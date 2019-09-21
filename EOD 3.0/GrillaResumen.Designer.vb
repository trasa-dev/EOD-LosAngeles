<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GrillaResumen
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GrillaResumen))
        Dim TimeRuler1 As DevExpress.XtraScheduler.TimeRuler = New DevExpress.XtraScheduler.TimeRuler()
        Dim TimeRuler2 As DevExpress.XtraScheduler.TimeRuler = New DevExpress.XtraScheduler.TimeRuler()
        Dim TimeRuler3 As DevExpress.XtraScheduler.TimeRuler = New DevExpress.XtraScheduler.TimeRuler()
        Dim IndicatorState1 As DevExpress.XtraGauges.Core.Model.IndicatorState = New DevExpress.XtraGauges.Core.Model.IndicatorState()
        Dim IndicatorState2 As DevExpress.XtraGauges.Core.Model.IndicatorState = New DevExpress.XtraGauges.Core.Model.IndicatorState()
        Dim IndicatorState3 As DevExpress.XtraGauges.Core.Model.IndicatorState = New DevExpress.XtraGauges.Core.Model.IndicatorState()
        Dim IndicatorState4 As DevExpress.XtraGauges.Core.Model.IndicatorState = New DevExpress.XtraGauges.Core.Model.IndicatorState()
        Dim IndicatorState5 As DevExpress.XtraGauges.Core.Model.IndicatorState = New DevExpress.XtraGauges.Core.Model.IndicatorState()
        Dim IndicatorState6 As DevExpress.XtraGauges.Core.Model.IndicatorState = New DevExpress.XtraGauges.Core.Model.IndicatorState()
        Dim IndicatorState7 As DevExpress.XtraGauges.Core.Model.IndicatorState = New DevExpress.XtraGauges.Core.Model.IndicatorState()
        Dim IndicatorState8 As DevExpress.XtraGauges.Core.Model.IndicatorState = New DevExpress.XtraGauges.Core.Model.IndicatorState()
        Me.GraficoEncuestadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.datasetEOD = New EOD.datasetEOD()
        Me.menuBackstage = New DevExpress.XtraBars.Ribbon.BackstageViewControl()
        Me.BarAndDockingController1 = New DevExpress.XtraBars.BarAndDockingController(Me.components)
        Me.hojaConfiguracion = New DevExpress.XtraBars.Ribbon.BackstageViewClientControl()
        Me.btnActualizar = New DevExpress.XtraEditors.SimpleButton()
        Me.lblVersion = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.btnGuardarConf = New DevExpress.XtraEditors.SimpleButton()
        Me.txtIDEquipo = New DevExpress.XtraEditors.TextEdit()
        Me.ribbonPrincipal = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnModificarHogar = New DevExpress.XtraBars.BarButtonItem()
        Me.btnEliminarHogar = New DevExpress.XtraBars.BarButtonItem()
        Me.btnAgregarPersona = New DevExpress.XtraBars.BarButtonItem()
        Me.btnModificarPersona = New DevExpress.XtraBars.BarButtonItem()
        Me.btnEliminarPersona = New DevExpress.XtraBars.BarButtonItem()
        Me.btnIngresarViajes = New DevExpress.XtraBars.BarButtonItem()
        Me.btnAgregarVehiculo = New DevExpress.XtraBars.BarButtonItem()
        Me.btnModificarVehiculo = New DevExpress.XtraBars.BarButtonItem()
        Me.btnEliminarVehiculo = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCuadroResumen = New DevExpress.XtraBars.BarButtonItem()
        Me.OpenScheduleItem1 = New DevExpress.XtraScheduler.UI.OpenScheduleItem()
        Me.SaveScheduleItem1 = New DevExpress.XtraScheduler.UI.SaveScheduleItem()
        Me.PrintPreviewItem1 = New DevExpress.XtraScheduler.UI.PrintPreviewItem()
        Me.PrintItem1 = New DevExpress.XtraScheduler.UI.PrintItem()
        Me.PrintPageSetupItem1 = New DevExpress.XtraScheduler.UI.PrintPageSetupItem()
        Me.NewAppointmentItem1 = New DevExpress.XtraScheduler.UI.NewAppointmentItem()
        Me.NewRecurringAppointmentItem1 = New DevExpress.XtraScheduler.UI.NewRecurringAppointmentItem()
        Me.NavigateViewBackwardItem1 = New DevExpress.XtraScheduler.UI.NavigateViewBackwardItem()
        Me.NavigateViewForwardItem1 = New DevExpress.XtraScheduler.UI.NavigateViewForwardItem()
        Me.GotoTodayItem1 = New DevExpress.XtraScheduler.UI.GotoTodayItem()
        Me.ViewZoomInItem1 = New DevExpress.XtraScheduler.UI.ViewZoomInItem()
        Me.ViewZoomOutItem1 = New DevExpress.XtraScheduler.UI.ViewZoomOutItem()
        Me.SwitchToDayViewItem1 = New DevExpress.XtraScheduler.UI.SwitchToDayViewItem()
        Me.SwitchToWeekViewItem1 = New DevExpress.XtraScheduler.UI.SwitchToWeekViewItem()
        Me.SwitchToFullWeekViewItem1 = New DevExpress.XtraScheduler.UI.SwitchToFullWeekViewItem()
        Me.SwitchToMonthViewItem1 = New DevExpress.XtraScheduler.UI.SwitchToMonthViewItem()
        Me.SwitchTimeScalesItem1 = New DevExpress.XtraScheduler.UI.SwitchTimeScalesItem()
        Me.ChangeScaleWidthItem1 = New DevExpress.XtraScheduler.UI.ChangeScaleWidthItem()
        Me.RepositoryItemSpinEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.SwitchTimeScalesCaptionItem1 = New DevExpress.XtraScheduler.UI.SwitchTimeScalesCaptionItem()
        Me.SwitchCompressWeekendItem1 = New DevExpress.XtraScheduler.UI.SwitchCompressWeekendItem()
        Me.SwitchShowWorkTimeOnlyItem1 = New DevExpress.XtraScheduler.UI.SwitchShowWorkTimeOnlyItem()
        Me.SwitchCellsAutoHeightItem1 = New DevExpress.XtraScheduler.UI.SwitchCellsAutoHeightItem()
        Me.ChangeSnapToCellsUIItem1 = New DevExpress.XtraScheduler.UI.ChangeSnapToCellsUIItem()
        Me.EditAppointmentQueryItem1 = New DevExpress.XtraScheduler.UI.EditAppointmentQueryItem()
        Me.EditOccurrenceUICommandItem1 = New DevExpress.XtraScheduler.UI.EditOccurrenceUICommandItem()
        Me.EditSeriesUICommandItem1 = New DevExpress.XtraScheduler.UI.EditSeriesUICommandItem()
        Me.DeleteAppointmentsItem1 = New DevExpress.XtraScheduler.UI.DeleteAppointmentsItem()
        Me.DeleteOccurrenceItem1 = New DevExpress.XtraScheduler.UI.DeleteOccurrenceItem()
        Me.DeleteSeriesItem1 = New DevExpress.XtraScheduler.UI.DeleteSeriesItem()
        Me.SplitAppointmentItem1 = New DevExpress.XtraScheduler.UI.SplitAppointmentItem()
        Me.ChangeAppointmentStatusItem1 = New DevExpress.XtraScheduler.UI.ChangeAppointmentStatusItem()
        Me.ChangeAppointmentLabelItem1 = New DevExpress.XtraScheduler.UI.ChangeAppointmentLabelItem()
        Me.ToggleRecurrenceItem1 = New DevExpress.XtraScheduler.UI.ToggleRecurrenceItem()
        Me.ChangeAppointmentReminderItem1 = New DevExpress.XtraScheduler.UI.ChangeAppointmentReminderItem()
        Me.RepositoryItemDuration1 = New DevExpress.XtraScheduler.UI.RepositoryItemDuration()
        Me.btnNuevoHogar = New DevExpress.XtraBars.BarButtonItem()
        Me.lkpTipoEncuestaMapa = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.TipoDiaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lkpSeleccionZonaMapa = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.btnSubirDatos = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCerrarSesion = New DevExpress.XtraBars.BarButtonItem()
        Me.btnValidar = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCompletas = New DevExpress.XtraBars.BarButtonItem()
        Me.btnIncompletas = New DevExpress.XtraBars.BarButtonItem()
        Me.btnInconsistentes = New DevExpress.XtraBars.BarButtonItem()
        Me.btnRechazadas = New DevExpress.XtraBars.BarButtonItem()
        Me.btnExportarExcel = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCopiarViajes = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCambioFolio = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCambiarDiaViajes = New DevExpress.XtraBars.BarButtonItem()
        Me.CalendarToolsRibbonPageCategory1 = New DevExpress.XtraScheduler.UI.CalendarToolsRibbonPageCategory()
        Me.pagEncuestas = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup4 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup3 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup6 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.pagControlAvance = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup5 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup7 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup8 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RepositoryItemRadioGroup1 = New DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup()
        Me.RepositoryItemRadioGroup2 = New DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup()
        Me.RepositoryItemToggleSwitch1 = New DevExpress.XtraEditors.Repository.RepositoryItemToggleSwitch()
        Me.RepositoryItemRadioGroup3 = New DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup()
        Me.RepositoryItemRadioGroup4 = New DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup()
        Me.RepositoryItemRadioGroup5 = New DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup()
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.txtUsuarioFTP = New DevExpress.XtraEditors.TextEdit()
        Me.txtClaveFTP = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtServidorFTP = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.itemConfig = New DevExpress.XtraBars.Ribbon.BackstageViewTabItem()
        Me.BackstageViewItemSeparator1 = New DevExpress.XtraBars.Ribbon.BackstageViewItemSeparator()
        Me.SchedulerStorage1 = New DevExpress.XtraScheduler.SchedulerStorage(Me.components)
        Me.ZonasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.gridHogares = New DevExpress.XtraGrid.GridControl()
        Me.ResumenHogaresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.gridViewHogares = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colHogar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colZona = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNombreCalle = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNumero = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCasaDepto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colComuna4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFechaVisita1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFecha = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTipoDia = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEstadoEncuesta = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGPS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ResumenHogaresTableAdapter = New EOD.datasetEODTableAdapters.ResumenHogaresTableAdapter()
        Me.grpHogares = New DevExpress.XtraEditors.GroupControl()
        Me.grpPersonas = New DevExpress.XtraEditors.GroupControl()
        Me.gridPersonas = New DevExpress.XtraGrid.GridControl()
        Me.ResumenPersonasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.gridViewPersonas = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colHogarPersona = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPersona = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNombrePila = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSexo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRelacion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEncuestadoLab = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEncuestadoSab = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEncuestadoDom = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEncuestado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ResumenPersonasTableAdapter = New EOD.datasetEODTableAdapters.ResumenPersonasTableAdapter()
        Me.cargaDatosBackground = New System.ComponentModel.BackgroundWorker()
        Me.DefaultLookAndFeel2 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
        Me.grpVehiculos = New DevExpress.XtraEditors.GroupControl()
        Me.gridVehiculos = New DevExpress.XtraGrid.GridControl()
        Me.ResumenVehiculosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.gridViewVehiculos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colVehículo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colvehiculo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCombustible = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ResumenVehiculosTableAdapter = New EOD.datasetEODTableAdapters.ResumenVehiculosTableAdapter()
        Me.framePrincipal = New DevExpress.XtraBars.Navigation.NavigationFrame()
        Me.navpageEncuestas = New DevExpress.XtraBars.Navigation.NavigationPage()
        Me.navpageControlAv = New DevExpress.XtraBars.Navigation.NavigationPage()
        Me.frameControlAvance = New DevExpress.XtraBars.Navigation.NavigationFrame()
        Me.panelCompletas = New DevExpress.XtraBars.Navigation.NavigationPage()
        Me.gcCompletas = New DevExpress.XtraEditors.GroupControl()
        Me.gridCompletas = New DevExpress.XtraGrid.GridControl()
        Me.ResumenHogaresCompletosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.gridViewCompletas = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colHogar2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colZona1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colComuna1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNombreCalle1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNumero1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCasaDepto1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFecha1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTipoDia1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.panelIncompletas = New DevExpress.XtraBars.Navigation.NavigationPage()
        Me.gcIncompletas = New DevExpress.XtraEditors.GroupControl()
        Me.gridIncompletas = New DevExpress.XtraGrid.GridControl()
        Me.ResumenHogaresIncompletosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.gridViewIncompletas = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colHogar3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colZona2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colComuna2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNombreCalle2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNumero2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCasaDepto2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFecha2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTipoDia2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEstadoEncuesta2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.panelInconsistentes = New DevExpress.XtraBars.Navigation.NavigationPage()
        Me.gcInconsistentes = New DevExpress.XtraEditors.GroupControl()
        Me.gridInconsistentes = New DevExpress.XtraGrid.GridControl()
        Me.ResumenHogaresInconsistentesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.gridViewInconsistentes = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colHogar4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colZona4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colComuna3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNombreCalle4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNumero4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCasaDepto4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFechaViajes1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTipoDia4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.panelRechazos = New DevExpress.XtraBars.Navigation.NavigationPage()
        Me.gcRechazos = New DevExpress.XtraEditors.GroupControl()
        Me.gridRechazadas = New DevExpress.XtraGrid.GridControl()
        Me.ResumenHogaresRechazadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.gridViewRechazadas = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colHogar1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colZona3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colComuna = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNombreCalle3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNumero3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCasaDepto3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFechaViajes = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTipoDia3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEstadoEncuesta1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.panelResumenAvance = New DevExpress.XtraBars.Navigation.NavigationPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.calendarioAvance = New DevExpress.XtraScheduler.SchedulerControl()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.lblEncuestasRechazadas = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl()
        Me.lblEncuestasInconsistentes = New DevExpress.XtraEditors.LabelControl()
        Me.PictureEdit5 = New DevExpress.XtraEditors.PictureEdit()
        Me.PictureEdit6 = New DevExpress.XtraEditors.PictureEdit()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.lblEncuestasIncompletas = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.lblEncuestasCompletas = New DevExpress.XtraEditors.LabelControl()
        Me.PictureEdit3 = New DevExpress.XtraEditors.PictureEdit()
        Me.PictureEdit4 = New DevExpress.XtraEditors.PictureEdit()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.lblEncuestasRecogerHoy = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.lblPersonasEncuestarDia = New DevExpress.XtraEditors.LabelControl()
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        Me.PictureEdit2 = New DevExpress.XtraEditors.PictureEdit()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.semaforoCarga = New DevExpress.XtraGauges.Win.GaugeControl()
        Me.indicadorSemaforo = New DevExpress.XtraGauges.Win.Gauges.State.StateIndicatorGauge()
        Me.StateIndicatorComponent2 = New DevExpress.XtraGauges.Win.Gauges.State.StateIndicatorComponent()
        Me.lblMensajeEnvio = New DevExpress.XtraEditors.LabelControl()
        Me.lblUltimaExportacion = New DevExpress.XtraEditors.LabelControl()
        Me.pageCambioFolio = New DevExpress.XtraBars.Navigation.NavigationPage()
        Me.gcCambioFolio = New DevExpress.XtraEditors.GroupControl()
        Me.btnCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnActualizarFolio = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl23 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl24 = New DevExpress.XtraEditors.LabelControl()
        Me.txtZonaCorregida = New DevExpress.XtraEditors.TextEdit()
        Me.txtManzanaCorregida = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl25 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl26 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl27 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCalleCorregida = New DevExpress.XtraEditors.TextEdit()
        Me.txtNumeroCorregido = New DevExpress.XtraEditors.TextEdit()
        Me.txtCasaDeptoCorregido = New DevExpress.XtraEditors.TextEdit()
        Me.lkpComunaCorregida = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.ComunaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.lkpFolioCorregido = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.FolioNuevoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colIDFolio = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelControl29 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lkpFolioActual = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.FolioActualBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colHogar5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl17 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl18 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl19 = New DevExpress.XtraEditors.LabelControl()
        Me.txtZonaActual = New DevExpress.XtraEditors.TextEdit()
        Me.txtManzanaActual = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl22 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl21 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl20 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCalleActual = New DevExpress.XtraEditors.TextEdit()
        Me.txtNumeroActual = New DevExpress.XtraEditors.TextEdit()
        Me.txtCasaDeptoActual = New DevExpress.XtraEditors.TextEdit()
        Me.lkpComunaActual = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridLookUpEdit2View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.NavigationPage1 = New DevExpress.XtraBars.Navigation.NavigationPage()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCorregirDiaViajes = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.LabelControl31 = New DevExpress.XtraEditors.LabelControl()
        Me.txtMotivoCambio = New DevExpress.XtraEditors.MemoEdit()
        Me.deNuevoDomingoLV = New DevExpress.XtraEditors.DateEdit()
        Me.lblDomingoLV = New DevExpress.XtraEditors.LabelControl()
        Me.deNuevoSabadoLV = New DevExpress.XtraEditors.DateEdit()
        Me.lblSabadoLV = New DevExpress.XtraEditors.LabelControl()
        Me.deNuevoDiaViajes = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl43 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl28 = New DevExpress.XtraEditors.LabelControl()
        Me.lkpNuevoTipoEncuesta = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.deDomingoLVActual = New DevExpress.XtraEditors.DateEdit()
        Me.lblDomingoLVActual = New DevExpress.XtraEditors.LabelControl()
        Me.deSabadoLVActual = New DevExpress.XtraEditors.DateEdit()
        Me.lblSabadoLVActual = New DevExpress.XtraEditors.LabelControl()
        Me.deDiaViajesActual = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl34 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl30 = New DevExpress.XtraEditors.LabelControl()
        Me.lkpTipoEncuestaDiaActual = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.lkpFolioDiaActual = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView5 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelControl36 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl37 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl38 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl39 = New DevExpress.XtraEditors.LabelControl()
        Me.txtZonaDiaActual = New DevExpress.XtraEditors.TextEdit()
        Me.txtManzanaDiaActual = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl40 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl41 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl42 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCalleDiaActual = New DevExpress.XtraEditors.TextEdit()
        Me.txtNumeroDiaActual = New DevExpress.XtraEditors.TextEdit()
        Me.txtCasaDeptoDiaActual = New DevExpress.XtraEditors.TextEdit()
        Me.lkpComunaDiaActual = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView6 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.EncuestasPorEstadoTableAdapter = New EOD.datasetEODTableAdapters.EncuestasPorEstadoTableAdapter()
        Me.EncuestasPorEstadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ResumenHogaresIncompletosTableAdapter = New EOD.datasetEODTableAdapters.ResumenHogaresIncompletosTableAdapter()
        Me.ResumenHogaresCompletosTableAdapter = New EOD.datasetEODTableAdapters.ResumenHogaresCompletosTableAdapter()
        Me.SchedulerBarController1 = New DevExpress.XtraScheduler.UI.SchedulerBarController()
        Me.ZonasTableAdapter = New EOD.datasetEODTableAdapters.ZonasTableAdapter()
        Me.HogarTableAdapter = New EOD.datasetEODTableAdapters.HogarTableAdapter()
        Me.PersonaTableAdapter = New EOD.datasetEODTableAdapters.PersonaTableAdapter()
        Me.VehiculoTableAdapter = New EOD.datasetEODTableAdapters.VehiculoTableAdapter()
        Me.ValidaHogarTableAdapter = New EOD.datasetEODTableAdapters.ValidaHogarTableAdapter()
        Me.ValidaPersonaTableAdapter = New EOD.datasetEODTableAdapters.ValidaPersonaTableAdapter()
        Me.GraficoEncuestadosTableAdapter = New EOD.datasetEODTableAdapters.GraficoEncuestadosTableAdapter()
        Me.ResumenHogaresInconsistentesTableAdapter = New EOD.datasetEODTableAdapters.ResumenHogaresInconsistentesTableAdapter()
        Me.ResumenHogaresRechazadosTableAdapter = New EOD.datasetEODTableAdapters.ResumenHogaresRechazadosTableAdapter()
        Me.LabelComponent1 = New DevExpress.XtraGauges.Win.Base.LabelComponent()
        Me.ArcScaleComponent1 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
        Me.ArcScaleRangeBarComponent1 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleRangeBarComponent()
        Me.TipoDiaTableAdapter = New EOD.datasetEODTableAdapters.TipoDiaTableAdapter()
        Me.StateIndicatorComponent1 = New DevExpress.XtraGauges.Win.Gauges.State.StateIndicatorComponent()
        Me.ExportacionesDataTableAdapter = New EOD.datasetEODTableAdapters.ExportacionesDataTableAdapter()
        Me.EncuestasRecogerHoyTableAdapter = New EOD.datasetEODTableAdapters.EncuestasRecogerHoyTableAdapter()
        Me.UltimaExportacionTableAdapter = New EOD.datasetEODTableAdapters.UltimaExportacionTableAdapter()
        Me.PersonasEncuestarHoyTableAdapter = New EOD.datasetEODTableAdapters.PersonasEncuestarHoyTableAdapter()
        Me.EncuestasRecoger1DiaTableAdapter = New EOD.datasetEODTableAdapters.EncuestasRecoger1DiaTableAdapter()
        Me.EncuestasRecoger2DiasTableAdapter = New EOD.datasetEODTableAdapters.EncuestasRecoger2DiasTableAdapter()
        Me.EncuestasRecogerMas2DiasTableAdapter = New EOD.datasetEODTableAdapters.EncuestasRecogerMas2DiasTableAdapter()
        Me.PersonasEncuestarHoyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EncuestasRecogerHoyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EncuestasRecoger2DiasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EncuestasRecoger1DiaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EncuestasRecogerMas2DiasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EncuestasRecogerSemanaTableAdapter = New EOD.datasetEODTableAdapters.EncuestasRecogerSemanaTableAdapter()
        Me.EncuestasRecogerSemanaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dialogExcel = New System.Windows.Forms.SaveFileDialog()
        Me.ComunaTableAdapter = New EOD.datasetEODTableAdapters.ComunaTableAdapter()
        Me.HogaresNoEncuestadosTableAdapter = New EOD.datasetEODTableAdapters.HogaresNoEncuestadosTableAdapter()
        Me.colTipoDia5 = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.GraficoEncuestadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.datasetEOD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.menuBackstage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.menuBackstage.SuspendLayout()
        CType(Me.BarAndDockingController1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.hojaConfiguracion.SuspendLayout()
        CType(Me.txtIDEquipo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ribbonPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDuration1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TipoDiaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemRadioGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemRadioGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemToggleSwitch1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemRadioGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemRadioGroup4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemRadioGroup5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUsuarioFTP.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtClaveFTP.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtServidorFTP.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SchedulerStorage1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ZonasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridHogares, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ResumenHogaresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridViewHogares, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpHogares, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpHogares.SuspendLayout()
        CType(Me.grpPersonas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpPersonas.SuspendLayout()
        CType(Me.gridPersonas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ResumenPersonasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridViewPersonas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpVehiculos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpVehiculos.SuspendLayout()
        CType(Me.gridVehiculos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ResumenVehiculosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridViewVehiculos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.framePrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.framePrincipal.SuspendLayout()
        Me.navpageEncuestas.SuspendLayout()
        Me.navpageControlAv.SuspendLayout()
        CType(Me.frameControlAvance, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.frameControlAvance.SuspendLayout()
        Me.panelCompletas.SuspendLayout()
        CType(Me.gcCompletas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gcCompletas.SuspendLayout()
        CType(Me.gridCompletas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ResumenHogaresCompletosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridViewCompletas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelIncompletas.SuspendLayout()
        CType(Me.gcIncompletas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gcIncompletas.SuspendLayout()
        CType(Me.gridIncompletas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ResumenHogaresIncompletosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridViewIncompletas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelInconsistentes.SuspendLayout()
        CType(Me.gcInconsistentes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gcInconsistentes.SuspendLayout()
        CType(Me.gridInconsistentes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ResumenHogaresInconsistentesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridViewInconsistentes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelRechazos.SuspendLayout()
        CType(Me.gcRechazos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gcRechazos.SuspendLayout()
        CType(Me.gridRechazadas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ResumenHogaresRechazadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridViewRechazadas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelResumenAvance.SuspendLayout()
        CType(Me.calendarioAvance, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.PictureEdit5.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEdit6.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEdit4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.indicadorSemaforo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StateIndicatorComponent2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pageCambioFolio.SuspendLayout()
        CType(Me.gcCambioFolio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gcCambioFolio.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.txtZonaCorregida.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtManzanaCorregida.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCalleCorregida.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNumeroCorregido.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCasaDeptoCorregido.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkpComunaCorregida.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComunaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkpFolioCorregido.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FolioNuevoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.lkpFolioActual.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FolioActualBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtZonaActual.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtManzanaActual.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCalleActual.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNumeroActual.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCasaDeptoActual.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkpComunaActual.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit2View, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NavigationPage1.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.txtMotivoCambio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deNuevoDomingoLV.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deNuevoDomingoLV.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deNuevoSabadoLV.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deNuevoSabadoLV.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deNuevoDiaViajes.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deNuevoDiaViajes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkpNuevoTipoEncuesta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.deDomingoLVActual.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deDomingoLVActual.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deSabadoLVActual.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deSabadoLVActual.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deDiaViajesActual.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deDiaViajesActual.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkpTipoEncuestaDiaActual.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkpFolioDiaActual.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtZonaDiaActual.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtManzanaDiaActual.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCalleDiaActual.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNumeroDiaActual.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCasaDeptoDiaActual.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkpComunaDiaActual.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EncuestasPorEstadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SchedulerBarController1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LabelComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArcScaleComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArcScaleRangeBarComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StateIndicatorComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PersonasEncuestarHoyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EncuestasRecogerHoyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EncuestasRecoger2DiasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EncuestasRecoger1DiaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EncuestasRecogerMas2DiasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EncuestasRecogerSemanaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GraficoEncuestadosBindingSource
        '
        Me.GraficoEncuestadosBindingSource.DataMember = "GraficoEncuestados"
        Me.GraficoEncuestadosBindingSource.DataSource = Me.datasetEOD
        '
        'datasetEOD
        '
        Me.datasetEOD.DataSetName = "datasetEOD"
        Me.datasetEOD.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'menuBackstage
        '
        Me.menuBackstage.Controller = Me.BarAndDockingController1
        Me.menuBackstage.Controls.Add(Me.hojaConfiguracion)
        Me.menuBackstage.Items.Add(Me.itemConfig)
        Me.menuBackstage.Items.Add(Me.BackstageViewItemSeparator1)
        Me.menuBackstage.Location = New System.Drawing.Point(389, 103)
        Me.menuBackstage.Name = "menuBackstage"
        Me.menuBackstage.OwnerControl = Me.ribbonPrincipal
        Me.menuBackstage.SelectedTab = Me.itemConfig
        Me.menuBackstage.SelectedTabIndex = 0
        Me.menuBackstage.Size = New System.Drawing.Size(951, 485)
        Me.menuBackstage.TabIndex = 2
        '
        'BarAndDockingController1
        '
        Me.BarAndDockingController1.LookAndFeel.SkinName = "Office 2016 Colorful"
        Me.BarAndDockingController1.PropertiesBar.AllowLinkLighting = False
        Me.BarAndDockingController1.PropertiesBar.DefaultGlyphSize = New System.Drawing.Size(16, 16)
        Me.BarAndDockingController1.PropertiesBar.DefaultLargeGlyphSize = New System.Drawing.Size(32, 32)
        '
        'hojaConfiguracion
        '
        Me.hojaConfiguracion.Controls.Add(Me.btnActualizar)
        Me.hojaConfiguracion.Controls.Add(Me.lblVersion)
        Me.hojaConfiguracion.Controls.Add(Me.LabelControl12)
        Me.hojaConfiguracion.Controls.Add(Me.LabelControl10)
        Me.hojaConfiguracion.Controls.Add(Me.btnGuardarConf)
        Me.hojaConfiguracion.Controls.Add(Me.txtIDEquipo)
        Me.hojaConfiguracion.Controls.Add(Me.LabelControl6)
        Me.hojaConfiguracion.Controls.Add(Me.LabelControl7)
        Me.hojaConfiguracion.Controls.Add(Me.txtUsuarioFTP)
        Me.hojaConfiguracion.Controls.Add(Me.txtClaveFTP)
        Me.hojaConfiguracion.Controls.Add(Me.LabelControl4)
        Me.hojaConfiguracion.Controls.Add(Me.LabelControl3)
        Me.hojaConfiguracion.Controls.Add(Me.txtServidorFTP)
        Me.hojaConfiguracion.Controls.Add(Me.LabelControl2)
        Me.hojaConfiguracion.Controls.Add(Me.LabelControl1)
        Me.hojaConfiguracion.Location = New System.Drawing.Point(181, 63)
        Me.hojaConfiguracion.Name = "hojaConfiguracion"
        Me.hojaConfiguracion.Size = New System.Drawing.Size(769, 421)
        Me.hojaConfiguracion.TabIndex = 3
        '
        'btnActualizar
        '
        Me.btnActualizar.Appearance.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnActualizar.Appearance.ForeColor = System.Drawing.Color.White
        Me.btnActualizar.Appearance.Options.UseBackColor = True
        Me.btnActualizar.Appearance.Options.UseForeColor = True
        Me.btnActualizar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
        Me.btnActualizar.Location = New System.Drawing.Point(449, 130)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(151, 36)
        Me.btnActualizar.TabIndex = 16
        Me.btnActualizar.Text = "Comprobar actualizaciones"
        '
        'lblVersion
        '
        Me.lblVersion.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblVersion.Appearance.Options.UseFont = True
        Me.lblVersion.Location = New System.Drawing.Point(505, 83)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(51, 13)
        Me.lblVersion.TabIndex = 15
        Me.lblVersion.Text = "1.0.0.120"
        '
        'LabelControl12
        '
        Me.LabelControl12.Location = New System.Drawing.Point(454, 83)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(39, 13)
        Me.LabelControl12.TabIndex = 14
        Me.LabelControl12.Text = "Versión:"
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl10.Appearance.Options.UseFont = True
        Me.LabelControl10.Location = New System.Drawing.Point(449, 8)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(112, 45)
        Me.LabelControl10.TabIndex = 13
        Me.LabelControl10.Text = "EOD 3.0"
        '
        'btnGuardarConf
        '
        Me.btnGuardarConf.Appearance.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnGuardarConf.Appearance.ForeColor = System.Drawing.Color.White
        Me.btnGuardarConf.Appearance.Options.UseBackColor = True
        Me.btnGuardarConf.Appearance.Options.UseForeColor = True
        Me.btnGuardarConf.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
        Me.btnGuardarConf.Location = New System.Drawing.Point(279, 325)
        Me.btnGuardarConf.Name = "btnGuardarConf"
        Me.btnGuardarConf.Size = New System.Drawing.Size(108, 36)
        Me.btnGuardarConf.TabIndex = 12
        Me.btnGuardarConf.Text = "Guardar cambios"
        '
        'txtIDEquipo
        '
        Me.txtIDEquipo.EditValue = ""
        Me.txtIDEquipo.Location = New System.Drawing.Point(116, 272)
        Me.txtIDEquipo.MenuManager = Me.ribbonPrincipal
        Me.txtIDEquipo.Name = "txtIDEquipo"
        Me.txtIDEquipo.Properties.Mask.EditMask = "d"
        Me.txtIDEquipo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtIDEquipo.Size = New System.Drawing.Size(120, 20)
        Me.txtIDEquipo.TabIndex = 10
        '
        'ribbonPrincipal
        '
        Me.ribbonPrincipal.ApplicationButtonDropDownControl = Me.menuBackstage
        Me.ribbonPrincipal.Controller = Me.BarAndDockingController1
        Me.ribbonPrincipal.ExpandCollapseItem.Id = 0
        Me.ribbonPrincipal.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ribbonPrincipal.ExpandCollapseItem, Me.btnModificarHogar, Me.btnEliminarHogar, Me.btnAgregarPersona, Me.btnModificarPersona, Me.btnEliminarPersona, Me.btnIngresarViajes, Me.btnAgregarVehiculo, Me.btnModificarVehiculo, Me.btnEliminarVehiculo, Me.btnCuadroResumen, Me.OpenScheduleItem1, Me.SaveScheduleItem1, Me.PrintPreviewItem1, Me.PrintItem1, Me.PrintPageSetupItem1, Me.NewAppointmentItem1, Me.NewRecurringAppointmentItem1, Me.NavigateViewBackwardItem1, Me.NavigateViewForwardItem1, Me.GotoTodayItem1, Me.ViewZoomInItem1, Me.ViewZoomOutItem1, Me.SwitchToDayViewItem1, Me.SwitchToWeekViewItem1, Me.SwitchToFullWeekViewItem1, Me.SwitchToMonthViewItem1, Me.SwitchTimeScalesItem1, Me.ChangeScaleWidthItem1, Me.SwitchTimeScalesCaptionItem1, Me.SwitchCompressWeekendItem1, Me.SwitchShowWorkTimeOnlyItem1, Me.SwitchCellsAutoHeightItem1, Me.ChangeSnapToCellsUIItem1, Me.EditAppointmentQueryItem1, Me.EditOccurrenceUICommandItem1, Me.EditSeriesUICommandItem1, Me.DeleteAppointmentsItem1, Me.DeleteOccurrenceItem1, Me.DeleteSeriesItem1, Me.SplitAppointmentItem1, Me.ChangeAppointmentStatusItem1, Me.ChangeAppointmentLabelItem1, Me.ToggleRecurrenceItem1, Me.ChangeAppointmentReminderItem1, Me.btnNuevoHogar, Me.lkpTipoEncuestaMapa, Me.lkpSeleccionZonaMapa, Me.btnSubirDatos, Me.btnCerrarSesion, Me.btnValidar, Me.btnCompletas, Me.btnIncompletas, Me.btnInconsistentes, Me.btnRechazadas, Me.btnExportarExcel, Me.btnCopiarViajes, Me.btnCambioFolio, Me.btnCambiarDiaViajes})
        Me.ribbonPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.ribbonPrincipal.MaxItemId = 297
        Me.ribbonPrincipal.Name = "ribbonPrincipal"
        Me.ribbonPrincipal.PageCategories.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageCategory() {Me.CalendarToolsRibbonPageCategory1})
        Me.ribbonPrincipal.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.pagEncuestas, Me.pagControlAvance})
        Me.ribbonPrincipal.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemSpinEdit1, Me.RepositoryItemDuration1, Me.RepositoryItemRadioGroup1, Me.RepositoryItemRadioGroup2, Me.RepositoryItemToggleSwitch1, Me.RepositoryItemRadioGroup3, Me.RepositoryItemRadioGroup4, Me.RepositoryItemRadioGroup5, Me.RepositoryItemDateEdit1, Me.RepositoryItemLookUpEdit1, Me.RepositoryItemLookUpEdit2})
        Me.ribbonPrincipal.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013
        Me.ribbonPrincipal.ShowCategoryInCaption = False
        Me.ribbonPrincipal.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.ribbonPrincipal.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.[True]
        Me.ribbonPrincipal.ShowQatLocationSelector = False
        Me.ribbonPrincipal.ShowToolbarCustomizeItem = False
        Me.ribbonPrincipal.Size = New System.Drawing.Size(1022, 165)
        Me.ribbonPrincipal.Toolbar.ShowCustomizeItem = False
        '
        'btnModificarHogar
        '
        Me.btnModificarHogar.Caption = "Modificar"
        Me.btnModificarHogar.Id = 1
        Me.btnModificarHogar.ImageOptions.Image = CType(resources.GetObject("btnModificarHogar.ImageOptions.Image"), System.Drawing.Image)
        Me.btnModificarHogar.ImageOptions.LargeImage = CType(resources.GetObject("btnModificarHogar.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnModificarHogar.Name = "btnModificarHogar"
        Me.btnModificarHogar.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'btnEliminarHogar
        '
        Me.btnEliminarHogar.Caption = "Eliminar"
        Me.btnEliminarHogar.Id = 2
        Me.btnEliminarHogar.ImageOptions.Image = CType(resources.GetObject("btnEliminarHogar.ImageOptions.Image"), System.Drawing.Image)
        Me.btnEliminarHogar.Name = "btnEliminarHogar"
        Me.btnEliminarHogar.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'btnAgregarPersona
        '
        Me.btnAgregarPersona.Caption = "Agregar"
        Me.btnAgregarPersona.Id = 3
        Me.btnAgregarPersona.ImageOptions.Image = CType(resources.GetObject("btnAgregarPersona.ImageOptions.Image"), System.Drawing.Image)
        Me.btnAgregarPersona.Name = "btnAgregarPersona"
        Me.btnAgregarPersona.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'btnModificarPersona
        '
        Me.btnModificarPersona.Caption = "Modificar"
        Me.btnModificarPersona.Id = 4
        Me.btnModificarPersona.ImageOptions.Image = CType(resources.GetObject("btnModificarPersona.ImageOptions.Image"), System.Drawing.Image)
        Me.btnModificarPersona.Name = "btnModificarPersona"
        Me.btnModificarPersona.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'btnEliminarPersona
        '
        Me.btnEliminarPersona.Caption = "Eliminar"
        Me.btnEliminarPersona.Id = 5
        Me.btnEliminarPersona.ImageOptions.Image = CType(resources.GetObject("btnEliminarPersona.ImageOptions.Image"), System.Drawing.Image)
        Me.btnEliminarPersona.Name = "btnEliminarPersona"
        Me.btnEliminarPersona.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'btnIngresarViajes
        '
        Me.btnIngresarViajes.Caption = "Contestar encuesta de viajes"
        Me.btnIngresarViajes.Id = 6
        Me.btnIngresarViajes.ImageOptions.Image = CType(resources.GetObject("btnIngresarViajes.ImageOptions.Image"), System.Drawing.Image)
        Me.btnIngresarViajes.Name = "btnIngresarViajes"
        Me.btnIngresarViajes.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'btnAgregarVehiculo
        '
        Me.btnAgregarVehiculo.Caption = "Agregar"
        Me.btnAgregarVehiculo.Id = 8
        Me.btnAgregarVehiculo.ImageOptions.Image = CType(resources.GetObject("btnAgregarVehiculo.ImageOptions.Image"), System.Drawing.Image)
        Me.btnAgregarVehiculo.Name = "btnAgregarVehiculo"
        Me.btnAgregarVehiculo.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'btnModificarVehiculo
        '
        Me.btnModificarVehiculo.Caption = "Modificar"
        Me.btnModificarVehiculo.Id = 9
        Me.btnModificarVehiculo.ImageOptions.Image = CType(resources.GetObject("btnModificarVehiculo.ImageOptions.Image"), System.Drawing.Image)
        Me.btnModificarVehiculo.Name = "btnModificarVehiculo"
        Me.btnModificarVehiculo.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'btnEliminarVehiculo
        '
        Me.btnEliminarVehiculo.Caption = "Eliminar"
        Me.btnEliminarVehiculo.Id = 10
        Me.btnEliminarVehiculo.ImageOptions.Image = CType(resources.GetObject("btnEliminarVehiculo.ImageOptions.Image"), System.Drawing.Image)
        Me.btnEliminarVehiculo.Name = "btnEliminarVehiculo"
        Me.btnEliminarVehiculo.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'btnCuadroResumen
        '
        Me.btnCuadroResumen.Caption = "Cuadro resumen"
        Me.btnCuadroResumen.Id = 14
        Me.btnCuadroResumen.ImageOptions.Image = CType(resources.GetObject("btnCuadroResumen.ImageOptions.Image"), System.Drawing.Image)
        Me.btnCuadroResumen.ImageOptions.LargeImage = CType(resources.GetObject("btnCuadroResumen.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnCuadroResumen.Name = "btnCuadroResumen"
        '
        'OpenScheduleItem1
        '
        Me.OpenScheduleItem1.Id = 227
        Me.OpenScheduleItem1.Name = "OpenScheduleItem1"
        '
        'SaveScheduleItem1
        '
        Me.SaveScheduleItem1.Id = 228
        Me.SaveScheduleItem1.Name = "SaveScheduleItem1"
        '
        'PrintPreviewItem1
        '
        Me.PrintPreviewItem1.Id = 229
        Me.PrintPreviewItem1.Name = "PrintPreviewItem1"
        '
        'PrintItem1
        '
        Me.PrintItem1.Id = 230
        Me.PrintItem1.Name = "PrintItem1"
        '
        'PrintPageSetupItem1
        '
        Me.PrintPageSetupItem1.Id = 231
        Me.PrintPageSetupItem1.Name = "PrintPageSetupItem1"
        '
        'NewAppointmentItem1
        '
        Me.NewAppointmentItem1.Id = 232
        Me.NewAppointmentItem1.Name = "NewAppointmentItem1"
        '
        'NewRecurringAppointmentItem1
        '
        Me.NewRecurringAppointmentItem1.Id = 233
        Me.NewRecurringAppointmentItem1.Name = "NewRecurringAppointmentItem1"
        '
        'NavigateViewBackwardItem1
        '
        Me.NavigateViewBackwardItem1.Id = 234
        Me.NavigateViewBackwardItem1.Name = "NavigateViewBackwardItem1"
        '
        'NavigateViewForwardItem1
        '
        Me.NavigateViewForwardItem1.Id = 235
        Me.NavigateViewForwardItem1.Name = "NavigateViewForwardItem1"
        '
        'GotoTodayItem1
        '
        Me.GotoTodayItem1.Id = 236
        Me.GotoTodayItem1.Name = "GotoTodayItem1"
        '
        'ViewZoomInItem1
        '
        Me.ViewZoomInItem1.Id = 237
        Me.ViewZoomInItem1.Name = "ViewZoomInItem1"
        '
        'ViewZoomOutItem1
        '
        Me.ViewZoomOutItem1.Id = 238
        Me.ViewZoomOutItem1.Name = "ViewZoomOutItem1"
        '
        'SwitchToDayViewItem1
        '
        Me.SwitchToDayViewItem1.Id = 239
        Me.SwitchToDayViewItem1.Name = "SwitchToDayViewItem1"
        '
        'SwitchToWeekViewItem1
        '
        Me.SwitchToWeekViewItem1.Id = 241
        Me.SwitchToWeekViewItem1.Name = "SwitchToWeekViewItem1"
        '
        'SwitchToFullWeekViewItem1
        '
        Me.SwitchToFullWeekViewItem1.Id = 242
        Me.SwitchToFullWeekViewItem1.Name = "SwitchToFullWeekViewItem1"
        '
        'SwitchToMonthViewItem1
        '
        Me.SwitchToMonthViewItem1.Id = 243
        Me.SwitchToMonthViewItem1.Name = "SwitchToMonthViewItem1"
        '
        'SwitchTimeScalesItem1
        '
        Me.SwitchTimeScalesItem1.Id = 249
        Me.SwitchTimeScalesItem1.Name = "SwitchTimeScalesItem1"
        '
        'ChangeScaleWidthItem1
        '
        Me.ChangeScaleWidthItem1.Edit = Me.RepositoryItemSpinEdit1
        Me.ChangeScaleWidthItem1.Id = 250
        Me.ChangeScaleWidthItem1.Name = "ChangeScaleWidthItem1"
        Me.ChangeScaleWidthItem1.UseCommandCaption = True
        '
        'RepositoryItemSpinEdit1
        '
        Me.RepositoryItemSpinEdit1.AutoHeight = False
        Me.RepositoryItemSpinEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemSpinEdit1.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.RepositoryItemSpinEdit1.LookAndFeel.SkinName = "Office 2016 Colorful"
        Me.RepositoryItemSpinEdit1.MaxValue = New Decimal(New Integer() {200, 0, 0, 0})
        Me.RepositoryItemSpinEdit1.MinValue = New Decimal(New Integer() {10, 0, 0, 0})
        Me.RepositoryItemSpinEdit1.Name = "RepositoryItemSpinEdit1"
        '
        'SwitchTimeScalesCaptionItem1
        '
        Me.SwitchTimeScalesCaptionItem1.Id = 251
        Me.SwitchTimeScalesCaptionItem1.Name = "SwitchTimeScalesCaptionItem1"
        '
        'SwitchCompressWeekendItem1
        '
        Me.SwitchCompressWeekendItem1.Id = 252
        Me.SwitchCompressWeekendItem1.Name = "SwitchCompressWeekendItem1"
        '
        'SwitchShowWorkTimeOnlyItem1
        '
        Me.SwitchShowWorkTimeOnlyItem1.Id = 253
        Me.SwitchShowWorkTimeOnlyItem1.Name = "SwitchShowWorkTimeOnlyItem1"
        '
        'SwitchCellsAutoHeightItem1
        '
        Me.SwitchCellsAutoHeightItem1.Id = 254
        Me.SwitchCellsAutoHeightItem1.Name = "SwitchCellsAutoHeightItem1"
        '
        'ChangeSnapToCellsUIItem1
        '
        Me.ChangeSnapToCellsUIItem1.Id = 255
        Me.ChangeSnapToCellsUIItem1.Name = "ChangeSnapToCellsUIItem1"
        '
        'EditAppointmentQueryItem1
        '
        Me.EditAppointmentQueryItem1.Id = 256
        Me.EditAppointmentQueryItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.EditOccurrenceUICommandItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.EditSeriesUICommandItem1)})
        Me.EditAppointmentQueryItem1.Name = "EditAppointmentQueryItem1"
        Me.EditAppointmentQueryItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'EditOccurrenceUICommandItem1
        '
        Me.EditOccurrenceUICommandItem1.Id = 257
        Me.EditOccurrenceUICommandItem1.Name = "EditOccurrenceUICommandItem1"
        '
        'EditSeriesUICommandItem1
        '
        Me.EditSeriesUICommandItem1.Id = 258
        Me.EditSeriesUICommandItem1.Name = "EditSeriesUICommandItem1"
        '
        'DeleteAppointmentsItem1
        '
        Me.DeleteAppointmentsItem1.Id = 259
        Me.DeleteAppointmentsItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.DeleteOccurrenceItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.DeleteSeriesItem1)})
        Me.DeleteAppointmentsItem1.Name = "DeleteAppointmentsItem1"
        Me.DeleteAppointmentsItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'DeleteOccurrenceItem1
        '
        Me.DeleteOccurrenceItem1.Id = 260
        Me.DeleteOccurrenceItem1.Name = "DeleteOccurrenceItem1"
        '
        'DeleteSeriesItem1
        '
        Me.DeleteSeriesItem1.Id = 261
        Me.DeleteSeriesItem1.Name = "DeleteSeriesItem1"
        '
        'SplitAppointmentItem1
        '
        Me.SplitAppointmentItem1.Id = 262
        Me.SplitAppointmentItem1.Name = "SplitAppointmentItem1"
        '
        'ChangeAppointmentStatusItem1
        '
        Me.ChangeAppointmentStatusItem1.Id = 263
        Me.ChangeAppointmentStatusItem1.Name = "ChangeAppointmentStatusItem1"
        '
        'ChangeAppointmentLabelItem1
        '
        Me.ChangeAppointmentLabelItem1.Id = 264
        Me.ChangeAppointmentLabelItem1.Name = "ChangeAppointmentLabelItem1"
        '
        'ToggleRecurrenceItem1
        '
        Me.ToggleRecurrenceItem1.Id = 265
        Me.ToggleRecurrenceItem1.Name = "ToggleRecurrenceItem1"
        '
        'ChangeAppointmentReminderItem1
        '
        Me.ChangeAppointmentReminderItem1.Edit = Me.RepositoryItemDuration1
        Me.ChangeAppointmentReminderItem1.Id = 266
        Me.ChangeAppointmentReminderItem1.Name = "ChangeAppointmentReminderItem1"
        '
        'RepositoryItemDuration1
        '
        Me.RepositoryItemDuration1.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.RepositoryItemDuration1.AutoHeight = False
        Me.RepositoryItemDuration1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDuration1.DisabledStateText = Nothing
        Me.RepositoryItemDuration1.LookAndFeel.SkinName = "Office 2016 Colorful"
        Me.RepositoryItemDuration1.Name = "RepositoryItemDuration1"
        Me.RepositoryItemDuration1.NullValuePromptShowForEmptyValue = True
        Me.RepositoryItemDuration1.ShowEmptyItem = True
        Me.RepositoryItemDuration1.ValidateOnEnterKey = True
        '
        'btnNuevoHogar
        '
        Me.btnNuevoHogar.Caption = "Nueva encuesta"
        Me.btnNuevoHogar.Id = 268
        Me.btnNuevoHogar.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[False]
        Me.btnNuevoHogar.ImageOptions.Image = CType(resources.GetObject("btnNuevoHogar.ImageOptions.Image"), System.Drawing.Image)
        Me.btnNuevoHogar.ImageOptions.LargeImage = CType(resources.GetObject("btnNuevoHogar.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnNuevoHogar.Name = "btnNuevoHogar"
        '
        'lkpTipoEncuestaMapa
        '
        Me.lkpTipoEncuestaMapa.Caption = "Filtrar por tipo"
        Me.lkpTipoEncuestaMapa.Edit = Me.RepositoryItemLookUpEdit1
        Me.lkpTipoEncuestaMapa.EditWidth = 100
        Me.lkpTipoEncuestaMapa.Id = 282
        Me.lkpTipoEncuestaMapa.Name = "lkpTipoEncuestaMapa"
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("TipoDia", "TipoDia")})
        Me.RepositoryItemLookUpEdit1.DataSource = Me.TipoDiaBindingSource
        Me.RepositoryItemLookUpEdit1.DisplayMember = "TipoDia"
        Me.RepositoryItemLookUpEdit1.LookAndFeel.SkinName = "Office 2016 Colorful"
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        Me.RepositoryItemLookUpEdit1.ShowFooter = False
        Me.RepositoryItemLookUpEdit1.ShowHeader = False
        Me.RepositoryItemLookUpEdit1.ValueMember = "ID"
        '
        'TipoDiaBindingSource
        '
        Me.TipoDiaBindingSource.DataMember = "TipoDia"
        Me.TipoDiaBindingSource.DataSource = Me.datasetEOD
        '
        'lkpSeleccionZonaMapa
        '
        Me.lkpSeleccionZonaMapa.Caption = "Filtrar por zona"
        Me.lkpSeleccionZonaMapa.Edit = Me.RepositoryItemLookUpEdit2
        Me.lkpSeleccionZonaMapa.EditWidth = 115
        Me.lkpSeleccionZonaMapa.Id = 283
        Me.lkpSeleccionZonaMapa.Name = "lkpSeleccionZonaMapa"
        '
        'RepositoryItemLookUpEdit2
        '
        Me.RepositoryItemLookUpEdit2.AutoHeight = False
        Me.RepositoryItemLookUpEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit2.DisplayMember = "Zona"
        Me.RepositoryItemLookUpEdit2.LookAndFeel.SkinName = "Office 2016 Colorful"
        Me.RepositoryItemLookUpEdit2.Name = "RepositoryItemLookUpEdit2"
        Me.RepositoryItemLookUpEdit2.ValueMember = "Zona"
        '
        'btnSubirDatos
        '
        Me.btnSubirDatos.Caption = "Subir datos a servidor"
        Me.btnSubirDatos.Id = 286
        Me.btnSubirDatos.ImageOptions.Image = CType(resources.GetObject("btnSubirDatos.ImageOptions.Image"), System.Drawing.Image)
        Me.btnSubirDatos.ImageOptions.LargeImage = CType(resources.GetObject("btnSubirDatos.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnSubirDatos.Name = "btnSubirDatos"
        Me.btnSubirDatos.RibbonStyle = CType((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText), DevExpress.XtraBars.Ribbon.RibbonItemStyles)
        '
        'btnCerrarSesion
        '
        Me.btnCerrarSesion.Caption = "Cerrar sesión"
        Me.btnCerrarSesion.Id = 287
        Me.btnCerrarSesion.ImageOptions.Image = CType(resources.GetObject("btnCerrarSesion.ImageOptions.Image"), System.Drawing.Image)
        Me.btnCerrarSesion.ImageOptions.LargeImage = CType(resources.GetObject("btnCerrarSesion.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnCerrarSesion.Name = "btnCerrarSesion"
        '
        'btnValidar
        '
        Me.btnValidar.Caption = "Validar encuestas"
        Me.btnValidar.Id = 288
        Me.btnValidar.ImageOptions.Image = CType(resources.GetObject("btnValidar.ImageOptions.Image"), System.Drawing.Image)
        Me.btnValidar.ImageOptions.LargeImage = CType(resources.GetObject("btnValidar.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnValidar.Name = "btnValidar"
        '
        'btnCompletas
        '
        Me.btnCompletas.Caption = "Completas"
        Me.btnCompletas.Id = 289
        Me.btnCompletas.ImageOptions.Image = CType(resources.GetObject("btnCompletas.ImageOptions.Image"), System.Drawing.Image)
        Me.btnCompletas.ImageOptions.LargeImage = CType(resources.GetObject("btnCompletas.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnCompletas.Name = "btnCompletas"
        '
        'btnIncompletas
        '
        Me.btnIncompletas.Caption = "Incompletas"
        Me.btnIncompletas.Id = 290
        Me.btnIncompletas.ImageOptions.Image = CType(resources.GetObject("btnIncompletas.ImageOptions.Image"), System.Drawing.Image)
        Me.btnIncompletas.ImageOptions.LargeImage = CType(resources.GetObject("btnIncompletas.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnIncompletas.Name = "btnIncompletas"
        '
        'btnInconsistentes
        '
        Me.btnInconsistentes.Caption = "Inconsistentes"
        Me.btnInconsistentes.Id = 291
        Me.btnInconsistentes.ImageOptions.Image = CType(resources.GetObject("btnInconsistentes.ImageOptions.Image"), System.Drawing.Image)
        Me.btnInconsistentes.ImageOptions.LargeImage = CType(resources.GetObject("btnInconsistentes.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnInconsistentes.Name = "btnInconsistentes"
        '
        'btnRechazadas
        '
        Me.btnRechazadas.Caption = "Rechazadas"
        Me.btnRechazadas.Id = 292
        Me.btnRechazadas.ImageOptions.Image = CType(resources.GetObject("btnRechazadas.ImageOptions.Image"), System.Drawing.Image)
        Me.btnRechazadas.ImageOptions.LargeImage = CType(resources.GetObject("btnRechazadas.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnRechazadas.Name = "btnRechazadas"
        '
        'btnExportarExcel
        '
        Me.btnExportarExcel.Caption = "Exportar resumen a Excel"
        Me.btnExportarExcel.Id = 293
        Me.btnExportarExcel.ImageOptions.Image = CType(resources.GetObject("btnExportarExcel.ImageOptions.Image"), System.Drawing.Image)
        Me.btnExportarExcel.ImageOptions.LargeImage = CType(resources.GetObject("btnExportarExcel.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnExportarExcel.Name = "btnExportarExcel"
        '
        'btnCopiarViajes
        '
        Me.btnCopiarViajes.Caption = "Copiar Viajes"
        Me.btnCopiarViajes.Id = 294
        Me.btnCopiarViajes.ImageOptions.Image = CType(resources.GetObject("btnCopiarViajes.ImageOptions.Image"), System.Drawing.Image)
        Me.btnCopiarViajes.ImageOptions.LargeImage = CType(resources.GetObject("btnCopiarViajes.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnCopiarViajes.Name = "btnCopiarViajes"
        '
        'btnCambioFolio
        '
        Me.btnCambioFolio.Caption = "Cambiar Folio"
        Me.btnCambioFolio.Id = 295
        Me.btnCambioFolio.ImageOptions.Image = CType(resources.GetObject("btnCambioFolio.ImageOptions.Image"), System.Drawing.Image)
        Me.btnCambioFolio.ImageOptions.LargeImage = CType(resources.GetObject("btnCambioFolio.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnCambioFolio.Name = "btnCambioFolio"
        '
        'btnCambiarDiaViajes
        '
        Me.btnCambiarDiaViajes.Caption = "Corregir Día de Viajes"
        Me.btnCambiarDiaViajes.Id = 296
        Me.btnCambiarDiaViajes.ImageOptions.Image = CType(resources.GetObject("btnCambiarDiaViajes.ImageOptions.Image"), System.Drawing.Image)
        Me.btnCambiarDiaViajes.ImageOptions.LargeImage = CType(resources.GetObject("btnCambiarDiaViajes.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnCambiarDiaViajes.Name = "btnCambiarDiaViajes"
        '
        'CalendarToolsRibbonPageCategory1
        '
        Me.CalendarToolsRibbonPageCategory1.Control = Nothing
        Me.CalendarToolsRibbonPageCategory1.Name = "CalendarToolsRibbonPageCategory1"
        Me.CalendarToolsRibbonPageCategory1.Visible = False
        '
        'pagEncuestas
        '
        Me.pagEncuestas.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1, Me.RibbonPageGroup2, Me.RibbonPageGroup4, Me.RibbonPageGroup3, Me.RibbonPageGroup6})
        Me.pagEncuestas.Image = CType(resources.GetObject("pagEncuestas.Image"), System.Drawing.Image)
        Me.pagEncuestas.Name = "pagEncuestas"
        Me.pagEncuestas.Text = "Encuestas"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.AllowTextClipping = False
        Me.RibbonPageGroup1.Glyph = CType(resources.GetObject("RibbonPageGroup1.Glyph"), System.Drawing.Image)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnNuevoHogar)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnModificarHogar)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnEliminarHogar)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.ShowCaptionButton = False
        Me.RibbonPageGroup1.Text = "Hogar"
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.AllowTextClipping = False
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnAgregarPersona)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnModificarPersona)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnEliminarPersona)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.ShowCaptionButton = False
        Me.RibbonPageGroup2.Text = "Personas"
        '
        'RibbonPageGroup4
        '
        Me.RibbonPageGroup4.AllowTextClipping = False
        Me.RibbonPageGroup4.ItemLinks.Add(Me.btnIngresarViajes)
        Me.RibbonPageGroup4.ItemLinks.Add(Me.btnCopiarViajes)
        Me.RibbonPageGroup4.Name = "RibbonPageGroup4"
        Me.RibbonPageGroup4.ShowCaptionButton = False
        Me.RibbonPageGroup4.Text = "Viajes"
        '
        'RibbonPageGroup3
        '
        Me.RibbonPageGroup3.AllowTextClipping = False
        Me.RibbonPageGroup3.ItemLinks.Add(Me.btnAgregarVehiculo)
        Me.RibbonPageGroup3.ItemLinks.Add(Me.btnModificarVehiculo)
        Me.RibbonPageGroup3.ItemLinks.Add(Me.btnEliminarVehiculo)
        Me.RibbonPageGroup3.Name = "RibbonPageGroup3"
        Me.RibbonPageGroup3.ShowCaptionButton = False
        Me.RibbonPageGroup3.Text = "Vehículos"
        '
        'RibbonPageGroup6
        '
        Me.RibbonPageGroup6.ItemLinks.Add(Me.btnSubirDatos)
        Me.RibbonPageGroup6.ItemLinks.Add(Me.btnCerrarSesion)
        Me.RibbonPageGroup6.Name = "RibbonPageGroup6"
        Me.RibbonPageGroup6.ShowCaptionButton = False
        Me.RibbonPageGroup6.Text = "Acciones"
        '
        'pagControlAvance
        '
        Me.pagControlAvance.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup5, Me.RibbonPageGroup7, Me.RibbonPageGroup8})
        Me.pagControlAvance.Image = CType(resources.GetObject("pagControlAvance.Image"), System.Drawing.Image)
        Me.pagControlAvance.Name = "pagControlAvance"
        Me.pagControlAvance.Text = "Control de Avance"
        '
        'RibbonPageGroup5
        '
        Me.RibbonPageGroup5.AllowTextClipping = False
        Me.RibbonPageGroup5.ItemLinks.Add(Me.btnCuadroResumen)
        Me.RibbonPageGroup5.ItemLinks.Add(Me.lkpSeleccionZonaMapa)
        Me.RibbonPageGroup5.ItemLinks.Add(Me.lkpTipoEncuestaMapa)
        Me.RibbonPageGroup5.Name = "RibbonPageGroup5"
        Me.RibbonPageGroup5.ShowCaptionButton = False
        Me.RibbonPageGroup5.Text = "Avance de encuestas"
        '
        'RibbonPageGroup7
        '
        Me.RibbonPageGroup7.ItemLinks.Add(Me.btnCompletas)
        Me.RibbonPageGroup7.ItemLinks.Add(Me.btnIncompletas)
        Me.RibbonPageGroup7.ItemLinks.Add(Me.btnInconsistentes)
        Me.RibbonPageGroup7.ItemLinks.Add(Me.btnRechazadas)
        Me.RibbonPageGroup7.Name = "RibbonPageGroup7"
        Me.RibbonPageGroup7.ShowCaptionButton = False
        Me.RibbonPageGroup7.Text = "Encuestas por estado"
        '
        'RibbonPageGroup8
        '
        Me.RibbonPageGroup8.ItemLinks.Add(Me.btnValidar)
        Me.RibbonPageGroup8.ItemLinks.Add(Me.btnExportarExcel)
        Me.RibbonPageGroup8.ItemLinks.Add(Me.btnCambioFolio)
        Me.RibbonPageGroup8.ItemLinks.Add(Me.btnCambiarDiaViajes)
        Me.RibbonPageGroup8.Name = "RibbonPageGroup8"
        Me.RibbonPageGroup8.ShowCaptionButton = False
        Me.RibbonPageGroup8.Text = "Herramientas"
        '
        'RepositoryItemRadioGroup1
        '
        Me.RepositoryItemRadioGroup1.LookAndFeel.SkinName = "Office 2016 Colorful"
        Me.RepositoryItemRadioGroup1.Name = "RepositoryItemRadioGroup1"
        '
        'RepositoryItemRadioGroup2
        '
        Me.RepositoryItemRadioGroup2.LookAndFeel.SkinName = "Office 2016 Colorful"
        Me.RepositoryItemRadioGroup2.Name = "RepositoryItemRadioGroup2"
        '
        'RepositoryItemToggleSwitch1
        '
        Me.RepositoryItemToggleSwitch1.AutoHeight = False
        Me.RepositoryItemToggleSwitch1.LookAndFeel.SkinName = "Office 2016 Colorful"
        Me.RepositoryItemToggleSwitch1.Name = "RepositoryItemToggleSwitch1"
        Me.RepositoryItemToggleSwitch1.OffText = "Off"
        Me.RepositoryItemToggleSwitch1.OnText = "On"
        '
        'RepositoryItemRadioGroup3
        '
        Me.RepositoryItemRadioGroup3.LookAndFeel.SkinName = "Office 2016 Colorful"
        Me.RepositoryItemRadioGroup3.Name = "RepositoryItemRadioGroup3"
        '
        'RepositoryItemRadioGroup4
        '
        Me.RepositoryItemRadioGroup4.Columns = 1
        Me.RepositoryItemRadioGroup4.LookAndFeel.SkinName = "Office 2016 Colorful"
        Me.RepositoryItemRadioGroup4.Name = "RepositoryItemRadioGroup4"
        '
        'RepositoryItemRadioGroup5
        '
        Me.RepositoryItemRadioGroup5.LookAndFeel.SkinName = "Office 2016 Colorful"
        Me.RepositoryItemRadioGroup5.Name = "RepositoryItemRadioGroup5"
        '
        'RepositoryItemDateEdit1
        '
        Me.RepositoryItemDateEdit1.AutoHeight = False
        Me.RepositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.CalendarTimeProperties.LookAndFeel.SkinName = "Office 2016 Colorful"
        Me.RepositoryItemDateEdit1.Name = "RepositoryItemDateEdit1"
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(42, 275)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(46, 13)
        Me.LabelControl6.TabIndex = 9
        Me.LabelControl6.Text = "ID Equipo"
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl7.Appearance.Options.UseFont = True
        Me.LabelControl7.Location = New System.Drawing.Point(42, 200)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(345, 45)
        Me.LabelControl7.TabIndex = 8
        Me.LabelControl7.Text = "Identificación de equipo"
        '
        'txtUsuarioFTP
        '
        Me.txtUsuarioFTP.EditValue = "dataeod@trasa.cl"
        Me.txtUsuarioFTP.Location = New System.Drawing.Point(116, 116)
        Me.txtUsuarioFTP.MenuManager = Me.ribbonPrincipal
        Me.txtUsuarioFTP.Name = "txtUsuarioFTP"
        Me.txtUsuarioFTP.Size = New System.Drawing.Size(120, 20)
        Me.txtUsuarioFTP.TabIndex = 7
        '
        'txtClaveFTP
        '
        Me.txtClaveFTP.EditValue = "DSV1249"
        Me.txtClaveFTP.Location = New System.Drawing.Point(116, 150)
        Me.txtClaveFTP.MenuManager = Me.ribbonPrincipal
        Me.txtClaveFTP.Name = "txtClaveFTP"
        Me.txtClaveFTP.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtClaveFTP.Size = New System.Drawing.Size(120, 20)
        Me.txtClaveFTP.TabIndex = 6
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(42, 153)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(56, 13)
        Me.LabelControl4.TabIndex = 4
        Me.LabelControl4.Text = "Contraseña"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(42, 119)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(57, 13)
        Me.LabelControl3.TabIndex = 3
        Me.LabelControl3.Text = "Usuario FTP"
        '
        'txtServidorFTP
        '
        Me.txtServidorFTP.EditValue = "ftp.trasa.cl"
        Me.txtServidorFTP.Location = New System.Drawing.Point(116, 80)
        Me.txtServidorFTP.MenuManager = Me.ribbonPrincipal
        Me.txtServidorFTP.Name = "txtServidorFTP"
        Me.txtServidorFTP.Size = New System.Drawing.Size(120, 20)
        Me.txtServidorFTP.TabIndex = 2
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(42, 83)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(19, 13)
        Me.LabelControl2.TabIndex = 1
        Me.LabelControl2.Text = "URL"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(42, 8)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(194, 45)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Conexión FTP"
        '
        'itemConfig
        '
        Me.itemConfig.Caption = "Configuración"
        Me.itemConfig.ContentControl = Me.hojaConfiguracion
        Me.itemConfig.Glyph = CType(resources.GetObject("itemConfig.Glyph"), System.Drawing.Image)
        Me.itemConfig.Name = "itemConfig"
        Me.itemConfig.Selected = True
        '
        'BackstageViewItemSeparator1
        '
        Me.BackstageViewItemSeparator1.Name = "BackstageViewItemSeparator1"
        '
        'SchedulerStorage1
        '
        Me.SchedulerStorage1.Appointments.CommitIdToDataSource = True
        '
        'ZonasBindingSource
        '
        Me.ZonasBindingSource.DataMember = "Zonas"
        Me.ZonasBindingSource.DataSource = Me.datasetEOD
        '
        'gridHogares
        '
        Me.gridHogares.DataSource = Me.ResumenHogaresBindingSource
        Me.gridHogares.Location = New System.Drawing.Point(13, 24)
        Me.gridHogares.MainView = Me.gridViewHogares
        Me.gridHogares.MenuManager = Me.ribbonPrincipal
        Me.gridHogares.Name = "gridHogares"
        Me.gridHogares.Size = New System.Drawing.Size(970, 164)
        Me.gridHogares.TabIndex = 4
        Me.gridHogares.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridViewHogares})
        '
        'ResumenHogaresBindingSource
        '
        Me.ResumenHogaresBindingSource.DataMember = "ResumenHogares"
        Me.ResumenHogaresBindingSource.DataSource = Me.datasetEOD
        Me.ResumenHogaresBindingSource.Sort = "Hogar ASC"
        '
        'gridViewHogares
        '
        Me.gridViewHogares.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colHogar, Me.colZona, Me.colNombreCalle, Me.colNumero, Me.colCasaDepto, Me.colComuna4, Me.colFechaVisita1, Me.colFecha, Me.colTipoDia, Me.colEstadoEncuesta, Me.colGPS})
        Me.gridViewHogares.GridControl = Me.gridHogares
        Me.gridViewHogares.Name = "gridViewHogares"
        Me.gridViewHogares.OptionsView.ShowGroupPanel = False
        Me.gridViewHogares.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colFecha, DevExpress.Data.ColumnSortOrder.Descending)})
        '
        'colHogar
        '
        Me.colHogar.FieldName = "Hogar"
        Me.colHogar.Name = "colHogar"
        Me.colHogar.OptionsColumn.AllowEdit = False
        Me.colHogar.Visible = True
        Me.colHogar.VisibleIndex = 0
        Me.colHogar.Width = 74
        '
        'colZona
        '
        Me.colZona.FieldName = "Zona"
        Me.colZona.Name = "colZona"
        Me.colZona.OptionsColumn.AllowEdit = False
        Me.colZona.Visible = True
        Me.colZona.VisibleIndex = 1
        Me.colZona.Width = 34
        '
        'colNombreCalle
        '
        Me.colNombreCalle.FieldName = "NombreCalle"
        Me.colNombreCalle.Name = "colNombreCalle"
        Me.colNombreCalle.OptionsColumn.AllowEdit = False
        Me.colNombreCalle.Visible = True
        Me.colNombreCalle.VisibleIndex = 2
        Me.colNombreCalle.Width = 153
        '
        'colNumero
        '
        Me.colNumero.FieldName = "Numero"
        Me.colNumero.Name = "colNumero"
        Me.colNumero.OptionsColumn.AllowEdit = False
        Me.colNumero.Visible = True
        Me.colNumero.VisibleIndex = 3
        Me.colNumero.Width = 46
        '
        'colCasaDepto
        '
        Me.colCasaDepto.FieldName = "CasaDepto"
        Me.colCasaDepto.Name = "colCasaDepto"
        Me.colCasaDepto.OptionsColumn.AllowEdit = False
        Me.colCasaDepto.Visible = True
        Me.colCasaDepto.VisibleIndex = 4
        Me.colCasaDepto.Width = 69
        '
        'colComuna4
        '
        Me.colComuna4.FieldName = "Comuna"
        Me.colComuna4.Name = "colComuna4"
        Me.colComuna4.OptionsColumn.AllowEdit = False
        Me.colComuna4.Visible = True
        Me.colComuna4.VisibleIndex = 5
        Me.colComuna4.Width = 64
        '
        'colFechaVisita1
        '
        Me.colFechaVisita1.Caption = "Fecha Visita 1"
        Me.colFechaVisita1.FieldName = "FechaVisita1"
        Me.colFechaVisita1.Name = "colFechaVisita1"
        Me.colFechaVisita1.OptionsColumn.AllowEdit = False
        Me.colFechaVisita1.Visible = True
        Me.colFechaVisita1.VisibleIndex = 6
        '
        'colFecha
        '
        Me.colFecha.Caption = "Fecha Viajes"
        Me.colFecha.FieldName = "FechaViajes"
        Me.colFecha.Name = "colFecha"
        Me.colFecha.OptionsColumn.AllowEdit = False
        Me.colFecha.Visible = True
        Me.colFecha.VisibleIndex = 7
        Me.colFecha.Width = 85
        '
        'colTipoDia
        '
        Me.colTipoDia.FieldName = "TipoDia"
        Me.colTipoDia.Name = "colTipoDia"
        Me.colTipoDia.OptionsColumn.AllowEdit = False
        Me.colTipoDia.Visible = True
        Me.colTipoDia.VisibleIndex = 8
        Me.colTipoDia.Width = 51
        '
        'colEstadoEncuesta
        '
        Me.colEstadoEncuesta.FieldName = "EstadoEncuesta"
        Me.colEstadoEncuesta.Name = "colEstadoEncuesta"
        Me.colEstadoEncuesta.OptionsColumn.AllowEdit = False
        Me.colEstadoEncuesta.Visible = True
        Me.colEstadoEncuesta.VisibleIndex = 9
        Me.colEstadoEncuesta.Width = 211
        '
        'colGPS
        '
        Me.colGPS.Caption = "Waypoint"
        Me.colGPS.FieldName = "GPS"
        Me.colGPS.Name = "colGPS"
        Me.colGPS.OptionsColumn.AllowEdit = False
        Me.colGPS.UnboundType = DevExpress.Data.UnboundColumnType.[Boolean]
        Me.colGPS.Visible = True
        Me.colGPS.VisibleIndex = 10
        Me.colGPS.Width = 87
        '
        'ResumenHogaresTableAdapter
        '
        Me.ResumenHogaresTableAdapter.ClearBeforeFill = True
        '
        'grpHogares
        '
        Me.grpHogares.Controls.Add(Me.gridHogares)
        Me.grpHogares.Location = New System.Drawing.Point(12, 6)
        Me.grpHogares.Name = "grpHogares"
        Me.grpHogares.Size = New System.Drawing.Size(998, 204)
        Me.grpHogares.TabIndex = 7
        Me.grpHogares.Text = "Hogares"
        '
        'grpPersonas
        '
        Me.grpPersonas.Controls.Add(Me.gridPersonas)
        Me.grpPersonas.Location = New System.Drawing.Point(12, 216)
        Me.grpPersonas.Name = "grpPersonas"
        Me.grpPersonas.Size = New System.Drawing.Size(648, 166)
        Me.grpPersonas.TabIndex = 8
        Me.grpPersonas.Text = "Personas del hogar"
        '
        'gridPersonas
        '
        Me.gridPersonas.DataSource = Me.ResumenPersonasBindingSource
        Me.gridPersonas.Location = New System.Drawing.Point(13, 24)
        Me.gridPersonas.MainView = Me.gridViewPersonas
        Me.gridPersonas.MenuManager = Me.ribbonPrincipal
        Me.gridPersonas.Name = "gridPersonas"
        Me.gridPersonas.Size = New System.Drawing.Size(623, 129)
        Me.gridPersonas.TabIndex = 0
        Me.gridPersonas.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridViewPersonas})
        '
        'ResumenPersonasBindingSource
        '
        Me.ResumenPersonasBindingSource.DataMember = "ResumenPersonas"
        Me.ResumenPersonasBindingSource.DataSource = Me.datasetEOD
        Me.ResumenPersonasBindingSource.Filter = "Hogar = 0"
        Me.ResumenPersonasBindingSource.Sort = "Persona ASC"
        '
        'gridViewPersonas
        '
        Me.gridViewPersonas.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colHogarPersona, Me.colPersona, Me.colNombrePila, Me.colSexo, Me.colRelacion, Me.colEncuestadoLab, Me.colEncuestadoSab, Me.colEncuestadoDom, Me.colEncuestado})
        Me.gridViewPersonas.GridControl = Me.gridPersonas
        Me.gridViewPersonas.Name = "gridViewPersonas"
        Me.gridViewPersonas.OptionsView.ShowGroupPanel = False
        '
        'colHogarPersona
        '
        Me.colHogarPersona.FieldName = "Hogar"
        Me.colHogarPersona.Name = "colHogarPersona"
        Me.colHogarPersona.OptionsColumn.AllowEdit = False
        '
        'colPersona
        '
        Me.colPersona.FieldName = "Persona"
        Me.colPersona.Name = "colPersona"
        Me.colPersona.OptionsColumn.AllowEdit = False
        Me.colPersona.Visible = True
        Me.colPersona.VisibleIndex = 0
        Me.colPersona.Width = 49
        '
        'colNombrePila
        '
        Me.colNombrePila.Caption = "Nombre"
        Me.colNombrePila.FieldName = "NombrePila"
        Me.colNombrePila.Name = "colNombrePila"
        Me.colNombrePila.OptionsColumn.AllowEdit = False
        Me.colNombrePila.Visible = True
        Me.colNombrePila.VisibleIndex = 1
        Me.colNombrePila.Width = 94
        '
        'colSexo
        '
        Me.colSexo.FieldName = "Sexo"
        Me.colSexo.Name = "colSexo"
        Me.colSexo.OptionsColumn.AllowEdit = False
        Me.colSexo.Visible = True
        Me.colSexo.VisibleIndex = 2
        Me.colSexo.Width = 92
        '
        'colRelacion
        '
        Me.colRelacion.Caption = "Relación con Jefe de hogar"
        Me.colRelacion.FieldName = "Relacion"
        Me.colRelacion.Name = "colRelacion"
        Me.colRelacion.OptionsColumn.AllowEdit = False
        Me.colRelacion.Visible = True
        Me.colRelacion.VisibleIndex = 3
        Me.colRelacion.Width = 140
        '
        'colEncuestadoLab
        '
        Me.colEncuestadoLab.Caption = "Laboral"
        Me.colEncuestadoLab.FieldName = "EncuestadoLab"
        Me.colEncuestadoLab.Name = "colEncuestadoLab"
        Me.colEncuestadoLab.OptionsColumn.AllowEdit = False
        Me.colEncuestadoLab.Visible = True
        Me.colEncuestadoLab.VisibleIndex = 4
        Me.colEncuestadoLab.Width = 54
        '
        'colEncuestadoSab
        '
        Me.colEncuestadoSab.Caption = "Sábado"
        Me.colEncuestadoSab.FieldName = "EncuestadoSab"
        Me.colEncuestadoSab.Name = "colEncuestadoSab"
        Me.colEncuestadoSab.OptionsColumn.AllowEdit = False
        Me.colEncuestadoSab.Visible = True
        Me.colEncuestadoSab.VisibleIndex = 5
        Me.colEncuestadoSab.Width = 54
        '
        'colEncuestadoDom
        '
        Me.colEncuestadoDom.Caption = "Domingo"
        Me.colEncuestadoDom.FieldName = "EncuestadoDom"
        Me.colEncuestadoDom.Name = "colEncuestadoDom"
        Me.colEncuestadoDom.OptionsColumn.AllowEdit = False
        Me.colEncuestadoDom.Visible = True
        Me.colEncuestadoDom.VisibleIndex = 6
        Me.colEncuestadoDom.Width = 57
        '
        'colEncuestado
        '
        Me.colEncuestado.FieldName = "Encuestado"
        Me.colEncuestado.Name = "colEncuestado"
        Me.colEncuestado.OptionsColumn.AllowEdit = False
        Me.colEncuestado.Visible = True
        Me.colEncuestado.VisibleIndex = 7
        Me.colEncuestado.Width = 62
        '
        'ResumenPersonasTableAdapter
        '
        Me.ResumenPersonasTableAdapter.ClearBeforeFill = True
        '
        'cargaDatosBackground
        '
        '
        'DefaultLookAndFeel2
        '
        Me.DefaultLookAndFeel2.LookAndFeel.SkinName = "Office 2016 Colorful"
        '
        'grpVehiculos
        '
        Me.grpVehiculos.Controls.Add(Me.menuBackstage)
        Me.grpVehiculos.Controls.Add(Me.gridVehiculos)
        Me.grpVehiculos.Location = New System.Drawing.Point(666, 216)
        Me.grpVehiculos.Name = "grpVehiculos"
        Me.grpVehiculos.Size = New System.Drawing.Size(344, 168)
        Me.grpVehiculos.TabIndex = 9
        Me.grpVehiculos.Text = "Vehículos del hogar"
        '
        'gridVehiculos
        '
        Me.gridVehiculos.DataSource = Me.ResumenVehiculosBindingSource
        Me.gridVehiculos.Location = New System.Drawing.Point(12, 24)
        Me.gridVehiculos.MainView = Me.gridViewVehiculos
        Me.gridVehiculos.MenuManager = Me.ribbonPrincipal
        Me.gridVehiculos.Name = "gridVehiculos"
        Me.gridVehiculos.Size = New System.Drawing.Size(317, 129)
        Me.gridVehiculos.TabIndex = 0
        Me.gridVehiculos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridViewVehiculos})
        '
        'ResumenVehiculosBindingSource
        '
        Me.ResumenVehiculosBindingSource.DataMember = "ResumenVehiculos"
        Me.ResumenVehiculosBindingSource.DataSource = Me.datasetEOD
        Me.ResumenVehiculosBindingSource.Filter = "Hogar = 0"
        '
        'gridViewVehiculos
        '
        Me.gridViewVehiculos.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colVehículo, Me.colvehiculo, Me.colCombustible})
        Me.gridViewVehiculos.GridControl = Me.gridVehiculos
        Me.gridViewVehiculos.Name = "gridViewVehiculos"
        Me.gridViewVehiculos.OptionsView.ShowGroupPanel = False
        '
        'colVehículo
        '
        Me.colVehículo.FieldName = "Vehículo"
        Me.colVehículo.Name = "colVehículo"
        Me.colVehículo.OptionsColumn.AllowEdit = False
        Me.colVehículo.Visible = True
        Me.colVehículo.VisibleIndex = 0
        Me.colVehículo.Width = 52
        '
        'colvehiculo
        '
        Me.colvehiculo.Caption = "Tipo Vehículo"
        Me.colvehiculo.FieldName = "vehiculo"
        Me.colvehiculo.Name = "colvehiculo"
        Me.colvehiculo.OptionsColumn.AllowEdit = False
        Me.colvehiculo.Visible = True
        Me.colvehiculo.VisibleIndex = 1
        Me.colvehiculo.Width = 146
        '
        'colCombustible
        '
        Me.colCombustible.FieldName = "Combustible"
        Me.colCombustible.Name = "colCombustible"
        Me.colCombustible.OptionsColumn.AllowEdit = False
        Me.colCombustible.Visible = True
        Me.colCombustible.VisibleIndex = 2
        Me.colCombustible.Width = 122
        '
        'ResumenVehiculosTableAdapter
        '
        Me.ResumenVehiculosTableAdapter.ClearBeforeFill = True
        '
        'framePrincipal
        '
        Me.framePrincipal.Controls.Add(Me.navpageEncuestas)
        Me.framePrincipal.Controls.Add(Me.navpageControlAv)
        Me.framePrincipal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.framePrincipal.Location = New System.Drawing.Point(0, 165)
        Me.framePrincipal.Name = "framePrincipal"
        Me.framePrincipal.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.navpageEncuestas, Me.navpageControlAv})
        Me.framePrincipal.SelectedPage = Me.navpageEncuestas
        Me.framePrincipal.Size = New System.Drawing.Size(1022, 394)
        Me.framePrincipal.TabIndex = 18
        '
        'navpageEncuestas
        '
        Me.navpageEncuestas.Controls.Add(Me.grpHogares)
        Me.navpageEncuestas.Controls.Add(Me.grpPersonas)
        Me.navpageEncuestas.Controls.Add(Me.grpVehiculos)
        Me.navpageEncuestas.Name = "navpageEncuestas"
        Me.navpageEncuestas.Size = New System.Drawing.Size(1022, 394)
        '
        'navpageControlAv
        '
        Me.navpageControlAv.Controls.Add(Me.frameControlAvance)
        Me.navpageControlAv.Name = "navpageControlAv"
        Me.navpageControlAv.Size = New System.Drawing.Size(1022, 394)
        '
        'frameControlAvance
        '
        Me.frameControlAvance.Appearance.BackColor = System.Drawing.Color.White
        Me.frameControlAvance.Appearance.Options.UseBackColor = True
        Me.frameControlAvance.Controls.Add(Me.panelCompletas)
        Me.frameControlAvance.Controls.Add(Me.panelIncompletas)
        Me.frameControlAvance.Controls.Add(Me.panelInconsistentes)
        Me.frameControlAvance.Controls.Add(Me.panelRechazos)
        Me.frameControlAvance.Controls.Add(Me.panelResumenAvance)
        Me.frameControlAvance.Controls.Add(Me.pageCambioFolio)
        Me.frameControlAvance.Controls.Add(Me.NavigationPage1)
        Me.frameControlAvance.Dock = System.Windows.Forms.DockStyle.Fill
        Me.frameControlAvance.Location = New System.Drawing.Point(0, 0)
        Me.frameControlAvance.Name = "frameControlAvance"
        Me.frameControlAvance.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.panelResumenAvance, Me.panelCompletas, Me.panelIncompletas, Me.panelInconsistentes, Me.panelRechazos, Me.pageCambioFolio, Me.NavigationPage1})
        Me.frameControlAvance.SelectedPage = Me.panelRechazos
        Me.frameControlAvance.Size = New System.Drawing.Size(1022, 394)
        Me.frameControlAvance.TabIndex = 1
        Me.frameControlAvance.Text = "NavigationFrame1"
        '
        'panelCompletas
        '
        Me.panelCompletas.Controls.Add(Me.gcCompletas)
        Me.panelCompletas.Name = "panelCompletas"
        Me.panelCompletas.Size = New System.Drawing.Size(1022, 394)
        '
        'gcCompletas
        '
        Me.gcCompletas.Controls.Add(Me.gridCompletas)
        Me.gcCompletas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcCompletas.Location = New System.Drawing.Point(0, 0)
        Me.gcCompletas.Name = "gcCompletas"
        Me.gcCompletas.Size = New System.Drawing.Size(1022, 394)
        Me.gcCompletas.TabIndex = 1
        Me.gcCompletas.Text = "Encuestas completas"
        '
        'gridCompletas
        '
        Me.gridCompletas.DataSource = Me.ResumenHogaresCompletosBindingSource
        Me.gridCompletas.Location = New System.Drawing.Point(15, 24)
        Me.gridCompletas.MainView = Me.gridViewCompletas
        Me.gridCompletas.MenuManager = Me.ribbonPrincipal
        Me.gridCompletas.Name = "gridCompletas"
        Me.gridCompletas.Size = New System.Drawing.Size(992, 334)
        Me.gridCompletas.TabIndex = 0
        Me.gridCompletas.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridViewCompletas})
        '
        'ResumenHogaresCompletosBindingSource
        '
        Me.ResumenHogaresCompletosBindingSource.DataMember = "ResumenHogaresCompletos"
        Me.ResumenHogaresCompletosBindingSource.DataSource = Me.datasetEOD
        '
        'gridViewCompletas
        '
        Me.gridViewCompletas.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colHogar2, Me.colZona1, Me.colComuna1, Me.colNombreCalle1, Me.colNumero1, Me.colCasaDepto1, Me.colFecha1, Me.colTipoDia1})
        Me.gridViewCompletas.GridControl = Me.gridCompletas
        Me.gridViewCompletas.Name = "gridViewCompletas"
        Me.gridViewCompletas.OptionsView.ShowGroupPanel = False
        '
        'colHogar2
        '
        Me.colHogar2.FieldName = "Hogar"
        Me.colHogar2.Name = "colHogar2"
        Me.colHogar2.Visible = True
        Me.colHogar2.VisibleIndex = 0
        Me.colHogar2.Width = 108
        '
        'colZona1
        '
        Me.colZona1.FieldName = "Zona"
        Me.colZona1.Name = "colZona1"
        Me.colZona1.Visible = True
        Me.colZona1.VisibleIndex = 1
        Me.colZona1.Width = 51
        '
        'colComuna1
        '
        Me.colComuna1.FieldName = "Comuna"
        Me.colComuna1.Name = "colComuna1"
        Me.colComuna1.Width = 131
        '
        'colNombreCalle1
        '
        Me.colNombreCalle1.FieldName = "NombreCalle"
        Me.colNombreCalle1.Name = "colNombreCalle1"
        Me.colNombreCalle1.Visible = True
        Me.colNombreCalle1.VisibleIndex = 2
        Me.colNombreCalle1.Width = 179
        '
        'colNumero1
        '
        Me.colNumero1.FieldName = "Numero"
        Me.colNumero1.Name = "colNumero1"
        Me.colNumero1.Visible = True
        Me.colNumero1.VisibleIndex = 3
        Me.colNumero1.Width = 80
        '
        'colCasaDepto1
        '
        Me.colCasaDepto1.FieldName = "CasaDepto"
        Me.colCasaDepto1.Name = "colCasaDepto1"
        Me.colCasaDepto1.Visible = True
        Me.colCasaDepto1.VisibleIndex = 4
        Me.colCasaDepto1.Width = 92
        '
        'colFecha1
        '
        Me.colFecha1.FieldName = "Fecha"
        Me.colFecha1.Name = "colFecha1"
        Me.colFecha1.Visible = True
        Me.colFecha1.VisibleIndex = 5
        Me.colFecha1.Width = 99
        '
        'colTipoDia1
        '
        Me.colTipoDia1.FieldName = "TipoDia"
        Me.colTipoDia1.Name = "colTipoDia1"
        Me.colTipoDia1.Visible = True
        Me.colTipoDia1.VisibleIndex = 6
        Me.colTipoDia1.Width = 362
        '
        'panelIncompletas
        '
        Me.panelIncompletas.Controls.Add(Me.gcIncompletas)
        Me.panelIncompletas.Name = "panelIncompletas"
        Me.panelIncompletas.Size = New System.Drawing.Size(1022, 394)
        '
        'gcIncompletas
        '
        Me.gcIncompletas.Controls.Add(Me.gridIncompletas)
        Me.gcIncompletas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcIncompletas.Location = New System.Drawing.Point(0, 0)
        Me.gcIncompletas.Name = "gcIncompletas"
        Me.gcIncompletas.Size = New System.Drawing.Size(1022, 394)
        Me.gcIncompletas.TabIndex = 0
        Me.gcIncompletas.Text = "Encuestas incompletas"
        '
        'gridIncompletas
        '
        Me.gridIncompletas.DataSource = Me.ResumenHogaresIncompletosBindingSource
        Me.gridIncompletas.Location = New System.Drawing.Point(14, 24)
        Me.gridIncompletas.MainView = Me.gridViewIncompletas
        Me.gridIncompletas.MenuManager = Me.ribbonPrincipal
        Me.gridIncompletas.Name = "gridIncompletas"
        Me.gridIncompletas.Size = New System.Drawing.Size(993, 337)
        Me.gridIncompletas.TabIndex = 0
        Me.gridIncompletas.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridViewIncompletas})
        '
        'ResumenHogaresIncompletosBindingSource
        '
        Me.ResumenHogaresIncompletosBindingSource.DataMember = "ResumenHogaresIncompletos"
        Me.ResumenHogaresIncompletosBindingSource.DataSource = Me.datasetEOD
        '
        'gridViewIncompletas
        '
        Me.gridViewIncompletas.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colHogar3, Me.colZona2, Me.colComuna2, Me.colNombreCalle2, Me.colNumero2, Me.colCasaDepto2, Me.colFecha2, Me.colTipoDia2, Me.colEstadoEncuesta2})
        Me.gridViewIncompletas.GridControl = Me.gridIncompletas
        Me.gridViewIncompletas.Name = "gridViewIncompletas"
        Me.gridViewIncompletas.OptionsView.ShowGroupPanel = False
        '
        'colHogar3
        '
        Me.colHogar3.FieldName = "Hogar"
        Me.colHogar3.Name = "colHogar3"
        Me.colHogar3.Visible = True
        Me.colHogar3.VisibleIndex = 0
        '
        'colZona2
        '
        Me.colZona2.FieldName = "Zona"
        Me.colZona2.Name = "colZona2"
        Me.colZona2.Visible = True
        Me.colZona2.VisibleIndex = 1
        '
        'colComuna2
        '
        Me.colComuna2.FieldName = "Comuna"
        Me.colComuna2.Name = "colComuna2"
        Me.colComuna2.Visible = True
        Me.colComuna2.VisibleIndex = 2
        '
        'colNombreCalle2
        '
        Me.colNombreCalle2.FieldName = "NombreCalle"
        Me.colNombreCalle2.Name = "colNombreCalle2"
        Me.colNombreCalle2.Visible = True
        Me.colNombreCalle2.VisibleIndex = 3
        '
        'colNumero2
        '
        Me.colNumero2.FieldName = "Numero"
        Me.colNumero2.Name = "colNumero2"
        Me.colNumero2.Visible = True
        Me.colNumero2.VisibleIndex = 4
        '
        'colCasaDepto2
        '
        Me.colCasaDepto2.FieldName = "CasaDepto"
        Me.colCasaDepto2.Name = "colCasaDepto2"
        Me.colCasaDepto2.Visible = True
        Me.colCasaDepto2.VisibleIndex = 5
        '
        'colFecha2
        '
        Me.colFecha2.FieldName = "Fecha"
        Me.colFecha2.Name = "colFecha2"
        Me.colFecha2.Visible = True
        Me.colFecha2.VisibleIndex = 6
        '
        'colTipoDia2
        '
        Me.colTipoDia2.FieldName = "TipoDia"
        Me.colTipoDia2.Name = "colTipoDia2"
        Me.colTipoDia2.Visible = True
        Me.colTipoDia2.VisibleIndex = 7
        '
        'colEstadoEncuesta2
        '
        Me.colEstadoEncuesta2.FieldName = "EstadoEncuesta"
        Me.colEstadoEncuesta2.Name = "colEstadoEncuesta2"
        Me.colEstadoEncuesta2.Visible = True
        Me.colEstadoEncuesta2.VisibleIndex = 8
        '
        'panelInconsistentes
        '
        Me.panelInconsistentes.Controls.Add(Me.gcInconsistentes)
        Me.panelInconsistentes.Name = "panelInconsistentes"
        Me.panelInconsistentes.Size = New System.Drawing.Size(1022, 394)
        '
        'gcInconsistentes
        '
        Me.gcInconsistentes.Controls.Add(Me.gridInconsistentes)
        Me.gcInconsistentes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcInconsistentes.Location = New System.Drawing.Point(0, 0)
        Me.gcInconsistentes.Name = "gcInconsistentes"
        Me.gcInconsistentes.Size = New System.Drawing.Size(1022, 394)
        Me.gcInconsistentes.TabIndex = 0
        Me.gcInconsistentes.Text = "Encuestas inconsistentes"
        '
        'gridInconsistentes
        '
        Me.gridInconsistentes.DataSource = Me.ResumenHogaresInconsistentesBindingSource
        Me.gridInconsistentes.Location = New System.Drawing.Point(12, 24)
        Me.gridInconsistentes.MainView = Me.gridViewInconsistentes
        Me.gridInconsistentes.MenuManager = Me.ribbonPrincipal
        Me.gridInconsistentes.Name = "gridInconsistentes"
        Me.gridInconsistentes.Size = New System.Drawing.Size(998, 358)
        Me.gridInconsistentes.TabIndex = 0
        Me.gridInconsistentes.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridViewInconsistentes})
        '
        'ResumenHogaresInconsistentesBindingSource
        '
        Me.ResumenHogaresInconsistentesBindingSource.DataMember = "ResumenHogaresInconsistentes"
        Me.ResumenHogaresInconsistentesBindingSource.DataSource = Me.datasetEOD
        '
        'gridViewInconsistentes
        '
        Me.gridViewInconsistentes.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colHogar4, Me.colZona4, Me.colComuna3, Me.colNombreCalle4, Me.colNumero4, Me.colCasaDepto4, Me.colFechaViajes1, Me.colTipoDia4})
        Me.gridViewInconsistentes.GridControl = Me.gridInconsistentes
        Me.gridViewInconsistentes.Name = "gridViewInconsistentes"
        Me.gridViewInconsistentes.OptionsView.ShowGroupPanel = False
        '
        'colHogar4
        '
        Me.colHogar4.FieldName = "Hogar"
        Me.colHogar4.Name = "colHogar4"
        Me.colHogar4.Visible = True
        Me.colHogar4.VisibleIndex = 0
        '
        'colZona4
        '
        Me.colZona4.FieldName = "Zona"
        Me.colZona4.Name = "colZona4"
        Me.colZona4.Visible = True
        Me.colZona4.VisibleIndex = 1
        '
        'colComuna3
        '
        Me.colComuna3.FieldName = "Comuna"
        Me.colComuna3.Name = "colComuna3"
        Me.colComuna3.Visible = True
        Me.colComuna3.VisibleIndex = 2
        '
        'colNombreCalle4
        '
        Me.colNombreCalle4.FieldName = "NombreCalle"
        Me.colNombreCalle4.Name = "colNombreCalle4"
        Me.colNombreCalle4.Visible = True
        Me.colNombreCalle4.VisibleIndex = 3
        '
        'colNumero4
        '
        Me.colNumero4.FieldName = "Numero"
        Me.colNumero4.Name = "colNumero4"
        Me.colNumero4.Visible = True
        Me.colNumero4.VisibleIndex = 4
        '
        'colCasaDepto4
        '
        Me.colCasaDepto4.FieldName = "CasaDepto"
        Me.colCasaDepto4.Name = "colCasaDepto4"
        Me.colCasaDepto4.Visible = True
        Me.colCasaDepto4.VisibleIndex = 5
        '
        'colFechaViajes1
        '
        Me.colFechaViajes1.FieldName = "FechaViajes"
        Me.colFechaViajes1.Name = "colFechaViajes1"
        Me.colFechaViajes1.Visible = True
        Me.colFechaViajes1.VisibleIndex = 6
        '
        'colTipoDia4
        '
        Me.colTipoDia4.FieldName = "TipoDia"
        Me.colTipoDia4.Name = "colTipoDia4"
        Me.colTipoDia4.Visible = True
        Me.colTipoDia4.VisibleIndex = 7
        '
        'panelRechazos
        '
        Me.panelRechazos.Controls.Add(Me.gcRechazos)
        Me.panelRechazos.Name = "panelRechazos"
        Me.panelRechazos.Size = New System.Drawing.Size(1022, 394)
        '
        'gcRechazos
        '
        Me.gcRechazos.Controls.Add(Me.gridRechazadas)
        Me.gcRechazos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcRechazos.Location = New System.Drawing.Point(0, 0)
        Me.gcRechazos.Name = "gcRechazos"
        Me.gcRechazos.Size = New System.Drawing.Size(1022, 394)
        Me.gcRechazos.TabIndex = 0
        Me.gcRechazos.Text = "Encuestas rechazadas"
        '
        'gridRechazadas
        '
        Me.gridRechazadas.DataSource = Me.ResumenHogaresRechazadosBindingSource
        Me.gridRechazadas.Location = New System.Drawing.Point(9, 24)
        Me.gridRechazadas.MainView = Me.gridViewRechazadas
        Me.gridRechazadas.MenuManager = Me.ribbonPrincipal
        Me.gridRechazadas.Name = "gridRechazadas"
        Me.gridRechazadas.Size = New System.Drawing.Size(998, 356)
        Me.gridRechazadas.TabIndex = 0
        Me.gridRechazadas.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridViewRechazadas})
        '
        'ResumenHogaresRechazadosBindingSource
        '
        Me.ResumenHogaresRechazadosBindingSource.DataMember = "ResumenHogaresRechazados"
        Me.ResumenHogaresRechazadosBindingSource.DataSource = Me.datasetEOD
        '
        'gridViewRechazadas
        '
        Me.gridViewRechazadas.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colHogar1, Me.colZona3, Me.colComuna, Me.colNombreCalle3, Me.colNumero3, Me.colCasaDepto3, Me.colFechaViajes, Me.colTipoDia3, Me.colEstadoEncuesta1})
        Me.gridViewRechazadas.GridControl = Me.gridRechazadas
        Me.gridViewRechazadas.Name = "gridViewRechazadas"
        Me.gridViewRechazadas.OptionsView.ShowGroupPanel = False
        '
        'colHogar1
        '
        Me.colHogar1.FieldName = "Hogar"
        Me.colHogar1.Name = "colHogar1"
        Me.colHogar1.Visible = True
        Me.colHogar1.VisibleIndex = 0
        '
        'colZona3
        '
        Me.colZona3.FieldName = "Zona"
        Me.colZona3.Name = "colZona3"
        Me.colZona3.Visible = True
        Me.colZona3.VisibleIndex = 1
        '
        'colComuna
        '
        Me.colComuna.FieldName = "Comuna"
        Me.colComuna.Name = "colComuna"
        Me.colComuna.Visible = True
        Me.colComuna.VisibleIndex = 2
        '
        'colNombreCalle3
        '
        Me.colNombreCalle3.FieldName = "NombreCalle"
        Me.colNombreCalle3.Name = "colNombreCalle3"
        Me.colNombreCalle3.Visible = True
        Me.colNombreCalle3.VisibleIndex = 3
        '
        'colNumero3
        '
        Me.colNumero3.FieldName = "Numero"
        Me.colNumero3.Name = "colNumero3"
        Me.colNumero3.Visible = True
        Me.colNumero3.VisibleIndex = 4
        '
        'colCasaDepto3
        '
        Me.colCasaDepto3.FieldName = "CasaDepto"
        Me.colCasaDepto3.Name = "colCasaDepto3"
        Me.colCasaDepto3.Visible = True
        Me.colCasaDepto3.VisibleIndex = 5
        '
        'colFechaViajes
        '
        Me.colFechaViajes.FieldName = "FechaViajes"
        Me.colFechaViajes.Name = "colFechaViajes"
        Me.colFechaViajes.Visible = True
        Me.colFechaViajes.VisibleIndex = 6
        '
        'colTipoDia3
        '
        Me.colTipoDia3.FieldName = "TipoDia"
        Me.colTipoDia3.Name = "colTipoDia3"
        Me.colTipoDia3.Visible = True
        Me.colTipoDia3.VisibleIndex = 7
        '
        'colEstadoEncuesta1
        '
        Me.colEstadoEncuesta1.FieldName = "EstadoEncuesta"
        Me.colEstadoEncuesta1.Name = "colEstadoEncuesta1"
        Me.colEstadoEncuesta1.Visible = True
        Me.colEstadoEncuesta1.VisibleIndex = 8
        '
        'panelResumenAvance
        '
        Me.panelResumenAvance.Controls.Add(Me.Label1)
        Me.panelResumenAvance.Controls.Add(Me.calendarioAvance)
        Me.panelResumenAvance.Controls.Add(Me.PanelControl2)
        Me.panelResumenAvance.Controls.Add(Me.PanelControl1)
        Me.panelResumenAvance.Controls.Add(Me.Label4)
        Me.panelResumenAvance.Controls.Add(Me.Label3)
        Me.panelResumenAvance.Controls.Add(Me.Label2)
        Me.panelResumenAvance.Controls.Add(Me.PanelControl3)
        Me.panelResumenAvance.Name = "panelResumenAvance"
        Me.panelResumenAvance.Size = New System.Drawing.Size(1022, 394)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Label1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label1.Location = New System.Drawing.Point(706, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(178, 19)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Último envío al servidor"
        '
        'calendarioAvance
        '
        Me.calendarioAvance.DataStorage = Me.SchedulerStorage1
        Me.calendarioAvance.Location = New System.Drawing.Point(0, 173)
        Me.calendarioAvance.MenuManager = Me.ribbonPrincipal
        Me.calendarioAvance.Name = "calendarioAvance"
        Me.calendarioAvance.OptionsRangeControl.RangeMaximum = New Date(2017, 5, 1, 0, 0, 0, 0)
        Me.calendarioAvance.OptionsRangeControl.RangeMinimum = New Date(2017, 2, 1, 0, 0, 0, 0)
        Me.calendarioAvance.OptionsView.FirstDayOfWeek = DevExpress.XtraScheduler.FirstDayOfWeek.Monday
        Me.calendarioAvance.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.calendarioAvance.Size = New System.Drawing.Size(1022, 422)
        Me.calendarioAvance.Start = New Date(2017, 4, 17, 0, 0, 0, 0)
        Me.calendarioAvance.TabIndex = 8
        Me.calendarioAvance.Text = "SchedulerControl1"
        Me.calendarioAvance.Views.DayView.TimeRulers.Add(TimeRuler1)
        Me.calendarioAvance.Views.FullWeekView.Enabled = True
        Me.calendarioAvance.Views.FullWeekView.TimeRulers.Add(TimeRuler2)
        Me.calendarioAvance.Views.GanttView.Enabled = False
        Me.calendarioAvance.Views.WorkWeekView.TimeRulers.Add(TimeRuler3)
        '
        'PanelControl2
        '
        Me.PanelControl2.Appearance.BackColor = System.Drawing.Color.White
        Me.PanelControl2.Appearance.Options.UseBackColor = True
        Me.PanelControl2.Controls.Add(Me.LabelControl13)
        Me.PanelControl2.Controls.Add(Me.lblEncuestasRechazadas)
        Me.PanelControl2.Controls.Add(Me.LabelControl15)
        Me.PanelControl2.Controls.Add(Me.lblEncuestasInconsistentes)
        Me.PanelControl2.Controls.Add(Me.PictureEdit5)
        Me.PanelControl2.Controls.Add(Me.PictureEdit6)
        Me.PanelControl2.Controls.Add(Me.LabelControl9)
        Me.PanelControl2.Controls.Add(Me.lblEncuestasIncompletas)
        Me.PanelControl2.Controls.Add(Me.LabelControl11)
        Me.PanelControl2.Controls.Add(Me.lblEncuestasCompletas)
        Me.PanelControl2.Controls.Add(Me.PictureEdit3)
        Me.PanelControl2.Controls.Add(Me.PictureEdit4)
        Me.PanelControl2.Location = New System.Drawing.Point(266, 35)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(425, 97)
        Me.PanelControl2.TabIndex = 7
        '
        'LabelControl13
        '
        Me.LabelControl13.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.LabelControl13.Appearance.Options.UseFont = True
        Me.LabelControl13.Appearance.Options.UseTextOptions = True
        Me.LabelControl13.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl13.Location = New System.Drawing.Point(340, 58)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(65, 32)
        Me.LabelControl13.TabIndex = 9
        Me.LabelControl13.Text = "Encuestas" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "rechazadas"
        '
        'lblEncuestasRechazadas
        '
        Me.lblEncuestasRechazadas.Appearance.Font = New System.Drawing.Font("Gill Sans MT", 32.0!)
        Me.lblEncuestasRechazadas.Appearance.Options.UseFont = True
        Me.lblEncuestasRechazadas.Appearance.Options.UseTextOptions = True
        Me.lblEncuestasRechazadas.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lblEncuestasRechazadas.Location = New System.Drawing.Point(380, 5)
        Me.lblEncuestasRechazadas.Name = "lblEncuestasRechazadas"
        Me.lblEncuestasRechazadas.Size = New System.Drawing.Size(22, 60)
        Me.lblEncuestasRechazadas.TabIndex = 8
        Me.lblEncuestasRechazadas.Text = "0"
        '
        'LabelControl15
        '
        Me.LabelControl15.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.LabelControl15.Appearance.Options.UseFont = True
        Me.LabelControl15.Appearance.Options.UseTextOptions = True
        Me.LabelControl15.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl15.Location = New System.Drawing.Point(225, 58)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(80, 32)
        Me.LabelControl15.TabIndex = 7
        Me.LabelControl15.Text = "Encuestas" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "inconsistentes"
        '
        'lblEncuestasInconsistentes
        '
        Me.lblEncuestasInconsistentes.Appearance.Font = New System.Drawing.Font("Gill Sans MT", 32.0!)
        Me.lblEncuestasInconsistentes.Appearance.Options.UseFont = True
        Me.lblEncuestasInconsistentes.Appearance.Options.UseTextOptions = True
        Me.lblEncuestasInconsistentes.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lblEncuestasInconsistentes.Location = New System.Drawing.Point(266, 5)
        Me.lblEncuestasInconsistentes.Name = "lblEncuestasInconsistentes"
        Me.lblEncuestasInconsistentes.Size = New System.Drawing.Size(22, 60)
        Me.lblEncuestasInconsistentes.TabIndex = 6
        Me.lblEncuestasInconsistentes.Text = "0"
        '
        'PictureEdit5
        '
        Me.PictureEdit5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureEdit5.EditValue = CType(resources.GetObject("PictureEdit5.EditValue"), Object)
        Me.PictureEdit5.Location = New System.Drawing.Point(226, 11)
        Me.PictureEdit5.MenuManager = Me.ribbonPrincipal
        Me.PictureEdit5.Name = "PictureEdit5"
        Me.PictureEdit5.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PictureEdit5.Properties.Appearance.Options.UseBackColor = True
        Me.PictureEdit5.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureEdit5.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.PictureEdit5.Properties.ZoomAccelerationFactor = 1.0R
        Me.PictureEdit5.Size = New System.Drawing.Size(44, 47)
        Me.PictureEdit5.TabIndex = 10
        '
        'PictureEdit6
        '
        Me.PictureEdit6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureEdit6.EditValue = CType(resources.GetObject("PictureEdit6.EditValue"), Object)
        Me.PictureEdit6.Location = New System.Drawing.Point(340, 11)
        Me.PictureEdit6.MenuManager = Me.ribbonPrincipal
        Me.PictureEdit6.Name = "PictureEdit6"
        Me.PictureEdit6.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PictureEdit6.Properties.Appearance.Options.UseBackColor = True
        Me.PictureEdit6.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureEdit6.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.PictureEdit6.Properties.ZoomAccelerationFactor = 1.0R
        Me.PictureEdit6.Size = New System.Drawing.Size(44, 47)
        Me.PictureEdit6.TabIndex = 11
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.LabelControl9.Appearance.Options.UseFont = True
        Me.LabelControl9.Appearance.Options.UseTextOptions = True
        Me.LabelControl9.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl9.Location = New System.Drawing.Point(118, 58)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(68, 32)
        Me.LabelControl9.TabIndex = 3
        Me.LabelControl9.Text = "Encuestas" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "incompletas"
        '
        'lblEncuestasIncompletas
        '
        Me.lblEncuestasIncompletas.Appearance.Font = New System.Drawing.Font("Gill Sans MT", 32.0!)
        Me.lblEncuestasIncompletas.Appearance.Options.UseFont = True
        Me.lblEncuestasIncompletas.Appearance.Options.UseTextOptions = True
        Me.lblEncuestasIncompletas.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lblEncuestasIncompletas.Location = New System.Drawing.Point(161, 5)
        Me.lblEncuestasIncompletas.Name = "lblEncuestasIncompletas"
        Me.lblEncuestasIncompletas.Size = New System.Drawing.Size(22, 60)
        Me.lblEncuestasIncompletas.TabIndex = 2
        Me.lblEncuestasIncompletas.Text = "0"
        '
        'LabelControl11
        '
        Me.LabelControl11.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.LabelControl11.Appearance.Options.UseFont = True
        Me.LabelControl11.Appearance.Options.UseTextOptions = True
        Me.LabelControl11.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl11.Location = New System.Drawing.Point(18, 58)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(58, 32)
        Me.LabelControl11.TabIndex = 1
        Me.LabelControl11.Text = "Encuestas" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "completas"
        '
        'lblEncuestasCompletas
        '
        Me.lblEncuestasCompletas.Appearance.Font = New System.Drawing.Font("Gill Sans MT", 32.0!)
        Me.lblEncuestasCompletas.Appearance.Options.UseFont = True
        Me.lblEncuestasCompletas.Appearance.Options.UseTextOptions = True
        Me.lblEncuestasCompletas.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lblEncuestasCompletas.Location = New System.Drawing.Point(55, 5)
        Me.lblEncuestasCompletas.Name = "lblEncuestasCompletas"
        Me.lblEncuestasCompletas.Size = New System.Drawing.Size(22, 60)
        Me.lblEncuestasCompletas.TabIndex = 0
        Me.lblEncuestasCompletas.Text = "0"
        '
        'PictureEdit3
        '
        Me.PictureEdit3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureEdit3.EditValue = CType(resources.GetObject("PictureEdit3.EditValue"), Object)
        Me.PictureEdit3.Location = New System.Drawing.Point(15, 11)
        Me.PictureEdit3.MenuManager = Me.ribbonPrincipal
        Me.PictureEdit3.Name = "PictureEdit3"
        Me.PictureEdit3.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PictureEdit3.Properties.Appearance.Options.UseBackColor = True
        Me.PictureEdit3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureEdit3.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.PictureEdit3.Properties.ZoomAccelerationFactor = 1.0R
        Me.PictureEdit3.Size = New System.Drawing.Size(44, 47)
        Me.PictureEdit3.TabIndex = 4
        '
        'PictureEdit4
        '
        Me.PictureEdit4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureEdit4.EditValue = CType(resources.GetObject("PictureEdit4.EditValue"), Object)
        Me.PictureEdit4.Location = New System.Drawing.Point(118, 11)
        Me.PictureEdit4.MenuManager = Me.ribbonPrincipal
        Me.PictureEdit4.Name = "PictureEdit4"
        Me.PictureEdit4.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PictureEdit4.Properties.Appearance.Options.UseBackColor = True
        Me.PictureEdit4.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureEdit4.Properties.ErrorImage = CType(resources.GetObject("PictureEdit4.Properties.ErrorImage"), System.Drawing.Image)
        Me.PictureEdit4.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.PictureEdit4.Properties.ZoomAccelerationFactor = 1.0R
        Me.PictureEdit4.Size = New System.Drawing.Size(44, 47)
        Me.PictureEdit4.TabIndex = 5
        '
        'PanelControl1
        '
        Me.PanelControl1.Appearance.BackColor = System.Drawing.Color.White
        Me.PanelControl1.Appearance.Options.UseBackColor = True
        Me.PanelControl1.Controls.Add(Me.LabelControl8)
        Me.PanelControl1.Controls.Add(Me.lblEncuestasRecogerHoy)
        Me.PanelControl1.Controls.Add(Me.LabelControl5)
        Me.PanelControl1.Controls.Add(Me.lblPersonasEncuestarDia)
        Me.PanelControl1.Controls.Add(Me.PictureEdit1)
        Me.PanelControl1.Controls.Add(Me.PictureEdit2)
        Me.PanelControl1.Location = New System.Drawing.Point(18, 35)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(226, 97)
        Me.PanelControl1.TabIndex = 6
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.LabelControl8.Appearance.Options.UseFont = True
        Me.LabelControl8.Appearance.Options.UseTextOptions = True
        Me.LabelControl8.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl8.Location = New System.Drawing.Point(124, 58)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(80, 32)
        Me.LabelControl8.TabIndex = 3
        Me.LabelControl8.Text = "Encuestas por" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "recoger"
        '
        'lblEncuestasRecogerHoy
        '
        Me.lblEncuestasRecogerHoy.Appearance.Font = New System.Drawing.Font("Gill Sans MT", 32.0!)
        Me.lblEncuestasRecogerHoy.Appearance.Options.UseFont = True
        Me.lblEncuestasRecogerHoy.Appearance.Options.UseTextOptions = True
        Me.lblEncuestasRecogerHoy.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lblEncuestasRecogerHoy.Location = New System.Drawing.Point(167, 5)
        Me.lblEncuestasRecogerHoy.Name = "lblEncuestasRecogerHoy"
        Me.lblEncuestasRecogerHoy.Size = New System.Drawing.Size(22, 60)
        Me.lblEncuestasRecogerHoy.TabIndex = 2
        Me.lblEncuestasRecogerHoy.Text = "0"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Appearance.Options.UseTextOptions = True
        Me.LabelControl5.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl5.Location = New System.Drawing.Point(23, 58)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(75, 32)
        Me.LabelControl5.TabIndex = 1
        Me.LabelControl5.Text = "Personas por" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "encuestar"
        '
        'lblPersonasEncuestarDia
        '
        Me.lblPersonasEncuestarDia.Appearance.Font = New System.Drawing.Font("Gill Sans MT", 32.0!)
        Me.lblPersonasEncuestarDia.Appearance.Options.UseFont = True
        Me.lblPersonasEncuestarDia.Appearance.Options.UseTextOptions = True
        Me.lblPersonasEncuestarDia.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lblPersonasEncuestarDia.Location = New System.Drawing.Point(60, 5)
        Me.lblPersonasEncuestarDia.Name = "lblPersonasEncuestarDia"
        Me.lblPersonasEncuestarDia.Size = New System.Drawing.Size(22, 60)
        Me.lblPersonasEncuestarDia.TabIndex = 0
        Me.lblPersonasEncuestarDia.Text = "0"
        '
        'PictureEdit1
        '
        Me.PictureEdit1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureEdit1.EditValue = CType(resources.GetObject("PictureEdit1.EditValue"), Object)
        Me.PictureEdit1.Location = New System.Drawing.Point(20, 11)
        Me.PictureEdit1.MenuManager = Me.ribbonPrincipal
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PictureEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.PictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.PictureEdit1.Properties.ZoomAccelerationFactor = 1.0R
        Me.PictureEdit1.Size = New System.Drawing.Size(44, 47)
        Me.PictureEdit1.TabIndex = 4
        '
        'PictureEdit2
        '
        Me.PictureEdit2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureEdit2.EditValue = CType(resources.GetObject("PictureEdit2.EditValue"), Object)
        Me.PictureEdit2.Location = New System.Drawing.Point(124, 11)
        Me.PictureEdit2.MenuManager = Me.ribbonPrincipal
        Me.PictureEdit2.Name = "PictureEdit2"
        Me.PictureEdit2.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PictureEdit2.Properties.Appearance.Options.UseBackColor = True
        Me.PictureEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureEdit2.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.PictureEdit2.Properties.ZoomAccelerationFactor = 1.0R
        Me.PictureEdit2.Size = New System.Drawing.Size(44, 47)
        Me.PictureEdit2.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Label4.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label4.Location = New System.Drawing.Point(15, 139)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(126, 19)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Agenda semanal"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Label3.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label3.Location = New System.Drawing.Point(14, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(127, 19)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Resumen de hoy"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Label2.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label2.Location = New System.Drawing.Point(262, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Avance global"
        '
        'PanelControl3
        '
        Me.PanelControl3.Appearance.BackColor = System.Drawing.Color.White
        Me.PanelControl3.Appearance.Options.UseBackColor = True
        Me.PanelControl3.Controls.Add(Me.semaforoCarga)
        Me.PanelControl3.Controls.Add(Me.lblMensajeEnvio)
        Me.PanelControl3.Controls.Add(Me.lblUltimaExportacion)
        Me.PanelControl3.Location = New System.Drawing.Point(710, 35)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(288, 97)
        Me.PanelControl3.TabIndex = 7
        '
        'semaforoCarga
        '
        Me.semaforoCarga.AutoLayout = False
        Me.semaforoCarga.BackColor = System.Drawing.Color.Transparent
        Me.semaforoCarga.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.semaforoCarga.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.indicadorSemaforo})
        Me.semaforoCarga.Location = New System.Drawing.Point(6, 10)
        Me.semaforoCarga.Name = "semaforoCarga"
        Me.semaforoCarga.Size = New System.Drawing.Size(44, 44)
        Me.semaforoCarga.TabIndex = 2
        '
        'indicadorSemaforo
        '
        Me.indicadorSemaforo.Bounds = New System.Drawing.Rectangle(3, 2, 38, 37)
        Me.indicadorSemaforo.Indicators.AddRange(New DevExpress.XtraGauges.Win.Gauges.State.StateIndicatorComponent() {Me.StateIndicatorComponent2})
        Me.indicadorSemaforo.Name = "indicadorSemaforo"
        '
        'StateIndicatorComponent2
        '
        Me.StateIndicatorComponent2.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(124.0!, 124.0!)
        Me.StateIndicatorComponent2.Name = "stateIndicatorComponent1"
        Me.StateIndicatorComponent2.Size = New System.Drawing.SizeF(200.0!, 200.0!)
        Me.StateIndicatorComponent2.StateIndex = 3
        IndicatorState1.Name = "State1"
        IndicatorState1.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ElectricLight1
        IndicatorState2.Name = "State2"
        IndicatorState2.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ElectricLight2
        IndicatorState3.Name = "State3"
        IndicatorState3.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ElectricLight3
        IndicatorState4.Name = "State4"
        IndicatorState4.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.ElectricLight4
        Me.StateIndicatorComponent2.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {IndicatorState1, IndicatorState2, IndicatorState3, IndicatorState4})
        '
        'lblMensajeEnvio
        '
        Me.lblMensajeEnvio.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.lblMensajeEnvio.Appearance.Options.UseFont = True
        Me.lblMensajeEnvio.Appearance.Options.UseTextOptions = True
        Me.lblMensajeEnvio.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lblMensajeEnvio.Location = New System.Drawing.Point(38, 58)
        Me.lblMensajeEnvio.Name = "lblMensajeEnvio"
        Me.lblMensajeEnvio.Size = New System.Drawing.Size(212, 32)
        Me.lblMensajeEnvio.TabIndex = 1
        Me.lblMensajeEnvio.Text = "Recuerde no dejar pasar más de dos" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "días entre envíos al servidor"
        '
        'lblUltimaExportacion
        '
        Me.lblUltimaExportacion.Appearance.Font = New System.Drawing.Font("Gill Sans MT", 14.0!)
        Me.lblUltimaExportacion.Appearance.Options.UseFont = True
        Me.lblUltimaExportacion.Appearance.Options.UseTextOptions = True
        Me.lblUltimaExportacion.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lblUltimaExportacion.Location = New System.Drawing.Point(55, 18)
        Me.lblUltimaExportacion.Name = "lblUltimaExportacion"
        Me.lblUltimaExportacion.Size = New System.Drawing.Size(0, 27)
        Me.lblUltimaExportacion.TabIndex = 0
        '
        'pageCambioFolio
        '
        Me.pageCambioFolio.Controls.Add(Me.gcCambioFolio)
        Me.pageCambioFolio.Name = "pageCambioFolio"
        Me.pageCambioFolio.Size = New System.Drawing.Size(1022, 394)
        '
        'gcCambioFolio
        '
        Me.gcCambioFolio.Controls.Add(Me.btnCancelar)
        Me.gcCambioFolio.Controls.Add(Me.btnActualizarFolio)
        Me.gcCambioFolio.Controls.Add(Me.GroupBox2)
        Me.gcCambioFolio.Controls.Add(Me.GroupBox1)
        Me.gcCambioFolio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcCambioFolio.Location = New System.Drawing.Point(0, 0)
        Me.gcCambioFolio.Name = "gcCambioFolio"
        Me.gcCambioFolio.Size = New System.Drawing.Size(1022, 394)
        Me.gcCambioFolio.TabIndex = 2
        Me.gcCambioFolio.Text = "Cambiar folio de encuesta"
        '
        'btnCancelar
        '
        Me.btnCancelar.Appearance.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnCancelar.Appearance.BackColor2 = System.Drawing.SystemColors.HotTrack
        Me.btnCancelar.Appearance.BorderColor = System.Drawing.SystemColors.HotTrack
        Me.btnCancelar.Appearance.ForeColor = System.Drawing.Color.White
        Me.btnCancelar.Appearance.Options.UseBackColor = True
        Me.btnCancelar.Appearance.Options.UseBorderColor = True
        Me.btnCancelar.Appearance.Options.UseForeColor = True
        Me.btnCancelar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
        Me.btnCancelar.Location = New System.Drawing.Point(860, 226)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(85, 28)
        Me.btnCancelar.TabIndex = 35
        Me.btnCancelar.Text = "Cancelar"
        '
        'btnActualizarFolio
        '
        Me.btnActualizarFolio.Appearance.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnActualizarFolio.Appearance.BackColor2 = System.Drawing.SystemColors.HotTrack
        Me.btnActualizarFolio.Appearance.BorderColor = System.Drawing.SystemColors.HotTrack
        Me.btnActualizarFolio.Appearance.ForeColor = System.Drawing.Color.White
        Me.btnActualizarFolio.Appearance.Options.UseBackColor = True
        Me.btnActualizarFolio.Appearance.Options.UseBorderColor = True
        Me.btnActualizarFolio.Appearance.Options.UseForeColor = True
        Me.btnActualizarFolio.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
        Me.btnActualizarFolio.Location = New System.Drawing.Point(769, 226)
        Me.btnActualizarFolio.Name = "btnActualizarFolio"
        Me.btnActualizarFolio.Size = New System.Drawing.Size(85, 28)
        Me.btnActualizarFolio.TabIndex = 34
        Me.btnActualizarFolio.Text = "Corregir"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LabelControl16)
        Me.GroupBox2.Controls.Add(Me.LabelControl23)
        Me.GroupBox2.Controls.Add(Me.LabelControl24)
        Me.GroupBox2.Controls.Add(Me.txtZonaCorregida)
        Me.GroupBox2.Controls.Add(Me.txtManzanaCorregida)
        Me.GroupBox2.Controls.Add(Me.LabelControl25)
        Me.GroupBox2.Controls.Add(Me.LabelControl26)
        Me.GroupBox2.Controls.Add(Me.LabelControl27)
        Me.GroupBox2.Controls.Add(Me.txtCalleCorregida)
        Me.GroupBox2.Controls.Add(Me.txtNumeroCorregido)
        Me.GroupBox2.Controls.Add(Me.txtCasaDeptoCorregido)
        Me.GroupBox2.Controls.Add(Me.lkpComunaCorregida)
        Me.GroupBox2.Controls.Add(Me.lkpFolioCorregido)
        Me.GroupBox2.Controls.Add(Me.LabelControl29)
        Me.GroupBox2.Location = New System.Drawing.Point(520, 68)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(425, 140)
        Me.GroupBox2.TabIndex = 33
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Folio corregido"
        '
        'LabelControl16
        '
        Me.LabelControl16.Location = New System.Drawing.Point(232, 49)
        Me.LabelControl16.Name = "LabelControl16"
        Me.LabelControl16.Size = New System.Drawing.Size(39, 13)
        Me.LabelControl16.TabIndex = 20
        Me.LabelControl16.Text = "Comuna"
        '
        'LabelControl23
        '
        Me.LabelControl23.Location = New System.Drawing.Point(247, 75)
        Me.LabelControl23.Name = "LabelControl23"
        Me.LabelControl23.Size = New System.Drawing.Size(24, 13)
        Me.LabelControl23.TabIndex = 21
        Me.LabelControl23.Text = "Zona"
        '
        'LabelControl24
        '
        Me.LabelControl24.Location = New System.Drawing.Point(228, 101)
        Me.LabelControl24.Name = "LabelControl24"
        Me.LabelControl24.Size = New System.Drawing.Size(43, 13)
        Me.LabelControl24.TabIndex = 22
        Me.LabelControl24.Text = "Manzana"
        '
        'txtZonaCorregida
        '
        Me.txtZonaCorregida.Enabled = False
        Me.txtZonaCorregida.Location = New System.Drawing.Point(277, 72)
        Me.txtZonaCorregida.MenuManager = Me.ribbonPrincipal
        Me.txtZonaCorregida.Name = "txtZonaCorregida"
        Me.txtZonaCorregida.Size = New System.Drawing.Size(137, 20)
        Me.txtZonaCorregida.TabIndex = 24
        '
        'txtManzanaCorregida
        '
        Me.txtManzanaCorregida.Enabled = False
        Me.txtManzanaCorregida.Location = New System.Drawing.Point(277, 98)
        Me.txtManzanaCorregida.MenuManager = Me.ribbonPrincipal
        Me.txtManzanaCorregida.Name = "txtManzanaCorregida"
        Me.txtManzanaCorregida.Size = New System.Drawing.Size(137, 20)
        Me.txtManzanaCorregida.TabIndex = 25
        '
        'LabelControl25
        '
        Me.LabelControl25.Location = New System.Drawing.Point(51, 49)
        Me.LabelControl25.Name = "LabelControl25"
        Me.LabelControl25.Size = New System.Drawing.Size(23, 13)
        Me.LabelControl25.TabIndex = 26
        Me.LabelControl25.Text = "Calle"
        '
        'LabelControl26
        '
        Me.LabelControl26.Location = New System.Drawing.Point(37, 75)
        Me.LabelControl26.Name = "LabelControl26"
        Me.LabelControl26.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl26.TabIndex = 27
        Me.LabelControl26.Text = "Número"
        '
        'LabelControl27
        '
        Me.LabelControl27.Location = New System.Drawing.Point(17, 101)
        Me.LabelControl27.Name = "LabelControl27"
        Me.LabelControl27.Size = New System.Drawing.Size(57, 13)
        Me.LabelControl27.TabIndex = 28
        Me.LabelControl27.Text = "Casa/Depto"
        '
        'txtCalleCorregida
        '
        Me.txtCalleCorregida.Enabled = False
        Me.txtCalleCorregida.Location = New System.Drawing.Point(80, 46)
        Me.txtCalleCorregida.MenuManager = Me.ribbonPrincipal
        Me.txtCalleCorregida.Name = "txtCalleCorregida"
        Me.txtCalleCorregida.Size = New System.Drawing.Size(136, 20)
        Me.txtCalleCorregida.TabIndex = 29
        '
        'txtNumeroCorregido
        '
        Me.txtNumeroCorregido.Enabled = False
        Me.txtNumeroCorregido.Location = New System.Drawing.Point(80, 72)
        Me.txtNumeroCorregido.MenuManager = Me.ribbonPrincipal
        Me.txtNumeroCorregido.Name = "txtNumeroCorregido"
        Me.txtNumeroCorregido.Size = New System.Drawing.Size(136, 20)
        Me.txtNumeroCorregido.TabIndex = 30
        '
        'txtCasaDeptoCorregido
        '
        Me.txtCasaDeptoCorregido.Enabled = False
        Me.txtCasaDeptoCorregido.Location = New System.Drawing.Point(80, 98)
        Me.txtCasaDeptoCorregido.MenuManager = Me.ribbonPrincipal
        Me.txtCasaDeptoCorregido.Name = "txtCasaDeptoCorregido"
        Me.txtCasaDeptoCorregido.Size = New System.Drawing.Size(136, 20)
        Me.txtCasaDeptoCorregido.TabIndex = 31
        '
        'lkpComunaCorregida
        '
        Me.lkpComunaCorregida.Enabled = False
        Me.lkpComunaCorregida.Location = New System.Drawing.Point(277, 46)
        Me.lkpComunaCorregida.MenuManager = Me.ribbonPrincipal
        Me.lkpComunaCorregida.Name = "lkpComunaCorregida"
        Me.lkpComunaCorregida.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkpComunaCorregida.Properties.DataSource = Me.ComunaBindingSource
        Me.lkpComunaCorregida.Properties.DisplayMember = "Comuna"
        Me.lkpComunaCorregida.Properties.NullText = ""
        Me.lkpComunaCorregida.Properties.ValueMember = "ID"
        Me.lkpComunaCorregida.Properties.View = Me.GridView1
        Me.lkpComunaCorregida.Size = New System.Drawing.Size(137, 20)
        Me.lkpComunaCorregida.TabIndex = 23
        '
        'ComunaBindingSource
        '
        Me.ComunaBindingSource.DataMember = "Comuna"
        Me.ComunaBindingSource.DataSource = Me.datasetEOD
        '
        'GridView1
        '
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'lkpFolioCorregido
        '
        Me.lkpFolioCorregido.EditValue = ""
        Me.lkpFolioCorregido.Location = New System.Drawing.Point(79, 20)
        Me.lkpFolioCorregido.MenuManager = Me.ribbonPrincipal
        Me.lkpFolioCorregido.Name = "lkpFolioCorregido"
        Me.lkpFolioCorregido.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkpFolioCorregido.Properties.DataSource = Me.FolioNuevoBindingSource
        Me.lkpFolioCorregido.Properties.DisplayMember = "IDFolio"
        Me.lkpFolioCorregido.Properties.PopupFormMinSize = New System.Drawing.Size(137, 200)
        Me.lkpFolioCorregido.Properties.PopupFormSize = New System.Drawing.Size(137, 200)
        Me.lkpFolioCorregido.Properties.ShowFooter = False
        Me.lkpFolioCorregido.Properties.ValueMember = "IDFolio"
        Me.lkpFolioCorregido.Properties.View = Me.GridView2
        Me.lkpFolioCorregido.Size = New System.Drawing.Size(137, 20)
        Me.lkpFolioCorregido.TabIndex = 0
        '
        'FolioNuevoBindingSource
        '
        Me.FolioNuevoBindingSource.DataMember = "HogaresNoEncuestados"
        Me.FolioNuevoBindingSource.DataSource = Me.datasetEOD
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIDFolio})
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'colIDFolio
        '
        Me.colIDFolio.FieldName = "IDFolio"
        Me.colIDFolio.Name = "colIDFolio"
        Me.colIDFolio.OptionsColumn.AllowEdit = False
        Me.colIDFolio.OptionsColumn.AllowFocus = False
        Me.colIDFolio.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colIDFolio.Visible = True
        Me.colIDFolio.VisibleIndex = 0
        '
        'LabelControl29
        '
        Me.LabelControl29.Location = New System.Drawing.Point(44, 26)
        Me.LabelControl29.Name = "LabelControl29"
        Me.LabelControl29.Size = New System.Drawing.Size(29, 13)
        Me.LabelControl29.TabIndex = 2
        Me.LabelControl29.Text = "Hogar"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lkpFolioActual)
        Me.GroupBox1.Controls.Add(Me.LabelControl14)
        Me.GroupBox1.Controls.Add(Me.LabelControl17)
        Me.GroupBox1.Controls.Add(Me.LabelControl18)
        Me.GroupBox1.Controls.Add(Me.LabelControl19)
        Me.GroupBox1.Controls.Add(Me.txtZonaActual)
        Me.GroupBox1.Controls.Add(Me.txtManzanaActual)
        Me.GroupBox1.Controls.Add(Me.LabelControl22)
        Me.GroupBox1.Controls.Add(Me.LabelControl21)
        Me.GroupBox1.Controls.Add(Me.LabelControl20)
        Me.GroupBox1.Controls.Add(Me.txtCalleActual)
        Me.GroupBox1.Controls.Add(Me.txtNumeroActual)
        Me.GroupBox1.Controls.Add(Me.txtCasaDeptoActual)
        Me.GroupBox1.Controls.Add(Me.lkpComunaActual)
        Me.GroupBox1.Location = New System.Drawing.Point(75, 68)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(425, 140)
        Me.GroupBox1.TabIndex = 32
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Folio actual"
        '
        'lkpFolioActual
        '
        Me.lkpFolioActual.EditValue = ""
        Me.lkpFolioActual.Location = New System.Drawing.Point(79, 20)
        Me.lkpFolioActual.MenuManager = Me.ribbonPrincipal
        Me.lkpFolioActual.Name = "lkpFolioActual"
        Me.lkpFolioActual.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkpFolioActual.Properties.DataSource = Me.FolioActualBindingSource
        Me.lkpFolioActual.Properties.DisplayMember = "Hogar"
        Me.lkpFolioActual.Properties.PopupFormMinSize = New System.Drawing.Size(137, 200)
        Me.lkpFolioActual.Properties.PopupFormSize = New System.Drawing.Size(137, 200)
        Me.lkpFolioActual.Properties.ShowFooter = False
        Me.lkpFolioActual.Properties.ValueMember = "Hogar"
        Me.lkpFolioActual.Properties.View = Me.GridLookUpEdit1View
        Me.lkpFolioActual.Size = New System.Drawing.Size(137, 20)
        Me.lkpFolioActual.TabIndex = 0
        '
        'FolioActualBindingSource
        '
        Me.FolioActualBindingSource.DataMember = "Hogar"
        Me.FolioActualBindingSource.DataSource = Me.datasetEOD
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colHogar5})
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colHogar5
        '
        Me.colHogar5.FieldName = "Hogar"
        Me.colHogar5.Name = "colHogar5"
        Me.colHogar5.OptionsColumn.AllowEdit = False
        Me.colHogar5.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[False]
        Me.colHogar5.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colHogar5.OptionsColumn.ShowCaption = False
        Me.colHogar5.Visible = True
        Me.colHogar5.VisibleIndex = 0
        '
        'LabelControl14
        '
        Me.LabelControl14.Location = New System.Drawing.Point(44, 26)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(29, 13)
        Me.LabelControl14.TabIndex = 2
        Me.LabelControl14.Text = "Hogar"
        '
        'LabelControl17
        '
        Me.LabelControl17.Location = New System.Drawing.Point(231, 49)
        Me.LabelControl17.Name = "LabelControl17"
        Me.LabelControl17.Size = New System.Drawing.Size(39, 13)
        Me.LabelControl17.TabIndex = 5
        Me.LabelControl17.Text = "Comuna"
        '
        'LabelControl18
        '
        Me.LabelControl18.Location = New System.Drawing.Point(246, 75)
        Me.LabelControl18.Name = "LabelControl18"
        Me.LabelControl18.Size = New System.Drawing.Size(24, 13)
        Me.LabelControl18.TabIndex = 6
        Me.LabelControl18.Text = "Zona"
        '
        'LabelControl19
        '
        Me.LabelControl19.Location = New System.Drawing.Point(227, 101)
        Me.LabelControl19.Name = "LabelControl19"
        Me.LabelControl19.Size = New System.Drawing.Size(43, 13)
        Me.LabelControl19.TabIndex = 7
        Me.LabelControl19.Text = "Manzana"
        '
        'txtZonaActual
        '
        Me.txtZonaActual.Enabled = False
        Me.txtZonaActual.Location = New System.Drawing.Point(276, 72)
        Me.txtZonaActual.MenuManager = Me.ribbonPrincipal
        Me.txtZonaActual.Name = "txtZonaActual"
        Me.txtZonaActual.Size = New System.Drawing.Size(137, 20)
        Me.txtZonaActual.TabIndex = 12
        '
        'txtManzanaActual
        '
        Me.txtManzanaActual.Enabled = False
        Me.txtManzanaActual.Location = New System.Drawing.Point(276, 98)
        Me.txtManzanaActual.MenuManager = Me.ribbonPrincipal
        Me.txtManzanaActual.Name = "txtManzanaActual"
        Me.txtManzanaActual.Size = New System.Drawing.Size(137, 20)
        Me.txtManzanaActual.TabIndex = 13
        '
        'LabelControl22
        '
        Me.LabelControl22.Location = New System.Drawing.Point(50, 49)
        Me.LabelControl22.Name = "LabelControl22"
        Me.LabelControl22.Size = New System.Drawing.Size(23, 13)
        Me.LabelControl22.TabIndex = 14
        Me.LabelControl22.Text = "Calle"
        '
        'LabelControl21
        '
        Me.LabelControl21.Location = New System.Drawing.Point(36, 75)
        Me.LabelControl21.Name = "LabelControl21"
        Me.LabelControl21.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl21.TabIndex = 15
        Me.LabelControl21.Text = "Número"
        '
        'LabelControl20
        '
        Me.LabelControl20.Location = New System.Drawing.Point(16, 101)
        Me.LabelControl20.Name = "LabelControl20"
        Me.LabelControl20.Size = New System.Drawing.Size(57, 13)
        Me.LabelControl20.TabIndex = 16
        Me.LabelControl20.Text = "Casa/Depto"
        '
        'txtCalleActual
        '
        Me.txtCalleActual.Enabled = False
        Me.txtCalleActual.Location = New System.Drawing.Point(79, 46)
        Me.txtCalleActual.MenuManager = Me.ribbonPrincipal
        Me.txtCalleActual.Name = "txtCalleActual"
        Me.txtCalleActual.Size = New System.Drawing.Size(136, 20)
        Me.txtCalleActual.TabIndex = 17
        '
        'txtNumeroActual
        '
        Me.txtNumeroActual.Enabled = False
        Me.txtNumeroActual.Location = New System.Drawing.Point(79, 72)
        Me.txtNumeroActual.MenuManager = Me.ribbonPrincipal
        Me.txtNumeroActual.Name = "txtNumeroActual"
        Me.txtNumeroActual.Size = New System.Drawing.Size(136, 20)
        Me.txtNumeroActual.TabIndex = 18
        '
        'txtCasaDeptoActual
        '
        Me.txtCasaDeptoActual.Enabled = False
        Me.txtCasaDeptoActual.Location = New System.Drawing.Point(79, 98)
        Me.txtCasaDeptoActual.MenuManager = Me.ribbonPrincipal
        Me.txtCasaDeptoActual.Name = "txtCasaDeptoActual"
        Me.txtCasaDeptoActual.Size = New System.Drawing.Size(136, 20)
        Me.txtCasaDeptoActual.TabIndex = 19
        '
        'lkpComunaActual
        '
        Me.lkpComunaActual.Enabled = False
        Me.lkpComunaActual.Location = New System.Drawing.Point(276, 46)
        Me.lkpComunaActual.MenuManager = Me.ribbonPrincipal
        Me.lkpComunaActual.Name = "lkpComunaActual"
        Me.lkpComunaActual.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkpComunaActual.Properties.DataSource = Me.ComunaBindingSource
        Me.lkpComunaActual.Properties.DisplayMember = "Comuna"
        Me.lkpComunaActual.Properties.NullText = ""
        Me.lkpComunaActual.Properties.ValueMember = "ID"
        Me.lkpComunaActual.Properties.View = Me.GridLookUpEdit2View
        Me.lkpComunaActual.Size = New System.Drawing.Size(137, 20)
        Me.lkpComunaActual.TabIndex = 11
        '
        'GridLookUpEdit2View
        '
        Me.GridLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit2View.Name = "GridLookUpEdit2View"
        Me.GridLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit2View.OptionsView.ShowGroupPanel = False
        '
        'NavigationPage1
        '
        Me.NavigationPage1.Controls.Add(Me.GroupControl1)
        Me.NavigationPage1.Name = "NavigationPage1"
        Me.NavigationPage1.Size = New System.Drawing.Size(1022, 394)
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.SimpleButton1)
        Me.GroupControl1.Controls.Add(Me.btnCorregirDiaViajes)
        Me.GroupControl1.Controls.Add(Me.GroupBox3)
        Me.GroupControl1.Controls.Add(Me.GroupBox4)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(1022, 394)
        Me.GroupControl1.TabIndex = 3
        Me.GroupControl1.Text = "Corregir Día de Viajes"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.BackColor = System.Drawing.SystemColors.HotTrack
        Me.SimpleButton1.Appearance.BackColor2 = System.Drawing.SystemColors.HotTrack
        Me.SimpleButton1.Appearance.BorderColor = System.Drawing.SystemColors.HotTrack
        Me.SimpleButton1.Appearance.ForeColor = System.Drawing.Color.White
        Me.SimpleButton1.Appearance.Options.UseBackColor = True
        Me.SimpleButton1.Appearance.Options.UseBorderColor = True
        Me.SimpleButton1.Appearance.Options.UseForeColor = True
        Me.SimpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
        Me.SimpleButton1.Location = New System.Drawing.Point(903, 343)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(85, 28)
        Me.SimpleButton1.TabIndex = 35
        Me.SimpleButton1.Text = "Cancelar"
        '
        'btnCorregirDiaViajes
        '
        Me.btnCorregirDiaViajes.Appearance.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnCorregirDiaViajes.Appearance.BackColor2 = System.Drawing.SystemColors.HotTrack
        Me.btnCorregirDiaViajes.Appearance.BorderColor = System.Drawing.SystemColors.HotTrack
        Me.btnCorregirDiaViajes.Appearance.ForeColor = System.Drawing.Color.White
        Me.btnCorregirDiaViajes.Appearance.Options.UseBackColor = True
        Me.btnCorregirDiaViajes.Appearance.Options.UseBorderColor = True
        Me.btnCorregirDiaViajes.Appearance.Options.UseForeColor = True
        Me.btnCorregirDiaViajes.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
        Me.btnCorregirDiaViajes.Location = New System.Drawing.Point(812, 343)
        Me.btnCorregirDiaViajes.Name = "btnCorregirDiaViajes"
        Me.btnCorregirDiaViajes.Size = New System.Drawing.Size(85, 28)
        Me.btnCorregirDiaViajes.TabIndex = 34
        Me.btnCorregirDiaViajes.Text = "Corregir"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.LabelControl31)
        Me.GroupBox3.Controls.Add(Me.txtMotivoCambio)
        Me.GroupBox3.Controls.Add(Me.deNuevoDomingoLV)
        Me.GroupBox3.Controls.Add(Me.lblDomingoLV)
        Me.GroupBox3.Controls.Add(Me.deNuevoSabadoLV)
        Me.GroupBox3.Controls.Add(Me.lblSabadoLV)
        Me.GroupBox3.Controls.Add(Me.deNuevoDiaViajes)
        Me.GroupBox3.Controls.Add(Me.LabelControl43)
        Me.GroupBox3.Controls.Add(Me.LabelControl28)
        Me.GroupBox3.Controls.Add(Me.lkpNuevoTipoEncuesta)
        Me.GroupBox3.Location = New System.Drawing.Point(573, 68)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(415, 249)
        Me.GroupBox3.TabIndex = 33
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Nuevo Día de viajes"
        '
        'LabelControl31
        '
        Me.LabelControl31.Location = New System.Drawing.Point(30, 127)
        Me.LabelControl31.Name = "LabelControl31"
        Me.LabelControl31.Size = New System.Drawing.Size(135, 13)
        Me.LabelControl31.TabIndex = 53
        Me.LabelControl31.Text = "Indique el motivo del cambio"
        '
        'txtMotivoCambio
        '
        Me.txtMotivoCambio.Location = New System.Drawing.Point(171, 124)
        Me.txtMotivoCambio.Name = "txtMotivoCambio"
        Me.txtMotivoCambio.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.txtMotivoCambio.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.txtMotivoCambio.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtMotivoCambio.Size = New System.Drawing.Size(222, 72)
        Me.txtMotivoCambio.TabIndex = 52
        '
        'deNuevoDomingoLV
        '
        Me.deNuevoDomingoLV.EditValue = Nothing
        Me.deNuevoDomingoLV.Enabled = False
        Me.deNuevoDomingoLV.Location = New System.Drawing.Point(171, 98)
        Me.deNuevoDomingoLV.Name = "deNuevoDomingoLV"
        Me.deNuevoDomingoLV.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.deNuevoDomingoLV.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.deNuevoDomingoLV.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.deNuevoDomingoLV.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deNuevoDomingoLV.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deNuevoDomingoLV.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.deNuevoDomingoLV.Size = New System.Drawing.Size(222, 20)
        Me.deNuevoDomingoLV.TabIndex = 51
        Me.deNuevoDomingoLV.Visible = False
        '
        'lblDomingoLV
        '
        Me.lblDomingoLV.Location = New System.Drawing.Point(28, 101)
        Me.lblDomingoLV.Name = "lblDomingoLV"
        Me.lblDomingoLV.Size = New System.Drawing.Size(137, 13)
        Me.lblDomingoLV.TabIndex = 50
        Me.lblDomingoLV.Text = "Libro de Viajes - Día domingo"
        Me.lblDomingoLV.Visible = False
        '
        'deNuevoSabadoLV
        '
        Me.deNuevoSabadoLV.EditValue = Nothing
        Me.deNuevoSabadoLV.Location = New System.Drawing.Point(171, 72)
        Me.deNuevoSabadoLV.Name = "deNuevoSabadoLV"
        Me.deNuevoSabadoLV.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.deNuevoSabadoLV.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.deNuevoSabadoLV.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.deNuevoSabadoLV.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deNuevoSabadoLV.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deNuevoSabadoLV.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.deNuevoSabadoLV.Size = New System.Drawing.Size(222, 20)
        Me.deNuevoSabadoLV.TabIndex = 48
        Me.deNuevoSabadoLV.Visible = False
        '
        'lblSabadoLV
        '
        Me.lblSabadoLV.Location = New System.Drawing.Point(33, 75)
        Me.lblSabadoLV.Name = "lblSabadoLV"
        Me.lblSabadoLV.Size = New System.Drawing.Size(132, 13)
        Me.lblSabadoLV.TabIndex = 49
        Me.lblSabadoLV.Text = "Libro de Viajes - Día sábado"
        Me.lblSabadoLV.Visible = False
        '
        'deNuevoDiaViajes
        '
        Me.deNuevoDiaViajes.EditValue = Nothing
        Me.deNuevoDiaViajes.Location = New System.Drawing.Point(171, 45)
        Me.deNuevoDiaViajes.Name = "deNuevoDiaViajes"
        Me.deNuevoDiaViajes.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.deNuevoDiaViajes.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.deNuevoDiaViajes.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.deNuevoDiaViajes.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deNuevoDiaViajes.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deNuevoDiaViajes.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.deNuevoDiaViajes.Size = New System.Drawing.Size(222, 20)
        Me.deNuevoDiaViajes.TabIndex = 46
        '
        'LabelControl43
        '
        Me.LabelControl43.Location = New System.Drawing.Point(71, 48)
        Me.LabelControl43.Name = "LabelControl43"
        Me.LabelControl43.Size = New System.Drawing.Size(94, 13)
        Me.LabelControl43.TabIndex = 47
        Me.LabelControl43.Text = "Nuevo día de viajes"
        '
        'LabelControl28
        '
        Me.LabelControl28.Location = New System.Drawing.Point(51, 23)
        Me.LabelControl28.Name = "LabelControl28"
        Me.LabelControl28.Size = New System.Drawing.Size(114, 13)
        Me.LabelControl28.TabIndex = 13
        Me.LabelControl28.Text = "Nuevo tipo de encuesta"
        '
        'lkpNuevoTipoEncuesta
        '
        Me.lkpNuevoTipoEncuesta.Location = New System.Drawing.Point(171, 20)
        Me.lkpNuevoTipoEncuesta.MenuManager = Me.ribbonPrincipal
        Me.lkpNuevoTipoEncuesta.Name = "lkpNuevoTipoEncuesta"
        Me.lkpNuevoTipoEncuesta.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.lkpNuevoTipoEncuesta.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.lkpNuevoTipoEncuesta.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lkpNuevoTipoEncuesta.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkpNuevoTipoEncuesta.Properties.DataSource = Me.TipoDiaBindingSource
        Me.lkpNuevoTipoEncuesta.Properties.DisplayMember = "TipoDia"
        Me.lkpNuevoTipoEncuesta.Properties.NullText = ""
        Me.lkpNuevoTipoEncuesta.Properties.PopupFormMinSize = New System.Drawing.Size(137, 80)
        Me.lkpNuevoTipoEncuesta.Properties.PopupFormSize = New System.Drawing.Size(137, 80)
        Me.lkpNuevoTipoEncuesta.Properties.ShowFooter = False
        Me.lkpNuevoTipoEncuesta.Properties.ValueMember = "ID"
        Me.lkpNuevoTipoEncuesta.Properties.View = Me.GridView3
        Me.lkpNuevoTipoEncuesta.Size = New System.Drawing.Size(137, 20)
        Me.lkpNuevoTipoEncuesta.TabIndex = 12
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colTipoDia5})
        Me.GridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.deDomingoLVActual)
        Me.GroupBox4.Controls.Add(Me.lblDomingoLVActual)
        Me.GroupBox4.Controls.Add(Me.deSabadoLVActual)
        Me.GroupBox4.Controls.Add(Me.lblSabadoLVActual)
        Me.GroupBox4.Controls.Add(Me.deDiaViajesActual)
        Me.GroupBox4.Controls.Add(Me.LabelControl34)
        Me.GroupBox4.Controls.Add(Me.LabelControl30)
        Me.GroupBox4.Controls.Add(Me.lkpTipoEncuestaDiaActual)
        Me.GroupBox4.Controls.Add(Me.lkpFolioDiaActual)
        Me.GroupBox4.Controls.Add(Me.LabelControl36)
        Me.GroupBox4.Controls.Add(Me.LabelControl37)
        Me.GroupBox4.Controls.Add(Me.LabelControl38)
        Me.GroupBox4.Controls.Add(Me.LabelControl39)
        Me.GroupBox4.Controls.Add(Me.txtZonaDiaActual)
        Me.GroupBox4.Controls.Add(Me.txtManzanaDiaActual)
        Me.GroupBox4.Controls.Add(Me.LabelControl40)
        Me.GroupBox4.Controls.Add(Me.LabelControl41)
        Me.GroupBox4.Controls.Add(Me.LabelControl42)
        Me.GroupBox4.Controls.Add(Me.txtCalleDiaActual)
        Me.GroupBox4.Controls.Add(Me.txtNumeroDiaActual)
        Me.GroupBox4.Controls.Add(Me.txtCasaDeptoDiaActual)
        Me.GroupBox4.Controls.Add(Me.lkpComunaDiaActual)
        Me.GroupBox4.Location = New System.Drawing.Point(29, 68)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(520, 249)
        Me.GroupBox4.TabIndex = 32
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Folio a corregir"
        '
        'deDomingoLVActual
        '
        Me.deDomingoLVActual.EditValue = Nothing
        Me.deDomingoLVActual.Enabled = False
        Me.deDomingoLVActual.Location = New System.Drawing.Point(161, 203)
        Me.deDomingoLVActual.Name = "deDomingoLVActual"
        Me.deDomingoLVActual.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.deDomingoLVActual.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.deDomingoLVActual.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.deDomingoLVActual.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deDomingoLVActual.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deDomingoLVActual.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.deDomingoLVActual.Size = New System.Drawing.Size(222, 20)
        Me.deDomingoLVActual.TabIndex = 57
        Me.deDomingoLVActual.Visible = False
        '
        'lblDomingoLVActual
        '
        Me.lblDomingoLVActual.Location = New System.Drawing.Point(18, 206)
        Me.lblDomingoLVActual.Name = "lblDomingoLVActual"
        Me.lblDomingoLVActual.Size = New System.Drawing.Size(137, 13)
        Me.lblDomingoLVActual.TabIndex = 56
        Me.lblDomingoLVActual.Text = "Libro de Viajes - Día domingo"
        Me.lblDomingoLVActual.Visible = False
        '
        'deSabadoLVActual
        '
        Me.deSabadoLVActual.EditValue = Nothing
        Me.deSabadoLVActual.Enabled = False
        Me.deSabadoLVActual.Location = New System.Drawing.Point(161, 177)
        Me.deSabadoLVActual.Name = "deSabadoLVActual"
        Me.deSabadoLVActual.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.deSabadoLVActual.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.deSabadoLVActual.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.deSabadoLVActual.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deSabadoLVActual.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deSabadoLVActual.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.deSabadoLVActual.Size = New System.Drawing.Size(222, 20)
        Me.deSabadoLVActual.TabIndex = 54
        Me.deSabadoLVActual.Visible = False
        '
        'lblSabadoLVActual
        '
        Me.lblSabadoLVActual.Location = New System.Drawing.Point(23, 180)
        Me.lblSabadoLVActual.Name = "lblSabadoLVActual"
        Me.lblSabadoLVActual.Size = New System.Drawing.Size(132, 13)
        Me.lblSabadoLVActual.TabIndex = 55
        Me.lblSabadoLVActual.Text = "Libro de Viajes - Día sábado"
        Me.lblSabadoLVActual.Visible = False
        '
        'deDiaViajesActual
        '
        Me.deDiaViajesActual.EditValue = Nothing
        Me.deDiaViajesActual.Enabled = False
        Me.deDiaViajesActual.Location = New System.Drawing.Point(161, 150)
        Me.deDiaViajesActual.Name = "deDiaViajesActual"
        Me.deDiaViajesActual.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.deDiaViajesActual.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.deDiaViajesActual.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.deDiaViajesActual.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deDiaViajesActual.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deDiaViajesActual.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.deDiaViajesActual.Size = New System.Drawing.Size(222, 20)
        Me.deDiaViajesActual.TabIndex = 52
        '
        'LabelControl34
        '
        Me.LabelControl34.Location = New System.Drawing.Point(54, 153)
        Me.LabelControl34.Name = "LabelControl34"
        Me.LabelControl34.Size = New System.Drawing.Size(101, 13)
        Me.LabelControl34.TabIndex = 53
        Me.LabelControl34.Text = "Día de viajes (actual)"
        '
        'LabelControl30
        '
        Me.LabelControl30.Location = New System.Drawing.Point(73, 128)
        Me.LabelControl30.Name = "LabelControl30"
        Me.LabelControl30.Size = New System.Drawing.Size(82, 13)
        Me.LabelControl30.TabIndex = 21
        Me.LabelControl30.Text = "Tipo de encuesta"
        '
        'lkpTipoEncuestaDiaActual
        '
        Me.lkpTipoEncuestaDiaActual.Enabled = False
        Me.lkpTipoEncuestaDiaActual.Location = New System.Drawing.Point(161, 124)
        Me.lkpTipoEncuestaDiaActual.MenuManager = Me.ribbonPrincipal
        Me.lkpTipoEncuestaDiaActual.Name = "lkpTipoEncuestaDiaActual"
        Me.lkpTipoEncuestaDiaActual.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.lkpTipoEncuestaDiaActual.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.lkpTipoEncuestaDiaActual.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lkpTipoEncuestaDiaActual.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkpTipoEncuestaDiaActual.Properties.DataSource = Me.TipoDiaBindingSource
        Me.lkpTipoEncuestaDiaActual.Properties.DisplayMember = "TipoDia"
        Me.lkpTipoEncuestaDiaActual.Properties.NullText = ""
        Me.lkpTipoEncuestaDiaActual.Properties.ValueMember = "ID"
        Me.lkpTipoEncuestaDiaActual.Properties.View = Me.GridView4
        Me.lkpTipoEncuestaDiaActual.Size = New System.Drawing.Size(137, 20)
        Me.lkpTipoEncuestaDiaActual.TabIndex = 20
        '
        'GridView4
        '
        Me.GridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView4.Name = "GridView4"
        Me.GridView4.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView4.OptionsView.ShowGroupPanel = False
        '
        'lkpFolioDiaActual
        '
        Me.lkpFolioDiaActual.EditValue = ""
        Me.lkpFolioDiaActual.Location = New System.Drawing.Point(161, 20)
        Me.lkpFolioDiaActual.MenuManager = Me.ribbonPrincipal
        Me.lkpFolioDiaActual.Name = "lkpFolioDiaActual"
        Me.lkpFolioDiaActual.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lkpFolioDiaActual.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkpFolioDiaActual.Properties.DataSource = Me.FolioActualBindingSource
        Me.lkpFolioDiaActual.Properties.DisplayMember = "Hogar"
        Me.lkpFolioDiaActual.Properties.PopupFormMinSize = New System.Drawing.Size(137, 200)
        Me.lkpFolioDiaActual.Properties.PopupFormSize = New System.Drawing.Size(137, 200)
        Me.lkpFolioDiaActual.Properties.ShowFooter = False
        Me.lkpFolioDiaActual.Properties.ValueMember = "Hogar"
        Me.lkpFolioDiaActual.Properties.View = Me.GridView5
        Me.lkpFolioDiaActual.Size = New System.Drawing.Size(137, 20)
        Me.lkpFolioDiaActual.TabIndex = 0
        '
        'GridView5
        '
        Me.GridView5.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn2})
        Me.GridView5.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView5.Name = "GridView5"
        Me.GridView5.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView5.OptionsView.ShowGroupPanel = False
        '
        'GridColumn2
        '
        Me.GridColumn2.FieldName = "Hogar"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.AllowEdit = False
        Me.GridColumn2.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridColumn2.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridColumn2.OptionsColumn.ShowCaption = False
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 0
        '
        'LabelControl36
        '
        Me.LabelControl36.Location = New System.Drawing.Point(126, 26)
        Me.LabelControl36.Name = "LabelControl36"
        Me.LabelControl36.Size = New System.Drawing.Size(29, 13)
        Me.LabelControl36.TabIndex = 2
        Me.LabelControl36.Text = "Hogar"
        '
        'LabelControl37
        '
        Me.LabelControl37.Location = New System.Drawing.Point(313, 49)
        Me.LabelControl37.Name = "LabelControl37"
        Me.LabelControl37.Size = New System.Drawing.Size(39, 13)
        Me.LabelControl37.TabIndex = 5
        Me.LabelControl37.Text = "Comuna"
        '
        'LabelControl38
        '
        Me.LabelControl38.Location = New System.Drawing.Point(328, 75)
        Me.LabelControl38.Name = "LabelControl38"
        Me.LabelControl38.Size = New System.Drawing.Size(24, 13)
        Me.LabelControl38.TabIndex = 6
        Me.LabelControl38.Text = "Zona"
        '
        'LabelControl39
        '
        Me.LabelControl39.Location = New System.Drawing.Point(309, 101)
        Me.LabelControl39.Name = "LabelControl39"
        Me.LabelControl39.Size = New System.Drawing.Size(43, 13)
        Me.LabelControl39.TabIndex = 7
        Me.LabelControl39.Text = "Manzana"
        '
        'txtZonaDiaActual
        '
        Me.txtZonaDiaActual.Enabled = False
        Me.txtZonaDiaActual.Location = New System.Drawing.Point(358, 72)
        Me.txtZonaDiaActual.MenuManager = Me.ribbonPrincipal
        Me.txtZonaDiaActual.Name = "txtZonaDiaActual"
        Me.txtZonaDiaActual.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.txtZonaDiaActual.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtZonaDiaActual.Size = New System.Drawing.Size(137, 20)
        Me.txtZonaDiaActual.TabIndex = 12
        '
        'txtManzanaDiaActual
        '
        Me.txtManzanaDiaActual.Enabled = False
        Me.txtManzanaDiaActual.Location = New System.Drawing.Point(358, 98)
        Me.txtManzanaDiaActual.MenuManager = Me.ribbonPrincipal
        Me.txtManzanaDiaActual.Name = "txtManzanaDiaActual"
        Me.txtManzanaDiaActual.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.txtManzanaDiaActual.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtManzanaDiaActual.Size = New System.Drawing.Size(137, 20)
        Me.txtManzanaDiaActual.TabIndex = 13
        '
        'LabelControl40
        '
        Me.LabelControl40.Location = New System.Drawing.Point(132, 49)
        Me.LabelControl40.Name = "LabelControl40"
        Me.LabelControl40.Size = New System.Drawing.Size(23, 13)
        Me.LabelControl40.TabIndex = 14
        Me.LabelControl40.Text = "Calle"
        '
        'LabelControl41
        '
        Me.LabelControl41.Location = New System.Drawing.Point(118, 75)
        Me.LabelControl41.Name = "LabelControl41"
        Me.LabelControl41.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl41.TabIndex = 15
        Me.LabelControl41.Text = "Número"
        '
        'LabelControl42
        '
        Me.LabelControl42.Location = New System.Drawing.Point(98, 101)
        Me.LabelControl42.Name = "LabelControl42"
        Me.LabelControl42.Size = New System.Drawing.Size(57, 13)
        Me.LabelControl42.TabIndex = 16
        Me.LabelControl42.Text = "Casa/Depto"
        '
        'txtCalleDiaActual
        '
        Me.txtCalleDiaActual.Enabled = False
        Me.txtCalleDiaActual.Location = New System.Drawing.Point(161, 46)
        Me.txtCalleDiaActual.MenuManager = Me.ribbonPrincipal
        Me.txtCalleDiaActual.Name = "txtCalleDiaActual"
        Me.txtCalleDiaActual.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.txtCalleDiaActual.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtCalleDiaActual.Size = New System.Drawing.Size(136, 20)
        Me.txtCalleDiaActual.TabIndex = 17
        '
        'txtNumeroDiaActual
        '
        Me.txtNumeroDiaActual.Enabled = False
        Me.txtNumeroDiaActual.Location = New System.Drawing.Point(161, 72)
        Me.txtNumeroDiaActual.MenuManager = Me.ribbonPrincipal
        Me.txtNumeroDiaActual.Name = "txtNumeroDiaActual"
        Me.txtNumeroDiaActual.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.txtNumeroDiaActual.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtNumeroDiaActual.Size = New System.Drawing.Size(136, 20)
        Me.txtNumeroDiaActual.TabIndex = 18
        '
        'txtCasaDeptoDiaActual
        '
        Me.txtCasaDeptoDiaActual.Enabled = False
        Me.txtCasaDeptoDiaActual.Location = New System.Drawing.Point(161, 98)
        Me.txtCasaDeptoDiaActual.MenuManager = Me.ribbonPrincipal
        Me.txtCasaDeptoDiaActual.Name = "txtCasaDeptoDiaActual"
        Me.txtCasaDeptoDiaActual.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.txtCasaDeptoDiaActual.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtCasaDeptoDiaActual.Size = New System.Drawing.Size(136, 20)
        Me.txtCasaDeptoDiaActual.TabIndex = 19
        '
        'lkpComunaDiaActual
        '
        Me.lkpComunaDiaActual.Enabled = False
        Me.lkpComunaDiaActual.Location = New System.Drawing.Point(358, 46)
        Me.lkpComunaDiaActual.MenuManager = Me.ribbonPrincipal
        Me.lkpComunaDiaActual.Name = "lkpComunaDiaActual"
        Me.lkpComunaDiaActual.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.lkpComunaDiaActual.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.lkpComunaDiaActual.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lkpComunaDiaActual.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkpComunaDiaActual.Properties.DataSource = Me.ComunaBindingSource
        Me.lkpComunaDiaActual.Properties.DisplayMember = "Comuna"
        Me.lkpComunaDiaActual.Properties.NullText = ""
        Me.lkpComunaDiaActual.Properties.ValueMember = "ID"
        Me.lkpComunaDiaActual.Properties.View = Me.GridView6
        Me.lkpComunaDiaActual.Size = New System.Drawing.Size(137, 20)
        Me.lkpComunaDiaActual.TabIndex = 11
        '
        'GridView6
        '
        Me.GridView6.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView6.Name = "GridView6"
        Me.GridView6.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView6.OptionsView.ShowGroupPanel = False
        '
        'EncuestasPorEstadoTableAdapter
        '
        Me.EncuestasPorEstadoTableAdapter.ClearBeforeFill = True
        '
        'EncuestasPorEstadoBindingSource
        '
        Me.EncuestasPorEstadoBindingSource.DataMember = "EncuestasPorEstado"
        Me.EncuestasPorEstadoBindingSource.DataSource = Me.datasetEOD
        '
        'ResumenHogaresIncompletosTableAdapter
        '
        Me.ResumenHogaresIncompletosTableAdapter.ClearBeforeFill = True
        '
        'ResumenHogaresCompletosTableAdapter
        '
        Me.ResumenHogaresCompletosTableAdapter.ClearBeforeFill = True
        '
        'SchedulerBarController1
        '
        Me.SchedulerBarController1.Control = Me.calendarioAvance
        '
        'ZonasTableAdapter
        '
        Me.ZonasTableAdapter.ClearBeforeFill = True
        '
        'HogarTableAdapter
        '
        Me.HogarTableAdapter.ClearBeforeFill = True
        '
        'PersonaTableAdapter
        '
        Me.PersonaTableAdapter.ClearBeforeFill = True
        '
        'VehiculoTableAdapter
        '
        Me.VehiculoTableAdapter.ClearBeforeFill = True
        '
        'ValidaHogarTableAdapter
        '
        Me.ValidaHogarTableAdapter.ClearBeforeFill = True
        '
        'ValidaPersonaTableAdapter
        '
        Me.ValidaPersonaTableAdapter.ClearBeforeFill = True
        '
        'GraficoEncuestadosTableAdapter
        '
        Me.GraficoEncuestadosTableAdapter.ClearBeforeFill = True
        '
        'ResumenHogaresInconsistentesTableAdapter
        '
        Me.ResumenHogaresInconsistentesTableAdapter.ClearBeforeFill = True
        '
        'ResumenHogaresRechazadosTableAdapter
        '
        Me.ResumenHogaresRechazadosTableAdapter.ClearBeforeFill = True
        '
        'LabelComponent1
        '
        Me.LabelComponent1.AppearanceText.Font = New System.Drawing.Font("Segoe UI", 27.75!)
        Me.LabelComponent1.Name = "circularGauge1_Label1"
        Me.LabelComponent1.Size = New System.Drawing.SizeF(140.0!, 60.0!)
        Me.LabelComponent1.Text = "910"
        Me.LabelComponent1.UseColorScheme = False
        Me.LabelComponent1.ZOrder = -1001
        '
        'ArcScaleComponent1
        '
        Me.ArcScaleComponent1.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
        Me.ArcScaleComponent1.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
        Me.ArcScaleComponent1.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
        Me.ArcScaleComponent1.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
        Me.ArcScaleComponent1.AppearanceTickmarkText.Font = New System.Drawing.Font("Tahoma", 8.5!)
        Me.ArcScaleComponent1.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#484E5A")
        Me.ArcScaleComponent1.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125.0!, 125.0!)
        Me.ArcScaleComponent1.EndAngle = 90.0!
        Me.ArcScaleComponent1.MajorTickCount = 0
        Me.ArcScaleComponent1.MajorTickmark.FormatString = "{0:F0}"
        Me.ArcScaleComponent1.MajorTickmark.ShapeOffset = -14.0!
        Me.ArcScaleComponent1.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style16_1
        Me.ArcScaleComponent1.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
        Me.ArcScaleComponent1.MaxValue = 100.0!
        Me.ArcScaleComponent1.MinorTickCount = 0
        Me.ArcScaleComponent1.MinorTickmark.ShapeOffset = -7.0!
        Me.ArcScaleComponent1.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style16_2
        Me.ArcScaleComponent1.Name = "scale1"
        Me.ArcScaleComponent1.StartAngle = -270.0!
        Me.ArcScaleComponent1.Value = 20.0!
        '
        'ArcScaleRangeBarComponent1
        '
        Me.ArcScaleRangeBarComponent1.ArcScale = Me.ArcScaleComponent1
        Me.ArcScaleRangeBarComponent1.Name = "circularGauge1_RangeBar2"
        Me.ArcScaleRangeBarComponent1.RoundedCaps = True
        Me.ArcScaleRangeBarComponent1.ShowBackground = True
        Me.ArcScaleRangeBarComponent1.StartOffset = 80.0!
        Me.ArcScaleRangeBarComponent1.ZOrder = -10
        '
        'TipoDiaTableAdapter
        '
        Me.TipoDiaTableAdapter.ClearBeforeFill = True
        '
        'StateIndicatorComponent1
        '
        Me.StateIndicatorComponent1.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(124.0!, 124.0!)
        Me.StateIndicatorComponent1.Name = "stateIndicatorComponent4"
        Me.StateIndicatorComponent1.Size = New System.Drawing.SizeF(100.0!, 200.0!)
        Me.StateIndicatorComponent1.StateIndex = 3
        IndicatorState5.Name = "State1"
        IndicatorState5.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.TrafficLight1
        IndicatorState6.Name = "State2"
        IndicatorState6.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.TrafficLight2
        IndicatorState7.Name = "State3"
        IndicatorState7.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.TrafficLight3
        IndicatorState8.Name = "State4"
        IndicatorState8.ShapeType = DevExpress.XtraGauges.Core.Model.StateIndicatorShapeType.TrafficLight4
        Me.StateIndicatorComponent1.States.AddRange(New DevExpress.XtraGauges.Core.Model.IIndicatorState() {IndicatorState5, IndicatorState6, IndicatorState7, IndicatorState8})
        '
        'ExportacionesDataTableAdapter
        '
        Me.ExportacionesDataTableAdapter.ClearBeforeFill = True
        '
        'EncuestasRecogerHoyTableAdapter
        '
        Me.EncuestasRecogerHoyTableAdapter.ClearBeforeFill = True
        '
        'UltimaExportacionTableAdapter
        '
        Me.UltimaExportacionTableAdapter.ClearBeforeFill = True
        '
        'PersonasEncuestarHoyTableAdapter
        '
        Me.PersonasEncuestarHoyTableAdapter.ClearBeforeFill = True
        '
        'EncuestasRecoger1DiaTableAdapter
        '
        Me.EncuestasRecoger1DiaTableAdapter.ClearBeforeFill = True
        '
        'EncuestasRecoger2DiasTableAdapter
        '
        Me.EncuestasRecoger2DiasTableAdapter.ClearBeforeFill = True
        '
        'EncuestasRecogerMas2DiasTableAdapter
        '
        Me.EncuestasRecogerMas2DiasTableAdapter.ClearBeforeFill = True
        '
        'PersonasEncuestarHoyBindingSource
        '
        Me.PersonasEncuestarHoyBindingSource.DataMember = "PersonasEncuestarHoy"
        Me.PersonasEncuestarHoyBindingSource.DataSource = Me.datasetEOD
        '
        'EncuestasRecogerHoyBindingSource
        '
        Me.EncuestasRecogerHoyBindingSource.DataMember = "EncuestasRecogerHoy"
        Me.EncuestasRecogerHoyBindingSource.DataSource = Me.datasetEOD
        '
        'EncuestasRecoger2DiasBindingSource
        '
        Me.EncuestasRecoger2DiasBindingSource.DataMember = "EncuestasRecoger2Dias"
        Me.EncuestasRecoger2DiasBindingSource.DataSource = Me.datasetEOD
        '
        'EncuestasRecoger1DiaBindingSource
        '
        Me.EncuestasRecoger1DiaBindingSource.DataMember = "EncuestasRecoger1Dia"
        Me.EncuestasRecoger1DiaBindingSource.DataSource = Me.datasetEOD
        '
        'EncuestasRecogerMas2DiasBindingSource
        '
        Me.EncuestasRecogerMas2DiasBindingSource.DataMember = "EncuestasRecogerMas2Dias"
        Me.EncuestasRecogerMas2DiasBindingSource.DataSource = Me.datasetEOD
        '
        'EncuestasRecogerSemanaTableAdapter
        '
        Me.EncuestasRecogerSemanaTableAdapter.ClearBeforeFill = True
        '
        'EncuestasRecogerSemanaBindingSource
        '
        Me.EncuestasRecogerSemanaBindingSource.DataMember = "EncuestasRecogerSemana"
        Me.EncuestasRecogerSemanaBindingSource.DataSource = Me.datasetEOD
        '
        'dialogExcel
        '
        '
        'ComunaTableAdapter
        '
        Me.ComunaTableAdapter.ClearBeforeFill = True
        '
        'HogaresNoEncuestadosTableAdapter
        '
        Me.HogaresNoEncuestadosTableAdapter.ClearBeforeFill = True
        '
        'colTipoDia5
        '
        Me.colTipoDia5.FieldName = "TipoDia"
        Me.colTipoDia5.Name = "colTipoDia5"
        Me.colTipoDia5.OptionsColumn.AllowEdit = False
        Me.colTipoDia5.OptionsColumn.ShowCaption = False
        Me.colTipoDia5.Visible = True
        Me.colTipoDia5.VisibleIndex = 0
        '
        'GrillaResumen
        '
        Me.AllowFormGlass = DevExpress.Utils.DefaultBoolean.[True]
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1022, 559)
        Me.Controls.Add(Me.framePrincipal)
        Me.Controls.Add(Me.ribbonPrincipal)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "GrillaResumen"
        Me.Ribbon = Me.ribbonPrincipal
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Encuesta Origen Destino"
        CType(Me.GraficoEncuestadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.datasetEOD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.menuBackstage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.menuBackstage.ResumeLayout(False)
        CType(Me.BarAndDockingController1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.hojaConfiguracion.ResumeLayout(False)
        Me.hojaConfiguracion.PerformLayout()
        CType(Me.txtIDEquipo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ribbonPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDuration1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TipoDiaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemRadioGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemRadioGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemToggleSwitch1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemRadioGroup3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemRadioGroup4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemRadioGroup5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUsuarioFTP.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtClaveFTP.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtServidorFTP.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SchedulerStorage1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ZonasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridHogares, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ResumenHogaresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridViewHogares, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpHogares, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpHogares.ResumeLayout(False)
        CType(Me.grpPersonas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpPersonas.ResumeLayout(False)
        CType(Me.gridPersonas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ResumenPersonasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridViewPersonas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpVehiculos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpVehiculos.ResumeLayout(False)
        CType(Me.gridVehiculos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ResumenVehiculosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridViewVehiculos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.framePrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.framePrincipal.ResumeLayout(False)
        Me.navpageEncuestas.ResumeLayout(False)
        Me.navpageControlAv.ResumeLayout(False)
        CType(Me.frameControlAvance, System.ComponentModel.ISupportInitialize).EndInit()
        Me.frameControlAvance.ResumeLayout(False)
        Me.panelCompletas.ResumeLayout(False)
        CType(Me.gcCompletas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gcCompletas.ResumeLayout(False)
        CType(Me.gridCompletas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ResumenHogaresCompletosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridViewCompletas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelIncompletas.ResumeLayout(False)
        CType(Me.gcIncompletas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gcIncompletas.ResumeLayout(False)
        CType(Me.gridIncompletas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ResumenHogaresIncompletosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridViewIncompletas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelInconsistentes.ResumeLayout(False)
        CType(Me.gcInconsistentes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gcInconsistentes.ResumeLayout(False)
        CType(Me.gridInconsistentes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ResumenHogaresInconsistentesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridViewInconsistentes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelRechazos.ResumeLayout(False)
        CType(Me.gcRechazos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gcRechazos.ResumeLayout(False)
        CType(Me.gridRechazadas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ResumenHogaresRechazadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridViewRechazadas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelResumenAvance.ResumeLayout(False)
        Me.panelResumenAvance.PerformLayout()
        CType(Me.calendarioAvance, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.PictureEdit5.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureEdit6.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureEdit4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        Me.PanelControl3.PerformLayout()
        CType(Me.indicadorSemaforo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StateIndicatorComponent2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pageCambioFolio.ResumeLayout(False)
        CType(Me.gcCambioFolio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gcCambioFolio.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.txtZonaCorregida.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtManzanaCorregida.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCalleCorregida.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNumeroCorregido.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCasaDeptoCorregido.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkpComunaCorregida.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComunaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkpFolioCorregido.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FolioNuevoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.lkpFolioActual.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FolioActualBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtZonaActual.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtManzanaActual.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCalleActual.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNumeroActual.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCasaDeptoActual.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkpComunaActual.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit2View, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NavigationPage1.ResumeLayout(False)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.txtMotivoCambio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deNuevoDomingoLV.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deNuevoDomingoLV.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deNuevoSabadoLV.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deNuevoSabadoLV.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deNuevoDiaViajes.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deNuevoDiaViajes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkpNuevoTipoEncuesta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.deDomingoLVActual.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deDomingoLVActual.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deSabadoLVActual.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deSabadoLVActual.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deDiaViajesActual.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deDiaViajesActual.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkpTipoEncuestaDiaActual.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkpFolioDiaActual.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtZonaDiaActual.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtManzanaDiaActual.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCalleDiaActual.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNumeroDiaActual.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCasaDeptoDiaActual.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkpComunaDiaActual.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EncuestasPorEstadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SchedulerBarController1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LabelComponent1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArcScaleComponent1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArcScaleRangeBarComponent1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StateIndicatorComponent1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PersonasEncuestarHoyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EncuestasRecogerHoyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EncuestasRecoger2DiasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EncuestasRecoger1DiaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EncuestasRecogerMas2DiasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EncuestasRecogerSemanaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents menuBackstage As DevExpress.XtraBars.Ribbon.BackstageViewControl
    Friend WithEvents gridHogares As DevExpress.XtraGrid.GridControl
    Friend WithEvents ResumenHogaresBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents datasetEOD As EOD.datasetEOD
    Friend WithEvents gridViewHogares As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colHogar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colZona As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombreCalle As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNumero As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCasaDepto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFecha As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTipoDia As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ResumenHogaresTableAdapter As EOD.datasetEODTableAdapters.ResumenHogaresTableAdapter
    Friend WithEvents DefaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    Friend WithEvents grpHogares As DevExpress.XtraEditors.GroupControl
    Friend WithEvents grpPersonas As DevExpress.XtraEditors.GroupControl
    Friend WithEvents gridPersonas As DevExpress.XtraGrid.GridControl
    Friend WithEvents ResumenPersonasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents gridViewPersonas As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colHogarPersona As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPersona As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombrePila As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSexo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRelacion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ResumenPersonasTableAdapter As EOD.datasetEODTableAdapters.ResumenPersonasTableAdapter
    Friend WithEvents cargaDatosBackground As System.ComponentModel.BackgroundWorker
    Friend WithEvents DefaultLookAndFeel2 As DevExpress.LookAndFeel.DefaultLookAndFeel
    Friend WithEvents grpVehiculos As DevExpress.XtraEditors.GroupControl
    Friend WithEvents ResumenVehiculosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ResumenVehiculosTableAdapter As EOD.datasetEODTableAdapters.ResumenVehiculosTableAdapter
    Friend WithEvents hojaConfiguracion As DevExpress.XtraBars.Ribbon.BackstageViewClientControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtServidorFTP As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents itemConfig As DevExpress.XtraBars.Ribbon.BackstageViewTabItem
    Friend WithEvents BackstageViewItemSeparator1 As DevExpress.XtraBars.Ribbon.BackstageViewItemSeparator
    Friend WithEvents txtUsuarioFTP As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtClaveFTP As DevExpress.XtraEditors.TextEdit
    Friend WithEvents gridVehiculos As DevExpress.XtraGrid.GridControl
    Friend WithEvents gridViewVehiculos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colVehículo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colvehiculo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents framePrincipal As DevExpress.XtraBars.Navigation.NavigationFrame
    Friend WithEvents navpageEncuestas As DevExpress.XtraBars.Navigation.NavigationPage
    Friend WithEvents navpageControlAv As DevExpress.XtraBars.Navigation.NavigationPage
    Friend WithEvents frameControlAvance As DevExpress.XtraBars.Navigation.NavigationFrame
    Friend WithEvents panelCompletas As DevExpress.XtraBars.Navigation.NavigationPage
    Friend WithEvents gcCompletas As DevExpress.XtraEditors.GroupControl
    Friend WithEvents BarAndDockingController1 As DevExpress.XtraBars.BarAndDockingController
    Friend WithEvents panelIncompletas As DevExpress.XtraBars.Navigation.NavigationPage
    Friend WithEvents gcIncompletas As DevExpress.XtraEditors.GroupControl
    Friend WithEvents gridIncompletas As DevExpress.XtraGrid.GridControl
    Friend WithEvents gridViewIncompletas As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ResumenHogaresIncompletosTableAdapter As EOD.datasetEODTableAdapters.ResumenHogaresIncompletosTableAdapter
    Friend WithEvents colHogar3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colZona2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colComuna2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombreCalle2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNumero2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCasaDepto2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFecha2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTipoDia2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gridCompletas As DevExpress.XtraGrid.GridControl
    Friend WithEvents gridViewCompletas As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ResumenHogaresIncompletosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ResumenHogaresCompletosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ResumenHogaresCompletosTableAdapter As EOD.datasetEODTableAdapters.ResumenHogaresCompletosTableAdapter
    Friend WithEvents colHogar2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colZona1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colComuna1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombreCalle1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNumero1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCasaDepto1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFecha1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTipoDia1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents panelInconsistentes As DevExpress.XtraBars.Navigation.NavigationPage
    Friend WithEvents gcInconsistentes As DevExpress.XtraEditors.GroupControl
    Friend WithEvents panelRechazos As DevExpress.XtraBars.Navigation.NavigationPage
    Friend WithEvents gcRechazos As DevExpress.XtraEditors.GroupControl
    Friend WithEvents panelResumenAvance As DevExpress.XtraBars.Navigation.NavigationPage
    Friend WithEvents SchedulerStorage1 As DevExpress.XtraScheduler.SchedulerStorage
    Friend WithEvents SchedulerBarController1 As DevExpress.XtraScheduler.UI.SchedulerBarController
    Friend WithEvents ZonasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ZonasTableAdapter As EOD.datasetEODTableAdapters.ZonasTableAdapter
    Friend WithEvents colFechaVisita1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEncuestado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtIDEquipo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ribbonPrincipal As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents btnModificarHogar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnEliminarHogar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnAgregarPersona As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnModificarPersona As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnEliminarPersona As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnIngresarViajes As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnAgregarVehiculo As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnModificarVehiculo As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnEliminarVehiculo As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCuadroResumen As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents OpenScheduleItem1 As DevExpress.XtraScheduler.UI.OpenScheduleItem
    Friend WithEvents SaveScheduleItem1 As DevExpress.XtraScheduler.UI.SaveScheduleItem
    Friend WithEvents PrintPreviewItem1 As DevExpress.XtraScheduler.UI.PrintPreviewItem
    Friend WithEvents PrintItem1 As DevExpress.XtraScheduler.UI.PrintItem
    Friend WithEvents PrintPageSetupItem1 As DevExpress.XtraScheduler.UI.PrintPageSetupItem
    Friend WithEvents NewAppointmentItem1 As DevExpress.XtraScheduler.UI.NewAppointmentItem
    Friend WithEvents NewRecurringAppointmentItem1 As DevExpress.XtraScheduler.UI.NewRecurringAppointmentItem
    Friend WithEvents NavigateViewBackwardItem1 As DevExpress.XtraScheduler.UI.NavigateViewBackwardItem
    Friend WithEvents NavigateViewForwardItem1 As DevExpress.XtraScheduler.UI.NavigateViewForwardItem
    Friend WithEvents GotoTodayItem1 As DevExpress.XtraScheduler.UI.GotoTodayItem
    Friend WithEvents ViewZoomInItem1 As DevExpress.XtraScheduler.UI.ViewZoomInItem
    Friend WithEvents ViewZoomOutItem1 As DevExpress.XtraScheduler.UI.ViewZoomOutItem
    Friend WithEvents SwitchToDayViewItem1 As DevExpress.XtraScheduler.UI.SwitchToDayViewItem
    Friend WithEvents SwitchToWeekViewItem1 As DevExpress.XtraScheduler.UI.SwitchToWeekViewItem
    Friend WithEvents SwitchToFullWeekViewItem1 As DevExpress.XtraScheduler.UI.SwitchToFullWeekViewItem
    Friend WithEvents SwitchToMonthViewItem1 As DevExpress.XtraScheduler.UI.SwitchToMonthViewItem
    Friend WithEvents SwitchTimeScalesItem1 As DevExpress.XtraScheduler.UI.SwitchTimeScalesItem
    Friend WithEvents ChangeScaleWidthItem1 As DevExpress.XtraScheduler.UI.ChangeScaleWidthItem
    Friend WithEvents RepositoryItemSpinEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents SwitchTimeScalesCaptionItem1 As DevExpress.XtraScheduler.UI.SwitchTimeScalesCaptionItem
    Friend WithEvents SwitchCompressWeekendItem1 As DevExpress.XtraScheduler.UI.SwitchCompressWeekendItem
    Friend WithEvents SwitchShowWorkTimeOnlyItem1 As DevExpress.XtraScheduler.UI.SwitchShowWorkTimeOnlyItem
    Friend WithEvents SwitchCellsAutoHeightItem1 As DevExpress.XtraScheduler.UI.SwitchCellsAutoHeightItem
    Friend WithEvents ChangeSnapToCellsUIItem1 As DevExpress.XtraScheduler.UI.ChangeSnapToCellsUIItem
    Friend WithEvents EditAppointmentQueryItem1 As DevExpress.XtraScheduler.UI.EditAppointmentQueryItem
    Friend WithEvents EditOccurrenceUICommandItem1 As DevExpress.XtraScheduler.UI.EditOccurrenceUICommandItem
    Friend WithEvents EditSeriesUICommandItem1 As DevExpress.XtraScheduler.UI.EditSeriesUICommandItem
    Friend WithEvents DeleteAppointmentsItem1 As DevExpress.XtraScheduler.UI.DeleteAppointmentsItem
    Friend WithEvents DeleteOccurrenceItem1 As DevExpress.XtraScheduler.UI.DeleteOccurrenceItem
    Friend WithEvents DeleteSeriesItem1 As DevExpress.XtraScheduler.UI.DeleteSeriesItem
    Friend WithEvents SplitAppointmentItem1 As DevExpress.XtraScheduler.UI.SplitAppointmentItem
    Friend WithEvents ChangeAppointmentStatusItem1 As DevExpress.XtraScheduler.UI.ChangeAppointmentStatusItem
    Friend WithEvents ChangeAppointmentLabelItem1 As DevExpress.XtraScheduler.UI.ChangeAppointmentLabelItem
    Friend WithEvents ToggleRecurrenceItem1 As DevExpress.XtraScheduler.UI.ToggleRecurrenceItem
    Friend WithEvents ChangeAppointmentReminderItem1 As DevExpress.XtraScheduler.UI.ChangeAppointmentReminderItem
    Friend WithEvents RepositoryItemDuration1 As DevExpress.XtraScheduler.UI.RepositoryItemDuration
    Friend WithEvents btnNuevoHogar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents lkpTipoEncuestaMapa As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents lkpSeleccionZonaMapa As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents btnSubirDatos As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCerrarSesion As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents CalendarToolsRibbonPageCategory1 As DevExpress.XtraScheduler.UI.CalendarToolsRibbonPageCategory
    Friend WithEvents pagEncuestas As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup4 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup3 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup6 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents pagControlAvance As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup5 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RepositoryItemRadioGroup1 As DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup
    Friend WithEvents RepositoryItemRadioGroup2 As DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup
    Friend WithEvents RepositoryItemToggleSwitch1 As DevExpress.XtraEditors.Repository.RepositoryItemToggleSwitch
    Friend WithEvents RepositoryItemRadioGroup3 As DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup
    Friend WithEvents RepositoryItemRadioGroup4 As DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup
    Friend WithEvents RepositoryItemRadioGroup5 As DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents HogarTableAdapter As EOD.datasetEODTableAdapters.HogarTableAdapter
    Friend WithEvents PersonaTableAdapter As EOD.datasetEODTableAdapters.PersonaTableAdapter
    Friend WithEvents VehiculoTableAdapter As EOD.datasetEODTableAdapters.VehiculoTableAdapter
    Friend WithEvents btnGuardarConf As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ValidaHogarTableAdapter As EOD.datasetEODTableAdapters.ValidaHogarTableAdapter
    Friend WithEvents ValidaPersonaTableAdapter As EOD.datasetEODTableAdapters.ValidaPersonaTableAdapter
    Friend WithEvents btnValidar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents colEstadoEncuesta As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GraficoEncuestadosTableAdapter As EOD.datasetEODTableAdapters.GraficoEncuestadosTableAdapter
    Friend WithEvents GraficoEncuestadosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents EncuestasPorEstadoTableAdapter As EOD.datasetEODTableAdapters.EncuestasPorEstadoTableAdapter
    Friend WithEvents EncuestasPorEstadoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ResumenHogaresInconsistentesTableAdapter As EOD.datasetEODTableAdapters.ResumenHogaresInconsistentesTableAdapter
    Friend WithEvents ResumenHogaresRechazadosTableAdapter As EOD.datasetEODTableAdapters.ResumenHogaresRechazadosTableAdapter
    Private WithEvents LabelComponent1 As DevExpress.XtraGauges.Win.Base.LabelComponent
    Private WithEvents ArcScaleComponent1 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent
    Private WithEvents ArcScaleRangeBarComponent1 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleRangeBarComponent
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblEncuestasRecogerHoy As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblPersonasEncuestarDia As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblEncuestasRechazadas As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblEncuestasInconsistentes As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PictureEdit5 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents PictureEdit6 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblEncuestasIncompletas As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblEncuestasCompletas As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PictureEdit3 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents PictureEdit4 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents PictureEdit2 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents calendarioAvance As DevExpress.XtraScheduler.SchedulerControl
    Friend WithEvents TipoDiaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TipoDiaTableAdapter As EOD.datasetEODTableAdapters.TipoDiaTableAdapter
    Friend WithEvents RibbonPageGroup7 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents btnCompletas As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnIncompletas As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnInconsistentes As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnRechazadas As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents lblMensajeEnvio As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblUltimaExportacion As DevExpress.XtraEditors.LabelControl
    Friend WithEvents semaforoCarga As DevExpress.XtraGauges.Win.GaugeControl
    Friend WithEvents indicadorSemaforo As DevExpress.XtraGauges.Win.Gauges.State.StateIndicatorGauge
    Private WithEvents StateIndicatorComponent2 As DevExpress.XtraGauges.Win.Gauges.State.StateIndicatorComponent
    Private WithEvents StateIndicatorComponent1 As DevExpress.XtraGauges.Win.Gauges.State.StateIndicatorComponent
    Friend WithEvents RibbonPageGroup8 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents btnExportarExcel As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ExportacionesDataTableAdapter As EOD.datasetEODTableAdapters.ExportacionesDataTableAdapter
    Friend WithEvents EncuestasRecogerHoyTableAdapter As EOD.datasetEODTableAdapters.EncuestasRecogerHoyTableAdapter
    Friend WithEvents UltimaExportacionTableAdapter As EOD.datasetEODTableAdapters.UltimaExportacionTableAdapter
    Friend WithEvents PersonasEncuestarHoyTableAdapter As EOD.datasetEODTableAdapters.PersonasEncuestarHoyTableAdapter
    Friend WithEvents EncuestasRecoger1DiaTableAdapter As EOD.datasetEODTableAdapters.EncuestasRecoger1DiaTableAdapter
    Friend WithEvents EncuestasRecoger2DiasTableAdapter As EOD.datasetEODTableAdapters.EncuestasRecoger2DiasTableAdapter
    Friend WithEvents EncuestasRecogerMas2DiasTableAdapter As EOD.datasetEODTableAdapters.EncuestasRecogerMas2DiasTableAdapter
    Friend WithEvents PersonasEncuestarHoyBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EncuestasRecogerHoyBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EncuestasRecoger2DiasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EncuestasRecoger1DiaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EncuestasRecogerMas2DiasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents btnActualizar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblVersion As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents EncuestasRecogerSemanaTableAdapter As EOD.datasetEODTableAdapters.EncuestasRecogerSemanaTableAdapter
    Friend WithEvents EncuestasRecogerSemanaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents dialogExcel As System.Windows.Forms.SaveFileDialog
    Friend WithEvents gridRechazadas As DevExpress.XtraGrid.GridControl
    Friend WithEvents ResumenHogaresRechazadosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents gridViewRechazadas As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colHogar1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colZona3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colComuna As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombreCalle3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNumero3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCasaDepto3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFechaViajes As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTipoDia3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEstadoEncuesta1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEstadoEncuesta2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gridInconsistentes As DevExpress.XtraGrid.GridControl
    Friend WithEvents ResumenHogaresInconsistentesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents gridViewInconsistentes As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colHogar4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colZona4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colComuna3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombreCalle4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNumero4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCasaDepto4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFechaViajes1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTipoDia4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCombustible As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colComuna4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGPS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEncuestadoLab As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEncuestadoSab As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEncuestadoDom As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnCopiarViajes As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCambioFolio As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents pageCambioFolio As DevExpress.XtraBars.Navigation.NavigationPage
    Friend WithEvents gcCambioFolio As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lkpFolioCorregido As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents FolioActualBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl29 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lkpFolioActual As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl17 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl18 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl19 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtZonaActual As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtManzanaActual As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl22 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl21 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl20 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCalleActual As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNumeroActual As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCasaDeptoActual As DevExpress.XtraEditors.TextEdit
    Friend WithEvents FolioNuevoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents btnCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnActualizarFolio As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lkpComunaActual As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit2View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ComunaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ComunaTableAdapter As EOD.datasetEODTableAdapters.ComunaTableAdapter
    Friend WithEvents HogaresNoEncuestadosTableAdapter As EOD.datasetEODTableAdapters.HogaresNoEncuestadosTableAdapter
    Friend WithEvents colIDFolio As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHogar5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl23 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl24 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtZonaCorregida As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtManzanaCorregida As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl25 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl26 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl27 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCalleCorregida As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNumeroCorregido As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCasaDeptoCorregido As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lkpComunaCorregida As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btnCambiarDiaViajes As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents NavigationPage1 As DevExpress.XtraBars.Navigation.NavigationPage
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCorregirDiaViajes As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents LabelControl28 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lkpNuevoTipoEncuesta As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents lkpFolioDiaActual As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView5 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl36 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl37 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl38 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl39 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtZonaDiaActual As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtManzanaDiaActual As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl40 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl41 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl42 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCalleDiaActual As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNumeroDiaActual As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCasaDeptoDiaActual As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lkpComunaDiaActual As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView6 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl30 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lkpTipoEncuestaDiaActual As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents deNuevoDomingoLV As DevExpress.XtraEditors.DateEdit
    Friend WithEvents lblDomingoLV As DevExpress.XtraEditors.LabelControl
    Friend WithEvents deNuevoSabadoLV As DevExpress.XtraEditors.DateEdit
    Friend WithEvents lblSabadoLV As DevExpress.XtraEditors.LabelControl
    Friend WithEvents deNuevoDiaViajes As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl43 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl31 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtMotivoCambio As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents deDomingoLVActual As DevExpress.XtraEditors.DateEdit
    Friend WithEvents lblDomingoLVActual As DevExpress.XtraEditors.LabelControl
    Friend WithEvents deSabadoLVActual As DevExpress.XtraEditors.DateEdit
    Friend WithEvents lblSabadoLVActual As DevExpress.XtraEditors.LabelControl
    Friend WithEvents deDiaViajesActual As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl34 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents colTipoDia5 As DevExpress.XtraGrid.Columns.GridColumn

End Class
