using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace yakinlik_sensor
{
    public partial class Form1 : Form
    {
        private string data;
        public Form1()
        {
            InitializeComponent();
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            data = serialPort1.ReadLine();                     //Gelen veriyi okuma
            this.Invoke(new EventHandler(displayData_event));
        }

        private void displayData_event(object sender, EventArgs e)
        {
            label3.Text = data;                               //Gelen veriyi label2'ye yaz
            progressBar1.Value = Convert.ToInt32(data);       //Gelen veriyi Int değikene döndürerek progressBar değerine eşitle
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();  //Seri portları diziye ekleme
            foreach (string port in ports)
                comboBox1.Items.Add(port);               //Seri portları comboBox1'e ekleme
            serialPort1.DataReceived += new SerialDataReceivedEventHandler(serialPort1_DataReceived); //DataReceived eventini oluşturma
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = comboBox1.Text;       //Port ismini comboBox1'in text'i olarak belirle
                serialPort1.Open();                          //Seri portu aç
                button2.Enabled = true;                          //"Kes" butonunu tıklanabilir yap
                button1.Enabled = false;                      //"Bağlan" butonunu tıklanamaz yap
                label2.Text = "Bağlantı sağlandı";
                label2.ForeColor = Color.Green;              //Label3 yazı rengini yeşil yap
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata");  //Hata mesajı
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Close();              //Seri portu kapa
                button2.Enabled = false;              //"Kes" butonunu tıklanamaz yap
                button1.Enabled = true;            //"BağlanKes" butonunu tıklanabilir yap
                label2.Text = "Bağlantı kesildi";
                label2.ForeColor = Color.Red;     //Label3 yazı rengini kırmızı yap
            }
            catch (Exception ex2)
            {
                MessageBox.Show(ex2.Message); //Hata mesajı
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (serialPort1.IsOpen) serialPort1.Close();    //Seri port açıksa kapat
        }
    }
    }

