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
            this.encerrarSessãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.regioesToolStripMenuItem,
            this.municipiosToolStripMenuItem,
            this.distritosToolStripMenuItem,
            this.encerrarSessãoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // regioesToolStripMenuItem
            // 
            this.regioesToolStripMenuItem.Name = "regioesToolStripMenuItem";
            this.regioesToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.regioesToolStripMenuItem.Text = "Regioes";
            this.regioesToolStripMenuItem.Click += new System.EventHandler(this.regioesToolStripMenuItem_Click);
            // 
            // municipiosToolStripMenuItem
            // 
            this.municipiosToolStripMenuItem.Name = "municipiosToolStripMenuItem";
            this.municipiosToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.municipiosToolStripMenuItem.Text = "Municipios";
            this.municipiosToolStripMenuItem.Click += new System.EventHandler(this.municipiosToolStripMenuItem_Click);
            // 
            // distritosToolStripMenuItem
            // 
            this.distritosToolStripMenuItem.Name = "distritosToolStripMenuItem";
            this.distritosToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.distritosToolStripMenuItem.Text = "Distritos";
            this.distritosToolStripMenuItem.Click += new System.EventHandler(this.distritosToolStripMenuItem_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(20, 123);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(740, 407);
            this.listBox1.TabIndex = 2;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(244, 63);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(313, 42);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Lista de Projetos";
            // 
            // encerrarSessãoToolStripMenuItem
            // 
            this.encerrarSessãoToolStripMenuItem.Name = "encerrarSessãoToolStripMenuItem";
            this.encerrarSessãoToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.encerrarSessãoToolStripMenuItem.Text = "Encerrar sessão";
            this.encerrarSessãoToolStripMenuItem.Click += new System.EventHandler(this.encerrarSessãoToolStripMenuItem_Click);
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Options";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.ToolStripMenuItem encerrarSessãoToolStripMenuItem;
    }
}