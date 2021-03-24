
using System;

namespace StokOtomasyonu
{
    partial class ÜrünEkleÇıkar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView_Stok_Kontrol = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tarih = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.urunAd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.birimFiyat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.urunMiktarı = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel_Sol = new System.Windows.Forms.Panel();
            this.button_Sil = new System.Windows.Forms.Button();
            this.button_Ekle = new System.Windows.Forms.Button();
            this.button_Temizle = new System.Windows.Forms.Button();
            this.label_Urun_Miktari = new System.Windows.Forms.Label();
            this.textBox_Urun_Miktari = new System.Windows.Forms.TextBox();
            this.textBox_Birim_Fiyat = new System.Windows.Forms.TextBox();
            this.label_Birim_Fiyat = new System.Windows.Forms.Label();
            this.label_Urun_Ad = new System.Windows.Forms.Label();
            this.textBox_Urun_Ad = new System.Windows.Forms.TextBox();
            this.panel_Sag = new System.Windows.Forms.Panel();
            this.groupBox_Istatistik_4 = new System.Windows.Forms.GroupBox();
            this.label_Toplam_Urum_Sayisi = new System.Windows.Forms.Label();
            this.groupBox_Istatistik_3 = new System.Windows.Forms.GroupBox();
            this.label__Toplam_Tutar = new System.Windows.Forms.Label();
            this.groupBox_Istatistik_2 = new System.Windows.Forms.GroupBox();
            this.label_Ortalama_Fiyat = new System.Windows.Forms.Label();
            this.groupBox_IstatistiSk_1 = new System.Windows.Forms.GroupBox();
            this.label_Toplam_Girdi = new System.Windows.Forms.Label();
            this.button_Id_Sirala = new System.Windows.Forms.Button();
            this.button_Tarih_Sirala = new System.Windows.Forms.Button();
            this.button_Urun_Ad_Sirala = new System.Windows.Forms.Button();
            this.button_Urun_Fiyat_Sirala = new System.Windows.Forms.Button();
            this.button_Urun_miktar_Sirala = new System.Windows.Forms.Button();
            this.panel_Sirala_Buttonlari = new System.Windows.Forms.Panel();
            this.panel_Sol.SuspendLayout();
            this.panel_Sag.SuspendLayout();
            this.groupBox_Istatistik_4.SuspendLayout();
            this.groupBox_Istatistik_3.SuspendLayout();
            this.groupBox_Istatistik_2.SuspendLayout();
            this.groupBox_IstatistiSk_1.SuspendLayout();
            this.panel_Sirala_Buttonlari.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView_Stok_Kontrol
            // 
            this.listView_Stok_Kontrol.AllowColumnReorder = true;
            this.listView_Stok_Kontrol.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView_Stok_Kontrol.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.tarih,
            this.urunAd,
            this.birimFiyat,
            this.urunMiktarı});
            this.listView_Stok_Kontrol.FullRowSelect = true;
            this.listView_Stok_Kontrol.GridLines = true;
            this.listView_Stok_Kontrol.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listView_Stok_Kontrol.HideSelection = false;
            this.listView_Stok_Kontrol.Location = new System.Drawing.Point(200, 30);
            this.listView_Stok_Kontrol.MultiSelect = false;
            this.listView_Stok_Kontrol.Name = "listView_Stok_Kontrol";
            this.listView_Stok_Kontrol.Size = new System.Drawing.Size(600, 610);
            this.listView_Stok_Kontrol.TabIndex = 0;
            this.listView_Stok_Kontrol.TabStop = false;
            this.listView_Stok_Kontrol.UseCompatibleStateImageBehavior = false;
            this.listView_Stok_Kontrol.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "id";
            this.ID.Width = 49;
            // 
            // tarih
            // 
            this.tarih.Text = "tarih";
            this.tarih.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tarih.Width = 150;
            // 
            // urunAd
            // 
            this.urunAd.Text = "ürün adı";
            this.urunAd.Width = 150;
            // 
            // birimFiyat
            // 
            this.birimFiyat.Text = "birim fiyat";
            this.birimFiyat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.birimFiyat.Width = 100;
            // 
            // urunMiktarı
            // 
            this.urunMiktarı.Text = "ürün miktarı";
            this.urunMiktarı.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.urunMiktarı.Width = 100;
            // 
            // panel_Sol
            // 
            this.panel_Sol.Controls.Add(this.button_Sil);
            this.panel_Sol.Controls.Add(this.button_Ekle);
            this.panel_Sol.Controls.Add(this.button_Temizle);
            this.panel_Sol.Controls.Add(this.label_Urun_Miktari);
            this.panel_Sol.Controls.Add(this.textBox_Urun_Miktari);
            this.panel_Sol.Controls.Add(this.textBox_Birim_Fiyat);
            this.panel_Sol.Controls.Add(this.label_Birim_Fiyat);
            this.panel_Sol.Controls.Add(this.label_Urun_Ad);
            this.panel_Sol.Controls.Add(this.textBox_Urun_Ad);
            this.panel_Sol.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Sol.Location = new System.Drawing.Point(0, 0);
            this.panel_Sol.Name = "panel_Sol";
            this.panel_Sol.Size = new System.Drawing.Size(200, 640);
            this.panel_Sol.TabIndex = 1;
            // 
            // button_Sil
            // 
            this.button_Sil.Location = new System.Drawing.Point(115, 250);
            this.button_Sil.Name = "button_Sil";
            this.button_Sil.Size = new System.Drawing.Size(75, 23);
            this.button_Sil.TabIndex = 5;
            this.button_Sil.Text = "Sil";
            this.button_Sil.UseVisualStyleBackColor = true;
            // 
            // button_Ekle
            // 
            this.button_Ekle.Location = new System.Drawing.Point(115, 200);
            this.button_Ekle.Name = "button_Ekle";
            this.button_Ekle.Size = new System.Drawing.Size(75, 23);
            this.button_Ekle.TabIndex = 3;
            this.button_Ekle.Text = "Ekle";
            this.button_Ekle.UseVisualStyleBackColor = true;
            // 
            // button_Temizle
            // 
            this.button_Temizle.Location = new System.Drawing.Point(10, 200);
            this.button_Temizle.Name = "button_Temizle";
            this.button_Temizle.Size = new System.Drawing.Size(75, 23);
            this.button_Temizle.TabIndex = 4;
            this.button_Temizle.Text = "Temizle";
            this.button_Temizle.UseVisualStyleBackColor = true;
            // 
            // label_Urun_Miktari
            // 
            this.label_Urun_Miktari.AutoSize = true;
            this.label_Urun_Miktari.Location = new System.Drawing.Point(14, 153);
            this.label_Urun_Miktari.Name = "label_Urun_Miktari";
            this.label_Urun_Miktari.Size = new System.Drawing.Size(61, 13);
            this.label_Urun_Miktari.TabIndex = 5;
            this.label_Urun_Miktari.Text = "ürün miktarı";
            // 
            // textBox_Urun_Miktari
            // 
            this.textBox_Urun_Miktari.Location = new System.Drawing.Point(90, 150);
            this.textBox_Urun_Miktari.Name = "textBox_Urun_Miktari";
            this.textBox_Urun_Miktari.Size = new System.Drawing.Size(100, 20);
            this.textBox_Urun_Miktari.TabIndex = 2;
            // 
            // textBox_Birim_Fiyat
            // 
            this.textBox_Birim_Fiyat.Location = new System.Drawing.Point(90, 100);
            this.textBox_Birim_Fiyat.Name = "textBox_Birim_Fiyat";
            this.textBox_Birim_Fiyat.Size = new System.Drawing.Size(100, 20);
            this.textBox_Birim_Fiyat.TabIndex = 1;
            // 
            // label_Birim_Fiyat
            // 
            this.label_Birim_Fiyat.AutoSize = true;
            this.label_Birim_Fiyat.Location = new System.Drawing.Point(22, 103);
            this.label_Birim_Fiyat.Name = "label_Birim_Fiyat";
            this.label_Birim_Fiyat.Size = new System.Drawing.Size(53, 13);
            this.label_Birim_Fiyat.TabIndex = 2;
            this.label_Birim_Fiyat.Text = "birim fiyat ";
            // 
            // label_Urun_Ad
            // 
            this.label_Urun_Ad.AutoSize = true;
            this.label_Urun_Ad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Urun_Ad.Location = new System.Drawing.Point(27, 53);
            this.label_Urun_Ad.Name = "label_Urun_Ad";
            this.label_Urun_Ad.Size = new System.Drawing.Size(48, 13);
            this.label_Urun_Ad.TabIndex = 1;
            this.label_Urun_Ad.Text = "ürün adı ";
            // 
            // textBox_Urun_Ad
            // 
            this.textBox_Urun_Ad.Location = new System.Drawing.Point(90, 50);
            this.textBox_Urun_Ad.Name = "textBox_Urun_Ad";
            this.textBox_Urun_Ad.Size = new System.Drawing.Size(100, 20);
            this.textBox_Urun_Ad.TabIndex = 0;
            // 
            // panel_Sag
            // 
            this.panel_Sag.Controls.Add(this.groupBox_Istatistik_4);
            this.panel_Sag.Controls.Add(this.groupBox_Istatistik_3);
            this.panel_Sag.Controls.Add(this.groupBox_Istatistik_2);
            this.panel_Sag.Controls.Add(this.groupBox_IstatistiSk_1);
            this.panel_Sag.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_Sag.Location = new System.Drawing.Point(800, 0);
            this.panel_Sag.Name = "panel_Sag";
            this.panel_Sag.Size = new System.Drawing.Size(200, 640);
            this.panel_Sag.TabIndex = 2;
            // 
            // groupBox_Istatistik_4
            // 
            this.groupBox_Istatistik_4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_Istatistik_4.BackColor = System.Drawing.Color.White;
            this.groupBox_Istatistik_4.Controls.Add(this.label_Toplam_Urum_Sayisi);
            this.groupBox_Istatistik_4.Location = new System.Drawing.Point(5, 218);
            this.groupBox_Istatistik_4.Name = "groupBox_Istatistik_4";
            this.groupBox_Istatistik_4.Size = new System.Drawing.Size(190, 50);
            this.groupBox_Istatistik_4.TabIndex = 4;
            this.groupBox_Istatistik_4.TabStop = false;
            this.groupBox_Istatistik_4.Text = "toplam ürün sayısı";
            // 
            // label_Toplam_Urum_Sayisi
            // 
            this.label_Toplam_Urum_Sayisi.AutoSize = true;
            this.label_Toplam_Urum_Sayisi.Location = new System.Drawing.Point(5, 25);
            this.label_Toplam_Urum_Sayisi.Name = "label_Toplam_Urum_Sayisi";
            this.label_Toplam_Urum_Sayisi.Size = new System.Drawing.Size(105, 13);
            this.label_Toplam_Urum_Sayisi.TabIndex = 0;
            this.label_Toplam_Urum_Sayisi.Text = "toplam ürün sayısı.....";
            // 
            // groupBox_Istatistik_3
            // 
            this.groupBox_Istatistik_3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_Istatistik_3.BackColor = System.Drawing.Color.White;
            this.groupBox_Istatistik_3.Controls.Add(this.label__Toplam_Tutar);
            this.groupBox_Istatistik_3.Location = new System.Drawing.Point(5, 162);
            this.groupBox_Istatistik_3.Name = "groupBox_Istatistik_3";
            this.groupBox_Istatistik_3.Size = new System.Drawing.Size(190, 50);
            this.groupBox_Istatistik_3.TabIndex = 3;
            this.groupBox_Istatistik_3.TabStop = false;
            this.groupBox_Istatistik_3.Text = "toplam tutar";
            // 
            // label__Toplam_Tutar
            // 
            this.label__Toplam_Tutar.AutoSize = true;
            this.label__Toplam_Tutar.Location = new System.Drawing.Point(5, 25);
            this.label__Toplam_Tutar.Name = "label__Toplam_Tutar";
            this.label__Toplam_Tutar.Size = new System.Drawing.Size(77, 13);
            this.label__Toplam_Tutar.TabIndex = 0;
            this.label__Toplam_Tutar.Text = "toplam tutar.....";
            // 
            // groupBox_Istatistik_2
            // 
            this.groupBox_Istatistik_2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_Istatistik_2.BackColor = System.Drawing.Color.White;
            this.groupBox_Istatistik_2.Controls.Add(this.label_Ortalama_Fiyat);
            this.groupBox_Istatistik_2.Location = new System.Drawing.Point(5, 106);
            this.groupBox_Istatistik_2.Name = "groupBox_Istatistik_2";
            this.groupBox_Istatistik_2.Size = new System.Drawing.Size(190, 50);
            this.groupBox_Istatistik_2.TabIndex = 2;
            this.groupBox_Istatistik_2.TabStop = false;
            this.groupBox_Istatistik_2.Text = "ortalama fiyat";
            // 
            // label_Ortalama_Fiyat
            // 
            this.label_Ortalama_Fiyat.AutoSize = true;
            this.label_Ortalama_Fiyat.Location = new System.Drawing.Point(5, 25);
            this.label_Ortalama_Fiyat.Name = "label_Ortalama_Fiyat";
            this.label_Ortalama_Fiyat.Size = new System.Drawing.Size(84, 13);
            this.label_Ortalama_Fiyat.TabIndex = 0;
            this.label_Ortalama_Fiyat.Text = "ortalama fiyat.....";
            // 
            // groupBox_IstatistiSk_1
            // 
            this.groupBox_IstatistiSk_1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_IstatistiSk_1.BackColor = System.Drawing.Color.White;
            this.groupBox_IstatistiSk_1.Controls.Add(this.label_Toplam_Girdi);
            this.groupBox_IstatistiSk_1.Location = new System.Drawing.Point(5, 50);
            this.groupBox_IstatistiSk_1.Name = "groupBox_IstatistiSk_1";
            this.groupBox_IstatistiSk_1.Size = new System.Drawing.Size(190, 50);
            this.groupBox_IstatistiSk_1.TabIndex = 1;
            this.groupBox_IstatistiSk_1.TabStop = false;
            this.groupBox_IstatistiSk_1.Text = "toplam girdi";
            // 
            // label_Toplam_Girdi
            // 
            this.label_Toplam_Girdi.AutoSize = true;
            this.label_Toplam_Girdi.Location = new System.Drawing.Point(5, 25);
            this.label_Toplam_Girdi.Name = "label_Toplam_Girdi";
            this.label_Toplam_Girdi.Size = new System.Drawing.Size(75, 13);
            this.label_Toplam_Girdi.TabIndex = 0;
            this.label_Toplam_Girdi.Text = "toplam girdi.....";
            // 
            // button_Id_Sirala
            // 
            this.button_Id_Sirala.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button_Id_Sirala.Location = new System.Drawing.Point(0, 0);
            this.button_Id_Sirala.Name = "button_Id_Sirala";
            this.button_Id_Sirala.Size = new System.Drawing.Size(50, 30);
            this.button_Id_Sirala.TabIndex = 5;
            this.button_Id_Sirala.TabStop = false;
            this.button_Id_Sirala.Text = "id";
            this.button_Id_Sirala.UseVisualStyleBackColor = true;
            // 
            // button_Tarih_Sirala
            // 
            this.button_Tarih_Sirala.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button_Tarih_Sirala.Location = new System.Drawing.Point(51, 0);
            this.button_Tarih_Sirala.Name = "button_Tarih_Sirala";
            this.button_Tarih_Sirala.Size = new System.Drawing.Size(150, 30);
            this.button_Tarih_Sirala.TabIndex = 4;
            this.button_Tarih_Sirala.TabStop = false;
            this.button_Tarih_Sirala.Text = "tarih";
            this.button_Tarih_Sirala.UseVisualStyleBackColor = true;
            // 
            // button_Urun_Ad_Sirala
            // 
            this.button_Urun_Ad_Sirala.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button_Urun_Ad_Sirala.Location = new System.Drawing.Point(202, 0);
            this.button_Urun_Ad_Sirala.Name = "button_Urun_Ad_Sirala";
            this.button_Urun_Ad_Sirala.Size = new System.Drawing.Size(150, 30);
            this.button_Urun_Ad_Sirala.TabIndex = 5;
            this.button_Urun_Ad_Sirala.TabStop = false;
            this.button_Urun_Ad_Sirala.Text = "ürün adı";
            this.button_Urun_Ad_Sirala.UseVisualStyleBackColor = true;
            // 
            // button_Urun_Fiyat_Sirala
            // 
            this.button_Urun_Fiyat_Sirala.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button_Urun_Fiyat_Sirala.Location = new System.Drawing.Point(353, 0);
            this.button_Urun_Fiyat_Sirala.Name = "button_Urun_Fiyat_Sirala";
            this.button_Urun_Fiyat_Sirala.Size = new System.Drawing.Size(100, 30);
            this.button_Urun_Fiyat_Sirala.TabIndex = 6;
            this.button_Urun_Fiyat_Sirala.TabStop = false;
            this.button_Urun_Fiyat_Sirala.Text = "birim fiyat";
            this.button_Urun_Fiyat_Sirala.UseVisualStyleBackColor = true;
            // 
            // button_Urun_miktar_Sirala
            // 
            this.button_Urun_miktar_Sirala.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button_Urun_miktar_Sirala.Location = new System.Drawing.Point(454, 0);
            this.button_Urun_miktar_Sirala.Name = "button_Urun_miktar_Sirala";
            this.button_Urun_miktar_Sirala.Size = new System.Drawing.Size(100, 30);
            this.button_Urun_miktar_Sirala.TabIndex = 7;
            this.button_Urun_miktar_Sirala.TabStop = false;
            this.button_Urun_miktar_Sirala.Text = "ürün miktarı";
            this.button_Urun_miktar_Sirala.UseVisualStyleBackColor = true;
            // 
            // panel_Sirala_Buttonlari
            // 
            this.panel_Sirala_Buttonlari.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_Sirala_Buttonlari.AutoScroll = true;
            this.panel_Sirala_Buttonlari.Controls.Add(this.button_Id_Sirala);
            this.panel_Sirala_Buttonlari.Controls.Add(this.button_Urun_miktar_Sirala);
            this.panel_Sirala_Buttonlari.Controls.Add(this.button_Tarih_Sirala);
            this.panel_Sirala_Buttonlari.Controls.Add(this.button_Urun_Fiyat_Sirala);
            this.panel_Sirala_Buttonlari.Controls.Add(this.button_Urun_Ad_Sirala);
            this.panel_Sirala_Buttonlari.Location = new System.Drawing.Point(200, 0);
            this.panel_Sirala_Buttonlari.Name = "panel_Sirala_Buttonlari";
            this.panel_Sirala_Buttonlari.Size = new System.Drawing.Size(600, 30);
            this.panel_Sirala_Buttonlari.TabIndex = 8;
            // 
            // ÜrünEkleÇıkar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 640);
            this.Controls.Add(this.panel_Sirala_Buttonlari);
            this.Controls.Add(this.panel_Sag);
            this.Controls.Add(this.panel_Sol);
            this.Controls.Add(this.listView_Stok_Kontrol);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ÜrünEkleÇıkar";
            this.Text = "StokKontrol";
            this.panel_Sol.ResumeLayout(false);
            this.panel_Sol.PerformLayout();
            this.panel_Sag.ResumeLayout(false);
            this.groupBox_Istatistik_4.ResumeLayout(false);
            this.groupBox_Istatistik_4.PerformLayout();
            this.groupBox_Istatistik_3.ResumeLayout(false);
            this.groupBox_Istatistik_3.PerformLayout();
            this.groupBox_Istatistik_2.ResumeLayout(false);
            this.groupBox_Istatistik_2.PerformLayout();
            this.groupBox_IstatistiSk_1.ResumeLayout(false);
            this.groupBox_IstatistiSk_1.PerformLayout();
            this.panel_Sirala_Buttonlari.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        protected override void ListView_Stok_Kontrol_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        protected override void Button_Degistir_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.ListView listView_Stok_Kontrol;
        private System.Windows.Forms.Panel panel_Sol;
        private System.Windows.Forms.ColumnHeader urunAd;
        private System.Windows.Forms.ColumnHeader birimFiyat;
        private System.Windows.Forms.ColumnHeader urunMiktarı;
        private System.Windows.Forms.Button button_Ekle;
        private System.Windows.Forms.Button button_Temizle;
        private System.Windows.Forms.Label label_Urun_Miktari;
        private System.Windows.Forms.TextBox textBox_Urun_Miktari;
        private System.Windows.Forms.TextBox textBox_Birim_Fiyat;
        private System.Windows.Forms.Label label_Birim_Fiyat;
        private System.Windows.Forms.Label label_Urun_Ad;
        private System.Windows.Forms.TextBox textBox_Urun_Ad;
        private System.Windows.Forms.Panel panel_Sag;
        private System.Windows.Forms.Label label_Toplam_Girdi;
        private System.Windows.Forms.Button button_Sil;
        private System.Windows.Forms.Button button_Id_Sirala;
        private System.Windows.Forms.Button button_Tarih_Sirala;
        private System.Windows.Forms.Button button_Urun_Ad_Sirala;
        private System.Windows.Forms.Button button_Urun_Fiyat_Sirala;
        private System.Windows.Forms.Button button_Urun_miktar_Sirala;
        private System.Windows.Forms.Panel panel_Sirala_Buttonlari;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader tarih;
        private System.Windows.Forms.GroupBox groupBox_IstatistiSk_1;
        private System.Windows.Forms.GroupBox groupBox_Istatistik_2;
        private System.Windows.Forms.Label label_Ortalama_Fiyat;
        private System.Windows.Forms.GroupBox groupBox_Istatistik_4;
        private System.Windows.Forms.Label label_Toplam_Urum_Sayisi;
        private System.Windows.Forms.GroupBox groupBox_Istatistik_3;
        private System.Windows.Forms.Label label__Toplam_Tutar;
    }
}