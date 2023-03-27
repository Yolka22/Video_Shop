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
    public partial class Add_Film : Form
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
            finally
            {
                
            }

        }

        public bool Name_Check(string name)
        {

            for (int i = 0; i < disks.Count; i++)
            {
                if (disks[i].Name == name)
                {
                    return true;
                }
            }
            return false;
        }

        public Add_Film()
        {
            InitializeComponent();
            Read();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (Name_Check(textBox1.Text) == false)
            {
                Disk disk = new Disk();
                disk.Name = textBox1.Text;
                disk.Regicer = textBox2.Text;
                disk.Ganre = textBox3.Text;
                disk.Rating = Convert.ToDouble(textBox4.Text);
                disk.Cost = Convert.ToDouble(textBox5.Text);

                disks.Add(disk);

                Save();

                this.Close();
            }

           
        }
    }
}
