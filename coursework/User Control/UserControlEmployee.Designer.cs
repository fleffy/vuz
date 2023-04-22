namespace car_parking_manager.User_Control
{
    partial class UserControlEmployee
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControlEmployee = new System.Windows.Forms.TabControl();
            this.tabPageAddEmployee = new System.Windows.Forms.TabPage();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageSearchEmployee = new System.Windows.Forms.TabPage();
            this.dataGridViewEmployee = new System.Windows.Forms.DataGridView();
            this.textBoxSearchFirstName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Employee_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Employee_FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Employee_LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Employee_PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControlEmployee.SuspendLayout();
            this.tabPageAddEmployee.SuspendLayout();
            this.tabPageSearchEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlEmployee
            // 
            this.tabControlEmployee.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControlEmployee.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabControlEmployee.Controls.Add(this.tabPageAddEmployee);
            this.tabControlEmployee.Controls.Add(this.tabPageSearchEmployee);
            this.tabControlEmployee.Location = new System.Drawing.Point(22, 45);
            this.tabControlEmployee.Name = "tabControlEmployee";
            this.tabControlEmployee.SelectedIndex = 0;
            this.tabControlEmployee.Size = new System.Drawing.Size(1061, 399);
            this.tabControlEmployee.TabIndex = 0;
            // 
            // tabPageAddEmployee
            // 
            this.tabPageAddEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.tabPageAddEmployee.Controls.Add(this.buttonAdd);
            this.tabPageAddEmployee.Controls.Add(this.textBoxPhoneNumber);
            this.tabPageAddEmployee.Controls.Add(this.textBoxLastName);
            this.tabPageAddEmployee.Controls.Add(this.label4);
            this.tabPageAddEmployee.Controls.Add(this.textBoxFirstName);
            this.tabPageAddEmployee.Controls.Add(this.label3);
            this.tabPageAddEmployee.Controls.Add(this.label2);
            this.tabPageAddEmployee.Controls.Add(this.label1);
            this.tabPageAddEmployee.Location = new System.Drawing.Point(4, 4);
            this.tabPageAddEmployee.Name = "tabPageAddEmployee";
            this.tabPageAddEmployee.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAddEmployee.Size = new System.Drawing.Size(1053, 367);
            this.tabPageAddEmployee.TabIndex = 0;
            this.tabPageAddEmployee.Text = "Add Employee";
            this.tabPageAddEmployee.Click += new System.EventHandler(this.tabPageAddEmployee_Click);
            this.tabPageAddEmployee.Leave += new System.EventHandler(this.tabPageAddEmployee_Leave);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(40)))), ((int)(((byte)(204)))));
            this.buttonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdd.FlatAppearance.BorderSize = 0;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.Location = new System.Drawing.Point(416, 279);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(228, 36);
            this.buttonAdd.TabIndex = 9;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(416, 237);
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(228, 27);
            this.textBoxPhoneNumber.TabIndex = 7;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxLastName.Location = new System.Drawing.Point(416, 184);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(228, 27);
            this.textBoxLastName.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(412, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Phone Number:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxFirstName.Location = new System.Drawing.Point(416, 130);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(228, 27);
            this.textBoxFirstName.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(412, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Last Name:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(412, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "First Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.MediumPurple;
            this.label1.Location = new System.Drawing.Point(412, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Add Employee";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tabPageSearchEmployee
            // 
            this.tabPageSearchEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.tabPageSearchEmployee.Controls.Add(this.dataGridViewEmployee);
            this.tabPageSearchEmployee.Controls.Add(this.textBoxSearchFirstName);
            this.tabPageSearchEmployee.Controls.Add(this.label5);
            this.tabPageSearchEmployee.Controls.Add(this.label6);
            this.tabPageSearchEmployee.Location = new System.Drawing.Point(4, 4);
            this.tabPageSearchEmployee.Name = "tabPageSearchEmployee";
            this.tabPageSearchEmployee.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSearchEmployee.Size = new System.Drawing.Size(1053, 367);
            this.tabPageSearchEmployee.TabIndex = 1;
            this.tabPageSearchEmployee.Text = "Search Employee";
            this.tabPageSearchEmployee.Click += new System.EventHandler(this.tabPageSearchEmployee_Click);
            this.tabPageSearchEmployee.Enter += new System.EventHandler(this.tabPageSearchEmployee_Enter);
            this.tabPageSearchEmployee.Leave += new System.EventHandler(this.tabPageSearchEmployee_Leave);
            // 
            // dataGridViewEmployee
            // 
            this.dataGridViewEmployee.AllowUserToAddRows = false;
            this.dataGridViewEmployee.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewEmployee.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewEmployee.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewEmployee.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewEmployee.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewEmployee.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Employee_ID,
            this.Employee_FirstName,
            this.Employee_LastName,
            this.Employee_PhoneNumber});
            this.dataGridViewEmployee.GridColor = System.Drawing.Color.Snow;
            this.dataGridViewEmployee.Location = new System.Drawing.Point(23, 128);
            this.dataGridViewEmployee.Name = "dataGridViewEmployee";
            this.dataGridViewEmployee.ReadOnly = true;
            this.dataGridViewEmployee.Size = new System.Drawing.Size(1000, 221);
            this.dataGridViewEmployee.TabIndex = 14;
            this.dataGridViewEmployee.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEmployee_CellClick);
            // 
            // textBoxSearchFirstName
            // 
            this.textBoxSearchFirstName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxSearchFirstName.Location = new System.Drawing.Point(23, 81);
            this.textBoxSearchFirstName.Name = "textBoxSearchFirstName";
            this.textBoxSearchFirstName.Size = new System.Drawing.Size(228, 27);
            this.textBoxSearchFirstName.TabIndex = 13;
            this.textBoxSearchFirstName.TextChanged += new System.EventHandler(this.textBoxSearchFirstName_TextChanged);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(19, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 19);
            this.label5.TabIndex = 12;
            this.label5.Text = "Name";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.MediumPurple;
            this.label6.Location = new System.Drawing.Point(19, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 19);
            this.label6.TabIndex = 11;
            this.label6.Text = "Search Employee";
            // 
            // Employee_ID
            // 
            this.Employee_ID.DataPropertyName = "Employee_ID";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Thistle;
            this.Employee_ID.DefaultCellStyle = dataGridViewCellStyle3;
            this.Employee_ID.HeaderText = "ID ";
            this.Employee_ID.Name = "Employee_ID";
            this.Employee_ID.ReadOnly = true;
            // 
            // Employee_FirstName
            // 
            this.Employee_FirstName.DataPropertyName = "Employee_FirstName";
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Thistle;
            this.Employee_FirstName.DefaultCellStyle = dataGridViewCellStyle4;
            this.Employee_FirstName.HeaderText = "First Name";
            this.Employee_FirstName.Name = "Employee_FirstName";
            this.Employee_FirstName.ReadOnly = true;
            // 
            // Employee_LastName
            // 
            this.Employee_LastName.DataPropertyName = "Employee_LastName";
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Thistle;
            this.Employee_LastName.DefaultCellStyle = dataGridViewCellStyle5;
            this.Employee_LastName.HeaderText = "Last Name";
            this.Employee_LastName.Name = "Employee_LastName";
            this.Employee_LastName.ReadOnly = true;
            // 
            // Employee_PhoneNumber
            // 
            this.Employee_PhoneNumber.DataPropertyName = "Employee_PhoneNumber";
            this.Employee_PhoneNumber.HeaderText = "Phone Number";
            this.Employee_PhoneNumber.Name = "Employee_PhoneNumber";
            this.Employee_PhoneNumber.ReadOnly = true;
            // 
            // UserControlEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Controls.Add(this.tabControlEmployee);
            this.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserControlEmployee";
            this.Size = new System.Drawing.Size(1102, 462);
            this.tabControlEmployee.ResumeLayout(false);
            this.tabPageAddEmployee.ResumeLayout(false);
            this.tabPageAddEmployee.PerformLayout();
            this.tabPageSearchEmployee.ResumeLayout(false);
            this.tabPageSearchEmployee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployee)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlEmployee;
        private System.Windows.Forms.TabPage tabPageAddEmployee;
        private System.Windows.Forms.TabPage tabPageSearchEmployee;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewEmployee;
        private System.Windows.Forms.TextBox textBoxSearchFirstName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxPhoneNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Employee_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Employee_FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Employee_LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Employee_PhoneNumber;
    }
}
