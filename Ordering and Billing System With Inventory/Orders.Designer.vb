<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class OrdersForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OrdersForm))
        Me.mainDishBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NamwahDataSet = New Ordering_and_Billing_System_With_Inventory.namwahDataSet()
        Me.appetizerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dessertBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.drinksBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
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
        Me.MenusTableAdapter = New Ordering_and_Billing_System_With_Inventory.namwahDataSetTableAdapters.MenusTableAdapter()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.tableNumber = New System.Windows.Forms.ComboBox()
        Me.TableManagementDSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableManagementDS = New Ordering_and_Billing_System_With_Inventory.TableManagementDS()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnRemoveLastItem = New System.Windows.Forms.Button()
        Me.btnClearItem = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.orderType = New System.Windows.Forms.ComboBox()
        Me.discounted = New System.Windows.Forms.ComboBox()
        Me.NamwahDataSet2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NamwahDataSet2 = New Ordering_and_Billing_System_With_Inventory.namwahDataSet2()
        Me.orderNumber = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.menuTab = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.mainDishTable = New System.Windows.Forms.DataGridView()
        Me.mainDishName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mainDishPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mainDishStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mainDishQuantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mainDishAction = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.mainDishID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mainDishMenuNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mainDishDetails = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mainDishType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mainDishDiscount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.appetizerTable = New System.Windows.Forms.DataGridView()
        Me.appetizerName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.appetizerPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.appetizerStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.appetizerQuantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.appetizerAction = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.appetizerID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.appetizerMenuNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.appetizerDetails = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.appetizerType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.appetizerDiscount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.dessertTable = New System.Windows.Forms.DataGridView()
        Me.dessertName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dessertPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dessertStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dessertQuantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dessertAction = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.dessertID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dessertMenuNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dessertDetails = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dessertType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dessertDiscount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.drinksTable = New System.Windows.Forms.DataGridView()
        Me.drinksName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.drinksPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.drinksStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.drinksQuantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.drinksAction = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.DrinksID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.drinksMenuNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.drinksDetails = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.drinksType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.drinksDiscount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TableManagementTableAdapter = New Ordering_and_Billing_System_With_Inventory.TableManagementDSTableAdapters.TableManagementTableAdapter()
        Me.DiscountManagementTableAdapter = New Ordering_and_Billing_System_With_Inventory.namwahDataSet2TableAdapters.DiscountManagementTableAdapter()
        CType(Me.mainDishBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NamwahDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.appetizerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dessertBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.drinksBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.TableManagementDSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TableManagementDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NamwahDataSet2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NamwahDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.menuTab.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.mainDishTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.appetizerTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.dessertTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        CType(Me.drinksTable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mainDishBindingSource
        '
        Me.mainDishBindingSource.DataMember = "Menus"
        Me.mainDishBindingSource.DataSource = Me.NamwahDataSet
        Me.mainDishBindingSource.Filter = "Type='Main Dish' AND Status='Available'"
        '
        'NamwahDataSet
        '
        Me.NamwahDataSet.DataSetName = "namwahDataSet"
        Me.NamwahDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'appetizerBindingSource
        '
        Me.appetizerBindingSource.DataMember = "Menus"
        Me.appetizerBindingSource.DataSource = Me.NamwahDataSet
        Me.appetizerBindingSource.Filter = "Type='Appetizer' AND Status='Available'"
        '
        'dessertBindingSource
        '
        Me.dessertBindingSource.DataMember = "Menus"
        Me.dessertBindingSource.DataSource = Me.NamwahDataSet
        Me.dessertBindingSource.Filter = "Type='Dessert' AND Status='Available'"
        '
        'drinksBindingSource
        '
        Me.drinksBindingSource.DataMember = "Menus"
        Me.drinksBindingSource.DataSource = Me.NamwahDataSet
        Me.drinksBindingSource.Filter = "Type='Drinks' AND Status='Available'"
        '
        'Panel1
        '
        Me.Panel1.AutoSize = True
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.Label1)
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
        Me.Panel1.Location = New System.Drawing.Point(695, 133)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(736, 632)
        Me.Panel1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(31, 525)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 22)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Initial Price:"
        '
        'listofids
        '
        Me.listofids.FormattingEnabled = True
        Me.listofids.ItemHeight = 26
        Me.listofids.Location = New System.Drawing.Point(14, 8)
        Me.listofids.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.listofids.Name = "listofids"
        Me.listofids.Size = New System.Drawing.Size(102, 4)
        Me.listofids.TabIndex = 15
        Me.listofids.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(399, 40)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
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
        Me.listofquantity.Location = New System.Drawing.Point(404, 84)
        Me.listofquantity.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.listofquantity.Name = "listofquantity"
        Me.listofquantity.Size = New System.Drawing.Size(91, 382)
        Me.listofquantity.TabIndex = 13
        '
        'lblListofPrice
        '
        Me.lblListofPrice.AutoSize = True
        Me.lblListofPrice.BackColor = System.Drawing.Color.Transparent
        Me.lblListofPrice.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblListofPrice.ForeColor = System.Drawing.Color.Black
        Me.lblListofPrice.Location = New System.Drawing.Point(582, 40)
        Me.lblListofPrice.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
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
        Me.lblSelectedMenus.ForeColor = System.Drawing.Color.Black
        Me.lblSelectedMenus.Location = New System.Drawing.Point(5, 40)
        Me.lblSelectedMenus.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
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
        Me.listofprices.Location = New System.Drawing.Point(539, 84)
        Me.listofprices.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.listofprices.Name = "listofprices"
        Me.listofprices.Size = New System.Drawing.Size(166, 382)
        Me.listofprices.TabIndex = 10
        '
        'totalPrice
        '
        Me.totalPrice.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.totalPrice.Font = New System.Drawing.Font("Segoe UI Light", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalPrice.Location = New System.Drawing.Point(256, 583)
        Me.totalPrice.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
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
        Me.TotalPriceLabel.ForeColor = System.Drawing.Color.Black
        Me.TotalPriceLabel.Location = New System.Drawing.Point(31, 577)
        Me.TotalPriceLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.TotalPriceLabel.Name = "TotalPriceLabel"
        Me.TotalPriceLabel.Size = New System.Drawing.Size(127, 42)
        Me.TotalPriceLabel.TabIndex = 8
        Me.TotalPriceLabel.Text = "Total Price:"
        Me.TotalPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'initialPrice
        '
        Me.initialPrice.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.initialPrice.Font = New System.Drawing.Font("Segoe UI Light", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.initialPrice.Location = New System.Drawing.Point(256, 520)
        Me.initialPrice.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
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
        Me.listofmenus.Location = New System.Drawing.Point(5, 88)
        Me.listofmenus.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.listofmenus.Name = "listofmenus"
        Me.listofmenus.Size = New System.Drawing.Size(363, 382)
        Me.listofmenus.TabIndex = 0
        '
        'MenusTableAdapter
        '
        Me.MenusTableAdapter.ClearBeforeFill = True
        '
        'Panel2
        '
        Me.Panel2.AutoScroll = True
        Me.Panel2.AutoSize = True
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.tableNumber)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.btnRemoveLastItem)
        Me.Panel2.Controls.Add(Me.btnClearItem)
        Me.Panel2.Controls.Add(Me.btnAdd)
        Me.Panel2.Controls.Add(Me.orderType)
        Me.Panel2.Controls.Add(Me.discounted)
        Me.Panel2.Controls.Add(Me.orderNumber)
        Me.Panel2.Location = New System.Drawing.Point(30, 777)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1401, 146)
        Me.Panel2.TabIndex = 28
        '
        'tableNumber
        '
        Me.tableNumber.BackColor = System.Drawing.Color.White
        Me.tableNumber.DataSource = Me.TableManagementDSBindingSource
        Me.tableNumber.DisplayMember = "TableNum"
        Me.tableNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.tableNumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tableNumber.Font = New System.Drawing.Font("Segoe UI Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tableNumber.FormattingEnabled = True
        Me.tableNumber.ItemHeight = 32
        Me.tableNumber.Location = New System.Drawing.Point(553, 6)
        Me.tableNumber.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.tableNumber.Name = "tableNumber"
        Me.tableNumber.Size = New System.Drawing.Size(132, 40)
        Me.tableNumber.TabIndex = 44
        Me.tableNumber.Tag = "Type"
        Me.tableNumber.ValueMember = "ID"
        '
        'TableManagementDSBindingSource
        '
        Me.TableManagementDSBindingSource.DataMember = "TableManagement"
        Me.TableManagementDSBindingSource.DataSource = Me.TableManagementDS
        Me.TableManagementDSBindingSource.Filter = "Status='Available'"
        Me.TableManagementDSBindingSource.Sort = "TableNum"
        '
        'TableManagementDS
        '
        Me.TableManagementDS.DataSetName = "TableManagementDS"
        Me.TableManagementDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(389, 71)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(110, 22)
        Me.Label11.TabIndex = 43
        Me.Label11.Text = "Order Type:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(360, 20)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(131, 22)
        Me.Label10.TabIndex = 42
        Me.Label10.Text = "Table Number:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(54, 69)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(106, 22)
        Me.Label9.TabIndex = 41
        Me.Label9.Text = "Discounted:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(16, 17)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(136, 22)
        Me.Label8.TabIndex = 40
        Me.Label8.Text = "Order Number:"
        '
        'btnRemoveLastItem
        '
        Me.btnRemoveLastItem.BackColor = System.Drawing.Color.Aqua
        Me.btnRemoveLastItem.BackgroundImage = Global.Ordering_and_Billing_System_With_Inventory.My.Resources.Resources.delete_document_32px
        Me.btnRemoveLastItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnRemoveLastItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemoveLastItem.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemoveLastItem.ForeColor = System.Drawing.Color.Black
        Me.btnRemoveLastItem.Location = New System.Drawing.Point(1170, 6)
        Me.btnRemoveLastItem.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.btnRemoveLastItem.Name = "btnRemoveLastItem"
        Me.btnRemoveLastItem.Size = New System.Drawing.Size(183, 59)
        Me.btnRemoveLastItem.TabIndex = 39
        Me.btnRemoveLastItem.Text = "Remove Selected Item"
        Me.btnRemoveLastItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnRemoveLastItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnRemoveLastItem.UseVisualStyleBackColor = False
        '
        'btnClearItem
        '
        Me.btnClearItem.BackColor = System.Drawing.Color.Aqua
        Me.btnClearItem.BackgroundImage = Global.Ordering_and_Billing_System_With_Inventory.My.Resources.Resources.clear_symbol_32px
        Me.btnClearItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnClearItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClearItem.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearItem.ForeColor = System.Drawing.Color.Black
        Me.btnClearItem.Location = New System.Drawing.Point(752, 6)
        Me.btnClearItem.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.btnClearItem.Name = "btnClearItem"
        Me.btnClearItem.Size = New System.Drawing.Size(183, 59)
        Me.btnClearItem.TabIndex = 37
        Me.btnClearItem.Text = "Clear Item"
        Me.btnClearItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnClearItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnClearItem.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.Aqua
        Me.btnAdd.BackgroundImage = Global.Ordering_and_Billing_System_With_Inventory.My.Resources.Resources.submit_for_approval_32px
        Me.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.Black
        Me.btnAdd.Location = New System.Drawing.Point(960, 6)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(183, 59)
        Me.btnAdd.TabIndex = 36
        Me.btnAdd.Text = "Submit"
        Me.btnAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'orderType
        '
        Me.orderType.BackColor = System.Drawing.Color.White
        Me.orderType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.orderType.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.orderType.Font = New System.Drawing.Font("Segoe UI Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.orderType.FormattingEnabled = True
        Me.orderType.ItemHeight = 32
        Me.orderType.Items.AddRange(New Object() {"Dine-In", "Take-Out"})
        Me.orderType.Location = New System.Drawing.Point(553, 61)
        Me.orderType.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.orderType.Name = "orderType"
        Me.orderType.Size = New System.Drawing.Size(132, 40)
        Me.orderType.TabIndex = 35
        Me.orderType.Tag = "Type"
        '
        'discounted
        '
        Me.discounted.BackColor = System.Drawing.Color.White
        Me.discounted.DataSource = Me.NamwahDataSet2BindingSource
        Me.discounted.DisplayMember = "Name"
        Me.discounted.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.discounted.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.discounted.Font = New System.Drawing.Font("Segoe UI Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.discounted.ItemHeight = 32
        Me.discounted.Location = New System.Drawing.Point(210, 58)
        Me.discounted.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.discounted.Name = "discounted"
        Me.discounted.Size = New System.Drawing.Size(127, 40)
        Me.discounted.TabIndex = 33
        Me.discounted.Tag = "Discounted"
        '
        'NamwahDataSet2BindingSource
        '
        Me.NamwahDataSet2BindingSource.DataMember = "DiscountManagement"
        Me.NamwahDataSet2BindingSource.DataSource = Me.NamwahDataSet2
        Me.NamwahDataSet2BindingSource.Sort = "Name"
        '
        'NamwahDataSet2
        '
        Me.NamwahDataSet2.DataSetName = "namwahDataSet2"
        Me.NamwahDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'orderNumber
        '
        Me.orderNumber.BackColor = System.Drawing.Color.White
        Me.orderNumber.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.orderNumber.Cursor = System.Windows.Forms.Cursors.Default
        Me.orderNumber.Font = New System.Drawing.Font("Segoe UI Light", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.orderNumber.Location = New System.Drawing.Point(210, 9)
        Me.orderNumber.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.orderNumber.Name = "orderNumber"
        Me.orderNumber.ReadOnly = True
        Me.orderNumber.Size = New System.Drawing.Size(127, 32)
        Me.orderNumber.TabIndex = 29
        Me.orderNumber.Tag = "Order Number"
        '
        'Panel3
        '
        Me.Panel3.AutoScroll = True
        Me.Panel3.AutoSize = True
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel3.Location = New System.Drawing.Point(30, 133)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(613, 642)
        Me.Panel3.TabIndex = 29
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 23.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(200, 10)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(189, 36)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "MENU LIST"
        '
        'Panel4
        '
        Me.Panel4.AutoScroll = True
        Me.Panel4.AutoSize = True
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel4.Controls.Add(Me.menuTab)
        Me.Panel4.Location = New System.Drawing.Point(22, 86)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(576, 544)
        Me.Panel4.TabIndex = 30
        '
        'menuTab
        '
        Me.menuTab.Controls.Add(Me.TabPage1)
        Me.menuTab.Controls.Add(Me.TabPage2)
        Me.menuTab.Controls.Add(Me.TabPage3)
        Me.menuTab.Controls.Add(Me.TabPage4)
        Me.menuTab.Font = New System.Drawing.Font("Segoe UI Light", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menuTab.Location = New System.Drawing.Point(5, 7)
        Me.menuTab.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.menuTab.Name = "menuTab"
        Me.menuTab.SelectedIndex = 0
        Me.menuTab.Size = New System.Drawing.Size(560, 526)
        Me.menuTab.TabIndex = 1
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
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.TabPage1.Size = New System.Drawing.Size(552, 488)
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
        Me.mainDishTable.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.mainDishName, Me.mainDishPrice, Me.mainDishStatus, Me.mainDishQuantity, Me.mainDishAction, Me.mainDishID, Me.mainDishMenuNumber, Me.mainDishDetails, Me.mainDishType, Me.mainDishDiscount})
        Me.mainDishTable.DataSource = Me.mainDishBindingSource
        Me.mainDishTable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mainDishTable.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke
        Me.mainDishTable.Location = New System.Drawing.Point(5, 7)
        Me.mainDishTable.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.mainDishTable.Name = "mainDishTable"
        Me.mainDishTable.RowHeadersVisible = False
        Me.mainDishTable.RowHeadersWidth = 250
        Me.mainDishTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.mainDishTable.RowTemplate.Height = 24
        Me.mainDishTable.Size = New System.Drawing.Size(538, 470)
        Me.mainDishTable.TabIndex = 3
        Me.mainDishTable.Tag = "menusTable"
        '
        'mainDishName
        '
        Me.mainDishName.DataPropertyName = "Name"
        DataGridViewCellStyle1.Format = "N0"
        DataGridViewCellStyle1.NullValue = "1"
        Me.mainDishName.DefaultCellStyle = DataGridViewCellStyle1
        Me.mainDishName.HeaderText = "Name"
        Me.mainDishName.MinimumWidth = 6
        Me.mainDishName.Name = "mainDishName"
        Me.mainDishName.ReadOnly = True
        Me.mainDishName.Width = 125
        '
        'mainDishPrice
        '
        Me.mainDishPrice.DataPropertyName = "Price"
        Me.mainDishPrice.HeaderText = "Price"
        Me.mainDishPrice.MinimumWidth = 6
        Me.mainDishPrice.Name = "mainDishPrice"
        Me.mainDishPrice.ReadOnly = True
        Me.mainDishPrice.Width = 80
        '
        'mainDishStatus
        '
        Me.mainDishStatus.DataPropertyName = "Status"
        Me.mainDishStatus.HeaderText = "Status"
        Me.mainDishStatus.MinimumWidth = 6
        Me.mainDishStatus.Name = "mainDishStatus"
        Me.mainDishStatus.ReadOnly = True
        Me.mainDishStatus.Width = 125
        '
        'mainDishQuantity
        '
        DataGridViewCellStyle2.Format = "N0"
        DataGridViewCellStyle2.NullValue = "1"
        Me.mainDishQuantity.DefaultCellStyle = DataGridViewCellStyle2
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
        'mainDishID
        '
        Me.mainDishID.DataPropertyName = "ID"
        Me.mainDishID.HeaderText = "ID"
        Me.mainDishID.MinimumWidth = 6
        Me.mainDishID.Name = "mainDishID"
        Me.mainDishID.Visible = False
        Me.mainDishID.Width = 125
        '
        'mainDishMenuNumber
        '
        Me.mainDishMenuNumber.DataPropertyName = "MenuNumber"
        Me.mainDishMenuNumber.HeaderText = "MenuNumber"
        Me.mainDishMenuNumber.MinimumWidth = 6
        Me.mainDishMenuNumber.Name = "mainDishMenuNumber"
        Me.mainDishMenuNumber.Visible = False
        Me.mainDishMenuNumber.Width = 125
        '
        'mainDishDetails
        '
        Me.mainDishDetails.DataPropertyName = "Details"
        Me.mainDishDetails.HeaderText = "Details"
        Me.mainDishDetails.MinimumWidth = 6
        Me.mainDishDetails.Name = "mainDishDetails"
        Me.mainDishDetails.Visible = False
        Me.mainDishDetails.Width = 125
        '
        'mainDishType
        '
        Me.mainDishType.DataPropertyName = "Type"
        Me.mainDishType.HeaderText = "Type"
        Me.mainDishType.MinimumWidth = 6
        Me.mainDishType.Name = "mainDishType"
        Me.mainDishType.Visible = False
        Me.mainDishType.Width = 125
        '
        'mainDishDiscount
        '
        Me.mainDishDiscount.DataPropertyName = "Discount"
        Me.mainDishDiscount.HeaderText = "Discount"
        Me.mainDishDiscount.MinimumWidth = 6
        Me.mainDishDiscount.Name = "mainDishDiscount"
        Me.mainDishDiscount.Visible = False
        Me.mainDishDiscount.Width = 125
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.White
        Me.TabPage2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPage2.Controls.Add(Me.appetizerTable)
        Me.TabPage2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.TabPage2.ForeColor = System.Drawing.Color.Black
        Me.TabPage2.Location = New System.Drawing.Point(4, 34)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.TabPage2.Size = New System.Drawing.Size(552, 488)
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
        Me.appetizerTable.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.appetizerName, Me.appetizerPrice, Me.appetizerStatus, Me.appetizerQuantity, Me.appetizerAction, Me.appetizerID, Me.appetizerMenuNumber, Me.appetizerDetails, Me.appetizerType, Me.appetizerDiscount})
        Me.appetizerTable.DataSource = Me.appetizerBindingSource
        Me.appetizerTable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.appetizerTable.Location = New System.Drawing.Point(5, 7)
        Me.appetizerTable.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.appetizerTable.Name = "appetizerTable"
        Me.appetizerTable.RowHeadersVisible = False
        Me.appetizerTable.RowHeadersWidth = 250
        Me.appetizerTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.appetizerTable.RowTemplate.Height = 24
        Me.appetizerTable.Size = New System.Drawing.Size(538, 470)
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
        'appetizerPrice
        '
        Me.appetizerPrice.DataPropertyName = "Price"
        Me.appetizerPrice.HeaderText = "Price"
        Me.appetizerPrice.MinimumWidth = 6
        Me.appetizerPrice.Name = "appetizerPrice"
        Me.appetizerPrice.ReadOnly = True
        Me.appetizerPrice.Width = 80
        '
        'appetizerStatus
        '
        Me.appetizerStatus.DataPropertyName = "Status"
        Me.appetizerStatus.HeaderText = "Status"
        Me.appetizerStatus.MinimumWidth = 6
        Me.appetizerStatus.Name = "appetizerStatus"
        Me.appetizerStatus.ReadOnly = True
        Me.appetizerStatus.Width = 125
        '
        'appetizerQuantity
        '
        DataGridViewCellStyle3.Format = "N0"
        DataGridViewCellStyle3.NullValue = "1"
        Me.appetizerQuantity.DefaultCellStyle = DataGridViewCellStyle3
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
        'appetizerID
        '
        Me.appetizerID.DataPropertyName = "ID"
        Me.appetizerID.HeaderText = "ID"
        Me.appetizerID.MinimumWidth = 6
        Me.appetizerID.Name = "appetizerID"
        Me.appetizerID.Visible = False
        Me.appetizerID.Width = 125
        '
        'appetizerMenuNumber
        '
        Me.appetizerMenuNumber.DataPropertyName = "MenuNumber"
        Me.appetizerMenuNumber.HeaderText = "MenuNumber"
        Me.appetizerMenuNumber.MinimumWidth = 6
        Me.appetizerMenuNumber.Name = "appetizerMenuNumber"
        Me.appetizerMenuNumber.Visible = False
        Me.appetizerMenuNumber.Width = 125
        '
        'appetizerDetails
        '
        Me.appetizerDetails.DataPropertyName = "Details"
        Me.appetizerDetails.HeaderText = "Details"
        Me.appetizerDetails.MinimumWidth = 6
        Me.appetizerDetails.Name = "appetizerDetails"
        Me.appetizerDetails.Visible = False
        Me.appetizerDetails.Width = 125
        '
        'appetizerType
        '
        Me.appetizerType.DataPropertyName = "Type"
        Me.appetizerType.HeaderText = "Type"
        Me.appetizerType.MinimumWidth = 6
        Me.appetizerType.Name = "appetizerType"
        Me.appetizerType.Visible = False
        Me.appetizerType.Width = 125
        '
        'appetizerDiscount
        '
        Me.appetizerDiscount.DataPropertyName = "Discount"
        Me.appetizerDiscount.HeaderText = "Discount"
        Me.appetizerDiscount.MinimumWidth = 6
        Me.appetizerDiscount.Name = "appetizerDiscount"
        Me.appetizerDiscount.Visible = False
        Me.appetizerDiscount.Width = 125
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.White
        Me.TabPage3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPage3.Controls.Add(Me.dessertTable)
        Me.TabPage3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.TabPage3.ForeColor = System.Drawing.Color.Black
        Me.TabPage3.Location = New System.Drawing.Point(4, 34)
        Me.TabPage3.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.TabPage3.Size = New System.Drawing.Size(552, 488)
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
        Me.dessertTable.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dessertName, Me.dessertPrice, Me.dessertStatus, Me.dessertQuantity, Me.dessertAction, Me.dessertID, Me.dessertMenuNumber, Me.dessertDetails, Me.dessertType, Me.dessertDiscount})
        Me.dessertTable.DataSource = Me.dessertBindingSource
        Me.dessertTable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dessertTable.Location = New System.Drawing.Point(5, 7)
        Me.dessertTable.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.dessertTable.Name = "dessertTable"
        Me.dessertTable.RowHeadersVisible = False
        Me.dessertTable.RowHeadersWidth = 250
        Me.dessertTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dessertTable.RowTemplate.Height = 24
        Me.dessertTable.Size = New System.Drawing.Size(538, 470)
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
        'dessertPrice
        '
        Me.dessertPrice.DataPropertyName = "Price"
        Me.dessertPrice.HeaderText = "Price"
        Me.dessertPrice.MinimumWidth = 6
        Me.dessertPrice.Name = "dessertPrice"
        Me.dessertPrice.ReadOnly = True
        Me.dessertPrice.Width = 80
        '
        'dessertStatus
        '
        Me.dessertStatus.DataPropertyName = "Status"
        Me.dessertStatus.HeaderText = "Status"
        Me.dessertStatus.MinimumWidth = 6
        Me.dessertStatus.Name = "dessertStatus"
        Me.dessertStatus.ReadOnly = True
        Me.dessertStatus.Width = 125
        '
        'dessertQuantity
        '
        DataGridViewCellStyle4.Format = "N0"
        DataGridViewCellStyle4.NullValue = "1"
        Me.dessertQuantity.DefaultCellStyle = DataGridViewCellStyle4
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
        'dessertID
        '
        Me.dessertID.DataPropertyName = "ID"
        Me.dessertID.HeaderText = "ID"
        Me.dessertID.MinimumWidth = 6
        Me.dessertID.Name = "dessertID"
        Me.dessertID.Visible = False
        Me.dessertID.Width = 125
        '
        'dessertMenuNumber
        '
        Me.dessertMenuNumber.DataPropertyName = "MenuNumber"
        Me.dessertMenuNumber.HeaderText = "MenuNumber"
        Me.dessertMenuNumber.MinimumWidth = 6
        Me.dessertMenuNumber.Name = "dessertMenuNumber"
        Me.dessertMenuNumber.Visible = False
        Me.dessertMenuNumber.Width = 125
        '
        'dessertDetails
        '
        Me.dessertDetails.DataPropertyName = "Details"
        Me.dessertDetails.HeaderText = "Details"
        Me.dessertDetails.MinimumWidth = 6
        Me.dessertDetails.Name = "dessertDetails"
        Me.dessertDetails.Visible = False
        Me.dessertDetails.Width = 125
        '
        'dessertType
        '
        Me.dessertType.DataPropertyName = "Type"
        Me.dessertType.HeaderText = "Type"
        Me.dessertType.MinimumWidth = 6
        Me.dessertType.Name = "dessertType"
        Me.dessertType.Visible = False
        Me.dessertType.Width = 125
        '
        'dessertDiscount
        '
        Me.dessertDiscount.DataPropertyName = "Discount"
        Me.dessertDiscount.HeaderText = "Discount"
        Me.dessertDiscount.MinimumWidth = 6
        Me.dessertDiscount.Name = "dessertDiscount"
        Me.dessertDiscount.Visible = False
        Me.dessertDiscount.Width = 125
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.Color.White
        Me.TabPage4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPage4.Controls.Add(Me.drinksTable)
        Me.TabPage4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.TabPage4.ForeColor = System.Drawing.Color.Black
        Me.TabPage4.Location = New System.Drawing.Point(4, 34)
        Me.TabPage4.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.TabPage4.Size = New System.Drawing.Size(552, 488)
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
        Me.drinksTable.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.drinksName, Me.drinksPrice, Me.drinksStatus, Me.drinksQuantity, Me.drinksAction, Me.DrinksID, Me.drinksMenuNumber, Me.drinksDetails, Me.drinksType, Me.drinksDiscount})
        Me.drinksTable.DataSource = Me.drinksBindingSource
        Me.drinksTable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.drinksTable.Location = New System.Drawing.Point(5, 7)
        Me.drinksTable.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.drinksTable.Name = "drinksTable"
        Me.drinksTable.RowHeadersVisible = False
        Me.drinksTable.RowHeadersWidth = 250
        Me.drinksTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.drinksTable.RowTemplate.Height = 24
        Me.drinksTable.Size = New System.Drawing.Size(538, 470)
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
        'drinksPrice
        '
        Me.drinksPrice.DataPropertyName = "Price"
        Me.drinksPrice.HeaderText = "Price"
        Me.drinksPrice.MinimumWidth = 6
        Me.drinksPrice.Name = "drinksPrice"
        Me.drinksPrice.ReadOnly = True
        Me.drinksPrice.Width = 80
        '
        'drinksStatus
        '
        Me.drinksStatus.DataPropertyName = "Status"
        Me.drinksStatus.HeaderText = "Status"
        Me.drinksStatus.MinimumWidth = 6
        Me.drinksStatus.Name = "drinksStatus"
        Me.drinksStatus.ReadOnly = True
        Me.drinksStatus.Width = 125
        '
        'drinksQuantity
        '
        DataGridViewCellStyle5.Format = "N0"
        DataGridViewCellStyle5.NullValue = "1"
        Me.drinksQuantity.DefaultCellStyle = DataGridViewCellStyle5
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
        'DrinksID
        '
        Me.DrinksID.DataPropertyName = "ID"
        Me.DrinksID.HeaderText = "ID"
        Me.DrinksID.MinimumWidth = 6
        Me.DrinksID.Name = "DrinksID"
        Me.DrinksID.Visible = False
        Me.DrinksID.Width = 125
        '
        'drinksMenuNumber
        '
        Me.drinksMenuNumber.DataPropertyName = "MenuNumber"
        Me.drinksMenuNumber.HeaderText = "MenuNumber"
        Me.drinksMenuNumber.MinimumWidth = 6
        Me.drinksMenuNumber.Name = "drinksMenuNumber"
        Me.drinksMenuNumber.Visible = False
        Me.drinksMenuNumber.Width = 125
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
        'drinksType
        '
        Me.drinksType.DataPropertyName = "Type"
        Me.drinksType.HeaderText = "Type"
        Me.drinksType.MinimumWidth = 6
        Me.drinksType.Name = "drinksType"
        Me.drinksType.Visible = False
        Me.drinksType.Width = 125
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
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Light", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(261, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 47)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "..."
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Transparent
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Times New Roman", 17.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnBack.Location = New System.Drawing.Point(20, 16)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(162, 54)
        Me.btnBack.TabIndex = 38
        Me.btnBack.Text = "Back"
        Me.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(214, 90)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(752, 33)
        Me.PictureBox1.TabIndex = 39
        Me.PictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(207, 47)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(292, 40)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "CREATE ORDER"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.InitialImage = Nothing
        Me.PictureBox3.Location = New System.Drawing.Point(1115, 12)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(144, 120)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 42
        Me.PictureBox3.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label7.Location = New System.Drawing.Point(651, 301)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(14, 312)
        Me.Label7.TabIndex = 43
        Me.Label7.Text = "|" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "|" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "|" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "|" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "|" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "|" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "|" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "|" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "|" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "|" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "|" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "|" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "|"
        '
        'TableManagementTableAdapter
        '
        Me.TableManagementTableAdapter.ClearBeforeFill = True
        '
        'DiscountManagementTableAdapter
        '
        Me.DiscountManagementTableAdapter.ClearBeforeFill = True
        '
        'OrdersForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1600, 900)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.Panel2)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.MaximumSize = New System.Drawing.Size(1600, 900)
        Me.MinimumSize = New System.Drawing.Size(1280, 898)
        Me.Name = "OrdersForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Orders"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.mainDishBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NamwahDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.appetizerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dessertBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.drinksBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.TableManagementDSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TableManagementDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NamwahDataSet2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NamwahDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.menuTab.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.mainDishTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.appetizerTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        CType(Me.dessertTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        CType(Me.drinksTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents listofmenus As ListBox
    Friend WithEvents NamwahDataSet As namwahDataSet
    Friend WithEvents totalPrice As TextBox
    Friend WithEvents TotalPriceLabel As Label
    Friend WithEvents initialPrice As TextBox
    Friend WithEvents mainDishBindingSource As BindingSource
    Friend WithEvents MenusTableAdapter As namwahDataSetTableAdapters.MenusTableAdapter
    Friend WithEvents appetizerBindingSource As BindingSource
    Friend WithEvents drinksBindingSource As BindingSource
    Friend WithEvents dessertBindingSource As BindingSource
    Friend WithEvents listofprices As ListBox
    Friend WithEvents lblListofPrice As Label
    Friend WithEvents lblSelectedMenus As Label
    Friend WithEvents listofquantity As ListBox
    Friend WithEvents Label3 As Label
    Friend WithEvents listofids As ListBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnRemoveLastItem As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents btnClearItem As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents orderType As ComboBox
    Friend WithEvents discounted As ComboBox
    Friend WithEvents orderNumber As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents menuTab As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents mainDishTable As DataGridView
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents appetizerTable As DataGridView
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents dessertTable As DataGridView
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents drinksTable As DataGridView
    Friend WithEvents Panel4 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents tableNumber As ComboBox
    Friend WithEvents mainDishName As DataGridViewTextBoxColumn
    Friend WithEvents mainDishPrice As DataGridViewTextBoxColumn
    Friend WithEvents mainDishStatus As DataGridViewTextBoxColumn
    Friend WithEvents mainDishQuantity As DataGridViewTextBoxColumn
    Friend WithEvents mainDishAction As DataGridViewButtonColumn
    Friend WithEvents mainDishID As DataGridViewTextBoxColumn
    Friend WithEvents mainDishMenuNumber As DataGridViewTextBoxColumn
    Friend WithEvents mainDishDetails As DataGridViewTextBoxColumn
    Friend WithEvents mainDishType As DataGridViewTextBoxColumn
    Friend WithEvents mainDishDiscount As DataGridViewTextBoxColumn
    Friend WithEvents appetizerName As DataGridViewTextBoxColumn
    Friend WithEvents appetizerPrice As DataGridViewTextBoxColumn
    Friend WithEvents appetizerStatus As DataGridViewTextBoxColumn
    Friend WithEvents appetizerQuantity As DataGridViewTextBoxColumn
    Friend WithEvents appetizerAction As DataGridViewButtonColumn
    Friend WithEvents appetizerID As DataGridViewTextBoxColumn
    Friend WithEvents appetizerMenuNumber As DataGridViewTextBoxColumn
    Friend WithEvents appetizerDetails As DataGridViewTextBoxColumn
    Friend WithEvents appetizerType As DataGridViewTextBoxColumn
    Friend WithEvents appetizerDiscount As DataGridViewTextBoxColumn
    Friend WithEvents dessertName As DataGridViewTextBoxColumn
    Friend WithEvents dessertPrice As DataGridViewTextBoxColumn
    Friend WithEvents dessertStatus As DataGridViewTextBoxColumn
    Friend WithEvents dessertQuantity As DataGridViewTextBoxColumn
    Friend WithEvents dessertAction As DataGridViewButtonColumn
    Friend WithEvents dessertID As DataGridViewTextBoxColumn
    Friend WithEvents dessertMenuNumber As DataGridViewTextBoxColumn
    Friend WithEvents dessertDetails As DataGridViewTextBoxColumn
    Friend WithEvents dessertType As DataGridViewTextBoxColumn
    Friend WithEvents dessertDiscount As DataGridViewTextBoxColumn
    Friend WithEvents drinksName As DataGridViewTextBoxColumn
    Friend WithEvents drinksPrice As DataGridViewTextBoxColumn
    Friend WithEvents drinksStatus As DataGridViewTextBoxColumn
    Friend WithEvents drinksQuantity As DataGridViewTextBoxColumn
    Friend WithEvents drinksAction As DataGridViewButtonColumn
    Friend WithEvents DrinksID As DataGridViewTextBoxColumn
    Friend WithEvents drinksMenuNumber As DataGridViewTextBoxColumn
    Friend WithEvents drinksDetails As DataGridViewTextBoxColumn
    Friend WithEvents drinksType As DataGridViewTextBoxColumn
    Friend WithEvents drinksDiscount As DataGridViewTextBoxColumn
    Friend WithEvents TableManagementDSBindingSource As BindingSource
    Friend WithEvents TableManagementDS As TableManagementDS
    Friend WithEvents TableManagementTableAdapter As TableManagementDSTableAdapters.TableManagementTableAdapter
    Friend WithEvents NamwahDataSet2 As namwahDataSet2
    Friend WithEvents NamwahDataSet2BindingSource As BindingSource
    Friend WithEvents DiscountManagementTableAdapter As namwahDataSet2TableAdapters.DiscountManagementTableAdapter
End Class
