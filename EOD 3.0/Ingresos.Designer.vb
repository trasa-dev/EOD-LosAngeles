<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ingresos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ingresos))
        Me.RibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.lkpTieneIngreso = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.TieneIngresosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.datasetEOD = New EOD.datasetEOD()
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colTieneIngresos = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SiNoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SiNoTableAdapter = New EOD.datasetEODTableAdapters.SiNoTableAdapter()
        Me.lblIngresoLiquido = New DevExpress.XtraEditors.LabelControl()
        Me.txtIngresoLiquido = New DevExpress.XtraEditors.TextEdit()
        Me.lblTramoIngreso = New DevExpress.XtraEditors.LabelControl()
        Me.lkpTramoIngreso = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.TramoIngresoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridLookUpEdit2View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colTramoIngreso = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TramoIngresoTableAdapter = New EOD.datasetEODTableAdapters.TramoIngresoTableAdapter()
        Me.btnCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnGuardarIngreso = New DevExpress.XtraEditors.SimpleButton()
        Me.TieneIngresosTableAdapter = New EOD.datasetEODTableAdapters.TieneIngresosTableAdapter()
        Me.chkNSNR = New DevExpress.XtraEditors.CheckEdit()
        Me.PersonaTableAdapter = New EOD.datasetEODTableAdapters.PersonaTableAdapter()
        Me.btnRechazoIngresos = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkpTieneIngreso.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TieneIngresosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.datasetEOD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SiNoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIngresoLiquido.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkpTramoIngreso.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TramoIngresoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit2View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkNSNR.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.RibbonControl.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide
        Me.RibbonControl.ShowQatLocationSelector = False
        Me.RibbonControl.ShowToolbarCustomizeItem = False
        Me.RibbonControl.Size = New System.Drawing.Size(725, 27)
        Me.RibbonControl.Toolbar.ShowCustomizeItem = False
        '
        'LabelControl1
        '
        Me.LabelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal
        Me.LabelControl1.Location = New System.Drawing.Point(12, 43)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(685, 26)
        Me.LabelControl1.TabIndex = 2
        Me.LabelControl1.Text = resources.GetString("LabelControl1.Text")
        '
        'lkpTieneIngreso
        '
        Me.lkpTieneIngreso.EditValue = ""
        Me.lkpTieneIngreso.Location = New System.Drawing.Point(12, 80)
        Me.lkpTieneIngreso.MenuManager = Me.RibbonControl
        Me.lkpTieneIngreso.Name = "lkpTieneIngreso"
        Me.lkpTieneIngreso.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.lkpTieneIngreso.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.lkpTieneIngreso.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lkpTieneIngreso.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkpTieneIngreso.Properties.DataSource = Me.TieneIngresosBindingSource
        Me.lkpTieneIngreso.Properties.DisplayMember = "TieneIngresos"
        Me.lkpTieneIngreso.Properties.PopupFormMinSize = New System.Drawing.Size(100, 60)
        Me.lkpTieneIngreso.Properties.PopupFormSize = New System.Drawing.Size(100, 60)
        Me.lkpTieneIngreso.Properties.ShowFooter = False
        Me.lkpTieneIngreso.Properties.ValueMember = "ID"
        Me.lkpTieneIngreso.Properties.View = Me.GridLookUpEdit1View
        Me.lkpTieneIngreso.Size = New System.Drawing.Size(100, 20)
        Me.lkpTieneIngreso.TabIndex = 1
        '
        'TieneIngresosBindingSource
        '
        Me.TieneIngresosBindingSource.DataMember = "TieneIngresos"
        Me.TieneIngresosBindingSource.DataSource = Me.datasetEOD
        Me.TieneIngresosBindingSource.Filter = "id > 0"
        '
        'datasetEOD
        '
        Me.datasetEOD.DataSetName = "datasetEOD"
        Me.datasetEOD.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colTieneIngresos})
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsCustomization.AllowFilter = False
        Me.GridLookUpEdit1View.OptionsCustomization.AllowGroup = False
        Me.GridLookUpEdit1View.OptionsCustomization.AllowSort = False
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowColumnHeaders = False
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        Me.GridLookUpEdit1View.OptionsView.ShowIndicator = False
        '
        'colTieneIngresos
        '
        Me.colTieneIngresos.FieldName = "TieneIngresos"
        Me.colTieneIngresos.Name = "colTieneIngresos"
        Me.colTieneIngresos.Visible = True
        Me.colTieneIngresos.VisibleIndex = 0
        '
        'SiNoBindingSource
        '
        Me.SiNoBindingSource.DataMember = "SiNo"
        Me.SiNoBindingSource.DataSource = Me.datasetEOD
        '
        'SiNoTableAdapter
        '
        Me.SiNoTableAdapter.ClearBeforeFill = True
        '
        'lblIngresoLiquido
        '
        Me.lblIngresoLiquido.Location = New System.Drawing.Point(135, 83)
        Me.lblIngresoLiquido.Name = "lblIngresoLiquido"
        Me.lblIngresoLiquido.Size = New System.Drawing.Size(258, 13)
        Me.lblIngresoLiquido.TabIndex = 4
        Me.lblIngresoLiquido.Text = "Monto líquido del ingreso personal mensual, en pesos:"
        Me.lblIngresoLiquido.Visible = False
        '
        'txtIngresoLiquido
        '
        Me.txtIngresoLiquido.Location = New System.Drawing.Point(408, 80)
        Me.txtIngresoLiquido.MenuManager = Me.RibbonControl
        Me.txtIngresoLiquido.Name = "txtIngresoLiquido"
        Me.txtIngresoLiquido.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.txtIngresoLiquido.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.txtIngresoLiquido.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtIngresoLiquido.Properties.Mask.EditMask = "c0"
        Me.txtIngresoLiquido.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtIngresoLiquido.Size = New System.Drawing.Size(140, 20)
        Me.txtIngresoLiquido.TabIndex = 2
        Me.txtIngresoLiquido.Visible = False
        '
        'lblTramoIngreso
        '
        Me.lblTramoIngreso.Location = New System.Drawing.Point(12, 113)
        Me.lblTramoIngreso.Name = "lblTramoIngreso"
        Me.lblTramoIngreso.Size = New System.Drawing.Size(667, 13)
        Me.lblTramoIngreso.TabIndex = 6
        Me.lblTramoIngreso.Text = "Aunque no pueda darnos un monto exacto, ¿nos podría decir aproximadamente en qué " &
    "rango se ubica su ingreso líquido mensual personal?"
        Me.lblTramoIngreso.Visible = False
        '
        'lkpTramoIngreso
        '
        Me.lkpTramoIngreso.EditValue = ""
        Me.lkpTramoIngreso.Location = New System.Drawing.Point(12, 132)
        Me.lkpTramoIngreso.MenuManager = Me.RibbonControl
        Me.lkpTramoIngreso.Name = "lkpTramoIngreso"
        Me.lkpTramoIngreso.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.lkpTramoIngreso.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.lkpTramoIngreso.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lkpTramoIngreso.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkpTramoIngreso.Properties.DataSource = Me.TramoIngresoBindingSource
        Me.lkpTramoIngreso.Properties.DisplayMember = "TramoIngreso"
        Me.lkpTramoIngreso.Properties.PopupFormMinSize = New System.Drawing.Size(250, 180)
        Me.lkpTramoIngreso.Properties.PopupFormSize = New System.Drawing.Size(250, 180)
        Me.lkpTramoIngreso.Properties.ShowFooter = False
        Me.lkpTramoIngreso.Properties.ValueMember = "ID"
        Me.lkpTramoIngreso.Properties.View = Me.GridLookUpEdit2View
        Me.lkpTramoIngreso.Size = New System.Drawing.Size(250, 20)
        Me.lkpTramoIngreso.TabIndex = 4
        Me.lkpTramoIngreso.Visible = False
        '
        'TramoIngresoBindingSource
        '
        Me.TramoIngresoBindingSource.DataMember = "TramoIngreso"
        Me.TramoIngresoBindingSource.DataSource = Me.datasetEOD
        '
        'GridLookUpEdit2View
        '
        Me.GridLookUpEdit2View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colTramoIngreso})
        Me.GridLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit2View.Name = "GridLookUpEdit2View"
        Me.GridLookUpEdit2View.OptionsCustomization.AllowFilter = False
        Me.GridLookUpEdit2View.OptionsCustomization.AllowGroup = False
        Me.GridLookUpEdit2View.OptionsCustomization.AllowSort = False
        Me.GridLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit2View.OptionsView.ShowColumnHeaders = False
        Me.GridLookUpEdit2View.OptionsView.ShowGroupPanel = False
        Me.GridLookUpEdit2View.OptionsView.ShowIndicator = False
        Me.GridLookUpEdit2View.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colTramoIngreso, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colTramoIngreso
        '
        Me.colTramoIngreso.FieldName = "TramoIngreso"
        Me.colTramoIngreso.Name = "colTramoIngreso"
        Me.colTramoIngreso.Visible = True
        Me.colTramoIngreso.VisibleIndex = 0
        '
        'TramoIngresoTableAdapter
        '
        Me.TramoIngresoTableAdapter.ClearBeforeFill = True
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
        Me.btnCancelar.Location = New System.Drawing.Point(612, 145)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(85, 28)
        Me.btnCancelar.TabIndex = 6
        Me.btnCancelar.Text = "Cancelar"
        '
        'btnGuardarIngreso
        '
        Me.btnGuardarIngreso.Appearance.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnGuardarIngreso.Appearance.BackColor2 = System.Drawing.SystemColors.HotTrack
        Me.btnGuardarIngreso.Appearance.BorderColor = System.Drawing.SystemColors.HotTrack
        Me.btnGuardarIngreso.Appearance.ForeColor = System.Drawing.Color.White
        Me.btnGuardarIngreso.Appearance.Options.UseBackColor = True
        Me.btnGuardarIngreso.Appearance.Options.UseBorderColor = True
        Me.btnGuardarIngreso.Appearance.Options.UseForeColor = True
        Me.btnGuardarIngreso.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
        Me.btnGuardarIngreso.Location = New System.Drawing.Point(521, 145)
        Me.btnGuardarIngreso.Name = "btnGuardarIngreso"
        Me.btnGuardarIngreso.Size = New System.Drawing.Size(85, 28)
        Me.btnGuardarIngreso.TabIndex = 5
        Me.btnGuardarIngreso.Text = "Guardar"
        '
        'TieneIngresosTableAdapter
        '
        Me.TieneIngresosTableAdapter.ClearBeforeFill = True
        '
        'chkNSNR
        '
        Me.chkNSNR.Location = New System.Drawing.Point(566, 80)
        Me.chkNSNR.MenuManager = Me.RibbonControl
        Me.chkNSNR.Name = "chkNSNR"
        Me.chkNSNR.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.chkNSNR.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.chkNSNR.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.chkNSNR.Properties.Caption = "No sabe / no responde"
        Me.chkNSNR.Size = New System.Drawing.Size(131, 21)
        Me.chkNSNR.TabIndex = 3
        Me.chkNSNR.Visible = False
        '
        'PersonaTableAdapter
        '
        Me.PersonaTableAdapter.ClearBeforeFill = True
        '
        'btnRechazoIngresos
        '
        Me.btnRechazoIngresos.Appearance.BackColor = System.Drawing.Color.Red
        Me.btnRechazoIngresos.Appearance.BackColor2 = System.Drawing.Color.DarkRed
        Me.btnRechazoIngresos.Appearance.BorderColor = System.Drawing.Color.DarkRed
        Me.btnRechazoIngresos.Appearance.ForeColor = System.Drawing.Color.White
        Me.btnRechazoIngresos.Appearance.Options.UseBackColor = True
        Me.btnRechazoIngresos.Appearance.Options.UseBorderColor = True
        Me.btnRechazoIngresos.Appearance.Options.UseForeColor = True
        Me.btnRechazoIngresos.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
        Me.btnRechazoIngresos.Location = New System.Drawing.Point(387, 145)
        Me.btnRechazoIngresos.Name = "btnRechazoIngresos"
        Me.btnRechazoIngresos.Size = New System.Drawing.Size(128, 28)
        Me.btnRechazoIngresos.TabIndex = 106
        Me.btnRechazoIngresos.Text = "Rechazar encuesta"
        '
        'Ingresos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(725, 193)
        Me.Controls.Add(Me.btnRechazoIngresos)
        Me.Controls.Add(Me.chkNSNR)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnGuardarIngreso)
        Me.Controls.Add(Me.lkpTramoIngreso)
        Me.Controls.Add(Me.lblTramoIngreso)
        Me.Controls.Add(Me.txtIngresoLiquido)
        Me.Controls.Add(Me.lblIngresoLiquido)
        Me.Controls.Add(Me.lkpTieneIngreso)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.RibbonControl)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Ingresos"
        Me.Ribbon = Me.RibbonControl
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ingresos"
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkpTieneIngreso.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TieneIngresosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.datasetEOD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SiNoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIngresoLiquido.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkpTramoIngreso.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TramoIngresoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit2View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkNSNR.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lkpTieneIngreso As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents datasetEOD As EOD.datasetEOD
    Friend WithEvents SiNoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SiNoTableAdapter As EOD.datasetEODTableAdapters.SiNoTableAdapter
    Friend WithEvents lblIngresoLiquido As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtIngresoLiquido As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblTramoIngreso As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lkpTramoIngreso As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit2View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents TramoIngresoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TramoIngresoTableAdapter As EOD.datasetEODTableAdapters.TramoIngresoTableAdapter
    Friend WithEvents btnCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnGuardarIngreso As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TieneIngresosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TieneIngresosTableAdapter As EOD.datasetEODTableAdapters.TieneIngresosTableAdapter
    Friend WithEvents colTieneIngresos As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTramoIngreso As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents chkNSNR As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents PersonaTableAdapter As EOD.datasetEODTableAdapters.PersonaTableAdapter
    Friend WithEvents btnRechazoIngresos As DevExpress.XtraEditors.SimpleButton


End Class
