
using System;

namespace StokOtomasyonu
{
    partial class StoktaAra
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
            this.button_Sonucları_Sil = new System.Windows.Forms.Button();
            this.radioButton_Kucuk = new System.Windows.Forms.RadioButton();
            this.radioButton_Büyük = new System.Windows.Forms.RadioButton();
            this.label_Urun_Miktari = new System.Windows.Forms.Label();
            this.textBox_Urun_Miktari = new System.Windows.Forms.TextBox();
            this.button_Ara = new System.Windows.Forms.Button();
            this.label_Urun_Ad = new System.Windows.Forms.Label();
            this.textBox_Urun_Ad = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton_Fazla = new System.Windows.Forms.RadioButton();
            this.radioButton_Az = new System.Windows.Forms.RadioButton();
            this.label_Birim_Fiyat = new System.Windows.Forms.Label();
            this.textBox_Birim_Fiyat = new System.Windows.Forms.TextBox();
            this.panel_Sirala_Buttonlari.SuspendLayout();
            this.panel_Sol.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.panel_Sirala_Buttonlari.TabIndex = 11;
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
            this.listView_Stok_Kontrol.Size = new System.Drawing.Size(800, 610);
            this.listView_Stok_Kontrol.TabIndex = 12;
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
            this.panel_Sol.Controls.Add(this.textBox_Birim_Fiyat);
            this.panel_Sol.Controls.Add(this.label_Birim_Fiyat);
            this.panel_Sol.Controls.Add(this.panel1);
            this.panel_Sol.Controls.Add(this.button_Sonucları_Sil);
            this.panel_Sol.Controls.Add(this.radioButton_Kucuk);
            this.panel_Sol.Controls.Add(this.radioButton_Büyük);
            this.panel_Sol.Controls.Add(this.label_Urun_Miktari);
            this.panel_Sol.Controls.Add(this.textBox_Urun_Miktari);
            this.panel_Sol.Controls.Add(this.button_Ara);
            this.panel_Sol.Controls.Add(this.label_Urun_Ad);
            this.panel_Sol.Controls.Add(this.textBox_Urun_Ad);
            this.panel_Sol.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Sol.Location = new System.Drawing.Point(0, 0);
            this.panel_Sol.Name = "panel_Sol";
            this.panel_Sol.Size = new System.Drawing.Size(200, 640);
            this.panel_Sol.TabIndex = 13;
            // 
            // button_Sonucları_Sil
            // 
            this.button_Sonucları_Sil.Location = new System.Drawing.Point(12, 419);
            this.button_Sonucları_Sil.Name = "button_Sonucları_Sil";
            this.button_Sonucları_Sil.Size = new System.Drawing.Size(75, 23);
            this.button_Sonucları_Sil.TabIndex = 9;
            this.button_Sonucları_Sil.Text = "Sonucları Sil";
            this.button_Sonucları_Sil.UseVisualStyleBackColor = true;
            // 
            // radioButton_Kucuk
            // 
            this.radioButton_Kucuk.AutoSize = true;
            this.radioButton_Kucuk.Location = new System.Drawing.Point(134, 150);
            this.radioButton_Kucuk.Name = "radioButton_Kucuk";
            this.radioButton_Kucuk.Size = new System.Drawing.Size(56, 17);
            this.radioButton_Kucuk.TabIndex = 4;
            this.radioButton_Kucuk.Text = "Küçük";
            this.radioButton_Kucuk.UseVisualStyleBackColor = true;
            // 
            // radioButton_Büyük
            // 
            this.radioButton_Büyük.AutoSize = true;
            this.radioButton_Büyük.Checked = true;
            this.radioButton_Büyük.Location = new System.Drawing.Point(73, 150);
            this.radioButton_Büyük.Name = "radioButton_Büyük";
            this.radioButton_Büyük.Size = new System.Drawing.Size(55, 17);
            this.radioButton_Büyük.TabIndex = 3;
            this.radioButton_Büyük.Text = "Büyük";
            this.radioButton_Büyük.UseVisualStyleBackColor = true;
            // 
            // label_Urun_Miktari
            // 
            this.label_Urun_Miktari.AutoSize = true;
            this.label_Urun_Miktari.Location = new System.Drawing.Point(14, 203);
            this.label_Urun_Miktari.Name = "label_Urun_Miktari";
            this.label_Urun_Miktari.Size = new System.Drawing.Size(61, 13);
            this.label_Urun_Miktari.TabIndex = 6;
            this.label_Urun_Miktari.Text = "ürün miktarı";
            // 
            // textBox_Urun_Miktari
            // 
            this.textBox_Urun_Miktari.Location = new System.Drawing.Point(90, 200);
            this.textBox_Urun_Miktari.Name = "textBox_Urun_Miktari";
            this.textBox_Urun_Miktari.Size = new System.Drawing.Size(100, 20);
            this.textBox_Urun_Miktari.TabIndex = 5;
            // 
            // button_Ara
            // 
            this.button_Ara.Location = new System.Drawing.Point(115, 419);
            this.button_Ara.Name = "button_Ara";
            this.button_Ara.Size = new System.Drawing.Size(75, 23);
            this.button_Ara.TabIndex = 8;
            this.button_Ara.Text = "Ara";
            this.button_Ara.UseVisualStyleBackColor = true;
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
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButton_Az);
            this.panel1.Controls.Add(this.radioButton_Fazla);
            this.panel1.Location = new System.Drawing.Point(73, 250);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(114, 18);
            this.panel1.TabIndex = 13;
            // 
            // radioButton_Fazla
            // 
            this.radioButton_Fazla.AutoSize = true;
            this.radioButton_Fazla.Checked = true;
            this.radioButton_Fazla.Location = new System.Drawing.Point(21, 0);
            this.radioButton_Fazla.Name = "radioButton_Fazla";
            this.radioButton_Fazla.Size = new System.Drawing.Size(50, 17);
            this.radioButton_Fazla.TabIndex = 6;
            this.radioButton_Fazla.Text = "Fazla";
            this.radioButton_Fazla.UseVisualStyleBackColor = true;
            // 
            // radioButton_Az
            // 
            this.radioButton_Az.AutoSize = true;
            this.radioButton_Az.Location = new System.Drawing.Point(77, 0);
            this.radioButton_Az.Name = "radioButton_Az";
            this.radioButton_Az.Size = new System.Drawing.Size(37, 17);
            this.radioButton_Az.TabIndex = 7;
            this.radioButton_Az.Text = "Az";
            this.radioButton_Az.UseVisualStyleBackColor = true;
            // 
            // label_Birim_Fiyat
            // 
            this.label_Birim_Fiyat.AutoSize = true;
            this.label_Birim_Fiyat.Location = new System.Drawing.Point(22, 106);
            this.label_Birim_Fiyat.Name = "label_Birim_Fiyat";
            this.label_Birim_Fiyat.Size = new System.Drawing.Size(53, 13);
            this.label_Birim_Fiyat.TabIndex = 14;
            this.label_Birim_Fiyat.Text = "birim fiyat ";
            // 
            // textBox_Birim_Fiyat
            // 
            this.textBox_Birim_Fiyat.Location = new System.Drawing.Point(90, 103);
            this.textBox_Birim_Fiyat.Name = "textBox_Birim_Fiyat";
            this.textBox_Birim_Fiyat.Size = new System.Drawing.Size(100, 20);
            this.textBox_Birim_Fiyat.TabIndex = 1;
            // 
            // StoktaAra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 640);
            this.Controls.Add(this.panel_Sol);
            this.Controls.Add(this.listView_Stok_Kontrol);
            this.Controls.Add(this.panel_Sirala_Buttonlari);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StoktaAra";
            this.Text = "StoktaAra";
            this.panel_Sirala_Buttonlari.ResumeLayout(false);
            this.panel_Sol.ResumeLayout(false);
            this.panel_Sol.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Label label_Urun_Ad;
        private System.Windows.Forms.TextBox textBox_Urun_Ad;
        private System.Windows.Forms.Button button_Ara;
        private System.Windows.Forms.TextBox textBox_Urun_Miktari;
        private System.Windows.Forms.RadioButton radioButton_Kucuk;
        private System.Windows.Forms.RadioButton radioButton_Büyük;
        private System.Windows.Forms.Label label_Urun_Miktari;
        private System.Windows.Forms.Button button_Sonucları_Sil;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButton_Az;
        private System.Windows.Forms.RadioButton radioButton_Fazla;
        private System.Windows.Forms.Label label_Birim_Fiyat;
        private System.Windows.Forms.TextBox textBox_Birim_Fiyat;
    }
}