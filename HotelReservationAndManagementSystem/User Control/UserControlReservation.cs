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

            DBConnector1 db = new DBConnector1();
            _service = new ReservationService(new ReservationRepository(db));
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
            OldRoomNo = "";
        }

        private bool BindSelectedReservation()
        {
            if (selectedReservationRow == null) return false;

            RID = selectedReservationRow.Cells[0].Value.ToString();
            txtBoxClientID1.Text = selectedReservationRow.Cells[1].Value.ToString();
            OldRoomNo = selectedReservationRow.Cells[2].Value.ToString();

            string roomType = selectedReservationRow.Cells[3].Value.ToString();
            comboBoxType1.SelectedItem = roomType;

            _service.LoadRoomNumbers(roomType, OldRoomNo, comboBoxNo1);
            comboBoxNo1.Text = OldRoomNo;

            dateTimePickerIn1.Value = Convert.ToDateTime(selectedReservationRow.Cells[4].Value);
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
            if (comboBoxType.SelectedIndex == 0 ||
               comboBoxNo.SelectedIndex == 0 ||
               string.IsNullOrWhiteSpace(txtBoxClientID.Text))
            {
                MessageBox.Show("Please fill out all fields.");
                return;
            }

            if (!int.TryParse(txtBoxClientID.Text, out int clientId))
            {
                MessageBox.Show("Client ID must be numeric.");
                return;
            }

            bool success = _service.AddReservation(
                comboBoxType.SelectedItem.ToString(),
                int.Parse(comboBoxNo.SelectedItem.ToString()),
                clientId,
                dateTimePickerIn.Value,
                dateTimePickerOut.Value
            );

            if (!success)
            {
                MessageBox.Show("Reservation failed. Check dates or data.");
                return;
            }

            MessageBox.Show("Reservation added successfully.");
            Clear();
        }
           

        private void tabPageSearchRervation_Enter(object sender, EventArgs e)
        {
            _service.LoadReservations(dataGridViewReservation);
        }

        private void tabPageSearchRervation_Leave(object sender, EventArgs e)
        {
            txtBoxClientID.Clear();
        }

        private void txtBoxSearchClientID_TextChanged(object sender, EventArgs e)
        {
            _service.SearchByClient(txtBoxSearchClientID.Text, dataGridViewReservation); // error 
        }

        private void dataGridViewReservation_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0) return;

            var row = dataGridViewReservation.Rows[e.RowIndex];

            if (row.Cells[6].Value?.ToString() != "Reserved")
            {
                MessageBox.Show("Only RESERVED reservations can be modified.");
                return;
            }

            selectedReservationRow = row;
            tabControlReservation.SelectedTab = tabPageUpdateAndCancelReservation;
        }

        private void btnUpdateReservation_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(RID))
            {
                MessageBox.Show("Select a reservation first.");
                return;
            }

            bool success = _service.UpdateReservation( // error 
                int.Parse(RID),
                comboBoxType1.SelectedItem.ToString(),
                int.Parse(comboBoxNo1.SelectedItem.ToString()),
                int.Parse(txtBoxClientID1.Text),
                dateTimePickerIn1.Value,
                dateTimePickerOut1.Value,
                OldRoomNo
            );

            if (!success)
            {
                MessageBox.Show("Update failed.");
                return;
            }

            MessageBox.Show("Reservation updated successfully.");
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
            if (string.IsNullOrEmpty(OldRoomNo)) return;

            _service.LoadRoomNumbers(
                comboBoxType1.SelectedItem.ToString(),
                OldRoomNo,
                comboBoxNo1
            );

            comboBoxNo1.Text = OldRoomNo;
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
                MessageBox.Show("Invalid reservation selection.");
                tabControlReservation.SelectedTab = tabPageSearchRervation;
            }
        }

        private void btnCheckInReservation_Click (object sender, EventArgs e)  // CANCEL RESERVATION BTN
        {
            if (string.IsNullOrEmpty(RID))
            {
                MessageBox.Show("Select a reservation first.");
                return;
            }

            bool success = _service.CheckIn( // error 
                int.Parse(RID),
                txtBoxClientID1.Text,
                int.Parse(comboBoxNo1.SelectedItem.ToString()),
                comboBoxType1.SelectedItem.ToString(),
                dateTimePickerOut1.Value
            );

            if (!success)
            {
                MessageBox.Show("Check-in failed.");
                return;
            }

            MessageBox.Show("Guest checked in successfully.");
            _service.LoadReservations(dataGridViewReservation);
            Clear1();
            tabControlReservation.SelectedTab = tabPageSearchRervation;
        }

        private void UserControlReservation_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxType.SelectedIndex == 0) return;

            _service.LoadRoomNumbers(
                comboBoxType.SelectedItem.ToString(),
                "",
                comboBoxNo
            );
        }

    }
}

