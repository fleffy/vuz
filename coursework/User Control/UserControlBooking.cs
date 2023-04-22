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
    public partial class UserControlBooking : UserControl
    {
        DbConnector db;
        private string RID = "", No;
        public UserControlBooking()
        {
            InitializeComponent();
            db = new DbConnector();
        }

        public void Clear()
        {
            comboBoxType.SelectedIndex = 0;
            comboBoxNo.SelectedIndex = 0;
            textBoxClientID.Clear();
            dateTimePickerIn.Value = DateTime.Now;
            dateTimePickerOut.Value = DateTime.Now;
            tabControlBooking.SelectedTab = tabPageAddBooking;
        }

        private void Clear1()
        {
            comboBoxType1.SelectedIndex = 0;
            comboBoxNo1.SelectedIndex = 0;
            textBoxClientID1.Clear();
            dateTimePickerIn1.Value = DateTime.Now;
            dateTimePickerOut1.Value = DateTime.Now;
            RID = "";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void UserControlBooking_Load(object sender, EventArgs e)
        {
            comboBoxType.SelectedIndex = 0;
            comboBoxType1.SelectedIndex = 0;
            comboBoxNo.SelectedIndex = 0;
            comboBoxNo1.SelectedIndex = 0;
        }

        private void tabPageAddBooking_Leave(object sender, EventArgs e)
        {
            Clear();
            Clear1();
        }

        private void buttonAdd_Click_1(object sender, EventArgs e)
        {
            bool check;
            if (comboBoxType.SelectedIndex == 0 || comboBoxNo.SelectedIndex == 0 || textBoxClientID.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please fill all fields", "Require all fields", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                check = db.AddReservation(comboBoxType.SelectedItem.ToString(), comboBoxNo.SelectedItem.ToString(), textBoxClientID.Text.Trim(), dateTimePickerIn.Text, dateTimePickerOut.Text);
                db.UpdateReservationRoom(comboBoxNo.SelectedItem.ToString(), "No");
                if (check)
                    Clear();
            }
        }

        private void tabPageSearchBooking_Enter(object sender, EventArgs e)
        {
            db.DisplayAndSearch("SELECT * FROM Reservation_Table", dataGridViewBooking);
        }

        private void tabPageSearchBooking_Leave(object sender, EventArgs e)
        {
            textBoxSearchClientID.Clear();
        }

        private void textBoxSearchClientID_TextChanged(object sender, EventArgs e)
        {
            db.DisplayAndSearch("SELECT * FROM Reservation_Table WHERE Reservation_Client_ID LIKE '%" + textBoxSearchClientID.Text + "%'", dataGridViewBooking);
        }

        private void dataGridViewBooking_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridViewBooking.Rows[e.RowIndex];
                RID = row.Cells[0].Value.ToString();
                comboBoxType1.SelectedItem = row.Cells[1].Value.ToString();
                No = row.Cells[2].Value.ToString();
                textBoxClientID1.Text = row.Cells[3].Value.ToString();
                dateTimePickerIn1.Text = row.Cells[4].Value.ToString();
                dateTimePickerOut1.Text = row.Cells[5].Value.ToString();
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            bool check;
            if (RID != "")
            {
                if (comboBoxType1.SelectedIndex == 0 || comboBoxNo1.SelectedIndex == 0 || textBoxClientID1.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Please fill all fields", "Require all fields", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    check = db.UpdateReservation(RID, comboBoxType1.SelectedItem.ToString(), comboBoxNo1.SelectedItem.ToString(), textBoxClientID1.Text.Trim(), dateTimePickerIn1.Text, dateTimePickerOut1.Text);
                    db.UpdateReservationRoom(No, "Yes");
                    db.UpdateReservationRoom(comboBoxNo1.SelectedItem.ToString(), "No");
                    if (check)
                        Clear1();
                }
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            bool check;
            if (RID != "")
            {
                if (comboBoxType1.SelectedIndex == -1 || textBoxClientID1.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Please fill all fields", "Require all fields", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    check = db.DeleteReservation(RID);
                    db.UpdateReservationRoom(No, "Yes");
                    if (check)
                        Clear1();
                }
            }
            else
            {
                MessageBox.Show("Select item from columns", "Please Select!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tabPageUpdateOrCancelBooking_Leave(object sender, EventArgs e)
        {
            Clear1();
        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            db.RoomTypeAndNo("SELECT Room_Number FROM Room_Table WHERE Room_Type = '" + comboBoxType.SelectedItem.ToString() + "' AND Room_Free = 'Yes' ORDER BY Room_Number", comboBoxNo);
        }

        private void comboBoxType1_SelectedIndexChanged(object sender, EventArgs e)
        {
            db.RoomTypeAndNo("SELECT Room_Number FROM Room_Table WHERE Room_Type = '" + comboBoxType1.SelectedItem.ToString() + "' AND Room_Free = 'Yes' ORDER BY Room_Number", comboBoxNo1);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
