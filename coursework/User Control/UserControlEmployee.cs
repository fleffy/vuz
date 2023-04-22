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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace car_parking_manager.User_Control
{
    public partial class UserControlEmployee : UserControl
    {
        DbConnector db;
        public UserControlEmployee()
        {
            InitializeComponent();
            db = new DbConnector();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        
        public void Clear()
        {
            textBoxFirstName.Clear();
            textBoxLastName.Clear();
            textBoxPhoneNumber.Clear();
            tabControlEmployee.SelectedTab = tabPageAddEmployee;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            bool check;
            if(textBoxFirstName.Text.Trim() == string.Empty || textBoxLastName.Text.Trim() == string.Empty || textBoxPhoneNumber.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please fill all fields", "Require all fields", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                check = db.AddClient(textBoxFirstName.Text.Trim(), textBoxLastName.Text.Trim(), textBoxPhoneNumber.Text.Trim(), "");
                if (check)
                    Clear();
            }
        }
        private void tabPageAddEmployee_Leave(object sender, EventArgs e)
        {
            Clear();
        }

        private void tabPageSearchEmployee_Enter(object sender, EventArgs e)
        {
            db.DisplayAndSearch("SELECT * FROM Client_Table", dataGridViewEmployee);
        }

        private void tabPageSearchEmployee_Leave(object sender, EventArgs e)
        {
            textBoxSearchFirstName.Clear();
        }

        private void textBoxSearchFirstName_TextChanged(object sender, EventArgs e)
        {
            db.DisplayAndSearch("SELECT * FROM Client_Table WHERE Client_FirstName LIKE '%" + textBoxSearchFirstName.Text + "%'", dataGridViewEmployee);
        }


        private void dataGridViewEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void tabPageSearchEmployee_Click(object sender, EventArgs e)
        {

        }

        private void tabPageAddEmployee_Click(object sender, EventArgs e)
        {

        }
    }
}
