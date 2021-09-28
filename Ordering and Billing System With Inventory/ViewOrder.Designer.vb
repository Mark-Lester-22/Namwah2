<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewOrder
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ViewOrder))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ordersDataGrid = New System.Windows.Forms.DataGridView()
        Me.OrderNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Location = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Action = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenusIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ListOfMenu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ListOfPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InitialPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenusTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuQuantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiscountedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CreatedDateTimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrdersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrdersDataSet = New Ordering_and_Billing_System_With_Inventory.ordersDataSet()
        Me.lbxMenuItem = New System.Windows.Forms.ListBox()
        Me.lbxMenuQuantity = New System.Windows.Forms.ListBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbxLocation = New System.Windows.Forms.TextBox()
        Me.tbxOrderID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbxOrderNum = New System.Windows.Forms.TextBox()
        Me.btnComplete = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.OrdersTableAdapter = New Ordering_and_Billing_System_With_Inventory.ordersDataSetTableAdapters.OrdersTableAdapter()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.ordersDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrdersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrdersDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.ordersDataGrid)
        Me.Panel1.Font = New System.Drawing.Font("Segoe UI Light", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(136, 166)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(586, 708)
        Me.Panel1.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(180, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(190, 32)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "ORDER LIST"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Light", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(257, 23)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 47)
        Me.Label6.TabIndex = 43
        Me.Label6.Text = "..."
        '
        'ordersDataGrid
        '
        Me.ordersDataGrid.AllowUserToAddRows = False
        Me.ordersDataGrid.AllowUserToDeleteRows = False
        Me.ordersDataGrid.AutoGenerateColumns = False
        Me.ordersDataGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ordersDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ordersDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ordersDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.OrderNumber, Me.Location, Me.StatusDataGridViewTextBoxColumn, Me.Action, Me.ID, Me.MenusIDDataGridViewTextBoxColumn, Me.ListOfMenu, Me.ListOfPrice, Me.InitialPriceDataGridViewTextBoxColumn, Me.TotalPriceDataGridViewTextBoxColumn, Me.MenusTypeDataGridViewTextBoxColumn, Me.MenuQuantity, Me.DiscountedDataGridViewTextBoxColumn, Me.CreatedDateTimeDataGridViewTextBoxColumn})
        Me.ordersDataGrid.DataSource = Me.OrdersBindingSource
        Me.ordersDataGrid.GridColor = System.Drawing.Color.Maroon
        Me.ordersDataGrid.Location = New System.Drawing.Point(17, 91)
        Me.ordersDataGrid.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.ordersDataGrid.Name = "ordersDataGrid"
        Me.ordersDataGrid.ReadOnly = True
        Me.ordersDataGrid.RowHeadersWidth = 51
        Me.ordersDataGrid.RowTemplate.Height = 24
        Me.ordersDataGrid.Size = New System.Drawing.Size(555, 527)
        Me.ordersDataGrid.TabIndex = 0
        '
        'OrderNumber
        '
        Me.OrderNumber.DataPropertyName = "OrderNumber"
        Me.OrderNumber.HeaderText = "OrderNumber"
        Me.OrderNumber.MinimumWidth = 6
        Me.OrderNumber.Name = "OrderNumber"
        Me.OrderNumber.ReadOnly = True
        Me.OrderNumber.Width = 125
        '
        'Location
        '
        Me.Location.DataPropertyName = "Location"
        Me.Location.HeaderText = "Table"
        Me.Location.MinimumWidth = 6
        Me.Location.Name = "Location"
        Me.Location.ReadOnly = True
        Me.Location.Width = 125
        '
        'StatusDataGridViewTextBoxColumn
        '
        Me.StatusDataGridViewTextBoxColumn.DataPropertyName = "Status"
        Me.StatusDataGridViewTextBoxColumn.HeaderText = "Status"
        Me.StatusDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.StatusDataGridViewTextBoxColumn.Name = "StatusDataGridViewTextBoxColumn"
        Me.StatusDataGridViewTextBoxColumn.ReadOnly = True
        Me.StatusDataGridViewTextBoxColumn.Width = 125
        '
        'Action
        '
        Me.Action.HeaderText = "Action"
        Me.Action.MinimumWidth = 6
        Me.Action.Name = "Action"
        Me.Action.ReadOnly = True
        Me.Action.Text = "View"
        Me.Action.ToolTipText = "View"
        Me.Action.UseColumnTextForButtonValue = True
        Me.Action.Width = 125
        '
        'ID
        '
        Me.ID.DataPropertyName = "ID"
        Me.ID.HeaderText = "ID"
        Me.ID.MinimumWidth = 6
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Visible = False
        Me.ID.Width = 125
        '
        'MenusIDDataGridViewTextBoxColumn
        '
        Me.MenusIDDataGridViewTextBoxColumn.DataPropertyName = "MenusID"
        Me.MenusIDDataGridViewTextBoxColumn.HeaderText = "MenusID"
        Me.MenusIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.MenusIDDataGridViewTextBoxColumn.Name = "MenusIDDataGridViewTextBoxColumn"
        Me.MenusIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.MenusIDDataGridViewTextBoxColumn.Visible = False
        Me.MenusIDDataGridViewTextBoxColumn.Width = 125
        '
        'ListOfMenu
        '
        Me.ListOfMenu.DataPropertyName = "ListOfMenu"
        Me.ListOfMenu.HeaderText = "ListOfMenu"
        Me.ListOfMenu.MinimumWidth = 6
        Me.ListOfMenu.Name = "ListOfMenu"
        Me.ListOfMenu.ReadOnly = True
        Me.ListOfMenu.Visible = False
        Me.ListOfMenu.Width = 125
        '
        'ListOfPrice
        '
        Me.ListOfPrice.DataPropertyName = "ListOfPrice"
        Me.ListOfPrice.HeaderText = "ListOfPrice"
        Me.ListOfPrice.MinimumWidth = 6
        Me.ListOfPrice.Name = "ListOfPrice"
        Me.ListOfPrice.ReadOnly = True
        Me.ListOfPrice.Visible = False
        Me.ListOfPrice.Width = 125
        '
        'InitialPriceDataGridViewTextBoxColumn
        '
        Me.InitialPriceDataGridViewTextBoxColumn.DataPropertyName = "InitialPrice"
        Me.InitialPriceDataGridViewTextBoxColumn.HeaderText = "InitialPrice"
        Me.InitialPriceDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.InitialPriceDataGridViewTextBoxColumn.Name = "InitialPriceDataGridViewTextBoxColumn"
        Me.InitialPriceDataGridViewTextBoxColumn.ReadOnly = True
        Me.InitialPriceDataGridViewTextBoxColumn.Visible = False
        Me.InitialPriceDataGridViewTextBoxColumn.Width = 125
        '
        'TotalPriceDataGridViewTextBoxColumn
        '
        Me.TotalPriceDataGridViewTextBoxColumn.DataPropertyName = "TotalPrice"
        Me.TotalPriceDataGridViewTextBoxColumn.HeaderText = "TotalPrice"
        Me.TotalPriceDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TotalPriceDataGridViewTextBoxColumn.Name = "TotalPriceDataGridViewTextBoxColumn"
        Me.TotalPriceDataGridViewTextBoxColumn.ReadOnly = True
        Me.TotalPriceDataGridViewTextBoxColumn.Visible = False
        Me.TotalPriceDataGridViewTextBoxColumn.Width = 125
        '
        'MenusTypeDataGridViewTextBoxColumn
        '
        Me.MenusTypeDataGridViewTextBoxColumn.DataPropertyName = "MenusType"
        Me.MenusTypeDataGridViewTextBoxColumn.HeaderText = "MenusType"
        Me.MenusTypeDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.MenusTypeDataGridViewTextBoxColumn.Name = "MenusTypeDataGridViewTextBoxColumn"
        Me.MenusTypeDataGridViewTextBoxColumn.ReadOnly = True
        Me.MenusTypeDataGridViewTextBoxColumn.Visible = False
        Me.MenusTypeDataGridViewTextBoxColumn.Width = 125
        '
        'MenuQuantity
        '
        Me.MenuQuantity.DataPropertyName = "MenuQuantity"
        Me.MenuQuantity.HeaderText = "MenuQuantity"
        Me.MenuQuantity.MinimumWidth = 6
        Me.MenuQuantity.Name = "MenuQuantity"
        Me.MenuQuantity.ReadOnly = True
        Me.MenuQuantity.Visible = False
        Me.MenuQuantity.Width = 125
        '
        'DiscountedDataGridViewTextBoxColumn
        '
        Me.DiscountedDataGridViewTextBoxColumn.DataPropertyName = "Discounted"
        Me.DiscountedDataGridViewTextBoxColumn.HeaderText = "Discounted"
        Me.DiscountedDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DiscountedDataGridViewTextBoxColumn.Name = "DiscountedDataGridViewTextBoxColumn"
        Me.DiscountedDataGridViewTextBoxColumn.ReadOnly = True
        Me.DiscountedDataGridViewTextBoxColumn.Visible = False
        Me.DiscountedDataGridViewTextBoxColumn.Width = 125
        '
        'CreatedDateTimeDataGridViewTextBoxColumn
        '
        Me.CreatedDateTimeDataGridViewTextBoxColumn.DataPropertyName = "createdDateTime"
        Me.CreatedDateTimeDataGridViewTextBoxColumn.HeaderText = "createdDateTime"
        Me.CreatedDateTimeDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CreatedDateTimeDataGridViewTextBoxColumn.Name = "CreatedDateTimeDataGridViewTextBoxColumn"
        Me.CreatedDateTimeDataGridViewTextBoxColumn.ReadOnly = True
        Me.CreatedDateTimeDataGridViewTextBoxColumn.Visible = False
        Me.CreatedDateTimeDataGridViewTextBoxColumn.Width = 125
        '
        'OrdersBindingSource
        '
        Me.OrdersBindingSource.DataMember = "Orders"
        Me.OrdersBindingSource.DataSource = Me.OrdersDataSet
        Me.OrdersBindingSource.Filter = "Status='Paid' Or Status='Additional'"
        '
        'OrdersDataSet
        '
        Me.OrdersDataSet.DataSetName = "ordersDataSet"
        Me.OrdersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lbxMenuItem
        '
        Me.lbxMenuItem.Font = New System.Drawing.Font("Segoe UI Light", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbxMenuItem.FormattingEnabled = True
        Me.lbxMenuItem.ItemHeight = 25
        Me.lbxMenuItem.Location = New System.Drawing.Point(13, 88)
        Me.lbxMenuItem.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.lbxMenuItem.Name = "lbxMenuItem"
        Me.lbxMenuItem.Size = New System.Drawing.Size(224, 529)
        Me.lbxMenuItem.TabIndex = 1
        '
        'lbxMenuQuantity
        '
        Me.lbxMenuQuantity.Font = New System.Drawing.Font("Segoe UI Light", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbxMenuQuantity.FormattingEnabled = True
        Me.lbxMenuQuantity.ItemHeight = 25
        Me.lbxMenuQuantity.Location = New System.Drawing.Point(263, 88)
        Me.lbxMenuQuantity.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.lbxMenuQuantity.Name = "lbxMenuQuantity"
        Me.lbxMenuQuantity.Size = New System.Drawing.Size(168, 529)
        Me.lbxMenuQuantity.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.tbxLocation)
        Me.Panel2.Controls.Add(Me.tbxOrderID)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.tbxOrderNum)
        Me.Panel2.Controls.Add(Me.btnComplete)
        Me.Panel2.Controls.Add(Me.btnRefresh)
        Me.Panel2.Controls.Add(Me.lbxMenuQuantity)
        Me.Panel2.Controls.Add(Me.lbxMenuItem)
        Me.Panel2.Location = New System.Drawing.Point(787, 166)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(666, 708)
        Me.Panel2.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(257, 34)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(125, 32)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Quantity"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(15, 34)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(152, 32)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Menu Item"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(467, 290)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(167, 44)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Table Number:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tbxLocation
        '
        Me.tbxLocation.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbxLocation.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxLocation.Location = New System.Drawing.Point(473, 339)
        Me.tbxLocation.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.tbxLocation.Name = "tbxLocation"
        Me.tbxLocation.ReadOnly = True
        Me.tbxLocation.Size = New System.Drawing.Size(161, 25)
        Me.tbxLocation.TabIndex = 9
        '
        'tbxOrderID
        '
        Me.tbxOrderID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbxOrderID.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxOrderID.Location = New System.Drawing.Point(473, 139)
        Me.tbxOrderID.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.tbxOrderID.Name = "tbxOrderID"
        Me.tbxOrderID.Size = New System.Drawing.Size(161, 25)
        Me.tbxOrderID.TabIndex = 8
        Me.tbxOrderID.Visible = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(467, 192)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(177, 44)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Order Number:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tbxOrderNum
        '
        Me.tbxOrderNum.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbxOrderNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxOrderNum.Location = New System.Drawing.Point(473, 241)
        Me.tbxOrderNum.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.tbxOrderNum.Name = "tbxOrderNum"
        Me.tbxOrderNum.ReadOnly = True
        Me.tbxOrderNum.Size = New System.Drawing.Size(161, 25)
        Me.tbxOrderNum.TabIndex = 6
        '
        'btnComplete
        '
        Me.btnComplete.BackColor = System.Drawing.Color.Aqua
        Me.btnComplete.BackgroundImage = Global.Ordering_and_Billing_System_With_Inventory.My.Resources.Resources.cutlery_32px1
        Me.btnComplete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnComplete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnComplete.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnComplete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnComplete.Location = New System.Drawing.Point(471, 388)
        Me.btnComplete.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btnComplete.Name = "btnComplete"
        Me.btnComplete.Size = New System.Drawing.Size(129, 64)
        Me.btnComplete.TabIndex = 5
        Me.btnComplete.Text = "Complete"
        Me.btnComplete.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnComplete.UseVisualStyleBackColor = False
        '
        'btnRefresh
        '
        Me.btnRefresh.BackColor = System.Drawing.Color.Aqua
        Me.btnRefresh.BackgroundImage = Global.Ordering_and_Billing_System_With_Inventory.My.Resources.Resources.refresh_32px
        Me.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefresh.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnRefresh.Location = New System.Drawing.Point(473, 473)
        Me.btnRefresh.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(127, 64)
        Me.btnRefresh.TabIndex = 4
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Transparent
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnBack.Location = New System.Drawing.Point(12, 14)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(159, 52)
        Me.btnBack.TabIndex = 3
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'OrdersTableAdapter
        '
        Me.OrdersTableAdapter.ClearBeforeFill = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label7.Location = New System.Drawing.Point(749, 344)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(14, 312)
        Me.Label7.TabIndex = 44
        Me.Label7.Text = "|" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "|" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "|" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "|" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "|" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "|" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "|" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "|" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "|" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "|" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "|" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "|" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "|"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.InitialImage = Nothing
        Me.PictureBox3.Location = New System.Drawing.Point(1354, -2)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(159, 147)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 47
        Me.PictureBox3.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label8.Location = New System.Drawing.Point(308, 58)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(255, 32)
        Me.Label8.TabIndex = 46
        Me.Label8.Text = "ORDER VIEWING"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(42, 93)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1291, 33)
        Me.PictureBox1.TabIndex = 45
        Me.PictureBox1.TabStop = False
        '
        'ViewOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1600, 900)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnBack)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.MaximumSize = New System.Drawing.Size(1600, 900)
        Me.MinimumSize = New System.Drawing.Size(1278, 898)
        Me.Name = "ViewOrder"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Orders"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ordersDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrdersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrdersDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents ordersDataGrid As DataGridView
    Friend WithEvents lbxMenuItem As ListBox
    Friend WithEvents lbxMenuQuantity As ListBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnComplete As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents OrdersDataSet As ordersDataSet
    Friend WithEvents OrdersBindingSource As BindingSource
    Friend WithEvents OrdersTableAdapter As ordersDataSetTableAdapters.OrdersTableAdapter
    Friend WithEvents Label1 As Label
    Friend WithEvents tbxOrderNum As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tbxLocation As TextBox
    Friend WithEvents tbxOrderID As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents OrderNumber As DataGridViewTextBoxColumn
    Friend WithEvents Location As DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Action As DataGridViewButtonColumn
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents MenusIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ListOfMenu As DataGridViewTextBoxColumn
    Friend WithEvents ListOfPrice As DataGridViewTextBoxColumn
    Friend WithEvents InitialPriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalPriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MenusTypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MenuQuantity As DataGridViewTextBoxColumn
    Friend WithEvents DiscountedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CreatedDateTimeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
