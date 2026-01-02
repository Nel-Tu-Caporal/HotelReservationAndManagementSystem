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
    public partial class UserControlBillsAndPayment : UserControl
    {

        DBConnector1 db;

        private DataGridViewRow selectedBillingRow = null;

       
        private int checkInOutID;
        private int reservationID;
        private decimal totalAmount;
        public UserControlBillsAndPayment()
        {
            InitializeComponent();
            db = new DBConnector1();
        }

        public void Clear()
        {
            txtBoxRoomType.Clear();
            txtBoxRoomNo.Clear();
            txtBoxTotalDays.Clear();
            txtBoxRatePerDay.Clear();
            txtBoxTotalAmount.Clear();

            dateTimePickerCheckInDate.Value = DateTime.Now;
            dateTimePickerCheckOutDate.Value = DateTime.Now;
        }
        private void LoadBillingDetails()
        {
            if (reservationID == 0)
            {
                MessageBox.Show("No reservation selected.");
                return;
            }

            DataTable dt = db.GetBillingDetails(reservationID);

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("No billing record found.");
                return;
            }

            DataRow row = dt.Rows[0];

            // store CheckInOutID (important for payment later)
            checkInOutID = Convert.ToInt32(row["CheckInOut_ID"]);

            txtBoxRoomNo.Text = row["Room_Number"].ToString();
            txtBoxRoomType.Text = row["Room_Type"].ToString();
            txtBoxTotalDays.Text = row["TotalDays"].ToString();
            txtBoxRatePerDay.Text = row["RoomRate"].ToString();
            txtBoxTotalAmount.Text = row["TotalAmount"].ToString();

            dateTimePickerCheckInDate.Value =
                Convert.ToDateTime(row["CheckInDate"]);

            dateTimePickerCheckOutDate.Value =
                Convert.ToDateTime(row["ExpectedCheckOutDate"]);
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxClientID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddReservation_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePickerPaymentDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tabControlBillsAndPayment_Enter(object sender, EventArgs e)
        {

        }

        private void tabPageSelectBilling_Enter(object sender, EventArgs e)
        {
            string query = @"
                SELECT
                    CheckInOut_ID,
                    Reservation_ID,
                    ClientName,
                    Room_Number,
                    Room_Type,
                    TotalDays,
                    TotalAmount,
                    PaymentStatus
                FROM CheckInOut_Table
                WHERE Status = 'CheckedOut'";

            db.DisplayAndSearch(query, dataGridViewBilling);
        }

        private void dataGridViewBilling_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;

            selectedBillingRow = dataGridViewBilling.Rows[e.RowIndex];

            checkInOutID = Convert.ToInt32(selectedBillingRow.Cells[0].Value);
            reservationID = Convert.ToInt32(selectedBillingRow.Cells[1].Value);
            totalAmount = Convert.ToDecimal(selectedBillingRow.Cells[6].Value);

            
            tabControlBillsAndPayment.SelectedTab = tabPageBilling;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {

            if (selectedBillingRow == null)
            {
                MessageBox.Show(
                    "Please select a billing record first.",
                    "Select Billing",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                return;
            }

            tabControlBillsAndPayment.SelectedTab = tabPageBilling;
        }

        private void tabPageBilling_Click(object sender, EventArgs e)
        {

        }

        private void tabPageBilling_Enter(object sender, EventArgs e)
        {
            LoadBillingDetails();
        }

        private void btnAddReservation_Click_1(object sender, EventArgs e)
        {
            if (checkInOutID == 0)
            {
                MessageBox.Show("Billing not loaded.");
                return;
            }

            tabControlBillsAndPayment.SelectedTab = tabPagePayment;
        }
    }
}
