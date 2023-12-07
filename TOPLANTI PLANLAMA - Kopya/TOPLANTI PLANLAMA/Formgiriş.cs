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
    public partial class Formgiriş : Form
    {
        public Formgiriş()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form1 aa = new Form1();
            aa.klncadi1 = textBox1.Text;
            aa.Show();
            this.Hide();

        }
    }
}
