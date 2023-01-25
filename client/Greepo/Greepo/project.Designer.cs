namespace Greepo
{
    partial class project
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
            this.lblProjectTitle = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMuni = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblProjectTitle
            // 
            this.lblProjectTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjectTitle.LinkColor = System.Drawing.Color.Black;
            this.lblProjectTitle.Location = new System.Drawing.Point(4, 9);
            this.lblProjectTitle.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lblProjectTitle.Name = "lblProjectTitle";
            this.lblProjectTitle.Size = new System.Drawing.Size(779, 107);
            this.lblProjectTitle.TabIndex = 0;
            this.lblProjectTitle.TabStop = true;
            this.lblProjectTitle.Text = "Project Title";
            this.lblProjectTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblProjectTitle.VisitedLinkColor = System.Drawing.Color.Black;
            this.lblProjectTitle.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblProjectTitle_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Descrição";
            // 
            // lblDesc
            // 
            this.lblDesc.Location = new System.Drawing.Point(58, 188);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(315, 323);
            this.lblDesc.TabIndex = 2;
            this.lblDesc.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(452, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 37);
            this.label3.TabIndex = 3;
            this.label3.Text = "Município";
            // 
            // lblMuni
            // 
            this.lblMuni.Location = new System.Drawing.Point(456, 188);
            this.lblMuni.Name = "lblMuni";
            this.lblMuni.Size = new System.Drawing.Size(248, 41);
            this.lblMuni.TabIndex = 4;
            this.lblMuni.Text = "label4";
            // 
            // project
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.lblMuni);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblProjectTitle);
            this.Name = "project";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Project";
            this.Load += new System.EventHandler(this.project_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lblProjectTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblMuni;
    }
}