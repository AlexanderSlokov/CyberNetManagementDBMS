namespace CyberGamingManagement.Account_Form
{
    partial class formLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formLogin));
            this.labelCreateAccount = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.checkBoxShowPassword = new System.Windows.Forms.CheckBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonUser = new System.Windows.Forms.RadioButton();
            this.radioButtonEmployee = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // labelCreateAccount
            // 
            this.labelCreateAccount.AutoSize = true;
            this.labelCreateAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelCreateAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.labelCreateAccount.Location = new System.Drawing.Point(95, 464);
            this.labelCreateAccount.Name = "labelCreateAccount";
            this.labelCreateAccount.Size = new System.Drawing.Size(132, 23);
            this.labelCreateAccount.TabIndex = 16;
            this.labelCreateAccount.Text = "Create Account";
            this.labelCreateAccount.Click += new System.EventHandler(this.labelCreateAccount_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(72, 438);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(189, 23);
            this.label5.TabIndex = 17;
            this.label5.Text = "Dont Have an Account";
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.White;
            this.buttonClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.buttonClear.Location = new System.Drawing.Point(37, 387);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(216, 35);
            this.buttonClear.TabIndex = 14;
            this.buttonClear.Text = "CLEAR";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.buttonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogin.FlatAppearance.BorderSize = 0;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.ForeColor = System.Drawing.Color.White;
            this.buttonLogin.Location = new System.Drawing.Point(37, 346);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(216, 35);
            this.buttonLogin.TabIndex = 15;
            this.buttonLogin.Text = "LOGIN";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // checkBoxShowPassword
            // 
            this.checkBoxShowPassword.AutoSize = true;
            this.checkBoxShowPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxShowPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxShowPassword.Location = new System.Drawing.Point(102, 243);
            this.checkBoxShowPassword.Name = "checkBoxShowPassword";
            this.checkBoxShowPassword.Size = new System.Drawing.Size(151, 27);
            this.checkBoxShowPassword.TabIndex = 13;
            this.checkBoxShowPassword.Text = "Show Password";
            this.checkBoxShowPassword.UseVisualStyleBackColor = true;
            this.checkBoxShowPassword.CheckedChanged += new System.EventHandler(this.checkBoxShowPassword_CheckedChanged);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPassword.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.textBoxPassword.Location = new System.Drawing.Point(37, 201);
            this.textBoxPassword.Multiline = true;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '•';
            this.textBoxPassword.Size = new System.Drawing.Size(216, 28);
            this.textBoxPassword.TabIndex = 11;
            this.textBoxPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxPassword_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "Password";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.textBoxUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUsername.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.textBoxUsername.Location = new System.Drawing.Point(37, 136);
            this.textBoxUsername.Multiline = true;
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(216, 28);
            this.textBoxUsername.TabIndex = 12;
            this.textBoxUsername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxUsername_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.BlueViolet;
            this.label1.Location = new System.Drawing.Point(32, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 34);
            this.label1.TabIndex = 6;
            this.label1.Text = "Get Started";
            // 
            // radioButtonUser
            // 
            this.radioButtonUser.AutoSize = true;
            this.radioButtonUser.Checked = true;
            this.radioButtonUser.Location = new System.Drawing.Point(37, 276);
            this.radioButtonUser.Name = "radioButtonUser";
            this.radioButtonUser.Size = new System.Drawing.Size(66, 27);
            this.radioButtonUser.TabIndex = 18;
            this.radioButtonUser.TabStop = true;
            this.radioButtonUser.Text = "User";
            this.radioButtonUser.UseVisualStyleBackColor = true;
            // 
            // radioButtonEmployee
            // 
            this.radioButtonEmployee.AutoSize = true;
            this.radioButtonEmployee.Location = new System.Drawing.Point(146, 276);
            this.radioButtonEmployee.Name = "radioButtonEmployee";
            this.radioButtonEmployee.Size = new System.Drawing.Size(109, 27);
            this.radioButtonEmployee.TabIndex = 19;
            this.radioButtonEmployee.Text = "Employee";
            this.radioButtonEmployee.UseVisualStyleBackColor = true;
            this.radioButtonEmployee.CheckedChanged += new System.EventHandler(this.radioButtonEmployee_CheckedChanged);
            // 
            // formLogin
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(289, 519);
            this.Controls.Add(this.radioButtonEmployee);
            this.Controls.Add(this.radioButtonUser);
            this.Controls.Add(this.labelCreateAccount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.checkBoxShowPassword);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.formLogin_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.formLogin_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCreateAccount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.CheckBox checkBoxShowPassword;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonUser;
        private System.Windows.Forms.RadioButton radioButtonEmployee;
    }
}