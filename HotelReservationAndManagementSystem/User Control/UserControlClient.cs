        using HotelReservationAndManagementSystem.Models;
        using HotelReservationAndManagementSystem.Models.Client;
        using HotelReservationAndManagementSystem.Models.Services;
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
        using HotelReservationAndManagementSystem.Repo;




    namespace HotelReservationAndManagementSystem.User_Control
        {
            public partial class UserControlClient : UserControl
            {
            private string ID = "";
            private readonly ClientService _clientService;

            public UserControlClient()
            {
                InitializeComponent();

                _clientService = new ClientService(
                    new ClientRepository(
                        new DBConnector1()
                    )
                );
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
                    _clientService.SearchClients(txtBoxSearchPhone.Text, dataGridViewClient);
                }

                private void tabControlClient_SelectedIndexChanged(object sender, EventArgs e)
                {

                }

                private void btnAddClient_Click(object sender, EventArgs e)
                {
                    Client1 client = new Client1
                    {
                        FirstName = txtBoxFirstName.Text.Trim(),
                        LastName = txtBoxLastName.Text.Trim(),
                        Phone = txtBoxPhoneNumber.Text.Trim(),
                        Address = txtBoxAddress.Text.Trim()
                    };

                    bool check = _clientService.AddClient(client);

                    if (!check)
                    {
                        MessageBox.Show("Please fill out all fields.");
                        return;
                    }

                    Clear();
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
                    _clientService.LoadClients(dataGridViewClient);
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

                    if (string.IsNullOrEmpty(ID))
                    {
                        MessageBox.Show("Select a client first.");
                        return;
                    }

                    Client1 client = new Client1
                    {
                        FirstName = txtBoxFirstName1.Text.Trim(),
                        LastName = txtBoxLastName1.Text.Trim(),
                        Phone = txtBoxPhone1.Text.Trim(),
                        Address = txtBoxAddress1.Text.Trim()
                    };

                    bool check = _clientService.UpdateClient(ID, client);

                    if (!check)
                    {
                        MessageBox.Show("Invalid data.");
                        return;
                    }

                    Clear1();
                }

                private void btnDelete_Click(object sender, EventArgs e)
                {
                    if (string.IsNullOrEmpty(ID))
                    {
                        MessageBox.Show("Select a client first.");
                        return;
                    }

                    bool check = _clientService.DeleteClient(ID);

                    if (check)
                        Clear1();

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

            private void UserControlClient_Load(object sender, EventArgs e)
            {

            }
        }
        }
