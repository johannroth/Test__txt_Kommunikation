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
    public partial class Form1 : Form
    {

        int count = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string newText = string.Format(Environment.NewLine + "test {0}", count.ToString());
            textBox1.Text += newText;
            count++;
            textBox1.SelectionStart = textBox1.TextLength;
            textBox1.ScrollToCaret();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!System.IO.File.Exists(@"D:\Git-Repos\Test__txt_Kommunikation\Test__txt_Kommunikation\txt-test\test1.txt"))
            {
                System.IO.File.Create(@"D:\Git-Repos\Test__txt_Kommunikation\Test__txt_Kommunikation\txt-test\test1.txt");
            }
               
            System.IO.File.WriteAllText(@"D:\Git-Repos\Test__txt_Kommunikation\Test__txt_Kommunikation\txt-test\test1.txt", textBox1.Text);
        }
    }
}
