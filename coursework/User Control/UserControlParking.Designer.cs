namespace car_parking_manager.User_Control
{
    partial class UserControlParking
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
            this.tabControlParking = new System.Windows.Forms.TabControl();
            this.tabPageAddParking = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxCommentary = new System.Windows.Forms.TextBox();
            this.radioButtonNo = new System.Windows.Forms.RadioButton();
            this.radioButtonYes = new System.Windows.Forms.RadioButton();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.tabPageSearchParking = new System.Windows.Forms.TabPage();
            this.dataGridViewParking = new System.Windows.Forms.DataGridView();
            this.textBoxSearchClientID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPageUpdateOrDeleteParking = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxCommentary1 = new System.Windows.Forms.TextBox();
            this.radioButtonNo1 = new System.Windows.Forms.RadioButton();
            this.radioButtonYes1 = new System.Windows.Forms.RadioButton();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBoxType1 = new System.Windows.Forms.ComboBox();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControlParking.SuspendLayout();
            this.tabPageAddParking.SuspendLayout();
            this.tabPageSearchParking.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParking)).BeginInit();
            this.tabPageUpdateOrDeleteParking.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlParking
            // 
            this.tabControlParking.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControlParking.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabControlParking.Controls.Add(this.tabPageAddParking);
            this.tabControlParking.Controls.Add(this.tabPageSearchParking);
            this.tabControlParking.Controls.Add(this.tabPageUpdateOrDeleteParking);
            this.tabControlParking.Location = new System.Drawing.Point(22, 45);
            this.tabControlParking.Name = "tabControlParking";
            this.tabControlParking.SelectedIndex = 0;
            this.tabControlParking.Size = new System.Drawing.Size(1061, 399);
            this.tabControlParking.TabIndex = 0;
            // 
            // tabPageAddParking
            // 
            this.tabPageAddParking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.tabPageAddParking.Controls.Add(this.label1);
            this.tabPageAddParking.Controls.Add(this.label2);
            this.tabPageAddParking.Controls.Add(this.label3);
            this.tabPageAddParking.Controls.Add(this.textBoxCommentary);
            this.tabPageAddParking.Controls.Add(this.radioButtonNo);
            this.tabPageAddParking.Controls.Add(this.radioButtonYes);
            this.tabPageAddParking.Controls.Add(this.buttonAdd);
            this.tabPageAddParking.Controls.Add(this.label4);
            this.tabPageAddParking.Controls.Add(this.comboBoxType);
            this.tabPageAddParking.Location = new System.Drawing.Point(4, 4);
            this.tabPageAddParking.Name = "tabPageAddParking";
            this.tabPageAddParking.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAddParking.Size = new System.Drawing.Size(1053, 367);
            this.tabPageAddParking.TabIndex = 0;
            this.tabPageAddParking.Text = "Add Parking";
            this.tabPageAddParking.Click += new System.EventHandler(this.tabPage1_Click);
            this.tabPageAddParking.Leave += new System.EventHandler(this.tabPageAddParking_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.MediumPurple;
            this.label1.Location = new System.Drawing.Point(412, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Parking";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(412, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Parking Type";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(412, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Commentary";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBoxCommentary
            // 
            this.textBoxCommentary.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxCommentary.Location = new System.Drawing.Point(416, 184);
            this.textBoxCommentary.Name = "textBoxCommentary";
            this.textBoxCommentary.Size = new System.Drawing.Size(228, 27);
            this.textBoxCommentary.TabIndex = 2;
            // 
            // radioButtonNo
            // 
            this.radioButtonNo.AutoSize = true;
            this.radioButtonNo.ForeColor = System.Drawing.Color.White;
            this.radioButtonNo.Location = new System.Drawing.Point(473, 236);
            this.radioButtonNo.Name = "radioButtonNo";
            this.radioButtonNo.Size = new System.Drawing.Size(47, 23);
            this.radioButtonNo.TabIndex = 4;
            this.radioButtonNo.TabStop = true;
            this.radioButtonNo.Text = "No";
            this.radioButtonNo.UseVisualStyleBackColor = true;
            // 
            // radioButtonYes
            // 
            this.radioButtonYes.AutoSize = true;
            this.radioButtonYes.ForeColor = System.Drawing.Color.White;
            this.radioButtonYes.Location = new System.Drawing.Point(416, 236);
            this.radioButtonYes.Name = "radioButtonYes";
            this.radioButtonYes.Size = new System.Drawing.Size(51, 23);
            this.radioButtonYes.TabIndex = 3;
            this.radioButtonYes.TabStop = true;
            this.radioButtonYes.Text = "Yes";
            this.radioButtonYes.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(40)))), ((int)(((byte)(204)))));
            this.buttonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdd.FlatAppearance.BorderSize = 0;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.Location = new System.Drawing.Point(416, 270);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(228, 36);
            this.buttonAdd.TabIndex = 5;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(412, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Free";
            this.label4.Click += new System.EventHandler(this.label3_Click);
            // 
            // comboBoxType
            // 
            this.comboBoxType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Car Parking",
            "Bike Parking",
            "Disabled Parking"});
            this.comboBoxType.Location = new System.Drawing.Point(416, 129);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(228, 27);
            this.comboBoxType.TabIndex = 1;
            // 
            // tabPageSearchParking
            // 
            this.tabPageSearchParking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.tabPageSearchParking.Controls.Add(this.dataGridViewParking);
            this.tabPageSearchParking.Controls.Add(this.textBoxSearchClientID);
            this.tabPageSearchParking.Controls.Add(this.label5);
            this.tabPageSearchParking.Controls.Add(this.label6);
            this.tabPageSearchParking.Location = new System.Drawing.Point(4, 4);
            this.tabPageSearchParking.Name = "tabPageSearchParking";
            this.tabPageSearchParking.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSearchParking.Size = new System.Drawing.Size(1053, 367);
            this.tabPageSearchParking.TabIndex = 1;
            this.tabPageSearchParking.Text = "Search Parking";
            this.tabPageSearchParking.Enter += new System.EventHandler(this.tabPageSearchParking_Enter);
            this.tabPageSearchParking.Leave += new System.EventHandler(this.tabPageSearchParking_Leave);
            // 
            // dataGridViewParking
            // 
            this.dataGridViewParking.AllowUserToAddRows = false;
            this.dataGridViewParking.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewParking.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewParking.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewParking.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewParking.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewParking.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewParking.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewParking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewParking.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridViewParking.GridColor = System.Drawing.Color.Snow;
            this.dataGridViewParking.Location = new System.Drawing.Point(28, 124);
            this.dataGridViewParking.Name = "dataGridViewParking";
            this.dataGridViewParking.ReadOnly = true;
            this.dataGridViewParking.Size = new System.Drawing.Size(1000, 221);
            this.dataGridViewParking.TabIndex = 18;
            this.dataGridViewParking.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewParking_CellClick);
            // 
            // textBoxSearchClientID
            // 
            this.textBoxSearchClientID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxSearchClientID.Location = new System.Drawing.Point(28, 77);
            this.textBoxSearchClientID.Name = "textBoxSearchClientID";
            this.textBoxSearchClientID.Size = new System.Drawing.Size(228, 27);
            this.textBoxSearchClientID.TabIndex = 17;
            this.textBoxSearchClientID.TextChanged += new System.EventHandler(this.textBoxSearchParkingID_TextChanged);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(24, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 19);
            this.label5.TabIndex = 16;
            this.label5.Text = "Client ID";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.MediumPurple;
            this.label6.Location = new System.Drawing.Point(24, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 19);
            this.label6.TabIndex = 15;
            this.label6.Text = "Search Parking";
            // 
            // tabPageUpdateOrDeleteParking
            // 
            this.tabPageUpdateOrDeleteParking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.tabPageUpdateOrDeleteParking.Controls.Add(this.label7);
            this.tabPageUpdateOrDeleteParking.Controls.Add(this.label8);
            this.tabPageUpdateOrDeleteParking.Controls.Add(this.label9);
            this.tabPageUpdateOrDeleteParking.Controls.Add(this.textBoxCommentary1);
            this.tabPageUpdateOrDeleteParking.Controls.Add(this.radioButtonNo1);
            this.tabPageUpdateOrDeleteParking.Controls.Add(this.radioButtonYes1);
            this.tabPageUpdateOrDeleteParking.Controls.Add(this.buttonDelete);
            this.tabPageUpdateOrDeleteParking.Controls.Add(this.buttonUpdate);
            this.tabPageUpdateOrDeleteParking.Controls.Add(this.label10);
            this.tabPageUpdateOrDeleteParking.Controls.Add(this.comboBoxType1);
            this.tabPageUpdateOrDeleteParking.Location = new System.Drawing.Point(4, 4);
            this.tabPageUpdateOrDeleteParking.Name = "tabPageUpdateOrDeleteParking";
            this.tabPageUpdateOrDeleteParking.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUpdateOrDeleteParking.Size = new System.Drawing.Size(1053, 367);
            this.tabPageUpdateOrDeleteParking.TabIndex = 2;
            this.tabPageUpdateOrDeleteParking.Text = "Update Or Delete Parking";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.MediumPurple;
            this.label7.Location = new System.Drawing.Point(412, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(192, 19);
            this.label7.TabIndex = 13;
            this.label7.Text = "Update or Delete Parking";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(412, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 19);
            this.label8.TabIndex = 16;
            this.label8.Text = "Parking Type";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(412, 143);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 19);
            this.label9.TabIndex = 14;
            this.label9.Text = "Commentary";
            // 
            // textBoxCommentary1
            // 
            this.textBoxCommentary1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxCommentary1.Location = new System.Drawing.Point(416, 168);
            this.textBoxCommentary1.Name = "textBoxCommentary1";
            this.textBoxCommentary1.Size = new System.Drawing.Size(228, 27);
            this.textBoxCommentary1.TabIndex = 17;
            // 
            // radioButtonNo1
            // 
            this.radioButtonNo1.AutoSize = true;
            this.radioButtonNo1.ForeColor = System.Drawing.Color.White;
            this.radioButtonNo1.Location = new System.Drawing.Point(473, 220);
            this.radioButtonNo1.Name = "radioButtonNo1";
            this.radioButtonNo1.Size = new System.Drawing.Size(47, 23);
            this.radioButtonNo1.TabIndex = 20;
            this.radioButtonNo1.TabStop = true;
            this.radioButtonNo1.Text = "No";
            this.radioButtonNo1.UseVisualStyleBackColor = true;
            // 
            // radioButtonYes1
            // 
            this.radioButtonYes1.AutoSize = true;
            this.radioButtonYes1.ForeColor = System.Drawing.Color.White;
            this.radioButtonYes1.Location = new System.Drawing.Point(416, 220);
            this.radioButtonYes1.Name = "radioButtonYes1";
            this.radioButtonYes1.Size = new System.Drawing.Size(51, 23);
            this.radioButtonYes1.TabIndex = 19;
            this.radioButtonYes1.TabStop = true;
            this.radioButtonYes1.Text = "Yes";
            this.radioButtonYes1.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonDelete.BackColor = System.Drawing.Color.Silver;
            this.buttonDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDelete.FlatAppearance.BorderSize = 0;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.ForeColor = System.Drawing.Color.White;
            this.buttonDelete.Location = new System.Drawing.Point(416, 296);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(228, 36);
            this.buttonDelete.TabIndex = 18;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(40)))), ((int)(((byte)(204)))));
            this.buttonUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUpdate.FlatAppearance.BorderSize = 0;
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdate.ForeColor = System.Drawing.Color.White;
            this.buttonUpdate.Location = new System.Drawing.Point(416, 254);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(228, 36);
            this.buttonUpdate.TabIndex = 18;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(412, 198);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 19);
            this.label10.TabIndex = 15;
            this.label10.Text = "Free";
            // 
            // comboBoxType1
            // 
            this.comboBoxType1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxType1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxType1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxType1.FormattingEnabled = true;
            this.comboBoxType1.Items.AddRange(new object[] {
            "Car Parking",
            "Bike Parking",
            "Disabled Parking"});
            this.comboBoxType1.Location = new System.Drawing.Point(416, 113);
            this.comboBoxType1.Name = "comboBoxType1";
            this.comboBoxType1.Size = new System.Drawing.Size(228, 27);
            this.comboBoxType1.TabIndex = 12;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Room_Free";
            this.Column4.HeaderText = "is Free?";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Room_Phone";
            this.Column3.HeaderText = "Commentary";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Room_Type";
            this.Column2.HeaderText = "Type";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Room_Number";
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // UserControlParking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Controls.Add(this.tabControlParking);
            this.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "UserControlParking";
            this.Size = new System.Drawing.Size(1102, 462);
            this.tabControlParking.ResumeLayout(false);
            this.tabPageAddParking.ResumeLayout(false);
            this.tabPageAddParking.PerformLayout();
            this.tabPageSearchParking.ResumeLayout(false);
            this.tabPageSearchParking.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParking)).EndInit();
            this.tabPageUpdateOrDeleteParking.ResumeLayout(false);
            this.tabPageUpdateOrDeleteParking.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlParking;
        private System.Windows.Forms.TabPage tabPageAddParking;
        private System.Windows.Forms.TabPage tabPageSearchParking;
        private System.Windows.Forms.TabPage tabPageUpdateOrDeleteParking;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.RadioButton radioButtonNo;
        private System.Windows.Forms.RadioButton radioButtonYes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxCommentary;
        private System.Windows.Forms.DataGridView dataGridViewParking;
        private System.Windows.Forms.TextBox textBoxSearchClientID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxCommentary1;
        private System.Windows.Forms.RadioButton radioButtonNo1;
        private System.Windows.Forms.RadioButton radioButtonYes1;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBoxType1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}
