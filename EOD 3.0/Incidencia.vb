Imports EOD.datasetEOD
Imports EOD.datasetEODTableAdapters

Public Class Incidencia

    Dim hogar As Integer
    Dim persona As Integer
    Dim diaViaje As Integer
    Dim viaje As Integer

    Dim modoEdicion As Boolean = False

    Dim incidencia As IncidenciaRow

    Public Sub New(ByVal hogar As Integer, ByVal persona As Integer, ByVal diaViaje As Integer, ByVal viaje As Integer)
        InitializeComponent()
        Me.hogar = hogar
        Me.persona = persona
        Me.diaViaje = diaViaje
        Me.viaje = viaje
    End Sub

    Private Sub Incidencia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DatasetEOD.TipoIncidencia' Puede moverla o quitarla según sea necesario.
        Me.TipoIncidenciaTableAdapter.Fill(Me.datasetEOD.TipoIncidencia)

        Try
            incidencia = datasetEOD.Incidencia.FindByDiaViajeHogarPersonaViaje(diaViaje, hogar, persona, viaje)
            If incidencia IsNot Nothing Then
                modoEdicion = True
                lkpTipoIncidencia.EditValue = incidencia.IDTipoIncidencia
                txtDescripcion.Text = incidencia.Descripcion
            Else
                incidencia = datasetEOD.Incidencia.NewIncidenciaRow
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        If incidenciaCompleta() Then

            If Not modoEdicion Then
                incidencia.Hogar = Me.hogar
                incidencia.Persona = Me.persona
                incidencia.Viaje = Me.viaje
                incidencia.DiaViaje = Me.diaViaje
            End If

            incidencia.FechaReporte = New Date()
            incidencia.Descripcion = Me.txtDescripcion.Text
            incidencia.IDTipoIncidencia = Me.lkpTipoIncidencia.EditValue

            IncidenciaTableAdapter.Update(Me.datasetEOD.Incidencia)
            IncidenciaTableAdapter.Fill(Me.datasetEOD.Incidencia)

            MessageBox.Show("Incidencia guardada correctamente.", "Datos guardados", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Por favor, complete los campos marcados con rojo para grabar la incidencia.", "Datos insuficientes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
        

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Dispose()
    End Sub

    Private Function incidenciaCompleta() As Boolean
        Dim completa As Boolean = True

        'Campo Tipo Incidencia
        If lkpTipoIncidencia.EditValue Is Nothing OrElse lkpTipoIncidencia.EditValue.ToString = "" Then
            completa = False
            lkpTipoIncidencia.Properties.Appearance.BorderColor = Color.Red
        Else
            lkpTipoIncidencia.Properties.Appearance.BorderColor = Nothing
        End If

        'Campo Otro motivo
        If txtDescripcion.Text = "" Then
            completa = False
            txtDescripcion.Properties.Appearance.BorderColor = Color.Red
        Else
            txtDescripcion.Properties.Appearance.BorderColor = Nothing
        End If

        Return completa

    End Function

End Class