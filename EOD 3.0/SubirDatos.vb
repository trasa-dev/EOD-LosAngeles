Imports System.Net
Imports System.IO
Imports System.Data
Imports System.ComponentModel
Imports EOD.datasetEOD
Imports System.Threading


Public Class SubirDatos

    Dim objConfig As cIniArray = New cIniArray
    Dim rutaConfig As String = Application.StartupPath & "\config.ini"
    Dim ftpIP As String = objConfig.IniGet(rutaConfig, "ftp", "ip", "")
    Dim ftpUSER As String = objConfig.IniGet(rutaConfig, "ftp", "user", "")
    Dim ftpPASS As String = objConfig.IniGet(rutaConfig, "ftp", "pass", "")
    Dim idEquipo As String = objConfig.IniGet(rutaConfig, "encuestador", "idEquipo", "")
    Dim tiempo As DateTime = DateTime.Now
    Dim archivoTemporal As String = Application.StartupPath + "\\" + idEquipo + "-" + tiempo.Year.ToString() + "-" + tiempo.Month.ToString() + "-" + tiempo.Day.ToString() + ".accdb"
    Dim archivoComprimir As String = idEquipo + "-" + tiempo.Year.ToString() + "-" + tiempo.Month.ToString() + "-" + tiempo.Day.ToString() + ".accdb"
    Dim archivoTemporalRAR As String = idEquipo + "-" + tiempo.Year.ToString() + "-" + tiempo.Month.ToString() + "-" + tiempo.Day.ToString() + ".rar"
    Dim rutaBaseDatos As String = Application.LocalUserAppDataPath & "\MASCARA REFERENCIA_VF.accdb"

    Dim textosLabel As String() = {"Creando base de datos a exportar...", "Comprimiendo base de datos...", " Subiendo archivo a servidor...", "Borrando archivos temporales...", "Eliminando data anterior en servidor..."}
    Dim indiceTexto As Integer
    Dim dataset As datasetEOD

    Public Sub New()
        InitializeComponent()
        dataset = New datasetEOD

    End Sub

    Private Sub inicializarVariablesConf()
        ftpIP = objConfig.IniGet(rutaConfig, "ftp", "ip", "")
        ftpUSER = objConfig.IniGet(rutaConfig, "ftp", "user", "")
        ftpPASS = objConfig.IniGet(rutaConfig, "ftp", "pass", "")
        idEquipo = objConfig.IniGet(rutaConfig, "encuestador", "idEquipo", "")
        archivoTemporal = Application.StartupPath + "\" + idEquipo + "-" + tiempo.Year.ToString() + "-" + tiempo.Month.ToString() + "-" + tiempo.Day.ToString() + ".accdb"
    End Sub

    Private Function hayConexionInternet() As Boolean
        Try
            Dim host As IPHostEntry = Dns.GetHostEntry("www.google.com")
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Sub copiaBaseDatos()
        Try
            System.IO.File.Copy(rutaBaseDatos, archivoTemporal, True)
        Catch ex As Exception
            Try
                rutaBaseDatos = System.Deployment.Application.ApplicationDeployment.CurrentDeployment.DataDirectory & "\MASCARA REFERENCIA_VF.accdb"
                System.IO.File.Copy(rutaBaseDatos, archivoTemporal, True)
            Catch ex2 As Exception
                rutaBaseDatos = Application.StartupPath & "\MASCARA REFERENCIA_VF.accdb"
                System.IO.File.Copy(rutaBaseDatos, archivoTemporal, True)
            End Try
        End Try
    End Sub

    Public Sub comprimeCopiaBase()
        Dim argsWinrar As String = "a """ + archivoTemporalRAR + """ """ + archivoComprimir + """"
        Dim propProceso As New ProcessStartInfo()
        propProceso.FileName = "winrar.exe"
        propProceso.Arguments = argsWinrar
        Dim procWinrar As Process = Process.Start(propProceso)
        procWinrar.WaitForExit()
    End Sub

    Public Sub cargaArchivoFTP()
        Dim FilePath As String = archivoTemporalRAR
        Dim RemotePath As String = "ftp://" + ftpIP + "/dataparenas"
        Dim Login As String = ftpUSER
        Dim Password As String = ftpPASS

        Using fs As New FileStream(FilePath, FileMode.Open, FileAccess.Read, FileShare.Read)
            Dim url As String = Path.Combine(RemotePath, Path.GetFileName(FilePath))

            Dim ftp As FtpWebRequest = DirectCast(FtpWebRequest.Create(url), FtpWebRequest)
            ftp.Credentials = New NetworkCredential(Login, Password)
            ftp.KeepAlive = False
            ftp.Method = WebRequestMethods.Ftp.UploadFile
            ftp.UseBinary = True
            ftp.ContentLength = fs.Length
            Dim pesoArchivo As Integer = CInt(fs.Length)
            ftp.Proxy = Nothing
            fs.Position = 0

            Dim buffLength As Integer = 2048
            Dim buff As Byte() = New Byte(buffLength - 1) {}
            Dim contentLen As Integer

            Using strm As Stream = ftp.GetRequestStream()
                contentLen = fs.Read(buff, 0, buffLength)

                Dim j As Integer = 2048
                While contentLen <> 0
                    strm.Write(buff, 0, contentLen)
                    contentLen = fs.Read(buff, 0, buffLength)
                    j += 2048
                    Dim progreso As Integer = If(CInt(j * 100 / pesoArchivo) > 100, 100, CInt(j * 100 / pesoArchivo))
                    bw.ReportProgress(progreso)
                End While
            End Using
        End Using
    End Sub

    Private Sub borraArchivo(ByVal archivoTemporal As String)
        If System.IO.File.Exists(archivoTemporal) Then
            Try
                System.IO.File.Delete(archivoTemporal)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub bw_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bw.DoWork
        'Crear copia de base de datos
        indiceTexto = 0
        copiaBaseDatos()

        'Comprimir copia con Winrar
        indiceTexto = 1
        comprimeCopiaBase()

        'Subir copia a FTP
        indiceTexto = 2
        cargaArchivoFTP()

        'Borrar archivo temporal
        indiceTexto = 3
        borraArchivo(archivoTemporal)
        borraArchivo(archivoTemporalRAR)

        'Eliminar Data anterior de FTP
        indiceTexto = 4
        eliminaDataAnterior()

        'Reportar carga en base de datos
        reportaEnBaseDatos()
    End Sub

    Private Sub eliminaDataAnterior()

        bw.ReportProgress(33)
        Dim request As FtpWebRequest = DirectCast(WebRequest.Create("ftp://" + ftpIP + "/dataparenas"), FtpWebRequest)
        request.Credentials = New NetworkCredential(ftpUSER, ftpPASS)
        request.Method = WebRequestMethods.Ftp.ListDirectory

        Dim streamReader As New StreamReader(request.GetResponse().GetResponseStream())
        Dim archivoBorrar As String = ""
        Dim fileName As String = streamReader.ReadLine()
        Dim uploadedFile As String = idEquipo + "-" + tiempo.Year.ToString() + "-" + tiempo.Month.ToString() + "-" + tiempo.Day.ToString() + ".mdb"

        While fileName IsNot Nothing
            If fileName <> "." AndAlso fileName <> ".." Then
                Dim sinExtension As String = fileName.Split("."c)(0)
                If Integer.Parse(sinExtension.Split("-"c)(0)) = Integer.Parse(idEquipo) Then
                    If String.Compare(uploadedFile, fileName) > 0 Then
                        archivoBorrar = fileName
                    End If
                End If
            End If
            fileName = streamReader.ReadLine()
        End While
        bw.ReportProgress(66)
        request = Nothing
        streamReader = Nothing

        If archivoBorrar <> "" Then
            Dim requestFileDelete As FtpWebRequest = DirectCast(WebRequest.Create("ftp://" + ftpIP + "/dataparenas/" + archivoBorrar), FtpWebRequest)
            requestFileDelete.Credentials = New NetworkCredential(ftpUSER, ftpPASS)
            requestFileDelete.Method = WebRequestMethods.Ftp.DeleteFile
            Dim responseFileDelete As FtpWebResponse = DirectCast(requestFileDelete.GetResponse(), FtpWebResponse)
        End If
    End Sub

    Private Sub bw_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bw.RunWorkerCompleted
        If e.Cancelled Then
            barraProg.Properties.Maximum = 0
            label.Text = "Operación cancelada"
        ElseIf e.Error IsNot Nothing Then
            barraProg.Properties.Maximum = 0
            MessageBox.Show("Excepción en el hilo de trabajo: " + e.Error.ToString())
            label.Text = "Error"
        Else
            'Desde el método DoWork
            barraProg.EditValue = 100
            If MessageBox.Show("Datos enviados correctamente", "Envío al servidor", MessageBoxButtons.OK, MessageBoxIcon.Information) = Windows.Forms.DialogResult.OK Then
                Me.Dispose()
            End If

        End If
    End Sub

    Private Sub bw_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles bw.ProgressChanged
        label.Text = textosLabel(indiceTexto)
        barraProg.EditValue = e.ProgressPercentage
    End Sub

    Private Sub SubirDatos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If hayConexionInternet() Then
                'Borrar temporal si existe
                If File.Exists(archivoTemporal) Then
                    Try
                        File.Delete(archivoTemporal)
                    Catch ex As IOException
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return
                    End Try
                End If

                'Obtener datos de conexión
                inicializarVariablesConf()
                barraProg.Properties.Maximum = 100
                'bw = New BackgroundWorker
                bw.WorkerSupportsCancellation = True
                bw.WorkerReportsProgress = True
                bw.RunWorkerAsync()
            Else
                MessageBox.Show("No hay conexión a Internet", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Dispose()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub reportaEnBaseDatos()
        Dim exportacion As ExportacionesDataRow = dataset.ExportacionesData.NewExportacionesDataRow
        exportacion.FechaExportacion = DateTime.Now
        dataset.ExportacionesData.AddExportacionesDataRow(exportacion)
        ExportacionesDataTableAdapter = New datasetEODTableAdapters.ExportacionesDataTableAdapter
        ExportacionesDataTableAdapter.Update(dataset.ExportacionesData)

    End Sub
End Class