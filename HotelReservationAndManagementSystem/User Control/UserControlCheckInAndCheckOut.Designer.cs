namespace HotelReservationAndManagementSystem.User_Control
{
    partial class UserControlCheckInAndCheckOut
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
            this.tabControlCheckInCheckOut = new System.Windows.Forms.TabControl();
            this.tabPageCheckIn = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerOut = new System.Windows.Forms.DateTimePicker();
            this.lblIN = new System.Windows.Forms.Label();
            this.dateTimePickerIn = new System.Windows.Forms.DateTimePicker();
            this.comboBoxRoomNo = new System.Windows.Forms.ComboBox();
            this.comboBoxRoomType = new System.Windows.Forms.ComboBox();
            this.txtBoxClientID = new System.Windows.Forms.TextBox();
            this.lblClientID = new System.Windows.Forms.Label();
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.lblRoomNo = new System.Windows.Forms.Label();
            this.lblRoomType = new System.Windows.Forms.Label();
            this.lblCheckIn = new System.Windows.Forms.Label();
            this.tabPageCheckInList = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelCheckIn = new System.Windows.Forms.Button();
            this.btnUpdateCheckIn = new System.Windows.Forms.Button();
            this.dataGridViewCheckInList = new System.Windows.Forms.DataGridView();
            this.tabPageCheckOut = new System.Windows.Forms.TabPage();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.lblRoomRates = new System.Windows.Forms.Label();
            this.lblTotalDaysStayed = new System.Windows.Forms.Label();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCheckInOutDate = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CheckInOut_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckInDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckOutDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reservation_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControlCheckInCheckOut.SuspendLayout();
            this.tabPageCheckIn.SuspendLayout();
            this.tabPageCheckInList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCheckInList)).BeginInit();
            this.tabPageCheckOut.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlCheckInCheckOut
            // 
            this.tabControlCheckInCheckOut.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControlCheckInCheckOut.Controls.Add(this.tabPageCheckIn);
            this.tabControlCheckInCheckOut.Controls.Add(this.tabPageCheckInList);
            this.tabControlCheckInCheckOut.Controls.Add(this.tabPageCheckOut);
            this.tabControlCheckInCheckOut.Location = new System.Drawing.Point(30, 28);
            this.tabControlCheckInCheckOut.Name = "tabControlCheckInCheckOut";
            this.tabControlCheckInCheckOut.SelectedIndex = 0;
            this.tabControlCheckInCheckOut.Size = new System.Drawing.Size(1023, 381);
            this.tabControlCheckInCheckOut.TabIndex = 0;
            // 
            // tabPageCheckIn
            // 
            this.tabPageCheckIn.Controls.Add(this.label2);
            this.tabPageCheckIn.Controls.Add(this.dateTimePickerOut);
            this.tabPageCheckIn.Controls.Add(this.lblIN);
            this.tabPageCheckIn.Controls.Add(this.dateTimePickerIn);
            this.tabPageCheckIn.Controls.Add(this.comboBoxRoomNo);
            this.tabPageCheckIn.Controls.Add(this.comboBoxRoomType);
            this.tabPageCheckIn.Controls.Add(this.txtBoxClientID);
            this.tabPageCheckIn.Controls.Add(this.lblClientID);
            this.tabPageCheckIn.Controls.Add(this.btnCheckIn);
            this.tabPageCheckIn.Controls.Add(this.lblRoomNo);
            this.tabPageCheckIn.Controls.Add(this.lblRoomType);
            this.tabPageCheckIn.Controls.Add(this.lblCheckIn);
            this.tabPageCheckIn.Location = new System.Drawing.Point(4, 4);
            this.tabPageCheckIn.Name = "tabPageCheckIn";
            this.tabPageCheckIn.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCheckIn.Size = new System.Drawing.Size(1015, 345);
            this.tabPageCheckIn.TabIndex = 0;
            this.tabPageCheckIn.Text = "Check in";
            this.tabPageCheckIn.UseVisualStyleBackColor = true;
            this.tabPageCheckIn.Click += new System.EventHandler(this.tabPageCheckIn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(533, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 23);
            this.label2.TabIndex = 38;
            this.label2.Text = "OUT:";
            // 
            // dateTimePickerOut
            // 
            this.dateTimePickerOut.Location = new System.Drawing.Point(537, 239);
            this.dateTimePickerOut.Name = "dateTimePickerOut";
            this.dateTimePickerOut.Size = new System.Drawing.Size(254, 32);
            this.dateTimePickerOut.TabIndex = 37;
            // 
            // lblIN
            // 
            this.lblIN.AutoSize = true;
            this.lblIN.Location = new System.Drawing.Point(102, 202);
            this.lblIN.Name = "lblIN";
            this.lblIN.Size = new System.Drawing.Size(35, 23);
            this.lblIN.TabIndex = 36;
            this.lblIN.Text = "IN:";
            // 
            // dateTimePickerIn
            // 
            this.dateTimePickerIn.Location = new System.Drawing.Point(106, 239);
            this.dateTimePickerIn.Name = "dateTimePickerIn";
            this.dateTimePickerIn.Size = new System.Drawing.Size(254, 32);
            this.dateTimePickerIn.TabIndex = 35;
            // 
            // comboBoxRoomNo
            // 
            this.comboBoxRoomNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxRoomNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRoomNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxRoomNo.FormattingEnabled = true;
            this.comboBoxRoomNo.Items.AddRange(new object[] {
            "Please select ..."});
            this.comboBoxRoomNo.Location = new System.Drawing.Point(537, 88);
            this.comboBoxRoomNo.Name = "comboBoxRoomNo";
            this.comboBoxRoomNo.Size = new System.Drawing.Size(254, 31);
            this.comboBoxRoomNo.TabIndex = 34;
            // 
            // comboBoxRoomType
            // 
            this.comboBoxRoomType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxRoomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRoomType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxRoomType.FormattingEnabled = true;
            this.comboBoxRoomType.Items.AddRange(new object[] {
            "Please select ...",
            "Single",
            "Double",
            "Family",
            "Suite"});
            this.comboBoxRoomType.Location = new System.Drawing.Point(106, 88);
            this.comboBoxRoomType.Name = "comboBoxRoomType";
            this.comboBoxRoomType.Size = new System.Drawing.Size(254, 31);
            this.comboBoxRoomType.TabIndex = 33;
            this.comboBoxRoomType.SelectedIndexChanged += new System.EventHandler(this.comboBoxRoomType_SelectedIndexChanged);
            // 
            // txtBoxClientID
            // 
            this.txtBoxClientID.Location = new System.Drawing.Point(106, 155);
            this.txtBoxClientID.Name = "txtBoxClientID";
            this.txtBoxClientID.Size = new System.Drawing.Size(254, 32);
            this.txtBoxClientID.TabIndex = 32;
            // 
            // lblClientID
            // 
            this.lblClientID.AutoSize = true;
            this.lblClientID.Location = new System.Drawing.Point(102, 122);
            this.lblClientID.Name = "lblClientID";
            this.lblClientID.Size = new System.Drawing.Size(97, 23);
            this.lblClientID.TabIndex = 31;
            this.lblClientID.Text = "Client ID:";
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.BackColor = System.Drawing.Color.Brown;
            this.btnCheckIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheckIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckIn.ForeColor = System.Drawing.Color.White;
            this.btnCheckIn.Location = new System.Drawing.Point(106, 284);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(144, 52);
            this.btnCheckIn.TabIndex = 30;
            this.btnCheckIn.Text = "Check In";
            this.btnCheckIn.UseVisualStyleBackColor = false;
            this.btnCheckIn.Click += new System.EventHandler(this.btnCheckIn_Click);
            // 
            // lblRoomNo
            // 
            this.lblRoomNo.AutoSize = true;
            this.lblRoomNo.Location = new System.Drawing.Point(533, 53);
            this.lblRoomNo.Name = "lblRoomNo";
            this.lblRoomNo.Size = new System.Drawing.Size(111, 23);
            this.lblRoomNo.TabIndex = 29;
            this.lblRoomNo.Text = "Room No.:";
            // 
            // lblRoomType
            // 
            this.lblRoomType.AutoSize = true;
            this.lblRoomType.Location = new System.Drawing.Point(102, 53);
            this.lblRoomType.Name = "lblRoomType";
            this.lblRoomType.Size = new System.Drawing.Size(124, 23);
            this.lblRoomType.TabIndex = 28;
            this.lblRoomType.Text = "Room Type:";
            // 
            // lblCheckIn
            // 
            this.lblCheckIn.AutoSize = true;
            this.lblCheckIn.ForeColor = System.Drawing.Color.Brown;
            this.lblCheckIn.Location = new System.Drawing.Point(17, 18);
            this.lblCheckIn.Name = "lblCheckIn";
            this.lblCheckIn.Size = new System.Drawing.Size(102, 23);
            this.lblCheckIn.TabIndex = 0;
            this.lblCheckIn.Text = "Check In:";
            // 
            // tabPageCheckInList
            // 
            this.tabPageCheckInList.Controls.Add(this.label1);
            this.tabPageCheckInList.Controls.Add(this.btnCancelCheckIn);
            this.tabPageCheckInList.Controls.Add(this.btnUpdateCheckIn);
            this.tabPageCheckInList.Controls.Add(this.dataGridViewCheckInList);
            this.tabPageCheckInList.Location = new System.Drawing.Point(4, 4);
            this.tabPageCheckInList.Name = "tabPageCheckInList";
            this.tabPageCheckInList.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCheckInList.Size = new System.Drawing.Size(1015, 345);
            this.tabPageCheckInList.TabIndex = 1;
            this.tabPageCheckInList.Text = "Check in List";
            this.tabPageCheckInList.UseVisualStyleBackColor = true;
            this.tabPageCheckInList.Click += new System.EventHandler(this.tabPageCheckInList_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(33, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 23);
            this.label1.TabIndex = 43;
            this.label1.Text = "Check In List:";
            // 
            // btnCancelCheckIn
            // 
            this.btnCancelCheckIn.BackColor = System.Drawing.Color.Brown;
            this.btnCancelCheckIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelCheckIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelCheckIn.ForeColor = System.Drawing.Color.White;
            this.btnCancelCheckIn.Location = new System.Drawing.Point(320, 280);
            this.btnCancelCheckIn.Name = "btnCancelCheckIn";
            this.btnCancelCheckIn.Size = new System.Drawing.Size(155, 52);
            this.btnCancelCheckIn.TabIndex = 42;
            this.btnCancelCheckIn.Text = "Cancel Check In";
            this.btnCancelCheckIn.UseVisualStyleBackColor = false;
            // 
            // btnUpdateCheckIn
            // 
            this.btnUpdateCheckIn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnUpdateCheckIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateCheckIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateCheckIn.ForeColor = System.Drawing.Color.White;
            this.btnUpdateCheckIn.Location = new System.Drawing.Point(33, 280);
            this.btnUpdateCheckIn.Name = "btnUpdateCheckIn";
            this.btnUpdateCheckIn.Size = new System.Drawing.Size(155, 52);
            this.btnUpdateCheckIn.TabIndex = 41;
            this.btnUpdateCheckIn.Text = "Update Check In";
            this.btnUpdateCheckIn.UseVisualStyleBackColor = false;
            // 
            // dataGridViewCheckInList
            // 
            this.dataGridViewCheckInList.AllowUserToAddRows = false;
            this.dataGridViewCheckInList.AllowUserToDeleteRows = false;
            this.dataGridViewCheckInList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewCheckInList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCheckInList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCheckInList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CheckInOut_ID,
            this.ClientName,
            this.RoomNumber,
            this.RoomType,
            this.CheckInDate,
            this.CheckOutDate,
            this.Status,
            this.Reservation_ID});
            this.dataGridViewCheckInList.Location = new System.Drawing.Point(33, 54);
            this.dataGridViewCheckInList.Name = "dataGridViewCheckInList";
            this.dataGridViewCheckInList.ReadOnly = true;
            this.dataGridViewCheckInList.RowHeadersWidth = 62;
            this.dataGridViewCheckInList.RowTemplate.Height = 28;
            this.dataGridViewCheckInList.Size = new System.Drawing.Size(869, 211);
            this.dataGridViewCheckInList.TabIndex = 14;
            this.dataGridViewCheckInList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCheckInList_CellClick);
            this.dataGridViewCheckInList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewReservation_CellContentClick);
            this.dataGridViewCheckInList.Enter += new System.EventHandler(this.dataGridViewCheckInList_Enter);
            // 
            // tabPageCheckOut
            // 
            this.tabPageCheckOut.Controls.Add(this.label7);
            this.tabPageCheckOut.Controls.Add(this.lblCheckInOutDate);
            this.tabPageCheckOut.Controls.Add(this.lblTotalAmount);
            this.tabPageCheckOut.Controls.Add(this.lblRoomRates);
            this.tabPageCheckOut.Controls.Add(this.lblTotalDaysStayed);
            this.tabPageCheckOut.Controls.Add(this.btnCheckOut);
            this.tabPageCheckOut.Controls.Add(this.label6);
            this.tabPageCheckOut.Controls.Add(this.label5);
            this.tabPageCheckOut.Controls.Add(this.label4);
            this.tabPageCheckOut.Controls.Add(this.label3);
            this.tabPageCheckOut.Location = new System.Drawing.Point(4, 4);
            this.tabPageCheckOut.Name = "tabPageCheckOut";
            this.tabPageCheckOut.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCheckOut.Size = new System.Drawing.Size(1015, 345);
            this.tabPageCheckOut.TabIndex = 2;
            this.tabPageCheckOut.Text = "Check Out";
            this.tabPageCheckOut.UseVisualStyleBackColor = true;
            this.tabPageCheckOut.Click += new System.EventHandler(this.tabPageCheckOut_Click);
            this.tabPageCheckOut.Enter += new System.EventHandler(this.tabPageCheckOut_Enter);
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Location = new System.Drawing.Point(470, 278);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(22, 23);
            this.lblTotalAmount.TabIndex = 46;
            this.lblTotalAmount.Text = "?";
            this.lblTotalAmount.Click += new System.EventHandler(this.lblTotalAmount_Click);
            // 
            // lblRoomRates
            // 
            this.lblRoomRates.AutoSize = true;
            this.lblRoomRates.Location = new System.Drawing.Point(470, 208);
            this.lblRoomRates.Name = "lblRoomRates";
            this.lblRoomRates.Size = new System.Drawing.Size(22, 23);
            this.lblRoomRates.TabIndex = 45;
            this.lblRoomRates.Text = "?";
            this.lblRoomRates.Click += new System.EventHandler(this.lblRoomRates_Click);
            // 
            // lblTotalDaysStayed
            // 
            this.lblTotalDaysStayed.AutoSize = true;
            this.lblTotalDaysStayed.Location = new System.Drawing.Point(470, 134);
            this.lblTotalDaysStayed.Name = "lblTotalDaysStayed";
            this.lblTotalDaysStayed.Size = new System.Drawing.Size(22, 23);
            this.lblTotalDaysStayed.TabIndex = 44;
            this.lblTotalDaysStayed.Text = "?";
            this.lblTotalDaysStayed.Click += new System.EventHandler(this.lblTotalDaysStayed_Click);
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.BackColor = System.Drawing.Color.Brown;
            this.btnCheckOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckOut.ForeColor = System.Drawing.Color.White;
            this.btnCheckOut.Location = new System.Drawing.Point(827, 287);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(155, 52);
            this.btnCheckOut.TabIndex = 43;
            this.btnCheckOut.Text = "Check Out";
            this.btnCheckOut.UseVisualStyleBackColor = false;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(141, 278);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 23);
            this.label6.TabIndex = 41;
            this.label6.Text = "Total Amount:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(141, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 23);
            this.label5.TabIndex = 40;
            this.label5.Text = "Room Rates:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(141, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 23);
            this.label4.TabIndex = 39;
            this.label4.Text = "Total Days Stayed:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(141, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(248, 23);
            this.label3.TabIndex = 38;
            this.label3.Text = "Actual Check Out Date:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblCheckInOutDate
            // 
            this.lblCheckInOutDate.AutoSize = true;
            this.lblCheckInOutDate.Location = new System.Drawing.Point(470, 68);
            this.lblCheckInOutDate.Name = "lblCheckInOutDate";
            this.lblCheckInOutDate.Size = new System.Drawing.Size(22, 23);
            this.lblCheckInOutDate.TabIndex = 47;
            this.lblCheckInOutDate.Text = "?";
            this.lblCheckInOutDate.Click += new System.EventHandler(this.lblCheckInOutDate_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Brown;
            this.label7.Location = new System.Drawing.Point(34, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 23);
            this.label7.TabIndex = 48;
            this.label7.Text = "Check Out:";
            // 
            // CheckInOut_ID
            // 
            this.CheckInOut_ID.HeaderText = "Check In ID";
            this.CheckInOut_ID.MinimumWidth = 8;
            this.CheckInOut_ID.Name = "CheckInOut_ID";
            this.CheckInOut_ID.ReadOnly = true;
            this.CheckInOut_ID.Visible = false;
            // 
            // ClientName
            // 
            this.ClientName.HeaderText = "Guest Name";
            this.ClientName.MinimumWidth = 8;
            this.ClientName.Name = "ClientName";
            this.ClientName.ReadOnly = true;
            // 
            // RoomNumber
            // 
            this.RoomNumber.HeaderText = "Room No.";
            this.RoomNumber.MinimumWidth = 8;
            this.RoomNumber.Name = "RoomNumber";
            this.RoomNumber.ReadOnly = true;
            // 
            // RoomType
            // 
            this.RoomType.HeaderText = "Room Type";
            this.RoomType.MinimumWidth = 8;
            this.RoomType.Name = "RoomType";
            this.RoomType.ReadOnly = true;
            // 
            // CheckInDate
            // 
            this.CheckInDate.HeaderText = "Check In Date";
            this.CheckInDate.MinimumWidth = 8;
            this.CheckInDate.Name = "CheckInDate";
            this.CheckInDate.ReadOnly = true;
            // 
            // CheckOutDate
            // 
            this.CheckOutDate.HeaderText = "Expected Check Out";
            this.CheckOutDate.MinimumWidth = 8;
            this.CheckOutDate.Name = "CheckOutDate";
            this.CheckOutDate.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 8;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // Reservation_ID
            // 
            this.Reservation_ID.HeaderText = "Reservation ID";
            this.Reservation_ID.MinimumWidth = 8;
            this.Reservation_ID.Name = "Reservation_ID";
            this.Reservation_ID.ReadOnly = true;
            this.Reservation_ID.Visible = false;
            // 
            // UserControlCheckInAndCheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tabControlCheckInCheckOut);
            this.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "UserControlCheckInAndCheckOut";
            this.Size = new System.Drawing.Size(1102, 462);
            this.Load += new System.EventHandler(this.UserControlCheckInAndCheckOut_Load);
            this.tabControlCheckInCheckOut.ResumeLayout(false);
            this.tabPageCheckIn.ResumeLayout(false);
            this.tabPageCheckIn.PerformLayout();
            this.tabPageCheckInList.ResumeLayout(false);
            this.tabPageCheckInList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCheckInList)).EndInit();
            this.tabPageCheckOut.ResumeLayout(false);
            this.tabPageCheckOut.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlCheckInCheckOut;
        private System.Windows.Forms.TabPage tabPageCheckIn;
        private System.Windows.Forms.TabPage tabPageCheckInList;
        private System.Windows.Forms.Label lblCheckIn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerOut;
        private System.Windows.Forms.Label lblIN;
        private System.Windows.Forms.DateTimePicker dateTimePickerIn;
        private System.Windows.Forms.ComboBox comboBoxRoomNo;
        private System.Windows.Forms.ComboBox comboBoxRoomType;
        private System.Windows.Forms.TextBox txtBoxClientID;
        private System.Windows.Forms.Label lblClientID;
        private System.Windows.Forms.Button btnCheckIn;
        private System.Windows.Forms.Label lblRoomNo;
        private System.Windows.Forms.Label lblRoomType;
        private System.Windows.Forms.DataGridView dataGridViewCheckInList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelCheckIn;
        private System.Windows.Forms.Button btnUpdateCheckIn;
        private System.Windows.Forms.TabPage tabPageCheckOut;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label lblRoomRates;
        private System.Windows.Forms.Label lblTotalDaysStayed;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCheckInOutDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn CheckInOut_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomType;
        private System.Windows.Forms.DataGridViewTextBoxColumn CheckInDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn CheckOutDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reservation_ID;
    }
}
