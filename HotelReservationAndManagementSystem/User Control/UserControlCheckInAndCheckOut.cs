using HotelReservationAndManagementSystem.Interface.Services;
using HotelReservationAndManagementSystem.Models.Services;
using HotelReservationAndManagementSystem.References;
using HotelReservationAndManagementSystem.Repo;
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

namespace HotelReservationAndManagementSystem.User_Control { 

    public partial class UserControlCheckInAndCheckOut : UserControl
{
    private int selectedReservationId = 0;
    private int selectedCheckInOutId = 0;
    private int selectedRoomNumber = 0;
        private ICheckInOutService _checkInOutService;

        // REQUIRED for WinForms Designer
        public UserControlCheckInAndCheckOut()
        {
            InitializeComponent();
        }

        // Your real constructor
        public UserControlCheckInAndCheckOut(ICheckInOutService service)
        {
            InitializeComponent();
            _checkInOutService = service;
        }


        public void Clear()
        {
            ClearDisplay();
        }

        private void ClearDisplay()
        {
            selectedReservationId = 0;
            selectedCheckInOutId = 0;
            selectedRoomNumber = 0;

            lblCheckInOutDate.Text = "?";
            lblTotalDaysStayed.Text = "?";
            lblRoomRates.Text = "?";
            lblTotalAmount.Text = "?";
        }

        private void LoadCheckInList()
        {
            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime)
                return;

            if (_checkInOutService == null)
                return; // <-- prevents crash
        }
        public void SetService(ICheckInOutService service)
        {
            _checkInOutService = service;
            LoadCheckInList();
        }

        private bool IsDesignMode()
        {
            return LicenseManager.UsageMode == LicenseUsageMode.Designtime;
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

            selectedCheckInOutId = Convert.ToInt32(row.Cells["CheckInOut_ID"].Value);
            selectedReservationId = Convert.ToInt32(row.Cells["Reservation_ID"].Value);
            selectedRoomNumber = Convert.ToInt32(row.Cells["Room_Number"].Value);

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
            if (_checkInOutService == null)
            {
                MessageBox.Show("Service not initialized.");
                return;
            }

            if (selectedReservationId == 0)
            {
                MessageBox.Show("Select a checked-in record first.");
                return;
            }

            if (_checkInOutService.CheckOut(selectedReservationId))
            {
                LoadCheckInList();
                ClearDisplay();
            }
        }



        private void UserControlCheckInAndCheckOut_Load(object sender, EventArgs e)
        {
            if (IsDesignMode() || _checkInOutService == null)
                return;

          
            ClearDisplay();
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
            
        }

        private void tabControlCheckInCheckOut_Enter(object sender, EventArgs e)
        {
        }

        private void btnUpdateCheckIn_Click(object sender, EventArgs e)
        {
           
        }

        private void btnCancelCheckIn_Click(object sender, EventArgs e)
        {
            if (_checkInOutService == null)
            {
                MessageBox.Show("Service not initialized.");
                return;
            }

            if (selectedCheckInOutId == 0)
            {
                MessageBox.Show("Select a check-in first.");
                return;
            }

            if (_checkInOutService.CancelCheckIn(selectedCheckInOutId, selectedRoomNumber))
            {
                LoadCheckInList();
                ClearDisplay();
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
