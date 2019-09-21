Imports DevExpress.XtraEditors
Imports EOD.datasetEOD

Public Class ModificarVehiculo

    Dim idHogar As Integer
    Dim idVehiculo As Integer
    Private vehiculo As VehiculoRow

    Sub New(ByVal idHogar As Integer, ByVal idVehiculo As Integer)
        InitializeComponent()
        Me.idHogar = idHogar
        Me.idVehiculo = idVehiculo
        Me.VehiculoTableAdapter.Fill(datasetEOD.Vehiculo)
        Me.vehiculo = datasetEOD.Vehiculo.FindByHogarVehículo(idHogar, idVehiculo)
    End Sub

    Private Sub ModificarVehiculo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargaVehiculoBackground.RunWorkerAsync()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Dim resultado As DialogResult = XtraMessageBox.Show("¿Seguro que desea cancelar la edición de este vehículo?", "Confirmar", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
        If resultado = Windows.Forms.DialogResult.OK Then
            Me.Close()
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

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If vehiculoCompleto() Then
            'Grabar vehiculo en base de datos 

            vehiculo.TipoVeh = Integer.Parse(Me.lkpTipoVeh.EditValue.ToString)
            vehiculo.Propiedad = Integer.Parse(Me.lkpPropiedadVeh.EditValue.ToString)
            vehiculo.PropiedadOtro = Me.txtPropiedadVehOtro.Text
            vehiculo.Combustible = Me.lkpCombustible.EditValue
            If vehiculo.Combustible = 3 Then
                vehiculo.CombustibleOtro = Me.txtCombustibleOtro.Text
            End If

            Try
                VehiculoTableAdapter.Update(datasetEOD.Vehiculo)
                MessageBox.Show("Vehículo modificado exitosamente", "Datos guardados", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Dispose()
            Catch ex As Exception
                MessageBox.Show("Error al modificar vehículo. Intente nuevamente" + ex.StackTrace, "Datos no guardados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            MessageBox.Show("No ha contestado las preguntas mínimas para terminar con la modificación del vehículo. Por favor, complete los campos marcados con rojo.", "Datos insuficientes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub cargaVehiculoBackground_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles cargaVehiculoBackground.DoWork
        SplashScreenManager1 = New DevExpress.XtraSplashScreen.SplashScreenManager(Me, GetType(Global.EOD.PantallaEspera), True, True)
        SplashScreenManager1.ShowWaitForm()

        Invoke(DirectCast(AddressOf Me.fillCombustible, MethodInvoker))
        Invoke(DirectCast(AddressOf Me.fillTipoVeh, MethodInvoker))
        Invoke(DirectCast(AddressOf Me.fillPropiedadVehiculo, MethodInvoker))
    End Sub

    Private Sub fillCombustible()
        Me.CombustibleTableAdapter.Fill(Me.datasetEOD.Combustible)
    End Sub

    Private Sub fillTipoVeh()
        Me.TipoVehTableAdapter.Fill(Me.datasetEOD.TipoVeh)
    End Sub

    Private Sub fillPropiedadVehiculo()
        Me.PropiedadVehiculoTableAdapter.Fill(Me.datasetEOD.PropiedadVehiculo)
    End Sub

    Private Sub cargaVehiculoBackground_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles cargaVehiculoBackground.RunWorkerCompleted
        'Cargar formulario
        Me.lkpTipoVeh.EditValue = vehiculo.TipoVeh
        Me.lkpPropiedadVeh.EditValue = vehiculo.Propiedad
        If vehiculo.Propiedad = 2 Then
            txtPropiedadVehOtro.Text = vehiculo.PropiedadOtro
        End If
        Me.lkpCombustible.EditValue = vehiculo.Combustible
        If vehiculo.Combustible = 3 Then
            Me.txtCombustibleOtro.Text = vehiculo.CombustibleOtro
        End If

        If SplashScreenManager1 IsNot Nothing Then
            SplashScreenManager1.CloseWaitForm()
        End If
    End Sub

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

        'Campo Combustible
        If lkpCombustible.EditValue Is Nothing OrElse lkpCombustible.EditValue.ToString = "" OrElse lkpCombustible.EditValue < 1 Then
            completo = False
            lkpCombustible.Properties.Appearance.BorderColor = Color.Red
        ElseIf lkpCombustible.EditValue = 3 Then
            lkpCombustible.Properties.Appearance.BorderColor = Nothing
            'Campo Otra Propiedad
            If txtCombustibleOtro.Text = "" Then
                completo = False
                txtCombustibleOtro.Properties.Appearance.BorderColor = Color.Red
            Else
                txtCombustibleOtro.Properties.Appearance.BorderColor = Nothing
            End If
        Else
            lkpCombustible.Properties.Appearance.BorderColor = Nothing
        End If


        Return completo
    End Function

    Private Sub lkpCombustible_EditValueChanged(sender As Object, e As EventArgs) Handles lkpCombustible.EditValueChanged
        Dim opcion As Integer = IIf(lkpCombustible.EditValue IsNot Nothing AndAlso lkpCombustible.EditValue.ToString <> "", lkpCombustible.EditValue, 0)
        Me.lblCombustibleOtro.Visible = False
        Me.txtCombustibleOtro.Visible = False

        If opcion = 3 Then
            Me.lblCombustibleOtro.Visible = True
            Me.txtCombustibleOtro.Visible = True
        End If
    End Sub

    Private Sub lkpTipoVeh_Enter(sender As Object, e As EventArgs) Handles lkpTipoVeh.Enter
        BeginInvoke(New MethodInvoker(Sub() CType(sender, GridLookUpEdit).ShowPopup()))
    End Sub

    Private Sub lkpCombustible_Enter(sender As Object, e As EventArgs) Handles lkpCombustible.Enter
        BeginInvoke(New MethodInvoker(Sub() CType(sender, GridLookUpEdit).ShowPopup()))
    End Sub

    Private Sub lkpPropiedadVeh_Enter(sender As Object, e As EventArgs) Handles lkpPropiedadVeh.Enter
        BeginInvoke(New MethodInvoker(Sub() CType(sender, GridLookUpEdit).ShowPopup()))
    End Sub
End Class