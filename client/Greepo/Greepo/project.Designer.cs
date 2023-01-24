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
            // project
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.lblProjectTitle);
            this.Name = "project";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Project";
            this.Load += new System.EventHandler(this.project_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.LinkLabel lblProjectTitle;
    }
}