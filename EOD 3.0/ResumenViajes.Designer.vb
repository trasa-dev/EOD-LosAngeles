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
        Me.panelEtapas.Controls.Add(Me.tabDetalle)
        Me.panelEtapas.Location = New System.Drawing.Point(0, 211)
        Me.panelEtapas.Name = "panelEtapas"
        Me.panelEtapas.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.tabDetalle})
        Me.panelEtapas.RegularSize = New System.Drawing.Size(1022, 237)
        Me.panelEtapas.SelectedPage = Me.tabDetalle
        Me.panelEtapas.Size = New System.Drawing.Size(1022, 237)
        Me.panelEtapas.TabIndex = 6
        Me.panelEtapas.Text = "TabPane1"
        '
        'tabDetalle
        '
        Me.tabDetalle.Caption = "Vista de tabla"
        Me.tabDetalle.Controls.Add(Me.gridEtapas)
        Me.tabDetalle.Name = "tabDetalle"
        Me.tabDetalle.Size = New System.Drawing.Size(1004, 192)
        '
        'gridEtapas
        '
        Me.gridEtapas.DataSource = Me.ResumenEtapasBindingSource
        Me.gridEtapas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridEtapas.Location = New System.Drawing.Point(0, 0)
        Me.gridEtapas.MainView = Me.gridViewEtapas
        Me.gridEtapas.MenuManager = Me.RibbonControl
        Me.gridEtapas.Name = "gridEtapas"
        Me.gridEtapas.Size = New System.Drawing.Size(1004, 192)
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
