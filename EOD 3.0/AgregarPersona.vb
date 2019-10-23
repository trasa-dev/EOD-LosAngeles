Imports DevExpress.XtraEditors
Imports EOD.datasetEOD
Imports System.Data.OleDb

Public Class AgregarPersona
    Private hogar As Integer
    Private idpersona As Integer
    Private persona As PersonaRow
    Private validadorPersona As ValidaPersonaRow

    Public Sub New(ByVal hogar As Integer)
        InitializeComponent()
        Me.hogar = hogar

        Me.PersonaTableAdapter.Fill(datasetEOD.Persona)

        persona = dataseteod.Persona.NewPersonaRow
        validadorPersona = dataseteod.ValidaPersona.NewValidaPersonaRow

        Dim maxPersona As PersonaRow = datasetEOD.Persona.Select("hogar = " & hogar & "and persona > 0", "persona ASC").LastOrDefault()
        If maxPersona IsNot Nothing Then
            idpersona = maxPersona.Persona + 1
        Else
            idpersona = 1
        End If

        x_trabajo.Text = "0"
        y_trabajo.Text = "0"
        x_estudio.Text = "0"
        y_estudio.Text = "0"
    End Sub

    Private Sub AgregarPersona_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'datasetEOD.TipoDiscapacidad' Puede moverla o quitarla según sea necesario.
        Me.TipoDiscapacidadTableAdapter.Fill(Me.datasetEOD.TipoDiscapacidad)
        'TODO: esta línea de código carga datos en la tabla 'datasetEOD.ConsultaCalle2Estudio' Puede moverla o quitarla según sea necesario.
        'Me.ConsultaCalle2EstudioTableAdapter.Fill(Me.datasetEOD.ConsultaCalle2Estudio)
        'TODO: esta línea de código carga datos en la tabla 'datasetEOD.ConsultaCalle2Trabajo' Puede moverla o quitarla según sea necesario.
        'Me.ConsultaCalle2TrabajoTableAdapter.Fill(Me.datasetEOD.ConsultaCalle2Trabajo)
        cargaPersonaBackground.RunWorkerAsync()
    End Sub

    Private Sub lkpEstudios_EditValueChanged(sender As Object, e As EventArgs) Handles lkpEstudios.EditValueChanged
        If txtAnoNacimiento.Text <> "" Then
            Dim opcion As Integer = Convert.ToInt32(IIf(lkpEstudios.EditValue IsNot Nothing AndAlso lkpEstudios.EditValue.ToString <> "", lkpEstudios.EditValue.ToString, 0))
            Dim edadEncuestado As Integer = DateTime.Now.Year - Convert.ToInt32(Me.txtAnoNacimiento.Text.ToString)

            Me.lblEstudiosCompletos.Visible = False
            Me.lkpEstudiosCompletos.Visible = False

            Select Case opcion
                Case 3, 4, 5
                    Me.lblEstudiosCompletos.Visible = True
                    Me.lkpEstudiosCompletos.Visible = True
                Case Else
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

    Private Sub chkActividad_EditValueChanged(sender As Object, e As EventArgs) Handles chkActividad.EditValueChanged
        If chkActividad.EditValue IsNot Nothing AndAlso chkActividad.EditValue.ToString <> "" AndAlso txtAnoNacimiento.Text <> "" Then
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
            If sinActividad AndAlso (trabaja Or estudia Or otraActividad Or jubilado) Then
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

                    'Asignar jornada completa
                    Me.lkpJornadaTrabajo.EditValue = 1
                Catch ex As Exception
                    MessageBox.Show(ex.Message + vbCrLf + vbCrLf + ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End If
    End Sub

    Private Sub btnCancelarPersona_Click(sender As Object, e As EventArgs) Handles btnCancelarPersona.Click
        Me.Dispose()
    End Sub

    Private Sub btnGuardarPersona_Click(sender As Object, e As EventArgs) Handles btnGuardarPersona.Click
        If personaCompleta() Then

            'Validador Servicio doméstico y no trabaja
            If lkpRelacion.EditValue = 6 AndAlso Not chkActividad.EditValue.Contains("1") Then
                Dim confirma As DialogResult = MessageBox.Show("Ha indicado que la persona es de Servicio doméstico pero no trabaja, ¿confirma que es correcto?", "Verificación de datos", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                If confirma = Windows.Forms.DialogResult.No Then
                    Me.lkpRelacion.Focus()
                    Return
                End If
            End If

            'Grabar persona en base de datos
            persona.Persona = Me.idpersona
            persona.Hogar = Me.hogar
            persona.NombrePila = Me.txtNombrePila.Text
            persona.AnoNac = Me.txtAnoNacimiento.Text
            persona.Sexo = Me.lkpSexo.EditValue
            persona.Relacion = Me.lkpRelacion.EditValue
            persona.Estudios = Me.lkpEstudios.EditValue
            Select Case persona.Estudios
                Case 3, 4, 5
                    persona.EstudiosCompletos = Me.lkpEstudiosCompletos.EditValue
            End Select
            If DateTime.Now.Year - persona.AnoNac >= 18 Then
                persona.LicenciaConducir = Me.lkpLicencia.EditValue
            End If
            persona.Actividad = Me.chkActividad.EditValue
            persona.ActividadOtra = Me.txtActividadOtra.Text
            persona.ViajesLab = 0
            persona.ViajesSab = 0
            persona.ViajesDom = 0
            persona.TieneIngresos = 0
            persona.Encuestado = False
            persona.NoViajaLab = -1
            persona.NoViajaSab = -1
            persona.NoViajaDom = -1
            persona.Discapacitado = IIf(Me.lkpDiscapacitado.EditValue = 1, True, False)
            If persona.Discapacitado Then
                persona.TipoDiscapacidad = Me.chkTipoDiscapacidad.EditValue
                If persona.TipoDiscapacidad.Contains("4") Then
                    persona.DiscapacidadOtra = txtDiscapacidadOtra.Text
                End If
                persona.DiscapacidadAutosuficiente = Me.lkpAutosuficiente.EditValue
            End If

            'Datos de trabajo
            If persona.Actividad.Contains("1") Then
                persona.ComunaTrabajo = lkpComunaTrabajo.EditValue
                If persona.ComunaTrabajo = 2 Then
                    If lkpCalle1Trabajo.EditValue IsNot Nothing Then
                        persona.NombreCalle1Trabajo = lkpCalle1Trabajo.EditValue.ToString
                    End If
                    If lkpCalle2Trabajo.EditValue IsNot Nothing Then
                        persona.NumeroOCalle2Trabajo = lkpCalle2Trabajo.EditValue.ToString
                    End If
                    If lkpHitoTrabajo.EditValue IsNot Nothing Then
                        persona.HitoTrabajo = lkpHitoTrabajo.EditValue.ToString
                    End If
                    If lkpManzanaTrabajo.EditValue IsNot Nothing Then
                        persona.ManzanaTrabajo = lkpManzanaTrabajo.EditValue.ToString
                    End If
                    persona.DirActividadCoordX = x_trabajo.Text
                    persona.DirActividadCoordY = y_trabajo.Text
                ElseIf persona.ComunaTrabajo = 1 Then
                    persona.ComunaTrabajoOtra = txtComunaTrabajoOtra.Text
                End If
                persona.JornadaTrabajo = lkpJornadaTrabajo.EditValue
            Else
                persona.ComunaTrabajo = -1
            End If

            'Datos de estudio
            If persona.Actividad.Contains("2") Then
                persona.ComunaEstudio = Me.lkpComunaEstudio.EditValue
                If persona.ComunaEstudio = 2 Then
                    If lkpCalle1Estudio.EditValue IsNot Nothing Then
                        persona.NombreCalle1Estudio = lkpCalle1Estudio.EditValue.ToString
                    End If
                    If lkpCalle2Estudio.EditValue IsNot Nothing Then
                        persona.NumeroOCalle2Estudio = lkpCalle2Estudio.EditValue.ToString
                    End If
                    If lkpHitoEstudio.EditValue IsNot Nothing Then
                        persona.HitoEstudio = lkpHitoEstudio.EditValue.ToString
                    End If
                    If lkpManzanaEstudio.EditValue IsNot Nothing Then
                        persona.ManzanaEstudio = lkpManzanaEstudio.EditValue.ToString
                    End If
                    persona.DirEstudiosCoordX = x_estudio.Text
                    persona.DirEstudiosCoordY = y_estudio.Text
                ElseIf persona.ComunaEstudio = 1 Then
                    persona.ComunaEstudioOtra = Me.txtComunaEstudioOtra.Text
                End If

                persona.DondeEstudia = Me.lkpDondeEstudia.EditValue
                If persona.DondeEstudia = 5 Then
                    persona.DondeEstudiaOtro = Me.txtDondeEstudiaOtro.Text
                End If
                persona.PaseEscolar = Me.lkpTieneTNE.EditValue
            Else
                persona.ComunaEstudio = -1
            End If

            Try
                validadorPersona.Hogar = persona.Hogar
                validadorPersona.Persona = persona.Persona
                datasetEOD.ValidaPersona.Rows.Add(validadorPersona)
                datasetEOD.Persona.Rows.Add(persona)

                ValidaPersonaTableAdapter.Update(datasetEOD.ValidaPersona)
                PersonaTableAdapter.Update(datasetEOD.Persona)
                MessageBox.Show("Persona agregada exitosamente", "Datos guardados", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Dispose()
            Catch ex As Exception
                MessageBox.Show("Error al agregar persona. Intente nuevamente" + vbCrLf + vbCrLf + ex.Message + vbCrLf + vbCrLf + ex.StackTrace, "Datos no guardados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            MessageBox.Show("No ha contestado las preguntas mínimas para terminar con el registro de la persona. Por favor, complete los campos marcados con rojo.", "Datos insuficientes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

    End Sub

    Private Sub cargaPersonaBackground_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles cargaPersonaBackground.DoWork
        SplashScreenManager1 = New DevExpress.XtraSplashScreen.SplashScreenManager(Me, GetType(Global.EOD.PantallaEspera), True, True)
        SplashScreenManager1.ShowWaitForm()

        Invoke(DirectCast(AddressOf Me.fillDondeEstudia, MethodInvoker))
        Invoke(DirectCast(AddressOf Me.fillJornadaTrabajo, MethodInvoker))
        Invoke(DirectCast(AddressOf Me.fillActividad, MethodInvoker))
        Invoke(DirectCast(AddressOf Me.fillEstudios, MethodInvoker))
        Invoke(DirectCast(AddressOf Me.fillRelacion, MethodInvoker))
        Invoke(DirectCast(AddressOf Me.fillSexo, MethodInvoker))
        Invoke(DirectCast(AddressOf Me.fillHito, MethodInvoker))
        Invoke(DirectCast(AddressOf Me.fillCalle1, MethodInvoker))
        Invoke(DirectCast(AddressOf Me.fillComuna, MethodInvoker))
        Invoke(DirectCast(AddressOf Me.fillSiNo, MethodInvoker))

    End Sub

    Private Sub fillComuna()
        Me.ComunaTableAdapter.Fill(Me.datasetEOD.Comuna)
    End Sub

    Private Sub fillSiNo()
        Me.SiNoTableAdapter.Fill(Me.datasetEOD.SiNo)
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

    Private Sub fillHito()
        Me.HitoTableAdapter.Fill(Me.datasetEOD.Hito)
    End Sub


    Private Sub fillCalle1()
        Me.CallesTableAdapter.Fill(Me.datasetEOD.Calles)
    End Sub

    Private Sub cargaPersonaBackground_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles cargaPersonaBackground.RunWorkerCompleted
        If SplashScreenManager1 IsNot Nothing Then
            SplashScreenManager1.CloseWaitForm()
            Me.Enabled = True
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
        End If
    End Sub

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
                If lkpEstudiosCompletos.EditValue Is Nothing OrElse lkpEstudiosCompletos.EditValue.ToString = "" OrElse lkpEstudiosCompletos.EditValue < 1 Then
                    completo = False
                    lkpEstudiosCompletos.Properties.Appearance.BorderColor = Color.Red
                Else
                    lkpEstudiosCompletos.Properties.Appearance.BorderColor = Nothing
                End If
            End If
        End If

        'Campo Discapacitado
        If lkpDiscapacitado.EditValue Is Nothing OrElse lkpDiscapacitado.EditValue.ToString = "" OrElse lkpDiscapacitado.EditValue < 0 Then
            completo = False
            lkpDiscapacitado.Properties.Appearance.BorderColor = Color.Red
        Else
            lkpDiscapacitado.Properties.Appearance.BorderColor = Nothing

            If lkpDiscapacitado.EditValue = 1 Then

                'Campo TipoDiscapacidad
                If chkTipoDiscapacidad.EditValue Is Nothing OrElse chkTipoDiscapacidad.EditValue.ToString = "" Then
                    completo = False
                    chkTipoDiscapacidad.Properties.Appearance.BorderColor = Color.Red
                Else
                    chkTipoDiscapacidad.Properties.Appearance.BorderColor = Nothing

                    If chkTipoDiscapacidad.EditValue.ToString.Contains("4") Then
                        'Campo Otra Discapacidad
                        If txtDiscapacidadOtra.Text = "" Then
                            completo = False
                            txtDiscapacidadOtra.Properties.Appearance.BorderColor = Color.Red
                        Else
                            txtDiscapacidadOtra.Properties.Appearance.BorderColor = Nothing
                        End If
                    End If
                End If

                'Campo Autosuficiente
                If lkpAutosuficiente.EditValue Is Nothing OrElse lkpAutosuficiente.EditValue.ToString = "" OrElse lkpAutosuficiente.EditValue < 0 Then
                    completo = False
                    lkpAutosuficiente.Properties.Appearance.BorderColor = Color.Red
                Else
                    lkpAutosuficiente.Properties.Appearance.BorderColor = Nothing
                End If
            End If

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
                Dim objTabla As DataTable = objDataset.Tables("Manzanastrabajo")
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
                Dim objTabla As DataTable = objDataset.Tables("Manzanasestudio")
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

    Private Sub lkpRelacion_EditValueChanged(sender As Object, e As EventArgs) Handles lkpRelacion.EditValueChanged
        If lkpRelacion.EditValue IsNot Nothing AndAlso lkpRelacion.EditValue.ToString <> "" Then
            Dim relacion As Integer = Convert.ToInt32(lkpRelacion.EditValue.ToString)
            Dim anoActual As Integer = DateTime.Now.Year
            'Dim edad As Integer = anoActual - Convert.ToInt32(txtAnoNacimiento.Text)

            'Primera persona jefe de hogar
            If idpersona = 1 AndAlso relacion > 0 Then
                MessageBox.Show("La primera persona en registrar debe ser el jefe de hogar.", "Dato no válido", MessageBoxButtons.OK, MessageBoxIcon.Error)
                lkpRelacion.EditValue = -1
                lkpRelacion.Focus()
                BeginInvoke(New MethodInvoker(Sub() CType(sender, GridLookUpEdit).ShowPopup()))
                Return
            End If

            'Jefe de hogar debe ser mayor de 16 años
            If relacion = 0 AndAlso txtAnoNacimiento.Text <> "" AndAlso (anoActual - Convert.ToInt32(txtAnoNacimiento.Text)) <= 16 Then
                Dim confirma As DialogResult = MessageBox.Show("Ha indicado que el jefe de hogar tiene menos de 16 años, ¿confirma que es correcto?", "Verificación de datos", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                If confirma = Windows.Forms.DialogResult.No Then
                    lkpRelacion.EditValue = ""
                End If
            End If

            'Debe haber sólo un jefe de hogar
            If relacion = 0 Then
                Try
                    Dim jefehogar() As PersonaRow
                    jefehogar = dataseteod.Persona.Select("hogar = " & Me.hogar & " and relacion = 0")

                    If Not jefehogar Is Nothing AndAlso jefehogar.Count > 0 Then
                        MessageBox.Show("Ya ha registrado un jefe de hogar.", "Dato no válido", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        lkpRelacion.EditValue = -1
                        lkpRelacion.Focus()
                    End If
                Catch ex As Exception
                End Try
            End If

            'Debe tener solo un cónyuge
            If relacion = 1 Then
                Dim conyuge() As datasetEOD.PersonaRow
                conyuge = Me.datasetEOD.Persona.Select("hogar = " & Me.hogar & " and relacion = 1")

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


            'Diferencia edad padres e hijo menor a 12 años
            If relacion = 2 Then
                'jefe hogar
                Try
                    Dim jefeHogar As datasetEOD.PersonaRow
                    jefeHogar = Me.datasetEOD.Persona.Select("hogar = " & Me.hogar & " and relacion = 0")(0)
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
                        Dim confirma As DialogResult = MessageBox.Show(textoAlerta, "Verificación de datos", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                        If confirma = Windows.Forms.DialogResult.No Then
                            txtAnoNacimiento.Text = ""
                            txtAnoNacimiento.Focus()
                        End If
                    End If

                Catch ex As Exception
                End Try

                'cónyuge
                Try
                    Dim conyuge As datasetEOD.PersonaRow
                    conyuge = Me.datasetEOD.Persona.Select("hogar = " & Me.hogar & " and relacion = 1")(0)
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
                        Dim confirma As DialogResult = MessageBox.Show(textoAlerta, "Verificación de datos", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                        If confirma = Windows.Forms.DialogResult.No Then
                            txtAnoNacimiento.Text = ""
                            txtAnoNacimiento.Focus()
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

            'Estudios superiores y lugar inferior a preuniversitario
            If (lugarEstudios < 4) AndAlso nivelEstudios = 5 Then
                MessageBox.Show("Indicó un valor inconsistente con el nivel de estudios.", "Dato no válido", MessageBoxButtons.OK, MessageBoxIcon.Error)
                lkpDondeEstudia.EditValue = ""
            End If

            'Estudia en universidad/instituto y no tiene estudios universitarios o técnico profesionales
            If lugarEstudios = 4 AndAlso (nivelEstudios <> 6 AndAlso nivelEstudios <> 5) Then
                MessageBox.Show("Indicó un valor inconsistente con el nivel de estudios.", "Dato no válido", MessageBoxButtons.OK, MessageBoxIcon.Error)
                lkpDondeEstudia.EditValue = ""
            End If

            'Preuniversitario y tiene estudios primarios o superiores
            If (lugarEstudios = 3) AndAlso (nivelEstudios = 3 OrElse nivelEstudios = 5) Then
                MessageBox.Show("Indicó un valor inconsistente con el nivel de estudios.", "Dato no válido", MessageBoxButtons.OK, MessageBoxIcon.Error)
                lkpDondeEstudia.EditValue = ""
            End If
        End If
    End Sub

    Private Sub chkActividad_Enter(sender As Object, e As EventArgs) Handles chkActividad.Enter
        BeginInvoke(New MethodInvoker(Sub() CType(sender, CheckedComboBoxEdit).ShowPopup()))
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

    Private Sub lkpComunaTrabajo_Enter(sender As Object, e As EventArgs) Handles lkpComunaTrabajo.Enter
        BeginInvoke(New MethodInvoker(Sub() CType(sender, GridLookUpEdit).ShowPopup()))
    End Sub

    Private Sub lkpJornadaTrabajo_Enter(sender As Object, e As EventArgs) Handles lkpJornadaTrabajo.Enter
        BeginInvoke(New MethodInvoker(Sub() CType(sender, GridLookUpEdit).ShowPopup()))
    End Sub

    Private Sub lkpComunaEstudio_Enter(sender As Object, e As EventArgs) Handles lkpComunaEstudio.Enter
        BeginInvoke(New MethodInvoker(Sub() CType(sender, GridLookUpEdit).ShowPopup()))
    End Sub

    Private Sub lkpDondeEstudia_Enter(sender As Object, e As EventArgs) Handles lkpDondeEstudia.Enter
        BeginInvoke(New MethodInvoker(Sub() CType(sender, GridLookUpEdit).ShowPopup()))
    End Sub

    Private Sub lkpTieneTNE_Enter(sender As Object, e As EventArgs) Handles lkpTieneTNE.Enter
        BeginInvoke(New MethodInvoker(Sub() CType(sender, GridLookUpEdit).ShowPopup()))
    End Sub

    Private Sub lkpEstudiosCompletos_EditValueChanged(sender As Object, e As EventArgs) Handles lkpEstudiosCompletos.EditValueChanged
        If txtAnoNacimiento.Text <> "" AndAlso lkpEstudios.EditValue IsNot Nothing Then
            Dim nivelEstudios As Integer = Convert.ToInt32(IIf(lkpEstudios.EditValue.ToString <> "", lkpEstudios.EditValue.ToString, 0))
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

    Private Sub txtAnoNacimiento_Leave(sender As Object, e As EventArgs) Handles txtAnoNacimiento.Leave
        If txtAnoNacimiento.Text <> "" Then
            Me.lkpLicencia.Visible = True
            Me.lblLicencia.Visible = True

            Dim anoNacimiento As Integer = Convert.ToInt32(txtAnoNacimiento.Text)
            Dim anoActual As Integer = DateTime.Today.Year
            Dim edadCalculada = anoActual - anoNacimiento

            If edadCalculada < 0 Then
                MessageBox.Show("El año de nacimiento no puede ser mayor que el actual. Corrija el dato para continuar.", "Inconsistencia en edad", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtAnoNacimiento.Text = ""
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
                        Dim objTabla As DataTable = objDataset.Tables("ManzanaAutoE2")
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
                        Dim objTabla As DataTable = objDataset.Tables("ManzanaAutoE2")
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
                btnGuardarPersona.Focus()
            End If
        End If

    End Sub

    Private Sub LkpDiscapacitado_EditValueChanged(sender As Object, e As EventArgs) Handles lkpDiscapacitado.EditValueChanged
        Dim opcion As Integer

        If lkpDiscapacitado.EditValue IsNot Nothing AndAlso lkpDiscapacitado.EditValue.ToString <> "" Then
            opcion = lkpDiscapacitado.EditValue
        End If

        lblAutosuficiente.Visible = False
        lblTipoDiscapacidad.Visible = False
        lkpAutosuficiente.Visible = False
        chkTipoDiscapacidad.Visible = False

        If opcion = 1 Then
            lblAutosuficiente.Visible = True
            lblTipoDiscapacidad.Visible = True
            lkpAutosuficiente.Visible = True
            chkTipoDiscapacidad.Visible = True
        End If
    End Sub

    Private Sub ChkTipoDiscapacidad_EditValueChanged(sender As Object, e As EventArgs) Handles chkTipoDiscapacidad.EditValueChanged
        If chkTipoDiscapacidad.EditValue IsNot Nothing AndAlso chkTipoDiscapacidad.EditValue.ToString.Contains("4") Then
            spDiscapacidadOtra.Collapsed = False
            txtDiscapacidadOtra.Visible = True
        Else
            spDiscapacidadOtra.Collapsed = True
            txtDiscapacidadOtra.Visible = False
        End If
    End Sub
End Class