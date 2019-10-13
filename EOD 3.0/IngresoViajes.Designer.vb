<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IngresoViajes
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl112 = New DevExpress.XtraEditors.LabelControl()
        Me.tmHoraLlegada = New DevExpress.XtraEditors.TimeEdit()
        Me.lkpTrasnoche = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.SiNoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.datasetEOD = New EOD.datasetEOD()
        Me.GridView8 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colId25 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOpcion1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cargaDatosViajeBackground = New System.ComponentModel.BackgroundWorker()
        Me.tabsEtapas = New DevExpress.XtraTab.XtraTabControl()
        Me.tabTransporte1 = New DevExpress.XtraTab.XtraTabPage()
        Me.gcLugarBajadaEtapa1 = New DevExpress.XtraEditors.GroupControl()
        Me.spcCallesEtapa1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.lblComunaOtraEtapa1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtComunaOtraEtapa1 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl136 = New DevExpress.XtraEditors.LabelControl()
        Me.lblManzanaEtapa1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl138 = New DevExpress.XtraEditors.LabelControl()
        Me.x_etapa1 = New DevExpress.XtraEditors.TextEdit()
        Me.lblCalle1Etapa1 = New DevExpress.XtraEditors.LabelControl()
        Me.y_etapa1 = New DevExpress.XtraEditors.TextEdit()
        Me.lblCalle2Etapa1 = New DevExpress.XtraEditors.LabelControl()
        Me.lblHitoEtapa1 = New DevExpress.XtraEditors.LabelControl()
        Me.lkpManzanaEtapa1 = New DevExpress.XtraEditors.LookUpEdit()
        Me.lkpCalle1Etapa1 = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.CallesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView30 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colid31 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcalle4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.lkpCalle2Etapa1 = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.ConsultaCalle2Etapa1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView31 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID32 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcalle14 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcalle23 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colconflictiva2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.lkpHitoEtapa1 = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.HitoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView32 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colid33 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colhito3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colhitoManzana3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.lblComunaEtapa1 = New DevExpress.XtraEditors.LabelControl()
        Me.lkpComunaEtapa1 = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.ComunaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView29 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID30 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colComuna3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.tabsEtapa1 = New DevExpress.XtraTab.XtraTabControl()
        Me.tabTaxi = New DevExpress.XtraTab.XtraTabPage()
        Me.LabelControl207 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl82 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl83 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl85 = New DevExpress.XtraEditors.LabelControl()
        Me.txtMinutosEsperaTaxiE1 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl90 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCuadrasTaxiE1 = New DevExpress.XtraEditors.TextEdit()
        Me.txtTarifaMontoTaxiE1 = New DevExpress.XtraEditors.TextEdit()
        Me.txtMinutosTaxiE1 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl89 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl87 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl88 = New DevExpress.XtraEditors.LabelControl()
        Me.lkpLugarBajadaTaxiE1 = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.DondeSeBajoE1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView35 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colId35 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDondeSeBajo1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.tabAuto = New DevExpress.XtraTab.XtraTabPage()
        Me.LabelControl19 = New DevExpress.XtraEditors.LabelControl()
        Me.lkpVehHogarE1 = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.ResumenVehiculosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView19 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colvehiculo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCombustible = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.panelPreguntasChofer = New DevExpress.XtraEditors.PanelControl()
        Me.spcPagoBajadaAutoE1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.spcFormaPagoE1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.lkpFormaPagoE1 = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.FormaPagoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView18 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID20 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFormaPago = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelControl26 = New DevExpress.XtraEditors.LabelControl()
        Me.lkpDondeEstacionaE1 = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.DondeEstacionaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DatasetEODBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView17 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn18 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn53 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelControl27 = New DevExpress.XtraEditors.LabelControl()
        Me.spcPagoEstacionamientoE1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.chkNSNRPagoE1 = New DevExpress.XtraEditors.CheckEdit()
        Me.TabFormDefaultManager1 = New DevExpress.XtraBars.TabFormDefaultManager()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.lblCuantoPagoE1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCuantoPagoE1 = New DevExpress.XtraEditors.TextEdit()
        Me.lblLugarDondeBajoE1 = New DevExpress.XtraEditors.LabelControl()
        Me.lkpLugarBajadaAutoE1 = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView16 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID18 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLugarDondeBajo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelControl35 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl36 = New DevExpress.XtraEditors.LabelControl()
        Me.txtMinutosAutoE1 = New DevExpress.XtraEditors.TextEdit()
        Me.txtCuadrasAutoE1 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl37 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl38 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl39 = New DevExpress.XtraEditors.LabelControl()
        Me.lkpViajaComoE1 = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.ViajaComoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView15 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colId15 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colViajaComo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.lkpQueVehiculoE1 = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.QueVehiculoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView7 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colId21 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQueVehiculo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.tabBicicleta = New DevExpress.XtraTab.XtraTabPage()
        Me.lkpLugarBajadaBiciE1 = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView53 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn33 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn34 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelControl137 = New DevExpress.XtraEditors.LabelControl()
        Me.spcPropiedadBicicletaE1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.txtPropiedadBicicletaOtraE1 = New DevExpress.XtraEditors.TextEdit()
        Me.lblPropiedadBiciOtraE1 = New DevExpress.XtraEditors.LabelControl()
        Me.spcMotivoNoUsaE1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.txtMotivoNoUsaE1 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl79 = New DevExpress.XtraEditors.LabelControl()
        Me.lkpEstacionamientoBiciE1 = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.EstacionamientoBicicletaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView37 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn54 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn55 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelControl102 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl57 = New DevExpress.XtraEditors.LabelControl()
        Me.lkpCicloviaE1 = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView26 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn51 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn52 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelControl48 = New DevExpress.XtraEditors.LabelControl()
        Me.lkpPropiedadBicicletaE1 = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.PropiedadBicicletaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView25 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID26 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPropiedadBicicleta = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.tabBus = New DevExpress.XtraTab.XtraTabPage()
        Me.txtMinutosEsperaBusE1 = New DevExpress.XtraEditors.TextEdit()
        Me.spcCuantoPagoBusE1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.LabelControl208 = New DevExpress.XtraEditors.LabelControl()
        Me.txtTarifaMontoBusE1 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl53 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl60 = New DevExpress.XtraEditors.LabelControl()
        Me.lkpLugarBajadaBusE1 = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView34 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colId34 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDondeSeBajo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelControl61 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl66 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl67 = New DevExpress.XtraEditors.LabelControl()
        Me.txtMinutosBusE1 = New DevExpress.XtraEditors.TextEdit()
        Me.txtCuadrasBusE1 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl68 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl69 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl70 = New DevExpress.XtraEditors.LabelControl()
        Me.lkpTipoTarifaBusE1 = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.TipoTarifaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView33 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID24 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTipoTarifaBus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.tabTXC = New DevExpress.XtraTab.XtraTabPage()
        Me.LabelControl209 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl113 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl173 = New DevExpress.XtraEditors.LabelControl()
        Me.txtMinutosEsperaTXCE1 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl174 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCuadrasTXCE1 = New DevExpress.XtraEditors.TextEdit()
        Me.txtTarifaMontoTXCE1 = New DevExpress.XtraEditors.TextEdit()
        Me.txtMinutosTXCE1 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl175 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl176 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl177 = New DevExpress.XtraEditors.LabelControl()
        Me.lkpLugarBajadaTXCE1 = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView64 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn76 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn77 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.tabTransporte2 = New DevExpress.XtraTab.XtraTabPage()
        Me.gcLugarBajadaEtapa2 = New DevExpress.XtraEditors.GroupControl()
        Me.spcCallesEtapa2 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.LabelControl25 = New DevExpress.XtraEditors.LabelControl()
        Me.txtComunaOtraEtapa2 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl145 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl146 = New DevExpress.XtraEditors.LabelControl()
        Me.x_etapa2 = New DevExpress.XtraEditors.TextEdit()
        Me.y_etapa2 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl29 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl30 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl31 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl32 = New DevExpress.XtraEditors.LabelControl()
        Me.lkpManzanaEtapa2 = New DevExpress.XtraEditors.LookUpEdit()
        Me.lkpCalle1Etapa2 = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView39 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.lkpCalle2Etapa2 = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.ConsultaCalle2Etapa2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView40 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.lkpHitoEtapa2 = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView41 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelControl33 = New DevExpress.XtraEditors.LabelControl()
        Me.lkpComunaEtapa2 = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView42 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.tabsEtapa2 = New DevExpress.XtraTab.XtraTabControl()
        Me.tabTaxiE2 = New DevExpress.XtraTab.XtraTabPage()
        Me.LabelControl34 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl45 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl212 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl40 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl41 = New DevExpress.XtraEditors.LabelControl()
        Me.txtMinutosEsperaTaxiE2 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl42 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCuadrasTaxiE2 = New DevExpress.XtraEditors.TextEdit()
        Me.txtTarifaMontoTaxiE2 = New DevExpress.XtraEditors.TextEdit()
        Me.txtMinutosTaxiE2 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl43 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl44 = New DevExpress.XtraEditors.LabelControl()
        Me.lkpLugarBajadaTaxiE2 = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.DondeSeBajoE2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView36 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.tabAutoE2 = New DevExpress.XtraTab.XtraTabPage()
        Me.LabelControl62 = New DevExpress.XtraEditors.LabelControl()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.spcPagoBajadaAutoE2 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.spcPagoEstacionamientoE2 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.chkNSNRPagoE2 = New DevExpress.XtraEditors.CheckEdit()
        Me.txtCuantoPagoE2 = New DevExpress.XtraEditors.TextEdit()
        Me.lblCuantoPagoE2 = New DevExpress.XtraEditors.LabelControl()
        Me.spcFormaPagoE2 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.LabelControl54 = New DevExpress.XtraEditors.LabelControl()
        Me.lkpFormaPagoE2 = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView43 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn15 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.lkpDondeEstacionaE2 = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView59 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn56 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn57 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelControl64 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl58 = New DevExpress.XtraEditors.LabelControl()
        Me.lkpLugarBajadaAutoE2 = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView44 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn16 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn17 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.lkpVehHogarE2 = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView45 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colvehiculo1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCombustible1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelControl84 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl86 = New DevExpress.XtraEditors.LabelControl()
        Me.txtMinutosAutoE2 = New DevExpress.XtraEditors.TextEdit()
        Me.txtCuadrasAutoE2 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl91 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl92 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl93 = New DevExpress.XtraEditors.LabelControl()
        Me.lkpViajaComoE2 = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView47 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn21 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn22 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.lkpQueVehiculoE2 = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView48 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn23 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn24 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.tabBicicletaE2 = New DevExpress.XtraTab.XtraTabPage()
        Me.spcPropiedadBicicletaE2 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.txtPropiedadBicicletaOtraE2 = New DevExpress.XtraEditors.TextEdit()
        Me.lblPropiedadBiciOtraE2 = New DevExpress.XtraEditors.LabelControl()
        Me.spcMotivoNoUsaE2 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.txtMotivoNoUsaE2 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl124 = New DevExpress.XtraEditors.LabelControl()
        Me.lkpEstacionamientoBiciE2 = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView62 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn79 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn93 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelControl125 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl28 = New DevExpress.XtraEditors.LabelControl()
        Me.lkpCicloviaE2 = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView24 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn44 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn45 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelControl94 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl172 = New DevExpress.XtraEditors.LabelControl()
        Me.lkpPropiedadBicicletaE2 = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView49 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn25 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn26 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.lkpLugarBajadaBiciE2 = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView14 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn74 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn75 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.tabBusE2 = New DevExpress.XtraTab.XtraTabPage()
        Me.txtMinutosEsperaBusE2 = New DevExpress.XtraEditors.TextEdit()
        Me.spcCuantoPagoBusE2 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.LabelControl216 = New DevExpress.XtraEditors.LabelControl()
        Me.txtTarifaMontoBusE2 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl95 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl96 = New DevExpress.XtraEditors.LabelControl()
        Me.lkpLugarBajadaBusE2 = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView50 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn27 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn28 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelControl97 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl98 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl99 = New DevExpress.XtraEditors.LabelControl()
        Me.txtMinutosBusE2 = New DevExpress.XtraEditors.TextEdit()
        Me.txtCuadrasBusE2 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl100 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl103 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl117 = New DevExpress.XtraEditors.LabelControl()
        Me.lkpTipoTarifaBusE2 = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView51 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn29 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn30 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.tabTXCE2 = New DevExpress.XtraTab.XtraTabPage()
        Me.LabelControl214 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl129 = New DevExpress.XtraEditors.LabelControl()
        Me.txtTarifaMontoTXCE2 = New DevExpress.XtraEditors.TextEdit()
        Me.txtMinutosEsperaTXCE2 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl130 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl131 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl132 = New DevExpress.XtraEditors.LabelControl()
        Me.txtMinutosTXCE2 = New DevExpress.XtraEditors.TextEdit()
        Me.txtCuadrasTXCE2 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl133 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl134 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl135 = New DevExpress.XtraEditors.LabelControl()
        Me.lkpLugarBajadaTXCE2 = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView52 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn31 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn32 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.tabTransporte3 = New DevExpress.XtraTab.XtraTabPage()
        Me.gcLugarBajadaEtapa3 = New DevExpress.XtraEditors.GroupControl()
        Me.spcCallesEtapa3 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl()
        Me.txtComunaOtraEtapa3 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl17 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl118 = New DevExpress.XtraEditors.LabelControl()
        Me.x_etapa3 = New DevExpress.XtraEditors.TextEdit()
        Me.y_etapa3 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl119 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl120 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl121 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl122 = New DevExpress.XtraEditors.LabelControl()
        Me.lkpManzanaEtapa3 = New DevExpress.XtraEditors.LookUpEdit()
        Me.lkpCalle1Etapa3 = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView46 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn80 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn81 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.lkpCalle2Etapa3 = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.ConsultaCalle2Etapa3BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView70 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn82 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn83 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn84 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn85 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.lkpHitoEtapa3 = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView71 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn86 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn87 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn88 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelControl123 = New DevExpress.XtraEditors.LabelControl()
        Me.lkpComunaEtapa3 = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView72 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn89 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn90 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.tabsEtapa3 = New DevExpress.XtraTab.XtraTabControl()
        Me.tabTaxiE3 = New DevExpress.XtraTab.XtraTabPage()
        Me.LabelControl71 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl77 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl217 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl72 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl73 = New DevExpress.XtraEditors.LabelControl()
        Me.txtMinutosEsperaTaxiE3 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl74 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCuadrasTaxiE3 = New DevExpress.XtraEditors.TextEdit()
        Me.txtTarifaMontoTaxiE3 = New DevExpress.XtraEditors.TextEdit()
        Me.txtMinutosTaxiE3 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl75 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl76 = New DevExpress.XtraEditors.LabelControl()
        Me.lkpLugarBajadaTaxiE3 = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.DondeSeBajoE3BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView38 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn37 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn38 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.tabAutoE3 = New DevExpress.XtraTab.XtraTabPage()
        Me.LabelControl101 = New DevExpress.XtraEditors.LabelControl()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.spcPagoBajadaAutoE3 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.spcPagoEstacionamientoE3 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.chkNSNRPagoE3 = New DevExpress.XtraEditors.CheckEdit()
        Me.txtCuantoPagoE3 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl80 = New DevExpress.XtraEditors.LabelControl()
        Me.spcFormaPagoE3 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.LabelControl56 = New DevExpress.XtraEditors.LabelControl()
        Me.lkpFormaPagoE3 = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView56 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn39 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn40 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.lkpDondeEstacionaE3 = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView55 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn58 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn78 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelControl78 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl81 = New DevExpress.XtraEditors.LabelControl()
        Me.lkpLugarBajadaAutoE3 = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView57 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn41 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn42 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.lkpVehHogarE3 = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView58 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn43 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCombustible2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelControl107 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl108 = New DevExpress.XtraEditors.LabelControl()
        Me.txtMinutosAutoE3 = New DevExpress.XtraEditors.TextEdit()
        Me.txtCuadrasAutoE3 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl109 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl110 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl111 = New DevExpress.XtraEditors.LabelControl()
        Me.lkpViajaComoE3 = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView60 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn46 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn47 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.lkpQueVehiculoE3 = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView63 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn48 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn63 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.tabBicicletaE3 = New DevExpress.XtraTab.XtraTabPage()
        Me.spcPropiedadBicicletaE3 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.txtPropiedadBicicletaOtraE3 = New DevExpress.XtraEditors.TextEdit()
        Me.lblPropiedadBiciOtraE3 = New DevExpress.XtraEditors.LabelControl()
        Me.spcMotivoNoUsaE3 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.txtMotivoNoUsaE3 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl126 = New DevExpress.XtraEditors.LabelControl()
        Me.lkpEstacionamientoBiciE3 = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView69 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn94 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn95 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelControl127 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl18 = New DevExpress.XtraEditors.LabelControl()
        Me.lkpCicloviaE3 = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView23 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn19 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn20 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelControl141 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl140 = New DevExpress.XtraEditors.LabelControl()
        Me.lkpPropiedadBicicletaE3 = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView65 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn66 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn67 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.lkpLugarBajadaBiciE3 = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView54 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn35 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn36 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.tabBusE3 = New DevExpress.XtraTab.XtraTabPage()
        Me.txtMinutosEsperaBusE3 = New DevExpress.XtraEditors.TextEdit()
        Me.spcCuantoPagoBusE3 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.LabelControl221 = New DevExpress.XtraEditors.LabelControl()
        Me.txtTarifaMontoBusE3 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl142 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl143 = New DevExpress.XtraEditors.LabelControl()
        Me.lkpLugarBajadaBusE3 = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView66 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn68 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn69 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelControl144 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl149 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl150 = New DevExpress.XtraEditors.LabelControl()
        Me.txtMinutosBusE3 = New DevExpress.XtraEditors.TextEdit()
        Me.txtCuadrasBusE3 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl151 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl152 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl153 = New DevExpress.XtraEditors.LabelControl()
        Me.lkpTipoTarifaBusE3 = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView67 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn70 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn71 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.tabTXCE3 = New DevExpress.XtraTab.XtraTabPage()
        Me.LabelControl219 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl165 = New DevExpress.XtraEditors.LabelControl()
        Me.txtTarifaMontoTXCE3 = New DevExpress.XtraEditors.TextEdit()
        Me.txtMinutosEsperaTXCE3 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl166 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl167 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl168 = New DevExpress.XtraEditors.LabelControl()
        Me.txtMinutosTXCE3 = New DevExpress.XtraEditors.TextEdit()
        Me.txtCuadrasTXCE3 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl169 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl170 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl171 = New DevExpress.XtraEditors.LabelControl()
        Me.lkpLugarBajadaTXCE3 = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView68 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn72 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn73 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PagaEstacionamientoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MuelleBajadaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MuelleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MetrotrenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TerrasurBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lkpProposito = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.PropositoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView9 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProposito = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.tmHoraSalida = New DevExpress.XtraEditors.TimeEdit()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.spDestinoViaje = New DevExpress.XtraEditors.SplitContainerControl()
        Me.txtOtroProposito = New DevExpress.XtraEditors.TextEdit()
        Me.lblOtroProposito = New DevExpress.XtraEditors.LabelControl()
        Me.spLugarDeclarado = New DevExpress.XtraEditors.SplitContainerControl()
        Me.lkpTrabajoDeclarado = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView21 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn64 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn65 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.lblTrabajoDeclarado = New DevExpress.XtraEditors.LabelControl()
        Me.lkpEstudioDeclarado = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView73 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn91 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn92 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.lblEstudioDeclarado = New DevExpress.XtraEditors.LabelControl()
        Me.spcCallesDestino = New DevExpress.XtraEditors.SplitContainerControl()
        Me.txtComunaDestinoOtra = New DevExpress.XtraEditors.TextEdit()
        Me.lblComunaDestinoOtra = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl24 = New DevExpress.XtraEditors.LabelControl()
        Me.lkpCalle1Destino = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colid13 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcalle = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.lkpHitoDestino = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView5 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colid14 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colhito1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colhitoManzana1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.lkpCalle2Destino = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.ConsultaCalle2DestinoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView6 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID16 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcalle11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcalle2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.lkpManzanaDestino = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl()
        Me.lkpComunaDestino = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView11 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colComuna1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.spcViaje = New DevExpress.XtraEditors.SplitContainerControl()
        Me.LabelControl23 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl147 = New DevExpress.XtraEditors.LabelControl()
        Me.lblTransporte3 = New DevExpress.XtraEditors.LabelControl()
        Me.lblTransporte2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.lkpTransporte1 = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.ModoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView10 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colModo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.lkpTransporte2 = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.Modo2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView12 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID12 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colModo3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.lkpTransporte3 = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.Modo3BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView13 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colModo1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelControl115 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCuadrasDespues = New DevExpress.XtraEditors.TextEdit()
        Me.panelFinViaje = New DevExpress.XtraEditors.PanelControl()
        Me.lkpOtroViaje = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView61 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn49 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn50 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelControl63 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl116 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl105 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl59 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl55 = New DevExpress.XtraEditors.LabelControl()
        Me.x_destino = New DevExpress.XtraEditors.TextEdit()
        Me.y_destino = New DevExpress.XtraEditors.TextEdit()
        Me.x_origen = New DevExpress.XtraEditors.TextEdit()
        Me.y_origen = New DevExpress.XtraEditors.TextEdit()
        Me.txtMinutosDespues = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl20 = New DevExpress.XtraEditors.LabelControl()
        Me.btnGuardarViaje = New DevExpress.XtraEditors.SimpleButton()
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.spcPrimerViaje = New DevExpress.XtraEditors.SplitContainerControl()
        Me.LabelControl21 = New DevExpress.XtraEditors.LabelControl()
        Me.spcCallesPrimerViaje = New DevExpress.XtraEditors.SplitContainerControl()
        Me.lblComunaOrigenOtra = New DevExpress.XtraEditors.LabelControl()
        Me.txtComunaOrigenOtra = New DevExpress.XtraEditors.TextEdit()
        Me.lkpCalle2Origen = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.ConsultaCalle2OrigenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID17 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcalle12 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcalle21 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colconflictiva = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.lkpCalle1Origen = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridLookUpEdit2View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colid1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colcalle1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.lkpManzanaOrigen = New DevExpress.XtraEditors.LookUpEdit()
        Me.lkpHitoOrigen = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colhito = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colhitoManzana = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.lblComunaOrigen = New DevExpress.XtraEditors.LabelControl()
        Me.lkpComunaOrigen = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colComuna = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.lkpDondePrimerViaje = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.LugarPrimerViajeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colId3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLugarPrimerViaje = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.lblNoViajaOtro = New DevExpress.XtraEditors.LabelControl()
        Me.txtNoViajaOtro = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl22 = New DevExpress.XtraEditors.LabelControl()
        Me.lkpNoViaja = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.NoViajaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView22 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNoViaja = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.lkpRealizoViajes = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView20 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colId2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOpcion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl()
        Me.spcRealizoViajes = New DevExpress.XtraEditors.SplitContainerControl()
        Me.tabsInicioViaje = New DevExpress.XtraTab.XtraTabControl()
        Me.tabPrimerViaje = New DevExpress.XtraTab.XtraTabPage()
        Me.tabViajeAnterior = New DevExpress.XtraTab.XtraTabPage()
        Me.gcViajeAnterior = New DevExpress.XtraEditors.GroupControl()
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl46 = New DevExpress.XtraEditors.LabelControl()
        Me.spCallesViajeAnterior = New DevExpress.XtraEditors.SplitContainerControl()
        Me.txtComunaOtraAnterior = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl47 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl49 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl50 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl51 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl52 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCalle1Anterior = New DevExpress.XtraEditors.TextEdit()
        Me.txtCalle2Anterior = New DevExpress.XtraEditors.TextEdit()
        Me.txtHitoAnterior = New DevExpress.XtraEditors.TextEdit()
        Me.txtManzanaAnterior = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl148 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl65 = New DevExpress.XtraEditors.LabelControl()
        Me.lkpComunaAnterior = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView27 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn59 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn60 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelControl104 = New DevExpress.XtraEditors.LabelControl()
        Me.lkpPropositoAnterior = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.GridView28 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn61 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn62 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelControl106 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl114 = New DevExpress.XtraEditors.LabelControl()
        Me.tmFinAnterior = New DevExpress.XtraEditors.TimeEdit()
        Me.tmInicioAnterior = New DevExpress.XtraEditors.TimeEdit()
        Me.SiNoTableAdapter = New EOD.datasetEODTableAdapters.SiNoTableAdapter()
        Me.LugarPrimerViajeTableAdapter = New EOD.datasetEODTableAdapters.LugarPrimerViajeTableAdapter()
        Me.PropositoTableAdapter = New EOD.datasetEODTableAdapters.PropositoTableAdapter()
        Me.ComunaTableAdapter = New EOD.datasetEODTableAdapters.ComunaTableAdapter()
        Me.ModoTableAdapter = New EOD.datasetEODTableAdapters.ModoTableAdapter()
        Me.CallesTableAdapter = New EOD.datasetEODTableAdapters.CallesTableAdapter()
        Me.ConsultaCalle2BTableAdapter = New EOD.datasetEODTableAdapters.ConsultaCalle2BTableAdapter()
        Me.HitoTableAdapter = New EOD.datasetEODTableAdapters.HitoTableAdapter()
        Me.NoViajaTableAdapter = New EOD.datasetEODTableAdapters.NoViajaTableAdapter()
        Me.DondeSeBajoTableAdapter = New EOD.datasetEODTableAdapters.DondeSeBajoTableAdapter()
        Me.TipoTarifaTableAdapter = New EOD.datasetEODTableAdapters.TipoTarifaTableAdapter()
        Me.PropiedadBicicletaTableAdapter = New EOD.datasetEODTableAdapters.PropiedadBicicletaTableAdapter()
        Me.ViajaComoTableAdapter = New EOD.datasetEODTableAdapters.ViajaComoTableAdapter()
        Me.QueVehiculoTableAdapter = New EOD.datasetEODTableAdapters.QueVehiculoTableAdapter()
        Me.ResumenVehiculosTableAdapter = New EOD.datasetEODTableAdapters.ResumenVehiculosTableAdapter()
        Me.FormaPagoTableAdapter = New EOD.datasetEODTableAdapters.FormaPagoTableAdapter()
        Me.PagaEstacionamientoTableAdapter = New EOD.datasetEODTableAdapters.PagaEstacionamientoTableAdapter()
        Me.ValidaViajeTableAdapter = New EOD.datasetEODTableAdapters.ValidaViajeTableAdapter()
        Me.ValidaEtapaTableAdapter = New EOD.datasetEODTableAdapters.ValidaEtapaTableAdapter()
        Me.btnRechazoViaje = New DevExpress.XtraEditors.SimpleButton()
        Me.ValidaPersonaTableAdapter = New EOD.datasetEODTableAdapters.ValidaPersonaTableAdapter()
        Me.MetrotrenTableAdapter = New EOD.datasetEODTableAdapters.MetrotrenTableAdapter()
        Me.TerrasurTableAdapter = New EOD.datasetEODTableAdapters.TerrasurTableAdapter()
        Me.DefaultLookAndFeel3 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
        Me.ConsultaCalle2OrigenTableAdapter = New EOD.datasetEODTableAdapters.ConsultaCalle2OrigenTableAdapter()
        Me.ConsultaCalle2DestinoTableAdapter = New EOD.datasetEODTableAdapters.ConsultaCalle2DestinoTableAdapter()
        Me.ConsultaCalle2Etapa1TableAdapter = New EOD.datasetEODTableAdapters.ConsultaCalle2Etapa1TableAdapter()
        Me.ConsultaCalle2Etapa2TableAdapter = New EOD.datasetEODTableAdapters.ConsultaCalle2Etapa2TableAdapter()
        Me.ConsultaCalle2Etapa3TableAdapter = New EOD.datasetEODTableAdapters.ConsultaCalle2Etapa3TableAdapter()
        Me.MuelleTableAdapter = New EOD.datasetEODTableAdapters.MuelleTableAdapter()
        Me.DondeEstacionaTableAdapter = New EOD.datasetEODTableAdapters.DondeEstacionaTableAdapter()
        Me.EstacionamientoBicicletaTableAdapter = New EOD.datasetEODTableAdapters.EstacionamientoBicicletaTableAdapter()
        CType(Me.tmHoraLlegada.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lkpTrasnoche.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.SiNoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.datasetEOD, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GridView8, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.tabsEtapas, System.ComponentModel.ISupportInitialize).BeginInit
        Me.tabsEtapas.SuspendLayout
        Me.tabTransporte1.SuspendLayout
        CType(Me.gcLugarBajadaEtapa1, System.ComponentModel.ISupportInitialize).BeginInit
        Me.gcLugarBajadaEtapa1.SuspendLayout
        CType(Me.spcCallesEtapa1, System.ComponentModel.ISupportInitialize).BeginInit
        Me.spcCallesEtapa1.SuspendLayout
        CType(Me.txtComunaOtraEtapa1.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.x_etapa1.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.y_etapa1.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lkpManzanaEtapa1.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lkpCalle1Etapa1.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.CallesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GridView30, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lkpCalle2Etapa1.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ConsultaCalle2Etapa1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GridView31, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lkpHitoEtapa1.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.HitoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GridView32, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lkpComunaEtapa1.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ComunaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GridView29, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.tabsEtapa1, System.ComponentModel.ISupportInitialize).BeginInit
        Me.tabsEtapa1.SuspendLayout
        Me.tabTaxi.SuspendLayout
        CType(Me.txtMinutosEsperaTaxiE1.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtCuadrasTaxiE1.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtTarifaMontoTaxiE1.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtMinutosTaxiE1.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lkpLugarBajadaTaxiE1.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.DondeSeBajoE1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GridView35, System.ComponentModel.ISupportInitialize).BeginInit
        Me.tabAuto.SuspendLayout
        CType(Me.lkpVehHogarE1.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ResumenVehiculosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GridView19, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.panelPreguntasChofer, System.ComponentModel.ISupportInitialize).BeginInit
        Me.panelPreguntasChofer.SuspendLayout
        CType(Me.spcPagoBajadaAutoE1, System.ComponentModel.ISupportInitialize).BeginInit
        Me.spcPagoBajadaAutoE1.SuspendLayout
        CType(Me.spcFormaPagoE1, System.ComponentModel.ISupportInitialize).BeginInit
        Me.spcFormaPagoE1.SuspendLayout
        CType(Me.lkpFormaPagoE1.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.FormaPagoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GridView18, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lkpDondeEstacionaE1.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.DondeEstacionaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.DatasetEODBindingSource, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GridView17, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.spcPagoEstacionamientoE1, System.ComponentModel.ISupportInitialize).BeginInit
        Me.spcPagoEstacionamientoE1.SuspendLayout
        CType(Me.chkNSNRPagoE1.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TabFormDefaultManager1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtCuantoPagoE1.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lkpLugarBajadaAutoE1.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GridView16, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtMinutosAutoE1.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtCuadrasAutoE1.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lkpViajaComoE1.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ViajaComoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GridView15, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lkpQueVehiculoE1.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.QueVehiculoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GridView7, System.ComponentModel.ISupportInitialize).BeginInit
        Me.tabBicicleta.SuspendLayout
        CType(Me.lkpLugarBajadaBiciE1.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GridView53, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.spcPropiedadBicicletaE1, System.ComponentModel.ISupportInitialize).BeginInit
        Me.spcPropiedadBicicletaE1.SuspendLayout
        CType(Me.txtPropiedadBicicletaOtraE1.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.spcMotivoNoUsaE1, System.ComponentModel.ISupportInitialize).BeginInit
        Me.spcMotivoNoUsaE1.SuspendLayout
        CType(Me.txtMotivoNoUsaE1.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lkpEstacionamientoBiciE1.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.EstacionamientoBicicletaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GridView37, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lkpCicloviaE1.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GridView26, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lkpPropiedadBicicletaE1.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PropiedadBicicletaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GridView25, System.ComponentModel.ISupportInitialize).BeginInit
        Me.tabBus.SuspendLayout
        CType(Me.txtMinutosEsperaBusE1.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.spcCuantoPagoBusE1, System.ComponentModel.ISupportInitialize).BeginInit
        Me.spcCuantoPagoBusE1.SuspendLayout
        CType(Me.txtTarifaMontoBusE1.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lkpLugarBajadaBusE1.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GridView34, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtMinutosBusE1.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtCuadrasBusE1.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lkpTipoTarifaBusE1.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TipoTarifaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GridView33, System.ComponentModel.ISupportInitialize).BeginInit
        Me.tabTXC.SuspendLayout
        CType(Me.txtMinutosEsperaTXCE1.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtCuadrasTXCE1.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtTarifaMontoTXCE1.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtMinutosTXCE1.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lkpLugarBajadaTXCE1.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GridView64, System.ComponentModel.ISupportInitialize).BeginInit
        Me.tabTransporte2.SuspendLayout
        CType(Me.gcLugarBajadaEtapa2, System.ComponentModel.ISupportInitialize).BeginInit
        Me.gcLugarBajadaEtapa2.SuspendLayout
        CType(Me.spcCallesEtapa2, System.ComponentModel.ISupportInitialize).BeginInit
        Me.spcCallesEtapa2.SuspendLayout
        CType(Me.txtComunaOtraEtapa2.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.x_etapa2.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.y_etapa2.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lkpManzanaEtapa2.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lkpCalle1Etapa2.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GridView39, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lkpCalle2Etapa2.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ConsultaCalle2Etapa2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GridView40, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lkpHitoEtapa2.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GridView41, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lkpComunaEtapa2.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GridView42, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.tabsEtapa2, System.ComponentModel.ISupportInitialize).BeginInit
        Me.tabsEtapa2.SuspendLayout
        Me.tabTaxiE2.SuspendLayout
        CType(Me.txtMinutosEsperaTaxiE2.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtCuadrasTaxiE2.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtTarifaMontoTaxiE2.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtMinutosTaxiE2.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lkpLugarBajadaTaxiE2.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.DondeSeBajoE2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GridView36, System.ComponentModel.ISupportInitialize).BeginInit
        Me.tabAutoE2.SuspendLayout
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit
        Me.PanelControl1.SuspendLayout
        CType(Me.spcPagoBajadaAutoE2, System.ComponentModel.ISupportInitialize).BeginInit
        Me.spcPagoBajadaAutoE2.SuspendLayout
        CType(Me.spcPagoEstacionamientoE2, System.ComponentModel.ISupportInitialize).BeginInit
        Me.spcPagoEstacionamientoE2.SuspendLayout
        CType(Me.chkNSNRPagoE2.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtCuantoPagoE2.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.spcFormaPagoE2, System.ComponentModel.ISupportInitialize).BeginInit
        Me.spcFormaPagoE2.SuspendLayout
        CType(Me.lkpFormaPagoE2.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GridView43, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lkpDondeEstacionaE2.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GridView59, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lkpLugarBajadaAutoE2.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GridView44, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lkpVehHogarE2.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GridView45, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtMinutosAutoE2.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtCuadrasAutoE2.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lkpViajaComoE2.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GridView47, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lkpQueVehiculoE2.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GridView48, System.ComponentModel.ISupportInitialize).BeginInit
        Me.tabBicicletaE2.SuspendLayout
        CType(Me.spcPropiedadBicicletaE2, System.ComponentModel.ISupportInitialize).BeginInit
        Me.spcPropiedadBicicletaE2.SuspendLayout
        CType(Me.txtPropiedadBicicletaOtraE2.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.spcMotivoNoUsaE2, System.ComponentModel.ISupportInitialize).BeginInit
        Me.spcMotivoNoUsaE2.SuspendLayout
        CType(Me.txtMotivoNoUsaE2.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lkpEstacionamientoBiciE2.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GridView62, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lkpCicloviaE2.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GridView24, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lkpPropiedadBicicletaE2.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GridView49, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lkpLugarBajadaBiciE2.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GridView14, System.ComponentModel.ISupportInitialize).BeginInit
        Me.tabBusE2.SuspendLayout
        CType(Me.txtMinutosEsperaBusE2.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.spcCuantoPagoBusE2, System.ComponentModel.ISupportInitialize).BeginInit
        Me.spcCuantoPagoBusE2.SuspendLayout
        CType(Me.txtTarifaMontoBusE2.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lkpLugarBajadaBusE2.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GridView50, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtMinutosBusE2.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtCuadrasBusE2.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lkpTipoTarifaBusE2.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GridView51, System.ComponentModel.ISupportInitialize).BeginInit
        Me.tabTXCE2.SuspendLayout
        CType(Me.txtTarifaMontoTXCE2.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtMinutosEsperaTXCE2.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtMinutosTXCE2.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtCuadrasTXCE2.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lkpLugarBajadaTXCE2.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GridView52, System.ComponentModel.ISupportInitialize).BeginInit
        Me.tabTransporte3.SuspendLayout
        CType(Me.gcLugarBajadaEtapa3, System.ComponentModel.ISupportInitialize).BeginInit
        Me.gcLugarBajadaEtapa3.SuspendLayout
        CType(Me.spcCallesEtapa3, System.ComponentModel.ISupportInitialize).BeginInit
        Me.spcCallesEtapa3.SuspendLayout
        CType(Me.txtComunaOtraEtapa3.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.x_etapa3.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.y_etapa3.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lkpManzanaEtapa3.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lkpCalle1Etapa3.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GridView46, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lkpCalle2Etapa3.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ConsultaCalle2Etapa3BindingSource, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GridView70, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lkpHitoEtapa3.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GridView71, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lkpComunaEtapa3.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GridView72, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.tabsEtapa3, System.ComponentModel.ISupportInitialize).BeginInit
        Me.tabsEtapa3.SuspendLayout
        Me.tabTaxiE3.SuspendLayout
        CType(Me.txtMinutosEsperaTaxiE3.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtCuadrasTaxiE3.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtTarifaMontoTaxiE3.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtMinutosTaxiE3.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lkpLugarBajadaTaxiE3.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.DondeSeBajoE3BindingSource, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GridView38, System.ComponentModel.ISupportInitialize).BeginInit
        Me.tabAutoE3.SuspendLayout
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit
        Me.PanelControl2.SuspendLayout
        CType(Me.spcPagoBajadaAutoE3, System.ComponentModel.ISupportInitialize).BeginInit
        Me.spcPagoBajadaAutoE3.SuspendLayout
        CType(Me.spcPagoEstacionamientoE3, System.ComponentModel.ISupportInitialize).BeginInit
        Me.spcPagoEstacionamientoE3.SuspendLayout
        CType(Me.chkNSNRPagoE3.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtCuantoPagoE3.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.spcFormaPagoE3, System.ComponentModel.ISupportInitialize).BeginInit
        Me.spcFormaPagoE3.SuspendLayout
        CType(Me.lkpFormaPagoE3.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GridView56, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lkpDondeEstacionaE3.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GridView55, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lkpLugarBajadaAutoE3.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GridView57, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lkpVehHogarE3.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GridView58, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtMinutosAutoE3.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtCuadrasAutoE3.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lkpViajaComoE3.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GridView60, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lkpQueVehiculoE3.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GridView63, System.ComponentModel.ISupportInitialize).BeginInit
        Me.tabBicicletaE3.SuspendLayout
        CType(Me.spcPropiedadBicicletaE3, System.ComponentModel.ISupportInitialize).BeginInit
        Me.spcPropiedadBicicletaE3.SuspendLayout
        CType(Me.txtPropiedadBicicletaOtraE3.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.spcMotivoNoUsaE3, System.ComponentModel.ISupportInitialize).BeginInit
        Me.spcMotivoNoUsaE3.SuspendLayout
        CType(Me.txtMotivoNoUsaE3.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lkpEstacionamientoBiciE3.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GridView69, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lkpCicloviaE3.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GridView23, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lkpPropiedadBicicletaE3.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GridView65, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lkpLugarBajadaBiciE3.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GridView54, System.ComponentModel.ISupportInitialize).BeginInit
        Me.tabBusE3.SuspendLayout
        CType(Me.txtMinutosEsperaBusE3.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.spcCuantoPagoBusE3, System.ComponentModel.ISupportInitialize).BeginInit
        Me.spcCuantoPagoBusE3.SuspendLayout
        CType(Me.txtTarifaMontoBusE3.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lkpLugarBajadaBusE3.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GridView66, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtMinutosBusE3.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtCuadrasBusE3.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lkpTipoTarifaBusE3.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GridView67, System.ComponentModel.ISupportInitialize).BeginInit
        Me.tabTXCE3.SuspendLayout
        CType(Me.txtTarifaMontoTXCE3.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtMinutosEsperaTXCE3.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtMinutosTXCE3.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtCuadrasTXCE3.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lkpLugarBajadaTXCE3.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GridView68, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PagaEstacionamientoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.MuelleBajadaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.MuelleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.MetrotrenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TerrasurBindingSource, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lkpProposito.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PropositoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GridView9, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.tmHoraSalida.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.spDestinoViaje, System.ComponentModel.ISupportInitialize).BeginInit
        Me.spDestinoViaje.SuspendLayout
        CType(Me.txtOtroProposito.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.spLugarDeclarado, System.ComponentModel.ISupportInitialize).BeginInit
        Me.spLugarDeclarado.SuspendLayout
        CType(Me.lkpTrabajoDeclarado.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GridView21, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lkpEstudioDeclarado.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GridView73, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.spcCallesDestino, System.ComponentModel.ISupportInitialize).BeginInit
        Me.spcCallesDestino.SuspendLayout
        CType(Me.txtComunaDestinoOtra.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lkpCalle1Destino.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lkpHitoDestino.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lkpCalle2Destino.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ConsultaCalle2DestinoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lkpManzanaDestino.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lkpComunaDestino.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GridView11, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.spcViaje, System.ComponentModel.ISupportInitialize).BeginInit
        Me.spcViaje.SuspendLayout
        CType(Me.lkpTransporte1.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ModoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GridView10, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lkpTransporte2.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Modo2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GridView12, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lkpTransporte3.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Modo3BindingSource, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GridView13, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtCuadrasDespues.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.panelFinViaje, System.ComponentModel.ISupportInitialize).BeginInit
        Me.panelFinViaje.SuspendLayout
        CType(Me.lkpOtroViaje.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GridView61, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.x_destino.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.y_destino.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.x_origen.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.y_origen.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtMinutosDespues.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.spcPrimerViaje, System.ComponentModel.ISupportInitialize).BeginInit
        Me.spcPrimerViaje.SuspendLayout
        CType(Me.spcCallesPrimerViaje, System.ComponentModel.ISupportInitialize).BeginInit
        Me.spcCallesPrimerViaje.SuspendLayout
        CType(Me.txtComunaOrigenOtra.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lkpCalle2Origen.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ConsultaCalle2OrigenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lkpCalle1Origen.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GridLookUpEdit2View, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lkpManzanaOrigen.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lkpHitoOrigen.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lkpComunaOrigen.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lkpDondePrimerViaje.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.LugarPrimerViajeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtNoViajaOtro.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lkpNoViaja.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.NoViajaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GridView22, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lkpRealizoViajes.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GridView20, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.spcRealizoViajes, System.ComponentModel.ISupportInitialize).BeginInit
        Me.spcRealizoViajes.SuspendLayout
        CType(Me.tabsInicioViaje, System.ComponentModel.ISupportInitialize).BeginInit
        Me.tabsInicioViaje.SuspendLayout
        Me.tabPrimerViaje.SuspendLayout
        Me.tabViajeAnterior.SuspendLayout
        CType(Me.gcViajeAnterior, System.ComponentModel.ISupportInitialize).BeginInit
        Me.gcViajeAnterior.SuspendLayout
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit
        Me.SplitContainerControl1.SuspendLayout
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.spCallesViajeAnterior, System.ComponentModel.ISupportInitialize).BeginInit
        Me.spCallesViajeAnterior.SuspendLayout
        CType(Me.txtComunaOtraAnterior.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtCalle1Anterior.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtCalle2Anterior.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtHitoAnterior.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtManzanaAnterior.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lkpComunaAnterior.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GridView27, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lkpPropositoAnterior.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GridView28, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.tmFinAnterior.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.tmInicioAnterior.Properties, System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'LabelControl13
        '
        Me.LabelControl13.Location = New System.Drawing.Point(173, 5)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(128, 13)
        Me.LabelControl13.TabIndex = 10
        Me.LabelControl13.Text = "¿Es un viaje de trasnoche?"
        '
        'LabelControl112
        '
        Me.LabelControl112.Location = New System.Drawing.Point(13, 5)
        Me.LabelControl112.Name = "LabelControl112"
        Me.LabelControl112.Size = New System.Drawing.Size(126, 13)
        Me.LabelControl112.TabIndex = 15
        Me.LabelControl112.Text = "¿A qué hora llegó al lugar?"
        '
        'tmHoraLlegada
        '
        Me.tmHoraLlegada.EditValue = New Date(2016, 5, 23, 0, 0, 0, 0)
        Me.tmHoraLlegada.Location = New System.Drawing.Point(13, 24)
        Me.tmHoraLlegada.Name = "tmHoraLlegada"
        Me.tmHoraLlegada.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.tmHoraLlegada.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.tmHoraLlegada.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.tmHoraLlegada.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.tmHoraLlegada.Properties.EditValueChangedDelay = 700
        Me.tmHoraLlegada.Properties.Mask.EditMask = "t"
        Me.tmHoraLlegada.Size = New System.Drawing.Size(87, 20)
        Me.tmHoraLlegada.TabIndex = 41
        '
        'lkpTrasnoche
        '
        Me.lkpTrasnoche.EditValue = ""
        Me.lkpTrasnoche.Location = New System.Drawing.Point(173, 24)
        Me.lkpTrasnoche.Name = "lkpTrasnoche"
        Me.lkpTrasnoche.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.lkpTrasnoche.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.lkpTrasnoche.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lkpTrasnoche.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkpTrasnoche.Properties.DataSource = Me.SiNoBindingSource
        Me.lkpTrasnoche.Properties.DisplayMember = "Opcion"
        Me.lkpTrasnoche.Properties.ImmediatePopup = True
        Me.lkpTrasnoche.Properties.PopupFormMinSize = New System.Drawing.Size(65, 40)
        Me.lkpTrasnoche.Properties.PopupFormSize = New System.Drawing.Size(65, 40)
        Me.lkpTrasnoche.Properties.ShowFooter = False
        Me.lkpTrasnoche.Properties.ValueMember = "Id"
        Me.lkpTrasnoche.Properties.View = Me.GridView8
        Me.lkpTrasnoche.Size = New System.Drawing.Size(65, 20)
        Me.lkpTrasnoche.TabIndex = 42
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
        'GridView8
        '
        Me.GridView8.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colId25, Me.colOpcion1})
        Me.GridView8.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView8.Name = "GridView8"
        Me.GridView8.OptionsCustomization.AllowFilter = False
        Me.GridView8.OptionsCustomization.AllowGroup = False
        Me.GridView8.OptionsCustomization.AllowSort = False
        Me.GridView8.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView8.OptionsView.ShowColumnHeaders = False
        Me.GridView8.OptionsView.ShowGroupPanel = False
        Me.GridView8.OptionsView.ShowIndicator = False
        '
        'colId25
        '
        Me.colId25.FieldName = "Id"
        Me.colId25.Name = "colId25"
        '
        'colOpcion1
        '
        Me.colOpcion1.FieldName = "Opcion"
        Me.colOpcion1.Name = "colOpcion1"
        Me.colOpcion1.Visible = True
        Me.colOpcion1.VisibleIndex = 0
        '
        'cargaDatosViajeBackground
        '
        '
        'tabsEtapas
        '
        Me.tabsEtapas.AppearancePage.HeaderActive.FontStyleDelta = System.Drawing.FontStyle.Bold
        Me.tabsEtapas.AppearancePage.HeaderActive.Options.UseFont = True
        Me.tabsEtapas.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.tabsEtapas.BorderStylePage = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.tabsEtapas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabsEtapas.Location = New System.Drawing.Point(0, 0)
        Me.tabsEtapas.Name = "tabsEtapas"
        Me.tabsEtapas.SelectedTabPage = Me.tabTransporte1
        Me.tabsEtapas.Size = New System.Drawing.Size(999, 206)
        Me.tabsEtapas.TabIndex = 87
        Me.tabsEtapas.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tabTransporte1, Me.tabTransporte2, Me.tabTransporte3})
        Me.tabsEtapas.TabStop = False
        Me.tabsEtapas.Visible = False
        '
        'tabTransporte1
        '
        Me.tabTransporte1.Controls.Add(Me.gcLugarBajadaEtapa1)
        Me.tabTransporte1.Controls.Add(Me.tabsEtapa1)
        Me.tabTransporte1.Name = "tabTransporte1"
        Me.tabTransporte1.PageVisible = False
        Me.tabTransporte1.Size = New System.Drawing.Size(995, 179)
        Me.tabTransporte1.Text = "Transporte 1"
        '
        'gcLugarBajadaEtapa1
        '
        Me.gcLugarBajadaEtapa1.Controls.Add(Me.spcCallesEtapa1)
        Me.gcLugarBajadaEtapa1.Controls.Add(Me.lblComunaEtapa1)
        Me.gcLugarBajadaEtapa1.Controls.Add(Me.lkpComunaEtapa1)
        Me.gcLugarBajadaEtapa1.Location = New System.Drawing.Point(3, 100)
        Me.gcLugarBajadaEtapa1.Name = "gcLugarBajadaEtapa1"
        Me.gcLugarBajadaEtapa1.Size = New System.Drawing.Size(980, 79)
        Me.gcLugarBajadaEtapa1.TabIndex = 94
        Me.gcLugarBajadaEtapa1.Text = "¿En dónde se bajó?"
        '
        'spcCallesEtapa1
        '
        Me.spcCallesEtapa1.Collapsed = True
        Me.spcCallesEtapa1.CollapsePanel = DevExpress.XtraEditors.SplitCollapsePanel.Panel1
        Me.spcCallesEtapa1.IsSplitterFixed = True
        Me.spcCallesEtapa1.Location = New System.Drawing.Point(115, 26)
        Me.spcCallesEtapa1.Name = "spcCallesEtapa1"
        Me.spcCallesEtapa1.Panel1.Controls.Add(Me.lblComunaOtraEtapa1)
        Me.spcCallesEtapa1.Panel1.Controls.Add(Me.txtComunaOtraEtapa1)
        Me.spcCallesEtapa1.Panel1.Text = "Panel1"
        Me.spcCallesEtapa1.Panel2.Controls.Add(Me.LabelControl136)
        Me.spcCallesEtapa1.Panel2.Controls.Add(Me.lblManzanaEtapa1)
        Me.spcCallesEtapa1.Panel2.Controls.Add(Me.LabelControl138)
        Me.spcCallesEtapa1.Panel2.Controls.Add(Me.x_etapa1)
        Me.spcCallesEtapa1.Panel2.Controls.Add(Me.lblCalle1Etapa1)
        Me.spcCallesEtapa1.Panel2.Controls.Add(Me.y_etapa1)
        Me.spcCallesEtapa1.Panel2.Controls.Add(Me.lblCalle2Etapa1)
        Me.spcCallesEtapa1.Panel2.Controls.Add(Me.lblHitoEtapa1)
        Me.spcCallesEtapa1.Panel2.Controls.Add(Me.lkpManzanaEtapa1)
        Me.spcCallesEtapa1.Panel2.Controls.Add(Me.lkpCalle1Etapa1)
        Me.spcCallesEtapa1.Panel2.Controls.Add(Me.lkpCalle2Etapa1)
        Me.spcCallesEtapa1.Panel2.Controls.Add(Me.lkpHitoEtapa1)
        Me.spcCallesEtapa1.Panel2.Text = "Panel2"
        Me.spcCallesEtapa1.Size = New System.Drawing.Size(842, 44)
        Me.spcCallesEtapa1.SplitterPosition = 93
        Me.spcCallesEtapa1.TabIndex = 94
        Me.spcCallesEtapa1.Text = "SplitContainerControl1"
        Me.spcCallesEtapa1.Visible = False
        '
        'lblComunaOtraEtapa1
        '
        Me.lblComunaOtraEtapa1.Location = New System.Drawing.Point(3, 3)
        Me.lblComunaOtraEtapa1.Name = "lblComunaOtraEtapa1"
        Me.lblComunaOtraEtapa1.Size = New System.Drawing.Size(62, 13)
        Me.lblComunaOtraEtapa1.TabIndex = 10
        Me.lblComunaOtraEtapa1.Text = "Otra comuna"
        '
        'txtComunaOtraEtapa1
        '
        Me.txtComunaOtraEtapa1.Location = New System.Drawing.Point(0, 21)
        Me.txtComunaOtraEtapa1.Name = "txtComunaOtraEtapa1"
        Me.txtComunaOtraEtapa1.Size = New System.Drawing.Size(85, 20)
        Me.txtComunaOtraEtapa1.TabIndex = 69
        '
        'LabelControl136
        '
        Me.LabelControl136.Location = New System.Drawing.Point(716, 22)
        Me.LabelControl136.Name = "LabelControl136"
        Me.LabelControl136.Size = New System.Drawing.Size(40, 13)
        Me.LabelControl136.TabIndex = 34
        Me.LabelControl136.Text = "y_etapa"
        Me.LabelControl136.Visible = False
        '
        'lblManzanaEtapa1
        '
        Me.lblManzanaEtapa1.Location = New System.Drawing.Point(627, 3)
        Me.lblManzanaEtapa1.Name = "lblManzanaEtapa1"
        Me.lblManzanaEtapa1.Size = New System.Drawing.Size(43, 13)
        Me.lblManzanaEtapa1.TabIndex = 17
        Me.lblManzanaEtapa1.Text = "Manzana"
        '
        'LabelControl138
        '
        Me.LabelControl138.Location = New System.Drawing.Point(716, 3)
        Me.LabelControl138.Name = "LabelControl138"
        Me.LabelControl138.Size = New System.Drawing.Size(40, 13)
        Me.LabelControl138.TabIndex = 33
        Me.LabelControl138.Text = "x_etapa"
        Me.LabelControl138.Visible = False
        '
        'x_etapa1
        '
        Me.x_etapa1.Location = New System.Drawing.Point(769, 1)
        Me.x_etapa1.Name = "x_etapa1"
        Me.x_etapa1.Size = New System.Drawing.Size(63, 20)
        Me.x_etapa1.TabIndex = 50
        Me.x_etapa1.Visible = False
        '
        'lblCalle1Etapa1
        '
        Me.lblCalle1Etapa1.Location = New System.Drawing.Point(5, 3)
        Me.lblCalle1Etapa1.Name = "lblCalle1Etapa1"
        Me.lblCalle1Etapa1.Size = New System.Drawing.Size(32, 13)
        Me.lblCalle1Etapa1.TabIndex = 12
        Me.lblCalle1Etapa1.Text = "Calle 1"
        '
        'y_etapa1
        '
        Me.y_etapa1.Location = New System.Drawing.Point(769, 19)
        Me.y_etapa1.Name = "y_etapa1"
        Me.y_etapa1.Size = New System.Drawing.Size(63, 20)
        Me.y_etapa1.TabIndex = 51
        Me.y_etapa1.Visible = False
        '
        'lblCalle2Etapa1
        '
        Me.lblCalle2Etapa1.Location = New System.Drawing.Point(212, 3)
        Me.lblCalle2Etapa1.Name = "lblCalle2Etapa1"
        Me.lblCalle2Etapa1.Size = New System.Drawing.Size(32, 13)
        Me.lblCalle2Etapa1.TabIndex = 13
        Me.lblCalle2Etapa1.Text = "Calle 2"
        '
        'lblHitoEtapa1
        '
        Me.lblHitoEtapa1.Location = New System.Drawing.Point(414, 3)
        Me.lblHitoEtapa1.Name = "lblHitoEtapa1"
        Me.lblHitoEtapa1.Size = New System.Drawing.Size(19, 13)
        Me.lblHitoEtapa1.TabIndex = 15
        Me.lblHitoEtapa1.Text = "Hito"
        '
        'lkpManzanaEtapa1
        '
        Me.lkpManzanaEtapa1.Location = New System.Drawing.Point(627, 21)
        Me.lkpManzanaEtapa1.Name = "lkpManzanaEtapa1"
        Me.lkpManzanaEtapa1.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.lkpManzanaEtapa1.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.lkpManzanaEtapa1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lkpManzanaEtapa1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkpManzanaEtapa1.Properties.DropDownRows = 5
        Me.lkpManzanaEtapa1.Properties.PopupFormMinSize = New System.Drawing.Size(30, 0)
        Me.lkpManzanaEtapa1.Properties.ShowFooter = False
        Me.lkpManzanaEtapa1.Properties.ShowHeader = False
        Me.lkpManzanaEtapa1.Size = New System.Drawing.Size(72, 20)
        Me.lkpManzanaEtapa1.TabIndex = 73
        '
        'lkpCalle1Etapa1
        '
        Me.lkpCalle1Etapa1.EditValue = ""
        Me.lkpCalle1Etapa1.Location = New System.Drawing.Point(5, 21)
        Me.lkpCalle1Etapa1.Name = "lkpCalle1Etapa1"
        Me.lkpCalle1Etapa1.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.lkpCalle1Etapa1.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.lkpCalle1Etapa1.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.lkpCalle1Etapa1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lkpCalle1Etapa1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkpCalle1Etapa1.Properties.DataSource = Me.CallesBindingSource
        Me.lkpCalle1Etapa1.Properties.DisplayMember = "calle"
        Me.lkpCalle1Etapa1.Properties.ImmediatePopup = True
        Me.lkpCalle1Etapa1.Properties.NullText = ""
        Me.lkpCalle1Etapa1.Properties.NullValuePrompt = "No reporta"
        Me.lkpCalle1Etapa1.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.lkpCalle1Etapa1.Properties.PopupFormMinSize = New System.Drawing.Size(181, 20)
        Me.lkpCalle1Etapa1.Properties.PopupFormSize = New System.Drawing.Size(181, 200)
        Me.lkpCalle1Etapa1.Properties.ShowFooter = False
        Me.lkpCalle1Etapa1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.lkpCalle1Etapa1.Properties.ValueMember = "calle"
        Me.lkpCalle1Etapa1.Properties.View = Me.GridView30
        Me.lkpCalle1Etapa1.Size = New System.Drawing.Size(181, 20)
        Me.lkpCalle1Etapa1.TabIndex = 70
        '
        'CallesBindingSource
        '
        Me.CallesBindingSource.DataMember = "Calles"
        Me.CallesBindingSource.DataSource = Me.datasetEOD
        Me.CallesBindingSource.Filter = "ID < 10000"
        '
        'GridView30
        '
        Me.GridView30.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colid31, Me.colcalle4})
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
        'colid31
        '
        Me.colid31.FieldName = "id"
        Me.colid31.Name = "colid31"
        '
        'colcalle4
        '
        Me.colcalle4.FieldName = "calle"
        Me.colcalle4.Name = "colcalle4"
        Me.colcalle4.Visible = True
        Me.colcalle4.VisibleIndex = 0
        '
        'lkpCalle2Etapa1
        '
        Me.lkpCalle2Etapa1.EditValue = ""
        Me.lkpCalle2Etapa1.Location = New System.Drawing.Point(212, 21)
        Me.lkpCalle2Etapa1.Name = "lkpCalle2Etapa1"
        Me.lkpCalle2Etapa1.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.lkpCalle2Etapa1.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.lkpCalle2Etapa1.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.lkpCalle2Etapa1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lkpCalle2Etapa1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkpCalle2Etapa1.Properties.DataSource = Me.ConsultaCalle2Etapa1BindingSource
        Me.lkpCalle2Etapa1.Properties.DisplayMember = "calle2"
        Me.lkpCalle2Etapa1.Properties.ImmediatePopup = True
        Me.lkpCalle2Etapa1.Properties.NullText = ""
        Me.lkpCalle2Etapa1.Properties.NullValuePrompt = "No reporta"
        Me.lkpCalle2Etapa1.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.lkpCalle2Etapa1.Properties.PopupFormMinSize = New System.Drawing.Size(173, 20)
        Me.lkpCalle2Etapa1.Properties.PopupFormSize = New System.Drawing.Size(173, 200)
        Me.lkpCalle2Etapa1.Properties.ShowFooter = False
        Me.lkpCalle2Etapa1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.lkpCalle2Etapa1.Properties.ValueMember = "calle2"
        Me.lkpCalle2Etapa1.Properties.View = Me.GridView31
        Me.lkpCalle2Etapa1.Size = New System.Drawing.Size(173, 20)
        Me.lkpCalle2Etapa1.TabIndex = 71
        '
        'ConsultaCalle2Etapa1BindingSource
        '
        Me.ConsultaCalle2Etapa1BindingSource.DataMember = "ConsultaCalle2Etapa1"
        Me.ConsultaCalle2Etapa1BindingSource.DataSource = Me.datasetEOD
        '
        'GridView31
        '
        Me.GridView31.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID32, Me.colcalle14, Me.colcalle23, Me.colconflictiva2})
        Me.GridView31.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView31.Name = "GridView31"
        Me.GridView31.OptionsCustomization.AllowFilter = False
        Me.GridView31.OptionsCustomization.AllowGroup = False
        Me.GridView31.OptionsCustomization.AllowSort = False
        Me.GridView31.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView31.OptionsView.ShowColumnHeaders = False
        Me.GridView31.OptionsView.ShowGroupPanel = False
        Me.GridView31.OptionsView.ShowIndicator = False
        '
        'colID32
        '
        Me.colID32.FieldName = "ID"
        Me.colID32.Name = "colID32"
        '
        'colcalle14
        '
        Me.colcalle14.FieldName = "calle1"
        Me.colcalle14.Name = "colcalle14"
        '
        'colcalle23
        '
        Me.colcalle23.FieldName = "calle2"
        Me.colcalle23.Name = "colcalle23"
        Me.colcalle23.Visible = True
        Me.colcalle23.VisibleIndex = 0
        '
        'colconflictiva2
        '
        Me.colconflictiva2.FieldName = "conflictiva"
        Me.colconflictiva2.Name = "colconflictiva2"
        '
        'lkpHitoEtapa1
        '
        Me.lkpHitoEtapa1.EditValue = ""
        Me.lkpHitoEtapa1.Location = New System.Drawing.Point(414, 21)
        Me.lkpHitoEtapa1.Name = "lkpHitoEtapa1"
        Me.lkpHitoEtapa1.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.lkpHitoEtapa1.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.lkpHitoEtapa1.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.lkpHitoEtapa1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lkpHitoEtapa1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkpHitoEtapa1.Properties.DataSource = Me.HitoBindingSource
        Me.lkpHitoEtapa1.Properties.DisplayMember = "hito"
        Me.lkpHitoEtapa1.Properties.ImmediatePopup = True
        Me.lkpHitoEtapa1.Properties.NullText = ""
        Me.lkpHitoEtapa1.Properties.NullValuePrompt = "No reporta"
        Me.lkpHitoEtapa1.Properties.NullValuePromptShowForEmptyValue = True
        Me.lkpHitoEtapa1.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.lkpHitoEtapa1.Properties.PopupFormMinSize = New System.Drawing.Size(188, 20)
        Me.lkpHitoEtapa1.Properties.PopupFormSize = New System.Drawing.Size(188, 200)
        Me.lkpHitoEtapa1.Properties.ShowFooter = False
        Me.lkpHitoEtapa1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.lkpHitoEtapa1.Properties.ValueMember = "hito"
        Me.lkpHitoEtapa1.Properties.View = Me.GridView32
        Me.lkpHitoEtapa1.Size = New System.Drawing.Size(188, 20)
        Me.lkpHitoEtapa1.TabIndex = 72
        '
        'HitoBindingSource
        '
        Me.HitoBindingSource.DataMember = "Hito"
        Me.HitoBindingSource.DataSource = Me.datasetEOD
        '
        'GridView32
        '
        Me.GridView32.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colid33, Me.colhito3, Me.colhitoManzana3})
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
        'colid33
        '
        Me.colid33.FieldName = "id"
        Me.colid33.Name = "colid33"
        '
        'colhito3
        '
        Me.colhito3.FieldName = "hito"
        Me.colhito3.Name = "colhito3"
        Me.colhito3.Visible = True
        Me.colhito3.VisibleIndex = 0
        '
        'colhitoManzana3
        '
        Me.colhitoManzana3.FieldName = "hitoManzana"
        Me.colhitoManzana3.Name = "colhitoManzana3"
        '
        'lblComunaEtapa1
        '
        Me.lblComunaEtapa1.Location = New System.Drawing.Point(5, 29)
        Me.lblComunaEtapa1.Name = "lblComunaEtapa1"
        Me.lblComunaEtapa1.Size = New System.Drawing.Size(39, 13)
        Me.lblComunaEtapa1.TabIndex = 12
        Me.lblComunaEtapa1.Text = "Comuna"
        '
        'lkpComunaEtapa1
        '
        Me.lkpComunaEtapa1.EditValue = ""
        Me.lkpComunaEtapa1.Location = New System.Drawing.Point(5, 47)
        Me.lkpComunaEtapa1.Name = "lkpComunaEtapa1"
        Me.lkpComunaEtapa1.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.lkpComunaEtapa1.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.lkpComunaEtapa1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lkpComunaEtapa1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkpComunaEtapa1.Properties.DataSource = Me.ComunaBindingSource
        Me.lkpComunaEtapa1.Properties.DisplayMember = "Comuna"
        Me.lkpComunaEtapa1.Properties.ImmediatePopup = True
        Me.lkpComunaEtapa1.Properties.PopupFormMinSize = New System.Drawing.Size(104, 220)
        Me.lkpComunaEtapa1.Properties.PopupFormSize = New System.Drawing.Size(104, 220)
        Me.lkpComunaEtapa1.Properties.ShowFooter = False
        Me.lkpComunaEtapa1.Properties.ValueMember = "ID"
        Me.lkpComunaEtapa1.Properties.View = Me.GridView29
        Me.lkpComunaEtapa1.Size = New System.Drawing.Size(104, 20)
        Me.lkpComunaEtapa1.TabIndex = 68
        '
        'ComunaBindingSource
        '
        Me.ComunaBindingSource.DataMember = "Comuna"
        Me.ComunaBindingSource.DataSource = Me.datasetEOD
        Me.ComunaBindingSource.Filter = "id > 0"
        '
        'GridView29
        '
        Me.GridView29.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID30, Me.colComuna3})
        Me.GridView29.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView29.Name = "GridView29"
        Me.GridView29.OptionsCustomization.AllowFilter = False
        Me.GridView29.OptionsCustomization.AllowGroup = False
        Me.GridView29.OptionsCustomization.AllowSort = False
        Me.GridView29.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView29.OptionsView.ShowColumnHeaders = False
        Me.GridView29.OptionsView.ShowGroupPanel = False
        Me.GridView29.OptionsView.ShowIndicator = False
        '
        'colID30
        '
        Me.colID30.FieldName = "ID"
        Me.colID30.Name = "colID30"
        '
        'colComuna3
        '
        Me.colComuna3.FieldName = "Comuna"
        Me.colComuna3.Name = "colComuna3"
        Me.colComuna3.Visible = True
        Me.colComuna3.VisibleIndex = 0
        '
        'tabsEtapa1
        '
        Me.tabsEtapa1.AppearancePage.HeaderActive.BorderColor = System.Drawing.Color.Lime
        Me.tabsEtapa1.AppearancePage.HeaderActive.Options.UseBorderColor = True
        Me.tabsEtapa1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.tabsEtapa1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabsEtapa1.Location = New System.Drawing.Point(0, 0)
        Me.tabsEtapa1.Name = "tabsEtapa1"
        Me.tabsEtapa1.SelectedTabPage = Me.tabTaxi
        Me.tabsEtapa1.ShowTabHeader = DevExpress.Utils.DefaultBoolean.[False]
        Me.tabsEtapa1.Size = New System.Drawing.Size(995, 179)
        Me.tabsEtapa1.TabIndex = 88
        Me.tabsEtapa1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tabAuto, Me.tabBicicleta, Me.tabBus, Me.tabTaxi, Me.tabTXC})
        Me.tabsEtapa1.TabStop = False
        Me.tabsEtapa1.Visible = False
        '
        'tabTaxi
        '
        Me.tabTaxi.Controls.Add(Me.LabelControl207)
        Me.tabTaxi.Controls.Add(Me.LabelControl82)
        Me.tabTaxi.Controls.Add(Me.LabelControl83)
        Me.tabTaxi.Controls.Add(Me.LabelControl85)
        Me.tabTaxi.Controls.Add(Me.txtMinutosEsperaTaxiE1)
        Me.tabTaxi.Controls.Add(Me.LabelControl90)
        Me.tabTaxi.Controls.Add(Me.txtCuadrasTaxiE1)
        Me.tabTaxi.Controls.Add(Me.txtTarifaMontoTaxiE1)
        Me.tabTaxi.Controls.Add(Me.txtMinutosTaxiE1)
        Me.tabTaxi.Controls.Add(Me.LabelControl89)
        Me.tabTaxi.Controls.Add(Me.LabelControl87)
        Me.tabTaxi.Controls.Add(Me.LabelControl88)
        Me.tabTaxi.Controls.Add(Me.lkpLugarBajadaTaxiE1)
        Me.tabTaxi.Name = "tabTaxi"
        Me.tabTaxi.Size = New System.Drawing.Size(993, 177)
        Me.tabTaxi.Text = "tabTaxi"
        '
        'LabelControl207
        '
        Me.LabelControl207.Location = New System.Drawing.Point(68, 76)
        Me.LabelControl207.Name = "LabelControl207"
        Me.LabelControl207.Size = New System.Drawing.Size(65, 13)
        Me.LabelControl207.TabIndex = 68
        Me.LabelControl207.Text = "(NS/NR = 99)"
        '
        'LabelControl82
        '
        Me.LabelControl82.Location = New System.Drawing.Point(3, 5)
        Me.LabelControl82.Name = "LabelControl82"
        Me.LabelControl82.Size = New System.Drawing.Size(419, 13)
        Me.LabelControl82.TabIndex = 49
        Me.LabelControl82.Text = "¿Cuánto caminó antes de tomar este taxi, radiotaxi o aplicación (uber, cabify o s" &
    "imilar)?"
        '
        'LabelControl83
        '
        Me.LabelControl83.Location = New System.Drawing.Point(49, 28)
        Me.LabelControl83.Name = "LabelControl83"
        Me.LabelControl83.Size = New System.Drawing.Size(38, 13)
        Me.LabelControl83.TabIndex = 51
        Me.LabelControl83.Text = "cuadras"
        '
        'LabelControl85
        '
        Me.LabelControl85.Location = New System.Drawing.Point(161, 28)
        Me.LabelControl85.Name = "LabelControl85"
        Me.LabelControl85.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl85.TabIndex = 52
        Me.LabelControl85.Text = "minutos"
        '
        'txtMinutosEsperaTaxiE1
        '
        Me.txtMinutosEsperaTaxiE1.Location = New System.Drawing.Point(445, 24)
        Me.txtMinutosEsperaTaxiE1.Name = "txtMinutosEsperaTaxiE1"
        Me.txtMinutosEsperaTaxiE1.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.txtMinutosEsperaTaxiE1.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.txtMinutosEsperaTaxiE1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtMinutosEsperaTaxiE1.Properties.Mask.EditMask = "n0"
        Me.txtMinutosEsperaTaxiE1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtMinutosEsperaTaxiE1.Size = New System.Drawing.Size(40, 20)
        Me.txtMinutosEsperaTaxiE1.TabIndex = 48
        '
        'LabelControl90
        '
        Me.LabelControl90.Location = New System.Drawing.Point(2, 53)
        Me.LabelControl90.Name = "LabelControl90"
        Me.LabelControl90.Size = New System.Drawing.Size(118, 13)
        Me.LabelControl90.TabIndex = 65
        Me.LabelControl90.Text = "¿Cuánto pagó en pesos?"
        '
        'txtCuadrasTaxiE1
        '
        Me.txtCuadrasTaxiE1.Location = New System.Drawing.Point(2, 24)
        Me.txtCuadrasTaxiE1.Name = "txtCuadrasTaxiE1"
        Me.txtCuadrasTaxiE1.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.txtCuadrasTaxiE1.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.txtCuadrasTaxiE1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtCuadrasTaxiE1.Properties.Mask.EditMask = "n0"
        Me.txtCuadrasTaxiE1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtCuadrasTaxiE1.Size = New System.Drawing.Size(40, 20)
        Me.txtCuadrasTaxiE1.TabIndex = 46
        '
        'txtTarifaMontoTaxiE1
        '
        Me.txtTarifaMontoTaxiE1.Location = New System.Drawing.Point(2, 72)
        Me.txtTarifaMontoTaxiE1.Name = "txtTarifaMontoTaxiE1"
        Me.txtTarifaMontoTaxiE1.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.txtTarifaMontoTaxiE1.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.txtTarifaMontoTaxiE1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtTarifaMontoTaxiE1.Properties.Mask.EditMask = "c0"
        Me.txtTarifaMontoTaxiE1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTarifaMontoTaxiE1.Size = New System.Drawing.Size(60, 20)
        Me.txtTarifaMontoTaxiE1.TabIndex = 49
        '
        'txtMinutosTaxiE1
        '
        Me.txtMinutosTaxiE1.Location = New System.Drawing.Point(115, 24)
        Me.txtMinutosTaxiE1.Name = "txtMinutosTaxiE1"
        Me.txtMinutosTaxiE1.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.txtMinutosTaxiE1.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.txtMinutosTaxiE1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtMinutosTaxiE1.Properties.Mask.EditMask = "n0"
        Me.txtMinutosTaxiE1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtMinutosTaxiE1.Size = New System.Drawing.Size(40, 20)
        Me.txtMinutosTaxiE1.TabIndex = 47
        '
        'LabelControl89
        '
        Me.LabelControl89.Location = New System.Drawing.Point(502, 27)
        Me.LabelControl89.Name = "LabelControl89"
        Me.LabelControl89.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl89.TabIndex = 56
        Me.LabelControl89.Text = "minutos"
        '
        'LabelControl87
        '
        Me.LabelControl87.Location = New System.Drawing.Point(152, 54)
        Me.LabelControl87.Name = "LabelControl87"
        Me.LabelControl87.Size = New System.Drawing.Size(79, 13)
        Me.LabelControl87.TabIndex = 67
        Me.LabelControl87.Text = "¿Dónde se bajó?"
        '
        'LabelControl88
        '
        Me.LabelControl88.Location = New System.Drawing.Point(445, 5)
        Me.LabelControl88.Name = "LabelControl88"
        Me.LabelControl88.Size = New System.Drawing.Size(419, 13)
        Me.LabelControl88.TabIndex = 55
        Me.LabelControl88.Text = "¿Cuánto rato esperó para abordar el taxi, radiotaxi o aplicación (uber, cabify o " &
    "similar)?"
        '
        'lkpLugarBajadaTaxiE1
        '
        Me.lkpLugarBajadaTaxiE1.EditValue = ""
        Me.lkpLugarBajadaTaxiE1.Location = New System.Drawing.Point(152, 73)
        Me.lkpLugarBajadaTaxiE1.Name = "lkpLugarBajadaTaxiE1"
        Me.lkpLugarBajadaTaxiE1.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.lkpLugarBajadaTaxiE1.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.lkpLugarBajadaTaxiE1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lkpLugarBajadaTaxiE1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkpLugarBajadaTaxiE1.Properties.DataSource = Me.DondeSeBajoE1BindingSource
        Me.lkpLugarBajadaTaxiE1.Properties.DisplayMember = "DondeSeBajo"
        Me.lkpLugarBajadaTaxiE1.Properties.ImmediatePopup = True
        Me.lkpLugarBajadaTaxiE1.Properties.PopupFormMinSize = New System.Drawing.Size(163, 40)
        Me.lkpLugarBajadaTaxiE1.Properties.PopupFormSize = New System.Drawing.Size(163, 40)
        Me.lkpLugarBajadaTaxiE1.Properties.ShowFooter = False
        Me.lkpLugarBajadaTaxiE1.Properties.ValueMember = "Id"
        Me.lkpLugarBajadaTaxiE1.Properties.View = Me.GridView35
        Me.lkpLugarBajadaTaxiE1.Size = New System.Drawing.Size(163, 20)
        Me.lkpLugarBajadaTaxiE1.TabIndex = 50
        '
        'DondeSeBajoE1BindingSource
        '
        Me.DondeSeBajoE1BindingSource.DataMember = "DondeSeBajo"
        Me.DondeSeBajoE1BindingSource.DataSource = Me.datasetEOD
        '
        'GridView35
        '
        Me.GridView35.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colId35, Me.colDondeSeBajo1})
        Me.GridView35.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView35.Name = "GridView35"
        Me.GridView35.OptionsCustomization.AllowFilter = False
        Me.GridView35.OptionsCustomization.AllowGroup = False
        Me.GridView35.OptionsCustomization.AllowSort = False
        Me.GridView35.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView35.OptionsView.ShowColumnHeaders = False
        Me.GridView35.OptionsView.ShowGroupPanel = False
        Me.GridView35.OptionsView.ShowIndicator = False
        '
        'colId35
        '
        Me.colId35.FieldName = "Id"
        Me.colId35.Name = "colId35"
        '
        'colDondeSeBajo1
        '
        Me.colDondeSeBajo1.FieldName = "DondeSeBajo"
        Me.colDondeSeBajo1.Name = "colDondeSeBajo1"
        Me.colDondeSeBajo1.OptionsColumn.AllowEdit = False
        Me.colDondeSeBajo1.Visible = True
        Me.colDondeSeBajo1.VisibleIndex = 0
        '
        'tabAuto
        '
        Me.tabAuto.Controls.Add(Me.LabelControl19)
        Me.tabAuto.Controls.Add(Me.lkpVehHogarE1)
        Me.tabAuto.Controls.Add(Me.panelPreguntasChofer)
        Me.tabAuto.Controls.Add(Me.LabelControl35)
        Me.tabAuto.Controls.Add(Me.LabelControl36)
        Me.tabAuto.Controls.Add(Me.txtMinutosAutoE1)
        Me.tabAuto.Controls.Add(Me.txtCuadrasAutoE1)
        Me.tabAuto.Controls.Add(Me.LabelControl37)
        Me.tabAuto.Controls.Add(Me.LabelControl38)
        Me.tabAuto.Controls.Add(Me.LabelControl39)
        Me.tabAuto.Controls.Add(Me.lkpViajaComoE1)
        Me.tabAuto.Controls.Add(Me.lkpQueVehiculoE1)
        Me.tabAuto.Name = "tabAuto"
        Me.tabAuto.Size = New System.Drawing.Size(993, 177)
        Me.tabAuto.Text = "tabAuto"
        '
        'LabelControl19
        '
        Me.LabelControl19.Location = New System.Drawing.Point(569, 3)
        Me.LabelControl19.Name = "LabelControl19"
        Me.LabelControl19.Size = New System.Drawing.Size(87, 13)
        Me.LabelControl19.TabIndex = 10
        Me.LabelControl19.Text = "Vehiculo del hogar"
        '
        'lkpVehHogarE1
        '
        Me.lkpVehHogarE1.EditValue = ""
        Me.lkpVehHogarE1.Location = New System.Drawing.Point(569, 22)
        Me.lkpVehHogarE1.Name = "lkpVehHogarE1"
        Me.lkpVehHogarE1.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.lkpVehHogarE1.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.lkpVehHogarE1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lkpVehHogarE1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkpVehHogarE1.Properties.DataSource = Me.ResumenVehiculosBindingSource
        Me.lkpVehHogarE1.Properties.DisplayMember = "vehiculo"
        Me.lkpVehHogarE1.Properties.ImmediatePopup = True
        Me.lkpVehHogarE1.Properties.PopupFormMinSize = New System.Drawing.Size(330, 20)
        Me.lkpVehHogarE1.Properties.PopupFormSize = New System.Drawing.Size(330, 100)
        Me.lkpVehHogarE1.Properties.ShowFooter = False
        Me.lkpVehHogarE1.Properties.ValueMember = "Vehículo"
        Me.lkpVehHogarE1.Properties.View = Me.GridView19
        Me.lkpVehHogarE1.Size = New System.Drawing.Size(330, 20)
        Me.lkpVehHogarE1.TabIndex = 29
        '
        'ResumenVehiculosBindingSource
        '
        Me.ResumenVehiculosBindingSource.DataMember = "ResumenVehiculos"
        Me.ResumenVehiculosBindingSource.DataSource = Me.datasetEOD
        '
        'GridView19
        '
        Me.GridView19.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colvehiculo, Me.colCombustible})
        Me.GridView19.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView19.Name = "GridView19"
        Me.GridView19.OptionsCustomization.AllowFilter = False
        Me.GridView19.OptionsCustomization.AllowGroup = False
        Me.GridView19.OptionsCustomization.AllowSort = False
        Me.GridView19.OptionsMenu.EnableColumnMenu = False
        Me.GridView19.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView19.OptionsView.ShowGroupPanel = False
        '
        'colvehiculo
        '
        Me.colvehiculo.Caption = "Tipo"
        Me.colvehiculo.FieldName = "vehiculo"
        Me.colvehiculo.Name = "colvehiculo"
        Me.colvehiculo.OptionsColumn.AllowEdit = False
        Me.colvehiculo.Visible = True
        Me.colvehiculo.VisibleIndex = 0
        '
        'colCombustible
        '
        Me.colCombustible.FieldName = "Combustible"
        Me.colCombustible.Name = "colCombustible"
        Me.colCombustible.Visible = True
        Me.colCombustible.VisibleIndex = 1
        '
        'panelPreguntasChofer
        '
        Me.panelPreguntasChofer.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.panelPreguntasChofer.Controls.Add(Me.spcPagoBajadaAutoE1)
        Me.panelPreguntasChofer.Location = New System.Drawing.Point(2, 54)
        Me.panelPreguntasChofer.Name = "panelPreguntasChofer"
        Me.panelPreguntasChofer.Size = New System.Drawing.Size(976, 54)
        Me.panelPreguntasChofer.TabIndex = 91
        '
        'spcPagoBajadaAutoE1
        '
        Me.spcPagoBajadaAutoE1.CollapsePanel = DevExpress.XtraEditors.SplitCollapsePanel.Panel1
        Me.spcPagoBajadaAutoE1.Location = New System.Drawing.Point(0, 0)
        Me.spcPagoBajadaAutoE1.Name = "spcPagoBajadaAutoE1"
        Me.spcPagoBajadaAutoE1.Panel1.Controls.Add(Me.spcFormaPagoE1)
        Me.spcPagoBajadaAutoE1.Panel1.Controls.Add(Me.spcPagoEstacionamientoE1)
        Me.spcPagoBajadaAutoE1.Panel1.Text = "Panel1"
        Me.spcPagoBajadaAutoE1.Panel2.Controls.Add(Me.lblLugarDondeBajoE1)
        Me.spcPagoBajadaAutoE1.Panel2.Controls.Add(Me.lkpLugarBajadaAutoE1)
        Me.spcPagoBajadaAutoE1.Panel2.Text = "Panel2"
        Me.spcPagoBajadaAutoE1.Size = New System.Drawing.Size(976, 54)
        Me.spcPagoBajadaAutoE1.SplitterPosition = 632
        Me.spcPagoBajadaAutoE1.TabIndex = 93
        Me.spcPagoBajadaAutoE1.Text = "SplitContainerControl1"
        '
        'spcFormaPagoE1
        '
        Me.spcFormaPagoE1.Collapsed = True
        Me.spcFormaPagoE1.CollapsePanel = DevExpress.XtraEditors.SplitCollapsePanel.Panel1
        Me.spcFormaPagoE1.Location = New System.Drawing.Point(236, 3)
        Me.spcFormaPagoE1.Name = "spcFormaPagoE1"
        Me.spcFormaPagoE1.Panel1.Controls.Add(Me.lkpFormaPagoE1)
        Me.spcFormaPagoE1.Panel1.Controls.Add(Me.LabelControl26)
        Me.spcFormaPagoE1.Panel1.Text = "Panel1"
        Me.spcFormaPagoE1.Panel2.Controls.Add(Me.lkpDondeEstacionaE1)
        Me.spcFormaPagoE1.Panel2.Controls.Add(Me.LabelControl27)
        Me.spcFormaPagoE1.Panel2.Text = "Panel2"
        Me.spcFormaPagoE1.Size = New System.Drawing.Size(392, 48)
        Me.spcFormaPagoE1.SplitterPosition = 176
        Me.spcFormaPagoE1.TabIndex = 95
        Me.spcFormaPagoE1.Text = "SplitContainerControl2"
        '
        'lkpFormaPagoE1
        '
        Me.lkpFormaPagoE1.EditValue = ""
        Me.lkpFormaPagoE1.Location = New System.Drawing.Point(6, 22)
        Me.lkpFormaPagoE1.Name = "lkpFormaPagoE1"
        Me.lkpFormaPagoE1.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.lkpFormaPagoE1.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.lkpFormaPagoE1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lkpFormaPagoE1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkpFormaPagoE1.Properties.DataSource = Me.FormaPagoBindingSource
        Me.lkpFormaPagoE1.Properties.DisplayMember = "FormaPago"
        Me.lkpFormaPagoE1.Properties.ImmediatePopup = True
        Me.lkpFormaPagoE1.Properties.PopupFormMinSize = New System.Drawing.Size(165, 160)
        Me.lkpFormaPagoE1.Properties.PopupFormSize = New System.Drawing.Size(165, 160)
        Me.lkpFormaPagoE1.Properties.ShowFooter = False
        Me.lkpFormaPagoE1.Properties.ValueMember = "ID"
        Me.lkpFormaPagoE1.Properties.View = Me.GridView18
        Me.lkpFormaPagoE1.Size = New System.Drawing.Size(165, 20)
        Me.lkpFormaPagoE1.TabIndex = 32
        '
        'FormaPagoBindingSource
        '
        Me.FormaPagoBindingSource.DataMember = "FormaPago"
        Me.FormaPagoBindingSource.DataSource = Me.datasetEOD
        Me.FormaPagoBindingSource.Filter = "id > 0"
        Me.FormaPagoBindingSource.Sort = "FormaPago"
        '
        'GridView18
        '
        Me.GridView18.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID20, Me.colFormaPago})
        Me.GridView18.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView18.Name = "GridView18"
        Me.GridView18.OptionsCustomization.AllowFilter = False
        Me.GridView18.OptionsCustomization.AllowGroup = False
        Me.GridView18.OptionsCustomization.AllowSort = False
        Me.GridView18.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView18.OptionsView.ShowColumnHeaders = False
        Me.GridView18.OptionsView.ShowGroupPanel = False
        Me.GridView18.OptionsView.ShowIndicator = False
        Me.GridView18.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colID20, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colID20
        '
        Me.colID20.FieldName = "ID"
        Me.colID20.Name = "colID20"
        '
        'colFormaPago
        '
        Me.colFormaPago.FieldName = "FormaPago"
        Me.colFormaPago.Name = "colFormaPago"
        Me.colFormaPago.Visible = True
        Me.colFormaPago.VisibleIndex = 0
        '
        'LabelControl26
        '
        Me.LabelControl26.Location = New System.Drawing.Point(6, 3)
        Me.LabelControl26.Name = "LabelControl26"
        Me.LabelControl26.Size = New System.Drawing.Size(72, 13)
        Me.LabelControl26.TabIndex = 4
        Me.LabelControl26.Text = "¿Este pago es?"
        '
        'lkpDondeEstacionaE1
        '
        Me.lkpDondeEstacionaE1.EditValue = ""
        Me.lkpDondeEstacionaE1.Location = New System.Drawing.Point(3, 21)
        Me.lkpDondeEstacionaE1.Name = "lkpDondeEstacionaE1"
        Me.lkpDondeEstacionaE1.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.lkpDondeEstacionaE1.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.lkpDondeEstacionaE1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lkpDondeEstacionaE1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkpDondeEstacionaE1.Properties.DataSource = Me.DondeEstacionaBindingSource
        Me.lkpDondeEstacionaE1.Properties.DisplayMember = "DondeEstaciona"
        Me.lkpDondeEstacionaE1.Properties.ImmediatePopup = True
        Me.lkpDondeEstacionaE1.Properties.PopupFormMinSize = New System.Drawing.Size(186, 80)
        Me.lkpDondeEstacionaE1.Properties.PopupFormSize = New System.Drawing.Size(186, 80)
        Me.lkpDondeEstacionaE1.Properties.ShowFooter = False
        Me.lkpDondeEstacionaE1.Properties.ValueMember = "ID"
        Me.lkpDondeEstacionaE1.Properties.View = Me.GridView17
        Me.lkpDondeEstacionaE1.Size = New System.Drawing.Size(186, 20)
        Me.lkpDondeEstacionaE1.TabIndex = 33
        '
        'DondeEstacionaBindingSource
        '
        Me.DondeEstacionaBindingSource.DataMember = "DondeEstaciona"
        Me.DondeEstacionaBindingSource.DataSource = Me.DatasetEODBindingSource
        Me.DondeEstacionaBindingSource.Filter = "id > 0"
        Me.DondeEstacionaBindingSource.Sort = "ID"
        '
        'DatasetEODBindingSource
        '
        Me.DatasetEODBindingSource.DataSource = Me.datasetEOD
        Me.DatasetEODBindingSource.Position = 0
        '
        'GridView17
        '
        Me.GridView17.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn18, Me.GridColumn53})
        Me.GridView17.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView17.Name = "GridView17"
        Me.GridView17.OptionsCustomization.AllowFilter = False
        Me.GridView17.OptionsCustomization.AllowGroup = False
        Me.GridView17.OptionsCustomization.AllowSort = False
        Me.GridView17.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView17.OptionsView.ShowColumnHeaders = False
        Me.GridView17.OptionsView.ShowGroupPanel = False
        Me.GridView17.OptionsView.ShowIndicator = False
        Me.GridView17.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.GridColumn53, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.GridColumn18, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'GridColumn18
        '
        Me.GridColumn18.FieldName = "ID"
        Me.GridColumn18.Name = "GridColumn18"
        '
        'GridColumn53
        '
        Me.GridColumn53.FieldName = "DondeEstaciona"
        Me.GridColumn53.Name = "GridColumn53"
        Me.GridColumn53.Visible = True
        Me.GridColumn53.VisibleIndex = 0
        '
        'LabelControl27
        '
        Me.LabelControl27.Location = New System.Drawing.Point(3, 3)
        Me.LabelControl27.Name = "LabelControl27"
        Me.LabelControl27.Size = New System.Drawing.Size(90, 13)
        Me.LabelControl27.TabIndex = 5
        Me.LabelControl27.Text = "¿Dónde estacionó?"
        '
        'spcPagoEstacionamientoE1
        '
        Me.spcPagoEstacionamientoE1.CollapsePanel = DevExpress.XtraEditors.SplitCollapsePanel.Panel2
        Me.spcPagoEstacionamientoE1.Location = New System.Drawing.Point(1, 0)
        Me.spcPagoEstacionamientoE1.Name = "spcPagoEstacionamientoE1"
        Me.spcPagoEstacionamientoE1.Panel1.Controls.Add(Me.chkNSNRPagoE1)
        Me.spcPagoEstacionamientoE1.Panel1.Controls.Add(Me.lblCuantoPagoE1)
        Me.spcPagoEstacionamientoE1.Panel1.Controls.Add(Me.txtCuantoPagoE1)
        Me.spcPagoEstacionamientoE1.Panel1.Text = "Panel1"
        Me.spcPagoEstacionamientoE1.Panel2.Text = "Panel2"
        Me.spcPagoEstacionamientoE1.Size = New System.Drawing.Size(653, 54)
        Me.spcPagoEstacionamientoE1.SplitterPosition = 216
        Me.spcPagoEstacionamientoE1.TabIndex = 94
        Me.spcPagoEstacionamientoE1.Text = "SplitContainerControl2"
        '
        'chkNSNRPagoE1
        '
        Me.chkNSNRPagoE1.Location = New System.Drawing.Point(93, 25)
        Me.chkNSNRPagoE1.MenuManager = Me.TabFormDefaultManager1
        Me.chkNSNRPagoE1.Name = "chkNSNRPagoE1"
        Me.chkNSNRPagoE1.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.chkNSNRPagoE1.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.chkNSNRPagoE1.Properties.Caption = "No sabe/no responde"
        Me.chkNSNRPagoE1.Size = New System.Drawing.Size(126, 19)
        Me.chkNSNRPagoE1.TabIndex = 31
        '
        'TabFormDefaultManager1
        '
        Me.TabFormDefaultManager1.DockControls.Add(Me.barDockControlTop)
        Me.TabFormDefaultManager1.DockControls.Add(Me.barDockControlBottom)
        Me.TabFormDefaultManager1.DockControls.Add(Me.barDockControlLeft)
        Me.TabFormDefaultManager1.DockControls.Add(Me.barDockControlRight)
        Me.TabFormDefaultManager1.DockingEnabled = False
        Me.TabFormDefaultManager1.Form = Me
        Me.TabFormDefaultManager1.MaxItemId = 0
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Nothing
        Me.barDockControlTop.Size = New System.Drawing.Size(1015, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 559)
        Me.barDockControlBottom.Manager = Nothing
        Me.barDockControlBottom.Size = New System.Drawing.Size(1015, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Manager = Nothing
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 559)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1015, 0)
        Me.barDockControlRight.Manager = Nothing
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 559)
        '
        'lblCuantoPagoE1
        '
        Me.lblCuantoPagoE1.Location = New System.Drawing.Point(2, 6)
        Me.lblCuantoPagoE1.Name = "lblCuantoPagoE1"
        Me.lblCuantoPagoE1.Size = New System.Drawing.Size(144, 13)
        Me.lblCuantoPagoE1.TabIndex = 6
        Me.lblCuantoPagoE1.Text = "¿Cuánto pagó por estacionar?"
        '
        'txtCuantoPagoE1
        '
        Me.txtCuantoPagoE1.Location = New System.Drawing.Point(2, 25)
        Me.txtCuantoPagoE1.Name = "txtCuantoPagoE1"
        Me.txtCuantoPagoE1.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.txtCuantoPagoE1.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.txtCuantoPagoE1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtCuantoPagoE1.Properties.Mask.EditMask = "c0"
        Me.txtCuantoPagoE1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtCuantoPagoE1.Size = New System.Drawing.Size(76, 20)
        Me.txtCuantoPagoE1.TabIndex = 30
        '
        'lblLugarDondeBajoE1
        '
        Me.lblLugarDondeBajoE1.Location = New System.Drawing.Point(12, 6)
        Me.lblLugarDondeBajoE1.Name = "lblLugarDondeBajoE1"
        Me.lblLugarDondeBajoE1.Size = New System.Drawing.Size(167, 13)
        Me.lblLugarDondeBajoE1.TabIndex = 12
        Me.lblLugarDondeBajoE1.Text = "¿En qué lugar se bajó del vehículo?"
        '
        'lkpLugarBajadaAutoE1
        '
        Me.lkpLugarBajadaAutoE1.EditValue = ""
        Me.lkpLugarBajadaAutoE1.Location = New System.Drawing.Point(12, 25)
        Me.lkpLugarBajadaAutoE1.Name = "lkpLugarBajadaAutoE1"
        Me.lkpLugarBajadaAutoE1.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.lkpLugarBajadaAutoE1.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.lkpLugarBajadaAutoE1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lkpLugarBajadaAutoE1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkpLugarBajadaAutoE1.Properties.DataSource = Me.DondeSeBajoE1BindingSource
        Me.lkpLugarBajadaAutoE1.Properties.DisplayMember = "DondeSeBajo"
        Me.lkpLugarBajadaAutoE1.Properties.ImmediatePopup = True
        Me.lkpLugarBajadaAutoE1.Properties.PopupFormMinSize = New System.Drawing.Size(167, 40)
        Me.lkpLugarBajadaAutoE1.Properties.PopupFormSize = New System.Drawing.Size(167, 40)
        Me.lkpLugarBajadaAutoE1.Properties.ShowFooter = False
        Me.lkpLugarBajadaAutoE1.Properties.ValueMember = "Id"
        Me.lkpLugarBajadaAutoE1.Properties.View = Me.GridView16
        Me.lkpLugarBajadaAutoE1.Size = New System.Drawing.Size(167, 20)
        Me.lkpLugarBajadaAutoE1.TabIndex = 34
        '
        'GridView16
        '
        Me.GridView16.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID18, Me.colLugarDondeBajo})
        Me.GridView16.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView16.Name = "GridView16"
        Me.GridView16.OptionsCustomization.AllowFilter = False
        Me.GridView16.OptionsCustomization.AllowGroup = False
        Me.GridView16.OptionsCustomization.AllowSort = False
        Me.GridView16.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView16.OptionsView.ShowColumnHeaders = False
        Me.GridView16.OptionsView.ShowGroupPanel = False
        Me.GridView16.OptionsView.ShowIndicator = False
        '
        'colID18
        '
        Me.colID18.FieldName = "Id"
        Me.colID18.Name = "colID18"
        '
        'colLugarDondeBajo
        '
        Me.colLugarDondeBajo.FieldName = "DondeSeBajo"
        Me.colLugarDondeBajo.Name = "colLugarDondeBajo"
        Me.colLugarDondeBajo.Visible = True
        Me.colLugarDondeBajo.VisibleIndex = 0
        '
        'LabelControl35
        '
        Me.LabelControl35.Location = New System.Drawing.Point(445, 3)
        Me.LabelControl35.Name = "LabelControl35"
        Me.LabelControl35.Size = New System.Drawing.Size(102, 13)
        Me.LabelControl35.TabIndex = 22
        Me.LabelControl35.Text = "¿Qué vehículo utilizó?"
        '
        'LabelControl36
        '
        Me.LabelControl36.Location = New System.Drawing.Point(238, 3)
        Me.LabelControl36.Name = "LabelControl36"
        Me.LabelControl36.Size = New System.Drawing.Size(194, 13)
        Me.LabelControl36.TabIndex = 20
        Me.LabelControl36.Text = "¿Viajó como conductor o como pasajero?"
        '
        'txtMinutosAutoE1
        '
        Me.txtMinutosAutoE1.Location = New System.Drawing.Point(115, 22)
        Me.txtMinutosAutoE1.Name = "txtMinutosAutoE1"
        Me.txtMinutosAutoE1.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.txtMinutosAutoE1.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.txtMinutosAutoE1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtMinutosAutoE1.Properties.Mask.EditMask = "n0"
        Me.txtMinutosAutoE1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtMinutosAutoE1.Size = New System.Drawing.Size(40, 20)
        Me.txtMinutosAutoE1.TabIndex = 26
        '
        'txtCuadrasAutoE1
        '
        Me.txtCuadrasAutoE1.Location = New System.Drawing.Point(3, 22)
        Me.txtCuadrasAutoE1.Name = "txtCuadrasAutoE1"
        Me.txtCuadrasAutoE1.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.txtCuadrasAutoE1.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.txtCuadrasAutoE1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtCuadrasAutoE1.Properties.Mask.EditMask = "n0"
        Me.txtCuadrasAutoE1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtCuadrasAutoE1.Size = New System.Drawing.Size(40, 20)
        Me.txtCuadrasAutoE1.TabIndex = 25
        '
        'LabelControl37
        '
        Me.LabelControl37.Location = New System.Drawing.Point(161, 22)
        Me.LabelControl37.Name = "LabelControl37"
        Me.LabelControl37.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl37.TabIndex = 17
        Me.LabelControl37.Text = "minutos"
        '
        'LabelControl38
        '
        Me.LabelControl38.Location = New System.Drawing.Point(49, 22)
        Me.LabelControl38.Name = "LabelControl38"
        Me.LabelControl38.Size = New System.Drawing.Size(38, 13)
        Me.LabelControl38.TabIndex = 16
        Me.LabelControl38.Text = "cuadras"
        '
        'LabelControl39
        '
        Me.LabelControl39.Location = New System.Drawing.Point(3, 3)
        Me.LabelControl39.Name = "LabelControl39"
        Me.LabelControl39.Size = New System.Drawing.Size(223, 13)
        Me.LabelControl39.TabIndex = 15
        Me.LabelControl39.Text = "¿Cuánto caminó antes de tomar este vehículo?"
        '
        'lkpViajaComoE1
        '
        Me.lkpViajaComoE1.EditValue = ""
        Me.lkpViajaComoE1.Location = New System.Drawing.Point(238, 22)
        Me.lkpViajaComoE1.Name = "lkpViajaComoE1"
        Me.lkpViajaComoE1.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.lkpViajaComoE1.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.lkpViajaComoE1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lkpViajaComoE1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkpViajaComoE1.Properties.DataSource = Me.ViajaComoBindingSource
        Me.lkpViajaComoE1.Properties.DisplayMember = "ViajaComo"
        Me.lkpViajaComoE1.Properties.ImmediatePopup = True
        Me.lkpViajaComoE1.Properties.PopupFormMinSize = New System.Drawing.Size(100, 40)
        Me.lkpViajaComoE1.Properties.PopupFormSize = New System.Drawing.Size(100, 40)
        Me.lkpViajaComoE1.Properties.ShowFooter = False
        Me.lkpViajaComoE1.Properties.ValueMember = "Id"
        Me.lkpViajaComoE1.Properties.View = Me.GridView15
        Me.lkpViajaComoE1.Size = New System.Drawing.Size(100, 20)
        Me.lkpViajaComoE1.TabIndex = 27
        '
        'ViajaComoBindingSource
        '
        Me.ViajaComoBindingSource.DataMember = "ViajaComo"
        Me.ViajaComoBindingSource.DataSource = Me.datasetEOD
        Me.ViajaComoBindingSource.Filter = "id > 0"
        '
        'GridView15
        '
        Me.GridView15.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colId15, Me.colViajaComo})
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
        'colId15
        '
        Me.colId15.FieldName = "Id"
        Me.colId15.Name = "colId15"
        '
        'colViajaComo
        '
        Me.colViajaComo.FieldName = "ViajaComo"
        Me.colViajaComo.Name = "colViajaComo"
        Me.colViajaComo.Visible = True
        Me.colViajaComo.VisibleIndex = 0
        '
        'lkpQueVehiculoE1
        '
        Me.lkpQueVehiculoE1.EditValue = ""
        Me.lkpQueVehiculoE1.Location = New System.Drawing.Point(445, 22)
        Me.lkpQueVehiculoE1.Name = "lkpQueVehiculoE1"
        Me.lkpQueVehiculoE1.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.lkpQueVehiculoE1.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.lkpQueVehiculoE1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lkpQueVehiculoE1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkpQueVehiculoE1.Properties.DataSource = Me.QueVehiculoBindingSource
        Me.lkpQueVehiculoE1.Properties.DisplayMember = "QueVehiculo"
        Me.lkpQueVehiculoE1.Properties.ImmediatePopup = True
        Me.lkpQueVehiculoE1.Properties.PopupFormMinSize = New System.Drawing.Size(100, 40)
        Me.lkpQueVehiculoE1.Properties.PopupFormSize = New System.Drawing.Size(100, 40)
        Me.lkpQueVehiculoE1.Properties.ShowFooter = False
        Me.lkpQueVehiculoE1.Properties.ValueMember = "Id"
        Me.lkpQueVehiculoE1.Properties.View = Me.GridView7
        Me.lkpQueVehiculoE1.Size = New System.Drawing.Size(102, 20)
        Me.lkpQueVehiculoE1.TabIndex = 28
        '
        'QueVehiculoBindingSource
        '
        Me.QueVehiculoBindingSource.DataMember = "QueVehiculo"
        Me.QueVehiculoBindingSource.DataSource = Me.datasetEOD
        Me.QueVehiculoBindingSource.Filter = "id > 0"
        '
        'GridView7
        '
        Me.GridView7.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colId21, Me.colQueVehiculo})
        Me.GridView7.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView7.Name = "GridView7"
        Me.GridView7.OptionsCustomization.AllowFilter = False
        Me.GridView7.OptionsCustomization.AllowGroup = False
        Me.GridView7.OptionsCustomization.AllowSort = False
        Me.GridView7.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView7.OptionsView.ShowColumnHeaders = False
        Me.GridView7.OptionsView.ShowGroupPanel = False
        Me.GridView7.OptionsView.ShowIndicator = False
        '
        'colId21
        '
        Me.colId21.FieldName = "Id"
        Me.colId21.Name = "colId21"
        '
        'colQueVehiculo
        '
        Me.colQueVehiculo.FieldName = "QueVehiculo"
        Me.colQueVehiculo.Name = "colQueVehiculo"
        Me.colQueVehiculo.Visible = True
        Me.colQueVehiculo.VisibleIndex = 0
        '
        'tabBicicleta
        '
        Me.tabBicicleta.Controls.Add(Me.lkpLugarBajadaBiciE1)
        Me.tabBicicleta.Controls.Add(Me.LabelControl137)
        Me.tabBicicleta.Controls.Add(Me.spcPropiedadBicicletaE1)
        Me.tabBicicleta.Controls.Add(Me.LabelControl48)
        Me.tabBicicleta.Controls.Add(Me.lkpPropiedadBicicletaE1)
        Me.tabBicicleta.Name = "tabBicicleta"
        Me.tabBicicleta.Size = New System.Drawing.Size(993, 177)
        Me.tabBicicleta.Text = "tabBicicleta"
        '
        'lkpLugarBajadaBiciE1
        '
        Me.lkpLugarBajadaBiciE1.EditValue = ""
        Me.lkpLugarBajadaBiciE1.Location = New System.Drawing.Point(3, 73)
        Me.lkpLugarBajadaBiciE1.Name = "lkpLugarBajadaBiciE1"
        Me.lkpLugarBajadaBiciE1.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.lkpLugarBajadaBiciE1.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.lkpLugarBajadaBiciE1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lkpLugarBajadaBiciE1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkpLugarBajadaBiciE1.Properties.DataSource = Me.DondeSeBajoE1BindingSource
        Me.lkpLugarBajadaBiciE1.Properties.DisplayMember = "DondeSeBajo"
        Me.lkpLugarBajadaBiciE1.Properties.ImmediatePopup = True
        Me.lkpLugarBajadaBiciE1.Properties.PopupFormMinSize = New System.Drawing.Size(167, 40)
        Me.lkpLugarBajadaBiciE1.Properties.PopupFormSize = New System.Drawing.Size(167, 40)
        Me.lkpLugarBajadaBiciE1.Properties.ShowFooter = False
        Me.lkpLugarBajadaBiciE1.Properties.ValueMember = "Id"
        Me.lkpLugarBajadaBiciE1.Properties.View = Me.GridView53
        Me.lkpLugarBajadaBiciE1.Size = New System.Drawing.Size(167, 20)
        Me.lkpLugarBajadaBiciE1.TabIndex = 45
        '
        'GridView53
        '
        Me.GridView53.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn33, Me.GridColumn34})
        Me.GridView53.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView53.Name = "GridView53"
        Me.GridView53.OptionsCustomization.AllowFilter = False
        Me.GridView53.OptionsCustomization.AllowGroup = False
        Me.GridView53.OptionsCustomization.AllowSort = False
        Me.GridView53.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView53.OptionsView.ShowColumnHeaders = False
        Me.GridView53.OptionsView.ShowGroupPanel = False
        Me.GridView53.OptionsView.ShowIndicator = False
        '
        'GridColumn33
        '
        Me.GridColumn33.FieldName = "Id"
        Me.GridColumn33.Name = "GridColumn33"
        '
        'GridColumn34
        '
        Me.GridColumn34.FieldName = "DondeSeBajo"
        Me.GridColumn34.Name = "GridColumn34"
        Me.GridColumn34.Visible = True
        Me.GridColumn34.VisibleIndex = 0
        '
        'LabelControl137
        '
        Me.LabelControl137.Location = New System.Drawing.Point(3, 54)
        Me.LabelControl137.Name = "LabelControl137"
        Me.LabelControl137.Size = New System.Drawing.Size(79, 13)
        Me.LabelControl137.TabIndex = 38
        Me.LabelControl137.Text = "¿Dónde se bajó?"
        '
        'spcPropiedadBicicletaE1
        '
        Me.spcPropiedadBicicletaE1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
        Me.spcPropiedadBicicletaE1.Collapsed = True
        Me.spcPropiedadBicicletaE1.CollapsePanel = DevExpress.XtraEditors.SplitCollapsePanel.Panel1
        Me.spcPropiedadBicicletaE1.Location = New System.Drawing.Point(203, 3)
        Me.spcPropiedadBicicletaE1.Name = "spcPropiedadBicicletaE1"
        Me.spcPropiedadBicicletaE1.Panel1.Controls.Add(Me.txtPropiedadBicicletaOtraE1)
        Me.spcPropiedadBicicletaE1.Panel1.Controls.Add(Me.lblPropiedadBiciOtraE1)
        Me.spcPropiedadBicicletaE1.Panel1.Text = "Panel1"
        Me.spcPropiedadBicicletaE1.Panel2.Controls.Add(Me.spcMotivoNoUsaE1)
        Me.spcPropiedadBicicletaE1.Panel2.Controls.Add(Me.LabelControl57)
        Me.spcPropiedadBicicletaE1.Panel2.Controls.Add(Me.lkpCicloviaE1)
        Me.spcPropiedadBicicletaE1.Panel2.Text = "Panel2"
        Me.spcPropiedadBicicletaE1.Size = New System.Drawing.Size(779, 54)
        Me.spcPropiedadBicicletaE1.SplitterPosition = 121
        Me.spcPropiedadBicicletaE1.TabIndex = 37
        Me.spcPropiedadBicicletaE1.Text = "SplitContainerControl4"
        '
        'txtPropiedadBicicletaOtraE1
        '
        Me.txtPropiedadBicicletaOtraE1.Location = New System.Drawing.Point(3, 19)
        Me.txtPropiedadBicicletaOtraE1.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.txtPropiedadBicicletaOtraE1.Name = "txtPropiedadBicicletaOtraE1"
        Me.txtPropiedadBicicletaOtraE1.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.txtPropiedadBicicletaOtraE1.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.txtPropiedadBicicletaOtraE1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtPropiedadBicicletaOtraE1.Size = New System.Drawing.Size(106, 20)
        Me.txtPropiedadBicicletaOtraE1.TabIndex = 38
        Me.txtPropiedadBicicletaOtraE1.Visible = False
        '
        'lblPropiedadBiciOtraE1
        '
        Me.lblPropiedadBiciOtraE1.Location = New System.Drawing.Point(0, 0)
        Me.lblPropiedadBiciOtraE1.Name = "lblPropiedadBiciOtraE1"
        Me.lblPropiedadBiciOtraE1.Size = New System.Drawing.Size(64, 13)
        Me.lblPropiedadBiciOtraE1.TabIndex = 40
        Me.lblPropiedadBiciOtraE1.Text = "Otra (indicar)"
        Me.lblPropiedadBiciOtraE1.Visible = False
        '
        'spcMotivoNoUsaE1
        '
        Me.spcMotivoNoUsaE1.Collapsed = True
        Me.spcMotivoNoUsaE1.CollapsePanel = DevExpress.XtraEditors.SplitCollapsePanel.Panel1
        Me.spcMotivoNoUsaE1.Location = New System.Drawing.Point(188, 0)
        Me.spcMotivoNoUsaE1.Name = "spcMotivoNoUsaE1"
        Me.spcMotivoNoUsaE1.Panel1.Controls.Add(Me.txtMotivoNoUsaE1)
        Me.spcMotivoNoUsaE1.Panel1.Controls.Add(Me.LabelControl79)
        Me.spcMotivoNoUsaE1.Panel1.Text = "Panel1"
        Me.spcMotivoNoUsaE1.Panel2.Controls.Add(Me.lkpEstacionamientoBiciE1)
        Me.spcMotivoNoUsaE1.Panel2.Controls.Add(Me.LabelControl102)
        Me.spcMotivoNoUsaE1.Panel2.Text = "Panel2"
        Me.spcMotivoNoUsaE1.Size = New System.Drawing.Size(570, 44)
        Me.spcMotivoNoUsaE1.SplitterPosition = 136
        Me.spcMotivoNoUsaE1.TabIndex = 45
        Me.spcMotivoNoUsaE1.Text = "SplitContainerControl2"
        '
        'txtMotivoNoUsaE1
        '
        Me.txtMotivoNoUsaE1.Location = New System.Drawing.Point(0, 17)
        Me.txtMotivoNoUsaE1.Name = "txtMotivoNoUsaE1"
        Me.txtMotivoNoUsaE1.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.txtMotivoNoUsaE1.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.txtMotivoNoUsaE1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtMotivoNoUsaE1.Size = New System.Drawing.Size(131, 20)
        Me.txtMotivoNoUsaE1.TabIndex = 40
        '
        'LabelControl79
        '
        Me.LabelControl79.Location = New System.Drawing.Point(0, 0)
        Me.LabelControl79.Name = "LabelControl79"
        Me.LabelControl79.Size = New System.Drawing.Size(91, 13)
        Me.LabelControl79.TabIndex = 39
        Me.LabelControl79.Text = "¿Por qué? (Indicar)"
        '
        'lkpEstacionamientoBiciE1
        '
        Me.lkpEstacionamientoBiciE1.EditValue = ""
        Me.lkpEstacionamientoBiciE1.Location = New System.Drawing.Point(11, 17)
        Me.lkpEstacionamientoBiciE1.Name = "lkpEstacionamientoBiciE1"
        Me.lkpEstacionamientoBiciE1.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.lkpEstacionamientoBiciE1.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.lkpEstacionamientoBiciE1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lkpEstacionamientoBiciE1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkpEstacionamientoBiciE1.Properties.DataSource = Me.EstacionamientoBicicletaBindingSource
        Me.lkpEstacionamientoBiciE1.Properties.DisplayMember = "EstacionamientoBicicleta"
        Me.lkpEstacionamientoBiciE1.Properties.ImmediatePopup = True
        Me.lkpEstacionamientoBiciE1.Properties.PopupFormMinSize = New System.Drawing.Size(395, 80)
        Me.lkpEstacionamientoBiciE1.Properties.PopupFormSize = New System.Drawing.Size(395, 80)
        Me.lkpEstacionamientoBiciE1.Properties.ShowFooter = False
        Me.lkpEstacionamientoBiciE1.Properties.ValueMember = "ID"
        Me.lkpEstacionamientoBiciE1.Properties.View = Me.GridView37
        Me.lkpEstacionamientoBiciE1.Size = New System.Drawing.Size(264, 20)
        Me.lkpEstacionamientoBiciE1.TabIndex = 42
        '
        'EstacionamientoBicicletaBindingSource
        '
        Me.EstacionamientoBicicletaBindingSource.DataMember = "EstacionamientoBicicleta"
        Me.EstacionamientoBicicletaBindingSource.DataSource = Me.datasetEOD
        Me.EstacionamientoBicicletaBindingSource.Sort = "ID"
        '
        'GridView37
        '
        Me.GridView37.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn54, Me.GridColumn55})
        Me.GridView37.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView37.Name = "GridView37"
        Me.GridView37.OptionsCustomization.AllowFilter = False
        Me.GridView37.OptionsCustomization.AllowGroup = False
        Me.GridView37.OptionsCustomization.AllowSort = False
        Me.GridView37.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView37.OptionsView.ShowColumnHeaders = False
        Me.GridView37.OptionsView.ShowGroupPanel = False
        Me.GridView37.OptionsView.ShowIndicator = False
        '
        'GridColumn54
        '
        Me.GridColumn54.FieldName = "ID"
        Me.GridColumn54.Name = "GridColumn54"
        '
        'GridColumn55
        '
        Me.GridColumn55.FieldName = "EstacionamientoBicicleta"
        Me.GridColumn55.Name = "GridColumn55"
        Me.GridColumn55.Visible = True
        Me.GridColumn55.VisibleIndex = 0
        '
        'LabelControl102
        '
        Me.LabelControl102.Location = New System.Drawing.Point(11, -2)
        Me.LabelControl102.Name = "LabelControl102"
        Me.LabelControl102.Size = New System.Drawing.Size(145, 13)
        Me.LabelControl102.TabIndex = 41
        Me.LabelControl102.Text = "¿Dónde estacionó su bicicleta?"
        '
        'LabelControl57
        '
        Me.LabelControl57.Location = New System.Drawing.Point(0, 0)
        Me.LabelControl57.Name = "LabelControl57"
        Me.LabelControl57.Size = New System.Drawing.Size(173, 13)
        Me.LabelControl57.TabIndex = 44
        Me.LabelControl57.Text = "¿Usó alguna ciclovía en su trayecto?"
        '
        'lkpCicloviaE1
        '
        Me.lkpCicloviaE1.EditValue = ""
        Me.lkpCicloviaE1.Location = New System.Drawing.Point(0, 19)
        Me.lkpCicloviaE1.Name = "lkpCicloviaE1"
        Me.lkpCicloviaE1.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.lkpCicloviaE1.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.lkpCicloviaE1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lkpCicloviaE1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkpCicloviaE1.Properties.DataSource = Me.SiNoBindingSource
        Me.lkpCicloviaE1.Properties.DisplayMember = "Opcion"
        Me.lkpCicloviaE1.Properties.ImmediatePopup = True
        Me.lkpCicloviaE1.Properties.PopupFormMinSize = New System.Drawing.Size(81, 40)
        Me.lkpCicloviaE1.Properties.PopupFormSize = New System.Drawing.Size(81, 40)
        Me.lkpCicloviaE1.Properties.ShowFooter = False
        Me.lkpCicloviaE1.Properties.ValueMember = "Id"
        Me.lkpCicloviaE1.Properties.View = Me.GridView26
        Me.lkpCicloviaE1.Size = New System.Drawing.Size(81, 20)
        Me.lkpCicloviaE1.TabIndex = 39
        '
        'GridView26
        '
        Me.GridView26.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn51, Me.GridColumn52})
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
        'GridColumn51
        '
        Me.GridColumn51.FieldName = "Id"
        Me.GridColumn51.Name = "GridColumn51"
        '
        'GridColumn52
        '
        Me.GridColumn52.FieldName = "Opcion"
        Me.GridColumn52.Name = "GridColumn52"
        Me.GridColumn52.Visible = True
        Me.GridColumn52.VisibleIndex = 0
        '
        'LabelControl48
        '
        Me.LabelControl48.Location = New System.Drawing.Point(2, 3)
        Me.LabelControl48.Name = "LabelControl48"
        Me.LabelControl48.Size = New System.Drawing.Size(182, 13)
        Me.LabelControl48.TabIndex = 35
        Me.LabelControl48.Text = "¿La bicicleta que usó en este viaje es?"
        '
        'lkpPropiedadBicicletaE1
        '
        Me.lkpPropiedadBicicletaE1.EditValue = ""
        Me.lkpPropiedadBicicletaE1.Location = New System.Drawing.Point(2, 22)
        Me.lkpPropiedadBicicletaE1.Name = "lkpPropiedadBicicletaE1"
        Me.lkpPropiedadBicicletaE1.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.lkpPropiedadBicicletaE1.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.lkpPropiedadBicicletaE1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lkpPropiedadBicicletaE1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkpPropiedadBicicletaE1.Properties.DataSource = Me.PropiedadBicicletaBindingSource
        Me.lkpPropiedadBicicletaE1.Properties.DisplayMember = "PropiedadBicicleta"
        Me.lkpPropiedadBicicletaE1.Properties.ImmediatePopup = True
        Me.lkpPropiedadBicicletaE1.Properties.PopupFormMinSize = New System.Drawing.Size(132, 40)
        Me.lkpPropiedadBicicletaE1.Properties.PopupFormSize = New System.Drawing.Size(132, 40)
        Me.lkpPropiedadBicicletaE1.Properties.ShowFooter = False
        Me.lkpPropiedadBicicletaE1.Properties.ValueMember = "ID"
        Me.lkpPropiedadBicicletaE1.Properties.View = Me.GridView25
        Me.lkpPropiedadBicicletaE1.Size = New System.Drawing.Size(132, 20)
        Me.lkpPropiedadBicicletaE1.TabIndex = 36
        '
        'PropiedadBicicletaBindingSource
        '
        Me.PropiedadBicicletaBindingSource.DataMember = "PropiedadBicicleta"
        Me.PropiedadBicicletaBindingSource.DataSource = Me.datasetEOD
        Me.PropiedadBicicletaBindingSource.Filter = "id > 0"
        '
        'GridView25
        '
        Me.GridView25.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID26, Me.colPropiedadBicicleta})
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
        'colID26
        '
        Me.colID26.FieldName = "ID"
        Me.colID26.Name = "colID26"
        '
        'colPropiedadBicicleta
        '
        Me.colPropiedadBicicleta.FieldName = "PropiedadBicicleta"
        Me.colPropiedadBicicleta.Name = "colPropiedadBicicleta"
        Me.colPropiedadBicicleta.Visible = True
        Me.colPropiedadBicicleta.VisibleIndex = 0
        '
        'tabBus
        '
        Me.tabBus.Controls.Add(Me.txtMinutosEsperaBusE1)
        Me.tabBus.Controls.Add(Me.spcCuantoPagoBusE1)
        Me.tabBus.Controls.Add(Me.LabelControl61)
        Me.tabBus.Controls.Add(Me.LabelControl66)
        Me.tabBus.Controls.Add(Me.LabelControl67)
        Me.tabBus.Controls.Add(Me.txtMinutosBusE1)
        Me.tabBus.Controls.Add(Me.txtCuadrasBusE1)
        Me.tabBus.Controls.Add(Me.LabelControl68)
        Me.tabBus.Controls.Add(Me.LabelControl69)
        Me.tabBus.Controls.Add(Me.LabelControl70)
        Me.tabBus.Controls.Add(Me.lkpTipoTarifaBusE1)
        Me.tabBus.Name = "tabBus"
        Me.tabBus.Size = New System.Drawing.Size(993, 177)
        Me.tabBus.Text = "tabBus"
        '
        'txtMinutosEsperaBusE1
        '
        Me.txtMinutosEsperaBusE1.Location = New System.Drawing.Point(243, 22)
        Me.txtMinutosEsperaBusE1.Name = "txtMinutosEsperaBusE1"
        Me.txtMinutosEsperaBusE1.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.txtMinutosEsperaBusE1.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.txtMinutosEsperaBusE1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtMinutosEsperaBusE1.Properties.Mask.EditMask = "n0"
        Me.txtMinutosEsperaBusE1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtMinutosEsperaBusE1.Size = New System.Drawing.Size(40, 20)
        Me.txtMinutosEsperaBusE1.TabIndex = 42
        '
        'spcCuantoPagoBusE1
        '
        Me.spcCuantoPagoBusE1.CollapsePanel = DevExpress.XtraEditors.SplitCollapsePanel.Panel1
        Me.spcCuantoPagoBusE1.Location = New System.Drawing.Point(640, -1)
        Me.spcCuantoPagoBusE1.Name = "spcCuantoPagoBusE1"
        Me.spcCuantoPagoBusE1.Panel1.Controls.Add(Me.LabelControl208)
        Me.spcCuantoPagoBusE1.Panel1.Controls.Add(Me.txtTarifaMontoBusE1)
        Me.spcCuantoPagoBusE1.Panel1.Controls.Add(Me.LabelControl53)
        Me.spcCuantoPagoBusE1.Panel1.Text = "Panel1"
        Me.spcCuantoPagoBusE1.Panel2.Controls.Add(Me.LabelControl60)
        Me.spcCuantoPagoBusE1.Panel2.Controls.Add(Me.lkpLugarBajadaBusE1)
        Me.spcCuantoPagoBusE1.Panel2.Text = "Panel2"
        Me.spcCuantoPagoBusE1.Size = New System.Drawing.Size(341, 48)
        Me.spcCuantoPagoBusE1.SplitterPosition = 141
        Me.spcCuantoPagoBusE1.TabIndex = 90
        Me.spcCuantoPagoBusE1.Text = "SplitContainerControl5"
        '
        'LabelControl208
        '
        Me.LabelControl208.Location = New System.Drawing.Point(67, 26)
        Me.LabelControl208.Name = "LabelControl208"
        Me.LabelControl208.Size = New System.Drawing.Size(65, 13)
        Me.LabelControl208.TabIndex = 69
        Me.LabelControl208.Text = "(NS/NR = 99)"
        '
        'txtTarifaMontoBusE1
        '
        Me.txtTarifaMontoBusE1.Location = New System.Drawing.Point(3, 23)
        Me.txtTarifaMontoBusE1.Name = "txtTarifaMontoBusE1"
        Me.txtTarifaMontoBusE1.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.txtTarifaMontoBusE1.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.txtTarifaMontoBusE1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtTarifaMontoBusE1.Properties.Mask.EditMask = "c0"
        Me.txtTarifaMontoBusE1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTarifaMontoBusE1.Size = New System.Drawing.Size(60, 20)
        Me.txtTarifaMontoBusE1.TabIndex = 44
        '
        'LabelControl53
        '
        Me.LabelControl53.Location = New System.Drawing.Point(3, 4)
        Me.LabelControl53.Name = "LabelControl53"
        Me.LabelControl53.Size = New System.Drawing.Size(118, 13)
        Me.LabelControl53.TabIndex = 25
        Me.LabelControl53.Text = "¿Cuanto pagó en pesos?"
        '
        'LabelControl60
        '
        Me.LabelControl60.Location = New System.Drawing.Point(6, 5)
        Me.LabelControl60.Name = "LabelControl60"
        Me.LabelControl60.Size = New System.Drawing.Size(79, 13)
        Me.LabelControl60.TabIndex = 0
        Me.LabelControl60.Text = "¿Dónde se bajó?"
        '
        'lkpLugarBajadaBusE1
        '
        Me.lkpLugarBajadaBusE1.EditValue = ""
        Me.lkpLugarBajadaBusE1.Location = New System.Drawing.Point(6, 24)
        Me.lkpLugarBajadaBusE1.Name = "lkpLugarBajadaBusE1"
        Me.lkpLugarBajadaBusE1.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.lkpLugarBajadaBusE1.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.lkpLugarBajadaBusE1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lkpLugarBajadaBusE1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkpLugarBajadaBusE1.Properties.DataSource = Me.DondeSeBajoE1BindingSource
        Me.lkpLugarBajadaBusE1.Properties.DisplayMember = "DondeSeBajo"
        Me.lkpLugarBajadaBusE1.Properties.ImmediatePopup = True
        Me.lkpLugarBajadaBusE1.Properties.PopupFormMinSize = New System.Drawing.Size(161, 40)
        Me.lkpLugarBajadaBusE1.Properties.PopupFormSize = New System.Drawing.Size(161, 40)
        Me.lkpLugarBajadaBusE1.Properties.ShowFooter = False
        Me.lkpLugarBajadaBusE1.Properties.ValueMember = "Id"
        Me.lkpLugarBajadaBusE1.Properties.View = Me.GridView34
        Me.lkpLugarBajadaBusE1.Size = New System.Drawing.Size(161, 20)
        Me.lkpLugarBajadaBusE1.TabIndex = 45
        '
        'GridView34
        '
        Me.GridView34.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colId34, Me.colDondeSeBajo})
        Me.GridView34.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView34.Name = "GridView34"
        Me.GridView34.OptionsCustomization.AllowFilter = False
        Me.GridView34.OptionsCustomization.AllowGroup = False
        Me.GridView34.OptionsCustomization.AllowSort = False
        Me.GridView34.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView34.OptionsView.ShowColumnHeaders = False
        Me.GridView34.OptionsView.ShowGroupPanel = False
        Me.GridView34.OptionsView.ShowIndicator = False
        '
        'colId34
        '
        Me.colId34.FieldName = "Id"
        Me.colId34.Name = "colId34"
        Me.colId34.OptionsColumn.AllowEdit = False
        '
        'colDondeSeBajo
        '
        Me.colDondeSeBajo.FieldName = "DondeSeBajo"
        Me.colDondeSeBajo.Name = "colDondeSeBajo"
        Me.colDondeSeBajo.Visible = True
        Me.colDondeSeBajo.VisibleIndex = 0
        '
        'LabelControl61
        '
        Me.LabelControl61.Location = New System.Drawing.Point(497, 3)
        Me.LabelControl61.Name = "LabelControl61"
        Me.LabelControl61.Size = New System.Drawing.Size(86, 13)
        Me.LabelControl61.TabIndex = 40
        Me.LabelControl61.Text = "¿Qué tarifa pagó?"
        '
        'LabelControl66
        '
        Me.LabelControl66.Location = New System.Drawing.Point(289, 25)
        Me.LabelControl66.Name = "LabelControl66"
        Me.LabelControl66.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl66.TabIndex = 31
        Me.LabelControl66.Text = "minutos"
        '
        'LabelControl67
        '
        Me.LabelControl67.Location = New System.Drawing.Point(243, 3)
        Me.LabelControl67.Name = "LabelControl67"
        Me.LabelControl67.Size = New System.Drawing.Size(235, 13)
        Me.LabelControl67.TabIndex = 30
        Me.LabelControl67.Text = "¿Cuánto rato esperó para abordar el transporte?"
        '
        'txtMinutosBusE1
        '
        Me.txtMinutosBusE1.Location = New System.Drawing.Point(115, 22)
        Me.txtMinutosBusE1.Name = "txtMinutosBusE1"
        Me.txtMinutosBusE1.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.txtMinutosBusE1.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.txtMinutosBusE1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtMinutosBusE1.Properties.Mask.EditMask = "n0"
        Me.txtMinutosBusE1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtMinutosBusE1.Size = New System.Drawing.Size(40, 20)
        Me.txtMinutosBusE1.TabIndex = 41
        '
        'txtCuadrasBusE1
        '
        Me.txtCuadrasBusE1.Location = New System.Drawing.Point(3, 22)
        Me.txtCuadrasBusE1.Name = "txtCuadrasBusE1"
        Me.txtCuadrasBusE1.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.txtCuadrasBusE1.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.txtCuadrasBusE1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtCuadrasBusE1.Properties.Mask.EditMask = "n0"
        Me.txtCuadrasBusE1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtCuadrasBusE1.Size = New System.Drawing.Size(40, 20)
        Me.txtCuadrasBusE1.TabIndex = 40
        '
        'LabelControl68
        '
        Me.LabelControl68.Location = New System.Drawing.Point(161, 26)
        Me.LabelControl68.Name = "LabelControl68"
        Me.LabelControl68.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl68.TabIndex = 27
        Me.LabelControl68.Text = "minutos"
        '
        'LabelControl69
        '
        Me.LabelControl69.Location = New System.Drawing.Point(49, 26)
        Me.LabelControl69.Name = "LabelControl69"
        Me.LabelControl69.Size = New System.Drawing.Size(38, 13)
        Me.LabelControl69.TabIndex = 26
        Me.LabelControl69.Text = "cuadras"
        '
        'LabelControl70
        '
        Me.LabelControl70.Location = New System.Drawing.Point(3, 3)
        Me.LabelControl70.Name = "LabelControl70"
        Me.LabelControl70.Size = New System.Drawing.Size(201, 13)
        Me.LabelControl70.TabIndex = 25
        Me.LabelControl70.Text = "¿Cuánto caminó antes de tomar este bus?"
        '
        'lkpTipoTarifaBusE1
        '
        Me.lkpTipoTarifaBusE1.EditValue = ""
        Me.lkpTipoTarifaBusE1.Location = New System.Drawing.Point(497, 22)
        Me.lkpTipoTarifaBusE1.Name = "lkpTipoTarifaBusE1"
        Me.lkpTipoTarifaBusE1.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.lkpTipoTarifaBusE1.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.lkpTipoTarifaBusE1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lkpTipoTarifaBusE1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkpTipoTarifaBusE1.Properties.DataSource = Me.TipoTarifaBindingSource
        Me.lkpTipoTarifaBusE1.Properties.DisplayMember = "TipoTarifaBus"
        Me.lkpTipoTarifaBusE1.Properties.ImmediatePopup = True
        Me.lkpTipoTarifaBusE1.Properties.PopupFormMinSize = New System.Drawing.Size(123, 100)
        Me.lkpTipoTarifaBusE1.Properties.PopupFormSize = New System.Drawing.Size(123, 100)
        Me.lkpTipoTarifaBusE1.Properties.ShowFooter = False
        Me.lkpTipoTarifaBusE1.Properties.ValueMember = "ID"
        Me.lkpTipoTarifaBusE1.Properties.View = Me.GridView33
        Me.lkpTipoTarifaBusE1.Size = New System.Drawing.Size(123, 20)
        Me.lkpTipoTarifaBusE1.TabIndex = 43
        '
        'TipoTarifaBindingSource
        '
        Me.TipoTarifaBindingSource.DataMember = "TipoTarifa"
        Me.TipoTarifaBindingSource.DataSource = Me.datasetEOD
        Me.TipoTarifaBindingSource.Filter = "id > 0"
        '
        'GridView33
        '
        Me.GridView33.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID24, Me.colTipoTarifaBus})
        Me.GridView33.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView33.Name = "GridView33"
        Me.GridView33.OptionsCustomization.AllowFilter = False
        Me.GridView33.OptionsCustomization.AllowGroup = False
        Me.GridView33.OptionsCustomization.AllowSort = False
        Me.GridView33.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView33.OptionsView.ShowColumnHeaders = False
        Me.GridView33.OptionsView.ShowGroupPanel = False
        Me.GridView33.OptionsView.ShowIndicator = False
        '
        'colID24
        '
        Me.colID24.FieldName = "ID"
        Me.colID24.Name = "colID24"
        '
        'colTipoTarifaBus
        '
        Me.colTipoTarifaBus.FieldName = "TipoTarifaBus"
        Me.colTipoTarifaBus.Name = "colTipoTarifaBus"
        Me.colTipoTarifaBus.OptionsColumn.AllowEdit = False
        Me.colTipoTarifaBus.Visible = True
        Me.colTipoTarifaBus.VisibleIndex = 0
        '
        'tabTXC
        '
        Me.tabTXC.Controls.Add(Me.LabelControl209)
        Me.tabTXC.Controls.Add(Me.LabelControl6)
        Me.tabTXC.Controls.Add(Me.LabelControl113)
        Me.tabTXC.Controls.Add(Me.LabelControl173)
        Me.tabTXC.Controls.Add(Me.txtMinutosEsperaTXCE1)
        Me.tabTXC.Controls.Add(Me.LabelControl174)
        Me.tabTXC.Controls.Add(Me.txtCuadrasTXCE1)
        Me.tabTXC.Controls.Add(Me.txtTarifaMontoTXCE1)
        Me.tabTXC.Controls.Add(Me.txtMinutosTXCE1)
        Me.tabTXC.Controls.Add(Me.LabelControl175)
        Me.tabTXC.Controls.Add(Me.LabelControl176)
        Me.tabTXC.Controls.Add(Me.LabelControl177)
        Me.tabTXC.Controls.Add(Me.lkpLugarBajadaTXCE1)
        Me.tabTXC.Name = "tabTXC"
        Me.tabTXC.Size = New System.Drawing.Size(993, 177)
        Me.tabTXC.Text = "tabTXC"
        '
        'LabelControl209
        '
        Me.LabelControl209.Location = New System.Drawing.Point(596, 25)
        Me.LabelControl209.Name = "LabelControl209"
        Me.LabelControl209.Size = New System.Drawing.Size(65, 13)
        Me.LabelControl209.TabIndex = 80
        Me.LabelControl209.Text = "(NS/NR = 99)"
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(2, 3)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(247, 13)
        Me.LabelControl6.TabIndex = 68
        Me.LabelControl6.Text = "¿Cuánto caminó antes de tomar este taxi colectivo?"
        '
        'LabelControl113
        '
        Me.LabelControl113.Location = New System.Drawing.Point(48, 26)
        Me.LabelControl113.Name = "LabelControl113"
        Me.LabelControl113.Size = New System.Drawing.Size(38, 13)
        Me.LabelControl113.TabIndex = 69
        Me.LabelControl113.Text = "cuadras"
        '
        'LabelControl173
        '
        Me.LabelControl173.Location = New System.Drawing.Point(160, 26)
        Me.LabelControl173.Name = "LabelControl173"
        Me.LabelControl173.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl173.TabIndex = 71
        Me.LabelControl173.Text = "minutos"
        '
        'txtMinutosEsperaTXCE1
        '
        Me.txtMinutosEsperaTXCE1.Location = New System.Drawing.Point(276, 22)
        Me.txtMinutosEsperaTXCE1.Name = "txtMinutosEsperaTXCE1"
        Me.txtMinutosEsperaTXCE1.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.txtMinutosEsperaTXCE1.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.txtMinutosEsperaTXCE1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtMinutosEsperaTXCE1.Properties.Mask.EditMask = "n0"
        Me.txtMinutosEsperaTXCE1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtMinutosEsperaTXCE1.Size = New System.Drawing.Size(40, 20)
        Me.txtMinutosEsperaTXCE1.TabIndex = 53
        '
        'LabelControl174
        '
        Me.LabelControl174.Location = New System.Drawing.Point(530, 3)
        Me.LabelControl174.Name = "LabelControl174"
        Me.LabelControl174.Size = New System.Drawing.Size(118, 13)
        Me.LabelControl174.TabIndex = 78
        Me.LabelControl174.Text = "¿Cuánto pagó en pesos?"
        '
        'txtCuadrasTXCE1
        '
        Me.txtCuadrasTXCE1.Location = New System.Drawing.Point(1, 22)
        Me.txtCuadrasTXCE1.Name = "txtCuadrasTXCE1"
        Me.txtCuadrasTXCE1.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.txtCuadrasTXCE1.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.txtCuadrasTXCE1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtCuadrasTXCE1.Properties.Mask.EditMask = "n0"
        Me.txtCuadrasTXCE1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtCuadrasTXCE1.Size = New System.Drawing.Size(40, 20)
        Me.txtCuadrasTXCE1.TabIndex = 51
        '
        'txtTarifaMontoTXCE1
        '
        Me.txtTarifaMontoTXCE1.Location = New System.Drawing.Point(530, 22)
        Me.txtTarifaMontoTXCE1.Name = "txtTarifaMontoTXCE1"
        Me.txtTarifaMontoTXCE1.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.txtTarifaMontoTXCE1.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.txtTarifaMontoTXCE1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtTarifaMontoTXCE1.Properties.Mask.EditMask = "c0"
        Me.txtTarifaMontoTXCE1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTarifaMontoTXCE1.Size = New System.Drawing.Size(60, 20)
        Me.txtTarifaMontoTXCE1.TabIndex = 54
        '
        'txtMinutosTXCE1
        '
        Me.txtMinutosTXCE1.Location = New System.Drawing.Point(114, 22)
        Me.txtMinutosTXCE1.Name = "txtMinutosTXCE1"
        Me.txtMinutosTXCE1.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.txtMinutosTXCE1.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.txtMinutosTXCE1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtMinutosTXCE1.Properties.Mask.EditMask = "n0"
        Me.txtMinutosTXCE1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtMinutosTXCE1.Size = New System.Drawing.Size(40, 20)
        Me.txtMinutosTXCE1.TabIndex = 52
        '
        'LabelControl175
        '
        Me.LabelControl175.Location = New System.Drawing.Point(333, 25)
        Me.LabelControl175.Name = "LabelControl175"
        Me.LabelControl175.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl175.TabIndex = 77
        Me.LabelControl175.Text = "minutos"
        '
        'LabelControl176
        '
        Me.LabelControl176.Location = New System.Drawing.Point(681, 4)
        Me.LabelControl176.Name = "LabelControl176"
        Me.LabelControl176.Size = New System.Drawing.Size(79, 13)
        Me.LabelControl176.TabIndex = 79
        Me.LabelControl176.Text = "¿Dónde se bajó?"
        '
        'LabelControl177
        '
        Me.LabelControl177.Location = New System.Drawing.Point(276, 3)
        Me.LabelControl177.Name = "LabelControl177"
        Me.LabelControl177.Size = New System.Drawing.Size(235, 13)
        Me.LabelControl177.TabIndex = 75
        Me.LabelControl177.Text = "¿Cuánto rato esperó para abordar el transporte?"
        '
        'lkpLugarBajadaTXCE1
        '
        Me.lkpLugarBajadaTXCE1.EditValue = ""
        Me.lkpLugarBajadaTXCE1.Location = New System.Drawing.Point(681, 23)
        Me.lkpLugarBajadaTXCE1.Name = "lkpLugarBajadaTXCE1"
        Me.lkpLugarBajadaTXCE1.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.lkpLugarBajadaTXCE1.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.lkpLugarBajadaTXCE1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lkpLugarBajadaTXCE1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkpLugarBajadaTXCE1.Properties.DataSource = Me.DondeSeBajoE1BindingSource
        Me.lkpLugarBajadaTXCE1.Properties.DisplayMember = "DondeSeBajo"
        Me.lkpLugarBajadaTXCE1.Properties.ImmediatePopup = True
        Me.lkpLugarBajadaTXCE1.Properties.PopupFormMinSize = New System.Drawing.Size(163, 40)
        Me.lkpLugarBajadaTXCE1.Properties.PopupFormSize = New System.Drawing.Size(163, 40)
        Me.lkpLugarBajadaTXCE1.Properties.ShowFooter = False
        Me.lkpLugarBajadaTXCE1.Properties.ValueMember = "Id"
        Me.lkpLugarBajadaTXCE1.Properties.View = Me.GridView64
        Me.lkpLugarBajadaTXCE1.Size = New System.Drawing.Size(163, 20)
        Me.lkpLugarBajadaTXCE1.TabIndex = 55
        '
        'GridView64
        '
        Me.GridView64.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn76, Me.GridColumn77})
        Me.GridView64.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView64.Name = "GridView64"
        Me.GridView64.OptionsCustomization.AllowFilter = False
        Me.GridView64.OptionsCustomization.AllowGroup = False
        Me.GridView64.OptionsCustomization.AllowSort = False
        Me.GridView64.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView64.OptionsView.ShowColumnHeaders = False
        Me.GridView64.OptionsView.ShowGroupPanel = False
        Me.GridView64.OptionsView.ShowIndicator = False
        '
        'GridColumn76
        '
        Me.GridColumn76.FieldName = "Id"
        Me.GridColumn76.Name = "GridColumn76"
        '
        'GridColumn77
        '
        Me.GridColumn77.FieldName = "DondeSeBajo"
        Me.GridColumn77.Name = "GridColumn77"
        Me.GridColumn77.OptionsColumn.AllowEdit = False
        Me.GridColumn77.Visible = True
        Me.GridColumn77.VisibleIndex = 0
        '
        'tabTransporte2
        '
        Me.tabTransporte2.Controls.Add(Me.gcLugarBajadaEtapa2)
        Me.tabTransporte2.Controls.Add(Me.tabsEtapa2)
        Me.tabTransporte2.Name = "tabTransporte2"
        Me.tabTransporte2.PageVisible = False
        Me.tabTransporte2.Size = New System.Drawing.Size(995, 179)
        Me.tabTransporte2.Text = "Transporte 2"
        '
        'gcLugarBajadaEtapa2
        '
        Me.gcLugarBajadaEtapa2.Controls.Add(Me.spcCallesEtapa2)
        Me.gcLugarBajadaEtapa2.Controls.Add(Me.LabelControl33)
        Me.gcLugarBajadaEtapa2.Controls.Add(Me.lkpComunaEtapa2)
        Me.gcLugarBajadaEtapa2.Location = New System.Drawing.Point(3, 100)
        Me.gcLugarBajadaEtapa2.Name = "gcLugarBajadaEtapa2"
        Me.gcLugarBajadaEtapa2.Size = New System.Drawing.Size(962, 75)
        Me.gcLugarBajadaEtapa2.TabIndex = 90
        Me.gcLugarBajadaEtapa2.Text = "¿En dónde se bajó?"
        '
        'spcCallesEtapa2
        '
        Me.spcCallesEtapa2.Collapsed = True
        Me.spcCallesEtapa2.CollapsePanel = DevExpress.XtraEditors.SplitCollapsePanel.Panel1
        Me.spcCallesEtapa2.IsSplitterFixed = True
        Me.spcCallesEtapa2.Location = New System.Drawing.Point(115, 26)
        Me.spcCallesEtapa2.Name = "spcCallesEtapa2"
        Me.spcCallesEtapa2.Panel1.Controls.Add(Me.LabelControl25)
        Me.spcCallesEtapa2.Panel1.Controls.Add(Me.txtComunaOtraEtapa2)
        Me.spcCallesEtapa2.Panel1.Text = "Panel1"
        Me.spcCallesEtapa2.Panel2.Controls.Add(Me.LabelControl145)
        Me.spcCallesEtapa2.Panel2.Controls.Add(Me.LabelControl146)
        Me.spcCallesEtapa2.Panel2.Controls.Add(Me.x_etapa2)
        Me.spcCallesEtapa2.Panel2.Controls.Add(Me.y_etapa2)
        Me.spcCallesEtapa2.Panel2.Controls.Add(Me.LabelControl29)
        Me.spcCallesEtapa2.Panel2.Controls.Add(Me.LabelControl30)
        Me.spcCallesEtapa2.Panel2.Controls.Add(Me.LabelControl31)
        Me.spcCallesEtapa2.Panel2.Controls.Add(Me.LabelControl32)
        Me.spcCallesEtapa2.Panel2.Controls.Add(Me.lkpManzanaEtapa2)
        Me.spcCallesEtapa2.Panel2.Controls.Add(Me.lkpCalle1Etapa2)
        Me.spcCallesEtapa2.Panel2.Controls.Add(Me.lkpCalle2Etapa2)
        Me.spcCallesEtapa2.Panel2.Controls.Add(Me.lkpHitoEtapa2)
        Me.spcCallesEtapa2.Panel2.Text = "Panel2"
        Me.spcCallesEtapa2.Size = New System.Drawing.Size(842, 44)
        Me.spcCallesEtapa2.SplitterPosition = 93
        Me.spcCallesEtapa2.TabIndex = 94
        Me.spcCallesEtapa2.Text = "SplitContainerControl1"
        Me.spcCallesEtapa2.Visible = False
        '
        'LabelControl25
        '
        Me.LabelControl25.Location = New System.Drawing.Point(3, 3)
        Me.LabelControl25.Name = "LabelControl25"
        Me.LabelControl25.Size = New System.Drawing.Size(62, 13)
        Me.LabelControl25.TabIndex = 10
        Me.LabelControl25.Text = "Otra comuna"
        '
        'txtComunaOtraEtapa2
        '
        Me.txtComunaOtraEtapa2.Location = New System.Drawing.Point(0, 21)
        Me.txtComunaOtraEtapa2.Name = "txtComunaOtraEtapa2"
        Me.txtComunaOtraEtapa2.Size = New System.Drawing.Size(85, 20)
        Me.txtComunaOtraEtapa2.TabIndex = 70
        '
        'LabelControl145
        '
        Me.LabelControl145.Location = New System.Drawing.Point(711, 24)
        Me.LabelControl145.Name = "LabelControl145"
        Me.LabelControl145.Size = New System.Drawing.Size(40, 13)
        Me.LabelControl145.TabIndex = 38
        Me.LabelControl145.Text = "y_etapa"
        Me.LabelControl145.Visible = False
        '
        'LabelControl146
        '
        Me.LabelControl146.Location = New System.Drawing.Point(711, 5)
        Me.LabelControl146.Name = "LabelControl146"
        Me.LabelControl146.Size = New System.Drawing.Size(40, 13)
        Me.LabelControl146.TabIndex = 37
        Me.LabelControl146.Text = "x_etapa"
        Me.LabelControl146.Visible = False
        '
        'x_etapa2
        '
        Me.x_etapa2.Location = New System.Drawing.Point(764, 3)
        Me.x_etapa2.Name = "x_etapa2"
        Me.x_etapa2.Size = New System.Drawing.Size(63, 20)
        Me.x_etapa2.TabIndex = 36
        Me.x_etapa2.Visible = False
        '
        'y_etapa2
        '
        Me.y_etapa2.Location = New System.Drawing.Point(764, 21)
        Me.y_etapa2.Name = "y_etapa2"
        Me.y_etapa2.Size = New System.Drawing.Size(63, 20)
        Me.y_etapa2.TabIndex = 35
        Me.y_etapa2.Visible = False
        '
        'LabelControl29
        '
        Me.LabelControl29.Location = New System.Drawing.Point(627, 3)
        Me.LabelControl29.Name = "LabelControl29"
        Me.LabelControl29.Size = New System.Drawing.Size(43, 13)
        Me.LabelControl29.TabIndex = 17
        Me.LabelControl29.Text = "Manzana"
        '
        'LabelControl30
        '
        Me.LabelControl30.Location = New System.Drawing.Point(5, 3)
        Me.LabelControl30.Name = "LabelControl30"
        Me.LabelControl30.Size = New System.Drawing.Size(32, 13)
        Me.LabelControl30.TabIndex = 12
        Me.LabelControl30.Text = "Calle 1"
        '
        'LabelControl31
        '
        Me.LabelControl31.Location = New System.Drawing.Point(212, 3)
        Me.LabelControl31.Name = "LabelControl31"
        Me.LabelControl31.Size = New System.Drawing.Size(32, 13)
        Me.LabelControl31.TabIndex = 13
        Me.LabelControl31.Text = "Calle 2"
        '
        'LabelControl32
        '
        Me.LabelControl32.Location = New System.Drawing.Point(414, 3)
        Me.LabelControl32.Name = "LabelControl32"
        Me.LabelControl32.Size = New System.Drawing.Size(19, 13)
        Me.LabelControl32.TabIndex = 15
        Me.LabelControl32.Text = "Hito"
        '
        'lkpManzanaEtapa2
        '
        Me.lkpManzanaEtapa2.Location = New System.Drawing.Point(627, 21)
        Me.lkpManzanaEtapa2.Name = "lkpManzanaEtapa2"
        Me.lkpManzanaEtapa2.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.lkpManzanaEtapa2.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.lkpManzanaEtapa2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lkpManzanaEtapa2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkpManzanaEtapa2.Properties.DropDownRows = 5
        Me.lkpManzanaEtapa2.Properties.PopupFormMinSize = New System.Drawing.Size(30, 0)
        Me.lkpManzanaEtapa2.Properties.ShowFooter = False
        Me.lkpManzanaEtapa2.Properties.ShowHeader = False
        Me.lkpManzanaEtapa2.Size = New System.Drawing.Size(72, 20)
        Me.lkpManzanaEtapa2.TabIndex = 73
        '
        'lkpCalle1Etapa2
        '
        Me.lkpCalle1Etapa2.EditValue = ""
        Me.lkpCalle1Etapa2.Location = New System.Drawing.Point(5, 21)
        Me.lkpCalle1Etapa2.Name = "lkpCalle1Etapa2"
        Me.lkpCalle1Etapa2.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.lkpCalle1Etapa2.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.lkpCalle1Etapa2.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.lkpCalle1Etapa2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lkpCalle1Etapa2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkpCalle1Etapa2.Properties.DataSource = Me.CallesBindingSource
        Me.lkpCalle1Etapa2.Properties.DisplayMember = "calle"
        Me.lkpCalle1Etapa2.Properties.ImmediatePopup = True
        Me.lkpCalle1Etapa2.Properties.NullText = ""
        Me.lkpCalle1Etapa2.Properties.NullValuePrompt = "No reporta"
        Me.lkpCalle1Etapa2.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.lkpCalle1Etapa2.Properties.ShowFooter = False
        Me.lkpCalle1Etapa2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.lkpCalle1Etapa2.Properties.ValueMember = "calle"
        Me.lkpCalle1Etapa2.Properties.View = Me.GridView39
        Me.lkpCalle1Etapa2.Size = New System.Drawing.Size(181, 20)
        Me.lkpCalle1Etapa2.TabIndex = 70
        '
        'GridView39
        '
        Me.GridView39.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2})
        Me.GridView39.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView39.Name = "GridView39"
        Me.GridView39.OptionsCustomization.AllowFilter = False
        Me.GridView39.OptionsCustomization.AllowGroup = False
        Me.GridView39.OptionsCustomization.AllowSort = False
        Me.GridView39.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView39.OptionsView.ShowColumnHeaders = False
        Me.GridView39.OptionsView.ShowGroupPanel = False
        Me.GridView39.OptionsView.ShowIndicator = False
        '
        'GridColumn1
        '
        Me.GridColumn1.FieldName = "id"
        Me.GridColumn1.Name = "GridColumn1"
        '
        'GridColumn2
        '
        Me.GridColumn2.FieldName = "calle"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 0
        '
        'lkpCalle2Etapa2
        '
        Me.lkpCalle2Etapa2.EditValue = ""
        Me.lkpCalle2Etapa2.Location = New System.Drawing.Point(212, 21)
        Me.lkpCalle2Etapa2.Name = "lkpCalle2Etapa2"
        Me.lkpCalle2Etapa2.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.lkpCalle2Etapa2.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.lkpCalle2Etapa2.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.lkpCalle2Etapa2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lkpCalle2Etapa2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkpCalle2Etapa2.Properties.DataSource = Me.ConsultaCalle2Etapa2BindingSource
        Me.lkpCalle2Etapa2.Properties.DisplayMember = "calle2"
        Me.lkpCalle2Etapa2.Properties.ImmediatePopup = True
        Me.lkpCalle2Etapa2.Properties.NullText = ""
        Me.lkpCalle2Etapa2.Properties.NullValuePrompt = "No reporta"
        Me.lkpCalle2Etapa2.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.lkpCalle2Etapa2.Properties.ShowFooter = False
        Me.lkpCalle2Etapa2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.lkpCalle2Etapa2.Properties.ValueMember = "calle2"
        Me.lkpCalle2Etapa2.Properties.View = Me.GridView40
        Me.lkpCalle2Etapa2.Size = New System.Drawing.Size(173, 20)
        Me.lkpCalle2Etapa2.TabIndex = 71
        '
        'ConsultaCalle2Etapa2BindingSource
        '
        Me.ConsultaCalle2Etapa2BindingSource.DataMember = "ConsultaCalle2Etapa2"
        Me.ConsultaCalle2Etapa2BindingSource.DataSource = Me.datasetEOD
        '
        'GridView40
        '
        Me.GridView40.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6})
        Me.GridView40.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView40.Name = "GridView40"
        Me.GridView40.OptionsCustomization.AllowFilter = False
        Me.GridView40.OptionsCustomization.AllowGroup = False
        Me.GridView40.OptionsCustomization.AllowSort = False
        Me.GridView40.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView40.OptionsView.ShowColumnHeaders = False
        Me.GridView40.OptionsView.ShowGroupPanel = False
        Me.GridView40.OptionsView.ShowIndicator = False
        '
        'GridColumn3
        '
        Me.GridColumn3.FieldName = "ID"
        Me.GridColumn3.Name = "GridColumn3"
        '
        'GridColumn4
        '
        Me.GridColumn4.FieldName = "calle1"
        Me.GridColumn4.Name = "GridColumn4"
        '
        'GridColumn5
        '
        Me.GridColumn5.FieldName = "calle2"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 0
        '
        'GridColumn6
        '
        Me.GridColumn6.FieldName = "conflictiva"
        Me.GridColumn6.Name = "GridColumn6"
        '
        'lkpHitoEtapa2
        '
        Me.lkpHitoEtapa2.EditValue = ""
        Me.lkpHitoEtapa2.Location = New System.Drawing.Point(414, 21)
        Me.lkpHitoEtapa2.Name = "lkpHitoEtapa2"
        Me.lkpHitoEtapa2.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.lkpHitoEtapa2.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.lkpHitoEtapa2.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.lkpHitoEtapa2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lkpHitoEtapa2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkpHitoEtapa2.Properties.DataSource = Me.HitoBindingSource
        Me.lkpHitoEtapa2.Properties.DisplayMember = "hito"
        Me.lkpHitoEtapa2.Properties.ImmediatePopup = True
        Me.lkpHitoEtapa2.Properties.NullText = ""
        Me.lkpHitoEtapa2.Properties.NullValuePrompt = "No reporta"
        Me.lkpHitoEtapa2.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.lkpHitoEtapa2.Properties.ShowFooter = False
        Me.lkpHitoEtapa2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.lkpHitoEtapa2.Properties.ValueMember = "hito"
        Me.lkpHitoEtapa2.Properties.View = Me.GridView41
        Me.lkpHitoEtapa2.Size = New System.Drawing.Size(188, 20)
        Me.lkpHitoEtapa2.TabIndex = 72
        '
        'GridView41
        '
        Me.GridView41.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn7, Me.GridColumn8, Me.GridColumn9})
        Me.GridView41.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView41.Name = "GridView41"
        Me.GridView41.OptionsCustomization.AllowFilter = False
        Me.GridView41.OptionsCustomization.AllowGroup = False
        Me.GridView41.OptionsCustomization.AllowSort = False
        Me.GridView41.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView41.OptionsView.ShowColumnHeaders = False
        Me.GridView41.OptionsView.ShowGroupPanel = False
        Me.GridView41.OptionsView.ShowIndicator = False
        '
        'GridColumn7
        '
        Me.GridColumn7.FieldName = "id"
        Me.GridColumn7.Name = "GridColumn7"
        '
        'GridColumn8
        '
        Me.GridColumn8.FieldName = "hito"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 0
        '
        'GridColumn9
        '
        Me.GridColumn9.FieldName = "hitoManzana"
        Me.GridColumn9.Name = "GridColumn9"
        '
        'LabelControl33
        '
        Me.LabelControl33.Location = New System.Drawing.Point(5, 29)
        Me.LabelControl33.Name = "LabelControl33"
        Me.LabelControl33.Size = New System.Drawing.Size(39, 13)
        Me.LabelControl33.TabIndex = 12
        Me.LabelControl33.Text = "Comuna"
        '
        'lkpComunaEtapa2
        '
        Me.lkpComunaEtapa2.EditValue = ""
        Me.lkpComunaEtapa2.Location = New System.Drawing.Point(5, 47)
        Me.lkpComunaEtapa2.Name = "lkpComunaEtapa2"
        Me.lkpComunaEtapa2.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.lkpComunaEtapa2.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.lkpComunaEtapa2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lkpComunaEtapa2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkpComunaEtapa2.Properties.DataSource = Me.ComunaBindingSource
        Me.lkpComunaEtapa2.Properties.DisplayMember = "Comuna"
        Me.lkpComunaEtapa2.Properties.PopupFormMinSize = New System.Drawing.Size(104, 240)
        Me.lkpComunaEtapa2.Properties.PopupFormSize = New System.Drawing.Size(104, 240)
        Me.lkpComunaEtapa2.Properties.ShowFooter = False
        Me.lkpComunaEtapa2.Properties.ValueMember = "ID"
        Me.lkpComunaEtapa2.Properties.View = Me.GridView42
        Me.lkpComunaEtapa2.Size = New System.Drawing.Size(104, 20)
        Me.lkpComunaEtapa2.TabIndex = 68
        '
        'GridView42
        '
        Me.GridView42.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn10, Me.GridColumn11})
        Me.GridView42.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView42.Name = "GridView42"
        Me.GridView42.OptionsCustomization.AllowFilter = False
        Me.GridView42.OptionsCustomization.AllowGroup = False
        Me.GridView42.OptionsCustomization.AllowSort = False
        Me.GridView42.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView42.OptionsView.ShowColumnHeaders = False
        Me.GridView42.OptionsView.ShowGroupPanel = False
        Me.GridView42.OptionsView.ShowIndicator = False
        Me.GridView42.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.GridColumn10, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'GridColumn10
        '
        Me.GridColumn10.FieldName = "ID"
        Me.GridColumn10.Name = "GridColumn10"
        '
        'GridColumn11
        '
        Me.GridColumn11.FieldName = "Comuna"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.Visible = True
        Me.GridColumn11.VisibleIndex = 0
        '
        'tabsEtapa2
        '
        Me.tabsEtapa2.AppearancePage.HeaderActive.BorderColor = System.Drawing.Color.Lime
        Me.tabsEtapa2.AppearancePage.HeaderActive.Options.UseBorderColor = True
        Me.tabsEtapa2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.tabsEtapa2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabsEtapa2.Location = New System.Drawing.Point(0, 0)
        Me.tabsEtapa2.Name = "tabsEtapa2"
        Me.tabsEtapa2.SelectedTabPage = Me.tabTaxiE2
        Me.tabsEtapa2.ShowTabHeader = DevExpress.Utils.DefaultBoolean.[False]
        Me.tabsEtapa2.Size = New System.Drawing.Size(995, 179)
        Me.tabsEtapa2.TabIndex = 89
        Me.tabsEtapa2.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tabAutoE2, Me.tabBicicletaE2, Me.tabBusE2, Me.tabTaxiE2, Me.tabTXCE2})
        Me.tabsEtapa2.Visible = False
        '
        'tabTaxiE2
        '
        Me.tabTaxiE2.Controls.Add(Me.LabelControl34)
        Me.tabTaxiE2.Controls.Add(Me.LabelControl45)
        Me.tabTaxiE2.Controls.Add(Me.LabelControl212)
        Me.tabTaxiE2.Controls.Add(Me.LabelControl40)
        Me.tabTaxiE2.Controls.Add(Me.LabelControl41)
        Me.tabTaxiE2.Controls.Add(Me.txtMinutosEsperaTaxiE2)
        Me.tabTaxiE2.Controls.Add(Me.LabelControl42)
        Me.tabTaxiE2.Controls.Add(Me.txtCuadrasTaxiE2)
        Me.tabTaxiE2.Controls.Add(Me.txtTarifaMontoTaxiE2)
        Me.tabTaxiE2.Controls.Add(Me.txtMinutosTaxiE2)
        Me.tabTaxiE2.Controls.Add(Me.LabelControl43)
        Me.tabTaxiE2.Controls.Add(Me.LabelControl44)
        Me.tabTaxiE2.Controls.Add(Me.lkpLugarBajadaTaxiE2)
        Me.tabTaxiE2.Name = "tabTaxiE2"
        Me.tabTaxiE2.Size = New System.Drawing.Size(993, 177)
        Me.tabTaxiE2.Text = "XtraTabPage3"
        '
        'LabelControl34
        '
        Me.LabelControl34.Location = New System.Drawing.Point(3, 5)
        Me.LabelControl34.Name = "LabelControl34"
        Me.LabelControl34.Size = New System.Drawing.Size(419, 13)
        Me.LabelControl34.TabIndex = 96
        Me.LabelControl34.Text = "¿Cuánto caminó antes de tomar este taxi, radiotaxi o aplicación (uber, cabify o s" &
    "imilar)?"
        '
        'LabelControl45
        '
        Me.LabelControl45.Location = New System.Drawing.Point(445, 5)
        Me.LabelControl45.Name = "LabelControl45"
        Me.LabelControl45.Size = New System.Drawing.Size(419, 13)
        Me.LabelControl45.TabIndex = 97
        Me.LabelControl45.Text = "¿Cuánto rato esperó para abordar el taxi, radiotaxi o aplicación (uber, cabify o " &
    "similar)?"
        '
        'LabelControl212
        '
        Me.LabelControl212.Location = New System.Drawing.Point(69, 76)
        Me.LabelControl212.Name = "LabelControl212"
        Me.LabelControl212.Size = New System.Drawing.Size(65, 13)
        Me.LabelControl212.TabIndex = 95
        Me.LabelControl212.Text = "(NS/NR = 99)"
        '
        'LabelControl40
        '
        Me.LabelControl40.Location = New System.Drawing.Point(49, 28)
        Me.LabelControl40.Name = "LabelControl40"
        Me.LabelControl40.Size = New System.Drawing.Size(38, 13)
        Me.LabelControl40.TabIndex = 51
        Me.LabelControl40.Text = "cuadras"
        '
        'LabelControl41
        '
        Me.LabelControl41.Location = New System.Drawing.Point(161, 28)
        Me.LabelControl41.Name = "LabelControl41"
        Me.LabelControl41.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl41.TabIndex = 52
        Me.LabelControl41.Text = "minutos"
        '
        'txtMinutosEsperaTaxiE2
        '
        Me.txtMinutosEsperaTaxiE2.Location = New System.Drawing.Point(445, 24)
        Me.txtMinutosEsperaTaxiE2.Name = "txtMinutosEsperaTaxiE2"
        Me.txtMinutosEsperaTaxiE2.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.txtMinutosEsperaTaxiE2.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.txtMinutosEsperaTaxiE2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtMinutosEsperaTaxiE2.Properties.Mask.EditMask = "n0"
        Me.txtMinutosEsperaTaxiE2.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtMinutosEsperaTaxiE2.Size = New System.Drawing.Size(40, 20)
        Me.txtMinutosEsperaTaxiE2.TabIndex = 53
        '
        'LabelControl42
        '
        Me.LabelControl42.Location = New System.Drawing.Point(3, 54)
        Me.LabelControl42.Name = "LabelControl42"
        Me.LabelControl42.Size = New System.Drawing.Size(118, 13)
        Me.LabelControl42.TabIndex = 65
        Me.LabelControl42.Text = "¿Cuánto pagó en pesos?"
        '
        'txtCuadrasTaxiE2
        '
        Me.txtCuadrasTaxiE2.Location = New System.Drawing.Point(2, 24)
        Me.txtCuadrasTaxiE2.Name = "txtCuadrasTaxiE2"
        Me.txtCuadrasTaxiE2.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.txtCuadrasTaxiE2.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.txtCuadrasTaxiE2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtCuadrasTaxiE2.Properties.Mask.EditMask = "n0"
        Me.txtCuadrasTaxiE2.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtCuadrasTaxiE2.Size = New System.Drawing.Size(40, 20)
        Me.txtCuadrasTaxiE2.TabIndex = 51
        '
        'txtTarifaMontoTaxiE2
        '
        Me.txtTarifaMontoTaxiE2.Location = New System.Drawing.Point(3, 73)
        Me.txtTarifaMontoTaxiE2.Name = "txtTarifaMontoTaxiE2"
        Me.txtTarifaMontoTaxiE2.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.txtTarifaMontoTaxiE2.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.txtTarifaMontoTaxiE2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtTarifaMontoTaxiE2.Properties.Mask.EditMask = "c0"
        Me.txtTarifaMontoTaxiE2.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTarifaMontoTaxiE2.Size = New System.Drawing.Size(60, 20)
        Me.txtTarifaMontoTaxiE2.TabIndex = 54
        '
        'txtMinutosTaxiE2
        '
        Me.txtMinutosTaxiE2.Location = New System.Drawing.Point(115, 24)
        Me.txtMinutosTaxiE2.Name = "txtMinutosTaxiE2"
        Me.txtMinutosTaxiE2.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.txtMinutosTaxiE2.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.txtMinutosTaxiE2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtMinutosTaxiE2.Properties.Mask.EditMask = "n0"
        Me.txtMinutosTaxiE2.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtMinutosTaxiE2.Size = New System.Drawing.Size(40, 20)
        Me.txtMinutosTaxiE2.TabIndex = 52
        '
        'LabelControl43
        '
        Me.LabelControl43.Location = New System.Drawing.Point(502, 27)
        Me.LabelControl43.Name = "LabelControl43"
        Me.LabelControl43.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl43.TabIndex = 56
        Me.LabelControl43.Text = "minutos"
        '
        'LabelControl44
        '
        Me.LabelControl44.Location = New System.Drawing.Point(146, 54)
        Me.LabelControl44.Name = "LabelControl44"
        Me.LabelControl44.Size = New System.Drawing.Size(79, 13)
        Me.LabelControl44.TabIndex = 67
        Me.LabelControl44.Text = "¿Dónde se bajó?"
        '
        'lkpLugarBajadaTaxiE2
        '
        Me.lkpLugarBajadaTaxiE2.EditValue = ""
        Me.lkpLugarBajadaTaxiE2.Location = New System.Drawing.Point(146, 73)
        Me.lkpLugarBajadaTaxiE2.Name = "lkpLugarBajadaTaxiE2"
        Me.lkpLugarBajadaTaxiE2.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.lkpLugarBajadaTaxiE2.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.lkpLugarBajadaTaxiE2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lkpLugarBajadaTaxiE2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkpLugarBajadaTaxiE2.Properties.DataSource = Me.DondeSeBajoE2BindingSource
        Me.lkpLugarBajadaTaxiE2.Properties.DisplayMember = "DondeSeBajo"
        Me.lkpLugarBajadaTaxiE2.Properties.ImmediatePopup = True
        Me.lkpLugarBajadaTaxiE2.Properties.PopupFormMinSize = New System.Drawing.Size(163, 40)
        Me.lkpLugarBajadaTaxiE2.Properties.PopupFormSize = New System.Drawing.Size(163, 40)
        Me.lkpLugarBajadaTaxiE2.Properties.ShowFooter = False
        Me.lkpLugarBajadaTaxiE2.Properties.ValueMember = "Id"
        Me.lkpLugarBajadaTaxiE2.Properties.View = Me.GridView36
        Me.lkpLugarBajadaTaxiE2.Size = New System.Drawing.Size(163, 20)
        Me.lkpLugarBajadaTaxiE2.TabIndex = 55
        '
        'DondeSeBajoE2BindingSource
        '
        Me.DondeSeBajoE2BindingSource.DataMember = "DondeSeBajo"
        Me.DondeSeBajoE2BindingSource.DataSource = Me.datasetEOD
        '
        'GridView36
        '
        Me.GridView36.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn12, Me.GridColumn13})
        Me.GridView36.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView36.Name = "GridView36"
        Me.GridView36.OptionsCustomization.AllowFilter = False
        Me.GridView36.OptionsCustomization.AllowGroup = False
        Me.GridView36.OptionsCustomization.AllowSort = False
        Me.GridView36.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView36.OptionsView.ShowColumnHeaders = False
        Me.GridView36.OptionsView.ShowGroupPanel = False
        Me.GridView36.OptionsView.ShowIndicator = False
        '
        'GridColumn12
        '
        Me.GridColumn12.FieldName = "Id"
        Me.GridColumn12.Name = "GridColumn12"
        '
        'GridColumn13
        '
        Me.GridColumn13.FieldName = "DondeSeBajo"
        Me.GridColumn13.Name = "GridColumn13"
        Me.GridColumn13.OptionsColumn.AllowEdit = False
        Me.GridColumn13.Visible = True
        Me.GridColumn13.VisibleIndex = 0
        '
        'tabAutoE2
        '
        Me.tabAutoE2.Controls.Add(Me.LabelControl62)
        Me.tabAutoE2.Controls.Add(Me.PanelControl1)
        Me.tabAutoE2.Controls.Add(Me.lkpVehHogarE2)
        Me.tabAutoE2.Controls.Add(Me.LabelControl84)
        Me.tabAutoE2.Controls.Add(Me.LabelControl86)
        Me.tabAutoE2.Controls.Add(Me.txtMinutosAutoE2)
        Me.tabAutoE2.Controls.Add(Me.txtCuadrasAutoE2)
        Me.tabAutoE2.Controls.Add(Me.LabelControl91)
        Me.tabAutoE2.Controls.Add(Me.LabelControl92)
        Me.tabAutoE2.Controls.Add(Me.LabelControl93)
        Me.tabAutoE2.Controls.Add(Me.lkpViajaComoE2)
        Me.tabAutoE2.Controls.Add(Me.lkpQueVehiculoE2)
        Me.tabAutoE2.Name = "tabAutoE2"
        Me.tabAutoE2.Size = New System.Drawing.Size(993, 177)
        Me.tabAutoE2.Text = "XtraTabPage4"
        '
        'LabelControl62
        '
        Me.LabelControl62.Location = New System.Drawing.Point(569, 3)
        Me.LabelControl62.Name = "LabelControl62"
        Me.LabelControl62.Size = New System.Drawing.Size(87, 13)
        Me.LabelControl62.TabIndex = 10
        Me.LabelControl62.Text = "Vehiculo del hogar"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.spcPagoBajadaAutoE2)
        Me.PanelControl1.Location = New System.Drawing.Point(2, 48)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(976, 54)
        Me.PanelControl1.TabIndex = 93
        '
        'spcPagoBajadaAutoE2
        '
        Me.spcPagoBajadaAutoE2.CollapsePanel = DevExpress.XtraEditors.SplitCollapsePanel.Panel1
        Me.spcPagoBajadaAutoE2.Location = New System.Drawing.Point(0, 0)
        Me.spcPagoBajadaAutoE2.Name = "spcPagoBajadaAutoE2"
        Me.spcPagoBajadaAutoE2.Panel1.Controls.Add(Me.spcPagoEstacionamientoE2)
        Me.spcPagoBajadaAutoE2.Panel1.Text = "Panel1"
        Me.spcPagoBajadaAutoE2.Panel2.Controls.Add(Me.LabelControl58)
        Me.spcPagoBajadaAutoE2.Panel2.Controls.Add(Me.lkpLugarBajadaAutoE2)
        Me.spcPagoBajadaAutoE2.Panel2.Text = "Panel2"
        Me.spcPagoBajadaAutoE2.Size = New System.Drawing.Size(866, 54)
        Me.spcPagoBajadaAutoE2.SplitterPosition = 658
        Me.spcPagoBajadaAutoE2.TabIndex = 95
        Me.spcPagoBajadaAutoE2.Text = "SplitContainerControl1"
        '
        'spcPagoEstacionamientoE2
        '
        Me.spcPagoEstacionamientoE2.CollapsePanel = DevExpress.XtraEditors.SplitCollapsePanel.Panel2
        Me.spcPagoEstacionamientoE2.Location = New System.Drawing.Point(1, 0)
        Me.spcPagoEstacionamientoE2.Name = "spcPagoEstacionamientoE2"
        Me.spcPagoEstacionamientoE2.Panel1.Controls.Add(Me.chkNSNRPagoE2)
        Me.spcPagoEstacionamientoE2.Panel1.Controls.Add(Me.txtCuantoPagoE2)
        Me.spcPagoEstacionamientoE2.Panel1.Controls.Add(Me.lblCuantoPagoE2)
        Me.spcPagoEstacionamientoE2.Panel1.Text = "Panel1"
        Me.spcPagoEstacionamientoE2.Panel2.Controls.Add(Me.spcFormaPagoE2)
        Me.spcPagoEstacionamientoE2.Panel2.Text = "Panel2"
        Me.spcPagoEstacionamientoE2.Size = New System.Drawing.Size(653, 54)
        Me.spcPagoEstacionamientoE2.SplitterPosition = 213
        Me.spcPagoEstacionamientoE2.TabIndex = 94
        Me.spcPagoEstacionamientoE2.Text = "SplitContainerControl2"
        '
        'chkNSNRPagoE2
        '
        Me.chkNSNRPagoE2.Location = New System.Drawing.Point(88, 26)
        Me.chkNSNRPagoE2.MenuManager = Me.TabFormDefaultManager1
        Me.chkNSNRPagoE2.Name = "chkNSNRPagoE2"
        Me.chkNSNRPagoE2.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.chkNSNRPagoE2.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.chkNSNRPagoE2.Properties.Caption = "No sabe/no responde"
        Me.chkNSNRPagoE2.Size = New System.Drawing.Size(126, 19)
        Me.chkNSNRPagoE2.TabIndex = 69
        '
        'txtCuantoPagoE2
        '
        Me.txtCuantoPagoE2.Location = New System.Drawing.Point(0, 25)
        Me.txtCuantoPagoE2.Name = "txtCuantoPagoE2"
        Me.txtCuantoPagoE2.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.txtCuantoPagoE2.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.txtCuantoPagoE2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtCuantoPagoE2.Properties.Mask.EditMask = "c0"
        Me.txtCuantoPagoE2.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtCuantoPagoE2.Size = New System.Drawing.Size(76, 20)
        Me.txtCuantoPagoE2.TabIndex = 68
        '
        'lblCuantoPagoE2
        '
        Me.lblCuantoPagoE2.Location = New System.Drawing.Point(0, 6)
        Me.lblCuantoPagoE2.Name = "lblCuantoPagoE2"
        Me.lblCuantoPagoE2.Size = New System.Drawing.Size(144, 13)
        Me.lblCuantoPagoE2.TabIndex = 6
        Me.lblCuantoPagoE2.Text = "¿Cuánto pagó por estacionar?"
        '
        'spcFormaPagoE2
        '
        Me.spcFormaPagoE2.Collapsed = True
        Me.spcFormaPagoE2.CollapsePanel = DevExpress.XtraEditors.SplitCollapsePanel.Panel1
        Me.spcFormaPagoE2.Location = New System.Drawing.Point(10, 6)
        Me.spcFormaPagoE2.Name = "spcFormaPagoE2"
        Me.spcFormaPagoE2.Panel1.Controls.Add(Me.LabelControl54)
        Me.spcFormaPagoE2.Panel1.Controls.Add(Me.lkpFormaPagoE2)
        Me.spcFormaPagoE2.Panel1.Text = "Panel1"
        Me.spcFormaPagoE2.Panel2.Controls.Add(Me.lkpDondeEstacionaE2)
        Me.spcFormaPagoE2.Panel2.Controls.Add(Me.LabelControl64)
        Me.spcFormaPagoE2.Panel2.Text = "Panel2"
        Me.spcFormaPagoE2.Size = New System.Drawing.Size(392, 48)
        Me.spcFormaPagoE2.SplitterPosition = 176
        Me.spcFormaPagoE2.TabIndex = 96
        Me.spcFormaPagoE2.Text = "SplitContainerControl2"
        '
        'LabelControl54
        '
        Me.LabelControl54.Location = New System.Drawing.Point(6, 3)
        Me.LabelControl54.Name = "LabelControl54"
        Me.LabelControl54.Size = New System.Drawing.Size(72, 13)
        Me.LabelControl54.TabIndex = 4
        Me.LabelControl54.Text = "¿Este pago es?"
        '
        'lkpFormaPagoE2
        '
        Me.lkpFormaPagoE2.EditValue = ""
        Me.lkpFormaPagoE2.Location = New System.Drawing.Point(6, 19)
        Me.lkpFormaPagoE2.Name = "lkpFormaPagoE2"
        Me.lkpFormaPagoE2.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.lkpFormaPagoE2.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.lkpFormaPagoE2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lkpFormaPagoE2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkpFormaPagoE2.Properties.DataSource = Me.FormaPagoBindingSource
        Me.lkpFormaPagoE2.Properties.DisplayMember = "FormaPago"
        Me.lkpFormaPagoE2.Properties.ImmediatePopup = True
        Me.lkpFormaPagoE2.Properties.PopupFormMinSize = New System.Drawing.Size(147, 160)
        Me.lkpFormaPagoE2.Properties.PopupFormSize = New System.Drawing.Size(147, 160)
        Me.lkpFormaPagoE2.Properties.ShowFooter = False
        Me.lkpFormaPagoE2.Properties.ValueMember = "ID"
        Me.lkpFormaPagoE2.Properties.View = Me.GridView43
        Me.lkpFormaPagoE2.Size = New System.Drawing.Size(147, 20)
        Me.lkpFormaPagoE2.TabIndex = 70
        '
        'GridView43
        '
        Me.GridView43.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn14, Me.GridColumn15})
        Me.GridView43.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView43.Name = "GridView43"
        Me.GridView43.OptionsCustomization.AllowFilter = False
        Me.GridView43.OptionsCustomization.AllowGroup = False
        Me.GridView43.OptionsCustomization.AllowSort = False
        Me.GridView43.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView43.OptionsView.ShowColumnHeaders = False
        Me.GridView43.OptionsView.ShowGroupPanel = False
        Me.GridView43.OptionsView.ShowIndicator = False
        Me.GridView43.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.GridColumn15, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'GridColumn14
        '
        Me.GridColumn14.FieldName = "ID"
        Me.GridColumn14.Name = "GridColumn14"
        '
        'GridColumn15
        '
        Me.GridColumn15.FieldName = "FormaPago"
        Me.GridColumn15.Name = "GridColumn15"
        Me.GridColumn15.Visible = True
        Me.GridColumn15.VisibleIndex = 0
        '
        'lkpDondeEstacionaE2
        '
        Me.lkpDondeEstacionaE2.EditValue = ""
        Me.lkpDondeEstacionaE2.Location = New System.Drawing.Point(3, 21)
        Me.lkpDondeEstacionaE2.Name = "lkpDondeEstacionaE2"
        Me.lkpDondeEstacionaE2.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.lkpDondeEstacionaE2.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.lkpDondeEstacionaE2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lkpDondeEstacionaE2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkpDondeEstacionaE2.Properties.DataSource = Me.DondeEstacionaBindingSource
        Me.lkpDondeEstacionaE2.Properties.DisplayMember = "DondeEstaciona"
        Me.lkpDondeEstacionaE2.Properties.ImmediatePopup = True
        Me.lkpDondeEstacionaE2.Properties.PopupFormMinSize = New System.Drawing.Size(186, 80)
        Me.lkpDondeEstacionaE2.Properties.PopupFormSize = New System.Drawing.Size(186, 80)
        Me.lkpDondeEstacionaE2.Properties.ShowFooter = False
        Me.lkpDondeEstacionaE2.Properties.ValueMember = "ID"
        Me.lkpDondeEstacionaE2.Properties.View = Me.GridView59
        Me.lkpDondeEstacionaE2.Size = New System.Drawing.Size(186, 20)
        Me.lkpDondeEstacionaE2.TabIndex = 35
        '
        'GridView59
        '
        Me.GridView59.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn56, Me.GridColumn57})
        Me.GridView59.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView59.Name = "GridView59"
        Me.GridView59.OptionsCustomization.AllowFilter = False
        Me.GridView59.OptionsCustomization.AllowGroup = False
        Me.GridView59.OptionsCustomization.AllowSort = False
        Me.GridView59.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView59.OptionsView.ShowColumnHeaders = False
        Me.GridView59.OptionsView.ShowGroupPanel = False
        Me.GridView59.OptionsView.ShowIndicator = False
        Me.GridView59.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.GridColumn56, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.GridColumn57, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'GridColumn56
        '
        Me.GridColumn56.FieldName = "ID"
        Me.GridColumn56.Name = "GridColumn56"
        '
        'GridColumn57
        '
        Me.GridColumn57.FieldName = "DondeEstaciona"
        Me.GridColumn57.Name = "GridColumn57"
        Me.GridColumn57.Visible = True
        Me.GridColumn57.VisibleIndex = 0
        '
        'LabelControl64
        '
        Me.LabelControl64.Location = New System.Drawing.Point(3, 3)
        Me.LabelControl64.Name = "LabelControl64"
        Me.LabelControl64.Size = New System.Drawing.Size(90, 13)
        Me.LabelControl64.TabIndex = 5
        Me.LabelControl64.Text = "¿Dónde estacionó?"
        '
        'LabelControl58
        '
        Me.LabelControl58.Location = New System.Drawing.Point(6, 6)
        Me.LabelControl58.Name = "LabelControl58"
        Me.LabelControl58.Size = New System.Drawing.Size(167, 13)
        Me.LabelControl58.TabIndex = 12
        Me.LabelControl58.Text = "¿En qué lugar se bajó del vehículo?"
        '
        'lkpLugarBajadaAutoE2
        '
        Me.lkpLugarBajadaAutoE2.EditValue = ""
        Me.lkpLugarBajadaAutoE2.Location = New System.Drawing.Point(6, 25)
        Me.lkpLugarBajadaAutoE2.Name = "lkpLugarBajadaAutoE2"
        Me.lkpLugarBajadaAutoE2.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.lkpLugarBajadaAutoE2.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.lkpLugarBajadaAutoE2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lkpLugarBajadaAutoE2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkpLugarBajadaAutoE2.Properties.DataSource = Me.DondeSeBajoE2BindingSource
        Me.lkpLugarBajadaAutoE2.Properties.DisplayMember = "DondeSeBajo"
        Me.lkpLugarBajadaAutoE2.Properties.ImmediatePopup = True
        Me.lkpLugarBajadaAutoE2.Properties.PopupFormMinSize = New System.Drawing.Size(167, 40)
        Me.lkpLugarBajadaAutoE2.Properties.PopupFormSize = New System.Drawing.Size(167, 40)
        Me.lkpLugarBajadaAutoE2.Properties.ShowFooter = False
        Me.lkpLugarBajadaAutoE2.Properties.ValueMember = "Id"
        Me.lkpLugarBajadaAutoE2.Properties.View = Me.GridView44
        Me.lkpLugarBajadaAutoE2.Size = New System.Drawing.Size(167, 20)
        Me.lkpLugarBajadaAutoE2.TabIndex = 71
        '
        'GridView44
        '
        Me.GridView44.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn16, Me.GridColumn17})
        Me.GridView44.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView44.Name = "GridView44"
        Me.GridView44.OptionsCustomization.AllowFilter = False
        Me.GridView44.OptionsCustomization.AllowGroup = False
        Me.GridView44.OptionsCustomization.AllowSort = False
        Me.GridView44.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView44.OptionsView.ShowColumnHeaders = False
        Me.GridView44.OptionsView.ShowGroupPanel = False
        Me.GridView44.OptionsView.ShowIndicator = False
        '
        'GridColumn16
        '
        Me.GridColumn16.FieldName = "Id"
        Me.GridColumn16.Name = "GridColumn16"
        '
        'GridColumn17
        '
        Me.GridColumn17.FieldName = "DondeSeBajo"
        Me.GridColumn17.Name = "GridColumn17"
        Me.GridColumn17.Visible = True
        Me.GridColumn17.VisibleIndex = 0
        '
        'lkpVehHogarE2
        '
        Me.lkpVehHogarE2.EditValue = ""
        Me.lkpVehHogarE2.Location = New System.Drawing.Point(569, 22)
        Me.lkpVehHogarE2.Name = "lkpVehHogarE2"
        Me.lkpVehHogarE2.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.lkpVehHogarE2.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.lkpVehHogarE2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lkpVehHogarE2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkpVehHogarE2.Properties.DataSource = Me.ResumenVehiculosBindingSource
        Me.lkpVehHogarE2.Properties.DisplayMember = "vehiculo"
        Me.lkpVehHogarE2.Properties.ImmediatePopup = True
        Me.lkpVehHogarE2.Properties.PopupFormMinSize = New System.Drawing.Size(330, 20)
        Me.lkpVehHogarE2.Properties.PopupFormSize = New System.Drawing.Size(330, 100)
        Me.lkpVehHogarE2.Properties.ShowFooter = False
        Me.lkpVehHogarE2.Properties.ValueMember = "Vehículo"
        Me.lkpVehHogarE2.Properties.View = Me.GridView45
        Me.lkpVehHogarE2.Size = New System.Drawing.Size(330, 20)
        Me.lkpVehHogarE2.TabIndex = 65
        '
        'GridView45
        '
        Me.GridView45.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colvehiculo1, Me.colCombustible1})
        Me.GridView45.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView45.Name = "GridView45"
        Me.GridView45.OptionsCustomization.AllowFilter = False
        Me.GridView45.OptionsCustomization.AllowGroup = False
        Me.GridView45.OptionsCustomization.AllowSort = False
        Me.GridView45.OptionsMenu.EnableColumnMenu = False
        Me.GridView45.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView45.OptionsView.ShowGroupPanel = False
        '
        'colvehiculo1
        '
        Me.colvehiculo1.Caption = "Tipo"
        Me.colvehiculo1.FieldName = "vehiculo"
        Me.colvehiculo1.Name = "colvehiculo1"
        Me.colvehiculo1.Visible = True
        Me.colvehiculo1.VisibleIndex = 1
        '
        'colCombustible1
        '
        Me.colCombustible1.FieldName = "Combustible"
        Me.colCombustible1.Name = "colCombustible1"
        Me.colCombustible1.Visible = True
        Me.colCombustible1.VisibleIndex = 0
        '
        'LabelControl84
        '
        Me.LabelControl84.Location = New System.Drawing.Point(445, 3)
        Me.LabelControl84.Name = "LabelControl84"
        Me.LabelControl84.Size = New System.Drawing.Size(102, 13)
        Me.LabelControl84.TabIndex = 22
        Me.LabelControl84.Text = "¿Qué vehículo utilizó?"
        '
        'LabelControl86
        '
        Me.LabelControl86.Location = New System.Drawing.Point(238, 3)
        Me.LabelControl86.Name = "LabelControl86"
        Me.LabelControl86.Size = New System.Drawing.Size(194, 13)
        Me.LabelControl86.TabIndex = 20
        Me.LabelControl86.Text = "¿Viajó como conductor o como pasajero?"
        '
        'txtMinutosAutoE2
        '
        Me.txtMinutosAutoE2.Location = New System.Drawing.Point(115, 22)
        Me.txtMinutosAutoE2.Name = "txtMinutosAutoE2"
        Me.txtMinutosAutoE2.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.txtMinutosAutoE2.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.txtMinutosAutoE2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtMinutosAutoE2.Properties.Mask.EditMask = "n0"
        Me.txtMinutosAutoE2.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtMinutosAutoE2.Size = New System.Drawing.Size(40, 20)
        Me.txtMinutosAutoE2.TabIndex = 62
        '
        'txtCuadrasAutoE2
        '
        Me.txtCuadrasAutoE2.Location = New System.Drawing.Point(3, 22)
        Me.txtCuadrasAutoE2.Name = "txtCuadrasAutoE2"
        Me.txtCuadrasAutoE2.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.txtCuadrasAutoE2.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.txtCuadrasAutoE2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtCuadrasAutoE2.Properties.Mask.EditMask = "n0"
        Me.txtCuadrasAutoE2.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtCuadrasAutoE2.Size = New System.Drawing.Size(40, 20)
        Me.txtCuadrasAutoE2.TabIndex = 61
        '
        'LabelControl91
        '
        Me.LabelControl91.Location = New System.Drawing.Point(161, 22)
        Me.LabelControl91.Name = "LabelControl91"
        Me.LabelControl91.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl91.TabIndex = 17
        Me.LabelControl91.Text = "minutos"
        '
        'LabelControl92
        '
        Me.LabelControl92.Location = New System.Drawing.Point(49, 22)
        Me.LabelControl92.Name = "LabelControl92"
        Me.LabelControl92.Size = New System.Drawing.Size(38, 13)
        Me.LabelControl92.TabIndex = 16
        Me.LabelControl92.Text = "cuadras"
        '
        'LabelControl93
        '
        Me.LabelControl93.Location = New System.Drawing.Point(3, 3)
        Me.LabelControl93.Name = "LabelControl93"
        Me.LabelControl93.Size = New System.Drawing.Size(223, 13)
        Me.LabelControl93.TabIndex = 15
        Me.LabelControl93.Text = "¿Cuánto caminó antes de tomar este vehículo?"
        '
        'lkpViajaComoE2
        '
        Me.lkpViajaComoE2.EditValue = ""
        Me.lkpViajaComoE2.Location = New System.Drawing.Point(238, 22)
        Me.lkpViajaComoE2.Name = "lkpViajaComoE2"
        Me.lkpViajaComoE2.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.lkpViajaComoE2.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.lkpViajaComoE2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lkpViajaComoE2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkpViajaComoE2.Properties.DataSource = Me.ViajaComoBindingSource
        Me.lkpViajaComoE2.Properties.DisplayMember = "ViajaComo"
        Me.lkpViajaComoE2.Properties.ImmediatePopup = True
        Me.lkpViajaComoE2.Properties.PopupFormMinSize = New System.Drawing.Size(100, 40)
        Me.lkpViajaComoE2.Properties.PopupFormSize = New System.Drawing.Size(100, 40)
        Me.lkpViajaComoE2.Properties.ShowFooter = False
        Me.lkpViajaComoE2.Properties.ValueMember = "Id"
        Me.lkpViajaComoE2.Properties.View = Me.GridView47
        Me.lkpViajaComoE2.Size = New System.Drawing.Size(100, 20)
        Me.lkpViajaComoE2.TabIndex = 63
        '
        'GridView47
        '
        Me.GridView47.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn21, Me.GridColumn22})
        Me.GridView47.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView47.Name = "GridView47"
        Me.GridView47.OptionsCustomization.AllowFilter = False
        Me.GridView47.OptionsCustomization.AllowGroup = False
        Me.GridView47.OptionsCustomization.AllowSort = False
        Me.GridView47.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView47.OptionsView.ShowColumnHeaders = False
        Me.GridView47.OptionsView.ShowGroupPanel = False
        Me.GridView47.OptionsView.ShowIndicator = False
        '
        'GridColumn21
        '
        Me.GridColumn21.FieldName = "Id"
        Me.GridColumn21.Name = "GridColumn21"
        '
        'GridColumn22
        '
        Me.GridColumn22.FieldName = "ViajaComo"
        Me.GridColumn22.Name = "GridColumn22"
        Me.GridColumn22.Visible = True
        Me.GridColumn22.VisibleIndex = 0
        '
        'lkpQueVehiculoE2
        '
        Me.lkpQueVehiculoE2.EditValue = ""
        Me.lkpQueVehiculoE2.Location = New System.Drawing.Point(445, 22)
        Me.lkpQueVehiculoE2.Name = "lkpQueVehiculoE2"
        Me.lkpQueVehiculoE2.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.lkpQueVehiculoE2.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.lkpQueVehiculoE2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lkpQueVehiculoE2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkpQueVehiculoE2.Properties.DataSource = Me.QueVehiculoBindingSource
        Me.lkpQueVehiculoE2.Properties.DisplayMember = "QueVehiculo"
        Me.lkpQueVehiculoE2.Properties.ImmediatePopup = True
        Me.lkpQueVehiculoE2.Properties.PopupFormMinSize = New System.Drawing.Size(100, 40)
        Me.lkpQueVehiculoE2.Properties.PopupFormSize = New System.Drawing.Size(100, 40)
        Me.lkpQueVehiculoE2.Properties.ShowFooter = False
        Me.lkpQueVehiculoE2.Properties.ValueMember = "Id"
        Me.lkpQueVehiculoE2.Properties.View = Me.GridView48
        Me.lkpQueVehiculoE2.Size = New System.Drawing.Size(102, 20)
        Me.lkpQueVehiculoE2.TabIndex = 64
        '
        'GridView48
        '
        Me.GridView48.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn23, Me.GridColumn24})
        Me.GridView48.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView48.Name = "GridView48"
        Me.GridView48.OptionsCustomization.AllowFilter = False
        Me.GridView48.OptionsCustomization.AllowGroup = False
        Me.GridView48.OptionsCustomization.AllowSort = False
        Me.GridView48.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView48.OptionsView.ShowColumnHeaders = False
        Me.GridView48.OptionsView.ShowGroupPanel = False
        Me.GridView48.OptionsView.ShowIndicator = False
        '
        'GridColumn23
        '
        Me.GridColumn23.FieldName = "Id"
        Me.GridColumn23.Name = "GridColumn23"
        '
        'GridColumn24
        '
        Me.GridColumn24.FieldName = "QueVehiculo"
        Me.GridColumn24.Name = "GridColumn24"
        Me.GridColumn24.Visible = True
        Me.GridColumn24.VisibleIndex = 0
        '
        'tabBicicletaE2
        '
        Me.tabBicicletaE2.Controls.Add(Me.spcPropiedadBicicletaE2)
        Me.tabBicicletaE2.Controls.Add(Me.LabelControl94)
        Me.tabBicicletaE2.Controls.Add(Me.LabelControl172)
        Me.tabBicicletaE2.Controls.Add(Me.lkpPropiedadBicicletaE2)
        Me.tabBicicletaE2.Controls.Add(Me.lkpLugarBajadaBiciE2)
        Me.tabBicicletaE2.Name = "tabBicicletaE2"
        Me.tabBicicletaE2.Size = New System.Drawing.Size(993, 177)
        Me.tabBicicletaE2.Text = "XtraTabPage5"
        '
        'spcPropiedadBicicletaE2
        '
        Me.spcPropiedadBicicletaE2.Collapsed = True
        Me.spcPropiedadBicicletaE2.CollapsePanel = DevExpress.XtraEditors.SplitCollapsePanel.Panel1
        Me.spcPropiedadBicicletaE2.Location = New System.Drawing.Point(203, 3)
        Me.spcPropiedadBicicletaE2.Name = "spcPropiedadBicicletaE2"
        Me.spcPropiedadBicicletaE2.Panel1.Controls.Add(Me.txtPropiedadBicicletaOtraE2)
        Me.spcPropiedadBicicletaE2.Panel1.Controls.Add(Me.lblPropiedadBiciOtraE2)
        Me.spcPropiedadBicicletaE2.Panel1.Text = "Panel1"
        Me.spcPropiedadBicicletaE2.Panel2.Controls.Add(Me.spcMotivoNoUsaE2)
        Me.spcPropiedadBicicletaE2.Panel2.Controls.Add(Me.LabelControl28)
        Me.spcPropiedadBicicletaE2.Panel2.Controls.Add(Me.lkpCicloviaE2)
        Me.spcPropiedadBicicletaE2.Panel2.Text = "Panel2"
        Me.spcPropiedadBicicletaE2.Size = New System.Drawing.Size(784, 54)
        Me.spcPropiedadBicicletaE2.SplitterPosition = 121
        Me.spcPropiedadBicicletaE2.TabIndex = 37
        Me.spcPropiedadBicicletaE2.Text = "SplitContainerControl4"
        '
        'txtPropiedadBicicletaOtraE2
        '
        Me.txtPropiedadBicicletaOtraE2.Location = New System.Drawing.Point(3, 19)
        Me.txtPropiedadBicicletaOtraE2.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.txtPropiedadBicicletaOtraE2.Name = "txtPropiedadBicicletaOtraE2"
        Me.txtPropiedadBicicletaOtraE2.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.txtPropiedadBicicletaOtraE2.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.txtPropiedadBicicletaOtraE2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtPropiedadBicicletaOtraE2.Size = New System.Drawing.Size(106, 20)
        Me.txtPropiedadBicicletaOtraE2.TabIndex = 38
        Me.txtPropiedadBicicletaOtraE2.Visible = False
        '
        'lblPropiedadBiciOtraE2
        '
        Me.lblPropiedadBiciOtraE2.Location = New System.Drawing.Point(0, 0)
        Me.lblPropiedadBiciOtraE2.Name = "lblPropiedadBiciOtraE2"
        Me.lblPropiedadBiciOtraE2.Size = New System.Drawing.Size(64, 13)
        Me.lblPropiedadBiciOtraE2.TabIndex = 40
        Me.lblPropiedadBiciOtraE2.Text = "Otra (indicar)"
        Me.lblPropiedadBiciOtraE2.Visible = False
        '
        'spcMotivoNoUsaE2
        '
        Me.spcMotivoNoUsaE2.Collapsed = True
        Me.spcMotivoNoUsaE2.CollapsePanel = DevExpress.XtraEditors.SplitCollapsePanel.Panel1
        Me.spcMotivoNoUsaE2.Location = New System.Drawing.Point(190, 3)
        Me.spcMotivoNoUsaE2.Name = "spcMotivoNoUsaE2"
        Me.spcMotivoNoUsaE2.Panel1.Controls.Add(Me.txtMotivoNoUsaE2)
        Me.spcMotivoNoUsaE2.Panel1.Controls.Add(Me.LabelControl124)
        Me.spcMotivoNoUsaE2.Panel1.Text = "Panel1"
        Me.spcMotivoNoUsaE2.Panel2.Controls.Add(Me.lkpEstacionamientoBiciE2)
        Me.spcMotivoNoUsaE2.Panel2.Controls.Add(Me.LabelControl125)
        Me.spcMotivoNoUsaE2.Panel2.Text = "Panel2"
        Me.spcMotivoNoUsaE2.Size = New System.Drawing.Size(454, 44)
        Me.spcMotivoNoUsaE2.SplitterPosition = 136
        Me.spcMotivoNoUsaE2.TabIndex = 46
        Me.spcMotivoNoUsaE2.Text = "SplitContainerControl2"
        '
        'txtMotivoNoUsaE2
        '
        Me.txtMotivoNoUsaE2.Location = New System.Drawing.Point(0, 17)
        Me.txtMotivoNoUsaE2.Name = "txtMotivoNoUsaE2"
        Me.txtMotivoNoUsaE2.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.txtMotivoNoUsaE2.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.txtMotivoNoUsaE2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtMotivoNoUsaE2.Size = New System.Drawing.Size(131, 20)
        Me.txtMotivoNoUsaE2.TabIndex = 40
        '
        'LabelControl124
        '
        Me.LabelControl124.Location = New System.Drawing.Point(0, 0)
        Me.LabelControl124.Name = "LabelControl124"
        Me.LabelControl124.Size = New System.Drawing.Size(91, 13)
        Me.LabelControl124.TabIndex = 39
        Me.LabelControl124.Text = "¿Por qué? (Indicar)"
        '
        'lkpEstacionamientoBiciE2
        '
        Me.lkpEstacionamientoBiciE2.EditValue = ""
        Me.lkpEstacionamientoBiciE2.Location = New System.Drawing.Point(11, 17)
        Me.lkpEstacionamientoBiciE2.Name = "lkpEstacionamientoBiciE2"
        Me.lkpEstacionamientoBiciE2.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.lkpEstacionamientoBiciE2.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.lkpEstacionamientoBiciE2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lkpEstacionamientoBiciE2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkpEstacionamientoBiciE2.Properties.DataSource = Me.EstacionamientoBicicletaBindingSource
        Me.lkpEstacionamientoBiciE2.Properties.DisplayMember = "EstacionamientoBicicleta"
        Me.lkpEstacionamientoBiciE2.Properties.ImmediatePopup = True
        Me.lkpEstacionamientoBiciE2.Properties.PopupFormMinSize = New System.Drawing.Size(283, 80)
        Me.lkpEstacionamientoBiciE2.Properties.PopupFormSize = New System.Drawing.Size(283, 80)
        Me.lkpEstacionamientoBiciE2.Properties.ShowFooter = False
        Me.lkpEstacionamientoBiciE2.Properties.ValueMember = "ID"
        Me.lkpEstacionamientoBiciE2.Properties.View = Me.GridView62
        Me.lkpEstacionamientoBiciE2.Size = New System.Drawing.Size(283, 20)
        Me.lkpEstacionamientoBiciE2.TabIndex = 41
        '
        'GridView62
        '
        Me.GridView62.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn79, Me.GridColumn93})
        Me.GridView62.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView62.Name = "GridView62"
        Me.GridView62.OptionsCustomization.AllowFilter = False
        Me.GridView62.OptionsCustomization.AllowGroup = False
        Me.GridView62.OptionsCustomization.AllowSort = False
        Me.GridView62.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView62.OptionsView.ShowColumnHeaders = False
        Me.GridView62.OptionsView.ShowGroupPanel = False
        Me.GridView62.OptionsView.ShowIndicator = False
        '
        'GridColumn79
        '
        Me.GridColumn79.FieldName = "ID"
        Me.GridColumn79.Name = "GridColumn79"
        '
        'GridColumn93
        '
        Me.GridColumn93.FieldName = "EstacionamientoBicicleta"
        Me.GridColumn93.Name = "GridColumn93"
        Me.GridColumn93.Visible = True
        Me.GridColumn93.VisibleIndex = 0
        '
        'LabelControl125
        '
        Me.LabelControl125.Location = New System.Drawing.Point(11, -2)
        Me.LabelControl125.Name = "LabelControl125"
        Me.LabelControl125.Size = New System.Drawing.Size(145, 13)
        Me.LabelControl125.TabIndex = 41
        Me.LabelControl125.Text = "¿Dónde estacionó su bicicleta?"
        '
        'LabelControl28
        '
        Me.LabelControl28.Location = New System.Drawing.Point(5, 0)
        Me.LabelControl28.Name = "LabelControl28"
        Me.LabelControl28.Size = New System.Drawing.Size(173, 13)
        Me.LabelControl28.TabIndex = 42
        Me.LabelControl28.Text = "¿Usó alguna ciclovía en su trayecto?"
        '
        'lkpCicloviaE2
        '
        Me.lkpCicloviaE2.EditValue = ""
        Me.lkpCicloviaE2.Location = New System.Drawing.Point(5, 19)
        Me.lkpCicloviaE2.Name = "lkpCicloviaE2"
        Me.lkpCicloviaE2.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.lkpCicloviaE2.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.lkpCicloviaE2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lkpCicloviaE2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkpCicloviaE2.Properties.DataSource = Me.SiNoBindingSource
        Me.lkpCicloviaE2.Properties.DisplayMember = "Opcion"
        Me.lkpCicloviaE2.Properties.ImmediatePopup = True
        Me.lkpCicloviaE2.Properties.PopupFormMinSize = New System.Drawing.Size(81, 40)
        Me.lkpCicloviaE2.Properties.PopupFormSize = New System.Drawing.Size(81, 40)
        Me.lkpCicloviaE2.Properties.ShowFooter = False
        Me.lkpCicloviaE2.Properties.ValueMember = "Id"
        Me.lkpCicloviaE2.Properties.View = Me.GridView24
        Me.lkpCicloviaE2.Size = New System.Drawing.Size(81, 20)
        Me.lkpCicloviaE2.TabIndex = 39
        '
        'GridView24
        '
        Me.GridView24.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn44, Me.GridColumn45})
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
        'GridColumn44
        '
        Me.GridColumn44.FieldName = "Id"
        Me.GridColumn44.Name = "GridColumn44"
        '
        'GridColumn45
        '
        Me.GridColumn45.FieldName = "Opcion"
        Me.GridColumn45.Name = "GridColumn45"
        Me.GridColumn45.Visible = True
        Me.GridColumn45.VisibleIndex = 0
        '
        'LabelControl94
        '
        Me.LabelControl94.Location = New System.Drawing.Point(2, 3)
        Me.LabelControl94.Name = "LabelControl94"
        Me.LabelControl94.Size = New System.Drawing.Size(182, 13)
        Me.LabelControl94.TabIndex = 35
        Me.LabelControl94.Text = "¿La bicicleta que usó en este viaje es?"
        '
        'LabelControl172
        '
        Me.LabelControl172.Location = New System.Drawing.Point(2, 54)
        Me.LabelControl172.Name = "LabelControl172"
        Me.LabelControl172.Size = New System.Drawing.Size(79, 13)
        Me.LabelControl172.TabIndex = 38
        Me.LabelControl172.Text = "¿Dónde se bajó?"
        '
        'lkpPropiedadBicicletaE2
        '
        Me.lkpPropiedadBicicletaE2.EditValue = ""
        Me.lkpPropiedadBicicletaE2.Location = New System.Drawing.Point(2, 22)
        Me.lkpPropiedadBicicletaE2.Name = "lkpPropiedadBicicletaE2"
        Me.lkpPropiedadBicicletaE2.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.lkpPropiedadBicicletaE2.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.lkpPropiedadBicicletaE2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lkpPropiedadBicicletaE2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkpPropiedadBicicletaE2.Properties.DataSource = Me.PropiedadBicicletaBindingSource
        Me.lkpPropiedadBicicletaE2.Properties.DisplayMember = "PropiedadBicicleta"
        Me.lkpPropiedadBicicletaE2.Properties.ImmediatePopup = True
        Me.lkpPropiedadBicicletaE2.Properties.PopupFormMinSize = New System.Drawing.Size(132, 60)
        Me.lkpPropiedadBicicletaE2.Properties.PopupFormSize = New System.Drawing.Size(132, 60)
        Me.lkpPropiedadBicicletaE2.Properties.ShowFooter = False
        Me.lkpPropiedadBicicletaE2.Properties.ValueMember = "ID"
        Me.lkpPropiedadBicicletaE2.Properties.View = Me.GridView49
        Me.lkpPropiedadBicicletaE2.Size = New System.Drawing.Size(132, 20)
        Me.lkpPropiedadBicicletaE2.TabIndex = 36
        '
        'GridView49
        '
        Me.GridView49.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn25, Me.GridColumn26})
        Me.GridView49.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView49.Name = "GridView49"
        Me.GridView49.OptionsCustomization.AllowFilter = False
        Me.GridView49.OptionsCustomization.AllowGroup = False
        Me.GridView49.OptionsCustomization.AllowSort = False
        Me.GridView49.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView49.OptionsView.ShowColumnHeaders = False
        Me.GridView49.OptionsView.ShowGroupPanel = False
        Me.GridView49.OptionsView.ShowIndicator = False
        '
        'GridColumn25
        '
        Me.GridColumn25.FieldName = "ID"
        Me.GridColumn25.Name = "GridColumn25"
        '
        'GridColumn26
        '
        Me.GridColumn26.FieldName = "PropiedadBicicleta"
        Me.GridColumn26.Name = "GridColumn26"
        Me.GridColumn26.Visible = True
        Me.GridColumn26.VisibleIndex = 0
        '
        'lkpLugarBajadaBiciE2
        '
        Me.lkpLugarBajadaBiciE2.EditValue = ""
        Me.lkpLugarBajadaBiciE2.Location = New System.Drawing.Point(2, 73)
        Me.lkpLugarBajadaBiciE2.Name = "lkpLugarBajadaBiciE2"
        Me.lkpLugarBajadaBiciE2.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.lkpLugarBajadaBiciE2.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.lkpLugarBajadaBiciE2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lkpLugarBajadaBiciE2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkpLugarBajadaBiciE2.Properties.DataSource = Me.DondeSeBajoE2BindingSource
        Me.lkpLugarBajadaBiciE2.Properties.DisplayMember = "DondeSeBajo"
        Me.lkpLugarBajadaBiciE2.Properties.ImmediatePopup = True
        Me.lkpLugarBajadaBiciE2.Properties.PopupFormMinSize = New System.Drawing.Size(167, 40)
        Me.lkpLugarBajadaBiciE2.Properties.PopupFormSize = New System.Drawing.Size(167, 40)
        Me.lkpLugarBajadaBiciE2.Properties.ShowFooter = False
        Me.lkpLugarBajadaBiciE2.Properties.ValueMember = "Id"
        Me.lkpLugarBajadaBiciE2.Properties.View = Me.GridView14
        Me.lkpLugarBajadaBiciE2.Size = New System.Drawing.Size(167, 20)
        Me.lkpLugarBajadaBiciE2.TabIndex = 45
        '
        'GridView14
        '
        Me.GridView14.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn74, Me.GridColumn75})
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
        'GridColumn74
        '
        Me.GridColumn74.FieldName = "Id"
        Me.GridColumn74.Name = "GridColumn74"
        '
        'GridColumn75
        '
        Me.GridColumn75.FieldName = "DondeSeBajo"
        Me.GridColumn75.Name = "GridColumn75"
        Me.GridColumn75.Visible = True
        Me.GridColumn75.VisibleIndex = 0
        '
        'tabBusE2
        '
        Me.tabBusE2.Controls.Add(Me.txtMinutosEsperaBusE2)
        Me.tabBusE2.Controls.Add(Me.spcCuantoPagoBusE2)
        Me.tabBusE2.Controls.Add(Me.LabelControl97)
        Me.tabBusE2.Controls.Add(Me.LabelControl98)
        Me.tabBusE2.Controls.Add(Me.LabelControl99)
        Me.tabBusE2.Controls.Add(Me.txtMinutosBusE2)
        Me.tabBusE2.Controls.Add(Me.txtCuadrasBusE2)
        Me.tabBusE2.Controls.Add(Me.LabelControl100)
        Me.tabBusE2.Controls.Add(Me.LabelControl103)
        Me.tabBusE2.Controls.Add(Me.LabelControl117)
        Me.tabBusE2.Controls.Add(Me.lkpTipoTarifaBusE2)
        Me.tabBusE2.Name = "tabBusE2"
        Me.tabBusE2.Size = New System.Drawing.Size(993, 177)
        Me.tabBusE2.Text = "XtraTabPage6"
        '
        'txtMinutosEsperaBusE2
        '
        Me.txtMinutosEsperaBusE2.Location = New System.Drawing.Point(243, 22)
        Me.txtMinutosEsperaBusE2.Name = "txtMinutosEsperaBusE2"
        Me.txtMinutosEsperaBusE2.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.txtMinutosEsperaBusE2.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.txtMinutosEsperaBusE2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtMinutosEsperaBusE2.Properties.Mask.EditMask = "n0"
        Me.txtMinutosEsperaBusE2.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtMinutosEsperaBusE2.Size = New System.Drawing.Size(40, 20)
        Me.txtMinutosEsperaBusE2.TabIndex = 76
        '
        'spcCuantoPagoBusE2
        '
        Me.spcCuantoPagoBusE2.CollapsePanel = DevExpress.XtraEditors.SplitCollapsePanel.Panel1
        Me.spcCuantoPagoBusE2.Location = New System.Drawing.Point(640, -1)
        Me.spcCuantoPagoBusE2.Name = "spcCuantoPagoBusE2"
        Me.spcCuantoPagoBusE2.Panel1.Controls.Add(Me.LabelControl216)
        Me.spcCuantoPagoBusE2.Panel1.Controls.Add(Me.txtTarifaMontoBusE2)
        Me.spcCuantoPagoBusE2.Panel1.Controls.Add(Me.LabelControl95)
        Me.spcCuantoPagoBusE2.Panel1.Text = "Panel1"
        Me.spcCuantoPagoBusE2.Panel2.Controls.Add(Me.LabelControl96)
        Me.spcCuantoPagoBusE2.Panel2.Controls.Add(Me.lkpLugarBajadaBusE2)
        Me.spcCuantoPagoBusE2.Panel2.Text = "Panel2"
        Me.spcCuantoPagoBusE2.Size = New System.Drawing.Size(341, 48)
        Me.spcCuantoPagoBusE2.SplitterPosition = 147
        Me.spcCuantoPagoBusE2.TabIndex = 90
        Me.spcCuantoPagoBusE2.Text = "SplitContainerControl5"
        '
        'LabelControl216
        '
        Me.LabelControl216.Location = New System.Drawing.Point(69, 26)
        Me.LabelControl216.Name = "LabelControl216"
        Me.LabelControl216.Size = New System.Drawing.Size(65, 13)
        Me.LabelControl216.TabIndex = 95
        Me.LabelControl216.Text = "(NS/NR = 99)"
        '
        'txtTarifaMontoBusE2
        '
        Me.txtTarifaMontoBusE2.Location = New System.Drawing.Point(3, 23)
        Me.txtTarifaMontoBusE2.Name = "txtTarifaMontoBusE2"
        Me.txtTarifaMontoBusE2.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.txtTarifaMontoBusE2.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.txtTarifaMontoBusE2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtTarifaMontoBusE2.Properties.Mask.EditMask = "c0"
        Me.txtTarifaMontoBusE2.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTarifaMontoBusE2.Size = New System.Drawing.Size(60, 20)
        Me.txtTarifaMontoBusE2.TabIndex = 78
        '
        'LabelControl95
        '
        Me.LabelControl95.Location = New System.Drawing.Point(3, 4)
        Me.LabelControl95.Name = "LabelControl95"
        Me.LabelControl95.Size = New System.Drawing.Size(118, 13)
        Me.LabelControl95.TabIndex = 25
        Me.LabelControl95.Text = "¿Cuanto pagó en pesos?"
        '
        'LabelControl96
        '
        Me.LabelControl96.Location = New System.Drawing.Point(6, 5)
        Me.LabelControl96.Name = "LabelControl96"
        Me.LabelControl96.Size = New System.Drawing.Size(79, 13)
        Me.LabelControl96.TabIndex = 0
        Me.LabelControl96.Text = "¿Dónde se bajó?"
        '
        'lkpLugarBajadaBusE2
        '
        Me.lkpLugarBajadaBusE2.EditValue = ""
        Me.lkpLugarBajadaBusE2.Location = New System.Drawing.Point(6, 24)
        Me.lkpLugarBajadaBusE2.Name = "lkpLugarBajadaBusE2"
        Me.lkpLugarBajadaBusE2.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.lkpLugarBajadaBusE2.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.lkpLugarBajadaBusE2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lkpLugarBajadaBusE2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkpLugarBajadaBusE2.Properties.DataSource = Me.DondeSeBajoE2BindingSource
        Me.lkpLugarBajadaBusE2.Properties.DisplayMember = "DondeSeBajo"
        Me.lkpLugarBajadaBusE2.Properties.ImmediatePopup = True
        Me.lkpLugarBajadaBusE2.Properties.PopupFormMinSize = New System.Drawing.Size(161, 40)
        Me.lkpLugarBajadaBusE2.Properties.PopupFormSize = New System.Drawing.Size(161, 40)
        Me.lkpLugarBajadaBusE2.Properties.ShowFooter = False
        Me.lkpLugarBajadaBusE2.Properties.ValueMember = "Id"
        Me.lkpLugarBajadaBusE2.Properties.View = Me.GridView50
        Me.lkpLugarBajadaBusE2.Size = New System.Drawing.Size(161, 20)
        Me.lkpLugarBajadaBusE2.TabIndex = 79
        '
        'GridView50
        '
        Me.GridView50.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn27, Me.GridColumn28})
        Me.GridView50.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView50.Name = "GridView50"
        Me.GridView50.OptionsCustomization.AllowFilter = False
        Me.GridView50.OptionsCustomization.AllowGroup = False
        Me.GridView50.OptionsCustomization.AllowSort = False
        Me.GridView50.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView50.OptionsView.ShowColumnHeaders = False
        Me.GridView50.OptionsView.ShowGroupPanel = False
        Me.GridView50.OptionsView.ShowIndicator = False
        '
        'GridColumn27
        '
        Me.GridColumn27.FieldName = "Id"
        Me.GridColumn27.Name = "GridColumn27"
        Me.GridColumn27.OptionsColumn.AllowEdit = False
        '
        'GridColumn28
        '
        Me.GridColumn28.FieldName = "DondeSeBajo"
        Me.GridColumn28.Name = "GridColumn28"
        Me.GridColumn28.Visible = True
        Me.GridColumn28.VisibleIndex = 0
        '
        'LabelControl97
        '
        Me.LabelControl97.Location = New System.Drawing.Point(497, 3)
        Me.LabelControl97.Name = "LabelControl97"
        Me.LabelControl97.Size = New System.Drawing.Size(86, 13)
        Me.LabelControl97.TabIndex = 40
        Me.LabelControl97.Text = "¿Qué tarifa pagó?"
        '
        'LabelControl98
        '
        Me.LabelControl98.Location = New System.Drawing.Point(289, 25)
        Me.LabelControl98.Name = "LabelControl98"
        Me.LabelControl98.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl98.TabIndex = 31
        Me.LabelControl98.Text = "minutos"
        '
        'LabelControl99
        '
        Me.LabelControl99.Location = New System.Drawing.Point(243, 3)
        Me.LabelControl99.Name = "LabelControl99"
        Me.LabelControl99.Size = New System.Drawing.Size(235, 13)
        Me.LabelControl99.TabIndex = 30
        Me.LabelControl99.Text = "¿Cuánto rato esperó para abordar el transporte?"
        '
        'txtMinutosBusE2
        '
        Me.txtMinutosBusE2.Location = New System.Drawing.Point(115, 22)
        Me.txtMinutosBusE2.Name = "txtMinutosBusE2"
        Me.txtMinutosBusE2.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.txtMinutosBusE2.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.txtMinutosBusE2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtMinutosBusE2.Properties.Mask.EditMask = "n0"
        Me.txtMinutosBusE2.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtMinutosBusE2.Size = New System.Drawing.Size(40, 20)
        Me.txtMinutosBusE2.TabIndex = 75
        '
        'txtCuadrasBusE2
        '
        Me.txtCuadrasBusE2.Location = New System.Drawing.Point(3, 22)
        Me.txtCuadrasBusE2.Name = "txtCuadrasBusE2"
        Me.txtCuadrasBusE2.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.txtCuadrasBusE2.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.txtCuadrasBusE2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtCuadrasBusE2.Properties.Mask.EditMask = "n0"
        Me.txtCuadrasBusE2.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtCuadrasBusE2.Size = New System.Drawing.Size(40, 20)
        Me.txtCuadrasBusE2.TabIndex = 74
        '
        'LabelControl100
        '
        Me.LabelControl100.Location = New System.Drawing.Point(161, 26)
        Me.LabelControl100.Name = "LabelControl100"
        Me.LabelControl100.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl100.TabIndex = 27
        Me.LabelControl100.Text = "minutos"
        '
        'LabelControl103
        '
        Me.LabelControl103.Location = New System.Drawing.Point(49, 26)
        Me.LabelControl103.Name = "LabelControl103"
        Me.LabelControl103.Size = New System.Drawing.Size(38, 13)
        Me.LabelControl103.TabIndex = 26
        Me.LabelControl103.Text = "cuadras"
        '
        'LabelControl117
        '
        Me.LabelControl117.Location = New System.Drawing.Point(3, 3)
        Me.LabelControl117.Name = "LabelControl117"
        Me.LabelControl117.Size = New System.Drawing.Size(210, 13)
        Me.LabelControl117.TabIndex = 25
        Me.LabelControl117.Text = "¿Cuánto caminó antes de tomar este modo?"
        '
        'lkpTipoTarifaBusE2
        '
        Me.lkpTipoTarifaBusE2.EditValue = ""
        Me.lkpTipoTarifaBusE2.Location = New System.Drawing.Point(497, 22)
        Me.lkpTipoTarifaBusE2.Name = "lkpTipoTarifaBusE2"
        Me.lkpTipoTarifaBusE2.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.lkpTipoTarifaBusE2.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.lkpTipoTarifaBusE2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lkpTipoTarifaBusE2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkpTipoTarifaBusE2.Properties.DataSource = Me.TipoTarifaBindingSource
        Me.lkpTipoTarifaBusE2.Properties.DisplayMember = "TipoTarifaBus"
        Me.lkpTipoTarifaBusE2.Properties.ImmediatePopup = True
        Me.lkpTipoTarifaBusE2.Properties.PopupFormMinSize = New System.Drawing.Size(123, 100)
        Me.lkpTipoTarifaBusE2.Properties.PopupFormSize = New System.Drawing.Size(123, 100)
        Me.lkpTipoTarifaBusE2.Properties.ShowFooter = False
        Me.lkpTipoTarifaBusE2.Properties.ValueMember = "ID"
        Me.lkpTipoTarifaBusE2.Properties.View = Me.GridView51
        Me.lkpTipoTarifaBusE2.Size = New System.Drawing.Size(123, 20)
        Me.lkpTipoTarifaBusE2.TabIndex = 77
        '
        'GridView51
        '
        Me.GridView51.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn29, Me.GridColumn30})
        Me.GridView51.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView51.Name = "GridView51"
        Me.GridView51.OptionsCustomization.AllowFilter = False
        Me.GridView51.OptionsCustomization.AllowGroup = False
        Me.GridView51.OptionsCustomization.AllowSort = False
        Me.GridView51.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView51.OptionsView.ShowColumnHeaders = False
        Me.GridView51.OptionsView.ShowGroupPanel = False
        Me.GridView51.OptionsView.ShowIndicator = False
        '
        'GridColumn29
        '
        Me.GridColumn29.FieldName = "ID"
        Me.GridColumn29.Name = "GridColumn29"
        '
        'GridColumn30
        '
        Me.GridColumn30.FieldName = "TipoTarifaBus"
        Me.GridColumn30.Name = "GridColumn30"
        Me.GridColumn30.OptionsColumn.AllowEdit = False
        Me.GridColumn30.Visible = True
        Me.GridColumn30.VisibleIndex = 0
        '
        'tabTXCE2
        '
        Me.tabTXCE2.Controls.Add(Me.LabelControl214)
        Me.tabTXCE2.Controls.Add(Me.LabelControl129)
        Me.tabTXCE2.Controls.Add(Me.txtTarifaMontoTXCE2)
        Me.tabTXCE2.Controls.Add(Me.txtMinutosEsperaTXCE2)
        Me.tabTXCE2.Controls.Add(Me.LabelControl130)
        Me.tabTXCE2.Controls.Add(Me.LabelControl131)
        Me.tabTXCE2.Controls.Add(Me.LabelControl132)
        Me.tabTXCE2.Controls.Add(Me.txtMinutosTXCE2)
        Me.tabTXCE2.Controls.Add(Me.txtCuadrasTXCE2)
        Me.tabTXCE2.Controls.Add(Me.LabelControl133)
        Me.tabTXCE2.Controls.Add(Me.LabelControl134)
        Me.tabTXCE2.Controls.Add(Me.LabelControl135)
        Me.tabTXCE2.Controls.Add(Me.lkpLugarBajadaTXCE2)
        Me.tabTXCE2.Name = "tabTXCE2"
        Me.tabTXCE2.Size = New System.Drawing.Size(993, 177)
        Me.tabTXCE2.Text = "XtraTabPage8"
        '
        'LabelControl214
        '
        Me.LabelControl214.Location = New System.Drawing.Point(620, 24)
        Me.LabelControl214.Name = "LabelControl214"
        Me.LabelControl214.Size = New System.Drawing.Size(65, 13)
        Me.LabelControl214.TabIndex = 95
        Me.LabelControl214.Text = "(NS/NR = 99)"
        '
        'LabelControl129
        '
        Me.LabelControl129.Location = New System.Drawing.Point(698, 2)
        Me.LabelControl129.Name = "LabelControl129"
        Me.LabelControl129.Size = New System.Drawing.Size(79, 13)
        Me.LabelControl129.TabIndex = 67
        Me.LabelControl129.Text = "¿Dónde se bajó?"
        '
        'txtTarifaMontoTXCE2
        '
        Me.txtTarifaMontoTXCE2.Location = New System.Drawing.Point(554, 21)
        Me.txtTarifaMontoTXCE2.Name = "txtTarifaMontoTXCE2"
        Me.txtTarifaMontoTXCE2.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.txtTarifaMontoTXCE2.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.txtTarifaMontoTXCE2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtTarifaMontoTXCE2.Properties.Mask.EditMask = "c0"
        Me.txtTarifaMontoTXCE2.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTarifaMontoTXCE2.Size = New System.Drawing.Size(60, 20)
        Me.txtTarifaMontoTXCE2.TabIndex = 54
        '
        'txtMinutosEsperaTXCE2
        '
        Me.txtMinutosEsperaTXCE2.Location = New System.Drawing.Point(281, 22)
        Me.txtMinutosEsperaTXCE2.Name = "txtMinutosEsperaTXCE2"
        Me.txtMinutosEsperaTXCE2.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.txtMinutosEsperaTXCE2.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.txtMinutosEsperaTXCE2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtMinutosEsperaTXCE2.Properties.Mask.EditMask = "n0"
        Me.txtMinutosEsperaTXCE2.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtMinutosEsperaTXCE2.Size = New System.Drawing.Size(40, 20)
        Me.txtMinutosEsperaTXCE2.TabIndex = 53
        '
        'LabelControl130
        '
        Me.LabelControl130.Location = New System.Drawing.Point(554, 3)
        Me.LabelControl130.Name = "LabelControl130"
        Me.LabelControl130.Size = New System.Drawing.Size(118, 13)
        Me.LabelControl130.TabIndex = 65
        Me.LabelControl130.Text = "¿Cuánto pagó en pesos?"
        '
        'LabelControl131
        '
        Me.LabelControl131.Location = New System.Drawing.Point(327, 25)
        Me.LabelControl131.Name = "LabelControl131"
        Me.LabelControl131.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl131.TabIndex = 56
        Me.LabelControl131.Text = "minutos"
        '
        'LabelControl132
        '
        Me.LabelControl132.Location = New System.Drawing.Point(281, 3)
        Me.LabelControl132.Name = "LabelControl132"
        Me.LabelControl132.Size = New System.Drawing.Size(235, 13)
        Me.LabelControl132.TabIndex = 55
        Me.LabelControl132.Text = "¿Cuánto rato esperó para abordar el transporte?"
        '
        'txtMinutosTXCE2
        '
        Me.txtMinutosTXCE2.Location = New System.Drawing.Point(115, 22)
        Me.txtMinutosTXCE2.Name = "txtMinutosTXCE2"
        Me.txtMinutosTXCE2.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.txtMinutosTXCE2.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.txtMinutosTXCE2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtMinutosTXCE2.Properties.Mask.EditMask = "n0"
        Me.txtMinutosTXCE2.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtMinutosTXCE2.Size = New System.Drawing.Size(40, 20)
        Me.txtMinutosTXCE2.TabIndex = 52
        '
        'txtCuadrasTXCE2
        '
        Me.txtCuadrasTXCE2.Location = New System.Drawing.Point(3, 22)
        Me.txtCuadrasTXCE2.Name = "txtCuadrasTXCE2"
        Me.txtCuadrasTXCE2.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.txtCuadrasTXCE2.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.txtCuadrasTXCE2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtCuadrasTXCE2.Properties.Mask.EditMask = "n0"
        Me.txtCuadrasTXCE2.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtCuadrasTXCE2.Size = New System.Drawing.Size(40, 20)
        Me.txtCuadrasTXCE2.TabIndex = 51
        '
        'LabelControl133
        '
        Me.LabelControl133.Location = New System.Drawing.Point(161, 26)
        Me.LabelControl133.Name = "LabelControl133"
        Me.LabelControl133.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl133.TabIndex = 52
        Me.LabelControl133.Text = "minutos"
        '
        'LabelControl134
        '
        Me.LabelControl134.Location = New System.Drawing.Point(49, 26)
        Me.LabelControl134.Name = "LabelControl134"
        Me.LabelControl134.Size = New System.Drawing.Size(38, 13)
        Me.LabelControl134.TabIndex = 51
        Me.LabelControl134.Text = "cuadras"
        '
        'LabelControl135
        '
        Me.LabelControl135.Location = New System.Drawing.Point(3, 3)
        Me.LabelControl135.Name = "LabelControl135"
        Me.LabelControl135.Size = New System.Drawing.Size(247, 13)
        Me.LabelControl135.TabIndex = 49
        Me.LabelControl135.Text = "¿Cuánto caminó antes de tomar este taxi colectivo?"
        '
        'lkpLugarBajadaTXCE2
        '
        Me.lkpLugarBajadaTXCE2.EditValue = ""
        Me.lkpLugarBajadaTXCE2.Location = New System.Drawing.Point(698, 21)
        Me.lkpLugarBajadaTXCE2.Name = "lkpLugarBajadaTXCE2"
        Me.lkpLugarBajadaTXCE2.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.lkpLugarBajadaTXCE2.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.lkpLugarBajadaTXCE2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lkpLugarBajadaTXCE2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkpLugarBajadaTXCE2.Properties.DataSource = Me.DondeSeBajoE2BindingSource
        Me.lkpLugarBajadaTXCE2.Properties.DisplayMember = "DondeSeBajo"
        Me.lkpLugarBajadaTXCE2.Properties.PopupFormMinSize = New System.Drawing.Size(168, 40)
        Me.lkpLugarBajadaTXCE2.Properties.PopupFormSize = New System.Drawing.Size(168, 40)
        Me.lkpLugarBajadaTXCE2.Properties.ShowFooter = False
        Me.lkpLugarBajadaTXCE2.Properties.ValueMember = "Id"
        Me.lkpLugarBajadaTXCE2.Properties.View = Me.GridView52
        Me.lkpLugarBajadaTXCE2.Size = New System.Drawing.Size(168, 20)
        Me.lkpLugarBajadaTXCE2.TabIndex = 55
        '
        'GridView52
        '
        Me.GridView52.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn31, Me.GridColumn32})
        Me.GridView52.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView52.Name = "GridView52"
        Me.GridView52.OptionsCustomization.AllowFilter = False
        Me.GridView52.OptionsCustomization.AllowGroup = False
        Me.GridView52.OptionsCustomization.AllowSort = False
        Me.GridView52.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView52.OptionsView.ShowColumnHeaders = False
        Me.GridView52.OptionsView.ShowGroupPanel = False
        Me.GridView52.OptionsView.ShowIndicator = False
        '
        'GridColumn31
        '
        Me.GridColumn31.FieldName = "Id"
        Me.GridColumn31.Name = "GridColumn31"
        '
        'GridColumn32
        '
        Me.GridColumn32.FieldName = "DondeSeBajo"
        Me.GridColumn32.Name = "GridColumn32"
        Me.GridColumn32.OptionsColumn.AllowEdit = False
        Me.GridColumn32.Visible = True
        Me.GridColumn32.VisibleIndex = 0
        '
        'tabTransporte3
        '
        Me.tabTransporte3.Controls.Add(Me.gcLugarBajadaEtapa3)
        Me.tabTransporte3.Controls.Add(Me.tabsEtapa3)
        Me.tabTransporte3.Name = "tabTransporte3"
        Me.tabTransporte3.PageVisible = False
        Me.tabTransporte3.Size = New System.Drawing.Size(995, 179)
        Me.tabTransporte3.Text = "Transporte 3"
        '
        'gcLugarBajadaEtapa3
        '
        Me.gcLugarBajadaEtapa3.Controls.Add(Me.spcCallesEtapa3)
        Me.gcLugarBajadaEtapa3.Controls.Add(Me.LabelControl123)
        Me.gcLugarBajadaEtapa3.Controls.Add(Me.lkpComunaEtapa3)
        Me.gcLugarBajadaEtapa3.Location = New System.Drawing.Point(3, 100)
        Me.gcLugarBajadaEtapa3.Name = "gcLugarBajadaEtapa3"
        Me.gcLugarBajadaEtapa3.Size = New System.Drawing.Size(962, 75)
        Me.gcLugarBajadaEtapa3.TabIndex = 94
        Me.gcLugarBajadaEtapa3.Text = "¿En dónde se bajó?"
        '
        'spcCallesEtapa3
        '
        Me.spcCallesEtapa3.Collapsed = True
        Me.spcCallesEtapa3.CollapsePanel = DevExpress.XtraEditors.SplitCollapsePanel.Panel1
        Me.spcCallesEtapa3.IsSplitterFixed = True
        Me.spcCallesEtapa3.Location = New System.Drawing.Point(115, 26)
        Me.spcCallesEtapa3.Name = "spcCallesEtapa3"
        Me.spcCallesEtapa3.Panel1.Controls.Add(Me.LabelControl14)
        Me.spcCallesEtapa3.Panel1.Controls.Add(Me.txtComunaOtraEtapa3)
        Me.spcCallesEtapa3.Panel1.Text = "Panel1"
        Me.spcCallesEtapa3.Panel2.Controls.Add(Me.LabelControl17)
        Me.spcCallesEtapa3.Panel2.Controls.Add(Me.LabelControl118)
        Me.spcCallesEtapa3.Panel2.Controls.Add(Me.x_etapa3)
        Me.spcCallesEtapa3.Panel2.Controls.Add(Me.y_etapa3)
        Me.spcCallesEtapa3.Panel2.Controls.Add(Me.LabelControl119)
        Me.spcCallesEtapa3.Panel2.Controls.Add(Me.LabelControl120)
        Me.spcCallesEtapa3.Panel2.Controls.Add(Me.LabelControl121)
        Me.spcCallesEtapa3.Panel2.Controls.Add(Me.LabelControl122)
        Me.spcCallesEtapa3.Panel2.Controls.Add(Me.lkpManzanaEtapa3)
        Me.spcCallesEtapa3.Panel2.Controls.Add(Me.lkpCalle1Etapa3)
        Me.spcCallesEtapa3.Panel2.Controls.Add(Me.lkpCalle2Etapa3)
        Me.spcCallesEtapa3.Panel2.Controls.Add(Me.lkpHitoEtapa3)
        Me.spcCallesEtapa3.Panel2.Text = "Panel2"
        Me.spcCallesEtapa3.Size = New System.Drawing.Size(842, 44)
        Me.spcCallesEtapa3.SplitterPosition = 93
        Me.spcCallesEtapa3.TabIndex = 94
        Me.spcCallesEtapa3.Text = "SplitContainerControl1"
        Me.spcCallesEtapa3.Visible = False
        '
        'LabelControl14
        '
        Me.LabelControl14.Location = New System.Drawing.Point(3, 3)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(62, 13)
        Me.LabelControl14.TabIndex = 10
        Me.LabelControl14.Text = "Otra comuna"
        '
        'txtComunaOtraEtapa3
        '
        Me.txtComunaOtraEtapa3.Location = New System.Drawing.Point(0, 21)
        Me.txtComunaOtraEtapa3.Name = "txtComunaOtraEtapa3"
        Me.txtComunaOtraEtapa3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtComunaOtraEtapa3.Size = New System.Drawing.Size(85, 20)
        Me.txtComunaOtraEtapa3.TabIndex = 69
        '
        'LabelControl17
        '
        Me.LabelControl17.Location = New System.Drawing.Point(711, 24)
        Me.LabelControl17.Name = "LabelControl17"
        Me.LabelControl17.Size = New System.Drawing.Size(40, 13)
        Me.LabelControl17.TabIndex = 38
        Me.LabelControl17.Text = "y_etapa"
        Me.LabelControl17.Visible = False
        '
        'LabelControl118
        '
        Me.LabelControl118.Location = New System.Drawing.Point(711, 5)
        Me.LabelControl118.Name = "LabelControl118"
        Me.LabelControl118.Size = New System.Drawing.Size(40, 13)
        Me.LabelControl118.TabIndex = 37
        Me.LabelControl118.Text = "x_etapa"
        Me.LabelControl118.Visible = False
        '
        'x_etapa3
        '
        Me.x_etapa3.Location = New System.Drawing.Point(764, 3)
        Me.x_etapa3.Name = "x_etapa3"
        Me.x_etapa3.Size = New System.Drawing.Size(63, 20)
        Me.x_etapa3.TabIndex = 36
        Me.x_etapa3.Visible = False
        '
        'y_etapa3
        '
        Me.y_etapa3.Location = New System.Drawing.Point(764, 21)
        Me.y_etapa3.Name = "y_etapa3"
        Me.y_etapa3.Size = New System.Drawing.Size(63, 20)
        Me.y_etapa3.TabIndex = 35
        Me.y_etapa3.Visible = False
        '
        'LabelControl119
        '
        Me.LabelControl119.Location = New System.Drawing.Point(627, 3)
        Me.LabelControl119.Name = "LabelControl119"
        Me.LabelControl119.Size = New System.Drawing.Size(43, 13)
        Me.LabelControl119.TabIndex = 17
        Me.LabelControl119.Text = "Manzana"
        '
        'LabelControl120
        '
        Me.LabelControl120.Location = New System.Drawing.Point(5, 3)
        Me.LabelControl120.Name = "LabelControl120"
        Me.LabelControl120.Size = New System.Drawing.Size(32, 13)
        Me.LabelControl120.TabIndex = 12
        Me.LabelControl120.Text = "Calle 1"
        '
        'LabelControl121
        '
        Me.LabelControl121.Location = New System.Drawing.Point(212, 3)
        Me.LabelControl121.Name = "LabelControl121"
        Me.LabelControl121.Size = New System.Drawing.Size(32, 13)
        Me.LabelControl121.TabIndex = 13
        Me.LabelControl121.Text = "Calle 2"
        '
        'LabelControl122
        '
        Me.LabelControl122.Location = New System.Drawing.Point(414, 3)
        Me.LabelControl122.Name = "LabelControl122"
        Me.LabelControl122.Size = New System.Drawing.Size(19, 13)
        Me.LabelControl122.TabIndex = 15
        Me.LabelControl122.Text = "Hito"
        '
        'lkpManzanaEtapa3
        '
        Me.lkpManzanaEtapa3.Location = New System.Drawing.Point(627, 21)
        Me.lkpManzanaEtapa3.Name = "lkpManzanaEtapa3"
        Me.lkpManzanaEtapa3.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.lkpManzanaEtapa3.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.lkpManzanaEtapa3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lkpManzanaEtapa3.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkpManzanaEtapa3.Properties.DropDownRows = 5
        Me.lkpManzanaEtapa3.Properties.PopupFormMinSize = New System.Drawing.Size(30, 0)
        Me.lkpManzanaEtapa3.Properties.ShowFooter = False
        Me.lkpManzanaEtapa3.Properties.ShowHeader = False
        Me.lkpManzanaEtapa3.Size = New System.Drawing.Size(72, 20)
        Me.lkpManzanaEtapa3.TabIndex = 73
        '
        'lkpCalle1Etapa3
        '
        Me.lkpCalle1Etapa3.EditValue = ""
        Me.lkpCalle1Etapa3.Location = New System.Drawing.Point(5, 21)
        Me.lkpCalle1Etapa3.Name = "lkpCalle1Etapa3"
        Me.lkpCalle1Etapa3.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.lkpCalle1Etapa3.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.lkpCalle1Etapa3.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.lkpCalle1Etapa3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lkpCalle1Etapa3.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkpCalle1Etapa3.Properties.DataSource = Me.CallesBindingSource
        Me.lkpCalle1Etapa3.Properties.DisplayMember = "calle"
        Me.lkpCalle1Etapa3.Properties.ImmediatePopup = True
        Me.lkpCalle1Etapa3.Properties.NullText = ""
        Me.lkpCalle1Etapa3.Properties.NullValuePrompt = "No reporta"
        Me.lkpCalle1Etapa3.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.lkpCalle1Etapa3.Properties.PopupFormMinSize = New System.Drawing.Size(181, 20)
        Me.lkpCalle1Etapa3.Properties.PopupFormSize = New System.Drawing.Size(181, 200)
        Me.lkpCalle1Etapa3.Properties.ShowFooter = False
        Me.lkpCalle1Etapa3.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.lkpCalle1Etapa3.Properties.ValueMember = "calle"
        Me.lkpCalle1Etapa3.Properties.View = Me.GridView46
        Me.lkpCalle1Etapa3.Size = New System.Drawing.Size(181, 20)
        Me.lkpCalle1Etapa3.TabIndex = 70
        '
        'GridView46
        '
        Me.GridView46.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn80, Me.GridColumn81})
        Me.GridView46.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView46.Name = "GridView46"
        Me.GridView46.OptionsCustomization.AllowFilter = False
        Me.GridView46.OptionsCustomization.AllowGroup = False
        Me.GridView46.OptionsCustomization.AllowSort = False
        Me.GridView46.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView46.OptionsView.ShowColumnHeaders = False
        Me.GridView46.OptionsView.ShowGroupPanel = False
        Me.GridView46.OptionsView.ShowIndicator = False
        '
        'GridColumn80
        '
        Me.GridColumn80.FieldName = "id"
        Me.GridColumn80.Name = "GridColumn80"
        '
        'GridColumn81
        '
        Me.GridColumn81.FieldName = "calle"
        Me.GridColumn81.Name = "GridColumn81"
        Me.GridColumn81.Visible = True
        Me.GridColumn81.VisibleIndex = 0
        '
        'lkpCalle2Etapa3
        '
        Me.lkpCalle2Etapa3.EditValue = ""
        Me.lkpCalle2Etapa3.Location = New System.Drawing.Point(212, 21)
        Me.lkpCalle2Etapa3.Name = "lkpCalle2Etapa3"
        Me.lkpCalle2Etapa3.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.lkpCalle2Etapa3.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.lkpCalle2Etapa3.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.lkpCalle2Etapa3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lkpCalle2Etapa3.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkpCalle2Etapa3.Properties.DataSource = Me.ConsultaCalle2Etapa3BindingSource
        Me.lkpCalle2Etapa3.Properties.DisplayMember = "calle2"
        Me.lkpCalle2Etapa3.Properties.ImmediatePopup = True
        Me.lkpCalle2Etapa3.Properties.NullText = ""
        Me.lkpCalle2Etapa3.Properties.NullValuePrompt = "No reporta"
        Me.lkpCalle2Etapa3.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.lkpCalle2Etapa3.Properties.PopupFormMinSize = New System.Drawing.Size(173, 20)
        Me.lkpCalle2Etapa3.Properties.PopupFormSize = New System.Drawing.Size(173, 200)
        Me.lkpCalle2Etapa3.Properties.ShowFooter = False
        Me.lkpCalle2Etapa3.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.lkpCalle2Etapa3.Properties.ValueMember = "calle2"
        Me.lkpCalle2Etapa3.Properties.View = Me.GridView70
        Me.lkpCalle2Etapa3.Size = New System.Drawing.Size(173, 20)
        Me.lkpCalle2Etapa3.TabIndex = 71
        '
        'ConsultaCalle2Etapa3BindingSource
        '
        Me.ConsultaCalle2Etapa3BindingSource.DataMember = "ConsultaCalle2Etapa3"
        Me.ConsultaCalle2Etapa3BindingSource.DataSource = Me.datasetEOD
        '
        'GridView70
        '
        Me.GridView70.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn82, Me.GridColumn83, Me.GridColumn84, Me.GridColumn85})
        Me.GridView70.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView70.Name = "GridView70"
        Me.GridView70.OptionsCustomization.AllowFilter = False
        Me.GridView70.OptionsCustomization.AllowGroup = False
        Me.GridView70.OptionsCustomization.AllowSort = False
        Me.GridView70.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView70.OptionsView.ShowColumnHeaders = False
        Me.GridView70.OptionsView.ShowGroupPanel = False
        Me.GridView70.OptionsView.ShowIndicator = False
        '
        'GridColumn82
        '
        Me.GridColumn82.FieldName = "ID"
        Me.GridColumn82.Name = "GridColumn82"
        '
        'GridColumn83
        '
        Me.GridColumn83.FieldName = "calle1"
        Me.GridColumn83.Name = "GridColumn83"
        '
        'GridColumn84
        '
        Me.GridColumn84.FieldName = "calle2"
        Me.GridColumn84.Name = "GridColumn84"
        Me.GridColumn84.Visible = True
        Me.GridColumn84.VisibleIndex = 0
        '
        'GridColumn85
        '
        Me.GridColumn85.FieldName = "conflictiva"
        Me.GridColumn85.Name = "GridColumn85"
        '
        'lkpHitoEtapa3
        '
        Me.lkpHitoEtapa3.EditValue = ""
        Me.lkpHitoEtapa3.Location = New System.Drawing.Point(414, 21)
        Me.lkpHitoEtapa3.Name = "lkpHitoEtapa3"
        Me.lkpHitoEtapa3.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.lkpHitoEtapa3.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.lkpHitoEtapa3.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.lkpHitoEtapa3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lkpHitoEtapa3.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkpHitoEtapa3.Properties.DataSource = Me.HitoBindingSource
        Me.lkpHitoEtapa3.Properties.DisplayMember = "hito"
        Me.lkpHitoEtapa3.Properties.ImmediatePopup = True
        Me.lkpHitoEtapa3.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.lkpHitoEtapa3.Properties.PopupFormMinSize = New System.Drawing.Size(188, 20)
        Me.lkpHitoEtapa3.Properties.PopupFormSize = New System.Drawing.Size(188, 200)
        Me.lkpHitoEtapa3.Properties.ShowFooter = False
        Me.lkpHitoEtapa3.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.lkpHitoEtapa3.Properties.ValueMember = "hito"
        Me.lkpHitoEtapa3.Properties.View = Me.GridView71
        Me.lkpHitoEtapa3.Size = New System.Drawing.Size(188, 20)
        Me.lkpHitoEtapa3.TabIndex = 72
        '
        'GridView71
        '
        Me.GridView71.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn86, Me.GridColumn87, Me.GridColumn88})
        Me.GridView71.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView71.Name = "GridView71"
        Me.GridView71.OptionsCustomization.AllowFilter = False
        Me.GridView71.OptionsCustomization.AllowGroup = False
        Me.GridView71.OptionsCustomization.AllowSort = False
        Me.GridView71.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView71.OptionsView.ShowColumnHeaders = False
        Me.GridView71.OptionsView.ShowGroupPanel = False
        Me.GridView71.OptionsView.ShowIndicator = False
        '
        'GridColumn86
        '
        Me.GridColumn86.FieldName = "id"
        Me.GridColumn86.Name = "GridColumn86"
        '
        'GridColumn87
        '
        Me.GridColumn87.FieldName = "hito"
        Me.GridColumn87.Name = "GridColumn87"
        Me.GridColumn87.Visible = True
        Me.GridColumn87.VisibleIndex = 0
        '
        'GridColumn88
        '
        Me.GridColumn88.FieldName = "hitoManzana"
        Me.GridColumn88.Name = "GridColumn88"
        '
        'LabelControl123
        '
        Me.LabelControl123.Location = New System.Drawing.Point(5, 29)
        Me.LabelControl123.Name = "LabelControl123"
        Me.LabelControl123.Size = New System.Drawing.Size(39, 13)
        Me.LabelControl123.TabIndex = 12
        Me.LabelControl123.Text = "Comuna"
        '
        'lkpComunaEtapa3
        '
        Me.lkpComunaEtapa3.EditValue = ""
        Me.lkpComunaEtapa3.Location = New System.Drawing.Point(5, 47)
        Me.lkpComunaEtapa3.Name = "lkpComunaEtapa3"
        Me.lkpComunaEtapa3.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.lkpComunaEtapa3.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.lkpComunaEtapa3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lkpComunaEtapa3.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkpComunaEtapa3.Properties.DataSource = Me.ComunaBindingSource
        Me.lkpComunaEtapa3.Properties.DisplayMember = "Comuna"
        Me.lkpComunaEtapa3.Properties.PopupFormMinSize = New System.Drawing.Size(104, 240)
        Me.lkpComunaEtapa3.Properties.PopupFormSize = New System.Drawing.Size(104, 240)
        Me.lkpComunaEtapa3.Properties.ShowFooter = False
        Me.lkpComunaEtapa3.Properties.ValueMember = "ID"
        Me.lkpComunaEtapa3.Properties.View = Me.GridView72
        Me.lkpComunaEtapa3.Size = New System.Drawing.Size(104, 20)
        Me.lkpComunaEtapa3.TabIndex = 68
        '
        'GridView72
        '
        Me.GridView72.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn89, Me.GridColumn90})
        Me.GridView72.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView72.Name = "GridView72"
        Me.GridView72.OptionsCustomization.AllowFilter = False
        Me.GridView72.OptionsCustomization.AllowGroup = False
        Me.GridView72.OptionsCustomization.AllowSort = False
        Me.GridView72.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView72.OptionsView.ShowColumnHeaders = False
        Me.GridView72.OptionsView.ShowGroupPanel = False
        Me.GridView72.OptionsView.ShowIndicator = False
        Me.GridView72.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.GridColumn89, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'GridColumn89
        '
        Me.GridColumn89.FieldName = "ID"
        Me.GridColumn89.Name = "GridColumn89"
        '
        'GridColumn90
        '
        Me.GridColumn90.FieldName = "Comuna"
        Me.GridColumn90.Name = "GridColumn90"
        Me.GridColumn90.Visible = True
        Me.GridColumn90.VisibleIndex = 0
        '
        'tabsEtapa3
        '
        Me.tabsEtapa3.AppearancePage.HeaderActive.BorderColor = System.Drawing.Color.Lime
        Me.tabsEtapa3.AppearancePage.HeaderActive.Options.UseBorderColor = True
        Me.tabsEtapa3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.tabsEtapa3.BorderStylePage = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.tabsEtapa3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabsEtapa3.Location = New System.Drawing.Point(0, 0)
        Me.tabsEtapa3.Name = "tabsEtapa3"
        Me.tabsEtapa3.SelectedTabPage = Me.tabTaxiE3
        Me.tabsEtapa3.ShowTabHeader = DevExpress.Utils.DefaultBoolean.[False]
        Me.tabsEtapa3.Size = New System.Drawing.Size(995, 179)
        Me.tabsEtapa3.TabIndex = 90
        Me.tabsEtapa3.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tabAutoE3, Me.tabBicicletaE3, Me.tabBusE3, Me.tabTaxiE3, Me.tabTXCE3})
        Me.tabsEtapa3.Visible = False
        '
        'tabTaxiE3
        '
        Me.tabTaxiE3.Controls.Add(Me.LabelControl71)
        Me.tabTaxiE3.Controls.Add(Me.LabelControl77)
        Me.tabTaxiE3.Controls.Add(Me.LabelControl217)
        Me.tabTaxiE3.Controls.Add(Me.LabelControl72)
        Me.tabTaxiE3.Controls.Add(Me.LabelControl73)
        Me.tabTaxiE3.Controls.Add(Me.txtMinutosEsperaTaxiE3)
        Me.tabTaxiE3.Controls.Add(Me.LabelControl74)
        Me.tabTaxiE3.Controls.Add(Me.txtCuadrasTaxiE3)
        Me.tabTaxiE3.Controls.Add(Me.txtTarifaMontoTaxiE3)
        Me.tabTaxiE3.Controls.Add(Me.txtMinutosTaxiE3)
        Me.tabTaxiE3.Controls.Add(Me.LabelControl75)
        Me.tabTaxiE3.Controls.Add(Me.LabelControl76)
        Me.tabTaxiE3.Controls.Add(Me.lkpLugarBajadaTaxiE3)
        Me.tabTaxiE3.Name = "tabTaxiE3"
        Me.tabTaxiE3.Size = New System.Drawing.Size(993, 177)
        Me.tabTaxiE3.Text = "XtraTabPage3"
        '
        'LabelControl71
        '
        Me.LabelControl71.Location = New System.Drawing.Point(2, 6)
        Me.LabelControl71.Name = "LabelControl71"
        Me.LabelControl71.Size = New System.Drawing.Size(419, 13)
        Me.LabelControl71.TabIndex = 96
        Me.LabelControl71.Text = "¿Cuánto caminó antes de tomar este taxi, radiotaxi o aplicación (uber, cabify o s" &
    "imilar)?"
        '
        'LabelControl77
        '
        Me.LabelControl77.Location = New System.Drawing.Point(444, 6)
        Me.LabelControl77.Name = "LabelControl77"
        Me.LabelControl77.Size = New System.Drawing.Size(419, 13)
        Me.LabelControl77.TabIndex = 97
        Me.LabelControl77.Text = "¿Cuánto rato esperó para abordar el taxi, radiotaxi o aplicación (uber, cabify o " &
    "similar)?"
        '
        'LabelControl217
        '
        Me.LabelControl217.Location = New System.Drawing.Point(69, 76)
        Me.LabelControl217.Name = "LabelControl217"
        Me.LabelControl217.Size = New System.Drawing.Size(65, 13)
        Me.LabelControl217.TabIndex = 95
        Me.LabelControl217.Text = "(NS/NR = 99)"
        '
        'LabelControl72
        '
        Me.LabelControl72.Location = New System.Drawing.Point(49, 28)
        Me.LabelControl72.Name = "LabelControl72"
        Me.LabelControl72.Size = New System.Drawing.Size(38, 13)
        Me.LabelControl72.TabIndex = 51
        Me.LabelControl72.Text = "cuadras"
        '
        'LabelControl73
        '
        Me.LabelControl73.Location = New System.Drawing.Point(161, 28)
        Me.LabelControl73.Name = "LabelControl73"
        Me.LabelControl73.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl73.TabIndex = 52
        Me.LabelControl73.Text = "minutos"
        '
        'txtMinutosEsperaTaxiE3
        '
        Me.txtMinutosEsperaTaxiE3.Location = New System.Drawing.Point(444, 25)
        Me.txtMinutosEsperaTaxiE3.Name = "txtMinutosEsperaTaxiE3"
        Me.txtMinutosEsperaTaxiE3.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.txtMinutosEsperaTaxiE3.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.txtMinutosEsperaTaxiE3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtMinutosEsperaTaxiE3.Properties.Mask.EditMask = "n0"
        Me.txtMinutosEsperaTaxiE3.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtMinutosEsperaTaxiE3.Size = New System.Drawing.Size(40, 20)
        Me.txtMinutosEsperaTaxiE3.TabIndex = 53
        '
        'LabelControl74
        '
        Me.LabelControl74.Location = New System.Drawing.Point(3, 54)
        Me.LabelControl74.Name = "LabelControl74"
        Me.LabelControl74.Size = New System.Drawing.Size(118, 13)
        Me.LabelControl74.TabIndex = 65
        Me.LabelControl74.Text = "¿Cuánto pagó en pesos?"
        '
        'txtCuadrasTaxiE3
        '
        Me.txtCuadrasTaxiE3.Location = New System.Drawing.Point(2, 24)
        Me.txtCuadrasTaxiE3.Name = "txtCuadrasTaxiE3"
        Me.txtCuadrasTaxiE3.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.txtCuadrasTaxiE3.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.txtCuadrasTaxiE3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtCuadrasTaxiE3.Properties.Mask.EditMask = "n0"
        Me.txtCuadrasTaxiE3.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtCuadrasTaxiE3.Size = New System.Drawing.Size(40, 20)
        Me.txtCuadrasTaxiE3.TabIndex = 51
        '
        'txtTarifaMontoTaxiE3
        '
        Me.txtTarifaMontoTaxiE3.Location = New System.Drawing.Point(3, 73)
        Me.txtTarifaMontoTaxiE3.Name = "txtTarifaMontoTaxiE3"
        Me.txtTarifaMontoTaxiE3.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.txtTarifaMontoTaxiE3.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.txtTarifaMontoTaxiE3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtTarifaMontoTaxiE3.Properties.Mask.EditMask = "c0"
        Me.txtTarifaMontoTaxiE3.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTarifaMontoTaxiE3.Size = New System.Drawing.Size(60, 20)
        Me.txtTarifaMontoTaxiE3.TabIndex = 54
        '
        'txtMinutosTaxiE3
        '
        Me.txtMinutosTaxiE3.Location = New System.Drawing.Point(115, 24)
        Me.txtMinutosTaxiE3.Name = "txtMinutosTaxiE3"
        Me.txtMinutosTaxiE3.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.txtMinutosTaxiE3.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.txtMinutosTaxiE3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtMinutosTaxiE3.Properties.Mask.EditMask = "n0"
        Me.txtMinutosTaxiE3.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtMinutosTaxiE3.Size = New System.Drawing.Size(40, 20)
        Me.txtMinutosTaxiE3.TabIndex = 52
        '
        'LabelControl75
        '
        Me.LabelControl75.Location = New System.Drawing.Point(501, 28)
        Me.LabelControl75.Name = "LabelControl75"
        Me.LabelControl75.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl75.TabIndex = 56
        Me.LabelControl75.Text = "minutos"
        '
        'LabelControl76
        '
        Me.LabelControl76.Location = New System.Drawing.Point(156, 54)
        Me.LabelControl76.Name = "LabelControl76"
        Me.LabelControl76.Size = New System.Drawing.Size(79, 13)
        Me.LabelControl76.TabIndex = 67
        Me.LabelControl76.Text = "¿Dónde se bajó?"
        '
        'lkpLugarBajadaTaxiE3
        '
        Me.lkpLugarBajadaTaxiE3.EditValue = ""
        Me.lkpLugarBajadaTaxiE3.Location = New System.Drawing.Point(156, 73)
        Me.lkpLugarBajadaTaxiE3.Name = "lkpLugarBajadaTaxiE3"
        Me.lkpLugarBajadaTaxiE3.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.lkpLugarBajadaTaxiE3.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.lkpLugarBajadaTaxiE3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lkpLugarBajadaTaxiE3.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkpLugarBajadaTaxiE3.Properties.DataSource = Me.DondeSeBajoE3BindingSource
        Me.lkpLugarBajadaTaxiE3.Properties.DisplayMember = "DondeSeBajo"
        Me.lkpLugarBajadaTaxiE3.Properties.ImmediatePopup = True
        Me.lkpLugarBajadaTaxiE3.Properties.PopupFormMinSize = New System.Drawing.Size(163, 40)
        Me.lkpLugarBajadaTaxiE3.Properties.PopupFormSize = New System.Drawing.Size(163, 40)
        Me.lkpLugarBajadaTaxiE3.Properties.ShowFooter = False
        Me.lkpLugarBajadaTaxiE3.Properties.ValueMember = "Id"
        Me.lkpLugarBajadaTaxiE3.Properties.View = Me.GridView38
        Me.lkpLugarBajadaTaxiE3.Size = New System.Drawing.Size(163, 20)
        Me.lkpLugarBajadaTaxiE3.TabIndex = 55
        '
        'DondeSeBajoE3BindingSource
        '
        Me.DondeSeBajoE3BindingSource.DataMember = "DondeSeBajo"
        Me.DondeSeBajoE3BindingSource.DataSource = Me.datasetEOD
        '
        'GridView38
        '
        Me.GridView38.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn37, Me.GridColumn38})
        Me.GridView38.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView38.Name = "GridView38"
        Me.GridView38.OptionsCustomization.AllowFilter = False
        Me.GridView38.OptionsCustomization.AllowGroup = False
        Me.GridView38.OptionsCustomization.AllowSort = False
        Me.GridView38.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView38.OptionsView.ShowColumnHeaders = False
        Me.GridView38.OptionsView.ShowGroupPanel = False
        Me.GridView38.OptionsView.ShowIndicator = False
        '
        'GridColumn37
        '
        Me.GridColumn37.FieldName = "Id"
        Me.GridColumn37.Name = "GridColumn37"
        '
        'GridColumn38
        '
        Me.GridColumn38.FieldName = "DondeSeBajo"
        Me.GridColumn38.Name = "GridColumn38"
        Me.GridColumn38.OptionsColumn.AllowEdit = False
        Me.GridColumn38.Visible = True
        Me.GridColumn38.VisibleIndex = 0
        '
        'tabAutoE3
        '
        Me.tabAutoE3.Controls.Add(Me.LabelControl101)
        Me.tabAutoE3.Controls.Add(Me.PanelControl2)
        Me.tabAutoE3.Controls.Add(Me.lkpVehHogarE3)
        Me.tabAutoE3.Controls.Add(Me.LabelControl107)
        Me.tabAutoE3.Controls.Add(Me.LabelControl108)
        Me.tabAutoE3.Controls.Add(Me.txtMinutosAutoE3)
        Me.tabAutoE3.Controls.Add(Me.txtCuadrasAutoE3)
        Me.tabAutoE3.Controls.Add(Me.LabelControl109)
        Me.tabAutoE3.Controls.Add(Me.LabelControl110)
        Me.tabAutoE3.Controls.Add(Me.LabelControl111)
        Me.tabAutoE3.Controls.Add(Me.lkpViajaComoE3)
        Me.tabAutoE3.Controls.Add(Me.lkpQueVehiculoE3)
        Me.tabAutoE3.Name = "tabAutoE3"
        Me.tabAutoE3.Size = New System.Drawing.Size(993, 177)
        Me.tabAutoE3.Text = "XtraTabPage4"
        '
        'LabelControl101
        '
        Me.LabelControl101.Location = New System.Drawing.Point(569, 3)
        Me.LabelControl101.Name = "LabelControl101"
        Me.LabelControl101.Size = New System.Drawing.Size(87, 13)
        Me.LabelControl101.TabIndex = 10
        Me.LabelControl101.Text = "Vehiculo del hogar"
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.spcPagoBajadaAutoE3)
        Me.PanelControl2.Location = New System.Drawing.Point(2, 48)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(976, 54)
        Me.PanelControl2.TabIndex = 93
        '
        'spcPagoBajadaAutoE3
        '
        Me.spcPagoBajadaAutoE3.CollapsePanel = DevExpress.XtraEditors.SplitCollapsePanel.Panel1
        Me.spcPagoBajadaAutoE3.Location = New System.Drawing.Point(0, 0)
        Me.spcPagoBajadaAutoE3.Name = "spcPagoBajadaAutoE3"
        Me.spcPagoBajadaAutoE3.Panel1.Controls.Add(Me.spcPagoEstacionamientoE3)
        Me.spcPagoBajadaAutoE3.Panel1.Text = "Panel1"
        Me.spcPagoBajadaAutoE3.Panel2.Controls.Add(Me.LabelControl81)
        Me.spcPagoBajadaAutoE3.Panel2.Controls.Add(Me.lkpLugarBajadaAutoE3)
        Me.spcPagoBajadaAutoE3.Panel2.Text = "Panel2"
        Me.spcPagoBajadaAutoE3.Size = New System.Drawing.Size(954, 54)
        Me.spcPagoBajadaAutoE3.SplitterPosition = 612
        Me.spcPagoBajadaAutoE3.TabIndex = 95
        Me.spcPagoBajadaAutoE3.Text = "SplitContainerControl1"
        '
        'spcPagoEstacionamientoE3
        '
        Me.spcPagoEstacionamientoE3.CollapsePanel = DevExpress.XtraEditors.SplitCollapsePanel.Panel2
        Me.spcPagoEstacionamientoE3.Location = New System.Drawing.Point(1, 0)
        Me.spcPagoEstacionamientoE3.Name = "spcPagoEstacionamientoE3"
        Me.spcPagoEstacionamientoE3.Panel1.Controls.Add(Me.chkNSNRPagoE3)
        Me.spcPagoEstacionamientoE3.Panel1.Controls.Add(Me.txtCuantoPagoE3)
        Me.spcPagoEstacionamientoE3.Panel1.Controls.Add(Me.LabelControl80)
        Me.spcPagoEstacionamientoE3.Panel1.Text = "Panel1"
        Me.spcPagoEstacionamientoE3.Panel2.Controls.Add(Me.spcFormaPagoE3)
        Me.spcPagoEstacionamientoE3.Panel2.Text = "Panel2"
        Me.spcPagoEstacionamientoE3.Size = New System.Drawing.Size(610, 54)
        Me.spcPagoEstacionamientoE3.SplitterPosition = 213
        Me.spcPagoEstacionamientoE3.TabIndex = 94
        Me.spcPagoEstacionamientoE3.Text = "SplitContainerControl2"
        '
        'chkNSNRPagoE3
        '
        Me.chkNSNRPagoE3.Location = New System.Drawing.Point(88, 25)
        Me.chkNSNRPagoE3.MenuManager = Me.TabFormDefaultManager1
        Me.chkNSNRPagoE3.Name = "chkNSNRPagoE3"
        Me.chkNSNRPagoE3.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.chkNSNRPagoE3.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.chkNSNRPagoE3.Properties.Caption = "No sabe/no responde"
        Me.chkNSNRPagoE3.Size = New System.Drawing.Size(126, 19)
        Me.chkNSNRPagoE3.TabIndex = 33
        '
        'txtCuantoPagoE3
        '
        Me.txtCuantoPagoE3.Location = New System.Drawing.Point(1, 25)
        Me.txtCuantoPagoE3.Name = "txtCuantoPagoE3"
        Me.txtCuantoPagoE3.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.txtCuantoPagoE3.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.txtCuantoPagoE3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtCuantoPagoE3.Properties.Mask.EditMask = "c0"
        Me.txtCuantoPagoE3.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtCuantoPagoE3.Size = New System.Drawing.Size(76, 20)
        Me.txtCuantoPagoE3.TabIndex = 32
        '
        'LabelControl80
        '
        Me.LabelControl80.Location = New System.Drawing.Point(1, 6)
        Me.LabelControl80.Name = "LabelControl80"
        Me.LabelControl80.Size = New System.Drawing.Size(144, 13)
        Me.LabelControl80.TabIndex = 6
        Me.LabelControl80.Text = "¿Cuánto pagó por estacionar?"
        '
        'spcFormaPagoE3
        '
        Me.spcFormaPagoE3.Collapsed = True
        Me.spcFormaPagoE3.CollapsePanel = DevExpress.XtraEditors.SplitCollapsePanel.Panel1
        Me.spcFormaPagoE3.Location = New System.Drawing.Point(8, 6)
        Me.spcFormaPagoE3.Name = "spcFormaPagoE3"
        Me.spcFormaPagoE3.Panel1.Controls.Add(Me.LabelControl56)
        Me.spcFormaPagoE3.Panel1.Controls.Add(Me.lkpFormaPagoE3)
        Me.spcFormaPagoE3.Panel1.Text = "Panel1"
        Me.spcFormaPagoE3.Panel2.Controls.Add(Me.lkpDondeEstacionaE3)
        Me.spcFormaPagoE3.Panel2.Controls.Add(Me.LabelControl78)
        Me.spcFormaPagoE3.Panel2.Text = "Panel2"
        Me.spcFormaPagoE3.Size = New System.Drawing.Size(368, 48)
        Me.spcFormaPagoE3.SplitterPosition = 156
        Me.spcFormaPagoE3.TabIndex = 97
        Me.spcFormaPagoE3.Text = "SplitContainerControl2"
        '
        'LabelControl56
        '
        Me.LabelControl56.Location = New System.Drawing.Point(6, 3)
        Me.LabelControl56.Name = "LabelControl56"
        Me.LabelControl56.Size = New System.Drawing.Size(72, 13)
        Me.LabelControl56.TabIndex = 4
        Me.LabelControl56.Text = "¿Este pago es?"
        '
        'lkpFormaPagoE3
        '
        Me.lkpFormaPagoE3.EditValue = ""
        Me.lkpFormaPagoE3.Location = New System.Drawing.Point(3, 19)
        Me.lkpFormaPagoE3.Name = "lkpFormaPagoE3"
        Me.lkpFormaPagoE3.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.lkpFormaPagoE3.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.lkpFormaPagoE3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lkpFormaPagoE3.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkpFormaPagoE3.Properties.DataSource = Me.FormaPagoBindingSource
        Me.lkpFormaPagoE3.Properties.DisplayMember = "FormaPago"
        Me.lkpFormaPagoE3.Properties.ImmediatePopup = True
        Me.lkpFormaPagoE3.Properties.PopupFormMinSize = New System.Drawing.Size(147, 160)
        Me.lkpFormaPagoE3.Properties.PopupFormSize = New System.Drawing.Size(147, 160)
        Me.lkpFormaPagoE3.Properties.ShowFooter = False
        Me.lkpFormaPagoE3.Properties.ValueMember = "ID"
        Me.lkpFormaPagoE3.Properties.View = Me.GridView56
        Me.lkpFormaPagoE3.Size = New System.Drawing.Size(147, 20)
        Me.lkpFormaPagoE3.TabIndex = 34
        '
        'GridView56
        '
        Me.GridView56.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn39, Me.GridColumn40})
        Me.GridView56.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView56.Name = "GridView56"
        Me.GridView56.OptionsCustomization.AllowFilter = False
        Me.GridView56.OptionsCustomization.AllowGroup = False
        Me.GridView56.OptionsCustomization.AllowSort = False
        Me.GridView56.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView56.OptionsView.ShowColumnHeaders = False
        Me.GridView56.OptionsView.ShowGroupPanel = False
        Me.GridView56.OptionsView.ShowIndicator = False
        '
        'GridColumn39
        '
        Me.GridColumn39.FieldName = "ID"
        Me.GridColumn39.Name = "GridColumn39"
        '
        'GridColumn40
        '
        Me.GridColumn40.FieldName = "FormaPago"
        Me.GridColumn40.Name = "GridColumn40"
        Me.GridColumn40.Visible = True
        Me.GridColumn40.VisibleIndex = 0
        '
        'lkpDondeEstacionaE3
        '
        Me.lkpDondeEstacionaE3.EditValue = ""
        Me.lkpDondeEstacionaE3.Location = New System.Drawing.Point(3, 21)
        Me.lkpDondeEstacionaE3.Name = "lkpDondeEstacionaE3"
        Me.lkpDondeEstacionaE3.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.lkpDondeEstacionaE3.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.lkpDondeEstacionaE3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lkpDondeEstacionaE3.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkpDondeEstacionaE3.Properties.DataSource = Me.DondeEstacionaBindingSource
        Me.lkpDondeEstacionaE3.Properties.DisplayMember = "DondeEstaciona"
        Me.lkpDondeEstacionaE3.Properties.ImmediatePopup = True
        Me.lkpDondeEstacionaE3.Properties.PopupFormMinSize = New System.Drawing.Size(186, 80)
        Me.lkpDondeEstacionaE3.Properties.PopupFormSize = New System.Drawing.Size(186, 80)
        Me.lkpDondeEstacionaE3.Properties.ShowFooter = False
        Me.lkpDondeEstacionaE3.Properties.ValueMember = "ID"
        Me.lkpDondeEstacionaE3.Properties.View = Me.GridView55
        Me.lkpDondeEstacionaE3.Size = New System.Drawing.Size(186, 20)
        Me.lkpDondeEstacionaE3.TabIndex = 35
        '
        'GridView55
        '
        Me.GridView55.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn58, Me.GridColumn78})
        Me.GridView55.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView55.Name = "GridView55"
        Me.GridView55.OptionsCustomization.AllowFilter = False
        Me.GridView55.OptionsCustomization.AllowGroup = False
        Me.GridView55.OptionsCustomization.AllowSort = False
        Me.GridView55.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView55.OptionsView.ShowColumnHeaders = False
        Me.GridView55.OptionsView.ShowGroupPanel = False
        Me.GridView55.OptionsView.ShowIndicator = False
        Me.GridView55.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.GridColumn58, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.GridColumn78, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'GridColumn58
        '
        Me.GridColumn58.FieldName = "ID"
        Me.GridColumn58.Name = "GridColumn58"
        '
        'GridColumn78
        '
        Me.GridColumn78.FieldName = "DondeEstaciona"
        Me.GridColumn78.Name = "GridColumn78"
        Me.GridColumn78.Visible = True
        Me.GridColumn78.VisibleIndex = 0
        '
        'LabelControl78
        '
        Me.LabelControl78.Location = New System.Drawing.Point(3, 3)
        Me.LabelControl78.Name = "LabelControl78"
        Me.LabelControl78.Size = New System.Drawing.Size(90, 13)
        Me.LabelControl78.TabIndex = 5
        Me.LabelControl78.Text = "¿Dónde estacionó?"
        '
        'LabelControl81
        '
        Me.LabelControl81.Location = New System.Drawing.Point(6, 6)
        Me.LabelControl81.Name = "LabelControl81"
        Me.LabelControl81.Size = New System.Drawing.Size(167, 13)
        Me.LabelControl81.TabIndex = 12
        Me.LabelControl81.Text = "¿En qué lugar se bajó del vehículo?"
        '
        'lkpLugarBajadaAutoE3
        '
        Me.lkpLugarBajadaAutoE3.EditValue = ""
        Me.lkpLugarBajadaAutoE3.Location = New System.Drawing.Point(6, 25)
        Me.lkpLugarBajadaAutoE3.Name = "lkpLugarBajadaAutoE3"
        Me.lkpLugarBajadaAutoE3.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.lkpLugarBajadaAutoE3.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.lkpLugarBajadaAutoE3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lkpLugarBajadaAutoE3.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkpLugarBajadaAutoE3.Properties.DataSource = Me.DondeSeBajoE3BindingSource
        Me.lkpLugarBajadaAutoE3.Properties.DisplayMember = "DondeSeBajo"
        Me.lkpLugarBajadaAutoE3.Properties.ImmediatePopup = True
        Me.lkpLugarBajadaAutoE3.Properties.PopupFormMinSize = New System.Drawing.Size(167, 40)
        Me.lkpLugarBajadaAutoE3.Properties.PopupFormSize = New System.Drawing.Size(167, 40)
        Me.lkpLugarBajadaAutoE3.Properties.ShowFooter = False
        Me.lkpLugarBajadaAutoE3.Properties.ValueMember = "Id"
        Me.lkpLugarBajadaAutoE3.Properties.View = Me.GridView57
        Me.lkpLugarBajadaAutoE3.Size = New System.Drawing.Size(167, 20)
        Me.lkpLugarBajadaAutoE3.TabIndex = 35
        '
        'GridView57
        '
        Me.GridView57.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn41, Me.GridColumn42})
        Me.GridView57.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView57.Name = "GridView57"
        Me.GridView57.OptionsCustomization.AllowFilter = False
        Me.GridView57.OptionsCustomization.AllowGroup = False
        Me.GridView57.OptionsCustomization.AllowSort = False
        Me.GridView57.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView57.OptionsView.ShowColumnHeaders = False
        Me.GridView57.OptionsView.ShowGroupPanel = False
        Me.GridView57.OptionsView.ShowIndicator = False
        '
        'GridColumn41
        '
        Me.GridColumn41.FieldName = "Id"
        Me.GridColumn41.Name = "GridColumn41"
        '
        'GridColumn42
        '
        Me.GridColumn42.FieldName = "DondeSeBajo"
        Me.GridColumn42.Name = "GridColumn42"
        Me.GridColumn42.Visible = True
        Me.GridColumn42.VisibleIndex = 0
        '
        'lkpVehHogarE3
        '
        Me.lkpVehHogarE3.EditValue = ""
        Me.lkpVehHogarE3.Location = New System.Drawing.Point(569, 22)
        Me.lkpVehHogarE3.Name = "lkpVehHogarE3"
        Me.lkpVehHogarE3.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.lkpVehHogarE3.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.lkpVehHogarE3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lkpVehHogarE3.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkpVehHogarE3.Properties.DataSource = Me.ResumenVehiculosBindingSource
        Me.lkpVehHogarE3.Properties.DisplayMember = "vehiculo"
        Me.lkpVehHogarE3.Properties.ImmediatePopup = True
        Me.lkpVehHogarE3.Properties.PopupFormMinSize = New System.Drawing.Size(330, 20)
        Me.lkpVehHogarE3.Properties.PopupFormSize = New System.Drawing.Size(330, 100)
        Me.lkpVehHogarE3.Properties.ShowFooter = False
        Me.lkpVehHogarE3.Properties.ValueMember = "Vehículo"
        Me.lkpVehHogarE3.Properties.View = Me.GridView58
        Me.lkpVehHogarE3.Size = New System.Drawing.Size(330, 20)
        Me.lkpVehHogarE3.TabIndex = 29
        '
        'GridView58
        '
        Me.GridView58.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn43, Me.colCombustible2})
        Me.GridView58.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView58.Name = "GridView58"
        Me.GridView58.OptionsCustomization.AllowFilter = False
        Me.GridView58.OptionsCustomization.AllowGroup = False
        Me.GridView58.OptionsCustomization.AllowSort = False
        Me.GridView58.OptionsMenu.EnableColumnMenu = False
        Me.GridView58.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView58.OptionsView.ShowGroupPanel = False
        '
        'GridColumn43
        '
        Me.GridColumn43.Caption = "Tipo"
        Me.GridColumn43.FieldName = "vehiculo"
        Me.GridColumn43.Name = "GridColumn43"
        Me.GridColumn43.OptionsColumn.AllowEdit = False
        Me.GridColumn43.Visible = True
        Me.GridColumn43.VisibleIndex = 0
        '
        'colCombustible2
        '
        Me.colCombustible2.FieldName = "Combustible"
        Me.colCombustible2.Name = "colCombustible2"
        Me.colCombustible2.Visible = True
        Me.colCombustible2.VisibleIndex = 1
        '
        'LabelControl107
        '
        Me.LabelControl107.Location = New System.Drawing.Point(445, 3)
        Me.LabelControl107.Name = "LabelControl107"
        Me.LabelControl107.Size = New System.Drawing.Size(102, 13)
        Me.LabelControl107.TabIndex = 22
        Me.LabelControl107.Text = "¿Qué vehículo utilizó?"
        '
        'LabelControl108
        '
        Me.LabelControl108.Location = New System.Drawing.Point(238, 3)
        Me.LabelControl108.Name = "LabelControl108"
        Me.LabelControl108.Size = New System.Drawing.Size(194, 13)
        Me.LabelControl108.TabIndex = 20
        Me.LabelControl108.Text = "¿Viajó como conductor o como pasajero?"
        '
        'txtMinutosAutoE3
        '
        Me.txtMinutosAutoE3.Location = New System.Drawing.Point(115, 22)
        Me.txtMinutosAutoE3.Name = "txtMinutosAutoE3"
        Me.txtMinutosAutoE3.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.txtMinutosAutoE3.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.txtMinutosAutoE3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtMinutosAutoE3.Properties.Mask.EditMask = "n0"
        Me.txtMinutosAutoE3.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtMinutosAutoE3.Size = New System.Drawing.Size(40, 20)
        Me.txtMinutosAutoE3.TabIndex = 26
        '
        'txtCuadrasAutoE3
        '
        Me.txtCuadrasAutoE3.Location = New System.Drawing.Point(3, 22)
        Me.txtCuadrasAutoE3.Name = "txtCuadrasAutoE3"
        Me.txtCuadrasAutoE3.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.txtCuadrasAutoE3.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.txtCuadrasAutoE3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtCuadrasAutoE3.Properties.Mask.EditMask = "n0"
        Me.txtCuadrasAutoE3.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtCuadrasAutoE3.Size = New System.Drawing.Size(40, 20)
        Me.txtCuadrasAutoE3.TabIndex = 25
        '
        'LabelControl109
        '
        Me.LabelControl109.Location = New System.Drawing.Point(161, 22)
        Me.LabelControl109.Name = "LabelControl109"
        Me.LabelControl109.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl109.TabIndex = 17
        Me.LabelControl109.Text = "minutos"
        '
        'LabelControl110
        '
        Me.LabelControl110.Location = New System.Drawing.Point(49, 22)
        Me.LabelControl110.Name = "LabelControl110"
        Me.LabelControl110.Size = New System.Drawing.Size(38, 13)
        Me.LabelControl110.TabIndex = 16
        Me.LabelControl110.Text = "cuadras"
        '
        'LabelControl111
        '
        Me.LabelControl111.Location = New System.Drawing.Point(3, 3)
        Me.LabelControl111.Name = "LabelControl111"
        Me.LabelControl111.Size = New System.Drawing.Size(223, 13)
        Me.LabelControl111.TabIndex = 15
        Me.LabelControl111.Text = "¿Cuánto caminó antes de tomar este vehículo?"
        '
        'lkpViajaComoE3
        '
        Me.lkpViajaComoE3.EditValue = ""
        Me.lkpViajaComoE3.Location = New System.Drawing.Point(238, 22)
        Me.lkpViajaComoE3.Name = "lkpViajaComoE3"
        Me.lkpViajaComoE3.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.lkpViajaComoE3.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.lkpViajaComoE3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lkpViajaComoE3.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkpViajaComoE3.Properties.DataSource = Me.ViajaComoBindingSource
        Me.lkpViajaComoE3.Properties.DisplayMember = "ViajaComo"
        Me.lkpViajaComoE3.Properties.ImmediatePopup = True
        Me.lkpViajaComoE3.Properties.PopupFormMinSize = New System.Drawing.Size(100, 40)
        Me.lkpViajaComoE3.Properties.PopupFormSize = New System.Drawing.Size(100, 40)
        Me.lkpViajaComoE3.Properties.ShowFooter = False
        Me.lkpViajaComoE3.Properties.ValueMember = "Id"
        Me.lkpViajaComoE3.Properties.View = Me.GridView60
        Me.lkpViajaComoE3.Size = New System.Drawing.Size(100, 20)
        Me.lkpViajaComoE3.TabIndex = 27
        '
        'GridView60
        '
        Me.GridView60.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn46, Me.GridColumn47})
        Me.GridView60.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView60.Name = "GridView60"
        Me.GridView60.OptionsCustomization.AllowFilter = False
        Me.GridView60.OptionsCustomization.AllowGroup = False
        Me.GridView60.OptionsCustomization.AllowSort = False
        Me.GridView60.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView60.OptionsView.ShowColumnHeaders = False
        Me.GridView60.OptionsView.ShowGroupPanel = False
        Me.GridView60.OptionsView.ShowIndicator = False
        '
        'GridColumn46
        '
        Me.GridColumn46.FieldName = "Id"
        Me.GridColumn46.Name = "GridColumn46"
        '
        'GridColumn47
        '
        Me.GridColumn47.FieldName = "ViajaComo"
        Me.GridColumn47.Name = "GridColumn47"
        Me.GridColumn47.Visible = True
        Me.GridColumn47.VisibleIndex = 0
        '
        'lkpQueVehiculoE3
        '
        Me.lkpQueVehiculoE3.EditValue = ""
        Me.lkpQueVehiculoE3.Location = New System.Drawing.Point(445, 22)
        Me.lkpQueVehiculoE3.Name = "lkpQueVehiculoE3"
        Me.lkpQueVehiculoE3.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.lkpQueVehiculoE3.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.lkpQueVehiculoE3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lkpQueVehiculoE3.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkpQueVehiculoE3.Properties.DataSource = Me.QueVehiculoBindingSource
        Me.lkpQueVehiculoE3.Properties.DisplayMember = "QueVehiculo"
        Me.lkpQueVehiculoE3.Properties.ImmediatePopup = True
        Me.lkpQueVehiculoE3.Properties.PopupFormMinSize = New System.Drawing.Size(100, 40)
        Me.lkpQueVehiculoE3.Properties.PopupFormSize = New System.Drawing.Size(100, 40)
        Me.lkpQueVehiculoE3.Properties.ShowFooter = False
        Me.lkpQueVehiculoE3.Properties.ValueMember = "Id"
        Me.lkpQueVehiculoE3.Properties.View = Me.GridView63
        Me.lkpQueVehiculoE3.Size = New System.Drawing.Size(102, 20)
        Me.lkpQueVehiculoE3.TabIndex = 28
        '
        'GridView63
        '
        Me.GridView63.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn48, Me.GridColumn63})
        Me.GridView63.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView63.Name = "GridView63"
        Me.GridView63.OptionsCustomization.AllowFilter = False
        Me.GridView63.OptionsCustomization.AllowGroup = False
        Me.GridView63.OptionsCustomization.AllowSort = False
        Me.GridView63.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView63.OptionsView.ShowColumnHeaders = False
        Me.GridView63.OptionsView.ShowGroupPanel = False
        Me.GridView63.OptionsView.ShowIndicator = False
        '
        'GridColumn48
        '
        Me.GridColumn48.FieldName = "Id"
        Me.GridColumn48.Name = "GridColumn48"
        '
        'GridColumn63
        '
        Me.GridColumn63.FieldName = "QueVehiculo"
        Me.GridColumn63.Name = "GridColumn63"
        Me.GridColumn63.Visible = True
        Me.GridColumn63.VisibleIndex = 0
        '
        'tabBicicletaE3
        '
        Me.tabBicicletaE3.Controls.Add(Me.spcPropiedadBicicletaE3)
        Me.tabBicicletaE3.Controls.Add(Me.LabelControl141)
        Me.tabBicicletaE3.Controls.Add(Me.LabelControl140)
        Me.tabBicicletaE3.Controls.Add(Me.lkpPropiedadBicicletaE3)
        Me.tabBicicletaE3.Controls.Add(Me.lkpLugarBajadaBiciE3)
        Me.tabBicicletaE3.Name = "tabBicicletaE3"
        Me.tabBicicletaE3.Size = New System.Drawing.Size(993, 177)
        Me.tabBicicletaE3.Text = "XtraTabPage5"
        '
        'spcPropiedadBicicletaE3
        '
        Me.spcPropiedadBicicletaE3.CollapsePanel = DevExpress.XtraEditors.SplitCollapsePanel.Panel1
        Me.spcPropiedadBicicletaE3.Location = New System.Drawing.Point(203, 3)
        Me.spcPropiedadBicicletaE3.Name = "spcPropiedadBicicletaE3"
        Me.spcPropiedadBicicletaE3.Panel1.Controls.Add(Me.txtPropiedadBicicletaOtraE3)
        Me.spcPropiedadBicicletaE3.Panel1.Controls.Add(Me.lblPropiedadBiciOtraE3)
        Me.spcPropiedadBicicletaE3.Panel1.Text = "Panel1"
        Me.spcPropiedadBicicletaE3.Panel2.Controls.Add(Me.spcMotivoNoUsaE3)
        Me.spcPropiedadBicicletaE3.Panel2.Controls.Add(Me.LabelControl18)
        Me.spcPropiedadBicicletaE3.Panel2.Controls.Add(Me.lkpCicloviaE3)
        Me.spcPropiedadBicicletaE3.Panel2.Text = "Panel2"
        Me.spcPropiedadBicicletaE3.Size = New System.Drawing.Size(784, 54)
        Me.spcPropiedadBicicletaE3.SplitterPosition = 121
        Me.spcPropiedadBicicletaE3.TabIndex = 37
        Me.spcPropiedadBicicletaE3.Text = "SplitContainerControl5"
        '
        'txtPropiedadBicicletaOtraE3
        '
        Me.txtPropiedadBicicletaOtraE3.Location = New System.Drawing.Point(3, 19)
        Me.txtPropiedadBicicletaOtraE3.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.txtPropiedadBicicletaOtraE3.Name = "txtPropiedadBicicletaOtraE3"
        Me.txtPropiedadBicicletaOtraE3.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.txtPropiedadBicicletaOtraE3.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.txtPropiedadBicicletaOtraE3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtPropiedadBicicletaOtraE3.Size = New System.Drawing.Size(106, 20)
        Me.txtPropiedadBicicletaOtraE3.TabIndex = 38
        Me.txtPropiedadBicicletaOtraE3.Visible = False
        '
        'lblPropiedadBiciOtraE3
        '
        Me.lblPropiedadBiciOtraE3.Location = New System.Drawing.Point(0, 0)
        Me.lblPropiedadBiciOtraE3.Name = "lblPropiedadBiciOtraE3"
        Me.lblPropiedadBiciOtraE3.Size = New System.Drawing.Size(64, 13)
        Me.lblPropiedadBiciOtraE3.TabIndex = 40
        Me.lblPropiedadBiciOtraE3.Text = "Otra (indicar)"
        Me.lblPropiedadBiciOtraE3.Visible = False
        '
        'spcMotivoNoUsaE3
        '
        Me.spcMotivoNoUsaE3.CollapsePanel = DevExpress.XtraEditors.SplitCollapsePanel.Panel1
        Me.spcMotivoNoUsaE3.Location = New System.Drawing.Point(190, 0)
        Me.spcMotivoNoUsaE3.Name = "spcMotivoNoUsaE3"
        Me.spcMotivoNoUsaE3.Panel1.Controls.Add(Me.txtMotivoNoUsaE3)
        Me.spcMotivoNoUsaE3.Panel1.Controls.Add(Me.LabelControl126)
        Me.spcMotivoNoUsaE3.Panel1.Text = "Panel1"
        Me.spcMotivoNoUsaE3.Panel2.Controls.Add(Me.lkpEstacionamientoBiciE3)
        Me.spcMotivoNoUsaE3.Panel2.Controls.Add(Me.LabelControl127)
        Me.spcMotivoNoUsaE3.Panel2.Text = "Panel2"
        Me.spcMotivoNoUsaE3.Size = New System.Drawing.Size(570, 44)
        Me.spcMotivoNoUsaE3.SplitterPosition = 136
        Me.spcMotivoNoUsaE3.TabIndex = 47
        Me.spcMotivoNoUsaE3.Text = "SplitContainerControl2"
        '
        'txtMotivoNoUsaE3
        '
        Me.txtMotivoNoUsaE3.Location = New System.Drawing.Point(0, 17)
        Me.txtMotivoNoUsaE3.Name = "txtMotivoNoUsaE3"
        Me.txtMotivoNoUsaE3.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.txtMotivoNoUsaE3.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.txtMotivoNoUsaE3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtMotivoNoUsaE3.Size = New System.Drawing.Size(131, 20)
        Me.txtMotivoNoUsaE3.TabIndex = 40
        '
        'LabelControl126
        '
        Me.LabelControl126.Location = New System.Drawing.Point(0, 0)
        Me.LabelControl126.Name = "LabelControl126"
        Me.LabelControl126.Size = New System.Drawing.Size(91, 13)
        Me.LabelControl126.TabIndex = 39
        Me.LabelControl126.Text = "¿Por qué? (Indicar)"
        '
        'lkpEstacionamientoBiciE3
        '
        Me.lkpEstacionamientoBiciE3.EditValue = ""
        Me.lkpEstacionamientoBiciE3.Location = New System.Drawing.Point(11, 17)
        Me.lkpEstacionamientoBiciE3.Name = "lkpEstacionamientoBiciE3"
        Me.lkpEstacionamientoBiciE3.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.lkpEstacionamientoBiciE3.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.lkpEstacionamientoBiciE3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lkpEstacionamientoBiciE3.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkpEstacionamientoBiciE3.Properties.DataSource = Me.EstacionamientoBicicletaBindingSource
        Me.lkpEstacionamientoBiciE3.Properties.DisplayMember = "EstacionamientoBicicleta"
        Me.lkpEstacionamientoBiciE3.Properties.ImmediatePopup = True
        Me.lkpEstacionamientoBiciE3.Properties.PopupFormMinSize = New System.Drawing.Size(167, 40)
        Me.lkpEstacionamientoBiciE3.Properties.PopupFormSize = New System.Drawing.Size(167, 40)
        Me.lkpEstacionamientoBiciE3.Properties.ShowFooter = False
        Me.lkpEstacionamientoBiciE3.Properties.ValueMember = "ID"
        Me.lkpEstacionamientoBiciE3.Properties.View = Me.GridView69
        Me.lkpEstacionamientoBiciE3.Size = New System.Drawing.Size(249, 20)
        Me.lkpEstacionamientoBiciE3.TabIndex = 41
        '
        'GridView69
        '
        Me.GridView69.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn94, Me.GridColumn95})
        Me.GridView69.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView69.Name = "GridView69"
        Me.GridView69.OptionsCustomization.AllowFilter = False
        Me.GridView69.OptionsCustomization.AllowGroup = False
        Me.GridView69.OptionsCustomization.AllowSort = False
        Me.GridView69.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView69.OptionsView.ShowColumnHeaders = False
        Me.GridView69.OptionsView.ShowGroupPanel = False
        Me.GridView69.OptionsView.ShowIndicator = False
        '
        'GridColumn94
        '
        Me.GridColumn94.FieldName = "ID"
        Me.GridColumn94.Name = "GridColumn94"
        '
        'GridColumn95
        '
        Me.GridColumn95.FieldName = "EstacionamientoBicicleta"
        Me.GridColumn95.Name = "GridColumn95"
        Me.GridColumn95.Visible = True
        Me.GridColumn95.VisibleIndex = 0
        '
        'LabelControl127
        '
        Me.LabelControl127.Location = New System.Drawing.Point(11, -2)
        Me.LabelControl127.Name = "LabelControl127"
        Me.LabelControl127.Size = New System.Drawing.Size(145, 13)
        Me.LabelControl127.TabIndex = 41
        Me.LabelControl127.Text = "¿Dónde estacionó su bicicleta?"
        '
        'LabelControl18
        '
        Me.LabelControl18.Location = New System.Drawing.Point(5, 0)
        Me.LabelControl18.Name = "LabelControl18"
        Me.LabelControl18.Size = New System.Drawing.Size(173, 13)
        Me.LabelControl18.TabIndex = 40
        Me.LabelControl18.Text = "¿Usó alguna ciclovía en su trayecto?"
        '
        'lkpCicloviaE3
        '
        Me.lkpCicloviaE3.EditValue = ""
        Me.lkpCicloviaE3.Location = New System.Drawing.Point(5, 19)
        Me.lkpCicloviaE3.Name = "lkpCicloviaE3"
        Me.lkpCicloviaE3.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.lkpCicloviaE3.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.lkpCicloviaE3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lkpCicloviaE3.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkpCicloviaE3.Properties.DataSource = Me.SiNoBindingSource
        Me.lkpCicloviaE3.Properties.DisplayMember = "Opcion"
        Me.lkpCicloviaE3.Properties.ImmediatePopup = True
        Me.lkpCicloviaE3.Properties.PopupFormMinSize = New System.Drawing.Size(81, 40)
        Me.lkpCicloviaE3.Properties.PopupFormSize = New System.Drawing.Size(81, 40)
        Me.lkpCicloviaE3.Properties.ShowFooter = False
        Me.lkpCicloviaE3.Properties.ValueMember = "Id"
        Me.lkpCicloviaE3.Properties.View = Me.GridView23
        Me.lkpCicloviaE3.Size = New System.Drawing.Size(81, 20)
        Me.lkpCicloviaE3.TabIndex = 39
        '
        'GridView23
        '
        Me.GridView23.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn19, Me.GridColumn20})
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
        'GridColumn19
        '
        Me.GridColumn19.FieldName = "Id"
        Me.GridColumn19.Name = "GridColumn19"
        '
        'GridColumn20
        '
        Me.GridColumn20.FieldName = "Opcion"
        Me.GridColumn20.Name = "GridColumn20"
        Me.GridColumn20.Visible = True
        Me.GridColumn20.VisibleIndex = 0
        '
        'LabelControl141
        '
        Me.LabelControl141.Location = New System.Drawing.Point(2, 3)
        Me.LabelControl141.Name = "LabelControl141"
        Me.LabelControl141.Size = New System.Drawing.Size(182, 13)
        Me.LabelControl141.TabIndex = 35
        Me.LabelControl141.Text = "¿La bicicleta que usó en este viaje es?"
        '
        'LabelControl140
        '
        Me.LabelControl140.Location = New System.Drawing.Point(2, 54)
        Me.LabelControl140.Name = "LabelControl140"
        Me.LabelControl140.Size = New System.Drawing.Size(79, 13)
        Me.LabelControl140.TabIndex = 38
        Me.LabelControl140.Text = "¿Dónde se bajó?"
        '
        'lkpPropiedadBicicletaE3
        '
        Me.lkpPropiedadBicicletaE3.EditValue = ""
        Me.lkpPropiedadBicicletaE3.Location = New System.Drawing.Point(2, 22)
        Me.lkpPropiedadBicicletaE3.Name = "lkpPropiedadBicicletaE3"
        Me.lkpPropiedadBicicletaE3.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.lkpPropiedadBicicletaE3.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.lkpPropiedadBicicletaE3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lkpPropiedadBicicletaE3.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkpPropiedadBicicletaE3.Properties.DataSource = Me.PropiedadBicicletaBindingSource
        Me.lkpPropiedadBicicletaE3.Properties.DisplayMember = "PropiedadBicicleta"
        Me.lkpPropiedadBicicletaE3.Properties.ImmediatePopup = True
        Me.lkpPropiedadBicicletaE3.Properties.PopupFormMinSize = New System.Drawing.Size(132, 60)
        Me.lkpPropiedadBicicletaE3.Properties.PopupFormSize = New System.Drawing.Size(132, 60)
        Me.lkpPropiedadBicicletaE3.Properties.ShowFooter = False
        Me.lkpPropiedadBicicletaE3.Properties.ValueMember = "ID"
        Me.lkpPropiedadBicicletaE3.Properties.View = Me.GridView65
        Me.lkpPropiedadBicicletaE3.Size = New System.Drawing.Size(132, 20)
        Me.lkpPropiedadBicicletaE3.TabIndex = 36
        '
        'GridView65
        '
        Me.GridView65.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn66, Me.GridColumn67})
        Me.GridView65.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView65.Name = "GridView65"
        Me.GridView65.OptionsCustomization.AllowFilter = False
        Me.GridView65.OptionsCustomization.AllowGroup = False
        Me.GridView65.OptionsCustomization.AllowSort = False
        Me.GridView65.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView65.OptionsView.ShowColumnHeaders = False
        Me.GridView65.OptionsView.ShowGroupPanel = False
        Me.GridView65.OptionsView.ShowIndicator = False
        '
        'GridColumn66
        '
        Me.GridColumn66.FieldName = "ID"
        Me.GridColumn66.Name = "GridColumn66"
        '
        'GridColumn67
        '
        Me.GridColumn67.FieldName = "PropiedadBicicleta"
        Me.GridColumn67.Name = "GridColumn67"
        Me.GridColumn67.Visible = True
        Me.GridColumn67.VisibleIndex = 0
        '
        'lkpLugarBajadaBiciE3
        '
        Me.lkpLugarBajadaBiciE3.EditValue = ""
        Me.lkpLugarBajadaBiciE3.Location = New System.Drawing.Point(2, 73)
        Me.lkpLugarBajadaBiciE3.Name = "lkpLugarBajadaBiciE3"
        Me.lkpLugarBajadaBiciE3.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.lkpLugarBajadaBiciE3.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.lkpLugarBajadaBiciE3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lkpLugarBajadaBiciE3.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkpLugarBajadaBiciE3.Properties.DataSource = Me.DondeSeBajoE3BindingSource
        Me.lkpLugarBajadaBiciE3.Properties.DisplayMember = "DondeSeBajo"
        Me.lkpLugarBajadaBiciE3.Properties.ImmediatePopup = True
        Me.lkpLugarBajadaBiciE3.Properties.PopupFormMinSize = New System.Drawing.Size(167, 40)
        Me.lkpLugarBajadaBiciE3.Properties.PopupFormSize = New System.Drawing.Size(167, 40)
        Me.lkpLugarBajadaBiciE3.Properties.ShowFooter = False
        Me.lkpLugarBajadaBiciE3.Properties.ValueMember = "Id"
        Me.lkpLugarBajadaBiciE3.Properties.View = Me.GridView54
        Me.lkpLugarBajadaBiciE3.Size = New System.Drawing.Size(167, 20)
        Me.lkpLugarBajadaBiciE3.TabIndex = 45
        '
        'GridView54
        '
        Me.GridView54.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn35, Me.GridColumn36})
        Me.GridView54.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView54.Name = "GridView54"
        Me.GridView54.OptionsCustomization.AllowFilter = False
        Me.GridView54.OptionsCustomization.AllowGroup = False
        Me.GridView54.OptionsCustomization.AllowSort = False
        Me.GridView54.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView54.OptionsView.ShowColumnHeaders = False
        Me.GridView54.OptionsView.ShowGroupPanel = False
        Me.GridView54.OptionsView.ShowIndicator = False
        '
        'GridColumn35
        '
        Me.GridColumn35.FieldName = "Id"
        Me.GridColumn35.Name = "GridColumn35"
        '
        'GridColumn36
        '
        Me.GridColumn36.FieldName = "DondeSeBajo"
        Me.GridColumn36.Name = "GridColumn36"
        Me.GridColumn36.Visible = True
        Me.GridColumn36.VisibleIndex = 0
        '
        'tabBusE3
        '
        Me.tabBusE3.Controls.Add(Me.txtMinutosEsperaBusE3)
        Me.tabBusE3.Controls.Add(Me.spcCuantoPagoBusE3)
        Me.tabBusE3.Controls.Add(Me.LabelControl144)
        Me.tabBusE3.Controls.Add(Me.LabelControl149)
        Me.tabBusE3.Controls.Add(Me.LabelControl150)
        Me.tabBusE3.Controls.Add(Me.txtMinutosBusE3)
        Me.tabBusE3.Controls.Add(Me.txtCuadrasBusE3)
        Me.tabBusE3.Controls.Add(Me.LabelControl151)
        Me.tabBusE3.Controls.Add(Me.LabelControl152)
        Me.tabBusE3.Controls.Add(Me.LabelControl153)
        Me.tabBusE3.Controls.Add(Me.lkpTipoTarifaBusE3)
        Me.tabBusE3.Name = "tabBusE3"
        Me.tabBusE3.Size = New System.Drawing.Size(993, 177)
        Me.tabBusE3.Text = "XtraTabPage6"
        '
        'txtMinutosEsperaBusE3
        '
        Me.txtMinutosEsperaBusE3.Location = New System.Drawing.Point(243, 22)
        Me.txtMinutosEsperaBusE3.Name = "txtMinutosEsperaBusE3"
        Me.txtMinutosEsperaBusE3.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.txtMinutosEsperaBusE3.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.txtMinutosEsperaBusE3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtMinutosEsperaBusE3.Properties.Mask.EditMask = "n0"
        Me.txtMinutosEsperaBusE3.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtMinutosEsperaBusE3.Size = New System.Drawing.Size(40, 20)
        Me.txtMinutosEsperaBusE3.TabIndex = 43
        '
        'spcCuantoPagoBusE3
        '
        Me.spcCuantoPagoBusE3.CollapsePanel = DevExpress.XtraEditors.SplitCollapsePanel.Panel1
        Me.spcCuantoPagoBusE3.Location = New System.Drawing.Point(640, -1)
        Me.spcCuantoPagoBusE3.Name = "spcCuantoPagoBusE3"
        Me.spcCuantoPagoBusE3.Panel1.Controls.Add(Me.LabelControl221)
        Me.spcCuantoPagoBusE3.Panel1.Controls.Add(Me.txtTarifaMontoBusE3)
        Me.spcCuantoPagoBusE3.Panel1.Controls.Add(Me.LabelControl142)
        Me.spcCuantoPagoBusE3.Panel1.Text = "Panel1"
        Me.spcCuantoPagoBusE3.Panel2.Controls.Add(Me.LabelControl143)
        Me.spcCuantoPagoBusE3.Panel2.Controls.Add(Me.lkpLugarBajadaBusE3)
        Me.spcCuantoPagoBusE3.Panel2.Text = "Panel2"
        Me.spcCuantoPagoBusE3.Size = New System.Drawing.Size(341, 48)
        Me.spcCuantoPagoBusE3.SplitterPosition = 148
        Me.spcCuantoPagoBusE3.TabIndex = 90
        Me.spcCuantoPagoBusE3.Text = "SplitContainerControl5"
        '
        'LabelControl221
        '
        Me.LabelControl221.Location = New System.Drawing.Point(69, 26)
        Me.LabelControl221.Name = "LabelControl221"
        Me.LabelControl221.Size = New System.Drawing.Size(65, 13)
        Me.LabelControl221.TabIndex = 95
        Me.LabelControl221.Text = "(NS/NR = 99)"
        '
        'txtTarifaMontoBusE3
        '
        Me.txtTarifaMontoBusE3.Location = New System.Drawing.Point(3, 23)
        Me.txtTarifaMontoBusE3.Name = "txtTarifaMontoBusE3"
        Me.txtTarifaMontoBusE3.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.txtTarifaMontoBusE3.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.txtTarifaMontoBusE3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtTarifaMontoBusE3.Properties.Mask.EditMask = "c0"
        Me.txtTarifaMontoBusE3.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTarifaMontoBusE3.Size = New System.Drawing.Size(60, 20)
        Me.txtTarifaMontoBusE3.TabIndex = 49
        '
        'LabelControl142
        '
        Me.LabelControl142.Location = New System.Drawing.Point(3, 4)
        Me.LabelControl142.Name = "LabelControl142"
        Me.LabelControl142.Size = New System.Drawing.Size(118, 13)
        Me.LabelControl142.TabIndex = 25
        Me.LabelControl142.Text = "¿Cuanto pagó en pesos?"
        '
        'LabelControl143
        '
        Me.LabelControl143.Location = New System.Drawing.Point(6, 5)
        Me.LabelControl143.Name = "LabelControl143"
        Me.LabelControl143.Size = New System.Drawing.Size(79, 13)
        Me.LabelControl143.TabIndex = 0
        Me.LabelControl143.Text = "¿Dónde se bajó?"
        '
        'lkpLugarBajadaBusE3
        '
        Me.lkpLugarBajadaBusE3.EditValue = ""
        Me.lkpLugarBajadaBusE3.Location = New System.Drawing.Point(6, 24)
        Me.lkpLugarBajadaBusE3.Name = "lkpLugarBajadaBusE3"
        Me.lkpLugarBajadaBusE3.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.lkpLugarBajadaBusE3.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.lkpLugarBajadaBusE3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lkpLugarBajadaBusE3.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkpLugarBajadaBusE3.Properties.DataSource = Me.DondeSeBajoE3BindingSource
        Me.lkpLugarBajadaBusE3.Properties.DisplayMember = "DondeSeBajo"
        Me.lkpLugarBajadaBusE3.Properties.ImmediatePopup = True
        Me.lkpLugarBajadaBusE3.Properties.PopupFormMinSize = New System.Drawing.Size(161, 40)
        Me.lkpLugarBajadaBusE3.Properties.PopupFormSize = New System.Drawing.Size(161, 40)
        Me.lkpLugarBajadaBusE3.Properties.ShowFooter = False
        Me.lkpLugarBajadaBusE3.Properties.ValueMember = "Id"
        Me.lkpLugarBajadaBusE3.Properties.View = Me.GridView66
        Me.lkpLugarBajadaBusE3.Size = New System.Drawing.Size(161, 20)
        Me.lkpLugarBajadaBusE3.TabIndex = 50
        '
        'GridView66
        '
        Me.GridView66.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn68, Me.GridColumn69})
        Me.GridView66.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView66.Name = "GridView66"
        Me.GridView66.OptionsCustomization.AllowFilter = False
        Me.GridView66.OptionsCustomization.AllowGroup = False
        Me.GridView66.OptionsCustomization.AllowSort = False
        Me.GridView66.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView66.OptionsView.ShowColumnHeaders = False
        Me.GridView66.OptionsView.ShowGroupPanel = False
        Me.GridView66.OptionsView.ShowIndicator = False
        '
        'GridColumn68
        '
        Me.GridColumn68.FieldName = "Id"
        Me.GridColumn68.Name = "GridColumn68"
        Me.GridColumn68.OptionsColumn.AllowEdit = False
        '
        'GridColumn69
        '
        Me.GridColumn69.FieldName = "DondeSeBajo"
        Me.GridColumn69.Name = "GridColumn69"
        Me.GridColumn69.Visible = True
        Me.GridColumn69.VisibleIndex = 0
        '
        'LabelControl144
        '
        Me.LabelControl144.Location = New System.Drawing.Point(497, 3)
        Me.LabelControl144.Name = "LabelControl144"
        Me.LabelControl144.Size = New System.Drawing.Size(86, 13)
        Me.LabelControl144.TabIndex = 40
        Me.LabelControl144.Text = "¿Qué tarifa pagó?"
        '
        'LabelControl149
        '
        Me.LabelControl149.Location = New System.Drawing.Point(289, 25)
        Me.LabelControl149.Name = "LabelControl149"
        Me.LabelControl149.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl149.TabIndex = 31
        Me.LabelControl149.Text = "minutos"
        '
        'LabelControl150
        '
        Me.LabelControl150.Location = New System.Drawing.Point(243, 3)
        Me.LabelControl150.Name = "LabelControl150"
        Me.LabelControl150.Size = New System.Drawing.Size(235, 13)
        Me.LabelControl150.TabIndex = 30
        Me.LabelControl150.Text = "¿Cuánto rato esperó para abordar el transporte?"
        '
        'txtMinutosBusE3
        '
        Me.txtMinutosBusE3.Location = New System.Drawing.Point(115, 22)
        Me.txtMinutosBusE3.Name = "txtMinutosBusE3"
        Me.txtMinutosBusE3.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.txtMinutosBusE3.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.txtMinutosBusE3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtMinutosBusE3.Properties.Mask.EditMask = "n0"
        Me.txtMinutosBusE3.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtMinutosBusE3.Size = New System.Drawing.Size(40, 20)
        Me.txtMinutosBusE3.TabIndex = 42
        '
        'txtCuadrasBusE3
        '
        Me.txtCuadrasBusE3.Location = New System.Drawing.Point(3, 22)
        Me.txtCuadrasBusE3.Name = "txtCuadrasBusE3"
        Me.txtCuadrasBusE3.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.txtCuadrasBusE3.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.txtCuadrasBusE3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtCuadrasBusE3.Properties.Mask.EditMask = "n0"
        Me.txtCuadrasBusE3.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtCuadrasBusE3.Size = New System.Drawing.Size(40, 20)
        Me.txtCuadrasBusE3.TabIndex = 41
        '
        'LabelControl151
        '
        Me.LabelControl151.Location = New System.Drawing.Point(161, 26)
        Me.LabelControl151.Name = "LabelControl151"
        Me.LabelControl151.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl151.TabIndex = 27
        Me.LabelControl151.Text = "minutos"
        '
        'LabelControl152
        '
        Me.LabelControl152.Location = New System.Drawing.Point(49, 26)
        Me.LabelControl152.Name = "LabelControl152"
        Me.LabelControl152.Size = New System.Drawing.Size(38, 13)
        Me.LabelControl152.TabIndex = 26
        Me.LabelControl152.Text = "cuadras"
        '
        'LabelControl153
        '
        Me.LabelControl153.Location = New System.Drawing.Point(3, 3)
        Me.LabelControl153.Name = "LabelControl153"
        Me.LabelControl153.Size = New System.Drawing.Size(210, 13)
        Me.LabelControl153.TabIndex = 25
        Me.LabelControl153.Text = "¿Cuánto caminó antes de tomar este modo?"
        '
        'lkpTipoTarifaBusE3
        '
        Me.lkpTipoTarifaBusE3.EditValue = ""
        Me.lkpTipoTarifaBusE3.Location = New System.Drawing.Point(497, 22)
        Me.lkpTipoTarifaBusE3.Name = "lkpTipoTarifaBusE3"
        Me.lkpTipoTarifaBusE3.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.lkpTipoTarifaBusE3.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.lkpTipoTarifaBusE3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lkpTipoTarifaBusE3.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkpTipoTarifaBusE3.Properties.DataSource = Me.TipoTarifaBindingSource
        Me.lkpTipoTarifaBusE3.Properties.DisplayMember = "TipoTarifaBus"
        Me.lkpTipoTarifaBusE3.Properties.ImmediatePopup = True
        Me.lkpTipoTarifaBusE3.Properties.PopupFormMinSize = New System.Drawing.Size(123, 100)
        Me.lkpTipoTarifaBusE3.Properties.PopupFormSize = New System.Drawing.Size(123, 100)
        Me.lkpTipoTarifaBusE3.Properties.ShowFooter = False
        Me.lkpTipoTarifaBusE3.Properties.ValueMember = "ID"
        Me.lkpTipoTarifaBusE3.Properties.View = Me.GridView67
        Me.lkpTipoTarifaBusE3.Size = New System.Drawing.Size(123, 20)
        Me.lkpTipoTarifaBusE3.TabIndex = 48
        '
        'GridView67
        '
        Me.GridView67.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn70, Me.GridColumn71})
        Me.GridView67.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView67.Name = "GridView67"
        Me.GridView67.OptionsCustomization.AllowFilter = False
        Me.GridView67.OptionsCustomization.AllowGroup = False
        Me.GridView67.OptionsCustomization.AllowSort = False
        Me.GridView67.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView67.OptionsView.ShowColumnHeaders = False
        Me.GridView67.OptionsView.ShowGroupPanel = False
        Me.GridView67.OptionsView.ShowIndicator = False
        '
        'GridColumn70
        '
        Me.GridColumn70.FieldName = "ID"
        Me.GridColumn70.Name = "GridColumn70"
        '
        'GridColumn71
        '
        Me.GridColumn71.FieldName = "TipoTarifaBus"
        Me.GridColumn71.Name = "GridColumn71"
        Me.GridColumn71.OptionsColumn.AllowEdit = False
        Me.GridColumn71.Visible = True
        Me.GridColumn71.VisibleIndex = 0
        '
        'tabTXCE3
        '
        Me.tabTXCE3.Controls.Add(Me.LabelControl219)
        Me.tabTXCE3.Controls.Add(Me.LabelControl165)
        Me.tabTXCE3.Controls.Add(Me.txtTarifaMontoTXCE3)
        Me.tabTXCE3.Controls.Add(Me.txtMinutosEsperaTXCE3)
        Me.tabTXCE3.Controls.Add(Me.LabelControl166)
        Me.tabTXCE3.Controls.Add(Me.LabelControl167)
        Me.tabTXCE3.Controls.Add(Me.LabelControl168)
        Me.tabTXCE3.Controls.Add(Me.txtMinutosTXCE3)
        Me.tabTXCE3.Controls.Add(Me.txtCuadrasTXCE3)
        Me.tabTXCE3.Controls.Add(Me.LabelControl169)
        Me.tabTXCE3.Controls.Add(Me.LabelControl170)
        Me.tabTXCE3.Controls.Add(Me.LabelControl171)
        Me.tabTXCE3.Controls.Add(Me.lkpLugarBajadaTXCE3)
        Me.tabTXCE3.Name = "tabTXCE3"
        Me.tabTXCE3.Size = New System.Drawing.Size(993, 177)
        Me.tabTXCE3.Text = "XtraTabPage10"
        '
        'LabelControl219
        '
        Me.LabelControl219.Location = New System.Drawing.Point(613, 24)
        Me.LabelControl219.Name = "LabelControl219"
        Me.LabelControl219.Size = New System.Drawing.Size(65, 13)
        Me.LabelControl219.TabIndex = 95
        Me.LabelControl219.Text = "(NS/NR = 99)"
        '
        'LabelControl165
        '
        Me.LabelControl165.Location = New System.Drawing.Point(691, 2)
        Me.LabelControl165.Name = "LabelControl165"
        Me.LabelControl165.Size = New System.Drawing.Size(79, 13)
        Me.LabelControl165.TabIndex = 67
        Me.LabelControl165.Text = "¿Dónde se bajó?"
        '
        'txtTarifaMontoTXCE3
        '
        Me.txtTarifaMontoTXCE3.Location = New System.Drawing.Point(547, 21)
        Me.txtTarifaMontoTXCE3.Name = "txtTarifaMontoTXCE3"
        Me.txtTarifaMontoTXCE3.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.txtTarifaMontoTXCE3.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.txtTarifaMontoTXCE3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtTarifaMontoTXCE3.Properties.Mask.EditMask = "c0"
        Me.txtTarifaMontoTXCE3.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTarifaMontoTXCE3.Size = New System.Drawing.Size(60, 20)
        Me.txtTarifaMontoTXCE3.TabIndex = 54
        '
        'txtMinutosEsperaTXCE3
        '
        Me.txtMinutosEsperaTXCE3.Location = New System.Drawing.Point(274, 22)
        Me.txtMinutosEsperaTXCE3.Name = "txtMinutosEsperaTXCE3"
        Me.txtMinutosEsperaTXCE3.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.txtMinutosEsperaTXCE3.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.txtMinutosEsperaTXCE3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtMinutosEsperaTXCE3.Properties.Mask.EditMask = "n0"
        Me.txtMinutosEsperaTXCE3.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtMinutosEsperaTXCE3.Size = New System.Drawing.Size(40, 20)
        Me.txtMinutosEsperaTXCE3.TabIndex = 53
        '
        'LabelControl166
        '
        Me.LabelControl166.Location = New System.Drawing.Point(547, 3)
        Me.LabelControl166.Name = "LabelControl166"
        Me.LabelControl166.Size = New System.Drawing.Size(118, 13)
        Me.LabelControl166.TabIndex = 65
        Me.LabelControl166.Text = "¿Cuánto pagó en pesos?"
        '
        'LabelControl167
        '
        Me.LabelControl167.Location = New System.Drawing.Point(320, 25)
        Me.LabelControl167.Name = "LabelControl167"
        Me.LabelControl167.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl167.TabIndex = 56
        Me.LabelControl167.Text = "minutos"
        '
        'LabelControl168
        '
        Me.LabelControl168.Location = New System.Drawing.Point(274, 3)
        Me.LabelControl168.Name = "LabelControl168"
        Me.LabelControl168.Size = New System.Drawing.Size(235, 13)
        Me.LabelControl168.TabIndex = 55
        Me.LabelControl168.Text = "¿Cuánto rato esperó para abordar el transporte?"
        '
        'txtMinutosTXCE3
        '
        Me.txtMinutosTXCE3.Location = New System.Drawing.Point(115, 22)
        Me.txtMinutosTXCE3.Name = "txtMinutosTXCE3"
        Me.txtMinutosTXCE3.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.txtMinutosTXCE3.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.txtMinutosTXCE3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtMinutosTXCE3.Properties.Mask.EditMask = "n0"
        Me.txtMinutosTXCE3.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtMinutosTXCE3.Size = New System.Drawing.Size(40, 20)
        Me.txtMinutosTXCE3.TabIndex = 52
        '
        'txtCuadrasTXCE3
        '
        Me.txtCuadrasTXCE3.Location = New System.Drawing.Point(3, 22)
        Me.txtCuadrasTXCE3.Name = "txtCuadrasTXCE3"
        Me.txtCuadrasTXCE3.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.txtCuadrasTXCE3.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.txtCuadrasTXCE3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtCuadrasTXCE3.Properties.Mask.EditMask = "n0"
        Me.txtCuadrasTXCE3.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtCuadrasTXCE3.Size = New System.Drawing.Size(40, 20)
        Me.txtCuadrasTXCE3.TabIndex = 51
        '
        'LabelControl169
        '
        Me.LabelControl169.Location = New System.Drawing.Point(161, 26)
        Me.LabelControl169.Name = "LabelControl169"
        Me.LabelControl169.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl169.TabIndex = 52
        Me.LabelControl169.Text = "minutos"
        '
        'LabelControl170
        '
        Me.LabelControl170.Location = New System.Drawing.Point(49, 26)
        Me.LabelControl170.Name = "LabelControl170"
        Me.LabelControl170.Size = New System.Drawing.Size(38, 13)
        Me.LabelControl170.TabIndex = 51
        Me.LabelControl170.Text = "cuadras"
        '
        'LabelControl171
        '
        Me.LabelControl171.Location = New System.Drawing.Point(3, 3)
        Me.LabelControl171.Name = "LabelControl171"
        Me.LabelControl171.Size = New System.Drawing.Size(247, 13)
        Me.LabelControl171.TabIndex = 49
        Me.LabelControl171.Text = "¿Cuánto caminó antes de tomar este taxi colectivo?"
        '
        'lkpLugarBajadaTXCE3
        '
        Me.lkpLugarBajadaTXCE3.EditValue = ""
        Me.lkpLugarBajadaTXCE3.Location = New System.Drawing.Point(691, 21)
        Me.lkpLugarBajadaTXCE3.Name = "lkpLugarBajadaTXCE3"
        Me.lkpLugarBajadaTXCE3.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.lkpLugarBajadaTXCE3.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.lkpLugarBajadaTXCE3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lkpLugarBajadaTXCE3.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkpLugarBajadaTXCE3.Properties.DataSource = Me.DondeSeBajoE3BindingSource
        Me.lkpLugarBajadaTXCE3.Properties.DisplayMember = "DondeSeBajo"
        Me.lkpLugarBajadaTXCE3.Properties.PopupFormMinSize = New System.Drawing.Size(168, 40)
        Me.lkpLugarBajadaTXCE3.Properties.PopupFormSize = New System.Drawing.Size(168, 40)
        Me.lkpLugarBajadaTXCE3.Properties.ShowFooter = False
        Me.lkpLugarBajadaTXCE3.Properties.ValueMember = "Id"
        Me.lkpLugarBajadaTXCE3.Properties.View = Me.GridView68
        Me.lkpLugarBajadaTXCE3.Size = New System.Drawing.Size(168, 20)
        Me.lkpLugarBajadaTXCE3.TabIndex = 55
        '
        'GridView68
        '
        Me.GridView68.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn72, Me.GridColumn73})
        Me.GridView68.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView68.Name = "GridView68"
        Me.GridView68.OptionsCustomization.AllowFilter = False
        Me.GridView68.OptionsCustomization.AllowGroup = False
        Me.GridView68.OptionsCustomization.AllowSort = False
        Me.GridView68.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView68.OptionsView.ShowColumnHeaders = False
        Me.GridView68.OptionsView.ShowGroupPanel = False
        Me.GridView68.OptionsView.ShowIndicator = False
        '
        'GridColumn72
        '
        Me.GridColumn72.FieldName = "Id"
        Me.GridColumn72.Name = "GridColumn72"
        '
        'GridColumn73
        '
        Me.GridColumn73.FieldName = "DondeSeBajo"
        Me.GridColumn73.Name = "GridColumn73"
        Me.GridColumn73.OptionsColumn.AllowEdit = False
        Me.GridColumn73.Visible = True
        Me.GridColumn73.VisibleIndex = 0
        '
        'PagaEstacionamientoBindingSource
        '
        Me.PagaEstacionamientoBindingSource.DataMember = "PagaEstacionamiento"
        Me.PagaEstacionamientoBindingSource.DataSource = Me.datasetEOD
        '
        'MuelleBajadaBindingSource
        '
        Me.MuelleBajadaBindingSource.DataMember = "Muelle"
        Me.MuelleBajadaBindingSource.DataSource = Me.datasetEOD
        '
        'MuelleBindingSource
        '
        Me.MuelleBindingSource.DataMember = "Muelle"
        Me.MuelleBindingSource.DataSource = Me.datasetEOD
        '
        'MetrotrenBindingSource
        '
        Me.MetrotrenBindingSource.DataMember = "Metrotren"
        Me.MetrotrenBindingSource.DataSource = Me.datasetEOD
        '
        'TerrasurBindingSource
        '
        Me.TerrasurBindingSource.DataMember = "Terrasur"
        Me.TerrasurBindingSource.DataSource = Me.datasetEOD
        '
        'lkpProposito
        '
        Me.lkpProposito.EditValue = ""
        Me.lkpProposito.Location = New System.Drawing.Point(117, 28)
        Me.lkpProposito.Name = "lkpProposito"
        Me.lkpProposito.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.lkpProposito.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.lkpProposito.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lkpProposito.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkpProposito.Properties.DataSource = Me.PropositoBindingSource
        Me.lkpProposito.Properties.DisplayMember = "Proposito"
        Me.lkpProposito.Properties.ImmediatePopup = True
        Me.lkpProposito.Properties.PopupFormMinSize = New System.Drawing.Size(153, 180)
        Me.lkpProposito.Properties.PopupFormSize = New System.Drawing.Size(153, 180)
        Me.lkpProposito.Properties.ShowFooter = False
        Me.lkpProposito.Properties.ValueMember = "ID"
        Me.lkpProposito.Properties.View = Me.GridView9
        Me.lkpProposito.Size = New System.Drawing.Size(153, 20)
        Me.lkpProposito.TabIndex = 13
        '
        'PropositoBindingSource
        '
        Me.PropositoBindingSource.DataMember = "Proposito"
        Me.PropositoBindingSource.DataSource = Me.datasetEOD
        Me.PropositoBindingSource.Filter = "id > 0"
        '
        'GridView9
        '
        Me.GridView9.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID5, Me.colProposito})
        Me.GridView9.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView9.Name = "GridView9"
        Me.GridView9.OptionsCustomization.AllowFilter = False
        Me.GridView9.OptionsCustomization.AllowGroup = False
        Me.GridView9.OptionsCustomization.AllowSort = False
        Me.GridView9.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView9.OptionsView.ShowColumnHeaders = False
        Me.GridView9.OptionsView.ShowGroupPanel = False
        Me.GridView9.OptionsView.ShowIndicator = False
        '
        'colID5
        '
        Me.colID5.FieldName = "ID"
        Me.colID5.Name = "colID5"
        '
        'colProposito
        '
        Me.colProposito.FieldName = "Proposito"
        Me.colProposito.Name = "colProposito"
        Me.colProposito.OptionsColumn.AllowEdit = False
        Me.colProposito.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colProposito.Visible = True
        Me.colProposito.VisibleIndex = 0
        '
        'tmHoraSalida
        '
        Me.tmHoraSalida.EditValue = New Date(2016, 5, 23, 0, 0, 0, 0)
        Me.tmHoraSalida.Location = New System.Drawing.Point(0, 28)
        Me.tmHoraSalida.Name = "tmHoraSalida"
        Me.tmHoraSalida.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.tmHoraSalida.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.tmHoraSalida.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.tmHoraSalida.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.tmHoraSalida.Properties.EditValueChangedDelay = 700
        Me.tmHoraSalida.Properties.Mask.EditMask = "t"
        Me.tmHoraSalida.Size = New System.Drawing.Size(87, 20)
        Me.tmHoraSalida.TabIndex = 12
        '
        'LabelControl12
        '
        Me.LabelControl12.Location = New System.Drawing.Point(0, 9)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(87, 13)
        Me.LabelControl12.TabIndex = 9
        Me.LabelControl12.Text = "¿A qué hora salió?"
        '
        'LabelControl11
        '
        Me.LabelControl11.Location = New System.Drawing.Point(116, 9)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(88, 13)
        Me.LabelControl11.TabIndex = 8
        Me.LabelControl11.Text = "¿Qué fue a hacer?"
        '
        'spDestinoViaje
        '
        Me.spDestinoViaje.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.spDestinoViaje.Appearance.Options.UseBackColor = True
        Me.spDestinoViaje.CollapsePanel = DevExpress.XtraEditors.SplitCollapsePanel.Panel1
        Me.spDestinoViaje.Location = New System.Drawing.Point(291, 3)
        Me.spDestinoViaje.Name = "spDestinoViaje"
        Me.spDestinoViaje.Panel1.Controls.Add(Me.txtOtroProposito)
        Me.spDestinoViaje.Panel1.Controls.Add(Me.lblOtroProposito)
        Me.spDestinoViaje.Panel1.Text = "Panel1"
        Me.spDestinoViaje.Panel2.Controls.Add(Me.spLugarDeclarado)
        Me.spDestinoViaje.Panel2.Text = "Panel2"
        Me.spDestinoViaje.Size = New System.Drawing.Size(687, 48)
        Me.spDestinoViaje.SplitterPosition = 104
        Me.spDestinoViaje.TabIndex = 14
        Me.spDestinoViaje.Text = "SplitContainerControl10"
        '
        'txtOtroProposito
        '
        Me.txtOtroProposito.Location = New System.Drawing.Point(3, 26)
        Me.txtOtroProposito.Name = "txtOtroProposito"
        Me.txtOtroProposito.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.txtOtroProposito.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.txtOtroProposito.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtOtroProposito.Size = New System.Drawing.Size(100, 20)
        Me.txtOtroProposito.TabIndex = 14
        '
        'lblOtroProposito
        '
        Me.lblOtroProposito.Location = New System.Drawing.Point(4, 7)
        Me.lblOtroProposito.Name = "lblOtroProposito"
        Me.lblOtroProposito.Size = New System.Drawing.Size(70, 13)
        Me.lblOtroProposito.TabIndex = 15
        Me.lblOtroProposito.Text = "Otro propósito"
        '
        'spLugarDeclarado
        '
        Me.spLugarDeclarado.Collapsed = True
        Me.spLugarDeclarado.CollapsePanel = DevExpress.XtraEditors.SplitCollapsePanel.Panel2
        Me.spLugarDeclarado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.spLugarDeclarado.Location = New System.Drawing.Point(0, 0)
        Me.spLugarDeclarado.Name = "spLugarDeclarado"
        Me.spLugarDeclarado.Panel1.Controls.Add(Me.lkpTrabajoDeclarado)
        Me.spLugarDeclarado.Panel1.Controls.Add(Me.lblTrabajoDeclarado)
        Me.spLugarDeclarado.Panel1.Text = "Panel1"
        Me.spLugarDeclarado.Panel2.Controls.Add(Me.lkpEstudioDeclarado)
        Me.spLugarDeclarado.Panel2.Controls.Add(Me.lblEstudioDeclarado)
        Me.spLugarDeclarado.Panel2.Text = "Panel2"
        Me.spLugarDeclarado.Size = New System.Drawing.Size(571, 48)
        Me.spLugarDeclarado.SplitterPosition = 213
        Me.spLugarDeclarado.TabIndex = 14
        Me.spLugarDeclarado.Text = "SplitContainerControl3"
        '
        'lkpTrabajoDeclarado
        '
        Me.lkpTrabajoDeclarado.EditValue = ""
        Me.lkpTrabajoDeclarado.Location = New System.Drawing.Point(13, 25)
        Me.lkpTrabajoDeclarado.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.lkpTrabajoDeclarado.Name = "lkpTrabajoDeclarado"
        Me.lkpTrabajoDeclarado.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.lkpTrabajoDeclarado.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.lkpTrabajoDeclarado.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit
        Me.lkpTrabajoDeclarado.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lkpTrabajoDeclarado.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkpTrabajoDeclarado.Properties.DataSource = Me.SiNoBindingSource
        Me.lkpTrabajoDeclarado.Properties.DisplayMember = "Opcion"
        Me.lkpTrabajoDeclarado.Properties.ImmediatePopup = True
        Me.lkpTrabajoDeclarado.Properties.PopupFormMinSize = New System.Drawing.Size(68, 40)
        Me.lkpTrabajoDeclarado.Properties.PopupFormSize = New System.Drawing.Size(68, 40)
        Me.lkpTrabajoDeclarado.Properties.ShowFooter = False
        Me.lkpTrabajoDeclarado.Properties.ValueMember = "Id"
        Me.lkpTrabajoDeclarado.Properties.View = Me.GridView21
        Me.lkpTrabajoDeclarado.Size = New System.Drawing.Size(68, 20)
        Me.lkpTrabajoDeclarado.TabIndex = 14
        '
        'GridView21
        '
        Me.GridView21.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn64, Me.GridColumn65})
        Me.GridView21.DetailHeight = 150
        Me.GridView21.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView21.Name = "GridView21"
        Me.GridView21.OptionsCustomization.AllowFilter = False
        Me.GridView21.OptionsCustomization.AllowGroup = False
        Me.GridView21.OptionsCustomization.AllowSort = False
        Me.GridView21.OptionsMenu.EnableColumnMenu = False
        Me.GridView21.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView21.OptionsView.AutoCalcPreviewLineCount = True
        Me.GridView21.OptionsView.ShowColumnHeaders = False
        Me.GridView21.OptionsView.ShowGroupPanel = False
        Me.GridView21.OptionsView.ShowIndicator = False
        '
        'GridColumn64
        '
        Me.GridColumn64.FieldName = "Id"
        Me.GridColumn64.Name = "GridColumn64"
        '
        'GridColumn65
        '
        Me.GridColumn65.FieldName = "Opcion"
        Me.GridColumn65.Name = "GridColumn65"
        Me.GridColumn65.OptionsColumn.AllowEdit = False
        Me.GridColumn65.OptionsColumn.ShowCaption = False
        Me.GridColumn65.Visible = True
        Me.GridColumn65.VisibleIndex = 0
        '
        'lblTrabajoDeclarado
        '
        Me.lblTrabajoDeclarado.Location = New System.Drawing.Point(13, 6)
        Me.lblTrabajoDeclarado.Name = "lblTrabajoDeclarado"
        Me.lblTrabajoDeclarado.Size = New System.Drawing.Size(367, 13)
        Me.lblTrabajoDeclarado.TabIndex = 109
        Me.lblTrabajoDeclarado.Text = "¿La dirección de su actividad es el lugar de trabajo declarado anteriormente?"
        '
        'lkpEstudioDeclarado
        '
        Me.lkpEstudioDeclarado.EditValue = ""
        Me.lkpEstudioDeclarado.Location = New System.Drawing.Point(1, 25)
        Me.lkpEstudioDeclarado.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.lkpEstudioDeclarado.Name = "lkpEstudioDeclarado"
        Me.lkpEstudioDeclarado.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.lkpEstudioDeclarado.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.lkpEstudioDeclarado.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit
        Me.lkpEstudioDeclarado.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lkpEstudioDeclarado.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkpEstudioDeclarado.Properties.DataSource = Me.SiNoBindingSource
        Me.lkpEstudioDeclarado.Properties.DisplayMember = "Opcion"
        Me.lkpEstudioDeclarado.Properties.ImmediatePopup = True
        Me.lkpEstudioDeclarado.Properties.PopupFormMinSize = New System.Drawing.Size(63, 40)
        Me.lkpEstudioDeclarado.Properties.PopupFormSize = New System.Drawing.Size(63, 40)
        Me.lkpEstudioDeclarado.Properties.ShowFooter = False
        Me.lkpEstudioDeclarado.Properties.ValueMember = "Id"
        Me.lkpEstudioDeclarado.Properties.View = Me.GridView73
        Me.lkpEstudioDeclarado.Size = New System.Drawing.Size(68, 20)
        Me.lkpEstudioDeclarado.TabIndex = 14
        '
        'GridView73
        '
        Me.GridView73.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn91, Me.GridColumn92})
        Me.GridView73.DetailHeight = 150
        Me.GridView73.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView73.Name = "GridView73"
        Me.GridView73.OptionsCustomization.AllowFilter = False
        Me.GridView73.OptionsCustomization.AllowGroup = False
        Me.GridView73.OptionsCustomization.AllowSort = False
        Me.GridView73.OptionsMenu.EnableColumnMenu = False
        Me.GridView73.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView73.OptionsView.AutoCalcPreviewLineCount = True
        Me.GridView73.OptionsView.ShowColumnHeaders = False
        Me.GridView73.OptionsView.ShowGroupPanel = False
        Me.GridView73.OptionsView.ShowIndicator = False
        '
        'GridColumn91
        '
        Me.GridColumn91.FieldName = "Id"
        Me.GridColumn91.Name = "GridColumn91"
        '
        'GridColumn92
        '
        Me.GridColumn92.FieldName = "Opcion"
        Me.GridColumn92.Name = "GridColumn92"
        Me.GridColumn92.OptionsColumn.AllowEdit = False
        Me.GridColumn92.OptionsColumn.ShowCaption = False
        Me.GridColumn92.Visible = True
        Me.GridColumn92.VisibleIndex = 0
        '
        'lblEstudioDeclarado
        '
        Me.lblEstudioDeclarado.Location = New System.Drawing.Point(1, 6)
        Me.lblEstudioDeclarado.Name = "lblEstudioDeclarado"
        Me.lblEstudioDeclarado.Size = New System.Drawing.Size(367, 13)
        Me.lblEstudioDeclarado.TabIndex = 111
        Me.lblEstudioDeclarado.Text = "¿La dirección de su actividad es el lugar de estudio declarado anteriormente?"
        '
        'spcCallesDestino
        '
        Me.spcCallesDestino.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.spcCallesDestino.Appearance.Options.UseBackColor = True
        Me.spcCallesDestino.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.None
        Me.spcCallesDestino.Location = New System.Drawing.Point(276, 52)
        Me.spcCallesDestino.Name = "spcCallesDestino"
        Me.spcCallesDestino.Panel1.Controls.Add(Me.txtComunaDestinoOtra)
        Me.spcCallesDestino.Panel1.Controls.Add(Me.lblComunaDestinoOtra)
        Me.spcCallesDestino.Panel1.Text = "Panel1"
        Me.spcCallesDestino.Panel2.Controls.Add(Me.LabelControl2)
        Me.spcCallesDestino.Panel2.Controls.Add(Me.LabelControl3)
        Me.spcCallesDestino.Panel2.Controls.Add(Me.LabelControl4)
        Me.spcCallesDestino.Panel2.Controls.Add(Me.LabelControl24)
        Me.spcCallesDestino.Panel2.Controls.Add(Me.lkpCalle1Destino)
        Me.spcCallesDestino.Panel2.Controls.Add(Me.lkpHitoDestino)
        Me.spcCallesDestino.Panel2.Controls.Add(Me.lkpCalle2Destino)
        Me.spcCallesDestino.Panel2.Controls.Add(Me.lkpManzanaDestino)
        Me.spcCallesDestino.Panel2.Text = "Panel2"
        Me.spcCallesDestino.Size = New System.Drawing.Size(714, 49)
        Me.spcCallesDestino.SplitterPosition = 90
        Me.spcCallesDestino.TabIndex = 16
        Me.spcCallesDestino.Text = "SplitContainerControl1"
        Me.spcCallesDestino.Visible = False
        '
        'txtComunaDestinoOtra
        '
        Me.txtComunaDestinoOtra.Location = New System.Drawing.Point(3, 24)
        Me.txtComunaDestinoOtra.Name = "txtComunaDestinoOtra"
        Me.txtComunaDestinoOtra.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.txtComunaDestinoOtra.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.txtComunaDestinoOtra.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtComunaDestinoOtra.Size = New System.Drawing.Size(86, 20)
        Me.txtComunaDestinoOtra.TabIndex = 16
        '
        'lblComunaDestinoOtra
        '
        Me.lblComunaDestinoOtra.Location = New System.Drawing.Point(3, 5)
        Me.lblComunaDestinoOtra.Name = "lblComunaDestinoOtra"
        Me.lblComunaDestinoOtra.Size = New System.Drawing.Size(62, 13)
        Me.lblComunaDestinoOtra.TabIndex = 16
        Me.lblComunaDestinoOtra.Text = "Otra comuna"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(540, 3)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(43, 13)
        Me.LabelControl2.TabIndex = 17
        Me.LabelControl2.Text = "Manzana"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(2, 3)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(32, 13)
        Me.LabelControl3.TabIndex = 12
        Me.LabelControl3.Text = "Calle 1"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(172, 3)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(32, 13)
        Me.LabelControl4.TabIndex = 13
        Me.LabelControl4.Text = "Calle 2"
        '
        'LabelControl24
        '
        Me.LabelControl24.Location = New System.Drawing.Point(344, 5)
        Me.LabelControl24.Name = "LabelControl24"
        Me.LabelControl24.Size = New System.Drawing.Size(19, 13)
        Me.LabelControl24.TabIndex = 15
        Me.LabelControl24.Text = "Hito"
        '
        'lkpCalle1Destino
        '
        Me.lkpCalle1Destino.EditValue = ""
        Me.lkpCalle1Destino.Location = New System.Drawing.Point(2, 22)
        Me.lkpCalle1Destino.Name = "lkpCalle1Destino"
        Me.lkpCalle1Destino.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.lkpCalle1Destino.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.lkpCalle1Destino.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.lkpCalle1Destino.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lkpCalle1Destino.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkpCalle1Destino.Properties.DataSource = Me.CallesBindingSource
        Me.lkpCalle1Destino.Properties.DisplayMember = "calle"
        Me.lkpCalle1Destino.Properties.ImmediatePopup = True
        Me.lkpCalle1Destino.Properties.NullText = ""
        Me.lkpCalle1Destino.Properties.NullValuePrompt = "No reporta"
        Me.lkpCalle1Destino.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.lkpCalle1Destino.Properties.PopupFormMinSize = New System.Drawing.Size(157, 20)
        Me.lkpCalle1Destino.Properties.PopupFormSize = New System.Drawing.Size(157, 200)
        Me.lkpCalle1Destino.Properties.ShowFooter = False
        Me.lkpCalle1Destino.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.lkpCalle1Destino.Properties.ValueMember = "calle"
        Me.lkpCalle1Destino.Properties.View = Me.GridView2
        Me.lkpCalle1Destino.Size = New System.Drawing.Size(157, 20)
        Me.lkpCalle1Destino.TabIndex = 17
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colid13, Me.colcalle})
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsCustomization.AllowFilter = False
        Me.GridView2.OptionsCustomization.AllowGroup = False
        Me.GridView2.OptionsCustomization.AllowSort = False
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ShowColumnHeaders = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        Me.GridView2.OptionsView.ShowIndicator = False
        '
        'colid13
        '
        Me.colid13.FieldName = "id"
        Me.colid13.Name = "colid13"
        '
        'colcalle
        '
        Me.colcalle.FieldName = "calle"
        Me.colcalle.Name = "colcalle"
        Me.colcalle.Visible = True
        Me.colcalle.VisibleIndex = 0
        '
        'lkpHitoDestino
        '
        Me.lkpHitoDestino.EditValue = ""
        Me.lkpHitoDestino.Location = New System.Drawing.Point(344, 22)
        Me.lkpHitoDestino.Name = "lkpHitoDestino"
        Me.lkpHitoDestino.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.lkpHitoDestino.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.lkpHitoDestino.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.lkpHitoDestino.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lkpHitoDestino.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkpHitoDestino.Properties.DataSource = Me.HitoBindingSource
        Me.lkpHitoDestino.Properties.DisplayMember = "hito"
        Me.lkpHitoDestino.Properties.ImmediatePopup = True
        Me.lkpHitoDestino.Properties.NullText = ""
        Me.lkpHitoDestino.Properties.NullValuePrompt = "No reporta"
        Me.lkpHitoDestino.Properties.NullValuePromptShowForEmptyValue = True
        Me.lkpHitoDestino.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.lkpHitoDestino.Properties.PopupFormMinSize = New System.Drawing.Size(188, 20)
        Me.lkpHitoDestino.Properties.PopupFormSize = New System.Drawing.Size(188, 200)
        Me.lkpHitoDestino.Properties.ShowFooter = False
        Me.lkpHitoDestino.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.lkpHitoDestino.Properties.ValueMember = "hito"
        Me.lkpHitoDestino.Properties.View = Me.GridView5
        Me.lkpHitoDestino.Size = New System.Drawing.Size(188, 20)
        Me.lkpHitoDestino.TabIndex = 19
        '
        'GridView5
        '
        Me.GridView5.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colid14, Me.colhito1, Me.colhitoManzana1})
        Me.GridView5.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView5.Name = "GridView5"
        Me.GridView5.OptionsCustomization.AllowFilter = False
        Me.GridView5.OptionsCustomization.AllowGroup = False
        Me.GridView5.OptionsCustomization.AllowSort = False
        Me.GridView5.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView5.OptionsView.ShowColumnHeaders = False
        Me.GridView5.OptionsView.ShowGroupPanel = False
        Me.GridView5.OptionsView.ShowIndicator = False
        '
        'colid14
        '
        Me.colid14.FieldName = "id"
        Me.colid14.Name = "colid14"
        '
        'colhito1
        '
        Me.colhito1.FieldName = "hito"
        Me.colhito1.Name = "colhito1"
        Me.colhito1.Visible = True
        Me.colhito1.VisibleIndex = 0
        '
        'colhitoManzana1
        '
        Me.colhitoManzana1.FieldName = "hitoManzana"
        Me.colhitoManzana1.Name = "colhitoManzana1"
        '
        'lkpCalle2Destino
        '
        Me.lkpCalle2Destino.EditValue = ""
        Me.lkpCalle2Destino.Location = New System.Drawing.Point(171, 22)
        Me.lkpCalle2Destino.Name = "lkpCalle2Destino"
        Me.lkpCalle2Destino.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.lkpCalle2Destino.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.lkpCalle2Destino.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.lkpCalle2Destino.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lkpCalle2Destino.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkpCalle2Destino.Properties.DataSource = Me.ConsultaCalle2DestinoBindingSource
        Me.lkpCalle2Destino.Properties.DisplayMember = "calle2"
        Me.lkpCalle2Destino.Properties.ImmediatePopup = True
        Me.lkpCalle2Destino.Properties.NullText = ""
        Me.lkpCalle2Destino.Properties.NullValuePrompt = "No reporta"
        Me.lkpCalle2Destino.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.lkpCalle2Destino.Properties.PopupFormMinSize = New System.Drawing.Size(151, 20)
        Me.lkpCalle2Destino.Properties.PopupFormSize = New System.Drawing.Size(151, 200)
        Me.lkpCalle2Destino.Properties.ShowFooter = False
        Me.lkpCalle2Destino.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.lkpCalle2Destino.Properties.ValueMember = "calle2"
        Me.lkpCalle2Destino.Properties.View = Me.GridView6
        Me.lkpCalle2Destino.Size = New System.Drawing.Size(151, 20)
        Me.lkpCalle2Destino.TabIndex = 18
        '
        'ConsultaCalle2DestinoBindingSource
        '
        Me.ConsultaCalle2DestinoBindingSource.DataMember = "ConsultaCalle2Destino"
        Me.ConsultaCalle2DestinoBindingSource.DataSource = Me.datasetEOD
        '
        'GridView6
        '
        Me.GridView6.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID16, Me.colcalle11, Me.colcalle2})
        Me.GridView6.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView6.Name = "GridView6"
        Me.GridView6.OptionsCustomization.AllowFilter = False
        Me.GridView6.OptionsCustomization.AllowGroup = False
        Me.GridView6.OptionsCustomization.AllowSort = False
        Me.GridView6.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView6.OptionsView.ShowColumnHeaders = False
        Me.GridView6.OptionsView.ShowGroupPanel = False
        Me.GridView6.OptionsView.ShowIndicator = False
        '
        'colID16
        '
        Me.colID16.FieldName = "ID"
        Me.colID16.Name = "colID16"
        '
        'colcalle11
        '
        Me.colcalle11.FieldName = "calle1"
        Me.colcalle11.Name = "colcalle11"
        '
        'colcalle2
        '
        Me.colcalle2.FieldName = "calle2"
        Me.colcalle2.Name = "colcalle2"
        Me.colcalle2.Visible = True
        Me.colcalle2.VisibleIndex = 0
        '
        'lkpManzanaDestino
        '
        Me.lkpManzanaDestino.EditValue = ""
        Me.lkpManzanaDestino.Location = New System.Drawing.Point(540, 22)
        Me.lkpManzanaDestino.Name = "lkpManzanaDestino"
        Me.lkpManzanaDestino.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.lkpManzanaDestino.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.lkpManzanaDestino.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lkpManzanaDestino.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkpManzanaDestino.Properties.ImmediatePopup = True
        Me.lkpManzanaDestino.Properties.ShowFooter = False
        Me.lkpManzanaDestino.Properties.ShowHeader = False
        Me.lkpManzanaDestino.Size = New System.Drawing.Size(72, 20)
        Me.lkpManzanaDestino.TabIndex = 20
        '
        'LabelControl15
        '
        Me.LabelControl15.Location = New System.Drawing.Point(134, 57)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(39, 13)
        Me.LabelControl15.TabIndex = 15
        Me.LabelControl15.Text = "Comuna"
        '
        'lkpComunaDestino
        '
        Me.lkpComunaDestino.EditValue = ""
        Me.lkpComunaDestino.Location = New System.Drawing.Point(134, 76)
        Me.lkpComunaDestino.Name = "lkpComunaDestino"
        Me.lkpComunaDestino.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.lkpComunaDestino.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.lkpComunaDestino.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lkpComunaDestino.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkpComunaDestino.Properties.DataSource = Me.ComunaBindingSource
        Me.lkpComunaDestino.Properties.DisplayMember = "Comuna"
        Me.lkpComunaDestino.Properties.ImmediatePopup = True
        Me.lkpComunaDestino.Properties.PopupFormMinSize = New System.Drawing.Size(136, 240)
        Me.lkpComunaDestino.Properties.PopupFormSize = New System.Drawing.Size(136, 240)
        Me.lkpComunaDestino.Properties.ShowFooter = False
        Me.lkpComunaDestino.Properties.ValueMember = "ID"
        Me.lkpComunaDestino.Properties.View = Me.GridView11
        Me.lkpComunaDestino.Size = New System.Drawing.Size(136, 20)
        Me.lkpComunaDestino.TabIndex = 15
        '
        'GridView11
        '
        Me.GridView11.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID8, Me.colComuna1})
        Me.GridView11.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView11.Name = "GridView11"
        Me.GridView11.OptionsCustomization.AllowFilter = False
        Me.GridView11.OptionsCustomization.AllowGroup = False
        Me.GridView11.OptionsCustomization.AllowSort = False
        Me.GridView11.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView11.OptionsView.ShowColumnHeaders = False
        Me.GridView11.OptionsView.ShowGroupPanel = False
        Me.GridView11.OptionsView.ShowIndicator = False
        '
        'colID8
        '
        Me.colID8.FieldName = "ID"
        Me.colID8.Name = "colID8"
        '
        'colComuna1
        '
        Me.colComuna1.FieldName = "Comuna"
        Me.colComuna1.Name = "colComuna1"
        Me.colComuna1.Visible = True
        Me.colComuna1.VisibleIndex = 0
        '
        'spcViaje
        '
        Me.spcViaje.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.spcViaje.Appearance.Options.UseBackColor = True
        Me.spcViaje.Horizontal = False
        Me.spcViaje.Location = New System.Drawing.Point(11, 129)
        Me.spcViaje.Name = "spcViaje"
        Me.spcViaje.Panel1.Controls.Add(Me.LabelControl23)
        Me.spcViaje.Panel1.Controls.Add(Me.spcCallesDestino)
        Me.spcViaje.Panel1.Controls.Add(Me.LabelControl147)
        Me.spcViaje.Panel1.Controls.Add(Me.LabelControl15)
        Me.spcViaje.Panel1.Controls.Add(Me.lblTransporte3)
        Me.spcViaje.Panel1.Controls.Add(Me.lkpComunaDestino)
        Me.spcViaje.Panel1.Controls.Add(Me.lblTransporte2)
        Me.spcViaje.Panel1.Controls.Add(Me.LabelControl1)
        Me.spcViaje.Panel1.Controls.Add(Me.lkpTransporte1)
        Me.spcViaje.Panel1.Controls.Add(Me.lkpTransporte2)
        Me.spcViaje.Panel1.Controls.Add(Me.lkpTransporte3)
        Me.spcViaje.Panel1.Controls.Add(Me.spDestinoViaje)
        Me.spcViaje.Panel1.Controls.Add(Me.LabelControl11)
        Me.spcViaje.Panel1.Controls.Add(Me.LabelControl12)
        Me.spcViaje.Panel1.Controls.Add(Me.tmHoraSalida)
        Me.spcViaje.Panel1.Controls.Add(Me.lkpProposito)
        Me.spcViaje.Panel1.Text = "Panel1"
        Me.spcViaje.Panel2.Controls.Add(Me.tabsEtapas)
        Me.spcViaje.Panel2.Text = "Panel2"
        Me.spcViaje.Size = New System.Drawing.Size(999, 346)
        Me.spcViaje.SplitterPosition = 128
        Me.spcViaje.TabIndex = 14
        Me.spcViaje.Text = "SplitContainerControl1"
        '
        'LabelControl23
        '
        Me.LabelControl23.Location = New System.Drawing.Point(-1, 59)
        Me.LabelControl23.Name = "LabelControl23"
        Me.LabelControl23.Size = New System.Drawing.Size(120, 13)
        Me.LabelControl23.TabIndex = 107
        Me.LabelControl23.Text = "¿Dónde fue su actividad?"
        '
        'LabelControl147
        '
        Me.LabelControl147.Location = New System.Drawing.Point(5, 110)
        Me.LabelControl147.Name = "LabelControl147"
        Me.LabelControl147.Size = New System.Drawing.Size(296, 13)
        Me.LabelControl147.TabIndex = 106
        Me.LabelControl147.Text = "¿Qué medios de transporte utilizó en el desarrollo de su viaje?"
        '
        'lblTransporte3
        '
        Me.lblTransporte3.Location = New System.Drawing.Point(748, 110)
        Me.lblTransporte3.Name = "lblTransporte3"
        Me.lblTransporte3.Size = New System.Drawing.Size(11, 13)
        Me.lblTransporte3.TabIndex = 100
        Me.lblTransporte3.Text = "3°"
        Me.lblTransporte3.Visible = False
        '
        'lblTransporte2
        '
        Me.lblTransporte2.Location = New System.Drawing.Point(555, 110)
        Me.lblTransporte2.Name = "lblTransporte2"
        Me.lblTransporte2.Size = New System.Drawing.Size(11, 13)
        Me.lblTransporte2.TabIndex = 99
        Me.lblTransporte2.Text = "2°"
        Me.lblTransporte2.Visible = False
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(362, 110)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(11, 13)
        Me.LabelControl1.TabIndex = 98
        Me.LabelControl1.Text = "1°"
        '
        'lkpTransporte1
        '
        Me.lkpTransporte1.EditValue = ""
        Me.lkpTransporte1.Location = New System.Drawing.Point(379, 107)
        Me.lkpTransporte1.Name = "lkpTransporte1"
        Me.lkpTransporte1.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.lkpTransporte1.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.lkpTransporte1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lkpTransporte1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkpTransporte1.Properties.DataSource = Me.ModoBindingSource
        Me.lkpTransporte1.Properties.DisplayMember = "Modo"
        Me.lkpTransporte1.Properties.ImmediatePopup = True
        Me.lkpTransporte1.Properties.PopupFormMinSize = New System.Drawing.Size(160, 280)
        Me.lkpTransporte1.Properties.PopupFormSize = New System.Drawing.Size(160, 280)
        Me.lkpTransporte1.Properties.ShowFooter = False
        Me.lkpTransporte1.Properties.ValueMember = "ID"
        Me.lkpTransporte1.Properties.View = Me.GridView10
        Me.lkpTransporte1.Size = New System.Drawing.Size(160, 20)
        Me.lkpTransporte1.TabIndex = 21
        '
        'ModoBindingSource
        '
        Me.ModoBindingSource.DataMember = "Modo"
        Me.ModoBindingSource.DataSource = Me.datasetEOD
        Me.ModoBindingSource.Filter = "id > 0"
        '
        'GridView10
        '
        Me.GridView10.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID9, Me.colModo})
        Me.GridView10.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView10.Name = "GridView10"
        Me.GridView10.OptionsCustomization.AllowFilter = False
        Me.GridView10.OptionsCustomization.AllowGroup = False
        Me.GridView10.OptionsCustomization.AllowSort = False
        Me.GridView10.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView10.OptionsView.ShowColumnHeaders = False
        Me.GridView10.OptionsView.ShowGroupPanel = False
        Me.GridView10.OptionsView.ShowIndicator = False
        Me.GridView10.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colID9, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colID9
        '
        Me.colID9.FieldName = "ID"
        Me.colID9.Name = "colID9"
        '
        'colModo
        '
        Me.colModo.FieldName = "Modo"
        Me.colModo.Name = "colModo"
        Me.colModo.Visible = True
        Me.colModo.VisibleIndex = 0
        '
        'lkpTransporte2
        '
        Me.lkpTransporte2.EditValue = ""
        Me.lkpTransporte2.Location = New System.Drawing.Point(572, 107)
        Me.lkpTransporte2.Name = "lkpTransporte2"
        Me.lkpTransporte2.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.lkpTransporte2.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.lkpTransporte2.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.lkpTransporte2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lkpTransporte2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkpTransporte2.Properties.DataSource = Me.Modo2BindingSource
        Me.lkpTransporte2.Properties.DisplayMember = "Modo"
        Me.lkpTransporte2.Properties.ImmediatePopup = True
        Me.lkpTransporte2.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.lkpTransporte2.Properties.PopupFormMinSize = New System.Drawing.Size(160, 280)
        Me.lkpTransporte2.Properties.PopupFormSize = New System.Drawing.Size(160, 280)
        Me.lkpTransporte2.Properties.ShowFooter = False
        Me.lkpTransporte2.Properties.ValueMember = "ID"
        Me.lkpTransporte2.Properties.View = Me.GridView12
        Me.lkpTransporte2.Size = New System.Drawing.Size(160, 20)
        Me.lkpTransporte2.TabIndex = 22
        Me.lkpTransporte2.Visible = False
        '
        'Modo2BindingSource
        '
        Me.Modo2BindingSource.DataMember = "Modo"
        Me.Modo2BindingSource.DataSource = Me.datasetEOD
        Me.Modo2BindingSource.Filter = "id <> 7"
        '
        'GridView12
        '
        Me.GridView12.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID12, Me.colModo3})
        Me.GridView12.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView12.Name = "GridView12"
        Me.GridView12.OptionsCustomization.AllowFilter = False
        Me.GridView12.OptionsCustomization.AllowGroup = False
        Me.GridView12.OptionsCustomization.AllowSort = False
        Me.GridView12.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView12.OptionsView.ShowColumnHeaders = False
        Me.GridView12.OptionsView.ShowGroupPanel = False
        Me.GridView12.OptionsView.ShowIndicator = False
        Me.GridView12.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colID12, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colID12
        '
        Me.colID12.FieldName = "ID"
        Me.colID12.Name = "colID12"
        '
        'colModo3
        '
        Me.colModo3.FieldName = "Modo"
        Me.colModo3.Name = "colModo3"
        Me.colModo3.Visible = True
        Me.colModo3.VisibleIndex = 0
        '
        'lkpTransporte3
        '
        Me.lkpTransporte3.EditValue = ""
        Me.lkpTransporte3.Location = New System.Drawing.Point(765, 107)
        Me.lkpTransporte3.Name = "lkpTransporte3"
        Me.lkpTransporte3.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.lkpTransporte3.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.lkpTransporte3.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.lkpTransporte3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lkpTransporte3.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkpTransporte3.Properties.DataSource = Me.Modo3BindingSource
        Me.lkpTransporte3.Properties.DisplayMember = "Modo"
        Me.lkpTransporte3.Properties.ImmediatePopup = True
        Me.lkpTransporte3.Properties.PopupFormMinSize = New System.Drawing.Size(160, 280)
        Me.lkpTransporte3.Properties.PopupFormSize = New System.Drawing.Size(160, 280)
        Me.lkpTransporte3.Properties.ShowFooter = False
        Me.lkpTransporte3.Properties.ValueMember = "ID"
        Me.lkpTransporte3.Properties.View = Me.GridView13
        Me.lkpTransporte3.Size = New System.Drawing.Size(160, 20)
        Me.lkpTransporte3.TabIndex = 23
        Me.lkpTransporte3.Visible = False
        '
        'Modo3BindingSource
        '
        Me.Modo3BindingSource.DataMember = "Modo"
        Me.Modo3BindingSource.DataSource = Me.datasetEOD
        Me.Modo3BindingSource.Filter = "id <> 7"
        '
        'GridView13
        '
        Me.GridView13.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID10, Me.colModo1})
        Me.GridView13.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView13.Name = "GridView13"
        Me.GridView13.OptionsCustomization.AllowFilter = False
        Me.GridView13.OptionsCustomization.AllowGroup = False
        Me.GridView13.OptionsCustomization.AllowSort = False
        Me.GridView13.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView13.OptionsView.ShowColumnHeaders = False
        Me.GridView13.OptionsView.ShowGroupPanel = False
        Me.GridView13.OptionsView.ShowIndicator = False
        Me.GridView13.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colID10, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colID10
        '
        Me.colID10.FieldName = "ID"
        Me.colID10.Name = "colID10"
        '
        'colModo1
        '
        Me.colModo1.FieldName = "Modo"
        Me.colModo1.Name = "colModo1"
        Me.colModo1.Visible = True
        Me.colModo1.VisibleIndex = 0
        '
        'LabelControl115
        '
        Me.LabelControl115.Location = New System.Drawing.Point(337, 5)
        Me.LabelControl115.Name = "LabelControl115"
        Me.LabelControl115.Size = New System.Drawing.Size(196, 13)
        Me.LabelControl115.TabIndex = 17
        Me.LabelControl115.Text = "¿Cuánto caminó para llegar a su destino?"
        '
        'txtCuadrasDespues
        '
        Me.txtCuadrasDespues.Location = New System.Drawing.Point(337, 24)
        Me.txtCuadrasDespues.Name = "txtCuadrasDespues"
        Me.txtCuadrasDespues.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.txtCuadrasDespues.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.txtCuadrasDespues.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtCuadrasDespues.Properties.Mask.EditMask = "n0"
        Me.txtCuadrasDespues.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtCuadrasDespues.Size = New System.Drawing.Size(43, 20)
        Me.txtCuadrasDespues.TabIndex = 43
        '
        'panelFinViaje
        '
        Me.panelFinViaje.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.panelFinViaje.Appearance.Options.UseBackColor = True
        Me.panelFinViaje.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.panelFinViaje.Controls.Add(Me.lkpOtroViaje)
        Me.panelFinViaje.Controls.Add(Me.LabelControl63)
        Me.panelFinViaje.Controls.Add(Me.LabelControl116)
        Me.panelFinViaje.Controls.Add(Me.LabelControl105)
        Me.panelFinViaje.Controls.Add(Me.LabelControl59)
        Me.panelFinViaje.Controls.Add(Me.LabelControl55)
        Me.panelFinViaje.Controls.Add(Me.x_destino)
        Me.panelFinViaje.Controls.Add(Me.y_destino)
        Me.panelFinViaje.Controls.Add(Me.x_origen)
        Me.panelFinViaje.Controls.Add(Me.y_origen)
        Me.panelFinViaje.Controls.Add(Me.txtMinutosDespues)
        Me.panelFinViaje.Controls.Add(Me.LabelControl5)
        Me.panelFinViaje.Controls.Add(Me.LabelControl20)
        Me.panelFinViaje.Controls.Add(Me.LabelControl112)
        Me.panelFinViaje.Controls.Add(Me.txtCuadrasDespues)
        Me.panelFinViaje.Controls.Add(Me.LabelControl13)
        Me.panelFinViaje.Controls.Add(Me.LabelControl115)
        Me.panelFinViaje.Controls.Add(Me.lkpTrasnoche)
        Me.panelFinViaje.Controls.Add(Me.tmHoraLlegada)
        Me.panelFinViaje.Location = New System.Drawing.Point(11, 491)
        Me.panelFinViaje.Name = "panelFinViaje"
        Me.panelFinViaje.Size = New System.Drawing.Size(999, 50)
        Me.panelFinViaje.TabIndex = 93
        Me.panelFinViaje.Visible = False
        '
        'lkpOtroViaje
        '
        Me.lkpOtroViaje.EditValue = ""
        Me.lkpOtroViaje.Location = New System.Drawing.Point(568, 24)
        Me.lkpOtroViaje.Name = "lkpOtroViaje"
        Me.lkpOtroViaje.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.lkpOtroViaje.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.lkpOtroViaje.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lkpOtroViaje.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkpOtroViaje.Properties.DataSource = Me.SiNoBindingSource
        Me.lkpOtroViaje.Properties.DisplayMember = "Opcion"
        Me.lkpOtroViaje.Properties.ImmediatePopup = True
        Me.lkpOtroViaje.Properties.PopupFormMinSize = New System.Drawing.Size(65, 40)
        Me.lkpOtroViaje.Properties.PopupFormSize = New System.Drawing.Size(65, 40)
        Me.lkpOtroViaje.Properties.ShowFooter = False
        Me.lkpOtroViaje.Properties.ValueMember = "Id"
        Me.lkpOtroViaje.Properties.View = Me.GridView61
        Me.lkpOtroViaje.Size = New System.Drawing.Size(65, 20)
        Me.lkpOtroViaje.TabIndex = 45
        '
        'GridView61
        '
        Me.GridView61.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn49, Me.GridColumn50})
        Me.GridView61.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView61.Name = "GridView61"
        Me.GridView61.OptionsCustomization.AllowFilter = False
        Me.GridView61.OptionsCustomization.AllowGroup = False
        Me.GridView61.OptionsCustomization.AllowSort = False
        Me.GridView61.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView61.OptionsView.ShowColumnHeaders = False
        Me.GridView61.OptionsView.ShowGroupPanel = False
        Me.GridView61.OptionsView.ShowIndicator = False
        '
        'GridColumn49
        '
        Me.GridColumn49.FieldName = "Id"
        Me.GridColumn49.Name = "GridColumn49"
        '
        'GridColumn50
        '
        Me.GridColumn50.FieldName = "Opcion"
        Me.GridColumn50.Name = "GridColumn50"
        Me.GridColumn50.Visible = True
        Me.GridColumn50.VisibleIndex = 0
        '
        'LabelControl63
        '
        Me.LabelControl63.Location = New System.Drawing.Point(568, 5)
        Me.LabelControl63.Name = "LabelControl63"
        Me.LabelControl63.Size = New System.Drawing.Size(175, 13)
        Me.LabelControl63.TabIndex = 50
        Me.LabelControl63.Text = "¿Realizó otro viaje después de este?"
        '
        'LabelControl116
        '
        Me.LabelControl116.Location = New System.Drawing.Point(893, 24)
        Me.LabelControl116.Name = "LabelControl116"
        Me.LabelControl116.Size = New System.Drawing.Size(47, 13)
        Me.LabelControl116.TabIndex = 30
        Me.LabelControl116.Text = "y_destino"
        Me.LabelControl116.Visible = False
        '
        'LabelControl105
        '
        Me.LabelControl105.Location = New System.Drawing.Point(807, 24)
        Me.LabelControl105.Name = "LabelControl105"
        Me.LabelControl105.Size = New System.Drawing.Size(42, 13)
        Me.LabelControl105.TabIndex = 29
        Me.LabelControl105.Text = "y_origen"
        Me.LabelControl105.Visible = False
        '
        'LabelControl59
        '
        Me.LabelControl59.Location = New System.Drawing.Point(893, 5)
        Me.LabelControl59.Name = "LabelControl59"
        Me.LabelControl59.Size = New System.Drawing.Size(47, 13)
        Me.LabelControl59.TabIndex = 28
        Me.LabelControl59.Text = "x_destino"
        Me.LabelControl59.Visible = False
        '
        'LabelControl55
        '
        Me.LabelControl55.Location = New System.Drawing.Point(807, 5)
        Me.LabelControl55.Name = "LabelControl55"
        Me.LabelControl55.Size = New System.Drawing.Size(42, 13)
        Me.LabelControl55.TabIndex = 27
        Me.LabelControl55.Text = "x_origen"
        Me.LabelControl55.Visible = False
        '
        'x_destino
        '
        Me.x_destino.Location = New System.Drawing.Point(945, 2)
        Me.x_destino.Name = "x_destino"
        Me.x_destino.Size = New System.Drawing.Size(25, 20)
        Me.x_destino.TabIndex = 48
        Me.x_destino.TabStop = False
        Me.x_destino.Visible = False
        '
        'y_destino
        '
        Me.y_destino.Location = New System.Drawing.Point(945, 21)
        Me.y_destino.Name = "y_destino"
        Me.y_destino.Size = New System.Drawing.Size(25, 20)
        Me.y_destino.TabIndex = 49
        Me.y_destino.TabStop = False
        Me.y_destino.Visible = False
        '
        'x_origen
        '
        Me.x_origen.Location = New System.Drawing.Point(855, 2)
        Me.x_origen.Name = "x_origen"
        Me.x_origen.Size = New System.Drawing.Size(32, 20)
        Me.x_origen.TabIndex = 46
        Me.x_origen.TabStop = False
        Me.x_origen.Visible = False
        '
        'y_origen
        '
        Me.y_origen.Location = New System.Drawing.Point(855, 23)
        Me.y_origen.Name = "y_origen"
        Me.y_origen.Size = New System.Drawing.Size(32, 20)
        Me.y_origen.TabIndex = 47
        Me.y_origen.TabStop = False
        Me.y_origen.Visible = False
        '
        'txtMinutosDespues
        '
        Me.txtMinutosDespues.Location = New System.Drawing.Point(452, 24)
        Me.txtMinutosDespues.Name = "txtMinutosDespues"
        Me.txtMinutosDespues.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.txtMinutosDespues.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.txtMinutosDespues.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtMinutosDespues.Properties.Mask.EditMask = "n0"
        Me.txtMinutosDespues.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtMinutosDespues.Size = New System.Drawing.Size(40, 20)
        Me.txtMinutosDespues.TabIndex = 44
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(498, 24)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl5.TabIndex = 21
        Me.LabelControl5.Text = "minutos"
        '
        'LabelControl20
        '
        Me.LabelControl20.Location = New System.Drawing.Point(386, 24)
        Me.LabelControl20.Name = "LabelControl20"
        Me.LabelControl20.Size = New System.Drawing.Size(38, 13)
        Me.LabelControl20.TabIndex = 20
        Me.LabelControl20.Text = "cuadras"
        '
        'btnGuardarViaje
        '
        Me.btnGuardarViaje.Appearance.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnGuardarViaje.Appearance.ForeColor = System.Drawing.Color.White
        Me.btnGuardarViaje.Appearance.Options.UseBackColor = True
        Me.btnGuardarViaje.Appearance.Options.UseForeColor = True
        Me.btnGuardarViaje.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
        Me.btnGuardarViaje.Location = New System.Drawing.Point(907, 517)
        Me.btnGuardarViaje.LookAndFeel.SkinMaskColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnGuardarViaje.Name = "btnGuardarViaje"
        Me.btnGuardarViaje.Size = New System.Drawing.Size(94, 30)
        Me.btnGuardarViaje.TabIndex = 46
        Me.btnGuardarViaje.Text = "Guardar viaje"
        '
        'RibbonControl1
        '
        Me.RibbonControl1.AllowKeyTips = False
        Me.RibbonControl1.AllowMdiChildButtons = False
        Me.RibbonControl1.AllowMinimizeRibbon = False
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem})
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 1
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl1.ShowCategoryInCaption = False
        Me.RibbonControl1.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.[True]
        Me.RibbonControl1.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide
        Me.RibbonControl1.ShowQatLocationSelector = False
        Me.RibbonControl1.ShowToolbarCustomizeItem = False
        Me.RibbonControl1.Size = New System.Drawing.Size(1015, 32)
        Me.RibbonControl1.Toolbar.ShowCustomizeItem = False
        Me.RibbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
        '
        'spcPrimerViaje
        '
        Me.spcPrimerViaje.Collapsed = True
        Me.spcPrimerViaje.CollapsePanel = DevExpress.XtraEditors.SplitCollapsePanel.Panel2
        Me.spcPrimerViaje.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.None
        Me.spcPrimerViaje.Location = New System.Drawing.Point(3, 2)
        Me.spcPrimerViaje.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.spcPrimerViaje.Name = "spcPrimerViaje"
        Me.spcPrimerViaje.Panel1.Controls.Add(Me.LabelControl21)
        Me.spcPrimerViaje.Panel1.Controls.Add(Me.spcCallesPrimerViaje)
        Me.spcPrimerViaje.Panel1.Controls.Add(Me.lblComunaOrigen)
        Me.spcPrimerViaje.Panel1.Controls.Add(Me.lkpComunaOrigen)
        Me.spcPrimerViaje.Panel1.Controls.Add(Me.lkpDondePrimerViaje)
        Me.spcPrimerViaje.Panel1.Text = "Panel1"
        Me.spcPrimerViaje.Panel2.Controls.Add(Me.lblNoViajaOtro)
        Me.spcPrimerViaje.Panel2.Controls.Add(Me.txtNoViajaOtro)
        Me.spcPrimerViaje.Panel2.Controls.Add(Me.LabelControl22)
        Me.spcPrimerViaje.Panel2.Controls.Add(Me.lkpNoViaja)
        Me.spcPrimerViaje.Panel2.Text = "Panel2"
        Me.spcPrimerViaje.Size = New System.Drawing.Size(810, 74)
        Me.spcPrimerViaje.SplitterPosition = 525
        Me.spcPrimerViaje.TabIndex = 99
        Me.spcPrimerViaje.Text = "SplitContainerControl1"
        '
        'LabelControl21
        '
        Me.LabelControl21.Location = New System.Drawing.Point(4, 20)
        Me.LabelControl21.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.LabelControl21.Name = "LabelControl21"
        Me.LabelControl21.Size = New System.Drawing.Size(159, 13)
        Me.LabelControl21.TabIndex = 13
        Me.LabelControl21.Text = "¿Dónde comenzó su primer viaje?"
        '
        'spcCallesPrimerViaje
        '
        Me.spcCallesPrimerViaje.Location = New System.Drawing.Point(313, 0)
        Me.spcCallesPrimerViaje.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.spcCallesPrimerViaje.Name = "spcCallesPrimerViaje"
        Me.spcCallesPrimerViaje.Panel1.Controls.Add(Me.lblComunaOrigenOtra)
        Me.spcCallesPrimerViaje.Panel1.Controls.Add(Me.txtComunaOrigenOtra)
        Me.spcCallesPrimerViaje.Panel1.Text = "Panel1"
        Me.spcCallesPrimerViaje.Panel2.Controls.Add(Me.lkpCalle2Origen)
        Me.spcCallesPrimerViaje.Panel2.Controls.Add(Me.LabelControl10)
        Me.spcCallesPrimerViaje.Panel2.Controls.Add(Me.lkpCalle1Origen)
        Me.spcCallesPrimerViaje.Panel2.Controls.Add(Me.LabelControl7)
        Me.spcCallesPrimerViaje.Panel2.Controls.Add(Me.lkpManzanaOrigen)
        Me.spcCallesPrimerViaje.Panel2.Controls.Add(Me.lkpHitoOrigen)
        Me.spcCallesPrimerViaje.Panel2.Controls.Add(Me.LabelControl9)
        Me.spcCallesPrimerViaje.Panel2.Controls.Add(Me.LabelControl8)
        Me.spcCallesPrimerViaje.Panel2.Text = "Panel2"
        Me.spcCallesPrimerViaje.Size = New System.Drawing.Size(496, 74)
        Me.spcCallesPrimerViaje.SplitterPosition = 92
        Me.spcCallesPrimerViaje.TabIndex = 98
        Me.spcCallesPrimerViaje.Text = "SplitContainerControl1"
        Me.spcCallesPrimerViaje.Visible = False
        '
        'lblComunaOrigenOtra
        '
        Me.lblComunaOrigenOtra.Location = New System.Drawing.Point(5, 18)
        Me.lblComunaOrigenOtra.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.lblComunaOrigenOtra.Name = "lblComunaOrigenOtra"
        Me.lblComunaOrigenOtra.Size = New System.Drawing.Size(62, 13)
        Me.lblComunaOrigenOtra.TabIndex = 10
        Me.lblComunaOrigenOtra.Text = "Otra comuna"
        '
        'txtComunaOrigenOtra
        '
        Me.txtComunaOrigenOtra.Location = New System.Drawing.Point(5, 39)
        Me.txtComunaOrigenOtra.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.txtComunaOrigenOtra.Name = "txtComunaOrigenOtra"
        Me.txtComunaOrigenOtra.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.txtComunaOrigenOtra.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.txtComunaOrigenOtra.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtComunaOrigenOtra.Size = New System.Drawing.Size(86, 20)
        Me.txtComunaOrigenOtra.TabIndex = 4
        '
        'lkpCalle2Origen
        '
        Me.lkpCalle2Origen.Location = New System.Drawing.Point(41, 43)
        Me.lkpCalle2Origen.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.lkpCalle2Origen.Name = "lkpCalle2Origen"
        Me.lkpCalle2Origen.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.lkpCalle2Origen.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.lkpCalle2Origen.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.lkpCalle2Origen.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lkpCalle2Origen.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkpCalle2Origen.Properties.DataSource = Me.ConsultaCalle2OrigenBindingSource
        Me.lkpCalle2Origen.Properties.DisplayMember = "calle2"
        Me.lkpCalle2Origen.Properties.ImmediatePopup = True
        Me.lkpCalle2Origen.Properties.NullText = ""
        Me.lkpCalle2Origen.Properties.NullValuePrompt = "No reporta"
        Me.lkpCalle2Origen.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.lkpCalle2Origen.Properties.PopupFormMinSize = New System.Drawing.Size(169, 20)
        Me.lkpCalle2Origen.Properties.PopupFormSize = New System.Drawing.Size(169, 200)
        Me.lkpCalle2Origen.Properties.ShowFooter = False
        Me.lkpCalle2Origen.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.lkpCalle2Origen.Properties.ValueMember = "calle2"
        Me.lkpCalle2Origen.Properties.View = Me.GridView1
        Me.lkpCalle2Origen.Size = New System.Drawing.Size(169, 20)
        Me.lkpCalle2Origen.TabIndex = 6
        '
        'ConsultaCalle2OrigenBindingSource
        '
        Me.ConsultaCalle2OrigenBindingSource.DataMember = "ConsultaCalle2Origen"
        Me.ConsultaCalle2OrigenBindingSource.DataSource = Me.datasetEOD
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID17, Me.colcalle12, Me.colcalle21, Me.colconflictiva})
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
        'colID17
        '
        Me.colID17.FieldName = "ID"
        Me.colID17.Name = "colID17"
        '
        'colcalle12
        '
        Me.colcalle12.FieldName = "calle1"
        Me.colcalle12.Name = "colcalle12"
        '
        'colcalle21
        '
        Me.colcalle21.FieldName = "calle2"
        Me.colcalle21.Name = "colcalle21"
        Me.colcalle21.Visible = True
        Me.colcalle21.VisibleIndex = 0
        '
        'colconflictiva
        '
        Me.colconflictiva.FieldName = "conflictiva"
        Me.colconflictiva.Name = "colconflictiva"
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(222, 45)
        Me.LabelControl10.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(43, 13)
        Me.LabelControl10.TabIndex = 17
        Me.LabelControl10.Text = "Manzana"
        '
        'lkpCalle1Origen
        '
        Me.lkpCalle1Origen.EditValue = ""
        Me.lkpCalle1Origen.Location = New System.Drawing.Point(41, 18)
        Me.lkpCalle1Origen.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.lkpCalle1Origen.Name = "lkpCalle1Origen"
        Me.lkpCalle1Origen.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.lkpCalle1Origen.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.lkpCalle1Origen.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.lkpCalle1Origen.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lkpCalle1Origen.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkpCalle1Origen.Properties.DataSource = Me.CallesBindingSource
        Me.lkpCalle1Origen.Properties.DisplayMember = "calle"
        Me.lkpCalle1Origen.Properties.ImmediatePopup = True
        Me.lkpCalle1Origen.Properties.NullText = ""
        Me.lkpCalle1Origen.Properties.NullValuePrompt = "No reporta"
        Me.lkpCalle1Origen.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.lkpCalle1Origen.Properties.PopupFormMinSize = New System.Drawing.Size(169, 20)
        Me.lkpCalle1Origen.Properties.PopupFormSize = New System.Drawing.Size(169, 200)
        Me.lkpCalle1Origen.Properties.ShowFooter = False
        Me.lkpCalle1Origen.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.lkpCalle1Origen.Properties.ValueMember = "calle"
        Me.lkpCalle1Origen.Properties.View = Me.GridLookUpEdit2View
        Me.lkpCalle1Origen.Size = New System.Drawing.Size(169, 20)
        Me.lkpCalle1Origen.TabIndex = 5
        '
        'GridLookUpEdit2View
        '
        Me.GridLookUpEdit2View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colid1, Me.colcalle1})
        Me.GridLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit2View.Name = "GridLookUpEdit2View"
        Me.GridLookUpEdit2View.OptionsCustomization.AllowFilter = False
        Me.GridLookUpEdit2View.OptionsCustomization.AllowGroup = False
        Me.GridLookUpEdit2View.OptionsCustomization.AllowSort = False
        Me.GridLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit2View.OptionsView.ShowColumnHeaders = False
        Me.GridLookUpEdit2View.OptionsView.ShowGroupPanel = False
        Me.GridLookUpEdit2View.OptionsView.ShowIndicator = False
        '
        'colid1
        '
        Me.colid1.FieldName = "id"
        Me.colid1.Name = "colid1"
        '
        'colcalle1
        '
        Me.colcalle1.FieldName = "calle"
        Me.colcalle1.Name = "colcalle1"
        Me.colcalle1.OptionsColumn.ShowCaption = False
        Me.colcalle1.Visible = True
        Me.colcalle1.VisibleIndex = 0
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(3, 21)
        Me.LabelControl7.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(32, 13)
        Me.LabelControl7.TabIndex = 12
        Me.LabelControl7.Text = "Calle 1"
        '
        'lkpManzanaOrigen
        '
        Me.lkpManzanaOrigen.Location = New System.Drawing.Point(271, 42)
        Me.lkpManzanaOrigen.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.lkpManzanaOrigen.Name = "lkpManzanaOrigen"
        Me.lkpManzanaOrigen.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.lkpManzanaOrigen.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.lkpManzanaOrigen.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lkpManzanaOrigen.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkpManzanaOrigen.Properties.NullText = ""
        Me.lkpManzanaOrigen.Properties.PopupFormMinSize = New System.Drawing.Size(30, 0)
        Me.lkpManzanaOrigen.Properties.ShowFooter = False
        Me.lkpManzanaOrigen.Properties.ShowHeader = False
        Me.lkpManzanaOrigen.Size = New System.Drawing.Size(72, 20)
        Me.lkpManzanaOrigen.TabIndex = 8
        '
        'lkpHitoOrigen
        '
        Me.lkpHitoOrigen.EditValue = ""
        Me.lkpHitoOrigen.Location = New System.Drawing.Point(271, 18)
        Me.lkpHitoOrigen.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.lkpHitoOrigen.Name = "lkpHitoOrigen"
        Me.lkpHitoOrigen.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.lkpHitoOrigen.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.lkpHitoOrigen.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.lkpHitoOrigen.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lkpHitoOrigen.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkpHitoOrigen.Properties.DataSource = Me.HitoBindingSource
        Me.lkpHitoOrigen.Properties.DisplayMember = "hito"
        Me.lkpHitoOrigen.Properties.ImmediatePopup = True
        Me.lkpHitoOrigen.Properties.NullText = ""
        Me.lkpHitoOrigen.Properties.NullValuePrompt = "No reporta"
        Me.lkpHitoOrigen.Properties.NullValuePromptShowForEmptyValue = True
        Me.lkpHitoOrigen.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains
        Me.lkpHitoOrigen.Properties.PopupFormMinSize = New System.Drawing.Size(167, 20)
        Me.lkpHitoOrigen.Properties.PopupFormSize = New System.Drawing.Size(167, 200)
        Me.lkpHitoOrigen.Properties.ShowFooter = False
        Me.lkpHitoOrigen.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.lkpHitoOrigen.Properties.ValueMember = "hito"
        Me.lkpHitoOrigen.Properties.View = Me.GridLookUpEdit1View
        Me.lkpHitoOrigen.Size = New System.Drawing.Size(167, 20)
        Me.lkpHitoOrigen.TabIndex = 7
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colid, Me.colhito, Me.colhitoManzana})
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
        'colid
        '
        Me.colid.FieldName = "id"
        Me.colid.Name = "colid"
        '
        'colhito
        '
        Me.colhito.FieldName = "hito"
        Me.colhito.Name = "colhito"
        Me.colhito.OptionsColumn.ShowCaption = False
        Me.colhito.Visible = True
        Me.colhito.VisibleIndex = 0
        '
        'colhitoManzana
        '
        Me.colhitoManzana.FieldName = "hitoManzana"
        Me.colhitoManzana.Name = "colhitoManzana"
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(222, 21)
        Me.LabelControl9.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(19, 13)
        Me.LabelControl9.TabIndex = 15
        Me.LabelControl9.Text = "Hito"
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(3, 46)
        Me.LabelControl8.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(32, 13)
        Me.LabelControl8.TabIndex = 13
        Me.LabelControl8.Text = "Calle 2"
        '
        'lblComunaOrigen
        '
        Me.lblComunaOrigen.Location = New System.Drawing.Point(197, 21)
        Me.lblComunaOrigen.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.lblComunaOrigen.Name = "lblComunaOrigen"
        Me.lblComunaOrigen.Size = New System.Drawing.Size(39, 13)
        Me.lblComunaOrigen.TabIndex = 10
        Me.lblComunaOrigen.Text = "Comuna"
        Me.lblComunaOrigen.Visible = False
        '
        'lkpComunaOrigen
        '
        Me.lkpComunaOrigen.EditValue = ""
        Me.lkpComunaOrigen.Location = New System.Drawing.Point(197, 39)
        Me.lkpComunaOrigen.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.lkpComunaOrigen.Name = "lkpComunaOrigen"
        Me.lkpComunaOrigen.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.lkpComunaOrigen.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.lkpComunaOrigen.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lkpComunaOrigen.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkpComunaOrigen.Properties.DataSource = Me.ComunaBindingSource
        Me.lkpComunaOrigen.Properties.DisplayMember = "Comuna"
        Me.lkpComunaOrigen.Properties.ImmediatePopup = True
        Me.lkpComunaOrigen.Properties.PopupFormMinSize = New System.Drawing.Size(109, 240)
        Me.lkpComunaOrigen.Properties.PopupFormSize = New System.Drawing.Size(109, 240)
        Me.lkpComunaOrigen.Properties.ShowFooter = False
        Me.lkpComunaOrigen.Properties.ValueMember = "ID"
        Me.lkpComunaOrigen.Properties.View = Me.GridView3
        Me.lkpComunaOrigen.Size = New System.Drawing.Size(109, 20)
        Me.lkpComunaOrigen.TabIndex = 3
        Me.lkpComunaOrigen.Visible = False
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID4, Me.colComuna})
        Me.GridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsCustomization.AllowFilter = False
        Me.GridView3.OptionsCustomization.AllowGroup = False
        Me.GridView3.OptionsCustomization.AllowSort = False
        Me.GridView3.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView3.OptionsView.ShowColumnHeaders = False
        Me.GridView3.OptionsView.ShowGroupPanel = False
        Me.GridView3.OptionsView.ShowIndicator = False
        '
        'colID4
        '
        Me.colID4.FieldName = "ID"
        Me.colID4.Name = "colID4"
        '
        'colComuna
        '
        Me.colComuna.FieldName = "Comuna"
        Me.colComuna.Name = "colComuna"
        Me.colComuna.Visible = True
        Me.colComuna.VisibleIndex = 0
        '
        'lkpDondePrimerViaje
        '
        Me.lkpDondePrimerViaje.EditValue = ""
        Me.lkpDondePrimerViaje.Location = New System.Drawing.Point(4, 39)
        Me.lkpDondePrimerViaje.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.lkpDondePrimerViaje.Name = "lkpDondePrimerViaje"
        Me.lkpDondePrimerViaje.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.lkpDondePrimerViaje.Properties.Appearance.Options.UseBackColor = True
        Me.lkpDondePrimerViaje.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.lkpDondePrimerViaje.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.lkpDondePrimerViaje.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lkpDondePrimerViaje.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkpDondePrimerViaje.Properties.DataSource = Me.LugarPrimerViajeBindingSource
        Me.lkpDondePrimerViaje.Properties.DisplayMember = "LugarPrimerViaje"
        Me.lkpDondePrimerViaje.Properties.ImmediatePopup = True
        Me.lkpDondePrimerViaje.Properties.PopupFormMinSize = New System.Drawing.Size(179, 40)
        Me.lkpDondePrimerViaje.Properties.PopupFormSize = New System.Drawing.Size(179, 40)
        Me.lkpDondePrimerViaje.Properties.ShowFooter = False
        Me.lkpDondePrimerViaje.Properties.ValueMember = "Id"
        Me.lkpDondePrimerViaje.Properties.View = Me.GridView4
        Me.lkpDondePrimerViaje.Size = New System.Drawing.Size(179, 20)
        Me.lkpDondePrimerViaje.TabIndex = 2
        '
        'LugarPrimerViajeBindingSource
        '
        Me.LugarPrimerViajeBindingSource.DataMember = "LugarPrimerViaje"
        Me.LugarPrimerViajeBindingSource.DataSource = Me.datasetEOD
        '
        'GridView4
        '
        Me.GridView4.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colId3, Me.colLugarPrimerViaje})
        Me.GridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView4.Name = "GridView4"
        Me.GridView4.OptionsCustomization.AllowFilter = False
        Me.GridView4.OptionsCustomization.AllowGroup = False
        Me.GridView4.OptionsCustomization.AllowSort = False
        Me.GridView4.OptionsMenu.EnableColumnMenu = False
        Me.GridView4.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView4.OptionsView.ShowColumnHeaders = False
        Me.GridView4.OptionsView.ShowGroupPanel = False
        Me.GridView4.OptionsView.ShowIndicator = False
        '
        'colId3
        '
        Me.colId3.FieldName = "Id"
        Me.colId3.Name = "colId3"
        '
        'colLugarPrimerViaje
        '
        Me.colLugarPrimerViaje.FieldName = "LugarPrimerViaje"
        Me.colLugarPrimerViaje.Name = "colLugarPrimerViaje"
        Me.colLugarPrimerViaje.Visible = True
        Me.colLugarPrimerViaje.VisibleIndex = 0
        '
        'lblNoViajaOtro
        '
        Me.lblNoViajaOtro.Location = New System.Drawing.Point(216, 19)
        Me.lblNoViajaOtro.Name = "lblNoViajaOtro"
        Me.lblNoViajaOtro.Size = New System.Drawing.Size(57, 13)
        Me.lblNoViajaOtro.TabIndex = 19
        Me.lblNoViajaOtro.Text = "Otro motivo"
        Me.lblNoViajaOtro.Visible = False
        '
        'txtNoViajaOtro
        '
        Me.txtNoViajaOtro.Location = New System.Drawing.Point(215, 39)
        Me.txtNoViajaOtro.Name = "txtNoViajaOtro"
        Me.txtNoViajaOtro.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtNoViajaOtro.Size = New System.Drawing.Size(100, 20)
        Me.txtNoViajaOtro.TabIndex = 11
        Me.txtNoViajaOtro.Visible = False
        '
        'LabelControl22
        '
        Me.LabelControl22.Location = New System.Drawing.Point(6, 20)
        Me.LabelControl22.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.LabelControl22.Name = "LabelControl22"
        Me.LabelControl22.Size = New System.Drawing.Size(88, 13)
        Me.LabelControl22.TabIndex = 17
        Me.LabelControl22.Text = "¿Por qué no viajó?"
        '
        'lkpNoViaja
        '
        Me.lkpNoViaja.EditValue = ""
        Me.lkpNoViaja.Location = New System.Drawing.Point(6, 39)
        Me.lkpNoViaja.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.lkpNoViaja.Name = "lkpNoViaja"
        Me.lkpNoViaja.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lkpNoViaja.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkpNoViaja.Properties.DataSource = Me.NoViajaBindingSource
        Me.lkpNoViaja.Properties.DisplayMember = "NoViaja"
        Me.lkpNoViaja.Properties.PopupFormMinSize = New System.Drawing.Size(189, 120)
        Me.lkpNoViaja.Properties.PopupFormSize = New System.Drawing.Size(189, 120)
        Me.lkpNoViaja.Properties.ShowFooter = False
        Me.lkpNoViaja.Properties.ValueMember = "ID"
        Me.lkpNoViaja.Properties.View = Me.GridView22
        Me.lkpNoViaja.Size = New System.Drawing.Size(189, 20)
        Me.lkpNoViaja.TabIndex = 10
        '
        'NoViajaBindingSource
        '
        Me.NoViajaBindingSource.DataMember = "NoViaja"
        Me.NoViajaBindingSource.DataSource = Me.datasetEOD
        Me.NoViajaBindingSource.Filter = "id > 0"
        '
        'GridView22
        '
        Me.GridView22.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID7, Me.colNoViaja})
        Me.GridView22.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView22.Name = "GridView22"
        Me.GridView22.OptionsCustomization.AllowFilter = False
        Me.GridView22.OptionsCustomization.AllowGroup = False
        Me.GridView22.OptionsCustomization.AllowSort = False
        Me.GridView22.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView22.OptionsView.ShowColumnHeaders = False
        Me.GridView22.OptionsView.ShowGroupPanel = False
        Me.GridView22.OptionsView.ShowIndicator = False
        '
        'colID7
        '
        Me.colID7.FieldName = "ID"
        Me.colID7.Name = "colID7"
        '
        'colNoViaja
        '
        Me.colNoViaja.FieldName = "NoViaja"
        Me.colNoViaja.Name = "colNoViaja"
        Me.colNoViaja.Visible = True
        Me.colNoViaja.VisibleIndex = 0
        '
        'lkpRealizoViajes
        '
        Me.lkpRealizoViajes.EditValue = ""
        Me.lkpRealizoViajes.Location = New System.Drawing.Point(1, 41)
        Me.lkpRealizoViajes.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.lkpRealizoViajes.Name = "lkpRealizoViajes"
        Me.lkpRealizoViajes.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.Lime
        Me.lkpRealizoViajes.Properties.AppearanceFocused.Options.UseBorderColor = True
        Me.lkpRealizoViajes.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit
        Me.lkpRealizoViajes.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.lkpRealizoViajes.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkpRealizoViajes.Properties.DataSource = Me.SiNoBindingSource
        Me.lkpRealizoViajes.Properties.DisplayMember = "Opcion"
        Me.lkpRealizoViajes.Properties.ImmediatePopup = True
        Me.lkpRealizoViajes.Properties.PopupFormMinSize = New System.Drawing.Size(63, 40)
        Me.lkpRealizoViajes.Properties.PopupFormSize = New System.Drawing.Size(63, 40)
        Me.lkpRealizoViajes.Properties.ShowFooter = False
        Me.lkpRealizoViajes.Properties.ValueMember = "Id"
        Me.lkpRealizoViajes.Properties.View = Me.GridView20
        Me.lkpRealizoViajes.Size = New System.Drawing.Size(68, 22)
        Me.lkpRealizoViajes.TabIndex = 1
        '
        'GridView20
        '
        Me.GridView20.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colId2, Me.colOpcion})
        Me.GridView20.DetailHeight = 150
        Me.GridView20.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView20.Name = "GridView20"
        Me.GridView20.OptionsCustomization.AllowFilter = False
        Me.GridView20.OptionsCustomization.AllowGroup = False
        Me.GridView20.OptionsCustomization.AllowSort = False
        Me.GridView20.OptionsMenu.EnableColumnMenu = False
        Me.GridView20.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView20.OptionsView.AutoCalcPreviewLineCount = True
        Me.GridView20.OptionsView.ShowColumnHeaders = False
        Me.GridView20.OptionsView.ShowGroupPanel = False
        Me.GridView20.OptionsView.ShowIndicator = False
        '
        'colId2
        '
        Me.colId2.FieldName = "Id"
        Me.colId2.Name = "colId2"
        '
        'colOpcion
        '
        Me.colOpcion.FieldName = "Opcion"
        Me.colOpcion.Name = "colOpcion"
        Me.colOpcion.OptionsColumn.AllowEdit = False
        Me.colOpcion.OptionsColumn.ShowCaption = False
        Me.colOpcion.Visible = True
        Me.colOpcion.VisibleIndex = 0
        '
        'LabelControl16
        '
        Me.LabelControl16.Location = New System.Drawing.Point(1, 22)
        Me.LabelControl16.Margin = New System.Windows.Forms.Padding(3, 1, 3, 1)
        Me.LabelControl16.Name = "LabelControl16"
        Me.LabelControl16.Size = New System.Drawing.Size(173, 13)
        Me.LabelControl16.TabIndex = 12
        Me.LabelControl16.Text = "¿Realizó algún viaje el día asignado?"
        '
        'spcRealizoViajes
        '
        Me.spcRealizoViajes.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.spcRealizoViajes.Appearance.Options.UseBackColor = True
        Me.spcRealizoViajes.IsSplitterFixed = True
        Me.spcRealizoViajes.Location = New System.Drawing.Point(7, 3)
        Me.spcRealizoViajes.Name = "spcRealizoViajes"
        Me.spcRealizoViajes.Panel1.Controls.Add(Me.LabelControl16)
        Me.spcRealizoViajes.Panel1.Controls.Add(Me.lkpRealizoViajes)
        Me.spcRealizoViajes.Panel1.Text = "Panel1"
        Me.spcRealizoViajes.Panel2.Controls.Add(Me.spcPrimerViaje)
        Me.spcRealizoViajes.Panel2.Text = "Panel2"
        Me.spcRealizoViajes.Size = New System.Drawing.Size(1008, 76)
        Me.spcRealizoViajes.SplitterPosition = 175
        Me.spcRealizoViajes.TabIndex = 47
        Me.spcRealizoViajes.Text = "SplitContainerControl1"
        '
        'tabsInicioViaje
        '
        Me.tabsInicioViaje.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.tabsInicioViaje.BorderStylePage = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.tabsInicioViaje.Location = New System.Drawing.Point(2, 35)
        Me.tabsInicioViaje.Name = "tabsInicioViaje"
        Me.tabsInicioViaje.SelectedTabPage = Me.tabPrimerViaje
        Me.tabsInicioViaje.ShowTabHeader = DevExpress.Utils.DefaultBoolean.[False]
        Me.tabsInicioViaje.Size = New System.Drawing.Size(1020, 85)
        Me.tabsInicioViaje.TabIndex = 99
        Me.tabsInicioViaje.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tabPrimerViaje, Me.tabViajeAnterior})
        '
        'tabPrimerViaje
        '
        Me.tabPrimerViaje.Controls.Add(Me.spcRealizoViajes)
        Me.tabPrimerViaje.Name = "tabPrimerViaje"
        Me.tabPrimerViaje.Size = New System.Drawing.Size(1018, 83)
        Me.tabPrimerViaje.Text = "XtraTabPage1"
        '
        'tabViajeAnterior
        '
        Me.tabViajeAnterior.Controls.Add(Me.gcViajeAnterior)
        Me.tabViajeAnterior.Name = "tabViajeAnterior"
        Me.tabViajeAnterior.Size = New System.Drawing.Size(1018, 83)
        Me.tabViajeAnterior.Text = "XtraTabPage2"
        '
        'gcViajeAnterior
        '
        Me.gcViajeAnterior.Controls.Add(Me.SplitContainerControl1)
        Me.gcViajeAnterior.Controls.Add(Me.LabelControl104)
        Me.gcViajeAnterior.Controls.Add(Me.lkpPropositoAnterior)
        Me.gcViajeAnterior.Controls.Add(Me.LabelControl106)
        Me.gcViajeAnterior.Controls.Add(Me.LabelControl114)
        Me.gcViajeAnterior.Controls.Add(Me.tmFinAnterior)
        Me.gcViajeAnterior.Controls.Add(Me.tmInicioAnterior)
        Me.gcViajeAnterior.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcViajeAnterior.Location = New System.Drawing.Point(0, 0)
        Me.gcViajeAnterior.Name = "gcViajeAnterior"
        Me.gcViajeAnterior.Size = New System.Drawing.Size(1018, 83)
        Me.gcViajeAnterior.TabIndex = 1
        Me.gcViajeAnterior.Text = "Viaje anterior"
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.SplitContainerControl1.Appearance.Options.UseBackColor = True
        Me.SplitContainerControl1.Collapsed = True
        Me.SplitContainerControl1.CollapsePanel = DevExpress.XtraEditors.SplitCollapsePanel.Panel1
        Me.SplitContainerControl1.Location = New System.Drawing.Point(255, 14)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.TextEdit1)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.LabelControl46)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.spCallesViajeAnterior)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.LabelControl148)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.LabelControl65)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.lkpComunaAnterior)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(758, 63)
        Me.SplitContainerControl1.SplitterPosition = 104
        Me.SplitContainerControl1.TabIndex = 100
        Me.SplitContainerControl1.Text = "SplitContainerControl10"
        '
        'TextEdit1
        '
        Me.TextEdit1.Location = New System.Drawing.Point(3, 43)
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Size = New System.Drawing.Size(100, 20)
        Me.TextEdit1.TabIndex = 14
        '
        'LabelControl46
        '
        Me.LabelControl46.Location = New System.Drawing.Point(4, 24)
        Me.LabelControl46.Name = "LabelControl46"
        Me.LabelControl46.Size = New System.Drawing.Size(70, 13)
        Me.LabelControl46.TabIndex = 15
        Me.LabelControl46.Text = "Otro propósito"
        '
        'spCallesViajeAnterior
        '
        Me.spCallesViajeAnterior.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.spCallesViajeAnterior.Appearance.Options.UseBackColor = True
        Me.spCallesViajeAnterior.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.None
        Me.spCallesViajeAnterior.Location = New System.Drawing.Point(117, 15)
        Me.spCallesViajeAnterior.Name = "spCallesViajeAnterior"
        Me.spCallesViajeAnterior.Panel1.Controls.Add(Me.txtComunaOtraAnterior)
        Me.spCallesViajeAnterior.Panel1.Controls.Add(Me.LabelControl47)
        Me.spCallesViajeAnterior.Panel1.Text = "Panel1"
        Me.spCallesViajeAnterior.Panel2.Controls.Add(Me.LabelControl49)
        Me.spCallesViajeAnterior.Panel2.Controls.Add(Me.LabelControl50)
        Me.spCallesViajeAnterior.Panel2.Controls.Add(Me.LabelControl51)
        Me.spCallesViajeAnterior.Panel2.Controls.Add(Me.LabelControl52)
        Me.spCallesViajeAnterior.Panel2.Controls.Add(Me.txtCalle1Anterior)
        Me.spCallesViajeAnterior.Panel2.Controls.Add(Me.txtCalle2Anterior)
        Me.spCallesViajeAnterior.Panel2.Controls.Add(Me.txtHitoAnterior)
        Me.spCallesViajeAnterior.Panel2.Controls.Add(Me.txtManzanaAnterior)
        Me.spCallesViajeAnterior.Panel2.Text = "Panel2"
        Me.spCallesViajeAnterior.Size = New System.Drawing.Size(619, 50)
        Me.spCallesViajeAnterior.SplitterPosition = 95
        Me.spCallesViajeAnterior.TabIndex = 96
        Me.spCallesViajeAnterior.Text = "SplitContainerControl1"
        Me.spCallesViajeAnterior.Visible = False
        '
        'txtComunaOtraAnterior
        '
        Me.txtComunaOtraAnterior.Location = New System.Drawing.Point(3, 24)
        Me.txtComunaOtraAnterior.Name = "txtComunaOtraAnterior"
        Me.txtComunaOtraAnterior.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtComunaOtraAnterior.Properties.Appearance.Options.UseBackColor = True
        Me.txtComunaOtraAnterior.Properties.ReadOnly = True
        Me.txtComunaOtraAnterior.Size = New System.Drawing.Size(86, 20)
        Me.txtComunaOtraAnterior.TabIndex = 16
        '
        'LabelControl47
        '
        Me.LabelControl47.Location = New System.Drawing.Point(3, 5)
        Me.LabelControl47.Name = "LabelControl47"
        Me.LabelControl47.Size = New System.Drawing.Size(62, 13)
        Me.LabelControl47.TabIndex = 16
        Me.LabelControl47.Text = "Otra comuna"
        '
        'LabelControl49
        '
        Me.LabelControl49.Location = New System.Drawing.Point(250, 30)
        Me.LabelControl49.Name = "LabelControl49"
        Me.LabelControl49.Size = New System.Drawing.Size(43, 13)
        Me.LabelControl49.TabIndex = 17
        Me.LabelControl49.Text = "Manzana"
        '
        'LabelControl50
        '
        Me.LabelControl50.Location = New System.Drawing.Point(2, 3)
        Me.LabelControl50.Name = "LabelControl50"
        Me.LabelControl50.Size = New System.Drawing.Size(32, 13)
        Me.LabelControl50.TabIndex = 12
        Me.LabelControl50.Text = "Calle 1"
        '
        'LabelControl51
        '
        Me.LabelControl51.Location = New System.Drawing.Point(2, 30)
        Me.LabelControl51.Name = "LabelControl51"
        Me.LabelControl51.Size = New System.Drawing.Size(32, 13)
        Me.LabelControl51.TabIndex = 13
        Me.LabelControl51.Text = "Calle 2"
        '
        'LabelControl52
        '
        Me.LabelControl52.Location = New System.Drawing.Point(250, 5)
        Me.LabelControl52.Name = "LabelControl52"
        Me.LabelControl52.Size = New System.Drawing.Size(19, 13)
        Me.LabelControl52.TabIndex = 15
        Me.LabelControl52.Text = "Hito"
        '
        'txtCalle1Anterior
        '
        Me.txtCalle1Anterior.EditValue = ""
        Me.txtCalle1Anterior.Location = New System.Drawing.Point(40, 4)
        Me.txtCalle1Anterior.Name = "txtCalle1Anterior"
        Me.txtCalle1Anterior.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtCalle1Anterior.Properties.Appearance.Options.UseBackColor = True
        Me.txtCalle1Anterior.Properties.NullText = "[Vacío]"
        Me.txtCalle1Anterior.Properties.ReadOnly = True
        Me.txtCalle1Anterior.Size = New System.Drawing.Size(191, 20)
        Me.txtCalle1Anterior.TabIndex = 17
        '
        'txtCalle2Anterior
        '
        Me.txtCalle2Anterior.EditValue = ""
        Me.txtCalle2Anterior.Location = New System.Drawing.Point(40, 30)
        Me.txtCalle2Anterior.Name = "txtCalle2Anterior"
        Me.txtCalle2Anterior.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtCalle2Anterior.Properties.Appearance.Options.UseBackColor = True
        Me.txtCalle2Anterior.Properties.NullText = "[Vacío]"
        Me.txtCalle2Anterior.Properties.ReadOnly = True
        Me.txtCalle2Anterior.Size = New System.Drawing.Size(191, 20)
        Me.txtCalle2Anterior.TabIndex = 18
        '
        'txtHitoAnterior
        '
        Me.txtHitoAnterior.EditValue = ""
        Me.txtHitoAnterior.Location = New System.Drawing.Point(299, 4)
        Me.txtHitoAnterior.Name = "txtHitoAnterior"
        Me.txtHitoAnterior.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtHitoAnterior.Properties.Appearance.Options.UseBackColor = True
        Me.txtHitoAnterior.Properties.NullText = "[Vacío]"
        Me.txtHitoAnterior.Properties.ReadOnly = True
        Me.txtHitoAnterior.Size = New System.Drawing.Size(209, 20)
        Me.txtHitoAnterior.TabIndex = 19
        '
        'txtManzanaAnterior
        '
        Me.txtManzanaAnterior.EditValue = ""
        Me.txtManzanaAnterior.Location = New System.Drawing.Point(299, 27)
        Me.txtManzanaAnterior.Name = "txtManzanaAnterior"
        Me.txtManzanaAnterior.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtManzanaAnterior.Properties.Appearance.Options.UseBackColor = True
        Me.txtManzanaAnterior.Properties.NullText = "[Vacío]"
        Me.txtManzanaAnterior.Properties.ReadOnly = True
        Me.txtManzanaAnterior.Size = New System.Drawing.Size(72, 20)
        Me.txtManzanaAnterior.TabIndex = 20
        '
        'LabelControl148
        '
        Me.LabelControl148.Location = New System.Drawing.Point(6, 1)
        Me.LabelControl148.Name = "LabelControl148"
        Me.LabelControl148.Size = New System.Drawing.Size(158, 13)
        Me.LabelControl148.TabIndex = 0
        Me.LabelControl148.Text = "¿Dónde fue la actividad anterior?"
        '
        'LabelControl65
        '
        Me.LabelControl65.Location = New System.Drawing.Point(4, 21)
        Me.LabelControl65.Name = "LabelControl65"
        Me.LabelControl65.Size = New System.Drawing.Size(39, 13)
        Me.LabelControl65.TabIndex = 15
        Me.LabelControl65.Text = "Comuna"
        '
        'lkpComunaAnterior
        '
        Me.lkpComunaAnterior.EditValue = ""
        Me.lkpComunaAnterior.Location = New System.Drawing.Point(4, 40)
        Me.lkpComunaAnterior.Name = "lkpComunaAnterior"
        Me.lkpComunaAnterior.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.lkpComunaAnterior.Properties.Appearance.Options.UseBackColor = True
        Me.lkpComunaAnterior.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkpComunaAnterior.Properties.DataSource = Me.ComunaBindingSource
        Me.lkpComunaAnterior.Properties.DisplayMember = "Comuna"
        Me.lkpComunaAnterior.Properties.ImmediatePopup = True
        Me.lkpComunaAnterior.Properties.PopupFormMinSize = New System.Drawing.Size(175, 280)
        Me.lkpComunaAnterior.Properties.PopupFormSize = New System.Drawing.Size(175, 280)
        Me.lkpComunaAnterior.Properties.ReadOnly = True
        Me.lkpComunaAnterior.Properties.ShowFooter = False
        Me.lkpComunaAnterior.Properties.ValueMember = "ID"
        Me.lkpComunaAnterior.Properties.View = Me.GridView27
        Me.lkpComunaAnterior.Size = New System.Drawing.Size(104, 20)
        Me.lkpComunaAnterior.TabIndex = 15
        '
        'GridView27
        '
        Me.GridView27.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn59, Me.GridColumn60})
        Me.GridView27.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView27.Name = "GridView27"
        Me.GridView27.OptionsCustomization.AllowFilter = False
        Me.GridView27.OptionsCustomization.AllowGroup = False
        Me.GridView27.OptionsCustomization.AllowSort = False
        Me.GridView27.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView27.OptionsView.ShowColumnHeaders = False
        Me.GridView27.OptionsView.ShowGroupPanel = False
        Me.GridView27.OptionsView.ShowIndicator = False
        '
        'GridColumn59
        '
        Me.GridColumn59.FieldName = "ID"
        Me.GridColumn59.Name = "GridColumn59"
        '
        'GridColumn60
        '
        Me.GridColumn60.FieldName = "Comuna"
        Me.GridColumn60.Name = "GridColumn60"
        Me.GridColumn60.Visible = True
        Me.GridColumn60.VisibleIndex = 0
        '
        'LabelControl104
        '
        Me.LabelControl104.Location = New System.Drawing.Point(8, 56)
        Me.LabelControl104.Name = "LabelControl104"
        Me.LabelControl104.Size = New System.Drawing.Size(88, 13)
        Me.LabelControl104.TabIndex = 98
        Me.LabelControl104.Text = "¿Qué fue a hacer?"
        '
        'lkpPropositoAnterior
        '
        Me.lkpPropositoAnterior.EditValue = ""
        Me.lkpPropositoAnterior.Location = New System.Drawing.Point(102, 53)
        Me.lkpPropositoAnterior.Name = "lkpPropositoAnterior"
        Me.lkpPropositoAnterior.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.lkpPropositoAnterior.Properties.Appearance.Options.UseBackColor = True
        Me.lkpPropositoAnterior.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkpPropositoAnterior.Properties.DataSource = Me.PropositoBindingSource
        Me.lkpPropositoAnterior.Properties.DisplayMember = "Proposito"
        Me.lkpPropositoAnterior.Properties.ImmediatePopup = True
        Me.lkpPropositoAnterior.Properties.PopupFormMinSize = New System.Drawing.Size(141, 280)
        Me.lkpPropositoAnterior.Properties.PopupFormSize = New System.Drawing.Size(141, 280)
        Me.lkpPropositoAnterior.Properties.ReadOnly = True
        Me.lkpPropositoAnterior.Properties.ShowFooter = False
        Me.lkpPropositoAnterior.Properties.ValueMember = "ID"
        Me.lkpPropositoAnterior.Properties.View = Me.GridView28
        Me.lkpPropositoAnterior.Size = New System.Drawing.Size(145, 20)
        Me.lkpPropositoAnterior.TabIndex = 99
        '
        'GridView28
        '
        Me.GridView28.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn61, Me.GridColumn62})
        Me.GridView28.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView28.Name = "GridView28"
        Me.GridView28.OptionsCustomization.AllowFilter = False
        Me.GridView28.OptionsCustomization.AllowGroup = False
        Me.GridView28.OptionsCustomization.AllowSort = False
        Me.GridView28.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView28.OptionsView.ShowColumnHeaders = False
        Me.GridView28.OptionsView.ShowGroupPanel = False
        Me.GridView28.OptionsView.ShowIndicator = False
        '
        'GridColumn61
        '
        Me.GridColumn61.FieldName = "ID"
        Me.GridColumn61.Name = "GridColumn61"
        '
        'GridColumn62
        '
        Me.GridColumn62.FieldName = "Proposito"
        Me.GridColumn62.Name = "GridColumn62"
        Me.GridColumn62.OptionsColumn.AllowEdit = False
        Me.GridColumn62.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridColumn62.Visible = True
        Me.GridColumn62.VisibleIndex = 0
        '
        'LabelControl106
        '
        Me.LabelControl106.Location = New System.Drawing.Point(135, 29)
        Me.LabelControl106.Name = "LabelControl106"
        Me.LabelControl106.Size = New System.Drawing.Size(54, 13)
        Me.LabelControl106.TabIndex = 3
        Me.LabelControl106.Text = "Llegó a las:"
        '
        'LabelControl114
        '
        Me.LabelControl114.Location = New System.Drawing.Point(9, 29)
        Me.LabelControl114.Name = "LabelControl114"
        Me.LabelControl114.Size = New System.Drawing.Size(51, 13)
        Me.LabelControl114.TabIndex = 2
        Me.LabelControl114.Text = "Salió a las:"
        '
        'tmFinAnterior
        '
        Me.tmFinAnterior.EditValue = New Date(2016, 7, 6, 0, 0, 0, 0)
        Me.tmFinAnterior.Location = New System.Drawing.Point(195, 26)
        Me.tmFinAnterior.Name = "tmFinAnterior"
        Me.tmFinAnterior.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.tmFinAnterior.Properties.Appearance.Options.UseBackColor = True
        Me.tmFinAnterior.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.tmFinAnterior.Properties.Mask.EditMask = "t"
        Me.tmFinAnterior.Properties.ReadOnly = True
        Me.tmFinAnterior.Size = New System.Drawing.Size(52, 20)
        Me.tmFinAnterior.TabIndex = 1
        '
        'tmInicioAnterior
        '
        Me.tmInicioAnterior.EditValue = New Date(2016, 7, 6, 0, 0, 0, 0)
        Me.tmInicioAnterior.Location = New System.Drawing.Point(70, 25)
        Me.tmInicioAnterior.Name = "tmInicioAnterior"
        Me.tmInicioAnterior.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.tmInicioAnterior.Properties.Appearance.Options.UseBackColor = True
        Me.tmInicioAnterior.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.tmInicioAnterior.Properties.Mask.EditMask = "t"
        Me.tmInicioAnterior.Properties.ReadOnly = True
        Me.tmInicioAnterior.Size = New System.Drawing.Size(52, 20)
        Me.tmInicioAnterior.TabIndex = 0
        '
        'SiNoTableAdapter
        '
        Me.SiNoTableAdapter.ClearBeforeFill = True
        '
        'LugarPrimerViajeTableAdapter
        '
        Me.LugarPrimerViajeTableAdapter.ClearBeforeFill = True
        '
        'PropositoTableAdapter
        '
        Me.PropositoTableAdapter.ClearBeforeFill = True
        '
        'ComunaTableAdapter
        '
        Me.ComunaTableAdapter.ClearBeforeFill = True
        '
        'ModoTableAdapter
        '
        Me.ModoTableAdapter.ClearBeforeFill = True
        '
        'CallesTableAdapter
        '
        Me.CallesTableAdapter.ClearBeforeFill = True
        '
        'ConsultaCalle2BTableAdapter
        '
        Me.ConsultaCalle2BTableAdapter.ClearBeforeFill = True
        '
        'HitoTableAdapter
        '
        Me.HitoTableAdapter.ClearBeforeFill = True
        '
        'NoViajaTableAdapter
        '
        Me.NoViajaTableAdapter.ClearBeforeFill = True
        '
        'DondeSeBajoTableAdapter
        '
        Me.DondeSeBajoTableAdapter.ClearBeforeFill = True
        '
        'TipoTarifaTableAdapter
        '
        Me.TipoTarifaTableAdapter.ClearBeforeFill = True
        '
        'PropiedadBicicletaTableAdapter
        '
        Me.PropiedadBicicletaTableAdapter.ClearBeforeFill = True
        '
        'ViajaComoTableAdapter
        '
        Me.ViajaComoTableAdapter.ClearBeforeFill = True
        '
        'QueVehiculoTableAdapter
        '
        Me.QueVehiculoTableAdapter.ClearBeforeFill = True
        '
        'ResumenVehiculosTableAdapter
        '
        Me.ResumenVehiculosTableAdapter.ClearBeforeFill = True
        '
        'FormaPagoTableAdapter
        '
        Me.FormaPagoTableAdapter.ClearBeforeFill = True
        '
        'PagaEstacionamientoTableAdapter
        '
        Me.PagaEstacionamientoTableAdapter.ClearBeforeFill = True
        '
        'ValidaViajeTableAdapter
        '
        Me.ValidaViajeTableAdapter.ClearBeforeFill = True
        '
        'ValidaEtapaTableAdapter
        '
        Me.ValidaEtapaTableAdapter.ClearBeforeFill = True
        '
        'btnRechazoViaje
        '
        Me.btnRechazoViaje.Appearance.BackColor = System.Drawing.Color.Red
        Me.btnRechazoViaje.Appearance.BackColor2 = System.Drawing.Color.DarkRed
        Me.btnRechazoViaje.Appearance.BorderColor = System.Drawing.Color.DarkRed
        Me.btnRechazoViaje.Appearance.ForeColor = System.Drawing.Color.White
        Me.btnRechazoViaje.Appearance.Options.UseBackColor = True
        Me.btnRechazoViaje.Appearance.Options.UseBorderColor = True
        Me.btnRechazoViaje.Appearance.Options.UseForeColor = True
        Me.btnRechazoViaje.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
        Me.btnRechazoViaje.Location = New System.Drawing.Point(771, 518)
        Me.btnRechazoViaje.Name = "btnRechazoViaje"
        Me.btnRechazoViaje.Size = New System.Drawing.Size(128, 28)
        Me.btnRechazoViaje.TabIndex = 105
        Me.btnRechazoViaje.Text = "Rechazar encuesta"
        '
        'ValidaPersonaTableAdapter
        '
        Me.ValidaPersonaTableAdapter.ClearBeforeFill = True
        '
        'MetrotrenTableAdapter
        '
        Me.MetrotrenTableAdapter.ClearBeforeFill = True
        '
        'TerrasurTableAdapter
        '
        Me.TerrasurTableAdapter.ClearBeforeFill = True
        '
        'DefaultLookAndFeel3
        '
        Me.DefaultLookAndFeel3.EnableBonusSkins = True
        Me.DefaultLookAndFeel3.LookAndFeel.SkinName = "Office 2016 Colorful"
        '
        'ConsultaCalle2OrigenTableAdapter
        '
        Me.ConsultaCalle2OrigenTableAdapter.ClearBeforeFill = True
        '
        'ConsultaCalle2DestinoTableAdapter
        '
        Me.ConsultaCalle2DestinoTableAdapter.ClearBeforeFill = True
        '
        'ConsultaCalle2Etapa1TableAdapter
        '
        Me.ConsultaCalle2Etapa1TableAdapter.ClearBeforeFill = True
        '
        'ConsultaCalle2Etapa2TableAdapter
        '
        Me.ConsultaCalle2Etapa2TableAdapter.ClearBeforeFill = True
        '
        'ConsultaCalle2Etapa3TableAdapter
        '
        Me.ConsultaCalle2Etapa3TableAdapter.ClearBeforeFill = True
        '
        'MuelleTableAdapter
        '
        Me.MuelleTableAdapter.ClearBeforeFill = True
        '
        'DondeEstacionaTableAdapter
        '
        Me.DondeEstacionaTableAdapter.ClearBeforeFill = True
        '
        'EstacionamientoBicicletaTableAdapter
        '
        Me.EstacionamientoBicicletaTableAdapter.ClearBeforeFill = True
        '
        'IngresoViajes
        '
        Me.AllowFormGlass = DevExpress.Utils.DefaultBoolean.[True]
        Me.Appearance.BackColor = System.Drawing.Color.Black
        Me.Appearance.BackColor2 = System.Drawing.Color.White
        Me.Appearance.BorderColor = System.Drawing.Color.White
        Me.Appearance.Options.UseBackColor = True
        Me.Appearance.Options.UseBorderColor = True
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1015, 559)
        Me.Controls.Add(Me.btnRechazoViaje)
        Me.Controls.Add(Me.spcViaje)
        Me.Controls.Add(Me.tabsInicioViaje)
        Me.Controls.Add(Me.btnGuardarViaje)
        Me.Controls.Add(Me.panelFinViaje)
        Me.Controls.Add(Me.RibbonControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Font = New System.Drawing.Font("Trebuchet MS", 9.0!)
        Me.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "IngresoViajes"
        Me.Ribbon = Me.RibbonControl1
        Me.RibbonVisibility = DevExpress.XtraBars.Ribbon.RibbonVisibility.Hidden
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ingreso de viajes"
        CType(Me.tmHoraLlegada.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lkpTrasnoche.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.SiNoBindingSource, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.datasetEOD, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GridView8, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.tabsEtapas, System.ComponentModel.ISupportInitialize).EndInit
        Me.tabsEtapas.ResumeLayout(False)
        Me.tabTransporte1.ResumeLayout(False)
        CType(Me.gcLugarBajadaEtapa1, System.ComponentModel.ISupportInitialize).EndInit
        Me.gcLugarBajadaEtapa1.ResumeLayout(False)
        Me.gcLugarBajadaEtapa1.PerformLayout
        CType(Me.spcCallesEtapa1, System.ComponentModel.ISupportInitialize).EndInit
        Me.spcCallesEtapa1.ResumeLayout(False)
        CType(Me.txtComunaOtraEtapa1.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.x_etapa1.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.y_etapa1.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lkpManzanaEtapa1.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lkpCalle1Etapa1.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.CallesBindingSource, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GridView30, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lkpCalle2Etapa1.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ConsultaCalle2Etapa1BindingSource, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GridView31, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lkpHitoEtapa1.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.HitoBindingSource, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GridView32, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lkpComunaEtapa1.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ComunaBindingSource, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GridView29, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.tabsEtapa1, System.ComponentModel.ISupportInitialize).EndInit
        Me.tabsEtapa1.ResumeLayout(False)
        Me.tabTaxi.ResumeLayout(False)
        Me.tabTaxi.PerformLayout
        CType(Me.txtMinutosEsperaTaxiE1.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtCuadrasTaxiE1.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtTarifaMontoTaxiE1.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtMinutosTaxiE1.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lkpLugarBajadaTaxiE1.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.DondeSeBajoE1BindingSource, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GridView35, System.ComponentModel.ISupportInitialize).EndInit
        Me.tabAuto.ResumeLayout(False)
        Me.tabAuto.PerformLayout
        CType(Me.lkpVehHogarE1.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ResumenVehiculosBindingSource, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GridView19, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.panelPreguntasChofer, System.ComponentModel.ISupportInitialize).EndInit
        Me.panelPreguntasChofer.ResumeLayout(False)
        CType(Me.spcPagoBajadaAutoE1, System.ComponentModel.ISupportInitialize).EndInit
        Me.spcPagoBajadaAutoE1.ResumeLayout(False)
        CType(Me.spcFormaPagoE1, System.ComponentModel.ISupportInitialize).EndInit
        Me.spcFormaPagoE1.ResumeLayout(False)
        CType(Me.lkpFormaPagoE1.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.FormaPagoBindingSource, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GridView18, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lkpDondeEstacionaE1.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.DondeEstacionaBindingSource, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.DatasetEODBindingSource, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GridView17, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.spcPagoEstacionamientoE1, System.ComponentModel.ISupportInitialize).EndInit
        Me.spcPagoEstacionamientoE1.ResumeLayout(False)
        CType(Me.chkNSNRPagoE1.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TabFormDefaultManager1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtCuantoPagoE1.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lkpLugarBajadaAutoE1.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GridView16, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtMinutosAutoE1.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtCuadrasAutoE1.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lkpViajaComoE1.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ViajaComoBindingSource, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GridView15, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lkpQueVehiculoE1.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.QueVehiculoBindingSource, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GridView7, System.ComponentModel.ISupportInitialize).EndInit
        Me.tabBicicleta.ResumeLayout(False)
        Me.tabBicicleta.PerformLayout
        CType(Me.lkpLugarBajadaBiciE1.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GridView53, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.spcPropiedadBicicletaE1, System.ComponentModel.ISupportInitialize).EndInit
        Me.spcPropiedadBicicletaE1.ResumeLayout(False)
        CType(Me.txtPropiedadBicicletaOtraE1.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.spcMotivoNoUsaE1, System.ComponentModel.ISupportInitialize).EndInit
        Me.spcMotivoNoUsaE1.ResumeLayout(False)
        CType(Me.txtMotivoNoUsaE1.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lkpEstacionamientoBiciE1.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.EstacionamientoBicicletaBindingSource, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GridView37, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lkpCicloviaE1.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GridView26, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lkpPropiedadBicicletaE1.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PropiedadBicicletaBindingSource, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GridView25, System.ComponentModel.ISupportInitialize).EndInit
        Me.tabBus.ResumeLayout(False)
        Me.tabBus.PerformLayout
        CType(Me.txtMinutosEsperaBusE1.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.spcCuantoPagoBusE1, System.ComponentModel.ISupportInitialize).EndInit
        Me.spcCuantoPagoBusE1.ResumeLayout(False)
        CType(Me.txtTarifaMontoBusE1.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lkpLugarBajadaBusE1.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GridView34, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtMinutosBusE1.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtCuadrasBusE1.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lkpTipoTarifaBusE1.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TipoTarifaBindingSource, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GridView33, System.ComponentModel.ISupportInitialize).EndInit
        Me.tabTXC.ResumeLayout(False)
        Me.tabTXC.PerformLayout
        CType(Me.txtMinutosEsperaTXCE1.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtCuadrasTXCE1.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtTarifaMontoTXCE1.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtMinutosTXCE1.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lkpLugarBajadaTXCE1.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GridView64, System.ComponentModel.ISupportInitialize).EndInit
        Me.tabTransporte2.ResumeLayout(False)
        CType(Me.gcLugarBajadaEtapa2, System.ComponentModel.ISupportInitialize).EndInit
        Me.gcLugarBajadaEtapa2.ResumeLayout(False)
        Me.gcLugarBajadaEtapa2.PerformLayout
        CType(Me.spcCallesEtapa2, System.ComponentModel.ISupportInitialize).EndInit
        Me.spcCallesEtapa2.ResumeLayout(False)
        CType(Me.txtComunaOtraEtapa2.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.x_etapa2.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.y_etapa2.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lkpManzanaEtapa2.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lkpCalle1Etapa2.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GridView39, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lkpCalle2Etapa2.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ConsultaCalle2Etapa2BindingSource, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GridView40, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lkpHitoEtapa2.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GridView41, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lkpComunaEtapa2.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GridView42, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.tabsEtapa2, System.ComponentModel.ISupportInitialize).EndInit
        Me.tabsEtapa2.ResumeLayout(False)
        Me.tabTaxiE2.ResumeLayout(False)
        Me.tabTaxiE2.PerformLayout
        CType(Me.txtMinutosEsperaTaxiE2.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtCuadrasTaxiE2.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtTarifaMontoTaxiE2.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtMinutosTaxiE2.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lkpLugarBajadaTaxiE2.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.DondeSeBajoE2BindingSource, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GridView36, System.ComponentModel.ISupportInitialize).EndInit
        Me.tabAutoE2.ResumeLayout(False)
        Me.tabAutoE2.PerformLayout
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.spcPagoBajadaAutoE2, System.ComponentModel.ISupportInitialize).EndInit
        Me.spcPagoBajadaAutoE2.ResumeLayout(False)
        CType(Me.spcPagoEstacionamientoE2, System.ComponentModel.ISupportInitialize).EndInit
        Me.spcPagoEstacionamientoE2.ResumeLayout(False)
        CType(Me.chkNSNRPagoE2.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtCuantoPagoE2.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.spcFormaPagoE2, System.ComponentModel.ISupportInitialize).EndInit
        Me.spcFormaPagoE2.ResumeLayout(False)
        CType(Me.lkpFormaPagoE2.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GridView43, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lkpDondeEstacionaE2.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GridView59, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lkpLugarBajadaAutoE2.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GridView44, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lkpVehHogarE2.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GridView45, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtMinutosAutoE2.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtCuadrasAutoE2.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lkpViajaComoE2.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GridView47, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lkpQueVehiculoE2.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GridView48, System.ComponentModel.ISupportInitialize).EndInit
        Me.tabBicicletaE2.ResumeLayout(False)
        Me.tabBicicletaE2.PerformLayout
        CType(Me.spcPropiedadBicicletaE2, System.ComponentModel.ISupportInitialize).EndInit
        Me.spcPropiedadBicicletaE2.ResumeLayout(False)
        CType(Me.txtPropiedadBicicletaOtraE2.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.spcMotivoNoUsaE2, System.ComponentModel.ISupportInitialize).EndInit
        Me.spcMotivoNoUsaE2.ResumeLayout(False)
        CType(Me.txtMotivoNoUsaE2.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lkpEstacionamientoBiciE2.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GridView62, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lkpCicloviaE2.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GridView24, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lkpPropiedadBicicletaE2.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GridView49, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lkpLugarBajadaBiciE2.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GridView14, System.ComponentModel.ISupportInitialize).EndInit
        Me.tabBusE2.ResumeLayout(False)
        Me.tabBusE2.PerformLayout
        CType(Me.txtMinutosEsperaBusE2.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.spcCuantoPagoBusE2, System.ComponentModel.ISupportInitialize).EndInit
        Me.spcCuantoPagoBusE2.ResumeLayout(False)
        CType(Me.txtTarifaMontoBusE2.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lkpLugarBajadaBusE2.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GridView50, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtMinutosBusE2.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtCuadrasBusE2.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lkpTipoTarifaBusE2.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GridView51, System.ComponentModel.ISupportInitialize).EndInit
        Me.tabTXCE2.ResumeLayout(False)
        Me.tabTXCE2.PerformLayout
        CType(Me.txtTarifaMontoTXCE2.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtMinutosEsperaTXCE2.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtMinutosTXCE2.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtCuadrasTXCE2.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lkpLugarBajadaTXCE2.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GridView52, System.ComponentModel.ISupportInitialize).EndInit
        Me.tabTransporte3.ResumeLayout(False)
        CType(Me.gcLugarBajadaEtapa3, System.ComponentModel.ISupportInitialize).EndInit
        Me.gcLugarBajadaEtapa3.ResumeLayout(False)
        Me.gcLugarBajadaEtapa3.PerformLayout
        CType(Me.spcCallesEtapa3, System.ComponentModel.ISupportInitialize).EndInit
        Me.spcCallesEtapa3.ResumeLayout(False)
        CType(Me.txtComunaOtraEtapa3.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.x_etapa3.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.y_etapa3.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lkpManzanaEtapa3.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lkpCalle1Etapa3.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GridView46, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lkpCalle2Etapa3.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ConsultaCalle2Etapa3BindingSource, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GridView70, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lkpHitoEtapa3.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GridView71, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lkpComunaEtapa3.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GridView72, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.tabsEtapa3, System.ComponentModel.ISupportInitialize).EndInit
        Me.tabsEtapa3.ResumeLayout(False)
        Me.tabTaxiE3.ResumeLayout(False)
        Me.tabTaxiE3.PerformLayout
        CType(Me.txtMinutosEsperaTaxiE3.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtCuadrasTaxiE3.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtTarifaMontoTaxiE3.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtMinutosTaxiE3.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lkpLugarBajadaTaxiE3.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.DondeSeBajoE3BindingSource, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GridView38, System.ComponentModel.ISupportInitialize).EndInit
        Me.tabAutoE3.ResumeLayout(False)
        Me.tabAutoE3.PerformLayout
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.spcPagoBajadaAutoE3, System.ComponentModel.ISupportInitialize).EndInit
        Me.spcPagoBajadaAutoE3.ResumeLayout(False)
        CType(Me.spcPagoEstacionamientoE3, System.ComponentModel.ISupportInitialize).EndInit
        Me.spcPagoEstacionamientoE3.ResumeLayout(False)
        CType(Me.chkNSNRPagoE3.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtCuantoPagoE3.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.spcFormaPagoE3, System.ComponentModel.ISupportInitialize).EndInit
        Me.spcFormaPagoE3.ResumeLayout(False)
        CType(Me.lkpFormaPagoE3.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GridView56, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lkpDondeEstacionaE3.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GridView55, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lkpLugarBajadaAutoE3.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GridView57, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lkpVehHogarE3.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GridView58, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtMinutosAutoE3.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtCuadrasAutoE3.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lkpViajaComoE3.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GridView60, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lkpQueVehiculoE3.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GridView63, System.ComponentModel.ISupportInitialize).EndInit
        Me.tabBicicletaE3.ResumeLayout(False)
        Me.tabBicicletaE3.PerformLayout
        CType(Me.spcPropiedadBicicletaE3, System.ComponentModel.ISupportInitialize).EndInit
        Me.spcPropiedadBicicletaE3.ResumeLayout(False)
        CType(Me.txtPropiedadBicicletaOtraE3.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.spcMotivoNoUsaE3, System.ComponentModel.ISupportInitialize).EndInit
        Me.spcMotivoNoUsaE3.ResumeLayout(False)
        CType(Me.txtMotivoNoUsaE3.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lkpEstacionamientoBiciE3.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GridView69, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lkpCicloviaE3.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GridView23, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lkpPropiedadBicicletaE3.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GridView65, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lkpLugarBajadaBiciE3.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GridView54, System.ComponentModel.ISupportInitialize).EndInit
        Me.tabBusE3.ResumeLayout(False)
        Me.tabBusE3.PerformLayout
        CType(Me.txtMinutosEsperaBusE3.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.spcCuantoPagoBusE3, System.ComponentModel.ISupportInitialize).EndInit
        Me.spcCuantoPagoBusE3.ResumeLayout(False)
        CType(Me.txtTarifaMontoBusE3.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lkpLugarBajadaBusE3.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GridView66, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtMinutosBusE3.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtCuadrasBusE3.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lkpTipoTarifaBusE3.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GridView67, System.ComponentModel.ISupportInitialize).EndInit
        Me.tabTXCE3.ResumeLayout(False)
        Me.tabTXCE3.PerformLayout
        CType(Me.txtTarifaMontoTXCE3.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtMinutosEsperaTXCE3.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtMinutosTXCE3.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtCuadrasTXCE3.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lkpLugarBajadaTXCE3.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GridView68, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PagaEstacionamientoBindingSource, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.MuelleBajadaBindingSource, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.MuelleBindingSource, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.MetrotrenBindingSource, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TerrasurBindingSource, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lkpProposito.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PropositoBindingSource, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GridView9, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.tmHoraSalida.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.spDestinoViaje, System.ComponentModel.ISupportInitialize).EndInit
        Me.spDestinoViaje.ResumeLayout(False)
        CType(Me.txtOtroProposito.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.spLugarDeclarado, System.ComponentModel.ISupportInitialize).EndInit
        Me.spLugarDeclarado.ResumeLayout(False)
        CType(Me.lkpTrabajoDeclarado.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GridView21, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lkpEstudioDeclarado.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GridView73, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.spcCallesDestino, System.ComponentModel.ISupportInitialize).EndInit
        Me.spcCallesDestino.ResumeLayout(False)
        CType(Me.txtComunaDestinoOtra.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lkpCalle1Destino.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lkpHitoDestino.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lkpCalle2Destino.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ConsultaCalle2DestinoBindingSource, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lkpManzanaDestino.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lkpComunaDestino.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GridView11, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.spcViaje, System.ComponentModel.ISupportInitialize).EndInit
        Me.spcViaje.ResumeLayout(False)
        CType(Me.lkpTransporte1.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ModoBindingSource, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GridView10, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lkpTransporte2.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Modo2BindingSource, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GridView12, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lkpTransporte3.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Modo3BindingSource, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GridView13, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtCuadrasDespues.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.panelFinViaje, System.ComponentModel.ISupportInitialize).EndInit
        Me.panelFinViaje.ResumeLayout(False)
        Me.panelFinViaje.PerformLayout
        CType(Me.lkpOtroViaje.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GridView61, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.x_destino.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.y_destino.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.x_origen.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.y_origen.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtMinutosDespues.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.spcPrimerViaje, System.ComponentModel.ISupportInitialize).EndInit
        Me.spcPrimerViaje.ResumeLayout(False)
        CType(Me.spcCallesPrimerViaje, System.ComponentModel.ISupportInitialize).EndInit
        Me.spcCallesPrimerViaje.ResumeLayout(False)
        CType(Me.txtComunaOrigenOtra.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lkpCalle2Origen.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ConsultaCalle2OrigenBindingSource, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lkpCalle1Origen.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GridLookUpEdit2View, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lkpManzanaOrigen.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lkpHitoOrigen.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lkpComunaOrigen.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lkpDondePrimerViaje.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.LugarPrimerViajeBindingSource, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtNoViajaOtro.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lkpNoViaja.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.NoViajaBindingSource, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GridView22, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lkpRealizoViajes.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GridView20, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.spcRealizoViajes, System.ComponentModel.ISupportInitialize).EndInit
        Me.spcRealizoViajes.ResumeLayout(False)
        CType(Me.tabsInicioViaje, System.ComponentModel.ISupportInitialize).EndInit
        Me.tabsInicioViaje.ResumeLayout(False)
        Me.tabPrimerViaje.ResumeLayout(False)
        Me.tabViajeAnterior.ResumeLayout(False)
        CType(Me.gcViajeAnterior, System.ComponentModel.ISupportInitialize).EndInit
        Me.gcViajeAnterior.ResumeLayout(False)
        Me.gcViajeAnterior.PerformLayout
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.spCallesViajeAnterior, System.ComponentModel.ISupportInitialize).EndInit
        Me.spCallesViajeAnterior.ResumeLayout(False)
        CType(Me.txtComunaOtraAnterior.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtCalle1Anterior.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtCalle2Anterior.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtHitoAnterior.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtManzanaAnterior.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lkpComunaAnterior.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GridView27, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lkpPropositoAnterior.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GridView28, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.tmFinAnterior.Properties, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.tmInicioAnterior.Properties, System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(False)
        Me.PerformLayout

    End Sub
    Friend WithEvents DefaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents EstacionaTableAdapter As EOD.datasetEODTableAdapters.EstacionaTableAdapter
    Friend WithEvents cargaDatosViajeBackground As System.ComponentModel.BackgroundWorker
    Friend WithEvents lkpTrasnoche As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView8 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SplashScreenManager1 As DevExpress.XtraSplashScreen.SplashScreenManager
    Friend WithEvents LabelControl112 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents tmHoraLlegada As DevExpress.XtraEditors.TimeEdit
    Friend WithEvents DefaultLookAndFeel2 As DevExpress.LookAndFeel.DefaultLookAndFeel
    Friend WithEvents tabsEtapas As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents tabTransporte1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tabsEtapa1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents tabTaxi As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents LabelControl82 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl83 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl85 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCuadrasTaxiE1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtMinutosTaxiE1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl87 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl88 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl89 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTarifaMontoTaxiE1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl90 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtMinutosEsperaTaxiE1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents tabAuto As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents LabelControl19 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblLugarDondeBajoE1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lkpLugarBajadaAutoE1 As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView16 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtCuantoPagoE1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblCuantoPagoE1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl26 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lkpFormaPagoE1 As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView18 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl35 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl36 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtMinutosAutoE1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCuadrasAutoE1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl37 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl38 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl39 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lkpViajaComoE1 As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView15 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents tabBicicleta As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents gcLugarBajadaEtapa1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents spcCallesEtapa1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents lblComunaOtraEtapa1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtComunaOtraEtapa1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblManzanaEtapa1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblCalle1Etapa1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblCalle2Etapa1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblHitoEtapa1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lkpManzanaEtapa1 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblComunaEtapa1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl48 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents tabBus As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents txtMinutosEsperaBusE1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents spcCuantoPagoBusE1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents txtTarifaMontoBusE1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl53 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl60 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl61 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl66 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl67 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtMinutosBusE1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCuadrasBusE1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl68 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl69 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl70 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents tabTransporte2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tabTransporte3 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents lkpProposito As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView9 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colID5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProposito As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tmHoraSalida As DevExpress.XtraEditors.TimeEdit
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents spDestinoViaje As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents txtOtroProposito As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblOtroProposito As DevExpress.XtraEditors.LabelControl
    Friend WithEvents spcCallesDestino As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents txtComunaDestinoOtra As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblComunaDestinoOtra As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl24 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lkpCalle1Destino As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents lkpHitoDestino As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView5 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents lkpCalle2Destino As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView6 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lkpComunaDestino As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView11 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents spcViaje As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents LabelControl115 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCuadrasDespues As DevExpress.XtraEditors.TextEdit
    Friend WithEvents colID8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colComuna1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents panelFinViaje As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnGuardarViaje As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents colid13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcalle As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colId15 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colViajaComo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colid14 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colhito1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colhitoManzana1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkpManzanaDestino As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents colID16 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcalle11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcalle2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colID18 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLugarDondeBajo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colID20 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFormaPago As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colId25 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOpcion1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkpCalle1Etapa1 As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView30 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colid31 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcalle4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkpCalle2Etapa1 As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView31 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colID32 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcalle14 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcalle23 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colconflictiva2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkpHitoEtapa1 As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView32 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colid33 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colhito3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colhitoManzana3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkpComunaEtapa1 As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView29 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colID30 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colComuna3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkpPropiedadBicicletaE1 As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView25 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colID26 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPropiedadBicicleta As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents panelPreguntasChofer As DevExpress.XtraEditors.PanelControl
    Friend WithEvents lkpQueVehiculoE1 As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView7 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colId21 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQueVehiculo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkpVehHogarE1 As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView19 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colvehiculo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkpTipoTarifaBusE1 As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView33 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colID24 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTipoTarifaBus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkpLugarBajadaBusE1 As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView34 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colId34 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDondeSeBajo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkpLugarBajadaTaxiE1 As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView35 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colId35 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDondeSeBajo1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtMinutosDespues As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl20 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents gcLugarBajadaEtapa2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents spcCallesEtapa2 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents LabelControl25 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtComunaOtraEtapa2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl29 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl30 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl31 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl32 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lkpManzanaEtapa2 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lkpCalle1Etapa2 As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView39 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkpCalle2Etapa2 As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView40 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkpHitoEtapa2 As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView41 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl33 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lkpComunaEtapa2 As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView42 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl136 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl138 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents x_etapa1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents y_etapa1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl116 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl105 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl59 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl55 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents x_destino As DevExpress.XtraEditors.TextEdit
    Friend WithEvents y_destino As DevExpress.XtraEditors.TextEdit
    Friend WithEvents x_origen As DevExpress.XtraEditors.TextEdit
    Friend WithEvents y_origen As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl145 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl146 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents x_etapa2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents y_etapa2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TabFormDefaultManager1 As DevExpress.XtraBars.TabFormDefaultManager
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents lkpOtroViaje As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView61 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn49 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn50 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl63 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents spcRealizoViajes As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents LabelControl16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lkpRealizoViajes As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView20 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colId2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOpcion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents spcPrimerViaje As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents LabelControl21 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents spcCallesPrimerViaje As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents lblComunaOrigenOtra As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtComunaOrigenOtra As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lkpCalle2Origen As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colID17 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcalle12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcalle21 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colconflictiva As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lkpCalle1Origen As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit2View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colid1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcalle1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lkpManzanaOrigen As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lkpHitoOrigen As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colhito As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colhitoManzana As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblComunaOrigen As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lkpComunaOrigen As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colID4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colComuna As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkpDondePrimerViaje As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colId3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLugarPrimerViaje As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lblNoViajaOtro As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNoViajaOtro As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl22 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lkpNoViaja As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView22 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colID7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNoViaja As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents spcPagoBajadaAutoE1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents spcPagoEstacionamientoE1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents tabsInicioViaje As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents tabPrimerViaje As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tabViajeAnterior As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents gcViajeAnterior As DevExpress.XtraEditors.GroupControl
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl46 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents spCallesViajeAnterior As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents txtComunaOtraAnterior As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl47 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl49 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl50 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl51 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl52 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl65 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lkpComunaAnterior As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView27 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn59 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn60 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl104 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lkpPropositoAnterior As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView28 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn61 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn62 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl106 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl114 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents tmFinAnterior As DevExpress.XtraEditors.TimeEdit
    Friend WithEvents tmInicioAnterior As DevExpress.XtraEditors.TimeEdit
    Friend WithEvents LabelControl147 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblTransporte3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblTransporte2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lkpTransporte1 As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView10 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colID9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkpTransporte2 As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView12 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colID12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModo3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkpTransporte3 As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView13 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colID10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModo1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl148 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents tabsEtapa2 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents tabTaxiE2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents LabelControl40 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl41 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtMinutosEsperaTaxiE2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl42 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCuadrasTaxiE2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTarifaMontoTaxiE2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtMinutosTaxiE2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl43 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl44 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lkpLugarBajadaTaxiE2 As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView36 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tabAutoE2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents spcPagoBajadaAutoE2 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents spcPagoEstacionamientoE2 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents txtCuantoPagoE2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lkpFormaPagoE2 As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView43 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn14 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn15 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lblCuantoPagoE2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl58 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lkpLugarBajadaAutoE2 As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView44 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn16 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn17 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl62 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lkpVehHogarE2 As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView45 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl84 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl86 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtMinutosAutoE2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCuadrasAutoE2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl91 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl92 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl93 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lkpViajaComoE2 As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView47 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn21 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn22 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkpQueVehiculoE2 As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView48 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn23 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn24 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tabBicicletaE2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents LabelControl94 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lkpPropiedadBicicletaE2 As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView49 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn25 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn26 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tabBusE2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents txtMinutosEsperaBusE2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents spcCuantoPagoBusE2 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents txtTarifaMontoBusE2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl95 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl96 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lkpLugarBajadaBusE2 As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView50 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn27 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn28 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl97 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl98 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl99 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtMinutosBusE2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCuadrasBusE2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl100 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl103 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl117 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lkpTipoTarifaBusE2 As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView51 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn29 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn30 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tabTXCE2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents LabelControl129 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTarifaMontoTXCE2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtMinutosEsperaTXCE2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl130 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl131 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl132 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtMinutosTXCE2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCuadrasTXCE2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl133 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl134 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl135 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lkpLugarBajadaTXCE2 As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView52 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn31 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn32 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl137 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lkpLugarBajadaBiciE1 As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView53 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn33 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn34 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tabsEtapa3 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents tabTaxiE3 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents LabelControl72 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl73 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtMinutosEsperaTaxiE3 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl74 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCuadrasTaxiE3 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTarifaMontoTaxiE3 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtMinutosTaxiE3 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl75 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl76 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lkpLugarBajadaTaxiE3 As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView38 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn37 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn38 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tabAutoE3 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents spcPagoBajadaAutoE3 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents spcPagoEstacionamientoE3 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents txtCuantoPagoE3 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lkpFormaPagoE3 As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView56 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn39 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn40 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl80 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl81 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lkpLugarBajadaAutoE3 As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView57 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn41 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn42 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl101 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lkpVehHogarE3 As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView58 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn43 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl107 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl108 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtMinutosAutoE3 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCuadrasAutoE3 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl109 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl110 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl111 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lkpViajaComoE3 As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView60 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn46 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn47 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkpQueVehiculoE3 As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView63 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn48 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn63 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tabBicicletaE3 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents LabelControl141 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lkpPropiedadBicicletaE3 As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView65 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn66 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn67 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tabBusE3 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents txtMinutosEsperaBusE3 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents spcCuantoPagoBusE3 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents txtTarifaMontoBusE3 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl142 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl143 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lkpLugarBajadaBusE3 As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView66 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn68 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn69 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl144 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl149 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl150 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtMinutosBusE3 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCuadrasBusE3 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl151 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl152 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl153 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lkpTipoTarifaBusE3 As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView67 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn70 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn71 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tabTXCE3 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents LabelControl165 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTarifaMontoTXCE3 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtMinutosEsperaTXCE3 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl166 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl167 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl168 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtMinutosTXCE3 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCuadrasTXCE3 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl169 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl170 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl171 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lkpLugarBajadaTXCE3 As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView68 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn72 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn73 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents spcPropiedadBicicletaE1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents txtPropiedadBicicletaOtraE1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblPropiedadBiciOtraE1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents spcPropiedadBicicletaE2 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents txtPropiedadBicicletaOtraE2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblPropiedadBiciOtraE2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl172 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lkpLugarBajadaBiciE2 As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView14 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn74 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn75 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents spcPropiedadBicicletaE3 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents txtPropiedadBicicletaOtraE3 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblPropiedadBiciOtraE3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl140 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lkpLugarBajadaBiciE3 As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView54 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn35 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn36 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl23 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents tabTXC As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl113 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl173 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtMinutosEsperaTXCE1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl174 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCuadrasTXCE1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTarifaMontoTXCE1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtMinutosTXCE1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl175 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl176 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl177 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lkpLugarBajadaTXCE1 As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView64 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn76 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn77 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PersonaTableAdapter As EOD.datasetEODTableAdapters.PersonaTableAdapter
    Friend WithEvents ActividadTableAdapter As EOD.datasetEODTableAdapters.ActividadTableAdapter
    Friend WithEvents gcLugarBajadaEtapa3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents spcCallesEtapa3 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtComunaOtraEtapa3 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl17 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl118 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents x_etapa3 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents y_etapa3 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl119 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl120 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl121 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl122 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lkpManzanaEtapa3 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lkpCalle1Etapa3 As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView46 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn80 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn81 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkpCalle2Etapa3 As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView70 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn82 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn83 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn84 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn85 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkpHitoEtapa3 As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView71 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn86 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn87 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn88 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl123 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lkpComunaEtapa3 As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView72 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn89 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn90 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ViajeTableAdapter As EOD.datasetEODTableAdapters.ViajeTableAdapter
    Friend WithEvents EtapaTableAdapter As EOD.datasetEODTableAdapters.EtapaTableAdapter
    Friend WithEvents spLugarDeclarado As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents lkpTrabajoDeclarado As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView21 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn64 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn65 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lblTrabajoDeclarado As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lkpEstudioDeclarado As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView73 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn91 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn92 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lblEstudioDeclarado As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCalle1Anterior As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCalle2Anterior As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtHitoAnterior As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtManzanaAnterior As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SplashScreenManager2 As DevExpress.XtraSplashScreen.SplashScreenManager
    Friend WithEvents datasetEOD As EOD.datasetEOD
    Friend WithEvents SiNoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SiNoTableAdapter As EOD.datasetEODTableAdapters.SiNoTableAdapter
    Friend WithEvents LugarPrimerViajeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LugarPrimerViajeTableAdapter As EOD.datasetEODTableAdapters.LugarPrimerViajeTableAdapter
    Friend WithEvents PropositoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PropositoTableAdapter As EOD.datasetEODTableAdapters.PropositoTableAdapter
    Friend WithEvents ComunaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ComunaTableAdapter As EOD.datasetEODTableAdapters.ComunaTableAdapter
    Friend WithEvents ModoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ModoTableAdapter As EOD.datasetEODTableAdapters.ModoTableAdapter
    Friend WithEvents CallesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CallesTableAdapter As EOD.datasetEODTableAdapters.CallesTableAdapter
    Friend WithEvents ConsultaCalle2BTableAdapter As EOD.datasetEODTableAdapters.ConsultaCalle2BTableAdapter
    Friend WithEvents HitoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents HitoTableAdapter As EOD.datasetEODTableAdapters.HitoTableAdapter
    Friend WithEvents Modo2BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Modo3BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents NoViajaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents NoViajaTableAdapter As EOD.datasetEODTableAdapters.NoViajaTableAdapter
    Friend WithEvents DondeSeBajoE1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DondeSeBajoTableAdapter As EOD.datasetEODTableAdapters.DondeSeBajoTableAdapter
    Friend WithEvents TipoTarifaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TipoTarifaTableAdapter As EOD.datasetEODTableAdapters.TipoTarifaTableAdapter
    Friend WithEvents PropiedadBicicletaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PropiedadBicicletaTableAdapter As EOD.datasetEODTableAdapters.PropiedadBicicletaTableAdapter
    Friend WithEvents ViajaComoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ViajaComoTableAdapter As EOD.datasetEODTableAdapters.ViajaComoTableAdapter
    Friend WithEvents QueVehiculoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents QueVehiculoTableAdapter As EOD.datasetEODTableAdapters.QueVehiculoTableAdapter
    Friend WithEvents ResumenVehiculosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ResumenVehiculosTableAdapter As EOD.datasetEODTableAdapters.ResumenVehiculosTableAdapter
    Friend WithEvents FormaPagoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FormaPagoTableAdapter As EOD.datasetEODTableAdapters.FormaPagoTableAdapter
    Friend WithEvents PagaEstacionamientoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PagaEstacionamientoTableAdapter As EOD.datasetEODTableAdapters.PagaEstacionamientoTableAdapter
    Friend WithEvents DondeSeBajoE2BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DondeSeBajoE3BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ValidaViajeTableAdapter As EOD.datasetEODTableAdapters.ValidaViajeTableAdapter
    Friend WithEvents ValidaEtapaTableAdapter As EOD.datasetEODTableAdapters.ValidaEtapaTableAdapter
    Friend WithEvents btnRechazoViaje As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SplashScreenManager3 As DevExpress.XtraSplashScreen.SplashScreenManager
    Friend WithEvents chkNSNRPagoE1 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkNSNRPagoE2 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkNSNRPagoE3 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ValidaPersonaTableAdapter As EOD.datasetEODTableAdapters.ValidaPersonaTableAdapter
    Friend WithEvents LabelControl57 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lkpCicloviaE1 As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView26 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn51 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn52 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl28 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lkpCicloviaE2 As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView24 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn44 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn45 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl18 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lkpCicloviaE3 As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView23 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn19 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn20 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DatasetEODBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MetrotrenBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MetrotrenTableAdapter As EOD.datasetEODTableAdapters.MetrotrenTableAdapter
    Friend WithEvents TerrasurBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TerrasurTableAdapter As EOD.datasetEODTableAdapters.TerrasurTableAdapter
    Friend WithEvents colCombustible As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCombustible1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCombustible2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl207 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl208 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl209 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl212 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl216 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl214 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl217 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl221 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl219 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DefaultLookAndFeel3 As DevExpress.LookAndFeel.DefaultLookAndFeel
    Friend WithEvents colvehiculo1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ConsultaCalle2OrigenBindingSource As BindingSource
    Friend WithEvents ConsultaCalle2OrigenTableAdapter As datasetEODTableAdapters.ConsultaCalle2OrigenTableAdapter
    Friend WithEvents ConsultaCalle2DestinoBindingSource As BindingSource
    Friend WithEvents ConsultaCalle2DestinoTableAdapter As datasetEODTableAdapters.ConsultaCalle2DestinoTableAdapter
    Friend WithEvents ConsultaCalle2Etapa1BindingSource As BindingSource
    Friend WithEvents ConsultaCalle2Etapa1TableAdapter As datasetEODTableAdapters.ConsultaCalle2Etapa1TableAdapter
    Friend WithEvents ConsultaCalle2Etapa2BindingSource As BindingSource
    Friend WithEvents ConsultaCalle2Etapa2TableAdapter As datasetEODTableAdapters.ConsultaCalle2Etapa2TableAdapter
    Friend WithEvents ConsultaCalle2Etapa3BindingSource As BindingSource
    Friend WithEvents ConsultaCalle2Etapa3TableAdapter As datasetEODTableAdapters.ConsultaCalle2Etapa3TableAdapter
    Friend WithEvents MuelleBindingSource As BindingSource
    Friend WithEvents MuelleTableAdapter As datasetEODTableAdapters.MuelleTableAdapter
    Friend WithEvents MuelleBajadaBindingSource As BindingSource
    Friend WithEvents spcFormaPagoE1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents lkpDondeEstacionaE1 As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView17 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn18 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn53 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl27 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DondeEstacionaBindingSource As BindingSource
    Friend WithEvents DondeEstacionaTableAdapter As datasetEODTableAdapters.DondeEstacionaTableAdapter
    Friend WithEvents spcFormaPagoE2 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents LabelControl54 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lkpDondeEstacionaE2 As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView59 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn56 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn57 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl64 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents spcFormaPagoE3 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents LabelControl56 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lkpDondeEstacionaE3 As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView55 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn58 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn78 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl78 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents spcMotivoNoUsaE1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents txtMotivoNoUsaE1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl79 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lkpEstacionamientoBiciE1 As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView37 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn54 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn55 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl102 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents EstacionamientoBicicletaBindingSource As BindingSource
    Friend WithEvents EstacionamientoBicicletaTableAdapter As datasetEODTableAdapters.EstacionamientoBicicletaTableAdapter
    Friend WithEvents spcMotivoNoUsaE2 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents txtMotivoNoUsaE2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl124 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lkpEstacionamientoBiciE2 As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView62 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn79 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn93 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl125 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents spcMotivoNoUsaE3 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents txtMotivoNoUsaE3 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl126 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lkpEstacionamientoBiciE3 As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridView69 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn94 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn95 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl127 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl34 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl45 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl71 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl77 As DevExpress.XtraEditors.LabelControl
End Class
