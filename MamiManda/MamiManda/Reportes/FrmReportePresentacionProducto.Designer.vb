﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReportePresentacionProducto
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.TxtID = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdInventarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioMayoristaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioDetalleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioCostoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoPresentacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PresentacionProductoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsBakerySystem = New MamiManda.dsBakerySystem()
        Me.PresentacionProductoTableAdapter = New MamiManda.dsBakerySystemTableAdapters.PresentacionProductoTableAdapter()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PresentacionProductoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsBakerySystem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(237, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Id Inventario"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Location = New System.Drawing.Point(63, 37)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(167, 59)
        Me.GroupBox1.TabIndex = 22
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
        Me.TxtID.Location = New System.Drawing.Point(330, 60)
        Me.TxtID.Name = "TxtID"
        Me.TxtID.Size = New System.Drawing.Size(151, 20)
        Me.TxtID.TabIndex = 21
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(487, 51)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(126, 36)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "Generar Reporte"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdInventarioDataGridViewTextBoxColumn, Me.PrecioMayoristaDataGridViewTextBoxColumn, Me.PrecioDetalleDataGridViewTextBoxColumn, Me.PrecioCostoDataGridViewTextBoxColumn, Me.TipoPresentacionDataGridViewTextBoxColumn, Me.UserNameDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.PresentacionProductoBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 121)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(642, 154)
        Me.DataGridView1.TabIndex = 24
        '
        'IdInventarioDataGridViewTextBoxColumn
        '
        Me.IdInventarioDataGridViewTextBoxColumn.DataPropertyName = "IdInventario"
        Me.IdInventarioDataGridViewTextBoxColumn.HeaderText = "IdInventario"
        Me.IdInventarioDataGridViewTextBoxColumn.Name = "IdInventarioDataGridViewTextBoxColumn"
        '
        'PrecioMayoristaDataGridViewTextBoxColumn
        '
        Me.PrecioMayoristaDataGridViewTextBoxColumn.DataPropertyName = "PrecioMayorista"
        Me.PrecioMayoristaDataGridViewTextBoxColumn.HeaderText = "PrecioMayorista"
        Me.PrecioMayoristaDataGridViewTextBoxColumn.Name = "PrecioMayoristaDataGridViewTextBoxColumn"
        '
        'PrecioDetalleDataGridViewTextBoxColumn
        '
        Me.PrecioDetalleDataGridViewTextBoxColumn.DataPropertyName = "PrecioDetalle"
        Me.PrecioDetalleDataGridViewTextBoxColumn.HeaderText = "PrecioDetalle"
        Me.PrecioDetalleDataGridViewTextBoxColumn.Name = "PrecioDetalleDataGridViewTextBoxColumn"
        '
        'PrecioCostoDataGridViewTextBoxColumn
        '
        Me.PrecioCostoDataGridViewTextBoxColumn.DataPropertyName = "PrecioCosto"
        Me.PrecioCostoDataGridViewTextBoxColumn.HeaderText = "PrecioCosto"
        Me.PrecioCostoDataGridViewTextBoxColumn.Name = "PrecioCostoDataGridViewTextBoxColumn"
        '
        'TipoPresentacionDataGridViewTextBoxColumn
        '
        Me.TipoPresentacionDataGridViewTextBoxColumn.DataPropertyName = "TipoPresentacion"
        Me.TipoPresentacionDataGridViewTextBoxColumn.HeaderText = "TipoPresentacion"
        Me.TipoPresentacionDataGridViewTextBoxColumn.Name = "TipoPresentacionDataGridViewTextBoxColumn"
        '
        'UserNameDataGridViewTextBoxColumn
        '
        Me.UserNameDataGridViewTextBoxColumn.DataPropertyName = "UserName"
        Me.UserNameDataGridViewTextBoxColumn.HeaderText = "UserName"
        Me.UserNameDataGridViewTextBoxColumn.Name = "UserNameDataGridViewTextBoxColumn"
        '
        'PresentacionProductoBindingSource
        '
        Me.PresentacionProductoBindingSource.DataMember = "PresentacionProducto"
        Me.PresentacionProductoBindingSource.DataSource = Me.DsBakerySystem
        '
        'DsBakerySystem
        '
        Me.DsBakerySystem.DataSetName = "dsBakerySystem"
        Me.DsBakerySystem.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PresentacionProductoTableAdapter
        '
        Me.PresentacionProductoTableAdapter.ClearBeforeFill = True
        '
        'FrmReportePresentacionProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(673, 287)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TxtID)
        Me.Controls.Add(Me.Button1)
        Me.Name = "FrmReportePresentacionProducto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmReportePresentacionProducto"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PresentacionProductoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsBakerySystem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents TxtID As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DsBakerySystem As dsBakerySystem
    Friend WithEvents PresentacionProductoBindingSource As BindingSource
    Friend WithEvents PresentacionProductoTableAdapter As dsBakerySystemTableAdapters.PresentacionProductoTableAdapter
    Friend WithEvents IdInventarioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrecioMayoristaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrecioDetalleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrecioCostoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TipoPresentacionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UserNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class