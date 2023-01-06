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
            this.linkToLogin = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // btnReset
            // 
            this.btnReset.AutoSize = true;
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.Location = new System.Drawing.Point(393, 293);
            this.btnReset.Name = "btnReset";
            this.btnReset.Padding = new System.Windows.Forms.Padding(5);
            this.btnReset.Size = new System.Drawing.Size(93, 36);
            this.btnReset.TabIndex = 14;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSignUp
            // 
            this.btnSignUp.AutoSize = true;
            this.btnSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignUp.Location = new System.Drawing.Point(518, 293);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Padding = new System.Windows.Forms.Padding(5);
            this.btnSignUp.Size = new System.Drawing.Size(89, 36);
            this.btnSignUp.TabIndex = 13;
            this.btnSignUp.Text = "Sign Up";
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // inptPassword
            // 
            this.inptPassword.Location = new System.Drawing.Point(393, 154);
            this.inptPassword.MaxLength = 150;
            this.inptPassword.Name = "inptPassword";
            this.inptPassword.PasswordChar = '●';
            this.inptPassword.Size = new System.Drawing.Size(214, 22);
            this.inptPassword.TabIndex = 12;
            this.inptPassword.TextChanged += new System.EventHandler(this.inptPassword_TextChanged);
            // 
            // inptEmail
            // 
            this.inptEmail.Location = new System.Drawing.Point(54, 222);
            this.inptEmail.MaxLength = 150;
            this.inptEmail.Name = "inptEmail";
            this.inptEmail.Size = new System.Drawing.Size(214, 22);
            this.inptEmail.TabIndex = 11;
            this.inptEmail.TextChanged += new System.EventHandler(this.inptEmail_TextChanged);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(388, 126);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(98, 25);
            this.lblPassword.TabIndex = 10;
            this.lblPassword.Text = "Password";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(49, 194);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(60, 25);
            this.lblEmail.TabIndex = 9;
            this.lblEmail.Text = "Email";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(247, 43);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(171, 29);
            this.lblTitle.TabIndex = 8;
            this.lblTitle.Text = "Sign Up Now";
            // 
            // inptName
            // 
            this.inptName.Location = new System.Drawing.Point(54, 153);
            this.inptName.MaxLength = 150;
            this.inptName.Name = "inptName";
            this.inptName.Size = new System.Drawing.Size(214, 22);
            this.inptName.TabIndex = 17;
            this.inptName.TextChanged += new System.EventHandler(this.inptName_TextChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(49, 126);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(64, 25);
            this.lblName.TabIndex = 16;
            this.lblName.Text = "Name";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(49, 265);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(77, 25);
            this.lblGender.TabIndex = 18;
            this.lblGender.Text = "Gender";
            // 
            // ddGender
            // 
            this.ddGender.FormattingEnabled = true;
            this.ddGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Non-Binary",
            "Other"});
            this.ddGender.Location = new System.Drawing.Point(54, 293);
            this.ddGender.Name = "ddGender";
            this.ddGender.Size = new System.Drawing.Size(214, 24);
            this.ddGender.TabIndex = 19;
            this.ddGender.SelectedIndexChanged += new System.EventHandler(this.ddGender_SelectedIndexChanged);
            // 
            // inptConfirmPassword
            // 
            this.inptConfirmPassword.Location = new System.Drawing.Point(393, 222);
            this.inptConfirmPassword.MaxLength = 150;
            this.inptConfirmPassword.Name = "inptConfirmPassword";
            this.inptConfirmPassword.PasswordChar = '●';
            this.inptConfirmPassword.Size = new System.Drawing.Size(214, 22);
            this.inptConfirmPassword.TabIndex = 21;
            this.inptConfirmPassword.TextChanged += new System.EventHandler(this.inptConfirmPassword_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(388, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "Confirm Password";
            // 
            // linkToLogin
            // 
            this.linkToLogin.AutoSize = true;
            this.linkToLogin.Location = new System.Drawing.Point(418, 265);
            this.linkToLogin.Name = "linkToLogin";
            this.linkToLogin.Size = new System.Drawing.Size(166, 16);
            this.linkToLogin.TabIndex = 22;
            this.linkToLogin.TabStop = true;
            this.linkToLogin.Text = "Already Have an Account?";
            this.linkToLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkToLogin_LinkClicked);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.linkToLogin);
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
            this.Name = "SignUp";
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
        private System.Windows.Forms.LinkLabel linkToLogin;
    }
}