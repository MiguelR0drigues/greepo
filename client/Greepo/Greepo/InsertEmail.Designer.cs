namespace Greepo
{
    partial class Recuperar
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
            this.label1 = new System.Windows.Forms.Label();
            this.inptEmail = new System.Windows.Forms.TextBox();
            this.btnSendToken = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(262, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Insira o seu email";
            // 
            // inptEmail
            // 
            this.inptEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inptEmail.HideSelection = false;
            this.inptEmail.Location = new System.Drawing.Point(239, 244);
            this.inptEmail.Margin = new System.Windows.Forms.Padding(2);
            this.inptEmail.MaxLength = 150;
            this.inptEmail.Name = "inptEmail";
            this.inptEmail.Size = new System.Drawing.Size(311, 20);
            this.inptEmail.TabIndex = 5;
            this.inptEmail.TextChanged += new System.EventHandler(this.inptEmail_TextChanged);
            // 
            // btnSendToken
            // 
            this.btnSendToken.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSendToken.AutoSize = true;
            this.btnSendToken.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSendToken.Location = new System.Drawing.Point(319, 287);
            this.btnSendToken.Margin = new System.Windows.Forms.Padding(2);
            this.btnSendToken.Name = "btnSendToken";
            this.btnSendToken.Padding = new System.Windows.Forms.Padding(4);
            this.btnSendToken.Size = new System.Drawing.Size(141, 31);
            this.btnSendToken.TabIndex = 6;
            this.btnSendToken.Text = "Enviar token";
            this.btnSendToken.UseVisualStyleBackColor = true;
            this.btnSendToken.Click += new System.EventHandler(this.btnSendToken_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(213, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(366, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Vamos enviar um token de validação para o seu email!";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(47, 36);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "<";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Recuperar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSendToken);
            this.Controls.Add(this.inptEmail);
            this.Controls.Add(this.label1);
            this.Name = "Recuperar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recuperar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inptEmail;
        private System.Windows.Forms.Button btnSendToken;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBack;
    }
}