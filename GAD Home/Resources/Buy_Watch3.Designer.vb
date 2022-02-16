<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Buy_Watch3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Buy_Watch3))
        Me.WatchHome = New System.Windows.Forms.Button()
        Me.iPhoneHome = New System.Windows.Forms.Button()
        Me.iPadHome = New System.Windows.Forms.Button()
        Me.iMacHome = New System.Windows.Forms.Button()
        Me.ListView2 = New System.Windows.Forms.ListView()
        Me.cSize = New System.Windows.Forms.GroupBox()
        Me.large = New System.Windows.Forms.RadioButton()
        Me.small = New System.Windows.Forms.RadioButton()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.finish = New System.Windows.Forms.GroupBox()
        Me.Black = New System.Windows.Forms.RadioButton()
        Me.White = New System.Windows.Forms.RadioButton()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.order = New System.Windows.Forms.Button()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.inBoxIMG = New System.Windows.Forms.PictureBox()
        Me.MainIMG = New System.Windows.Forms.PictureBox()
        Me.Bag = New System.Windows.Forms.PictureBox()
        Me.HomeB = New System.Windows.Forms.PictureBox()
        Me.cSize.SuspendLayout()
        Me.finish.SuspendLayout()
        CType(Me.inBoxIMG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MainIMG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bag, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HomeB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'WatchHome
        '
        Me.WatchHome.BackColor = System.Drawing.SystemColors.GrayText
        Me.WatchHome.FlatAppearance.BorderSize = 0
        Me.WatchHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.WatchHome.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.WatchHome.Location = New System.Drawing.Point(836, 9)
        Me.WatchHome.Margin = New System.Windows.Forms.Padding(2)
        Me.WatchHome.Name = "WatchHome"
        Me.WatchHome.Size = New System.Drawing.Size(48, 35)
        Me.WatchHome.TabIndex = 105
        Me.WatchHome.Text = "Watch"
        Me.WatchHome.UseVisualStyleBackColor = False
        '
        'iPhoneHome
        '
        Me.iPhoneHome.BackColor = System.Drawing.SystemColors.GrayText
        Me.iPhoneHome.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.iPhoneHome.FlatAppearance.BorderSize = 0
        Me.iPhoneHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.iPhoneHome.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.iPhoneHome.Location = New System.Drawing.Point(658, 8)
        Me.iPhoneHome.Margin = New System.Windows.Forms.Padding(2)
        Me.iPhoneHome.Name = "iPhoneHome"
        Me.iPhoneHome.Size = New System.Drawing.Size(48, 35)
        Me.iPhoneHome.TabIndex = 104
        Me.iPhoneHome.Text = "iPhone"
        Me.iPhoneHome.UseVisualStyleBackColor = False
        '
        'iPadHome
        '
        Me.iPadHome.BackColor = System.Drawing.SystemColors.GrayText
        Me.iPadHome.FlatAppearance.BorderSize = 0
        Me.iPadHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.iPadHome.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.iPadHome.Location = New System.Drawing.Point(483, 8)
        Me.iPadHome.Margin = New System.Windows.Forms.Padding(2)
        Me.iPadHome.Name = "iPadHome"
        Me.iPadHome.Size = New System.Drawing.Size(48, 35)
        Me.iPadHome.TabIndex = 103
        Me.iPadHome.Text = "iPad"
        Me.iPadHome.UseVisualStyleBackColor = False
        '
        'iMacHome
        '
        Me.iMacHome.BackColor = System.Drawing.SystemColors.GrayText
        Me.iMacHome.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.iMacHome.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.iMacHome.FlatAppearance.BorderSize = 0
        Me.iMacHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.iMacHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.iMacHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.iMacHome.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.iMacHome.Location = New System.Drawing.Point(310, 4)
        Me.iMacHome.Margin = New System.Windows.Forms.Padding(2)
        Me.iMacHome.Name = "iMacHome"
        Me.iMacHome.Size = New System.Drawing.Size(48, 43)
        Me.iMacHome.TabIndex = 102
        Me.iMacHome.Text = "Mac"
        Me.iMacHome.UseVisualStyleBackColor = False
        '
        'ListView2
        '
        Me.ListView2.BackColor = System.Drawing.SystemColors.GrayText
        Me.ListView2.Location = New System.Drawing.Point(0, 0)
        Me.ListView2.Margin = New System.Windows.Forms.Padding(2)
        Me.ListView2.Name = "ListView2"
        Me.ListView2.Size = New System.Drawing.Size(1276, 49)
        Me.ListView2.TabIndex = 107
        Me.ListView2.UseCompatibleStateImageBehavior = False
        '
        'cSize
        '
        Me.cSize.Controls.Add(Me.large)
        Me.cSize.Controls.Add(Me.small)
        Me.cSize.Controls.Add(Me.TextBox1)
        Me.cSize.Location = New System.Drawing.Point(873, 313)
        Me.cSize.Name = "cSize"
        Me.cSize.Size = New System.Drawing.Size(198, 153)
        Me.cSize.TabIndex = 127
        Me.cSize.TabStop = False
        '
        'large
        '
        Me.large.AutoSize = True
        Me.large.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.large.Location = New System.Drawing.Point(40, 105)
        Me.large.Margin = New System.Windows.Forms.Padding(2)
        Me.large.Name = "large"
        Me.large.Size = New System.Drawing.Size(69, 24)
        Me.large.TabIndex = 100
        Me.large.TabStop = True
        Me.large.Text = "42mm"
        Me.large.UseVisualStyleBackColor = True
        '
        'small
        '
        Me.small.AutoSize = True
        Me.small.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.small.Location = New System.Drawing.Point(40, 58)
        Me.small.Margin = New System.Windows.Forms.Padding(2)
        Me.small.Name = "small"
        Me.small.Size = New System.Drawing.Size(69, 24)
        Me.small.TabIndex = 99
        Me.small.TabStop = True
        Me.small.Text = "38mm"
        Me.small.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.HighlightText
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(22, 14)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(152, 40)
        Me.TextBox1.TabIndex = 98
        Me.TextBox1.Text = "Case Size"
        '
        'finish
        '
        Me.finish.Controls.Add(Me.Black)
        Me.finish.Controls.Add(Me.White)
        Me.finish.Controls.Add(Me.TextBox2)
        Me.finish.Location = New System.Drawing.Point(874, 103)
        Me.finish.Name = "finish"
        Me.finish.Size = New System.Drawing.Size(197, 165)
        Me.finish.TabIndex = 126
        Me.finish.TabStop = False
        '
        'Black
        '
        Me.Black.AutoSize = True
        Me.Black.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Black.Location = New System.Drawing.Point(39, 115)
        Me.Black.Margin = New System.Windows.Forms.Padding(2)
        Me.Black.Name = "Black"
        Me.Black.Size = New System.Drawing.Size(63, 24)
        Me.Black.TabIndex = 98
        Me.Black.TabStop = True
        Me.Black.Text = "Black"
        Me.Black.UseVisualStyleBackColor = True
        '
        'White
        '
        Me.White.AutoSize = True
        Me.White.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.White.Location = New System.Drawing.Point(39, 65)
        Me.White.Margin = New System.Windows.Forms.Padding(2)
        Me.White.Name = "White"
        Me.White.Size = New System.Drawing.Size(67, 24)
        Me.White.TabIndex = 97
        Me.White.TabStop = True
        Me.White.Text = "White"
        Me.White.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.SystemColors.HighlightText
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(22, 10)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(152, 40)
        Me.TextBox2.TabIndex = 96
        Me.TextBox2.Text = "Strap Colour"
        '
        'order
        '
        Me.order.BackColor = System.Drawing.Color.DodgerBlue
        Me.order.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.order.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.order.ForeColor = System.Drawing.Color.White
        Me.order.Location = New System.Drawing.Point(931, 644)
        Me.order.Margin = New System.Windows.Forms.Padding(2)
        Me.order.Name = "order"
        Me.order.Size = New System.Drawing.Size(116, 39)
        Me.order.TabIndex = 125
        Me.order.Text = "Place Order"
        Me.order.UseVisualStyleBackColor = False
        '
        'TextBox5
        '
        Me.TextBox5.BackColor = System.Drawing.SystemColors.HighlightText
        Me.TextBox5.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox5.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(895, 543)
        Me.TextBox5.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox5.Multiline = True
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(152, 97)
        Me.TextBox5.TabIndex = 124
        Me.TextBox5.Text = "Strap Size: Regular" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Strap fits 140–210mm wrists."
        '
        'TextBox4
        '
        Me.TextBox4.BackColor = System.Drawing.SystemColors.HighlightText
        Me.TextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox4.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(895, 448)
        Me.TextBox4.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(112, 37)
        Me.TextBox4.TabIndex = 123
        Me.TextBox4.Text = "GPS + Cellular" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.SystemColors.HighlightText
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(895, 490)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 49)
        Me.TextBox3.TabIndex = 122
        Me.TextBox3.Text = "Connectivity" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "GPS" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'inBoxIMG
        '
        Me.inBoxIMG.Image = Global.Apple.My.Resources.Resources.W3inBoxwhite
        Me.inBoxIMG.Location = New System.Drawing.Point(139, 765)
        Me.inBoxIMG.Margin = New System.Windows.Forms.Padding(2)
        Me.inBoxIMG.Name = "inBoxIMG"
        Me.inBoxIMG.Size = New System.Drawing.Size(993, 494)
        Me.inBoxIMG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.inBoxIMG.TabIndex = 129
        Me.inBoxIMG.TabStop = False
        '
        'MainIMG
        '
        Me.MainIMG.Image = Global.Apple.My.Resources.Resources.W3white
        Me.MainIMG.Location = New System.Drawing.Point(99, 103)
        Me.MainIMG.Margin = New System.Windows.Forms.Padding(2)
        Me.MainIMG.Name = "MainIMG"
        Me.MainIMG.Size = New System.Drawing.Size(517, 640)
        Me.MainIMG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.MainIMG.TabIndex = 128
        Me.MainIMG.TabStop = False
        '
        'Bag
        '
        Me.Bag.BackColor = System.Drawing.SystemColors.GrayText
        Me.Bag.Image = Global.Apple.My.Resources.Resources.shopping_bag_24px
        Me.Bag.Location = New System.Drawing.Point(1009, 12)
        Me.Bag.Margin = New System.Windows.Forms.Padding(2)
        Me.Bag.Name = "Bag"
        Me.Bag.Size = New System.Drawing.Size(28, 30)
        Me.Bag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.Bag.TabIndex = 108
        Me.Bag.TabStop = False
        '
        'HomeB
        '
        Me.HomeB.BackColor = System.Drawing.SystemColors.GrayText
        Me.HomeB.Image = CType(resources.GetObject("HomeB.Image"), System.Drawing.Image)
        Me.HomeB.Location = New System.Drawing.Point(162, 12)
        Me.HomeB.Margin = New System.Windows.Forms.Padding(2)
        Me.HomeB.Name = "HomeB"
        Me.HomeB.Size = New System.Drawing.Size(30, 23)
        Me.HomeB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.HomeB.TabIndex = 106
        Me.HomeB.TabStop = False
        '
        'Buy_Watch3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1274, 691)
        Me.Controls.Add(Me.inBoxIMG)
        Me.Controls.Add(Me.MainIMG)
        Me.Controls.Add(Me.cSize)
        Me.Controls.Add(Me.finish)
        Me.Controls.Add(Me.order)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Bag)
        Me.Controls.Add(Me.HomeB)
        Me.Controls.Add(Me.WatchHome)
        Me.Controls.Add(Me.iPhoneHome)
        Me.Controls.Add(Me.iPadHome)
        Me.Controls.Add(Me.iMacHome)
        Me.Controls.Add(Me.ListView2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Buy_Watch3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buy Apple watch series 3"
        Me.cSize.ResumeLayout(False)
        Me.cSize.PerformLayout()
        Me.finish.ResumeLayout(False)
        Me.finish.PerformLayout()
        CType(Me.inBoxIMG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MainIMG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bag, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HomeB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Bag As System.Windows.Forms.PictureBox
    Friend WithEvents HomeB As System.Windows.Forms.PictureBox
    Friend WithEvents WatchHome As System.Windows.Forms.Button
    Friend WithEvents iPhoneHome As System.Windows.Forms.Button
    Friend WithEvents iPadHome As System.Windows.Forms.Button
    Friend WithEvents iMacHome As System.Windows.Forms.Button
    Friend WithEvents ListView2 As System.Windows.Forms.ListView
    Friend WithEvents cSize As System.Windows.Forms.GroupBox
    Friend WithEvents large As System.Windows.Forms.RadioButton
    Friend WithEvents small As System.Windows.Forms.RadioButton
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents finish As System.Windows.Forms.GroupBox
    Friend WithEvents Black As System.Windows.Forms.RadioButton
    Friend WithEvents White As System.Windows.Forms.RadioButton
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents order As System.Windows.Forms.Button
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents MainIMG As System.Windows.Forms.PictureBox
    Friend WithEvents inBoxIMG As System.Windows.Forms.PictureBox
End Class
