using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Burçlara_Göre_Renklerin_Dili
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Koç")
            {
                pictureBox1.Image = Properties.Resources.kocbrc;
            }
            else if (comboBox1.SelectedItem.ToString() == "Boğa")
            {
                pictureBox1.Image = Properties.Resources.bogabrc;
            }
            else if (comboBox1.SelectedItem.ToString() == "İkizler")
            {
                pictureBox1.Image = Properties.Resources.ikizlerbrc;
            }
            else if (comboBox1.SelectedItem.ToString() == "Yengeç")
            {
                pictureBox1.Image = Properties.Resources.yengecbrc;
            }
            else if (comboBox1.SelectedItem.ToString() == "Aslan")
            {
                pictureBox1.Image = Properties.Resources.aslanbrc;
            }
            else if (comboBox1.SelectedItem.ToString() == "Başak")
            {
                pictureBox1.Image = Properties.Resources.basakbrc;
            }
            else if (comboBox1.SelectedItem.ToString() == "Terazi")
            {
                pictureBox1.Image = Properties.Resources.terazibrc;
            }
            else if (comboBox1.SelectedItem.ToString() == "Akrep")
            {
                pictureBox1.Image = Properties.Resources.akrepbrc;
            }
            else if (comboBox1.SelectedItem.ToString() == "Yay")
            {
                pictureBox1.Image = Properties.Resources.yaybrc;
            }
            else if (comboBox1.SelectedItem.ToString() == "Oğlak")
            {
                pictureBox1.Image = Properties.Resources.oglakbrc;
            }
            else if (comboBox1.SelectedItem.ToString() == "Kova")
            {
                pictureBox1.Image = Properties.Resources.kovabrc;
            }
            else if(comboBox1.SelectedItem.ToString() == "Balık")
            {
                pictureBox1.Image = Properties.Resources.balikbrc;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem.ToString() == "Kırmızı")
            {
                button2.BackColor = Color.Red;
            }
            else if (comboBox2.SelectedItem.ToString() == "Sarı")
            {
                button2.BackColor = Color.Yellow;
            }
            else if (comboBox2.SelectedItem.ToString() == "Yeşil")
            {
                button2.BackColor = Color.Green;
            }
            else if (comboBox2.SelectedItem.ToString() == "Mavi")
            {
                button2.BackColor = Color.Blue;
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Koç" ) 
                {
                 if (comboBox2.Text == "Mavi")
                {
                    textBox2.Text = textBox1.Text + " " + "burcunda" + " " + comboBox2.Text + " " + "rengin anlamı: Doğayı ve parayı temsil etmektedir. ";
                }
                else if (comboBox2.Text == "Yeşil")
                {
                    textBox2.Text = textBox1.Text + " " + "burcunda" + " " + comboBox2.Text + " " + "rengin anlamı: Şans ve uğuru temsil etmektedir. ";
                }
                else if (comboBox2.Text == "Sarı")
                {
                    textBox2.Text = textBox1.Text + " " + "burcunda" + " " + comboBox2.Text + " " + "rengin anlamı: Bereketi ve zenginliği temsil etmektedir. ";
                }
                else if (comboBox2.Text == "Kırmızı")
                {
                    textBox2.Text = textBox1.Text + " " + "burcunda" + " " + comboBox2.Text + " " + "rengin anlamı: Hareketi ve enerjiyi  temsil etmektedir. ";
                }

            }
            if (comboBox1.Text == "Boğa")
            {
                if (comboBox2.Text == "Mavi")
                {
                    textBox2.Text = textBox1.Text + " " + "burcunda" + " " + comboBox2.Text + " " + "rengin anlamı: Doğayı ve parayı temsil etmektedir. ";
                }
                else if (comboBox2.Text == "Yeşil")
                {
                    textBox2.Text = textBox1.Text + " " + "burcunda" + " " + comboBox2.Text + " " + "rengin anlamı: Şans ve uğuru temsil etmektedir. ";
                }
                else if (comboBox2.Text == "Sarı")
                {
                    textBox2.Text = textBox1.Text + " " + "burcunda" + " " + comboBox2.Text + " " + "rengin anlamı: Bereketi ve zenginliği temsil etmektedir. ";
                }
                else if (comboBox2.Text == "Kırmızı")
                {
                    textBox2.Text = textBox1.Text + " " + "burcunda" + " " + comboBox2.Text + " " + "rengin anlamı: Hareketi ve enerjiyi  temsil etmektedir. ";
                }

            }
            if (comboBox1.Text == "İkizler")
            {
                if (comboBox2.Text == "Mavi")
                {
                    textBox2.Text = textBox1.Text + " " + "burcunda" + " " + comboBox2.Text + " " + "rengin anlamı: Doğayı ve parayı temsil etmektedir. ";
                }
                else if (comboBox2.Text == "Yeşil")
                {
                    textBox2.Text = textBox1.Text + " " + "burcunda" + " " + comboBox2.Text + " " + "rengin anlamı: Şans ve uğuru temsil etmektedir. ";
                }
                else if (comboBox2.Text == "Sarı")
                {
                    textBox2.Text = textBox1.Text + " " + "burcunda" + " " + comboBox2.Text + " " + "rengin anlamı: Bereketi ve zenginliği temsil etmektedir. ";
                }
                else if (comboBox2.Text == "Kırmızı")
                {
                    textBox2.Text = textBox1.Text + " " + "burcunda" + " " + comboBox2.Text + " " + "rengin anlamı: Hareketi ve enerjiyi  temsil etmektedir. ";
                }

            }
            if (comboBox1.Text == "Yengeç")
            {
                if (comboBox2.Text == "Mavi")
                {
                    textBox2.Text = textBox1.Text + " " + "burcunda" + " " + comboBox2.Text + " " + "rengin anlamı: Doğayı ve parayı temsil etmektedir. ";
                }
                else if (comboBox2.Text == "Yeşil")
                {
                    textBox2.Text = textBox1.Text + " " + "burcunda" + " " + comboBox2.Text + " " + "rengin anlamı: Şans ve uğuru temsil etmektedir. ";
                }
                else if (comboBox2.Text == "Sarı")
                {
                    textBox2.Text = textBox1.Text + " " + "burcunda" + " " + comboBox2.Text + " " + "rengin anlamı: Bereketi ve zenginliği temsil etmektedir. ";
                }
                else if (comboBox2.Text == "Kırmızı")
                {
                    textBox2.Text = textBox1.Text + " " + "burcunda" + " " + comboBox2.Text + " " + "rengin anlamı: Hareketi ve enerjiyi  temsil etmektedir. ";
                }

            }
            if (comboBox1.Text == "Aslan")
            {
                if (comboBox2.Text == "Mavi")
                {
                    textBox2.Text = textBox1.Text + " " + "burcunda" + " " + comboBox2.Text + " " + "rengin anlamı: Doğayı ve parayı temsil etmektedir. ";
                }
                else if (comboBox2.Text == "Yeşil")
                {
                    textBox2.Text = textBox1.Text + " " + "burcunda" + " " + comboBox2.Text + " " + "rengin anlamı: Şans ve uğuru temsil etmektedir. ";
                }
                else if (comboBox2.Text == "Sarı")
                {
                    textBox2.Text = textBox1.Text + " " + "burcunda" + " " + comboBox2.Text + " " + "rengin anlamı: Bereketi ve zenginliği temsil etmektedir. ";
                }
                else if (comboBox2.Text == "Kırmızı")
                {
                    textBox2.Text = textBox1.Text + " " + "burcunda" + " " + comboBox2.Text + " " + "rengin anlamı: Hareketi ve enerjiyi  temsil etmektedir. ";
                }

            }
            if (comboBox1.Text == "Başak")
            {
                if (comboBox2.Text == "Mavi")
                {
                    textBox2.Text = textBox1.Text + " " + "burcunda" + " " + comboBox2.Text + " " + "rengin anlamı: Doğayı ve parayı temsil etmektedir. ";
                }
                else if (comboBox2.Text == "Yeşil")
                {
                    textBox2.Text = textBox1.Text + " " + "burcunda" + " " + comboBox2.Text + " " + "rengin anlamı: Şans ve uğuru temsil etmektedir. ";
                }
                else if (comboBox2.Text == "Sarı")
                {
                    textBox2.Text = textBox1.Text + " " + "burcunda" + " " + comboBox2.Text + " " + "rengin anlamı: Bereketi ve zenginliği temsil etmektedir. ";
                }
                else if (comboBox2.Text == "Kırmızı")
                {
                    textBox2.Text = textBox1.Text + " " + "burcunda" + " " + comboBox2.Text + " " + "rengin anlamı: Hareketi ve enerjiyi  temsil etmektedir. ";
                }

            }
            if (comboBox1.Text == "Terazi")
            {
                if (comboBox2.Text == "Mavi")
                {
                    textBox2.Text = textBox1.Text + " " + "burcunda" + " " + comboBox2.Text + " " + "rengin anlamı: Doğayı ve parayı temsil etmektedir. ";
                }
                else if (comboBox2.Text == "Yeşil")
                {
                    textBox2.Text = textBox1.Text + " " + "burcunda" + " " + comboBox2.Text + " " + "rengin anlamı: Şans ve uğuru temsil etmektedir. ";
                }
                else if (comboBox2.Text == "Sarı")
                {
                    textBox2.Text = textBox1.Text + " " + "burcunda" + " " + comboBox2.Text + " " + "rengin anlamı: Bereketi ve zenginliği temsil etmektedir. ";
                }
                else if (comboBox2.Text == "Kırmızı")
                {
                    textBox2.Text = textBox1.Text + " " + "burcunda" + " " + comboBox2.Text + " " + "rengin anlamı: Hareketi ve enerjiyi  temsil etmektedir. ";
                }

            }
            if (comboBox1.Text == "Akrep")
            {
                if (comboBox2.Text == "Mavi")
                {
                    textBox2.Text = textBox1.Text + " " + "burcunda" + " " + comboBox2.Text + " " + "rengin anlamı: Doğayı ve parayı temsil etmektedir. ";
                }
                else if (comboBox2.Text == "Yeşil")
                {
                    textBox2.Text = textBox1.Text + " " + "burcunda" + " " + comboBox2.Text + " " + "rengin anlamı: Şans ve uğuru temsil etmektedir. ";
                }
                else if (comboBox2.Text == "Sarı")
                {
                    textBox2.Text = textBox1.Text + " " + "burcunda" + " " + comboBox2.Text + " " + "rengin anlamı: Bereketi ve zenginliği temsil etmektedir. ";
                }
                else if (comboBox2.Text == "Kırmızı")
                {
                    textBox2.Text = textBox1.Text + " " + "burcunda" + " " + comboBox2.Text + " " + "rengin anlamı: Hareketi ve enerjiyi  temsil etmektedir. ";
                }

            }
            if (comboBox1.Text == "Yay")
            {
                if (comboBox2.Text == "Mavi")
                {
                    textBox2.Text = textBox1.Text + " " + "burcunda" + " " + comboBox2.Text + " " + "rengin anlamı: Doğayı ve parayı temsil etmektedir. ";
                }
                else if (comboBox2.Text == "Yeşil")
                {
                    textBox2.Text = textBox1.Text + " " + "burcunda" + " " + comboBox2.Text + " " + "rengin anlamı: Şans ve uğuru temsil etmektedir. ";
                }
                else if (comboBox2.Text == "Sarı")
                {
                    textBox2.Text = textBox1.Text + " " + "burcunda" + " " + comboBox2.Text + " " + "rengin anlamı: Bereketi ve zenginliği temsil etmektedir. ";
                }
                else if (comboBox2.Text == "Kırmızı")
                {
                    textBox2.Text = textBox1.Text + " " + "burcunda" + " " + comboBox2.Text + " " + "rengin anlamı: Hareketi ve enerjiyi  temsil etmektedir. ";
                }

            }
            if (comboBox1.Text == "Oğlak")
            {
                if (comboBox2.Text == "Mavi")
                {
                    textBox2.Text = textBox1.Text + " " + "burcunda" + " " + comboBox2.Text + " " + "rengin anlamı: Doğayı ve parayı temsil etmektedir. ";
                }
                else if (comboBox2.Text == "Yeşil")
                {
                    textBox2.Text = textBox1.Text + " " + "burcunda" + " " + comboBox2.Text + " " + "rengin anlamı: Şans ve uğuru temsil etmektedir. ";
                }
                else if (comboBox2.Text == "Sarı")
                {
                    textBox2.Text = textBox1.Text + " " + "burcunda" + " " + comboBox2.Text + " " + "rengin anlamı: Bereketi ve zenginliği temsil etmektedir. ";
                }
                else if (comboBox2.Text == "Kırmızı")
                {
                    textBox2.Text = textBox1.Text + " " + "burcunda" + " " + comboBox2.Text + " " + "rengin anlamı: Hareketi ve enerjiyi  temsil etmektedir. ";
                }

            }
            if (comboBox1.Text == "Kova")
            {
                if (comboBox2.Text == "Mavi")
                {
                    textBox2.Text = textBox1.Text + " " + "burcunda" + " " + comboBox2.Text + " " + "rengin anlamı: Doğayı ve parayı temsil etmektedir. ";
                }
                else if (comboBox2.Text == "Yeşil")
                {
                    textBox2.Text = textBox1.Text + " " + "burcunda" + " " + comboBox2.Text + " " + "rengin anlamı: Şans ve uğuru temsil etmektedir. ";
                }
                else if (comboBox2.Text == "Sarı")
                {
                    textBox2.Text = textBox1.Text + " " + "burcunda" + " " + comboBox2.Text + " " + "rengin anlamı: Bereketi ve zenginliği temsil etmektedir. ";
                }
                else if (comboBox2.Text == "Kırmızı")
                {
                    textBox2.Text = textBox1.Text + " " + "burcunda" + " " + comboBox2.Text + " " + "rengin anlamı: Hareketi ve enerjiyi  temsil etmektedir. ";
                }

            }
            if (comboBox1.Text == "Balık")
            {
                if (comboBox2.Text == "Mavi")
                {
                    textBox2.Text = textBox1.Text + " " + "burcunda" + " " + comboBox2.Text + " " + "rengin anlamı: Doğayı ve parayı temsil etmektedir. ";
                }
                else if (comboBox2.Text == "Yeşil")
                {
                    textBox2.Text = textBox1.Text + " " + "burcunda" + " " + comboBox2.Text + " " + "rengin anlamı: Şans ve uğuru temsil etmektedir. ";
                }
                else if (comboBox2.Text == "Sarı")
                {
                    textBox2.Text = textBox1.Text + " " + "burcunda" + " " + comboBox2.Text + " " + "rengin anlamı: Bereketi ve zenginliği temsil etmektedir. ";
                }
                else if (comboBox2.Text == "Kırmızı")
                {
                    textBox2.Text = textBox1.Text + " " + "burcunda" + " " + comboBox2.Text + " " + "rengin anlamı: Hareketi ve enerjiyi  temsil etmektedir. ";
                }

            }

        }
    }
}
