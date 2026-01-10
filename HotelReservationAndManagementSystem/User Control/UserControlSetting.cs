using HotelReservationAndManagementSystem.Interface;
using HotelReservationAndManagementSystem.Models;
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

namespace HotelReservationAndManagementSystem.User_Control
{


    public partial class UserControlSetting : UserControl
    {
        private string ID = "";
        private readonly IUserService _userService;

        // REQUIRED for WinForms Designer
        public UserControlSetting()
        {
            InitializeComponent();
        }

        // DI constructor (used at runtime)
        public UserControlSetting(IUserService userService)
        {
            InitializeComponent();
            _userService = userService;
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
            _userService.SearchUsers(textBoxSearchUserName.Text.Trim(),dataGridViewUser);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (ID == "")
            {
                MessageBox.Show("Select a user first.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtBoxUserName1.Text) ||
                string.IsNullOrWhiteSpace(txtBoxPassword1.Text))
            {
                MessageBox.Show("Please fill out all fields.");
                return;
            }

            SystemUser user = new SystemUser(
                txtBoxUserName1.Text.Trim(),
                txtBoxPassword1.Text.Trim()
            );

            if (_userService.UpdateUser(int.Parse(ID), user))
                Clear1();
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (ID == "")
            {
                MessageBox.Show("Select a user first.");
                return;
            }

            if (MessageBox.Show(
                "Are you sure?",
                "Delete User",
                MessageBoxButtons.YesNo
            ) != DialogResult.Yes)
                return;

            if (_userService.DeleteUser(int.Parse(ID)))
                Clear1();
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
            _userService.LoadUsers(dataGridViewUser);
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
            if (string.IsNullOrWhiteSpace(txtBoxUserName.Text) ||
                string.IsNullOrWhiteSpace(txtBoxPassword.Text))
            {
                MessageBox.Show("Please fill out all fields.");
                return;
            }

            SystemUser user = new SystemUser(
                txtBoxUserName.Text.Trim(),
                txtBoxPassword.Text.Trim()
            );

            if (_userService.AddUser(user))
                Clear();
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

        private void tabPageUpdateAndDeleteUser_Click(object sender, EventArgs e)
        {

        }

        private void tabPageSearchUSer_Click(object sender, EventArgs e)
        {

        }

        private void UserControlSetting_Load(object sender, EventArgs e)
        {

        }
    }
}
