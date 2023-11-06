Public Class Form2
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub Form2_Activated(sender As Object, e As EventArgs) Handles Me.Activated

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub



    Private Sub btn_relatorios_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btn_deslogar_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btn_deslogar_Click_1(sender As Object, e As EventArgs) Handles btn_deslogar.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub Guna2GradientCircleButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientCircleButton1.Click

    End Sub

    Private Sub btn_clientes_Click(sender As Object, e As EventArgs) Handles btn_clientes.Click
        Form4.Show()
        Me.Hide()
    End Sub
End Class