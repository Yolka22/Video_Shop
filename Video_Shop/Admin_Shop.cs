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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace Video_Shop
{
    public partial class Admin_Shop : Form
    {
        List<Disk> disks = new List<Disk>();

        Add_Film add_Film = new Add_Film(); 

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


                for (int i = 0; i < disks.Count; i++)
                {

                    listBox1.Items.Add(disks[i].Name.ToString());
                    listBox1.Items.Add(disks[i].Regicer.ToString());
                    listBox1.Items.Add(disks[i].Ganre.ToString());
                    listBox1.Items.Add(disks[i].Rating.ToString());
                    listBox1.Items.Add(disks[i].Cost.ToString() + "\n");

                }

            }
            catch (Exception e)
            {

            }


        }

        public void Update()
        {

            disks.Clear();
            listBox1.Items.Clear();

            Read();

        }

        public Admin_Shop()
        {
            InitializeComponent();
            Read();
        }

        private void добавитьФильмToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_Film add_Film = new Add_Film();
            add_Film.ShowDialog();


            Update();
        }

        private void удалитьФильмToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Delete_Disk delete_Disk = new Delete_Disk();
            delete_Disk.ShowDialog();
            Update();
        }

        private void редактироватьФильмToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Change_Disk change_Disk = new Change_Disk();
            change_Disk.ShowDialog();
            Update();
        }
    }
}
