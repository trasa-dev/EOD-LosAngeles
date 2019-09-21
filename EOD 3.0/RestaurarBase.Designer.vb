<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RestaurarBase
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RestaurarBase))
        Me.RibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.barraProg = New DevExpress.XtraEditors.ProgressBarControl()
        Me.btnCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.lblProgreso = New DevExpress.XtraEditors.LabelControl()
        Me.label1 = New System.Windows.Forms.Label()
        Me.bw = New System.ComponentModel.BackgroundWorker()
        Me.ExportacionesDataTableAdapter = New EOD.datasetEODTableAdapters.ExportacionesDataTableAdapter()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.imgError = New DevExpress.XtraEditors.PictureEdit()
        Me.img5 = New DevExpress.XtraEditors.PictureEdit()
        Me.img4 = New DevExpress.XtraEditors.PictureEdit()
        Me.img3 = New DevExpress.XtraEditors.PictureEdit()
        Me.img2 = New DevExpress.XtraEditors.PictureEdit()
        Me.lblError = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.img1 = New DevExpress.XtraEditors.PictureEdit()
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.barraProg.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.imgError.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.img5.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.img4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.img3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.img2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.img1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.RibbonControl.Size = New System.Drawing.Size(301, 32)
        Me.RibbonControl.Toolbar.ShowCustomizeItem = False
        '
        'barraProg
        '
        Me.barraProg.Location = New System.Drawing.Point(12, 280)
        Me.barraProg.MenuManager = Me.RibbonControl
        Me.barraProg.Name = "barraProg"
        Me.barraProg.Size = New System.Drawing.Size(277, 30)
        Me.barraProg.TabIndex = 4
        '
        'btnCancelar
        '
        Me.btnCancelar.Appearance.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnCancelar.Appearance.BackColor2 = System.Drawing.SystemColors.HotTrack
        Me.btnCancelar.Appearance.ForeColor = System.Drawing.Color.White
        Me.btnCancelar.Appearance.Options.UseBackColor = True
        Me.btnCancelar.Appearance.Options.UseForeColor = True
        Me.btnCancelar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
        Me.btnCancelar.Location = New System.Drawing.Point(204, 316)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(85, 28)
        Me.btnCancelar.TabIndex = 9
        Me.btnCancelar.Text = "Cancelar"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(12, 62)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(110, 13)
        Me.LabelControl1.TabIndex = 10
        Me.LabelControl1.Text = "Actualización en curso:"
        '
        'lblProgreso
        '
        Me.lblProgreso.Location = New System.Drawing.Point(12, 261)
        Me.lblProgreso.Name = "lblProgreso"
        Me.lblProgreso.Size = New System.Drawing.Size(102, 13)
        Me.lblProgreso.TabIndex = 11
        Me.lblProgreso.Text = "Progreso de la tarea:"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(37, 14)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(146, 13)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Preparando base de datos..."
        '
        'bw
        '
        '
        'ExportacionesDataTableAdapter
        '
        Me.ExportacionesDataTableAdapter.ClearBeforeFill = True
        '
        'PanelControl1
        '
        Me.PanelControl1.Appearance.BackColor = System.Drawing.Color.White
        Me.PanelControl1.Appearance.Options.UseBackColor = True
        Me.PanelControl1.Controls.Add(Me.imgError)
        Me.PanelControl1.Controls.Add(Me.img5)
        Me.PanelControl1.Controls.Add(Me.img4)
        Me.PanelControl1.Controls.Add(Me.img3)
        Me.PanelControl1.Controls.Add(Me.img2)
        Me.PanelControl1.Controls.Add(Me.lblError)
        Me.PanelControl1.Controls.Add(Me.label5)
        Me.PanelControl1.Controls.Add(Me.label4)
        Me.PanelControl1.Controls.Add(Me.label3)
        Me.PanelControl1.Controls.Add(Me.label2)
        Me.PanelControl1.Controls.Add(Me.img1)
        Me.PanelControl1.Controls.Add(Me.label1)
        Me.PanelControl1.Location = New System.Drawing.Point(12, 81)
        Me.PanelControl1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.PanelControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(277, 174)
        Me.PanelControl1.TabIndex = 14
        '
        'imgError
        '
        Me.imgError.EditValue = CType(resources.GetObject("imgError.EditValue"), Object)
        Me.imgError.Location = New System.Drawing.Point(6, 141)
        Me.imgError.MenuManager = Me.RibbonControl
        Me.imgError.Name = "imgError"
        Me.imgError.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.imgError.Properties.Appearance.Options.UseBackColor = True
        Me.imgError.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.imgError.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.imgError.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
        Me.imgError.Size = New System.Drawing.Size(25, 20)
        Me.imgError.TabIndex = 21
        Me.imgError.Visible = False
        '
        'img5
        '
        Me.img5.EditValue = CType(resources.GetObject("img5.EditValue"), Object)
        Me.img5.Location = New System.Drawing.Point(6, 115)
        Me.img5.MenuManager = Me.RibbonControl
        Me.img5.Name = "img5"
        Me.img5.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.img5.Properties.Appearance.Options.UseBackColor = True
        Me.img5.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.img5.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.img5.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
        Me.img5.Size = New System.Drawing.Size(25, 20)
        Me.img5.TabIndex = 18
        Me.img5.Visible = False
        '
        'img4
        '
        Me.img4.EditValue = CType(resources.GetObject("img4.EditValue"), Object)
        Me.img4.Location = New System.Drawing.Point(6, 89)
        Me.img4.MenuManager = Me.RibbonControl
        Me.img4.Name = "img4"
        Me.img4.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.img4.Properties.Appearance.Options.UseBackColor = True
        Me.img4.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.img4.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.img4.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
        Me.img4.Size = New System.Drawing.Size(25, 20)
        Me.img4.TabIndex = 17
        Me.img4.Visible = False
        '
        'img3
        '
        Me.img3.EditValue = CType(resources.GetObject("img3.EditValue"), Object)
        Me.img3.Location = New System.Drawing.Point(6, 63)
        Me.img3.MenuManager = Me.RibbonControl
        Me.img3.Name = "img3"
        Me.img3.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.img3.Properties.Appearance.Options.UseBackColor = True
        Me.img3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.img3.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.img3.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
        Me.img3.Size = New System.Drawing.Size(25, 20)
        Me.img3.TabIndex = 16
        Me.img3.Visible = False
        '
        'img2
        '
        Me.img2.EditValue = CType(resources.GetObject("img2.EditValue"), Object)
        Me.img2.Location = New System.Drawing.Point(6, 37)
        Me.img2.MenuManager = Me.RibbonControl
        Me.img2.Name = "img2"
        Me.img2.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.img2.Properties.Appearance.Options.UseBackColor = True
        Me.img2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.img2.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.img2.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
        Me.img2.Size = New System.Drawing.Size(25, 20)
        Me.img2.TabIndex = 15
        Me.img2.Visible = False
        '
        'lblError
        '
        Me.lblError.AutoSize = True
        Me.lblError.Location = New System.Drawing.Point(37, 144)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(42, 13)
        Me.lblError.TabIndex = 14
        Me.lblError.Text = "ERROR"
        Me.lblError.Visible = False
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(37, 118)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(132, 13)
        Me.label5.TabIndex = 8
        Me.label5.Text = "Restauración completada."
        Me.label5.Visible = False
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(37, 92)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(161, 13)
        Me.label4.TabIndex = 6
        Me.label4.Text = "Restaurando tablas históricas..."
        Me.label4.Visible = False
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(37, 66)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(178, 13)
        Me.label3.TabIndex = 4
        Me.label3.Text = "Restaurando tablas de validación..."
        Me.label3.Visible = False
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(37, 40)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(174, 13)
        Me.label2.TabIndex = 2
        Me.label2.Text = "Restaurando base de encuestas..."
        Me.label2.Visible = False
        '
        'img1
        '
        Me.img1.EditValue = CType(resources.GetObject("img1.EditValue"), Object)
        Me.img1.Location = New System.Drawing.Point(6, 11)
        Me.img1.MenuManager = Me.RibbonControl
        Me.img1.Name = "img1"
        Me.img1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.img1.Properties.Appearance.Options.UseBackColor = True
        Me.img1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.img1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.img1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
        Me.img1.Size = New System.Drawing.Size(25, 20)
        Me.img1.TabIndex = 1
        '
        'RestaurarBase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(301, 356)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.lblProgreso)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.barraProg)
        Me.Controls.Add(Me.RibbonControl)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "RestaurarBase"
        Me.Ribbon = Me.RibbonControl
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Restaurando base de datos"
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.barraProg.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.imgError.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.img5.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.img4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.img3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.img2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.img1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents barraProg As DevExpress.XtraEditors.ProgressBarControl
    Friend WithEvents btnCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblProgreso As DevExpress.XtraEditors.LabelControl
    Friend WithEvents bw As System.ComponentModel.BackgroundWorker
    Friend WithEvents ExportacionesDataTableAdapter As EOD.datasetEODTableAdapters.ExportacionesDataTableAdapter
    Friend WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents img1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents lblError As System.Windows.Forms.Label
    Friend WithEvents label5 As System.Windows.Forms.Label
    Friend WithEvents label4 As System.Windows.Forms.Label
    Friend WithEvents label3 As System.Windows.Forms.Label
    Friend WithEvents label2 As System.Windows.Forms.Label
    Friend WithEvents imgError As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents img5 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents img4 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents img3 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents img2 As DevExpress.XtraEditors.PictureEdit


End Class
