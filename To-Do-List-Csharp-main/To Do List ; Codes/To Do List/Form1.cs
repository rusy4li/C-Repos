using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace To_Do_List
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            // Şimdi program açılırken yüklenecek olan yazıları yapıyoruz


            // Öncelikle Dosya varmı yokmu kontrol ediyoruz
            string to_do1_dosya = "to_do1.txt";
            if (File.Exists(to_do1_dosya) == true)
            {
                // Dosya var ise dosyanın içindekileri okuyoruz
                string readText = File.ReadAllText(to_do1_dosya);
                // Dosyanın içinde yazı varmı diye kontrol ediyoruz
                if (readText.Trim() != null)
                {
                    // Dosyanın içinde yazanları textboxa yazıyoruz
                    text1.Text = readText.Trim();
                }
            }

            // Diğerlerinede aynısını yapıyoruz:

            // Öncelikle Dosya varmı yokmu kontrol ediyoruz
            string to_do2_dosya = "to_do2.txt";
            if (File.Exists(to_do2_dosya) == true)
            {
                // Dosya var ise dosyanın içindekileri okuyoruz
                string readText = File.ReadAllText(to_do2_dosya);
                // Dosyanın içinde yazı varmı diye kontrol ediyoruz
                if (readText.Trim() != null)
                {
                    // Dosyanın içinde yazanları textboxa yazıyoruz
                    text2.Text = readText.Trim();
                }
            }

            // Öncelikle Dosya varmı yokmu kontrol ediyoruz
            string to_do3_dosya = "to_do3.txt";
            if (File.Exists(to_do3_dosya) == true)
            {
                // Dosya var ise dosyanın içindekileri okuyoruz
                string readText = File.ReadAllText(to_do3_dosya);
                // Dosyanın içinde yazı varmı diye kontrol ediyoruz
                if (readText.Trim() != null)
                {
                    // Dosyanın içinde yazanları textboxa yazıyoruz
                    text3.Text = readText.Trim();
                }
            }

            // Öncelikle Dosya varmı yokmu kontrol ediyoruz
            string to_do4_dosya = "to_do4.txt";
            if (File.Exists(to_do4_dosya) == true)
            {
                // Dosya var ise dosyanın içindekileri okuyoruz
                string readText = File.ReadAllText(to_do4_dosya);
                // Dosyanın içinde yazı varmı diye kontrol ediyoruz
                if (readText.Trim() != null)
                {
                    // Dosyanın içinde yazanları textboxa yazıyoruz
                    text4.Text = readText.Trim();
                }
            }

            // Öncelikle Dosya varmı yokmu kontrol ediyoruz
            string to_do5_dosya = "to_do5.txt";
            if (File.Exists(to_do5_dosya) == true)
            {
                // Dosya var ise dosyanın içindekileri okuyoruz
                string readText = File.ReadAllText(to_do5_dosya);
                // Dosyanın içinde yazı varmı diye kontrol ediyoruz
                if (readText.Trim() != null)
                {
                    // Dosyanın içinde yazanları textboxa yazıyoruz
                    text5.Text = readText.Trim();
                }
            }


            // Öncelikle Dosya varmı yokmu kontrol ediyoruz
            string to_do6_dosya = "to_do6.txt";
            if (File.Exists(to_do6_dosya) == true)
            {
                // Dosya var ise dosyanın içindekileri okuyoruz
                string readText = File.ReadAllText(to_do6_dosya);
                // Dosyanın içinde yazı varmı diye kontrol ediyoruz
                if (readText.Trim() != null)
                {
                    // Dosyanın içinde yazanları textboxa yazıyoruz
                    text6.Text = readText.Trim();
                }
            }

            // Öncelikle Dosya varmı yokmu kontrol ediyoruz
            string to_do7_dosya = "to_do7.txt";
            if (File.Exists(to_do7_dosya) == true)
            {
                // Dosya var ise dosyanın içindekileri okuyoruz
                string readText = File.ReadAllText(to_do7_dosya);
                // Dosyanın içinde yazı varmı diye kontrol ediyoruz
                if (readText.Trim() != null)
                {
                    // Dosyanın içinde yazanları textboxa yazıyoruz
                    text7.Text = readText.Trim();
                }
            }

            // Öncelikle Dosya varmı yokmu kontrol ediyoruz
            string to_do8_dosya = "to_do8.txt";
            if (File.Exists(to_do8_dosya) == true)
            {
                // Dosya var ise dosyanın içindekileri okuyoruz
                string readText = File.ReadAllText(to_do8_dosya);
                // Dosyanın içinde yazı varmı diye kontrol ediyoruz
                if (readText.Trim() != null)
                {
                    // Dosyanın içinde yazanları textboxa yazıyoruz
                    text8.Text = readText.Trim();
                }
            }

            // Öncelikle Dosya varmı yokmu kontrol ediyoruz
            string to_do9_dosya = "to_do9.txt";
            if (File.Exists(to_do9_dosya) == true)
            {
                // Dosya var ise dosyanın içindekileri okuyoruz
                string readText = File.ReadAllText(to_do9_dosya);
                // Dosyanın içinde yazı varmı diye kontrol ediyoruz
                if (readText.Trim() != null)
                {
                    // Dosyanın içinde yazanları textboxa yazıyoruz
                    text9.Text = readText.Trim();
                }
            }

            // Öncelikle Dosya varmı yokmu kontrol ediyoruz
            string to_do10_dosya = "to_do10.txt";
            if (File.Exists(to_do10_dosya) == true)
            {
                // Dosya var ise dosyanın içindekileri okuyoruz
                string readText = File.ReadAllText(to_do10_dosya);
                // Dosyanın içinde yazı varmı diye kontrol ediyoruz
                if (readText.Trim() != null)
                {
                    // Dosyanın içinde yazanları textboxa yazıyoruz
                    text10.Text = readText.Trim();
                }
            }

            // Öncelikle Dosya varmı yokmu kontrol ediyoruz
            string to_do11_dosya = "to_do11.txt";
            if (File.Exists(to_do11_dosya) == true)
            {
                // Dosya var ise dosyanın içindekileri okuyoruz
                string readText = File.ReadAllText(to_do11_dosya);
                // Dosyanın içinde yazı varmı diye kontrol ediyoruz
                if (readText.Trim() != null)
                {
                    // Dosyanın içinde yazanları textboxa yazıyoruz
                    text11.Text = readText.Trim();
                }
            }

            // Bitti
        }


        // Dosya silme methodu
        static void sil(string to_txt)
        {
            // Adı girilen dosyayı siliyoruz
            File.Delete(to_txt);
        }

        // Dosya kaydetme methodu
        static void kaydet(string to_txt,string to_do)
        { 
            // Dosya adı girilen dosyayı oluşturuyoruz ve Dosyaya yazı yazıyoruz
            File.WriteAllText(to_txt, to_do);
        }

        private void tik1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Kullanıcı onaylaya bastığı zaman yazdığı şeyleri dosya adı ile beraber kaydetmeye yolluyoruz!
            string to_do = text1.Text.Trim();
            string to_txt = "to_do1.txt";
            kaydet(to_txt, to_do);
        }

        private void tik2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Kullanıcı onaylaya bastığı zaman yazdığı şeyleri dosya adı ile beraber kaydetmeye yolluyoruz!
            string to_do = text2.Text.Trim();
            string to_txt = "to_do2.txt";
            kaydet(to_txt, to_do);
        }

        private void tik3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Kullanıcı onaylaya bastığı zaman yazdığı şeyleri dosya adı ile beraber kaydetmeye yolluyoruz!
            string to_do = text3.Text.Trim();
            string to_txt = "to_do3.txt";
            kaydet(to_txt, to_do);
        }

        private void tik4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Kullanıcı onaylaya bastığı zaman yazdığı şeyleri dosya adı ile beraber kaydetmeye yolluyoruz!
            string to_do = text4.Text.Trim();
            string to_txt = "to_do4.txt";
            kaydet(to_txt, to_do);
        }

        private void tik5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Kullanıcı onaylaya bastığı zaman yazdığı şeyleri dosya adı ile beraber kaydetmeye yolluyoruz!
            string to_do = text5.Text.Trim();
            string to_txt = "to_do5.txt";
            kaydet(to_txt, to_do);
        }

        private void tik6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Kullanıcı onaylaya bastığı zaman yazdığı şeyleri dosya adı ile beraber kaydetmeye yolluyoruz!
            string to_do = text6.Text.Trim();
            string to_txt = "to_do6.txt";
            kaydet(to_txt, to_do);
        }

        private void tik7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Kullanıcı onaylaya bastığı zaman yazdığı şeyleri dosya adı ile beraber kaydetmeye yolluyoruz!
            string to_do = text7.Text.Trim();
            string to_txt = "to_do7.txt";
            kaydet(to_txt, to_do);
        }

        private void tik8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Kullanıcı onaylaya bastığı zaman yazdığı şeyleri dosya adı ile beraber kaydetmeye yolluyoruz!
            string to_do = text8.Text.Trim();
            string to_txt = "to_do8.txt";
            kaydet(to_txt, to_do);
        }

        private void tik9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Kullanıcı onaylaya bastığı zaman yazdığı şeyleri dosya adı ile beraber kaydetmeye yolluyoruz!
            string to_do = text9.Text.Trim();
            string to_txt = "to_do9.txt";
            kaydet(to_txt, to_do);
        }

        private void tik10_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Kullanıcı onaylaya bastığı zaman yazdığı şeyleri dosya adı ile beraber kaydetmeye yolluyoruz!
            string to_do = text10.Text.Trim();
            string to_txt = "to_do10.txt";
            kaydet(to_txt, to_do);
        }

        private void tik11_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Kullanıcı onaylaya bastığı zaman yazdığı şeyleri dosya adı ile beraber kaydetmeye yolluyoruz!
            string to_do = text11.Text.Trim();
            string to_txt = "to_do11.txt";
            kaydet(to_txt, to_do);
        }

        private void carpı1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Kullanıcı çarpıya bastığı zaman önce textboxun içini boşaltıyoruz sonra ise dosyayı silme methoduna dosya adını yolluyoruz!
            text1.Text = "";
            string to_txt = "to_do1.txt";
            if (File.Exists(to_txt) == true)
            {
                sil(to_txt);
            }
        }

        private void carpı2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Kullanıcı çarpıya bastığı zaman önce textboxun içini boşaltıyoruz sonra ise dosyayı silme methoduna dosya adını yolluyoruz!
            text2.Text = "";
            string to_txt = "to_do2.txt";
            if (File.Exists(to_txt) == true)
            {
                sil(to_txt);
            }
        }

        private void carpı3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Kullanıcı çarpıya bastığı zaman önce textboxun içini boşaltıyoruz sonra ise dosyayı silme methoduna dosya adını yolluyoruz!
            text3.Text = "";
            string to_txt = "to_do3.txt";
            if (File.Exists(to_txt) == true)
            {
                sil(to_txt);
            }
        }

        private void carpı4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Kullanıcı çarpıya bastığı zaman önce textboxun içini boşaltıyoruz sonra ise dosyayı silme methoduna dosya adını yolluyoruz!
            text4.Text = "";
            string to_txt = "to_do4.txt";
            if (File.Exists(to_txt) == true)
            {
                sil(to_txt);
            }
        }

        private void carpı5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Kullanıcı çarpıya bastığı zaman önce textboxun içini boşaltıyoruz sonra ise dosyayı silme methoduna dosya adını yolluyoruz!
            text5.Text = "";
            string to_txt = "to_do5.txt";
            if (File.Exists(to_txt) == true)
            {
                sil(to_txt);
            }
        }

        private void carpı6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Kullanıcı çarpıya bastığı zaman önce textboxun içini boşaltıyoruz sonra ise dosyayı silme methoduna dosya adını yolluyoruz!
            text6.Text = "";
            string to_txt = "to_do6.txt";
            if (File.Exists(to_txt) == true)
            {
                sil(to_txt);
            }
        }

        private void carpı7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Kullanıcı çarpıya bastığı zaman önce textboxun içini boşaltıyoruz sonra ise dosyayı silme methoduna dosya adını yolluyoruz!
            text7.Text = "";
            string to_txt = "to_do7.txt";
            if (File.Exists(to_txt) == true)
            {
                sil(to_txt);
            }
        }

        private void carpı8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Kullanıcı çarpıya bastığı zaman önce textboxun içini boşaltıyoruz sonra ise dosyayı silme methoduna dosya adını yolluyoruz!
            text8.Text = "";
            string to_txt = "to_do8.txt";
            if (File.Exists(to_txt) == true)
            {
                sil(to_txt);
            }
        }

        private void carpı9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Kullanıcı çarpıya bastığı zaman önce textboxun içini boşaltıyoruz sonra ise dosyayı silme methoduna dosya adını yolluyoruz!
            text9.Text = "";
            string to_txt = "to_do9.txt";
            if (File.Exists(to_txt) == true)
            {
                sil(to_txt);
            }
        }

        private void carpı10_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Kullanıcı çarpıya bastığı zaman önce textboxun içini boşaltıyoruz sonra ise dosyayı silme methoduna dosya adını yolluyoruz!
            text10.Text = "";
            string to_txt = "to_do10.txt";
            if (File.Exists(to_txt) == true)
            {
                sil(to_txt);
            }
        }

        private void carpı11_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Kullanıcı çarpıya bastığı zaman önce textboxun içini boşaltıyoruz sonra ise dosyayı silme methoduna dosya adını yolluyoruz!
            text11.Text = "";
            string to_txt = "to_do11.txt";
            if (File.Exists(to_txt) == true)
            {
                sil(to_txt);
            }
        }

        private void help_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Öncelikle To_Do List uygulama'mı kullandığın için teşekkür ederim.\nBaşında To_Do: yazan kutucuklara not almak istediğin şeyleri yazabilirsin!\nProgram onları kaydedecek ve bir sonra ki girişinde yine karşına çıkaracaktır.\nYan tarafdaki [✓] tuşu ile yazınızı kaydedebilirsiniz.\n[X] butonu ile yazınızı silebilirsiniz \n Not: [X] tuşuna basarsanız To_Do notunuz silinir!", "Help!");
        }
    }
}
