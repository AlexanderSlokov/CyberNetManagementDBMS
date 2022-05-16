namespace InternetCafeManagement.AdminForm
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
            this.comboBoxRoomID = new System.Windows.Forms.ComboBox();
            this.labeLQ = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxShiftID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxShiftType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxWeekDate = new System.Windows.Forms.ComboBox();
            this.dataGridViewShift = new System.Windows.Forms.DataGridView();
            this.buttonDeleteShift = new System.Windows.Forms.Button();
            this.buttonUpdateShift = new System.Windows.Forms.Button();
            this.buttonNewShift = new System.Windows.Forms.Button();
            this.buttonChangeStatus = new System.Windows.Forms.Button();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShift)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxRoomID
            // 
            this.comboBoxRoomID.FormattingEnabled = true;
            this.comboBoxRoomID.Location = new System.Drawing.Point(102, 67);
            this.comboBoxRoomID.Name = "comboBoxRoomID";
            this.comboBoxRoomID.Size = new System.Drawing.Size(121, 21);
            this.comboBoxRoomID.TabIndex = 0;
            // 
            // labeLQ
            // 
            this.labeLQ.AutoSize = true;
            this.labeLQ.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.labeLQ.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.labeLQ.Location = new System.Drawing.Point(251, 27);
            this.labeLQ.Name = "labeLQ";
            this.labeLQ.Size = new System.Drawing.Size(72, 17);
            this.labeLQ.TabIndex = 11;
            this.labeLQ.Text = "Start Time";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.label1.Location = new System.Drawing.Point(17, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Room ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.label2.Location = new System.Drawing.Point(17, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Shift ID";
            // 
            // textBoxShiftID
            // 
            this.textBoxShiftID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.textBoxShiftID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxShiftID.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.textBoxShiftID.Location = new System.Drawing.Point(102, 20);
            this.textBoxShiftID.Multiline = true;
            this.textBoxShiftID.Name = "textBoxShiftID";
            this.textBoxShiftID.Size = new System.Drawing.Size(121, 28);
            this.textBoxShiftID.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.label3.Location = new System.Drawing.Point(251, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "End Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.label4.Location = new System.Drawing.Point(251, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 17);
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
            this.comboBoxShiftType.Location = new System.Drawing.Point(336, 122);
            this.comboBoxShiftType.Name = "comboBoxShiftType";
            this.comboBoxShiftType.Size = new System.Drawing.Size(164, 21);
            this.comboBoxShiftType.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.label5.Location = new System.Drawing.Point(17, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "Week Date";
            // 
            // comboBoxWeekDate
            // 
            this.comboBoxWeekDate.FormattingEnabled = true;
            this.comboBoxWeekDate.Location = new System.Drawing.Point(102, 122);
            this.comboBoxWeekDate.Name = "comboBoxWeekDate";
            this.comboBoxWeekDate.Size = new System.Drawing.Size(121, 21);
            this.comboBoxWeekDate.TabIndex = 20;
            // 
            // dataGridViewShift
            // 
            this.dataGridViewShift.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShift.Location = new System.Drawing.Point(653, 3);
            this.dataGridViewShift.Name = "dataGridViewShift";
            this.dataGridViewShift.Size = new System.Drawing.Size(389, 362);
            this.dataGridViewShift.TabIndex = 22;
            // 
            // buttonDeleteShift
            // 
            this.buttonDeleteShift.AllowDrop = true;
            this.buttonDeleteShift.BackColor = System.Drawing.Color.Red;
            this.buttonDeleteShift.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDeleteShift.FlatAppearance.BorderSize = 0;
            this.buttonDeleteShift.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteShift.ForeColor = System.Drawing.Color.White;
            this.buttonDeleteShift.Location = new System.Drawing.Point(155, 189);
            this.buttonDeleteShift.Name = "buttonDeleteShift";
            this.buttonDeleteShift.Size = new System.Drawing.Size(93, 38);
            this.buttonDeleteShift.TabIndex = 101;
            this.buttonDeleteShift.Text = "DELETE";
            this.buttonDeleteShift.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonDeleteShift.UseVisualStyleBackColor = false;
            this.buttonDeleteShift.Click += new System.EventHandler(this.buttonDeleteShift_Click);
            // 
            // buttonUpdateShift
            // 
            this.buttonUpdateShift.AllowDrop = true;
            this.buttonUpdateShift.BackColor = System.Drawing.Color.Turquoise;
            this.buttonUpdateShift.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUpdateShift.FlatAppearance.BorderSize = 0;
            this.buttonUpdateShift.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdateShift.ForeColor = System.Drawing.Color.Black;
            this.buttonUpdateShift.Location = new System.Drawing.Point(54, 189);
            this.buttonUpdateShift.Name = "buttonUpdateShift";
            this.buttonUpdateShift.Size = new System.Drawing.Size(93, 38);
            this.buttonUpdateShift.TabIndex = 100;
            this.buttonUpdateShift.Text = "UPDATE SHIFT";
            this.buttonUpdateShift.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonUpdateShift.UseVisualStyleBackColor = false;
            this.buttonUpdateShift.Click += new System.EventHandler(this.buttonUpdateShift_Click);
            // 
            // buttonNewShift
            // 
            this.buttonNewShift.AllowDrop = true;
            this.buttonNewShift.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.buttonNewShift.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonNewShift.FlatAppearance.BorderSize = 0;
            this.buttonNewShift.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNewShift.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonNewShift.ForeColor = System.Drawing.Color.White;
            this.buttonNewShift.Location = new System.Drawing.Point(254, 189);
            this.buttonNewShift.Name = "buttonNewShift";
            this.buttonNewShift.Size = new System.Drawing.Size(93, 38);
            this.buttonNewShift.TabIndex = 99;
            this.buttonNewShift.Text = "NEW SHIFT";
            this.buttonNewShift.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonNewShift.UseVisualStyleBackColor = false;
            this.buttonNewShift.Click += new System.EventHandler(this.buttonNewShift_Click);
            // 
            // buttonChangeStatus
            // 
            this.buttonChangeStatus.AllowDrop = true;
            this.buttonChangeStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonChangeStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonChangeStatus.FlatAppearance.BorderSize = 0;
            this.buttonChangeStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChangeStatus.ForeColor = System.Drawing.Color.White;
            this.buttonChangeStatus.Location = new System.Drawing.Point(353, 189);
            this.buttonChangeStatus.Name = "buttonChangeStatus";
            this.buttonChangeStatus.Size = new System.Drawing.Size(93, 38);
            this.buttonChangeStatus.TabIndex = 98;
            this.buttonChangeStatus.Text = "CHANGE STATUS";
            this.buttonChangeStatus.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonChangeStatus.UseVisualStyleBackColor = false;
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.Location = new System.Drawing.Point(336, 27);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(164, 20);
            this.dateTimePickerStart.TabIndex = 102;
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.Location = new System.Drawing.Point(336, 67);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(164, 20);
            this.dateTimePickerEnd.TabIndex = 103;
            // 
            // ShiftManagement
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dateTimePickerEnd);
            this.Controls.Add(this.dateTimePickerStart);
            this.Controls.Add(this.buttonDeleteShift);
            this.Controls.Add(this.buttonUpdateShift);
            this.Controls.Add(this.buttonNewShift);
            this.Controls.Add(this.buttonChangeStatus);
            this.Controls.Add(this.dataGridViewShift);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxWeekDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxShiftType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxShiftID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labeLQ);
            this.Controls.Add(this.comboBoxRoomID);
            this.Name = "ShiftManagement";
            this.Size = new System.Drawing.Size(1045, 369);
            this.Load += new System.EventHandler(this.ShiftManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShift)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxRoomID;
        private System.Windows.Forms.Label labeLQ;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxShiftID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxShiftType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxWeekDate;
        private System.Windows.Forms.DataGridView dataGridViewShift;
        private System.Windows.Forms.Button buttonDeleteShift;
        private System.Windows.Forms.Button buttonUpdateShift;
        private System.Windows.Forms.Button buttonNewShift;
        private System.Windows.Forms.Button buttonChangeStatus;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
    }
}
