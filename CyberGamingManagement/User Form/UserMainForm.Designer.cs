namespace CyberGamingManagement.User_Form
{
    partial class UserMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserMainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonRecharge = new System.Windows.Forms.Button();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.buttonProfile = new System.Windows.Forms.Button();
            this.buttonService = new System.Windows.Forms.Button();
            this.buttonDashBoard = new System.Windows.Forms.Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.timerUsingTime = new System.Windows.Forms.Timer(this.components);
            this.timerHour = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.panel1.Controls.Add(this.buttonRecharge);
            this.panel1.Controls.Add(this.buttonLogOut);
            this.panel1.Controls.Add(this.buttonProfile);
            this.panel1.Controls.Add(this.buttonService);
            this.panel1.Controls.Add(this.buttonDashBoard);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(167, 661);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // buttonRecharge
            // 
            this.buttonRecharge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.buttonRecharge.FlatAppearance.BorderSize = 0;
            this.buttonRecharge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRecharge.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRecharge.ForeColor = System.Drawing.Color.White;
            this.buttonRecharge.Image = global::CyberGamingManagement.Properties.Resources.dollar;
            this.buttonRecharge.Location = new System.Drawing.Point(4, 255);
            this.buttonRecharge.Name = "buttonRecharge";
            this.buttonRecharge.Size = new System.Drawing.Size(163, 79);
            this.buttonRecharge.TabIndex = 119;
            this.buttonRecharge.Text = "Recharge";
            this.buttonRecharge.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonRecharge.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonRecharge.UseVisualStyleBackColor = false;
            this.buttonRecharge.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.buttonLogOut.FlatAppearance.BorderSize = 0;
            this.buttonLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogOut.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogOut.ForeColor = System.Drawing.Color.White;
            this.buttonLogOut.Image = global::CyberGamingManagement.Properties.Resources.logout;
            this.buttonLogOut.Location = new System.Drawing.Point(1, 579);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(163, 79);
            this.buttonLogOut.TabIndex = 115;
            this.buttonLogOut.Text = "LogOut";
            this.buttonLogOut.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonLogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonLogOut.UseVisualStyleBackColor = false;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // buttonProfile
            // 
            this.buttonProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.buttonProfile.FlatAppearance.BorderSize = 0;
            this.buttonProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProfile.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProfile.ForeColor = System.Drawing.Color.White;
            this.buttonProfile.Image = ((System.Drawing.Image)(resources.GetObject("buttonProfile.Image")));
            this.buttonProfile.Location = new System.Drawing.Point(0, 85);
            this.buttonProfile.Name = "buttonProfile";
            this.buttonProfile.Size = new System.Drawing.Size(163, 79);
            this.buttonProfile.TabIndex = 118;
            this.buttonProfile.Text = "Profile";
            this.buttonProfile.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonProfile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonProfile.UseVisualStyleBackColor = false;
            this.buttonProfile.Click += new System.EventHandler(this.buttonProfile_Click);
            // 
            // buttonService
            // 
            this.buttonService.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.buttonService.FlatAppearance.BorderSize = 0;
            this.buttonService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonService.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonService.ForeColor = System.Drawing.Color.White;
            this.buttonService.Image = global::CyberGamingManagement.Properties.Resources.food_icon;
            this.buttonService.Location = new System.Drawing.Point(0, 170);
            this.buttonService.Name = "buttonService";
            this.buttonService.Size = new System.Drawing.Size(163, 79);
            this.buttonService.TabIndex = 113;
            this.buttonService.Text = "Service";
            this.buttonService.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonService.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonService.UseVisualStyleBackColor = false;
            this.buttonService.Click += new System.EventHandler(this.buttonService_Click);
            // 
            // buttonDashBoard
            // 
            this.buttonDashBoard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.buttonDashBoard.FlatAppearance.BorderSize = 0;
            this.buttonDashBoard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDashBoard.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDashBoard.ForeColor = System.Drawing.Color.White;
            this.buttonDashBoard.Image = ((System.Drawing.Image)(resources.GetObject("buttonDashBoard.Image")));
            this.buttonDashBoard.Location = new System.Drawing.Point(0, 0);
            this.buttonDashBoard.Name = "buttonDashBoard";
            this.buttonDashBoard.Size = new System.Drawing.Size(163, 79);
            this.buttonDashBoard.TabIndex = 116;
            this.buttonDashBoard.Text = "Dashboard";
            this.buttonDashBoard.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonDashBoard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonDashBoard.UseVisualStyleBackColor = false;
            this.buttonDashBoard.Click += new System.EventHandler(this.button5_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.Location = new System.Drawing.Point(164, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1074, 661);
            this.panelContainer.TabIndex = 1;
            // 
            // timerUsingTime
            // 
            this.timerUsingTime.Interval = 1000;
            this.timerUsingTime.Tick += new System.EventHandler(this.timerUsingTime_Tick);
            // 
            // timerHour
            // 
            this.timerHour.Interval = 3600000;
            this.timerHour.Tick += new System.EventHandler(this.timerHour_Tick);
            // 
            // UserMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 659);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserMainForm";
            this.Text = "Hello User";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserMainForm_FormClosing);
            this.Load += new System.EventHandler(this.UserMainForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonProfile;
        private System.Windows.Forms.Button buttonDashBoard;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Button buttonService;
        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.Timer timerUsingTime;
        private System.Windows.Forms.Timer timerHour;
        private System.Windows.Forms.Button buttonRecharge;
    }
}