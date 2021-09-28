<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Maintenance
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Maintenance))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnClearTable = New System.Windows.Forms.Button()
        Me.btnAddTable = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbxTableDetails = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbxTableNum = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TableManagementDGV = New System.Windows.Forms.DataGridView()
        Me.tableManagementID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableNumDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DetailsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tableManagementStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CreatedDateTimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusChange = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Delete = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.TableManagementBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableManagementDS = New Ordering_and_Billing_System_With_Inventory.TableManagementDS()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.discountPercentage = New System.Windows.Forms.NumericUpDown()
        Me.discountID = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.discountDetails = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.discountName = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.discountManagementGrid = New System.Windows.Forms.DataGridView()
        Me.discountManagementID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.discountManagementName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiscountPercent = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Details = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.createdDateTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewButtonColumn1 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.DiscountManagementBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DiscountMangement = New Ordering_and_Billing_System_With_Inventory.namwahDataSet2()
        Me.TableManagementTableAdapter = New Ordering_and_Billing_System_With_Inventory.TableManagementDSTableAdapters.TableManagementTableAdapter()
        Me.DiscountManagementTableAdapter = New Ordering_and_Billing_System_With_Inventory.namwahDataSet2TableAdapters.DiscountManagementTableAdapter()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.TableManagementDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TableManagementBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TableManagementDS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.discountPercentage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.discountManagementGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DiscountManagementBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DiscountMangement, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(424, 132)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(936, 27)
        Me.PictureBox1.TabIndex = 47
        Me.PictureBox1.TabStop = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Transparent
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.Black
        Me.btnBack.Location = New System.Drawing.Point(15, 22)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(121, 51)
        Me.btnBack.TabIndex = 46
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
        Me.Label1.Location = New System.Drawing.Point(132, 119)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(284, 40)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "MAINTENANCE"
        '
        'TabControl1
        '
        Me.TabControl1.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.ItemSize = New System.Drawing.Size(30, 120)
        Me.TabControl1.Location = New System.Drawing.Point(30, 182)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(2)
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1409, 596)
        Me.TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.TabControl1.TabIndex = 48
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.btnClearTable)
        Me.TabPage1.Controls.Add(Me.btnAddTable)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.tbxTableDetails)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.tbxTableNum)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.TableManagementDGV)
        Me.TabPage1.Location = New System.Drawing.Point(124, 4)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPage1.Size = New System.Drawing.Size(1281, 588)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Tables"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label9.Location = New System.Drawing.Point(831, 35)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(399, 40)
        Me.Label9.TabIndex = 57
        Me.Label9.Text = "TABLE INFORMATION"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Light", 25.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label10.Location = New System.Drawing.Point(850, 75)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(356, 46)
        Me.Label10.TabIndex = 58
        Me.Label10.Text = "________________________"
        '
        'btnClearTable
        '
        Me.btnClearTable.Font = New System.Drawing.Font("Times New Roman", 17.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearTable.Location = New System.Drawing.Point(1087, 426)
        Me.btnClearTable.Margin = New System.Windows.Forms.Padding(2)
        Me.btnClearTable.Name = "btnClearTable"
        Me.btnClearTable.Size = New System.Drawing.Size(143, 89)
        Me.btnClearTable.TabIndex = 56
        Me.btnClearTable.Text = "Clear"
        Me.btnClearTable.UseVisualStyleBackColor = True
        '
        'btnAddTable
        '
        Me.btnAddTable.Font = New System.Drawing.Font("Times New Roman", 17.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddTable.Location = New System.Drawing.Point(887, 426)
        Me.btnAddTable.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAddTable.Name = "btnAddTable"
        Me.btnAddTable.Size = New System.Drawing.Size(158, 89)
        Me.btnAddTable.TabIndex = 55
        Me.btnAddTable.Text = "Add"
        Me.btnAddTable.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label3.Location = New System.Drawing.Point(883, 211)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 22)
        Me.Label3.TabIndex = 54
        Me.Label3.Text = "Details:"
        '
        'tbxTableDetails
        '
        Me.tbxTableDetails.BackColor = System.Drawing.Color.White
        Me.tbxTableDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbxTableDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxTableDetails.ForeColor = System.Drawing.SystemColors.Desktop
        Me.tbxTableDetails.Location = New System.Drawing.Point(887, 247)
        Me.tbxTableDetails.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tbxTableDetails.Multiline = True
        Me.tbxTableDetails.Name = "tbxTableDetails"
        Me.tbxTableDetails.Size = New System.Drawing.Size(343, 130)
        Me.tbxTableDetails.TabIndex = 53
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label4.Location = New System.Drawing.Point(878, 150)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 22)
        Me.Label4.TabIndex = 52
        Me.Label4.Text = "Table #:"
        '
        'tbxTableNum
        '
        Me.tbxTableNum.BackColor = System.Drawing.Color.White
        Me.tbxTableNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbxTableNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxTableNum.ForeColor = System.Drawing.SystemColors.Desktop
        Me.tbxTableNum.Location = New System.Drawing.Point(959, 142)
        Me.tbxTableNum.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tbxTableNum.Name = "tbxTableNum"
        Me.tbxTableNum.Size = New System.Drawing.Size(134, 35)
        Me.tbxTableNum.TabIndex = 51
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label2.Location = New System.Drawing.Point(27, 35)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(151, 40)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "TABLES"
        '
        'TableManagementDGV
        '
        Me.TableManagementDGV.AllowUserToAddRows = False
        Me.TableManagementDGV.AllowUserToDeleteRows = False
        Me.TableManagementDGV.AutoGenerateColumns = False
        Me.TableManagementDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TableManagementDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.tableManagementID, Me.TableNumDataGridViewTextBoxColumn, Me.DetailsDataGridViewTextBoxColumn, Me.tableManagementStatus, Me.CreatedDateTimeDataGridViewTextBoxColumn, Me.StatusChange, Me.Delete})
        Me.TableManagementDGV.DataSource = Me.TableManagementBindingSource
        Me.TableManagementDGV.Location = New System.Drawing.Point(16, 99)
        Me.TableManagementDGV.Margin = New System.Windows.Forms.Padding(2)
        Me.TableManagementDGV.Name = "TableManagementDGV"
        Me.TableManagementDGV.RowHeadersWidth = 51
        Me.TableManagementDGV.RowTemplate.Height = 24
        Me.TableManagementDGV.Size = New System.Drawing.Size(803, 466)
        Me.TableManagementDGV.TabIndex = 0
        '
        'tableManagementID
        '
        Me.tableManagementID.DataPropertyName = "ID"
        Me.tableManagementID.HeaderText = "ID"
        Me.tableManagementID.MinimumWidth = 6
        Me.tableManagementID.Name = "tableManagementID"
        Me.tableManagementID.Visible = False
        Me.tableManagementID.Width = 125
        '
        'TableNumDataGridViewTextBoxColumn
        '
        Me.TableNumDataGridViewTextBoxColumn.DataPropertyName = "TableNum"
        Me.TableNumDataGridViewTextBoxColumn.HeaderText = "TableNum"
        Me.TableNumDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TableNumDataGridViewTextBoxColumn.Name = "TableNumDataGridViewTextBoxColumn"
        Me.TableNumDataGridViewTextBoxColumn.Width = 125
        '
        'DetailsDataGridViewTextBoxColumn
        '
        Me.DetailsDataGridViewTextBoxColumn.DataPropertyName = "Details"
        Me.DetailsDataGridViewTextBoxColumn.HeaderText = "Details"
        Me.DetailsDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DetailsDataGridViewTextBoxColumn.Name = "DetailsDataGridViewTextBoxColumn"
        Me.DetailsDataGridViewTextBoxColumn.Width = 125
        '
        'tableManagementStatus
        '
        Me.tableManagementStatus.DataPropertyName = "Status"
        Me.tableManagementStatus.HeaderText = "Status"
        Me.tableManagementStatus.MinimumWidth = 6
        Me.tableManagementStatus.Name = "tableManagementStatus"
        Me.tableManagementStatus.Width = 125
        '
        'CreatedDateTimeDataGridViewTextBoxColumn
        '
        Me.CreatedDateTimeDataGridViewTextBoxColumn.DataPropertyName = "createdDateTime"
        Me.CreatedDateTimeDataGridViewTextBoxColumn.HeaderText = "createdDateTime"
        Me.CreatedDateTimeDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CreatedDateTimeDataGridViewTextBoxColumn.Name = "CreatedDateTimeDataGridViewTextBoxColumn"
        Me.CreatedDateTimeDataGridViewTextBoxColumn.Width = 125
        '
        'StatusChange
        '
        Me.StatusChange.HeaderText = "Action"
        Me.StatusChange.MinimumWidth = 6
        Me.StatusChange.Name = "StatusChange"
        Me.StatusChange.Text = "Available/Unavailable"
        Me.StatusChange.ToolTipText = "Available/Unavailable"
        Me.StatusChange.UseColumnTextForButtonValue = True
        Me.StatusChange.Width = 125
        '
        'Delete
        '
        Me.Delete.HeaderText = "Action"
        Me.Delete.MinimumWidth = 6
        Me.Delete.Name = "Delete"
        Me.Delete.Text = "Delete"
        Me.Delete.ToolTipText = "Delete"
        Me.Delete.UseColumnTextForButtonValue = True
        Me.Delete.Width = 125
        '
        'TableManagementBindingSource
        '
        Me.TableManagementBindingSource.DataMember = "TableManagement"
        Me.TableManagementBindingSource.DataSource = Me.TableManagementDS
        Me.TableManagementBindingSource.Sort = "TableNum"
        '
        'TableManagementDS
        '
        Me.TableManagementDS.DataSetName = "TableManagementDS"
        Me.TableManagementDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.btnDelete)
        Me.TabPage2.Controls.Add(Me.discountPercentage)
        Me.TabPage2.Controls.Add(Me.discountID)
        Me.TabPage2.Controls.Add(Me.Label13)
        Me.TabPage2.Controls.Add(Me.Label12)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.btnUpdate)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.discountDetails)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.discountName)
        Me.TabPage2.Controls.Add(Me.Label11)
        Me.TabPage2.Controls.Add(Me.discountManagementGrid)
        Me.TabPage2.Location = New System.Drawing.Point(124, 4)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(1281, 588)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Discount"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Times New Roman", 17.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(930, 422)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(158, 89)
        Me.btnDelete.TabIndex = 74
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'discountPercentage
        '
        Me.discountPercentage.Location = New System.Drawing.Point(919, 184)
        Me.discountPercentage.Margin = New System.Windows.Forms.Padding(2)
        Me.discountPercentage.Name = "discountPercentage"
        Me.discountPercentage.Size = New System.Drawing.Size(106, 26)
        Me.discountPercentage.TabIndex = 73
        Me.discountPercentage.Tag = "discountPercentage"
        '
        'discountID
        '
        Me.discountID.BackColor = System.Drawing.Color.White
        Me.discountID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.discountID.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.discountID.ForeColor = System.Drawing.SystemColors.Desktop
        Me.discountID.Location = New System.Drawing.Point(845, 225)
        Me.discountID.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.discountID.Name = "discountID"
        Me.discountID.Size = New System.Drawing.Size(206, 35)
        Me.discountID.TabIndex = 72
        Me.discountID.Tag = "discountID"
        Me.discountID.Visible = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.White
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label13.Location = New System.Drawing.Point(1030, 188)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(28, 22)
        Me.Label13.TabIndex = 71
        Me.Label13.Text = "%"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.White
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label12.Location = New System.Drawing.Point(771, 180)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(110, 22)
        Me.Label12.TabIndex = 70
        Me.Label12.Text = "Discount %:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label5.Location = New System.Drawing.Point(699, 32)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(466, 40)
        Me.Label5.TabIndex = 67
        Me.Label5.Text = "DISCOUNT INFORMATION"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Light", 25.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label6.Location = New System.Drawing.Point(746, 62)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(356, 46)
        Me.Label6.TabIndex = 68
        Me.Label6.Text = "________________________"
        '
        'btnUpdate
        '
        Me.btnUpdate.Font = New System.Drawing.Font("Times New Roman", 17.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(764, 422)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(2)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(158, 89)
        Me.btnUpdate.TabIndex = 65
        Me.btnUpdate.Text = "Add/Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label7.Location = New System.Drawing.Point(771, 225)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 22)
        Me.Label7.TabIndex = 64
        Me.Label7.Text = "Details:"
        '
        'discountDetails
        '
        Me.discountDetails.BackColor = System.Drawing.Color.White
        Me.discountDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.discountDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.discountDetails.ForeColor = System.Drawing.SystemColors.Desktop
        Me.discountDetails.Location = New System.Drawing.Point(775, 266)
        Me.discountDetails.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.discountDetails.Multiline = True
        Me.discountDetails.Name = "discountDetails"
        Me.discountDetails.Size = New System.Drawing.Size(289, 130)
        Me.discountDetails.TabIndex = 63
        Me.discountDetails.Tag = "discountDetails"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label8.Location = New System.Drawing.Point(771, 138)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(140, 22)
        Me.Label8.TabIndex = 62
        Me.Label8.Text = "Discount Name:"
        '
        'discountName
        '
        Me.discountName.BackColor = System.Drawing.Color.White
        Me.discountName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.discountName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.discountName.ForeColor = System.Drawing.SystemColors.Desktop
        Me.discountName.Location = New System.Drawing.Point(919, 138)
        Me.discountName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.discountName.Name = "discountName"
        Me.discountName.Size = New System.Drawing.Size(137, 26)
        Me.discountName.TabIndex = 61
        Me.discountName.Tag = "discountName"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label11.Location = New System.Drawing.Point(72, 32)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(200, 40)
        Me.Label11.TabIndex = 60
        Me.Label11.Text = "DISCOUNT"
        '
        'discountManagementGrid
        '
        Me.discountManagementGrid.AllowUserToAddRows = False
        Me.discountManagementGrid.AllowUserToDeleteRows = False
        Me.discountManagementGrid.AutoGenerateColumns = False
        Me.discountManagementGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.discountManagementGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.discountManagementID, Me.discountManagementName, Me.DiscountPercent, Me.Details, Me.createdDateTime, Me.DataGridViewButtonColumn1})
        Me.discountManagementGrid.DataSource = Me.DiscountManagementBindingSource
        Me.discountManagementGrid.Location = New System.Drawing.Point(70, 92)
        Me.discountManagementGrid.Margin = New System.Windows.Forms.Padding(2)
        Me.discountManagementGrid.Name = "discountManagementGrid"
        Me.discountManagementGrid.RowHeadersWidth = 51
        Me.discountManagementGrid.RowTemplate.Height = 24
        Me.discountManagementGrid.Size = New System.Drawing.Size(554, 466)
        Me.discountManagementGrid.TabIndex = 59
        '
        'discountManagementID
        '
        Me.discountManagementID.DataPropertyName = "ID"
        Me.discountManagementID.HeaderText = "ID"
        Me.discountManagementID.MinimumWidth = 6
        Me.discountManagementID.Name = "discountManagementID"
        Me.discountManagementID.Visible = False
        Me.discountManagementID.Width = 125
        '
        'discountManagementName
        '
        Me.discountManagementName.DataPropertyName = "Name"
        Me.discountManagementName.HeaderText = "Name"
        Me.discountManagementName.MinimumWidth = 6
        Me.discountManagementName.Name = "discountManagementName"
        Me.discountManagementName.Width = 125
        '
        'DiscountPercent
        '
        Me.DiscountPercent.DataPropertyName = "DiscountPercent"
        Me.DiscountPercent.HeaderText = "DiscountPercent"
        Me.DiscountPercent.MinimumWidth = 6
        Me.DiscountPercent.Name = "DiscountPercent"
        Me.DiscountPercent.Width = 125
        '
        'Details
        '
        Me.Details.DataPropertyName = "Details"
        Me.Details.HeaderText = "Details"
        Me.Details.MinimumWidth = 6
        Me.Details.Name = "Details"
        Me.Details.Width = 125
        '
        'createdDateTime
        '
        Me.createdDateTime.DataPropertyName = "createdDateTime"
        Me.createdDateTime.HeaderText = "createdDateTime"
        Me.createdDateTime.MinimumWidth = 6
        Me.createdDateTime.Name = "createdDateTime"
        Me.createdDateTime.Visible = False
        Me.createdDateTime.Width = 125
        '
        'DataGridViewButtonColumn1
        '
        Me.DataGridViewButtonColumn1.HeaderText = "Action"
        Me.DataGridViewButtonColumn1.MinimumWidth = 6
        Me.DataGridViewButtonColumn1.Name = "DataGridViewButtonColumn1"
        Me.DataGridViewButtonColumn1.Text = "Select"
        Me.DataGridViewButtonColumn1.ToolTipText = "Select"
        Me.DataGridViewButtonColumn1.UseColumnTextForButtonValue = True
        Me.DataGridViewButtonColumn1.Width = 125
        '
        'DiscountManagementBindingSource
        '
        Me.DiscountManagementBindingSource.DataMember = "DiscountManagement"
        Me.DiscountManagementBindingSource.DataSource = Me.DiscountMangement
        '
        'DiscountMangement
        '
        Me.DiscountMangement.DataSetName = "DiscountMangement"
        Me.DiscountMangement.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TableManagementTableAdapter
        '
        Me.TableManagementTableAdapter.ClearBeforeFill = True
        '
        'DiscountManagementTableAdapter
        '
        Me.DiscountManagementTableAdapter.ClearBeforeFill = True
        '
        'Maintenance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1600, 900)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximumSize = New System.Drawing.Size(1600, 900)
        Me.MinimumSize = New System.Drawing.Size(1198, 730)
        Me.Name = "Maintenance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Maintenance"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.TableManagementDGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TableManagementBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TableManagementDS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.discountPercentage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.discountManagementGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DiscountManagementBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DiscountMangement, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnBack As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Label2 As Label
    Friend WithEvents TableManagementDGV As DataGridView
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents btnClearTable As Button
    Friend WithEvents btnAddTable As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents tbxTableDetails As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tbxTableNum As TextBox
    Friend WithEvents TableManagementDS As TableManagementDS
    Friend WithEvents TableManagementBindingSource As BindingSource
    Friend WithEvents TableManagementTableAdapter As TableManagementDSTableAdapters.TableManagementTableAdapter
    Friend WithEvents tableManagementID As DataGridViewTextBoxColumn
    Friend WithEvents TableNumDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DetailsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents tableManagementStatus As DataGridViewTextBoxColumn
    Friend WithEvents CreatedDateTimeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StatusChange As DataGridViewButtonColumn
    Friend WithEvents Delete As DataGridViewButtonColumn
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnUpdate As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents discountDetails As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents discountName As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents discountManagementGrid As DataGridView
    Friend WithEvents DiscountMangement As namwahDataSet2
    Friend WithEvents DiscountManagementBindingSource As BindingSource
    Friend WithEvents DiscountManagementTableAdapter As namwahDataSet2TableAdapters.DiscountManagementTableAdapter
    Friend WithEvents discountID As TextBox
    Friend WithEvents discountManagementID As DataGridViewTextBoxColumn
    Friend WithEvents discountManagementName As DataGridViewTextBoxColumn
    Friend WithEvents DiscountPercent As DataGridViewTextBoxColumn
    Friend WithEvents Details As DataGridViewTextBoxColumn
    Friend WithEvents createdDateTime As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewButtonColumn1 As DataGridViewButtonColumn
    Friend WithEvents discountPercentage As NumericUpDown
    Friend WithEvents btnDelete As Button
End Class
