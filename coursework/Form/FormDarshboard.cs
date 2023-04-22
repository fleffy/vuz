using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace car_parking_manager
{
    public partial class FormDarshboard : Form
    {
        public string Username;
        public FormDarshboard()
        {
            InitializeComponent();
        }

        private void MovePanel(Control btn)
        {
            panelSlide.Top = btn.Top;
            panelSlide.Height = btn.Height;
        }

        private void FormDarshboard_Load(object sender, EventArgs e)
        {
            timer1.Start();
            labelUsername.Text = Username;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(DialogResult.Yes == result)
            {
                timer1.Stop();
                this.Close();
            };
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            MovePanel(buttonSettings);
            userControlParking1.Hide();
            userControlEmployee1.Hide();
            userControlBooking1.Hide();
            userControlDashboard1.Hide();
            userControlSettings1.Clear();
            userControlSettings1.Show();
        }

        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            MovePanel(buttonDashboard);
            userControlSettings1.Hide();
            userControlEmployee1.Hide();
            userControlParking1.Hide();
            userControlBooking1.Hide();
            userControlDashboard1.Show();
        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint_2(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelDateTime.Text = DateTime.Now.ToString("dd-MMM-yyyy hh:mm:ss tt");
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonEmployee_Click(object sender, EventArgs e)
        {
            MovePanel(buttonEmployee);
            userControlSettings1.Hide();
            userControlParking1.Hide();
            userControlBooking1.Hide();
            userControlDashboard1.Hide();
            userControlEmployee1.Clear();
            userControlEmployee1.Show();
        }

        private void buttonParking_Click(object sender, EventArgs e)
        {
            MovePanel(buttonParking);
            userControlSettings1.Hide();
            userControlEmployee1.Hide();
            userControlDashboard1.Hide();
            userControlBooking1.Hide();
            userControlParking1.Clear();
            userControlParking1.Show();
        }

        private void buttonBooking_Click(object sender, EventArgs e)
        {
            MovePanel(buttonBooking);
            userControlSettings1.Hide();
            userControlEmployee1.Hide();
            userControlDashboard1.Hide();
            userControlParking1.Hide();
            userControlBooking1.Clear();
            userControlBooking1.Show();
        }

        private void labelDateTime_Click(object sender, EventArgs e)
        {

        }

        private void userControlSettings1_Load(object sender, EventArgs e)
        {

        }

        private void userControlEmployee1_Load(object sender, EventArgs e)
        {

        }
    }
}
