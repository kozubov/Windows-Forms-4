using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_4_2
{
    public partial class Form1 : Form
    {

        List<string> path = new List<string>();
        int indexPath = -1;
        public Form1()
        {
            InitializeComponent();
            DriveInfo[] allDrives = DriveInfo.GetDrives();
            foreach (DriveInfo d in allDrives)
            {
                listBox1.Items.Add(d);
            }

            ToolStripMenuItem_Forward1.Click += Forward;
            toolStripButton2_Forward2.Click += Forward;
            ToolStripMenuItem1_Forward3.Click += Forward;
            listBox1.DoubleClick += Forward;

            ToolStripMenuItem_Back1.Click += Back;
            toolStripButton_Back2.Click += Back;
            ToolStripMenuItem1_Back3.Click += Back;
            
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((ListBox)sender).SelectedIndex > -1)
            {
                this.Text = ((ListBox)sender).Items[((ListBox)sender).SelectedIndex].ToString();
            }
        }

        private void Forward(object sender, EventArgs e)
        {
            try
            {
                if (listBox1.SelectedIndex > -1)
                {

                    String mypath = listBox1.Items[listBox1.SelectedIndex].ToString();
                    path.Add(mypath);
                    indexPath++;
                    listBox1.Items.Clear();
                    listBox2.Items.Clear();
                    String[] files = Directory.GetFiles(mypath);
                    String[] dir = Directory.GetDirectories(mypath);
                    foreach (var file in files)
                    {
                        listBox2.Items.Add(file);
                    }

                    foreach (var d in dir)
                    {
                        listBox1.Items.Add(d);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Back(object sender, EventArgs e)
        {
            try
            {
                indexPath--;
                if (indexPath + 1 > 0)
                {
                    String mypath = path[indexPath];
                    path.Remove(path[indexPath + 1]);
                    listBox1.Items.Clear();
                    listBox2.Items.Clear();
                    String[] files = Directory.GetFiles(mypath);
                    String[] dir = Directory.GetDirectories(mypath);
                    foreach (var file in files)
                    {
                        listBox2.Items.Add(file);
                    }

                    foreach (var d in dir)
                    {
                        listBox1.Items.Add(d);
                    }
                }
                else
                {
                    listBox1.Items.Clear();
                    listBox2.Items.Clear();
                    DriveInfo[] allDrives = DriveInfo.GetDrives();
                    foreach (DriveInfo d in allDrives)
                    {
                        listBox1.Items.Add(d);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
