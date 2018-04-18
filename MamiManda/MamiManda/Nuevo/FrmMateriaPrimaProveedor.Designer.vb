<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMateriaPrimaProveedor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMateriaPrimaProveedor))
        Me.LblMensaje = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnRemover = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnAgregar = New DevExpress.XtraEditors.SimpleButton()
        Me.GcProveedores = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GcMateriaPrimaA = New DevExpress.XtraGrid.GridControl()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GcMateriaPrimaD = New DevExpress.XtraGrid.GridControl()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        CType(Me.GcProveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GcMateriaPrimaA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GcMateriaPrimaD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblMensaje
        '
        Me.LblMensaje.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblMensaje.AutoSize = True
        Me.LblMensaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMensaje.Location = New System.Drawing.Point(747, 341)
        Me.LblMensaje.Name = "LblMensaje"
        Me.LblMensaje.Size = New System.Drawing.Size(99, 20)
        Me.LblMensaje.TabIndex = 20
        Me.LblMensaje.Text = "Sin asignar"
        Me.LblMensaje.Visible = False
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(696, 243)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(196, 20)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Materia prima asignada"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(100, 243)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(204, 20)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Materia prima disponible"
        '
        'BtnRemover
        '
        Me.BtnRemover.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnRemover.Image = CType(resources.GetObject("BtnRemover.Image"), System.Drawing.Image)
        Me.BtnRemover.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.BtnRemover.Location = New System.Drawing.Point(469, 376)
        Me.BtnRemover.Name = "BtnRemover"
        Me.BtnRemover.Size = New System.Drawing.Size(84, 57)
        Me.BtnRemover.TabIndex = 17
        '
        'BtnAgregar
        '
        Me.BtnAgregar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnAgregar.Image = CType(resources.GetObject("BtnAgregar.Image"), System.Drawing.Image)
        Me.BtnAgregar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.BtnAgregar.Location = New System.Drawing.Point(469, 313)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(84, 57)
        Me.BtnAgregar.TabIndex = 16
        '
        'GcProveedores
        '
        Me.GcProveedores.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GcProveedores.Location = New System.Drawing.Point(76, 38)
        Me.GcProveedores.MainView = Me.GridView1
        Me.GcProveedores.Name = "GcProveedores"
        Me.GcProveedores.Size = New System.Drawing.Size(850, 176)
        Me.GcProveedores.TabIndex = 15
        Me.GcProveedores.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.GcProveedores
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsBehavior.ReadOnly = True
        Me.GridView1.OptionsFind.AlwaysVisible = True
        Me.GridView1.OptionsFind.FindMode = DevExpress.XtraEditors.FindMode.Always
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'GcMateriaPrimaA
        '
        Me.GcMateriaPrimaA.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GcMateriaPrimaA.Location = New System.Drawing.Point(665, 266)
        Me.GcMateriaPrimaA.MainView = Me.GridView3
        Me.GcMateriaPrimaA.Name = "GcMateriaPrimaA"
        Me.GcMateriaPrimaA.Size = New System.Drawing.Size(261, 235)
        Me.GcMateriaPrimaA.TabIndex = 14
        Me.GcMateriaPrimaA.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView3})
        '
        'GridView3
        '
        Me.GridView3.GridControl = Me.GcMateriaPrimaA
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsBehavior.Editable = False
        Me.GridView3.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        'GcMateriaPrimaD
        '
        Me.GcMateriaPrimaD.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GcMateriaPrimaD.Location = New System.Drawing.Point(76, 266)
        Me.GcMateriaPrimaD.MainView = Me.GridView2
        Me.GcMateriaPrimaD.Name = "GcMateriaPrimaD"
        Me.GcMateriaPrimaD.Size = New System.Drawing.Size(266, 235)
        Me.GcMateriaPrimaD.TabIndex = 13
        Me.GcMateriaPrimaD.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.GcMateriaPrimaD
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsBehavior.Editable = False
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'FrmMateriaPrimaProveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.MamiManda.My.Resources.Resources.FondoNew
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1003, 563)
        Me.Controls.Add(Me.LblMensaje)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnRemover)
        Me.Controls.Add(Me.BtnAgregar)
        Me.Controls.Add(Me.GcProveedores)
        Me.Controls.Add(Me.GcMateriaPrimaA)
        Me.Controls.Add(Me.GcMateriaPrimaD)
        Me.Name = "FrmMateriaPrimaProveedor"
        Me.Text = "Materia Prima - Proveedor"
        CType(Me.GcProveedores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GcMateriaPrimaA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GcMateriaPrimaD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblMensaje As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnRemover As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnAgregar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GcProveedores As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GcMateriaPrimaA As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GcMateriaPrimaD As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
End Class
