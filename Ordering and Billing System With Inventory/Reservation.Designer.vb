<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reservation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Reservation))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.reservationDataGrid = New System.Windows.Forms.DataGridView()
        Me.reservationID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MobileNumDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumOfPeopleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiscountedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DownPaymentDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EventName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EventType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SchedDateTimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CreatedDateTimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cancelBtn = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.completBtn = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.ReservationDSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReservationDS = New Ordering_and_Billing_System_With_Inventory.reservationDS()
        Me.ReservationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.cbxEventType = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.tbxEventName = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tbxDownPayment = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tbxAmount = New System.Windows.Forms.TextBox()
        Me.peopleCount = New System.Windows.Forms.NumericUpDown()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.schedDateTime = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbxTableNum = New System.Windows.Forms.TextBox()
        Me.tbxMobileNum = New System.Windows.Forms.TextBox()
        Me.tbxAddress = New System.Windows.Forms.TextBox()
        Me.tbxEmail = New System.Windows.Forms.TextBox()
        Me.tbxName = New System.Windows.Forms.TextBox()
        Me.tbxCode = New System.Windows.Forms.TextBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ReservationTableAdapter = New Ordering_and_Billing_System_With_Inventory.reservationDSTableAdapters.ReservationTableAdapter()
        Me.Panel1.SuspendLayout()
        CType(Me.reservationDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReservationDSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReservationDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReservationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.peopleCount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.reservationDataGrid)
        Me.Panel1.Location = New System.Drawing.Point(36, 183)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1200, 538)
        Me.Panel1.TabIndex = 0
        '
        'reservationDataGrid
        '
        Me.reservationDataGrid.AllowUserToAddRows = False
        Me.reservationDataGrid.AllowUserToDeleteRows = False
        Me.reservationDataGrid.AutoGenerateColumns = False
        Me.reservationDataGrid.BackgroundColor = System.Drawing.Color.White
        Me.reservationDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.reservationDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.reservationDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.reservationID, Me.CodeDataGridViewTextBoxColumn, Me.CustomerNameDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn, Me.MobileNumDataGridViewTextBoxColumn, Me.TableNumberDataGridViewTextBoxColumn, Me.NumOfPeopleDataGridViewTextBoxColumn, Me.DiscountedDataGridViewTextBoxColumn, Me.PriceDataGridViewTextBoxColumn, Me.DownPaymentDataGridViewTextBoxColumn, Me.StatusDataGridViewTextBoxColumn, Me.EventName, Me.EventType, Me.SchedDateTimeDataGridViewTextBoxColumn, Me.CreatedDateTimeDataGridViewTextBoxColumn, Me.cancelBtn, Me.completBtn})
        Me.reservationDataGrid.DataSource = Me.ReservationDSBindingSource
        Me.reservationDataGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.reservationDataGrid.Location = New System.Drawing.Point(0, 0)
        Me.reservationDataGrid.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.reservationDataGrid.MaximumSize = New System.Drawing.Size(1500, 800)
        Me.reservationDataGrid.MinimumSize = New System.Drawing.Size(900, 400)
        Me.reservationDataGrid.Name = "reservationDataGrid"
        Me.reservationDataGrid.ReadOnly = True
        Me.reservationDataGrid.RowHeadersWidth = 51
        Me.reservationDataGrid.RowTemplate.Height = 24
        Me.reservationDataGrid.Size = New System.Drawing.Size(1200, 538)
        Me.reservationDataGrid.TabIndex = 0
        '
        'reservationID
        '
        Me.reservationID.DataPropertyName = "ID"
        Me.reservationID.HeaderText = "ID"
        Me.reservationID.MinimumWidth = 6
        Me.reservationID.Name = "reservationID"
        Me.reservationID.ReadOnly = True
        Me.reservationID.Visible = False
        Me.reservationID.Width = 125
        '
        'CodeDataGridViewTextBoxColumn
        '
        Me.CodeDataGridViewTextBoxColumn.DataPropertyName = "Code"
        Me.CodeDataGridViewTextBoxColumn.HeaderText = "Code"
        Me.CodeDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CodeDataGridViewTextBoxColumn.Name = "CodeDataGridViewTextBoxColumn"
        Me.CodeDataGridViewTextBoxColumn.ReadOnly = True
        Me.CodeDataGridViewTextBoxColumn.Width = 125
        '
        'CustomerNameDataGridViewTextBoxColumn
        '
        Me.CustomerNameDataGridViewTextBoxColumn.DataPropertyName = "CustomerName"
        Me.CustomerNameDataGridViewTextBoxColumn.HeaderText = "CustomerName"
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
        Me.MobileNumDataGridViewTextBoxColumn.HeaderText = "MobileNum"
        Me.MobileNumDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.MobileNumDataGridViewTextBoxColumn.Name = "MobileNumDataGridViewTextBoxColumn"
        Me.MobileNumDataGridViewTextBoxColumn.ReadOnly = True
        Me.MobileNumDataGridViewTextBoxColumn.Width = 125
        '
        'TableNumberDataGridViewTextBoxColumn
        '
        Me.TableNumberDataGridViewTextBoxColumn.DataPropertyName = "TableNumber"
        Me.TableNumberDataGridViewTextBoxColumn.HeaderText = "TableNumber"
        Me.TableNumberDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TableNumberDataGridViewTextBoxColumn.Name = "TableNumberDataGridViewTextBoxColumn"
        Me.TableNumberDataGridViewTextBoxColumn.ReadOnly = True
        Me.TableNumberDataGridViewTextBoxColumn.Width = 125
        '
        'NumOfPeopleDataGridViewTextBoxColumn
        '
        Me.NumOfPeopleDataGridViewTextBoxColumn.DataPropertyName = "NumOfPeople"
        Me.NumOfPeopleDataGridViewTextBoxColumn.HeaderText = "NumOfPeople"
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
        Me.DiscountedDataGridViewTextBoxColumn.Visible = False
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
        'DownPaymentDataGridViewTextBoxColumn
        '
        Me.DownPaymentDataGridViewTextBoxColumn.DataPropertyName = "DownPayment"
        Me.DownPaymentDataGridViewTextBoxColumn.HeaderText = "DownPayment"
        Me.DownPaymentDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DownPaymentDataGridViewTextBoxColumn.Name = "DownPaymentDataGridViewTextBoxColumn"
        Me.DownPaymentDataGridViewTextBoxColumn.ReadOnly = True
        Me.DownPaymentDataGridViewTextBoxColumn.Width = 125
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
        'EventName
        '
        Me.EventName.DataPropertyName = "EventName"
        Me.EventName.HeaderText = "Event Name"
        Me.EventName.MinimumWidth = 6
        Me.EventName.Name = "EventName"
        Me.EventName.ReadOnly = True
        Me.EventName.Width = 125
        '
        'EventType
        '
        Me.EventType.DataPropertyName = "EventType"
        Me.EventType.HeaderText = "Package Type"
        Me.EventType.MinimumWidth = 6
        Me.EventType.Name = "EventType"
        Me.EventType.ReadOnly = True
        Me.EventType.Width = 125
        '
        'SchedDateTimeDataGridViewTextBoxColumn
        '
        Me.SchedDateTimeDataGridViewTextBoxColumn.DataPropertyName = "SchedDateTime"
        Me.SchedDateTimeDataGridViewTextBoxColumn.HeaderText = "SchedDateTime"
        Me.SchedDateTimeDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.SchedDateTimeDataGridViewTextBoxColumn.Name = "SchedDateTimeDataGridViewTextBoxColumn"
        Me.SchedDateTimeDataGridViewTextBoxColumn.ReadOnly = True
        Me.SchedDateTimeDataGridViewTextBoxColumn.Width = 125
        '
        'CreatedDateTimeDataGridViewTextBoxColumn
        '
        Me.CreatedDateTimeDataGridViewTextBoxColumn.DataPropertyName = "createdDateTime"
        Me.CreatedDateTimeDataGridViewTextBoxColumn.HeaderText = "createdDateTime"
        Me.CreatedDateTimeDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CreatedDateTimeDataGridViewTextBoxColumn.Name = "CreatedDateTimeDataGridViewTextBoxColumn"
        Me.CreatedDateTimeDataGridViewTextBoxColumn.ReadOnly = True
        Me.CreatedDateTimeDataGridViewTextBoxColumn.Width = 125
        '
        'cancelBtn
        '
        Me.cancelBtn.HeaderText = "Action"
        Me.cancelBtn.MinimumWidth = 6
        Me.cancelBtn.Name = "cancelBtn"
        Me.cancelBtn.ReadOnly = True
        Me.cancelBtn.Text = "Cancel"
        Me.cancelBtn.ToolTipText = "Cancel"
        Me.cancelBtn.UseColumnTextForButtonValue = True
        Me.cancelBtn.Width = 125
        '
        'completBtn
        '
        Me.completBtn.HeaderText = "Action"
        Me.completBtn.MinimumWidth = 6
        Me.completBtn.Name = "completBtn"
        Me.completBtn.ReadOnly = True
        Me.completBtn.Text = "Complete"
        Me.completBtn.ToolTipText = "Complete"
        Me.completBtn.UseColumnTextForButtonValue = True
        Me.completBtn.Width = 125
        '
        'ReservationDSBindingSource
        '
        Me.ReservationDSBindingSource.AllowNew = True
        Me.ReservationDSBindingSource.DataMember = "Reservation"
        Me.ReservationDSBindingSource.DataSource = Me.ReservationDS
        Me.ReservationDSBindingSource.Filter = "Status='Reserved'"
        '
        'ReservationDS
        '
        Me.ReservationDS.DataSetName = "reservationDS"
        Me.ReservationDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReservationBindingSource
        '
        Me.ReservationBindingSource.DataMember = "Reservation"
        Me.ReservationBindingSource.Filter = "Status='Reserved'"
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.btnBack)
        Me.Panel2.Location = New System.Drawing.Point(2, 2)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(598, 87)
        Me.Panel2.TabIndex = 2
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Transparent
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnBack.Location = New System.Drawing.Point(52, 14)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(99, 56)
        Me.btnBack.TabIndex = 0
        Me.btnBack.Text = "Back"
        Me.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.Controls.Add(Me.cbxEventType)
        Me.Panel3.Controls.Add(Me.Label13)
        Me.Panel3.Controls.Add(Me.Label12)
        Me.Panel3.Controls.Add(Me.tbxEventName)
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Controls.Add(Me.tbxDownPayment)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.tbxAmount)
        Me.Panel3.Controls.Add(Me.peopleCount)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.schedDateTime)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.tbxTableNum)
        Me.Panel3.Controls.Add(Me.tbxMobileNum)
        Me.Panel3.Controls.Add(Me.tbxAddress)
        Me.Panel3.Controls.Add(Me.tbxEmail)
        Me.Panel3.Controls.Add(Me.tbxName)
        Me.Panel3.Controls.Add(Me.tbxCode)
        Me.Panel3.Location = New System.Drawing.Point(13, 729)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1462, 231)
        Me.Panel3.TabIndex = 1
        '
        'cbxEventType
        '
        Me.cbxEventType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxEventType.Font = New System.Drawing.Font("Segoe UI Light", 16.2!)
        Me.cbxEventType.FormattingEnabled = True
        Me.cbxEventType.Items.AddRange(New Object() {"", "Package A (Good for 4 person)", "Package B (Good for 8 person)", "Package C (Good for 10 person)", "Package D (Good for 12 person)"})
        Me.cbxEventType.Location = New System.Drawing.Point(1122, 102)
        Me.cbxEventType.Name = "cbxEventType"
        Me.cbxEventType.Size = New System.Drawing.Size(313, 38)
        Me.cbxEventType.TabIndex = 27
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label13.Location = New System.Drawing.Point(905, 111)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(219, 22)
        Me.Label13.TabIndex = 26
        Me.Label13.Text = "(Optional) Package Type:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label12.Location = New System.Drawing.Point(999, 65)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(115, 22)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "Event Name:"
        '
        'tbxEventName
        '
        Me.tbxEventName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbxEventName.Font = New System.Drawing.Font("Segoe UI Light", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxEventName.Location = New System.Drawing.Point(1122, 58)
        Me.tbxEventName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbxEventName.Name = "tbxEventName"
        Me.tbxEventName.Size = New System.Drawing.Size(186, 29)
        Me.tbxEventName.TabIndex = 23
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label11.Location = New System.Drawing.Point(975, 16)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(139, 22)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "Down Payment:"
        '
        'tbxDownPayment
        '
        Me.tbxDownPayment.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbxDownPayment.Font = New System.Drawing.Font("Segoe UI Light", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxDownPayment.Location = New System.Drawing.Point(1122, 9)
        Me.tbxDownPayment.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbxDownPayment.Name = "tbxDownPayment"
        Me.tbxDownPayment.Size = New System.Drawing.Size(186, 29)
        Me.tbxDownPayment.TabIndex = 21
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label9.Location = New System.Drawing.Point(613, 112)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(79, 22)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Amount:"
        '
        'tbxAmount
        '
        Me.tbxAmount.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbxAmount.Font = New System.Drawing.Font("Segoe UI Light", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxAmount.Location = New System.Drawing.Point(771, 105)
        Me.tbxAmount.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbxAmount.Name = "tbxAmount"
        Me.tbxAmount.Size = New System.Drawing.Size(126, 29)
        Me.tbxAmount.TabIndex = 19
        '
        'peopleCount
        '
        Me.peopleCount.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.peopleCount.Font = New System.Drawing.Font("Segoe UI Light", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.peopleCount.Location = New System.Drawing.Point(771, 56)
        Me.peopleCount.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.peopleCount.Name = "peopleCount"
        Me.peopleCount.Size = New System.Drawing.Size(126, 32)
        Me.peopleCount.TabIndex = 18
        Me.peopleCount.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Aqua
        Me.btnClear.BackgroundImage = Global.Ordering_and_Billing_System_With_Inventory.My.Resources.Resources.clear_symbol_32px
        Me.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnClear.Location = New System.Drawing.Point(1338, 464)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(155, 66)
        Me.btnClear.TabIndex = 17
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
        Me.btnAdd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnAdd.Location = New System.Drawing.Point(1338, 354)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(155, 66)
        Me.btnAdd.TabIndex = 16
        Me.btnAdd.Text = "Add"
        Me.btnAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label8.Location = New System.Drawing.Point(613, 22)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(138, 22)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Date And Time:"
        '
        'schedDateTime
        '
        Me.schedDateTime.CalendarFont = New System.Drawing.Font("Segoe UI Light", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.schedDateTime.Font = New System.Drawing.Font("Segoe UI Light", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.schedDateTime.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.schedDateTime.Location = New System.Drawing.Point(771, 14)
        Me.schedDateTime.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.schedDateTime.Name = "schedDateTime"
        Me.schedDateTime.Size = New System.Drawing.Size(126, 32)
        Me.schedDateTime.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Location = New System.Drawing.Point(600, 63)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(163, 22)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Number of Guests:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(241, 111)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 22)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Address:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(241, 61)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 22)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Table No.:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(241, 15)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 22)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Mobile No.:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(5, 105)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 22)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Email:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(-2, 61)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 22)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(5, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 22)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Code:"
        '
        'tbxTableNum
        '
        Me.tbxTableNum.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbxTableNum.Font = New System.Drawing.Font("Segoe UI Light", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxTableNum.Location = New System.Drawing.Point(355, 61)
        Me.tbxTableNum.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbxTableNum.Name = "tbxTableNum"
        Me.tbxTableNum.Size = New System.Drawing.Size(239, 29)
        Me.tbxTableNum.TabIndex = 5
        '
        'tbxMobileNum
        '
        Me.tbxMobileNum.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbxMobileNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxMobileNum.Location = New System.Drawing.Point(355, 16)
        Me.tbxMobileNum.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbxMobileNum.Name = "tbxMobileNum"
        Me.tbxMobileNum.Size = New System.Drawing.Size(239, 28)
        Me.tbxMobileNum.TabIndex = 4
        '
        'tbxAddress
        '
        Me.tbxAddress.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbxAddress.Font = New System.Drawing.Font("Segoe UI Light", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxAddress.Location = New System.Drawing.Point(355, 107)
        Me.tbxAddress.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbxAddress.Name = "tbxAddress"
        Me.tbxAddress.Size = New System.Drawing.Size(241, 29)
        Me.tbxAddress.TabIndex = 3
        '
        'tbxEmail
        '
        Me.tbxEmail.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbxEmail.Font = New System.Drawing.Font("Segoe UI Light", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxEmail.Location = New System.Drawing.Point(74, 104)
        Me.tbxEmail.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbxEmail.Name = "tbxEmail"
        Me.tbxEmail.Size = New System.Drawing.Size(158, 29)
        Me.tbxEmail.TabIndex = 2
        '
        'tbxName
        '
        Me.tbxName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbxName.Font = New System.Drawing.Font("Segoe UI Light", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxName.Location = New System.Drawing.Point(75, 55)
        Me.tbxName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbxName.Name = "tbxName"
        Me.tbxName.Size = New System.Drawing.Size(158, 29)
        Me.tbxName.TabIndex = 1
        '
        'tbxCode
        '
        Me.tbxCode.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbxCode.Font = New System.Drawing.Font("Segoe UI Light", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxCode.Location = New System.Drawing.Point(74, 9)
        Me.tbxCode.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbxCode.Name = "tbxCode"
        Me.tbxCode.ReadOnly = True
        Me.tbxCode.Size = New System.Drawing.Size(159, 29)
        Me.tbxCode.TabIndex = 0
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.InitialImage = Nothing
        Me.PictureBox3.Location = New System.Drawing.Point(1110, 16)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(159, 147)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 45
        Me.PictureBox3.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label10.Location = New System.Drawing.Point(94, 84)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(262, 40)
        Me.Label10.TabIndex = 44
        Me.Label10.Text = "RESERVATION"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(360, 91)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(876, 33)
        Me.PictureBox1.TabIndex = 43
        Me.PictureBox1.TabStop = False
        '
        'ReservationTableAdapter
        '
        Me.ReservationTableAdapter.ClearBeforeFill = True
        '
        'Reservation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1600, 900)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnClear)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximumSize = New System.Drawing.Size(1918, 1211)
        Me.MinimumSize = New System.Drawing.Size(1278, 898)
        Me.Name = "Reservation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reservation"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        CType(Me.reservationDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReservationDSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReservationDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReservationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.peopleCount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents schedDateTime As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents tbxTableNum As TextBox
    Friend WithEvents tbxMobileNum As TextBox
    Friend WithEvents tbxAddress As TextBox
    Friend WithEvents tbxEmail As TextBox
    Friend WithEvents tbxName As TextBox
    Friend WithEvents tbxCode As TextBox
    Friend WithEvents reservationDataGrid As DataGridView
    Friend WithEvents btnBack As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents peopleCount As NumericUpDown
    Friend WithEvents ReservationBindingSource As BindingSource
    Friend WithEvents ReservationTableAdapter As reservationDSTableAdapters.ReservationTableAdapter
    Friend WithEvents Label9 As Label
    Friend WithEvents tbxAmount As TextBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label10 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label11 As Label
    Friend WithEvents tbxDownPayment As TextBox
    Friend WithEvents ReservationDS As reservationDS
    Friend WithEvents ReservationDSBindingSource As BindingSource
    Friend WithEvents cbxEventType As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents tbxEventName As TextBox
    Friend WithEvents reservationID As DataGridViewTextBoxColumn
    Friend WithEvents CodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustomerNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MobileNumDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TableNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NumOfPeopleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DiscountedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DownPaymentDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EventName As DataGridViewTextBoxColumn
    Friend WithEvents EventType As DataGridViewTextBoxColumn
    Friend WithEvents SchedDateTimeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CreatedDateTimeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents cancelBtn As DataGridViewButtonColumn
    Friend WithEvents completBtn As DataGridViewButtonColumn
End Class
