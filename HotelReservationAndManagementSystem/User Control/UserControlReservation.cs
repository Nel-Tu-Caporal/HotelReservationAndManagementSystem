using HotelReservationAndManagementSystem.References;
using Org.BouncyCastle.Cms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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


        private bool BindSelectedReservation()
        {
            if (selectedReservationRow == null)
                return false;

            if (selectedReservationRow.Cells[0].Value == null)
                return false;

            RID = selectedReservationRow.Cells[0].Value.ToString();

            txtBoxClientID1.Text =
                selectedReservationRow.Cells[1].Value?.ToString() ?? "";

            string roomNo =
                selectedReservationRow.Cells[2].Value?.ToString();

            string roomType =
                selectedReservationRow.Cells[3].Value?.ToString();

            if (string.IsNullOrEmpty(roomNo) || string.IsNullOrEmpty(roomType))
                return false;

            comboBoxType1.SelectedItem = roomType;

            db.RoomTypeAndNo(
                "SELECT Room_Number FROM Room_Table " +
                "WHERE Room_Type = '" + roomType + "' " +
                "AND (Room_Free = 'Yes' OR Room_Number = " + roomNo + ")",
                comboBoxNo1
            );

            comboBoxNo1.SelectedItem = roomNo;
            No = roomNo;

            if (selectedReservationRow.Cells[4].Value != null)
                dateTimePickerIn1.Value = Convert.ToDateTime(selectedReservationRow.Cells[4].Value);

            if (selectedReservationRow.Cells[5].Value != null)
                dateTimePickerOut1.Value = Convert.ToDateTime(selectedReservationRow.Cells[5].Value);

            return true;
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

            if (dateTimePickerOut.Value.Date <= dateTimePickerIn.Value.Date)
            {
                MessageBox.Show(
                    "Check-out date must be later than check-in date.",
                    "Invalid Dates",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

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

            try
            {
                bool check = db.AddReservation(
                    comboBoxType.SelectedItem.ToString(),
                    roomNo,
                    clientId,
                    dateTimePickerIn.Value,
                    dateTimePickerOut.Value);

                if (check)
                {
                    db.UpdateReservationRoom(
                        comboBoxNo.SelectedItem.ToString(),
                        "No");

                    MessageBox.Show(
                        "Reservation added successfully.",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    Clear();
                }
            }
            catch (SqlException)
            {
                MessageBox.Show(
                    "Client ID does not exist.\nPlease add the client first.",
                    "Invalid Client",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
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

            if (e.RowIndex < 0) return;

            var row = dataGridViewReservation.Rows[e.RowIndex];

            if (row.Cells[6].Value == null)
                return;

            string status = row.Cells[6].Value.ToString();

            if (status != "Reserved")
            {
                MessageBox.Show(
                    "Only RESERVED reservations can be modified.",
                    "Action Not Allowed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                return;
            }

            selectedReservationRow = row;
            tabControlReservation.SelectedTab = tabPageUpdateAndCancelReservation;
        }

        private void btnUpdateReservation_Click(object sender, EventArgs e)
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

            if (comboBoxType1.SelectedIndex == 0 ||
                comboBoxNo1.SelectedIndex == 0 ||
                string.IsNullOrWhiteSpace(txtBoxClientID1.Text))
            {
                MessageBox.Show(
                    "Please fill out all fields.",
                    "Required Fields",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            // Update reservation FIRST
            bool updated = db.UpdateReservation(
                int.Parse(RID),
                comboBoxType1.SelectedItem.ToString(),
                int.Parse(comboBoxNo1.SelectedItem.ToString()),
                int.Parse(txtBoxClientID1.Text),
                dateTimePickerIn1.Value,
                dateTimePickerOut1.Value
            );

            //  Stop if update failed
            if (!updated)
            {
                MessageBox.Show(
                    "Reservation could not be updated.",
                    "Update Failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

            // ✅ Free old room (if changed)
            if (!string.IsNullOrEmpty(No) &&
                No != comboBoxNo1.SelectedItem.ToString())
            {
                db.UpdateReservationRoom(No, "Yes");
            }

            // ✅ Occupy new room
            db.UpdateReservationRoom(
                comboBoxNo1.SelectedItem.ToString(),
                "No"
            );

            MessageBox.Show(
                "Reservation updated successfully.",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            Clear1();
            tabControlReservation.SelectedTab = tabPageSearchRervation;
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
            if (!BindSelectedReservation())
            {
                MessageBox.Show(
                    "Please select a valid reservation.",
                    "Invalid Selection",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                tabControlReservation.SelectedTab = tabPageSearchRervation;
            }
        }

        private void btnCheckInReservation_Click (object sender, EventArgs e)  // CANCEL RESERVATION BTN
        {
            if (string.IsNullOrEmpty(RID))
            {
                MessageBox.Show("Please select a reservation first.");
                return;
            }

            // Make sure room is selected
            if (comboBoxNo1.SelectedItem == null || comboBoxType1.SelectedItem == null)
            {
                MessageBox.Show("Invalid room selection.");
                return;
            }

            DialogResult confirm = MessageBox.Show(
                "Proceed with CHECK-IN for this reservation?",
                "Check-In Reservation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes)
                return;

            int reservationId = int.Parse(RID);
            int roomNumber = int.Parse(comboBoxNo1.SelectedItem.ToString());
            string roomType = comboBoxType1.SelectedItem.ToString();

            // You can improve this later by fetching real client name
            string clientName = txtBoxClientID1.Text;

            // TEMP room rate (replace with DB value if you have one)
            decimal roomRate = 1000m;

            bool success = db.CheckInFromReservation(
                reservationId,
                clientName,
                roomNumber,
                roomType,
                roomRate,
                DateTime.Now,                 // actual check-in
                dateTimePickerOut1.Value      // expected checkout
            );

            if (!success)
            {
                MessageBox.Show(
                    "This reservation is already checked in or invalid.",
                    "Check-In Failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show(
                "Guest checked in successfully!",
                "Check-In Complete",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            // 🔄 Refresh grid
            db.DisplayAndSearch(
                @"SELECT Reservation_ID,
                 Client_ID,
                 Room_Number,
                 Room_Type,
                 Reservation_In,
                 Reservation_Out,
                 Reservation_Status
          FROM Reservation_Table",
                dataGridViewReservation);

            Clear1();
            tabControlReservation.SelectedTab = tabPageSearchRervation;
        }

        private void UserControlReservation_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            db.RoomTypeAndNo("SELECT Room_Number FROM Room_Table WHERE Room_Type = '" + comboBoxType.SelectedItem.ToString() + "' AND Room_Free = 'Yes' ORDER BY Room_Number", comboBoxNo);
        }

    }
}

