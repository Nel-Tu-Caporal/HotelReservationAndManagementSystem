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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HotelReservationAndManagementSystem.User_Control
{
    public partial class UserControlCheckInAndCheckOut : UserControl
    {

        DBConnector1 db;

        private string SelectedCheckInID = "";
        private string SelectedReservationID = "";
        private int SelectedRoomNumber = 0;
        private decimal SelectedRoomRate = 0;
        private DateTime SelectedCheckInDate;

        private int selectedCheckInOutID = 0;
        private int selectedRoomNumber = 0;

        private string checkInID = "";


        public UserControlCheckInAndCheckOut()
        {
            InitializeComponent();

            db = new DBConnector1();
        }

        public void Clear()
        {
            
           
        }

        private void Clear1()
        {
            lblCheckInOutDate.Text = "?";
            lblTotalDaysStayed.Text = "?";
            lblRoomRates.Text = "?";
            lblTotalAmount.Text = "?";

            SelectedCheckInID = "";
            SelectedReservationID = "";
            SelectedRoomNumber = 0;
            SelectedRoomRate = 0;
        }

        private void LoadCheckInList()
        {
            string query =
                "SELECT c.CheckInOut_ID, c.Reservation_ID, " +
                "cl.Client_FirstName + ' ' + cl.Client_LastName AS ClientName, " +
                "r.Room_Number, r.Room_Type, " +
                "c.CheckInDate, c.ExpectedCheckOutDate, c.RoomRate, c.Status " +
                "FROM CheckInOut_Table c " +
                "JOIN Reservation_Table r ON c.Reservation_ID = r.Reservation_ID " +
                "JOIN Client_Table cl ON r.Client_ID = cl.Client_ID " +
                "WHERE c.Status = 'CheckedIn'";

            db.DisplayAndSearch(query, dataGridViewCheckInList);
        }


        private void dataGridViewReservation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void tabPageCheckOut_Click(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblCheckInOutDate_Click(object sender, EventArgs e)
        {

        }

        private void lblTotalDaysStayed_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void lblTotalAmount_Click(object sender, EventArgs e)
        {

        }

        private void lblRoomRates_Click(object sender, EventArgs e)
        {

        }

        private void tabPageCheckIn_Click(object sender, EventArgs e)
        {

        }



        private void dataGridViewCheckInList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dataGridViewCheckInList.Rows[e.RowIndex];

            selectedCheckInOutID = Convert.ToInt32(row.Cells["CheckInOut_ID"].Value);
            selectedRoomNumber = Convert.ToInt32(row.Cells["Room_Number"].Value);

            //  REQUIRED FOR CHECK-OUT
            SelectedReservationID = row.Cells["Reservation_ID"].Value.ToString();

            DateTime checkInDate = Convert.ToDateTime(row.Cells["CheckInDate"].Value);
            DateTime today = DateTime.Today;

            int totalDays = Math.Max(1, (today - checkInDate).Days);
            decimal roomRate = Convert.ToDecimal(row.Cells["RoomRate"].Value);

            lblCheckInOutDate.Text = today.ToString("dd/MM/yyyy");
            lblTotalDaysStayed.Text = totalDays.ToString();
            lblRoomRates.Text = roomRate.ToString("0.00");
            lblTotalAmount.Text = (totalDays * roomRate).ToString("0.00");


        }

        

        private void tabPageCheckOut_Enter(object sender, EventArgs e)
        {
           
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(SelectedReservationID))
            {
                MessageBox.Show("Select a checked-in record first.");
                return;
            }

            int reservationId = Convert.ToInt32(SelectedReservationID);

            bool success = db.CheckOutReservation(reservationId);

            if (success)
            {
                LoadCheckInList();

                // reset UI
                SelectedReservationID = "";
                selectedCheckInOutID = 0;
                selectedRoomNumber = 0;

                lblCheckInOutDate.Text = "?";
                lblTotalDaysStayed.Text = "?";
                lblRoomRates.Text = "?";
                lblTotalAmount.Text = "?";
            }
        }



        private void UserControlCheckInAndCheckOut_Load(object sender, EventArgs e)
        {
            LoadCheckInList();
        }

        private void comboBoxRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridViewCheckInList_Enter(object sender, EventArgs e)
        {
           
        }


        private void tabPageCheckInList_Click(object sender, EventArgs e)
        {

        }

        private void UserControlCheckInAndCheckOut_Enter(object sender, EventArgs e)
        {
            LoadCheckInList();
        }

        private void tabControlCheckInCheckOut_Enter(object sender, EventArgs e)
        {
        }

        private void btnUpdateCheckIn_Click(object sender, EventArgs e)
        {
           
        }

        private void btnCancelCheckIn_Click(object sender, EventArgs e)
        {
            if (selectedCheckInOutID == 0)
            {
                MessageBox.Show("Select a check-in first.");
                return;
            }

            bool success = db.CancelCheckIn(
                selectedCheckInOutID,
                selectedRoomNumber
            );

            if (success)
            {
                MessageBox.Show(
                    $"Check-in cancelled successfully.\nRoom {selectedRoomNumber}");

                
                LoadCheckInList();

                // reset state
                selectedCheckInOutID = 0;
                selectedRoomNumber = 0;

                lblCheckInOutDate.Text = "?";
                lblTotalDaysStayed.Text = "?";
                lblRoomRates.Text = "?";
                lblTotalAmount.Text = "?";
            }
        }


        private void comboBoxRoomNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void tabPageCheckIn_Enter(object sender, EventArgs e)
        {
            
        }

        private void tabPageCheckInList_Enter(object sender, EventArgs e)
        {

        }
    }
    
}
