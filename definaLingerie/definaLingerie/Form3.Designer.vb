<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Guna2AnimateWindow1 = New Guna.UI2.WinForms.Guna2AnimateWindow(Me.components)
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2ShadowForm1 = New Guna.UI2.WinForms.Guna2ShadowForm(Me.components)
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2ControlBox2 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_clientes = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_produtos = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Guna2GradientCircleButton2 = New Guna.UI2.WinForms.Guna2GradientCircleButton()
        Me.Guna2GradientCircleButton1 = New Guna.UI2.WinForms.Guna2GradientCircleButton()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2PictureBox2 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.btn_deslogar = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_deslogar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2AnimateWindow1
        '
        Me.Guna2AnimateWindow1.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_BLEND
        Me.Guna2AnimateWindow1.TargetForm = Me
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 20
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Guna2ShadowForm1
        '
        Me.Guna2ShadowForm1.TargetForm = Me
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2DragControl1.TargetControl = Me
        Me.Guna2DragControl1.UseTransparentDrag = True
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel1.Controls.Add(Me.Guna2ControlBox1)
        Me.Guna2Panel1.Controls.Add(Me.Guna2ControlBox2)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(1095, 43)
        Me.Guna2Panel1.TabIndex = 15
        '
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(1048, 0)
        Me.Guna2ControlBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(47, 43)
        Me.Guna2ControlBox1.TabIndex = 0
        '
        'Guna2ControlBox2
        '
        Me.Guna2ControlBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.Guna2ControlBox2.FillColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox2.IconColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Guna2ControlBox2.Location = New System.Drawing.Point(1000, 0)
        Me.Guna2ControlBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Guna2ControlBox2.Name = "Guna2ControlBox2"
        Me.Guna2ControlBox2.Size = New System.Drawing.Size(47, 43)
        Me.Guna2ControlBox2.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(436, 64)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(243, 54)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Funcionário"
        '
        'btn_clientes
        '
        Me.btn_clientes.Animated = True
        Me.btn_clientes.AutoRoundedCorners = True
        Me.btn_clientes.BorderColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.btn_clientes.BorderRadius = 22
        Me.btn_clientes.BorderThickness = 1
        Me.btn_clientes.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_clientes.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_clientes.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_clientes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_clientes.FillColor = System.Drawing.Color.Transparent
        Me.btn_clientes.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_clientes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.btn_clientes.Location = New System.Drawing.Point(285, 385)
        Me.btn_clientes.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_clientes.Name = "btn_clientes"
        Me.btn_clientes.Size = New System.Drawing.Size(236, 46)
        Me.btn_clientes.TabIndex = 25
        Me.btn_clientes.Text = "Administrar Clientes"
        '
        'btn_produtos
        '
        Me.btn_produtos.Animated = True
        Me.btn_produtos.AutoRoundedCorners = True
        Me.btn_produtos.BorderColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.btn_produtos.BorderRadius = 22
        Me.btn_produtos.BorderThickness = 1
        Me.btn_produtos.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_produtos.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_produtos.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_produtos.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_produtos.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_produtos.FillColor = System.Drawing.Color.Transparent
        Me.btn_produtos.FillColor2 = System.Drawing.Color.Transparent
        Me.btn_produtos.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_produtos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.btn_produtos.Location = New System.Drawing.Point(609, 385)
        Me.btn_produtos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_produtos.Name = "btn_produtos"
        Me.btn_produtos.Size = New System.Drawing.Size(241, 46)
        Me.btn_produtos.TabIndex = 24
        Me.btn_produtos.Text = "Cadastrar produtos"
        '
        'Guna2GradientCircleButton2
        '
        Me.Guna2GradientCircleButton2.Animated = True
        Me.Guna2GradientCircleButton2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2GradientCircleButton2.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2GradientCircleButton2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2GradientCircleButton2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2GradientCircleButton2.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2GradientCircleButton2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2GradientCircleButton2.FillColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.Guna2GradientCircleButton2.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Guna2GradientCircleButton2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2GradientCircleButton2.ForeColor = System.Drawing.Color.White
        Me.Guna2GradientCircleButton2.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.Guna2GradientCircleButton2.Image = Global.definaLingerie.My.Resources.Resources.icons8_staff_96
        Me.Guna2GradientCircleButton2.ImageSize = New System.Drawing.Size(96, 96)
        Me.Guna2GradientCircleButton2.Location = New System.Drawing.Point(303, 183)
        Me.Guna2GradientCircleButton2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Guna2GradientCircleButton2.Name = "Guna2GradientCircleButton2"
        Me.Guna2GradientCircleButton2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2GradientCircleButton2.Size = New System.Drawing.Size(197, 182)
        Me.Guna2GradientCircleButton2.TabIndex = 27
        '
        'Guna2GradientCircleButton1
        '
        Me.Guna2GradientCircleButton1.Animated = True
        Me.Guna2GradientCircleButton1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2GradientCircleButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2GradientCircleButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2GradientCircleButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2GradientCircleButton1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2GradientCircleButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2GradientCircleButton1.FillColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.Guna2GradientCircleButton1.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Guna2GradientCircleButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2GradientCircleButton1.ForeColor = System.Drawing.Color.White
        Me.Guna2GradientCircleButton1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.Guna2GradientCircleButton1.Image = Global.definaLingerie.My.Resources.Resources.icons8_product_96
        Me.Guna2GradientCircleButton1.ImageSize = New System.Drawing.Size(96, 96)
        Me.Guna2GradientCircleButton1.Location = New System.Drawing.Point(629, 183)
        Me.Guna2GradientCircleButton1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Guna2GradientCircleButton1.Name = "Guna2GradientCircleButton1"
        Me.Guna2GradientCircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2GradientCircleButton1.Size = New System.Drawing.Size(197, 182)
        Me.Guna2GradientCircleButton1.TabIndex = 26
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BorderRadius = 28
        Me.Guna2PictureBox1.Image = Global.definaLingerie.My.Resources.Resources.definaLogo
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(16, 50)
        Me.Guna2PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(75, 69)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 16
        Me.Guna2PictureBox1.TabStop = False
        '
        'Guna2PictureBox2
        '
        Me.Guna2PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox2.Image = Global.definaLingerie.My.Resources.Resources.background_form
        Me.Guna2PictureBox2.ImageRotate = 0!
        Me.Guna2PictureBox2.Location = New System.Drawing.Point(321, 123)
        Me.Guna2PictureBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Guna2PictureBox2.Name = "Guna2PictureBox2"
        Me.Guna2PictureBox2.Size = New System.Drawing.Size(773, 475)
        Me.Guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox2.TabIndex = 18
        Me.Guna2PictureBox2.TabStop = False
        '
        'btn_deslogar
        '
        Me.btn_deslogar.BackColor = System.Drawing.Color.Transparent
        Me.btn_deslogar.BorderRadius = 28
        Me.btn_deslogar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_deslogar.Image = Global.definaLingerie.My.Resources.Resources.icons8_quit_50
        Me.btn_deslogar.ImageRotate = 0!
        Me.btn_deslogar.Location = New System.Drawing.Point(1012, 58)
        Me.btn_deslogar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_deslogar.Name = "btn_deslogar"
        Me.btn_deslogar.Size = New System.Drawing.Size(50, 50)
        Me.btn_deslogar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btn_deslogar.TabIndex = 28
        Me.btn_deslogar.TabStop = False
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1095, 593)
        Me.Controls.Add(Me.btn_deslogar)
        Me.Controls.Add(Me.Guna2GradientCircleButton2)
        Me.Controls.Add(Me.Guna2GradientCircleButton1)
        Me.Controls.Add(Me.btn_clientes)
        Me.Controls.Add(Me.btn_produtos)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.Guna2PictureBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form3"
        Me.Guna2Panel1.ResumeLayout(False)
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_deslogar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Guna2AnimateWindow1 As Guna.UI2.WinForms.Guna2AnimateWindow
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2ShadowForm1 As Guna.UI2.WinForms.Guna2ShadowForm
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ControlBox2 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2PictureBox2 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents btn_clientes As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_produtos As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Guna2GradientCircleButton2 As Guna.UI2.WinForms.Guna2GradientCircleButton
    Friend WithEvents Guna2GradientCircleButton1 As Guna.UI2.WinForms.Guna2GradientCircleButton
    Friend WithEvents btn_deslogar As Guna.UI2.WinForms.Guna2PictureBox
End Class
