Imports System.ComponentModel
Imports System.Data.SQLite
Imports System.IO

Public Class Form5
    Private dbCommand As String = ""
    Private bindingSrc As BindingSource
    Private diretorio As String
    Private dbName As String = "banco.db"
    Private dbPath As String = Application.StartupPath & "\banco\" & dbName
    Private conString As String = "Data Source=" & dbPath & ";Version=3"
    Private connection As New SQLiteConnection(conString)

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_nome.Focus()

        connection.Open()
    End Sub

    Private Sub btn_criar_Click(sender As Object, e As EventArgs) Handles btn_criar.Click
        Dim sql As String = "SELECT * FROM tb_clientes WHERE cpf='" & txt_cpf.Text & "';"

        Dim command As New SQLiteCommand(sql, connection)
        Using reader As SQLiteDataReader = command.ExecuteReader()
            If reader.Read() Then
                If reader("cpf") = txt_cpf.Text Then
                    MsgBox("Há um registro com esse CPF:  insira outro cpf!", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical)
                    txt_cpf.Clear()
                End If
            Else
                sql = "INSERT INTO tb_clientes VALUES ('" & txt_cpf.Text & "','" & txt_nome.Text & "','" & txt_email.Text & "','" & cmb_data.Text & "','" & txt_telefone.Text & "','" & diretorio & "');"
                Dim command2 As New SQLiteCommand(sql, connection)
                command2.ExecuteNonQuery()
                MsgBox("CRIAÇÃO EFETUADA COM SUCESSO!", MsgBoxStyle.Information + vbOKOnly)
                Try
                    command2.ExecuteNonQuery()
                    MsgBox("CRIAÇÃO EFETUADA COM SUCESSO!", MsgBoxStyle.Information + vbOKOnly)
                Catch ex As Exception
                    MsgBox("Foi impossível realizar a criação, aqui há algumas possíveis razões!" + vbNewLine &
                       "1. Você tentou criar uma conta com usuário ou CPF já registrados no sistema;" + vbNewLine &
                       "2. Você já fez o cadastro dessa conta;" + vbNewLine &
                      "3. Você não completou todos os campos apropriadamente;" + vbNewLine &
                     "4. Você deixou pelo menos um campo vazio. ", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
                End Try
            End If
        End Using
    End Sub

    Private Sub btn_editar_Click(sender As Object, e As EventArgs) Handles btn_editar.Click
        Dim sql As String = "SELECT * FROM tb_clientes WHERE cpf='" & txt_cpf.Text & "';"
        Dim command As New SQLiteCommand(sql, connection)
        Using reader As SQLiteDataReader = command.ExecuteReader()
            If reader.Read() Then
                Dim update_cpf As String = reader("cpf").ToString()
                Dim update_nome As String = reader("nome").ToString()
                Dim update_email As String = reader("email").ToString()
                Dim update_data As String = reader("data_nasc").ToString()
                Dim update_telefone As String = reader("telefone").ToString()
                Dim update_foto As String = reader("foto").ToString()

                sql = "UPDATE tb_clientes SET cpf = '" & txt_cpf.Text & "', nome= '" & txt_nome.Text & "', email='" & txt_email.Text & "', data_nasc='" & cmb_data.Text & "',telefone='" & txt_telefone.Text & "',foto='" & diretorio & "' WHERE cpf='" & update_cpf & "'"
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

    Private Sub btn_deletar_Click(sender As Object, e As EventArgs) Handles btn_deletar.Click
        Dim sql As String = "SELECT * FROM tb_clientes WHERE cpf='" & txt_cpf.Text & "';"
        Dim command As New SQLiteCommand(sql, connection)
        Using reader As SQLiteDataReader = command.ExecuteReader()
            If reader.Read() Then
                sql = "DELETE FROM tb_clientes WHERE cpf= '" & txt_cpf.Text & "'"
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

    Private Sub pb_foto_Click(sender As Object, e As EventArgs) Handles pb_foto.Click
        Try
            With OpenFileDialog1
                .Title = "Selecione uma Foto"
                .InitialDirectory = Application.StartupPath & "\fotos_clientes"
                .ShowDialog()
                diretorio = .FileName
                pb_foto.Load(diretorio)
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub
End Class