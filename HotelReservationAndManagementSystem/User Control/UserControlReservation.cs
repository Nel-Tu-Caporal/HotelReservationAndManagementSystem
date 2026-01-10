    using HotelReservationAndManagementSystem.Interface.Services;
    using HotelReservationAndManagementSystem.Models.Services;
    using HotelReservationAndManagementSystem.References;
    using HotelReservationAndManagementSystem.Repo;
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
        private readonly IReservationService _service;

        private DataGridViewRow selectedReservationRow = null;
        private string RID = "";
        private string OldRoomNo = "";

        public UserControlReservation()
        {
            InitializeComponent();

            if (!DesignMode)
            {
                var repo = new ReservationRepository(new DBConnector1());
                _service = new ReservationService(repo);
            }
        }



        public void Clear()
        {
            SafeSelectFirstItem(comboBoxType);
            SafeSelectFirstItem(comboBoxNo);

            txtBoxClientID.Clear();
            dateTimePickerIn.Value = DateTime.Now;
            dateTimePickerOut.Value = DateTime.Now;
            tabControlReservation.SelectedTab = tabPageAddReservation;
        }

        private void Clear1()
        {
            SafeSelectFirstItem(comboBoxType1);
            SafeSelectFirstItem(comboBoxNo1);

            txtBoxClientID1.Clear();
            dateTimePickerIn1.Value = DateTime.Now;
            dateTimePickerOut1.Value = DateTime.Now;
            RID = "";
            OldRoomNo = "";
        }

      

        private bool BindSelectedReservation()
        {
            if (selectedReservationRow == null)
                return false;

         
            RID = selectedReservationRow.Cells[0].Value.ToString();

           
            txtBoxClientID1.Text = selectedReservationRow.Cells[3].Value.ToString();

          
            OldRoomNo = selectedReservationRow.Cells[2].Value.ToString();

           
            string roomType = selectedReservationRow.Cells[1].Value.ToString();
            comboBoxType1.SelectedItem = roomType;

        
            BindRoomNumbersToComboBox(roomType, OldRoomNo, comboBoxNo1);
            comboBoxNo1.SelectedItem = int.Parse(OldRoomNo);

      
            dateTimePickerIn1.Value =
                Convert.ToDateTime(selectedReservationRow.Cells[4].Value);

            dateTimePickerOut1.Value =
                Convert.ToDateTime(selectedReservationRow.Cells[5].Value);

            return true;
        }

        private void BindRoomNumbersToComboBox(string roomType, string oldRoomNo, ComboBox comboBox)
        {
            if (string.IsNullOrWhiteSpace(roomType)) return;

            // Temporarily unsubscribe event to avoid recursive calls
            comboBox.SelectedIndexChanged -= comboBoxType_SelectedIndexChanged;

            comboBox.Items.Clear();
            var rooms = _service.GetAvailableRoomNumbers(roomType, oldRoomNo);
            foreach (var roomNo in rooms)
                comboBox.Items.Add(roomNo);

            // Safely select old room if it exists
            if (int.TryParse(oldRoomNo, out int oldNo) && comboBox.Items.Contains(oldNo))
            {
                comboBox.SelectedItem = oldNo;
            }
            else if (comboBox.Items.Count > 0)
            {
                comboBox.SelectedIndex = 0;
            }
            else
            {
                comboBox.SelectedIndex = -1;
            }

            // Re-subscribe event
            comboBox.SelectedIndexChanged += comboBoxType_SelectedIndexChanged;
        }

        private void SafeSelectFirstItem(ComboBox comboBox)
        {
            if (comboBox.Items.Count > 0)
                comboBox.SelectedIndex = 0;
            else
                comboBox.SelectedIndex = -1;
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
            comboBoxType.SelectedIndex = -1;
            comboBoxType1.SelectedIndex = -1;
            comboBoxNo.SelectedIndex = -1;
            comboBoxNo1.SelectedIndex = -1;
        }

        private void tabPageAddReservation_Leave(object sender, EventArgs e)
        {
            Clear();
            Clear1();
        }

        private void btnAddReservation_Click(object sender, EventArgs e)
        {
            if (comboBoxType.SelectedItem == null)
            {
                MessageBox.Show(
                    "Please select a room type.",
                    "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            if (comboBoxNo.SelectedItem == null)
            {
                MessageBox.Show(
                    "Please select a room number.",
                    "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            if (string.IsNullOrWhiteSpace(txtBoxClientID.Text))
            {
                MessageBox.Show(
                    "Please enter the Client ID.",
                    "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            if (!int.TryParse(txtBoxClientID.Text, out int clientId))
            {
                MessageBox.Show(
                    "Client ID must be a valid numeric value.",
                    "Invalid Input",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            if (!_service.ClientExists(clientId)) // error not exists clientExist
            {
                MessageBox.Show(
                    "The Client ID you entered does not exist.\n\n" +
                    "Please register the client first before making a reservation.",
                    "Invalid Client ID",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            if (dateTimePickerIn.Value.Date >= dateTimePickerOut.Value.Date)
            {
                MessageBox.Show(
                    "Check-out date must be later than the check-in date.",
                    "Invalid Date Selection",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            bool success = _service.AddReservation(
                comboBoxType.SelectedItem.ToString(),
                Convert.ToInt32(comboBoxNo.SelectedItem),
                clientId,
                dateTimePickerIn.Value.Date,
                dateTimePickerOut.Value.Date
            );

            MessageBox.Show(
                success ? "Reservation has been added successfully." : "Failed to add reservation.",
                success ? "Success" : "Operation Failed",
                MessageBoxButtons.OK,
                success ? MessageBoxIcon.Information : MessageBoxIcon.Error
            );

            if (success)
                Clear();
        }


        private void tabPageSearchRervation_Enter(object sender, EventArgs e)
        {
            dataGridViewReservation.DataSource = _service.GetReservations();
        }

        private void tabPageSearchRervation_Leave(object sender, EventArgs e)
        {
            txtBoxClientID.Clear();
        }

        private void txtBoxSearchClientID_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBoxSearchClientID.Text))
            {
                dataGridViewReservation.DataSource = _service.GetReservations();
                return;
            }

            if (!int.TryParse(txtBoxSearchClientID.Text, out int clientId))
                return;

            dataGridViewReservation.DataSource =
                _service.SearchReservationsByClient(clientId);
        }
        

        private void dataGridViewReservation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
       
            if (e.RowIndex < 0) return;

            selectedReservationRow = dataGridViewReservation.Rows[e.RowIndex];

            // Prevent selecting cancelled / checked-in reservations
            string status = selectedReservationRow.Cells[6].Value.ToString();
            if (status != "Reserved")
            {
                MessageBox.Show(
                    "Only RESERVED reservations can be updated or checked in.",
                    "Invalid Selection",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                return;
            }

            // Auto switch to Update & Cancel tab
            tabControlReservation.SelectedTab = tabPageUpdateAndCancelReservation;
        }
        

        private void btnUpdateReservation_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(RID))
            {
                MessageBox.Show("Select a reservation first.");
                return;
            }

            if (comboBoxType1.SelectedItem == null ||
                comboBoxNo1.SelectedItem == null ||
                string.IsNullOrWhiteSpace(txtBoxClientID1.Text))
            {
                MessageBox.Show("Please complete all fields.");
                return;
            }

            if (!int.TryParse(RID, out int reservationId) ||
                !int.TryParse(comboBoxNo1.SelectedItem.ToString(), out int roomNo) ||
                !int.TryParse(txtBoxClientID1.Text, out int clientId))
            {
                MessageBox.Show("Invalid numeric value.");
                return;
            }

            // ✅ CLIENT EXISTENCE CHECK (FIX FOR FK ERROR)
            if (!_service.ClientExists(clientId))
            {
                MessageBox.Show(
                    "The Client ID you entered does not exist.\n\n" +
                    "Please create/register the client first before updating the reservation.",
                    "Client Not Found",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            if (dateTimePickerIn1.Value.Date >= dateTimePickerOut1.Value.Date)
            {
                MessageBox.Show("Check-out date must be after check-in date.");
                return;
            }

            bool success = _service.UpdateReservation(
                reservationId,
                comboBoxType1.SelectedItem.ToString(),
                roomNo,
                clientId,
                dateTimePickerIn1.Value.Date,
                dateTimePickerOut1.Value.Date,
                OldRoomNo
            );

            MessageBox.Show(
                success ? "Reservation updated successfully." : "Update failed.",
                success ? "Success" : "Error",
                MessageBoxButtons.OK,
                success ? MessageBoxIcon.Information : MessageBoxIcon.Error
            );

            if (success)
            {
                Clear1();
                tabControlReservation.SelectedTab = tabPageSearchRervation;
            }
        }
        


        private void tabPageUpdateAndCancelReservation_Leave(object sender, EventArgs e)
        {
            Clear1();
        }

        private void txtBoxClientID1_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void comboBoxType1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxType1.SelectedItem == null) return;
            if (string.IsNullOrEmpty(OldRoomNo)) return;

            BindRoomNumbersToComboBox(comboBoxType1.SelectedItem.ToString(), OldRoomNo, comboBoxNo1);
        }

        private void tabPageSearchRervation_Click(object sender, EventArgs e)
        {

        }


        private void tabPageUpdateAndCancelReservation_Enter(object sender, EventArgs e)
        {
            if (!BindSelectedReservation())
            {
                MessageBox.Show("Invalid reservation selection.");
                tabControlReservation.SelectedTab = tabPageSearchRervation;
            }
        }

        private void btnCheckInReservation_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(RID))
            {
                MessageBox.Show(
                    "Please select a reservation to check in.",
                    "Check-In Required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                return;
            }

            if (!int.TryParse(RID, out int reservationId))
            {
                MessageBox.Show(
                    "The selected reservation is invalid.",
                    "Check-In Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

            if (!int.TryParse(comboBoxNo1.SelectedItem?.ToString(), out int roomNo))
            {
                MessageBox.Show(
                    "Unable to determine the room number.",
                    "Check-In Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

            decimal roomRate = 0; // Temporary fix: no txtRoomRate TextBox yet

            string roomType = comboBoxType1.SelectedItem?.ToString();
            string clientName = txtBoxClientID1.Text; // temporary, you can replace with actual client name later
            DateTime checkInDate = DateTime.Now;
            DateTime expectedOutDate = dateTimePickerOut1.Value;

            DialogResult confirm = MessageBox.Show(
                "Do you want to proceed with the check-in for this reservation?",
                "Confirm Check-In",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirm != DialogResult.Yes)
                return;

            bool success = _service.CheckIn(
                reservationId,
                clientName,
                roomNo,
                roomType,
                roomRate,
                checkInDate,
                expectedOutDate
            );

            MessageBox.Show(
                success
                    ? "The guest has been successfully checked in."
                    : "Check-in failed. This reservation may already be checked in or cancelled.",
                success ? "Check-In Successful" : "Check-In Failed",
                MessageBoxButtons.OK,
                success ? MessageBoxIcon.Information : MessageBoxIcon.Warning
            );

            if (success)
            {
                dataGridViewReservation.DataSource = _service.GetReservations();
                Clear1();
                tabControlReservation.SelectedTab = tabPageSearchRervation;
            }
        }


        private void UserControlReservation_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxType.SelectedItem == null)
                return;

            string roomType = comboBoxType.SelectedItem.ToString();

            // Ignore placeholder value
            if (roomType == "Please select ...")
            {
                comboBoxNo.Items.Clear();
                comboBoxNo.SelectedIndex = -1;
                return;
            }

            comboBoxNo.Items.Clear();

            var rooms = _service.GetAvailableRoomNumbers(roomType, "");

            if (rooms.Count == 0)
            {
                comboBoxNo.SelectedIndex = -1;
                return;
            }

            foreach (var room in rooms)
                comboBoxNo.Items.Add(room);

            comboBoxNo.SelectedIndex = 0;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(RID))
            {
                MessageBox.Show(
                    "Please select a reservation to cancel.",
                    "Cancellation Required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                return;
            }

            if (!int.TryParse(RID, out int reservationId))
            {
                MessageBox.Show(
                    "The selected reservation is invalid.",
                    "Cancellation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

            if (!int.TryParse(comboBoxNo1.SelectedItem?.ToString(), out int roomNo))
            {
                MessageBox.Show(
                    "Unable to determine the room number for this reservation.",
                    "Cancellation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

            DialogResult confirm = MessageBox.Show(
                "Are you sure you want to cancel this reservation?\n\n" +
                "This action will release the room and cannot be undone.",
                "Confirm Reservation Cancellation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirm != DialogResult.Yes)
                return;

            bool success = _service.CancelReservation(reservationId, roomNo.ToString());

            MessageBox.Show(
                success
                    ? "The reservation has been successfully cancelled."
                    : "The reservation could not be cancelled. It may have already been processed.",
                success ? "Cancellation Successful" : "Cancellation Failed",
                MessageBoxButtons.OK,
                success ? MessageBoxIcon.Information : MessageBoxIcon.Warning
            );

            if (success)
            {
                dataGridViewReservation.DataSource = _service.GetReservations();
                Clear1();
                tabControlReservation.SelectedTab = tabPageSearchRervation;
            }
        }
    }
    }


