using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OkulApp.MODEL;
using OkulAppOgretmen.BLL;
namespace OgretmenKayitt
{
    public partial class frmOgretmenBul : Form
    {
        frmOgrtmnKayit frm;
        public frmOgretmenBul(frmOgrtmnKayit frm)
        {
            InitializeComponent();
            this.frm = frm;
        }
        public bool a = false;
        private void ogretmenbulbtn_Click(object sender, EventArgs e)
        {

            try
            {
                var obl = new OgretmenBL();
                Ogrenci ogr = obl.OgretmenBul(ogretmenbultext.Text.Trim());
                if (ogr != null)
                {
                    frm.adtext.Text = ogr.Ad2;
                    frm.soyadtext.Text = ogr.Soyad2;
                    frm.tctext.Text = ogr.TC;
                    frm.Ogretmenid = ogr.Ogretmenid;
                    MessageBox.Show("Öğretmen Bulundu");
                    frm.a = true;
                }
                else
                {
                    MessageBox.Show("Öğretmen bulunamadı!");
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
