Imports DevExpress.XtraEditors
Imports EOD.datasetEOD
Imports EOD.datasetEODTableAdapters
Imports DevExpress.Utils.Win
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Controls
Imports System.Data.OleDb
Imports Waymex.Gps

Public Class NuevoHogar
    Friend WithEvents HogarTableAdapter As EOD.datasetEODTableAdapters.HogarTableAdapter
    Friend WithEvents VehiculoTableAdapter As EOD.datasetEODTableAdapters.VehiculoTableAdapter
    Friend WithEvents PersonaTableAdapter As EOD.datasetEODTableAdapters.PersonaTableAdapter

    Private hogar As Double
    Private numPer As Integer = 0
    Private numVeh As Integer = 0
    Private pressGrabarHogar As Boolean = False
    Private pressGrabarVehiculo As Boolean = False

    Dim gps As DeviceBase
    Dim waypoints As WaypointCollection
    Dim datasetWaypoints As DataSet
    Dim dataTableWaypoints As DataTable

    Private validadorHogar As ValidaHogarRow
    Private validadorPersona As ValidaPersonaRow

    Private primeraCarga As Boolean = True
    Private primeraCargaPersona As Boolean = True
    Private primeraCargaVehiculo As Boolean = True
    Private primeraCargaFecha As Boolean = True

    Dim modoEdicionHogar As Boolean = False
    Dim folioAnterior As Integer

    Private Sub NuevoHogar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'datasetEOD.TipoDiscapacidad' Puede moverla o quitarla según sea necesario.
        Me.TipoDiscapacidadTableAdapter.Fill(Me.datasetEOD.TipoDiscapacidad)
        Me.HogarTableAdapter = New EOD.datasetEODTableAdapters.HogarTableAdapter()
        Me.VehiculoTableAdapter = New EOD.datasetEODTableAdapters.VehiculoTableAdapter()
        Me.PersonaTableAdapter = New EOD.datasetEODTableAdapters.PersonaTableAdapter()

        Me.tabPageVehículos.PageVisible = False
        Me.tabPagePersonas.PageVisible = False
        Me.tabPageFecha.PageVisible = False
        Me.tabPaneHogar.SelectedPage = Me.tabPageHogar
        If Not cargaPreguntasHogar.IsBusy Then
            suspendBindings()
            Me.Enabled = False
            cargaPreguntasHogar.RunWorkerAsync()
        End If

        Me.deFechaViajes.Properties.MinValue = DateTime.Today.AddDays(1)

        validadorHogar = datasetEOD.ValidaHogar.NewValidaHogarRow
        validadorPersona = datasetEOD.ValidaPersona.NewValidaPersonaRow
    End Sub

    Private Sub lkpPropiedad_EditValueChanged(sender As Object, e As EventArgs) Handles lkpPropiedad.EditValueChanged
        Dim opcion As Integer

        If lkpPropiedad.EditValue IsNot Nothing AndAlso lkpPropiedad.EditValue.ToString <> "" Then
            opcion = lkpPropiedad.EditValue
            Me.tabsPagoVivienda.Visible = True
        End If

        Me.splitPropiedadPago.Collapsed = True
        Me.txtPropiedadOtra.Visible = False
        Me.lblPropiedadOtra.Visible = False

        Select Case opcion
            Case 1
                Me.tabsPagoVivienda.SelectedTabPageIndex = 2
            Case 4
                Me.tabsPagoVivienda.SelectedTabPageIndex = 2
                Me.splitPropiedadPago.Collapsed = False
                Me.txtPropiedadOtra.Visible = True
                Me.lblPropiedadOtra.Visible = True
            Case 2
                Me.tabsPagoVivienda.SelectedTabPageIndex = 0
            Case 3
                Me.tabsPagoVivienda.SelectedTabPageIndex = 1
        End Select
    End Sub

    Private Sub chkNSNRArriendo_CheckedChanged(sender As Object, e As EventArgs) Handles chkNSNRArriendo.CheckedChanged
        Dim opcion As Boolean = chkNSNRArriendo.Checked

        If opcion Then
            txtArriendo.Enabled = False
        Else
            txtArriendo.Enabled = True
        End If
    End Sub

    Private Sub chkNSNRDividendo_CheckedChanged(sender As Object, e As EventArgs) Handles chkNSNRDividendo.CheckedChanged
        Dim opcion As Boolean = chkNSNRDividendo.Checked

        If opcion Then
            txtDividendo.Enabled = False
        Else
            txtDividendo.Enabled = True
        End If
    End Sub

    Private Sub chkNSNREstima_CheckedChanged(sender As Object, e As EventArgs) Handles chkNSNREstima.CheckedChanged
        Dim opcion As Boolean = chkNSNREstima.Checked

        If opcion Then
            txtEstimaArriendo.Enabled = False
        Else
            txtEstimaArriendo.Enabled = True
        End If
    End Sub

    Private Sub lkpComuna_EditValueChanged(sender As Object, e As EventArgs) Handles lkpComuna.EditValueChanged
        Dim opcion As Integer

        If lkpComuna.EditValue IsNot Nothing AndAlso lkpComuna.EditValue.ToString <> "" Then
            opcion = lkpComuna.EditValue
        End If

        If opcion = 1 Then
            Me.lblComunaOtra.Visible = True
            Me.txtComunaOtra.Visible = True
        Else
            Me.lblComunaOtra.Visible = False
            Me.txtComunaOtra.Visible = False
        End If
    End Sub

    Private Sub lkpZona_Enter(sender As Object, e As EventArgs) Handles lkpZona.Enter
        If Not pressGrabarHogar Then
            BeginInvoke(New MethodInvoker(Sub() CType(sender, GridLookUpEdit).ShowPopup()))
        End If

    End Sub

    Private Sub lkpManzana_Enter(sender As Object, e As EventArgs) Handles lkpManzana.Enter
        BeginInvoke(New MethodInvoker(Sub() CType(sender, GridLookUpEdit).ShowPopup()))
    End Sub

    Private Sub lkpFolio_Enter(sender As Object, e As EventArgs) Handles lkpFolio.Enter
        BeginInvoke(New MethodInvoker(Sub() CType(sender, GridLookUpEdit).ShowPopup()))
    End Sub

    Private Sub lkpComuna_Enter(sender As Object, e As EventArgs) Handles lkpComuna.Enter
        BeginInvoke(New MethodInvoker(Sub() CType(sender, GridLookUpEdit).ShowPopup()))
    End Sub

    Private Sub lkpPropiedad_Enter(sender As Object, e As EventArgs) Handles lkpPropiedad.Enter
        BeginInvoke(New MethodInvoker(Sub() CType(sender, GridLookUpEdit).ShowPopup()))
    End Sub

    Private Sub lkpTieneVeh_Enter(sender As Object, e As EventArgs) Handles lkpTieneVeh.Enter
        BeginInvoke(New MethodInvoker(Sub() CType(sender, GridLookUpEdit).ShowPopup()))
    End Sub

    Private Sub btnGuardarHogar_Click(sender As Object, e As EventArgs) Handles btnGuardarHogar.Click

        Me.pressGrabarHogar = True
        'Revisar completitud de datos

        If hogarCompleto() Then

            'Validador de montos de arriendo, dividendo y estimación de arriendo
            If Not validaMontosPropiedad() Then
                Return
            End If

            'Grabar hogar en base de datos con EstadoEncuesta = 1 
            Dim nuevoHogar As HogarRow = datasetEOD.Hogar.NewHogarRow

            nuevoHogar.Hogar = Me.lkpFolio.EditValue.ToString
            nuevoHogar.Zona = Me.lkpZona.EditValue.ToString
            nuevoHogar.Manzana = Me.lkpManzana.EditValue.ToString
            nuevoHogar.Comuna = Me.lkpComuna.EditValue.ToString
            nuevoHogar.NombreCalle = Me.txtCalle.Text
            nuevoHogar.IDEncuestador = My.Settings.IdUsuario
            nuevoHogar.FechaVisita1 = DateTime.Now
            nuevoHogar.Propiedad = Me.lkpPropiedad.EditValue.ToString
            nuevoHogar.Telefono = Me.txtTelefono.Text
            nuevoHogar.TipoViviendaActual = Me.lkpTipoVivienda.EditValue.ToString
            nuevoHogar.IndicaGFT = Me.lkpIndicaGFT.EditValue
            If nuevoHogar.IndicaGFT Then
                nuevoHogar.GastoFamiliarTransporte = Me.txtMontoGFT.Text
            End If

            If dataTableWaypoints IsNot Nothing Then
                Dim rowWaypoint As DataRow = dataTableWaypoints.Rows(cbWaypoint.SelectedIndex)
                nuevoHogar.DirCoordX = rowWaypoint.Item("Longitude")
                nuevoHogar.DirCoordY = rowWaypoint.Item("Latitude")
                If nuevoHogar.TipoViviendaActual = 2 OrElse nuevoHogar.TipoViviendaActual = 3 Then
                    'Comprobar coordenadas

                End If
            End If

            If Me.txtNumero.Text <> "" Then
                nuevoHogar.Numero = Me.txtNumero.Text
            End If

            If Me.txtCasaDepto.Text <> "" Then
                nuevoHogar.CasaDepto = Me.txtCasaDepto.Text
            End If



            Select Case nuevoHogar.Propiedad
                Case 1
                    nuevoHogar.NoSabeNoResponde = Me.chkNSNREstima.Checked
                    If Not nuevoHogar.NoSabeNoResponde Then
                        nuevoHogar.MontoEst = Me.txtEstimaArriendo.Text
                    End If
                Case 4
                    nuevoHogar.NoSabeNoResponde = Me.chkNSNREstima.Checked
                    If Not nuevoHogar.NoSabeNoResponde Then
                        nuevoHogar.MontoEst = Me.txtEstimaArriendo.Text
                    End If
                    nuevoHogar.PropiedadOtra = Me.txtPropiedadOtra.Text
                Case 2
                    nuevoHogar.NoSabeNoResponde = Me.chkNSNRDividendo.Checked
                    If Not nuevoHogar.NoSabeNoResponde Then
                        nuevoHogar.MontoDiv = Me.txtDividendo.Text
                    End If
                Case 3
                    nuevoHogar.NoSabeNoResponde = Me.chkNSNRArriendo.Checked
                    If Not nuevoHogar.NoSabeNoResponde Then
                        nuevoHogar.MontoArr = Me.txtArriendo.Text
                    End If
            End Select

            nuevoHogar.EstadoEncuesta = 1

            validadorHogar.Hogar = nuevoHogar.Hogar

            Try
                Me.hogar = nuevoHogar.Hogar
                datasetEOD.Hogar.Rows.Add(nuevoHogar)
                datasetEOD.ValidaHogar.Rows.Add(validadorHogar)
                ValidaHogarTableAdapter.Update(Me.datasetEOD.ValidaHogar)
                ValidaHogarTableAdapter.Fill(Me.datasetEOD.ValidaHogar)
                Dim resultadoUpdate As Integer = HogarTableAdapter.Update(Me.datasetEOD.Hogar)
                Dim resultadoFill As Integer = HogarTableAdapter.Fill(Me.datasetEOD.Hogar)
                ResumenHogaresTableAdapter1.Fill(Me.datasetEOD.ResumenHogares)
                Me.Text = "Ingresando hogar " & Me.lkpFolio.EditValue.ToString & " - " & Me.txtCalle.Text & " " & Me.txtNumero.Text & " " & Me.txtCasaDepto.Text


                'Comprobar si respondió tener vehículos para habilitar tabVehiculo
                If lkpTieneVeh.EditValue.ToString = "1" Then
                    Me.tabPageVehículos.PageVisible = True
                    Me.lkpTipoVeh.Focus()
                    Me.tabPaneHogar.SelectedPage = Me.tabPageVehículos

                Else
                    Me.tabPagePersonas.PageVisible = True
                    Me.tabPaneHogar.SelectedPage = Me.tabPagePersonas
                    Me.txtNombrePila.Focus()
                End If

                Me.pressGrabarHogar = False

            Catch ex As Exception
                MessageBox.Show("Error al guardar hogar. Intente nuevamente" + vbCrLf + vbCrLf + ex.Message + vbCrLf + vbCrLf + ex.StackTrace, "Datos no guardados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            MessageBox.Show("No ha contestado las preguntas mínimas para continuar con la encuesta. Por favor, complete los campos marcados con rojo.", "Datos insuficientes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If


    End Sub

    Private Sub lkpZona_EditValueChanged(sender As Object, e As EventArgs) Handles lkpZona.EditValueChanged
        If lkpZona.EditValue IsNot Nothing AndAlso lkpZona.EditValue.ToString <> "" Then
            ManzanasCatTableAdapter.FillBy(datasetEOD.ManzanasCat, Me.lkpZona.EditValue)
        End If
    End Sub

    Private Sub lkpManzana_EditValueChanged(sender As Object, e As EventArgs) Handles lkpManzana.EditValueChanged
        If lkpManzana.EditValue IsNot Nothing AndAlso lkpManzana.EditValue.ToString <> "" Then
            CatastroHogaresTableAdapter.FillBy(datasetEOD.CatastroHogares, Me.lkpManzana.EditValue)
        End If
    End Sub

    Private Sub lkpFolio_EditValueChanged(sender As Object, e As EventArgs) Handles lkpFolio.EditValueChanged
        If lkpFolio.EditValue IsNot Nothing AndAlso lkpFolio.EditValue.ToString <> "" Then
            'Comprobar si ya ha sido encuestado
            Dim objConn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\MASCARA REFERENCIA_VF.accdb")
            objConn.Open()

            Dim objCommand As New OleDbCommand("select hogar from hogar where hogar = ?", objConn)
            Dim parametro As New OleDbParameter("hogar", Me.lkpFolio.EditValue.ToString)
            objCommand.Parameters.Add(parametro)

            Dim reader As OleDbDataReader = objCommand.ExecuteReader()

            While reader.Read()
                If reader.Item("hogar").ToString <> "" Then
                    'hogar fue encuestado, alertar
                    MessageBox.Show("Este hogar ya ha sido encuestado. Por favor, escoja otro folio.", "Hogar ya encuestado", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.lkpFolio.EditValue = -1
                    Me.lkpFolio_Enter(Me.lkpFolio, Nothing)
                End If

            End While

            'hogar no fue encuestado, llenar datos
            Dim edit As GridLookUpEdit = TryCast(sender, GridLookUpEdit)
            Dim row As DataRowView = TryCast(edit.Properties.GetRowByKeyValue(edit.EditValue), DataRowView)
            If Not row Is Nothing Then

                validadorHogar.Hogar = lkpFolio.EditValue

                Me.txtCalle.Text = IIf(row.Item("calle") Is DBNull.Value, "", row.Item("calle").ToString)
                Me.txtNumero.Text = IIf(row.Item("numero") Is DBNull.Value, "", row.Item("numero").ToString)
                Me.txtCasaDepto.Text = IIf(row.Item("casadepto") Is DBNull.Value, "", row.Item("casadepto").ToString)
                Me.lkpComuna.EditValue = IIf(row.Item("comuna") Is DBNull.Value, "", row.Item("comuna").ToString)
                Me.lkpTipoVivienda.EditValue = IIf(row.Item("tipovivienda") Is DBNull.Value, "", row.Item("tipovivienda").ToString)
                Me.txtReferenciaHogar.Text = IIf(row.Item("observacion") Is DBNull.Value, "", row.Item("observacion").ToString)

                Me.cbWaypoint.Focus()

                Me.ResumenVehiculosBindingSource.Filter = "hogar = " & lkpFolio.EditValue.ToString
                Me.ResumenPersonasBindingSource.Filter = "hogar = " & lkpFolio.EditValue.ToString
            End If

            reader.Close()
            objCommand.Dispose()
            objConn.Close()
        End If
    End Sub

    Private Sub btnGuardarVehiculo_Click(sender As Object, e As EventArgs) Handles btnGuardarVehiculo.Click
        Me.pressGrabarVehiculo = True

        If vehiculoCompleto() Then
            'Grabar vehiculo en base de datos 
            Dim nuevoVehiculo As VehiculoRow = datasetEOD.Vehiculo.NewVehiculoRow

            nuevoVehiculo.Hogar = Me.hogar
            nuevoVehiculo.Vehículo = Me.numVeh + 1
            nuevoVehiculo.TipoVeh = Integer.Parse(Me.lkpTipoVeh.EditValue.ToString)
            nuevoVehiculo.Propiedad = Integer.Parse(Me.lkpPropiedadVeh.EditValue.ToString)
            nuevoVehiculo.PropiedadOtro = Me.txtPropiedadVehOtro.Text
            nuevoVehiculo.AnioFabricacion = Integer.Parse(Me.txtAnioFabricacion.Text)
            nuevoVehiculo.TipoMotor = Integer.Parse(Me.lkpTipoMotor.EditValue.ToString)

            Try
                datasetEOD.Vehiculo.Rows.Add(nuevoVehiculo)
                Dim resultadoUpdate As Integer = VehiculoTableAdapter.Update(Me.datasetEOD.Vehiculo)
                Dim resultadoFill As Integer = VehiculoTableAdapter.Fill(Me.datasetEOD.Vehiculo)
                ResumenVehiculosTableAdapter.Fill(Me.datasetEOD.ResumenVehiculos)
                MessageBox.Show("Vehículo guardado exitosamente", "Datos guardados", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.numVeh += 1

                'Comprobar si registra otro vehículo para limpiar o pasar a siguiente tab
                If lkpOtroVeh.EditValue = 1 Then
                    'Crear nuevo vehículo
                    Me.limpiarVehiculo()
                    Me.pressGrabarVehiculo = False
                    Me.lkpTipoVeh.Focus()
                Else
                    'Pasar a ingresar personas
                    Me.tabPagePersonas.PageVisible = True
                    Me.tabPaneHogar.SelectedPage = Me.tabPagePersonas
                    Me.txtNombrePila.Focus()
                End If
                Me.pressGrabarVehiculo = False

            Catch ex As Exception
                MessageBox.Show("Error al guardar vehículo. Intente nuevamente" + ex.StackTrace, "Datos no guardados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            MessageBox.Show("No ha contestado las preguntas mínimas para continuar con la encuesta. Por favor, complete los campos marcados con rojo.", "Datos insuficientes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub limpiarVehiculo()
        Me.lkpTipoVeh.EditValue = -1
        Me.lkpPropiedadVeh.EditValue = -1
        Me.lkpOtroVeh.EditValue = -1
        Me.txtPropiedadVehOtro.Text = ""
        Me.txtAnioFabricacion.Text = ""
        Me.lkpTipoMotor.EditValue = -1
    End Sub

    Private Sub lkpSexo_Enter(sender As Object, e As EventArgs) Handles lkpSexo.Enter
        BeginInvoke(New MethodInvoker(Sub() CType(sender, GridLookUpEdit).ShowPopup()))
    End Sub

    Private Sub lkpRelacion_Enter(sender As Object, e As EventArgs) Handles lkpRelacion.Enter
        BeginInvoke(New MethodInvoker(Sub() CType(sender, GridLookUpEdit).ShowPopup()))
    End Sub

    Private Sub lkpEstudios_Enter(sender As Object, e As EventArgs) Handles lkpEstudios.Enter
        BeginInvoke(New MethodInvoker(Sub() CType(sender, GridLookUpEdit).ShowPopup()))
    End Sub

    Private Sub lkpEstudiosCompletos_Enter(sender As Object, e As EventArgs) Handles lkpEstudiosCompletos.Enter
        BeginInvoke(New MethodInvoker(Sub() CType(sender, GridLookUpEdit).ShowPopup()))
    End Sub

    Private Sub lkpLicencia_Enter(sender As Object, e As EventArgs) Handles lkpLicencia.Enter
        BeginInvoke(New MethodInvoker(Sub() CType(sender, GridLookUpEdit).ShowPopup()))
    End Sub

    Private Sub chkActividad_Enter(sender As Object, e As EventArgs) Handles chkActividad.Enter
        BeginInvoke(New MethodInvoker(Sub() CType(sender, CheckedComboBoxEdit).ShowPopup()))
    End Sub

    Private Sub lkpComunaTrabajo_Enter(sender As Object, e As EventArgs) Handles lkpComunaTrabajo.Enter
        BeginInvoke(New MethodInvoker(Sub() CType(sender, GridLookUpEdit).ShowPopup()))
    End Sub

    Private Sub lkpCalle1Trabajo_Enter(sender As Object, e As EventArgs) Handles lkpCalle1Trabajo.Enter
        BeginInvoke(New MethodInvoker(Sub() CType(sender, GridLookUpEdit).ShowPopup()))
    End Sub

    Private Sub lkpCalle2Trabajo_Enter(sender As Object, e As EventArgs) Handles lkpCalle2Trabajo.Enter
        BeginInvoke(New MethodInvoker(Sub() CType(sender, GridLookUpEdit).ShowPopup()))
    End Sub

    Private Sub lkpHitoTrabajo_Enter(sender As Object, e As EventArgs) Handles lkpHitoTrabajo.Enter
        BeginInvoke(New MethodInvoker(Sub() CType(sender, GridLookUpEdit).ShowPopup()))
    End Sub

    Private Sub lkpManzanaTrabajo_Enter(sender As Object, e As EventArgs) Handles lkpManzanaTrabajo.Enter
        BeginInvoke(New MethodInvoker(Sub() CType(sender, LookUpEdit).ShowPopup()))
    End Sub

    Private Sub lkpJornadaTrabajo_Enter(sender As Object, e As EventArgs) Handles lkpJornadaTrabajo.Enter
        BeginInvoke(New MethodInvoker(Sub() CType(sender, GridLookUpEdit).ShowPopup()))
    End Sub

    Private Sub lkpComunaEstudio_Enter(sender As Object, e As EventArgs) Handles lkpComunaEstudio.Enter
        BeginInvoke(New MethodInvoker(Sub() CType(sender, GridLookUpEdit).ShowPopup()))
    End Sub

    Private Sub lkpCalle1Estudio_Enter(sender As Object, e As EventArgs) Handles lkpCalle1Estudio.Enter
        BeginInvoke(New MethodInvoker(Sub() CType(sender, GridLookUpEdit).ShowPopup()))
    End Sub

    Private Sub lkpCalle2Estudio_Enter(sender As Object, e As EventArgs) Handles lkpCalle2Estudio.Enter
        BeginInvoke(New MethodInvoker(Sub() CType(sender, GridLookUpEdit).ShowPopup()))
    End Sub

    Private Sub lkpHitoEstudio_Enter(sender As Object, e As EventArgs) Handles lkpHitoEstudio.Enter
        BeginInvoke(New MethodInvoker(Sub() CType(sender, GridLookUpEdit).ShowPopup()))
    End Sub

    Private Sub lkpManzanaEstudio_Enter(sender As Object, e As EventArgs) Handles lkpManzanaEstudio.Enter
        BeginInvoke(New MethodInvoker(Sub() CType(sender, LookUpEdit).ShowPopup()))
    End Sub

    Private Sub lkpDondeEstudia_Enter(sender As Object, e As EventArgs) Handles lkpDondeEstudia.Enter
        BeginInvoke(New MethodInvoker(Sub() CType(sender, GridLookUpEdit).ShowPopup()))
    End Sub

    Private Sub lkpTieneTNE_Enter(sender As Object, e As EventArgs) Handles lkpTieneTNE.Enter
        BeginInvoke(New MethodInvoker(Sub() CType(sender, GridLookUpEdit).ShowPopup()))
    End Sub

    Private Sub lkpOtraPersona_Enter(sender As Object, e As EventArgs) Handles lkpOtraPersona.Enter
        BeginInvoke(New MethodInvoker(Sub() CType(sender, GridLookUpEdit).ShowPopup()))
    End Sub

    Private Sub chkActividad_EditValueChanged(sender As Object, e As EventArgs) Handles chkActividad.EditValueChanged
        If Me.txtAnoNacimiento.Text <> "" Then
            Dim trabaja As Boolean = chkActividad.Properties.GetItems.GetCheckedValues.Contains(1)
            Dim estudia As Boolean = chkActividad.Properties.GetItems.GetCheckedValues.Contains(2)
            Dim jubilado As Boolean = chkActividad.Properties.GetItems.GetCheckedValues.Contains(3)
            Dim duenoCasa As Boolean = chkActividad.Properties.GetItems.GetCheckedValues.Contains(4)
            Dim sinActividad As Boolean = chkActividad.Properties.GetItems.GetCheckedValues.Contains(5)
            Dim otraActividad As Boolean = chkActividad.Properties.GetItems.GetCheckedValues.Contains(6)
            Dim edadEncuestado As Integer = DateTime.Now.Year - Convert.ToInt32(Me.txtAnoNacimiento.Text.ToString)
            Dim relacion As Integer
            Integer.TryParse(Me.lkpRelacion.EditValue, relacion)

            Me.lkpComunaTrabajo.Visible = False
            Me.txtComunaTrabajoOtra.Visible = False
            Me.lkpCalle1Trabajo.Visible = False
            Me.lkpCalle2Trabajo.Visible = False
            Me.lkpHitoTrabajo.Visible = False
            Me.lkpManzanaTrabajo.Visible = False
            Me.lkpJornadaTrabajo.Visible = False

            Me.lkpComunaEstudio.Visible = False
            Me.txtComunaEstudioOtra.Visible = False
            Me.lkpCalle1Estudio.Visible = False
            Me.lkpCalle2Estudio.Visible = False
            Me.lkpHitoEstudio.Visible = False
            Me.lkpManzanaEstudio.Visible = False
            Me.lkpDondeEstudia.Visible = False
            Me.lkpTieneTNE.Visible = False

            Me.txtActividadOtra.Visible = False
            Me.lblActividadOtra.Visible = False
            Me.spcTrabajaEstudia.Visible = False

            If trabaja And Not estudia Then
                spcTrabajaEstudia.Visible = True
                spcTrabajaEstudia.CollapsePanel = SplitCollapsePanel.Panel2
                spcTrabajaEstudia.Collapsed = True

                Me.lkpComunaTrabajo.Visible = True
                Me.txtComunaTrabajoOtra.Visible = True
                Me.lkpCalle1Trabajo.Visible = True
                Me.lkpCalle2Trabajo.Visible = True
                Me.lkpHitoTrabajo.Visible = True
                Me.lkpManzanaTrabajo.Visible = True
                Me.lkpJornadaTrabajo.Visible = True
            End If
            If trabaja And estudia Then
                spcTrabajaEstudia.Visible = True
                spcTrabajaEstudia.Collapsed = False

                Me.lkpComunaTrabajo.Visible = True
                Me.txtComunaTrabajoOtra.Visible = True
                Me.lkpCalle1Trabajo.Visible = True
                Me.lkpCalle2Trabajo.Visible = True
                Me.lkpHitoTrabajo.Visible = True
                Me.lkpManzanaTrabajo.Visible = True
                Me.lkpJornadaTrabajo.Visible = True

                Me.lkpComunaEstudio.Visible = True
                Me.txtComunaEstudioOtra.Visible = True
                Me.lkpCalle1Estudio.Visible = True
                Me.lkpCalle2Estudio.Visible = True
                Me.lkpHitoEstudio.Visible = True
                Me.lkpManzanaEstudio.Visible = True
                Me.lkpDondeEstudia.Visible = True
                Me.lkpTieneTNE.Visible = True
            End If
            If estudia And Not trabaja Then
                spcTrabajaEstudia.Visible = True
                spcTrabajaEstudia.CollapsePanel = SplitCollapsePanel.Panel1
                spcTrabajaEstudia.Collapsed = True

                Me.lkpComunaEstudio.Visible = True
                Me.txtComunaEstudioOtra.Visible = True
                Me.lkpCalle1Estudio.Visible = True
                Me.lkpCalle2Estudio.Visible = True
                Me.lkpHitoEstudio.Visible = True
                Me.lkpManzanaEstudio.Visible = True
                Me.lkpDondeEstudia.Visible = True
                Me.lkpTieneTNE.Visible = True
            End If
            If otraActividad Then
                txtActividadOtra.Visible = True
                lblActividadOtra.Visible = True
            End If

            'Validar actividad
            'Estudiante de más de 30 años
            If edadEncuestado > 30 And estudia Then
                validadorPersona.Val10 = True
                Dim confirma As DialogResult = MessageBox.Show("Ha indicado que estudia y tiene más de 30 años, ¿confirma que es correcto?", "Verificación de datos", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                If confirma = Windows.Forms.DialogResult.No Then
                    chkActividad.EditValue = ""
                    Me.spcTrabajaEstudia.Visible = False
                    chkActividad_Enter(chkActividad, Nothing)
                    validadorPersona.Val10 = False
                Else
                    validadorPersona.Val10Resp = True
                End If
            End If

            'Jubilado tiene otra actividad adicional
            If jubilado AndAlso (trabaja Or estudia Or otraActividad) Then
                validadorPersona.Val19 = True
                Dim confirma As DialogResult = MessageBox.Show("Ha indicado que es jubilado y además tiene otra actividad, ¿confirma que es correcto?", "Verificación de datos", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                If confirma = Windows.Forms.DialogResult.No Then
                    chkActividad.EditValue = ""
                    Me.spcTrabajaEstudia.Visible = False
                    chkActividad_Enter(chkActividad, Nothing)
                    validadorPersona.Val19 = False
                Else
                    validadorPersona.Val19Resp = True
                End If
            End If

            'Sin actividad, y marca además otra alternativa
            If sinActividad AndAlso (trabaja Or estudia Or otraActividad Or jubilado Or duenoCasa) Then
                MessageBox.Show("Ha indicado que no tiene actividad, sin embargo seleccionó otra alternativa adicional, corrija para continuar.", "Dato inconsistente", MessageBoxButtons.OK, MessageBoxIcon.Error)
                chkActividad.EditValue = ""
                Me.spcTrabajaEstudia.Visible = False
                chkActividad_Enter(chkActividad, Nothing)
            End If

            'Menor de edad con actividad de adulto
            Dim actividadAdulto As Boolean = trabaja Or jubilado Or duenoCasa
            If actividadAdulto And edadEncuestado < 18 Then
                validadorPersona.Val11 = True
                If MessageBox.Show("Ha indicado una actividad de adulto pero el encuestado es menor de edad, ¿confirma que es correcto?", "Verificación de datos", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.No Then
                    chkActividad.EditValue = ""
                    Me.spcTrabajaEstudia.Visible = False
                    chkActividad_Enter(chkActividad, Nothing)
                    validadorPersona.Val11 = False
                Else
                    validadorPersona.Val11Resp = True
                End If
            End If

            'Trabaja y es servicio doméstico, cargar dirección casa
            If trabaja AndAlso (relacion = 6 OrElse relacion = 7) Then

                'Cargar datos de casa
                Try
                    Dim objConn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\MASCARA REFERENCIA_VF.accdb")
                    objConn.Open()
                    Dim objCommand As New OleDbCommand("select comuna, nombrecalle, numero, manzana from hogar where hogar = ?", objConn)
                    Dim parametro As New OleDbParameter("hogar", Me.hogar)
                    objCommand.Parameters.Add(parametro)

                    Dim comunaHogar As String
                    Dim nombreCalleHogar As String
                    Dim numeroHogar As String
                    Dim manzanaHogar As String

                    Dim reader As OleDbDataReader = objCommand.ExecuteReader()
                    While reader.Read()
                        comunaHogar = reader.Item("comuna")
                        nombreCalleHogar = reader.Item("nombrecalle")
                        numeroHogar = reader.Item("numero")
                        manzanaHogar = reader.Item("manzana")
                    End While

                    'Llena campos comuna y calles con valores hogar
                    Me.lkpComunaTrabajo.EditValue = comunaHogar
                    Me.lkpCalle1Trabajo.EditValue = nombreCalleHogar
                    Me.lkpCalle2Trabajo.EditValue = numeroHogar

                    'Llenado de campo manzana con valor hogar
                    For i As Integer = 0 To 3
                        If Not Me.lkpManzanaTrabajo.Properties.Columns.GetVisibleColumn(i) Is Nothing Then
                            Me.lkpManzanaTrabajo.Properties.Columns.Remove(Me.lkpManzanaTrabajo.Properties.Columns.GetVisibleColumn(i))
                        End If
                    Next

                    Try
                        Dim args As DevExpress.XtraEditors.Controls.CloseUpEventArgs = New DevExpress.XtraEditors.Controls.CloseUpEventArgs(Nothing)
                        args.AcceptValue = True
                        args.Value = numeroHogar
                        Me.lkpCalle2Trabajo_CloseUp(lkpCalle2Trabajo, args)
                        Me.lkpManzanaTrabajo.EditValue = manzanaHogar
                    Catch ex As Exception

                    End Try

                    reader.Close()
                    objCommand.Dispose()
                    objConn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message + vbCrLf + vbCrLf + ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try

                'Asignar jornada completa
                Me.lkpJornadaTrabajo.EditValue = 1

            End If

        End If
    End Sub

    Private Sub lkpEstudios_EditValueChanged(sender As Object, e As EventArgs) Handles lkpEstudios.EditValueChanged
        If txtAnoNacimiento.Text <> "" Then
            Dim opcion As Integer = Convert.ToInt32(IIf(lkpEstudios.EditValue IsNot Nothing AndAlso lkpEstudios.EditValue.ToString <> "", lkpEstudios.EditValue.ToString, 0))
            Dim edadEncuestado As Integer = DateTime.Now.Year - Convert.ToInt32(Me.txtAnoNacimiento.Text.ToString)

            Me.splitEstudios.Collapsed = True
            Me.lblEstudiosCompletos.Visible = False
            Me.lkpEstudiosCompletos.Visible = False

            Select Case opcion
                Case 3, 4, 5
                    Me.splitEstudios.Collapsed = False
                    Me.lblEstudiosCompletos.Visible = True
                    Me.lkpEstudiosCompletos.Visible = True
                Case Else
                    Me.splitEstudios.Collapsed = True
                    Me.lblEstudiosCompletos.Visible = False
                    Me.lkpEstudiosCompletos.Visible = False
            End Select

            'Validar nivel de estudios con edad del encuestado

            'Estudios primarios con más de 16 años
            If edadEncuestado > 16 And opcion = 3 Then
                If MessageBox.Show("Ha indicado que tiene estudios primarios con más de 16 años, ¿confirma que es correcto?", "Verificación de datos", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.No Then
                    lkpEstudios.EditValue = ""
                End If
            End If

            'Estudios secundarios con menos de 12 años
            If edadEncuestado < 12 And opcion = 4 Then
                MessageBox.Show("Ha indicado que tiene estudios secundarios con menos de 12 años. Corrija la información.", "Dato no válido", MessageBoxButtons.OK, MessageBoxIcon.Error)
                lkpEstudios.EditValue = ""
            End If

            'Estudios superiores con menos de 17 años
            If edadEncuestado < 17 And opcion = 5 Then
                MessageBox.Show("Ha indicado que tiene estudios superiores con menos de 17 años. Corrija la información.", "Dato no válido", MessageBoxButtons.OK, MessageBoxIcon.Error)
                lkpEstudios.EditValue = ""
            End If
        End If

    End Sub


    Private Sub lkpCalle1Trabajo_EditValueChanged(sender As Object, e As EventArgs) Handles lkpCalle1Trabajo.EditValueChanged
        If lkpCalle1Trabajo.EditValue IsNot Nothing AndAlso Me.lkpCalle1Trabajo.EditValue.ToString <> "" Then
            Dim calleQuery As String = Me.lkpCalle1Trabajo.EditValue.ToString '.Replace("'", ControlChars.Quote)
            ConsultaCalle2TrabajoTableAdapter.FillBy(datasetEOD.ConsultaCalle2Trabajo, calleQuery)
        End If
    End Sub

    Private Sub lkpHitoTrabajo_EditValueChanged(sender As Object, e As EventArgs) Handles lkpHitoTrabajo.EditValueChanged
        If lkpHitoTrabajo.EditValue IsNot Nothing AndAlso lkpHitoTrabajo.EditValue.ToString <> "" Then
            Dim edit As GridLookUpEdit = TryCast(sender, GridLookUpEdit)
            Dim row As DataRowView = TryCast(edit.Properties.GetRowByKeyValue(edit.EditValue), DataRowView)
            If Not row Is Nothing Then
                Me.x_trabajo.Text = row.Item("x")
                Me.y_trabajo.Text = row.Item("y")
            End If


            Dim objConn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\MASCARA REFERENCIA_VF.accdb")
            objConn.Open()

            Dim objCommand As New OleDbCommand("select hitomanzana from hito where hito = ?", objConn)
            Dim parametro1 As New OleDbParameter("hito", Me.lkpHitoTrabajo.EditValue)
            objCommand.Parameters.Add(parametro1)

            Dim objAdapter As New OleDbDataAdapter(objCommand)
            Dim objDataSet As New DataSet("Manzanastrabajo")

            For i As Integer = 0 To 3
                If Not Me.lkpManzanaTrabajo.Properties.Columns.GetVisibleColumn(i) Is Nothing Then
                    Me.lkpManzanaTrabajo.Properties.Columns.Remove(Me.lkpManzanaTrabajo.Properties.Columns.GetVisibleColumn(i))
                End If
            Next

            Try
                objAdapter.Fill(objDataSet, "Manzanastrabajo")
                Dim objTabla As DataTable = objDataSet.Tables("Manzanastrabajo")
                Me.lkpManzanaTrabajo.Properties.DataSource = objTabla
                Me.lkpManzanaTrabajo.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("hitomanzana", "hitomanzana", 5, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
                Me.lkpManzanaTrabajo.Properties.DisplayMember = "hitomanzana"
                Me.lkpManzanaTrabajo.Properties.ValueMember = "hitomanzana"
                Me.lkpManzanaTrabajo.ItemIndex = 0
            Catch ex As Exception
                MessageBox.Show(ex.Message + vbCrLf + vbCrLf + ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            'borrar manzana
            For i As Integer = 0 To 3
                If Not Me.lkpManzanaTrabajo.Properties.Columns.GetVisibleColumn(i) Is Nothing Then
                    Me.lkpManzanaTrabajo.Properties.Columns.Remove(Me.lkpManzanaTrabajo.Properties.Columns.GetVisibleColumn(i))
                End If
            Next
            lkpManzanaTrabajo.Properties.DataSource = Nothing

            'si hay calle 2, lanzar evento closeup
            If lkpCalle2Trabajo.EditValue IsNot Nothing AndAlso lkpCalle2Trabajo.EditValue.ToString <> "" Then
                Dim args As DevExpress.XtraEditors.Controls.CloseUpEventArgs = New DevExpress.XtraEditors.Controls.CloseUpEventArgs(Nothing)
                args.AcceptValue = True
                args.Value = Me.lkpCalle2Trabajo.EditValue
                Me.lkpCalle2Trabajo_CloseUp(lkpCalle2Trabajo, args)
            End If
        End If
    End Sub

    Private Sub lkpCalle1Estudio_EditValueChanged(sender As Object, e As EventArgs) Handles lkpCalle1Estudio.EditValueChanged
        If lkpCalle1Estudio.EditValue IsNot Nothing AndAlso Me.lkpCalle1Estudio.EditValue.ToString <> "" Then
            Dim calleQuery As String = Me.lkpCalle1Estudio.EditValue.ToString '.Replace("'", ControlChars.Quote)
            ConsultaCalle2EstudioTableAdapter.FillBy(datasetEOD.ConsultaCalle2Estudio, calleQuery)
        End If
    End Sub

    Private Sub lkpHitoEstudio_EditValueChanged(sender As Object, e As EventArgs) Handles lkpHitoEstudio.EditValueChanged
        If lkpHitoEstudio.EditValue IsNot Nothing AndAlso lkpHitoEstudio.EditValue.ToString <> "" Then
            Dim edit As GridLookUpEdit = TryCast(sender, GridLookUpEdit)
            Dim row As DataRowView = TryCast(edit.Properties.GetRowByKeyValue(edit.EditValue), DataRowView)
            If Not row Is Nothing Then
                Me.x_estudio.Text = row.Item("x")
                Me.y_estudio.Text = row.Item("y")
            End If


            Dim objConn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\MASCARA REFERENCIA_VF.accdb")
            objConn.Open()

            Dim objCommand As New OleDbCommand("select hitomanzana from hito where hito = ?", objConn)
            Dim parametro1 As New OleDbParameter("hito", Me.lkpHitoEstudio.EditValue)
            objCommand.Parameters.Add(parametro1)

            Dim objAdapter As New OleDbDataAdapter(objCommand)
            Dim objDataSet As New DataSet("Manzanasestudio")

            For i As Integer = 0 To 3
                If Not Me.lkpManzanaEstudio.Properties.Columns.GetVisibleColumn(i) Is Nothing Then
                    Me.lkpManzanaEstudio.Properties.Columns.Remove(Me.lkpManzanaEstudio.Properties.Columns.GetVisibleColumn(i))
                End If
            Next

            Try
                objAdapter.Fill(objDataSet, "Manzanasestudio")
                Dim objTabla As DataTable = objDataSet.Tables("Manzanasestudio")
                Me.lkpManzanaEstudio.Properties.DataSource = objTabla
                Me.lkpManzanaEstudio.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("hitomanzana", "hitomanzana", 5, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
                Me.lkpManzanaEstudio.Properties.DisplayMember = "hitomanzana"
                Me.lkpManzanaEstudio.Properties.ValueMember = "hitomanzana"
                Me.lkpManzanaEstudio.ItemIndex = 0
            Catch ex As Exception
                MessageBox.Show(ex.Message + vbCrLf + vbCrLf + ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            'borrar manzana
            For i As Integer = 0 To 3
                If Not Me.lkpManzanaEstudio.Properties.Columns.GetVisibleColumn(i) Is Nothing Then
                    Me.lkpManzanaEstudio.Properties.Columns.Remove(Me.lkpManzanaEstudio.Properties.Columns.GetVisibleColumn(i))
                End If
            Next
            lkpManzanaEstudio.Properties.DataSource = Nothing

            'si hay calle 2, lanzar evento closeup
            If lkpCalle2Estudio.EditValue IsNot Nothing AndAlso lkpCalle2Estudio.EditValue.ToString <> "" Then
                Dim args As DevExpress.XtraEditors.Controls.CloseUpEventArgs = New DevExpress.XtraEditors.Controls.CloseUpEventArgs(Nothing)
                args.AcceptValue = True
                args.Value = Me.lkpCalle2Estudio.EditValue
                Me.lkpCalle2Estudio_CloseUp(lkpCalle2Estudio, args)
            End If
        End If
    End Sub

    Private Sub lkpComunaTrabajo_EditValueChanged(sender As Object, e As EventArgs) Handles lkpComunaTrabajo.EditValueChanged
        Dim opcion As Integer = Convert.ToInt32(IIf(lkpComunaTrabajo.EditValue IsNot Nothing AndAlso lkpComunaTrabajo.EditValue.ToString <> "", lkpComunaTrabajo.EditValue, 0))
        Me.lblComunaTrabajoOtra.Visible = False
        Me.txtComunaTrabajoOtra.Visible = False

        Me.lkpCalle1Trabajo.Visible = False
        Me.lblCalle1Trabajo.Visible = False
        Me.lkpCalle2Trabajo.Visible = False
        Me.lblCalle2Trabajo.Visible = False
        Me.lkpHitoTrabajo.Visible = False
        Me.lblHitoTrabajo.Visible = False
        Me.lkpManzanaTrabajo.Visible = False
        Me.lblManzanaTrabajo.Visible = False

        If opcion = 1 Then
            Me.lblComunaTrabajoOtra.Visible = True
            Me.txtComunaTrabajoOtra.Visible = True
        ElseIf (opcion = 2) Then
            Me.lkpCalle1Trabajo.Visible = True
            Me.lblCalle1Trabajo.Visible = True
            Me.lkpCalle2Trabajo.Visible = True
            Me.lblCalle2Trabajo.Visible = True
            Me.lkpHitoTrabajo.Visible = True
            Me.lblHitoTrabajo.Visible = True
            Me.lkpManzanaTrabajo.Visible = True
            Me.lblManzanaTrabajo.Visible = True
        End If
    End Sub

    Private Sub lkpComunaEstudio_EditValueChanged(sender As Object, e As EventArgs) Handles lkpComunaEstudio.EditValueChanged
        Dim opcion As Integer = Convert.ToInt32(IIf(lkpComunaEstudio.EditValue IsNot Nothing AndAlso lkpComunaEstudio.EditValue.ToString <> "", lkpComunaEstudio.EditValue, 0))
        Me.lblComunaEstudioOtra.Visible = False
        Me.txtComunaEstudioOtra.Visible = False

        Me.lkpCalle1Estudio.Visible = False
        Me.lblCalle1Estudio.Visible = False
        Me.lkpCalle2Estudio.Visible = False
        Me.lblCalle2Estudio.Visible = False
        Me.lkpHitoEstudio.Visible = False
        Me.lblHitoEstudio.Visible = False
        Me.lkpManzanaEstudio.Visible = False
        Me.lblManzanaEstudio.Visible = False

        If opcion = 1 Then
            Me.lblComunaEstudioOtra.Visible = True
            Me.txtComunaEstudioOtra.Visible = True
        ElseIf (opcion = 2) Then
            Me.lkpCalle1Estudio.Visible = True
            Me.lblCalle1Estudio.Visible = True
            Me.lkpCalle2Estudio.Visible = True
            Me.lblCalle2Estudio.Visible = True
            Me.lkpHitoEstudio.Visible = True
            Me.lblHitoEstudio.Visible = True
            Me.lkpManzanaEstudio.Visible = True
            Me.lblManzanaEstudio.Visible = True
        End If
    End Sub


    Private Sub btnGuardarPersona_Click(sender As Object, e As EventArgs) Handles btnGuardarPersona.Click

        If personaCompleta() Then


            'Grabar persona en base de datos 

            Dim nuevaPersona As PersonaRow = datasetEOD.Persona.NewPersonaRow

            nuevaPersona.Persona = Me.numPer + 1
            nuevaPersona.Hogar = Me.hogar
            nuevaPersona.NombrePila = Me.txtNombrePila.Text
            nuevaPersona.AnoNac = Me.txtAnoNacimiento.Text
            nuevaPersona.Sexo = Me.lkpSexo.EditValue
            nuevaPersona.Relacion = Me.lkpRelacion.EditValue
            nuevaPersona.Estudios = Me.lkpEstudios.EditValue
            Select Case nuevaPersona.Estudios
                Case 3, 4, 5
                    nuevaPersona.EstudiosCompletos = Me.lkpEstudiosCompletos.EditValue
            End Select
            If DateTime.Now.Year - nuevaPersona.AnoNac >= 18 Then
                nuevaPersona.LicenciaConducir = Me.lkpLicencia.EditValue
            End If
            nuevaPersona.Actividad = Me.chkActividad.EditValue
            nuevaPersona.ActividadOtra = Me.txtActividadOtra.Text
            nuevaPersona.ViajesLab = 0
            nuevaPersona.ViajesSab = 0
            nuevaPersona.ViajesDom = 0
            nuevaPersona.TieneIngresos = 0
            nuevaPersona.NoViajaLab = -1
            nuevaPersona.NoViajaSab = -1
            nuevaPersona.NoViajaDom = -1
            nuevaPersona.Encuestado = False

            'Validador Servicio doméstico y no trabaja
            If nuevaPersona.Relacion = 6 AndAlso Not nuevaPersona.Actividad.Contains("1") Then
                Dim confirma As DialogResult = MessageBox.Show("Ha indicado que la persona es de Servicio doméstico pero no trabaja, ¿confirma que es correcto?", "Verificación de datos", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                If confirma = Windows.Forms.DialogResult.No Then
                    Me.lkpRelacion.Focus()
                    Return
                End If
            End If

            'Datos de trabajo
            If nuevaPersona.Actividad.Contains("1") Then
                nuevaPersona.ComunaTrabajo = Me.lkpComunaTrabajo.EditValue
                If nuevaPersona.ComunaTrabajo = 2 Then
                    If lkpCalle1Trabajo.EditValue IsNot Nothing Then
                        nuevaPersona.NombreCalle1Trabajo = lkpCalle1Trabajo.EditValue.ToString
                    End If
                    If lkpCalle2Trabajo.EditValue IsNot Nothing Then
                        nuevaPersona.NumeroOCalle2Trabajo = lkpCalle2Trabajo.EditValue.ToString
                    End If
                    If lkpHitoTrabajo.EditValue IsNot Nothing Then
                        nuevaPersona.HitoTrabajo = lkpHitoTrabajo.EditValue.ToString
                    End If
                    If lkpManzanaTrabajo.EditValue IsNot Nothing Then
                        nuevaPersona.ManzanaTrabajo = lkpManzanaTrabajo.EditValue.ToString
                    End If
                    nuevaPersona.DirActividadCoordX = x_trabajo.Text
                    nuevaPersona.DirActividadCoordY = y_trabajo.Text
                ElseIf nuevaPersona.ComunaTrabajo = 1 Then
                    nuevaPersona.ComunaTrabajoOtra = Me.txtComunaTrabajoOtra.Text
                End If
                nuevaPersona.JornadaTrabajo = Me.lkpJornadaTrabajo.EditValue
            Else
                nuevaPersona.ComunaTrabajo = -1
            End If

            'Datos de estudio
            If nuevaPersona.Actividad.Contains("2") Then
                nuevaPersona.ComunaEstudio = Me.lkpComunaEstudio.EditValue
                If nuevaPersona.ComunaEstudio = 2 Then
                    If lkpCalle1Estudio.EditValue IsNot Nothing Then
                        nuevaPersona.NombreCalle1Estudio = lkpCalle1Estudio.EditValue.ToString
                    End If
                    If lkpCalle2Estudio.EditValue IsNot Nothing Then
                        nuevaPersona.NumeroOCalle2Estudio = lkpCalle2Estudio.EditValue.ToString
                    End If
                    If lkpHitoEstudio.EditValue IsNot Nothing Then
                        nuevaPersona.HitoEstudio = lkpHitoEstudio.EditValue.ToString
                    End If
                    If lkpManzanaEstudio.EditValue IsNot Nothing Then
                        nuevaPersona.ManzanaEstudio = lkpManzanaEstudio.EditValue.ToString
                    End If
                    nuevaPersona.DirEstudiosCoordX = x_estudio.Text
                    nuevaPersona.DirEstudiosCoordY = y_estudio.Text
                ElseIf nuevaPersona.ComunaEstudio = 1 Then
                    nuevaPersona.ComunaEstudioOtra = Me.txtComunaEstudioOtra.Text
                End If

                nuevaPersona.DondeEstudia = Me.lkpDondeEstudia.EditValue
                If nuevaPersona.DondeEstudia = 5 Then
                    nuevaPersona.DondeEstudiaOtro = Me.txtDondeEstudiaOtro.Text
                End If
                nuevaPersona.PaseEscolar = Me.lkpTieneTNE.EditValue
            Else
                nuevaPersona.ComunaEstudio = -1
            End If

            validadorPersona.Hogar = nuevaPersona.Hogar
            validadorPersona.Persona = nuevaPersona.Persona

            Try
                datasetEOD.ValidaPersona.Rows.Add(validadorPersona)
                datasetEOD.Persona.Rows.Add(nuevaPersona)

                ValidaPersonaTableAdapter.Update(Me.datasetEOD.ValidaPersona)
                Dim resultadoUpdate As Integer = PersonaTableAdapter.Update(Me.datasetEOD.Persona)
                Dim resultadoFill As Integer = PersonaTableAdapter.Fill(Me.datasetEOD.Persona)
                ResumenPersonasTableAdapter.Fill(Me.datasetEOD.ResumenPersonas)
                MessageBox.Show("Persona guardada exitosamente", "Datos guardados", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.numPer += 1

                'Comprobar si registra otra persona para limpiar o pasar a siguiente tab
                If lkpOtraPersona.EditValue = 1 Then
                    'Crear nueva persona
                    Me.limpiarPersona()
                    Me.txtNombrePila.Focus()
                    validadorPersona = datasetEOD.ValidaPersona.NewValidaPersonaRow
                Else
                    'Pasar a fecha viajes
                    Me.tabPageFecha.PageVisible = True
                    Me.tabPaneHogar.SelectedPage = Me.tabPageFecha
                End If

            Catch ex As Exception
                MessageBox.Show("Error al guardar persona. Intente nuevamente" + vbCrLf + vbCrLf + ex.Message + vbCrLf + vbCrLf + ex.StackTrace, "Datos no guardados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            MessageBox.Show("No ha contestado las preguntas mínimas para continuar con la encuesta. Por favor, complete los campos marcados con rojo.", "Datos insuficientes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If



    End Sub

    Private Sub limpiarPersona()
        Me.txtNombrePila.Text = ""
        Me.txtAnoNacimiento.Text = ""
        Me.lkpSexo.EditValue = -1
        Me.lkpRelacion.EditValue = -1
        Me.lkpEstudiosCompletos.EditValue = -1
        Me.lkpEstudios.EditValue = -1
        Me.lkpLicencia.EditValue = -1
        Me.txtActividadOtra.Text = ""
        Me.lkpComunaTrabajo.EditValue = -1
        Me.txtComunaTrabajoOtra.Text = ""
        Me.lkpCalle1Trabajo.EditValue = Nothing
        Me.lkpCalle2Trabajo.EditValue = Nothing
        Me.lkpHitoTrabajo.EditValue = Nothing
        Me.lkpManzanaTrabajo.Properties.DataSource = Nothing
        Me.lkpJornadaTrabajo.EditValue = -1
        Me.lkpComunaEstudio.EditValue = -1
        Me.txtComunaEstudioOtra.Text = ""
        Me.lkpCalle1Estudio.EditValue = Nothing
        Me.lkpCalle2Estudio.EditValue = Nothing
        Me.lkpHitoEstudio.EditValue = Nothing
        Me.lkpManzanaEstudio.Properties.DataSource = Nothing
        Me.lkpDondeEstudia.EditValue = 0
        Me.lkpTieneTNE.EditValue = -1
        Me.lkpOtraPersona.EditValue = -1
        Me.x_trabajo.Text = "0"
        Me.y_trabajo.Text = "0"
        Me.x_estudio.Text = "0"
        Me.y_estudio.Text = "0"

        For Each item As CheckedListBoxItem In Me.chkActividad.Properties.Items
            If item.CheckState = CheckState.Checked Then
                item.InvertCheckState()
            End If
        Next

    End Sub

    Private Sub btnGuardarEncuesta_Click(sender As Object, e As EventArgs) Handles btnGuardarEncuesta.Click

        Dim filaHogar As datasetEOD.HogarRow
        filaHogar = Me.datasetEOD.Hogar.FindByHogar(Me.lkpFolio.EditValue)
        Dim filaValidador As datasetEOD.ValidaHogarRow
        filaValidador = Me.datasetEOD.ValidaHogar.FindByHogar(Me.lkpFolio.EditValue)

        If modoEdicionHogar = True Then

            filaHogar = Me.datasetEOD.Hogar.FindByHogar(Me.folioAnterior)
            filaValidador = Me.datasetEOD.ValidaHogar.FindByHogar(Me.folioAnterior)

            filaHogar.Hogar = Me.lkpFolio.EditValue
            filaValidador.Hogar = Me.lkpFolio.EditValue
            If fechaCompleta() Then
                If fechaValida() Then

                    Dim fecha As Date = Me.deFechaViajes.EditValue
                    filaHogar.TipoDia = Me.lkpTipoDia.EditValue

                    Select Case filaHogar.TipoDia
                        Case 1
                            filaHogar.FechaViajesLab = Me.deFechaViajes.EditValue
                        Case 2
                            filaHogar.FechaViajesSab = Me.deFechaViajes.EditValue
                        Case 3
                            filaHogar.FechaViajesDom = Me.deFechaViajes.EditValue
                        Case 4
                            filaHogar.FechaViajesLab = Me.deFechaViajes.EditValue
                            filaHogar.FechaViajesSab = Me.deSabadoLV.EditValue
                            filaHogar.FechaViajesDom = Me.deDomingoLV.EditValue
                    End Select

                    filaHogar.PersonaConDiscapacidad = Me.lkpPersonaDiscapacidad.EditValue
                    If filaHogar.PersonaConDiscapacidad Then
                        filaHogar.TipoDiscapacidad = Me.lkpTipoDiscapacidad.EditValue
                        filaHogar.DiscapacidadAutosuf = Me.lkpPersonaAutosuficiente.EditValue
                    End If

                    filaHogar.NumPer = Me.numPer
                    filaHogar.NumVeh = Me.numVeh
                    filaHogar.EstadoEncuesta = 3
                    Try
                        HogarTableAdapter.Update(Me.datasetEOD.Hogar)
                        HogarTableAdapter.Fill(Me.datasetEOD.Hogar)
                        ValidaHogarTableAdapter.Update(Me.datasetEOD.ValidaHogar)
                        ValidaHogarTableAdapter.Fill(Me.datasetEOD.ValidaHogar)
                        ResumenHogaresTableAdapter1.Fill(Me.datasetEOD.ResumenHogares)
                        MessageBox.Show("La primera visita de la encuesta ha sido terminada", "Datos guardados", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.Dispose()
                    Catch ex As Exception
                        MessageBox.Show("Error al guardar fecha de viajes. Intente nuevamente" + ex.StackTrace, "Datos no guardados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                Else
                    MessageBox.Show("La fecha de viajes es inconsistente con el tipo de encuesta. Corrija para continuar.", "Datos no guardados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("No ha contestado las preguntas mínimas para continuar con la encuesta. Por favor, complete los campos marcados con rojo.", "Datos insuficientes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Else

            Dim strHogar = filaHogar.Hogar.ToString
            Dim strZona = filaHogar.Zona.ToString
            Dim strManzana = filaHogar.Manzana.ToString
            Dim strCalle = filaHogar.NombreCalle.ToString
            Dim strNumero = filaHogar.Numero.ToString
            Dim strCasaDepto = ""

            If Not filaHogar.IsCasaDeptoNull Then
                strCasaDepto = filaHogar.CasaDepto
            End If

            Dim respuesta As DialogResult = MessageBox.Show("¿Confirma que los datos del hogar encuestado son los siguientes?" + vbCrLf +
                                                            "Hogar: " + strHogar + vbCrLf +
                                                            "Zona: " + strZona + vbCrLf +
                                                            "Manzana: " + strManzana + vbCrLf +
                                                            "Calle: " + strCalle + " - Número: " + strNumero + " - Casa/Depto: " + strCasaDepto,
                                                            "Confirmación de datos", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

            If respuesta = Windows.Forms.DialogResult.Yes Then
                If fechaCompleta() Then
                    If fechaValida() Then

                        Dim fecha As Date = Me.deFechaViajes.EditValue
                        filaHogar.TipoDia = Me.lkpTipoDia.EditValue

                        Select Case filaHogar.TipoDia
                            Case 1
                                filaHogar.FechaViajesLab = Me.deFechaViajes.EditValue
                            Case 2
                                filaHogar.FechaViajesSab = Me.deFechaViajes.EditValue
                            Case 3
                                filaHogar.FechaViajesDom = Me.deFechaViajes.EditValue
                            Case 4
                                filaHogar.FechaViajesLab = Me.deFechaViajes.EditValue
                                filaHogar.FechaViajesSab = Me.deSabadoLV.EditValue
                                filaHogar.FechaViajesDom = Me.deDomingoLV.EditValue
                        End Select

                        filaHogar.PersonaConDiscapacidad = Me.lkpPersonaDiscapacidad.EditValue
                        If filaHogar.PersonaConDiscapacidad Then
                            filaHogar.TipoDiscapacidad = Me.lkpTipoDiscapacidad.EditValue
                            filaHogar.DiscapacidadAutosuf = Me.lkpPersonaAutosuficiente.EditValue
                        End If
                        filaHogar.NumPer = Me.numPer
                        filaHogar.NumVeh = Me.numVeh
                        filaHogar.EstadoEncuesta = 3
                        Try
                            HogarTableAdapter.Update(Me.datasetEOD.Hogar)
                            HogarTableAdapter.Fill(Me.datasetEOD.Hogar)
                            ResumenHogaresTableAdapter1.Fill(Me.datasetEOD.ResumenHogares)
                            MessageBox.Show("La primera visita de la encuesta ha sido terminada", "Datos guardados", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Me.Dispose()
                        Catch ex As Exception
                            MessageBox.Show("Error al guardar fecha de viajes. Intente nuevamente" + ex.StackTrace, "Datos no guardados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End Try
                    Else
                        MessageBox.Show("La fecha de viajes es inconsistente con el tipo de encuesta. Corrija para continuar.", "Datos no guardados", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                    MessageBox.Show("No ha contestado las preguntas mínimas para continuar con la encuesta. Por favor, complete los campos marcados con rojo.", "Datos insuficientes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            Else
                folioAnterior = Me.lkpFolio.EditValue
                modoEdicionHogar = True
                Me.tabPaneHogar.SelectedPage = tabPageHogar
                MessageBox.Show("Elija el hogar correcto en este cuadro y vuelva a grabar en la última pestaña.", "Confirmación de datos", MessageBoxButtons.OK, MessageBoxIcon.Information)
                lkpZona.Focus()
            End If
        End If
    End Sub

    Private Sub lkpPropiedadVeh_EditValueChanged(sender As Object, e As EventArgs) Handles lkpPropiedadVeh.EditValueChanged
        Dim opcion As Integer = IIf(lkpPropiedadVeh.EditValue IsNot Nothing AndAlso lkpPropiedadVeh.EditValue.ToString <> "", lkpPropiedadVeh.EditValue, 0)
        Me.lblPropiedadVehOtro.Visible = False
        Me.txtPropiedadVehOtro.Visible = False

        If opcion = 2 Then
            Me.lblPropiedadVehOtro.Visible = True
            Me.txtPropiedadVehOtro.Visible = True
        End If
    End Sub

    Private Sub lkpTipoDia_Enter(sender As Object, e As EventArgs)
        BeginInvoke(New MethodInvoker(Sub() CType(sender, GridLookUpEdit).ShowPopup()))
    End Sub

    Private Sub deFechaViajes_Enter(sender As Object, e As EventArgs)
        BeginInvoke(New MethodInvoker(Sub() CType(sender, DateEdit).ShowPopup()))
    End Sub

    Private Sub deSabadoLV_Enter(sender As Object, e As EventArgs)
        BeginInvoke(New MethodInvoker(Sub() CType(sender, DateEdit).ShowPopup()))
    End Sub

    Private Sub deFechaViajes_EditValueChanged(sender As Object, e As EventArgs)

        If (Not Me.lkpTipoDia.EditValue Is Nothing) Then
            Dim tipoEncuesta As Integer
            Dim fechaSeleccionada As DateTime = deFechaViajes.EditValue
            Dim diaSemana As Integer

            If lkpTipoDia.EditValue IsNot Nothing AndAlso lkpTipoDia.EditValue.ToString <> "" Then
                tipoEncuesta = lkpTipoDia.EditValue
                diaSemana = fechaSeleccionada.DayOfWeek

                Select Case tipoEncuesta
                    Case 1
                        If diaSemana < 1 Or diaSemana > 5 Then
                            MessageBox.Show("Ha escogido tipo de encuesta laboral. El día de viajes debe ser entre Lunes y Viernes.", "Inconsistencia en día seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            deFechaViajes.Focus()
                        End If
                    Case 2
                        If diaSemana <> 6 Then
                            MessageBox.Show("Ha escogido tipo de encuesta Sábado. El día de viajes debe ser un día Sábado.", "Inconsistencia en día seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            deFechaViajes.Focus()
                        End If
                    Case 3
                        If diaSemana <> 0 Then
                            MessageBox.Show("Ha escogido tipo de encuesta Domingo. El día de viajes debe ser un día Domingo.", "Inconsistencia en día seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            deFechaViajes.Focus()
                        End If
                End Select
            End If
        End If



    End Sub



#Region "Validacion Persona"

#End Region








    Private Sub lkpRelacion_EditValueChanged(sender As Object, e As EventArgs) Handles lkpRelacion.EditValueChanged
        If lkpRelacion.EditValue IsNot Nothing AndAlso lkpRelacion.EditValue.ToString <> "" Then
            Dim relacion As Integer = Convert.ToInt32(lkpRelacion.EditValue.ToString)
            Dim personasRegistradas As Integer = gridPersonasHogar.DataRowCount
            Dim anoActual As Integer = DateTime.Now.Year
            'Dim edad As Integer = anoActual - Convert.ToInt32(txtAnoNacimiento.Text)

            'Primera persona debe ser jefe de hogar
            If personasRegistradas = 0 And relacion <> 0 Then
                MessageBox.Show("La primera persona ingresada debe ser el jefe de hogar", "Dato no válido", MessageBoxButtons.OK, MessageBoxIcon.Error)
                lkpRelacion.EditValue = ""
                lkpRelacion.Focus()
                BeginInvoke(New MethodInvoker(Sub() CType(sender, GridLookUpEdit).ShowPopup()))
            End If

            'Jefe de hogar debe ser mayor de 16 años
            If relacion = 0 AndAlso txtAnoNacimiento.Text <> "" AndAlso (anoActual - Convert.ToInt32(txtAnoNacimiento.Text)) <= 16 Then
                validadorPersona.Val4 = True
                Dim confirma As DialogResult = MessageBox.Show("Ha indicado que el jefe de hogar tiene menos de 16 años, ¿confirma que es correcto?", "Verificación de datos", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                If confirma = Windows.Forms.DialogResult.No Then
                    lkpRelacion.EditValue = ""
                    validadorPersona.Val4 = False
                Else
                    validadorPersona.Val4Resp = True
                End If
            End If

            'Debe haber sólo un jefe de hogar
            If relacion = 0 Then
                Dim jefehogar() As datasetEOD.PersonaRow
                jefehogar = Me.datasetEOD.Persona.Select("hogar = " & Me.lkpFolio.EditValue.ToString & " and relacion = 0")

                If Not jefehogar Is Nothing AndAlso jefehogar.Count > 0 Then
                    MessageBox.Show("Ya ha registrado un jefe de hogar.", "Dato no válido", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    lkpRelacion.EditValue = -1
                    lkpRelacion.Focus()
                End If
            End If

            'Debe tener solo un cónyuge
            If relacion = 1 Then
                Dim conyuge() As datasetEOD.PersonaRow
                conyuge = Me.datasetEOD.Persona.Select("hogar = " & Me.lkpFolio.EditValue.ToString & " and relacion = 1")

                If Not conyuge Is Nothing AndAlso conyuge.Count > 0 Then
                    MessageBox.Show("Ya ha registrado un cónyuge para el jefe de hogar.", "Dato no válido", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    lkpRelacion.EditValue = -1
                    lkpRelacion.Focus()
                Else
                    If txtAnoNacimiento.Text <> "" Then
                        If anoActual - Integer.Parse(txtAnoNacimiento.Text) < 18 Then
                            Dim confirma As DialogResult = MessageBox.Show("Ha indicado que el/la cónyuge es menor de edad, ¿confirma que es correcto?", "Verificación de datos", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                            If confirma = Windows.Forms.DialogResult.No Then
                                lkpRelacion.EditValue = -1
                                lkpRelacion.Focus()
                            End If
                        End If
                    End If
                End If
            End If


            'Diferencia edad padres e hijo menor a 13 años
            If personasRegistradas > 0 And relacion = 2 Then
                'jefe hogar
                Try
                    Dim jefeHogar As datasetEOD.PersonaRow
                    jefeHogar = Me.datasetEOD.Persona.Select("hogar = " & Me.lkpFolio.EditValue.ToString & " and relacion = 0")(0)
                    Dim sexoJefeHogar As Integer = jefeHogar.Sexo
                    Dim edadJefeHogar As Integer = jefeHogar.AnoNac
                    Dim diferenciaJefeHogar As Integer = Convert.ToInt32(Me.txtAnoNacimiento.Text) - edadJefeHogar

                    Dim textoAlerta As String

                    If sexoJefeHogar = 1 Then
                        'jefe hogar hombre
                        textoAlerta = "Ha indicado que la diferencia de edad entre padre e hijo/a es menor a 13 años, ¿confirma que es correcto?"
                    Else
                        'jefe hogar mujer
                        textoAlerta = "Ha indicado que la diferencia de edad entre madre e hijo/a es menor a 13 años, ¿confirma que es correcto?"
                    End If

                    If diferenciaJefeHogar < 12 Then
                        validadorPersona.Val6 = True
                        Dim confirma As DialogResult = MessageBox.Show(textoAlerta, "Verificación de datos", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                        If confirma = Windows.Forms.DialogResult.No Then
                            txtAnoNacimiento.Focus()
                            txtAnoNacimiento.Text = ""
                            validadorPersona.Val6 = False
                        Else
                            validadorPersona.Val6Resp = True
                        End If
                    End If

                Catch ex As Exception
                End Try

                'cónyuge
                Try
                    Dim conyuge As datasetEOD.PersonaRow
                    conyuge = Me.datasetEOD.Persona.Select("hogar = " & Me.lkpFolio.EditValue.ToString & " and relacion = 1")(0)
                    Dim sexoConyuge As Integer = conyuge.Sexo
                    Dim edadConyuge As Integer = conyuge.AnoNac
                    Dim diferenciaConyuge As Integer = Convert.ToInt32(Me.txtAnoNacimiento.Text) - edadConyuge

                    Dim textoAlerta As String

                    If sexoConyuge = 1 Then
                        'conyuge hombre
                        textoAlerta = "Ha indicado que la diferencia de edad entre padre e hijo/a es menor a 13 años, ¿confirma que es correcto?"
                    Else
                        'conyuge mujer
                        textoAlerta = "Ha indicado que la diferencia de edad entre madre e hijo/a es menor a 13 años, ¿confirma que es correcto?"
                    End If

                    If diferenciaConyuge < 12 Then
                        validadorPersona.Val6 = True
                        Dim confirma As DialogResult = MessageBox.Show(textoAlerta, "Verificación de datos", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                        If confirma = Windows.Forms.DialogResult.No Then
                            txtAnoNacimiento.Focus()
                            txtAnoNacimiento.Text = ""
                            validadorPersona.Val6 = False
                        Else
                            validadorPersona.Val6Resp = True
                        End If
                    End If
                Catch ex As Exception
                End Try

            End If

            If relacion = 7 OrElse relacion = 6 Then
                Dim actividad As String = chkActividad.EditValue.ToString.Trim
                If Not actividad.Contains("1") Then
                    actividad = IIf(actividad.Length = 0, 1, 1 & ", " & actividad).ToString
                    chkActividad.EditValue = actividad
                    'Habilitar preguntas Trabajo
                    spcTrabajaEstudia.Visible = True
                    spcTrabajaEstudia.CollapsePanel = SplitCollapsePanel.Panel2
                    spcTrabajaEstudia.Collapsed = True

                    Me.lkpComunaTrabajo.Visible = True
                    Me.txtComunaTrabajoOtra.Visible = True
                    Me.lkpCalle1Trabajo.Visible = True
                    Me.lkpCalle2Trabajo.Visible = True
                    Me.lkpHitoTrabajo.Visible = True
                    Me.lkpManzanaTrabajo.Visible = True
                    Me.lkpJornadaTrabajo.Visible = True

                    'Cargar datos hogar

                    Try
                        Dim objConn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\MASCARA REFERENCIA_VF.accdb")
                        objConn.Open()
                        Dim objCommand As New OleDbCommand("select comuna, nombrecalle, numero, manzana from hogar where hogar = ?", objConn)
                        Dim parametro As New OleDbParameter("hogar", Me.hogar)
                        objCommand.Parameters.Add(parametro)

                        Dim comunaHogar As String
                        Dim nombreCalleHogar As String
                        Dim numeroHogar As String
                        Dim manzanaHogar As String

                        Dim reader As OleDbDataReader = objCommand.ExecuteReader()
                        While reader.Read()
                            comunaHogar = reader.Item("comuna")
                            nombreCalleHogar = reader.Item("nombrecalle")
                            numeroHogar = reader.Item("numero")
                            manzanaHogar = reader.Item("manzana")
                        End While

                        'Llena campos comuna y calles con valores hogar
                        Me.lkpComunaTrabajo.EditValue = comunaHogar
                        Me.lkpCalle1Trabajo.EditValue = nombreCalleHogar
                        Me.lkpCalle2Trabajo.EditValue = numeroHogar

                        'Llenado de campo manzana con valor hogar
                        For i As Integer = 0 To 3
                            If Not Me.lkpManzanaTrabajo.Properties.Columns.GetVisibleColumn(i) Is Nothing Then
                                Me.lkpManzanaTrabajo.Properties.Columns.Remove(Me.lkpManzanaTrabajo.Properties.Columns.GetVisibleColumn(i))
                            End If
                        Next

                        Try
                            Dim args As DevExpress.XtraEditors.Controls.CloseUpEventArgs = New DevExpress.XtraEditors.Controls.CloseUpEventArgs(Nothing)
                            args.AcceptValue = True
                            args.Value = numeroHogar
                            Me.lkpCalle2Trabajo_CloseUp(lkpCalle2Trabajo, args)
                            Me.lkpManzanaTrabajo.EditValue = manzanaHogar
                        Catch ex As Exception

                        End Try

                        reader.Close()
                        objCommand.Dispose()
                        objConn.Close()

                    Catch ex As Exception
                        MessageBox.Show(ex.Message + vbCrLf + vbCrLf + ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try

                    'Asignar jornada completa
                    Me.lkpJornadaTrabajo.EditValue = 1

                    'Foco en nivel estudios
                    Me.lkpEstudios.Focus()

                End If
            End If
        End If
    End Sub

    Private Sub lkpDondeEstudia_EditValueChanged(sender As Object, e As EventArgs) Handles lkpDondeEstudia.EditValueChanged
        If (lkpDondeEstudia.EditValue IsNot Nothing) AndAlso (lkpDondeEstudia.EditValue.ToString <> "") Then
            Dim lugarEstudios As Integer = lkpDondeEstudia.EditValue
            Dim nivelEstudios As Integer = lkpEstudios.EditValue

            'Ocultar Otro Lugar
            Me.txtDondeEstudiaOtro.Visible = False
            Me.lblDondeEstudiaOtro.Visible = False

            If lugarEstudios = 5 Then
                'Mostrar Otro Lugar
                Me.txtDondeEstudiaOtro.Visible = True
                Me.lblDondeEstudiaOtro.Visible = True
            End If

            'Estudios prebásicos y no estudia en sala cuna/jardin/kinder/prekinder
            If lugarEstudios <> 1 AndAlso nivelEstudios = 2 Then
                MessageBox.Show("Indicó un valor inconsistente con el nivel de estudios.", "Dato no válido", MessageBoxButtons.OK, MessageBoxIcon.Error)
                lkpDondeEstudia.EditValue = ""
            End If

            'Estudios primarios y no estudia en colegio
            If lugarEstudios <> 2 AndAlso nivelEstudios = 3 Then
                MessageBox.Show("Indicó un valor inconsistente con el nivel de estudios.", "Dato no válido", MessageBoxButtons.OK, MessageBoxIcon.Error)
                lkpDondeEstudia.EditValue = ""
            End If

            'Estudios secundarios y no estudia en colegio o preuniversitario
            If (lugarEstudios <> 3 AndAlso lugarEstudios <> 2) AndAlso nivelEstudios = 4 Then
                MessageBox.Show("Indicó un valor inconsistente con el nivel de estudios.", "Dato no válido", MessageBoxButtons.OK, MessageBoxIcon.Error)
                lkpDondeEstudia.EditValue = ""
            End If

            'Estudia en universidad/instituto y no tiene estudios universitarios o técnico profesionales
            If lugarEstudios = 4 AndAlso (nivelEstudios <> 5) Then
                MessageBox.Show("Indicó un valor inconsistente con el nivel de estudios.", "Dato no válido", MessageBoxButtons.OK, MessageBoxIcon.Error)
                lkpDondeEstudia.EditValue = ""
            End If
        End If
    End Sub

    Private Sub chkNSNRDividendo_Leave(sender As Object, e As EventArgs) Handles chkNSNRDividendo.Leave
        If Not txtDividendo.Focus Then
            Dim opcion As Boolean = chkNSNRDividendo.Checked
            Dim dividendo As String = txtDividendo.Text.Replace("$", "").Replace(".", "")
            Dim monto As Integer

            If Not opcion Then
                If dividendo <> "" Then
                    monto = Convert.ToInt32(dividendo)

                    If monto < 10000 Then
                        validadorHogar.Val10 = True
                        Dim confirma As DialogResult = MessageBox.Show("El encuestado paga menos de $10.000 de dividendo, ¿confirma que es correcto?", "Verificación de datos", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                        If confirma = Windows.Forms.DialogResult.No Then
                            txtDividendo.Text = ""
                            txtDividendo.Focus()
                            validadorHogar.Val10 = False
                        ElseIf confirma = Windows.Forms.DialogResult.Yes Then
                            txtMontoGFT.Focus()
                            validadorHogar.Val10Resp = True
                        End If
                    ElseIf monto > 900000 Then
                        validadorHogar.Val11 = True
                        Dim confirma As DialogResult = MessageBox.Show("El encuestado paga más de $900.000 de dividendo, ¿confirma que es correcto?", "Verificación de datos", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                        If confirma = Windows.Forms.DialogResult.No Then
                            txtDividendo.Text = ""
                            txtDividendo.Focus()
                            validadorHogar.Val11 = False
                        ElseIf confirma = Windows.Forms.DialogResult.Yes Then
                            txtMontoGFT.Focus()
                            validadorHogar.Val11Resp = True
                        End If
                    Else
                        txtMontoGFT.Focus()
                    End If
                Else
                    MessageBox.Show("No ha indicado monto de dividendo, ni ha especificado si el encuestado no sabe o no contesta la información. Corrija con uno de estos antecedentes.", "Dato requerido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    txtDividendo.Focus()
                End If
            End If
        End If
    End Sub

    Private Sub chkNSNREstima_Leave(sender As Object, e As EventArgs) Handles chkNSNREstima.Leave
        If Not txtEstimaArriendo.Focus Then
            Dim opcion As Boolean = chkNSNREstima.Checked
            Dim estima As String = txtEstimaArriendo.Text.Replace("$", "").Replace(".", "").Replace("€", "").Trim
            Dim monto As Integer

            If Not opcion Then
                If estima <> "" Then
                    monto = Convert.ToInt32(estima)

                    If monto < 10000 Then
                        validadorHogar.Val12 = True
                        Dim confirma As DialogResult = MessageBox.Show("El encuestado estima menos de $10.000 de arriendo, ¿confirma que es correcto?", "Verificación de datos", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                        If confirma = Windows.Forms.DialogResult.No Then
                            txtEstimaArriendo.Text = ""
                            txtEstimaArriendo.Focus()
                            validadorHogar.Val12 = False
                        ElseIf confirma = Windows.Forms.DialogResult.Yes Then
                            txtMontoGFT.Focus()
                            validadorHogar.Val12Resp = True
                        End If
                    ElseIf monto > 900000 Then
                        validadorHogar.Val13 = True
                        Dim confirma As DialogResult = MessageBox.Show("El encuestado estima más de $900.000 de arriendo, ¿confirma que es correcto?", "Verificación de datos", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                        If confirma = Windows.Forms.DialogResult.No Then
                            txtEstimaArriendo.Text = ""
                            txtEstimaArriendo.Focus()
                            validadorHogar.Val13 = False
                        ElseIf confirma = Windows.Forms.DialogResult.Yes Then
                            txtMontoGFT.Focus()
                            validadorHogar.Val13Resp = True
                        End If
                    Else
                        txtMontoGFT.Focus()
                    End If
                Else
                    MessageBox.Show("No ha indicado estimación de arriendo, ni ha especificado si el encuestado no sabe o no contesta la información. Corrija con uno de estos antecedentes.", "Dato requerido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    txtEstimaArriendo.Focus()
                End If
            End If
        End If

    End Sub

    Private Sub chkNSNRArriendo_Leave(sender As Object, e As EventArgs) Handles chkNSNRArriendo.Leave
        If Not txtArriendo.Focus Then
            Dim opcion As Boolean = chkNSNRArriendo.Checked
            Dim arriendo As String = txtArriendo.Text.Replace("$", "").Replace(".", "")
            Dim monto As Integer

            If Not opcion Then
                If arriendo <> "" Then
                    monto = Convert.ToInt32(arriendo)

                    If monto < 10000 Then
                        validadorHogar.Val12 = True
                        Dim confirma As DialogResult = MessageBox.Show("El encuestado paga menos de $10.000 de arriendo, ¿confirma que es correcto?", "Verificación de datos", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                        If confirma = Windows.Forms.DialogResult.No Then
                            txtArriendo.Text = ""
                            txtArriendo.Focus()
                            validadorHogar.Val12 = False
                        ElseIf confirma = Windows.Forms.DialogResult.Yes Then
                            txtMontoGFT.Focus()
                            validadorHogar.Val12Resp = True
                        End If
                    ElseIf monto > 900000 Then
                        validadorHogar.Val13 = True
                        Dim confirma As DialogResult = MessageBox.Show("El encuestado paga más de $900.000 de arriendo, ¿confirma que es correcto?", "Verificación de datos", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                        If confirma = Windows.Forms.DialogResult.No Then
                            txtArriendo.Text = ""
                            txtArriendo.Focus()
                            validadorHogar.Val13 = False
                        ElseIf confirma = Windows.Forms.DialogResult.Yes Then
                            txtMontoGFT.Focus()
                            validadorHogar.Val13Resp = True
                        End If
                    Else
                        txtMontoGFT.Focus()
                    End If
                Else
                    MessageBox.Show("No ha indicado monto de arriendo, ni ha especificado si el encuestado no sabe o no contesta la información. Corrija con uno de estos antecedentes.", "Dato requerido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    txtArriendo.Focus()
                End If
            End If
        End If

    End Sub

    Private Sub txtAnoNacimiento_Leave(sender As Object, e As EventArgs) Handles txtAnoNacimiento.Leave
        If txtAnoNacimiento.Text <> "" AndAlso txtAnoNacimiento.Text <> "0" Then
            Me.lkpLicencia.Visible = True
            Me.lblLicencia.Visible = True

            Dim anoNacimiento As Integer = Convert.ToInt32(txtAnoNacimiento.Text)
            Dim anoActual As Integer = DateTime.Today.Year
            Dim edadCalculada = anoActual - anoNacimiento

            If edadCalculada < 0 Then
                MessageBox.Show("El año de nacimiento no puede ser mayor que el actual. Corrija el dato para continuar.", "Inconsistencia en edad", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtAnoNacimiento.Text = "0"
                txtAnoNacimiento.Focus()
            ElseIf edadCalculada > 100 Then
                validadorPersona.Val2 = True
                Dim comprueba As DialogResult = MessageBox.Show("Ha indicado que el encuestado tiene más de 100 años, ¿es correcto?", "Posible inconsistencia en edad", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                If comprueba = Windows.Forms.DialogResult.No Then
                    Me.txtAnoNacimiento.Text = ""
                    Me.txtAnoNacimiento.Focus()
                    validadorPersona.Val2 = False
                Else
                    validadorPersona.Val2Resp = True
                End If
            ElseIf edadCalculada < 18 Then
                Me.lkpLicencia.Visible = False
                Me.lblLicencia.Visible = False
            End If
        End If
    End Sub


    Private Sub txtTelefono_Leave(sender As Object, e As EventArgs) Handles txtTelefono.Leave
        Dim telefono As String = Me.txtTelefono.Text
        If telefono.Length > 0 And telefono.Length < 9 Then
            MessageBox.Show("El número de teléfono debe tener 9 dígitos.", "Dato incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtAnoNacimiento.Focus()
        End If

    End Sub

    Private Sub lkpTipoVeh_Enter(sender As Object, e As EventArgs) Handles lkpTipoVeh.Enter
        If Not pressGrabarVehiculo Then
            BeginInvoke(New MethodInvoker(Sub() CType(sender, GridLookUpEdit).ShowPopup()))
        End If
    End Sub

    Private Sub lkpPropiedadVeh_Enter(sender As Object, e As EventArgs) Handles lkpPropiedadVeh.Enter
        BeginInvoke(New MethodInvoker(Sub() CType(sender, GridLookUpEdit).ShowPopup()))
    End Sub

    Private Sub lkpOtroVeh_Enter(sender As Object, e As EventArgs) Handles lkpOtroVeh.Enter
        BeginInvoke(New MethodInvoker(Sub() CType(sender, GridLookUpEdit).ShowPopup()))
    End Sub

    Private Sub tabPaneHogar_SelectedPageChanged(sender As Object, e As DevExpress.XtraBars.Navigation.SelectedPageChangedEventArgs) Handles tabPaneHogar.SelectedPageChanged

        Dim page As Integer = tabPaneHogar.SelectedPageIndex
        Select Case page
            Case 0
                Me.lkpZona.Focus()
            Case 1
                Me.lkpTipoVeh.Focus()
            Case 2
                Me.txtNombrePila.Focus()
            Case 3
                Me.txtObservacion.Focus()
        End Select

    End Sub

    Private Function hogarCompleto() As Boolean
        Dim completo As Boolean = True

        'Campo Zona
        If lkpZona.EditValue Is Nothing OrElse lkpZona.EditValue.ToString = "" OrElse lkpZona.EditValue < 1 Then
            completo = False
            lkpZona.Properties.Appearance.BorderColor = Color.Red
        Else
            lkpZona.Properties.Appearance.BorderColor = Nothing
        End If

        'Campo Manzana
        If lkpManzana.EditValue Is Nothing OrElse lkpManzana.EditValue.ToString = "" OrElse lkpManzana.EditValue < 1 Then
            completo = False
            lkpManzana.Properties.Appearance.BorderColor = Color.Red
        Else
            lkpManzana.Properties.Appearance.BorderColor = Nothing
        End If

        'Campo Folio
        If lkpFolio.EditValue Is Nothing OrElse lkpFolio.EditValue.ToString = "" OrElse lkpFolio.EditValue < 1 Then
            completo = False
            lkpFolio.Properties.Appearance.BorderColor = Color.Red
        Else
            lkpFolio.Properties.Appearance.BorderColor = Nothing
        End If

        'Campo Calle
        If txtCalle.Text = "" Then
            completo = False
            txtCalle.Properties.Appearance.BorderColor = Color.Red
        Else
            txtCalle.Properties.Appearance.BorderColor = Nothing
        End If

        'Campo Número
        If txtNumero.Text = "" Then
            completo = False
            txtNumero.Properties.Appearance.BorderColor = Color.Red
        Else
            txtNumero.Properties.Appearance.BorderColor = Nothing
        End If

        'Campo Comuna
        If lkpComuna.EditValue Is Nothing OrElse lkpComuna.EditValue.ToString = "" OrElse lkpComuna.EditValue < 1 Then
            completo = False
            lkpComuna.Properties.Appearance.BorderColor = Color.Red
        ElseIf lkpComuna.EditValue = 1 Then
            lkpComuna.Properties.Appearance.BorderColor = Nothing

            'Campo Otra Comuna
            If txtComunaOtra.Text = "" Then
                completo = False
                txtComunaOtra.Properties.Appearance.BorderColor = Color.Red
            Else
                txtComunaOtra.Properties.Appearance.BorderColor = Nothing
            End If
        Else
            lkpComuna.Properties.Appearance.BorderColor = Nothing
        End If

        'Campo Tipo Vivienda
        If lkpTipoVivienda.EditValue Is Nothing OrElse lkpTipoVivienda.EditValue.ToString = "" OrElse lkpTipoVivienda.EditValue < 1 Then
            completo = False
            lkpTipoVivienda.Properties.Appearance.BorderColor = Color.Red
        Else
            lkpTipoVivienda.Properties.Appearance.BorderColor = Nothing
        End If

        'Campo Propiedad Vivienda
        If lkpPropiedad.EditValue Is Nothing OrElse lkpPropiedad.EditValue.ToString = "" OrElse lkpPropiedad.EditValue < 1 Then
            completo = False
            lkpPropiedad.Properties.Appearance.BorderColor = Color.Red
        Else
            lkpPropiedad.Properties.Appearance.BorderColor = Nothing

            Select Case lkpPropiedad.EditValue
                Case 1, 4
                    If txtEstimaArriendo.Text = "" AndAlso Not chkNSNREstima.Checked Then
                        completo = False
                        txtEstimaArriendo.Properties.Appearance.BorderColor = Color.Red
                    Else
                        txtEstimaArriendo.Properties.Appearance.BorderColor = Nothing
                    End If
                Case 5
                    If txtEstimaArriendo.Text = "" AndAlso Not chkNSNREstima.Checked Then
                        completo = False
                        txtEstimaArriendo.Properties.Appearance.BorderColor = Color.Red
                    Else
                        txtEstimaArriendo.Properties.Appearance.BorderColor = Nothing
                    End If

                    If txtPropiedadOtra.Text = "" Then
                        completo = False
                        txtPropiedadOtra.Properties.Appearance.BorderColor = Color.Red
                    Else
                        txtPropiedadOtra.Properties.Appearance.BorderColor = Nothing
                    End If
                Case 2
                    If txtDividendo.Text = "" AndAlso Not chkNSNRDividendo.Checked Then
                        completo = False
                        txtDividendo.Properties.Appearance.BorderColor = Color.Red
                    Else
                        txtDividendo.Properties.Appearance.BorderColor = Nothing
                    End If
                Case 3
                    If txtArriendo.Text = "" AndAlso Not chkNSNRArriendo.Checked Then
                        completo = False
                        txtArriendo.Properties.Appearance.BorderColor = Color.Red
                    Else
                        txtArriendo.Properties.Appearance.BorderColor = Nothing
                    End If
            End Select
        End If

        'Campo Indica GFT
        If lkpIndicaGFT.EditValue Is Nothing OrElse lkpIndicaGFT.EditValue.ToString = "" Then
            completo = False
            lkpIndicaGFT.Properties.Appearance.BorderColor = Color.Red
        ElseIf lkpIndicaGFT.EditValue = 1 Then
            lkpIndicaGFT.Properties.Appearance.BorderColor = Nothing

            'Campo MontoGFT
            If txtMontoGFT.Text = "" Then
                completo = False
                txtMontoGFT.Properties.Appearance.BorderColor = Color.Red
            Else
                txtMontoGFT.Properties.Appearance.BorderColor = Nothing
            End If
        Else
            lkpIndicaGFT.Properties.Appearance.BorderColor = Nothing
        End If


        'Campo Tiene Vehiculo
        If lkpTieneVeh.EditValue Is Nothing OrElse lkpTieneVeh.EditValue.ToString = "" OrElse lkpTieneVeh.EditValue < 1 Then
            completo = False
            lkpTieneVeh.Properties.Appearance.BorderColor = Color.Red
        Else
            lkpTieneVeh.Properties.Appearance.BorderColor = Nothing
        End If

        Return completo
    End Function

    Private Function vehiculoCompleto() As Boolean
        Dim completo As Boolean = True

        'Campo Tipo Vehiculo
        If lkpTipoVeh.EditValue Is Nothing OrElse lkpTipoVeh.EditValue.ToString = "" OrElse lkpTipoVeh.EditValue < 1 Then
            completo = False
            lkpTipoVeh.Properties.Appearance.BorderColor = Color.Red
        Else
            lkpTipoVeh.Properties.Appearance.BorderColor = Nothing
        End If

        'Campo Propiedad Vehiculo
        If lkpPropiedadVeh.EditValue Is Nothing OrElse lkpPropiedadVeh.EditValue.ToString = "" OrElse lkpPropiedadVeh.EditValue < 1 Then
            completo = False
            lkpPropiedadVeh.Properties.Appearance.BorderColor = Color.Red
        ElseIf lkpPropiedadVeh.EditValue = 2 Then
            lkpPropiedadVeh.Properties.Appearance.BorderColor = Nothing
            'Campo Otra Propiedad
            If txtPropiedadVehOtro.Text = "" Then
                completo = False
                txtPropiedadVehOtro.Properties.Appearance.BorderColor = Color.Red
            Else
                txtPropiedadVehOtro.Properties.Appearance.BorderColor = Nothing
            End If
        Else
            lkpPropiedadVeh.Properties.Appearance.BorderColor = Nothing
        End If

        'Campo lkpTipoMotor 
        If lkpTipoMotor.EditValue Is Nothing OrElse lkpTipoMotor.EditValue.ToString = "" OrElse lkpTipoMotor.EditValue < 1 Then
            completo = False
            lkpTipoMotor.Properties.Appearance.BorderColor = Color.Red
        Else
            lkpTipoMotor.Properties.Appearance.BorderColor = Nothing
        End If

        'Campo Año Fabricacion
        If txtAnioFabricacion.Text = "" Then
            completo = False
            txtAnioFabricacion.Properties.Appearance.BorderColor = Color.Red
        Else
            txtAnioFabricacion.Properties.Appearance.BorderColor = Nothing
        End If

        'Campo Otro Vehiculo
        If lkpOtroVeh.EditValue Is Nothing OrElse lkpOtroVeh.EditValue.ToString = "" OrElse lkpOtroVeh.EditValue < 1 Then
            completo = False
            lkpOtroVeh.Properties.Appearance.BorderColor = Color.Red
        Else
            lkpOtroVeh.Properties.Appearance.BorderColor = Nothing
        End If

        Return completo
    End Function

    Private Function personaCompleta() As Boolean
        Dim completo As Boolean = True

        'Campo Nombre
        If txtNombrePila.Text = "" Then
            completo = False
            txtNombrePila.Properties.Appearance.BorderColor = Color.Red
        Else
            txtNombrePila.Properties.Appearance.BorderColor = Nothing
        End If

        'Campo Año Nacimiento
        If txtAnoNacimiento.Text = "" Then
            completo = False
            txtAnoNacimiento.Properties.Appearance.BorderColor = Color.Red
        Else
            txtAnoNacimiento.Properties.Appearance.BorderColor = Nothing

            If txtAnoNacimiento.Text > 1900 AndAlso txtAnoNacimiento.Text < Date.Now.Year Then
                If Date.Now.Year - txtAnoNacimiento.Text > 17 Then
                    'Campo Licencia
                    If lkpLicencia.EditValue Is Nothing OrElse lkpLicencia.EditValue.ToString = "" OrElse lkpLicencia.EditValue < 1 Then
                        completo = False
                        lkpLicencia.Properties.Appearance.BorderColor = Color.Red
                    Else
                        lkpLicencia.Properties.Appearance.BorderColor = Nothing
                    End If
                End If
            End If
        End If

        'Campo Sexo
        If lkpSexo.EditValue Is Nothing OrElse lkpSexo.EditValue.ToString = "" OrElse lkpSexo.EditValue < 1 Then
            completo = False
            lkpSexo.Properties.Appearance.BorderColor = Color.Red
        Else
            lkpSexo.Properties.Appearance.BorderColor = Nothing
        End If

        'Campo Relación
        If lkpRelacion.EditValue Is Nothing OrElse lkpRelacion.EditValue.ToString = "" OrElse lkpRelacion.EditValue < 0 Then
            completo = False
            lkpRelacion.Properties.Appearance.BorderColor = Color.Red
        Else
            lkpRelacion.Properties.Appearance.BorderColor = Nothing
        End If

        'Campo Estudios
        If lkpEstudios.EditValue Is Nothing OrElse lkpEstudios.EditValue.ToString = "" OrElse lkpEstudios.EditValue < 1 Then
            completo = False
            lkpEstudios.Properties.Appearance.BorderColor = Color.Red
        Else
            'Campo Estudios Completos
            If lkpEstudios.EditValue = 3 OrElse lkpEstudios.EditValue = 4 OrElse lkpEstudios.EditValue = 5 Then
                If lkpEstudiosCompletos.EditValue.ToString = "" OrElse lkpEstudiosCompletos.EditValue < 1 Then
                    completo = False
                    lkpEstudiosCompletos.Properties.Appearance.BorderColor = Color.Red
                Else
                    lkpEstudiosCompletos.Properties.Appearance.BorderColor = Nothing
                End If
            End If
        End If

        'Campo Otra Persona
        If lkpOtraPersona.EditValue Is Nothing OrElse lkpOtraPersona.EditValue.ToString = "" OrElse lkpOtraPersona.EditValue < 1 Then
            completo = False
            lkpOtraPersona.Properties.Appearance.BorderColor = Color.Red
        Else
            lkpOtraPersona.Properties.Appearance.BorderColor = Nothing
        End If

        'Campo Actividad
        If chkActividad.EditValue Is Nothing OrElse chkActividad.EditValue.ToString = "" Then
            completo = False
            chkActividad.Properties.Appearance.BorderColor = Color.Red
        Else
            chkActividad.Properties.Appearance.BorderColor = Nothing
            If chkActividad.EditValue.ToString.Contains("6") Then
                'Campo Otra Actividad
                If txtActividadOtra.Text = "" Then
                    completo = False
                    txtActividadOtra.Properties.Appearance.BorderColor = Color.Red
                Else
                    txtActividadOtra.Properties.Appearance.BorderColor = Nothing
                End If
            End If
            'Preguntas Actividad Trabajo
            If chkActividad.EditValue.ToString.Contains("1") Then
                'Campo Jornada Trabajo
                If lkpJornadaTrabajo.EditValue Is Nothing OrElse lkpJornadaTrabajo.EditValue.ToString = "" OrElse lkpJornadaTrabajo.EditValue < 1 Then
                    completo = False
                    lkpJornadaTrabajo.Properties.Appearance.BorderColor = Color.Red
                Else
                    lkpJornadaTrabajo.Properties.Appearance.BorderColor = Nothing
                End If

                'Campo Comuna Trabajo
                If lkpComunaTrabajo.EditValue Is Nothing OrElse lkpComunaTrabajo.EditValue.ToString = "" OrElse lkpComunaTrabajo.EditValue < 1 Then
                    completo = False
                    lkpComunaTrabajo.Properties.Appearance.BorderColor = Color.Red
                Else
                    lkpComunaTrabajo.Properties.Appearance.BorderColor = Nothing

                    If lkpComunaTrabajo.EditValue = 1 Then
                        'Campo Otra Comuna Trabajo
                        If txtComunaTrabajoOtra.Text = "" Then
                            completo = False
                            txtComunaTrabajoOtra.Properties.Appearance.BorderColor = Color.Red
                        Else
                            txtComunaTrabajoOtra.Properties.Appearance.BorderColor = Nothing
                        End If
                    ElseIf lkpComunaTrabajo.EditValue = 2 Then
                        'Campo Hito Trabajo
                        If lkpHitoTrabajo.EditValue Is Nothing OrElse lkpHitoTrabajo.EditValue.ToString = "" Then

                            'Campo Calle 1 Trabajo
                            If lkpCalle1Trabajo.EditValue Is Nothing OrElse lkpCalle1Trabajo.EditValue.ToString = "" Then
                                completo = False
                                lkpCalle1Trabajo.Properties.Appearance.BorderColor = Color.Red
                                lkpHitoTrabajo.Properties.Appearance.BorderColor = Color.Red
                            Else
                                'Campo Calle 2 Trabajo
                                If lkpCalle2Trabajo.EditValue Is Nothing OrElse lkpCalle2Trabajo.EditValue.ToString = "" Then
                                    completo = False
                                    lkpCalle2Trabajo.Properties.Appearance.BorderColor = Color.Red
                                    lkpHitoTrabajo.Properties.Appearance.BorderColor = Color.Red
                                Else
                                    lkpCalle1Trabajo.Properties.Appearance.BorderColor = Nothing
                                    lkpCalle2Trabajo.Properties.Appearance.BorderColor = Nothing
                                    lkpHitoTrabajo.Properties.Appearance.BorderColor = Nothing
                                End If
                            End If
                        Else
                            lkpHitoTrabajo.Properties.Appearance.BorderColor = Nothing
                        End If

                        'Campo Manzana Trabajo
                        If lkpManzanaTrabajo.EditValue Is Nothing OrElse lkpManzanaTrabajo.EditValue.ToString = "" Then
                            completo = False
                            lkpManzanaTrabajo.Properties.Appearance.BorderColor = Color.Red
                        Else
                            lkpManzanaTrabajo.Properties.Appearance.BorderColor = Nothing
                        End If

                    End If
                End If
            End If


            'Preguntas Actividad Estudio
            If chkActividad.EditValue.ToString.Contains("2") Then
                'Campo Donde Estudia 
                If lkpDondeEstudia.EditValue Is Nothing OrElse lkpDondeEstudia.EditValue.ToString = "" OrElse lkpDondeEstudia.EditValue < 1 Then
                    completo = False
                    lkpDondeEstudia.Properties.Appearance.BorderColor = Color.Red
                Else
                    lkpDondeEstudia.Properties.Appearance.BorderColor = Nothing

                    If lkpDondeEstudia.EditValue = 5 Then
                        'Campo Otro Lugar Estudio
                        If txtDondeEstudiaOtro.Text = "" Then
                            completo = False
                            txtDondeEstudiaOtro.Properties.Appearance.BorderColor = Color.Red
                        Else
                            txtDondeEstudiaOtro.Properties.Appearance.BorderColor = Nothing
                        End If
                    End If
                End If

                'Campo Tiene TNE
                If lkpTieneTNE.EditValue Is Nothing OrElse lkpTieneTNE.EditValue.ToString = "" OrElse lkpTieneTNE.EditValue < 1 Then
                    completo = False
                    lkpTieneTNE.Properties.Appearance.BorderColor = Color.Red
                Else
                    lkpTieneTNE.Properties.Appearance.BorderColor = Nothing
                End If

                'Campo Comuna Estudio
                If lkpComunaEstudio.EditValue Is Nothing OrElse lkpComunaEstudio.EditValue.ToString = "" OrElse lkpComunaEstudio.EditValue < 1 Then
                    completo = False
                    lkpComunaEstudio.Properties.Appearance.BorderColor = Color.Red
                Else
                    lkpComunaEstudio.Properties.Appearance.BorderColor = Nothing

                    If lkpComunaEstudio.EditValue = 1 Then
                        'Campo Otra Comuna Estudio
                        If txtComunaEstudioOtra.Text = "" Then
                            completo = False
                            txtComunaEstudioOtra.Properties.Appearance.BorderColor = Color.Red
                        Else
                            txtComunaEstudioOtra.Properties.Appearance.BorderColor = Nothing
                        End If
                    ElseIf lkpComunaEstudio.EditValue = 2 Then
                        'Campo Hito Estudio
                        If lkpHitoEstudio.EditValue Is Nothing OrElse lkpHitoEstudio.EditValue.ToString = "" Then

                            'Campo Calle 1 Estudio
                            If lkpCalle1Estudio.EditValue Is Nothing OrElse lkpCalle1Estudio.EditValue.ToString = "" Then
                                completo = False
                                lkpCalle1Estudio.Properties.Appearance.BorderColor = Color.Red
                                lkpHitoEstudio.Properties.Appearance.BorderColor = Color.Red
                            Else
                                'Campo Calle 2 Estudio
                                If lkpCalle2Estudio.EditValue Is Nothing OrElse lkpCalle2Estudio.EditValue.ToString = "" Then
                                    completo = False
                                    lkpCalle2Estudio.Properties.Appearance.BorderColor = Color.Red
                                    lkpHitoEstudio.Properties.Appearance.BorderColor = Color.Red
                                Else
                                    lkpCalle1Estudio.Properties.Appearance.BorderColor = Nothing
                                    lkpCalle2Estudio.Properties.Appearance.BorderColor = Nothing
                                    lkpHitoEstudio.Properties.Appearance.BorderColor = Nothing
                                End If
                            End If
                        Else
                            lkpHitoEstudio.Properties.Appearance.BorderColor = Nothing
                        End If

                        'Campo Manzana Estudio
                        If lkpManzanaEstudio.EditValue Is Nothing OrElse lkpManzanaEstudio.EditValue.ToString = "" Then
                            completo = False
                            lkpManzanaEstudio.Properties.Appearance.BorderColor = Color.Red
                        Else
                            lkpManzanaEstudio.Properties.Appearance.BorderColor = Nothing
                        End If

                    End If
                End If
            End If
        End If

        Return completo

    End Function

    Private Function fechaCompleta() As Boolean
        Dim completo As Boolean = True

        'Campo Hay Discapacitado
        If lkpPersonaDiscapacidad.EditValue Is Nothing OrElse lkpPersonaDiscapacidad.EditValue.ToString = "" OrElse lkpPersonaDiscapacidad.EditValue < 1 Then
            completo = False
            lkpPersonaDiscapacidad.Properties.Appearance.BorderColor = Color.Red
        ElseIf lkpPersonaDiscapacidad.EditValue = 1 Then

            'Campo Tipo Discapacidad
            If lkpTipoDiscapacidad.EditValue Is Nothing OrElse lkpTipoDiscapacidad.EditValue.ToString = "" OrElse lkpTipoDiscapacidad.EditValue < 1 Then
                completo = False
                lkpTipoDiscapacidad.Properties.Appearance.BorderColor = Color.Red
            Else
                lkpTipoDiscapacidad.Properties.Appearance.BorderColor = Nothing
            End If

            'Campo Autosuficiente
            If lkpPersonaAutosuficiente.EditValue Is Nothing OrElse lkpPersonaAutosuficiente.EditValue.ToString = "" OrElse lkpPersonaAutosuficiente.EditValue < 1 Then
                completo = False
                lkpPersonaAutosuficiente.Properties.Appearance.BorderColor = Color.Red
            Else
                lkpPersonaAutosuficiente.Properties.Appearance.BorderColor = Nothing
            End If
        End If

        'Campo Tipo Encuesta
        If lkpTipoDia.EditValue Is Nothing OrElse lkpTipoDia.EditValue.ToString = "" OrElse lkpTipoDia.EditValue < 1 Then
            completo = False
            lkpTipoDia.Properties.Appearance.BorderColor = Color.Red
        Else
            lkpTipoDia.Properties.Appearance.BorderColor = Nothing
        End If

        'Campo Fecha Programada
        If deFechaViajes.EditValue Is Nothing OrElse deFechaViajes.EditValue.ToString = "" Then
            completo = False
            deFechaViajes.Properties.Appearance.BorderColor = Color.Red
        Else
            deFechaViajes.Properties.Appearance.BorderColor = Nothing
        End If


        If lkpTipoDia.EditValue = 4 Then
            'Campo Fecha Sábado
            If deSabadoLV.EditValue Is Nothing OrElse deSabadoLV.EditValue.ToString = "" Then
                completo = False
                deSabadoLV.Properties.Appearance.BorderColor = Color.Red
            Else
                deSabadoLV.Properties.Appearance.BorderColor = Nothing
            End If
        End If

        Return completo
    End Function

    Private Sub btnCancelarHogar_Click(sender As Object, e As EventArgs) Handles btnCancelarHogar.Click
        Me.datasetEOD.RejectChanges()
        Me.Dispose()
    End Sub

    Private Sub btnCancelarVeh_Click(sender As Object, e As EventArgs) Handles btnCancelarVeh.Click
        limpiarVehiculo()
        'Pasar a ingresar personas
        Me.tabPagePersonas.PageVisible = True
        Me.tabPaneHogar.SelectedPage = Me.tabPagePersonas
        Me.txtNombrePila.Focus()
    End Sub

    Private Sub btnCancelarPersona_Click(sender As Object, e As EventArgs) Handles btnCancelarPersona.Click
        limpiarPersona()
        'Pasar a ingresar fecha
        Me.tabPageFecha.PageVisible = True
        Me.tabPaneHogar.SelectedPage = Me.tabPageFecha
        Me.txtObservacion.Focus()
    End Sub

    Private Sub lkpEstudiosCompletos_EditValueChanged(sender As Object, e As EventArgs) Handles lkpEstudiosCompletos.EditValueChanged
        If txtAnoNacimiento.Text <> "" AndAlso lkpEstudios.EditValue IsNot Nothing Then
            Dim nivelEstudios As Integer = Convert.ToInt32(IIf(lkpEstudios.EditValue IsNot Nothing AndAlso lkpEstudios.EditValue.ToString <> "", lkpEstudios.EditValue.ToString, 0))
            Dim edadEncuestado As Integer = DateTime.Now.Year - Convert.ToInt32(Me.txtAnoNacimiento.Text.ToString)

            If lkpEstudiosCompletos.EditValue IsNot Nothing AndAlso lkpEstudiosCompletos.EditValue.ToString <> "" Then
                Dim opcion As Integer = Integer.Parse(lkpEstudiosCompletos.EditValue.ToString)

                'Validar nivel de estudios con edad del encuestado
                'Estudios primarios completos con menos de 13 años
                If edadEncuestado < 13 AndAlso nivelEstudios = 3 AndAlso opcion = 1 Then
                    validadorPersona.Val23 = True
                    Dim confirma As DialogResult = MessageBox.Show("Ha indicado que tiene estudios primarios completos con menos de 13 años. ¿Confirma que es correcto?.", "Verificación de datos", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                    If confirma = Windows.Forms.DialogResult.No Then
                        lkpEstudiosCompletos.EditValue = ""
                        lkpEstudios.Focus()
                        validadorPersona.Val23 = False
                    Else
                        validadorPersona.Val23Resp = True
                    End If
                End If

                'Estudios secundarios completos con menos de 17 años
                If edadEncuestado < 17 AndAlso nivelEstudios = 4 AndAlso opcion = 1 Then
                    validadorPersona.Val24 = True
                    Dim confirma As DialogResult = MessageBox.Show("Ha indicado que tiene estudios secundarios completos con menos de 17 años. Corrija la información.", "Verificación de datos", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                    If confirma = Windows.Forms.DialogResult.No Then
                        lkpEstudiosCompletos.EditValue = ""
                        lkpEstudios.Focus()
                        validadorPersona.Val24 = False
                    Else
                        validadorPersona.Val24Resp = True
                    End If
                End If

                'Estudios profesionales completos con menos de 22 años
                If edadEncuestado < 22 AndAlso nivelEstudios = 5 AndAlso opcion = 1 Then
                    validadorPersona.Val25 = True
                    Dim confirma As DialogResult = MessageBox.Show("Ha indicado que tiene estudios universitarios con menos de 17 años. Corrija la información.", "Verificación de datos", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                    If confirma = Windows.Forms.DialogResult.No Then
                        lkpEstudiosCompletos.EditValue = ""
                        lkpEstudios.Focus()
                        validadorPersona.Val25 = False
                    Else
                        validadorPersona.Val25Resp = True
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub cargaPreguntasHogar_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles cargaPreguntasHogar.DoWork
        lanzaPantallaEspera = New DevExpress.XtraSplashScreen.SplashScreenManager(Me, GetType(Global.EOD.PantallaEspera), True, True)
        lanzaPantallaEspera.ShowWaitForm()

        Invoke(DirectCast(AddressOf Me.fillTipoMotor, MethodInvoker))
        Invoke(DirectCast(AddressOf Me.fillZonasCat, MethodInvoker))
        Invoke(DirectCast(AddressOf Me.fillPropiedad, MethodInvoker))
        Invoke(DirectCast(AddressOf Me.fillComuna, MethodInvoker))
        Invoke(DirectCast(AddressOf Me.fillTipoViviendaActual, MethodInvoker))
        Invoke(DirectCast(AddressOf Me.fillSiNo, MethodInvoker))
        Invoke(DirectCast(AddressOf Me.fillTipoVeh, MethodInvoker))
        Invoke(DirectCast(AddressOf Me.fillPropiedadVehiculo, MethodInvoker))
        Invoke(DirectCast(AddressOf Me.fillResumenVehiculos, MethodInvoker))
        Invoke(DirectCast(AddressOf Me.fillTipoDia, MethodInvoker))
        Invoke(DirectCast(AddressOf Me.fillDondeEstudia, MethodInvoker))
        Invoke(DirectCast(AddressOf Me.fillJornadaTrabajo, MethodInvoker))
        Invoke(DirectCast(AddressOf Me.fillActividad, MethodInvoker))
        Invoke(DirectCast(AddressOf Me.fillEstudios, MethodInvoker))
        Invoke(DirectCast(AddressOf Me.fillRelacion, MethodInvoker))
        Invoke(DirectCast(AddressOf Me.fillSexo, MethodInvoker))
        Invoke(DirectCast(AddressOf Me.fillResumenPersonas, MethodInvoker))
        Invoke(DirectCast(AddressOf Me.fillHito, MethodInvoker))
        Invoke(DirectCast(AddressOf Me.fillCalle1, MethodInvoker))
    End Sub

    Private Sub cargaPreguntasHogar_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles cargaPreguntasHogar.RunWorkerCompleted
        If lanzaPantallaEspera IsNot Nothing Then
            lanzaPantallaEspera.CloseWaitForm()
            Me.Enabled = True
            resumeBindings()
        End If

        Try
            gps = New GarminDevice
            gps.OpenPort()

            waypoints = gps.GetWaypoints

            If waypoints IsNot Nothing Then
                datasetWaypoints = waypoints.ToDataSet
                dataTableWaypoints = datasetWaypoints.Tables("Waypoints")
                cbWaypoint.DataSource = dataTableWaypoints
                cbWaypoint.DisplayMember = "Identifier"
                cbWaypoint.ValueMember = "Identifier"

            End If

        Catch ex As Exception
            MessageBox.Show("No se ha encontrado un GPS conectado al equipo. El waypoint correspondiente a este hogar deberá ser ingresado posteriormente.", "GPS no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub btnRechazoVehiculo_Click(sender As Object, e As EventArgs) Handles btnRechazoVehiculo.Click
        Dim rechazarEncuesta = MessageBox.Show("Ha indicado que el hogar ha rechazado participar en la Encuesta, ¿confirma que es correcto?", "Rechazar encuesta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If rechazarEncuesta = Windows.Forms.DialogResult.Yes Then
            'Mostrar modal de confirmación con clave
            Dim ventanaRechazo As RechazoEncuesta = New RechazoEncuesta(Me.lkpFolio.EditValue)
            ventanaRechazo.ShowDialog()
            'Cerrar nuevo hogar
            Me.Dispose()
        End If
    End Sub

    Private Sub btnRechazoPersona_Click(sender As Object, e As EventArgs) Handles btnRechazoPersona.Click
        Dim rechazarEncuesta = MessageBox.Show("Ha indicado que el hogar ha rechazado participar en la Encuesta, ¿confirma que es correcto?", "Rechazar encuesta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If rechazarEncuesta = Windows.Forms.DialogResult.Yes Then
            'Mostrar modal de confirmación con clave
            Dim ventanaRechazo As RechazoEncuesta = New RechazoEncuesta(Me.lkpFolio.EditValue)
            ventanaRechazo.ShowDialog()
            'Cerrar nuevo hogar
            Me.Dispose()
        End If
    End Sub

    Private Sub btnRechazoFecha_Click(sender As Object, e As EventArgs) Handles btnRechazoFecha.Click
        Dim rechazarEncuesta = MessageBox.Show("Ha indicado que el hogar ha rechazado participar en la Encuesta, ¿confirma que es correcto?", "Rechazar encuesta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If rechazarEncuesta = Windows.Forms.DialogResult.Yes Then
            'Mostrar modal de confirmación con clave
            Dim ventanaRechazo As RechazoEncuesta = New RechazoEncuesta(Me.lkpFolio.EditValue)
            ventanaRechazo.ShowDialog()
            'Cerrar nuevo hogar
            Me.Dispose()
        End If
    End Sub

    Private Sub lkpCalle2Trabajo_CloseUp(sender As Object, e As DevExpress.XtraEditors.Controls.CloseUpEventArgs) Handles lkpCalle2Trabajo.CloseUp
        If e.AcceptValue Then
            Dim idInterseccion As Integer
            Dim conflictiva As Integer
            Dim codigoTrasa As Integer

            If lkpCalle2Trabajo.EditValue IsNot Nothing AndAlso lkpCalle2Trabajo.EditValue.ToString <> "" Then
                Try
                    Dim edit As GridLookUpEdit = TryCast(sender, GridLookUpEdit)
                    Dim row As DataRowView = TryCast(edit.Properties.GetRowByKeyValue(e.Value), DataRowView)
                    idInterseccion = row.Item("id")
                    conflictiva = row.Item("conflictiva")
                    codigoTrasa = row.Item("codigoTrasa")
                    Me.x_trabajo.Text = row.Item("x")
                    Me.y_trabajo.Text = row.Item("y")

                    Dim objConn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\MASCARA REFERENCIA_VF.accdb")
                    objConn.Open()

                    Dim objCommand As New OleDbCommand("MzIntersec", objConn) With {.CommandType = CommandType.StoredProcedure}
                    Dim parametro As New OleDbParameter("idInter", idInterseccion)
                    objCommand.Parameters.Add(parametro)

                    Dim objAdapter As New OleDbDataAdapter(objCommand)
                    Dim objDataSet As New DataSet("ManzanaAutoE2")

                    For i As Integer = 0 To 3
                        If Not Me.lkpManzanaTrabajo.Properties.Columns.GetVisibleColumn(i) Is Nothing Then
                            Me.lkpManzanaTrabajo.Properties.Columns.Remove(Me.lkpManzanaTrabajo.Properties.Columns.GetVisibleColumn(i))
                        End If
                    Next

                    Try
                        objAdapter.Fill(objDataSet, "ManzanaAutoE2")
                        Dim objTabla As DataTable = objDataSet.Tables("ManzanaAutoE2")
                        Me.lkpManzanaTrabajo.Properties.DataSource = objTabla
                        Me.lkpManzanaTrabajo.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("mz1", "mz1", 5, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
                        Me.lkpManzanaTrabajo.Properties.DisplayMember = "mz1"
                        Me.lkpManzanaTrabajo.Properties.ValueMember = "mz1"

                    Catch ex As Exception
                        MessageBox.Show(ex.Message + vbCrLf + vbCrLf + ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try


                    If conflictiva = 1 Then
                        MessageBox.Show("Debe escoger una manzana del siguiente mapa para identificar el lugar de bajada del transporte.", "Intersección conflictiva", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Dim mapaInterseccion As New MapaInterseccion(codigoTrasa)
                        mapaInterseccion.ShowDialog()
                        lkpManzanaTrabajo.Focus()
                    ElseIf conflictiva = 0 Then
                        Dim aleatorioMax = objDataSet.Tables("ManzanaAutoE2").Rows.Count
                        Dim aleatorio As Random = New Random
                        Me.lkpManzanaTrabajo.ItemIndex = aleatorio.Next(0, aleatorioMax - 1)
                        lkpJornadaTrabajo.Focus()
                    End If
                Catch ex As Exception
                End Try
            Else
                'borrar manzanas 
                lkpManzanaTrabajo.Properties.DataSource = ""
                For i As Integer = 0 To 3
                    If Not Me.lkpManzanaTrabajo.Properties.Columns.GetVisibleColumn(i) Is Nothing Then
                        Me.lkpManzanaTrabajo.Properties.Columns.Remove(Me.lkpManzanaTrabajo.Properties.Columns.GetVisibleColumn(i))
                    End If
                Next
                lkpManzanaTrabajo.Properties.DataSource = Nothing

                'si indicó hito, lanzar manzana de hito
                If lkpHitoTrabajo.EditValue IsNot Nothing AndAlso lkpHitoTrabajo.EditValue.ToString <> "" Then
                    lkpHitoTrabajo_EditValueChanged(lkpHitoTrabajo, Nothing)
                End If
            End If

        End If
    End Sub

    Private Sub lkpCalle2Estudio_CloseUp(sender As Object, e As DevExpress.XtraEditors.Controls.CloseUpEventArgs) Handles lkpCalle2Estudio.CloseUp
        If e.AcceptValue Then
            Dim idInterseccion As Integer
            Dim conflictiva As Integer
            Dim codigoTrasa As Integer

            If lkpCalle2Estudio.EditValue IsNot Nothing AndAlso lkpCalle2Estudio.EditValue.ToString <> "" Then
                Try
                    Dim edit As GridLookUpEdit = TryCast(sender, GridLookUpEdit)
                    Dim row As DataRowView = TryCast(edit.Properties.GetRowByKeyValue(e.Value), DataRowView)
                    idInterseccion = row.Item("id")
                    conflictiva = row.Item("conflictiva")
                    codigoTrasa = row.Item("codigoTrasa")
                    Me.x_estudio.Text = row.Item("x")
                    Me.y_estudio.Text = row.Item("y")

                    Dim objConn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\MASCARA REFERENCIA_VF.accdb")
                    objConn.Open()

                    Dim objCommand As New OleDbCommand("MzIntersec", objConn) With {.CommandType = CommandType.StoredProcedure}
                    Dim parametro As New OleDbParameter("idInter", idInterseccion)
                    objCommand.Parameters.Add(parametro)

                    Dim objAdapter As New OleDbDataAdapter(objCommand)
                    Dim objDataSet As New DataSet("ManzanaAutoE2")

                    For i As Integer = 0 To 3
                        If Not Me.lkpManzanaEstudio.Properties.Columns.GetVisibleColumn(i) Is Nothing Then
                            Me.lkpManzanaEstudio.Properties.Columns.Remove(Me.lkpManzanaEstudio.Properties.Columns.GetVisibleColumn(i))
                        End If
                    Next

                    Try
                        objAdapter.Fill(objDataSet, "ManzanaAutoE2")
                        Dim objTabla As DataTable = objDataSet.Tables("ManzanaAutoE2")
                        Me.lkpManzanaEstudio.Properties.DataSource = objTabla
                        Me.lkpManzanaEstudio.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("mz1", "mz1", 5, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
                        Me.lkpManzanaEstudio.Properties.DisplayMember = "mz1"
                        Me.lkpManzanaEstudio.Properties.ValueMember = "mz1"

                    Catch ex As Exception
                        MessageBox.Show(ex.Message + vbCrLf + vbCrLf + ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try


                    If conflictiva = 1 Then
                        MessageBox.Show("Debe escoger una manzana del siguiente mapa para identificar el lugar de bajada del transporte.", "Intersección conflictiva", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Dim mapaInterseccion As New MapaInterseccion(codigoTrasa)
                        mapaInterseccion.ShowDialog()
                        lkpManzanaEstudio.Focus()
                    ElseIf conflictiva = 0 Then
                        Dim aleatorioMax = objDataSet.Tables("ManzanaAutoE2").Rows.Count
                        Dim aleatorio As Random = New Random
                        Me.lkpManzanaEstudio.ItemIndex = aleatorio.Next(0, aleatorioMax - 1)
                        lkpDondeEstudia.Focus()
                    End If
                Catch ex As Exception
                End Try
            Else
                'borrar manzanas 
                lkpManzanaEstudio.Properties.DataSource = ""
                For i As Integer = 0 To 3
                    If Not Me.lkpManzanaEstudio.Properties.Columns.GetVisibleColumn(i) Is Nothing Then
                        Me.lkpManzanaEstudio.Properties.Columns.Remove(Me.lkpManzanaEstudio.Properties.Columns.GetVisibleColumn(i))
                    End If
                Next
                lkpManzanaEstudio.Properties.DataSource = Nothing

                'si indicó hito, lanzar manzana de hito
                If lkpHitoEstudio.EditValue IsNot Nothing AndAlso lkpHitoEstudio.EditValue.ToString <> "" Then
                    lkpHitoEstudio_EditValueChanged(lkpHitoEstudio, Nothing)
                End If
            End If

        End If
    End Sub

    Private Sub lkpCalle2trabajo_Leave(sender As Object, e As EventArgs) Handles lkpCalle2Trabajo.Leave
        If lkpManzanaTrabajo.Properties.DataSource Is Nothing Then
            Dim args As DevExpress.XtraEditors.Controls.CloseUpEventArgs = New DevExpress.XtraEditors.Controls.CloseUpEventArgs(Nothing)
            args.AcceptValue = True
            args.Value = Me.lkpCalle2Trabajo.EditValue
            Me.lkpCalle2Trabajo_CloseUp(lkpCalle2Trabajo, args)
        End If
    End Sub

    Private Sub lkpCalle2estudio_Leave(sender As Object, e As EventArgs) Handles lkpCalle2Estudio.Leave
        If lkpManzanaEstudio.Properties.DataSource Is Nothing Then
            Dim args As DevExpress.XtraEditors.Controls.CloseUpEventArgs = New DevExpress.XtraEditors.Controls.CloseUpEventArgs(Nothing)
            args.AcceptValue = True
            args.Value = Me.lkpCalle2Estudio.EditValue
            Me.lkpCalle2Estudio_CloseUp(lkpCalle2Estudio, args)
        End If
    End Sub

    Private Sub suspendBindings()
        ZonasCatBindingSource.SuspendBinding()
        ManzanasCatBindingSource.SuspendBinding()
        CatastroHogaresBindingSource.SuspendBinding()
        PropiedadBindingSource.SuspendBinding()
        ComunaBindingSource.SuspendBinding()
        TipoViviendaActualBindingSource.SuspendBinding()
        SiNoBindingSource.SuspendBinding()
        TipoVehBindingSource.SuspendBinding()
        PropiedadVehiculoBindingSource.SuspendBinding()
        ResumenVehiculosBindingSource.SuspendBinding()
        TipoDiaBindingSource.SuspendBinding()
        DondeEstudiaBindingSource.SuspendBinding()
        JornadaTrabajoBindingSource.SuspendBinding()
        ActividadBindingSource.SuspendBinding()
        EstudiosBindingSource.SuspendBinding()
        RelacionBindingSource.SuspendBinding()
        SexoBindingSource.SuspendBinding()
        ResumenPersonasBindingSource.SuspendBinding()
        HitoEstudioBindingSource.SuspendBinding()
        HitoTrabajoBindingSource.SuspendBinding()
        Calle1TrabajoBindingSource.SuspendBinding()

        Calle1EstudioBindingSource.SuspendBinding()

        ComunaTrabajoBindingSource.SuspendBinding()
        ComunaEstudioBindingSource.SuspendBinding()
    End Sub

    Private Sub resumeBindings()
        ZonasCatBindingSource.ResumeBinding()
        ManzanasCatBindingSource.ResumeBinding()
        CatastroHogaresBindingSource.ResumeBinding()
        PropiedadBindingSource.ResumeBinding()
        ComunaBindingSource.ResumeBinding()
        TipoViviendaActualBindingSource.ResumeBinding()
        SiNoBindingSource.ResumeBinding()
        TipoVehBindingSource.ResumeBinding()
        PropiedadVehiculoBindingSource.ResumeBinding()
        ResumenVehiculosBindingSource.ResumeBinding()
        TipoDiaBindingSource.ResumeBinding()
        DondeEstudiaBindingSource.ResumeBinding()
        JornadaTrabajoBindingSource.ResumeBinding()
        ActividadBindingSource.ResumeBinding()
        EstudiosBindingSource.ResumeBinding()
        RelacionBindingSource.ResumeBinding()
        SexoBindingSource.ResumeBinding()
        ResumenPersonasBindingSource.ResumeBinding()
        HitoEstudioBindingSource.ResumeBinding()
        HitoTrabajoBindingSource.ResumeBinding()
        Calle1TrabajoBindingSource.ResumeBinding()

        Calle1EstudioBindingSource.ResumeBinding()

        ComunaTrabajoBindingSource.ResumeBinding()
        ComunaEstudioBindingSource.ResumeBinding()
    End Sub

    Private Sub fillZonasCat()
        Me.ZonasCatTableAdapter.Fill(Me.datasetEOD.ZonasCat)
    End Sub

    Private Sub fillPropiedad()
        Me.PropiedadTableAdapter.Fill(Me.datasetEOD.Propiedad)
    End Sub
    Private Sub fillTipoMotor()
        Me.TipoMotorTableAdapter.Fill(Me.datasetEOD.TipoMotor)
    End Sub

    Private Sub fillComuna()
        Me.ComunaTableAdapter.Fill(Me.datasetEOD.Comuna)
    End Sub

    Private Sub fillTipoViviendaActual()
        Me.TipoViviendaActualTableAdapter.Fill(Me.datasetEOD.TipoViviendaActual)
    End Sub

    Private Sub fillSiNo()
        Me.SiNoTableAdapter.Fill(Me.datasetEOD.SiNo)
    End Sub

    Private Sub fillTipoVeh()
        Me.TipoVehTableAdapter.Fill(Me.datasetEOD.TipoVeh)
    End Sub

    Private Sub fillPropiedadVehiculo()
        Me.PropiedadVehiculoTableAdapter.Fill(Me.datasetEOD.PropiedadVehiculo)
    End Sub

    Private Sub fillResumenVehiculos()
        Me.ResumenVehiculosTableAdapter.Fill(Me.datasetEOD.ResumenVehiculos)
    End Sub

    Private Sub fillTipoDia()
        Me.TipoDiaTableAdapter.Fill(Me.datasetEOD.TipoDia)
    End Sub

    Private Sub fillDondeEstudia()
        Me.DondeEstudiaTableAdapter.Fill(Me.datasetEOD.DondeEstudia)
    End Sub

    Private Sub fillJornadaTrabajo()
        Me.JornadaTrabajoTableAdapter.Fill(Me.datasetEOD.JornadaTrabajo)
    End Sub

    Private Sub fillActividad()
        Me.ActividadTableAdapter.Fill(Me.datasetEOD.Actividad)
    End Sub

    Private Sub fillEstudios()
        Me.EstudiosTableAdapter.Fill(Me.datasetEOD.Estudios)
    End Sub

    Private Sub fillRelacion()
        Me.RelacionTableAdapter.Fill(Me.datasetEOD.Relacion)
    End Sub

    Private Sub fillSexo()
        Me.SexoTableAdapter.Fill(Me.datasetEOD.Sexo)
    End Sub

    Private Sub fillResumenPersonas()
        Me.ResumenPersonasTableAdapter.Fill(Me.datasetEOD.ResumenPersonas)
    End Sub

    Private Sub fillHito()
        Me.HitoTableAdapter.Fill(Me.datasetEOD.Hito)
    End Sub


    Private Sub fillCalle1()
        Me.CallesTableAdapter.Fill(Me.datasetEOD.Calles)
    End Sub

    Private Function validaMontosPropiedad() As Boolean

        Select Case lkpPropiedad.EditValue

            Case 1, 4, 5
                'Estimación arriendo
                Dim opcion As Boolean = chkNSNREstima.Checked
                Dim estima As String = txtEstimaArriendo.Text.Replace("$", "").Replace(".", "")
                Dim monto As Integer

                If Not opcion Then
                    If estima <> "" Then
                        monto = Convert.ToInt32(estima)

                        If monto < 10000 Then
                            validadorHogar.Val12 = True
                            Dim confirma As DialogResult = MessageBox.Show("El encuestado estima menos de $10.000 de arriendo, ¿confirma que es correcto?", "Verificación de datos", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                            If confirma = Windows.Forms.DialogResult.No Then
                                txtEstimaArriendo.Text = ""
                                txtEstimaArriendo.Focus()
                                validadorHogar.Val12 = False
                                Return False
                            ElseIf confirma = Windows.Forms.DialogResult.Yes Then
                                validadorHogar.Val12Resp = True
                                Return True
                            End If
                        ElseIf monto > 900000 Then
                            validadorHogar.Val13 = True
                            Dim confirma As DialogResult = MessageBox.Show("El encuestado estima más de $900.000 de arriendo, ¿confirma que es correcto?", "Verificación de datos", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                            If confirma = Windows.Forms.DialogResult.No Then
                                txtEstimaArriendo.Text = ""
                                txtEstimaArriendo.Focus()
                                validadorHogar.Val13 = False
                                Return False
                            ElseIf confirma = Windows.Forms.DialogResult.Yes Then
                                validadorHogar.Val13Resp = True
                                Return True
                            End If
                        Else
                            Return True
                        End If
                    Else
                        MessageBox.Show("No ha indicado estimación de arriendo, ni ha especificado si el encuestado no sabe o no contesta la información. Corrija con uno de estos antecedentes.", "Dato requerido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        txtEstimaArriendo.Focus()
                        Return False
                    End If
                End If

            Case 2
                'Dividendo
                Dim opcion As Boolean = chkNSNRDividendo.Checked
                Dim dividendo As String = txtDividendo.Text.Replace("$", "").Replace(".", "")
                Dim monto As Integer

                If Not opcion Then
                    If dividendo <> "" Then
                        monto = Convert.ToInt32(dividendo)

                        If monto < 10000 Then
                            validadorHogar.Val10 = True
                            Dim confirma As DialogResult = MessageBox.Show("El encuestado paga menos de $10.000 de dividendo, ¿confirma que es correcto?", "Verificación de datos", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                            If confirma = Windows.Forms.DialogResult.No Then
                                txtDividendo.Text = ""
                                txtDividendo.Focus()
                                validadorHogar.Val10 = False
                                Return False
                            ElseIf confirma = Windows.Forms.DialogResult.Yes Then
                                validadorHogar.Val10Resp = True
                                Return True
                            End If
                        ElseIf monto > 900000 Then
                            validadorHogar.Val11 = True
                            Dim confirma As DialogResult = MessageBox.Show("El encuestado paga más de $900.000 de dividendo, ¿confirma que es correcto?", "Verificación de datos", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                            If confirma = Windows.Forms.DialogResult.No Then
                                txtDividendo.Text = ""
                                txtDividendo.Focus()
                                validadorHogar.Val11 = False
                                Return False
                            ElseIf confirma = Windows.Forms.DialogResult.Yes Then
                                validadorHogar.Val11Resp = True
                                Return True
                            End If
                        Else
                            Return True
                        End If
                    Else
                        MessageBox.Show("No ha indicado monto de dividendo, ni ha especificado si el encuestado no sabe o no contesta la información. Corrija con uno de estos antecedentes.", "Dato requerido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        txtDividendo.Focus()
                        Return False
                    End If
                End If

            Case 3
                'Arriendo

                Dim opcion As Boolean = chkNSNRArriendo.Checked
                Dim arriendo As String = txtArriendo.Text.Replace("$", "").Replace(".", "")
                Dim monto As Integer

                If Not opcion Then
                    If arriendo <> "" Then
                        monto = Convert.ToInt32(arriendo)

                        If monto < 10000 Then
                            validadorHogar.Val12 = True
                            Dim confirma As DialogResult = MessageBox.Show("El encuestado paga menos de $10.000 de arriendo, ¿confirma que es correcto?", "Verificación de datos", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                            If confirma = Windows.Forms.DialogResult.No Then
                                txtArriendo.Text = ""
                                txtArriendo.Focus()
                                validadorHogar.Val12 = False
                                Return False
                            ElseIf confirma = Windows.Forms.DialogResult.Yes Then
                                validadorHogar.Val12Resp = True
                                Return True
                            End If
                        ElseIf monto > 900000 Then
                            validadorHogar.Val13 = True
                            Dim confirma As DialogResult = MessageBox.Show("El encuestado paga más de $900.000 de arriendo, ¿confirma que es correcto?", "Verificación de datos", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                            If confirma = Windows.Forms.DialogResult.No Then
                                txtArriendo.Text = ""
                                txtArriendo.Focus()
                                validadorHogar.Val13 = False
                                Return False
                            ElseIf confirma = Windows.Forms.DialogResult.Yes Then
                                validadorHogar.Val13Resp = True
                                Return True
                            End If
                        Else
                            Return True
                        End If
                    Else
                        MessageBox.Show("No ha indicado monto de arriendo, ni ha especificado si el encuestado no sabe o no contesta la información. Corrija con uno de estos antecedentes.", "Dato requerido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        txtArriendo.Focus()
                        Return False
                    End If
                End If
        End Select

        Return True
    End Function


    Private Function coordenadasRepetidas(ByVal coordX As Double, ByVal coordY As Double) As Boolean
        Dim repetida As Boolean = False
        Dim arrayHogares() As DataRow
        arrayHogares = datasetEOD.Hogar.Select("DirCoordX =  " & coordX & " AND DirCoordY = " & coordY)
        If arrayHogares.Count > 0 Then
            repetida = True
        End If
        Return repetida
    End Function


    Private Function fechaValida() As Boolean
        Dim valida As Boolean = True

        If (Not Me.lkpTipoDia.EditValue Is Nothing) Then
            Dim tipoEncuesta As Integer
            Dim fechaSeleccionada As DateTime = deFechaViajes.EditValue
            Dim diaSemana As Integer

            If lkpTipoDia.EditValue IsNot Nothing AndAlso lkpTipoDia.EditValue.ToString <> "" Then
                tipoEncuesta = lkpTipoDia.EditValue
                diaSemana = fechaSeleccionada.DayOfWeek

                Select Case tipoEncuesta
                    Case 1
                        If diaSemana < 1 Or diaSemana > 5 Then
                            valida = False
                        End If
                    Case 2
                        If diaSemana <> 6 Then
                            valida = False
                        End If
                    Case 3
                        If diaSemana <> 0 Then
                            valida = False
                        End If
                End Select
            End If
        Else
            valida = False
        End If

        Return valida
    End Function

    Private Sub chkActividad_Leave(sender As Object, e As EventArgs) Handles chkActividad.Leave
        Dim relacion As Integer
        If lkpRelacion.EditValue IsNot Nothing AndAlso lkpRelacion.EditValue.ToString <> "" Then
            relacion = Convert.ToInt32(lkpRelacion.EditValue.ToString)
        End If

        If relacion = 6 OrElse relacion = 7 Then
            If chkActividad.Properties.GetItems.GetCheckedValues.Contains(2) Then
                'Si estudia, foco en comuna estudio
                lkpJornadaTrabajo.ClosePopup()
                lkpComunaEstudio.Focus()
            Else
                'Sino, foco en otro integrante
                lkpJornadaTrabajo.ClosePopup()
                lkpOtraPersona.Focus()
            End If
        End If

    End Sub

    Private Sub deSabadoLV_EditValueChanged(sender As Object, e As EventArgs)
        If deSabadoLV.EditValue IsNot Nothing AndAlso deSabadoLV.EditValue.ToString <> "" Then
            Dim fechaSeleccionada As DateTime = deSabadoLV.EditValue
            Dim diaSemana As Integer = fechaSeleccionada.DayOfWeek

            If diaSemana <> 6 Then
                deSabadoLV.EditValue = ""
                MessageBox.Show("Debe elegir el día sábado del Libro de Viajes.", "Dato inconsistente", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                deDomingoLV.EditValue = fechaSeleccionada.AddDays(1)
            End If
        End If
    End Sub

    Private Sub lkpTipoDia_EditValueChanged(sender As Object, e As EventArgs)
        Dim opcion As Integer

        If lkpTipoDia.EditValue IsNot Nothing AndAlso lkpTipoDia.EditValue.ToString <> "" Then
            opcion = lkpTipoDia.EditValue
        End If

        deSabadoLV.Visible = False
        deDomingoLV.Visible = False
        lblSabadoLV.Visible = False
        lblDomingoLV.Visible = False
        lblNotaLV.Visible = False

        If opcion = 4 Then
            deSabadoLV.Visible = True
            deDomingoLV.Visible = True
            lblSabadoLV.Visible = True
            lblDomingoLV.Visible = True
            lblNotaLV.Visible = True
        End If

    End Sub

    Private Sub NuevoHogar_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

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

    Private Sub lkpTipoMotor_Enter(sender As Object, e As EventArgs) Handles lkpTipoMotor.Enter
        BeginInvoke(New MethodInvoker(Sub() CType(sender, GridLookUpEdit).ShowPopup()))
    End Sub

    Private Sub lkpPersonaDiscapacidad_Enter(sender As Object, e As EventArgs) Handles lkpPersonaDiscapacidad.Enter
        BeginInvoke(New MethodInvoker(Sub() CType(sender, GridLookUpEdit).ShowPopup()))
    End Sub

    Private Sub lkpPersonaAutosuficiente_Enter(sender As Object, e As EventArgs) Handles lkpPersonaAutosuficiente.Enter
        BeginInvoke(New MethodInvoker(Sub() CType(sender, GridLookUpEdit).ShowPopup()))
    End Sub

    Private Sub lkpTipoDiscapacidad_Enter(sender As Object, e As EventArgs) Handles lkpTipoDiscapacidad.Enter
        BeginInvoke(New MethodInvoker(Sub() CType(sender, GridLookUpEdit).ShowPopup()))
    End Sub

    Private Sub lkpIndicaGFT_Enter(sender As Object, e As EventArgs) Handles lkpIndicaGFT.Enter
        BeginInvoke(New MethodInvoker(Sub() CType(sender, GridLookUpEdit).ShowPopup()))
    End Sub

    Private Sub LkpPersonaDiscapacidad_EditValueChanged(sender As Object, e As EventArgs) Handles lkpPersonaDiscapacidad.EditValueChanged
        Dim opcion As Integer = Integer.TryParse(lkpPersonaDiscapacidad.EditValue, 0)

        spcDiscapacidad.Collapsed = True
        If opcion = 1 Then
            spcDiscapacidad.Collapsed = False
        End If

    End Sub

    Private Sub LkpIndicaGFT_EditValueChanged(sender As Object, e As EventArgs) Handles lkpIndicaGFT.EditValueChanged
        txtMontoGFT.Visible = False
        lblMontoGFT.Visible = False

        If lkpIndicaGFT.EditValue IsNot Nothing AndAlso lkpIndicaGFT.EditValue.ToString <> "" Then
            If lkpIndicaGFT.EditValue = 1 Then
                txtMontoGFT.Visible = True
                lblMontoGFT.Visible = True
            End If
        End If
    End Sub
End Class