namespace Greepo
{
    partial class SignUp
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
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.inptPassword = new System.Windows.Forms.TextBox();
            this.inptEmail = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.inptName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.ddGender = new System.Windows.Forms.ComboBox();
            this.inptConfirmPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLinkToLogin = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // btnReset
            // 
            this.btnReset.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReset.AutoSize = true;
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.Location = new System.Drawing.Point(227, 368);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Padding = new System.Windows.Forms.Padding(4);
            this.btnReset.Size = new System.Drawing.Size(155, 31);
            this.btnReset.TabIndex = 14;
            this.btnReset.Text = "Limpar";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSignUp
            // 
            this.btnSignUp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSignUp.AutoSize = true;
            this.btnSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignUp.Location = new System.Drawing.Point(410, 368);
            this.btnSignUp.Margin = new System.Windows.Forms.Padding(2);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Padding = new System.Windows.Forms.Padding(4);
            this.btnSignUp.Size = new System.Drawing.Size(155, 31);
            this.btnSignUp.TabIndex = 13;
            this.btnSignUp.Text = "Registo";
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // inptPassword
            // 
            this.inptPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inptPassword.Location = new System.Drawing.Point(432, 203);
            this.inptPassword.Margin = new System.Windows.Forms.Padding(2);
            this.inptPassword.MaxLength = 150;
            this.inptPassword.Name = "inptPassword";
            this.inptPassword.PasswordChar = '●';
            this.inptPassword.Size = new System.Drawing.Size(178, 20);
            this.inptPassword.TabIndex = 12;
            this.inptPassword.TextChanged += new System.EventHandler(this.inptPassword_TextChanged);
            // 
            // inptEmail
            // 
            this.inptEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inptEmail.Location = new System.Drawing.Point(188, 259);
            this.inptEmail.Margin = new System.Windows.Forms.Padding(2);
            this.inptEmail.MaxLength = 150;
            this.inptEmail.Name = "inptEmail";
            this.inptEmail.Size = new System.Drawing.Size(162, 20);
            this.inptEmail.TabIndex = 11;
            this.inptEmail.TextChanged += new System.EventHandler(this.inptEmail_TextChanged);
            // 
            // lblPassword
            // 
            this.lblPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(428, 180);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPassword.Size = new System.Drawing.Size(109, 20);
            this.lblPassword.TabIndex = 10;
            this.lblPassword.Text = "Palavra-passe";
            this.lblPassword.Click += new System.EventHandler(this.lblPassword_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(185, 237);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(48, 20);
            this.lblEmail.TabIndex = 9;
            this.lblEmail.Text = "Email";
            this.lblEmail.Click += new System.EventHandler(this.lblEmail_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(336, 124);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(152, 42);
            this.lblTitle.TabIndex = 8;
            this.lblTitle.Text = "Registo";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // inptName
            // 
            this.inptName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inptName.Location = new System.Drawing.Point(188, 203);
            this.inptName.Margin = new System.Windows.Forms.Padding(2);
            this.inptName.MaxLength = 150;
            this.inptName.Name = "inptName";
            this.inptName.Size = new System.Drawing.Size(162, 20);
            this.inptName.TabIndex = 17;
            this.inptName.TextChanged += new System.EventHandler(this.inptName_TextChanged);
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(185, 181);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(51, 20);
            this.lblName.TabIndex = 16;
            this.lblName.Text = "Nome";
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // lblGender
            // 
            this.lblGender.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(185, 294);
            this.lblGender.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(45, 20);
            this.lblGender.TabIndex = 18;
            this.lblGender.Text = "Sexo";
            this.lblGender.Click += new System.EventHandler(this.lblGender_Click);
            // 
            // ddGender
            // 
            this.ddGender.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ddGender.FormattingEnabled = true;
            this.ddGender.Items.AddRange(new object[] {
            "--select--",
            "Male",
            "Female",
            "Non-Binary",
            "Other"});
            this.ddGender.Location = new System.Drawing.Point(188, 317);
            this.ddGender.Margin = new System.Windows.Forms.Padding(2);
            this.ddGender.Name = "ddGender";
            this.ddGender.Size = new System.Drawing.Size(162, 21);
            this.ddGender.TabIndex = 19;
            this.ddGender.SelectedIndexChanged += new System.EventHandler(this.ddGender_SelectedIndexChanged);
            // 
            // inptConfirmPassword
            // 
            this.inptConfirmPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inptConfirmPassword.Location = new System.Drawing.Point(432, 258);
            this.inptConfirmPassword.Margin = new System.Windows.Forms.Padding(2);
            this.inptConfirmPassword.MaxLength = 150;
            this.inptConfirmPassword.Name = "inptConfirmPassword";
            this.inptConfirmPassword.PasswordChar = '●';
            this.inptConfirmPassword.Size = new System.Drawing.Size(178, 20);
            this.inptConfirmPassword.TabIndex = 21;
            this.inptConfirmPassword.TextChanged += new System.EventHandler(this.inptConfirmPassword_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(428, 236);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Confirmar Palavra-passe";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblLinkToLogin
            // 
            this.lblLinkToLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLinkToLogin.AutoSize = true;
            this.lblLinkToLogin.Location = new System.Drawing.Point(491, 320);
            this.lblLinkToLogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLinkToLogin.Name = "lblLinkToLogin";
            this.lblLinkToLogin.Size = new System.Drawing.Size(74, 13);
            this.lblLinkToLogin.TabIndex = 24;
            this.lblLinkToLogin.TabStop = true;
            this.lblLinkToLogin.Text = "Já tem conta?";
            this.lblLinkToLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblLinkToLogin_LinkClicked);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.lblLinkToLogin);
            this.Controls.Add(this.inptConfirmPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ddGender);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.inptName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.inptPassword);
            this.Controls.Add(this.inptEmail);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblTitle);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign Up";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.TextBox inptPassword;
        private System.Windows.Forms.TextBox inptEmail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox inptName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.ComboBox ddGender;
        private System.Windows.Forms.TextBox inptConfirmPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lblLinkToLogin;
    }
}