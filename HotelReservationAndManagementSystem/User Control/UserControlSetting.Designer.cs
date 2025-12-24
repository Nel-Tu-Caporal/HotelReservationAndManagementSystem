namespace HotelReservationAndManagementSystem.User_Control
{
    partial class UserControlSetting
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
            this.tabControlUser = new System.Windows.Forms.TabControl();
            this.tabPageAddUser = new System.Windows.Forms.TabPage();
            this.btnAddUserNamePassword = new System.Windows.Forms.Button();
            this.txtBoxPassword = new System.Windows.Forms.TextBox();
            this.lblUserPassword = new System.Windows.Forms.Label();
            this.txtBoxUserName = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.labelAddUserSetting = new System.Windows.Forms.Label();
            this.tabPageSearchUSer = new System.Windows.Forms.TabPage();
            this.dataGridViewUser = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxSearchRoom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSearchUser = new System.Windows.Forms.Label();
            this.tabPageUpdateAndDeleteUser = new System.Windows.Forms.TabPage();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtBoxPassword1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxUserName1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControlUser.SuspendLayout();
            this.tabPageAddUser.SuspendLayout();
            this.tabPageSearchUSer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUser)).BeginInit();
            this.tabPageUpdateAndDeleteUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlUser
            // 
            this.tabControlUser.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControlUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabControlUser.Controls.Add(this.tabPageAddUser);
            this.tabControlUser.Controls.Add(this.tabPageSearchUSer);
            this.tabControlUser.Controls.Add(this.tabPageUpdateAndDeleteUser);
            this.tabControlUser.Location = new System.Drawing.Point(35, 33);
            this.tabControlUser.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabControlUser.Name = "tabControlUser";
            this.tabControlUser.SelectedIndex = 0;
            this.tabControlUser.Size = new System.Drawing.Size(1388, 451);
            this.tabControlUser.TabIndex = 0;
            this.tabControlUser.Leave += new System.EventHandler(this.tabControlUser_Leave);
            // 
            // tabPageAddUser
            // 
            this.tabPageAddUser.Controls.Add(this.btnAddUserNamePassword);
            this.tabPageAddUser.Controls.Add(this.txtBoxPassword);
            this.tabPageAddUser.Controls.Add(this.lblUserPassword);
            this.tabPageAddUser.Controls.Add(this.txtBoxUserName);
            this.tabPageAddUser.Controls.Add(this.lblUserName);
            this.tabPageAddUser.Controls.Add(this.labelAddUserSetting);
            this.tabPageAddUser.Location = new System.Drawing.Point(4, 4);
            this.tabPageAddUser.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPageAddUser.Name = "tabPageAddUser";
            this.tabPageAddUser.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPageAddUser.Size = new System.Drawing.Size(1380, 415);
            this.tabPageAddUser.TabIndex = 0;
            this.tabPageAddUser.Text = "Add User";
            this.tabPageAddUser.UseVisualStyleBackColor = true;
            this.tabPageAddUser.Click += new System.EventHandler(this.tabPageAddUser_Click);
            this.tabPageAddUser.Leave += new System.EventHandler(this.tabPageAddUser_Leave);
            // 
            // btnAddUserNamePassword
            // 
            this.btnAddUserNamePassword.BackColor = System.Drawing.Color.Brown;
            this.btnAddUserNamePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddUserNamePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUserNamePassword.ForeColor = System.Drawing.Color.White;
            this.btnAddUserNamePassword.Location = new System.Drawing.Point(96, 188);
            this.btnAddUserNamePassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAddUserNamePassword.Name = "btnAddUserNamePassword";
            this.btnAddUserNamePassword.Size = new System.Drawing.Size(192, 60);
            this.btnAddUserNamePassword.TabIndex = 5;
            this.btnAddUserNamePassword.Text = "Add";
            this.btnAddUserNamePassword.UseVisualStyleBackColor = false;
            this.btnAddUserNamePassword.Click += new System.EventHandler(this.btnAddUserNamePassword_Click);
            // 
            // txtBoxPassword
            // 
            this.txtBoxPassword.Location = new System.Drawing.Point(518, 150);
            this.txtBoxPassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.Size = new System.Drawing.Size(337, 32);
            this.txtBoxPassword.TabIndex = 4;
            this.txtBoxPassword.TextChanged += new System.EventHandler(this.txtBoxPassword_TextChanged);
            // 
            // lblUserPassword
            // 
            this.lblUserPassword.AutoSize = true;
            this.lblUserPassword.Location = new System.Drawing.Point(514, 123);
            this.lblUserPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserPassword.Name = "lblUserPassword";
            this.lblUserPassword.Size = new System.Drawing.Size(154, 23);
            this.lblUserPassword.TabIndex = 3;
            this.lblUserPassword.Text = "User Password:";
            // 
            // txtBoxUserName
            // 
            this.txtBoxUserName.Location = new System.Drawing.Point(96, 150);
            this.txtBoxUserName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtBoxUserName.Name = "txtBoxUserName";
            this.txtBoxUserName.Size = new System.Drawing.Size(337, 32);
            this.txtBoxUserName.TabIndex = 2;
            this.txtBoxUserName.TextChanged += new System.EventHandler(this.txtBoxUserName_TextChanged);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(90, 123);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(122, 23);
            this.lblUserName.TabIndex = 1;
            this.lblUserName.Text = "User Name:";
            this.lblUserName.Click += new System.EventHandler(this.lblAddUsername_Click);
            // 
            // labelAddUserSetting
            // 
            this.labelAddUserSetting.AutoSize = true;
            this.labelAddUserSetting.ForeColor = System.Drawing.Color.Brown;
            this.labelAddUserSetting.Location = new System.Drawing.Point(5, 8);
            this.labelAddUserSetting.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAddUserSetting.Name = "labelAddUserSetting";
            this.labelAddUserSetting.Size = new System.Drawing.Size(104, 23);
            this.labelAddUserSetting.TabIndex = 0;
            this.labelAddUserSetting.Text = "Add User:";
            // 
            // tabPageSearchUSer
            // 
            this.tabPageSearchUSer.Controls.Add(this.dataGridViewUser);
            this.tabPageSearchUSer.Controls.Add(this.textBoxSearchRoom);
            this.tabPageSearchUSer.Controls.Add(this.label1);
            this.tabPageSearchUSer.Controls.Add(this.lblSearchUser);
            this.tabPageSearchUSer.Location = new System.Drawing.Point(4, 4);
            this.tabPageSearchUSer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPageSearchUSer.Name = "tabPageSearchUSer";
            this.tabPageSearchUSer.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPageSearchUSer.Size = new System.Drawing.Size(1380, 415);
            this.tabPageSearchUSer.TabIndex = 1;
            this.tabPageSearchUSer.Text = "Search User";
            this.tabPageSearchUSer.UseVisualStyleBackColor = true;
            this.tabPageSearchUSer.Enter += new System.EventHandler(this.tabPageSearchUSer_Enter);
            this.tabPageSearchUSer.Leave += new System.EventHandler(this.tabPageSearchUSer_Leave);
            // 
            // dataGridViewUser
            // 
            this.dataGridViewUser.AllowUserToAddRows = false;
            this.dataGridViewUser.AllowUserToDeleteRows = false;
            this.dataGridViewUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridViewUser.Location = new System.Drawing.Point(8, 119);
            this.dataGridViewUser.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridViewUser.Name = "dataGridViewUser";
            this.dataGridViewUser.ReadOnly = true;
            this.dataGridViewUser.RowHeadersWidth = 62;
            this.dataGridViewUser.RowTemplate.Height = 28;
            this.dataGridViewUser.Size = new System.Drawing.Size(926, 285);
            this.dataGridViewUser.TabIndex = 5;
            this.dataGridViewUser.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUser_CellClick);
            this.dataGridViewUser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUser_CellContentClick);
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
            this.Column2.HeaderText = "User Name";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "User_Password";
            this.Column3.HeaderText = "User Password";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // textBoxSearchRoom
            // 
            this.textBoxSearchRoom.Location = new System.Drawing.Point(139, 64);
            this.textBoxSearchRoom.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxSearchRoom.Name = "textBoxSearchRoom";
            this.textBoxSearchRoom.Size = new System.Drawing.Size(337, 32);
            this.textBoxSearchRoom.TabIndex = 4;
            this.textBoxSearchRoom.TextChanged += new System.EventHandler(this.textBoxSearchUserName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "User Name:";
            // 
            // lblSearchUser
            // 
            this.lblSearchUser.AutoSize = true;
            this.lblSearchUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSearchUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblSearchUser.ForeColor = System.Drawing.Color.Brown;
            this.lblSearchUser.Location = new System.Drawing.Point(4, 3);
            this.lblSearchUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearchUser.Name = "lblSearchUser";
            this.lblSearchUser.Size = new System.Drawing.Size(124, 23);
            this.lblSearchUser.TabIndex = 0;
            this.lblSearchUser.Text = "Search User";
            // 
            // tabPageUpdateAndDeleteUser
            // 
            this.tabPageUpdateAndDeleteUser.Controls.Add(this.btnDelete);
            this.tabPageUpdateAndDeleteUser.Controls.Add(this.btnUpdate);
            this.tabPageUpdateAndDeleteUser.Controls.Add(this.txtBoxPassword1);
            this.tabPageUpdateAndDeleteUser.Controls.Add(this.label2);
            this.tabPageUpdateAndDeleteUser.Controls.Add(this.txtBoxUserName1);
            this.tabPageUpdateAndDeleteUser.Controls.Add(this.label3);
            this.tabPageUpdateAndDeleteUser.Controls.Add(this.label4);
            this.tabPageUpdateAndDeleteUser.Location = new System.Drawing.Point(4, 4);
            this.tabPageUpdateAndDeleteUser.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPageUpdateAndDeleteUser.Name = "tabPageUpdateAndDeleteUser";
            this.tabPageUpdateAndDeleteUser.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPageUpdateAndDeleteUser.Size = new System.Drawing.Size(1380, 415);
            this.tabPageUpdateAndDeleteUser.TabIndex = 2;
            this.tabPageUpdateAndDeleteUser.Text = "Update and Delete User";
            this.tabPageUpdateAndDeleteUser.UseVisualStyleBackColor = true;
            this.tabPageUpdateAndDeleteUser.Click += new System.EventHandler(this.tabPageUpdateAndDeleteUser_Click);
            this.tabPageUpdateAndDeleteUser.Leave += new System.EventHandler(this.tabPageUpdateAndDeleteUser_Leave);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Brown;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(311, 195);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(192, 60);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(111, 195);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(192, 60);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtBoxPassword1
            // 
            this.txtBoxPassword1.Location = new System.Drawing.Point(598, 157);
            this.txtBoxPassword1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtBoxPassword1.Name = "txtBoxPassword1";
            this.txtBoxPassword1.Size = new System.Drawing.Size(384, 32);
            this.txtBoxPassword1.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(594, 131);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "User Password:";
            // 
            // txtBoxUserName1
            // 
            this.txtBoxUserName1.Location = new System.Drawing.Point(111, 157);
            this.txtBoxUserName1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtBoxUserName1.Name = "txtBoxUserName1";
            this.txtBoxUserName1.Size = new System.Drawing.Size(391, 32);
            this.txtBoxUserName1.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(106, 131);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "User Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Brown;
            this.label4.Location = new System.Drawing.Point(20, 18);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(254, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Update and Delete User:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // UserControlSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControlUser);
            this.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "UserControlSetting";
            this.Size = new System.Drawing.Size(1469, 531);
            this.tabControlUser.ResumeLayout(false);
            this.tabPageAddUser.ResumeLayout(false);
            this.tabPageAddUser.PerformLayout();
            this.tabPageSearchUSer.ResumeLayout(false);
            this.tabPageSearchUSer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUser)).EndInit();
            this.tabPageUpdateAndDeleteUser.ResumeLayout(false);
            this.tabPageUpdateAndDeleteUser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlUser;
        private System.Windows.Forms.TabPage tabPageAddUser;
        private System.Windows.Forms.TabPage tabPageSearchUSer;
        private System.Windows.Forms.Label labelAddUserSetting;
        private System.Windows.Forms.Button btnAddUserNamePassword;
        private System.Windows.Forms.TextBox txtBoxPassword;
        private System.Windows.Forms.Label lblUserPassword;
        private System.Windows.Forms.TextBox txtBoxUserName;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblSearchUser;
        private System.Windows.Forms.DataGridView dataGridViewUser;
        private System.Windows.Forms.TextBox textBoxSearchRoom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPageUpdateAndDeleteUser;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtBoxPassword1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxUserName1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}
