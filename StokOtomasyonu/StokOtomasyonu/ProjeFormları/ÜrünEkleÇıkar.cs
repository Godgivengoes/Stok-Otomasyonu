using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace StokOtomasyonu
{
    public partial class ÜrünEkleÇıkar : AbsFormControl
    {
        public ÜrünEkleÇıkar()
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

            //  Istatistikleri hesaplar ve gosterir
            IstatiskleriGuncelle();

            //  Sıralama buttonlarının click eventlerini doldurma
            button_Id_Sirala.Click += Button_Id_Sirala_Click;
            button_Tarih_Sirala.Click += Button_Tarih_Sirala_Click;
            button_Urun_Ad_Sirala.Click += Button_Urun_Ad_Sirala_Click;
            button_Urun_Fiyat_Sirala.Click += Button_Urun_Fiyat_Sirala_Click;
            button_Urun_miktar_Sirala.Click += Button_Urun_miktar_Sirala_Click;

            //  Diger buttonlar
            button_Temizle.Click += Button_Temizle_Click;
            button_Ekle.Click += Button_Ekle_Click;
            button_Sil.Click += Button_Sil_Click;
        }

        #region Button_Clicks

        //  Tıklandıgı zaman textboxlardaki bilgileri bos mu kontrol ederek liste ve listview'a ekler
        //  Istatistikleri gunceller ve kaydeder
        protected override void Button_Ekle_Click(object sender, EventArgs e)
        {
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

            int _id = 0;
            if (data.Any())
                _id = data.Max(x => x.Id);
            _id = _id > 0 ? _id : 0;
            _id++;

            DateTime _time = DateTime.Now;

            StokKontrolData stok = new StokKontrolData()
            {
                Id = _id,
                EnSonDegistirme = _time,
                UrunAdi = _urunAd,
                UrunBirimFiyati = _urunFiyat,
                UrunMiktari = _uruMiktarı
            };

            ListviewaEkle(stok, this.listView_Stok_Kontrol);
            data.Add(stok);
            TextBoxlariTemizle(panel_Sol);
            IstatiskleriGuncelle();
            JsonKaydet(DependencyInjection.GetJsonController(path));
        }

        //  Butona basıldığı zaman ListView'daki secili veri satırını listeden ve ListView'dan siler
        //  istatistikleri gunceller ve kaydeder
        protected override void Button_Sil_Click(object sender, EventArgs e)
        {
            if (listView_Stok_Kontrol.SelectedItems.Count == 0)
            {
                MessageBox.Show("Silme işlemi için herhangi birşey şeçilmedi!");
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Şeçili kısmın silinmesini istediğinize emin misiniz?", "UYARI!!!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                ListedenCikar(data, listView_Stok_Kontrol);
                JsonKaydet(DependencyInjection.GetJsonController(path));
                IstatiskleriGuncelle();
            }

        }

        //  Texboxların temizler
        protected override void Button_Temizle_Click(object sender, EventArgs e)
        {
            TextBoxlariTemizle(panel_Sol);
        }

        #endregion

        #region Fonksiyonlar

        //  List view'ın secili bilgisini komple siler
        private void ListedenCikar(List<StokKontrolData> data, ListView list)
        {
            ListViewItem item = list.SelectedItems[0];

            int id = int.Parse(list.SelectedItems[0].Text);

            data.Remove(data.Find(ara => ara.Id == id));
            item.Remove();
        }

        //  Istatistikler kısmında gözükcek bilgileri hesaplar
        private void IstatiskleriGuncelle()
        {
            //  TOPLAM GIRDI
            label_Toplam_Girdi.Text = data.Count.ToString();

            float _ortFiyat = 0, _toplamTutar = 0;
            int _toplamUrunsayısı = 0;
            foreach (var item in data)
            {
                _toplamUrunsayısı += item.UrunMiktari;
                _ortFiyat += item.UrunBirimFiyati;
                _toplamTutar += item.UrunBirimFiyati * item.UrunMiktari;
            }
            _ortFiyat /= data.Count;

            //  ORTALAMA FİYAT
            label_Ortalama_Fiyat.Text = _ortFiyat.ToString("N2") + " ₺";

            //  TOPLAM TUTAR
            label__Toplam_Tutar.Text = _toplamTutar.ToString("N2") + " ₺";

            //  TOPLAM URUN SAYISI
            label_Toplam_Urum_Sayisi.Text = _toplamUrunsayısı.ToString("N0");
        }

        #endregion

    }
}
