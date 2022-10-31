namespace CyberGamingManagement.AdminForm
{
    partial class ShiftManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShiftManagement));
            this.labeLQ = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxShiftType = new System.Windows.Forms.ComboBox();
            this.dataGridViewShift = new System.Windows.Forms.DataGridView();
            this.buttonDeleteShift = new System.Windows.Forms.Button();
            this.buttonUpdateShift = new System.Windows.Forms.Button();
            this.buttonNewShift = new System.Windows.Forms.Button();
            this.labelStartTime = new System.Windows.Forms.Label();
            this.labelEndTime = new System.Windows.Forms.Label();
            this.comboBoxWeekDate = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonAutoAssign = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxEmployee = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxRoom = new System.Windows.Forms.ComboBox();
            this.buttonClearSchedules = new System.Windows.Forms.Button();
            this.buttonReload = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShift)).BeginInit();
            this.SuspendLayout();
            // 
            // labeLQ
            // 
            this.labeLQ.AutoSize = true;
            this.labeLQ.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.labeLQ.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.labeLQ.Location = new System.Drawing.Point(12, 162);
            this.labeLQ.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labeLQ.Name = "labeLQ";
            this.labeLQ.Size = new System.Drawing.Size(94, 23);
            this.labeLQ.TabIndex = 11;
            this.labeLQ.Text = "Start Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.label3.Location = new System.Drawing.Point(15, 205);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 23);
            this.label3.TabIndex = 16;
            this.label3.Text = "End Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.label4.Location = new System.Drawing.Point(12, 122);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 23);
            this.label4.TabIndex = 19;
            this.label4.Text = "Shift Type";
            // 
            // comboBoxShiftType
            // 
            this.comboBoxShiftType.AutoCompleteCustomSource.AddRange(new string[] {
            "Morning Shift",
            "Noon Shift",
            "Evening Shift",
            "Night Shift"});
            this.comboBoxShiftType.FormattingEnabled = true;
            this.comboBoxShiftType.Items.AddRange(new object[] {
            "Morning Shift",
            "Noon Shift",
            "Afternoon Shift",
            "Night Shift"});
            this.comboBoxShiftType.Location = new System.Drawing.Point(125, 122);
            this.comboBoxShiftType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxShiftType.Name = "comboBoxShiftType";
            this.comboBoxShiftType.Size = new System.Drawing.Size(160, 24);
            this.comboBoxShiftType.TabIndex = 18;
            this.comboBoxShiftType.SelectedIndexChanged += new System.EventHandler(this.comboBoxShiftType_SelectedIndexChanged);
            // 
            // dataGridViewShift
            // 
            this.dataGridViewShift.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShift.Location = new System.Drawing.Point(387, 22);
            this.dataGridViewShift.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewShift.Name = "dataGridViewShift";
            this.dataGridViewShift.RowHeadersWidth = 51;
            this.dataGridViewShift.Size = new System.Drawing.Size(1089, 493);
            this.dataGridViewShift.TabIndex = 22;
            this.dataGridViewShift.Click += new System.EventHandler(this.dataGridViewShift_Click);
            // 
            // buttonDeleteShift
            // 
            this.buttonDeleteShift.AllowDrop = true;
            this.buttonDeleteShift.BackColor = System.Drawing.Color.Red;
            this.buttonDeleteShift.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDeleteShift.FlatAppearance.BorderSize = 0;
            this.buttonDeleteShift.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteShift.ForeColor = System.Drawing.Color.White;
            this.buttonDeleteShift.Location = new System.Drawing.Point(15, 413);
            this.buttonDeleteShift.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonDeleteShift.Name = "buttonDeleteShift";
            this.buttonDeleteShift.Size = new System.Drawing.Size(269, 47);
            this.buttonDeleteShift.TabIndex = 101;
            this.buttonDeleteShift.Text = "DELETE";
            this.buttonDeleteShift.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonDeleteShift.UseVisualStyleBackColor = false;
            this.buttonDeleteShift.Click += new System.EventHandler(this.buttonDeleteShift_Click);
            // 
            // buttonUpdateShift
            // 
            this.buttonUpdateShift.AllowDrop = true;
            this.buttonUpdateShift.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.buttonUpdateShift.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUpdateShift.FlatAppearance.BorderSize = 0;
            this.buttonUpdateShift.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdateShift.ForeColor = System.Drawing.Color.Black;
            this.buttonUpdateShift.Location = new System.Drawing.Point(15, 245);
            this.buttonUpdateShift.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonUpdateShift.Name = "buttonUpdateShift";
            this.buttonUpdateShift.Size = new System.Drawing.Size(269, 47);
            this.buttonUpdateShift.TabIndex = 100;
            this.buttonUpdateShift.Text = "UPDATE SHIFT";
            this.buttonUpdateShift.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonUpdateShift.UseVisualStyleBackColor = false;
            this.buttonUpdateShift.Click += new System.EventHandler(this.buttonUpdateShift_Click);
            // 
            // buttonNewShift
            // 
            this.buttonNewShift.AllowDrop = true;
            this.buttonNewShift.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonNewShift.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonNewShift.FlatAppearance.BorderSize = 0;
            this.buttonNewShift.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNewShift.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonNewShift.ForeColor = System.Drawing.Color.White;
            this.buttonNewShift.Location = new System.Drawing.Point(16, 359);
            this.buttonNewShift.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonNewShift.Name = "buttonNewShift";
            this.buttonNewShift.Size = new System.Drawing.Size(268, 43);
            this.buttonNewShift.TabIndex = 99;
            this.buttonNewShift.Text = "NEW SHIFT";
            this.buttonNewShift.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonNewShift.UseVisualStyleBackColor = false;
            this.buttonNewShift.Click += new System.EventHandler(this.buttonNewShift_Click);
            // 
            // labelStartTime
            // 
            this.labelStartTime.AllowDrop = true;
            this.labelStartTime.AutoSize = true;
            this.labelStartTime.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStartTime.ForeColor = System.Drawing.Color.Teal;
            this.labelStartTime.Location = new System.Drawing.Point(143, 153);
            this.labelStartTime.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelStartTime.Name = "labelStartTime";
            this.labelStartTime.Size = new System.Drawing.Size(112, 32);
            this.labelStartTime.TabIndex = 118;
            this.labelStartTime.Text = "00:00:00";
            // 
            // labelEndTime
            // 
            this.labelEndTime.AllowDrop = true;
            this.labelEndTime.AutoSize = true;
            this.labelEndTime.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEndTime.ForeColor = System.Drawing.Color.Teal;
            this.labelEndTime.Location = new System.Drawing.Point(143, 196);
            this.labelEndTime.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelEndTime.Name = "labelEndTime";
            this.labelEndTime.Size = new System.Drawing.Size(112, 32);
            this.labelEndTime.TabIndex = 119;
            this.labelEndTime.Text = "00:00:00";
            // 
            // comboBoxWeekDate
            // 
            this.comboBoxWeekDate.FormattingEnabled = true;
            this.comboBoxWeekDate.Items.AddRange(new object[] {
            "Monday",
            "TuesDay",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"});
            this.comboBoxWeekDate.Location = new System.Drawing.Point(125, 90);
            this.comboBoxWeekDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxWeekDate.Name = "comboBoxWeekDate";
            this.comboBoxWeekDate.Size = new System.Drawing.Size(160, 24);
            this.comboBoxWeekDate.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.label5.Location = new System.Drawing.Point(12, 90);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 23);
            this.label5.TabIndex = 21;
            this.label5.Text = "Week Date";
            // 
            // buttonAutoAssign
            // 
            this.buttonAutoAssign.BackColor = System.Drawing.Color.BurlyWood;
            this.buttonAutoAssign.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAutoAssign.FlatAppearance.BorderSize = 0;
            this.buttonAutoAssign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAutoAssign.ForeColor = System.Drawing.Color.White;
            this.buttonAutoAssign.Location = new System.Drawing.Point(15, 299);
            this.buttonAutoAssign.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAutoAssign.Name = "buttonAutoAssign";
            this.buttonAutoAssign.Size = new System.Drawing.Size(269, 47);
            this.buttonAutoAssign.TabIndex = 134;
            this.buttonAutoAssign.Text = "ASSIGN AUTOMATICALLY";
            this.buttonAutoAssign.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonAutoAssign.UseVisualStyleBackColor = false;
            this.buttonAutoAssign.Click += new System.EventHandler(this.buttonAutoAssign_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.label1.Location = new System.Drawing.Point(12, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 23);
            this.label1.TabIndex = 136;
            this.label1.Text = "Employee";
            // 
            // comboBoxEmployee
            // 
            this.comboBoxEmployee.AutoCompleteCustomSource.AddRange(new string[] {
            "Morning Shift",
            "Noon Shift",
            "Evening Shift",
            "Night Shift"});
            this.comboBoxEmployee.FormattingEnabled = true;
            this.comboBoxEmployee.Items.AddRange(new object[] {
            "Morning Shift",
            "Noon Shift",
            "Afternoon Shift",
            "Nigh Shift"});
            this.comboBoxEmployee.Location = new System.Drawing.Point(125, 58);
            this.comboBoxEmployee.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxEmployee.Name = "comboBoxEmployee";
            this.comboBoxEmployee.Size = new System.Drawing.Size(160, 24);
            this.comboBoxEmployee.TabIndex = 135;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.label2.Location = new System.Drawing.Point(12, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 23);
            this.label2.TabIndex = 138;
            this.label2.Text = "Room";
            // 
            // comboBoxRoom
            // 
            this.comboBoxRoom.FormattingEnabled = true;
            this.comboBoxRoom.Items.AddRange(new object[] {
            "Monday",
            "TuesDay",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"});
            this.comboBoxRoom.Location = new System.Drawing.Point(125, 22);
            this.comboBoxRoom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxRoom.Name = "comboBoxRoom";
            this.comboBoxRoom.Size = new System.Drawing.Size(160, 24);
            this.comboBoxRoom.TabIndex = 137;
            // 
            // buttonClearSchedules
            // 
            this.buttonClearSchedules.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonClearSchedules.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClearSchedules.FlatAppearance.BorderSize = 0;
            this.buttonClearSchedules.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClearSchedules.ForeColor = System.Drawing.Color.White;
            this.buttonClearSchedules.Location = new System.Drawing.Point(16, 468);
            this.buttonClearSchedules.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonClearSchedules.Name = "buttonClearSchedules";
            this.buttonClearSchedules.Size = new System.Drawing.Size(268, 47);
            this.buttonClearSchedules.TabIndex = 140;
            this.buttonClearSchedules.Text = "CLEAR ALL SCHEDULES";
            this.buttonClearSchedules.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonClearSchedules.UseVisualStyleBackColor = false;
            this.buttonClearSchedules.Click += new System.EventHandler(this.buttonClearSchedules_Click);
            // 
            // buttonReload
            // 
            this.buttonReload.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonReload.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonReload.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonReload.BackgroundImage")));
            this.buttonReload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonReload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonReload.FlatAppearance.BorderSize = 0;
            this.buttonReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReload.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReload.ForeColor = System.Drawing.Color.RosyBrown;
            this.buttonReload.Location = new System.Drawing.Point(311, 22);
            this.buttonReload.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.buttonReload.Name = "buttonReload";
            this.buttonReload.Size = new System.Drawing.Size(54, 59);
            this.buttonReload.TabIndex = 139;
            this.buttonReload.UseVisualStyleBackColor = false;
            this.buttonReload.Click += new System.EventHandler(this.buttonReload_Click);
            // 
            // ShiftManagement
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonClearSchedules);
            this.Controls.Add(this.buttonReload);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxRoom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxEmployee);
            this.Controls.Add(this.buttonAutoAssign);
            this.Controls.Add(this.labelEndTime);
            this.Controls.Add(this.labelStartTime);
            this.Controls.Add(this.buttonDeleteShift);
            this.Controls.Add(this.buttonUpdateShift);
            this.Controls.Add(this.buttonNewShift);
            this.Controls.Add(this.dataGridViewShift);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxWeekDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxShiftType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labeLQ);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ShiftManagement";
            this.Size = new System.Drawing.Size(1497, 529);
            this.Load += new System.EventHandler(this.ShiftManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShift)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labeLQ;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxShiftType;
        private System.Windows.Forms.DataGridView dataGridViewShift;
        private System.Windows.Forms.Button buttonDeleteShift;
        private System.Windows.Forms.Button buttonUpdateShift;
        private System.Windows.Forms.Button buttonNewShift;
        public System.Windows.Forms.Label labelStartTime;
        public System.Windows.Forms.Label labelEndTime;
        private System.Windows.Forms.ComboBox comboBoxWeekDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonAutoAssign;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxEmployee;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxRoom;
        private System.Windows.Forms.Button buttonReload;
        private System.Windows.Forms.Button buttonClearSchedules;
    }
}
