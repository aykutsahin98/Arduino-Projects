namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.kirmizi_click = new System.Windows.Forms.Button();
            this.yesil_click = new System.Windows.Forms.Button();
            this.mavi_click = new System.Windows.Forms.Button();
            this.mor_click = new System.Windows.Forms.Button();
            this.sari_click = new System.Windows.Forms.Button();
            this.magenta = new System.Windows.Forms.Button();
            this.cyan = new System.Windows.Forms.Button();
            this.beyaz = new System.Windows.Forms.Button();
            this.turuncu = new System.Windows.Forms.Button();
            this.pembe = new System.Windows.Forms.Button();
            this.kahverengi = new System.Windows.Forms.Button();
            this.yesil2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.R = new System.Windows.Forms.TrackBar();
            this.G = new System.Windows.Forms.TrackBar();
            this.B = new System.Windows.Forms.TrackBar();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.R)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.G)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.B)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 73);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(114, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(132, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 37);
            this.button1.TabIndex = 1;
            this.button1.Text = "Bağlan";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // kirmizi_click
            // 
            this.kirmizi_click.BackColor = System.Drawing.Color.Red;
            this.kirmizi_click.Location = new System.Drawing.Point(20, 16);
            this.kirmizi_click.Name = "kirmizi_click";
            this.kirmizi_click.Size = new System.Drawing.Size(44, 35);
            this.kirmizi_click.TabIndex = 2;
            this.kirmizi_click.UseVisualStyleBackColor = false;
            this.kirmizi_click.Click += new System.EventHandler(this.kirmizi_click_Click);
            // 
            // yesil_click
            // 
            this.yesil_click.BackColor = System.Drawing.Color.Lime;
            this.yesil_click.Location = new System.Drawing.Point(70, 16);
            this.yesil_click.Name = "yesil_click";
            this.yesil_click.Size = new System.Drawing.Size(44, 35);
            this.yesil_click.TabIndex = 3;
            this.yesil_click.UseVisualStyleBackColor = false;
            this.yesil_click.Click += new System.EventHandler(this.yesil_click_Click);
            // 
            // mavi_click
            // 
            this.mavi_click.BackColor = System.Drawing.Color.Blue;
            this.mavi_click.Location = new System.Drawing.Point(120, 16);
            this.mavi_click.Name = "mavi_click";
            this.mavi_click.Size = new System.Drawing.Size(44, 35);
            this.mavi_click.TabIndex = 4;
            this.mavi_click.UseVisualStyleBackColor = false;
            this.mavi_click.Click += new System.EventHandler(this.mavi_click_Click);
            // 
            // mor_click
            // 
            this.mor_click.BackColor = System.Drawing.Color.Purple;
            this.mor_click.Location = new System.Drawing.Point(170, 16);
            this.mor_click.Name = "mor_click";
            this.mor_click.Size = new System.Drawing.Size(44, 35);
            this.mor_click.TabIndex = 5;
            this.mor_click.UseVisualStyleBackColor = false;
            this.mor_click.Click += new System.EventHandler(this.mor_click_Click);
            // 
            // sari_click
            // 
            this.sari_click.BackColor = System.Drawing.Color.Yellow;
            this.sari_click.Location = new System.Drawing.Point(20, 57);
            this.sari_click.Name = "sari_click";
            this.sari_click.Size = new System.Drawing.Size(44, 35);
            this.sari_click.TabIndex = 6;
            this.sari_click.UseVisualStyleBackColor = false;
            this.sari_click.Click += new System.EventHandler(this.sari_click_Click);
            // 
            // magenta
            // 
            this.magenta.BackColor = System.Drawing.Color.Magenta;
            this.magenta.Location = new System.Drawing.Point(70, 57);
            this.magenta.Name = "magenta";
            this.magenta.Size = new System.Drawing.Size(44, 35);
            this.magenta.TabIndex = 7;
            this.magenta.UseVisualStyleBackColor = false;
            this.magenta.Click += new System.EventHandler(this.magenta_Click);
            // 
            // cyan
            // 
            this.cyan.BackColor = System.Drawing.Color.Cyan;
            this.cyan.Location = new System.Drawing.Point(120, 57);
            this.cyan.Name = "cyan";
            this.cyan.Size = new System.Drawing.Size(44, 35);
            this.cyan.TabIndex = 8;
            this.cyan.UseVisualStyleBackColor = false;
            this.cyan.Click += new System.EventHandler(this.cyan_Click);
            // 
            // beyaz
            // 
            this.beyaz.BackColor = System.Drawing.Color.White;
            this.beyaz.Location = new System.Drawing.Point(170, 57);
            this.beyaz.Name = "beyaz";
            this.beyaz.Size = new System.Drawing.Size(44, 35);
            this.beyaz.TabIndex = 9;
            this.beyaz.UseVisualStyleBackColor = false;
            this.beyaz.Click += new System.EventHandler(this.beyaz_Click);
            // 
            // turuncu
            // 
            this.turuncu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.turuncu.Location = new System.Drawing.Point(20, 98);
            this.turuncu.Name = "turuncu";
            this.turuncu.Size = new System.Drawing.Size(44, 35);
            this.turuncu.TabIndex = 10;
            this.turuncu.UseVisualStyleBackColor = false;
            this.turuncu.Click += new System.EventHandler(this.turuncu_Click);
            // 
            // pembe
            // 
            this.pembe.BackColor = System.Drawing.Color.Pink;
            this.pembe.Location = new System.Drawing.Point(70, 98);
            this.pembe.Name = "pembe";
            this.pembe.Size = new System.Drawing.Size(44, 35);
            this.pembe.TabIndex = 11;
            this.pembe.UseVisualStyleBackColor = false;
            this.pembe.Click += new System.EventHandler(this.pembe_Click);
            // 
            // kahverengi
            // 
            this.kahverengi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.kahverengi.Location = new System.Drawing.Point(120, 98);
            this.kahverengi.Name = "kahverengi";
            this.kahverengi.Size = new System.Drawing.Size(44, 35);
            this.kahverengi.TabIndex = 12;
            this.kahverengi.UseVisualStyleBackColor = false;
            this.kahverengi.Click += new System.EventHandler(this.kahverengi_Click);
            // 
            // yesil2
            // 
            this.yesil2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.yesil2.Location = new System.Drawing.Point(170, 98);
            this.yesil2.Name = "yesil2";
            this.yesil2.Size = new System.Drawing.Size(44, 35);
            this.yesil2.TabIndex = 13;
            this.yesil2.UseVisualStyleBackColor = false;
            this.yesil2.Click += new System.EventHandler(this.yesil2_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.kirmizi_click);
            this.panel1.Controls.Add(this.yesil2);
            this.panel1.Controls.Add(this.yesil_click);
            this.panel1.Controls.Add(this.kahverengi);
            this.panel1.Controls.Add(this.mavi_click);
            this.panel1.Controls.Add(this.pembe);
            this.panel1.Controls.Add(this.mor_click);
            this.panel1.Controls.Add(this.turuncu);
            this.panel1.Controls.Add(this.sari_click);
            this.panel1.Controls.Add(this.beyaz);
            this.panel1.Controls.Add(this.magenta);
            this.panel1.Controls.Add(this.cyan);
            this.panel1.Location = new System.Drawing.Point(12, 129);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(234, 200);
            this.panel1.TabIndex = 14;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(40, 148);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 37);
            this.button2.TabIndex = 14;
            this.button2.Text = "Renk Paleti";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(108, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(313, 42);
            this.label2.TabIndex = 15;
            this.label2.Text = "RGB COLOR LAMBA ";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Location = new System.Drawing.Point(277, 129);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(212, 200);
            this.panel2.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(28, 368);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 26);
            this.label4.TabIndex = 18;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(178, 368);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 26);
            this.label5.TabIndex = 20;
            this.label5.Text = "label5";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(328, 368);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 26);
            this.label7.TabIndex = 22;
            this.label7.Text = "label7";
            // 
            // R
            // 
            this.R.Location = new System.Drawing.Point(17, 407);
            this.R.Maximum = 255;
            this.R.Name = "R";
            this.R.Size = new System.Drawing.Size(149, 45);
            this.R.TabIndex = 23;
            this.R.Scroll += new System.EventHandler(this.R_Scroll);
            // 
            // G
            // 
            this.G.Location = new System.Drawing.Point(172, 407);
            this.G.Maximum = 255;
            this.G.Name = "G";
            this.G.Size = new System.Drawing.Size(146, 45);
            this.G.TabIndex = 24;
            this.G.Scroll += new System.EventHandler(this.G_Scroll);
            // 
            // B
            // 
            this.B.Location = new System.Drawing.Point(324, 407);
            this.B.Maximum = 255;
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(147, 45);
            this.B.TabIndex = 25;
            this.B.Scroll += new System.EventHandler(this.B_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 464);
            this.Controls.Add(this.B);
            this.Controls.Add(this.G);
            this.Controls.Add(this.R);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.R)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.G)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.B)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button kirmizi_click;
        private System.Windows.Forms.Button yesil_click;
        private System.Windows.Forms.Button mavi_click;
        private System.Windows.Forms.Button mor_click;
        private System.Windows.Forms.Button sari_click;
        private System.Windows.Forms.Button magenta;
        private System.Windows.Forms.Button cyan;
        private System.Windows.Forms.Button beyaz;
        private System.Windows.Forms.Button turuncu;
        private System.Windows.Forms.Button pembe;
        private System.Windows.Forms.Button kahverengi;
        private System.Windows.Forms.Button yesil2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TrackBar R;
        private System.Windows.Forms.TrackBar G;
        private System.Windows.Forms.TrackBar B;
        private System.Windows.Forms.Button button2;
    }
}

