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
    public partial class Choose_Form : Form
    {
        public Choose_Form()
        {
            InitializeComponent();

        }

        private void User_Butto_Click(object sender, EventArgs e)
        {
            User_Login user_login = new User_Login();
            
            user_login.Show();
            
            this.Hide();
        }

        private void Admin_button_Click(object sender, EventArgs e)
        {
            
            Admin_Login admin_Login = new Admin_Login();

            admin_Login.Show(); 

            this.Hide();

        }
    }
}
