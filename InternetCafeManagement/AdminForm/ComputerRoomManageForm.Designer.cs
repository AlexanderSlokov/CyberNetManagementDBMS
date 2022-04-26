namespace InternetCafeManagement.AdminForm
{
    partial class ComputerRoomManageForm
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
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelAdminControl = new System.Windows.Forms.Panel();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.panelComputerGrid = new System.Windows.Forms.Panel();
            this.panelRoomInformation = new System.Windows.Forms.Panel();
            this.labelComputerNumber = new System.Windows.Forms.Label();
            this.labelRoomID = new System.Windows.Forms.Label();
            this.panelMain.SuspendLayout();
            this.panelAdminControl.SuspendLayout();
            this.panelRoomInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.panelAdminControl);
            this.panelMain.Controls.Add(this.panelComputerGrid);
            this.panelMain.Controls.Add(this.panelRoomInformation);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1195, 737);
            this.panelMain.TabIndex = 0;
            // 
            // panelAdminControl
            // 
            this.panelAdminControl.Controls.Add(this.buttonUpdate);
            this.panelAdminControl.Location = new System.Drawing.Point(819, 92);
            this.panelAdminControl.Name = "panelAdminControl";
            this.panelAdminControl.Size = new System.Drawing.Size(375, 642);
            this.panelAdminControl.TabIndex = 2;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.buttonUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUpdate.FlatAppearance.BorderSize = 0;
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdate.ForeColor = System.Drawing.Color.White;
            this.buttonUpdate.Location = new System.Drawing.Point(3, 3);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(372, 35);
            this.buttonUpdate.TabIndex = 31;
            this.buttonUpdate.Text = "ADD NEW COMPUTER";
            this.buttonUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // panelComputerGrid
            // 
            this.panelComputerGrid.Location = new System.Drawing.Point(3, 92);
            this.panelComputerGrid.Name = "panelComputerGrid";
            this.panelComputerGrid.Size = new System.Drawing.Size(810, 642);
            this.panelComputerGrid.TabIndex = 1;
            // 
            // panelRoomInformation
            // 
            this.panelRoomInformation.Controls.Add(this.labelComputerNumber);
            this.panelRoomInformation.Controls.Add(this.labelRoomID);
            this.panelRoomInformation.Location = new System.Drawing.Point(3, 3);
            this.panelRoomInformation.Name = "panelRoomInformation";
            this.panelRoomInformation.Size = new System.Drawing.Size(452, 72);
            this.panelRoomInformation.TabIndex = 0;
            // 
            // labelComputerNumber
            // 
            this.labelComputerNumber.AutoSize = true;
            this.labelComputerNumber.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelComputerNumber.Location = new System.Drawing.Point(9, 44);
            this.labelComputerNumber.Name = "labelComputerNumber";
            this.labelComputerNumber.Size = new System.Drawing.Size(134, 17);
            this.labelComputerNumber.TabIndex = 1;
            this.labelComputerNumber.Text = "Computers Number:";
            // 
            // labelRoomID
            // 
            this.labelRoomID.AutoSize = true;
            this.labelRoomID.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRoomID.Location = new System.Drawing.Point(4, 4);
            this.labelRoomID.Name = "labelRoomID";
            this.labelRoomID.Size = new System.Drawing.Size(140, 40);
            this.labelRoomID.TabIndex = 0;
            this.labelRoomID.Text = "Room 01";
            // 
            // ComputerRoomManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 737);
            this.Controls.Add(this.panelMain);
            this.Name = "ComputerRoomManageForm";
            this.Text = "ComputerRoomManageForm";
            this.Load += new System.EventHandler(this.ComputerRoomManageForm_Load);
            this.panelMain.ResumeLayout(false);
            this.panelAdminControl.ResumeLayout(false);
            this.panelRoomInformation.ResumeLayout(false);
            this.panelRoomInformation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelRoomInformation;
        private System.Windows.Forms.Label labelComputerNumber;
        private System.Windows.Forms.Label labelRoomID;
        private System.Windows.Forms.Panel panelComputerGrid;
        private System.Windows.Forms.Panel panelAdminControl;
        private System.Windows.Forms.Button buttonUpdate;
    }
}