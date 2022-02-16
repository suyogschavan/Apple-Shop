Imports System.Data.SqlClient
Imports System.Data


Public Class Orders

    Dim connect As SqlConnection = New SqlConnection("Data Source=HP-Saurav\sqlexpress;Initial Catalog=Store;Integrated Security=True;Pooling=False")
    Dim cmd As SqlCommand
    Dim dRead As SqlDataReader
    Dim dAdapter As SqlDataAdapter
    Dim dSet As New DataSet()
    Dim query As String
    Dim mem As String
    Dim store As String

    Private Sub Orders_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect.Open()
        'TODO: This line of code loads data into the 'StoreDataSet2.Orders' table. You can move, or remove it, as needed.
        Me.OrdersTableAdapter2.Fill(Me.StoreDataSet2.Orders)
        'TODO: This line of code loads data into the 'StoreDataSet1.Orders' table. You can move, or remove it, as needed.
        Me.OrdersTableAdapter1.Fill(Me.StoreDataSet1.Orders)
        'TODO: This line of code loads data into the 'StoreDataSet.Orders' table. You can move, or remove it, as needed.
        Me.OrdersTableAdapter.Fill(Me.StoreDataSet.Orders)
        cmd = New SqlCommand("select * from Orders where User_ID='" + LoginPG.IDbox.Text + "'", connect)
        dAdapter = New SqlDataAdapter(cmd)
        dAdapter.Fill(dSet, "Orders")
        AllView.DataSource = dSet.Tables("Orders")

        cBox.Visible = False
        Cancel.Visible = False


    End Sub

    Private Sub Cancell_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click

        cmd = New SqlCommand("delete from Orders where Order_ID='" + cBox.Text + "'", connect)
        cmd.CommandType = CommandType.Text
        Dim x As Integer = cmd.ExecuteNonQuery()

        If x = 0 Then
            MsgBox("Error", MsgBoxStyle.Critical)
        Else
            MsgBox("Your order has been cancelled!", MsgBoxStyle.Information)
            connect.Close()
            Me.Close()
            Home.BringToFront()
        End If
    End Sub

    'Navigation Bar

    Private Sub Home_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HomeB.Click
        Me.Close()
        Home.BringToFront()

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

    Private Sub canc_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles canc.LinkClicked
        cBox.Visible = True
        Cancel.Visible = True
        canc.Visible = False
    End Sub

    
End Class