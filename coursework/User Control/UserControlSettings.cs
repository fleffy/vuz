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

namespace car_parking_manager.User_Control
{
    public partial class UserControlSettings : UserControl
    {
        DbConnector db;
        private string ID = "";
        public UserControlSettings()
        {
            InitializeComponent();
            db = new DbConnector();
        }
        
        public void Clear()
        {
            textBoxUsername.Clear();
            textBoxPassword.Clear();
            tabControlUser.SelectedTab = tabPageAddUser;
        }

        private void Clear1()
        {
            textBoxUsername1.Clear();
            textBoxPassword1.Clear();
            ID = "";
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabControlUser_Leave(object sender, EventArgs e)
        {
            Clear();
        }

        private void tabPageSearchUser_Enter(object sender, EventArgs e)
        {
            db.DisplayAndSearch("SELECT * FROM User_Table", dataGridViewUser);
        }

        private void tabPageSearchUser_Leave(object sender, EventArgs e)
        {
            textBoxSearchUsername.Clear();
        }

        private void tabPageUpdateOrDeleteUser_Leave(object sender, EventArgs e)
        {
            Clear1();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            bool check;
            if (textBoxUsername.Text.Trim() == string.Empty || textBoxPassword.Text.Trim() == string.Empty)
                MessageBox.Show("Please fill all fields", "Require all fields", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                check = db.AddUser(textBoxUsername.Text.Trim(), textBoxPassword.Text.Trim());
                if (check)
                    Clear();
            }
        }

        private void dataGridViewUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
               DataGridViewRow row = dataGridViewUser.Rows[e.RowIndex];
               ID = row.Cells[0].Value.ToString();
               textBoxUsername1.Text = row.Cells[1].Value.ToString();
               textBoxPassword1.Text = row.Cells[2].Value.ToString();
            } else
            {
                MessageBox.Show("Click other row!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            bool check;
            if(ID != "")
            {
                if (textBoxUsername1.Text.Trim() == string.Empty || textBoxPassword1.Text.Trim() == string.Empty)
                    MessageBox.Show("Please fill all fields", "Require all fields", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    check = db.UpdateUser(ID, textBoxUsername1.Text.Trim(), textBoxPassword1.Text.Trim());
                    if (check)
                        Clear1();
                }
            } else
            {
                MessageBox.Show("Please first select row from table", "Select row", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            bool check;
            if (ID != "")
            {
                if (textBoxUsername1.Text.Trim() == string.Empty || textBoxPassword1.Text.Trim() == string.Empty)
                    MessageBox.Show("Please fill all fields", "Require all fields", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    check = db.DeleteUser(ID);
                    if (check)
                        Clear1();
                }
            }
            else
            {
                MessageBox.Show("Please first select row from table", "Select row", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void textBoxSearchUsername_TextChanged(object sender, EventArgs e)
        {
            db.DisplayAndSearch("SELECT * FROM User_Table WHERE User_Name LIKE '%" + textBoxSearchUsername.Text + "%'", dataGridViewUser);
        }
    }
}
