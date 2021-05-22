using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1_CafeOrderProgram
{
    public partial class CafeOrderScreenForm : Form
    {
        public CafeOrderScreenForm()
        {
            InitializeComponent();
        }
        private int _total_fiyat;
        private int cay_sayisi=0;
        private int kahve_sayisi=0;
        private int oralet_sayisi=0;
        private int limonata_sayisi=0;


        private void cay_sayisi_arttir_button_Click(object sender, EventArgs e)
        {
            cay_sayisi++;
            cay_sayisi_label.Text = Convert.ToString(cay_sayisi);
            _total_fiyat += Convert.ToInt32(cay_fiyat_label.Text);
            total_fiyat_label.Text = Convert.ToString(_total_fiyat)+" TL";
        }

        private void cay_sayisi_azalt_button_Click(object sender, EventArgs e)
        {  
            if (cay_sayisi > 0)
            {
                cay_sayisi--;
                cay_sayisi_label.Text = Convert.ToString(cay_sayisi);
                _total_fiyat -= Convert.ToInt32(cay_fiyat_label.Text);
                total_fiyat_label.Text = Convert.ToString(_total_fiyat) + " TL";
            }
            
        }

        private void cay_fiyat_label_Click(object sender, EventArgs e)
        {

        }

        private void kahve_sayisi_arttir_button_Click(object sender, EventArgs e)
        {
            kahve_sayisi++;
            kahve_sayisi_label.Text = Convert.ToString(kahve_sayisi);
            _total_fiyat += Convert.ToInt32(kahve_fiyat_label.Text);
            total_fiyat_label.Text = Convert.ToString(_total_fiyat) + " TL";
        }

        private void kahve_sayisi_azalt_button_Click(object sender, EventArgs e)
        {
            if (kahve_sayisi > 0)
            {
                kahve_sayisi--;
                kahve_sayisi_label.Text = Convert.ToString(kahve_sayisi);
                _total_fiyat -= Convert.ToInt32(kahve_fiyat_label.Text);
                total_fiyat_label.Text = Convert.ToString(_total_fiyat) + " TL";
            }
        }

        private void limonata_sayisi_arttir_button_Click(object sender, EventArgs e)
        {
            limonata_sayisi++;
            limonata_sayisi_label.Text = Convert.ToString(limonata_sayisi);
            _total_fiyat += Convert.ToInt32(limonata_fiyat_label.Text);
            total_fiyat_label.Text = Convert.ToString(_total_fiyat) + " TL";
        }

        private void limonata_sayisi_azalt_button_Click(object sender, EventArgs e)
        {
            if (limonata_sayisi > 0)
            {
                limonata_sayisi--;
                limonata_sayisi_label.Text = Convert.ToString(limonata_sayisi);
                _total_fiyat -= Convert.ToInt32(limonata_fiyat_label.Text);
                total_fiyat_label.Text = Convert.ToString(_total_fiyat) + " TL";
            }
        }

        private void oralet_sayisi_arttir_button_Click(object sender, EventArgs e)
        {
            oralet_sayisi++;
            oralet_sayisi_label.Text = Convert.ToString(oralet_sayisi);
            _total_fiyat += Convert.ToInt32(oralet_fiyat_label.Text);
            total_fiyat_label.Text = Convert.ToString(_total_fiyat) + " TL";
        }

        private void oralet_sayisi_azalt_button_Click(object sender, EventArgs e)
        {
            if (oralet_sayisi > 0)
            {
                oralet_sayisi--;
                oralet_sayisi_label.Text = Convert.ToString(oralet_sayisi);
                _total_fiyat -= Convert.ToInt32(oralet_fiyat_label.Text);
                total_fiyat_label.Text = Convert.ToString(_total_fiyat) + " TL";
            }
        }

        private void siparis_sifirla_button_Click(object sender, EventArgs e)
        {
            cay_sayisi_label.Text = "0";
            kahve_sayisi_label.Text = "0";
            oralet_sayisi_label.Text = "0";
            limonata_sayisi_label.Text = "0";
            cay_sayisi = 0;
            kahve_sayisi = 0;
            oralet_sayisi = 0;
            limonata_sayisi = 0;
        _total_fiyat = 0;
            total_fiyat_label.Text = Convert.ToString(_total_fiyat) + " TL";
        }

        private void siparis_onayla_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("SİPARİŞ ÖZETİ: \n"+cay_sayisi_label.Text+" ÇAY\n"+ kahve_sayisi_label.Text+ " KAHVE\n"
            + limonata_sayisi_label.Text+ " LİMONATA\n"+ oralet_sayisi_label.Text+" ORALET\nTOPLAM TUTAR : "+total_fiyat_label.Text);
        }

        private void cikis_button_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
