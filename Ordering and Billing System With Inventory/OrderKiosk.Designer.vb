<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class OrderKiosk
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OrderKiosk))
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.dessertDateTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DessertBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MenusDataSet = New Ordering_and_Billing_System_With_Inventory.menusDataSet()
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
        Me.appetizerDateTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AppetizerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.drinksTable = New System.Windows.Forms.DataGridView()
        Me.drinksName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.drinksPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.drinksStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.drinksQuantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.drinksAction = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.drinksID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.drinksMenuNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.drinksDetails = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.drinksType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.drinksDiscount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.drinksDateTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DrinksBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.tableNumber = New System.Windows.Forms.ComboBox()
        Me.TableManagementDSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableManagementDS = New Ordering_and_Billing_System_With_Inventory.TableManagementDS()
        Me.orderNumber = New System.Windows.Forms.TextBox()
        Me.orderType = New System.Windows.Forms.ComboBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.discounted = New System.Windows.Forms.ComboBox()
        Me.NamwahDataSet2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NamwahDataSet2 = New Ordering_and_Billing_System_With_Inventory.namwahDataSet2()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.tableNumberLabel = New System.Windows.Forms.Label()
        Me.orderNumberLabel = New System.Windows.Forms.Label()
        Me.lbxMenuID = New System.Windows.Forms.ListBox()
        Me.MenusTableAdapter = New Ordering_and_Billing_System_With_Inventory.menusDataSetTableAdapters.MenusTableAdapter()
        Me.MenusBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.mainDishTable = New System.Windows.Forms.DataGridView()
        Me.mainDishName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mainDishPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mainDishStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mainDishQuantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mainDishAction = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.mainDishID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mainDishMenuNum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mainDishDetails = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mainDishType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mainDishDiscount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mainDishDateTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnClearItem = New System.Windows.Forms.Button()
        Me.btnRemoveLastItem = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.initialPrice = New System.Windows.Forms.TextBox()
        Me.totalPrice = New System.Windows.Forms.TextBox()
        Me.lbxMenuPrice = New System.Windows.Forms.ListBox()
        Me.lbxMenuQuantity = New System.Windows.Forms.ListBox()
        Me.lbxMenuItems = New System.Windows.Forms.ListBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DiscountManagementTableAdapter = New Ordering_and_Billing_System_With_Inventory.namwahDataSet2TableAdapters.DiscountManagementTableAdapter()
        Me.TableManagementTableAdapter = New Ordering_and_Billing_System_With_Inventory.TableManagementDSTableAdapters.TableManagementTableAdapter()
        Me.TabPage3.SuspendLayout()
        CType(Me.dessertTable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DessertBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MenusDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.appetizerTable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AppetizerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.drinksTable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DrinksBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        CType(Me.TableManagementDSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TableManagementDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.NamwahDataSet2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NamwahDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MenusBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mainDishTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.White
        Me.TabPage3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPage3.Controls.Add(Me.dessertTable)
        Me.TabPage3.ForeColor = System.Drawing.Color.Black
        Me.TabPage3.Location = New System.Drawing.Point(4, 27)
        Me.TabPage3.Margin = New System.Windows.Forms.Padding(7, 9, 7, 9)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(7, 9, 7, 9)
        Me.TabPage3.Size = New System.Drawing.Size(552, 405)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Dessert"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'dessertTable
        '
        Me.dessertTable.AllowUserToAddRows = False
        Me.dessertTable.AllowUserToDeleteRows = False
        Me.dessertTable.AutoGenerateColumns = False
        Me.dessertTable.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dessertTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dessertTable.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dessertName, Me.dessertPrice, Me.dessertStatus, Me.dessertQuantity, Me.dessertAction, Me.dessertID, Me.dessertMenuNumber, Me.dessertDetails, Me.dessertType, Me.dessertDiscount, Me.dessertDateTime})
        Me.dessertTable.DataSource = Me.DessertBindingSource
        Me.dessertTable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dessertTable.Location = New System.Drawing.Point(7, 9)
        Me.dessertTable.Margin = New System.Windows.Forms.Padding(7, 9, 7, 9)
        Me.dessertTable.Name = "dessertTable"
        Me.dessertTable.RowHeadersWidth = 51
        Me.dessertTable.Size = New System.Drawing.Size(534, 383)
        Me.dessertTable.TabIndex = 0
        '
        'dessertName
        '
        Me.dessertName.DataPropertyName = "Name"
        Me.dessertName.HeaderText = "Name"
        Me.dessertName.MinimumWidth = 6
        Me.dessertName.Name = "dessertName"
        Me.dessertName.Width = 125
        '
        'dessertPrice
        '
        Me.dessertPrice.DataPropertyName = "Price"
        Me.dessertPrice.HeaderText = "Price"
        Me.dessertPrice.MinimumWidth = 6
        Me.dessertPrice.Name = "dessertPrice"
        Me.dessertPrice.Width = 125
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
        'dessertQuantity
        '
        DataGridViewCellStyle1.Format = "N0"
        DataGridViewCellStyle1.NullValue = "1"
        Me.dessertQuantity.DefaultCellStyle = DataGridViewCellStyle1
        Me.dessertQuantity.HeaderText = "Quantity"
        Me.dessertQuantity.MinimumWidth = 6
        Me.dessertQuantity.Name = "dessertQuantity"
        Me.dessertQuantity.Width = 125
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
        'dessertDateTime
        '
        Me.dessertDateTime.DataPropertyName = "createdDateTime"
        Me.dessertDateTime.HeaderText = "createdDateTime"
        Me.dessertDateTime.MinimumWidth = 6
        Me.dessertDateTime.Name = "dessertDateTime"
        Me.dessertDateTime.Visible = False
        Me.dessertDateTime.Width = 125
        '
        'DessertBindingSource
        '
        Me.DessertBindingSource.DataMember = "Menus"
        Me.DessertBindingSource.DataSource = Me.MenusDataSet
        Me.DessertBindingSource.Filter = "Type='Dessert' AND Status='Available'"
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
        Me.TabPage2.ForeColor = System.Drawing.Color.Black
        Me.TabPage2.Location = New System.Drawing.Point(4, 27)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.TabPage2.Size = New System.Drawing.Size(552, 405)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Appetizer"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'appetizerTable
        '
        Me.appetizerTable.AllowUserToAddRows = False
        Me.appetizerTable.AllowUserToDeleteRows = False
        Me.appetizerTable.AutoGenerateColumns = False
        Me.appetizerTable.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.appetizerTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.appetizerTable.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.appetizerName, Me.appetizerPrice, Me.appetizerStatus, Me.appetizerQuantity, Me.appetizerAction, Me.appetizerID, Me.appetizerMenuNumber, Me.appetizerDetails, Me.appetizerType, Me.appetizerDiscount, Me.appetizerDateTime})
        Me.appetizerTable.DataSource = Me.AppetizerBindingSource
        Me.appetizerTable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.appetizerTable.Location = New System.Drawing.Point(5, 4)
        Me.appetizerTable.Margin = New System.Windows.Forms.Padding(7, 9, 7, 9)
        Me.appetizerTable.Name = "appetizerTable"
        Me.appetizerTable.RowHeadersWidth = 51
        Me.appetizerTable.Size = New System.Drawing.Size(538, 393)
        Me.appetizerTable.TabIndex = 0
        '
        'appetizerName
        '
        Me.appetizerName.DataPropertyName = "Name"
        Me.appetizerName.HeaderText = "Name"
        Me.appetizerName.MinimumWidth = 6
        Me.appetizerName.Name = "appetizerName"
        Me.appetizerName.Width = 125
        '
        'appetizerPrice
        '
        Me.appetizerPrice.DataPropertyName = "Price"
        Me.appetizerPrice.HeaderText = "Price"
        Me.appetizerPrice.MinimumWidth = 6
        Me.appetizerPrice.Name = "appetizerPrice"
        Me.appetizerPrice.Width = 125
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
        'appetizerQuantity
        '
        DataGridViewCellStyle2.Format = "N0"
        DataGridViewCellStyle2.NullValue = "1"
        Me.appetizerQuantity.DefaultCellStyle = DataGridViewCellStyle2
        Me.appetizerQuantity.HeaderText = "Quantity"
        Me.appetizerQuantity.MinimumWidth = 6
        Me.appetizerQuantity.Name = "appetizerQuantity"
        Me.appetizerQuantity.ToolTipText = "Quantity"
        Me.appetizerQuantity.Width = 125
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
        'appetizerDateTime
        '
        Me.appetizerDateTime.DataPropertyName = "createdDateTime"
        Me.appetizerDateTime.HeaderText = "createdDateTime"
        Me.appetizerDateTime.MinimumWidth = 6
        Me.appetizerDateTime.Name = "appetizerDateTime"
        Me.appetizerDateTime.Visible = False
        Me.appetizerDateTime.Width = 125
        '
        'AppetizerBindingSource
        '
        Me.AppetizerBindingSource.DataMember = "Menus"
        Me.AppetizerBindingSource.DataSource = Me.MenusDataSet
        Me.AppetizerBindingSource.Filter = "Type='Appetizer' AND Status='Available'"
        '
        'drinksTable
        '
        Me.drinksTable.AllowUserToAddRows = False
        Me.drinksTable.AllowUserToDeleteRows = False
        Me.drinksTable.AutoGenerateColumns = False
        Me.drinksTable.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.drinksTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.drinksTable.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.drinksName, Me.drinksPrice, Me.drinksStatus, Me.drinksQuantity, Me.drinksAction, Me.drinksID, Me.drinksMenuNumber, Me.drinksDetails, Me.drinksType, Me.drinksDiscount, Me.drinksDateTime})
        Me.drinksTable.DataSource = Me.DrinksBindingSource
        Me.drinksTable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.drinksTable.Location = New System.Drawing.Point(7, 9)
        Me.drinksTable.Margin = New System.Windows.Forms.Padding(7, 9, 7, 9)
        Me.drinksTable.Name = "drinksTable"
        Me.drinksTable.RowHeadersWidth = 51
        Me.drinksTable.Size = New System.Drawing.Size(534, 383)
        Me.drinksTable.TabIndex = 0
        '
        'drinksName
        '
        Me.drinksName.DataPropertyName = "Name"
        Me.drinksName.HeaderText = "Name"
        Me.drinksName.MinimumWidth = 6
        Me.drinksName.Name = "drinksName"
        Me.drinksName.Width = 125
        '
        'drinksPrice
        '
        Me.drinksPrice.DataPropertyName = "Price"
        Me.drinksPrice.HeaderText = "Price"
        Me.drinksPrice.MinimumWidth = 6
        Me.drinksPrice.Name = "drinksPrice"
        Me.drinksPrice.Width = 125
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
        DataGridViewCellStyle3.Format = "N0"
        DataGridViewCellStyle3.NullValue = "1"
        Me.drinksQuantity.DefaultCellStyle = DataGridViewCellStyle3
        Me.drinksQuantity.HeaderText = "Quantity"
        Me.drinksQuantity.MinimumWidth = 6
        Me.drinksQuantity.Name = "drinksQuantity"
        Me.drinksQuantity.Width = 125
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
        'drinksID
        '
        Me.drinksID.DataPropertyName = "ID"
        Me.drinksID.HeaderText = "ID"
        Me.drinksID.MinimumWidth = 6
        Me.drinksID.Name = "drinksID"
        Me.drinksID.Visible = False
        Me.drinksID.Width = 125
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
        'drinksDateTime
        '
        Me.drinksDateTime.DataPropertyName = "createdDateTime"
        Me.drinksDateTime.HeaderText = "createdDateTime"
        Me.drinksDateTime.MinimumWidth = 6
        Me.drinksDateTime.Name = "drinksDateTime"
        Me.drinksDateTime.Visible = False
        Me.drinksDateTime.Width = 125
        '
        'DrinksBindingSource
        '
        Me.DrinksBindingSource.DataMember = "Menus"
        Me.DrinksBindingSource.DataSource = Me.MenusDataSet
        Me.DrinksBindingSource.Filter = "Type='Drinks' AND Status='Available'"
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.Color.White
        Me.TabPage4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPage4.Controls.Add(Me.drinksTable)
        Me.TabPage4.ForeColor = System.Drawing.Color.Black
        Me.TabPage4.Location = New System.Drawing.Point(4, 27)
        Me.TabPage4.Margin = New System.Windows.Forms.Padding(7, 9, 7, 9)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(7, 9, 7, 9)
        Me.TabPage4.Size = New System.Drawing.Size(552, 405)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Drinks"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'tableNumber
        '
        Me.tableNumber.BackColor = System.Drawing.Color.White
        Me.tableNumber.DataSource = Me.TableManagementDSBindingSource
        Me.tableNumber.DisplayMember = "TableNum"
        Me.tableNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.tableNumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tableNumber.Font = New System.Drawing.Font("Courier New", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tableNumber.FormattingEnabled = True
        Me.tableNumber.ItemHeight = 20
        Me.tableNumber.Location = New System.Drawing.Point(141, 70)
        Me.tableNumber.Margin = New System.Windows.Forms.Padding(7, 9, 7, 9)
        Me.tableNumber.Name = "tableNumber"
        Me.tableNumber.Size = New System.Drawing.Size(121, 28)
        Me.tableNumber.TabIndex = 53
        Me.tableNumber.Tag = "tableNumber"
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
        'orderNumber
        '
        Me.orderNumber.BackColor = System.Drawing.Color.White
        Me.orderNumber.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.orderNumber.Cursor = System.Windows.Forms.Cursors.Default
        Me.orderNumber.Font = New System.Drawing.Font("Courier New", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.orderNumber.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.orderNumber.Location = New System.Drawing.Point(141, 20)
        Me.orderNumber.Margin = New System.Windows.Forms.Padding(7, 9, 7, 9)
        Me.orderNumber.Name = "orderNumber"
        Me.orderNumber.ReadOnly = True
        Me.orderNumber.Size = New System.Drawing.Size(121, 21)
        Me.orderNumber.TabIndex = 37
        Me.orderNumber.Tag = "Order Number"
        '
        'orderType
        '
        Me.orderType.BackColor = System.Drawing.Color.White
        Me.orderType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.orderType.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.orderType.Font = New System.Drawing.Font("Courier New", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.orderType.FormattingEnabled = True
        Me.orderType.ItemHeight = 20
        Me.orderType.Items.AddRange(New Object() {"Dine-In", "Take-Out"})
        Me.orderType.Location = New System.Drawing.Point(400, 75)
        Me.orderType.Margin = New System.Windows.Forms.Padding(7, 9, 7, 9)
        Me.orderType.Name = "orderType"
        Me.orderType.Size = New System.Drawing.Size(108, 28)
        Me.orderType.TabIndex = 52
        Me.orderType.Tag = "Type"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Location = New System.Drawing.Point(826, 19)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(53, 77)
        Me.PictureBox3.TabIndex = 64
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(166, 19)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(53, 77)
        Me.PictureBox2.TabIndex = 63
        Me.PictureBox2.TabStop = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.White
        Me.btnBack.BackgroundImage = Global.Ordering_and_Billing_System_With_Inventory.My.Resources.Resources.shutdown_32px
        Me.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btnBack.ForeColor = System.Drawing.Color.Black
        Me.btnBack.Location = New System.Drawing.Point(21, 19)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(7, 9, 7, 9)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(63, 51)
        Me.btnBack.TabIndex = 65
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.Controls.Add(Me.tableNumber)
        Me.Panel3.Controls.Add(Me.orderNumber)
        Me.Panel3.Controls.Add(Me.orderType)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.discounted)
        Me.Panel3.Controls.Add(Me.Label12)
        Me.Panel3.Controls.Add(Me.tableNumberLabel)
        Me.Panel3.Controls.Add(Me.orderNumberLabel)
        Me.Panel3.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel3.Location = New System.Drawing.Point(25, 104)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(529, 133)
        Me.Panel3.TabIndex = 52
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(280, 60)
        Me.Label3.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 55)
        Me.Label3.TabIndex = 51
        Me.Label3.Text = "Order Type:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'discounted
        '
        Me.discounted.BackColor = System.Drawing.Color.White
        Me.discounted.DataSource = Me.NamwahDataSet2BindingSource
        Me.discounted.DisplayMember = "Name"
        Me.discounted.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.discounted.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.discounted.Font = New System.Drawing.Font("Courier New", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.discounted.FormattingEnabled = True
        Me.discounted.ItemHeight = 20
        Me.discounted.Location = New System.Drawing.Point(400, 17)
        Me.discounted.Margin = New System.Windows.Forms.Padding(7, 9, 7, 9)
        Me.discounted.Name = "discounted"
        Me.discounted.Size = New System.Drawing.Size(108, 28)
        Me.discounted.TabIndex = 50
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
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label12.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(276, 9)
        Me.Label12.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(131, 51)
        Me.Label12.TabIndex = 49
        Me.Label12.Text = "Discount:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tableNumberLabel
        '
        Me.tableNumberLabel.BackColor = System.Drawing.Color.Transparent
        Me.tableNumberLabel.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tableNumberLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.tableNumberLabel.Location = New System.Drawing.Point(4, 65)
        Me.tableNumberLabel.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.tableNumberLabel.Name = "tableNumberLabel"
        Me.tableNumberLabel.Size = New System.Drawing.Size(123, 42)
        Me.tableNumberLabel.TabIndex = 38
        Me.tableNumberLabel.Text = "Table Number:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.tableNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'orderNumberLabel
        '
        Me.orderNumberLabel.BackColor = System.Drawing.Color.Transparent
        Me.orderNumberLabel.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.orderNumberLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.orderNumberLabel.Location = New System.Drawing.Point(1, 0)
        Me.orderNumberLabel.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.orderNumberLabel.Name = "orderNumberLabel"
        Me.orderNumberLabel.Size = New System.Drawing.Size(135, 65)
        Me.orderNumberLabel.TabIndex = 36
        Me.orderNumberLabel.Text = "Order Number :"
        Me.orderNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbxMenuID
        '
        Me.lbxMenuID.FormattingEnabled = True
        Me.lbxMenuID.ItemHeight = 28
        Me.lbxMenuID.Location = New System.Drawing.Point(29, 87)
        Me.lbxMenuID.Margin = New System.Windows.Forms.Padding(7, 9, 7, 9)
        Me.lbxMenuID.Name = "lbxMenuID"
        Me.lbxMenuID.Size = New System.Drawing.Size(42, 4)
        Me.lbxMenuID.TabIndex = 44
        Me.lbxMenuID.Visible = False
        '
        'MenusTableAdapter
        '
        Me.MenusTableAdapter.ClearBeforeFill = True
        '
        'MenusBindingSource
        '
        Me.MenusBindingSource.DataMember = "Menus"
        Me.MenusBindingSource.DataSource = Me.MenusDataSet
        Me.MenusBindingSource.Filter = "Type='Main Dish' AND Status='Available'"
        '
        'mainDishTable
        '
        Me.mainDishTable.AllowUserToAddRows = False
        Me.mainDishTable.AllowUserToDeleteRows = False
        Me.mainDishTable.AutoGenerateColumns = False
        Me.mainDishTable.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.mainDishTable.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.mainDishTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.mainDishTable.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.mainDishName, Me.mainDishPrice, Me.mainDishStatus, Me.mainDishQuantity, Me.mainDishAction, Me.mainDishID, Me.mainDishMenuNum, Me.mainDishDetails, Me.mainDishType, Me.mainDishDiscount, Me.mainDishDateTime})
        Me.mainDishTable.DataSource = Me.MenusBindingSource
        Me.mainDishTable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mainDishTable.Location = New System.Drawing.Point(5, 4)
        Me.mainDishTable.Margin = New System.Windows.Forms.Padding(7, 9, 7, 9)
        Me.mainDishTable.Name = "mainDishTable"
        Me.mainDishTable.RowHeadersWidth = 51
        Me.mainDishTable.Size = New System.Drawing.Size(542, 397)
        Me.mainDishTable.TabIndex = 0
        '
        'mainDishName
        '
        Me.mainDishName.DataPropertyName = "Name"
        Me.mainDishName.HeaderText = "Name"
        Me.mainDishName.MinimumWidth = 6
        Me.mainDishName.Name = "mainDishName"
        Me.mainDishName.Width = 125
        '
        'mainDishPrice
        '
        Me.mainDishPrice.DataPropertyName = "Price"
        Me.mainDishPrice.HeaderText = "Price"
        Me.mainDishPrice.MinimumWidth = 6
        Me.mainDishPrice.Name = "mainDishPrice"
        Me.mainDishPrice.Width = 125
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
        'mainDishQuantity
        '
        DataGridViewCellStyle4.Format = "N0"
        DataGridViewCellStyle4.NullValue = "1"
        Me.mainDishQuantity.DefaultCellStyle = DataGridViewCellStyle4
        Me.mainDishQuantity.HeaderText = "Quantity"
        Me.mainDishQuantity.MinimumWidth = 6
        Me.mainDishQuantity.Name = "mainDishQuantity"
        Me.mainDishQuantity.Width = 125
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
        'mainDishMenuNum
        '
        Me.mainDishMenuNum.DataPropertyName = "MenuNumber"
        Me.mainDishMenuNum.HeaderText = "MenuNumber"
        Me.mainDishMenuNum.MinimumWidth = 6
        Me.mainDishMenuNum.Name = "mainDishMenuNum"
        Me.mainDishMenuNum.Visible = False
        Me.mainDishMenuNum.Width = 125
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
        'mainDishDateTime
        '
        Me.mainDishDateTime.DataPropertyName = "createdDateTime"
        Me.mainDishDateTime.HeaderText = "createdDateTime"
        Me.mainDishDateTime.MinimumWidth = 6
        Me.mainDishDateTime.Name = "mainDishDateTime"
        Me.mainDishDateTime.Visible = False
        Me.mainDishDateTime.Width = 125
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.White
        Me.TabPage1.Controls.Add(Me.mainDishTable)
        Me.TabPage1.ForeColor = System.Drawing.Color.Black
        Me.TabPage1.Location = New System.Drawing.Point(4, 27)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.TabPage1.Size = New System.Drawing.Size(552, 405)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Main Dish"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(25, 245)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(560, 436)
        Me.TabControl1.TabIndex = 49
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(280, 15)
        Me.Label6.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 17)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Prices"
        '
        'btnClearItem
        '
        Me.btnClearItem.BackColor = System.Drawing.Color.Transparent
        Me.btnClearItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClearItem.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearItem.ForeColor = System.Drawing.Color.White
        Me.btnClearItem.Location = New System.Drawing.Point(16, 507)
        Me.btnClearItem.Margin = New System.Windows.Forms.Padding(7, 9, 7, 9)
        Me.btnClearItem.Name = "btnClearItem"
        Me.btnClearItem.Size = New System.Drawing.Size(110, 52)
        Me.btnClearItem.TabIndex = 46
        Me.btnClearItem.Text = "Clear Item"
        Me.btnClearItem.UseVisualStyleBackColor = False
        '
        'btnRemoveLastItem
        '
        Me.btnRemoveLastItem.BackColor = System.Drawing.Color.Transparent
        Me.btnRemoveLastItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemoveLastItem.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemoveLastItem.ForeColor = System.Drawing.Color.White
        Me.btnRemoveLastItem.Location = New System.Drawing.Point(140, 507)
        Me.btnRemoveLastItem.Margin = New System.Windows.Forms.Padding(7, 9, 7, 9)
        Me.btnRemoveLastItem.Name = "btnRemoveLastItem"
        Me.btnRemoveLastItem.Size = New System.Drawing.Size(113, 52)
        Me.btnRemoveLastItem.TabIndex = 47
        Me.btnRemoveLastItem.Text = "Remove Selected Item"
        Me.btnRemoveLastItem.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(177, 15)
        Me.Label5.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 17)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Quantity"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(10, 15)
        Me.Label4.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(134, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Selected Items"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Gabriola", 30.0!)
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Location = New System.Drawing.Point(255, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(423, 74)
        Me.Label7.TabIndex = 50
        Me.Label7.Text = "Welcome to NAMWAH Cuisine!"
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.Transparent
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.Location = New System.Drawing.Point(267, 507)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(7, 9, 7, 9)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(113, 52)
        Me.btnAdd.TabIndex = 45
        Me.btnAdd.Text = "Submit Order"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 445)
        Me.Label2.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Total Price:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 376)
        Me.Label1.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Initial Price:"
        '
        'initialPrice
        '
        Me.initialPrice.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.initialPrice.Location = New System.Drawing.Point(186, 371)
        Me.initialPrice.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.initialPrice.Name = "initialPrice"
        Me.initialPrice.ReadOnly = True
        Me.initialPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.initialPrice.Size = New System.Drawing.Size(194, 26)
        Me.initialPrice.TabIndex = 3
        Me.initialPrice.Text = "0.00"
        '
        'totalPrice
        '
        Me.totalPrice.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalPrice.Location = New System.Drawing.Point(186, 440)
        Me.totalPrice.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.totalPrice.Name = "totalPrice"
        Me.totalPrice.ReadOnly = True
        Me.totalPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.totalPrice.Size = New System.Drawing.Size(194, 26)
        Me.totalPrice.TabIndex = 0
        Me.totalPrice.Text = "0.00"
        '
        'lbxMenuPrice
        '
        Me.lbxMenuPrice.Enabled = False
        Me.lbxMenuPrice.Font = New System.Drawing.Font("Courier New", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbxMenuPrice.FormattingEnabled = True
        Me.lbxMenuPrice.ItemHeight = 20
        Me.lbxMenuPrice.Location = New System.Drawing.Point(277, 54)
        Me.lbxMenuPrice.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.lbxMenuPrice.Name = "lbxMenuPrice"
        Me.lbxMenuPrice.Size = New System.Drawing.Size(105, 304)
        Me.lbxMenuPrice.TabIndex = 2
        '
        'lbxMenuQuantity
        '
        Me.lbxMenuQuantity.Enabled = False
        Me.lbxMenuQuantity.Font = New System.Drawing.Font("Courier New", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbxMenuQuantity.FormattingEnabled = True
        Me.lbxMenuQuantity.ItemHeight = 20
        Me.lbxMenuQuantity.Location = New System.Drawing.Point(201, 55)
        Me.lbxMenuQuantity.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.lbxMenuQuantity.Name = "lbxMenuQuantity"
        Me.lbxMenuQuantity.Size = New System.Drawing.Size(65, 304)
        Me.lbxMenuQuantity.TabIndex = 1
        '
        'lbxMenuItems
        '
        Me.lbxMenuItems.Font = New System.Drawing.Font("Courier New", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbxMenuItems.FormattingEnabled = True
        Me.lbxMenuItems.ItemHeight = 20
        Me.lbxMenuItems.Location = New System.Drawing.Point(14, 55)
        Me.lbxMenuItems.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.lbxMenuItems.Name = "lbxMenuItems"
        Me.lbxMenuItems.Size = New System.Drawing.Size(176, 304)
        Me.lbxMenuItems.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.btnClearItem)
        Me.Panel2.Controls.Add(Me.btnRemoveLastItem)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.btnAdd)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.initialPrice)
        Me.Panel2.Controls.Add(Me.totalPrice)
        Me.Panel2.Controls.Add(Me.lbxMenuPrice)
        Me.Panel2.Controls.Add(Me.lbxMenuQuantity)
        Me.Panel2.Controls.Add(Me.lbxMenuItems)
        Me.Panel2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel2.Location = New System.Drawing.Point(595, 106)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(401, 579)
        Me.Panel2.TabIndex = 51
        '
        'DiscountManagementTableAdapter
        '
        Me.DiscountManagementTableAdapter.ClearBeforeFill = True
        '
        'TableManagementTableAdapter
        '
        Me.TableManagementTableAdapter.ClearBeforeFill = True
        '
        'OrderKiosk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 28.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackgroundImage = Global.Ordering_and_Billing_System_With_Inventory.My.Resources.Resources.background_template_with_chinese_patterns_red_1308_38164
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lbxMenuID)
        Me.Controls.Add(Me.Panel2)
        Me.Font = New System.Drawing.Font("Bernard MT Condensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.MaximumSize = New System.Drawing.Size(1024, 768)
        Me.MinimumSize = New System.Drawing.Size(1024, 768)
        Me.Name = "OrderKiosk"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Kiosk Order"
        Me.TabPage3.ResumeLayout(False)
        CType(Me.dessertTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DessertBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MenusDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.appetizerTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AppetizerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.drinksTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DrinksBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        CType(Me.TableManagementDSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TableManagementDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.NamwahDataSet2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NamwahDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MenusBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mainDishTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents dessertTable As DataGridView
    Friend WithEvents DessertBindingSource As BindingSource
    Friend WithEvents MenusDataSet As menusDataSet
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents appetizerTable As DataGridView
    Friend WithEvents AppetizerBindingSource As BindingSource
    Friend WithEvents drinksTable As DataGridView
    Friend WithEvents DrinksBindingSource As BindingSource
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents tableNumber As ComboBox
    Friend WithEvents orderNumber As TextBox
    Friend WithEvents orderType As ComboBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnBack As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents discounted As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents lbxMenuID As ListBox
    Friend WithEvents tableNumberLabel As Label
    Friend WithEvents orderNumberLabel As Label
    Friend WithEvents MenusTableAdapter As menusDataSetTableAdapters.MenusTableAdapter
    Friend WithEvents MenusBindingSource As BindingSource
    Friend WithEvents mainDishTable As DataGridView
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents Label6 As Label
    Friend WithEvents btnClearItem As Button
    Friend WithEvents btnRemoveLastItem As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents initialPrice As TextBox
    Friend WithEvents totalPrice As TextBox
    Friend WithEvents lbxMenuPrice As ListBox
    Friend WithEvents lbxMenuQuantity As ListBox
    Friend WithEvents lbxMenuItems As ListBox
    Friend WithEvents Panel2 As Panel
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
    Friend WithEvents dessertDateTime As DataGridViewTextBoxColumn
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
    Friend WithEvents appetizerDateTime As DataGridViewTextBoxColumn
    Friend WithEvents drinksName As DataGridViewTextBoxColumn
    Friend WithEvents drinksPrice As DataGridViewTextBoxColumn
    Friend WithEvents drinksStatus As DataGridViewTextBoxColumn
    Friend WithEvents drinksQuantity As DataGridViewTextBoxColumn
    Friend WithEvents drinksAction As DataGridViewButtonColumn
    Friend WithEvents drinksID As DataGridViewTextBoxColumn
    Friend WithEvents drinksMenuNumber As DataGridViewTextBoxColumn
    Friend WithEvents drinksDetails As DataGridViewTextBoxColumn
    Friend WithEvents drinksType As DataGridViewTextBoxColumn
    Friend WithEvents drinksDiscount As DataGridViewTextBoxColumn
    Friend WithEvents drinksDateTime As DataGridViewTextBoxColumn
    Friend WithEvents mainDishName As DataGridViewTextBoxColumn
    Friend WithEvents mainDishPrice As DataGridViewTextBoxColumn
    Friend WithEvents mainDishStatus As DataGridViewTextBoxColumn
    Friend WithEvents mainDishQuantity As DataGridViewTextBoxColumn
    Friend WithEvents mainDishAction As DataGridViewButtonColumn
    Friend WithEvents mainDishID As DataGridViewTextBoxColumn
    Friend WithEvents mainDishMenuNum As DataGridViewTextBoxColumn
    Friend WithEvents mainDishDetails As DataGridViewTextBoxColumn
    Friend WithEvents mainDishType As DataGridViewTextBoxColumn
    Friend WithEvents mainDishDiscount As DataGridViewTextBoxColumn
    Friend WithEvents mainDishDateTime As DataGridViewTextBoxColumn
    Friend WithEvents NamwahDataSet2BindingSource As BindingSource
    Friend WithEvents NamwahDataSet2 As namwahDataSet2
    Friend WithEvents DiscountManagementTableAdapter As namwahDataSet2TableAdapters.DiscountManagementTableAdapter
    Friend WithEvents TableManagementDSBindingSource As BindingSource
    Friend WithEvents TableManagementDS As TableManagementDS
    Friend WithEvents TableManagementTableAdapter As TableManagementDSTableAdapters.TableManagementTableAdapter
End Class
