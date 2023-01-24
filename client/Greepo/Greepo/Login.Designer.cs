namespace Greepo
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.inptEmail = new System.Windows.Forms.TextBox();
            this.inptPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.linkToSignup = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(360, 135);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(127, 42);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Log In\r\n";
            this.lblTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(241, 190);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(48, 20);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "Email";
            this.lblEmail.Click += new System.EventHandler(this.lblEmail_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(241, 250);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(109, 20);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Palavra-passe";
            // 
            // inptEmail
            // 
            this.inptEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inptEmail.Location = new System.Drawing.Point(245, 212);
            this.inptEmail.Margin = new System.Windows.Forms.Padding(2);
            this.inptEmail.MaxLength = 150;
            this.inptEmail.Name = "inptEmail";
            this.inptEmail.Size = new System.Drawing.Size(311, 20);
            this.inptEmail.TabIndex = 3;
            this.inptEmail.TextChanged += new System.EventHandler(this.inptEmail_TextChanged);
            // 
            // inptPassword
            // 
            this.inptPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inptPassword.Location = new System.Drawing.Point(245, 272);
            this.inptPassword.Margin = new System.Windows.Forms.Padding(2);
            this.inptPassword.MaxLength = 150;
            this.inptPassword.Name = "inptPassword";
            this.inptPassword.PasswordChar = '●';
            this.inptPassword.Size = new System.Drawing.Size(311, 20);
            this.inptPassword.TabIndex = 4;
            this.inptPassword.TextChanged += new System.EventHandler(this.inptPassword_TextChanged);
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogin.AutoSize = true;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Location = new System.Drawing.Point(418, 365);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Padding = new System.Windows.Forms.Padding(4);
            this.btnLogin.Size = new System.Drawing.Size(141, 31);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnReset
            // 
            this.btnReset.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReset.AutoSize = true;
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.Location = new System.Drawing.Point(245, 365);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Padding = new System.Windows.Forms.Padding(4);
            this.btnReset.Size = new System.Drawing.Size(143, 31);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Limpar";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // linkToSignup
            // 
            this.linkToSignup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.linkToSignup.AutoSize = true;
            this.linkToSignup.Location = new System.Drawing.Point(363, 319);
            this.linkToSignup.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkToSignup.Name = "linkToSignup";
            this.linkToSignup.Size = new System.Drawing.Size(83, 13);
            this.linkToSignup.TabIndex = 7;
            this.linkToSignup.TabStop = true;
            this.linkToSignup.Text = "Não tem conta?";
            this.linkToSignup.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkToSignup_LinkClicked);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.linkToSignup);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.inptPassword);
            this.Controls.Add(this.inptEmail);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblTitle);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Page";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox inptEmail;
        private System.Windows.Forms.TextBox inptPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.LinkLabel linkToSignup;
    }
}