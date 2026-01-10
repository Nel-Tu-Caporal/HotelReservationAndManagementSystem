namespace HotelReservationAndManagementSystem.User_Control
{
    partial class UserControlCheckOut
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
            this.tabPageCheckInList = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelCheckIn = new System.Windows.Forms.Button();
            this.dataGridViewCheckInList = new System.Windows.Forms.DataGridView();
            this.CheckInOut_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reservation_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Room_Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Room_Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckInDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpectedCheckOutDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPageCheckOut = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.lblCheckInOutDate = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.lblRoomRates = new System.Windows.Forms.Label();
            this.lblTotalDaysStayed = new System.Windows.Forms.Label();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControlCheckInCheckOut.SuspendLayout();
            this.tabPageCheckInList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCheckInList)).BeginInit();
            this.tabPageCheckOut.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlCheckInCheckOut
            // 
            this.tabControlCheckInCheckOut.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControlCheckInCheckOut.Controls.Add(this.tabPageCheckInList);
            this.tabControlCheckInCheckOut.Controls.Add(this.tabPageCheckOut);
            this.tabControlCheckInCheckOut.Location = new System.Drawing.Point(30, 28);
            this.tabControlCheckInCheckOut.Name = "tabControlCheckInCheckOut";
            this.tabControlCheckInCheckOut.SelectedIndex = 0;
            this.tabControlCheckInCheckOut.Size = new System.Drawing.Size(1023, 381);
            this.tabControlCheckInCheckOut.TabIndex = 0;
          //this.tabControlCheckInCheckOut.Enter += new System.EventHandler(this.tabControlCheckInCheckOut_Enter);
            // 
            // tabPageCheckInList
            // 
            this.tabPageCheckInList.Controls.Add(this.label1);
            this.tabPageCheckInList.Controls.Add(this.btnCancelCheckIn);
            this.tabPageCheckInList.Controls.Add(this.dataGridViewCheckInList);
            this.tabPageCheckInList.Location = new System.Drawing.Point(4, 4);
            this.tabPageCheckInList.Name = "tabPageCheckInList";
            this.tabPageCheckInList.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCheckInList.Size = new System.Drawing.Size(1015, 345);
            this.tabPageCheckInList.TabIndex = 1;
            this.tabPageCheckInList.Text = "Check in List";
            this.tabPageCheckInList.UseVisualStyleBackColor = true;
            this.tabPageCheckInList.Click += new System.EventHandler(this.tabPageCheckInList_Click);
            this.tabPageCheckInList.Enter += new System.EventHandler(this.tabPageCheckInList_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(6, 19);
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
            this.btnCancelCheckIn.Location = new System.Drawing.Point(584, 278);
            this.btnCancelCheckIn.Name = "btnCancelCheckIn";
            this.btnCancelCheckIn.Size = new System.Drawing.Size(155, 52);
            this.btnCancelCheckIn.TabIndex = 42;
            this.btnCancelCheckIn.Text = "Cancel Check In";
            this.btnCancelCheckIn.UseVisualStyleBackColor = false;
            this.btnCancelCheckIn.Click += new System.EventHandler(this.btnCancelCheckIn_Click);
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
            this.Reservation_ID,
            this.ClientName,
            this.Room_Number,
            this.Room_Type,
            this.CheckInDate,
            this.ExpectedCheckOutDate,
            this.RoomRate,
            this.Status});
            this.dataGridViewCheckInList.Location = new System.Drawing.Point(3, 61);
            this.dataGridViewCheckInList.Name = "dataGridViewCheckInList";
            this.dataGridViewCheckInList.ReadOnly = true;
            this.dataGridViewCheckInList.RowHeadersWidth = 62;
            this.dataGridViewCheckInList.RowTemplate.Height = 28;
            this.dataGridViewCheckInList.Size = new System.Drawing.Size(925, 211);
            this.dataGridViewCheckInList.TabIndex = 14;
            this.dataGridViewCheckInList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCheckInList_CellClick);
            this.dataGridViewCheckInList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewReservation_CellContentClick);
            this.dataGridViewCheckInList.Enter += new System.EventHandler(this.dataGridViewCheckInList_Enter);
            // 
            // CheckInOut_ID
            // 
            this.CheckInOut_ID.DataPropertyName = "CheckInOut_ID";
            this.CheckInOut_ID.HeaderText = "CheckInOut ID";
            this.CheckInOut_ID.MinimumWidth = 8;
            this.CheckInOut_ID.Name = "CheckInOut_ID";
            this.CheckInOut_ID.ReadOnly = true;
            this.CheckInOut_ID.Visible = false;
            // 
            // Reservation_ID
            // 
            this.Reservation_ID.DataPropertyName = "Reservation_ID";
            this.Reservation_ID.HeaderText = "Reservation ID";
            this.Reservation_ID.MinimumWidth = 8;
            this.Reservation_ID.Name = "Reservation_ID";
            this.Reservation_ID.ReadOnly = true;
            this.Reservation_ID.Visible = false;
            // 
            // ClientName
            // 
            this.ClientName.DataPropertyName = "ClientName";
            this.ClientName.HeaderText = "Client Name";
            this.ClientName.MinimumWidth = 8;
            this.ClientName.Name = "ClientName";
            this.ClientName.ReadOnly = true;
            // 
            // Room_Number
            // 
            this.Room_Number.DataPropertyName = "Room_Number";
            this.Room_Number.HeaderText = "Room No.";
            this.Room_Number.MinimumWidth = 8;
            this.Room_Number.Name = "Room_Number";
            this.Room_Number.ReadOnly = true;
            // 
            // Room_Type
            // 
            this.Room_Type.DataPropertyName = "Room_Type";
            this.Room_Type.HeaderText = "Room Type";
            this.Room_Type.MinimumWidth = 8;
            this.Room_Type.Name = "Room_Type";
            this.Room_Type.ReadOnly = true;
            // 
            // CheckInDate
            // 
            this.CheckInDate.DataPropertyName = "CheckInDate";
            this.CheckInDate.HeaderText = "CheckIn Date";
            this.CheckInDate.MinimumWidth = 8;
            this.CheckInDate.Name = "CheckInDate";
            this.CheckInDate.ReadOnly = true;
            // 
            // ExpectedCheckOutDate
            // 
            this.ExpectedCheckOutDate.DataPropertyName = "ExpectedCheckOutDate";
            this.ExpectedCheckOutDate.HeaderText = "ExpectedCheckOut Date";
            this.ExpectedCheckOutDate.MinimumWidth = 8;
            this.ExpectedCheckOutDate.Name = "ExpectedCheckOutDate";
            this.ExpectedCheckOutDate.ReadOnly = true;
            // 
            // RoomRate
            // 
            this.RoomRate.DataPropertyName = "RoomRate";
            this.RoomRate.HeaderText = "Room Rate";
            this.RoomRate.MinimumWidth = 8;
            this.RoomRate.Name = "RoomRate";
            this.RoomRate.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 8;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
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
            this.btnCheckOut.Location = new System.Drawing.Point(586, 287);
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
            this.Load += new System.EventHandler(this.UserControlCheckOut_Load);
            this.Enter += new System.EventHandler(this.UserControlCheckOut_Enter);
            this.tabControlCheckInCheckOut.ResumeLayout(false);
            this.tabPageCheckInList.ResumeLayout(false);
            this.tabPageCheckInList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCheckInList)).EndInit();
            this.tabPageCheckOut.ResumeLayout(false);
            this.tabPageCheckOut.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlCheckInCheckOut;
        private System.Windows.Forms.TabPage tabPageCheckInList;
        private System.Windows.Forms.DataGridView dataGridViewCheckInList;
        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.Button btnCancelCheckIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CheckInOut_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reservation_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Room_Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Room_Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn CheckInDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpectedCheckOutDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
    }
}
