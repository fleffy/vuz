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
    public partial class UserControlDashboard : UserControl
    {
        DbConnector db;
        public UserControlDashboard()
        {
            InitializeComponent();
            db = new DbConnector();
        }

        public void User()
        {
            labelUserCount.Text = db.Count("SELECT COUNT(*) FROM User_Table").ToString();
        }

        public void Employee()
        {
            labelEmployeeCount.Text = db.Count("SELECT COUNT(*) FROM Client_Table").ToString();
        }

        public void Parking()
        {
            labelParkingCount.Text = db.Count("SELECT COUNT(*) FROM Room_Table").ToString();
        }

        private void UserControlDashboard_Load(object sender, EventArgs e)
        {
            User();
            Employee();
            Parking();
        }
    }
}
