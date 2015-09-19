using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test__txt_Kommunikation
{
    public partial class Options : Form
    {
        private int count;

        public Options()
        {
            InitializeComponent();
            count = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            count++;
            label1.Text = count.ToString();
        }

        private void selectFileButton_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                selectedFileTextBox.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void checkPathButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (System.IO.Directory.Exists(selectedFileTextBox.Text))
                {
                    checkPathLabel.Text = "zulässiger Ordner";
                }
                else
                {
                    checkPathLabel.Text = "Ordner existiert noch nicht";
                }
            }
            catch
            {
                checkPathLabel.Text = "Keine Zugriffsrechte";
            }
            
        }

        private void Options_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
            //Options options = sender as Options;
            //options.Hide();
        }

        private void schließenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
