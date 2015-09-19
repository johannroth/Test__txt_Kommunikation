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
    public partial class Gui : Form
    {

        int count = 0;
        Options options;

        public Gui()
        {
            InitializeComponent();
            options = new Options();
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

        public delegate void UiWriteText(string text);
        public void WriteText(string text)
        {
            if (testTextLabel.InvokeRequired)
            {
                UiWriteText d = new UiWriteText(WriteText);
                Invoke(d, new object[] { text });
            }
            else
            {
                testTextLabel.Text = text;
            }
        }

        private void testTextButton_Click(object sender, EventArgs e)
        {
            ClickEventArgs args = new ClickEventArgs();
            args.text = testTextBox.Text;
            buttonClick(this, args);
        }

        public delegate void buttonClickHandler(Object source, ClickEventArgs e);
        public event buttonClickHandler buttonClick;

        private void button2_Click(object sender, EventArgs e)
        {
            options.Show();
            options.WindowState = FormWindowState.Normal;
        }

        

    }
}
