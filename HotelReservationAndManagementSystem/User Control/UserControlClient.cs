using HotelReservationAndManagementSystem.Models;
using HotelReservationAndManagementSystem.Models.Users;
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
using HotelReservationAndManagementSystem.Models.Client;

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
            ID = ""
            ;
        }

        private void tabPageAddClient_Click(object sender, EventArgs e)
        {

        }

      

        private void txtBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxUserName_TextChanged(object sender, EventArgs e)
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
            db.DisplayAndSearch(
    "SELECT * FROM Client_Table WHERE Client_Phone LIKE '%" + txtBoxSearchPhone.Text + "%'",
    dataGridViewClient
);
        }

        private void tabControlClient_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            bool check;

            if (txtBoxFirstName.Text.Trim() == string.Empty ||
                txtBoxLastName.Text.Trim() == string.Empty ||
                txtBoxPhoneNumber.Text.Trim() == string.Empty ||
                txtBoxAddress.Text.Trim() == string.Empty)
            {
                MessageBox.Show(
                    "Please fill out all fields.",
                    "Required all fields.",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                return;
            }

            // 1️⃣ Create Client model
            Client client = new Client
            {
                FirstName = txtBoxFirstName.Text.Trim(),
                LastName = txtBoxLastName.Text.Trim(),
                Phone = txtBoxPhoneNumber.Text.Trim(),
                Address = txtBoxAddress.Text.Trim()
            };

            // 2️⃣ Call existing DAL (unchanged)
            check = db.AddClient(
                client.FirstName,
                client.LastName,
                client.Phone,
                client.Address
            );

            // 3️⃣ Clear UI
            if (check)
            {
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
            db.DisplayAndSearch("SELECT * FROM Client_Table",dataGridViewClient);
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

            if (ID == "")
            {
                MessageBox.Show(
                    "Please first select row from table.",
                    "Selection Required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                return;
            }

            if (txtBoxFirstName1.Text.Trim() == string.Empty ||
                txtBoxLastName1.Text.Trim() == string.Empty ||
                txtBoxPhone1.Text.Trim() == string.Empty ||
                txtBoxAddress1.Text.Trim() == string.Empty)
            {
                MessageBox.Show(
                    "Please fill out all fields.",
                    "Required all fields.",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                return;
            }

            //  Create Client model
            Client client = new Client
            {
                ClientID = int.Parse(ID),
                FirstName = txtBoxFirstName1.Text.Trim(),
                LastName = txtBoxLastName1.Text.Trim(),
                Phone = txtBoxPhone1.Text.Trim(),
                Address = txtBoxAddress1.Text.Trim()
            };

            //  Call DAL (UNCHANGED)
            check = db.UpdateClient(
                client.ClientID.ToString(),
                client.FirstName,
                client.LastName,
                client.Phone,
                client.Address
            );

            //  Clear UI
            if (check)
            {
                Clear1();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            bool check;

            if (ID == "")
            {
                MessageBox.Show(
                    "Please first select row from table.",
                    "Selection Required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                return;
            }

            if (txtBoxFirstName1.Text.Trim() == string.Empty ||
                txtBoxLastName1.Text.Trim() == string.Empty ||
                txtBoxPhone1.Text.Trim() == string.Empty ||
                txtBoxAddress1.Text.Trim() == string.Empty)
            {
                MessageBox.Show(
                    "Please fill out all fields.",
                    "Required all fields.",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                return;
            }

            //  Create Client model
            Client client = new Client
            {
                ClientID = int.Parse(ID),
                FirstName = txtBoxFirstName1.Text.Trim(),
                LastName = txtBoxLastName1.Text.Trim(),
                Phone = txtBoxPhone1.Text.Trim(),
                Address = txtBoxAddress1.Text.Trim()
            };

            // Call DAL 
            check = db.UpdateClient(
                client.ClientID.ToString(),
                client.FirstName,
                client.LastName,
                client.Phone,
                client.Address
            );

            //  Clear UI
            if (check)
            {
                Clear1();
            }

        }

        private void tabPageClientDeleteUpdate_Leave(object sender, EventArgs e)
        {
            Clear1();
        }

        private void dataGridViewClient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewClient.Rows[e.RowIndex];

                ID = row.Cells[0].Value?.ToString();

                txtBoxFirstName1.Text = row.Cells[1].Value?.ToString();
                txtBoxLastName1.Text = row.Cells[2].Value?.ToString();
                txtBoxPhone1.Text = row.Cells[3].Value?.ToString();
                txtBoxAddress1.Text = row.Cells[4].Value?.ToString();
            }
        }

        private void tabPageClientDeleteUpdate_Enter(object sender, EventArgs e)
        {

        }
    }
}
