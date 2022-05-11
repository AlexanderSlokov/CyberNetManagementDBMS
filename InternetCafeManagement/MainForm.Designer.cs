namespace InternetCafeManagement
{
    partial class formMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMain));
            this.buttonProfile = new System.Windows.Forms.Button();
            this.Manager = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnEmployeeManagement = new System.Windows.Forms.Button();
            this.buttonCheckList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonProfile
            // 
            this.buttonProfile.Location = new System.Drawing.Point(12, 2);
            this.buttonProfile.Name = "buttonProfile";
            this.buttonProfile.Size = new System.Drawing.Size(75, 23);
            this.buttonProfile.TabIndex = 0;
            this.buttonProfile.Text = "Profile";
            this.buttonProfile.UseVisualStyleBackColor = true;
            this.buttonProfile.Click += new System.EventHandler(this.buttonProfile_Click);
            // 
            // Manager
            // 
            this.Manager.Location = new System.Drawing.Point(12, 54);
            this.Manager.Name = "Manager";
            this.Manager.Size = new System.Drawing.Size(75, 23);
            this.Manager.TabIndex = 1;
            this.Manager.Text = "Room Manager";
            this.Manager.UseVisualStyleBackColor = true;
            this.Manager.Click += new System.EventHandler(this.Manager_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 109);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Room Manager";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEmployeeManagement
            // 
            this.btnEmployeeManagement.Location = new System.Drawing.Point(22, 161);
            this.btnEmployeeManagement.Name = "btnEmployeeManagement";
            this.btnEmployeeManagement.Size = new System.Drawing.Size(75, 23);
            this.btnEmployeeManagement.TabIndex = 3;
            this.btnEmployeeManagement.Text = "EmployeeManagement";
            this.btnEmployeeManagement.UseVisualStyleBackColor = true;
            this.btnEmployeeManagement.Click += new System.EventHandler(this.btnEmployeeManagement_Click);
            // 
            // buttonCheckList
            // 
            this.buttonCheckList.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonCheckList.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonCheckList.BackgroundImage")));
            this.buttonCheckList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonCheckList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCheckList.Location = new System.Drawing.Point(225, 76);
            this.buttonCheckList.Name = "buttonCheckList";
            this.buttonCheckList.Size = new System.Drawing.Size(157, 56);
            this.buttonCheckList.TabIndex = 108;
            this.buttonCheckList.Text = "Check";
            this.buttonCheckList.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonCheckList.UseVisualStyleBackColor = false;
            this.buttonCheckList.Click += new System.EventHandler(this.buttonCheckList_Click);
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCheckList);
            this.Controls.Add(this.btnEmployeeManagement);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Manager);
            this.Controls.Add(this.buttonProfile);
            this.Name = "formMain";
            this.Text = "Main Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonProfile;
        private System.Windows.Forms.Button Manager;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnEmployeeManagement;
        private System.Windows.Forms.Button buttonCheckList;
    }
}