namespace InternetCafeManagement.AdminForm
{
    partial class ComputerRoomManagerForm
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
            this.comboBoxComputerRoomId = new System.Windows.Forms.ComboBox();
            this.textBoxComputerRoomID = new System.Windows.Forms.Label();
            this.buttonAddRoom = new System.Windows.Forms.Button();
            this.buttonDeleteRoom = new System.Windows.Forms.Button();
            this.buttonManage = new System.Windows.Forms.Button();
            this.buttonReload = new System.Windows.Forms.Button();
            this.labelRoomCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxComputerRoomId
            // 
            this.comboBoxComputerRoomId.FormattingEnabled = true;
            this.comboBoxComputerRoomId.Location = new System.Drawing.Point(25, 57);
            this.comboBoxComputerRoomId.Name = "comboBoxComputerRoomId";
            this.comboBoxComputerRoomId.Size = new System.Drawing.Size(159, 21);
            this.comboBoxComputerRoomId.TabIndex = 0;
            // 
            // textBoxComputerRoomID
            // 
            this.textBoxComputerRoomID.AutoSize = true;
            this.textBoxComputerRoomID.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxComputerRoomID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.textBoxComputerRoomID.Location = new System.Drawing.Point(22, 25);
            this.textBoxComputerRoomID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.textBoxComputerRoomID.Name = "textBoxComputerRoomID";
            this.textBoxComputerRoomID.Size = new System.Drawing.Size(134, 25);
            this.textBoxComputerRoomID.TabIndex = 84;
            this.textBoxComputerRoomID.Text = "Choose Room";
            // 
            // buttonAddRoom
            // 
            this.buttonAddRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.buttonAddRoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddRoom.FlatAppearance.BorderSize = 0;
            this.buttonAddRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddRoom.ForeColor = System.Drawing.Color.White;
            this.buttonAddRoom.Location = new System.Drawing.Point(23, 151);
            this.buttonAddRoom.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddRoom.Name = "buttonAddRoom";
            this.buttonAddRoom.Size = new System.Drawing.Size(121, 34);
            this.buttonAddRoom.TabIndex = 85;
            this.buttonAddRoom.Text = "ADD ROOM";
            this.buttonAddRoom.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonAddRoom.UseVisualStyleBackColor = false;
            this.buttonAddRoom.Click += new System.EventHandler(this.buttonAddRoom_Click);
            // 
            // buttonDeleteRoom
            // 
            this.buttonDeleteRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonDeleteRoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDeleteRoom.FlatAppearance.BorderSize = 0;
            this.buttonDeleteRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteRoom.ForeColor = System.Drawing.Color.MistyRose;
            this.buttonDeleteRoom.Location = new System.Drawing.Point(152, 151);
            this.buttonDeleteRoom.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDeleteRoom.Name = "buttonDeleteRoom";
            this.buttonDeleteRoom.Size = new System.Drawing.Size(109, 34);
            this.buttonDeleteRoom.TabIndex = 86;
            this.buttonDeleteRoom.Text = "DELETE ROOM";
            this.buttonDeleteRoom.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonDeleteRoom.UseVisualStyleBackColor = false;
            this.buttonDeleteRoom.Click += new System.EventHandler(this.buttonDeleteRoom_Click);
            // 
            // buttonManage
            // 
            this.buttonManage.BackColor = System.Drawing.Color.PaleGreen;
            this.buttonManage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonManage.FlatAppearance.BorderSize = 0;
            this.buttonManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonManage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonManage.ForeColor = System.Drawing.Color.RosyBrown;
            this.buttonManage.Location = new System.Drawing.Point(25, 103);
            this.buttonManage.Margin = new System.Windows.Forms.Padding(4);
            this.buttonManage.Name = "buttonManage";
            this.buttonManage.Size = new System.Drawing.Size(236, 34);
            this.buttonManage.TabIndex = 87;
            this.buttonManage.Text = "MANAGE";
            this.buttonManage.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonManage.UseVisualStyleBackColor = false;
            this.buttonManage.Click += new System.EventHandler(this.buttonManage_Click);
            // 
            // buttonReload
            // 
            this.buttonReload.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonReload.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonReload.BackgroundImage = global::InternetCafeManagement.Properties.Resources.reload;
            this.buttonReload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonReload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonReload.FlatAppearance.BorderSize = 0;
            this.buttonReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReload.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReload.ForeColor = System.Drawing.Color.RosyBrown;
            this.buttonReload.Location = new System.Drawing.Point(240, 25);
            this.buttonReload.Margin = new System.Windows.Forms.Padding(4);
            this.buttonReload.Name = "buttonReload";
            this.buttonReload.Size = new System.Drawing.Size(23, 25);
            this.buttonReload.TabIndex = 88;
            this.buttonReload.UseVisualStyleBackColor = false;
            this.buttonReload.Click += new System.EventHandler(this.buttonReload_Click);
            // 
            // labelRoomCount
            // 
            this.labelRoomCount.AutoSize = true;
            this.labelRoomCount.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRoomCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.labelRoomCount.Location = new System.Drawing.Point(191, 53);
            this.labelRoomCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRoomCount.Name = "labelRoomCount";
            this.labelRoomCount.Size = new System.Drawing.Size(34, 25);
            this.labelRoomCount.TabIndex = 89;
            this.labelRoomCount.Text = "10";
            // 
            // ComputerRoomManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(290, 216);
            this.Controls.Add(this.labelRoomCount);
            this.Controls.Add(this.buttonReload);
            this.Controls.Add(this.buttonManage);
            this.Controls.Add(this.buttonDeleteRoom);
            this.Controls.Add(this.buttonAddRoom);
            this.Controls.Add(this.textBoxComputerRoomID);
            this.Controls.Add(this.comboBoxComputerRoomId);
            this.Name = "ComputerRoomManagerForm";
            this.Text = "Room Manager";
            this.Load += new System.EventHandler(this.ComputerRoomManagerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxComputerRoomId;
        private System.Windows.Forms.Label textBoxComputerRoomID;
        private System.Windows.Forms.Button buttonAddRoom;
        private System.Windows.Forms.Button buttonDeleteRoom;
        private System.Windows.Forms.Button buttonManage;
        private System.Windows.Forms.Button buttonReload;
        private System.Windows.Forms.Label labelRoomCount;
    }
}