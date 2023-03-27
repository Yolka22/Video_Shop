using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Video_Shop
{
    public partial class Basket : Form
    {



        List<Disk> Disks = new List<Disk>();


        public void SendConfirm()
        {


            string Body="";


            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                Body += listBox1.Items[i] + "\n";
            }

            Body += DateTime.Now;

            MessageBox.Show(Body);

        }


        public Basket()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            SendConfirm();
        }

    }
}
