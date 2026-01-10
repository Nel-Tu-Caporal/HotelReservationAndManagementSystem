using HotelReservationAndManagementSystem.Interface;
using HotelReservationAndManagementSystem.Interface.Services;
using HotelReservationAndManagementSystem.Models.Services;
using HotelReservationAndManagementSystem.References;
using HotelReservationAndManagementSystem.Repo;
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

    public partial class UserControlPayment : UserControl
    {
        private IPaymentService _paymentService;
        

        private int checkInOutId;
        private int reservationId;
        private decimal totalAmount;

       
        public UserControlPayment()
        {
            InitializeComponent();
            DBConnector1 db = new DBConnector1();
            IPaymentRepository repo = new PaymentRepository(db);
            IPaymentService service = new PaymentService(repo);

            SetPaymentService(service);
        }

        public void SetPaymentService(IPaymentService service)
        {
            _paymentService = service;
        }

        private void RefreshBillingGrid()
        {
            if (_paymentService == null)
                return;

            ConfigureBillingGrid();
            SetupBillingGridColumns();
            LoadBillingList();
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
            if (_paymentService == null)
                return;

            DataTable dt = _paymentService.GetCheckedOutBillingList();

            dataGridViewBilling.DataSource = null;
            dataGridViewBilling.AutoGenerateColumns = true;
            dataGridViewBilling.DataSource = dt;
        }
        private void LoadBillingDetails(int reservationId)
        {
            if (_paymentService == null)
                return;

            DataTable dt = _paymentService.GetBillingDetails(reservationId);

            if (dt == null || dt.Rows.Count == 0)
                return;

            dataGridViewBilling.DataSource = dt;
        }

        private void ConfigureBillingGrid()
        {
            dataGridViewBilling.AutoGenerateColumns = false;
            dataGridViewBilling.ReadOnly = true;
            dataGridViewBilling.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewBilling.MultiSelect = false;
            dataGridViewBilling.MultiSelect = false;
        }

        private void SetupBillingGridColumns()
        {
            dataGridViewBilling.Columns.Clear();

            dataGridViewBilling.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Reservation ID",
                DataPropertyName = "Reservation_ID"
            });

            dataGridViewBilling.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Client",
                DataPropertyName = "ClientName"
            });

            dataGridViewBilling.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Room No",
                DataPropertyName = "Room_Number"
            });

            dataGridViewBilling.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Room Type",
                DataPropertyName = "Room_Type"
            });

            dataGridViewBilling.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Check In",
                DataPropertyName = "CheckInDate"
            });

            dataGridViewBilling.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Check Out",
                DataPropertyName = "ActualCheckOutDate"
            });

            dataGridViewBilling.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Total Days",
                DataPropertyName = "TotalDays"
            });

            dataGridViewBilling.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Room Rate",
                DataPropertyName = "RoomRate",
                DefaultCellStyle = { Format = "N2" }
            });

            dataGridViewBilling.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Total Amount",
                DataPropertyName = "TotalAmount",
                DefaultCellStyle = { Format = "N2" }
            });

            dataGridViewBilling.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Payment Status",
                DataPropertyName = "PaymentStatus"
            });

           
            dataGridViewBilling.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "CheckInOut_ID",
                Visible = false
            });
        }
        private void LoadSelectedBilling(DataRowView drv)
        {
            if (drv == null) return;

            checkInOutId = Convert.ToInt32(drv["CheckInOut_ID"]);
            reservationId = Convert.ToInt32(drv["Reservation_ID"]);
            totalAmount = Convert.ToDecimal(drv["TotalAmount"]);

            txtBoxSearchReservationID.Text = reservationId.ToString();
            txtBoxTotalAmount.Text = totalAmount.ToString("0.00");

            txtBoxRoomType.Text = drv["Room_Type"].ToString();
            txtBoxRoomNo.Text = drv["Room_Number"].ToString();
            txtBoxTotalDays.Text = drv["TotalDays"].ToString();
            txtBoxRatePerDay.Text = drv["RoomRate"].ToString();

            lblPaymentStatus.Text = "UNPAID";
            lblPaymentStatus.ForeColor = Color.Red;


            if (drv["CheckInDate"] != DBNull.Value)
                dateTimePickerCheckInDate.Value = Convert.ToDateTime(drv["CheckInDate"]);

            if (drv["ActualCheckOutDate"] != DBNull.Value)
                dateTimePickerCheckOutDate.Value = Convert.ToDateTime(drv["ActualCheckOutDate"]);
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
            RefreshBillingGrid();
            Clear();
        }
        private void dataGridViewBilling_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dataGridViewBilling.Rows.Count == 0) return;

            DataGridViewRow row = dataGridViewBilling.Rows[e.RowIndex];

            if (row == null || row.DataBoundItem == null)
                return;

            DataRowView drv = row.DataBoundItem as DataRowView;
            if (drv == null) return;

            LoadSelectedBilling(drv);
        }


        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (dataGridViewBilling.Rows.Count == 0)
            {
                MessageBox.Show(
                    "No billing records available.",
                    "Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                return;
            }

            if (dataGridViewBilling.CurrentRow == null ||
                dataGridViewBilling.CurrentRow.DataBoundItem == null)
            {
                MessageBox.Show("Please select a record first.");
                return;
            }

            DataRowView drv =
                dataGridViewBilling.CurrentRow.DataBoundItem as DataRowView;

            if (drv == null) return;

            LoadSelectedBilling(drv);
            tabControlBillsAndPayment.SelectedTab = tabPageBilling;
        }

        private void tabPageBilling_Click(object sender, EventArgs e)
        {

        }

        private void tabPageBilling_Enter(object sender, EventArgs e)
        {
            if (dataGridViewBilling.CurrentRow == null) return;

            DataRowView drv =
                dataGridViewBilling.CurrentRow.DataBoundItem as DataRowView;

            if (drv == null) return;

            LoadSelectedBilling(drv);
        }

        private void btnAddReservation_Click_1(object sender, EventArgs e)
        {
            if (checkInOutId == 0)
            {
                MessageBox.Show("Billing not loaded.");
                return;
            }

            txtBoxTotalAmount1.Text = totalAmount.ToString("0.00");
            txtBoxAmountPaid.Clear();
            txtBoxChange.Clear();
            comboBoxPaymentMethod.SelectedIndex = -1;

            lblPaymentStatus.Text = "Unpaid";
            lblPaymentStatus.ForeColor = Color.Red;

            tabControlBillsAndPayment.SelectedTab = tabPagePayment;
        }


        // private void UserControlBillsAndPayment_Load(object sender, EventArgs e)
        //{
        // if (IsDesignMode() || _paymentService == null)
        //    return;

        // ConfigureBillingGrid();
        // LoadBillingList();
        // }
        private void UserControlPayment_Load(object sender, EventArgs e)
        {
            if (IsDesignMode())
                return;

            RefreshBillingGrid();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtBoxAmountPaid.Text, out decimal paid))
            {
                MessageBox.Show("Invalid payment amount.");
                return;
            }

            if (string.IsNullOrWhiteSpace(comboBoxPaymentMethod.Text))
            {
                MessageBox.Show("Select payment method.");
                return;
            }

            if (paid < totalAmount)
            {
                MessageBox.Show("Amount paid is less than total amount.");
                return;
            }

            bool success = _paymentService.ProcessPayment(
                checkInOutId,
                reservationId,
                totalAmount,
                paid,
                comboBoxPaymentMethod.Text
            );

            if (!success)
            {
                MessageBox.Show("Payment failed.");
                return;
            }

            decimal change = paid - totalAmount;
            txtBoxChange.Text = change.ToString("0.00");

            lblPaymentStatus.Text = "PAID";
            lblPaymentStatus.ForeColor = Color.Green;
            lblPaymentStatus.Font = new Font(lblPaymentStatus.Font, FontStyle.Bold);

            MessageBox.Show("Payment successful.");

            LoadBillingList();
            tabControlBillsAndPayment.SelectedTab = tabPageSelectBilling;
        }
        

        private void btnCancel_Click(object sender, EventArgs e)
        {
            comboBoxPaymentMethod.SelectedIndex = -1;
            txtBoxAmountPaid.Clear();
            txtBoxChange.Clear();

            lblPaymentStatus.Text = "UNPAID";
            lblPaymentStatus.ForeColor = Color.Red;
            lblPaymentStatus.Font = new Font(lblPaymentStatus.Font, FontStyle.Regular);

            tabControlBillsAndPayment.SelectedTab = tabPageBilling;
        }

        private void txtBoxSearchReservationID_TextChanged(object sender, EventArgs e)
        {
            if (dataGridViewBilling.DataSource == null)
                return;

            string searchText = txtBoxSearchReservationID.Text.Trim();

            DataTable dt = dataGridViewBilling.DataSource as DataTable;
            if (dt == null)
                return;

            if (string.IsNullOrEmpty(searchText))
            {
                dt.DefaultView.RowFilter = string.Empty;
            }
            else
            {
                // Reservation_ID must be INT in database
                dt.DefaultView.RowFilter = $"Convert(Reservation_ID, 'System.String') LIKE '{searchText}%'";
            }
        }
    }
}
