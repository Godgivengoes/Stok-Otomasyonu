using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace StokOtomasyonu
{
    public partial class StoktaAra : AbsFormControl
    {
        private List<StokKontrolData> stokKontrols = new List<StokKontrolData>();
        public StoktaAra()
        {
            //  Komponentleri yukler
            InitializeComponent();

            //  Json dosyasını okuyarak listeyi doldurur
            JsonOku(DependencyInjection.GetJsonController(path));

            //  listedekileri listview'a yazdırır
            foreach (var item in data)
            {
                ListviewaEkle(item, listView_Stok_Kontrol);
            }

            stokKontrols = data;

            //  Sıralama buttonlarının click eventlerini doldurma
            button_Id_Sirala.Click += Button_Id_Sirala_Click;
            button_Tarih_Sirala.Click += Button_Tarih_Sirala_Click;
            button_Urun_Ad_Sirala.Click += Button_Urun_Ad_Sirala_Click;
            button_Urun_Fiyat_Sirala.Click += Button_Urun_Fiyat_Sirala_Click;
            button_Urun_miktar_Sirala.Click += Button_Urun_miktar_Sirala_Click;

            //  Diger buttonlar
            textBox_Urun_Miktari.TextChanged += TextBox_Urun_Miktari_TextChanged;
            textBox_Birim_Fiyat.TextChanged += TextBox_Birim_Fiyat_TextChanged;
            textBox_Urun_Miktari.KeyPress += TextBox_Urun_Miktari_KeyPress;
            textBox_Urun_Miktari.KeyDown += TextBox_Urun_Miktari_KeyDown;
            textBox_Birim_Fiyat.KeyPress += TextBox_Birim_Fiyat_KeyPress;
            textBox_Urun_Ad.TextChanged += TextBox_Urun_Ad_TextChanged;
            textBox_Birim_Fiyat.KeyDown += TextBox_Birim_Fiyat_KeyDown;
            button_Sonucları_Sil.Click += Button_Sonucları_Sil_Click;
            textBox_Urun_Ad.KeyDown += TextBox_Urun_Ad_KeyDown;
            button_Ara.Click += Button_Ara_Click;
        }

        //  Floating nuber girilmesini engeller
        private void TextBox_Birim_Fiyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        //  Floating nuber girilmesini engeller
        private void TextBox_Urun_Miktari_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        //  Enter'a basıldıgında ara buttonunu çalıstırır
        private void TextBox_Birim_Fiyat_KeyDown(object sender, KeyEventArgs e)
        {
            Button_Ara_Click(null, null);
        }

        //  Enter'a basıldıgında ara buttonunu çalıstırır
        private void TextBox_Urun_Miktari_KeyDown(object sender, KeyEventArgs e)
        {
            Button_Ara_Click(null, null);
        }

        //  Enter'a basıldıgında ara buttonunu çalıstırır
        private void TextBox_Urun_Ad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Return))
            {
                Button_Ara_Click(null, null);
            }
        }

        //  Texti değiştiginde ara buttonunu çalıştırır
        private void TextBox_Birim_Fiyat_TextChanged(object sender, EventArgs e)
        {
            Button_Ara_Click(null, null);
        }

        //  Texti değiştiginde ara buttonunu çalıştırır
        private void TextBox_Urun_Miktari_TextChanged(object sender, EventArgs e)
        {
            Button_Ara_Click(null, null);
        }

        //  Texti değiştiginde ara buttonunu çalıştırır
        private void TextBox_Urun_Ad_TextChanged(object sender, EventArgs e)
        {
            Button_Ara_Click(null, null);
        }

        //  Ekranı ve belli bellekleri temizler
        private void Button_Sonucları_Sil_Click(object sender, EventArgs e)
        {
            stokKontrols = new List<StokKontrolData>();
            textBox_Urun_Ad.Text = string.Empty;
            textBox_Urun_Miktari.Text = string.Empty;
            textBox_Birim_Fiyat.Text = string.Empty;
            ListViewBosalt(listView_Stok_Kontrol);
        }

        private void Button_Ara_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox_Urun_Ad.Text))
            {
                var str = textBox_Urun_Ad.Text.ToLower();
                var find = data.FindAll(i => i.UrunAdi.ToLower().Contains(str));
                if (find == null || !find.Any()) return;
                stokKontrols = find;
                ListViewYenile(listView_Stok_Kontrol, find);

                if (!string.IsNullOrWhiteSpace(textBox_Birim_Fiyat.Text))
                {
                    if (radioButton_Fazla.Checked)
                    {
                        find = stokKontrols.FindAll(i => i.UrunBirimFiyati >= float.Parse(textBox_Birim_Fiyat.Text));
                    }
                    else if (radioButton_Kucuk.Checked)
                    {
                        find = stokKontrols.FindAll(i => i.UrunBirimFiyati <= float.Parse(textBox_Birim_Fiyat.Text));
                    }
                    if (find == null || !find.Any()) return;
                    stokKontrols = find;
                    ListViewYenile(listView_Stok_Kontrol, find);

                    if (!string.IsNullOrWhiteSpace(textBox_Urun_Miktari.Text))
                    {
                        if (radioButton_Fazla.Checked)
                        {
                            find = stokKontrols.FindAll(i => i.UrunMiktari >= float.Parse(textBox_Urun_Miktari.Text));
                        }
                        else if (radioButton_Az.Checked)
                        {
                            find = stokKontrols.FindAll(i => i.UrunMiktari <= float.Parse(textBox_Urun_Miktari.Text));
                        }
                        if (find == null || !find.Any()) return;
                        stokKontrols = find;
                        ListViewYenile(listView_Stok_Kontrol, find);
                    }
                    return;
                }

                if (!string.IsNullOrWhiteSpace(textBox_Urun_Miktari.Text))
                {
                    if (radioButton_Fazla.Checked)
                    {
                        find = stokKontrols.FindAll(i => i.UrunMiktari >= float.Parse(textBox_Urun_Miktari.Text));
                    }
                    else if (radioButton_Az.Checked)
                    {
                        find = stokKontrols.FindAll(i => i.UrunMiktari <= float.Parse(textBox_Urun_Miktari.Text));
                    }
                    if (find == null || !find.Any()) return;
                    stokKontrols = find;
                    ListViewYenile(listView_Stok_Kontrol, find);
                }
                return;
            }
            if (!string.IsNullOrWhiteSpace(textBox_Birim_Fiyat.Text))
            {
                List<StokKontrolData> find = null;
                if (radioButton_Büyük.Checked)
                {
                    find = data.FindAll(i => i.UrunBirimFiyati >= float.Parse(textBox_Birim_Fiyat.Text));
                }
                else if (radioButton_Kucuk.Checked)
                {
                    find = data.FindAll(i => i.UrunBirimFiyati <= float.Parse(textBox_Birim_Fiyat.Text));
                }
                if (find == null || !find.Any()) return;
                stokKontrols = find;
                ListViewYenile(listView_Stok_Kontrol, find);

                if (!string.IsNullOrWhiteSpace(textBox_Urun_Miktari.Text))
                {
                    if (radioButton_Fazla.Checked)
                    {
                        find = stokKontrols.FindAll(i => i.UrunMiktari >= float.Parse(textBox_Urun_Miktari.Text));
                    }
                    else if (radioButton_Az.Checked)
                    {
                        find = stokKontrols.FindAll(i => i.UrunMiktari <= float.Parse(textBox_Urun_Miktari.Text));
                    }
                    if (find == null || !find.Any()) return;
                    stokKontrols = find;
                    ListViewYenile(listView_Stok_Kontrol, find);
                }
                return;
            }
            if (!string.IsNullOrWhiteSpace(textBox_Urun_Miktari.Text))
            {
                List<StokKontrolData> find = null;
                if (radioButton_Fazla.Checked)
                {
                    find = stokKontrols.FindAll(i => i.UrunMiktari >= float.Parse(textBox_Urun_Miktari.Text));
                }
                else if (radioButton_Az.Checked)
                {
                    find = stokKontrols.FindAll(i => i.UrunMiktari <= float.Parse(textBox_Urun_Miktari.Text));
                }
                if (find == null || !find.Any()) return;
                stokKontrols = find;
                ListViewYenile(listView_Stok_Kontrol, find);
            }
            return;
        }

        protected override bool Tersirala(object sender)
        {
            var btn = (Button)sender;
            if (btn.Equals(activeSiralaButton))
            {
                stokKontrols.Reverse();
                return true;
            }
            activeSiralaButton = btn;
            return false;
        }

        protected override void Button_Id_Sirala_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            ListView listView = null;
            foreach (var item in btn.Parent.Parent.Controls)
            {
                if (item is ListView list)
                {
                    listView = list;
                }
            }
            if (listView == null) return;
            if (Tersirala(sender))
            {
                ListViewYenile(listView, stokKontrols);
                return;
            }

            stokKontrols.Sort();
            ListViewYenile(listView, stokKontrols);
        }

        protected override void Button_Tarih_Sirala_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            ListView listView = null;
            foreach (var item in btn.Parent.Parent.Controls)
            {
                if (item is ListView list)
                {
                    listView = list;
                }
            }
            if (listView == null) return;
            if (Tersirala(sender))
            {
                ListViewYenile(listView, stokKontrols);
                return;
            }

            stokKontrols.Sort((x, y) => DateTime.Compare(x.EnSonDegistirme, y.EnSonDegistirme));
            ListViewYenile(listView, stokKontrols);
        }

        protected override void Button_Urun_Ad_Sirala_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            ListView listView = null;
            foreach (var item in btn.Parent.Parent.Controls)
            {
                if (item is ListView list)
                {
                    listView = list;
                }
            }
            if (listView == null) return;
            if (Tersirala(sender))
            {
                ListViewYenile(listView, stokKontrols);
                return;
            }


            stokKontrols.Sort(delegate (StokKontrolData x, StokKontrolData y)
            {
                if (x.UrunAdi == null && y.UrunAdi == null) return 0;
                else if (x.UrunAdi == null) return -1;
                else if (y.UrunAdi == null) return 1;
                else return x.UrunAdi.CompareTo(y.UrunAdi);
            });
            ListViewYenile(listView, stokKontrols);
        }

        protected override void Button_Urun_Fiyat_Sirala_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            ListView listView = null;
            foreach (var item in btn.Parent.Parent.Controls)
            {
                if (item is ListView list)
                {
                    listView = list;
                }
            }
            if (listView == null) return;
            if (Tersirala(sender))
            {
                ListViewYenile(listView, stokKontrols);
                return;
            }

            stokKontrols.Sort((x, y) => x.UrunBirimFiyati.CompareTo(y.UrunBirimFiyati));
            ListViewYenile(listView, stokKontrols);
        }

        protected override void Button_Urun_miktar_Sirala_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            ListView listView = null;
            foreach (var item in btn.Parent.Parent.Controls)
            {
                if (item is ListView list)
                {
                    listView = list;
                }
            }
            if (listView == null) return;
            if (Tersirala(sender))
            {
                ListViewYenile(listView, stokKontrols);
                return;
            }

            stokKontrols.Sort((x, y) => x.UrunMiktari.CompareTo(y.UrunMiktari));
            ListViewYenile(listView, stokKontrols);
        }
    }
}
