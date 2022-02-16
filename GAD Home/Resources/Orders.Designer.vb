<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Orders
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Orders))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OrdersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StoreDataSet = New Apple.StoreDataSet()
        Me.OrdersTableAdapter = New Apple.StoreDataSetTableAdapters.OrdersTableAdapter()
        Me.OrdersBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.StoreDataSet1 = New Apple.StoreDataSet1()
        Me.OrdersTableAdapter1 = New Apple.StoreDataSet1TableAdapters.OrdersTableAdapter()
        Me.AllView = New System.Windows.Forms.DataGridView()
        Me.ProductNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FinishDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SizeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MemoryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StorageDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ConnectivityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrderIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrdersBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.StoreDataSet2 = New Apple.StoreDataSet2()
        Me.OrdersTableAdapter2 = New Apple.StoreDataSet2TableAdapters.OrdersTableAdapter()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.WatchHome = New System.Windows.Forms.Button()
        Me.iPhoneHome = New System.Windows.Forms.Button()
        Me.iPadHome = New System.Windows.Forms.Button()
        Me.iMacHome = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.cBox = New System.Windows.Forms.TextBox()
        Me.Bag = New System.Windows.Forms.PictureBox()
        Me.HomeB = New System.Windows.Forms.PictureBox()
        Me.canc = New System.Windows.Forms.LinkLabel()
        CType(Me.OrdersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StoreDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrdersBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StoreDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AllView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrdersBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StoreDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bag, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HomeB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(56, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(603, 62)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Products you've ordered."
        '
        'OrdersBindingSource
        '
        Me.OrdersBindingSource.DataMember = "Orders"
        Me.OrdersBindingSource.DataSource = Me.StoreDataSet
        '
        'StoreDataSet
        '
        Me.StoreDataSet.DataSetName = "StoreDataSet"
        Me.StoreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OrdersTableAdapter
        '
        Me.OrdersTableAdapter.ClearBeforeFill = True
        '
        'OrdersBindingSource1
        '
        Me.OrdersBindingSource1.DataMember = "Orders"
        Me.OrdersBindingSource1.DataSource = Me.StoreDataSet1
        '
        'StoreDataSet1
        '
        Me.StoreDataSet1.DataSetName = "StoreDataSet1"
        Me.StoreDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OrdersTableAdapter1
        '
        Me.OrdersTableAdapter1.ClearBeforeFill = True
        '
        'AllView
        '
        Me.AllView.AllowUserToAddRows = False
        Me.AllView.AutoGenerateColumns = False
        Me.AllView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.AllView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AllView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProductNameDataGridViewTextBoxColumn, Me.FinishDataGridViewTextBoxColumn, Me.SizeDataGridViewTextBoxColumn, Me.MemoryDataGridViewTextBoxColumn, Me.StorageDataGridViewTextBoxColumn, Me.ConnectivityDataGridViewTextBoxColumn, Me.PriceDataGridViewTextBoxColumn, Me.OrderIDDataGridViewTextBoxColumn, Me.UserIDDataGridViewTextBoxColumn})
        Me.AllView.DataSource = Me.OrdersBindingSource2
        Me.AllView.Location = New System.Drawing.Point(67, 144)
        Me.AllView.Name = "AllView"
        Me.AllView.ReadOnly = True
        Me.AllView.Size = New System.Drawing.Size(1155, 511)
        Me.AllView.TabIndex = 2
        '
        'ProductNameDataGridViewTextBoxColumn
        '
        Me.ProductNameDataGridViewTextBoxColumn.DataPropertyName = "Product_Name"
        Me.ProductNameDataGridViewTextBoxColumn.HeaderText = "Product_Name"
        Me.ProductNameDataGridViewTextBoxColumn.Name = "ProductNameDataGridViewTextBoxColumn"
        Me.ProductNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProductNameDataGridViewTextBoxColumn.Width = 250
        '
        'FinishDataGridViewTextBoxColumn
        '
        Me.FinishDataGridViewTextBoxColumn.DataPropertyName = "Finish"
        Me.FinishDataGridViewTextBoxColumn.HeaderText = "Finish"
        Me.FinishDataGridViewTextBoxColumn.Name = "FinishDataGridViewTextBoxColumn"
        Me.FinishDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SizeDataGridViewTextBoxColumn
        '
        Me.SizeDataGridViewTextBoxColumn.DataPropertyName = "Size"
        Me.SizeDataGridViewTextBoxColumn.HeaderText = "Size"
        Me.SizeDataGridViewTextBoxColumn.Name = "SizeDataGridViewTextBoxColumn"
        Me.SizeDataGridViewTextBoxColumn.ReadOnly = True
        Me.SizeDataGridViewTextBoxColumn.Width = 120
        '
        'MemoryDataGridViewTextBoxColumn
        '
        Me.MemoryDataGridViewTextBoxColumn.DataPropertyName = "Memory"
        Me.MemoryDataGridViewTextBoxColumn.HeaderText = "Memory"
        Me.MemoryDataGridViewTextBoxColumn.Name = "MemoryDataGridViewTextBoxColumn"
        Me.MemoryDataGridViewTextBoxColumn.ReadOnly = True
        Me.MemoryDataGridViewTextBoxColumn.Width = 110
        '
        'StorageDataGridViewTextBoxColumn
        '
        Me.StorageDataGridViewTextBoxColumn.DataPropertyName = "Storage"
        Me.StorageDataGridViewTextBoxColumn.HeaderText = "Storage"
        Me.StorageDataGridViewTextBoxColumn.Name = "StorageDataGridViewTextBoxColumn"
        Me.StorageDataGridViewTextBoxColumn.ReadOnly = True
        Me.StorageDataGridViewTextBoxColumn.Width = 90
        '
        'ConnectivityDataGridViewTextBoxColumn
        '
        Me.ConnectivityDataGridViewTextBoxColumn.DataPropertyName = "Connectivity"
        Me.ConnectivityDataGridViewTextBoxColumn.HeaderText = "Connectivity"
        Me.ConnectivityDataGridViewTextBoxColumn.Name = "ConnectivityDataGridViewTextBoxColumn"
        Me.ConnectivityDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PriceDataGridViewTextBoxColumn
        '
        Me.PriceDataGridViewTextBoxColumn.DataPropertyName = "Price"
        Me.PriceDataGridViewTextBoxColumn.HeaderText = "Price"
        Me.PriceDataGridViewTextBoxColumn.Name = "PriceDataGridViewTextBoxColumn"
        Me.PriceDataGridViewTextBoxColumn.ReadOnly = True
        Me.PriceDataGridViewTextBoxColumn.Width = 90
        '
        'OrderIDDataGridViewTextBoxColumn
        '
        Me.OrderIDDataGridViewTextBoxColumn.DataPropertyName = "Order_ID"
        Me.OrderIDDataGridViewTextBoxColumn.HeaderText = "Order_ID"
        Me.OrderIDDataGridViewTextBoxColumn.Name = "OrderIDDataGridViewTextBoxColumn"
        Me.OrderIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UserIDDataGridViewTextBoxColumn
        '
        Me.UserIDDataGridViewTextBoxColumn.DataPropertyName = "User_ID"
        Me.UserIDDataGridViewTextBoxColumn.HeaderText = "User_ID"
        Me.UserIDDataGridViewTextBoxColumn.Name = "UserIDDataGridViewTextBoxColumn"
        Me.UserIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.UserIDDataGridViewTextBoxColumn.Width = 150
        '
        'OrdersBindingSource2
        '
        Me.OrdersBindingSource2.DataMember = "Orders"
        Me.OrdersBindingSource2.DataSource = Me.StoreDataSet2
        '
        'StoreDataSet2
        '
        Me.StoreDataSet2.DataSetName = "StoreDataSet2"
        Me.StoreDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OrdersTableAdapter2
        '
        Me.OrdersTableAdapter2.ClearBeforeFill = True
        '
        'Cancel
        '
        Me.Cancel.BackColor = System.Drawing.Color.DodgerBlue
        Me.Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cancel.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancel.ForeColor = System.Drawing.Color.White
        Me.Cancel.Location = New System.Drawing.Point(678, 692)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(146, 45)
        Me.Cancel.TabIndex = 76
        Me.Cancel.Text = "Cancel order"
        Me.Cancel.UseVisualStyleBackColor = False
        '
        'WatchHome
        '
        Me.WatchHome.BackColor = System.Drawing.SystemColors.GrayText
        Me.WatchHome.FlatAppearance.BorderSize = 0
        Me.WatchHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.WatchHome.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.WatchHome.Location = New System.Drawing.Point(850, 4)
        Me.WatchHome.Name = "WatchHome"
        Me.WatchHome.Size = New System.Drawing.Size(51, 43)
        Me.WatchHome.TabIndex = 80
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
        Me.iPhoneHome.Location = New System.Drawing.Point(682, 4)
        Me.iPhoneHome.Name = "iPhoneHome"
        Me.iPhoneHome.Size = New System.Drawing.Size(51, 43)
        Me.iPhoneHome.TabIndex = 79
        Me.iPhoneHome.Text = "iPhone"
        Me.iPhoneHome.UseVisualStyleBackColor = False
        '
        'iPadHome
        '
        Me.iPadHome.BackColor = System.Drawing.SystemColors.GrayText
        Me.iPadHome.FlatAppearance.BorderSize = 0
        Me.iPadHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.iPadHome.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.iPadHome.Location = New System.Drawing.Point(527, 4)
        Me.iPadHome.Name = "iPadHome"
        Me.iPadHome.Size = New System.Drawing.Size(51, 43)
        Me.iPadHome.TabIndex = 78
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
        Me.iMacHome.Location = New System.Drawing.Point(355, 4)
        Me.iMacHome.Name = "iMacHome"
        Me.iMacHome.Size = New System.Drawing.Size(51, 43)
        Me.iMacHome.TabIndex = 77
        Me.iMacHome.Text = "Mac"
        Me.iMacHome.UseVisualStyleBackColor = False
        '
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.SystemColors.GrayText
        Me.ListView1.Location = New System.Drawing.Point(-5, 0)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(1297, 47)
        Me.ListView1.TabIndex = 84
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'cBox
        '
        Me.cBox.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cBox.Location = New System.Drawing.Point(466, 697)
        Me.cBox.Name = "cBox"
        Me.cBox.Size = New System.Drawing.Size(193, 28)
        Me.cBox.TabIndex = 85
        '
        'Bag
        '
        Me.Bag.BackColor = System.Drawing.SystemColors.GrayText
        Me.Bag.Image = Global.Apple.My.Resources.Resources.shopping_bag_24px
        Me.Bag.Location = New System.Drawing.Point(1020, 11)
        Me.Bag.Name = "Bag"
        Me.Bag.Size = New System.Drawing.Size(45, 32)
        Me.Bag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.Bag.TabIndex = 83
        Me.Bag.TabStop = False
        '
        'HomeB
        '
        Me.HomeB.BackColor = System.Drawing.SystemColors.GrayText
        Me.HomeB.Image = CType(resources.GetObject("HomeB.Image"), System.Drawing.Image)
        Me.HomeB.Location = New System.Drawing.Point(202, 15)
        Me.HomeB.Name = "HomeB"
        Me.HomeB.Size = New System.Drawing.Size(27, 28)
        Me.HomeB.TabIndex = 81
        Me.HomeB.TabStop = False
        '
        'canc
        '
        Me.canc.AutoSize = True
        Me.canc.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.canc.LinkColor = System.Drawing.Color.Red
        Me.canc.Location = New System.Drawing.Point(594, 658)
        Me.canc.Name = "canc"
        Me.canc.Size = New System.Drawing.Size(139, 21)
        Me.canc.TabIndex = 86
        Me.canc.TabStop = True
        Me.canc.Text = "Cancel an order?"
        '
        'Orders
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1274, 691)
        Me.Controls.Add(Me.canc)
        Me.Controls.Add(Me.cBox)
        Me.Controls.Add(Me.Bag)
        Me.Controls.Add(Me.HomeB)
        Me.Controls.Add(Me.WatchHome)
        Me.Controls.Add(Me.iPhoneHome)
        Me.Controls.Add(Me.iPadHome)
        Me.Controls.Add(Me.iMacHome)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.AllView)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Orders"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Your Orders"
        CType(Me.OrdersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StoreDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrdersBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StoreDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AllView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrdersBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StoreDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bag, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HomeB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents StoreDataSet As Apple.StoreDataSet
    Friend WithEvents OrdersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OrdersTableAdapter As Apple.StoreDataSetTableAdapters.OrdersTableAdapter
    Friend WithEvents StoreDataSet1 As Apple.StoreDataSet1
    Friend WithEvents OrdersBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents OrdersTableAdapter1 As Apple.StoreDataSet1TableAdapters.OrdersTableAdapter
    Friend WithEvents AllView As System.Windows.Forms.DataGridView
    Friend WithEvents StoreDataSet2 As Apple.StoreDataSet2
    Friend WithEvents OrdersBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents OrdersTableAdapter2 As Apple.StoreDataSet2TableAdapters.OrdersTableAdapter
    Friend WithEvents ProductNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FinishDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SizeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MemoryDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StorageDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ConnectivityDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PriceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OrderIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UserIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cancel As System.Windows.Forms.Button
    Friend WithEvents Bag As System.Windows.Forms.PictureBox
    Friend WithEvents HomeB As System.Windows.Forms.PictureBox
    Friend WithEvents WatchHome As System.Windows.Forms.Button
    Friend WithEvents iPhoneHome As System.Windows.Forms.Button
    Friend WithEvents iPadHome As System.Windows.Forms.Button
    Friend WithEvents iMacHome As System.Windows.Forms.Button
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents cBox As System.Windows.Forms.TextBox
    Friend WithEvents canc As System.Windows.Forms.LinkLabel
End Class
