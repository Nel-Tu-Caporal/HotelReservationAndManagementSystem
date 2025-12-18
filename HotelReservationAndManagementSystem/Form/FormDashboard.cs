using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelReservationAndManagementSystem
{
    public partial class Hotel : Form
    {

        public string Username;
        public Hotel()
        {
            InitializeComponent();
        }

        private void MovePanel(Control btn)
        {
            panelSlide.Top = btn.Top;
            panelSlide.Height = btn.Height;
        }

        private void FormDashboard_Load(object sender, EventArgs e)
        {
            

            timer1.Start();
            labelUserName.Text = Username;
        }

       

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void labelDateAndTime_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelUserName_Click(object sender, EventArgs e)
        {

        }

        private void buttonClient_Click(object sender, EventArgs e)
        {
            MovePanel(buttonClient);
            userControlSetting1.Hide();
            userControlSetting1.Hide();
            userControlClient1.Clear();
            userControlClient1.Show();
        }

        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            MovePanel(buttonDashboard);
            userControlSetting1.Hide();
             userControlSetting1.Hide();
            userControlClient1.Hide();
        }

        private void buttonRoom_Click(object sender, EventArgs e)
        {
            MovePanel(buttonRoom);
            userControlSetting1.Hide();
              userControlSetting1.Hide();
            userControlClient1.Hide();
        }

        private void buttonReservation_Click(object sender, EventArgs e)
        {
            MovePanel(buttonReservation);
            userControlSetting1.Hide();
             userControlSetting1.Hide();
            userControlClient1.Hide();
        }

        private void buttonCheckInCheckOut_Click(object sender, EventArgs e)
        {
            MovePanel(buttonCheckInCheckOut);
            userControlSetting1.Hide();
             userControlSetting1.Hide();
            userControlClient1.Hide();
        }

        private void buttonBillAndPayment_Click(object sender, EventArgs e)
        {
            MovePanel(buttonBillAndPayment);
            userControlSetting1.Hide();
              userControlSetting1.Hide();
            userControlClient1.Hide();
        }

        private void buttonSetting_Click(object sender, EventArgs e)
        {
            MovePanel(buttonSetting);
            userControlSetting1.Show();
            userControlSetting1.Clear();
            userControlSetting1.Show();
            

        }

        private void panelSlide_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelDateAndTime.Text = DateTime.Now.ToString("dd-MMM-yyyy hh:mm:ss tt");
        }

        private void linkLabelLogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabelLogOut.Enabled = true;
            linkLabelLogOut.Visible = true;
            linkLabelLogOut.BringToFront();

            DialogResult result = MessageBox.Show("Are you want to log out?", "Log out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (DialogResult.Yes == result)
            {
                timer1.Stop();
                this.Close();
            }
        
    
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void userControlSetting1_Load(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void userControlSetting1_Load_1(object sender, EventArgs e)
        {

        }

        private void userControlClient1_Load(object sender, EventArgs e)
        {

        }
    }
}
