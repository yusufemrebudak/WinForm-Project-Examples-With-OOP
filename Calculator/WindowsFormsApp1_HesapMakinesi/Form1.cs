using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1_HesapMakinesi
{
    public partial class Form1 : Form
    {
        private char _islem;
        private bool _ekran_temizlenecek_mi;
        private int _ilk_sayi;



        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (_ekran_temizlenecek_mi)
            {
                ekran_label.Text = "";
                _ekran_temizlenecek_mi = false;
            }
            if (ekran_label.Text == "0") ekran_label.Text = "";
            ekran_label.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (_ekran_temizlenecek_mi)
            {
                ekran_label.Text = "";
                _ekran_temizlenecek_mi = false;
            }
            if (ekran_label.Text == "0") ekran_label.Text = "";
            ekran_label.Text += "3";
        }

        private void rakam1_button_Click(object sender, EventArgs e)
        {
            if (_ekran_temizlenecek_mi)
            {
                ekran_label.Text = "";
                _ekran_temizlenecek_mi = false;
            }
            if (ekran_label.Text == "0") ekran_label.Text = "";
            ekran_label.Text += "1";
        }

        private void rakam4_button_Click(object sender, EventArgs e)
        {
            if (_ekran_temizlenecek_mi)
            {
                ekran_label.Text = "";
                _ekran_temizlenecek_mi = false;
            }
            if (ekran_label.Text == "0") ekran_label.Text = "";
            ekran_label.Text += "4";
        }

        private void rakam5_button_Click(object sender, EventArgs e)
        {
            if (_ekran_temizlenecek_mi)
            {
                ekran_label.Text = "";
                _ekran_temizlenecek_mi = false;
            }
            if (ekran_label.Text == "0") ekran_label.Text = "";
            ekran_label.Text += "5";
        }

        private void rakam6_button_Click(object sender, EventArgs e)
        {
            if (_ekran_temizlenecek_mi)
            {
                ekran_label.Text = "";
                _ekran_temizlenecek_mi = false;
            }
            if (ekran_label.Text == "0") ekran_label.Text = "";
            ekran_label.Text += "6";
        }

        private void rakam7_button_Click(object sender, EventArgs e)
        {
            if (_ekran_temizlenecek_mi)
            {
                ekran_label.Text = "";
                _ekran_temizlenecek_mi = false;
            }
            if (ekran_label.Text == "0") ekran_label.Text = "";
            ekran_label.Text += "7";
        }

        private void rakam8_button_Click(object sender, EventArgs e)
        {
            if (_ekran_temizlenecek_mi)
            {
                ekran_label.Text = "";
                _ekran_temizlenecek_mi = false;
            }
            if (ekran_label.Text == "0") ekran_label.Text = "";
            ekran_label.Text += "8";
        }

        private void rakam9_button_Click(object sender, EventArgs e)
        {
            if (_ekran_temizlenecek_mi)
            {
                ekran_label.Text = "";
                _ekran_temizlenecek_mi = false;
            }
            if (ekran_label.Text == "0") ekran_label.Text = "";
            ekran_label.Text += "9";
        }

        private void rakam0_button_Click(object sender, EventArgs e)
        {
            if (_ekran_temizlenecek_mi)
            {
                ekran_label.Text = "";
                _ekran_temizlenecek_mi = false;
            }
            if (ekran_label.Text == "0") ekran_label.Text = "";
            ekran_label.Text += "0";
        }

        private void arti_button_Click(object sender, EventArgs e)
        {
            _islem = '+';
            _ekran_temizlenecek_mi = true;
            _ilk_sayi = Convert.ToInt32(ekran_label.Text);
        }

        private void esittir_button_Click(object sender, EventArgs e)
        {
            int ikinci_sayi = Convert.ToInt32(ekran_label.Text);
            int sonuc;
            switch (_islem)
            {
                case '+':
                    sonuc = _ilk_sayi + ikinci_sayi; 
                    break;
                case '-':
                    sonuc = _ilk_sayi - ikinci_sayi;
                    break;
                case '*':
                    sonuc = _ilk_sayi * ikinci_sayi;
                    break;
                case '/':
                    sonuc = _ilk_sayi / ikinci_sayi;
                    break;
                default:
                    sonuc = 0;
                    break;
            }
            ekran_label.Text = Convert.ToString(sonuc);


        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            ekran_label.Text = "0";
        }

        private void eksi_button_Click(object sender, EventArgs e)
        {
            _islem = '-';
            _ekran_temizlenecek_mi = true;
            _ilk_sayi = Convert.ToInt32(ekran_label.Text);
        }

        private void carpi_button_Click(object sender, EventArgs e)
        {
            _islem = '*';
            _ekran_temizlenecek_mi = true;
            _ilk_sayi = Convert.ToInt32(ekran_label.Text);
        }

        private void bolme_button_Click(object sender, EventArgs e)
        {
            _islem = '/';
            _ekran_temizlenecek_mi = true;
            _ilk_sayi = Convert.ToInt32(ekran_label.Text);
        }

        private void tek_rakam_sil_button_Click(object sender, EventArgs e)
        {
            int gecici;
            gecici = Convert.ToInt32(ekran_label.Text);
            gecici = gecici / 10;
            ekran_label.Text = Convert.ToString(gecici);
        }
    }
}
