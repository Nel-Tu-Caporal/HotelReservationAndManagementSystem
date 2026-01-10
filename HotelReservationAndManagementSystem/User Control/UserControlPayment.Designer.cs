namespace HotelReservationAndManagementSystem.User_Control
{
    partial class UserControlPayment
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControlBillsAndPayment = new System.Windows.Forms.TabControl();
            this.tabPageSelectBilling = new System.Windows.Forms.TabPage();
            this.btnSelect = new System.Windows.Forms.Button();
            this.dataGridViewBilling = new System.Windows.Forms.DataGridView();
            this.txtBoxSearchReservationID = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.labelAddReservation = new System.Windows.Forms.Label();
            this.tabPageBilling = new System.Windows.Forms.TabPage();
            this.dateTimePickerCheckOutDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerCheckInDate = new System.Windows.Forms.DateTimePicker();
            this.btnAddReservation = new System.Windows.Forms.Button();
            this.txtBoxTotalAmount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxRatePerDay = new System.Windows.Forms.TextBox();
            this.txtBoxTotalDays = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxRoomNo = new System.Windows.Forms.TextBox();
            this.txtBoxRoomType = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblIN = new System.Windows.Forms.Label();
            this.lblRoomNo = new System.Windows.Forms.Label();
            this.lblRoomType = new System.Windows.Forms.Label();
            this.tabPagePayment = new System.Windows.Forms.TabPage();
            this.lblStatusPayment = new System.Windows.Forms.Label();
            this.lblPaymentStatus = new System.Windows.Forms.Label();
            this.txtBoxTotalAmount1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnPay = new System.Windows.Forms.Button();
            this.dateTimePickerPaymentDate = new System.Windows.Forms.DateTimePicker();
            this.txtBoxChange = new System.Windows.Forms.TextBox();
            this.txtBoxAmountPaid = new System.Windows.Forms.TextBox();
            this.comboBoxPaymentMethod = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.colCheckInOutID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReservationID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRoomNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRoomType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCheckIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCheckOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotals = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPaymentStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControlBillsAndPayment.SuspendLayout();
            this.tabPageSelectBilling.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBilling)).BeginInit();
            this.tabPageBilling.SuspendLayout();
            this.tabPagePayment.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlBillsAndPayment
            // 
            this.tabControlBillsAndPayment.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControlBillsAndPayment.Controls.Add(this.tabPageSelectBilling);
            this.tabControlBillsAndPayment.Controls.Add(this.tabPageBilling);
            this.tabControlBillsAndPayment.Controls.Add(this.tabPagePayment);
            this.tabControlBillsAndPayment.Location = new System.Drawing.Point(20, 28);
            this.tabControlBillsAndPayment.Name = "tabControlBillsAndPayment";
            this.tabControlBillsAndPayment.SelectedIndex = 0;
            this.tabControlBillsAndPayment.Size = new System.Drawing.Size(1004, 367);
            this.tabControlBillsAndPayment.TabIndex = 0;
            this.tabControlBillsAndPayment.Enter += new System.EventHandler(this.tabControlBillsAndPayment_Enter);
            // 
            // tabPageSelectBilling
            // 
            this.tabPageSelectBilling.Controls.Add(this.btnSelect);
            this.tabPageSelectBilling.Controls.Add(this.dataGridViewBilling);
            this.tabPageSelectBilling.Controls.Add(this.txtBoxSearchReservationID);
            this.tabPageSelectBilling.Controls.Add(this.lblId);
            this.tabPageSelectBilling.Controls.Add(this.labelAddReservation);
            this.tabPageSelectBilling.Location = new System.Drawing.Point(4, 4);
            this.tabPageSelectBilling.Name = "tabPageSelectBilling";
            this.tabPageSelectBilling.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSelectBilling.Size = new System.Drawing.Size(996, 331);
            this.tabPageSelectBilling.TabIndex = 0;
            this.tabPageSelectBilling.Text = "Select Client";
            this.tabPageSelectBilling.UseVisualStyleBackColor = true;
            this.tabPageSelectBilling.Click += new System.EventHandler(this.tabPage1_Click);
            this.tabPageSelectBilling.Enter += new System.EventHandler(this.tabPageSelectBilling_Enter);
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.Color.Brown;
            this.btnSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.ForeColor = System.Drawing.Color.White;
            this.btnSelect.Location = new System.Drawing.Point(50, 270);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(144, 52);
            this.btnSelect.TabIndex = 23;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // dataGridViewBilling
            // 
            this.dataGridViewBilling.AllowUserToAddRows = false;
            this.dataGridViewBilling.AllowUserToDeleteRows = false;
            this.dataGridViewBilling.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewBilling.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBilling.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBilling.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCheckInOutID,
            this.colReservationID,
            this.colClientName,
            this.colRoomNo,
            this.colRoomType,
            this.colCheckIn,
            this.colCheckOut,
            this.colRate,
            this.colTotal,
            this.colTotals,
            this.colPaymentStatus});
            this.dataGridViewBilling.Location = new System.Drawing.Point(32, 105);
            this.dataGridViewBilling.Name = "dataGridViewBilling";
            this.dataGridViewBilling.ReadOnly = true;
            this.dataGridViewBilling.RowHeadersWidth = 62;
            this.dataGridViewBilling.RowTemplate.Height = 28;
            this.dataGridViewBilling.Size = new System.Drawing.Size(939, 159);
            this.dataGridViewBilling.TabIndex = 22;
            this.dataGridViewBilling.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBilling_CellClick);
            // 
            // txtBoxSearchReservationID
            // 
            this.txtBoxSearchReservationID.Location = new System.Drawing.Point(191, 67);
            this.txtBoxSearchReservationID.Name = "txtBoxSearchReservationID";
            this.txtBoxSearchReservationID.Size = new System.Drawing.Size(254, 32);
            this.txtBoxSearchReservationID.TabIndex = 21;
            this.txtBoxSearchReservationID.TextChanged += new System.EventHandler(this.txtBoxSearchReservationID_TextChanged);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(187, 41);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(155, 23);
            this.lblId.TabIndex = 20;
            this.lblId.Text = "Reservation ID:";
            // 
            // labelAddReservation
            // 
            this.labelAddReservation.AutoSize = true;
            this.labelAddReservation.ForeColor = System.Drawing.Color.Brown;
            this.labelAddReservation.Location = new System.Drawing.Point(7, 8);
            this.labelAddReservation.Name = "labelAddReservation";
            this.labelAddReservation.Size = new System.Drawing.Size(187, 23);
            this.labelAddReservation.TabIndex = 19;
            this.labelAddReservation.Text = "Bills and Payment:";
            // 
            // tabPageBilling
            // 
            this.tabPageBilling.Controls.Add(this.dateTimePickerCheckOutDate);
            this.tabPageBilling.Controls.Add(this.dateTimePickerCheckInDate);
            this.tabPageBilling.Controls.Add(this.btnAddReservation);
            this.tabPageBilling.Controls.Add(this.txtBoxTotalAmount);
            this.tabPageBilling.Controls.Add(this.label5);
            this.tabPageBilling.Controls.Add(this.txtBoxRatePerDay);
            this.tabPageBilling.Controls.Add(this.txtBoxTotalDays);
            this.tabPageBilling.Controls.Add(this.label4);
            this.tabPageBilling.Controls.Add(this.label3);
            this.tabPageBilling.Controls.Add(this.txtBoxRoomNo);
            this.tabPageBilling.Controls.Add(this.txtBoxRoomType);
            this.tabPageBilling.Controls.Add(this.label1);
            this.tabPageBilling.Controls.Add(this.label2);
            this.tabPageBilling.Controls.Add(this.lblIN);
            this.tabPageBilling.Controls.Add(this.lblRoomNo);
            this.tabPageBilling.Controls.Add(this.lblRoomType);
            this.tabPageBilling.Location = new System.Drawing.Point(4, 4);
            this.tabPageBilling.Name = "tabPageBilling";
            this.tabPageBilling.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBilling.Size = new System.Drawing.Size(996, 331);
            this.tabPageBilling.TabIndex = 1;
            this.tabPageBilling.Text = "Billing";
            this.tabPageBilling.UseVisualStyleBackColor = true;
            this.tabPageBilling.Click += new System.EventHandler(this.tabPageBilling_Click);
            this.tabPageBilling.Enter += new System.EventHandler(this.tabPageBilling_Enter);
            // 
            // dateTimePickerCheckOutDate
            // 
            this.dateTimePickerCheckOutDate.Enabled = false;
            this.dateTimePickerCheckOutDate.Location = new System.Drawing.Point(290, 168);
            this.dateTimePickerCheckOutDate.Name = "dateTimePickerCheckOutDate";
            this.dateTimePickerCheckOutDate.Size = new System.Drawing.Size(232, 32);
            this.dateTimePickerCheckOutDate.TabIndex = 44;
            // 
            // dateTimePickerCheckInDate
            // 
            this.dateTimePickerCheckInDate.Enabled = false;
            this.dateTimePickerCheckInDate.Location = new System.Drawing.Point(24, 168);
            this.dateTimePickerCheckInDate.Name = "dateTimePickerCheckInDate";
            this.dateTimePickerCheckInDate.Size = new System.Drawing.Size(232, 32);
            this.dateTimePickerCheckInDate.TabIndex = 43;
            // 
            // btnAddReservation
            // 
            this.btnAddReservation.BackColor = System.Drawing.Color.Brown;
            this.btnAddReservation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddReservation.ForeColor = System.Drawing.Color.White;
            this.btnAddReservation.Location = new System.Drawing.Point(592, 242);
            this.btnAddReservation.Name = "btnAddReservation";
            this.btnAddReservation.Size = new System.Drawing.Size(189, 52);
            this.btnAddReservation.TabIndex = 20;
            this.btnAddReservation.Text = "Proceed to Payment";
            this.btnAddReservation.UseVisualStyleBackColor = false;
            this.btnAddReservation.Click += new System.EventHandler(this.btnAddReservation_Click_1);
            // 
            // txtBoxTotalAmount
            // 
            this.txtBoxTotalAmount.Location = new System.Drawing.Point(24, 252);
            this.txtBoxTotalAmount.Name = "txtBoxTotalAmount";
            this.txtBoxTotalAmount.ReadOnly = true;
            this.txtBoxTotalAmount.Size = new System.Drawing.Size(232, 32);
            this.txtBoxTotalAmount.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 23);
            this.label5.TabIndex = 41;
            this.label5.Text = "Total Amount:";
            // 
            // txtBoxRatePerDay
            // 
            this.txtBoxRatePerDay.Enabled = false;
            this.txtBoxRatePerDay.Location = new System.Drawing.Point(549, 168);
            this.txtBoxRatePerDay.Name = "txtBoxRatePerDay";
            this.txtBoxRatePerDay.Size = new System.Drawing.Size(232, 32);
            this.txtBoxRatePerDay.TabIndex = 40;
            // 
            // txtBoxTotalDays
            // 
            this.txtBoxTotalDays.Enabled = false;
            this.txtBoxTotalDays.Location = new System.Drawing.Point(549, 82);
            this.txtBoxTotalDays.Name = "txtBoxTotalDays";
            this.txtBoxTotalDays.Size = new System.Drawing.Size(232, 32);
            this.txtBoxTotalDays.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(545, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 23);
            this.label4.TabIndex = 38;
            this.label4.Text = "Rate Per Day:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(545, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 23);
            this.label3.TabIndex = 37;
            this.label3.Text = "Total Days:";
            // 
            // txtBoxRoomNo
            // 
            this.txtBoxRoomNo.Enabled = false;
            this.txtBoxRoomNo.Location = new System.Drawing.Point(290, 82);
            this.txtBoxRoomNo.Name = "txtBoxRoomNo";
            this.txtBoxRoomNo.Size = new System.Drawing.Size(232, 32);
            this.txtBoxRoomNo.TabIndex = 34;
            // 
            // txtBoxRoomType
            // 
            this.txtBoxRoomType.Enabled = false;
            this.txtBoxRoomType.Location = new System.Drawing.Point(24, 82);
            this.txtBoxRoomType.Name = "txtBoxRoomType";
            this.txtBoxRoomType.Size = new System.Drawing.Size(232, 32);
            this.txtBoxRoomType.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(20, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 23);
            this.label1.TabIndex = 32;
            this.label1.Text = "Client Bills:";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(286, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 23);
            this.label2.TabIndex = 31;
            this.label2.Text = "Check Out Date:";
            // 
            // lblIN
            // 
            this.lblIN.AutoSize = true;
            this.lblIN.Location = new System.Drawing.Point(20, 132);
            this.lblIN.Name = "lblIN";
            this.lblIN.Size = new System.Drawing.Size(157, 23);
            this.lblIN.TabIndex = 30;
            this.lblIN.Text = "Check In Date:";
            // 
            // lblRoomNo
            // 
            this.lblRoomNo.AutoSize = true;
            this.lblRoomNo.Location = new System.Drawing.Point(286, 56);
            this.lblRoomNo.Name = "lblRoomNo";
            this.lblRoomNo.Size = new System.Drawing.Size(111, 23);
            this.lblRoomNo.TabIndex = 29;
            this.lblRoomNo.Text = "Room No.:";
            // 
            // lblRoomType
            // 
            this.lblRoomType.AutoSize = true;
            this.lblRoomType.Location = new System.Drawing.Point(20, 56);
            this.lblRoomType.Name = "lblRoomType";
            this.lblRoomType.Size = new System.Drawing.Size(124, 23);
            this.lblRoomType.TabIndex = 28;
            this.lblRoomType.Text = "Room Type:";
            // 
            // tabPagePayment
            // 
            this.tabPagePayment.Controls.Add(this.lblStatusPayment);
            this.tabPagePayment.Controls.Add(this.lblPaymentStatus);
            this.tabPagePayment.Controls.Add(this.txtBoxTotalAmount1);
            this.tabPagePayment.Controls.Add(this.label11);
            this.tabPagePayment.Controls.Add(this.btnCancel);
            this.tabPagePayment.Controls.Add(this.btnPay);
            this.tabPagePayment.Controls.Add(this.dateTimePickerPaymentDate);
            this.tabPagePayment.Controls.Add(this.txtBoxChange);
            this.tabPagePayment.Controls.Add(this.txtBoxAmountPaid);
            this.tabPagePayment.Controls.Add(this.comboBoxPaymentMethod);
            this.tabPagePayment.Controls.Add(this.label7);
            this.tabPagePayment.Controls.Add(this.label8);
            this.tabPagePayment.Controls.Add(this.label9);
            this.tabPagePayment.Controls.Add(this.label10);
            this.tabPagePayment.Controls.Add(this.label6);
            this.tabPagePayment.Location = new System.Drawing.Point(4, 4);
            this.tabPagePayment.Name = "tabPagePayment";
            this.tabPagePayment.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePayment.Size = new System.Drawing.Size(996, 331);
            this.tabPagePayment.TabIndex = 2;
            this.tabPagePayment.Text = "Payment";
            this.tabPagePayment.UseVisualStyleBackColor = true;
            this.tabPagePayment.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // lblStatusPayment
            // 
            this.lblStatusPayment.AutoSize = true;
            this.lblStatusPayment.Location = new System.Drawing.Point(403, 196);
            this.lblStatusPayment.Name = "lblStatusPayment";
            this.lblStatusPayment.Size = new System.Drawing.Size(167, 23);
            this.lblStatusPayment.TabIndex = 47;
            this.lblStatusPayment.Text = "Payment Status:";
            // 
            // lblPaymentStatus
            // 
            this.lblPaymentStatus.AutoSize = true;
            this.lblPaymentStatus.Location = new System.Drawing.Point(403, 235);
            this.lblPaymentStatus.Name = "lblPaymentStatus";
            this.lblPaymentStatus.Size = new System.Drawing.Size(162, 23);
            this.lblPaymentStatus.TabIndex = 46;
            this.lblPaymentStatus.Text = "Payment Status";
            // 
            // txtBoxTotalAmount1
            // 
            this.txtBoxTotalAmount1.Location = new System.Drawing.Point(18, 150);
            this.txtBoxTotalAmount1.Name = "txtBoxTotalAmount1";
            this.txtBoxTotalAmount1.ReadOnly = true;
            this.txtBoxTotalAmount1.Size = new System.Drawing.Size(307, 32);
            this.txtBoxTotalAmount1.TabIndex = 45;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 118);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(146, 23);
            this.label11.TabIndex = 44;
            this.label11.Text = "Total Amount:";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Brown;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(629, 273);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(144, 52);
            this.btnCancel.TabIndex = 43;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnPay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.ForeColor = System.Drawing.Color.White;
            this.btnPay.Location = new System.Drawing.Point(18, 273);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(144, 52);
            this.btnPay.TabIndex = 42;
            this.btnPay.Text = "Pay";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // dateTimePickerPaymentDate
            // 
            this.dateTimePickerPaymentDate.Enabled = false;
            this.dateTimePickerPaymentDate.Location = new System.Drawing.Point(407, 150);
            this.dateTimePickerPaymentDate.Name = "dateTimePickerPaymentDate";
            this.dateTimePickerPaymentDate.Size = new System.Drawing.Size(366, 32);
            this.dateTimePickerPaymentDate.TabIndex = 41;
            this.dateTimePickerPaymentDate.ValueChanged += new System.EventHandler(this.dateTimePickerPaymentDate_ValueChanged);
            // 
            // txtBoxChange
            // 
            this.txtBoxChange.Location = new System.Drawing.Point(18, 226);
            this.txtBoxChange.Name = "txtBoxChange";
            this.txtBoxChange.ReadOnly = true;
            this.txtBoxChange.Size = new System.Drawing.Size(307, 32);
            this.txtBoxChange.TabIndex = 40;
            // 
            // txtBoxAmountPaid
            // 
            this.txtBoxAmountPaid.Location = new System.Drawing.Point(407, 72);
            this.txtBoxAmountPaid.Name = "txtBoxAmountPaid";
            this.txtBoxAmountPaid.Size = new System.Drawing.Size(366, 32);
            this.txtBoxAmountPaid.TabIndex = 39;
            this.txtBoxAmountPaid.TextChanged += new System.EventHandler(this.txtBoxAmountPaid_TextChanged);
            // 
            // comboBoxPaymentMethod
            // 
            this.comboBoxPaymentMethod.FormattingEnabled = true;
            this.comboBoxPaymentMethod.Items.AddRange(new object[] {
            "",
            "Cash",
            "Card",
            "Gcash"});
            this.comboBoxPaymentMethod.Location = new System.Drawing.Point(18, 73);
            this.comboBoxPaymentMethod.Name = "comboBoxPaymentMethod";
            this.comboBoxPaymentMethod.Size = new System.Drawing.Size(307, 31);
            this.comboBoxPaymentMethod.TabIndex = 38;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(403, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 23);
            this.label7.TabIndex = 37;
            this.label7.Text = "Paymet Date:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 196);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 23);
            this.label8.TabIndex = 36;
            this.label8.Text = "Change:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(403, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(142, 23);
            this.label9.TabIndex = 35;
            this.label9.Text = "Amount Paid:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 36);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(185, 23);
            this.label10.TabIndex = 34;
            this.label10.Text = "Payment Method:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Brown;
            this.label6.Location = new System.Drawing.Point(14, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(165, 23);
            this.label6.TabIndex = 33;
            this.label6.Text = "Client Payment:";
            // 
            // colCheckInOutID
            // 
            this.colCheckInOutID.DataPropertyName = "CheckInOut_ID";
            this.colCheckInOutID.HeaderText = "ID";
            this.colCheckInOutID.MinimumWidth = 8;
            this.colCheckInOutID.Name = "colCheckInOutID";
            this.colCheckInOutID.ReadOnly = true;
            this.colCheckInOutID.Visible = false;
            // 
            // colReservationID
            // 
            this.colReservationID.DataPropertyName = "Reservation_ID";
            this.colReservationID.HeaderText = "ID";
            this.colReservationID.MinimumWidth = 8;
            this.colReservationID.Name = "colReservationID";
            this.colReservationID.ReadOnly = true;
            // 
            // colClientName
            // 
            this.colClientName.DataPropertyName = "ClientName";
            this.colClientName.HeaderText = "Client Name";
            this.colClientName.MinimumWidth = 8;
            this.colClientName.Name = "colClientName";
            this.colClientName.ReadOnly = true;
            // 
            // colRoomNo
            // 
            this.colRoomNo.DataPropertyName = "Room_Number";
            this.colRoomNo.HeaderText = "Room No";
            this.colRoomNo.MinimumWidth = 8;
            this.colRoomNo.Name = "colRoomNo";
            this.colRoomNo.ReadOnly = true;
            // 
            // colRoomType
            // 
            this.colRoomType.DataPropertyName = "Room_Type";
            this.colRoomType.HeaderText = "Room Type";
            this.colRoomType.MinimumWidth = 8;
            this.colRoomType.Name = "colRoomType";
            this.colRoomType.ReadOnly = true;
            // 
            // colCheckIn
            // 
            this.colCheckIn.DataPropertyName = "CheckInDate";
            this.colCheckIn.HeaderText = "Check In";
            this.colCheckIn.MinimumWidth = 8;
            this.colCheckIn.Name = "colCheckIn";
            this.colCheckIn.ReadOnly = true;
            // 
            // colCheckOut
            // 
            this.colCheckOut.DataPropertyName = "ActualCheckOutDate";
            this.colCheckOut.HeaderText = "Check Out";
            this.colCheckOut.MinimumWidth = 8;
            this.colCheckOut.Name = "colCheckOut";
            this.colCheckOut.ReadOnly = true;
            // 
            // colRate
            // 
            this.colRate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colRate.DataPropertyName = "TotalDays";
            this.colRate.HeaderText = "Total Days";
            this.colRate.MinimumWidth = 8;
            this.colRate.Name = "colRate";
            this.colRate.ReadOnly = true;
            this.colRate.Width = 150;
            // 
            // colTotal
            // 
            this.colTotal.DataPropertyName = "RoomRate";
            this.colTotal.HeaderText = "Room  Rate";
            this.colTotal.MinimumWidth = 8;
            this.colTotal.Name = "colTotal";
            this.colTotal.ReadOnly = true;
            // 
            // colTotals
            // 
            this.colTotals.DataPropertyName = "TotalAmount";
            this.colTotals.HeaderText = "Total Amount";
            this.colTotals.MinimumWidth = 8;
            this.colTotals.Name = "colTotals";
            this.colTotals.ReadOnly = true;
            // 
            // colPaymentStatus
            // 
            this.colPaymentStatus.DataPropertyName = "PaymentStatus";
            this.colPaymentStatus.HeaderText = "Payment Statust";
            this.colPaymentStatus.MinimumWidth = 8;
            this.colPaymentStatus.Name = "colPaymentStatus";
            this.colPaymentStatus.ReadOnly = true;
            // 
            // UserControlPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControlBillsAndPayment);
            this.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "UserControlPayment";
            this.Size = new System.Drawing.Size(1469, 531);
            this.tabControlBillsAndPayment.ResumeLayout(false);
            this.tabPageSelectBilling.ResumeLayout(false);
            this.tabPageSelectBilling.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBilling)).EndInit();
            this.tabPageBilling.ResumeLayout(false);
            this.tabPageBilling.PerformLayout();
            this.tabPagePayment.ResumeLayout(false);
            this.tabPagePayment.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlBillsAndPayment;
        private System.Windows.Forms.TabPage tabPageSelectBilling;
        private System.Windows.Forms.TabPage tabPageBilling;
        private System.Windows.Forms.DataGridView dataGridViewBilling;
        private System.Windows.Forms.TextBox txtBoxSearchReservationID;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label labelAddReservation;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.TabPage tabPagePayment;
        private System.Windows.Forms.TextBox txtBoxRoomNo;
        private System.Windows.Forms.TextBox txtBoxRoomType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblIN;
        private System.Windows.Forms.Label lblRoomNo;
        private System.Windows.Forms.Label lblRoomType;
        private System.Windows.Forms.TextBox txtBoxTotalAmount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBoxRatePerDay;
        private System.Windows.Forms.TextBox txtBoxTotalDays;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddReservation;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxPaymentMethod;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBoxAmountPaid;
        private System.Windows.Forms.DateTimePicker dateTimePickerCheckInDate;
        private System.Windows.Forms.TextBox txtBoxChange;
        private System.Windows.Forms.DateTimePicker dateTimePickerCheckOutDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerPaymentDate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Label lblPaymentStatus;
        private System.Windows.Forms.TextBox txtBoxTotalAmount1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblStatusPayment;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCheckInOutID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReservationID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRoomNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRoomType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCheckIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCheckOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotals;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPaymentStatus;
    }
}
