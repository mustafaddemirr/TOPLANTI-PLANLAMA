using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TOPLANTI_PLANLAMA
{
    public partial class yanıtlar : Form
    {
        public yanıtlar()
        {
            InitializeComponent();
        }

        public string kod1;
        public string klncgeri;
        private void yanıtlar_Load(object sender, EventArgs e)
        {
            labelgetir.Text = kod1.ToString();
            label7.Text = klncgeri.ToString();

            string dosyaAdi = $"{labelgetir.Text}.txt";


            string uygulamaDizini = AppDomain.CurrentDomain.BaseDirectory;


            string dosyaYolu = Path.Combine(uygulamaDizini, dosyaAdi);


            if (File.Exists(dosyaYolu))
            {

                string[] satirlar = File.ReadAllLines(dosyaYolu);
                listBox1.Items.AddRange(satirlar);

            }
            if (listBox1.Items.Count > 7)
            {
                label1.Text = listBox1.Items[7].ToString();
                panel1.Visible = true;
            }
            if (listBox1.Items.Count > 8)
            {
                label2.Text = listBox1.Items[8].ToString();
                panel2.Visible = true;
            }
            if (listBox1.Items.Count > 9)
            {
                label3.Text = listBox1.Items[9].ToString();
                panel3.Visible = true;
            }
            if (listBox1.Items.Count > 10)
            {
                label4.Text = listBox1.Items[10].ToString();
                panel4.Visible = true;

            }
            if (listBox1.Items.Count > 11)
            {
                label5.Text = listBox1.Items[11].ToString();
                panel5.Visible = true;

            }
            if (listBox1.Items.Count > 12)
            {
                label6.Text = listBox1.Items[12].ToString();
                panel6.Visible = true;

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 aa = new Form4();
            aa.aktar1(listBox1.Items);
            aa.kodgeri = labelgetir.Text;
            aa.klncgeri2 = label7.Text;
            aa.Show();
            this.Hide();
        }
    }
}
