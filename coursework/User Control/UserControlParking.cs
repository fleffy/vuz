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
    public partial class UserControlParking : UserControl
    {
        DbConnector db;
        private string ID = "", Free = "";
        public UserControlParking()
        {
            InitializeComponent();
            db = new DbConnector();
        }

        public void Clear()
        {
            comboBoxType.SelectedIndex = -1;
            textBoxCommentary.Clear();
            radioButtonYes.Checked = false;
            radioButtonNo.Checked = false;
            tabControlParking.SelectedTab = tabPageAddParking;
        }

        private void Clear1()
        {
            comboBoxType1.SelectedIndex = -1;
            textBoxCommentary1.Clear();
            radioButtonYes1.Checked = false;
            radioButtonNo1.Checked = false;
            ID = "";
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (radioButtonYes.Checked)
                Free = "Yes";
            if (radioButtonNo.Checked)
                Free = "No";
            bool check;
            if (comboBoxType.SelectedIndex == -1 || textBoxCommentary.Text.Trim() == string.Empty || Free == "")
            {
                MessageBox.Show("Please fill all fields", "Require all fields", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                check = db.AddRoom(comboBoxType.SelectedItem.ToString(), textBoxCommentary.Text.Trim(), Free);
                if (check)
                    Clear();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabPageAddParking_Leave(object sender, EventArgs e)
        {
            Clear();
            Clear1();
        }

        private void tabPageSearchParking_Enter(object sender, EventArgs e)
        {
            db.DisplayAndSearch("SELECT * FROM Room_Table", dataGridViewParking);
        }

        private void tabPageSearchParking_Leave(object sender, EventArgs e)
        {
            textBoxSearchClientID.Clear();
        }

        private void textBoxSearchParkingID_TextChanged(object sender, EventArgs e)
        {
            db.DisplayAndSearch("SELECT * FROM Room_Table WHERE Room_Number LIKE '%" + textBoxSearchClientID.Text + "%'", dataGridViewParking);
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (radioButtonYes1.Checked)
                Free = "Yes";
            if (radioButtonNo1.Checked)
                Free = "No";
            bool check;
            if (ID != "")
            {
                if (comboBoxType1.SelectedIndex == -1 || textBoxCommentary1.Text.Trim() == string.Empty || Free == "")
                {
                    MessageBox.Show("Please fill all fields", "Require all fields", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    check = db.UpdateRoom(ID, comboBoxType1.SelectedItem.ToString(),textBoxCommentary1.Text.Trim(), Free);
                    if (check)
                        Clear1();
                }
            }
            else
            {
                MessageBox.Show("Please first select row from table", "Select row", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (radioButtonYes1.Checked)
                Free = "Yes";
            if (radioButtonNo1.Checked)
                Free = "No";
            bool check;
            if (ID != "")
            {
                if (comboBoxType1.SelectedIndex == -1 || textBoxCommentary1.Text.Trim() == string.Empty || Free == "")
                {
                    MessageBox.Show("Please fill all fields", "Require all fields", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    check = db.DeleteRoom(ID);
                    if (check)
                        Clear1();
                }
            }
            else
            {
                MessageBox.Show("Select item from columns", "Please Select!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridViewParking_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridViewParking.Rows[e.RowIndex];
                ID = row.Cells[0].Value.ToString();
                comboBoxType1.SelectedItem = row.Cells[1].Value.ToString();
                textBoxCommentary1.Text = row.Cells[2].Value.ToString();
                Free = row.Cells[3].Value.ToString();
                if (Free == "Yes")
                    radioButtonYes1.Checked = true;
                if (Free == "No")
                    radioButtonNo1.Checked = true;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
