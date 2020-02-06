Imports System.Data.OleDb
Imports DevExpress.XtraEditors
Imports EOD.datasetEOD
Imports EOD.datasetEODTableAdapters

Public Class ModificarViaje

    Private idFolio As Integer
    Private idDiaViajes As Integer
    Private idPersona As Integer
    Private idViaje As Integer
    Private tipoEncuesta As Integer
    Private nombrePersona As String
    Private comunaHogar As Integer
    Private nombreCalleHogar As String
    Private numeroHogar As String
    Private manzanaHogar As Integer
    Private actividadString As String
    Private persona As PersonaRow
    Private validadorViaje As ValidaViajeRow
    Private validadorEtapa1 As ValidaEtapaRow
    Private validadorEtapa2 As ValidaEtapaRow
    Private validadorEtapa3 As ValidaEtapaRow

    Private viaje As ViajeRow
    Private viajeAnterior As ViajeRow
    Private viajeSiguiente As ViajeRow

    Private etapa1 As EtapaRow
    Private etapa2 As EtapaRow
    Private etapa3 As EtapaRow
    Private etapaViajeSiguiente As EtapaRow

    Private trabajoDeclarado As Boolean = False
    Private estudioDeclarado As Boolean = False
    Private mismaManzanaDestino As Boolean = False
    Private primeraCarga As Boolean = True
    Private primeraCargaDestino As Boolean = True

    Private agregaEtapa2 As Boolean = False
    Private agregaEtapa3 As Boolean = False

    Private cargaCompleta As Boolean = False

    Public Sub New(ByVal idFolio As Integer, ByVal idPersona As Integer, ByVal idViaje As Integer, ByVal nombrePersona As String, ByVal idDiaViajes As Integer, ByVal tipoEncuesta As Integer)
        InitializeComponent()

        Me.idFolio = idFolio
        Me.idPersona = idPersona
        Me.idViaje = idViaje
        Me.idDiaViajes = idDiaViajes
        Me.nombrePersona = nombrePersona
        Me.tipoEncuesta = tipoEncuesta

    End Sub

    Private Sub ModificarViaje_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'datasetEOD.DondeEstaciona' Puede moverla o quitarla según sea necesario.
        Me.DondeEstacionaTableAdapter.Fill(Me.datasetEOD.DondeEstaciona)
        'TODO: esta línea de código carga datos en la tabla 'datasetEOD.EstacionamientoBicicleta' Puede moverla o quitarla según sea necesario.
        Me.EstacionamientoBicicletaTableAdapter.Fill(Me.datasetEOD.EstacionamientoBicicleta)
        'TODO: esta línea de código carga datos en la tabla 'datasetEOD.Muelle' Puede moverla o quitarla según sea necesario.
        Me.MuelleTableAdapter.Fill(Me.datasetEOD.Muelle)

        Me.PersonaTableAdapter = New PersonaTableAdapter
        Me.ViajeTableAdapter = New ViajeTableAdapter
        Me.EtapaTableAdapter = New EtapaTableAdapter
        Me.ActividadTableAdapter = New ActividadTableAdapter
        Me.PersonaTableAdapter.FillByHogar(datasetEOD.Persona, Me.idFolio)
        Me.ActividadTableAdapter.Fill(datasetEOD.Actividad)
        Me.ViajeTableAdapter.FillByHogarPersonaDiaViaje(datasetEOD.Viaje, Me.idFolio, Me.idPersona, Me.idDiaViajes)
        Me.EtapaTableAdapter.FillByHogarPersonaViajeDiaViaje(datasetEOD.Etapa, Me.idFolio, Me.idPersona, Me.idViaje, Me.idDiaViajes)

        persona = datasetEOD.Persona.FindByHogarPersona(idFolio, idPersona)
        validadorViaje = datasetEOD.ValidaViaje.FindByHogarViajePersonaDiaViaje(idFolio, idViaje, idPersona, Me.idDiaViajes)
        validadorEtapa1 = datasetEOD.ValidaEtapa.FindByHogarEtapaViajePersonaDiaViaje(idFolio, 1, idViaje, idPersona, Me.idDiaViajes)
        validadorEtapa2 = datasetEOD.ValidaEtapa.FindByHogarEtapaViajePersonaDiaViaje(idFolio, 2, idViaje, idPersona, Me.idDiaViajes)
        validadorEtapa3 = datasetEOD.ValidaEtapa.FindByHogarEtapaViajePersonaDiaViaje(idFolio, 3, idViaje, idPersona, Me.idDiaViajes)
        If validadorViaje Is Nothing Then
            validadorViaje = datasetEOD.ValidaViaje.NewValidaViajeRow
        End If

        If persona.Actividad.Length = 1 Then
            Dim actividad As datasetEOD.ActividadRow = datasetEOD.Actividad.FindByID(Integer.Parse(persona.Actividad))
            actividadString = actividad.Actividad.Split(".")(1).Trim.ToLower
        ElseIf persona.Actividad.Length > 1 Then
            Dim actividades As String() = persona.Actividad.Split(",")

            Dim actividad As String
            For Each actividad In actividades
                If actividadString = "" Then
                    actividadString = datasetEOD.Actividad.FindByID(actividad).Actividad.Split(".")(1).Trim.ToLower
                Else
                    actividadString = actividadString & ", " & datasetEOD.Actividad.FindByID(actividad).Actividad.Split(".")(1).Trim.ToLower
                End If
            Next
        End If

        Me.Enabled = False

        Me.Text = "Modificando viaje " & Me.idViaje & " de " & Me.nombrePersona & ", " & actividadString & ", del hogar " & Me.idFolio

        Me.viaje = datasetEOD.Viaje.FindByHogarPersonaViajeDiaViaje(Me.idFolio, Me.idPersona, Me.idViaje, Me.idDiaViajes)
        Me.etapa1 = datasetEOD.Etapa.FindByHogarEtapaViajePersonaDiaViaje(Me.idFolio, 1, Me.idViaje, Me.idPersona, Me.idDiaViajes)
        Me.etapa2 = datasetEOD.Etapa.FindByHogarEtapaViajePersonaDiaViaje(Me.idFolio, 2, Me.idViaje, Me.idPersona, Me.idDiaViajes)
        Me.etapa3 = datasetEOD.Etapa.FindByHogarEtapaViajePersonaDiaViaje(Me.idFolio, 3, Me.idViaje, Me.idPersona, Me.idDiaViajes)

        If Me.idViaje = 1 Then
            Me.tabsInicioViaje.SelectedTabPageIndex = 0
            Me.tabViajeAnterior.PageVisible = False
            Me.tabPrimerViaje.PageVisible = True
        Else
            Me.tabsInicioViaje.SelectedTabPageIndex = 1
            Me.tabViajeAnterior.PageVisible = True
            Me.tabPrimerViaje.PageVisible = False
        End If

        cargaDatosViajeBackground.RunWorkerAsync()

    End Sub

    Private Sub lkpComunaOrigen_EditValueChanged(sender As Object, e As EventArgs) Handles lkpComunaOrigen.EditValueChanged

        Dim comuna As Integer

        If lkpComunaOrigen.EditValue IsNot Nothing AndAlso lkpComunaOrigen.EditValue.ToString <> "" Then
            comuna = lkpComunaOrigen.EditValue
        End If

        Me.spcCallesPrimerViaje.Visible = False
        Me.lblComunaOrigenOtra.Visible = False
        Me.txtComunaOrigenOtra.Visible = False

        Select Case comuna
            Case 1
                Me.spcCallesPrimerViaje.Visible = True
                Me.spcCallesPrimerViaje.CollapsePanel = DevExpress.XtraEditors.SplitCollapsePanel.Panel2
                Me.spcCallesPrimerViaje.Collapsed = True
                Me.lblComunaOrigenOtra.Visible = True
                Me.txtComunaOrigenOtra.Visible = True
            Case 2
                Me.spcCallesPrimerViaje.Visible = True
                Me.spcCallesPrimerViaje.CollapsePanel = DevExpress.XtraEditors.SplitCollapsePanel.Panel1
                Me.spcCallesPrimerViaje.Collapsed = True
        End Select
    End Sub

    Private Sub lkpComunaDestino_EditValueChanged(sender As Object, e As EventArgs) Handles lkpComunaDestino.EditValueChanged
        Dim comuna As Integer

        If lkpComunaDestino.EditValue IsNot Nothing AndAlso lkpComunaDestino.EditValue.ToString <> "" Then
            comuna = lkpComunaDestino.EditValue
        End If
        Me.spcCallesDestino.Visible = False
        Me.lblComunaDestinoOtra.Visible = False
        Me.txtComunaDestinoOtra.Visible = False

        Select Case comuna
            Case 1
                Me.spcCallesDestino.Visible = True
                Me.spcCallesDestino.CollapsePanel = DevExpress.XtraEditors.SplitCollapsePanel.Panel2
                Me.spcCallesDestino.Collapsed = True
                Me.lblComunaDestinoOtra.Visible = True
                Me.txtComunaDestinoOtra.Visible = True
            Case 2
                Me.spcCallesDestino.Visible = True
                Me.spcCallesDestino.CollapsePanel = DevExpress.XtraEditors.SplitCollapsePanel.Panel1
                Me.spcCallesDestino.Collapsed = True
        End Select
    End Sub

    Private Sub lkpTransporte1_EditValueChanged(sender As Object, e As EventArgs) Handles lkpTransporte1.EditValueChanged

        Dim opTransporte1 As Integer
        Dim opTransporte2 As Integer
        Me.gcLugarBajadaEtapa1.Visible = True

        ' Asigna valores de modos 1 y 2
        If lkpTransporte1.EditValue IsNot Nothing AndAlso lkpTransporte1.EditValue.ToString <> "" Then
            opTransporte1 = lkpTransporte1.EditValue
        End If

        If lkpTransporte2.EditValue IsNot Nothing AndAlso lkpTransporte2.EditValue.ToString <> "" Then
            opTransporte2 = lkpTransporte2.EditValue
        End If

        ' Crea validador de etapa 1
        If opTransporte1 > 0 AndAlso validadorEtapa1 Is Nothing Then
            validadorEtapa1 = datasetEOD.ValidaEtapa.NewValidaEtapaRow
        End If

        ' Muestra preguntas de etapa si no es a pie
        If opTransporte1 > 0 AndAlso opTransporte1 <> 7 Then
            Me.tabTransporte1.PageVisible = True
            Me.lkpTransporte2.Visible = True
            Me.lblTransporte2.Visible = True
            Me.DondeSeBajoE1BindingSource.Filter = "id > 0 "

        Else
            ' Viaje a pie, bloquea etapa 2
            Me.lkpTransporte2.EditValue = -1
            Me.lkpTransporte2.Visible = False
            Me.lblTransporte2.Visible = False
        End If

        Me.x_etapa1.Text = "0"
        Me.y_etapa1.Text = "0"

        ' Filtrar lugar bajada si hay etapa 2
        If opTransporte2 > 0 Then
            Me.DondeSeBajoE1BindingSource.Filter = "id > 1 "
        Else
            Me.DondeSeBajoE1BindingSource.Filter = "id > 0 "
        End If

        Select Case opTransporte1
            Case 1, 5, 9
                Me.FormaPagoTableAdapter.Fill(datasetEOD.FormaPago)
                Me.ViajaComoTableAdapter.Fill(datasetEOD.ViajaComo)
                Me.tabsEtapa1.Visible = True
                Me.tabsEtapa1.SelectedTabPage = tabsEtapa1.TabPages(0)
            Case 2, 10, 11, 12
                Me.TipoTarifaTableAdapter.Fill(datasetEOD.TipoTarifa)
                Me.tabsEtapa1.Visible = True
                Me.tabsEtapa1.SelectedTabPage = tabsEtapa1.TabPages(2)
            Case 3, 4
                Me.tabsEtapa1.Visible = True
                Me.tabsEtapa1.SelectedTabPage = tabsEtapa1.TabPages(4)
            Case 6
                Me.tabsEtapa1.Visible = True
                Me.tabsEtapa1.SelectedTabPage = tabsEtapa1.TabPages(3)
            Case 7
                Me.tabsEtapa1.Visible = False
                Me.gcLugarBajadaEtapa1.Visible = False
                Me.x_etapa1.Text = Me.x_destino.Text
                Me.y_etapa1.Text = Me.y_destino.Text
            Case 8
                Me.PropiedadBicicletaTableAdapter.Fill(datasetEOD.PropiedadBicicleta)
                Me.tabsEtapa1.Visible = True
                Me.tabsEtapa1.SelectedTabPage = tabsEtapa1.TabPages(1)
            Case 13
                Me.tabsEtapa1.Visible = True
                Me.gcLugarBajadaEtapa1.Visible = False
                Me.tabsEtapa1.SelectedTabPage = tabsEtapa1.TabPages(5)
            Case 14
                Me.tabsEtapa1.Visible = True
                Me.gcLugarBajadaEtapa1.Visible = False
                Me.tabsEtapa1.SelectedTabPage = tabsEtapa1.TabPages(6)
        End Select

    End Sub

    Private Sub lkpCalle1Origen_EditValueChanged(sender As Object, e As EventArgs) Handles lkpCalle1Origen.EditValueChanged

        If lkpCalle1Origen.EditValue IsNot Nothing AndAlso Me.lkpCalle1Origen.EditValue.ToString <> "" Then
            Dim calleQuery As String = Me.lkpCalle1Origen.EditValue.ToString '.Replace("'", ControlChars.Quote)
            ConsultaCalle2OrigenTableAdapter.FillBy(datasetEOD.ConsultaCalle2Origen, calleQuery)
        End If

    End Sub

    Private Sub lkpHitoOrigen_EditValueChanged(sender As Object, e As EventArgs) Handles lkpHitoOrigen.EditValueChanged
        If lkpHitoOrigen.EditValue IsNot Nothing AndAlso lkpHitoOrigen.EditValue.ToString <> "" Then
            Dim edit As GridLookUpEdit = TryCast(sender, GridLookUpEdit)
            Dim row As DataRowView = TryCast(edit.Properties.GetRowByKeyValue(edit.EditValue), DataRowView)
            If Not row Is Nothing Then
                Me.x_origen.Text = row.Item("x")
                Me.y_origen.Text = row.Item("y")
            End If


            Dim objConn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\MASCARA REFERENCIA_VF.accdb")
            objConn.Open()

            Dim objCommand As New OleDbCommand("select hitomanzana from hito where hito = ?", objConn)
            Dim parametro1 As New OleDbParameter("hito", Me.lkpHitoOrigen.EditValue)
            objCommand.Parameters.Add(parametro1)

            Dim objAdapter As New OleDbDataAdapter(objCommand)
            Dim objDataSet As New DataSet("ManzanasOrigen")

            For i As Integer = 0 To 3
                If Not Me.lkpManzanaOrigen.Properties.Columns.GetVisibleColumn(i) Is Nothing Then
                    Me.lkpManzanaOrigen.Properties.Columns.Remove(Me.lkpManzanaOrigen.Properties.Columns.GetVisibleColumn(i))
                End If
            Next

            Try
                objAdapter.Fill(objDataSet, "ManzanasOrigen")
                Dim objTabla As DataTable = objdataset.Tables("ManzanasOrigen")
                Me.lkpManzanaOrigen.Properties.DataSource = objTabla
                Me.lkpManzanaOrigen.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("hitomanzana", "hitomanzana", 5, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
                Me.lkpManzanaOrigen.Properties.DisplayMember = "hitomanzana"
                Me.lkpManzanaOrigen.Properties.ValueMember = "hitomanzana"
                Me.lkpManzanaOrigen.ItemIndex = 0
            Catch ex As Exception
                MessageBox.Show(ex.Message + vbCrLf + vbCrLf + ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            'borrar manzana
            For i As Integer = 0 To 3
                If Not Me.lkpManzanaOrigen.Properties.Columns.GetVisibleColumn(i) Is Nothing Then
                    Me.lkpManzanaOrigen.Properties.Columns.Remove(Me.lkpManzanaOrigen.Properties.Columns.GetVisibleColumn(i))
                End If
            Next
            lkpManzanaOrigen.Properties.DataSource = Nothing

            'si hay calle 2, lanzar evento closeup
            If lkpCalle2Origen.EditValue IsNot Nothing AndAlso lkpCalle2Origen.EditValue.ToString <> "" Then
                Dim args As DevExpress.XtraEditors.Controls.CloseUpEventArgs = New DevExpress.XtraEditors.Controls.CloseUpEventArgs(Nothing)
                args.AcceptValue = True
                args.Value = Me.lkpCalle2Origen.EditValue
                Me.lkpCalle2Origen_CloseUp(lkpCalle2Origen, args)
            End If
        End If

    End Sub

    Private Sub cargaDatosViajeBackground_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles cargaDatosViajeBackground.DoWork
        SplashScreenManager4 = New DevExpress.XtraSplashScreen.SplashScreenManager(Me, GetType(Global.EOD.PantallaEspera), True, True)
        SplashScreenManager4.ShowWaitForm()

        Invoke(DirectCast(AddressOf Me.fillCalle1, MethodInvoker))
        Invoke(DirectCast(AddressOf Me.fillDondeSeBajo, MethodInvoker))
        Invoke(DirectCast(AddressOf Me.fillHito, MethodInvoker))
        Invoke(DirectCast(AddressOf Me.fillModo, MethodInvoker))
        Invoke(DirectCast(AddressOf Me.fillComuna, MethodInvoker))
        Invoke(DirectCast(AddressOf Me.fillProposito, MethodInvoker))
        Invoke(DirectCast(AddressOf Me.fillLugarPrimerViaje, MethodInvoker))
        Invoke(DirectCast(AddressOf Me.fillNoViaja, MethodInvoker))
        Invoke(DirectCast(AddressOf Me.fillSiNo, MethodInvoker))
        Invoke(DirectCast(AddressOf Me.fillPagaEstacionamiento, MethodInvoker))
        Invoke(DirectCast(AddressOf Me.fillQueVehiculo, MethodInvoker))
        'Invoke(DirectCast(AddressOf Me.fillCalle2, MethodInvoker))
        Invoke(DirectCast(AddressOf Me.fillFormaPago, MethodInvoker))
        Invoke(DirectCast(AddressOf Me.fillResumenVehiculos, MethodInvoker))
        Invoke(DirectCast(AddressOf Me.fillViajaComo, MethodInvoker))
        Invoke(DirectCast(AddressOf Me.fillPropiedadBicicleta, MethodInvoker))
        Invoke(DirectCast(AddressOf Me.fillTipoTarifa, MethodInvoker))
        Invoke(DirectCast(AddressOf Me.fillMuelle, MethodInvoker))

    End Sub

    Private Sub cargaDatosViajeBackground_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles cargaDatosViajeBackground.RunWorkerCompleted

        'Carga de viaje en ventana
        Me.tmHoraSalida.EditValue = viaje.HoraIni
        Me.lkpProposito.EditValue = viaje.Proposito
        If viaje.Proposito = 9 Then
            If Not viaje.IsPropositoOtroNull Then
                Me.txtOtroProposito.Text = viaje.PropositoOtro
            End If
        End If

        Try
            Me.x_origen.Text = viaje.OrigenCoordX.ToString
        Catch ex As Exception
            Me.x_origen.Text = "0"
        End Try
        Try
            Me.y_origen.Text = viaje.OrigenCoordY.ToString
        Catch ex As Exception
            Me.y_origen.Text = "0"
        End Try

        Me.tmHoraLlegada.EditValue = viaje.Horafin
        Me.lkpTrasnoche.EditValue = viaje.Trasnoche
        Me.txtCuadrasDespues.Text = viaje.CuadrasDespues.ToString
        Me.txtMinutosDespues.Text = viaje.MinutosDespues.ToString
        Me.lkpComunaDestino.EditValue = viaje.ComunaDestino
        Try
            Me.lkpTrabajoDeclarado.EditValue = viaje.TrabajoDeclarado
            Me.lkpEstudioDeclarado.EditValue = viaje.EstudioDeclarado
        Catch ex As Exception
        End Try

        If viaje.ComunaDestino = 1 Then
            Me.txtComunaDestinoOtra.Text = viaje.ComunaOtraDestino
        ElseIf viaje.ComunaDestino = 2 Then
            If Not viaje.IsNombreCalle1DestinoNull Then
                Me.lkpCalle1Destino.EditValue = viaje.NombreCalle1Destino
            End If
            If Not viaje.IsNumeroOCalle2DestinoNull Then
                Me.lkpCalle2Destino.EditValue = viaje.NumeroOCalle2Destino
                Dim args As DevExpress.XtraEditors.Controls.CloseUpEventArgs = New DevExpress.XtraEditors.Controls.CloseUpEventArgs(Nothing)
                args.AcceptValue = True
                args.Value = Me.lkpCalle2Destino.EditValue
                Me.lkpCalle2Destino_CloseUp(lkpCalle2Destino, args)
            End If
            If Not viaje.IsHitoDestinoNull Then
                Me.lkpHitoDestino.EditValue = viaje.HitoDestino
            End If

            Me.lkpManzanaDestino.EditValue = viaje.ManzanaDestino
            Me.x_destino.Text = viaje.DestinoCoordX.ToString
            Me.y_destino.Text = viaje.DestinoCoordY.ToString
        End If

        If Me.idViaje = 1 Then
            Me.lkpComunaOrigen.EditValue = viaje.ComunaOrigen
            If viaje.ComunaOrigen = 1 Then
                Me.txtComunaOrigenOtra.Text = viaje.ComunaOtraOrigen
            ElseIf viaje.ComunaOrigen = 2 Then
                If Not viaje.IsNombreCalle1OrigenNull Then
                    Me.lkpCalle1Origen.EditValue = viaje.NombreCalle1Origen
                End If
                If Not viaje.IsNumeroOCalle2OrigenNull Then
                    Me.lkpCalle2Origen.EditValue = viaje.NumeroOCalle2Origen
                    Dim args As DevExpress.XtraEditors.Controls.CloseUpEventArgs = New DevExpress.XtraEditors.Controls.CloseUpEventArgs(Nothing)
                    args.AcceptValue = True
                    args.Value = Me.lkpCalle2Origen.EditValue
                    Me.lkpCalle2Origen_CloseUp(lkpCalle2Origen, args)
                End If
                If Not viaje.IsHitoOrigenNull Then
                    Me.lkpHitoOrigen.EditValue = viaje.HitoOrigen
                End If
                If Not viaje.IsManzanaOrigenNull Then
                    Me.lkpManzanaOrigen.EditValue = viaje.ManzanaOrigen
                End If
            End If
        Else
            Me.viajeAnterior = datasetEOD.Viaje.FindByHogarPersonaViajeDiaViaje(Me.idFolio, Me.idPersona, Me.idViaje - 1, Me.idDiaViajes)
            Me.lkpComunaAnterior.EditValue = viajeAnterior.ComunaDestino
            Me.tmInicioAnterior.EditValue = viajeAnterior.HoraIni
            Me.tmFinAnterior.EditValue = viajeAnterior.Horafin
            Me.lkpPropositoAnterior.EditValue = viajeAnterior.Proposito

            If viajeAnterior.ComunaDestino = 1 Then
                Me.txtComunaOtraAnterior.Text = viajeAnterior.ComunaOtraDestino
            ElseIf viajeAnterior.ComunaDestino = 2 Then
                Try
                    Me.txtCalle1Anterior.Text = viajeAnterior.NombreCalle1Destino
                Catch ex As Exception
                End Try
                Try
                    Me.txtCalle2Anterior.Text = viajeAnterior.NumeroOCalle2Destino
                Catch ex As Exception
                End Try
                Try
                    Me.txtHitoAnterior.Text = viajeAnterior.HitoDestino
                Catch ex As Exception
                End Try
                Me.txtManzanaAnterior.Text = viajeAnterior.ManzanaDestino.ToString
            End If
        End If

        'Carga de Etapa 1
        Me.lkpTransporte1.EditValue = etapa1.Modo

        Select Case etapa1.Modo
            Case 1, 5, 9
                'Carga Auto
                Me.txtCuadrasAutoE1.Text = etapa1.CuadrasAntes.ToString
                Me.txtMinutosAutoE1.Text = etapa1.MinutosAntes.ToString
                Me.lkpViajaComoE1.EditValue = etapa1.ViajaComo
                Me.lkpQueVehiculoE1.EditValue = etapa1.QueVehiculo
                Me.lkpLugarDondeBajoE1.EditValue = etapa1.LugarBajadaAuto

                If etapa1.QueVehiculo = 1 Then
                    Me.lkpVehHogarE1.EditValue = etapa1.IdVehiculoHogar
                End If

                If etapa1.ViajaComo = 1 Then
                    Me.lkpDondeEstacionaE1.EditValue = etapa1.DondeEstaciona
                    Me.txtMinutosEstacionaAutoE1.EditValue = etapa1.MinutosEsperaEstacionamiento
                    If etapa1.FormaPago > 0 Then
                        Me.lkpFormaPagoE1.EditValue = etapa1.FormaPago
                    End If
                    If Not etapa1.IsCostoEstacionamientoNull Then
                        Me.txtCuantoPagoE1.Text = etapa1.CostoEstacionamiento.ToString
                    End If
                End If
            Case 2, 10, 11, 12
                'Carga Bus
                Me.lkpLugarBajadaBusE1.EditValue = etapa1.LugarBajadaBus
                Me.txtMinutosEsperaBusE1.Text = etapa1.TiempoEsperaBus.ToString
                Me.lkpTipoTarifaBusE1.EditValue = etapa1.TipoTarifaBus
                If etapa1.TipoTarifaBus > 0 AndAlso etapa1.TipoTarifaBus < 4 Then
                    Me.txtTarifaMontoBusE1.Text = etapa1.TarifaBus.ToString
                End If
                Me.txtMinutosBusE1.Text = etapa1.MinutosAntes.ToString
                Me.txtCuadrasBusE1.Text = etapa1.CuadrasAntes.ToString
            Case 3, 4
                'Carga TXC
                Me.lkpLugarBajadaTXCE1.EditValue = etapa1.LugarBajadaTxc
                Me.txtMinutosEsperaTXCE1.Text = etapa1.TiempoEsperaTxc.ToString
                Me.txtTarifaMontoTXCE1.Text = etapa1.TarifaTxc.ToString
                Me.txtMinutosTXCE1.Text = etapa1.MinutosAntes.ToString
                Me.txtCuadrasTXCE1.Text = etapa1.CuadrasAntes.ToString
            Case 6
                'Carga Taxi
                Me.lkpLugarBajadaTaxiE1.EditValue = etapa1.LugarBajadaTaxi
                Me.txtMinutosEsperaTaxiE1.Text = etapa1.TiempoEsperaTaxi.ToString
                Me.txtTarifaMontoTaxiE1.Text = etapa1.TarifaTaxi.ToString
                Me.txtMinutosTaxiE1.Text = etapa1.MinutosAntes.ToString
                Me.txtCuadrasTaxiE1.Text = etapa1.CuadrasAntes.ToString
            Case 8
                'Carga Bicicleta
                Me.lkpPropiedadBicicletaE1.EditValue = etapa1.PropiedadBicicleta
                If etapa1.PropiedadBicicleta = 2 Then
                    Me.txtPropiedadBicicletaOtraE1.Text = etapa1.PropiedadBicicletaOtro
                End If
                Me.lkpLugarBajadaBiciE1.EditValue = etapa1.LugarBajadaBicicleta
                Me.lkpCicloviaE1.EditValue = etapa1.UsaCiclovia
                If etapa1.UsaCiclovia = 2 Then
                    Me.txtMotivoNoUsaE1.EditValue = etapa1.MotivoNoUsa
                End If
                Me.lkpEstacionamientoBiciE1.EditValue = etapa1.EstacionamientoBicicleta
        End Select

        Me.lkpComunaEtapa1.EditValue = etapa1.ComunaDestino
        If etapa1.ComunaDestino = 1 Then
            txtComunaOtraEtapa1.Text = etapa1.ComunaOtraDestino
        ElseIf etapa1.ComunaDestino = 2 Then
            If Not etapa1.IsNombreCalle1DestinoNull Then
                lkpCalle1Etapa1.EditValue = etapa1.NombreCalle1Destino
            End If
            If Not etapa1.IsNumeroOCalle2DestinoNull Then
                lkpCalle2Etapa1.EditValue = etapa1.NumeroOCalle2Destino
            End If
            If Not etapa1.IsHitoDestinoNull Then
                lkpHitoEtapa1.EditValue = etapa1.HitoDestino
            End If
            lkpManzanaEtapa1.EditValue = etapa1.ManzanaDestino
            x_etapa1.Text = etapa1.DestinoCoordX
            y_etapa1.Text = etapa1.DestinoCoordY
        End If

        If Not etapa2 Is Nothing Then
            'Carga de Etapa 2
            Me.lkpTransporte2.EditValue = etapa2.Modo

            Select Case etapa2.Modo
                Case 1, 5, 9
                    'Carga Auto
                    Me.txtCuadrasAutoE2.Text = etapa2.CuadrasAntes.ToString
                    Me.txtMinutosAutoE2.Text = etapa2.MinutosAntes.ToString
                    Me.lkpViajaComoE2.EditValue = etapa2.ViajaComo
                    Me.lkpQueVehiculoE2.EditValue = etapa2.QueVehiculo
                    Me.lkpLugarBajadaAutoE2.EditValue = etapa2.LugarBajadaAuto

                    If etapa2.QueVehiculo = 1 Then
                        Me.lkpVehHogarE2.EditValue = etapa2.IdVehiculoHogar
                    End If


                    If etapa2.ViajaComo = 1 Then
                        Me.lkpDondeEstacionaE2.EditValue = etapa2.DondeEstaciona
                        Me.txtMinutosEstacionaAutoE2.EditValue = etapa2.MinutosEsperaEstacionamiento
                        If etapa2.FormaPago > 0 Then
                            Me.lkpFormaPagoE2.EditValue = etapa2.FormaPago
                        End If
                        If Not etapa2.IsCostoEstacionamientoNull Then
                            Me.txtCuantoPagoE2.Text = etapa2.CostoEstacionamiento.ToString
                        End If
                    End If


                Case 2, 10, 11, 12
                    'Carga Bus
                    Me.lkpLugarBajadaBusE2.EditValue = etapa2.LugarBajadaBus
                    Me.txtMinutosEsperaBusE2.Text = etapa2.TiempoEsperaBus.ToString
                    Me.lkpTipoTarifaBusE2.EditValue = etapa2.TipoTarifaBus
                    If etapa2.TipoTarifaBus > 0 AndAlso etapa2.TipoTarifaBus < 4 Then
                        Me.txtTarifaMontoBusE2.Text = etapa2.TarifaBus.ToString
                    End If
                    Me.txtMinutosBusE2.Text = etapa2.MinutosAntes.ToString
                    Me.txtCuadrasBusE2.Text = etapa2.CuadrasAntes.ToString
                Case 3, 4
                    'Carga TXC
                    Me.lkpLugarBajadaTXCE2.EditValue = etapa2.LugarBajadaTxc
                    Me.txtMinutosEsperaTXCE2.Text = etapa2.TiempoEsperaTxc.ToString
                    Me.txtTarifaMontoTXCE2.Text = etapa2.TarifaTxc.ToString
                    Me.txtMinutosTXCE2.Text = etapa2.MinutosAntes.ToString
                    Me.txtCuadrasTXCE2.Text = etapa2.CuadrasAntes.ToString
                Case 6
                    'Carga Taxi
                    Me.lkpLugarBajadaTaxiE2.EditValue = etapa2.LugarBajadaTaxi
                    Me.txtMinutosEsperaTaxiE2.Text = etapa2.TiempoEsperaTaxi.ToString
                    Me.txtTarifaMontoTaxiE2.Text = etapa2.TarifaTaxi.ToString
                    Me.txtMinutosTaxiE2.Text = etapa2.MinutosAntes.ToString
                    Me.txtCuadrasTaxiE2.Text = etapa2.CuadrasAntes.ToString
                Case 8
                    'Carga Bicicleta
                    Me.lkpPropiedadBicicletaE2.EditValue = etapa2.PropiedadBicicleta
                    If etapa2.PropiedadBicicleta = 2 Then
                        Me.txtPropiedadBicicletaOtraE2.Text = etapa2.PropiedadBicicletaOtro
                    End If
                    Me.lkpLugarBajadaBiciE2.EditValue = etapa2.LugarBajadaBicicleta
                    Me.lkpCicloviaE2.EditValue = etapa2.UsaCiclovia
                    Me.lkpEstacionamientoBiciE2.EditValue = etapa2.EstacionamientoBicicleta
                    If etapa2.UsaCiclovia = 2 Then
                        Me.txtMotivoNoUsaE2.EditValue = etapa2.MotivoNoUsa
                    End If
            End Select

            Me.lkpComunaEtapa2.EditValue = etapa2.ComunaDestino
            If etapa2.ComunaDestino = 1 Then
                txtComunaOtraEtapa2.Text = etapa2.ComunaOtraDestino
            ElseIf etapa2.ComunaDestino = 2 Then
                If Not etapa2.IsNombreCalle1DestinoNull Then
                    lkpCalle1Etapa2.EditValue = etapa2.NombreCalle1Destino
                End If
                If Not etapa2.IsNumeroOCalle2DestinoNull Then
                    lkpCalle2Etapa2.EditValue = etapa2.NumeroOCalle2Destino
                End If
                If Not etapa2.IsHitoDestinoNull Then
                    lkpHitoEtapa2.EditValue = etapa2.HitoDestino
                End If
                lkpManzanaEtapa2.EditValue = etapa2.ManzanaDestino
                x_etapa2.Text = etapa2.DestinoCoordX
                y_etapa2.Text = etapa2.DestinoCoordY
            End If
        Else
            Me.lkpTransporte2.EditValue = 0
        End If

        If Not etapa3 Is Nothing Then
            'Carga de Etapa 3
            Me.lkpTransporte3.EditValue = etapa3.Modo

            Select Case etapa3.Modo
                Case 1, 5, 9
                    'Carga Auto
                    Me.txtCuadrasAutoE3.Text = etapa3.CuadrasAntes.ToString
                    Me.txtMinutosAutoE3.Text = etapa3.MinutosAntes.ToString
                    Me.lkpViajaComoE3.EditValue = etapa3.ViajaComo
                    Me.lkpQueVehiculoE3.EditValue = etapa3.QueVehiculo
                    Me.lkpLugarBajadaAutoE3.EditValue = etapa3.LugarBajadaAuto

                    If etapa3.QueVehiculo = 1 Then
                        Me.lkpVehHogarE3.EditValue = etapa3.IdVehiculoHogar
                    End If

                    If etapa3.ViajaComo = 1 Then
                        Me.lkpDondeEstacionaE3.EditValue = etapa3.DondeEstaciona
                        Me.txtMinutosEstacionaAutoE3.EditValue = etapa3.MinutosEsperaEstacionamiento
                        If etapa3.FormaPago > 0 Then
                            Me.lkpFormaPagoE3.EditValue = etapa3.FormaPago
                        End If
                        If Not etapa3.IsCostoEstacionamientoNull Then
                            Me.txtCuantoPagoE3.Text = etapa3.CostoEstacionamiento.ToString
                        End If
                    End If
                Case 2, 10, 11, 12
                    'Carga Bus
                    Me.lkpLugarBajadaBusE3.EditValue = etapa3.LugarBajadaBus
                    Me.txtMinutosEsperaBusE3.Text = etapa3.TiempoEsperaBus.ToString
                    Me.lkpTipoTarifaBusE3.EditValue = etapa3.TipoTarifaBus
                    If etapa3.TipoTarifaBus > 0 AndAlso etapa3.TipoTarifaBus < 4 Then
                        Me.txtTarifaMontoBusE3.Text = etapa3.TarifaBus.ToString
                    End If
                    Me.txtMinutosBusE3.Text = etapa3.MinutosAntes.ToString
                    Me.txtCuadrasBusE3.Text = etapa3.CuadrasAntes.ToString
                Case 3, 4
                    'Carga TXC
                    Me.lkpLugarBajadaTXCE3.EditValue = etapa3.LugarBajadaTxc
                    Me.txtMinutosEsperaTXCE3.Text = etapa3.TiempoEsperaTxc.ToString
                    Me.txtTarifaMontoTXCE3.Text = etapa3.TarifaTxc.ToString
                    Me.txtMinutosTXCE3.Text = etapa3.MinutosAntes.ToString
                    Me.txtCuadrasTXCE3.Text = etapa3.CuadrasAntes.ToString
                Case 6
                    'Carga Taxi
                    Me.lkpLugarBajadaTaxiE3.EditValue = etapa3.LugarBajadaTaxi
                    Me.txtMinutosEsperaTaxiE3.Text = etapa3.TiempoEsperaTaxi.ToString
                    Me.txtTarifaMontoTaxiE3.Text = etapa3.TarifaTaxi.ToString
                    Me.txtMinutosTaxiE3.Text = etapa3.MinutosAntes.ToString
                    Me.txtCuadrasTaxiE3.Text = etapa3.CuadrasAntes.ToString
                Case 8
                    'Carga Bicicleta
                    Me.lkpPropiedadBicicletaE3.EditValue = etapa3.PropiedadBicicleta
                    If etapa3.PropiedadBicicleta = 2 Then
                        Me.txtPropiedadBicicletaOtraE3.Text = etapa3.PropiedadBicicletaOtro
                    End If
                    Me.lkpLugarBajadaBiciE3.EditValue = etapa3.LugarBajadaBicicleta
                    Me.lkpCicloviaE3.EditValue = etapa3.UsaCiclovia
                    Me.lkpEstacionamientoBiciE3.EditValue = etapa3.EstacionamientoBicicleta
                    If etapa3.UsaCiclovia = 2 Then
                        Me.txtMotivoNoUsaE3.EditValue = etapa3.MotivoNoUsa
                    End If
            End Select

            Me.lkpComunaEtapa3.EditValue = etapa3.ComunaDestino
            If etapa3.ComunaDestino = 1 Then
                txtComunaOtraEtapa3.Text = etapa3.ComunaOtraDestino
            ElseIf etapa3.ComunaDestino = 2 Then
                If Not etapa3.IsNombreCalle1DestinoNull Then
                    lkpCalle1Etapa3.EditValue = etapa3.NombreCalle1Destino
                End If
                If Not etapa3.IsNumeroOCalle2DestinoNull Then
                    lkpCalle2Etapa3.EditValue = etapa3.NumeroOCalle2Destino
                End If
                If Not etapa3.IsHitoDestinoNull Then
                    lkpHitoEtapa3.EditValue = etapa3.HitoDestino
                End If
                lkpManzanaEtapa3.EditValue = etapa3.ManzanaDestino
                x_etapa3.Text = etapa3.DestinoCoordX
                y_etapa3.Text = etapa3.DestinoCoordY
            End If
        Else
            Me.lkpTransporte3.EditValue = 0
        End If

        If SplashScreenManager4 IsNot Nothing Then
            SplashScreenManager4.CloseWaitForm()
        End If

        Me.Enabled = True

        cargaCompleta = True
    End Sub

    Private Sub lkpCalle1Destino_EditValueChanged(sender As Object, e As EventArgs) Handles lkpCalle1Destino.EditValueChanged

        If lkpCalle1Destino.EditValue IsNot Nothing AndAlso Me.lkpCalle1Destino.EditValue.ToString <> "" Then
            Dim calleQuery As String = Me.lkpCalle1Destino.EditValue.ToString '.Replace("'", "''")
            ConsultaCalle2DestinoTableAdapter.FillBy(datasetEOD.ConsultaCalle2Destino, calleQuery)
        End If
    End Sub

    Private Sub lkpHitoDestino_EditValueChanged(sender As Object, e As EventArgs) Handles lkpHitoDestino.EditValueChanged
        If lkpHitoDestino.EditValue IsNot Nothing AndAlso lkpHitoDestino.EditValue.ToString <> "" Then
            Dim edit As GridLookUpEdit = TryCast(sender, GridLookUpEdit)
            Dim row As DataRowView = TryCast(edit.Properties.GetRowByKeyValue(edit.EditValue), DataRowView)
            If Not row Is Nothing Then
                Me.x_destino.Text = row.Item("x")
                Me.y_destino.Text = row.Item("y")
            End If


            Dim objConn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\MASCARA REFERENCIA_VF.accdb")
            objConn.Open()

            Dim objCommand As New OleDbCommand("select hitomanzana from hito where hito = ?", objConn)
            Dim parametro1 As New OleDbParameter("hito", Me.lkpHitoDestino.EditValue)
            objCommand.Parameters.Add(parametro1)

            Dim objAdapter As New OleDbDataAdapter(objCommand)
            Dim objDataSet As New DataSet("Manzanasdestino")

            For i As Integer = 0 To 3
                If Not Me.lkpManzanaDestino.Properties.Columns.GetVisibleColumn(i) Is Nothing Then
                    Me.lkpManzanaDestino.Properties.Columns.Remove(Me.lkpManzanaDestino.Properties.Columns.GetVisibleColumn(i))
                End If
            Next

            Try
                objAdapter.Fill(objDataSet, "Manzanasdestino")
                Dim objTabla As DataTable = objDataSet.Tables("Manzanasdestino")
                Me.lkpManzanaDestino.Properties.DataSource = objTabla
                Me.lkpManzanaDestino.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("hitomanzana", "hitomanzana", 5, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
                Me.lkpManzanaDestino.Properties.DisplayMember = "hitomanzana"
                Me.lkpManzanaDestino.Properties.ValueMember = "hitomanzana"
                Me.lkpManzanaDestino.ItemIndex = 0
            Catch ex As Exception
                MessageBox.Show(ex.Message + vbCrLf + vbCrLf + ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            'borrar manzana
            For i As Integer = 0 To 3
                If Not Me.lkpManzanaDestino.Properties.Columns.GetVisibleColumn(i) Is Nothing Then
                    Me.lkpManzanaDestino.Properties.Columns.Remove(Me.lkpManzanaDestino.Properties.Columns.GetVisibleColumn(i))
                End If
            Next
            lkpManzanaDestino.Properties.DataSource = Nothing

            'si hay calle 2, lanzar evento closeup
            If lkpCalle2Destino.EditValue IsNot Nothing AndAlso lkpCalle2Destino.EditValue.ToString <> "" Then
                Dim args As DevExpress.XtraEditors.Controls.CloseUpEventArgs = New DevExpress.XtraEditors.Controls.CloseUpEventArgs(Nothing)
                args.AcceptValue = True
                args.Value = Me.lkpCalle2Destino.EditValue
                Me.lkpCalle2Destino_CloseUp(lkpCalle2Destino, args)
            End If
        End If

    End Sub

    Private Sub lkpFormaPagoE1_EditValueChanged(sender As Object, e As EventArgs) Handles lkpFormaPagoE1.EditValueChanged

        Dim opcion As Integer

        If lkpFormaPagoE1.EditValue IsNot Nothing AndAlso lkpFormaPagoE1.EditValue.ToString <> "" Then
            opcion = lkpFormaPagoE1.EditValue
        End If

        If opcion < 9 Then
            Me.lblCuantoPagoE1.Visible = True
            Me.txtCuantoPagoE1.Visible = True
            spcPagoEstacionamientoE1.Collapsed = False
        Else
            Me.lblCuantoPagoE1.Visible = False
            Me.txtCuantoPagoE1.Visible = False
            spcPagoEstacionamientoE1.Collapsed = True
        End If

    End Sub

    Private Sub lkpComunaEtapa1_EditValueChanged(sender As Object, e As EventArgs) Handles lkpComunaEtapa1.EditValueChanged
        Dim comuna As Integer

        If lkpComunaEtapa1.EditValue IsNot Nothing AndAlso lkpComunaEtapa1.EditValue.ToString <> "" Then
            comuna = lkpComunaEtapa1.EditValue
        End If

        Me.spcCallesEtapa1.Visible = False
        Me.txtComunaOtraEtapa1.Enabled = False

        Select Case comuna
            Case 1
                Me.spcCallesEtapa1.Visible = True
                Me.spcCallesEtapa1.CollapsePanel = DevExpress.XtraEditors.SplitCollapsePanel.Panel2
                Me.spcCallesEtapa1.Collapsed = True
                Me.txtComunaOtraEtapa1.Enabled = True
            Case 2
                Me.spcCallesEtapa1.Visible = True
                Me.spcCallesEtapa1.CollapsePanel = DevExpress.XtraEditors.SplitCollapsePanel.Panel1
                Me.spcCallesEtapa1.Collapsed = True
        End Select
    End Sub

    Private Sub lkpCalle1Etapa1_EditValueChanged(sender As Object, e As EventArgs) Handles lkpCalle1Etapa1.EditValueChanged
        If lkpCalle1Etapa1.EditValue IsNot Nothing AndAlso Me.lkpCalle1Etapa1.EditValue.ToString <> "" Then
            Dim calleQuery As String = Me.lkpCalle1Etapa1.EditValue.ToString '.Replace("'", "''")
            ConsultaCalle2Etapa1TableAdapter.FillBy(datasetEOD.ConsultaCalle2Etapa1, calleQuery)
        End If
    End Sub

    Private Sub lkpHitoEtapa1_EditValueChanged(sender As Object, e As EventArgs) Handles lkpHitoEtapa1.EditValueChanged
        If lkpHitoEtapa1.EditValue IsNot Nothing AndAlso lkpHitoEtapa1.EditValue.ToString <> "" Then
            Dim edit As GridLookUpEdit = TryCast(sender, GridLookUpEdit)
            Dim row As DataRowView = TryCast(edit.Properties.GetRowByKeyValue(edit.EditValue), DataRowView)
            If Not row Is Nothing Then
                Me.x_etapa1.Text = row.Item("x")
                Me.y_etapa1.Text = row.Item("y")
            End If


            Dim objConn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\MASCARA REFERENCIA_VF.accdb")
            objConn.Open()

            Dim objCommand As New OleDbCommand("select hitomanzana from hito where hito = ?", objConn)
            Dim parametro1 As New OleDbParameter("hito", Me.lkpHitoEtapa1.EditValue)
            objCommand.Parameters.Add(parametro1)

            Dim objAdapter As New OleDbDataAdapter(objCommand)
            Dim objDataSet As New DataSet("Manzanasetapa1")

            For i As Integer = 0 To 3
                If Not Me.lkpManzanaEtapa1.Properties.Columns.GetVisibleColumn(i) Is Nothing Then
                    Me.lkpManzanaEtapa1.Properties.Columns.Remove(Me.lkpManzanaEtapa1.Properties.Columns.GetVisibleColumn(i))
                End If
            Next

            Try
                objAdapter.Fill(objDataSet, "Manzanasetapa1")
                Dim objTabla As DataTable = objDataSet.Tables("Manzanasetapa1")
                Me.lkpManzanaEtapa1.Properties.DataSource = objTabla
                Me.lkpManzanaEtapa1.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("hitomanzana", "hitomanzana", 5, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
                Me.lkpManzanaEtapa1.Properties.DisplayMember = "hitomanzana"
                Me.lkpManzanaEtapa1.Properties.ValueMember = "hitomanzana"
                Me.lkpManzanaEtapa1.ItemIndex = 0
            Catch ex As Exception
                MessageBox.Show(ex.Message + vbCrLf + vbCrLf + ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            'borrar manzana
            For i As Integer = 0 To 3
                If Not Me.lkpManzanaEtapa1.Properties.Columns.GetVisibleColumn(i) Is Nothing Then
                    Me.lkpManzanaEtapa1.Properties.Columns.Remove(Me.lkpManzanaEtapa1.Properties.Columns.GetVisibleColumn(i))
                End If
            Next
            lkpManzanaEtapa1.Properties.DataSource = Nothing

            'si hay calle 2, lanzar evento closeup
            If lkpCalle2Etapa1.EditValue IsNot Nothing AndAlso lkpCalle2Etapa1.EditValue.ToString <> "" Then
                Dim args As DevExpress.XtraEditors.Controls.CloseUpEventArgs = New DevExpress.XtraEditors.Controls.CloseUpEventArgs(Nothing)
                args.AcceptValue = True
                args.Value = Me.lkpCalle2Etapa1.EditValue
                Me.lkpCalle2Etapa1_CloseUp(lkpCalle2Etapa1, args)
            End If
        End If

    End Sub

    Private Sub lkpViajaComoE1_EditValueChanged(sender As Object, e As EventArgs) Handles lkpViajaComoE1.EditValueChanged
        Dim opcion As Integer

        Me.spcPagoBajadaAutoE1.Collapsed = True
        Me.lkpDondeEstacionaE1.Visible = False
        Me.txtCuantoPagoE1.Visible = False
        Me.lkpFormaPagoE1.Visible = False

        If lkpViajaComoE1.EditValue IsNot Nothing AndAlso Me.lkpViajaComoE1.EditValue.ToString <> "" Then
            opcion = Me.lkpViajaComoE1.EditValue
        End If

        If opcion = 1 Then
            Me.spcPagoBajadaAutoE1.Collapsed = False
            Me.lkpDondeEstacionaE1.Visible = True
            Me.txtCuantoPagoE1.Visible = True
            Me.lkpFormaPagoE1.Visible = True

            'Validador viaja como chofer y no tiene licencia
            Try
                Dim licencia As Integer = persona.LicenciaConducir

                If licencia = 2 Then
                    If validadorEtapa1 IsNot Nothing Then
                        validadorEtapa1.Val16 = True
                    End If
                    Dim confirma As DialogResult = MessageBox.Show("El encuestado viaja como chofer pero no indicó que posea licencia de conducir, ¿confirma que es correcto?", "Verificación de datos", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                    If confirma = Windows.Forms.DialogResult.No Then
                        lkpViajaComoE1.EditValue = -1
                        lkpViajaComoE1.Focus()
                        If validadorEtapa1 IsNot Nothing Then
                            validadorEtapa1.Val16 = False
                        End If
                    Else
                        If validadorEtapa1 IsNot Nothing Then
                            validadorEtapa1.Val16Resp = True
                        End If
                    End If
                End If
            Catch
            End Try

            'Validador chofer menor de edad
            Try
                Dim edad As Integer = DateTime.Now.Year - persona.AnoNac
                If edad < 18 Then
                    Dim confirma As DialogResult = MessageBox.Show("El encuestado viaja como chofer pero es menor de edad, ¿confirma que es correcto?", "Verificación de datos", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                    If confirma = Windows.Forms.DialogResult.No Then
                        lkpViajaComoE1.EditValue = -1
                        lkpViajaComoE1.Focus()
                        If validadorEtapa1 IsNot Nothing Then
                            validadorEtapa1.Val16 = False
                        End If
                    Else
                        If validadorEtapa1 IsNot Nothing Then
                            validadorEtapa1.Val16Resp = True
                        End If
                    End If
                End If
            Catch ex As Exception
            End Try

        End If
    End Sub

    Private Sub lkpLugarBajadaTaxiE1_EditValueChanged(sender As Object, e As EventArgs) Handles lkpLugarBajadaTaxiE1.EditValueChanged
        Dim opcion As Integer

        If lkpLugarBajadaTaxiE1.EditValue IsNot Nothing AndAlso Me.lkpLugarBajadaTaxiE1.EditValue.ToString <> "" Then
            opcion = Me.lkpLugarBajadaTaxiE1.EditValue
        End If

        'Desbloquear caminata posterior
        Me.txtCuadrasDespues.Enabled = True
        Me.txtMinutosDespues.Enabled = True

        Select Case opcion
            Case 1
                mismaManzanaDestino = True
                'Bloquear caminata posterior
                Me.txtCuadrasDespues.Text = "0"
                Me.txtCuadrasDespues.Enabled = False
                Me.txtMinutosDespues.Text = "0"
                Me.txtMinutosDespues.Enabled = False

                Me.lkpComunaEtapa1.EditValue = Me.lkpComunaDestino.EditValue
                Me.txtComunaOtraEtapa1.Text = Me.txtComunaDestinoOtra.Text
                Me.lkpCalle1Etapa1.EditValue = Me.lkpCalle1Destino.EditValue
                Me.lkpCalle2Etapa1.EditValue = Me.lkpCalle2Destino.EditValue
                Dim args As DevExpress.XtraEditors.Controls.CloseUpEventArgs = New DevExpress.XtraEditors.Controls.CloseUpEventArgs(Nothing)
                args.AcceptValue = True
                args.Value = Me.lkpCalle2Destino.EditValue
                Me.lkpCalle2Etapa1_CloseUp(lkpCalle2Etapa1, args)
                Me.lkpHitoEtapa1.EditValue = Me.lkpHitoDestino.EditValue
                Me.lkpManzanaEtapa1.ItemIndex = Me.lkpManzanaDestino.ItemIndex
                Me.tmHoraLlegada.Focus()
            Case 2
                Me.lkpComunaEtapa1.EditValue = ""
                Me.txtComunaOtraEtapa1.Text = ""
                Me.lkpCalle1Etapa1.EditValue = ""
                Me.lkpCalle2Etapa1.EditValue = ""
                Me.lkpHitoEtapa1.EditValue = ""
                Me.txtCuadrasDespues.Enabled = True
                Me.txtMinutosDespues.Enabled = True
                Me.lkpManzanaEtapa1.Properties.DataSource = Nothing
        End Select
    End Sub

    Private Sub lkpQueVehiculoE1_EditValueChanged(sender As Object, e As EventArgs) Handles lkpQueVehiculoE1.EditValueChanged
        Dim opcion As Integer

        If lkpQueVehiculoE1.EditValue IsNot Nothing AndAlso Me.lkpQueVehiculoE1.EditValue.ToString <> "" Then
            opcion = Me.lkpQueVehiculoE1.EditValue
        End If

        If opcion = 1 Then
            Me.spVehiculoHogarE1.Collapsed = False
            Me.lkpVehHogarE1.Visible = True

            Me.ResumenVehiculosTableAdapter.Fill(Me.datasetEOD.ResumenVehiculos)
            Me.ResumenVehiculosBindingSource.Filter = "Hogar = " + Me.idFolio.ToString

        ElseIf opcion = 2 Then
            Me.spVehiculoHogarE1.Collapsed = True
            Me.lkpVehHogarE1.Visible = False
        End If

    End Sub

    Private Sub lkpLugarDondeBajoE1_EditValueChanged(sender As Object, e As EventArgs) Handles lkpLugarDondeBajoE1.EditValueChanged
        Dim opcion As Integer

        If lkpLugarDondeBajoE1.EditValue IsNot Nothing AndAlso Me.lkpLugarDondeBajoE1.EditValue.ToString <> "" Then
            opcion = Me.lkpLugarDondeBajoE1.EditValue
        End If

        'Desbloquear caminata posterior
        Me.txtCuadrasDespues.Enabled = True
        Me.txtMinutosDespues.Enabled = True

        Select Case opcion
            Case 1
                mismaManzanaDestino = True
                'Bloquear caminata posterior
                Me.txtCuadrasDespues.Text = "0"
                Me.txtCuadrasDespues.Enabled = False
                Me.txtMinutosDespues.Text = "0"
                Me.txtMinutosDespues.Enabled = False

                'Llenado destino con destino de viaje
                Me.gcLugarBajadaEtapa1.Visible = True
                Me.lkpComunaEtapa1.EditValue = Me.lkpComunaDestino.EditValue
                Me.txtComunaOtraEtapa1.Text = Me.txtComunaDestinoOtra.Text
                Me.lkpCalle1Etapa1.EditValue = Me.lkpCalle1Destino.EditValue
                Me.lkpCalle2Etapa1.EditValue = Me.lkpCalle2Destino.EditValue
                Dim args As DevExpress.XtraEditors.Controls.CloseUpEventArgs = New DevExpress.XtraEditors.Controls.CloseUpEventArgs(Nothing)
                args.AcceptValue = True
                args.Value = Me.lkpCalle2Destino.EditValue
                Me.lkpCalle2Etapa1_CloseUp(lkpCalle2Etapa1, args)
                Me.lkpHitoEtapa1.EditValue = Me.lkpHitoDestino.EditValue
                Me.lkpManzanaEtapa1.EditValue = Me.lkpManzanaDestino.EditValue
                Me.tmHoraLlegada.Focus()
            Case 3
                Me.gcLugarBajadaEtapa1.Visible = True
                Me.lkpComunaEtapa1.EditValue = ""
                Me.txtComunaOtraEtapa1.Text = ""
                Me.lkpCalle1Etapa1.EditValue = ""
                Me.lkpCalle2Etapa1.EditValue = ""
                Me.lkpHitoEtapa1.EditValue = ""
                Me.txtCuadrasDespues.Enabled = True
                Me.txtMinutosDespues.Enabled = True
                Me.lkpManzanaEtapa1.Properties.DataSource = Nothing
        End Select
    End Sub



    Private Sub lkpLugarBajadaBusE1_EditValueChanged(sender As Object, e As EventArgs) Handles lkpLugarBajadaBusE1.EditValueChanged
        Dim opcion As Integer

        If lkpLugarBajadaBusE1.EditValue IsNot Nothing AndAlso Me.lkpLugarBajadaBusE1.EditValue.ToString <> "" Then
            opcion = Me.lkpLugarBajadaBusE1.EditValue
        End If

        'Desbloquear caminata posterior
        Me.txtCuadrasDespues.Enabled = True
        Me.txtMinutosDespues.Enabled = True

        Select Case opcion
            Case 1
                mismaManzanaDestino = True
                'Bloquear caminata posterior
                Me.txtCuadrasDespues.Text = "0"
                Me.txtCuadrasDespues.Enabled = False
                Me.txtMinutosDespues.Text = "0"
                Me.txtMinutosDespues.Enabled = False

                Me.gcLugarBajadaEtapa1.Visible = True
                Me.lkpComunaEtapa1.EditValue = Me.lkpComunaDestino.EditValue
                Me.txtComunaOtraEtapa1.Text = Me.txtComunaDestinoOtra.Text
                Me.lkpCalle1Etapa1.EditValue = Me.lkpCalle1Destino.EditValue
                Me.lkpCalle2Etapa1.EditValue = Me.lkpCalle2Destino.EditValue
                Dim args As DevExpress.XtraEditors.Controls.CloseUpEventArgs = New DevExpress.XtraEditors.Controls.CloseUpEventArgs(Nothing)
                args.AcceptValue = True
                args.Value = Me.lkpCalle2Destino.EditValue
                Me.lkpCalle2Etapa1_CloseUp(lkpCalle2Etapa1, args)
                Me.lkpHitoEtapa1.EditValue = Me.lkpHitoDestino.EditValue
                Me.lkpManzanaEtapa1.ItemIndex = Me.lkpManzanaDestino.ItemIndex
                Me.tmHoraLlegada.Focus()
            Case 2
                Me.gcLugarBajadaEtapa1.Visible = True
                Me.lkpComunaEtapa1.EditValue = ""
                Me.txtComunaOtraEtapa1.Text = ""
                Me.lkpCalle1Etapa1.EditValue = ""
                Me.lkpCalle2Etapa1.EditValue = ""
                Me.lkpHitoEtapa1.EditValue = ""
                Me.txtCuadrasDespues.Enabled = True
                Me.txtMinutosDespues.Enabled = True
                Me.lkpManzanaEtapa1.Properties.DataSource = Nothing
        End Select
    End Sub

    Private Sub lkpTransporte2_EditValueChanged(sender As Object, e As EventArgs) Handles lkpTransporte2.EditValueChanged

        Dim opTransporte3 As Integer
        Dim opTransporte2 As Integer
        Me.gcLugarBajadaEtapa2.Visible = True

        ' Asigna valores de modos 2 y 3
        If lkpTransporte2.EditValue IsNot Nothing AndAlso lkpTransporte2.EditValue.ToString <> "" Then
            opTransporte2 = lkpTransporte2.EditValue
        End If

        If lkpTransporte3.EditValue IsNot Nothing AndAlso lkpTransporte3.EditValue.ToString <> "" Then
            opTransporte3 = lkpTransporte3.EditValue
        End If


        If opTransporte2 > 0 Then
            ' Muestra preguntas de etapa
            Me.tabTransporte2.PageVisible = True
            Me.lkpTransporte3.Visible = True
            Me.lblTransporte3.Visible = True
            ' Filtra mismo lugar de destino en Etapa 1
            Me.DondeSeBajoE1BindingSource.Filter = "id > 1 "
            Me.DondeSeBajoE2BindingSource.Filter = "id > 0 "
            ' Crea validador de etapa 2
            If validadorEtapa2 Is Nothing Then
                validadorEtapa2 = datasetEOD.ValidaEtapa.NewValidaEtapaRow
            End If

            If lkpTransporte3.EditValue Is Nothing OrElse lkpTransporte3.EditValue.ToString = "" Then
                Me.tabsEtapas.Visible = False
            End If

        Else
            ' Oculta preguntas de etapa y suelta filtro de destino Etapa 1
            Me.DondeSeBajoE1BindingSource.Filter = "id > 0 "
            Me.tabTransporte2.PageVisible = False
            Me.lkpTransporte3.EditValue = -1
            Me.lkpTransporte3.Visible = False
            Me.lblTransporte3.Visible = False

            If validadorEtapa2 IsNot Nothing Then
                validadorEtapa2 = Nothing
            End If

            Me.tabsEtapas.Visible = True

            ' Ocultar preguntas de Etapa 3
            Me.tabTransporte3.PageVisible = False

        End If

        ' Filtrar lugar bajada si hay etapa 3
        If opTransporte3 > 0 Then
            Me.DondeSeBajoE2BindingSource.Filter = "id > 1 "
        Else
            Me.DondeSeBajoE2BindingSource.Filter = "id > 0 "
        End If

        Me.x_etapa2.Text = "0"
        Me.y_etapa2.Text = "0"

        Select Case opTransporte2
            Case 1, 5, 9
                Me.FormaPagoTableAdapter.Fill(datasetEOD.FormaPago)
                Me.ViajaComoTableAdapter.Fill(datasetEOD.ViajaComo)
                Me.tabsEtapa2.Visible = True
                Me.tabsEtapa2.SelectedTabPage = tabsEtapa2.TabPages(0)
            Case 2, 10, 11, 12
                Me.TipoTarifaTableAdapter.Fill(datasetEOD.TipoTarifa)
                Me.tabsEtapa2.Visible = True
                Me.tabsEtapa2.SelectedTabPage = tabsEtapa2.TabPages(2)
            Case 3, 4
                Me.tabsEtapa2.Visible = True
                Me.tabsEtapa2.SelectedTabPage = tabsEtapa2.TabPages(4)
            Case 6
                Me.tabsEtapa2.Visible = True
                Me.tabsEtapa2.SelectedTabPage = tabsEtapa2.TabPages(3)
            Case 7
                Me.tabsEtapa2.Visible = False
                Me.gcLugarBajadaEtapa2.Visible = False
                Me.x_etapa2.Text = Me.x_destino.Text
                Me.y_etapa2.Text = Me.y_destino.Text
            Case 8
                Me.PropiedadBicicletaTableAdapter.Fill(datasetEOD.PropiedadBicicleta)
                Me.tabsEtapa2.Visible = True
                Me.tabsEtapa2.SelectedTabPage = tabsEtapa2.TabPages(1)
            Case 13
                Me.tabsEtapa2.Visible = True
                Me.gcLugarBajadaEtapa2.Visible = False
                Me.tabsEtapa2.SelectedTabPage = tabsEtapa2.TabPages(5)
            Case 14
                Me.tabsEtapa2.Visible = True
                Me.gcLugarBajadaEtapa2.Visible = False
                Me.tabsEtapa2.SelectedTabPage = tabsEtapa2.TabPages(6)
        End Select
    End Sub

    Private Sub lkpTransporte3_EditValueChanged(sender As Object, e As EventArgs) Handles lkpTransporte3.EditValueChanged

        Dim opTransporte3 As Integer
        Me.gcLugarBajadaEtapa3.Visible = True

        If lkpTransporte3.EditValue IsNot Nothing AndAlso lkpTransporte3.EditValue.ToString <> "" Then
            opTransporte3 = lkpTransporte3.EditValue
        End If

        If opTransporte3 > 0 Then
            Me.tabTransporte3.PageVisible = True
            Me.DondeSeBajoE1BindingSource.Filter = "id > 1 "
            Me.DondeSeBajoE2BindingSource.Filter = "id > 1 "
            If validadorEtapa3 Is Nothing Then
                validadorEtapa3 = datasetEOD.ValidaEtapa.NewValidaEtapaRow
            End If
        Else
            If validadorEtapa3 IsNot Nothing Then
                validadorEtapa3 = Nothing
            End If

            'ocultar etapa 3
            Me.tabTransporte3.PageVisible = False
        End If

        Me.x_etapa3.Text = "0"
        Me.y_etapa3.Text = "0"

        Me.tabsEtapas.Visible = True

        Select Case opTransporte3
            Case 1, 5, 9
                Me.FormaPagoTableAdapter.Fill(datasetEOD.FormaPago)
                Try
                    Me.EstacionaTableAdapter.Fill(datasetEOD.Estaciona)
                Catch ex As Exception

                End Try
                Me.ViajaComoTableAdapter.Fill(datasetEOD.ViajaComo)

                Me.tabsEtapa3.Visible = True
                Me.tabsEtapa3.SelectedTabPage = tabsEtapa3.TabPages(0)
            Case 2, 10, 11, 12
                Me.TipoTarifaTableAdapter.Fill(datasetEOD.TipoTarifa)
                Me.tabsEtapa3.Visible = True
                Me.tabsEtapa3.SelectedTabPage = tabsEtapa3.TabPages(2)
            Case 3, 4
                Me.tabsEtapa3.Visible = True
                Me.tabsEtapa3.SelectedTabPage = tabsEtapa3.TabPages(4)
            Case 6
                Me.tabsEtapa3.Visible = True
                Me.tabsEtapa3.SelectedTabPage = tabsEtapa3.TabPages(3)
            Case 7
                Me.tabsEtapa3.Visible = False
                Me.gcLugarBajadaEtapa3.Visible = False
                Me.x_etapa3.Text = Me.x_destino.Text
                Me.y_etapa3.Text = Me.y_destino.Text
            Case 8
                Me.PropiedadBicicletaTableAdapter.Fill(datasetEOD.PropiedadBicicleta)
                Me.tabsEtapa3.Visible = True
                Me.tabsEtapa3.SelectedTabPage = tabsEtapa3.TabPages(1)
            Case 13
                Me.tabsEtapa3.Visible = True
                Me.gcLugarBajadaEtapa3.Visible = False
                Me.tabsEtapa3.SelectedTabPage = tabsEtapa3.TabPages(5)
            Case 14
                Me.tabsEtapa3.Visible = True
                Me.gcLugarBajadaEtapa3.Visible = False
                Me.tabsEtapa3.SelectedTabPage = tabsEtapa3.TabPages(6)
        End Select
    End Sub

    Private Sub lkpFormaPagoE2_EditValueChanged(sender As Object, e As EventArgs) Handles lkpFormaPagoE2.EditValueChanged

        Dim opcion As Integer

        If lkpFormaPagoE2.EditValue IsNot Nothing AndAlso lkpFormaPagoE2.EditValue.ToString <> "" Then
            opcion = lkpFormaPagoE2.EditValue
        End If

        If opcion < 9 Then
            Me.lblCuantoPagoE2.Visible = True
            Me.txtCuantoPagoE2.Visible = True
            spcPagoEstacionamientoE2.Collapsed = False
        Else
            Me.lblCuantoPagoE2.Visible = False
            Me.txtCuantoPagoE2.Visible = False
            spcPagoEstacionamientoE2.Collapsed = True
        End If

    End Sub

    Private Sub lkpFormaPagoE3_EditValueChanged(sender As Object, e As EventArgs) Handles lkpFormaPagoE3.EditValueChanged

        Dim opcion As Integer

        If lkpFormaPagoE3.EditValue IsNot Nothing AndAlso lkpFormaPagoE3.EditValue.ToString <> "" Then
            opcion = lkpFormaPagoE3.EditValue
        End If

        If opcion < 9 Then
            Me.lblCuantoPagoE3.Visible = True
            Me.txtCuantoPagoE3.Visible = True
            spcPagoEstacionamientoE3.Collapsed = False
        Else
            Me.lblCuantoPagoE3.Visible = False
            Me.txtCuantoPagoE3.Visible = False
            spcPagoEstacionamientoE3.Collapsed = True
        End If

    End Sub

    Private Sub lkpComunaEtapa2_EditValueChanged(sender As Object, e As EventArgs) Handles lkpComunaEtapa2.EditValueChanged
        Dim comuna As Integer

        If lkpComunaEtapa2.EditValue IsNot Nothing AndAlso lkpComunaEtapa2.EditValue.ToString <> "" Then
            comuna = lkpComunaEtapa2.EditValue
        End If

        Me.spcCallesEtapa2.Visible = False
        Me.txtComunaOtraEtapa2.Enabled = False

        Select Case comuna
            Case 1
                Me.spcCallesEtapa2.Visible = True
                Me.spcCallesEtapa2.CollapsePanel = DevExpress.XtraEditors.SplitCollapsePanel.Panel2
                Me.spcCallesEtapa2.Collapsed = True
                Me.txtComunaOtraEtapa2.Enabled = True
            Case 2
                Me.spcCallesEtapa2.Visible = True
                Me.spcCallesEtapa2.CollapsePanel = DevExpress.XtraEditors.SplitCollapsePanel.Panel1
                Me.spcCallesEtapa2.Collapsed = True
        End Select
    End Sub

    Private Sub lkpCalle1Etapa2_EditValueChanged(sender As Object, e As EventArgs) Handles lkpCalle1Etapa2.EditValueChanged
        If lkpCalle1Etapa2.EditValue IsNot Nothing AndAlso Me.lkpCalle1Etapa2.EditValue.ToString <> "" Then
            Dim calleQuery As String = Me.lkpCalle1Etapa2.EditValue.ToString '.Replace("'", ControlChars.Quote)
            ConsultaCalle2Etapa2TableAdapter.FillBy(datasetEOD.ConsultaCalle2Etapa2, calleQuery)
        End If
    End Sub

    Private Sub lkpHitoEtapa2_EditValueChanged(sender As Object, e As EventArgs) Handles lkpHitoEtapa2.EditValueChanged
        If lkpHitoEtapa2.EditValue IsNot Nothing AndAlso lkpHitoEtapa2.EditValue.ToString <> "" Then
            Dim edit As GridLookUpEdit = TryCast(sender, GridLookUpEdit)
            Dim row As DataRowView = TryCast(edit.Properties.GetRowByKeyValue(edit.EditValue), DataRowView)
            If Not row Is Nothing Then
                Me.x_etapa2.Text = row.Item("x")
                Me.y_etapa2.Text = row.Item("y")
            End If


            Dim objConn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\MASCARA REFERENCIA_VF.accdb")
            objConn.Open()

            Dim objCommand As New OleDbCommand("select hitomanzana from hito where hito = ?", objConn)
            Dim parametro1 As New OleDbParameter("hito", Me.lkpHitoEtapa2.EditValue)
            objCommand.Parameters.Add(parametro1)

            Dim objAdapter As New OleDbDataAdapter(objCommand)
            Dim objDataSet As New DataSet("Manzanasetapa2")

            For i As Integer = 0 To 3
                If Not Me.lkpManzanaEtapa2.Properties.Columns.GetVisibleColumn(i) Is Nothing Then
                    Me.lkpManzanaEtapa2.Properties.Columns.Remove(Me.lkpManzanaEtapa2.Properties.Columns.GetVisibleColumn(i))
                End If
            Next

            Try
                objAdapter.Fill(objDataSet, "Manzanasetapa2")
                Dim objTabla As DataTable = objDataSet.Tables("Manzanasetapa2")
                Me.lkpManzanaEtapa2.Properties.DataSource = objTabla
                Me.lkpManzanaEtapa2.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("hitomanzana", "hitomanzana", 5, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
                Me.lkpManzanaEtapa2.Properties.DisplayMember = "hitomanzana"
                Me.lkpManzanaEtapa2.Properties.ValueMember = "hitomanzana"
                Me.lkpManzanaEtapa2.ItemIndex = 0
            Catch ex As Exception
                MessageBox.Show(ex.Message + vbCrLf + vbCrLf + ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            'borrar manzana
            For i As Integer = 0 To 3
                If Not Me.lkpManzanaEtapa2.Properties.Columns.GetVisibleColumn(i) Is Nothing Then
                    Me.lkpManzanaEtapa2.Properties.Columns.Remove(Me.lkpManzanaEtapa2.Properties.Columns.GetVisibleColumn(i))
                End If
            Next
            lkpManzanaEtapa2.Properties.DataSource = Nothing

            'si hay calle 2, lanzar evento closeup
            If lkpCalle2Etapa2.EditValue IsNot Nothing AndAlso lkpCalle2Etapa2.EditValue.ToString <> "" Then
                Dim args As DevExpress.XtraEditors.Controls.CloseUpEventArgs = New DevExpress.XtraEditors.Controls.CloseUpEventArgs(Nothing)
                args.AcceptValue = True
                args.Value = Me.lkpCalle2Etapa2.EditValue
                Me.lkpCalle2Etapa2_CloseUp(lkpCalle2Etapa2, args)
            End If
        End If
    End Sub

    Private Sub btnGuardarViaje_Click(sender As Object, e As EventArgs) Handles btnGuardarViaje.Click

        If Me.idViaje > 0 Then


            'Validar viaje completo
            If viajeCompleto() Then

                'Validar tiempo de viaje versus minutos caminados
                If tiempoViaje() < minutosCaminadosViaje() Then
                    MessageBox.Show("El tiempo de viaje reportado es inferior a los minutos caminados que indicó. Revise los valores de hora de salida y llegada del viaje, además de todos los minutos caminados durante el viaje. Modifique el dato incorrecto para continuar.", "Datos inconsistentes", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    tmHoraSalida.Focus()
                    Return
                End If

                'Actualizar viaje
                Dim etapas As Integer
                If Me.lkpTransporte1.EditValue > 0 Then
                    etapas += 1

                    If lkpTransporte2.EditValue IsNot Nothing AndAlso Me.lkpTransporte2.EditValue.ToString <> "" Then
                        If Me.lkpTransporte2.EditValue > 0 Then
                            etapas += 1

                            If lkpTransporte3.EditValue IsNot Nothing AndAlso Me.lkpTransporte3.EditValue.ToString <> "" Then
                                If Me.lkpTransporte3.EditValue > 0 Then
                                    etapas += 1
                                End If
                            End If
                        End If
                    End If
                End If

                'Viaje
                viaje.Proposito = Me.lkpProposito.EditValue
                If viaje.Proposito = 9 Then
                    viaje.PropositoOtro = Me.txtOtroProposito.Text
                End If
                viaje.Trasnoche = Me.lkpTrasnoche.EditValue
                viaje.MinutosDespues = Me.txtMinutosDespues.EditValue
                viaje.CuadrasDespues = Me.txtCuadrasDespues.EditValue
                viaje.HoraIni = Me.tmHoraSalida.EditValue
                viaje.Horafin = Me.tmHoraLlegada.EditValue
                viaje.Etapas = etapas
                viaje.TrabajoDeclarado = IIf(lkpTrabajoDeclarado.EditValue Is Nothing OrElse Me.lkpTrabajoDeclarado.EditValue.ToString = "", -1, Me.lkpTrabajoDeclarado.EditValue)
                viaje.EstudioDeclarado = IIf(lkpEstudioDeclarado.EditValue Is Nothing OrElse Me.lkpEstudioDeclarado.EditValue.ToString = "", -1, Me.lkpEstudioDeclarado.EditValue)

                If viaje.Viaje > 1 Then
                    viaje.ComunaOrigen = Me.lkpComunaAnterior.EditValue
                    If viaje.ComunaOrigen = 2 Then
                        viaje.NombreCalle1Origen = Me.txtCalle1Anterior.Text
                        viaje.NumeroOCalle2Origen = Me.txtCalle2Anterior.Text
                        viaje.HitoOrigen = Me.txtHitoAnterior.Text
                        viaje.ManzanaOrigen = Me.txtManzanaAnterior.Text
                        viaje.ZonaOrigen = Me.txtManzanaAnterior.Text \ 1000
                        viaje.OrigenCoordX = Me.x_origen.Text
                        viaje.OrigenCoordY = Me.y_origen.Text
                        viaje.ComunaOtraOrigen = ""
                    ElseIf viaje.ComunaOrigen = 1 Then
                        viaje.ComunaOtraOrigen = Me.txtComunaOtraAnterior.Text
                    End If
                Else
                    viaje.ComunaOrigen = Me.lkpComunaOrigen.EditValue
                    If viaje.ComunaOrigen = 2 Then
                        If Me.lkpCalle1Origen.EditValue IsNot Nothing Then
                            viaje.NombreCalle1Origen = Me.lkpCalle1Origen.EditValue
                        End If
                        If Me.lkpCalle2Origen.EditValue IsNot Nothing Then
                            viaje.NumeroOCalle2Origen = Me.lkpCalle2Origen.EditValue
                        End If
                        If lkpHitoOrigen.EditValue IsNot Nothing Then
                            viaje.HitoOrigen = Me.lkpHitoOrigen.EditValue
                        End If
                        If lkpManzanaOrigen.EditValue IsNot Nothing Then
                            viaje.ManzanaOrigen = Me.lkpManzanaOrigen.EditValue
                            viaje.ZonaOrigen = Me.lkpManzanaOrigen.EditValue \ 1000
                        End If
                        viaje.OrigenCoordX = Me.x_origen.Text
                        viaje.OrigenCoordY = Me.y_origen.Text
                        viaje.ComunaOtraOrigen = ""
                    ElseIf viaje.ComunaOrigen = 1 Then
                        viaje.ComunaOtraOrigen = Me.txtComunaOrigenOtra.Text
                    End If
                End If


                viaje.ComunaDestino = Me.lkpComunaDestino.EditValue


                If viaje.ComunaDestino = 2 Then
                    If Me.lkpCalle1Destino.EditValue IsNot Nothing Then
                        viaje.NombreCalle1Destino = Me.lkpCalle1Destino.EditValue
                    End If
                    If Me.lkpCalle2Destino.EditValue IsNot Nothing Then
                        viaje.NumeroOCalle2Destino = Me.lkpCalle2Destino.EditValue
                    End If
                    If lkpHitoDestino.EditValue IsNot Nothing Then
                        viaje.HitoDestino = Me.lkpHitoDestino.EditValue
                    End If
                    If lkpManzanaDestino.EditValue IsNot Nothing Then
                        viaje.ManzanaDestino = Me.lkpManzanaDestino.EditValue
                        viaje.ZonaDestino = Me.lkpManzanaDestino.EditValue \ 1000
                    End If
                    viaje.DestinoCoordX = Me.x_destino.Text
                    viaje.DestinoCoordY = Me.y_destino.Text
                    viaje.ComunaOtraDestino = ""
                ElseIf viaje.ComunaDestino = 1 Then
                    viaje.ComunaOtraDestino = Me.txtComunaDestinoOtra.Text
                End If



                'Etapa 1
                If Me.lkpTransporte1.EditValue > 0 Then
                    etapa1.Modo = Me.lkpTransporte1.EditValue
                    etapa1.ComunaOrigen = viaje.ComunaOrigen
                    If etapa1.Modo = 7 Then
                        etapa1.ComunaDestino = viaje.ComunaDestino
                    Else
                        etapa1.ComunaDestino = Me.lkpComunaEtapa1.EditValue
                    End If

                    If etapa1.ComunaOrigen = 2 Then
                        Try
                            etapa1.NombreCalle1Origen = viaje.NombreCalle1Origen
                        Catch ex As Exception
                        End Try
                        Try
                            etapa1.NumeroOCalle2Origen = viaje.NumeroOCalle2Origen
                        Catch ex As Exception
                        End Try
                        Try
                            etapa1.HitoOrigen = viaje.HitoOrigen
                        Catch ex As Exception
                        End Try

                        etapa1.ManzanaOrigen = viaje.ManzanaOrigen
                        etapa1.OrigenCoordX = viaje.OrigenCoordX
                        etapa1.OrigenCoordY = viaje.OrigenCoordY
                        etapa1.ZonaOrigen = viaje.ManzanaOrigen \ 1000
                    ElseIf etapa1.ComunaOrigen = 1 Then
                        etapa1.ComunaOtraOrigen = viaje.ComunaOtraOrigen
                    End If

                    Select Case etapa1.Modo
                        Case 1, 5, 9
                            etapa1.ViajaComo = Me.lkpViajaComoE1.EditValue
                            etapa1.QueVehiculo = Me.lkpQueVehiculoE1.EditValue
                            If etapa1.QueVehiculo = 1 Then
                                etapa1.IdVehiculoHogar = Me.lkpVehHogarE1.EditValue
                            End If
                            If etapa1.ViajaComo = 1 Then
                                etapa1.DondeEstaciona = Me.lkpDondeEstacionaE1.EditValue
                                etapa1.FormaPago = Me.lkpFormaPagoE1.EditValue
                                etapa1.MinutosEsperaEstacionamiento = txtMinutosEstacionaAutoE1.Text
                                If etapa1.FormaPago < 8 AndAlso etapa1.FormaPago > 0 Then
                                    etapa1.CostoEstacionamiento = Me.txtCuantoPagoE1.Text
                                End If
                            End If
                            etapa1.LugarBajadaAuto = Me.lkpLugarDondeBajoE1.EditValue
                            etapa1.MinutosAntes = Me.txtMinutosAutoE1.Text
                            etapa1.CuadrasAntes = Me.txtCuadrasAutoE1.Text
                        Case 2, 10, 11, 12
                            etapa1.LugarBajadaBus = Me.lkpLugarBajadaBusE1.EditValue
                            etapa1.TiempoEsperaBus = Me.txtMinutosEsperaBusE1.Text
                            etapa1.TipoTarifaBus = Me.lkpTipoTarifaBusE1.EditValue
                            etapa1.TarifaBus = IIf(Me.txtTarifaMontoBusE1.Text = "", 0, Me.txtTarifaMontoBusE1.Text)
                            etapa1.MinutosAntes = Me.txtMinutosBusE1.Text
                            etapa1.CuadrasAntes = Me.txtCuadrasBusE1.Text
                        Case 3, 4
                            etapa1.LugarBajadaTxc = Me.lkpLugarBajadaTXCE1.EditValue
                            etapa1.TiempoEsperaTxc = Me.txtMinutosEsperaTXCE1.Text
                            etapa1.TarifaTxc = Me.txtTarifaMontoTXCE1.Text
                            etapa1.MinutosAntes = Me.txtMinutosTXCE1.Text
                            etapa1.CuadrasAntes = Me.txtCuadrasTXCE1.Text
                        Case 6
                            etapa1.LugarBajadaTaxi = Me.lkpLugarBajadaTaxiE1.EditValue
                            etapa1.TiempoEsperaTaxi = Me.txtMinutosEsperaTaxiE1.Text
                            etapa1.TarifaTaxi = Me.txtTarifaMontoTaxiE1.Text
                            etapa1.MinutosAntes = Me.txtMinutosTaxiE1.Text
                            etapa1.CuadrasAntes = Me.txtCuadrasTaxiE1.Text
                        Case 7
                            etapa1.MinutosAntes = 0
                            etapa1.CuadrasAntes = 0
                            etapa1.ComunaDestino = viaje.ComunaDestino
                            If etapa1.ComunaDestino = 1 Then
                                etapa1.ComunaOtraDestino = viaje.ComunaOtraDestino
                            ElseIf etapa1.ComunaDestino = 2 Then
                                Try
                                    etapa1.NombreCalle1Destino = viaje.NombreCalle1Destino
                                Catch ex As Exception
                                End Try
                                Try
                                    etapa1.NumeroOCalle2Destino = viaje.NumeroOCalle2Destino
                                Catch ex As Exception
                                End Try
                                Try
                                    etapa1.HitoDestino = viaje.HitoDestino
                                Catch ex As Exception
                                End Try

                                etapa1.ManzanaDestino = viaje.ManzanaDestino
                                etapa1.DestinoCoordX = viaje.DestinoCoordX
                                etapa1.DestinoCoordY = viaje.DestinoCoordY
                                etapa1.ZonaDestino = viaje.ZonaDestino
                            End If
                        Case 8
                            etapa1.PropiedadBicicleta = Me.lkpPropiedadBicicletaE1.EditValue
                            If etapa1.PropiedadBicicleta = 2 Then
                                etapa1.PropiedadBicicletaOtro = Me.txtPropiedadBicicletaOtraE1.Text
                            End If
                            etapa1.LugarBajadaBicicleta = Me.lkpLugarBajadaBiciE1.EditValue
                            etapa1.UsaCiclovia = Me.lkpCicloviaE1.EditValue
                            If etapa1.UsaCiclovia = 2 Then
                                etapa1.MotivoNoUsa = Me.txtMotivoNoUsaE1.Text
                            End If
                            etapa1.EstacionamientoBicicleta = Me.lkpEstacionamientoBiciE1.EditValue
                            etapa1.LugarBajadaBicicleta = Me.lkpLugarBajadaBiciE1.EditValue
                    End Select

                    If etapa1.ComunaDestino = 2 Then
                        etapa1.NombreCalle1Destino = Me.lkpCalle1Etapa1.EditValue
                        etapa1.NumeroOCalle2Destino = Me.lkpCalle2Etapa1.EditValue
                        etapa1.HitoDestino = Me.lkpHitoEtapa1.EditValue
                        etapa1.ManzanaDestino = Me.lkpManzanaEtapa1.EditValue
                        etapa1.DestinoCoordX = Me.x_etapa1.Text
                        etapa1.DestinoCoordY = Me.y_etapa1.Text
                        etapa1.ZonaDestino = etapa1.ManzanaDestino \ 1000
                    ElseIf etapa1.ComunaDestino = 1 Then
                        etapa1.ComunaOtraDestino = Me.txtComunaOtraEtapa1.Text
                    End If

                    'Etapa 2
                    If etapas > 1 AndAlso Me.lkpTransporte2.EditValue > 0 Then
                        If etapa2 Is Nothing Then
                            etapa2 = datasetEOD.Etapa.NewEtapaRow
                            etapa2.Hogar = Me.idFolio
                            etapa2.Persona = Me.idPersona
                            etapa2.Viaje = Me.idViaje
                            etapa2.DiaViaje = Me.idDiaViajes
                            etapa2.Etapa = 2
                            agregaEtapa2 = True
                        End If
                        etapa2.Modo = Me.lkpTransporte2.EditValue
                        etapa2.ComunaOrigen = etapa1.ComunaDestino
                        etapa2.ComunaDestino = Me.lkpComunaEtapa2.EditValue

                        If etapa2.ComunaOrigen = 2 Then
                            Try
                                etapa2.NombreCalle1Origen = etapa1.NombreCalle1Destino
                            Catch ex As Exception
                            End Try
                            Try
                                etapa2.NumeroOCalle2Origen = etapa1.NumeroOCalle2Destino
                            Catch ex As Exception
                            End Try
                            Try
                                etapa2.HitoOrigen = etapa1.HitoDestino
                            Catch ex As Exception
                            End Try

                            etapa2.ManzanaOrigen = etapa1.ManzanaDestino
                            etapa2.OrigenCoordX = etapa1.DestinoCoordX
                            etapa2.OrigenCoordY = etapa1.DestinoCoordY
                            etapa2.ZonaOrigen = etapa2.ManzanaOrigen \ 1000
                        ElseIf etapa2.ComunaOrigen = 1 Then
                            etapa2.ComunaOtraOrigen = etapa1.ComunaOtraDestino
                        End If

                        Select Case etapa2.Modo
                            Case 1, 5, 9
                                etapa2.ViajaComo = Me.lkpViajaComoE2.EditValue
                                etapa2.QueVehiculo = Me.lkpQueVehiculoE2.EditValue
                                If etapa2.QueVehiculo = 1 Then
                                    etapa2.IdVehiculoHogar = Me.lkpVehHogarE2.EditValue
                                End If
                                If etapa2.ViajaComo = 1 Then
                                    etapa2.DondeEstaciona = Me.lkpDondeEstacionaE2.EditValue
                                    etapa2.FormaPago = Me.lkpFormaPagoE2.EditValue
                                    etapa2.MinutosEsperaEstacionamiento = txtMinutosEstacionaAutoE2.Text
                                    If etapa2.FormaPago < 8 AndAlso etapa2.FormaPago > 0 Then
                                        etapa2.CostoEstacionamiento = Me.txtCuantoPagoE2.Text
                                    End If
                                End If
                                etapa2.LugarBajadaAuto = Me.lkpLugarBajadaAutoE2.EditValue
                                etapa2.MinutosAntes = Me.txtMinutosAutoE2.Text
                                etapa2.CuadrasAntes = Me.txtCuadrasAutoE2.Text
                            Case 2, 10, 11, 12
                                etapa2.LugarBajadaBus = Me.lkpLugarBajadaBusE2.EditValue
                                etapa2.TiempoEsperaBus = Me.txtMinutosEsperaBusE2.Text
                                etapa2.TipoTarifaBus = Me.lkpTipoTarifaBusE2.EditValue
                                etapa2.TarifaBus = IIf(Me.txtTarifaMontoBusE2.Text = "", 0, Me.txtTarifaMontoBusE2.Text)
                                etapa2.MinutosAntes = Me.txtMinutosBusE2.Text
                                etapa2.CuadrasAntes = Me.txtCuadrasBusE2.Text
                            Case 3, 4
                                etapa2.LugarBajadaTxc = Me.lkpLugarBajadaTXCE2.EditValue
                                etapa2.TiempoEsperaTxc = Me.txtMinutosEsperaTXCE2.Text
                                etapa2.TarifaTxc = Me.txtTarifaMontoTXCE2.Text
                                etapa2.MinutosAntes = Me.txtMinutosTXCE2.Text
                                etapa2.CuadrasAntes = Me.txtCuadrasTXCE2.Text
                            Case 6
                                etapa2.LugarBajadaTaxi = Me.lkpLugarBajadaTaxiE2.EditValue
                                etapa2.TiempoEsperaTaxi = Me.txtMinutosEsperaTaxiE2.Text
                                etapa2.TarifaTaxi = Me.txtTarifaMontoTaxiE2.Text
                                etapa2.MinutosAntes = Me.txtMinutosTaxiE2.Text
                                etapa2.CuadrasAntes = Me.txtCuadrasTaxiE2.Text
                            Case 8
                                etapa2.PropiedadBicicleta = Me.lkpPropiedadBicicletaE2.EditValue
                                If etapa2.PropiedadBicicleta = 2 Then
                                    etapa2.PropiedadBicicletaOtro = Me.txtPropiedadBicicletaOtraE2.Text
                                End If
                                etapa2.LugarBajadaBicicleta = Me.lkpLugarBajadaBiciE2.EditValue
                                etapa2.UsaCiclovia = Me.lkpCicloviaE2.EditValue
                                If etapa2.UsaCiclovia = 2 Then
                                    etapa2.MotivoNoUsa = Me.txtMotivoNoUsaE2.Text
                                End If
                                etapa2.EstacionamientoBicicleta = Me.lkpEstacionamientoBiciE2.EditValue
                                etapa2.LugarBajadaBicicleta = Me.lkpLugarBajadaBiciE2.EditValue
                        End Select

                        If etapa2.ComunaDestino = 2 Then
                            If Me.lkpCalle1Etapa2.EditValue IsNot Nothing Then
                                etapa2.NombreCalle1Destino = Me.lkpCalle1Etapa2.EditValue
                            End If

                            If Me.lkpCalle2Etapa2.EditValue IsNot Nothing Then
                                etapa2.NumeroOCalle2Destino = Me.lkpCalle2Etapa2.EditValue
                            End If
                            If Me.lkpHitoEtapa2.EditValue IsNot Nothing Then
                                etapa2.HitoDestino = Me.lkpHitoEtapa2.EditValue
                            End If
                            If Me.lkpManzanaEtapa2.EditValue IsNot Nothing Then
                                etapa2.ManzanaDestino = Me.lkpManzanaEtapa2.EditValue
                                etapa2.ZonaDestino = etapa2.ManzanaDestino \ 1000
                            End If
                            etapa2.DestinoCoordX = Me.x_etapa2.Text
                            etapa2.DestinoCoordY = Me.y_etapa2.Text
                        ElseIf etapa2.ComunaDestino = 1 Then
                            etapa2.ComunaOtraDestino = Me.txtComunaOtraEtapa2.Text
                        End If

                        'Etapa 3
                        If etapas > 2 AndAlso Me.lkpTransporte3.EditValue > 0 Then
                            If etapa3 Is Nothing Then
                                etapa3 = datasetEOD.Etapa.NewEtapaRow
                                etapa3.Hogar = Me.idFolio
                                etapa3.Persona = Me.idPersona
                                etapa3.Viaje = Me.idViaje
                                etapa3.DiaViaje = Me.idDiaViajes
                                etapa3.Etapa = 3
                                agregaEtapa3 = True
                            End If
                            etapa3.Modo = Me.lkpTransporte3.EditValue
                            etapa3.ComunaOrigen = etapa2.ComunaDestino
                            etapa3.ComunaDestino = Me.lkpComunaEtapa3.EditValue

                            If etapa3.ComunaOrigen = 2 Then
                                Try
                                    etapa3.NombreCalle1Origen = etapa2.NombreCalle1Destino
                                Catch ex As Exception
                                End Try
                                Try
                                    etapa3.NumeroOCalle2Origen = etapa2.NumeroOCalle2Destino
                                Catch ex As Exception
                                End Try
                                Try
                                    etapa3.HitoOrigen = etapa2.HitoDestino
                                Catch ex As Exception
                                End Try

                                etapa3.ManzanaOrigen = etapa2.ManzanaDestino
                                etapa3.OrigenCoordX = etapa2.DestinoCoordX
                                etapa3.OrigenCoordY = etapa2.DestinoCoordY
                                etapa3.ZonaOrigen = etapa3.ManzanaOrigen \ 1000
                            ElseIf etapa3.ComunaOrigen = 1 Then
                                etapa3.ComunaOtraDestino = Me.txtComunaOtraEtapa3.Text
                            End If

                            Select Case etapa3.Modo
                                Case 1, 5, 9
                                    etapa3.ViajaComo = Me.lkpViajaComoE3.EditValue
                                    etapa3.QueVehiculo = Me.lkpQueVehiculoE3.EditValue
                                    If etapa3.QueVehiculo = 1 Then
                                        etapa3.IdVehiculoHogar = Me.lkpVehHogarE3.EditValue
                                    End If
                                    If etapa3.ViajaComo = 1 Then
                                        etapa3.DondeEstaciona = Me.lkpDondeEstacionaE3.EditValue
                                        etapa3.FormaPago = Me.lkpFormaPagoE3.EditValue
                                        etapa3.MinutosEsperaEstacionamiento = txtMinutosEstacionaAutoE3.Text
                                        If etapa3.FormaPago < 8 AndAlso etapa3.FormaPago > 0 Then
                                            etapa3.CostoEstacionamiento = Me.txtCuantoPagoE3.Text
                                        End If
                                    End If
                                    etapa3.LugarBajadaAuto = Me.lkpLugarBajadaAutoE3.EditValue
                                    etapa3.MinutosAntes = Me.txtMinutosAutoE3.Text
                                    etapa3.CuadrasAntes = Me.txtCuadrasAutoE3.Text
                                Case 2, 10, 11, 12
                                    etapa3.LugarBajadaBus = Me.lkpLugarBajadaBusE3.EditValue
                                    etapa3.TiempoEsperaBus = Me.txtMinutosEsperaBusE3.Text
                                    etapa3.TipoTarifaBus = Me.lkpTipoTarifaBusE3.EditValue
                                    etapa3.TarifaBus = IIf(Me.txtTarifaMontoBusE3.Text = "", 0, Me.txtTarifaMontoBusE3.Text)
                                    etapa3.MinutosAntes = Me.txtMinutosBusE3.Text
                                    etapa3.CuadrasAntes = Me.txtCuadrasBusE3.Text
                                Case 3, 4
                                    etapa3.LugarBajadaTxc = Me.lkpLugarBajadaTXCE3.EditValue
                                    etapa3.TiempoEsperaTxc = Me.txtMinutosEsperaTXCE3.Text
                                    etapa3.TarifaTxc = Me.txtTarifaMontoTXCE3.Text
                                    etapa3.MinutosAntes = Me.txtMinutosTXCE3.Text
                                    etapa3.CuadrasAntes = Me.txtCuadrasTXCE3.Text
                                Case 6
                                    etapa3.LugarBajadaTaxi = Me.lkpLugarBajadaTaxiE3.EditValue
                                    etapa3.TiempoEsperaTaxi = Me.txtMinutosEsperaTaxiE3.Text
                                    etapa3.TarifaTaxi = Me.txtTarifaMontoTaxiE3.Text
                                    etapa3.MinutosAntes = Me.txtMinutosTaxiE3.Text
                                    etapa3.CuadrasAntes = Me.txtCuadrasTaxiE3.Text
                                Case 8
                                    etapa3.PropiedadBicicleta = Me.lkpPropiedadBicicletaE3.EditValue
                                    If etapa3.PropiedadBicicleta = 2 Then
                                        etapa3.PropiedadBicicletaOtro = Me.txtPropiedadBicicletaOtraE3.Text
                                    End If
                                    etapa3.LugarBajadaBicicleta = Me.lkpLugarBajadaBiciE3.EditValue
                                    etapa3.UsaCiclovia = Me.lkpCicloviaE3.EditValue
                                    If etapa3.UsaCiclovia = 2 Then
                                        etapa3.MotivoNoUsa = Me.txtMotivoNoUsaE3.Text
                                    End If
                                    etapa3.EstacionamientoBicicleta = Me.lkpEstacionamientoBiciE3.EditValue
                                    etapa3.LugarBajadaBicicleta = Me.lkpLugarBajadaBiciE3.EditValue
                            End Select

                            If etapa3.ComunaDestino = 2 Then
                                If lkpCalle1Etapa3.EditValue IsNot Nothing Then
                                    etapa3.NombreCalle1Destino = Me.lkpCalle1Etapa3.EditValue
                                End If
                                If lkpCalle2Etapa3.EditValue IsNot Nothing Then
                                    etapa3.NumeroOCalle2Destino = Me.lkpCalle2Etapa3.EditValue
                                End If
                                If lkpHitoEtapa3.EditValue IsNot Nothing Then
                                    etapa3.HitoDestino = Me.lkpHitoEtapa3.EditValue
                                End If
                                If lkpManzanaEtapa3.EditValue IsNot Nothing Then
                                    etapa3.ManzanaDestino = Me.lkpManzanaEtapa3.EditValue
                                    etapa3.ZonaDestino = etapa3.ManzanaDestino \ 1000
                                End If
                                etapa3.DestinoCoordX = Me.x_etapa3.Text
                                etapa3.DestinoCoordY = Me.y_etapa3.Text
                            ElseIf etapa3.ComunaDestino = 1 Then
                                etapa3.ComunaOtraDestino = Me.txtComunaOtraEtapa3.Text
                            End If
                        Else
                            'Si existía, borrar etapa 3
                            If Not etapa3 Is Nothing Then
                                etapa3.Delete()
                                etapa3 = Nothing
                            End If
                        End If
                    Else
                        'Si existía, borrar etapa 2
                        If Not etapa2 Is Nothing Then
                            etapa2.Delete()
                            etapa2 = Nothing
                        End If
                    End If
                End If

                'Verificar si tenía viaje siguiente y modificar origen (en viaje y su primera etapa correspondiente)

                viajeSiguiente = datasetEOD.Viaje.FindByHogarPersonaViajeDiaViaje(Me.idFolio, Me.idPersona, Me.idViaje + 1, Me.idDiaViajes)

                If Not viajeSiguiente Is Nothing Then
                    viajeSiguiente.ComunaOrigen = viaje.ComunaDestino
                    If viaje.ComunaDestino = 1 Then
                        viajeSiguiente.ComunaOtraOrigen = viaje.ComunaOtraDestino
                    ElseIf viaje.ComunaDestino = 2 Then
                        Try
                            viajeSiguiente.NombreCalle1Origen = viaje.NombreCalle1Destino
                        Catch ex As Exception
                        End Try
                        Try
                            viajeSiguiente.NumeroOCalle2Origen = viaje.NumeroOCalle2Destino
                        Catch ex As Exception
                        End Try
                        Try
                            viajeSiguiente.HitoOrigen = viaje.HitoDestino
                        Catch ex As Exception
                        End Try

                        viajeSiguiente.ManzanaOrigen = viaje.ManzanaDestino
                        viajeSiguiente.ZonaOrigen = viaje.ZonaDestino
                        viajeSiguiente.OrigenCoordX = viaje.DestinoCoordX
                        viajeSiguiente.OrigenCoordY = viaje.DestinoCoordY
                    End If

                End If

                etapaViajeSiguiente = datasetEOD.Etapa.FindByHogarEtapaViajePersonaDiaViaje(Me.idFolio, 1, Me.idViaje + 1, Me.idPersona, 1)

                If Not etapaViajeSiguiente Is Nothing Then
                    Try
                        etapaViajeSiguiente.NombreCalle1Origen = viaje.NombreCalle1Destino
                    Catch ex As Exception
                    End Try
                    Try
                        etapaViajeSiguiente.NumeroOCalle2Origen = viaje.NumeroOCalle2Destino
                    Catch ex As Exception
                    End Try
                    Try
                        etapaViajeSiguiente.HitoOrigen = viaje.HitoDestino
                    Catch ex As Exception
                    End Try

                    If Not viaje.IsManzanaDestinoNull Then
                        etapaViajeSiguiente.ManzanaOrigen = viaje.ManzanaDestino
                    End If
                    If Not viaje.IsZonaDestinoNull Then
                        etapaViajeSiguiente.ZonaOrigen = viaje.ZonaDestino
                    End If
                    If Not viaje.IsDestinoCoordXNull Then
                        etapaViajeSiguiente.OrigenCoordX = viaje.DestinoCoordX
                    End If
                    If Not viaje.IsDestinoCoordYNull Then
                        etapaViajeSiguiente.OrigenCoordY = viaje.DestinoCoordY
                    End If

                End If

                'Verificar si lugar de bajada de última etapa del viaje es lugar de destino y modificar datos

                If Not etapa3 Is Nothing Then

                    Dim actualizaEtapa As Boolean = False

                    Select Case etapa3.Modo
                        Case 1, 5, 9
                            If etapa3.LugarBajadaAuto = 1 Then
                                actualizaEtapa = True
                            End If
                        Case 2, 10, 11, 12
                            If etapa3.LugarBajadaBus = 1 Then
                                actualizaEtapa = True
                            End If
                        Case 3, 4
                            If etapa3.LugarBajadaTxc = 1 Then
                                actualizaEtapa = True
                            End If
                        Case 6
                            If etapa3.LugarBajadaTaxi = 1 Then
                                actualizaEtapa = True
                            End If
                        Case 8
                            If etapa3.LugarBajadaBicicleta = 1 Then
                                actualizaEtapa = True
                            End If
                    End Select

                    etapa3.ComunaDestino = viaje.ComunaDestino
                    If etapa3.ComunaDestino = 1 Then
                        etapa3.ComunaOtraDestino = viaje.ComunaOtraDestino
                    ElseIf etapa3.ComunaDestino = 2 Then
                        Try
                            etapa3.NombreCalle1Destino = viaje.NombreCalle1Destino
                        Catch ex As Exception
                        End Try
                        Try
                            etapa3.NumeroOCalle2Destino = viaje.NumeroOCalle2Destino
                        Catch ex As Exception
                        End Try
                        Try
                            etapa3.HitoDestino = viaje.HitoDestino
                        Catch ex As Exception
                        End Try

                        etapa3.ManzanaDestino = viaje.ManzanaDestino
                        etapa3.ZonaDestino = viaje.ZonaDestino
                        etapa3.DestinoCoordX = viaje.DestinoCoordX
                        etapa3.DestinoCoordY = viaje.DestinoCoordY
                    End If

                ElseIf Not etapa2 Is Nothing Then

                    Dim actualizaEtapa As Boolean = False

                    Select Case etapa2.Modo
                        Case 1, 5, 9
                            If etapa2.LugarBajadaAuto = 1 Then
                                actualizaEtapa = True
                            End If
                        Case 2, 10, 11, 12
                            If etapa2.LugarBajadaBus = 1 Then
                                actualizaEtapa = True
                            End If
                        Case 3, 4
                            If etapa2.LugarBajadaTxc = 1 Then
                                actualizaEtapa = True
                            End If
                        Case 6
                            If etapa2.LugarBajadaTaxi = 1 Then
                                actualizaEtapa = True
                            End If
                        Case 8
                            If etapa2.LugarBajadaBicicleta = 1 Then
                                actualizaEtapa = True
                            End If
                    End Select

                    etapa2.ComunaDestino = viaje.ComunaDestino

                    If etapa2.ComunaDestino = 1 Then
                        etapa2.ComunaOtraDestino = viaje.ComunaOtraDestino
                    ElseIf etapa2.ComunaDestino = 2 Then
                        Try
                            etapa2.NombreCalle1Destino = viaje.NombreCalle1Destino
                        Catch ex As Exception
                        End Try
                        Try
                            etapa2.NumeroOCalle2Destino = viaje.NumeroOCalle2Destino
                        Catch ex As Exception
                        End Try
                        Try
                            etapa2.HitoDestino = viaje.HitoDestino
                        Catch ex As Exception
                        End Try

                        etapa2.ManzanaDestino = viaje.ManzanaDestino
                        etapa2.ZonaDestino = viaje.ZonaDestino
                        etapa2.DestinoCoordX = viaje.DestinoCoordX
                        etapa2.DestinoCoordY = viaje.DestinoCoordY
                    End If

                Else
                    Dim actualizaEtapa As Boolean = False

                    Select Case etapa1.Modo
                        Case 1, 5, 9
                            If etapa1.LugarBajadaAuto = 1 Then
                                actualizaEtapa = True
                            End If
                        Case 2, 10, 11, 12
                            If etapa1.LugarBajadaBus = 1 Then
                                actualizaEtapa = True
                            End If
                        Case 3, 4
                            If etapa1.LugarBajadaTxc = 1 Then
                                actualizaEtapa = True
                            End If
                        Case 6
                            If etapa1.LugarBajadaTaxi = 1 Then
                                actualizaEtapa = True
                            End If
                        Case 8
                            If etapa1.LugarBajadaBicicleta = 1 Then
                                actualizaEtapa = True
                            End If
                    End Select

                    etapa1.ComunaDestino = viaje.ComunaDestino
                    If etapa1.ComunaDestino = 1 Then
                        etapa1.ComunaOtraDestino = viaje.ComunaOtraDestino
                    ElseIf etapa1.ComunaDestino = 2 Then
                        Try
                            etapa1.NombreCalle1Destino = viaje.NombreCalle1Destino
                        Catch ex As Exception
                        End Try
                        Try
                            etapa1.NumeroOCalle2Destino = viaje.NumeroOCalle2Destino
                        Catch ex As Exception
                        End Try
                        Try
                            etapa1.HitoDestino = viaje.HitoDestino
                        Catch ex As Exception
                        End Try

                        etapa1.ManzanaDestino = viaje.ManzanaDestino
                        etapa1.ZonaDestino = viaje.ZonaDestino
                        etapa1.DestinoCoordX = viaje.DestinoCoordX
                        etapa1.DestinoCoordY = viaje.DestinoCoordY
                    End If
                End If

                If agregaEtapa2 Then
                    datasetEOD.Etapa.AddEtapaRow(etapa2)
                End If
                If agregaEtapa3 Then
                    datasetEOD.Etapa.AddEtapaRow(etapa3)
                End If

                'Guardar en base de datos
                Try
                    ViajeTableAdapter.Update(Me.datasetEOD.Viaje)
                    EtapaTableAdapter.Update(Me.datasetEOD.Etapa)

                    MessageBox.Show("Viaje modificado exitosamente", "Datos guardados", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Dispose()
                Catch ex As Exception
                    MessageBox.Show("Error al modificar viaje. Intente nuevamente" + vbCrLf + vbCrLf + ex.Message + vbCrLf + vbCrLf + ex.StackTrace, "Datos no guardados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            Else
                MessageBox.Show("No ha contestado las preguntas mínimas para terminar la modificación del viaje. Por favor, complete los campos marcados con rojo.", "Datos insuficientes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

        End If
    End Sub


    Private Sub lkpComunaOrigen_Enter(sender As Object, e As EventArgs) Handles lkpComunaOrigen.Enter
        BeginInvoke(New MethodInvoker(Sub() CType(sender, GridLookUpEdit).ShowPopup()))
    End Sub

    Private Sub lkpProposito_Enter(sender As Object, e As EventArgs) Handles lkpProposito.Enter
        BeginInvoke(New MethodInvoker(Sub() CType(sender, GridLookUpEdit).ShowPopup()))
    End Sub

    Private Sub lkpComunaDestino_Enter(sender As Object, e As EventArgs) Handles lkpComunaDestino.Enter
        BeginInvoke(New MethodInvoker(Sub() CType(sender, GridLookUpEdit).ShowPopup()))
    End Sub

    Private Sub lkpTransporte1_Enter(sender As Object, e As EventArgs) Handles lkpTransporte1.Enter
        BeginInvoke(New MethodInvoker(Sub() CType(sender, GridLookUpEdit).ShowPopup()))
    End Sub

    Private Sub lkpTransporte2_Enter(sender As Object, e As EventArgs) Handles lkpTransporte2.Enter
        BeginInvoke(New MethodInvoker(Sub() CType(sender, GridLookUpEdit).ShowPopup()))
    End Sub

    Private Sub lkpTransporte3_Enter(sender As Object, e As EventArgs) Handles lkpTransporte3.Enter
        BeginInvoke(New MethodInvoker(Sub() CType(sender, GridLookUpEdit).ShowPopup()))
    End Sub

    Private Sub lkpLugarBajadaTaxiE1_Enter(sender As Object, e As EventArgs) Handles lkpLugarBajadaTaxiE1.Enter
        BeginInvoke(New MethodInvoker(Sub() CType(sender, GridLookUpEdit).ShowPopup()))
    End Sub

    Private Sub lkpViajaComoE1_Enter(sender As Object, e As EventArgs) Handles lkpViajaComoE1.Enter
        BeginInvoke(New MethodInvoker(Sub() CType(sender, GridLookUpEdit).ShowPopup()))
    End Sub

    Private Sub lkpQueVehiculoE1_Enter(sender As Object, e As EventArgs) Handles lkpQueVehiculoE1.Enter
        BeginInvoke(New MethodInvoker(Sub() CType(sender, GridLookUpEdit).ShowPopup()))
    End Sub

    Private Sub lkpLugarDondeBajoE1_Enter(sender As Object, e As EventArgs) Handles lkpLugarDondeBajoE1.Enter
        BeginInvoke(New MethodInvoker(Sub() CType(sender, GridLookUpEdit).ShowPopup()))
    End Sub

    Private Sub lkpFormaPagoE1_Enter(sender As Object, e As EventArgs) Handles lkpFormaPagoE1.Enter
        BeginInvoke(New MethodInvoker(Sub() CType(sender, GridLookUpEdit).ShowPopup()))
    End Sub

    Private Sub lkpVehHogarE1_Enter(sender As Object, e As EventArgs) Handles lkpVehHogarE1.Enter
        BeginInvoke(New MethodInvoker(Sub() CType(sender, GridLookUpEdit).ShowPopup()))
    End Sub

    Private Sub lkpComunaEtapa1_Enter(sender As Object, e As EventArgs) Handles lkpComunaEtapa1.Enter
        BeginInvoke(New MethodInvoker(Sub() CType(sender, GridLookUpEdit).ShowPopup()))
    End Sub

    Private Sub lkpTrasnoche_Enter(sender As Object, e As EventArgs) Handles lkpTrasnoche.Enter
        BeginInvoke(New MethodInvoker(Sub() CType(sender, GridLookUpEdit).ShowPopup()))
    End Sub

    Private Sub lkpPropiedadBicicletaE1_Enter(sender As Object, e As EventArgs) Handles lkpPropiedadBicicletaE1.Enter
        BeginInvoke(New MethodInvoker(Sub() CType(sender, GridLookUpEdit).ShowPopup()))
    End Sub

    Private Sub lkpTipoTarifaBusE1_Enter(sender As Object, e As EventArgs) Handles lkpTipoTarifaBusE1.Enter
        BeginInvoke(New MethodInvoker(Sub() CType(sender, GridLookUpEdit).ShowPopup()))
    End Sub

    Private Sub lkpLugarBajadaBusE1_Enter(sender As Object, e As EventArgs) Handles lkpLugarBajadaBusE1.Enter
        BeginInvoke(New MethodInvoker(Sub() CType(sender, GridLookUpEdit).ShowPopup()))
    End Sub

    Private Sub lkpViajaComoE2_EditValueChanged(sender As Object, e As EventArgs) Handles lkpViajaComoE2.EditValueChanged
        Dim opcion As Integer

        Me.spcPagoBajadaAutoE2.Collapsed = True
        Me.lkpDondeEstacionaE2.Visible = False
        Me.txtCuantoPagoE2.Visible = False
        Me.lkpFormaPagoE2.Visible = False

        If lkpViajaComoE2.EditValue IsNot Nothing AndAlso Me.lkpViajaComoE2.EditValue.ToString <> "" Then
            opcion = Me.lkpViajaComoE2.EditValue
        End If

        If opcion = 1 Then
            Me.spcPagoBajadaAutoE2.Collapsed = False
            Me.lkpDondeEstacionaE2.Visible = True
            Me.txtCuantoPagoE2.Visible = True
            Me.lkpFormaPagoE2.Visible = True

            'Validador viaja como chofer y no tiene licencia
            Try
                Dim licencia As Integer = persona.LicenciaConducir

                If licencia = 2 Then
                    If validadorEtapa2 IsNot Nothing Then
                        validadorEtapa2.Val16 = True
                    End If
                    Dim confirma As DialogResult = MessageBox.Show("El encuestado viaja como chofer pero no indicó que posea licencia de conducir, ¿confirma que es correcto?", "Verificación de datos", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                    If confirma = Windows.Forms.DialogResult.No Then
                        lkpViajaComoE2.EditValue = -1
                        lkpViajaComoE2.Focus()
                        If validadorEtapa2 IsNot Nothing Then
                            validadorEtapa2.Val16 = False
                        End If
                    Else
                        If validadorEtapa2 IsNot Nothing Then
                            validadorEtapa2.Val16Resp = True
                        End If
                    End If
                End If
            Catch
            End Try

            'Validador chofer menor de edad
            Try
                Dim edad As Integer = DateTime.Now.Year - persona.AnoNac
                If edad < 18 Then
                    Dim confirma As DialogResult = MessageBox.Show("El encuestado viaja como chofer pero es menor de edad, ¿confirma que es correcto?", "Verificación de datos", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                    If confirma = Windows.Forms.DialogResult.No Then
                        lkpViajaComoE2.EditValue = -1
                        lkpViajaComoE2.Focus()
                        If validadorEtapa2 IsNot Nothing Then
                            validadorEtapa2.Val16 = False
                        End If
                    Else
                        If validadorEtapa2 IsNot Nothing Then
                            validadorEtapa2.Val16Resp = True
                        End If
                    End If
                End If
            Catch ex As Exception
            End Try

        End If
    End Sub

    Private Sub lkpViajaComoE3_EditValueChanged(sender As Object, e As EventArgs) Handles lkpViajaComoE3.EditValueChanged
        Dim opcion As Integer

        Me.spcPagoBajadaAutoE3.Collapsed = True
        Me.lkpDondeEstacionaE3.Visible = False
        Me.txtCuantoPagoE3.Visible = False
        Me.lkpFormaPagoE3.Visible = False

        If lkpViajaComoE3.EditValue IsNot Nothing AndAlso Me.lkpViajaComoE3.EditValue.ToString <> "" Then
            opcion = Me.lkpViajaComoE3.EditValue
        End If

        If opcion = 1 Then
            Me.spcPagoBajadaAutoE3.Collapsed = False
            Me.lkpDondeEstacionaE3.Visible = True
            Me.txtCuantoPagoE3.Visible = True
            Me.lkpFormaPagoE3.Visible = True

            'Validador viaja como chofer y no tiene licencia
            Try
                Dim licencia As Integer = persona.LicenciaConducir

                If licencia = 2 Then
                    If validadorEtapa3 IsNot Nothing Then
                        validadorEtapa3.Val16 = True
                    End If
                    Dim confirma As DialogResult = MessageBox.Show("El encuestado viaja como chofer pero no indicó que posea licencia de conducir, ¿confirma que es correcto?", "Verificación de datos", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                    If confirma = Windows.Forms.DialogResult.No Then
                        lkpViajaComoE3.EditValue = -1
                        lkpViajaComoE3.Focus()
                        If validadorEtapa3 IsNot Nothing Then
                            validadorEtapa3.Val16 = False
                        End If
                    Else
                        If validadorEtapa3 IsNot Nothing Then
                            validadorEtapa3.Val16Resp = True
                        End If
                    End If
                End If
            Catch
            End Try

            'Validador chofer menor de edad
            Try
                Dim edad As Integer = DateTime.Now.Year - persona.AnoNac
                If edad < 18 Then
                    Dim confirma As DialogResult = MessageBox.Show("El encuestado viaja como chofer pero es menor de edad, ¿confirma que es correcto?", "Verificación de datos", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                    If confirma = Windows.Forms.DialogResult.No Then
                        lkpViajaComoE3.EditValue = -1
                        lkpViajaComoE3.Focus()
                        If validadorEtapa3 IsNot Nothing Then
                            validadorEtapa3.Val16 = False
                        End If
                    Else
                        If validadorEtapa3 IsNot Nothing Then
                            validadorEtapa3.Val16Resp = True
                        End If
                    End If
                End If
            Catch ex As Exception
            End Try

        End If
    End Sub

    Private Sub lkpTrasnoche_EditValueChanged(sender As Object, e As EventArgs) Handles lkpTrasnoche.EditValueChanged
        Dim opcion As Integer

        If Not (Me.lkpTrasnoche.EditValue Is Nothing OrElse Me.lkpTrasnoche.EditValue.ToString = "") Then
            opcion = Me.lkpTrasnoche.EditValue
        End If

        Dim horaSalida As DateTime = Me.tmHoraSalida.EditValue
        Dim horaLlegada As DateTime = Me.tmHoraLlegada.EditValue

        If opcion = 2 Then
            'Validador hora de llegada superior a hora de salida
            If horaLlegada <= horaSalida Then
                MessageBox.Show("Las horas de salida y llegada del viaje son inconsistentes. Por favor, revisar", "Dato inconsistente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                tmHoraSalida.Focus()
            End If

            'Validador viaje intrazonal mayor a 30 minutos en modo distinto a caminata, viaje 1
            If lkpComunaOrigen.EditValue IsNot Nothing AndAlso (lkpComunaOrigen.EditValue.ToString = "2" OrElse lkpComunaOrigen.EditValue.ToString = "3") AndAlso lkpComunaDestino.EditValue IsNot Nothing AndAlso (lkpComunaDestino.EditValue.ToString = "2" OrElse lkpComunaDestino.EditValue.ToString = "3") Then
                If idViaje = 1 Then
                    If Me.lkpTransporte1.EditValue IsNot Nothing AndAlso Me.lkpTransporte1.EditValue.ToString <> "" Then
                        If Me.lkpTransporte1.EditValue <> 7 Then
                            If Me.lkpManzanaOrigen.EditValue IsNot Nothing AndAlso Me.lkpManzanaDestino.EditValue IsNot Nothing Then
                                If Me.lkpManzanaOrigen.EditValue.ToString <> "" AndAlso Me.lkpManzanaDestino.EditValue.ToString <> "" Then
                                    If Not Me.lkpTransporte1.EditValue Is Nothing AndAlso Me.lkpTransporte1.EditValue.ToString <> "" Then
                                        Dim zonaOrigen As Integer = Me.lkpManzanaOrigen.EditValue \ 1000
                                        Dim zonaDestino As Integer = Me.lkpManzanaDestino.EditValue \ 1000
                                        If zonaOrigen = zonaDestino Then
                                            validadorViaje.Val9 = True
                                            Dim confirma As DialogResult = MessageBox.Show("Este viaje es intrazonal pero duró más de 30 minutos, ¿confirma que es correcto?", "Verificación de datos", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                                            If confirma = Windows.Forms.DialogResult.No Then
                                                validadorViaje.Val9 = False
                                                Me.lkpManzanaDestino.EditValue = ""
                                                Me.lkpManzanaDestino.Focus()
                                            Else
                                                validadorViaje.Val9Resp = True
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                ElseIf idViaje > 1 Then
                    If Me.lkpTransporte1.EditValue IsNot Nothing AndAlso Me.lkpTransporte1.EditValue.ToString <> "" Then
                        If Me.lkpTransporte1.EditValue <> 7 Then
                            If Not Me.txtManzanaAnterior.Text = "" AndAlso Me.lkpManzanaDestino.EditValue IsNot Nothing Then
                                If Me.txtManzanaAnterior.Text <> "" AndAlso Me.lkpManzanaDestino.EditValue.ToString <> "" Then
                                    If Me.lkpTransporte1.EditValue IsNot Nothing AndAlso Me.lkpTransporte1.EditValue.ToString <> "" Then
                                        Dim manzanaAnterior As Integer = Me.txtManzanaAnterior.Text
                                        Dim zonaOrigen As Integer = manzanaAnterior \ 1000
                                        Dim zonaDestino As Integer = Me.lkpManzanaDestino.EditValue \ 1000
                                        If zonaOrigen = zonaDestino Then
                                            validadorViaje.Val9 = True
                                            Dim confirma As DialogResult = MessageBox.Show("Este viaje es intrazonal pero duró más de 30 minutos, ¿confirma que es correcto?", "Verificación de datos", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                                            If confirma = Windows.Forms.DialogResult.No Then
                                                validadorViaje.Val9 = False
                                                Me.lkpManzanaDestino.EditValue = ""
                                                Me.lkpManzanaDestino.Focus()
                                            Else
                                                validadorViaje.Val9Resp = True
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        ElseIf opcion = 1 Then
            'Validador hora de llegada superior a hora de salida
            If horaLlegada >= horaSalida Then
                MessageBox.Show("Las horas de salida y llegada del viaje son inconsistentes. Por favor, revisar", "Dato inconsistente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                tmHoraSalida.Focus()
            End If
        End If

        'Viaje a pie, calcular minutos viaje
        If lkpTransporte1.EditValue IsNot Nothing AndAlso lkpTransporte1.EditValue.ToString <> "" AndAlso lkpTransporte1.EditValue = 7 Then
            Dim dtLlegada As DateTime = tmHoraLlegada.EditValue
            Dim dtSalida As DateTime = tmHoraSalida.EditValue
            Select Case opcion
                Case 1
                    Dim tpoViaje As Integer = (dtSalida - dtLlegada).TotalMinutes
                    txtMinutosDespues.Text = tpoViaje
                Case 2
                    Dim tpoViaje As Integer = (dtLlegada - dtSalida).TotalMinutes
                    txtMinutosDespues.Text = tpoViaje
            End Select
        End If

    End Sub

    Private Sub lkpProposito_EditValueChanged(sender As Object, e As EventArgs) Handles lkpProposito.EditValueChanged

        Dim opcion As Integer

        If lkpProposito.EditValue IsNot Nothing AndAlso lkpProposito.EditValue.ToString <> "" Then
            opcion = lkpProposito.EditValue
        End If


        Me.lblOtroProposito.Visible = False
        Me.txtOtroProposito.Visible = False
        Me.lkpTrabajoDeclarado.Visible = False
        Me.lblTrabajoDeclarado.Visible = False
        Me.lkpEstudioDeclarado.Visible = False
        Me.lblEstudioDeclarado.Visible = False

        Me.lkpComunaDestino.Enabled = True
        Me.lkpCalle1Destino.Enabled = True
        Me.lkpCalle2Destino.Enabled = True
        Me.lkpManzanaDestino.Enabled = True

        If opcion > 0 Then
            Dim persona As datasetEOD.PersonaRow
            Try
                persona = datasetEOD.Persona.Select("hogar = " & Me.idFolio & " and persona = " & Me.idPersona)(0)
                Dim trabaja As Boolean = persona.Actividad.Contains("1")
                Dim estudia As Boolean = persona.Actividad.Contains("2")
                Dim edad As Integer = DateTime.Now.Year - persona.AnoNac

                If opcion = 1 Then
                    'Validador menor de edad viaja por trabajo
                    If trabaja Then
                        If edad < 18 Then
                            validadorViaje.Val6 = True

                            If validadorViaje.Val6Resp = False Then
                                Dim confirma As DialogResult = MessageBox.Show("Ha indicado que un menor de edad viaja por trabajo, ¿confirma que es correcto?", "Verificación de datos", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                                If confirma = Windows.Forms.DialogResult.No Then
                                    lkpProposito.EditValue = ""
                                    lkpProposito.Focus()
                                    validadorViaje.Val6 = False
                                Else
                                    validadorViaje.Val6Resp = True
                                    Me.spLugarDeclarado.CollapsePanel = SplitCollapsePanel.Panel2
                                    Me.lkpTrabajoDeclarado.Visible = True
                                    Me.lblTrabajoDeclarado.Visible = True
                                End If
                            End If
                        Else
                            Me.spLugarDeclarado.CollapsePanel = SplitCollapsePanel.Panel2
                            Me.lkpTrabajoDeclarado.Visible = True
                            Me.lblTrabajoDeclarado.Visible = True
                        End If
                    End If
                    If edad < 18 Then
                        Dim confirma As DialogResult = MessageBox.Show("Ha indicado que un menor de edad viaja por trabajo, ¿confirma que es correcto?", "Verificación de datos", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                        If confirma = Windows.Forms.DialogResult.No Then
                            lkpProposito.EditValue = ""
                            lkpProposito.Focus()
                        End If
                    ElseIf Not trabaja Then
                        'Validador viaja por trabajo y su actividad no es trabajo
                        Dim confirma As DialogResult = MessageBox.Show("Ha indicado que viaja por trabajo, pero su actividad no es Trabajo, ¿confirma que es correcto?", "Verificación de datos", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                        If confirma = Windows.Forms.DialogResult.No Then
                            lkpProposito.EditValue = ""
                            lkpProposito.Focus()
                        End If
                    End If
                End If

                If opcion = 2 Then
                    If estudia Then
                        Me.spLugarDeclarado.CollapsePanel = SplitCollapsePanel.Panel1
                        Me.lkpEstudioDeclarado.Visible = True
                        Me.lblEstudioDeclarado.Visible = True
                    Else
                        'Validador viaja por estudio y su actividad no es estudio
                        validadorViaje.Val7 = True

                        If validadorViaje.Val7Resp = False Then
                            Dim confirma As DialogResult = MessageBox.Show("Ha indicado que viaja por estudio, pero su actividad no es Estudio, ¿confirma que es correcto?", "Verificación de datos", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                            If confirma = Windows.Forms.DialogResult.No Then
                                lkpProposito.EditValue = ""
                                lkpProposito.Focus()
                                validadorViaje.Val7 = False
                            Else
                                validadorViaje.Val7Resp = True
                                Me.spLugarDeclarado.CollapsePanel = SplitCollapsePanel.Panel1
                                Me.lkpEstudioDeclarado.Visible = True
                                Me.lblEstudioDeclarado.Visible = True
                            End If
                        End If
                    End If
                End If

                If opcion = 4 Then
                    'Cargar datos de casa
                    Try
                        Dim objConn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\MASCARA REFERENCIA_VF.accdb")
                        objConn.Open()
                        Dim objCommand As New OleDbCommand("select comuna, nombrecalle, numero, manzana from hogar where hogar = ?", objConn)
                        Dim parametro As New OleDbParameter("hogar", Me.idFolio)
                        objCommand.Parameters.Add(parametro)

                        Dim reader As OleDbDataReader = objCommand.ExecuteReader()
                        While reader.Read()
                            Me.nombreCalleHogar = reader.Item("nombrecalle")
                            Me.comunaHogar = reader.Item("comuna")
                            Me.numeroHogar = reader.Item("numero")
                            Me.manzanaHogar = reader.Item("manzana")
                        End While

                        'Llena campos comuna y calles con valores hogar
                        Me.lkpComunaDestino.EditValue = Me.comunaHogar
                        Me.lkpCalle1Destino.EditValue = Me.nombreCalleHogar
                        Me.lkpCalle2Destino.EditValue = Me.numeroHogar

                        'Llenado de campo manzana con valor hogar
                        For i As Integer = 0 To 3
                            If Not Me.lkpManzanaDestino.Properties.Columns.GetVisibleColumn(i) Is Nothing Then
                                Me.lkpManzanaDestino.Properties.Columns.Remove(Me.lkpManzanaDestino.Properties.Columns.GetVisibleColumn(i))
                            End If
                        Next

                        Try
                            Dim args As DevExpress.XtraEditors.Controls.CloseUpEventArgs = New DevExpress.XtraEditors.Controls.CloseUpEventArgs(Nothing)
                            args.AcceptValue = True
                            args.Value = Me.numeroHogar
                            Me.lkpCalle2Destino_CloseUp(lkpCalle2Destino, args)
                            Me.lkpManzanaDestino.EditValue = Me.manzanaHogar
                        Catch ex As Exception

                        End Try

                        'Bloquear campos
                        Me.lkpComunaDestino.Enabled = False
                        Me.lkpCalle1Destino.Enabled = False
                        Me.lkpCalle2Destino.Enabled = False
                        Me.lkpManzanaDestino.Enabled = False

                        reader.Close()
                        objCommand.Dispose()
                        objConn.Close()

                        Me.lkpTransporte1.Focus()

                    Catch ex As Exception
                        MessageBox.Show(ex.Message + vbCrLf + vbCrLf + ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End If

                If opcion = 9 Then
                    Me.spDestinoViaje.Collapsed = False
                    Me.lblOtroProposito.Visible = True
                    Me.txtOtroProposito.Visible = True
                Else
                    Me.spDestinoViaje.Collapsed = True
                End If

            Catch ex As Exception
                MessageBox.Show("Error leyendo persona en base de datos", "Error de lectura", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub lkpLugarDondeBajoE2_EditValueChanged(sender As Object, e As EventArgs) Handles lkpLugarBajadaAutoE2.EditValueChanged
        Dim opcion As Integer

        If lkpLugarBajadaAutoE2.EditValue IsNot Nothing AndAlso Me.lkpLugarBajadaAutoE2.EditValue.ToString <> "" Then
            opcion = Me.lkpLugarBajadaAutoE2.EditValue
        End If

        'Desbloquear caminata posterior
        Me.txtCuadrasDespues.Enabled = True
        Me.txtMinutosDespues.Enabled = True

        Select Case opcion
            Case 1
                mismaManzanaDestino = True
                'Bloquear caminata posterior
                Me.txtCuadrasDespues.Text = "0"
                Me.txtCuadrasDespues.Enabled = False
                Me.txtMinutosDespues.Text = "0"
                Me.txtMinutosDespues.Enabled = False

                'Llenado destino con destino de viaje
                Me.gcLugarBajadaEtapa2.Visible = True
                Me.lkpComunaEtapa2.EditValue = Me.lkpComunaDestino.EditValue
                Me.txtComunaOtraEtapa2.Text = Me.txtComunaDestinoOtra.Text
                Me.lkpCalle1Etapa2.EditValue = Me.lkpCalle1Destino.EditValue
                Me.lkpCalle2Etapa2.EditValue = Me.lkpCalle2Destino.EditValue
                Dim args As DevExpress.XtraEditors.Controls.CloseUpEventArgs = New DevExpress.XtraEditors.Controls.CloseUpEventArgs(Nothing)
                args.AcceptValue = True
                args.Value = Me.lkpCalle2Destino.EditValue
                Me.lkpCalle2Etapa2_CloseUp(lkpCalle2Etapa2, args)
                Me.lkpHitoEtapa2.EditValue = Me.lkpHitoDestino.EditValue
                Me.lkpManzanaEtapa2.ItemIndex = Me.lkpManzanaDestino.ItemIndex
                Me.tmHoraLlegada.Focus()
            Case 3
                Me.gcLugarBajadaEtapa2.Visible = True
                Me.lkpComunaEtapa2.EditValue = ""
                Me.txtComunaOtraEtapa2.Text = ""
                Me.lkpCalle1Etapa2.EditValue = ""
                Me.lkpCalle2Etapa2.EditValue = ""
                Me.lkpHitoEtapa2.EditValue = ""
                Me.txtCuadrasDespues.Enabled = True
                Me.txtMinutosDespues.Enabled = True
                Me.lkpManzanaEtapa2.Properties.DataSource = Nothing
        End Select
    End Sub

    Private Sub lkpLugarDondeBajoE3_EditValueChanged(sender As Object, e As EventArgs) Handles lkpLugarBajadaAutoE3.EditValueChanged
        Dim opcion As Integer

        If lkpLugarBajadaAutoE3.EditValue IsNot Nothing AndAlso Me.lkpLugarBajadaAutoE3.EditValue.ToString <> "" Then
            opcion = Me.lkpLugarBajadaAutoE3.EditValue
        End If

        'Desbloquear caminata posterior
        Me.txtCuadrasDespues.Enabled = True
        Me.txtMinutosDespues.Enabled = True

        Select Case opcion
            Case 1
                mismaManzanaDestino = True
                'Bloquear caminata posterior
                Me.txtCuadrasDespues.Text = "0"
                Me.txtCuadrasDespues.Enabled = False
                Me.txtMinutosDespues.Text = "0"
                Me.txtMinutosDespues.Enabled = False

                'Llenado destino con destino de viaje
                Me.gcLugarBajadaEtapa3.Visible = True
                Me.lkpComunaEtapa3.EditValue = Me.lkpComunaDestino.EditValue
                Me.txtComunaOtraEtapa3.Text = Me.txtComunaDestinoOtra.Text
                Me.lkpCalle1Etapa3.EditValue = Me.lkpCalle1Destino.EditValue
                Me.lkpCalle2Etapa3.EditValue = Me.lkpCalle2Destino.EditValue
                Dim args As DevExpress.XtraEditors.Controls.CloseUpEventArgs = New DevExpress.XtraEditors.Controls.CloseUpEventArgs(Nothing)
                args.AcceptValue = True
                args.Value = Me.lkpCalle2Destino.EditValue
                Me.lkpCalle2Etapa3_CloseUp(lkpCalle2Etapa3, args)
                Me.lkpHitoEtapa3.EditValue = Me.lkpHitoDestino.EditValue
                Me.lkpManzanaEtapa3.ItemIndex = Me.lkpManzanaDestino.ItemIndex
                Me.tmHoraLlegada.Focus()
            Case 3
                Me.gcLugarBajadaEtapa3.Visible = True
                Me.lkpComunaEtapa3.EditValue = ""
                Me.txtComunaOtraEtapa3.Text = ""
                Me.lkpCalle1Etapa3.EditValue = ""
                Me.lkpCalle2Etapa3.EditValue = ""
                Me.lkpHitoEtapa3.EditValue = ""
                Me.txtCuadrasDespues.Enabled = True
                Me.txtMinutosDespues.Enabled = True
                Me.lkpManzanaEtapa3.Properties.DataSource = Nothing
        End Select
    End Sub

    Private Sub txtCuadrasDespues_EditValueChanged(sender As Object, e As EventArgs) Handles txtCuadrasDespues.EditValueChanged
        Dim cuadrasDespues As Integer = Convert.ToInt32(Me.txtCuadrasDespues.Text)

        'Validador más de 2 cuadras después en t. público
        If cuadrasDespues > 2 Then
            'Comprobar tercera etapa
            Dim muestraValidadorTP As Boolean = False

            If Not lkpTransporte3.EditValue Is Nothing AndAlso lkpTransporte3.EditValue.ToString <> "" Then
                Dim etapa3 As Integer = Me.lkpTransporte3.EditValue

                Select Case etapa3
                    Case 2
                        If Not lkpLugarBajadaBusE3.EditValue Is Nothing AndAlso Me.lkpLugarBajadaBusE3.EditValue = 1 Then
                            muestraValidadorTP = True
                        End If
                    Case 3, 4
                        If Not lkpLugarBajadaTXCE3.EditValue Is Nothing AndAlso Me.lkpLugarBajadaTXCE3.EditValue = 1 Then
                            muestraValidadorTP = True
                        End If
                End Select

                'Comprobar segunda etapa
                If Not lkpTransporte2.EditValue Is Nothing AndAlso lkpTransporte2.EditValue.ToString <> "" Then
                    Dim etapa2 As Integer = Me.lkpTransporte2.EditValue

                    Select Case etapa2
                        Case 2
                            If Not lkpLugarBajadaBusE2.EditValue Is Nothing AndAlso Me.lkpLugarBajadaBusE2.EditValue = 1 Then
                                muestraValidadorTP = True
                            End If
                        Case 3, 4
                            If Not lkpLugarBajadaTXCE2.EditValue Is Nothing AndAlso Me.lkpLugarBajadaTXCE2.EditValue = 1 Then
                                muestraValidadorTP = True
                            End If
                    End Select

                    'Comprobar primera etapa
                    If Not lkpTransporte1.EditValue Is Nothing AndAlso lkpTransporte1.EditValue.ToString <> "" Then
                        Dim etapa1 As Integer = Me.lkpTransporte1.EditValue

                        Select Case etapa1
                            Case 2
                                If Not lkpLugarBajadaBusE1.EditValue Is Nothing AndAlso Me.lkpLugarBajadaBusE1.EditValue = 1 Then
                                    muestraValidadorTP = True
                                End If
                            Case 3, 4
                                If Not lkpLugarBajadaTXCE1.EditValue Is Nothing AndAlso Me.lkpLugarBajadaTXCE1.EditValue = 1 Then
                                    muestraValidadorTP = True
                                End If
                        End Select
                    End If
                End If
            End If

            If muestraValidadorTP Then
                Dim confirma As DialogResult = MessageBox.Show("Ha indicado que se baja en el lugar de destino pero posteriormente camina más de 2 cuadras, ¿confirma que es correcto?", "Verificación de datos", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                If confirma = Windows.Forms.DialogResult.No Then
                    txtCuadrasDespues.Text = ""
                    txtCuadrasDespues.Focus()
                End If
            End If
        End If


        'Validador caminata con cuadras 0
        If Not lkpTransporte1.EditValue Is Nothing AndAlso lkpTransporte1.EditValue.ToString <> "" Then
            If lkpTransporte1.EditValue = 7 AndAlso Me.txtCuadrasDespues.Text <> "" Then
                If Convert.ToInt32(Me.txtCuadrasDespues.Text) = 0 Then
                    MessageBox.Show("Debe indicar un valor de cuadras caminadas mayor a 0", "Dato inconsistente", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                    txtCuadrasDespues.Text = ""
                    txtCuadrasDespues.Focus()
                End If
            Else
                If txtCuadrasDespues.Text = "0" Then
                    txtMinutosDespues.Text = "0"
                End If
            End If
        End If



    End Sub

    Private Sub txtMinutosDespues_EditValueChanged(sender As Object, e As EventArgs) Handles txtMinutosDespues.EditValueChanged
        'Validador caminata con minutos 0
        If Not lkpTransporte1.EditValue Is Nothing AndAlso lkpTransporte1.EditValue.ToString <> "" Then
            If lkpTransporte1.EditValue = 7 AndAlso Me.txtMinutosDespues.Text <> "" Then
                If Convert.ToInt32(Me.txtMinutosDespues.Text) = 0 Then
                    MessageBox.Show("Debe indicar un valor de minutos caminados mayor a 0", "Dato inconsistente", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                    txtMinutosDespues.Text = ""
                    txtMinutosDespues.Focus()
                End If
            End If
        ElseIf Convert.ToInt32(txtMinutosDespues.Text) = 0 AndAlso txtCuadrasDespues.Text <> "" AndAlso Convert.ToInt32(txtCuadrasDespues.Text) > 0 Then
            MessageBox.Show("Ha indicado que caminó algunas cuadras en 0 minutos, corrija para continuar", "Dato inconsistente", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtMinutosDespues.Text = ""
            txtCuadrasDespues.Text = ""
            txtCuadrasDespues.Focus()
        ElseIf Convert.ToInt32(txtMinutosDespues.Text) > 0 AndAlso txtCuadrasDespues.Text <> "" AndAlso Convert.ToInt32(txtCuadrasDespues.Text) = 0 Then
            MessageBox.Show("Ha indicado que caminó algunos minutos pero 0 cuadras, corrija para continuar", "Dato inconsistente", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtCuadrasDespues.Focus()

        End If
    End Sub
    Private Sub txtCuadrasAutoE1_Leave(sender As Object, e As EventArgs) Handles txtCuadrasAutoE1.Leave
        If txtCuadrasAutoE1.Text <> "" Then

            'Validador cuadras para llegar a vehículo mayor a 5
            If Convert.ToInt32(txtCuadrasAutoE1.Text) > 5 Then
                If validadorEtapa1 IsNot Nothing Then
                    validadorEtapa1.Val1 = True
                End If
                Dim confirma As DialogResult = MessageBox.Show("Ha indicado que caminó más de 5 cuadras para llegar al vehículo, ¿confirma que es correcto?", "Verificación de datos", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                If confirma = Windows.Forms.DialogResult.No Then
                    txtCuadrasAutoE1.Text = ""
                    txtCuadrasAutoE1.Focus()
                    If validadorEtapa1 IsNot Nothing Then
                        validadorEtapa1.Val1 = False
                    End If
                Else
                    If validadorEtapa1 IsNot Nothing Then
                        validadorEtapa1.Val1Resp = True
                    End If
                End If
            ElseIf Convert.ToInt32(txtCuadrasAutoE1.Text) = 0 Then
                txtMinutosAutoE1.Text = 0
                lkpViajaComoE1.Focus()
            End If
        End If
    End Sub

    Private Sub txtCuadrasAutoE2_Leave(sender As Object, e As EventArgs) Handles txtCuadrasAutoE2.Leave
        If txtCuadrasAutoE2.Text <> "" Then

            'Validador cuadras para llegar a vehículo mayor a 5
            If Convert.ToInt32(txtCuadrasAutoE2.Text) > 5 Then
                If validadorEtapa2 IsNot Nothing Then
                    validadorEtapa2.Val1 = True
                End If
                Dim confirma As DialogResult = MessageBox.Show("Ha indicado que caminó más de 5 cuadras para llegar al vehículo, ¿confirma que es correcto?", "Verificación de datos", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                If confirma = Windows.Forms.DialogResult.No Then
                    txtCuadrasAutoE2.Text = ""
                    txtCuadrasAutoE2.Focus()
                    If validadorEtapa2 IsNot Nothing Then
                        validadorEtapa2.Val1 = False
                    End If
                Else
                    If validadorEtapa2 IsNot Nothing Then
                        validadorEtapa2.Val1Resp = True
                    End If
                End If
            ElseIf Convert.ToInt32(txtCuadrasAutoE2.Text) = 0 Then
                txtMinutosAutoE2.Text = 0
                lkpViajaComoE2.Focus()
            End If
        End If
    End Sub

    Private Sub txtCuadrasAutoE3_Leave(sender As Object, e As EventArgs) Handles txtCuadrasAutoE3.Leave
        If txtCuadrasAutoE3.Text <> "" Then

            'Validador cuadras para llegar a vehículo mayor a 5
            If Convert.ToInt32(txtCuadrasAutoE3.Text) > 5 Then
                If validadorEtapa3 IsNot Nothing Then
                    validadorEtapa3.Val1 = True
                End If
                Dim confirma As DialogResult = MessageBox.Show("Ha indicado que caminó más de 5 cuadras para llegar al vehículo, ¿confirma que es correcto?", "Verificación de datos", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                If confirma = Windows.Forms.DialogResult.No Then
                    txtCuadrasAutoE3.Text = ""
                    txtCuadrasAutoE3.Focus()
                    If validadorEtapa3 IsNot Nothing Then
                        validadorEtapa3.Val1 = False
                    End If
                Else
                    If validadorEtapa3 IsNot Nothing Then
                        validadorEtapa3.Val1Resp = True
                    End If
                End If
            ElseIf Convert.ToInt32(txtCuadrasAutoE3.Text) = 0 Then
                txtMinutosAutoE3.Text = 0
                lkpViajaComoE3.Focus()
            End If
        End If
    End Sub

    Private Sub txtMinutosAutoE1_Leave(sender As Object, e As EventArgs) Handles txtMinutosAutoE1.Leave
        If txtMinutosAutoE1.Text <> "" Then

            'Validador minutos para llegar a vehículo mayor a 10
            If Convert.ToInt32(txtMinutosAutoE1.Text) > 10 Then
                If validadorEtapa1 IsNot Nothing Then
                    validadorEtapa1.Val2 = True
                End If
                Dim confirma As DialogResult = MessageBox.Show("Ha indicado que caminó más de 10 minutos para llegar al vehículo, ¿confirma que es correcto?", "Verificación de datos", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                If confirma = Windows.Forms.DialogResult.No Then
                    txtMinutosAutoE1.Text = ""
                    txtMinutosAutoE1.Focus()
                    If validadorEtapa1 IsNot Nothing Then
                        validadorEtapa1.Val2 = False
                    End If
                Else
                    If validadorEtapa1 IsNot Nothing Then
                        validadorEtapa1.Val2Resp = True
                    End If
                End If
            ElseIf Convert.ToInt32(txtMinutosAutoE1.Text) = 0 AndAlso txtCuadrasAutoE1.Text <> "" AndAlso Convert.ToInt32(txtCuadrasAutoE1.Text) > 0 Then
                MessageBox.Show("Ha indicado que caminó algunas cuadras en 0 minutos, corrija para continuar", "Dato inconsistente", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtMinutosAutoE1.Text = ""
                txtCuadrasAutoE1.Text = ""
                txtCuadrasAutoE1.Focus()
            ElseIf Convert.ToInt32(txtMinutosAutoE1.Text) > 0 AndAlso txtCuadrasAutoE1.Text <> "" AndAlso Convert.ToInt32(txtCuadrasAutoE1.Text) = 0 Then
                MessageBox.Show("Ha indicado que caminó algunos minutos pero 0 cuadras, corrija para continuar", "Dato inconsistente", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtMinutosAutoE1.Text = ""
                txtCuadrasAutoE1.Focus()
            End If
        End If
    End Sub

    Private Sub txtMinutosAutoE2_Leave(sender As Object, e As EventArgs) Handles txtMinutosAutoE2.Leave
        If txtMinutosAutoE2.Text <> "" Then

            'Validador minutos para llegar a vehículo mayor a 10
            If Convert.ToInt32(txtMinutosAutoE2.Text) > 10 Then
                If validadorEtapa2 IsNot Nothing Then
                    validadorEtapa2.Val2 = True
                End If
                Dim confirma As DialogResult = MessageBox.Show("Ha indicado que caminó más de 10 minutos para llegar al vehículo, ¿confirma que es correcto?", "Verificación de datos", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                If confirma = Windows.Forms.DialogResult.No Then
                    txtMinutosAutoE2.Text = ""
                    txtMinutosAutoE2.Focus()
                    If validadorEtapa2 IsNot Nothing Then
                        validadorEtapa2.Val2 = False
                    End If
                Else
                    If validadorEtapa2 IsNot Nothing Then
                        validadorEtapa2.Val2Resp = True
                    End If
                End If
            ElseIf Convert.ToInt32(txtMinutosAutoE2.Text) = 0 AndAlso txtCuadrasAutoE2.Text <> "" AndAlso Convert.ToInt32(txtCuadrasAutoE2.Text) > 0 Then
                MessageBox.Show("Ha indicado que caminó algunas cuadras en 0 minutos, corrija para continuar", "Dato inconsistente", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtMinutosAutoE2.Text = ""
                txtCuadrasAutoE2.Text = ""
                txtCuadrasAutoE2.Focus()
            ElseIf Convert.ToInt32(txtMinutosAutoE2.Text) > 0 AndAlso txtCuadrasAutoE2.Text <> "" AndAlso Convert.ToInt32(txtCuadrasAutoE2.Text) = 0 Then
                MessageBox.Show("Ha indicado que caminó algunos minutos pero 0 cuadras, corrija para continuar", "Dato inconsistente", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtMinutosAutoE2.Text = ""
                txtCuadrasAutoE2.Focus()
            End If
        End If
    End Sub

    Private Sub txtMinutosAutoE3_Leave(sender As Object, e As EventArgs) Handles txtMinutosAutoE3.Leave
        If txtMinutosAutoE3.Text <> "" Then

            'Validador minutos para llegar a vehículo mayor a 10
            If Convert.ToInt32(txtMinutosAutoE3.Text) > 10 Then
                If validadorEtapa3 IsNot Nothing Then
                    validadorEtapa3.Val2 = True
                End If
                Dim confirma As DialogResult = MessageBox.Show("Ha indicado que caminó más de 10 minutos para llegar al vehículo, ¿confirma que es correcto?", "Verificación de datos", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                If confirma = Windows.Forms.DialogResult.No Then
                    txtMinutosAutoE3.Text = ""
                    txtMinutosAutoE3.Focus()
                    If validadorEtapa3 IsNot Nothing Then
                        validadorEtapa3.Val2 = False
                    End If
                Else
                    If validadorEtapa3 IsNot Nothing Then
                        validadorEtapa3.Val2Resp = True
                    End If
                End If
            ElseIf Convert.ToInt32(txtMinutosAutoE3.Text) = 0 AndAlso txtCuadrasAutoE3.Text <> "" AndAlso Convert.ToInt32(txtCuadrasAutoE3.Text) > 0 Then
                MessageBox.Show("Ha indicado que caminó algunas cuadras en 0 minutos, corrija para continuar", "Dato inconsistente", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtMinutosAutoE3.Text = ""
                txtCuadrasAutoE3.Text = ""
                txtCuadrasAutoE3.Focus()
            ElseIf Convert.ToInt32(txtMinutosAutoE3.Text) > 0 AndAlso txtCuadrasAutoE3.Text <> "" AndAlso Convert.ToInt32(txtCuadrasAutoE3.Text) = 0 Then
                MessageBox.Show("Ha indicado que caminó algunos minutos pero 0 cuadras, corrija para continuar", "Dato inconsistente", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtMinutosAutoE3.Text = ""
                txtCuadrasAutoE3.Focus()
            End If
        End If
    End Sub

    Private Sub txtCuadrasBusE1_Leave(sender As Object, e As EventArgs) Handles txtCuadrasBusE1.Leave
        If txtCuadrasBusE1.Text <> "" Then

            'Validador cuadras para llegar a vehículo mayor a 10
            If Convert.ToInt32(txtCuadrasBusE1.Text) > 10 Then
                If validadorEtapa1 IsNot Nothing Then
                    validadorEtapa1.Val3 = True
                End If
                Dim confirma As DialogResult = MessageBox.Show("Ha indicado que caminó más de 10 cuadras para llegar al bus, ¿confirma que es correcto?", "Verificación de datos", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                If confirma = Windows.Forms.DialogResult.No Then
                    txtCuadrasBusE1.Text = ""
                    txtCuadrasBusE1.Focus()
                    If validadorEtapa1 IsNot Nothing Then
                        validadorEtapa1.Val3 = False
                    End If
                Else
                    If validadorEtapa1 IsNot Nothing Then
                        validadorEtapa1.Val3Resp = True
                    End If
                End If
            ElseIf Convert.ToInt32(txtCuadrasBusE1.Text) = 0 Then
                txtMinutosBusE1.Text = 0
                txtMinutosEsperaBusE1.Focus()
            End If
        End If
    End Sub

    Private Sub txtCuadrasBusE2_Leave(sender As Object, e As EventArgs) Handles txtCuadrasBusE2.Leave
        If txtCuadrasBusE2.Text <> "" Then

            'Validador cuadras para llegar a vehículo mayor a 10
            If Convert.ToInt32(txtCuadrasBusE2.Text) > 10 Then
                If validadorEtapa2 IsNot Nothing Then
                    validadorEtapa2.Val3 = True
                End If
                Dim confirma As DialogResult = MessageBox.Show("Ha indicado que caminó más de 10 cuadras para llegar al bus, ¿confirma que es correcto?", "Verificación de datos", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                If confirma = Windows.Forms.DialogResult.No Then
                    txtCuadrasBusE2.Text = ""
                    txtCuadrasBusE2.Focus()
                    If validadorEtapa2 IsNot Nothing Then
                        validadorEtapa2.Val3 = False
                    End If
                Else
                    If validadorEtapa2 IsNot Nothing Then
                        validadorEtapa2.Val3Resp = True
                    End If
                End If
            ElseIf Convert.ToInt32(txtCuadrasBusE2.Text) = 0 Then
                txtMinutosBusE2.Text = 0
                txtMinutosEsperaBusE2.Focus()
            End If
        End If
    End Sub

    Private Sub txtCuadrasBusE3_Leave(sender As Object, e As EventArgs) Handles txtCuadrasBusE3.Leave
        If txtCuadrasBusE3.Text <> "" Then

            'Validador cuadras para llegar a vehículo mayor a 10
            If Convert.ToInt32(txtCuadrasBusE3.Text) > 10 Then
                If validadorEtapa3 IsNot Nothing Then
                    validadorEtapa3.Val3 = True
                End If
                Dim confirma As DialogResult = MessageBox.Show("Ha indicado que caminó más de 10 cuadras para llegar al bus, ¿confirma que es correcto?", "Verificación de datos", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                If confirma = Windows.Forms.DialogResult.No Then
                    txtCuadrasBusE3.Text = ""
                    txtCuadrasBusE3.Focus()
                    If validadorEtapa3 IsNot Nothing Then
                        validadorEtapa3.Val3 = False
                    End If
                Else
                    If validadorEtapa3 IsNot Nothing Then
                        validadorEtapa3.Val3Resp = True
                    End If
                End If
            ElseIf Convert.ToInt32(txtCuadrasBusE3.Text) = 0 Then
                txtMinutosBusE3.Text = 0
                txtMinutosEsperaBusE3.Focus()
            End If
        End If
    End Sub

    Private Sub txtMinutosBusE1_Leave(sender As Object, e As EventArgs) Handles txtMinutosBusE1.Leave
        If txtMinutosBusE1.Text <> "" Then

            'Validador minutos para llegar a bus mayor a 20
            If Convert.ToInt32(txtMinutosBusE1.Text) > 20 Then
                If validadorEtapa1 IsNot Nothing Then
                    validadorEtapa1.Val4 = True
                End If
                Dim confirma As DialogResult = MessageBox.Show("Ha indicado que caminó más de 20 minutos para llegar al bus, ¿confirma que es correcto?", "Verificación de datos", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                If confirma = Windows.Forms.DialogResult.No Then
                    txtMinutosBusE1.Text = ""
                    txtMinutosBusE1.Focus()
                    If validadorEtapa1 IsNot Nothing Then
                        validadorEtapa1.Val4 = False
                    End If
                Else
                    If validadorEtapa1 IsNot Nothing Then
                        validadorEtapa1.Val4Resp = True
                    End If
                End If
            ElseIf Convert.ToInt32(txtMinutosBusE1.Text) = 0 AndAlso txtCuadrasBusE1.Text <> "" AndAlso Convert.ToInt32(txtCuadrasBusE1.Text) > 0 Then
                MessageBox.Show("Ha indicado que caminó algunas cuadras en 0 minutos, corrija para continuar", "Dato inconsistente", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtMinutosBusE1.Text = ""
                txtCuadrasBusE1.Text = ""
                txtCuadrasBusE1.Focus()
            ElseIf Convert.ToInt32(txtMinutosBusE1.Text) > 0 AndAlso txtCuadrasBusE1.Text <> "" AndAlso Convert.ToInt32(txtCuadrasBusE1.Text) = 0 Then
                MessageBox.Show("Ha indicado que caminó algunos minutos pero 0 cuadras, corrija para continuar", "Dato inconsistente", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtMinutosBusE1.Text = ""
                txtCuadrasBusE1.Focus()
            End If
        End If
    End Sub

    Private Sub txtMinutosBusE2_Leave(sender As Object, e As EventArgs) Handles txtMinutosBusE2.Leave
        If txtMinutosBusE2.Text <> "" Then

            'Validador minutos para llegar a bus mayor a 20
            If Convert.ToInt32(txtMinutosBusE2.Text) > 20 Then
                If validadorEtapa2 IsNot Nothing Then
                    validadorEtapa2.Val4 = True
                End If
                Dim confirma As DialogResult = MessageBox.Show("Ha indicado que caminó más de 20 minutos para llegar al bus, ¿confirma que es correcto?", "Verificación de datos", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                If confirma = Windows.Forms.DialogResult.No Then
                    txtMinutosBusE2.Text = ""
                    txtMinutosBusE2.Focus()
                    If validadorEtapa2 IsNot Nothing Then
                        validadorEtapa2.Val4 = False
                    End If
                Else
                    If validadorEtapa2 IsNot Nothing Then
                        validadorEtapa2.Val4Resp = True
                    End If
                End If
            ElseIf Convert.ToInt32(txtMinutosBusE2.Text) = 0 AndAlso txtCuadrasBusE2.Text <> "" AndAlso Convert.ToInt32(txtCuadrasBusE2.Text) > 0 Then
                MessageBox.Show("Ha indicado que caminó algunas cuadras en 0 minutos, corrija para continuar", "Dato inconsistente", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtMinutosBusE2.Text = ""
                txtCuadrasBusE2.Text = ""
                txtCuadrasBusE2.Focus()
            ElseIf Convert.ToInt32(txtMinutosBusE2.Text) > 0 AndAlso txtCuadrasBusE2.Text <> "" AndAlso Convert.ToInt32(txtCuadrasBusE2.Text) = 0 Then
                MessageBox.Show("Ha indicado que caminó algunos minutos pero 0 cuadras, corrija para continuar", "Dato inconsistente", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtMinutosBusE2.Text = ""
                txtCuadrasBusE2.Focus()
            End If
        End If
    End Sub

    Private Sub txtMinutosBusE3_Leave(sender As Object, e As EventArgs) Handles txtMinutosBusE3.Leave
        If txtMinutosBusE3.Text <> "" Then

            'Validador minutos para llegar a bus mayor a 20
            If Convert.ToInt32(txtMinutosBusE3.Text) > 20 Then
                If validadorEtapa3 IsNot Nothing Then
                    validadorEtapa3.Val4 = True
                End If
                Dim confirma As DialogResult = MessageBox.Show("Ha indicado que caminó más de 20 minutos para llegar al bus, ¿confirma que es correcto?", "Verificación de datos", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                If confirma = Windows.Forms.DialogResult.No Then
                    txtMinutosBusE3.Text = ""
                    txtMinutosBusE3.Focus()
                    If validadorEtapa3 IsNot Nothing Then
                        validadorEtapa3.Val4 = False
                    End If
                Else
                    If validadorEtapa3 IsNot Nothing Then
                        validadorEtapa3.Val4Resp = True
                    End If
                End If
            ElseIf Convert.ToInt32(txtMinutosBusE3.Text) = 0 AndAlso txtCuadrasBusE3.Text <> "" AndAlso Convert.ToInt32(txtCuadrasBusE3.Text) > 0 Then
                MessageBox.Show("Ha indicado que caminó algunas cuadras en 0 minutos, corrija para continuar", "Dato inconsistente", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtMinutosBusE3.Text = ""
                txtCuadrasBusE3.Text = ""
                txtCuadrasBusE3.Focus()
            ElseIf Convert.ToInt32(txtMinutosBusE3.Text) > 0 AndAlso txtCuadrasBusE3.Text <> "" AndAlso Convert.ToInt32(txtCuadrasBusE3.Text) = 0 Then
                MessageBox.Show("Ha indicado que caminó algunos minutos pero 0 cuadras, corrija para continuar", "Dato inconsistente", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtMinutosBusE3.Text = ""
                txtCuadrasBusE3.Focus()
            End If
        End If
    End Sub

    Private Sub txtMinutosEsperaBusE1_Leave(sender As Object, e As EventArgs) Handles txtMinutosEsperaBusE1.Leave
        If txtMinutosEsperaBusE1.Text <> "" Then

            'Validador minutos espera bus mayor a 15
            If Convert.ToInt32(txtMinutosEsperaBusE1.Text) > 15 Then
                If validadorEtapa1 IsNot Nothing Then
                    validadorEtapa1.Val5 = True
                End If
                Dim confirma As DialogResult = MessageBox.Show("Ha indicado que esperó al bus por más de 15 minutos, ¿confirma que es correcto?", "Verificación de datos", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                If confirma = Windows.Forms.DialogResult.No Then
                    If validadorEtapa1 IsNot Nothing Then
                        validadorEtapa1.Val5 = False
                    End If
                    txtMinutosEsperaBusE1.Text = ""
                    txtMinutosEsperaBusE1.Focus()
                Else
                    If validadorEtapa1 IsNot Nothing Then
                        validadorEtapa1.Val5Resp = True
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub txtMinutosEsperaBusE2_Leave(sender As Object, e As EventArgs) Handles txtMinutosEsperaBusE2.Leave
        If txtMinutosEsperaBusE2.Text <> "" Then

            'Validador minutos espera bus mayor a 15
            If Convert.ToInt32(txtMinutosEsperaBusE2.Text) > 15 Then
                If validadorEtapa2 IsNot Nothing Then
                    validadorEtapa2.Val5 = True
                End If
                Dim confirma As DialogResult = MessageBox.Show("Ha indicado que esperó al bus por más de 15 minutos, ¿confirma que es correcto?", "Verificación de datos", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                If confirma = Windows.Forms.DialogResult.No Then
                    If validadorEtapa2 IsNot Nothing Then
                        validadorEtapa2.Val5 = False
                    End If
                    txtMinutosEsperaBusE2.Text = ""
                    txtMinutosEsperaBusE2.Focus()
                Else
                    If validadorEtapa2 IsNot Nothing Then
                        validadorEtapa2.Val5Resp = True
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub txtMinutosEsperaBusE3_Leave(sender As Object, e As EventArgs) Handles txtMinutosEsperaBusE3.Leave
        If txtMinutosEsperaBusE3.Text <> "" Then

            'Validador minutos espera bus mayor a 15
            If Convert.ToInt32(txtMinutosEsperaBusE3.Text) > 15 Then
                If validadorEtapa3 IsNot Nothing Then
                    validadorEtapa3.Val5 = True
                End If
                Dim confirma As DialogResult = MessageBox.Show("Ha indicado que esperó al bus por más de 15 minutos, ¿confirma que es correcto?", "Verificación de datos", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                If confirma = Windows.Forms.DialogResult.No Then
                    If validadorEtapa3 IsNot Nothing Then
                        validadorEtapa3.Val5 = False
                    End If
                    txtMinutosEsperaBusE3.Text = ""
                    txtMinutosEsperaBusE3.Focus()
                Else
                    If validadorEtapa3 IsNot Nothing Then
                        validadorEtapa3.Val5Resp = True
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub txtCuadrasTXCE1_Leave(sender As Object, e As EventArgs) Handles txtCuadrasTXCE1.Leave
        If txtCuadrasTXCE1.Text <> "" Then

            'Validador cuadras para llegar a TXC mayor a 10
            If Convert.ToInt32(txtCuadrasTXCE1.Text) > 10 Then
                If validadorEtapa1 IsNot Nothing Then
                    validadorEtapa1.Val8 = True
                End If
                Dim confirma As DialogResult = MessageBox.Show("Ha indicado que caminó más de 10 cuadras para llegar al taxi colectivo, ¿confirma que es correcto?", "Verificación de datos", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                If confirma = Windows.Forms.DialogResult.No Then
                    txtCuadrasTXCE1.Text = ""
                    txtCuadrasTXCE1.Focus()
                    If validadorEtapa1 IsNot Nothing Then
                        validadorEtapa1.Val8 = False
                    End If
                Else
                    If validadorEtapa1 IsNot Nothing Then
                        validadorEtapa1.Val8Resp = True
                    End If
                End If
            ElseIf Convert.ToInt32(txtCuadrasTXCE1.Text) = 0 Then
                txtMinutosTXCE1.Text = 0
                txtMinutosEsperaTXCE1.Focus()
            End If
        End If
    End Sub

    Private Sub txtCuadrasTXCE2_Leave(sender As Object, e As EventArgs) Handles txtCuadrasTXCE2.Leave
        If txtCuadrasTXCE2.Text <> "" Then

            'Validador cuadras para llegar a TXC mayor a 10
            If Convert.ToInt32(txtCuadrasTXCE2.Text) > 10 Then
                If validadorEtapa2 IsNot Nothing Then
                    validadorEtapa2.Val8 = True
                End If
                Dim confirma As DialogResult = MessageBox.Show("Ha indicado que caminó más de 10 cuadras para llegar al taxi colectivo, ¿confirma que es correcto?", "Verificación de datos", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                If confirma = Windows.Forms.DialogResult.No Then
                    txtCuadrasTXCE2.Text = ""
                    txtCuadrasTXCE2.Focus()
                    If validadorEtapa2 IsNot Nothing Then
                        validadorEtapa2.Val8 = False
                    End If
                Else
                    If validadorEtapa2 IsNot Nothing Then
                        validadorEtapa2.Val8Resp = True
                    End If
                End If
            ElseIf Convert.ToInt32(txtCuadrasTXCE2.Text) = 0 Then
                txtMinutosTXCE2.Text = 0
                txtMinutosEsperaTXCE2.Focus()
            End If
        End If
    End Sub

    Private Sub txtCuadrasTXCE3_Leave(sender As Object, e As EventArgs) Handles txtCuadrasTXCE3.Leave
        If txtCuadrasTXCE3.Text <> "" Then

            'Validador cuadras para llegar a TXC mayor a 10
            If Convert.ToInt32(txtCuadrasTXCE3.Text) > 10 Then
                If validadorEtapa3 IsNot Nothing Then
                    validadorEtapa3.Val8 = True
                End If
                Dim confirma As DialogResult = MessageBox.Show("Ha indicado que caminó más de 10 cuadras para llegar al taxi colectivo, ¿confirma que es correcto?", "Verificación de datos", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                If confirma = Windows.Forms.DialogResult.No Then
                    txtCuadrasTXCE3.Text = ""
                    txtCuadrasTXCE3.Focus()
                    If validadorEtapa3 IsNot Nothing Then
                        validadorEtapa3.Val8 = False
                    End If
                Else
                    If validadorEtapa3 IsNot Nothing Then
                        validadorEtapa3.Val8Resp = True
                    End If
                End If
            ElseIf Convert.ToInt32(txtCuadrasTXCE3.Text) = 0 Then
                txtMinutosTXCE3.Text = 0
                txtMinutosEsperaTXCE3.Focus()
            End If
        End If
    End Sub

    Private Sub txtMinutosTXCE1_Leave(sender As Object, e As EventArgs) Handles txtMinutosTXCE1.Leave
        If txtMinutosTXCE1.Text <> "" Then

            'Validador minutos para llegar a TXC mayor a 10
            If Convert.ToInt32(txtMinutosTXCE1.Text) > 10 Then
                If validadorEtapa1 IsNot Nothing Then
                    validadorEtapa1.Val9 = True
                End If
                Dim confirma As DialogResult = MessageBox.Show("Ha indicado que caminó más de 10 minutos para llegar al taxi colectivo, ¿confirma que es correcto?", "Verificación de datos", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                If confirma = Windows.Forms.DialogResult.No Then
                    txtMinutosTXCE1.Text = ""
                    txtMinutosTXCE1.Focus()
                    If validadorEtapa1 IsNot Nothing Then
                        validadorEtapa1.Val9 = False
                    End If
                Else
                    If validadorEtapa1 IsNot Nothing Then
                        validadorEtapa1.Val9Resp = True
                    End If
                End If
            ElseIf Convert.ToInt32(txtMinutosTXCE1.Text) = 0 AndAlso txtCuadrasTXCE1.Text <> "" AndAlso Convert.ToInt32(txtCuadrasTXCE1.Text) > 0 Then
                MessageBox.Show("Ha indicado que caminó algunas cuadras en 0 minutos, corrija para continuar", "Dato inconsistente", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtMinutosTXCE1.Text = ""
                txtCuadrasTXCE1.Text = ""
                txtCuadrasTXCE1.Focus()
            ElseIf Convert.ToInt32(txtMinutosTXCE1.Text) > 0 AndAlso txtCuadrasTXCE1.Text <> "" AndAlso Convert.ToInt32(txtCuadrasTXCE1.Text) = 0 Then
                MessageBox.Show("Ha indicado que caminó algunos minutos pero 0 cuadras, corrija para continuar", "Dato inconsistente", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtMinutosTXCE1.Text = ""
                txtCuadrasTXCE1.Focus()
            End If
        End If
    End Sub

    Private Sub txtMinutosTXCE2_Leave(sender As Object, e As EventArgs) Handles txtMinutosTXCE2.Leave
        If txtMinutosTXCE2.Text <> "" Then

            'Validador minutos para llegar a TXC mayor a 10
            If Convert.ToInt32(txtMinutosTXCE2.Text) > 10 Then
                If validadorEtapa2 IsNot Nothing Then
                    validadorEtapa2.Val9 = True
                End If
                Dim confirma As DialogResult = MessageBox.Show("Ha indicado que caminó más de 10 minutos para llegar al taxi colectivo, ¿confirma que es correcto?", "Verificación de datos", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                If confirma = Windows.Forms.DialogResult.No Then
                    txtMinutosTXCE2.Text = ""
                    txtMinutosTXCE2.Focus()
                    If validadorEtapa2 IsNot Nothing Then
                        validadorEtapa2.Val9 = False
                    End If
                Else
                    If validadorEtapa2 IsNot Nothing Then
                        validadorEtapa2.Val9Resp = True
                    End If
                End If
            ElseIf Convert.ToInt32(txtMinutosTXCE2.Text) = 0 AndAlso txtCuadrasTXCE2.Text <> "" AndAlso Convert.ToInt32(txtCuadrasTXCE2.Text) > 0 Then
                MessageBox.Show("Ha indicado que caminó algunas cuadras en 0 minutos, corrija para continuar", "Dato inconsistente", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtMinutosTXCE2.Text = ""
                txtCuadrasTXCE2.Text = ""
                txtCuadrasTXCE2.Focus()
            ElseIf Convert.ToInt32(txtMinutosTXCE2.Text) > 0 AndAlso txtCuadrasTXCE2.Text <> "" AndAlso Convert.ToInt32(txtCuadrasTXCE2.Text) = 0 Then
                MessageBox.Show("Ha indicado que caminó algunos minutos pero 0 cuadras, corrija para continuar", "Dato inconsistente", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtMinutosTXCE2.Text = ""
                txtCuadrasTXCE2.Focus()
            End If
        End If
    End Sub

    Private Sub txtMinutosTXCE3_Leave(sender As Object, e As EventArgs) Handles txtMinutosTXCE3.Leave
        If txtMinutosTXCE3.Text <> "" Then

            'Validador minutos para llegar a TXC mayor a 10
            If Convert.ToInt32(txtMinutosTXCE3.Text) > 10 Then
                If validadorEtapa3 IsNot Nothing Then
                    validadorEtapa3.Val9 = True
                End If
                Dim confirma As DialogResult = MessageBox.Show("Ha indicado que caminó más de 10 minutos para llegar al taxi colectivo, ¿confirma que es correcto?", "Verificación de datos", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                If confirma = Windows.Forms.DialogResult.No Then
                    txtMinutosTXCE3.Text = ""
                    txtMinutosTXCE3.Focus()
                    If validadorEtapa3 IsNot Nothing Then
                        validadorEtapa3.Val9 = False
                    End If
                Else
                    If validadorEtapa3 IsNot Nothing Then
                        validadorEtapa3.Val9Resp = True
                    End If
                End If
            ElseIf Convert.ToInt32(txtMinutosTXCE3.Text) = 0 AndAlso txtCuadrasTXCE3.Text <> "" AndAlso Convert.ToInt32(txtCuadrasTXCE3.Text) > 0 Then
                MessageBox.Show("Ha indicado que caminó algunas cuadras en 0 minutos, corrija para continuar", "Dato inconsistente", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtMinutosTXCE3.Text = ""
                txtCuadrasTXCE3.Text = ""
                txtCuadrasTXCE3.Focus()
            ElseIf Convert.ToInt32(txtMinutosTXCE3.Text) > 0 AndAlso txtCuadrasTXCE3.Text <> "" AndAlso Convert.ToInt32(txtCuadrasTXCE3.Text) = 0 Then
                MessageBox.Show("Ha indicado que caminó algunos minutos pero 0 cuadras, corrija para continuar", "Dato inconsistente", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtMinutosTXCE3.Text = ""
                txtCuadrasTXCE3.Focus()
            End If
        End If
    End Sub

    Private Sub txtMinutosEsperaTXCE1_Leave(sender As Object, e As EventArgs) Handles txtMinutosEsperaTXCE1.Leave
        If txtMinutosEsperaTXCE1.Text <> "" Then

            'Validador minutos espera TXC mayor a 10
            If Convert.ToInt32(txtMinutosEsperaTXCE1.Text) > 10 Then
                If validadorEtapa1 IsNot Nothing Then
                    validadorEtapa1.Val10 = True
                End If
                Dim confirma As DialogResult = MessageBox.Show("Ha indicado que esperó al taxi colectivo por más de 10 minutos, ¿confirma que es correcto?", "Verificación de datos", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                If confirma = Windows.Forms.DialogResult.No Then
                    txtMinutosEsperaTXCE1.Text = ""
                    txtMinutosEsperaTXCE1.Focus()
                    If validadorEtapa1 IsNot Nothing Then
                        validadorEtapa1.Val10 = False
                    End If
                Else
                    If validadorEtapa1 IsNot Nothing Then
                        validadorEtapa1.Val10Resp = True
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub txtMinutosEsperaTXCE2_Leave(sender As Object, e As EventArgs) Handles txtMinutosEsperaTXCE2.Leave
        If txtMinutosEsperaTXCE2.Text <> "" Then

            'Validador minutos espera TXC mayor a 10
            If Convert.ToInt32(txtMinutosEsperaTXCE2.Text) > 10 Then
                If validadorEtapa2 IsNot Nothing Then
                    validadorEtapa2.Val10 = True
                End If
                Dim confirma As DialogResult = MessageBox.Show("Ha indicado que esperó al taxi colectivo por más de 10 minutos, ¿confirma que es correcto?", "Verificación de datos", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                If confirma = Windows.Forms.DialogResult.No Then
                    txtMinutosEsperaTXCE2.Text = ""
                    txtMinutosEsperaTXCE2.Focus()
                    If validadorEtapa2 IsNot Nothing Then
                        validadorEtapa2.Val10 = False
                    End If
                Else
                    If validadorEtapa2 IsNot Nothing Then
                        validadorEtapa2.Val10Resp = True
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub txtMinutosEsperaTXCE3_Leave(sender As Object, e As EventArgs) Handles txtMinutosEsperaTXCE3.Leave
        If txtMinutosEsperaTXCE3.Text <> "" Then

            'Validador minutos espera TXC mayor a 10
            If Convert.ToInt32(txtMinutosEsperaTXCE3.Text) > 10 Then
                If validadorEtapa3 IsNot Nothing Then
                    validadorEtapa3.Val10 = True
                End If
                Dim confirma As DialogResult = MessageBox.Show("Ha indicado que esperó al taxi colectivo por más de 10 minutos, ¿confirma que es correcto?", "Verificación de datos", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                If confirma = Windows.Forms.DialogResult.No Then
                    txtMinutosEsperaTXCE3.Text = ""
                    txtMinutosEsperaTXCE3.Focus()
                    If validadorEtapa3 IsNot Nothing Then
                        validadorEtapa3.Val10 = False
                    End If
                Else
                    If validadorEtapa3 IsNot Nothing Then
                        validadorEtapa3.Val10Resp = True
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub txtCuadrasTaxiE1_Leave(sender As Object, e As EventArgs) Handles txtCuadrasTaxiE1.Leave
        If txtCuadrasTaxiE1.Text <> "" Then

            'Validador cuadras para llegar al taxi mayor a 5
            If Convert.ToInt32(txtCuadrasTaxiE1.Text) > 5 Then
                If validadorEtapa1 IsNot Nothing Then
                    validadorEtapa1.Val11 = True
                End If
                Dim confirma As DialogResult = MessageBox.Show("Ha indicado que caminó más de 5 cuadras para tomar el taxi, ¿confirma que es correcto?", "Verificación de datos", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                If confirma = Windows.Forms.DialogResult.No Then
                    txtCuadrasTaxiE1.Text = ""
                    txtCuadrasTaxiE1.Focus()
                    If validadorEtapa1 IsNot Nothing Then
                        validadorEtapa1.Val11 = False
                    End If
                Else
                    If validadorEtapa1 IsNot Nothing Then
                        validadorEtapa1.Val11Resp = True
                    End If
                End If
            ElseIf Convert.ToInt32(txtCuadrasTaxiE1.Text) = 0 Then
                txtMinutosTaxiE1.Text = 0
                txtMinutosEsperaTaxiE1.Focus()
            End If
        End If
    End Sub

    Private Sub txtCuadrasTaxiE2_Leave(sender As Object, e As EventArgs) Handles txtCuadrasTaxiE2.Leave
        If txtCuadrasTaxiE2.Text <> "" Then

            'Validador cuadras para llegar al taxi mayor a 5
            If Convert.ToInt32(txtCuadrasTaxiE2.Text) > 5 Then
                If validadorEtapa2 IsNot Nothing Then
                    validadorEtapa2.Val11 = True
                End If
                Dim confirma As DialogResult = MessageBox.Show("Ha indicado que caminó más de 5 cuadras para tomar el taxi, ¿confirma que es correcto?", "Verificación de datos", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                If confirma = Windows.Forms.DialogResult.No Then
                    txtCuadrasTaxiE2.Text = ""
                    txtCuadrasTaxiE2.Focus()
                    If validadorEtapa2 IsNot Nothing Then
                        validadorEtapa2.Val11 = False
                    End If
                Else
                    If validadorEtapa2 IsNot Nothing Then
                        validadorEtapa2.Val11Resp = True
                    End If
                End If
            ElseIf Convert.ToInt32(txtCuadrasTaxiE2.Text) = 0 Then
                txtMinutosTaxiE2.Text = 0
                txtMinutosEsperaTaxiE2.Focus()
            End If
        End If
    End Sub

    Private Sub txtCuadrasTaxiE3_Leave(sender As Object, e As EventArgs) Handles txtCuadrasTaxiE3.Leave
        If txtCuadrasTaxiE3.Text <> "" Then

            'Validador cuadras para llegar al taxi mayor a 5
            If Convert.ToInt32(txtCuadrasTaxiE3.Text) > 5 Then
                If validadorEtapa3 IsNot Nothing Then
                    validadorEtapa3.Val11 = True
                End If
                Dim confirma As DialogResult = MessageBox.Show("Ha indicado que caminó más de 5 cuadras para tomar el taxi, ¿confirma que es correcto?", "Verificación de datos", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                If confirma = Windows.Forms.DialogResult.No Then
                    txtCuadrasTaxiE3.Text = ""
                    txtCuadrasTaxiE3.Focus()
                    If validadorEtapa3 IsNot Nothing Then
                        validadorEtapa3.Val11 = False
                    End If
                Else
                    If validadorEtapa3 IsNot Nothing Then
                        validadorEtapa3.Val11Resp = True
                    End If
                End If
            ElseIf Convert.ToInt32(txtCuadrasTaxiE3.Text) = 0 Then
                txtMinutosTaxiE3.Text = 0
                txtMinutosEsperaTaxiE3.Focus()
            End If
        End If
    End Sub

    Private Sub txtMinutosTaxiE1_Leave(sender As Object, e As EventArgs) Handles txtMinutosTaxiE1.Leave
        If txtMinutosTaxiE1.Text <> "" Then

            'Validador minutos para llegar al taxi mayor a 10
            If Convert.ToInt32(txtMinutosTaxiE1.Text) > 10 Then
                If validadorEtapa1 IsNot Nothing Then
                    validadorEtapa1.Val12 = True
                End If
                Dim confirma As DialogResult = MessageBox.Show("Ha indicado que caminó más de 10 minutos para llegar al taxi, ¿confirma que es correcto?", "Verificación de datos", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                If confirma = Windows.Forms.DialogResult.No Then
                    txtMinutosTaxiE1.Text = ""
                    txtMinutosTaxiE1.Focus()
                    If validadorEtapa1 IsNot Nothing Then
                        validadorEtapa1.Val12 = False
                    End If
                Else
                    If validadorEtapa1 IsNot Nothing Then
                        validadorEtapa1.Val12Resp = True
                    End If
                End If
            ElseIf Convert.ToInt32(txtMinutosTaxiE1.Text) = 0 AndAlso txtCuadrasTaxiE1.Text <> "" AndAlso Convert.ToInt32(txtCuadrasTaxiE1.Text) > 0 Then
                MessageBox.Show("Ha indicado que caminó algunas cuadras en 0 minutos, corrija para continuar", "Dato inconsistente", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtMinutosTaxiE1.Text = ""
                txtCuadrasTaxiE1.Text = ""
                txtCuadrasTaxiE1.Focus()
            ElseIf Convert.ToInt32(txtMinutosTaxiE1.Text) > 0 AndAlso txtCuadrasTaxiE1.Text <> "" AndAlso Convert.ToInt32(txtCuadrasTaxiE1.Text) = 0 Then
                MessageBox.Show("Ha indicado que caminó algunos minutos pero 0 cuadras, corrija para continuar", "Dato inconsistente", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtMinutosTaxiE1.Text = ""
                txtCuadrasTaxiE1.Focus()
            End If
        End If
    End Sub

    Private Sub txtMinutosTaxiE2_Leave(sender As Object, e As EventArgs) Handles txtMinutosTaxiE2.Leave
        If txtMinutosTaxiE2.Text <> "" Then

            'Validador minutos para llegar al taxi mayor a 10
            If Convert.ToInt32(txtMinutosTaxiE2.Text) > 10 Then
                If validadorEtapa2 IsNot Nothing Then
                    validadorEtapa2.Val12 = True
                End If
                Dim confirma As DialogResult = MessageBox.Show("Ha indicado que caminó más de 10 minutos para llegar al taxi, ¿confirma que es correcto?", "Verificación de datos", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                If confirma = Windows.Forms.DialogResult.No Then
                    txtMinutosTaxiE2.Text = ""
                    txtMinutosTaxiE2.Focus()
                    If validadorEtapa2 IsNot Nothing Then
                        validadorEtapa2.Val12 = False
                    End If
                Else
                    If validadorEtapa2 IsNot Nothing Then
                        validadorEtapa2.Val12Resp = True
                    End If
                End If
            ElseIf Convert.ToInt32(txtMinutosTaxiE2.Text) = 0 AndAlso txtCuadrasTaxiE2.Text <> "" AndAlso Convert.ToInt32(txtCuadrasTaxiE2.Text) > 0 Then
                MessageBox.Show("Ha indicado que caminó algunas cuadras en 0 minutos, corrija para continuar", "Dato inconsistente", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtMinutosTaxiE2.Text = ""
                txtCuadrasTaxiE2.Text = ""
                txtCuadrasTaxiE2.Focus()
            ElseIf Convert.ToInt32(txtMinutosTaxiE2.Text) > 0 AndAlso txtCuadrasTaxiE2.Text <> "" AndAlso Convert.ToInt32(txtCuadrasTaxiE2.Text) = 0 Then
                MessageBox.Show("Ha indicado que caminó algunos minutos pero 0 cuadras, corrija para continuar", "Dato inconsistente", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtMinutosTaxiE2.Text = ""
                txtCuadrasTaxiE2.Focus()
            End If
        End If
    End Sub

    Private Sub txtMinutosTaxiE3_Leave(sender As Object, e As EventArgs) Handles txtMinutosTaxiE3.Leave
        If txtMinutosTaxiE3.Text <> "" Then

            'Validador minutos para llegar al taxi mayor a 10
            If Convert.ToInt32(txtMinutosTaxiE3.Text) > 10 Then
                If validadorEtapa3 IsNot Nothing Then
                    validadorEtapa3.Val12 = True
                End If
                Dim confirma As DialogResult = MessageBox.Show("Ha indicado que caminó más de 10 minutos para llegar al taxi, ¿confirma que es correcto?", "Verificación de datos", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                If confirma = Windows.Forms.DialogResult.No Then
                    txtMinutosTaxiE3.Text = ""
                    txtMinutosTaxiE3.Focus()
                    If validadorEtapa3 IsNot Nothing Then
                        validadorEtapa3.Val12 = False
                    End If
                Else
                    If validadorEtapa3 IsNot Nothing Then
                        validadorEtapa3.Val12Resp = True
                    End If
                End If
            ElseIf Convert.ToInt32(txtMinutosTaxiE3.Text) = 0 AndAlso txtCuadrasTaxiE3.Text <> "" AndAlso Convert.ToInt32(txtCuadrasTaxiE3.Text) > 0 Then
                MessageBox.Show("Ha indicado que caminó algunas cuadras en 0 minutos, corrija para continuar", "Dato inconsistente", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtMinutosTaxiE3.Text = ""
                txtCuadrasTaxiE3.Text = ""
                txtCuadrasTaxiE3.Focus()
            ElseIf Convert.ToInt32(txtMinutosTaxiE3.Text) > 0 AndAlso txtCuadrasTaxiE3.Text <> "" AndAlso Convert.ToInt32(txtCuadrasTaxiE3.Text) = 0 Then
                MessageBox.Show("Ha indicado que caminó algunos minutos pero 0 cuadras, corrija para continuar", "Dato inconsistente", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtMinutosTaxiE3.Text = ""
                txtCuadrasTaxiE3.Focus()
            End If
        End If
    End Sub

    Private Sub txtMinutosEsperaTaxiE1_Leave(sender As Object, e As EventArgs) Handles txtMinutosEsperaTaxiE1.Leave
        If txtMinutosEsperaTaxiE1.Text <> "" Then

            'Validador minutos espera taxi mayor a 10
            If Convert.ToInt32(txtMinutosEsperaTaxiE1.Text) > 10 Then
                If validadorEtapa1 IsNot Nothing Then
                    validadorEtapa1.Val13 = True
                End If
                Dim confirma As DialogResult = MessageBox.Show("Ha indicado que esperó al taxi por más de 10 minutos, ¿confirma que es correcto?", "Verificación de datos", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                If confirma = Windows.Forms.DialogResult.No Then
                    txtMinutosEsperaTaxiE1.Text = ""
                    txtMinutosEsperaTaxiE1.Focus()
                    If validadorEtapa1 IsNot Nothing Then
                        validadorEtapa1.Val13 = False
                    End If
                Else
                    If validadorEtapa1 IsNot Nothing Then
                        validadorEtapa1.Val13Resp = True
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub txtMinutosEsperaTaxiE2_Leave(sender As Object, e As EventArgs) Handles txtMinutosEsperaTaxiE2.Leave
        If txtMinutosEsperaTaxiE2.Text <> "" Then

            'Validador minutos espera taxi mayor a 10
            If Convert.ToInt32(txtMinutosEsperaTaxiE2.Text) > 10 Then
                If validadorEtapa2 IsNot Nothing Then
                    validadorEtapa2.Val13 = True
                End If
                Dim confirma As DialogResult = MessageBox.Show("Ha indicado que esperó al taxi por más de 10 minutos, ¿confirma que es correcto?", "Verificación de datos", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                If confirma = Windows.Forms.DialogResult.No Then
                    txtMinutosEsperaTaxiE2.Text = ""
                    txtMinutosEsperaTaxiE2.Focus()
                    If validadorEtapa2 IsNot Nothing Then
                        validadorEtapa2.Val13 = False
                    End If
                Else
                    If validadorEtapa2 IsNot Nothing Then
                        validadorEtapa2.Val13Resp = True
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub txtMinutosEsperaTaxiE3_Leave(sender As Object, e As EventArgs) Handles txtMinutosEsperaTaxiE3.Leave
        If txtMinutosEsperaTaxiE3.Text <> "" Then

            'Validador minutos espera taxi mayor a 10
            If Convert.ToInt32(txtMinutosEsperaTaxiE3.Text) > 10 Then
                If validadorEtapa3 IsNot Nothing Then
                    validadorEtapa3.Val13 = True
                End If
                Dim confirma As DialogResult = MessageBox.Show("Ha indicado que esperó al taxi por más de 10 minutos, ¿confirma que es correcto?", "Verificación de datos", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                If confirma = Windows.Forms.DialogResult.No Then
                    txtMinutosEsperaTaxiE3.Text = ""
                    txtMinutosEsperaTaxiE3.Focus()
                    If validadorEtapa3 IsNot Nothing Then
                        validadorEtapa3.Val13 = False
                    End If
                Else
                    If validadorEtapa3 IsNot Nothing Then
                        validadorEtapa3.Val13Resp = True
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub txtTarifaMontoTaxiE1_Leave(sender As Object, e As EventArgs) Handles txtTarifaMontoTaxiE1.Leave
        If txtTarifaMontoTaxiE1.Text <> "" Then

            Dim monto As Integer = Convert.ToInt32(txtTarifaMontoTaxiE1.Text.Replace("$", "").Replace(".", ""))

            If monto < 500 Then
                If validadorEtapa1 IsNot Nothing Then
                    validadorEtapa1.Val14 = True
                End If
                Dim confirma As DialogResult = MessageBox.Show("Ha indicado que pagó menos de $500 por el taxi, ¿confirma que es correcto?", "Verificación de datos", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                If confirma = Windows.Forms.DialogResult.No Then
                    txtTarifaMontoTaxiE1.Text = ""
                    txtTarifaMontoTaxiE1.Focus()
                    If validadorEtapa1 IsNot Nothing Then
                        validadorEtapa1.Val14 = False
                    End If
                Else
                    If validadorEtapa1 IsNot Nothing Then
                        validadorEtapa1.Val14Resp = True
                    End If
                End If

            ElseIf monto > 10000 Then
                If validadorEtapa1 IsNot Nothing Then
                    validadorEtapa1.Val14 = True
                End If
                Dim confirma As DialogResult = MessageBox.Show("Ha indicado que pagó más de $10.000 por el taxi, ¿confirma que es correcto?", "Verificación de datos", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                If confirma = Windows.Forms.DialogResult.No Then
                    txtTarifaMontoTaxiE1.Text = ""
                    txtTarifaMontoTaxiE1.Focus()
                    If validadorEtapa1 IsNot Nothing Then
                        validadorEtapa1.Val14 = False
                    End If
                Else
                    If validadorEtapa1 IsNot Nothing Then
                        validadorEtapa1.Val14Resp = True
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub txtTarifaMontoTaxiE2_Leave(sender As Object, e As EventArgs) Handles txtTarifaMontoTaxiE2.Leave
        If txtTarifaMontoTaxiE2.Text <> "" Then

            Dim monto As Integer = Convert.ToInt32(txtTarifaMontoTaxiE2.Text.Replace("$", "").Replace(".", ""))

            If monto < 500 Then
                If validadorEtapa2 IsNot Nothing Then
                    validadorEtapa2.Val14 = True
                End If
                Dim confirma As DialogResult = MessageBox.Show("Ha indicado que pagó menos de $500 por el taxi, ¿confirma que es correcto?", "Verificación de datos", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                If confirma = Windows.Forms.DialogResult.No Then
                    txtTarifaMontoTaxiE2.Text = ""
                    txtTarifaMontoTaxiE2.Focus()
                    If validadorEtapa2 IsNot Nothing Then
                        validadorEtapa2.Val14 = False
                    End If
                Else
                    If validadorEtapa2 IsNot Nothing Then
                        validadorEtapa2.Val14Resp = True
                    End If
                End If

            ElseIf monto > 10000 Then
                If validadorEtapa2 IsNot Nothing Then
                    validadorEtapa2.Val14 = True
                End If
                Dim confirma As DialogResult = MessageBox.Show("Ha indicado que pagó más de $10.000 por el taxi, ¿confirma que es correcto?", "Verificación de datos", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                If confirma = Windows.Forms.DialogResult.No Then
                    txtTarifaMontoTaxiE2.Text = ""
                    txtTarifaMontoTaxiE2.Focus()
                    If validadorEtapa2 IsNot Nothing Then
                        validadorEtapa2.Val14 = False
                    End If
                Else
                    If validadorEtapa2 IsNot Nothing Then
                        validadorEtapa2.Val14Resp = True
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub txtTarifaMontoTaxiE3_Leave(sender As Object, e As EventArgs) Handles txtTarifaMontoTaxiE3.Leave
        If txtTarifaMontoTaxiE3.Text <> "" Then

            Dim monto As Integer = Convert.ToInt32(txtTarifaMontoTaxiE3.Text.Replace("$", "").Replace(".", ""))

            If monto < 500 Then
                If validadorEtapa3 IsNot Nothing Then
                    validadorEtapa3.Val14 = True
                End If
                Dim confirma As DialogResult = MessageBox.Show("Ha indicado que pagó menos de $500 por el taxi, ¿confirma que es correcto?", "Verificación de datos", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                If confirma = Windows.Forms.DialogResult.No Then
                    txtTarifaMontoTaxiE3.Text = ""
                    txtTarifaMontoTaxiE3.Focus()
                    If validadorEtapa3 IsNot Nothing Then
                        validadorEtapa3.Val14 = False
                    End If
                Else
                    If validadorEtapa3 IsNot Nothing Then
                        validadorEtapa3.Val14Resp = True
                    End If
                End If

            ElseIf monto > 10000 Then
                If validadorEtapa3 IsNot Nothing Then
                    validadorEtapa3.Val14 = True
                End If
                Dim confirma As DialogResult = MessageBox.Show("Ha indicado que pagó más de $10.000 por el taxi, ¿confirma que es correcto?", "Verificación de datos", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                If confirma = Windows.Forms.DialogResult.No Then
                    txtTarifaMontoTaxiE3.Text = ""
                    txtTarifaMontoTaxiE3.Focus()
                    If validadorEtapa3 IsNot Nothing Then
                        validadorEtapa3.Val14 = False
                    End If
                Else
                    If validadorEtapa3 IsNot Nothing Then
                        validadorEtapa3.Val14Resp = True
                    End If
                End If
            End If
        End If
    End Sub


    Private Sub lkpTipoTarifaBusE1_EditValueChanged(sender As Object, e As EventArgs) Handles lkpTipoTarifaBusE1.EditValueChanged
        Dim opcion As Integer

        If lkpTipoTarifaBusE1.EditValue IsNot Nothing AndAlso Me.lkpTipoTarifaBusE1.EditValue.ToString <> "" Then
            opcion = Me.lkpTipoTarifaBusE1.EditValue
        End If

        Me.spcCuantoPagoBusE1.Collapsed = True

        If opcion > 3 Then
            Me.spcCuantoPagoBusE1.Collapsed = True
        ElseIf opcion > 0 Then
            Me.spcCuantoPagoBusE1.Collapsed = False

            Try
                Dim estudia As Boolean = persona.Actividad.Contains("2")

                'Validador es estudiante y paga tarifa adulto
                If estudia And (opcion = 2 OrElse opcion = 3) Then
                    If validadorEtapa1 IsNot Nothing Then
                        validadorEtapa1.Val7 = True
                    End If
                    Dim confirma As DialogResult = MessageBox.Show("Ha indicado tarifa adulto, pero la persona es estudiante, ¿confirma que es correcto?", "Verificación de datos", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                    If confirma = Windows.Forms.DialogResult.No Then
                        lkpTipoTarifaBusE1.EditValue = -1
                        lkpTipoTarifaBusE1.Focus()
                        If validadorEtapa1 IsNot Nothing Then
                            validadorEtapa1.Val7 = False
                        End If
                    Else
                        If validadorEtapa1 IsNot Nothing Then
                            validadorEtapa1.Val7Resp = True
                        End If
                    End If
                End If

                'Validador no es estudiante y paga tarifa estudiante
                If Not estudia And (opcion = 1) Then
                    MessageBox.Show("Ha indicado tarifa escolar, pero la persona no es estudiante. Por favor, corrija para continuar.", "Dato inconsistente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    lkpTipoTarifaBusE1.Focus()
                End If
            Catch
                MessageBox.Show("Error validando tarifa contra actividad del encuestado. No se puede leer la persona en base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End If

    End Sub

    Private Sub lkpTipoTarifaBusE2_EditValueChanged(sender As Object, e As EventArgs) Handles lkpTipoTarifaBusE2.EditValueChanged
        Dim opcion As Integer

        If lkpTipoTarifaBusE2.EditValue IsNot Nothing AndAlso Me.lkpTipoTarifaBusE2.EditValue.ToString <> "" Then
            opcion = Me.lkpTipoTarifaBusE2.EditValue
        End If

        Me.spcCuantoPagoBusE2.Collapsed = True
        Me.txtTarifaMontoBusE2.Visible = False

        If opcion > 3 Then
            Me.spcCuantoPagoBusE2.Collapsed = True
            Me.txtTarifaMontoBusE2.Visible = False
        ElseIf opcion > 0 Then
            Me.spcCuantoPagoBusE2.Collapsed = False
            Me.txtTarifaMontoBusE2.Visible = True

            Try
                Dim estudia As Boolean = persona.Actividad.Contains("2")

                'Validador es estudiante y paga tarifa adulto
                If estudia And (opcion = 2 OrElse opcion = 3) Then
                    If validadorEtapa2 IsNot Nothing Then
                        validadorEtapa2.Val7 = True
                    End If
                    Dim confirma As DialogResult = MessageBox.Show("Ha indicado tarifa adulto, pero la persona es estudiante, ¿confirma que es correcto?", "Verificación de datos", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                    If confirma = Windows.Forms.DialogResult.No Then
                        lkpTipoTarifaBusE2.EditValue = -1
                        lkpTipoTarifaBusE2.Focus()
                        If validadorEtapa2 IsNot Nothing Then
                            validadorEtapa2.Val7 = False
                        End If
                    Else
                        If validadorEtapa2 IsNot Nothing Then
                            validadorEtapa2.Val7Resp = True
                        End If
                    End If
                End If

                'Validador no es estudiante y paga tarifa estudiante
                If Not estudia And (opcion = 1) Then
                    MessageBox.Show("Ha indicado tarifa escolar, pero la persona no es estudiante. Por favor, corrija para continuar.", "Dato inconsistente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    lkpTipoTarifaBusE2.Focus()
                End If
            Catch
                MessageBox.Show("Error validando tarifa contra actividad del encuestado. No se puede leer la persona en base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub lkpTipoTarifaBusE3_EditValueChanged(sender As Object, e As EventArgs) Handles lkpTipoTarifaBusE3.EditValueChanged
        Dim opcion As Integer

        If lkpTipoTarifaBusE3.EditValue IsNot Nothing AndAlso Me.lkpTipoTarifaBusE3.EditValue.ToString <> "" Then
            opcion = Me.lkpTipoTarifaBusE3.EditValue
        End If

        Me.spcCuantoPagoBusE3.Collapsed = True
        Me.txtTarifaMontoBusE3.Visible = False

        If opcion > 3 Then
            Me.spcCuantoPagoBusE3.Collapsed = True
            Me.txtTarifaMontoBusE3.Visible = False
        ElseIf opcion > 0 Then
            Me.spcCuantoPagoBusE3.Collapsed = False
            Me.txtTarifaMontoBusE3.Visible = True

            Try
                Dim estudia As Boolean = persona.Actividad.Contains("2")

                'Validador es estudiante y paga tarifa adulto
                If estudia And (opcion = 2 OrElse opcion = 3) Then
                    If validadorEtapa3 IsNot Nothing Then
                        validadorEtapa3.Val7 = True
                    End If
                    Dim confirma As DialogResult = MessageBox.Show("Ha indicado tarifa adulto, pero la persona es estudiante, ¿confirma que es correcto?", "Verificación de datos", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                    If confirma = Windows.Forms.DialogResult.No Then
                        lkpTipoTarifaBusE3.EditValue = -1
                        lkpTipoTarifaBusE3.Focus()
                        If validadorEtapa3 IsNot Nothing Then
                            validadorEtapa3.Val7 = False
                        End If
                    Else
                        If validadorEtapa3 IsNot Nothing Then
                            validadorEtapa3.Val7Resp = True
                        End If
                    End If
                End If

                'Validador no es estudiante y paga tarifa estudiante
                If Not estudia And (opcion = 1) Then
                    MessageBox.Show("Ha indicado tarifa escolar, pero la persona no es estudiante. Por favor, corrija para continuar.", "Dato inconsistente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    lkpTipoTarifaBusE3.Focus()
                End If
            Catch
                MessageBox.Show("Error validando tarifa contra actividad del encuestado. No se puede leer la persona en base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End If
    End Sub

    Private Sub txtTarifaMontoBusE1_Leave(sender As Object, e As EventArgs) Handles txtTarifaMontoBusE1.Leave

        If Me.txtTarifaMontoBusE1.Text <> "" Then

            'Validador tarifa bus fuera de rango
            Dim monto As Integer = Convert.ToInt32(txtTarifaMontoBusE1.Text.Replace("$", "").Replace(".", ""))

            If monto < 200 Then
                If validadorEtapa1 IsNot Nothing Then
                    validadorEtapa1.Val19 = True
                End If
                Dim confirma As DialogResult = MessageBox.Show("Ha indicado una tarifa menor a $200, ¿confirma que es correcto?", "Verificación de datos", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                If confirma = Windows.Forms.DialogResult.No Then
                    txtTarifaMontoBusE1.EditValue = ""
                    txtTarifaMontoBusE1.Focus()
                    If validadorEtapa1 IsNot Nothing Then
                        validadorEtapa1.Val19 = False
                    End If
                Else
                    If validadorEtapa1 IsNot Nothing Then
                        validadorEtapa1.Val19Resp = True
                    End If
                End If
            ElseIf monto > 2000 Then
                If validadorEtapa1 IsNot Nothing Then
                    validadorEtapa1.Val19 = True
                End If
                Dim confirma As DialogResult = MessageBox.Show("Ha indicado una tarifa mayor a $2.000, ¿confirma que es correcto?", "Verificación de datos", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                If confirma = Windows.Forms.DialogResult.No Then
                    txtTarifaMontoBusE1.EditValue = ""
                    txtTarifaMontoBusE1.Focus()
                    If validadorEtapa1 IsNot Nothing Then
                        validadorEtapa1.Val19 = False
                    End If
                Else
                    If validadorEtapa1 IsNot Nothing Then
                        validadorEtapa1.Val19Resp = True
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub txtTarifaMontoBusE2_Leave(sender As Object, e As EventArgs) Handles txtTarifaMontoBusE2.Leave
        If Me.txtTarifaMontoBusE2.Text <> "" Then

            'Validador tarifa bus fuera de rango
            Dim monto As Integer = Convert.ToInt32(txtTarifaMontoBusE2.Text.Replace("$", "").Replace(".", ""))

            If monto < 200 Then
                If validadorEtapa2 IsNot Nothing Then
                    validadorEtapa2.Val19 = True
                End If
                Dim confirma As DialogResult = MessageBox.Show("Ha indicado una tarifa menor a $200, ¿confirma que es correcto?", "Verificación de datos", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                If confirma = Windows.Forms.DialogResult.No Then
                    txtTarifaMontoBusE2.EditValue = ""
                    txtTarifaMontoBusE2.Focus()
                    If validadorEtapa2 IsNot Nothing Then
                        validadorEtapa2.Val19 = False
                    End If
                Else
                    If validadorEtapa2 IsNot Nothing Then
                        validadorEtapa2.Val19Resp = True
                    End If
                End If
            ElseIf monto > 2000 Then
                If validadorEtapa2 IsNot Nothing Then
                    validadorEtapa2.Val19 = True
                End If
                Dim confirma As DialogResult = MessageBox.Show("Ha indicado una tarifa mayor a $2.000, ¿confirma que es correcto?", "Verificación de datos", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                If confirma = Windows.Forms.DialogResult.No Then
                    txtTarifaMontoBusE2.EditValue = ""
                    txtTarifaMontoBusE2.Focus()
                    If validadorEtapa2 IsNot Nothing Then
                        validadorEtapa2.Val19 = False
                    End If
                Else
                    If validadorEtapa2 IsNot Nothing Then
                        validadorEtapa2.Val19Resp = True
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub txtTarifaMontoBusE3_Leave(sender As Object, e As EventArgs) Handles txtTarifaMontoBusE3.Leave
        If Me.txtTarifaMontoBusE3.Text <> "" Then

            'Validador tarifa bus fuera de rango
            Dim monto As Integer = Convert.ToInt32(txtTarifaMontoBusE3.Text.Replace("$", "").Replace(".", ""))

            If monto < 200 Then
                If validadorEtapa3 IsNot Nothing Then
                    validadorEtapa3.Val19 = True
                End If
                Dim confirma As DialogResult = MessageBox.Show("Ha indicado una tarifa menor a $200, ¿confirma que es correcto?", "Verificación de datos", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                If confirma = Windows.Forms.DialogResult.No Then
                    txtTarifaMontoBusE3.EditValue = ""
                    txtTarifaMontoBusE3.Focus()
                    If validadorEtapa3 IsNot Nothing Then
                        validadorEtapa3.Val19 = False
                    End If
                Else
                    If validadorEtapa3 IsNot Nothing Then
                        validadorEtapa3.Val19Resp = True
                    End If
                End If
            ElseIf monto > 2000 Then
                If validadorEtapa3 IsNot Nothing Then
                    validadorEtapa3.Val19 = True
                End If
                Dim confirma As DialogResult = MessageBox.Show("Ha indicado una tarifa mayor a $2.000, ¿confirma que es correcto?", "Verificación de datos", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                If confirma = Windows.Forms.DialogResult.No Then
                    txtTarifaMontoBusE3.EditValue = ""
                    txtTarifaMontoBusE3.Focus()
                    If validadorEtapa3 IsNot Nothing Then
                        validadorEtapa3.Val19 = False
                    End If
                Else
                    If validadorEtapa3 IsNot Nothing Then
                        validadorEtapa3.Val19Resp = True
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub txtTarifaMontoTXCE1_Leave(sender As Object, e As EventArgs) Handles txtTarifaMontoTXCE1.Leave
        If Me.txtTarifaMontoTXCE1.Text <> "" Then

            'Validador tarifa TXC fuera de rango
            Dim monto As Integer = Convert.ToInt32(txtTarifaMontoTXCE1.Text.Replace("$", "").Replace(".", ""))

            If monto < 200 Then
                If validadorEtapa1 IsNot Nothing Then
                    validadorEtapa1.Val18 = True
                End If
                Dim confirma As DialogResult = MessageBox.Show("Ha indicado una tarifa menor a $200, ¿confirma que es correcto?", "Verificación de datos", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                If confirma = Windows.Forms.DialogResult.No Then
                    txtTarifaMontoTXCE1.Text = ""
                    txtTarifaMontoTXCE1.Focus()
                    If validadorEtapa1 IsNot Nothing Then
                        validadorEtapa1.Val18 = False
                    End If
                Else
                    If validadorEtapa1 IsNot Nothing Then
                        validadorEtapa1.Val18Resp = True
                    End If
                End If
            ElseIf monto > 3000 Then
                If validadorEtapa1 IsNot Nothing Then
                    validadorEtapa1.Val18 = True
                End If
                Dim confirma As DialogResult = MessageBox.Show("Ha indicado una tarifa mayor a $3.000, ¿confirma que es correcto?", "Verificación de datos", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                If confirma = Windows.Forms.DialogResult.No Then
                    txtTarifaMontoTXCE1.Text = ""
                    txtTarifaMontoTXCE1.Focus()
                    If validadorEtapa1 IsNot Nothing Then
                        validadorEtapa1.Val18 = False
                    End If
                Else
                    If validadorEtapa1 IsNot Nothing Then
                        validadorEtapa1.Val18Resp = True
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub txtTarifaMontoTXCE2_Leave(sender As Object, e As EventArgs) Handles txtTarifaMontoTXCE2.Leave
        If Me.txtTarifaMontoTXCE2.Text <> "" Then

            'Validador tarifa TXC fuera de rango
            Dim monto As Integer = Convert.ToInt32(txtTarifaMontoTXCE2.Text.Replace("$", "").Replace(".", ""))

            If monto < 200 Then
                If validadorEtapa2 IsNot Nothing Then
                    validadorEtapa2.Val18 = True
                End If
                Dim confirma As DialogResult = MessageBox.Show("Ha indicado una tarifa menor a $200, ¿confirma que es correcto?", "Verificación de datos", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                If confirma = Windows.Forms.DialogResult.No Then
                    txtTarifaMontoTXCE2.Text = ""
                    txtTarifaMontoTXCE2.Focus()
                    If validadorEtapa2 IsNot Nothing Then
                        validadorEtapa2.Val18 = False
                    End If
                Else
                    If validadorEtapa2 IsNot Nothing Then
                        validadorEtapa2.Val18Resp = True
                    End If
                End If
            ElseIf monto > 3000 Then
                If validadorEtapa2 IsNot Nothing Then
                    validadorEtapa2.Val18 = True
                End If
                Dim confirma As DialogResult = MessageBox.Show("Ha indicado una tarifa mayor a $3.000, ¿confirma que es correcto?", "Verificación de datos", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                If confirma = Windows.Forms.DialogResult.No Then
                    txtTarifaMontoTXCE2.Text = ""
                    txtTarifaMontoTXCE2.Focus()
                    If validadorEtapa2 IsNot Nothing Then
                        validadorEtapa2.Val18 = False
                    End If
                Else
                    If validadorEtapa2 IsNot Nothing Then
                        validadorEtapa2.Val18Resp = True
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub txtTarifaMontoTXCE3_Leave(sender As Object, e As EventArgs) Handles txtTarifaMontoTXCE3.Leave
        If Me.txtTarifaMontoTXCE3.Text <> "" Then

            'Validador tarifa TXC fuera de rango
            Dim monto As Integer = Convert.ToInt32(txtTarifaMontoTXCE3.Text.Replace("$", "").Replace(".", ""))

            If monto < 200 Then
                If validadorEtapa3 IsNot Nothing Then
                    validadorEtapa3.Val18 = True
                End If
                Dim confirma As DialogResult = MessageBox.Show("Ha indicado una tarifa menor a $200, ¿confirma que es correcto?", "Verificación de datos", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                If confirma = Windows.Forms.DialogResult.No Then
                    txtTarifaMontoTXCE3.Text = ""
                    txtTarifaMontoTXCE3.Focus()
                    If validadorEtapa3 IsNot Nothing Then
                        validadorEtapa3.Val18 = False
                    End If
                Else
                    If validadorEtapa3 IsNot Nothing Then
                        validadorEtapa3.Val18Resp = True
                    End If
                End If
            ElseIf monto > 3000 Then
                If validadorEtapa3 IsNot Nothing Then
                    validadorEtapa3.Val18 = True
                End If
                Dim confirma As DialogResult = MessageBox.Show("Ha indicado una tarifa mayor a $3.000, ¿confirma que es correcto?", "Verificación de datos", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                If confirma = Windows.Forms.DialogResult.No Then
                    txtTarifaMontoTXCE3.Text = ""
                    txtTarifaMontoTXCE3.Focus()
                    If validadorEtapa3 IsNot Nothing Then
                        validadorEtapa3.Val18 = False
                    End If
                Else
                    If validadorEtapa3 IsNot Nothing Then
                        validadorEtapa3.Val18Resp = True
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub lkpLugarBajadaTXCE1_EditValueChanged(sender As Object, e As EventArgs) Handles lkpLugarBajadaTXCE1.EditValueChanged
        Dim opcion As Integer

        If lkpLugarBajadaTXCE1.EditValue IsNot Nothing AndAlso Me.lkpLugarBajadaTXCE1.EditValue.ToString <> "" Then
            opcion = Me.lkpLugarBajadaTXCE1.EditValue
        End If

        'Desbloquear caminata posterior
        Me.txtCuadrasDespues.Enabled = True
        Me.txtMinutosDespues.Enabled = True

        Select Case opcion
            Case 1
                mismaManzanaDestino = True
                'Bloquear caminata posterior
                Me.txtCuadrasDespues.Text = "0"
                Me.txtCuadrasDespues.Enabled = False
                Me.txtMinutosDespues.Text = "0"
                Me.txtMinutosDespues.Enabled = False

                Me.lkpComunaEtapa1.EditValue = Me.lkpComunaDestino.EditValue
                Me.txtComunaOtraEtapa1.Text = Me.txtComunaDestinoOtra.Text
                Me.lkpCalle1Etapa1.EditValue = Me.lkpCalle1Destino.EditValue
                Me.lkpCalle2Etapa1.EditValue = Me.lkpCalle2Destino.EditValue
                Dim args As DevExpress.XtraEditors.Controls.CloseUpEventArgs = New DevExpress.XtraEditors.Controls.CloseUpEventArgs(Nothing)
                args.AcceptValue = True
                args.Value = Me.lkpCalle2Destino.EditValue
                Me.lkpCalle2Etapa1_CloseUp(lkpCalle2Etapa1, args)
                Me.lkpHitoEtapa1.EditValue = Me.lkpHitoDestino.EditValue
                Me.lkpManzanaEtapa1.ItemIndex = Me.lkpManzanaDestino.ItemIndex
                Me.tmHoraLlegada.Focus()
            Case 2
                Me.lkpComunaEtapa1.EditValue = ""
                Me.txtComunaOtraEtapa1.Text = ""
                Me.lkpCalle1Etapa1.EditValue = ""
                Me.lkpCalle2Etapa1.EditValue = ""
                Me.lkpHitoEtapa1.EditValue = ""
                Me.txtCuadrasDespues.Enabled = True
                Me.txtMinutosDespues.Enabled = True
                Me.lkpManzanaEtapa1.Properties.DataSource = Nothing
        End Select
    End Sub

    Private Sub lkpOtroViaje_Enter(sender As Object, e As EventArgs)
        BeginInvoke(New MethodInvoker(Sub() CType(sender, GridLookUpEdit).ShowPopup()))
    End Sub

    Private Sub limpiaAutoE1()
        Me.txtCuadrasAutoE1.Text = "0"
        Me.txtMinutosAutoE1.Text = "0"
        Me.lkpViajaComoE1.EditValue = -1
        Me.lkpQueVehiculoE1.EditValue = -1
        Me.lkpDondeEstacionaE1.EditValue = -1
        Me.lkpVehHogarE1.EditValue = -1
        Me.txtCuantoPagoE1.Text = "0"
        Me.txtMinutosEstacionaAutoE1.Text = "0"
        Me.lkpFormaPagoE1.EditValue = -1
        Me.lkpLugarDondeBajoE1.EditValue = -1
    End Sub

    Private Sub limpiaBusE1()
        Me.txtCuadrasBusE1.Text = "0"
        Me.txtMinutosBusE1.Text = "0"
        Me.txtMinutosEsperaBusE1.Text = "0"
        Me.lkpTipoTarifaBusE1.EditValue = -1
        Me.txtTarifaMontoBusE1.Text = "0"
        Me.lkpLugarBajadaBusE1.EditValue = -1
    End Sub

    Private Sub limpiaTaxiE1()
        Me.txtCuadrasTaxiE1.Text = "0"
        Me.txtMinutosTaxiE1.Text = "0"
        Me.txtMinutosEsperaTaxiE1.Text = "0"
        Me.txtTarifaMontoTaxiE1.Text = "0"
        Me.lkpLugarBajadaTaxiE1.EditValue = -1
    End Sub

    Private Sub limpiaTxcE1()
        Me.txtCuadrasTXCE1.Text = "0"
        Me.txtMinutosTXCE1.Text = "0"
        Me.txtMinutosEsperaTXCE1.Text = "0"
        Me.txtTarifaMontoTXCE1.Text = "0"
        Me.lkpLugarBajadaTXCE1.EditValue = -1
    End Sub

    Private Sub limpiaBiciE1()
        Me.lkpPropiedadBicicletaE1.EditValue = -1
        Me.txtPropiedadBicicletaOtraE1.Text = ""
        Me.txtMotivoNoUsaE1.Text = ""
        Me.lkpEstacionamientoBiciE1.EditValue = -1
        Me.lkpLugarBajadaBiciE1.EditValue = -1
    End Sub

    Private Sub limpiaAutoE2()
        Me.txtCuadrasAutoE2.Text = "0"
        Me.txtMinutosAutoE2.Text = "0"
        Me.lkpViajaComoE2.EditValue = -1
        Me.lkpQueVehiculoE2.EditValue = -1
        Me.lkpVehHogarE2.EditValue = -1
        Me.lkpDondeEstacionaE2.EditValue = -1
        Me.txtCuantoPagoE2.Text = "0"
        Me.txtMinutosEstacionaAutoE2.Text = "0"
        Me.lkpFormaPagoE2.EditValue = -1
        Me.lkpLugarBajadaAutoE2.EditValue = -1
    End Sub

    Private Sub limpiaBusE2()
        Me.txtCuadrasBusE2.Text = "0"
        Me.txtMinutosBusE2.Text = "0"
        Me.txtMinutosEsperaBusE2.Text = "0"
        Me.lkpTipoTarifaBusE2.EditValue = -1
        Me.txtTarifaMontoBusE2.Text = "0"
        Me.lkpLugarBajadaBusE2.EditValue = -1
    End Sub

    Private Sub limpiaTaxiE2()
        Me.txtCuadrasTaxiE2.Text = "0"
        Me.txtMinutosTaxiE2.Text = "0"
        Me.txtMinutosEsperaTaxiE2.Text = "0"
        Me.txtTarifaMontoTaxiE2.Text = "0"
        Me.lkpLugarBajadaTaxiE2.EditValue = -1
    End Sub

    Private Sub limpiaTxcE2()
        Me.txtCuadrasTXCE2.Text = "0"
        Me.txtMinutosTXCE2.Text = "0"
        Me.txtMinutosEsperaTXCE2.Text = "0"
        Me.txtTarifaMontoTXCE2.Text = "0"
        Me.lkpLugarBajadaTXCE2.EditValue = -1
    End Sub

    Private Sub limpiaBiciE2()
        Me.lkpPropiedadBicicletaE2.EditValue = -1
        Me.txtPropiedadBicicletaOtraE2.Text = ""
        Me.lkpLugarBajadaBiciE2.EditValue = -1
        Me.txtMotivoNoUsaE2.Text = ""
        Me.lkpEstacionamientoBiciE2.EditValue = -1
    End Sub

    Private Sub limpiaAutoE3()
        Me.txtCuadrasAutoE3.Text = "0"
        Me.txtMinutosAutoE3.Text = "0"
        Me.lkpViajaComoE3.EditValue = -1
        Me.lkpQueVehiculoE3.EditValue = -1
        Me.lkpVehHogarE3.EditValue = -1
        Me.lkpDondeEstacionaE3.EditValue = -1
        Me.txtCuantoPagoE3.Text = "0"
        Me.txtMinutosEstacionaAutoE3.Text = "0"
        Me.lkpFormaPagoE3.EditValue = -1
        Me.lkpLugarBajadaAutoE3.EditValue = -1
    End Sub

    Private Sub limpiaBusE3()
        Me.txtCuadrasBusE3.Text = "0"
        Me.txtMinutosBusE3.Text = "0"
        Me.txtMinutosEsperaBusE3.Text = "0"
        Me.lkpTipoTarifaBusE3.EditValue = -1
        Me.txtTarifaMontoBusE3.Text = "0"
        Me.lkpLugarBajadaBusE3.EditValue = -1
    End Sub

    Private Sub limpiaTaxiE3()
        Me.txtCuadrasTaxiE3.Text = "0"
        Me.txtMinutosTaxiE3.Text = "0"
        Me.txtMinutosEsperaTaxiE3.Text = "0"
        Me.txtTarifaMontoTaxiE3.Text = "0"
        Me.lkpLugarBajadaTaxiE3.EditValue = -1
    End Sub

    Private Sub limpiaTxcE3()
        Me.txtCuadrasTXCE3.Text = "0"
        Me.txtMinutosTXCE3.Text = "0"
        Me.txtMinutosEsperaTXCE3.Text = "0"
        Me.txtTarifaMontoTXCE3.Text = "0"
        Me.lkpLugarBajadaTXCE3.EditValue = -1
    End Sub

    Private Sub limpiaBiciE3()
        Me.lkpPropiedadBicicletaE3.EditValue = -1
        Me.txtPropiedadBicicletaOtraE3.Text = ""
        Me.lkpLugarBajadaBiciE3.EditValue = -1
        Me.txtMotivoNoUsaE3.Text = ""
        Me.lkpEstacionamientoBiciE3.EditValue = -1
    End Sub

    Private Sub lkpTrabajoDeclarado_EditValueChanged(sender As Object, e As EventArgs) Handles lkpTrabajoDeclarado.EditValueChanged

        Dim opcion As Integer
        If lkpTrabajoDeclarado.EditValue IsNot Nothing AndAlso Me.lkpTrabajoDeclarado.EditValue.ToString <> "" Then
            opcion = Me.lkpTrabajoDeclarado.EditValue
        End If

        If persona IsNot Nothing Then
            Dim trabaja As Boolean = persona.Actividad.Contains("1")

            If trabaja AndAlso opcion = 1 Then
                Me.trabajoDeclarado = True
                Try
                    Me.lkpComunaDestino.EditValue = persona.ComunaTrabajo
                Catch ex As Exception
                End Try
                Try
                    Me.txtComunaDestinoOtra.Text = persona.ComunaTrabajoOtra
                Catch ex As Exception
                End Try
                Try
                    Me.lkpCalle1Destino.EditValue = persona.NombreCalle1Trabajo
                Catch ex As Exception
                End Try
                Try
                    Me.lkpCalle2Destino.EditValue = persona.NumeroOCalle2Trabajo
                    Dim args As DevExpress.XtraEditors.Controls.CloseUpEventArgs = New DevExpress.XtraEditors.Controls.CloseUpEventArgs(Nothing)
                    args.AcceptValue = True
                    args.Value = persona.NumeroOCalle2Trabajo
                    Me.lkpCalle2Destino_CloseUp(lkpCalle2Destino, args)
                Catch ex As Exception
                End Try
                Try
                    If persona.HitoTrabajo.ToString <> "" Then
                        Me.lkpHitoDestino.EditValue = persona.HitoTrabajo
                    End If
                Catch ex As Exception
                End Try
                Try
                    Me.lkpManzanaDestino.EditValue = persona.ManzanaTrabajo
                Catch ex As Exception
                End Try
                Try
                    Me.x_destino.Text = persona.DirActividadCoordX
                Catch ex As Exception
                End Try
                Try
                    Me.y_destino.Text = persona.DirActividadCoordY
                Catch ex As Exception
                End Try
            End If
        End If


        Me.lkpTransporte1.Focus()
    End Sub

    Private Sub lkpEstudioDeclarado_EditValueChanged(sender As Object, e As EventArgs) Handles lkpEstudioDeclarado.EditValueChanged

        Dim opcion As Integer
        If lkpEstudioDeclarado.EditValue IsNot Nothing AndAlso Me.lkpEstudioDeclarado.EditValue.ToString <> "" Then
            opcion = Me.lkpEstudioDeclarado.EditValue
        End If

        If persona IsNot Nothing Then
            Dim estudia As Boolean = persona.Actividad.Contains("2")
            If estudia AndAlso opcion = 1 Then
                Me.estudioDeclarado = True
                Try
                    Me.lkpComunaDestino.EditValue = persona.ComunaEstudio
                Catch ex As Exception
                End Try
                Try
                    Me.txtComunaDestinoOtra.Text = persona.ComunaEstudioOtra
                Catch ex As Exception
                End Try
                Try
                    Me.lkpCalle1Destino.EditValue = persona.NombreCalle1Estudio
                Catch ex As Exception
                End Try
                Try
                    Me.lkpCalle2Destino.EditValue = persona.NumeroOCalle2Estudio
                    Dim args As DevExpress.XtraEditors.Controls.CloseUpEventArgs = New DevExpress.XtraEditors.Controls.CloseUpEventArgs(Nothing)
                    args.AcceptValue = True
                    args.Value = persona.NumeroOCalle2Estudio
                    Me.lkpCalle2Destino_CloseUp(lkpCalle2Destino, args)
                Catch ex As Exception
                End Try
                Try
                    If persona.HitoEstudio.ToString <> "" Then
                        Me.lkpHitoDestino.EditValue = persona.HitoEstudio
                    End If
                Catch ex As Exception
                End Try
                Try
                    Me.lkpManzanaDestino.EditValue = persona.ManzanaTrabajo
                Catch ex As Exception
                End Try
                Try
                    Me.x_destino.Text = persona.DirEstudiosCoordX
                Catch ex As Exception
                End Try
                Try
                    Me.y_destino.Text = persona.DirEstudiosCoordY
                Catch ex As Exception
                End Try
            End If
        End If

        Me.lkpTransporte1.Focus()
    End Sub

    Private Sub lkpComunaAnterior_EditValueChanged(sender As Object, e As EventArgs) Handles lkpComunaAnterior.EditValueChanged
        Dim comuna As Integer

        If lkpComunaAnterior.EditValue IsNot Nothing AndAlso lkpComunaAnterior.EditValue.ToString <> "" Then
            comuna = lkpComunaAnterior.EditValue
        End If

        Me.spCallesViajeAnterior.Visible = False

        Select Case comuna
            Case 1
                Me.spCallesViajeAnterior.Visible = True
                Me.spCallesViajeAnterior.CollapsePanel = DevExpress.XtraEditors.SplitCollapsePanel.Panel2
                Me.spCallesViajeAnterior.Collapsed = True
            Case 2
                Me.spCallesViajeAnterior.Visible = True
                Me.spCallesViajeAnterior.CollapsePanel = DevExpress.XtraEditors.SplitCollapsePanel.Panel1
                Me.spCallesViajeAnterior.Collapsed = True
        End Select
    End Sub

    Private Sub lkpPropiedadBicicletaE1_EditValueChanged(sender As Object, e As EventArgs) Handles lkpPropiedadBicicletaE1.EditValueChanged
        Me.spcPropiedadBicicletaE1.Collapsed = True
        Me.txtPropiedadBicicletaOtraE1.Visible = False
        Me.lblPropiedadBiciOtraE1.Visible = False

        Dim opcion As Integer

        If lkpPropiedadBicicletaE1.EditValue IsNot Nothing AndAlso Me.lkpPropiedadBicicletaE1.EditValue.ToString <> "" Then
            opcion = Me.lkpPropiedadBicicletaE1.EditValue

            If opcion = 2 Then
                Me.spcPropiedadBicicletaE1.Collapsed = False
                Me.txtPropiedadBicicletaOtraE1.Visible = True
                Me.lblPropiedadBiciOtraE1.Visible = True
            End If
        End If
    End Sub

    Private Function viajeCompleto() As Boolean
        Dim completo As Boolean = True

        If Me.idViaje = 1 Then

            'Campo Comuna Origen
            If lkpComunaOrigen.EditValue Is Nothing OrElse lkpComunaOrigen.EditValue.ToString = "" OrElse lkpComunaOrigen.EditValue < 1 Then
                completo = False
                lkpComunaOrigen.Properties.Appearance.BorderColor = Color.Red
            Else
                lkpComunaOrigen.Properties.Appearance.BorderColor = Nothing

                If lkpComunaOrigen.EditValue = 1 Then
                    'Campo Otra Comuna Origen
                    If txtComunaOrigenOtra.Text = "" Then
                        completo = False
                        txtComunaOrigenOtra.Properties.Appearance.BorderColor = Color.Red
                    Else
                        txtComunaOrigenOtra.Properties.Appearance.BorderColor = Nothing
                    End If
                ElseIf lkpComunaOrigen.EditValue = 2 Then
                    'Dirección Origen

                    'Campo Hito Origen
                    If lkpHitoOrigen.EditValue Is Nothing OrElse lkpHitoOrigen.EditValue.ToString = "" Then

                        'Campo Calle 1 Origen
                        If lkpCalle1Origen.EditValue Is Nothing OrElse lkpCalle1Origen.EditValue.ToString = "" Then
                            completo = False
                            lkpCalle1Origen.Properties.Appearance.BorderColor = Color.Red
                            lkpHitoOrigen.Properties.Appearance.BorderColor = Color.Red
                        Else
                            'Campo Calle 2 Origen
                            If lkpCalle2Origen.EditValue Is Nothing OrElse lkpCalle2Origen.EditValue.ToString = "" Then
                                completo = False
                                lkpCalle2Origen.Properties.Appearance.BorderColor = Color.Red
                                lkpHitoOrigen.Properties.Appearance.BorderColor = Color.Red
                            Else
                                lkpCalle1Origen.Properties.Appearance.BorderColor = Nothing
                                lkpCalle2Origen.Properties.Appearance.BorderColor = Nothing
                                lkpHitoOrigen.Properties.Appearance.BorderColor = Nothing
                            End If
                        End If
                    Else
                        lkpHitoOrigen.Properties.Appearance.BorderColor = Nothing
                    End If

                    'Campo Manzana Origen
                    If lkpManzanaOrigen.EditValue Is Nothing OrElse lkpManzanaOrigen.EditValue.ToString = "" Then
                        completo = False
                        lkpManzanaOrigen.Properties.Appearance.BorderColor = Color.Red
                    Else
                        lkpManzanaOrigen.Properties.Appearance.BorderColor = Nothing
                    End If

                End If
            End If
        End If

        'Campo Hora Salida
        If tmHoraSalida.EditValue Is Nothing OrElse tmHoraSalida.EditValue.ToString = "" Then
            completo = False
            tmHoraSalida.Properties.Appearance.BorderColor = Color.Red
        Else
            tmHoraSalida.Properties.Appearance.BorderColor = Nothing
        End If

        'Campo Propósito
        If lkpProposito.EditValue Is Nothing OrElse lkpProposito.EditValue.ToString = "" OrElse lkpProposito.EditValue < 1 Then
            completo = False
            lkpProposito.Properties.Appearance.BorderColor = Color.Red
        Else
            lkpProposito.Properties.Appearance.BorderColor = Nothing

            If lkpProposito.EditValue = 9 Then
                'Campo Otro Propósito
                If txtOtroProposito.Text = "" Then
                    completo = False
                    txtOtroProposito.Properties.Appearance.BorderColor = Color.Red
                Else
                    txtOtroProposito.Properties.Appearance.BorderColor = Nothing
                End If

            ElseIf lkpProposito.EditValue = 1 AndAlso persona.Actividad.Contains("1") Then
                'Campo Dirección Trabajo
                If lkpTrabajoDeclarado.EditValue Is Nothing OrElse lkpTrabajoDeclarado.EditValue.ToString = "" Then
                    completo = False
                    lkpTrabajoDeclarado.Properties.Appearance.BorderColor = Color.Red
                Else
                    lkpTrabajoDeclarado.Properties.Appearance.BorderColor = Nothing
                End If

            ElseIf lkpProposito.EditValue = 2 AndAlso persona.Actividad.Contains("2") Then
                'Campo Dirección Estudio
                If lkpEstudioDeclarado.EditValue Is Nothing OrElse lkpEstudioDeclarado.EditValue.ToString = "" Then
                    completo = False
                    lkpEstudioDeclarado.Properties.Appearance.BorderColor = Color.Red
                Else
                    lkpEstudioDeclarado.Properties.Appearance.BorderColor = Nothing
                End If
            End If
        End If

        'Campo Comuna Destino
        If lkpComunaDestino.EditValue Is Nothing OrElse lkpComunaDestino.EditValue.ToString = "" OrElse lkpComunaDestino.EditValue < 1 Then
            completo = False
            lkpComunaDestino.Properties.Appearance.BorderColor = Color.Red
        Else
            lkpComunaDestino.Properties.Appearance.BorderColor = Nothing

            If lkpComunaDestino.EditValue = 1 Then
                'Campo Otra Comuna Destino
                If txtComunaDestinoOtra.Text = "" Then
                    completo = False
                    txtComunaDestinoOtra.Properties.Appearance.BorderColor = Color.Red
                Else
                    txtComunaDestinoOtra.Properties.Appearance.BorderColor = Nothing
                End If
            ElseIf lkpComunaDestino.EditValue = 2 Then
                'Dirección Destino

                'Campo Hito Destino
                If lkpHitoDestino.EditValue Is Nothing OrElse lkpHitoDestino.EditValue.ToString = "" Then

                    'Campo Calle 1 Destino
                    If lkpCalle1Destino.EditValue Is Nothing OrElse lkpCalle1Destino.EditValue.ToString = "" Then
                        completo = False
                        lkpCalle1Destino.Properties.Appearance.BorderColor = Color.Red
                        lkpHitoDestino.Properties.Appearance.BorderColor = Color.Red
                    Else
                        'Campo Calle 2 Destino
                        If lkpCalle2Destino.EditValue Is Nothing OrElse lkpCalle2Destino.EditValue.ToString = "" Then
                            completo = False
                            lkpCalle2Destino.Properties.Appearance.BorderColor = Color.Red
                            lkpHitoDestino.Properties.Appearance.BorderColor = Color.Red
                        Else
                            lkpCalle1Destino.Properties.Appearance.BorderColor = Nothing
                            lkpCalle2Destino.Properties.Appearance.BorderColor = Nothing
                            lkpHitoDestino.Properties.Appearance.BorderColor = Nothing
                        End If
                    End If
                Else
                    lkpHitoDestino.Properties.Appearance.BorderColor = Nothing
                End If

                'Campo Manzana Destino
                If lkpManzanaDestino.EditValue Is Nothing OrElse lkpManzanaDestino.EditValue.ToString = "" Then
                    completo = False
                    lkpManzanaDestino.Properties.Appearance.BorderColor = Color.Red
                Else
                    lkpManzanaDestino.Properties.Appearance.BorderColor = Nothing
                End If

            End If
        End If

        'Campo Transporte 1
        If lkpTransporte1.EditValue Is Nothing OrElse lkpTransporte1.EditValue.ToString = "" Then
            completo = False
            lkpTransporte1.Properties.Appearance.BorderColor = Color.Red
        Else
            lkpTransporte1.Properties.Appearance.BorderColor = Nothing
        End If

        'Campo Hora Llegada
        If tmHoraLlegada.EditValue Is Nothing OrElse tmHoraLlegada.EditValue.ToString = "" Then
            completo = False
            tmHoraLlegada.Properties.Appearance.BorderColor = Color.Red
        Else
            tmHoraLlegada.Properties.Appearance.BorderColor = Nothing
        End If

        'Campo Viaje Transoche
        If lkpTrasnoche.EditValue Is Nothing OrElse lkpTrasnoche.EditValue.ToString = "" Then
            completo = False
            lkpTrasnoche.Properties.Appearance.BorderColor = Color.Red
        Else
            lkpTrasnoche.Properties.Appearance.BorderColor = Nothing
        End If

        'Campo Minutos Después
        If txtMinutosDespues.Text = "" Then
            completo = False
            txtMinutosDespues.Properties.Appearance.BorderColor = Color.Red
        Else
            txtMinutosDespues.Properties.Appearance.BorderColor = Nothing
        End If

        'Campo Cuadras Después
        If txtCuadrasDespues.Text = "" Then
            completo = False
            txtCuadrasDespues.Properties.Appearance.BorderColor = Color.Red
        Else
            txtCuadrasDespues.Properties.Appearance.BorderColor = Nothing
        End If

        If lkpTransporte1.EditValue.ToString <> "" AndAlso lkpTransporte1.EditValue > 0 Then
            completo = etapa1Completa(Integer.Parse(Me.lkpTransporte1.EditValue))
        End If
        If lkpTransporte2.EditValue.ToString <> "" AndAlso lkpTransporte2.EditValue > 0 Then
            completo = etapa2Completa(Integer.Parse(Me.lkpTransporte2.EditValue))
        End If
        If lkpTransporte3.EditValue.ToString <> "" AndAlso lkpTransporte3.EditValue > 0 Then
            completo = etapa3Completa(Integer.Parse(Me.lkpTransporte3.EditValue))
        End If

        Return completo
    End Function

    Private Sub lkpLugarBajadaTXCE2_Enter(sender As Object, e As EventArgs) Handles lkpLugarBajadaTXCE2.Enter
        BeginInvoke(New MethodInvoker(Sub() CType(sender, GridLookUpEdit).ShowPopup()))
    End Sub

    Private Sub lkpPagaEstacionamientoE1_Enter(sender As Object, e As EventArgs)
        BeginInvoke(New MethodInvoker(Sub() CType(sender, GridLookUpEdit).ShowPopup()))
    End Sub


    Private Function etapa1Completa(ByVal modo As Integer) As Boolean
        If modo = 7 Then
            Return True
        Else
            Dim completo As Boolean = True

            Select Case modo
                Case 1, 5, 9
                    'Campo Minutos Antes
                    If txtMinutosAutoE1.Text = "" Then
                        completo = False
                        txtMinutosAutoE1.Properties.Appearance.BorderColor = Color.Red
                    Else
                        txtMinutosAutoE1.Properties.Appearance.BorderColor = Nothing
                    End If

                    'Campo Cuadras Antes
                    If txtCuadrasAutoE1.Text = "" Then
                        completo = False
                        txtCuadrasAutoE1.Properties.Appearance.BorderColor = Color.Red
                    Else
                        txtCuadrasAutoE1.Properties.Appearance.BorderColor = Nothing
                    End If

                    'Campo Viaja Como
                    If lkpViajaComoE1.EditValue Is Nothing OrElse lkpViajaComoE1.EditValue.ToString = "" Then
                        completo = False
                        lkpViajaComoE1.Properties.Appearance.BorderColor = Color.Red
                    Else
                        lkpViajaComoE1.Properties.Appearance.BorderColor = Nothing

                        If lkpViajaComoE1.EditValue = 1 Then
                            'Campo Donde Estaciona
                            If lkpDondeEstacionaE1.EditValue Is Nothing OrElse lkpDondeEstacionaE1.EditValue.ToString = "" Then
                                completo = False
                                lkpDondeEstacionaE1.Properties.Appearance.BorderColor = Color.Red
                            Else
                                lkpDondeEstacionaE1.Properties.Appearance.BorderColor = Nothing
                            End If

                            'Campo Minutos Espera Estacionamiento
                            If txtMinutosEstacionaAutoE1.Text = "" Then
                                completo = False
                                txtMinutosEstacionaAutoE1.Properties.Appearance.BorderColor = Color.Red
                            Else
                                txtMinutosEstacionaAutoE1.Properties.Appearance.BorderColor = Nothing
                            End If

                            'Campo Forma Pago
                            If lkpFormaPagoE1.EditValue Is Nothing OrElse lkpFormaPagoE1.EditValue.ToString = "" Then
                                completo = False
                                lkpFormaPagoE1.Properties.Appearance.BorderColor = Color.Red

                                If (lkpFormaPagoE1.EditValue > 0 AndAlso lkpFormaPagoE1.EditValue < 8) Then
                                    'Campo Cuánto Paga
                                    If txtCuantoPagoE1.Text = "" Then
                                        completo = False
                                        txtCuantoPagoE1.Properties.Appearance.BorderColor = Color.Red
                                    Else
                                        txtCuantoPagoE1.Properties.Appearance.BorderColor = Nothing
                                    End If
                                End If
                            Else
                                lkpFormaPagoE1.Properties.Appearance.BorderColor = Nothing
                            End If
                        End If
                    End If

                    'Campo Qué Vehículo
                    If lkpQueVehiculoE1.EditValue Is Nothing OrElse lkpQueVehiculoE1.EditValue.ToString = "" Then
                        completo = False
                        lkpQueVehiculoE1.Properties.Appearance.BorderColor = Color.Red
                    Else
                        lkpQueVehiculoE1.Properties.Appearance.BorderColor = Nothing

                        If lkpQueVehiculoE1.EditValue = 1 Then
                            'Campo Vehículo del hogar
                            If lkpVehHogarE1.EditValue Is Nothing OrElse lkpVehHogarE1.EditValue.ToString = "" Then
                                completo = False
                                lkpVehHogarE1.Properties.Appearance.BorderColor = Color.Red
                            Else
                                lkpVehHogarE1.Properties.Appearance.BorderColor = Nothing
                            End If
                        End If
                    End If



                Case 2, 10, 11, 12
                    'Campo Minutos Antes
                    If txtMinutosBusE1.Text = "" Then
                        completo = False
                        txtMinutosBusE1.Properties.Appearance.BorderColor = Color.Red
                    Else
                        txtMinutosBusE1.Properties.Appearance.BorderColor = Nothing
                    End If

                    'Campo Cuadras Antes
                    If txtCuadrasBusE1.Text = "" Then
                        completo = False
                        txtCuadrasBusE1.Properties.Appearance.BorderColor = Color.Red
                    Else
                        txtCuadrasBusE1.Properties.Appearance.BorderColor = Nothing
                    End If

                    'Campo Minutos Espera
                    If txtMinutosEsperaBusE1.Text = "" Then
                        completo = False
                        txtMinutosEsperaBusE1.Properties.Appearance.BorderColor = Color.Red
                    Else
                        txtMinutosEsperaBusE1.Properties.Appearance.BorderColor = Nothing
                    End If

                    'Campo Tipo Tarifa
                    If lkpTipoTarifaBusE1.EditValue Is Nothing OrElse lkpTipoTarifaBusE1.EditValue.ToString = "" Then
                        completo = False
                        lkpTipoTarifaBusE1.Properties.Appearance.BorderColor = Color.Red
                    Else
                        lkpTipoTarifaBusE1.Properties.Appearance.BorderColor = Nothing

                        If lkpTipoTarifaBusE1.EditValue > 0 AndAlso lkpTipoTarifaBusE1.EditValue < 4 Then
                            'Campo Monto Tarifa
                            If txtTarifaMontoBusE1.Text = "" Then
                                completo = False
                                txtTarifaMontoBusE1.Properties.Appearance.BorderColor = Color.Red
                            Else
                                txtTarifaMontoBusE1.Properties.Appearance.BorderColor = Nothing
                            End If
                        End If
                    End If

                    'Campo Lugar Bajada
                    If lkpLugarBajadaBusE1.EditValue Is Nothing OrElse lkpLugarBajadaBusE1.EditValue.ToString = "" Then
                        completo = False
                        lkpLugarBajadaBusE1.Properties.Appearance.BorderColor = Color.Red
                    Else
                        lkpLugarBajadaBusE1.Properties.Appearance.BorderColor = Nothing
                    End If

                Case 3, 4
                    'Campo Minutos Antes
                    If txtMinutosTXCE1.Text = "" Then
                        completo = False
                        txtMinutosTXCE1.Properties.Appearance.BorderColor = Color.Red
                    Else
                        txtMinutosTXCE1.Properties.Appearance.BorderColor = Nothing
                    End If

                    'Campo Cuadras Antes
                    If txtCuadrasTXCE1.Text = "" Then
                        completo = False
                        txtCuadrasTXCE1.Properties.Appearance.BorderColor = Color.Red
                    Else
                        txtCuadrasTXCE1.Properties.Appearance.BorderColor = Nothing
                    End If

                    'Campo Minutos Espera
                    If txtMinutosEsperaTXCE1.Text = "" Then
                        completo = False
                        txtMinutosEsperaTXCE1.Properties.Appearance.BorderColor = Color.Red
                    Else
                        txtMinutosEsperaTXCE1.Properties.Appearance.BorderColor = Nothing
                    End If

                    'Campo Monto Tarifa
                    If txtTarifaMontoTXCE1.Text = "" Then
                        completo = False
                        txtTarifaMontoTXCE1.Properties.Appearance.BorderColor = Color.Red
                    Else
                        txtTarifaMontoTXCE1.Properties.Appearance.BorderColor = Nothing
                    End If

                    'Campo Lugar Bajada
                    If lkpLugarBajadaTXCE1.EditValue Is Nothing OrElse lkpLugarBajadaTXCE1.EditValue.ToString = "" Then
                        completo = False
                        lkpLugarBajadaTXCE1.Properties.Appearance.BorderColor = Color.Red
                    Else
                        lkpLugarBajadaTXCE1.Properties.Appearance.BorderColor = Nothing
                    End If
                Case 6
                    'Campo Minutos Antes
                    If txtMinutosTaxiE1.Text = "" Then
                        completo = False
                        txtMinutosTaxiE1.Properties.Appearance.BorderColor = Color.Red
                    Else
                        txtMinutosTaxiE1.Properties.Appearance.BorderColor = Nothing
                    End If

                    'Campo Cuadras Antes
                    If txtCuadrasTaxiE1.Text = "" Then
                        completo = False
                        txtCuadrasTaxiE1.Properties.Appearance.BorderColor = Color.Red
                    Else
                        txtCuadrasTaxiE1.Properties.Appearance.BorderColor = Nothing
                    End If

                    'Campo Minutos Espera
                    If txtMinutosEsperaTaxiE1.Text = "" Then
                        completo = False
                        txtMinutosEsperaTaxiE1.Properties.Appearance.BorderColor = Color.Red
                    Else
                        txtMinutosEsperaTaxiE1.Properties.Appearance.BorderColor = Nothing
                    End If

                    'Campo Monto Tarifa
                    If txtTarifaMontoTaxiE1.Text = "" Then
                        completo = False
                        txtTarifaMontoTaxiE1.Properties.Appearance.BorderColor = Color.Red
                    Else
                        txtTarifaMontoTaxiE1.Properties.Appearance.BorderColor = Nothing
                    End If

                    'Campo Lugar Bajada
                    If lkpLugarBajadaTaxiE1.EditValue Is Nothing OrElse lkpLugarBajadaTaxiE1.EditValue.ToString = "" Then
                        completo = False
                        lkpLugarBajadaTaxiE1.Properties.Appearance.BorderColor = Color.Red
                    Else
                        lkpLugarBajadaTaxiE1.Properties.Appearance.BorderColor = Nothing
                    End If

                Case 8
                    'Campo Propiedad Bicicleta
                    If lkpPropiedadBicicletaE1.EditValue Is Nothing OrElse lkpPropiedadBicicletaE1.EditValue.ToString = "" Then
                        completo = False
                        lkpPropiedadBicicletaE1.Properties.Appearance.BorderColor = Color.Red
                    Else
                        lkpPropiedadBicicletaE1.Properties.Appearance.BorderColor = Nothing

                        If lkpPropiedadBicicletaE1.EditValue = 2 Then
                            'Campo Propiedad Otra
                            If txtPropiedadBicicletaOtraE1.Text = "" Then
                                completo = False
                                txtPropiedadBicicletaOtraE1.Properties.Appearance.BorderColor = Color.Red
                            Else
                                txtPropiedadBicicletaOtraE1.Properties.Appearance.BorderColor = Nothing
                            End If
                        End If
                    End If

                    'Campo Ciclovia
                    If lkpCicloviaE1.EditValue Is Nothing OrElse lkpCicloviaE1.EditValue.ToString = "" Then
                        completo = False
                        lkpCicloviaE1.Properties.Appearance.BorderColor = Color.Red
                    Else
                        lkpCicloviaE1.Properties.Appearance.BorderColor = Nothing

                        If lkpCicloviaE1.EditValue = 2 Then
                            'Campo Motivo No Usa
                            If txtMotivoNoUsaE1.Text = "" Then
                                completo = False
                                txtMotivoNoUsaE1.Properties.Appearance.BorderColor = Color.Red
                            Else
                                txtMotivoNoUsaE1.Properties.Appearance.BorderColor = Nothing
                            End If
                        End If

                    End If

                    'Campo Estacionamiento Bici
                    If lkpEstacionamientoBiciE1.EditValue Is Nothing OrElse lkpEstacionamientoBiciE1.EditValue.ToString = "" Then
                        completo = False
                        lkpEstacionamientoBiciE1.Properties.Appearance.BorderColor = Color.Red
                    Else
                        lkpEstacionamientoBiciE1.Properties.Appearance.BorderColor = Nothing
                    End If

                    'Campo Lugar Bajada
                    If lkpLugarBajadaBiciE1.EditValue Is Nothing OrElse lkpLugarBajadaBiciE1.EditValue.ToString = "" Then
                        completo = False
                        lkpLugarBajadaBiciE1.Properties.Appearance.BorderColor = Color.Red
                    Else
                        lkpLugarBajadaBiciE1.Properties.Appearance.BorderColor = Nothing
                    End If


            End Select

            If modo < 13 Then
                'Campo Comuna Etapa1
                If lkpComunaEtapa1.EditValue Is Nothing OrElse lkpComunaEtapa1.EditValue.ToString = "" OrElse lkpComunaEtapa1.EditValue < 1 Then
                    completo = False
                    lkpComunaEtapa1.Properties.Appearance.BorderColor = Color.Red
                Else
                    lkpComunaEtapa1.Properties.Appearance.BorderColor = Nothing

                    If lkpComunaEtapa1.EditValue = 1 Then
                        'Campo Otra Comuna Etapa1
                        If txtComunaOtraEtapa1.Text = "" Then
                            completo = False
                            txtComunaOtraEtapa1.Properties.Appearance.BorderColor = Color.Red
                        Else
                            txtComunaOtraEtapa1.Properties.Appearance.BorderColor = Nothing
                        End If
                    ElseIf lkpComunaEtapa1.EditValue = 2 Then
                        'Dirección Etapa1

                        'Campo Hito Etapa1
                        If lkpHitoEtapa1.EditValue Is Nothing OrElse lkpHitoEtapa1.EditValue.ToString = "" Then

                            'Campo Calle 1 Etapa1
                            If lkpCalle1Etapa1.EditValue Is Nothing OrElse lkpCalle1Etapa1.EditValue.ToString = "" Then
                                completo = False
                                lkpCalle1Etapa1.Properties.Appearance.BorderColor = Color.Red
                                lkpHitoEtapa1.Properties.Appearance.BorderColor = Color.Red
                            Else
                                'Campo Calle 2 Etapa1
                                If lkpCalle2Etapa1.EditValue Is Nothing OrElse lkpCalle2Etapa1.EditValue.ToString = "" Then
                                    completo = False
                                    lkpCalle2Etapa1.Properties.Appearance.BorderColor = Color.Red
                                    lkpHitoEtapa1.Properties.Appearance.BorderColor = Color.Red
                                Else
                                    lkpCalle1Etapa1.Properties.Appearance.BorderColor = Nothing
                                    lkpCalle2Etapa1.Properties.Appearance.BorderColor = Nothing
                                    lkpHitoEtapa1.Properties.Appearance.BorderColor = Nothing
                                End If
                            End If
                        Else
                            lkpHitoEtapa1.Properties.Appearance.BorderColor = Nothing
                        End If

                        'Campo Manzana Etapa1
                        If lkpManzanaEtapa1.EditValue Is Nothing OrElse lkpManzanaEtapa1.EditValue.ToString = "" Then
                            completo = False
                            lkpManzanaEtapa1.Properties.Appearance.BorderColor = Color.Red
                        Else
                            lkpManzanaEtapa1.Properties.Appearance.BorderColor = Nothing
                        End If

                    End If
                End If
            End If

            If completo = False Then
                tabTransporte1.Appearance.Header.ForeColor = Color.Red
            Else
                tabTransporte1.Appearance.Header.ForeColor = Color.Black
            End If
            Return completo
        End If


    End Function

    Private Function etapa2Completa(ByVal modo As Integer) As Boolean
        Dim completo As Boolean = True

        Select Case modo
            Case 1, 5, 9
                'Campo Minutos Antes
                If txtMinutosAutoE2.Text = "" Then
                    completo = False
                    txtMinutosAutoE2.Properties.Appearance.BorderColor = Color.Red
                Else
                    txtMinutosAutoE2.Properties.Appearance.BorderColor = Nothing
                End If

                'Campo Cuadras Antes
                If txtCuadrasAutoE2.Text = "" Then
                    completo = False
                    txtCuadrasAutoE2.Properties.Appearance.BorderColor = Color.Red
                Else
                    txtCuadrasAutoE2.Properties.Appearance.BorderColor = Nothing
                End If

                'Campo Viaja Como
                If lkpViajaComoE2.EditValue Is Nothing OrElse lkpViajaComoE2.EditValue.ToString = "" Then
                    completo = False
                    lkpViajaComoE2.Properties.Appearance.BorderColor = Color.Red
                Else
                    lkpViajaComoE2.Properties.Appearance.BorderColor = Nothing

                    If lkpViajaComoE2.EditValue = 1 Then
                        'Campo Donde Estaciona
                        If lkpDondeEstacionaE2.EditValue Is Nothing OrElse lkpDondeEstacionaE2.EditValue.ToString = "" Then
                            completo = False
                            lkpDondeEstacionaE2.Properties.Appearance.BorderColor = Color.Red
                        Else
                            lkpDondeEstacionaE2.Properties.Appearance.BorderColor = Nothing
                        End If

                        'Campo Minutos Espera Estacionamiento
                        If txtMinutosEstacionaAutoE2.Text = "" Then
                            completo = False
                            txtMinutosEstacionaAutoE2.Properties.Appearance.BorderColor = Color.Red
                        Else
                            txtMinutosEstacionaAutoE2.Properties.Appearance.BorderColor = Nothing
                        End If

                        'Campo Forma Pago
                        If lkpFormaPagoE2.EditValue Is Nothing OrElse lkpFormaPagoE2.EditValue.ToString = "" Then
                            completo = False
                            lkpFormaPagoE2.Properties.Appearance.BorderColor = Color.Red

                            If (lkpFormaPagoE2.EditValue > 0 AndAlso lkpFormaPagoE2.EditValue < 8) Then
                                'Campo Cuánto Paga
                                If txtCuantoPagoE2.Text = "" Then
                                    completo = False
                                    txtCuantoPagoE2.Properties.Appearance.BorderColor = Color.Red
                                Else
                                    txtCuantoPagoE2.Properties.Appearance.BorderColor = Nothing
                                End If
                            End If
                        Else
                            lkpFormaPagoE2.Properties.Appearance.BorderColor = Nothing
                        End If
                    End If
                End If

                'Campo Qué Vehículo
                If lkpQueVehiculoE2.EditValue Is Nothing OrElse lkpQueVehiculoE2.EditValue.ToString = "" Then
                    completo = False
                    lkpQueVehiculoE2.Properties.Appearance.BorderColor = Color.Red
                Else
                    lkpQueVehiculoE2.Properties.Appearance.BorderColor = Nothing

                    If lkpQueVehiculoE2.EditValue = 1 Then
                        'Campo Vehículo del hogar
                        If lkpVehHogarE2.EditValue Is Nothing OrElse lkpVehHogarE2.EditValue.ToString = "" Then
                            completo = False
                            lkpVehHogarE2.Properties.Appearance.BorderColor = Color.Red
                        Else
                            lkpVehHogarE2.Properties.Appearance.BorderColor = Nothing
                        End If
                    End If
                End If



            Case 2, 10, 11, 12
                'Campo Minutos Antes
                If txtMinutosBusE2.Text = "" Then
                    completo = False
                    txtMinutosBusE2.Properties.Appearance.BorderColor = Color.Red
                Else
                    txtMinutosBusE2.Properties.Appearance.BorderColor = Nothing
                End If

                'Campo Cuadras Antes
                If txtCuadrasBusE2.Text = "" Then
                    completo = False
                    txtCuadrasBusE2.Properties.Appearance.BorderColor = Color.Red
                Else
                    txtCuadrasBusE2.Properties.Appearance.BorderColor = Nothing
                End If

                'Campo Minutos Espera
                If txtMinutosEsperaBusE2.Text = "" Then
                    completo = False
                    txtMinutosEsperaBusE2.Properties.Appearance.BorderColor = Color.Red
                Else
                    txtMinutosEsperaBusE2.Properties.Appearance.BorderColor = Nothing
                End If

                'Campo Tipo Tarifa
                If lkpTipoTarifaBusE2.EditValue Is Nothing OrElse lkpTipoTarifaBusE2.EditValue.ToString = "" Then
                    completo = False
                    lkpTipoTarifaBusE2.Properties.Appearance.BorderColor = Color.Red
                Else
                    lkpTipoTarifaBusE2.Properties.Appearance.BorderColor = Nothing

                    If lkpTipoTarifaBusE2.EditValue > 0 AndAlso lkpTipoTarifaBusE2.EditValue < 4 Then
                        'Campo Monto Tarifa
                        If txtTarifaMontoBusE2.Text = "" Then
                            completo = False
                            txtTarifaMontoBusE2.Properties.Appearance.BorderColor = Color.Red
                        Else
                            txtTarifaMontoBusE2.Properties.Appearance.BorderColor = Nothing
                        End If
                    End If
                End If

                'Campo Lugar Bajada
                If lkpLugarBajadaBusE2.EditValue Is Nothing OrElse lkpLugarBajadaBusE2.EditValue.ToString = "" Then
                    completo = False
                    lkpLugarBajadaBusE2.Properties.Appearance.BorderColor = Color.Red
                Else
                    lkpLugarBajadaBusE2.Properties.Appearance.BorderColor = Nothing
                End If

            Case 3, 4
                'Campo Minutos Antes
                If txtMinutosTXCE2.Text = "" Then
                    completo = False
                    txtMinutosTXCE2.Properties.Appearance.BorderColor = Color.Red
                Else
                    txtMinutosTXCE2.Properties.Appearance.BorderColor = Nothing
                End If

                'Campo Cuadras Antes
                If txtCuadrasTXCE2.Text = "" Then
                    completo = False
                    txtCuadrasTXCE2.Properties.Appearance.BorderColor = Color.Red
                Else
                    txtCuadrasTXCE2.Properties.Appearance.BorderColor = Nothing
                End If

                'Campo Minutos Espera
                If txtMinutosEsperaTXCE2.Text = "" Then
                    completo = False
                    txtMinutosEsperaTXCE2.Properties.Appearance.BorderColor = Color.Red
                Else
                    txtMinutosEsperaTXCE2.Properties.Appearance.BorderColor = Nothing
                End If

                'Campo Monto Tarifa
                If txtTarifaMontoTXCE2.Text = "" Then
                    completo = False
                    txtTarifaMontoTXCE2.Properties.Appearance.BorderColor = Color.Red
                Else
                    txtTarifaMontoTXCE2.Properties.Appearance.BorderColor = Nothing
                End If

                'Campo Lugar Bajada
                If lkpLugarBajadaTXCE2.EditValue Is Nothing OrElse lkpLugarBajadaTXCE2.EditValue.ToString = "" Then
                    completo = False
                    lkpLugarBajadaTXCE2.Properties.Appearance.BorderColor = Color.Red
                Else
                    lkpLugarBajadaTXCE2.Properties.Appearance.BorderColor = Nothing
                End If
            Case 6
                'Campo Minutos Antes
                If txtMinutosTaxiE2.Text = "" Then
                    completo = False
                    txtMinutosTaxiE2.Properties.Appearance.BorderColor = Color.Red
                Else
                    txtMinutosTaxiE2.Properties.Appearance.BorderColor = Nothing
                End If

                'Campo Cuadras Antes
                If txtCuadrasTaxiE2.Text = "" Then
                    completo = False
                    txtCuadrasTaxiE2.Properties.Appearance.BorderColor = Color.Red
                Else
                    txtCuadrasTaxiE2.Properties.Appearance.BorderColor = Nothing
                End If

                'Campo Minutos Espera
                If txtMinutosEsperaTaxiE2.Text = "" Then
                    completo = False
                    txtMinutosEsperaTaxiE2.Properties.Appearance.BorderColor = Color.Red
                Else
                    txtMinutosEsperaTaxiE2.Properties.Appearance.BorderColor = Nothing
                End If

                'Campo Monto Tarifa
                If txtTarifaMontoTaxiE2.Text = "" Then
                    completo = False
                    txtTarifaMontoTaxiE2.Properties.Appearance.BorderColor = Color.Red
                Else
                    txtTarifaMontoTaxiE2.Properties.Appearance.BorderColor = Nothing
                End If

                'Campo Lugar Bajada
                If lkpLugarBajadaTaxiE2.EditValue Is Nothing OrElse lkpLugarBajadaTaxiE2.EditValue.ToString = "" Then
                    completo = False
                    lkpLugarBajadaTaxiE2.Properties.Appearance.BorderColor = Color.Red
                Else
                    lkpLugarBajadaTaxiE2.Properties.Appearance.BorderColor = Nothing
                End If

            Case 8
                'Campo Propiedad Bicicleta
                If lkpPropiedadBicicletaE2.EditValue Is Nothing OrElse lkpPropiedadBicicletaE2.EditValue.ToString = "" Then
                    completo = False
                    lkpPropiedadBicicletaE2.Properties.Appearance.BorderColor = Color.Red
                Else
                    lkpPropiedadBicicletaE2.Properties.Appearance.BorderColor = Nothing

                    If lkpPropiedadBicicletaE2.EditValue = 2 Then
                        'Campo Propiedad Otra
                        If txtPropiedadBicicletaOtraE2.Text = "" Then
                            completo = False
                            txtPropiedadBicicletaOtraE2.Properties.Appearance.BorderColor = Color.Red
                        Else
                            txtPropiedadBicicletaOtraE2.Properties.Appearance.BorderColor = Nothing
                        End If
                    End If
                End If

                'Campo Ciclovia
                If lkpCicloviaE2.EditValue Is Nothing OrElse lkpCicloviaE2.EditValue.ToString = "" Then
                    completo = False
                    lkpCicloviaE2.Properties.Appearance.BorderColor = Color.Red
                Else
                    lkpCicloviaE2.Properties.Appearance.BorderColor = Nothing

                    If lkpCicloviaE2.EditValue = 2 Then
                        'Campo Motivo No Usa
                        If txtMotivoNoUsaE2.Text = "" Then
                            completo = False
                            txtMotivoNoUsaE2.Properties.Appearance.BorderColor = Color.Red
                        Else
                            txtMotivoNoUsaE2.Properties.Appearance.BorderColor = Nothing
                        End If
                    End If

                End If

                'Campo Estacionamiento Bici
                If lkpEstacionamientoBiciE2.EditValue Is Nothing OrElse lkpEstacionamientoBiciE2.EditValue.ToString = "" Then
                    completo = False
                    lkpEstacionamientoBiciE2.Properties.Appearance.BorderColor = Color.Red
                Else
                    lkpEstacionamientoBiciE2.Properties.Appearance.BorderColor = Nothing
                End If

                'Campo Lugar Bajada
                If lkpLugarBajadaBiciE2.EditValue Is Nothing OrElse lkpLugarBajadaBiciE2.EditValue.ToString = "" Then
                    completo = False
                    lkpLugarBajadaBiciE2.Properties.Appearance.BorderColor = Color.Red
                Else
                    lkpLugarBajadaBiciE2.Properties.Appearance.BorderColor = Nothing
                End If
        End Select

        If modo < 13 Then
            'Campo Comuna Etapa2
            If lkpComunaEtapa2.EditValue Is Nothing OrElse lkpComunaEtapa2.EditValue.ToString = "" OrElse lkpComunaEtapa2.EditValue < 1 Then
                completo = False
                lkpComunaEtapa2.Properties.Appearance.BorderColor = Color.Red
            Else
                lkpComunaEtapa2.Properties.Appearance.BorderColor = Nothing

                If lkpComunaEtapa2.EditValue = 1 Then
                    'Campo Otra Comuna Etapa2
                    If txtComunaOtraEtapa2.Text = "" Then
                        completo = False
                        txtComunaOtraEtapa2.Properties.Appearance.BorderColor = Color.Red
                    Else
                        txtComunaOtraEtapa2.Properties.Appearance.BorderColor = Nothing
                    End If
                ElseIf lkpComunaEtapa2.EditValue = 2 Then
                    'Dirección Etapa2

                    'Campo Hito Etapa2
                    If lkpHitoEtapa2.EditValue Is Nothing OrElse lkpHitoEtapa2.EditValue.ToString = "" Then

                        'Campo Calle 1 Etapa2
                        If lkpCalle1Etapa2.EditValue Is Nothing OrElse lkpCalle1Etapa2.EditValue.ToString = "" Then
                            completo = False
                            lkpCalle1Etapa2.Properties.Appearance.BorderColor = Color.Red
                            lkpHitoEtapa2.Properties.Appearance.BorderColor = Color.Red
                        Else
                            'Campo Calle 2 Etapa2
                            If lkpCalle2Etapa2.EditValue Is Nothing OrElse lkpCalle2Etapa2.EditValue.ToString = "" Then
                                completo = False
                                lkpCalle2Etapa2.Properties.Appearance.BorderColor = Color.Red
                                lkpHitoEtapa2.Properties.Appearance.BorderColor = Color.Red
                            Else
                                lkpCalle1Etapa2.Properties.Appearance.BorderColor = Nothing
                                lkpCalle2Etapa2.Properties.Appearance.BorderColor = Nothing
                                lkpHitoEtapa2.Properties.Appearance.BorderColor = Nothing
                            End If
                        End If
                    Else
                        lkpHitoEtapa2.Properties.Appearance.BorderColor = Nothing
                    End If

                    'Campo Manzana Etapa2
                    If lkpManzanaEtapa2.EditValue Is Nothing OrElse lkpManzanaEtapa2.EditValue.ToString = "" Then
                        completo = False
                        lkpManzanaEtapa2.Properties.Appearance.BorderColor = Color.Red
                    Else
                        lkpManzanaEtapa2.Properties.Appearance.BorderColor = Nothing
                    End If

                End If
            End If
        End If



        If completo = False Then
            tabTransporte2.Appearance.Header.ForeColor = Color.Red
        Else
            tabTransporte2.Appearance.Header.ForeColor = Color.Black
        End If

        Return completo
    End Function

    Private Function etapa3Completa(ByVal modo As Integer) As Boolean
        Dim completo As Boolean = True

        Select Case modo
            Case 1, 5, 9
                'Campo Minutos Antes
                If txtMinutosAutoE3.Text = "" Then
                    completo = False
                    txtMinutosAutoE3.Properties.Appearance.BorderColor = Color.Red
                Else
                    txtMinutosAutoE3.Properties.Appearance.BorderColor = Nothing
                End If

                'Campo Cuadras Antes
                If txtCuadrasAutoE3.Text = "" Then
                    completo = False
                    txtCuadrasAutoE3.Properties.Appearance.BorderColor = Color.Red
                Else
                    txtCuadrasAutoE3.Properties.Appearance.BorderColor = Nothing
                End If

                'Campo Viaja Como
                If lkpViajaComoE3.EditValue Is Nothing OrElse lkpViajaComoE3.EditValue.ToString = "" Then
                    completo = False
                    lkpViajaComoE3.Properties.Appearance.BorderColor = Color.Red
                Else
                    lkpViajaComoE3.Properties.Appearance.BorderColor = Nothing

                    If lkpViajaComoE3.EditValue = 1 Then
                        'Campo Donde Estaciona
                        If lkpDondeEstacionaE3.EditValue Is Nothing OrElse lkpDondeEstacionaE3.EditValue.ToString = "" Then
                            completo = False
                            lkpDondeEstacionaE3.Properties.Appearance.BorderColor = Color.Red
                        Else
                            lkpDondeEstacionaE3.Properties.Appearance.BorderColor = Nothing
                        End If

                        'Campo Minutos Espera Estacionamiento
                        If txtMinutosEstacionaAutoE3.Text = "" Then
                            completo = False
                            txtMinutosEstacionaAutoE3.Properties.Appearance.BorderColor = Color.Red
                        Else
                            txtMinutosEstacionaAutoE3.Properties.Appearance.BorderColor = Nothing
                        End If

                        'Campo Forma Pago
                        If lkpFormaPagoE3.EditValue Is Nothing OrElse lkpFormaPagoE3.EditValue.ToString = "" Then
                            completo = False
                            lkpFormaPagoE3.Properties.Appearance.BorderColor = Color.Red

                            If (lkpFormaPagoE3.EditValue > 0 AndAlso lkpFormaPagoE3.EditValue < 8) Then
                                'Campo Cuánto Paga
                                If txtCuantoPagoE3.Text = "" Then
                                    completo = False
                                    txtCuantoPagoE3.Properties.Appearance.BorderColor = Color.Red
                                Else
                                    txtCuantoPagoE3.Properties.Appearance.BorderColor = Nothing
                                End If
                            End If
                        Else
                            lkpFormaPagoE3.Properties.Appearance.BorderColor = Nothing
                        End If
                    End If
                End If

                'Campo Qué Vehículo
                If lkpQueVehiculoE3.EditValue Is Nothing OrElse lkpQueVehiculoE3.EditValue.ToString = "" Then
                    completo = False
                    lkpQueVehiculoE3.Properties.Appearance.BorderColor = Color.Red
                Else
                    lkpQueVehiculoE3.Properties.Appearance.BorderColor = Nothing

                    If lkpQueVehiculoE3.EditValue = 1 Then
                        'Campo Vehículo del hogar
                        If lkpVehHogarE3.EditValue Is Nothing OrElse lkpVehHogarE3.EditValue.ToString = "" Then
                            completo = False
                            lkpVehHogarE3.Properties.Appearance.BorderColor = Color.Red
                        Else
                            lkpVehHogarE3.Properties.Appearance.BorderColor = Nothing
                        End If
                    End If
                End If

            Case 2, 10, 11, 12
                'Campo Minutos Antes
                If txtMinutosBusE3.Text = "" Then
                    completo = False
                    txtMinutosBusE3.Properties.Appearance.BorderColor = Color.Red
                Else
                    txtMinutosBusE3.Properties.Appearance.BorderColor = Nothing
                End If

                'Campo Cuadras Antes
                If txtCuadrasBusE3.Text = "" Then
                    completo = False
                    txtCuadrasBusE3.Properties.Appearance.BorderColor = Color.Red
                Else
                    txtCuadrasBusE3.Properties.Appearance.BorderColor = Nothing
                End If

                'Campo Minutos Espera
                If txtMinutosEsperaBusE3.Text = "" Then
                    completo = False
                    txtMinutosEsperaBusE3.Properties.Appearance.BorderColor = Color.Red
                Else
                    txtMinutosEsperaBusE3.Properties.Appearance.BorderColor = Nothing
                End If

                'Campo Tipo Tarifa
                If lkpTipoTarifaBusE3.EditValue Is Nothing OrElse lkpTipoTarifaBusE3.EditValue.ToString = "" Then
                    completo = False
                    lkpTipoTarifaBusE3.Properties.Appearance.BorderColor = Color.Red
                Else
                    lkpTipoTarifaBusE3.Properties.Appearance.BorderColor = Nothing

                    If lkpTipoTarifaBusE3.EditValue > 0 AndAlso lkpTipoTarifaBusE3.EditValue < 4 Then
                        'Campo Monto Tarifa
                        If txtTarifaMontoBusE3.Text = "" Then
                            completo = False
                            txtTarifaMontoBusE3.Properties.Appearance.BorderColor = Color.Red
                        Else
                            txtTarifaMontoBusE3.Properties.Appearance.BorderColor = Nothing
                        End If
                    End If
                End If

                'Campo Lugar Bajada
                If lkpLugarBajadaBusE3.EditValue Is Nothing OrElse lkpLugarBajadaBusE3.EditValue.ToString = "" Then
                    completo = False
                    lkpLugarBajadaBusE3.Properties.Appearance.BorderColor = Color.Red
                Else
                    lkpLugarBajadaBusE3.Properties.Appearance.BorderColor = Nothing
                End If

            Case 3, 4
                'Campo Minutos Antes
                If txtMinutosTXCE3.Text = "" Then
                    completo = False
                    txtMinutosTXCE3.Properties.Appearance.BorderColor = Color.Red
                Else
                    txtMinutosTXCE3.Properties.Appearance.BorderColor = Nothing
                End If

                'Campo Cuadras Antes
                If txtCuadrasTXCE3.Text = "" Then
                    completo = False
                    txtCuadrasTXCE3.Properties.Appearance.BorderColor = Color.Red
                Else
                    txtCuadrasTXCE3.Properties.Appearance.BorderColor = Nothing
                End If

                'Campo Minutos Espera
                If txtMinutosEsperaTXCE3.Text = "" Then
                    completo = False
                    txtMinutosEsperaTXCE3.Properties.Appearance.BorderColor = Color.Red
                Else
                    txtMinutosEsperaTXCE3.Properties.Appearance.BorderColor = Nothing
                End If

                'Campo Monto Tarifa
                If txtTarifaMontoTXCE3.Text = "" Then
                    completo = False
                    txtTarifaMontoTXCE3.Properties.Appearance.BorderColor = Color.Red
                Else
                    txtTarifaMontoTXCE3.Properties.Appearance.BorderColor = Nothing
                End If

                'Campo Lugar Bajada
                If lkpLugarBajadaTXCE3.EditValue Is Nothing OrElse lkpLugarBajadaTXCE3.EditValue.ToString = "" Then
                    completo = False
                    lkpLugarBajadaTXCE3.Properties.Appearance.BorderColor = Color.Red
                Else
                    lkpLugarBajadaTXCE3.Properties.Appearance.BorderColor = Nothing
                End If
            Case 6
                'Campo Minutos Antes
                If txtMinutosTaxiE3.Text = "" Then
                    completo = False
                    txtMinutosTaxiE3.Properties.Appearance.BorderColor = Color.Red
                Else
                    txtMinutosTaxiE3.Properties.Appearance.BorderColor = Nothing
                End If

                'Campo Cuadras Antes
                If txtCuadrasTaxiE3.Text = "" Then
                    completo = False
                    txtCuadrasTaxiE3.Properties.Appearance.BorderColor = Color.Red
                Else
                    txtCuadrasTaxiE3.Properties.Appearance.BorderColor = Nothing
                End If

                'Campo Minutos Espera
                If txtMinutosEsperaTaxiE3.Text = "" Then
                    completo = False
                    txtMinutosEsperaTaxiE3.Properties.Appearance.BorderColor = Color.Red
                Else
                    txtMinutosEsperaTaxiE3.Properties.Appearance.BorderColor = Nothing
                End If

                'Campo Monto Tarifa
                If txtTarifaMontoTaxiE3.Text = "" Then
                    completo = False
                    txtTarifaMontoTaxiE3.Properties.Appearance.BorderColor = Color.Red
                Else
                    txtTarifaMontoTaxiE3.Properties.Appearance.BorderColor = Nothing
                End If

                'Campo Lugar Bajada
                If lkpLugarBajadaTaxiE3.EditValue Is Nothing OrElse lkpLugarBajadaTaxiE3.EditValue.ToString = "" Then
                    completo = False
                    lkpLugarBajadaTaxiE3.Properties.Appearance.BorderColor = Color.Red
                Else
                    lkpLugarBajadaTaxiE3.Properties.Appearance.BorderColor = Nothing
                End If

            Case 8
                'Campo Propiedad Bicicleta
                If lkpPropiedadBicicletaE3.EditValue Is Nothing OrElse lkpPropiedadBicicletaE3.EditValue.ToString = "" Then
                    completo = False
                    lkpPropiedadBicicletaE3.Properties.Appearance.BorderColor = Color.Red
                Else
                    lkpPropiedadBicicletaE3.Properties.Appearance.BorderColor = Nothing

                    If lkpPropiedadBicicletaE3.EditValue = 2 Then
                        'Campo Propiedad Otra
                        If txtPropiedadBicicletaOtraE3.Text = "" Then
                            completo = False
                            txtPropiedadBicicletaOtraE3.Properties.Appearance.BorderColor = Color.Red
                        Else
                            txtPropiedadBicicletaOtraE3.Properties.Appearance.BorderColor = Nothing
                        End If
                    End If
                End If

                'Campo Ciclovia
                If lkpCicloviaE3.EditValue Is Nothing OrElse lkpCicloviaE3.EditValue.ToString = "" Then
                    completo = False
                    lkpCicloviaE3.Properties.Appearance.BorderColor = Color.Red
                Else
                    lkpCicloviaE3.Properties.Appearance.BorderColor = Nothing

                    If lkpCicloviaE3.EditValue = 2 Then
                        'Campo Motivo No Usa
                        If txtMotivoNoUsaE3.Text = "" Then
                            completo = False
                            txtMotivoNoUsaE3.Properties.Appearance.BorderColor = Color.Red
                        Else
                            txtMotivoNoUsaE3.Properties.Appearance.BorderColor = Nothing
                        End If
                    End If

                End If

                'Campo Estacionamiento Bici
                If lkpEstacionamientoBiciE3.EditValue Is Nothing OrElse lkpEstacionamientoBiciE3.EditValue.ToString = "" Then
                    completo = False
                    lkpEstacionamientoBiciE3.Properties.Appearance.BorderColor = Color.Red
                Else
                    lkpEstacionamientoBiciE3.Properties.Appearance.BorderColor = Nothing
                End If

                'Campo Lugar Bajada
                If lkpLugarBajadaBiciE3.EditValue Is Nothing OrElse lkpLugarBajadaBiciE3.EditValue.ToString = "" Then
                    completo = False
                    lkpLugarBajadaBiciE3.Properties.Appearance.BorderColor = Color.Red
                Else
                    lkpLugarBajadaBiciE3.Properties.Appearance.BorderColor = Nothing
                End If

        End Select

        If modo < 13 Then
            'Campo Comuna Etapa3
            If lkpComunaEtapa3.EditValue Is Nothing OrElse lkpComunaEtapa3.EditValue.ToString = "" OrElse lkpComunaEtapa3.EditValue < 1 Then
                completo = False
                lkpComunaEtapa3.Properties.Appearance.BorderColor = Color.Red
            Else
                lkpComunaEtapa3.Properties.Appearance.BorderColor = Nothing

                If lkpComunaEtapa3.EditValue = 1 Then
                    'Campo Otra Comuna Etapa3
                    If txtComunaOtraEtapa3.Text = "" Then
                        completo = False
                        txtComunaOtraEtapa3.Properties.Appearance.BorderColor = Color.Red
                    Else
                        txtComunaOtraEtapa3.Properties.Appearance.BorderColor = Nothing
                    End If
                ElseIf lkpComunaEtapa3.EditValue = 2 Then
                    'Dirección Etapa3

                    'Campo Hito Etapa3
                    If lkpHitoEtapa3.EditValue Is Nothing OrElse lkpHitoEtapa3.EditValue.ToString = "" Then

                        'Campo Calle 1 Etapa3
                        If lkpCalle1Etapa3.EditValue Is Nothing OrElse lkpCalle1Etapa3.EditValue.ToString = "" Then
                            completo = False
                            lkpCalle1Etapa3.Properties.Appearance.BorderColor = Color.Red
                            lkpHitoEtapa3.Properties.Appearance.BorderColor = Color.Red
                        Else
                            'Campo Calle 2 Etapa3
                            If lkpCalle2Etapa3.EditValue Is Nothing OrElse lkpCalle2Etapa3.EditValue.ToString = "" Then
                                completo = False
                                lkpCalle2Etapa3.Properties.Appearance.BorderColor = Color.Red
                                lkpHitoEtapa3.Properties.Appearance.BorderColor = Color.Red
                            Else
                                lkpCalle1Etapa3.Properties.Appearance.BorderColor = Nothing
                                lkpCalle2Etapa3.Properties.Appearance.BorderColor = Nothing
                                lkpHitoEtapa3.Properties.Appearance.BorderColor = Nothing
                            End If
                        End If
                    Else
                        lkpHitoEtapa3.Properties.Appearance.BorderColor = Nothing
                    End If

                    'Campo Manzana Etapa3
                    If lkpManzanaEtapa3.EditValue Is Nothing OrElse lkpManzanaEtapa3.EditValue.ToString = "" Then
                        completo = False
                        lkpManzanaEtapa3.Properties.Appearance.BorderColor = Color.Red
                    Else
                        lkpManzanaEtapa3.Properties.Appearance.BorderColor = Nothing
                    End If

                End If
            End If
        End If



        If completo = False Then
            tabTransporte3.Appearance.Header.ForeColor = Color.Red
        Else
            tabTransporte3.Appearance.Header.ForeColor = Color.Black
        End If

        Return completo
    End Function

    Private Sub lkpLugarBajadaTXCE1_Enter(sender As Object, e As EventArgs) Handles lkpLugarBajadaTXCE1.Enter
        BeginInvoke(New MethodInvoker(Sub() CType(sender, GridLookUpEdit).ShowPopup()))
    End Sub

    Private Sub lkpLugarBajadaBiciE2_EditValueChanged(sender As Object, e As EventArgs) Handles lkpLugarBajadaBiciE2.EditValueChanged
        Dim opcion As Integer

        If lkpLugarBajadaBiciE2.EditValue IsNot Nothing AndAlso Me.lkpLugarBajadaBiciE2.EditValue.ToString <> "" Then
            opcion = Me.lkpLugarBajadaBiciE2.EditValue
        End If

        'Desbloquear caminata posterior
        Me.txtCuadrasDespues.Enabled = True
        Me.txtMinutosDespues.Enabled = True

        Select Case opcion
            Case 1
                mismaManzanaDestino = True
                'Bloquear caminata posterior
                Me.txtCuadrasDespues.Text = "0"
                Me.txtCuadrasDespues.Enabled = False
                Me.txtMinutosDespues.Text = "0"
                Me.txtMinutosDespues.Enabled = False
                Me.lkpComunaEtapa2.EditValue = Me.lkpComunaDestino.EditValue
                Me.txtComunaOtraEtapa2.Text = Me.txtComunaDestinoOtra.Text
                Me.lkpCalle1Etapa2.EditValue = Me.lkpCalle1Destino.EditValue
                Me.lkpCalle2Etapa2.EditValue = Me.lkpCalle2Destino.EditValue
                Dim args As DevExpress.XtraEditors.Controls.CloseUpEventArgs = New DevExpress.XtraEditors.Controls.CloseUpEventArgs(Nothing)
                args.AcceptValue = True
                args.Value = Me.lkpCalle2Destino.EditValue
                Me.lkpCalle2Etapa2_CloseUp(lkpCalle2Etapa2, args)
                Me.lkpHitoEtapa2.EditValue = Me.lkpHitoDestino.EditValue
                Me.lkpManzanaEtapa2.ItemIndex = Me.lkpManzanaDestino.ItemIndex
                Me.tmHoraLlegada.Focus()
            Case 2
                Me.lkpComunaEtapa2.EditValue = ""
                Me.txtComunaOtraEtapa2.Text = ""
                Me.lkpCalle1Etapa2.EditValue = ""
                Me.lkpCalle2Etapa2.EditValue = ""
                Me.lkpHitoEtapa2.EditValue = ""
                Me.txtCuadrasDespues.Enabled = True
                Me.txtMinutosDespues.Enabled = True
                Me.lkpManzanaEtapa2.Properties.DataSource = Nothing
        End Select
    End Sub

    Private Sub lkpLugarBajadaBiciE1_EditValueChanged(sender As Object, e As EventArgs) Handles lkpLugarBajadaBiciE1.EditValueChanged
        Dim opcion As Integer

        If lkpLugarBajadaBiciE1.EditValue IsNot Nothing AndAlso Me.lkpLugarBajadaBiciE1.EditValue.ToString <> "" Then
            opcion = Me.lkpLugarBajadaBiciE1.EditValue
        End If

        'Desbloquear caminata posterior
        Me.txtCuadrasDespues.Enabled = True
        Me.txtMinutosDespues.Enabled = True

        Select Case opcion
            Case 1
                mismaManzanaDestino = True
                'Bloquear caminata posterior
                Me.txtCuadrasDespues.Text = "0"
                Me.txtCuadrasDespues.Enabled = False
                Me.txtMinutosDespues.Text = "0"
                Me.txtMinutosDespues.Enabled = False
                Me.gcLugarBajadaEtapa1.Visible = True
                Me.lkpComunaEtapa1.EditValue = Me.lkpComunaDestino.EditValue
                Me.txtComunaOtraEtapa1.Text = Me.txtComunaDestinoOtra.Text
                Me.lkpCalle1Etapa1.EditValue = Me.lkpCalle1Destino.EditValue
                Me.lkpCalle2Etapa1.EditValue = Me.lkpCalle2Destino.EditValue
                Dim args As DevExpress.XtraEditors.Controls.CloseUpEventArgs = New DevExpress.XtraEditors.Controls.CloseUpEventArgs(Nothing)
                args.AcceptValue = True
                args.Value = Me.lkpCalle2Destino.EditValue
                Me.lkpCalle2Etapa1_CloseUp(lkpCalle2Etapa1, args)
                Me.lkpHitoEtapa1.EditValue = Me.lkpHitoDestino.EditValue
                Me.lkpManzanaEtapa1.ItemIndex = Me.lkpManzanaDestino.ItemIndex
                Me.tmHoraLlegada.Focus()
            Case 2
                Me.gcLugarBajadaEtapa1.Visible = True
                Me.lkpComunaEtapa1.EditValue = ""
                Me.txtComunaOtraEtapa1.Text = ""
                Me.lkpCalle1Etapa1.EditValue = ""
                Me.lkpCalle2Etapa1.EditValue = ""
                Me.lkpHitoEtapa1.EditValue = ""
                Me.txtCuadrasDespues.Enabled = True
                Me.txtMinutosDespues.Enabled = True
                Me.lkpManzanaEtapa1.Properties.DataSource = Nothing
        End Select
    End Sub

    Private Sub lkpLugarBajadaBusE2_EditValueChanged(sender As Object, e As EventArgs) Handles lkpLugarBajadaBusE2.EditValueChanged
        Dim opcion As Integer

        If Me.lkpLugarBajadaBusE2.EditValue IsNot Nothing AndAlso Me.lkpLugarBajadaBusE2.EditValue.ToString <> "" Then
            opcion = Me.lkpLugarBajadaBusE2.EditValue
        End If

        'Desbloquear caminata posterior
        Me.txtCuadrasDespues.Enabled = True
        Me.txtMinutosDespues.Enabled = True

        Select Case opcion
            Case 1
                mismaManzanaDestino = True
                'Bloquear caminata posterior
                Me.txtCuadrasDespues.Text = "0"
                Me.txtCuadrasDespues.Enabled = False
                Me.txtMinutosDespues.Text = "0"
                Me.txtMinutosDespues.Enabled = False

                Me.gcLugarBajadaEtapa2.Visible = True
                Me.lkpComunaEtapa2.EditValue = Me.lkpComunaDestino.EditValue
                Me.txtComunaOtraEtapa2.Text = Me.txtComunaDestinoOtra.Text
                Me.lkpCalle1Etapa2.EditValue = Me.lkpCalle1Destino.EditValue
                Me.lkpCalle2Etapa2.EditValue = Me.lkpCalle2Destino.EditValue
                Dim args As DevExpress.XtraEditors.Controls.CloseUpEventArgs = New DevExpress.XtraEditors.Controls.CloseUpEventArgs(Nothing)
                args.AcceptValue = True
                args.Value = Me.lkpCalle2Destino.EditValue
                Me.lkpCalle2Etapa2_CloseUp(lkpCalle2Etapa2, args)
                Me.lkpHitoEtapa2.EditValue = Me.lkpHitoDestino.EditValue
                Me.lkpManzanaEtapa2.ItemIndex = Me.lkpManzanaDestino.ItemIndex
                Me.tmHoraLlegada.Focus()
            Case 2
                Me.gcLugarBajadaEtapa2.Visible = True
                Me.lkpComunaEtapa2.EditValue = ""
                Me.txtComunaOtraEtapa2.Text = ""
                Me.lkpCalle1Etapa2.EditValue = ""
                Me.lkpCalle2Etapa2.EditValue = ""
                Me.lkpHitoEtapa2.EditValue = ""
                Me.txtCuadrasDespues.Enabled = True
                Me.txtMinutosDespues.Enabled = True
                Me.lkpManzanaEtapa2.Properties.DataSource = Nothing
        End Select
    End Sub

    Private Sub lkpLugarBajadaTaxiE2_EditValueChanged(sender As Object, e As EventArgs) Handles lkpLugarBajadaTaxiE2.EditValueChanged
        Dim opcion As Integer

        If lkpLugarBajadaTaxiE2.EditValue IsNot Nothing AndAlso Me.lkpLugarBajadaTaxiE2.EditValue.ToString <> "" Then
            opcion = Me.lkpLugarBajadaTaxiE2.EditValue
        End If

        'Desbloquear caminata posterior
        Me.txtCuadrasDespues.Enabled = True
        Me.txtMinutosDespues.Enabled = True

        Select Case opcion
            Case 1
                mismaManzanaDestino = True
                'Bloquear caminata posterior
                Me.txtCuadrasDespues.Text = "0"
                Me.txtCuadrasDespues.Enabled = False
                Me.txtMinutosDespues.Text = "0"
                Me.txtMinutosDespues.Enabled = False

                Me.gcLugarBajadaEtapa2.Visible = True
                Me.lkpComunaEtapa2.EditValue = Me.lkpComunaDestino.EditValue
                Me.txtComunaOtraEtapa2.Text = Me.txtComunaDestinoOtra.Text
                Me.lkpCalle1Etapa2.EditValue = Me.lkpCalle1Destino.EditValue
                Me.lkpCalle2Etapa2.EditValue = Me.lkpCalle2Destino.EditValue
                Dim args As DevExpress.XtraEditors.Controls.CloseUpEventArgs = New DevExpress.XtraEditors.Controls.CloseUpEventArgs(Nothing)
                args.AcceptValue = True
                args.Value = Me.lkpCalle2Destino.EditValue
                Me.lkpCalle2Etapa2_CloseUp(lkpCalle2Etapa2, args)
                Me.lkpHitoEtapa2.EditValue = Me.lkpHitoDestino.EditValue
                Me.lkpManzanaEtapa2.ItemIndex = Me.lkpManzanaDestino.ItemIndex
                Me.tmHoraLlegada.Focus()
            Case 2
                Me.gcLugarBajadaEtapa2.Visible = True
                Me.lkpComunaEtapa2.EditValue = ""
                Me.txtComunaOtraEtapa2.Text = ""
                Me.lkpCalle1Etapa2.EditValue = ""
                Me.lkpCalle2Etapa2.EditValue = ""
                Me.lkpHitoEtapa2.EditValue = ""
                Me.txtCuadrasDespues.Enabled = True
                Me.txtMinutosDespues.Enabled = True
                Me.lkpManzanaEtapa2.Properties.DataSource = Nothing
        End Select
    End Sub

    Private Sub lkpLugarBajadaTXCE2_EditValueChanged(sender As Object, e As EventArgs) Handles lkpLugarBajadaTXCE2.EditValueChanged
        Dim opcion As Integer

        If lkpLugarBajadaTXCE2.EditValue IsNot Nothing AndAlso Me.lkpLugarBajadaTXCE2.EditValue.ToString <> "" Then
            opcion = Me.lkpLugarBajadaTXCE2.EditValue
        End If

        'Desbloquear caminata posterior
        Me.txtCuadrasDespues.Enabled = True
        Me.txtMinutosDespues.Enabled = True

        Select Case opcion
            Case 1
                mismaManzanaDestino = True
                'Bloquear caminata posterior
                Me.txtCuadrasDespues.Text = "0"
                Me.txtCuadrasDespues.Enabled = False
                Me.txtMinutosDespues.Text = "0"
                Me.txtMinutosDespues.Enabled = False
                Me.lkpComunaEtapa2.EditValue = Me.lkpComunaDestino.EditValue
                Me.txtComunaOtraEtapa2.Text = Me.txtComunaDestinoOtra.Text
                Me.lkpCalle1Etapa2.EditValue = Me.lkpCalle1Destino.EditValue
                Me.lkpCalle2Etapa2.EditValue = Me.lkpCalle2Destino.EditValue
                Dim args As DevExpress.XtraEditors.Controls.CloseUpEventArgs = New DevExpress.XtraEditors.Controls.CloseUpEventArgs(Nothing)
                args.AcceptValue = True
                args.Value = Me.lkpCalle2Destino.EditValue
                Me.lkpCalle2Etapa2_CloseUp(lkpCalle2Etapa2, args)
                Me.lkpHitoEtapa2.EditValue = Me.lkpHitoDestino.EditValue
                Me.lkpManzanaEtapa2.ItemIndex = Me.lkpManzanaDestino.ItemIndex
                Me.tmHoraLlegada.Focus()
            Case 2
                Me.lkpComunaEtapa2.EditValue = ""
                Me.txtComunaOtraEtapa2.Text = ""
                Me.lkpCalle1Etapa2.EditValue = ""
                Me.lkpCalle2Etapa2.EditValue = ""
                Me.lkpHitoEtapa2.EditValue = ""
                Me.txtCuadrasDespues.Enabled = True
                Me.txtMinutosDespues.Enabled = True
                Me.lkpManzanaEtapa2.Properties.DataSource = Nothing
        End Select
    End Sub

    Private Sub lkpLugarBajadaTaxiE3_EditValueChanged(sender As Object, e As EventArgs) Handles lkpLugarBajadaTaxiE3.EditValueChanged
        Dim opcion As Integer

        If lkpLugarBajadaTaxiE3.EditValue IsNot Nothing AndAlso Me.lkpLugarBajadaTaxiE3.EditValue.ToString <> "" Then
            opcion = Me.lkpLugarBajadaTaxiE3.EditValue
        End If

        'Desbloquear caminata posterior
        Me.txtCuadrasDespues.Enabled = True
        Me.txtMinutosDespues.Enabled = True

        Select Case opcion
            Case 1
                mismaManzanaDestino = True
                'Bloquear caminata posterior
                Me.txtCuadrasDespues.Text = "0"
                Me.txtCuadrasDespues.Enabled = False
                Me.txtMinutosDespues.Text = "0"
                Me.txtMinutosDespues.Enabled = False

                Me.gcLugarBajadaEtapa3.Visible = True
                Me.lkpComunaEtapa3.EditValue = Me.lkpComunaDestino.EditValue
                Me.txtComunaOtraEtapa3.Text = Me.txtComunaDestinoOtra.Text
                Me.lkpCalle1Etapa3.EditValue = Me.lkpCalle1Destino.EditValue
                Me.lkpCalle2Etapa3.EditValue = Me.lkpCalle2Destino.EditValue
                Dim args As DevExpress.XtraEditors.Controls.CloseUpEventArgs = New DevExpress.XtraEditors.Controls.CloseUpEventArgs(Nothing)
                args.AcceptValue = True
                args.Value = Me.lkpCalle2Destino.EditValue
                Me.lkpCalle2Etapa3_CloseUp(lkpCalle2Etapa3, args)
                Me.lkpHitoEtapa3.EditValue = Me.lkpHitoDestino.EditValue
                Me.lkpManzanaEtapa3.ItemIndex = Me.lkpManzanaDestino.ItemIndex
                Me.tmHoraLlegada.Focus()
            Case 2
                Me.gcLugarBajadaEtapa3.Visible = True
                Me.lkpComunaEtapa3.EditValue = ""
                Me.txtComunaOtraEtapa3.Text = ""
                Me.lkpCalle1Etapa3.EditValue = ""
                Me.lkpCalle2Etapa3.EditValue = ""
                Me.lkpHitoEtapa3.EditValue = ""
                Me.txtCuadrasDespues.Enabled = True
                Me.txtMinutosDespues.Enabled = True
                Me.lkpManzanaEtapa3.Properties.DataSource = Nothing
        End Select
    End Sub

    Private Sub lkpLugarBajadaTXCE3_EditValueChanged(sender As Object, e As EventArgs) Handles lkpLugarBajadaTXCE3.EditValueChanged
        Dim opcion As Integer

        If lkpLugarBajadaTXCE3.EditValue IsNot Nothing AndAlso Me.lkpLugarBajadaTXCE3.EditValue.ToString <> "" Then
            opcion = Me.lkpLugarBajadaTXCE3.EditValue
        End If

        'Desbloquear caminata posterior
        Me.txtCuadrasDespues.Enabled = True
        Me.txtMinutosDespues.Enabled = True

        Select Case opcion
            Case 1
                mismaManzanaDestino = True
                'Bloquear caminata posterior
                Me.txtCuadrasDespues.Text = "0"
                Me.txtCuadrasDespues.Enabled = False
                Me.txtMinutosDespues.Text = "0"
                Me.txtMinutosDespues.Enabled = False

                Me.gcLugarBajadaEtapa3.Visible = True
                Me.lkpComunaEtapa3.EditValue = Me.lkpComunaDestino.EditValue
                Me.txtComunaOtraEtapa3.Text = Me.txtComunaDestinoOtra.Text
                Me.lkpCalle1Etapa3.EditValue = Me.lkpCalle1Destino.EditValue
                Me.lkpCalle2Etapa3.EditValue = Me.lkpCalle2Destino.EditValue
                Dim args As DevExpress.XtraEditors.Controls.CloseUpEventArgs = New DevExpress.XtraEditors.Controls.CloseUpEventArgs(Nothing)
                args.AcceptValue = True
                args.Value = Me.lkpCalle2Destino.EditValue
                Me.lkpCalle2Etapa3_CloseUp(lkpCalle2Etapa3, args)
                Me.lkpHitoEtapa3.EditValue = Me.lkpHitoDestino.EditValue
                Me.lkpManzanaEtapa3.ItemIndex = Me.lkpManzanaDestino.ItemIndex
                Me.tmHoraLlegada.Focus()
            Case 2
                Me.gcLugarBajadaEtapa3.Visible = True
                Me.lkpComunaEtapa3.EditValue = ""
                Me.txtComunaOtraEtapa3.Text = ""
                Me.lkpCalle1Etapa3.EditValue = ""
                Me.lkpCalle2Etapa3.EditValue = ""
                Me.lkpHitoEtapa3.EditValue = ""
                Me.txtCuadrasDespues.Enabled = True
                Me.txtMinutosDespues.Enabled = True
                Me.lkpManzanaEtapa3.Properties.DataSource = Nothing
        End Select
    End Sub

    Private Sub lkpLugarBajadaBiciE3_EditValueChanged(sender As Object, e As EventArgs) Handles lkpLugarBajadaBiciE3.EditValueChanged
        Dim opcion As Integer

        If lkpLugarBajadaBiciE3.EditValue IsNot Nothing AndAlso Me.lkpLugarBajadaBiciE3.EditValue.ToString <> "" Then
            opcion = Me.lkpLugarBajadaBiciE3.EditValue
        End If

        'Desbloquear caminata posterior
        Me.txtCuadrasDespues.Enabled = True
        Me.txtMinutosDespues.Enabled = True

        Select Case opcion
            Case 1
                mismaManzanaDestino = True
                'Bloquear caminata posterior
                Me.txtCuadrasDespues.Text = "0"
                Me.txtCuadrasDespues.Enabled = False
                Me.txtMinutosDespues.Text = "0"
                Me.txtMinutosDespues.Enabled = False

                Me.gcLugarBajadaEtapa3.Visible = True
                Me.lkpComunaEtapa3.EditValue = Me.lkpComunaDestino.EditValue
                Me.txtComunaOtraEtapa3.Text = Me.txtComunaDestinoOtra.Text
                Me.lkpCalle1Etapa3.EditValue = Me.lkpCalle1Destino.EditValue
                Me.lkpCalle2Etapa3.EditValue = Me.lkpCalle2Destino.EditValue
                Dim args As DevExpress.XtraEditors.Controls.CloseUpEventArgs = New DevExpress.XtraEditors.Controls.CloseUpEventArgs(Nothing)
                args.AcceptValue = True
                args.Value = Me.lkpCalle2Destino.EditValue
                Me.lkpCalle2Etapa3_CloseUp(lkpCalle2Etapa3, args)
                Me.lkpHitoEtapa3.EditValue = Me.lkpHitoDestino.EditValue
                Me.lkpManzanaEtapa3.ItemIndex = Me.lkpManzanaDestino.ItemIndex
                Me.tmHoraLlegada.Focus()
            Case 2
                Me.gcLugarBajadaEtapa3.Visible = True
                Me.lkpComunaEtapa3.EditValue = ""
                Me.txtComunaOtraEtapa3.Text = ""
                Me.lkpCalle1Etapa3.EditValue = ""
                Me.lkpCalle2Etapa3.EditValue = ""
                Me.lkpHitoEtapa3.EditValue = ""
                Me.txtCuadrasDespues.Enabled = True
                Me.txtMinutosDespues.Enabled = True
                Me.lkpManzanaEtapa3.Properties.DataSource = Nothing
        End Select
    End Sub

    Private Sub lkpLugarBajadaBusE3_EditValueChanged(sender As Object, e As EventArgs) Handles lkpLugarBajadaBusE3.EditValueChanged
        Dim opcion As Integer

        If lkpLugarBajadaBusE3.EditValue IsNot Nothing AndAlso Me.lkpLugarBajadaBusE3.EditValue.ToString <> "" Then
            opcion = Me.lkpLugarBajadaBusE3.EditValue
        End If

        'Desbloquear caminata posterior
        Me.txtCuadrasDespues.Enabled = True
        Me.txtMinutosDespues.Enabled = True

        Select Case opcion
            Case 1
                mismaManzanaDestino = True
                'Bloquear caminata posterior
                Me.txtCuadrasDespues.Text = "0"
                Me.txtCuadrasDespues.Enabled = False
                Me.txtMinutosDespues.Text = "0"
                Me.txtMinutosDespues.Enabled = False

                Me.gcLugarBajadaEtapa3.Visible = True
                Me.lkpComunaEtapa3.EditValue = Me.lkpComunaDestino.EditValue
                Me.txtComunaOtraEtapa3.Text = Me.txtComunaDestinoOtra.Text
                Me.lkpCalle1Etapa3.EditValue = Me.lkpCalle1Destino.EditValue
                Me.lkpCalle2Etapa3.EditValue = Me.lkpCalle2Destino.EditValue
                Dim args As DevExpress.XtraEditors.Controls.CloseUpEventArgs = New DevExpress.XtraEditors.Controls.CloseUpEventArgs(Nothing)
                args.AcceptValue = True
                args.Value = Me.lkpCalle2Destino.EditValue
                Me.lkpCalle2Etapa3_CloseUp(lkpCalle2Etapa3, args)
                Me.lkpHitoEtapa3.EditValue = Me.lkpHitoDestino.EditValue
                Me.lkpManzanaEtapa3.ItemIndex = Me.lkpManzanaDestino.ItemIndex
                Me.tmHoraLlegada.Focus()
            Case 2
                Me.gcLugarBajadaEtapa3.Visible = True
                Me.lkpComunaEtapa3.EditValue = ""
                Me.txtComunaOtraEtapa3.Text = Me.txtComunaDestinoOtra.Text
                Me.lkpCalle1Etapa3.EditValue = ""
                Me.lkpCalle2Etapa3.EditValue = ""
                Me.lkpHitoEtapa3.EditValue = ""
                Me.txtCuadrasDespues.Enabled = True
                Me.txtMinutosDespues.Enabled = True
                Me.lkpManzanaEtapa2.Properties.DataSource = Nothing
        End Select
    End Sub

    Private Sub lkpLugarBajadaTaxiE2_Enter(sender As Object, e As EventArgs) Handles lkpLugarBajadaTaxiE2.Enter
        BeginInvoke(New MethodInvoker(Sub() CType(sender, GridLookUpEdit).ShowPopup()))
    End Sub

    Private Sub lkpLugarBajadaBusE2_Enter(sender As Object, e As EventArgs) Handles lkpLugarBajadaBusE2.Enter
        BeginInvoke(New MethodInvoker(Sub() CType(sender, GridLookUpEdit).ShowPopup()))
    End Sub

    Private Sub lkpLugarBajadaBiciE2_Enter(sender As Object, e As EventArgs) Handles lkpLugarBajadaBiciE2.Enter
        BeginInvoke(New MethodInvoker(Sub() CType(sender, GridLookUpEdit).ShowPopup()))
    End Sub

    Private Sub lkpLugarDondeBajoE3_Enter(sender As Object, e As EventArgs) Handles lkpLugarBajadaAutoE3.Enter
        BeginInvoke(New MethodInvoker(Sub() CType(sender, GridLookUpEdit).ShowPopup()))
    End Sub

    Private Sub lkpViajaComoE3_Enter(sender As Object, e As EventArgs) Handles lkpViajaComoE3.Enter
        BeginInvoke(New MethodInvoker(Sub() CType(sender, GridLookUpEdit).ShowPopup()))
    End Sub

    Private Sub lkpQueVehiculoE3_Enter(sender As Object, e As EventArgs) Handles lkpQueVehiculoE3.Enter
        BeginInvoke(New MethodInvoker(Sub() CType(sender, GridLookUpEdit).ShowPopup()))
    End Sub

    Private Sub lkpPagaEstacionamientoE3_Enter(sender As Object, e As EventArgs)
        BeginInvoke(New MethodInvoker(Sub() CType(sender, GridLookUpEdit).ShowPopup()))
    End Sub

    Private Sub lkpFormaPagoE3_Enter(sender As Object, e As EventArgs)
        BeginInvoke(New MethodInvoker(Sub() CType(sender, GridLookUpEdit).ShowPopup()))
    End Sub

    Private Sub lkpLugarBajadaBiciE3_Enter(sender As Object, e As EventArgs) Handles lkpLugarBajadaBiciE3.Enter
        BeginInvoke(New MethodInvoker(Sub() CType(sender, GridLookUpEdit).ShowPopup()))
    End Sub

    Private Sub lkpPropiedadBicicletaE3_Enter(sender As Object, e As EventArgs) Handles lkpPropiedadBicicletaE3.Enter
        BeginInvoke(New MethodInvoker(Sub() CType(sender, GridLookUpEdit).ShowPopup()))
    End Sub

    Private Sub lkpTipoTarifaBusE3_Enter(sender As Object, e As EventArgs) Handles lkpTipoTarifaBusE3.Enter
        BeginInvoke(New MethodInvoker(Sub() CType(sender, GridLookUpEdit).ShowPopup()))
    End Sub

    Private Sub lkpLugarBajadaBusE3_Enter(sender As Object, e As EventArgs) Handles lkpLugarBajadaBusE3.Enter
        BeginInvoke(New MethodInvoker(Sub() CType(sender, GridLookUpEdit).ShowPopup()))
    End Sub

    Private Sub lkpLugarBajadaTaxiE3_Enter(sender As Object, e As EventArgs) Handles lkpLugarBajadaTaxiE3.Enter
        BeginInvoke(New MethodInvoker(Sub() CType(sender, GridLookUpEdit).ShowPopup()))
    End Sub

    Private Sub lkpLugarBajadaTXCE3_Enter(sender As Object, e As EventArgs) Handles lkpLugarBajadaTXCE3.Enter
        BeginInvoke(New MethodInvoker(Sub() CType(sender, GridLookUpEdit).ShowPopup()))
    End Sub

    Private Sub lkpLugarBajadaBiciE1_Enter(sender As Object, e As EventArgs) Handles lkpLugarBajadaBiciE1.Enter
        BeginInvoke(New MethodInvoker(Sub() CType(sender, GridLookUpEdit).ShowPopup()))
    End Sub

    Private Sub lkpViajaComoE2_Enter(sender As Object, e As EventArgs) Handles lkpViajaComoE2.Enter
        BeginInvoke(New MethodInvoker(Sub() CType(sender, GridLookUpEdit).ShowPopup()))
    End Sub

    Private Sub lkpQueVehiculoE2_Enter(sender As Object, e As EventArgs) Handles lkpQueVehiculoE2.Enter
        BeginInvoke(New MethodInvoker(Sub() CType(sender, GridLookUpEdit).ShowPopup()))
    End Sub

    Private Sub lkpPagaEstacionamientoE2_Enter(sender As Object, e As EventArgs)
        BeginInvoke(New MethodInvoker(Sub() CType(sender, GridLookUpEdit).ShowPopup()))
    End Sub

    Private Sub lkpFormaPagoE2_Enter(sender As Object, e As EventArgs) Handles lkpFormaPagoE2.Enter
        BeginInvoke(New MethodInvoker(Sub() CType(sender, GridLookUpEdit).ShowPopup()))
    End Sub

    Private Sub lkpLugarDondeBajoE2_Enter(sender As Object, e As EventArgs) Handles lkpLugarBajadaAutoE2.Enter
        BeginInvoke(New MethodInvoker(Sub() CType(sender, GridLookUpEdit).ShowPopup()))
    End Sub

    Private Sub lkpQueVehiculoE2_EditValueChanged(sender As Object, e As EventArgs) Handles lkpQueVehiculoE2.EditValueChanged
        Dim opcion As Integer

        If lkpQueVehiculoE2.EditValue IsNot Nothing AndAlso Me.lkpQueVehiculoE2.EditValue.ToString <> "" Then
            opcion = Me.lkpQueVehiculoE2.EditValue
        End If

        If opcion = 1 Then
            Me.spVehiculoHogarE2.Collapsed = False
            Me.lkpVehHogarE2.Visible = True

            Me.ResumenVehiculosTableAdapter.Fill(Me.datasetEOD.ResumenVehiculos)
            Me.ResumenVehiculosBindingSource.Filter = "Hogar = " + Me.idFolio.ToString

        ElseIf opcion = 2 Then
            Me.spVehiculoHogarE2.Collapsed = True
            Me.lkpVehHogarE2.Visible = False
        End If
    End Sub

    Private Sub lkpVehHogarE2_Enter(sender As Object, e As EventArgs) Handles lkpVehHogarE2.Enter
        BeginInvoke(New MethodInvoker(Sub() CType(sender, GridLookUpEdit).ShowPopup()))
    End Sub

    Private Sub lkpTipoTarifaBusE2_Enter(sender As Object, e As EventArgs) Handles lkpTipoTarifaBusE2.Enter
        BeginInvoke(New MethodInvoker(Sub() CType(sender, GridLookUpEdit).ShowPopup()))
    End Sub

    Private Sub lkpPropiedadBicicletaE2_EditValueChanged(sender As Object, e As EventArgs) Handles lkpPropiedadBicicletaE2.EditValueChanged
        Me.spcPropiedadBicicletaE2.Collapsed = True
        Me.txtPropiedadBicicletaOtraE2.Visible = False
        Me.lblPropiedadBiciOtraE2.Visible = False

        Dim opcion As Integer

        If lkpPropiedadBicicletaE2.EditValue IsNot Nothing AndAlso Me.lkpPropiedadBicicletaE2.EditValue.ToString <> "" Then
            opcion = Me.lkpPropiedadBicicletaE2.EditValue

            If opcion = 2 Then
                Me.spcPropiedadBicicletaE2.Collapsed = False
                Me.txtPropiedadBicicletaOtraE2.Visible = True
                Me.lblPropiedadBiciOtraE2.Visible = True
            End If
        End If
    End Sub

    Private Sub lkpQueVehiculoE3_EditValueChanged(sender As Object, e As EventArgs) Handles lkpQueVehiculoE3.EditValueChanged
        Dim opcion As Integer

        If lkpQueVehiculoE3.EditValue IsNot Nothing AndAlso Me.lkpQueVehiculoE3.EditValue.ToString <> "" Then
            opcion = Me.lkpQueVehiculoE3.EditValue
        End If

        If opcion = 1 Then
            Me.spVehiculoHogarE3.Collapsed = False
            Me.lkpVehHogarE3.Visible = True

            Me.ResumenVehiculosTableAdapter.Fill(datasetEOD.ResumenVehiculos)
            Me.ResumenVehiculosBindingSource.Filter = "Hogar = " + Me.idFolio.ToString

        ElseIf opcion = 2 Then
            Me.spVehiculoHogarE3.Collapsed = True
            Me.lkpVehHogarE3.Visible = False
        End If
    End Sub

    Private Sub lkpPropiedadBicicletaE3_EditValueChanged(sender As Object, e As EventArgs) Handles lkpPropiedadBicicletaE3.EditValueChanged
        Me.spcPropiedadBicicletaE3.Collapsed = True
        Me.txtPropiedadBicicletaOtraE3.Visible = False
        Me.lblPropiedadBiciOtraE3.Visible = False

        Dim opcion As Integer

        If lkpPropiedadBicicletaE3.EditValue IsNot Nothing AndAlso Me.lkpPropiedadBicicletaE3.EditValue.ToString <> "" Then
            opcion = Me.lkpPropiedadBicicletaE3.EditValue

            If opcion = 2 Then
                Me.spcPropiedadBicicletaE3.Collapsed = False
                Me.txtPropiedadBicicletaOtraE3.Visible = True
                Me.lblPropiedadBiciOtraE3.Visible = True
            End If
        End If
    End Sub

    Private Sub lkpComunaEtapa3_EditValueChanged(sender As Object, e As EventArgs) Handles lkpComunaEtapa3.EditValueChanged
        Dim comuna As Integer

        If lkpComunaEtapa3.EditValue IsNot Nothing AndAlso lkpComunaEtapa3.EditValue.ToString <> "" Then
            comuna = lkpComunaEtapa3.EditValue
        End If

        Me.spcCallesEtapa3.Visible = False
        Me.txtComunaOtraEtapa3.Enabled = False

        Select Case comuna
            Case 1
                Me.spcCallesEtapa3.Visible = True
                Me.spcCallesEtapa3.CollapsePanel = DevExpress.XtraEditors.SplitCollapsePanel.Panel2
                Me.spcCallesEtapa3.Collapsed = True
                Me.txtComunaOtraEtapa2.Enabled = True
            Case 2
                Me.spcCallesEtapa3.Visible = True
                Me.spcCallesEtapa3.CollapsePanel = DevExpress.XtraEditors.SplitCollapsePanel.Panel1
                Me.spcCallesEtapa3.Collapsed = True
        End Select
    End Sub

    Private Sub lkpCalle1Etapa3_EditValueChanged(sender As Object, e As EventArgs) Handles lkpCalle1Etapa3.EditValueChanged
        If lkpCalle1Etapa3.EditValue IsNot Nothing AndAlso Me.lkpCalle1Etapa3.EditValue.ToString <> "" Then
            Dim calleQuery As String = Me.lkpCalle1Etapa3.EditValue.ToString '.Replace("'", ControlChars.Quote)
            ConsultaCalle2Etapa3TableAdapter.FillBy(datasetEOD.ConsultaCalle2Etapa3, calleQuery)
        End If
    End Sub

    Private Sub lkpTrabajoDeclarado_Enter(sender As Object, e As EventArgs) Handles lkpTrabajoDeclarado.Enter
        BeginInvoke(New MethodInvoker(Sub() CType(sender, GridLookUpEdit).ShowPopup()))
    End Sub

    Private Sub lkpEstudioDeclarado_Enter(sender As Object, e As EventArgs) Handles lkpEstudioDeclarado.Enter
        BeginInvoke(New MethodInvoker(Sub() CType(sender, GridLookUpEdit).ShowPopup()))
    End Sub

    Private Sub lkpManzanaEtapa1_Leave(sender As Object, e As EventArgs) Handles lkpManzanaEtapa1.Leave
        If lkpTransporte2.EditValue IsNot Nothing AndAlso lkpTransporte2.EditValue.ToString <> "" AndAlso lkpTransporte2.EditValue > 0 Then
            Me.tabsEtapas.SelectedTabPage = tabsEtapas.TabPages(1)
            Select Case lkpTransporte2.EditValue
                Case 1, 5, 9
                    txtCuadrasAutoE2.Focus()
                Case 2, 10, 11, 12
                    txtCuadrasBusE2.Focus()
                Case 3, 4
                    txtCuadrasTXCE2.Focus()
                Case 6
                    txtCuadrasTaxiE2.Focus()
                Case 8
                    lkpPropiedadBicicletaE2.Focus()
            End Select
        End If
    End Sub

    Private Sub lkpManzanaEtapa2_Leave(sender As Object, e As EventArgs) Handles lkpManzanaEtapa2.Leave
        If lkpTransporte3.EditValue IsNot Nothing AndAlso lkpTransporte3.EditValue.ToString <> "" AndAlso lkpTransporte3.EditValue > 0 Then
            Me.tabsEtapas.SelectedTabPage = tabsEtapas.TabPages(2)
            Select Case lkpTransporte3.EditValue
                Case 1, 5, 9
                    txtCuadrasAutoE3.Focus()
                Case 2, 10, 11, 12
                    txtCuadrasBusE3.Focus()
                Case 3, 4
                    txtCuadrasTXCE3.Focus()
                Case 6
                    txtCuadrasTaxiE3.Focus()
                Case 8
                    lkpPropiedadBicicletaE3.Focus()
            End Select
        End If
    End Sub

    Private Sub lkpComunaEtapa2_Enter(sender As Object, e As EventArgs) Handles lkpComunaEtapa2.Enter
        BeginInvoke(New MethodInvoker(Sub() CType(sender, GridLookUpEdit).ShowPopup()))
    End Sub

    Private Sub lkpComunaEtapa3_Enter(sender As Object, e As EventArgs) Handles lkpComunaEtapa3.Enter
        BeginInvoke(New MethodInvoker(Sub() CType(sender, GridLookUpEdit).ShowPopup()))
    End Sub

    Private Sub lkpHitoEtapa3_EditValueChanged(sender As Object, e As EventArgs) Handles lkpHitoEtapa3.EditValueChanged
        If lkpHitoEtapa3.EditValue IsNot Nothing AndAlso lkpHitoEtapa3.EditValue.ToString <> "" Then
            Dim edit As GridLookUpEdit = TryCast(sender, GridLookUpEdit)
            Dim row As DataRowView = TryCast(edit.Properties.GetRowByKeyValue(edit.EditValue), DataRowView)
            If Not row Is Nothing Then
                Me.x_etapa3.Text = row.Item("x")
                Me.y_etapa3.Text = row.Item("y")
            End If


            Dim objConn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\MASCARA REFERENCIA_VF.accdb")
            objConn.Open()

            Dim objCommand As New OleDbCommand("select hitomanzana from hito where hito = ?", objConn)
            Dim parametro1 As New OleDbParameter("hito", Me.lkpHitoEtapa3.EditValue)
            objCommand.Parameters.Add(parametro1)

            Dim objAdapter As New OleDbDataAdapter(objCommand)
            Dim objDataSet As New DataSet("Manzanasetapa3")

            For i As Integer = 0 To 3
                If Not Me.lkpManzanaEtapa3.Properties.Columns.GetVisibleColumn(i) Is Nothing Then
                    Me.lkpManzanaEtapa3.Properties.Columns.Remove(Me.lkpManzanaEtapa3.Properties.Columns.GetVisibleColumn(i))
                End If
            Next

            Try
                objAdapter.Fill(objDataSet, "Manzanasetapa3")
                Dim objTabla As DataTable = objDataSet.Tables("Manzanasetapa3")
                Me.lkpManzanaEtapa3.Properties.DataSource = objTabla
                Me.lkpManzanaEtapa3.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("hitomanzana", "hitomanzana", 5, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
                Me.lkpManzanaEtapa3.Properties.DisplayMember = "hitomanzana"
                Me.lkpManzanaEtapa3.Properties.ValueMember = "hitomanzana"
                Me.lkpManzanaEtapa3.ItemIndex = 0
            Catch ex As Exception
                MessageBox.Show(ex.Message + vbCrLf + vbCrLf + ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            'borrar manzana
            For i As Integer = 0 To 3
                If Not Me.lkpManzanaEtapa3.Properties.Columns.GetVisibleColumn(i) Is Nothing Then
                    Me.lkpManzanaEtapa3.Properties.Columns.Remove(Me.lkpManzanaEtapa3.Properties.Columns.GetVisibleColumn(i))
                End If
            Next
            lkpManzanaEtapa3.Properties.DataSource = Nothing

            'si hay calle 2, lanzar evento closeup
            If lkpCalle2Etapa3.EditValue IsNot Nothing AndAlso lkpCalle2Etapa3.EditValue.ToString <> "" Then
                Dim args As DevExpress.XtraEditors.Controls.CloseUpEventArgs = New DevExpress.XtraEditors.Controls.CloseUpEventArgs(Nothing)
                args.AcceptValue = True
                args.Value = Me.lkpCalle2Etapa3.EditValue
                Me.lkpCalle2Etapa3_CloseUp(lkpCalle2Etapa3, args)
            End If
        End If
    End Sub


    Private Function tiempoViaje() As Integer
        Dim tpoViaje As Integer

        Dim horaIni As DateTime = tmHoraSalida.EditValue
        Dim horaFin As DateTime = tmHoraLlegada.EditValue

        If lkpTrasnoche.EditValue IsNot Nothing AndAlso lkpTrasnoche.EditValue.ToString <> "" Then
            Select Case lkpTrasnoche.EditValue
                Case 1
                    tpoViaje = (horaIni.Hour * 60 + horaIni.Minute) - (horaFin.Hour * 60 + horaFin.Minute)
                Case 2
                    tpoViaje = (horaFin.Hour * 60 + horaFin.Minute) - (horaIni.Hour * 60 + horaIni.Minute)
            End Select
        End If

        Return tpoViaje
    End Function

    Private Function minutosCaminadosViaje() As Integer

        Dim minutosCaminados As Integer

        If lkpTransporte1.EditValue IsNot Nothing AndAlso lkpTransporte1.EditValue.ToString <> "" Then
            Select Case lkpTransporte1.EditValue
                Case 1, 5, 9
                    minutosCaminados += txtMinutosAutoE1.Text
                Case 2, 10, 11, 12
                    minutosCaminados += txtMinutosBusE1.Text
                Case 3, 4
                    minutosCaminados += txtMinutosTXCE1.Text
                Case 6
                    minutosCaminados += txtMinutosTaxiE1.Text
            End Select
        End If

        If lkpTransporte2.EditValue IsNot Nothing AndAlso lkpTransporte2.EditValue.ToString <> "" Then
            Select Case lkpTransporte2.EditValue
                Case 1, 5, 9
                    minutosCaminados += txtMinutosAutoE2.Text
                Case 2, 10, 11, 12
                    minutosCaminados += txtMinutosBusE2.Text
                Case 3, 4
                    minutosCaminados += txtMinutosTXCE2.Text
                Case 6
                    minutosCaminados += txtMinutosTaxiE2.Text
            End Select
        End If

        If lkpTransporte3.EditValue IsNot Nothing AndAlso lkpTransporte3.EditValue.ToString <> "" Then
            Select Case lkpTransporte3.EditValue
                Case 1, 5, 9
                    minutosCaminados += txtMinutosAutoE3.Text
                Case 2, 10, 11, 12
                    minutosCaminados += txtMinutosBusE3.Text
                Case 3, 4
                    minutosCaminados += txtMinutosTXCE3.Text
                Case 6
                    minutosCaminados += txtMinutosTaxiE3.Text
            End Select
        End If
        minutosCaminados += txtMinutosDespues.Text

        Return minutosCaminados
    End Function

    Private Sub lkpCalle2Destino_CloseUp(sender As Object, e As DevExpress.XtraEditors.Controls.CloseUpEventArgs) Handles lkpCalle2Destino.CloseUp
        If e.AcceptValue Then
            Try
                Dim idInterseccion As Integer
                Dim conflictiva As Integer
                Dim codigoTrasa As Integer
                Dim coordXDestino As Double
                Dim coordYDestino As Double

                If lkpCalle2Destino.EditValue IsNot Nothing AndAlso lkpCalle2Destino.EditValue.ToString <> "" Then
                    Dim edit As GridLookUpEdit = TryCast(sender, GridLookUpEdit)
                    Dim row As DataRowView = TryCast(edit.Properties.GetRowByKeyValue(e.Value), DataRowView)
                    idInterseccion = row.Item("id")
                    conflictiva = row.Item("conflictiva")
                    codigoTrasa = row.Item("codigoTrasa")
                    coordXDestino = row.Item("x")
                    coordYDestino = row.Item("y")
                    Me.x_destino.Text = coordXDestino
                    Me.y_destino.Text = coordYDestino

                    Dim objConn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\MASCARA REFERENCIA_VF.accdb")
                    objConn.Open()

                    Dim objCommand As New OleDbCommand("MzIntersec", objConn) With {.CommandType = CommandType.StoredProcedure}
                    Dim parametro As New OleDbParameter("idInter", idInterseccion)
                    objCommand.Parameters.Add(parametro)

                    Dim objAdapter As New OleDbDataAdapter(objCommand)
                    Dim objDataSet As New DataSet("ManzanasDestino")

                    For i As Integer = 0 To 3
                        If Not Me.lkpManzanaDestino.Properties.Columns.GetVisibleColumn(i) Is Nothing Then
                            Me.lkpManzanaDestino.Properties.Columns.Remove(Me.lkpManzanaDestino.Properties.Columns.GetVisibleColumn(i))
                        End If
                    Next

                    Try
                        objAdapter.Fill(objDataSet, "ManzanasDestino")
                        Dim objTabla As DataTable = objDataSet.Tables("ManzanasDestino")
                        Me.lkpManzanaDestino.Properties.DataSource = objTabla
                        Me.lkpManzanaDestino.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("mz1", "mz1", 5, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
                        Me.lkpManzanaDestino.Properties.DisplayMember = "mz1"
                        Me.lkpManzanaDestino.Properties.ValueMember = "mz1"
                    Catch ex As Exception
                        MessageBox.Show(ex.Message + vbCrLf + vbCrLf + ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try

                    If trabajoDeclarado Then
                        Me.lkpManzanaDestino.EditValue = Integer.Parse(persona.ManzanaTrabajo)
                        trabajoDeclarado = False
                    ElseIf estudioDeclarado Then
                        Me.lkpManzanaDestino.EditValue = Integer.Parse(persona.ManzanaEstudio)
                        estudioDeclarado = False
                    Else
                        If conflictiva = 1 And Not primeraCargaDestino Then
                            MessageBox.Show("Debe escoger una manzana del siguiente mapa para identificar el destino de viaje", "Intersección conflictiva", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            Dim mapaInterseccion As New MapaInterseccion(codigoTrasa)
                            mapaInterseccion.ShowDialog()
                            lkpManzanaDestino.Focus()
                        ElseIf conflictiva = 0 Then
                            Dim aleatorioMax = objDataSet.Tables("ManzanasDestino").Rows.Count
                            Dim aleatorio As Random = New Random
                            Me.lkpManzanaDestino.ItemIndex = aleatorio.Next(0, aleatorioMax - 1)
                            lkpTransporte1.Focus()
                        End If
                        primeraCargaDestino = False
                    End If
                Else
                    'borrar manzanas 
                    lkpManzanaDestino.Properties.DataSource = ""
                    For i As Integer = 0 To 3
                        If Not Me.lkpManzanaDestino.Properties.Columns.GetVisibleColumn(i) Is Nothing Then
                            Me.lkpManzanaDestino.Properties.Columns.Remove(Me.lkpManzanaDestino.Properties.Columns.GetVisibleColumn(i))
                        End If
                    Next
                    lkpManzanaDestino.Properties.DataSource = Nothing

                    'si indicó hito, lanzar manzana de hito
                    If lkpHitoDestino.EditValue IsNot Nothing AndAlso lkpHitoDestino.EditValue.ToString <> "" Then
                        lkpHitoDestino_EditValueChanged(lkpHitoDestino, Nothing)
                    End If
                End If
            Catch ex As Exception
            End Try

        End If
    End Sub

    Private Sub lkpCalle2Origen_CloseUp(sender As Object, e As DevExpress.XtraEditors.Controls.CloseUpEventArgs) Handles lkpCalle2Origen.CloseUp
        If e.AcceptValue Then
            Dim idInterseccion As Integer
            Dim codigoTrasa As Integer
            Dim conflictiva As Integer
            Dim coordXOrigen As Double
            Dim coordYOrigen As Double

            If lkpCalle2Origen.EditValue IsNot Nothing AndAlso lkpCalle2Origen.EditValue.ToString <> "" Then
                Dim edit As GridLookUpEdit = TryCast(sender, GridLookUpEdit)
                Dim row As DataRowView = TryCast(edit.Properties.GetRowByKeyValue(e.Value), DataRowView)
                If row IsNot Nothing Then
                    idInterseccion = row.Item("id")
                    conflictiva = row.Item("conflictiva")
                    codigoTrasa = row.Item("codigoTrasa")
                    coordXOrigen = row.Item("x")
                    coordYOrigen = row.Item("y")
                    Me.x_origen.Text = coordXOrigen
                    Me.y_origen.Text = coordYOrigen

                    Dim objConn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\MASCARA REFERENCIA_VF.accdb")
                    objConn.Open()

                    Dim objCommand As New OleDbCommand("MzIntersec", objConn) With {.CommandType = CommandType.StoredProcedure}
                    Dim parametro As New OleDbParameter("idInter", idInterseccion)
                    objCommand.Parameters.Add(parametro)

                    Dim objAdapter As New OleDbDataAdapter(objCommand)
                    Dim objDataSet As New DataSet("ManzanasOrigen")

                    For i As Integer = 0 To 3
                        If Not Me.lkpManzanaOrigen.Properties.Columns.GetVisibleColumn(i) Is Nothing Then
                            Me.lkpManzanaOrigen.Properties.Columns.Remove(Me.lkpManzanaOrigen.Properties.Columns.GetVisibleColumn(i))
                        End If
                    Next

                    Try
                        objAdapter.Fill(objDataSet, "ManzanasOrigen")
                        Dim objTabla As DataTable = objDataSet.Tables("ManzanasOrigen")
                        Me.lkpManzanaOrigen.Properties.DataSource = objTabla
                        Me.lkpManzanaOrigen.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("mz1", "mz1", 5, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
                        Me.lkpManzanaOrigen.Properties.DisplayMember = "mz1"
                        Me.lkpManzanaOrigen.Properties.ValueMember = "mz1"

                    Catch ex As Exception
                        MessageBox.Show(ex.Message + vbCrLf + vbCrLf + ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try

                    If conflictiva = 1 Then
                        MessageBox.Show("Debe escoger una manzana del siguiente mapa para identificar el Origen de viaje", "Intersección conflictiva", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Dim mapaInterseccion As New MapaInterseccion(codigoTrasa)
                        mapaInterseccion.ShowDialog()
                        tmHoraSalida.Focus()
                    ElseIf conflictiva = 0 Then
                        Dim aleatorioMax = objDataSet.Tables("ManzanasOrigen").Rows.Count
                        Dim aleatorio As Random = New Random
                        Me.lkpManzanaOrigen.ItemIndex = aleatorio.Next(0, aleatorioMax - 1)
                    End If
                End If

            Else
                'borrar manzanas 
                lkpManzanaOrigen.Properties.DataSource = ""
                For i As Integer = 0 To 3
                    If Not Me.lkpManzanaOrigen.Properties.Columns.GetVisibleColumn(i) Is Nothing Then
                        Me.lkpManzanaOrigen.Properties.Columns.Remove(Me.lkpManzanaOrigen.Properties.Columns.GetVisibleColumn(i))
                    End If
                Next
                lkpManzanaOrigen.Properties.DataSource = Nothing

                'si indicó hito, lanzar manzana de hito
                If lkpHitoOrigen.EditValue IsNot Nothing AndAlso lkpHitoOrigen.EditValue.ToString <> "" Then
                    lkpHitoOrigen_EditValueChanged(lkpHitoOrigen, Nothing)
                End If
            End If
        End If
    End Sub

    Private Sub lkpCalle2Etapa1_CloseUp(sender As Object, e As DevExpress.XtraEditors.Controls.CloseUpEventArgs) Handles lkpCalle2Etapa1.CloseUp
        If e.AcceptValue Then
            Dim idInterseccion As Integer
            Dim codigoTrasa As Integer
            Dim conflictiva As Integer

            If lkpCalle2Etapa1.EditValue IsNot Nothing AndAlso lkpCalle2Etapa1.EditValue.ToString <> "" Then
                Try
                    Dim edit As GridLookUpEdit = TryCast(sender, GridLookUpEdit)
                    Dim row As DataRowView = TryCast(edit.Properties.GetRowByKeyValue(e.Value), DataRowView)
                    idInterseccion = row.Item("id")
                    conflictiva = row.Item("conflictiva")
                    codigoTrasa = row.Item("codigoTrasa")

                    Me.x_etapa1.Text = row.Item("x")
                    Me.y_etapa1.Text = row.Item("y")

                    Dim objConn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\MASCARA REFERENCIA_VF.accdb")
                    objConn.Open()

                    Dim objCommand As New OleDbCommand("MzIntersec", objConn) With {.CommandType = CommandType.StoredProcedure}
                    Dim parametro As New OleDbParameter("idInter", idInterseccion)
                    objCommand.Parameters.Add(parametro)

                    Dim objAdapter As New OleDbDataAdapter(objCommand)
                    Dim objDataSet As New DataSet("ManzanaAutoE1")

                    For i As Integer = 0 To 3
                        If Not Me.lkpManzanaEtapa1.Properties.Columns.GetVisibleColumn(i) Is Nothing Then
                            Me.lkpManzanaEtapa1.Properties.Columns.Remove(Me.lkpManzanaEtapa1.Properties.Columns.GetVisibleColumn(i))
                        End If
                    Next

                    Try
                        objAdapter.Fill(objDataSet, "ManzanaAutoE1")
                        Dim objTabla As DataTable = objDataSet.Tables("ManzanaAutoE1")
                        Me.lkpManzanaEtapa1.Properties.DataSource = objTabla
                        Me.lkpManzanaEtapa1.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("mz1", "mz1", 5, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
                        Me.lkpManzanaEtapa1.Properties.DisplayMember = "mz1"
                        Me.lkpManzanaEtapa1.Properties.ValueMember = "mz1"

                    Catch ex As Exception
                        MessageBox.Show(ex.Message + vbCrLf + vbCrLf + ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try

                    If conflictiva = 1 AndAlso Not mismaManzanaDestino Then
                        MessageBox.Show("Debe escoger una manzana del siguiente mapa para identificar el lugar de bajada del transporte.", "Intersección conflictiva", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Dim mapaInterseccion As New MapaInterseccion(codigoTrasa)
                        mapaInterseccion.ShowDialog()
                        lkpManzanaEtapa1.Focus()
                    ElseIf conflictiva = 0 Then
                        Dim aleatorioMax = objDataSet.Tables("ManzanaAutoE1").Rows.Count
                        Dim aleatorio As Random = New Random
                        Me.lkpManzanaEtapa1.ItemIndex = aleatorio.Next(0, aleatorioMax - 1)
                        'CHEQUEAR SI HAY OTRO MODO
                    End If
                    mismaManzanaDestino = False
                Catch ex As Exception

                End Try
            Else
                'borrar manzanas 
                lkpManzanaEtapa1.Properties.DataSource = ""
                For i As Integer = 0 To 3
                    If Not Me.lkpManzanaEtapa1.Properties.Columns.GetVisibleColumn(i) Is Nothing Then
                        Me.lkpManzanaEtapa1.Properties.Columns.Remove(Me.lkpManzanaEtapa1.Properties.Columns.GetVisibleColumn(i))
                    End If
                Next
                lkpManzanaEtapa1.Properties.DataSource = Nothing

                'si indicó hito, lanzar manzana de hito
                If lkpHitoEtapa1.EditValue IsNot Nothing AndAlso lkpHitoEtapa1.EditValue.ToString <> "" Then
                    lkpHitoEtapa1_EditValueChanged(lkpHitoEtapa1, Nothing)
                End If
            End If
        End If
    End Sub

    Private Sub lkpCalle2Etapa2_CloseUp(sender As Object, e As DevExpress.XtraEditors.Controls.CloseUpEventArgs) Handles lkpCalle2Etapa2.CloseUp
        If e.AcceptValue Then
            Dim idInterseccion As Integer
            Dim conflictiva As Integer
            Dim codigoTrasa As Integer

            If lkpCalle2Etapa2.EditValue IsNot Nothing AndAlso lkpCalle2Etapa2.EditValue.ToString <> "" Then
                Try
                    Dim edit As GridLookUpEdit = TryCast(sender, GridLookUpEdit)
                    Dim row As DataRowView = TryCast(edit.Properties.GetRowByKeyValue(e.Value), DataRowView)
                    idInterseccion = row.Item("id")
                    conflictiva = row.Item("conflictiva")
                    codigoTrasa = row.Item("codigoTrasa")
                    Me.x_etapa2.Text = row.Item("x")
                    Me.y_etapa2.Text = row.Item("y")

                    Dim objConn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\MASCARA REFERENCIA_VF.accdb")
                    objConn.Open()

                    Dim objCommand As New OleDbCommand("MzIntersec", objConn) With {.CommandType = CommandType.StoredProcedure}
                    Dim parametro As New OleDbParameter("idInter", idInterseccion)
                    objCommand.Parameters.Add(parametro)

                    Dim objAdapter As New OleDbDataAdapter(objCommand)
                    Dim objDataSet As New DataSet("ManzanaAutoE2")

                    For i As Integer = 0 To 3
                        If Not Me.lkpManzanaEtapa2.Properties.Columns.GetVisibleColumn(i) Is Nothing Then
                            Me.lkpManzanaEtapa2.Properties.Columns.Remove(Me.lkpManzanaEtapa2.Properties.Columns.GetVisibleColumn(i))
                        End If
                    Next

                    Try
                        objAdapter.Fill(objDataSet, "ManzanaAutoE2")
                        Dim objTabla As DataTable = objDataSet.Tables("ManzanaAutoE2")
                        Me.lkpManzanaEtapa2.Properties.DataSource = objTabla
                        Me.lkpManzanaEtapa2.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("mz1", "mz1", 5, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
                        Me.lkpManzanaEtapa2.Properties.DisplayMember = "mz1"
                        Me.lkpManzanaEtapa2.Properties.ValueMember = "mz1"

                    Catch ex As Exception
                        MessageBox.Show(ex.Message + vbCrLf + vbCrLf + ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try


                    If conflictiva = 1 AndAlso Not mismaManzanaDestino Then
                        MessageBox.Show("Debe escoger una manzana del siguiente mapa para identificar el lugar de bajada del transporte.", "Intersección conflictiva", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Dim mapaInterseccion As New MapaInterseccion(codigoTrasa)
                        mapaInterseccion.ShowDialog()
                        lkpManzanaEtapa2.Focus()
                    ElseIf conflictiva = 0 Then
                        Dim aleatorioMax = objDataSet.Tables("ManzanaAutoE2").Rows.Count
                        Dim aleatorio As Random = New Random
                        Me.lkpManzanaEtapa2.ItemIndex = aleatorio.Next(0, aleatorioMax - 1)
                        'CHEQUEAR SI HAY OTRO MODO
                    End If
                    mismaManzanaDestino = False
                Catch ex As Exception

                End Try
            Else
                'borrar manzanas 
                lkpManzanaEtapa2.Properties.DataSource = ""
                For i As Integer = 0 To 3
                    If Not Me.lkpManzanaEtapa2.Properties.Columns.GetVisibleColumn(i) Is Nothing Then
                        Me.lkpManzanaEtapa2.Properties.Columns.Remove(Me.lkpManzanaEtapa2.Properties.Columns.GetVisibleColumn(i))
                    End If
                Next
                lkpManzanaEtapa2.Properties.DataSource = Nothing

                'si indicó hito, lanzar manzana de hito
                If lkpHitoEtapa2.EditValue IsNot Nothing AndAlso lkpHitoEtapa2.EditValue.ToString <> "" Then
                    lkpHitoEtapa2_EditValueChanged(lkpHitoEtapa2, Nothing)
                End If
            End If
        End If
    End Sub

    Private Sub lkpCalle2Etapa3_CloseUp(sender As Object, e As DevExpress.XtraEditors.Controls.CloseUpEventArgs) Handles lkpCalle2Etapa3.CloseUp
        If e.AcceptValue Then
            Dim idInterseccion As Integer
            Dim conflictiva As Integer
            Dim codigoTrasa As Integer

            If lkpCalle2Etapa3.EditValue IsNot Nothing AndAlso lkpCalle2Etapa3.EditValue.ToString <> "" Then
                Try
                    Dim edit As GridLookUpEdit = TryCast(sender, GridLookUpEdit)
                    Dim row As DataRowView = TryCast(edit.Properties.GetRowByKeyValue(e.Value), DataRowView)
                    idInterseccion = row.Item("id")
                    conflictiva = row.Item("conflictiva")
                    codigoTrasa = row.Item("codigoTrasa")
                    Me.x_etapa3.Text = row.Item("x")
                    Me.y_etapa3.Text = row.Item("y")

                    Dim objConn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\MASCARA REFERENCIA_VF.accdb")
                    objConn.Open()

                    Dim objCommand As New OleDbCommand("MzIntersec", objConn) With {.CommandType = CommandType.StoredProcedure}
                    Dim parametro As New OleDbParameter("idInter", idInterseccion)
                    objCommand.Parameters.Add(parametro)

                    Dim objAdapter As New OleDbDataAdapter(objCommand)
                    Dim objDataSet As New DataSet("ManzanaAutoE2")

                    For i As Integer = 0 To 3
                        If Not Me.lkpManzanaEtapa3.Properties.Columns.GetVisibleColumn(i) Is Nothing Then
                            Me.lkpManzanaEtapa3.Properties.Columns.Remove(Me.lkpManzanaEtapa3.Properties.Columns.GetVisibleColumn(i))
                        End If
                    Next

                    Try
                        objAdapter.Fill(objDataSet, "ManzanaAutoE2")
                        Dim objTabla As DataTable = objDataSet.Tables("ManzanaAutoE2")
                        Me.lkpManzanaEtapa3.Properties.DataSource = objTabla
                        Me.lkpManzanaEtapa3.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("mz1", "mz1", 5, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
                        Me.lkpManzanaEtapa3.Properties.DisplayMember = "mz1"
                        Me.lkpManzanaEtapa3.Properties.ValueMember = "mz1"

                    Catch ex As Exception
                        MessageBox.Show(ex.Message + vbCrLf + vbCrLf + ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try


                    If conflictiva = 1 AndAlso Not mismaManzanaDestino Then
                        MessageBox.Show("Debe escoger una manzana del siguiente mapa para identificar el lugar de bajada del transporte.", "Intersección conflictiva", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Dim mapaInterseccion As New MapaInterseccion(codigoTrasa)
                        mapaInterseccion.ShowDialog()
                        lkpManzanaEtapa3.Focus()
                    ElseIf conflictiva = 0 Then
                        Dim aleatorioMax = objDataSet.Tables("ManzanaAutoE2").Rows.Count
                        Dim aleatorio As Random = New Random
                        Me.lkpManzanaEtapa3.ItemIndex = aleatorio.Next(0, aleatorioMax - 1)
                        'CHEQUEAR SI HAY OTRO MODO
                    End If
                    mismaManzanaDestino = False
                Catch ex As Exception
                End Try
            Else
                'borrar manzanas 
                lkpManzanaEtapa3.Properties.DataSource = ""
                For i As Integer = 0 To 3
                    If Not Me.lkpManzanaEtapa3.Properties.Columns.GetVisibleColumn(i) Is Nothing Then
                        Me.lkpManzanaEtapa3.Properties.Columns.Remove(Me.lkpManzanaEtapa3.Properties.Columns.GetVisibleColumn(i))
                    End If
                Next
                lkpManzanaEtapa3.Properties.DataSource = Nothing

                'si indicó hito, lanzar manzana de hito
                If lkpHitoEtapa3.EditValue IsNot Nothing AndAlso lkpHitoEtapa3.EditValue.ToString <> "" Then
                    lkpHitoEtapa3_EditValueChanged(lkpHitoEtapa3, Nothing)
                End If
            End If

        End If
    End Sub

    Private Sub lkpVehHogarE3_Enter(sender As Object, e As EventArgs) Handles lkpVehHogarE3.Enter
        BeginInvoke(New MethodInvoker(Sub() CType(sender, GridLookUpEdit).ShowPopup()))
    End Sub

    Private Sub lkpPropiedadBicicletaE2_Enter(sender As Object, e As EventArgs) Handles lkpPropiedadBicicletaE2.Enter
        BeginInvoke(New MethodInvoker(Sub() CType(sender, GridLookUpEdit).ShowPopup()))
    End Sub

    Private Sub lkpComunaEtapa1_Leave(sender As Object, e As EventArgs) Handles lkpComunaEtapa1.Leave
        Dim opcion As Integer

        If lkpComunaEtapa1.EditValue IsNot Nothing AndAlso lkpComunaEtapa1.EditValue.ToString <> "" Then
            opcion = lkpComunaEtapa1.EditValue
        End If

        If (opcion <> 2 AndAlso opcion <> 3) Then
            If lkpTransporte2.EditValue IsNot Nothing AndAlso lkpTransporte2.EditValue.ToString <> "" AndAlso lkpTransporte2.EditValue > 0 Then
                Me.tabsEtapas.SelectedTabPage = tabsEtapas.TabPages(1)
                Select Case lkpTransporte2.EditValue
                    Case 1, 5, 9
                        txtCuadrasAutoE2.Focus()
                    Case 2, 10, 11, 12
                        txtCuadrasBusE2.Focus()
                    Case 3, 4
                        txtCuadrasTXCE2.Focus()
                    Case 6
                        txtCuadrasTaxiE2.Focus()
                    Case 8
                        lkpPropiedadBicicletaE2.Focus()
                    Case 13
                        txtCuadrasBarcazaE2.Focus()
                End Select
            End If
        End If
    End Sub

    Private Sub lkpComunaEtapa2_Leave(sender As Object, e As EventArgs) Handles lkpComunaEtapa2.Leave
        Dim opcion As Integer

        If lkpComunaEtapa2.EditValue IsNot Nothing AndAlso lkpComunaEtapa2.EditValue.ToString <> "" Then
            opcion = lkpComunaEtapa2.EditValue
        End If

        If (opcion <> 2 AndAlso opcion <> 3) Then
            If lkpTransporte3.EditValue IsNot Nothing AndAlso lkpTransporte3.EditValue.ToString <> "" AndAlso lkpTransporte3.EditValue > 0 Then
                Me.tabsEtapas.SelectedTabPage = tabsEtapas.TabPages(2)
                Select Case lkpTransporte3.EditValue
                    Case 1, 5, 9
                        txtCuadrasAutoE3.Focus()
                    Case 2, 10, 11, 12
                        txtCuadrasBusE3.Focus()
                    Case 3, 4
                        txtCuadrasTXCE3.Focus()
                    Case 6
                        txtCuadrasTaxiE3.Focus()
                    Case 8
                        lkpPropiedadBicicletaE3.Focus()
                    Case 13
                        txtCuadrasBarcazaE3.Focus()
                End Select
            End If
        End If
    End Sub


    Private Sub lkpCalle2Origen_Leave(sender As Object, e As EventArgs) Handles lkpCalle2Origen.Leave
        If lkpManzanaOrigen.Properties.DataSource Is Nothing Then
            Dim args As DevExpress.XtraEditors.Controls.CloseUpEventArgs = New DevExpress.XtraEditors.Controls.CloseUpEventArgs(Nothing)
            args.AcceptValue = True
            args.Value = Me.lkpCalle2Origen.EditValue
            Me.lkpCalle2Origen_CloseUp(lkpCalle2Origen, args)
        End If
    End Sub

    Private Sub lkpCalle2Destino_Leave(sender As Object, e As EventArgs) Handles lkpCalle2Destino.Leave
        If lkpManzanaDestino.Properties.DataSource Is Nothing Then
            Dim args As DevExpress.XtraEditors.Controls.CloseUpEventArgs = New DevExpress.XtraEditors.Controls.CloseUpEventArgs(Nothing)
            args.AcceptValue = True
            args.Value = Me.lkpCalle2Destino.EditValue
            Me.lkpCalle2Destino_CloseUp(lkpCalle2Destino, args)
        End If
    End Sub

    Private Sub lkpCalle2Etapa1_Leave(sender As Object, e As EventArgs) Handles lkpCalle2Etapa1.Leave
        If lkpManzanaEtapa1.Properties.DataSource Is Nothing Then
            Dim args As DevExpress.XtraEditors.Controls.CloseUpEventArgs = New DevExpress.XtraEditors.Controls.CloseUpEventArgs(Nothing)
            args.AcceptValue = True
            args.Value = Me.lkpCalle2Etapa1.EditValue
            Me.lkpCalle2Etapa1_CloseUp(lkpCalle2Etapa1, args)
        End If
    End Sub

    Private Sub lkpCalle2Etapa2_Leave(sender As Object, e As EventArgs) Handles lkpCalle2Etapa2.Leave
        If lkpManzanaEtapa2.Properties.DataSource Is Nothing Then
            Dim args As DevExpress.XtraEditors.Controls.CloseUpEventArgs = New DevExpress.XtraEditors.Controls.CloseUpEventArgs(Nothing)
            args.AcceptValue = True
            args.Value = Me.lkpCalle2Etapa2.EditValue
            Me.lkpCalle2Etapa2_CloseUp(lkpCalle2Etapa2, args)
        End If
    End Sub

    Private Sub lkpCalle2Etapa3_Leave(sender As Object, e As EventArgs) Handles lkpCalle2Etapa3.Leave
        If lkpManzanaEtapa3.Properties.DataSource Is Nothing Then
            Dim args As DevExpress.XtraEditors.Controls.CloseUpEventArgs = New DevExpress.XtraEditors.Controls.CloseUpEventArgs(Nothing)
            args.AcceptValue = True
            args.Value = Me.lkpCalle2Etapa3.EditValue
            Me.lkpCalle2Etapa3_CloseUp(lkpCalle2Etapa3, args)
        End If
    End Sub

    Private Sub fillCalle1()
        Me.CallesTableAdapter.Fill(datasetEOD.Calles)
    End Sub

    Private Sub fillDondeSeBajo()
        Me.DondeSeBajoTableAdapter.Fill(datasetEOD.DondeSeBajo)
    End Sub

    Private Sub fillHito()
        Me.HitoTableAdapter.Fill(datasetEOD.Hito)
    End Sub

    Private Sub fillModo()
        Me.ModoTableAdapter.Fill(datasetEOD.Modo)
    End Sub

    Private Sub fillComuna()
        Me.ComunaTableAdapter.Fill(datasetEOD.Comuna)
    End Sub

    Private Sub fillProposito()
        Me.PropositoTableAdapter.Fill(datasetEOD.Proposito)
    End Sub

    Private Sub fillLugarPrimerViaje()
        Me.LugarPrimerViajeTableAdapter.Fill(datasetEOD.LugarPrimerViaje)
    End Sub

    Private Sub fillNoViaja()
        Me.NoViajaTableAdapter.Fill(datasetEOD.NoViaja)
    End Sub

    Private Sub fillSiNo()
        Me.SiNoTableAdapter.Fill(datasetEOD.SiNo)
    End Sub

    Private Sub fillPagaEstacionamiento()
        Me.PagaEstacionamientoTableAdapter.Fill(datasetEOD.PagaEstacionamiento)
    End Sub

    Private Sub fillQueVehiculo()
        Me.QueVehiculoTableAdapter.Fill(datasetEOD.QueVehiculo)
    End Sub

    Private Sub fillFormaPago()
        Me.FormaPagoTableAdapter.Fill(datasetEOD.FormaPago)
    End Sub

    Private Sub fillResumenVehiculos()
        Me.ResumenVehiculosTableAdapter.Fill(datasetEOD.ResumenVehiculos)
    End Sub

    Private Sub fillViajaComo()
        Me.ViajaComoTableAdapter.Fill(datasetEOD.ViajaComo)
    End Sub

    Private Sub fillPropiedadBicicleta()
        Me.PropiedadBicicletaTableAdapter.Fill(datasetEOD.PropiedadBicicleta)
    End Sub

    Private Sub fillTipoTarifa()
        Me.TipoTarifaTableAdapter.Fill(datasetEOD.TipoTarifa)
    End Sub

    Private Sub fillMuelle()
        Me.MuelleTableAdapter.Fill(datasetEOD.Muelle)
    End Sub

    Private Sub txtCuadrasBarcazaE1_Leave(sender As Object, e As EventArgs) Handles txtCuadrasBarcazaE1.Leave
        If txtCuadrasBarcazaE1.Text <> "" Then
            If Convert.ToInt32(txtCuadrasBarcazaE1.Text) = 0 Then
                txtMinutosBarcazaE1.Text = 0
                txtMinutosEsperaBarcazaE1.Focus()
            End If
        End If
    End Sub

    Private Sub txtCuadrasBarcazaE2_Leave(sender As Object, e As EventArgs) Handles txtCuadrasBarcazaE2.Leave
        If txtCuadrasBarcazaE2.Text <> "" Then
            If Convert.ToInt32(txtCuadrasBarcazaE2.Text) = 0 Then
                txtMinutosBarcazaE2.Text = 0
                txtMinutosEsperaBarcazaE2.Focus()
            End If
        End If
    End Sub

    Private Sub txtCuadrasBarcazaE3_Leave(sender As Object, e As EventArgs) Handles txtCuadrasBarcazaE3.Leave
        If txtCuadrasBarcazaE3.Text <> "" Then
            If Convert.ToInt32(txtCuadrasBarcazaE3.Text) = 0 Then
                txtMinutosBarcazaE3.Text = 0
                txtMinutosEsperaBarcazaE3.Focus()
            End If
        End If
    End Sub

    Private Sub txtMinutosBarcazaE1_Leave(sender As Object, e As EventArgs) Handles txtMinutosBarcazaE1.Leave
        If txtMinutosBarcazaE1.Text <> "" Then

            If Convert.ToInt32(txtMinutosBarcazaE1.Text) = 0 AndAlso txtCuadrasBarcazaE1.Text <> "" AndAlso Convert.ToInt32(txtCuadrasBarcazaE1.Text) > 0 Then
                MessageBox.Show("Ha indicado que caminó algunas cuadras en 0 minutos, corrija para continuar", "Dato inconsistente", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtMinutosBarcazaE1.Text = ""
                txtCuadrasBarcazaE1.Text = ""
                txtCuadrasBarcazaE1.Focus()
            ElseIf Convert.ToInt32(txtMinutosBarcazaE1.Text) > 0 AndAlso txtCuadrasBarcazaE1.Text <> "" AndAlso Convert.ToInt32(txtCuadrasBarcazaE1.Text) = 0 Then
                MessageBox.Show("Ha indicado que caminó algunos minutos pero 0 cuadras, corrija para continuar", "Dato inconsistente", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtMinutosBarcazaE1.Text = ""
                txtCuadrasBarcazaE1.Focus()
            End If
        End If
    End Sub

    Private Sub txtMinutosBarcazaE2_Leave(sender As Object, e As EventArgs) Handles txtMinutosBarcazaE2.Leave
        If txtMinutosBarcazaE2.Text <> "" Then

            If Convert.ToInt32(txtMinutosBarcazaE2.Text) = 0 AndAlso txtCuadrasBarcazaE2.Text <> "" AndAlso Convert.ToInt32(txtCuadrasBarcazaE2.Text) > 0 Then
                MessageBox.Show("Ha indicado que caminó algunas cuadras en 0 minutos, corrija para continuar", "Dato inconsistente", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtMinutosBarcazaE2.Text = ""
                txtCuadrasBarcazaE2.Text = ""
                txtCuadrasBarcazaE2.Focus()
            ElseIf Convert.ToInt32(txtMinutosBarcazaE2.Text) > 0 AndAlso txtCuadrasBarcazaE2.Text <> "" AndAlso Convert.ToInt32(txtCuadrasBarcazaE2.Text) = 0 Then
                MessageBox.Show("Ha indicado que caminó algunos minutos pero 0 cuadras, corrija para continuar", "Dato inconsistente", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtMinutosBarcazaE2.Text = ""
                txtCuadrasBarcazaE2.Focus()
            End If
        End If
    End Sub

    Private Sub txtMinutosBarcazaE3_Leave(sender As Object, e As EventArgs) Handles txtMinutosBarcazaE3.Leave
        If txtMinutosBarcazaE3.Text <> "" Then

            If Convert.ToInt32(txtMinutosBarcazaE3.Text) = 0 AndAlso txtCuadrasBarcazaE3.Text <> "" AndAlso Convert.ToInt32(txtCuadrasBarcazaE3.Text) > 0 Then
                MessageBox.Show("Ha indicado que caminó algunas cuadras en 0 minutos, corrija para continuar", "Dato inconsistente", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtMinutosBarcazaE3.Text = ""
                txtCuadrasBarcazaE3.Text = ""
                txtCuadrasBarcazaE3.Focus()
            ElseIf Convert.ToInt32(txtMinutosBarcazaE3.Text) > 0 AndAlso txtCuadrasBarcazaE3.Text <> "" AndAlso Convert.ToInt32(txtCuadrasBarcazaE3.Text) = 0 Then
                MessageBox.Show("Ha indicado que caminó algunos minutos pero 0 cuadras, corrija para continuar", "Dato inconsistente", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtMinutosBarcazaE3.Text = ""
                txtCuadrasBarcazaE3.Focus()
            End If
        End If
    End Sub

    Private Sub lkpMuelleSubidaBarcazaE1_EditValueChanged(sender As Object, e As EventArgs) Handles lkpMuelleSubidaBarcazaE1.EditValueChanged
        Dim opcionSubida As Integer

        If lkpMuelleSubidaBarcazaE1.EditValue IsNot Nothing AndAlso Me.lkpMuelleSubidaBarcazaE1.EditValue.ToString <> "" Then
            opcionSubida = Me.lkpMuelleSubidaBarcazaE1.EditValue
        End If

        If opcionSubida > 0 AndAlso opcionSubida < 3 Then
            MuelleBajadaBindingSource.Filter = "PA = 0"
        Else
            MuelleBajadaBindingSource.Filter = "PA = 1"
        End If
    End Sub

    Private Sub lkpMuelleSubidaBarcazaE2_EditValueChanged(sender As Object, e As EventArgs) Handles lkpMuelleSubidaBarcazaE2.EditValueChanged
        Dim opcionSubida As Integer

        If lkpMuelleSubidaBarcazaE2.EditValue IsNot Nothing AndAlso Me.lkpMuelleSubidaBarcazaE2.EditValue.ToString <> "" Then
            opcionSubida = Me.lkpMuelleSubidaBarcazaE2.EditValue
        End If

        If opcionSubida > 0 AndAlso opcionSubida < 3 Then
            MuelleBajadaBindingSource.Filter = "PA = 0"
        Else
            MuelleBajadaBindingSource.Filter = "PA = 1"
        End If
    End Sub

    Private Sub lkpMuelleSubidaBarcazaE3_EditValueChanged(sender As Object, e As EventArgs) Handles lkpMuelleSubidaBarcazaE3.EditValueChanged
        Dim opcionSubida As Integer

        If lkpMuelleSubidaBarcazaE3.EditValue IsNot Nothing AndAlso Me.lkpMuelleSubidaBarcazaE3.EditValue.ToString <> "" Then
            opcionSubida = Me.lkpMuelleSubidaBarcazaE3.EditValue
        End If

        If opcionSubida > 0 AndAlso opcionSubida < 3 Then
            MuelleBajadaBindingSource.Filter = "PA = 0"
        Else
            MuelleBajadaBindingSource.Filter = "PA = 1"
        End If
    End Sub

    Private Sub lkpMuelleBajadaBarcazaE1_EditValueChanged(sender As Object, e As EventArgs) Handles lkpMuelleBajadaBarcazaE1.EditValueChanged
        Dim opcionSubida As Integer
        Dim opcionBajada As Integer

        If lkpMuelleSubidaBarcazaE1.EditValue IsNot Nothing AndAlso Me.lkpMuelleSubidaBarcazaE1.EditValue.ToString <> "" Then
            opcionSubida = Me.lkpMuelleSubidaBarcazaE1.EditValue
        End If

        If lkpMuelleBajadaBarcazaE1.EditValue IsNot Nothing AndAlso Me.lkpMuelleBajadaBarcazaE1.EditValue.ToString <> "" Then
            opcionBajada = Me.lkpMuelleBajadaBarcazaE1.EditValue
        End If

        If opcionBajada > 0 AndAlso opcionBajada = opcionSubida Then
            MessageBox.Show("Ha indicado que se subió en la misma estación donde bajó, corrija para continuar", "Dato inconsistente", MessageBoxButtons.OK, MessageBoxIcon.Error)
            lkpMuelleBajadaBarcazaE1.EditValue = -1
        End If
    End Sub

    Private Sub lkpMuelleBajadaBarcazaE2_EditValueChanged(sender As Object, e As EventArgs) Handles lkpMuelleBajadaBarcazaE2.EditValueChanged
        Dim opcionSubida As Integer
        Dim opcionBajada As Integer

        If lkpMuelleSubidaBarcazaE2.EditValue IsNot Nothing AndAlso Me.lkpMuelleSubidaBarcazaE2.EditValue.ToString <> "" Then
            opcionSubida = Me.lkpMuelleSubidaBarcazaE2.EditValue
        End If

        If lkpMuelleBajadaBarcazaE2.EditValue IsNot Nothing AndAlso Me.lkpMuelleBajadaBarcazaE2.EditValue.ToString <> "" Then
            opcionBajada = Me.lkpMuelleBajadaBarcazaE2.EditValue
        End If

        If opcionBajada > 0 AndAlso opcionBajada = opcionSubida Then
            MessageBox.Show("Ha indicado que se subió en la misma estación donde bajó, corrija para continuar", "Dato inconsistente", MessageBoxButtons.OK, MessageBoxIcon.Error)
            lkpMuelleBajadaBarcazaE2.EditValue = -1
        End If
    End Sub

    Private Sub lkpMuelleBajadaBarcazaE3_EditValueChanged(sender As Object, e As EventArgs) Handles lkpMuelleBajadaBarcazaE3.EditValueChanged
        Dim opcionSubida As Integer
        Dim opcionBajada As Integer

        If lkpMuelleSubidaBarcazaE3.EditValue IsNot Nothing AndAlso Me.lkpMuelleSubidaBarcazaE3.EditValue.ToString <> "" Then
            opcionSubida = Me.lkpMuelleSubidaBarcazaE3.EditValue
        End If

        If lkpMuelleBajadaBarcazaE3.EditValue IsNot Nothing AndAlso Me.lkpMuelleBajadaBarcazaE3.EditValue.ToString <> "" Then
            opcionBajada = Me.lkpMuelleBajadaBarcazaE3.EditValue
        End If

        If opcionBajada > 0 AndAlso opcionBajada = opcionSubida Then
            MessageBox.Show("Ha indicado que se subió en el mismo muelle donde bajó, corrija para continuar", "Dato inconsistente", MessageBoxButtons.OK, MessageBoxIcon.Error)
            lkpMuelleBajadaBarcazaE3.EditValue = -1
        End If
    End Sub

    Private Sub tmHoraSalida_Leave(sender As Object, e As EventArgs) Handles tmHoraSalida.Leave
        If primeraCarga = False Then
            If idViaje > 1 Then
                Dim horaFinAnterior As DateTime = Me.tmFinAnterior.EditValue
                Dim horaInicioNuevo As DateTime = Me.tmHoraSalida.EditValue

                Dim diff As Integer = diferenciaHoras(horaInicioNuevo, horaFinAnterior)

                If Not diff > 0 Then
                    MessageBox.Show("Ha indicado una hora de salida incoherente con el viaje anterior. Corrija para continuar.", "Dato inconsistente", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    tmHoraSalida.Focus()
                End If
            End If
        End If
        primeraCarga = False
    End Sub

    Private Sub lkpMuelleSubidaBarcazaE1_Enter(sender As Object, e As EventArgs) Handles lkpMuelleSubidaBarcazaE1.Enter
        BeginInvoke(New MethodInvoker(Sub() CType(sender, GridLookUpEdit).ShowPopup()))
    End Sub

    Private Sub lkpMuelleSubidaBarcazaE2_Enter(sender As Object, e As EventArgs) Handles lkpMuelleSubidaBarcazaE2.Enter
        BeginInvoke(New MethodInvoker(Sub() CType(sender, GridLookUpEdit).ShowPopup()))
    End Sub

    Private Sub lkpMuelleSubidaBarcazaE3_Enter(sender As Object, e As EventArgs) Handles lkpMuelleSubidaBarcazaE3.Enter
        BeginInvoke(New MethodInvoker(Sub() CType(sender, GridLookUpEdit).ShowPopup()))
    End Sub

    Private Sub lkpMuelleBajadaBarcazaE1_Enter(sender As Object, e As EventArgs) Handles lkpMuelleBajadaBarcazaE1.Enter
        BeginInvoke(New MethodInvoker(Sub() CType(sender, GridLookUpEdit).ShowPopup()))
    End Sub

    Private Sub lkpMuelleBajadaBarcazaE2_Enter(sender As Object, e As EventArgs) Handles lkpMuelleBajadaBarcazaE2.Enter
        BeginInvoke(New MethodInvoker(Sub() CType(sender, GridLookUpEdit).ShowPopup()))
    End Sub

    Private Sub lkpMuelleBajadaBarcazaE3_Enter(sender As Object, e As EventArgs) Handles lkpMuelleBajadaBarcazaE3.Enter
        BeginInvoke(New MethodInvoker(Sub() CType(sender, GridLookUpEdit).ShowPopup()))
    End Sub

    Private Sub lkpMuelleBajadaBarcazaE1_Leave(sender As Object, e As EventArgs) Handles lkpMuelleBajadaBarcazaE1.Leave
        If lkpTransporte2.EditValue IsNot Nothing AndAlso lkpTransporte2.EditValue.ToString <> "" AndAlso lkpTransporte2.EditValue > 0 Then
            Me.tabsEtapas.SelectedTabPage = tabsEtapas.TabPages(1)
            Select Case lkpTransporte2.EditValue
                Case 1, 5, 9
                    txtCuadrasAutoE2.Focus()
                Case 2, 10, 11, 12
                    txtCuadrasBusE2.Focus()
                Case 3, 4
                    txtCuadrasTXCE2.Focus()
                Case 6
                    txtCuadrasTaxiE2.Focus()
                Case 8
                    lkpPropiedadBicicletaE2.Focus()
                Case 13
                    txtCuadrasBarcazaE2.Focus()
            End Select
        End If
    End Sub

    Private Sub lkpMuelleBajadaBarcazaE2_Leave(sender As Object, e As EventArgs) Handles lkpMuelleBajadaBarcazaE2.Leave
        If lkpTransporte3.EditValue IsNot Nothing AndAlso lkpTransporte3.EditValue.ToString <> "" AndAlso lkpTransporte3.EditValue > 0 Then
            Me.tabsEtapas.SelectedTabPage = tabsEtapas.TabPages(2)
            Select Case lkpTransporte3.EditValue
                Case 1, 5, 9
                    txtCuadrasAutoE3.Focus()
                Case 2, 10, 11, 12
                    txtCuadrasBusE3.Focus()
                Case 3, 4
                    txtCuadrasTXCE3.Focus()
                Case 6
                    txtCuadrasTaxiE3.Focus()
                Case 8
                    lkpPropiedadBicicletaE3.Focus()
                Case 13
                    txtCuadrasBarcazaE3.Focus()
            End Select
        End If
    End Sub

    Private Function diferenciaHoras(ByVal hora1 As DateTime, ByVal hora2 As DateTime) As Integer
        Dim tiempo1 As Integer = hora1.Hour * 60 + hora1.Minute
        Dim tiempo2 As Integer = hora2.Hour * 60 + hora2.Minute

        Return tiempo1 - tiempo2
    End Function


    Private Sub ModificarViaje_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        If e.KeyCode = Keys.F7 Then
            Dim nuevaIncidencia = New Incidencia(Me.idFolio, Me.idPersona, Me.idDiaViajes, Me.idViaje)
            nuevaIncidencia.ShowDialog()
        End If
    End Sub

    Private Sub ModificarViaje_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        Me.datasetEOD.Clear()
        releaseObject(datasetEOD)
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

    Private Sub LkpCicloviaE1_EditValueChanged(sender As Object, e As EventArgs) Handles lkpCicloviaE1.EditValueChanged
        Dim opcion As Integer

        If lkpCicloviaE1.EditValue IsNot Nothing AndAlso lkpCicloviaE1.EditValue.ToString <> "" Then
            opcion = lkpCicloviaE1.EditValue
        End If

        If opcion = 2 Then
            spcMotivoNoUsaE1.Collapsed = False
            txtMotivoNoUsaE1.Visible = True
        Else
            spcMotivoNoUsaE1.Collapsed = True
            txtMotivoNoUsaE1.Visible = False
        End If
    End Sub

    Private Sub LkpCicloviaE2_EditValueChanged(sender As Object, e As EventArgs) Handles lkpCicloviaE2.EditValueChanged
        Dim opcion As Integer

        If lkpCicloviaE2.EditValue IsNot Nothing AndAlso lkpCicloviaE2.EditValue.ToString <> "" Then
            opcion = lkpCicloviaE2.EditValue
        End If

        If opcion = 2 Then
            spcMotivoNoUsaE2.Collapsed = False
            txtMotivoNoUsaE2.Visible = True
        Else
            spcMotivoNoUsaE2.Collapsed = True
            txtMotivoNoUsaE2.Visible = False
        End If
    End Sub

    Private Sub LkpCicloviaE3_EditValueChanged(sender As Object, e As EventArgs) Handles lkpCicloviaE3.EditValueChanged
        Dim opcion As Integer

        If lkpCicloviaE3.EditValue IsNot Nothing AndAlso lkpCicloviaE3.EditValue.ToString <> "" Then
            opcion = lkpCicloviaE3.EditValue
        End If

        If opcion = 2 Then
            spcMotivoNoUsaE3.Collapsed = False
            txtMotivoNoUsaE3.Visible = True
        Else
            spcMotivoNoUsaE3.Collapsed = True
            txtMotivoNoUsaE3.Visible = False
        End If
    End Sub

    Private Sub LkpDondeEstacionaE1_Enter(sender As Object, e As EventArgs) Handles lkpDondeEstacionaE1.Enter
        BeginInvoke(New MethodInvoker(Sub() CType(sender, GridLookUpEdit).ShowPopup()))
    End Sub

    Private Sub LkpDondeEstacionaE2_Enter(sender As Object, e As EventArgs) Handles lkpDondeEstacionaE2.Enter
        BeginInvoke(New MethodInvoker(Sub() CType(sender, GridLookUpEdit).ShowPopup()))
    End Sub

    Private Sub LkpDondeEstacionaE3_Enter(sender As Object, e As EventArgs) Handles lkpDondeEstacionaE3.Enter
        BeginInvoke(New MethodInvoker(Sub() CType(sender, GridLookUpEdit).ShowPopup()))
    End Sub

    Private Sub LkpCicloviaE1_Enter(sender As Object, e As EventArgs) Handles lkpCicloviaE1.Enter
        BeginInvoke(New MethodInvoker(Sub() CType(sender, GridLookUpEdit).ShowPopup()))
    End Sub

    Private Sub LkpEstacionamientoBiciE1_Enter(sender As Object, e As EventArgs) Handles lkpEstacionamientoBiciE1.Enter
        BeginInvoke(New MethodInvoker(Sub() CType(sender, GridLookUpEdit).ShowPopup()))
    End Sub

    Private Sub LkpCicloviaE2_Enter(sender As Object, e As EventArgs) Handles lkpCicloviaE2.Enter
        BeginInvoke(New MethodInvoker(Sub() CType(sender, GridLookUpEdit).ShowPopup()))
    End Sub

    Private Sub LkpEstacionamientoBiciE2_Enter(sender As Object, e As EventArgs) Handles lkpEstacionamientoBiciE2.Enter
        BeginInvoke(New MethodInvoker(Sub() CType(sender, GridLookUpEdit).ShowPopup()))
    End Sub

    Private Sub LkpCicloviaE3_Enter(sender As Object, e As EventArgs) Handles lkpCicloviaE3.Enter
        BeginInvoke(New MethodInvoker(Sub() CType(sender, GridLookUpEdit).ShowPopup()))
    End Sub

    Private Sub LkpEstacionamientoBiciE3_Enter(sender As Object, e As EventArgs) Handles lkpEstacionamientoBiciE3.Enter
        BeginInvoke(New MethodInvoker(Sub() CType(sender, GridLookUpEdit).ShowPopup()))
    End Sub

    Private Sub txtMinutosEstacionaAutoE1_Leave(sender As Object, e As EventArgs) Handles txtMinutosEstacionaAutoE1.Leave
        If txtMinutosEstacionaAutoE1.Text <> "" Then
            Dim valor As Integer = txtMinutosEstacionaAutoE1.Text

            If valor > 60 Then
                Dim confirma As DialogResult = MessageBox.Show("Indicó que tardó más de 1 hora en estacionar, ¿confirma que es correcto?", "Validación de datos", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                If confirma = DialogResult.No Then
                    txtMinutosEstacionaAutoE1.Text = ""
                    txtMinutosEstacionaAutoE1.Focus()
                End If
            End If
        End If
    End Sub

    Private Sub txtMinutosEstacionaAutoE2_Leave(sender As Object, e As EventArgs) Handles txtMinutosEstacionaAutoE2.Leave
        If txtMinutosEstacionaAutoE2.Text <> "" Then
            Dim valor As Integer = txtMinutosEstacionaAutoE2.Text

            If valor > 60 Then
                Dim confirma As DialogResult = MessageBox.Show("Indicó que tardó más de 1 hora en estacionar, ¿confirma que es correcto?", "Validación de datos", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                If confirma = DialogResult.No Then
                    txtMinutosEstacionaAutoE2.Text = ""
                    txtMinutosEstacionaAutoE2.Focus()
                End If
            End If
        End If
    End Sub

    Private Sub txtMinutosEstacionaAutoE3_Leave(sender As Object, e As EventArgs) Handles txtMinutosEstacionaAutoE3.Leave
        If txtMinutosEstacionaAutoE3.Text <> "" Then
            Dim valor As Integer = txtMinutosEstacionaAutoE3.Text

            If valor > 60 Then
                Dim confirma As DialogResult = MessageBox.Show("Indicó que tardó más de 1 hora en estacionar, ¿confirma que es correcto?", "Validación de datos", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                If confirma = DialogResult.No Then
                    txtMinutosEstacionaAutoE3.Text = ""
                    txtMinutosEstacionaAutoE3.Focus()
                End If
            End If
        End If
    End Sub
End Class
