Imports EOD.datasetEOD
Imports EOD.datasetEODTableAdapters
Imports DevExpress.XtraEditors

Public Class Ingresos

    Private persona As PersonaRow
    Private idHogar As Integer

    Dim dataset As New datasetEOD

    Public Sub New(ByVal idHogar As Integer, ByVal idPersona As Integer)

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

        Me.PersonaTableAdapter = New PersonaTableAdapter
        Me.PersonaTableAdapter.Fill(dataset.Persona)
        Me.persona = dataset.Persona.FindByHogarPersona(idHogar, idPersona)
        Me.idHogar = idHogar

    End Sub

    Private Sub Ingresos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TieneIngresosTableAdapter.Fill(datasetEOD.TieneIngresos)
        Me.TramoIngresoTableAdapter.Fill(datasetEOD.TramoIngreso)
        Me.SiNoTableAdapter.Fill(datasetEOD.SiNo)

        Me.lkpTieneIngreso.Focus()
    End Sub



    Private Sub chkNSNR_CheckedChanged(sender As Object, e As EventArgs) Handles chkNSNR.CheckedChanged
        Dim nsnr As Boolean = chkNSNR.Checked
        Me.lblTramoIngreso.Visible = False
        Me.lkpTramoIngreso.Visible = False

        If nsnr Then
            Me.lblTramoIngreso.Visible = True
            Me.lkpTramoIngreso.Visible = True
        End If

    End Sub

    Private Sub lkpTieneIngreso_EditValueChanged(sender As Object, e As EventArgs) Handles lkpTieneIngreso.EditValueChanged
        If Not persona Is Nothing Then
            Dim trabaja As Boolean = persona.Actividad.Contains("1")

            Me.lblIngresoLiquido.Visible = False
            Me.lblTramoIngreso.Visible = False
            Me.lkpTramoIngreso.Visible = False
            Me.txtIngresoLiquido.Visible = False
            Me.chkNSNR.Visible = False

            Dim opcion As Integer

            If lkpTieneIngreso.EditValue.ToString <> "" Then
                opcion = Convert.ToInt32(lkpTieneIngreso.EditValue.ToString)
            End If

            If opcion = 1 Then
                Me.txtIngresoLiquido.Visible = True
                Me.lblIngresoLiquido.Visible = True
                Me.chkNSNR.Visible = True
            ElseIf opcion = 2 Then
                'Validador Si trabaja debe tener ingresos
                If persona.Actividad.Contains("1") Then
                    MessageBox.Show("La persona encuestada declaró trabajar, debe tener ingresos.", "Dato inconsistente", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    lkpTieneIngreso.Focus()
                End If
            ElseIf opcion = 3 Then
                Me.lblTramoIngreso.Visible = True
                Me.lkpTramoIngreso.Visible = True
            End If
        End If
    End Sub

    Private Sub btnGuardarIngreso_Click(sender As Object, e As EventArgs) Handles btnGuardarIngreso.Click
        If Me.lkpTieneIngreso.EditValue Is Nothing OrElse Me.lkpTieneIngreso.EditValue.ToString = "" Then
            MessageBox.Show("Debe contestar esta pregunta", "Dato requerido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            lkpTieneIngreso.Focus()
        Else
            Dim tieneIngreso As Integer = Convert.ToInt32(Me.lkpTieneIngreso.EditValue.ToString)

            Select Case tieneIngreso
                Case 1
                    'Validador Dice tiene ingreso y no tiene monto ingreso
                    Dim contestaIngreso As Boolean = False

                    'Contesta tramo
                    If Not Me.lkpTramoIngreso.EditValue Is Nothing AndAlso Me.lkpTramoIngreso.EditValue.ToString <> "" Then
                        contestaIngreso = True
                    End If
                    'Contesta monto
                    If Me.txtIngresoLiquido.Text <> "" Then
                        contestaIngreso = True
                    End If
                    If Not contestaIngreso Then
                        MessageBox.Show("No ha indicado monto ni tramo de ingresos. Debe contestar para continuar.", "Dato requerido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        If chkNSNR.Checked Then
                            lkpTramoIngreso.Focus()
                        Else
                            txtIngresoLiquido.Focus()
                        End If
                    Else
                        'Grabar
                        Me.persona.TieneIngresos = tieneIngreso

                        If chkNSNR.Checked Then
                            Me.persona.TramoIngreso = Convert.ToInt32(Me.lkpTramoIngreso.EditValue)
                        Else
                            Me.persona.IngresoLiquido = Convert.ToInt32(Me.txtIngresoLiquido.Text)
                        End If
                        Me.persona.Encuestado = True
                        PersonaTableAdapter.Update(Me.dataset.Persona)
                        MessageBox.Show("Ingreso guardado correctamente. Ha finalizado la encuesta de " & persona.NombrePila & ".", "Datos guardados", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.Dispose()
                    End If
                Case 2
                    'Grabar
                    Me.persona.TieneIngresos = tieneIngreso
                    Me.persona.Encuestado = True
                    PersonaTableAdapter.Update(Me.dataset.Persona)
                    MessageBox.Show("Ha finalizado la encuesta de " & persona.NombrePila & ".", "Datos guardados", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Dispose()
                Case 3
                    'Validador Dice tiene ingreso y no tiene monto ingreso
                    Dim contestaIngreso As Boolean = False
                    'Contesta monto
                    If Me.lkpTramoIngreso.EditValue > 0 Then
                        contestaIngreso = True
                    End If
                    If Not contestaIngreso Then
                        MessageBox.Show("No ha indicado tramo de ingresos. Debe contestar para continuar.", "Dato requerido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        lkpTramoIngreso.Focus()
                    Else
                        'Grabar
                        Me.persona.TieneIngresos = tieneIngreso
                        Me.persona.TramoIngreso = Convert.ToInt32(Me.lkpTramoIngreso.EditValue)
                        Me.persona.Encuestado = True
                        PersonaTableAdapter.Update(Me.dataset.Persona)
                        MessageBox.Show("Ingreso guardado correctamente. Ha finalizado la encuesta de " & persona.NombrePila & ".", "Datos guardados", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.Dispose()
                    End If
            End Select
        End If
    End Sub

    Private Sub lkpTramoIngreso_Leave(sender As Object, e As EventArgs) Handles lkpTramoIngreso.Leave
        If Me.lkpTramoIngreso.EditValue Is Nothing OrElse Me.lkpTramoIngreso.EditValue.ToString = "" Then
            MessageBox.Show("Debe contestar esta pregunta", "Dato requerido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            lkpTramoIngreso.Focus()
        End If
    End Sub

    Private Sub lkpTieneIngreso_Enter(sender As Object, e As EventArgs) Handles lkpTieneIngreso.Enter
        BeginInvoke(New MethodInvoker(Sub() CType(sender, GridLookUpEdit).ShowPopup()))
    End Sub

    Private Sub lkpTramoIngreso_Enter(sender As Object, e As EventArgs) Handles lkpTramoIngreso.Enter
        BeginInvoke(New MethodInvoker(Sub() CType(sender, GridLookUpEdit).ShowPopup()))
    End Sub

    Private Sub btnRechazoIngresos_Click(sender As Object, e As EventArgs) Handles btnRechazoIngresos.Click
        Dim rechazarEncuesta = MessageBox.Show("Ha indicado que el hogar ha rechazado participar en la Encuesta, ¿confirma que es correcto?", "Rechazar encuesta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If rechazarEncuesta = Windows.Forms.DialogResult.Yes Then
            'Mostrar modal de confirmación con clave
            Dim ventanaRechazo As RechazoEncuesta = New RechazoEncuesta(idHogar, 5)
            ventanaRechazo.ShowDialog()
            'Cerrar nuevo hogar
            Me.Dispose()
        End If
    End Sub

    Private Sub txtIngresoLiquido_Leave(sender As Object, e As EventArgs) Handles txtIngresoLiquido.Leave
        Dim ingreso As Integer = Integer.TryParse(txtIngresoLiquido.Text, 1)

        If ingreso > 0 AndAlso ingreso < 1000 Then
            Dim confirma As DialogResult = MessageBox.Show("Ha indicado que gana menos de $1.000. ¿Confirma que es correcto?.", "Verificación de datos", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
            If confirma = Windows.Forms.DialogResult.No Then
                txtIngresoLiquido.Text = ""
                txtIngresoLiquido.Focus()
            Else
                chkNSNR.Focus()
            End If
        End If
    End Sub
End Class