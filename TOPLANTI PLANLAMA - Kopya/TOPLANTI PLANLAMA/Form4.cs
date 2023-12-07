using System;
using System.Collections;
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
    public partial class Form4 : Form
    {

        public string klncadi4;
        public string kod;
        public string kodgeri;
        public string klncgeri2;
        public void aktar(IEnumerable veriler)
        {
            foreach (var değer in veriler)
            {
                listBox1.Items.Add(değer);
            }
        }
        public void aktar1(IEnumerable veriler)
        {
            foreach (var değer1 in veriler)
            {
                listBox1.Items.Add(değer1);
            }
        }

        public Form4()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            yanıtlar aa = new yanıtlar();
            aa.kod1 = label9.Text;
            aa.klncgeri = label7.Text;
            aa.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (label10.Text != label7.Text && label11.Text != label7.Text && label12.Text != label7.Text && label13.Text != label7.Text && label14.Text != label7.Text)
            {

                if (listBox1.Items.Count > 6)
                {
                    string dosyaAdi = $"{listBox1.Items[6]}.txt";

                    string uygulamaDizini = AppDomain.CurrentDomain.BaseDirectory;
                    string dosyaYolu = Path.Combine(uygulamaDizini, dosyaAdi);


                    if (label2.Text == label7.Text)
                    {
                        MessageBox.Show("Size ait toplantıda tarih seçimi yapamazsınız.");
                        return;
                    }
                    else
                    {
                        if (checkBox1.Checked)
                        {
                            string yeniIcerik = $"{label7.Text}:{richTextBox2.Text}";
                            File.AppendAllText(dosyaYolu, yeniIcerik + Environment.NewLine);
                        }
                        else
                        {
                            if (dateTimePicker2.Value.Date == DateTime.Parse(label4.Text).Date && dateTimePicker3.Value.Date == DateTime.Parse(label4.Text).Date)
                            {
                                string yeniIcerik = $"{label7.Text}:{dateTimePicker1.Text}";
                                File.AppendAllText(dosyaYolu, yeniIcerik + Environment.NewLine);
                            }
                            else if (dateTimePicker3.Value.Date == DateTime.Parse(label4.Text).Date)
                            {
                                string yeniIcerik = $"{label7.Text}:{dateTimePicker1.Text},{dateTimePicker2.Text}";
                                File.AppendAllText(dosyaYolu, yeniIcerik + Environment.NewLine);
                            }
                            else
                            {
                                string yeniIcerik = $"{label7.Text}:{dateTimePicker1.Text}, {dateTimePicker2.Text}, {dateTimePicker3.Text}";
                                File.AppendAllText(dosyaYolu, yeniIcerik + Environment.NewLine);
                            }
                        }

                        MessageBox.Show("Belirttiğiniz tarihler kaydedilmiştir.");
                        checkBox1.Checked = false;
                    }
                }
           
            }
            else
            {
                MessageBox.Show("Size ait bir yanıt bulunmaktadır daha fazla yanıt veremezsiniz");
                checkBox1.Checked = false;
            }
               

        }

        private void button3_Click(object sender, EventArgs e)
        {
            dateTimePicker2.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dateTimePicker3.Visible = true;
            button6.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dateTimePicker2.Visible = false;
            dateTimePicker2.Value = DateTime.Parse(label4.Text);
            button4.Visible = false;
            button5.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dateTimePicker3.Visible = false;
            dateTimePicker3.Value = DateTime.Parse(label4.Text);
            button6.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 bb = new Form3();
            bb.geri = label7.Text;
            bb.Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            DateTime başlangıçtarihi = DateTime.Parse(label4.Text);
            DateTime bitistarihi = DateTime.Parse(label5.Text);
            List<DateTime> tariharalığı = tariharalığınıal(başlangıçtarihi, bitistarihi);
            tariharalığınıgöster(tariharalığı);
        }

        private List<DateTime> tariharalığınıal(DateTime başlangıçtarihi, DateTime bitistarihi)
        {
            List<DateTime> tariharalığı = new List<DateTime>();

            for (DateTime tarih = başlangıçtarihi; tarih <= bitistarihi; tarih = tarih.AddDays(1))
            {
                tariharalığı.Add(tarih);

            }
            return tariharalığı;

        }

        private void tariharalığınıgöster(List<DateTime> tariharalığı)
        {
            richTextBox2.Clear();
            foreach (var tarih in tariharalığı)
            {
                richTextBox2.AppendText(tarih.ToString("dd.MM.yyyy"));
                if (tarih != tariharalığı.Last())
                {
                    richTextBox2.AppendText(" , ");
                }
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {


            if (listBox1.Items.Count >= 8)
            {
                string yedinci = listBox1.Items[7].ToString();
                int index = yedinci.IndexOf(':');
                string altdizi = index != -1 ? yedinci.Substring(0, index) : yedinci;
                label10.Text = altdizi;
            }


            if (listBox1.Items.Count >= 9)
            {
                string sekizinci = listBox1.Items[8].ToString();
                int index1 = sekizinci.IndexOf(':');
                string altdizi1 = index1 != -1 ? sekizinci.Substring(0, index1) : sekizinci;
                label11.Text = altdizi1;
            }


            if (listBox1.Items.Count >=10)
            {
                string dokuzuncu = listBox1.Items[9].ToString();
                int index2 = dokuzuncu.IndexOf(':');
                string altdizi2 = index2 != -1 ? dokuzuncu.Substring(0, index2) : dokuzuncu;
                label12.Text = altdizi2;
            }
            


            if (listBox1.Items.Count >= 11)
            {
                string onuncu = listBox1.Items[10].ToString();
                int index3 = onuncu.IndexOf(':');
                string altdizi3 = index3 != -1 ? onuncu.Substring(0, index3) : onuncu;
                label13.Text = altdizi3;
            }




            if (listBox1.Items.Count >= 12)
            {
                string onbirinci = listBox1.Items[11].ToString();
                int index4 = onbirinci.IndexOf(':');
                string altdizi4 = index4 != -1 ? onbirinci.Substring(0, index4) : onbirinci;
                label14.Text = altdizi4;
            }


            if (klncadi4 != null)
                label7.Text = klncadi4;
            else
                label7.Text = klncgeri2;

            if (kod != null)
                label9.Text = kod.ToString();
            else
                label9.Text = kodgeri.ToString();

            if (listBox1.Items.Count > 5)
            {
                label2.Text = listBox1.Items[0].ToString();
                label4.Text = listBox1.Items[4].ToString();
                label5.Text = listBox1.Items[5].ToString();
                richTextBox1.Text = listBox1.Items[2].ToString() + "\n" + "\n" + listBox1.Items[3].ToString() + "\n" + "\n" + "Toplantımızı " + label4.Text + " - " + label5.Text + " tarihleri arasında düzenlemeyi planlıyoruz." + "\n" + "\n" + listBox1.Items[1].ToString();

            }

            if (DateTime.TryParse(label4.Text, out DateTime dtmin))
            {
                dateTimePicker1.MinDate = dtmin;
            }
            if (DateTime.TryParse(label5.Text, out DateTime dtmax))
            {
                dateTimePicker1.MaxDate = dtmax;
            }

            if (DateTime.TryParse(label4.Text, out DateTime dtmin1))
            {
                dateTimePicker2.MinDate = dtmin1;
            }
            if (DateTime.TryParse(label5.Text, out DateTime dtmax1))
            {
                dateTimePicker2.MaxDate = dtmax1;
            }

            if (DateTime.TryParse(label4.Text, out DateTime dtmin2))
            {
                dateTimePicker3.MinDate = dtmin2;
            }
            if (DateTime.TryParse(label5.Text, out DateTime dtmax2))
            {
                dateTimePicker3.MaxDate = dtmax2;
            }
        }
    }
}
