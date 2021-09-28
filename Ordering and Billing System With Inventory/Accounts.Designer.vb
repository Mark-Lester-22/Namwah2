<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Accounts
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Accounts))
        Me.accountsDataGrid = New System.Windows.Forms.DataGridView()
        Me.accountsID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.accountsName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.accountsUsername = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.accountsPassword = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.accountsType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.accountsEmail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.accountsPassRecovery = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.accountsStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.accountsDateTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnDelete = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.btnEdit = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.btnInactive = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.AccountsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AccountsDataSet = New Ordering_and_Billing_System_With_Inventory.accountsDataSet()
        Me.AccountsTableAdapter = New Ordering_and_Billing_System_With_Inventory.accountsDataSetTableAdapters.AccountsTableAdapter()
        Me.tbxName = New System.Windows.Forms.TextBox()
        Me.tbxEmail = New System.Windows.Forms.TextBox()
        Me.tbxUsername = New System.Windows.Forms.TextBox()
        Me.tbxPassword = New System.Windows.Forms.TextBox()
        Me.tbxRecoveryPass = New System.Windows.Forms.TextBox()
        Me.tbxType = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.tbxID = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        CType(Me.accountsDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccountsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccountsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'accountsDataGrid
        '
        Me.accountsDataGrid.AllowUserToAddRows = False
        Me.accountsDataGrid.AllowUserToDeleteRows = False
        Me.accountsDataGrid.AutoGenerateColumns = False
        Me.accountsDataGrid.BackgroundColor = System.Drawing.Color.White
        Me.accountsDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.accountsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.accountsDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.accountsID, Me.accountsName, Me.accountsUsername, Me.accountsPassword, Me.accountsType, Me.accountsEmail, Me.accountsPassRecovery, Me.accountsStatus, Me.accountsDateTime, Me.btnDelete, Me.btnEdit, Me.btnInactive})
        Me.accountsDataGrid.DataSource = Me.AccountsBindingSource
        Me.accountsDataGrid.Location = New System.Drawing.Point(392, 198)
        Me.accountsDataGrid.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.accountsDataGrid.Name = "accountsDataGrid"
        Me.accountsDataGrid.ReadOnly = True
        Me.accountsDataGrid.RowHeadersWidth = 51
        Me.accountsDataGrid.RowTemplate.Height = 24
        Me.accountsDataGrid.Size = New System.Drawing.Size(987, 594)
        Me.accountsDataGrid.TabIndex = 0
        '
        'accountsID
        '
        Me.accountsID.DataPropertyName = "ID"
        Me.accountsID.HeaderText = "ID"
        Me.accountsID.MinimumWidth = 6
        Me.accountsID.Name = "accountsID"
        Me.accountsID.ReadOnly = True
        Me.accountsID.Width = 125
        '
        'accountsName
        '
        Me.accountsName.DataPropertyName = "Name"
        Me.accountsName.HeaderText = "Name"
        Me.accountsName.MinimumWidth = 6
        Me.accountsName.Name = "accountsName"
        Me.accountsName.ReadOnly = True
        Me.accountsName.Width = 125
        '
        'accountsUsername
        '
        Me.accountsUsername.DataPropertyName = "Username"
        Me.accountsUsername.HeaderText = "Username"
        Me.accountsUsername.MinimumWidth = 6
        Me.accountsUsername.Name = "accountsUsername"
        Me.accountsUsername.ReadOnly = True
        Me.accountsUsername.Width = 125
        '
        'accountsPassword
        '
        Me.accountsPassword.DataPropertyName = "Password"
        Me.accountsPassword.HeaderText = "Password"
        Me.accountsPassword.MinimumWidth = 6
        Me.accountsPassword.Name = "accountsPassword"
        Me.accountsPassword.ReadOnly = True
        Me.accountsPassword.Width = 125
        '
        'accountsType
        '
        Me.accountsType.DataPropertyName = "AccountType"
        Me.accountsType.HeaderText = "AccountType"
        Me.accountsType.MinimumWidth = 6
        Me.accountsType.Name = "accountsType"
        Me.accountsType.ReadOnly = True
        Me.accountsType.Width = 125
        '
        'accountsEmail
        '
        Me.accountsEmail.DataPropertyName = "Email"
        Me.accountsEmail.HeaderText = "Email"
        Me.accountsEmail.MinimumWidth = 6
        Me.accountsEmail.Name = "accountsEmail"
        Me.accountsEmail.ReadOnly = True
        Me.accountsEmail.Width = 125
        '
        'accountsPassRecovery
        '
        Me.accountsPassRecovery.DataPropertyName = "PassRecovery"
        Me.accountsPassRecovery.HeaderText = "PassRecovery"
        Me.accountsPassRecovery.MinimumWidth = 6
        Me.accountsPassRecovery.Name = "accountsPassRecovery"
        Me.accountsPassRecovery.ReadOnly = True
        Me.accountsPassRecovery.Width = 125
        '
        'accountsStatus
        '
        Me.accountsStatus.DataPropertyName = "Status"
        Me.accountsStatus.HeaderText = "Status"
        Me.accountsStatus.MinimumWidth = 6
        Me.accountsStatus.Name = "accountsStatus"
        Me.accountsStatus.ReadOnly = True
        Me.accountsStatus.Width = 125
        '
        'accountsDateTime
        '
        Me.accountsDateTime.DataPropertyName = "createdDateTime"
        Me.accountsDateTime.HeaderText = "createdDateTime"
        Me.accountsDateTime.MinimumWidth = 6
        Me.accountsDateTime.Name = "accountsDateTime"
        Me.accountsDateTime.ReadOnly = True
        Me.accountsDateTime.Width = 125
        '
        'btnDelete
        '
        Me.btnDelete.HeaderText = "Action"
        Me.btnDelete.MinimumWidth = 6
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.ReadOnly = True
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.ToolTipText = "Delete"
        Me.btnDelete.UseColumnTextForButtonValue = True
        Me.btnDelete.Width = 125
        '
        'btnEdit
        '
        Me.btnEdit.HeaderText = "Action"
        Me.btnEdit.MinimumWidth = 6
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.ReadOnly = True
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.ToolTipText = "Edit"
        Me.btnEdit.UseColumnTextForButtonValue = True
        Me.btnEdit.Width = 125
        '
        'btnInactive
        '
        Me.btnInactive.HeaderText = "Action"
        Me.btnInactive.MinimumWidth = 6
        Me.btnInactive.Name = "btnInactive"
        Me.btnInactive.ReadOnly = True
        Me.btnInactive.Text = "Inactive/Active"
        Me.btnInactive.ToolTipText = "Inactive/Active"
        Me.btnInactive.UseColumnTextForButtonValue = True
        Me.btnInactive.Width = 125
        '
        'AccountsBindingSource
        '
        Me.AccountsBindingSource.DataMember = "Accounts"
        Me.AccountsBindingSource.DataSource = Me.AccountsDataSet
        '
        'AccountsDataSet
        '
        Me.AccountsDataSet.DataSetName = "accountsDataSet"
        Me.AccountsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AccountsTableAdapter
        '
        Me.AccountsTableAdapter.ClearBeforeFill = True
        '
        'tbxName
        '
        Me.tbxName.Font = New System.Drawing.Font("Segoe UI Light", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxName.Location = New System.Drawing.Point(22, 269)
        Me.tbxName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbxName.Name = "tbxName"
        Me.tbxName.Size = New System.Drawing.Size(316, 38)
        Me.tbxName.TabIndex = 1
        '
        'tbxEmail
        '
        Me.tbxEmail.Font = New System.Drawing.Font("Segoe UI Light", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxEmail.Location = New System.Drawing.Point(22, 345)
        Me.tbxEmail.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbxEmail.Name = "tbxEmail"
        Me.tbxEmail.Size = New System.Drawing.Size(316, 38)
        Me.tbxEmail.TabIndex = 2
        '
        'tbxUsername
        '
        Me.tbxUsername.Font = New System.Drawing.Font("Segoe UI Light", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxUsername.Location = New System.Drawing.Point(20, 563)
        Me.tbxUsername.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbxUsername.Name = "tbxUsername"
        Me.tbxUsername.Size = New System.Drawing.Size(318, 38)
        Me.tbxUsername.TabIndex = 3
        '
        'tbxPassword
        '
        Me.tbxPassword.Font = New System.Drawing.Font("Segoe UI Light", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxPassword.Location = New System.Drawing.Point(20, 640)
        Me.tbxPassword.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbxPassword.Name = "tbxPassword"
        Me.tbxPassword.Size = New System.Drawing.Size(318, 38)
        Me.tbxPassword.TabIndex = 4
        '
        'tbxRecoveryPass
        '
        Me.tbxRecoveryPass.Font = New System.Drawing.Font("Segoe UI Light", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxRecoveryPass.Location = New System.Drawing.Point(20, 717)
        Me.tbxRecoveryPass.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbxRecoveryPass.Name = "tbxRecoveryPass"
        Me.tbxRecoveryPass.Size = New System.Drawing.Size(318, 38)
        Me.tbxRecoveryPass.TabIndex = 5
        '
        'tbxType
        '
        Me.tbxType.BackColor = System.Drawing.Color.White
        Me.tbxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.tbxType.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.tbxType.Font = New System.Drawing.Font("Segoe UI Light", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxType.FormattingEnabled = True
        Me.tbxType.Items.AddRange(New Object() {"Cashier", "Kitchen", "Staff"})
        Me.tbxType.Location = New System.Drawing.Point(22, 483)
        Me.tbxType.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbxType.Name = "tbxType"
        Me.tbxType.Size = New System.Drawing.Size(316, 39)
        Me.tbxType.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(28, 528)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 26)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Username:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(30, 312)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 26)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Email:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(30, 606)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 26)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Password:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(34, 450)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 26)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Type"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(30, 684)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(212, 26)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Recovery Password"
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Transparent
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.Black
        Me.btnBack.Location = New System.Drawing.Point(39, 14)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(156, 66)
        Me.btnBack.TabIndex = 16
        Me.btnBack.Text = "Back"
        Me.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'tbxID
        '
        Me.tbxID.Font = New System.Drawing.Font("Segoe UI Light", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxID.Location = New System.Drawing.Point(1063, 841)
        Me.tbxID.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbxID.Name = "tbxID"
        Me.tbxID.Size = New System.Drawing.Size(100, 38)
        Me.tbxID.TabIndex = 18
        Me.tbxID.Visible = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Aqua
        Me.btnSave.BackgroundImage = Global.Ordering_and_Billing_System_With_Inventory.My.Resources.Resources.save_32px
        Me.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.Black
        Me.btnSave.Location = New System.Drawing.Point(254, 812)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(105, 83)
        Me.btnSave.TabIndex = 17
        Me.btnSave.Text = "Update"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.Aqua
        Me.btnAdd.BackgroundImage = Global.Ordering_and_Billing_System_With_Inventory.My.Resources.Resources.add_32px
        Me.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.Black
        Me.btnAdd.Location = New System.Drawing.Point(22, 812)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(107, 83)
        Me.btnAdd.TabIndex = 15
        Me.btnAdd.Text = "Add"
        Me.btnAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Aqua
        Me.btnClear.BackgroundImage = Global.Ordering_and_Billing_System_With_Inventory.My.Resources.Resources.clear_symbol_32px
        Me.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.Black
        Me.btnClear.Location = New System.Drawing.Point(137, 812)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(109, 83)
        Me.btnClear.TabIndex = 14
        Me.btnClear.Text = "Clear"
        Me.btnClear.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnRefresh
        '
        Me.btnRefresh.BackColor = System.Drawing.Color.Transparent
        Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefresh.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.Image = Global.Ordering_and_Billing_System_With_Inventory.My.Resources.Resources.refresh_32px
        Me.btnRefresh.Location = New System.Drawing.Point(1233, 812)
        Me.btnRefresh.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(146, 69)
        Me.btnRefresh.TabIndex = 13
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Light", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(948, 847)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(93, 32)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "User ID:"
        Me.Label7.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(30, 233)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 26)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Name:"
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Light", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(-16, 754)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(330, 53)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "______________________________"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Light", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label8.Location = New System.Drawing.Point(181, 388)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 59)
        Me.Label8.TabIndex = 42
        Me.Label8.Text = "..."
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Segoe UI Light", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(-16, 180)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(330, 53)
        Me.Label12.TabIndex = 43
        Me.Label12.Text = "______________________________"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label11.Location = New System.Drawing.Point(717, 134)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(324, 45)
        Me.Label11.TabIndex = 47
        Me.Label11.Text = "ACCOUNT LIST"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Segoe UI Light", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label13.Location = New System.Drawing.Point(867, 134)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(55, 59)
        Me.Label13.TabIndex = 48
        Me.Label13.Text = "..."
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(269, 83)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1186, 33)
        Me.PictureBox1.TabIndex = 44
        Me.PictureBox1.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label9.Location = New System.Drawing.Point(261, 35)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(245, 45)
        Me.Label9.TabIndex = 45
        Me.Label9.Text = "ACCOUNTS"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.InitialImage = Nothing
        Me.PictureBox3.Location = New System.Drawing.Point(1147, -1)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(159, 147)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 46
        Me.PictureBox3.TabStop = False
        '
        'Accounts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 29.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1421, 1005)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.tbxEmail)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.tbxID)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbxType)
        Me.Controls.Add(Me.tbxRecoveryPass)
        Me.Controls.Add(Me.tbxPassword)
        Me.Controls.Add(Me.tbxUsername)
        Me.Controls.Add(Me.tbxName)
        Me.Controls.Add(Me.accountsDataGrid)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MinimumSize = New System.Drawing.Size(1278, 982)
        Me.Name = "Accounts"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Accounts"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.accountsDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccountsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccountsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents accountsDataGrid As DataGridView
    Friend WithEvents AccountsDataSet As accountsDataSet
    Friend WithEvents AccountsBindingSource As BindingSource
    Friend WithEvents AccountsTableAdapter As accountsDataSetTableAdapters.AccountsTableAdapter
    Friend WithEvents tbxName As TextBox
    Friend WithEvents tbxEmail As TextBox
    Friend WithEvents tbxUsername As TextBox
    Friend WithEvents tbxPassword As TextBox
    Friend WithEvents tbxRecoveryPass As TextBox
    Friend WithEvents tbxType As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents accountsID As DataGridViewTextBoxColumn
    Friend WithEvents accountsName As DataGridViewTextBoxColumn
    Friend WithEvents accountsUsername As DataGridViewTextBoxColumn
    Friend WithEvents accountsPassword As DataGridViewTextBoxColumn
    Friend WithEvents accountsType As DataGridViewTextBoxColumn
    Friend WithEvents accountsEmail As DataGridViewTextBoxColumn
    Friend WithEvents accountsPassRecovery As DataGridViewTextBoxColumn
    Friend WithEvents accountsStatus As DataGridViewTextBoxColumn
    Friend WithEvents accountsDateTime As DataGridViewTextBoxColumn
    Friend WithEvents btnDelete As DataGridViewButtonColumn
    Friend WithEvents btnEdit As DataGridViewButtonColumn
    Friend WithEvents btnInactive As DataGridViewButtonColumn
    Friend WithEvents btnSave As Button
    Friend WithEvents tbxID As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label9 As Label
    Friend WithEvents PictureBox3 As PictureBox
End Class
