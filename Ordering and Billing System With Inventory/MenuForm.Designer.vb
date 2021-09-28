<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuForm))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.menusTable = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DetailsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.menusStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiscountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Action = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Status = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.MenusBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NamwahDataSet = New Ordering_and_Billing_System_With_Inventory.namwahDataSet()
        Me.MenusTableAdapter = New Ordering_and_Billing_System_With_Inventory.namwahDataSetTableAdapters.MenusTableAdapter()
        Me.NamwahDataSet1 = New Ordering_and_Billing_System_With_Inventory.namwahDataSet()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.menuNumber = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.menuName = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.menuPrice = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.menuType = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.menuStatus = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.menuDiscount = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.menuDetails = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.menusTable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MenusBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NamwahDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NamwahDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.menusTable)
        Me.Panel1.Font = New System.Drawing.Font("Segoe UI Light", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(28, 115)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(746, 756)
        Me.Panel1.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(225, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(226, 42)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "MENU LIST"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Light", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(339, 30)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 47)
        Me.Label6.TabIndex = 43
        Me.Label6.Text = "..."
        '
        'menusTable
        '
        Me.menusTable.AutoGenerateColumns = False
        Me.menusTable.BackgroundColor = System.Drawing.SystemColors.Control
        Me.menusTable.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.menusTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.menusTable.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.MenuNumberDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.DetailsDataGridViewTextBoxColumn, Me.PriceDataGridViewTextBoxColumn, Me.TypeDataGridViewTextBoxColumn, Me.menusStatus, Me.DiscountDataGridViewTextBoxColumn, Me.Action, Me.Status})
        Me.menusTable.DataSource = Me.MenusBindingSource
        Me.menusTable.GridColor = System.Drawing.Color.Firebrick
        Me.menusTable.Location = New System.Drawing.Point(4, 105)
        Me.menusTable.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.menusTable.Name = "menusTable"
        Me.menusTable.ReadOnly = True
        Me.menusTable.RowHeadersVisible = False
        Me.menusTable.RowHeadersWidth = 250
        Me.menusTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.menusTable.RowTemplate.Height = 24
        Me.menusTable.Size = New System.Drawing.Size(727, 646)
        Me.menusTable.TabIndex = 2
        Me.menusTable.Tag = "menusTable"
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
        'MenuNumberDataGridViewTextBoxColumn
        '
        Me.MenuNumberDataGridViewTextBoxColumn.DataPropertyName = "MenuNumber"
        Me.MenuNumberDataGridViewTextBoxColumn.HeaderText = "MenuNumber"
        Me.MenuNumberDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.MenuNumberDataGridViewTextBoxColumn.Name = "MenuNumberDataGridViewTextBoxColumn"
        Me.MenuNumberDataGridViewTextBoxColumn.ReadOnly = True
        Me.MenuNumberDataGridViewTextBoxColumn.Width = 125
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "Name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.NameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        Me.NameDataGridViewTextBoxColumn.ReadOnly = True
        Me.NameDataGridViewTextBoxColumn.Width = 125
        '
        'DetailsDataGridViewTextBoxColumn
        '
        Me.DetailsDataGridViewTextBoxColumn.DataPropertyName = "Details"
        Me.DetailsDataGridViewTextBoxColumn.HeaderText = "Details"
        Me.DetailsDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DetailsDataGridViewTextBoxColumn.Name = "DetailsDataGridViewTextBoxColumn"
        Me.DetailsDataGridViewTextBoxColumn.ReadOnly = True
        Me.DetailsDataGridViewTextBoxColumn.Width = 125
        '
        'PriceDataGridViewTextBoxColumn
        '
        Me.PriceDataGridViewTextBoxColumn.DataPropertyName = "Price"
        Me.PriceDataGridViewTextBoxColumn.HeaderText = "Price"
        Me.PriceDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PriceDataGridViewTextBoxColumn.Name = "PriceDataGridViewTextBoxColumn"
        Me.PriceDataGridViewTextBoxColumn.ReadOnly = True
        Me.PriceDataGridViewTextBoxColumn.Width = 125
        '
        'TypeDataGridViewTextBoxColumn
        '
        Me.TypeDataGridViewTextBoxColumn.DataPropertyName = "Type"
        Me.TypeDataGridViewTextBoxColumn.HeaderText = "Type"
        Me.TypeDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TypeDataGridViewTextBoxColumn.Name = "TypeDataGridViewTextBoxColumn"
        Me.TypeDataGridViewTextBoxColumn.ReadOnly = True
        Me.TypeDataGridViewTextBoxColumn.Width = 125
        '
        'menusStatus
        '
        Me.menusStatus.DataPropertyName = "Status"
        Me.menusStatus.HeaderText = "Status"
        Me.menusStatus.MinimumWidth = 6
        Me.menusStatus.Name = "menusStatus"
        Me.menusStatus.ReadOnly = True
        Me.menusStatus.Width = 125
        '
        'DiscountDataGridViewTextBoxColumn
        '
        Me.DiscountDataGridViewTextBoxColumn.DataPropertyName = "Discount"
        Me.DiscountDataGridViewTextBoxColumn.HeaderText = "Discount"
        Me.DiscountDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DiscountDataGridViewTextBoxColumn.Name = "DiscountDataGridViewTextBoxColumn"
        Me.DiscountDataGridViewTextBoxColumn.ReadOnly = True
        Me.DiscountDataGridViewTextBoxColumn.Width = 125
        '
        'Action
        '
        Me.Action.HeaderText = "Action"
        Me.Action.MinimumWidth = 6
        Me.Action.Name = "Action"
        Me.Action.ReadOnly = True
        Me.Action.Text = "Delete"
        Me.Action.ToolTipText = "Delete"
        Me.Action.UseColumnTextForButtonValue = True
        Me.Action.Width = 125
        '
        'Status
        '
        Me.Status.HeaderText = "Action"
        Me.Status.MinimumWidth = 6
        Me.Status.Name = "Status"
        Me.Status.ReadOnly = True
        Me.Status.Text = "Available/Unavailable"
        Me.Status.ToolTipText = "Available/Unavailable"
        Me.Status.UseColumnTextForButtonValue = True
        Me.Status.Width = 125
        '
        'MenusBindingSource
        '
        Me.MenusBindingSource.DataMember = "Menus"
        Me.MenusBindingSource.DataSource = Me.NamwahDataSet
        '
        'NamwahDataSet
        '
        Me.NamwahDataSet.DataSetName = "namwahDataSet"
        Me.NamwahDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MenusTableAdapter
        '
        Me.MenusTableAdapter.ClearBeforeFill = True
        '
        'NamwahDataSet1
        '
        Me.NamwahDataSet1.DataSetName = "namwahDataSet"
        Me.NamwahDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(-31, 108)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(231, 75)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "*Menu Number :"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'menuNumber
        '
        Me.menuNumber.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.menuNumber.Font = New System.Drawing.Font("Segoe UI Light", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menuNumber.ForeColor = System.Drawing.Color.Black
        Me.menuNumber.Location = New System.Drawing.Point(164, 131)
        Me.menuNumber.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.menuNumber.Name = "menuNumber"
        Me.menuNumber.ReadOnly = True
        Me.menuNumber.Size = New System.Drawing.Size(127, 25)
        Me.menuNumber.TabIndex = 3
        Me.menuNumber.Tag = "menuNumber"
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(58, 61)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(120, 38)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "*Name :"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'menuName
        '
        Me.menuName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.menuName.Font = New System.Drawing.Font("Segoe UI Light", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menuName.ForeColor = System.Drawing.Color.Black
        Me.menuName.Location = New System.Drawing.Point(164, 66)
        Me.menuName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.menuName.Name = "menuName"
        Me.menuName.Size = New System.Drawing.Size(233, 25)
        Me.menuName.TabIndex = 5
        Me.menuName.Tag = "menuName"
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(58, 161)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(120, 48)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "* Price :"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'menuPrice
        '
        Me.menuPrice.BackColor = System.Drawing.SystemColors.Window
        Me.menuPrice.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.menuPrice.Font = New System.Drawing.Font("Segoe UI Light", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menuPrice.ForeColor = System.Drawing.Color.Black
        Me.menuPrice.Location = New System.Drawing.Point(164, 171)
        Me.menuPrice.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.menuPrice.Name = "menuPrice"
        Me.menuPrice.Size = New System.Drawing.Size(129, 25)
        Me.menuPrice.TabIndex = 7
        Me.menuPrice.Tag = "menuPrice"
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(310, 127)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(78, 34)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "Type :"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'menuType
        '
        Me.menuType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.menuType.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.menuType.Font = New System.Drawing.Font("Segoe UI Light", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menuType.ForeColor = System.Drawing.Color.Black
        Me.menuType.FormattingEnabled = True
        Me.menuType.ItemHeight = 25
        Me.menuType.Items.AddRange(New Object() {"Main Dish", "Appetizer", "Dessert", "Rice", "Drinks"})
        Me.menuType.Location = New System.Drawing.Point(398, 128)
        Me.menuType.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.menuType.Name = "menuType"
        Me.menuType.Size = New System.Drawing.Size(137, 33)
        Me.menuType.TabIndex = 10
        Me.menuType.Tag = "menuType"
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(299, 169)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(94, 34)
        Me.Label13.TabIndex = 11
        Me.Label13.Text = "Status :"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'menuStatus
        '
        Me.menuStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.menuStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.menuStatus.Font = New System.Drawing.Font("Segoe UI Light", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menuStatus.ForeColor = System.Drawing.Color.Black
        Me.menuStatus.FormattingEnabled = True
        Me.menuStatus.ItemHeight = 25
        Me.menuStatus.Items.AddRange(New Object() {"Available", "Unavailable"})
        Me.menuStatus.Location = New System.Drawing.Point(398, 168)
        Me.menuStatus.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.menuStatus.Name = "menuStatus"
        Me.menuStatus.Size = New System.Drawing.Size(137, 33)
        Me.menuStatus.TabIndex = 12
        Me.menuStatus.Tag = "menuStatus"
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(310, 384)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(98, 42)
        Me.Label14.TabIndex = 13
        Me.Label14.Text = "Discount :"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label14.Visible = False
        '
        'menuDiscount
        '
        Me.menuDiscount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.menuDiscount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.menuDiscount.Font = New System.Drawing.Font("Segoe UI Light", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menuDiscount.ForeColor = System.Drawing.Color.Black
        Me.menuDiscount.FormattingEnabled = True
        Me.menuDiscount.ItemHeight = 25
        Me.menuDiscount.Items.AddRange(New Object() {"No", "Yes"})
        Me.menuDiscount.Location = New System.Drawing.Point(315, 385)
        Me.menuDiscount.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.menuDiscount.Name = "menuDiscount"
        Me.menuDiscount.Size = New System.Drawing.Size(137, 33)
        Me.menuDiscount.TabIndex = 14
        Me.menuDiscount.Tag = "menuDiscount"
        Me.menuDiscount.Visible = False
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(29, 406)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(149, 47)
        Me.Label15.TabIndex = 15
        Me.Label15.Text = "Details :"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'menuDetails
        '
        Me.menuDetails.Font = New System.Drawing.Font("Segoe UI Light", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menuDetails.ForeColor = System.Drawing.Color.White
        Me.menuDetails.Location = New System.Drawing.Point(65, 458)
        Me.menuDetails.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.menuDetails.Multiline = True
        Me.menuDetails.Name = "menuDetails"
        Me.menuDetails.Size = New System.Drawing.Size(470, 222)
        Me.menuDetails.TabIndex = 16
        Me.menuDetails.Tag = "menuDetails"
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.Aqua
        Me.btnAdd.BackgroundImage = CType(resources.GetObject("btnAdd.BackgroundImage"), System.Drawing.Image)
        Me.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.Black
        Me.btnAdd.Location = New System.Drawing.Point(106, 288)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(132, 87)
        Me.btnAdd.TabIndex = 17
        Me.btnAdd.Text = "Add"
        Me.btnAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Aqua
        Me.Button2.BackgroundImage = Global.Ordering_and_Billing_System_With_Inventory.My.Resources.Resources.clear_symbol_32px
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(262, 288)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(131, 87)
        Me.Button2.TabIndex = 18
        Me.Button2.Text = "Clear"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button2.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Transparent
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.Black
        Me.btnBack.Location = New System.Drawing.Point(28, 14)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(122, 58)
        Me.btnBack.TabIndex = 19
        Me.btnBack.Text = "Back"
        Me.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.btnAdd)
        Me.Panel2.Controls.Add(Me.menuDetails)
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Controls.Add(Me.menuDiscount)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Controls.Add(Me.menuStatus)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.menuType)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.menuPrice)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.menuName)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.menuNumber)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Location = New System.Drawing.Point(782, 145)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(658, 772)
        Me.Panel2.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(0, 229)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(376, 26)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "_____________________________________________"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(376, 26)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "_____________________________________________"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Light", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(220, 355)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 47)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "..."
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.InitialImage = Nothing
        Me.PictureBox3.Location = New System.Drawing.Point(1097, 2)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(159, 147)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 53
        Me.PictureBox3.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(183, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(257, 42)
        Me.Label2.TabIndex = 52
        Me.Label2.Text = "MENU FORM"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(436, 74)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1248, 33)
        Me.PictureBox1.TabIndex = 51
        Me.PictureBox1.TabStop = False
        '
        'MenuForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1284, 898)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximumSize = New System.Drawing.Size(1918, 1381)
        Me.MinimumSize = New System.Drawing.Size(1278, 898)
        Me.Name = "MenuForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.menusTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MenusBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NamwahDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NamwahDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents menusTable As DataGridView
    Friend WithEvents NamwahDataSet As namwahDataSet
    Friend WithEvents MenusBindingSource As BindingSource
    Friend WithEvents MenusTableAdapter As namwahDataSetTableAdapters.MenusTableAdapter
    Friend WithEvents NamwahDataSet1 As namwahDataSet
    Friend WithEvents Label9 As Label
    Friend WithEvents menuNumber As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents menuName As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents menuPrice As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents menuType As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents menuStatus As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents menuDiscount As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents menuDetails As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents MenuNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DetailsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents menusStatus As DataGridViewTextBoxColumn
    Friend WithEvents DiscountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Action As DataGridViewButtonColumn
    Friend WithEvents Status As DataGridViewButtonColumn
End Class
