using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Video_Shop
{
    public partial class User_Login : Form
    {

        List<User> Users = new List<User>();


        public bool Check_User(string username,string password)
        {

            for (int i = 0; i < Users.Count; i++)
            {
                if (Users[i].Login == username && Users[i].Password == password)
                {
                    return true;
                }
            }

            return false;
        }

        public bool Check_Login(string username)
        {

            for (int i = 0; i < Users.Count; i++)
            {
                if (Users[i].Login==username)
                {
                    return true;
                }
            }

            return false;
        }

        public void Add_User()
        {
            User user = new User();
            user.Login = textBox1.Text;
            user.Password = textBox2.Text;


            if (Check_Login(user.Login) ==false)
            {
                Users.Add(user);
            }
            else
            {
                MessageBox.Show("Этот логин уже занят");
               
            }
            
        }

        public void Read()
        {

            String line;
            try
            {
                StreamReader sr = new StreamReader("Users.txt");
                //Read the first line of text
                line = sr.ReadLine();
                //Continue to read until you reach end of file
                do
                {
                    User user = new User();
                    user.Login = line;

                    line = sr.ReadLine();

                    user.Password = line;

                    line = sr.ReadLine();

                    Users.Add(user);

                } while (line != null);

                //close the file
                sr.Close();
                Console.ReadLine();

            }
            catch (Exception e)
            {

            }
            finally
            {

            }


        }


        public User_Login()
        {
            InitializeComponent();
            Read();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Add_User();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            if(Check_User(textBox1.Text,textBox2.Text)== true)
            {
                User_Shop user_Shop = new User_Shop();
                user_Shop.Show();
                this.Hide();
            }

            
        }
    }
}
