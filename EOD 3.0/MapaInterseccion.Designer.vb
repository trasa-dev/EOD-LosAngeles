<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MapaInterseccion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MapaInterseccion))
        Me.RibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.imagenMapa = New DevExpress.XtraEditors.PictureEdit()
        Me.lblTexto = New DevExpress.XtraEditors.LabelControl()
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imagenMapa.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.RibbonControl.Size = New System.Drawing.Size(845, 27)
        '
        'imagenMapa
        '
        Me.imagenMapa.Cursor = System.Windows.Forms.Cursors.Default
        Me.imagenMapa.Location = New System.Drawing.Point(22, 79)
        Me.imagenMapa.MenuManager = Me.RibbonControl
        Me.imagenMapa.Name = "imagenMapa"
        Me.imagenMapa.Properties.InitialImage = Nothing
        Me.imagenMapa.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.imagenMapa.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.imagenMapa.Properties.ZoomAccelerationFactor = 1.0R
        Me.imagenMapa.Size = New System.Drawing.Size(800, 450)
        Me.imagenMapa.TabIndex = 4
        '
        'lblTexto
        '
        Me.lblTexto.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold
        Me.lblTexto.Appearance.Options.UseFont = True
        Me.lblTexto.Location = New System.Drawing.Point(22, 43)
        Me.lblTexto.Name = "lblTexto"
        Me.lblTexto.Size = New System.Drawing.Size(792, 26)
        Me.lblTexto.TabIndex = 5
        Me.lblTexto.Text = resources.GetString("lblTexto.Text")
        '
        'MapaInterseccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(845, 539)
        Me.Controls.Add(Me.lblTexto)
        Me.Controls.Add(Me.imagenMapa)
        Me.Controls.Add(Me.RibbonControl)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MapaInterseccion"
        Me.Ribbon = Me.RibbonControl
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mapa Intersección"
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imagenMapa.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents imagenMapa As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents lblTexto As DevExpress.XtraEditors.LabelControl


End Class
