<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConfigSar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmConfigSar))
        Me.NavBarControl1 = New DevExpress.XtraNavBar.NavBarControl()
        Me.NavBarGroup1 = New DevExpress.XtraNavBar.NavBarGroup()
        Me.NavBarItem1 = New DevExpress.XtraNavBar.NavBarItem()
        Me.NavBarItem2 = New DevExpress.XtraNavBar.NavBarItem()
        Me.NavBarItem3 = New DevExpress.XtraNavBar.NavBarItem()
        Me.DtgCai = New System.Windows.Forms.DataGridView()
        Me.DtCai = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DtFechaInicial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DtFechaFinal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DtUsado = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DtIdCai = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DtInicio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DtFin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.NavBarControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtgCai, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NavBarControl1
        '
        Me.NavBarControl1.ActiveGroup = Me.NavBarGroup1
        Me.NavBarControl1.Appearance.Background.BackColor = System.Drawing.Color.Transparent
        Me.NavBarControl1.Appearance.Background.Options.UseBackColor = True
        Me.NavBarControl1.Dock = System.Windows.Forms.DockStyle.Left
        Me.NavBarControl1.Groups.AddRange(New DevExpress.XtraNavBar.NavBarGroup() {Me.NavBarGroup1})
        Me.NavBarControl1.Items.AddRange(New DevExpress.XtraNavBar.NavBarItem() {Me.NavBarItem1, Me.NavBarItem2, Me.NavBarItem3})
        Me.NavBarControl1.Location = New System.Drawing.Point(0, 0)
        Me.NavBarControl1.Name = "NavBarControl1"
        Me.NavBarControl1.OptionsNavPane.ExpandedWidth = 149
        Me.NavBarControl1.Size = New System.Drawing.Size(149, 471)
        Me.NavBarControl1.TabIndex = 2
        Me.NavBarControl1.Text = "NavBarControl1"
        '
        'NavBarGroup1
        '
        Me.NavBarGroup1.Caption = "Opciones"
        Me.NavBarGroup1.Expanded = True
        Me.NavBarGroup1.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() {New DevExpress.XtraNavBar.NavBarItemLink(Me.NavBarItem1), New DevExpress.XtraNavBar.NavBarItemLink(Me.NavBarItem2), New DevExpress.XtraNavBar.NavBarItemLink(Me.NavBarItem3)})
        Me.NavBarGroup1.Name = "NavBarGroup1"
        Me.NavBarGroup1.SmallImage = CType(resources.GetObject("NavBarGroup1.SmallImage"), System.Drawing.Image)
        '
        'NavBarItem1
        '
        Me.NavBarItem1.Caption = "Crear nuevo"
        Me.NavBarItem1.LargeImage = CType(resources.GetObject("NavBarItem1.LargeImage"), System.Drawing.Image)
        Me.NavBarItem1.Name = "NavBarItem1"
        Me.NavBarItem1.SmallImage = CType(resources.GetObject("NavBarItem1.SmallImage"), System.Drawing.Image)
        '
        'NavBarItem2
        '
        Me.NavBarItem2.Caption = "Editar registro"
        Me.NavBarItem2.Name = "NavBarItem2"
        Me.NavBarItem2.SmallImage = CType(resources.GetObject("NavBarItem2.SmallImage"), System.Drawing.Image)
        '
        'NavBarItem3
        '
        Me.NavBarItem3.Caption = "Actualizar datos"
        Me.NavBarItem3.Name = "NavBarItem3"
        Me.NavBarItem3.SmallImage = CType(resources.GetObject("NavBarItem3.SmallImage"), System.Drawing.Image)
        '
        'DtgCai
        '
        Me.DtgCai.AllowUserToAddRows = False
        Me.DtgCai.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DtgCai.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DtgCai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtgCai.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DtCai, Me.DtFechaInicial, Me.DtFechaFinal, Me.DtUsado, Me.DtIdCai, Me.DtInicio, Me.DtFin})
        Me.DtgCai.GridColor = System.Drawing.SystemColors.ButtonFace
        Me.DtgCai.Location = New System.Drawing.Point(189, 12)
        Me.DtgCai.MultiSelect = False
        Me.DtgCai.Name = "DtgCai"
        Me.DtgCai.ReadOnly = True
        Me.DtgCai.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DtgCai.Size = New System.Drawing.Size(976, 435)
        Me.DtgCai.TabIndex = 34
        '
        'DtCai
        '
        Me.DtCai.HeaderText = "CAI"
        Me.DtCai.Name = "DtCai"
        Me.DtCai.ReadOnly = True
        Me.DtCai.Width = 200
        '
        'DtFechaInicial
        '
        Me.DtFechaInicial.HeaderText = "Fecha Inicio"
        Me.DtFechaInicial.Name = "DtFechaInicial"
        Me.DtFechaInicial.ReadOnly = True
        Me.DtFechaInicial.Width = 154
        '
        'DtFechaFinal
        '
        Me.DtFechaFinal.HeaderText = "Fecha Fin"
        Me.DtFechaFinal.Name = "DtFechaFinal"
        Me.DtFechaFinal.ReadOnly = True
        Me.DtFechaFinal.Width = 153
        '
        'DtUsado
        '
        Me.DtUsado.HeaderText = "Usado"
        Me.DtUsado.Name = "DtUsado"
        Me.DtUsado.ReadOnly = True
        Me.DtUsado.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DtUsado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DtUsado.Width = 154
        '
        'DtIdCai
        '
        Me.DtIdCai.HeaderText = "IdCai"
        Me.DtIdCai.Name = "DtIdCai"
        Me.DtIdCai.ReadOnly = True
        Me.DtIdCai.Visible = False
        Me.DtIdCai.Width = 130
        '
        'DtInicio
        '
        Me.DtInicio.HeaderText = "Inicio"
        Me.DtInicio.Name = "DtInicio"
        Me.DtInicio.ReadOnly = True
        Me.DtInicio.Width = 153
        '
        'DtFin
        '
        Me.DtFin.HeaderText = "Fin"
        Me.DtFin.Name = "DtFin"
        Me.DtFin.ReadOnly = True
        Me.DtFin.Width = 154
        '
        'FrmConfigSar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1177, 471)
        Me.Controls.Add(Me.DtgCai)
        Me.Controls.Add(Me.NavBarControl1)
        Me.Name = "FrmConfigSar"
        Me.Text = "FrmConfigSar"
        CType(Me.NavBarControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtgCai, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents NavBarControl1 As DevExpress.XtraNavBar.NavBarControl
    Friend WithEvents NavBarGroup1 As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents NavBarItem1 As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NavBarItem2 As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NavBarItem3 As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents DtgCai As DataGridView
    Friend WithEvents DtCai As DataGridViewTextBoxColumn
    Friend WithEvents DtFechaInicial As DataGridViewTextBoxColumn
    Friend WithEvents DtFechaFinal As DataGridViewTextBoxColumn
    Friend WithEvents DtUsado As DataGridViewCheckBoxColumn
    Friend WithEvents DtIdCai As DataGridViewTextBoxColumn
    Friend WithEvents DtInicio As DataGridViewTextBoxColumn
    Friend WithEvents DtFin As DataGridViewTextBoxColumn
End Class
