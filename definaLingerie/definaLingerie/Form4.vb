Imports System.Data.SQLite
Imports System.Security.Cryptography

Public Class Form4
    Private dbCommand As String = ""
    Private bindingSrc As BindingSource

    Private dbName As String = "banco.db"
    Private dbPath As String = Application.StartupPath & "\banco\" & dbName
    Private conString As String = "Data Source=" & dbPath & ";Version=3"

    Private connection As New SQLiteConnection(conString)

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection.Open()
        cmb_parametro.Items.Add("CPF")
        cmb_parametro.Items.Add("Usuário")
    End Sub

    Private Sub btn_filtrar_Click(sender As Object, e As EventArgs) Handles btn_filtrar.Click
        Dim sql As String
        If cmb_parametro.SelectedItem.ToString() = "CPF" Then
            sql = "select * from tb_funcionarios where cpf = '" & txt_valor.Text & "' "
            Dim command As New SQLiteCommand(sql, connection)
            Using reader As SQLiteDataReader = command.ExecuteReader()
                If reader.Read() Then
                    txt_cpf.Text = reader("cpf").ToString()
                    txt_nome.Text = reader("nome").ToString()
                    txt_user.Text = reader("usuario").ToString()
                    txt_senha.Text = reader("senha").ToString()
                    cmb_data.Text = reader("data_nascimento").ToString()
                    txt_email.Text = reader("email").ToString()
                    txt_telefone.Text = reader("telefone").ToString()
                Else
                    MsgBox("Não há um registro com esse CPF!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO!")
                End If
            End Using
        ElseIf cmb_parametro.SelectedItem.ToString() = "Usuário" Then
            sql = "select * from tb_funcionarios where usuario = '" & txt_valor.Text & "' "
            Dim command As New SQLiteCommand(sql, connection)
            Using reader As SQLiteDataReader = command.ExecuteReader()
                If reader.Read() Then
                    txt_cpf.Text = reader("cpf").ToString()
                    txt_nome.Text = reader("nome").ToString()
                    txt_user.Text = reader("usuario").ToString()
                    txt_senha.Text = reader("senha").ToString()
                    cmb_data.Text = reader("data_nascimento").ToString()
                    txt_email.Text = reader("email").ToString()
                    txt_telefone.Text = reader("telefone").ToString()
                Else
                    MsgBox("Não há um registro com esse Usuário!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO!")
                End If
            End Using
        Else
            MsgBox("Escolha um parâmetro, antes de filtrar!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO!")
        End If
    End Sub

    Private Sub btn_deletar_Click(sender As Object, e As EventArgs) Handles btn_deletar.Click
        Dim sql As String = "SELECT * FROM tb_funcionarios WHERE usuario='" & txt_user.Text & "';"
        Dim command As New SQLiteCommand(sql, connection)
        Using reader As SQLiteDataReader = command.ExecuteReader()
            If reader.Read() Then
                sql = "DELETE FROM tb_funcionarios WHERE usuario= '" & txt_user.Text & "'"
                Dim command2 As New SQLiteCommand(sql, connection)
                Try
                    command2.ExecuteNonQuery()
                    MsgBox("Deleção efetuada com sucesso!")
                Catch ex As Exception
                    MsgBox("Não foi possível realizar a deleção!")
                End Try
            End If
        End Using
    End Sub

    Private Sub btn_editar_Click(sender As Object, e As EventArgs) Handles btn_editar.Click
        Dim sql As String = "SELECT * FROM tb_funcionarios WHERE usuario='" & txt_user.Text & "';"
        Dim command As New SQLiteCommand(sql, connection)
        Using reader As SQLiteDataReader = command.ExecuteReader()
            If reader.Read() Then
                Dim update_cpf As String = reader("cpf").ToString()
                Dim update_nome As String = reader("nome").ToString()
                Dim update_senha As String = reader("senha").ToString()
                Dim update_user As String = reader("usuario").ToString()
                Dim update_data As String = reader("data_nascimento").ToString()
                Dim update_email As String = reader("email").ToString()
                Dim update_telefone As String = reader("telefone").ToString()

                sql = "UPDATE tb_funcionarios SET cpf = '" & txt_cpf.Text & "', nome= '" & txt_nome.Text & "', usuario='" & txt_user.Text & "', senha='" & txt_senha.Text & "', data_nascimento='" & cmb_data.Text & "', email='" & txt_email.Text & "',telefone='" & txt_telefone.Text & "', cargo= 2 where usuario='" & update_user & "'"
                Dim command2 As New SQLiteCommand(sql, connection)
                Try
                    command2.ExecuteNonQuery()
                    MsgBox("EDIÇÃO FEITA COM SUCESSO!")
                Catch ex As Exception
                    MsgBox("Foi impossível realizar a edição do usuário!")
                End Try
            Else
                MsgBox("Não há cadastro existente com esse nome de usuário!", MsgBoxStyle.Exclamation + vbOKOnly)
            End If
        End Using
    End Sub

    Private Sub btn_criar_Click(sender As Object, e As EventArgs) Handles btn_criar.Click
        Dim sql As String = "SELECT * FROM tb_funcionarios WHERE usuario='" & txt_user.Text & "';"

        Dim command As New SQLiteCommand(sql, connection)
        Using reader As SQLiteDataReader = command.ExecuteReader()
            If reader.Read() Then
                If reader("usuario") = txt_user.Text Or reader("nome") = txt_nome.Text Then
                    MsgBox("Há um registro com esse usuário ou nome, insira outro nome ou usuário!", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical)
                    txt_user.Clear()
                    txt_nome.Clear()
                End If
            Else

                MsgBox("CRIAÇÃO EFETUADA COM SUCESSO!")
                sql = "INSERT INTO tb_funcionarios VALUES ('" & txt_cpf.Text & "','" & txt_nome.Text & "','" & txt_user.Text & "','" & txt_senha.Text & "','" & cmb_data.Text & "','" & txt_email.Text & "','" & txt_telefone.Text & "',2);"
                Dim command2 As New SQLiteCommand(sql, connection)
                command2.ExecuteNonQuery()
            End If
        End Using
    End Sub

    Private Sub Form4_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        connection.Close()
    End Sub

    Private Sub btn_deslogar_Click(sender As Object, e As EventArgs) Handles btn_deslogar.Click
        Me.Close()
        Form2.Show()
    End Sub
End Class