namespace CyberGamingManagement.AdminForm
{
    partial class Dashboard
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
            this.dataGridViewSchedule = new System.Windows.Forms.DataGridView();
            this.buttonToday = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.labelTotalPayment = new System.Windows.Forms.Label();
            this.labelEmployees = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelUsers = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelManagers = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSchedule)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSchedule
            // 
            this.dataGridViewSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSchedule.Location = new System.Drawing.Point(27, 329);
            this.dataGridViewSchedule.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewSchedule.Name = "dataGridViewSchedule";
            this.dataGridViewSchedule.RowHeadersWidth = 51;
            this.dataGridViewSchedule.Size = new System.Drawing.Size(574, 313);
            this.dataGridViewSchedule.TabIndex = 23;
            this.dataGridViewSchedule.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSchedule_CellContentClick);
            // 
            // buttonToday
            // 
            this.buttonToday.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonToday.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonToday.FlatAppearance.BorderSize = 0;
            this.buttonToday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonToday.ForeColor = System.Drawing.Color.White;
            this.buttonToday.Location = new System.Drawing.Point(27, 240);
            this.buttonToday.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.buttonToday.Name = "buttonToday";
            this.buttonToday.Size = new System.Drawing.Size(574, 80);
            this.buttonToday.TabIndex = 86;
            this.buttonToday.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonToday.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Historic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.label2.Location = new System.Drawing.Point(20, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(345, 38);
            this.label2.TabIndex = 87;
            this.label2.Text = "Total Employee Payment";
            // 
            // labelTotalPayment
            // 
            this.labelTotalPayment.AllowDrop = true;
            this.labelTotalPayment.AutoSize = true;
            this.labelTotalPayment.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalPayment.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.labelTotalPayment.Location = new System.Drawing.Point(475, 13);
            this.labelTotalPayment.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelTotalPayment.Name = "labelTotalPayment";
            this.labelTotalPayment.Size = new System.Drawing.Size(40, 46);
            this.labelTotalPayment.TabIndex = 99;
            this.labelTotalPayment.Text = "$";
            // 
            // labelEmployees
            // 
            this.labelEmployees.AllowDrop = true;
            this.labelEmployees.AutoSize = true;
            this.labelEmployees.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmployees.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.labelEmployees.Location = new System.Drawing.Point(395, 173);
            this.labelEmployees.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelEmployees.Name = "labelEmployees";
            this.labelEmployees.Size = new System.Drawing.Size(40, 46);
            this.labelEmployees.TabIndex = 101;
            this.labelEmployees.Text = "$";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Historic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.label3.Location = new System.Drawing.Point(20, 181);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(312, 38);
            this.label3.TabIndex = 100;
            this.label3.Text = "Number of Employees";
            // 
            // labelUsers
            // 
            this.labelUsers.AllowDrop = true;
            this.labelUsers.AutoSize = true;
            this.labelUsers.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsers.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.labelUsers.Location = new System.Drawing.Point(395, 74);
            this.labelUsers.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelUsers.Name = "labelUsers";
            this.labelUsers.Size = new System.Drawing.Size(40, 46);
            this.labelUsers.TabIndex = 103;
            this.labelUsers.Text = "$";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Historic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.label5.Location = new System.Drawing.Point(20, 74);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(243, 38);
            this.label5.TabIndex = 102;
            this.label5.Text = "Number of Users";
            // 
            // labelManagers
            // 
            this.labelManagers.AllowDrop = true;
            this.labelManagers.AutoSize = true;
            this.labelManagers.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelManagers.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.labelManagers.Location = new System.Drawing.Point(395, 120);
            this.labelManagers.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelManagers.Name = "labelManagers";
            this.labelManagers.Size = new System.Drawing.Size(40, 46);
            this.labelManagers.TabIndex = 105;
            this.labelManagers.Text = "$";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Historic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.label7.Location = new System.Drawing.Point(20, 129);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(300, 38);
            this.label7.TabIndex = 104;
            this.label7.Text = "Number of Managers";
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(363, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 46);
            this.label1.TabIndex = 106;
            this.label1.Text = "VND";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelManagers);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelUsers);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelEmployees);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelTotalPayment);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonToday);
            this.Controls.Add(this.dataGridViewSchedule);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Dashboard";
            this.Size = new System.Drawing.Size(632, 665);
            this.Load += new System.EventHandler(this.Schedule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSchedule)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSchedule;
        private System.Windows.Forms.Button buttonToday;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label labelTotalPayment;
        public System.Windows.Forms.Label labelEmployees;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label labelUsers;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label labelManagers;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label1;
    }
}
