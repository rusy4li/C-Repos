using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rs4_Dork_Maker
{
    public partial class Form : System.Windows.Forms.Form
    {
        bool onayla_girildi;
        public Form()
        {
            InitializeComponent();
        }

        private void onayla_button_Click(object sender, EventArgs e)
        {
            if (onayla_girildi)
            {
                dork_goster_label.Text += "\n--------------\n";
            }
            // Textboxları değişkenlere atıyoruz
            string site_alan_adi = site_alan_adi_textbox.Text.Trim().ToLower();
            string kelime = kelime_textbox.Text.Trim().ToLower();
            string site_kategori = site_kategori_textbox.Text.Trim().ToLower();
            string site_bölüm = site_bölümü_textbox.Text.Trim().ToLower();
            string dosya_tipi = dosya_tipi_textbox.Text.Trim().ToLower();
            // 

            // Kullanacağımız değişkenleri oluşturduk
            string intitle;
            string inurl;
            string site;
            string related;
            string cache;
            string link;
            string filetype;
            // 

            // Şimdi uygulama zamanı
            intitle = (kelime + " intitle:" + site_kategori);
            inurl = ("inurl:" + site_bölüm + ".php?");
            site = (kelime + " site:" + site_alan_adi);
            related = ("related:" + site_alan_adi);
            cache = ("cache:" + site_alan_adi);
            link = ("link:" + site_alan_adi);
            filetype = (kelime + " filetype:" + dosya_tipi);
            // 

            // Dork Gorunum kutucuğuna yazdırma sırası
            if (site_alan_adi == "" && kelime == "" && site_kategori == "" && site_bölüm == "" && dosya_tipi == "")
            {
                MessageBox.Show("En az bir kutucuğu doldurmanız gerekmektedir!", "Uyarı!");
            }
            else
            {
                if (kelime != "" && site_kategori != "")
                {
                    dork_goster_label.Text += intitle;
                    dork_goster_label.Text += "\n";
                }
                if (site_bölüm != "")
                {
                    dork_goster_label.Text += inurl;
                    dork_goster_label.Text += "\n";
                }
                if (kelime != "" && site_alan_adi != "")
                {
                    dork_goster_label.Text += site;
                    dork_goster_label.Text += "\n";
                }
                if (site_alan_adi != "")
                {
                    dork_goster_label.Text += related;
                    dork_goster_label.Text += "\n";
                    dork_goster_label.Text += cache;
                    dork_goster_label.Text += "\n";
                    dork_goster_label.Text += link;
                    dork_goster_label.Text += "\n";
                }
                if (kelime != "" && dosya_tipi != "")
                {
                    dork_goster_label.Text += filetype;
                }
                onayla_girildi = true;

                // Kutucukları boşaltalım
                site_alan_adi_textbox.Text = "";
                kelime_textbox.Text = "";
                site_kategori_textbox.Text = "";
                site_bölümü_textbox.Text = "";
                dosya_tipi_textbox.Text = "";
                //
            }
            // 
        }

        private void kopyala_button_Click(object sender, EventArgs e)
        {
            if (dork_goster_label.Text != "") 
            {
                Clipboard.SetText(dork_goster_label.Text);
                MessageBox.Show("Bütün Dorklar Kopyalandı", "Uyarı!");
            }    
            else 
            {
                MessageBox.Show("Kopyalanacak Dork Bulunamadı!", "Uyarı!");
            }
        }

        private void site_alan_adi_uyari_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Bu boşluğa oluşturacağınız dork için alan adı giriniz lütfen!\nÖrnek: elitehackz.org,rusygame.com", "Uyarı!");
        }

        private void kelime_uyari_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Bu boşluğa oluşturacağınız dork için kelime giriniz lütfen!\nÖrnek: hack,oyun", "Uyarı!");
        }

        private void site_kategorisi_uyari_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Bu boşluğa oluşturacağınız dork için site kategorisi giriniz lütfen!\nÖrnek: blog,forum", "Uyarı!");
        }

        private void site_bölümü_uyari_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Bu boşluğa oluşturacağınız dork için site bölümü giriniz lütfen!\nÖrnek: index,anasayfa", "Uyarı!");
        }

        private void dosya_tipi_uyari_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Bu boşluğa oluşturacağınız dork için dosya uzantısı giriniz lütfen!\nÖrnek: jpeg,png", "Uyarı!");
        }

        private void temizle_button_Click(object sender, EventArgs e)
        {
            onayla_girildi = false;
            dork_goster_label.Text = "";
        }
    }
}

