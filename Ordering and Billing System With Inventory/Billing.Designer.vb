<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Billing
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Billing))
        Me.NamwahDataSet = New Ordering_and_Billing_System_With_Inventory.namwahDataSet()
        Me.NamwahDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtboxOrderNum = New System.Windows.Forms.TextBox()
        Me.txtboxPayments = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtboxTableNum = New System.Windows.Forms.TextBox()
        Me.txtboxTotal = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.ordersDataView = New System.Windows.Forms.DataGridView()
        Me.orderNum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.initialPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.totalPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.location = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.menusType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.discounted = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Action = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.cancelOrderAction = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.ordersID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ListOfMenuDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ListOfPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuQuantityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CreatedDateTimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenusIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamwahOrdersDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NamwahOrdersDataSet = New Ordering_and_Billing_System_With_Inventory.namwahOrdersDataSet()
        Me.OrdersTableAdapter = New Ordering_and_Billing_System_With_Inventory.namwahOrdersDataSetTableAdapters.OrdersTableAdapter()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtboxChange = New System.Windows.Forms.TextBox()
        Me.lblBillNum = New System.Windows.Forms.Label()
        Me.txtboxBillingNum = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.tbxOrderID = New System.Windows.Forms.TextBox()
        CType(Me.NamwahDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NamwahDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ordersDataView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NamwahOrdersDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NamwahOrdersDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NamwahDataSet
        '
        Me.NamwahDataSet.DataSetName = "namwahDataSet"
        Me.NamwahDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'NamwahDataSetBindingSource
        '
        Me.NamwahDataSetBindingSource.DataSource = Me.NamwahDataSet
        Me.NamwahDataSetBindingSource.Position = 0
        '
        'txtboxOrderNum
        '
        Me.txtboxOrderNum.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtboxOrderNum.Font = New System.Drawing.Font("Segoe UI Light", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboxOrderNum.Location = New System.Drawing.Point(1006, 354)
        Me.txtboxOrderNum.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtboxOrderNum.Name = "txtboxOrderNum"
        Me.txtboxOrderNum.ReadOnly = True
        Me.txtboxOrderNum.Size = New System.Drawing.Size(323, 25)
        Me.txtboxOrderNum.TabIndex = 1
        '
        'txtboxPayments
        '
        Me.txtboxPayments.Font = New System.Drawing.Font("Segoe UI Light", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboxPayments.Location = New System.Drawing.Point(1005, 654)
        Me.txtboxPayments.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtboxPayments.Name = "txtboxPayments"
        Me.txtboxPayments.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtboxPayments.Size = New System.Drawing.Size(323, 32)
        Me.txtboxPayments.TabIndex = 2
        Me.txtboxPayments.Text = "0"
        Me.txtboxPayments.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(1003, 612)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 22)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Payment:"
        '
        'txtboxTableNum
        '
        Me.txtboxTableNum.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtboxTableNum.Font = New System.Drawing.Font("Segoe UI Light", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboxTableNum.Location = New System.Drawing.Point(1006, 431)
        Me.txtboxTableNum.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtboxTableNum.Name = "txtboxTableNum"
        Me.txtboxTableNum.ReadOnly = True
        Me.txtboxTableNum.Size = New System.Drawing.Size(323, 25)
        Me.txtboxTableNum.TabIndex = 4
        '
        'txtboxTotal
        '
        Me.txtboxTotal.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtboxTotal.Font = New System.Drawing.Font("Segoe UI Light", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboxTotal.Location = New System.Drawing.Point(1005, 572)
        Me.txtboxTotal.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtboxTotal.Name = "txtboxTotal"
        Me.txtboxTotal.ReadOnly = True
        Me.txtboxTotal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtboxTotal.Size = New System.Drawing.Size(323, 25)
        Me.txtboxTotal.TabIndex = 5
        Me.txtboxTotal.Text = "0"
        Me.txtboxTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(1003, 317)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 22)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Order Number:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(1005, 395)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(131, 22)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Table Number:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(1001, 525)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 22)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Total Price:"
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Aqua
        Me.btnClear.BackgroundImage = Global.Ordering_and_Billing_System_With_Inventory.My.Resources.Resources.clear_symbol_32px
        Me.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnClear.Location = New System.Drawing.Point(1385, 317)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(139, 82)
        Me.btnClear.TabIndex = 9
        Me.btnClear.Text = "Clear"
        Me.btnClear.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.Aqua
        Me.btnPrint.BackgroundImage = Global.Ordering_and_Billing_System_With_Inventory.My.Resources.Resources.billing_machine_32px
        Me.btnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnPrint.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.btnPrint.Location = New System.Drawing.Point(1385, 448)
        Me.btnPrint.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(139, 82)
        Me.btnPrint.TabIndex = 10
        Me.btnPrint.Text = "Print Bill"
        Me.btnPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.Aqua
        Me.btnSubmit.BackgroundImage = Global.Ordering_and_Billing_System_With_Inventory.My.Resources.Resources.submit_for_approval_32px
        Me.btnSubmit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubmit.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnSubmit.Location = New System.Drawing.Point(1385, 572)
        Me.btnSubmit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(139, 82)
        Me.btnSubmit.TabIndex = 11
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSubmit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Transparent
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnBack.Location = New System.Drawing.Point(25, 21)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(139, 64)
        Me.btnBack.TabIndex = 12
        Me.btnBack.Text = "Back"
        Me.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'ordersDataView
        '
        Me.ordersDataView.AllowUserToAddRows = False
        Me.ordersDataView.AllowUserToDeleteRows = False
        Me.ordersDataView.AutoGenerateColumns = False
        Me.ordersDataView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.ordersDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ordersDataView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.orderNum, Me.initialPrice, Me.totalPrice, Me.location, Me.menusType, Me.status, Me.discounted, Me.Action, Me.cancelOrderAction, Me.ordersID, Me.ListOfMenuDataGridViewTextBoxColumn, Me.ListOfPriceDataGridViewTextBoxColumn, Me.MenuQuantityDataGridViewTextBoxColumn, Me.CreatedDateTimeDataGridViewTextBoxColumn, Me.MenusIDDataGridViewTextBoxColumn})
        Me.ordersDataView.DataSource = Me.NamwahOrdersDataSetBindingSource
        Me.ordersDataView.Location = New System.Drawing.Point(25, 240)
        Me.ordersDataView.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ordersDataView.Name = "ordersDataView"
        Me.ordersDataView.ReadOnly = True
        Me.ordersDataView.RowHeadersWidth = 51
        Me.ordersDataView.RowTemplate.Height = 24
        Me.ordersDataView.Size = New System.Drawing.Size(927, 584)
        Me.ordersDataView.TabIndex = 13
        '
        'orderNum
        '
        Me.orderNum.DataPropertyName = "OrderNumber"
        Me.orderNum.HeaderText = "Order #"
        Me.orderNum.MinimumWidth = 6
        Me.orderNum.Name = "orderNum"
        Me.orderNum.ReadOnly = True
        Me.orderNum.Width = 125
        '
        'initialPrice
        '
        Me.initialPrice.DataPropertyName = "InitialPrice"
        Me.initialPrice.HeaderText = "InitialPrice"
        Me.initialPrice.MinimumWidth = 6
        Me.initialPrice.Name = "initialPrice"
        Me.initialPrice.ReadOnly = True
        Me.initialPrice.Width = 125
        '
        'totalPrice
        '
        Me.totalPrice.DataPropertyName = "TotalPrice"
        Me.totalPrice.HeaderText = "TotalPrice"
        Me.totalPrice.MinimumWidth = 6
        Me.totalPrice.Name = "totalPrice"
        Me.totalPrice.ReadOnly = True
        Me.totalPrice.Width = 125
        '
        'location
        '
        Me.location.DataPropertyName = "Location"
        Me.location.HeaderText = "Table"
        Me.location.MinimumWidth = 6
        Me.location.Name = "location"
        Me.location.ReadOnly = True
        Me.location.Width = 125
        '
        'menusType
        '
        Me.menusType.DataPropertyName = "MenusType"
        Me.menusType.HeaderText = "MenusType"
        Me.menusType.MinimumWidth = 6
        Me.menusType.Name = "menusType"
        Me.menusType.ReadOnly = True
        Me.menusType.Width = 125
        '
        'status
        '
        Me.status.DataPropertyName = "Status"
        Me.status.HeaderText = "Status"
        Me.status.MinimumWidth = 6
        Me.status.Name = "status"
        Me.status.ReadOnly = True
        Me.status.Width = 125
        '
        'discounted
        '
        Me.discounted.DataPropertyName = "Discounted"
        Me.discounted.HeaderText = "Discounted"
        Me.discounted.MinimumWidth = 6
        Me.discounted.Name = "discounted"
        Me.discounted.ReadOnly = True
        Me.discounted.Width = 125
        '
        'Action
        '
        Me.Action.HeaderText = "Action"
        Me.Action.MinimumWidth = 6
        Me.Action.Name = "Action"
        Me.Action.ReadOnly = True
        Me.Action.Text = "Select"
        Me.Action.ToolTipText = "Select"
        Me.Action.UseColumnTextForButtonValue = True
        Me.Action.Width = 125
        '
        'cancelOrderAction
        '
        Me.cancelOrderAction.HeaderText = "Action"
        Me.cancelOrderAction.MinimumWidth = 6
        Me.cancelOrderAction.Name = "cancelOrderAction"
        Me.cancelOrderAction.ReadOnly = True
        Me.cancelOrderAction.Text = "Cancel"
        Me.cancelOrderAction.ToolTipText = "Cancel"
        Me.cancelOrderAction.UseColumnTextForButtonValue = True
        Me.cancelOrderAction.Width = 125
        '
        'ordersID
        '
        Me.ordersID.DataPropertyName = "ID"
        Me.ordersID.HeaderText = "ID"
        Me.ordersID.MinimumWidth = 6
        Me.ordersID.Name = "ordersID"
        Me.ordersID.ReadOnly = True
        Me.ordersID.Visible = False
        Me.ordersID.Width = 125
        '
        'ListOfMenuDataGridViewTextBoxColumn
        '
        Me.ListOfMenuDataGridViewTextBoxColumn.DataPropertyName = "ListOfMenu"
        Me.ListOfMenuDataGridViewTextBoxColumn.HeaderText = "ListOfMenu"
        Me.ListOfMenuDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ListOfMenuDataGridViewTextBoxColumn.Name = "ListOfMenuDataGridViewTextBoxColumn"
        Me.ListOfMenuDataGridViewTextBoxColumn.ReadOnly = True
        Me.ListOfMenuDataGridViewTextBoxColumn.Visible = False
        Me.ListOfMenuDataGridViewTextBoxColumn.Width = 125
        '
        'ListOfPriceDataGridViewTextBoxColumn
        '
        Me.ListOfPriceDataGridViewTextBoxColumn.DataPropertyName = "ListOfPrice"
        Me.ListOfPriceDataGridViewTextBoxColumn.HeaderText = "ListOfPrice"
        Me.ListOfPriceDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ListOfPriceDataGridViewTextBoxColumn.Name = "ListOfPriceDataGridViewTextBoxColumn"
        Me.ListOfPriceDataGridViewTextBoxColumn.ReadOnly = True
        Me.ListOfPriceDataGridViewTextBoxColumn.Visible = False
        Me.ListOfPriceDataGridViewTextBoxColumn.Width = 125
        '
        'MenuQuantityDataGridViewTextBoxColumn
        '
        Me.MenuQuantityDataGridViewTextBoxColumn.DataPropertyName = "MenuQuantity"
        Me.MenuQuantityDataGridViewTextBoxColumn.HeaderText = "MenuQuantity"
        Me.MenuQuantityDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.MenuQuantityDataGridViewTextBoxColumn.Name = "MenuQuantityDataGridViewTextBoxColumn"
        Me.MenuQuantityDataGridViewTextBoxColumn.ReadOnly = True
        Me.MenuQuantityDataGridViewTextBoxColumn.Visible = False
        Me.MenuQuantityDataGridViewTextBoxColumn.Width = 125
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
        'NamwahOrdersDataSetBindingSource
        '
        Me.NamwahOrdersDataSetBindingSource.DataMember = "Orders"
        Me.NamwahOrdersDataSetBindingSource.DataSource = Me.NamwahOrdersDataSet
        Me.NamwahOrdersDataSetBindingSource.Filter = "Status='Pending'"
        '
        'NamwahOrdersDataSet
        '
        Me.NamwahOrdersDataSet.DataSetName = "namwahOrdersDataSet"
        Me.NamwahOrdersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OrdersTableAdapter
        '
        Me.OrdersTableAdapter.ClearBeforeFill = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(1003, 697)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 22)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Change:"
        '
        'txtboxChange
        '
        Me.txtboxChange.Font = New System.Drawing.Font("Segoe UI Light", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboxChange.Location = New System.Drawing.Point(1006, 740)
        Me.txtboxChange.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtboxChange.Name = "txtboxChange"
        Me.txtboxChange.ReadOnly = True
        Me.txtboxChange.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtboxChange.Size = New System.Drawing.Size(323, 32)
        Me.txtboxChange.TabIndex = 15
        Me.txtboxChange.Text = "0"
        Me.txtboxChange.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblBillNum
        '
        Me.lblBillNum.AutoSize = True
        Me.lblBillNum.BackColor = System.Drawing.Color.Transparent
        Me.lblBillNum.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBillNum.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblBillNum.Location = New System.Drawing.Point(1003, 240)
        Me.lblBillNum.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBillNum.Name = "lblBillNum"
        Me.lblBillNum.Size = New System.Drawing.Size(139, 22)
        Me.lblBillNum.TabIndex = 17
        Me.lblBillNum.Text = "Billing Number:"
        '
        'txtboxBillingNum
        '
        Me.txtboxBillingNum.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtboxBillingNum.Font = New System.Drawing.Font("Segoe UI Light", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboxBillingNum.Location = New System.Drawing.Point(1006, 278)
        Me.txtboxBillingNum.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtboxBillingNum.Name = "txtboxBillingNum"
        Me.txtboxBillingNum.ReadOnly = True
        Me.txtboxBillingNum.Size = New System.Drawing.Size(323, 25)
        Me.txtboxBillingNum.TabIndex = 16
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(337, 153)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(230, 40)
        Me.Label6.TabIndex = 44
        Me.Label6.Text = "ORDER LIST"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Light", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Location = New System.Drawing.Point(414, 164)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 47)
        Me.Label7.TabIndex = 45
        Me.Label7.Text = "..."
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Light", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label8.Location = New System.Drawing.Point(1129, 467)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 47)
        Me.Label8.TabIndex = 46
        Me.Label8.Text = "..."
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(972, 783)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(390, 26)
        Me.Label10.TabIndex = 47
        Me.Label10.Text = "________________________"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.InitialImage = Nothing
        Me.PictureBox3.Location = New System.Drawing.Point(1048, 21)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(159, 147)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 50
        Me.PictureBox3.TabStop = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label11.Location = New System.Drawing.Point(189, 66)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(167, 40)
        Me.Label11.TabIndex = 49
        Me.Label11.Text = "BILLING"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(169, 117)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(873, 33)
        Me.PictureBox1.TabIndex = 48
        Me.PictureBox1.TabStop = False
        '
        'PrintDialog1
        '
        Me.PrintDialog1.Document = Me.PrintDocument1
        Me.PrintDialog1.UseEXDialog = True
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'tbxOrderID
        '
        Me.tbxOrderID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbxOrderID.Font = New System.Drawing.Font("Segoe UI Light", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxOrderID.Location = New System.Drawing.Point(719, 168)
        Me.tbxOrderID.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbxOrderID.Name = "tbxOrderID"
        Me.tbxOrderID.ReadOnly = True
        Me.tbxOrderID.Size = New System.Drawing.Size(100, 25)
        Me.tbxOrderID.TabIndex = 51
        Me.tbxOrderID.Visible = False
        '
        'Billing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1600, 900)
        Me.Controls.Add(Me.tbxOrderID)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblBillNum)
        Me.Controls.Add(Me.txtboxBillingNum)
        Me.Controls.Add(Me.txtboxChange)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ordersDataView)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtboxTotal)
        Me.Controls.Add(Me.txtboxTableNum)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtboxPayments)
        Me.Controls.Add(Me.txtboxOrderNum)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximumSize = New System.Drawing.Size(1600, 900)
        Me.MinimumSize = New System.Drawing.Size(1280, 898)
        Me.Name = "Billing"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Billing"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.NamwahDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NamwahDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ordersDataView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NamwahOrdersDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NamwahOrdersDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NamwahDataSetBindingSource As BindingSource
    Friend WithEvents NamwahDataSet As namwahDataSet
    Friend WithEvents txtboxOrderNum As TextBox
    Friend WithEvents txtboxPayments As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtboxTableNum As TextBox
    Friend WithEvents txtboxTotal As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents ordersDataView As DataGridView
    Friend WithEvents NamwahOrdersDataSetBindingSource As BindingSource
    Friend WithEvents NamwahOrdersDataSet As namwahOrdersDataSet
    Friend WithEvents OrdersTableAdapter As namwahOrdersDataSetTableAdapters.OrdersTableAdapter
    Friend WithEvents Label5 As Label
    Friend WithEvents txtboxChange As TextBox
    Friend WithEvents lblBillNum As Label
    Friend WithEvents txtboxBillingNum As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label11 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents tbxOrderID As TextBox
    Friend WithEvents orderNum As DataGridViewTextBoxColumn
    Friend WithEvents initialPrice As DataGridViewTextBoxColumn
    Friend WithEvents totalPrice As DataGridViewTextBoxColumn
    Friend WithEvents location As DataGridViewTextBoxColumn
    Friend WithEvents menusType As DataGridViewTextBoxColumn
    Friend WithEvents status As DataGridViewTextBoxColumn
    Friend WithEvents discounted As DataGridViewTextBoxColumn
    Friend WithEvents Action As DataGridViewButtonColumn
    Friend WithEvents cancelOrderAction As DataGridViewButtonColumn
    Friend WithEvents ordersID As DataGridViewTextBoxColumn
    Friend WithEvents ListOfMenuDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ListOfPriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MenuQuantityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CreatedDateTimeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MenusIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
