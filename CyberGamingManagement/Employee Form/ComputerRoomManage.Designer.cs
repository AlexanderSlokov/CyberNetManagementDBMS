namespace CyberGamingManagement.Employee_Form
{
    partial class ComputerRoomManageUC
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
            this.buttonReload = new System.Windows.Forms.Button();
            this.panelAdminControl = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelComputerGrid = new System.Windows.Forms.Panel();
            this.panelRoomInformation = new System.Windows.Forms.Panel();
            this.labelComputerNumber = new System.Windows.Forms.Label();
            this.labelRoomID = new System.Windows.Forms.Label();
            this.panelMain.SuspendLayout();
            this.panelAdminControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelRoomInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.panelAdminControl);
            this.panelMain.Controls.Add(this.panelComputerGrid);
            this.panelMain.Controls.Add(this.panelRoomInformation);
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(652, 907);
            this.panelMain.TabIndex = 0;
            // 
            // buttonReload
            // 
            this.buttonReload.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonReload.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonReload.BackgroundImage = global::CyberGamingManagement.Properties.Resources.reload;
            this.buttonReload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonReload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonReload.FlatAppearance.BorderSize = 0;
            this.buttonReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReload.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReload.ForeColor = System.Drawing.Color.RosyBrown;
            this.buttonReload.Location = new System.Drawing.Point(506, -5);
            this.buttonReload.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.buttonReload.Name = "buttonReload";
            this.buttonReload.Size = new System.Drawing.Size(92, 93);
            this.buttonReload.TabIndex = 89;
            this.buttonReload.UseVisualStyleBackColor = false;
            this.buttonReload.Click += new System.EventHandler(this.buttonReload_Click);
            // 
            // panelAdminControl
            // 
            this.panelAdminControl.Controls.Add(this.dataGridView1);
            this.panelAdminControl.Location = new System.Drawing.Point(20, 360);
            this.panelAdminControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelAdminControl.Name = "panelAdminControl";
            this.panelAdminControl.Size = new System.Drawing.Size(603, 521);
            this.panelAdminControl.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 4);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(598, 517);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // panelComputerGrid
            // 
            this.panelComputerGrid.Location = new System.Drawing.Point(20, 111);
            this.panelComputerGrid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelComputerGrid.Name = "panelComputerGrid";
            this.panelComputerGrid.Size = new System.Drawing.Size(603, 241);
            this.panelComputerGrid.TabIndex = 1;
            // 
            // panelRoomInformation
            // 
            this.panelRoomInformation.Controls.Add(this.buttonReload);
            this.panelRoomInformation.Controls.Add(this.labelComputerNumber);
            this.panelRoomInformation.Controls.Add(this.labelRoomID);
            this.panelRoomInformation.Location = new System.Drawing.Point(20, 14);
            this.panelRoomInformation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelRoomInformation.Name = "panelRoomInformation";
            this.panelRoomInformation.Size = new System.Drawing.Size(603, 89);
            this.panelRoomInformation.TabIndex = 0;
            // 
            // labelComputerNumber
            // 
            this.labelComputerNumber.AutoSize = true;
            this.labelComputerNumber.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelComputerNumber.Location = new System.Drawing.Point(12, 38);
            this.labelComputerNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelComputerNumber.Name = "labelComputerNumber";
            this.labelComputerNumber.Size = new System.Drawing.Size(248, 32);
            this.labelComputerNumber.TabIndex = 1;
            this.labelComputerNumber.Text = "Computers Number:";
            // 
            // labelRoomID
            // 
            this.labelRoomID.AutoSize = true;
            this.labelRoomID.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelRoomID.Location = new System.Drawing.Point(12, 7);
            this.labelRoomID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRoomID.Name = "labelRoomID";
            this.labelRoomID.Size = new System.Drawing.Size(116, 32);
            this.labelRoomID.TabIndex = 0;
            this.labelRoomID.Text = "Room 01";
            // 
            // ComputerRoomManageUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelMain);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ComputerRoomManageUC";
            this.Size = new System.Drawing.Size(651, 907);
            this.Load += new System.EventHandler(this.ComputerRoomManageForm_Load);
            this.panelMain.ResumeLayout(false);
            this.panelAdminControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonReload;
    }
}