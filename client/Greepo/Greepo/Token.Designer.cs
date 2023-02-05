namespace Greepo
{
    partial class Token
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnSendToken = new System.Windows.Forms.Button();
            this.inptToken = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(282, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Recebeu um token no seu email!";
            // 
            // btnSendToken
            // 
            this.btnSendToken.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSendToken.AutoSize = true;
            this.btnSendToken.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSendToken.Location = new System.Drawing.Point(316, 318);
            this.btnSendToken.Margin = new System.Windows.Forms.Padding(2);
            this.btnSendToken.Name = "btnSendToken";
            this.btnSendToken.Padding = new System.Windows.Forms.Padding(4);
            this.btnSendToken.Size = new System.Drawing.Size(141, 31);
            this.btnSendToken.TabIndex = 10;
            this.btnSendToken.Text = "Submeter";
            this.btnSendToken.UseVisualStyleBackColor = true;
            this.btnSendToken.Click += new System.EventHandler(this.btnSendToken_Click);
            // 
            // inptToken
            // 
            this.inptToken.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inptToken.HideSelection = false;
            this.inptToken.Location = new System.Drawing.Point(285, 279);
            this.inptToken.Margin = new System.Windows.Forms.Padding(2);
            this.inptToken.MaxLength = 150;
            this.inptToken.Name = "inptToken";
            this.inptToken.Size = new System.Drawing.Size(221, 20);
            this.inptToken.TabIndex = 9;
            this.inptToken.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(288, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 37);
            this.label1.TabIndex = 8;
            this.label1.Text = "Insira o token";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(47, 36);
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "<";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Token
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSendToken);
            this.Controls.Add(this.inptToken);
            this.Controls.Add(this.label1);
            this.Name = "Token";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Token";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSendToken;
        private System.Windows.Forms.TextBox inptToken;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
    }
}