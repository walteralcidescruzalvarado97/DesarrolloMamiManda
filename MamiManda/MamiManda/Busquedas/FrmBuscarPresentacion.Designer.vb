<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBuscarPresentacion
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmBuscarPresentacion))
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GcPresentacion = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RdbDetalle = New System.Windows.Forms.RadioButton()
        Me.RdbMayorista = New System.Windows.Forms.RadioButton()
        Me.RdbCosto = New System.Windows.Forms.RadioButton()
        CType(Me.GcPresentacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(294, 24)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(197, 25)
        Me.Label11.TabIndex = 84
        Me.Label11.Text = "Listar Presentación"
        '
        'GcPresentacion
        '
        Me.GcPresentacion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GcPresentacion.Location = New System.Drawing.Point(24, 64)
        Me.GcPresentacion.MainView = Me.GridView1
        Me.GcPresentacion.Name = "GcPresentacion"
        Me.GcPresentacion.Size = New System.Drawing.Size(702, 233)
        Me.GcPresentacion.TabIndex = 101
        Me.GcPresentacion.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.GcPresentacion
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsBehavior.ReadOnly = True
        Me.GridView1.OptionsFind.AlwaysVisible = True
        Me.GridView1.OptionsFind.FindMode = DevExpress.XtraEditors.FindMode.Always
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RdbCosto)
        Me.GroupBox1.Controls.Add(Me.RdbMayorista)
        Me.GroupBox1.Controls.Add(Me.RdbDetalle)
        Me.GroupBox1.Location = New System.Drawing.Point(385, 317)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(341, 47)
        Me.GroupBox1.TabIndex = 102
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Elegir Precio"
        '
        'RdbDetalle
        '
        Me.RdbDetalle.AutoSize = True
        Me.RdbDetalle.Location = New System.Drawing.Point(133, 20)
        Me.RdbDetalle.Name = "RdbDetalle"
        Me.RdbDetalle.Size = New System.Drawing.Size(58, 17)
        Me.RdbDetalle.TabIndex = 0
        Me.RdbDetalle.TabStop = True
        Me.RdbDetalle.Text = "Detalle"
        Me.RdbDetalle.UseVisualStyleBackColor = True
        '
        'RdbMayorista
        '
        Me.RdbMayorista.AutoSize = True
        Me.RdbMayorista.Location = New System.Drawing.Point(19, 20)
        Me.RdbMayorista.Name = "RdbMayorista"
        Me.RdbMayorista.Size = New System.Drawing.Size(70, 17)
        Me.RdbMayorista.TabIndex = 1
        Me.RdbMayorista.TabStop = True
        Me.RdbMayorista.Text = "Mayorista"
        Me.RdbMayorista.UseVisualStyleBackColor = True
        '
        'RdbCosto
        '
        Me.RdbCosto.AutoSize = True
        Me.RdbCosto.Location = New System.Drawing.Point(235, 20)
        Me.RdbCosto.Name = "RdbCosto"
        Me.RdbCosto.Size = New System.Drawing.Size(52, 17)
        Me.RdbCosto.TabIndex = 2
        Me.RdbCosto.TabStop = True
        Me.RdbCosto.Text = "Costo"
        Me.RdbCosto.UseVisualStyleBackColor = True
        '
        'FrmBuscarPresentacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.MamiManda.My.Resources.Resources.FondoNew
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(749, 376)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GcPresentacion)
        Me.Controls.Add(Me.Label11)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmBuscarPresentacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmBuscarPresentacion"
        CType(Me.GcPresentacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label11 As Label
    Friend WithEvents GcPresentacion As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RdbCosto As System.Windows.Forms.RadioButton
    Friend WithEvents RdbMayorista As System.Windows.Forms.RadioButton
    Friend WithEvents RdbDetalle As System.Windows.Forms.RadioButton
End Class
