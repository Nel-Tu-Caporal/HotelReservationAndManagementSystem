using HotelReservationAndManagementSystem.References;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelReservationAndManagementSystem.User_Control
{

    
    public partial class UserControlSetting : UserControl
    {
        DBConnector1 db;
        private string ID = "";
        public UserControlSetting()
        {
            InitializeComponent();

            db = new DBConnector1();    

        }
        public void Clear()
        {
            txtBoxUserName.Clear();
            txtBoxPassword.Clear();
            tabControlUser.SelectedTab = tabPageAddUser;
        }
        public void Clear1()
        {
            txtBoxUserName1.Clear();
            txtBoxPassword1.Clear();
            ID = "";
        }

        private void lblAddUsername_Click(object sender, EventArgs e)
        {

        }

        private void txtBoxUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBoxSearchUserName_TextChanged(object sender, EventArgs e)
        {
            db.DisplayAndSearch("SELECT * FROM User_Table WHERE User_Name LIKE '%" + textBoxSearchUserName.Text + "%'", dataGridViewUser);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            bool check;
            if (ID != "")
            {
                if (txtBoxUserName1.Text.Trim() == string.Empty || txtBoxPassword1.Text.Trim() == string.Empty)

                    MessageBox.Show("Please fill out all fields.", "Required all fields.", MessageBoxButtons.OK, MessageBoxIcon.Information);

                else
                {
                    check = db.UpdateUser(ID, txtBoxUserName1.Text.Trim(), txtBoxPassword1.Text.Trim());
                    if (check)
                        Clear1();
                }
            }
            else
                MessageBox.Show("Please first select row from table.", "Selection of row.", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            bool check;
            if (ID != "")
            {
                if (txtBoxUserName1.Text.Trim() == string.Empty || txtBoxPassword1.Text.Trim() == string.Empty)

                    MessageBox.Show("Please fill out all fields.", "Required all fields.", MessageBoxButtons.OK, MessageBoxIcon.Information);

                else
                {
                    DialogResult result = MessageBox.Show("Are you want to delete this user?", "User delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (DialogResult.Yes == result)
                    {
                        check = db.DeleteUser(ID);
                        if (check)
                            Clear1();

                    }
                }
              
            }
            else
                MessageBox.Show("Please first select row from table.", "Selection of row.", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tabPageAddUser_Click(object sender, EventArgs e)
        {

        }

        private void tabPageAddUser_Leave(object sender, EventArgs e)
        {
            Clear();
            Clear1();
        }

        private void tabPageSearchUSer_Enter(object sender, EventArgs e)
        {
            db.DisplayAndSearch("SELECT * FROM User_Table", dataGridViewUser);
        }

        private void tabPageSearchUSer_Leave(object sender, EventArgs e)
        {
            textBoxSearchUserName.Clear();
        }

        private void tabPageUpdateAndDeleteUser_Leave(object sender, EventArgs e)
        {
            Clear1();
        }

        private void btnAddUserNamePassword_Click(object sender, EventArgs e)
        {
            bool check;
            if(txtBoxUserName.Text.Trim() == string.Empty || txtBoxPassword.Text.Trim() == string.Empty)
            
                MessageBox.Show("Please fill out all fields.", "Required all fields.", MessageBoxButtons.OK,MessageBoxIcon.Information);

            else
            {
                check = db.AddUser(txtBoxUserName.Text.Trim(), txtBoxPassword.Text.Trim());
                if(check)
                Clear();

                
            }
        }

        private void dataGridViewUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != - 1)
            {
               DataGridViewRow row = dataGridViewUser.Rows[e.RowIndex]; 
                ID = row.Cells[0].Value.ToString();
                txtBoxUserName1.Text = row.Cells[1].Value.ToString();
                txtBoxPassword1.Text = row.Cells[2].Value.ToString(); 
            }
        }

        private void tabControlUser_Leave(object sender, EventArgs e)
        {

        }
    }
}
