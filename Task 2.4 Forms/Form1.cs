using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_2._4_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int f = 3;
            int n = 5;
            for (int i = 0; i < 10; i++)
            {
                int k = f;
                for (int j = 0; j < n; j++)
                {
                    if (i % 2 == 0)
                    {
                        textBox1.Text+="2" + " ";
                    }
                    else textBox1.Text += (k++) + " ";
                }
                if (i % 2 != 0)
                {
                    f--; n--;
                }
                textBox1.Text += "\r\n";
            }
        }
    }
}
