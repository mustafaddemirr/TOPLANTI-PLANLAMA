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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public string klncadi2;
        private void button1_Click(object sender, EventArgs e)
        {

            DateTime tarih1 = dateTimePicker1.Value;
            DateTime tarih2 = dateTimePicker2.Value;
            TimeSpan fark = tarih2 - tarih1;
            label1.Text = fark.ToString();

            if (dateTimePicker1.Value <= dateTimePicker2.Value)
            {
                if (label1.Text == "1.00:00:00" || label1.Text == "00:00:00")
                {
                    MessageBox.Show("Planlanan tarih aralığı en az 2 gün olmalıdır");
                }
                else if (label1.Text == "4.00:00:00" || label1.Text == "3.00:00:00" || label1.Text == "2.00:00:00")
                {


                    Random random = new Random();
                    char randomChar1 = (char)random.Next('A', 'Z' + 1);
                    char randomChar2 = (char)random.Next('A', 'Z' + 1);
                    int randomNumber = random.Next(1000, 9999);
                    string randomkod = $"{randomChar1}{randomChar2}{randomNumber:D4}";

                    string baslangicTarihi = dateTimePicker1.Value.ToString("dd.MM.yyyy");
                    string bitisTarihi = dateTimePicker2.Value.ToString("dd.MM.yyyy");

                    textBox1.Text = randomkod;
                    string dosyaYolu = $"{randomkod}.txt";

                    File.WriteAllText(dosyaYolu, $"{label8.Text}\r\n{textBox2.Text}\r\n{textBox3.Text}\r\n{richTextBox1.Text}\r\n{baslangicTarihi}\r\n{bitisTarihi}\r\n{randomkod}\r");


                    MessageBox.Show("Toplantı Kaydı Yapıldı");

                }
                else
                {
                    MessageBox.Show("Planlanan tarih aralığı 5 günden fazla olamaz.");
                }
            }
            else
            {
                MessageBox.Show("Son tarih ilk tarihten önce gelemez. Lütfen değiştiriniz.");
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label8.Text = klncadi2.ToString();
        }
    }
}
