<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OrdersAdditional
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OrdersAdditional))
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.tbxOrderType = New System.Windows.Forms.TextBox()
        Me.tbxTableNumber = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnRemoveLastItem = New System.Windows.Forms.Button()
        Me.btnPrintBill = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.cbxOrderNumber = New System.Windows.Forms.ComboBox()
        Me.OrdersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrdersDataSet = New Ordering_and_Billing_System_With_Inventory.ordersDataSet()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.listofids = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.listofquantity = New System.Windows.Forms.ListBox()
        Me.lblListofPrice = New System.Windows.Forms.Label()
        Me.lblSelectedMenus = New System.Windows.Forms.Label()
        Me.listofprices = New System.Windows.Forms.ListBox()
        Me.totalPrice = New System.Windows.Forms.TextBox()
        Me.TotalPriceLabel = New System.Windows.Forms.Label()
        Me.initialPrice = New System.Windows.Forms.TextBox()
        Me.listofmenus = New System.Windows.Forms.ListBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.menuTab = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.mainDishTable = New System.Windows.Forms.DataGridView()
        Me.mainDishID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mainDishName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DetailsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mainDishPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mainDishStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiscountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CreatedDateTimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mainDishQuantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mainDishAction = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.mainDishBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MenusDataSet = New Ordering_and_Billing_System_With_Inventory.menusDataSet()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.appetizerTable = New System.Windows.Forms.DataGridView()
        Me.appetizerName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.appetizerID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuNumberDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DetailsDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.appetizerPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TypeDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.appetizerStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiscountDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CreatedDateTimeDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.appetizerQuantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.appetizerAction = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.appetizerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.dessertTable = New System.Windows.Forms.DataGridView()
        Me.dessertName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dessertID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuNumberDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DetailsDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dessertPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TypeDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dessertStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiscountDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CreatedDateTimeDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dessertQuantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dessertAction = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.dessertBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.drinksTable = New System.Windows.Forms.DataGridView()
        Me.drinksName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.drinksID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuNumberDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DetailsDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.drinksPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TypeDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.drinksStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiscountDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CreatedDateTimeDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.drinksQuantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.drinksAction = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.drinksBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MenusTableAdapter = New Ordering_and_Billing_System_With_Inventory.menusDataSetTableAdapters.MenusTableAdapter()
        Me.OrdersTableAdapter = New Ordering_and_Billing_System_With_Inventory.ordersDataSetTableAdapters.OrdersTableAdapter()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.OrdersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrdersDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.menuTab.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.mainDishTable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mainDishBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MenusDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.appetizerTable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.appetizerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.dessertTable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dessertBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        CType(Me.drinksTable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.drinksBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(578, 118)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(949, 40)
        Me.PictureBox1.TabIndex = 50
        Me.PictureBox1.TabStop = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Transparent
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.Black
        Me.btnBack.Location = New System.Drawing.Point(36, 41)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(121, 51)
        Me.btnBack.TabIndex = 49
        Me.btnBack.Text = "Back"
        Me.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(28, 118)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(546, 40)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "ADDITIONAL/UPDATE ORDERS"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label7.Location = New System.Drawing.Point(507, 445)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(9, 169)
        Me.Label7.TabIndex = 53
        Me.Label7.Text = "|" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "|" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "|" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "|" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "|" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "|" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "|" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "|" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "|" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "|" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "|" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "|" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "|"
        '
        'Panel1
        '
        Me.Panel1.AutoSize = True
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.tbxOrderType)
        Me.Panel1.Controls.Add(Me.tbxTableNumber)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.cbxOrderNumber)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.listofids)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.listofquantity)
        Me.Panel1.Controls.Add(Me.lblListofPrice)
        Me.Panel1.Controls.Add(Me.lblSelectedMenus)
        Me.Panel1.Controls.Add(Me.listofprices)
        Me.Panel1.Controls.Add(Me.totalPrice)
        Me.Panel1.Controls.Add(Me.TotalPriceLabel)
        Me.Panel1.Controls.Add(Me.initialPrice)
        Me.Panel1.Controls.Add(Me.listofmenus)
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(541, 177)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(760, 609)
        Me.Panel1.TabIndex = 51
        '
        'tbxOrderType
        '
        Me.tbxOrderType.BackColor = System.Drawing.Color.White
        Me.tbxOrderType.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbxOrderType.Cursor = System.Windows.Forms.Cursors.Default
        Me.tbxOrderType.Font = New System.Drawing.Font("Segoe UI Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxOrderType.Location = New System.Drawing.Point(557, 319)
        Me.tbxOrderType.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.tbxOrderType.Name = "tbxOrderType"
        Me.tbxOrderType.ReadOnly = True
        Me.tbxOrderType.Size = New System.Drawing.Size(161, 32)
        Me.tbxOrderType.TabIndex = 56
        Me.tbxOrderType.Tag = "Order Number"
        '
        'tbxTableNumber
        '
        Me.tbxTableNumber.BackColor = System.Drawing.Color.White
        Me.tbxTableNumber.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbxTableNumber.Cursor = System.Windows.Forms.Cursors.Default
        Me.tbxTableNumber.Font = New System.Drawing.Font("Segoe UI Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxTableNumber.Location = New System.Drawing.Point(557, 222)
        Me.tbxTableNumber.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.tbxTableNumber.Name = "tbxTableNumber"
        Me.tbxTableNumber.ReadOnly = True
        Me.tbxTableNumber.Size = New System.Drawing.Size(161, 32)
        Me.tbxTableNumber.TabIndex = 55
        Me.tbxTableNumber.Tag = "Order Number"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label8.Location = New System.Drawing.Point(552, 288)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(110, 22)
        Me.Label8.TabIndex = 54
        Me.Label8.Text = "Order Type:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(552, 179)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(131, 22)
        Me.Label4.TabIndex = 53
        Me.Label4.Text = "Table Number:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label10.Location = New System.Drawing.Point(552, 72)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(136, 22)
        Me.Label10.TabIndex = 52
        Me.Label10.Text = "Order Number:"
        '
        'btnRemoveLastItem
        '
        Me.btnRemoveLastItem.BackColor = System.Drawing.Color.Aqua
        Me.btnRemoveLastItem.BackgroundImage = Global.Ordering_and_Billing_System_With_Inventory.My.Resources.Resources.clear_symbol_32px
        Me.btnRemoveLastItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnRemoveLastItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemoveLastItem.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemoveLastItem.ForeColor = System.Drawing.Color.Black
        Me.btnRemoveLastItem.Location = New System.Drawing.Point(1341, 280)
        Me.btnRemoveLastItem.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnRemoveLastItem.Name = "btnRemoveLastItem"
        Me.btnRemoveLastItem.Size = New System.Drawing.Size(168, 60)
        Me.btnRemoveLastItem.TabIndex = 51
        Me.btnRemoveLastItem.Text = "Remove Selected Item"
        Me.btnRemoveLastItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnRemoveLastItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnRemoveLastItem.UseVisualStyleBackColor = False
        '
        'btnPrintBill
        '
        Me.btnPrintBill.BackColor = System.Drawing.Color.Aqua
        Me.btnPrintBill.BackgroundImage = Global.Ordering_and_Billing_System_With_Inventory.My.Resources.Resources.billing_machine_32px
        Me.btnPrintBill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnPrintBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrintBill.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrintBill.ForeColor = System.Drawing.Color.Black
        Me.btnPrintBill.Location = New System.Drawing.Point(1341, 399)
        Me.btnPrintBill.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnPrintBill.Name = "btnPrintBill"
        Me.btnPrintBill.Size = New System.Drawing.Size(168, 61)
        Me.btnPrintBill.TabIndex = 50
        Me.btnPrintBill.Text = "Print Bill"
        Me.btnPrintBill.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnPrintBill.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPrintBill.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.Aqua
        Me.btnAdd.BackgroundImage = Global.Ordering_and_Billing_System_With_Inventory.My.Resources.Resources.add_32px
        Me.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.Black
        Me.btnAdd.Location = New System.Drawing.Point(1341, 496)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(168, 60)
        Me.btnAdd.TabIndex = 49
        Me.btnAdd.Text = "Update"
        Me.btnAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'cbxOrderNumber
        '
        Me.cbxOrderNumber.BackColor = System.Drawing.Color.White
        Me.cbxOrderNumber.DataSource = Me.OrdersBindingSource
        Me.cbxOrderNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxOrderNumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbxOrderNumber.Font = New System.Drawing.Font("Segoe UI Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxOrderNumber.FormattingEnabled = True
        Me.cbxOrderNumber.ItemHeight = 32
        Me.cbxOrderNumber.Location = New System.Drawing.Point(557, 103)
        Me.cbxOrderNumber.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.cbxOrderNumber.Name = "cbxOrderNumber"
        Me.cbxOrderNumber.Size = New System.Drawing.Size(161, 40)
        Me.cbxOrderNumber.TabIndex = 48
        Me.cbxOrderNumber.Tag = "Type"
        '
        'OrdersBindingSource
        '
        Me.OrdersBindingSource.DataMember = "Orders"
        Me.OrdersBindingSource.DataSource = Me.OrdersDataSet
        Me.OrdersBindingSource.Filter = "Status='Pending' OR Status='Complete'"
        '
        'OrdersDataSet
        '
        Me.OrdersDataSet.DataSetName = "ordersDataSet"
        Me.OrdersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(24, 506)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 22)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Initial Price:"
        '
        'listofids
        '
        Me.listofids.FormattingEnabled = True
        Me.listofids.ItemHeight = 26
        Me.listofids.Location = New System.Drawing.Point(159, 16)
        Me.listofids.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.listofids.Name = "listofids"
        Me.listofids.Size = New System.Drawing.Size(78, 4)
        Me.listofids.TabIndex = 15
        Me.listofids.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(280, 25)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 26)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Quantity"
        '
        'listofquantity
        '
        Me.listofquantity.Enabled = False
        Me.listofquantity.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.listofquantity.FormattingEnabled = True
        Me.listofquantity.ItemHeight = 14
        Me.listofquantity.Location = New System.Drawing.Point(286, 72)
        Me.listofquantity.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.listofquantity.Name = "listofquantity"
        Me.listofquantity.Size = New System.Drawing.Size(95, 424)
        Me.listofquantity.TabIndex = 13
        '
        'lblListofPrice
        '
        Me.lblListofPrice.AutoSize = True
        Me.lblListofPrice.BackColor = System.Drawing.Color.Transparent
        Me.lblListofPrice.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblListofPrice.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblListofPrice.Location = New System.Drawing.Point(410, 25)
        Me.lblListofPrice.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblListofPrice.Name = "lblListofPrice"
        Me.lblListofPrice.Size = New System.Drawing.Size(76, 26)
        Me.lblListofPrice.TabIndex = 12
        Me.lblListofPrice.Text = "Prices"
        '
        'lblSelectedMenus
        '
        Me.lblSelectedMenus.AutoSize = True
        Me.lblSelectedMenus.BackColor = System.Drawing.Color.Transparent
        Me.lblSelectedMenus.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelectedMenus.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblSelectedMenus.Location = New System.Drawing.Point(23, 25)
        Me.lblSelectedMenus.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSelectedMenus.Name = "lblSelectedMenus"
        Me.lblSelectedMenus.Size = New System.Drawing.Size(159, 26)
        Me.lblSelectedMenus.TabIndex = 11
        Me.lblSelectedMenus.Text = "Selected Items"
        '
        'listofprices
        '
        Me.listofprices.Enabled = False
        Me.listofprices.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.listofprices.FormattingEnabled = True
        Me.listofprices.ItemHeight = 14
        Me.listofprices.Location = New System.Drawing.Point(389, 72)
        Me.listofprices.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.listofprices.Name = "listofprices"
        Me.listofprices.Size = New System.Drawing.Size(122, 424)
        Me.listofprices.TabIndex = 10
        '
        'totalPrice
        '
        Me.totalPrice.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.totalPrice.Font = New System.Drawing.Font("Segoe UI Light", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalPrice.Location = New System.Drawing.Point(346, 540)
        Me.totalPrice.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.totalPrice.Name = "totalPrice"
        Me.totalPrice.ReadOnly = True
        Me.totalPrice.Size = New System.Drawing.Size(239, 29)
        Me.totalPrice.TabIndex = 9
        Me.totalPrice.Tag = "Total"
        Me.totalPrice.Text = "0"
        Me.totalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TotalPriceLabel
        '
        Me.TotalPriceLabel.BackColor = System.Drawing.Color.Transparent
        Me.TotalPriceLabel.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalPriceLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TotalPriceLabel.Location = New System.Drawing.Point(342, 500)
        Me.TotalPriceLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TotalPriceLabel.Name = "TotalPriceLabel"
        Me.TotalPriceLabel.Size = New System.Drawing.Size(111, 34)
        Me.TotalPriceLabel.TabIndex = 8
        Me.TotalPriceLabel.Text = "Total Price:"
        Me.TotalPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'initialPrice
        '
        Me.initialPrice.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.initialPrice.Font = New System.Drawing.Font("Segoe UI Light", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.initialPrice.Location = New System.Drawing.Point(28, 540)
        Me.initialPrice.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.initialPrice.Name = "initialPrice"
        Me.initialPrice.ReadOnly = True
        Me.initialPrice.Size = New System.Drawing.Size(239, 29)
        Me.initialPrice.TabIndex = 7
        Me.initialPrice.Tag = "Initial"
        Me.initialPrice.Text = "0"
        Me.initialPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'listofmenus
        '
        Me.listofmenus.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.listofmenus.FormattingEnabled = True
        Me.listofmenus.ItemHeight = 14
        Me.listofmenus.Location = New System.Drawing.Point(23, 72)
        Me.listofmenus.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.listofmenus.Name = "listofmenus"
        Me.listofmenus.Size = New System.Drawing.Size(255, 424)
        Me.listofmenus.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 23.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(150, 156)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(189, 36)
        Me.Label5.TabIndex = 55
        Me.Label5.Text = "MENU LIST"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Light", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(204, 164)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 47)
        Me.Label6.TabIndex = 56
        Me.Label6.Text = "..."
        '
        'menuTab
        '
        Me.menuTab.Controls.Add(Me.TabPage1)
        Me.menuTab.Controls.Add(Me.TabPage2)
        Me.menuTab.Controls.Add(Me.TabPage3)
        Me.menuTab.Controls.Add(Me.TabPage4)
        Me.menuTab.Font = New System.Drawing.Font("Segoe UI Light", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menuTab.Location = New System.Drawing.Point(43, 221)
        Me.menuTab.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.menuTab.Name = "menuTab"
        Me.menuTab.SelectedIndex = 0
        Me.menuTab.Size = New System.Drawing.Size(473, 529)
        Me.menuTab.TabIndex = 57
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.White
        Me.TabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.TabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPage1.Controls.Add(Me.mainDishTable)
        Me.TabPage1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.TabPage1.ForeColor = System.Drawing.Color.Black
        Me.TabPage1.Location = New System.Drawing.Point(4, 34)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.TabPage1.Size = New System.Drawing.Size(465, 491)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Main Dish"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'mainDishTable
        '
        Me.mainDishTable.AllowUserToAddRows = False
        Me.mainDishTable.AllowUserToDeleteRows = False
        Me.mainDishTable.AutoGenerateColumns = False
        Me.mainDishTable.BackgroundColor = System.Drawing.Color.White
        Me.mainDishTable.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.mainDishTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.mainDishTable.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.mainDishID, Me.MenuNumberDataGridViewTextBoxColumn, Me.mainDishName, Me.DetailsDataGridViewTextBoxColumn, Me.mainDishPrice, Me.TypeDataGridViewTextBoxColumn, Me.mainDishStatus, Me.DiscountDataGridViewTextBoxColumn, Me.CreatedDateTimeDataGridViewTextBoxColumn, Me.mainDishQuantity, Me.mainDishAction})
        Me.mainDishTable.DataSource = Me.mainDishBindingSource
        Me.mainDishTable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mainDishTable.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke
        Me.mainDishTable.Location = New System.Drawing.Point(4, 6)
        Me.mainDishTable.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.mainDishTable.Name = "mainDishTable"
        Me.mainDishTable.RowHeadersVisible = False
        Me.mainDishTable.RowHeadersWidth = 250
        Me.mainDishTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.mainDishTable.RowTemplate.Height = 24
        Me.mainDishTable.Size = New System.Drawing.Size(453, 475)
        Me.mainDishTable.TabIndex = 3
        Me.mainDishTable.Tag = "menusTable"
        '
        'mainDishID
        '
        Me.mainDishID.DataPropertyName = "ID"
        Me.mainDishID.HeaderText = "ID"
        Me.mainDishID.MinimumWidth = 6
        Me.mainDishID.Name = "mainDishID"
        Me.mainDishID.Visible = False
        Me.mainDishID.Width = 125
        '
        'MenuNumberDataGridViewTextBoxColumn
        '
        Me.MenuNumberDataGridViewTextBoxColumn.DataPropertyName = "MenuNumber"
        Me.MenuNumberDataGridViewTextBoxColumn.HeaderText = "MenuNumber"
        Me.MenuNumberDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.MenuNumberDataGridViewTextBoxColumn.Name = "MenuNumberDataGridViewTextBoxColumn"
        Me.MenuNumberDataGridViewTextBoxColumn.Visible = False
        Me.MenuNumberDataGridViewTextBoxColumn.Width = 125
        '
        'mainDishName
        '
        Me.mainDishName.DataPropertyName = "Name"
        Me.mainDishName.HeaderText = "Name"
        Me.mainDishName.MinimumWidth = 6
        Me.mainDishName.Name = "mainDishName"
        Me.mainDishName.ReadOnly = True
        Me.mainDishName.Width = 125
        '
        'DetailsDataGridViewTextBoxColumn
        '
        Me.DetailsDataGridViewTextBoxColumn.DataPropertyName = "Details"
        Me.DetailsDataGridViewTextBoxColumn.HeaderText = "Details"
        Me.DetailsDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DetailsDataGridViewTextBoxColumn.Name = "DetailsDataGridViewTextBoxColumn"
        Me.DetailsDataGridViewTextBoxColumn.Visible = False
        Me.DetailsDataGridViewTextBoxColumn.Width = 125
        '
        'mainDishPrice
        '
        Me.mainDishPrice.DataPropertyName = "Price"
        Me.mainDishPrice.HeaderText = "Price"
        Me.mainDishPrice.MinimumWidth = 6
        Me.mainDishPrice.Name = "mainDishPrice"
        Me.mainDishPrice.ReadOnly = True
        Me.mainDishPrice.Width = 125
        '
        'TypeDataGridViewTextBoxColumn
        '
        Me.TypeDataGridViewTextBoxColumn.DataPropertyName = "Type"
        Me.TypeDataGridViewTextBoxColumn.HeaderText = "Type"
        Me.TypeDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TypeDataGridViewTextBoxColumn.Name = "TypeDataGridViewTextBoxColumn"
        Me.TypeDataGridViewTextBoxColumn.Visible = False
        Me.TypeDataGridViewTextBoxColumn.Width = 125
        '
        'mainDishStatus
        '
        Me.mainDishStatus.DataPropertyName = "Status"
        Me.mainDishStatus.HeaderText = "Status"
        Me.mainDishStatus.MinimumWidth = 6
        Me.mainDishStatus.Name = "mainDishStatus"
        Me.mainDishStatus.Visible = False
        Me.mainDishStatus.Width = 125
        '
        'DiscountDataGridViewTextBoxColumn
        '
        Me.DiscountDataGridViewTextBoxColumn.DataPropertyName = "Discount"
        Me.DiscountDataGridViewTextBoxColumn.HeaderText = "Discount"
        Me.DiscountDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DiscountDataGridViewTextBoxColumn.Name = "DiscountDataGridViewTextBoxColumn"
        Me.DiscountDataGridViewTextBoxColumn.Visible = False
        Me.DiscountDataGridViewTextBoxColumn.Width = 125
        '
        'CreatedDateTimeDataGridViewTextBoxColumn
        '
        Me.CreatedDateTimeDataGridViewTextBoxColumn.DataPropertyName = "createdDateTime"
        Me.CreatedDateTimeDataGridViewTextBoxColumn.HeaderText = "createdDateTime"
        Me.CreatedDateTimeDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CreatedDateTimeDataGridViewTextBoxColumn.Name = "CreatedDateTimeDataGridViewTextBoxColumn"
        Me.CreatedDateTimeDataGridViewTextBoxColumn.Visible = False
        Me.CreatedDateTimeDataGridViewTextBoxColumn.Width = 125
        '
        'mainDishQuantity
        '
        DataGridViewCellStyle5.Format = "N0"
        DataGridViewCellStyle5.NullValue = "1"
        Me.mainDishQuantity.DefaultCellStyle = DataGridViewCellStyle5
        Me.mainDishQuantity.HeaderText = "Quantity"
        Me.mainDishQuantity.MinimumWidth = 6
        Me.mainDishQuantity.Name = "mainDishQuantity"
        Me.mainDishQuantity.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.mainDishQuantity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.mainDishQuantity.ToolTipText = "Quantity"
        Me.mainDishQuantity.Width = 80
        '
        'mainDishAction
        '
        Me.mainDishAction.HeaderText = "Action"
        Me.mainDishAction.MinimumWidth = 6
        Me.mainDishAction.Name = "mainDishAction"
        Me.mainDishAction.Text = "Add"
        Me.mainDishAction.ToolTipText = "Add"
        Me.mainDishAction.UseColumnTextForButtonValue = True
        Me.mainDishAction.Width = 125
        '
        'mainDishBindingSource
        '
        Me.mainDishBindingSource.DataMember = "Menus"
        Me.mainDishBindingSource.DataSource = Me.MenusDataSet
        Me.mainDishBindingSource.Filter = "Type='Main Dish' And Status='Available'"
        '
        'MenusDataSet
        '
        Me.MenusDataSet.DataSetName = "menusDataSet"
        Me.MenusDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.White
        Me.TabPage2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPage2.Controls.Add(Me.appetizerTable)
        Me.TabPage2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.TabPage2.ForeColor = System.Drawing.Color.Black
        Me.TabPage2.Location = New System.Drawing.Point(4, 34)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.TabPage2.Size = New System.Drawing.Size(465, 491)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Appetizer"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'appetizerTable
        '
        Me.appetizerTable.AllowUserToAddRows = False
        Me.appetizerTable.AllowUserToDeleteRows = False
        Me.appetizerTable.AutoGenerateColumns = False
        Me.appetizerTable.BackgroundColor = System.Drawing.Color.White
        Me.appetizerTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.appetizerTable.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.appetizerName, Me.appetizerID, Me.MenuNumberDataGridViewTextBoxColumn1, Me.DetailsDataGridViewTextBoxColumn1, Me.appetizerPrice, Me.TypeDataGridViewTextBoxColumn1, Me.appetizerStatus, Me.DiscountDataGridViewTextBoxColumn1, Me.CreatedDateTimeDataGridViewTextBoxColumn1, Me.appetizerQuantity, Me.appetizerAction})
        Me.appetizerTable.DataSource = Me.appetizerBindingSource
        Me.appetizerTable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.appetizerTable.Location = New System.Drawing.Point(4, 6)
        Me.appetizerTable.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.appetizerTable.Name = "appetizerTable"
        Me.appetizerTable.RowHeadersVisible = False
        Me.appetizerTable.RowHeadersWidth = 250
        Me.appetizerTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.appetizerTable.RowTemplate.Height = 24
        Me.appetizerTable.Size = New System.Drawing.Size(453, 475)
        Me.appetizerTable.TabIndex = 4
        Me.appetizerTable.Tag = "appetizerTable"
        '
        'appetizerName
        '
        Me.appetizerName.DataPropertyName = "Name"
        Me.appetizerName.HeaderText = "Name"
        Me.appetizerName.MinimumWidth = 6
        Me.appetizerName.Name = "appetizerName"
        Me.appetizerName.ReadOnly = True
        Me.appetizerName.Width = 125
        '
        'appetizerID
        '
        Me.appetizerID.DataPropertyName = "ID"
        Me.appetizerID.HeaderText = "ID"
        Me.appetizerID.MinimumWidth = 6
        Me.appetizerID.Name = "appetizerID"
        Me.appetizerID.Visible = False
        Me.appetizerID.Width = 125
        '
        'MenuNumberDataGridViewTextBoxColumn1
        '
        Me.MenuNumberDataGridViewTextBoxColumn1.DataPropertyName = "MenuNumber"
        Me.MenuNumberDataGridViewTextBoxColumn1.HeaderText = "MenuNumber"
        Me.MenuNumberDataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.MenuNumberDataGridViewTextBoxColumn1.Name = "MenuNumberDataGridViewTextBoxColumn1"
        Me.MenuNumberDataGridViewTextBoxColumn1.Visible = False
        Me.MenuNumberDataGridViewTextBoxColumn1.Width = 125
        '
        'DetailsDataGridViewTextBoxColumn1
        '
        Me.DetailsDataGridViewTextBoxColumn1.DataPropertyName = "Details"
        Me.DetailsDataGridViewTextBoxColumn1.HeaderText = "Details"
        Me.DetailsDataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DetailsDataGridViewTextBoxColumn1.Name = "DetailsDataGridViewTextBoxColumn1"
        Me.DetailsDataGridViewTextBoxColumn1.Visible = False
        Me.DetailsDataGridViewTextBoxColumn1.Width = 125
        '
        'appetizerPrice
        '
        Me.appetizerPrice.DataPropertyName = "Price"
        Me.appetizerPrice.HeaderText = "Price"
        Me.appetizerPrice.MinimumWidth = 6
        Me.appetizerPrice.Name = "appetizerPrice"
        Me.appetizerPrice.ReadOnly = True
        Me.appetizerPrice.Width = 125
        '
        'TypeDataGridViewTextBoxColumn1
        '
        Me.TypeDataGridViewTextBoxColumn1.DataPropertyName = "Type"
        Me.TypeDataGridViewTextBoxColumn1.HeaderText = "Type"
        Me.TypeDataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.TypeDataGridViewTextBoxColumn1.Name = "TypeDataGridViewTextBoxColumn1"
        Me.TypeDataGridViewTextBoxColumn1.Visible = False
        Me.TypeDataGridViewTextBoxColumn1.Width = 125
        '
        'appetizerStatus
        '
        Me.appetizerStatus.DataPropertyName = "Status"
        Me.appetizerStatus.HeaderText = "Status"
        Me.appetizerStatus.MinimumWidth = 6
        Me.appetizerStatus.Name = "appetizerStatus"
        Me.appetizerStatus.Visible = False
        Me.appetizerStatus.Width = 125
        '
        'DiscountDataGridViewTextBoxColumn1
        '
        Me.DiscountDataGridViewTextBoxColumn1.DataPropertyName = "Discount"
        Me.DiscountDataGridViewTextBoxColumn1.HeaderText = "Discount"
        Me.DiscountDataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DiscountDataGridViewTextBoxColumn1.Name = "DiscountDataGridViewTextBoxColumn1"
        Me.DiscountDataGridViewTextBoxColumn1.Visible = False
        Me.DiscountDataGridViewTextBoxColumn1.Width = 125
        '
        'CreatedDateTimeDataGridViewTextBoxColumn1
        '
        Me.CreatedDateTimeDataGridViewTextBoxColumn1.DataPropertyName = "createdDateTime"
        Me.CreatedDateTimeDataGridViewTextBoxColumn1.HeaderText = "createdDateTime"
        Me.CreatedDateTimeDataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.CreatedDateTimeDataGridViewTextBoxColumn1.Name = "CreatedDateTimeDataGridViewTextBoxColumn1"
        Me.CreatedDateTimeDataGridViewTextBoxColumn1.Visible = False
        Me.CreatedDateTimeDataGridViewTextBoxColumn1.Width = 125
        '
        'appetizerQuantity
        '
        DataGridViewCellStyle6.Format = "N0"
        DataGridViewCellStyle6.NullValue = "1"
        Me.appetizerQuantity.DefaultCellStyle = DataGridViewCellStyle6
        Me.appetizerQuantity.HeaderText = "Quantity"
        Me.appetizerQuantity.MinimumWidth = 6
        Me.appetizerQuantity.Name = "appetizerQuantity"
        Me.appetizerQuantity.Width = 80
        '
        'appetizerAction
        '
        Me.appetizerAction.HeaderText = "Action"
        Me.appetizerAction.MinimumWidth = 6
        Me.appetizerAction.Name = "appetizerAction"
        Me.appetizerAction.Text = "Add"
        Me.appetizerAction.ToolTipText = "Add"
        Me.appetizerAction.UseColumnTextForButtonValue = True
        Me.appetizerAction.Width = 125
        '
        'appetizerBindingSource
        '
        Me.appetizerBindingSource.AllowNew = True
        Me.appetizerBindingSource.DataMember = "Menus"
        Me.appetizerBindingSource.DataSource = Me.MenusDataSet
        Me.appetizerBindingSource.Filter = "Type='Appetizer'  And Status='Available'"
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.White
        Me.TabPage3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPage3.Controls.Add(Me.dessertTable)
        Me.TabPage3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.TabPage3.ForeColor = System.Drawing.Color.Black
        Me.TabPage3.Location = New System.Drawing.Point(4, 34)
        Me.TabPage3.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.TabPage3.Size = New System.Drawing.Size(465, 491)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Dessert"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'dessertTable
        '
        Me.dessertTable.AllowUserToAddRows = False
        Me.dessertTable.AllowUserToDeleteRows = False
        Me.dessertTable.AutoGenerateColumns = False
        Me.dessertTable.BackgroundColor = System.Drawing.Color.White
        Me.dessertTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dessertTable.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dessertName, Me.dessertID, Me.MenuNumberDataGridViewTextBoxColumn2, Me.DetailsDataGridViewTextBoxColumn2, Me.dessertPrice, Me.TypeDataGridViewTextBoxColumn2, Me.dessertStatus, Me.DiscountDataGridViewTextBoxColumn2, Me.CreatedDateTimeDataGridViewTextBoxColumn2, Me.dessertQuantity, Me.dessertAction})
        Me.dessertTable.DataSource = Me.dessertBindingSource
        Me.dessertTable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dessertTable.Location = New System.Drawing.Point(4, 6)
        Me.dessertTable.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.dessertTable.Name = "dessertTable"
        Me.dessertTable.RowHeadersVisible = False
        Me.dessertTable.RowHeadersWidth = 250
        Me.dessertTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dessertTable.RowTemplate.Height = 24
        Me.dessertTable.Size = New System.Drawing.Size(453, 475)
        Me.dessertTable.TabIndex = 10
        Me.dessertTable.Tag = "menusTable"
        '
        'dessertName
        '
        Me.dessertName.DataPropertyName = "Name"
        Me.dessertName.HeaderText = "Name"
        Me.dessertName.MinimumWidth = 6
        Me.dessertName.Name = "dessertName"
        Me.dessertName.ReadOnly = True
        Me.dessertName.Width = 125
        '
        'dessertID
        '
        Me.dessertID.DataPropertyName = "ID"
        Me.dessertID.HeaderText = "ID"
        Me.dessertID.MinimumWidth = 6
        Me.dessertID.Name = "dessertID"
        Me.dessertID.Visible = False
        Me.dessertID.Width = 125
        '
        'MenuNumberDataGridViewTextBoxColumn2
        '
        Me.MenuNumberDataGridViewTextBoxColumn2.DataPropertyName = "MenuNumber"
        Me.MenuNumberDataGridViewTextBoxColumn2.HeaderText = "MenuNumber"
        Me.MenuNumberDataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.MenuNumberDataGridViewTextBoxColumn2.Name = "MenuNumberDataGridViewTextBoxColumn2"
        Me.MenuNumberDataGridViewTextBoxColumn2.Visible = False
        Me.MenuNumberDataGridViewTextBoxColumn2.Width = 125
        '
        'DetailsDataGridViewTextBoxColumn2
        '
        Me.DetailsDataGridViewTextBoxColumn2.DataPropertyName = "Details"
        Me.DetailsDataGridViewTextBoxColumn2.HeaderText = "Details"
        Me.DetailsDataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DetailsDataGridViewTextBoxColumn2.Name = "DetailsDataGridViewTextBoxColumn2"
        Me.DetailsDataGridViewTextBoxColumn2.Visible = False
        Me.DetailsDataGridViewTextBoxColumn2.Width = 125
        '
        'dessertPrice
        '
        Me.dessertPrice.DataPropertyName = "Price"
        Me.dessertPrice.HeaderText = "Price"
        Me.dessertPrice.MinimumWidth = 6
        Me.dessertPrice.Name = "dessertPrice"
        Me.dessertPrice.ReadOnly = True
        Me.dessertPrice.Width = 125
        '
        'TypeDataGridViewTextBoxColumn2
        '
        Me.TypeDataGridViewTextBoxColumn2.DataPropertyName = "Type"
        Me.TypeDataGridViewTextBoxColumn2.HeaderText = "Type"
        Me.TypeDataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.TypeDataGridViewTextBoxColumn2.Name = "TypeDataGridViewTextBoxColumn2"
        Me.TypeDataGridViewTextBoxColumn2.Visible = False
        Me.TypeDataGridViewTextBoxColumn2.Width = 125
        '
        'dessertStatus
        '
        Me.dessertStatus.DataPropertyName = "Status"
        Me.dessertStatus.HeaderText = "Status"
        Me.dessertStatus.MinimumWidth = 6
        Me.dessertStatus.Name = "dessertStatus"
        Me.dessertStatus.Visible = False
        Me.dessertStatus.Width = 125
        '
        'DiscountDataGridViewTextBoxColumn2
        '
        Me.DiscountDataGridViewTextBoxColumn2.DataPropertyName = "Discount"
        Me.DiscountDataGridViewTextBoxColumn2.HeaderText = "Discount"
        Me.DiscountDataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DiscountDataGridViewTextBoxColumn2.Name = "DiscountDataGridViewTextBoxColumn2"
        Me.DiscountDataGridViewTextBoxColumn2.Visible = False
        Me.DiscountDataGridViewTextBoxColumn2.Width = 125
        '
        'CreatedDateTimeDataGridViewTextBoxColumn2
        '
        Me.CreatedDateTimeDataGridViewTextBoxColumn2.DataPropertyName = "createdDateTime"
        Me.CreatedDateTimeDataGridViewTextBoxColumn2.HeaderText = "createdDateTime"
        Me.CreatedDateTimeDataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.CreatedDateTimeDataGridViewTextBoxColumn2.Name = "CreatedDateTimeDataGridViewTextBoxColumn2"
        Me.CreatedDateTimeDataGridViewTextBoxColumn2.Visible = False
        Me.CreatedDateTimeDataGridViewTextBoxColumn2.Width = 125
        '
        'dessertQuantity
        '
        DataGridViewCellStyle7.Format = "N0"
        DataGridViewCellStyle7.NullValue = "1"
        Me.dessertQuantity.DefaultCellStyle = DataGridViewCellStyle7
        Me.dessertQuantity.HeaderText = "Quantity"
        Me.dessertQuantity.MinimumWidth = 6
        Me.dessertQuantity.Name = "dessertQuantity"
        Me.dessertQuantity.Width = 80
        '
        'dessertAction
        '
        Me.dessertAction.HeaderText = "Action"
        Me.dessertAction.MinimumWidth = 6
        Me.dessertAction.Name = "dessertAction"
        Me.dessertAction.Text = "Add"
        Me.dessertAction.ToolTipText = "Add"
        Me.dessertAction.UseColumnTextForButtonValue = True
        Me.dessertAction.Width = 125
        '
        'dessertBindingSource
        '
        Me.dessertBindingSource.DataMember = "Menus"
        Me.dessertBindingSource.DataSource = Me.MenusDataSet
        Me.dessertBindingSource.Filter = "Type='Dessert' And Status='Available'"
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.Color.White
        Me.TabPage4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPage4.Controls.Add(Me.drinksTable)
        Me.TabPage4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.TabPage4.ForeColor = System.Drawing.Color.Black
        Me.TabPage4.Location = New System.Drawing.Point(4, 34)
        Me.TabPage4.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.TabPage4.Size = New System.Drawing.Size(465, 491)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Drinks"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'drinksTable
        '
        Me.drinksTable.AllowUserToAddRows = False
        Me.drinksTable.AllowUserToDeleteRows = False
        Me.drinksTable.AutoGenerateColumns = False
        Me.drinksTable.BackgroundColor = System.Drawing.Color.White
        Me.drinksTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.drinksTable.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.drinksName, Me.drinksID, Me.MenuNumberDataGridViewTextBoxColumn3, Me.DetailsDataGridViewTextBoxColumn3, Me.drinksPrice, Me.TypeDataGridViewTextBoxColumn3, Me.drinksStatus, Me.DiscountDataGridViewTextBoxColumn3, Me.CreatedDateTimeDataGridViewTextBoxColumn3, Me.drinksQuantity, Me.drinksAction})
        Me.drinksTable.DataSource = Me.drinksBindingSource
        Me.drinksTable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.drinksTable.Location = New System.Drawing.Point(4, 6)
        Me.drinksTable.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.drinksTable.Name = "drinksTable"
        Me.drinksTable.RowHeadersVisible = False
        Me.drinksTable.RowHeadersWidth = 250
        Me.drinksTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.drinksTable.RowTemplate.Height = 24
        Me.drinksTable.Size = New System.Drawing.Size(453, 475)
        Me.drinksTable.TabIndex = 11
        Me.drinksTable.Tag = "menusTable"
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
        'drinksID
        '
        Me.drinksID.DataPropertyName = "ID"
        Me.drinksID.HeaderText = "ID"
        Me.drinksID.MinimumWidth = 6
        Me.drinksID.Name = "drinksID"
        Me.drinksID.Visible = False
        Me.drinksID.Width = 125
        '
        'MenuNumberDataGridViewTextBoxColumn3
        '
        Me.MenuNumberDataGridViewTextBoxColumn3.DataPropertyName = "MenuNumber"
        Me.MenuNumberDataGridViewTextBoxColumn3.HeaderText = "MenuNumber"
        Me.MenuNumberDataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.MenuNumberDataGridViewTextBoxColumn3.Name = "MenuNumberDataGridViewTextBoxColumn3"
        Me.MenuNumberDataGridViewTextBoxColumn3.Visible = False
        Me.MenuNumberDataGridViewTextBoxColumn3.Width = 125
        '
        'DetailsDataGridViewTextBoxColumn3
        '
        Me.DetailsDataGridViewTextBoxColumn3.DataPropertyName = "Details"
        Me.DetailsDataGridViewTextBoxColumn3.HeaderText = "Details"
        Me.DetailsDataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DetailsDataGridViewTextBoxColumn3.Name = "DetailsDataGridViewTextBoxColumn3"
        Me.DetailsDataGridViewTextBoxColumn3.Visible = False
        Me.DetailsDataGridViewTextBoxColumn3.Width = 125
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
        'TypeDataGridViewTextBoxColumn3
        '
        Me.TypeDataGridViewTextBoxColumn3.DataPropertyName = "Type"
        Me.TypeDataGridViewTextBoxColumn3.HeaderText = "Type"
        Me.TypeDataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.TypeDataGridViewTextBoxColumn3.Name = "TypeDataGridViewTextBoxColumn3"
        Me.TypeDataGridViewTextBoxColumn3.Visible = False
        Me.TypeDataGridViewTextBoxColumn3.Width = 125
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
        'DiscountDataGridViewTextBoxColumn3
        '
        Me.DiscountDataGridViewTextBoxColumn3.DataPropertyName = "Discount"
        Me.DiscountDataGridViewTextBoxColumn3.HeaderText = "Discount"
        Me.DiscountDataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DiscountDataGridViewTextBoxColumn3.Name = "DiscountDataGridViewTextBoxColumn3"
        Me.DiscountDataGridViewTextBoxColumn3.Visible = False
        Me.DiscountDataGridViewTextBoxColumn3.Width = 125
        '
        'CreatedDateTimeDataGridViewTextBoxColumn3
        '
        Me.CreatedDateTimeDataGridViewTextBoxColumn3.DataPropertyName = "createdDateTime"
        Me.CreatedDateTimeDataGridViewTextBoxColumn3.HeaderText = "createdDateTime"
        Me.CreatedDateTimeDataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.CreatedDateTimeDataGridViewTextBoxColumn3.Name = "CreatedDateTimeDataGridViewTextBoxColumn3"
        Me.CreatedDateTimeDataGridViewTextBoxColumn3.Visible = False
        Me.CreatedDateTimeDataGridViewTextBoxColumn3.Width = 125
        '
        'drinksQuantity
        '
        DataGridViewCellStyle8.Format = "N0"
        DataGridViewCellStyle8.NullValue = "1"
        Me.drinksQuantity.DefaultCellStyle = DataGridViewCellStyle8
        Me.drinksQuantity.HeaderText = "Quantity"
        Me.drinksQuantity.MinimumWidth = 6
        Me.drinksQuantity.Name = "drinksQuantity"
        Me.drinksQuantity.Width = 80
        '
        'drinksAction
        '
        Me.drinksAction.HeaderText = "Action"
        Me.drinksAction.MinimumWidth = 6
        Me.drinksAction.Name = "drinksAction"
        Me.drinksAction.Text = "Add"
        Me.drinksAction.ToolTipText = "Add"
        Me.drinksAction.UseColumnTextForButtonValue = True
        Me.drinksAction.Width = 125
        '
        'drinksBindingSource
        '
        Me.drinksBindingSource.DataMember = "Menus"
        Me.drinksBindingSource.DataSource = Me.MenusDataSet
        Me.drinksBindingSource.Filter = "Type='Drinks' And Status='Available'"
        '
        'MenusTableAdapter
        '
        Me.MenusTableAdapter.ClearBeforeFill = True
        '
        'OrdersTableAdapter
        '
        Me.OrdersTableAdapter.ClearBeforeFill = True
        '
        'OrdersAdditional
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1600, 900)
        Me.Controls.Add(Me.menuTab)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnPrintBill)
        Me.Controls.Add(Me.btnRemoveLastItem)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MaximumSize = New System.Drawing.Size(1600, 900)
        Me.MinimumSize = New System.Drawing.Size(1198, 730)
        Me.Name = "OrdersAdditional"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "OrdersAdditional"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.OrdersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrdersDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.menuTab.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.mainDishTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mainDishBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MenusDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.appetizerTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.appetizerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        CType(Me.dessertTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dessertBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        CType(Me.drinksTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.drinksBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnBack As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents listofids As ListBox
    Friend WithEvents Label3 As Label
    Friend WithEvents listofquantity As ListBox
    Friend WithEvents lblListofPrice As Label
    Friend WithEvents lblSelectedMenus As Label
    Friend WithEvents listofprices As ListBox
    Friend WithEvents totalPrice As TextBox
    Friend WithEvents TotalPriceLabel As Label
    Friend WithEvents initialPrice As TextBox
    Friend WithEvents listofmenus As ListBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents menuTab As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents mainDishTable As DataGridView
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents appetizerTable As DataGridView
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents dessertTable As DataGridView
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents drinksTable As DataGridView
    Friend WithEvents cbxOrderNumber As ComboBox
    Friend WithEvents btnRemoveLastItem As Button
    Friend WithEvents btnPrintBill As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents tbxOrderType As TextBox
    Friend WithEvents tbxTableNumber As TextBox
    Friend WithEvents MenusDataSet As menusDataSet
    Friend WithEvents mainDishBindingSource As BindingSource
    Friend WithEvents MenusTableAdapter As menusDataSetTableAdapters.MenusTableAdapter
    Friend WithEvents appetizerBindingSource As BindingSource
    Friend WithEvents dessertBindingSource As BindingSource
    Friend WithEvents drinksBindingSource As BindingSource
    Friend WithEvents OrdersDataSet As ordersDataSet
    Friend WithEvents OrdersBindingSource As BindingSource
    Friend WithEvents OrdersTableAdapter As ordersDataSetTableAdapters.OrdersTableAdapter
    Friend WithEvents mainDishID As DataGridViewTextBoxColumn
    Friend WithEvents MenuNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents mainDishName As DataGridViewTextBoxColumn
    Friend WithEvents DetailsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents mainDishPrice As DataGridViewTextBoxColumn
    Friend WithEvents TypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents mainDishStatus As DataGridViewTextBoxColumn
    Friend WithEvents DiscountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CreatedDateTimeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents mainDishQuantity As DataGridViewTextBoxColumn
    Friend WithEvents mainDishAction As DataGridViewButtonColumn
    Friend WithEvents appetizerName As DataGridViewTextBoxColumn
    Friend WithEvents appetizerID As DataGridViewTextBoxColumn
    Friend WithEvents MenuNumberDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DetailsDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents appetizerPrice As DataGridViewTextBoxColumn
    Friend WithEvents TypeDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents appetizerStatus As DataGridViewTextBoxColumn
    Friend WithEvents DiscountDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents CreatedDateTimeDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents appetizerQuantity As DataGridViewTextBoxColumn
    Friend WithEvents appetizerAction As DataGridViewButtonColumn
    Friend WithEvents dessertName As DataGridViewTextBoxColumn
    Friend WithEvents dessertID As DataGridViewTextBoxColumn
    Friend WithEvents MenuNumberDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DetailsDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents dessertPrice As DataGridViewTextBoxColumn
    Friend WithEvents TypeDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents dessertStatus As DataGridViewTextBoxColumn
    Friend WithEvents DiscountDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents CreatedDateTimeDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents dessertQuantity As DataGridViewTextBoxColumn
    Friend WithEvents dessertAction As DataGridViewButtonColumn
    Friend WithEvents drinksName As DataGridViewTextBoxColumn
    Friend WithEvents drinksID As DataGridViewTextBoxColumn
    Friend WithEvents MenuNumberDataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DetailsDataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents drinksPrice As DataGridViewTextBoxColumn
    Friend WithEvents TypeDataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents drinksStatus As DataGridViewTextBoxColumn
    Friend WithEvents DiscountDataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents CreatedDateTimeDataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents drinksQuantity As DataGridViewTextBoxColumn
    Friend WithEvents drinksAction As DataGridViewButtonColumn
End Class
