using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Video_Shop
{
    public partial class Admin_Login : Form
    {
        Admin admin = new Admin();

        public bool Admin_Check(string login, string password)
        {

            if (admin.Login == login && admin.Password == password)
            {
                return true;
            }
            return false;
        }

        public Admin_Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Admin_Check(textBox1.Text,textBox2.Text)==true)
            {
                this.Hide();
                Admin_Shop admin_Shop = new Admin_Shop();
                admin_Shop.Show();
            }
        }
    }
}
