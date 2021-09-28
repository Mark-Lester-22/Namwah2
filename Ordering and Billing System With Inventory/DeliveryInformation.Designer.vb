<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DeliveryInformation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DeliveryInformation))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.deliveryDGV = New System.Windows.Forms.DataGridView()
        Me.deliveryID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DeliveryNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenusIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrderNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ListOfMenuDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ListOfPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuQuantityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InitialPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiscountedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MobileNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DeliveryManDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CreatedDateTimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Complete = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Cancel = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.DeliveryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DeliveryDS = New Ordering_and_Billing_System_With_Inventory.DeliveryDS()
        Me.DeliveryTableAdapter = New Ordering_and_Billing_System_With_Inventory.DeliveryDSTableAdapters.DeliveryTableAdapter()
        Me.btnRefresh = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deliveryDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DeliveryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DeliveryDS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(19, 93)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(466, 40)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "DELIVERY INFORMATION"
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Transparent
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.Black
        Me.btnBack.Location = New System.Drawing.Point(22, 18)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(121, 51)
        Me.btnBack.TabIndex = 11
        Me.btnBack.Text = "Back"
        Me.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(238, 141)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1091, 27)
        Me.PictureBox1.TabIndex = 44
        Me.PictureBox1.TabStop = False
        '
        'deliveryDGV
        '
        Me.deliveryDGV.AllowUserToAddRows = False
        Me.deliveryDGV.AllowUserToDeleteRows = False
        Me.deliveryDGV.AutoGenerateColumns = False
        Me.deliveryDGV.BackgroundColor = System.Drawing.Color.White
        Me.deliveryDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.deliveryDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.deliveryID, Me.DeliveryNumberDataGridViewTextBoxColumn, Me.MenusIDDataGridViewTextBoxColumn, Me.OrderNumberDataGridViewTextBoxColumn, Me.ListOfMenuDataGridViewTextBoxColumn, Me.ListOfPriceDataGridViewTextBoxColumn, Me.MenuQuantityDataGridViewTextBoxColumn, Me.InitialPriceDataGridViewTextBoxColumn, Me.TotalPriceDataGridViewTextBoxColumn, Me.StatusDataGridViewTextBoxColumn, Me.DiscountedDataGridViewTextBoxColumn, Me.CustomerNameDataGridViewTextBoxColumn, Me.MobileNumberDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn, Me.DeliveryManDataGridViewTextBoxColumn, Me.CreatedDateTimeDataGridViewTextBoxColumn, Me.Complete, Me.Cancel})
        Me.deliveryDGV.DataSource = Me.DeliveryBindingSource
        Me.deliveryDGV.Location = New System.Drawing.Point(90, 220)
        Me.deliveryDGV.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.deliveryDGV.Name = "deliveryDGV"
        Me.deliveryDGV.ReadOnly = True
        Me.deliveryDGV.RowHeadersWidth = 51
        Me.deliveryDGV.RowTemplate.Height = 24
        Me.deliveryDGV.Size = New System.Drawing.Size(1429, 500)
        Me.deliveryDGV.TabIndex = 45
        '
        'deliveryID
        '
        Me.deliveryID.DataPropertyName = "ID"
        Me.deliveryID.HeaderText = "ID"
        Me.deliveryID.MinimumWidth = 6
        Me.deliveryID.Name = "deliveryID"
        Me.deliveryID.ReadOnly = True
        Me.deliveryID.Visible = False
        Me.deliveryID.Width = 125
        '
        'DeliveryNumberDataGridViewTextBoxColumn
        '
        Me.DeliveryNumberDataGridViewTextBoxColumn.DataPropertyName = "DeliveryNumber"
        Me.DeliveryNumberDataGridViewTextBoxColumn.HeaderText = "DeliveryNumber"
        Me.DeliveryNumberDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DeliveryNumberDataGridViewTextBoxColumn.Name = "DeliveryNumberDataGridViewTextBoxColumn"
        Me.DeliveryNumberDataGridViewTextBoxColumn.ReadOnly = True
        Me.DeliveryNumberDataGridViewTextBoxColumn.Width = 125
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
        'OrderNumberDataGridViewTextBoxColumn
        '
        Me.OrderNumberDataGridViewTextBoxColumn.DataPropertyName = "OrderNumber"
        Me.OrderNumberDataGridViewTextBoxColumn.HeaderText = "OrderNumber"
        Me.OrderNumberDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.OrderNumberDataGridViewTextBoxColumn.Name = "OrderNumberDataGridViewTextBoxColumn"
        Me.OrderNumberDataGridViewTextBoxColumn.ReadOnly = True
        Me.OrderNumberDataGridViewTextBoxColumn.Visible = False
        Me.OrderNumberDataGridViewTextBoxColumn.Width = 125
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
        'InitialPriceDataGridViewTextBoxColumn
        '
        Me.InitialPriceDataGridViewTextBoxColumn.DataPropertyName = "InitialPrice"
        Me.InitialPriceDataGridViewTextBoxColumn.HeaderText = "InitialPrice"
        Me.InitialPriceDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.InitialPriceDataGridViewTextBoxColumn.Name = "InitialPriceDataGridViewTextBoxColumn"
        Me.InitialPriceDataGridViewTextBoxColumn.ReadOnly = True
        Me.InitialPriceDataGridViewTextBoxColumn.Width = 125
        '
        'TotalPriceDataGridViewTextBoxColumn
        '
        Me.TotalPriceDataGridViewTextBoxColumn.DataPropertyName = "TotalPrice"
        Me.TotalPriceDataGridViewTextBoxColumn.HeaderText = "TotalPrice"
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
        'DiscountedDataGridViewTextBoxColumn
        '
        Me.DiscountedDataGridViewTextBoxColumn.DataPropertyName = "Discounted"
        Me.DiscountedDataGridViewTextBoxColumn.HeaderText = "Discounted"
        Me.DiscountedDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DiscountedDataGridViewTextBoxColumn.Name = "DiscountedDataGridViewTextBoxColumn"
        Me.DiscountedDataGridViewTextBoxColumn.ReadOnly = True
        Me.DiscountedDataGridViewTextBoxColumn.Width = 125
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
        'MobileNumberDataGridViewTextBoxColumn
        '
        Me.MobileNumberDataGridViewTextBoxColumn.DataPropertyName = "MobileNumber"
        Me.MobileNumberDataGridViewTextBoxColumn.HeaderText = "MobileNumber"
        Me.MobileNumberDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.MobileNumberDataGridViewTextBoxColumn.Name = "MobileNumberDataGridViewTextBoxColumn"
        Me.MobileNumberDataGridViewTextBoxColumn.ReadOnly = True
        Me.MobileNumberDataGridViewTextBoxColumn.Width = 125
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
        'DeliveryManDataGridViewTextBoxColumn
        '
        Me.DeliveryManDataGridViewTextBoxColumn.DataPropertyName = "DeliveryMan"
        Me.DeliveryManDataGridViewTextBoxColumn.HeaderText = "DeliveryMan"
        Me.DeliveryManDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DeliveryManDataGridViewTextBoxColumn.Name = "DeliveryManDataGridViewTextBoxColumn"
        Me.DeliveryManDataGridViewTextBoxColumn.ReadOnly = True
        Me.DeliveryManDataGridViewTextBoxColumn.Visible = False
        Me.DeliveryManDataGridViewTextBoxColumn.Width = 125
        '
        'CreatedDateTimeDataGridViewTextBoxColumn
        '
        Me.CreatedDateTimeDataGridViewTextBoxColumn.DataPropertyName = "createdDateTime"
        Me.CreatedDateTimeDataGridViewTextBoxColumn.HeaderText = "Date And Time"
        Me.CreatedDateTimeDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CreatedDateTimeDataGridViewTextBoxColumn.Name = "CreatedDateTimeDataGridViewTextBoxColumn"
        Me.CreatedDateTimeDataGridViewTextBoxColumn.ReadOnly = True
        Me.CreatedDateTimeDataGridViewTextBoxColumn.Width = 125
        '
        'Complete
        '
        Me.Complete.HeaderText = "Action"
        Me.Complete.MinimumWidth = 6
        Me.Complete.Name = "Complete"
        Me.Complete.ReadOnly = True
        Me.Complete.Text = "Complete"
        Me.Complete.ToolTipText = "Complete"
        Me.Complete.UseColumnTextForButtonValue = True
        Me.Complete.Width = 125
        '
        'Cancel
        '
        Me.Cancel.HeaderText = "Action"
        Me.Cancel.MinimumWidth = 6
        Me.Cancel.Name = "Cancel"
        Me.Cancel.ReadOnly = True
        Me.Cancel.Text = "Cancel"
        Me.Cancel.ToolTipText = "Cancel"
        Me.Cancel.UseColumnTextForButtonValue = True
        Me.Cancel.Width = 125
        '
        'DeliveryBindingSource
        '
        Me.DeliveryBindingSource.DataMember = "Delivery"
        Me.DeliveryBindingSource.DataSource = Me.DeliveryDS
        Me.DeliveryBindingSource.Filter = "Status='Pending'"
        '
        'DeliveryDS
        '
        Me.DeliveryDS.DataSetName = "DeliveryDS"
        Me.DeliveryDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DeliveryTableAdapter
        '
        Me.DeliveryTableAdapter.ClearBeforeFill = True
        '
        'btnRefresh
        '
        Me.btnRefresh.BackColor = System.Drawing.Color.Aqua
        Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefresh.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.ForeColor = System.Drawing.Color.Black
        Me.btnRefresh.Image = Global.Ordering_and_Billing_System_With_Inventory.My.Resources.Resources.refresh_32px
        Me.btnRefresh.Location = New System.Drawing.Point(1389, 141)
        Me.btnRefresh.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(130, 56)
        Me.btnRefresh.TabIndex = 46
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'DeliveryInformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.Red
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1600, 900)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.deliveryDGV)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MaximumSize = New System.Drawing.Size(1600, 900)
        Me.MinimumSize = New System.Drawing.Size(1198, 730)
        Me.Name = "DeliveryInformation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Delivery Information"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deliveryDGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DeliveryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DeliveryDS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents deliveryDGV As DataGridView
    Friend WithEvents DeliveryDS As DeliveryDS
    Friend WithEvents DeliveryBindingSource As BindingSource
    Friend WithEvents DeliveryTableAdapter As DeliveryDSTableAdapters.DeliveryTableAdapter
    Friend WithEvents deliveryID As DataGridViewTextBoxColumn
    Friend WithEvents DeliveryNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MenusIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OrderNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ListOfMenuDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ListOfPriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MenuQuantityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents InitialPriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalPriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DiscountedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustomerNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MobileNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DeliveryManDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CreatedDateTimeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Complete As DataGridViewButtonColumn
    Friend WithEvents Cancel As DataGridViewButtonColumn
    Friend WithEvents btnRefresh As Button
End Class
