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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 cfrm = new Form1();
            cfrm.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 cfrm = new Form3();
            cfrm.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 cfrm = new Form4();
            cfrm.Show();
            Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 cfrm = new Form5();
            cfrm.Show();
            Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form6 cfrm = new Form6();
            cfrm.Show();
            Hide();
        }
    }
}
