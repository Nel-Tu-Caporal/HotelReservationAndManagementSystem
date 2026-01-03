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

        private DataGridViewRow selectedReservationRow = null;
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
            if (comboBoxType.SelectedItem == null ||
        comboBoxNo.SelectedItem == null ||
        string.IsNullOrWhiteSpace(txtBoxClientID.Text))
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

            // Validate numeric values
            if (!int.TryParse(txtBoxClientID.Text, out int clientId))
            {
                MessageBox.Show("Client ID must be a number.");
                return;
            }

            if (!int.TryParse(comboBoxNo.SelectedItem.ToString(), out int roomNo))
            {
                MessageBox.Show("Room Number must be a number.");
                return;
            }

            // Call AddReservation with correct types
            bool check = db.AddReservation(
                comboBoxType.SelectedItem.ToString(),
                roomNo,
                clientId,
                dateTimePickerIn.Value,   // DateTime
                dateTimePickerOut.Value   // DateTime
            );

            if (check)
            {
                db.UpdateReservationRoom(comboBoxNo.SelectedItem.ToString(), "No");
                Clear();
            }
        }

        private void tabPageSearchRervation_Enter(object sender, EventArgs e)
        {
            string query = @"
        
    SELECT
        Reservation_ID,
        Client_ID,
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
            string query;

           
            if (string.IsNullOrWhiteSpace(txtBoxSearchClientID.Text))
            {
                query = @"
SELECT 
    Reservation_ID,
    Client_ID,
    Room_Number,
    Room_Type,
    Reservation_In,
    Reservation_Out,
    Reservation_Status
FROM Reservation_Table";
            }
            else
            {
                
                if (!int.TryParse(txtBoxSearchClientID.Text, out _))
                    return;

                query = @"
SELECT 
    Reservation_ID,
    Client_ID,
    Room_Number,
    Room_Type,
    Reservation_In,
    Reservation_Out,
    Reservation_Status
FROM Reservation_Table
WHERE Client_ID = " + txtBoxSearchClientID.Text;
            }

            db.DisplayAndSearch(query, dataGridViewReservation);
        }

        private void dataGridViewReservation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           if (e.RowIndex == -1) return;

            selectedReservationRow = dataGridViewReservation.Rows[e.RowIndex];

            tabControlReservation.SelectedTab = tabPageUpdateAndCancelReservation;
        }

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
    int.Parse(RID),                              
    comboBoxType1.SelectedItem.ToString(),       
    int.Parse(comboBoxNo1.SelectedItem.ToString()),
    int.Parse(txtBoxClientID1.Text),              
    dateTimePickerIn1.Value,                     
    dateTimePickerOut1.Value                  
);

            // Update old room to free
            if (!string.IsNullOrEmpty(No))
                db.UpdateReservationRoom(No, "Yes");

            // Update new room to occupied
            db.UpdateReservationRoom(comboBoxNo1.SelectedItem.ToString(), "No");

            if (check)
                db.UpdateReservationRoom(comboBoxNo.SelectedItem.ToString(), "No");
            Clear1();
        } 
            private void btnCancelReservation_Click(object sender, EventArgs e)
            {
            if (string.IsNullOrEmpty(RID))
            {
                MessageBox.Show(
                    "Please first select a reservation.",
                    "No Selection",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                return;
            }

            // 🔒 Allow cancel ONLY if status is Reserved
            string status = selectedReservationRow.Cells[6].Value?.ToString();
            if (status != "Reserved")
            {
                MessageBox.Show(
                    "Only RESERVED reservations can be cancelled.",
                    "Cancel Not Allowed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            DialogResult result = MessageBox.Show(
                "Do you want to cancel this reservation?",
                "Cancel Reservation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result != DialogResult.Yes)
                return;

            // ✅ CORRECT: cancel (update status), not delete
            bool success = db.CancelReservation(int.Parse(RID));

            if (success)
            {
                // Free the room
                if (!string.IsNullOrEmpty(No))
                    db.UpdateReservationRoom(No, "Yes");

                MessageBox.Show("Reservation cancelled successfully.");

                Clear1();
                tabControlReservation.SelectedTab = tabPageSearchRervation;
            }
            else
            {
                MessageBox.Show(
                    "Reservation could not be cancelled.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                }
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
            if (string.IsNullOrEmpty(No)) return;

            string query =
                "SELECT Room_Number FROM Room_Table " +
                "WHERE Room_Type = '" + comboBoxType1.SelectedItem.ToString() + "' " +
                "AND (Room_Free = 'Yes' OR Room_Number = '" + No + "') " +
                "ORDER BY Room_Number";

            db.RoomTypeAndNo(query, comboBoxNo1);

            // 🔑 Auto-select the reserved room
            comboBoxNo1.Text = No;
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

        private void tabPageUpdateAndCancelReservation_Enter(object sender, EventArgs e)
        {
            if (selectedReservationRow == null) return;

            RID = selectedReservationRow.Cells[0].Value.ToString();
            txtBoxClientID1.Text = selectedReservationRow.Cells[1].Value.ToString();

            string roomNo = selectedReservationRow.Cells[2].Value.ToString();
            string roomType = selectedReservationRow.Cells[3].Value.ToString();

            comboBoxType1.SelectedItem = roomType;

            // 🔥 KEY FIX: load free rooms + current reserved room
            db.RoomTypeAndNo(
                "SELECT Room_Number FROM Room_Table " +
                "WHERE Room_Type = '" + roomType + "' " +
                "AND (Room_Free = 'Yes' OR Room_Number = " + roomNo + ") " +
                "ORDER BY Room_Number",
                comboBoxNo1
            );

            comboBoxNo1.SelectedItem = roomNo;

            No = roomNo;

            dateTimePickerIn1.Value = Convert.ToDateTime(selectedReservationRow.Cells[4].Value);
            dateTimePickerOut1.Value = Convert.ToDateTime(selectedReservationRow.Cells[5].Value);
        }

        private void btnCheckInReservation_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(RID))
            {
                MessageBox.Show("Please select a reservation first.");
                return;
            }

            string status = selectedReservationRow.Cells[6].Value?.ToString();
            if (status != "Reserved")
            {
                MessageBox.Show("This reservation is already checked in or cancelled.");
                return;
            }

            bool success = db.CheckInFromReservation(
                int.Parse(RID),
                txtBoxClientID1.Text,
                dateTimePickerIn1.Value,
                dateTimePickerOut1.Value
            );

            if (success)
            {
                MessageBox.Show("Check-In successful.");

                // ✅ FIX 3-B: refresh reservation list
                db.DisplayAndSearch(
                    "SELECT Reservation_ID, Client_ID, Room_Number, Room_Type, " +
                    "Reservation_In, Reservation_Out, Reservation_Status " +
                    "FROM Reservation_Table " +
                    "WHERE Reservation_Status = 'Reserved'",
                    dataGridViewReservation
                );

                Clear1();
                tabControlReservation.SelectedTab = tabPageSearchRervation;
            }
        }

        private void comboBoxRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            db.RoomTypeAndNo("SELECT Room_Number FROM Room_Table WHERE Room_Type = '" + comboBoxType.SelectedItem.ToString() + "' AND Room_Free = 'Yes' ORDER BY Room_Number", comboBoxNo);
        }

    }
}

