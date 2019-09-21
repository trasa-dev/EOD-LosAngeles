Imports EOD.datasetEOD

Public Class CopiarViajes

    Dim hogar As Integer
    Dim persona As Integer
    Dim tipoEncuesta As Integer

    Public Sub New(ByVal hogar As Integer, ByVal persona As Integer, ByVal tipoEncuesta As Integer)
        InitializeComponent()
        Me.hogar = hogar
        Me.persona = persona
        Me.tipoEncuesta = tipoEncuesta
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Dispose()
    End Sub

    Private Sub CopiarViajes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.PersonaTableAdapter.Fill(Me.datasetEOD.Persona)
        ViajeTableAdapter.Fill(Me.datasetEOD.Viaje)
        EtapaTableAdapter.Fill(Me.datasetEOD.Etapa)
        ValidaViajeTableAdapter.Fill(Me.datasetEOD.ValidaViaje)
        ValidaEtapaTableAdapter.Fill(Me.datasetEOD.ValidaEtapa)

        PersonaBindingSource.Filter = "hogar = " & hogar & " and persona <> " & persona
        If Me.tipoEncuesta = 4 Then
            Me.selTipoDia.Enabled = True
            Me.selTipoDia.EditValue = 1
        Else
            Me.selTipoDia.EditValue = Me.tipoEncuesta
        End If
    End Sub

    Private Sub btnCopiar_Click(sender As Object, e As EventArgs) Handles btnCopiar.Click
        barraProg.Visible = True

        Dim personaOrigen As Integer = Me.lkpPersonaOrigen.EditValue

        

        Dim filaPersona As PersonaRow = datasetEOD.Persona.FindByHogarPersona(Me.hogar, Me.persona)
        Dim viajesCopiar() As ViajeRow = datasetEOD.Viaje.Select("hogar = " & Me.hogar & " and persona = " & personaOrigen & " and diaViaje = " & Me.selTipoDia.EditValue)
        Dim etapasCopiar() As EtapaRow = datasetEOD.Etapa.Select("hogar = " & Me.hogar & " and persona = " & personaOrigen & " and diaViaje = " & Me.selTipoDia.EditValue)

        Dim validaViajes() As ValidaViajeRow = datasetEOD.ValidaViaje.Select("hogar = " & Me.hogar & " and persona = " & personaOrigen & " and diaViaje = " & Me.selTipoDia.EditValue)
        Dim validaEtapas() As ValidaEtapaRow = datasetEOD.ValidaEtapa.Select("hogar = " & Me.hogar & " and persona = " & personaOrigen & " and diaViaje = " & Me.selTipoDia.EditValue)

        Dim tieneViajes As Boolean = False
        Dim noViaja As Boolean = False
        Dim copiar = True

        'Revisar si persona destino ya tiene viajes el día seleccionado
        Select Case Integer.Parse(Me.selTipoDia.EditValue.ToString)
            Case 1
                If filaPersona.ViajesLab > 0 Then
                    tieneViajes = True
                End If
            Case 2
                If filaPersona.ViajesSab > 0 Then
                    tieneViajes = True
                End If
            Case 3
                If filaPersona.ViajesDom > 0 Then
                    tieneViajes = True
                End If
        End Select

        'Revisar si persona destino indicó no viaja el día seleccionado
        Select Case Integer.Parse(Me.selTipoDia.EditValue.ToString)
            Case 1
                If filaPersona.NoViajaLab > 0 Then
                    noViaja = True
                End If
            Case 2
                If filaPersona.NoViajaSab > 0 Then
                    noViaja = True
                End If
            Case 3
                If filaPersona.NoViajaDom > 0 Then
                    noViaja = True
                End If
        End Select

        If tieneViajes Then
            Dim respuesta As DialogResult = MessageBox.Show("Esta persona ya tiene viajes registrado el día seleccionado, ¿está seguro de querer borrarlos y copiar los viajes de " + Me.lkpPersonaOrigen.Text + "?", "Persona ya encuestada", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If respuesta = Windows.Forms.DialogResult.No Then
                copiar = False
            End If
        ElseIf noViaja Then
            Dim respuesta As DialogResult = MessageBox.Show("Esta persona ya indicó que el día seleccionado no realizó ningún viaje, ¿está seguro de copiar los viajes de " + Me.lkpPersonaOrigen.Text + "?", "Persona ya encuestada", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If respuesta = Windows.Forms.DialogResult.No Then
                copiar = False
            End If
        End If

        If copiar Then
            'Copiar tabla viaje
            For Each viaje As ViajeRow In viajesCopiar
                Dim viajeNuevo As ViajeRow = datasetEOD.Viaje.NewViajeRow
                viajeNuevo.Hogar = viaje.Hogar
                viajeNuevo.Persona = Me.persona
                viajeNuevo.Viaje = viaje.Viaje
                viajeNuevo.DiaViaje = viaje.DiaViaje
                viajeNuevo.Etapas = viaje.Etapas
                viajeNuevo.ComunaOrigen = viaje.ComunaOrigen
                If Not viaje.IsComunaOtraOrigenNull Then
                    viajeNuevo.ComunaOtraOrigen = viaje.ComunaOtraOrigen
                End If
                If Not viaje.IsZonaOrigenNull Then
                    viajeNuevo.ZonaOrigen = viaje.ZonaOrigen
                End If
                If Not viaje.IsManzanaOrigenNull Then
                    viajeNuevo.ManzanaOrigen = viaje.ManzanaOrigen
                End If
                If Not viaje.IsNombreCalle1OrigenNull Then
                    viajeNuevo.NombreCalle1Origen = viaje.NombreCalle1Origen
                End If
                If Not viaje.IsNumeroOCalle2OrigenNull Then
                    viajeNuevo.NumeroOCalle2Origen = viaje.NumeroOCalle2Origen
                End If
                If Not viaje.IsHitoOrigenNull Then
                    viajeNuevo.HitoOrigen = viaje.HitoOrigen
                End If
                If Not viaje.IsOrigenCoordXNull Then
                    viajeNuevo.OrigenCoordX = viaje.OrigenCoordX
                End If
                If Not viaje.IsOrigenCoordYNull Then
                    viajeNuevo.OrigenCoordY = viaje.OrigenCoordY
                End If

                viajeNuevo.ComunaDestino = viaje.ComunaDestino

                If Not viaje.IsComunaOtraDestinoNull Then
                    viajeNuevo.ComunaOtraDestino = viaje.ComunaOtraDestino
                End If
                If Not viaje.IsZonaDestinoNull Then
                    viajeNuevo.ZonaDestino = viaje.ZonaDestino
                End If
                If Not viaje.IsManzanaDestinoNull Then
                    viajeNuevo.ManzanaDestino = viaje.ManzanaDestino
                End If
                If Not viaje.IsNombreCalle1DestinoNull Then
                    viajeNuevo.NombreCalle1Destino = viaje.NombreCalle1Destino
                End If
                If Not viaje.IsNumeroOCalle2DestinoNull Then
                    viajeNuevo.NumeroOCalle2Destino = viaje.NumeroOCalle2Destino
                End If
                If Not viaje.IsHitoDestinoNull Then
                    viajeNuevo.HitoDestino = viaje.HitoDestino
                End If
                If Not viaje.IsDestinoCoordXNull Then
                    viajeNuevo.DestinoCoordX = viaje.DestinoCoordX
                End If
                If Not viaje.IsDestinoCoordYNull Then
                    viajeNuevo.DestinoCoordY = viaje.DestinoCoordY
                End If

                If Not viaje.IsTrabajoDeclaradoNull Then
                    viajeNuevo.TrabajoDeclarado = viaje.TrabajoDeclarado
                End If
                If Not viaje.IsEstudioDeclaradoNull Then
                    viajeNuevo.EstudioDeclarado = viaje.EstudioDeclarado
                End If

                viajeNuevo.Proposito = viaje.Proposito
                If Not viaje.IsPropositoOtroNull Then
                    viajeNuevo.PropositoOtro = viaje.PropositoOtro
                End If

                viajeNuevo.HoraIni = viaje.HoraIni
                viajeNuevo.Horafin = viaje.Horafin
                viajeNuevo.Trasnoche = viaje.Trasnoche
                viajeNuevo.CuadrasDespues = viaje.CuadrasDespues
                viajeNuevo.MinutosDespues = viaje.MinutosDespues

                datasetEOD.Viaje.Rows.Add(viajeNuevo)
            Next

            Dim countViaje As Integer = Me.ViajeTableAdapter.Update(Me.datasetEOD.Viaje)
            Me.ViajeTableAdapter.Fill(Me.datasetEOD.Viaje)

            'Copiar tabla etapa
            For Each etapa As EtapaRow In etapasCopiar
                Dim etapaNueva As EtapaRow = datasetEOD.Etapa.NewEtapaRow
                etapaNueva.Hogar = etapa.Hogar
                etapaNueva.Persona = Me.persona
                etapaNueva.Viaje = etapa.Viaje
                etapaNueva.DiaViaje = etapa.DiaViaje
                etapaNueva.Etapa = etapa.Etapa
                
                If Not etapa.IsComunaOtraOrigenNull Then
                    etapaNueva.ComunaOtraOrigen = etapa.ComunaOtraOrigen
                End If
                If Not etapa.IsZonaOrigenNull Then
                    etapaNueva.ZonaOrigen = etapa.ZonaOrigen
                End If
                If Not etapa.IsManzanaOrigenNull Then
                    etapaNueva.ManzanaOrigen = etapa.ManzanaOrigen
                End If
                If Not etapa.IsNombreCalle1OrigenNull Then
                    etapaNueva.NombreCalle1Origen = etapa.NombreCalle1Origen
                End If
                If Not etapa.IsNumeroOCalle2OrigenNull Then
                    etapaNueva.NumeroOCalle2Origen = etapa.NumeroOCalle2Origen
                End If
                If Not etapa.IsHitoOrigenNull Then
                    etapaNueva.HitoOrigen = etapa.HitoOrigen
                End If
                If Not etapa.IsOrigenCoordXNull Then
                    etapaNueva.OrigenCoordX = etapa.OrigenCoordX
                End If
                If Not etapa.IsOrigenCoordYNull Then
                    etapaNueva.OrigenCoordY = etapa.OrigenCoordY
                End If

                etapaNueva.ComunaDestino = etapa.ComunaDestino

                If Not etapa.IsComunaOtraDestinoNull Then
                    etapaNueva.ComunaOtraDestino = etapa.ComunaOtraDestino
                End If
                If Not etapa.IsZonaDestinoNull Then
                    etapaNueva.ZonaDestino = etapa.ZonaDestino
                End If
                If Not etapa.IsManzanaDestinoNull Then
                    etapaNueva.ManzanaDestino = etapa.ManzanaDestino
                End If
                If Not etapa.IsNombreCalle1DestinoNull Then
                    etapaNueva.NombreCalle1Destino = etapa.NombreCalle1Destino
                End If
                If Not etapa.IsNumeroOCalle2DestinoNull Then
                    etapaNueva.NumeroOCalle2Destino = etapa.NumeroOCalle2Destino
                End If
                If Not etapa.IsHitoDestinoNull Then
                    etapaNueva.HitoDestino = etapa.HitoDestino
                End If
                If Not etapa.IsDestinoCoordXNull Then
                    etapaNueva.DestinoCoordX = etapa.DestinoCoordX
                End If
                If Not etapa.IsDestinoCoordYNull Then
                    etapaNueva.DestinoCoordY = etapa.DestinoCoordY
                End If

                etapaNueva.Modo = etapa.Modo
                If Not etapa.IsCuadrasAntesNull Then
                    etapaNueva.CuadrasAntes = etapa.CuadrasAntes
                End If
                If Not etapa.IsMinutosAntesNull Then
                    etapaNueva.MinutosAntes = etapa.MinutosAntes
                End If
                If Not etapa.IsViajaComoNull Then
                    etapaNueva.ViajaComo = etapa.ViajaComo
                End If
                If Not etapa.IsQueVehiculoNull Then
                    etapaNueva.QueVehiculo = etapa.QueVehiculo
                End If
                If Not etapa.IsIdVehiculoHogarNull Then
                    etapaNueva.IdVehiculoHogar = etapa.IdVehiculoHogar
                End If
                If Not etapa.IsPagaEstacionamientoNull Then
                    etapaNueva.PagaEstacionamiento = etapa.PagaEstacionamiento
                End If
                If Not etapa.IsCostoEstacionamientoNull Then
                    etapaNueva.CostoEstacionamiento = etapa.CostoEstacionamiento
                End If
                etapaNueva.CostoNSNR = etapa.CostoNSNR
                If Not etapa.IsFormaPagoNull Then
                    etapaNueva.FormaPago = etapa.FormaPago
                End If
                If Not etapa.IsLugarDondeBajoNull Then
                    etapaNueva.LugarDondeBajo = etapa.LugarDondeBajo
                End If
                If Not etapa.IsTiempoEsperaBusNull Then
                    etapaNueva.TiempoEsperaBus = etapa.TiempoEsperaBus
                    etapaNueva.TipoTarifaBus = etapa.TipoTarifaBus
                    If Not etapa.IsTarifaBusNull Then
                        etapaNueva.TarifaBus = etapa.TarifaBus
                    End If
                    etapaNueva.LugarBajadaBus = etapa.LugarBajadaBus
                End If
                If Not etapa.IsTiempoEsperaTxcNull Then
                    etapaNueva.TiempoEsperaTxc = etapa.TiempoEsperaTxc
                    etapaNueva.TarifaTxc = etapa.TarifaTxc
                    etapaNueva.LugarBajadaTxc = etapa.LugarBajadaTxc
                End If
                If Not etapa.IsTiempoEsperaTaxiNull Then
                    etapaNueva.TiempoEsperaTaxi = etapa.TiempoEsperaTaxi
                    etapaNueva.TarifaTaxi = etapa.TarifaTaxi
                    etapaNueva.LugarBajadaTaxi = etapa.LugarBajadaTaxi
                End If
                If Not etapa.IsPropiedadBicicletaNull Then
                    etapaNueva.PropiedadBicicleta = etapa.PropiedadBicicleta
                    If Not etapa.IsPropiedadBicicletaOtroNull Then
                        etapaNueva.PropiedadBicicletaOtro = etapa.PropiedadBicicletaOtro
                    End If
                    etapaNueva.UsaCiclovia = etapa.UsaCiclovia
                    etapaNueva.LugarBajadaBicicleta = etapa.LugarBajadaBicicleta
                End If

                If Not etapa.IsMinutosEsperaBarcazaNull Then
                    etapaNueva.MinutosEsperaBarcaza = etapa.MinutosEsperaBarcaza
                    etapaNueva.TarifaBarcaza = etapa.TarifaBarcaza
                    etapaNueva.MuelleSubidaBarcaza = etapa.MuelleSubidaBarcaza
                    etapaNueva.MuelleBajadaBarcaza = etapa.MuelleBajadaBarcaza
                End If

                datasetEOD.Etapa.Rows.Add(etapaNueva)
            Next

            Dim countEtapa As Integer = Me.EtapaTableAdapter.Update(Me.datasetEOD.Etapa)
            Me.EtapaTableAdapter.Fill(Me.datasetEOD.Etapa)

            'Copiar tabla valida viaje
            For Each viaje As ValidaViajeRow In validaViajes
                Dim viajeNuevo As ValidaViajeRow = datasetEOD.ValidaViaje.NewValidaViajeRow
                viajeNuevo.Hogar = viaje.Hogar
                viajeNuevo.Persona = Me.persona
                viajeNuevo.Viaje = viaje.Viaje
                viajeNuevo.DiaViaje = viaje.DiaViaje
                If Not viaje.IsVal3Null Then
                    viajeNuevo.Val3 = viaje.Val3
                End If
                If Not viaje.IsVal3RespNull Then
                    viajeNuevo.Val3Resp = viaje.Val3Resp
                End If
                If Not viaje.IsVal3ObsNull Then
                    viajeNuevo.Val3Obs = viaje.Val3Obs
                End If

                If Not viaje.IsVal6Null Then
                    viajeNuevo.Val6 = viaje.Val6
                End If
                If Not viaje.IsVal6RespNull Then
                    viajeNuevo.Val6Resp = viaje.Val6Resp
                End If
                If Not viaje.IsVal6ObsNull Then
                    viajeNuevo.Val6Obs = viaje.Val6Obs
                End If

                If Not viaje.IsVal7Null Then
                    viajeNuevo.Val7 = viaje.Val7
                End If
                If Not viaje.IsVal7RespNull Then
                    viajeNuevo.Val7Resp = viaje.Val7Resp
                End If
                If Not viaje.IsVal7ObsNull Then
                    viajeNuevo.Val7Obs = viaje.Val7Obs
                End If

                If Not viaje.IsVal8Null Then
                    viajeNuevo.Val8 = viaje.Val8
                End If
                If Not viaje.IsVal8RespNull Then
                    viajeNuevo.Val8Resp = viaje.Val8Resp
                End If
                If Not viaje.IsVal8ObsNull Then
                    viajeNuevo.Val8Obs = viaje.Val8Obs
                End If

                If Not viaje.IsVal9Null Then
                    viajeNuevo.Val9 = viaje.Val9
                End If
                If Not viaje.IsVal9RespNull Then
                    viajeNuevo.Val9Resp = viaje.Val9Resp
                End If
                If Not viaje.IsVal9ObsNull Then
                    viajeNuevo.Val9Obs = viaje.Val9Obs
                End If

                If Not viaje.IsVal15Null Then
                    viajeNuevo.Val15 = viaje.Val15
                End If
                If Not viaje.IsVal15RespNull Then
                    viajeNuevo.Val15Resp = viaje.Val15Resp
                End If
                If Not viaje.IsVal15ObsNull Then
                    viajeNuevo.Val15Obs = viaje.Val15Obs
                End If

                datasetEOD.ValidaViaje.Rows.Add(viajeNuevo)
            Next

            Me.ValidaViajeTableAdapter.Update(Me.datasetEOD.ValidaViaje)
            Me.ValidaViajeTableAdapter.Fill(Me.datasetEOD.ValidaViaje)

            'Copiar tabla valida etapa
            For Each etapa As ValidaEtapaRow In validaEtapas
                Dim etapaNueva As ValidaEtapaRow = datasetEOD.ValidaEtapa.NewValidaEtapaRow
                etapaNueva.Hogar = etapa.Hogar
                etapaNueva.Persona = Me.persona
                etapaNueva.Viaje = etapa.Viaje
                etapaNueva.DiaViaje = etapa.DiaViaje
                etapaNueva.Etapa = etapa.Etapa
                
                If Not etapa.IsVal1Null Then
                    etapaNueva.Val1 = etapa.Val1
                End If
                If Not etapa.IsVal1RespNull Then
                    etapaNueva.Val1Resp = etapa.Val1Resp
                End If
                If Not etapa.IsVal1ObsNull Then
                    etapaNueva.Val1Obs = etapa.Val1Obs
                End If

                If Not etapa.IsVal2Null Then
                    etapaNueva.Val2 = etapa.Val2
                End If
                If Not etapa.IsVal2RespNull Then
                    etapaNueva.Val2Resp = etapa.Val2Resp
                End If
                If Not etapa.IsVal2ObsNull Then
                    etapaNueva.Val2Obs = etapa.Val2Obs
                End If

                If Not etapa.IsVal3Null Then
                    etapaNueva.Val3 = etapa.Val3
                End If
                If Not etapa.IsVal3RespNull Then
                    etapaNueva.Val3Resp = etapa.Val3Resp
                End If
                If Not etapa.IsVal3ObsNull Then
                    etapaNueva.Val3Obs = etapa.Val3Obs
                End If

                If Not etapa.IsVal4Null Then
                    etapaNueva.Val4 = etapa.Val4
                End If
                If Not etapa.IsVal4RespNull Then
                    etapaNueva.Val4Resp = etapa.Val4Resp
                End If
                If Not etapa.IsVal4ObsNull Then
                    etapaNueva.Val4Obs = etapa.Val4Obs
                End If

                If Not etapa.IsVal5Null Then
                    etapaNueva.Val5 = etapa.Val5
                End If
                If Not etapa.IsVal5RespNull Then
                    etapaNueva.Val5Resp = etapa.Val5Resp
                End If
                If Not etapa.IsVal5ObsNull Then
                    etapaNueva.Val5Obs = etapa.Val5Obs
                End If

                If Not etapa.IsVal7Null Then
                    etapaNueva.Val7 = etapa.Val7
                End If
                If Not etapa.IsVal7RespNull Then
                    etapaNueva.Val7Resp = etapa.Val7Resp
                End If
                If Not etapa.IsVal7ObsNull Then
                    etapaNueva.Val7Obs = etapa.Val7Obs
                End If

                If Not etapa.IsVal8Null Then
                    etapaNueva.Val8 = etapa.Val8
                End If
                If Not etapa.IsVal8RespNull Then
                    etapaNueva.Val8Resp = etapa.Val8Resp
                End If
                If Not etapa.IsVal8ObsNull Then
                    etapaNueva.Val8Obs = etapa.Val8Obs
                End If

                If Not etapa.IsVal9Null Then
                    etapaNueva.Val9 = etapa.Val9
                End If
                If Not etapa.IsVal9RespNull Then
                    etapaNueva.Val9Resp = etapa.Val9Resp
                End If
                If Not etapa.IsVal9ObsNull Then
                    etapaNueva.Val9Obs = etapa.Val9Obs
                End If

                If Not etapa.IsVal10Null Then
                    etapaNueva.Val10 = etapa.Val10
                End If
                If Not etapa.IsVal10RespNull Then
                    etapaNueva.Val10Resp = etapa.Val10Resp
                End If
                If Not etapa.IsVal10ObsNull Then
                    etapaNueva.Val10Obs = etapa.Val10Obs
                End If

                If Not etapa.IsVal11Null Then
                    etapaNueva.Val11 = etapa.Val11
                End If
                If Not etapa.IsVal11RespNull Then
                    etapaNueva.Val11Resp = etapa.Val11Resp
                End If
                If Not etapa.IsVal11ObsNull Then
                    etapaNueva.Val11Obs = etapa.Val11Obs
                End If

                If Not etapa.IsVal12Null Then
                    etapaNueva.Val12 = etapa.Val12
                End If
                If Not etapa.IsVal12RespNull Then
                    etapaNueva.Val12Resp = etapa.Val12Resp
                End If
                If Not etapa.IsVal12ObsNull Then
                    etapaNueva.Val12Obs = etapa.Val12Obs
                End If

                If Not etapa.IsVal13Null Then
                    etapaNueva.Val13 = etapa.Val13
                End If
                If Not etapa.IsVal13RespNull Then
                    etapaNueva.Val13Resp = etapa.Val13Resp
                End If
                If Not etapa.IsVal13ObsNull Then
                    etapaNueva.Val13Obs = etapa.Val13Obs
                End If

                If Not etapa.IsVal14Null Then
                    etapaNueva.Val14 = etapa.Val14
                End If
                If Not etapa.IsVal14RespNull Then
                    etapaNueva.Val14Resp = etapa.Val14Resp
                End If
                If Not etapa.IsVal14ObsNull Then
                    etapaNueva.Val14Obs = etapa.Val14Obs
                End If

                If Not etapa.IsVal16Null Then
                    etapaNueva.Val16 = etapa.Val16
                End If
                If Not etapa.IsVal16RespNull Then
                    etapaNueva.Val16Resp = etapa.Val16Resp
                End If
                If Not etapa.IsVal16ObsNull Then
                    etapaNueva.Val16Obs = etapa.Val16Obs
                End If

                If Not etapa.IsVal17Null Then
                    etapaNueva.Val17 = etapa.Val17
                End If
                If Not etapa.IsVal17RespNull Then
                    etapaNueva.Val17Resp = etapa.Val17Resp
                End If
                If Not etapa.IsVal17ObsNull Then
                    etapaNueva.Val17Obs = etapa.Val17Obs
                End If

                If Not etapa.IsVal18Null Then
                    etapaNueva.Val18 = etapa.Val18
                End If
                If Not etapa.IsVal18RespNull Then
                    etapaNueva.Val18Resp = etapa.Val18Resp
                End If
                If Not etapa.IsVal18ObsNull Then
                    etapaNueva.Val18Obs = etapa.Val18Obs
                End If

                If Not etapa.IsVal19Null Then
                    etapaNueva.Val19 = etapa.Val19
                End If
                If Not etapa.IsVal19RespNull Then
                    etapaNueva.Val19Resp = etapa.Val19Resp
                End If
                If Not etapa.IsVal19ObsNull Then
                    etapaNueva.Val19Obs = etapa.Val19Obs
                End If

                datasetEOD.ValidaEtapa.Rows.Add(etapaNueva)
            Next

            Me.ValidaEtapaTableAdapter.Update(Me.datasetEOD.ValidaEtapa)
            Me.ValidaEtapaTableAdapter.Fill(Me.datasetEOD.ValidaEtapa)

            Select Case selTipoDia.EditValue
                Case 1
                    filaPersona.ViajesLab = viajesCopiar.Count
                    filaPersona.EncuestadoLab = True
                Case 2
                    filaPersona.ViajesSab = viajesCopiar.Count
                    filaPersona.EncuestadoSab = True
                Case 3
                    filaPersona.ViajesDom = viajesCopiar.Count
                    filaPersona.EncuestadoDom = True
            End Select

            PersonaTableAdapter.Update(Me.datasetEOD.Persona)
            PersonaTableAdapter.Fill(Me.datasetEOD.Persona)

            'Alertar cambiar propósito y modos si procede
            barraProg.Visible = False
            MessageBox.Show("Los viajes fueron copiados correctamente. Por favor, recuerde verificar los siguientes datos en los viajes copiados: " + vbCrLf + vbCrLf + "- Propósito del viaje" + vbCrLf + "- Modos de transporte del viaje (conductor/pasajero)", "Viajes copiados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Dispose()

        End If

    End Sub
End Class