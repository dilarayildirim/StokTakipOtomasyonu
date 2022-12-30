using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stok_takip_otomasyonu
{
    public partial class Ş : Form
    {
        public Ş()
        {
            InitializeComponent();
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void GroupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnMusteriEkleme_Click(object sender, EventArgs e)
        {
            FrmMusteriEkle ekle = new FrmMusteriEkle();
             ekle.ShowDialog();
        }

        private void BtnMusteriListeleme_Click(object sender, EventArgs e)
        {
            FrmMüşteriListele listele = new FrmMüşteriListele();
            listele.ShowDialog();


        }

        private void btnUrunEkleme_Click(object sender, EventArgs e)
        {
            frmÜrünEkle ekle = new frmÜrünEkle();
            ekle.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmKategori kategori = new frmKategori();
            kategori.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmMarka marka = new frmMarka();
            marka.ShowDialog();
        }
    }
}
