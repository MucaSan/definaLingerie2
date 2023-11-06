<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
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
        Me.btn_relatorios = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btn_clientes = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2GradientCircleButton2 = New Guna.UI2.WinForms.Guna2GradientCircleButton()
        Me.Guna2GradientCircleButton1 = New Guna.UI2.WinForms.Guna2GradientCircleButton()
        Me.btn_deslogar = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2PictureBox2 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.btn_deslogar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(821, 35)
        Me.Guna2Panel1.TabIndex = 14
        '
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(786, 0)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(35, 35)
        Me.Guna2ControlBox1.TabIndex = 0
        '
        'Guna2ControlBox2
        '
        Me.Guna2ControlBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.Guna2ControlBox2.FillColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox2.IconColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Guna2ControlBox2.Location = New System.Drawing.Point(750, 0)
        Me.Guna2ControlBox2.Name = "Guna2ControlBox2"
        Me.Guna2ControlBox2.Size = New System.Drawing.Size(35, 35)
        Me.Guna2ControlBox2.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(298, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(238, 45)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Administrador"
        '
        'btn_relatorios
        '
        Me.btn_relatorios.Animated = True
        Me.btn_relatorios.AutoRoundedCorners = True
        Me.btn_relatorios.BorderColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.btn_relatorios.BorderRadius = 17
        Me.btn_relatorios.BorderThickness = 1
        Me.btn_relatorios.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_relatorios.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_relatorios.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_relatorios.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_relatorios.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_relatorios.FillColor = System.Drawing.Color.Transparent
        Me.btn_relatorios.FillColor2 = System.Drawing.Color.Transparent
        Me.btn_relatorios.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_relatorios.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.btn_relatorios.Location = New System.Drawing.Point(457, 313)
        Me.btn_relatorios.Name = "btn_relatorios"
        Me.btn_relatorios.Size = New System.Drawing.Size(181, 37)
        Me.btn_relatorios.TabIndex = 18
        Me.btn_relatorios.Text = "Relatórios"
        '
        'btn_clientes
        '
        Me.btn_clientes.Animated = True
        Me.btn_clientes.AutoRoundedCorners = True
        Me.btn_clientes.BorderColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.btn_clientes.BorderRadius = 17
        Me.btn_clientes.BorderThickness = 1
        Me.btn_clientes.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_clientes.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_clientes.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_clientes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_clientes.FillColor = System.Drawing.Color.Transparent
        Me.btn_clientes.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_clientes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(101, Byte), Integer))
        Me.btn_clientes.Location = New System.Drawing.Point(214, 313)
        Me.btn_clientes.Name = "btn_clientes"
        Me.btn_clientes.Size = New System.Drawing.Size(177, 37)
        Me.btn_clientes.TabIndex = 23
        Me.btn_clientes.Text = "Administrar Clientes"
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
        Me.Guna2GradientCircleButton2.Location = New System.Drawing.Point(227, 149)
        Me.Guna2GradientCircleButton2.Name = "Guna2GradientCircleButton2"
        Me.Guna2GradientCircleButton2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2GradientCircleButton2.Size = New System.Drawing.Size(148, 148)
        Me.Guna2GradientCircleButton2.TabIndex = 24
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
        Me.Guna2GradientCircleButton1.Image = Global.definaLingerie.My.Resources.Resources.icons8_report_962
        Me.Guna2GradientCircleButton1.ImageSize = New System.Drawing.Size(96, 96)
        Me.Guna2GradientCircleButton1.Location = New System.Drawing.Point(472, 149)
        Me.Guna2GradientCircleButton1.Name = "Guna2GradientCircleButton1"
        Me.Guna2GradientCircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2GradientCircleButton1.Size = New System.Drawing.Size(148, 148)
        Me.Guna2GradientCircleButton1.TabIndex = 22
        '
        'btn_deslogar
        '
        Me.btn_deslogar.BackColor = System.Drawing.Color.Transparent
        Me.btn_deslogar.BorderRadius = 28
        Me.btn_deslogar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_deslogar.Image = Global.definaLingerie.My.Resources.Resources.icons8_quit_50
        Me.btn_deslogar.ImageRotate = 0!
        Me.btn_deslogar.Location = New System.Drawing.Point(759, 47)
        Me.btn_deslogar.Name = "btn_deslogar"
        Me.btn_deslogar.Size = New System.Drawing.Size(50, 50)
        Me.btn_deslogar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btn_deslogar.TabIndex = 20
        Me.btn_deslogar.TabStop = False
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BorderRadius = 28
        Me.Guna2PictureBox1.Image = Global.definaLingerie.My.Resources.Resources.definaLogo
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(12, 41)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(56, 56)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 15
        Me.Guna2PictureBox1.TabStop = False
        '
        'Guna2PictureBox2
        '
        Me.Guna2PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox2.Image = Global.definaLingerie.My.Resources.Resources.background_form
        Me.Guna2PictureBox2.ImageRotate = 0!
        Me.Guna2PictureBox2.Location = New System.Drawing.Point(241, 100)
        Me.Guna2PictureBox2.Name = "Guna2PictureBox2"
        Me.Guna2PictureBox2.Size = New System.Drawing.Size(580, 386)
        Me.Guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox2.TabIndex = 7
        Me.Guna2PictureBox2.TabStop = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(821, 482)
        Me.Controls.Add(Me.Guna2GradientCircleButton2)
        Me.Controls.Add(Me.btn_clientes)
        Me.Controls.Add(Me.Guna2GradientCircleButton1)
        Me.Controls.Add(Me.btn_deslogar)
        Me.Controls.Add(Me.btn_relatorios)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.Guna2PictureBox2)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administrador"
        Me.Guna2Panel1.ResumeLayout(False)
        CType(Me.btn_deslogar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Guna2AnimateWindow1 As Guna.UI2.WinForms.Guna2AnimateWindow
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2ShadowForm1 As Guna.UI2.WinForms.Guna2ShadowForm
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents Guna2PictureBox2 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ControlBox2 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_relatorios As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btn_deslogar As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2GradientCircleButton1 As Guna.UI2.WinForms.Guna2GradientCircleButton
    Friend WithEvents btn_clientes As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2GradientCircleButton2 As Guna.UI2.WinForms.Guna2GradientCircleButton
End Class
