using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace Video_Shop
{


    public partial class User_Shop : Form
    {
        List<Disk> Disks = new List<Disk>();
        List<Disk> user_disks = new List<Disk>();
        Basket basket = new Basket();

        public void Send_Info(Basket basket)
        {

            basket.listBox1.Items.Add(listBox1.SelectedItem);
            user_disks.Add(Disks[listBox1.SelectedIndex]);

        }

        public void Read()
        {

            String line;
            try
            {
                StreamReader sr = new StreamReader("Disks.txt");
                //Read the first line of text
                line = sr.ReadLine();
                //Continue to read until you reach end of file
                do
                {
                    Disk disk = new Disk();

                    disk.Name = line;
                    line = sr.ReadLine();

                    disk.Regicer = line;
                    line = sr.ReadLine();

                    disk.Ganre = line;
                    line = sr.ReadLine();

                    disk.Rating = Convert.ToDouble(line);
                    line = sr.ReadLine();

                    disk.Cost = Convert.ToDouble(line);
                    line = sr.ReadLine();


                    Disks.Add(disk);

                } while (line != null);

                //close the file
                sr.Close();
                Console.ReadLine();


                for (int i = 0; i < Disks.Count; i++)
                {

                    listBox1.Items.Add(Disks[i].Name+" " + Disks[i].Cost+"$");

                }

            }
            catch (Exception e)
            {

            }
            finally
            {

            }


        }

        public User_Shop()
        {
            InitializeComponent();
            Read();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Send_Info(basket);
        }

        private void корзинаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            basket.ShowDialog();
        }

        private void отДешёвыхToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            var sorted = Disks.OrderBy(ob => ob.Cost).ToArray();

            for (int i = 0; i < sorted.Length; i++)
            {
                listBox1.Items.Add(sorted[i].Name + " " + sorted[i].Cost.ToString() +"$");
            }
   
        }

        private void отДорогихToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            var sorted = Disks.OrderBy(ob => ob.Cost).ToArray();

            Array.Reverse(sorted);

            for (int i = 0; i < sorted.Length; i++)
            {
                listBox1.Items.Add(sorted[i].Name + " " + sorted[i].Cost.ToString() + "$");
            }
        }

        private void отсортироватьПоРейтингуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            var sorted = Disks.OrderBy(ob => ob.Rating).ToArray();

            Array.Reverse(sorted);

            for (int i = 0; i < sorted.Length; i++)
            {
                listBox1.Items.Add(sorted[i].Name + " " + sorted[i].Cost.ToString() + "$");
            }
        }
    }
}
