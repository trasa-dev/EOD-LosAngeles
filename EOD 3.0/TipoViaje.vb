Imports EOD.datasetEOD
Imports EOD.datasetEODTableAdapters

Public Class TipoViaje

    Dim hogar As Integer
    Dim persona As Integer
    Dim nombrePila As String
    Dim tipoEncuesta As Integer

    Public Sub New(ByVal hogar As Integer, ByVal persona As Integer, ByVal nombrePila As String, ByVal tipoEncuesta As Integer)
        InitializeComponent()
        Me.hogar = hogar
        Me.persona = persona
        Me.nombrePila = nombrePila
        Me.tipoEncuesta = tipoEncuesta
    End Sub

    Private Sub btnIngresarViajes_Click(sender As Object, e As EventArgs) Handles btnIngresarViajes.Click
        If Me.selTipoDia.EditValue IsNot Nothing Then

            Dim hogarBD As HogarRow = datasetEOD.Hogar.FindByHogar(hogar)

            Dim tipoDia As Integer = Me.selTipoDia.EditValue
            Dim hoy As DateTime = DateTime.Now
            Dim viajes As Double
            Dim noViaja As Integer

            Select Case tipoDia
                Case 1
                    If hogarBD.FechaViajesLab < hoy OrElse My.Settings.IdUsuario = 2 Then
                        'indicó no viaja?

                        Dim personaBuscada As PersonaRow = datasetEOD.Persona.FindByHogarPersona(hogar, persona)

                        If personaBuscada IsNot Nothing Then
                            noViaja = personaBuscada.NoViajaLab
                            viajes = personaBuscada.ViajesLab

                            'no viaja = sí
                            If noViaja > 0 Then
                                Dim resultado As DialogResult = MessageBox.Show("Esta persona anteriormente indicó que no realizó viajes el día asignado, ¿está seguro de que realmente tiene al menos un viaje?", "Por favor confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                                If resultado = DialogResult.Yes Then
                                    'actualizar noviaja
                                    personaBuscada.NoViajaLab = -1

                                    Try
                                        PersonaTableAdapter.Update(datasetEOD.Persona)
                                        'ingresar nuevo viaje
                                        Dim ventanaIngresoViajes As New IngresoViajes(hogar, persona, 1, nombrePila, 1, Me.tipoEncuesta)
                                        ventanaIngresoViajes.Show()
                                        Me.Dispose()
                                    Catch ex As Exception
                                        MessageBox.Show("No se pudo actualizar el dato de la persona en la base de datos.", "Error de actualización de datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                                    End Try
                                End If
                            Else
                                'no viaja = no
                                If personaBuscada.ViajesLab > 0 Then
                                    'mostrar resumen viajes
                                    Dim ventanaResumenViajes As New ResumenViajes(hogar, persona, nombrePila, 4)
                                    ventanaResumenViajes.Show()
                                    Me.Dispose()
                                Else
                                    'viaje1
                                    Dim ventanaIngresoViajes As New IngresoViajes(hogar, persona, 1, nombrePila, 1, Me.tipoEncuesta)
                                    ventanaIngresoViajes.Show()
                                    Me.Dispose()
                                End If
                            End If
                            'Catch ex As Exception
                            'MessageBox.Show(ex.Message + vbCrLf + vbCrLf + ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            ' End Try
                        End If
                    Else
                        MessageBox.Show("Debe recoger la Encuesta de Viajes al menos un día después de la fecha programada para el hogar", "No se puede encuestar hoy", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return
                    End If
                Case 2
                    If hogarBD.FechaViajesSab < hoy OrElse My.Settings.IdUsuario = 2 Then
                        'indicó no viaja?

                        Dim personaBuscada As PersonaRow = datasetEOD.Persona.FindByHogarPersona(hogar, persona)

                        If personaBuscada IsNot Nothing Then
                            noViaja = personaBuscada.NoViajaSab
                            viajes = personaBuscada.ViajesSab

                            'no viaja = sí
                            If noViaja > 0 Then
                                Dim resultado As DialogResult = MessageBox.Show("Esta persona anteriormente indicó que no realizó viajes el día asignado, ¿está seguro de que realmente tiene al menos un viaje?", "Por favor confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                                If resultado = DialogResult.Yes Then
                                    'actualizar noviaja
                                    personaBuscada.NoViajaSab = -1

                                    Try
                                        PersonaTableAdapter.Update(datasetEOD.Persona)
                                        'ingresar nuevo viaje
                                        Dim ventanaIngresoViajes As New IngresoViajes(hogar, persona, 1, nombrePila, 2, Me.tipoEncuesta)
                                        ventanaIngresoViajes.Show()
                                        Me.Dispose()
                                    Catch ex As Exception
                                        MessageBox.Show("No se pudo actualizar el dato de la persona en la base de datos.", "Error de actualización de datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                                    End Try
                                End If
                            Else
                                'no viaja = no
                                If personaBuscada.ViajesSab > 0 Then
                                    'mostrar resumen viajes
                                    Dim ventanaResumenViajes As New ResumenViajes(hogar, persona, nombrePila, 4)
                                    ventanaResumenViajes.Show()
                                    Me.Dispose()
                                Else
                                    'viaje1
                                    Dim ventanaIngresoViajes As New IngresoViajes(hogar, persona, 1, nombrePila, 2, Me.tipoEncuesta)
                                    ventanaIngresoViajes.Show()
                                    Me.Dispose()
                                End If
                            End If
                            'Catch ex As Exception
                            'MessageBox.Show(ex.Message + vbCrLf + vbCrLf + ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            ' End Try
                        End If
                    Else
                        MessageBox.Show("Debe recoger la Encuesta de Viajes al menos un día después de la fecha programada para el hogar", "No se puede encuestar hoy", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return
                    End If
                Case 3
                    If hogarBD.FechaViajesDom < hoy OrElse My.Settings.IdUsuario = 2 Then
                        'indicó no viaja?

                        Dim personaBuscada As PersonaRow = datasetEOD.Persona.FindByHogarPersona(hogar, persona)

                        If personaBuscada IsNot Nothing Then
                            noViaja = personaBuscada.NoViajaDom
                            viajes = personaBuscada.ViajesDom

                            'no viaja = sí
                            If noViaja > 0 Then
                                Dim resultado As DialogResult = MessageBox.Show("Esta persona anteriormente indicó que no realizó viajes el día asignado, ¿está seguro de que realmente tiene al menos un viaje?", "Por favor confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                                If resultado = DialogResult.Yes Then
                                    'actualizar noviaja 
                                    personaBuscada.NoViajaDom = -1

                                    Try
                                        PersonaTableAdapter.Update(datasetEOD.Persona)
                                        'ingresar nuevo viaje
                                        Dim ventanaIngresoViajes As New IngresoViajes(hogar, persona, 1, nombrePila, 3, Me.tipoEncuesta)
                                        ventanaIngresoViajes.Show()
                                        Me.Dispose()
                                    Catch ex As Exception
                                        MessageBox.Show("No se pudo actualizar el dato de la persona en la base de datos.", "Error de actualización de datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                                    End Try
                                End If
                            Else
                                'no viaja = no
                                If personaBuscada.ViajesDom > 0 Then
                                    'mostrar resumen viajes
                                    Dim ventanaResumenViajes As New ResumenViajes(hogar, persona, nombrePila, 4)
                                    ventanaResumenViajes.Show()
                                    Me.Dispose()
                                Else
                                    'viaje1
                                    Dim ventanaIngresoViajes As New IngresoViajes(hogar, persona, 1, nombrePila, 3, Me.tipoEncuesta)
                                    ventanaIngresoViajes.Show()
                                    Me.Dispose()
                                End If
                            End If
                            'Catch ex As Exception
                            'MessageBox.Show(ex.Message + vbCrLf + vbCrLf + ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            ' End Try
                        End If
                    Else
                        MessageBox.Show("Debe recoger la Encuesta de Viajes al menos un día después de la fecha programada para el hogar", "No se puede encuestar hoy", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return
                    End If
            End Select

        End If
    End Sub

    Private Sub TipoViaje_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'datasetEOD.Hogar' Puede moverla o quitarla según sea necesario.
        Me.HogarTableAdapter.Fill(Me.datasetEOD.Hogar)
        Me.PersonaTableAdapter.Fill(Me.datasetEOD.Persona)

        Me.txtNombre.Text = Me.nombrePila
    End Sub
End Class