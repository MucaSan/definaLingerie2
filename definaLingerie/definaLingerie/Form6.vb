Imports System.Data.Common
Imports System.Data.SQLite
Imports System.Web.UI.WebControls
Imports System.Windows.Forms.Design

Public Class Form6
    Private dbCommand As String = ""
    Private permitir_criar As Boolean = True
    Private bindingSrc As BindingSource
    Private cont As Integer = 0
    Private dbName As String = "banco.db"
    Private dbPath As String = Application.StartupPath & "\banco\" & dbName
    Private conString As String = "Data Source=" & dbPath & ";Version=3"
    Private SQL As String
    Private connection As New SQLiteConnection(conString)

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection.Open()
        SQL = "SELECT cor from tb_cor;"
        Dim command As New SQLiteCommand(SQL, connection)
        Using reader As SQLiteDataReader = command.ExecuteReader()
            While reader.Read()
                cmb_cor.Items.Add(reader("cor"))
            End While
        End Using
        SQL = "SELECT tipo from tb_tipo;"
        command.CommandText = SQL
        Using reader As SQLiteDataReader = command.ExecuteReader()
            While reader.Read()
                cmb_tipo.Items.Add(reader("tipo"))
            End While
        End Using
        SQL = "SELECT tamanho from tb_tamanho;"
        command.CommandText = SQL
        Using reader As SQLiteDataReader = command.ExecuteReader()
            While reader.Read()
                cmb_tamanho.Items.Add(reader("tamanho"))
            End While
        End Using
        SQL = "SELECT cond_renda from tb_renda;"
        command.CommandText = SQL
        Using reader As SQLiteDataReader = command.ExecuteReader()
            While reader.Read()
                cmb_renda.Items.Add(reader("cond_renda"))
            End While
        End Using
    End Sub

    Private Sub cmb_renda_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_renda.SelectedIndexChanged
        Dim command As New SQLiteCommand(SQL, connection)
        Dim verif_tipo As Integer
        Dim verif_tamanho As Integer
        Dim verif_renda As Integer
        SQL = "SELECT id from tb_tipo where tipo = '" & cmb_tipo.Text & "';"
        command.CommandText = SQL
        Using reader As SQLiteDataReader = command.ExecuteReader()
            If reader.Read() Then
                verif_tipo = CInt(reader("id"))
            End If
        End Using
        SQL = "SELECT id from tb_tamanho where tamanho = '" & cmb_tamanho.Text & "';"
        command.CommandText = SQL
        Using reader As SQLiteDataReader = command.ExecuteReader()
            If reader.Read() Then
                verif_tamanho = CInt(reader("id"))
            End If
        End Using
        SQL = "SELECT id from tb_renda where cond_renda = '" & cmb_renda.Text & "';"
        command.CommandText = SQL
        Using reader As SQLiteDataReader = command.ExecuteReader()
            If reader.Read() Then
                verif_renda = CInt(reader("id"))
            End If
        End Using

        SQL = "SELECT preco from tb_preco WHERE tamanho = '" & verif_tamanho & "' AND tipo = '" & verif_tipo & "' AND renda = '" & verif_renda & "';"
        command.CommandText = SQL
        Using reader As SQLiteDataReader = command.ExecuteReader()
            If reader.Read() Then
                txt_preco.Text = reader("preco")
                cont = 0
                If txt_qtde.Text = Nothing Then
                    Exit Sub
                Else
                    txt_qtde_TextChanged(sender, e)
                End If

            End If
        End Using
    End Sub

    Private Sub cmb_tipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_tipo.SelectedIndexChanged
        Dim command As New SQLiteCommand(SQL, connection)
        Dim verif_tipo As Integer
        Dim verif_tamanho As Integer
        Dim verif_renda As Integer
        SQL = "SELECT id from tb_tipo where tipo = '" & cmb_tipo.Text & "';"
        command.CommandText = SQL
        Using reader As SQLiteDataReader = command.ExecuteReader()
            If reader.Read() Then
                verif_tipo = CInt(reader("id"))
            End If
        End Using
        SQL = "SELECT id from tb_tamanho where tamanho = '" & cmb_tamanho.Text & "';"
        command.CommandText = SQL
        Using reader As SQLiteDataReader = command.ExecuteReader()
            If reader.Read() Then
                verif_tamanho = CInt(reader("id"))
            End If
        End Using
        SQL = "SELECT id from tb_renda where cond_renda = '" & cmb_renda.Text & "';"
        command.CommandText = SQL
        Using reader As SQLiteDataReader = command.ExecuteReader()
            If reader.Read() Then
                verif_renda = CInt(reader("id"))
            End If
        End Using
        SQL = "SELECT preco from tb_preco WHERE tamanho = '" & verif_tamanho & "' AND tipo = '" & verif_tipo & "' AND renda = '" & verif_renda & "';"
        command.CommandText = SQL
        Using reader As SQLiteDataReader = command.ExecuteReader()
            If reader.Read() Then
                txt_preco.Text = reader("preco")
                cont = 0
                If txt_qtde.Text = Nothing Then
                    Exit Sub
                Else
                    txt_qtde_TextChanged(sender, e)
                End If

            End If
        End Using
    End Sub

    Private Sub cmb_tamanho_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_tamanho.SelectedIndexChanged
        Dim command As New SQLiteCommand(SQL, connection)
        Dim verif_tipo As Integer
        Dim verif_tamanho As Integer
        Dim verif_renda As Integer
        SQL = "SELECT id from tb_tipo where tipo = '" & cmb_tipo.Text & "';"
        command.CommandText = SQL
        Using reader As SQLiteDataReader = command.ExecuteReader()
            If reader.Read() Then
                verif_tipo = CInt(reader("id"))
            End If
        End Using
        SQL = "SELECT id from tb_tamanho where tamanho = '" & cmb_tamanho.Text & "';"
        command.CommandText = SQL
        Using reader As SQLiteDataReader = command.ExecuteReader()
            If reader.Read() Then
                verif_tamanho = CInt(reader("id"))
            End If
        End Using
        SQL = "SELECT id from tb_renda where cond_renda = '" & cmb_renda.Text & "';"
        command.CommandText = SQL
        Using reader As SQLiteDataReader = command.ExecuteReader()
            If reader.Read() Then
                verif_renda = CInt(reader("id"))
            End If
        End Using

        SQL = "SELECT preco from tb_preco WHERE tamanho = '" & verif_tamanho & "' AND tipo = '" & verif_tipo & "' AND renda = '" & verif_renda & "';"
        command.CommandText = SQL
        Using reader As SQLiteDataReader = command.ExecuteReader()
            If reader.Read() Then
                txt_preco.Text = reader("preco")
                cont = 0
                If txt_qtde.Text = Nothing Then
                    Exit Sub
                Else
                    txt_qtde_TextChanged(sender, e)
                End If
            End If
        End Using
    End Sub

    Private Sub txt_qtde_TextChanged(sender As Object, e As EventArgs) Handles txt_qtde.TextChanged
        Try
            Dim integer_preco As Integer
            Dim integer_qtde As Integer
            Dim integer_result As Integer
            If txt_preco.Text = Nothing Then
                permitir_criar = False
                Exit Sub
            ElseIf cont < 1 Then
                integer_preco = CInt(txt_preco.Text)
                integer_qtde = CInt(txt_qtde.Text)
                integer_result = integer_preco * integer_qtde
                txt_preco.Text = integer_result.ToString()
                permitir_criar = True
                cont += 1
            End If
        Catch ex As Exception
            MsgBox("Insira um valor válido dentro da quantidade! Não é aceito letras nem caracteres especiais!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
            permitir_criar = False

        End Try
    End Sub
    Private Sub btn_criar_Click(sender As Object, e As EventArgs) Handles btn_criar.Click
        SQL = "SELECT nome from tb_clientes where nome = '" & txt_cliente.Text & "';"
        Dim command As New SQLiteCommand(SQL, connection)
        Using reader As SQLiteDataReader = command.ExecuteReader()
            If reader.Read() Then
                permitir_criar = True
            Else
                MsgBox("Você inseriu o nome do cliente errado, ou ele não existe!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
                permitir_criar = False
            End If
        End Using
        SQL = "INSERT INTO tb_produtos VALUES ('" & funcionario_logado & "','" & cmb_tamanho.Text & "','" & txt_cliente.Text & "','" & cmb_renda.Text & "','" & txt_preco.Text & "','" & cmb_cor.Text & "','" & txt_qtde.Text & "','" & cmb_tipo.Text & "','" & DateTime.Now.ToString() & "');"
        command.CommandText = SQL
        Select Case permitir_criar
            Case True
                Try
                    command.ExecuteNonQuery()
                    MsgBox("Criação efetuada com sucesso!")
                Catch ex As Exception
                    MsgBox("Foi impossível realizar a criação do produto, porque provavelmente foram inseridos valores inválidos nos campos!")
                End Try
            Case Else
                MsgBox("Você completou os campos de forma indevida! Tente novamente após as mudanças!")
                Exit Sub

        End Select

    End Sub

End Class