namespace Greepo
{
    partial class Options
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.regioesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.municipiosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.distritosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.regioesToolStripMenuItem,
            this.municipiosToolStripMenuItem,
            this.distritosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1045, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // regioesToolStripMenuItem
            // 
            this.regioesToolStripMenuItem.Name = "regioesToolStripMenuItem";
            this.regioesToolStripMenuItem.Size = new System.Drawing.Size(76, 26);
            this.regioesToolStripMenuItem.Text = "Regioes";
            this.regioesToolStripMenuItem.Click += new System.EventHandler(this.regioesToolStripMenuItem_Click);
            // 
            // municipiosToolStripMenuItem
            // 
            this.municipiosToolStripMenuItem.Name = "municipiosToolStripMenuItem";
            this.municipiosToolStripMenuItem.Size = new System.Drawing.Size(95, 26);
            this.municipiosToolStripMenuItem.Text = "Municipios";
            this.municipiosToolStripMenuItem.Click += new System.EventHandler(this.municipiosToolStripMenuItem_Click);
            // 
            // distritosToolStripMenuItem
            // 
            this.distritosToolStripMenuItem.Name = "distritosToolStripMenuItem";
            this.distritosToolStripMenuItem.Size = new System.Drawing.Size(78, 26);
            this.distritosToolStripMenuItem.Text = "Distritos";
            this.distritosToolStripMenuItem.Click += new System.EventHandler(this.distritosToolStripMenuItem_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(27, 151);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(985, 500);
            this.listBox1.TabIndex = 2;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(326, 77);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(387, 54);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Lista de Projetos";
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 690);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Options";
            this.Text = "Options";
            this.Load += new System.EventHandler(this.Projects_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem regioesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem municipiosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem distritosToolStripMenuItem;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lblTitle;
    }
}