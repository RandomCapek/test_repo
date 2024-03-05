using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            if (textBox1.Text == "4")
                progressBar1.Value += 20;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            if (textBox2.Text == "12")
                progressBar1.Value += 20;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Enabled = false;
            if (textBox4.Text == "3")
                progressBar1.Value += 20;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Enabled = false;
            if (textBox3.Text == "0")
                progressBar1.Value += 20;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Enabled = false;
            if (textBox6.Text == "48")
                progressBar1.Value += 20;
        }
    }
}
