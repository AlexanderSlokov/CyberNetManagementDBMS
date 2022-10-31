namespace CyberGamingManagement.User_Form
{
    partial class UserDashBoard
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
            this.components = new System.ComponentModel.Container();
            this.textBoxFee = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelLoginTime = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelBalance = new System.Windows.Forms.Label();
            this.labelUserFullName = new System.Windows.Forms.Label();
            this.labelRoomID = new System.Windows.Forms.Label();
            this.labelComputerID = new System.Windows.Forms.Label();
            this.textBoxInfo = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.labelUsingTime = new System.Windows.Forms.Label();
            this.textBoxPcID = new System.Windows.Forms.TextBox();
            this.textBoxRoomID = new System.Windows.Forms.TextBox();
            this.textBoxBalance = new System.Windows.Forms.TextBox();
            this.textBoxUserFullName = new System.Windows.Forms.TextBox();
            this.timerUsingTime = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // textBoxFee
            // 
            this.textBoxFee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.textBoxFee.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxFee.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFee.Location = new System.Drawing.Point(670, 178);
            this.textBoxFee.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxFee.Name = "textBoxFee";
            this.textBoxFee.ReadOnly = true;
            this.textBoxFee.Size = new System.Drawing.Size(372, 30);
            this.textBoxFee.TabIndex = 113;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.label3.Location = new System.Drawing.Point(523, 187);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 23);
            this.label3.TabIndex = 112;
            this.label3.Text = "Fee Per Hour:";
            // 
            // labelLoginTime
            // 
            this.labelLoginTime.AllowDrop = true;
            this.labelLoginTime.AutoSize = true;
            this.labelLoginTime.Font = new System.Drawing.Font("Nirmala UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoginTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.labelLoginTime.Location = new System.Drawing.Point(242, 219);
            this.labelLoginTime.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelLoginTime.Name = "labelLoginTime";
            this.labelLoginTime.Size = new System.Drawing.Size(158, 46);
            this.labelLoginTime.TabIndex = 111;
            this.labelLoginTime.Text = "20:20:00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.label2.Location = new System.Drawing.Point(523, 229);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 23);
            this.label2.TabIndex = 110;
            this.label2.Text = "Using Time:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.label1.Location = new System.Drawing.Point(51, 238);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 23);
            this.label1.TabIndex = 109;
            this.label1.Text = "Login Time:";
            // 
            // labelBalance
            // 
            this.labelBalance.AutoSize = true;
            this.labelBalance.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelBalance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.labelBalance.Location = new System.Drawing.Point(51, 95);
            this.labelBalance.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelBalance.Name = "labelBalance";
            this.labelBalance.Size = new System.Drawing.Size(81, 23);
            this.labelBalance.TabIndex = 107;
            this.labelBalance.Text = "Balance: ";
            // 
            // labelUserFullName
            // 
            this.labelUserFullName.AutoSize = true;
            this.labelUserFullName.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelUserFullName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.labelUserFullName.Location = new System.Drawing.Point(51, 48);
            this.labelUserFullName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelUserFullName.Name = "labelUserFullName";
            this.labelUserFullName.Size = new System.Drawing.Size(56, 23);
            this.labelUserFullName.TabIndex = 106;
            this.labelUserFullName.Text = "User: ";
            // 
            // labelRoomID
            // 
            this.labelRoomID.AutoSize = true;
            this.labelRoomID.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelRoomID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.labelRoomID.Location = new System.Drawing.Point(51, 187);
            this.labelRoomID.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelRoomID.Name = "labelRoomID";
            this.labelRoomID.Size = new System.Drawing.Size(67, 23);
            this.labelRoomID.TabIndex = 105;
            this.labelRoomID.Text = "Room: ";
            // 
            // labelComputerID
            // 
            this.labelComputerID.AutoSize = true;
            this.labelComputerID.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelComputerID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.labelComputerID.Location = new System.Drawing.Point(51, 138);
            this.labelComputerID.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelComputerID.Name = "labelComputerID";
            this.labelComputerID.Size = new System.Drawing.Size(61, 23);
            this.labelComputerID.TabIndex = 104;
            this.labelComputerID.Text = "PC no:";
            // 
            // textBoxInfo
            // 
            this.textBoxInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.textBoxInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxInfo.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxInfo.Location = new System.Drawing.Point(670, 48);
            this.textBoxInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxInfo.Multiline = true;
            this.textBoxInfo.Name = "textBoxInfo";
            this.textBoxInfo.ReadOnly = true;
            this.textBoxInfo.Size = new System.Drawing.Size(372, 113);
            this.textBoxInfo.TabIndex = 103;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.label23.Location = new System.Drawing.Point(523, 48);
            this.label23.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(133, 23);
            this.label23.TabIndex = 102;
            this.label23.Text = "PC Description:";
            // 
            // labelUsingTime
            // 
            this.labelUsingTime.AllowDrop = true;
            this.labelUsingTime.AutoSize = true;
            this.labelUsingTime.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsingTime.ForeColor = System.Drawing.Color.Teal;
            this.labelUsingTime.Location = new System.Drawing.Point(770, 212);
            this.labelUsingTime.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelUsingTime.Name = "labelUsingTime";
            this.labelUsingTime.Size = new System.Drawing.Size(183, 54);
            this.labelUsingTime.TabIndex = 116;
            this.labelUsingTime.Text = "20:20:00";
            // 
            // textBoxPcID
            // 
            this.textBoxPcID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.textBoxPcID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPcID.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPcID.Location = new System.Drawing.Point(148, 131);
            this.textBoxPcID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxPcID.Name = "textBoxPcID";
            this.textBoxPcID.ReadOnly = true;
            this.textBoxPcID.Size = new System.Drawing.Size(349, 30);
            this.textBoxPcID.TabIndex = 117;
            // 
            // textBoxRoomID
            // 
            this.textBoxRoomID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.textBoxRoomID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxRoomID.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRoomID.Location = new System.Drawing.Point(148, 180);
            this.textBoxRoomID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxRoomID.Name = "textBoxRoomID";
            this.textBoxRoomID.ReadOnly = true;
            this.textBoxRoomID.Size = new System.Drawing.Size(350, 30);
            this.textBoxRoomID.TabIndex = 118;
            // 
            // textBoxBalance
            // 
            this.textBoxBalance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.textBoxBalance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxBalance.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBalance.Location = new System.Drawing.Point(149, 86);
            this.textBoxBalance.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxBalance.Name = "textBoxBalance";
            this.textBoxBalance.ReadOnly = true;
            this.textBoxBalance.Size = new System.Drawing.Size(349, 30);
            this.textBoxBalance.TabIndex = 119;
            this.textBoxBalance.TextChanged += new System.EventHandler(this.textBoxBalance_TextChanged);
            // 
            // textBoxUserFullName
            // 
            this.textBoxUserFullName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.textBoxUserFullName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUserFullName.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUserFullName.Location = new System.Drawing.Point(149, 48);
            this.textBoxUserFullName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxUserFullName.Name = "textBoxUserFullName";
            this.textBoxUserFullName.ReadOnly = true;
            this.textBoxUserFullName.Size = new System.Drawing.Size(349, 30);
            this.textBoxUserFullName.TabIndex = 120;
            this.textBoxUserFullName.TextChanged += new System.EventHandler(this.textBoxUserFullName_TextChanged);
            // 
            // timerUsingTime
            // 
            this.timerUsingTime.Interval = 1000;
            this.timerUsingTime.Tick += new System.EventHandler(this.timerUsingTime_Tick);
            // 
            // UserDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxUserFullName);
            this.Controls.Add(this.textBoxBalance);
            this.Controls.Add(this.textBoxRoomID);
            this.Controls.Add(this.textBoxPcID);
            this.Controls.Add(this.labelUsingTime);
            this.Controls.Add(this.textBoxFee);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelLoginTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelBalance);
            this.Controls.Add(this.labelUserFullName);
            this.Controls.Add(this.labelRoomID);
            this.Controls.Add(this.labelComputerID);
            this.Controls.Add(this.textBoxInfo);
            this.Controls.Add(this.label23);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UserDashBoard";
            this.Size = new System.Drawing.Size(1171, 323);
            this.Load += new System.EventHandler(this.UserDashBoard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxFee;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label labelLoginTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelBalance;
        private System.Windows.Forms.Label labelUserFullName;
        private System.Windows.Forms.Label labelRoomID;
        private System.Windows.Forms.Label labelComputerID;
        private System.Windows.Forms.TextBox textBoxInfo;
        private System.Windows.Forms.Label label23;
        public System.Windows.Forms.Label labelUsingTime;
        private System.Windows.Forms.TextBox textBoxPcID;
        private System.Windows.Forms.TextBox textBoxRoomID;
        private System.Windows.Forms.TextBox textBoxBalance;
        private System.Windows.Forms.TextBox textBoxUserFullName;
        private System.Windows.Forms.Timer timerUsingTime;
    }
}
