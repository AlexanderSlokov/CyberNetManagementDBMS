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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelComputerGrid = new System.Windows.Forms.Panel();
            this.panelRoomInformation = new System.Windows.Forms.Panel();
            this.labelComputerNumber = new System.Windows.Forms.Label();
            this.labelRoomID = new System.Windows.Forms.Label();
            this.panelMain.SuspendLayout();
            this.panelRoomInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.panel2);
            this.panelMain.Controls.Add(this.panelComputerGrid);
            this.panelMain.Controls.Add(this.panelRoomInformation);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1643, 737);
            this.panelMain.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(1265, 92);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(375, 855);
            this.panel2.TabIndex = 2;
            // 
            // panelComputerGrid
            // 
            this.panelComputerGrid.Location = new System.Drawing.Point(0, 92);
            this.panelComputerGrid.Name = "panelComputerGrid";
            this.panelComputerGrid.Size = new System.Drawing.Size(1259, 852);
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
            this.ClientSize = new System.Drawing.Size(1643, 737);
            this.Controls.Add(this.panelMain);
            this.Name = "ComputerRoomManageForm";
            this.Text = "ComputerRoomManageForm";
            this.Load += new System.EventHandler(this.ComputerRoomManageForm_Load);
            this.panelMain.ResumeLayout(false);
            this.panelRoomInformation.ResumeLayout(false);
            this.panelRoomInformation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelRoomInformation;
        private System.Windows.Forms.Label labelComputerNumber;
        private System.Windows.Forms.Label labelRoomID;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelComputerGrid;
    }
}