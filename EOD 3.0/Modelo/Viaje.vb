Imports System.Data.OleDb

Public Class Viaje
    Public hogar As Double
    Public persona As Integer
    Public viaje As Integer
    Public etapas As Integer

    Public comunaOrigen As Integer
    Public comunaOrigenOtra As String = ""
    Public comunaDestino As Integer
    Public comunaDestinoOtra As String = ""
    Public macrozonaOrigen As Integer
    Public macrozonaDestino As Integer
    Public zonaOrigen As Integer
    Public zonaDestino As Integer
    Public manzanaOrigen As Integer
    Public manzanaDestino As Integer

    Public nombreCalle1Origen As String = ""
    Public numeroOCalle2Origen As String = ""
    Public hitoOrigen As String = ""
    Public origenCoordX As Double
    Public origenCoordY As Double

    Public nombreCalle1Destino As String = ""
    Public numeroOCalle2Destino As String = ""
    Public hitoDestino As String = ""
    Public destinoCoordX As Double
    Public destinoCoordY As Double

    Public proposito As Integer
    Public propositoOtro As String = ""
    Public propositoEstraus As Integer
    Public mediosUsados As String = ""

    Public horaIni As Date = New DateTime(Now.Year, Now.Month, Now.Day, Now.Hour, Now.Minute, Now.Second)
    Public horaFin As Date = New DateTime(Now.Year, Now.Month, Now.Day, Now.Hour, Now.Minute, Now.Second)
    Public horaMedia As String = ""

    Public trasnoche As Integer
    Public tiempoViaje As Integer
    Public tiempoMedio As Integer

    Public minutosDespues As Integer
    Public cuadrasDespues As Integer

    Public Sub New(ByVal hogar As Double, ByVal persona As Integer, ByVal viaje As Integer)
        Me.hogar = hogar
        Me.persona = persona
        Me.viaje = viaje
    End Sub

    Public Sub guardar()
        Try
            Dim objConn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\MASCARA REFERENCIA_VF.accdb")
            objConn.Open()
            Dim objCommand As New OleDbCommand("insert into viaje (hogar, persona, viaje, comunaOrigen, comunaOtraOrigen, comunaDestino, comunaOtraDestino, nombreCalle1Origen, numeroOCalle2Origen, " +
                                               "hitoOrigen, nombreCalle1Destino, numeroOCalle2Destino, hitoDestino, proposito, propositoOtro, horaini, horafin, trasnoche, minutosDespues, cuadrasDespues, manzanaOrigen, manzanaDestino, origencoordx, origencoordy, destinocoordx, destinocoordy, etapas, zonaorigen, zonadestino) " +
                                                "values (?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?)", objConn)
            Dim parametro1 As New OleDbParameter("hogar", Me.hogar)
            Dim parametro2 As New OleDbParameter("persona", Me.persona)
            Dim parametro3 As New OleDbParameter("viaje", Me.viaje)
            Dim parametro4 As New OleDbParameter("comunaOrigen", Me.comunaOrigen)
            Dim parametro5 As New OleDbParameter("comunaOtraOrigen", Me.comunaOrigenOtra)
            Dim parametro6 As New OleDbParameter("comunaDestino", Me.comunaDestino)
            Dim parametro7 As New OleDbParameter("comunaOtraDestino", Me.comunaDestinoOtra)
            Dim parametro8 As New OleDbParameter("nombreCalle1Origen", Me.nombreCalle1Origen)
            Dim parametro9 As New OleDbParameter("numeroOCalle2Origen", Me.numeroOCalle2Origen)
            Dim parametro10 As New OleDbParameter("hitoOrigen", Me.hitoOrigen)
            Dim parametro11 As New OleDbParameter("nombreCalle1Destino", Me.nombreCalle1Destino)
            Dim parametro12 As New OleDbParameter("numeroOCalle2Destino", Me.numeroOCalle2Destino)
            Dim parametro13 As New OleDbParameter("hitoDestino", Me.hitoDestino)
            Dim parametro14 As New OleDbParameter("proposito", Me.proposito)
            Dim parametro15 As New OleDbParameter("propositoOtro", Me.propositoOtro)
            Dim parametro16 As New OleDbParameter("horaIni", Me.horaIni)
            Dim parametro17 As New OleDbParameter("horaFin", Me.horaFin)
            Dim parametro18 As New OleDbParameter("trasnoche", Me.trasnoche)
            Dim parametro19 As New OleDbParameter("minutosDespues", Me.minutosDespues)
            Dim parametro20 As New OleDbParameter("cuadrasDespues", Me.cuadrasDespues)
            Dim parametro21 As New OleDbParameter("manzanaOrigen", Me.manzanaOrigen)
            Dim parametro22 As New OleDbParameter("manzanaDestino", Me.manzanaDestino)
            Dim parametro23 As New OleDbParameter("origencoordx", Me.origenCoordX)
            Dim parametro24 As New OleDbParameter("origencoordy", Me.origenCoordY)
            Dim parametro25 As New OleDbParameter("destinocoordx", Me.destinoCoordX)
            Dim parametro26 As New OleDbParameter("destinocoordy", Me.destinoCoordY)
            Dim parametro27 As New OleDbParameter("etapas", Me.etapas)
            Dim parametro28 As New OleDbParameter("zonaorigen", Me.zonaOrigen)
            Dim parametro29 As New OleDbParameter("zonadestino", Me.zonaDestino)

            objCommand.Parameters.Add(parametro1)
            objCommand.Parameters.Add(parametro2)
            objCommand.Parameters.Add(parametro3)
            objCommand.Parameters.Add(parametro4)
            objCommand.Parameters.Add(parametro5)
            objCommand.Parameters.Add(parametro6)
            objCommand.Parameters.Add(parametro7)
            objCommand.Parameters.Add(parametro8)
            objCommand.Parameters.Add(parametro9)
            objCommand.Parameters.Add(parametro10)
            objCommand.Parameters.Add(parametro11)
            objCommand.Parameters.Add(parametro12)
            objCommand.Parameters.Add(parametro13)
            objCommand.Parameters.Add(parametro14)
            objCommand.Parameters.Add(parametro15)
            objCommand.Parameters.Add(parametro16)
            objCommand.Parameters.Add(parametro17)
            objCommand.Parameters.Add(parametro18)
            objCommand.Parameters.Add(parametro19)
            objCommand.Parameters.Add(parametro20)
            objCommand.Parameters.Add(parametro21)
            objCommand.Parameters.Add(parametro22)
            objCommand.Parameters.Add(parametro23)
            objCommand.Parameters.Add(parametro24)
            objCommand.Parameters.Add(parametro25)
            objCommand.Parameters.Add(parametro26)
            objCommand.Parameters.Add(parametro27)
            objCommand.Parameters.Add(parametro28)
            objCommand.Parameters.Add(parametro29)

            Dim resultado As Integer = objCommand.ExecuteNonQuery()

            If resultado > 0 Then
                MessageBox.Show("Viaje guardado exitosamente", "Datos ok", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("No se pudo guardar el viaje en la base de datos.", "Datos ok", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message + vbCrLf + vbCrLf + ex.StackTrace, "Error de base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class
