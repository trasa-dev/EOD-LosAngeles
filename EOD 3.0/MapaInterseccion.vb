Public Class MapaInterseccion 

    Public Sub New(ByVal idInterseccion As Integer)
        InitializeComponent()
        Dim rutaMapa As String = "C:\conflictivas\" & idInterseccion & ".jpg"

        If System.IO.File.Exists(rutaMapa) Then
            Me.imagenMapa.Image = Image.FromFile(rutaMapa)
        Else
            MessageBox.Show(rutaMapa)
        End If
    End Sub
End Class