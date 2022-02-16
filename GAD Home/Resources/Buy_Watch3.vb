Imports System.Data.SqlClient
Imports System.Data


Public Class Buy_Watch3

    Dim connect As SqlConnection = New SqlConnection("Data Source=HP-Saurav\sqlexpress;Initial Catalog=Store;Integrated Security=True;Pooling=False")
    Dim cmd As SqlCommand
    Dim dRead As SqlDataReader
    Dim query As String
    Dim tPrice As Integer

    Private Sub Buy_Watch3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

    Private Sub Bag_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bag.Click
        Orders.Show()
        Me.Close()
    End Sub

    Private Sub WatchHome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WatchHome.Click
        Watch.Show()
        Me.Close()
    End Sub
    'Navigation End

    Private Sub White_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles White.CheckedChanged
        MainIMG.Image = My.Resources.W3white
        inBoxIMG.Image = My.Resources.W3inBoxwhite

    End Sub

    Private Sub Black_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Black.CheckedChanged
        MainIMG.Image = My.Resources.watch4
        inBoxIMG.Image = My.Resources.W3inBoxblack
    End Sub

   
    Private Sub order_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles order.Click


        Dim lol As String
        Dim Size As String
        Dim pName As String

        lol = ""
        pName = "Apple Watch series 3"
        'size = "24-inch 4.5K display"

        Dim rNum As String = ""
        Dim random As New Random()
        Dim n As Integer = random.[Next](10000, 999999)
        rNum += n.ToString("D5")


        For Each a As RadioButton In finish.Controls.OfType(Of RadioButton)()
            If a.Checked = True Then
                For Each b As RadioButton In cSize.Controls.OfType(Of RadioButton)()
                    If b.Checked = True Then

                        If cSize.Name = "small" Then
                            Size = "38 mm"
                            tPrice = 20900
                        Else
                            Size = "42 mm"
                            tPrice = 23900
                        End If

                        query = "insert into Orders values ('" + pName + "', '" + a.Name + "', '" + Size + "', '" + lol + "', '" + lol + "', '" + lol + "','" + Convert.ToString(tPrice) + "','" + rNum + "','" + LoginPG.IDbox.Text + "')"
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