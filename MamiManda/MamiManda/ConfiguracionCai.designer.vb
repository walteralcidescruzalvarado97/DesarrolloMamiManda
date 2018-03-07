<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConfiguracionCai
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ConfiguracionCai))
        Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem1 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Me.TCCai = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtCai = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ChkUsado = New System.Windows.Forms.CheckBox()
        Me.TxtInicio = New System.Windows.Forms.MaskedTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DtFechaFin = New System.Windows.Forms.DateTimePicker()
        Me.TxtFin = New System.Windows.Forms.MaskedTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DtFechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.BtnCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.CmsOpc = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EpValidar = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.TCCai.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.CmsOpc.SuspendLayout()
        CType(Me.EpValidar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TCCai
        '
        Me.TCCai.Controls.Add(Me.TabPage1)
        Me.TCCai.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TCCai.Location = New System.Drawing.Point(0, 0)
        Me.TCCai.Margin = New System.Windows.Forms.Padding(2)
        Me.TCCai.Name = "TCCai"
        Me.TCCai.SelectedIndex = 0
        Me.TCCai.Size = New System.Drawing.Size(845, 347)
        Me.TCCai.TabIndex = 102
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.BtnCancelar)
        Me.TabPage1.Controls.Add(Me.BtnGuardar)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPage1.Size = New System.Drawing.Size(837, 321)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Configuración"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtCai)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.ChkUsado)
        Me.GroupBox1.Controls.Add(Me.TxtInicio)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.DtFechaFin)
        Me.GroupBox1.Controls.Add(Me.TxtFin)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.DtFechaInicio)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(168, 51)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(515, 179)
        Me.GroupBox1.TabIndex = 110
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del CAI"
        '
        'TxtCai
        '
        Me.TxtCai.Enabled = False
        Me.TxtCai.Location = New System.Drawing.Point(105, 36)
        Me.TxtCai.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtCai.Mask = "AAAAAA-AAAAAA-AAAAAA-AAAAAA-AAAAAA-AA"
        Me.TxtCai.Name = "TxtCai"
        Me.TxtCai.Size = New System.Drawing.Size(249, 26)
        Me.TxtCai.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(62, 39)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 20)
        Me.Label1.TabIndex = 100
        Me.Label1.Text = "CAI:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(62, 114)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 20)
        Me.Label2.TabIndex = 102
        Me.Label2.Text = "Inicio:"
        '
        'ChkUsado
        '
        Me.ChkUsado.AutoSize = True
        Me.ChkUsado.Location = New System.Drawing.Point(65, 147)
        Me.ChkUsado.Margin = New System.Windows.Forms.Padding(2)
        Me.ChkUsado.Name = "ChkUsado"
        Me.ChkUsado.Size = New System.Drawing.Size(75, 24)
        Me.ChkUsado.TabIndex = 5
        Me.ChkUsado.Text = "Usado"
        Me.ChkUsado.UseVisualStyleBackColor = True
        '
        'TxtInicio
        '
        Me.TxtInicio.Enabled = False
        Me.TxtInicio.Location = New System.Drawing.Point(116, 111)
        Me.TxtInicio.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtInicio.Mask = "000-000-00-00000000"
        Me.TxtInicio.Name = "TxtInicio"
        Me.TxtInicio.Size = New System.Drawing.Size(117, 26)
        Me.TxtInicio.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(279, 74)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 20)
        Me.Label6.TabIndex = 109
        Me.Label6.Text = "Fecha Fin:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(279, 114)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 20)
        Me.Label3.TabIndex = 104
        Me.Label3.Text = "Fin:"
        '
        'DtFechaFin
        '
        Me.DtFechaFin.Enabled = False
        Me.DtFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtFechaFin.Location = New System.Drawing.Point(359, 74)
        Me.DtFechaFin.Name = "DtFechaFin"
        Me.DtFechaFin.Size = New System.Drawing.Size(102, 26)
        Me.DtFechaFin.TabIndex = 2
        '
        'TxtFin
        '
        Me.TxtFin.Enabled = False
        Me.TxtFin.Location = New System.Drawing.Point(318, 111)
        Me.TxtFin.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtFin.Mask = "000-000-00-00000000"
        Me.TxtFin.Name = "TxtFin"
        Me.TxtFin.Size = New System.Drawing.Size(117, 26)
        Me.TxtFin.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(62, 74)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 20)
        Me.Label5.TabIndex = 107
        Me.Label5.Text = "Fecha Inicio:"
        '
        'DtFechaInicio
        '
        Me.DtFechaInicio.Enabled = False
        Me.DtFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtFechaInicio.Location = New System.Drawing.Point(166, 74)
        Me.DtFechaInicio.Name = "DtFechaInicio"
        Me.DtFechaInicio.Size = New System.Drawing.Size(102, 26)
        Me.DtFechaInicio.TabIndex = 1
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Image = CType(resources.GetObject("BtnCancelar.Image"), System.Drawing.Image)
        Me.BtnCancelar.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.BtnCancelar.Location = New System.Drawing.Point(405, 247)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(41, 41)
        Me.BtnCancelar.TabIndex = 3
        Me.BtnCancelar.ToolTip = "Cancelar"
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Image = CType(resources.GetObject("BtnGuardar.Image"), System.Drawing.Image)
        Me.BtnGuardar.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.BtnGuardar.Location = New System.Drawing.Point(345, 247)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(45, 41)
        ToolTipTitleItem1.Text = "Guardar Registro"
        SuperToolTip1.Items.Add(ToolTipTitleItem1)
        Me.BtnGuardar.SuperTip = SuperToolTip1
        Me.BtnGuardar.TabIndex = 1
        Me.BtnGuardar.ToolTip = "Guardar"
        '
        'CmsOpc
        '
        Me.CmsOpc.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditarToolStripMenuItem})
        Me.CmsOpc.Name = "CmsOpc"
        Me.CmsOpc.Size = New System.Drawing.Size(108, 26)
        '
        'EditarToolStripMenuItem
        '
        Me.EditarToolStripMenuItem.Name = "EditarToolStripMenuItem"
        Me.EditarToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.EditarToolStripMenuItem.Text = "Editar "
        '
        'EpValidar
        '
        Me.EpValidar.ContainerControl = Me
        '
        'ConfiguracionCai
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(845, 347)
        Me.Controls.Add(Me.TCCai)
        Me.Name = "ConfiguracionCai"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ConfiguracionCai"
        Me.TCCai.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.CmsOpc.ResumeLayout(False)
        CType(Me.EpValidar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TCCai As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents ChkUsado As CheckBox
    Private WithEvents BtnCancelar As DevExpress.XtraEditors.SimpleButton
    Private WithEvents BtnGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label6 As Label
    Friend WithEvents DtFechaFin As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents DtFechaInicio As DateTimePicker
    Friend WithEvents TxtFin As MaskedTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtInicio As MaskedTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtCai As MaskedTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CmsOpc As ContextMenuStrip
    Friend WithEvents EditarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EpValidar As ErrorProvider
    Friend WithEvents GroupBox1 As GroupBox
End Class
