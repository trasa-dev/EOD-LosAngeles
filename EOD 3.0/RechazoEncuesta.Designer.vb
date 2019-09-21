<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RechazoEncuesta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RechazoEncuesta))
        Me.RibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.txtClave = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnRechazar = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.lblFolio = New DevExpress.XtraEditors.LabelControl()
        Me.lblCalle = New DevExpress.XtraEditors.LabelControl()
        Me.lblCasaDepto = New DevExpress.XtraEditors.LabelControl()
        Me.lblNumero = New DevExpress.XtraEditors.LabelControl()
        Me.lblZona = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.lblManzana = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.HogarTableAdapter = New EOD.datasetEODTableAdapters.HogarTableAdapter()
        Me.UsuarioTableAdapter = New EOD.datasetEODTableAdapters.UsuarioTableAdapter()
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtClave.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.RibbonControl.Size = New System.Drawing.Size(456, 32)
        Me.RibbonControl.Toolbar.ShowCustomizeItem = False
        '
        'txtClave
        '
        Me.txtClave.Location = New System.Drawing.Point(315, 128)
        Me.txtClave.MenuManager = Me.RibbonControl
        Me.txtClave.Name = "txtClave"
        Me.txtClave.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtClave.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtClave.Size = New System.Drawing.Size(128, 20)
        Me.txtClave.TabIndex = 2
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(12, 47)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(431, 13)
        Me.LabelControl1.TabIndex = 3
        Me.LabelControl1.Text = "Ha indicado que el siguiente hogar ha rechazado participar en la Encuesta Origen " & _
    "Destino:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 131)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(300, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Para confirmar, ingrese su contraseña en el siguiente campo:"
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
        Me.btnCancelar.Location = New System.Drawing.Point(358, 166)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(85, 28)
        Me.btnCancelar.TabIndex = 20
        Me.btnCancelar.Text = "Cancelar"
        '
        'btnRechazar
        '
        Me.btnRechazar.Appearance.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnRechazar.Appearance.BackColor2 = System.Drawing.SystemColors.HotTrack
        Me.btnRechazar.Appearance.BorderColor = System.Drawing.SystemColors.HotTrack
        Me.btnRechazar.Appearance.ForeColor = System.Drawing.Color.White
        Me.btnRechazar.Appearance.Options.UseBackColor = True
        Me.btnRechazar.Appearance.Options.UseBorderColor = True
        Me.btnRechazar.Appearance.Options.UseForeColor = True
        Me.btnRechazar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
        Me.btnRechazar.Location = New System.Drawing.Point(267, 166)
        Me.btnRechazar.Name = "btnRechazar"
        Me.btnRechazar.Size = New System.Drawing.Size(85, 28)
        Me.btnRechazar.TabIndex = 19
        Me.btnRechazar.Text = "Aceptar"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(12, 77)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(26, 13)
        Me.LabelControl2.TabIndex = 21
        Me.LabelControl2.Text = "Folio:"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(12, 96)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(27, 13)
        Me.LabelControl3.TabIndex = 22
        Me.LabelControl3.Text = "Calle:"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(185, 96)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(41, 13)
        Me.LabelControl4.TabIndex = 23
        Me.LabelControl4.Text = "Número:"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(296, 96)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(60, 13)
        Me.LabelControl5.TabIndex = 24
        Me.LabelControl5.Text = "Casa/depto:"
        '
        'lblFolio
        '
        Me.lblFolio.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblFolio.Location = New System.Drawing.Point(49, 77)
        Me.lblFolio.Name = "lblFolio"
        Me.lblFolio.Size = New System.Drawing.Size(35, 13)
        Me.lblFolio.TabIndex = 25
        Me.lblFolio.Text = "TEXTO"
        '
        'lblCalle
        '
        Me.lblCalle.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblCalle.Location = New System.Drawing.Point(49, 96)
        Me.lblCalle.Name = "lblCalle"
        Me.lblCalle.Size = New System.Drawing.Size(35, 13)
        Me.lblCalle.TabIndex = 26
        Me.lblCalle.Text = "TEXTO"
        '
        'lblCasaDepto
        '
        Me.lblCasaDepto.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblCasaDepto.Location = New System.Drawing.Point(362, 96)
        Me.lblCasaDepto.Name = "lblCasaDepto"
        Me.lblCasaDepto.Size = New System.Drawing.Size(35, 13)
        Me.lblCasaDepto.TabIndex = 27
        Me.lblCasaDepto.Text = "TEXTO"
        '
        'lblNumero
        '
        Me.lblNumero.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblNumero.Location = New System.Drawing.Point(232, 96)
        Me.lblNumero.Name = "lblNumero"
        Me.lblNumero.Size = New System.Drawing.Size(35, 13)
        Me.lblNumero.TabIndex = 28
        Me.lblNumero.Text = "TEXTO"
        '
        'lblZona
        '
        Me.lblZona.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblZona.Location = New System.Drawing.Point(232, 77)
        Me.lblZona.Name = "lblZona"
        Me.lblZona.Size = New System.Drawing.Size(35, 13)
        Me.lblZona.TabIndex = 30
        Me.lblZona.Text = "TEXTO"
        '
        'LabelControl11
        '
        Me.LabelControl11.Location = New System.Drawing.Point(185, 77)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(28, 13)
        Me.LabelControl11.TabIndex = 29
        Me.LabelControl11.Text = "Zona:"
        '
        'lblManzana
        '
        Me.lblManzana.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblManzana.Location = New System.Drawing.Point(362, 77)
        Me.lblManzana.Name = "lblManzana"
        Me.lblManzana.Size = New System.Drawing.Size(35, 13)
        Me.lblManzana.TabIndex = 32
        Me.lblManzana.Text = "TEXTO"
        '
        'LabelControl13
        '
        Me.LabelControl13.Location = New System.Drawing.Point(296, 77)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(47, 13)
        Me.LabelControl13.TabIndex = 31
        Me.LabelControl13.Text = "Manzana:"
        '
        'HogarTableAdapter
        '
        Me.HogarTableAdapter.ClearBeforeFill = True
        '
        'UsuarioTableAdapter
        '
        Me.UsuarioTableAdapter.ClearBeforeFill = True
        '
        'RechazoEncuesta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(456, 209)
        Me.Controls.Add(Me.lblManzana)
        Me.Controls.Add(Me.LabelControl13)
        Me.Controls.Add(Me.lblZona)
        Me.Controls.Add(Me.LabelControl11)
        Me.Controls.Add(Me.lblNumero)
        Me.Controls.Add(Me.lblCasaDepto)
        Me.Controls.Add(Me.lblCalle)
        Me.Controls.Add(Me.lblFolio)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnRechazar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txtClave)
        Me.Controls.Add(Me.RibbonControl)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "RechazoEncuesta"
        Me.Ribbon = Me.RibbonControl
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Rechazar encuesta"
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtClave.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents txtClave As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnRechazar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblFolio As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblCalle As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblCasaDepto As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblNumero As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblZona As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblManzana As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents HogarTableAdapter As EOD.datasetEODTableAdapters.HogarTableAdapter
    Friend WithEvents UsuarioTableAdapter As EOD.datasetEODTableAdapters.UsuarioTableAdapter


End Class
