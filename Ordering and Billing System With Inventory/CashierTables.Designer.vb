<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CashierTables
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CashierTables))
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.tablesDGV = New System.Windows.Forms.DataGridView()
        Me.tableID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableNumDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DetailsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tableStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CreatedDateTimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusChange = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.TableManagementBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableManagementDSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableManagementDS = New Ordering_and_Billing_System_With_Inventory.TableManagementDS()
        Me.TableManagementTableAdapter = New Ordering_and_Billing_System_With_Inventory.TableManagementDSTableAdapters.TableManagementTableAdapter()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tablesDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TableManagementBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TableManagementDSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TableManagementDS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.InitialImage = Nothing
        Me.PictureBox3.Location = New System.Drawing.Point(1312, 75)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(119, 119)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 45
        Me.PictureBox3.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(130, 122)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(390, 40)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "TABLE AVAILABILITY"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(240, 167)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1046, 27)
        Me.PictureBox1.TabIndex = 43
        Me.PictureBox1.TabStop = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Transparent
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Times New Roman", 17.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnBack.Location = New System.Drawing.Point(32, 33)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(122, 44)
        Me.btnBack.TabIndex = 46
        Me.btnBack.Text = "Back"
        Me.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'tablesDGV
        '
        Me.tablesDGV.AllowUserToAddRows = False
        Me.tablesDGV.AllowUserToDeleteRows = False
        Me.tablesDGV.AutoGenerateColumns = False
        Me.tablesDGV.BackgroundColor = System.Drawing.Color.White
        Me.tablesDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tablesDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.tableID, Me.TableNumDataGridViewTextBoxColumn, Me.DetailsDataGridViewTextBoxColumn, Me.tableStatus, Me.CreatedDateTimeDataGridViewTextBoxColumn, Me.StatusChange})
        Me.tablesDGV.DataSource = Me.TableManagementBindingSource
        Me.tablesDGV.Location = New System.Drawing.Point(477, 234)
        Me.tablesDGV.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tablesDGV.Name = "tablesDGV"
        Me.tablesDGV.ReadOnly = True
        Me.tablesDGV.RowHeadersWidth = 51
        Me.tablesDGV.RowTemplate.Height = 24
        Me.tablesDGV.Size = New System.Drawing.Size(681, 448)
        Me.tablesDGV.TabIndex = 47
        '
        'tableID
        '
        Me.tableID.DataPropertyName = "ID"
        Me.tableID.HeaderText = "ID"
        Me.tableID.MinimumWidth = 6
        Me.tableID.Name = "tableID"
        Me.tableID.ReadOnly = True
        Me.tableID.Visible = False
        Me.tableID.Width = 125
        '
        'TableNumDataGridViewTextBoxColumn
        '
        Me.TableNumDataGridViewTextBoxColumn.DataPropertyName = "TableNum"
        Me.TableNumDataGridViewTextBoxColumn.HeaderText = "TableNum"
        Me.TableNumDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TableNumDataGridViewTextBoxColumn.Name = "TableNumDataGridViewTextBoxColumn"
        Me.TableNumDataGridViewTextBoxColumn.ReadOnly = True
        Me.TableNumDataGridViewTextBoxColumn.Width = 125
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
        'tableStatus
        '
        Me.tableStatus.DataPropertyName = "Status"
        Me.tableStatus.HeaderText = "Status"
        Me.tableStatus.MinimumWidth = 6
        Me.tableStatus.Name = "tableStatus"
        Me.tableStatus.ReadOnly = True
        Me.tableStatus.Width = 125
        '
        'CreatedDateTimeDataGridViewTextBoxColumn
        '
        Me.CreatedDateTimeDataGridViewTextBoxColumn.DataPropertyName = "createdDateTime"
        Me.CreatedDateTimeDataGridViewTextBoxColumn.HeaderText = "Date and Time"
        Me.CreatedDateTimeDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CreatedDateTimeDataGridViewTextBoxColumn.Name = "CreatedDateTimeDataGridViewTextBoxColumn"
        Me.CreatedDateTimeDataGridViewTextBoxColumn.ReadOnly = True
        Me.CreatedDateTimeDataGridViewTextBoxColumn.Width = 125
        '
        'StatusChange
        '
        Me.StatusChange.HeaderText = "Action"
        Me.StatusChange.MinimumWidth = 6
        Me.StatusChange.Name = "StatusChange"
        Me.StatusChange.ReadOnly = True
        Me.StatusChange.Text = "Available/Unavailable"
        Me.StatusChange.ToolTipText = "Available/Unavailable"
        Me.StatusChange.UseColumnTextForButtonValue = True
        Me.StatusChange.Width = 125
        '
        'TableManagementBindingSource
        '
        Me.TableManagementBindingSource.DataMember = "TableManagement"
        Me.TableManagementBindingSource.DataSource = Me.TableManagementDSBindingSource
        '
        'TableManagementDSBindingSource
        '
        Me.TableManagementDSBindingSource.DataSource = Me.TableManagementDS
        Me.TableManagementDSBindingSource.Position = 0
        '
        'TableManagementDS
        '
        Me.TableManagementDS.DataSetName = "TableManagementDS"
        Me.TableManagementDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TableManagementTableAdapter
        '
        Me.TableManagementTableAdapter.ClearBeforeFill = True
        '
        'CashierTables
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1600, 900)
        Me.Controls.Add(Me.tablesDGV)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PictureBox1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MaximumSize = New System.Drawing.Size(1600, 900)
        Me.MinimumSize = New System.Drawing.Size(1198, 730)
        Me.Name = "CashierTables"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CashierTables"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tablesDGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TableManagementBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TableManagementDSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TableManagementDS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnBack As Button
    Friend WithEvents tablesDGV As DataGridView
    Friend WithEvents TableManagementDSBindingSource As BindingSource
    Friend WithEvents TableManagementDS As TableManagementDS
    Friend WithEvents TableManagementBindingSource As BindingSource
    Friend WithEvents TableManagementTableAdapter As TableManagementDSTableAdapters.TableManagementTableAdapter
    Friend WithEvents tableID As DataGridViewTextBoxColumn
    Friend WithEvents TableNumDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DetailsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents tableStatus As DataGridViewTextBoxColumn
    Friend WithEvents CreatedDateTimeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StatusChange As DataGridViewButtonColumn
End Class
