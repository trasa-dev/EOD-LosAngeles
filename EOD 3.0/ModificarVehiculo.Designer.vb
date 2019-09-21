<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModificarVehiculo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ModificarVehiculo))
        Me.RibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.VehBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.datasetEOD = New EOD.datasetEOD()
        Me.lkpTipoVeh = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.TipoVehBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colvehiculo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.lkpPropiedadVeh = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.PropiedadVehiculoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPropiedadVehiculo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SiNoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.txtCombustibleOtro = New DevExpress.XtraEditors.TextEdit()
        Me.lblCombustibleOtro = New DevExpress.XtraEditors.LabelControl()
        Me.lkpCombustible = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.CombustibleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView15 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCombustible = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelControl23 = New DevExpress.XtraEditors.LabelControl()
        Me.txtPropiedadVehOtro = New DevExpress.XtraEditors.TextEdit()
        Me.lblPropiedadVehOtro = New DevExpress.XtraEditors.LabelControl()
        Me.btnCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.GridLookUpEdit1 = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView6 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.TipoVehTableAdapter = New EOD.datasetEODTableAdapters.TipoVehTableAdapter()
        Me.SiNoTableAdapter = New EOD.datasetEODTableAdapters.SiNoTableAdapter()
        Me.PropiedadVehiculoTableAdapter = New EOD.datasetEODTableAdapters.PropiedadVehiculoTableAdapter()
        Me.VehiculoTableAdapter = New EOD.datasetEODTableAdapters.VehiculoTableAdapter()
        Me.cargaVehiculoBackground = New System.ComponentModel.BackgroundWorker()
        Me.SplashScreenManager1 = New DevExpress.XtraSplashScreen.SplashScreenManager(Me, GetType(Global.EOD.PantallaEspera), True, True)
        Me.CombustibleTableAdapter = New EOD.datasetEODTableAdapters.CombustibleTableAdapter()
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VehBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.datasetEOD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkpTipoVeh.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TipoVehBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkpPropiedadVeh.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PropiedadVehiculoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SiNoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.txtCombustibleOtro.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkpCombustible.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CombustibleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPropiedadVehOtro.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonControl
        '
        Me.RibbonControl.ExpandCollapseItem.Id = 0
        Me.RibbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl.ExpandCollapseItem})
        Me.RibbonControl.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl.MaxItemId = 1
        Me.RibbonControl.Name = "RibbonControl"
        Me.RibbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl.ShowCategoryInCaption = False
        Me.RibbonControl.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl.ShowFullScreenButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide
        Me.RibbonControl.ShowQatLocationSelector = False
        Me.RibbonControl.ShowToolbarCustomizeItem = False
        Me.RibbonControl.Size = New System.Drawing.Size(518, 32)
        Me.RibbonControl.Toolbar.ShowCustomizeItem = False
        Me.RibbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(14, 32)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(122, 13)
        Me.LabelControl1.TabIndex = 2
        Me.LabelControl1.Text = "¿Qué tipo de vehículo es?"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(14, 58)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(99, 13)
        Me.LabelControl3.TabIndex = 4
        Me.LabelControl3.Text = "¿Este vehículo es...?"
        '
        'VehBindingSource
        '
        Me.VehBindingSource.AllowNew = False
        Me.VehBindingSource.DataMember = "Vehiculo"
        Me.VehBindingSource.DataSource = Me.datasetEOD
        '
        'datasetEOD
        '
        Me.datasetEOD.DataSetName = "datasetEOD"
        Me.datasetEOD.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lkpTipoVeh
        '
        Me.lkpTipoVeh.EditValue = ""
        Me.lkpTipoVeh.Location = New System.Drawing.Point(142, 29)
        Me.lkpTipoVeh.MenuManager = Me.RibbonControl
        Me.lkpTipoVeh.Name = "lkpTipoVeh"
        Me.lkpTipoVeh.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.lkpTipoVeh.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.lkpTipoVeh.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lkpTipoVeh.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkpTipoVeh.Properties.DataSource = Me.TipoVehBindingSource
        Me.lkpTipoVeh.Properties.DisplayMember = "vehiculo"
        Me.lkpTipoVeh.Properties.ImmediatePopup = True
        Me.lkpTipoVeh.Properties.PopupFormMinSize = New System.Drawing.Size(345, 100)
        Me.lkpTipoVeh.Properties.PopupFormSize = New System.Drawing.Size(345, 100)
        Me.lkpTipoVeh.Properties.ShowFooter = False
        Me.lkpTipoVeh.Properties.ValueMember = "ID"
        Me.lkpTipoVeh.Properties.View = Me.GridView1
        Me.lkpTipoVeh.Size = New System.Drawing.Size(345, 20)
        Me.lkpTipoVeh.TabIndex = 12
        '
        'TipoVehBindingSource
        '
        Me.TipoVehBindingSource.DataMember = "TipoVeh"
        Me.TipoVehBindingSource.DataSource = Me.datasetEOD
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colvehiculo})
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsCustomization.AllowFilter = False
        Me.GridView1.OptionsCustomization.AllowGroup = False
        Me.GridView1.OptionsCustomization.AllowSort = False
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowColumnHeaders = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.OptionsView.ShowIndicator = False
        '
        'colID
        '
        Me.colID.FieldName = "ID"
        Me.colID.Name = "colID"
        '
        'colvehiculo
        '
        Me.colvehiculo.FieldName = "vehiculo"
        Me.colvehiculo.Name = "colvehiculo"
        Me.colvehiculo.OptionsColumn.AllowEdit = False
        Me.colvehiculo.Visible = True
        Me.colvehiculo.VisibleIndex = 0
        '
        'lkpPropiedadVeh
        '
        Me.lkpPropiedadVeh.EditValue = ""
        Me.lkpPropiedadVeh.Location = New System.Drawing.Point(142, 55)
        Me.lkpPropiedadVeh.MenuManager = Me.RibbonControl
        Me.lkpPropiedadVeh.Name = "lkpPropiedadVeh"
        Me.lkpPropiedadVeh.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.lkpPropiedadVeh.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.lkpPropiedadVeh.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lkpPropiedadVeh.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkpPropiedadVeh.Properties.DataSource = Me.PropiedadVehiculoBindingSource
        Me.lkpPropiedadVeh.Properties.DisplayMember = "PropiedadVehiculo"
        Me.lkpPropiedadVeh.Properties.ImmediatePopup = True
        Me.lkpPropiedadVeh.Properties.PopupFormMinSize = New System.Drawing.Size(177, 40)
        Me.lkpPropiedadVeh.Properties.PopupFormSize = New System.Drawing.Size(177, 40)
        Me.lkpPropiedadVeh.Properties.ShowFooter = False
        Me.lkpPropiedadVeh.Properties.ValueMember = "ID"
        Me.lkpPropiedadVeh.Properties.View = Me.GridView4
        Me.lkpPropiedadVeh.Size = New System.Drawing.Size(177, 20)
        Me.lkpPropiedadVeh.TabIndex = 15
        '
        'PropiedadVehiculoBindingSource
        '
        Me.PropiedadVehiculoBindingSource.DataMember = "PropiedadVehiculo"
        Me.PropiedadVehiculoBindingSource.DataSource = Me.datasetEOD
        '
        'GridView4
        '
        Me.GridView4.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID3, Me.colPropiedadVehiculo})
        Me.GridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView4.Name = "GridView4"
        Me.GridView4.OptionsCustomization.AllowFilter = False
        Me.GridView4.OptionsCustomization.AllowGroup = False
        Me.GridView4.OptionsCustomization.AllowSort = False
        Me.GridView4.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView4.OptionsView.ShowColumnHeaders = False
        Me.GridView4.OptionsView.ShowGroupPanel = False
        Me.GridView4.OptionsView.ShowIndicator = False
        '
        'colID3
        '
        Me.colID3.FieldName = "ID"
        Me.colID3.Name = "colID3"
        '
        'colPropiedadVehiculo
        '
        Me.colPropiedadVehiculo.FieldName = "PropiedadVehiculo"
        Me.colPropiedadVehiculo.Name = "colPropiedadVehiculo"
        Me.colPropiedadVehiculo.OptionsColumn.AllowEdit = False
        Me.colPropiedadVehiculo.Visible = True
        Me.colPropiedadVehiculo.VisibleIndex = 0
        '
        'SiNoBindingSource
        '
        Me.SiNoBindingSource.DataMember = "SiNo"
        Me.SiNoBindingSource.DataSource = Me.datasetEOD
        Me.SiNoBindingSource.Filter = "id >0"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.txtCombustibleOtro)
        Me.GroupControl1.Controls.Add(Me.lblCombustibleOtro)
        Me.GroupControl1.Controls.Add(Me.lkpCombustible)
        Me.GroupControl1.Controls.Add(Me.LabelControl23)
        Me.GroupControl1.Controls.Add(Me.txtPropiedadVehOtro)
        Me.GroupControl1.Controls.Add(Me.lblPropiedadVehOtro)
        Me.GroupControl1.Controls.Add(Me.lkpPropiedadVeh)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.lkpTipoVeh)
        Me.GroupControl1.Location = New System.Drawing.Point(12, 38)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(495, 126)
        Me.GroupControl1.TabIndex = 17
        Me.GroupControl1.Text = "Datos generales del vehículo"
        '
        'txtCombustibleOtro
        '
        Me.txtCombustibleOtro.Location = New System.Drawing.Point(377, 81)
        Me.txtCombustibleOtro.MenuManager = Me.RibbonControl
        Me.txtCombustibleOtro.Name = "txtCombustibleOtro"
        Me.txtCombustibleOtro.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.txtCombustibleOtro.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.txtCombustibleOtro.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtCombustibleOtro.Size = New System.Drawing.Size(110, 20)
        Me.txtCombustibleOtro.TabIndex = 20
        Me.txtCombustibleOtro.Visible = False
        '
        'lblCombustibleOtro
        '
        Me.lblCombustibleOtro.Location = New System.Drawing.Point(349, 84)
        Me.lblCombustibleOtro.Name = "lblCombustibleOtro"
        Me.lblCombustibleOtro.Size = New System.Drawing.Size(22, 13)
        Me.lblCombustibleOtro.TabIndex = 21
        Me.lblCombustibleOtro.Text = "Otro"
        Me.lblCombustibleOtro.Visible = False
        '
        'lkpCombustible
        '
        Me.lkpCombustible.EditValue = ""
        Me.lkpCombustible.Location = New System.Drawing.Point(177, 81)
        Me.lkpCombustible.MenuManager = Me.RibbonControl
        Me.lkpCombustible.Name = "lkpCombustible"
        Me.lkpCombustible.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.lkpCombustible.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.lkpCombustible.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lkpCombustible.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkpCombustible.Properties.DataSource = Me.CombustibleBindingSource
        Me.lkpCombustible.Properties.DisplayMember = "Combustible"
        Me.lkpCombustible.Properties.ImmediatePopup = True
        Me.lkpCombustible.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.lkpCombustible.Properties.PopupFormMinSize = New System.Drawing.Size(144, 60)
        Me.lkpCombustible.Properties.PopupFormSize = New System.Drawing.Size(144, 60)
        Me.lkpCombustible.Properties.ShowFooter = False
        Me.lkpCombustible.Properties.ValueMember = "ID"
        Me.lkpCombustible.Properties.View = Me.GridView15
        Me.lkpCombustible.Size = New System.Drawing.Size(142, 20)
        Me.lkpCombustible.TabIndex = 18
        '
        'CombustibleBindingSource
        '
        Me.CombustibleBindingSource.DataMember = "Combustible"
        Me.CombustibleBindingSource.DataSource = Me.datasetEOD
        '
        'GridView15
        '
        Me.GridView15.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.colCombustible})
        Me.GridView15.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView15.Name = "GridView15"
        Me.GridView15.OptionsCustomization.AllowFilter = False
        Me.GridView15.OptionsCustomization.AllowGroup = False
        Me.GridView15.OptionsCustomization.AllowSort = False
        Me.GridView15.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView15.OptionsView.ShowColumnHeaders = False
        Me.GridView15.OptionsView.ShowGroupPanel = False
        Me.GridView15.OptionsView.ShowIndicator = False
        '
        'GridColumn1
        '
        Me.GridColumn1.FieldName = "ID"
        Me.GridColumn1.Name = "GridColumn1"
        '
        'colCombustible
        '
        Me.colCombustible.FieldName = "Combustible"
        Me.colCombustible.Name = "colCombustible"
        Me.colCombustible.Visible = True
        Me.colCombustible.VisibleIndex = 0
        '
        'LabelControl23
        '
        Me.LabelControl23.Location = New System.Drawing.Point(15, 84)
        Me.LabelControl23.Name = "LabelControl23"
        Me.LabelControl23.Size = New System.Drawing.Size(145, 13)
        Me.LabelControl23.TabIndex = 19
        Me.LabelControl23.Text = "¿Qué tipo de combustible usa?"
        '
        'txtPropiedadVehOtro
        '
        Me.txtPropiedadVehOtro.Location = New System.Drawing.Point(377, 55)
        Me.txtPropiedadVehOtro.MenuManager = Me.RibbonControl
        Me.txtPropiedadVehOtro.Name = "txtPropiedadVehOtro"
        Me.txtPropiedadVehOtro.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.txtPropiedadVehOtro.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.txtPropiedadVehOtro.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtPropiedadVehOtro.Size = New System.Drawing.Size(110, 20)
        Me.txtPropiedadVehOtro.TabIndex = 16
        Me.txtPropiedadVehOtro.Visible = False
        '
        'lblPropiedadVehOtro
        '
        Me.lblPropiedadVehOtro.Location = New System.Drawing.Point(349, 58)
        Me.lblPropiedadVehOtro.Name = "lblPropiedadVehOtro"
        Me.lblPropiedadVehOtro.Size = New System.Drawing.Size(22, 13)
        Me.lblPropiedadVehOtro.TabIndex = 17
        Me.lblPropiedadVehOtro.Text = "Otro"
        Me.lblPropiedadVehOtro.Visible = False
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
        Me.btnCancelar.Location = New System.Drawing.Point(422, 170)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(85, 28)
        Me.btnCancelar.TabIndex = 34
        Me.btnCancelar.Text = "Cancelar"
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
        Me.btnGuardar.Location = New System.Drawing.Point(331, 170)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(85, 28)
        Me.btnGuardar.TabIndex = 33
        Me.btnGuardar.Text = "Guardar"
        '
        'GridLookUpEdit1
        '
        Me.GridLookUpEdit1.Location = New System.Drawing.Point(-321, -70)
        Me.GridLookUpEdit1.MenuManager = Me.RibbonControl
        Me.GridLookUpEdit1.Name = "GridLookUpEdit1"
        Me.GridLookUpEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.GridLookUpEdit1.Properties.View = Me.GridView6
        Me.GridLookUpEdit1.Size = New System.Drawing.Size(94, 20)
        Me.GridLookUpEdit1.TabIndex = 32
        '
        'GridView6
        '
        Me.GridView6.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView6.Name = "GridView6"
        Me.GridView6.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView6.OptionsView.ShowGroupPanel = False
        '
        'TipoVehTableAdapter
        '
        Me.TipoVehTableAdapter.ClearBeforeFill = True
        '
        'SiNoTableAdapter
        '
        Me.SiNoTableAdapter.ClearBeforeFill = True
        '
        'PropiedadVehiculoTableAdapter
        '
        Me.PropiedadVehiculoTableAdapter.ClearBeforeFill = True
        '
        'VehiculoTableAdapter
        '
        Me.VehiculoTableAdapter.ClearBeforeFill = True
        '
        'cargaVehiculoBackground
        '
        '
        'SplashScreenManager1
        '
        Me.SplashScreenManager1.ClosingDelay = 500
        '
        'CombustibleTableAdapter
        '
        Me.CombustibleTableAdapter.ClearBeforeFill = True
        '
        'ModificarVehiculo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(518, 210)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.GridLookUpEdit1)
        Me.Controls.Add(Me.RibbonControl)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "ModificarVehiculo"
        Me.Ribbon = Me.RibbonControl
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modificar vehículo"
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VehBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.datasetEOD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkpTipoVeh.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TipoVehBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkpPropiedadVeh.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PropiedadVehiculoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SiNoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.txtCombustibleOtro.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkpCombustible.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CombustibleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPropiedadVehOtro.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lkpTipoVeh As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents lkpPropiedadVeh As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridLookUpEdit1 As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView6 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents datasetEOD As EOD.datasetEOD
    Friend WithEvents TipoVehBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TipoVehTableAdapter As EOD.datasetEODTableAdapters.TipoVehTableAdapter
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colvehiculo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SiNoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SiNoTableAdapter As EOD.datasetEODTableAdapters.SiNoTableAdapter
    Friend WithEvents PropiedadVehiculoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PropiedadVehiculoTableAdapter As EOD.datasetEODTableAdapters.PropiedadVehiculoTableAdapter
    Friend WithEvents colID3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPropiedadVehiculo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents VehBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VehiculoTableAdapter As EOD.datasetEODTableAdapters.VehiculoTableAdapter
    Friend WithEvents txtPropiedadVehOtro As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblPropiedadVehOtro As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cargaVehiculoBackground As System.ComponentModel.BackgroundWorker
    Friend WithEvents SplashScreenManager1 As DevExpress.XtraSplashScreen.SplashScreenManager
    Friend WithEvents txtCombustibleOtro As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblCombustibleOtro As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lkpCombustible As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView15 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCombustible As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl23 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents CombustibleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CombustibleTableAdapter As EOD.datasetEODTableAdapters.CombustibleTableAdapter


End Class
