using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HelloWorld
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "HelloWorld";
            textBox1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Belka - ест орешки, а скорлупки золотые";
            textBox1.Text = "Belka";
            textBox1.Text = "Belka - strelka";

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Возвращение";
        }
    }
}
