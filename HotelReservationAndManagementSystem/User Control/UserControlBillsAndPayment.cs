using HotelReservationAndManagementSystem.Interface.Services;
using HotelReservationAndManagementSystem.References;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelReservationAndManagementSystem.User_Control
{

    public partial class UserControlBillsAndPayment : UserControl
    {
        private IPaymentService _paymentService;

        private int reservationId = 0;
        private int checkInOutId = 0;
        private decimal totalAmount = 0;

       
        public UserControlBillsAndPayment()
        {
            InitializeComponent();
        }

        public void SetService(IPaymentService service)
        {
            _paymentService = service;
        }
         private bool IsDesignMode()
        {
            return LicenseManager.UsageMode == LicenseUsageMode.Designtime;
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
        private void LoadBillingList()
        {
            DataTable dt = _paymentService.GetCheckedOutList();
            dataGridViewBilling.DataSource = dt;
        }
        private void LoadBillingDetails(int reservationId)
        {
            DataTable dt = _paymentService.GetBillingDetails(reservationId);
            dataGridViewBillingDetails.DataSource = dt;
        }

        private void ConfigureBillingGrid()
        {
            dataGridViewBilling.AutoGenerateColumns = true;
            dataGridViewBilling.ReadOnly = true;
            dataGridViewBilling.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewBilling.MultiSelect = false;
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

        private void txtBoxAmountPaid_TextChanged(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtBoxAmountPaid.Text, out decimal paid))
            {
                txtBoxChange.Clear();
                return;
            }

            if (paid >= totalAmount)
                txtBoxChange.Text = (paid - totalAmount).ToString("0.00");
            else
                txtBoxChange.Text = "0.00";
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

            ConfigureBillingGrid();

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

            DataTable dt = new DataTable();

            using (SqlConnection con = new SqlConnection(
                "Data Source=.\\SQLEXPRESS;Initial Catalog=Hotel_Management_System;Integrated Security=true"))
            using (SqlDataAdapter da = new SqlDataAdapter(query, con))
            {
                da.Fill(dt);
            }

            dataGridViewBilling.DataSource = dt;
        }

        private void dataGridViewBilling_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataRowView drv =
                dataGridViewBilling.Rows[e.RowIndex].DataBoundItem as DataRowView;

            if (drv == null) return;

            checkInOutId = Convert.ToInt32(drv["CheckInOut_ID"]);
            reservationId = Convert.ToInt32(drv["Reservation_ID"]);
            totalAmount = Convert.ToDecimal(drv["TotalAmount"]);

            txtBoxTotalAmount.Text = totalAmount.ToString("0.00");

            LoadBillingDetails(reservationId);
            tabControlBillsAndPayment.SelectedTab = tabPageBilling;
        }


        private void btnSelect_Click(object sender, EventArgs e)
        {



            if (dataGridViewBilling.CurrentRow == null)
            {
                MessageBox.Show("Please select a record first.");
                return;
            }

            tabControlBillsAndPayment.SelectedTab = tabPageBilling;
        }

        private void tabPageBilling_Click(object sender, EventArgs e)
        {

        }

        private void tabPageBilling_Enter(object sender, EventArgs e)
        {
            if (dataGridViewBilling.CurrentRow == null)
                return;

            
            DataRowView drv =
                dataGridViewBilling.CurrentRow.DataBoundItem as DataRowView;

            if (drv == null)
            {
                MessageBox.Show("Unable to read billing data.");
                return;
            }

        
            checkInOutID = Convert.ToInt32(drv["CheckInOut_ID"]);
            reservationID = Convert.ToInt32(drv["Reservation_ID"]);
            totalAmount = Convert.ToDecimal(drv["TotalAmount"]);

            txtBoxSearchReservationID.Text = reservationID.ToString();

            
            LoadBillingDetails();
        }

        private void btnAddReservation_Click_1(object sender, EventArgs e)
        {
            if (checkInOutID == 0)
            {
                MessageBox.Show("Billing not loaded.");
                return;
            }

            // store total for payment
            paymentTotalAmount = totalAmount;

            //  prepare payment UI
            txtBoxTotalAmount1.Text = paymentTotalAmount.ToString("0.00");
            txtBoxAmountPaid.Clear();        
            txtBoxChange.Clear();              
            comboBoxPaymentMethod.SelectedIndex = -1;
            lblPaymentStatus.Text = "Unpaid";
            lblPaymentStatus.ForeColor = Color.Red;


            tabControlBillsAndPayment.SelectedTab = tabPagePayment;
        }

        private void UserControlBillsAndPayment_Load(object sender, EventArgs e)
        {
            if (IsDesignMode() || _paymentService == null)
                return;

            ConfigureBillingGrid();
            LoadBillingList();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
           
           if (_paymentService == null)
            {
                MessageBox.Show("Service not initialized.");
                return;
            }

            if (checkInOutId == 0 || reservationId == 0)
            {
                MessageBox.Show("Select billing first.");
                return;
            }

            if (!decimal.TryParse(txtBoxAmountPaid.Text, out decimal paid))
            {
                MessageBox.Show("Invalid payment amount.");
                return;
            }

            if (paid < totalAmount)
            {
                MessageBox.Show("Insufficient amount.");
                return;
            }

            if (string.IsNullOrWhiteSpace(comboBoxPaymentMethod.Text))
            {
                MessageBox.Show("Select payment method.");
                return;
            }

            int clientId = _paymentService.GetClientIdFromReservation(reservationId);
            decimal change = paid - totalAmount;

            bool success = _paymentService.AddPayment(
                checkInOutId,
                reservationId,
                clientId,
                totalAmount,
                paid,
                change,
                comboBoxPaymentMethod.Text
            );

            if (!success)
            {
                MessageBox.Show("Payment failed.");
                return;
            }

            _paymentService.UpdateCheckInOutPaymentStatus(checkInOutId);

            MessageBox.Show("Payment successful.");

            Clear();
            LoadBillingList();
            tabControlBillsAndPayment.SelectedTab = tabPageSelectBilling;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            comboBoxPaymentMethod.SelectedIndex = -1;
            txtBoxAmountPaid.Clear();
            txtBoxChange.Clear();

            
            lblPaymentStatus.Text = "Unpaid";

            
            tabControlBillsAndPayment.SelectedTab = tabPageBilling;
        }
    }
}
