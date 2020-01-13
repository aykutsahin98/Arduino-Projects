using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{

    public partial class Form1 : Form
    {
        SerialPort sp1 = new SerialPort();
        public Form1()
        {
            InitializeComponent();
        }
        private void SetColor(Color color)   //Renk ayarlama fonksiyonu
        {
            try
            {
                panel2.BackColor = color;   //Panel rengini ayarla
                label4.Text = "R = " + color.R.ToString();  //Rengin R değerini yazdır
                label5.Text = "G = " + color.G.ToString();  //Rengin G değerini yazdır
                label7.Text = "B = " + color.B.ToString();  //Rengin B değerini yazdır
                R.Value = color.R;     //TrackBar 1
                G.Value = color.G;     //TrackBar 2
                B.Value = color.B;     //TrackBar 3
                sp1.Write(new[] { color.R, color.G, color.B }, 0, 3);  //Rengin RGB değerlerini porta gönder
            }
            catch (Exception ex2)
            {
                MessageBox.Show(ex2.Message, "Hata"); //Hata mesajı
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();  //Seri portları diziye ekleme
            foreach (string port in ports)
                comboBox1.Items.Add(port);               //Seri portları comboBox1'e ekleme
        }

        private void button2_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();    //Renk paletini aç
            SetColor(colorDialog1.Color); //Rengi renk paletinde seçilen olarak ayarla
        }

        private void kirmizi_click_Click(object sender, EventArgs e)
        {
            SetColor(Color.Red);
        }

        private void yesil_click_Click(object sender, EventArgs e)
        {
            SetColor(Color.Lime);
        }

        private void mavi_click_Click(object sender, EventArgs e)
        {
            SetColor(Color.Blue);
        }

        private void mor_click_Click(object sender, EventArgs e)
        {
            SetColor(Color.Purple);
        }

        private void sari_click_Click(object sender, EventArgs e)
        {
            SetColor(Color.Yellow);
        }

        private void magenta_Click(object sender, EventArgs e)
        {
            SetColor(Color.Magenta);
        }

        private void cyan_Click(object sender, EventArgs e)
        {
            SetColor(Color.Cyan);
        }

        private void beyaz_Click(object sender, EventArgs e)
        {
            SetColor(Color.White);
        }

        private void turuncu_Click(object sender, EventArgs e)
        {
            SetColor(Color.Orange);
        }

        private void pembe_Click(object sender, EventArgs e)
        {
            SetColor(Color.DeepPink);
        }

        private void kahverengi_Click(object sender, EventArgs e)
        {
            SetColor(Color.Brown);
        }

        private void yesil2_Click(object sender, EventArgs e)
        {
            SetColor(Color.Green);
        }

        private void R_Scroll(object sender, EventArgs e)
        {
            SetColor(Color.FromArgb(R.Value, G.Value, B.Value));
        }

        private void G_Scroll(object sender, EventArgs e)
        {
            SetColor(Color.FromArgb(R.Value, G.Value, B.Value));
        }

        private void B_Scroll(object sender, EventArgs e)
        {
            SetColor(Color.FromArgb(R.Value, G.Value, B.Value));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!sp1.IsOpen)
                {
                    sp1.PortName = comboBox1.Text; //Port ismini comboBox1'den al
                    sp1.BaudRate = 9600;           //BaudRate'i 9600 olarak ayarla
                    sp1.Open();                    //Seri portu aç
                    button2.Text = "KES";                 //Buton2 yazısını değiştir
                }
                else
                {

                    SetColor(Color.Black);                //Rengi siyah olarak ayarla
                    button2.Text = "BAĞLAN";              //Buton2 yazısını değiştir
                    sp1.Close();                   //Seri portu kapa

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata");      //Hata mesajı
            }
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (sp1.IsOpen) sp1.Close();    //Seri port açıksa kapat
        }

    }
}
