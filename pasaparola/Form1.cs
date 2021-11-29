using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pasaparola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        int soruno,dogru=0,yanlis;
        string cevap = null;
       

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

            
                if (e.KeyChar == (char)13)
                {
                cevap = textBox1.Text.ToLower();

                if (cevap != "")
                {
                    switch (soruno)
                    {
                        case 1:

                            if (cevap == "akdeniz")
                            {
                                textBox1.Clear();
                                linkLabel1.Enabled = true;
                                button23.BackColor = Color.Green;
                                dogru++;
                                label2.Text = dogru.ToString();
                            }
                            else
                            {
                                button23.BackColor = Color.Red;
                                yanlis++;
                                label4.Text = yanlis.ToString();


                            }
                            break;
                        case 2:
                            cevap = textBox1.Text.ToLower();

                            if (cevap == "bursa")
                            {
                                linkLabel1.Enabled = true;
                                textBox1.Clear();

                                button23.BackColor = Color.Green;
                                dogru++;
                                label2.Text = dogru.ToString();
                            }
                            else
                            {
                                button23.BackColor = Color.Red;
                                yanlis++;
                                label4.Text = yanlis.ToString();


                            }
                            break;
                        case 3:
                            cevap = textBox1.Text.ToLower();

                            if (cevap == "cuma")
                            {
                                linkLabel1.Enabled = true;
                                textBox1.Clear();

                                button23.BackColor = Color.Green;
                                dogru++;
                                label2.Text = dogru.ToString();
                            }
                            else
                            {
                                button23.BackColor = Color.Red;
                                yanlis++;
                                label4.Text = yanlis.ToString();


                            }
                            break;
                        case 4:
                            cevap = textBox1.Text.ToLower();

                            if (cevap == "deniz")
                            {
                                linkLabel1.Enabled = true;
                                textBox1.Clear();

                                button23.BackColor = Color.Green;
                                dogru++;
                                label2.Text = dogru.ToString();
                            }
                            else
                            {
                                button23.BackColor = Color.Red;
                                yanlis++;
                                label4.Text = yanlis.ToString();


                            }
                            break;
                        case 5:
                            cevap = textBox1.Text.ToLower();

                            if (cevap == "edirne")
                            {
                                linkLabel1.Enabled = true;
                                textBox1.Clear();

                                button23.BackColor = Color.Green;
                                dogru++;
                                label2.Text = dogru.ToString();
                            }
                            else
                            {
                                button23.BackColor = Color.Red;
                                yanlis++;
                                label4.Text = yanlis.ToString();


                            }
                            break;
                        case 6:
                            cevap = textBox1.Text.ToLower();

                            if (cevap == "ferman")
                            {
                                linkLabel1.Enabled = true;
                                textBox1.Clear();

                                button23.BackColor = Color.Green;
                                dogru++;
                                label2.Text = dogru.ToString();
                            }
                            else
                            {
                                button23.BackColor = Color.Red;
                                yanlis++;
                                label4.Text = yanlis.ToString();


                            }
                            break;
                        case 7:
                            cevap = textBox1.Text.ToLower();

                            if (cevap == "güneş")
                            {
                                linkLabel1.Enabled = true;
                                textBox1.Clear();

                                button23.BackColor = Color.Green;
                                dogru++;
                                label2.Text = dogru.ToString();
                            }
                            else
                            {
                                button23.BackColor = Color.Red;
                                yanlis++;
                                label4.Text = yanlis.ToString();


                            }
                            break;
                        case 8:
                            cevap = textBox1.Text.ToLower();

                            if (cevap == "halı")
                            {
                                linkLabel1.Enabled = true;
                                textBox1.Clear();

                                button23.BackColor = Color.Green;
                                dogru++;
                                label2.Text = dogru.ToString();
                            }
                            else
                            {
                                button23.BackColor = Color.Red;
                                yanlis++;
                                label4.Text = yanlis.ToString();


                            }
                            break;
                        case 9:
                            cevap = textBox1.Text.ToLower();

                            if (cevap == "ısparta")
                            {
                                linkLabel1.Enabled = true;
                                textBox1.Clear();

                                button23.BackColor = Color.Green;
                                dogru++;
                                label2.Text = dogru.ToString();
                            }
                            else
                            {
                                button23.BackColor = Color.Red;
                                yanlis++;
                                label4.Text = yanlis.ToString();


                            }
                            break;

                        case 10:
                            cevap = textBox1.Text.ToLower();

                            if (cevap == "jandarma")
                            {
                                linkLabel1.Enabled = true;
                                textBox1.Clear();

                                button23.BackColor = Color.Green;
                                dogru++;
                                label2.Text = dogru.ToString();
                            }
                            else
                            {
                                button23.BackColor = Color.Red;
                                yanlis++;
                                label4.Text = yanlis.ToString();


                            }
                            break;

                        case 11:
                            cevap = textBox1.Text.ToLower();

                            if (cevap == "kayısı")
                            {
                                linkLabel1.Enabled = true;
                                textBox1.Clear();

                                button23.BackColor = Color.Green;
                                dogru++;
                                label2.Text = dogru.ToString();
                            }
                            else
                            {
                                button23.BackColor = Color.Red;
                                yanlis++;
                                label4.Text = yanlis.ToString();


                            }
                            break;
                        case 12:
                            cevap = textBox1.Text.ToLower();

                            if (cevap == "lale")
                            {
                                linkLabel1.Enabled = true;
                                textBox1.Clear();

                                button23.BackColor = Color.Green;
                                dogru++;
                                label2.Text = dogru.ToString();
                            }
                            else
                            {
                                button23.BackColor = Color.Red;
                                yanlis++;
                                label4.Text = yanlis.ToString();


                            }
                            break;
                        case 13:
                            cevap = textBox1.Text.ToLower();

                            if (cevap == "mart")
                            {
                                linkLabel1.Enabled = true;
                                textBox1.Clear();

                                button23.BackColor = Color.Green;
                                dogru++;
                                label2.Text = dogru.ToString();
                            }
                            else
                            {
                                button23.BackColor = Color.Red;
                                yanlis++;
                                label4.Text = yanlis.ToString();


                            }
                            break;
                        case 14:
                            cevap = textBox1.Text.ToLower();

                            if (cevap == "ney")
                            {
                                linkLabel1.Enabled = true;
                                textBox1.Clear();

                                button23.BackColor = Color.Green;
                                dogru++;
                                label2.Text = dogru.ToString();
                            }
                            else
                            {
                                button23.BackColor = Color.Red;
                                yanlis++;
                                label4.Text = yanlis.ToString();


                            }
                            break;
                        case 15:
                            cevap = textBox1.Text.ToLower();

                            if (cevap == "ozan")
                            {
                                linkLabel1.Enabled = true;
                                textBox1.Clear();

                                button23.BackColor = Color.Green;
                                dogru++;
                                label2.Text = dogru.ToString();
                            }
                            else
                            {
                                button23.BackColor = Color.Red;
                                yanlis++;
                                label4.Text = yanlis.ToString();


                            }
                            break;
                        case 16:
                            cevap = textBox1.Text.ToLower();

                            if (cevap == "pırasa")
                            {
                                linkLabel1.Enabled = true;
                                textBox1.Clear();

                                button23.BackColor = Color.Green;
                                dogru++;
                                label2.Text = dogru.ToString();
                            }
                            else
                            {
                                button23.BackColor = Color.Red;
                                yanlis++;
                                label4.Text = yanlis.ToString();


                            }
                            break;
                        case 17:
                            cevap = textBox1.Text.ToLower();

                            if (cevap == "ramazan")
                            {
                                linkLabel1.Enabled = true;
                                textBox1.Clear();

                                button23.BackColor = Color.Green;
                                dogru++;
                                label2.Text = dogru.ToString();
                            }
                            else
                            {
                                button23.BackColor = Color.Red;
                                yanlis++;
                                label4.Text = yanlis.ToString();


                            }
                            break;
                        case 18:
                            cevap = textBox1.Text.ToLower();

                            if (cevap == "sneak")
                            {
                                linkLabel1.Enabled = true;
                                textBox1.Clear();

                                button23.BackColor = Color.Green;
                                dogru++;
                                label2.Text = dogru.ToString();
                            }
                            else
                            {
                                button23.BackColor = Color.Red;
                                yanlis++;
                                label4.Text = yanlis.ToString();


                            }
                            break;
                        case 19:
                            cevap = textBox1.Text.ToLower();

                            if (cevap == "tarkan")
                            {
                                linkLabel1.Enabled = true;
                                textBox1.Clear();

                                button23.BackColor = Color.Green;
                                dogru++;
                                label2.Text = dogru.ToString();
                            }
                            else
                            {
                                button23.BackColor = Color.Red;
                                yanlis++;
                                label4.Text = yanlis.ToString();


                            }
                            break;

                        case 20:
                            cevap = textBox1.Text.ToLower();

                            if (cevap == "umut")
                            {
                                linkLabel1.Enabled = true;
                                textBox1.Clear();

                                button23.BackColor = Color.Green;
                                dogru++;
                                label2.Text = dogru.ToString();
                            }
                            else
                            {
                                button23.BackColor = Color.Red;
                                yanlis++;
                                label4.Text = yanlis.ToString();


                            }
                            break;
                        case 21:
                            cevap = textBox1.Text.ToLower();

                            if (cevap == "van")
                            {
                                linkLabel1.Enabled = true;
                                textBox1.Clear();

                                button23.BackColor = Color.Green;
                                dogru++;
                                label2.Text = dogru.ToString();
                            }
                            else
                            {
                                button23.BackColor = Color.Red;
                                yanlis++;
                                label4.Text = yanlis.ToString();


                            }
                            break;
                        case 22:
                            cevap = textBox1.Text.ToLower();

                            if (cevap == "yıldırım")
                            {
                                linkLabel1.Enabled = true;
                                textBox1.Clear();

                                button23.BackColor = Color.Green;
                                dogru++;
                                label2.Text = dogru.ToString();
                            }
                            else
                            {
                                button23.BackColor = Color.Red;
                                yanlis++;
                                label4.Text = yanlis.ToString();


                            }
                            break;
                        default:
                            break;
                    }
                }

            }
        }

       
        

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
            soruno++;
            linkLabel1.Text = "SONRAKİ";
            this.Text = soruno.ToString();
            if (linkLabel1.Text == "SONRAKİ")
            {
                linkLabel1.Enabled = false;
            }
            if (soruno==1)
            {
                richTextBox1.Text = "Ülkemizin güney kısmındaki kıyı bölgesi";
                button1.BackColor = Color.Yellow;
                button23.Text = button1.Text;

               
             
            }
           else if (soruno == 2)
            {
                richTextBox1.Text = "Yeşilliği ile ünlü marmara ilimiz?";
                button2.BackColor = Color.Yellow;
                button23.Text = button2.Text;

            }
            else if (soruno == 3)
            {
                richTextBox1.Text = "Müslümanların kutsal günü?";
                button3.BackColor = Color.Yellow;
                button23.Text = button3.Text;

            }
            else if (soruno == 4)
            {
                richTextBox1.Text = "Türkiyenin 3 tarafı ne ile kaplıdır?";
                button4.BackColor = Color.Yellow;
                button23.Text = button4.Text;

            }
            else if (soruno == 5)
            {
                richTextBox1.Text = "Ciğer yemeği ile meşhur olan ilimiz?";
                button5.BackColor = Color.Yellow;
                button23.Text = button5.Text;

            }
            else if (soruno == 6)
            {
                richTextBox1.Text = "Padişahın emirlerinin yazılı hali";
                button6.BackColor = Color.Yellow;
                button23.Text = button6.Text;

            }
            else if (soruno == 7)
            {
                richTextBox1.Text = "Dünyanın ısı kaynağı";
                button7.BackColor = Color.Yellow;
                button23.Text = button7.Text;

            }
            else if (soruno == 8)
            {
                richTextBox1.Text = "Öğrencilerin kötü karne getirdiğinde baktıkları yer";
                button8.BackColor = Color.Yellow;
                button23.Text = button8.Text;

            }
            else if (soruno == 9)
            {
                richTextBox1.Text = "Gülü ile ünlü ilimiz";
                button9.BackColor = Color.Yellow;
                button23.Text = button9.Text;

            }
            else if (soruno == 10)
            {
                richTextBox1.Text = "Askeri bir topluluk";
                button10.BackColor = Color.Yellow;
                button23.Text = button10.Text;

            }
            else if (soruno == 11)
            {
                richTextBox1.Text = "Malatyalıların ortak özelliği";
                button11.BackColor = Color.Yellow;
                button23.Text = button11.Text;

            }
            else if (soruno == 12)
            {
                richTextBox1.Text = "Her yıl bahar aylarında düzenlenen çiçek festivali";
                button12.BackColor = Color.Yellow;
                button23.Text = button12.Text;

            }
            else if (soruno == 13)
            {
                richTextBox1.Text = "Yılın 3.ayı";
                button13.BackColor = Color.Yellow;
                button23.Text = button13.Text;

            }
            else if (soruno == 14)
            {
                richTextBox1.Text = "üflemeli bir çalgı aleti";
                button14.BackColor = Color.Yellow;
                button23.Text = button14.Text;

            }
            else if (soruno == 15)
            {
                richTextBox1.Text = "Halk Şairi";
                button15.BackColor = Color.Yellow;
                button23.Text = button15.Text;

            }
            else if (soruno == 16)
            {
                richTextBox1.Text = "Çocukların pek sevmediği havuç ve pirinç gibi gıdalar ile yapılan yemek";
                button16.BackColor = Color.Yellow;
                button23.Text = button16.Text;

            }
            else if (soruno == 17)
            {
                richTextBox1.Text = "11 ayın sultana";
                button17.BackColor = Color.Yellow;
                button23.Text = button17.Text;

            }
            else if (soruno == 18)
            {
                richTextBox1.Text = "İngilizce yılan";
                button18.BackColor = Color.Yellow;
                button23.Text = button18.Text;

            }
            else if (soruno == 19)
            {
                richTextBox1.Text = "Mega Star";
                button19.BackColor = Color.Yellow;
                button23.Text = button19.Text;

            }
            else if (soruno == 20)
            {
                richTextBox1.Text = "Ümit kelimesinin eş anlamlısı";
                button20.BackColor = Color.Yellow;
                button23.Text = button20.Text;

            }
            else if (soruno == 21)
            {
                richTextBox1.Text = "Kahvaltısı ile ünlü ilimiz";
                button21.BackColor = Color.Yellow;
                button23.Text = button21.Text;

            }
            else if (soruno == 22)
            {
                richTextBox1.Text = "Şimşek kelimesinin eş anlamlısı";
                button22.BackColor = Color.Yellow;
                button23.Text = button22.Text;

            }

            
            
        }

    }
}
