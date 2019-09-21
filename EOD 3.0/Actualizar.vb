Imports System.Net
Imports System.IO
Imports System.Data
Imports System.ComponentModel
Imports EOD.datasetEOD
Imports System.Deployment.Application

Public Class Actualizar

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

    Dim WithEvents ADUpdateAsync As ApplicationDeployment

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

    Public Sub respaldoLocalBase()
        'respaldar data localmente
        Dim archivoTemporal As String = "C:\backups data\" + DateTime.Now.Year.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Day.ToString() + ".accdb"
        Dim rutaBaseDatos As String
        Try
            rutaBaseDatos = System.Deployment.Application.ApplicationDeployment.CurrentDeployment.DataDirectory & "\MASCARA REFERENCIA_VF.accdb"
            System.IO.File.Copy(rutaBaseDatos, archivoTemporal, True)
        Catch ex2 As Exception
            rutaBaseDatos = Application.StartupPath & "\MASCARA REFERENCIA_VF.accdb"
            System.IO.File.Copy(rutaBaseDatos, archivoTemporal, True)
        End Try
    End Sub

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
        Dim RemotePath As String = "ftp://" + ftpIP + "/datarancagua"
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

    Private Sub eliminaDataAnterior()

        bw.ReportProgress(33)
        Dim request As FtpWebRequest = DirectCast(WebRequest.Create("ftp://" + ftpIP + "/datarancagua"), FtpWebRequest)
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
            Dim requestFileDelete As FtpWebRequest = DirectCast(WebRequest.Create("ftp://" + ftpIP + "/datarancagua/" + archivoBorrar), FtpWebRequest)
            requestFileDelete.Credentials = New NetworkCredential(ftpUSER, ftpPASS)
            requestFileDelete.Method = WebRequestMethods.Ftp.DeleteFile
            Dim responseFileDelete As FtpWebResponse = DirectCast(requestFileDelete.GetResponse(), FtpWebResponse)
        End If
    End Sub

    Private Sub reportaEnBaseDatos()
        Dim exportacion As ExportacionesDataRow = dataset.ExportacionesData.NewExportacionesDataRow
        exportacion.FechaExportacion = DateTime.Now
        dataset.ExportacionesData.AddExportacionesDataRow(exportacion)
        ExportacionesDataTableAdapter = New datasetEODTableAdapters.ExportacionesDataTableAdapter
        ExportacionesDataTableAdapter.Update(dataset.ExportacionesData)

    End Sub

    Private Sub bw_DoWork(sender As Object, e As DoWorkEventArgs) Handles bw.DoWork
        'Crear copia de base de datos
        bw.ReportProgress(10)
        indiceTexto = 0
        copiaBaseDatos()

        'Comprimir copia con Winrar
        bw.ReportProgress(20)
        indiceTexto = 1
        comprimeCopiaBase()

        'Subir copia a FTP
        bw.ReportProgress(30)
        indiceTexto = 2
        cargaArchivoFTP()

        'Borrar archivo temporal
        bw.ReportProgress(60)
        borraArchivo(archivoTemporal)
        borraArchivo(archivoTemporalRAR)

        'Eliminar Data anterior de FTP
        bw.ReportProgress(70)
        eliminaDataAnterior()

        'Reportar carga en base de datos
        bw.ReportProgress(80)
        reportaEnBaseDatos()

        'Crea respaldo local
        bw.ReportProgress(90)
        indiceTexto = 3
        respaldoLocalBase()
    End Sub

    Private Sub bw_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bw.RunWorkerCompleted
        If e.Cancelled Then
            barraProg.Properties.Maximum = 0
            imgError.Visible = True
            Label8.Visible = True
            Label8.Text = "Operación cancelada"

        ElseIf e.Error IsNot Nothing Then
            barraProg.Properties.Maximum = 0
            MessageBox.Show("Excepción en el hilo de trabajo: " + e.Error.ToString())
            imgError.Visible = True
            Label8.Visible = True
            Label8.Text = "Error"
        Else
            'Desde el método DoWork
            barraProg.EditValue = 100

            'Lanzar worker actualización
            Label5.Visible = True
            img5.Visible = True
            img4.Image = DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/apply_16x16.png")
            BeginUpdate()


        End If
    End Sub


    Private Sub bw_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles bw.ProgressChanged

        Select Case indiceTexto
            Case 0
                label1.Visible = True
                img1.Visible = True
            Case 1
                Label2.Visible = True
                img2.Visible = True
                img1.Image = DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/apply_16x16.png")
            Case 2
                Label3.Visible = True
                img3.Visible = True
                img2.Image = DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/apply_16x16.png")
            Case 3
                Label4.Visible = True
                img4.Visible = True
                img3.Image = DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/apply_16x16.png")
        End Select

        barraProg.EditValue = e.ProgressPercentage
    End Sub

    Private Sub Actualizar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub BeginUpdate()
        ADUpdateAsync = ApplicationDeployment.CurrentDeployment
        ADUpdateAsync.UpdateAsync()
    End Sub


    Private Sub ADUpdateAsync_UpdateProgressChanged(ByVal sender As Object, ByVal e As DeploymentProgressChangedEventArgs) Handles ADUpdateAsync.UpdateProgressChanged
        Try
            Dim completado As Integer = e.BytesCompleted / 1024
            Dim total As Integer = e.BytesTotal / 1024
            Dim progressText As String = completado & "K de " & total & "K descargados - " & e.ProgressPercentage & "% completado"
            lblProgreso.Text = progressText
        Catch ex As Exception
            
        End Try
        
        barraProg.EditValue = e.ProgressPercentage
    End Sub


    Private Sub ADUpdateAsync_UpdateCompleted(ByVal sender As Object, ByVal e As AsyncCompletedEventArgs) Handles ADUpdateAsync.UpdateCompleted
        If (e.Cancelled) Then
            MessageBox.Show("La actualización a la última versión ha sido cancelada.")
            Exit Sub
        Else
            If (e.Error IsNot Nothing) Then
                imgError.Visible = True
                Label7.Visible = True
                Label7.Text = "Error"
                MessageBox.Show("ERROR: No se pudo instalar la última versión de la aplicación. Motivo: " + ControlChars.Lf + e.Error.Message + ControlChars.Lf + "Por favor, reporte este error a Supervisión.")
                Exit Sub
            End If
        End If

        Label8.Visible = True
        img7.Visible = True

        Dim dr As DialogResult = MessageBox.Show("Se ha actualizado la aplicación. ¿Desea reiniciar? (Si no reinicia ahora, la nueva versión no surtirá efecto hasta después de salir y volver a iniciar la aplicación nuevamente.)", "Reiniciar aplicación", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
        If (dr = System.Windows.Forms.DialogResult.OK) Then
            Application.Restart()
        End If
    End Sub

End Class