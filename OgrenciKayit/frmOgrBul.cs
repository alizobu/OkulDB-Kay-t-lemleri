using OkulApp.BLL;
using OkulApp.MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OkulAppSube1BIL
{
    public partial class frmOgrBul : Form
    {
        frmOgrKayit frm;
        public frmOgrBul(frmOgrKayit frm)
        {
            InitializeComponent();
            this.frm = frm;
        }
        public bool a = false;
        private void btnbul_Click(object sender, EventArgs e)
        {

            try
            {
                var obl = new OgrenciBL();
                Ogrenci ogr = obl.OgrenciBul(ogrbultext.Text.Trim());
                if (ogr != null)
                {
                    frm.txtAd.Text = ogr.Ad;
                    frm.txtSoyad.Text = ogr.Soyad;
                    frm.txtNumara.Text = ogr.Numara;
                    frm.Ogrenciid = ogr.Ogrenciid;
                    MessageBox.Show("Öğrenci Bulundu");
                    frm.a = true;
                }
                else
                {
                    MessageBox.Show("Öğrenci bulunamadı!");
                }

                frm.EnableButtons(frm.a);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
        }

    }
}
