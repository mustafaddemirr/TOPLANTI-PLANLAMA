using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TOPLANTI_PLANLAMA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string klncadi1;
        public string geri1;

        private void Form1_Load(object sender, EventArgs e)
        {
            if (klncadi1 != null)
                label2.Text = klncadi1.ToString();
            else
                label2.Text = geri1.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 aa = new Form2();
            aa.klncadi2 = label2.Text;
            aa.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 aa = new Form3();
            aa.klncadi3 = label2.Text;
            aa.Show();
            this.Hide();
        }
    }
}
