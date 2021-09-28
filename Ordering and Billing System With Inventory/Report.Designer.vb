<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Report
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Report))
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend3 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series4 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series5 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea4 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend4 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series6 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series7 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.billingsSales = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.BillingDSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BillingDS = New Ordering_and_Billing_System_With_Inventory.billingDS()
        Me.BillingsTableAdapter = New Ordering_and_Billing_System_With_Inventory.billingDSTableAdapters.BillingsTableAdapter()
        Me.billingsMonthlyDate = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.orderMonthlyDate = New System.Windows.Forms.DateTimePicker()
        Me.orderTransaction = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.deliveryMonthlyDate = New System.Windows.Forms.DateTimePicker()
        Me.deliveryTransaction = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.reservationMonthlyDate = New System.Windows.Forms.DateTimePicker()
        Me.reservationTransaction = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.billingsSales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BillingDSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BillingDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.orderTransaction, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deliveryTransaction, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.reservationTransaction, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.InitialImage = Nothing
        Me.PictureBox3.Location = New System.Drawing.Point(1138, 76)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(119, 119)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 54
        Me.PictureBox3.TabStop = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label11.Location = New System.Drawing.Point(121, 110)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(161, 40)
        Me.Label11.TabIndex = 53
        Me.Label11.Text = "REPORT"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(252, 120)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1062, 27)
        Me.PictureBox1.TabIndex = 52
        Me.PictureBox1.TabStop = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Transparent
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnBack.Location = New System.Drawing.Point(32, 33)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(104, 52)
        Me.btnBack.TabIndex = 51
        Me.btnBack.Text = "Back"
        Me.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'billingsSales
        '
        Me.billingsSales.BackColor = System.Drawing.Color.Transparent
        Me.billingsSales.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid
        ChartArea1.AxisX.MajorGrid.LineWidth = 0
        ChartArea1.Name = "ChartArea1"
        Me.billingsSales.ChartAreas.Add(ChartArea1)
        Me.billingsSales.DataSource = Me.BillingDSBindingSource
        Legend1.Name = "Legend1"
        Legend1.Title = "Sales"
        Legend1.TitleSeparator = System.Windows.Forms.DataVisualization.Charting.LegendSeparatorStyle.Line
        Me.billingsSales.Legends.Add(Legend1)
        Me.billingsSales.Location = New System.Drawing.Point(30, 72)
        Me.billingsSales.Margin = New System.Windows.Forms.Padding(2)
        Me.billingsSales.Name = "billingsSales"
        Me.billingsSales.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen
        Series1.ChartArea = "ChartArea1"
        Series1.IsValueShownAsLabel = True
        Series1.Legend = "Legend1"
        Series1.Name = "Monthly Sales"
        Me.billingsSales.Series.Add(Series1)
        Me.billingsSales.Size = New System.Drawing.Size(670, 282)
        Me.billingsSales.TabIndex = 55
        Me.billingsSales.Text = "Chart1"
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
        'BillingsTableAdapter
        '
        Me.BillingsTableAdapter.ClearBeforeFill = True
        '
        'billingsMonthlyDate
        '
        Me.billingsMonthlyDate.Font = New System.Drawing.Font("Segoe UI Light", 12.0!)
        Me.billingsMonthlyDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.billingsMonthlyDate.Location = New System.Drawing.Point(550, 17)
        Me.billingsMonthlyDate.Margin = New System.Windows.Forms.Padding(2)
        Me.billingsMonthlyDate.Name = "billingsMonthlyDate"
        Me.billingsMonthlyDate.ShowUpDown = True
        Me.billingsMonthlyDate.Size = New System.Drawing.Size(151, 29)
        Me.billingsMonthlyDate.TabIndex = 56
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 17.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(26, 17)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 25)
        Me.Label1.TabIndex = 57
        Me.Label1.Text = "BILLINGS"
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
        'orderMonthlyDate
        '
        Me.orderMonthlyDate.Font = New System.Drawing.Font("Segoe UI Light", 12.0!)
        Me.orderMonthlyDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.orderMonthlyDate.Location = New System.Drawing.Point(564, 20)
        Me.orderMonthlyDate.Margin = New System.Windows.Forms.Padding(2)
        Me.orderMonthlyDate.Name = "orderMonthlyDate"
        Me.orderMonthlyDate.ShowUpDown = True
        Me.orderMonthlyDate.Size = New System.Drawing.Size(151, 29)
        Me.orderMonthlyDate.TabIndex = 59
        '
        'orderTransaction
        '
        Me.orderTransaction.BackColor = System.Drawing.Color.Transparent
        Me.orderTransaction.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid
        ChartArea2.AxisX.MajorGrid.LineWidth = 0
        ChartArea2.Name = "ChartArea1"
        Me.orderTransaction.ChartAreas.Add(ChartArea2)
        Me.orderTransaction.DataSource = Me.BillingDSBindingSource
        Legend2.Name = "Legend1"
        Legend2.Title = "Order"
        Legend2.TitleSeparator = System.Windows.Forms.DataVisualization.Charting.LegendSeparatorStyle.Line
        Me.orderTransaction.Legends.Add(Legend2)
        Me.orderTransaction.Location = New System.Drawing.Point(32, 68)
        Me.orderTransaction.Margin = New System.Windows.Forms.Padding(2)
        Me.orderTransaction.Name = "orderTransaction"
        Series2.ChartArea = "ChartArea1"
        Series2.IsValueShownAsLabel = True
        Series2.Legend = "Legend1"
        Series2.Name = "Cancel"
        Series3.ChartArea = "ChartArea1"
        Series3.Legend = "Legend1"
        Series3.Name = "Complete"
        Me.orderTransaction.Series.Add(Series2)
        Me.orderTransaction.Series.Add(Series3)
        Me.orderTransaction.Size = New System.Drawing.Size(682, 293)
        Me.orderTransaction.TabIndex = 58
        Me.orderTransaction.Text = "Chart1"
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
        'deliveryMonthlyDate
        '
        Me.deliveryMonthlyDate.Font = New System.Drawing.Font("Segoe UI Light", 12.0!)
        Me.deliveryMonthlyDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.deliveryMonthlyDate.Location = New System.Drawing.Point(584, 20)
        Me.deliveryMonthlyDate.Margin = New System.Windows.Forms.Padding(2)
        Me.deliveryMonthlyDate.Name = "deliveryMonthlyDate"
        Me.deliveryMonthlyDate.ShowUpDown = True
        Me.deliveryMonthlyDate.Size = New System.Drawing.Size(151, 29)
        Me.deliveryMonthlyDate.TabIndex = 62
        '
        'deliveryTransaction
        '
        Me.deliveryTransaction.BackColor = System.Drawing.Color.Transparent
        Me.deliveryTransaction.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid
        ChartArea3.AxisX.MajorGrid.LineWidth = 0
        ChartArea3.Name = "ChartArea1"
        Me.deliveryTransaction.ChartAreas.Add(ChartArea3)
        Me.deliveryTransaction.DataSource = Me.BillingDSBindingSource
        Legend3.Name = "Legend1"
        Legend3.Title = "Delivery"
        Legend3.TitleSeparator = System.Windows.Forms.DataVisualization.Charting.LegendSeparatorStyle.Line
        Me.deliveryTransaction.Legends.Add(Legend3)
        Me.deliveryTransaction.Location = New System.Drawing.Point(23, 69)
        Me.deliveryTransaction.Margin = New System.Windows.Forms.Padding(2)
        Me.deliveryTransaction.Name = "deliveryTransaction"
        Me.deliveryTransaction.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate
        Series4.ChartArea = "ChartArea1"
        Series4.IsValueShownAsLabel = True
        Series4.Legend = "Legend1"
        Series4.Name = "Cancel"
        Series5.ChartArea = "ChartArea1"
        Series5.Legend = "Legend1"
        Series5.Name = "Complete"
        Me.deliveryTransaction.Series.Add(Series4)
        Me.deliveryTransaction.Series.Add(Series5)
        Me.deliveryTransaction.Size = New System.Drawing.Size(710, 291)
        Me.deliveryTransaction.TabIndex = 61
        Me.deliveryTransaction.Text = "Chart1"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 17.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(27, 23)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(174, 25)
        Me.Label4.TabIndex = 66
        Me.Label4.Text = "RESERVATION"
        '
        'reservationMonthlyDate
        '
        Me.reservationMonthlyDate.Font = New System.Drawing.Font("Segoe UI Light", 12.0!)
        Me.reservationMonthlyDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.reservationMonthlyDate.Location = New System.Drawing.Point(575, 23)
        Me.reservationMonthlyDate.Margin = New System.Windows.Forms.Padding(2)
        Me.reservationMonthlyDate.Name = "reservationMonthlyDate"
        Me.reservationMonthlyDate.ShowUpDown = True
        Me.reservationMonthlyDate.Size = New System.Drawing.Size(151, 29)
        Me.reservationMonthlyDate.TabIndex = 65
        '
        'reservationTransaction
        '
        Me.reservationTransaction.BackColor = System.Drawing.Color.Transparent
        Me.reservationTransaction.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid
        ChartArea4.AxisX.MajorGrid.LineWidth = 0
        ChartArea4.Name = "ChartArea1"
        Me.reservationTransaction.ChartAreas.Add(ChartArea4)
        Me.reservationTransaction.DataSource = Me.BillingDSBindingSource
        Legend4.Name = "Legend1"
        Legend4.Title = "Reservation"
        Legend4.TitleSeparator = System.Windows.Forms.DataVisualization.Charting.LegendSeparatorStyle.Line
        Me.reservationTransaction.Legends.Add(Legend4)
        Me.reservationTransaction.Location = New System.Drawing.Point(32, 80)
        Me.reservationTransaction.Margin = New System.Windows.Forms.Padding(2)
        Me.reservationTransaction.Name = "reservationTransaction"
        Me.reservationTransaction.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry
        Series6.ChartArea = "ChartArea1"
        Series6.IsValueShownAsLabel = True
        Series6.Legend = "Legend1"
        Series6.Name = "Cancel"
        Series7.ChartArea = "ChartArea1"
        Series7.Legend = "Legend1"
        Series7.Name = "Reserved"
        Me.reservationTransaction.Series.Add(Series6)
        Me.reservationTransaction.Series.Add(Series7)
        Me.reservationTransaction.Size = New System.Drawing.Size(694, 277)
        Me.reservationTransaction.TabIndex = 64
        Me.reservationTransaction.Text = "Chart1"
        '
        'TabControl1
        '
        Me.TabControl1.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed
        Me.TabControl1.ItemSize = New System.Drawing.Size(30, 120)
        Me.TabControl1.Location = New System.Drawing.Point(252, 235)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(2)
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(992, 436)
        Me.TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.TabControl1.TabIndex = 67
        '
        'TabPage1
        '
        Me.TabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.TabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPage1.Controls.Add(Me.billingsSales)
        Me.TabPage1.Controls.Add(Me.billingsMonthlyDate)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(124, 4)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPage1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TabPage1.Size = New System.Drawing.Size(864, 428)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Billings"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.orderTransaction)
        Me.TabPage2.Controls.Add(Me.orderMonthlyDate)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Location = New System.Drawing.Point(124, 4)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPage2.Size = New System.Drawing.Size(864, 428)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Orders"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.deliveryTransaction)
        Me.TabPage3.Controls.Add(Me.deliveryMonthlyDate)
        Me.TabPage3.Controls.Add(Me.Label3)
        Me.TabPage3.Location = New System.Drawing.Point(124, 4)
        Me.TabPage3.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(864, 428)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Delivery"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.reservationTransaction)
        Me.TabPage4.Controls.Add(Me.Label4)
        Me.TabPage4.Controls.Add(Me.reservationMonthlyDate)
        Me.TabPage4.Location = New System.Drawing.Point(124, 4)
        Me.TabPage4.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(864, 428)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Reservation"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'Report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1600, 900)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnBack)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximumSize = New System.Drawing.Size(1600, 900)
        Me.MinimumSize = New System.Drawing.Size(1198, 730)
        Me.Name = "Report"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Report"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.billingsSales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BillingDSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BillingDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.orderTransaction, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deliveryTransaction, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.reservationTransaction, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label11 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnBack As Button
    Friend WithEvents billingsSales As DataVisualization.Charting.Chart
    Friend WithEvents BillingDSBindingSource As BindingSource
    Friend WithEvents BillingDS As billingDS
    Friend WithEvents BillingsTableAdapter As billingDSTableAdapters.BillingsTableAdapter
    Friend WithEvents billingsMonthlyDate As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents orderMonthlyDate As DateTimePicker
    Friend WithEvents orderTransaction As DataVisualization.Charting.Chart
    Friend WithEvents Label3 As Label
    Friend WithEvents deliveryMonthlyDate As DateTimePicker
    Friend WithEvents deliveryTransaction As DataVisualization.Charting.Chart
    Friend WithEvents Label4 As Label
    Friend WithEvents reservationMonthlyDate As DateTimePicker
    Friend WithEvents reservationTransaction As DataVisualization.Charting.Chart
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
End Class
