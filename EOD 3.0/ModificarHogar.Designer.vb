<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModificarHogar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ModificarHogar))
        Me.RibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.ManzanasCatBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.datasetEOD = New EOD.datasetEOD()
        Me.ZonasCatBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CatastroHogaresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PropiedadBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SiNoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.ZonasCatTableAdapter = New EOD.datasetEODTableAdapters.ZonasCatTableAdapter()
        Me.ManzanasCatTableAdapter = New EOD.datasetEODTableAdapters.ManzanasCatTableAdapter()
        Me.CatastroHogaresTableAdapter = New EOD.datasetEODTableAdapters.CatastroHogaresTableAdapter()
        Me.PropiedadTableAdapter = New EOD.datasetEODTableAdapters.PropiedadTableAdapter()
        Me.SiNoTableAdapter = New EOD.datasetEODTableAdapters.SiNoTableAdapter()
        Me.HogarBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TipoViviendaActualBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HogarTableAdapter = New EOD.datasetEODTableAdapters.HogarTableAdapter()
        Me.TipoViviendaActualTableAdapter = New EOD.datasetEODTableAdapters.TipoViviendaActualTableAdapter()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.LabelControl41 = New DevExpress.XtraEditors.LabelControl()
        Me.txtObservacion = New DevExpress.XtraEditors.MemoEdit()
        Me.deFechaViajes = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl43 = New DevExpress.XtraEditors.LabelControl()
        Me.lkpTipoDia = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.TipoDiaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridLookUpEdit28View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colTipoDia = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelControl42 = New DevExpress.XtraEditors.LabelControl()
        Me.TipoDiaTableAdapter = New EOD.datasetEODTableAdapters.TipoDiaTableAdapter()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.txtBicicletas = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl27 = New DevExpress.XtraEditors.LabelControl()
        Me.splitPropiedadPago = New DevExpress.XtraEditors.SplitContainerControl()
        Me.lblPropiedadOtra = New DevExpress.XtraEditors.LabelControl()
        Me.txtPropiedadOtra = New DevExpress.XtraEditors.TextEdit()
        Me.tabsPagoVivienda = New DevExpress.XtraTab.XtraTabControl()
        Me.tabDividendo = New DevExpress.XtraTab.XtraTabPage()
        Me.chkNSNRDividendo = New DevExpress.XtraEditors.CheckEdit()
        Me.txtDividendo = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl18 = New DevExpress.XtraEditors.LabelControl()
        Me.tabArriendo = New DevExpress.XtraTab.XtraTabPage()
        Me.chkNSNRArriendo = New DevExpress.XtraEditors.CheckEdit()
        Me.txtArriendo = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl19 = New DevExpress.XtraEditors.LabelControl()
        Me.tabEstimaArriendo = New DevExpress.XtraTab.XtraTabPage()
        Me.chkNSNREstima = New DevExpress.XtraEditors.CheckEdit()
        Me.txtEstimaArriendo = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl20 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl17 = New DevExpress.XtraEditors.LabelControl()
        Me.lkpPropiedad = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView8 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colPropiedad = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.lblWaypoint = New DevExpress.XtraEditors.LabelControl()
        Me.cbWaypoint = New System.Windows.Forms.ComboBox()
        Me.lblReferenciaHogar = New DevExpress.XtraEditors.LabelControl()
        Me.txtReferenciaHogar = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl45 = New DevExpress.XtraEditors.LabelControl()
        Me.txtTelefono = New DevExpress.XtraEditors.TextEdit()
        Me.lkpTipoVivienda = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView29 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colTipoViviendaActual = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelControl44 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.lkpComuna = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.ComunaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView6 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colComuna = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCasaDepto = New DevExpress.XtraEditors.TextEdit()
        Me.txtNumero = New DevExpress.XtraEditors.TextEdit()
        Me.txtCalle = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.lkpManzana = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colZonaEOD1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colManzana = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.lkpZona = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colZonaEOD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.lkpFolio = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView5 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colIDFolio = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cargaHogarBackground = New System.ComponentModel.BackgroundWorker()
        Me.ComunaTableAdapter = New EOD.datasetEODTableAdapters.ComunaTableAdapter()
        Me.ValidaHogarTableAdapter = New EOD.datasetEODTableAdapters.ValidaHogarTableAdapter()
        Me.deSabadoLV = New DevExpress.XtraEditors.DateEdit()
        Me.lblSabadoLV = New DevExpress.XtraEditors.LabelControl()
        Me.deDomingoLV = New DevExpress.XtraEditors.DateEdit()
        Me.lblDomingoLV = New DevExpress.XtraEditors.LabelControl()
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ManzanasCatBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.datasetEOD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ZonasCatBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CatastroHogaresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PropiedadBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SiNoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HogarBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TipoViviendaActualBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.txtObservacion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deFechaViajes.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deFechaViajes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkpTipoDia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TipoDiaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit28View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.txtBicicletas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.splitPropiedadPago, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitPropiedadPago.SuspendLayout()
        CType(Me.txtPropiedadOtra.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tabsPagoVivienda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabsPagoVivienda.SuspendLayout()
        Me.tabDividendo.SuspendLayout()
        CType(Me.chkNSNRDividendo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDividendo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabArriendo.SuspendLayout()
        CType(Me.chkNSNRArriendo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtArriendo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabEstimaArriendo.SuspendLayout()
        CType(Me.chkNSNREstima.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEstimaArriendo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkpPropiedad.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.txtReferenciaHogar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTelefono.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkpTipoVivienda.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView29, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkpComuna.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComunaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCasaDepto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNumero.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCalle.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkpManzana.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkpZona.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkpFolio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deSabadoLV.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deSabadoLV.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deDomingoLV.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deDomingoLV.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonControl
        '
        Me.RibbonControl.ExpandCollapseItem.Id = 0
        Me.RibbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl.ExpandCollapseItem})
        Me.RibbonControl.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl.MaxItemId = 55
        Me.RibbonControl.Name = "RibbonControl"
        Me.RibbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl.ShowCategoryInCaption = False
        Me.RibbonControl.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide
        Me.RibbonControl.ShowQatLocationSelector = False
        Me.RibbonControl.ShowToolbarCustomizeItem = False
        Me.RibbonControl.Size = New System.Drawing.Size(904, 32)
        Me.RibbonControl.Toolbar.ShowCustomizeItem = False
        Me.RibbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
        '
        'ManzanasCatBindingSource
        '
        Me.ManzanasCatBindingSource.DataMember = "ManzanasCat"
        Me.ManzanasCatBindingSource.DataSource = Me.datasetEOD
        '
        'datasetEOD
        '
        Me.datasetEOD.DataSetName = "datasetEOD"
        Me.datasetEOD.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ZonasCatBindingSource
        '
        Me.ZonasCatBindingSource.DataMember = "ZonasCat"
        Me.ZonasCatBindingSource.DataSource = Me.datasetEOD
        '
        'CatastroHogaresBindingSource
        '
        Me.CatastroHogaresBindingSource.DataMember = "CatastroHogares"
        Me.CatastroHogaresBindingSource.DataSource = Me.datasetEOD
        '
        'PropiedadBindingSource
        '
        Me.PropiedadBindingSource.DataMember = "Propiedad"
        Me.PropiedadBindingSource.DataSource = Me.datasetEOD
        '
        'SiNoBindingSource
        '
        Me.SiNoBindingSource.DataMember = "SiNo"
        Me.SiNoBindingSource.DataSource = Me.datasetEOD
        '
        'btnGuardar
        '
        Me.btnGuardar.Appearance.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnGuardar.Appearance.BackColor2 = System.Drawing.SystemColors.HotTrack
        Me.btnGuardar.Appearance.BorderColor = System.Drawing.SystemColors.HotTrack
        Me.btnGuardar.Appearance.ForeColor = System.Drawing.Color.White
        Me.btnGuardar.Appearance.Options.UseBackColor = True
        Me.btnGuardar.Appearance.Options.UseBorderColor = True
        Me.btnGuardar.Appearance.Options.UseForeColor = True
        Me.btnGuardar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
        Me.btnGuardar.Location = New System.Drawing.Point(716, 442)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(85, 28)
        Me.btnGuardar.TabIndex = 24
        Me.btnGuardar.Text = "Guardar"
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
        Me.btnCancelar.Location = New System.Drawing.Point(807, 442)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(85, 28)
        Me.btnCancelar.TabIndex = 25
        Me.btnCancelar.Text = "Cancelar"
        '
        'ZonasCatTableAdapter
        '
        Me.ZonasCatTableAdapter.ClearBeforeFill = True
        '
        'ManzanasCatTableAdapter
        '
        Me.ManzanasCatTableAdapter.ClearBeforeFill = True
        '
        'CatastroHogaresTableAdapter
        '
        Me.CatastroHogaresTableAdapter.ClearBeforeFill = True
        '
        'PropiedadTableAdapter
        '
        Me.PropiedadTableAdapter.ClearBeforeFill = True
        '
        'SiNoTableAdapter
        '
        Me.SiNoTableAdapter.ClearBeforeFill = True
        '
        'HogarBindingSource
        '
        Me.HogarBindingSource.AllowNew = False
        Me.HogarBindingSource.DataMember = "Hogar"
        Me.HogarBindingSource.DataSource = Me.datasetEOD
        '
        'TipoViviendaActualBindingSource
        '
        Me.TipoViviendaActualBindingSource.DataMember = "TipoViviendaActual"
        Me.TipoViviendaActualBindingSource.DataSource = Me.datasetEOD
        '
        'HogarTableAdapter
        '
        Me.HogarTableAdapter.ClearBeforeFill = True
        '
        'TipoViviendaActualTableAdapter
        '
        Me.TipoViviendaActualTableAdapter.ClearBeforeFill = True
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.deDomingoLV)
        Me.GroupControl1.Controls.Add(Me.lblDomingoLV)
        Me.GroupControl1.Controls.Add(Me.deSabadoLV)
        Me.GroupControl1.Controls.Add(Me.lblSabadoLV)
        Me.GroupControl1.Controls.Add(Me.LabelControl41)
        Me.GroupControl1.Controls.Add(Me.txtObservacion)
        Me.GroupControl1.Controls.Add(Me.deFechaViajes)
        Me.GroupControl1.Controls.Add(Me.LabelControl43)
        Me.GroupControl1.Controls.Add(Me.lkpTipoDia)
        Me.GroupControl1.Controls.Add(Me.LabelControl42)
        Me.GroupControl1.Location = New System.Drawing.Point(12, 298)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(880, 138)
        Me.GroupControl1.TabIndex = 93
        Me.GroupControl1.Text = "Observaciones - Fecha programada de viajes"
        '
        'LabelControl41
        '
        Me.LabelControl41.Location = New System.Drawing.Point(15, 23)
        Me.LabelControl41.Name = "LabelControl41"
        Me.LabelControl41.Size = New System.Drawing.Size(190, 13)
        Me.LabelControl41.TabIndex = 9
        Me.LabelControl41.Text = "¿Tiene alguna observación o acotación?"
        '
        'txtObservacion
        '
        Me.txtObservacion.Location = New System.Drawing.Point(14, 42)
        Me.txtObservacion.MenuManager = Me.RibbonControl
        Me.txtObservacion.Name = "txtObservacion"
        Me.txtObservacion.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtObservacion.Size = New System.Drawing.Size(389, 76)
        Me.txtObservacion.TabIndex = 19
        '
        'deFechaViajes
        '
        Me.deFechaViajes.EditValue = Nothing
        Me.deFechaViajes.Enabled = False
        Me.deFechaViajes.Location = New System.Drawing.Point(652, 40)
        Me.deFechaViajes.MenuManager = Me.RibbonControl
        Me.deFechaViajes.Name = "deFechaViajes"
        Me.deFechaViajes.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.deFechaViajes.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deFechaViajes.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deFechaViajes.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.deFechaViajes.Size = New System.Drawing.Size(200, 20)
        Me.deFechaViajes.TabIndex = 21
        '
        'LabelControl43
        '
        Me.LabelControl43.Location = New System.Drawing.Point(652, 20)
        Me.LabelControl43.Name = "LabelControl43"
        Me.LabelControl43.Size = New System.Drawing.Size(140, 13)
        Me.LabelControl43.TabIndex = 8
        Me.LabelControl43.Text = "Fecha programada de viajes:"
        '
        'lkpTipoDia
        '
        Me.lkpTipoDia.EditValue = ""
        Me.lkpTipoDia.Enabled = False
        Me.lkpTipoDia.Location = New System.Drawing.Point(427, 40)
        Me.lkpTipoDia.MenuManager = Me.RibbonControl
        Me.lkpTipoDia.Name = "lkpTipoDia"
        Me.lkpTipoDia.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lkpTipoDia.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkpTipoDia.Properties.DataSource = Me.TipoDiaBindingSource
        Me.lkpTipoDia.Properties.DisplayMember = "TipoDia"
        Me.lkpTipoDia.Properties.PopupFormMinSize = New System.Drawing.Size(152, 60)
        Me.lkpTipoDia.Properties.PopupFormSize = New System.Drawing.Size(152, 60)
        Me.lkpTipoDia.Properties.ValueMember = "ID"
        Me.lkpTipoDia.Properties.View = Me.GridLookUpEdit28View
        Me.lkpTipoDia.Size = New System.Drawing.Size(200, 20)
        Me.lkpTipoDia.TabIndex = 20
        '
        'TipoDiaBindingSource
        '
        Me.TipoDiaBindingSource.DataMember = "TipoDia"
        Me.TipoDiaBindingSource.DataSource = Me.datasetEOD
        '
        'GridLookUpEdit28View
        '
        Me.GridLookUpEdit28View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colTipoDia})
        Me.GridLookUpEdit28View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit28View.Name = "GridLookUpEdit28View"
        Me.GridLookUpEdit28View.OptionsBehavior.Editable = False
        Me.GridLookUpEdit28View.OptionsCustomization.AllowFilter = False
        Me.GridLookUpEdit28View.OptionsCustomization.AllowGroup = False
        Me.GridLookUpEdit28View.OptionsCustomization.AllowSort = False
        Me.GridLookUpEdit28View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit28View.OptionsView.ShowColumnHeaders = False
        Me.GridLookUpEdit28View.OptionsView.ShowGroupPanel = False
        Me.GridLookUpEdit28View.OptionsView.ShowIndicator = False
        '
        'colTipoDia
        '
        Me.colTipoDia.FieldName = "TipoDia"
        Me.colTipoDia.Name = "colTipoDia"
        Me.colTipoDia.Visible = True
        Me.colTipoDia.VisibleIndex = 0
        '
        'LabelControl42
        '
        Me.LabelControl42.Location = New System.Drawing.Point(427, 20)
        Me.LabelControl42.Name = "LabelControl42"
        Me.LabelControl42.Size = New System.Drawing.Size(92, 13)
        Me.LabelControl42.TabIndex = 6
        Me.LabelControl42.Text = "¿Esta encuesta es?"
        '
        'TipoDiaTableAdapter
        '
        Me.TipoDiaTableAdapter.ClearBeforeFill = True
        '
        'GroupControl3
        '
        Me.GroupControl3.Controls.Add(Me.txtBicicletas)
        Me.GroupControl3.Controls.Add(Me.LabelControl27)
        Me.GroupControl3.Controls.Add(Me.splitPropiedadPago)
        Me.GroupControl3.Controls.Add(Me.LabelControl17)
        Me.GroupControl3.Controls.Add(Me.lkpPropiedad)
        Me.GroupControl3.Location = New System.Drawing.Point(12, 170)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(880, 122)
        Me.GroupControl3.TabIndex = 91
        Me.GroupControl3.Text = "Datos generales de la vivienda"
        '
        'txtBicicletas
        '
        Me.txtBicicletas.Location = New System.Drawing.Point(16, 94)
        Me.txtBicicletas.MenuManager = Me.RibbonControl
        Me.txtBicicletas.Name = "txtBicicletas"
        Me.txtBicicletas.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtBicicletas.Properties.Mask.EditMask = "n0"
        Me.txtBicicletas.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtBicicletas.Size = New System.Drawing.Size(37, 20)
        Me.txtBicicletas.TabIndex = 18
        '
        'LabelControl27
        '
        Me.LabelControl27.Location = New System.Drawing.Point(17, 76)
        Me.LabelControl27.Name = "LabelControl27"
        Me.LabelControl27.Size = New System.Drawing.Size(285, 13)
        Me.LabelControl27.TabIndex = 93
        Me.LabelControl27.Text = "¿Cuántas bicicletas para adulto tiene disponibles para usar?"
        '
        'splitPropiedadPago
        '
        Me.splitPropiedadPago.Collapsed = True
        Me.splitPropiedadPago.CollapsePanel = DevExpress.XtraEditors.SplitCollapsePanel.Panel1
        Me.splitPropiedadPago.Location = New System.Drawing.Point(220, 12)
        Me.splitPropiedadPago.Name = "splitPropiedadPago"
        Me.splitPropiedadPago.Panel1.Controls.Add(Me.lblPropiedadOtra)
        Me.splitPropiedadPago.Panel1.Controls.Add(Me.txtPropiedadOtra)
        Me.splitPropiedadPago.Panel1.Text = "Panel1"
        Me.splitPropiedadPago.Panel2.Controls.Add(Me.tabsPagoVivienda)
        Me.splitPropiedadPago.Panel2.Text = "Panel2"
        Me.splitPropiedadPago.Size = New System.Drawing.Size(655, 64)
        Me.splitPropiedadPago.SplitterPosition = 124
        Me.splitPropiedadPago.TabIndex = 92
        Me.splitPropiedadPago.Text = "SplitContainerControl1"
        '
        'lblPropiedadOtra
        '
        Me.lblPropiedadOtra.Location = New System.Drawing.Point(17, 12)
        Me.lblPropiedadOtra.Name = "lblPropiedadOtra"
        Me.lblPropiedadOtra.Size = New System.Drawing.Size(22, 13)
        Me.lblPropiedadOtra.TabIndex = 25
        Me.lblPropiedadOtra.Text = "Otra"
        Me.lblPropiedadOtra.Visible = False
        '
        'txtPropiedadOtra
        '
        Me.txtPropiedadOtra.Location = New System.Drawing.Point(17, 31)
        Me.txtPropiedadOtra.MenuManager = Me.RibbonControl
        Me.txtPropiedadOtra.Name = "txtPropiedadOtra"
        Me.txtPropiedadOtra.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtPropiedadOtra.Size = New System.Drawing.Size(100, 20)
        Me.txtPropiedadOtra.TabIndex = 9
        Me.txtPropiedadOtra.Visible = False
        '
        'tabsPagoVivienda
        '
        Me.tabsPagoVivienda.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.tabsPagoVivienda.BorderStylePage = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.tabsPagoVivienda.Location = New System.Drawing.Point(8, 6)
        Me.tabsPagoVivienda.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.tabsPagoVivienda.LookAndFeel.UseDefaultLookAndFeel = False
        Me.tabsPagoVivienda.Name = "tabsPagoVivienda"
        Me.tabsPagoVivienda.SelectedTabPage = Me.tabDividendo
        Me.tabsPagoVivienda.ShowTabHeader = DevExpress.Utils.DefaultBoolean.[False]
        Me.tabsPagoVivienda.Size = New System.Drawing.Size(424, 47)
        Me.tabsPagoVivienda.TabIndex = 28
        Me.tabsPagoVivienda.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tabDividendo, Me.tabArriendo, Me.tabEstimaArriendo})
        Me.tabsPagoVivienda.TabStop = False
        Me.tabsPagoVivienda.Visible = False
        '
        'tabDividendo
        '
        Me.tabDividendo.Controls.Add(Me.chkNSNRDividendo)
        Me.tabDividendo.Controls.Add(Me.txtDividendo)
        Me.tabDividendo.Controls.Add(Me.LabelControl18)
        Me.tabDividendo.Name = "tabDividendo"
        Me.tabDividendo.Size = New System.Drawing.Size(424, 47)
        Me.tabDividendo.Text = "tabDividendo"
        '
        'chkNSNRDividendo
        '
        Me.chkNSNRDividendo.Location = New System.Drawing.Point(187, 25)
        Me.chkNSNRDividendo.MenuManager = Me.RibbonControl
        Me.chkNSNRDividendo.Name = "chkNSNRDividendo"
        Me.chkNSNRDividendo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.chkNSNRDividendo.Properties.Appearance.Options.UseForeColor = True
        Me.chkNSNRDividendo.Properties.Caption = "No sabe/No responde"
        Me.chkNSNRDividendo.Size = New System.Drawing.Size(132, 19)
        Me.chkNSNRDividendo.TabIndex = 13
        '
        'txtDividendo
        '
        Me.txtDividendo.Location = New System.Drawing.Point(3, 25)
        Me.txtDividendo.MenuManager = Me.RibbonControl
        Me.txtDividendo.Name = "txtDividendo"
        Me.txtDividendo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtDividendo.Properties.Mask.EditMask = "c0"
        Me.txtDividendo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtDividendo.Size = New System.Drawing.Size(100, 20)
        Me.txtDividendo.TabIndex = 12
        '
        'LabelControl18
        '
        Me.LabelControl18.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LabelControl18.Appearance.Options.UseForeColor = True
        Me.LabelControl18.Location = New System.Drawing.Point(3, 6)
        Me.LabelControl18.Name = "LabelControl18"
        Me.LabelControl18.Size = New System.Drawing.Size(178, 13)
        Me.LabelControl18.TabIndex = 29
        Me.LabelControl18.Text = "¿Cuánto paga de dividendo mensual?"
        '
        'tabArriendo
        '
        Me.tabArriendo.Controls.Add(Me.chkNSNRArriendo)
        Me.tabArriendo.Controls.Add(Me.txtArriendo)
        Me.tabArriendo.Controls.Add(Me.LabelControl19)
        Me.tabArriendo.Name = "tabArriendo"
        Me.tabArriendo.Size = New System.Drawing.Size(424, 47)
        Me.tabArriendo.Text = "tabArriendo"
        '
        'chkNSNRArriendo
        '
        Me.chkNSNRArriendo.Location = New System.Drawing.Point(181, 24)
        Me.chkNSNRArriendo.MenuManager = Me.RibbonControl
        Me.chkNSNRArriendo.Name = "chkNSNRArriendo"
        Me.chkNSNRArriendo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.chkNSNRArriendo.Properties.Appearance.Options.UseForeColor = True
        Me.chkNSNRArriendo.Properties.Caption = "No sabe/No responde"
        Me.chkNSNRArriendo.Size = New System.Drawing.Size(132, 19)
        Me.chkNSNRArriendo.TabIndex = 15
        '
        'txtArriendo
        '
        Me.txtArriendo.Location = New System.Drawing.Point(3, 24)
        Me.txtArriendo.MenuManager = Me.RibbonControl
        Me.txtArriendo.Name = "txtArriendo"
        Me.txtArriendo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtArriendo.Properties.Mask.EditMask = "c0"
        Me.txtArriendo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtArriendo.Size = New System.Drawing.Size(100, 20)
        Me.txtArriendo.TabIndex = 14
        '
        'LabelControl19
        '
        Me.LabelControl19.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LabelControl19.Appearance.Options.UseForeColor = True
        Me.LabelControl19.Location = New System.Drawing.Point(3, 5)
        Me.LabelControl19.Name = "LabelControl19"
        Me.LabelControl19.Size = New System.Drawing.Size(172, 13)
        Me.LabelControl19.TabIndex = 31
        Me.LabelControl19.Text = "¿Cuánto paga de arriendo mensual?"
        '
        'tabEstimaArriendo
        '
        Me.tabEstimaArriendo.Controls.Add(Me.chkNSNREstima)
        Me.tabEstimaArriendo.Controls.Add(Me.txtEstimaArriendo)
        Me.tabEstimaArriendo.Controls.Add(Me.LabelControl20)
        Me.tabEstimaArriendo.Name = "tabEstimaArriendo"
        Me.tabEstimaArriendo.Size = New System.Drawing.Size(424, 47)
        Me.tabEstimaArriendo.Text = "tabEstimaArriendo"
        '
        'chkNSNREstima
        '
        Me.chkNSNREstima.Location = New System.Drawing.Point(251, 25)
        Me.chkNSNREstima.MenuManager = Me.RibbonControl
        Me.chkNSNREstima.Name = "chkNSNREstima"
        Me.chkNSNREstima.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.chkNSNREstima.Properties.Appearance.Options.UseForeColor = True
        Me.chkNSNREstima.Properties.Caption = "No sabe/No responde"
        Me.chkNSNREstima.Size = New System.Drawing.Size(132, 19)
        Me.chkNSNREstima.TabIndex = 11
        '
        'txtEstimaArriendo
        '
        Me.txtEstimaArriendo.Location = New System.Drawing.Point(3, 25)
        Me.txtEstimaArriendo.MenuManager = Me.RibbonControl
        Me.txtEstimaArriendo.Name = "txtEstimaArriendo"
        Me.txtEstimaArriendo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtEstimaArriendo.Properties.Mask.EditMask = "c0"
        Me.txtEstimaArriendo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtEstimaArriendo.Size = New System.Drawing.Size(100, 20)
        Me.txtEstimaArriendo.TabIndex = 10
        '
        'LabelControl20
        '
        Me.LabelControl20.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LabelControl20.Appearance.Options.UseForeColor = True
        Me.LabelControl20.Location = New System.Drawing.Point(3, 6)
        Me.LabelControl20.Name = "LabelControl20"
        Me.LabelControl20.Size = New System.Drawing.Size(247, 13)
        Me.LabelControl20.TabIndex = 31
        Me.LabelControl20.Text = "¿Cuánto estima el arriendo mensual de su vivienda?"
        '
        'LabelControl17
        '
        Me.LabelControl17.Location = New System.Drawing.Point(16, 24)
        Me.LabelControl17.Name = "LabelControl17"
        Me.LabelControl17.Size = New System.Drawing.Size(79, 13)
        Me.LabelControl17.TabIndex = 27
        Me.LabelControl17.Text = "¿Su vivienda es?"
        '
        'lkpPropiedad
        '
        Me.lkpPropiedad.EditValue = ""
        Me.lkpPropiedad.Location = New System.Drawing.Point(16, 43)
        Me.lkpPropiedad.MenuManager = Me.RibbonControl
        Me.lkpPropiedad.Name = "lkpPropiedad"
        Me.lkpPropiedad.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lkpPropiedad.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkpPropiedad.Properties.DataSource = Me.PropiedadBindingSource
        Me.lkpPropiedad.Properties.DisplayMember = "Propiedad"
        Me.lkpPropiedad.Properties.ImmediatePopup = True
        Me.lkpPropiedad.Properties.PopupFormMinSize = New System.Drawing.Size(198, 80)
        Me.lkpPropiedad.Properties.PopupFormSize = New System.Drawing.Size(198, 80)
        Me.lkpPropiedad.Properties.ShowFooter = False
        Me.lkpPropiedad.Properties.ValueMember = "ID"
        Me.lkpPropiedad.Properties.View = Me.GridView8
        Me.lkpPropiedad.Size = New System.Drawing.Size(198, 20)
        Me.lkpPropiedad.TabIndex = 9
        '
        'GridView8
        '
        Me.GridView8.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colPropiedad})
        Me.GridView8.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView8.Name = "GridView8"
        Me.GridView8.OptionsBehavior.Editable = False
        Me.GridView8.OptionsCustomization.AllowFilter = False
        Me.GridView8.OptionsCustomization.AllowGroup = False
        Me.GridView8.OptionsCustomization.AllowSort = False
        Me.GridView8.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView8.OptionsView.ShowColumnHeaders = False
        Me.GridView8.OptionsView.ShowGroupPanel = False
        Me.GridView8.OptionsView.ShowIndicator = False
        '
        'colPropiedad
        '
        Me.colPropiedad.FieldName = "Propiedad"
        Me.colPropiedad.Name = "colPropiedad"
        Me.colPropiedad.Visible = True
        Me.colPropiedad.VisibleIndex = 0
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.lblWaypoint)
        Me.GroupControl2.Controls.Add(Me.cbWaypoint)
        Me.GroupControl2.Controls.Add(Me.lblReferenciaHogar)
        Me.GroupControl2.Controls.Add(Me.txtReferenciaHogar)
        Me.GroupControl2.Controls.Add(Me.LabelControl45)
        Me.GroupControl2.Controls.Add(Me.txtTelefono)
        Me.GroupControl2.Controls.Add(Me.lkpTipoVivienda)
        Me.GroupControl2.Controls.Add(Me.LabelControl44)
        Me.GroupControl2.Controls.Add(Me.LabelControl10)
        Me.GroupControl2.Controls.Add(Me.lkpComuna)
        Me.GroupControl2.Controls.Add(Me.LabelControl9)
        Me.GroupControl2.Controls.Add(Me.LabelControl8)
        Me.GroupControl2.Controls.Add(Me.LabelControl7)
        Me.GroupControl2.Controls.Add(Me.txtCasaDepto)
        Me.GroupControl2.Controls.Add(Me.txtNumero)
        Me.GroupControl2.Controls.Add(Me.txtCalle)
        Me.GroupControl2.Controls.Add(Me.LabelControl6)
        Me.GroupControl2.Controls.Add(Me.lkpManzana)
        Me.GroupControl2.Controls.Add(Me.LabelControl5)
        Me.GroupControl2.Controls.Add(Me.lkpZona)
        Me.GroupControl2.Controls.Add(Me.LabelControl4)
        Me.GroupControl2.Controls.Add(Me.lkpFolio)
        Me.GroupControl2.Location = New System.Drawing.Point(12, 38)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(880, 126)
        Me.GroupControl2.TabIndex = 90
        Me.GroupControl2.Text = "Ubicación del hogar"
        '
        'lblWaypoint
        '
        Me.lblWaypoint.Location = New System.Drawing.Point(639, 77)
        Me.lblWaypoint.Name = "lblWaypoint"
        Me.lblWaypoint.Size = New System.Drawing.Size(170, 13)
        Me.lblWaypoint.TabIndex = 38
        Me.lblWaypoint.Text = "Waypoint con localización del hogar"
        '
        'cbWaypoint
        '
        Me.cbWaypoint.FormattingEnabled = True
        Me.cbWaypoint.Location = New System.Drawing.Point(639, 96)
        Me.cbWaypoint.Name = "cbWaypoint"
        Me.cbWaypoint.Size = New System.Drawing.Size(208, 21)
        Me.cbWaypoint.Sorted = True
        Me.cbWaypoint.TabIndex = 37
        '
        'lblReferenciaHogar
        '
        Me.lblReferenciaHogar.Location = New System.Drawing.Point(15, 77)
        Me.lblReferenciaHogar.Name = "lblReferenciaHogar"
        Me.lblReferenciaHogar.Size = New System.Drawing.Size(177, 13)
        Me.lblReferenciaHogar.TabIndex = 27
        Me.lblReferenciaHogar.Text = "Referencias para ubicación del hogar"
        '
        'txtReferenciaHogar
        '
        Me.txtReferenciaHogar.Enabled = False
        Me.txtReferenciaHogar.Location = New System.Drawing.Point(15, 96)
        Me.txtReferenciaHogar.MenuManager = Me.RibbonControl
        Me.txtReferenciaHogar.Name = "txtReferenciaHogar"
        Me.txtReferenciaHogar.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtReferenciaHogar.Properties.Mask.EditMask = "d"
        Me.txtReferenciaHogar.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtReferenciaHogar.Properties.MaxLength = 9
        Me.txtReferenciaHogar.Size = New System.Drawing.Size(266, 20)
        Me.txtReferenciaHogar.TabIndex = 26
        '
        'LabelControl45
        '
        Me.LabelControl45.Location = New System.Drawing.Point(527, 77)
        Me.LabelControl45.Name = "LabelControl45"
        Me.LabelControl45.Size = New System.Drawing.Size(42, 13)
        Me.LabelControl45.TabIndex = 25
        Me.LabelControl45.Text = "Teléfono"
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(527, 96)
        Me.txtTelefono.MenuManager = Me.RibbonControl
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtTelefono.Properties.Mask.EditMask = "d"
        Me.txtTelefono.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTelefono.Properties.MaxLength = 9
        Me.txtTelefono.Size = New System.Drawing.Size(100, 20)
        Me.txtTelefono.TabIndex = 24
        '
        'lkpTipoVivienda
        '
        Me.lkpTipoVivienda.EditValue = ""
        Me.lkpTipoVivienda.Location = New System.Drawing.Point(303, 96)
        Me.lkpTipoVivienda.MenuManager = Me.RibbonControl
        Me.lkpTipoVivienda.Name = "lkpTipoVivienda"
        Me.lkpTipoVivienda.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lkpTipoVivienda.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkpTipoVivienda.Properties.DataSource = Me.TipoViviendaActualBindingSource
        Me.lkpTipoVivienda.Properties.DisplayMember = "TipoViviendaActual"
        Me.lkpTipoVivienda.Properties.ImmediatePopup = True
        Me.lkpTipoVivienda.Properties.PopupFormMinSize = New System.Drawing.Size(183, 80)
        Me.lkpTipoVivienda.Properties.PopupFormSize = New System.Drawing.Size(183, 80)
        Me.lkpTipoVivienda.Properties.ShowFooter = False
        Me.lkpTipoVivienda.Properties.ValueMember = "ID"
        Me.lkpTipoVivienda.Properties.View = Me.GridView29
        Me.lkpTipoVivienda.Size = New System.Drawing.Size(183, 20)
        Me.lkpTipoVivienda.TabIndex = 23
        '
        'GridView29
        '
        Me.GridView29.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colTipoViviendaActual})
        Me.GridView29.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView29.Name = "GridView29"
        Me.GridView29.OptionsBehavior.Editable = False
        Me.GridView29.OptionsCustomization.AllowFilter = False
        Me.GridView29.OptionsCustomization.AllowGroup = False
        Me.GridView29.OptionsCustomization.AllowSort = False
        Me.GridView29.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView29.OptionsView.ShowColumnHeaders = False
        Me.GridView29.OptionsView.ShowGroupPanel = False
        Me.GridView29.OptionsView.ShowIndicator = False
        '
        'colTipoViviendaActual
        '
        Me.colTipoViviendaActual.FieldName = "TipoViviendaActual"
        Me.colTipoViviendaActual.Name = "colTipoViviendaActual"
        Me.colTipoViviendaActual.Visible = True
        Me.colTipoViviendaActual.VisibleIndex = 0
        '
        'LabelControl44
        '
        Me.LabelControl44.Location = New System.Drawing.Point(303, 77)
        Me.LabelControl44.Name = "LabelControl44"
        Me.LabelControl44.Size = New System.Drawing.Size(205, 13)
        Me.LabelControl44.TabIndex = 22
        Me.LabelControl44.Text = "Tipo de vivienda donde reside actualmente"
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(639, 24)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(39, 13)
        Me.LabelControl10.TabIndex = 20
        Me.LabelControl10.Text = "Comuna"
        '
        'lkpComuna
        '
        Me.lkpComuna.EditValue = ""
        Me.lkpComuna.Enabled = False
        Me.lkpComuna.Location = New System.Drawing.Point(639, 43)
        Me.lkpComuna.MenuManager = Me.RibbonControl
        Me.lkpComuna.Name = "lkpComuna"
        Me.lkpComuna.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lkpComuna.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkpComuna.Properties.DataSource = Me.ComunaBindingSource
        Me.lkpComuna.Properties.DisplayMember = "Comuna"
        Me.lkpComuna.Properties.ImmediatePopup = True
        Me.lkpComuna.Properties.PopupFormMinSize = New System.Drawing.Size(105, 280)
        Me.lkpComuna.Properties.PopupFormSize = New System.Drawing.Size(105, 280)
        Me.lkpComuna.Properties.ShowFooter = False
        Me.lkpComuna.Properties.ValueMember = "ID"
        Me.lkpComuna.Properties.View = Me.GridView6
        Me.lkpComuna.Size = New System.Drawing.Size(105, 20)
        Me.lkpComuna.TabIndex = 7
        '
        'ComunaBindingSource
        '
        Me.ComunaBindingSource.DataMember = "Comuna"
        Me.ComunaBindingSource.DataSource = Me.datasetEOD
        Me.ComunaBindingSource.Filter = "id > 0"
        '
        'GridView6
        '
        Me.GridView6.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colComuna})
        Me.GridView6.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView6.Name = "GridView6"
        Me.GridView6.OptionsBehavior.Editable = False
        Me.GridView6.OptionsCustomization.AllowFilter = False
        Me.GridView6.OptionsCustomization.AllowGroup = False
        Me.GridView6.OptionsCustomization.AllowSort = False
        Me.GridView6.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView6.OptionsView.ShowColumnHeaders = False
        Me.GridView6.OptionsView.ShowGroupPanel = False
        Me.GridView6.OptionsView.ShowIndicator = False
        '
        'colComuna
        '
        Me.colComuna.FieldName = "Comuna"
        Me.colComuna.Name = "colComuna"
        Me.colComuna.Visible = True
        Me.colComuna.VisibleIndex = 0
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(556, 24)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(57, 13)
        Me.LabelControl9.TabIndex = 18
        Me.LabelControl9.Text = "Casa/Depto"
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(489, 24)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl8.TabIndex = 17
        Me.LabelControl8.Text = "Número"
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(303, 24)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(23, 13)
        Me.LabelControl7.TabIndex = 16
        Me.LabelControl7.Text = "Calle"
        '
        'txtCasaDepto
        '
        Me.txtCasaDepto.Enabled = False
        Me.txtCasaDepto.Location = New System.Drawing.Point(556, 43)
        Me.txtCasaDepto.MenuManager = Me.RibbonControl
        Me.txtCasaDepto.Name = "txtCasaDepto"
        Me.txtCasaDepto.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtCasaDepto.Size = New System.Drawing.Size(57, 20)
        Me.txtCasaDepto.TabIndex = 6
        '
        'txtNumero
        '
        Me.txtNumero.Enabled = False
        Me.txtNumero.Location = New System.Drawing.Point(489, 43)
        Me.txtNumero.MenuManager = Me.RibbonControl
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtNumero.Size = New System.Drawing.Size(37, 20)
        Me.txtNumero.TabIndex = 5
        '
        'txtCalle
        '
        Me.txtCalle.Enabled = False
        Me.txtCalle.Location = New System.Drawing.Point(303, 43)
        Me.txtCalle.MenuManager = Me.RibbonControl
        Me.txtCalle.Name = "txtCalle"
        Me.txtCalle.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtCalle.Size = New System.Drawing.Size(165, 20)
        Me.txtCalle.TabIndex = 4
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(16, 24)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(24, 13)
        Me.LabelControl6.TabIndex = 7
        Me.LabelControl6.Text = "Zona"
        '
        'lkpManzana
        '
        Me.lkpManzana.EditValue = ""
        Me.lkpManzana.Enabled = False
        Me.lkpManzana.Location = New System.Drawing.Point(101, 43)
        Me.lkpManzana.MenuManager = Me.RibbonControl
        Me.lkpManzana.Name = "lkpManzana"
        Me.lkpManzana.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lkpManzana.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkpManzana.Properties.DataSource = Me.ManzanasCatBindingSource
        Me.lkpManzana.Properties.DisplayMember = "Manzana"
        Me.lkpManzana.Properties.PopupFormMinSize = New System.Drawing.Size(62, 0)
        Me.lkpManzana.Properties.PopupFormSize = New System.Drawing.Size(62, 0)
        Me.lkpManzana.Properties.ShowFooter = False
        Me.lkpManzana.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.lkpManzana.Properties.ValueMember = "Manzana"
        Me.lkpManzana.Properties.View = Me.GridView3
        Me.lkpManzana.Size = New System.Drawing.Size(62, 20)
        Me.lkpManzana.TabIndex = 2
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colZonaEOD1, Me.colManzana})
        Me.GridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsBehavior.Editable = False
        Me.GridView3.OptionsCustomization.AllowFilter = False
        Me.GridView3.OptionsCustomization.AllowGroup = False
        Me.GridView3.OptionsCustomization.AllowSort = False
        Me.GridView3.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView3.OptionsView.ShowColumnHeaders = False
        Me.GridView3.OptionsView.ShowGroupPanel = False
        Me.GridView3.OptionsView.ShowIndicator = False
        '
        'colZonaEOD1
        '
        Me.colZonaEOD1.FieldName = "ZonaEOD"
        Me.colZonaEOD1.Name = "colZonaEOD1"
        '
        'colManzana
        '
        Me.colManzana.FieldName = "Manzana"
        Me.colManzana.Name = "colManzana"
        Me.colManzana.Visible = True
        Me.colManzana.VisibleIndex = 0
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(101, 24)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(43, 13)
        Me.LabelControl5.TabIndex = 8
        Me.LabelControl5.Text = "Manzana"
        '
        'lkpZona
        '
        Me.lkpZona.EditValue = ""
        Me.lkpZona.Enabled = False
        Me.lkpZona.Location = New System.Drawing.Point(15, 43)
        Me.lkpZona.MenuManager = Me.RibbonControl
        Me.lkpZona.Name = "lkpZona"
        Me.lkpZona.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lkpZona.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkpZona.Properties.DataSource = Me.ZonasCatBindingSource
        Me.lkpZona.Properties.DisplayMember = "ZonaEOD"
        Me.lkpZona.Properties.ImmediatePopup = True
        Me.lkpZona.Properties.PopupFormMinSize = New System.Drawing.Size(63, 0)
        Me.lkpZona.Properties.PopupFormSize = New System.Drawing.Size(63, 0)
        Me.lkpZona.Properties.ShowFooter = False
        Me.lkpZona.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.lkpZona.Properties.ValueMember = "ZonaEOD"
        Me.lkpZona.Properties.View = Me.GridView4
        Me.lkpZona.Size = New System.Drawing.Size(63, 20)
        Me.lkpZona.TabIndex = 1
        '
        'GridView4
        '
        Me.GridView4.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colZonaEOD})
        Me.GridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView4.Name = "GridView4"
        Me.GridView4.OptionsBehavior.Editable = False
        Me.GridView4.OptionsCustomization.AllowFilter = False
        Me.GridView4.OptionsCustomization.AllowGroup = False
        Me.GridView4.OptionsCustomization.AllowSort = False
        Me.GridView4.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView4.OptionsView.ShowColumnHeaders = False
        Me.GridView4.OptionsView.ShowGroupPanel = False
        Me.GridView4.OptionsView.ShowIndicator = False
        '
        'colZonaEOD
        '
        Me.colZonaEOD.FieldName = "ZonaEOD"
        Me.colZonaEOD.Name = "colZonaEOD"
        Me.colZonaEOD.Visible = True
        Me.colZonaEOD.VisibleIndex = 0
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(187, 24)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(22, 13)
        Me.LabelControl4.TabIndex = 10
        Me.LabelControl4.Text = "Folio"
        '
        'lkpFolio
        '
        Me.lkpFolio.EditValue = ""
        Me.lkpFolio.Enabled = False
        Me.lkpFolio.Location = New System.Drawing.Point(187, 43)
        Me.lkpFolio.MenuManager = Me.RibbonControl
        Me.lkpFolio.Name = "lkpFolio"
        Me.lkpFolio.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lkpFolio.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkpFolio.Properties.DataSource = Me.CatastroHogaresBindingSource
        Me.lkpFolio.Properties.DisplayMember = "IDFolio"
        Me.lkpFolio.Properties.PopupFormMinSize = New System.Drawing.Size(94, 0)
        Me.lkpFolio.Properties.PopupFormSize = New System.Drawing.Size(94, 0)
        Me.lkpFolio.Properties.ShowFooter = False
        Me.lkpFolio.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.lkpFolio.Properties.ValueMember = "IDFolio"
        Me.lkpFolio.Properties.View = Me.GridView5
        Me.lkpFolio.Size = New System.Drawing.Size(94, 20)
        Me.lkpFolio.TabIndex = 3
        '
        'GridView5
        '
        Me.GridView5.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIDFolio})
        Me.GridView5.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView5.Name = "GridView5"
        Me.GridView5.OptionsBehavior.Editable = False
        Me.GridView5.OptionsCustomization.AllowFilter = False
        Me.GridView5.OptionsCustomization.AllowGroup = False
        Me.GridView5.OptionsCustomization.AllowSort = False
        Me.GridView5.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView5.OptionsView.ShowColumnHeaders = False
        Me.GridView5.OptionsView.ShowGroupPanel = False
        Me.GridView5.OptionsView.ShowIndicator = False
        '
        'colIDFolio
        '
        Me.colIDFolio.FieldName = "IDFolio"
        Me.colIDFolio.Name = "colIDFolio"
        Me.colIDFolio.Visible = True
        Me.colIDFolio.VisibleIndex = 0
        '
        'cargaHogarBackground
        '
        '
        'ComunaTableAdapter
        '
        Me.ComunaTableAdapter.ClearBeforeFill = True
        '
        'ValidaHogarTableAdapter
        '
        Me.ValidaHogarTableAdapter.ClearBeforeFill = True
        '
        'deSabadoLV
        '
        Me.deSabadoLV.EditValue = Nothing
        Me.deSabadoLV.Enabled = False
        Me.deSabadoLV.Location = New System.Drawing.Point(427, 98)
        Me.deSabadoLV.MenuManager = Me.RibbonControl
        Me.deSabadoLV.Name = "deSabadoLV"
        Me.deSabadoLV.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.deSabadoLV.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deSabadoLV.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deSabadoLV.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.deSabadoLV.Size = New System.Drawing.Size(200, 20)
        Me.deSabadoLV.TabIndex = 22
        Me.deSabadoLV.Visible = False
        '
        'lblSabadoLV
        '
        Me.lblSabadoLV.Location = New System.Drawing.Point(427, 78)
        Me.lblSabadoLV.Name = "lblSabadoLV"
        Me.lblSabadoLV.Size = New System.Drawing.Size(136, 13)
        Me.lblSabadoLV.TabIndex = 22
        Me.lblSabadoLV.Text = "Libro de Viajes - Día sábado:"
        Me.lblSabadoLV.Visible = False
        '
        'deDomingoLV
        '
        Me.deDomingoLV.EditValue = Nothing
        Me.deDomingoLV.Enabled = False
        Me.deDomingoLV.Location = New System.Drawing.Point(652, 98)
        Me.deDomingoLV.MenuManager = Me.RibbonControl
        Me.deDomingoLV.Name = "deDomingoLV"
        Me.deDomingoLV.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.deDomingoLV.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deDomingoLV.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deDomingoLV.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.deDomingoLV.Size = New System.Drawing.Size(200, 20)
        Me.deDomingoLV.TabIndex = 23
        Me.deDomingoLV.Visible = False
        '
        'lblDomingoLV
        '
        Me.lblDomingoLV.Location = New System.Drawing.Point(652, 78)
        Me.lblDomingoLV.Name = "lblDomingoLV"
        Me.lblDomingoLV.Size = New System.Drawing.Size(141, 13)
        Me.lblDomingoLV.TabIndex = 24
        Me.lblDomingoLV.Text = "Libro de Viajes - Día domingo:"
        Me.lblDomingoLV.Visible = False
        '
        'ModificarHogar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(904, 479)
        Me.Controls.Add(Me.GroupControl3)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.RibbonControl)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "ModificarHogar"
        Me.Ribbon = Me.RibbonControl
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modificando datos del hogar"
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ManzanasCatBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.datasetEOD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ZonasCatBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CatastroHogaresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PropiedadBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SiNoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HogarBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TipoViviendaActualBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.txtObservacion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deFechaViajes.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deFechaViajes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkpTipoDia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TipoDiaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit28View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        Me.GroupControl3.PerformLayout()
        CType(Me.txtBicicletas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.splitPropiedadPago, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitPropiedadPago.ResumeLayout(False)
        CType(Me.txtPropiedadOtra.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tabsPagoVivienda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabsPagoVivienda.ResumeLayout(False)
        Me.tabDividendo.ResumeLayout(False)
        Me.tabDividendo.PerformLayout()
        CType(Me.chkNSNRDividendo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDividendo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabArriendo.ResumeLayout(False)
        Me.tabArriendo.PerformLayout()
        CType(Me.chkNSNRArriendo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtArriendo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabEstimaArriendo.ResumeLayout(False)
        Me.tabEstimaArriendo.PerformLayout()
        CType(Me.chkNSNREstima.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEstimaArriendo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkpPropiedad.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.txtReferenciaHogar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTelefono.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkpTipoVivienda.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView29, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkpComuna.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComunaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCasaDepto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNumero.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCalle.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkpManzana.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkpZona.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkpFolio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deSabadoLV.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deSabadoLV.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deDomingoLV.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deDomingoLV.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents btnGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents datasetEOD As EOD.datasetEOD
    Friend WithEvents ZonasCatBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ZonasCatTableAdapter As EOD.datasetEODTableAdapters.ZonasCatTableAdapter
    Friend WithEvents ManzanasCatBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ManzanasCatTableAdapter As EOD.datasetEODTableAdapters.ManzanasCatTableAdapter
    Friend WithEvents CatastroHogaresBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CatastroHogaresTableAdapter As EOD.datasetEODTableAdapters.CatastroHogaresTableAdapter
    Friend WithEvents PropiedadBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PropiedadTableAdapter As EOD.datasetEODTableAdapters.PropiedadTableAdapter
    Friend WithEvents SiNoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SiNoTableAdapter As EOD.datasetEODTableAdapters.SiNoTableAdapter
    Friend WithEvents HogarBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents HogarTableAdapter As EOD.datasetEODTableAdapters.HogarTableAdapter
    Friend WithEvents TipoViviendaActualBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TipoViviendaActualTableAdapter As EOD.datasetEODTableAdapters.TipoViviendaActualTableAdapter
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents deFechaViajes As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl43 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lkpTipoDia As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit28View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colTipoDia As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl42 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl41 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtObservacion As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents TipoDiaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TipoDiaTableAdapter As EOD.datasetEODTableAdapters.TipoDiaTableAdapter
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents tabsPagoVivienda As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents tabDividendo As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents chkNSNRDividendo As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtDividendo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl18 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents tabArriendo As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents chkNSNRArriendo As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtArriendo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl19 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents tabEstimaArriendo As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents chkNSNREstima As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtEstimaArriendo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl20 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl17 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lkpPropiedad As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView8 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colPropiedad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lblReferenciaHogar As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl45 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTelefono As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lkpTipoVivienda As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView29 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colTipoViviendaActual As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl44 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lkpComuna As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView6 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colComuna As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCasaDepto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNumero As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCalle As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lkpManzana As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colZonaEOD1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colManzana As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lkpZona As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colZonaEOD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lkpFolio As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView5 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colIDFolio As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cargaHogarBackground As System.ComponentModel.BackgroundWorker
    Friend WithEvents SplashScreenManager1 As DevExpress.XtraSplashScreen.SplashScreenManager
    Friend WithEvents txtReferenciaHogar As DevExpress.XtraEditors.TextEdit
    Friend WithEvents splitPropiedadPago As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents lblPropiedadOtra As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPropiedadOtra As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ComunaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ComunaTableAdapter As EOD.datasetEODTableAdapters.ComunaTableAdapter
    Friend WithEvents ValidaHogarTableAdapter As EOD.datasetEODTableAdapters.ValidaHogarTableAdapter
    Friend WithEvents SplashScreenManager2 As DevExpress.XtraSplashScreen.SplashScreenManager
    Friend WithEvents lblWaypoint As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cbWaypoint As System.Windows.Forms.ComboBox
    Friend WithEvents txtBicicletas As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl27 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents deDomingoLV As DevExpress.XtraEditors.DateEdit
    Friend WithEvents lblDomingoLV As DevExpress.XtraEditors.LabelControl
    Friend WithEvents deSabadoLV As DevExpress.XtraEditors.DateEdit
    Friend WithEvents lblSabadoLV As DevExpress.XtraEditors.LabelControl



End Class
