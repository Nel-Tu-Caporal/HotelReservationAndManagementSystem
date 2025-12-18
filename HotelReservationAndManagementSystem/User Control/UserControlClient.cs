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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace HotelReservationAndManagementSystem.User_Control
{
    public partial class UserControlClient : UserControl
    {

        DBConnector1 db;

        private string ID = "";

        public UserControlClient()
        {
            InitializeComponent();

            db = new DBConnector1();

        }


        public void Clear()
        {
            txtBoxFirstName.Clear();
            txtBoxLastName.Clear();
            txtBoxPhoneNumber.Clear();
            txtBoxAddress.Clear();
            tabControlClient.SelectedTab = tabPageAddClient;
        }
        private void Clear1()
        {
            txtBoxFirstName1.Clear();
            txtBoxLastName1.Clear();
            txtBoxPhone1.Clear();
            txtBoxAddress1.Clear();
            ID = "";
            
        }

        private void tabPageAddClient_Click(object sender, EventArgs e)
        {

        }

        private void btnAddUserNamePassword_Click(object sender, EventArgs e)
        {

        }

        private void txtBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblAddUsername_Click(object sender, EventArgs e)
        {

        }

        private void labelAddClient_Click(object sender, EventArgs e)
        {

        }

        private void lblUserName_Click(object sender, EventArgs e)
        {

        }

        private void txtBoxFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblLastName_Click(object sender, EventArgs e)
        {

        }

        private void txtBoxLastName_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void lblPhoneNumber_Click(object sender, EventArgs e)
        {

        }

        private void txtBoxPhoneNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblAddress_Click(object sender, EventArgs e)
        {

        }

        private void txtBoxAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPageSearchClient_Click(object sender, EventArgs e)
        {

        }

        private void txtBoxSearchPhone_TextChanged(object sender, EventArgs e)
        {
            db.DisplayAndSearch("SELECT * FROM User_Table WHERE Client_Phone LIKE '%" + txtBoxSearchPhone.Text + "%'", dataGridViewClient);
        }

        private void tabControlClient_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            bool check;
            if(txtBoxFirstName.Text.Trim() == string.Empty || txtBoxLastName.Text.Trim () == string.Empty || txtBoxPhoneNumber.Text.Trim() == String.Empty || txtBoxAddress.Text.Trim() == string.Empty)
           
                MessageBox.Show("Please fill out all fields.", "Required all fields.", MessageBoxButtons.OK, MessageBoxIcon.Information);

            else
            {
                check = db.AddClient(txtBoxFirstName.Text.Trim(), txtBoxLastName.Text.Trim(),txtBoxPhoneNumber.Text.Trim(),txtBoxAddress.Text.Trim());
                if (check)
                    Clear();


            }
        }

        private void btnDelete_Leave(object sender, EventArgs e)
        {

        }

        private void tabPageAddClient_Leave(object sender, EventArgs e)
        {
            Clear();
            Clear1();
        }

        private void tabPageSearchClient_Enter(object sender, EventArgs e)
        {
            db.DisplayAndSearch("SELECT * FROM User_Table", dataGridViewClient);
        }

        private void dataGridViewClient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPageSearchClient_Leave(object sender, EventArgs e)
        {
            txtBoxPhoneNumber.Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            bool check;
            if (ID != "")
            {
                if (txtBoxFirstName1.Text.Trim() == string.Empty || txtBoxLastName1.Text.Trim() == string.Empty || txtBoxPhone1.Text.Trim() == String.Empty || txtBoxAddress1.Text.Trim() == string.Empty)

                    MessageBox.Show("Please fill out all fields.", "Required all fields.", MessageBoxButtons.OK, MessageBoxIcon.Information);

                else
                {
                    check = db.UpdateClient(ID, txtBoxFirstName1.Text.Trim(), txtBoxLastName1.Text.Trim(), txtBoxPhone1.Text.Trim(), txtBoxAddress1.Text.Trim());
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
                if (txtBoxFirstName1.Text.Trim() == string.Empty || txtBoxLastName1.Text.Trim() == string.Empty)

                    MessageBox.Show("Please fill out all fields.", "Required all fields.", MessageBoxButtons.OK, MessageBoxIcon.Information);

                else
                {
                    DialogResult result = MessageBox.Show("Are you want to delete this client?", "Client delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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

        private void tabPageClientDeleteUpdate_Leave(object sender, EventArgs e)
        {
            Clear1();
        }
    }
}
