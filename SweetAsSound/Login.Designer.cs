namespace SweetAsSound
{
    partial class Login
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
            label1 = new Label();
            label2 = new Label();
            loginemail_lbl = new Label();
            loginpassword_lbl = new Label();
            LoginEmail = new TextBox();
            LoginPassword = new TextBox();
            ForgotPassword_link = new LinkLabel();
            Login_btn = new Button();
            register_link = new LinkLabel();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(273, 64);
            label1.Name = "label1";
            label1.Size = new Size(197, 27);
            label1.TabIndex = 1;
            label1.Text = "Sweet As Sound";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(259, 160);
            label2.Name = "label2";
            label2.Size = new Size(101, 35);
            label2.TabIndex = 2;
            label2.Text = "Log In";
            // 
            // loginemail_lbl
            // 
            loginemail_lbl.AutoSize = true;
            loginemail_lbl.Location = new Point(60, 214);
            loginemail_lbl.Name = "loginemail_lbl";
            loginemail_lbl.Size = new Size(46, 20);
            loginemail_lbl.TabIndex = 3;
            loginemail_lbl.Text = "Email";
            // 
            // loginpassword_lbl
            // 
            loginpassword_lbl.AutoSize = true;
            loginpassword_lbl.Location = new Point(60, 271);
            loginpassword_lbl.Name = "loginpassword_lbl";
            loginpassword_lbl.Size = new Size(70, 20);
            loginpassword_lbl.TabIndex = 4;
            loginpassword_lbl.Text = "Password";
            // 
            // LoginEmail
            // 
            LoginEmail.Location = new Point(145, 211);
            LoginEmail.Name = "LoginEmail";
            LoginEmail.Size = new Size(325, 27);
            LoginEmail.TabIndex = 5;
            // 
            // LoginPassword
            // 
            LoginPassword.Location = new Point(145, 268);
            LoginPassword.Name = "LoginPassword";
            LoginPassword.Size = new Size(325, 27);
            LoginPassword.TabIndex = 6;
            LoginPassword.UseSystemPasswordChar = true;
            // 
            // ForgotPassword_link
            // 
            ForgotPassword_link.AutoSize = true;
            ForgotPassword_link.Location = new Point(345, 298);
            ForgotPassword_link.Name = "ForgotPassword_link";
            ForgotPassword_link.Size = new Size(125, 20);
            ForgotPassword_link.TabIndex = 7;
            ForgotPassword_link.TabStop = true;
            ForgotPassword_link.Text = "Forgot Password?";
            ForgotPassword_link.LinkClicked += ForgotPassword_link_LinkClicked_1;
            // 
            // Login_btn
            // 
            Login_btn.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Login_btn.Location = new Point(213, 355);
            Login_btn.Name = "Login_btn";
            Login_btn.Size = new Size(173, 71);
            Login_btn.TabIndex = 8;
            Login_btn.Text = "Login";
            Login_btn.UseVisualStyleBackColor = true;
            Login_btn.Click += Login_btn_Click_1;
            // 
            // register_link
            // 
            register_link.AutoSize = true;
            register_link.Location = new Point(178, 439);
            register_link.Name = "register_link";
            register_link.Size = new Size(262, 20);
            register_link.TabIndex = 9;
            register_link.TabStop = true;
            register_link.Text = "Don't have an Account? Register Here.";
            register_link.LinkClicked += register_link_LinkClicked;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.OIP__3_;
            pictureBox2.Location = new Point(189, 31);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(78, 100);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 21;
            pictureBox2.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(613, 535);
            Controls.Add(pictureBox2);
            Controls.Add(register_link);
            Controls.Add(Login_btn);
            Controls.Add(ForgotPassword_link);
            Controls.Add(LoginPassword);
            Controls.Add(LoginEmail);
            Controls.Add(loginpassword_lbl);
            Controls.Add(loginemail_lbl);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Login";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label loginemail_lbl;
        private Label loginpassword_lbl;
        private TextBox LoginEmail;
        private TextBox LoginPassword;
        private LinkLabel ForgotPassword_link;
        private Button Login_btn;
        private LinkLabel register_link;
        private PictureBox pictureBox2;
    }
}