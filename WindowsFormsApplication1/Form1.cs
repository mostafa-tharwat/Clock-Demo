using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// this is called when the button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = DateTime.Now.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = DateTime.Now.ToString();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            textBox1.Text = DateTime.Now.ToString();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = DateTime.Now.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show(textBox1.Text);
        }
    }
}
