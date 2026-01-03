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

        DBConnector1 db;

        private DataGridViewRow selectedBillingRow = null;

        private decimal paymentTotalAmount;
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

        private void ConfigureBillingGrid()
        {
            dataGridViewBilling.AutoGenerateColumns = false;
            dataGridViewBilling.AllowUserToAddRows = false;
            dataGridViewBilling.ReadOnly = true;
            dataGridViewBilling.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewBilling.MultiSelect = false;

            dataGridViewBilling.Columns.Clear();

            dataGridViewBilling.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "CheckInOut_ID",
                DataPropertyName = "CheckInOut_ID",
                Visible = false
            });
            dataGridViewBilling.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Reservation_ID",
                DataPropertyName = "Reservation_ID",
                HeaderText = "Reservation",
                Width = 90
            });

            dataGridViewBilling.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ClientName",
                DataPropertyName = "ClientName",
                HeaderText = "Client Name",
                Width = 150
            });

            dataGridViewBilling.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Room_Number",
                DataPropertyName = "Room_Number",
                HeaderText = "Room No",
                Width = 80
            });

            dataGridViewBilling.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Room_Type",
                DataPropertyName = "Room_Type",
                HeaderText = "Room Type",
                Width = 90
            });

            dataGridViewBilling.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "TotalDays",
                DataPropertyName = "TotalDays",
                HeaderText = "Days",
                Width = 60
            });

            dataGridViewBilling.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "TotalAmount",
                DataPropertyName = "TotalAmount",
                HeaderText = "Total Amount",
                Width = 110,
                DefaultCellStyle =
        {
            Format = "C2",
            Alignment = DataGridViewContentAlignment.MiddleRight
        }
            });

            dataGridViewBilling.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "PaymentStatus",
                DataPropertyName = "PaymentStatus",
                HeaderText = "Payment",
                Width = 90
            });
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

            selectedBillingRow = dataGridViewBilling.Rows[e.RowIndex];

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
            ConfigureBillingGrid();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
           
            if (checkInOutID == 0 || reservationID == 0)
            {
                MessageBox.Show("No billing selected.");
                return;
            }

            if (string.IsNullOrWhiteSpace(comboBoxPaymentMethod.Text))
            {
                MessageBox.Show("Please select a payment method.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtBoxAmountPaid.Text))
            {
                MessageBox.Show("Please enter amount paid.");
                return;
            }

            if (!decimal.TryParse(txtBoxAmountPaid.Text, out decimal amountPaid))
            {
                MessageBox.Show("Invalid amount paid.");
                return;
            }

            if (amountPaid < totalAmount)
            {
                MessageBox.Show("Amount paid is insufficient.");
                return;
            }

            
            decimal changeAmount = amountPaid - totalAmount;
            txtBoxChange.Text = changeAmount.ToString("0.00");

            int clientId = db.GetClientIdFromReservation(reservationID);
            if (clientId == 0)
            {
                MessageBox.Show("Client not found.");
                return;
            }

            bool paymentSaved = db.AddPayment(
                checkInOutID,
                reservationID,
                clientId,
                totalAmount,
                amountPaid,
                changeAmount,
                comboBoxPaymentMethod.Text
            );

            if (!paymentSaved)
            {
                MessageBox.Show("Payment failed.");
                return;
            }

            db.UpdateCheckInOutPaymentStatus(checkInOutID);

          
            lblPaymentStatus.Text = "Paid";
            lblPaymentStatus.ForeColor = Color.Green;

            MessageBox.Show("Payment completed successfully.");

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
