Imports System.Data.SqlClient
Imports System.Data

Public Class LoginPG

    Dim connect As SqlConnection = New SqlConnection("Data Source=HP-Saurav\sqlexpress;Initial Catalog=Store;Integrated Security=True;Pooling=False")
    Dim cmd As SqlCommand
    Dim dRead As SqlDataReader

    Private Sub LoginPG_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect.Open()
    End Sub

    Public Sub Signin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Signin.Click


        'IDbox.Text
        'PASSbox.Text

        If IDbox.Text = "" Then
            MsgBox("Enter ID!.", MsgBoxStyle.Critical)
        ElseIf PASSbox.Text = "" Then
            MsgBox("Enter Password!.", MsgBoxStyle.Critical)
        Else
            Dim query As String
            query = "select * from Login where ID = '" + IDbox.Text + "' and Password = '" + PASSbox.Text + "'"
            cmd = New SqlCommand(query, connect)

            Dim dAdapter As SqlDataAdapter = New SqlDataAdapter(cmd)
            Dim dSet As DataSet = New DataSet()
            dAdapter.Fill(dSet)


            Dim a As Integer
            a = dSet.Tables(0).Rows.Count

            If a = 0 Then
                MsgBox("Login fail!, Enter valid credentials", MsgBoxStyle.Critical)
                connect.Close()
            Else
                MsgBox("Logged-in successfully!", MsgBoxStyle.Information)
                Me.Hide()
                wait()
                Dim Home As New Home()
                AddHandler Home.FormClosed, AddressOf Home_FormClosed
                Home.Show()
                
            End If
        End If
    End Sub


    Private Sub createAC_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles createAC.LinkClicked
        Me.SendToBack()
        Create_Account.Show()

    End Sub

    Private Sub Home_FormClosed(ByVal sender As Object, ByVal e As FormClosedEventArgs)
        Me.Close()
    End Sub

    Private Sub wait()

        Dim num As Integer
        While num <> 811
            Splash2.Show()
            Dim rNum As String = ""
            Dim random As New Random()
            Dim n As Integer = random.[Next](1, 1000)
            rNum += n.ToString("D5")
            num = Convert.ToInt32(rNum)
            If num = 811 Then
                My.Computer.Audio.Play(My.Resources.Startup1, AudioPlayMode.WaitToComplete)
                Splash2.Close()
                Exit While
            End If
        End While

    End Sub

End Class

