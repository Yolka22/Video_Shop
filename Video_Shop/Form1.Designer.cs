namespace Video_Shop
{
    partial class Choose_Form
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.User_Butto = new System.Windows.Forms.Button();
            this.Admin_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // User_Butto
            // 
            this.User_Butto.Location = new System.Drawing.Point(12, 45);
            this.User_Butto.Name = "User_Butto";
            this.User_Butto.Size = new System.Drawing.Size(329, 64);
            this.User_Butto.TabIndex = 0;
            this.User_Butto.Text = "User";
            this.User_Butto.UseVisualStyleBackColor = true;
            this.User_Butto.Click += new System.EventHandler(this.User_Butto_Click);
            // 
            // Admin_button
            // 
            this.Admin_button.Location = new System.Drawing.Point(12, 115);
            this.Admin_button.Name = "Admin_button";
            this.Admin_button.Size = new System.Drawing.Size(329, 63);
            this.Admin_button.TabIndex = 1;
            this.Admin_button.Text = "Admin";
            this.Admin_button.UseVisualStyleBackColor = true;
            this.Admin_button.Click += new System.EventHandler(this.Admin_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Выберете под кем зайти";
            // 
            // Choose_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 190);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Admin_button);
            this.Controls.Add(this.User_Butto);
            this.Name = "Choose_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Choose";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button User_Butto;
        private System.Windows.Forms.Button Admin_button;
        private System.Windows.Forms.Label label1;
    }
}

