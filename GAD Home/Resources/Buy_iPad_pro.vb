Imports System.Data.SqlClient
Imports System.Data

Public Class Buy_iPad_pro

    Dim connect As SqlConnection = New SqlConnection("Data Source=HP-Saurav\sqlexpress;Initial Catalog=Store;Integrated Security=True;Pooling=False")
    Dim cmd As SqlCommand
    Dim dRead As SqlDataReader
    Dim query As String
    Dim conn As String
    Dim store As String
    Dim tPrice As Integer

    Private Sub Buy_iPad_pro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect.Open()
    End Sub

    'Navigation Bar
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HomeB.Click
        Home.BringToFront()
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim iMac24H As New iMac__24in
        iMac24H.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim iPadH As New iPad
        iPadH.Show()
        Me.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim iPhoneH As New iPhone
        iPhoneH.Show()
        Me.Close()
    End Sub

    Private Sub WatchHome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WatchHome.Click
        Watch.Show()
        Me.Close()
    End Sub
    'Navigation End

    Private Sub Silver_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Silver.CheckedChanged
        MainIMG.Image = My.Resources.ProSilver
        inBoxIMG.Image = My.Resources.ProSilverinBox
    End Sub

    Private Sub Grey_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Grey.CheckedChanged
        MainIMG.Image = My.Resources.ProGrey
        inBoxIMG.Image = My.Resources.ProGreyinBox
    End Sub

    
    Private Sub Bag_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bag.Click
        Dim order As New Orders
        order.Show()
        Me.Close()
    End Sub

    Private Sub order_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles order.Click

        Dim p1 As Integer
        Dim p2 As Integer
        Dim lol As String
        Dim size As String
        Dim pName As String

        lol = ""
        pName = "iPad pro"
        size = ""

        Dim rNum As String = ""
        Dim random As New Random()
        Dim n As Integer = random.[Next](100000, 999999)
        rNum += n.ToString("D5")


        For Each a As RadioButton In model.Controls.OfType(Of RadioButton)()
            If a.Checked = True Then
                For Each b As RadioButton In finish.Controls.OfType(Of RadioButton)()
                    If b.Checked = True Then
                        For Each c As RadioButton In storage.Controls.OfType(Of RadioButton)()
                            If c.Checked = True Then
                                For Each d As RadioButton In connectivity.Controls.OfType(Of RadioButton)()
                                    If d.Checked = True Then

                                        'storage
                                        If c.Name = "one" Then
                                            store = "128 GB"
                                        ElseIf c.Name = "two" Then
                                            store = "256 GB"
                                            p1 = 9000
                                        ElseIf c.Name = "three" Then
                                            store = "512 GB"
                                            p1 = 27000
                                        ElseIf c.Name = "four" Then
                                            store = "1 TB"
                                            p1 = 63000
                                        Else
                                            store = "2 TB"
                                            p1 = 99000
                                        End If

                                        'connectivity
                                        If c.Name = "wifi" Then
                                            conn = "Wifi"
                                        Else
                                            conn = "Wifi + Cellular"
                                            p2 = 14000
                                        End If

                                        'size
                                        If a.Name = "small" Then
                                            size = "11-inch LRD Display"
                                            tPrice = 71900
                                        Else
                                            size = "12.9-inch XDR Display"
                                            tPrice = 99900
                                        End If

                                        tPrice = tPrice + p1 + p2

                                        query = "insert into Orders values ('" + pName + "', '" + b.Name + "', '" + size + "', '" + lol + "', '" + store + "', '" + conn + "','" + Convert.ToString(tPrice) + "','" + rNum + "','" + LoginPG.IDbox.Text + "')"
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
                    End If
                Next
                    End If
        Next
    End Sub

   
End Class