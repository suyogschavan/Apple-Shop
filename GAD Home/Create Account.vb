Imports System.Data.SqlClient
Imports System.Data

Public Class Create_Account

    Dim connect As SqlConnection = New SqlConnection("Data Source=HP-Saurav\sqlexpress;Initial Catalog=Store;Integrated Security=True;Pooling=False")
    Dim cmd As SqlCommand
    Dim dRead As SqlDataReader

    Private Sub Create_Account_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect.Open()
    End Sub

    Private Sub CreateAC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreateAC.Click

        If IDbox.Text = "" Then
            MsgBox("Enter ID!.", MsgBoxStyle.Critical)
        ElseIf PASSbox.Text = "" Then
            MsgBox("Enter Password!.", MsgBoxStyle.Critical)
        Else
            cmd = New SqlCommand("insert into Login values ('" + IDbox.Text + "','" + PASSbox.Text + "')", connect)

            Dim a As Integer = cmd.ExecuteNonQuery()
            If a = 0 Then
                MsgBox("Error", MsgBoxStyle.Critical)
            Else
                MsgBox("Account created successfully!!", MsgBoxStyle.Information)
                connect.Close()
                LoginPG.BringToFront()
                Me.Close()
            End If

        End If


    End Sub

End Class