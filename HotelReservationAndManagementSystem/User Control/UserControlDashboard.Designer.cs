namespace HotelReservationAndManagementSystem.User_Control
{
    partial class UserControlDashboard
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTotalRooms = new System.Windows.Forms.Label();
            this.lblAvailableRooms = new System.Windows.Forms.Label();
            this.lblOccupiedRooms = new System.Windows.Forms.Label();
            this.lblTotalClient = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(38)))), ((int)(((byte)(53)))));
            this.panel1.Controls.Add(this.lblAvailableRooms);
            this.panel1.Controls.Add(this.lblTotalRooms);
            this.panel1.ForeColor = System.Drawing.Color.Maroon;
            this.panel1.Location = new System.Drawing.Point(79, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(443, 154);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(93)))), ((int)(((byte)(80)))));
            this.panel2.Controls.Add(this.lblOccupiedRooms);
            this.panel2.Location = new System.Drawing.Point(560, 71);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(443, 154);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(185)))), ((int)(((byte)(155)))));
            this.panel3.Controls.Add(this.lblTotalClient);
            this.panel3.Location = new System.Drawing.Point(315, 266);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(443, 154);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // lblTotalRooms
            // 
            this.lblTotalRooms.AutoSize = true;
            this.lblTotalRooms.ForeColor = System.Drawing.Color.White;
            this.lblTotalRooms.Location = new System.Drawing.Point(24, 31);
            this.lblTotalRooms.Name = "lblTotalRooms";
            this.lblTotalRooms.Size = new System.Drawing.Size(25, 29);
            this.lblTotalRooms.TabIndex = 1;
            this.lblTotalRooms.Text = "?";
            // 
            // lblAvailableRooms
            // 
            this.lblAvailableRooms.AutoSize = true;
            this.lblAvailableRooms.ForeColor = System.Drawing.Color.White;
            this.lblAvailableRooms.Location = new System.Drawing.Point(24, 80);
            this.lblAvailableRooms.Name = "lblAvailableRooms";
            this.lblAvailableRooms.Size = new System.Drawing.Size(25, 29);
            this.lblAvailableRooms.TabIndex = 3;
            this.lblAvailableRooms.Text = "?";
            this.lblAvailableRooms.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblOccupiedRooms
            // 
            this.lblOccupiedRooms.AutoSize = true;
            this.lblOccupiedRooms.ForeColor = System.Drawing.Color.White;
            this.lblOccupiedRooms.Location = new System.Drawing.Point(35, 31);
            this.lblOccupiedRooms.Name = "lblOccupiedRooms";
            this.lblOccupiedRooms.Size = new System.Drawing.Size(25, 29);
            this.lblOccupiedRooms.TabIndex = 5;
            this.lblOccupiedRooms.Text = "?";
            this.lblOccupiedRooms.Click += new System.EventHandler(this.label7_Click);
            // 
            // lblTotalClient
            // 
            this.lblTotalClient.AutoSize = true;
            this.lblTotalClient.ForeColor = System.Drawing.Color.White;
            this.lblTotalClient.Location = new System.Drawing.Point(35, 55);
            this.lblTotalClient.Name = "lblTotalClient";
            this.lblTotalClient.Size = new System.Drawing.Size(25, 29);
            this.lblTotalClient.TabIndex = 9;
            this.lblTotalClient.Text = "?";
            // 
            // UserControlDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "UserControlDashboard";
            this.Size = new System.Drawing.Size(1102, 472);
            this.Load += new System.EventHandler(this.UserControlDashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblAvailableRooms;
        private System.Windows.Forms.Label lblTotalRooms;
        private System.Windows.Forms.Label lblOccupiedRooms;
        private System.Windows.Forms.Label lblTotalClient;
    }
}
