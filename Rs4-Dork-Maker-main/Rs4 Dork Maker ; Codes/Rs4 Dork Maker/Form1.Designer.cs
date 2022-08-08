namespace Rs4_Dork_Maker
{
    partial class Form
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.label1 = new System.Windows.Forms.Label();
            this.onayla_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.site_alan_adi_textbox = new System.Windows.Forms.TextBox();
            this.kelime_textbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.site_kategori_textbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.site_alan_adi_uyari = new System.Windows.Forms.LinkLabel();
            this.kelime_uyari = new System.Windows.Forms.LinkLabel();
            this.site_kategorisi_uyari = new System.Windows.Forms.LinkLabel();
            this.site_bölümü_uyari = new System.Windows.Forms.LinkLabel();
            this.site_bölümü_textbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dosya_tipi_uyari = new System.Windows.Forms.LinkLabel();
            this.dosya_tipi_textbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dork_goster_label = new System.Windows.Forms.Label();
            this.kopyala_button = new System.Windows.Forms.Button();
            this.temizle_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Oluşturulan Dorklar:";
            // 
            // onayla_button
            // 
            this.onayla_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.onayla_button.Location = new System.Drawing.Point(146, 156);
            this.onayla_button.Name = "onayla_button";
            this.onayla_button.Size = new System.Drawing.Size(98, 33);
            this.onayla_button.TabIndex = 3;
            this.onayla_button.Text = "Onayla";
            this.onayla_button.UseVisualStyleBackColor = true;
            this.onayla_button.Click += new System.EventHandler(this.onayla_button_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Site Alan Adı:";
            // 
            // site_alan_adi_textbox
            // 
            this.site_alan_adi_textbox.Location = new System.Drawing.Point(121, 26);
            this.site_alan_adi_textbox.Name = "site_alan_adi_textbox";
            this.site_alan_adi_textbox.Size = new System.Drawing.Size(123, 20);
            this.site_alan_adi_textbox.TabIndex = 5;
            // 
            // kelime_textbox
            // 
            this.kelime_textbox.Location = new System.Drawing.Point(121, 52);
            this.kelime_textbox.Name = "kelime_textbox";
            this.kelime_textbox.Size = new System.Drawing.Size(123, 20);
            this.kelime_textbox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Kelime:";
            // 
            // site_kategori_textbox
            // 
            this.site_kategori_textbox.Location = new System.Drawing.Point(121, 78);
            this.site_kategori_textbox.Name = "site_kategori_textbox";
            this.site_kategori_textbox.Size = new System.Drawing.Size(123, 20);
            this.site_kategori_textbox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(12, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Site Kategori:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(12, 294);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 16);
            this.label6.TabIndex = 14;
            // 
            // site_alan_adi_uyari
            // 
            this.site_alan_adi_uyari.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.site_alan_adi_uyari.LinkColor = System.Drawing.Color.Red;
            this.site_alan_adi_uyari.Location = new System.Drawing.Point(250, 27);
            this.site_alan_adi_uyari.Name = "site_alan_adi_uyari";
            this.site_alan_adi_uyari.Size = new System.Drawing.Size(21, 19);
            this.site_alan_adi_uyari.TabIndex = 15;
            this.site_alan_adi_uyari.TabStop = true;
            this.site_alan_adi_uyari.Text = "(!)";
            this.site_alan_adi_uyari.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.site_alan_adi_uyari_LinkClicked);
            // 
            // kelime_uyari
            // 
            this.kelime_uyari.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kelime_uyari.LinkColor = System.Drawing.Color.Red;
            this.kelime_uyari.Location = new System.Drawing.Point(250, 53);
            this.kelime_uyari.Name = "kelime_uyari";
            this.kelime_uyari.Size = new System.Drawing.Size(21, 19);
            this.kelime_uyari.TabIndex = 16;
            this.kelime_uyari.TabStop = true;
            this.kelime_uyari.Text = "(!)";
            this.kelime_uyari.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.kelime_uyari_LinkClicked);
            // 
            // site_kategorisi_uyari
            // 
            this.site_kategorisi_uyari.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.site_kategorisi_uyari.LinkColor = System.Drawing.Color.Red;
            this.site_kategorisi_uyari.Location = new System.Drawing.Point(250, 78);
            this.site_kategorisi_uyari.Name = "site_kategorisi_uyari";
            this.site_kategorisi_uyari.Size = new System.Drawing.Size(21, 19);
            this.site_kategorisi_uyari.TabIndex = 17;
            this.site_kategorisi_uyari.TabStop = true;
            this.site_kategorisi_uyari.Text = "(!)";
            this.site_kategorisi_uyari.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.site_kategorisi_uyari_LinkClicked);
            // 
            // site_bölümü_uyari
            // 
            this.site_bölümü_uyari.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.site_bölümü_uyari.LinkColor = System.Drawing.Color.Red;
            this.site_bölümü_uyari.Location = new System.Drawing.Point(250, 104);
            this.site_bölümü_uyari.Name = "site_bölümü_uyari";
            this.site_bölümü_uyari.Size = new System.Drawing.Size(21, 19);
            this.site_bölümü_uyari.TabIndex = 20;
            this.site_bölümü_uyari.TabStop = true;
            this.site_bölümü_uyari.Text = "(!)";
            this.site_bölümü_uyari.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.site_bölümü_uyari_LinkClicked);
            // 
            // site_bölümü_textbox
            // 
            this.site_bölümü_textbox.Location = new System.Drawing.Point(121, 104);
            this.site_bölümü_textbox.Name = "site_bölümü_textbox";
            this.site_bölümü_textbox.Size = new System.Drawing.Size(123, 20);
            this.site_bölümü_textbox.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(12, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 23);
            this.label7.TabIndex = 18;
            this.label7.Text = "Site Bölümü:";
            // 
            // dosya_tipi_uyari
            // 
            this.dosya_tipi_uyari.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dosya_tipi_uyari.LinkColor = System.Drawing.Color.Red;
            this.dosya_tipi_uyari.Location = new System.Drawing.Point(250, 130);
            this.dosya_tipi_uyari.Name = "dosya_tipi_uyari";
            this.dosya_tipi_uyari.Size = new System.Drawing.Size(21, 19);
            this.dosya_tipi_uyari.TabIndex = 23;
            this.dosya_tipi_uyari.TabStop = true;
            this.dosya_tipi_uyari.Text = "(!)";
            this.dosya_tipi_uyari.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.dosya_tipi_uyari_LinkClicked);
            // 
            // dosya_tipi_textbox
            // 
            this.dosya_tipi_textbox.Location = new System.Drawing.Point(121, 130);
            this.dosya_tipi_textbox.Name = "dosya_tipi_textbox";
            this.dosya_tipi_textbox.Size = new System.Drawing.Size(123, 20);
            this.dosya_tipi_textbox.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(12, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 23);
            this.label4.TabIndex = 21;
            this.label4.Text = "Dosya Tipi:";
            // 
            // dork_goster_label
            // 
            this.dork_goster_label.BackColor = System.Drawing.SystemColors.Window;
            this.dork_goster_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dork_goster_label.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dork_goster_label.Location = new System.Drawing.Point(12, 234);
            this.dork_goster_label.Name = "dork_goster_label";
            this.dork_goster_label.Size = new System.Drawing.Size(356, 224);
            this.dork_goster_label.TabIndex = 24;
            // 
            // kopyala_button
            // 
            this.kopyala_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kopyala_button.Location = new System.Drawing.Point(275, 208);
            this.kopyala_button.Name = "kopyala_button";
            this.kopyala_button.Size = new System.Drawing.Size(93, 23);
            this.kopyala_button.TabIndex = 27;
            this.kopyala_button.Text = "kopyala";
            this.kopyala_button.UseVisualStyleBackColor = true;
            this.kopyala_button.Click += new System.EventHandler(this.kopyala_button_Click);
            // 
            // temizle_button
            // 
            this.temizle_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.temizle_button.Location = new System.Drawing.Point(299, 422);
            this.temizle_button.Name = "temizle_button";
            this.temizle_button.Size = new System.Drawing.Size(58, 27);
            this.temizle_button.TabIndex = 28;
            this.temizle_button.Text = "temizle";
            this.temizle_button.UseVisualStyleBackColor = true;
            this.temizle_button.Click += new System.EventHandler(this.temizle_button_Click);
            // 
            // Form
            // 
            this.AcceptButton = this.onayla_button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(380, 471);
            this.Controls.Add(this.temizle_button);
            this.Controls.Add(this.kopyala_button);
            this.Controls.Add(this.dork_goster_label);
            this.Controls.Add(this.dosya_tipi_uyari);
            this.Controls.Add(this.dosya_tipi_textbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.site_bölümü_uyari);
            this.Controls.Add(this.site_bölümü_textbox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.site_kategorisi_uyari);
            this.Controls.Add(this.kelime_uyari);
            this.Controls.Add(this.site_alan_adi_uyari);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.site_kategori_textbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.kelime_textbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.site_alan_adi_textbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.onayla_button);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rs4 Dork Maker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button onayla_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox site_alan_adi_textbox;
        private System.Windows.Forms.TextBox kelime_textbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox site_kategori_textbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel site_alan_adi_uyari;
        private System.Windows.Forms.LinkLabel kelime_uyari;
        private System.Windows.Forms.LinkLabel site_kategorisi_uyari;
        private System.Windows.Forms.LinkLabel site_bölümü_uyari;
        private System.Windows.Forms.TextBox site_bölümü_textbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.LinkLabel dosya_tipi_uyari;
        private System.Windows.Forms.TextBox dosya_tipi_textbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label dork_goster_label;
        private System.Windows.Forms.Button kopyala_button;
        private System.Windows.Forms.Button temizle_button;
    }
}

