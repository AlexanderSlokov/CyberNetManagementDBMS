namespace CyberGamingManagement.Employee_Form
{
    partial class EmployeeDashboard
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
            this.dataGridViewRechargeRequest = new System.Windows.Forms.DataGridView();
            this.dataGridViewSchedule = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxRoomID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxShiftType = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelStartTime = new System.Windows.Forms.Label();
            this.labelCheckOutTime = new System.Windows.Forms.Label();
            this.buttonCheckIn = new System.Windows.Forms.Button();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.textBoxRecharge = new System.Windows.Forms.TextBox();
            this.labelBalance = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxUserID = new System.Windows.Forms.TextBox();
            this.labelShiftAnnouncement = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRechargeRequest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSchedule)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewRechargeRequest
            // 
            this.dataGridViewRechargeRequest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRechargeRequest.Location = new System.Drawing.Point(532, 484);
            this.dataGridViewRechargeRequest.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewRechargeRequest.Name = "dataGridViewRechargeRequest";
            this.dataGridViewRechargeRequest.RowHeadersWidth = 51;
            this.dataGridViewRechargeRequest.Size = new System.Drawing.Size(516, 258);
            this.dataGridViewRechargeRequest.TabIndex = 0;
            this.dataGridViewRechargeRequest.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRechargeRequest_CellClick);
            // 
            // dataGridViewSchedule
            // 
            this.dataGridViewSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSchedule.Location = new System.Drawing.Point(532, 72);
            this.dataGridViewSchedule.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewSchedule.Name = "dataGridViewSchedule";
            this.dataGridViewSchedule.RowHeadersWidth = 51;
            this.dataGridViewSchedule.Size = new System.Drawing.Size(516, 327);
            this.dataGridViewSchedule.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(632, 429);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 34);
            this.label1.TabIndex = 7;
            this.label1.Text = "Recharge Requests";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Brown;
            this.label2.Location = new System.Drawing.Point(642, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(279, 34);
            this.label2.TabIndex = 8;
            this.label2.Text = "Today\'s Schedule";
            // 
            // textBoxRoomID
            // 
            this.textBoxRoomID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.textBoxRoomID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxRoomID.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.textBoxRoomID.Location = new System.Drawing.Point(183, 83);
            this.textBoxRoomID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxRoomID.Multiline = true;
            this.textBoxRoomID.Name = "textBoxRoomID";
            this.textBoxRoomID.ReadOnly = true;
            this.textBoxRoomID.Size = new System.Drawing.Size(288, 34);
            this.textBoxRoomID.TabIndex = 103;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(16, 92);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 23);
            this.label3.TabIndex = 102;
            this.label3.Text = "Room ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(16, 141);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 23);
            this.label5.TabIndex = 105;
            this.label5.Text = "Start Time";
            // 
            // textBoxShiftType
            // 
            this.textBoxShiftType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.textBoxShiftType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxShiftType.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.textBoxShiftType.Location = new System.Drawing.Point(183, 246);
            this.textBoxShiftType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxShiftType.Multiline = true;
            this.textBoxShiftType.Name = "textBoxShiftType";
            this.textBoxShiftType.Size = new System.Drawing.Size(288, 34);
            this.textBoxShiftType.TabIndex = 108;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(14, 187);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 23);
            this.label6.TabIndex = 107;
            this.label6.Text = "Check Out Time";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(18, 255);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 23);
            this.label7.TabIndex = 109;
            this.label7.Text = "Shift Type";
            // 
            // labelStartTime
            // 
            this.labelStartTime.AllowDrop = true;
            this.labelStartTime.AutoSize = true;
            this.labelStartTime.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStartTime.ForeColor = System.Drawing.Color.Tomato;
            this.labelStartTime.Location = new System.Drawing.Point(175, 121);
            this.labelStartTime.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelStartTime.Name = "labelStartTime";
            this.labelStartTime.Size = new System.Drawing.Size(158, 46);
            this.labelStartTime.TabIndex = 117;
            this.labelStartTime.Text = "00:00:00";
            // 
            // labelCheckOutTime
            // 
            this.labelCheckOutTime.AllowDrop = true;
            this.labelCheckOutTime.AutoSize = true;
            this.labelCheckOutTime.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCheckOutTime.ForeColor = System.Drawing.Color.Tomato;
            this.labelCheckOutTime.Location = new System.Drawing.Point(175, 167);
            this.labelCheckOutTime.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelCheckOutTime.Name = "labelCheckOutTime";
            this.labelCheckOutTime.Size = new System.Drawing.Size(158, 46);
            this.labelCheckOutTime.TabIndex = 118;
            this.labelCheckOutTime.Text = "20:20:00";
            // 
            // buttonCheckIn
            // 
            this.buttonCheckIn.BackColor = System.Drawing.Color.Turquoise;
            this.buttonCheckIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonCheckIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCheckIn.FlatAppearance.BorderSize = 0;
            this.buttonCheckIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCheckIn.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.buttonCheckIn.ForeColor = System.Drawing.Color.Red;
            this.buttonCheckIn.Image = global::CyberGamingManagement.Properties.Resources.check;
            this.buttonCheckIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCheckIn.Location = new System.Drawing.Point(179, 534);
            this.buttonCheckIn.Margin = new System.Windows.Forms.Padding(120, 111, 120, 111);
            this.buttonCheckIn.Name = "buttonCheckIn";
            this.buttonCheckIn.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.buttonCheckIn.Size = new System.Drawing.Size(292, 208);
            this.buttonCheckIn.TabIndex = 101;
            this.buttonCheckIn.Text = "CHECK IN";
            this.buttonCheckIn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonCheckIn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonCheckIn.UseVisualStyleBackColor = false;
            this.buttonCheckIn.Click += new System.EventHandler(this.buttonCheckIn_Click);
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSubmit.FlatAppearance.BorderSize = 0;
            this.buttonSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSubmit.ForeColor = System.Drawing.Color.White;
            this.buttonSubmit.Location = new System.Drawing.Point(179, 466);
            this.buttonSubmit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(292, 47);
            this.buttonSubmit.TabIndex = 125;
            this.buttonSubmit.Text = "Add Amount To User Balance";
            this.buttonSubmit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonSubmit.UseVisualStyleBackColor = false;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // textBoxRecharge
            // 
            this.textBoxRecharge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.textBoxRecharge.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxRecharge.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRecharge.Location = new System.Drawing.Point(179, 401);
            this.textBoxRecharge.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxRecharge.Name = "textBoxRecharge";
            this.textBoxRecharge.Size = new System.Drawing.Size(292, 30);
            this.textBoxRecharge.TabIndex = 124;
            this.textBoxRecharge.TextChanged += new System.EventHandler(this.textBoxRecharge_TextChanged);
            // 
            // labelBalance
            // 
            this.labelBalance.AutoSize = true;
            this.labelBalance.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelBalance.ForeColor = System.Drawing.Color.Red;
            this.labelBalance.Location = new System.Drawing.Point(16, 313);
            this.labelBalance.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelBalance.Name = "labelBalance";
            this.labelBalance.Size = new System.Drawing.Size(110, 23);
            this.labelBalance.TabIndex = 123;
            this.labelBalance.Text = "Reecharge +";
            this.labelBalance.Click += new System.EventHandler(this.labelBalance_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(16, 362);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 23);
            this.label4.TabIndex = 126;
            this.label4.Text = "User ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(16, 409);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 23);
            this.label8.TabIndex = 128;
            this.label8.Text = "Ammount";
            // 
            // textBoxUserID
            // 
            this.textBoxUserID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.textBoxUserID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUserID.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUserID.Location = new System.Drawing.Point(179, 354);
            this.textBoxUserID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxUserID.Name = "textBoxUserID";
            this.textBoxUserID.Size = new System.Drawing.Size(292, 30);
            this.textBoxUserID.TabIndex = 127;
            // 
            // labelShiftAnnouncement
            // 
            this.labelShiftAnnouncement.AutoSize = true;
            this.labelShiftAnnouncement.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold);
            this.labelShiftAnnouncement.ForeColor = System.Drawing.Color.Brown;
            this.labelShiftAnnouncement.Location = new System.Drawing.Point(214, 16);
            this.labelShiftAnnouncement.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelShiftAnnouncement.Name = "labelShiftAnnouncement";
            this.labelShiftAnnouncement.Size = new System.Drawing.Size(197, 34);
            this.labelShiftAnnouncement.TabIndex = 104;
            this.labelShiftAnnouncement.Text = "SHIFT INFO";
            // 
            // EmployeeDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxUserID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.textBoxRecharge);
            this.Controls.Add(this.labelBalance);
            this.Controls.Add(this.labelCheckOutTime);
            this.Controls.Add(this.labelStartTime);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxShiftType);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelShiftAnnouncement);
            this.Controls.Add(this.textBoxRoomID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonCheckIn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewSchedule);
            this.Controls.Add(this.dataGridViewRechargeRequest);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "EmployeeDashboard";
            this.Size = new System.Drawing.Size(1089, 759);
            this.Load += new System.EventHandler(this.EmployeeDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRechargeRequest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSchedule)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewRechargeRequest;
        private System.Windows.Forms.DataGridView dataGridViewSchedule;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonCheckIn;
        private System.Windows.Forms.TextBox textBoxRoomID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxShiftType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label labelStartTime;
        public System.Windows.Forms.Label labelCheckOutTime;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.TextBox textBoxRecharge;
        private System.Windows.Forms.Label labelBalance;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxUserID;
        private System.Windows.Forms.Label labelShiftAnnouncement;
    }
}
