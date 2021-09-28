<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class History
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(History))
        Me.BillingDSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BillingDS = New Ordering_and_Billing_System_With_Inventory.billingDS()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btnOrderExport = New System.Windows.Forms.Button()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.OrderNumberDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ListOfMenuDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ListOfPriceDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InitialPriceDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalPriceDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LocationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenusTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuQuantityDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiscountedDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrdersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrdersDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrdersDataSet = New Ordering_and_Billing_System_With_Inventory.ordersDataSet()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.btnReservationExport = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MobileNumDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumOfPeopleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiscountedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SchedDateTimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReservationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReservationDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReservationDataSet = New Ordering_and_Billing_System_With_Inventory.reservationDataSet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.btnDeliveryExport = New System.Windows.Forms.Button()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.DeliveryNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrderNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ListOfMenuDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ListOfPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuQuantityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InitialPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiscountedDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerNameDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MobileNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddressDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DeliveryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DeliveryDSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DeliveryDS = New Ordering_and_Billing_System_With_Inventory.DeliveryDS()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BillingsTableAdapter = New Ordering_and_Billing_System_With_Inventory.billingDSTableAdapters.BillingsTableAdapter()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.ReservationTableAdapter = New Ordering_and_Billing_System_With_Inventory.reservationDataSetTableAdapters.ReservationTableAdapter()
        Me.DeliveryTableAdapter = New Ordering_and_Billing_System_With_Inventory.DeliveryDSTableAdapters.DeliveryTableAdapter()
        Me.OrdersTableAdapter = New Ordering_and_Billing_System_With_Inventory.ordersDataSetTableAdapters.OrdersTableAdapter()
        CType(Me.BillingDSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BillingDS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrdersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrdersDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrdersDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReservationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReservationDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReservationDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DeliveryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DeliveryDSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DeliveryDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BillingDSBindingSource
        '
        Me.BillingDSBindingSource.DataMember = "Billings"
        Me.BillingDSBindingSource.DataSource = Me.BillingDS
        '
        'BillingDS
        '
        Me.BillingDS.DataSetName = "billingDS"
        Me.BillingDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.btnOrderExport)
        Me.TabPage2.Controls.Add(Me.DataGridView3)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Location = New System.Drawing.Point(124, 4)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TabPage2.Size = New System.Drawing.Size(1234, 428)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Orders"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btnOrderExport
        '
        Me.btnOrderExport.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOrderExport.Location = New System.Drawing.Point(854, 14)
        Me.btnOrderExport.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnOrderExport.Name = "btnOrderExport"
        Me.btnOrderExport.Size = New System.Drawing.Size(115, 32)
        Me.btnOrderExport.TabIndex = 68
        Me.btnOrderExport.Text = "Print"
        Me.btnOrderExport.UseVisualStyleBackColor = True
        '
        'DataGridView3
        '
        Me.DataGridView3.AllowUserToDeleteRows = False
        Me.DataGridView3.AutoGenerateColumns = False
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.OrderNumberDataGridViewTextBoxColumn1, Me.ListOfMenuDataGridViewTextBoxColumn1, Me.ListOfPriceDataGridViewTextBoxColumn1, Me.InitialPriceDataGridViewTextBoxColumn1, Me.TotalPriceDataGridViewTextBoxColumn1, Me.LocationDataGridViewTextBoxColumn, Me.MenusTypeDataGridViewTextBoxColumn, Me.MenuQuantityDataGridViewTextBoxColumn1, Me.StatusDataGridViewTextBoxColumn1, Me.DiscountedDataGridViewTextBoxColumn2})
        Me.DataGridView3.DataSource = Me.OrdersBindingSource
        Me.DataGridView3.Location = New System.Drawing.Point(32, 58)
        Me.DataGridView3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.ReadOnly = True
        Me.DataGridView3.RowHeadersWidth = 51
        Me.DataGridView3.RowTemplate.Height = 24
        Me.DataGridView3.Size = New System.Drawing.Size(1178, 354)
        Me.DataGridView3.TabIndex = 67
        '
        'OrderNumberDataGridViewTextBoxColumn1
        '
        Me.OrderNumberDataGridViewTextBoxColumn1.DataPropertyName = "OrderNumber"
        Me.OrderNumberDataGridViewTextBoxColumn1.HeaderText = "Order Number"
        Me.OrderNumberDataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.OrderNumberDataGridViewTextBoxColumn1.Name = "OrderNumberDataGridViewTextBoxColumn1"
        Me.OrderNumberDataGridViewTextBoxColumn1.ReadOnly = True
        Me.OrderNumberDataGridViewTextBoxColumn1.Width = 125
        '
        'ListOfMenuDataGridViewTextBoxColumn1
        '
        Me.ListOfMenuDataGridViewTextBoxColumn1.DataPropertyName = "ListOfMenu"
        Me.ListOfMenuDataGridViewTextBoxColumn1.HeaderText = "List Of Menu"
        Me.ListOfMenuDataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.ListOfMenuDataGridViewTextBoxColumn1.Name = "ListOfMenuDataGridViewTextBoxColumn1"
        Me.ListOfMenuDataGridViewTextBoxColumn1.ReadOnly = True
        Me.ListOfMenuDataGridViewTextBoxColumn1.Width = 125
        '
        'ListOfPriceDataGridViewTextBoxColumn1
        '
        Me.ListOfPriceDataGridViewTextBoxColumn1.DataPropertyName = "ListOfPrice"
        Me.ListOfPriceDataGridViewTextBoxColumn1.HeaderText = "Menu Price List"
        Me.ListOfPriceDataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.ListOfPriceDataGridViewTextBoxColumn1.Name = "ListOfPriceDataGridViewTextBoxColumn1"
        Me.ListOfPriceDataGridViewTextBoxColumn1.ReadOnly = True
        Me.ListOfPriceDataGridViewTextBoxColumn1.Width = 125
        '
        'InitialPriceDataGridViewTextBoxColumn1
        '
        Me.InitialPriceDataGridViewTextBoxColumn1.DataPropertyName = "InitialPrice"
        Me.InitialPriceDataGridViewTextBoxColumn1.HeaderText = "Initial Price"
        Me.InitialPriceDataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.InitialPriceDataGridViewTextBoxColumn1.Name = "InitialPriceDataGridViewTextBoxColumn1"
        Me.InitialPriceDataGridViewTextBoxColumn1.ReadOnly = True
        Me.InitialPriceDataGridViewTextBoxColumn1.Width = 125
        '
        'TotalPriceDataGridViewTextBoxColumn1
        '
        Me.TotalPriceDataGridViewTextBoxColumn1.DataPropertyName = "TotalPrice"
        Me.TotalPriceDataGridViewTextBoxColumn1.HeaderText = "Total Price"
        Me.TotalPriceDataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.TotalPriceDataGridViewTextBoxColumn1.Name = "TotalPriceDataGridViewTextBoxColumn1"
        Me.TotalPriceDataGridViewTextBoxColumn1.ReadOnly = True
        Me.TotalPriceDataGridViewTextBoxColumn1.Width = 125
        '
        'LocationDataGridViewTextBoxColumn
        '
        Me.LocationDataGridViewTextBoxColumn.DataPropertyName = "Location"
        Me.LocationDataGridViewTextBoxColumn.HeaderText = "Table Number"
        Me.LocationDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.LocationDataGridViewTextBoxColumn.Name = "LocationDataGridViewTextBoxColumn"
        Me.LocationDataGridViewTextBoxColumn.ReadOnly = True
        Me.LocationDataGridViewTextBoxColumn.Width = 125
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
        'MenuQuantityDataGridViewTextBoxColumn1
        '
        Me.MenuQuantityDataGridViewTextBoxColumn1.DataPropertyName = "MenuQuantity"
        Me.MenuQuantityDataGridViewTextBoxColumn1.HeaderText = "Menu Quantity"
        Me.MenuQuantityDataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.MenuQuantityDataGridViewTextBoxColumn1.Name = "MenuQuantityDataGridViewTextBoxColumn1"
        Me.MenuQuantityDataGridViewTextBoxColumn1.ReadOnly = True
        Me.MenuQuantityDataGridViewTextBoxColumn1.Width = 125
        '
        'StatusDataGridViewTextBoxColumn1
        '
        Me.StatusDataGridViewTextBoxColumn1.DataPropertyName = "Status"
        Me.StatusDataGridViewTextBoxColumn1.HeaderText = "Status"
        Me.StatusDataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.StatusDataGridViewTextBoxColumn1.Name = "StatusDataGridViewTextBoxColumn1"
        Me.StatusDataGridViewTextBoxColumn1.ReadOnly = True
        Me.StatusDataGridViewTextBoxColumn1.Width = 125
        '
        'DiscountedDataGridViewTextBoxColumn2
        '
        Me.DiscountedDataGridViewTextBoxColumn2.DataPropertyName = "Discounted"
        Me.DiscountedDataGridViewTextBoxColumn2.HeaderText = "Discounted"
        Me.DiscountedDataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DiscountedDataGridViewTextBoxColumn2.Name = "DiscountedDataGridViewTextBoxColumn2"
        Me.DiscountedDataGridViewTextBoxColumn2.ReadOnly = True
        Me.DiscountedDataGridViewTextBoxColumn2.Width = 125
        '
        'OrdersBindingSource
        '
        Me.OrdersBindingSource.DataMember = "Orders"
        Me.OrdersBindingSource.DataSource = Me.OrdersDataSetBindingSource
        '
        'OrdersDataSetBindingSource
        '
        Me.OrdersDataSetBindingSource.DataSource = Me.OrdersDataSet
        Me.OrdersDataSetBindingSource.Position = 0
        '
        'OrdersDataSet
        '
        Me.OrdersDataSet.DataSetName = "ordersDataSet"
        Me.OrdersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 17.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(27, 20)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 25)
        Me.Label2.TabIndex = 60
        Me.Label2.Text = "ORDERS"
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.btnReservationExport)
        Me.TabPage4.Controls.Add(Me.DataGridView1)
        Me.TabPage4.Controls.Add(Me.Label1)
        Me.TabPage4.Location = New System.Drawing.Point(124, 4)
        Me.TabPage4.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(1234, 428)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Reservation"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'btnReservationExport
        '
        Me.btnReservationExport.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReservationExport.Location = New System.Drawing.Point(852, 18)
        Me.btnReservationExport.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnReservationExport.Name = "btnReservationExport"
        Me.btnReservationExport.Size = New System.Drawing.Size(115, 32)
        Me.btnReservationExport.TabIndex = 69
        Me.btnReservationExport.Text = "Print"
        Me.btnReservationExport.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodeDataGridViewTextBoxColumn, Me.CustomerNameDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn, Me.MobileNumDataGridViewTextBoxColumn, Me.TableNumberDataGridViewTextBoxColumn, Me.NumOfPeopleDataGridViewTextBoxColumn, Me.DiscountedDataGridViewTextBoxColumn, Me.PriceDataGridViewTextBoxColumn, Me.SchedDateTimeDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ReservationBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(32, 58)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1177, 354)
        Me.DataGridView1.TabIndex = 65
        '
        'CodeDataGridViewTextBoxColumn
        '
        Me.CodeDataGridViewTextBoxColumn.DataPropertyName = "Code"
        Me.CodeDataGridViewTextBoxColumn.HeaderText = "Reservation Code"
        Me.CodeDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CodeDataGridViewTextBoxColumn.Name = "CodeDataGridViewTextBoxColumn"
        Me.CodeDataGridViewTextBoxColumn.ReadOnly = True
        Me.CodeDataGridViewTextBoxColumn.Width = 125
        '
        'CustomerNameDataGridViewTextBoxColumn
        '
        Me.CustomerNameDataGridViewTextBoxColumn.DataPropertyName = "CustomerName"
        Me.CustomerNameDataGridViewTextBoxColumn.HeaderText = "Customer"
        Me.CustomerNameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CustomerNameDataGridViewTextBoxColumn.Name = "CustomerNameDataGridViewTextBoxColumn"
        Me.CustomerNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.CustomerNameDataGridViewTextBoxColumn.Width = 125
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "Email"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "Email"
        Me.EmailDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        Me.EmailDataGridViewTextBoxColumn.ReadOnly = True
        Me.EmailDataGridViewTextBoxColumn.Width = 125
        '
        'AddressDataGridViewTextBoxColumn
        '
        Me.AddressDataGridViewTextBoxColumn.DataPropertyName = "Address"
        Me.AddressDataGridViewTextBoxColumn.HeaderText = "Address"
        Me.AddressDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.AddressDataGridViewTextBoxColumn.Name = "AddressDataGridViewTextBoxColumn"
        Me.AddressDataGridViewTextBoxColumn.ReadOnly = True
        Me.AddressDataGridViewTextBoxColumn.Width = 125
        '
        'MobileNumDataGridViewTextBoxColumn
        '
        Me.MobileNumDataGridViewTextBoxColumn.DataPropertyName = "MobileNum"
        Me.MobileNumDataGridViewTextBoxColumn.HeaderText = "Mobile"
        Me.MobileNumDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.MobileNumDataGridViewTextBoxColumn.Name = "MobileNumDataGridViewTextBoxColumn"
        Me.MobileNumDataGridViewTextBoxColumn.ReadOnly = True
        Me.MobileNumDataGridViewTextBoxColumn.Width = 125
        '
        'TableNumberDataGridViewTextBoxColumn
        '
        Me.TableNumberDataGridViewTextBoxColumn.DataPropertyName = "TableNumber"
        Me.TableNumberDataGridViewTextBoxColumn.HeaderText = "Table Number"
        Me.TableNumberDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TableNumberDataGridViewTextBoxColumn.Name = "TableNumberDataGridViewTextBoxColumn"
        Me.TableNumberDataGridViewTextBoxColumn.ReadOnly = True
        Me.TableNumberDataGridViewTextBoxColumn.Width = 125
        '
        'NumOfPeopleDataGridViewTextBoxColumn
        '
        Me.NumOfPeopleDataGridViewTextBoxColumn.DataPropertyName = "NumOfPeople"
        Me.NumOfPeopleDataGridViewTextBoxColumn.HeaderText = "How many people?"
        Me.NumOfPeopleDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NumOfPeopleDataGridViewTextBoxColumn.Name = "NumOfPeopleDataGridViewTextBoxColumn"
        Me.NumOfPeopleDataGridViewTextBoxColumn.ReadOnly = True
        Me.NumOfPeopleDataGridViewTextBoxColumn.Width = 125
        '
        'DiscountedDataGridViewTextBoxColumn
        '
        Me.DiscountedDataGridViewTextBoxColumn.DataPropertyName = "Discounted"
        Me.DiscountedDataGridViewTextBoxColumn.HeaderText = "Discounted"
        Me.DiscountedDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DiscountedDataGridViewTextBoxColumn.Name = "DiscountedDataGridViewTextBoxColumn"
        Me.DiscountedDataGridViewTextBoxColumn.ReadOnly = True
        Me.DiscountedDataGridViewTextBoxColumn.Width = 125
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
        'SchedDateTimeDataGridViewTextBoxColumn
        '
        Me.SchedDateTimeDataGridViewTextBoxColumn.DataPropertyName = "SchedDateTime"
        Me.SchedDateTimeDataGridViewTextBoxColumn.HeaderText = "SchedDateTime"
        Me.SchedDateTimeDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.SchedDateTimeDataGridViewTextBoxColumn.Name = "SchedDateTimeDataGridViewTextBoxColumn"
        Me.SchedDateTimeDataGridViewTextBoxColumn.ReadOnly = True
        Me.SchedDateTimeDataGridViewTextBoxColumn.Visible = False
        Me.SchedDateTimeDataGridViewTextBoxColumn.Width = 125
        '
        'ReservationBindingSource
        '
        Me.ReservationBindingSource.DataMember = "Reservation"
        Me.ReservationBindingSource.DataSource = Me.ReservationDataSetBindingSource
        '
        'ReservationDataSetBindingSource
        '
        Me.ReservationDataSetBindingSource.DataSource = Me.ReservationDataSet
        Me.ReservationDataSetBindingSource.Position = 0
        '
        'ReservationDataSet
        '
        Me.ReservationDataSet.DataSetName = "reservationDataSet"
        Me.ReservationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 17.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(27, 20)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(174, 25)
        Me.Label1.TabIndex = 64
        Me.Label1.Text = "RESERVATION"
        '
        'TabControl1
        '
        Me.TabControl1.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed
        Me.TabControl1.ItemSize = New System.Drawing.Size(30, 120)
        Me.TabControl1.Location = New System.Drawing.Point(53, 220)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1362, 436)
        Me.TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.TabControl1.TabIndex = 72
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.btnDeliveryExport)
        Me.TabPage3.Controls.Add(Me.DataGridView2)
        Me.TabPage3.Controls.Add(Me.Label3)
        Me.TabPage3.Location = New System.Drawing.Point(124, 4)
        Me.TabPage3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(1234, 428)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Delivery"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'btnDeliveryExport
        '
        Me.btnDeliveryExport.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeliveryExport.Location = New System.Drawing.Point(848, 14)
        Me.btnDeliveryExport.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnDeliveryExport.Name = "btnDeliveryExport"
        Me.btnDeliveryExport.Size = New System.Drawing.Size(115, 32)
        Me.btnDeliveryExport.TabIndex = 69
        Me.btnDeliveryExport.Text = "Print"
        Me.btnDeliveryExport.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DeliveryNumberDataGridViewTextBoxColumn, Me.OrderNumberDataGridViewTextBoxColumn, Me.ListOfMenuDataGridViewTextBoxColumn, Me.ListOfPriceDataGridViewTextBoxColumn, Me.MenuQuantityDataGridViewTextBoxColumn, Me.InitialPriceDataGridViewTextBoxColumn, Me.TotalPriceDataGridViewTextBoxColumn, Me.StatusDataGridViewTextBoxColumn, Me.DiscountedDataGridViewTextBoxColumn1, Me.CustomerNameDataGridViewTextBoxColumn1, Me.MobileNumberDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn1})
        Me.DataGridView2.DataSource = Me.DeliveryBindingSource
        Me.DataGridView2.Location = New System.Drawing.Point(32, 57)
        Me.DataGridView2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.RowHeadersWidth = 51
        Me.DataGridView2.RowTemplate.Height = 24
        Me.DataGridView2.Size = New System.Drawing.Size(1177, 354)
        Me.DataGridView2.TabIndex = 66
        '
        'DeliveryNumberDataGridViewTextBoxColumn
        '
        Me.DeliveryNumberDataGridViewTextBoxColumn.DataPropertyName = "DeliveryNumber"
        Me.DeliveryNumberDataGridViewTextBoxColumn.HeaderText = "Delivery Number"
        Me.DeliveryNumberDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DeliveryNumberDataGridViewTextBoxColumn.Name = "DeliveryNumberDataGridViewTextBoxColumn"
        Me.DeliveryNumberDataGridViewTextBoxColumn.ReadOnly = True
        Me.DeliveryNumberDataGridViewTextBoxColumn.Width = 125
        '
        'OrderNumberDataGridViewTextBoxColumn
        '
        Me.OrderNumberDataGridViewTextBoxColumn.DataPropertyName = "OrderNumber"
        Me.OrderNumberDataGridViewTextBoxColumn.HeaderText = "Order Number"
        Me.OrderNumberDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.OrderNumberDataGridViewTextBoxColumn.Name = "OrderNumberDataGridViewTextBoxColumn"
        Me.OrderNumberDataGridViewTextBoxColumn.ReadOnly = True
        Me.OrderNumberDataGridViewTextBoxColumn.Width = 125
        '
        'ListOfMenuDataGridViewTextBoxColumn
        '
        Me.ListOfMenuDataGridViewTextBoxColumn.DataPropertyName = "ListOfMenu"
        Me.ListOfMenuDataGridViewTextBoxColumn.HeaderText = "List Of Menu"
        Me.ListOfMenuDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ListOfMenuDataGridViewTextBoxColumn.Name = "ListOfMenuDataGridViewTextBoxColumn"
        Me.ListOfMenuDataGridViewTextBoxColumn.ReadOnly = True
        Me.ListOfMenuDataGridViewTextBoxColumn.Width = 125
        '
        'ListOfPriceDataGridViewTextBoxColumn
        '
        Me.ListOfPriceDataGridViewTextBoxColumn.DataPropertyName = "ListOfPrice"
        Me.ListOfPriceDataGridViewTextBoxColumn.HeaderText = "Menu Price List"
        Me.ListOfPriceDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ListOfPriceDataGridViewTextBoxColumn.Name = "ListOfPriceDataGridViewTextBoxColumn"
        Me.ListOfPriceDataGridViewTextBoxColumn.ReadOnly = True
        Me.ListOfPriceDataGridViewTextBoxColumn.Width = 125
        '
        'MenuQuantityDataGridViewTextBoxColumn
        '
        Me.MenuQuantityDataGridViewTextBoxColumn.DataPropertyName = "MenuQuantity"
        Me.MenuQuantityDataGridViewTextBoxColumn.HeaderText = "Menu Quantity"
        Me.MenuQuantityDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.MenuQuantityDataGridViewTextBoxColumn.Name = "MenuQuantityDataGridViewTextBoxColumn"
        Me.MenuQuantityDataGridViewTextBoxColumn.ReadOnly = True
        Me.MenuQuantityDataGridViewTextBoxColumn.Width = 125
        '
        'InitialPriceDataGridViewTextBoxColumn
        '
        Me.InitialPriceDataGridViewTextBoxColumn.DataPropertyName = "InitialPrice"
        Me.InitialPriceDataGridViewTextBoxColumn.HeaderText = "Initial Price"
        Me.InitialPriceDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.InitialPriceDataGridViewTextBoxColumn.Name = "InitialPriceDataGridViewTextBoxColumn"
        Me.InitialPriceDataGridViewTextBoxColumn.ReadOnly = True
        Me.InitialPriceDataGridViewTextBoxColumn.Width = 125
        '
        'TotalPriceDataGridViewTextBoxColumn
        '
        Me.TotalPriceDataGridViewTextBoxColumn.DataPropertyName = "TotalPrice"
        Me.TotalPriceDataGridViewTextBoxColumn.HeaderText = "Total Price"
        Me.TotalPriceDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TotalPriceDataGridViewTextBoxColumn.Name = "TotalPriceDataGridViewTextBoxColumn"
        Me.TotalPriceDataGridViewTextBoxColumn.ReadOnly = True
        Me.TotalPriceDataGridViewTextBoxColumn.Width = 125
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
        'DiscountedDataGridViewTextBoxColumn1
        '
        Me.DiscountedDataGridViewTextBoxColumn1.DataPropertyName = "Discounted"
        Me.DiscountedDataGridViewTextBoxColumn1.HeaderText = "Discounted"
        Me.DiscountedDataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DiscountedDataGridViewTextBoxColumn1.Name = "DiscountedDataGridViewTextBoxColumn1"
        Me.DiscountedDataGridViewTextBoxColumn1.ReadOnly = True
        Me.DiscountedDataGridViewTextBoxColumn1.Width = 125
        '
        'CustomerNameDataGridViewTextBoxColumn1
        '
        Me.CustomerNameDataGridViewTextBoxColumn1.DataPropertyName = "CustomerName"
        Me.CustomerNameDataGridViewTextBoxColumn1.HeaderText = "Customer"
        Me.CustomerNameDataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.CustomerNameDataGridViewTextBoxColumn1.Name = "CustomerNameDataGridViewTextBoxColumn1"
        Me.CustomerNameDataGridViewTextBoxColumn1.ReadOnly = True
        Me.CustomerNameDataGridViewTextBoxColumn1.Width = 125
        '
        'MobileNumberDataGridViewTextBoxColumn
        '
        Me.MobileNumberDataGridViewTextBoxColumn.DataPropertyName = "MobileNumber"
        Me.MobileNumberDataGridViewTextBoxColumn.HeaderText = "Mobile"
        Me.MobileNumberDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.MobileNumberDataGridViewTextBoxColumn.Name = "MobileNumberDataGridViewTextBoxColumn"
        Me.MobileNumberDataGridViewTextBoxColumn.ReadOnly = True
        Me.MobileNumberDataGridViewTextBoxColumn.Width = 125
        '
        'AddressDataGridViewTextBoxColumn1
        '
        Me.AddressDataGridViewTextBoxColumn1.DataPropertyName = "Address"
        Me.AddressDataGridViewTextBoxColumn1.HeaderText = "Address"
        Me.AddressDataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.AddressDataGridViewTextBoxColumn1.Name = "AddressDataGridViewTextBoxColumn1"
        Me.AddressDataGridViewTextBoxColumn1.ReadOnly = True
        Me.AddressDataGridViewTextBoxColumn1.Width = 125
        '
        'DeliveryBindingSource
        '
        Me.DeliveryBindingSource.DataMember = "Delivery"
        Me.DeliveryBindingSource.DataSource = Me.DeliveryDSBindingSource
        '
        'DeliveryDSBindingSource
        '
        Me.DeliveryDSBindingSource.DataSource = Me.DeliveryDS
        Me.DeliveryDSBindingSource.Position = 0
        '
        'DeliveryDS
        '
        Me.DeliveryDS.DataSetName = "DeliveryDS"
        Me.DeliveryDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 17.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(27, 20)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(130, 25)
        Me.Label3.TabIndex = 63
        Me.Label3.Text = "DELIVERY"
        '
        'BillingsTableAdapter
        '
        Me.BillingsTableAdapter.ClearBeforeFill = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label11.Location = New System.Drawing.Point(114, 108)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(176, 40)
        Me.Label11.TabIndex = 70
        Me.Label11.Text = "HISTORY"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(245, 119)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1062, 27)
        Me.PictureBox1.TabIndex = 69
        Me.PictureBox1.TabStop = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Transparent
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnBack.Location = New System.Drawing.Point(26, 32)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(104, 52)
        Me.btnBack.TabIndex = 68
        Me.btnBack.Text = "Back"
        Me.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.InitialImage = Nothing
        Me.PictureBox3.Location = New System.Drawing.Point(1132, 67)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(119, 119)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 71
        Me.PictureBox3.TabStop = False
        '
        'ReservationTableAdapter
        '
        Me.ReservationTableAdapter.ClearBeforeFill = True
        '
        'DeliveryTableAdapter
        '
        Me.DeliveryTableAdapter.ClearBeforeFill = True
        '
        'OrdersTableAdapter
        '
        Me.OrdersTableAdapter.ClearBeforeFill = True
        '
        'History
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1600, 900)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnBack)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MaximumSize = New System.Drawing.Size(1600, 900)
        Me.MinimumSize = New System.Drawing.Size(1198, 730)
        Me.Name = "History"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "History"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.BillingDSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BillingDS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrdersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrdersDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrdersDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReservationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReservationDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReservationDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DeliveryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DeliveryDSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DeliveryDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BillingDSBindingSource As BindingSource
    Friend WithEvents BillingDS As billingDS
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label2 As Label
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Label3 As Label
    Friend WithEvents BillingsTableAdapter As billingDSTableAdapters.BillingsTableAdapter
    Friend WithEvents Label11 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnBack As Button
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ReservationDataSetBindingSource As BindingSource
    Friend WithEvents ReservationDataSet As reservationDataSet
    Friend WithEvents Label1 As Label
    Friend WithEvents ReservationBindingSource As BindingSource
    Friend WithEvents ReservationTableAdapter As reservationDataSetTableAdapters.ReservationTableAdapter
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents DeliveryDSBindingSource As BindingSource
    Friend WithEvents DeliveryDS As DeliveryDS
    Friend WithEvents DeliveryBindingSource As BindingSource
    Friend WithEvents DeliveryTableAdapter As DeliveryDSTableAdapters.DeliveryTableAdapter
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents OrdersDataSetBindingSource As BindingSource
    Friend WithEvents OrdersDataSet As ordersDataSet
    Friend WithEvents OrdersBindingSource As BindingSource
    Friend WithEvents OrdersTableAdapter As ordersDataSetTableAdapters.OrdersTableAdapter
    Friend WithEvents btnOrderExport As Button
    Friend WithEvents btnReservationExport As Button
    Friend WithEvents btnDeliveryExport As Button
    Friend WithEvents OrderNumberDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents ListOfMenuDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents ListOfPriceDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents InitialPriceDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents TotalPriceDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents LocationDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MenusTypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MenuQuantityDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DiscountedDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents CodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustomerNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MobileNumDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TableNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NumOfPeopleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DiscountedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SchedDateTimeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DeliveryNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OrderNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ListOfMenuDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ListOfPriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MenuQuantityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents InitialPriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalPriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DiscountedDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents CustomerNameDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents MobileNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
End Class
