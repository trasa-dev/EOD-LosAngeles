Imports Waymex.Gps
Imports EOD.datasetEOD
Imports DevExpress.XtraEditors

Public Class ModificarHogar

    Private hogar As HogarRow
    Private folio As Integer
    Private validadorHogar As ValidaHogarRow
    Dim gps As DeviceBase
    Dim waypoints As WaypointCollection
    Dim datasetWaypoints As DataSet
    Dim dataTableWaypoints As DataTable

    Public Sub New(ByVal folio As Integer)
        InitializeComponent()
        Me.folio = folio
        Me.HogarTableAdapter.Fill(datasetEOD.Hogar)
        Me.hogar = datasetEOD.Hogar.FindByHogar(folio)
        validadorHogar = datasetEOD.ValidaHogar.NewValidaHogarRow
        ValidaHogarTableAdapter = New datasetEODTableAdapters.ValidaHogarTableAdapter

    End Sub

    Private Sub ModificarHogar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'datasetEOD.TipoDiscapacidad' Puede moverla o quitarla según sea necesario.
        Me.TipoDiscapacidadTableAdapter.Fill(Me.datasetEOD.TipoDiscapacidad)
        cargaHogarBackground.RunWorkerAsync()
        Me.deFechaViajes.Properties.MinValue = DateTime.Today.AddDays(1)

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
            MessageBox.Show("No se ha encontrado un GPS conectado al equipo.", "GPS no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Dispose()
    End Sub

    Private Sub lkpPropiedad_EditValueChanged(sender As Object, e As EventArgs) Handles lkpPropiedad.EditValueChanged
        Dim opcion As Integer

        If lkpPropiedad.EditValue IsNot Nothing AndAlso lkpPropiedad.EditValue.ToString <> "" Then
            opcion = CInt(lkpPropiedad.EditValue)
            tabsPagoVivienda.Visible = True
        End If

        splitPropiedadPago.Collapsed = True
        txtPropiedadOtra.Visible = False
        lblPropiedadOtra.Visible = False

        Select Case opcion
            Case 1
                tabsPagoVivienda.SelectedTabPageIndex = 2
            Case 4
                tabsPagoVivienda.SelectedTabPageIndex = 2
                splitPropiedadPago.Collapsed = False
                txtPropiedadOtra.Visible = True
                lblPropiedadOtra.Visible = True
            Case 2
                tabsPagoVivienda.SelectedTabPageIndex = 0
            Case 3
                tabsPagoVivienda.SelectedTabPageIndex = 1
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

    Private Sub cargaHogarBackground_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles cargaHogarBackground.DoWork
        SplashScreenManager1 = New DevExpress.XtraSplashScreen.SplashScreenManager(Me, GetType(Global.EOD.PantallaEspera), True, True)
        SplashScreenManager1.ShowWaitForm()

        Invoke(DirectCast(AddressOf Me.fillZonasCat, MethodInvoker))
        Invoke(DirectCast(AddressOf Me.fillManzanasCat, MethodInvoker))
        Invoke(DirectCast(AddressOf Me.fillCatastroHogares, MethodInvoker))
        Invoke(DirectCast(AddressOf Me.fillPropiedad, MethodInvoker))
        Invoke(DirectCast(AddressOf Me.fillComuna, MethodInvoker))
        Invoke(DirectCast(AddressOf Me.fillTipoViviendaActual, MethodInvoker))
        Invoke(DirectCast(AddressOf Me.fillSiNo, MethodInvoker))
        Invoke(DirectCast(AddressOf Me.fillTipoDia, MethodInvoker))

    End Sub

    Private Sub fillZonasCat()
        Me.ZonasCatTableAdapter.Fill(Me.datasetEOD.ZonasCat)
    End Sub

    Private Sub fillManzanasCat()
        Me.ManzanasCatTableAdapter.Fill(Me.datasetEOD.ManzanasCat)
    End Sub

    Private Sub fillCatastroHogares()
        Me.CatastroHogaresTableAdapter.Fill(Me.datasetEOD.CatastroHogares)
    End Sub

    Private Sub fillPropiedad()
        Me.PropiedadTableAdapter.Fill(Me.datasetEOD.Propiedad)
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

    Private Sub fillTipoDia()
        Me.TipoDiaTableAdapter.Fill(Me.datasetEOD.TipoDia)
    End Sub

    Private Sub cargaHogarBackground_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles cargaHogarBackground.RunWorkerCompleted


        'Cargar formulario
        Me.lkpZona.EditValue = hogar.Zona
        Me.lkpManzana.EditValue = hogar.Manzana
        Me.lkpFolio.EditValue = hogar.Hogar
        Me.lkpComuna.EditValue = hogar.Comuna
        Me.txtCalle.Text = hogar.NombreCalle
        Me.txtNumero.Text = hogar.Numero
        Me.lkpIndicaGFT.EditValue = hogar.IndicaGFT
        If hogar.IndicaGFT Then
            Me.txtMontoGFT.Text = hogar.GastoFamiliarTransporte
        End If

        Try
            Me.txtCasaDepto.Text = hogar.CasaDepto
        Catch ex As Exception
        End Try

        If Not hogar.IsTelefonoNull Then
            Me.txtTelefono.Text = hogar.Telefono
        End If

        Me.lkpTipoVivienda.EditValue = hogar.TipoViviendaActual
        lkpPropiedad.EditValue = hogar.Propiedad

        splitPropiedadPago.Collapsed = True

        Select Case hogar.Propiedad
            Case 1
                chkNSNREstima.Checked = hogar.NoSabeNoResponde
                If Not hogar.NoSabeNoResponde Then
                    txtEstimaArriendo.Text = hogar.MontoEst
                End If
            Case 4
                Me.chkNSNREstima.Checked = hogar.NoSabeNoResponde
                If Not hogar.NoSabeNoResponde Then
                    txtEstimaArriendo.Text = hogar.MontoEst
                End If

                If hogar.Propiedad = 5 Then
                    txtPropiedadOtra.Text = hogar.PropiedadOtra
                    splitPropiedadPago.Collapsed = False
                End If
            Case 2
                chkNSNRDividendo.Checked = hogar.NoSabeNoResponde
                If Not hogar.NoSabeNoResponde Then
                    txtDividendo.Text = hogar.MontoDiv
                End If
            Case 3
                chkNSNRArriendo.Checked = CBool(hogar.NoSabeNoResponde)
                If Not hogar.NoSabeNoResponde Then
                    txtArriendo.Text = hogar.MontoArr
                End If
        End Select

        Try
            txtObservacion.Text = hogar.Observacion
        Catch ex As Exception
        End Try

        If hogar.EstadoEncuesta = 1 Then
            lkpTipoDia.Enabled = True
            deFechaViajes.Enabled = True
            deSabadoLV.Enabled = True
        ElseIf hogar.EstadoEncuesta = 3 Then
            lkpTipoDia.EditValue = hogar.TipoDia
            Select Case hogar.TipoDia
                Case 1
                    deFechaViajes.EditValue = hogar.FechaViajesLab
                Case 2
                    deFechaViajes.EditValue = hogar.FechaViajesSab
                Case 3
                    deFechaViajes.EditValue = hogar.FechaViajesDom
                Case 4
                    deFechaViajes.EditValue = hogar.FechaViajesLab
                    deSabadoLV.EditValue = hogar.FechaViajesSab
                    deDomingoLV.EditValue = hogar.FechaViajesDom
            End Select

            Me.lkpTipoDia.Enabled = False
            Me.deFechaViajes.Enabled = False
            Me.deSabadoLV.Enabled = False
            Me.deDomingoLV.Enabled = False
        End If

        If SplashScreenManager1 IsNot Nothing Then
            SplashScreenManager1.CloseWaitForm()
        End If
    End Sub

    Private Function hogarCompleto() As Boolean
        Dim completo As Boolean = True

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

            Select Case lkpPropiedad.EditValue.ToString
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

        If hogar.EstadoEncuesta = 1 Then
            'Campo Tipo Dia
            If lkpTipoDia.EditValue Is Nothing OrElse lkpTipoDia.EditValue.ToString = "" OrElse lkpTipoDia.EditValue < 1 Then
                completo = False
                lkpTipoDia.Properties.Appearance.BorderColor = Color.Red
            Else
                lkpTipoDia.Properties.Appearance.BorderColor = Nothing
            End If

            'Campo fecha viajes
            If deFechaViajes.EditValue Is Nothing OrElse deFechaViajes.EditValue.ToString = "" Then
                completo = False
                deFechaViajes.Properties.Appearance.BorderColor = Color.Red
            Else
                deFechaViajes.Properties.Appearance.BorderColor = Nothing
            End If
        End If

        Return completo
    End Function

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If hogarCompleto() Then

            'Validador de montos de arriendo, dividendo y estimación de arriendo
            If Not validaMontosPropiedad() Then
                Return
            End If

            hogar.NombreCalle = Me.txtCalle.Text

            If Me.txtNumero.Text <> "" Then
                hogar.Numero = Me.txtNumero.Text
            End If

            If Me.txtCasaDepto.Text <> "" Then
                hogar.CasaDepto = Me.txtCasaDepto.Text
            End If

            hogar.Propiedad = Me.lkpPropiedad.EditValue.ToString
            hogar.Telefono = Me.txtTelefono.Text
            hogar.TipoViviendaActual = Me.lkpTipoVivienda.EditValue.ToString

            hogar.IndicaGFT = IIf(Me.lkpIndicaGFT.EditValue = 1, True, False)
            If hogar.IndicaGFT Then
                hogar.GastoFamiliarTransporte = Me.txtMontoGFT.Text
            End If

            hogar.Observacion = Me.txtObservacion.Text

            If hogar.EstadoEncuesta = 1 Then
                hogar.TipoDia = Me.lkpTipoDia.EditValue
            End If


            Select Case hogar.TipoDia
                Case 1
                    hogar.FechaViajesLab = Me.deFechaViajes.EditValue
                Case 2
                    hogar.FechaViajesSab = Me.deFechaViajes.EditValue
                Case 3
                    hogar.FechaViajesDom = Me.deFechaViajes.EditValue
                Case 4
                    hogar.FechaViajesLab = Me.deFechaViajes.EditValue
                    hogar.FechaViajesSab = Me.deSabadoLV.EditValue
                    hogar.FechaViajesDom = Me.deDomingoLV.EditValue
            End Select

            Select Case hogar.Propiedad
                Case 1
                    hogar.NoSabeNoResponde = Me.chkNSNREstima.Checked
                    If Not hogar.NoSabeNoResponde Then
                        hogar.MontoEst = Me.txtEstimaArriendo.Text
                    End If
                Case 4
                    hogar.NoSabeNoResponde = Me.chkNSNREstima.Checked
                    If Not hogar.NoSabeNoResponde Then
                        hogar.MontoEst = Me.txtEstimaArriendo.Text
                    End If
                    hogar.PropiedadOtra = Me.txtPropiedadOtra.Text
                Case 2
                    hogar.NoSabeNoResponde = Me.chkNSNRDividendo.Checked
                    If Not hogar.NoSabeNoResponde Then
                        hogar.MontoDiv = Me.txtDividendo.Text
                    End If
                Case 3
                    hogar.NoSabeNoResponde = Me.chkNSNRArriendo.Checked
                    If Not hogar.NoSabeNoResponde Then
                        hogar.MontoArr = Me.txtArriendo.Text
                    End If
            End Select

            If dataTableWaypoints IsNot Nothing Then
                Dim rowWaypoint As DataRow = dataTableWaypoints.Rows(cbWaypoint.SelectedIndex)
                hogar.DirCoordX = rowWaypoint.Item("Longitude")
                hogar.DirCoordY = rowWaypoint.Item("Latitude")
            End If

            Try
                ValidaHogarTableAdapter.Update(datasetEOD.ValidaHogar)
                HogarTableAdapter.Update(datasetEOD.Hogar)
                MessageBox.Show("Hogar modificado exitosamente", "Datos guardados", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Dispose()
            Catch ex As Exception
                MessageBox.Show("Error al guardar hogar. Intente nuevamente" + vbCrLf + vbCrLf + ex.Message + vbCrLf + vbCrLf + ex.StackTrace, "Datos no guardados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            MessageBox.Show("No ha contestado las preguntas mínimas para terminar la modificación del hogar. Por favor, complete los campos marcados con rojo.", "Datos insuficientes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
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
                            validadorHogar.Val11Resp = True
                        End If
                    Else
                        txtObservacion.Focus()
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
                        ElseIf confirma = Windows.Forms.DialogResult.Yes Then
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
                            validadorHogar.Val13Resp = True
                        End If
                    Else
                        txtObservacion.Focus()
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
                            validadorHogar.Val13Resp = True
                        End If
                    Else
                        txtObservacion.Focus()
                    End If
                Else
                    MessageBox.Show("No ha indicado monto de arriendo, ni ha especificado si el encuestado no sabe o no contesta la información. Corrija con uno de estos antecedentes.", "Dato requerido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    txtArriendo.Focus()
                End If
            End If
        End If

    End Sub

    Private Sub deFechaViajes_EditValueChanged(sender As Object, e As EventArgs)
        If (Not Me.lkpTipoDia.EditValue Is Nothing) Then
            Dim tipoEncuesta As Integer
            Dim fechaSeleccionada As DateTime = deFechaViajes.EditValue
            Dim diaSemana As Integer

            If lkpTipoDia.EditValue IsNot Nothing AndAlso Me.lkpTipoDia.EditValue.ToString <> "" Then
                tipoEncuesta = lkpTipoDia.EditValue
                diaSemana = fechaSeleccionada.DayOfWeek

                Select Case tipoEncuesta
                    Case 1
                        If diaSemana < 1 Or diaSemana > 5 Then
                            MessageBox.Show("Ha escogido tipo de encuesta laboral. La fecha de viajes debe ser entre Lunes y Viernes.", "Inconsistencia en día seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            deFechaViajes.EditValue = Nothing
                            deFechaViajes.Focus()
                        End If
                    Case 2
                        If diaSemana <> 6 Then
                            MessageBox.Show("Ha escogido tipo de encuesta Sábado. La fecha de viajes debe ser un día Sábado.", "Inconsistencia en día seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            deFechaViajes.EditValue = Nothing
                            deFechaViajes.Focus()
                        End If
                    Case 3
                        If diaSemana <> 0 Then
                            MessageBox.Show("Ha escogido tipo de encuesta Domingo. La fecha de viajes debe ser un día Domingo.", "Inconsistencia en día seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            deFechaViajes.EditValue = Nothing
                            deFechaViajes.Focus()
                        End If
                End Select
            End If
        End If
    End Sub

    Private Sub lkpTipoVivienda_Enter(sender As Object, e As EventArgs) Handles lkpTipoVivienda.Enter
        BeginInvoke(New MethodInvoker(Sub() CType(sender, GridLookUpEdit).ShowPopup()))
    End Sub

    Private Sub lkpPropiedad_Enter(sender As Object, e As EventArgs) Handles lkpPropiedad.Enter
        BeginInvoke(New MethodInvoker(Sub() CType(sender, GridLookUpEdit).ShowPopup()))
    End Sub

    Private Sub lkpTipoDia_Enter(sender As Object, e As EventArgs)
        BeginInvoke(New MethodInvoker(Sub() CType(sender, GridLookUpEdit).ShowPopup()))
    End Sub

    Private Sub deFechaViajes_Enter(sender As Object, e As EventArgs)
        BeginInvoke(New MethodInvoker(Sub() CType(sender, DateEdit).ShowPopup()))
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

    Private Sub lkpTipoDia_EditValueChanged(sender As Object, e As EventArgs)
        Dim opcion As Integer

        If lkpTipoDia.EditValue IsNot Nothing AndAlso lkpTipoDia.EditValue.ToString <> "" Then
            opcion = lkpTipoDia.EditValue
        End If

        deSabadoLV.Visible = False
        deDomingoLV.Visible = False
        lblSabadoLV.Visible = False
        lblDomingoLV.Visible = False

        If opcion = 4 Then
            deSabadoLV.Visible = True
            deDomingoLV.Visible = True
            lblSabadoLV.Visible = True
            lblDomingoLV.Visible = True
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

    Private Sub LkpIndicaGFT_EditValueChanged(sender As Object, e As EventArgs) Handles lkpIndicaGFT.EditValueChanged
        Dim opcion As Integer
        lblMontoGFT.Visible = False
        txtMontoGFT.Visible = False

        If lkpIndicaGFT.EditValue IsNot Nothing AndAlso lkpIndicaGFT.EditValue.ToString <> "" Then
            opcion = lkpIndicaGFT.EditValue
        End If

        If opcion = 1 Then
            lblMontoGFT.Visible = True
            txtMontoGFT.Visible = True
        End If
    End Sub
End Class