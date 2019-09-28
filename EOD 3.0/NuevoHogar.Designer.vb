<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NuevoHogar
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
        Me.tabPaneHogar = New DevExpress.XtraBars.Navigation.TabPane()
        Me.tabPageHogar = New DevExpress.XtraBars.Navigation.TabNavigationPage()
        Me.btnCancelarHogar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnGuardarHogar = New DevExpress.XtraEditors.SimpleButton()
        Me.lkpTieneVeh = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.SiNoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.datasetEOD = New EOD.datasetEOD()
        Me.GridView9 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colOpcion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelControl21 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.lblMontoGFT = New DevExpress.XtraEditors.LabelControl()
        Me.lkpIndicaGFT = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView15 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtMontoGFT = New DevExpress.XtraEditors.TextEdit()
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
        Me.PropiedadBindingSource = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.TipoViviendaActualBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView29 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colTipoViviendaActual = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelControl44 = New DevExpress.XtraEditors.LabelControl()
        Me.lblComunaOtra = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.lkpComuna = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.ComunaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView6 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colComuna = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCasaDepto = New DevExpress.XtraEditors.TextEdit()
        Me.txtComunaOtra = New DevExpress.XtraEditors.TextEdit()
        Me.txtNumero = New DevExpress.XtraEditors.TextEdit()
        Me.txtCalle = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.lkpManzana = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.ManzanasCatBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colZonaEOD1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colManzana = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.lkpZona = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.ZonasCatBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colZonaEOD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.lkpFolio = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.CatastroHogaresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView5 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colIDFolio = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.tabPageVehículos = New DevExpress.XtraBars.Navigation.TabNavigationPage()
        Me.btnRechazoVehiculo = New DevExpress.XtraEditors.SimpleButton()
        Me.gcVehRegistrados = New DevExpress.XtraEditors.GroupControl()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.ResumenVehiculosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView7 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colHogar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVehículo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colvehiculo1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTipoMotor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnCancelarVeh = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.lkpTipoMotor = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.TipoMotorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView19 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelControl26 = New DevExpress.XtraEditors.LabelControl()
        Me.txtAnioFabricacion = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl23 = New DevExpress.XtraEditors.LabelControl()
        Me.lkpOtroVeh = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView13 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colOpcion5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.txtPropiedadVehOtro = New DevExpress.XtraEditors.TextEdit()
        Me.lblPropiedadVehOtro = New DevExpress.XtraEditors.LabelControl()
        Me.lkpPropiedadVeh = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.PropiedadVehiculoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPropiedadVehiculo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.lkpTipoVeh = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.TipoVehBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colvehiculo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnGuardarVehiculo = New DevExpress.XtraEditors.SimpleButton()
        Me.tabPagePersonas = New DevExpress.XtraBars.Navigation.TabNavigationPage()
        Me.btnRechazoPersona = New DevExpress.XtraEditors.SimpleButton()
        Me.lkpOtraPersona = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView30 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colOpcion4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelControl46 = New DevExpress.XtraEditors.LabelControl()
        Me.btnCancelarPersona = New DevExpress.XtraEditors.SimpleButton()
        Me.btnGuardarPersona = New DevExpress.XtraEditors.SimpleButton()
        Me.gcPerRegistradas = New DevExpress.XtraEditors.GroupControl()
        Me.gridPersonas = New DevExpress.XtraGrid.GridControl()
        Me.ResumenPersonasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.gridPersonasHogar = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colHogar1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPersona = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNombrePila = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSexo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRelacion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.spcTrabajaEstudia = New DevExpress.XtraEditors.SplitContainerControl()
        Me.y_trabajo = New DevExpress.XtraEditors.TextEdit()
        Me.lkpJornadaTrabajo = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.JornadaTrabajoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.ConsultaCalle2TrabajoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.ConsultaCalle2EstudioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.splitEstudios = New DevExpress.XtraEditors.SplitContainerControl()
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
        Me.lkpRelacion = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.RelacionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView10 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colRelacion1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.txtAnoNacimiento = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.txtNombrePila = New DevExpress.XtraEditors.TextEdit()
        Me.lkpSexo = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.SexoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridLookUpEdit3View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSexo1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.tabPageFecha = New DevExpress.XtraBars.Navigation.TabNavigationPage()
        Me.spcDiscapacidad = New DevExpress.XtraEditors.SplitContainerControl()
        Me.LabelControl30 = New DevExpress.XtraEditors.LabelControl()
        Me.lkpPersonaAutosuficiente = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView32 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.lkpTipoDiscapacidad = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.TipoDiscapacidadBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView31 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelControl33 = New DevExpress.XtraEditors.LabelControl()
        Me.lblNotaLV = New DevExpress.XtraEditors.LabelControl()
        Me.deDomingoLV = New DevExpress.XtraEditors.DateEdit()
        Me.lblDomingoLV = New DevExpress.XtraEditors.LabelControl()
        Me.deSabadoLV = New DevExpress.XtraEditors.DateEdit()
        Me.lblSabadoLV = New DevExpress.XtraEditors.LabelControl()
        Me.deFechaViajes = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl43 = New DevExpress.XtraEditors.LabelControl()
        Me.lkpTipoDia = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.TipoDiaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridLookUpEdit28View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colTipoDia = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelControl42 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl41 = New DevExpress.XtraEditors.LabelControl()
        Me.txtObservacion = New DevExpress.XtraEditors.MemoEdit()
        Me.lkpPersonaDiscapacidad = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView23 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelControl29 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl28 = New DevExpress.XtraEditors.LabelControl()
        Me.btnRechazoFecha = New DevExpress.XtraEditors.SimpleButton()
        Me.btnGuardarEncuesta = New DevExpress.XtraEditors.SimpleButton()
        Me.ResumenVehiculosTableAdapter = New EOD.datasetEODTableAdapters.ResumenVehiculosTableAdapter()
        Me.ResumenPersonasTableAdapter = New EOD.datasetEODTableAdapters.ResumenPersonasTableAdapter()
        Me.ComunaTableAdapter = New EOD.datasetEODTableAdapters.ComunaTableAdapter()
        Me.PropiedadTableAdapter = New EOD.datasetEODTableAdapters.PropiedadTableAdapter()
        Me.TipoVehTableAdapter = New EOD.datasetEODTableAdapters.TipoVehTableAdapter()
        Me.PropiedadVehiculoTableAdapter = New EOD.datasetEODTableAdapters.PropiedadVehiculoTableAdapter()
        Me.SexoTableAdapter = New EOD.datasetEODTableAdapters.SexoTableAdapter()
        Me.RelacionTableAdapter = New EOD.datasetEODTableAdapters.RelacionTableAdapter()
        Me.EstudiosTableAdapter = New EOD.datasetEODTableAdapters.EstudiosTableAdapter()
        Me.SiNoTableAdapter = New EOD.datasetEODTableAdapters.SiNoTableAdapter()
        Me.ActividadTableAdapter = New EOD.datasetEODTableAdapters.ActividadTableAdapter()
        Me.JornadaTrabajoTableAdapter = New EOD.datasetEODTableAdapters.JornadaTrabajoTableAdapter()
        Me.DondeEstudiaTableAdapter = New EOD.datasetEODTableAdapters.DondeEstudiaTableAdapter()
        Me.TipoDiaTableAdapter = New EOD.datasetEODTableAdapters.TipoDiaTableAdapter()
        Me.CatastroHogaresTableAdapter = New EOD.datasetEODTableAdapters.CatastroHogaresTableAdapter()
        Me.ManzanasCatTableAdapter = New EOD.datasetEODTableAdapters.ManzanasCatTableAdapter()
        Me.ZonasCatTableAdapter = New EOD.datasetEODTableAdapters.ZonasCatTableAdapter()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.CallesTableAdapter = New EOD.datasetEODTableAdapters.CallesTableAdapter()
        Me.HitoTableAdapter = New EOD.datasetEODTableAdapters.HitoTableAdapter()
        Me.TipoViviendaActualTableAdapter = New EOD.datasetEODTableAdapters.TipoViviendaActualTableAdapter()
        Me.ResumenHogaresTableAdapter1 = New EOD.datasetEODTableAdapters.ResumenHogaresTableAdapter()
        Me.CatastroHogaresTableAdapter1 = New EOD.datasetEODTableAdapters.CatastroHogaresTableAdapter()
        Me.cargaPreguntasHogar = New System.ComponentModel.BackgroundWorker()
        Me.cargaPreguntasVehiculo = New System.ComponentModel.BackgroundWorker()
        Me.cargaPreguntasPersona = New System.ComponentModel.BackgroundWorker()
        Me.cargaPreguntasFecha = New System.ComponentModel.BackgroundWorker()
        Me.ValidaHogarTableAdapter = New EOD.datasetEODTableAdapters.ValidaHogarTableAdapter()
        Me.ValidaPersonaTableAdapter = New EOD.datasetEODTableAdapters.ValidaPersonaTableAdapter()
        Me.ConsultaCalle2TrabajoTableAdapter = New EOD.datasetEODTableAdapters.ConsultaCalle2TrabajoTableAdapter()
        Me.ConsultaCalle2EstudioTableAdapter = New EOD.datasetEODTableAdapters.ConsultaCalle2EstudioTableAdapter()
        Me.TipoMotorTableAdapter = New EOD.datasetEODTableAdapters.TipoMotorTableAdapter()
        Me.TipoDiscapacidadTableAdapter = New EOD.datasetEODTableAdapters.TipoDiscapacidadTableAdapter()
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tabPaneHogar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabPaneHogar.SuspendLayout()
        Me.tabPageHogar.SuspendLayout()
        CType(Me.lkpTieneVeh.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SiNoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.datasetEOD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.lkpIndicaGFT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMontoGFT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        CType(Me.PropiedadBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.txtReferenciaHogar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTelefono.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkpTipoVivienda.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TipoViviendaActualBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView29, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkpComuna.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComunaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCasaDepto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtComunaOtra.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNumero.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCalle.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkpManzana.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ManzanasCatBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkpZona.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ZonasCatBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkpFolio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CatastroHogaresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabPageVehículos.SuspendLayout()
        CType(Me.gcVehRegistrados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gcVehRegistrados.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ResumenVehiculosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.lkpTipoMotor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TipoMotorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAnioFabricacion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkpOtroVeh.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPropiedadVehOtro.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkpPropiedadVeh.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PropiedadVehiculoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkpTipoVeh.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TipoVehBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabPagePersonas.SuspendLayout()
        CType(Me.lkpOtraPersona.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView30, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcPerRegistradas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gcPerRegistradas.SuspendLayout()
        CType(Me.gridPersonas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ResumenPersonasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridPersonasHogar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spcTrabajaEstudia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.spcTrabajaEstudia.SuspendLayout()
        CType(Me.y_trabajo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkpJornadaTrabajo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JornadaTrabajoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.x_trabajo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkpHitoTrabajo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HitoTrabajoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkpCalle2Trabajo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConsultaCalle2TrabajoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        CType(Me.GridView28, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.x_estudio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkpDondeEstudia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DondeEstudiaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkpHitoEstudio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HitoEstudioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView24, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkpCalle2Estudio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConsultaCalle2EstudioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView25, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkpCalle1Estudio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Calle1EstudioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView26, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtComunaEstudioOtra.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkpComunaEstudio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComunaEstudioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView27, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkpManzanaEstudio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.splitEstudios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitEstudios.SuspendLayout()
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
        CType(Me.lkpRelacion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RelacionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAnoNacimiento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombrePila.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkpSexo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SexoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit3View, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabPageFecha.SuspendLayout()
        CType(Me.spcDiscapacidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.spcDiscapacidad.SuspendLayout()
        CType(Me.lkpPersonaAutosuficiente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView32, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkpTipoDiscapacidad.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TipoDiscapacidadBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView31, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deDomingoLV.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deDomingoLV.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deSabadoLV.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deSabadoLV.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deFechaViajes.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deFechaViajes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkpTipoDia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TipoDiaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit28View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtObservacion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkpPersonaDiscapacidad.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.RibbonControl.Size = New System.Drawing.Size(984, 32)
        Me.RibbonControl.Toolbar.ShowCustomizeItem = False
        '
        'tabPaneHogar
        '
        Me.tabPaneHogar.Controls.Add(Me.tabPageHogar)
        Me.tabPaneHogar.Controls.Add(Me.tabPageVehículos)
        Me.tabPaneHogar.Controls.Add(Me.tabPagePersonas)
        Me.tabPaneHogar.Controls.Add(Me.tabPageFecha)
        Me.tabPaneHogar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabPaneHogar.Location = New System.Drawing.Point(0, 32)
        Me.tabPaneHogar.Name = "tabPaneHogar"
        Me.tabPaneHogar.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.tabPageHogar, Me.tabPageVehículos, Me.tabPagePersonas, Me.tabPageFecha})
        Me.tabPaneHogar.RegularSize = New System.Drawing.Size(984, 495)
        Me.tabPaneHogar.SelectedPage = Me.tabPageVehículos
        Me.tabPaneHogar.Size = New System.Drawing.Size(984, 495)
        Me.tabPaneHogar.TabIndex = 2
        Me.tabPaneHogar.Text = "TabPane1"
        '
        'tabPageHogar
        '
        Me.tabPageHogar.Caption = "1. Datos de la vivienda"
        Me.tabPageHogar.Controls.Add(Me.btnCancelarHogar)
        Me.tabPageHogar.Controls.Add(Me.btnGuardarHogar)
        Me.tabPageHogar.Controls.Add(Me.lkpTieneVeh)
        Me.tabPageHogar.Controls.Add(Me.LabelControl21)
        Me.tabPageHogar.Controls.Add(Me.GroupControl3)
        Me.tabPageHogar.Controls.Add(Me.GroupControl2)
        Me.tabPageHogar.Name = "tabPageHogar"
        Me.tabPageHogar.Size = New System.Drawing.Size(966, 451)
        '
        'btnCancelarHogar
        '
        Me.btnCancelarHogar.Appearance.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnCancelarHogar.Appearance.BackColor2 = System.Drawing.SystemColors.HotTrack
        Me.btnCancelarHogar.Appearance.BorderColor = System.Drawing.SystemColors.HotTrack
        Me.btnCancelarHogar.Appearance.ForeColor = System.Drawing.Color.White
        Me.btnCancelarHogar.Appearance.Options.UseBackColor = True
        Me.btnCancelarHogar.Appearance.Options.UseBorderColor = True
        Me.btnCancelarHogar.Appearance.Options.UseForeColor = True
        Me.btnCancelarHogar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
        Me.btnCancelarHogar.Location = New System.Drawing.Point(842, 364)
        Me.btnCancelarHogar.Name = "btnCancelarHogar"
        Me.btnCancelarHogar.Size = New System.Drawing.Size(85, 28)
        Me.btnCancelarHogar.TabIndex = 63
        Me.btnCancelarHogar.Text = "Cancelar"
        '
        'btnGuardarHogar
        '
        Me.btnGuardarHogar.Appearance.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnGuardarHogar.Appearance.BackColor2 = System.Drawing.SystemColors.HotTrack
        Me.btnGuardarHogar.Appearance.BorderColor = System.Drawing.SystemColors.HotTrack
        Me.btnGuardarHogar.Appearance.ForeColor = System.Drawing.Color.White
        Me.btnGuardarHogar.Appearance.Options.UseBackColor = True
        Me.btnGuardarHogar.Appearance.Options.UseBorderColor = True
        Me.btnGuardarHogar.Appearance.Options.UseForeColor = True
        Me.btnGuardarHogar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
        Me.btnGuardarHogar.Location = New System.Drawing.Point(751, 364)
        Me.btnGuardarHogar.Name = "btnGuardarHogar"
        Me.btnGuardarHogar.Size = New System.Drawing.Size(85, 28)
        Me.btnGuardarHogar.TabIndex = 62
        Me.btnGuardarHogar.Text = "Guardar"
        '
        'lkpTieneVeh
        '
        Me.lkpTieneVeh.EditValue = ""
        Me.lkpTieneVeh.Location = New System.Drawing.Point(819, 249)
        Me.lkpTieneVeh.MenuManager = Me.RibbonControl
        Me.lkpTieneVeh.Name = "lkpTieneVeh"
        Me.lkpTieneVeh.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.lkpTieneVeh.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.lkpTieneVeh.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lkpTieneVeh.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkpTieneVeh.Properties.DataSource = Me.SiNoBindingSource
        Me.lkpTieneVeh.Properties.DisplayMember = "Opcion"
        Me.lkpTieneVeh.Properties.ImmediatePopup = True
        Me.lkpTieneVeh.Properties.PopupFormMinSize = New System.Drawing.Size(63, 40)
        Me.lkpTieneVeh.Properties.PopupFormSize = New System.Drawing.Size(63, 40)
        Me.lkpTieneVeh.Properties.ShowFooter = False
        Me.lkpTieneVeh.Properties.ValueMember = "Id"
        Me.lkpTieneVeh.Properties.View = Me.GridView9
        Me.lkpTieneVeh.Size = New System.Drawing.Size(63, 20)
        Me.lkpTieneVeh.TabIndex = 61
        '
        'SiNoBindingSource
        '
        Me.SiNoBindingSource.DataMember = "SiNo"
        Me.SiNoBindingSource.DataSource = Me.datasetEOD
        Me.SiNoBindingSource.Filter = "id > 0"
        '
        'datasetEOD
        '
        Me.datasetEOD.DataSetName = "datasetEOD"
        Me.datasetEOD.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView9
        '
        Me.GridView9.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colOpcion})
        Me.GridView9.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView9.Name = "GridView9"
        Me.GridView9.OptionsBehavior.Editable = False
        Me.GridView9.OptionsCustomization.AllowFilter = False
        Me.GridView9.OptionsCustomization.AllowGroup = False
        Me.GridView9.OptionsCustomization.AllowSort = False
        Me.GridView9.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView9.OptionsView.ShowColumnHeaders = False
        Me.GridView9.OptionsView.ShowGroupPanel = False
        Me.GridView9.OptionsView.ShowIndicator = False
        '
        'colOpcion
        '
        Me.colOpcion.FieldName = "Opcion"
        Me.colOpcion.Name = "colOpcion"
        Me.colOpcion.Visible = True
        Me.colOpcion.VisibleIndex = 0
        '
        'LabelControl21
        '
        Me.LabelControl21.Location = New System.Drawing.Point(18, 252)
        Me.LabelControl21.Name = "LabelControl21"
        Me.LabelControl21.Size = New System.Drawing.Size(788, 13)
        Me.LabelControl21.TabIndex = 34
        Me.LabelControl21.Text = "¿La familia o algún integrante del hogar utiliza regularmente vehículos motorizad" &
    "os, sean propios, contratados, prestados o institucionales? (solo para uso parti" &
    "cular)"
        '
        'GroupControl3
        '
        Me.GroupControl3.Controls.Add(Me.lblMontoGFT)
        Me.GroupControl3.Controls.Add(Me.lkpIndicaGFT)
        Me.GroupControl3.Controls.Add(Me.txtMontoGFT)
        Me.GroupControl3.Controls.Add(Me.LabelControl27)
        Me.GroupControl3.Controls.Add(Me.splitPropiedadPago)
        Me.GroupControl3.Controls.Add(Me.LabelControl17)
        Me.GroupControl3.Controls.Add(Me.lkpPropiedad)
        Me.GroupControl3.Location = New System.Drawing.Point(3, 135)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(925, 111)
        Me.GroupControl3.TabIndex = 9
        Me.GroupControl3.Text = "Datos generales de la vivienda"
        '
        'lblMontoGFT
        '
        Me.lblMontoGFT.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblMontoGFT.Appearance.Options.UseForeColor = True
        Me.lblMontoGFT.Location = New System.Drawing.Point(535, 79)
        Me.lblMontoGFT.Name = "lblMontoGFT"
        Me.lblMontoGFT.Size = New System.Drawing.Size(34, 13)
        Me.lblMontoGFT.TabIndex = 30
        Me.lblMontoGFT.Text = "Monto:"
        Me.lblMontoGFT.Visible = False
        '
        'lkpIndicaGFT
        '
        Me.lkpIndicaGFT.EditValue = ""
        Me.lkpIndicaGFT.Location = New System.Drawing.Point(445, 76)
        Me.lkpIndicaGFT.MenuManager = Me.RibbonControl
        Me.lkpIndicaGFT.Name = "lkpIndicaGFT"
        Me.lkpIndicaGFT.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.lkpIndicaGFT.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.lkpIndicaGFT.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lkpIndicaGFT.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkpIndicaGFT.Properties.DataSource = Me.SiNoBindingSource
        Me.lkpIndicaGFT.Properties.DisplayMember = "Opcion"
        Me.lkpIndicaGFT.Properties.ImmediatePopup = True
        Me.lkpIndicaGFT.Properties.PopupFormMinSize = New System.Drawing.Size(63, 40)
        Me.lkpIndicaGFT.Properties.PopupFormSize = New System.Drawing.Size(63, 40)
        Me.lkpIndicaGFT.Properties.ShowFooter = False
        Me.lkpIndicaGFT.Properties.ValueMember = "Id"
        Me.lkpIndicaGFT.Properties.View = Me.GridView15
        Me.lkpIndicaGFT.Size = New System.Drawing.Size(63, 20)
        Me.lkpIndicaGFT.TabIndex = 59
        '
        'GridView15
        '
        Me.GridView15.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1})
        Me.GridView15.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView15.Name = "GridView15"
        Me.GridView15.OptionsBehavior.Editable = False
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
        Me.GridColumn1.FieldName = "Opcion"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        '
        'txtMontoGFT
        '
        Me.txtMontoGFT.Location = New System.Drawing.Point(578, 76)
        Me.txtMontoGFT.MenuManager = Me.RibbonControl
        Me.txtMontoGFT.Name = "txtMontoGFT"
        Me.txtMontoGFT.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.txtMontoGFT.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.txtMontoGFT.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtMontoGFT.Size = New System.Drawing.Size(87, 20)
        Me.txtMontoGFT.TabIndex = 60
        Me.txtMontoGFT.Visible = False
        '
        'LabelControl27
        '
        Me.LabelControl27.Location = New System.Drawing.Point(16, 79)
        Me.LabelControl27.Name = "LabelControl27"
        Me.LabelControl27.Size = New System.Drawing.Size(414, 13)
        Me.LabelControl27.TabIndex = 28
        Me.LabelControl27.Text = "¿Nos podría indicar aproximadamente cuánto es el gasto familiar en transporte al " &
    "mes?"
        '
        'splitPropiedadPago
        '
        Me.splitPropiedadPago.Collapsed = True
        Me.splitPropiedadPago.CollapsePanel = DevExpress.XtraEditors.SplitCollapsePanel.Panel1
        Me.splitPropiedadPago.Location = New System.Drawing.Point(233, 14)
        Me.splitPropiedadPago.Name = "splitPropiedadPago"
        Me.splitPropiedadPago.Panel1.Controls.Add(Me.lblPropiedadOtra)
        Me.splitPropiedadPago.Panel1.Controls.Add(Me.txtPropiedadOtra)
        Me.splitPropiedadPago.Panel1.Text = "Panel1"
        Me.splitPropiedadPago.Panel2.Controls.Add(Me.tabsPagoVivienda)
        Me.splitPropiedadPago.Panel2.Text = "Panel2"
        Me.splitPropiedadPago.Size = New System.Drawing.Size(687, 62)
        Me.splitPropiedadPago.SplitterPosition = 112
        Me.splitPropiedadPago.TabIndex = 27
        Me.splitPropiedadPago.Text = "SplitContainerControl1"
        '
        'lblPropiedadOtra
        '
        Me.lblPropiedadOtra.Location = New System.Drawing.Point(3, 10)
        Me.lblPropiedadOtra.Name = "lblPropiedadOtra"
        Me.lblPropiedadOtra.Size = New System.Drawing.Size(22, 13)
        Me.lblPropiedadOtra.TabIndex = 23
        Me.lblPropiedadOtra.Text = "Otra"
        Me.lblPropiedadOtra.Visible = False
        '
        'txtPropiedadOtra
        '
        Me.txtPropiedadOtra.Location = New System.Drawing.Point(3, 29)
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
        Me.tabsPagoVivienda.Location = New System.Drawing.Point(3, 4)
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
        Me.chkNSNRDividendo.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.chkNSNRDividendo.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.chkNSNRDividendo.Properties.Caption = "No sabe/No responde"
        Me.chkNSNRDividendo.Size = New System.Drawing.Size(132, 19)
        Me.chkNSNRDividendo.TabIndex = 13
        '
        'txtDividendo
        '
        Me.txtDividendo.Location = New System.Drawing.Point(3, 25)
        Me.txtDividendo.MenuManager = Me.RibbonControl
        Me.txtDividendo.Name = "txtDividendo"
        Me.txtDividendo.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.txtDividendo.Properties.AppearanceFocused.Options.UseBorderColor = True
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
        Me.chkNSNRArriendo.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.chkNSNRArriendo.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.chkNSNRArriendo.Properties.Caption = "No sabe/No responde"
        Me.chkNSNRArriendo.Size = New System.Drawing.Size(132, 19)
        Me.chkNSNRArriendo.TabIndex = 15
        '
        'txtArriendo
        '
        Me.txtArriendo.Location = New System.Drawing.Point(3, 24)
        Me.txtArriendo.MenuManager = Me.RibbonControl
        Me.txtArriendo.Name = "txtArriendo"
        Me.txtArriendo.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.txtArriendo.Properties.AppearanceFocused.Options.UseBorderColor = True
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
        Me.chkNSNREstima.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.chkNSNREstima.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.chkNSNREstima.Properties.Caption = "No sabe/No responde"
        Me.chkNSNREstima.Size = New System.Drawing.Size(132, 19)
        Me.chkNSNREstima.TabIndex = 11
        '
        'txtEstimaArriendo
        '
        Me.txtEstimaArriendo.Location = New System.Drawing.Point(3, 25)
        Me.txtEstimaArriendo.MenuManager = Me.RibbonControl
        Me.txtEstimaArriendo.Name = "txtEstimaArriendo"
        Me.txtEstimaArriendo.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.txtEstimaArriendo.Properties.AppearanceFocused.Options.UseBorderColor = True
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
        Me.lkpPropiedad.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.lkpPropiedad.Properties.AppearanceFocused.Options.UseBorderColor = True
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
        'PropiedadBindingSource
        '
        Me.PropiedadBindingSource.DataMember = "Propiedad"
        Me.PropiedadBindingSource.DataSource = Me.datasetEOD
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
        Me.GroupControl2.Controls.Add(Me.lblComunaOtra)
        Me.GroupControl2.Controls.Add(Me.LabelControl10)
        Me.GroupControl2.Controls.Add(Me.lkpComuna)
        Me.GroupControl2.Controls.Add(Me.LabelControl9)
        Me.GroupControl2.Controls.Add(Me.LabelControl8)
        Me.GroupControl2.Controls.Add(Me.LabelControl7)
        Me.GroupControl2.Controls.Add(Me.txtCasaDepto)
        Me.GroupControl2.Controls.Add(Me.txtComunaOtra)
        Me.GroupControl2.Controls.Add(Me.txtNumero)
        Me.GroupControl2.Controls.Add(Me.txtCalle)
        Me.GroupControl2.Controls.Add(Me.LabelControl6)
        Me.GroupControl2.Controls.Add(Me.lkpManzana)
        Me.GroupControl2.Controls.Add(Me.LabelControl5)
        Me.GroupControl2.Controls.Add(Me.lkpZona)
        Me.GroupControl2.Controls.Add(Me.LabelControl4)
        Me.GroupControl2.Controls.Add(Me.lkpFolio)
        Me.GroupControl2.Location = New System.Drawing.Point(3, 3)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(924, 126)
        Me.GroupControl2.TabIndex = 7
        Me.GroupControl2.Text = "Ubicación del hogar"
        '
        'lblWaypoint
        '
        Me.lblWaypoint.Location = New System.Drawing.Point(658, 76)
        Me.lblWaypoint.Name = "lblWaypoint"
        Me.lblWaypoint.Size = New System.Drawing.Size(170, 13)
        Me.lblWaypoint.TabIndex = 36
        Me.lblWaypoint.Text = "Waypoint con localización del hogar"
        '
        'cbWaypoint
        '
        Me.cbWaypoint.FormattingEnabled = True
        Me.cbWaypoint.Location = New System.Drawing.Point(658, 95)
        Me.cbWaypoint.Name = "cbWaypoint"
        Me.cbWaypoint.Size = New System.Drawing.Size(208, 21)
        Me.cbWaypoint.Sorted = True
        Me.cbWaypoint.TabIndex = 24
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
        Me.txtTelefono.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.txtTelefono.Properties.AppearanceFocused.Options.UseBorderColor = True
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
        Me.lkpTipoVivienda.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.lkpTipoVivienda.Properties.AppearanceFocused.Options.UseBorderColor = True
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
        'TipoViviendaActualBindingSource
        '
        Me.TipoViviendaActualBindingSource.DataMember = "TipoViviendaActual"
        Me.TipoViviendaActualBindingSource.DataSource = Me.datasetEOD
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
        'lblComunaOtra
        '
        Me.lblComunaOtra.Location = New System.Drawing.Point(764, 24)
        Me.lblComunaOtra.Name = "lblComunaOtra"
        Me.lblComunaOtra.Size = New System.Drawing.Size(62, 13)
        Me.lblComunaOtra.TabIndex = 21
        Me.lblComunaOtra.Text = "Otra comuna"
        Me.lblComunaOtra.Visible = False
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
        Me.ComunaBindingSource.Filter = "id >0"
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
        'txtComunaOtra
        '
        Me.txtComunaOtra.Enabled = False
        Me.txtComunaOtra.Location = New System.Drawing.Point(764, 43)
        Me.txtComunaOtra.MenuManager = Me.RibbonControl
        Me.txtComunaOtra.Name = "txtComunaOtra"
        Me.txtComunaOtra.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtComunaOtra.Size = New System.Drawing.Size(100, 20)
        Me.txtComunaOtra.TabIndex = 8
        Me.txtComunaOtra.Visible = False
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
        Me.lkpManzana.Location = New System.Drawing.Point(101, 43)
        Me.lkpManzana.MenuManager = Me.RibbonControl
        Me.lkpManzana.Name = "lkpManzana"
        Me.lkpManzana.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.lkpManzana.Properties.AppearanceFocused.Options.UseBorderColor = True
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
        'ManzanasCatBindingSource
        '
        Me.ManzanasCatBindingSource.DataMember = "ManzanasCat"
        Me.ManzanasCatBindingSource.DataSource = Me.datasetEOD
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
        Me.lkpZona.Location = New System.Drawing.Point(15, 43)
        Me.lkpZona.MenuManager = Me.RibbonControl
        Me.lkpZona.Name = "lkpZona"
        Me.lkpZona.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.lkpZona.Properties.AppearanceFocused.Options.UseBorderColor = True
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
        'ZonasCatBindingSource
        '
        Me.ZonasCatBindingSource.DataMember = "ZonasCat"
        Me.ZonasCatBindingSource.DataSource = Me.datasetEOD
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
        Me.lkpFolio.Location = New System.Drawing.Point(187, 43)
        Me.lkpFolio.MenuManager = Me.RibbonControl
        Me.lkpFolio.Name = "lkpFolio"
        Me.lkpFolio.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.lkpFolio.Properties.AppearanceFocused.Options.UseBorderColor = True
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
        'CatastroHogaresBindingSource
        '
        Me.CatastroHogaresBindingSource.DataMember = "CatastroHogares"
        Me.CatastroHogaresBindingSource.DataSource = Me.datasetEOD
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
        'tabPageVehículos
        '
        Me.tabPageVehículos.Caption = "2. Datos de los vehículos"
        Me.tabPageVehículos.Controls.Add(Me.btnRechazoVehiculo)
        Me.tabPageVehículos.Controls.Add(Me.gcVehRegistrados)
        Me.tabPageVehículos.Controls.Add(Me.btnCancelarVeh)
        Me.tabPageVehículos.Controls.Add(Me.GroupControl1)
        Me.tabPageVehículos.Controls.Add(Me.btnGuardarVehiculo)
        Me.tabPageVehículos.Name = "tabPageVehículos"
        Me.tabPageVehículos.Size = New System.Drawing.Size(966, 451)
        '
        'btnRechazoVehiculo
        '
        Me.btnRechazoVehiculo.Appearance.BackColor = System.Drawing.Color.Red
        Me.btnRechazoVehiculo.Appearance.BackColor2 = System.Drawing.Color.DarkRed
        Me.btnRechazoVehiculo.Appearance.BorderColor = System.Drawing.Color.DarkRed
        Me.btnRechazoVehiculo.Appearance.ForeColor = System.Drawing.Color.White
        Me.btnRechazoVehiculo.Appearance.Options.UseBackColor = True
        Me.btnRechazoVehiculo.Appearance.Options.UseBorderColor = True
        Me.btnRechazoVehiculo.Appearance.Options.UseForeColor = True
        Me.btnRechazoVehiculo.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
        Me.btnRechazoVehiculo.Location = New System.Drawing.Point(17, 364)
        Me.btnRechazoVehiculo.Name = "btnRechazoVehiculo"
        Me.btnRechazoVehiculo.Size = New System.Drawing.Size(128, 28)
        Me.btnRechazoVehiculo.TabIndex = 40
        Me.btnRechazoVehiculo.Text = "Rechazar encuesta"
        '
        'gcVehRegistrados
        '
        Me.gcVehRegistrados.Controls.Add(Me.GridControl1)
        Me.gcVehRegistrados.Location = New System.Drawing.Point(467, 3)
        Me.gcVehRegistrados.Name = "gcVehRegistrados"
        Me.gcVehRegistrados.Size = New System.Drawing.Size(472, 389)
        Me.gcVehRegistrados.TabIndex = 39
        Me.gcVehRegistrados.Text = "Vehículos registrados en el hogar"
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.ResumenVehiculosBindingSource
        Me.GridControl1.Location = New System.Drawing.Point(16, 24)
        Me.GridControl1.MainView = Me.GridView7
        Me.GridControl1.MenuManager = Me.RibbonControl
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(451, 350)
        Me.GridControl1.TabIndex = 38
        Me.GridControl1.TabStop = False
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView7})
        '
        'ResumenVehiculosBindingSource
        '
        Me.ResumenVehiculosBindingSource.DataMember = "ResumenVehiculos"
        Me.ResumenVehiculosBindingSource.DataSource = Me.datasetEOD
        '
        'GridView7
        '
        Me.GridView7.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colHogar, Me.colVehículo, Me.colvehiculo1, Me.colTipoMotor})
        Me.GridView7.GridControl = Me.GridControl1
        Me.GridView7.Name = "GridView7"
        Me.GridView7.OptionsBehavior.Editable = False
        Me.GridView7.OptionsView.ShowGroupPanel = False
        '
        'colHogar
        '
        Me.colHogar.FieldName = "Hogar"
        Me.colHogar.Name = "colHogar"
        '
        'colVehículo
        '
        Me.colVehículo.FieldName = "Vehículo"
        Me.colVehículo.Name = "colVehículo"
        Me.colVehículo.Visible = True
        Me.colVehículo.VisibleIndex = 0
        Me.colVehículo.Width = 57
        '
        'colvehiculo1
        '
        Me.colvehiculo1.Caption = "Tipo de vehículo"
        Me.colvehiculo1.FieldName = "vehiculo"
        Me.colvehiculo1.Name = "colvehiculo1"
        Me.colvehiculo1.Visible = True
        Me.colvehiculo1.VisibleIndex = 1
        Me.colvehiculo1.Width = 327
        '
        'colTipoMotor
        '
        Me.colTipoMotor.FieldName = "TipoMotor"
        Me.colTipoMotor.Name = "colTipoMotor"
        Me.colTipoMotor.OptionsColumn.AllowEdit = False
        Me.colTipoMotor.Visible = True
        Me.colTipoMotor.VisibleIndex = 2
        Me.colTipoMotor.Width = 95
        '
        'btnCancelarVeh
        '
        Me.btnCancelarVeh.Appearance.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnCancelarVeh.Appearance.BackColor2 = System.Drawing.SystemColors.HotTrack
        Me.btnCancelarVeh.Appearance.BorderColor = System.Drawing.SystemColors.HotTrack
        Me.btnCancelarVeh.Appearance.ForeColor = System.Drawing.Color.White
        Me.btnCancelarVeh.Appearance.Options.UseBackColor = True
        Me.btnCancelarVeh.Appearance.Options.UseBorderColor = True
        Me.btnCancelarVeh.Appearance.Options.UseForeColor = True
        Me.btnCancelarVeh.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
        Me.btnCancelarVeh.Location = New System.Drawing.Point(376, 169)
        Me.btnCancelarVeh.Name = "btnCancelarVeh"
        Me.btnCancelarVeh.Size = New System.Drawing.Size(85, 28)
        Me.btnCancelarVeh.TabIndex = 8
        Me.btnCancelarVeh.Text = "Cancelar"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.lkpTipoMotor)
        Me.GroupControl1.Controls.Add(Me.LabelControl26)
        Me.GroupControl1.Controls.Add(Me.txtAnioFabricacion)
        Me.GroupControl1.Controls.Add(Me.LabelControl23)
        Me.GroupControl1.Controls.Add(Me.lkpOtroVeh)
        Me.GroupControl1.Controls.Add(Me.LabelControl11)
        Me.GroupControl1.Controls.Add(Me.txtPropiedadVehOtro)
        Me.GroupControl1.Controls.Add(Me.lblPropiedadVehOtro)
        Me.GroupControl1.Controls.Add(Me.lkpPropiedadVeh)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.lkpTipoVeh)
        Me.GroupControl1.Location = New System.Drawing.Point(3, 3)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(458, 160)
        Me.GroupControl1.TabIndex = 1
        Me.GroupControl1.Text = "Datos generales del vehículo"
        '
        'lkpTipoMotor
        '
        Me.lkpTipoMotor.EditValue = ""
        Me.lkpTipoMotor.Location = New System.Drawing.Point(152, 107)
        Me.lkpTipoMotor.MenuManager = Me.RibbonControl
        Me.lkpTipoMotor.Name = "lkpTipoMotor"
        Me.lkpTipoMotor.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.lkpTipoMotor.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.lkpTipoMotor.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lkpTipoMotor.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkpTipoMotor.Properties.DataSource = Me.TipoMotorBindingSource
        Me.lkpTipoMotor.Properties.DisplayMember = "TipoMotor"
        Me.lkpTipoMotor.Properties.ImmediatePopup = True
        Me.lkpTipoMotor.Properties.PopupFormMinSize = New System.Drawing.Size(215, 120)
        Me.lkpTipoMotor.Properties.PopupFormSize = New System.Drawing.Size(215, 120)
        Me.lkpTipoMotor.Properties.ShowFooter = False
        Me.lkpTipoMotor.Properties.ValueMember = "ID"
        Me.lkpTipoMotor.Properties.View = Me.GridView19
        Me.lkpTipoMotor.Size = New System.Drawing.Size(215, 20)
        Me.lkpTipoMotor.TabIndex = 5
        '
        'TipoMotorBindingSource
        '
        Me.TipoMotorBindingSource.DataMember = "TipoMotor"
        Me.TipoMotorBindingSource.DataSource = Me.datasetEOD
        '
        'GridView19
        '
        Me.GridView19.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn2})
        Me.GridView19.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView19.Name = "GridView19"
        Me.GridView19.OptionsCustomization.AllowFilter = False
        Me.GridView19.OptionsCustomization.AllowGroup = False
        Me.GridView19.OptionsCustomization.AllowSort = False
        Me.GridView19.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView19.OptionsView.ShowColumnHeaders = False
        Me.GridView19.OptionsView.ShowGroupPanel = False
        Me.GridView19.OptionsView.ShowIndicator = False
        '
        'GridColumn2
        '
        Me.GridColumn2.FieldName = "TipoMotor"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 0
        '
        'LabelControl26
        '
        Me.LabelControl26.Location = New System.Drawing.Point(14, 110)
        Me.LabelControl26.Name = "LabelControl26"
        Me.LabelControl26.Size = New System.Drawing.Size(124, 13)
        Me.LabelControl26.TabIndex = 14
        Me.LabelControl26.Text = "¿Qué tipo de motor tiene?"
        '
        'txtAnioFabricacion
        '
        Me.txtAnioFabricacion.Location = New System.Drawing.Point(167, 81)
        Me.txtAnioFabricacion.MenuManager = Me.RibbonControl
        Me.txtAnioFabricacion.Name = "txtAnioFabricacion"
        Me.txtAnioFabricacion.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.txtAnioFabricacion.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.txtAnioFabricacion.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtAnioFabricacion.Properties.Mask.EditMask = "n0"
        Me.txtAnioFabricacion.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtAnioFabricacion.Size = New System.Drawing.Size(102, 20)
        Me.txtAnioFabricacion.TabIndex = 4
        '
        'LabelControl23
        '
        Me.LabelControl23.Location = New System.Drawing.Point(14, 84)
        Me.LabelControl23.Name = "LabelControl23"
        Me.LabelControl23.Size = New System.Drawing.Size(147, 13)
        Me.LabelControl23.TabIndex = 10
        Me.LabelControl23.Text = "¿Cuál es el año de fabricación?"
        '
        'lkpOtroVeh
        '
        Me.lkpOtroVeh.EditValue = ""
        Me.lkpOtroVeh.Location = New System.Drawing.Point(245, 133)
        Me.lkpOtroVeh.MenuManager = Me.RibbonControl
        Me.lkpOtroVeh.Name = "lkpOtroVeh"
        Me.lkpOtroVeh.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.lkpOtroVeh.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.lkpOtroVeh.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lkpOtroVeh.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkpOtroVeh.Properties.DataSource = Me.SiNoBindingSource
        Me.lkpOtroVeh.Properties.DisplayMember = "Opcion"
        Me.lkpOtroVeh.Properties.ImmediatePopup = True
        Me.lkpOtroVeh.Properties.PopupFormMinSize = New System.Drawing.Size(95, 40)
        Me.lkpOtroVeh.Properties.PopupFormSize = New System.Drawing.Size(95, 40)
        Me.lkpOtroVeh.Properties.ShowFooter = False
        Me.lkpOtroVeh.Properties.ValueMember = "Id"
        Me.lkpOtroVeh.Properties.View = Me.GridView13
        Me.lkpOtroVeh.Size = New System.Drawing.Size(95, 20)
        Me.lkpOtroVeh.TabIndex = 6
        '
        'GridView13
        '
        Me.GridView13.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colOpcion5})
        Me.GridView13.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView13.Name = "GridView13"
        Me.GridView13.OptionsCustomization.AllowFilter = False
        Me.GridView13.OptionsCustomization.AllowGroup = False
        Me.GridView13.OptionsCustomization.AllowSort = False
        Me.GridView13.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView13.OptionsView.ShowColumnHeaders = False
        Me.GridView13.OptionsView.ShowGroupPanel = False
        Me.GridView13.OptionsView.ShowIndicator = False
        '
        'colOpcion5
        '
        Me.colOpcion5.FieldName = "Opcion"
        Me.colOpcion5.Name = "colOpcion5"
        Me.colOpcion5.Visible = True
        Me.colOpcion5.VisibleIndex = 0
        '
        'LabelControl11
        '
        Me.LabelControl11.Location = New System.Drawing.Point(14, 136)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(225, 13)
        Me.LabelControl11.TabIndex = 8
        Me.LabelControl11.Text = "¿El hogar dispone de otro vehículo motorizado?"
        '
        'txtPropiedadVehOtro
        '
        Me.txtPropiedadVehOtro.Location = New System.Drawing.Point(340, 55)
        Me.txtPropiedadVehOtro.MenuManager = Me.RibbonControl
        Me.txtPropiedadVehOtro.Name = "txtPropiedadVehOtro"
        Me.txtPropiedadVehOtro.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.txtPropiedadVehOtro.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.txtPropiedadVehOtro.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtPropiedadVehOtro.Size = New System.Drawing.Size(102, 20)
        Me.txtPropiedadVehOtro.TabIndex = 3
        Me.txtPropiedadVehOtro.Visible = False
        '
        'lblPropiedadVehOtro
        '
        Me.lblPropiedadVehOtro.Location = New System.Drawing.Point(312, 58)
        Me.lblPropiedadVehOtro.Name = "lblPropiedadVehOtro"
        Me.lblPropiedadVehOtro.Size = New System.Drawing.Size(22, 13)
        Me.lblPropiedadVehOtro.TabIndex = 5
        Me.lblPropiedadVehOtro.Text = "Otro"
        Me.lblPropiedadVehOtro.Visible = False
        '
        'lkpPropiedadVeh
        '
        Me.lkpPropiedadVeh.EditValue = ""
        Me.lkpPropiedadVeh.Location = New System.Drawing.Point(152, 55)
        Me.lkpPropiedadVeh.MenuManager = Me.RibbonControl
        Me.lkpPropiedadVeh.Name = "lkpPropiedadVeh"
        Me.lkpPropiedadVeh.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.lkpPropiedadVeh.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.lkpPropiedadVeh.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lkpPropiedadVeh.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkpPropiedadVeh.Properties.DataSource = Me.PropiedadVehiculoBindingSource
        Me.lkpPropiedadVeh.Properties.DisplayMember = "PropiedadVehiculo"
        Me.lkpPropiedadVeh.Properties.ImmediatePopup = True
        Me.lkpPropiedadVeh.Properties.PopupFormMinSize = New System.Drawing.Size(144, 40)
        Me.lkpPropiedadVeh.Properties.PopupFormSize = New System.Drawing.Size(144, 40)
        Me.lkpPropiedadVeh.Properties.ShowFooter = False
        Me.lkpPropiedadVeh.Properties.ValueMember = "ID"
        Me.lkpPropiedadVeh.Properties.View = Me.GridView1
        Me.lkpPropiedadVeh.Size = New System.Drawing.Size(144, 20)
        Me.lkpPropiedadVeh.TabIndex = 2
        '
        'PropiedadVehiculoBindingSource
        '
        Me.PropiedadVehiculoBindingSource.DataMember = "PropiedadVehiculo"
        Me.PropiedadVehiculoBindingSource.DataSource = Me.datasetEOD
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID3, Me.colPropiedadVehiculo})
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
        'lkpTipoVeh
        '
        Me.lkpTipoVeh.EditValue = ""
        Me.lkpTipoVeh.Location = New System.Drawing.Point(152, 29)
        Me.lkpTipoVeh.MenuManager = Me.RibbonControl
        Me.lkpTipoVeh.Name = "lkpTipoVeh"
        Me.lkpTipoVeh.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.lkpTipoVeh.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.lkpTipoVeh.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lkpTipoVeh.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkpTipoVeh.Properties.DataSource = Me.TipoVehBindingSource
        Me.lkpTipoVeh.Properties.DisplayMember = "vehiculo"
        Me.lkpTipoVeh.Properties.ImmediatePopup = True
        Me.lkpTipoVeh.Properties.PopupFormMinSize = New System.Drawing.Size(350, 180)
        Me.lkpTipoVeh.Properties.PopupFormSize = New System.Drawing.Size(350, 180)
        Me.lkpTipoVeh.Properties.ShowFooter = False
        Me.lkpTipoVeh.Properties.ValueMember = "ID"
        Me.lkpTipoVeh.Properties.View = Me.GridView2
        Me.lkpTipoVeh.Size = New System.Drawing.Size(290, 20)
        Me.lkpTipoVeh.TabIndex = 1
        '
        'TipoVehBindingSource
        '
        Me.TipoVehBindingSource.DataMember = "TipoVeh"
        Me.TipoVehBindingSource.DataSource = Me.datasetEOD
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colvehiculo})
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
        'colvehiculo
        '
        Me.colvehiculo.FieldName = "vehiculo"
        Me.colvehiculo.Name = "colvehiculo"
        Me.colvehiculo.OptionsColumn.AllowEdit = False
        Me.colvehiculo.Visible = True
        Me.colvehiculo.VisibleIndex = 0
        '
        'btnGuardarVehiculo
        '
        Me.btnGuardarVehiculo.Appearance.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnGuardarVehiculo.Appearance.BackColor2 = System.Drawing.SystemColors.HotTrack
        Me.btnGuardarVehiculo.Appearance.BorderColor = System.Drawing.SystemColors.HotTrack
        Me.btnGuardarVehiculo.Appearance.ForeColor = System.Drawing.Color.White
        Me.btnGuardarVehiculo.Appearance.Options.UseBackColor = True
        Me.btnGuardarVehiculo.Appearance.Options.UseBorderColor = True
        Me.btnGuardarVehiculo.Appearance.Options.UseForeColor = True
        Me.btnGuardarVehiculo.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
        Me.btnGuardarVehiculo.Location = New System.Drawing.Point(285, 169)
        Me.btnGuardarVehiculo.Name = "btnGuardarVehiculo"
        Me.btnGuardarVehiculo.Size = New System.Drawing.Size(85, 28)
        Me.btnGuardarVehiculo.TabIndex = 7
        Me.btnGuardarVehiculo.Text = "Guardar"
        '
        'tabPagePersonas
        '
        Me.tabPagePersonas.Caption = "3. Datos de las personas"
        Me.tabPagePersonas.Controls.Add(Me.btnRechazoPersona)
        Me.tabPagePersonas.Controls.Add(Me.lkpOtraPersona)
        Me.tabPagePersonas.Controls.Add(Me.LabelControl46)
        Me.tabPagePersonas.Controls.Add(Me.btnCancelarPersona)
        Me.tabPagePersonas.Controls.Add(Me.btnGuardarPersona)
        Me.tabPagePersonas.Controls.Add(Me.gcPerRegistradas)
        Me.tabPagePersonas.Controls.Add(Me.spcTrabajaEstudia)
        Me.tabPagePersonas.Controls.Add(Me.splitEstudios)
        Me.tabPagePersonas.Controls.Add(Me.LabelControl15)
        Me.tabPagePersonas.Controls.Add(Me.lkpEstudios)
        Me.tabPagePersonas.Controls.Add(Me.LabelControl14)
        Me.tabPagePersonas.Controls.Add(Me.lkpRelacion)
        Me.tabPagePersonas.Controls.Add(Me.LabelControl13)
        Me.tabPagePersonas.Controls.Add(Me.txtAnoNacimiento)
        Me.tabPagePersonas.Controls.Add(Me.LabelControl12)
        Me.tabPagePersonas.Controls.Add(Me.txtNombrePila)
        Me.tabPagePersonas.Controls.Add(Me.lkpSexo)
        Me.tabPagePersonas.Controls.Add(Me.LabelControl2)
        Me.tabPagePersonas.Name = "tabPagePersonas"
        Me.tabPagePersonas.Size = New System.Drawing.Size(966, 451)
        '
        'btnRechazoPersona
        '
        Me.btnRechazoPersona.Appearance.BackColor = System.Drawing.Color.Red
        Me.btnRechazoPersona.Appearance.BackColor2 = System.Drawing.Color.DarkRed
        Me.btnRechazoPersona.Appearance.BorderColor = System.Drawing.Color.DarkRed
        Me.btnRechazoPersona.Appearance.ForeColor = System.Drawing.Color.White
        Me.btnRechazoPersona.Appearance.Options.UseBackColor = True
        Me.btnRechazoPersona.Appearance.Options.UseBorderColor = True
        Me.btnRechazoPersona.Appearance.Options.UseForeColor = True
        Me.btnRechazoPersona.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
        Me.btnRechazoPersona.Location = New System.Drawing.Point(6, 390)
        Me.btnRechazoPersona.Name = "btnRechazoPersona"
        Me.btnRechazoPersona.Size = New System.Drawing.Size(128, 28)
        Me.btnRechazoPersona.TabIndex = 41
        Me.btnRechazoPersona.Text = "Rechazar encuesta"
        '
        'lkpOtraPersona
        '
        Me.lkpOtraPersona.EditValue = ""
        Me.lkpOtraPersona.Location = New System.Drawing.Point(194, 358)
        Me.lkpOtraPersona.MenuManager = Me.RibbonControl
        Me.lkpOtraPersona.Name = "lkpOtraPersona"
        Me.lkpOtraPersona.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.lkpOtraPersona.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.lkpOtraPersona.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lkpOtraPersona.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkpOtraPersona.Properties.DataSource = Me.SiNoBindingSource
        Me.lkpOtraPersona.Properties.DisplayMember = "Opcion"
        Me.lkpOtraPersona.Properties.PopupFormMinSize = New System.Drawing.Size(92, 40)
        Me.lkpOtraPersona.Properties.PopupFormSize = New System.Drawing.Size(92, 40)
        Me.lkpOtraPersona.Properties.ShowFooter = False
        Me.lkpOtraPersona.Properties.ValueMember = "Id"
        Me.lkpOtraPersona.Properties.View = Me.GridView30
        Me.lkpOtraPersona.Size = New System.Drawing.Size(92, 20)
        Me.lkpOtraPersona.TabIndex = 25
        '
        'GridView30
        '
        Me.GridView30.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colOpcion4})
        Me.GridView30.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView30.Name = "GridView30"
        Me.GridView30.OptionsCustomization.AllowFilter = False
        Me.GridView30.OptionsCustomization.AllowGroup = False
        Me.GridView30.OptionsCustomization.AllowSort = False
        Me.GridView30.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView30.OptionsView.ShowColumnHeaders = False
        Me.GridView30.OptionsView.ShowGroupPanel = False
        Me.GridView30.OptionsView.ShowIndicator = False
        '
        'colOpcion4
        '
        Me.colOpcion4.FieldName = "Opcion"
        Me.colOpcion4.Name = "colOpcion4"
        Me.colOpcion4.Visible = True
        Me.colOpcion4.VisibleIndex = 0
        '
        'LabelControl46
        '
        Me.LabelControl46.Location = New System.Drawing.Point(6, 361)
        Me.LabelControl46.Name = "LabelControl46"
        Me.LabelControl46.Size = New System.Drawing.Size(182, 13)
        Me.LabelControl46.TabIndex = 17
        Me.LabelControl46.Text = "¿Hay algún otro integrante del hogar?"
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
        Me.btnCancelarPersona.Location = New System.Drawing.Point(568, 390)
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
        Me.btnGuardarPersona.Location = New System.Drawing.Point(477, 390)
        Me.btnGuardarPersona.Name = "btnGuardarPersona"
        Me.btnGuardarPersona.Size = New System.Drawing.Size(85, 28)
        Me.btnGuardarPersona.TabIndex = 26
        Me.btnGuardarPersona.Text = "Guardar"
        '
        'gcPerRegistradas
        '
        Me.gcPerRegistradas.Controls.Add(Me.gridPersonas)
        Me.gcPerRegistradas.Location = New System.Drawing.Point(668, 51)
        Me.gcPerRegistradas.Name = "gcPerRegistradas"
        Me.gcPerRegistradas.Size = New System.Drawing.Size(259, 339)
        Me.gcPerRegistradas.TabIndex = 27
        Me.gcPerRegistradas.Text = "Personas registradas en el hogar"
        '
        'gridPersonas
        '
        Me.gridPersonas.DataSource = Me.ResumenPersonasBindingSource
        Me.gridPersonas.Location = New System.Drawing.Point(16, 25)
        Me.gridPersonas.MainView = Me.gridPersonasHogar
        Me.gridPersonas.MenuManager = Me.RibbonControl
        Me.gridPersonas.Name = "gridPersonas"
        Me.gridPersonas.Size = New System.Drawing.Size(229, 294)
        Me.gridPersonas.TabIndex = 0
        Me.gridPersonas.TabStop = False
        Me.gridPersonas.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridPersonasHogar})
        '
        'ResumenPersonasBindingSource
        '
        Me.ResumenPersonasBindingSource.DataMember = "ResumenPersonas"
        Me.ResumenPersonasBindingSource.DataSource = Me.datasetEOD
        '
        'gridPersonasHogar
        '
        Me.gridPersonasHogar.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colHogar1, Me.colPersona, Me.colNombrePila, Me.colSexo, Me.colRelacion})
        Me.gridPersonasHogar.GridControl = Me.gridPersonas
        Me.gridPersonasHogar.Name = "gridPersonasHogar"
        Me.gridPersonasHogar.OptionsView.ShowGroupPanel = False
        '
        'colHogar1
        '
        Me.colHogar1.FieldName = "Hogar"
        Me.colHogar1.Name = "colHogar1"
        '
        'colPersona
        '
        Me.colPersona.FieldName = "Persona"
        Me.colPersona.Name = "colPersona"
        '
        'colNombrePila
        '
        Me.colNombrePila.Caption = "Nombre"
        Me.colNombrePila.FieldName = "NombrePila"
        Me.colNombrePila.Name = "colNombrePila"
        Me.colNombrePila.Visible = True
        Me.colNombrePila.VisibleIndex = 0
        '
        'colSexo
        '
        Me.colSexo.FieldName = "Sexo"
        Me.colSexo.Name = "colSexo"
        '
        'colRelacion
        '
        Me.colRelacion.FieldName = "Relacion"
        Me.colRelacion.Name = "colRelacion"
        Me.colRelacion.Visible = True
        Me.colRelacion.VisibleIndex = 1
        Me.colRelacion.Width = 133
        '
        'spcTrabajaEstudia
        '
        Me.spcTrabajaEstudia.Horizontal = False
        Me.spcTrabajaEstudia.IsSplitterFixed = True
        Me.spcTrabajaEstudia.Location = New System.Drawing.Point(3, 103)
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
        Me.spcTrabajaEstudia.Size = New System.Drawing.Size(650, 249)
        Me.spcTrabajaEstudia.SplitterPosition = 105
        Me.spcTrabajaEstudia.TabIndex = 9
        Me.spcTrabajaEstudia.Text = "SplitContainerControl2"
        Me.spcTrabajaEstudia.Visible = False
        '
        'y_trabajo
        '
        Me.y_trabajo.EditValue = "0"
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
        Me.lkpJornadaTrabajo.TabIndex = 15
        '
        'JornadaTrabajoBindingSource
        '
        Me.JornadaTrabajoBindingSource.DataMember = "JornadaTrabajo"
        Me.JornadaTrabajoBindingSource.DataSource = Me.datasetEOD
        Me.JornadaTrabajoBindingSource.Filter = "id > 0"
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
        Me.x_trabajo.EditValue = "0"
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
        Me.lkpHitoTrabajo.Properties.NullText = ""
        Me.lkpHitoTrabajo.Properties.NullValuePrompt = "No reporta"
        Me.lkpHitoTrabajo.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.lkpHitoTrabajo.Properties.PopupFormMinSize = New System.Drawing.Size(235, 200)
        Me.lkpHitoTrabajo.Properties.PopupFormSize = New System.Drawing.Size(235, 200)
        Me.lkpHitoTrabajo.Properties.ShowFooter = False
        Me.lkpHitoTrabajo.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.lkpHitoTrabajo.Properties.ValueMember = "hito"
        Me.lkpHitoTrabajo.Properties.View = Me.GridView20
        Me.lkpHitoTrabajo.Size = New System.Drawing.Size(235, 20)
        Me.lkpHitoTrabajo.TabIndex = 13
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
        Me.GridView20.OptionsMenu.EnableColumnMenu = False
        Me.GridView20.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView20.OptionsView.ShowColumnHeaders = False
        Me.GridView20.OptionsView.ShowGroupPanel = False
        Me.GridView20.OptionsView.ShowIndicator = False
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
        Me.lkpCalle2Trabajo.Properties.NullText = ""
        Me.lkpCalle2Trabajo.Properties.NullValuePrompt = "No reporta"
        Me.lkpCalle2Trabajo.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.lkpCalle2Trabajo.Properties.PopupFormMinSize = New System.Drawing.Size(197, 0)
        Me.lkpCalle2Trabajo.Properties.PopupFormSize = New System.Drawing.Size(197, 0)
        Me.lkpCalle2Trabajo.Properties.ShowFooter = False
        Me.lkpCalle2Trabajo.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.lkpCalle2Trabajo.Properties.ValueMember = "calle2"
        Me.lkpCalle2Trabajo.Properties.View = Me.GridView18
        Me.lkpCalle2Trabajo.Size = New System.Drawing.Size(197, 20)
        Me.lkpCalle2Trabajo.TabIndex = 12
        '
        'ConsultaCalle2TrabajoBindingSource
        '
        Me.ConsultaCalle2TrabajoBindingSource.DataMember = "ConsultaCalle2Trabajo"
        Me.ConsultaCalle2TrabajoBindingSource.DataSource = Me.datasetEOD
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
        Me.lkpCalle1Trabajo.Properties.NullText = ""
        Me.lkpCalle1Trabajo.Properties.NullValuePrompt = "No reporta"
        Me.lkpCalle1Trabajo.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.lkpCalle1Trabajo.Properties.PopupFormMinSize = New System.Drawing.Size(161, 0)
        Me.lkpCalle1Trabajo.Properties.PopupFormSize = New System.Drawing.Size(161, 0)
        Me.lkpCalle1Trabajo.Properties.ShowFooter = False
        Me.lkpCalle1Trabajo.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.lkpCalle1Trabajo.Properties.ValueMember = "calle"
        Me.lkpCalle1Trabajo.Properties.View = Me.GridView17
        Me.lkpCalle1Trabajo.Size = New System.Drawing.Size(161, 20)
        Me.lkpCalle1Trabajo.TabIndex = 11
        '
        'Calle1TrabajoBindingSource
        '
        Me.Calle1TrabajoBindingSource.DataMember = "Calles"
        Me.Calle1TrabajoBindingSource.DataSource = Me.datasetEOD
        Me.Calle1TrabajoBindingSource.Filter = "id < 10000"
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
        Me.txtComunaTrabajoOtra.TabIndex = 10
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
        Me.lkpComunaTrabajo.TabIndex = 9
        '
        'ComunaTrabajoBindingSource
        '
        Me.ComunaTrabajoBindingSource.DataMember = "Comuna"
        Me.ComunaTrabajoBindingSource.DataSource = Me.datasetEOD
        Me.ComunaTrabajoBindingSource.Filter = "id >0"
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
        Me.lkpManzanaTrabajo.TabIndex = 14
        '
        'txtDondeEstudiaOtro
        '
        Me.txtDondeEstudiaOtro.Location = New System.Drawing.Point(545, 83)
        Me.txtDondeEstudiaOtro.MenuManager = Me.RibbonControl
        Me.txtDondeEstudiaOtro.Name = "txtDondeEstudiaOtro"
        Me.txtDondeEstudiaOtro.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.txtDondeEstudiaOtro.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.txtDondeEstudiaOtro.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtDondeEstudiaOtro.Size = New System.Drawing.Size(105, 20)
        Me.txtDondeEstudiaOtro.TabIndex = 23
        Me.txtDondeEstudiaOtro.Visible = False
        '
        'lblDondeEstudiaOtro
        '
        Me.lblDondeEstudiaOtro.Location = New System.Drawing.Point(490, 86)
        Me.lblDondeEstudiaOtro.Name = "lblDondeEstudiaOtro"
        Me.lblDondeEstudiaOtro.Size = New System.Drawing.Size(49, 13)
        Me.lblDondeEstudiaOtro.TabIndex = 81
        Me.lblDondeEstudiaOtro.Text = "Otro lugar"
        Me.lblDondeEstudiaOtro.Visible = False
        '
        'y_estudio
        '
        Me.y_estudio.EditValue = "0"
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
        Me.lkpTieneTNE.Location = New System.Drawing.Point(219, 109)
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
        Me.lkpTieneTNE.TabIndex = 24
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
        Me.x_estudio.EditValue = "0"
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
        Me.lkpDondeEstudia.Properties.PopupFormMinSize = New System.Drawing.Size(383, 100)
        Me.lkpDondeEstudia.Properties.PopupFormSize = New System.Drawing.Size(383, 100)
        Me.lkpDondeEstudia.Properties.ShowFooter = False
        Me.lkpDondeEstudia.Properties.ValueMember = "ID"
        Me.lkpDondeEstudia.Properties.View = Me.GridView22
        Me.lkpDondeEstudia.Size = New System.Drawing.Size(383, 20)
        Me.lkpDondeEstudia.TabIndex = 22
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
        Me.lkpHitoEstudio.Properties.NullText = ""
        Me.lkpHitoEstudio.Properties.NullValuePrompt = "No reporta"
        Me.lkpHitoEstudio.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.lkpHitoEstudio.Properties.PopupFormMinSize = New System.Drawing.Size(235, 200)
        Me.lkpHitoEstudio.Properties.PopupFormSize = New System.Drawing.Size(235, 200)
        Me.lkpHitoEstudio.Properties.ShowFooter = False
        Me.lkpHitoEstudio.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.lkpHitoEstudio.Properties.ValueMember = "hito"
        Me.lkpHitoEstudio.Properties.View = Me.GridView24
        Me.lkpHitoEstudio.Size = New System.Drawing.Size(235, 20)
        Me.lkpHitoEstudio.TabIndex = 20
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
        Me.lkpCalle2Estudio.Properties.NullText = ""
        Me.lkpCalle2Estudio.Properties.NullValuePrompt = "No reporta"
        Me.lkpCalle2Estudio.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.lkpCalle2Estudio.Properties.PopupFormMinSize = New System.Drawing.Size(195, 200)
        Me.lkpCalle2Estudio.Properties.PopupFormSize = New System.Drawing.Size(195, 200)
        Me.lkpCalle2Estudio.Properties.ShowFooter = False
        Me.lkpCalle2Estudio.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.lkpCalle2Estudio.Properties.ValueMember = "calle2"
        Me.lkpCalle2Estudio.Properties.View = Me.GridView25
        Me.lkpCalle2Estudio.Size = New System.Drawing.Size(195, 20)
        Me.lkpCalle2Estudio.TabIndex = 19
        '
        'ConsultaCalle2EstudioBindingSource
        '
        Me.ConsultaCalle2EstudioBindingSource.DataMember = "ConsultaCalle2Estudio"
        Me.ConsultaCalle2EstudioBindingSource.DataSource = Me.datasetEOD
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
        Me.lkpCalle1Estudio.Properties.NullText = ""
        Me.lkpCalle1Estudio.Properties.NullValuePrompt = "No reporta"
        Me.lkpCalle1Estudio.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.lkpCalle1Estudio.Properties.PopupFormMinSize = New System.Drawing.Size(161, 200)
        Me.lkpCalle1Estudio.Properties.PopupFormSize = New System.Drawing.Size(161, 200)
        Me.lkpCalle1Estudio.Properties.ShowFooter = False
        Me.lkpCalle1Estudio.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.lkpCalle1Estudio.Properties.ValueMember = "calle"
        Me.lkpCalle1Estudio.Properties.View = Me.GridView26
        Me.lkpCalle1Estudio.Size = New System.Drawing.Size(161, 20)
        Me.lkpCalle1Estudio.TabIndex = 18
        '
        'Calle1EstudioBindingSource
        '
        Me.Calle1EstudioBindingSource.DataMember = "Calles"
        Me.Calle1EstudioBindingSource.DataSource = Me.datasetEOD
        Me.Calle1EstudioBindingSource.Filter = "id < 10000"
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
        Me.txtComunaEstudioOtra.TabIndex = 17
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
        Me.lkpComunaEstudio.Properties.ShowFooter = False
        Me.lkpComunaEstudio.Properties.ValueMember = "ID"
        Me.lkpComunaEstudio.Properties.View = Me.GridView27
        Me.lkpComunaEstudio.Size = New System.Drawing.Size(161, 20)
        Me.lkpComunaEstudio.TabIndex = 16
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
        Me.lkpManzanaEstudio.TabIndex = 21
        '
        'splitEstudios
        '
        Me.splitEstudios.CollapsePanel = DevExpress.XtraEditors.SplitCollapsePanel.Panel1
        Me.splitEstudios.IsSplitterFixed = True
        Me.splitEstudios.Location = New System.Drawing.Point(-1, 48)
        Me.splitEstudios.Name = "splitEstudios"
        Me.splitEstudios.Panel1.Controls.Add(Me.lkpEstudiosCompletos)
        Me.splitEstudios.Panel1.Controls.Add(Me.lblEstudiosCompletos)
        Me.splitEstudios.Panel1.Text = "Panel1"
        Me.splitEstudios.Panel2.Controls.Add(Me.txtActividadOtra)
        Me.splitEstudios.Panel2.Controls.Add(Me.lblActividadOtra)
        Me.splitEstudios.Panel2.Controls.Add(Me.lkpLicencia)
        Me.splitEstudios.Panel2.Controls.Add(Me.LabelControl22)
        Me.splitEstudios.Panel2.Controls.Add(Me.lblLicencia)
        Me.splitEstudios.Panel2.Controls.Add(Me.chkActividad)
        Me.splitEstudios.Panel2.Text = "Panel2"
        Me.splitEstudios.Size = New System.Drawing.Size(663, 49)
        Me.splitEstudios.SplitterPosition = 147
        Me.splitEstudios.TabIndex = 6
        Me.splitEstudios.Text = "SplitContainerControl1"
        '
        'lkpEstudiosCompletos
        '
        Me.lkpEstudiosCompletos.EditValue = ""
        Me.lkpEstudiosCompletos.Location = New System.Drawing.Point(3, 22)
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
        Me.lblEstudiosCompletos.Location = New System.Drawing.Point(3, 3)
        Me.lblEstudiosCompletos.Name = "lblEstudiosCompletos"
        Me.lblEstudiosCompletos.Size = New System.Drawing.Size(122, 13)
        Me.lblEstudiosCompletos.TabIndex = 11
        Me.lblEstudiosCompletos.Text = "¿Son estudios completos?"
        '
        'txtActividadOtra
        '
        Me.txtActividadOtra.Location = New System.Drawing.Point(391, 22)
        Me.txtActividadOtra.MenuManager = Me.RibbonControl
        Me.txtActividadOtra.Name = "txtActividadOtra"
        Me.txtActividadOtra.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.txtActividadOtra.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.txtActividadOtra.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtActividadOtra.Properties.Mask.EditMask = "c0"
        Me.txtActividadOtra.Size = New System.Drawing.Size(104, 20)
        Me.txtActividadOtra.TabIndex = 16
        Me.txtActividadOtra.Visible = False
        '
        'lblActividadOtra
        '
        Me.lblActividadOtra.Location = New System.Drawing.Point(390, 3)
        Me.lblActividadOtra.Name = "lblActividadOtra"
        Me.lblActividadOtra.Size = New System.Drawing.Size(68, 13)
        Me.lblActividadOtra.TabIndex = 17
        Me.lblActividadOtra.Text = "Otra actividad"
        Me.lblActividadOtra.Visible = False
        '
        'lkpLicencia
        '
        Me.lkpLicencia.EditValue = ""
        Me.lkpLicencia.Location = New System.Drawing.Point(2, 22)
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
        Me.LabelControl22.Location = New System.Drawing.Point(145, 3)
        Me.LabelControl22.Name = "LabelControl22"
        Me.LabelControl22.Size = New System.Drawing.Size(148, 13)
        Me.LabelControl22.TabIndex = 15
        Me.LabelControl22.Text = "¿A qué se dedica actualmente?"
        '
        'lblLicencia
        '
        Me.lblLicencia.Location = New System.Drawing.Point(2, 3)
        Me.lblLicencia.Name = "lblLicencia"
        Me.lblLicencia.Size = New System.Drawing.Size(131, 13)
        Me.lblLicencia.TabIndex = 13
        Me.lblLicencia.Text = "¿Tiene licencia de conducir?"
        '
        'chkActividad
        '
        Me.chkActividad.EditValue = ""
        Me.chkActividad.Location = New System.Drawing.Point(145, 22)
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
        Me.chkActividad.Properties.PopupFormMinSize = New System.Drawing.Size(231, 160)
        Me.chkActividad.Properties.PopupFormSize = New System.Drawing.Size(231, 160)
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
        Me.LabelControl15.Location = New System.Drawing.Point(597, 6)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(142, 13)
        Me.LabelControl15.TabIndex = 9
        Me.LabelControl15.Text = "¿Cuál es su nivel de estudios?"
        '
        'lkpEstudios
        '
        Me.lkpEstudios.EditValue = ""
        Me.lkpEstudios.Location = New System.Drawing.Point(597, 25)
        Me.lkpEstudios.MenuManager = Me.RibbonControl
        Me.lkpEstudios.Name = "lkpEstudios"
        Me.lkpEstudios.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.lkpEstudios.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.lkpEstudios.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lkpEstudios.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkpEstudios.Properties.DataSource = Me.EstudiosBindingSource
        Me.lkpEstudios.Properties.DisplayMember = "Estudio"
        Me.lkpEstudios.Properties.PopupFormMinSize = New System.Drawing.Size(330, 120)
        Me.lkpEstudios.Properties.PopupFormSize = New System.Drawing.Size(330, 120)
        Me.lkpEstudios.Properties.ShowFooter = False
        Me.lkpEstudios.Properties.ValueMember = "ID"
        Me.lkpEstudios.Properties.View = Me.GridView11
        Me.lkpEstudios.Size = New System.Drawing.Size(330, 20)
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
        Me.LabelControl14.Location = New System.Drawing.Point(378, 6)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(198, 13)
        Me.LabelControl14.TabIndex = 7
        Me.LabelControl14.Text = "¿Cuál es su relación con el jefe de hogar?"
        '
        'lkpRelacion
        '
        Me.lkpRelacion.EditValue = ""
        Me.lkpRelacion.Location = New System.Drawing.Point(378, 25)
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
        Me.lkpRelacion.Properties.View = Me.GridView10
        Me.lkpRelacion.Size = New System.Drawing.Size(198, 20)
        Me.lkpRelacion.TabIndex = 4
        '
        'RelacionBindingSource
        '
        Me.RelacionBindingSource.DataMember = "Relacion"
        Me.RelacionBindingSource.DataSource = Me.datasetEOD
        '
        'GridView10
        '
        Me.GridView10.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colRelacion1})
        Me.GridView10.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView10.Name = "GridView10"
        Me.GridView10.OptionsBehavior.Editable = False
        Me.GridView10.OptionsCustomization.AllowFilter = False
        Me.GridView10.OptionsCustomization.AllowGroup = False
        Me.GridView10.OptionsCustomization.AllowSort = False
        Me.GridView10.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView10.OptionsView.ShowColumnHeaders = False
        Me.GridView10.OptionsView.ShowGroupPanel = False
        Me.GridView10.OptionsView.ShowIndicator = False
        '
        'colRelacion1
        '
        Me.colRelacion1.FieldName = "Relacion"
        Me.colRelacion1.Name = "colRelacion1"
        Me.colRelacion1.Visible = True
        Me.colRelacion1.VisibleIndex = 0
        '
        'LabelControl13
        '
        Me.LabelControl13.Location = New System.Drawing.Point(263, 3)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(73, 13)
        Me.LabelControl13.TabIndex = 5
        Me.LabelControl13.Text = "¿Su género es?"
        '
        'txtAnoNacimiento
        '
        Me.txtAnoNacimiento.Location = New System.Drawing.Point(120, 22)
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
        'LabelControl12
        '
        Me.LabelControl12.Location = New System.Drawing.Point(120, 3)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(126, 13)
        Me.LabelControl12.TabIndex = 3
        Me.LabelControl12.Text = "¿Su año de nacimiento es?"
        '
        'txtNombrePila
        '
        Me.txtNombrePila.Location = New System.Drawing.Point(3, 22)
        Me.txtNombrePila.MenuManager = Me.RibbonControl
        Me.txtNombrePila.Name = "txtNombrePila"
        Me.txtNombrePila.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.txtNombrePila.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.txtNombrePila.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtNombrePila.Size = New System.Drawing.Size(95, 20)
        Me.txtNombrePila.TabIndex = 1
        '
        'lkpSexo
        '
        Me.lkpSexo.EditValue = ""
        Me.lkpSexo.Location = New System.Drawing.Point(263, 22)
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
        Me.lkpSexo.Properties.View = Me.GridLookUpEdit3View
        Me.lkpSexo.Size = New System.Drawing.Size(92, 20)
        Me.lkpSexo.TabIndex = 3
        '
        'SexoBindingSource
        '
        Me.SexoBindingSource.DataMember = "Sexo"
        Me.SexoBindingSource.DataSource = Me.datasetEOD
        '
        'GridLookUpEdit3View
        '
        Me.GridLookUpEdit3View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSexo1})
        Me.GridLookUpEdit3View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit3View.Name = "GridLookUpEdit3View"
        Me.GridLookUpEdit3View.OptionsBehavior.Editable = False
        Me.GridLookUpEdit3View.OptionsCustomization.AllowFilter = False
        Me.GridLookUpEdit3View.OptionsCustomization.AllowGroup = False
        Me.GridLookUpEdit3View.OptionsCustomization.AllowSort = False
        Me.GridLookUpEdit3View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit3View.OptionsView.ShowColumnHeaders = False
        Me.GridLookUpEdit3View.OptionsView.ShowGroupPanel = False
        Me.GridLookUpEdit3View.OptionsView.ShowIndicator = False
        '
        'colSexo1
        '
        Me.colSexo1.FieldName = "Sexo"
        Me.colSexo1.Name = "colSexo1"
        Me.colSexo1.Visible = True
        Me.colSexo1.VisibleIndex = 0
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(3, 3)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(95, 13)
        Me.LabelControl2.TabIndex = 0
        Me.LabelControl2.Text = "¿Su nombre de pila?"
        '
        'tabPageFecha
        '
        Me.tabPageFecha.Caption = "4. Día de viajes"
        Me.tabPageFecha.Controls.Add(Me.spcDiscapacidad)
        Me.tabPageFecha.Controls.Add(Me.lkpPersonaDiscapacidad)
        Me.tabPageFecha.Controls.Add(Me.LabelControl29)
        Me.tabPageFecha.Controls.Add(Me.LabelControl28)
        Me.tabPageFecha.Controls.Add(Me.btnRechazoFecha)
        Me.tabPageFecha.Controls.Add(Me.btnGuardarEncuesta)
        Me.tabPageFecha.Name = "tabPageFecha"
        Me.tabPageFecha.Size = New System.Drawing.Size(966, 451)
        '
        'spcDiscapacidad
        '
        Me.spcDiscapacidad.CollapsePanel = DevExpress.XtraEditors.SplitCollapsePanel.Panel1
        Me.spcDiscapacidad.Horizontal = False
        Me.spcDiscapacidad.Location = New System.Drawing.Point(174, 92)
        Me.spcDiscapacidad.Name = "spcDiscapacidad"
        Me.spcDiscapacidad.Panel1.Controls.Add(Me.LabelControl30)
        Me.spcDiscapacidad.Panel1.Controls.Add(Me.lkpPersonaAutosuficiente)
        Me.spcDiscapacidad.Panel1.Controls.Add(Me.lkpTipoDiscapacidad)
        Me.spcDiscapacidad.Panel1.Controls.Add(Me.LabelControl33)
        Me.spcDiscapacidad.Panel1.Text = "Panel1"
        Me.spcDiscapacidad.Panel2.Controls.Add(Me.lblNotaLV)
        Me.spcDiscapacidad.Panel2.Controls.Add(Me.deDomingoLV)
        Me.spcDiscapacidad.Panel2.Controls.Add(Me.lblDomingoLV)
        Me.spcDiscapacidad.Panel2.Controls.Add(Me.deSabadoLV)
        Me.spcDiscapacidad.Panel2.Controls.Add(Me.lblSabadoLV)
        Me.spcDiscapacidad.Panel2.Controls.Add(Me.deFechaViajes)
        Me.spcDiscapacidad.Panel2.Controls.Add(Me.LabelControl43)
        Me.spcDiscapacidad.Panel2.Controls.Add(Me.lkpTipoDia)
        Me.spcDiscapacidad.Panel2.Controls.Add(Me.LabelControl42)
        Me.spcDiscapacidad.Panel2.Controls.Add(Me.LabelControl41)
        Me.spcDiscapacidad.Panel2.Controls.Add(Me.txtObservacion)
        Me.spcDiscapacidad.Panel2.Text = "Panel2"
        Me.spcDiscapacidad.Size = New System.Drawing.Size(621, 243)
        Me.spcDiscapacidad.SplitterPosition = 60
        Me.spcDiscapacidad.TabIndex = 54
        Me.spcDiscapacidad.Text = "SplitContainerControl1"
        '
        'LabelControl30
        '
        Me.LabelControl30.Location = New System.Drawing.Point(17, 3)
        Me.LabelControl30.Name = "LabelControl30"
        Me.LabelControl30.Size = New System.Drawing.Size(137, 13)
        Me.LabelControl30.TabIndex = 51
        Me.LabelControl30.Text = "Indicar tipo de discapacidad:"
        '
        'lkpPersonaAutosuficiente
        '
        Me.lkpPersonaAutosuficiente.EditValue = ""
        Me.lkpPersonaAutosuficiente.Location = New System.Drawing.Point(175, 33)
        Me.lkpPersonaAutosuficiente.MenuManager = Me.RibbonControl
        Me.lkpPersonaAutosuficiente.Name = "lkpPersonaAutosuficiente"
        Me.lkpPersonaAutosuficiente.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.lkpPersonaAutosuficiente.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.lkpPersonaAutosuficiente.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lkpPersonaAutosuficiente.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkpPersonaAutosuficiente.Properties.DataSource = Me.SiNoBindingSource
        Me.lkpPersonaAutosuficiente.Properties.DisplayMember = "Opcion"
        Me.lkpPersonaAutosuficiente.Properties.ImmediatePopup = True
        Me.lkpPersonaAutosuficiente.Properties.PopupFormMinSize = New System.Drawing.Size(95, 40)
        Me.lkpPersonaAutosuficiente.Properties.PopupFormSize = New System.Drawing.Size(95, 40)
        Me.lkpPersonaAutosuficiente.Properties.ShowFooter = False
        Me.lkpPersonaAutosuficiente.Properties.ValueMember = "Id"
        Me.lkpPersonaAutosuficiente.Properties.View = Me.GridView32
        Me.lkpPersonaAutosuficiente.Size = New System.Drawing.Size(95, 20)
        Me.lkpPersonaAutosuficiente.TabIndex = 47
        '
        'GridView32
        '
        Me.GridView32.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn5})
        Me.GridView32.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView32.Name = "GridView32"
        Me.GridView32.OptionsCustomization.AllowFilter = False
        Me.GridView32.OptionsCustomization.AllowGroup = False
        Me.GridView32.OptionsCustomization.AllowSort = False
        Me.GridView32.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView32.OptionsView.ShowColumnHeaders = False
        Me.GridView32.OptionsView.ShowGroupPanel = False
        Me.GridView32.OptionsView.ShowIndicator = False
        '
        'GridColumn5
        '
        Me.GridColumn5.FieldName = "Opcion"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 0
        '
        'lkpTipoDiscapacidad
        '
        Me.lkpTipoDiscapacidad.EditValue = ""
        Me.lkpTipoDiscapacidad.Location = New System.Drawing.Point(175, 0)
        Me.lkpTipoDiscapacidad.MenuManager = Me.RibbonControl
        Me.lkpTipoDiscapacidad.Name = "lkpTipoDiscapacidad"
        Me.lkpTipoDiscapacidad.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.lkpTipoDiscapacidad.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.lkpTipoDiscapacidad.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lkpTipoDiscapacidad.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkpTipoDiscapacidad.Properties.DataSource = Me.TipoDiscapacidadBindingSource
        Me.lkpTipoDiscapacidad.Properties.DisplayMember = "TipoDiscapacidad"
        Me.lkpTipoDiscapacidad.Properties.PopupFormMinSize = New System.Drawing.Size(431, 80)
        Me.lkpTipoDiscapacidad.Properties.PopupFormSize = New System.Drawing.Size(431, 80)
        Me.lkpTipoDiscapacidad.Properties.ShowFooter = False
        Me.lkpTipoDiscapacidad.Properties.ValueMember = "ID"
        Me.lkpTipoDiscapacidad.Properties.View = Me.GridView31
        Me.lkpTipoDiscapacidad.Size = New System.Drawing.Size(431, 20)
        Me.lkpTipoDiscapacidad.TabIndex = 46
        '
        'TipoDiscapacidadBindingSource
        '
        Me.TipoDiscapacidadBindingSource.DataMember = "TipoDiscapacidad"
        Me.TipoDiscapacidadBindingSource.DataSource = Me.datasetEOD
        '
        'GridView31
        '
        Me.GridView31.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn4})
        Me.GridView31.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView31.Name = "GridView31"
        Me.GridView31.OptionsBehavior.Editable = False
        Me.GridView31.OptionsCustomization.AllowFilter = False
        Me.GridView31.OptionsCustomization.AllowGroup = False
        Me.GridView31.OptionsCustomization.AllowSort = False
        Me.GridView31.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView31.OptionsView.ShowColumnHeaders = False
        Me.GridView31.OptionsView.ShowGroupPanel = False
        Me.GridView31.OptionsView.ShowIndicator = False
        '
        'GridColumn4
        '
        Me.GridColumn4.FieldName = "TipoDiscapacidad"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 0
        '
        'LabelControl33
        '
        Me.LabelControl33.Location = New System.Drawing.Point(17, 36)
        Me.LabelControl33.Name = "LabelControl33"
        Me.LabelControl33.Size = New System.Drawing.Size(148, 13)
        Me.LabelControl33.TabIndex = 52
        Me.LabelControl33.Text = "¿La persona es autosuficiente?"
        '
        'lblNotaLV
        '
        Me.lblNotaLV.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Italic)
        Me.lblNotaLV.Appearance.Options.UseFont = True
        Me.lblNotaLV.Location = New System.Drawing.Point(465, 123)
        Me.lblNotaLV.Name = "lblNotaLV"
        Me.lblNotaLV.Size = New System.Drawing.Size(91, 13)
        Me.lblNotaLV.TabIndex = 57
        Me.lblNotaLV.Text = "(Autocompletado):"
        Me.lblNotaLV.Visible = False
        '
        'deDomingoLV
        '
        Me.deDomingoLV.EditValue = Nothing
        Me.deDomingoLV.Enabled = False
        Me.deDomingoLV.Location = New System.Drawing.Point(322, 142)
        Me.deDomingoLV.MenuManager = Me.RibbonControl
        Me.deDomingoLV.Name = "deDomingoLV"
        Me.deDomingoLV.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.deDomingoLV.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.deDomingoLV.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.deDomingoLV.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deDomingoLV.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deDomingoLV.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.deDomingoLV.Size = New System.Drawing.Size(284, 20)
        Me.deDomingoLV.TabIndex = 56
        Me.deDomingoLV.Visible = False
        '
        'lblDomingoLV
        '
        Me.lblDomingoLV.Location = New System.Drawing.Point(322, 123)
        Me.lblDomingoLV.Name = "lblDomingoLV"
        Me.lblDomingoLV.Size = New System.Drawing.Size(137, 13)
        Me.lblDomingoLV.TabIndex = 55
        Me.lblDomingoLV.Text = "Libro de Viajes - Día domingo"
        Me.lblDomingoLV.Visible = False
        '
        'deSabadoLV
        '
        Me.deSabadoLV.EditValue = Nothing
        Me.deSabadoLV.Location = New System.Drawing.Point(17, 142)
        Me.deSabadoLV.MenuManager = Me.RibbonControl
        Me.deSabadoLV.Name = "deSabadoLV"
        Me.deSabadoLV.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.deSabadoLV.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.deSabadoLV.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.deSabadoLV.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deSabadoLV.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deSabadoLV.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.deSabadoLV.Size = New System.Drawing.Size(284, 20)
        Me.deSabadoLV.TabIndex = 52
        Me.deSabadoLV.Visible = False
        '
        'lblSabadoLV
        '
        Me.lblSabadoLV.Location = New System.Drawing.Point(17, 123)
        Me.lblSabadoLV.Name = "lblSabadoLV"
        Me.lblSabadoLV.Size = New System.Drawing.Size(136, 13)
        Me.lblSabadoLV.TabIndex = 54
        Me.lblSabadoLV.Text = "Libro de Viajes - Día sábado:"
        Me.lblSabadoLV.Visible = False
        '
        'deFechaViajes
        '
        Me.deFechaViajes.EditValue = Nothing
        Me.deFechaViajes.Location = New System.Drawing.Point(322, 84)
        Me.deFechaViajes.MenuManager = Me.RibbonControl
        Me.deFechaViajes.Name = "deFechaViajes"
        Me.deFechaViajes.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.deFechaViajes.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.deFechaViajes.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.deFechaViajes.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deFechaViajes.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deFechaViajes.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.deFechaViajes.Size = New System.Drawing.Size(284, 20)
        Me.deFechaViajes.TabIndex = 51
        '
        'LabelControl43
        '
        Me.LabelControl43.Location = New System.Drawing.Point(322, 65)
        Me.LabelControl43.Name = "LabelControl43"
        Me.LabelControl43.Size = New System.Drawing.Size(65, 13)
        Me.LabelControl43.TabIndex = 53
        Me.LabelControl43.Text = "Día de viajes:"
        '
        'lkpTipoDia
        '
        Me.lkpTipoDia.EditValue = ""
        Me.lkpTipoDia.Location = New System.Drawing.Point(17, 84)
        Me.lkpTipoDia.MenuManager = Me.RibbonControl
        Me.lkpTipoDia.Name = "lkpTipoDia"
        Me.lkpTipoDia.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.lkpTipoDia.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.lkpTipoDia.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lkpTipoDia.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkpTipoDia.Properties.DataSource = Me.TipoDiaBindingSource
        Me.lkpTipoDia.Properties.DisplayMember = "TipoDia"
        Me.lkpTipoDia.Properties.PopupFormMinSize = New System.Drawing.Size(152, 80)
        Me.lkpTipoDia.Properties.PopupFormSize = New System.Drawing.Size(152, 80)
        Me.lkpTipoDia.Properties.ShowFooter = False
        Me.lkpTipoDia.Properties.ValueMember = "ID"
        Me.lkpTipoDia.Properties.View = Me.GridLookUpEdit28View
        Me.lkpTipoDia.Size = New System.Drawing.Size(284, 20)
        Me.lkpTipoDia.TabIndex = 49
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
        Me.LabelControl42.Location = New System.Drawing.Point(17, 65)
        Me.LabelControl42.Name = "LabelControl42"
        Me.LabelControl42.Size = New System.Drawing.Size(92, 13)
        Me.LabelControl42.TabIndex = 50
        Me.LabelControl42.Text = "¿Esta encuesta es?"
        '
        'LabelControl41
        '
        Me.LabelControl41.Location = New System.Drawing.Point(17, 10)
        Me.LabelControl41.Name = "LabelControl41"
        Me.LabelControl41.Size = New System.Drawing.Size(190, 13)
        Me.LabelControl41.TabIndex = 47
        Me.LabelControl41.Text = "¿Tiene alguna observación o acotación?"
        '
        'txtObservacion
        '
        Me.txtObservacion.Location = New System.Drawing.Point(213, 8)
        Me.txtObservacion.MenuManager = Me.RibbonControl
        Me.txtObservacion.Name = "txtObservacion"
        Me.txtObservacion.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.txtObservacion.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.txtObservacion.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtObservacion.Size = New System.Drawing.Size(393, 41)
        Me.txtObservacion.TabIndex = 48
        '
        'lkpPersonaDiscapacidad
        '
        Me.lkpPersonaDiscapacidad.EditValue = ""
        Me.lkpPersonaDiscapacidad.Location = New System.Drawing.Point(444, 62)
        Me.lkpPersonaDiscapacidad.MenuManager = Me.RibbonControl
        Me.lkpPersonaDiscapacidad.Name = "lkpPersonaDiscapacidad"
        Me.lkpPersonaDiscapacidad.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.lkpPersonaDiscapacidad.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.lkpPersonaDiscapacidad.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lkpPersonaDiscapacidad.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkpPersonaDiscapacidad.Properties.DataSource = Me.SiNoBindingSource
        Me.lkpPersonaDiscapacidad.Properties.DisplayMember = "Opcion"
        Me.lkpPersonaDiscapacidad.Properties.ImmediatePopup = True
        Me.lkpPersonaDiscapacidad.Properties.PopupFormMinSize = New System.Drawing.Size(95, 40)
        Me.lkpPersonaDiscapacidad.Properties.PopupFormSize = New System.Drawing.Size(95, 40)
        Me.lkpPersonaDiscapacidad.Properties.ShowFooter = False
        Me.lkpPersonaDiscapacidad.Properties.ValueMember = "Id"
        Me.lkpPersonaDiscapacidad.Properties.View = Me.GridView23
        Me.lkpPersonaDiscapacidad.Size = New System.Drawing.Size(95, 20)
        Me.lkpPersonaDiscapacidad.TabIndex = 45
        '
        'GridView23
        '
        Me.GridView23.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn3})
        Me.GridView23.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView23.Name = "GridView23"
        Me.GridView23.OptionsCustomization.AllowFilter = False
        Me.GridView23.OptionsCustomization.AllowGroup = False
        Me.GridView23.OptionsCustomization.AllowSort = False
        Me.GridView23.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView23.OptionsView.ShowColumnHeaders = False
        Me.GridView23.OptionsView.ShowGroupPanel = False
        Me.GridView23.OptionsView.ShowIndicator = False
        '
        'GridColumn3
        '
        Me.GridColumn3.FieldName = "Opcion"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 0
        '
        'LabelControl29
        '
        Me.LabelControl29.Location = New System.Drawing.Point(191, 65)
        Me.LabelControl29.Name = "LabelControl29"
        Me.LabelControl29.Size = New System.Drawing.Size(247, 13)
        Me.LabelControl29.TabIndex = 48
        Me.LabelControl29.Text = "¿Hay alguna persona con discapacidad en el hogar?"
        '
        'LabelControl28
        '
        Me.LabelControl28.Location = New System.Drawing.Point(191, 24)
        Me.LabelControl28.Name = "LabelControl28"
        Me.LabelControl28.Size = New System.Drawing.Size(581, 26)
        Me.LabelControl28.TabIndex = 47
        Me.LabelControl28.Text = "A nivel nacional, se tiene como objetivo dar accesibilidad universal a toda la po" &
    "blación, por lo tanto, interesa saber cuáles" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "son las limitaciones y a cuántas p" &
    "ersonas afecta."
        '
        'btnRechazoFecha
        '
        Me.btnRechazoFecha.Appearance.BackColor = System.Drawing.Color.Red
        Me.btnRechazoFecha.Appearance.BackColor2 = System.Drawing.Color.DarkRed
        Me.btnRechazoFecha.Appearance.BorderColor = System.Drawing.Color.DarkRed
        Me.btnRechazoFecha.Appearance.ForeColor = System.Drawing.Color.White
        Me.btnRechazoFecha.Appearance.Options.UseBackColor = True
        Me.btnRechazoFecha.Appearance.Options.UseBorderColor = True
        Me.btnRechazoFecha.Appearance.Options.UseForeColor = True
        Me.btnRechazoFecha.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
        Me.btnRechazoFecha.Location = New System.Drawing.Point(193, 341)
        Me.btnRechazoFecha.Name = "btnRechazoFecha"
        Me.btnRechazoFecha.Size = New System.Drawing.Size(128, 28)
        Me.btnRechazoFecha.TabIndex = 41
        Me.btnRechazoFecha.Text = "Rechazar encuesta"
        '
        'btnGuardarEncuesta
        '
        Me.btnGuardarEncuesta.Appearance.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnGuardarEncuesta.Appearance.BackColor2 = System.Drawing.SystemColors.HotTrack
        Me.btnGuardarEncuesta.Appearance.BorderColor = System.Drawing.SystemColors.HotTrack
        Me.btnGuardarEncuesta.Appearance.ForeColor = System.Drawing.Color.White
        Me.btnGuardarEncuesta.Appearance.Options.UseBackColor = True
        Me.btnGuardarEncuesta.Appearance.Options.UseBorderColor = True
        Me.btnGuardarEncuesta.Appearance.Options.UseForeColor = True
        Me.btnGuardarEncuesta.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
        Me.btnGuardarEncuesta.Location = New System.Drawing.Point(655, 341)
        Me.btnGuardarEncuesta.Name = "btnGuardarEncuesta"
        Me.btnGuardarEncuesta.Size = New System.Drawing.Size(127, 28)
        Me.btnGuardarEncuesta.TabIndex = 5
        Me.btnGuardarEncuesta.Text = "Guardar encuesta"
        '
        'ResumenVehiculosTableAdapter
        '
        Me.ResumenVehiculosTableAdapter.ClearBeforeFill = True
        '
        'ResumenPersonasTableAdapter
        '
        Me.ResumenPersonasTableAdapter.ClearBeforeFill = True
        '
        'ComunaTableAdapter
        '
        Me.ComunaTableAdapter.ClearBeforeFill = True
        '
        'PropiedadTableAdapter
        '
        Me.PropiedadTableAdapter.ClearBeforeFill = True
        '
        'TipoVehTableAdapter
        '
        Me.TipoVehTableAdapter.ClearBeforeFill = True
        '
        'PropiedadVehiculoTableAdapter
        '
        Me.PropiedadVehiculoTableAdapter.ClearBeforeFill = True
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
        'JornadaTrabajoTableAdapter
        '
        Me.JornadaTrabajoTableAdapter.ClearBeforeFill = True
        '
        'DondeEstudiaTableAdapter
        '
        Me.DondeEstudiaTableAdapter.ClearBeforeFill = True
        '
        'TipoDiaTableAdapter
        '
        Me.TipoDiaTableAdapter.ClearBeforeFill = True
        '
        'CatastroHogaresTableAdapter
        '
        Me.CatastroHogaresTableAdapter.ClearBeforeFill = True
        '
        'ManzanasCatTableAdapter
        '
        Me.ManzanasCatTableAdapter.ClearBeforeFill = True
        '
        'ZonasCatTableAdapter
        '
        Me.ZonasCatTableAdapter.ClearBeforeFill = True
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(50, 20)
        '
        'CallesTableAdapter
        '
        Me.CallesTableAdapter.ClearBeforeFill = True
        '
        'HitoTableAdapter
        '
        Me.HitoTableAdapter.ClearBeforeFill = True
        '
        'TipoViviendaActualTableAdapter
        '
        Me.TipoViviendaActualTableAdapter.ClearBeforeFill = True
        '
        'ResumenHogaresTableAdapter1
        '
        Me.ResumenHogaresTableAdapter1.ClearBeforeFill = True
        '
        'CatastroHogaresTableAdapter1
        '
        Me.CatastroHogaresTableAdapter1.ClearBeforeFill = True
        '
        'cargaPreguntasHogar
        '
        '
        'ValidaHogarTableAdapter
        '
        Me.ValidaHogarTableAdapter.ClearBeforeFill = True
        '
        'ValidaPersonaTableAdapter
        '
        Me.ValidaPersonaTableAdapter.ClearBeforeFill = True
        '
        'ConsultaCalle2TrabajoTableAdapter
        '
        Me.ConsultaCalle2TrabajoTableAdapter.ClearBeforeFill = True
        '
        'ConsultaCalle2EstudioTableAdapter
        '
        Me.ConsultaCalle2EstudioTableAdapter.ClearBeforeFill = True
        '
        'TipoMotorTableAdapter
        '
        Me.TipoMotorTableAdapter.ClearBeforeFill = True
        '
        'TipoDiscapacidadTableAdapter
        '
        Me.TipoDiscapacidadTableAdapter.ClearBeforeFill = True
        '
        'NuevoHogar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 527)
        Me.Controls.Add(Me.tabPaneHogar)
        Me.Controls.Add(Me.RibbonControl)
        Me.Name = "NuevoHogar"
        Me.Ribbon = Me.RibbonControl
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ingresando nuevo hogar"
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tabPaneHogar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabPaneHogar.ResumeLayout(False)
        Me.tabPageHogar.ResumeLayout(False)
        Me.tabPageHogar.PerformLayout()
        CType(Me.lkpTieneVeh.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SiNoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.datasetEOD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        Me.GroupControl3.PerformLayout()
        CType(Me.lkpIndicaGFT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMontoGFT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
        CType(Me.PropiedadBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.txtReferenciaHogar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTelefono.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkpTipoVivienda.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TipoViviendaActualBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView29, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkpComuna.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComunaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCasaDepto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtComunaOtra.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNumero.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCalle.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkpManzana.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ManzanasCatBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkpZona.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ZonasCatBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkpFolio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CatastroHogaresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabPageVehículos.ResumeLayout(False)
        CType(Me.gcVehRegistrados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gcVehRegistrados.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ResumenVehiculosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.lkpTipoMotor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TipoMotorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAnioFabricacion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkpOtroVeh.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPropiedadVehOtro.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkpPropiedadVeh.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PropiedadVehiculoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkpTipoVeh.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TipoVehBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabPagePersonas.ResumeLayout(False)
        Me.tabPagePersonas.PerformLayout()
        CType(Me.lkpOtraPersona.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView30, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcPerRegistradas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gcPerRegistradas.ResumeLayout(False)
        CType(Me.gridPersonas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ResumenPersonasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridPersonasHogar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spcTrabajaEstudia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.spcTrabajaEstudia.ResumeLayout(False)
        CType(Me.y_trabajo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkpJornadaTrabajo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JornadaTrabajoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.x_trabajo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkpHitoTrabajo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HitoTrabajoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkpCalle2Trabajo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConsultaCalle2TrabajoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
        CType(Me.GridView28, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.x_estudio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkpDondeEstudia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DondeEstudiaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkpHitoEstudio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HitoEstudioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView24, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkpCalle2Estudio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConsultaCalle2EstudioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView25, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkpCalle1Estudio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Calle1EstudioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView26, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtComunaEstudioOtra.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkpComunaEstudio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComunaEstudioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView27, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkpManzanaEstudio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.splitEstudios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitEstudios.ResumeLayout(False)
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
        CType(Me.lkpRelacion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RelacionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAnoNacimiento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombrePila.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkpSexo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SexoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit3View, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabPageFecha.ResumeLayout(False)
        Me.tabPageFecha.PerformLayout()
        CType(Me.spcDiscapacidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.spcDiscapacidad.ResumeLayout(False)
        CType(Me.lkpPersonaAutosuficiente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView32, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkpTipoDiscapacidad.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TipoDiscapacidadBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView31, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deDomingoLV.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deDomingoLV.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deSabadoLV.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deSabadoLV.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deFechaViajes.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deFechaViajes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkpTipoDia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TipoDiaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit28View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtObservacion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkpPersonaDiscapacidad.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents tabPaneHogar As DevExpress.XtraBars.Navigation.TabPane
    Friend WithEvents tabPageHogar As DevExpress.XtraBars.Navigation.TabNavigationPage
    Friend WithEvents tabPageVehículos As DevExpress.XtraBars.Navigation.TabNavigationPage
    Friend WithEvents tabPagePersonas As DevExpress.XtraBars.Navigation.TabNavigationPage
    Friend WithEvents tabPageFecha As DevExpress.XtraBars.Navigation.TabNavigationPage
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lblComunaOtra As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lkpComuna As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView6 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCasaDepto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtComunaOtra As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNumero As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCalle As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lkpManzana As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lkpZona As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lkpFolio As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView5 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btnCancelarHogar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnGuardarHogar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lkpTieneVeh As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView9 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl21 As DevExpress.XtraEditors.LabelControl
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
    Friend WithEvents btnCancelarVeh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lkpPropiedadVeh As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colID3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPropiedadVehiculo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lkpTipoVeh As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colvehiculo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnGuardarVehiculo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gcVehRegistrados As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView7 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents datasetEOD As EOD.datasetEOD
    Friend WithEvents ResumenVehiculosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ResumenVehiculosTableAdapter As EOD.datasetEODTableAdapters.ResumenVehiculosTableAdapter
    Friend WithEvents colHogar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVehículo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colvehiculo1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtNombrePila As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lkpSexo As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit3View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtAnoNacimiento As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lkpRelacion As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView10 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents lblEstudiosCompletos As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lkpEstudiosCompletos As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView12 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lkpEstudios As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView11 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl22 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblLicencia As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lkpLicencia As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView14 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents splitEstudios As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents spcTrabajaEstudia As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents gcPerRegistradas As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnCancelarPersona As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnGuardarPersona As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gridPersonas As DevExpress.XtraGrid.GridControl
    Friend WithEvents gridPersonasHogar As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ResumenPersonasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ResumenPersonasTableAdapter As EOD.datasetEODTableAdapters.ResumenPersonasTableAdapter
    Friend WithEvents colHogar1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPersona As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombrePila As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSexo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRelacion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl24 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lkpComunaTrabajo As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView16 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl25 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtComunaTrabajoOtra As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblComunaTrabajoOtra As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lkpCalle2Trabajo As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView18 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents lkpCalle1Trabajo As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView17 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents lblCalle2Trabajo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblCalle1Trabajo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lkpHitoTrabajo As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView20 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents lblManzanaTrabajo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblHitoTrabajo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lkpJornadaTrabajo As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView21 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl31 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lkpDondeEstudia As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView22 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl32 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lkpHitoEstudio As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView24 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents lblManzanaEstudio As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblHitoEstudio As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lkpCalle2Estudio As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView25 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents lkpCalle1Estudio As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView26 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents lblCalle2Estudio As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblCalle1Estudio As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtComunaEstudioOtra As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblComunaEstudioOtra As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lkpComunaEstudio As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView27 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl38 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl39 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lkpTieneTNE As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView28 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl40 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnGuardarEncuesta As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents chkActividad As DevExpress.XtraEditors.CheckedComboBoxEdit
    Friend WithEvents ComunaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ComunaTableAdapter As EOD.datasetEODTableAdapters.ComunaTableAdapter
    Friend WithEvents PropiedadBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PropiedadTableAdapter As EOD.datasetEODTableAdapters.PropiedadTableAdapter
    Friend WithEvents TipoVehBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TipoVehTableAdapter As EOD.datasetEODTableAdapters.TipoVehTableAdapter
    Friend WithEvents PropiedadVehiculoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PropiedadVehiculoTableAdapter As EOD.datasetEODTableAdapters.PropiedadVehiculoTableAdapter
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
    Friend WithEvents JornadaTrabajoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents JornadaTrabajoTableAdapter As EOD.datasetEODTableAdapters.JornadaTrabajoTableAdapter
    Friend WithEvents DondeEstudiaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DondeEstudiaTableAdapter As EOD.datasetEODTableAdapters.DondeEstudiaTableAdapter
    Friend WithEvents TipoDiaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TipoDiaTableAdapter As EOD.datasetEODTableAdapters.TipoDiaTableAdapter
    Friend WithEvents CatastroHogaresBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CatastroHogaresTableAdapter As EOD.datasetEODTableAdapters.CatastroHogaresTableAdapter
    Friend WithEvents ManzanasCatBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ManzanasCatTableAdapter As EOD.datasetEODTableAdapters.ManzanasCatTableAdapter
    Friend WithEvents ZonasCatBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ZonasCatTableAdapter As EOD.datasetEODTableAdapters.ZonasCatTableAdapter
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents colZonaEOD1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colManzana As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colZonaEOD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIDFolio As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPropiedad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colComuna As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOpcion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkpOtroVeh As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView13 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPropiedadVehOtro As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblPropiedadVehOtro As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl45 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTelefono As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lkpTipoVivienda As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView29 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl44 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lkpOtraPersona As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView30 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl46 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents colSexo1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtActividadOtra As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblActividadOtra As DevExpress.XtraEditors.LabelControl
    Friend WithEvents colOpcion1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOpcion2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ComunaTrabajoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents colComuna1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEstudio As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRelacion1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOpcion4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colJornadaTrabajo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOpcion3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDondeEstudia As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Calle1TrabajoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CallesTableAdapter As EOD.datasetEODTableAdapters.CallesTableAdapter
    Friend WithEvents HitoTrabajoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents HitoTableAdapter As EOD.datasetEODTableAdapters.HitoTableAdapter
    Friend WithEvents HitoEstudioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Calle1EstudioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ComunaEstudioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents colcalle As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkpManzanaTrabajo As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents y_trabajo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl47 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents x_trabajo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents y_estudio As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl48 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents x_estudio As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl49 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lkpManzanaEstudio As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents colhito As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcalle2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colhito1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcalle21 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcalle1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colComuna2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TipoViviendaActualBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TipoViviendaActualTableAdapter As EOD.datasetEODTableAdapters.TipoViviendaActualTableAdapter
    Friend WithEvents colTipoViviendaActual As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOpcion5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ResumenHogaresTableAdapter1 As EOD.datasetEODTableAdapters.ResumenHogaresTableAdapter
    Friend WithEvents CatastroHogaresTableAdapter1 As EOD.datasetEODTableAdapters.CatastroHogaresTableAdapter
    Friend WithEvents lblReferenciaHogar As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtReferenciaHogar As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl23 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents splitPropiedadPago As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents lblPropiedadOtra As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPropiedadOtra As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cargaPreguntasHogar As System.ComponentModel.BackgroundWorker
    Friend WithEvents cargaPreguntasVehiculo As System.ComponentModel.BackgroundWorker
    Friend WithEvents cargaPreguntasPersona As System.ComponentModel.BackgroundWorker
    Friend WithEvents cargaPreguntasFecha As System.ComponentModel.BackgroundWorker
    Friend WithEvents lanzaPantallaEspera As DevExpress.XtraSplashScreen.SplashScreenManager
    Friend WithEvents lanzaPantallaEspera2 As DevExpress.XtraSplashScreen.SplashScreenManager
    Friend WithEvents lanzaPantallaEspera3 As DevExpress.XtraSplashScreen.SplashScreenManager
    Friend WithEvents lanzaPantallaEspera4 As DevExpress.XtraSplashScreen.SplashScreenManager
    Friend WithEvents cbWaypoint As System.Windows.Forms.ComboBox
    Friend WithEvents lblWaypoint As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnRechazoVehiculo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnRechazoPersona As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnRechazoFecha As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ValidaHogarTableAdapter As EOD.datasetEODTableAdapters.ValidaHogarTableAdapter
    Friend WithEvents ValidaPersonaTableAdapter As EOD.datasetEODTableAdapters.ValidaPersonaTableAdapter
    Friend WithEvents SplashScreenManager1 As DevExpress.XtraSplashScreen.SplashScreenManager
    Friend WithEvents txtMontoGFT As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl27 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtAnioFabricacion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDondeEstudiaOtro As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblDondeEstudiaOtro As DevExpress.XtraEditors.LabelControl
    Friend WithEvents colTipoMotor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ConsultaCalle2TrabajoBindingSource As BindingSource
    Friend WithEvents ConsultaCalle2TrabajoTableAdapter As datasetEODTableAdapters.ConsultaCalle2TrabajoTableAdapter
    Friend WithEvents ConsultaCalle2EstudioBindingSource As BindingSource
    Friend WithEvents ConsultaCalle2EstudioTableAdapter As datasetEODTableAdapters.ConsultaCalle2EstudioTableAdapter
    Friend WithEvents lkpTipoMotor As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView19 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl26 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TipoMotorBindingSource As BindingSource
    Friend WithEvents TipoMotorTableAdapter As datasetEODTableAdapters.TipoMotorTableAdapter
    Friend WithEvents lblMontoGFT As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lkpIndicaGFT As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView15 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl28 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lkpPersonaAutosuficiente As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView32 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl33 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lkpTipoDiscapacidad As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView31 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl30 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lkpPersonaDiscapacidad As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView23 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl29 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents spcDiscapacidad As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents lblNotaLV As DevExpress.XtraEditors.LabelControl
    Friend WithEvents deDomingoLV As DevExpress.XtraEditors.DateEdit
    Friend WithEvents lblDomingoLV As DevExpress.XtraEditors.LabelControl
    Friend WithEvents deSabadoLV As DevExpress.XtraEditors.DateEdit
    Friend WithEvents lblSabadoLV As DevExpress.XtraEditors.LabelControl
    Friend WithEvents deFechaViajes As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl43 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lkpTipoDia As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit28View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colTipoDia As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl42 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl41 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtObservacion As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents TipoDiscapacidadBindingSource As BindingSource
    Friend WithEvents TipoDiscapacidadTableAdapter As datasetEODTableAdapters.TipoDiscapacidadTableAdapter
End Class
