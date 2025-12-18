
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


namespace HotelReservationAndManagementSystem
{
    public partial class FormLogIn : Form
    {

        DBConnector1 db;
        public FormLogIn()
        {
            InitializeComponent();

            db = new DBConnector1();

          
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void FormLogIn_Load(object sender, EventArgs e)
        {

        }

        private void pictureBoxMinimize_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(PictureBoxMinimize, "Minimize");
        }

        private void pictureBoxClose_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(PictureBoxClose, "Close");
        }

        private void PictureBoxMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            bool check = db.IsValidNamePass(textBoxUserName.Text.Trim(), textBoxPassword.Text.Trim());

            if (textBoxUserName.Text.Trim() == string.Empty || textBoxPassword.Text.Trim() == string.Empty)
                MessageBox.Show("Please fill out all fields.", "Required field", MessageBoxButtons.OK, MessageBoxIcon.Information);

            else
            {
                if (check)
                {
                    Hotel fd = new Hotel();
                    fd.Username = textBoxUserName.Text;
                    textBoxUserName.Clear();
                    textBoxPassword.Clear();

                    fd.Show();
                }
                else

                    MessageBox.Show("Invalid User name or password", "Username or password", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
            
        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void labelForgotPassword_Click(object sender, EventArgs e)
        {

        }

        private void textBoxUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelUserName_Click(object sender, EventArgs e)
        {


        }

        private void pictureBoxShow_Click(object sender, EventArgs e)
        {
            pictureBoxShow.Hide();
            textBoxPassword.UseSystemPasswordChar =false; 
            pictureBoxHide.Show();
        }

        private void pictureBoxShow_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxShow, "Show Password");
        }

        private void pictureBoxHide_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxHide, "Hide Password");
        }

        private void pictureBoxHide_Click(object sender, EventArgs e)
        {
            pictureBoxHide.Hide();
            textBoxPassword.UseSystemPasswordChar = true;
            pictureBoxShow.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
