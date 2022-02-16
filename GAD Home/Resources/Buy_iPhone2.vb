Imports System.Data.SqlClient
Imports System.Data

Public Class Buy_iPhone2

    Dim connect As SqlConnection = New SqlConnection("Data Source=HP-Saurav\sqlexpress;Initial Catalog=Store;Integrated Security=True;Pooling=False")
    Dim cmd As SqlCommand
    Dim dRead As SqlDataReader
    Dim query As String
    Dim store As String
    Dim tPrice As Integer

    Private Sub Buy_iPhone2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect.Open()
    End Sub

    'Navigation Bar

    Private Sub Home_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HomeB.Click
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

    Private Sub Graphite_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Graphite.CheckedChanged
        MainIMG.Image = My.Resources._12proGraphite
        inBoxIMG.Image = My.Resources._12proGraphiteinBox
    End Sub

    Private Sub Silver_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Silver.CheckedChanged
        MainIMG.Image = My.Resources._12proSilver
        inBoxIMG.Image = My.Resources._12proSilverinBox
    End Sub

    Private Sub Gold_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Gold.CheckedChanged
        MainIMG.Image = My.Resources._12proGold
        inBoxIMG.Image = My.Resources._12proGoldinBox
    End Sub

    Private Sub Blue_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Blue.CheckedChanged
        MainIMG.Image = My.Resources._12proBlue
        inBoxIMG.Image = My.Resources._12proBlueinBox
    End Sub

    Private Sub Bag_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bag.Click
        Dim order As New Orders
        order.Show()
        Me.Close()
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
                            store = "128 GB"
                        ElseIf c.Name = "two" Then
                            store = "256 GB"
                            p1 = 10000
                        Else
                            store = "512 GB"
                            p1 = 30000
                        End If

                        'Model
                        If model.SelectedItem = "iPhone 12 Pro" Then
                            tPrice = 119900
                            size = "6.1-inch display"
                        Else
                            tPrice = 129900
                            size = "6.7-inch display"
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

    
End Class