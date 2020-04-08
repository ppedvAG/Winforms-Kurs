namespace Modul05_DataGridView
{
    partial class Form1
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
            this.beispieleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.einfachesGridToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainContent = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.beispieleToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(979, 40);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // beispieleToolStripMenuItem
            // 
            this.beispieleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.einfachesGridToolStripMenuItem});
            this.beispieleToolStripMenuItem.Name = "beispieleToolStripMenuItem";
            this.beispieleToolStripMenuItem.Size = new System.Drawing.Size(130, 36);
            this.beispieleToolStripMenuItem.Text = "Beispiele";
            // 
            // einfachesGridToolStripMenuItem
            // 
            this.einfachesGridToolStripMenuItem.Name = "einfachesGridToolStripMenuItem";
            this.einfachesGridToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.einfachesGridToolStripMenuItem.Text = "Einfaches Grid";
            this.einfachesGridToolStripMenuItem.Click += new System.EventHandler(this.einfachesGridToolStripMenuItem_Click);
            // 
            // mainContent
            // 
            this.mainContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainContent.Location = new System.Drawing.Point(0, 40);
            this.mainContent.Name = "mainContent";
            this.mainContent.Size = new System.Drawing.Size(979, 591);
            this.mainContent.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 631);
            this.Controls.Add(this.mainContent);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Beispielanwendung DataGridView";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem beispieleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem einfachesGridToolStripMenuItem;
        private System.Windows.Forms.Panel mainContent;
    }
}

