<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModificarPersona
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ModificarPersona))
        Me.RibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnCancelarPersona = New DevExpress.XtraEditors.SimpleButton()
        Me.btnGuardarPersona = New DevExpress.XtraEditors.SimpleButton()
        Me.spcTrabajaEstudia = New DevExpress.XtraEditors.SplitContainerControl()
        Me.y_trabajo = New DevExpress.XtraEditors.TextEdit()
        Me.lkpJornadaTrabajo = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.JornadaTrabajoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.datasetEOD = New EOD.datasetEOD()
        Me.GridView21 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colJornadaTrabajo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelControl47 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl31 = New DevExpress.XtraEditors.LabelControl()
        Me.x_trabajo = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl()
        Me.lkpHitoTrabajo = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.HitoTrabajoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView20 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colhito = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.lblManzanaTrabajo = New DevExpress.XtraEditors.LabelControl()
        Me.lblHitoTrabajo = New DevExpress.XtraEditors.LabelControl()
        Me.lkpCalle2Trabajo = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView18 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colcalle2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.lkpCalle1Trabajo = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.Calle1TrabajoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView17 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colcalle = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.lblCalle2Trabajo = New DevExpress.XtraEditors.LabelControl()
        Me.lblCalle1Trabajo = New DevExpress.XtraEditors.LabelControl()
        Me.txtComunaTrabajoOtra = New DevExpress.XtraEditors.TextEdit()
        Me.lblComunaTrabajoOtra = New DevExpress.XtraEditors.LabelControl()
        Me.lkpComunaTrabajo = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.ComunaTrabajoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView16 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colComuna1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelControl25 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl24 = New DevExpress.XtraEditors.LabelControl()
        Me.lkpManzanaTrabajo = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtDondeEstudiaOtro = New DevExpress.XtraEditors.TextEdit()
        Me.lblDondeEstudiaOtro = New DevExpress.XtraEditors.LabelControl()
        Me.y_estudio = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl48 = New DevExpress.XtraEditors.LabelControl()
        Me.lkpTieneTNE = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.SiNoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView28 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colOpcion3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.x_estudio = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl40 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl49 = New DevExpress.XtraEditors.LabelControl()
        Me.lkpDondeEstudia = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.DondeEstudiaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView22 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colDondeEstudia = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelControl32 = New DevExpress.XtraEditors.LabelControl()
        Me.lkpHitoEstudio = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.HitoEstudioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView24 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colhito1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.lblManzanaEstudio = New DevExpress.XtraEditors.LabelControl()
        Me.lblHitoEstudio = New DevExpress.XtraEditors.LabelControl()
        Me.lkpCalle2Estudio = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView25 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colcalle21 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.lkpCalle1Estudio = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.Calle1EstudioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView26 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colcalle1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.lblCalle2Estudio = New DevExpress.XtraEditors.LabelControl()
        Me.lblCalle1Estudio = New DevExpress.XtraEditors.LabelControl()
        Me.txtComunaEstudioOtra = New DevExpress.XtraEditors.TextEdit()
        Me.lblComunaEstudioOtra = New DevExpress.XtraEditors.LabelControl()
        Me.lkpComunaEstudio = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.ComunaEstudioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView27 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colComuna2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelControl38 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl39 = New DevExpress.XtraEditors.LabelControl()
        Me.lkpManzanaEstudio = New DevExpress.XtraEditors.LookUpEdit()
        Me.PersonaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lkpEstudiosCompletos = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView12 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colOpcion1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.lblEstudiosCompletos = New DevExpress.XtraEditors.LabelControl()
        Me.txtActividadOtra = New DevExpress.XtraEditors.TextEdit()
        Me.lblActividadOtra = New DevExpress.XtraEditors.LabelControl()
        Me.lkpLicencia = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView14 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colOpcion2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelControl22 = New DevExpress.XtraEditors.LabelControl()
        Me.lblLicencia = New DevExpress.XtraEditors.LabelControl()
        Me.chkActividad = New DevExpress.XtraEditors.CheckedComboBoxEdit()
        Me.ActividadBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl()
        Me.lkpEstudios = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.EstudiosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView11 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colEstudio = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl()
        Me.RelacionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.SexoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.PersonaTableAdapter = New EOD.datasetEODTableAdapters.PersonaTableAdapter()
        Me.SexoTableAdapter = New EOD.datasetEODTableAdapters.SexoTableAdapter()
        Me.RelacionTableAdapter = New EOD.datasetEODTableAdapters.RelacionTableAdapter()
        Me.EstudiosTableAdapter = New EOD.datasetEODTableAdapters.EstudiosTableAdapter()
        Me.SiNoTableAdapter = New EOD.datasetEODTableAdapters.SiNoTableAdapter()
        Me.ActividadTableAdapter = New EOD.datasetEODTableAdapters.ActividadTableAdapter()
        Me.ComunaTableAdapter = New EOD.datasetEODTableAdapters.ComunaTableAdapter()
        Me.CallesTableAdapter = New EOD.datasetEODTableAdapters.CallesTableAdapter()
        Me.HitoTableAdapter = New EOD.datasetEODTableAdapters.HitoTableAdapter()
        Me.JornadaTrabajoTableAdapter = New EOD.datasetEODTableAdapters.JornadaTrabajoTableAdapter()
        Me.DondeEstudiaTableAdapter = New EOD.datasetEODTableAdapters.DondeEstudiaTableAdapter()
        Me.lkpRelacion = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtAnoNacimiento = New DevExpress.XtraEditors.TextEdit()
        Me.txtNombrePila = New DevExpress.XtraEditors.TextEdit()
        Me.lkpSexo = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SplashScreenManager1 = New DevExpress.XtraSplashScreen.SplashScreenManager(Me, GetType(Global.EOD.PantallaEspera), True, True)
        Me.cargaPersonaBackground = New System.ComponentModel.BackgroundWorker()
        Me.ValidaPersonaTableAdapter = New EOD.datasetEODTableAdapters.ValidaPersonaTableAdapter()
        Me.btnIngresos = New DevExpress.XtraEditors.SimpleButton()
        Me.ConsultaCalle2TrabajoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ConsultaCalle2TrabajoTableAdapter = New EOD.datasetEODTableAdapters.ConsultaCalle2TrabajoTableAdapter()
        Me.ConsultaCalle2EstudioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ConsultaCalle2EstudioTableAdapter = New EOD.datasetEODTableAdapters.ConsultaCalle2EstudioTableAdapter()
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spcTrabajaEstudia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.spcTrabajaEstudia.SuspendLayout()
        CType(Me.y_trabajo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkpJornadaTrabajo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JornadaTrabajoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.datasetEOD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.x_trabajo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkpHitoTrabajo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HitoTrabajoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkpCalle2Trabajo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkpCalle1Trabajo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Calle1TrabajoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtComunaTrabajoOtra.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkpComunaTrabajo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComunaTrabajoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkpManzanaTrabajo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDondeEstudiaOtro.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.y_estudio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkpTieneTNE.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SiNoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView28, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.x_estudio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkpDondeEstudia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DondeEstudiaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkpHitoEstudio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HitoEstudioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView24, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkpCalle2Estudio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView25, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkpCalle1Estudio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Calle1EstudioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView26, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtComunaEstudioOtra.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkpComunaEstudio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComunaEstudioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView27, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkpManzanaEstudio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PersonaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkpEstudiosCompletos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtActividadOtra.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkpLicencia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkActividad.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ActividadBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkpEstudios.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstudiosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RelacionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SexoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkpRelacion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAnoNacimiento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombrePila.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkpSexo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConsultaCalle2TrabajoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConsultaCalle2EstudioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.RibbonControl.Size = New System.Drawing.Size(676, 32)
        Me.RibbonControl.Toolbar.ShowCustomizeItem = False
        '
        'btnCancelarPersona
        '
        Me.btnCancelarPersona.Appearance.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnCancelarPersona.Appearance.BackColor2 = System.Drawing.SystemColors.HotTrack
        Me.btnCancelarPersona.Appearance.BorderColor = System.Drawing.SystemColors.HotTrack
        Me.btnCancelarPersona.Appearance.ForeColor = System.Drawing.Color.White
        Me.btnCancelarPersona.Appearance.Options.UseBackColor = True
        Me.btnCancelarPersona.Appearance.Options.UseBorderColor = True
        Me.btnCancelarPersona.Appearance.Options.UseForeColor = True
        Me.btnCancelarPersona.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
        Me.btnCancelarPersona.Location = New System.Drawing.Point(576, 449)
        Me.btnCancelarPersona.Name = "btnCancelarPersona"
        Me.btnCancelarPersona.Size = New System.Drawing.Size(85, 28)
        Me.btnCancelarPersona.TabIndex = 27
        Me.btnCancelarPersona.Text = "Cancelar"
        '
        'btnGuardarPersona
        '
        Me.btnGuardarPersona.Appearance.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnGuardarPersona.Appearance.BackColor2 = System.Drawing.SystemColors.HotTrack
        Me.btnGuardarPersona.Appearance.BorderColor = System.Drawing.SystemColors.HotTrack
        Me.btnGuardarPersona.Appearance.ForeColor = System.Drawing.Color.White
        Me.btnGuardarPersona.Appearance.Options.UseBackColor = True
        Me.btnGuardarPersona.Appearance.Options.UseBorderColor = True
        Me.btnGuardarPersona.Appearance.Options.UseForeColor = True
        Me.btnGuardarPersona.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
        Me.btnGuardarPersona.Location = New System.Drawing.Point(485, 449)
        Me.btnGuardarPersona.Name = "btnGuardarPersona"
        Me.btnGuardarPersona.Size = New System.Drawing.Size(85, 28)
        Me.btnGuardarPersona.TabIndex = 26
        Me.btnGuardarPersona.Text = "Guardar"
        '
        'spcTrabajaEstudia
        '
        Me.spcTrabajaEstudia.Horizontal = False
        Me.spcTrabajaEstudia.IsSplitterFixed = True
        Me.spcTrabajaEstudia.Location = New System.Drawing.Point(11, 185)
        Me.spcTrabajaEstudia.Name = "spcTrabajaEstudia"
        Me.spcTrabajaEstudia.Panel1.Controls.Add(Me.y_trabajo)
        Me.spcTrabajaEstudia.Panel1.Controls.Add(Me.lkpJornadaTrabajo)
        Me.spcTrabajaEstudia.Panel1.Controls.Add(Me.LabelControl47)
        Me.spcTrabajaEstudia.Panel1.Controls.Add(Me.LabelControl31)
        Me.spcTrabajaEstudia.Panel1.Controls.Add(Me.x_trabajo)
        Me.spcTrabajaEstudia.Panel1.Controls.Add(Me.LabelControl16)
        Me.spcTrabajaEstudia.Panel1.Controls.Add(Me.lkpHitoTrabajo)
        Me.spcTrabajaEstudia.Panel1.Controls.Add(Me.lblManzanaTrabajo)
        Me.spcTrabajaEstudia.Panel1.Controls.Add(Me.lblHitoTrabajo)
        Me.spcTrabajaEstudia.Panel1.Controls.Add(Me.lkpCalle2Trabajo)
        Me.spcTrabajaEstudia.Panel1.Controls.Add(Me.lkpCalle1Trabajo)
        Me.spcTrabajaEstudia.Panel1.Controls.Add(Me.lblCalle2Trabajo)
        Me.spcTrabajaEstudia.Panel1.Controls.Add(Me.lblCalle1Trabajo)
        Me.spcTrabajaEstudia.Panel1.Controls.Add(Me.txtComunaTrabajoOtra)
        Me.spcTrabajaEstudia.Panel1.Controls.Add(Me.lblComunaTrabajoOtra)
        Me.spcTrabajaEstudia.Panel1.Controls.Add(Me.lkpComunaTrabajo)
        Me.spcTrabajaEstudia.Panel1.Controls.Add(Me.LabelControl25)
        Me.spcTrabajaEstudia.Panel1.Controls.Add(Me.LabelControl24)
        Me.spcTrabajaEstudia.Panel1.Controls.Add(Me.lkpManzanaTrabajo)
        Me.spcTrabajaEstudia.Panel1.Text = "Panel1"
        Me.spcTrabajaEstudia.Panel2.Controls.Add(Me.txtDondeEstudiaOtro)
        Me.spcTrabajaEstudia.Panel2.Controls.Add(Me.lblDondeEstudiaOtro)
        Me.spcTrabajaEstudia.Panel2.Controls.Add(Me.y_estudio)
        Me.spcTrabajaEstudia.Panel2.Controls.Add(Me.LabelControl48)
        Me.spcTrabajaEstudia.Panel2.Controls.Add(Me.lkpTieneTNE)
        Me.spcTrabajaEstudia.Panel2.Controls.Add(Me.x_estudio)
        Me.spcTrabajaEstudia.Panel2.Controls.Add(Me.LabelControl40)
        Me.spcTrabajaEstudia.Panel2.Controls.Add(Me.LabelControl49)
        Me.spcTrabajaEstudia.Panel2.Controls.Add(Me.lkpDondeEstudia)
        Me.spcTrabajaEstudia.Panel2.Controls.Add(Me.LabelControl32)
        Me.spcTrabajaEstudia.Panel2.Controls.Add(Me.lkpHitoEstudio)
        Me.spcTrabajaEstudia.Panel2.Controls.Add(Me.lblManzanaEstudio)
        Me.spcTrabajaEstudia.Panel2.Controls.Add(Me.lblHitoEstudio)
        Me.spcTrabajaEstudia.Panel2.Controls.Add(Me.lkpCalle2Estudio)
        Me.spcTrabajaEstudia.Panel2.Controls.Add(Me.lkpCalle1Estudio)
        Me.spcTrabajaEstudia.Panel2.Controls.Add(Me.lblCalle2Estudio)
        Me.spcTrabajaEstudia.Panel2.Controls.Add(Me.lblCalle1Estudio)
        Me.spcTrabajaEstudia.Panel2.Controls.Add(Me.txtComunaEstudioOtra)
        Me.spcTrabajaEstudia.Panel2.Controls.Add(Me.lblComunaEstudioOtra)
        Me.spcTrabajaEstudia.Panel2.Controls.Add(Me.lkpComunaEstudio)
        Me.spcTrabajaEstudia.Panel2.Controls.Add(Me.LabelControl38)
        Me.spcTrabajaEstudia.Panel2.Controls.Add(Me.LabelControl39)
        Me.spcTrabajaEstudia.Panel2.Controls.Add(Me.lkpManzanaEstudio)
        Me.spcTrabajaEstudia.Panel2.Text = "Panel2"
        Me.spcTrabajaEstudia.Size = New System.Drawing.Size(650, 255)
        Me.spcTrabajaEstudia.SplitterPosition = 105
        Me.spcTrabajaEstudia.TabIndex = 99
        Me.spcTrabajaEstudia.Text = "SplitContainerControl2"
        Me.spcTrabajaEstudia.Visible = False
        '
        'y_trabajo
        '
        Me.y_trabajo.Location = New System.Drawing.Point(83, 58)
        Me.y_trabajo.MenuManager = Me.RibbonControl
        Me.y_trabajo.Name = "y_trabajo"
        Me.y_trabajo.Size = New System.Drawing.Size(56, 20)
        Me.y_trabajo.TabIndex = 73
        Me.y_trabajo.Visible = False
        '
        'lkpJornadaTrabajo
        '
        Me.lkpJornadaTrabajo.EditValue = ""
        Me.lkpJornadaTrabajo.Location = New System.Drawing.Point(174, 84)
        Me.lkpJornadaTrabajo.MenuManager = Me.RibbonControl
        Me.lkpJornadaTrabajo.Name = "lkpJornadaTrabajo"
        Me.lkpJornadaTrabajo.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.lkpJornadaTrabajo.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.lkpJornadaTrabajo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lkpJornadaTrabajo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkpJornadaTrabajo.Properties.DataSource = Me.JornadaTrabajoBindingSource
        Me.lkpJornadaTrabajo.Properties.DisplayMember = "JornadaTrabajo"
        Me.lkpJornadaTrabajo.Properties.PopupFormMinSize = New System.Drawing.Size(476, 80)
        Me.lkpJornadaTrabajo.Properties.PopupFormSize = New System.Drawing.Size(476, 80)
        Me.lkpJornadaTrabajo.Properties.ShowFooter = False
        Me.lkpJornadaTrabajo.Properties.ValueMember = "ID"
        Me.lkpJornadaTrabajo.Properties.View = Me.GridView21
        Me.lkpJornadaTrabajo.Size = New System.Drawing.Size(476, 20)
        Me.lkpJornadaTrabajo.TabIndex = 16
        '
        'JornadaTrabajoBindingSource
        '
        Me.JornadaTrabajoBindingSource.DataMember = "JornadaTrabajo"
        Me.JornadaTrabajoBindingSource.DataSource = Me.datasetEOD
        '
        'datasetEOD
        '
        Me.datasetEOD.DataSetName = "datasetEOD"
        Me.datasetEOD.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView21
        '
        Me.GridView21.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colJornadaTrabajo})
        Me.GridView21.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView21.Name = "GridView21"
        Me.GridView21.OptionsBehavior.Editable = False
        Me.GridView21.OptionsCustomization.AllowFilter = False
        Me.GridView21.OptionsCustomization.AllowGroup = False
        Me.GridView21.OptionsCustomization.AllowSort = False
        Me.GridView21.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView21.OptionsView.ShowColumnHeaders = False
        Me.GridView21.OptionsView.ShowGroupPanel = False
        Me.GridView21.OptionsView.ShowIndicator = False
        '
        'colJornadaTrabajo
        '
        Me.colJornadaTrabajo.FieldName = "JornadaTrabajo"
        Me.colJornadaTrabajo.Name = "colJornadaTrabajo"
        Me.colJornadaTrabajo.Visible = True
        Me.colJornadaTrabajo.VisibleIndex = 0
        '
        'LabelControl47
        '
        Me.LabelControl47.Location = New System.Drawing.Point(30, 61)
        Me.LabelControl47.Name = "LabelControl47"
        Me.LabelControl47.Size = New System.Drawing.Size(47, 13)
        Me.LabelControl47.TabIndex = 72
        Me.LabelControl47.Text = "y_trabajo"
        Me.LabelControl47.Visible = False
        '
        'LabelControl31
        '
        Me.LabelControl31.Location = New System.Drawing.Point(3, 87)
        Me.LabelControl31.Name = "LabelControl31"
        Me.LabelControl31.Size = New System.Drawing.Size(152, 13)
        Me.LabelControl31.TabIndex = 52
        Me.LabelControl31.Text = "¿Cuál es su jornada de trabajo?"
        '
        'x_trabajo
        '
        Me.x_trabajo.Location = New System.Drawing.Point(83, 32)
        Me.x_trabajo.MenuManager = Me.RibbonControl
        Me.x_trabajo.Name = "x_trabajo"
        Me.x_trabajo.Size = New System.Drawing.Size(56, 20)
        Me.x_trabajo.TabIndex = 71
        Me.x_trabajo.Visible = False
        '
        'LabelControl16
        '
        Me.LabelControl16.Location = New System.Drawing.Point(30, 35)
        Me.LabelControl16.Name = "LabelControl16"
        Me.LabelControl16.Size = New System.Drawing.Size(47, 13)
        Me.LabelControl16.TabIndex = 70
        Me.LabelControl16.Text = "x_trabajo"
        Me.LabelControl16.Visible = False
        '
        'lkpHitoTrabajo
        '
        Me.lkpHitoTrabajo.EditValue = ""
        Me.lkpHitoTrabajo.Location = New System.Drawing.Point(236, 58)
        Me.lkpHitoTrabajo.MenuManager = Me.RibbonControl
        Me.lkpHitoTrabajo.Name = "lkpHitoTrabajo"
        Me.lkpHitoTrabajo.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.lkpHitoTrabajo.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.lkpHitoTrabajo.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.lkpHitoTrabajo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lkpHitoTrabajo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkpHitoTrabajo.Properties.DataSource = Me.HitoTrabajoBindingSource
        Me.lkpHitoTrabajo.Properties.DisplayMember = "hito"
        Me.lkpHitoTrabajo.Properties.ImmediatePopup = True
        Me.lkpHitoTrabajo.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.lkpHitoTrabajo.Properties.PopupFormMinSize = New System.Drawing.Size(235, 20)
        Me.lkpHitoTrabajo.Properties.PopupFormSize = New System.Drawing.Size(235, 200)
        Me.lkpHitoTrabajo.Properties.ShowFooter = False
        Me.lkpHitoTrabajo.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.lkpHitoTrabajo.Properties.ValueMember = "hito"
        Me.lkpHitoTrabajo.Properties.View = Me.GridView20
        Me.lkpHitoTrabajo.Size = New System.Drawing.Size(235, 20)
        Me.lkpHitoTrabajo.TabIndex = 14
        '
        'HitoTrabajoBindingSource
        '
        Me.HitoTrabajoBindingSource.DataMember = "Hito"
        Me.HitoTrabajoBindingSource.DataSource = Me.datasetEOD
        '
        'GridView20
        '
        Me.GridView20.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colhito})
        Me.GridView20.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView20.Name = "GridView20"
        Me.GridView20.OptionsCustomization.AllowFilter = False
        Me.GridView20.OptionsCustomization.AllowGroup = False
        Me.GridView20.OptionsCustomization.AllowSort = False
        Me.GridView20.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView20.OptionsView.ShowColumnHeaders = False
        Me.GridView20.OptionsView.ShowGroupPanel = False
        '
        'colhito
        '
        Me.colhito.FieldName = "hito"
        Me.colhito.Name = "colhito"
        Me.colhito.Visible = True
        Me.colhito.VisibleIndex = 0
        '
        'lblManzanaTrabajo
        '
        Me.lblManzanaTrabajo.Location = New System.Drawing.Point(497, 61)
        Me.lblManzanaTrabajo.Name = "lblManzanaTrabajo"
        Me.lblManzanaTrabajo.Size = New System.Drawing.Size(43, 13)
        Me.lblManzanaTrabajo.TabIndex = 49
        Me.lblManzanaTrabajo.Text = "Manzana"
        '
        'lblHitoTrabajo
        '
        Me.lblHitoTrabajo.Location = New System.Drawing.Point(211, 61)
        Me.lblHitoTrabajo.Name = "lblHitoTrabajo"
        Me.lblHitoTrabajo.Size = New System.Drawing.Size(19, 13)
        Me.lblHitoTrabajo.TabIndex = 48
        Me.lblHitoTrabajo.Text = "Hito"
        '
        'lkpCalle2Trabajo
        '
        Me.lkpCalle2Trabajo.EditValue = ""
        Me.lkpCalle2Trabajo.Location = New System.Drawing.Point(453, 32)
        Me.lkpCalle2Trabajo.MenuManager = Me.RibbonControl
        Me.lkpCalle2Trabajo.Name = "lkpCalle2Trabajo"
        Me.lkpCalle2Trabajo.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.lkpCalle2Trabajo.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.lkpCalle2Trabajo.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.lkpCalle2Trabajo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lkpCalle2Trabajo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkpCalle2Trabajo.Properties.DataSource = Me.ConsultaCalle2TrabajoBindingSource
        Me.lkpCalle2Trabajo.Properties.DisplayMember = "calle2"
        Me.lkpCalle2Trabajo.Properties.ImmediatePopup = True
        Me.lkpCalle2Trabajo.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.lkpCalle2Trabajo.Properties.PopupFormMinSize = New System.Drawing.Size(197, 20)
        Me.lkpCalle2Trabajo.Properties.PopupFormSize = New System.Drawing.Size(197, 200)
        Me.lkpCalle2Trabajo.Properties.ShowFooter = False
        Me.lkpCalle2Trabajo.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.lkpCalle2Trabajo.Properties.ValueMember = "calle2"
        Me.lkpCalle2Trabajo.Properties.View = Me.GridView18
        Me.lkpCalle2Trabajo.Size = New System.Drawing.Size(197, 20)
        Me.lkpCalle2Trabajo.TabIndex = 13
        '
        'GridView18
        '
        Me.GridView18.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colcalle2})
        Me.GridView18.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView18.Name = "GridView18"
        Me.GridView18.OptionsCustomization.AllowFilter = False
        Me.GridView18.OptionsCustomization.AllowGroup = False
        Me.GridView18.OptionsCustomization.AllowSort = False
        Me.GridView18.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView18.OptionsView.ShowColumnHeaders = False
        Me.GridView18.OptionsView.ShowGroupPanel = False
        Me.GridView18.OptionsView.ShowIndicator = False
        '
        'colcalle2
        '
        Me.colcalle2.FieldName = "calle2"
        Me.colcalle2.Name = "colcalle2"
        Me.colcalle2.Visible = True
        Me.colcalle2.VisibleIndex = 0
        '
        'lkpCalle1Trabajo
        '
        Me.lkpCalle1Trabajo.EditValue = ""
        Me.lkpCalle1Trabajo.Location = New System.Drawing.Point(236, 32)
        Me.lkpCalle1Trabajo.MenuManager = Me.RibbonControl
        Me.lkpCalle1Trabajo.Name = "lkpCalle1Trabajo"
        Me.lkpCalle1Trabajo.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.lkpCalle1Trabajo.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.lkpCalle1Trabajo.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.lkpCalle1Trabajo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lkpCalle1Trabajo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkpCalle1Trabajo.Properties.DataSource = Me.Calle1TrabajoBindingSource
        Me.lkpCalle1Trabajo.Properties.DisplayMember = "calle"
        Me.lkpCalle1Trabajo.Properties.ImmediatePopup = True
        Me.lkpCalle1Trabajo.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.lkpCalle1Trabajo.Properties.PopupFormMinSize = New System.Drawing.Size(161, 20)
        Me.lkpCalle1Trabajo.Properties.PopupFormSize = New System.Drawing.Size(161, 240)
        Me.lkpCalle1Trabajo.Properties.ShowFooter = False
        Me.lkpCalle1Trabajo.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.lkpCalle1Trabajo.Properties.ValueMember = "calle"
        Me.lkpCalle1Trabajo.Properties.View = Me.GridView17
        Me.lkpCalle1Trabajo.Size = New System.Drawing.Size(161, 20)
        Me.lkpCalle1Trabajo.TabIndex = 12
        '
        'Calle1TrabajoBindingSource
        '
        Me.Calle1TrabajoBindingSource.DataMember = "Calles"
        Me.Calle1TrabajoBindingSource.DataSource = Me.datasetEOD
        Me.Calle1TrabajoBindingSource.Filter = "ID < 10000"
        '
        'GridView17
        '
        Me.GridView17.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colcalle})
        Me.GridView17.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView17.Name = "GridView17"
        Me.GridView17.OptionsCustomization.AllowFilter = False
        Me.GridView17.OptionsCustomization.AllowGroup = False
        Me.GridView17.OptionsCustomization.AllowSort = False
        Me.GridView17.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView17.OptionsView.ShowColumnHeaders = False
        Me.GridView17.OptionsView.ShowGroupPanel = False
        Me.GridView17.OptionsView.ShowIndicator = False
        '
        'colcalle
        '
        Me.colcalle.FieldName = "calle"
        Me.colcalle.Name = "colcalle"
        Me.colcalle.Visible = True
        Me.colcalle.VisibleIndex = 0
        '
        'lblCalle2Trabajo
        '
        Me.lblCalle2Trabajo.Location = New System.Drawing.Point(415, 35)
        Me.lblCalle2Trabajo.Name = "lblCalle2Trabajo"
        Me.lblCalle2Trabajo.Size = New System.Drawing.Size(32, 13)
        Me.lblCalle2Trabajo.TabIndex = 45
        Me.lblCalle2Trabajo.Text = "Calle 2"
        '
        'lblCalle1Trabajo
        '
        Me.lblCalle1Trabajo.Location = New System.Drawing.Point(198, 35)
        Me.lblCalle1Trabajo.Name = "lblCalle1Trabajo"
        Me.lblCalle1Trabajo.Size = New System.Drawing.Size(32, 13)
        Me.lblCalle1Trabajo.TabIndex = 44
        Me.lblCalle1Trabajo.Text = "Calle 1"
        '
        'txtComunaTrabajoOtra
        '
        Me.txtComunaTrabajoOtra.Location = New System.Drawing.Point(453, 3)
        Me.txtComunaTrabajoOtra.MenuManager = Me.RibbonControl
        Me.txtComunaTrabajoOtra.Name = "txtComunaTrabajoOtra"
        Me.txtComunaTrabajoOtra.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.txtComunaTrabajoOtra.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.txtComunaTrabajoOtra.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtComunaTrabajoOtra.Size = New System.Drawing.Size(128, 20)
        Me.txtComunaTrabajoOtra.TabIndex = 11
        Me.txtComunaTrabajoOtra.Visible = False
        '
        'lblComunaTrabajoOtra
        '
        Me.lblComunaTrabajoOtra.Location = New System.Drawing.Point(425, 6)
        Me.lblComunaTrabajoOtra.Name = "lblComunaTrabajoOtra"
        Me.lblComunaTrabajoOtra.Size = New System.Drawing.Size(22, 13)
        Me.lblComunaTrabajoOtra.TabIndex = 42
        Me.lblComunaTrabajoOtra.Text = "Otra"
        Me.lblComunaTrabajoOtra.Visible = False
        '
        'lkpComunaTrabajo
        '
        Me.lkpComunaTrabajo.EditValue = ""
        Me.lkpComunaTrabajo.Location = New System.Drawing.Point(236, 3)
        Me.lkpComunaTrabajo.MenuManager = Me.RibbonControl
        Me.lkpComunaTrabajo.Name = "lkpComunaTrabajo"
        Me.lkpComunaTrabajo.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.lkpComunaTrabajo.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.lkpComunaTrabajo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lkpComunaTrabajo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkpComunaTrabajo.Properties.DataSource = Me.ComunaTrabajoBindingSource
        Me.lkpComunaTrabajo.Properties.DisplayMember = "Comuna"
        Me.lkpComunaTrabajo.Properties.PopupFormMinSize = New System.Drawing.Size(161, 240)
        Me.lkpComunaTrabajo.Properties.PopupFormSize = New System.Drawing.Size(161, 240)
        Me.lkpComunaTrabajo.Properties.ShowFooter = False
        Me.lkpComunaTrabajo.Properties.ValueMember = "ID"
        Me.lkpComunaTrabajo.Properties.View = Me.GridView16
        Me.lkpComunaTrabajo.Size = New System.Drawing.Size(161, 20)
        Me.lkpComunaTrabajo.TabIndex = 10
        '
        'ComunaTrabajoBindingSource
        '
        Me.ComunaTrabajoBindingSource.DataMember = "Comuna"
        Me.ComunaTrabajoBindingSource.DataSource = Me.datasetEOD
        Me.ComunaTrabajoBindingSource.Filter = "id > 0"
        '
        'GridView16
        '
        Me.GridView16.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colComuna1})
        Me.GridView16.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView16.Name = "GridView16"
        Me.GridView16.OptionsBehavior.Editable = False
        Me.GridView16.OptionsCustomization.AllowFilter = False
        Me.GridView16.OptionsCustomization.AllowGroup = False
        Me.GridView16.OptionsCustomization.AllowSort = False
        Me.GridView16.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView16.OptionsView.ShowColumnHeaders = False
        Me.GridView16.OptionsView.ShowGroupPanel = False
        Me.GridView16.OptionsView.ShowIndicator = False
        '
        'colComuna1
        '
        Me.colComuna1.FieldName = "Comuna"
        Me.colComuna1.Name = "colComuna1"
        Me.colComuna1.Visible = True
        Me.colComuna1.VisibleIndex = 0
        '
        'LabelControl25
        '
        Me.LabelControl25.Location = New System.Drawing.Point(191, 6)
        Me.LabelControl25.Name = "LabelControl25"
        Me.LabelControl25.Size = New System.Drawing.Size(39, 13)
        Me.LabelControl25.TabIndex = 41
        Me.LabelControl25.Text = "Comuna"
        '
        'LabelControl24
        '
        Me.LabelControl24.Location = New System.Drawing.Point(3, 6)
        Me.LabelControl24.Name = "LabelControl24"
        Me.LabelControl24.Size = New System.Drawing.Size(176, 13)
        Me.LabelControl24.TabIndex = 40
        Me.LabelControl24.Text = "Indique su lugar de trabajo principal:"
        '
        'lkpManzanaTrabajo
        '
        Me.lkpManzanaTrabajo.Location = New System.Drawing.Point(546, 58)
        Me.lkpManzanaTrabajo.MenuManager = Me.RibbonControl
        Me.lkpManzanaTrabajo.Name = "lkpManzanaTrabajo"
        Me.lkpManzanaTrabajo.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.lkpManzanaTrabajo.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.lkpManzanaTrabajo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lkpManzanaTrabajo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkpManzanaTrabajo.Properties.PopupFormMinSize = New System.Drawing.Size(104, 0)
        Me.lkpManzanaTrabajo.Properties.PopupWidth = 104
        Me.lkpManzanaTrabajo.Properties.ShowFooter = False
        Me.lkpManzanaTrabajo.Size = New System.Drawing.Size(104, 20)
        Me.lkpManzanaTrabajo.TabIndex = 15
        '
        'txtDondeEstudiaOtro
        '
        Me.txtDondeEstudiaOtro.Location = New System.Drawing.Point(455, 83)
        Me.txtDondeEstudiaOtro.MenuManager = Me.RibbonControl
        Me.txtDondeEstudiaOtro.Name = "txtDondeEstudiaOtro"
        Me.txtDondeEstudiaOtro.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.txtDondeEstudiaOtro.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.txtDondeEstudiaOtro.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtDondeEstudiaOtro.Size = New System.Drawing.Size(126, 20)
        Me.txtDondeEstudiaOtro.TabIndex = 24
        Me.txtDondeEstudiaOtro.Visible = False
        '
        'lblDondeEstudiaOtro
        '
        Me.lblDondeEstudiaOtro.Location = New System.Drawing.Point(400, 86)
        Me.lblDondeEstudiaOtro.Name = "lblDondeEstudiaOtro"
        Me.lblDondeEstudiaOtro.Size = New System.Drawing.Size(49, 13)
        Me.lblDondeEstudiaOtro.TabIndex = 79
        Me.lblDondeEstudiaOtro.Text = "Otro lugar"
        Me.lblDondeEstudiaOtro.Visible = False
        '
        'y_estudio
        '
        Me.y_estudio.Location = New System.Drawing.Point(83, 57)
        Me.y_estudio.MenuManager = Me.RibbonControl
        Me.y_estudio.Name = "y_estudio"
        Me.y_estudio.Size = New System.Drawing.Size(56, 20)
        Me.y_estudio.TabIndex = 77
        Me.y_estudio.Visible = False
        '
        'LabelControl48
        '
        Me.LabelControl48.Location = New System.Drawing.Point(30, 60)
        Me.LabelControl48.Name = "LabelControl48"
        Me.LabelControl48.Size = New System.Drawing.Size(47, 13)
        Me.LabelControl48.TabIndex = 76
        Me.LabelControl48.Text = "y_estudio"
        Me.LabelControl48.Visible = False
        '
        'lkpTieneTNE
        '
        Me.lkpTieneTNE.EditValue = ""
        Me.lkpTieneTNE.Location = New System.Drawing.Point(236, 109)
        Me.lkpTieneTNE.MenuManager = Me.RibbonControl
        Me.lkpTieneTNE.Name = "lkpTieneTNE"
        Me.lkpTieneTNE.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.lkpTieneTNE.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.lkpTieneTNE.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lkpTieneTNE.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkpTieneTNE.Properties.DataSource = Me.SiNoBindingSource
        Me.lkpTieneTNE.Properties.DisplayMember = "Opcion"
        Me.lkpTieneTNE.Properties.PopupFormMinSize = New System.Drawing.Size(61, 40)
        Me.lkpTieneTNE.Properties.PopupFormSize = New System.Drawing.Size(61, 40)
        Me.lkpTieneTNE.Properties.ShowFooter = False
        Me.lkpTieneTNE.Properties.ValueMember = "Id"
        Me.lkpTieneTNE.Properties.View = Me.GridView28
        Me.lkpTieneTNE.Size = New System.Drawing.Size(61, 20)
        Me.lkpTieneTNE.TabIndex = 25
        '
        'SiNoBindingSource
        '
        Me.SiNoBindingSource.DataMember = "SiNo"
        Me.SiNoBindingSource.DataSource = Me.datasetEOD
        Me.SiNoBindingSource.Filter = "id > 0"
        '
        'GridView28
        '
        Me.GridView28.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colOpcion3})
        Me.GridView28.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView28.Name = "GridView28"
        Me.GridView28.OptionsBehavior.Editable = False
        Me.GridView28.OptionsCustomization.AllowFilter = False
        Me.GridView28.OptionsCustomization.AllowGroup = False
        Me.GridView28.OptionsCustomization.AllowSort = False
        Me.GridView28.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView28.OptionsView.ShowColumnHeaders = False
        Me.GridView28.OptionsView.ShowGroupPanel = False
        Me.GridView28.OptionsView.ShowIndicator = False
        '
        'colOpcion3
        '
        Me.colOpcion3.FieldName = "Opcion"
        Me.colOpcion3.Name = "colOpcion3"
        Me.colOpcion3.Visible = True
        Me.colOpcion3.VisibleIndex = 0
        '
        'x_estudio
        '
        Me.x_estudio.Location = New System.Drawing.Point(83, 31)
        Me.x_estudio.MenuManager = Me.RibbonControl
        Me.x_estudio.Name = "x_estudio"
        Me.x_estudio.Size = New System.Drawing.Size(56, 20)
        Me.x_estudio.TabIndex = 75
        Me.x_estudio.Visible = False
        '
        'LabelControl40
        '
        Me.LabelControl40.Location = New System.Drawing.Point(3, 112)
        Me.LabelControl40.Name = "LabelControl40"
        Me.LabelControl40.Size = New System.Drawing.Size(210, 13)
        Me.LabelControl40.TabIndex = 69
        Me.LabelControl40.Text = "¿Tiene la Tarjeta Nacional Estudiantil (TNE)?"
        '
        'LabelControl49
        '
        Me.LabelControl49.Location = New System.Drawing.Point(30, 34)
        Me.LabelControl49.Name = "LabelControl49"
        Me.LabelControl49.Size = New System.Drawing.Size(47, 13)
        Me.LabelControl49.TabIndex = 74
        Me.LabelControl49.Text = "x_estudio"
        Me.LabelControl49.Visible = False
        '
        'lkpDondeEstudia
        '
        Me.lkpDondeEstudia.EditValue = ""
        Me.lkpDondeEstudia.Location = New System.Drawing.Point(88, 83)
        Me.lkpDondeEstudia.MenuManager = Me.RibbonControl
        Me.lkpDondeEstudia.Name = "lkpDondeEstudia"
        Me.lkpDondeEstudia.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.lkpDondeEstudia.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.lkpDondeEstudia.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lkpDondeEstudia.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkpDondeEstudia.Properties.DataSource = Me.DondeEstudiaBindingSource
        Me.lkpDondeEstudia.Properties.DisplayMember = "DondeEstudia"
        Me.lkpDondeEstudia.Properties.PopupFormMinSize = New System.Drawing.Size(277, 100)
        Me.lkpDondeEstudia.Properties.PopupFormSize = New System.Drawing.Size(277, 100)
        Me.lkpDondeEstudia.Properties.ShowFooter = False
        Me.lkpDondeEstudia.Properties.ValueMember = "ID"
        Me.lkpDondeEstudia.Properties.View = Me.GridView22
        Me.lkpDondeEstudia.Size = New System.Drawing.Size(277, 20)
        Me.lkpDondeEstudia.TabIndex = 23
        '
        'DondeEstudiaBindingSource
        '
        Me.DondeEstudiaBindingSource.DataMember = "DondeEstudia"
        Me.DondeEstudiaBindingSource.DataSource = Me.datasetEOD
        Me.DondeEstudiaBindingSource.Filter = "id > 0"
        '
        'GridView22
        '
        Me.GridView22.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDondeEstudia})
        Me.GridView22.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView22.Name = "GridView22"
        Me.GridView22.OptionsBehavior.Editable = False
        Me.GridView22.OptionsCustomization.AllowFilter = False
        Me.GridView22.OptionsCustomization.AllowGroup = False
        Me.GridView22.OptionsCustomization.AllowSort = False
        Me.GridView22.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView22.OptionsView.ShowColumnHeaders = False
        Me.GridView22.OptionsView.ShowGroupPanel = False
        Me.GridView22.OptionsView.ShowIndicator = False
        '
        'colDondeEstudia
        '
        Me.colDondeEstudia.FieldName = "DondeEstudia"
        Me.colDondeEstudia.Name = "colDondeEstudia"
        Me.colDondeEstudia.Visible = True
        Me.colDondeEstudia.VisibleIndex = 0
        '
        'LabelControl32
        '
        Me.LabelControl32.Location = New System.Drawing.Point(3, 86)
        Me.LabelControl32.Name = "LabelControl32"
        Me.LabelControl32.Size = New System.Drawing.Size(79, 13)
        Me.LabelControl32.TabIndex = 67
        Me.LabelControl32.Text = "¿Dónde estudia?"
        '
        'lkpHitoEstudio
        '
        Me.lkpHitoEstudio.EditValue = ""
        Me.lkpHitoEstudio.Location = New System.Drawing.Point(236, 57)
        Me.lkpHitoEstudio.MenuManager = Me.RibbonControl
        Me.lkpHitoEstudio.Name = "lkpHitoEstudio"
        Me.lkpHitoEstudio.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.lkpHitoEstudio.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.lkpHitoEstudio.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.lkpHitoEstudio.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lkpHitoEstudio.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkpHitoEstudio.Properties.DataSource = Me.HitoEstudioBindingSource
        Me.lkpHitoEstudio.Properties.DisplayMember = "hito"
        Me.lkpHitoEstudio.Properties.ImmediatePopup = True
        Me.lkpHitoEstudio.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.lkpHitoEstudio.Properties.PopupFormMinSize = New System.Drawing.Size(235, 20)
        Me.lkpHitoEstudio.Properties.PopupFormSize = New System.Drawing.Size(235, 200)
        Me.lkpHitoEstudio.Properties.ShowFooter = False
        Me.lkpHitoEstudio.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.lkpHitoEstudio.Properties.ValueMember = "hito"
        Me.lkpHitoEstudio.Properties.View = Me.GridView24
        Me.lkpHitoEstudio.Size = New System.Drawing.Size(235, 20)
        Me.lkpHitoEstudio.TabIndex = 21
        '
        'HitoEstudioBindingSource
        '
        Me.HitoEstudioBindingSource.DataMember = "Hito"
        Me.HitoEstudioBindingSource.DataSource = Me.datasetEOD
        '
        'GridView24
        '
        Me.GridView24.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colhito1})
        Me.GridView24.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView24.Name = "GridView24"
        Me.GridView24.OptionsCustomization.AllowFilter = False
        Me.GridView24.OptionsCustomization.AllowGroup = False
        Me.GridView24.OptionsCustomization.AllowSort = False
        Me.GridView24.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView24.OptionsView.ShowColumnHeaders = False
        Me.GridView24.OptionsView.ShowGroupPanel = False
        Me.GridView24.OptionsView.ShowIndicator = False
        '
        'colhito1
        '
        Me.colhito1.FieldName = "hito"
        Me.colhito1.Name = "colhito1"
        Me.colhito1.Visible = True
        Me.colhito1.VisibleIndex = 0
        '
        'lblManzanaEstudio
        '
        Me.lblManzanaEstudio.Location = New System.Drawing.Point(497, 60)
        Me.lblManzanaEstudio.Name = "lblManzanaEstudio"
        Me.lblManzanaEstudio.Size = New System.Drawing.Size(43, 13)
        Me.lblManzanaEstudio.TabIndex = 64
        Me.lblManzanaEstudio.Text = "Manzana"
        '
        'lblHitoEstudio
        '
        Me.lblHitoEstudio.Location = New System.Drawing.Point(211, 60)
        Me.lblHitoEstudio.Name = "lblHitoEstudio"
        Me.lblHitoEstudio.Size = New System.Drawing.Size(19, 13)
        Me.lblHitoEstudio.TabIndex = 63
        Me.lblHitoEstudio.Text = "Hito"
        '
        'lkpCalle2Estudio
        '
        Me.lkpCalle2Estudio.EditValue = ""
        Me.lkpCalle2Estudio.Location = New System.Drawing.Point(455, 31)
        Me.lkpCalle2Estudio.MenuManager = Me.RibbonControl
        Me.lkpCalle2Estudio.Name = "lkpCalle2Estudio"
        Me.lkpCalle2Estudio.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.lkpCalle2Estudio.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.lkpCalle2Estudio.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.lkpCalle2Estudio.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lkpCalle2Estudio.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkpCalle2Estudio.Properties.DataSource = Me.ConsultaCalle2EstudioBindingSource
        Me.lkpCalle2Estudio.Properties.DisplayMember = "calle2"
        Me.lkpCalle2Estudio.Properties.ImmediatePopup = True
        Me.lkpCalle2Estudio.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.lkpCalle2Estudio.Properties.PopupFormMinSize = New System.Drawing.Size(195, 20)
        Me.lkpCalle2Estudio.Properties.PopupFormSize = New System.Drawing.Size(195, 200)
        Me.lkpCalle2Estudio.Properties.ShowFooter = False
        Me.lkpCalle2Estudio.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.lkpCalle2Estudio.Properties.ValueMember = "calle2"
        Me.lkpCalle2Estudio.Properties.View = Me.GridView25
        Me.lkpCalle2Estudio.Size = New System.Drawing.Size(195, 20)
        Me.lkpCalle2Estudio.TabIndex = 20
        '
        'GridView25
        '
        Me.GridView25.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colcalle21})
        Me.GridView25.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView25.Name = "GridView25"
        Me.GridView25.OptionsCustomization.AllowFilter = False
        Me.GridView25.OptionsCustomization.AllowGroup = False
        Me.GridView25.OptionsCustomization.AllowSort = False
        Me.GridView25.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView25.OptionsView.ShowColumnHeaders = False
        Me.GridView25.OptionsView.ShowGroupPanel = False
        Me.GridView25.OptionsView.ShowIndicator = False
        '
        'colcalle21
        '
        Me.colcalle21.FieldName = "calle2"
        Me.colcalle21.Name = "colcalle21"
        Me.colcalle21.Visible = True
        Me.colcalle21.VisibleIndex = 0
        '
        'lkpCalle1Estudio
        '
        Me.lkpCalle1Estudio.EditValue = ""
        Me.lkpCalle1Estudio.Location = New System.Drawing.Point(236, 31)
        Me.lkpCalle1Estudio.MenuManager = Me.RibbonControl
        Me.lkpCalle1Estudio.Name = "lkpCalle1Estudio"
        Me.lkpCalle1Estudio.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.lkpCalle1Estudio.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.lkpCalle1Estudio.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.lkpCalle1Estudio.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lkpCalle1Estudio.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkpCalle1Estudio.Properties.DataSource = Me.Calle1EstudioBindingSource
        Me.lkpCalle1Estudio.Properties.DisplayMember = "calle"
        Me.lkpCalle1Estudio.Properties.ImmediatePopup = True
        Me.lkpCalle1Estudio.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.lkpCalle1Estudio.Properties.PopupFormMinSize = New System.Drawing.Size(161, 20)
        Me.lkpCalle1Estudio.Properties.PopupFormSize = New System.Drawing.Size(161, 240)
        Me.lkpCalle1Estudio.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.lkpCalle1Estudio.Properties.ValueMember = "calle"
        Me.lkpCalle1Estudio.Properties.View = Me.GridView26
        Me.lkpCalle1Estudio.Size = New System.Drawing.Size(161, 20)
        Me.lkpCalle1Estudio.TabIndex = 19
        '
        'Calle1EstudioBindingSource
        '
        Me.Calle1EstudioBindingSource.DataMember = "Calles"
        Me.Calle1EstudioBindingSource.DataSource = Me.datasetEOD
        Me.Calle1EstudioBindingSource.Filter = "ID < 10000"
        '
        'GridView26
        '
        Me.GridView26.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colcalle1})
        Me.GridView26.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView26.Name = "GridView26"
        Me.GridView26.OptionsCustomization.AllowFilter = False
        Me.GridView26.OptionsCustomization.AllowGroup = False
        Me.GridView26.OptionsCustomization.AllowSort = False
        Me.GridView26.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView26.OptionsView.ShowColumnHeaders = False
        Me.GridView26.OptionsView.ShowGroupPanel = False
        Me.GridView26.OptionsView.ShowIndicator = False
        '
        'colcalle1
        '
        Me.colcalle1.FieldName = "calle"
        Me.colcalle1.Name = "colcalle1"
        Me.colcalle1.Visible = True
        Me.colcalle1.VisibleIndex = 0
        '
        'lblCalle2Estudio
        '
        Me.lblCalle2Estudio.Location = New System.Drawing.Point(417, 34)
        Me.lblCalle2Estudio.Name = "lblCalle2Estudio"
        Me.lblCalle2Estudio.Size = New System.Drawing.Size(32, 13)
        Me.lblCalle2Estudio.TabIndex = 60
        Me.lblCalle2Estudio.Text = "Calle 2"
        '
        'lblCalle1Estudio
        '
        Me.lblCalle1Estudio.Location = New System.Drawing.Point(198, 34)
        Me.lblCalle1Estudio.Name = "lblCalle1Estudio"
        Me.lblCalle1Estudio.Size = New System.Drawing.Size(32, 13)
        Me.lblCalle1Estudio.TabIndex = 59
        Me.lblCalle1Estudio.Text = "Calle 1"
        '
        'txtComunaEstudioOtra
        '
        Me.txtComunaEstudioOtra.Location = New System.Drawing.Point(455, 2)
        Me.txtComunaEstudioOtra.MenuManager = Me.RibbonControl
        Me.txtComunaEstudioOtra.Name = "txtComunaEstudioOtra"
        Me.txtComunaEstudioOtra.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.txtComunaEstudioOtra.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.txtComunaEstudioOtra.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtComunaEstudioOtra.Size = New System.Drawing.Size(126, 20)
        Me.txtComunaEstudioOtra.TabIndex = 18
        '
        'lblComunaEstudioOtra
        '
        Me.lblComunaEstudioOtra.Location = New System.Drawing.Point(427, 5)
        Me.lblComunaEstudioOtra.Name = "lblComunaEstudioOtra"
        Me.lblComunaEstudioOtra.Size = New System.Drawing.Size(22, 13)
        Me.lblComunaEstudioOtra.TabIndex = 57
        Me.lblComunaEstudioOtra.Text = "Otra"
        '
        'lkpComunaEstudio
        '
        Me.lkpComunaEstudio.EditValue = ""
        Me.lkpComunaEstudio.Location = New System.Drawing.Point(236, 2)
        Me.lkpComunaEstudio.MenuManager = Me.RibbonControl
        Me.lkpComunaEstudio.Name = "lkpComunaEstudio"
        Me.lkpComunaEstudio.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.lkpComunaEstudio.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.lkpComunaEstudio.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lkpComunaEstudio.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkpComunaEstudio.Properties.DataSource = Me.ComunaEstudioBindingSource
        Me.lkpComunaEstudio.Properties.DisplayMember = "Comuna"
        Me.lkpComunaEstudio.Properties.PopupFormMinSize = New System.Drawing.Size(161, 240)
        Me.lkpComunaEstudio.Properties.PopupFormSize = New System.Drawing.Size(161, 240)
        Me.lkpComunaEstudio.Properties.ValueMember = "ID"
        Me.lkpComunaEstudio.Properties.View = Me.GridView27
        Me.lkpComunaEstudio.Size = New System.Drawing.Size(161, 20)
        Me.lkpComunaEstudio.TabIndex = 17
        '
        'ComunaEstudioBindingSource
        '
        Me.ComunaEstudioBindingSource.DataMember = "Comuna"
        Me.ComunaEstudioBindingSource.DataSource = Me.datasetEOD
        Me.ComunaEstudioBindingSource.Filter = "id > 0"
        '
        'GridView27
        '
        Me.GridView27.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colComuna2})
        Me.GridView27.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView27.Name = "GridView27"
        Me.GridView27.OptionsBehavior.Editable = False
        Me.GridView27.OptionsCustomization.AllowFilter = False
        Me.GridView27.OptionsCustomization.AllowGroup = False
        Me.GridView27.OptionsCustomization.AllowSort = False
        Me.GridView27.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView27.OptionsView.ShowColumnHeaders = False
        Me.GridView27.OptionsView.ShowGroupPanel = False
        Me.GridView27.OptionsView.ShowIndicator = False
        '
        'colComuna2
        '
        Me.colComuna2.FieldName = "Comuna"
        Me.colComuna2.Name = "colComuna2"
        Me.colComuna2.Visible = True
        Me.colComuna2.VisibleIndex = 0
        '
        'LabelControl38
        '
        Me.LabelControl38.Location = New System.Drawing.Point(191, 5)
        Me.LabelControl38.Name = "LabelControl38"
        Me.LabelControl38.Size = New System.Drawing.Size(39, 13)
        Me.LabelControl38.TabIndex = 56
        Me.LabelControl38.Text = "Comuna"
        '
        'LabelControl39
        '
        Me.LabelControl39.Location = New System.Drawing.Point(3, 5)
        Me.LabelControl39.Name = "LabelControl39"
        Me.LabelControl39.Size = New System.Drawing.Size(176, 13)
        Me.LabelControl39.TabIndex = 55
        Me.LabelControl39.Text = "Indique su lugar de estudio principal:"
        '
        'lkpManzanaEstudio
        '
        Me.lkpManzanaEstudio.Location = New System.Drawing.Point(546, 57)
        Me.lkpManzanaEstudio.MenuManager = Me.RibbonControl
        Me.lkpManzanaEstudio.Name = "lkpManzanaEstudio"
        Me.lkpManzanaEstudio.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.lkpManzanaEstudio.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.lkpManzanaEstudio.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lkpManzanaEstudio.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkpManzanaEstudio.Properties.PopupFormMinSize = New System.Drawing.Size(104, 0)
        Me.lkpManzanaEstudio.Properties.PopupWidth = 104
        Me.lkpManzanaEstudio.Properties.ShowFooter = False
        Me.lkpManzanaEstudio.Size = New System.Drawing.Size(104, 20)
        Me.lkpManzanaEstudio.TabIndex = 22
        '
        'PersonaBindingSource
        '
        Me.PersonaBindingSource.DataMember = "Persona"
        Me.PersonaBindingSource.DataSource = Me.datasetEOD
        '
        'lkpEstudiosCompletos
        '
        Me.lkpEstudiosCompletos.EditValue = ""
        Me.lkpEstudiosCompletos.Location = New System.Drawing.Point(327, 109)
        Me.lkpEstudiosCompletos.MenuManager = Me.RibbonControl
        Me.lkpEstudiosCompletos.Name = "lkpEstudiosCompletos"
        Me.lkpEstudiosCompletos.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.lkpEstudiosCompletos.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.lkpEstudiosCompletos.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lkpEstudiosCompletos.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkpEstudiosCompletos.Properties.DataSource = Me.SiNoBindingSource
        Me.lkpEstudiosCompletos.Properties.DisplayMember = "Opcion"
        Me.lkpEstudiosCompletos.Properties.PopupFormMinSize = New System.Drawing.Size(81, 40)
        Me.lkpEstudiosCompletos.Properties.PopupFormSize = New System.Drawing.Size(81, 40)
        Me.lkpEstudiosCompletos.Properties.ShowFooter = False
        Me.lkpEstudiosCompletos.Properties.ValueMember = "Id"
        Me.lkpEstudiosCompletos.Properties.View = Me.GridView12
        Me.lkpEstudiosCompletos.Size = New System.Drawing.Size(81, 20)
        Me.lkpEstudiosCompletos.TabIndex = 6
        '
        'GridView12
        '
        Me.GridView12.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colOpcion1})
        Me.GridView12.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView12.Name = "GridView12"
        Me.GridView12.OptionsBehavior.Editable = False
        Me.GridView12.OptionsCustomization.AllowFilter = False
        Me.GridView12.OptionsCustomization.AllowGroup = False
        Me.GridView12.OptionsCustomization.AllowSort = False
        Me.GridView12.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView12.OptionsView.ShowColumnHeaders = False
        Me.GridView12.OptionsView.ShowGroupPanel = False
        Me.GridView12.OptionsView.ShowIndicator = False
        '
        'colOpcion1
        '
        Me.colOpcion1.FieldName = "Opcion"
        Me.colOpcion1.Name = "colOpcion1"
        Me.colOpcion1.Visible = True
        Me.colOpcion1.VisibleIndex = 0
        '
        'lblEstudiosCompletos
        '
        Me.lblEstudiosCompletos.Location = New System.Drawing.Point(327, 90)
        Me.lblEstudiosCompletos.Name = "lblEstudiosCompletos"
        Me.lblEstudiosCompletos.Size = New System.Drawing.Size(122, 13)
        Me.lblEstudiosCompletos.TabIndex = 11
        Me.lblEstudiosCompletos.Text = "¿Son estudios completos?"
        '
        'txtActividadOtra
        '
        Me.txtActividadOtra.Location = New System.Drawing.Point(424, 159)
        Me.txtActividadOtra.MenuManager = Me.RibbonControl
        Me.txtActividadOtra.Name = "txtActividadOtra"
        Me.txtActividadOtra.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.txtActividadOtra.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.txtActividadOtra.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtActividadOtra.Properties.Mask.EditMask = "c0"
        Me.txtActividadOtra.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtActividadOtra.Size = New System.Drawing.Size(127, 20)
        Me.txtActividadOtra.TabIndex = 9
        Me.txtActividadOtra.Visible = False
        '
        'lblActividadOtra
        '
        Me.lblActividadOtra.Location = New System.Drawing.Point(424, 140)
        Me.lblActividadOtra.Name = "lblActividadOtra"
        Me.lblActividadOtra.Size = New System.Drawing.Size(68, 13)
        Me.lblActividadOtra.TabIndex = 17
        Me.lblActividadOtra.Text = "Otra actividad"
        Me.lblActividadOtra.Visible = False
        '
        'lkpLicencia
        '
        Me.lkpLicencia.EditValue = ""
        Me.lkpLicencia.Location = New System.Drawing.Point(11, 159)
        Me.lkpLicencia.MenuManager = Me.RibbonControl
        Me.lkpLicencia.Name = "lkpLicencia"
        Me.lkpLicencia.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.lkpLicencia.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.lkpLicencia.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lkpLicencia.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkpLicencia.Properties.DataSource = Me.SiNoBindingSource
        Me.lkpLicencia.Properties.DisplayMember = "Opcion"
        Me.lkpLicencia.Properties.PopupFormMinSize = New System.Drawing.Size(92, 40)
        Me.lkpLicencia.Properties.PopupFormSize = New System.Drawing.Size(92, 40)
        Me.lkpLicencia.Properties.ShowFooter = False
        Me.lkpLicencia.Properties.ValueMember = "Id"
        Me.lkpLicencia.Properties.View = Me.GridView14
        Me.lkpLicencia.Size = New System.Drawing.Size(92, 20)
        Me.lkpLicencia.TabIndex = 7
        '
        'GridView14
        '
        Me.GridView14.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colOpcion2})
        Me.GridView14.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView14.Name = "GridView14"
        Me.GridView14.OptionsCustomization.AllowFilter = False
        Me.GridView14.OptionsCustomization.AllowGroup = False
        Me.GridView14.OptionsCustomization.AllowSort = False
        Me.GridView14.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView14.OptionsView.ShowColumnHeaders = False
        Me.GridView14.OptionsView.ShowGroupPanel = False
        Me.GridView14.OptionsView.ShowIndicator = False
        '
        'colOpcion2
        '
        Me.colOpcion2.FieldName = "Opcion"
        Me.colOpcion2.Name = "colOpcion2"
        Me.colOpcion2.Visible = True
        Me.colOpcion2.VisibleIndex = 0
        '
        'LabelControl22
        '
        Me.LabelControl22.Location = New System.Drawing.Point(168, 140)
        Me.LabelControl22.Name = "LabelControl22"
        Me.LabelControl22.Size = New System.Drawing.Size(148, 13)
        Me.LabelControl22.TabIndex = 15
        Me.LabelControl22.Text = "¿A qué se dedica actualmente?"
        '
        'lblLicencia
        '
        Me.lblLicencia.Location = New System.Drawing.Point(8, 140)
        Me.lblLicencia.Name = "lblLicencia"
        Me.lblLicencia.Size = New System.Drawing.Size(131, 13)
        Me.lblLicencia.TabIndex = 13
        Me.lblLicencia.Text = "¿Tiene licencia de conducir?"
        '
        'chkActividad
        '
        Me.chkActividad.EditValue = ""
        Me.chkActividad.Location = New System.Drawing.Point(168, 159)
        Me.chkActividad.MenuManager = Me.RibbonControl
        Me.chkActividad.Name = "chkActividad"
        Me.chkActividad.Properties.AllowMultiSelect = True
        Me.chkActividad.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.chkActividad.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.chkActividad.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.chkActividad.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.chkActividad.Properties.DataSource = Me.ActividadBindingSource
        Me.chkActividad.Properties.DisplayMember = "Actividad"
        Me.chkActividad.Properties.NullText = "[Vacío]"
        Me.chkActividad.Properties.PopupFormMinSize = New System.Drawing.Size(231, 120)
        Me.chkActividad.Properties.PopupFormSize = New System.Drawing.Size(231, 120)
        Me.chkActividad.Properties.SelectAllItemVisible = False
        Me.chkActividad.Properties.ValueMember = "ID"
        Me.chkActividad.Size = New System.Drawing.Size(231, 20)
        Me.chkActividad.TabIndex = 8
        '
        'ActividadBindingSource
        '
        Me.ActividadBindingSource.DataMember = "Actividad"
        Me.ActividadBindingSource.DataSource = Me.datasetEOD
        '
        'LabelControl15
        '
        Me.LabelControl15.Location = New System.Drawing.Point(11, 90)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(142, 13)
        Me.LabelControl15.TabIndex = 39
        Me.LabelControl15.Text = "¿Cuál es su nivel de estudios?"
        '
        'lkpEstudios
        '
        Me.lkpEstudios.EditValue = ""
        Me.lkpEstudios.Location = New System.Drawing.Point(11, 109)
        Me.lkpEstudios.MenuManager = Me.RibbonControl
        Me.lkpEstudios.Name = "lkpEstudios"
        Me.lkpEstudios.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.lkpEstudios.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.lkpEstudios.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lkpEstudios.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkpEstudios.Properties.DataSource = Me.EstudiosBindingSource
        Me.lkpEstudios.Properties.DisplayMember = "Estudio"
        Me.lkpEstudios.Properties.PopupFormMinSize = New System.Drawing.Size(298, 120)
        Me.lkpEstudios.Properties.PopupFormSize = New System.Drawing.Size(298, 120)
        Me.lkpEstudios.Properties.ShowFooter = False
        Me.lkpEstudios.Properties.ValueMember = "ID"
        Me.lkpEstudios.Properties.View = Me.GridView11
        Me.lkpEstudios.Size = New System.Drawing.Size(298, 20)
        Me.lkpEstudios.TabIndex = 5
        '
        'EstudiosBindingSource
        '
        Me.EstudiosBindingSource.DataMember = "Estudios"
        Me.EstudiosBindingSource.DataSource = Me.datasetEOD
        '
        'GridView11
        '
        Me.GridView11.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colEstudio})
        Me.GridView11.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView11.Name = "GridView11"
        Me.GridView11.OptionsBehavior.Editable = False
        Me.GridView11.OptionsCustomization.AllowFilter = False
        Me.GridView11.OptionsCustomization.AllowGroup = False
        Me.GridView11.OptionsCustomization.AllowSort = False
        Me.GridView11.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView11.OptionsView.ShowColumnHeaders = False
        Me.GridView11.OptionsView.ShowGroupPanel = False
        Me.GridView11.OptionsView.ShowIndicator = False
        '
        'colEstudio
        '
        Me.colEstudio.FieldName = "Estudio"
        Me.colEstudio.Name = "colEstudio"
        Me.colEstudio.Visible = True
        Me.colEstudio.VisibleIndex = 0
        '
        'LabelControl14
        '
        Me.LabelControl14.Location = New System.Drawing.Point(463, 45)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(198, 13)
        Me.LabelControl14.TabIndex = 37
        Me.LabelControl14.Text = "¿Cuál es su relación con el jefe de hogar?"
        '
        'RelacionBindingSource
        '
        Me.RelacionBindingSource.DataMember = "Relacion"
        Me.RelacionBindingSource.DataSource = Me.datasetEOD
        '
        'LabelControl13
        '
        Me.LabelControl13.Location = New System.Drawing.Point(327, 45)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(62, 13)
        Me.LabelControl13.TabIndex = 34
        Me.LabelControl13.Text = "¿Su sexo es?"
        '
        'LabelControl12
        '
        Me.LabelControl12.Location = New System.Drawing.Point(168, 45)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(126, 13)
        Me.LabelControl12.TabIndex = 31
        Me.LabelControl12.Text = "¿Su año de nacimiento es?"
        '
        'SexoBindingSource
        '
        Me.SexoBindingSource.DataMember = "Sexo"
        Me.SexoBindingSource.DataSource = Me.datasetEOD
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(11, 45)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(95, 13)
        Me.LabelControl2.TabIndex = 28
        Me.LabelControl2.Text = "¿Su nombre de pila?"
        '
        'PersonaTableAdapter
        '
        Me.PersonaTableAdapter.ClearBeforeFill = True
        '
        'SexoTableAdapter
        '
        Me.SexoTableAdapter.ClearBeforeFill = True
        '
        'RelacionTableAdapter
        '
        Me.RelacionTableAdapter.ClearBeforeFill = True
        '
        'EstudiosTableAdapter
        '
        Me.EstudiosTableAdapter.ClearBeforeFill = True
        '
        'SiNoTableAdapter
        '
        Me.SiNoTableAdapter.ClearBeforeFill = True
        '
        'ActividadTableAdapter
        '
        Me.ActividadTableAdapter.ClearBeforeFill = True
        '
        'ComunaTableAdapter
        '
        Me.ComunaTableAdapter.ClearBeforeFill = True
        '
        'CallesTableAdapter
        '
        Me.CallesTableAdapter.ClearBeforeFill = True
        '
        'HitoTableAdapter
        '
        Me.HitoTableAdapter.ClearBeforeFill = True
        '
        'JornadaTrabajoTableAdapter
        '
        Me.JornadaTrabajoTableAdapter.ClearBeforeFill = True
        '
        'DondeEstudiaTableAdapter
        '
        Me.DondeEstudiaTableAdapter.ClearBeforeFill = True
        '
        'lkpRelacion
        '
        Me.lkpRelacion.EditValue = ""
        Me.lkpRelacion.Location = New System.Drawing.Point(463, 64)
        Me.lkpRelacion.MenuManager = Me.RibbonControl
        Me.lkpRelacion.Name = "lkpRelacion"
        Me.lkpRelacion.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.lkpRelacion.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.lkpRelacion.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lkpRelacion.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkpRelacion.Properties.DataSource = Me.RelacionBindingSource
        Me.lkpRelacion.Properties.DisplayMember = "Relacion"
        Me.lkpRelacion.Properties.PopupFormMinSize = New System.Drawing.Size(198, 160)
        Me.lkpRelacion.Properties.PopupFormSize = New System.Drawing.Size(198, 160)
        Me.lkpRelacion.Properties.ShowFooter = False
        Me.lkpRelacion.Properties.ValueMember = "ID"
        Me.lkpRelacion.Properties.View = Me.GridView1
        Me.lkpRelacion.Size = New System.Drawing.Size(198, 20)
        Me.lkpRelacion.TabIndex = 4
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1})
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsCustomization.AllowFilter = False
        Me.GridView1.OptionsCustomization.AllowGroup = False
        Me.GridView1.OptionsCustomization.AllowSort = False
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowColumnHeaders = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.OptionsView.ShowIndicator = False
        '
        'GridColumn1
        '
        Me.GridColumn1.FieldName = "Relacion"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        '
        'txtAnoNacimiento
        '
        Me.txtAnoNacimiento.Location = New System.Drawing.Point(168, 64)
        Me.txtAnoNacimiento.MenuManager = Me.RibbonControl
        Me.txtAnoNacimiento.Name = "txtAnoNacimiento"
        Me.txtAnoNacimiento.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.txtAnoNacimiento.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.txtAnoNacimiento.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtAnoNacimiento.Properties.Mask.EditMask = "f0"
        Me.txtAnoNacimiento.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtAnoNacimiento.Size = New System.Drawing.Size(48, 20)
        Me.txtAnoNacimiento.TabIndex = 2
        '
        'txtNombrePila
        '
        Me.txtNombrePila.Location = New System.Drawing.Point(11, 64)
        Me.txtNombrePila.MenuManager = Me.RibbonControl
        Me.txtNombrePila.Name = "txtNombrePila"
        Me.txtNombrePila.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.txtNombrePila.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.txtNombrePila.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtNombrePila.Size = New System.Drawing.Size(142, 20)
        Me.txtNombrePila.TabIndex = 1
        '
        'lkpSexo
        '
        Me.lkpSexo.EditValue = ""
        Me.lkpSexo.Location = New System.Drawing.Point(327, 64)
        Me.lkpSexo.MenuManager = Me.RibbonControl
        Me.lkpSexo.Name = "lkpSexo"
        Me.lkpSexo.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.lkpSexo.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.lkpSexo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lkpSexo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkpSexo.Properties.DataSource = Me.SexoBindingSource
        Me.lkpSexo.Properties.DisplayMember = "Sexo"
        Me.lkpSexo.Properties.PopupFormMinSize = New System.Drawing.Size(92, 60)
        Me.lkpSexo.Properties.PopupFormSize = New System.Drawing.Size(92, 60)
        Me.lkpSexo.Properties.ShowFooter = False
        Me.lkpSexo.Properties.ValueMember = "ID"
        Me.lkpSexo.Properties.View = Me.GridView2
        Me.lkpSexo.Size = New System.Drawing.Size(92, 20)
        Me.lkpSexo.TabIndex = 3
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn2})
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsBehavior.Editable = False
        Me.GridView2.OptionsCustomization.AllowFilter = False
        Me.GridView2.OptionsCustomization.AllowGroup = False
        Me.GridView2.OptionsCustomization.AllowSort = False
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ShowColumnHeaders = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        Me.GridView2.OptionsView.ShowIndicator = False
        '
        'GridColumn2
        '
        Me.GridColumn2.FieldName = "Sexo"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 0
        '
        'SplashScreenManager1
        '
        Me.SplashScreenManager1.ClosingDelay = 500
        '
        'cargaPersonaBackground
        '
        '
        'ValidaPersonaTableAdapter
        '
        Me.ValidaPersonaTableAdapter.ClearBeforeFill = True
        '
        'btnIngresos
        '
        Me.btnIngresos.Appearance.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnIngresos.Appearance.BackColor2 = System.Drawing.SystemColors.HotTrack
        Me.btnIngresos.Appearance.BorderColor = System.Drawing.SystemColors.HotTrack
        Me.btnIngresos.Appearance.ForeColor = System.Drawing.Color.White
        Me.btnIngresos.Appearance.Options.UseBackColor = True
        Me.btnIngresos.Appearance.Options.UseBorderColor = True
        Me.btnIngresos.Appearance.Options.UseForeColor = True
        Me.btnIngresos.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
        Me.btnIngresos.Location = New System.Drawing.Point(11, 449)
        Me.btnIngresos.Name = "btnIngresos"
        Me.btnIngresos.Size = New System.Drawing.Size(128, 28)
        Me.btnIngresos.TabIndex = 101
        Me.btnIngresos.Text = "Reportar Ingresos"
        '
        'ConsultaCalle2TrabajoBindingSource
        '
        Me.ConsultaCalle2TrabajoBindingSource.DataMember = "ConsultaCalle2Trabajo"
        Me.ConsultaCalle2TrabajoBindingSource.DataSource = Me.datasetEOD
        '
        'ConsultaCalle2TrabajoTableAdapter
        '
        Me.ConsultaCalle2TrabajoTableAdapter.ClearBeforeFill = True
        '
        'ConsultaCalle2EstudioBindingSource
        '
        Me.ConsultaCalle2EstudioBindingSource.DataMember = "ConsultaCalle2Estudio"
        Me.ConsultaCalle2EstudioBindingSource.DataSource = Me.datasetEOD
        '
        'ConsultaCalle2EstudioTableAdapter
        '
        Me.ConsultaCalle2EstudioTableAdapter.ClearBeforeFill = True
        '
        'ModificarPersona
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(676, 489)
        Me.Controls.Add(Me.btnIngresos)
        Me.Controls.Add(Me.lkpSexo)
        Me.Controls.Add(Me.txtNombrePila)
        Me.Controls.Add(Me.txtAnoNacimiento)
        Me.Controls.Add(Me.lkpRelacion)
        Me.Controls.Add(Me.txtActividadOtra)
        Me.Controls.Add(Me.lkpEstudiosCompletos)
        Me.Controls.Add(Me.lblActividadOtra)
        Me.Controls.Add(Me.lblEstudiosCompletos)
        Me.Controls.Add(Me.LabelControl22)
        Me.Controls.Add(Me.lkpLicencia)
        Me.Controls.Add(Me.chkActividad)
        Me.Controls.Add(Me.btnCancelarPersona)
        Me.Controls.Add(Me.lblLicencia)
        Me.Controls.Add(Me.btnGuardarPersona)
        Me.Controls.Add(Me.spcTrabajaEstudia)
        Me.Controls.Add(Me.LabelControl15)
        Me.Controls.Add(Me.lkpEstudios)
        Me.Controls.Add(Me.LabelControl14)
        Me.Controls.Add(Me.LabelControl13)
        Me.Controls.Add(Me.LabelControl12)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.RibbonControl)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ModificarPersona"
        Me.Ribbon = Me.RibbonControl
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modificando persona"
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spcTrabajaEstudia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.spcTrabajaEstudia.ResumeLayout(False)
        CType(Me.y_trabajo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkpJornadaTrabajo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JornadaTrabajoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.datasetEOD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.x_trabajo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkpHitoTrabajo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HitoTrabajoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkpCalle2Trabajo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkpCalle1Trabajo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Calle1TrabajoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtComunaTrabajoOtra.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkpComunaTrabajo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComunaTrabajoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkpManzanaTrabajo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDondeEstudiaOtro.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.y_estudio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkpTieneTNE.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SiNoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView28, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.x_estudio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkpDondeEstudia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DondeEstudiaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkpHitoEstudio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HitoEstudioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView24, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkpCalle2Estudio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView25, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkpCalle1Estudio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Calle1EstudioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView26, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtComunaEstudioOtra.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkpComunaEstudio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComunaEstudioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView27, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkpManzanaEstudio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PersonaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkpEstudiosCompletos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtActividadOtra.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkpLicencia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkActividad.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ActividadBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkpEstudios.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstudiosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RelacionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SexoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkpRelacion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAnoNacimiento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombrePila.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkpSexo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConsultaCalle2TrabajoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConsultaCalle2EstudioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents btnCancelarPersona As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnGuardarPersona As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents spcTrabajaEstudia As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents y_trabajo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lkpJornadaTrabajo As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView21 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colJornadaTrabajo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl47 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl31 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents x_trabajo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lkpHitoTrabajo As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView20 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colhito As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lblManzanaTrabajo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblHitoTrabajo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lkpCalle2Trabajo As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView18 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colcalle2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkpCalle1Trabajo As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView17 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colcalle As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lblCalle2Trabajo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblCalle1Trabajo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtComunaTrabajoOtra As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblComunaTrabajoOtra As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lkpComunaTrabajo As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView16 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colComuna1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl25 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl24 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lkpManzanaTrabajo As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents y_estudio As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl48 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lkpTieneTNE As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView28 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colOpcion3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents x_estudio As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl40 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl49 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lkpDondeEstudia As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView22 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colDondeEstudia As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl32 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lkpHitoEstudio As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView24 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colhito1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lblManzanaEstudio As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblHitoEstudio As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lkpCalle2Estudio As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView25 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colcalle21 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkpCalle1Estudio As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView26 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colcalle1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lblCalle2Estudio As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblCalle1Estudio As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtComunaEstudioOtra As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblComunaEstudioOtra As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lkpComunaEstudio As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView27 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colComuna2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl38 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl39 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lkpManzanaEstudio As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lkpEstudiosCompletos As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView12 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colOpcion1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lblEstudiosCompletos As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtActividadOtra As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblActividadOtra As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lkpLicencia As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView14 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colOpcion2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl22 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblLicencia As DevExpress.XtraEditors.LabelControl
    Friend WithEvents chkActividad As DevExpress.XtraEditors.CheckedComboBoxEdit
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lkpEstudios As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView11 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colEstudio As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PersonaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents datasetEOD As EOD.datasetEOD
    Friend WithEvents PersonaTableAdapter As EOD.datasetEODTableAdapters.PersonaTableAdapter
    Friend WithEvents SexoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SexoTableAdapter As EOD.datasetEODTableAdapters.SexoTableAdapter
    Friend WithEvents RelacionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RelacionTableAdapter As EOD.datasetEODTableAdapters.RelacionTableAdapter
    Friend WithEvents EstudiosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EstudiosTableAdapter As EOD.datasetEODTableAdapters.EstudiosTableAdapter
    Friend WithEvents SiNoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SiNoTableAdapter As EOD.datasetEODTableAdapters.SiNoTableAdapter
    Friend WithEvents ActividadBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ActividadTableAdapter As EOD.datasetEODTableAdapters.ActividadTableAdapter
    Friend WithEvents ComunaTrabajoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ComunaTableAdapter As EOD.datasetEODTableAdapters.ComunaTableAdapter
    Friend WithEvents Calle1TrabajoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CallesTableAdapter As EOD.datasetEODTableAdapters.CallesTableAdapter
    Friend WithEvents HitoTrabajoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents HitoTableAdapter As EOD.datasetEODTableAdapters.HitoTableAdapter
    Friend WithEvents JornadaTrabajoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents JornadaTrabajoTableAdapter As EOD.datasetEODTableAdapters.JornadaTrabajoTableAdapter
    Friend WithEvents HitoEstudioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Calle1EstudioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ComunaEstudioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DondeEstudiaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DondeEstudiaTableAdapter As EOD.datasetEODTableAdapters.DondeEstudiaTableAdapter
    Friend WithEvents lkpRelacion As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtAnoNacimiento As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNombrePila As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lkpSexo As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cargaPersonaBackground As System.ComponentModel.BackgroundWorker
    Friend WithEvents SplashScreenManager1 As DevExpress.XtraSplashScreen.SplashScreenManager
    Friend WithEvents ValidaPersonaTableAdapter As EOD.datasetEODTableAdapters.ValidaPersonaTableAdapter
    Friend WithEvents btnIngresos As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtDondeEstudiaOtro As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblDondeEstudiaOtro As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ConsultaCalle2TrabajoBindingSource As BindingSource
    Friend WithEvents ConsultaCalle2TrabajoTableAdapter As datasetEODTableAdapters.ConsultaCalle2TrabajoTableAdapter
    Friend WithEvents ConsultaCalle2EstudioBindingSource As BindingSource
    Friend WithEvents ConsultaCalle2EstudioTableAdapter As datasetEODTableAdapters.ConsultaCalle2EstudioTableAdapter
End Class
