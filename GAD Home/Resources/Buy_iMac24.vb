Imports System.Data.SqlClient
Imports System.Data


Public Class Buy_iMac24

    Dim connect As SqlConnection = New SqlConnection("Data Source=HP-Saurav\sqlexpress;Initial Catalog=Store;Integrated Security=True;Pooling=False")
    Dim cmd As SqlCommand
    Dim dRead As SqlDataReader
    Dim query As String
    Dim mem As String
    Dim store As String
    Dim tPrice As Integer

    Public Sub Buy_iMac24_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

    Private Sub watchHome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles watchHome.Click
        Watch.Show()
        Me.Close()
    End Sub
    'Navigation End

    Private Sub Blue_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Blue.CheckedChanged
        MainIMG.Image = My.Resources.iMac_Blue
        inBoxIMG.Image = My.Resources.iMac_Blue_inBox
    End Sub

    Private Sub Orange_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Orange.CheckedChanged
        MainIMG.Image = My.Resources.iMac_Orange
    End Sub

    Private Sub Pink_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pink.CheckedChanged
        MainIMG.Image = My.Resources.iMac_Pink
    End Sub

    Private Sub Yellow_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Yellow.CheckedChanged
        MainIMG.Image = My.Resources.iMac_Yellow
    End Sub

    Private Sub Purple_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Purple.CheckedChanged
        MainIMG.Image = My.Resources.iMac_Purple
    End Sub

   
    Public Sub order_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles order.Click



        Dim p1 As Integer
        Dim p2 As Integer
        Dim lol As String
        Dim size As String
        Dim pName As String
        'Dim num As Integer

        lol = ""
        pName = "M1 iMac"
        size = "24-inch 4.5K display"

        Dim rNum As String = ""
        Dim random As New Random()
        Dim n As Integer = random.[Next](10000, 999999)
        rNum += n.ToString("D5")


        For Each a As RadioButton In finish.Controls.OfType(Of RadioButton)()
            If a.Checked = True Then
                For Each b As RadioButton In memory.Controls.OfType(Of RadioButton)()
                    If b.Checked = True Then
                        For Each c As RadioButton In storage.Controls.OfType(Of RadioButton)()
                            If c.Checked = True Then


                                If b.Name = "memOne" Then
                                    mem = "8 GB Unified memory"
                                Else
                                    mem = "16 GB Unified memory"
                                    p1 = 20000
                                End If

                                If c.Name = "one" Then
                                    store = "256 GB"
                                ElseIf c.Name = "two" Then
                                    store = "512 GB"
                                    p2 = 20000
                                ElseIf c.Name = "three" Then
                                    store = "1 TB"
                                    p2 = 40000
                                Else
                                    store = "2 TB"
                                    p2 = 80000
                                End If

                                tPrice = p1 + p2 + 139900
                                query = "insert into Orders values ('" + pName + "', '" + a.Name + "', '" + size + "', '" + mem + "', '" + store + "', '" + lol + "','" + Convert.ToString(tPrice) + "','" + rNum + "','" + LoginPG.IDbox.Text + "')"
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






