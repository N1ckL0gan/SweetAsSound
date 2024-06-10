namespace SweetAsSound
{
    partial class Registration
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
            firstname_lbl = new Label();
            lastname_lbl = new Label();
            email_lbl = new Label();
            password_lbl = new Label();
            label7 = new Label();
            captcha_lbl = new Label();
            privacy_lbl = new Label();
            firstname_txt = new TextBox();
            lastname_txt = new TextBox();
            email_txt = new TextBox();
            password_txt = new TextBox();
            Captcha_txt = new TextBox();
            Privacy_txt = new TextBox();
            privacy_checkbox = new CheckBox();
            Signin_btn = new Button();
            login_link = new LinkLabel();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(324, 51);
            label1.Name = "label1";
            label1.Size = new Size(197, 27);
            label1.TabIndex = 1;
            label1.Text = "Sweet As Sound";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(240, 132);
            label2.Name = "label2";
            label2.Size = new Size(307, 38);
            label2.TabIndex = 2;
            label2.Text = "Create a New Account";
            // 
            // firstname_lbl
            // 
            firstname_lbl.AutoSize = true;
            firstname_lbl.Location = new Point(12, 202);
            firstname_lbl.Name = "firstname_lbl";
            firstname_lbl.Size = new Size(80, 20);
            firstname_lbl.TabIndex = 3;
            firstname_lbl.Text = "First Name";
            // 
            // lastname_lbl
            // 
            lastname_lbl.AutoSize = true;
            lastname_lbl.Location = new Point(400, 202);
            lastname_lbl.Name = "lastname_lbl";
            lastname_lbl.Size = new Size(79, 20);
            lastname_lbl.TabIndex = 4;
            lastname_lbl.Text = "Last Name";
            // 
            // email_lbl
            // 
            email_lbl.AutoSize = true;
            email_lbl.Location = new Point(42, 249);
            email_lbl.Name = "email_lbl";
            email_lbl.Size = new Size(46, 20);
            email_lbl.TabIndex = 5;
            email_lbl.Text = "Email";
            // 
            // password_lbl
            // 
            password_lbl.AutoSize = true;
            password_lbl.Location = new Point(22, 304);
            password_lbl.Name = "password_lbl";
            password_lbl.Size = new Size(70, 20);
            password_lbl.TabIndex = 6;
            password_lbl.Text = "Password";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Viner Hand ITC", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.Location = new Point(127, 346);
            label7.Name = "label7";
            label7.Size = new Size(127, 32);
            label7.TabIndex = 7;
            label7.Text = "CLICK ME";
            label7.Click += label7_Click;
            // 
            // captcha_lbl
            // 
            captcha_lbl.AutoSize = true;
            captcha_lbl.Location = new Point(25, 353);
            captcha_lbl.Name = "captcha_lbl";
            captcha_lbl.Size = new Size(63, 20);
            captcha_lbl.TabIndex = 8;
            captcha_lbl.Text = "Captcha";
            // 
            // privacy_lbl
            // 
            privacy_lbl.AutoSize = true;
            privacy_lbl.Location = new Point(5, 406);
            privacy_lbl.Name = "privacy_lbl";
            privacy_lbl.Size = new Size(97, 20);
            privacy_lbl.TabIndex = 9;
            privacy_lbl.Text = "Privacy Policy";
            privacy_lbl.Click += label9_Click;
            // 
            // firstname_txt
            // 
            firstname_txt.Location = new Point(108, 199);
            firstname_txt.Name = "firstname_txt";
            firstname_txt.Size = new Size(286, 27);
            firstname_txt.TabIndex = 11;
            // 
            // lastname_txt
            // 
            lastname_txt.Location = new Point(477, 199);
            lastname_txt.Name = "lastname_txt";
            lastname_txt.Size = new Size(286, 27);
            lastname_txt.TabIndex = 12;
            // 
            // email_txt
            // 
            email_txt.Location = new Point(108, 249);
            email_txt.Name = "email_txt";
            email_txt.Size = new Size(655, 27);
            email_txt.TabIndex = 13;
            // 
            // password_txt
            // 
            password_txt.Location = new Point(108, 301);
            password_txt.Name = "password_txt";
            password_txt.Size = new Size(655, 27);
            password_txt.TabIndex = 14;
            password_txt.UseSystemPasswordChar = true;
            // 
            // Captcha_txt
            // 
            Captcha_txt.Location = new Point(283, 346);
            Captcha_txt.Name = "Captcha_txt";
            Captcha_txt.Size = new Size(480, 27);
            Captcha_txt.TabIndex = 15;
            // 
            // Privacy_txt
            // 
            Privacy_txt.Location = new Point(108, 406);
            Privacy_txt.Multiline = true;
            Privacy_txt.Name = "Privacy_txt";
            Privacy_txt.Size = new Size(655, 101);
            Privacy_txt.TabIndex = 16;
            // 
            // privacy_checkbox
            // 
            privacy_checkbox.AutoSize = true;
            privacy_checkbox.Location = new Point(116, 525);
            privacy_checkbox.Name = "privacy_checkbox";
            privacy_checkbox.Size = new Size(212, 24);
            privacy_checkbox.TabIndex = 17;
            privacy_checkbox.Text = "I agree to the Privacy Policy";
            privacy_checkbox.UseVisualStyleBackColor = true;
            // 
            // Signin_btn
            // 
            Signin_btn.Location = new Point(258, 603);
            Signin_btn.Name = "Signin_btn";
            Signin_btn.Size = new Size(263, 80);
            Signin_btn.TabIndex = 18;
            Signin_btn.Text = "Sign In";
            Signin_btn.TextImageRelation = TextImageRelation.TextAboveImage;
            Signin_btn.UseVisualStyleBackColor = true;
            Signin_btn.Click += Signin_btn_Click;
            // 
            // login_link
            // 
            login_link.AutoSize = true;
            login_link.Location = new Point(283, 708);
            login_link.Name = "login_link";
            login_link.Size = new Size(216, 20);
            login_link.TabIndex = 19;
            login_link.TabStop = true;
            login_link.Text = "Already a Member? Login Here";
            login_link.LinkClicked += login_link_LinkClicked;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.OIP__3_;
            pictureBox1.Location = new Point(240, 19);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(78, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // Registration
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 758);
            Controls.Add(pictureBox1);
            Controls.Add(login_link);
            Controls.Add(Signin_btn);
            Controls.Add(privacy_checkbox);
            Controls.Add(Privacy_txt);
            Controls.Add(Captcha_txt);
            Controls.Add(password_txt);
            Controls.Add(email_txt);
            Controls.Add(lastname_txt);
            Controls.Add(firstname_txt);
            Controls.Add(privacy_lbl);
            Controls.Add(captcha_lbl);
            Controls.Add(label7);
            Controls.Add(password_lbl);
            Controls.Add(email_lbl);
            Controls.Add(lastname_lbl);
            Controls.Add(firstname_lbl);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Registration";
            Text = "Registration";
            Load += Registration_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label firstname_lbl;
        private Label lastname_lbl;
        private Label email_lbl;
        private Label password_lbl;
        private Label label7;
        private Label captcha_lbl;
        private Label privacy_lbl;
        private TextBox firstname_txt;
        private TextBox lastname_txt;
        private TextBox email_txt;
        private TextBox password_txt;
        private TextBox Captcha_txt;
        private TextBox Privacy_txt;
        private CheckBox privacy_checkbox;
        private Button Signin_btn;
        private LinkLabel login_link;
        private PictureBox pictureBox1;
    }
}