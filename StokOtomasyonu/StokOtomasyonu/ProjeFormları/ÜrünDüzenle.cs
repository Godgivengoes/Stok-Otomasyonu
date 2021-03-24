using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace StokOtomasyonu
{
    public partial class ÜrünDüzenle : AbsFormControl
    {
        //  Listviewdan secilen satırı tutar
        private ListViewItem selected;

        public ÜrünDüzenle()
        {
            //  Komponentleri yukler
            InitializeComponent();

            //  Json Dosyasını oku ve listeye cevir
            JsonOku(DependencyInjection.GetJsonController(path));

            //  listedekileri listviewda goster
            foreach (var item in data)
            {
                ListviewaEkle(item, listView_Stok_Kontrol);
            }

            //  Sıralama Buttonlarının event clickleri
            button_Urun_miktar_Sirala.Click += Button_Urun_miktar_Sirala_Click;
            button_Urun_Fiyat_Sirala.Click += Button_Urun_Fiyat_Sirala_Click;
            button_Urun_Ad_Sirala.Click += Button_Urun_Ad_Sirala_Click;
            button_Tarih_Sirala.Click += Button_Tarih_Sirala_Click;
            button_Id_Sirala.Click += Button_Id_Sirala_Click;

            //  Diger buttonlar
            button_Temizle.Click += Button_Temizle_Click;
            button_Degistir.Click += Button_Degistir_Click;
            listView_Stok_Kontrol.Click += ListView_Stok_Kontrol_Click;
        }


        //  Listviewdan secilen satırı hafıza getirir ve textboxları ordaki bilgilerle doldurur
        protected override void ListView_Stok_Kontrol_Click(object sender, EventArgs e)
        {
            selected = listView_Stok_Kontrol.SelectedItems[0];
            textBox_Urun_Ad.Text = listView_Stok_Kontrol.SelectedItems[0].SubItems[2].Text;
            textBox_Birim_Fiyat.Text = float.Parse(listView_Stok_Kontrol.SelectedItems[0].SubItems[3].Text.Replace(" ₺", "")).ToString();
            textBox_Urun_Miktari.Text = int.Parse(listView_Stok_Kontrol.SelectedItems[0].SubItems[4].Text).ToString();
        }

        //  Hafızadaki listview'ı ve texboxların textlerini bosaltır
        protected override void Button_Temizle_Click(object sender, EventArgs e)
        {
            selected = null;
            TextBoxlariTemizle(panel_Sol);
        }

        //  secili listview'ı modifiye eder
        protected override void Button_Degistir_Click(object sender, EventArgs e)
        {
            if (listView_Stok_Kontrol.SelectedItems.Count == 0)
            {
                MessageBox.Show("Değiştirme işlemi için herhangi birşey şeçilmedi!");
                return;
            }

            if (string.IsNullOrWhiteSpace(textBox_Urun_Ad.Text))
            {
                MessageBox.Show("ürün adı boş bırakılmış!");
                return;
            }
            var _urunAd = textBox_Urun_Ad.Text;

            float _urunFiyat;
            try
            {
                _urunFiyat = float.Parse(textBox_Birim_Fiyat.Text);
                if (_urunFiyat <= 0)
                {
                    MessageBox.Show("ürün fiyatı boş bırakılmış!");
                    return;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("ürün fiyatı problemli!");
                return;
            }

            int _uruMiktarı;
            try
            {
                _uruMiktarı = int.Parse(textBox_Urun_Miktari.Text);
                if (_uruMiktarı <= 0)
                {
                    MessageBox.Show("ürün miktarı boş bırakılmıs!");
                    return;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("ürün miktarı problemli!");
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Şeçili kısmın değiştirilmesini istediğinize emin misiniz?", "UYARI!!!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int id = int.Parse(selected.SubItems[0].Text);
                IStokKontrolData stok = DependencyInjection.GetStokKontrolData();

                stok.Id = id;
                stok.EnSonDegistirme = DateTime.Now;
                stok.UrunAdi = _urunAd;
                stok.UrunBirimFiyati = _urunFiyat;
                stok.UrunMiktari = _uruMiktarı;

                var find = data.Where(i => i.Id == id).First();
                var index = data.IndexOf(find);

                if (index != -1)
                    data[index] = stok as StokKontrolData;

                selected.SubItems[1].Text = stok.EnSonDegistirme.ToString("dd/MM/yyyy HH:mm:ss");
                selected.SubItems[2].Text = stok.UrunAdi;
                selected.SubItems[3].Text = stok.UrunBirimFiyati.ToString("F") + " ₺";
                selected.SubItems[4].Text = stok.UrunMiktari.ToString("00000");

                JsonKaydet(DependencyInjection.GetJsonController(path));
            }
        }

    }
}
