namespace InternetCafeManagement.AdminForm
{
    partial class SalaryUC
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
            this.dataGridViewSalaryCalculator = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSalaryCalculator)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSalaryCalculator
            // 
            this.dataGridViewSalaryCalculator.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSalaryCalculator.Location = new System.Drawing.Point(0, 55);
            this.dataGridViewSalaryCalculator.Name = "dataGridViewSalaryCalculator";
            this.dataGridViewSalaryCalculator.Size = new System.Drawing.Size(1283, 546);
            this.dataGridViewSalaryCalculator.TabIndex = 88;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label1.Location = new System.Drawing.Point(482, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 27);
            this.label1.TabIndex = 89;
            this.label1.Text = "Salary Calculation";
            // 
            // SalaryUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewSalaryCalculator);
            this.Name = "SalaryUC";
            this.Size = new System.Drawing.Size(1283, 604);
            this.Load += new System.EventHandler(this.SalaryUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSalaryCalculator)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSalaryCalculator;
        private System.Windows.Forms.Label label1;
    }
}
