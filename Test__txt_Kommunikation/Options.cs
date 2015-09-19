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
    }
}
