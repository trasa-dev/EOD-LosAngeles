Imports EOD.datasetEOD

Public Class ResumenViajes

    Private hogar As Integer
    Private persona As Integer
    Private nombrePersona As String
    Private tipoEncuesta As Integer
    Private bloqueaRecarga As Boolean = False
    Private primeraCarga As Boolean = True

    Public Sub New(ByVal hogar As Integer, ByVal persona As Integer, ByVal nombrePersona As String, ByVal tipoEncuesta As Integer)
        InitializeComponent()

        Me.hogar = hogar
        Me.persona = persona
        Me.nombrePersona = nombrePersona
        Me.tipoEncuesta = tipoEncuesta

        Me.Text = "Viajes de " & Me.nombrePersona & " del hogar " & Me.hogar
    End Sub

    Private Sub ResumenViajes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ResumenViajesBindingSource.SuspendBinding()
        ResumenEtapasBindingSource.SuspendBinding()
        cargaDatosBackground.RunWorkerAsync()

        Select Case tipoEncuesta
            Case 1
                rgTipoDia.SelectedIndex = 0
                rgTipoDia.Properties.Items(1).Enabled = False
                rgTipoDia.Properties.Items(2).Enabled = False
            Case 2
                rgTipoDia.SelectedIndex = 1
                rgTipoDia.Properties.Items(0).Enabled = False
                rgTipoDia.Properties.Items(2).Enabled = False
            Case 3
                rgTipoDia.SelectedIndex = 2
                rgTipoDia.Properties.Items(0).Enabled = False
                rgTipoDia.Properties.Items(1).Enabled = False
            Case 4
                rgTipoDia.SelectedIndex = 0
        End Select

    End Sub

    Private Sub gridViewViajes_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gridViewViajes.FocusedRowChanged
        If Not Me.gridViewViajes.GetSelectedRows Is Nothing Then

            Me.gridEtapas.ForceInitialize()

            Try
                Dim viaje As Integer = Me.gridViewViajes.GetFocusedRowCellValue("Viaje").ToString()
                Dim tipoDia As Integer = 1

                Select Case tipoEncuesta
                    Case 2
                        tipoDia = 2
                    Case 3
                        tipoDia = 3
                    Case Else
                        tipoDia = 1
                End Select

                'Filtro gridViewEtapas
                Me.ResumenEtapasBindingSource.Filter = "Hogar = " & Me.hogar & " and Persona = " & Me.persona & " and viaje = " & viaje & " and diaviaje = " & tipoDia

            Catch ex As Exception

            End Try

        Else
        End If
    End Sub

    Private Sub btnModificarViaje_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnModificarViaje.ItemClick
        Dim viaje As Integer = Me.gridViewViajes.GetFocusedRowCellValue("Viaje").ToString()

        Dim nuevaVentana As ModificarViaje = New ModificarViaje(Me.hogar, Me.persona, viaje, Me.nombrePersona, Me.rgTipoDia.EditValue, tipoEncuesta)
        nuevaVentana.Show()
    End Sub

    Private Sub ResumenViajes_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        If Not bloqueaRecarga Then
            If Not cargaDatosBackground.IsBusy Then
                ResumenViajesBindingSource.SuspendBinding()
                ResumenEtapasBindingSource.SuspendBinding()
                cargaDatosBackground.RunWorkerAsync()
            End If
        Else
            bloqueaRecarga = False
        End If
        
    End Sub

    Private Sub cargaDatosBackground_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles cargaDatosBackground.DoWork
        Me.ResumenEtapasTableAdapter.FillBy(Me.datasetEOD.ResumenEtapas, hogar, persona)
        Me.ResumenViajesTableAdapter.FillBy(Me.datasetEOD.ResumenViajes, hogar, persona)
        PersonaTableAdapter.Fill(Me.datasetEOD.Persona)

       

    End Sub

    Private Sub btnIngresarViaje_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnIngresarViaje.ItemClick
        Dim persona As PersonaRow = Me.datasetEOD.Persona.FindByHogarPersona(Me.hogar, Me.persona)
        Dim maxViaje As Integer

        Select Case rgTipoDia.EditValue
            Case 1
                maxViaje = persona.ViajesLab
                Dim ventanaIngresoViajes As New IngresoViajes(hogar, Me.persona, maxViaje + 1, nombrePersona, 1, tipoEncuesta)
                ventanaIngresoViajes.Show()
            Case 2
                maxViaje = persona.ViajesSab
                Dim ventanaIngresoViajes As New IngresoViajes(hogar, Me.persona, maxViaje + 1, nombrePersona, 2, tipoEncuesta)
                ventanaIngresoViajes.Show()
            Case 3
                maxViaje = persona.ViajesDom
                Dim ventanaIngresoViajes As New IngresoViajes(hogar, Me.persona, maxViaje + 1, nombrePersona, 3, tipoEncuesta)
                ventanaIngresoViajes.Show()
        End Select

        
    End Sub

    Private Sub cargaDatosBackground_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles cargaDatosBackground.RunWorkerCompleted
        ResumenViajesBindingSource.ResumeBinding()
        ResumenEtapasBindingSource.ResumeBinding()

        Dim tipoDia As Integer = tipoEncuesta
        If tipoEncuesta = 4 Then
            tipoDia = 1
        End If

        Try
            Me.ResumenViajesBindingSource.Filter = "Hogar = " & Me.hogar & " and Persona = " & Me.persona & " and diaviaje = " & tipoDia
            Dim viaje As Integer = Me.gridViewViajes.GetFocusedRowCellValue("Viaje").ToString()
            Me.ResumenEtapasBindingSource.Filter = "Hogar = " & Me.hogar & " and Persona = " & Me.persona & " and diaviaje = " & tipoDia & " and viaje = " & viaje
        Catch ex As Exception
        End Try

    End Sub

    Private Sub rgTipoDia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles rgTipoDia.SelectedIndexChanged
        If primeraCarga Then
            primeraCarga = False
        Else
            Dim tipoDia As Integer = rgTipoDia.SelectedIndex + 1
            Try
                'Me.ResumenEtapasTableAdapter.FillBy(datasetEOD.ResumenEtapas, hogar, persona, tipoDia)
                'Me.ResumenViajesTableAdapter.FillBy(datasetEOD.ResumenViajes, hogar, persona, tipoDia)
                Me.ResumenViajesBindingSource.Filter = "Hogar = " & Me.hogar & " and Persona = " & Me.persona & " and diaviaje = " & tipoDia
                If Me.gridViewViajes.RowCount > 0 Then
                    Dim viaje As Integer = Me.gridViewViajes.GetFocusedRowCellValue("Viaje").ToString()
                    Me.ResumenEtapasBindingSource.Filter = "Hogar = " & Me.hogar & " and Persona = " & Me.persona & " and diaviaje = " & tipoDia & " and viaje = " & viaje
                Else
                    bloqueaRecarga = True
                    MessageBox.Show("El día seleccionado no tiene viajes", "Resumen Viajes", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Catch ex As Exception


            End Try
        End If
    End Sub

    Private Sub ResumenViajes_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        Me.datasetEOD.Clear()
        Me.datasetEOD1.Clear()
        releaseObject(datasetEOD)
        releaseObject(datasetEOD1)
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
End Class