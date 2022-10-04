namespace CyberGamingManagement.Employee_Form
{
    partial class E_ComputerDetailForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(E_ComputerDetailForm));
            this.buttonChangeStatus = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.textBoxInfo = new System.Windows.Forms.TextBox();
            this.labelComputerID = new System.Windows.Forms.Label();
            this.labelRoomID = new System.Windows.Forms.Label();
            this.labelUserFullName = new System.Windows.Forms.Label();
            this.labelBalance = new System.Windows.Forms.Label();
            this.buttonServiceList = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelLoginTime = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxFee = new System.Windows.Forms.TextBox();
            this.buttonUpdateInformation = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.labelUsingTime = new System.Windows.Forms.Label();
            this.timerUsingTime = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.buttonDisplayStatus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonChangeStatus
            // 
            this.buttonChangeStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonChangeStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonChangeStatus.FlatAppearance.BorderSize = 0;
            this.buttonChangeStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChangeStatus.ForeColor = System.Drawing.Color.White;
            this.buttonChangeStatus.Location = new System.Drawing.Point(307, 408);
            this.buttonChangeStatus.Name = "buttonChangeStatus";
            this.buttonChangeStatus.Size = new System.Drawing.Size(93, 38);
            this.buttonChangeStatus.TabIndex = 22;
            this.buttonChangeStatus.Text = "CHANGE STATUS";
            this.buttonChangeStatus.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonChangeStatus.UseVisualStyleBackColor = false;
            this.buttonChangeStatus.Click += new System.EventHandler(this.buttonMakeBusy_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.label23.Location = new System.Drawing.Point(9, 158);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(103, 17);
            this.label23.TabIndex = 84;
            this.label23.Text = "PC Description:";
            // 
            // textBoxInfo
            // 
            this.textBoxInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.textBoxInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxInfo.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxInfo.Location = new System.Drawing.Point(12, 187);
            this.textBoxInfo.Multiline = true;
            this.textBoxInfo.Name = "textBoxInfo";
            this.textBoxInfo.Size = new System.Drawing.Size(390, 137);
            this.textBoxInfo.TabIndex = 85;
            // 
            // labelComputerID
            // 
            this.labelComputerID.AutoSize = true;
            this.labelComputerID.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelComputerID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.labelComputerID.Location = new System.Drawing.Point(7, 9);
            this.labelComputerID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelComputerID.Name = "labelComputerID";
            this.labelComputerID.Size = new System.Drawing.Size(48, 17);
            this.labelComputerID.TabIndex = 86;
            this.labelComputerID.Text = "PC no:";
            // 
            // labelRoomID
            // 
            this.labelRoomID.AutoSize = true;
            this.labelRoomID.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelRoomID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.labelRoomID.Location = new System.Drawing.Point(7, 40);
            this.labelRoomID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRoomID.Name = "labelRoomID";
            this.labelRoomID.Size = new System.Drawing.Size(52, 17);
            this.labelRoomID.TabIndex = 87;
            this.labelRoomID.Text = "Room: ";
            // 
            // labelUserFullName
            // 
            this.labelUserFullName.AutoSize = true;
            this.labelUserFullName.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelUserFullName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.labelUserFullName.Location = new System.Drawing.Point(422, 9);
            this.labelUserFullName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUserFullName.Name = "labelUserFullName";
            this.labelUserFullName.Size = new System.Drawing.Size(44, 17);
            this.labelUserFullName.TabIndex = 88;
            this.labelUserFullName.Text = "User: ";
            // 
            // labelBalance
            // 
            this.labelBalance.AutoSize = true;
            this.labelBalance.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelBalance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.labelBalance.Location = new System.Drawing.Point(613, 9);
            this.labelBalance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBalance.Name = "labelBalance";
            this.labelBalance.Size = new System.Drawing.Size(63, 17);
            this.labelBalance.TabIndex = 89;
            this.labelBalance.Text = "Balance: ";
            // 
            // buttonServiceList
            // 
            this.buttonServiceList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.buttonServiceList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonServiceList.FlatAppearance.BorderSize = 0;
            this.buttonServiceList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonServiceList.ForeColor = System.Drawing.Color.White;
            this.buttonServiceList.Location = new System.Drawing.Point(208, 408);
            this.buttonServiceList.Name = "buttonServiceList";
            this.buttonServiceList.Size = new System.Drawing.Size(93, 38);
            this.buttonServiceList.TabIndex = 90;
            this.buttonServiceList.Text = "SERVICE REQUIRED";
            this.buttonServiceList.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonServiceList.UseVisualStyleBackColor = false;
            this.buttonServiceList.Click += new System.EventHandler(this.buttonServiceList_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.label1.Location = new System.Drawing.Point(422, 87);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 91;
            this.label1.Text = "Login Time:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.label2.Location = new System.Drawing.Point(613, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 92;
            this.label2.Text = "Using Time";
            // 
            // labelLoginTime
            // 
            this.labelLoginTime.AllowDrop = true;
            this.labelLoginTime.AutoSize = true;
            this.labelLoginTime.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelLoginTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.labelLoginTime.Location = new System.Drawing.Point(422, 113);
            this.labelLoginTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLoginTime.Name = "labelLoginTime";
            this.labelLoginTime.Size = new System.Drawing.Size(58, 17);
            this.labelLoginTime.TabIndex = 93;
            this.labelLoginTime.Text = "20:20:00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.label3.Location = new System.Drawing.Point(15, 338);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 17);
            this.label3.TabIndex = 94;
            this.label3.Text = "Fee Per Hour:";
            // 
            // textBoxFee
            // 
            this.textBoxFee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.textBoxFee.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxFee.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFee.Location = new System.Drawing.Point(12, 367);
            this.textBoxFee.Name = "textBoxFee";
            this.textBoxFee.Size = new System.Drawing.Size(390, 24);
            this.textBoxFee.TabIndex = 95;
            // 
            // buttonUpdateInformation
            // 
            this.buttonUpdateInformation.BackColor = System.Drawing.Color.Turquoise;
            this.buttonUpdateInformation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUpdateInformation.FlatAppearance.BorderSize = 0;
            this.buttonUpdateInformation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdateInformation.ForeColor = System.Drawing.Color.Black;
            this.buttonUpdateInformation.Location = new System.Drawing.Point(8, 408);
            this.buttonUpdateInformation.Name = "buttonUpdateInformation";
            this.buttonUpdateInformation.Size = new System.Drawing.Size(93, 38);
            this.buttonUpdateInformation.TabIndex = 96;
            this.buttonUpdateInformation.Text = "UPDATE INFORMATION";
            this.buttonUpdateInformation.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonUpdateInformation.UseVisualStyleBackColor = false;
            this.buttonUpdateInformation.Click += new System.EventHandler(this.buttonUpdateInformation_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Red;
            this.buttonDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDelete.FlatAppearance.BorderSize = 0;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.ForeColor = System.Drawing.Color.White;
            this.buttonDelete.Location = new System.Drawing.Point(109, 408);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(93, 38);
            this.buttonDelete.TabIndex = 97;
            this.buttonDelete.Text = "DELETE";
            this.buttonDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // labelUsingTime
            // 
            this.labelUsingTime.AllowDrop = true;
            this.labelUsingTime.AutoSize = true;
            this.labelUsingTime.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelUsingTime.ForeColor = System.Drawing.Color.Teal;
            this.labelUsingTime.Location = new System.Drawing.Point(613, 113);
            this.labelUsingTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUsingTime.Name = "labelUsingTime";
            this.labelUsingTime.Size = new System.Drawing.Size(58, 17);
            this.labelUsingTime.TabIndex = 98;
            this.labelUsingTime.Text = "20:20:00";
            // 
            // timerUsingTime
            // 
            this.timerUsingTime.Interval = 1000;
            this.timerUsingTime.Tick += new System.EventHandler(this.timerUsingTime_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.label4.Location = new System.Drawing.Point(7, 93);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 17);
            this.label4.TabIndex = 99;
            this.label4.Text = "Status:";
            // 
            // buttonDisplayStatus
            // 
            this.buttonDisplayStatus.BackColor = System.Drawing.Color.White;
            this.buttonDisplayStatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonDisplayStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDisplayStatus.FlatAppearance.BorderSize = 0;
            this.buttonDisplayStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDisplayStatus.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.buttonDisplayStatus.ForeColor = System.Drawing.Color.Red;
            this.buttonDisplayStatus.Image = ((System.Drawing.Image)(resources.GetObject("buttonDisplayStatus.Image")));
            this.buttonDisplayStatus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDisplayStatus.Location = new System.Drawing.Point(10, 113);
            this.buttonDisplayStatus.Margin = new System.Windows.Forms.Padding(90);
            this.buttonDisplayStatus.Name = "buttonDisplayStatus";
            this.buttonDisplayStatus.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.buttonDisplayStatus.Size = new System.Drawing.Size(390, 28);
            this.buttonDisplayStatus.TabIndex = 100;
            this.buttonDisplayStatus.Text = "AVAILABLE";
            this.buttonDisplayStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonDisplayStatus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonDisplayStatus.UseVisualStyleBackColor = false;
            // 
            // E_ComputerDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 458);
            this.Controls.Add(this.buttonDisplayStatus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelUsingTime);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdateInformation);
            this.Controls.Add(this.textBoxFee);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelLoginTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonServiceList);
            this.Controls.Add(this.labelBalance);
            this.Controls.Add(this.labelUserFullName);
            this.Controls.Add(this.labelRoomID);
            this.Controls.Add(this.labelComputerID);
            this.Controls.Add(this.textBoxInfo);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.buttonChangeStatus);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "E_ComputerDetailForm";
            this.Text = "Computer Detail";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ComputerDetailForm_FormClosed);
            this.Load += new System.EventHandler(this.ComputerDetailForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonChangeStatus;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox textBoxInfo;
        private System.Windows.Forms.Label labelComputerID;
        private System.Windows.Forms.Label labelRoomID;
        private System.Windows.Forms.Label labelUserFullName;
        private System.Windows.Forms.Label labelBalance;
        private System.Windows.Forms.Button buttonServiceList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxFee;
        private System.Windows.Forms.Button buttonUpdateInformation;
        private System.Windows.Forms.Button buttonDelete;
        public System.Windows.Forms.Label labelLoginTime;
        public System.Windows.Forms.Label labelUsingTime;
        private System.Windows.Forms.Timer timerUsingTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonDisplayStatus;
    }
}