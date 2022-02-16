Imports System.Data.SqlClient
Imports System.Data



Public Class Buy_iPad


    Dim connect As SqlConnection = New SqlConnection("Data Source=HP-Saurav\sqlexpress;Initial Catalog=Store;Integrated Security=True;Pooling=False")
    Dim cmd As SqlCommand
    Dim dRead As SqlDataReader
    Dim query As String
    Dim conn As String
    Dim store As String
    Dim tPrice As Integer

    Private Sub Buy_iPad_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect.Open()
    End Sub

    
    'Navigation
    Private Sub HomeB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HomeB.Click
        Home.BringToFront()
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim iMac24H As New iMac__24in
        iMac24H.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim iPad As New iPad
        iPad.Show()
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
    'End Navigation

    Private Sub Grey_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Grey.CheckedChanged
        MainIMG.Image = My.Resources.PadGrey
        inBoxIMG.Image = My.Resources.PadGreyinBox
    End Sub

    Private Sub Silver_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Silver.CheckedChanged
        MainIMG.Image = My.Resources.PadSilver
        inBoxIMG.Image = My.Resources.PadSilverinBox
    End Sub

   
    Private Sub order_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles order.Click


        Dim p1 As Integer
        Dim p2 As Integer
        Dim lol As String
        Dim pName As String

        lol = ""
        pName = "iPad"

        Dim rNum As String = ""
        Dim random As New Random()
        Dim n As Integer = random.[Next](100000, 999999)
        rNum += n.ToString("D5")

        For Each a As RadioButton In finish.Controls.OfType(Of RadioButton)()
            If a.Checked = True Then
                For Each b As RadioButton In storage.Controls.OfType(Of RadioButton)()
                    If b.Checked = True Then
                        For Each c As RadioButton In connectivity.Controls.OfType(Of RadioButton)()
                            If c.Checked = True Then

                                If b.Name = "one" Then
                                    store = "32 GB"
                                Else
                                    store = "128 GB"
                                    p1 = 8000
                                End If

                                If c.Name = "wifi" Then
                                    conn = "Wifi"
                                Else
                                    conn = "Wifi + Cellular"
                                    p2 = 12000
                                End If


                                tPrice = p1 + p2 + 29900
                                query = "insert into Orders values ('" + pName + "', '" + a.Name + "', '" + lol + "', '" + lol + "', '" + store + "', '" + conn + "','" + Convert.ToString(tPrice) + "','" + rNum + "','" + LoginPG.IDbox.Text + "')"
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
    End Sub

    Private Sub Bag_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bag.Click
        Dim order As New Orders
        order.Show()
        Me.Close()

    End Sub

    
End Class