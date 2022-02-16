<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class About
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(About))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Copyrights = New System.Windows.Forms.Label()
        Me.Credits = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(84, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(225, 83)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "About"
        '
        'Copyrights
        '
        Me.Copyrights.AutoSize = True
        Me.Copyrights.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Copyrights.Location = New System.Drawing.Point(85, 301)
        Me.Copyrights.Name = "Copyrights"
        Me.Copyrights.Size = New System.Drawing.Size(635, 210)
        Me.Copyrights.TabIndex = 1
        Me.Copyrights.Text = resources.GetString("Copyrights.Text")
        '
        'Credits
        '
        Me.Credits.AutoSize = True
        Me.Credits.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Credits.Location = New System.Drawing.Point(86, 552)
        Me.Credits.Name = "Credits"
        Me.Credits.Size = New System.Drawing.Size(574, 114)
        Me.Credits.TabIndex = 2
        Me.Credits.Text = resources.GetString("Credits.Text")
        '
        'About
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1274, 691)
        Me.Controls.Add(Me.Credits)
        Me.Controls.Add(Me.Copyrights)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "About"
        Me.Text = "About"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Copyrights As System.Windows.Forms.Label
    Friend WithEvents Credits As System.Windows.Forms.Label
End Class
