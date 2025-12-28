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


        public UserControlCheckInAndCheckOut()
        {
            InitializeComponent();

            db = new DBConnector1();
        }

        public void Clear()
        {
            comboBoxRoomType.SelectedIndex = 0;
            comboBoxRoomNo.SelectedIndex = 0;
            txtBoxClientID.Clear();
            dateTimePickerIn.Value = DateTime.Now;
            dateTimePickerOut.Value = DateTime.Now;
            tabControlCheckInCheckOut.SelectedTab = tabPageCheckIn;
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
            string query = @"SELECT c.CheckInOut_ID, cl.Client_FirstName + ' ' + cl.Client_LastName AS GuestName, 
                                    r.Room_Number, r.Room_Type, c.CheckInDate, res.Reservation_Out AS ExpectedCheckOut, 
                                    c.PaymentStatus AS Status, res.Reservation_ID 
                             FROM CheckInOut_Table c
                             INNER JOIN Reservation_Table res ON c.Reservation_ID = res.Reservation_ID
                             INNER JOIN Room_Table r ON res.Reservation_Room_Number = r.Room_Number
                             INNER JOIN Client_Table cl ON res.Reservation_Client_ID = cl.Client_ID";

            db.DisplayAndSearch(query, dataGridViewCheckInList);

            dataGridViewCheckInList.Columns[0].Visible = false; 
            dataGridViewCheckInList.Columns[7].Visible = false;
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

        private void btnCheckIn_Click(object sender, EventArgs e)
        {

            bool check;
            if (comboBoxRoomType.SelectedIndex == 0 || comboBoxRoomNo.SelectedIndex == 0 || txtBoxClientID.Text.Trim() == string.Empty)

                MessageBox.Show("Please fill out all fields.", "Required all fields.", MessageBoxButtons.OK, MessageBoxIcon.Information);

            else
            {
                check = db.AddReservation(comboBoxRoomType.SelectedItem.ToString(), comboBoxRoomNo.SelectedItem.ToString(), txtBoxClientID.Text.ToString(), dateTimePickerIn.Text, dateTimePickerOut.Text);
                db.UpdateReservationRoom(comboBoxRoomNo.SelectedItem.ToString(), "No");
                if (check)
                    LoadCheckInList();
                Clear();

            }
        }

        private void dataGridViewCheckInList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridViewCheckInList.Rows[e.RowIndex];
                SelectedCheckInID = row.Cells[0].Value.ToString();
                SelectedReservationID = row.Cells[7].Value.ToString();
                SelectedRoomNumber = Convert.ToInt32(row.Cells[2].Value);
                SelectedCheckInDate = Convert.ToDateTime(row.Cells[4].Value);
                SelectedRoomRate = db.Count("SELECT Room_Rate FROM Room_Table WHERE Room_Number = " + SelectedRoomNumber);
            }
        }

        private void tabPageCheckOut_Enter(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(SelectedCheckInID))
            {
                MessageBox.Show("Please select a guest from Check-In List first.", "Check-Out", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DateTime actualCheckOut = DateTime.Now;
            lblCheckInOutDate.Text = actualCheckOut.ToString("MM/dd/yyyy");

            int totalDays = (int)Math.Ceiling((actualCheckOut - SelectedCheckInDate).TotalDays);
            if (totalDays == 0) totalDays = 1;

            lblTotalDaysStayed.Text = totalDays.ToString();
            lblRoomRates.Text = SelectedRoomRate.ToString("C");
            lblTotalAmount.Text = (totalDays * SelectedRoomRate).ToString("C");
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(SelectedReservationID))
            {
                MessageBox.Show("Please select a guest from Check-In List first.", "Check-Out", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            bool check = db.CheckOutReservation(SelectedReservationID);
            db.UpdateReservationRoom(SelectedRoomNumber.ToString(), "Yes"); // Mark room available

            if (check)
            {
                MessageBox.Show("Check-Out Successful!", "Check-Out", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                LoadCheckInList();
                Clear1();
            }
        }

        private void UserControlCheckInAndCheckOut_Load(object sender, EventArgs e)
        {
            dataGridViewCheckInList.AutoGenerateColumns = true;
            dataGridViewCheckInList.Columns.Clear();
            LoadCheckInList();
        }

        private void comboBoxRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = @"SELECT Reservation_Room_Number 
                             FROM Reservation_Table r
                             LEFT JOIN CheckInOut_Table c ON r.Reservation_ID = c.Reservation_ID
                             WHERE r.Reservation_Room_Type = '" + comboBoxRoomType.SelectedItem + @"' 
                               AND c.Reservation_ID IS NULL
                             ORDER BY Reservation_Room_Number";

            db.RoomTypeAndNo(query, comboBoxRoomNo);
        }

        private void dataGridViewCheckInList_Enter(object sender, EventArgs e)
        {
            LoadCheckInList();
        }

        private void tabPageCheckInList_Click(object sender, EventArgs e)
        {

        }
    }
}
