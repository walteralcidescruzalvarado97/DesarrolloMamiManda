<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPresentacion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPresentacion))
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.TxtUnidades = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtPc = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtPd = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtPm = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtPresentacion = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NavBarControl1 = New DevExpress.XtraNavBar.NavBarControl()
        Me.NavBarGroup1 = New DevExpress.XtraNavBar.NavBarGroup()
        Me.NavBarItem1 = New DevExpress.XtraNavBar.NavBarItem()
        Me.NavBarItem2 = New DevExpress.XtraNavBar.NavBarItem()
        Me.NavBarItem3 = New DevExpress.XtraNavBar.NavBarItem()
        Me.GcPresentacion = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.NavBarControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GcPresentacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.GroupControl1.Appearance.Options.UseBackColor = True
        Me.GroupControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.GroupControl1.CaptionImage = CType(resources.GetObject("GroupControl1.CaptionImage"), System.Drawing.Image)
        Me.GroupControl1.Controls.Add(Me.TxtUnidades)
        Me.GroupControl1.Controls.Add(Me.Label6)
        Me.GroupControl1.Controls.Add(Me.TxtPc)
        Me.GroupControl1.Controls.Add(Me.Label5)
        Me.GroupControl1.Controls.Add(Me.TxtPd)
        Me.GroupControl1.Controls.Add(Me.Label4)
        Me.GroupControl1.Controls.Add(Me.TxtPm)
        Me.GroupControl1.Controls.Add(Me.Label3)
        Me.GroupControl1.Controls.Add(Me.TxtPresentacion)
        Me.GroupControl1.Controls.Add(Me.Label2)
        Me.GroupControl1.Controls.Add(Me.TxtNombre)
        Me.GroupControl1.Controls.Add(Me.Label1)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Right
        Me.GroupControl1.Location = New System.Drawing.Point(922, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(255, 471)
        Me.GroupControl1.TabIndex = 5
        Me.GroupControl1.Text = "Datos de la presentación del producto"
        '
        'TxtUnidades
        '
        Me.TxtUnidades.Location = New System.Drawing.Point(12, 316)
        Me.TxtUnidades.Name = "TxtUnidades"
        Me.TxtUnidades.ReadOnly = True
        Me.TxtUnidades.Size = New System.Drawing.Size(90, 21)
        Me.TxtUnidades.TabIndex = 23
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 300)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 13)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Unidades:"
        '
        'TxtPc
        '
        Me.TxtPc.Location = New System.Drawing.Point(12, 257)
        Me.TxtPc.Name = "TxtPc"
        Me.TxtPc.ReadOnly = True
        Me.TxtPc.Size = New System.Drawing.Size(87, 21)
        Me.TxtPc.TabIndex = 21
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 241)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 13)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Precio costo:"
        '
        'TxtPd
        '
        Me.TxtPd.Location = New System.Drawing.Point(12, 207)
        Me.TxtPd.Name = "TxtPd"
        Me.TxtPd.ReadOnly = True
        Me.TxtPd.Size = New System.Drawing.Size(90, 21)
        Me.TxtPd.TabIndex = 19
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 191)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Prescio detalle:"
        '
        'TxtPm
        '
        Me.TxtPm.Location = New System.Drawing.Point(11, 159)
        Me.TxtPm.Name = "TxtPm"
        Me.TxtPm.ReadOnly = True
        Me.TxtPm.Size = New System.Drawing.Size(90, 21)
        Me.TxtPm.TabIndex = 17
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 143)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Precio mayorista:"
        '
        'TxtPresentacion
        '
        Me.TxtPresentacion.Location = New System.Drawing.Point(11, 104)
        Me.TxtPresentacion.Name = "TxtPresentacion"
        Me.TxtPresentacion.ReadOnly = True
        Me.TxtPresentacion.Size = New System.Drawing.Size(184, 21)
        Me.TxtPresentacion.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Tipo de presentación:"
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(11, 56)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.ReadOnly = True
        Me.TxtNombre.Size = New System.Drawing.Size(184, 21)
        Me.TxtNombre.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Nombre del producto:"
        '
        'NavBarControl1
        '
        Me.NavBarControl1.ActiveGroup = Me.NavBarGroup1
        Me.NavBarControl1.Appearance.Background.BackColor = System.Drawing.Color.Transparent
        Me.NavBarControl1.Appearance.Background.Options.UseBackColor = True
        Me.NavBarControl1.Groups.AddRange(New DevExpress.XtraNavBar.NavBarGroup() {Me.NavBarGroup1})
        Me.NavBarControl1.Items.AddRange(New DevExpress.XtraNavBar.NavBarItem() {Me.NavBarItem1, Me.NavBarItem2, Me.NavBarItem3})
        Me.NavBarControl1.Location = New System.Drawing.Point(0, 0)
        Me.NavBarControl1.Name = "NavBarControl1"
        Me.NavBarControl1.OptionsNavPane.ExpandedWidth = 149
        Me.NavBarControl1.Size = New System.Drawing.Size(149, 471)
        Me.NavBarControl1.TabIndex = 4
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
        'GcPresentacion
        '
        Me.GcPresentacion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GcPresentacion.Location = New System.Drawing.Point(166, 15)
        Me.GcPresentacion.MainView = Me.GridView1
        Me.GcPresentacion.Name = "GcPresentacion"
        Me.GcPresentacion.Size = New System.Drawing.Size(739, 444)
        Me.GcPresentacion.TabIndex = 3
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
        'Label7
        '
        Me.Label7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(748, 39)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(143, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Hacer doble click para editar"
        '
        'FrmPresentacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.MamiManda.My.Resources.Resources.IMG_20180311_WA0027
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1177, 471)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.NavBarControl1)
        Me.Controls.Add(Me.GcPresentacion)
        Me.Name = "FrmPresentacion"
        Me.Text = "Gestión Presentación Producto"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.NavBarControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GcPresentacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents TxtUnidades As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtPc As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtPd As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtPm As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtPresentacion As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents NavBarControl1 As DevExpress.XtraNavBar.NavBarControl
    Friend WithEvents NavBarGroup1 As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents NavBarItem1 As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NavBarItem2 As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents NavBarItem3 As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents GcPresentacion As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
