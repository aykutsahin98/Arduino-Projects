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

namespace Led_Kontrol_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        
        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();  //Seri portları diziye ekleme
            foreach (string port in ports)
                comboBox1.Items.Add(port); //Seri portları comBox1' ekleme
        }
        SerialPort sb1 = new SerialPort();
        private void button1_Click(object sender, EventArgs e)
        {
            sb1.Write("1");    //Seri porta "1" gönder    
            label1.Text = "Led Açık";  //Label1'e "Led Açık" yaz
            button2.Enabled = true;    //Button2'yi tıklanabilir hale getir
            button1.Enabled = false;   //Button1'i tıklanamaz hale getir
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sb1.Write("0");    //Seri porta "0" gönder    
            label1.Text = "Led Kapalı";  //Label1'e "Led Kapalı" yaz
            button1.Enabled = true;    //Button2'yi tıklanabilir hale getir
            button2.Enabled = true;   //Button1'i tıklanamaz hale getir
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            sb1.PortName = comboBox1.SelectedItem.ToString();
            sb1.Open(); //seri portu aç
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (sb1.IsOpen) sb1.Close();
        }
    }
}
