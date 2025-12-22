namespace HotelReservationAndManagementSystem.User_Control
{
    partial class UserControlRoom
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
            this.tabControlRoom = new System.Windows.Forms.TabControl();
            this.tabPageAddRoom = new System.Windows.Forms.TabPage();
            this.radioButtonNo = new System.Windows.Forms.RadioButton();
            this.radioButtonYes = new System.Windows.Forms.RadioButton();
            this.lblFree = new System.Windows.Forms.Label();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.btnAddRoom = new System.Windows.Forms.Button();
            this.txtBoxPhoneNo = new System.Windows.Forms.TextBox();
            this.lblPhoneNo = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblRoom = new System.Windows.Forms.Label();
            this.tabPageSearchRoom = new System.Windows.Forms.TabPage();
            this.dataGridViewRoom = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBoxSearchRoomNo = new System.Windows.Forms.TextBox();
            this.labelRoom = new System.Windows.Forms.Label();
            this.lblSearchRoom = new System.Windows.Forms.Label();
            this.tabPageUpdateDelete = new System.Windows.Forms.TabPage();
            this.btnDelete = new System.Windows.Forms.Button();
            this.radioButtonNo1 = new System.Windows.Forms.RadioButton();
            this.radioButtonYes1 = new System.Windows.Forms.RadioButton();
            this.lblFree1 = new System.Windows.Forms.Label();
            this.comboBoxType1 = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtBoxPhoneNo1 = new System.Windows.Forms.TextBox();
            this.lblRoomNo = new System.Windows.Forms.Label();
            this.lblType1 = new System.Windows.Forms.Label();
            this.lblUpdateDelete = new System.Windows.Forms.Label();
            this.tabControlRoom.SuspendLayout();
            this.tabPageAddRoom.SuspendLayout();
            this.tabPageSearchRoom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoom)).BeginInit();
            this.tabPageUpdateDelete.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlRoom
            // 
            this.tabControlRoom.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControlRoom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabControlRoom.Controls.Add(this.tabPageAddRoom);
            this.tabControlRoom.Controls.Add(this.tabPageSearchRoom);
            this.tabControlRoom.Controls.Add(this.tabPageUpdateDelete);
            this.tabControlRoom.Location = new System.Drawing.Point(36, 41);
            this.tabControlRoom.Name = "tabControlRoom";
            this.tabControlRoom.SelectedIndex = 0;
            this.tabControlRoom.Size = new System.Drawing.Size(1031, 417);
            this.tabControlRoom.TabIndex = 0;
            this.tabControlRoom.SelectedIndexChanged += new System.EventHandler(this.tabControlRoom_SelectedIndexChanged);
            // 
            // tabPageAddRoom
            // 
            this.tabPageAddRoom.Controls.Add(this.radioButtonNo);
            this.tabPageAddRoom.Controls.Add(this.radioButtonYes);
            this.tabPageAddRoom.Controls.Add(this.lblFree);
            this.tabPageAddRoom.Controls.Add(this.comboBoxType);
            this.tabPageAddRoom.Controls.Add(this.btnAddRoom);
            this.tabPageAddRoom.Controls.Add(this.txtBoxPhoneNo);
            this.tabPageAddRoom.Controls.Add(this.lblPhoneNo);
            this.tabPageAddRoom.Controls.Add(this.lblType);
            this.tabPageAddRoom.Controls.Add(this.lblRoom);
            this.tabPageAddRoom.Location = new System.Drawing.Point(4, 4);
            this.tabPageAddRoom.Name = "tabPageAddRoom";
            this.tabPageAddRoom.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAddRoom.Size = new System.Drawing.Size(1023, 381);
            this.tabPageAddRoom.TabIndex = 0;
            this.tabPageAddRoom.Text = "Add Room";
            this.tabPageAddRoom.UseVisualStyleBackColor = true;
            this.tabPageAddRoom.Click += new System.EventHandler(this.tabPageRoom_Click);
            this.tabPageAddRoom.Leave += new System.EventHandler(this.tabPageAddRoom_Leave);
            // 
            // radioButtonNo
            // 
            this.radioButtonNo.AutoSize = true;
            this.radioButtonNo.Location = new System.Drawing.Point(228, 270);
            this.radioButtonNo.Name = "radioButtonNo";
            this.radioButtonNo.Size = new System.Drawing.Size(63, 27);
            this.radioButtonNo.TabIndex = 22;
            this.radioButtonNo.TabStop = true;
            this.radioButtonNo.Text = "No";
            this.radioButtonNo.UseVisualStyleBackColor = true;
            this.radioButtonNo.CheckedChanged += new System.EventHandler(this.radioButtonNo_CheckedChanged);
            // 
            // radioButtonYes
            // 
            this.radioButtonYes.AutoSize = true;
            this.radioButtonYes.Location = new System.Drawing.Point(228, 237);
            this.radioButtonYes.Name = "radioButtonYes";
            this.radioButtonYes.Size = new System.Drawing.Size(69, 27);
            this.radioButtonYes.TabIndex = 21;
            this.radioButtonYes.TabStop = true;
            this.radioButtonYes.Text = "Yes";
            this.radioButtonYes.UseVisualStyleBackColor = true;
            // 
            // lblFree
            // 
            this.lblFree.AutoSize = true;
            this.lblFree.Location = new System.Drawing.Point(165, 241);
            this.lblFree.Name = "lblFree";
            this.lblFree.Size = new System.Drawing.Size(57, 23);
            this.lblFree.TabIndex = 20;
            this.lblFree.Text = "Free:";
            // 
            // comboBoxType
            // 
            this.comboBoxType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Single ",
            "Double",
            "Family",
            "Suite"});
            this.comboBoxType.Location = new System.Drawing.Point(169, 142);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(291, 31);
            this.comboBoxType.TabIndex = 19;
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.BackColor = System.Drawing.Color.Brown;
            this.btnAddRoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRoom.ForeColor = System.Drawing.Color.White;
            this.btnAddRoom.Location = new System.Drawing.Point(169, 305);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Size = new System.Drawing.Size(144, 52);
            this.btnAddRoom.TabIndex = 18;
            this.btnAddRoom.Text = "Add";
            this.btnAddRoom.UseVisualStyleBackColor = false;
            this.btnAddRoom.Click += new System.EventHandler(this.btnAddRoom_Click);
            // 
            // txtBoxPhoneNo
            // 
            this.txtBoxPhoneNo.Location = new System.Drawing.Point(546, 142);
            this.txtBoxPhoneNo.Name = "txtBoxPhoneNo";
            this.txtBoxPhoneNo.Size = new System.Drawing.Size(254, 32);
            this.txtBoxPhoneNo.TabIndex = 17;
            this.txtBoxPhoneNo.TextChanged += new System.EventHandler(this.txtBoxPhoneNo_TextChanged);
            // 
            // lblPhoneNo
            // 
            this.lblPhoneNo.AutoSize = true;
            this.lblPhoneNo.Location = new System.Drawing.Point(542, 119);
            this.lblPhoneNo.Name = "lblPhoneNo";
            this.lblPhoneNo.Size = new System.Drawing.Size(116, 23);
            this.lblPhoneNo.TabIndex = 16;
            this.lblPhoneNo.Text = "Phone No.:";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(165, 119);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(61, 23);
            this.lblType.TabIndex = 15;
            this.lblType.Text = "Type:";
            // 
            // lblRoom
            // 
            this.lblRoom.AutoSize = true;
            this.lblRoom.ForeColor = System.Drawing.Color.Brown;
            this.lblRoom.Location = new System.Drawing.Point(21, 16);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(121, 23);
            this.lblRoom.TabIndex = 14;
            this.lblRoom.Text = "Add Room:";
            // 
            // tabPageSearchRoom
            // 
            this.tabPageSearchRoom.Controls.Add(this.dataGridViewRoom);
            this.tabPageSearchRoom.Controls.Add(this.txtBoxSearchRoomNo);
            this.tabPageSearchRoom.Controls.Add(this.labelRoom);
            this.tabPageSearchRoom.Controls.Add(this.lblSearchRoom);
            this.tabPageSearchRoom.Location = new System.Drawing.Point(4, 4);
            this.tabPageSearchRoom.Name = "tabPageSearchRoom";
            this.tabPageSearchRoom.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSearchRoom.Size = new System.Drawing.Size(1023, 381);
            this.tabPageSearchRoom.TabIndex = 1;
            this.tabPageSearchRoom.Text = "Search Room";
            this.tabPageSearchRoom.UseVisualStyleBackColor = true;
            this.tabPageSearchRoom.Click += new System.EventHandler(this.tabPageSearchRoom_Click);
            this.tabPageSearchRoom.Enter += new System.EventHandler(this.tabPageSearchRoom_Enter);
            // 
            // dataGridViewRoom
            // 
            this.dataGridViewRoom.AllowUserToAddRows = false;
            this.dataGridViewRoom.AllowUserToDeleteRows = false;
            this.dataGridViewRoom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewRoom.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRoom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridViewRoom.Location = new System.Drawing.Point(6, 113);
            this.dataGridViewRoom.Name = "dataGridViewRoom";
            this.dataGridViewRoom.ReadOnly = true;
            this.dataGridViewRoom.RowHeadersWidth = 62;
            this.dataGridViewRoom.RowTemplate.Height = 28;
            this.dataGridViewRoom.Size = new System.Drawing.Size(824, 248);
            this.dataGridViewRoom.TabIndex = 9;
            this.dataGridViewRoom.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRoom_CellClick);
            this.dataGridViewRoom.Leave += new System.EventHandler(this.dataGridViewRoom_Leave);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "User_ID";
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "User_Name";
            this.Column2.HeaderText = "Username";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "User_Password";
            this.Column3.HeaderText = "Password";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // txtBoxSearchRoomNo
            // 
            this.txtBoxSearchRoomNo.Location = new System.Drawing.Point(104, 64);
            this.txtBoxSearchRoomNo.Name = "txtBoxSearchRoomNo";
            this.txtBoxSearchRoomNo.Size = new System.Drawing.Size(254, 32);
            this.txtBoxSearchRoomNo.TabIndex = 8;
            this.txtBoxSearchRoomNo.TextChanged += new System.EventHandler(this.txtBoxSearchRoom_TextChanged);
            // 
            // labelRoom
            // 
            this.labelRoom.AutoSize = true;
            this.labelRoom.Location = new System.Drawing.Point(100, 41);
            this.labelRoom.Name = "labelRoom";
            this.labelRoom.Size = new System.Drawing.Size(108, 23);
            this.labelRoom.TabIndex = 7;
            this.labelRoom.Tag = "";
            this.labelRoom.Text = "Room no.:";
            // 
            // lblSearchRoom
            // 
            this.lblSearchRoom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSearchRoom.AutoSize = true;
            this.lblSearchRoom.ForeColor = System.Drawing.Color.Brown;
            this.lblSearchRoom.Location = new System.Drawing.Point(6, 11);
            this.lblSearchRoom.Name = "lblSearchRoom";
            this.lblSearchRoom.Size = new System.Drawing.Size(146, 23);
            this.lblSearchRoom.TabIndex = 6;
            this.lblSearchRoom.Text = "Search Room:";
            // 
            // tabPageUpdateDelete
            // 
            this.tabPageUpdateDelete.Controls.Add(this.btnDelete);
            this.tabPageUpdateDelete.Controls.Add(this.radioButtonNo1);
            this.tabPageUpdateDelete.Controls.Add(this.radioButtonYes1);
            this.tabPageUpdateDelete.Controls.Add(this.lblFree1);
            this.tabPageUpdateDelete.Controls.Add(this.comboBoxType1);
            this.tabPageUpdateDelete.Controls.Add(this.btnUpdate);
            this.tabPageUpdateDelete.Controls.Add(this.txtBoxPhoneNo1);
            this.tabPageUpdateDelete.Controls.Add(this.lblRoomNo);
            this.tabPageUpdateDelete.Controls.Add(this.lblType1);
            this.tabPageUpdateDelete.Controls.Add(this.lblUpdateDelete);
            this.tabPageUpdateDelete.Location = new System.Drawing.Point(4, 4);
            this.tabPageUpdateDelete.Name = "tabPageUpdateDelete";
            this.tabPageUpdateDelete.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUpdateDelete.Size = new System.Drawing.Size(1023, 381);
            this.tabPageUpdateDelete.TabIndex = 2;
            this.tabPageUpdateDelete.Text = "Update and Delete Room";
            this.tabPageUpdateDelete.UseVisualStyleBackColor = true;
            this.tabPageUpdateDelete.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Brown;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(322, 301);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(144, 52);
            this.btnDelete.TabIndex = 32;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // radioButtonNo1
            // 
            this.radioButtonNo1.AutoSize = true;
            this.radioButtonNo1.Location = new System.Drawing.Point(213, 266);
            this.radioButtonNo1.Name = "radioButtonNo1";
            this.radioButtonNo1.Size = new System.Drawing.Size(63, 27);
            this.radioButtonNo1.TabIndex = 31;
            this.radioButtonNo1.TabStop = true;
            this.radioButtonNo1.Text = "No";
            this.radioButtonNo1.UseVisualStyleBackColor = true;
            // 
            // radioButtonYes1
            // 
            this.radioButtonYes1.AutoSize = true;
            this.radioButtonYes1.Location = new System.Drawing.Point(213, 233);
            this.radioButtonYes1.Name = "radioButtonYes1";
            this.radioButtonYes1.Size = new System.Drawing.Size(69, 27);
            this.radioButtonYes1.TabIndex = 30;
            this.radioButtonYes1.TabStop = true;
            this.radioButtonYes1.Text = "Yes";
            this.radioButtonYes1.UseVisualStyleBackColor = true;
            // 
            // lblFree1
            // 
            this.lblFree1.AutoSize = true;
            this.lblFree1.Location = new System.Drawing.Point(150, 237);
            this.lblFree1.Name = "lblFree1";
            this.lblFree1.Size = new System.Drawing.Size(57, 23);
            this.lblFree1.TabIndex = 29;
            this.lblFree1.Text = "Free:";
            // 
            // comboBoxType1
            // 
            this.comboBoxType1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxType1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxType1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxType1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxType1.FormattingEnabled = true;
            this.comboBoxType1.Items.AddRange(new object[] {
            "Single ",
            "Double",
            "Family",
            "Suite"});
            this.comboBoxType1.Location = new System.Drawing.Point(154, 138);
            this.comboBoxType1.Name = "comboBoxType1";
            this.comboBoxType1.Size = new System.Drawing.Size(291, 31);
            this.comboBoxType1.TabIndex = 28;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(154, 301);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(144, 52);
            this.btnUpdate.TabIndex = 27;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtBoxPhoneNo1
            // 
            this.txtBoxPhoneNo1.Location = new System.Drawing.Point(531, 138);
            this.txtBoxPhoneNo1.Name = "txtBoxPhoneNo1";
            this.txtBoxPhoneNo1.Size = new System.Drawing.Size(254, 32);
            this.txtBoxPhoneNo1.TabIndex = 26;
            this.txtBoxPhoneNo1.TextChanged += new System.EventHandler(this.txtBoxPhoneNo1_TextChanged);
            // 
            // lblRoomNo
            // 
            this.lblRoomNo.AutoSize = true;
            this.lblRoomNo.Location = new System.Drawing.Point(527, 115);
            this.lblRoomNo.Name = "lblRoomNo";
            this.lblRoomNo.Size = new System.Drawing.Size(116, 23);
            this.lblRoomNo.TabIndex = 25;
            this.lblRoomNo.Text = "Phone No.:";
            // 
            // lblType1
            // 
            this.lblType1.AutoSize = true;
            this.lblType1.Location = new System.Drawing.Point(150, 115);
            this.lblType1.Name = "lblType1";
            this.lblType1.Size = new System.Drawing.Size(61, 23);
            this.lblType1.TabIndex = 24;
            this.lblType1.Text = "Type:";
            // 
            // lblUpdateDelete
            // 
            this.lblUpdateDelete.AutoSize = true;
            this.lblUpdateDelete.ForeColor = System.Drawing.Color.Brown;
            this.lblUpdateDelete.Location = new System.Drawing.Point(6, 12);
            this.lblUpdateDelete.Name = "lblUpdateDelete";
            this.lblUpdateDelete.Size = new System.Drawing.Size(266, 23);
            this.lblUpdateDelete.TabIndex = 23;
            this.lblUpdateDelete.Text = "Room Update and Delete";
            // 
            // UserControlRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tabControlRoom);
            this.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "UserControlRoom";
            this.Size = new System.Drawing.Size(1102, 462);
            this.tabControlRoom.ResumeLayout(false);
            this.tabPageAddRoom.ResumeLayout(false);
            this.tabPageAddRoom.PerformLayout();
            this.tabPageSearchRoom.ResumeLayout(false);
            this.tabPageSearchRoom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoom)).EndInit();
            this.tabPageUpdateDelete.ResumeLayout(false);
            this.tabPageUpdateDelete.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlRoom;
        private System.Windows.Forms.TabPage tabPageAddRoom;
        private System.Windows.Forms.TabPage tabPageSearchRoom;
        private System.Windows.Forms.TabPage tabPageUpdateDelete;
        private System.Windows.Forms.Label lblFree;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Button btnAddRoom;
        private System.Windows.Forms.TextBox txtBoxPhoneNo;
        private System.Windows.Forms.Label lblPhoneNo;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblRoom;
        private System.Windows.Forms.RadioButton radioButtonNo;
        private System.Windows.Forms.RadioButton radioButtonYes;
        private System.Windows.Forms.DataGridView dataGridViewRoom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.TextBox txtBoxSearchRoomNo;
        private System.Windows.Forms.Label labelRoom;
        private System.Windows.Forms.Label lblSearchRoom;
        private System.Windows.Forms.RadioButton radioButtonNo1;
        private System.Windows.Forms.RadioButton radioButtonYes1;
        private System.Windows.Forms.Label lblFree1;
        private System.Windows.Forms.ComboBox comboBoxType1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtBoxPhoneNo1;
        private System.Windows.Forms.Label lblRoomNo;
        private System.Windows.Forms.Label lblType1;
        private System.Windows.Forms.Label lblUpdateDelete;
        private System.Windows.Forms.Button btnDelete;
    }
}
