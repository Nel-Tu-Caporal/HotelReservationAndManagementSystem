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
    public partial class UserControlRoom : UserControl
    {

        DBConnector1 db;

        private string No = "", Free = "";

        public UserControlRoom()
        {
            InitializeComponent();
            db = new DBConnector1();
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

            if (radioButtonYes.Checked)
                Free = "Yes";
            if (radioButtonNo.Checked)
                Free = "No";
            bool check;
            if (comboBoxType.SelectedIndex == 0 || txtBoxPhoneNo.Text.Trim() == string.Empty || Free== "")

                MessageBox.Show("Please fill out all fields.", "Required all fields.", MessageBoxButtons.OK, MessageBoxIcon.Information);

            else
            {
                check = db.AddRoom(comboBoxType.SelectedItem.ToString(), txtBoxPhoneNo.Text.Trim(),Free);
                if (check)
                    Clear();
                tabControlRoom.SelectedTab = tabPageAddRoom;

            }
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
            db.DisplayAndSearch("SELECT * FROM Room_Table WHERE Room_Number LIKE '%" + txtBoxSearchRoomNo.Text + "%'", dataGridViewRoom);
        
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
            
            db.DisplayAndSearch("SELECT * FROM Room_Table", dataGridViewRoom);
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

            if (radioButtonYes1.Checked)
                Free = "Yes";
            if (radioButtonNo1.Checked)
                Free = "No";

            bool check;
            if (No != "")
            {
                if (comboBoxType1.SelectedIndex == 0 || txtBoxPhoneNo1.Text.Trim() == string.Empty || Free == "")

                    MessageBox.Show("Please fill out all fields.", "Required all fields.", MessageBoxButtons.OK, MessageBoxIcon.Information);
           
                else
                {
                    check = db.UpdateRoom(No, comboBoxType1.SelectedItem.ToString(), txtBoxPhoneNo1.Text.Trim(),Free);
                    if (check)
                        Clear1();
                }
            }   
            else
                MessageBox.Show("Please first select row from table.", "Selection of row.", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (radioButtonYes1.Checked)
                Free = "Yes";
            if (radioButtonNo1.Checked)
                Free = "No";

            bool check;
            if (No != "")
            {
                if (comboBoxType1.SelectedIndex == 0 || txtBoxPhoneNo1.Text.Trim() == string.Empty || Free == "")

                    MessageBox.Show("Please fill out all fields.", "Required all fields.", MessageBoxButtons.OK, MessageBoxIcon.Information);

                else
                {

                    DialogResult result = MessageBox.Show("Are you want to delete this Room?", "Room delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (DialogResult.Yes == result)
                    {
                        check = db.DeleteRoom(No);
                        if (check)
                            Clear1();

                    }
                }

            }
            else
                MessageBox.Show("Please first select row from table.", "Selection of row.", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
