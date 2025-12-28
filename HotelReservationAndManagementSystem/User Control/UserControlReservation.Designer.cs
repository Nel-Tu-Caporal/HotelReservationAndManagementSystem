namespace HotelReservationAndManagementSystem.User_Control
{
    partial class UserControlReservation
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
            this.tabControlReservation = new System.Windows.Forms.TabControl();
            this.tabPageAddReservation = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerOut = new System.Windows.Forms.DateTimePicker();
            this.lblIN = new System.Windows.Forms.Label();
            this.dateTimePickerIn = new System.Windows.Forms.DateTimePicker();
            this.comboBoxNo = new System.Windows.Forms.ComboBox();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.txtBoxClientID = new System.Windows.Forms.TextBox();
            this.lblClientID = new System.Windows.Forms.Label();
            this.btnAddReservation = new System.Windows.Forms.Button();
            this.lblRoomNo = new System.Windows.Forms.Label();
            this.lblRoomType = new System.Windows.Forms.Label();
            this.labelAddReservation = new System.Windows.Forms.Label();
            this.tabPageSearchRervation = new System.Windows.Forms.TabPage();
            this.dataGridViewReservation = new System.Windows.Forms.DataGridView();
            this.txtBoxSearchClientID = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.lblSearchReservation = new System.Windows.Forms.Label();
            this.tabPageUpdateAndCancelReservation = new System.Windows.Forms.TabPage();
            this.btnCancelReservation = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerOut1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerIn1 = new System.Windows.Forms.DateTimePicker();
            this.comboBoxNo1 = new System.Windows.Forms.ComboBox();
            this.comboBoxType1 = new System.Windows.Forms.ComboBox();
            this.txtBoxClientID1 = new System.Windows.Forms.TextBox();
            this.lblClientID1 = new System.Windows.Forms.Label();
            this.btnUpdateReservation = new System.Windows.Forms.Button();
            this.lblRoomNo1 = new System.Windows.Forms.Label();
            this.lblRoomType1 = new System.Windows.Forms.Label();
            this.lblUpdateCancel = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControlReservation.SuspendLayout();
            this.tabPageAddReservation.SuspendLayout();
            this.tabPageSearchRervation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReservation)).BeginInit();
            this.tabPageUpdateAndCancelReservation.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlReservation
            // 
            this.tabControlReservation.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControlReservation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabControlReservation.Controls.Add(this.tabPageAddReservation);
            this.tabControlReservation.Controls.Add(this.tabPageSearchRervation);
            this.tabControlReservation.Controls.Add(this.tabPageUpdateAndCancelReservation);
            this.tabControlReservation.Location = new System.Drawing.Point(19, 21);
            this.tabControlReservation.Name = "tabControlReservation";
            this.tabControlReservation.SelectedIndex = 0;
            this.tabControlReservation.Size = new System.Drawing.Size(1012, 403);
            this.tabControlReservation.TabIndex = 0;
            // 
            // tabPageAddReservation
            // 
            this.tabPageAddReservation.Controls.Add(this.label2);
            this.tabPageAddReservation.Controls.Add(this.dateTimePickerOut);
            this.tabPageAddReservation.Controls.Add(this.lblIN);
            this.tabPageAddReservation.Controls.Add(this.dateTimePickerIn);
            this.tabPageAddReservation.Controls.Add(this.comboBoxNo);
            this.tabPageAddReservation.Controls.Add(this.comboBoxType);
            this.tabPageAddReservation.Controls.Add(this.txtBoxClientID);
            this.tabPageAddReservation.Controls.Add(this.lblClientID);
            this.tabPageAddReservation.Controls.Add(this.btnAddReservation);
            this.tabPageAddReservation.Controls.Add(this.lblRoomNo);
            this.tabPageAddReservation.Controls.Add(this.lblRoomType);
            this.tabPageAddReservation.Controls.Add(this.labelAddReservation);
            this.tabPageAddReservation.Location = new System.Drawing.Point(4, 4);
            this.tabPageAddReservation.Name = "tabPageAddReservation";
            this.tabPageAddReservation.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAddReservation.Size = new System.Drawing.Size(1004, 367);
            this.tabPageAddReservation.TabIndex = 0;
            this.tabPageAddReservation.Text = "Add Reservation";
            this.tabPageAddReservation.UseVisualStyleBackColor = true;
            this.tabPageAddReservation.Click += new System.EventHandler(this.tabPageAddReservation_Click);
            this.tabPageAddReservation.Leave += new System.EventHandler(this.tabPageAddReservation_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(588, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 23);
            this.label2.TabIndex = 27;
            this.label2.Text = "OUT:";
            // 
            // dateTimePickerOut
            // 
            this.dateTimePickerOut.Location = new System.Drawing.Point(592, 231);
            this.dateTimePickerOut.Name = "dateTimePickerOut";
            this.dateTimePickerOut.Size = new System.Drawing.Size(254, 32);
            this.dateTimePickerOut.TabIndex = 26;
            // 
            // lblIN
            // 
            this.lblIN.AutoSize = true;
            this.lblIN.Location = new System.Drawing.Point(157, 194);
            this.lblIN.Name = "lblIN";
            this.lblIN.Size = new System.Drawing.Size(35, 23);
            this.lblIN.TabIndex = 25;
            this.lblIN.Text = "IN:";
            this.lblIN.Click += new System.EventHandler(this.label1_Click);
            // 
            // dateTimePickerIn
            // 
            this.dateTimePickerIn.Location = new System.Drawing.Point(161, 231);
            this.dateTimePickerIn.Name = "dateTimePickerIn";
            this.dateTimePickerIn.Size = new System.Drawing.Size(254, 32);
            this.dateTimePickerIn.TabIndex = 24;
            this.dateTimePickerIn.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // comboBoxNo
            // 
            this.comboBoxNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxNo.FormattingEnabled = true;
            this.comboBoxNo.Items.AddRange(new object[] {
            "Please select ..."});
            this.comboBoxNo.Location = new System.Drawing.Point(592, 80);
            this.comboBoxNo.Name = "comboBoxNo";
            this.comboBoxNo.Size = new System.Drawing.Size(254, 31);
            this.comboBoxNo.TabIndex = 23;
            // 
            // comboBoxType
            // 
            this.comboBoxType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Please select ...",
            "Single",
            "Double",
            "Family",
            "Suite"});
            this.comboBoxType.Location = new System.Drawing.Point(161, 80);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(254, 31);
            this.comboBoxType.TabIndex = 22;
            this.comboBoxType.SelectedIndexChanged += new System.EventHandler(this.comboBoxRoomType_SelectedIndexChanged);
            // 
            // txtBoxClientID
            // 
            this.txtBoxClientID.Location = new System.Drawing.Point(161, 147);
            this.txtBoxClientID.Name = "txtBoxClientID";
            this.txtBoxClientID.Size = new System.Drawing.Size(254, 32);
            this.txtBoxClientID.TabIndex = 21;
            this.txtBoxClientID.TextChanged += new System.EventHandler(this.txtBoxClientID_TextChanged);
            // 
            // lblClientID
            // 
            this.lblClientID.AutoSize = true;
            this.lblClientID.Location = new System.Drawing.Point(157, 114);
            this.lblClientID.Name = "lblClientID";
            this.lblClientID.Size = new System.Drawing.Size(104, 23);
            this.lblClientID.TabIndex = 20;
            this.lblClientID.Text = "Cliend ID:";
            // 
            // btnAddReservation
            // 
            this.btnAddReservation.BackColor = System.Drawing.Color.Brown;
            this.btnAddReservation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddReservation.ForeColor = System.Drawing.Color.White;
            this.btnAddReservation.Location = new System.Drawing.Point(161, 276);
            this.btnAddReservation.Name = "btnAddReservation";
            this.btnAddReservation.Size = new System.Drawing.Size(144, 52);
            this.btnAddReservation.TabIndex = 19;
            this.btnAddReservation.Text = "Add";
            this.btnAddReservation.UseVisualStyleBackColor = false;
            this.btnAddReservation.Click += new System.EventHandler(this.btnAddReservation_Click);
            // 
            // lblRoomNo
            // 
            this.lblRoomNo.AutoSize = true;
            this.lblRoomNo.Location = new System.Drawing.Point(588, 45);
            this.lblRoomNo.Name = "lblRoomNo";
            this.lblRoomNo.Size = new System.Drawing.Size(111, 23);
            this.lblRoomNo.TabIndex = 17;
            this.lblRoomNo.Text = "Room No.:";
            // 
            // lblRoomType
            // 
            this.lblRoomType.AutoSize = true;
            this.lblRoomType.Location = new System.Drawing.Point(157, 45);
            this.lblRoomType.Name = "lblRoomType";
            this.lblRoomType.Size = new System.Drawing.Size(124, 23);
            this.lblRoomType.TabIndex = 15;
            this.lblRoomType.Text = "Room Type:";
            // 
            // labelAddReservation
            // 
            this.labelAddReservation.AutoSize = true;
            this.labelAddReservation.ForeColor = System.Drawing.Color.Brown;
            this.labelAddReservation.Location = new System.Drawing.Point(13, 12);
            this.labelAddReservation.Name = "labelAddReservation";
            this.labelAddReservation.Size = new System.Drawing.Size(178, 23);
            this.labelAddReservation.TabIndex = 14;
            this.labelAddReservation.Text = "Add Reservation:";
            // 
            // tabPageSearchRervation
            // 
            this.tabPageSearchRervation.Controls.Add(this.dataGridViewReservation);
            this.tabPageSearchRervation.Controls.Add(this.txtBoxSearchClientID);
            this.tabPageSearchRervation.Controls.Add(this.lblId);
            this.tabPageSearchRervation.Controls.Add(this.lblSearchReservation);
            this.tabPageSearchRervation.Location = new System.Drawing.Point(4, 4);
            this.tabPageSearchRervation.Name = "tabPageSearchRervation";
            this.tabPageSearchRervation.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSearchRervation.Size = new System.Drawing.Size(1004, 367);
            this.tabPageSearchRervation.TabIndex = 1;
            this.tabPageSearchRervation.Text = "Search Reservation";
            this.tabPageSearchRervation.UseVisualStyleBackColor = true;
            this.tabPageSearchRervation.Click += new System.EventHandler(this.tabPageSearchRervation_Click);
            this.tabPageSearchRervation.Enter += new System.EventHandler(this.tabPageSearchRervation_Enter);
            this.tabPageSearchRervation.Leave += new System.EventHandler(this.tabPageSearchRervation_Leave);
            // 
            // dataGridViewReservation
            // 
            this.dataGridViewReservation.AllowUserToAddRows = false;
            this.dataGridViewReservation.AllowUserToDeleteRows = false;
            this.dataGridViewReservation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewReservation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewReservation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReservation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dataGridViewReservation.Location = new System.Drawing.Point(23, 88);
            this.dataGridViewReservation.Name = "dataGridViewReservation";
            this.dataGridViewReservation.ReadOnly = true;
            this.dataGridViewReservation.RowHeadersWidth = 62;
            this.dataGridViewReservation.RowTemplate.Height = 28;
            this.dataGridViewReservation.Size = new System.Drawing.Size(816, 248);
            this.dataGridViewReservation.TabIndex = 13;
            this.dataGridViewReservation.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewReservation_CellClick);
            this.dataGridViewReservation.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewReservation_CellContentClick);
            // 
            // txtBoxSearchClientID
            // 
            this.txtBoxSearchClientID.Location = new System.Drawing.Point(182, 50);
            this.txtBoxSearchClientID.Name = "txtBoxSearchClientID";
            this.txtBoxSearchClientID.Size = new System.Drawing.Size(254, 32);
            this.txtBoxSearchClientID.TabIndex = 12;
            this.txtBoxSearchClientID.TextChanged += new System.EventHandler(this.txtBoxSearchClientID_TextChanged);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(178, 27);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(110, 23);
            this.lblId.TabIndex = 11;
            this.lblId.Text = "Clienet ID:";
            // 
            // lblSearchReservation
            // 
            this.lblSearchReservation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSearchReservation.AutoSize = true;
            this.lblSearchReservation.ForeColor = System.Drawing.Color.Brown;
            this.lblSearchReservation.Location = new System.Drawing.Point(19, 8);
            this.lblSearchReservation.Name = "lblSearchReservation";
            this.lblSearchReservation.Size = new System.Drawing.Size(145, 23);
            this.lblSearchReservation.TabIndex = 10;
            this.lblSearchReservation.Text = "Search Client:";
            // 
            // tabPageUpdateAndCancelReservation
            // 
            this.tabPageUpdateAndCancelReservation.Controls.Add(this.btnCancelReservation);
            this.tabPageUpdateAndCancelReservation.Controls.Add(this.label1);
            this.tabPageUpdateAndCancelReservation.Controls.Add(this.dateTimePickerOut1);
            this.tabPageUpdateAndCancelReservation.Controls.Add(this.label3);
            this.tabPageUpdateAndCancelReservation.Controls.Add(this.dateTimePickerIn1);
            this.tabPageUpdateAndCancelReservation.Controls.Add(this.comboBoxNo1);
            this.tabPageUpdateAndCancelReservation.Controls.Add(this.comboBoxType1);
            this.tabPageUpdateAndCancelReservation.Controls.Add(this.txtBoxClientID1);
            this.tabPageUpdateAndCancelReservation.Controls.Add(this.lblClientID1);
            this.tabPageUpdateAndCancelReservation.Controls.Add(this.btnUpdateReservation);
            this.tabPageUpdateAndCancelReservation.Controls.Add(this.lblRoomNo1);
            this.tabPageUpdateAndCancelReservation.Controls.Add(this.lblRoomType1);
            this.tabPageUpdateAndCancelReservation.Controls.Add(this.lblUpdateCancel);
            this.tabPageUpdateAndCancelReservation.Location = new System.Drawing.Point(4, 4);
            this.tabPageUpdateAndCancelReservation.Name = "tabPageUpdateAndCancelReservation";
            this.tabPageUpdateAndCancelReservation.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUpdateAndCancelReservation.Size = new System.Drawing.Size(1004, 367);
            this.tabPageUpdateAndCancelReservation.TabIndex = 2;
            this.tabPageUpdateAndCancelReservation.Text = "Update and Cancel Reservation";
            this.tabPageUpdateAndCancelReservation.UseVisualStyleBackColor = true;
            this.tabPageUpdateAndCancelReservation.Click += new System.EventHandler(this.tabPageUpdateAndCancelReservation_Click);
            this.tabPageUpdateAndCancelReservation.Leave += new System.EventHandler(this.tabPageUpdateAndCancelReservation_Leave);
            // 
            // btnCancelReservation
            // 
            this.btnCancelReservation.BackColor = System.Drawing.Color.Brown;
            this.btnCancelReservation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelReservation.ForeColor = System.Drawing.Color.White;
            this.btnCancelReservation.Location = new System.Drawing.Point(313, 278);
            this.btnCancelReservation.Name = "btnCancelReservation";
            this.btnCancelReservation.Size = new System.Drawing.Size(144, 52);
            this.btnCancelReservation.TabIndex = 40;
            this.btnCancelReservation.Text = "Cancel";
            this.btnCancelReservation.UseVisualStyleBackColor = false;
            this.btnCancelReservation.Click += new System.EventHandler(this.btnCancelReservation_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(590, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 23);
            this.label1.TabIndex = 39;
            this.label1.Text = "OUT:";
            // 
            // dateTimePickerOut1
            // 
            this.dateTimePickerOut1.Location = new System.Drawing.Point(594, 233);
            this.dateTimePickerOut1.Name = "dateTimePickerOut1";
            this.dateTimePickerOut1.Size = new System.Drawing.Size(254, 32);
            this.dateTimePickerOut1.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(159, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 23);
            this.label3.TabIndex = 37;
            this.label3.Text = "IN:";
            // 
            // dateTimePickerIn1
            // 
            this.dateTimePickerIn1.Location = new System.Drawing.Point(163, 233);
            this.dateTimePickerIn1.Name = "dateTimePickerIn1";
            this.dateTimePickerIn1.Size = new System.Drawing.Size(294, 32);
            this.dateTimePickerIn1.TabIndex = 36;
            // 
            // comboBoxNo1
            // 
            this.comboBoxNo1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxNo1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNo1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxNo1.FormattingEnabled = true;
            this.comboBoxNo1.Items.AddRange(new object[] {
            "Please select ..."});
            this.comboBoxNo1.Location = new System.Drawing.Point(594, 82);
            this.comboBoxNo1.Name = "comboBoxNo1";
            this.comboBoxNo1.Size = new System.Drawing.Size(254, 31);
            this.comboBoxNo1.TabIndex = 35;
            // 
            // comboBoxType1
            // 
            this.comboBoxType1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxType1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxType1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxType1.FormattingEnabled = true;
            this.comboBoxType1.Items.AddRange(new object[] {
            "Please select ... ",
            "Single",
            "Double",
            "Family",
            "Suite"});
            this.comboBoxType1.Location = new System.Drawing.Point(163, 82);
            this.comboBoxType1.Name = "comboBoxType1";
            this.comboBoxType1.Size = new System.Drawing.Size(294, 31);
            this.comboBoxType1.TabIndex = 34;
            this.comboBoxType1.SelectedIndexChanged += new System.EventHandler(this.comboBoxType1_SelectedIndexChanged);
            this.comboBoxType1.TextChanged += new System.EventHandler(this.comboBoxType1_TextChanged);
            // 
            // txtBoxClientID1
            // 
            this.txtBoxClientID1.Location = new System.Drawing.Point(163, 149);
            this.txtBoxClientID1.Name = "txtBoxClientID1";
            this.txtBoxClientID1.Size = new System.Drawing.Size(294, 32);
            this.txtBoxClientID1.TabIndex = 33;
            this.txtBoxClientID1.TextChanged += new System.EventHandler(this.txtBoxClientID1_TextChanged);
            // 
            // lblClientID1
            // 
            this.lblClientID1.AutoSize = true;
            this.lblClientID1.Location = new System.Drawing.Point(159, 116);
            this.lblClientID1.Name = "lblClientID1";
            this.lblClientID1.Size = new System.Drawing.Size(104, 23);
            this.lblClientID1.TabIndex = 32;
            this.lblClientID1.Text = "Cliend ID:";
            // 
            // btnUpdateReservation
            // 
            this.btnUpdateReservation.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnUpdateReservation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateReservation.ForeColor = System.Drawing.Color.White;
            this.btnUpdateReservation.Location = new System.Drawing.Point(163, 278);
            this.btnUpdateReservation.Name = "btnUpdateReservation";
            this.btnUpdateReservation.Size = new System.Drawing.Size(144, 52);
            this.btnUpdateReservation.TabIndex = 31;
            this.btnUpdateReservation.Text = "Update";
            this.btnUpdateReservation.UseVisualStyleBackColor = false;
            this.btnUpdateReservation.Click += new System.EventHandler(this.btnUpdateReservation_Click);
            // 
            // lblRoomNo1
            // 
            this.lblRoomNo1.AutoSize = true;
            this.lblRoomNo1.Location = new System.Drawing.Point(590, 47);
            this.lblRoomNo1.Name = "lblRoomNo1";
            this.lblRoomNo1.Size = new System.Drawing.Size(111, 23);
            this.lblRoomNo1.TabIndex = 30;
            this.lblRoomNo1.Text = "Room No.:";
            // 
            // lblRoomType1
            // 
            this.lblRoomType1.AutoSize = true;
            this.lblRoomType1.Location = new System.Drawing.Point(159, 47);
            this.lblRoomType1.Name = "lblRoomType1";
            this.lblRoomType1.Size = new System.Drawing.Size(124, 23);
            this.lblRoomType1.TabIndex = 29;
            this.lblRoomType1.Text = "Room Type:";
            // 
            // lblUpdateCancel
            // 
            this.lblUpdateCancel.AutoSize = true;
            this.lblUpdateCancel.ForeColor = System.Drawing.Color.Brown;
            this.lblUpdateCancel.Location = new System.Drawing.Point(15, 14);
            this.lblUpdateCancel.Name = "lblUpdateCancel";
            this.lblUpdateCancel.Size = new System.Drawing.Size(318, 23);
            this.lblUpdateCancel.TabIndex = 28;
            this.lblUpdateCancel.Text = "Updat And Cancel Reservation";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Reservation_ID";
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Room_Type";
            this.Column2.HeaderText = "Room Type";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Room_Number";
            this.Column3.HeaderText = "Room No.";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Client_ID";
            this.Column4.HeaderText = "Client ID";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Reservation_In";
            this.Column5.HeaderText = "In";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Reservation_Out";
            this.Column6.HeaderText = "Out";
            this.Column6.MinimumWidth = 8;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "Reservation_Status";
            this.Column7.HeaderText = "Status";
            this.Column7.MinimumWidth = 8;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // UserControlReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tabControlReservation);
            this.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "UserControlReservation";
            this.Size = new System.Drawing.Size(1102, 462);
            this.Load += new System.EventHandler(this.UserControlReservation_Load);
            this.tabControlReservation.ResumeLayout(false);
            this.tabPageAddReservation.ResumeLayout(false);
            this.tabPageAddReservation.PerformLayout();
            this.tabPageSearchRervation.ResumeLayout(false);
            this.tabPageSearchRervation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReservation)).EndInit();
            this.tabPageUpdateAndCancelReservation.ResumeLayout(false);
            this.tabPageUpdateAndCancelReservation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlReservation;
        private System.Windows.Forms.TabPage tabPageAddReservation;
        private System.Windows.Forms.TabPage tabPageSearchRervation;
        private System.Windows.Forms.TabPage tabPageUpdateAndCancelReservation;
        private System.Windows.Forms.Label lblIN;
        private System.Windows.Forms.DateTimePicker dateTimePickerIn;
        private System.Windows.Forms.ComboBox comboBoxNo;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.TextBox txtBoxClientID;
        private System.Windows.Forms.Label lblClientID;
        private System.Windows.Forms.Button btnAddReservation;
        private System.Windows.Forms.Label lblRoomNo;
        private System.Windows.Forms.Label lblRoomType;
        private System.Windows.Forms.Label labelAddReservation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerOut;
        private System.Windows.Forms.DataGridView dataGridViewReservation;
        private System.Windows.Forms.TextBox txtBoxSearchClientID;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblSearchReservation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerOut1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePickerIn1;
        private System.Windows.Forms.ComboBox comboBoxNo1;
        private System.Windows.Forms.ComboBox comboBoxType1;
        private System.Windows.Forms.TextBox txtBoxClientID1;
        private System.Windows.Forms.Label lblClientID1;
        private System.Windows.Forms.Button btnUpdateReservation;
        private System.Windows.Forms.Label lblRoomNo1;
        private System.Windows.Forms.Label lblRoomType1;
        private System.Windows.Forms.Label lblUpdateCancel;
        private System.Windows.Forms.Button btnCancelReservation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}
