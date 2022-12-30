
namespace Stok_takip_otomasyonu
{
    partial class Ş
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTelefon = new System.Windows.Forms.Label();
            this.txtAdSoyad = new System.Windows.Forms.Label();
            this.txtTC = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtToplamFiyat = new System.Windows.Forms.Label();
            this.txtSatisFiyati = new System.Windows.Forms.Label();
            this.txtMiktar = new System.Windows.Forms.Label();
            this.txtBarkodNo = new System.Windows.Forms.Label();
            this.txtUrunAdi = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnSatisİptal = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSatisYap = new System.Windows.Forms.Button();
            this.lblGenelToplam = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSatislariListeleme = new System.Windows.Forms.Button();
            this.btnUrunListeleme = new System.Windows.Forms.Button();
            this.btnUrunEkleme = new System.Windows.Forms.Button();
            this.btnMusteriListeleme = new System.Windows.Forms.Button();
            this.btnMusteriEkleme = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(303, 159);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(525, 292);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTelefon);
            this.groupBox1.Controls.Add(this.txtAdSoyad);
            this.groupBox1.Controls.Add(this.txtTC);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 136);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 146);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri İşlemleri";
            this.groupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // txtTelefon
            // 
            this.txtTelefon.AutoSize = true;
            this.txtTelefon.Location = new System.Drawing.Point(7, 88);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(43, 13);
            this.txtTelefon.TabIndex = 5;
            this.txtTelefon.Text = "Telefon";
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.AutoSize = true;
            this.txtAdSoyad.Location = new System.Drawing.Point(7, 52);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(53, 13);
            this.txtAdSoyad.TabIndex = 4;
            this.txtAdSoyad.Text = "Ad Soyad";
            // 
            // txtTC
            // 
            this.txtTC.AutoSize = true;
            this.txtTC.Location = new System.Drawing.Point(7, 25);
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(21, 13);
            this.txtTC.TabIndex = 3;
            this.txtTC.Text = "TC";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(129, 81);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(129, 45);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(129, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker1_DoWork);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtToplamFiyat);
            this.groupBox2.Controls.Add(this.txtSatisFiyati);
            this.groupBox2.Controls.Add(this.txtMiktar);
            this.groupBox2.Controls.Add(this.txtBarkodNo);
            this.groupBox2.Controls.Add(this.txtUrunAdi);
            this.groupBox2.Controls.Add(this.textBox8);
            this.groupBox2.Controls.Add(this.textBox7);
            this.groupBox2.Controls.Add(this.textBox6);
            this.groupBox2.Controls.Add(this.textBox5);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Location = new System.Drawing.Point(13, 292);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(273, 159);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ürün İşlemleri";
            this.groupBox2.Enter += new System.EventHandler(this.GroupBox2_Enter);
            // 
            // txtToplamFiyat
            // 
            this.txtToplamFiyat.AutoSize = true;
            this.txtToplamFiyat.Location = new System.Drawing.Point(8, 126);
            this.txtToplamFiyat.Name = "txtToplamFiyat";
            this.txtToplamFiyat.Size = new System.Drawing.Size(67, 13);
            this.txtToplamFiyat.TabIndex = 10;
            this.txtToplamFiyat.Text = "Toplam Fiyat";
            // 
            // txtSatisFiyati
            // 
            this.txtSatisFiyati.AutoSize = true;
            this.txtSatisFiyati.Location = new System.Drawing.Point(8, 104);
            this.txtSatisFiyati.Name = "txtSatisFiyati";
            this.txtSatisFiyati.Size = new System.Drawing.Size(57, 13);
            this.txtSatisFiyati.TabIndex = 9;
            this.txtSatisFiyati.Text = "Satış Fiyatı";
            // 
            // txtMiktar
            // 
            this.txtMiktar.AutoSize = true;
            this.txtMiktar.Location = new System.Drawing.Point(8, 78);
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(36, 13);
            this.txtMiktar.TabIndex = 8;
            this.txtMiktar.Text = "Miktar";
            // 
            // txtBarkodNo
            // 
            this.txtBarkodNo.AutoSize = true;
            this.txtBarkodNo.Location = new System.Drawing.Point(6, 26);
            this.txtBarkodNo.Name = "txtBarkodNo";
            this.txtBarkodNo.Size = new System.Drawing.Size(58, 13);
            this.txtBarkodNo.TabIndex = 7;
            this.txtBarkodNo.Text = "Barkod No";
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.AutoSize = true;
            this.txtUrunAdi.Location = new System.Drawing.Point(6, 52);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(48, 13);
            this.txtUrunAdi.TabIndex = 6;
            this.txtUrunAdi.Text = "Ürün Adı";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(130, 123);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 20);
            this.textBox8.TabIndex = 5;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(130, 97);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 4;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(130, 71);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 3;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(130, 45);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 2;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(130, 19);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 1;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(853, 161);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 3;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            // 
            // btnSatisİptal
            // 
            this.btnSatisİptal.Location = new System.Drawing.Point(853, 224);
            this.btnSatisİptal.Name = "btnSatisİptal";
            this.btnSatisİptal.Size = new System.Drawing.Size(75, 23);
            this.btnSatisİptal.TabIndex = 4;
            this.btnSatisİptal.Text = "Satış İptal";
            this.btnSatisİptal.UseVisualStyleBackColor = true;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(303, 460);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 5;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            // 
            // btnSatisYap
            // 
            this.btnSatisYap.Location = new System.Drawing.Point(753, 460);
            this.btnSatisYap.Name = "btnSatisYap";
            this.btnSatisYap.Size = new System.Drawing.Size(75, 23);
            this.btnSatisYap.TabIndex = 6;
            this.btnSatisYap.Text = "Satış Yap";
            this.btnSatisYap.UseVisualStyleBackColor = true;
            // 
            // lblGenelToplam
            // 
            this.lblGenelToplam.AutoSize = true;
            this.lblGenelToplam.Location = new System.Drawing.Point(513, 460);
            this.lblGenelToplam.Name = "lblGenelToplam";
            this.lblGenelToplam.Size = new System.Drawing.Size(73, 13);
            this.lblGenelToplam.TabIndex = 7;
            this.lblGenelToplam.Text = "Genel Toplam";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnSatislariListeleme);
            this.panel1.Controls.Add(this.btnUrunListeleme);
            this.panel1.Controls.Add(this.btnUrunEkleme);
            this.panel1.Controls.Add(this.btnMusteriListeleme);
            this.panel1.Controls.Add(this.btnMusteriEkleme);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(957, 100);
            this.panel1.TabIndex = 8;
            // 
            // btnSatislariListeleme
            // 
            this.btnSatislariListeleme.Location = new System.Drawing.Point(592, 23);
            this.btnSatislariListeleme.Name = "btnSatislariListeleme";
            this.btnSatislariListeleme.Size = new System.Drawing.Size(87, 43);
            this.btnSatislariListeleme.TabIndex = 4;
            this.btnSatislariListeleme.Text = "Satışları Listelme";
            this.btnSatislariListeleme.UseVisualStyleBackColor = true;
            // 
            // btnUrunListeleme
            // 
            this.btnUrunListeleme.Location = new System.Drawing.Point(444, 23);
            this.btnUrunListeleme.Name = "btnUrunListeleme";
            this.btnUrunListeleme.Size = new System.Drawing.Size(97, 43);
            this.btnUrunListeleme.TabIndex = 3;
            this.btnUrunListeleme.Text = "Ürün Listeleme";
            this.btnUrunListeleme.UseVisualStyleBackColor = true;
            // 
            // btnUrunEkleme
            // 
            this.btnUrunEkleme.Location = new System.Drawing.Point(303, 23);
            this.btnUrunEkleme.Name = "btnUrunEkleme";
            this.btnUrunEkleme.Size = new System.Drawing.Size(86, 43);
            this.btnUrunEkleme.TabIndex = 2;
            this.btnUrunEkleme.Text = "Ürün Ekleme";
            this.btnUrunEkleme.UseVisualStyleBackColor = true;
            this.btnUrunEkleme.Click += new System.EventHandler(this.btnUrunEkleme_Click);
            // 
            // btnMusteriListeleme
            // 
            this.btnMusteriListeleme.Location = new System.Drawing.Point(143, 23);
            this.btnMusteriListeleme.Name = "btnMusteriListeleme";
            this.btnMusteriListeleme.Size = new System.Drawing.Size(87, 43);
            this.btnMusteriListeleme.TabIndex = 1;
            this.btnMusteriListeleme.Text = "Müşteri Listeleme";
            this.btnMusteriListeleme.UseVisualStyleBackColor = true;
            this.btnMusteriListeleme.Click += new System.EventHandler(this.BtnMusteriListeleme_Click);
            // 
            // btnMusteriEkleme
            // 
            this.btnMusteriEkleme.Location = new System.Drawing.Point(24, 23);
            this.btnMusteriEkleme.Name = "btnMusteriEkleme";
            this.btnMusteriEkleme.Size = new System.Drawing.Size(92, 43);
            this.btnMusteriEkleme.TabIndex = 0;
            this.btnMusteriEkleme.Text = "Müşteri Ekleme";
            this.btnMusteriEkleme.UseVisualStyleBackColor = true;
            this.btnMusteriEkleme.Click += new System.EventHandler(this.BtnMusteriEkleme_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(729, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 43);
            this.button1.TabIndex = 5;
            this.button1.Text = "Kategori";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(842, 23);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 43);
            this.button2.TabIndex = 6;
            this.button2.Text = "Marka";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Ş
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 540);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblGenelToplam);
            this.Controls.Add(this.btnSatisYap);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnSatisİptal);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Ş";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Satis Sayfasi";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label txtTelefon;
        private System.Windows.Forms.Label txtAdSoyad;
        private System.Windows.Forms.Label txtTC;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label txtToplamFiyat;
        private System.Windows.Forms.Label txtSatisFiyati;
        private System.Windows.Forms.Label txtMiktar;
        private System.Windows.Forms.Label txtBarkodNo;
        private System.Windows.Forms.Label txtUrunAdi;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnSatisİptal;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSatisYap;
        private System.Windows.Forms.Label lblGenelToplam;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSatislariListeleme;
        private System.Windows.Forms.Button btnUrunListeleme;
        private System.Windows.Forms.Button btnUrunEkleme;
        private System.Windows.Forms.Button btnMusteriListeleme;
        private System.Windows.Forms.Button btnMusteriEkleme;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

