<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Delivery
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Delivery))
        Me.orderDeliveryTab = New System.Windows.Forms.TabControl()
        Me.menusTab = New System.Windows.Forms.TabPage()
        Me.menusDataGrid = New System.Windows.Forms.DataGridView()
        Me.menusName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.menusPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.menusType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.menusStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.menusQuantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.selectMenus = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.menusID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.menusNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.menusDetails = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.menusDiscount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.menusCreatedDateTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenusBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NamwahDataSet = New Ordering_and_Billing_System_With_Inventory.namwahDataSet()
        Me.drinksTab = New System.Windows.Forms.TabPage()
        Me.drinksDataGrid = New System.Windows.Forms.DataGridView()
        Me.drinksName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.drinksPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.drinksType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.drinksStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.drinksQuantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.selectDrinks = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.drinksID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.drinksNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.drinksDetails = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.drinksDiscount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.drinksCreatedDateTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenusBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.NamwahOrdersDataSet = New Ordering_and_Billing_System_With_Inventory.namwahOrdersDataSet()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.listofids = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.listofquantity = New System.Windows.Forms.ListBox()
        Me.lblListofPrice = New System.Windows.Forms.Label()
        Me.lblSelectedMenus = New System.Windows.Forms.Label()
        Me.listofprices = New System.Windows.Forms.ListBox()
        Me.totalPrice = New System.Windows.Forms.TextBox()
        Me.TotalPriceLabel = New System.Windows.Forms.Label()
        Me.initialPrice = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.listofmenus = New System.Windows.Forms.ListBox()
        Me.tbxAddress = New System.Windows.Forms.TextBox()
        Me.tbxMobileNum = New System.Windows.Forms.TextBox()
        Me.tbxCustomerName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbxServiceCharge = New System.Windows.Forms.ComboBox()
        Me.btnPrintBill = New System.Windows.Forms.Button()
        Me.MenusTableAdapter = New Ordering_and_Billing_System_With_Inventory.namwahDataSetTableAdapters.MenusTableAdapter()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbxDeliveryNum = New System.Windows.Forms.TextBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.orderDeliveryTab.SuspendLayout()
        Me.menusTab.SuspendLayout()
        CType(Me.menusDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MenusBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NamwahDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.drinksTab.SuspendLayout()
        CType(Me.drinksDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MenusBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NamwahOrdersDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'orderDeliveryTab
        '
        Me.orderDeliveryTab.Controls.Add(Me.menusTab)
        Me.orderDeliveryTab.Controls.Add(Me.drinksTab)
        Me.orderDeliveryTab.Font = New System.Drawing.Font("Segoe UI Light", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.orderDeliveryTab.Location = New System.Drawing.Point(49, 165)
        Me.orderDeliveryTab.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.orderDeliveryTab.Name = "orderDeliveryTab"
        Me.orderDeliveryTab.SelectedIndex = 0
        Me.orderDeliveryTab.Size = New System.Drawing.Size(571, 688)
        Me.orderDeliveryTab.TabIndex = 0
        '
        'menusTab
        '
        Me.menusTab.Controls.Add(Me.menusDataGrid)
        Me.menusTab.Location = New System.Drawing.Point(4, 34)
        Me.menusTab.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.menusTab.Name = "menusTab"
        Me.menusTab.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.menusTab.Size = New System.Drawing.Size(563, 650)
        Me.menusTab.TabIndex = 2
        Me.menusTab.Text = "Menus"
        Me.menusTab.UseVisualStyleBackColor = True
        '
        'menusDataGrid
        '
        Me.menusDataGrid.AllowUserToAddRows = False
        Me.menusDataGrid.AllowUserToDeleteRows = False
        Me.menusDataGrid.AutoGenerateColumns = False
        Me.menusDataGrid.BackgroundColor = System.Drawing.Color.White
        Me.menusDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.menusDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.menusName, Me.menusPrice, Me.menusType, Me.menusStatus, Me.menusQuantity, Me.selectMenus, Me.menusID, Me.menusNumber, Me.menusDetails, Me.menusDiscount, Me.menusCreatedDateTime})
        Me.menusDataGrid.DataSource = Me.MenusBindingSource
        Me.menusDataGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.menusDataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke
        Me.menusDataGrid.Location = New System.Drawing.Point(3, 2)
        Me.menusDataGrid.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.menusDataGrid.Name = "menusDataGrid"
        Me.menusDataGrid.RowHeadersWidth = 51
        Me.menusDataGrid.RowTemplate.Height = 24
        Me.menusDataGrid.Size = New System.Drawing.Size(557, 646)
        Me.menusDataGrid.TabIndex = 0
        '
        'menusName
        '
        Me.menusName.DataPropertyName = "Name"
        Me.menusName.HeaderText = "Name"
        Me.menusName.MinimumWidth = 6
        Me.menusName.Name = "menusName"
        Me.menusName.ReadOnly = True
        Me.menusName.Width = 125
        '
        'menusPrice
        '
        Me.menusPrice.DataPropertyName = "Price"
        Me.menusPrice.HeaderText = "Price"
        Me.menusPrice.MinimumWidth = 6
        Me.menusPrice.Name = "menusPrice"
        Me.menusPrice.ReadOnly = True
        Me.menusPrice.Width = 125
        '
        'menusType
        '
        Me.menusType.DataPropertyName = "Type"
        Me.menusType.HeaderText = "Type"
        Me.menusType.MinimumWidth = 6
        Me.menusType.Name = "menusType"
        Me.menusType.Visible = False
        Me.menusType.Width = 125
        '
        'menusStatus
        '
        Me.menusStatus.DataPropertyName = "Status"
        Me.menusStatus.HeaderText = "Status"
        Me.menusStatus.MinimumWidth = 6
        Me.menusStatus.Name = "menusStatus"
        Me.menusStatus.Visible = False
        Me.menusStatus.Width = 125
        '
        'menusQuantity
        '
        DataGridViewCellStyle7.Format = "N0"
        DataGridViewCellStyle7.NullValue = "1"
        Me.menusQuantity.DefaultCellStyle = DataGridViewCellStyle7
        Me.menusQuantity.HeaderText = "Quantity"
        Me.menusQuantity.MinimumWidth = 6
        Me.menusQuantity.Name = "menusQuantity"
        Me.menusQuantity.ToolTipText = "Quantity"
        Me.menusQuantity.Width = 125
        '
        'selectMenus
        '
        Me.selectMenus.HeaderText = "Action"
        Me.selectMenus.MinimumWidth = 6
        Me.selectMenus.Name = "selectMenus"
        Me.selectMenus.Text = "Add"
        Me.selectMenus.ToolTipText = "Add"
        Me.selectMenus.UseColumnTextForButtonValue = True
        Me.selectMenus.Width = 125
        '
        'menusID
        '
        Me.menusID.DataPropertyName = "ID"
        Me.menusID.HeaderText = "ID"
        Me.menusID.MinimumWidth = 6
        Me.menusID.Name = "menusID"
        Me.menusID.Visible = False
        Me.menusID.Width = 125
        '
        'menusNumber
        '
        Me.menusNumber.DataPropertyName = "MenuNumber"
        Me.menusNumber.HeaderText = "MenuNumber"
        Me.menusNumber.MinimumWidth = 6
        Me.menusNumber.Name = "menusNumber"
        Me.menusNumber.Visible = False
        Me.menusNumber.Width = 125
        '
        'menusDetails
        '
        Me.menusDetails.DataPropertyName = "Details"
        Me.menusDetails.HeaderText = "Details"
        Me.menusDetails.MinimumWidth = 6
        Me.menusDetails.Name = "menusDetails"
        Me.menusDetails.Visible = False
        Me.menusDetails.Width = 125
        '
        'menusDiscount
        '
        Me.menusDiscount.DataPropertyName = "Discount"
        Me.menusDiscount.HeaderText = "Discount"
        Me.menusDiscount.MinimumWidth = 6
        Me.menusDiscount.Name = "menusDiscount"
        Me.menusDiscount.Visible = False
        Me.menusDiscount.Width = 125
        '
        'menusCreatedDateTime
        '
        Me.menusCreatedDateTime.DataPropertyName = "createdDateTime"
        Me.menusCreatedDateTime.HeaderText = "createdDateTime"
        Me.menusCreatedDateTime.MinimumWidth = 6
        Me.menusCreatedDateTime.Name = "menusCreatedDateTime"
        Me.menusCreatedDateTime.Visible = False
        Me.menusCreatedDateTime.Width = 125
        '
        'MenusBindingSource
        '
        Me.MenusBindingSource.DataMember = "Menus"
        Me.MenusBindingSource.DataSource = Me.NamwahDataSet
        Me.MenusBindingSource.Filter = "Type <> 'Drinks'"
        '
        'NamwahDataSet
        '
        Me.NamwahDataSet.DataSetName = "namwahDataSet"
        Me.NamwahDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'drinksTab
        '
        Me.drinksTab.Controls.Add(Me.drinksDataGrid)
        Me.drinksTab.Location = New System.Drawing.Point(4, 34)
        Me.drinksTab.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.drinksTab.Name = "drinksTab"
        Me.drinksTab.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.drinksTab.Size = New System.Drawing.Size(526, 650)
        Me.drinksTab.TabIndex = 3
        Me.drinksTab.Text = "Drinks"
        Me.drinksTab.UseVisualStyleBackColor = True
        '
        'drinksDataGrid
        '
        Me.drinksDataGrid.AllowUserToAddRows = False
        Me.drinksDataGrid.AllowUserToDeleteRows = False
        Me.drinksDataGrid.AutoGenerateColumns = False
        Me.drinksDataGrid.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.drinksDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.drinksDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.drinksName, Me.drinksPrice, Me.drinksType, Me.drinksStatus, Me.drinksQuantity, Me.selectDrinks, Me.drinksID, Me.drinksNumber, Me.drinksDetails, Me.drinksDiscount, Me.drinksCreatedDateTime})
        Me.drinksDataGrid.DataSource = Me.MenusBindingSource1
        Me.drinksDataGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.drinksDataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke
        Me.drinksDataGrid.Location = New System.Drawing.Point(3, 2)
        Me.drinksDataGrid.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.drinksDataGrid.Name = "drinksDataGrid"
        Me.drinksDataGrid.RowHeadersWidth = 51
        Me.drinksDataGrid.RowTemplate.Height = 24
        Me.drinksDataGrid.Size = New System.Drawing.Size(520, 646)
        Me.drinksDataGrid.TabIndex = 1
        '
        'drinksName
        '
        Me.drinksName.DataPropertyName = "Name"
        Me.drinksName.HeaderText = "Name"
        Me.drinksName.MinimumWidth = 6
        Me.drinksName.Name = "drinksName"
        Me.drinksName.ReadOnly = True
        Me.drinksName.Width = 125
        '
        'drinksPrice
        '
        Me.drinksPrice.DataPropertyName = "Price"
        Me.drinksPrice.HeaderText = "Price"
        Me.drinksPrice.MinimumWidth = 6
        Me.drinksPrice.Name = "drinksPrice"
        Me.drinksPrice.ReadOnly = True
        Me.drinksPrice.Width = 125
        '
        'drinksType
        '
        Me.drinksType.DataPropertyName = "Type"
        Me.drinksType.HeaderText = "Type"
        Me.drinksType.MinimumWidth = 6
        Me.drinksType.Name = "drinksType"
        Me.drinksType.Visible = False
        Me.drinksType.Width = 125
        '
        'drinksStatus
        '
        Me.drinksStatus.DataPropertyName = "Status"
        Me.drinksStatus.HeaderText = "Status"
        Me.drinksStatus.MinimumWidth = 6
        Me.drinksStatus.Name = "drinksStatus"
        Me.drinksStatus.Visible = False
        Me.drinksStatus.Width = 125
        '
        'drinksQuantity
        '
        DataGridViewCellStyle8.Format = "N0"
        DataGridViewCellStyle8.NullValue = "1"
        Me.drinksQuantity.DefaultCellStyle = DataGridViewCellStyle8
        Me.drinksQuantity.HeaderText = "Quantity"
        Me.drinksQuantity.MinimumWidth = 6
        Me.drinksQuantity.Name = "drinksQuantity"
        Me.drinksQuantity.ToolTipText = "Quantity"
        Me.drinksQuantity.Width = 125
        '
        'selectDrinks
        '
        Me.selectDrinks.HeaderText = "Action"
        Me.selectDrinks.MinimumWidth = 6
        Me.selectDrinks.Name = "selectDrinks"
        Me.selectDrinks.Text = "Add"
        Me.selectDrinks.ToolTipText = "Add"
        Me.selectDrinks.UseColumnTextForButtonValue = True
        Me.selectDrinks.Width = 125
        '
        'drinksID
        '
        Me.drinksID.DataPropertyName = "ID"
        Me.drinksID.HeaderText = "ID"
        Me.drinksID.MinimumWidth = 6
        Me.drinksID.Name = "drinksID"
        Me.drinksID.Visible = False
        Me.drinksID.Width = 125
        '
        'drinksNumber
        '
        Me.drinksNumber.DataPropertyName = "MenuNumber"
        Me.drinksNumber.HeaderText = "MenuNumber"
        Me.drinksNumber.MinimumWidth = 6
        Me.drinksNumber.Name = "drinksNumber"
        Me.drinksNumber.Visible = False
        Me.drinksNumber.Width = 125
        '
        'drinksDetails
        '
        Me.drinksDetails.DataPropertyName = "Details"
        Me.drinksDetails.HeaderText = "Details"
        Me.drinksDetails.MinimumWidth = 6
        Me.drinksDetails.Name = "drinksDetails"
        Me.drinksDetails.Visible = False
        Me.drinksDetails.Width = 125
        '
        'drinksDiscount
        '
        Me.drinksDiscount.DataPropertyName = "Discount"
        Me.drinksDiscount.HeaderText = "Discount"
        Me.drinksDiscount.MinimumWidth = 6
        Me.drinksDiscount.Name = "drinksDiscount"
        Me.drinksDiscount.Visible = False
        Me.drinksDiscount.Width = 125
        '
        'drinksCreatedDateTime
        '
        Me.drinksCreatedDateTime.DataPropertyName = "createdDateTime"
        Me.drinksCreatedDateTime.HeaderText = "createdDateTime"
        Me.drinksCreatedDateTime.MinimumWidth = 6
        Me.drinksCreatedDateTime.Name = "drinksCreatedDateTime"
        Me.drinksCreatedDateTime.Visible = False
        Me.drinksCreatedDateTime.Width = 125
        '
        'MenusBindingSource1
        '
        Me.MenusBindingSource1.DataMember = "Menus"
        Me.MenusBindingSource1.DataSource = Me.NamwahDataSet
        Me.MenusBindingSource1.Filter = "Type = 'Drinks'"
        '
        'NamwahOrdersDataSet
        '
        Me.NamwahOrdersDataSet.DataSetName = "namwahOrdersDataSet"
        Me.NamwahOrdersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.listofids)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.listofquantity)
        Me.Panel1.Controls.Add(Me.lblListofPrice)
        Me.Panel1.Controls.Add(Me.lblSelectedMenus)
        Me.Panel1.Controls.Add(Me.listofprices)
        Me.Panel1.Controls.Add(Me.totalPrice)
        Me.Panel1.Controls.Add(Me.TotalPriceLabel)
        Me.Panel1.Controls.Add(Me.initialPrice)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.listofmenus)
        Me.Panel1.Location = New System.Drawing.Point(675, 196)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(447, 595)
        Me.Panel1.TabIndex = 2
        '
        'listofids
        '
        Me.listofids.Font = New System.Drawing.Font("Segoe UI Light", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listofids.FormattingEnabled = True
        Me.listofids.ItemHeight = 25
        Me.listofids.Location = New System.Drawing.Point(110, 552)
        Me.listofids.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.listofids.Name = "listofids"
        Me.listofids.Size = New System.Drawing.Size(212, 4)
        Me.listofids.TabIndex = 15
        Me.listofids.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 17.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(227, 6)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 25)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Quantity"
        '
        'listofquantity
        '
        Me.listofquantity.Font = New System.Drawing.Font("Segoe UI Light", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listofquantity.FormattingEnabled = True
        Me.listofquantity.ItemHeight = 25
        Me.listofquantity.Location = New System.Drawing.Point(236, 46)
        Me.listofquantity.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.listofquantity.Name = "listofquantity"
        Me.listofquantity.Size = New System.Drawing.Size(108, 354)
        Me.listofquantity.TabIndex = 13
        '
        'lblListofPrice
        '
        Me.lblListofPrice.AutoSize = True
        Me.lblListofPrice.Font = New System.Drawing.Font("Times New Roman", 17.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblListofPrice.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblListofPrice.Location = New System.Drawing.Point(350, 6)
        Me.lblListofPrice.Name = "lblListofPrice"
        Me.lblListofPrice.Size = New System.Drawing.Size(64, 25)
        Me.lblListofPrice.TabIndex = 12
        Me.lblListofPrice.Text = "Price"
        '
        'lblSelectedMenus
        '
        Me.lblSelectedMenus.AutoSize = True
        Me.lblSelectedMenus.Font = New System.Drawing.Font("Times New Roman", 17.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelectedMenus.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblSelectedMenus.Location = New System.Drawing.Point(10, 6)
        Me.lblSelectedMenus.Name = "lblSelectedMenus"
        Me.lblSelectedMenus.Size = New System.Drawing.Size(170, 25)
        Me.lblSelectedMenus.TabIndex = 11
        Me.lblSelectedMenus.Text = "Selected Menus"
        '
        'listofprices
        '
        Me.listofprices.Font = New System.Drawing.Font("Segoe UI Light", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listofprices.FormattingEnabled = True
        Me.listofprices.ItemHeight = 25
        Me.listofprices.Location = New System.Drawing.Point(350, 46)
        Me.listofprices.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.listofprices.Name = "listofprices"
        Me.listofprices.Size = New System.Drawing.Size(81, 354)
        Me.listofprices.TabIndex = 10
        '
        'totalPrice
        '
        Me.totalPrice.Font = New System.Drawing.Font("Segoe UI Light", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalPrice.Location = New System.Drawing.Point(269, 513)
        Me.totalPrice.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.totalPrice.Name = "totalPrice"
        Me.totalPrice.ReadOnly = True
        Me.totalPrice.Size = New System.Drawing.Size(166, 32)
        Me.totalPrice.TabIndex = 9
        Me.totalPrice.Tag = "Total"
        Me.totalPrice.Text = "0"
        Me.totalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TotalPriceLabel
        '
        Me.TotalPriceLabel.BackColor = System.Drawing.Color.Transparent
        Me.TotalPriceLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TotalPriceLabel.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalPriceLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TotalPriceLabel.Location = New System.Drawing.Point(263, 474)
        Me.TotalPriceLabel.Name = "TotalPriceLabel"
        Me.TotalPriceLabel.Size = New System.Drawing.Size(92, 37)
        Me.TotalPriceLabel.TabIndex = 8
        Me.TotalPriceLabel.Text = "Total :"
        Me.TotalPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'initialPrice
        '
        Me.initialPrice.Font = New System.Drawing.Font("Segoe UI Light", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.initialPrice.Location = New System.Drawing.Point(20, 510)
        Me.initialPrice.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.initialPrice.Name = "initialPrice"
        Me.initialPrice.ReadOnly = True
        Me.initialPrice.Size = New System.Drawing.Size(154, 32)
        Me.initialPrice.TabIndex = 7
        Me.initialPrice.Tag = "Initial"
        Me.initialPrice.Text = "0"
        Me.initialPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(3, 474)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 37)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Initial :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'listofmenus
        '
        Me.listofmenus.Font = New System.Drawing.Font("Segoe UI Light", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listofmenus.FormattingEnabled = True
        Me.listofmenus.ItemHeight = 25
        Me.listofmenus.Location = New System.Drawing.Point(7, 46)
        Me.listofmenus.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.listofmenus.Name = "listofmenus"
        Me.listofmenus.Size = New System.Drawing.Size(223, 354)
        Me.listofmenus.TabIndex = 0
        '
        'tbxAddress
        '
        Me.tbxAddress.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbxAddress.Font = New System.Drawing.Font("Segoe UI Light", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxAddress.Location = New System.Drawing.Point(1141, 598)
        Me.tbxAddress.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tbxAddress.Name = "tbxAddress"
        Me.tbxAddress.Size = New System.Drawing.Size(382, 25)
        Me.tbxAddress.TabIndex = 3
        '
        'tbxMobileNum
        '
        Me.tbxMobileNum.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbxMobileNum.Font = New System.Drawing.Font("Segoe UI Light", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxMobileNum.Location = New System.Drawing.Point(1144, 497)
        Me.tbxMobileNum.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tbxMobileNum.Name = "tbxMobileNum"
        Me.tbxMobileNum.Size = New System.Drawing.Size(205, 25)
        Me.tbxMobileNum.TabIndex = 4
        '
        'tbxCustomerName
        '
        Me.tbxCustomerName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbxCustomerName.Font = New System.Drawing.Font("Segoe UI Light", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxCustomerName.Location = New System.Drawing.Point(1144, 399)
        Me.tbxCustomerName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tbxCustomerName.Name = "tbxCustomerName"
        Me.tbxCustomerName.Size = New System.Drawing.Size(205, 25)
        Me.tbxCustomerName.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(1144, 363)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(176, 22)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Customer's Name: *"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(1140, 461)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 22)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Mobile #: *"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(1137, 574)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 22)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Address: *"
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Transparent
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.Black
        Me.btnBack.Location = New System.Drawing.Point(21, 15)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(161, 63)
        Me.btnBack.TabIndex = 10
        Me.btnBack.Text = "Back"
        Me.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Aqua
        Me.btnClear.BackgroundImage = Global.Ordering_and_Billing_System_With_Inventory.My.Resources.Resources.clear_symbol_32px
        Me.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.Black
        Me.btnClear.Location = New System.Drawing.Point(1375, 257)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(148, 74)
        Me.btnClear.TabIndex = 11
        Me.btnClear.Text = "Clear"
        Me.btnClear.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.Aqua
        Me.btnAdd.BackgroundImage = Global.Ordering_and_Billing_System_With_Inventory.My.Resources.Resources.add_32px
        Me.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.Black
        Me.btnAdd.Location = New System.Drawing.Point(1375, 383)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(148, 74)
        Me.btnAdd.TabIndex = 12
        Me.btnAdd.Text = "Add"
        Me.btnAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Button2.Location = New System.Drawing.Point(724, 610)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(161, 82)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "Print Bill"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(1142, 646)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(141, 22)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Service Charge:"
        '
        'cbxServiceCharge
        '
        Me.cbxServiceCharge.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbxServiceCharge.Font = New System.Drawing.Font("Segoe UI Light", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxServiceCharge.FormattingEnabled = True
        Me.cbxServiceCharge.Items.AddRange(New Object() {"No", "Yes"})
        Me.cbxServiceCharge.Location = New System.Drawing.Point(1141, 695)
        Me.cbxServiceCharge.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbxServiceCharge.Name = "cbxServiceCharge"
        Me.cbxServiceCharge.Size = New System.Drawing.Size(203, 33)
        Me.cbxServiceCharge.TabIndex = 16
        '
        'btnPrintBill
        '
        Me.btnPrintBill.BackColor = System.Drawing.Color.Aqua
        Me.btnPrintBill.BackgroundImage = Global.Ordering_and_Billing_System_With_Inventory.My.Resources.Resources.billing_machine_32px
        Me.btnPrintBill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnPrintBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrintBill.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrintBill.ForeColor = System.Drawing.Color.Black
        Me.btnPrintBill.Location = New System.Drawing.Point(1375, 501)
        Me.btnPrintBill.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnPrintBill.Name = "btnPrintBill"
        Me.btnPrintBill.Size = New System.Drawing.Size(148, 74)
        Me.btnPrintBill.TabIndex = 17
        Me.btnPrintBill.Text = "Print Bill"
        Me.btnPrintBill.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnPrintBill.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPrintBill.UseVisualStyleBackColor = False
        '
        'MenusTableAdapter
        '
        Me.MenusTableAdapter.ClearBeforeFill = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Location = New System.Drawing.Point(1142, 272)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(98, 22)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Delivery #:"
        '
        'tbxDeliveryNum
        '
        Me.tbxDeliveryNum.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbxDeliveryNum.Font = New System.Drawing.Font("Segoe UI Light", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxDeliveryNum.Location = New System.Drawing.Point(1142, 306)
        Me.tbxDeliveryNum.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tbxDeliveryNum.Name = "tbxDeliveryNum"
        Me.tbxDeliveryNum.ReadOnly = True
        Me.tbxDeliveryNum.Size = New System.Drawing.Size(204, 25)
        Me.tbxDeliveryNum.TabIndex = 18
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.InitialImage = Nothing
        Me.PictureBox3.Location = New System.Drawing.Point(1037, 15)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(159, 147)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 45
        Me.PictureBox3.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label8.Location = New System.Drawing.Point(204, 54)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(292, 40)
        Me.Label8.TabIndex = 44
        Me.Label8.Text = "CREATE ORDER"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(288, 97)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(729, 33)
        Me.PictureBox1.TabIndex = 43
        Me.PictureBox1.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label9.Location = New System.Drawing.Point(174, 132)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(165, 31)
        Me.Label9.TabIndex = 46
        Me.Label9.Text = "MENU LIST"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Light", 23.0!)
        Me.Label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label10.Location = New System.Drawing.Point(251, 142)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(39, 42)
        Me.Label10.TabIndex = 47
        Me.Label10.Text = "..."
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Segoe UI Light", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(1136, 217)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(213, 44)
        Me.Label12.TabIndex = 48
        Me.Label12.Text = "______________________________"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Segoe UI Light", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(1143, 754)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(206, 29)
        Me.Label11.TabIndex = 49
        Me.Label11.Text = "______________________________"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Delivery
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.Red
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1600, 900)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.tbxDeliveryNum)
        Me.Controls.Add(Me.btnPrintBill)
        Me.Controls.Add(Me.cbxServiceCharge)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbxCustomerName)
        Me.Controls.Add(Me.tbxMobileNum)
        Me.Controls.Add(Me.tbxAddress)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.orderDeliveryTab)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximumSize = New System.Drawing.Size(1600, 900)
        Me.MinimumSize = New System.Drawing.Size(1280, 898)
        Me.Name = "Delivery"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Delivery"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.orderDeliveryTab.ResumeLayout(False)
        Me.menusTab.ResumeLayout(False)
        CType(Me.menusDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MenusBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NamwahDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.drinksTab.ResumeLayout(False)
        CType(Me.drinksDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MenusBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NamwahOrdersDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents orderDeliveryTab As TabControl
    Friend WithEvents menusTab As TabPage
    Friend WithEvents NamwahOrdersDataSet As namwahOrdersDataSet
    Friend WithEvents drinksTab As TabPage
    Friend WithEvents NamwahDataSet As namwahDataSet
    Friend WithEvents Panel1 As Panel
    Friend WithEvents listofids As ListBox
    Friend WithEvents Label3 As Label
    Friend WithEvents listofquantity As ListBox
    Friend WithEvents lblListofPrice As Label
    Friend WithEvents lblSelectedMenus As Label
    Friend WithEvents listofprices As ListBox
    Friend WithEvents totalPrice As TextBox
    Friend WithEvents TotalPriceLabel As Label
    Friend WithEvents initialPrice As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents listofmenus As ListBox
    Friend WithEvents tbxAddress As TextBox
    Friend WithEvents tbxMobileNum As TextBox
    Friend WithEvents tbxCustomerName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents cbxServiceCharge As ComboBox
    Friend WithEvents btnPrintBill As Button
    Friend WithEvents drinksDataGrid As DataGridView
    Friend WithEvents menusDataGrid As DataGridView
    Friend WithEvents MenusBindingSource As BindingSource
    Friend WithEvents MenusTableAdapter As namwahDataSetTableAdapters.MenusTableAdapter
    Friend WithEvents MenusBindingSource1 As BindingSource
    Friend WithEvents Label7 As Label
    Friend WithEvents tbxDeliveryNum As TextBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents menusName As DataGridViewTextBoxColumn
    Friend WithEvents menusPrice As DataGridViewTextBoxColumn
    Friend WithEvents menusType As DataGridViewTextBoxColumn
    Friend WithEvents menusStatus As DataGridViewTextBoxColumn
    Friend WithEvents menusQuantity As DataGridViewTextBoxColumn
    Friend WithEvents selectMenus As DataGridViewButtonColumn
    Friend WithEvents menusID As DataGridViewTextBoxColumn
    Friend WithEvents menusNumber As DataGridViewTextBoxColumn
    Friend WithEvents menusDetails As DataGridViewTextBoxColumn
    Friend WithEvents menusDiscount As DataGridViewTextBoxColumn
    Friend WithEvents menusCreatedDateTime As DataGridViewTextBoxColumn
    Friend WithEvents drinksName As DataGridViewTextBoxColumn
    Friend WithEvents drinksPrice As DataGridViewTextBoxColumn
    Friend WithEvents drinksType As DataGridViewTextBoxColumn
    Friend WithEvents drinksStatus As DataGridViewTextBoxColumn
    Friend WithEvents drinksQuantity As DataGridViewTextBoxColumn
    Friend WithEvents selectDrinks As DataGridViewButtonColumn
    Friend WithEvents drinksID As DataGridViewTextBoxColumn
    Friend WithEvents drinksNumber As DataGridViewTextBoxColumn
    Friend WithEvents drinksDetails As DataGridViewTextBoxColumn
    Friend WithEvents drinksDiscount As DataGridViewTextBoxColumn
    Friend WithEvents drinksCreatedDateTime As DataGridViewTextBoxColumn
End Class
