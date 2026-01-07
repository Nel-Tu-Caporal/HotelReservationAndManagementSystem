using HotelReservationAndManagementSystem.Interface.Service;
using HotelReservationAndManagementSystem.Models.Services;
using HotelReservationAndManagementSystem.References;
using HotelReservationAndManagementSystem.Repo;
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
    public partial class UserControlRoom : UserControl
    {

        private readonly IRoomService _roomService;

        private string No = "", Free = "";

        public UserControlRoom()
        {
            InitializeComponent();

            
            var db = new DBConnector1();
            var repo = new RoomRepository(db);
            _roomService = new RoomService(repo);
        }
        public void Clear()
        {
            comboBoxType.SelectedIndex = 0;
            txtBoxPhoneNo.Clear();
            radioButtonYes.Checked = false;
            radioButtonNo.Checked = false;
            

        }
        private void Clear1()
        {
            comboBoxType1.SelectedIndex = 0;
            txtBoxPhoneNo1.Clear();
            radioButtonYes1.Checked = false;
            radioButtonNo1.Checked = false;
            
            No = "";
        }

       

        private void tabPageRoom_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tabControlRoom_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {

            Free = radioButtonYes.Checked ? "Yes" :
            radioButtonNo.Checked ? "No" : "";

            if (comboBoxType.SelectedIndex == 0 || txtBoxPhoneNo.Text == "" || Free == "")
            {
                MessageBox.Show("Please fill out all fields.");
                return;
            }

            bool success = _roomService.AddRoom(
                comboBoxType.SelectedItem.ToString(),
                txtBoxPhoneNo.Text.Trim()
            );

            if (success)
                Clear();
        }
        

        private void radioButtonYes_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lblFree_Click(object sender, EventArgs e)
        {

        }

        private void lblUserName_Click(object sender, EventArgs e)
        {

        }

        private void lblRoomNo_Click(object sender, EventArgs e)
        {

        }

        private void txtBoxRoomNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblAddRoom_Click(object sender, EventArgs e)
        {

        }

        private void radioButtonNo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxSearchRoom_TextChanged(object sender, EventArgs e)
        {
            _roomService.LoadRooms(dataGridViewRoom);

        }

        private void txtBoxPhoneNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxPhoneNo1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddRoom_Click_1(object sender, EventArgs e)
        {

        }

        private void tabPageAddRoom_Leave(object sender, EventArgs e)
        {
            Clear();
            
        }

        private void tabPageSearchRoom_Enter(object sender, EventArgs e)
        {

            _roomService.LoadRooms(dataGridViewRoom);
        }

        private void dataGridViewRoom_Leave(object sender, EventArgs e)
        {
            txtBoxSearchRoomNo.Clear();
        }

        private void dataGridViewRoom_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if(e.RowIndex != -1)
            {
                DataGridViewRow  row = dataGridViewRoom.Rows[e.RowIndex];
                No = row.Cells[0].Value.ToString();
                comboBoxType1.SelectedItem = row.Cells[1].Value.ToString(); 
                txtBoxPhoneNo1.Text = row.Cells[2].Value.ToString();
                Free = row.Cells[3].Value.ToString();
                if(Free == "Yes")
                    radioButtonYes1.Checked = true;
                if (Free == "No")
                    radioButtonNo1.Checked = true;

            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            Free = radioButtonYes1.Checked ? "Yes" :
           radioButtonNo1.Checked ? "No" : "";

            if (No == "")
            {
                MessageBox.Show("Please select a room first.");
                return;
            }

            bool success = _roomService.UpdateRoom(
                No,
                comboBoxType1.SelectedItem.ToString(),
                txtBoxPhoneNo1.Text.Trim()
            );

            if (success)
                Clear1();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (No == "")
            {
                MessageBox.Show("Please select a room first.");
                return;
            }

            if (MessageBox.Show("Delete this room?", "Confirm",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (_roomService.DeleteRoom(No))
                    Clear1();
            }
        }

        private void dataGridViewRoom_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UserControlRoom_Load(object sender, EventArgs e)
        {
            comboBoxType.SelectedIndex = 0;
            comboBoxType1.SelectedIndex = 0;
        }

        private void tabPageUpdateDelete_Leave(object sender, EventArgs e)
        {
            Clear1();
        }

        private void comboBoxType_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void tabPageSearchRoom_Click(object sender, EventArgs e)
        {

        }
    }
}
