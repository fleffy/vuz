namespace car_parking_manager
{
    partial class FormDarshboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDarshboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelSlide = new System.Windows.Forms.Panel();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.buttonBooking = new System.Windows.Forms.Button();
            this.buttonParking = new System.Windows.Forms.Button();
            this.buttonEmployee = new System.Windows.Forms.Button();
            this.buttonDashboard = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.labelUsername = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.linkLabelLogOut = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.userControlDashboard1 = new car_parking_manager.User_Control.UserControlDashboard();
            this.userControlBooking1 = new car_parking_manager.User_Control.UserControlBooking();
            this.userControlParking1 = new car_parking_manager.User_Control.UserControlParking();
            this.userControlEmployee1 = new car_parking_manager.User_Control.UserControlEmployee();
            this.userControlSettings1 = new car_parking_manager.User_Control.UserControlSettings();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(40)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.panelSlide);
            this.panel1.Controls.Add(this.buttonSettings);
            this.panel1.Controls.Add(this.buttonBooking);
            this.panel1.Controls.Add(this.buttonParking);
            this.panel1.Controls.Add(this.buttonEmployee);
            this.panel1.Controls.Add(this.buttonDashboard);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(255, 720);
            this.panel1.TabIndex = 0;
            // 
            // panelSlide
            // 
            this.panelSlide.BackColor = System.Drawing.Color.Snow;
            this.panelSlide.Location = new System.Drawing.Point(47, 220);
            this.panelSlide.Name = "panelSlide";
            this.panelSlide.Size = new System.Drawing.Size(5, 35);
            this.panelSlide.TabIndex = 0;
            this.panelSlide.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint_1);
            // 
            // buttonSettings
            // 
            this.buttonSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSettings.FlatAppearance.BorderSize = 0;
            this.buttonSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSettings.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonSettings.Location = new System.Drawing.Point(50, 463);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(155, 44);
            this.buttonSettings.TabIndex = 5;
            this.buttonSettings.Text = "Settings";
            this.buttonSettings.UseVisualStyleBackColor = true;
            this.buttonSettings.Click += new System.EventHandler(this.button5_Click);
            // 
            // buttonBooking
            // 
            this.buttonBooking.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBooking.FlatAppearance.BorderSize = 0;
            this.buttonBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBooking.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonBooking.Location = new System.Drawing.Point(50, 400);
            this.buttonBooking.Name = "buttonBooking";
            this.buttonBooking.Size = new System.Drawing.Size(155, 44);
            this.buttonBooking.TabIndex = 4;
            this.buttonBooking.Text = "Booking";
            this.buttonBooking.UseVisualStyleBackColor = true;
            this.buttonBooking.Click += new System.EventHandler(this.buttonBooking_Click);
            // 
            // buttonParking
            // 
            this.buttonParking.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonParking.FlatAppearance.BorderSize = 0;
            this.buttonParking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonParking.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonParking.Location = new System.Drawing.Point(50, 339);
            this.buttonParking.Name = "buttonParking";
            this.buttonParking.Size = new System.Drawing.Size(155, 44);
            this.buttonParking.TabIndex = 3;
            this.buttonParking.Text = "Parking";
            this.buttonParking.UseVisualStyleBackColor = true;
            this.buttonParking.Click += new System.EventHandler(this.buttonParking_Click);
            // 
            // buttonEmployee
            // 
            this.buttonEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEmployee.FlatAppearance.BorderSize = 0;
            this.buttonEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEmployee.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonEmployee.Location = new System.Drawing.Point(50, 278);
            this.buttonEmployee.Name = "buttonEmployee";
            this.buttonEmployee.Size = new System.Drawing.Size(155, 44);
            this.buttonEmployee.TabIndex = 2;
            this.buttonEmployee.Text = "Employee";
            this.buttonEmployee.UseVisualStyleBackColor = true;
            this.buttonEmployee.Click += new System.EventHandler(this.buttonEmployee_Click);
            // 
            // buttonDashboard
            // 
            this.buttonDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDashboard.FlatAppearance.BorderSize = 0;
            this.buttonDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDashboard.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonDashboard.Location = new System.Drawing.Point(50, 216);
            this.buttonDashboard.Name = "buttonDashboard";
            this.buttonDashboard.Size = new System.Drawing.Size(155, 44);
            this.buttonDashboard.TabIndex = 1;
            this.buttonDashboard.Text = "Dashboard";
            this.buttonDashboard.UseVisualStyleBackColor = true;
            this.buttonDashboard.Click += new System.EventHandler(this.buttonDashboard_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(255, 200);
            this.panel3.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(40)))), ((int)(((byte)(204)))));
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(255, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1111, 164);
            this.panel4.TabIndex = 0;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panel5.Controls.Add(this.labelUsername);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.labelDateTime);
            this.panel5.Controls.Add(this.linkLabelLogOut);
            this.panel5.Controls.Add(this.pictureBox1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1111, 91);
            this.panel5.TabIndex = 0;
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelUsername.Location = new System.Drawing.Point(121, 26);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(42, 19);
            this.labelUsername.TabIndex = 2;
            this.labelUsername.Text = "user";
            this.labelUsername.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(47, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Welcome, ";
            // 
            // labelDateTime
            // 
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.ForeColor = System.Drawing.Color.Snow;
            this.labelDateTime.Location = new System.Drawing.Point(47, 45);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(44, 19);
            this.labelDateTime.TabIndex = 1;
            this.labelDateTime.Text = "Time";
            this.labelDateTime.Click += new System.EventHandler(this.labelDateTime_Click);
            // 
            // linkLabelLogOut
            // 
            this.linkLabelLogOut.ActiveLinkColor = System.Drawing.Color.DarkOrchid;
            this.linkLabelLogOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabelLogOut.AutoSize = true;
            this.linkLabelLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabelLogOut.LinkColor = System.Drawing.Color.MediumSlateBlue;
            this.linkLabelLogOut.Location = new System.Drawing.Point(987, 39);
            this.linkLabelLogOut.Name = "linkLabelLogOut";
            this.linkLabelLogOut.Size = new System.Drawing.Size(63, 19);
            this.linkLabelLogOut.TabIndex = 0;
            this.linkLabelLogOut.TabStop = true;
            this.linkLabelLogOut.Text = "Log out";
            this.linkLabelLogOut.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::car_parking_manager.Properties.Resources.user_icon;
            this.pictureBox1.Location = new System.Drawing.Point(929, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.userControlDashboard1);
            this.panel2.Controls.Add(this.userControlBooking1);
            this.panel2.Controls.Add(this.userControlParking1);
            this.panel2.Controls.Add(this.userControlEmployee1);
            this.panel2.Controls.Add(this.userControlSettings1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(255, 164);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1111, 556);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint_2);
            // 
            // userControlDashboard1
            // 
            this.userControlDashboard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.userControlDashboard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlDashboard1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.userControlDashboard1.Location = new System.Drawing.Point(0, 0);
            this.userControlDashboard1.Margin = new System.Windows.Forms.Padding(4);
            this.userControlDashboard1.Name = "userControlDashboard1";
            this.userControlDashboard1.Size = new System.Drawing.Size(1111, 556);
            this.userControlDashboard1.TabIndex = 0;
            // 
            // userControlBooking1
            // 
            this.userControlBooking1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.userControlBooking1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlBooking1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.userControlBooking1.Location = new System.Drawing.Point(0, 0);
            this.userControlBooking1.Margin = new System.Windows.Forms.Padding(4);
            this.userControlBooking1.Name = "userControlBooking1";
            this.userControlBooking1.Size = new System.Drawing.Size(1111, 556);
            this.userControlBooking1.TabIndex = 0;
            this.userControlBooking1.Visible = false;
            // 
            // userControlParking1
            // 
            this.userControlParking1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.userControlParking1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlParking1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.userControlParking1.Location = new System.Drawing.Point(0, 0);
            this.userControlParking1.Margin = new System.Windows.Forms.Padding(6);
            this.userControlParking1.Name = "userControlParking1";
            this.userControlParking1.Size = new System.Drawing.Size(1111, 556);
            this.userControlParking1.TabIndex = 0;
            this.userControlParking1.Visible = false;
            // 
            // userControlEmployee1
            // 
            this.userControlEmployee1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.userControlEmployee1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlEmployee1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userControlEmployee1.Location = new System.Drawing.Point(0, 0);
            this.userControlEmployee1.Margin = new System.Windows.Forms.Padding(4);
            this.userControlEmployee1.Name = "userControlEmployee1";
            this.userControlEmployee1.Size = new System.Drawing.Size(1111, 556);
            this.userControlEmployee1.TabIndex = 0;
            this.userControlEmployee1.Visible = false;
            this.userControlEmployee1.Load += new System.EventHandler(this.userControlEmployee1_Load);
            // 
            // userControlSettings1
            // 
            this.userControlSettings1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.userControlSettings1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlSettings1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userControlSettings1.ForeColor = System.Drawing.Color.White;
            this.userControlSettings1.Location = new System.Drawing.Point(0, 0);
            this.userControlSettings1.Margin = new System.Windows.Forms.Padding(4);
            this.userControlSettings1.Name = "userControlSettings1";
            this.userControlSettings1.Size = new System.Drawing.Size(1111, 556);
            this.userControlSettings1.TabIndex = 0;
            this.userControlSettings1.Visible = false;
            this.userControlSettings1.Load += new System.EventHandler(this.userControlSettings1_Load);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = global::car_parking_manager.Properties.Resources.parking;
            this.pictureBox2.Location = new System.Drawing.Point(82, 63);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(83, 63);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // FormDarshboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(1366, 720);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormDarshboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Car Parking Manager | Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormDarshboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel linkLabelLogOut;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.Button buttonBooking;
        private System.Windows.Forms.Button buttonParking;
        private System.Windows.Forms.Button buttonEmployee;
        private System.Windows.Forms.Button buttonDashboard;
        private System.Windows.Forms.Panel panelSlide;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelDateTime;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label label2;
        private User_Control.UserControlSettings userControlSettings1;
        private User_Control.UserControlEmployee userControlEmployee1;
        private User_Control.UserControlParking userControlParking1;
        private User_Control.UserControlBooking userControlBooking1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private User_Control.UserControlDashboard userControlDashboard1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}