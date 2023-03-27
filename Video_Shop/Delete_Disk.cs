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
    public partial class Delete_Disk : Form
    {

        List<Disk> disks = new List<Disk>();

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


                    disks.Add(disk);

                } while (line != null);


                for (int i = 0; i < disks.Count; i++)
                {

                    listBox1.Items.Add(disks[i].Name);

                }

                //close the file
                sr.Close();
                Console.ReadLine();

            }
            catch (Exception e)
            {

            }
        }

        public void Save()
        {

            try
            {
                //Pass the filepath and filename to the StreamWriter Constructor
                StreamWriter sw = new StreamWriter("Disks.txt");

                for (int i = 0; i < disks.Count; i++)
                {
                    sw.WriteLine(disks[i].Name);
                    sw.WriteLine(disks[i].Regicer);
                    sw.WriteLine(disks[i].Ganre);
                    sw.WriteLine(disks[i].Rating);
                    sw.WriteLine(disks[i].Cost);
                }
                sw.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }

        }

        public Delete_Disk()
        {
            InitializeComponent();
            Read();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            disks.RemoveAt(listBox1.SelectedIndex);
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            Save();
        }
    }
}
