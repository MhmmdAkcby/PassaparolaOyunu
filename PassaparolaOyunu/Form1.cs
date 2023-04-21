using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassaparolaOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int dogru = 0, yanlis = 0, soruno = 0;

        int saniye = 60; //timer süresi
        int dakika = 2; //timer dakika
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval= 1000; // 1000 ms = 1 saniye
            saniye = saniye - 1;
            LblSaniye.Text=saniye.ToString();
            LblDakika.Text = (dakika - 1).ToString();
            if (saniye == 0)
            {
                dakika= dakika - 1;
                LblDakika.Text=dakika.ToString();
                saniye = 60;
            }
            if (LblDakika.Text == "-1")
            {
                timer1.Stop();
                LblDakika.Text = "0";
                LblSaniye.Text = "0";
                MessageBox.Show("Süre Doldu","Bilgi",MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Restart();  
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                switch (soruno)
                {
                    //Cevap 1
                    case 1:
                        if (textBox1.Text == "akdeniz")
                        {
                            button1.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button1.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;
                    //Cevap 2
                    case 2:
                        if (textBox1.Text == "bursa")
                        {
                            button2.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button2.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;
                    //Cevap 3
                    case 3:
                        if (textBox1.Text == "cuma")
                        {
                            button3.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button3.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;
                    //Cevap 4
                    case 4:
                        if (textBox1.Text == "diyarbakır")
                        {
                            button4.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button4.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;
                    //Cevap 5
                    case 5:
                        if (textBox1.Text == "eski")
                        {
                            button5.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button5.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;
                    //Cevap 6
                    case 6:
                        if (textBox1.Text == "ferman")
                        {
                            button6.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button6.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;
                    //Cevap 7
                    case 7:
                        if (textBox1.Text == "güneş")
                        {
                            button7.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button7.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;
                    //Cevap 8
                    case 8:
                        if (textBox1.Text == "hatay")
                        {
                            button8.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button8.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;
                    //Cevap 9
                    case 9:
                        if (textBox1.Text == "ısparta")
                        {
                            button9.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button9.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;
                    //Cevap 10
                    case 10:
                        if (textBox1.Text == "içel")
                        {
                            button10.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button10.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;
                    //Cevap 11
                    case 11:
                        if (textBox1.Text == "jandarma")
                        {
                            button11.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button11.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;
                    //Cevap 12
                    case 12:
                        if (textBox1.Text == "kayısı")
                        {
                            button12.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button12.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;
                    //Cevap 13
                    case 13:
                        if (textBox1.Text == "lale")
                        {
                            button13.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button13.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;
                    //Cevap 14
                    case 14:
                        if (textBox1.Text == "mart")
                        {
                            button14.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button14.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;
                    //Cevap 15
                    case 15:
                        if (textBox1.Text == "ney")
                        {
                            button15.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button15.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;
                    //Cevap 16
                    case 16:
                        if (textBox1.Text == "ozan")
                        {
                            button16.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button16.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;
                    //Cevap 17
                    case 17:
                        if (textBox1.Text == "pırasa")
                        {
                            button17.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button17.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;
                    //Cevap 18
                    case 18:
                        if (textBox1.Text == "ramazan")
                        {
                            button18.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button18.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;
                    //Cevap 19
                    case 19:
                        if (textBox1.Text == "snake")
                        {
                            button19.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button19.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;
                    //Cevap 20
                    case 20:
                        if (textBox1.Text == "tarkan")
                        {
                            button20.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button20.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;
                    //Cevap 21
                    case 21:
                        if (textBox1.Text == "umut")
                        {
                            button21.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button21.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;
                    //Cevap 22
                    case 22:
                        if (textBox1.Text == "van")
                        {
                            button22.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button22.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;
                    //Cevap 23
                    case 23:
                        if (textBox1.Text == "yıldırım")
                        {
                            button23.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button23.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;
                    //Cevap 24
                    case 24:
                        if (textBox1.Text == "zeytin")
                        {
                            button24.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();
                        }
                        else
                        {
                            button24.BackColor = Color.Red;
                            yanlis++;
                            label3.Text = yanlis.ToString();
                        }
                        break;
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.Text = "SONRAKİ";
            timer1.Enabled = true;
            timer1.Start();
            soruno++;
            this.Text = "Passaparola Oyunu Soru No : " + soruno.ToString();

            //Sorular

            if (soruno == 1)
            {
                richTextBox1.Text = "Ülkemizin güney kısmındaki kıyı bölgesi ?";
                button1.BackColor = Color.Yellow;
                button25.Text = "A";
            }
            if (soruno == 2)
            {
                richTextBox1.Text = "Yeşilliğiyle ünlü marmara ilimiz neresidir ?";
                button2.BackColor = Color.Yellow;
                button25.Text = "B";
            }
            if (soruno == 3)
            {
                richTextBox1.Text = "Müslümanların Kutsal günü ?";
                button3.BackColor = Color.Yellow;
                button25.Text = "C";
            }
            if (soruno == 4)
            {
                richTextBox1.Text = "Karpuzuyla ünlü ilimiz ?";
                button4.BackColor = Color.Yellow;
                button25.Text = "D";
            }
            if (soruno == 5)
            {
                richTextBox1.Text = "Yeni kelimesinin zıt anlamı ?";
                button5.BackColor = Color.Yellow;
                button25.Text = "E";
            }
            if (soruno == 6)
            {
                richTextBox1.Text = "Padişahın emirlerinin yazılı hali ?";
                button6.BackColor = Color.Yellow;
                button25.Text = "F";
            }
            if (soruno == 7)
            {
                richTextBox1.Text = "Dünyanın ısı kaynağı ?";
                button7.BackColor = Color.Yellow;
                button25.Text = "G";
            }
            if (soruno == 8)
            {
                richTextBox1.Text = "Künefesiyle ünlü ilimiz ?";
                button8.BackColor = Color.Yellow;
                button25.Text = "H";
            }
            if (soruno == 9)
            {
                richTextBox1.Text = "Gülüyle ünlü ilimiz ?";
                button9.BackColor = Color.Yellow;
                button25.Text = "I";
            }
            if (soruno == 10)
            {
                richTextBox1.Text = "Mersinin diğer ismi ?";
                button10.BackColor = Color.Yellow;
                button25.Text = "İ";
            }
            if (soruno == 11)
            {
                richTextBox1.Text = "Askeri bir topluluk ?";
                button11.BackColor = Color.Yellow;
                button25.Text = "J";
            }
            if (soruno == 12)
            {
                richTextBox1.Text = "Malatyanın meşhur meyvesi ?";
                button12.BackColor = Color.Yellow;
                button25.Text = "K";
            }
            if (soruno == 13)
            {
                richTextBox1.Text = "Her yıl bahar aylarında yapılan meşhur çiçek festivalin adı ?";
                button13.BackColor = Color.Yellow;
                button25.Text = "L";
            }
            if (soruno == 14)
            {
                richTextBox1.Text = "Yılın üçüncü ayı ?";
                button14.BackColor = Color.Yellow;
                button25.Text = "M";
            }
            if (soruno == 15)
            {
                richTextBox1.Text = "Üflemeli müzik aleti ?";
                button15.BackColor = Color.Yellow;
                button25.Text = "N";
            }
            if (soruno == 16)
            {
                richTextBox1.Text = "Halk şairi ?";
                button16.BackColor = Color.Yellow;
                button25.Text = "O";
            }
            if (soruno == 17)
            {
                richTextBox1.Text = "Çocukların pek sevmediği pirinç havuç gibi sebzlerele yapılan yemek nedir ?";
                button17.BackColor = Color.Yellow;
                button25.Text = "P";
            }
            if (soruno == 18)
            {
                richTextBox1.Text = "11 Ayın sultanı ?";
                button18.BackColor = Color.Yellow;
                button25.Text = "R";
            }
            if (soruno == 19)
            {
                richTextBox1.Text = "İnglizcede yılan ?";
                button19.BackColor = Color.Yellow;
                button25.Text = "S";
            }
            if (soruno == 20)
            {
                richTextBox1.Text = "Türiyenin megastarı olarak bilinen sanatçı kimdir ?";
                button20.BackColor = Color.Yellow;
                button25.Text = "T";
            }
            if (soruno == 21)
            {
                richTextBox1.Text = "Ümit kelimesinin eş anlamlısı ?";
                button21.BackColor = Color.Yellow;
                button25.Text = "U";
            }
            if (soruno == 22)
            {
                richTextBox1.Text = "Kahvaltısı ile ünlü ilimiz ?";
                button22.BackColor = Color.Yellow;
                button25.Text = "V";
            }
            if (soruno == 23)
            {
                richTextBox1.Text = "Şimşek kelimesini eş anlamlısı ?";
                button23.BackColor = Color.Yellow;
                button25.Text = "Y";
            }
            if (soruno == 24)
            {
                richTextBox1.Text = "Ege bölgesinde bulunan kahvaltılarda kullanılan aynı zamanda yağıda yapılan meyvesi nedir ?";
                button24.BackColor = Color.Yellow;
                button25.Text = "Z";
            }
            if (soruno == 25)
            {
                MessageBox.Show("Oyun Bitti Tekrar Oynayın","Bilgi",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
