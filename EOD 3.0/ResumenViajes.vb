Imports EOD.datasetEOD

Public Class ResumenViajes

    Private hogar As Integer
    Private persona As Integer
    Private nombrePersona As String
    Private tipoEncuesta As Integer
    Private bloqueaRecarga As Boolean = False
    Private primeraCarga As Boolean = True

    Public Sub New(ByVal hogar As Integer, ByVal persona As Integer, ByVal nombrePersona As String, ByVal tipoEncuesta As Integer)
        InitializeComponent()

        Me.hogar = hogar
        Me.persona = persona
        Me.nombrePersona = nombrePersona
        Me.tipoEncuesta = tipoEncuesta

        Me.Text = "Viajes de " & Me.nombrePersona & " del hogar " & Me.hogar
    End Sub

    Private Sub ResumenViajes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ResumenViajesBindingSource.SuspendBinding()
        ResumenEtapasBindingSource.SuspendBinding()
        cargaDatosBackground.RunWorkerAsync()

        Select Case tipoEncuesta
            Case 1
                rgTipoDia.SelectedIndex = 0
                rgTipoDia.Properties.Items(1).Enabled = False
                rgTipoDia.Properties.Items(2).Enabled = False
            Case 2
                rgTipoDia.SelectedIndex = 1
                rgTipoDia.Properties.Items(0).Enabled = False
                rgTipoDia.Properties.Items(2).Enabled = False
            Case 3
                rgTipoDia.SelectedIndex = 2
                rgTipoDia.Properties.Items(0).Enabled = False
                rgTipoDia.Properties.Items(1).Enabled = False
            Case 4
                rgTipoDia.SelectedIndex = 0
        End Select

    End Sub

    Private Sub gridViewViajes_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gridViewViajes.FocusedRowChanged
        If Not Me.gridViewViajes.GetSelectedRows Is Nothing Then

            Me.gridEtapas.ForceInitialize()

            Try
                Dim viaje As Integer = Me.gridViewViajes.GetFocusedRowCellValue("Viaje").ToString()
                Dim tipoDia As Integer = 1

                Select Case tipoEncuesta
                    Case 2
                        tipoDia = 2
                    Case 3
                        tipoDia = 3
                    Case Else
                        tipoDia = 1
                End Select

                'Filtro gridViewEtapas
                Me.ResumenEtapasBindingSource.Filter = "Hogar = " & Me.hogar & " and Persona = " & Me.persona & " and viaje = " & viaje & " and diaviaje = " & tipoDia

                actualizaVistaSecuencia()
            Catch ex As Exception

            End Try

        Else
        End If
    End Sub

    Private Sub btnModificarViaje_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnModificarViaje.ItemClick
        Dim viaje As Integer = Me.gridViewViajes.GetFocusedRowCellValue("Viaje").ToString()

        Dim nuevaVentana As ModificarViaje = New ModificarViaje(Me.hogar, Me.persona, viaje, Me.nombrePersona, Me.rgTipoDia.EditValue, tipoEncuesta)
        nuevaVentana.Show()
    End Sub

    Private Sub ResumenViajes_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        If Not bloqueaRecarga Then
            If Not cargaDatosBackground.IsBusy Then
                ResumenViajesBindingSource.SuspendBinding()
                ResumenEtapasBindingSource.SuspendBinding()
                cargaDatosBackground.RunWorkerAsync()
            End If
        Else
            bloqueaRecarga = False
        End If
        
    End Sub

    Private Sub cargaDatosBackground_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles cargaDatosBackground.DoWork
        Me.ResumenEtapasTableAdapter.FillBy(Me.datasetEOD.ResumenEtapas, hogar, persona)
        Me.ResumenViajesTableAdapter.FillBy(Me.datasetEOD.ResumenViajes, hogar, persona)
        PersonaTableAdapter.Fill(Me.datasetEOD.Persona)

       

    End Sub

    Private Sub actualizaVistaSecuencia()


        'Carga tab con numero de etapas correcto
        Dim etapas As String = Me.gridViewViajes.GetFocusedRowCellValue("Etapas").ToString()
        panelEtapas.SelectedPageIndex = etapas - 1

        Select Case etapas
            Case 1
                Me.tab2etapas.PageVisible = False
                Me.tab3etapas.PageVisible = False

                txtInicioViajeE1.Text = "Calle 1: " + Me.gridViewViajes.GetFocusedRowCellValue("NombreCalle1Origen").ToString() + vbCrLf + _
                            "Calle 2: " + Me.gridViewViajes.GetFocusedRowCellValue("NumeroOCalle2Origen").ToString() + vbCrLf + _
                            "Hito: " + Me.gridViewViajes.GetFocusedRowCellValue("HitoOrigen").ToString() + vbCrLf + _
                            "Comuna: " + Me.gridViewViajes.GetFocusedRowCellValue("ComunaOri_Comuna").ToString()

                txtFinViajeE1.Text = "Calle 1: " + Me.gridViewViajes.GetFocusedRowCellValue("NombreCalle1Destino").ToString() + vbCrLf + _
                                    "Calle 2: " + Me.gridViewViajes.GetFocusedRowCellValue("NumeroOCalle2Destino").ToString() + vbCrLf + _
                                    "Hito: " + Me.gridViewViajes.GetFocusedRowCellValue("HitoDestino").ToString() + vbCrLf + _
                                    "Comuna: " + Me.gridViewViajes.GetFocusedRowCellValue("ComunaDes_Comuna").ToString()

                txtHoraIniViajeE1.Text = "Hora: " + Convert.ToDateTime(Me.gridViewViajes.GetFocusedRowCellValue("HoraIni")).ToString("HH:mm")

                txtHoraFinViajeE1.Text = "Hora: " + Convert.ToDateTime(Me.gridViewViajes.GetFocusedRowCellValue("Horafin")).ToString("HH:mm")

                Dim filaEtapa As Integer = Me.gridViewEtapas.LocateByValue("Etapa", 1, Nothing)
                gridViewEtapas.FocusedRowHandle = filaEtapa

                txtEtapaE1.Text = "Calle 1: " + Me.gridViewEtapas.GetFocusedRowCellValue("NombreCalle1Destino").ToString() + vbCrLf + _
                                     "Calle 2: " + Me.gridViewEtapas.GetFocusedRowCellValue("NumeroOCalle2Destino").ToString() + vbCrLf + _
                                     "Hito: " + Me.gridViewEtapas.GetFocusedRowCellValue("HitoDestino").ToString() + vbCrLf + _
                                     "Comuna: " + Me.gridViewEtapas.GetFocusedRowCellValue("ComunaDes_Comuna").ToString()

                Dim strModo As String = Me.gridViewEtapas.GetFocusedRowCellValue("Modo").ToString()

                txtMedioE1.Text = Split(strModo, ".")(1)

                Dim intModo As Integer = Split(strModo, ".")(0)
                intModo -= 1

                imgTransporteE1.Image = imageCollectionModos.Images.Item(intModo)

            Case 2
                Me.tab1etapa.PageVisible = False
                Me.tab3etapas.PageVisible = False

                txtInicioViajeE2.Text = "Calle 1: " + Me.gridViewViajes.GetFocusedRowCellValue("NombreCalle1Origen").ToString() + vbCrLf + _
                            "Calle 2: " + Me.gridViewViajes.GetFocusedRowCellValue("NumeroOCalle2Origen").ToString() + vbCrLf + _
                            "Hito: " + Me.gridViewViajes.GetFocusedRowCellValue("HitoOrigen").ToString() + vbCrLf + _
                            "Comuna: " + Me.gridViewViajes.GetFocusedRowCellValue("ComunaOri_Comuna").ToString()

                txtFinViajeE2.Text = "Calle 1: " + Me.gridViewViajes.GetFocusedRowCellValue("NombreCalle1Destino").ToString() + vbCrLf + _
                                    "Calle 2: " + Me.gridViewViajes.GetFocusedRowCellValue("NumeroOCalle2Destino").ToString() + vbCrLf + _
                                    "Hito: " + Me.gridViewViajes.GetFocusedRowCellValue("HitoDestino").ToString() + vbCrLf + _
                                    "Comuna: " + Me.gridViewViajes.GetFocusedRowCellValue("ComunaDes_Comuna").ToString()

                txtHoraIniViajeE2.Text = "Hora: " + Convert.ToDateTime(Me.gridViewViajes.GetFocusedRowCellValue("HoraIni")).ToString("HH:mm")

                txtHoraFinViajeE2.Text = "Hora: " + Convert.ToDateTime(Me.gridViewViajes.GetFocusedRowCellValue("Horafin")).ToString("HH:mm")

                'ETAPA 1
                Dim filaEtapa As Integer = Me.gridViewEtapas.LocateByValue("Etapa", 1, Nothing)
                gridViewEtapas.FocusedRowHandle = 0

                txtEtapa1E2.Text = "Calle 1: " + Me.gridViewEtapas.GetRowCellValue(0, "NombreCalle1Destino").ToString() + vbCrLf + _
                 "Calle 2: " + Me.gridViewEtapas.GetRowCellValue(0, "NumeroOCalle2Destino").ToString() + vbCrLf + _
                 "Hito: " + Me.gridViewEtapas.GetRowCellValue(0, "HitoDestino").ToString() + vbCrLf + _
                 "Comuna: " + Me.gridViewEtapas.GetRowCellValue(0, "ComunaDes_Comuna").ToString()

                Dim strModo As String = Me.gridViewEtapas.GetFocusedRowCellValue("Modo").ToString()

                txtMedio1E2.Text = Split(strModo, ".")(1)

                Dim intModo As Integer = Split(strModo, ".")(0)
                intModo -= 1

                imgTransporte1E2.Image = imageCollectionModos.Images.Item(intModo)

                'ETAPA 2
                filaEtapa = Me.gridViewEtapas.LocateByValue("Etapa", 2, Nothing)
                gridViewEtapas.FocusedRowHandle = 1

                txtEtapa2E2.Text = "Calle 1: " + Me.gridViewEtapas.GetRowCellValue(1, "NombreCalle1Destino").ToString() + vbCrLf + _
                 "Calle 2: " + Me.gridViewEtapas.GetRowCellValue(1, "NumeroOCalle2Destino").ToString() + vbCrLf + _
                 "Hito: " + Me.gridViewEtapas.GetRowCellValue(1, "HitoDestino").ToString() + vbCrLf + _
                 "Comuna: " + Me.gridViewEtapas.GetRowCellValue(1, "ComunaDes_Comuna").ToString()

                strModo = Me.gridViewEtapas.GetFocusedRowCellValue("Modo").ToString()

                txtMedio2E2.Text = Split(strModo, ".")(1)

                intModo = Split(strModo, ".")(0)
                intModo -= 1

                imgTransporte2E2.Image = imageCollectionModos.Images.Item(intModo)
            Case 3
                Me.tab1etapa.PageVisible = False
                Me.tab2etapas.PageVisible = False

                txtInicioViajeE3.Text = "Calle 1: " + Me.gridViewViajes.GetFocusedRowCellValue("NombreCalle1Origen").ToString() + vbCrLf +
                            "Calle 2: " + Me.gridViewViajes.GetFocusedRowCellValue("NumeroOCalle2Origen").ToString() + vbCrLf +
                            "Hito: " + Me.gridViewViajes.GetFocusedRowCellValue("HitoOrigen").ToString() + vbCrLf +
                            "Comuna: " + Me.gridViewViajes.GetFocusedRowCellValue("ComunaOri_Comuna").ToString()

                txtFinViajeE3.Text = "Calle 1: " + Me.gridViewViajes.GetFocusedRowCellValue("NombreCalle1Destino").ToString() + vbCrLf +
                                    "Calle 2: " + Me.gridViewViajes.GetFocusedRowCellValue("NumeroOCalle2Destino").ToString() + vbCrLf +
                                    "Hito: " + Me.gridViewViajes.GetFocusedRowCellValue("HitoDestino").ToString() + vbCrLf +
                                    "Comuna: " + Me.gridViewViajes.GetFocusedRowCellValue("ComunaDes_Comuna").ToString()

                txtHoraIniViajeE3.Text = "Hora: " + Convert.ToDateTime(Me.gridViewViajes.GetFocusedRowCellValue("HoraIni")).ToString("HH:mm")

                txtHoraFinViajeE3.Text = "Hora: " + Convert.ToDateTime(Me.gridViewViajes.GetFocusedRowCellValue("Horafin")).ToString("HH:mm")

                'ETAPA 1
                Dim filaEtapa As Integer = Me.gridViewEtapas.LocateByValue("Etapa", 1, Nothing)
                gridViewEtapas.FocusedRowHandle = 0

                txtEtapa1E3.Text = "Calle 1: " + Me.gridViewEtapas.GetRowCellValue(0, "NombreCalle1Destino").ToString() + vbCrLf +
                 "Calle 2: " + Me.gridViewEtapas.GetRowCellValue(0, "NumeroOCalle2Destino").ToString() + vbCrLf +
                 "Hito: " + Me.gridViewEtapas.GetRowCellValue(0, "HitoDestino").ToString() + vbCrLf +
                 "Comuna: " + Me.gridViewEtapas.GetRowCellValue(0, "ComunaDes_Comuna").ToString()

                Dim strModo As String = Me.gridViewEtapas.GetFocusedRowCellValue("Modo").ToString()

                txtMedio1E3.Text = Split(strModo, ".")(1)

                Dim intModo As Integer = Split(strModo, ".")(0)
                intModo -= 1

                imgTransporte1E3.Image = imageCollectionModos.Images.Item(intModo)

                'ETAPA 2
                filaEtapa = Me.gridViewEtapas.LocateByValue("Etapa", 2, Nothing)
                gridViewEtapas.FocusedRowHandle = 1

                txtEtapa2E3.Text = "Calle 1: " + Me.gridViewEtapas.GetRowCellValue(1, "NombreCalle1Destino").ToString() + vbCrLf +
                 "Calle 2: " + Me.gridViewEtapas.GetRowCellValue(1, "NumeroOCalle2Destino").ToString() + vbCrLf +
                 "Hito: " + Me.gridViewEtapas.GetRowCellValue(1, "HitoDestino").ToString() + vbCrLf +
                 "Comuna: " + Me.gridViewEtapas.GetRowCellValue(1, "ComunaDes_Comuna").ToString()

                strModo = Me.gridViewEtapas.GetFocusedRowCellValue("Modo").ToString()

                txtMedio2E3.Text = Split(strModo, ".")(1)

                intModo = Split(strModo, ".")(0)
                intModo -= 1

                imgTransporte2E3.Image = imageCollectionModos.Images.Item(intModo)

                'ETAPA 3
                filaEtapa = Me.gridViewEtapas.LocateByValue("Etapa", 3, Nothing)
                gridViewEtapas.FocusedRowHandle = 1

                txtEtapa3E3.Text = "Calle 1: " + Me.gridViewEtapas.GetRowCellValue(1, "NombreCalle1Destino").ToString() + vbCrLf +
                 "Calle 2: " + Me.gridViewEtapas.GetRowCellValue(1, "NumeroOCalle2Destino").ToString() + vbCrLf +
                 "Hito: " + Me.gridViewEtapas.GetRowCellValue(1, "HitoDestino").ToString() + vbCrLf +
                 "Comuna: " + Me.gridViewEtapas.GetRowCellValue(1, "ComunaDes_Comuna").ToString()

                strModo = Me.gridViewEtapas.GetFocusedRowCellValue("Modo").ToString()

                txtMedio3E3.Text = Split(strModo, ".")(1)

                intModo = Split(strModo, ".")(0)
                intModo -= 1

                imgTransporte3E3.Image = imageCollectionModos.Images.Item(intModo)
        End Select
    End Sub

    Private Sub btnIngresarViaje_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnIngresarViaje.ItemClick
        Dim persona As PersonaRow = Me.datasetEOD.Persona.FindByHogarPersona(Me.hogar, Me.persona)
        Dim maxViaje As Integer

        Select Case rgTipoDia.EditValue
            Case 1
                maxViaje = persona.ViajesLab
                Dim ventanaIngresoViajes As New IngresoViajes(hogar, Me.persona, maxViaje + 1, nombrePersona, 1, tipoEncuesta)
                ventanaIngresoViajes.Show()
            Case 2
                maxViaje = persona.ViajesSab
                Dim ventanaIngresoViajes As New IngresoViajes(hogar, Me.persona, maxViaje + 1, nombrePersona, 2, tipoEncuesta)
                ventanaIngresoViajes.Show()
            Case 3
                maxViaje = persona.ViajesDom
                Dim ventanaIngresoViajes As New IngresoViajes(hogar, Me.persona, maxViaje + 1, nombrePersona, 3, tipoEncuesta)
                ventanaIngresoViajes.Show()
        End Select

        
    End Sub

    Private Sub cargaDatosBackground_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles cargaDatosBackground.RunWorkerCompleted
        ResumenViajesBindingSource.ResumeBinding()
        ResumenEtapasBindingSource.ResumeBinding()

        Dim tipoDia As Integer = tipoEncuesta
        If tipoEncuesta = 4 Then
            tipoDia = 1
        End If

        Try
            Me.ResumenViajesBindingSource.Filter = "Hogar = " & Me.hogar & " and Persona = " & Me.persona & " and diaviaje = " & tipoDia
            Dim viaje As Integer = Me.gridViewViajes.GetFocusedRowCellValue("Viaje").ToString()
            Me.ResumenEtapasBindingSource.Filter = "Hogar = " & Me.hogar & " and Persona = " & Me.persona & " and diaviaje = " & tipoDia & " and viaje = " & viaje
        Catch ex As Exception
        End Try

        Try
            actualizaVistaSecuencia()
        Catch ex As Exception
        End Try

    End Sub

    Private Sub rgTipoDia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles rgTipoDia.SelectedIndexChanged
        If primeraCarga Then
            primeraCarga = False
        Else
            Dim tipoDia As Integer = rgTipoDia.SelectedIndex + 1
            Try
                'Me.ResumenEtapasTableAdapter.FillBy(datasetEOD.ResumenEtapas, hogar, persona, tipoDia)
                'Me.ResumenViajesTableAdapter.FillBy(datasetEOD.ResumenViajes, hogar, persona, tipoDia)
                Me.ResumenViajesBindingSource.Filter = "Hogar = " & Me.hogar & " and Persona = " & Me.persona & " and diaviaje = " & tipoDia
                If Me.gridViewViajes.RowCount > 0 Then
                    Dim viaje As Integer = Me.gridViewViajes.GetFocusedRowCellValue("Viaje").ToString()
                    Me.ResumenEtapasBindingSource.Filter = "Hogar = " & Me.hogar & " and Persona = " & Me.persona & " and diaviaje = " & tipoDia & " and viaje = " & viaje
                    actualizaVistaSecuencia()
                Else
                    bloqueaRecarga = True
                    MessageBox.Show("El día seleccionado no tiene viajes", "Resumen Viajes", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Catch ex As Exception


            End Try
        End If
    End Sub

    Private Sub ResumenViajes_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        Me.datasetEOD.Clear()
        Me.datasetEOD1.Clear()
        releaseObject(datasetEOD)
        releaseObject(datasetEOD1)
    End Sub

    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub
End Class