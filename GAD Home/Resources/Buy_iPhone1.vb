Imports System.Data.SqlClient
Imports System.Data


Public Class Buy_iPhone1

    Dim connect As SqlConnection = New SqlConnection("Data Source=HP-Saurav\sqlexpress;Initial Catalog=Store;Integrated Security=True;Pooling=False")
    Dim cmd As SqlCommand
    Dim dRead As SqlDataReader
    Dim query As String
    Dim store As String
    Dim tPrice As Integer

    Private Sub Buy_iPhone1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Green.Visible = False
        Blue.Visible = False
        Purple.Visible = False
        connect.Open()
    End Sub

    'Navigation Bar

    Private Sub Home_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HomeB.Click
        Home.BringToFront()
        Me.Close()
    End Sub

    Public Sub iPadHome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles iPadHome.Click
        Dim iPadH As New iPad
        iPadH.Show()
        Me.Close()
    End Sub

    Private Sub iPhoneHome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles iPhoneHome.Click
        Dim iPhoneH As New iPhone
        iPhoneH.Show()
        Me.Close()
    End Sub

    Private Sub iMacHome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles iMacHome.Click
        Dim iMac24H As New iMac__24in
        iMac24H.Show()
        Me.Close()
    End Sub

    Private Sub WatchHome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WatchHome.Click
        Watch.Show()
        Me.Close()
    End Sub
    'Navigation End

    Private Sub ComboBox1_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles model.SelectedIndexChanged
        If (model.SelectedItem = "iPhone SE") Then
            MainIMG.Image = My.Resources.SE
            Green.Visible = False
            Blue.Visible = False
            Purple.Visible = False
        Else
            MainIMG.Image = My.Resources.iPhone12DEF
            Green.Visible = True
            Blue.Visible = True
            Purple.Visible = True
        End If
    End Sub

    Private Sub White_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles White.CheckedChanged

        If model.SelectedItem = "iPhone SE" Then
            MainIMG.Image = My.Resources.SE_white
            inBoxIMG.Image = My.Resources.SE_inBoxWhite
        Else
            MainIMG.Image = My.Resources._12miniWhite
            inBoxIMG.Image = My.Resources._12miniWhiteinBox
        End If

    End Sub

    Private Sub Black_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Black.CheckedChanged
        If model.SelectedItem = "iPhone SE" Then
            MainIMG.Image = My.Resources.SE_Black
            inBoxIMG.Image = My.Resources.SE_inBox
        Else
            MainIMG.Image = My.Resources._12miniBlack
            inBoxIMG.Image = My.Resources._12miniBlackinBox
        End If
    End Sub

    Private Sub Red_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Red.CheckedChanged
        If model.SelectedItem = "iPhone SE" Then
            MainIMG.Image = My.Resources.SE_Red
            inBoxIMG.Image = My.Resources.SE_inBoxRed

        Else
            MainIMG.Image = My.Resources._12miniRed
            inBoxIMG.Image = My.Resources._12miniRedinbox
        End If
    End Sub

    Private Sub Green_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Green.CheckedChanged
        MainIMG.Image = My.Resources._12miniGreen
        inBoxIMG.Image = My.Resources._12miniGreeninBox
    End Sub

    Private Sub Blue_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Blue.CheckedChanged
        MainIMG.Image = My.Resources._12miniBlue
        inBoxIMG.Image = My.Resources._12miniBlueinBox
    End Sub

    Private Sub Purple_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Purple.CheckedChanged
        MainIMG.Image = My.Resources._12miniPurple
        inBoxIMG.Image = My.Resources._12miniPurpleinBox
    End Sub

    Private Sub order_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles order.Click

        Dim p1 As Integer
        Dim lol As String
        Dim size As String
        size = ""
        lol = ""

        Dim rNum As String = ""
        Dim random As New Random()
        Dim n As Integer = random.[Next](100000, 999999)
        rNum += n.ToString("D5")

        If model.SelectedIndex < 0 Then
            model.SelectedIndex = 0    ' The first item has index 0 '
        End If
        
                For Each b As RadioButton In finish.Controls.OfType(Of RadioButton)()
                    If b.Checked = True Then
                        For Each c As RadioButton In storage.Controls.OfType(Of RadioButton)()
                            If c.Checked = True Then

                        'storage
                        If c.Name = "one" Then
                            store = "64 GB"
                        ElseIf c.Name = "two" Then
                            store = "128 GB"
                            p1 = 5000
                        Else
                            store = "256 GB"
                            p1 = 15000
                        End If

                        'Model
                        If model.SelectedItem = "iPhone SE" Then
                            tPrice = 39900
                        ElseIf model.SelectedItem = "iPhone 12 mini" Then
                            tPrice = 69900
                            size = "5.4-inch display"
                        Else
                            tPrice = 79900
                            size = "6.1-inch display"
                        End If

                        tPrice = tPrice + p1

                        query = "insert into Orders values ('" + model.SelectedItem + "', '" + b.Name + "', '" + size + "', '" + lol + "', '" + store + "', '" + lol + "','" + Convert.ToString(tPrice) + "','" + rNum + "','" + LoginPG.IDbox.Text + "')"
                                cmd = New SqlCommand(query, connect)
                                Dim x As Integer = cmd.ExecuteNonQuery()

                                If x = 0 Then
                                    MsgBox("Error", MsgBoxStyle.Critical)
                                Else
                                    MsgBox("Order placed successfully!", MsgBoxStyle.Information)
                                    connect.Close()
                                End If

                            End If
                        Next
                    End If
                Next
    End Sub

    Private Sub Bag_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bag.Click
        Dim order As New Orders
        order.Show()
        Me.Close()
    End Sub

    
End Class