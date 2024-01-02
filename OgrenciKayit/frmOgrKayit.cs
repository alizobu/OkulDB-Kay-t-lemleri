
using OkulApp.MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OkulApp.BLL;

namespace OkulAppSube1BIL
{
    public partial class frmOgrKayit : Form
    {
        public int Ogrenciid { get; set; }
        public bool a { get; set; }
        public frmOgrKayit()
        {
            InitializeComponent();
            a = false;
            ogrguncelle.Enabled = false;
            ogrsil.Enabled = false;
        }
        public void EnableButtons(bool enable)
        {
            ogrguncelle.Enabled = enable;
            ogrsil.Enabled = enable;
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {

            try
            {
                var obl = new OgrenciBL();
                bool sonuc = obl.OgrenciEkle(new Ogrenci { Ad = txtAd.Text.Trim(), Soyad = txtSoyad.Text.Trim(), Numara = txtNumara.Text.Trim() });
                MessageBox.Show(sonuc ? "Ekleme Başarılı!" : "Ekleme Başarısız!!");
            }
            catch (SqlException ex)
            {
                switch (ex.Number)
                {
                    case 2627:
                        MessageBox.Show("Bu numaralı öğrenci daha önce kayıtlı");
                        break;
                    default:
                        MessageBox.Show("Veritabanı hatası");
                        break;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Bilinmeyen Hata!!");
            }
        }

        private void ogrencibul_Click(object sender, EventArgs e)
        {
            frmOgrBul frm = new frmOgrBul(this);
            frm.Show();
        }

        private void ogrguncelle_Click(object sender, EventArgs e)
        {

            try
            {
                var obl = new OgrenciBL();
                bool sonuc1 = obl.OgrenciGuncelle(new Ogrenci { Ad = txtAd.Text.Trim(), Soyad = txtSoyad.Text.Trim(), Numara = txtNumara.Text.Trim(), Ogrenciid = Ogrenciid });
                MessageBox.Show(sonuc1 ? "Güncelleme Başarılı!" : "Güncelleme Başarısız!!");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Veritabanı hatası: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bilinmeyen Hata: " + ex.Message);
            }
        }

        private void ogrsil_Click(object sender, EventArgs e)
        {
            try
            {
                var obl = new OgrenciBL();
                bool sonuc2 = obl.OgrenciSil(Ogrenciid);
                MessageBox.Show(sonuc2 ? "Silme Başarılı!" : "Silme Başarısız!!");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Veritabanı hatası: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bilinmeyen Hata: " + ex.Message);
            }
        }
    }
}



