﻿namespace InternetCafeManagement.AdminForm
{
    partial class AdminMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMainForm));
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonSchedule = new System.Windows.Forms.Button();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.buttonEmployeeManage = new System.Windows.Forms.Button();
            this.buttonComputerRoom = new System.Windows.Forms.Button();
            this.buttonService = new System.Windows.Forms.Button();
            this.buttonDashBoard = new System.Windows.Forms.Button();
            this.timerUsingTime = new System.Windows.Forms.Timer(this.components);
            this.timerHour = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.Location = new System.Drawing.Point(165, -1);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1227, 667);
            this.panelContainer.TabIndex = 3;
            this.panelContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContainer_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.panel1.Controls.Add(this.buttonSchedule);
            this.panel1.Controls.Add(this.buttonLogOut);
            this.panel1.Controls.Add(this.buttonEmployeeManage);
            this.panel1.Controls.Add(this.buttonComputerRoom);
            this.panel1.Controls.Add(this.buttonService);
            this.panel1.Controls.Add(this.buttonDashBoard);
            this.panel1.Location = new System.Drawing.Point(2, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(167, 667);
            this.panel1.TabIndex = 2;
            // 
            // buttonSchedule
            // 
            this.buttonSchedule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.buttonSchedule.FlatAppearance.BorderSize = 0;
            this.buttonSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSchedule.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSchedule.ForeColor = System.Drawing.Color.White;
            this.buttonSchedule.Image = ((System.Drawing.Image)(resources.GetObject("buttonSchedule.Image")));
            this.buttonSchedule.Location = new System.Drawing.Point(0, 340);
            this.buttonSchedule.Name = "buttonSchedule";
            this.buttonSchedule.Size = new System.Drawing.Size(163, 79);
            this.buttonSchedule.TabIndex = 119;
            this.buttonSchedule.Text = "Schedule";
            this.buttonSchedule.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonSchedule.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonSchedule.UseVisualStyleBackColor = false;
            this.buttonSchedule.Click += new System.EventHandler(this.buttonSchedule_Click_1);
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.buttonLogOut.FlatAppearance.BorderSize = 0;
            this.buttonLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogOut.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogOut.ForeColor = System.Drawing.Color.White;
            this.buttonLogOut.Image = ((System.Drawing.Image)(resources.GetObject("buttonLogOut.Image")));
            this.buttonLogOut.Location = new System.Drawing.Point(0, 425);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(163, 79);
            this.buttonLogOut.TabIndex = 115;
            this.buttonLogOut.Text = "LogOut";
            this.buttonLogOut.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonLogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonLogOut.UseVisualStyleBackColor = false;
            // 
            // buttonEmployeeManage
            // 
            this.buttonEmployeeManage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.buttonEmployeeManage.FlatAppearance.BorderSize = 0;
            this.buttonEmployeeManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEmployeeManage.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEmployeeManage.ForeColor = System.Drawing.Color.White;
            this.buttonEmployeeManage.Image = ((System.Drawing.Image)(resources.GetObject("buttonEmployeeManage.Image")));
            this.buttonEmployeeManage.Location = new System.Drawing.Point(0, 85);
            this.buttonEmployeeManage.Name = "buttonEmployeeManage";
            this.buttonEmployeeManage.Size = new System.Drawing.Size(163, 79);
            this.buttonEmployeeManage.TabIndex = 118;
            this.buttonEmployeeManage.Text = "Employee";
            this.buttonEmployeeManage.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonEmployeeManage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonEmployeeManage.UseVisualStyleBackColor = false;
            this.buttonEmployeeManage.Click += new System.EventHandler(this.buttonEmployeeManage_Click);
            // 
            // buttonComputerRoom
            // 
            this.buttonComputerRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.buttonComputerRoom.FlatAppearance.BorderSize = 0;
            this.buttonComputerRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonComputerRoom.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonComputerRoom.ForeColor = System.Drawing.Color.White;
            this.buttonComputerRoom.Image = ((System.Drawing.Image)(resources.GetObject("buttonComputerRoom.Image")));
            this.buttonComputerRoom.Location = new System.Drawing.Point(0, 170);
            this.buttonComputerRoom.Name = "buttonComputerRoom";
            this.buttonComputerRoom.Size = new System.Drawing.Size(163, 79);
            this.buttonComputerRoom.TabIndex = 117;
            this.buttonComputerRoom.Text = "Computer Room";
            this.buttonComputerRoom.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonComputerRoom.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonComputerRoom.UseVisualStyleBackColor = false;
            this.buttonComputerRoom.Click += new System.EventHandler(this.buttonComputerRoom_Click);
            // 
            // buttonService
            // 
            this.buttonService.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.buttonService.FlatAppearance.BorderSize = 0;
            this.buttonService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonService.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonService.ForeColor = System.Drawing.Color.White;
            this.buttonService.Image = global::InternetCafeManagement.Properties.Resources.food_icon;
            this.buttonService.Location = new System.Drawing.Point(0, 255);
            this.buttonService.Name = "buttonService";
            this.buttonService.Size = new System.Drawing.Size(163, 79);
            this.buttonService.TabIndex = 114;
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
            this.buttonDashBoard.Click += new System.EventHandler(this.buttonDashBoard_Click);
            // 
            // timerUsingTime
            // 
            this.timerUsingTime.Interval = 1000;
            // 
            // timerHour
            // 
            this.timerHour.Interval = 3600000;
            // 
            // AdminMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1394, 667);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panel1);
            this.Name = "AdminMainForm";
            this.Text = "AdminMainForm";
            this.Load += new System.EventHandler(this.AdminMainForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.Button buttonEmployeeManage;
        private System.Windows.Forms.Button buttonComputerRoom;
        private System.Windows.Forms.Button buttonService;
        private System.Windows.Forms.Button buttonDashBoard;
        private System.Windows.Forms.Timer timerUsingTime;
        private System.Windows.Forms.Timer timerHour;
        private System.Windows.Forms.Button buttonSchedule;
    }
}