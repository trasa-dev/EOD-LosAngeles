<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SubirDatos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SubirDatos))
        Me.RibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.barraProg = New DevExpress.XtraEditors.ProgressBarControl()
        Me.label = New DevExpress.XtraEditors.LabelControl()
        Me.bw = New System.ComponentModel.BackgroundWorker()
        Me.ExportacionesDataTableAdapter = New EOD.datasetEODTableAdapters.ExportacionesDataTableAdapter()
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.RibbonControl.Size = New System.Drawing.Size(552, 32)
        '
        'barraProg
        '
        Me.barraProg.Location = New System.Drawing.Point(12, 87)
        Me.barraProg.MenuManager = Me.RibbonControl
        Me.barraProg.Name = "barraProg"
        Me.barraProg.Size = New System.Drawing.Size(520, 28)
        Me.barraProg.TabIndex = 2
        '
        'label
        '
        Me.label.Location = New System.Drawing.Point(12, 56)
        Me.label.Name = "label"
        Me.label.Size = New System.Drawing.Size(142, 13)
        Me.label.TabIndex = 3
        Me.label.Text = "Estado de la carga al servidor"
        '
        'bw
        '
        '
        'ExportacionesDataTableAdapter
        '
        Me.ExportacionesDataTableAdapter.ClearBeforeFill = True
        '
        'SubirDatos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(552, 139)
        Me.Controls.Add(Me.label)
        Me.Controls.Add(Me.barraProg)
        Me.Controls.Add(Me.RibbonControl)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SubirDatos"
        Me.Ribbon = Me.RibbonControl
        Me.RibbonAlwaysAtBack = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Subir datos al servidor"
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.barraProg.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents barraProg As DevExpress.XtraEditors.ProgressBarControl
    Friend WithEvents label As DevExpress.XtraEditors.LabelControl
    Friend WithEvents bw As System.ComponentModel.BackgroundWorker
    Friend WithEvents ExportacionesDataTableAdapter As EOD.datasetEODTableAdapters.ExportacionesDataTableAdapter


End Class
