Imports System.Data.OleDb

Public Class Etapa
    Public hogar As Double
    Public persona As Integer
    Public viaje As Integer
    Public etapa As Integer


    Public zonaOrigen As Integer = 0
    Public zonaDestino As Integer = 0
    Public comunaOrigen As Integer = 0
    Public comunaOrigenOtra As String = ""
    Public comunaDestino As Integer = 0
    Public comunaDestinoOtra As String = ""
    Public manzanaOrigen As Integer = 0
    Public manzanaDestino As Integer = 0

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

    Public modo As Integer
    Public cuadrasAntes As Integer
    Public minutosAntes As Integer

    'Variables modo Auto
    Public viajaComo As Integer = -1
    Public queVehiculo As Integer = -1
    Public idVehiculoHogar As Integer = -1
    Public autopista As String = ""
    Public estaciona As Integer = -1
    Public formaPago As Integer = -1
    Public costoEstacionamiento As Integer = -1
    Public lugarDondeBajo As Integer = -1

    'Variables modo Bus
    Public recorridoBus As Integer = -1
    Public tiempoEsperaBus As Integer = -1
    Public dejoPasarBus As Integer = -1
    Public busesPerdidos As Integer = -1
    Public tipoTarifaBus As Integer = -1
    Public tarifaBus As Integer = -1

    'Variables modo TXC
    Public recorridoTXC As Integer = -1
    Public tiempoEsperaTXC As Integer = -1
    Public dejoPasarTXC As Integer = -1
    Public txcPerdidos As Integer = -1
    Public tarifaTXC As Integer = -1

    'Variables modo Taxi
    Public tiempoEsperaTaxi As Integer = -1
    Public tarifaTaxi As Integer = -1

    'Variables modo Bicicleta
    Public propiedadBicicleta As Integer = -1
    Public usaCiclovia As Integer = -1
    Public usoHabitualBicicleta As Integer = -1
    Public estacionaBicicleta As Integer = -1
    Public modoEstacionaBicicleta As Integer = -1

    Public Sub New(ByVal hogar As Integer, ByVal persona As Integer, ByVal viaje As Integer, ByVal etapa As Integer)
        Me.hogar = hogar
        Me.persona = persona
        Me.viaje = viaje
        Me.etapa = etapa
    End Sub

    Public Sub guardar()

        Dim objConn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\MASCARA REFERENCIA_VF.accdb")
        objConn.Open()
        Dim objCommand As New OleDbCommand("insert into etapa (hogar, persona, viaje, etapa, zonaOrigen, zonaDestino, comunaOrigen, comunaOtraOrigen, comunaDestino, comunaOtraDestino, nombreCalle1Origen, numeroOCalle2Origen, " +
                                           "HitoOrigen, nombreCalle1Destino, numeroOCalle2Destino, HitoDestino, modo, cuadrasAntes, minutosAntes, ViajaComo, QueVehiculo, IdVehiculoHogar, Autopista, Estaciona, FormaPago, CostoEstacionamiento, LugarDondeBajo," +
                                           "RecorridoBus, TiempoEsperaBus, DejoPasarBus, BusesPerdidos, TipoTarifaBus, TarifaBus, RecorridoTxc, TiempoEsperaTxc, DejoPasarTxc, TxcPerdidos, TarifaTxc," +
                                            "TiempoEsperaTaxi, TarifaTaxi, PropiedadBicicleta, UsaCiclovia, UsoHabitualBicicleta, EstacionaBicicleta, ModoEstacionaBicicleta,manzanaOrigen, manzanaDestino, origencoordx, origencoordy, destinocoordx, destinocoordy)" +
                                           "values (?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?)", objConn)
        Dim parametro1 As New OleDbParameter("hogar", Me.hogar)
        Dim parametro2 As New OleDbParameter("persona", Me.persona)
        Dim parametro3 As New OleDbParameter("viaje", Me.viaje)
        Dim parametro4 As New OleDbParameter("etapa", Me.etapa)
        Dim parametro5 As New OleDbParameter("zonaOrigen", Me.zonaOrigen)
        Dim parametro6 As New OleDbParameter("zonaDestino", Me.zonaDestino)
        Dim parametro7 As New OleDbParameter("comunaOrigen", Me.comunaOrigen)
        Dim parametro8 As New OleDbParameter("comunaOtraOrigen", Me.comunaOrigenOtra)
        Dim parametro9 As New OleDbParameter("comunaDestino", Me.comunaDestino)
        Dim parametro10 As New OleDbParameter("comunaOtraDestino", Me.comunaDestinoOtra)
        Dim parametro11 As New OleDbParameter("nombreCalle1Origen", Me.nombreCalle1Origen)
        Dim parametro12 As New OleDbParameter("numeroOCalle2Origen", Me.numeroOCalle2Origen)
        Dim parametro13 As New OleDbParameter("hitoOrigen", Me.hitoOrigen)
        Dim parametro14 As New OleDbParameter("nombreCalle1Destino", Me.nombreCalle1Destino)
        Dim parametro15 As New OleDbParameter("numeroOCalle2Destino", Me.numeroOCalle2Destino)
        Dim parametro16 As New OleDbParameter("hitoDestino", Me.hitoDestino)
        Dim parametro17 As New OleDbParameter("modo", Me.modo)
        Dim parametro18 As New OleDbParameter("cuadrasAntes", Me.cuadrasAntes)
        Dim parametro19 As New OleDbParameter("minutosAntes", Me.minutosAntes)
        Dim parametro20 As New OleDbParameter("viajacomo", Me.viajaComo)
        Dim parametro21 As New OleDbParameter("QueVehiculo", Me.queVehiculo)
        Dim parametro22 As New OleDbParameter("idvehiculohogar", Me.idVehiculoHogar)
        Dim parametro23 As New OleDbParameter("autopista", Me.autopista)
        Dim parametro24 As New OleDbParameter("estaciona", Me.estaciona)
        Dim parametro25 As New OleDbParameter("formapago", Me.formaPago)
        Dim parametro26 As New OleDbParameter("costoestacionamiento", Me.costoEstacionamiento)
        Dim parametro27 As New OleDbParameter("lugardondebajo", Me.lugarDondeBajo)
        Dim parametro28 As New OleDbParameter("RecorridoBus", Me.recorridoBus)
        Dim parametro29 As New OleDbParameter("TiempoEsperaBus", Me.tiempoEsperaBus)
        Dim parametro30 As New OleDbParameter("DejoPasarBus", Me.dejoPasarBus)
        Dim parametro31 As New OleDbParameter("BusesPerdidos", Me.busesPerdidos)
        Dim parametro32 As New OleDbParameter("TipoTarifaBus", Me.tipoTarifaBus)
        Dim parametro33 As New OleDbParameter("TarifaBus", Me.tarifaBus)
        Dim parametro34 As New OleDbParameter("RecorridoTxc", Me.recorridoTXC)
        Dim parametro35 As New OleDbParameter("TiempoEsperaTxc", Me.tiempoEsperaTXC)
        Dim parametro36 As New OleDbParameter("DejoPasarTxc", Me.dejoPasarTXC)
        Dim parametro37 As New OleDbParameter("TxcPerdidos", Me.txcPerdidos)
        Dim parametro38 As New OleDbParameter("TarifaTxc", Me.tarifaTxc)
        Dim parametro39 As New OleDbParameter("TiempoEsperaTaxi", Me.tiempoEsperaTaxi)
        Dim parametro40 As New OleDbParameter("TarifaTaxi", Me.tarifaTaxi)
        Dim parametro41 As New OleDbParameter("PropiedadBicicleta", Me.propiedadBicicleta)
        Dim parametro42 As New OleDbParameter("UsaCiclovia", Me.usaCiclovia)
        Dim parametro43 As New OleDbParameter("UsoHabitualBicicleta", Me.usoHabitualBicicleta)
        Dim parametro44 As New OleDbParameter("EstacionaBicicleta", Me.estacionaBicicleta)
        Dim parametro45 As New OleDbParameter("ModoEstacionaBicicleta", Me.modoEstacionaBicicleta)
        Dim parametro46 As New OleDbParameter("manzanaOrigen", Me.manzanaOrigen)
        Dim parametro47 As New OleDbParameter("manzanaDestino", Me.manzanaDestino)
        Dim parametro48 As New OleDbParameter("origencoordx", Me.origenCoordX)
        Dim parametro49 As New OleDbParameter("origencoordy", Me.origenCoordY)
        Dim parametro50 As New OleDbParameter("destinocoordx", Me.destinoCoordX)
        Dim parametro51 As New OleDbParameter("destinocoordy", Me.destinoCoordY)

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
        objCommand.Parameters.Add(parametro30)
        objCommand.Parameters.Add(parametro31)
        objCommand.Parameters.Add(parametro32)
        objCommand.Parameters.Add(parametro33)
        objCommand.Parameters.Add(parametro34)
        objCommand.Parameters.Add(parametro35)
        objCommand.Parameters.Add(parametro36)
        objCommand.Parameters.Add(parametro37)
        objCommand.Parameters.Add(parametro38)
        objCommand.Parameters.Add(parametro39)
        objCommand.Parameters.Add(parametro40)
        objCommand.Parameters.Add(parametro41)
        objCommand.Parameters.Add(parametro42)
        objCommand.Parameters.Add(parametro43)
        objCommand.Parameters.Add(parametro44)
        objCommand.Parameters.Add(parametro45)
        objCommand.Parameters.Add(parametro46)
        objCommand.Parameters.Add(parametro47)
        objCommand.Parameters.Add(parametro48)
        objCommand.Parameters.Add(parametro49)
        objCommand.Parameters.Add(parametro50)
        objCommand.Parameters.Add(parametro51)

        Dim resultado As Integer = objCommand.ExecuteNonQuery()

        If resultado = 0 Then
            MessageBox.Show("No se pudo guardar la etapa " + etapa.ToString + " en la base de datos.", "Datos ok", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

    End Sub

End Class
