Imports System.Net
Imports System.IO
Imports System.Data
Imports System.ComponentModel
Imports EOD.datasetEOD
Imports EOD.datasetEODTableAdapters
Imports System.Deployment.Application
Imports System.Data.OleDb

Public Class RestaurarBase
    Dim rutaRespaldo As String = Directory.GetFiles("C:\backups data").OrderByDescending(Function(f) New FileInfo(f).LastWriteTime).First()
    Dim objConn As OleDbConnection
    Dim procedimiento As Integer
    Dim dataset As datasetEOD

    Dim WithEvents ADUpdateAsync As ApplicationDeployment

    Public Sub New()
        InitializeComponent()
        dataset = New datasetEOD
    End Sub

    Private Sub RestaurarBase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'conectar con base respaldada
            objConn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & rutaRespaldo)
            objConn.Open()

            If objConn.State = ConnectionState.Open Then
                barraProg.Properties.Maximum = 100
                bw.WorkerSupportsCancellation = True
                bw.WorkerReportsProgress = True
                bw.RunWorkerAsync()
            Else
                MessageBox.Show("No se pudo conectar con la base de respaldo", "Error en restauración de respaldo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub bw_DoWork(sender As Object, e As DoWorkEventArgs) Handles bw.DoWork

        '********************************

        'PASO 1 - VACIAR TABLAS

        '********************************

        procedimiento = 1
        bw.ReportProgress(1)
        'vaciar hogar
        dataset.Hogar.Clear()
        dataset.Persona.Clear()
        dataset.Vehiculo.Clear()
        dataset.Viaje.Clear()
        dataset.Etapa.Clear()
        dataset.Incidencia.Clear()

        'vaciar valida hogar
        dataset.ValidaHogar.Clear()
        dataset.ValidaPersona.Clear()
        dataset.ValidaViaje.Clear()
        dataset.ValidaEtapa.Clear()
        dataset.AcceptChanges()

        'vaciar tablas históricas
        dataset.Hogar_H.Clear()
        dataset.Persona_H.Clear()
        dataset.Vehiculo_H.Clear()
        dataset.Viaje_H.Clear()
        dataset.Etapa_H.Clear()

        '********************************

        'PASO 2 - RESTAURAR ENCUESTAS

        '********************************
        procedimiento = 2
        bw.ReportProgress(25)
        Try
            'tabla hogar
            Dim objCommandHogar As New OleDbCommand("select * from hogar", objConn)
            Dim hogares As OleDbDataReader = objCommandHogar.ExecuteReader()

            While hogares.Read()
                Dim nuevoHogar As HogarRow = dataset.Hogar.NewHogarRow

                nuevoHogar.Hogar = IIf(hogares.Item("Hogar") IsNot DBNull.Value, hogares.Item("Hogar"), Nothing)
                nuevoHogar.IDEncuestador = IIf(hogares.Item("IDEncuestador") IsNot DBNull.Value, hogares.Item("IDEncuestador"), Nothing)
                Try
                    nuevoHogar.GastoFamiliarTransporte = IIf(hogares.Item("GastoFamiliarTransporte") IsNot DBNull.Value, hogares.Item("GastoFamiliarTransporte"), Nothing)
                    nuevoHogar.IndicaGFT = IIf(hogares.Item("IndicaGFT") IsNot DBNull.Value, hogares.Item("IndicaGFT"), Nothing)
                Catch ex As Exception

                End Try

                nuevoHogar.Zona = IIf(hogares.Item("Zona") IsNot DBNull.Value, hogares.Item("Zona"), Nothing)
                nuevoHogar.Manzana = IIf(hogares.Item("Manzana") IsNot DBNull.Value, hogares.Item("Manzana"), Nothing)
                nuevoHogar.Comuna = IIf(hogares.Item("Comuna") IsNot DBNull.Value, hogares.Item("Comuna"), Nothing)
                nuevoHogar.NombreCalle = IIf(hogares.Item("NombreCalle") IsNot DBNull.Value, hogares.Item("NombreCalle"), Nothing)
                nuevoHogar.Numero = IIf(hogares.Item("Numero") IsNot DBNull.Value, hogares.Item("Numero"), Nothing)
                nuevoHogar.CasaDepto = IIf(hogares.Item("CasaDepto") IsNot DBNull.Value, hogares.Item("CasaDepto"), Nothing)
                nuevoHogar.TipoViviendaActual = IIf(hogares.Item("TipoViviendaActual") IsNot DBNull.Value, hogares.Item("TipoViviendaActual"), Nothing)
                nuevoHogar.Telefono = IIf(hogares.Item("Telefono") IsNot DBNull.Value, hogares.Item("Telefono"), Nothing)
                nuevoHogar.DirCoordX = IIf(hogares.Item("DirCoordX") IsNot DBNull.Value, hogares.Item("DirCoordX"), Nothing)
                nuevoHogar.DirCoordY = IIf(hogares.Item("DirCoordY") IsNot DBNull.Value, hogares.Item("DirCoordY"), Nothing)
                nuevoHogar.Waypoint = IIf(hogares.Item("Waypoint") IsNot DBNull.Value, hogares.Item("Waypoint"), Nothing)
                nuevoHogar.FechaVisita1 = IIf(hogares.Item("FechaVisita1") IsNot DBNull.Value, hogares.Item("FechaVisita1"), Nothing)
                Try
                    nuevoHogar.FechaViajesLab = IIf(hogares.Item("FechaViajesLab") IsNot DBNull.Value, hogares.Item("FechaViajesLab"), Nothing)
                    nuevoHogar.FechaViajesSab = IIf(hogares.Item("FechaViajesSab") IsNot DBNull.Value, hogares.Item("FechaViajesSab"), Nothing)
                    nuevoHogar.FechaViajesDom = IIf(hogares.Item("FechaViajesDom") IsNot DBNull.Value, hogares.Item("FechaViajesDom"), Nothing)
                Catch ex As Exception

                End Try
                nuevoHogar.DiaAsig = IIf(hogares.Item("DiaAsig") IsNot DBNull.Value, hogares.Item("DiaAsig"), Nothing)
                nuevoHogar.TipoDia = IIf(hogares.Item("TipoDia") IsNot DBNull.Value, hogares.Item("TipoDia"), Nothing)
                If nuevoHogar.TipoDia = 0 Then
                    nuevoHogar.TipoDia = Nothing
                End If
                nuevoHogar.NumPer = IIf(hogares.Item("NumPer") IsNot DBNull.Value, hogares.Item("NumPer"), Nothing)
                nuevoHogar.NumVeh = IIf(hogares.Item("NumVeh") IsNot DBNull.Value, hogares.Item("NumVeh"), Nothing)
                nuevoHogar.Propiedad = IIf(hogares.Item("Propiedad") IsNot DBNull.Value, hogares.Item("Propiedad"), Nothing)
                nuevoHogar.PropiedadOtra = IIf(hogares.Item("PropiedadOtra") IsNot DBNull.Value, hogares.Item("PropiedadOtra"), Nothing)
                nuevoHogar.MontoDiv = IIf(hogares.Item("MontoDiv") IsNot DBNull.Value, hogares.Item("MontoDiv"), Nothing)
                nuevoHogar.ImputadoDiv = IIf(hogares.Item("ImputadoDiv") IsNot DBNull.Value, hogares.Item("ImputadoDiv"), Nothing)
                nuevoHogar.MontoArr = IIf(hogares.Item("MontoArr") IsNot DBNull.Value, hogares.Item("MontoArr"), Nothing)
                nuevoHogar.ImputadoArr = IIf(hogares.Item("ImputadoArr") IsNot DBNull.Value, hogares.Item("ImputadoArr"), Nothing)
                nuevoHogar.MontoEst = IIf(hogares.Item("MontoEst") IsNot DBNull.Value, hogares.Item("MontoEst"), Nothing)
                nuevoHogar.ImputadoEst = IIf(hogares.Item("ImputadoEst") IsNot DBNull.Value, hogares.Item("ImputadoEst"), Nothing)
                nuevoHogar.NoSabeNoResponde = IIf(hogares.Item("NoSabeNoResponde") IsNot DBNull.Value, hogares.Item("NoSabeNoResponde"), Nothing)
                nuevoHogar.IngresoHogar = IIf(hogares.Item("IngresoHogar") IsNot DBNull.Value, hogares.Item("IngresoHogar"), Nothing)
                nuevoHogar.TipoIngreso = IIf(hogares.Item("TipoIngreso") IsNot DBNull.Value AndAlso hogares.Item("TipoIngreso").ToString <> "0", hogares.Item("TipoIngreso"), 3)
                nuevoHogar.Factor_Laboral = IIf(hogares.Item("Factor_Laboral") IsNot DBNull.Value, hogares.Item("Factor_Laboral"), Nothing)
                nuevoHogar.Factor_Sabado = IIf(hogares.Item("Factor_Sabado") IsNot DBNull.Value, hogares.Item("Factor_Sabado"), Nothing)
                nuevoHogar.Factor_Domingo = IIf(hogares.Item("Factor_Domingo") IsNot DBNull.Value, hogares.Item("Factor_Domingo"), Nothing)
                nuevoHogar.Factor = IIf(hogares.Item("Factor") IsNot DBNull.Value, hogares.Item("Factor"), Nothing)
                nuevoHogar.Observacion = IIf(hogares.Item("Observacion") IsNot DBNull.Value, hogares.Item("Observacion"), Nothing)
                nuevoHogar.EstadoEncuesta = IIf(hogares.Item("EstadoEncuesta") IsNot DBNull.Value, hogares.Item("EstadoEncuesta"), Nothing)

                dataset.Hogar.Rows.Add(nuevoHogar)
            End While

            hogares.Close()

            'tabla vehiculo
            Dim objCommandVehiculo As New OleDbCommand("select * from vehiculo", objConn)
            Dim vehiculos As OleDbDataReader = objCommandVehiculo.ExecuteReader()

            While vehiculos.Read()
                Dim nuevoVehiculo As VehiculoRow = dataset.Vehiculo.NewVehiculoRow

                nuevoVehiculo.Hogar = IIf(vehiculos.Item("Hogar") IsNot DBNull.Value, vehiculos.Item("Hogar"), Nothing)
                nuevoVehiculo.Vehículo = IIf(vehiculos.Item("Vehículo") IsNot DBNull.Value, vehiculos.Item("Vehículo"), Nothing)
                nuevoVehiculo.TipoVeh = IIf(vehiculos.Item("TipoVeh") IsNot DBNull.Value, vehiculos.Item("TipoVeh"), Nothing)
                nuevoVehiculo.Propiedad = IIf(vehiculos.Item("Propiedad") IsNot DBNull.Value, vehiculos.Item("Propiedad"), Nothing)
                nuevoVehiculo.PropiedadOtro = IIf(vehiculos.Item("PropiedadOtro") IsNot DBNull.Value, vehiculos.Item("PropiedadOtro"), Nothing)
                Try
                    nuevoVehiculo.TipoMotor = IIf(vehiculos.Item("TipoMotor") IsNot DBNull.Value, vehiculos.Item("TipoMotor"), Nothing)
                    nuevoVehiculo.AnioFabricacion = IIf(vehiculos.Item("AnioFabricacion") IsNot DBNull.Value, vehiculos.Item("AnioFabricacion"), Nothing)
                Catch ex As Exception

                End Try

                dataset.Vehiculo.Rows.Add(nuevoVehiculo)
            End While

            vehiculos.Close()

            'tabla persona
            Dim objCommandPersona As New OleDbCommand("select * from persona", objConn)
            Dim personas As OleDbDataReader = objCommandPersona.ExecuteReader()

            While personas.Read()
                Dim nuevaPersona As PersonaRow = dataset.Persona.NewPersonaRow

                nuevaPersona.Hogar = IIf(personas.Item("Hogar") IsNot DBNull.Value, personas.Item("Hogar"), Nothing)
                nuevaPersona.Persona = IIf(personas.Item("Persona") IsNot DBNull.Value, personas.Item("Persona"), Nothing)
                nuevaPersona.NombrePila = IIf(personas.Item("NombrePila") IsNot DBNull.Value, personas.Item("NombrePila"), Nothing)
                nuevaPersona.AnoNac = IIf(personas.Item("AnoNac") IsNot DBNull.Value, personas.Item("AnoNac"), Nothing)
                nuevaPersona.Sexo = IIf(personas.Item("Sexo") IsNot DBNull.Value, personas.Item("Sexo"), Nothing)
                nuevaPersona.Relacion = IIf(personas.Item("Relacion") IsNot DBNull.Value, personas.Item("Relacion"), Nothing)
                Try
                    nuevaPersona.ViajesLab = IIf(personas.Item("ViajesLab") IsNot DBNull.Value, personas.Item("ViajesLab"), Nothing)
                    nuevaPersona.ViajesSab = IIf(personas.Item("ViajesSab") IsNot DBNull.Value, personas.Item("ViajesSab"), Nothing)
                    nuevaPersona.ViajesDom = IIf(personas.Item("ViajesDom") IsNot DBNull.Value, personas.Item("ViajesDom"), Nothing)
                    nuevaPersona.Discapacitado = IIf(personas.Item("Discapacitado") IsNot DBNull.Value, personas.Item("Discapacitado"), Nothing)
                    nuevaPersona.TipoDiscapacidad = IIf(personas.Item("TipoDiscapacidad") IsNot DBNull.Value, personas.Item("TipoDiscapacidad"), Nothing)
                    nuevaPersona.DiscapacidadAutosuficiente = IIf(personas.Item("DiscapacidadAutosuficiente") IsNot DBNull.Value, personas.Item("DiscapacidadAutosuficiente"), Nothing)
                Catch ex As Exception

                End Try
                nuevaPersona.Estudios = IIf(personas.Item("Estudios") IsNot DBNull.Value, personas.Item("Estudios"), Nothing)
                nuevaPersona.EstudiosCompletos = IIf(personas.Item("EstudiosCompletos") IsNot DBNull.Value, personas.Item("EstudiosCompletos"), Nothing)
                nuevaPersona.Actividad = IIf(personas.Item("Actividad") IsNot DBNull.Value, personas.Item("Actividad"), Nothing)
                nuevaPersona.ActividadOtra = IIf(personas.Item("ActividadOtra") IsNot DBNull.Value, personas.Item("ActividadOtra"), Nothing)
                nuevaPersona.LicenciaConducir = IIf(personas.Item("LicenciaConducir") IsNot DBNull.Value, personas.Item("LicenciaConducir"), Nothing)
                If nuevaPersona.Actividad.Contains("1") Then
                    nuevaPersona.JornadaTrabajo = IIf(personas.Item("JornadaTrabajo") IsNot DBNull.Value, personas.Item("JornadaTrabajo"), Nothing)
                    nuevaPersona.ComunaTrabajo = IIf(personas.Item("ComunaTrabajo") IsNot DBNull.Value, personas.Item("ComunaTrabajo"), Nothing)
                    If nuevaPersona.ComunaTrabajo = 1 Then
                        nuevaPersona.ComunaTrabajoOtra = IIf(personas.Item("ComunaTrabajoOtra") IsNot DBNull.Value, personas.Item("ComunaTrabajoOtra"), Nothing)
                    ElseIf nuevaPersona.ComunaTrabajo = 2 OrElse nuevaPersona.ComunaTrabajo = 3 Then
                        nuevaPersona.NombreCalle1Trabajo = IIf(personas.Item("NombreCalle1Trabajo") IsNot DBNull.Value, personas.Item("NombreCalle1Trabajo"), Nothing)
                        nuevaPersona.NumeroOCalle2Trabajo = IIf(personas.Item("NumeroOCalle2Trabajo") IsNot DBNull.Value, personas.Item("NumeroOCalle2Trabajo"), Nothing)
                        nuevaPersona.HitoTrabajo = IIf(personas.Item("HitoTrabajo") IsNot DBNull.Value, personas.Item("HitoTrabajo"), Nothing)
                        nuevaPersona.ManzanaTrabajo = IIf(personas.Item("ManzanaTrabajo") IsNot DBNull.Value, personas.Item("ManzanaTrabajo"), Nothing)
                        nuevaPersona.DirActividadCoordX = IIf(personas.Item("DirActividadCoordX") IsNot DBNull.Value, personas.Item("DirActividadCoordX"), Nothing)
                        nuevaPersona.DirActividadCoordY = IIf(personas.Item("DirActividadCoordY") IsNot DBNull.Value, personas.Item("DirActividadCoordY"), Nothing)
                    End If
                End If

                If nuevaPersona.Actividad.Contains("2") Then
                    nuevaPersona.PaseEscolar = IIf(personas.Item("PaseEscolar") IsNot DBNull.Value, personas.Item("PaseEscolar"), Nothing)
                    nuevaPersona.DondeEstudia = IIf(personas.Item("DondeEstudia") IsNot DBNull.Value, personas.Item("DondeEstudia"), Nothing)
                    nuevaPersona.DondeEstudiaOtro = IIf(personas.Item("DondeEstudiaOtro") IsNot DBNull.Value, personas.Item("DondeEstudiaOtro"), Nothing)
                    nuevaPersona.ComunaEstudio = IIf(personas.Item("ComunaEstudio") IsNot DBNull.Value, personas.Item("ComunaEstudio"), Nothing)
                    If nuevaPersona.ComunaEstudio = 1 Then
                        nuevaPersona.ComunaEstudioOtra = IIf(personas.Item("ComunaEstudioOtra") IsNot DBNull.Value, personas.Item("ComunaEstudioOtra"), Nothing)
                    ElseIf nuevaPersona.ComunaEstudio = 2 OrElse nuevaPersona.ComunaEstudio = 3 Then
                        nuevaPersona.NombreCalle1Estudio = IIf(personas.Item("NombreCalle1Estudio") IsNot DBNull.Value, personas.Item("NombreCalle1Estudio"), Nothing)
                        nuevaPersona.NumeroOCalle2Estudio = IIf(personas.Item("NumeroOCalle2Estudio") IsNot DBNull.Value, personas.Item("NumeroOCalle2Estudio"), Nothing)
                        nuevaPersona.HitoEstudio = IIf(personas.Item("HitoEstudio") IsNot DBNull.Value, personas.Item("HitoEstudio"), Nothing)
                        nuevaPersona.ManzanaEstudio = IIf(personas.Item("ManzanaEstudio") IsNot DBNull.Value, personas.Item("ManzanaEstudio"), Nothing)
                        nuevaPersona.DirEstudiosCoordX = IIf(personas.Item("DirEstudiosCoordX") IsNot DBNull.Value, personas.Item("DirEstudiosCoordX"), Nothing)
                        nuevaPersona.DirEstudiosCoordY = IIf(personas.Item("DirEstudiosCoordY") IsNot DBNull.Value, personas.Item("DirEstudiosCoordY"), Nothing)
                    End If
                End If

                Try
                    nuevaPersona.NoViajaLab = CInt(IIf(personas.Item("NoViajaLab") IsNot DBNull.Value, personas.Item("NoViajaLab"), Nothing))
                    nuevaPersona.NoViajaSab = CInt(IIf(personas.Item("NoViajaSab") IsNot DBNull.Value, personas.Item("NoViajaSab"), Nothing))
                    nuevaPersona.NoViajaDom = CInt(IIf(personas.Item("NoViajaDom") IsNot DBNull.Value, personas.Item("NoViajaDom"), Nothing))
                    nuevaPersona.NoViajaLabOtroMotivo = IIf(personas.Item("NoViajaLabOtroMotivo") IsNot DBNull.Value, personas.Item("NoViajaLabOtroMotivo"), Nothing)
                    nuevaPersona.NoViajaSabOtroMotivo = IIf(personas.Item("NoViajaSabOtroMotivo") IsNot DBNull.Value, personas.Item("NoViajaSabOtroMotivo"), Nothing)
                    nuevaPersona.NoViajaDomOtroMotivo = IIf(personas.Item("NoViajaDomOtroMotivo") IsNot DBNull.Value, personas.Item("NoViajaDomOtroMotivo"), Nothing)
                Catch ex As Exception

                End Try

                nuevaPersona.TieneIngresos = IIf(personas.Item("TieneIngresos") IsNot DBNull.Value, personas.Item("TieneIngresos"), Nothing)
                If nuevaPersona.TieneIngresos = 1 Then
                    nuevaPersona.IngresoLiquido = IIf(personas.Item("IngresoLiquido") IsNot DBNull.Value, personas.Item("IngresoLiquido"), Nothing)
                    If nuevaPersona.IsIngresoLiquidoNull Then
                        nuevaPersona.TramoIngreso = IIf(personas.Item("TramoIngreso") IsNot DBNull.Value, personas.Item("TramoIngreso"), Nothing)
                    End If
                End If

                nuevaPersona.Factor_Laboral = IIf(personas.Item("Factor_Laboral") IsNot DBNull.Value, personas.Item("Factor_Laboral"), Nothing)
                nuevaPersona.Factor_Sabado = IIf(personas.Item("Factor_Sabado") IsNot DBNull.Value, personas.Item("Factor_Sabado"), Nothing)
                nuevaPersona.Factor_Domingo = IIf(personas.Item("Factor_Domingo") IsNot DBNull.Value, personas.Item("Factor_Domingo"), Nothing)
                nuevaPersona.Factor = IIf(personas.Item("Factor") IsNot DBNull.Value, personas.Item("Factor"), Nothing)
                Try
                    nuevaPersona.EncuestadoLab = IIf(personas.Item("EncuestadoLab") IsNot DBNull.Value, personas.Item("EncuestadoLab"), Nothing)
                    nuevaPersona.EncuestadoSab = IIf(personas.Item("EncuestadoSab") IsNot DBNull.Value, personas.Item("EncuestadoSab"), Nothing)
                    nuevaPersona.EncuestadoDom = IIf(personas.Item("EncuestadoDom") IsNot DBNull.Value, personas.Item("EncuestadoDom"), Nothing)

                Catch ex As Exception

                End Try
                nuevaPersona.Encuestado = IIf(personas.Item("Encuestado") IsNot DBNull.Value, personas.Item("Encuestado"), Nothing)

                dataset.Persona.Rows.Add(nuevaPersona)
            End While

            personas.Close()

            'tabla viaje
            Dim objCommandViaje As New OleDbCommand("select * from viaje", objConn)
            Dim viajes As OleDbDataReader = objCommandViaje.ExecuteReader()

            While viajes.Read()
                Dim nuevoViaje As ViajeRow = dataset.Viaje.NewViajeRow

                nuevoViaje.Hogar = IIf(viajes.Item("Hogar") IsNot DBNull.Value, viajes.Item("Hogar"), Nothing)
                nuevoViaje.Persona = IIf(viajes.Item("Persona") IsNot DBNull.Value, viajes.Item("Persona"), Nothing)
                nuevoViaje.Viaje = IIf(viajes.Item("Viaje") IsNot DBNull.Value, viajes.Item("Viaje"), Nothing)
                Try
                    nuevoViaje.DiaViaje = IIf(viajes.Item("DiaViaje") IsNot DBNull.Value, viajes.Item("DiaViaje"), Nothing)
                Catch ex As Exception

                End Try
                nuevoViaje.Etapas = IIf(viajes.Item("Etapas") IsNot DBNull.Value, viajes.Item("Etapas"), Nothing)
                nuevoViaje.ComunaOrigen = IIf(viajes.Item("ComunaOrigen") IsNot DBNull.Value, viajes.Item("ComunaOrigen"), Nothing)
                nuevoViaje.ComunaDestino = IIf(viajes.Item("ComunaDestino") IsNot DBNull.Value, viajes.Item("ComunaDestino"), Nothing)
                If nuevoViaje.ComunaOrigen = 1 Then
                    nuevoViaje.ComunaOtraOrigen = IIf(viajes.Item("ComunaOtraOrigen") IsNot DBNull.Value, viajes.Item("ComunaOtraOrigen"), Nothing)
                ElseIf nuevoViaje.ComunaOrigen = 2 OrElse nuevoviaje.ComunaOrigen = 3 Then
                    nuevoViaje.ZonaOrigen = IIf(viajes.Item("ZonaOrigen") IsNot DBNull.Value, viajes.Item("ZonaOrigen"), Nothing)
                    nuevoViaje.ManzanaOrigen = IIf(viajes.Item("ManzanaOrigen") IsNot DBNull.Value, viajes.Item("ManzanaOrigen"), Nothing)
                    nuevoViaje.NombreCalle1Origen = IIf(viajes.Item("NombreCalle1Origen") IsNot DBNull.Value, viajes.Item("NombreCalle1Origen"), Nothing)
                    nuevoViaje.NumeroOCalle2Origen = IIf(viajes.Item("NumeroOCalle2Origen") IsNot DBNull.Value, viajes.Item("NumeroOCalle2Origen"), Nothing)
                    nuevoViaje.HitoOrigen = IIf(viajes.Item("HitoOrigen") IsNot DBNull.Value, viajes.Item("HitoOrigen"), Nothing)
                    nuevoViaje.OrigenCoordX = IIf(viajes.Item("OrigenCoordX") IsNot DBNull.Value, viajes.Item("OrigenCoordX"), Nothing)
                    nuevoViaje.OrigenCoordY = IIf(viajes.Item("OrigenCoordY") IsNot DBNull.Value, viajes.Item("OrigenCoordY"), Nothing)
                End If

                If nuevoViaje.ComunaDestino = 1 Then
                    nuevoViaje.ComunaOtraDestino = IIf(viajes.Item("ComunaOtraDestino") IsNot DBNull.Value, viajes.Item("ComunaOtraDestino"), Nothing)
                ElseIf nuevoViaje.ComunaDestino = 2 OrElse nuevoViaje.ComunaDestino = 3 Then
                    nuevoViaje.ZonaDestino = IIf(viajes.Item("ZonaDestino") IsNot DBNull.Value, viajes.Item("ZonaDestino"), Nothing)
                    nuevoViaje.ManzanaDestino = IIf(viajes.Item("ManzanaDestino") IsNot DBNull.Value, viajes.Item("ManzanaDestino"), Nothing)
                    nuevoViaje.NombreCalle1Destino = IIf(viajes.Item("NombreCalle1Destino") IsNot DBNull.Value, viajes.Item("NombreCalle1Destino"), Nothing)
                    nuevoViaje.NumeroOCalle2Destino = IIf(viajes.Item("NumeroOCalle2Destino") IsNot DBNull.Value, viajes.Item("NumeroOCalle2Destino"), Nothing)
                    nuevoViaje.HitoDestino = IIf(viajes.Item("HitoDestino") IsNot DBNull.Value, viajes.Item("HitoDestino"), Nothing)
                    nuevoViaje.DestinoCoordX = IIf(viajes.Item("DestinoCoordX") IsNot DBNull.Value, viajes.Item("DestinoCoordX"), Nothing)
                    nuevoViaje.DestinoCoordY = IIf(viajes.Item("DestinoCoordY") IsNot DBNull.Value, viajes.Item("DestinoCoordY"), Nothing)
                End If

                nuevoViaje.TrabajoDeclarado = IIf(viajes.Item("TrabajoDeclarado") IsNot DBNull.Value, viajes.Item("TrabajoDeclarado"), Nothing)
                nuevoViaje.EstudioDeclarado = IIf(viajes.Item("EstudioDeclarado") IsNot DBNull.Value, viajes.Item("EstudioDeclarado"), Nothing)
                nuevoViaje.Proposito = IIf(viajes.Item("Proposito") IsNot DBNull.Value, viajes.Item("Proposito"), Nothing)
                nuevoViaje.PropositoOtro = IIf(viajes.Item("PropositoOtro") IsNot DBNull.Value, viajes.Item("PropositoOtro"), Nothing)
                nuevoViaje.HoraIni = IIf(viajes.Item("HoraIni") IsNot DBNull.Value, viajes.Item("HoraIni"), Nothing)
                nuevoViaje.Horafin = IIf(viajes.Item("Horafin") IsNot DBNull.Value, viajes.Item("Horafin"), Nothing)
                nuevoViaje.HoraMedia = IIf(viajes.Item("HoraMedia") IsNot DBNull.Value, viajes.Item("HoraMedia"), Nothing)
                nuevoViaje.Trasnoche = IIf(viajes.Item("Trasnoche") IsNot DBNull.Value, viajes.Item("Trasnoche"), Nothing)
                nuevoViaje.TiempoViaje = IIf(viajes.Item("TiempoViaje") IsNot DBNull.Value, viajes.Item("TiempoViaje"), Nothing)
                nuevoViaje.MinutosDespues = IIf(viajes.Item("MinutosDespues") IsNot DBNull.Value, viajes.Item("MinutosDespues"), Nothing)
                nuevoViaje.CuadrasDespues = IIf(viajes.Item("CuadrasDespues") IsNot DBNull.Value, viajes.Item("CuadrasDespues"), Nothing)
                nuevoViaje.FactorLaboral = IIf(viajes.Item("FactorLaboral") IsNot DBNull.Value, viajes.Item("FactorLaboral"), Nothing)
                nuevoViaje.FactorSabado = IIf(viajes.Item("FactorSabado") IsNot DBNull.Value, viajes.Item("FactorSabado"), Nothing)
                nuevoViaje.FactorDomingo = IIf(viajes.Item("FactorDomingo") IsNot DBNull.Value, viajes.Item("FactorDomingo"), Nothing)
                nuevoViaje.CodigoTiempo = IIf(viajes.Item("CodigoTiempo") IsNot DBNull.Value, viajes.Item("CodigoTiempo"), Nothing)

                dataset.Viaje.Rows.Add(nuevoViaje)
            End While

            viajes.Close()

            'tabla etapa
            Dim objCommandEtapa As New OleDbCommand("select * from etapa", objConn)
            Dim etapas As OleDbDataReader = objCommandEtapa.ExecuteReader()

            While etapas.Read()
                Dim nuevaEtapa As EtapaRow = dataset.Etapa.NewEtapaRow

                nuevaEtapa.Hogar = IIf(etapas.Item("Hogar") IsNot DBNull.Value, etapas.Item("Hogar"), Nothing)
                nuevaEtapa.Persona = IIf(etapas.Item("Persona") IsNot DBNull.Value, etapas.Item("Persona"), Nothing)
                nuevaEtapa.Viaje = IIf(etapas.Item("Viaje") IsNot DBNull.Value, etapas.Item("Viaje"), Nothing)
                nuevaEtapa.Etapa = IIf(etapas.Item("Etapa") IsNot DBNull.Value, etapas.Item("Etapa"), Nothing)
                Try
                    nuevaEtapa.DiaViaje = IIf(etapas.Item("DiaViaje") IsNot DBNull.Value, etapas.Item("DiaViaje"), Nothing)
                Catch ex As Exception

                End Try
                nuevaEtapa.ComunaOrigen = IIf(etapas.Item("ComunaOrigen") IsNot DBNull.Value, etapas.Item("ComunaOrigen"), Nothing)
                nuevaEtapa.ComunaDestino = IIf(etapas.Item("ComunaDestino") IsNot DBNull.Value, etapas.Item("ComunaDestino"), Nothing)
                If nuevaEtapa.ComunaOrigen = 1 Then
                    nuevaEtapa.ComunaOtraOrigen = IIf(etapas.Item("ComunaOtraOrigen") IsNot DBNull.Value, etapas.Item("ComunaOtraOrigen"), Nothing)
                ElseIf nuevaEtapa.ComunaOrigen = 2 OrElse nuevaEtapa.ComunaOrigen = 3 Then
                    nuevaEtapa.ZonaOrigen = IIf(etapas.Item("ZonaOrigen") IsNot DBNull.Value, etapas.Item("ZonaOrigen"), Nothing)
                    nuevaEtapa.ManzanaOrigen = IIf(etapas.Item("ManzanaOrigen") IsNot DBNull.Value, etapas.Item("ManzanaOrigen"), Nothing)
                    nuevaEtapa.NombreCalle1Origen = IIf(etapas.Item("NombreCalle1Origen") IsNot DBNull.Value, etapas.Item("NombreCalle1Origen"), Nothing)
                    nuevaEtapa.NumeroOCalle2Origen = IIf(etapas.Item("NumeroOCalle2Origen") IsNot DBNull.Value, etapas.Item("NumeroOCalle2Origen"), Nothing)
                    nuevaEtapa.HitoOrigen = IIf(etapas.Item("HitoOrigen") IsNot DBNull.Value, etapas.Item("HitoOrigen"), Nothing)
                    nuevaEtapa.OrigenCoordX = IIf(etapas.Item("OrigenCoordX") IsNot DBNull.Value, etapas.Item("OrigenCoordX"), Nothing)
                    nuevaEtapa.OrigenCoordY = IIf(etapas.Item("OrigenCoordY") IsNot DBNull.Value, etapas.Item("OrigenCoordY"), Nothing)
                End If

                If nuevaEtapa.ComunaDestino = 1 Then
                    nuevaEtapa.ComunaOtraDestino = IIf(etapas.Item("ComunaOtraDestino") IsNot DBNull.Value, etapas.Item("ComunaOtraDestino"), Nothing)
                ElseIf nuevaEtapa.ComunaDestino = 2 OrElse nuevaEtapa.Comunadestino = 3 Then
                    nuevaEtapa.ZonaDestino = IIf(etapas.Item("ZonaDestino") IsNot DBNull.Value, etapas.Item("ZonaDestino"), Nothing)
                    nuevaEtapa.ManzanaDestino = IIf(etapas.Item("ManzanaDestino") IsNot DBNull.Value, etapas.Item("ManzanaDestino"), Nothing)
                    nuevaEtapa.NombreCalle1Destino = IIf(etapas.Item("NombreCalle1Destino") IsNot DBNull.Value, etapas.Item("NombreCalle1Destino"), Nothing)
                    nuevaEtapa.NumeroOCalle2Destino = IIf(etapas.Item("NumeroOCalle2Destino") IsNot DBNull.Value, etapas.Item("NumeroOCalle2Destino"), Nothing)
                    nuevaEtapa.HitoDestino = IIf(etapas.Item("HitoDestino") IsNot DBNull.Value, etapas.Item("HitoDestino"), Nothing)
                    nuevaEtapa.DestinoCoordX = IIf(etapas.Item("DestinoCoordX") IsNot DBNull.Value, etapas.Item("DestinoCoordX"), Nothing)
                    nuevaEtapa.DestinoCoordY = IIf(etapas.Item("DestinoCoordY") IsNot DBNull.Value, etapas.Item("DestinoCoordY"), Nothing)
                End If

                nuevaEtapa.Modo = IIf(etapas.Item("Modo") IsNot DBNull.Value, etapas.Item("Modo"), Nothing)
                nuevaEtapa.CuadrasAntes = IIf(etapas.Item("CuadrasAntes") IsNot DBNull.Value, etapas.Item("CuadrasAntes"), Nothing)
                nuevaEtapa.MinutosAntes = IIf(etapas.Item("MinutosAntes") IsNot DBNull.Value, etapas.Item("MinutosAntes"), Nothing)

                Select Case nuevaEtapa.Modo
                    Case 1, 5, 9
                        nuevaEtapa.ViajaComo = IIf(etapas.Item("ViajaComo") IsNot DBNull.Value, etapas.Item("ViajaComo"), Nothing)
                        nuevaEtapa.QueVehiculo = IIf(etapas.Item("QueVehiculo") IsNot DBNull.Value, etapas.Item("QueVehiculo"), Nothing)
                        nuevaEtapa.LugarBajadaAuto = IIf(etapas.Item("LugarBajadaAuto") IsNot DBNull.Value, etapas.Item("LugarBajadaAuto"), Nothing)
                        If nuevaEtapa.ViajaComo = 1 Then
                            nuevaEtapa.DondeEstaciona = IIf(etapas.Item("DondeEstaciona") IsNot DBNull.Value, etapas.Item("DondeEstaciona"), Nothing)
                            nuevaEtapa.CostoNSNR = IIf(etapas.Item("CostoNSNR") IsNot DBNull.Value, etapas.Item("CostoNSNR"), Nothing)
                            If Not nuevaEtapa.CostoNSNR Then
                                nuevaEtapa.CostoEstacionamiento = IIf(etapas.Item("CostoEstacionamiento") IsNot DBNull.Value, etapas.Item("CostoEstacionamiento"), Nothing)
                            End If
                            nuevaEtapa.FormaPago = IIf(etapas.Item("FormaPago") IsNot DBNull.Value, etapas.Item("FormaPago"), Nothing)

                        End If
                        If nuevaEtapa.QueVehiculo = 1 Then
                            nuevaEtapa.IdVehiculoHogar = IIf(etapas.Item("IdVehiculoHogar") IsNot DBNull.Value, etapas.Item("IdVehiculoHogar"), Nothing)
                        End If
                    Case 2, 10, 11, 12
                        nuevaEtapa.TiempoEsperaBus = IIf(etapas.Item("TiempoEsperaBus") IsNot DBNull.Value, etapas.Item("TiempoEsperaBus"), Nothing)
                        nuevaEtapa.TipoTarifaBus = IIf(etapas.Item("TipoTarifaBus") IsNot DBNull.Value, etapas.Item("TipoTarifaBus"), Nothing)
                        If nuevaEtapa.TipoTarifaBus > 0 AndAlso nuevaEtapa.TipoTarifaBus < 4 Then
                            nuevaEtapa.TarifaBus = IIf(etapas.Item("TarifaBus") IsNot DBNull.Value, etapas.Item("TarifaBus"), Nothing)
                        End If
                        nuevaEtapa.LugarBajadaBus = IIf(etapas.Item("LugarBajadaBus") IsNot DBNull.Value, etapas.Item("LugarBajadaBus"), Nothing)
                    Case 3, 4
                        nuevaEtapa.TiempoEsperaTxc = IIf(etapas.Item("TiempoEsperaTxc") IsNot DBNull.Value, etapas.Item("TiempoEsperaTxc"), Nothing)
                        nuevaEtapa.TarifaTxc = IIf(etapas.Item("TarifaTxc") IsNot DBNull.Value, etapas.Item("TarifaTxc"), Nothing)
                        nuevaEtapa.LugarBajadaTxc = IIf(etapas.Item("LugarBajadaTxc") IsNot DBNull.Value, etapas.Item("LugarBajadaTxc"), Nothing)
                    Case 6
                        nuevaEtapa.TiempoEsperaTaxi = IIf(etapas.Item("TiempoEsperaTaxi") IsNot DBNull.Value, etapas.Item("TiempoEsperaTaxi"), Nothing)
                        nuevaEtapa.TarifaTaxi = IIf(etapas.Item("TarifaTaxi") IsNot DBNull.Value, etapas.Item("TarifaTaxi"), Nothing)
                        nuevaEtapa.LugarBajadaTaxi = IIf(etapas.Item("LugarBajadaTaxi") IsNot DBNull.Value, etapas.Item("LugarBajadaTaxi"), Nothing)
                    Case 8
                        nuevaEtapa.PropiedadBicicleta = IIf(etapas.Item("PropiedadBicicleta") IsNot DBNull.Value, etapas.Item("PropiedadBicicleta"), Nothing)
                        If nuevaEtapa.PropiedadBicicleta = 2 Then
                            nuevaEtapa.PropiedadBicicletaOtro = IIf(etapas.Item("PropiedadBicicletaOtro") IsNot DBNull.Value, etapas.Item("PropiedadBicicletaOtro"), Nothing)
                        End If
                        nuevaEtapa.LugarBajadaBicicleta = IIf(etapas.Item("LugarBajadaBicicleta") IsNot DBNull.Value, etapas.Item("LugarBajadaBicicleta"), Nothing)
                        nuevaEtapa.UsaCiclovia = IIf(etapas.Item("UsaCiclovia") IsNot DBNull.Value, etapas.Item("UsaCiclovia"), Nothing)
                        nuevaEtapa.EstacionamientoBicicleta = IIf(etapas.Item("EstacionamientoBicicleta") IsNot DBNull.Value, etapas.Item("EstacionamientoBicicleta"), Nothing)
                        nuevaEtapa.MotivoNoUsa = IIf(etapas.Item("MotivoNoUsa") IsNot DBNull.Value, etapas.Item("MotivoNoUsa"), Nothing)

                End Select

                dataset.Etapa.Rows.Add(nuevaEtapa)
            End While


            'tabla incidencias

            Try

                Dim objCommandIncidencias As New OleDbCommand("select * from incidencia", objConn)
                Dim incidencias As OleDbDataReader = objCommandEtapa.ExecuteReader()

                While incidencias.Read()
                    Dim nuevaIncidencia As IncidenciaRow = dataset.Incidencia.NewIncidenciaRow

                    nuevaIncidencia.Hogar = IIf(incidencias.Item("Hogar") IsNot DBNull.Value, incidencias.Item("Hogar"), Nothing)
                    nuevaIncidencia.Persona = IIf(incidencias.Item("Persona") IsNot DBNull.Value, incidencias.Item("Persona"), Nothing)
                    nuevaIncidencia.Viaje = IIf(incidencias.Item("Viaje") IsNot DBNull.Value, incidencias.Item("Viaje"), Nothing)
                    nuevaIncidencia.DiaViaje = IIf(incidencias.Item("DiaViaje") IsNot DBNull.Value, incidencias.Item("DiaViaje"), Nothing)
                    nuevaIncidencia.IDTipoIncidencia = IIf(incidencias.Item("IDTipoIncidencia") IsNot DBNull.Value, incidencias.Item("IDTipoIncidencia"), Nothing)
                    nuevaIncidencia.Descripcion = IIf(incidencias.Item("Descripcion") IsNot DBNull.Value, incidencias.Item("Descripcion"), Nothing)
                    nuevaIncidencia.FechaReporte = IIf(incidencias.Item("FechaReporte") IsNot DBNull.Value, incidencias.Item("FechaReporte"), Nothing)
                    nuevaIncidencia.Solucionado = IIf(incidencias.Item("Solucionado") IsNot DBNull.Value, incidencias.Item("Solucionado"), Nothing)


                    dataset.Incidencia.Rows.Add(nuevaIncidencia)
                End While
            Catch ex As Exception

            End Try

            etapas.Close()
        Catch ex As Exception
            dataset.RejectChanges()
            MessageBox.Show("No se pudo restaurar las tablas de encuestas. Error: " & ex.Message & ControlChars.Lf & ControlChars.Lf & "Pila de ejecución: " & ControlChars.Lf & ControlChars.Lf & ex.StackTrace, "Error en restauración de base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        Finally
            'actualizar tableadapters
            Dim adapterHogar As HogarTableAdapter = New HogarTableAdapter
            Dim adapterPersona As PersonaTableAdapter = New PersonaTableAdapter
            Dim adapterVehiculoT As VehiculoTableAdapter = New VehiculoTableAdapter
            Dim adapterViaje As ViajeTableAdapter = New ViajeTableAdapter
            Dim adapterEtapa As EtapaTableAdapter = New EtapaTableAdapter

            adapterHogar.Update(dataset.Hogar)
            adapterPersona.Update(dataset.Persona)
            adapterVehiculoT.Update(dataset.Vehiculo)
            adapterViaje.Update(dataset.Viaje)
            adapterEtapa.Update(dataset.Etapa)

            dataset.AcceptChanges()
        End Try





        '********************************

        'PASO 3 - RESTAURAR VALIDACIONES

        '********************************
        procedimiento = 3
        bw.ReportProgress(50)
        Try
            'tabla validahogar
            Dim objCommandValHogar As New OleDbCommand("select * from validahogar", objConn)
            Dim validaHogares As OleDbDataReader = objCommandValHogar.ExecuteReader()

            While validaHogares.Read()
                Dim nuevoValida As ValidaHogarRow = dataset.ValidaHogar.NewValidaHogarRow

                nuevoValida.Hogar = IIf(validaHogares.Item("Hogar") IsNot DBNull.Value, validaHogares.Item("Hogar"), Nothing)
                nuevoValida.Val10 = IIf(validaHogares.Item("Val10") IsNot DBNull.Value, validaHogares.Item("Val10"), Nothing)
                nuevoValida.Val10Resp = IIf(validaHogares.Item("Val10Resp") IsNot DBNull.Value, validaHogares.Item("Val10Resp"), Nothing)
                nuevoValida.Val10Obs = IIf(validaHogares.Item("Val10Obs") IsNot DBNull.Value, validaHogares.Item("Val10Obs"), Nothing)
                nuevoValida.Val11 = IIf(validaHogares.Item("Val11") IsNot DBNull.Value, validaHogares.Item("Val11"), Nothing)
                nuevoValida.Val11Resp = IIf(validaHogares.Item("Val11Resp") IsNot DBNull.Value, validaHogares.Item("Val11Resp"), Nothing)
                nuevoValida.Val11Obs = IIf(validaHogares.Item("Val11Obs") IsNot DBNull.Value, validaHogares.Item("Val11Obs"), Nothing)
                nuevoValida.Val12 = IIf(validaHogares.Item("Val12") IsNot DBNull.Value, validaHogares.Item("Val12"), Nothing)
                nuevoValida.Val12Resp = IIf(validaHogares.Item("Val12Resp") IsNot DBNull.Value, validaHogares.Item("Val12Resp"), Nothing)
                nuevoValida.Val12Obs = IIf(validaHogares.Item("Val12Obs") IsNot DBNull.Value, validaHogares.Item("Val12Obs"), Nothing)
                nuevoValida.Val13 = IIf(validaHogares.Item("Val13") IsNot DBNull.Value, validaHogares.Item("Val13"), Nothing)
                nuevoValida.Val13Resp = IIf(validaHogares.Item("Val13Resp") IsNot DBNull.Value, validaHogares.Item("Val13Resp"), Nothing)
                nuevoValida.Val13Obs = IIf(validaHogares.Item("Val13Obs") IsNot DBNull.Value, validaHogares.Item("Val13Obs"), Nothing)
                nuevoValida.Val15 = IIf(validaHogares.Item("Val15") IsNot DBNull.Value, validaHogares.Item("Val15"), Nothing)
                nuevoValida.Val15Resp = IIf(validaHogares.Item("Val15Resp") IsNot DBNull.Value, validaHogares.Item("Val15Resp"), Nothing)
                nuevoValida.Val15Obs = IIf(validaHogares.Item("Val15Obs") IsNot DBNull.Value, validaHogares.Item("Val15Obs"), Nothing)

                dataset.ValidaHogar.Rows.Add(nuevoValida)
            End While

            validaHogares.Close()

            'tabla validapersona
            Dim objCommandValPersona As New OleDbCommand("select * from validapersona", objConn)
            Dim validaPersonas As OleDbDataReader = objCommandValPersona.ExecuteReader()

            While validaPersonas.Read()
                Dim nuevoValida As ValidaPersonaRow = dataset.ValidaPersona.NewValidaPersonaRow

                nuevoValida.Hogar = IIf(validaPersonas.Item("Hogar") IsNot DBNull.Value, validaPersonas.Item("Hogar"), Nothing)
                nuevoValida.Persona = IIf(validaPersonas.Item("Persona") IsNot DBNull.Value, validaPersonas.Item("Persona"), Nothing)
                nuevoValida.Val2 = IIf(validaPersonas.Item("Val2") IsNot DBNull.Value, validaPersonas.Item("Val2"), Nothing)
                nuevoValida.Val2Resp = IIf(validaPersonas.Item("Val2Resp") IsNot DBNull.Value, validaPersonas.Item("Val2Resp"), Nothing)
                nuevoValida.Val2Obs = IIf(validaPersonas.Item("Val2Obs") IsNot DBNull.Value, validaPersonas.Item("Val2Obs"), Nothing)
                nuevoValida.Val4 = IIf(validaPersonas.Item("Val4") IsNot DBNull.Value, validaPersonas.Item("Val4"), Nothing)
                nuevoValida.Val4Resp = IIf(validaPersonas.Item("Val4Resp") IsNot DBNull.Value, validaPersonas.Item("Val4Resp"), Nothing)
                nuevoValida.Val4Obs = IIf(validaPersonas.Item("Val4Obs") IsNot DBNull.Value, validaPersonas.Item("Val4Obs"), Nothing)
                nuevoValida.Val6 = IIf(validaPersonas.Item("Val6") IsNot DBNull.Value, validaPersonas.Item("Val6"), Nothing)
                nuevoValida.Val6Resp = IIf(validaPersonas.Item("Val6Resp") IsNot DBNull.Value, validaPersonas.Item("Val6Resp"), Nothing)
                nuevoValida.Val6Obs = IIf(validaPersonas.Item("Val6Obs") IsNot DBNull.Value, validaPersonas.Item("Val6Obs"), Nothing)
                nuevoValida.Val10 = IIf(validaPersonas.Item("Val10") IsNot DBNull.Value, validaPersonas.Item("Val10"), Nothing)
                nuevoValida.Val10Resp = IIf(validaPersonas.Item("Val10Resp") IsNot DBNull.Value, validaPersonas.Item("Val10Resp"), Nothing)
                nuevoValida.Val10Obs = IIf(validaPersonas.Item("Val10Obs") IsNot DBNull.Value, validaPersonas.Item("Val10Obs"), Nothing)
                nuevoValida.Val11 = IIf(validaPersonas.Item("Val11") IsNot DBNull.Value, validaPersonas.Item("Val11"), Nothing)
                nuevoValida.Val11Resp = IIf(validaPersonas.Item("Val11Resp") IsNot DBNull.Value, validaPersonas.Item("Val11Resp"), Nothing)
                nuevoValida.Val11Obs = IIf(validaPersonas.Item("Val11Obs") IsNot DBNull.Value, validaPersonas.Item("Val11Obs"), Nothing)
                nuevoValida.Val16 = IIf(validaPersonas.Item("Val16") IsNot DBNull.Value, validaPersonas.Item("Val16"), Nothing)
                nuevoValida.Val16Resp = IIf(validaPersonas.Item("Val16Resp") IsNot DBNull.Value, validaPersonas.Item("Val16Resp"), Nothing)
                nuevoValida.Val16Obs = IIf(validaPersonas.Item("Val16Obs") IsNot DBNull.Value, validaPersonas.Item("Val16Obs"), Nothing)
                nuevoValida.Val17 = IIf(validaPersonas.Item("Val17") IsNot DBNull.Value, validaPersonas.Item("Val17"), Nothing)
                nuevoValida.Val17Resp = IIf(validaPersonas.Item("Val17Resp") IsNot DBNull.Value, validaPersonas.Item("Val17Resp"), Nothing)
                nuevoValida.Val17Obs = IIf(validaPersonas.Item("Val17Obs") IsNot DBNull.Value, validaPersonas.Item("Val17Obs"), Nothing)
                nuevoValida.Val18 = IIf(validaPersonas.Item("Val18") IsNot DBNull.Value, validaPersonas.Item("Val18"), Nothing)
                nuevoValida.Val18Resp = IIf(validaPersonas.Item("Val18Resp") IsNot DBNull.Value, validaPersonas.Item("Val18Resp"), Nothing)
                nuevoValida.Val18Obs = IIf(validaPersonas.Item("Val18Obs") IsNot DBNull.Value, validaPersonas.Item("Val18Obs"), Nothing)
                nuevoValida.Val19 = IIf(validaPersonas.Item("Val19") IsNot DBNull.Value, validaPersonas.Item("Val19"), Nothing)
                nuevoValida.Val19Resp = IIf(validaPersonas.Item("Val19Resp") IsNot DBNull.Value, validaPersonas.Item("Val19Resp"), Nothing)
                nuevoValida.Val19Obs = IIf(validaPersonas.Item("Val19Obs") IsNot DBNull.Value, validaPersonas.Item("Val19Obs"), Nothing)
                nuevoValida.Val20 = IIf(validaPersonas.Item("Val20") IsNot DBNull.Value, validaPersonas.Item("Val20"), Nothing)
                nuevoValida.Val20Resp = IIf(validaPersonas.Item("Val20Resp") IsNot DBNull.Value, validaPersonas.Item("Val20Resp"), Nothing)
                nuevoValida.Val20Obs = IIf(validaPersonas.Item("Val20Obs") IsNot DBNull.Value, validaPersonas.Item("Val20Obs"), Nothing)
                nuevoValida.Val23 = IIf(validaPersonas.Item("Val23") IsNot DBNull.Value, validaPersonas.Item("Val23"), Nothing)
                nuevoValida.Val23Resp = IIf(validaPersonas.Item("Val23Resp") IsNot DBNull.Value, validaPersonas.Item("Val23Resp"), Nothing)
                nuevoValida.Val23Obs = IIf(validaPersonas.Item("Val23Obs") IsNot DBNull.Value, validaPersonas.Item("Val23Obs"), Nothing)
                nuevoValida.Val24 = IIf(validaPersonas.Item("Val24") IsNot DBNull.Value, validaPersonas.Item("Val24"), Nothing)
                nuevoValida.Val24Resp = IIf(validaPersonas.Item("Val24Resp") IsNot DBNull.Value, validaPersonas.Item("Val24Resp"), Nothing)
                nuevoValida.Val24Obs = IIf(validaPersonas.Item("Val24Obs") IsNot DBNull.Value, validaPersonas.Item("Val24Obs"), Nothing)
                nuevoValida.Val25 = IIf(validaPersonas.Item("Val25") IsNot DBNull.Value, validaPersonas.Item("Val25"), Nothing)
                nuevoValida.Val25Resp = IIf(validaPersonas.Item("Val25Resp") IsNot DBNull.Value, validaPersonas.Item("Val25Resp"), Nothing)
                nuevoValida.Val25Obs = IIf(validaPersonas.Item("Val25Obs") IsNot DBNull.Value, validaPersonas.Item("Val25Obs"), Nothing)

                dataset.ValidaPersona.Rows.Add(nuevoValida)
            End While

            validaPersonas.Close()

            'tabla validaviaje
            Dim objCommandValViaje As New OleDbCommand("select * from validaviaje", objConn)
            Dim validaViajes As OleDbDataReader = objCommandValViaje.ExecuteReader()

            While validaViajes.Read()
                Dim nuevoValida As ValidaViajeRow = dataset.ValidaViaje.NewValidaViajeRow

                nuevoValida.Hogar = IIf(validaViajes.Item("Hogar") IsNot DBNull.Value, validaViajes.Item("Hogar"), Nothing)
                nuevoValida.Persona = IIf(validaViajes.Item("Persona") IsNot DBNull.Value, validaViajes.Item("Persona"), Nothing)
                nuevoValida.Viaje = IIf(validaViajes.Item("Viaje") IsNot DBNull.Value, validaViajes.Item("Viaje"), Nothing)
                nuevoValida.DiaViaje = IIf(validaViajes.Item("DiaViaje") IsNot DBNull.Value, validaViajes.Item("DiaViaje"), Nothing)
                nuevoValida.Val3 = IIf(validaViajes.Item("Val3") IsNot DBNull.Value, validaViajes.Item("Val3"), Nothing)
                nuevoValida.Val3Resp = IIf(validaViajes.Item("Val3Resp") IsNot DBNull.Value, validaViajes.Item("Val3Resp"), Nothing)
                nuevoValida.Val3Obs = IIf(validaViajes.Item("Val3Obs") IsNot DBNull.Value, validaViajes.Item("Val3Obs"), Nothing)
                nuevoValida.Val6 = IIf(validaViajes.Item("Val6") IsNot DBNull.Value, validaViajes.Item("Val6"), Nothing)
                nuevoValida.Val6Resp = IIf(validaViajes.Item("Val6Resp") IsNot DBNull.Value, validaViajes.Item("Val6Resp"), Nothing)
                nuevoValida.Val6Obs = IIf(validaViajes.Item("Val6Obs") IsNot DBNull.Value, validaViajes.Item("Val6Obs"), Nothing)
                nuevoValida.Val7 = IIf(validaViajes.Item("Val7") IsNot DBNull.Value, validaViajes.Item("Val7"), Nothing)
                nuevoValida.Val7Resp = IIf(validaViajes.Item("Val7Resp") IsNot DBNull.Value, validaViajes.Item("Val7Resp"), Nothing)
                nuevoValida.Val7Obs = IIf(validaViajes.Item("Val7Obs") IsNot DBNull.Value, validaViajes.Item("Val7Obs"), Nothing)
                nuevoValida.Val9 = IIf(validaViajes.Item("Val9") IsNot DBNull.Value, validaViajes.Item("Val9"), Nothing)
                nuevoValida.Val9Resp = IIf(validaViajes.Item("Val9Resp") IsNot DBNull.Value, validaViajes.Item("Val9Resp"), Nothing)
                nuevoValida.Val9Obs = IIf(validaViajes.Item("Val9Obs") IsNot DBNull.Value, validaViajes.Item("Val9Obs"), Nothing)
                nuevoValida.Val15 = IIf(validaViajes.Item("Val15") IsNot DBNull.Value, validaViajes.Item("Val15"), Nothing)
                nuevoValida.Val15Resp = IIf(validaViajes.Item("Val15Resp") IsNot DBNull.Value, validaViajes.Item("Val15Resp"), Nothing)
                nuevoValida.Val15Obs = IIf(validaViajes.Item("Val15Obs") IsNot DBNull.Value, validaViajes.Item("Val15Obs"), Nothing)
                nuevoValida.Val8 = IIf(validaViajes.Item("Val8") IsNot DBNull.Value, validaViajes.Item("Val8"), Nothing)
                nuevoValida.Val8Resp = IIf(validaViajes.Item("Val8Resp") IsNot DBNull.Value, validaViajes.Item("Val8Resp"), Nothing)
                nuevoValida.Val8Obs = IIf(validaViajes.Item("Val8Obs") IsNot DBNull.Value, validaViajes.Item("Val8Obs"), Nothing)

                dataset.ValidaViaje.Rows.Add(nuevoValida)
            End While

            validaViajes.Close()

            'tabla validaetapa
            Dim objCommandValEtapa As New OleDbCommand("select * from validaetapa", objConn)
            Dim validaEtapas As OleDbDataReader = objCommandValEtapa.ExecuteReader()

            While validaEtapas.Read()
                Dim nuevoValida As ValidaEtapaRow = dataset.ValidaEtapa.NewValidaEtapaRow

                nuevoValida.Hogar = IIf(validaEtapas.Item("Hogar") IsNot DBNull.Value, validaEtapas.Item("Hogar"), Nothing)
                nuevoValida.Persona = IIf(validaEtapas.Item("Persona") IsNot DBNull.Value, validaEtapas.Item("Persona"), Nothing)
                nuevoValida.Viaje = IIf(validaEtapas.Item("Viaje") IsNot DBNull.Value, validaEtapas.Item("Viaje"), Nothing)
                nuevoValida.DiaViaje = IIf(validaEtapas.Item("DiaViaje") IsNot DBNull.Value, validaEtapas.Item("DiaViaje"), Nothing)
                nuevoValida.Etapa = IIf(validaEtapas.Item("Etapa") IsNot DBNull.Value, validaEtapas.Item("Etapa"), Nothing)
                nuevoValida.Val1 = IIf(validaEtapas.Item("Val1") IsNot DBNull.Value, validaEtapas.Item("Val1"), Nothing)
                nuevoValida.Val1Resp = IIf(validaEtapas.Item("Val1Resp") IsNot DBNull.Value, validaEtapas.Item("Val1Resp"), Nothing)
                nuevoValida.Val1Obs = IIf(validaEtapas.Item("Val1Obs") IsNot DBNull.Value, validaEtapas.Item("Val1Obs"), Nothing)
                nuevoValida.Val2 = IIf(validaEtapas.Item("Val2") IsNot DBNull.Value, validaEtapas.Item("Val2"), Nothing)
                nuevoValida.Val2Resp = IIf(validaEtapas.Item("Val2Resp") IsNot DBNull.Value, validaEtapas.Item("Val2Resp"), Nothing)
                nuevoValida.Val2Obs = IIf(validaEtapas.Item("Val2Obs") IsNot DBNull.Value, validaEtapas.Item("Val2Obs"), Nothing)
                nuevoValida.Val3 = IIf(validaEtapas.Item("Val3") IsNot DBNull.Value, validaEtapas.Item("Val3"), Nothing)
                nuevoValida.Val3Resp = IIf(validaEtapas.Item("Val3Resp") IsNot DBNull.Value, validaEtapas.Item("Val3Resp"), Nothing)
                nuevoValida.Val3Obs = IIf(validaEtapas.Item("Val3Obs") IsNot DBNull.Value, validaEtapas.Item("Val3Obs"), Nothing)
                nuevoValida.Val4 = IIf(validaEtapas.Item("Val4") IsNot DBNull.Value, validaEtapas.Item("Val4"), Nothing)
                nuevoValida.Val4Resp = IIf(validaEtapas.Item("Val4Resp") IsNot DBNull.Value, validaEtapas.Item("Val4Resp"), Nothing)
                nuevoValida.Val4Obs = IIf(validaEtapas.Item("Val4Obs") IsNot DBNull.Value, validaEtapas.Item("Val4Obs"), Nothing)
                nuevoValida.Val5 = IIf(validaEtapas.Item("Val5") IsNot DBNull.Value, validaEtapas.Item("Val5"), Nothing)
                nuevoValida.Val5Resp = IIf(validaEtapas.Item("Val5Resp") IsNot DBNull.Value, validaEtapas.Item("Val5Resp"), Nothing)
                nuevoValida.Val5Obs = IIf(validaEtapas.Item("Val5Obs") IsNot DBNull.Value, validaEtapas.Item("Val5Obs"), Nothing)
                nuevoValida.Val7 = IIf(validaEtapas.Item("Val7") IsNot DBNull.Value, validaEtapas.Item("Val7"), Nothing)
                nuevoValida.Val7Resp = IIf(validaEtapas.Item("Val7Resp") IsNot DBNull.Value, validaEtapas.Item("Val7Resp"), Nothing)
                nuevoValida.Val7Obs = IIf(validaEtapas.Item("Val7Obs") IsNot DBNull.Value, validaEtapas.Item("Val7Obs"), Nothing)
                nuevoValida.Val8 = IIf(validaEtapas.Item("Val8") IsNot DBNull.Value, validaEtapas.Item("Val8"), Nothing)
                nuevoValida.Val8Resp = IIf(validaEtapas.Item("Val8Resp") IsNot DBNull.Value, validaEtapas.Item("Val8Resp"), Nothing)
                nuevoValida.Val8Obs = IIf(validaEtapas.Item("Val8Obs") IsNot DBNull.Value, validaEtapas.Item("Val8Obs"), Nothing)
                nuevoValida.Val9 = IIf(validaEtapas.Item("Val9") IsNot DBNull.Value, validaEtapas.Item("Val9"), Nothing)
                nuevoValida.Val9Resp = IIf(validaEtapas.Item("Val9Resp") IsNot DBNull.Value, validaEtapas.Item("Val9Resp"), Nothing)
                nuevoValida.Val9Obs = IIf(validaEtapas.Item("Val9Obs") IsNot DBNull.Value, validaEtapas.Item("Val9Obs"), Nothing)
                nuevoValida.Val10 = IIf(validaEtapas.Item("Val10") IsNot DBNull.Value, validaEtapas.Item("Val10"), Nothing)
                nuevoValida.Val10Resp = IIf(validaEtapas.Item("Val10Resp") IsNot DBNull.Value, validaEtapas.Item("Val10Resp"), Nothing)
                nuevoValida.Val10Obs = IIf(validaEtapas.Item("Val10Obs") IsNot DBNull.Value, validaEtapas.Item("Val10Obs"), Nothing)
                nuevoValida.Val11 = IIf(validaEtapas.Item("Val11") IsNot DBNull.Value, validaEtapas.Item("Val11"), Nothing)
                nuevoValida.Val11Resp = IIf(validaEtapas.Item("Val11Resp") IsNot DBNull.Value, validaEtapas.Item("Val11Resp"), Nothing)
                nuevoValida.Val11Obs = IIf(validaEtapas.Item("Val11Obs") IsNot DBNull.Value, validaEtapas.Item("Val11Obs"), Nothing)
                nuevoValida.Val12 = IIf(validaEtapas.Item("Val12") IsNot DBNull.Value, validaEtapas.Item("Val12"), Nothing)
                nuevoValida.Val12Resp = IIf(validaEtapas.Item("Val12Resp") IsNot DBNull.Value, validaEtapas.Item("Val12Resp"), Nothing)
                nuevoValida.Val12Obs = IIf(validaEtapas.Item("Val12Obs") IsNot DBNull.Value, validaEtapas.Item("Val12Obs"), Nothing)
                nuevoValida.Val13 = IIf(validaEtapas.Item("Val13") IsNot DBNull.Value, validaEtapas.Item("Val13"), Nothing)
                nuevoValida.Val13Resp = IIf(validaEtapas.Item("Val13Resp") IsNot DBNull.Value, validaEtapas.Item("Val13Resp"), Nothing)
                nuevoValida.Val13Obs = IIf(validaEtapas.Item("Val13Obs") IsNot DBNull.Value, validaEtapas.Item("Val13Obs"), Nothing)
                nuevoValida.Val14 = IIf(validaEtapas.Item("Val14") IsNot DBNull.Value, validaEtapas.Item("Val14"), Nothing)
                nuevoValida.Val14Resp = IIf(validaEtapas.Item("Val14Resp") IsNot DBNull.Value, validaEtapas.Item("Val14Resp"), Nothing)
                nuevoValida.Val14Obs = IIf(validaEtapas.Item("Val14Obs") IsNot DBNull.Value, validaEtapas.Item("Val14Obs"), Nothing)
                nuevoValida.Val16 = IIf(validaEtapas.Item("Val16") IsNot DBNull.Value, validaEtapas.Item("Val16"), Nothing)
                nuevoValida.Val16Resp = IIf(validaEtapas.Item("Val16Resp") IsNot DBNull.Value, validaEtapas.Item("Val16Resp"), Nothing)
                nuevoValida.Val16Obs = IIf(validaEtapas.Item("Val16Obs") IsNot DBNull.Value, validaEtapas.Item("Val16Obs"), Nothing)
                nuevoValida.Val17 = IIf(validaEtapas.Item("Val17") IsNot DBNull.Value, validaEtapas.Item("Val17"), Nothing)
                nuevoValida.Val17Resp = IIf(validaEtapas.Item("Val17Resp") IsNot DBNull.Value, validaEtapas.Item("Val17Resp"), Nothing)
                nuevoValida.Val17Obs = IIf(validaEtapas.Item("Val17Obs") IsNot DBNull.Value, validaEtapas.Item("Val17Obs"), Nothing)
                nuevoValida.Val18 = IIf(validaEtapas.Item("Val18") IsNot DBNull.Value, validaEtapas.Item("Val18"), Nothing)
                nuevoValida.Val18Resp = IIf(validaEtapas.Item("Val18Resp") IsNot DBNull.Value, validaEtapas.Item("Val18Resp"), Nothing)
                nuevoValida.Val18Obs = IIf(validaEtapas.Item("Val18Obs") IsNot DBNull.Value, validaEtapas.Item("Val18Obs"), Nothing)
                nuevoValida.Val19 = IIf(validaEtapas.Item("Val19") IsNot DBNull.Value, validaEtapas.Item("Val19"), Nothing)
                nuevoValida.Val19Resp = IIf(validaEtapas.Item("Val19Resp") IsNot DBNull.Value, validaEtapas.Item("Val19Resp"), Nothing)
                nuevoValida.Val19Obs = IIf(validaEtapas.Item("Val19Obs") IsNot DBNull.Value, validaEtapas.Item("Val19Obs"), Nothing)

                dataset.ValidaEtapa.Rows.Add(nuevoValida)
            End While

            validaEtapas.Close()
        Catch ex As Exception
            dataset.RejectChanges()
            MessageBox.Show("No se pudo restaurar las tablas de validación. Error: " & ex.Message & ControlChars.Lf & ControlChars.Lf & "Pila de ejecución: " & ControlChars.Lf & ControlChars.Lf & ex.StackTrace, "Error en restauración de base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        Finally
            Dim adapterValHogar As ValidaHogarTableAdapter = New ValidaHogarTableAdapter
            Dim adapterValPersona As ValidaPersonaTableAdapter = New ValidaPersonaTableAdapter
            Dim adapterValViaje As ValidaViajeTableAdapter = New ValidaViajeTableAdapter
            Dim adapterValEtapa As ValidaEtapaTableAdapter = New ValidaEtapaTableAdapter

            adapterValHogar.Update(dataset.ValidaHogar)
            adapterValPersona.Update(dataset.ValidaPersona)
            adapterValViaje.Update(dataset.ValidaViaje)
            adapterValEtapa.Update(dataset.ValidaEtapa)

            dataset.AcceptChanges()
        End Try




        '*************************************

        'PASO 4 - RESTAURAR TABLAS HISTÓRICAS

        '*************************************
        procedimiento = 4
        bw.ReportProgress(75)
        Try
            'tabla hogar
            Dim objCommandHogarH As New OleDbCommand("select * from hogar_h", objConn)
            Dim hogaresH As OleDbDataReader = objCommandHogarH.ExecuteReader()

            While hogaresH.Read()
                Dim nuevoHogarH As Hogar_HRow = dataset.Hogar_H.NewHogar_HRow

                nuevoHogarH.Hogar = IIf(hogaresH.Item("Hogar") IsNot DBNull.Value, hogaresH.Item("Hogar"), Nothing)
                nuevoHogarH.IDEncuestador = IIf(hogaresH.Item("IDEncuestador") IsNot DBNull.Value, hogaresH.Item("IDEncuestador"), Nothing)
                nuevoHogarH.Macrozona = IIf(hogaresH.Item("Macrozona") IsNot DBNull.Value, hogaresH.Item("Macrozona"), Nothing)

                Try
                    nuevoHogarH.GastoFamiliarTransporte = IIf(hogaresH.Item("GastoFamiliarTransporte") IsNot DBNull.Value, hogaresH.Item("GastoFamiliarTransporte"), Nothing)
                    nuevoHogarH.IndicaGFT = IIf(hogaresH.Item("IndicaGFT") IsNot DBNull.Value, hogaresH.Item("IndicaGFT"), Nothing)
                Catch ex As Exception

                End Try
                nuevoHogarH.Zona = IIf(hogaresH.Item("Zona") IsNot DBNull.Value, hogaresH.Item("Zona"), Nothing)
                nuevoHogarH.Manzana = IIf(hogaresH.Item("Manzana") IsNot DBNull.Value, hogaresH.Item("Manzana"), Nothing)
                nuevoHogarH.Comuna = IIf(hogaresH.Item("Comuna") IsNot DBNull.Value, hogaresH.Item("Comuna"), Nothing)
                nuevoHogarH.NombreCalle = IIf(hogaresH.Item("NombreCalle") IsNot DBNull.Value, hogaresH.Item("NombreCalle"), Nothing)
                nuevoHogarH.Numero = IIf(hogaresH.Item("Numero") IsNot DBNull.Value, hogaresH.Item("Numero"), Nothing)
                nuevoHogarH.CasaDepto = IIf(hogaresH.Item("CasaDepto") IsNot DBNull.Value, hogaresH.Item("CasaDepto"), Nothing)
                nuevoHogarH.TipoViviendaActual = IIf(hogaresH.Item("TipoViviendaActual") IsNot DBNull.Value, hogaresH.Item("TipoViviendaActual"), Nothing)
                nuevoHogarH.Telefono = IIf(hogaresH.Item("Telefono") IsNot DBNull.Value, hogaresH.Item("Telefono"), Nothing)
                nuevoHogarH.DirCoordX = IIf(hogaresH.Item("DirCoordX") IsNot DBNull.Value, hogaresH.Item("DirCoordX"), Nothing)
                nuevoHogarH.DirCoordY = IIf(hogaresH.Item("DirCoordY") IsNot DBNull.Value, hogaresH.Item("DirCoordY"), Nothing)
                nuevoHogarH.FechaVisita1 = IIf(hogaresH.Item("FechaVisita1") IsNot DBNull.Value, hogaresH.Item("FechaVisita1"), Nothing)
                Try
                    nuevoHogarH.FechaViajesLab = IIf(hogaresH.Item("FechaViajesLab") IsNot DBNull.Value, hogaresH.Item("FechaViajesLab"), Nothing)
                    nuevoHogarH.FechaViajesSab = IIf(hogaresH.Item("FechaViajesSab") IsNot DBNull.Value, hogaresH.Item("FechaViajesSab"), Nothing)
                    nuevoHogarH.FechaViajesDom = IIf(hogaresH.Item("FechaViajesDom") IsNot DBNull.Value, hogaresH.Item("FechaViajesDom"), Nothing)
                Catch ex As Exception

                End Try

                nuevoHogarH.DiaAsig = IIf(hogaresH.Item("DiaAsig") IsNot DBNull.Value, hogaresH.Item("DiaAsig"), Nothing)
                nuevoHogarH.TipoDia = IIf(hogaresH.Item("TipoDia") IsNot DBNull.Value, hogaresH.Item("TipoDia"), Nothing)
                nuevoHogarH.NumPer = IIf(hogaresH.Item("NumPer") IsNot DBNull.Value, hogaresH.Item("NumPer"), Nothing)
                nuevoHogarH.NumVeh = IIf(hogaresH.Item("NumVeh") IsNot DBNull.Value, hogaresH.Item("NumVeh"), Nothing)
                nuevoHogarH.Propiedad = IIf(hogaresH.Item("Propiedad") IsNot DBNull.Value, hogaresH.Item("Propiedad"), Nothing)
                nuevoHogarH.PropiedadOtra = IIf(hogaresH.Item("PropiedadOtra") IsNot DBNull.Value, hogaresH.Item("PropiedadOtra"), Nothing)
                nuevoHogarH.MontoDiv = IIf(hogaresH.Item("MontoDiv") IsNot DBNull.Value, hogaresH.Item("MontoDiv"), Nothing)
                nuevoHogarH.ImputadoDiv = IIf(hogaresH.Item("ImputadoDiv") IsNot DBNull.Value, hogaresH.Item("ImputadoDiv"), Nothing)
                nuevoHogarH.MontoArr = IIf(hogaresH.Item("MontoArr") IsNot DBNull.Value, hogaresH.Item("MontoArr"), Nothing)
                nuevoHogarH.ImputadoArr = IIf(hogaresH.Item("ImputadoArr") IsNot DBNull.Value, hogaresH.Item("ImputadoArr"), Nothing)
                nuevoHogarH.MontoEst = IIf(hogaresH.Item("MontoEst") IsNot DBNull.Value, hogaresH.Item("MontoEst"), Nothing)
                nuevoHogarH.ImputadoEst = IIf(hogaresH.Item("ImputadoEst") IsNot DBNull.Value, hogaresH.Item("ImputadoEst"), Nothing)
                nuevoHogarH.NoSabeNoResponde = IIf(hogaresH.Item("NoSabeNoResponde") IsNot DBNull.Value, hogaresH.Item("NoSabeNoResponde"), Nothing)
                nuevoHogarH.IngresoHogar = IIf(hogaresH.Item("IngresoHogar") IsNot DBNull.Value, hogaresH.Item("IngresoHogar"), Nothing)
                nuevoHogarH.TipoIngreso = IIf(hogaresH.Item("TipoIngreso") IsNot DBNull.Value, hogaresH.Item("TipoIngreso"), Nothing)
                nuevoHogarH.Factor_Laboral = IIf(hogaresH.Item("Factor_Laboral") IsNot DBNull.Value, hogaresH.Item("Factor_Laboral"), Nothing)
                nuevoHogarH.Factor_Sabado = IIf(hogaresH.Item("Factor_Sabado") IsNot DBNull.Value, hogaresH.Item("Factor_Sabado"), Nothing)
                nuevoHogarH.Factor_Domingo = IIf(hogaresH.Item("Factor_Domingo") IsNot DBNull.Value, hogaresH.Item("Factor_Domingo"), Nothing)
                nuevoHogarH.Factor = IIf(hogaresH.Item("Factor") IsNot DBNull.Value, hogaresH.Item("Factor"), Nothing)
                nuevoHogarH.Observacion = IIf(hogaresH.Item("Observacion") IsNot DBNull.Value, hogaresH.Item("Observacion"), Nothing)
                nuevoHogarH.EstadoEncuesta = IIf(hogaresH.Item("EstadoEncuesta") IsNot DBNull.Value, hogaresH.Item("EstadoEncuesta"), Nothing)
                nuevoHogarH.Operacion = IIf(hogaresH.Item("Operacion") IsNot DBNull.Value, hogaresH.Item("Operacion"), Nothing)
                nuevoHogarH.HoraMod = IIf(hogaresH.Item("HoraMod") IsNot DBNull.Value, hogaresH.Item("HoraMod"), Nothing)

                dataset.Hogar_H.Rows.Add(nuevoHogarH)
            End While

            hogaresH.Close()

            'tabla vehiculo
            Dim objCommandVehiculoH As New OleDbCommand("select * from vehiculo_h", objConn)
            Dim vehiculosH As OleDbDataReader = objCommandVehiculoH.ExecuteReader()

            While vehiculosH.Read()
                Dim nuevoVehiculoH As Vehiculo_HRow = dataset.Vehiculo_H.NewVehiculo_HRow

                nuevoVehiculoH.Hogar = IIf(vehiculosH.Item("Hogar") IsNot DBNull.Value, vehiculosH.Item("Hogar"), Nothing)
                nuevoVehiculoH.Vehículo = IIf(vehiculosH.Item("Vehículo") IsNot DBNull.Value, vehiculosH.Item("Vehículo"), Nothing)
                nuevoVehiculoH.TipoVeh = IIf(vehiculosH.Item("TipoVeh") IsNot DBNull.Value, vehiculosH.Item("TipoVeh"), Nothing)
                nuevoVehiculoH.Propiedad = IIf(vehiculosH.Item("Propiedad") IsNot DBNull.Value, vehiculosH.Item("Propiedad"), Nothing)
                nuevoVehiculoH.PropiedadOtro = IIf(vehiculosH.Item("PropiedadOtro") IsNot DBNull.Value, vehiculosH.Item("PropiedadOtro"), Nothing)
                Try
                    nuevoVehiculoH.TipoMotor = IIf(vehiculosH.Item("TipoMotor") IsNot DBNull.Value, vehiculosH.Item("TipoMotor"), Nothing)
                    nuevoVehiculoH.AnioFabricacion = IIf(vehiculosH.Item("AnioFabricacion") IsNot DBNull.Value, vehiculosH.Item("AnioFabricacion"), Nothing)
                Catch ex As Exception

                End Try
                nuevoVehiculoH.Operacion = IIf(vehiculosH.Item("Operacion") IsNot DBNull.Value, vehiculosH.Item("Operacion"), Nothing)
                nuevoVehiculoH.HoraMod = IIf(vehiculosH.Item("HoraMod") IsNot DBNull.Value, vehiculosH.Item("HoraMod"), Nothing)

                dataset.Vehiculo_H.Rows.Add(nuevoVehiculoH)
            End While

            vehiculosH.Close()

            'tabla persona
            Dim objCommandPersonaH As New OleDbCommand("select * from persona_H", objConn)
            Dim personasH As OleDbDataReader = objCommandPersonaH.ExecuteReader()

            While personasH.Read()
                Dim nuevaPersonaH As Persona_HRow = dataset.Persona_H.NewPersona_HRow

                nuevaPersonaH.Hogar = IIf(personasH.Item("Hogar") IsNot DBNull.Value, personasH.Item("Hogar"), Nothing)
                nuevaPersonaH.Persona = IIf(personasH.Item("Persona") IsNot DBNull.Value, personasH.Item("Persona"), Nothing)
                nuevaPersonaH.NombrePila = IIf(personasH.Item("NombrePila") IsNot DBNull.Value, personasH.Item("NombrePila"), Nothing)
                nuevaPersonaH.AnoNac = IIf(personasH.Item("AnoNac") IsNot DBNull.Value, personasH.Item("AnoNac"), Nothing)
                nuevaPersonaH.Sexo = IIf(personasH.Item("Sexo") IsNot DBNull.Value, personasH.Item("Sexo"), Nothing)
                nuevaPersonaH.Relacion = IIf(personasH.Item("Relacion") IsNot DBNull.Value, personasH.Item("Relacion"), Nothing)
                Try
                    nuevaPersonaH.ViajesLab = IIf(personasH.Item("ViajesLab") IsNot DBNull.Value, personasH.Item("ViajesLab"), Nothing)
                    nuevaPersonaH.ViajesSab = IIf(personasH.Item("ViajesSab") IsNot DBNull.Value, personasH.Item("ViajesSab"), Nothing)
                    nuevaPersonaH.ViajesDom = IIf(personasH.Item("ViajesDom") IsNot DBNull.Value, personasH.Item("ViajesDom"), Nothing)
                    nuevaPersonaH.Discapacitado = IIf(personasH.Item("Discapacitado") IsNot DBNull.Value, personasH.Item("Discapacitado"), Nothing)
                    nuevaPersonaH.TipoDiscapacidad = IIf(personasH.Item("TipoDiscapacidad") IsNot DBNull.Value, personasH.Item("TipoDiscapacidad"), Nothing)
                    nuevaPersonaH.DiscapacidadAutosuficiente = IIf(personasH.Item("DiscapacidadAutosuficiente") IsNot DBNull.Value, personasH.Item("DiscapacidadAutosuficiente"), Nothing)
                Catch ex As Exception

                End Try

                nuevaPersonaH.Estudios = IIf(personasH.Item("Estudios") IsNot DBNull.Value, personasH.Item("Estudios"), Nothing)
                nuevaPersonaH.EstudiosCompletos = IIf(personasH.Item("EstudiosCompletos") IsNot DBNull.Value, personasH.Item("EstudiosCompletos"), Nothing)
                nuevaPersonaH.Actividad = IIf(personasH.Item("Actividad") IsNot DBNull.Value, personasH.Item("Actividad"), Nothing)
                nuevaPersonaH.ActividadOtra = IIf(personasH.Item("ActividadOtra") IsNot DBNull.Value, personasH.Item("ActividadOtra"), Nothing)
                nuevaPersonaH.LicenciaConducir = IIf(personasH.Item("LicenciaConducir") IsNot DBNull.Value, personasH.Item("LicenciaConducir"), Nothing)
                nuevaPersonaH.PaseEscolar = IIf(personasH.Item("PaseEscolar") IsNot DBNull.Value, personasH.Item("PaseEscolar"), Nothing)
                nuevaPersonaH.DondeEstudia = IIf(personasH.Item("DondeEstudia") IsNot DBNull.Value, personasH.Item("DondeEstudia"), Nothing)
                nuevaPersonaH.JornadaTrabajo = IIf(personasH.Item("JornadaTrabajo") IsNot DBNull.Value, personasH.Item("JornadaTrabajo"), Nothing)
                nuevaPersonaH.ComunaTrabajo = IIf(personasH.Item("ComunaTrabajo") IsNot DBNull.Value, personasH.Item("ComunaTrabajo"), Nothing)
                nuevaPersonaH.ComunaTrabajoOtra = IIf(personasH.Item("ComunaTrabajoOtra") IsNot DBNull.Value, personasH.Item("ComunaTrabajoOtra"), Nothing)
                nuevaPersonaH.NombreCalle1Trabajo = IIf(personasH.Item("NombreCalle1Trabajo") IsNot DBNull.Value, personasH.Item("NombreCalle1Trabajo"), Nothing)
                nuevaPersonaH.NumeroOCalle2Trabajo = IIf(personasH.Item("NumeroOCalle2Trabajo") IsNot DBNull.Value, personasH.Item("NumeroOCalle2Trabajo"), Nothing)
                nuevaPersonaH.HitoTrabajo = IIf(personasH.Item("HitoTrabajo") IsNot DBNull.Value, personasH.Item("HitoTrabajo"), Nothing)
                nuevaPersonaH.ManzanaTrabajo = IIf(personasH.Item("ManzanaTrabajo") IsNot DBNull.Value, personasH.Item("ManzanaTrabajo"), Nothing)
                nuevaPersonaH.DirActividadCoordX = IIf(personasH.Item("DirActividadCoordX") IsNot DBNull.Value, personasH.Item("DirActividadCoordX"), Nothing)
                nuevaPersonaH.DirActividadCoordY = IIf(personasH.Item("DirActividadCoordY") IsNot DBNull.Value, personasH.Item("DirActividadCoordY"), Nothing)
                nuevaPersonaH.ComunaEstudio = IIf(personasH.Item("ComunaEstudio") IsNot DBNull.Value, personasH.Item("ComunaEstudio"), Nothing)
                nuevaPersonaH.ComunaEstudioOtra = IIf(personasH.Item("ComunaEstudioOtra") IsNot DBNull.Value, personasH.Item("ComunaEstudioOtra"), Nothing)
                nuevaPersonaH.NombreCalle1Estudio = IIf(personasH.Item("NombreCalle1Estudio") IsNot DBNull.Value, personasH.Item("NombreCalle1Estudio"), Nothing)
                nuevaPersonaH.NumeroOCalle2Estudio = IIf(personasH.Item("NumeroOCalle2Estudio") IsNot DBNull.Value, personasH.Item("NumeroOCalle2Estudio"), Nothing)
                nuevaPersonaH.HitoEstudio = IIf(personasH.Item("HitoEstudio") IsNot DBNull.Value, personasH.Item("HitoEstudio"), Nothing)
                nuevaPersonaH.ManzanaEstudio = IIf(personasH.Item("ManzanaEstudio") IsNot DBNull.Value, personasH.Item("ManzanaEstudio"), Nothing)
                nuevaPersonaH.DirEstudiosCoordX = IIf(personasH.Item("DirEstudiosCoordX") IsNot DBNull.Value, personasH.Item("DirEstudiosCoordX"), Nothing)
                nuevaPersonaH.DirEstudiosCoordY = IIf(personasH.Item("DirEstudiosCoordY") IsNot DBNull.Value, personasH.Item("DirEstudiosCoordY"), Nothing)
                Try
                    nuevaPersonaH.NoViajaLab = IIf(personasH.Item("NoViajaLab") IsNot DBNull.Value, personasH.Item("NoViajaLab"), Nothing)
                    nuevaPersonaH.NoViajaSab = IIf(personasH.Item("NoViajaSab") IsNot DBNull.Value, personasH.Item("NoViajaSab"), Nothing)
                    nuevaPersonaH.NoViajaDom = IIf(personasH.Item("NoViajaDom") IsNot DBNull.Value, personasH.Item("NoViajaDom"), Nothing)
                    nuevaPersonaH.NoViajaLabOtroMotivo = IIf(personasH.Item("NoViajaLabOtroMotivo") IsNot DBNull.Value, personasH.Item("NoViajaLabOtroMotivo"), Nothing)
                    nuevaPersonaH.NoViajaSabOtroMotivo = IIf(personasH.Item("NoViajaSabOtroMotivo") IsNot DBNull.Value, personasH.Item("NoViajaSabOtroMotivo"), Nothing)
                    nuevaPersonaH.NoViajaDomOtroMotivo = IIf(personasH.Item("NoViajaDomOtroMotivo") IsNot DBNull.Value, personasH.Item("NoViajaDomOtroMotivo"), Nothing)
                Catch ex As Exception

                End Try

                nuevaPersonaH.TieneIngresos = IIf(personasH.Item("TieneIngresos") IsNot DBNull.Value, personasH.Item("TieneIngresos"), Nothing)
                nuevaPersonaH.IngresoLiquido = IIf(personasH.Item("IngresoLiquido") IsNot DBNull.Value, personasH.Item("IngresoLiquido"), Nothing)
                nuevaPersonaH.TramoIngreso = IIf(personasH.Item("TramoIngreso") IsNot DBNull.Value, personasH.Item("TramoIngreso"), Nothing)
                nuevaPersonaH.IngresoFinal = IIf(personasH.Item("IngresoFinal") IsNot DBNull.Value, personasH.Item("IngresoFinal"), Nothing)
                nuevaPersonaH.TramoIngresoFinal = IIf(personasH.Item("TramoIngresoFinal") IsNot DBNull.Value, personasH.Item("TramoIngresoFinal"), Nothing)
                nuevaPersonaH.IngresoImputado = IIf(personasH.Item("IngresoImputado") IsNot DBNull.Value, personasH.Item("IngresoImputado"), Nothing)
                nuevaPersonaH.Factor_Laboral = IIf(personasH.Item("Factor_Laboral") IsNot DBNull.Value, personasH.Item("Factor_Laboral"), Nothing)
                nuevaPersonaH.Factor_Sabado = IIf(personasH.Item("Factor_Sabado") IsNot DBNull.Value, personasH.Item("Factor_Sabado"), Nothing)
                nuevaPersonaH.Factor_Domingo = IIf(personasH.Item("Factor_Domingo") IsNot DBNull.Value, personasH.Item("Factor_Domingo"), Nothing)
                nuevaPersonaH.Factor = IIf(personasH.Item("Factor") IsNot DBNull.Value, personasH.Item("Factor"), Nothing)
                nuevaPersonaH.Encuestado = IIf(personasH.Item("Encuestado") IsNot DBNull.Value, personasH.Item("Encuestado"), Nothing)
                nuevaPersonaH.Operacion = IIf(personasH.Item("Operacion") IsNot DBNull.Value, personasH.Item("Operacion"), Nothing)
                nuevaPersonaH.HoraMod = IIf(personasH.Item("HoraMod") IsNot DBNull.Value, personasH.Item("HoraMod"), Nothing)

                dataset.Persona_H.Rows.Add(nuevaPersonaH)
            End While

            personasH.Close()

            'tabla viaje
            Dim objCommandViajeH As New OleDbCommand("select * from viaje_H", objConn)
            Dim viajesH As OleDbDataReader = objCommandViajeH.ExecuteReader()

            While viajesH.Read()
                Dim nuevoViajeH As Viaje_HRow = dataset.Viaje_H.NewViaje_HRow

                nuevoViajeH.Hogar = IIf(viajesH.Item("Hogar") IsNot DBNull.Value, viajesH.Item("Hogar"), Nothing)
                nuevoViajeH.Persona = IIf(viajesH.Item("Persona") IsNot DBNull.Value, viajesH.Item("Persona"), Nothing)
                nuevoViajeH.Viaje = IIf(viajesH.Item("Viaje") IsNot DBNull.Value, viajesH.Item("Viaje"), Nothing)
                Try
                    nuevoViajeH.DiaViaje = IIf(viajesH.Item("DiaViaje") IsNot DBNull.Value, viajesH.Item("DiaViaje"), Nothing)
                Catch ex As Exception

                End Try
                nuevoViajeH.Etapas = IIf(viajesH.Item("Etapas") IsNot DBNull.Value, viajesH.Item("Etapas"), Nothing)
                nuevoViajeH.ComunaOrigen = IIf(viajesH.Item("ComunaOrigen") IsNot DBNull.Value, viajesH.Item("ComunaOrigen"), Nothing)
                nuevoViajeH.ComunaOtraOrigen = IIf(viajesH.Item("ComunaOtraOrigen") IsNot DBNull.Value, viajesH.Item("ComunaOtraOrigen"), Nothing)
                nuevoViajeH.ComunaDestino = IIf(viajesH.Item("ComunaDestino") IsNot DBNull.Value, viajesH.Item("ComunaDestino"), Nothing)
                nuevoViajeH.ComunaOtraDestino = IIf(viajesH.Item("ComunaOtraDestino") IsNot DBNull.Value, viajesH.Item("ComunaOtraDestino"), Nothing)
                nuevoViajeH.MacrozonaOrigen = IIf(viajesH.Item("MacrozonaOrigen") IsNot DBNull.Value, viajesH.Item("MacrozonaOrigen"), Nothing)
                nuevoViajeH.MacrozonaDestino = IIf(viajesH.Item("MacrozonaDestino") IsNot DBNull.Value, viajesH.Item("MacrozonaDestino"), Nothing)
                nuevoViajeH.ZonaOrigen = IIf(viajesH.Item("ZonaOrigen") IsNot DBNull.Value, viajesH.Item("ZonaOrigen"), Nothing)
                nuevoViajeH.ZonaDestino = IIf(viajesH.Item("ZonaDestino") IsNot DBNull.Value, viajesH.Item("ZonaDestino"), Nothing)
                nuevoViajeH.ManzanaOrigen = IIf(viajesH.Item("ManzanaOrigen") IsNot DBNull.Value, viajesH.Item("ManzanaOrigen"), Nothing)
                nuevoViajeH.ManzanaDestino = IIf(viajesH.Item("ManzanaDestino") IsNot DBNull.Value, viajesH.Item("ManzanaDestino"), Nothing)
                nuevoViajeH.NombreCalle1Origen = IIf(viajesH.Item("NombreCalle1Origen") IsNot DBNull.Value, viajesH.Item("NombreCalle1Origen"), Nothing)
                nuevoViajeH.NumeroOCalle2Origen = IIf(viajesH.Item("NumeroOCalle2Origen") IsNot DBNull.Value, viajesH.Item("NumeroOCalle2Origen"), Nothing)
                nuevoViajeH.HitoOrigen = IIf(viajesH.Item("HitoOrigen") IsNot DBNull.Value, viajesH.Item("HitoOrigen"), Nothing)
                nuevoViajeH.OrigenCoordX = IIf(viajesH.Item("OrigenCoordX") IsNot DBNull.Value, viajesH.Item("OrigenCoordX"), Nothing)
                nuevoViajeH.OrigenCoordY = IIf(viajesH.Item("OrigenCoordY") IsNot DBNull.Value, viajesH.Item("OrigenCoordY"), Nothing)
                nuevoViajeH.NombreCalle1Destino = IIf(viajesH.Item("NombreCalle1Destino") IsNot DBNull.Value, viajesH.Item("NombreCalle1Destino"), Nothing)
                nuevoViajeH.NumeroOCalle2Destino = IIf(viajesH.Item("NumeroOCalle2Destino") IsNot DBNull.Value, viajesH.Item("NumeroOCalle2Destino"), Nothing)
                nuevoViajeH.HitoDestino = IIf(viajesH.Item("HitoDestino") IsNot DBNull.Value, viajesH.Item("HitoDestino"), Nothing)
                nuevoViajeH.DestinoCoordX = IIf(viajesH.Item("DestinoCoordX") IsNot DBNull.Value, viajesH.Item("DestinoCoordX"), Nothing)
                nuevoViajeH.DestinoCoordY = IIf(viajesH.Item("DestinoCoordY") IsNot DBNull.Value, viajesH.Item("DestinoCoordY"), Nothing)
                nuevoViajeH.TrabajoDeclarado = IIf(viajesH.Item("TrabajoDeclarado") IsNot DBNull.Value, viajesH.Item("TrabajoDeclarado"), Nothing)
                nuevoViajeH.EstudioDeclarado = IIf(viajesH.Item("EstudioDeclarado") IsNot DBNull.Value, viajesH.Item("EstudioDeclarado"), Nothing)
                nuevoViajeH.Proposito = IIf(viajesH.Item("Proposito") IsNot DBNull.Value, viajesH.Item("Proposito"), Nothing)
                nuevoViajeH.PropositoOtro = IIf(viajesH.Item("PropositoOtro") IsNot DBNull.Value, viajesH.Item("PropositoOtro"), Nothing)
                nuevoViajeH.PropositoEstraus = IIf(viajesH.Item("PropositoEstraus") IsNot DBNull.Value, viajesH.Item("PropositoEstraus"), Nothing)
                nuevoViajeH.MediosUsados = IIf(viajesH.Item("MediosUsados") IsNot DBNull.Value, viajesH.Item("MediosUsados"), Nothing)
                nuevoViajeH.ModoAgregado = IIf(viajesH.Item("ModoAgregado") IsNot DBNull.Value, viajesH.Item("ModoAgregado"), Nothing)
                nuevoViajeH.ModoPriPub = IIf(viajesH.Item("ModoPriPub") IsNot DBNull.Value, viajesH.Item("ModoPriPub"), Nothing)
                nuevoViajeH.ModoMotor = IIf(viajesH.Item("ModoMotor") IsNot DBNull.Value, viajesH.Item("ModoMotor"), Nothing)
                nuevoViajeH.HoraIni = IIf(viajesH.Item("HoraIni") IsNot DBNull.Value, viajesH.Item("HoraIni"), Nothing)
                nuevoViajeH.Horafin = IIf(viajesH.Item("Horafin") IsNot DBNull.Value, viajesH.Item("Horafin"), Nothing)
                nuevoViajeH.HoraMedia = IIf(viajesH.Item("HoraMedia") IsNot DBNull.Value, viajesH.Item("HoraMedia"), Nothing)
                nuevoViajeH.Trasnoche = IIf(viajesH.Item("Trasnoche") IsNot DBNull.Value, viajesH.Item("Trasnoche"), Nothing)
                nuevoViajeH.TiempoViaje = IIf(viajesH.Item("TiempoViaje") IsNot DBNull.Value, viajesH.Item("TiempoViaje"), Nothing)
                nuevoViajeH.TiempoMedio = IIf(viajesH.Item("TiempoMedio") IsNot DBNull.Value, viajesH.Item("TiempoMedio"), Nothing)
                nuevoViajeH.Periodo = IIf(viajesH.Item("Periodo") IsNot DBNull.Value, viajesH.Item("Periodo"), Nothing)
                nuevoViajeH.MinutosDespues = IIf(viajesH.Item("MinutosDespues") IsNot DBNull.Value, viajesH.Item("MinutosDespues"), Nothing)
                nuevoViajeH.CuadrasDespues = IIf(viajesH.Item("CuadrasDespues") IsNot DBNull.Value, viajesH.Item("CuadrasDespues"), Nothing)
                nuevoViajeH.FactorLaboral = IIf(viajesH.Item("FactorLaboral") IsNot DBNull.Value, viajesH.Item("FactorLaboral"), Nothing)
                nuevoViajeH.FactorSabado = IIf(viajesH.Item("FactorSabado") IsNot DBNull.Value, viajesH.Item("FactorSabado"), Nothing)
                nuevoViajeH.FactorDomingo = IIf(viajesH.Item("FactorDomingo") IsNot DBNull.Value, viajesH.Item("FactorDomingo"), Nothing)
                nuevoViajeH.CodigoTiempo = IIf(viajesH.Item("CodigoTiempo") IsNot DBNull.Value, viajesH.Item("CodigoTiempo"), Nothing)
                nuevoViajeH.Operacion = IIf(viajesH.Item("Operacion") IsNot DBNull.Value, viajesH.Item("Operacion"), Nothing)
                nuevoViajeH.HoraMod = IIf(viajesH.Item("HoraMod") IsNot DBNull.Value, viajesH.Item("HoraMod"), Nothing)

                dataset.Viaje_H.Rows.Add(nuevoViajeH)
            End While

            viajesH.Close()

            'tabla etapa
            Dim objCommandEtapaH As New OleDbCommand("select * from etapa_H", objConn)
            Dim etapasH As OleDbDataReader = objCommandEtapaH.ExecuteReader()

            While etapasH.Read()
                Dim nuevaEtapaH As Etapa_HRow = dataset.Etapa_H.NewEtapa_HRow

                nuevaEtapaH.Hogar = IIf(etapasH.Item("Hogar") IsNot DBNull.Value, etapasH.Item("Hogar"), Nothing)
                nuevaEtapaH.Persona = IIf(etapasH.Item("Persona") IsNot DBNull.Value, etapasH.Item("Persona"), Nothing)
                nuevaEtapaH.Viaje = IIf(etapasH.Item("Viaje") IsNot DBNull.Value, etapasH.Item("Viaje"), Nothing)
                Try
                    nuevaEtapaH.DiaViaje = IIf(etapasH.Item("DiaViaje") IsNot DBNull.Value, etapasH.Item("DiaViaje"), Nothing)
                Catch ex As Exception

                End Try
                nuevaEtapaH.Etapa = IIf(etapasH.Item("Etapa") IsNot DBNull.Value, etapasH.Item("Etapa"), Nothing)
                nuevaEtapaH.ComunaOrigen = IIf(etapasH.Item("ComunaOrigen") IsNot DBNull.Value, etapasH.Item("ComunaOrigen"), Nothing)
                nuevaEtapaH.ComunaOtraOrigen = IIf(etapasH.Item("ComunaOtraOrigen") IsNot DBNull.Value, etapasH.Item("ComunaOtraOrigen"), Nothing)
                nuevaEtapaH.ComunaDestino = IIf(etapasH.Item("ComunaDestino") IsNot DBNull.Value, etapasH.Item("ComunaDestino"), Nothing)
                nuevaEtapaH.ComunaOtraDestino = IIf(etapasH.Item("ComunaOtraDestino") IsNot DBNull.Value, etapasH.Item("ComunaOtraDestino"), Nothing)
                nuevaEtapaH.ZonaOrigen = IIf(etapasH.Item("ZonaOrigen") IsNot DBNull.Value, etapasH.Item("ZonaOrigen"), Nothing)
                nuevaEtapaH.ZonaDestino = IIf(etapasH.Item("ZonaDestino") IsNot DBNull.Value, etapasH.Item("ZonaDestino"), Nothing)
                nuevaEtapaH.ManzanaOrigen = IIf(etapasH.Item("ManzanaOrigen") IsNot DBNull.Value, etapasH.Item("ManzanaOrigen"), Nothing)
                nuevaEtapaH.ManzanaDestino = IIf(etapasH.Item("ManzanaDestino") IsNot DBNull.Value, etapasH.Item("ManzanaDestino"), Nothing)
                nuevaEtapaH.NombreCalle1Origen = IIf(etapasH.Item("NombreCalle1Origen") IsNot DBNull.Value, etapasH.Item("NombreCalle1Origen"), Nothing)
                nuevaEtapaH.NumeroOCalle2Origen = IIf(etapasH.Item("NumeroOCalle2Origen") IsNot DBNull.Value, etapasH.Item("NumeroOCalle2Origen"), Nothing)
                nuevaEtapaH.HitoOrigen = IIf(etapasH.Item("HitoOrigen") IsNot DBNull.Value, etapasH.Item("HitoOrigen"), Nothing)
                nuevaEtapaH.OrigenCoordX = IIf(etapasH.Item("OrigenCoordX") IsNot DBNull.Value, etapasH.Item("OrigenCoordX"), Nothing)
                nuevaEtapaH.OrigenCoordY = IIf(etapasH.Item("OrigenCoordY") IsNot DBNull.Value, etapasH.Item("OrigenCoordY"), Nothing)
                nuevaEtapaH.NombreCalle1Destino = IIf(etapasH.Item("NombreCalle1Destino") IsNot DBNull.Value, etapasH.Item("NombreCalle1Destino"), Nothing)
                nuevaEtapaH.NumeroOCalle2Destino = IIf(etapasH.Item("NumeroOCalle2Destino") IsNot DBNull.Value, etapasH.Item("NumeroOCalle2Destino"), Nothing)
                nuevaEtapaH.HitoDestino = IIf(etapasH.Item("HitoDestino") IsNot DBNull.Value, etapasH.Item("HitoDestino"), Nothing)
                nuevaEtapaH.DestinoCoordX = IIf(etapasH.Item("DestinoCoordX") IsNot DBNull.Value, etapasH.Item("DestinoCoordX"), Nothing)
                nuevaEtapaH.DestinoCoordY = IIf(etapasH.Item("DestinoCoordY") IsNot DBNull.Value, etapasH.Item("DestinoCoordY"), Nothing)
                nuevaEtapaH.Modo = IIf(etapasH.Item("Modo") IsNot DBNull.Value, etapasH.Item("Modo"), Nothing)
                nuevaEtapaH.CuadrasAntes = IIf(etapasH.Item("CuadrasAntes") IsNot DBNull.Value, etapasH.Item("CuadrasAntes"), Nothing)
                nuevaEtapaH.MinutosAntes = IIf(etapasH.Item("MinutosAntes") IsNot DBNull.Value, etapasH.Item("MinutosAntes"), Nothing)
                nuevaEtapaH.ViajaComo = IIf(etapasH.Item("ViajaComo") IsNot DBNull.Value, etapasH.Item("ViajaComo"), Nothing)
                nuevaEtapaH.QueVehiculo = IIf(etapasH.Item("QueVehiculo") IsNot DBNull.Value, etapasH.Item("QueVehiculo"), Nothing)
                nuevaEtapaH.IdVehiculoHogar = IIf(etapasH.Item("IdVehiculoHogar") IsNot DBNull.Value, etapasH.Item("IdVehiculoHogar"), Nothing)
                nuevaEtapaH.Autopista = IIf(etapasH.Item("Autopista") IsNot DBNull.Value, etapasH.Item("Autopista"), Nothing)
                nuevaEtapaH.DondeEstaciona = IIf(etapasH.Item("DondeEstaciona") IsNot DBNull.Value, etapasH.Item("DondeEstaciona"), Nothing)
                nuevaEtapaH.CostoEstacionamiento = IIf(etapasH.Item("CostoEstacionamiento") IsNot DBNull.Value, etapasH.Item("CostoEstacionamiento"), Nothing)
                nuevaEtapaH.CostoNSNR = IIf(etapasH.Item("CostoNSNR") IsNot DBNull.Value, etapasH.Item("CostoNSNR"), Nothing)
                nuevaEtapaH.FormaPago = IIf(etapasH.Item("FormaPago") IsNot DBNull.Value, etapasH.Item("FormaPago"), Nothing)
                nuevaEtapaH.LugarBajadaAuto = IIf(etapasH.Item("LugarBajadaAuto") IsNot DBNull.Value, etapasH.Item("LugarBajadaAuto"), Nothing)
                nuevaEtapaH.TiempoEsperaBus = IIf(etapasH.Item("TiempoEsperaBus") IsNot DBNull.Value, etapasH.Item("TiempoEsperaBus"), Nothing)
                nuevaEtapaH.TipoTarifaBus = IIf(etapasH.Item("TipoTarifaBus") IsNot DBNull.Value, etapasH.Item("TipoTarifaBus"), Nothing)
                nuevaEtapaH.TarifaBus = IIf(etapasH.Item("TarifaBus") IsNot DBNull.Value, etapasH.Item("TarifaBus"), Nothing)
                nuevaEtapaH.LugarBajadaBus = IIf(etapasH.Item("LugarBajadaBus") IsNot DBNull.Value, etapasH.Item("LugarBajadaBus"), Nothing)
                nuevaEtapaH.TiempoEsperaTxc = IIf(etapasH.Item("TiempoEsperaTxc") IsNot DBNull.Value, etapasH.Item("TiempoEsperaTxc"), Nothing)
                nuevaEtapaH.TarifaTxc = IIf(etapasH.Item("TarifaTxc") IsNot DBNull.Value, etapasH.Item("TarifaTxc"), Nothing)
                nuevaEtapaH.LugarBajadaTxc = IIf(etapasH.Item("LugarBajadaTxc") IsNot DBNull.Value, etapasH.Item("LugarBajadaTxc"), Nothing)
                nuevaEtapaH.TiempoEsperaTaxi = IIf(etapasH.Item("TiempoEsperaTaxi") IsNot DBNull.Value, etapasH.Item("TiempoEsperaTaxi"), Nothing)
                nuevaEtapaH.TarifaTaxi = IIf(etapasH.Item("TarifaTaxi") IsNot DBNull.Value, etapasH.Item("TarifaTaxi"), Nothing)
                nuevaEtapaH.LugarBajadaTaxi = IIf(etapasH.Item("LugarBajadaTaxi") IsNot DBNull.Value, etapasH.Item("LugarBajadaTaxi"), Nothing)
                nuevaEtapaH.PropiedadBicicleta = IIf(etapasH.Item("PropiedadBicicleta") IsNot DBNull.Value, etapasH.Item("PropiedadBicicleta"), Nothing)
                nuevaEtapaH.PropiedadBicicletaOtro = IIf(etapasH.Item("PropiedadBicicletaOtro") IsNot DBNull.Value, etapasH.Item("PropiedadBicicletaOtro"), Nothing)
                nuevaEtapaH.LugarBajadaBicicleta = IIf(etapasH.Item("LugarBajadaBicicleta") IsNot DBNull.Value, etapasH.Item("LugarBajadaBicicleta"), Nothing)

                Try
                    nuevaEtapaH.UsaCiclovia = IIf(etapasH.Item("UsaCiclovia") IsNot DBNull.Value, etapasH.Item("UsaCiclovia"), Nothing)
                    nuevaEtapaH.MotivoNoUsa = IIf(etapasH.Item("MotivoNoUsa") IsNot DBNull.Value, etapasH.Item("MotivoNoUsa"), Nothing)
                    nuevaEtapaH.EstacionamientoBicicleta = IIf(etapasH.Item("EstacionamientoBicicleta") IsNot DBNull.Value, etapasH.Item("EstacionamientoBicicleta"), Nothing)

                Catch ex As Exception

                End Try

                nuevaEtapaH.Operacion = IIf(etapasH.Item("Operacion") IsNot DBNull.Value, etapasH.Item("Operacion"), Nothing)
                nuevaEtapaH.HoraMod = IIf(etapasH.Item("HoraMod") IsNot DBNull.Value, etapasH.Item("HoraMod"), Nothing)

                dataset.Etapa_H.Rows.Add(nuevaEtapaH)
            End While

            etapasH.Close()
        Catch ex As Exception
            dataset.RejectChanges()
            MessageBox.Show("No se pudo restaurar las tablas de control de cambios. Error: " & ex.Message & ControlChars.Lf & ControlChars.Lf & "Pila de ejecución: " & ControlChars.Lf & ControlChars.Lf & ex.StackTrace, "Error en restauración de base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        Finally

            Dim adapterHogarH As Hogar_HTableAdapter = New Hogar_HTableAdapter
            Dim adapterVehiculoH As Vehiculo_HTableAdapter = New Vehiculo_HTableAdapter
            Dim adapterPersonaH As Persona_HTableAdapter = New Persona_HTableAdapter
            Dim adapterViajeH As Viaje_HTableAdapter = New Viaje_HTableAdapter
            Dim adapterEtapaH As Etapa_HTableAdapter = New Etapa_HTableAdapter

            adapterHogarH.Update(dataset.Hogar_H)
            adapterVehiculoH.Update(dataset.Vehiculo_H)
            adapterPersonaH.Update(dataset.Persona_H)
            adapterViajeH.Update(dataset.Viaje_H)
            adapterEtapaH.Update(dataset.Etapa_H)

            dataset.AcceptChanges()
        End Try

        dataset.AcceptChanges()
        bw.ReportProgress(95)

        'informar actualización finalizada
        bw.ReportProgress(100)
    End Sub

    Private Sub bw_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bw.RunWorkerCompleted
        If e.Cancelled Then
            MessageBox.Show("Proceso cancelado, no podrá continuar sus encuestas.", "Proceso cancelado", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf e.Error IsNot Nothing Then
            lblError.Visible = True
            imgError.Visible = True
            MessageBox.Show(e.Error.Message)
        Else
            label5.Visible = True
            img5.Visible = True
            img4.Image = DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/apply_16x16.png")
            MessageBox.Show("La restauración se ha completado con éxito. Haga clic en Aceptar para volver al programa de encuestas.", "Restauración finalizada", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Dispose()
        End If
    End Sub

    Private Sub bw_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles bw.ProgressChanged

        Select Case procedimiento
            Case 1
                label1.Visible = True
                img1.Visible = True
            Case 2
                label2.Visible = True
                img2.Visible = True
                img1.Image = DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/apply_16x16.png")
            Case 3
                label3.Visible = True
                img3.Visible = True
                img2.Image = DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/apply_16x16.png")
            Case 4
                label4.Visible = True
                img4.Visible = True
                img3.Image = DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/apply_16x16.png")
            Case 5
                label5.Visible = True
                img5.Visible = True
                img4.Image = DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/apply_16x16.png")
        End Select

        barraProg.EditValue = e.ProgressPercentage
    End Sub
End Class