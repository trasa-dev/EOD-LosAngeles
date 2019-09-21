<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TipoViaje
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
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.selTipoDia = New DevExpress.XtraEditors.RadioGroup()
        Me.btnIngresarViajes = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.datasetEOD = New EOD.datasetEOD()
        Me.PersonaTableAdapter = New EOD.datasetEODTableAdapters.PersonaTableAdapter()
        Me.HogarBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HogarTableAdapter = New EOD.datasetEODTableAdapters.HogarTableAdapter()
        Me.PersonaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtNombre = New DevExpress.XtraEditors.LabelControl()
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.selTipoDia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.datasetEOD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HogarBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PersonaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonControl
        '
        Me.RibbonControl.ExpandCollapseItem.Id = 0
        Me.RibbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl.ExpandCollapseItem})
        Me.RibbonControl.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl.MaxItemId = 1
        Me.RibbonControl.Name = "RibbonControl"
        Me.RibbonControl.Size = New System.Drawing.Size(309, 32)
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(12, 75)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(284, 26)
        Me.LabelControl2.TabIndex = 4
        Me.LabelControl2.Text = "Escoja el día al que pertenecen los viajes que va a reportar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "a continuación:"
        '
        'selTipoDia
        '
        Me.selTipoDia.Location = New System.Drawing.Point(12, 107)
        Me.selTipoDia.MenuManager = Me.RibbonControl
        Me.selTipoDia.Name = "selTipoDia"
        Me.selTipoDia.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.selTipoDia.Properties.Appearance.Options.UseBackColor = True
        Me.selTipoDia.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.selTipoDia.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(CType(1, Short), "Laboral"), New DevExpress.XtraEditors.Controls.RadioGroupItem(CType(2, Short), "Sábado"), New DevExpress.XtraEditors.Controls.RadioGroupItem(CType(3, Short), "Domingo")})
        Me.selTipoDia.Size = New System.Drawing.Size(275, 31)
        Me.selTipoDia.TabIndex = 5
        '
        'btnIngresarViajes
        '
        Me.btnIngresarViajes.Appearance.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnIngresarViajes.Appearance.ForeColor = System.Drawing.Color.White
        Me.btnIngresarViajes.Appearance.Options.UseBackColor = True
        Me.btnIngresarViajes.Appearance.Options.UseForeColor = True
        Me.btnIngresarViajes.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
        Me.btnIngresarViajes.Location = New System.Drawing.Point(202, 144)
        Me.btnIngresarViajes.LookAndFeel.SkinMaskColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnIngresarViajes.Name = "btnIngresarViajes"
        Me.btnIngresarViajes.Size = New System.Drawing.Size(94, 30)
        Me.btnIngresarViajes.TabIndex = 47
        Me.btnIngresarViajes.Text = "Ingresar viajes"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(12, 47)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(179, 13)
        Me.LabelControl1.TabIndex = 49
        Me.LabelControl1.Text = "Está ingresando el Libro de Viajes de:"
        '
        'datasetEOD
        '
        Me.datasetEOD.DataSetName = "datasetEOD"
        Me.datasetEOD.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PersonaTableAdapter
        '
        Me.PersonaTableAdapter.ClearBeforeFill = True
        '
        'HogarBindingSource
        '
        Me.HogarBindingSource.DataMember = "Hogar"
        Me.HogarBindingSource.DataSource = Me.datasetEOD
        '
        'HogarTableAdapter
        '
        Me.HogarTableAdapter.ClearBeforeFill = True
        '
        'PersonaBindingSource
        '
        Me.PersonaBindingSource.DataMember = "Persona"
        Me.PersonaBindingSource.DataSource = Me.datasetEOD
        '
        'txtNombre
        '
        Me.txtNombre.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold
        Me.txtNombre.Appearance.Options.UseFont = True
        Me.txtNombre.Location = New System.Drawing.Point(197, 47)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(64, 13)
        Me.txtNombre.TabIndex = 51
        Me.txtNombre.Text = "NombrePila"
        '
        'TipoViaje
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(309, 187)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.btnIngresarViajes)
        Me.Controls.Add(Me.selTipoDia)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.RibbonControl)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "TipoViaje"
        Me.Ribbon = Me.RibbonControl
        Me.RibbonAlwaysAtBack = False
        Me.RibbonVisibility = DevExpress.XtraBars.Ribbon.RibbonVisibility.Hidden
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Libro de Viajes"
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.selTipoDia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.datasetEOD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HogarBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PersonaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents selTipoDia As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents btnIngresarViajes As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents datasetEOD As EOD.datasetEOD
    Friend WithEvents PersonaTableAdapter As EOD.datasetEODTableAdapters.PersonaTableAdapter
    Friend WithEvents HogarBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents HogarTableAdapter As EOD.datasetEODTableAdapters.HogarTableAdapter
    Friend WithEvents PersonaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents txtNombre As DevExpress.XtraEditors.LabelControl



End Class
