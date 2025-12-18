namespace HotelReservationAndManagementSystem.User_Control
{
    partial class UserControlClient
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
            this.tabControlClient = new System.Windows.Forms.TabControl();
            this.tabPageAddClient = new System.Windows.Forms.TabPage();
            this.txtBoxAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.btnAddClient = new System.Windows.Forms.Button();
            this.txtBoxLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtBoxFirstName = new System.Windows.Forms.TextBox();
            this.lblClientName = new System.Windows.Forms.Label();
            this.labelAddClient = new System.Windows.Forms.Label();
            this.tabPageSearchClient = new System.Windows.Forms.TabPage();
            this.dataGridViewClient = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Client_Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBoxSearchPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblSearchClient = new System.Windows.Forms.Label();
            this.tabPageClientDeleteUpdate = new System.Windows.Forms.TabPage();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtBoxAddress1 = new System.Windows.Forms.TextBox();
            this.lblAddress1 = new System.Windows.Forms.Label();
            this.txtBoxPhone1 = new System.Windows.Forms.TextBox();
            this.lblPhone1 = new System.Windows.Forms.Label();
            this.txtBoxLastName1 = new System.Windows.Forms.TextBox();
            this.lblLastName1 = new System.Windows.Forms.Label();
            this.txtBoxFirstName1 = new System.Windows.Forms.TextBox();
            this.lblFirstName1 = new System.Windows.Forms.Label();
            this.lblUpdateClient = new System.Windows.Forms.Label();
            this.tabControlClient.SuspendLayout();
            this.tabPageAddClient.SuspendLayout();
            this.tabPageSearchClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClient)).BeginInit();
            this.tabPageClientDeleteUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlClient
            // 
            this.tabControlClient.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControlClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabControlClient.Controls.Add(this.tabPageAddClient);
            this.tabControlClient.Controls.Add(this.tabPageSearchClient);
            this.tabControlClient.Controls.Add(this.tabPageClientDeleteUpdate);
            this.tabControlClient.Location = new System.Drawing.Point(37, 21);
            this.tabControlClient.Name = "tabControlClient";
            this.tabControlClient.SelectedIndex = 0;
            this.tabControlClient.Size = new System.Drawing.Size(1031, 417);
            this.tabControlClient.TabIndex = 0;
            this.tabControlClient.SelectedIndexChanged += new System.EventHandler(this.tabControlClient_SelectedIndexChanged);
            // 
            // tabPageAddClient
            // 
            this.tabPageAddClient.Controls.Add(this.txtBoxAddress);
            this.tabPageAddClient.Controls.Add(this.lblAddress);
            this.tabPageAddClient.Controls.Add(this.txtBoxPhoneNumber);
            this.tabPageAddClient.Controls.Add(this.lblPhoneNumber);
            this.tabPageAddClient.Controls.Add(this.btnAddClient);
            this.tabPageAddClient.Controls.Add(this.txtBoxLastName);
            this.tabPageAddClient.Controls.Add(this.lblLastName);
            this.tabPageAddClient.Controls.Add(this.txtBoxFirstName);
            this.tabPageAddClient.Controls.Add(this.lblClientName);
            this.tabPageAddClient.Controls.Add(this.labelAddClient);
            this.tabPageAddClient.Location = new System.Drawing.Point(4, 4);
            this.tabPageAddClient.Name = "tabPageAddClient";
            this.tabPageAddClient.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAddClient.Size = new System.Drawing.Size(1023, 381);
            this.tabPageAddClient.TabIndex = 0;
            this.tabPageAddClient.Text = "Add Client";
            this.tabPageAddClient.UseVisualStyleBackColor = true;
            this.tabPageAddClient.Click += new System.EventHandler(this.tabPageAddClient_Click);
            this.tabPageAddClient.Leave += new System.EventHandler(this.tabPageAddClient_Leave);
            // 
            // txtBoxAddress
            // 
            this.txtBoxAddress.Location = new System.Drawing.Point(160, 206);
            this.txtBoxAddress.Multiline = true;
            this.txtBoxAddress.Name = "txtBoxAddress";
            this.txtBoxAddress.Size = new System.Drawing.Size(714, 88);
            this.txtBoxAddress.TabIndex = 15;
            this.txtBoxAddress.TextChanged += new System.EventHandler(this.txtBoxAddress_TextChanged);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(156, 183);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(93, 23);
            this.lblAddress.TabIndex = 14;
            this.lblAddress.Text = "Address:";
            this.lblAddress.Click += new System.EventHandler(this.lblAddress_Click);
            // 
            // txtBoxPhoneNumber
            // 
            this.txtBoxPhoneNumber.Location = new System.Drawing.Point(160, 137);
            this.txtBoxPhoneNumber.Name = "txtBoxPhoneNumber";
            this.txtBoxPhoneNumber.Size = new System.Drawing.Size(254, 32);
            this.txtBoxPhoneNumber.TabIndex = 13;
            this.txtBoxPhoneNumber.TextChanged += new System.EventHandler(this.txtBoxPhoneNumber_TextChanged);
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(156, 114);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(97, 23);
            this.lblPhoneNumber.TabIndex = 12;
            this.lblPhoneNumber.Text = "Phone #:";
            this.lblPhoneNumber.Click += new System.EventHandler(this.lblPhoneNumber_Click);
            // 
            // btnAddClient
            // 
            this.btnAddClient.BackColor = System.Drawing.Color.Brown;
            this.btnAddClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddClient.ForeColor = System.Drawing.Color.White;
            this.btnAddClient.Location = new System.Drawing.Point(160, 300);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(144, 52);
            this.btnAddClient.TabIndex = 11;
            this.btnAddClient.Text = "Add";
            this.btnAddClient.UseVisualStyleBackColor = false;
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // txtBoxLastName
            // 
            this.txtBoxLastName.Location = new System.Drawing.Point(591, 68);
            this.txtBoxLastName.Name = "txtBoxLastName";
            this.txtBoxLastName.Size = new System.Drawing.Size(254, 32);
            this.txtBoxLastName.TabIndex = 10;
            this.txtBoxLastName.TextChanged += new System.EventHandler(this.txtBoxLastName_TextChanged_1);
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(587, 45);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(120, 23);
            this.lblLastName.TabIndex = 9;
            this.lblLastName.Text = "Last Name:";
            this.lblLastName.Click += new System.EventHandler(this.lblLastName_Click);
            // 
            // txtBoxFirstName
            // 
            this.txtBoxFirstName.Location = new System.Drawing.Point(160, 68);
            this.txtBoxFirstName.Name = "txtBoxFirstName";
            this.txtBoxFirstName.Size = new System.Drawing.Size(254, 32);
            this.txtBoxFirstName.TabIndex = 8;
            this.txtBoxFirstName.TextChanged += new System.EventHandler(this.txtBoxFirstName_TextChanged);
            // 
            // lblClientName
            // 
            this.lblClientName.AutoSize = true;
            this.lblClientName.Location = new System.Drawing.Point(156, 45);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(116, 23);
            this.lblClientName.TabIndex = 7;
            this.lblClientName.Text = "First Name:";
            this.lblClientName.Click += new System.EventHandler(this.lblUserName_Click);
            // 
            // labelAddClient
            // 
            this.labelAddClient.AutoSize = true;
            this.labelAddClient.ForeColor = System.Drawing.Color.Brown;
            this.labelAddClient.Location = new System.Drawing.Point(12, 12);
            this.labelAddClient.Name = "labelAddClient";
            this.labelAddClient.Size = new System.Drawing.Size(120, 23);
            this.labelAddClient.TabIndex = 6;
            this.labelAddClient.Text = "Add Client:";
            this.labelAddClient.Click += new System.EventHandler(this.labelAddClient_Click);
            // 
            // tabPageSearchClient
            // 
            this.tabPageSearchClient.Controls.Add(this.dataGridViewClient);
            this.tabPageSearchClient.Controls.Add(this.txtBoxSearchPhone);
            this.tabPageSearchClient.Controls.Add(this.lblPhone);
            this.tabPageSearchClient.Controls.Add(this.lblSearchClient);
            this.tabPageSearchClient.Location = new System.Drawing.Point(4, 4);
            this.tabPageSearchClient.Name = "tabPageSearchClient";
            this.tabPageSearchClient.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSearchClient.Size = new System.Drawing.Size(1023, 381);
            this.tabPageSearchClient.TabIndex = 1;
            this.tabPageSearchClient.Text = "SearchClient";
            this.tabPageSearchClient.UseVisualStyleBackColor = true;
            this.tabPageSearchClient.Click += new System.EventHandler(this.tabPageSearchClient_Click);
            this.tabPageSearchClient.Enter += new System.EventHandler(this.tabPageSearchClient_Enter);
            this.tabPageSearchClient.Leave += new System.EventHandler(this.tabPageSearchClient_Leave);
            // 
            // dataGridViewClient
            // 
            this.dataGridViewClient.AllowUserToAddRows = false;
            this.dataGridViewClient.AllowUserToDeleteRows = false;
            this.dataGridViewClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewClient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Client_Address});
            this.dataGridViewClient.Location = new System.Drawing.Point(39, 117);
            this.dataGridViewClient.Name = "dataGridViewClient";
            this.dataGridViewClient.ReadOnly = true;
            this.dataGridViewClient.RowHeadersWidth = 62;
            this.dataGridViewClient.RowTemplate.Height = 28;
            this.dataGridViewClient.Size = new System.Drawing.Size(944, 248);
            this.dataGridViewClient.TabIndex = 9;
            this.dataGridViewClient.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewClient_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Client_ID";
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Client_FirstName";
            this.Column2.HeaderText = "First Name";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Client_lastName";
            this.Column3.HeaderText = "Last Name";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Client_PhoneNo";
            this.Column4.HeaderText = "Phone no.";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Client_Address
            // 
            this.Client_Address.HeaderText = "Address";
            this.Client_Address.MinimumWidth = 8;
            this.Client_Address.Name = "Client_Address";
            this.Client_Address.ReadOnly = true;
            // 
            // txtBoxSearchPhone
            // 
            this.txtBoxSearchPhone.Location = new System.Drawing.Point(137, 68);
            this.txtBoxSearchPhone.Name = "txtBoxSearchPhone";
            this.txtBoxSearchPhone.Size = new System.Drawing.Size(254, 32);
            this.txtBoxSearchPhone.TabIndex = 8;
            this.txtBoxSearchPhone.TextChanged += new System.EventHandler(this.txtBoxSearchPhone_TextChanged);
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(133, 45);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(111, 23);
            this.lblPhone.TabIndex = 7;
            this.lblPhone.Text = "Phone No.";
            // 
            // lblSearchClient
            // 
            this.lblSearchClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSearchClient.AutoSize = true;
            this.lblSearchClient.ForeColor = System.Drawing.Color.Brown;
            this.lblSearchClient.Location = new System.Drawing.Point(39, 15);
            this.lblSearchClient.Name = "lblSearchClient";
            this.lblSearchClient.Size = new System.Drawing.Size(145, 23);
            this.lblSearchClient.TabIndex = 6;
            this.lblSearchClient.Text = "Search Client:";
            // 
            // tabPageClientDeleteUpdate
            // 
            this.tabPageClientDeleteUpdate.Controls.Add(this.btnDelete);
            this.tabPageClientDeleteUpdate.Controls.Add(this.btnUpdate);
            this.tabPageClientDeleteUpdate.Controls.Add(this.txtBoxAddress1);
            this.tabPageClientDeleteUpdate.Controls.Add(this.lblAddress1);
            this.tabPageClientDeleteUpdate.Controls.Add(this.txtBoxPhone1);
            this.tabPageClientDeleteUpdate.Controls.Add(this.lblPhone1);
            this.tabPageClientDeleteUpdate.Controls.Add(this.txtBoxLastName1);
            this.tabPageClientDeleteUpdate.Controls.Add(this.lblLastName1);
            this.tabPageClientDeleteUpdate.Controls.Add(this.txtBoxFirstName1);
            this.tabPageClientDeleteUpdate.Controls.Add(this.lblFirstName1);
            this.tabPageClientDeleteUpdate.Controls.Add(this.lblUpdateClient);
            this.tabPageClientDeleteUpdate.Location = new System.Drawing.Point(4, 4);
            this.tabPageClientDeleteUpdate.Name = "tabPageClientDeleteUpdate";
            this.tabPageClientDeleteUpdate.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageClientDeleteUpdate.Size = new System.Drawing.Size(1023, 381);
            this.tabPageClientDeleteUpdate.TabIndex = 2;
            this.tabPageClientDeleteUpdate.Text = "Update and Delete Client:";
            this.tabPageClientDeleteUpdate.UseVisualStyleBackColor = true;
            this.tabPageClientDeleteUpdate.Leave += new System.EventHandler(this.tabPageClientDeleteUpdate_Leave);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Brown;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(310, 308);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(144, 52);
            this.btnDelete.TabIndex = 26;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            this.btnDelete.Leave += new System.EventHandler(this.btnDelete_Leave);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.Location = new System.Drawing.Point(160, 308);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(144, 52);
            this.btnUpdate.TabIndex = 25;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtBoxAddress1
            // 
            this.txtBoxAddress1.Location = new System.Drawing.Point(161, 204);
            this.txtBoxAddress1.Multiline = true;
            this.txtBoxAddress1.Name = "txtBoxAddress1";
            this.txtBoxAddress1.Size = new System.Drawing.Size(714, 88);
            this.txtBoxAddress1.TabIndex = 24;
            // 
            // lblAddress1
            // 
            this.lblAddress1.AutoSize = true;
            this.lblAddress1.Location = new System.Drawing.Point(157, 181);
            this.lblAddress1.Name = "lblAddress1";
            this.lblAddress1.Size = new System.Drawing.Size(93, 23);
            this.lblAddress1.TabIndex = 23;
            this.lblAddress1.Text = "Address:";
            // 
            // txtBoxPhone1
            // 
            this.txtBoxPhone1.Location = new System.Drawing.Point(161, 135);
            this.txtBoxPhone1.Name = "txtBoxPhone1";
            this.txtBoxPhone1.Size = new System.Drawing.Size(254, 32);
            this.txtBoxPhone1.TabIndex = 22;
            // 
            // lblPhone1
            // 
            this.lblPhone1.AutoSize = true;
            this.lblPhone1.Location = new System.Drawing.Point(157, 112);
            this.lblPhone1.Name = "lblPhone1";
            this.lblPhone1.Size = new System.Drawing.Size(97, 23);
            this.lblPhone1.TabIndex = 21;
            this.lblPhone1.Text = "Phone #:";
            // 
            // txtBoxLastName1
            // 
            this.txtBoxLastName1.Location = new System.Drawing.Point(592, 66);
            this.txtBoxLastName1.Name = "txtBoxLastName1";
            this.txtBoxLastName1.Size = new System.Drawing.Size(254, 32);
            this.txtBoxLastName1.TabIndex = 20;
            // 
            // lblLastName1
            // 
            this.lblLastName1.AutoSize = true;
            this.lblLastName1.Location = new System.Drawing.Point(588, 43);
            this.lblLastName1.Name = "lblLastName1";
            this.lblLastName1.Size = new System.Drawing.Size(120, 23);
            this.lblLastName1.TabIndex = 19;
            this.lblLastName1.Text = "Last Name:";
            // 
            // txtBoxFirstName1
            // 
            this.txtBoxFirstName1.Location = new System.Drawing.Point(161, 66);
            this.txtBoxFirstName1.Name = "txtBoxFirstName1";
            this.txtBoxFirstName1.Size = new System.Drawing.Size(254, 32);
            this.txtBoxFirstName1.TabIndex = 18;
            // 
            // lblFirstName1
            // 
            this.lblFirstName1.AutoSize = true;
            this.lblFirstName1.Location = new System.Drawing.Point(157, 43);
            this.lblFirstName1.Name = "lblFirstName1";
            this.lblFirstName1.Size = new System.Drawing.Size(116, 23);
            this.lblFirstName1.TabIndex = 17;
            this.lblFirstName1.Text = "First Name:";
            // 
            // lblUpdateClient
            // 
            this.lblUpdateClient.AutoSize = true;
            this.lblUpdateClient.ForeColor = System.Drawing.Color.Brown;
            this.lblUpdateClient.Location = new System.Drawing.Point(13, 10);
            this.lblUpdateClient.Name = "lblUpdateClient";
            this.lblUpdateClient.Size = new System.Drawing.Size(265, 23);
            this.lblUpdateClient.TabIndex = 16;
            this.lblUpdateClient.Text = "Update and Delete Client";
            // 
            // UserControlClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tabControlClient);
            this.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "UserControlClient";
            this.Size = new System.Drawing.Size(1102, 462);
            this.tabControlClient.ResumeLayout(false);
            this.tabPageAddClient.ResumeLayout(false);
            this.tabPageAddClient.PerformLayout();
            this.tabPageSearchClient.ResumeLayout(false);
            this.tabPageSearchClient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClient)).EndInit();
            this.tabPageClientDeleteUpdate.ResumeLayout(false);
            this.tabPageClientDeleteUpdate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlClient;
        private System.Windows.Forms.TabPage tabPageAddClient;
        private System.Windows.Forms.TabPage tabPageSearchClient;
        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.TextBox txtBoxLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtBoxFirstName;
        private System.Windows.Forms.Label lblClientName;
        private System.Windows.Forms.Label labelAddClient;
        private System.Windows.Forms.TextBox txtBoxAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtBoxPhoneNumber;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.TabPage tabPageClientDeleteUpdate;
        private System.Windows.Forms.DataGridView dataGridViewClient;
        private System.Windows.Forms.TextBox txtBoxSearchPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblSearchClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Client_Address;
        private System.Windows.Forms.TextBox txtBoxAddress1;
        private System.Windows.Forms.Label lblAddress1;
        private System.Windows.Forms.TextBox txtBoxPhone1;
        private System.Windows.Forms.Label lblPhone1;
        private System.Windows.Forms.TextBox txtBoxLastName1;
        private System.Windows.Forms.Label lblLastName1;
        private System.Windows.Forms.TextBox txtBoxFirstName1;
        private System.Windows.Forms.Label lblFirstName1;
        private System.Windows.Forms.Label lblUpdateClient;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
    }
}
