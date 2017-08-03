<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReporteMateriaPrima
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmReporteMateriaPrima))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdMateriaPrimaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreMateriaPrimaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExistenciaMinimaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExistenciaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioCostoMDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RTNProveedorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MedidaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MateriaPrimaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsBakerySystem = New MamiManda.dsBakerySystem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.TxtID = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MateriaPrimaTableAdapter = New MamiManda.dsBakerySystemTableAdapters.MateriaPrimaTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MateriaPrimaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsBakerySystem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdMateriaPrimaDataGridViewTextBoxColumn, Me.NombreMateriaPrimaDataGridViewTextBoxColumn, Me.ExistenciaMinimaDataGridViewTextBoxColumn, Me.ExistenciaDataGridViewTextBoxColumn, Me.PrecioCostoMDataGridViewTextBoxColumn, Me.FechaDataGridViewTextBoxColumn, Me.RTNProveedorDataGridViewTextBoxColumn, Me.MedidaDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.MateriaPrimaBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 124)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(844, 209)
        Me.DataGridView1.TabIndex = 0
        '
        'IdMateriaPrimaDataGridViewTextBoxColumn
        '
        Me.IdMateriaPrimaDataGridViewTextBoxColumn.DataPropertyName = "IdMateriaPrima"
        Me.IdMateriaPrimaDataGridViewTextBoxColumn.HeaderText = "IdMateriaPrima"
        Me.IdMateriaPrimaDataGridViewTextBoxColumn.Name = "IdMateriaPrimaDataGridViewTextBoxColumn"
        Me.IdMateriaPrimaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NombreMateriaPrimaDataGridViewTextBoxColumn
        '
        Me.NombreMateriaPrimaDataGridViewTextBoxColumn.DataPropertyName = "NombreMateriaPrima"
        Me.NombreMateriaPrimaDataGridViewTextBoxColumn.HeaderText = "NombreMateriaPrima"
        Me.NombreMateriaPrimaDataGridViewTextBoxColumn.Name = "NombreMateriaPrimaDataGridViewTextBoxColumn"
        '
        'ExistenciaMinimaDataGridViewTextBoxColumn
        '
        Me.ExistenciaMinimaDataGridViewTextBoxColumn.DataPropertyName = "ExistenciaMinima"
        Me.ExistenciaMinimaDataGridViewTextBoxColumn.HeaderText = "ExistenciaMinima"
        Me.ExistenciaMinimaDataGridViewTextBoxColumn.Name = "ExistenciaMinimaDataGridViewTextBoxColumn"
        '
        'ExistenciaDataGridViewTextBoxColumn
        '
        Me.ExistenciaDataGridViewTextBoxColumn.DataPropertyName = "Existencia"
        Me.ExistenciaDataGridViewTextBoxColumn.HeaderText = "Existencia"
        Me.ExistenciaDataGridViewTextBoxColumn.Name = "ExistenciaDataGridViewTextBoxColumn"
        '
        'PrecioCostoMDataGridViewTextBoxColumn
        '
        Me.PrecioCostoMDataGridViewTextBoxColumn.DataPropertyName = "PrecioCostoM"
        Me.PrecioCostoMDataGridViewTextBoxColumn.HeaderText = "PrecioCostoM"
        Me.PrecioCostoMDataGridViewTextBoxColumn.Name = "PrecioCostoMDataGridViewTextBoxColumn"
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        '
        'RTNProveedorDataGridViewTextBoxColumn
        '
        Me.RTNProveedorDataGridViewTextBoxColumn.DataPropertyName = "RTNProveedor"
        Me.RTNProveedorDataGridViewTextBoxColumn.HeaderText = "RTNProveedor"
        Me.RTNProveedorDataGridViewTextBoxColumn.Name = "RTNProveedorDataGridViewTextBoxColumn"
        '
        'MedidaDataGridViewTextBoxColumn
        '
        Me.MedidaDataGridViewTextBoxColumn.DataPropertyName = "Medida"
        Me.MedidaDataGridViewTextBoxColumn.HeaderText = "Medida"
        Me.MedidaDataGridViewTextBoxColumn.Name = "MedidaDataGridViewTextBoxColumn"
        '
        'MateriaPrimaBindingSource
        '
        Me.MateriaPrimaBindingSource.DataMember = "MateriaPrima"
        Me.MateriaPrimaBindingSource.DataSource = Me.DsBakerySystem
        '
        'DsBakerySystem
        '
        Me.DsBakerySystem.DataSetName = "dsBakerySystem"
        Me.DsBakerySystem.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(325, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Id Materia Prima"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Location = New System.Drawing.Point(151, 40)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(167, 59)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Generar reporte por:"
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(98, 27)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(62, 17)
        Me.RadioButton2.TabIndex = 5
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "General"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(18, 26)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(74, 17)
        Me.RadioButton1.TabIndex = 4
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Especifico"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'TxtID
        '
        Me.TxtID.Enabled = False
        Me.TxtID.Location = New System.Drawing.Point(418, 63)
        Me.TxtID.Name = "TxtID"
        Me.TxtID.Size = New System.Drawing.Size(151, 20)
        Me.TxtID.TabIndex = 17
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(575, 54)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(126, 36)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Generar Reporte"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'MateriaPrimaTableAdapter
        '
        Me.MateriaPrimaTableAdapter.ClearBeforeFill = True
        '
        'FrmReporteMateriaPrima
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(871, 345)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TxtID)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmReporteMateriaPrima"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte MateriaPrima"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MateriaPrimaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsBakerySystem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DsBakerySystem As dsBakerySystem
    Friend WithEvents MateriaPrimaBindingSource As BindingSource
    Friend WithEvents MateriaPrimaTableAdapter As dsBakerySystemTableAdapters.MateriaPrimaTableAdapter
    Friend WithEvents IdMateriaPrimaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreMateriaPrimaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ExistenciaMinimaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ExistenciaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrecioCostoMDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RTNProveedorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MedidaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents TxtID As TextBox
    Friend WithEvents Button1 As Button
End Class
