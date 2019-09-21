<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CopiarViajes
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
        Me.RibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.lkpPersonaOrigen = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.PersonaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.datasetEOD = New EOD.datasetEOD()
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colNombrePila = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCopiar = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.selTipoDia = New DevExpress.XtraEditors.RadioGroup()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.PersonaTableAdapter = New EOD.datasetEODTableAdapters.PersonaTableAdapter()
        Me.EtapaTableAdapter = New EOD.datasetEODTableAdapters.EtapaTableAdapter()
        Me.ViajeTableAdapter = New EOD.datasetEODTableAdapters.ViajeTableAdapter()
        Me.ValidaEtapaTableAdapter = New EOD.datasetEODTableAdapters.ValidaEtapaTableAdapter()
        Me.ValidaViajeTableAdapter = New EOD.datasetEODTableAdapters.ValidaViajeTableAdapter()
        Me.barraProg = New DevExpress.XtraEditors.MarqueeProgressBarControl()
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkpPersonaOrigen.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PersonaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.datasetEOD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.selTipoDia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.barraProg.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonControl
        '
        Me.RibbonControl.ExpandCollapseItem.Id = 0
        Me.RibbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl.ExpandCollapseItem})
        Me.RibbonControl.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl.MaxItemId = 1
        Me.RibbonControl.Name = "RibbonControl"
        Me.RibbonControl.Size = New System.Drawing.Size(457, 32)
        '
        'lkpPersonaOrigen
        '
        Me.lkpPersonaOrigen.EditValue = ""
        Me.lkpPersonaOrigen.Location = New System.Drawing.Point(220, 51)
        Me.lkpPersonaOrigen.MenuManager = Me.RibbonControl
        Me.lkpPersonaOrigen.Name = "lkpPersonaOrigen"
        Me.lkpPersonaOrigen.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkpPersonaOrigen.Properties.DataSource = Me.PersonaBindingSource
        Me.lkpPersonaOrigen.Properties.DisplayMember = "NombrePila"
        Me.lkpPersonaOrigen.Properties.ShowFooter = False
        Me.lkpPersonaOrigen.Properties.ValueMember = "Persona"
        Me.lkpPersonaOrigen.Properties.View = Me.GridLookUpEdit1View
        Me.lkpPersonaOrigen.Size = New System.Drawing.Size(202, 20)
        Me.lkpPersonaOrigen.TabIndex = 2
        '
        'PersonaBindingSource
        '
        Me.PersonaBindingSource.DataMember = "Persona"
        Me.PersonaBindingSource.DataSource = Me.datasetEOD
        '
        'datasetEOD
        '
        Me.datasetEOD.DataSetName = "datasetEOD"
        Me.datasetEOD.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colNombrePila})
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsCustomization.AllowGroup = False
        Me.GridLookUpEdit1View.OptionsCustomization.AllowSort = False
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colNombrePila
        '
        Me.colNombrePila.FieldName = "NombrePila"
        Me.colNombrePila.Name = "colNombrePila"
        Me.colNombrePila.OptionsColumn.AllowEdit = False
        Me.colNombrePila.Visible = True
        Me.colNombrePila.VisibleIndex = 0
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
        Me.btnCancelar.Location = New System.Drawing.Point(336, 153)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(85, 28)
        Me.btnCancelar.TabIndex = 36
        Me.btnCancelar.Text = "Cancelar"
        '
        'btnCopiar
        '
        Me.btnCopiar.Appearance.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnCopiar.Appearance.BackColor2 = System.Drawing.SystemColors.HotTrack
        Me.btnCopiar.Appearance.BorderColor = System.Drawing.SystemColors.HotTrack
        Me.btnCopiar.Appearance.ForeColor = System.Drawing.Color.White
        Me.btnCopiar.Appearance.Options.UseBackColor = True
        Me.btnCopiar.Appearance.Options.UseBorderColor = True
        Me.btnCopiar.Appearance.Options.UseForeColor = True
        Me.btnCopiar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
        Me.btnCopiar.Location = New System.Drawing.Point(245, 153)
        Me.btnCopiar.Name = "btnCopiar"
        Me.btnCopiar.Size = New System.Drawing.Size(85, 28)
        Me.btnCopiar.TabIndex = 35
        Me.btnCopiar.Text = "Copiar"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(12, 54)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(192, 13)
        Me.LabelControl1.TabIndex = 37
        Me.LabelControl1.Text = "¿Quién hizo los viajes que desea copiar?"
        '
        'selTipoDia
        '
        Me.selTipoDia.Enabled = False
        Me.selTipoDia.Location = New System.Drawing.Point(220, 77)
        Me.selTipoDia.MenuManager = Me.RibbonControl
        Me.selTipoDia.Name = "selTipoDia"
        Me.selTipoDia.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.selTipoDia.Properties.Appearance.Options.UseBackColor = True
        Me.selTipoDia.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.selTipoDia.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(CType(1, Short), "Laboral"), New DevExpress.XtraEditors.Controls.RadioGroupItem(CType(2, Short), "Sábado"), New DevExpress.XtraEditors.Controls.RadioGroupItem(CType(3, Short), "Domingo")})
        Me.selTipoDia.Size = New System.Drawing.Size(202, 31)
        Me.selTipoDia.TabIndex = 39
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(12, 86)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(164, 13)
        Me.LabelControl2.TabIndex = 38
        Me.LabelControl2.Text = "¿De qué día va a copiar los viajes?"
        '
        'PersonaTableAdapter
        '
        Me.PersonaTableAdapter.ClearBeforeFill = True
        '
        'EtapaTableAdapter
        '
        Me.EtapaTableAdapter.ClearBeforeFill = True
        '
        'ViajeTableAdapter
        '
        Me.ViajeTableAdapter.ClearBeforeFill = True
        '
        'ValidaEtapaTableAdapter
        '
        Me.ValidaEtapaTableAdapter.ClearBeforeFill = True
        '
        'ValidaViajeTableAdapter
        '
        Me.ValidaViajeTableAdapter.ClearBeforeFill = True
        '
        'barraProg
        '
        Me.barraProg.EditValue = 0
        Me.barraProg.Location = New System.Drawing.Point(12, 119)
        Me.barraProg.MenuManager = Me.RibbonControl
        Me.barraProg.Name = "barraProg"
        Me.barraProg.Size = New System.Drawing.Size(410, 18)
        Me.barraProg.TabIndex = 40
        Me.barraProg.Visible = False
        '
        'CopiarViajes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(457, 205)
        Me.Controls.Add(Me.barraProg)
        Me.Controls.Add(Me.selTipoDia)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnCopiar)
        Me.Controls.Add(Me.lkpPersonaOrigen)
        Me.Controls.Add(Me.RibbonControl)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CopiarViajes"
        Me.Ribbon = Me.RibbonControl
        Me.RibbonVisibility = DevExpress.XtraBars.Ribbon.RibbonVisibility.Hidden
        Me.Text = "Copiar Viajes"
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkpPersonaOrigen.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PersonaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.datasetEOD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.selTipoDia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.barraProg.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents lkpPersonaOrigen As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btnCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCopiar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents selTipoDia As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents datasetEOD As EOD.datasetEOD
    Friend WithEvents PersonaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PersonaTableAdapter As EOD.datasetEODTableAdapters.PersonaTableAdapter
    Friend WithEvents EtapaTableAdapter As EOD.datasetEODTableAdapters.EtapaTableAdapter
    Friend WithEvents ViajeTableAdapter As EOD.datasetEODTableAdapters.ViajeTableAdapter
    Friend WithEvents ValidaEtapaTableAdapter As EOD.datasetEODTableAdapters.ValidaEtapaTableAdapter
    Friend WithEvents ValidaViajeTableAdapter As EOD.datasetEODTableAdapters.ValidaViajeTableAdapter
    Friend WithEvents colNombrePila As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents barraProg As DevExpress.XtraEditors.MarqueeProgressBarControl


End Class
