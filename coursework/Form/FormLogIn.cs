using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AMRConnector;

namespace car_parking_manager
{
    public partial class FormLogIn : Form
    {
        DbConnector db;
        public FormLogIn()
        {
            InitializeComponent();
            db = new DbConnector();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBoxClose_mouseHover(object sender, EventArgs e)
        {

        }

        private void pictureBoxMinimize_mouseHover(object sender, EventArgs e)
        {

        }

        private void pictureBoxMinimize_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxMinimize, "Minimize");
        }

        private void pictureBoxClose_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxClose, "Close");
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBoxMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool check = db.IsValidNamePass(textBoxUsername.Text.Trim(), textBoxPassword.Text.Trim());
            if (textBoxUsername.Text.Trim() == string.Empty || textBoxPassword.Text.Trim() == string.Empty)
                MessageBox.Show("Please fill out all  fields", "Required field", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                if(check)
                {
                    FormDarshboard fd = new FormDarshboard();
                    fd.Username = textBoxUsername.Text;
                    textBoxUsername.Clear();
                    textBoxPassword.Clear();
                    fd.Show();
                }
                else
                {
                    MessageBox.Show("Invalid Useraname or Password", "Username or Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBoxShow_mouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxShow, "Show Password");
        }

        private void pictureBoxHide_mouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxHide, "Hide Password");
        }

        private void pictureBoxShow_Click(object sender, EventArgs e)
        {
            pictureBoxShow.Hide();
            textBoxPassword.UseSystemPasswordChar = false;
            pictureBoxHide.Show();
        }

        private void pictureBoxHide_Click(object sender, EventArgs e)
        {
            pictureBoxHide.Hide();
            textBoxPassword.UseSystemPasswordChar = true;
            pictureBoxShow.Show();
        }
    }
}
