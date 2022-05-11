namespace InternetCafeManagement.Employee_Form
{
    partial class Timekeeping_Timer
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonTimeKeepingFind = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.TimeKeepingtimer = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.radioButtonFinnished = new System.Windows.Forms.RadioButton();
            this.radioButtonNotFinnished = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.labelTimerLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonTimerStart = new System.Windows.Forms.Button();
            this.buttonTimerFinnish = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonUnfinnishedTasksSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employees ID:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(105, 62);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(139, 20);
            this.textBox1.TabIndex = 1;
            // 
            // buttonTimeKeepingFind
            // 
            this.buttonTimeKeepingFind.Location = new System.Drawing.Point(248, 62);
            this.buttonTimeKeepingFind.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonTimeKeepingFind.Name = "buttonTimeKeepingFind";
            this.buttonTimeKeepingFind.Size = new System.Drawing.Size(56, 18);
            this.buttonTimeKeepingFind.TabIndex = 2;
            this.buttonTimeKeepingFind.Text = "Find";
            this.buttonTimeKeepingFind.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(11, 150);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(294, 110);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // TimeKeepingtimer
            // 
            this.TimeKeepingtimer.Enabled = true;
            this.TimeKeepingtimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(340, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Working Progress:";
            // 
            // radioButtonFinnished
            // 
            this.radioButtonFinnished.AutoSize = true;
            this.radioButtonFinnished.Location = new System.Drawing.Point(364, 93);
            this.radioButtonFinnished.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButtonFinnished.Name = "radioButtonFinnished";
            this.radioButtonFinnished.Size = new System.Drawing.Size(70, 17);
            this.radioButtonFinnished.TabIndex = 5;
            this.radioButtonFinnished.TabStop = true;
            this.radioButtonFinnished.Text = "Finnished";
            this.radioButtonFinnished.UseVisualStyleBackColor = true;
            // 
            // radioButtonNotFinnished
            // 
            this.radioButtonNotFinnished.AutoSize = true;
            this.radioButtonNotFinnished.Location = new System.Drawing.Point(462, 93);
            this.radioButtonNotFinnished.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButtonNotFinnished.Name = "radioButtonNotFinnished";
            this.radioButtonNotFinnished.Size = new System.Drawing.Size(90, 17);
            this.radioButtonNotFinnished.TabIndex = 6;
            this.radioButtonNotFinnished.TabStop = true;
            this.radioButtonNotFinnished.Text = "Not Finnished";
            this.radioButtonNotFinnished.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(340, 128);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Unfinnished Tasks name:";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(343, 150);
            this.richTextBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(222, 110);
            this.richTextBox2.TabIndex = 8;
            this.richTextBox2.Text = "";
            // 
            // labelTimerLabel
            // 
            this.labelTimerLabel.AutoSize = true;
            this.labelTimerLabel.Location = new System.Drawing.Point(47, 270);
            this.labelTimerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTimerLabel.Name = "labelTimerLabel";
            this.labelTimerLabel.Size = new System.Drawing.Size(58, 13);
            this.labelTimerLabel.TabIndex = 9;
            this.labelTimerLabel.Text = "Timer label";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 26);
            this.label5.TabIndex = 10;
            this.label5.Text = "Timekeeping";
            // 
            // buttonTimerStart
            // 
            this.buttonTimerStart.Location = new System.Drawing.Point(179, 267);
            this.buttonTimerStart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonTimerStart.Name = "buttonTimerStart";
            this.buttonTimerStart.Size = new System.Drawing.Size(56, 19);
            this.buttonTimerStart.TabIndex = 11;
            this.buttonTimerStart.Text = "Start";
            this.buttonTimerStart.UseVisualStyleBackColor = true;
            // 
            // buttonTimerFinnish
            // 
            this.buttonTimerFinnish.Location = new System.Drawing.Point(248, 267);
            this.buttonTimerFinnish.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonTimerFinnish.Name = "buttonTimerFinnish";
            this.buttonTimerFinnish.Size = new System.Drawing.Size(56, 19);
            this.buttonTimerFinnish.TabIndex = 12;
            this.buttonTimerFinnish.Text = "Finnish";
            this.buttonTimerFinnish.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 270);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Timer:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 91);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Employees Name:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(105, 91);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(200, 20);
            this.textBox2.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 115);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Working Date:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(105, 115);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(349, 266);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(227, 18);
            this.label8.TabIndex = 19;
            this.label8.Text = "Thank you for your contribution!";
            // 
            // buttonUnfinnishedTasksSave
            // 
            this.buttonUnfinnishedTasksSave.Location = new System.Drawing.Point(464, 126);
            this.buttonUnfinnishedTasksSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonUnfinnishedTasksSave.Name = "buttonUnfinnishedTasksSave";
            this.buttonUnfinnishedTasksSave.Size = new System.Drawing.Size(100, 19);
            this.buttonUnfinnishedTasksSave.TabIndex = 20;
            this.buttonUnfinnishedTasksSave.Text = "Save";
            this.buttonUnfinnishedTasksSave.UseVisualStyleBackColor = true;
            // 
            // Timekeeping_Timer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 307);
            this.Controls.Add(this.buttonUnfinnishedTasksSave);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonTimerFinnish);
            this.Controls.Add(this.buttonTimerStart);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelTimerLabel);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.radioButtonNotFinnished);
            this.Controls.Add(this.radioButtonFinnished);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.buttonTimeKeepingFind);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Timekeeping_Timer";
            this.Text = "Employees Timekeeping";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonTimeKeepingFind;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Timer TimeKeepingtimer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButtonFinnished;
        private System.Windows.Forms.RadioButton radioButtonNotFinnished;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Label labelTimerLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonTimerStart;
        private System.Windows.Forms.Button buttonTimerFinnish;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonUnfinnishedTasksSave;
    }
}