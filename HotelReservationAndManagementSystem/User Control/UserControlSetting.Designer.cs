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
            this.textBoxSearchUserName = new System.Windows.Forms.TextBox();
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
            this.tabControlUser.Location = new System.Drawing.Point(26, 29);
            this.tabControlUser.Name = "tabControlUser";
            this.tabControlUser.SelectedIndex = 0;
            this.tabControlUser.Size = new System.Drawing.Size(1041, 392);
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
            this.tabPageAddUser.Name = "tabPageAddUser";
            this.tabPageAddUser.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAddUser.Size = new System.Drawing.Size(1033, 359);
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
            this.btnAddUserNamePassword.Location = new System.Drawing.Point(152, 166);
            this.btnAddUserNamePassword.Name = "btnAddUserNamePassword";
            this.btnAddUserNamePassword.Size = new System.Drawing.Size(144, 52);
            this.btnAddUserNamePassword.TabIndex = 5;
            this.btnAddUserNamePassword.Text = "Add";
            this.btnAddUserNamePassword.UseVisualStyleBackColor = false;
            this.btnAddUserNamePassword.Click += new System.EventHandler(this.btnAddUserNamePassword_Click);
            // 
            // txtBoxPassword
            // 
            this.txtBoxPassword.Location = new System.Drawing.Point(529, 133);
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.Size = new System.Drawing.Size(254, 26);
            this.txtBoxPassword.TabIndex = 4;
            this.txtBoxPassword.TextChanged += new System.EventHandler(this.txtBoxPassword_TextChanged);
            // 
            // lblUserPassword
            // 
            this.lblUserPassword.AutoSize = true;
            this.lblUserPassword.Location = new System.Drawing.Point(525, 110);
            this.lblUserPassword.Name = "lblUserPassword";
            this.lblUserPassword.Size = new System.Drawing.Size(120, 20);
            this.lblUserPassword.TabIndex = 3;
            this.lblUserPassword.Text = "User Password:";
            // 
            // txtBoxUserName
            // 
            this.txtBoxUserName.Location = new System.Drawing.Point(152, 133);
            this.txtBoxUserName.Name = "txtBoxUserName";
            this.txtBoxUserName.Size = new System.Drawing.Size(254, 26);
            this.txtBoxUserName.TabIndex = 2;
            this.txtBoxUserName.TextChanged += new System.EventHandler(this.txtBoxUserName_TextChanged);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(148, 110);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(93, 20);
            this.lblUserName.TabIndex = 1;
            this.lblUserName.Text = "User Name:";
            this.lblUserName.Click += new System.EventHandler(this.lblAddUsername_Click);
            // 
            // labelAddUserSetting
            // 
            this.labelAddUserSetting.AutoSize = true;
            this.labelAddUserSetting.ForeColor = System.Drawing.Color.Brown;
            this.labelAddUserSetting.Location = new System.Drawing.Point(4, 7);
            this.labelAddUserSetting.Name = "labelAddUserSetting";
            this.labelAddUserSetting.Size = new System.Drawing.Size(80, 20);
            this.labelAddUserSetting.TabIndex = 0;
            this.labelAddUserSetting.Text = "Add User:";
            // 
            // tabPageSearchUSer
            // 
            this.tabPageSearchUSer.Controls.Add(this.dataGridViewUser);
            this.tabPageSearchUSer.Controls.Add(this.textBoxSearchUserName);
            this.tabPageSearchUSer.Controls.Add(this.label1);
            this.tabPageSearchUSer.Controls.Add(this.lblSearchUser);
            this.tabPageSearchUSer.Location = new System.Drawing.Point(4, 4);
            this.tabPageSearchUSer.Name = "tabPageSearchUSer";
            this.tabPageSearchUSer.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSearchUSer.Size = new System.Drawing.Size(1033, 359);
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
            this.dataGridViewUser.Location = new System.Drawing.Point(6, 105);
            this.dataGridViewUser.Name = "dataGridViewUser";
            this.dataGridViewUser.ReadOnly = true;
            this.dataGridViewUser.RowHeadersWidth = 62;
            this.dataGridViewUser.RowTemplate.Height = 28;
            this.dataGridViewUser.Size = new System.Drawing.Size(824, 248);
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
            // textBoxSearchUserName
            // 
            this.textBoxSearchUserName.Location = new System.Drawing.Point(104, 56);
            this.textBoxSearchUserName.Name = "textBoxSearchUserName";
            this.textBoxSearchUserName.Size = new System.Drawing.Size(254, 26);
            this.textBoxSearchUserName.TabIndex = 4;
            this.textBoxSearchUserName.TextChanged += new System.EventHandler(this.textBoxSearchUserName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "User Name:";
            // 
            // lblSearchUser
            // 
            this.lblSearchUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSearchUser.AutoSize = true;
            this.lblSearchUser.ForeColor = System.Drawing.Color.Brown;
            this.lblSearchUser.Location = new System.Drawing.Point(6, 3);
            this.lblSearchUser.Name = "lblSearchUser";
            this.lblSearchUser.Size = new System.Drawing.Size(102, 20);
            this.lblSearchUser.TabIndex = 0;
            this.lblSearchUser.Text = "Search User:";
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
            this.tabPageUpdateAndDeleteUser.Name = "tabPageUpdateAndDeleteUser";
            this.tabPageUpdateAndDeleteUser.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUpdateAndDeleteUser.Size = new System.Drawing.Size(1033, 359);
            this.tabPageUpdateAndDeleteUser.TabIndex = 2;
            this.tabPageUpdateAndDeleteUser.Text = "Update and Delete User";
            this.tabPageUpdateAndDeleteUser.UseVisualStyleBackColor = true;
            this.tabPageUpdateAndDeleteUser.Leave += new System.EventHandler(this.tabPageUpdateAndDeleteUser_Leave);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Brown;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(313, 175);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(144, 52);
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
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.Location = new System.Drawing.Point(163, 175);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(144, 52);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtBoxPassword1
            // 
            this.txtBoxPassword1.Location = new System.Drawing.Point(548, 142);
            this.txtBoxPassword1.Name = "txtBoxPassword1";
            this.txtBoxPassword1.Size = new System.Drawing.Size(289, 26);
            this.txtBoxPassword1.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(544, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "User Password:";
            // 
            // txtBoxUserName1
            // 
            this.txtBoxUserName1.Location = new System.Drawing.Point(163, 142);
            this.txtBoxUserName1.Name = "txtBoxUserName1";
            this.txtBoxUserName1.Size = new System.Drawing.Size(294, 26);
            this.txtBoxUserName1.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(159, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "User Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Brown;
            this.label4.Location = new System.Drawing.Point(15, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Update and Delete User:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // UserControlSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControlUser);
            this.Name = "UserControlSetting";
            this.Size = new System.Drawing.Size(1102, 462);
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
        private System.Windows.Forms.TextBox textBoxSearchUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.TabPage tabPageUpdateAndDeleteUser;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtBoxPassword1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxUserName1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDelete;
    }
}
