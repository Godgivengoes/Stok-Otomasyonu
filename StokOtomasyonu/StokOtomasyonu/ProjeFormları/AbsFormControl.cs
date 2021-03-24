using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace StokOtomasyonu
{
    //[TypeDescriptionProvider(typeof(AbstractControlDescriptionProvider<AbsFormControl, Form>))]
    [TypeDescriptionProvider(typeof(AbstractCommunicatorProvider))]
    public abstract class AbsFormControl : Form
    {
        //  Json dosyasının adı
        public const string path = "StokKontrol.json";
        //  Sıralama buttonunu saklar tekrar basıldıgını anlayıp ters sıralama yapmak için
        public Button activeSiralaButton;
        //  Gösterilcek verileri tutar
        public List<StokKontrolData> data;

        //  Initialize Field
        public AbsFormControl()
        {
            data = new List<StokKontrolData>();
        }

        #region Fonksiyonlar

        //  Listview'a verilen bilgileri ekler
        protected virtual void ListviewaEkle(IStokKontrolData stok, ListView list)
        {
            ListViewItem item = list.Items.Add(stok.Id.ToString("00000"));

            if (stok.EnSonDegistirme == null)
                item.SubItems.Add("NULL");
            else item.SubItems.Add(stok.EnSonDegistirme.ToString("dd/MM/yyyy HH:mm:ss"));

            if (stok.UrunAdi == null)
                item.SubItems.Add("NULL");
            else item.SubItems.Add(stok.UrunAdi);

            item.SubItems.Add(stok.UrunBirimFiyati.ToString("F") + " ₺");

            item.SubItems.Add(stok.UrunMiktari.ToString("00000"));
        }

        //  Verilen listView'ı komple temizler
        protected virtual void ListViewBosalt(ListView list)
        {
            if (list.Items.Count != 0)
                list.Items.Clear();
        }

        //  Listviewdaki itemları silerek yeniden yazdırır
        protected virtual void ListViewYenile(ListView list, List<StokKontrolData> data)
        {
            ListViewBosalt(list);

            foreach (var item in data)
            {
                ListviewaEkle(item, list);
            }
        }

        //  Textboxlar'ın Textini bosaltır
        protected virtual void TextBoxlariTemizle(Panel panel)
        {
            foreach (var item in panel.Controls)
            {
                if (item is TextBox textBox)
                {
                    textBox.Text = string.Empty;
                }
            }
        }

        //  Eğer aynı butona ikinci kez basılıyorsa ters sıralar ve true degerini donderir
        protected virtual bool Tersirala(object sender)
        {
            var btn = (Button)sender;
            if (btn.Equals(activeSiralaButton))
            {
                data.Reverse();
                return true;
            }
            activeSiralaButton = btn;
            return false;
        }

        //  listeyi okuyup listeye cevirir
        protected virtual void JsonOku(IJsonController jsonController)
        {
            data = jsonController.GetList<StokKontrolData>();
        }

        //  listeyi Json olarak kaydeder
        protected virtual void JsonKaydet(IJsonController jsonController)
        {
            jsonController.SetList(data);
        }

        #endregion

        #region Button_abstract_Clicks

        protected abstract void ListView_Stok_Kontrol_Click(object sender, EventArgs e);
        protected abstract void Button_Degistir_Click(object sender, EventArgs e);
        protected abstract void Button_Temizle_Click(object sender, EventArgs e);
        protected abstract void Button_Ekle_Click(object sender, EventArgs e);
        protected abstract void Button_Sil_Click(object sender, EventArgs e);

        #endregion

        #region Button_Sirala_Click_Fonksiyonları

        //  idleri sırala
        protected virtual void Button_Id_Sirala_Click(object sender, EventArgs e)
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
                ListViewYenile(listView, data);
                return;
            }

            data.Sort();
            ListViewYenile(listView, data);
        }

        //  tarihleri sırala
        protected virtual void Button_Tarih_Sirala_Click(object sender, EventArgs e)
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
                ListViewYenile(listView, data);
                return;
            }

            data.Sort((x, y) => DateTime.Compare(x.EnSonDegistirme, y.EnSonDegistirme));
            ListViewYenile(listView, data);
        }

        //  urun adlarını sırala
        protected virtual void Button_Urun_Ad_Sirala_Click(object sender, EventArgs e)
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
                ListViewYenile(listView, data);
                return;
            }


            data.Sort(delegate (StokKontrolData x, StokKontrolData y)
            {
                if (x.UrunAdi == null && y.UrunAdi == null) return 0;
                else if (x.UrunAdi == null) return -1;
                else if (y.UrunAdi == null) return 1;
                else return x.UrunAdi.CompareTo(y.UrunAdi);
            });
            ListViewYenile(listView, data);
        }


        //  Fiyatları sırala
        protected virtual void Button_Urun_Fiyat_Sirala_Click(object sender, EventArgs e)
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
                ListViewYenile(listView, data);
                return;
            }

            data.Sort((x, y) => x.UrunBirimFiyati.CompareTo(y.UrunBirimFiyati));
            ListViewYenile(listView, data);
        }

        //  Miktarları sırala
        protected virtual void Button_Urun_miktar_Sirala_Click(object sender, EventArgs e)
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
                ListViewYenile(listView, data);
                return;
            }

            data.Sort((x, y) => x.UrunMiktari.CompareTo(y.UrunMiktari));
            ListViewYenile(listView, data);
        }

        #endregion
    }
}
