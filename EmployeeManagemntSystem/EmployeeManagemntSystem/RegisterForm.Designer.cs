namespace EmployeeManagemntSystem
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.register_loginButton = new System.Windows.Forms.Button();
            this.register_signupbutton = new System.Windows.Forms.Button();
            this.register_showPassword = new System.Windows.Forms.CheckBox();
            this.register_password = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.register_username = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.register_Cfmpassword = new System.Windows.Forms.TextBox();
            this.register_showCfmPassword = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.register_loginButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(258, 380);
            this.panel1.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(51, 28);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // register_loginButton
            // 
            this.register_loginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.register_loginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.register_loginButton.FlatAppearance.BorderSize = 0;
            this.register_loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.register_loginButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_loginButton.ForeColor = System.Drawing.Color.White;
            this.register_loginButton.Location = new System.Drawing.Point(41, 330);
            this.register_loginButton.Margin = new System.Windows.Forms.Padding(2);
            this.register_loginButton.Name = "register_loginButton";
            this.register_loginButton.Size = new System.Drawing.Size(169, 38);
            this.register_loginButton.TabIndex = 1;
            this.register_loginButton.Text = "LOGIN";
            this.register_loginButton.UseVisualStyleBackColor = false;
            this.register_loginButton.Click += new System.EventHandler(this.register_loginButton_Click);
            // 
            // register_signupbutton
            // 
            this.register_signupbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.register_signupbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.register_signupbutton.FlatAppearance.BorderSize = 0;
            this.register_signupbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(137)))));
            this.register_signupbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(137)))));
            this.register_signupbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.register_signupbutton.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_signupbutton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.register_signupbutton.Location = new System.Drawing.Point(320, 331);
            this.register_signupbutton.Margin = new System.Windows.Forms.Padding(2);
            this.register_signupbutton.Name = "register_signupbutton";
            this.register_signupbutton.Size = new System.Drawing.Size(169, 38);
            this.register_signupbutton.TabIndex = 17;
            this.register_signupbutton.Text = "Register";
            this.register_signupbutton.UseVisualStyleBackColor = false;
            this.register_signupbutton.Click += new System.EventHandler(this.register_signupbutton_Click);
            // 
            // register_showPassword
            // 
            this.register_showPassword.AutoSize = true;
            this.register_showPassword.Font = new System.Drawing.Font("Tahoma", 8F);
            this.register_showPassword.Location = new System.Drawing.Point(432, 249);
            this.register_showPassword.Margin = new System.Windows.Forms.Padding(2);
            this.register_showPassword.Name = "register_showPassword";
            this.register_showPassword.Size = new System.Drawing.Size(101, 17);
            this.register_showPassword.TabIndex = 16;
            this.register_showPassword.Text = "Show Password";
            this.register_showPassword.UseVisualStyleBackColor = true;
            this.register_showPassword.CheckedChanged += new System.EventHandler(this.register_showPassword_CheckedChanged);
            // 
            // register_password
            // 
            this.register_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.register_password.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_password.Location = new System.Drawing.Point(283, 221);
            this.register_password.Margin = new System.Windows.Forms.Padding(2);
            this.register_password.Multiline = true;
            this.register_password.Name = "register_password";
            this.register_password.PasswordChar = '*';
            this.register_password.Size = new System.Drawing.Size(250, 25);
            this.register_password.TabIndex = 15;
            this.register_password.TextChanged += new System.EventHandler(this.register_password_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(262, 201);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 14);
            this.label4.TabIndex = 14;
            this.label4.Text = "Password:";
            // 
            // register_username
            // 
            this.register_username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.register_username.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_username.Location = new System.Drawing.Point(283, 164);
            this.register_username.Margin = new System.Windows.Forms.Padding(2);
            this.register_username.Multiline = true;
            this.register_username.Name = "register_username";
            this.register_username.Size = new System.Drawing.Size(250, 25);
            this.register_username.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(262, 145);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 14);
            this.label3.TabIndex = 12;
            this.label3.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(332, 95);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 23);
            this.label2.TabIndex = 11;
            this.label2.Text = "Registration";
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(522, 2);
            this.exit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(17, 18);
            this.exit.TabIndex = 10;
            this.exit.Text = "X";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(24, 191);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Employee Management";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(86, 225);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "System";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(358, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(80, 80);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(262, 259);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 14);
            this.label7.TabIndex = 14;
            this.label7.Text = "Confirm Password:";
            // 
            // register_Cfmpassword
            // 
            this.register_Cfmpassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.register_Cfmpassword.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_Cfmpassword.Location = new System.Drawing.Point(283, 279);
            this.register_Cfmpassword.Multiline = true;
            this.register_Cfmpassword.Name = "register_Cfmpassword";
            this.register_Cfmpassword.PasswordChar = '*';
            this.register_Cfmpassword.Size = new System.Drawing.Size(250, 25);
            this.register_Cfmpassword.TabIndex = 18;
            // 
            // register_showCfmPassword
            // 
            this.register_showCfmPassword.AutoSize = true;
            this.register_showCfmPassword.Location = new System.Drawing.Point(432, 307);
            this.register_showCfmPassword.Name = "register_showCfmPassword";
            this.register_showCfmPassword.Size = new System.Drawing.Size(102, 17);
            this.register_showCfmPassword.TabIndex = 16;
            this.register_showCfmPassword.Text = "Show Password";
            this.register_showCfmPassword.UseVisualStyleBackColor = true;
            this.register_showCfmPassword.CheckedChanged += new System.EventHandler(this.register_showCfmPassword_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(41, 310);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(174, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Did you complete the registration ?";
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(541, 380);
            this.Controls.Add(this.register_showCfmPassword);
            this.Controls.Add(this.register_Cfmpassword);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.register_signupbutton);
            this.Controls.Add(this.register_showPassword);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.register_password);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.register_username);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button register_loginButton;
        private System.Windows.Forms.Button register_signupbutton;
        private System.Windows.Forms.CheckBox register_showPassword;
        private System.Windows.Forms.TextBox register_password;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox register_username;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox register_Cfmpassword;
        private System.Windows.Forms.CheckBox register_showCfmPassword;
        private System.Windows.Forms.Label label8;
    }
}