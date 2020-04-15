Imports Microsoft.Office.Interop
Imports System.Threading
Imports DevExpress.XtraEditors
Imports DevExpress.LookAndFeel
Imports DevExpress.XtraScheduler
Imports System.Data.OleDb
Imports System.Net
Imports EOD.datasetEOD
Imports EOD.datasetEODTableAdapters
Imports System.Globalization
Imports System.Deployment.Application
Imports System.IO
Imports DevExpress.XtraGrid
Imports DevExpress.XtraPrinting

Public Class GrillaResumen
    Private userLook As UserLookAndFeel


    Private Shared appPath As String = Application.StartupPath
    Private Shared rutaConfig As String = appPath + "\config.ini"
    Private objConfig As New cIniArray()
    Private Shared secEncuestador As String = "encuestador"
    Private Shared secServidor As String = "ftp"
    Dim hogarSeleccionado As Object

    Sub New()
        InitializeComponent()
        DevExpress.Data.CurrencyDataController.DisableThreadingProblemsDetection = True
    End Sub

    Private Sub GrillaResumen_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        'TODO: esta línea de código carga datos en la tabla 'datasetEOD.Comuna' Puede moverla o quitarla según sea necesario.
        Me.ComunaTableAdapter.Fill(Me.datasetEOD.Comuna)



        framePrincipal.SelectedPageIndex = 0
        suspendeBindings()
        cargaDatosBackground.RunWorkerAsync()



        If ApplicationDeployment.IsNetworkDeployed Then
            'Muestra versión de publicación en menú
            Dim version As String = ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString
            lblVersion.Text = version

            'flag para restaurar datos
            Try
                If ApplicationDeployment.CurrentDeployment.IsFirstRun Then
                    Try
                        Dim nuevaVentana As RestaurarBase = New RestaurarBase
                        nuevaVentana.ShowDialog()
                    Catch ex As Exception
                        MessageBox.Show("No se pudo restaurar la base de datos. Contacte a Supervisión para resolver. " & vbCrLf & vbCrLf & "Error: " & ex.Message & "Pila de ejecución: " & vbCrLf & vbCrLf & ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End If
            Catch ex As InvalidDeploymentException
                MessageBox.Show(ex.Message + vbCrLf + vbCrLf + ex.StackTrace, "Deployment Exception", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Catch ex2 As Exception
                MessageBox.Show(ex2.Message + vbCrLf + vbCrLf + ex2.StackTrace, "Excepcion", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub gridViewHogares_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gridViewHogares.FocusedRowChanged

        If My.Settings.RolUsuario = 1 Then
            Me.ResumenHogaresBindingSource.Filter = "IDEncuestador = " + My.Settings.IdUsuario.ToString
        Else
            Me.ResumenHogaresBindingSource.Filter = Nothing
        End If

        If Not Me.gridViewHogares.GetSelectedRows Is Nothing Then
            Try
                If Me.gridViewHogares.GetFocusedRow IsNot Nothing Then
                    Dim folioActual As String = Me.gridViewHogares.GetFocusedRowCellValue("Hogar").ToString()
                    Me.ResumenPersonasBindingSource.Filter = "Hogar = " + folioActual
                    Me.ResumenVehiculosBindingSource.Filter = "Hogar = " + folioActual

                    Me.grpPersonas.Text = "Personas del hogar " + folioActual
                    Me.grpVehiculos.Text = "Vehículos del hogar " + folioActual
                End If


            Catch ex As Exception
                Me.ResumenPersonasBindingSource.Filter = "Hogar = 0"
                Me.ResumenVehiculosBindingSource.Filter = "Hogar = 0"
            End Try
        Else
            Me.ResumenPersonasBindingSource.Filter = "Hogar = 0"
            Me.ResumenVehiculosBindingSource.Filter = "Hogar = 0"
        End If
    End Sub

    Private Sub btnIngresarViajes_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnIngresarViajes.ItemClick
        '  Try
        Dim folio As Integer = Me.gridViewHogares.GetFocusedRowCellValue("Hogar").ToString()
        Dim persona As Integer = Me.gridViewPersonas.GetFocusedRowCellValue("Persona").ToString()
        Dim nombre As String = Me.gridViewPersonas.GetFocusedRowCellValue("NombrePila").ToString()

        Dim viajes As Double
        Dim noViaja As Integer

        'comprobar fecha minima para segunda visita

        Dim hogar As HogarRow = datasetEOD.Hogar.FindByHogar(folio)

        Dim tipoEncuesta As Integer = hogar.TipoDia
        Dim hoy As DateTime = DateTime.Now

        Select Case tipoEncuesta
            Case 1
                If hogar.FechaViajesLab < hoy OrElse My.Settings.IdUsuario = 2 Then
                    'indicó no viaja?

                    Dim personaBuscada As PersonaRow = datasetEOD.Persona.FindByHogarPersona(folio, persona)

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
                                    Dim ventanaIngresoViajes As New IngresoViajes(folio, persona, 1, nombre, 1, 1)
                                    ventanaIngresoViajes.Show()
                                Catch ex As Exception
                                    MessageBox.Show("No se pudo actualizar el dato de la persona en la base de datos.", "Error de actualización de datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                                End Try
                            End If
                        Else
                            'no viaja = no
                            If personaBuscada.ViajesLab > 0 Then
                                'mostrar resumen viajes
                                Dim ventanaResumenViajes As New ResumenViajes(folio, persona, nombre, 1)
                                ventanaResumenViajes.Show()
                            Else
                                'viaje1
                                Dim ventanaIngresoViajes As New IngresoViajes(folio, persona, 1, nombre, 1, 1)
                                ventanaIngresoViajes.Show()
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
                If hogar.FechaViajesSab < hoy OrElse My.Settings.IdUsuario = 2 Then
                    'indicó no viaja?

                    Dim personaBuscada As PersonaRow = datasetEOD.Persona.FindByHogarPersona(folio, persona)

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
                                    Dim ventanaIngresoViajes As New IngresoViajes(folio, persona, 1, nombre, 2, 2)
                                    ventanaIngresoViajes.Show()
                                Catch ex As Exception
                                    MessageBox.Show("No se pudo actualizar el dato de la persona en la base de datos.", "Error de actualización de datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                                End Try
                            End If
                        Else
                            'no viaja = no
                            If personaBuscada.ViajesSab > 0 Then
                                'mostrar resumen viajes
                                Dim ventanaResumenViajes As New ResumenViajes(folio, persona, nombre, 2)
                                ventanaResumenViajes.Show()
                            Else
                                'viaje1
                                Dim ventanaIngresoViajes As New IngresoViajes(folio, persona, 1, nombre, 2, 2)
                                ventanaIngresoViajes.Show()
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
                If hogar.FechaViajesDom < hoy OrElse My.Settings.IdUsuario = 2 Then
                    'indicó no viaja?

                    Dim personaBuscada As PersonaRow = datasetEOD.Persona.FindByHogarPersona(folio, persona)

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
                                    Dim ventanaIngresoViajes As New IngresoViajes(folio, persona, 1, nombre, 3, 3)
                                    ventanaIngresoViajes.Show()
                                Catch ex As Exception
                                    MessageBox.Show("No se pudo actualizar el dato de la persona en la base de datos.", "Error de actualización de datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                                End Try
                            End If
                        Else
                            'no viaja = no
                            If personaBuscada.ViajesDom > 0 Then
                                'mostrar resumen viajes
                                Dim ventanaResumenViajes As New ResumenViajes(folio, persona, nombre, 3)
                                ventanaResumenViajes.Show()
                            Else
                                'viaje1
                                Dim ventanaIngresoViajes As New IngresoViajes(folio, persona, 1, nombre, 3, 3)
                                ventanaIngresoViajes.Show()
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
            Case 4



                Dim ventanaTipoViaje As New TipoViaje(folio, persona, nombre, 4)
                ventanaTipoViaje.Show()
        End Select


        

    End Sub

    Private Sub suspendeBindings()
        ResumenHogaresBindingSource.SuspendBinding()
        ResumenPersonasBindingSource.SuspendBinding()
        ResumenVehiculosBindingSource.SuspendBinding()
        ZonasBindingSource.SuspendBinding()
        ResumenHogaresCompletosBindingSource.SuspendBinding()
        ResumenHogaresIncompletosBindingSource.SuspendBinding()
    End Sub

    Private Sub resumeBindings()
        ResumenHogaresBindingSource.ResumeBinding()
        ResumenPersonasBindingSource.ResumeBinding()
        ResumenVehiculosBindingSource.ResumeBinding()
        ZonasBindingSource.ResumeBinding()
        ResumenHogaresCompletosBindingSource.ResumeBinding()
        ResumenHogaresIncompletosBindingSource.ResumeBinding()
    End Sub

    Private Sub cargaDatosBackground_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles cargaDatosBackground.DoWork

        ResumenHogaresTableAdapter.Fill(datasetEOD.ResumenHogares)
        ResumenPersonasTableAdapter.Fill(datasetEOD.ResumenPersonas)
        ResumenVehiculosTableAdapter.Fill(datasetEOD.ResumenVehiculos)
        ZonasTableAdapter.Fill(datasetEOD.Zonas)

        PersonaTableAdapter.Fill(datasetEOD.Persona)
        If My.Settings.RolUsuario = 1 Then
            HogarTableAdapter.FillByUsuario(datasetEOD.Hogar, My.Settings.IdUsuario)
        Else
            HogarTableAdapter.Fill(datasetEOD.Hogar)
        End If

        VehiculoTableAdapter.Fill(datasetEOD.Vehiculo)
        ValidaHogarTableAdapter.Fill(datasetEOD.ValidaHogar)
        ValidaPersonaTableAdapter.Fill(datasetEOD.ValidaPersona)

        
    End Sub

    Private Sub cargaDatosBackground_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles cargaDatosBackground.RunWorkerCompleted
        resumeBindings()

        Try
            If My.Settings.RolUsuario = 1 Then
                Me.ResumenHogaresBindingSource.Filter = "IDEncuestador = " + My.Settings.IdUsuario.ToString
            Else
                Me.ResumenHogaresBindingSource.Filter = Nothing
            End If

            If Me.gridViewHogares IsNot Nothing AndAlso Me.gridViewHogares.GetSelectedRows IsNot Nothing Then

                If gridViewHogares.RowCount > 0 Then
                    gridViewHogares.FocusedRowHandle = gridViewHogares.LocateByValue("ID", hogarSeleccionado)
                End If

                Dim folioActual As String = Me.gridViewHogares.GetFocusedRowCellValue("Hogar").ToString()
                If My.Settings.RolUsuario = 1 Then
                    Me.ResumenHogaresBindingSource.Filter = "IDEncuestador = " + My.Settings.IdUsuario.ToString
                Else
                    Me.ResumenHogaresBindingSource.Filter = Nothing
                End If
                Me.ResumenPersonasBindingSource.Filter = "Hogar = " + folioActual
                Me.ResumenVehiculosBindingSource.Filter = "Hogar = " + folioActual

                Me.grpPersonas.Text = "Personas del hogar " + folioActual
                Me.grpVehiculos.Text = "Vehículos del hogar " + folioActual
            Else
                Me.ResumenPersonasBindingSource.Filter = "Hogar = 0"
                Me.ResumenVehiculosBindingSource.Filter = "Hogar = 0"
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub GrillaResumen_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        If gridViewHogares.GetSelectedRows.Count > 0 Then
            hogarSeleccionado = Me.gridViewHogares.GetRowCellValue(gridViewHogares.FocusedRowHandle, "ID")
        End If

        If Not cargaDatosBackground.IsBusy Then
            suspendeBindings()
            cargaDatosBackground.RunWorkerAsync()
        End If
    End Sub

    Private Sub GrillaResumen_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub

    Private Sub btnModificarPersona_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnModificarPersona.ItemClick
        Try
            Dim folioActual As String = Me.gridViewHogares.GetFocusedRowCellValue("Hogar").ToString()
            Dim perActual As String = Me.gridViewPersonas.GetFocusedRowCellValue("Persona").ToString()
            Dim nuevaVentana As ModificarPersona = New ModificarPersona(folioActual, perActual)
            nuevaVentana.ShowDialog()
        Catch ex As NullReferenceException

        End Try
        
    End Sub

    Private Sub btnModificarHogar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnModificarHogar.ItemClick
        Try
            Dim nuevaVentana As New ModificarHogar(Me.gridViewHogares.GetFocusedRowCellValue("Hogar").ToString())
            nuevaVentana.ShowDialog()
        Catch ex As NullReferenceException

        End Try
    End Sub

    Private Sub btnModificarVehiculo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnModificarVehiculo.ItemClick
        Try
            Dim folioActual As String = Me.gridViewHogares.GetFocusedRowCellValue("Hogar").ToString()
            Dim vehActual As String = Me.gridViewVehiculos.GetFocusedRowCellValue("Vehículo").ToString()
            Dim nuevaVentana As ModificarVehiculo = New ModificarVehiculo(folioActual, vehActual)
            nuevaVentana.ShowDialog()
        Catch ex As NullReferenceException

        End Try
        
    End Sub

    Private Sub btnEliminarVehiculo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEliminarVehiculo.ItemClick
        Try
            Dim folioActual As String = Me.gridViewPersonas.GetFocusedRowCellValue("Hogar").ToString()
            Dim vehActual As String = Me.gridViewVehiculos.GetFocusedRowCellValue("Vehículo").ToString()
            Dim resultado As DialogResult = XtraMessageBox.Show("¿Está seguro de eliminar el vehículo?", "Confirmar acción", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If resultado = Windows.Forms.DialogResult.Yes Then

                Dim vehiculoEliminado As VehiculoRow = datasetEOD.Vehiculo.FindByHogarVehículo(folioActual, vehActual)
                If vehiculoEliminado IsNot Nothing Then
                    vehiculoEliminado.Delete()
                    VehiculoTableAdapter.Update(datasetEOD.Vehiculo)
                    MessageBox.Show("El vehículo " & vehActual & " ha sido eliminado del hogar " & folioActual, "Vehículo eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("No se encontró el vehículo a eliminar")
                End If
            End If
        Catch ex As NullReferenceException

        End Try
        
    End Sub

    Private Sub btnEliminarHogar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEliminarHogar.ItemClick
        Try
            Dim folioActual As String = Me.gridViewHogares.GetFocusedRowCellValue("Hogar").ToString()
            Dim resultado As DialogResult = XtraMessageBox.Show("¿Está seguro de eliminar el hogar?", "Confirmar acción", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If resultado = Windows.Forms.DialogResult.Yes Then

                Dim hogarEliminado As HogarRow = datasetEOD.Hogar.FindByHogar(folioActual)
                If hogarEliminado IsNot Nothing Then
                    hogarEliminado.Delete()
                    HogarTableAdapter.Update(datasetEOD.Hogar)
                    MessageBox.Show("El hogar " & folioActual & " ha sido eliminado de la base de datos de encuestas.", "Hogar eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    Dim validaHogarEliminado As ValidaHogarRow = datasetEOD.ValidaHogar.FindByHogar(folioActual)
                    If validaHogarEliminado IsNot Nothing Then
                        validaHogarEliminado.Delete()
                        ValidaHogarTableAdapter.Update(datasetEOD.ValidaHogar)
                    End If
                Else
                    MessageBox.Show("No se encontró el hogar a eliminar")
                End If
            End If
        Catch ex As NullReferenceException

        End Try
        
    End Sub

    Private Sub btnEliminarPersona_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEliminarPersona.ItemClick
        Try
            Dim folioActual As String = Me.gridViewPersonas.GetFocusedRowCellValue("Hogar").ToString()
            Dim perActual As String = Me.gridViewPersonas.GetFocusedRowCellValue("Persona").ToString()
            Dim resultado As DialogResult = XtraMessageBox.Show("¿Está seguro de eliminar la persona?", "Confirmar acción", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If resultado = Windows.Forms.DialogResult.Yes Then

                Dim personaEliminada As PersonaRow = datasetEOD.Persona.FindByHogarPersona(folioActual, perActual)
                If personaEliminada IsNot Nothing Then
                    personaEliminada.Delete()
                    PersonaTableAdapter.Update(datasetEOD.Persona)
                    MessageBox.Show("La persona " & perActual & " ha sido eliminado del hogar " & folioActual, "Persona eliminada", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    Dim validaPersonaEliminado As ValidaPersonaRow = datasetEOD.ValidaPersona.FindByHogarPersona(folioActual, perActual)
                    If validaPersonaEliminado IsNot Nothing Then
                        validaPersonaEliminado.Delete()
                        ValidaPersonaTableAdapter.Update(datasetEOD.ValidaPersona)
                    End If
                Else
                    MessageBox.Show("No se encontró la persona a eliminar")
                End If
            End If
        Catch ex As NullReferenceException

        End Try
    End Sub

    Private Sub ribbonPrincipal_SelectedPageChanged(sender As Object, e As EventArgs) Handles ribbonPrincipal.SelectedPageChanged
        If ribbonPrincipal.SelectedPage.PageIndex = 0 Then
            framePrincipal.SelectedPageIndex = 0
        Else
            framePrincipal.SelectedPageIndex = 1
        End If
    End Sub

    Private Sub btnNuevoHogar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnNuevoHogar.ItemClick
        Dim nuevaEncuesta As New NuevoHogar
        nuevaEncuesta.Show()
    End Sub

    Private Sub btnSubirDatos_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSubirDatos.ItemClick
        Dim nuevaVentana As SubirDatos = New SubirDatos
        nuevaVentana.ShowDialog()
    End Sub

    Private Sub btnAgregarPersona_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAgregarPersona.ItemClick
        Try
            Dim folioActual As String = Me.gridViewHogares.GetFocusedRowCellValue("Hogar").ToString()
            Dim nuevaVentana As AgregarPersona = New AgregarPersona(folioActual)
            nuevaVentana.ShowDialog()
        Catch ex As NullReferenceException
            MessageBox.Show("No ha seleccionado algún hogar para agregar persona" + vbCrLf + vbCrLf + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnAgregarVehiculo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAgregarVehiculo.ItemClick
        Try
            Dim folioActual As String = Me.gridViewHogares.GetFocusedRowCellValue("Hogar").ToString()
            Dim nuevaVentana As AgregarVehiculo = New AgregarVehiculo(folioActual)
            nuevaVentana.ShowDialog()
        Catch ex As Exception
            MessageBox.Show("No ha seleccionado algún hogar para agregar vehículo" + vbCrLf + vbCrLf + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCerrarSesion_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCerrarSesion.ItemClick
        Dim nuevaVentana As Login = New Login
        nuevaVentana.Show()
        My.User.CurrentPrincipal = Nothing
        Me.Dispose()
    End Sub

    Private Sub hojaConfiguracion_Load(sender As Object, e As EventArgs) Handles hojaConfiguracion.Load
        txtIDEquipo.Text = objConfig.IniGet(rutaConfig, secEncuestador, "idEquipo", "")
        txtServidorFTP.Text = objConfig.IniGet(rutaConfig, secServidor, "ip", "")
        txtUsuarioFTP.Text = objConfig.IniGet(rutaConfig, secServidor, "user", "")
        txtClaveFTP.Text = objConfig.IniGet(rutaConfig, secServidor, "pass", "")
    End Sub

    Private Sub btnGuardarConf_Click(sender As Object, e As EventArgs) Handles btnGuardarConf.Click
        Try
            objConfig.IniWrite(rutaConfig, secEncuestador, "idEquipo", txtIDEquipo.Text)
            objConfig.IniWrite(rutaConfig, secServidor, "ip", txtServidorFTP.Text)
            objConfig.IniWrite(rutaConfig, secServidor, "user", txtUsuarioFTP.Text)
            objConfig.IniWrite(rutaConfig, secServidor, "pass", txtClaveFTP.Text)

            MessageBox.Show("Configuración guardada correctamente", "Datos guardados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ribbonPrincipal.HideApplicationButtonContentControl()
        Catch ex As Exception
            MessageBox.Show("Ocurrió un error tratando de guardar la configuración." + vbCrLf + vbCrLf + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnValidar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnValidar.ItemClick
        Try
            Dim objConn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\MASCARA REFERENCIA_VF.accdb")
            objConn.Open()

            'Estado encuesta 1
            Dim objCommand As New OleDbCommand("[Estado Encuesta 1]", objConn) With {.CommandType = CommandType.StoredProcedure}
            objCommand.ExecuteNonQuery()

            'Estado encuesta 3
            objCommand = New OleDbCommand("[Estado Encuesta 3]", objConn) With {.CommandType = CommandType.StoredProcedure}
            objCommand.ExecuteNonQuery()

            'Estado encuesta 4
            objCommand = New OleDbCommand("[Estado Encuesta 4]", objConn) With {.CommandType = CommandType.StoredProcedure}
            objCommand.ExecuteNonQuery()

            'Estado encuesta 7
            objCommand = New OleDbCommand("[Estado Encuesta 7]", objConn) With {.CommandType = CommandType.StoredProcedure}
            objCommand.ExecuteNonQuery()

            'Estado encuesta 6 por Hogar
            objCommand = New OleDbCommand("[Estado Encuesta 6 Hogar]", objConn) With {.CommandType = CommandType.StoredProcedure}
            objCommand.ExecuteNonQuery()

            'Estado encuesta 6 por Persona
            objCommand = New OleDbCommand("[Estado Encuesta 6 Persona]", objConn) With {.CommandType = CommandType.StoredProcedure}
            objCommand.ExecuteNonQuery()

            'Estado encuesta 6 por Viaje
            objCommand = New OleDbCommand("[Estado Encuesta 6 Viaje]", objConn) With {.CommandType = CommandType.StoredProcedure}
            objCommand.ExecuteNonQuery()

            'Estado encuesta 6 por Etapa
            objCommand = New OleDbCommand("[Estado Encuesta 6 Etapa]", objConn) With {.CommandType = CommandType.StoredProcedure}
            objCommand.ExecuteNonQuery()

            MessageBox.Show("Finalizó el proceso de validación de encuestas", "Validación de encuestas", MessageBoxButtons.OK, MessageBoxIcon.Information)
            actualizaResumenAvance()
        Catch ex As Exception
            MessageBox.Show("Error en el proceso de validación de encuestas: " & ex.Message & vbCrLf & vbCrLf & ex.StackTrace, "Validación de encuestas", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub frameControlAvance_SelectedPageChanged(sender As Object, e As DevExpress.XtraBars.Navigation.SelectedPageChangedEventArgs) Handles frameControlAvance.SelectedPageChanged
        Select Case frameControlAvance.SelectedPageIndex
            Case 0
                actualizaResumenAvance()
            Case 1
                ResumenHogaresCompletosTableAdapter = New datasetEODTableAdapters.ResumenHogaresCompletosTableAdapter
                ResumenHogaresCompletosTableAdapter.Fill(datasetEOD.ResumenHogaresCompletos)


            Case 2
                ResumenHogaresIncompletosTableAdapter = New datasetEODTableAdapters.ResumenHogaresIncompletosTableAdapter
                ResumenHogaresIncompletosTableAdapter.Fill(datasetEOD.ResumenHogaresIncompletos)
            Case 3
                ResumenHogaresInconsistentesTableAdapter = New datasetEODTableAdapters.ResumenHogaresInconsistentesTableAdapter
                ResumenHogaresInconsistentesTableAdapter.Fill(datasetEOD.ResumenHogaresInconsistentes)
            Case 4
                ResumenHogaresRechazadosTableAdapter = New datasetEODTableAdapters.ResumenHogaresRechazadosTableAdapter
                ResumenHogaresRechazadosTableAdapter.Fill(datasetEOD.ResumenHogaresRechazados)
            Case 5
                If My.Settings.RolUsuario = 1 Then
                    HogarTableAdapter.FillByUsuario(datasetEOD.Hogar, My.Settings.IdUsuario)
                Else
                    HogarTableAdapter.Fill(datasetEOD.Hogar)
                End If
                Me.HogaresNoEncuestadosTableAdapter.Fill(Me.datasetEOD.HogaresNoEncuestados)

            Case 6


        End Select
    End Sub

    Private Sub btnCuadroResumen_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCuadroResumen.ItemClick
        frameControlAvance.SelectedPageIndex = 0
    End Sub

    Private Sub btnCompletas_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCompletas.ItemClick
        frameControlAvance.SelectedPageIndex = 1
    End Sub

    Private Sub btnIncompletas_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnIncompletas.ItemClick
        frameControlAvance.SelectedPageIndex = 2
    End Sub

    Private Sub btnInconsistentes_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnInconsistentes.ItemClick
        frameControlAvance.SelectedPageIndex = 3
    End Sub

    Private Sub btnRechazadas_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRechazadas.ItemClick
        frameControlAvance.SelectedPageIndex = 4
    End Sub

    Private Sub framePrincipal_SelectedPageChanged(sender As Object, e As DevExpress.XtraBars.Navigation.SelectedPageChangedEventArgs) Handles framePrincipal.SelectedPageChanged
        If framePrincipal.SelectedPageIndex = 1 Then
            actualizaResumenAvance()
        End If
    End Sub

    Private Sub actualizaResumenAvance()
        GraficoEncuestadosTableAdapter = New datasetEODTableAdapters.GraficoEncuestadosTableAdapter
        GraficoEncuestadosTableAdapter.Fill(datasetEOD.GraficoEncuestados)
        EncuestasPorEstadoTableAdapter = New datasetEODTableAdapters.EncuestasPorEstadoTableAdapter
        EncuestasPorEstadoTableAdapter.Fill(datasetEOD.EncuestasPorEstado)
        EncuestasRecogerHoyTableAdapter = New datasetEODTableAdapters.EncuestasRecogerHoyTableAdapter
        EncuestasRecogerHoyTableAdapter.Fill(datasetEOD.EncuestasRecogerHoy)
        PersonasEncuestarHoyTableAdapter = New datasetEODTableAdapters.PersonasEncuestarHoyTableAdapter
        PersonasEncuestarHoyTableAdapter.Fill(datasetEOD.PersonasEncuestarHoy)
        UltimaExportacionTableAdapter = New datasetEODTableAdapters.UltimaExportacionTableAdapter
        UltimaExportacionTableAdapter.Fill(datasetEOD.UltimaExportacion)
        EncuestasRecoger1DiaTableAdapter = New datasetEODTableAdapters.EncuestasRecoger1DiaTableAdapter
        EncuestasRecoger2DiasTableAdapter = New datasetEODTableAdapters.EncuestasRecoger2DiasTableAdapter
        EncuestasRecogerMas2DiasTableAdapter = New datasetEODTableAdapters.EncuestasRecogerMas2DiasTableAdapter
        EncuestasRecogerSemanaTableAdapter = New datasetEODTableAdapters.EncuestasRecogerSemanaTableAdapter
        EncuestasRecoger1DiaTableAdapter.Fill(datasetEOD.EncuestasRecoger1Dia)
        EncuestasRecoger2DiasTableAdapter.Fill(datasetEOD.EncuestasRecoger2Dias)
        EncuestasRecogerMas2DiasTableAdapter.Fill(datasetEOD.EncuestasRecogerMas2Dias)
        EncuestasRecogerSemanaTableAdapter.Fill(datasetEOD.EncuestasRecogerSemana)

        'Número de encuestas completas
        Dim rowEstadoCompletas As EncuestasPorEstadoRow = datasetEOD.EncuestasPorEstado.Rows.Find("Completa")
        If rowEstadoCompletas IsNot Nothing Then
            lblEncuestasCompletas.Text = rowEstadoCompletas.Encuestas.ToString
        Else
            lblEncuestasCompletas.Text = "0"
        End If

        'Número de encuestas incompletas
        Dim rowEstadoIncompletas As EncuestasPorEstadoRow = datasetEOD.EncuestasPorEstado.Rows.Find("Incompleta")
        If rowEstadoIncompletas IsNot Nothing Then
            lblEncuestasIncompletas.Text = rowEstadoIncompletas.Encuestas.ToString
        Else
            lblEncuestasIncompletas.Text = "0"
        End If

        'Número de encuestas inconsistentes
        Dim rowEstadoInconsistentes As EncuestasPorEstadoRow = datasetEOD.EncuestasPorEstado.Rows.Find("Inconsistente")
        If rowEstadoInconsistentes IsNot Nothing Then
            lblEncuestasInconsistentes.Text = rowEstadoInconsistentes.Encuestas.ToString
        Else
            lblEncuestasInconsistentes.Text = "0"
        End If

        'Número de encuestas rechazadas
        Dim rowEstadoRechazadas As EncuestasPorEstadoRow = datasetEOD.EncuestasPorEstado.Rows.Find("Rechazada")
        If rowEstadoRechazadas IsNot Nothing Then
            lblEncuestasRechazadas.Text = rowEstadoRechazadas.Encuestas.ToString
        Else
            lblEncuestasRechazadas.Text = "0"
        End If

        'Fecha última exportación
        Dim rowUltimaExportación As UltimaExportacionRow = datasetEOD.UltimaExportacion.Rows(0)
        If rowUltimaExportación IsNot Nothing Then
            Try
                If Not rowUltimaExportación.IsUltimaExportacionNull Then
                    lblUltimaExportacion.Text = rowUltimaExportación.UltimaExportacion.ToString
                End If

            Catch ex As Exception
                lblUltimaExportacion.Text = "No ha exportado"
            End Try
        Else
            lblUltimaExportacion.Text = "No ha exportado"
        End If

        'Personas por encuestar hoy
        lblPersonasEncuestarDia.Text = PersonasEncuestarHoyBindingSource.Count.ToString

        'Encuestas por recoger hoy
        lblEncuestasRecogerHoy.Text = EncuestasRecogerHoyBindingSource.Count.ToString

        'Cargar agenda
        '1 día después
        If calendarioAvance.Storage IsNot Nothing Then
            calendarioAvance.Storage.Appointments.Clear()
        End If

        For Each encuestaHoy As Object In EncuestasRecoger1DiaBindingSource
            Dim citaHoy As Appointment = calendarioAvance.Storage.CreateAppointment(AppointmentType.Normal)

            citaHoy.AllDay = True
            citaHoy.Subject = encuestaHoy("Hogar")
            Dim location As String = encuestaHoy("NombreCalle") & " " & encuestaHoy("Numero") & " " & encuestaHoy("CasaDepto")
            citaHoy.Location = location.Trim
            citaHoy.Description = "Recoger viajes (1 día después)"
            citaHoy.Start = DateTime.Today
            citaHoy.LabelId = 3
            calendarioAvance.Storage.Appointments.Add(citaHoy)
        Next

        '2 días después
        For Each encuesta2Dias As Object In EncuestasRecoger2DiasBindingSource
            Dim citaHoy As Appointment = calendarioAvance.Storage.CreateAppointment(AppointmentType.Normal)
            citaHoy.AllDay = True
            citaHoy.Subject = encuesta2Dias("Hogar")
            Dim location As String = encuesta2Dias("NombreCalle") & " " & encuesta2Dias("Numero") & " " & encuesta2Dias("CasaDepto")
            citaHoy.Location = location.Trim
            citaHoy.Description = "Recoger viajes (2 días después)"
            citaHoy.Start = DateTime.Today
            citaHoy.LabelId = 10
            calendarioAvance.Storage.Appointments.Add(citaHoy)
        Next

        '2 días después
        For Each encuesta3Días As Object In EncuestasRecogerMas2DiasBindingSource
            Dim citaHoy As Appointment = calendarioAvance.Storage.CreateAppointment(AppointmentType.Normal)
            citaHoy.AllDay = True
            citaHoy.Subject = encuesta3Días("Hogar")
            Dim location As String = encuesta3Días("NombreCalle") & " " & encuesta3Días("Numero") & " " & encuesta3Días("CasaDepto")
            citaHoy.Location = location.Trim
            citaHoy.Description = "Recoger viajes (más de 2 días después)"
            citaHoy.Start = DateTime.Today
            citaHoy.LabelId = 1
            calendarioAvance.Storage.Appointments.Add(citaHoy)
        Next

        'resto de la semana
        For Each encuestaSemana As Object In EncuestasRecogerSemanaBindingSource
            Dim citaHoy As Appointment = calendarioAvance.Storage.CreateAppointment(AppointmentType.Normal)
            citaHoy.AllDay = True
            citaHoy.Subject = encuestaSemana("Hogar")
            Dim location As String = encuestaSemana("NombreCalle") & " " & encuestaSemana("Numero") & " " & encuestaSemana("CasaDepto")
            citaHoy.Location = location.Trim
            citaHoy.Description = "Recoger viajes"
            citaHoy.Start = encuestaSemana("FechaVisita2")
            citaHoy.LabelId = 3
            calendarioAvance.Storage.Appointments.Add(citaHoy)
        Next

        calendarioAvance.DayView.AllDayAreaScrollBarVisible = True
        calendarioAvance.Start = DateTime.Today
        calendarioAvance.DayView.DayCount = 3
    End Sub

    Private Sub calendarioAvance_PopupMenuShowing(sender As Object, e As PopupMenuShowingEventArgs) Handles calendarioAvance.PopupMenuShowing
        e.Menu.Items.Clear()
    End Sub

    Private Sub InstallUpdateSyncWithInfo()
        Dim info As UpdateCheckInfo = Nothing

        If (ApplicationDeployment.IsNetworkDeployed) Then
            Dim AD As ApplicationDeployment = ApplicationDeployment.CurrentDeployment

            Try
                info = AD.CheckForDetailedUpdate()
            Catch dde As DeploymentDownloadException
                MessageBox.Show("La nueva versión de la aplicación no puede descargarse en este momento. " + ControlChars.Lf & ControlChars.Lf & "Por favor, revise su conexión a internet o intente más tarde. Error: " + dde.Message)
                Return
            Catch ioe As InvalidOperationException
                MessageBox.Show("Esta aplicación no puede actualizarse. No parece una aplicación ClickOnce. Error: " & ioe.Message)
                Return
            End Try

            If (info.UpdateAvailable) Then
                Dim doUpdate As Boolean = True

                If (Not info.IsUpdateRequired) Then
                    Dim dr As DialogResult = MessageBox.Show("Hay una actualización disponible, ¿le gustaría actualizar la aplicación ahora?", "Actualización disponible", MessageBoxButtons.OKCancel)
                    If (Not System.Windows.Forms.DialogResult.OK = dr) Then
                        doUpdate = False
                    End If
                Else
                    ' Display a message that the app MUST reboot. Display the minimum required version.
                    MessageBox.Show("Esta aplicación ha detectado una actualización necesaria desde la versión " & _
                        "actual a la versión " & info.MinimumRequiredVersion.ToString() & _
                        ". La aplicación instalará ahora la actualización y se reiniciará.", _
                        "Actualización disponible", MessageBoxButtons.OK, _
                        MessageBoxIcon.Information)
                End If

                If (doUpdate) Then
                    Dim nuevaVentana As Actualizar = New Actualizar
                    nuevaVentana.ShowDialog()
                End If
            Else
                MessageBox.Show("No hay actualizaciones disponibles, ya posee la última versión del programa.", "Comprobación de actualizaciones", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("No es una aplicación ClickOnce desplegada por red. No es posible actualizar", "No se puede actualizar", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        InstallUpdateSyncWithInfo()
    End Sub

    Private Sub btnExportarExcel_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExportarExcel.ItemClick
        dialogExcel = New SaveFileDialog
        dialogExcel.FileName = "Resumen " & My.Settings.NombreUsuario & " " & My.Settings.ApellidoUsuario & " " & DateTime.Now.Year & "-" & DateTime.Now.Month.ToString & "-" & DateTime.Now.Day & ".xls"
        dialogExcel.ShowDialog()

    End Sub

    Private Sub dialogExcel_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles dialogExcel.FileOk



        ResumenHogaresCompletosTableAdapter = New datasetEODTableAdapters.ResumenHogaresCompletosTableAdapter
        ResumenHogaresCompletosTableAdapter.Fill(datasetEOD.ResumenHogaresCompletos)

        ResumenHogaresIncompletosTableAdapter = New datasetEODTableAdapters.ResumenHogaresIncompletosTableAdapter
        ResumenHogaresIncompletosTableAdapter.Fill(datasetEOD.ResumenHogaresIncompletos)

        ResumenHogaresInconsistentesTableAdapter = New datasetEODTableAdapters.ResumenHogaresInconsistentesTableAdapter
        ResumenHogaresInconsistentesTableAdapter.Fill(datasetEOD.ResumenHogaresInconsistentes)

        ResumenHogaresRechazadosTableAdapter = New datasetEODTableAdapters.ResumenHogaresRechazadosTableAdapter
        ResumenHogaresRechazadosTableAdapter.Fill(datasetEOD.ResumenHogaresRechazados)


        Dim xlApp As Excel.Application = New Excel.Application()

        If xlApp Is Nothing Then
            MessageBox.Show("No se ha encontrado Excel instalado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim xlWorkBook As Excel.Workbook
        Dim xlHojaCompletas As Excel.Worksheet
        Dim xlHojaIncompletas As Excel.Worksheet
        Dim xlHojaInconsistentes As Excel.Worksheet
        Dim xlHojaRechazadas As Excel.Worksheet
        Dim misValue As Object = System.Reflection.Missing.Value

        xlWorkBook = xlApp.Workbooks.Add()

        '********** Contenido encuestas completas ***************
        xlHojaCompletas = xlWorkBook.Sheets(1)
        xlHojaCompletas.Name = "Encuestas completas"

        'Encabezados de tabla
        xlHojaCompletas.Cells(3, 3) = "Hogar"
        xlHojaCompletas.Cells(3, 4) = "Zona"
        xlHojaCompletas.Cells(3, 5) = "Calle"
        xlHojaCompletas.Cells(3, 6) = "Número"
        xlHojaCompletas.Cells(3, 7) = "Casa/Depto"
        xlHojaCompletas.Cells(3, 8) = "Fecha Viajes"
        xlHojaCompletas.Cells(3, 9) = "Tipo Encuesta"

        'Contenido de tabla   
        For i As Integer = 0 To gridViewCompletas.DataRowCount - 1
            xlHojaCompletas.Cells(i + 4, 3) = gridViewCompletas.GetRowCellValue(i, "Hogar").ToString
            xlHojaCompletas.Cells(i + 4, 4) = gridViewCompletas.GetRowCellValue(i, "Zona").ToString
            xlHojaCompletas.Cells(i + 4, 5) = gridViewCompletas.GetRowCellValue(i, "NombreCalle").ToString
            xlHojaCompletas.Cells(i + 4, 6) = gridViewCompletas.GetRowCellValue(i, "Numero").ToString
            xlHojaCompletas.Cells(i + 4, 7) = gridViewCompletas.GetRowCellValue(i, "CasaDepto").ToString
            xlHojaCompletas.Cells(i + 4, 8) = gridViewCompletas.GetRowCellValue(i, "FechaViajes").ToString
            xlHojaCompletas.Cells(i + 4, 9) = gridViewCompletas.GetRowCellValue(i, "TipoDia").ToString
        Next


        Dim xlHojasWorkbook As Excel.Sheets = xlWorkBook.Worksheets

        '********** Contenido encuestas incompletas ***************
        xlHojaIncompletas = DirectCast(xlHojasWorkbook.Add(xlHojasWorkbook(1), Type.Missing, Type.Missing, Type.Missing), Excel.Worksheet)
        xlHojaIncompletas.Name = "Encuestas incompletas"

        'Encabezados de tabla
        xlHojaIncompletas.Cells(3, 3) = "Hogar"
        xlHojaIncompletas.Cells(3, 4) = "Zona"
        xlHojaIncompletas.Cells(3, 5) = "Calle"
        xlHojaIncompletas.Cells(3, 6) = "Número"
        xlHojaIncompletas.Cells(3, 7) = "Casa/Depto"
        xlHojaIncompletas.Cells(3, 8) = "Fecha Viajes"
        xlHojaIncompletas.Cells(3, 9) = "Tipo Encuesta"
        xlHojaIncompletas.Cells(3, 10) = "Estado Encuesta"

        'Contenido de tabla
        For i As Integer = 0 To gridViewIncompletas.DataRowCount - 1
            xlHojaIncompletas.Cells(i + 4, 3) = gridViewIncompletas.GetRowCellValue(i, "Hogar").ToString
            xlHojaIncompletas.Cells(i + 4, 4) = gridViewIncompletas.GetRowCellValue(i, "Zona").ToString
            xlHojaIncompletas.Cells(i + 4, 5) = gridViewIncompletas.GetRowCellValue(i, "NombreCalle").ToString
            xlHojaIncompletas.Cells(i + 4, 6) = gridViewIncompletas.GetRowCellValue(i, "Numero").ToString
            xlHojaIncompletas.Cells(i + 4, 7) = gridViewIncompletas.GetRowCellValue(i, "CasaDepto").ToString
            xlHojaIncompletas.Cells(i + 4, 8) = gridViewIncompletas.GetRowCellValue(i, "FechaViajes").ToString
            xlHojaIncompletas.Cells(i + 4, 9) = gridViewIncompletas.GetRowCellValue(i, "TipoDia").ToString
            xlHojaIncompletas.Cells(i + 4, 10) = gridViewIncompletas.GetRowCellValue(i, "EstadoEncuesta").ToString
        Next

        '********** Contenido encuestas inconsistentes ***************
        xlHojaInconsistentes = DirectCast(xlHojasWorkbook.Add(xlHojasWorkbook(2), Type.Missing, Type.Missing, Type.Missing), Excel.Worksheet)
        xlHojaInconsistentes.Name = "Encuestas inconsistentes"

        'Encabezados de tabla
        xlHojaInconsistentes.Cells(3, 3) = "Hogar"
        xlHojaInconsistentes.Cells(3, 4) = "Zona"
        xlHojaInconsistentes.Cells(3, 5) = "Calle"
        xlHojaInconsistentes.Cells(3, 6) = "Número"
        xlHojaInconsistentes.Cells(3, 7) = "Casa/Depto"
        xlHojaInconsistentes.Cells(3, 8) = "Fecha Viajes"
        xlHojaInconsistentes.Cells(3, 9) = "Tipo Encuesta"
        xlHojaInconsistentes.Cells(3, 10) = "Estado Encuesta"

        'Contenido de tabla
        For i As Integer = 0 To gridViewInconsistentes.DataRowCount - 1
            xlHojaInconsistentes.Cells(i + 4, 3) = gridViewInconsistentes.GetRowCellValue(i, "Hogar").ToString
            xlHojaInconsistentes.Cells(i + 4, 4) = gridViewInconsistentes.GetRowCellValue(i, "Zona").ToString
            xlHojaInconsistentes.Cells(i + 4, 5) = gridViewInconsistentes.GetRowCellValue(i, "NombreCalle").ToString
            xlHojaInconsistentes.Cells(i + 4, 6) = gridViewInconsistentes.GetRowCellValue(i, "Numero").ToString
            xlHojaInconsistentes.Cells(i + 4, 7) = gridViewInconsistentes.GetRowCellValue(i, "CasaDepto").ToString
            xlHojaInconsistentes.Cells(i + 4, 8) = gridViewInconsistentes.GetRowCellValue(i, "FechaViajes").ToString
            xlHojaInconsistentes.Cells(i + 4, 9) = gridViewInconsistentes.GetRowCellValue(i, "TipoDia").ToString
            xlHojaInconsistentes.Cells(i + 4, 10) = gridViewInconsistentes.GetRowCellValue(i, "EstadoEncuesta").ToString
        Next

        'Contenido encuestas rechazadas
        xlHojaRechazadas = DirectCast(xlHojasWorkbook.Add(xlHojasWorkbook(3), Type.Missing, Type.Missing, Type.Missing), Excel.Worksheet)
        xlHojaRechazadas.Name = "Encuestas rechazadas"

        'Encabezados de tabla
        xlHojaRechazadas.Cells(3, 3) = "Hogar"
        xlHojaRechazadas.Cells(3, 4) = "Zona"
        xlHojaRechazadas.Cells(3, 5) = "Calle"
        xlHojaRechazadas.Cells(3, 6) = "Número"
        xlHojaRechazadas.Cells(3, 7) = "Casa/Depto"
        xlHojaRechazadas.Cells(3, 8) = "Fecha Viajes"
        xlHojaRechazadas.Cells(3, 9) = "Tipo Encuesta"

        'Contenido de tabla
        For i As Integer = 0 To gridViewRechazadas.DataRowCount - 1
            xlHojaRechazadas.Cells(i + 4, 3) = gridViewRechazadas.GetRowCellValue(i, "Hogar").ToString
            xlHojaRechazadas.Cells(i + 4, 4) = gridViewRechazadas.GetRowCellValue(i, "Zona").ToString
            xlHojaRechazadas.Cells(i + 4, 5) = gridViewRechazadas.GetRowCellValue(i, "NombreCalle").ToString
            xlHojaRechazadas.Cells(i + 4, 6) = gridViewRechazadas.GetRowCellValue(i, "Numero").ToString
            xlHojaRechazadas.Cells(i + 4, 7) = gridViewRechazadas.GetRowCellValue(i, "CasaDepto").ToString
            xlHojaRechazadas.Cells(i + 4, 8) = gridViewRechazadas.GetRowCellValue(i, "FechaViajes").ToString
            xlHojaRechazadas.Cells(i + 4, 9) = gridViewRechazadas.GetRowCellValue(i, "TipoDia").ToString
        Next

        'Guardar archivo
        xlWorkBook.SaveAs(dialogExcel.FileName, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue)
        xlWorkBook.Close(True, misValue, misValue)
        xlApp.Quit()

        MessageBox.Show("El resumen de encuestas en Excel se ha guardado en la ruta indicada", "Guardado exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information)

        'Liberar objetos en memoria
        releaseObject(xlHojaCompletas)
        releaseObject(xlHojaIncompletas)
        releaseObject(xlHojaInconsistentes)
        releaseObject(xlHojaRechazadas)
        releaseObject(xlWorkBook)
        releaseObject(xlApp)

        'Dim tablas As GridControl() = New GridControl() {gridCompletas, gridIncompletas}
        'Dim compositeLink As DevExpress.XtraPrintingLinks.CompositeLink = New DevExpress.XtraPrintingLinks.CompositeLink()
        'Dim ps As PrintingSystem = New PrintingSystem()
        'compositeLink.PrintingSystem = ps
        'For Each tabla As GridControl In tablas
        '    Dim link As PrintableComponentLink = New PrintableComponentLink()
        '    link.Component = tabla
        '    compositeLink.Links.Add(link)
        'Next
        'compositeLink.CreateDocument()
        'compositeLink.CreatePageForEachLink()
        'Dim opciones As XlsxExportOptions = New XlsxExportOptions
        'opciones.ExportMode = XlsxExportMode.SingleFilePageByPage
        'compositeLink.ExportToXlsx(dialogExcel.FileName, opciones)
    End Sub

    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

    Private Sub btnCopiarViajes_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCopiarViajes.ItemClick
        Try
            Dim folioActual As String = Me.gridViewHogares.GetFocusedRowCellValue("Hogar").ToString()
            Dim perActual As String = Me.gridViewPersonas.GetFocusedRowCellValue("Persona").ToString()
            Dim hogar As HogarRow = datasetEOD.Hogar.FindByHogar(folioActual)
            Dim tipoEncuesta As Integer = hogar.TipoDia

            Dim nuevaVentana As CopiarViajes = New CopiarViajes(folioActual, perActual, tipoEncuesta)
            nuevaVentana.ShowDialog()
        Catch ex As NullReferenceException

        End Try
    End Sub

    Private Sub btnCambioFolio_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCambioFolio.ItemClick
        If My.Settings.RolUsuario > 1 Then
            Me.HogaresNoEncuestadosTableAdapter.Fill(Me.datasetEOD.HogaresNoEncuestados)
            frameControlAvance.SelectedPageIndex = 5
        Else
            MessageBox.Show("Esta opción solo es accesible por un supervisor o administrador.", "Acción no permitida", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnActualizarFolio_Click(sender As Object, e As EventArgs) Handles btnActualizarFolio.Click
        Dim folioActual As Integer = Me.lkpFolioActual.EditValue
        Dim folioCorregido As Integer = Me.lkpFolioCorregido.EditValue

        If folioActual < 1 Then
            MessageBox.Show("No ha escogido la encuesta que desea corregir.", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf folioCorregido < 1 Then
            MessageBox.Show("No ha escogido el nuevo folio que asignará a la encuesta.", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                Dim filaHogar As datasetEOD.HogarRow
                filaHogar = Me.datasetEOD.Hogar.FindByHogar(folioActual)
                Dim filaValidador As datasetEOD.ValidaHogarRow
                filaValidador = Me.datasetEOD.ValidaHogar.FindByHogar(folioActual)

                filaHogar.Hogar = folioCorregido
                filaHogar.NombreCalle = txtCalleCorregida.Text
                filaHogar.Numero = txtNumeroCorregido.Text
                filaHogar.CasaDepto = txtCasaDeptoCorregido.Text
                filaHogar.Zona = txtZonaCorregida.Text
                filaHogar.Manzana = txtManzanaCorregida.Text
                filaHogar.Comuna = lkpComunaCorregida.EditValue

                filaValidador.Hogar = folioCorregido

                HogarTableAdapter.Update(Me.datasetEOD.Hogar)
                HogarTableAdapter.Fill(Me.datasetEOD.Hogar)
                ValidaHogarTableAdapter.Update(Me.datasetEOD.ValidaHogar)
                ValidaHogarTableAdapter.Fill(Me.datasetEOD.ValidaHogar)

                MessageBox.Show("Encuesta corregida exitosamente.", "Cambio de folio", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ribbonPrincipal.SelectedPage = ribbonPrincipal.Pages(0)
                frameControlAvance.SelectedPageIndex = 0
                framePrincipal.SelectedPageIndex = 0
            Catch ex As Exception
                MessageBox.Show("No se pudo guardar los cambios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            

        End If

    End Sub

    Private Sub lkpFolioActual_EditValueChanged(sender As Object, e As EventArgs) Handles lkpFolioActual.EditValueChanged
        Dim filaHogar As datasetEOD.HogarRow
        Try
            filaHogar = Me.datasetEOD.Hogar.FindByHogar(lkpFolioActual.EditValue)
            txtCalleActual.Text = filaHogar.NombreCalle
            txtNumeroActual.Text = filaHogar.Numero
            If Not filaHogar.IsCasaDeptoNull Then
                txtCasaDeptoActual.Text = filaHogar.CasaDepto
            End If
            txtZonaActual.Text = filaHogar.Zona
            txtManzanaActual.Text = filaHogar.Manzana
            lkpComunaActual.EditValue = filaHogar.Comuna
        Catch ex As Exception

        End Try
        
    End Sub

    Private Sub lkpFolioCorregido_EditValueChanged(sender As Object, e As EventArgs) Handles lkpFolioCorregido.EditValueChanged
        Dim filaHogar As datasetEOD.HogaresNoEncuestadosRow
        Try
            If lkpFolioCorregido.EditValue IsNot Nothing AndAlso lkpFolioCorregido.EditValue.ToString <> "" Then
                filaHogar = Me.datasetEOD.HogaresNoEncuestados.FindByIDFolio(lkpFolioCorregido.EditValue)
                txtCalleCorregida.Text = filaHogar.Calle
                txtNumeroCorregido.Text = filaHogar.Numero
                If Not filaHogar.IsCasaDeptoNull Then
                    txtCasaDeptoCorregido.Text = filaHogar.CasaDepto
                End If
                txtZonaCorregida.Text = filaHogar.ZonaEOD
                txtManzanaCorregida.Text = filaHogar.Manzana
                lkpComunaCorregida.EditValue = filaHogar.Comuna
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub lkpFolioDiaActual_EditValueChanged(sender As Object, e As EventArgs) Handles lkpFolioDiaActual.EditValueChanged
        Dim filaHogar As datasetEOD.HogarRow

        lblSabadoLVActual.Visible = False
        deSabadoLVActual.Visible = False
        lblDomingoLVActual.Visible = False
        deDomingoLVActual.Visible = False

        Try
            filaHogar = Me.datasetEOD.Hogar.FindByHogar(lkpFolioDiaActual.EditValue)
            txtCalleDiaActual.Text = filaHogar.NombreCalle
            txtNumeroDiaActual.Text = filaHogar.Numero
            If Not filaHogar.IsCasaDeptoNull Then
                txtCasaDeptoDiaActual.Text = filaHogar.CasaDepto
            End If
            txtZonaDiaActual.Text = filaHogar.Zona
            txtManzanaDiaActual.Text = filaHogar.Manzana
            lkpComunaDiaActual.EditValue = filaHogar.Comuna
            lkpTipoEncuestaDiaActual.EditValue = filaHogar.TipoDia

            Select Case filaHogar.TipoDia
                Case 1
                    deDiaViajesActual.EditValue = filaHogar.FechaViajesLab
                Case 2
                    deDiaViajesActual.EditValue = filaHogar.FechaViajesSab
                Case 3
                    deDiaViajesActual.EditValue = filaHogar.FechaViajesDom
                Case 4
                    lblSabadoLVActual.Visible = True
                    deSabadoLVActual.Visible = True
                    lblDomingoLVActual.Visible = True
                    deDomingoLVActual.Visible = True

                    deDiaViajesActual.EditValue = filaHogar.FechaViajesLab
                    deSabadoLVActual.EditValue = filaHogar.FechaViajesSab
                    deDomingoLVActual.EditValue = filaHogar.FechaViajesDom
            End Select


        Catch ex As Exception


        End Try
    End Sub

    Private Function fechaValida() As Boolean
        Dim valida As Boolean = True

        If (Not Me.lkpNuevoTipoEncuesta.EditValue Is Nothing) Then
            Dim tipoEncuesta As Integer
            Dim fechaSeleccionada As DateTime = deNuevoDiaViajes.EditValue
            Dim diaSemana As Integer

            If lkpNuevoTipoEncuesta.EditValue IsNot Nothing AndAlso lkpNuevoTipoEncuesta.EditValue.ToString <> "" Then
                tipoEncuesta = lkpNuevoTipoEncuesta.EditValue
                diaSemana = fechaSeleccionada.DayOfWeek

                Select Case tipoEncuesta
                    Case 1
                        If diaSemana < 1 Or diaSemana > 5 Then
                            valida = False
                        End If
                    Case 2
                        If diaSemana <> 6 Then
                            valida = False
                        End If
                    Case 3
                        If diaSemana <> 0 Then
                            valida = False
                        End If
                End Select
            Else
                valida = False
            End If
        Else
            valida = False
        End If

        Return valida
    End Function

    Private Sub btnCorregirDiaViajes_Click(sender As Object, e As EventArgs) Handles btnCorregirDiaViajes.Click
        'Validar datos completos

        If nuevoDiaCompleto() Then

            If fechaValida() Then
                Dim filaHogar As datasetEOD.HogarRow
                Try
                    filaHogar = Me.datasetEOD.Hogar.FindByHogar(lkpFolioDiaActual.EditValue)
                    filaHogar.TipoDia = lkpNuevoTipoEncuesta.EditValue
                    Select Case lkpNuevoTipoEncuesta.EditValue
                        Case 1
                            filaHogar.FechaViajesLab = deNuevoDiaViajes.EditValue
                            filaHogar.FechaViajesSab = Nothing
                            filaHogar.FechaViajesDom = Nothing
                        Case 2
                            filaHogar.FechaViajesSab = deNuevoDiaViajes.EditValue
                            filaHogar.FechaViajesLab = Nothing
                            filaHogar.FechaViajesDom = Nothing
                        Case 3
                            filaHogar.FechaViajesDom = deNuevoDiaViajes.EditValue
                            filaHogar.FechaViajesSab = Nothing
                            filaHogar.FechaViajesLab = Nothing
                        Case 4
                            filaHogar.FechaViajesLab = deNuevoDiaViajes.EditValue
                            filaHogar.FechaViajesSab = deNuevoSabadoLV.EditValue
                            filaHogar.FechaViajesDom = deNuevoDomingoLV.EditValue
                    End Select

                    If Not filaHogar.IsObservacionNull Then
                        filaHogar.Observacion = filaHogar.Observacion + vbCrLf + vbCrLf + txtMotivoCambio.Text
                    Else
                        filaHogar.Observacion = txtMotivoCambio.Text
                    End If



                    HogarTableAdapter.Update(Me.datasetEOD.Hogar)
                    HogarTableAdapter.Fill(Me.datasetEOD.Hogar)

                    MessageBox.Show("Encuesta corregida exitosamente.", "Cambio de Día de Viajes", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ribbonPrincipal.SelectedPage = ribbonPrincipal.Pages(0)
                    frameControlAvance.SelectedPageIndex = 0
                    framePrincipal.SelectedPageIndex = 0
                Catch ex As Exception
                    MessageBox.Show("No se pudo guardar los cambios." + vbCrLf + vbCrLf + "Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

                End Try
            Else
                MessageBox.Show("La fecha de viajes es inconsistente con el tipo de encuesta. Corrija para continuar.", "Datos no guardados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Por favor, complete los campos marcados con rojo para guardar los cambios.", "Datos insuficientes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Function nuevoDiaCompleto() As Boolean
        Dim completo As Boolean = True

        'Campo lkpNuevoTipoEncuesta
        If lkpNuevoTipoEncuesta.EditValue Is Nothing OrElse lkpNuevoTipoEncuesta.EditValue.ToString = "" OrElse lkpNuevoTipoEncuesta.EditValue < 1 Then
            completo = False
            lkpNuevoTipoEncuesta.Properties.Appearance.BorderColor = Color.Red
        Else
            lkpNuevoTipoEncuesta.Properties.Appearance.BorderColor = Nothing

            If lkpNuevoTipoEncuesta.EditValue = 4 Then
                'Campo deNuevoSabadoLV
                If deNuevoSabadoLV.EditValue Is Nothing OrElse deNuevoSabadoLV.EditValue.ToString = "" OrElse deNuevoSabadoLV.EditValue < 1 Then
                    completo = False
                    deNuevoSabadoLV.Properties.Appearance.BorderColor = Color.Red
                Else
                    deNuevoSabadoLV.Properties.Appearance.BorderColor = Nothing
                End If
            End If

        End If

        'Campo deNuevoDiaViajes
        If deNuevoDiaViajes.EditValue Is Nothing OrElse deNuevoDiaViajes.EditValue.ToString = "" Then
            completo = False
            deNuevoDiaViajes.Properties.Appearance.BorderColor = Color.Red
        Else
            deNuevoDiaViajes.Properties.Appearance.BorderColor = Nothing
        End If

        

        'Campo Motivo
        If txtMotivoCambio.Text = "" Then
            completo = False
            txtMotivoCambio.Properties.Appearance.BorderColor = Color.Red
        Else
            txtMotivoCambio.Properties.Appearance.BorderColor = Nothing
        End If

        Return completo
    End Function

    Private Sub btnCambiarDiaViajes_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCambiarDiaViajes.ItemClick
        If My.Settings.RolUsuario > 1 Then
            Me.TipoDiaTableAdapter.Fill(Me.datasetEOD.TipoDia)
            frameControlAvance.SelectedPageIndex = 6
        Else
            MessageBox.Show("Esta opción solo es accesible por un supervisor o administrador.", "Acción no permitida", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

End Class