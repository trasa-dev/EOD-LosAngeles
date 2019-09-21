Public Class Login 

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click

        Dim samplePrincipal As New EodIPrincipal(Me.txtUsuario.Text, Me.txtPassword.Text)
        Me.txtPassword.Text = ""
        If (Not samplePrincipal.Identity.IsAuthenticated) Then
            ' The user is still not validated.
            MessageBox.Show("Credenciales no válidas, reintente.", "Acceso no autorizado", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Else
            ' Update the current principal.
            My.User.CurrentPrincipal = samplePrincipal

            If My.User.IsInRole(ApplicationServices.BuiltInRole.Administrator) Then
                'Usuario es Admin
                Dim ventanaPrincipal As New GrillaResumen
                ventanaPrincipal.Show()
                Me.Close()
            ElseIf My.User.IsInRole(ApplicationServices.BuiltInRole.SystemOperator) Then
                'Usuario es Supervisor
                Dim ventanaPrincipal As New GrillaResumen
                ventanaPrincipal.Show()
                Me.Close()
            ElseIf My.User.IsInRole(ApplicationServices.BuiltInRole.User) Then
                'Usuario es Encuestador
                Dim ventanaPrincipal As New GrillaResumen
                ventanaPrincipal.Show()
                Me.Close()
            End If
        End If
    End Sub

    Private Sub txtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnIngresar_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Dispose()
    End Sub

End Class