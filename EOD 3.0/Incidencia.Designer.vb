<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Incidencia
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
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.lkpTipoIncidencia = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.TipoIncidenciaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.datasetEOD = New EOD.datasetEOD()
        Me.GridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.btnCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.TipoIncidenciaTableAdapter = New EOD.datasetEODTableAdapters.TipoIncidenciaTableAdapter()
        Me.txtDescripcion = New DevExpress.XtraEditors.MemoEdit()
        Me.IncidenciaTableAdapter = New EOD.datasetEODTableAdapters.IncidenciaTableAdapter()
        Me.IncidenciaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.colTipoIncidencia = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkpTipoIncidencia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TipoIncidenciaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.datasetEOD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescripcion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IncidenciaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonControl
        '
        Me.RibbonControl.ExpandCollapseItem.Id = 0
        Me.RibbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl.ExpandCollapseItem})
        Me.RibbonControl.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl.MaxItemId = 1
        Me.RibbonControl.Name = "RibbonControl"
        Me.RibbonControl.Size = New System.Drawing.Size(302, 32)
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(12, 48)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(221, 13)
        Me.LabelControl1.TabIndex = 2
        Me.LabelControl1.Text = "Indique qué tipo de incidencia desea reportar:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(12, 99)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(238, 13)
        Me.LabelControl2.TabIndex = 3
        Me.LabelControl2.Text = "Describa el problema con el mayor detalle posible:"
        '
        'lkpTipoIncidencia
        '
        Me.lkpTipoIncidencia.EditValue = ""
        Me.lkpTipoIncidencia.Location = New System.Drawing.Point(12, 67)
        Me.lkpTipoIncidencia.MenuManager = Me.RibbonControl
        Me.lkpTipoIncidencia.Name = "lkpTipoIncidencia"
        Me.lkpTipoIncidencia.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkpTipoIncidencia.Properties.DataSource = Me.TipoIncidenciaBindingSource
        Me.lkpTipoIncidencia.Properties.DisplayMember = "TipoIncidencia"
        Me.lkpTipoIncidencia.Properties.PopupFormMinSize = New System.Drawing.Size(270, 120)
        Me.lkpTipoIncidencia.Properties.PopupFormSize = New System.Drawing.Size(270, 120)
        Me.lkpTipoIncidencia.Properties.ShowFooter = False
        Me.lkpTipoIncidencia.Properties.ValueMember = "Id"
        Me.lkpTipoIncidencia.Properties.View = Me.GridLookUpEdit1View
        Me.lkpTipoIncidencia.Size = New System.Drawing.Size(270, 20)
        Me.lkpTipoIncidencia.TabIndex = 1
        '
        'TipoIncidenciaBindingSource
        '
        Me.TipoIncidenciaBindingSource.DataMember = "TipoIncidencia"
        Me.TipoIncidenciaBindingSource.DataSource = Me.datasetEOD
        '
        'datasetEOD
        '
        Me.datasetEOD.DataSetName = "datasetEOD"
        Me.datasetEOD.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridLookUpEdit1View
        '
        Me.GridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colTipoIncidencia})
        Me.GridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridLookUpEdit1View.Name = "GridLookUpEdit1View"
        Me.GridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridLookUpEdit1View.OptionsView.ShowGroupPanel = False
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
        Me.btnCancelar.Location = New System.Drawing.Point(197, 257)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(85, 28)
        Me.btnCancelar.TabIndex = 4
        Me.btnCancelar.Text = "Cancelar"
        '
        'btnGuardar
        '
        Me.btnGuardar.Appearance.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnGuardar.Appearance.BackColor2 = System.Drawing.SystemColors.HotTrack
        Me.btnGuardar.Appearance.BorderColor = System.Drawing.SystemColors.HotTrack
        Me.btnGuardar.Appearance.ForeColor = System.Drawing.Color.White
        Me.btnGuardar.Appearance.Options.UseBackColor = True
        Me.btnGuardar.Appearance.Options.UseBorderColor = True
        Me.btnGuardar.Appearance.Options.UseForeColor = True
        Me.btnGuardar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
        Me.btnGuardar.Location = New System.Drawing.Point(106, 257)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(85, 28)
        Me.btnGuardar.TabIndex = 3
        Me.btnGuardar.Text = "Guardar"
        '
        'TipoIncidenciaTableAdapter
        '
        Me.TipoIncidenciaTableAdapter.ClearBeforeFill = True
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(12, 118)
        Me.txtDescripcion.MenuManager = Me.RibbonControl
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(270, 123)
        Me.txtDescripcion.TabIndex = 2
        '
        'IncidenciaTableAdapter
        '
        Me.IncidenciaTableAdapter.ClearBeforeFill = True
        '
        'IncidenciaBindingSource
        '
        Me.IncidenciaBindingSource.DataMember = "Incidencia"
        Me.IncidenciaBindingSource.DataSource = Me.datasetEOD
        '
        'colTipoIncidencia
        '
        Me.colTipoIncidencia.FieldName = "TipoIncidencia"
        Me.colTipoIncidencia.Name = "colTipoIncidencia"
        Me.colTipoIncidencia.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[False]
        Me.colTipoIncidencia.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colTipoIncidencia.OptionsColumn.ShowCaption = False
        Me.colTipoIncidencia.SortMode = DevExpress.XtraGrid.ColumnSortMode.Value
        Me.colTipoIncidencia.Visible = True
        Me.colTipoIncidencia.VisibleIndex = 0
        '
        'Incidencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(302, 301)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.lkpTipoIncidencia)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.RibbonControl)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Incidencia"
        Me.Ribbon = Me.RibbonControl
        Me.RibbonVisibility = DevExpress.XtraBars.Ribbon.RibbonVisibility.Hidden
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Reportar incidencia"
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkpTipoIncidencia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TipoIncidenciaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.datasetEOD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescripcion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IncidenciaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lkpTipoIncidencia As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents GridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btnCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents datasetEOD As EOD.datasetEOD
    Friend WithEvents TipoIncidenciaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TipoIncidenciaTableAdapter As EOD.datasetEODTableAdapters.TipoIncidenciaTableAdapter
    Friend WithEvents txtDescripcion As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents IncidenciaTableAdapter As EOD.datasetEODTableAdapters.IncidenciaTableAdapter
    Friend WithEvents IncidenciaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents colTipoIncidencia As DevExpress.XtraGrid.Columns.GridColumn


End Class
