Imports EOD.datasetEOD
Imports EOD.datasetEODTableAdapters

Public Class RechazoEncuesta

    Private dataset As datasetEOD
    Private hogar As HogarRow
    Private estado As Integer

    Public Sub New(ByVal hogar As Integer, Optional ByVal estado As Integer = 2)

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        dataset = New datasetEOD
        HogarTableAdapter.Fill(dataset.Hogar)
        UsuarioTableAdapter.Fill(dataset.Usuario)
        Me.hogar = dataset.Hogar.FindByHogar(hogar)

        Me.lblCalle.Text = Me.hogar.NombreCalle
        Me.lblNumero.Text = Me.hogar.Numero
        Try
            Me.lblCasaDepto.Text = Me.hogar.CasaDepto
        Catch ex As Exception
            Me.lblCasaDepto.Text = ""
        End Try
        Me.lblFolio.Text = Me.hogar.Hogar.ToString
        Me.lblZona.Text = Me.hogar.Zona.ToString
        Me.lblManzana.Text = Me.hogar.Manzana.ToString
        Me.estado = estado
    End Sub

    Private Sub btnRechazar_Click(sender As Object, e As EventArgs) Handles btnRechazar.Click
        If txtClave.Text <> "" Then
            Dim claveIngresada As String = Me.txtClave.Text

            Dim usuario As UsuarioRow = dataset.Usuario.FindByID(My.Settings.IdUsuario)
            If usuario.pwd <> claveIngresada Then
                MessageBox.Show("La clave es incorrecta, reintente.", "Clave no válida", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                'Cambiar estado a encuesta
                hogar.EstadoEncuesta = estado
                HogarTableAdapter.Update(dataset.Hogar)
                MessageBox.Show("Se ha cambiado correctamente el estado de la encuesta a Rechazada.", "Encuesta rechazada", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Dispose()
            End If
        Else
            MessageBox.Show("Debe ingresar su clave para terminar.", "Clave no válida", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class