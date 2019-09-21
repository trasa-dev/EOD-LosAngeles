<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ResumenViajes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ResumenViajes))
        Me.RibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.btnIngresarViaje = New DevExpress.XtraBars.BarButtonItem()
        Me.btnModificarViaje = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem5 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem6 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem7 = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.gridViajes = New DevExpress.XtraGrid.GridControl()
        Me.ResumenViajesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.datasetEOD = New EOD.datasetEOD()
        Me.gridViewViajes = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colHogar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPersona = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colViaje = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHoraIni = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHorafin = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProposito = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colComunaOri_Comuna = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colManzanaOrigen = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNombreCalle1Origen = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNumeroOCalle2Origen = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHitoOrigen = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colComunaDes_Comuna = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNombreCalle1Destino = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNumeroOCalle2Destino = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHitoDestino = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colManzanaDestino = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ResumenViajesTableAdapter = New EOD.datasetEODTableAdapters.ResumenViajesTableAdapter()
        Me.ResumenEtapasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ResumenEtapasTableAdapter = New EOD.datasetEODTableAdapters.ResumenEtapasTableAdapter()
        Me.SharedImageCollection1 = New DevExpress.Utils.SharedImageCollection(Me.components)
        Me.datasetEOD1 = New EOD.datasetEOD()
        Me.panelEtapas = New DevExpress.XtraBars.Navigation.TabPane()
        Me.tab1etapa = New DevExpress.XtraBars.Navigation.TabNavigationPage()
        Me.XtraScrollableControl1 = New DevExpress.XtraEditors.XtraScrollableControl()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.txtHoraFinViajeE1 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtMedioE1 = New System.Windows.Forms.Label()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.txtFinViajeE1 = New DevExpress.XtraEditors.LabelControl()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtHoraIniViajeE1 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.txtEtapaE1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtInicioViajeE1 = New DevExpress.XtraEditors.LabelControl()
        Me.imgTransporteE1 = New DevExpress.XtraEditors.PictureEdit()
        Me.LabelControl23 = New DevExpress.XtraEditors.LabelControl()
        Me.tab2etapas = New DevExpress.XtraBars.Navigation.TabNavigationPage()
        Me.scroll2 = New DevExpress.XtraEditors.XtraScrollableControl()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.txtHoraFinViajeE2 = New System.Windows.Forms.Label()
        Me.txtMedio2E2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtMedio1E2 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.txtFinViajeE2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtHoraIniViajeE2 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtEtapa2E2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtEtapa1E2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtInicioViajeE2 = New DevExpress.XtraEditors.LabelControl()
        Me.imgTransporte2E2 = New DevExpress.XtraEditors.PictureEdit()
        Me.imgTransporte1E2 = New DevExpress.XtraEditors.PictureEdit()
        Me.LabelControl18 = New DevExpress.XtraEditors.LabelControl()
        Me.tab3etapas = New DevExpress.XtraBars.Navigation.TabNavigationPage()
        Me.scroll3 = New DevExpress.XtraEditors.XtraScrollableControl()
        Me.GroupControl4 = New DevExpress.XtraEditors.GroupControl()
        Me.txtHoraFinViajeE3 = New System.Windows.Forms.Label()
        Me.txtMedio2E3 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txtMedio1E3 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.txtMedio3E3 = New System.Windows.Forms.Label()
        Me.LabelControl19 = New DevExpress.XtraEditors.LabelControl()
        Me.txtFinViajeE3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl24 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl25 = New DevExpress.XtraEditors.LabelControl()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.txtHoraIniViajeE3 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.txtEtapa3E3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtEtapa2E3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtEtapa1E3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtInicioViajeE3 = New DevExpress.XtraEditors.LabelControl()
        Me.imgTransporte3E3 = New DevExpress.XtraEditors.PictureEdit()
        Me.imgTransporte2E3 = New DevExpress.XtraEditors.PictureEdit()
        Me.imgTransporte1E3 = New DevExpress.XtraEditors.PictureEdit()
        Me.LabelControl30 = New DevExpress.XtraEditors.LabelControl()
        Me.tabDetalle = New DevExpress.XtraBars.Navigation.TabNavigationPage()
        Me.gridEtapas = New DevExpress.XtraGrid.GridControl()
        Me.gridViewEtapas = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colHogar1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPersona1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colViaje1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEtapa = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colModo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colComunaOri_Comuna1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colManzanaOrigen1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNombreCalle1Origen1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNumeroOCalle2Origen1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHitoOrigen1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colComunaDes_Comuna1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colManzanaDestino1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNombreCalle1Destino1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNumeroOCalle2Destino1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHitoDestino1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.imageCollectionModos = New DevExpress.Utils.ImageCollection(Me.components)
        Me.cargaDatosBackground = New System.ComponentModel.BackgroundWorker()
        Me.PersonaTableAdapter = New EOD.datasetEODTableAdapters.PersonaTableAdapter()
        Me.rgTipoDia = New DevExpress.XtraEditors.RadioGroup()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridViajes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ResumenViajesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.datasetEOD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridViewViajes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ResumenEtapasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SharedImageCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SharedImageCollection1.ImageSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.datasetEOD1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.panelEtapas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelEtapas.SuspendLayout()
        Me.tab1etapa.SuspendLayout()
        Me.XtraScrollableControl1.SuspendLayout()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.imgTransporteE1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab2etapas.SuspendLayout()
        Me.scroll2.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.imgTransporte2E2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgTransporte1E2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab3etapas.SuspendLayout()
        Me.scroll3.SuspendLayout()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl4.SuspendLayout()
        CType(Me.imgTransporte3E3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgTransporte2E3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgTransporte1E3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabDetalle.SuspendLayout()
        CType(Me.gridEtapas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridViewEtapas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imageCollectionModos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgTipoDia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonControl
        '
        Me.RibbonControl.ExpandCollapseItem.Id = 0
        Me.RibbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl.ExpandCollapseItem, Me.BarButtonItem1, Me.btnIngresarViaje, Me.btnModificarViaje, Me.BarButtonItem5, Me.BarButtonItem6, Me.BarButtonItem7})
        Me.RibbonControl.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl.MaxItemId = 10
        Me.RibbonControl.Name = "RibbonControl"
        Me.RibbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.TabletOffice
        Me.RibbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl.ShowCategoryInCaption = False
        Me.RibbonControl.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide
        Me.RibbonControl.ShowToolbarCustomizeItem = False
        Me.RibbonControl.Size = New System.Drawing.Size(1022, 56)
        Me.RibbonControl.Toolbar.ShowCustomizeItem = False
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "BarButtonItem1"
        Me.BarButtonItem1.Id = 3
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'btnIngresarViaje
        '
        Me.btnIngresarViaje.Caption = "Nuevo"
        Me.btnIngresarViaje.Id = 4
        Me.btnIngresarViaje.ImageOptions.Image = CType(resources.GetObject("btnIngresarViaje.ImageOptions.Image"), System.Drawing.Image)
        Me.btnIngresarViaje.ImageOptions.LargeImage = CType(resources.GetObject("btnIngresarViaje.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnIngresarViaje.Name = "btnIngresarViaje"
        Me.btnIngresarViaje.RibbonStyle = CType((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText), DevExpress.XtraBars.Ribbon.RibbonItemStyles)
        '
        'btnModificarViaje
        '
        Me.btnModificarViaje.Caption = "Modificar"
        Me.btnModificarViaje.Id = 5
        Me.btnModificarViaje.ImageOptions.Image = CType(resources.GetObject("btnModificarViaje.ImageOptions.Image"), System.Drawing.Image)
        Me.btnModificarViaje.ImageOptions.LargeImage = CType(resources.GetObject("btnModificarViaje.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnModificarViaje.Name = "btnModificarViaje"
        Me.btnModificarViaje.RibbonStyle = CType((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText), DevExpress.XtraBars.Ribbon.RibbonItemStyles)
        '
        'BarButtonItem5
        '
        Me.BarButtonItem5.Caption = "Eliminar"
        Me.BarButtonItem5.Id = 7
        Me.BarButtonItem5.ImageOptions.Image = CType(resources.GetObject("BarButtonItem5.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem5.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem5.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem5.Name = "BarButtonItem5"
        '
        'BarButtonItem6
        '
        Me.BarButtonItem6.Caption = "Modificar"
        Me.BarButtonItem6.Id = 8
        Me.BarButtonItem6.ImageOptions.Image = CType(resources.GetObject("BarButtonItem6.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem6.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem6.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem6.Name = "BarButtonItem6"
        '
        'BarButtonItem7
        '
        Me.BarButtonItem7.Caption = "Nuevo"
        Me.BarButtonItem7.Id = 9
        Me.BarButtonItem7.ImageOptions.Image = CType(resources.GetObject("BarButtonItem7.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem7.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem7.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem7.Name = "BarButtonItem7"
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "RibbonPage1"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnIngresarViaje)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnModificarViaje)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.Text = "Viajes"
        '
        'gridViajes
        '
        Me.gridViajes.DataSource = Me.ResumenViajesBindingSource
        Me.gridViajes.Location = New System.Drawing.Point(12, 70)
        Me.gridViajes.MainView = Me.gridViewViajes
        Me.gridViajes.MenuManager = Me.RibbonControl
        Me.gridViajes.Name = "gridViajes"
        Me.gridViajes.Size = New System.Drawing.Size(998, 131)
        Me.gridViajes.TabIndex = 1
        Me.gridViajes.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridViewViajes})
        '
        'ResumenViajesBindingSource
        '
        Me.ResumenViajesBindingSource.DataMember = "ResumenViajes"
        Me.ResumenViajesBindingSource.DataSource = Me.datasetEOD
        '
        'datasetEOD
        '
        Me.datasetEOD.DataSetName = "datasetEOD"
        Me.datasetEOD.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'gridViewViajes
        '
        Me.gridViewViajes.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colHogar, Me.colPersona, Me.colViaje, Me.colHoraIni, Me.colHorafin, Me.colProposito, Me.colComunaOri_Comuna, Me.colManzanaOrigen, Me.colNombreCalle1Origen, Me.colNumeroOCalle2Origen, Me.colHitoOrigen, Me.colComunaDes_Comuna, Me.colNombreCalle1Destino, Me.colNumeroOCalle2Destino, Me.colHitoDestino, Me.colManzanaDestino})
        Me.gridViewViajes.GridControl = Me.gridViajes
        Me.gridViewViajes.Name = "gridViewViajes"
        Me.gridViewViajes.OptionsBehavior.Editable = False
        Me.gridViewViajes.OptionsView.ShowGroupPanel = False
        '
        'colHogar
        '
        Me.colHogar.FieldName = "Hogar"
        Me.colHogar.Name = "colHogar"
        Me.colHogar.OptionsColumn.AllowEdit = False
        '
        'colPersona
        '
        Me.colPersona.FieldName = "Persona"
        Me.colPersona.Name = "colPersona"
        Me.colPersona.OptionsColumn.AllowEdit = False
        '
        'colViaje
        '
        Me.colViaje.FieldName = "Viaje"
        Me.colViaje.Name = "colViaje"
        Me.colViaje.OptionsColumn.AllowEdit = False
        Me.colViaje.Visible = True
        Me.colViaje.VisibleIndex = 0
        Me.colViaje.Width = 42
        '
        'colHoraIni
        '
        Me.colHoraIni.Caption = "Hora inicio"
        Me.colHoraIni.DisplayFormat.FormatString = "t"
        Me.colHoraIni.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colHoraIni.FieldName = "HoraIni"
        Me.colHoraIni.Name = "colHoraIni"
        Me.colHoraIni.OptionsColumn.AllowEdit = False
        Me.colHoraIni.Visible = True
        Me.colHoraIni.VisibleIndex = 2
        '
        'colHorafin
        '
        Me.colHorafin.Caption = "Hora término"
        Me.colHorafin.DisplayFormat.FormatString = "t"
        Me.colHorafin.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colHorafin.FieldName = "Horafin"
        Me.colHorafin.Name = "colHorafin"
        Me.colHorafin.OptionsColumn.AllowEdit = False
        Me.colHorafin.Visible = True
        Me.colHorafin.VisibleIndex = 3
        '
        'colProposito
        '
        Me.colProposito.Caption = "¿Qué fue a hacer?"
        Me.colProposito.FieldName = "Proposito"
        Me.colProposito.Name = "colProposito"
        Me.colProposito.OptionsColumn.AllowEdit = False
        Me.colProposito.Visible = True
        Me.colProposito.VisibleIndex = 1
        Me.colProposito.Width = 120
        '
        'colComunaOri_Comuna
        '
        Me.colComunaOri_Comuna.FieldName = "ComunaOri_Comuna"
        Me.colComunaOri_Comuna.Name = "colComunaOri_Comuna"
        Me.colComunaOri_Comuna.OptionsColumn.AllowEdit = False
        '
        'colManzanaOrigen
        '
        Me.colManzanaOrigen.FieldName = "ManzanaOrigen"
        Me.colManzanaOrigen.Name = "colManzanaOrigen"
        Me.colManzanaOrigen.OptionsColumn.AllowEdit = False
        '
        'colNombreCalle1Origen
        '
        Me.colNombreCalle1Origen.FieldName = "NombreCalle1Origen"
        Me.colNombreCalle1Origen.Name = "colNombreCalle1Origen"
        Me.colNombreCalle1Origen.OptionsColumn.AllowEdit = False
        '
        'colNumeroOCalle2Origen
        '
        Me.colNumeroOCalle2Origen.FieldName = "NumeroOCalle2Origen"
        Me.colNumeroOCalle2Origen.Name = "colNumeroOCalle2Origen"
        Me.colNumeroOCalle2Origen.OptionsColumn.AllowEdit = False
        '
        'colHitoOrigen
        '
        Me.colHitoOrigen.FieldName = "HitoOrigen"
        Me.colHitoOrigen.Name = "colHitoOrigen"
        Me.colHitoOrigen.OptionsColumn.AllowEdit = False
        '
        'colComunaDes_Comuna
        '
        Me.colComunaDes_Comuna.Caption = "Comuna"
        Me.colComunaDes_Comuna.FieldName = "ComunaDes_Comuna"
        Me.colComunaDes_Comuna.Name = "colComunaDes_Comuna"
        Me.colComunaDes_Comuna.OptionsColumn.AllowEdit = False
        Me.colComunaDes_Comuna.Visible = True
        Me.colComunaDes_Comuna.VisibleIndex = 4
        Me.colComunaDes_Comuna.Width = 103
        '
        'colNombreCalle1Destino
        '
        Me.colNombreCalle1Destino.Caption = "Calle 1"
        Me.colNombreCalle1Destino.FieldName = "NombreCalle1Destino"
        Me.colNombreCalle1Destino.Name = "colNombreCalle1Destino"
        Me.colNombreCalle1Destino.OptionsColumn.AllowEdit = False
        Me.colNombreCalle1Destino.Visible = True
        Me.colNombreCalle1Destino.VisibleIndex = 5
        Me.colNombreCalle1Destino.Width = 140
        '
        'colNumeroOCalle2Destino
        '
        Me.colNumeroOCalle2Destino.Caption = "Calle 2"
        Me.colNumeroOCalle2Destino.FieldName = "NumeroOCalle2Destino"
        Me.colNumeroOCalle2Destino.Name = "colNumeroOCalle2Destino"
        Me.colNumeroOCalle2Destino.OptionsColumn.AllowEdit = False
        Me.colNumeroOCalle2Destino.Visible = True
        Me.colNumeroOCalle2Destino.VisibleIndex = 6
        Me.colNumeroOCalle2Destino.Width = 140
        '
        'colHitoDestino
        '
        Me.colHitoDestino.Caption = "Hito"
        Me.colHitoDestino.FieldName = "HitoDestino"
        Me.colHitoDestino.Name = "colHitoDestino"
        Me.colHitoDestino.OptionsColumn.AllowEdit = False
        Me.colHitoDestino.Visible = True
        Me.colHitoDestino.VisibleIndex = 7
        Me.colHitoDestino.Width = 140
        '
        'colManzanaDestino
        '
        Me.colManzanaDestino.Caption = "Manzana"
        Me.colManzanaDestino.FieldName = "ManzanaDestino"
        Me.colManzanaDestino.Name = "colManzanaDestino"
        Me.colManzanaDestino.OptionsColumn.AllowEdit = False
        Me.colManzanaDestino.Visible = True
        Me.colManzanaDestino.VisibleIndex = 8
        Me.colManzanaDestino.Width = 100
        '
        'ResumenViajesTableAdapter
        '
        Me.ResumenViajesTableAdapter.ClearBeforeFill = True
        '
        'ResumenEtapasBindingSource
        '
        Me.ResumenEtapasBindingSource.DataMember = "ResumenEtapas"
        Me.ResumenEtapasBindingSource.DataSource = Me.datasetEOD
        '
        'ResumenEtapasTableAdapter
        '
        Me.ResumenEtapasTableAdapter.ClearBeforeFill = True
        '
        'SharedImageCollection1
        '
        '
        '
        '
        Me.SharedImageCollection1.ImageSource.ImageStream = CType(resources.GetObject("SharedImageCollection1.ImageSource.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.SharedImageCollection1.ImageSource.Images.SetKeyName(0, "04_-_Walking-512.png")
        Me.SharedImageCollection1.ImageSource.Images.SetKeyName(1, "Bicycle-48.png")
        Me.SharedImageCollection1.ImageSource.Images.SetKeyName(2, "Bus-48.png")
        Me.SharedImageCollection1.ImageSource.Images.SetKeyName(3, "Motorcycle-48.png")
        Me.SharedImageCollection1.ImageSource.Images.SetKeyName(4, "Sedan-48.png")
        Me.SharedImageCollection1.ImageSource.Images.SetKeyName(5, "Taxi-48.png")
        Me.SharedImageCollection1.ImageSource.Images.SetKeyName(6, "Train-48.png")
        Me.SharedImageCollection1.ParentControl = Me
        '
        'datasetEOD1
        '
        Me.datasetEOD1.DataSetName = "datasetEOD"
        Me.datasetEOD1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'panelEtapas
        '
        Me.panelEtapas.Controls.Add(Me.tab1etapa)
        Me.panelEtapas.Controls.Add(Me.tab2etapas)
        Me.panelEtapas.Controls.Add(Me.tab3etapas)
        Me.panelEtapas.Controls.Add(Me.tabDetalle)
        Me.panelEtapas.Location = New System.Drawing.Point(0, 211)
        Me.panelEtapas.Name = "panelEtapas"
        Me.panelEtapas.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.tab1etapa, Me.tab2etapas, Me.tab3etapas, Me.tabDetalle})
        Me.panelEtapas.RegularSize = New System.Drawing.Size(1022, 237)
        Me.panelEtapas.SelectedPage = Me.tab2etapas
        Me.panelEtapas.Size = New System.Drawing.Size(1022, 237)
        Me.panelEtapas.TabIndex = 6
        Me.panelEtapas.Text = "TabPane1"
        '
        'tab1etapa
        '
        Me.tab1etapa.Caption = "Vista de secuencia"
        Me.tab1etapa.Controls.Add(Me.XtraScrollableControl1)
        Me.tab1etapa.Name = "tab1etapa"
        Me.tab1etapa.Size = New System.Drawing.Size(1004, 192)
        '
        'XtraScrollableControl1
        '
        Me.XtraScrollableControl1.Controls.Add(Me.GroupControl3)
        Me.XtraScrollableControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraScrollableControl1.Location = New System.Drawing.Point(0, 0)
        Me.XtraScrollableControl1.Name = "XtraScrollableControl1"
        Me.XtraScrollableControl1.Size = New System.Drawing.Size(1004, 192)
        Me.XtraScrollableControl1.TabIndex = 9
        '
        'GroupControl3
        '
        Me.GroupControl3.Controls.Add(Me.txtHoraFinViajeE1)
        Me.GroupControl3.Controls.Add(Me.Label21)
        Me.GroupControl3.Controls.Add(Me.txtMedioE1)
        Me.GroupControl3.Controls.Add(Me.LabelControl12)
        Me.GroupControl3.Controls.Add(Me.txtFinViajeE1)
        Me.GroupControl3.Controls.Add(Me.Label24)
        Me.GroupControl3.Controls.Add(Me.txtHoraIniViajeE1)
        Me.GroupControl3.Controls.Add(Me.Label26)
        Me.GroupControl3.Controls.Add(Me.txtEtapaE1)
        Me.GroupControl3.Controls.Add(Me.txtInicioViajeE1)
        Me.GroupControl3.Controls.Add(Me.imgTransporteE1)
        Me.GroupControl3.Controls.Add(Me.LabelControl23)
        Me.GroupControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl3.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(1004, 192)
        Me.GroupControl3.TabIndex = 4
        Me.GroupControl3.Text = "Detalle del viaje "
        '
        'txtHoraFinViajeE1
        '
        Me.txtHoraFinViajeE1.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.txtHoraFinViajeE1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHoraFinViajeE1.ForeColor = System.Drawing.Color.White
        Me.txtHoraFinViajeE1.Location = New System.Drawing.Point(629, 156)
        Me.txtHoraFinViajeE1.Name = "txtHoraFinViajeE1"
        Me.txtHoraFinViajeE1.Padding = New System.Windows.Forms.Padding(5)
        Me.txtHoraFinViajeE1.Size = New System.Drawing.Size(143, 28)
        Me.txtHoraFinViajeE1.TabIndex = 40
        Me.txtHoraFinViajeE1.Text = "Hora: 09:00"
        Me.txtHoraFinViajeE1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.Label21.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.White
        Me.Label21.Location = New System.Drawing.Point(629, 18)
        Me.Label21.Name = "Label21"
        Me.Label21.Padding = New System.Windows.Forms.Padding(5)
        Me.Label21.Size = New System.Drawing.Size(143, 28)
        Me.Label21.TabIndex = 37
        Me.Label21.Text = "Fin del Viaje"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtMedioE1
        '
        Me.txtMedioE1.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.txtMedioE1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMedioE1.ForeColor = System.Drawing.Color.White
        Me.txtMedioE1.Location = New System.Drawing.Point(402, 156)
        Me.txtMedioE1.Name = "txtMedioE1"
        Me.txtMedioE1.Padding = New System.Windows.Forms.Padding(5)
        Me.txtMedioE1.Size = New System.Drawing.Size(197, 28)
        Me.txtMedioE1.TabIndex = 38
        Me.txtMedioE1.Text = "Bus urbano"
        Me.txtMedioE1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelControl12
        '
        Me.LabelControl12.Location = New System.Drawing.Point(606, 93)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(20, 13)
        Me.LabelControl12.TabIndex = 30
        Me.LabelControl12.Text = "--->"
        '
        'txtFinViajeE1
        '
        Me.txtFinViajeE1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.txtFinViajeE1.Location = New System.Drawing.Point(632, 74)
        Me.txtFinViajeE1.Name = "txtFinViajeE1"
        Me.txtFinViajeE1.Size = New System.Drawing.Size(140, 52)
        Me.txtFinViajeE1.TabIndex = 29
        Me.txtFinViajeE1.Text = "Calle 1: Manquehue" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Calle 2: San Olav" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Hito:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Comuna: Las Condes"
        '
        'Label24
        '
        Me.Label24.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.Label24.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.White
        Me.Label24.Location = New System.Drawing.Point(402, 18)
        Me.Label24.Name = "Label24"
        Me.Label24.Padding = New System.Windows.Forms.Padding(5)
        Me.Label24.Size = New System.Drawing.Size(197, 28)
        Me.Label24.TabIndex = 32
        Me.Label24.Text = "Medio de transporte"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtHoraIniViajeE1
        '
        Me.txtHoraIniViajeE1.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.txtHoraIniViajeE1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHoraIniViajeE1.ForeColor = System.Drawing.Color.White
        Me.txtHoraIniViajeE1.Location = New System.Drawing.Point(231, 156)
        Me.txtHoraIniViajeE1.Name = "txtHoraIniViajeE1"
        Me.txtHoraIniViajeE1.Padding = New System.Windows.Forms.Padding(5)
        Me.txtHoraIniViajeE1.Size = New System.Drawing.Size(143, 28)
        Me.txtHoraIniViajeE1.TabIndex = 18
        Me.txtHoraIniViajeE1.Text = "Hora: 08:00"
        Me.txtHoraIniViajeE1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label26
        '
        Me.Label26.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.Label26.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.White
        Me.Label26.Location = New System.Drawing.Point(231, 18)
        Me.Label26.Name = "Label26"
        Me.Label26.Padding = New System.Windows.Forms.Padding(5)
        Me.Label26.Size = New System.Drawing.Size(143, 28)
        Me.Label26.TabIndex = 16
        Me.Label26.Text = "Inicio del Viaje"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtEtapaE1
        '
        Me.txtEtapaE1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.txtEtapaE1.Location = New System.Drawing.Point(460, 74)
        Me.txtEtapaE1.Name = "txtEtapaE1"
        Me.txtEtapaE1.Size = New System.Drawing.Size(140, 52)
        Me.txtEtapaE1.TabIndex = 13
        Me.txtEtapaE1.Text = "Calle 1: Las Torres" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Calle 2: Américo Vespucio" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Hito: " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Comuna: Peñalolén"
        '
        'txtInicioViajeE1
        '
        Me.txtInicioViajeE1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.txtInicioViajeE1.Location = New System.Drawing.Point(234, 74)
        Me.txtInicioViajeE1.Name = "txtInicioViajeE1"
        Me.txtInicioViajeE1.Size = New System.Drawing.Size(140, 52)
        Me.txtInicioViajeE1.TabIndex = 12
        Me.txtInicioViajeE1.Text = "Calle 1: Avenida Tobalaba" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Calle 2: Palena" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Hito: " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Comuna: La Florida"
        '
        'imgTransporteE1
        '
        Me.imgTransporteE1.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgTransporteE1.EditValue = CType(resources.GetObject("imgTransporteE1.EditValue"), Object)
        Me.imgTransporteE1.Location = New System.Drawing.Point(406, 74)
        Me.imgTransporteE1.MenuManager = Me.RibbonControl
        Me.imgTransporteE1.Name = "imgTransporteE1"
        Me.imgTransporteE1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.imgTransporteE1.Properties.Appearance.Options.UseBackColor = True
        Me.imgTransporteE1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.imgTransporteE1.Properties.InitialImage = CType(resources.GetObject("imgTransporteE1.Properties.InitialImage"), System.Drawing.Image)
        Me.imgTransporteE1.Properties.ReadOnly = True
        Me.imgTransporteE1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.imgTransporteE1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.imgTransporteE1.Properties.ZoomAccelerationFactor = 1.0R
        Me.imgTransporteE1.Size = New System.Drawing.Size(48, 48)
        Me.imgTransporteE1.TabIndex = 9
        '
        'LabelControl23
        '
        Me.LabelControl23.Location = New System.Drawing.Point(380, 93)
        Me.LabelControl23.Name = "LabelControl23"
        Me.LabelControl23.Size = New System.Drawing.Size(20, 13)
        Me.LabelControl23.TabIndex = 3
        Me.LabelControl23.Text = "--->"
        '
        'tab2etapas
        '
        Me.tab2etapas.Caption = "Vista de secuencia"
        Me.tab2etapas.Controls.Add(Me.scroll2)
        Me.tab2etapas.Name = "tab2etapas"
        Me.tab2etapas.Size = New System.Drawing.Size(1004, 192)
        '
        'scroll2
        '
        Me.scroll2.Controls.Add(Me.GroupControl2)
        Me.scroll2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.scroll2.Location = New System.Drawing.Point(0, 0)
        Me.scroll2.Name = "scroll2"
        Me.scroll2.Size = New System.Drawing.Size(1004, 192)
        Me.scroll2.TabIndex = 8
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.txtHoraFinViajeE2)
        Me.GroupControl2.Controls.Add(Me.txtMedio2E2)
        Me.GroupControl2.Controls.Add(Me.Label7)
        Me.GroupControl2.Controls.Add(Me.txtMedio1E2)
        Me.GroupControl2.Controls.Add(Me.Label16)
        Me.GroupControl2.Controls.Add(Me.LabelControl6)
        Me.GroupControl2.Controls.Add(Me.txtFinViajeE2)
        Me.GroupControl2.Controls.Add(Me.LabelControl13)
        Me.GroupControl2.Controls.Add(Me.Label18)
        Me.GroupControl2.Controls.Add(Me.txtHoraIniViajeE2)
        Me.GroupControl2.Controls.Add(Me.Label20)
        Me.GroupControl2.Controls.Add(Me.txtEtapa2E2)
        Me.GroupControl2.Controls.Add(Me.txtEtapa1E2)
        Me.GroupControl2.Controls.Add(Me.txtInicioViajeE2)
        Me.GroupControl2.Controls.Add(Me.imgTransporte2E2)
        Me.GroupControl2.Controls.Add(Me.imgTransporte1E2)
        Me.GroupControl2.Controls.Add(Me.LabelControl18)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl2.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(1004, 192)
        Me.GroupControl2.TabIndex = 4
        Me.GroupControl2.Text = "Detalle del viaje "
        '
        'txtHoraFinViajeE2
        '
        Me.txtHoraFinViajeE2.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.txtHoraFinViajeE2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHoraFinViajeE2.ForeColor = System.Drawing.Color.White
        Me.txtHoraFinViajeE2.Location = New System.Drawing.Point(746, 157)
        Me.txtHoraFinViajeE2.Name = "txtHoraFinViajeE2"
        Me.txtHoraFinViajeE2.Padding = New System.Windows.Forms.Padding(5)
        Me.txtHoraFinViajeE2.Size = New System.Drawing.Size(143, 28)
        Me.txtHoraFinViajeE2.TabIndex = 40
        Me.txtHoraFinViajeE2.Text = "Hora: 09:00"
        Me.txtHoraFinViajeE2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtMedio2E2
        '
        Me.txtMedio2E2.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.txtMedio2E2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMedio2E2.ForeColor = System.Drawing.Color.White
        Me.txtMedio2E2.Location = New System.Drawing.Point(519, 157)
        Me.txtMedio2E2.Name = "txtMedio2E2"
        Me.txtMedio2E2.Padding = New System.Windows.Forms.Padding(5)
        Me.txtMedio2E2.Size = New System.Drawing.Size(197, 28)
        Me.txtMedio2E2.TabIndex = 39
        Me.txtMedio2E2.Text = "Tren"
        Me.txtMedio2E2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(746, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Padding = New System.Windows.Forms.Padding(5)
        Me.Label7.Size = New System.Drawing.Size(143, 28)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "Fin del Viaje"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtMedio1E2
        '
        Me.txtMedio1E2.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.txtMedio1E2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMedio1E2.ForeColor = System.Drawing.Color.White
        Me.txtMedio1E2.Location = New System.Drawing.Point(293, 157)
        Me.txtMedio1E2.Name = "txtMedio1E2"
        Me.txtMedio1E2.Padding = New System.Windows.Forms.Padding(5)
        Me.txtMedio1E2.Size = New System.Drawing.Size(197, 28)
        Me.txtMedio1E2.TabIndex = 38
        Me.txtMedio1E2.Text = "Bus urbano"
        Me.txtMedio1E2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.Label16.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(519, 19)
        Me.Label16.Name = "Label16"
        Me.Label16.Padding = New System.Windows.Forms.Padding(5)
        Me.Label16.Size = New System.Drawing.Size(197, 28)
        Me.Label16.TabIndex = 38
        Me.Label16.Text = "Medio de transporte 2"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(723, 94)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(20, 13)
        Me.LabelControl6.TabIndex = 30
        Me.LabelControl6.Text = "--->"
        '
        'txtFinViajeE2
        '
        Me.txtFinViajeE2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.txtFinViajeE2.Location = New System.Drawing.Point(749, 75)
        Me.txtFinViajeE2.Name = "txtFinViajeE2"
        Me.txtFinViajeE2.Size = New System.Drawing.Size(140, 52)
        Me.txtFinViajeE2.TabIndex = 29
        Me.txtFinViajeE2.Text = "Calle 1: Manquehue" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Calle 2: San Olav" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Hito:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Comuna: Las Condes"
        '
        'LabelControl13
        '
        Me.LabelControl13.Location = New System.Drawing.Point(497, 94)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(20, 13)
        Me.LabelControl13.TabIndex = 23
        Me.LabelControl13.Text = "--->"
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.Label18.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(293, 19)
        Me.Label18.Name = "Label18"
        Me.Label18.Padding = New System.Windows.Forms.Padding(5)
        Me.Label18.Size = New System.Drawing.Size(197, 28)
        Me.Label18.TabIndex = 32
        Me.Label18.Text = "Medio de transporte 1"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtHoraIniViajeE2
        '
        Me.txtHoraIniViajeE2.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.txtHoraIniViajeE2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHoraIniViajeE2.ForeColor = System.Drawing.Color.White
        Me.txtHoraIniViajeE2.Location = New System.Drawing.Point(122, 157)
        Me.txtHoraIniViajeE2.Name = "txtHoraIniViajeE2"
        Me.txtHoraIniViajeE2.Padding = New System.Windows.Forms.Padding(5)
        Me.txtHoraIniViajeE2.Size = New System.Drawing.Size(143, 28)
        Me.txtHoraIniViajeE2.TabIndex = 18
        Me.txtHoraIniViajeE2.Text = "Hora: 08:00"
        Me.txtHoraIniViajeE2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.Label20.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.White
        Me.Label20.Location = New System.Drawing.Point(122, 19)
        Me.Label20.Name = "Label20"
        Me.Label20.Padding = New System.Windows.Forms.Padding(5)
        Me.Label20.Size = New System.Drawing.Size(143, 28)
        Me.Label20.TabIndex = 16
        Me.Label20.Text = "Inicio del Viaje"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtEtapa2E2
        '
        Me.txtEtapa2E2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.txtEtapa2E2.Location = New System.Drawing.Point(577, 75)
        Me.txtEtapa2E2.Name = "txtEtapa2E2"
        Me.txtEtapa2E2.Size = New System.Drawing.Size(140, 52)
        Me.txtEtapa2E2.TabIndex = 14
        Me.txtEtapa2E2.Text = "Calle 1:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Calle 2:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Hito: Metro Manquehue" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Comuna: Las Condes"
        '
        'txtEtapa1E2
        '
        Me.txtEtapa1E2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.txtEtapa1E2.Location = New System.Drawing.Point(351, 75)
        Me.txtEtapa1E2.Name = "txtEtapa1E2"
        Me.txtEtapa1E2.Size = New System.Drawing.Size(140, 52)
        Me.txtEtapa1E2.TabIndex = 13
        Me.txtEtapa1E2.Text = "Calle 1: Las Torres" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Calle 2: Américo Vespucio" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Hito: " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Comuna: Peñalolén"
        '
        'txtInicioViajeE2
        '
        Me.txtInicioViajeE2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.txtInicioViajeE2.Location = New System.Drawing.Point(125, 75)
        Me.txtInicioViajeE2.Name = "txtInicioViajeE2"
        Me.txtInicioViajeE2.Size = New System.Drawing.Size(140, 52)
        Me.txtInicioViajeE2.TabIndex = 12
        Me.txtInicioViajeE2.Text = "Calle 1: Avenida Tobalaba" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Calle 2: Palena" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Hito: " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Comuna: La Florida"
        '
        'imgTransporte2E2
        '
        Me.imgTransporte2E2.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgTransporte2E2.EditValue = CType(resources.GetObject("imgTransporte2E2.EditValue"), Object)
        Me.imgTransporte2E2.Location = New System.Drawing.Point(523, 75)
        Me.imgTransporte2E2.MenuManager = Me.RibbonControl
        Me.imgTransporte2E2.Name = "imgTransporte2E2"
        Me.imgTransporte2E2.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.imgTransporte2E2.Properties.Appearance.Options.UseBackColor = True
        Me.imgTransporte2E2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.imgTransporte2E2.Properties.InitialImage = CType(resources.GetObject("imgTransporte2E2.Properties.InitialImage"), System.Drawing.Image)
        Me.imgTransporte2E2.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.imgTransporte2E2.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.imgTransporte2E2.Properties.ZoomAccelerationFactor = 1.0R
        Me.imgTransporte2E2.Size = New System.Drawing.Size(48, 48)
        Me.imgTransporte2E2.TabIndex = 10
        '
        'imgTransporte1E2
        '
        Me.imgTransporte1E2.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgTransporte1E2.EditValue = CType(resources.GetObject("imgTransporte1E2.EditValue"), Object)
        Me.imgTransporte1E2.Location = New System.Drawing.Point(297, 75)
        Me.imgTransporte1E2.MenuManager = Me.RibbonControl
        Me.imgTransporte1E2.Name = "imgTransporte1E2"
        Me.imgTransporte1E2.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.imgTransporte1E2.Properties.Appearance.Options.UseBackColor = True
        Me.imgTransporte1E2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.imgTransporte1E2.Properties.InitialImage = CType(resources.GetObject("imgTransporte1E2.Properties.InitialImage"), System.Drawing.Image)
        Me.imgTransporte1E2.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.imgTransporte1E2.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.imgTransporte1E2.Properties.ZoomAccelerationFactor = 1.0R
        Me.imgTransporte1E2.Size = New System.Drawing.Size(48, 48)
        Me.imgTransporte1E2.TabIndex = 9
        '
        'LabelControl18
        '
        Me.LabelControl18.Location = New System.Drawing.Point(271, 94)
        Me.LabelControl18.Name = "LabelControl18"
        Me.LabelControl18.Size = New System.Drawing.Size(20, 13)
        Me.LabelControl18.TabIndex = 3
        Me.LabelControl18.Text = "--->"
        '
        'tab3etapas
        '
        Me.tab3etapas.Caption = "Vista de secuencia"
        Me.tab3etapas.Controls.Add(Me.scroll3)
        Me.tab3etapas.Name = "tab3etapas"
        Me.tab3etapas.Size = New System.Drawing.Size(1004, 192)
        '
        'scroll3
        '
        Me.scroll3.Controls.Add(Me.GroupControl4)
        Me.scroll3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.scroll3.Location = New System.Drawing.Point(0, 0)
        Me.scroll3.Name = "scroll3"
        Me.scroll3.Size = New System.Drawing.Size(1004, 192)
        Me.scroll3.TabIndex = 8
        '
        'GroupControl4
        '
        Me.GroupControl4.Controls.Add(Me.txtHoraFinViajeE3)
        Me.GroupControl4.Controls.Add(Me.txtMedio2E3)
        Me.GroupControl4.Controls.Add(Me.Label27)
        Me.GroupControl4.Controls.Add(Me.txtMedio1E3)
        Me.GroupControl4.Controls.Add(Me.Label29)
        Me.GroupControl4.Controls.Add(Me.Label30)
        Me.GroupControl4.Controls.Add(Me.txtMedio3E3)
        Me.GroupControl4.Controls.Add(Me.LabelControl19)
        Me.GroupControl4.Controls.Add(Me.txtFinViajeE3)
        Me.GroupControl4.Controls.Add(Me.LabelControl24)
        Me.GroupControl4.Controls.Add(Me.LabelControl25)
        Me.GroupControl4.Controls.Add(Me.Label32)
        Me.GroupControl4.Controls.Add(Me.txtHoraIniViajeE3)
        Me.GroupControl4.Controls.Add(Me.Label34)
        Me.GroupControl4.Controls.Add(Me.txtEtapa3E3)
        Me.GroupControl4.Controls.Add(Me.txtEtapa2E3)
        Me.GroupControl4.Controls.Add(Me.txtEtapa1E3)
        Me.GroupControl4.Controls.Add(Me.txtInicioViajeE3)
        Me.GroupControl4.Controls.Add(Me.imgTransporte3E3)
        Me.GroupControl4.Controls.Add(Me.imgTransporte2E3)
        Me.GroupControl4.Controls.Add(Me.imgTransporte1E3)
        Me.GroupControl4.Controls.Add(Me.LabelControl30)
        Me.GroupControl4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl4.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl4.Name = "GroupControl4"
        Me.GroupControl4.Size = New System.Drawing.Size(1004, 192)
        Me.GroupControl4.TabIndex = 4
        Me.GroupControl4.Text = "Detalle del viaje "
        '
        'txtHoraFinViajeE3
        '
        Me.txtHoraFinViajeE3.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.txtHoraFinViajeE3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHoraFinViajeE3.ForeColor = System.Drawing.Color.White
        Me.txtHoraFinViajeE3.Location = New System.Drawing.Point(857, 162)
        Me.txtHoraFinViajeE3.Name = "txtHoraFinViajeE3"
        Me.txtHoraFinViajeE3.Padding = New System.Windows.Forms.Padding(5)
        Me.txtHoraFinViajeE3.Size = New System.Drawing.Size(133, 28)
        Me.txtHoraFinViajeE3.TabIndex = 40
        Me.txtHoraFinViajeE3.Text = "Hora: 09:00"
        Me.txtHoraFinViajeE3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtMedio2E3
        '
        Me.txtMedio2E3.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.txtMedio2E3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMedio2E3.ForeColor = System.Drawing.Color.White
        Me.txtMedio2E3.Location = New System.Drawing.Point(404, 162)
        Me.txtMedio2E3.Name = "txtMedio2E3"
        Me.txtMedio2E3.Padding = New System.Windows.Forms.Padding(5)
        Me.txtMedio2E3.Size = New System.Drawing.Size(197, 28)
        Me.txtMedio2E3.TabIndex = 39
        Me.txtMedio2E3.Text = "Tren"
        Me.txtMedio2E3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label27
        '
        Me.Label27.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.Label27.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.White
        Me.Label27.Location = New System.Drawing.Point(857, 24)
        Me.Label27.Name = "Label27"
        Me.Label27.Padding = New System.Windows.Forms.Padding(5)
        Me.Label27.Size = New System.Drawing.Size(133, 28)
        Me.Label27.TabIndex = 37
        Me.Label27.Text = "Fin del Viaje"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtMedio1E3
        '
        Me.txtMedio1E3.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.txtMedio1E3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMedio1E3.ForeColor = System.Drawing.Color.White
        Me.txtMedio1E3.Location = New System.Drawing.Point(178, 162)
        Me.txtMedio1E3.Name = "txtMedio1E3"
        Me.txtMedio1E3.Padding = New System.Windows.Forms.Padding(5)
        Me.txtMedio1E3.Size = New System.Drawing.Size(197, 28)
        Me.txtMedio1E3.TabIndex = 38
        Me.txtMedio1E3.Text = "Bus urbano"
        Me.txtMedio1E3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label29
        '
        Me.Label29.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.Label29.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.White
        Me.Label29.Location = New System.Drawing.Point(630, 24)
        Me.Label29.Name = "Label29"
        Me.Label29.Padding = New System.Windows.Forms.Padding(5)
        Me.Label29.Size = New System.Drawing.Size(197, 28)
        Me.Label29.TabIndex = 39
        Me.Label29.Text = "Medio de transporte 3"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label30
        '
        Me.Label30.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.Label30.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.Color.White
        Me.Label30.Location = New System.Drawing.Point(404, 24)
        Me.Label30.Name = "Label30"
        Me.Label30.Padding = New System.Windows.Forms.Padding(5)
        Me.Label30.Size = New System.Drawing.Size(197, 28)
        Me.Label30.TabIndex = 38
        Me.Label30.Text = "Medio de transporte 2"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtMedio3E3
        '
        Me.txtMedio3E3.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.txtMedio3E3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMedio3E3.ForeColor = System.Drawing.Color.White
        Me.txtMedio3E3.Location = New System.Drawing.Point(630, 162)
        Me.txtMedio3E3.Name = "txtMedio3E3"
        Me.txtMedio3E3.Padding = New System.Windows.Forms.Padding(5)
        Me.txtMedio3E3.Size = New System.Drawing.Size(197, 28)
        Me.txtMedio3E3.TabIndex = 34
        Me.txtMedio3E3.Text = "Taxi o radiotaxi"
        Me.txtMedio3E3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelControl19
        '
        Me.LabelControl19.Location = New System.Drawing.Point(834, 99)
        Me.LabelControl19.Name = "LabelControl19"
        Me.LabelControl19.Size = New System.Drawing.Size(20, 13)
        Me.LabelControl19.TabIndex = 30
        Me.LabelControl19.Text = "--->"
        '
        'txtFinViajeE3
        '
        Me.txtFinViajeE3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.txtFinViajeE3.Location = New System.Drawing.Point(860, 80)
        Me.txtFinViajeE3.Name = "txtFinViajeE3"
        Me.txtFinViajeE3.Size = New System.Drawing.Size(140, 52)
        Me.txtFinViajeE3.TabIndex = 29
        Me.txtFinViajeE3.Text = "Calle 1: Manquehue" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Calle 2: San Olav" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Hito:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Comuna: Las Condes"
        '
        'LabelControl24
        '
        Me.LabelControl24.Location = New System.Drawing.Point(608, 99)
        Me.LabelControl24.Name = "LabelControl24"
        Me.LabelControl24.Size = New System.Drawing.Size(20, 13)
        Me.LabelControl24.TabIndex = 24
        Me.LabelControl24.Text = "--->"
        '
        'LabelControl25
        '
        Me.LabelControl25.Location = New System.Drawing.Point(382, 99)
        Me.LabelControl25.Name = "LabelControl25"
        Me.LabelControl25.Size = New System.Drawing.Size(20, 13)
        Me.LabelControl25.TabIndex = 23
        Me.LabelControl25.Text = "--->"
        '
        'Label32
        '
        Me.Label32.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.Label32.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.White
        Me.Label32.Location = New System.Drawing.Point(178, 24)
        Me.Label32.Name = "Label32"
        Me.Label32.Padding = New System.Windows.Forms.Padding(5)
        Me.Label32.Size = New System.Drawing.Size(197, 28)
        Me.Label32.TabIndex = 32
        Me.Label32.Text = "Medio de transporte 1"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtHoraIniViajeE3
        '
        Me.txtHoraIniViajeE3.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.txtHoraIniViajeE3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHoraIniViajeE3.ForeColor = System.Drawing.Color.White
        Me.txtHoraIniViajeE3.Location = New System.Drawing.Point(7, 162)
        Me.txtHoraIniViajeE3.Name = "txtHoraIniViajeE3"
        Me.txtHoraIniViajeE3.Padding = New System.Windows.Forms.Padding(5)
        Me.txtHoraIniViajeE3.Size = New System.Drawing.Size(143, 28)
        Me.txtHoraIniViajeE3.TabIndex = 18
        Me.txtHoraIniViajeE3.Text = "Hora: 08:00"
        Me.txtHoraIniViajeE3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label34
        '
        Me.Label34.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.Label34.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.ForeColor = System.Drawing.Color.White
        Me.Label34.Location = New System.Drawing.Point(7, 24)
        Me.Label34.Name = "Label34"
        Me.Label34.Padding = New System.Windows.Forms.Padding(5)
        Me.Label34.Size = New System.Drawing.Size(143, 28)
        Me.Label34.TabIndex = 16
        Me.Label34.Text = "Inicio del Viaje"
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtEtapa3E3
        '
        Me.txtEtapa3E3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.txtEtapa3E3.Location = New System.Drawing.Point(688, 80)
        Me.txtEtapa3E3.Name = "txtEtapa3E3"
        Me.txtEtapa3E3.Size = New System.Drawing.Size(140, 52)
        Me.txtEtapa3E3.TabIndex = 15
        Me.txtEtapa3E3.Text = "Calle 1: Manquehue" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Calle 2: San Olav" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Hito:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Comuna: Las Condes"
        '
        'txtEtapa2E3
        '
        Me.txtEtapa2E3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.txtEtapa2E3.Location = New System.Drawing.Point(462, 80)
        Me.txtEtapa2E3.Name = "txtEtapa2E3"
        Me.txtEtapa2E3.Size = New System.Drawing.Size(140, 52)
        Me.txtEtapa2E3.TabIndex = 14
        Me.txtEtapa2E3.Text = "Calle 1:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Calle 2:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Hito: Metro Manquehue" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Comuna: Las Condes"
        '
        'txtEtapa1E3
        '
        Me.txtEtapa1E3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.txtEtapa1E3.Location = New System.Drawing.Point(236, 80)
        Me.txtEtapa1E3.Name = "txtEtapa1E3"
        Me.txtEtapa1E3.Size = New System.Drawing.Size(140, 52)
        Me.txtEtapa1E3.TabIndex = 13
        Me.txtEtapa1E3.Text = "Calle 1: Las Torres" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Calle 2: Américo Vespucio" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Hito: " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Comuna: Peñalolén"
        '
        'txtInicioViajeE3
        '
        Me.txtInicioViajeE3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.txtInicioViajeE3.Location = New System.Drawing.Point(10, 80)
        Me.txtInicioViajeE3.Name = "txtInicioViajeE3"
        Me.txtInicioViajeE3.Size = New System.Drawing.Size(140, 52)
        Me.txtInicioViajeE3.TabIndex = 12
        Me.txtInicioViajeE3.Text = "Calle 1: Avenida Tobalaba" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Calle 2: Palena" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Hito: " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Comuna: La Florida"
        '
        'imgTransporte3E3
        '
        Me.imgTransporte3E3.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgTransporte3E3.Location = New System.Drawing.Point(634, 80)
        Me.imgTransporte3E3.MenuManager = Me.RibbonControl
        Me.imgTransporte3E3.Name = "imgTransporte3E3"
        Me.imgTransporte3E3.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.imgTransporte3E3.Properties.Appearance.Options.UseBackColor = True
        Me.imgTransporte3E3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.imgTransporte3E3.Properties.InitialImage = Nothing
        Me.imgTransporte3E3.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.imgTransporte3E3.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.imgTransporte3E3.Properties.ZoomAccelerationFactor = 1.0R
        Me.imgTransporte3E3.Size = New System.Drawing.Size(48, 48)
        Me.imgTransporte3E3.TabIndex = 11
        '
        'imgTransporte2E3
        '
        Me.imgTransporte2E3.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgTransporte2E3.Location = New System.Drawing.Point(408, 80)
        Me.imgTransporte2E3.MenuManager = Me.RibbonControl
        Me.imgTransporte2E3.Name = "imgTransporte2E3"
        Me.imgTransporte2E3.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.imgTransporte2E3.Properties.Appearance.Options.UseBackColor = True
        Me.imgTransporte2E3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.imgTransporte2E3.Properties.InitialImage = Nothing
        Me.imgTransporte2E3.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.imgTransporte2E3.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.imgTransporte2E3.Properties.ZoomAccelerationFactor = 1.0R
        Me.imgTransporte2E3.Size = New System.Drawing.Size(48, 48)
        Me.imgTransporte2E3.TabIndex = 10
        '
        'imgTransporte1E3
        '
        Me.imgTransporte1E3.Cursor = System.Windows.Forms.Cursors.Default
        Me.imgTransporte1E3.Location = New System.Drawing.Point(182, 80)
        Me.imgTransporte1E3.MenuManager = Me.RibbonControl
        Me.imgTransporte1E3.Name = "imgTransporte1E3"
        Me.imgTransporte1E3.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.imgTransporte1E3.Properties.Appearance.Options.UseBackColor = True
        Me.imgTransporte1E3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.imgTransporte1E3.Properties.InitialImage = Nothing
        Me.imgTransporte1E3.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.imgTransporte1E3.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.imgTransporte1E3.Properties.ZoomAccelerationFactor = 1.0R
        Me.imgTransporte1E3.Size = New System.Drawing.Size(48, 48)
        Me.imgTransporte1E3.TabIndex = 9
        '
        'LabelControl30
        '
        Me.LabelControl30.Location = New System.Drawing.Point(156, 99)
        Me.LabelControl30.Name = "LabelControl30"
        Me.LabelControl30.Size = New System.Drawing.Size(20, 13)
        Me.LabelControl30.TabIndex = 3
        Me.LabelControl30.Text = "--->"
        '
        'tabDetalle
        '
        Me.tabDetalle.Caption = "Vista de tabla"
        Me.tabDetalle.Controls.Add(Me.gridEtapas)
        Me.tabDetalle.Name = "tabDetalle"
        Me.tabDetalle.Size = New System.Drawing.Size(1004, 193)
        '
        'gridEtapas
        '
        Me.gridEtapas.DataSource = Me.ResumenEtapasBindingSource
        Me.gridEtapas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridEtapas.Location = New System.Drawing.Point(0, 0)
        Me.gridEtapas.MainView = Me.gridViewEtapas
        Me.gridEtapas.MenuManager = Me.RibbonControl
        Me.gridEtapas.Name = "gridEtapas"
        Me.gridEtapas.Size = New System.Drawing.Size(1004, 193)
        Me.gridEtapas.TabIndex = 0
        Me.gridEtapas.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridViewEtapas})
        '
        'gridViewEtapas
        '
        Me.gridViewEtapas.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colHogar1, Me.colPersona1, Me.colViaje1, Me.colEtapa, Me.colModo, Me.colComunaOri_Comuna1, Me.colManzanaOrigen1, Me.colNombreCalle1Origen1, Me.colNumeroOCalle2Origen1, Me.colHitoOrigen1, Me.colComunaDes_Comuna1, Me.colManzanaDestino1, Me.colNombreCalle1Destino1, Me.colNumeroOCalle2Destino1, Me.colHitoDestino1})
        Me.gridViewEtapas.GridControl = Me.gridEtapas
        Me.gridViewEtapas.Name = "gridViewEtapas"
        Me.gridViewEtapas.OptionsView.ShowGroupPanel = False
        '
        'colHogar1
        '
        Me.colHogar1.FieldName = "Hogar"
        Me.colHogar1.Name = "colHogar1"
        Me.colHogar1.OptionsColumn.AllowEdit = False
        Me.colHogar1.Width = 72
        '
        'colPersona1
        '
        Me.colPersona1.FieldName = "Persona"
        Me.colPersona1.Name = "colPersona1"
        Me.colPersona1.OptionsColumn.AllowEdit = False
        Me.colPersona1.Width = 72
        '
        'colViaje1
        '
        Me.colViaje1.FieldName = "Viaje"
        Me.colViaje1.Name = "colViaje1"
        Me.colViaje1.OptionsColumn.AllowEdit = False
        Me.colViaje1.Width = 72
        '
        'colEtapa
        '
        Me.colEtapa.Caption = "N°"
        Me.colEtapa.FieldName = "Etapa"
        Me.colEtapa.Name = "colEtapa"
        Me.colEtapa.OptionsColumn.AllowEdit = False
        Me.colEtapa.UnboundType = DevExpress.Data.UnboundColumnType.[Integer]
        Me.colEtapa.Visible = True
        Me.colEtapa.VisibleIndex = 0
        Me.colEtapa.Width = 50
        '
        'colModo
        '
        Me.colModo.Caption = "Medio de transporte"
        Me.colModo.FieldName = "Modo"
        Me.colModo.Name = "colModo"
        Me.colModo.OptionsColumn.AllowEdit = False
        Me.colModo.Visible = True
        Me.colModo.VisibleIndex = 1
        Me.colModo.Width = 159
        '
        'colComunaOri_Comuna1
        '
        Me.colComunaOri_Comuna1.FieldName = "ComunaOri_Comuna"
        Me.colComunaOri_Comuna1.Name = "colComunaOri_Comuna1"
        Me.colComunaOri_Comuna1.OptionsColumn.AllowEdit = False
        Me.colComunaOri_Comuna1.Width = 99
        '
        'colManzanaOrigen1
        '
        Me.colManzanaOrigen1.FieldName = "ManzanaOrigen"
        Me.colManzanaOrigen1.Name = "colManzanaOrigen1"
        Me.colManzanaOrigen1.OptionsColumn.AllowEdit = False
        Me.colManzanaOrigen1.Width = 134
        '
        'colNombreCalle1Origen1
        '
        Me.colNombreCalle1Origen1.FieldName = "NombreCalle1Origen"
        Me.colNombreCalle1Origen1.Name = "colNombreCalle1Origen1"
        Me.colNombreCalle1Origen1.OptionsColumn.AllowEdit = False
        Me.colNombreCalle1Origen1.Width = 58
        '
        'colNumeroOCalle2Origen1
        '
        Me.colNumeroOCalle2Origen1.FieldName = "NumeroOCalle2Origen"
        Me.colNumeroOCalle2Origen1.Name = "colNumeroOCalle2Origen1"
        Me.colNumeroOCalle2Origen1.OptionsColumn.AllowEdit = False
        Me.colNumeroOCalle2Origen1.Width = 58
        '
        'colHitoOrigen1
        '
        Me.colHitoOrigen1.FieldName = "HitoOrigen"
        Me.colHitoOrigen1.Name = "colHitoOrigen1"
        Me.colHitoOrigen1.OptionsColumn.AllowEdit = False
        Me.colHitoOrigen1.Width = 58
        '
        'colComunaDes_Comuna1
        '
        Me.colComunaDes_Comuna1.Caption = "Comuna"
        Me.colComunaDes_Comuna1.FieldName = "ComunaDes_Comuna"
        Me.colComunaDes_Comuna1.Name = "colComunaDes_Comuna1"
        Me.colComunaDes_Comuna1.OptionsColumn.AllowEdit = False
        Me.colComunaDes_Comuna1.Visible = True
        Me.colComunaDes_Comuna1.VisibleIndex = 2
        Me.colComunaDes_Comuna1.Width = 121
        '
        'colManzanaDestino1
        '
        Me.colManzanaDestino1.Caption = "Manzana"
        Me.colManzanaDestino1.FieldName = "ManzanaDestino"
        Me.colManzanaDestino1.Name = "colManzanaDestino1"
        Me.colManzanaDestino1.OptionsColumn.AllowEdit = False
        Me.colManzanaDestino1.Visible = True
        Me.colManzanaDestino1.VisibleIndex = 6
        Me.colManzanaDestino1.Width = 153
        '
        'colNombreCalle1Destino1
        '
        Me.colNombreCalle1Destino1.Caption = "Calle 1"
        Me.colNombreCalle1Destino1.FieldName = "NombreCalle1Destino"
        Me.colNombreCalle1Destino1.Name = "colNombreCalle1Destino1"
        Me.colNombreCalle1Destino1.OptionsColumn.AllowEdit = False
        Me.colNombreCalle1Destino1.Visible = True
        Me.colNombreCalle1Destino1.VisibleIndex = 3
        Me.colNombreCalle1Destino1.Width = 146
        '
        'colNumeroOCalle2Destino1
        '
        Me.colNumeroOCalle2Destino1.Caption = "Calle 2"
        Me.colNumeroOCalle2Destino1.FieldName = "NumeroOCalle2Destino"
        Me.colNumeroOCalle2Destino1.Name = "colNumeroOCalle2Destino1"
        Me.colNumeroOCalle2Destino1.OptionsColumn.AllowEdit = False
        Me.colNumeroOCalle2Destino1.Visible = True
        Me.colNumeroOCalle2Destino1.VisibleIndex = 4
        Me.colNumeroOCalle2Destino1.Width = 146
        '
        'colHitoDestino1
        '
        Me.colHitoDestino1.Caption = "Hito"
        Me.colHitoDestino1.FieldName = "HitoDestino"
        Me.colHitoDestino1.Name = "colHitoDestino1"
        Me.colHitoDestino1.OptionsColumn.AllowEdit = False
        Me.colHitoDestino1.Visible = True
        Me.colHitoDestino1.VisibleIndex = 5
        Me.colHitoDestino1.Width = 201
        '
        'imageCollectionModos
        '
        Me.imageCollectionModos.ImageSize = New System.Drawing.Size(32, 32)
        Me.imageCollectionModos.ImageStream = CType(resources.GetObject("imageCollectionModos.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.imageCollectionModos.Images.SetKeyName(0, "1.png")
        Me.imageCollectionModos.Images.SetKeyName(1, "2.png")
        Me.imageCollectionModos.Images.SetKeyName(2, "3.png")
        Me.imageCollectionModos.Images.SetKeyName(3, "4.png")
        Me.imageCollectionModos.Images.SetKeyName(4, "5.png")
        Me.imageCollectionModos.Images.SetKeyName(5, "6.png")
        Me.imageCollectionModos.Images.SetKeyName(6, "7.png")
        Me.imageCollectionModos.Images.SetKeyName(7, "8.png")
        Me.imageCollectionModos.Images.SetKeyName(8, "9.png")
        Me.imageCollectionModos.Images.SetKeyName(9, "10.png")
        Me.imageCollectionModos.Images.SetKeyName(10, "11.png")
        Me.imageCollectionModos.Images.SetKeyName(11, "12.png")
        Me.imageCollectionModos.Images.SetKeyName(12, "13.png")
        '
        'cargaDatosBackground
        '
        '
        'PersonaTableAdapter
        '
        Me.PersonaTableAdapter.ClearBeforeFill = True
        '
        'rgTipoDia
        '
        Me.rgTipoDia.Location = New System.Drawing.Point(100, 35)
        Me.rgTipoDia.MenuManager = Me.RibbonControl
        Me.rgTipoDia.Name = "rgTipoDia"
        Me.rgTipoDia.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.rgTipoDia.Properties.Appearance.Options.UseBackColor = True
        Me.rgTipoDia.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.rgTipoDia.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(CType(1, Short), "Laboral"), New DevExpress.XtraEditors.Controls.RadioGroupItem(CType(2, Short), "Sábado"), New DevExpress.XtraEditors.Controls.RadioGroupItem(CType(3, Short), "Domingo")})
        Me.rgTipoDia.Size = New System.Drawing.Size(221, 20)
        Me.rgTipoDia.TabIndex = 8
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(12, 39)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(61, 13)
        Me.LabelControl1.TabIndex = 9
        Me.LabelControl1.Text = "Día de Viajes"
        '
        'ResumenViajes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1022, 461)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.rgTipoDia)
        Me.Controls.Add(Me.panelEtapas)
        Me.Controls.Add(Me.gridViajes)
        Me.Controls.Add(Me.RibbonControl)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ResumenViajes"
        Me.Ribbon = Me.RibbonControl
        Me.RibbonVisibility = DevExpress.XtraBars.Ribbon.RibbonVisibility.Visible
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Viajes de X del hogar XXXXXXXXX, "
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridViajes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ResumenViajesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.datasetEOD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridViewViajes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ResumenEtapasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SharedImageCollection1.ImageSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SharedImageCollection1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.datasetEOD1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.panelEtapas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelEtapas.ResumeLayout(False)
        Me.tab1etapa.ResumeLayout(False)
        Me.XtraScrollableControl1.ResumeLayout(False)
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        Me.GroupControl3.PerformLayout()
        CType(Me.imgTransporteE1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tab2etapas.ResumeLayout(False)
        Me.scroll2.ResumeLayout(False)
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.imgTransporte2E2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgTransporte1E2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tab3etapas.ResumeLayout(False)
        Me.scroll3.ResumeLayout(False)
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl4.ResumeLayout(False)
        Me.GroupControl4.PerformLayout()
        CType(Me.imgTransporte3E3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgTransporte2E3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgTransporte1E3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabDetalle.ResumeLayout(False)
        CType(Me.gridEtapas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridViewEtapas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imageCollectionModos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgTipoDia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents gridViajes As DevExpress.XtraGrid.GridControl
    Friend WithEvents gridViewViajes As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents datasetEOD As EOD.datasetEOD
    Friend WithEvents ResumenViajesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ResumenViajesTableAdapter As EOD.datasetEODTableAdapters.ResumenViajesTableAdapter
    Friend WithEvents colHogar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPersona As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colViaje As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHoraIni As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHorafin As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProposito As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colComunaOri_Comuna As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colManzanaOrigen As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombreCalle1Origen As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNumeroOCalle2Origen As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHitoOrigen As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colComunaDes_Comuna As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombreCalle1Destino As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNumeroOCalle2Destino As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHitoDestino As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colManzanaDestino As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ResumenEtapasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ResumenEtapasTableAdapter As EOD.datasetEODTableAdapters.ResumenEtapasTableAdapter
    Friend WithEvents SharedImageCollection1 As DevExpress.Utils.SharedImageCollection
    Friend WithEvents datasetEOD1 As EOD.datasetEOD
    Friend WithEvents panelEtapas As DevExpress.XtraBars.Navigation.TabPane
    Friend WithEvents tab1etapa As DevExpress.XtraBars.Navigation.TabNavigationPage
    Friend WithEvents tab2etapas As DevExpress.XtraBars.Navigation.TabNavigationPage
    Friend WithEvents scroll2 As DevExpress.XtraEditors.XtraScrollableControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtHoraFinViajeE2 As System.Windows.Forms.Label
    Friend WithEvents txtMedio2E2 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtMedio1E2 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtFinViajeE2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtHoraIniViajeE2 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtEtapa2E2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtEtapa1E2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtInicioViajeE2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents imgTransporte2E2 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents imgTransporte1E2 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents LabelControl18 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents tab3etapas As DevExpress.XtraBars.Navigation.TabNavigationPage
    Friend WithEvents XtraScrollableControl1 As DevExpress.XtraEditors.XtraScrollableControl
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtHoraFinViajeE1 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtMedioE1 As System.Windows.Forms.Label
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtFinViajeE1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txtHoraIniViajeE1 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents txtEtapaE1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtInicioViajeE1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents imgTransporteE1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents LabelControl23 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents scroll3 As DevExpress.XtraEditors.XtraScrollableControl
    Friend WithEvents GroupControl4 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtHoraFinViajeE3 As System.Windows.Forms.Label
    Friend WithEvents txtMedio2E3 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents txtMedio1E3 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents txtMedio3E3 As System.Windows.Forms.Label
    Friend WithEvents LabelControl19 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtFinViajeE3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl24 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl25 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents txtHoraIniViajeE3 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents txtEtapa3E3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtEtapa2E3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtEtapa1E3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtInicioViajeE3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents imgTransporte3E3 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents imgTransporte2E3 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents imgTransporte1E3 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents LabelControl30 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents tabDetalle As DevExpress.XtraBars.Navigation.TabNavigationPage
    Friend WithEvents gridEtapas As DevExpress.XtraGrid.GridControl
    Friend WithEvents gridViewEtapas As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colHogar1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPersona1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colViaje1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEtapa As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colComunaOri_Comuna1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colManzanaOrigen1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombreCalle1Origen1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNumeroOCalle2Origen1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHitoOrigen1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colComunaDes_Comuna1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colManzanaDestino1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombreCalle1Destino1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNumeroOCalle2Destino1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHitoDestino1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents imageCollectionModos As DevExpress.Utils.ImageCollection
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents btnIngresarViaje As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnModificarViaje As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem5 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem6 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem7 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents cargaDatosBackground As System.ComponentModel.BackgroundWorker
    Friend WithEvents PersonaTableAdapter As EOD.datasetEODTableAdapters.PersonaTableAdapter
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents rgTipoDia As DevExpress.XtraEditors.RadioGroup



End Class
