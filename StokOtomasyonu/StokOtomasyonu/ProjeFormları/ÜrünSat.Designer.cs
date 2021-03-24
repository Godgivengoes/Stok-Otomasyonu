
using System;

namespace StokOtomasyonu
{
    partial class ÜrünSat
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
            this.panel_Sirala_Buttonlari = new System.Windows.Forms.Panel();
            this.button_Id_Sirala = new System.Windows.Forms.Button();
            this.button_Urun_miktar_Sirala = new System.Windows.Forms.Button();
            this.button_Tarih_Sirala = new System.Windows.Forms.Button();
            this.button_Urun_Fiyat_Sirala = new System.Windows.Forms.Button();
            this.button_Urun_Ad_Sirala = new System.Windows.Forms.Button();
            this.listView_Stok_Kontrol = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tarih = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.urunAd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.birimFiyat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.urunMiktarı = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel_Sol = new System.Windows.Forms.Panel();
            this.button_Fis_Ver = new System.Windows.Forms.Button();
            this.button_Sepete_Ekle = new System.Windows.Forms.Button();
            this.label_Toplam_Tutar = new System.Windows.Forms.Label();
            this.label_Toplam_Tutar_Text = new System.Windows.Forms.Label();
            this.comboBox_Urun_Ad = new System.Windows.Forms.ComboBox();
            this.label_Urun_Miktari = new System.Windows.Forms.Label();
            this.textBox_Urun_Miktari = new System.Windows.Forms.TextBox();
            this.label_Urun_Ad = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label_Hesap = new System.Windows.Forms.Label();
            this.button_Fisden_Cikar = new System.Windows.Forms.Button();
            this.button_Fis_Iptal = new System.Windows.Forms.Button();
            this.panel_Sirala_Buttonlari.SuspendLayout();
            this.panel_Sol.SuspendLayout();
            this.SuspendLayout();
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
            this.panel_Sirala_Buttonlari.Size = new System.Drawing.Size(800, 30);
            this.panel_Sirala_Buttonlari.TabIndex = 10;
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
            // button_Urun_miktar_Sirala
            // 
            this.button_Urun_miktar_Sirala.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button_Urun_miktar_Sirala.Location = new System.Drawing.Point(604, 0);
            this.button_Urun_miktar_Sirala.Name = "button_Urun_miktar_Sirala";
            this.button_Urun_miktar_Sirala.Size = new System.Drawing.Size(100, 30);
            this.button_Urun_miktar_Sirala.TabIndex = 7;
            this.button_Urun_miktar_Sirala.TabStop = false;
            this.button_Urun_miktar_Sirala.Text = "ürün miktarı";
            this.button_Urun_miktar_Sirala.UseVisualStyleBackColor = true;
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
            // button_Urun_Fiyat_Sirala
            // 
            this.button_Urun_Fiyat_Sirala.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button_Urun_Fiyat_Sirala.Location = new System.Drawing.Point(503, 0);
            this.button_Urun_Fiyat_Sirala.Name = "button_Urun_Fiyat_Sirala";
            this.button_Urun_Fiyat_Sirala.Size = new System.Drawing.Size(100, 30);
            this.button_Urun_Fiyat_Sirala.TabIndex = 6;
            this.button_Urun_Fiyat_Sirala.TabStop = false;
            this.button_Urun_Fiyat_Sirala.Text = "birim fiyat";
            this.button_Urun_Fiyat_Sirala.UseVisualStyleBackColor = true;
            // 
            // button_Urun_Ad_Sirala
            // 
            this.button_Urun_Ad_Sirala.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button_Urun_Ad_Sirala.Location = new System.Drawing.Point(202, 0);
            this.button_Urun_Ad_Sirala.Name = "button_Urun_Ad_Sirala";
            this.button_Urun_Ad_Sirala.Size = new System.Drawing.Size(300, 30);
            this.button_Urun_Ad_Sirala.TabIndex = 5;
            this.button_Urun_Ad_Sirala.TabStop = false;
            this.button_Urun_Ad_Sirala.Text = "ürün adı";
            this.button_Urun_Ad_Sirala.UseVisualStyleBackColor = true;
            // 
            // listView_Stok_Kontrol
            // 
            this.listView_Stok_Kontrol.AllowColumnReorder = true;
            this.listView_Stok_Kontrol.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
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
            this.listView_Stok_Kontrol.Size = new System.Drawing.Size(800, 359);
            this.listView_Stok_Kontrol.TabIndex = 11;
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
            this.urunAd.Width = 300;
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
            this.panel_Sol.Controls.Add(this.button_Fis_Iptal);
            this.panel_Sol.Controls.Add(this.button_Fisden_Cikar);
            this.panel_Sol.Controls.Add(this.label_Hesap);
            this.panel_Sol.Controls.Add(this.button_Fis_Ver);
            this.panel_Sol.Controls.Add(this.button_Sepete_Ekle);
            this.panel_Sol.Controls.Add(this.label_Toplam_Tutar);
            this.panel_Sol.Controls.Add(this.label_Toplam_Tutar_Text);
            this.panel_Sol.Controls.Add(this.comboBox_Urun_Ad);
            this.panel_Sol.Controls.Add(this.label_Urun_Miktari);
            this.panel_Sol.Controls.Add(this.textBox_Urun_Miktari);
            this.panel_Sol.Controls.Add(this.label_Urun_Ad);
            this.panel_Sol.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Sol.Location = new System.Drawing.Point(0, 0);
            this.panel_Sol.Name = "panel_Sol";
            this.panel_Sol.Size = new System.Drawing.Size(200, 640);
            this.panel_Sol.TabIndex = 12;
            // 
            // button_Fis_Ver
            // 
            this.button_Fis_Ver.Location = new System.Drawing.Point(115, 400);
            this.button_Fis_Ver.Name = "button_Fis_Ver";
            this.button_Fis_Ver.Size = new System.Drawing.Size(75, 23);
            this.button_Fis_Ver.TabIndex = 10;
            this.button_Fis_Ver.Text = "Fiş Ver";
            this.button_Fis_Ver.UseVisualStyleBackColor = true;
            // 
            // button_Sepete_Ekle
            // 
            this.button_Sepete_Ekle.Location = new System.Drawing.Point(115, 200);
            this.button_Sepete_Ekle.Name = "button_Sepete_Ekle";
            this.button_Sepete_Ekle.Size = new System.Drawing.Size(75, 23);
            this.button_Sepete_Ekle.TabIndex = 9;
            this.button_Sepete_Ekle.Text = "Sepete Ekle";
            this.button_Sepete_Ekle.UseVisualStyleBackColor = true;
            // 
            // label_Toplam_Tutar
            // 
            this.label_Toplam_Tutar.AutoSize = true;
            this.label_Toplam_Tutar.Location = new System.Drawing.Point(92, 153);
            this.label_Toplam_Tutar.Name = "label_Toplam_Tutar";
            this.label_Toplam_Tutar.Size = new System.Drawing.Size(37, 13);
            this.label_Toplam_Tutar.TabIndex = 8;
            this.label_Toplam_Tutar.Text = "0.00 ₺";
            // 
            // label_Toplam_Tutar_Text
            // 
            this.label_Toplam_Tutar_Text.AutoSize = true;
            this.label_Toplam_Tutar_Text.Location = new System.Drawing.Point(13, 153);
            this.label_Toplam_Tutar_Text.Name = "label_Toplam_Tutar_Text";
            this.label_Toplam_Tutar_Text.Size = new System.Drawing.Size(62, 13);
            this.label_Toplam_Tutar_Text.TabIndex = 7;
            this.label_Toplam_Tutar_Text.Text = "toplam tutar";
            // 
            // comboBox_Urun_Ad
            // 
            this.comboBox_Urun_Ad.DropDownWidth = 300;
            this.comboBox_Urun_Ad.FormattingEnabled = true;
            this.comboBox_Urun_Ad.Location = new System.Drawing.Point(90, 50);
            this.comboBox_Urun_Ad.Name = "comboBox_Urun_Ad";
            this.comboBox_Urun_Ad.Size = new System.Drawing.Size(100, 21);
            this.comboBox_Urun_Ad.TabIndex = 6;
            // 
            // label_Urun_Miktari
            // 
            this.label_Urun_Miktari.AutoSize = true;
            this.label_Urun_Miktari.Location = new System.Drawing.Point(14, 103);
            this.label_Urun_Miktari.Name = "label_Urun_Miktari";
            this.label_Urun_Miktari.Size = new System.Drawing.Size(61, 13);
            this.label_Urun_Miktari.TabIndex = 5;
            this.label_Urun_Miktari.Text = "ürün miktarı";
            // 
            // textBox_Urun_Miktari
            // 
            this.textBox_Urun_Miktari.Location = new System.Drawing.Point(90, 100);
            this.textBox_Urun_Miktari.Name = "textBox_Urun_Miktari";
            this.textBox_Urun_Miktari.Size = new System.Drawing.Size(100, 20);
            this.textBox_Urun_Miktari.TabIndex = 2;
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
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(200, 389);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(800, 251);
            this.listBox1.TabIndex = 13;
            // 
            // label_Hesap
            // 
            this.label_Hesap.AutoSize = true;
            this.label_Hesap.Location = new System.Drawing.Point(37, 405);
            this.label_Hesap.Name = "label_Hesap";
            this.label_Hesap.Size = new System.Drawing.Size(37, 13);
            this.label_Hesap.TabIndex = 11;
            this.label_Hesap.Text = "0.00 ₺";
            // 
            // button_Fisden_Cikar
            // 
            this.button_Fisden_Cikar.Location = new System.Drawing.Point(115, 450);
            this.button_Fisden_Cikar.Name = "button_Fisden_Cikar";
            this.button_Fisden_Cikar.Size = new System.Drawing.Size(75, 23);
            this.button_Fisden_Cikar.TabIndex = 12;
            this.button_Fisden_Cikar.Text = "Fişten Çıkar";
            this.button_Fisden_Cikar.UseVisualStyleBackColor = true;
            // 
            // button_Fis_Iptal
            // 
            this.button_Fis_Iptal.Location = new System.Drawing.Point(115, 500);
            this.button_Fis_Iptal.Name = "button_Fis_Iptal";
            this.button_Fis_Iptal.Size = new System.Drawing.Size(75, 23);
            this.button_Fis_Iptal.TabIndex = 13;
            this.button_Fis_Iptal.Text = "Fiş İptal";
            this.button_Fis_Iptal.UseVisualStyleBackColor = true;
            // 
            // ÜrünSat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 640);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.panel_Sol);
            this.Controls.Add(this.listView_Stok_Kontrol);
            this.Controls.Add(this.panel_Sirala_Buttonlari);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ÜrünSat";
            this.Text = "ÜrünSat";
            this.panel_Sirala_Buttonlari.ResumeLayout(false);
            this.panel_Sol.ResumeLayout(false);
            this.panel_Sol.PerformLayout();
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

        protected override void Button_Temizle_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        protected override void Button_Ekle_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        protected override void Button_Sil_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Panel panel_Sirala_Buttonlari;
        private System.Windows.Forms.Button button_Id_Sirala;
        private System.Windows.Forms.Button button_Urun_miktar_Sirala;
        private System.Windows.Forms.Button button_Tarih_Sirala;
        private System.Windows.Forms.Button button_Urun_Fiyat_Sirala;
        private System.Windows.Forms.Button button_Urun_Ad_Sirala;
        private System.Windows.Forms.ListView listView_Stok_Kontrol;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader tarih;
        private System.Windows.Forms.ColumnHeader urunAd;
        private System.Windows.Forms.ColumnHeader birimFiyat;
        private System.Windows.Forms.ColumnHeader urunMiktarı;
        private System.Windows.Forms.Panel panel_Sol;
        private System.Windows.Forms.Label label_Urun_Miktari;
        private System.Windows.Forms.TextBox textBox_Urun_Miktari;
        private System.Windows.Forms.Label label_Urun_Ad;
        private System.Windows.Forms.ComboBox comboBox_Urun_Ad;
        private System.Windows.Forms.Label label_Toplam_Tutar_Text;
        private System.Windows.Forms.Label label_Toplam_Tutar;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button_Sepete_Ekle;
        private System.Windows.Forms.Button button_Fis_Ver;
        private System.Windows.Forms.Label label_Hesap;
        private System.Windows.Forms.Button button_Fisden_Cikar;
        private System.Windows.Forms.Button button_Fis_Iptal;
    }
}