using HotelReservationAndManagementSystem.References;
using Org.BouncyCastle.Cms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace HotelReservationAndManagementSystem.User_Control
{
    public partial class UserControlReservation : UserControl
    {

        DBConnector1 db;

        private string RID = "", No;
        public UserControlReservation()
        {
            InitializeComponent();

            db = new DBConnector1();
        }

        public void Clear()

        {
            comboBoxType.SelectedIndex = 0;
            comboBoxNo.SelectedIndex = 0;
            txtBoxClientID.Clear();
            dateTimePickerIn.Value = DateTime.Now;
            dateTimePickerOut.Value = DateTime.Now;
            tabControlReservation.SelectedTab = tabPageAddReservation;
        }
        private void Clear1()

        {
            comboBoxType1.SelectedIndex = 0;
            comboBoxNo1.SelectedIndex = 0;
            txtBoxClientID1.Clear();
            dateTimePickerIn1.Value = DateTime.Now;
            dateTimePickerOut1.Value = DateTime.Now;
            RID = "";
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPageAddReservation_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tabPageUpdateAndCancelReservation_Click(object sender, EventArgs e)
        {

        }

        private void UserControlReservation_Load(object sender, EventArgs e)
        {
            comboBoxType.SelectedIndex = 0;
            comboBoxType1.SelectedIndex = 0;
            comboBoxNo.SelectedIndex = 0;
            comboBoxNo1.SelectedIndex = 0;
        }

        private void tabPageAddReservation_Leave(object sender, EventArgs e)
        {
            Clear();
            Clear1();
        }

        private void btnAddReservation_Click(object sender, EventArgs e)
        {
            if (comboBoxType.SelectedIndex == 0 ||
         comboBoxNo.SelectedIndex == 0 ||
         txtBoxClientID.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please fill out all fields.");
                return;
            }

            // DATE VALIDATION
            if (dateTimePickerOut.Value.Date <= dateTimePickerIn.Value.Date)
            {
                MessageBox.Show(
                    "Check-out date must be later than check-in date.",
                    "Invalid Dates",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }
            // check if ClientID exist in  client button 
            if (!db.ClientExists(txtBoxClientID.Text.Trim()))
            {
                MessageBox.Show(
                    "Client ID does not exist. Please add the client first.",
                    "Invalid Client",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            bool check = db.AddReservation(
                comboBoxType.SelectedItem.ToString(),
                comboBoxNo.SelectedItem.ToString(),
                txtBoxClientID.Text.Trim(),
                dateTimePickerIn.Value.ToString("yyyy-MM-dd"),
                dateTimePickerOut.Value.ToString("yyyy-MM-dd")
            );

            if (check)
                Clear();
        }



        private void tabPageSearchRervation_Enter(object sender, EventArgs e)
        {
            string query = @"
SELECT 
    Reservation_ID,
    Room_Number,
    Room_Type,
    Reservation_In,
    Reservation_Out,
    Reservation_Status
FROM Reservation_Table";


            db.DisplayAndSearch(query, dataGridViewReservation);
        }

        private void tabPageSearchRervation_Leave(object sender, EventArgs e)
        {
            txtBoxClientID.Clear();
        }

        private void txtBoxSearchClientID_TextChanged(object sender, EventArgs e)
        {

            string query = @"
SELECT 
    Reservation_ID,
    Room_Number,
    Room_Type,
    Reservation_In,
    Reservation_Out,
    Reservation_Status
FROM Reservation_Table";

            db.DisplayAndSearch(query, dataGridViewReservation);
        }

        private void dataGridViewReservation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex == -1) return;

            DataGridViewRow row = dataGridViewReservation.Rows[e.RowIndex];

            RID = row.Cells[0].Value?.ToString() ?? "";
            No = row.Cells[1].Value?.ToString() ?? "";

            if (row.Cells[2].Value != null && comboBoxType1.Items.Contains(row.Cells[2].Value.ToString()))
                comboBoxType1.SelectedItem = row.Cells[2].Value.ToString();

            // Safe assignment for Reservation_In
            if (row.Cells[3].Value != null)
            {
                if (row.Cells[3].Value is DateTime dtIn)
                    dateTimePickerIn1.Value = dtIn;
                else if (DateTime.TryParse(row.Cells[3].Value.ToString(), out DateTime parsedIn))
                    dateTimePickerIn1.Value = parsedIn;
                else
                    dateTimePickerIn1.Value = DateTime.Now; // fallback
            }

            // Safe assignment for Reservation_Out
            if (row.Cells[4].Value != null)
            {
                if (row.Cells[4].Value is DateTime dtOut)
                    dateTimePickerOut1.Value = dtOut;
                else if (DateTime.TryParse(row.Cells[4].Value.ToString(), out DateTime parsedOut))
                    dateTimePickerOut1.Value = parsedOut;
                else
                    dateTimePickerOut1.Value = DateTime.Now;

            } }

        private void btnUpdateReservation_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(RID))
            {
                MessageBox.Show("Please first select row from table.", "Selection of row.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (comboBoxType1.SelectedIndex == 0 || comboBoxNo1.SelectedIndex == 0 || string.IsNullOrWhiteSpace(txtBoxClientID1.Text))
            {
                MessageBox.Show("Please fill out all fields.", "Required all fields.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            bool check = db.UpdateReservation(
                RID,
                comboBoxType1.SelectedItem.ToString(),
                comboBoxNo1.SelectedItem.ToString(),
                txtBoxClientID1.Text,
                dateTimePickerIn1.Value.ToString("yyyy-MM-dd"),
                dateTimePickerOut1.Value.ToString("yyyy-MM-dd")
            );

            // Update old room to free
            if (!string.IsNullOrEmpty(No))
                db.UpdateReservationRoom(No, "Yes");

            // Update new room to occupied
            db.UpdateReservationRoom(comboBoxNo1.SelectedItem.ToString(), "No");

            if (check)
                Clear1();
        } 
        private void btnCancelReservation_Click(object sender, EventArgs e)
        {

            bool check;
            if (RID != "")
            {
                if (comboBoxType1.SelectedIndex == 0 ||  txtBoxClientID1.Text.Trim() == string.Empty)

                    MessageBox.Show("Please fill out all fields.", "Required all fields.", MessageBoxButtons.OK, MessageBoxIcon.Information);

                else
                {
                    DialogResult result = MessageBox.Show("Are you want to cancel this reservation?", "reservation cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (DialogResult.Yes == result)
                    {
                        check = db.DeleteReservation(RID);
                        db.UpdateReservationRoom(No, "Yes");
                        if (check)
                            Clear1();

                    }
                }

            }
            else
                MessageBox.Show("Please first select row from table.", "Selection of row.", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tabPageUpdateAndCancelReservation_Leave(object sender, EventArgs e)
        {
            Clear1();
        }

        private void txtBoxClientID1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxType1_TextChanged(object sender, EventArgs e)
        {
             
        }

        private void comboBoxType1_SelectedIndexChanged(object sender, EventArgs e)
        {
            db.RoomTypeAndNo("SELECT Room_Number FROM Room_Table WHERE Room_Type = '" +comboBoxType1.SelectedItem.ToString() + "' AND Room_Free = 'Yes' ORDER BY Room_Number",comboBoxNo1);
        }

        private void tabPageSearchRervation_Click(object sender, EventArgs e)
        {

        }

        private void txtBoxClientID_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewReservation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBoxRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            db.RoomTypeAndNo("SELECT Room_Number FROM Room_Table WHERE Room_Type = '" + comboBoxType.SelectedItem.ToString() + "' AND Room_Free = 'Yes' ORDER BY Room_Number", comboBoxNo);
        }

    }
}

