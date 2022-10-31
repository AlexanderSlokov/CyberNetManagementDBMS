namespace CyberGamingManagement.AdminForm
{
    partial class EmployeeManagementForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeManagementForm));
            this.dataGridViewEmployee = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBoxEMPLOYEE = new System.Windows.Forms.PictureBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.buttonUploadImage = new System.Windows.Forms.Button();
            this.radioButtonMALE = new System.Windows.Forms.RadioButton();
            this.radioButtonFEMALE = new System.Windows.Forms.RadioButton();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.textBoxFullName = new System.Windows.Forms.TextBox();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxEMAIL = new System.Windows.Forms.TextBox();
            this.textBoxSalary = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.Username = new System.Windows.Forms.Label();
            this.checkBoxShowPassword = new System.Windows.Forms.CheckBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdateInformation = new System.Windows.Forms.Button();
            this.buttonAddEmployee = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBoxPosition = new System.Windows.Forms.ComboBox();
            this.buttonRefreshList = new System.Windows.Forms.Button();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.buttonSwitchEmployee = new System.Windows.Forms.Button();
            this.buttonSwitchManagers = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEMPLOYEE)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewEmployee
            // 
            this.dataGridViewEmployee.BackgroundColor = System.Drawing.Color.Bisque;
            this.dataGridViewEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployee.Location = new System.Drawing.Point(716, 17);
            this.dataGridViewEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewEmployee.Name = "dataGridViewEmployee";
            this.dataGridViewEmployee.RowHeadersWidth = 51;
            this.dataGridViewEmployee.RowTemplate.Height = 80;
            this.dataGridViewEmployee.Size = new System.Drawing.Size(816, 685);
            this.dataGridViewEmployee.TabIndex = 0;
            this.dataGridViewEmployee.Click += new System.EventHandler(this.dataGridViewEmployee_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(11, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "Full Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(11, 323);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 31);
            this.label3.TabIndex = 6;
            this.label3.Text = "Age:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(11, 371);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 31);
            this.label4.TabIndex = 7;
            this.label4.Text = "Birthdate:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(11, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 31);
            this.label5.TabIndex = 8;
            this.label5.Text = "Gender:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(9, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 31);
            this.label6.TabIndex = 9;
            this.label6.Text = "Phone:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(11, 233);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 31);
            this.label7.TabIndex = 10;
            this.label7.Text = "Email:";
            // 
            // pictureBoxEMPLOYEE
            // 
            this.pictureBoxEMPLOYEE.BackColor = System.Drawing.Color.Linen;
            this.pictureBoxEMPLOYEE.Location = new System.Drawing.Point(436, 68);
            this.pictureBoxEMPLOYEE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxEMPLOYEE.Name = "pictureBoxEMPLOYEE";
            this.pictureBoxEMPLOYEE.Size = new System.Drawing.Size(247, 242);
            this.pictureBoxEMPLOYEE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxEMPLOYEE.TabIndex = 12;
            this.pictureBoxEMPLOYEE.TabStop = false;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(153, 198);
            this.textBoxPhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(244, 22);
            this.textBoxPhone.TabIndex = 14;
            // 
            // buttonUploadImage
            // 
            this.buttonUploadImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.buttonUploadImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUploadImage.ForeColor = System.Drawing.Color.White;
            this.buttonUploadImage.Location = new System.Drawing.Point(436, 19);
            this.buttonUploadImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonUploadImage.Name = "buttonUploadImage";
            this.buttonUploadImage.Size = new System.Drawing.Size(247, 37);
            this.buttonUploadImage.TabIndex = 15;
            this.buttonUploadImage.Text = "Upload Image";
            this.buttonUploadImage.UseVisualStyleBackColor = false;
            this.buttonUploadImage.Click += new System.EventHandler(this.buttonUploadImage_Click);
            // 
            // radioButtonMALE
            // 
            this.radioButtonMALE.AutoSize = true;
            this.radioButtonMALE.Checked = true;
            this.radioButtonMALE.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.radioButtonMALE.Location = new System.Drawing.Point(153, 284);
            this.radioButtonMALE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonMALE.Name = "radioButtonMALE";
            this.radioButtonMALE.Size = new System.Drawing.Size(70, 27);
            this.radioButtonMALE.TabIndex = 20;
            this.radioButtonMALE.TabStop = true;
            this.radioButtonMALE.Text = "Male";
            this.radioButtonMALE.UseVisualStyleBackColor = true;
            // 
            // radioButtonFEMALE
            // 
            this.radioButtonFEMALE.AutoSize = true;
            this.radioButtonFEMALE.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.radioButtonFEMALE.Location = new System.Drawing.Point(253, 284);
            this.radioButtonFEMALE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonFEMALE.Name = "radioButtonFEMALE";
            this.radioButtonFEMALE.Size = new System.Drawing.Size(88, 27);
            this.radioButtonFEMALE.TabIndex = 21;
            this.radioButtonFEMALE.Text = "Female";
            this.radioButtonFEMALE.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(153, 378);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(244, 22);
            this.dateTimePicker.TabIndex = 22;
            // 
            // textBoxFullName
            // 
            this.textBoxFullName.Location = new System.Drawing.Point(153, 17);
            this.textBoxFullName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxFullName.Name = "textBoxFullName";
            this.textBoxFullName.Size = new System.Drawing.Size(244, 22);
            this.textBoxFullName.TabIndex = 23;
            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(153, 332);
            this.textBoxAge.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.ReadOnly = true;
            this.textBoxAge.Size = new System.Drawing.Size(244, 22);
            this.textBoxAge.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(11, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 31);
            this.label9.TabIndex = 26;
            this.label9.Text = "ID:";
            // 
            // textBoxEMAIL
            // 
            this.textBoxEMAIL.Location = new System.Drawing.Point(153, 242);
            this.textBoxEMAIL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxEMAIL.Name = "textBoxEMAIL";
            this.textBoxEMAIL.Size = new System.Drawing.Size(244, 22);
            this.textBoxEMAIL.TabIndex = 27;
            // 
            // textBoxSalary
            // 
            this.textBoxSalary.Location = new System.Drawing.Point(153, 156);
            this.textBoxSalary.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSalary.Name = "textBoxSalary";
            this.textBoxSalary.Size = new System.Drawing.Size(244, 22);
            this.textBoxSalary.TabIndex = 29;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(153, 476);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '•';
            this.textBoxPassword.Size = new System.Drawing.Size(244, 22);
            this.textBoxPassword.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(13, 467);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 31);
            this.label1.TabIndex = 30;
            this.label1.Text = "Password:";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(153, 424);
            this.textBoxUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(244, 22);
            this.textBoxUsername.TabIndex = 33;
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.ForeColor = System.Drawing.Color.Black;
            this.Username.Location = new System.Drawing.Point(11, 421);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(121, 31);
            this.Username.TabIndex = 32;
            this.Username.Text = "Username";
            // 
            // checkBoxShowPassword
            // 
            this.checkBoxShowPassword.AutoSize = true;
            this.checkBoxShowPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxShowPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxShowPassword.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.checkBoxShowPassword.Location = new System.Drawing.Point(153, 504);
            this.checkBoxShowPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxShowPassword.Name = "checkBoxShowPassword";
            this.checkBoxShowPassword.Size = new System.Drawing.Size(151, 27);
            this.checkBoxShowPassword.TabIndex = 34;
            this.checkBoxShowPassword.Text = "Show Password";
            this.checkBoxShowPassword.UseVisualStyleBackColor = true;
            this.checkBoxShowPassword.CheckedChanged += new System.EventHandler(this.checkBoxShowPassword_CheckedChanged);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Red;
            this.buttonDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDelete.FlatAppearance.BorderSize = 0;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.ForeColor = System.Drawing.Color.White;
            this.buttonDelete.Location = new System.Drawing.Point(436, 453);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(247, 47);
            this.buttonDelete.TabIndex = 101;
            this.buttonDelete.Text = "DELETE";
            this.buttonDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonUpdateInformation
            // 
            this.buttonUpdateInformation.BackColor = System.Drawing.Color.Turquoise;
            this.buttonUpdateInformation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUpdateInformation.FlatAppearance.BorderSize = 0;
            this.buttonUpdateInformation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdateInformation.ForeColor = System.Drawing.Color.Black;
            this.buttonUpdateInformation.Location = new System.Drawing.Point(436, 508);
            this.buttonUpdateInformation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonUpdateInformation.Name = "buttonUpdateInformation";
            this.buttonUpdateInformation.Size = new System.Drawing.Size(247, 47);
            this.buttonUpdateInformation.TabIndex = 100;
            this.buttonUpdateInformation.Text = "UPDATE INFORMATION";
            this.buttonUpdateInformation.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonUpdateInformation.UseVisualStyleBackColor = false;
            this.buttonUpdateInformation.Click += new System.EventHandler(this.buttonUpdateInformation_Click);
            // 
            // buttonAddEmployee
            // 
            this.buttonAddEmployee.BackColor = System.Drawing.Color.PaleGreen;
            this.buttonAddEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddEmployee.FlatAppearance.BorderSize = 0;
            this.buttonAddEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddEmployee.ForeColor = System.Drawing.Color.Black;
            this.buttonAddEmployee.Location = new System.Drawing.Point(436, 398);
            this.buttonAddEmployee.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAddEmployee.Name = "buttonAddEmployee";
            this.buttonAddEmployee.Size = new System.Drawing.Size(247, 47);
            this.buttonAddEmployee.TabIndex = 99;
            this.buttonAddEmployee.Text = "ADD NEW";
            this.buttonAddEmployee.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonAddEmployee.UseVisualStyleBackColor = false;
            this.buttonAddEmployee.Click += new System.EventHandler(this.buttonAddEmployee_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(11, 107);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(108, 31);
            this.label12.TabIndex = 102;
            this.label12.Text = "Position:";
            // 
            // comboBoxPosition
            // 
            this.comboBoxPosition.AutoCompleteCustomSource.AddRange(new string[] {
            "employee",
            "manager"});
            this.comboBoxPosition.FormattingEnabled = true;
            this.comboBoxPosition.Items.AddRange(new object[] {
            "Employee",
            "Manager"});
            this.comboBoxPosition.Location = new System.Drawing.Point(153, 114);
            this.comboBoxPosition.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.comboBoxPosition.Name = "comboBoxPosition";
            this.comboBoxPosition.Size = new System.Drawing.Size(244, 24);
            this.comboBoxPosition.TabIndex = 103;
            // 
            // buttonRefreshList
            // 
            this.buttonRefreshList.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonRefreshList.BackgroundImage")));
            this.buttonRefreshList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonRefreshList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRefreshList.Location = new System.Drawing.Point(436, 343);
            this.buttonRefreshList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonRefreshList.Name = "buttonRefreshList";
            this.buttonRefreshList.Size = new System.Drawing.Size(247, 47);
            this.buttonRefreshList.TabIndex = 106;
            this.buttonRefreshList.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonRefreshList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonRefreshList.UseVisualStyleBackColor = true;
            this.buttonRefreshList.Click += new System.EventHandler(this.buttonRefreshList_Click);
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(153, 68);
            this.textBoxID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(244, 22);
            this.textBoxID.TabIndex = 25;
            // 
            // buttonSwitchEmployee
            // 
            this.buttonSwitchEmployee.BackColor = System.Drawing.Color.Cyan;
            this.buttonSwitchEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSwitchEmployee.FlatAppearance.BorderSize = 0;
            this.buttonSwitchEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSwitchEmployee.ForeColor = System.Drawing.Color.Black;
            this.buttonSwitchEmployee.Location = new System.Drawing.Point(15, 578);
            this.buttonSwitchEmployee.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSwitchEmployee.Name = "buttonSwitchEmployee";
            this.buttonSwitchEmployee.Size = new System.Drawing.Size(668, 47);
            this.buttonSwitchEmployee.TabIndex = 110;
            this.buttonSwitchEmployee.Text = "EMPLOYEE";
            this.buttonSwitchEmployee.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonSwitchEmployee.UseVisualStyleBackColor = false;
            this.buttonSwitchEmployee.Click += new System.EventHandler(this.buttonSwitchEmployee_Click);
            // 
            // buttonSwitchManagers
            // 
            this.buttonSwitchManagers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.buttonSwitchManagers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSwitchManagers.FlatAppearance.BorderSize = 0;
            this.buttonSwitchManagers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSwitchManagers.ForeColor = System.Drawing.Color.Linen;
            this.buttonSwitchManagers.Location = new System.Drawing.Point(15, 655);
            this.buttonSwitchManagers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSwitchManagers.Name = "buttonSwitchManagers";
            this.buttonSwitchManagers.Size = new System.Drawing.Size(668, 47);
            this.buttonSwitchManagers.TabIndex = 111;
            this.buttonSwitchManagers.Text = "MANAGERS";
            this.buttonSwitchManagers.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonSwitchManagers.UseVisualStyleBackColor = false;
            this.buttonSwitchManagers.Click += new System.EventHandler(this.buttonSwitchManagers_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(11, 147);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 31);
            this.label8.TabIndex = 112;
            this.label8.Text = "Salary:\r\n";
            // 
            // EmployeeManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.Controls.Add(this.label8);
            this.Controls.Add(this.buttonSwitchEmployee);
            this.Controls.Add(this.buttonSwitchManagers);
            this.Controls.Add(this.buttonRefreshList);
            this.Controls.Add(this.comboBoxPosition);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdateInformation);
            this.Controls.Add(this.buttonAddEmployee);
            this.Controls.Add(this.checkBoxShowPassword);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSalary);
            this.Controls.Add(this.textBoxEMAIL);
            this.Controls.Add(this.dataGridViewEmployee);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.textBoxAge);
            this.Controls.Add(this.textBoxFullName);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.radioButtonFEMALE);
            this.Controls.Add(this.radioButtonMALE);
            this.Controls.Add(this.buttonUploadImage);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.pictureBoxEMPLOYEE);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "EmployeeManagementForm";
            this.Size = new System.Drawing.Size(1547, 822);
            this.Load += new System.EventHandler(this.EmployeeManagementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEMPLOYEE)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewEmployee;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBoxEMPLOYEE;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Button buttonUploadImage;
        private System.Windows.Forms.RadioButton radioButtonMALE;
        private System.Windows.Forms.RadioButton radioButtonFEMALE;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox textBoxFullName;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxEMAIL;
        private System.Windows.Forms.TextBox textBoxSalary;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.CheckBox checkBoxShowPassword;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdateInformation;
        private System.Windows.Forms.Button buttonAddEmployee;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBoxPosition;
        private System.Windows.Forms.Button buttonRefreshList;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Button buttonSwitchEmployee;
        private System.Windows.Forms.Button buttonSwitchManagers;
        private System.Windows.Forms.Label label8;
    }
}