<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmGraficoVenta
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim XyDiagram1 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
        Dim Series1 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmGraficoVenta))
        Me.ChartControl1 = New DevExpress.XtraCharts.ChartControl()
        Me.Sp_GraficoVentasTableAdapter = New MamiManda.dsBakerySystemTableAdapters.Sp_GraficoVentasTableAdapter()
        Me.SpGraficoVentasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsBakerySystem = New MamiManda.dsBakerySystem()
        Me.DateEdit1 = New DevExpress.XtraEditors.DateEdit()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.ChartControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(XyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpGraficoVentasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsBakerySystem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ChartControl1
        '
        Me.ChartControl1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ChartControl1.DataAdapter = Me.Sp_GraficoVentasTableAdapter
        Me.ChartControl1.DataSource = Me.SpGraficoVentasBindingSource
        XyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
        XyDiagram1.AxisY.Interlaced = True
        XyDiagram1.AxisY.MinorCount = 4
        XyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
        Me.ChartControl1.Diagram = XyDiagram1
        Me.ChartControl1.Legend.Name = "Default Legend"
        Me.ChartControl1.Location = New System.Drawing.Point(13, 62)
        Me.ChartControl1.Name = "ChartControl1"
        Series1.ArgumentDataMember = "Mes"
        Series1.LegendTextPattern = "{A} : {V}"
        Series1.Name = "Meses"
        Series1.ValueDataMembersSerializable = "Total"
        Me.ChartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series1}
        Me.ChartControl1.Size = New System.Drawing.Size(754, 413)
        Me.ChartControl1.TabIndex = 0
        '
        'Sp_GraficoVentasTableAdapter
        '
        Me.Sp_GraficoVentasTableAdapter.ClearBeforeFill = True
        '
        'SpGraficoVentasBindingSource
        '
        Me.SpGraficoVentasBindingSource.DataMember = "Sp_GraficoVentas"
        Me.SpGraficoVentasBindingSource.DataSource = Me.DsBakerySystem
        '
        'DsBakerySystem
        '
        Me.DsBakerySystem.DataSetName = "dsBakerySystem"
        Me.DsBakerySystem.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DateEdit1
        '
        Me.DateEdit1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DateEdit1.EditValue = New Date(2018, 4, 17, 19, 15, 9, 399)
        Me.DateEdit1.Location = New System.Drawing.Point(209, 29)
        Me.DateEdit1.Name = "DateEdit1"
        Me.DateEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit1.Size = New System.Drawing.Size(123, 20)
        Me.DateEdit1.TabIndex = 1
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(443, 22)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(122, 34)
        Me.SimpleButton1.TabIndex = 2
        Me.SimpleButton1.Text = "Vista Previa"
        '
        'FrmGraficoVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(778, 487)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.DateEdit1)
        Me.Controls.Add(Me.ChartControl1)
        Me.Name = "FrmGraficoVenta"
        Me.Text = "Reporte Grafico de Ventas Mensuales"
        CType(XyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpGraficoVentasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsBakerySystem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ChartControl1 As DevExpress.XtraCharts.ChartControl
    Friend WithEvents DateEdit1 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Sp_GraficoVentasTableAdapter As dsBakerySystemTableAdapters.Sp_GraficoVentasTableAdapter
    Friend WithEvents SpGraficoVentasBindingSource As BindingSource
    Friend WithEvents DsBakerySystem As dsBakerySystem
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
End Class
