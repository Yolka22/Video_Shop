namespace Video_Shop
{
    partial class User_Shop
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.корзинаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отсортироватьПоЦенеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отДешёвыхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отДорогихToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отсортироватьПоРейтингуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Все Фильмы";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 66);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(229, 340);
            this.listBox1.TabIndex = 1;
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.корзинаToolStripMenuItem,
            this.отсортироватьПоЦенеToolStripMenuItem,
            this.отсортироватьПоРейтингуToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(614, 28);
            this.menuStrip2.TabIndex = 3;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // корзинаToolStripMenuItem
            // 
            this.корзинаToolStripMenuItem.Name = "корзинаToolStripMenuItem";
            this.корзинаToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.корзинаToolStripMenuItem.Text = "Корзина";
            this.корзинаToolStripMenuItem.Click += new System.EventHandler(this.корзинаToolStripMenuItem_Click);
            // 
            // отсортироватьПоЦенеToolStripMenuItem
            // 
            this.отсортироватьПоЦенеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.отДешёвыхToolStripMenuItem,
            this.отДорогихToolStripMenuItem});
            this.отсортироватьПоЦенеToolStripMenuItem.Name = "отсортироватьПоЦенеToolStripMenuItem";
            this.отсортироватьПоЦенеToolStripMenuItem.Size = new System.Drawing.Size(188, 24);
            this.отсортироватьПоЦенеToolStripMenuItem.Text = "Отсортировать по цене";
            // 
            // отДешёвыхToolStripMenuItem
            // 
            this.отДешёвыхToolStripMenuItem.Name = "отДешёвыхToolStripMenuItem";
            this.отДешёвыхToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.отДешёвыхToolStripMenuItem.Text = "От дешёвых";
            this.отДешёвыхToolStripMenuItem.Click += new System.EventHandler(this.отДешёвыхToolStripMenuItem_Click);
            // 
            // отДорогихToolStripMenuItem
            // 
            this.отДорогихToolStripMenuItem.Name = "отДорогихToolStripMenuItem";
            this.отДорогихToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.отДорогихToolStripMenuItem.Text = "От дорогих";
            this.отДорогихToolStripMenuItem.Click += new System.EventHandler(this.отДорогихToolStripMenuItem_Click);
            // 
            // отсортироватьПоРейтингуToolStripMenuItem
            // 
            this.отсортироватьПоРейтингуToolStripMenuItem.Name = "отсортироватьПоРейтингуToolStripMenuItem";
            this.отсортироватьПоРейтингуToolStripMenuItem.Size = new System.Drawing.Size(217, 24);
            this.отсортироватьПоРейтингуToolStripMenuItem.Text = "Отсортировать по рейтингу";
            this.отсортироватьПоРейтингуToolStripMenuItem.Click += new System.EventHandler(this.отсортироватьПоРейтингуToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 412);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(229, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "В корзину";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // User_Shop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip2);
            this.Name = "User_Shop";
            this.Text = "User_Shop";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem корзинаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отсортироватьПоЦенеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отДешёвыхToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отДорогихToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отсортироватьПоРейтингуToolStripMenuItem;
        private System.Windows.Forms.Button button1;
    }
}