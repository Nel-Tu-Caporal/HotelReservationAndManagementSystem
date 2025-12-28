namespace HotelReservationAndManagementSystem
{
    partial class Hotel
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hotel));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panelSlide = new System.Windows.Forms.Panel();
            this.buttonCheckInCheckOut = new System.Windows.Forms.Button();
            this.buttonSetting = new System.Windows.Forms.Button();
            this.buttonBillAndPayment = new System.Windows.Forms.Button();
            this.buttonReservation = new System.Windows.Forms.Button();
            this.buttonRoom = new System.Windows.Forms.Button();
            this.buttonClient = new System.Windows.Forms.Button();
            this.buttonDashboard = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblLogoLabel = new System.Windows.Forms.Panel();
            this.lblLogoLabel2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labelUserName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.linkLabelLogOut = new System.Windows.Forms.LinkLabel();
            this.labelDateAndTime = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.userControlCheckInAndCheckOut1 = new HotelReservationAndManagementSystem.User_Control.UserControlCheckInAndCheckOut();
            this.userControlSetting1 = new HotelReservationAndManagementSystem.User_Control.UserControlSetting();
            this.userControlClient1 = new HotelReservationAndManagementSystem.User_Control.UserControlClient();
            this.userControlRoom1 = new HotelReservationAndManagementSystem.User_Control.UserControlRoom();
            this.userControlReservation1 = new HotelReservationAndManagementSystem.User_Control.UserControlReservation();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.lblLogoLabel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Wheat;
            this.panel2.Controls.Add(this.panel8);
            this.panel2.Controls.Add(this.panelSlide);
            this.panel2.Controls.Add(this.buttonCheckInCheckOut);
            this.panel2.Controls.Add(this.buttonSetting);
            this.panel2.Controls.Add(this.buttonBillAndPayment);
            this.panel2.Controls.Add(this.buttonReservation);
            this.panel2.Controls.Add(this.buttonRoom);
            this.panel2.Controls.Add(this.buttonClient);
            this.panel2.Controls.Add(this.buttonDashboard);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.ForeColor = System.Drawing.Color.Brown;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(307, 814);
            this.panel2.TabIndex = 0;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Sienna;
            this.panel8.ForeColor = System.Drawing.Color.Maroon;
            this.panel8.Location = new System.Drawing.Point(296, 241);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(10, 573);
            this.panel8.TabIndex = 1;
            // 
            // panelSlide
            // 
            this.panelSlide.BackColor = System.Drawing.Color.Sienna;
            this.panelSlide.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelSlide.Location = new System.Drawing.Point(-3, 276);
            this.panelSlide.Name = "panelSlide";
            this.panelSlide.Size = new System.Drawing.Size(10, 51);
            this.panelSlide.TabIndex = 0;
            this.panelSlide.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSlide_Paint);
            // 
            // buttonCheckInCheckOut
            // 
            this.buttonCheckInCheckOut.FlatAppearance.BorderSize = 0;
            this.buttonCheckInCheckOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCheckInCheckOut.Location = new System.Drawing.Point(41, 534);
            this.buttonCheckInCheckOut.Name = "buttonCheckInCheckOut";
            this.buttonCheckInCheckOut.Size = new System.Drawing.Size(255, 45);
            this.buttonCheckInCheckOut.TabIndex = 5;
            this.buttonCheckInCheckOut.Text = "Check In / Check Out";
            this.buttonCheckInCheckOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCheckInCheckOut.UseVisualStyleBackColor = true;
            this.buttonCheckInCheckOut.Click += new System.EventHandler(this.buttonCheckInCheckOut_Click);
            // 
            // buttonSetting
            // 
            this.buttonSetting.FlatAppearance.BorderSize = 0;
            this.buttonSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSetting.Location = new System.Drawing.Point(41, 671);
            this.buttonSetting.Name = "buttonSetting";
            this.buttonSetting.Size = new System.Drawing.Size(247, 45);
            this.buttonSetting.TabIndex = 7;
            this.buttonSetting.Text = "Setting";
            this.buttonSetting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSetting.UseVisualStyleBackColor = true;
            this.buttonSetting.Click += new System.EventHandler(this.buttonSetting_Click);
            // 
            // buttonBillAndPayment
            // 
            this.buttonBillAndPayment.FlatAppearance.BorderSize = 0;
            this.buttonBillAndPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBillAndPayment.Location = new System.Drawing.Point(38, 602);
            this.buttonBillAndPayment.Name = "buttonBillAndPayment";
            this.buttonBillAndPayment.Size = new System.Drawing.Size(247, 45);
            this.buttonBillAndPayment.TabIndex = 6;
            this.buttonBillAndPayment.Text = "Billing and Payment";
            this.buttonBillAndPayment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBillAndPayment.UseVisualStyleBackColor = true;
            this.buttonBillAndPayment.Click += new System.EventHandler(this.buttonBillAndPayment_Click);
            // 
            // buttonReservation
            // 
            this.buttonReservation.FlatAppearance.BorderSize = 0;
            this.buttonReservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReservation.Location = new System.Drawing.Point(41, 465);
            this.buttonReservation.Name = "buttonReservation";
            this.buttonReservation.Size = new System.Drawing.Size(247, 45);
            this.buttonReservation.TabIndex = 4;
            this.buttonReservation.Text = "Reservation";
            this.buttonReservation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonReservation.UseVisualStyleBackColor = true;
            this.buttonReservation.Click += new System.EventHandler(this.buttonReservation_Click);
            // 
            // buttonRoom
            // 
            this.buttonRoom.FlatAppearance.BorderSize = 0;
            this.buttonRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRoom.Location = new System.Drawing.Point(41, 395);
            this.buttonRoom.Name = "buttonRoom";
            this.buttonRoom.Size = new System.Drawing.Size(247, 45);
            this.buttonRoom.TabIndex = 3;
            this.buttonRoom.Text = "Room";
            this.buttonRoom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRoom.UseVisualStyleBackColor = true;
            this.buttonRoom.Click += new System.EventHandler(this.buttonRoom_Click);
            // 
            // buttonClient
            // 
            this.buttonClient.FlatAppearance.BorderSize = 0;
            this.buttonClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClient.Location = new System.Drawing.Point(41, 334);
            this.buttonClient.Name = "buttonClient";
            this.buttonClient.Size = new System.Drawing.Size(247, 45);
            this.buttonClient.TabIndex = 2;
            this.buttonClient.Text = "Client";
            this.buttonClient.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonClient.UseVisualStyleBackColor = true;
            this.buttonClient.Click += new System.EventHandler(this.buttonClient_Click);
            // 
            // buttonDashboard
            // 
            this.buttonDashboard.FlatAppearance.BorderSize = 0;
            this.buttonDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDashboard.Location = new System.Drawing.Point(41, 276);
            this.buttonDashboard.Name = "buttonDashboard";
            this.buttonDashboard.Size = new System.Drawing.Size(247, 45);
            this.buttonDashboard.TabIndex = 1;
            this.buttonDashboard.Text = "Dashboard";
            this.buttonDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDashboard.UseVisualStyleBackColor = true;
            this.buttonDashboard.Click += new System.EventHandler(this.buttonDashboard_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblLogoLabel);
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(307, 241);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // lblLogoLabel
            // 
            this.lblLogoLabel.BackColor = System.Drawing.Color.White;
            this.lblLogoLabel.Controls.Add(this.lblLogoLabel2);
            this.lblLogoLabel.Controls.Add(this.label2);
            this.lblLogoLabel.ForeColor = System.Drawing.Color.Brown;
            this.lblLogoLabel.Location = new System.Drawing.Point(-2, 138);
            this.lblLogoLabel.Name = "lblLogoLabel";
            this.lblLogoLabel.Size = new System.Drawing.Size(292, 87);
            this.lblLogoLabel.TabIndex = 2;
            // 
            // lblLogoLabel2
            // 
            this.lblLogoLabel2.AutoSize = true;
            this.lblLogoLabel2.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogoLabel2.Location = new System.Drawing.Point(70, 39);
            this.lblLogoLabel2.Name = "lblLogoLabel2";
            this.lblLogoLabel2.Size = new System.Drawing.Size(301, 34);
            this.lblLogoLabel2.TabIndex = 1;
            this.lblLogoLabel2.Text = "Management System";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(311, 34);
            this.label2.TabIndex = 0;
            this.label2.Text = "Hotel Reservation and";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Sienna;
            this.panel7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel7.Location = new System.Drawing.Point(296, -2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(10, 290);
            this.panel7.TabIndex = 1;
            this.panel7.Paint += new System.Windows.Forms.PaintEventHandler(this.panel7_Paint);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Sienna;
            this.panel6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel6.Location = new System.Drawing.Point(-2, 231);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(307, 10);
            this.panel6.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Wheat;
            this.pictureBox2.Image = global::HotelReservationAndManagementSystem.Properties.Resources.download;
            this.pictureBox2.Location = new System.Drawing.Point(-5, -2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(306, 235);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(307, 747);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1173, 67);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(454, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "© 2025 All rights reserved Nel-Tu-Caporal.";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Wheat;
            this.panel4.Controls.Add(this.labelUserName);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(307, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1173, 156);
            this.panel4.TabIndex = 0;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserName.ForeColor = System.Drawing.Color.Brown;
            this.labelUserName.Location = new System.Drawing.Point(104, 66);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(25, 28);
            this.labelUserName.TabIndex = 2;
            this.labelUserName.Text = "?";
            this.labelUserName.Click += new System.EventHandler(this.labelUserName_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Brown;
            this.label4.Location = new System.Drawing.Point(3, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 28);
            this.label4.TabIndex = 1;
            this.label4.Text = "Welcome: ";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.linkLabelLogOut);
            this.panel5.Controls.Add(this.labelDateAndTime);
            this.panel5.Controls.Add(this.pictureBox1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1173, 63);
            this.panel5.TabIndex = 0;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // linkLabelLogOut
            // 
            this.linkLabelLogOut.AutoSize = true;
            this.linkLabelLogOut.Location = new System.Drawing.Point(850, 25);
            this.linkLabelLogOut.Name = "linkLabelLogOut";
            this.linkLabelLogOut.Size = new System.Drawing.Size(95, 26);
            this.linkLabelLogOut.TabIndex = 1;
            this.linkLabelLogOut.TabStop = true;
            this.linkLabelLogOut.Text = "Log Out";
            this.linkLabelLogOut.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelLogOut_LinkClicked);
            // 
            // labelDateAndTime
            // 
            this.labelDateAndTime.AutoSize = true;
            this.labelDateAndTime.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateAndTime.ForeColor = System.Drawing.Color.Black;
            this.labelDateAndTime.Location = new System.Drawing.Point(6, 14);
            this.labelDateAndTime.Name = "labelDateAndTime";
            this.labelDateAndTime.Size = new System.Drawing.Size(25, 28);
            this.labelDateAndTime.TabIndex = 0;
            this.labelDateAndTime.Text = "?";
            this.labelDateAndTime.Click += new System.EventHandler(this.labelDateAndTime_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::HotelReservationAndManagementSystem.Properties.Resources.Profile_Picture_FB;
            this.pictureBox1.Location = new System.Drawing.Point(1113, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // userControlCheckInAndCheckOut1
            // 
            this.userControlCheckInAndCheckOut1.BackColor = System.Drawing.Color.White;
            this.userControlCheckInAndCheckOut1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userControlCheckInAndCheckOut1.Location = new System.Drawing.Point(313, 247);
            this.userControlCheckInAndCheckOut1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.userControlCheckInAndCheckOut1.Name = "userControlCheckInAndCheckOut1";
            this.userControlCheckInAndCheckOut1.Size = new System.Drawing.Size(1469, 494);
            this.userControlCheckInAndCheckOut1.TabIndex = 1;
            this.userControlCheckInAndCheckOut1.Visible = false;
            // 
            // userControlSetting1
            // 
            this.userControlSetting1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userControlSetting1.Location = new System.Drawing.Point(195, -154);
            this.userControlSetting1.Margin = new System.Windows.Forms.Padding(4);
            this.userControlSetting1.Name = "userControlSetting1";
            this.userControlSetting1.Size = new System.Drawing.Size(1634, 1102);
            this.userControlSetting1.TabIndex = 0;
            this.userControlSetting1.Visible = false;
            this.userControlSetting1.Load += new System.EventHandler(this.userControlSetting1_Load_1);
            // 
            // userControlClient1
            // 
            this.userControlClient1.BackColor = System.Drawing.Color.White;
            this.userControlClient1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userControlClient1.Location = new System.Drawing.Point(308, 162);
            this.userControlClient1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.userControlClient1.Name = "userControlClient1";
            this.userControlClient1.Size = new System.Drawing.Size(1054, 430);
            this.userControlClient1.TabIndex = 0;
            this.userControlClient1.Visible = false;
            this.userControlClient1.Load += new System.EventHandler(this.userControlClient1_Load);
            // 
            // userControlRoom1
            // 
            this.userControlRoom1.BackColor = System.Drawing.Color.White;
            this.userControlRoom1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userControlRoom1.Location = new System.Drawing.Point(315, 153);
            this.userControlRoom1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.userControlRoom1.Name = "userControlRoom1";
            this.userControlRoom1.Size = new System.Drawing.Size(1074, 464);
            this.userControlRoom1.TabIndex = 0;
            this.userControlRoom1.Visible = false;
            this.userControlRoom1.Load += new System.EventHandler(this.userControlRoom1_Load);
            // 
            // userControlReservation1
            // 
            this.userControlReservation1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.userControlReservation1.BackColor = System.Drawing.Color.White;
            this.userControlReservation1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userControlReservation1.Location = new System.Drawing.Point(420, 211);
            this.userControlReservation1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.userControlReservation1.Name = "userControlReservation1";
            this.userControlReservation1.Size = new System.Drawing.Size(1102, 462);
            this.userControlReservation1.TabIndex = 0;
            this.userControlReservation1.Visible = false;
            this.userControlReservation1.Load += new System.EventHandler(this.userControlReservation1_Load);
            // 
            // Hotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1480, 814);
            this.Controls.Add(this.userControlCheckInAndCheckOut1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.userControlSetting1);
            this.Controls.Add(this.userControlClient1);
            this.Controls.Add(this.userControlRoom1);
            this.Controls.Add(this.userControlReservation1);
            this.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Hotel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hotel_Reservation_and_Management_System |  Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormDashboard_Load);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.lblLogoLabel.ResumeLayout(false);
            this.lblLogoLabel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label labelDateAndTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Button buttonDashboard;
        private System.Windows.Forms.Button buttonBillAndPayment;
        private System.Windows.Forms.Button buttonReservation;
        private System.Windows.Forms.Button buttonRoom;
        private System.Windows.Forms.Button buttonClient;
        private System.Windows.Forms.Button buttonSetting;
        private System.Windows.Forms.Button buttonCheckInCheckOut;
        private System.Windows.Forms.Panel panelSlide;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.LinkLabel linkLabelLogOut;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel lblLogoLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblLogoLabel2;
        private User_Control.UserControlSetting userControlSetting1;
        private User_Control.UserControlClient userControlClient1;
        private User_Control.UserControlRoom userControlRoom1;
        private User_Control.UserControlReservation userControlReservation1;
        private User_Control.UserControlCheckInAndCheckOut userControlCheckInAndCheckOut1;
    }
}