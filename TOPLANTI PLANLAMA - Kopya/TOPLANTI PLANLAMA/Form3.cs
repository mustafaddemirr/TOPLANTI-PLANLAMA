using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TOPLANTI_PLANLAMA
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        public string geri;
        public string klncadi3;

        private void Form3_Load(object sender, EventArgs e)
        {
            if (klncadi3 != null)
                label1.Text = klncadi3.ToString();
            else
                label1.Text = geri.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string dosyaAdi = $"{textBox1.Text}.txt";


            string uygulamaDizini = AppDomain.CurrentDomain.BaseDirectory;


            string dosyaYolu = Path.Combine(uygulamaDizini, dosyaAdi);


            if (File.Exists(dosyaYolu))
            {

                string[] satirlar = File.ReadAllLines(dosyaYolu);
                listBox1.Items.AddRange(satirlar);

                Form4 aa = new Form4();
                aa.aktar(listBox1.Items);
                aa.klncadi4 = label1.Text;
                aa.kod = textBox1.Text;
                aa.Show();
                this.Hide();

            }

            else
            {
                MessageBox.Show("Erişim kodunuzu doğru girdiğinize emin olunuz.", "Hatalı Giriş");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 xx = new Form1();
            xx.geri1 = label1.Text;
            xx.Show();
            this.Hide();
        }
    }
}
