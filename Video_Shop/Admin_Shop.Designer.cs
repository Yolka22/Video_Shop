namespace Video_Shop
{
    partial class Admin_Shop
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
            this.добавитьФильмToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьФильмToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьФильмToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьФильмToolStripMenuItem,
            this.удалитьФильмToolStripMenuItem,
            this.редактироватьФильмToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(537, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // добавитьФильмToolStripMenuItem
            // 
            this.добавитьФильмToolStripMenuItem.Name = "добавитьФильмToolStripMenuItem";
            this.добавитьФильмToolStripMenuItem.Size = new System.Drawing.Size(141, 24);
            this.добавитьФильмToolStripMenuItem.Text = "Добавить Фильм";
            this.добавитьФильмToolStripMenuItem.Click += new System.EventHandler(this.добавитьФильмToolStripMenuItem_Click);
            // 
            // удалитьФильмToolStripMenuItem
            // 
            this.удалитьФильмToolStripMenuItem.Name = "удалитьФильмToolStripMenuItem";
            this.удалитьФильмToolStripMenuItem.Size = new System.Drawing.Size(130, 24);
            this.удалитьФильмToolStripMenuItem.Text = "Удалить Фильм";
            this.удалитьФильмToolStripMenuItem.Click += new System.EventHandler(this.удалитьФильмToolStripMenuItem_Click);
            // 
            // редактироватьФильмToolStripMenuItem
            // 
            this.редактироватьФильмToolStripMenuItem.Name = "редактироватьФильмToolStripMenuItem";
            this.редактироватьФильмToolStripMenuItem.Size = new System.Drawing.Size(176, 24);
            this.редактироватьФильмToolStripMenuItem.Text = "Редактировать Фильм";
            this.редактироватьФильмToolStripMenuItem.Click += new System.EventHandler(this.редактироватьФильмToolStripMenuItem_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(13, 32);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(443, 404);
            this.listBox1.TabIndex = 1;
            // 
            // Admin_Shop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Admin_Shop";
            this.Text = "Admin_Shop";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem добавитьФильмToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьФильмToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактироватьФильмToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ListBox listBox1;
    }
}