Public Class Home
    'Navigation Bar
    Public Sub iPadHome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles iPadHome.Click
        Dim iPadH As New iPad
        iPadH.Show()
    End Sub

    Private Sub iPhoneHome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles iPhoneHome.Click
        Dim iPhoneH As New iPhone
        iPhoneH.Show()
    End Sub

    Private Sub iMacHome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles iMacHome.Click
        Dim iMac24H As New iMac__24in
        iMac24H.Show()
    End Sub
    'Navigation End


    Private Sub BuyiPadpro_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles BuyiPadpro.LinkClicked
        Dim iPadProBuy As New Buy_iPad_pro
        iPadProBuy.Show()
    End Sub

    Private Sub BuyiPhone12_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles BuyiPhone12.LinkClicked
        Dim BuyiPhone12 As New Buy_iPhone1
        BuyiPhone12.Show()
    End Sub

    Private Sub BuyiMac_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles BuyiMac.LinkClicked
        Dim BuyiMac24 As New Buy_iMac24
        BuyiMac24.Show()
    End Sub

    Private Sub Buy12pro_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles Buy12pro.LinkClicked
        Dim Buy12Pro As New Buy_iPhone2
        Buy12Pro.Show()
    End Sub

    Private Sub Apple_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Apple.Click
        About.Show()
    End Sub

   
    Private Sub WatchHome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WatchHome.Click
        Dim watch As New Watch
        'Me.SendToBack()
        watch.Show()
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Bag.Show()
    End Sub

    Private Sub Bag_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bag.Click
        Orders.Show()
    End Sub

End Class