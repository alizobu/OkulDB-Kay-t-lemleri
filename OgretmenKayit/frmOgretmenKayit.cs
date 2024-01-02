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
using OkulAppOgretmen.BLL;

namespace OgretmenKayitt
{
    public partial class frmOgrtmnKayit : Form
    {
        public int Ogretmenid { get; set; }
        public bool a { get; set; }
        public frmOgrtmnKayit()
        {
            InitializeComponent();
            a = false;
            guncellebtn.Enabled = false;
            silbtn.Enabled = false;
        }
        public void EnableButtons(bool enable)
        {
            guncellebtn.Enabled = enable;
            silbtn.Enabled = enable;
        }
        private void kaydetbtn_Click_1(object sender, EventArgs e)
        {

            try
            {
                var obl = new OgretmenBL();
                bool sonuc = obl.OgretmenEkle(new Ogrenci { Ad2 = adtext.Text.Trim(), Soyad2 = soyadtext.Text.Trim(), TC = tctext.Text.Trim() });
                MessageBox.Show(sonuc ? "Ekleme Başarılı!" : "Ekleme Başarısız!!");
            }
            catch (SqlException ex)
            {
                switch (ex.Number)
                {
                    case 2627:
                        MessageBox.Show("Bu numaralı öğretmen daha önce kayıtlı");
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

        private void bulbtn_Click_1(object sender, EventArgs e)
        {
            frmOgretmenBul frm = new frmOgretmenBul(this);
            frm.Show();
        }

        private void guncellebtn_Click_1(object sender, EventArgs e)
        {

            try
            {
                var obl = new OgretmenBL();
                bool sonuc1 = obl.OgretmenGuncelle(new Ogrenci { Ad2 = adtext.Text.Trim(), Soyad2 = soyadtext.Text.Trim(), TC = tctext.Text.Trim(), Ogretmenid = Ogretmenid });
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

        private void silbtn_Click_1(object sender, EventArgs e)
        {
            try
            {
                var obl = new OgretmenBL();
                bool sonuc2 = obl.OgretmenSil(Ogretmenid);
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


