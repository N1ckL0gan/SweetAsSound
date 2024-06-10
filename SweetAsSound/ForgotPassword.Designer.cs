namespace SweetAsSound
{
    partial class ForgotPassword
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
            forgotpassword_txt = new TextBox();
            resetlink_btn = new Button();
            BacktoLogin_link = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(134, 53);
            label1.Name = "label1";
            label1.Size = new Size(221, 35);
            label1.TabIndex = 0;
            label1.Text = "Forgot Password?";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(88, 148);
            label2.Name = "label2";
            label2.Size = new Size(317, 20);
            label2.TabIndex = 1;
            label2.Text = "Please enter your Email to reset your password";
            // 
            // forgotpassword_txt
            // 
            forgotpassword_txt.Location = new Point(32, 183);
            forgotpassword_txt.Name = "forgotpassword_txt";
            forgotpassword_txt.Size = new Size(430, 27);
            forgotpassword_txt.TabIndex = 2;
            // 
            // resetlink_btn
            // 
            resetlink_btn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            resetlink_btn.Location = new Point(145, 250);
            resetlink_btn.Name = "resetlink_btn";
            resetlink_btn.Size = new Size(197, 56);
            resetlink_btn.TabIndex = 3;
            resetlink_btn.Text = "Send Reset Link";
            resetlink_btn.UseVisualStyleBackColor = true;
            // 
            // BacktoLogin_link
            // 
            BacktoLogin_link.AutoSize = true;
            BacktoLogin_link.Location = new Point(197, 477);
            BacktoLogin_link.Name = "BacktoLogin_link";
            BacktoLogin_link.Size = new Size(99, 20);
            BacktoLogin_link.TabIndex = 4;
            BacktoLogin_link.TabStop = true;
            BacktoLogin_link.Text = "Back to Login";
            // 
            // ForgotPassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(488, 519);
            Controls.Add(BacktoLogin_link);
            Controls.Add(resetlink_btn);
            Controls.Add(forgotpassword_txt);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ForgotPassword";
            Text = "ForgotPassword";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox forgotpassword_txt;
        private Button resetlink_btn;
        private LinkLabel BacktoLogin_link;
    }
}