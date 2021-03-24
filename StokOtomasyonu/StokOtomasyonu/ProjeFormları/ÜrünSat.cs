using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StokOtomasyonu
{
    public partial class ÜrünSat : AbsFormControl
    {
        //  Secili urunun listedeki indexini tutar
        private int seciliUrununIndexi = 0;
        //  Sepete eklenen urunun liste indexi miktarı depolanır
        private readonly Dictionary<int, int> indexFiyat;

        public ÜrünSat()
        {
            //  Dictionary initialize edilir
            indexFiyat = new Dictionary<int, int>();

            //  Komponentleri yukler
            InitializeComponent();

            //  Json Dosyasını oku ve listeye cevir
            JsonOku(DependencyInjection.GetJsonController(path));

            //  listedekileri listviewda goster
            foreach (var item in data)
            {
                ListviewaEkle(item, listView_Stok_Kontrol);
                comboBox_Urun_Ad.Items.Add(item.UrunAdi);
            }

            //  Sıralama Buttonlarının event clickleri
            button_Id_Sirala.Click += Button_Id_Sirala_Click;
            button_Tarih_Sirala.Click += Button_Tarih_Sirala_Click;
            button_Urun_Ad_Sirala.Click += Button_Urun_Ad_Sirala_Click;
            button_Urun_Fiyat_Sirala.Click += Button_Urun_Fiyat_Sirala_Click;
            button_Urun_miktar_Sirala.Click += Button_Urun_miktar_Sirala_Click;

            //  Diger event eklemeleri
            comboBox_Urun_Ad.SelectedIndexChanged += ComboBox_Urun_Ad_SelectedIndexChanged;
            textBox_Urun_Miktari.TextChanged += TextBox_Urun_Miktari_TextChanged;
            button_Fisden_Cikar.Click += Button_Fisden_Cikar_Click;
            button_Sepete_Ekle.Click += Button_Sepete_Ekle_Click;
            button_Fis_Ver.Click += Button_Fis_Ver_Click;
            button_Fis_Iptal.Click += Button_Fis_Iptal_Click;
        }

        //  bilgileri temizler
        private void Button_Fis_Iptal_Click(object sender, EventArgs e)
        {
            indexFiyat.Clear();
            listBox1.Items.Clear();
            textBox_Urun_Miktari.Text = "";
            label_Hesap.Text = "0.00 ₺";
            label_Toplam_Tutar.Text = "0.00 ₺";
        }

        //  listboxdan secili kısmı cıkarır
        private void Button_Fisden_Cikar_Click(object sender, EventArgs e)
        {
            //  Listboxdan bişi yapılmamıssa terkeder
            if (listBox1.SelectedItem == null) return;

            //  Urunun indexini bulmak için string kısmını ayırır
            var strIndex = listBox1.SelectedItem.ToString().IndexOf("❌");
            var str = listBox1.SelectedItem.ToString().Substring(0, strIndex - 1);
            //  miktar ayrılır
            var intStr = listBox1.SelectedItem.ToString().Substring(strIndex + 2);

            //  Generic listeden urunadından index bulunur
            var find = data.Where(i => i.UrunAdi == str).First();
            var index = data.IndexOf(find);
            if (index == -1) return;
            //  UrunMiktarı ayrılır
            StringBuilder _intStr = new StringBuilder();
            for (int i = 0; i < intStr.Length; i++)
            {
                if (char.IsWhiteSpace(intStr[i])) break;
                _intStr.Append(intStr[i]);
            }
            //  listboxdaki secili urun miktarı elde edildi
            int num = int.Parse(_intStr.ToString());

            //  Dictionaryden eksiltilir
            if (indexFiyat[index] == num)
                indexFiyat.Remove(index);
            else indexFiyat[index] = indexFiyat[index] - num;
            //  Listboxtan cıkarılır
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);

            //  Total hesap guncellenir
            float hesap = 0;
            foreach (var item in indexFiyat)
            {
                hesap += data[item.Key].UrunBirimFiyati * item.Value;
            }
            label_Hesap.Text = hesap.ToString("N2") + " ₺";
        }

        //  Fiş simulasyonu
        private void Button_Fis_Ver_Click(object sender, EventArgs e)
        {
            string fis = DateTime.Now.ToString("dd/MM/yyyy - HH:mm:ss") + "\n";
            foreach (var item in listBox1.Items)
            {
                fis += "\n" + item.ToString();
            }
            fis += "\n\nToplam Hesap : " + label_Hesap.Text;
            MessageBox.Show(fis, "BİM Hesap bakiyesi", MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);

            foreach (var item in indexFiyat)
            {
                data[item.Key].UrunMiktari -= item.Value;
            }

            JsonKaydet(DependencyInjection.GetJsonController(path));
            ListViewBosalt(listView_Stok_Kontrol);

            //  listedekileri listviewda goster
            foreach (var item in data)
            {
                ListviewaEkle(item, listView_Stok_Kontrol);
                comboBox_Urun_Ad.Items.Add(item.UrunAdi);
            }

            indexFiyat.Clear();
            listBox1.Items.Clear();
            textBox_Urun_Miktari.Text = "";
            label_Hesap.Text = "0.00 ₺";
            label_Toplam_Tutar.Text = "0.00 ₺";

        }

        //  Secili item ve miktarını sepete ekler
        private void Button_Sepete_Ekle_Click(object sender, EventArgs e)
        {
            int miktar;
            try
            {
                miktar = int.Parse(textBox_Urun_Miktari.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("miktar hatalı!");
                return;
            }

            if (!indexFiyat.ContainsKey(seciliUrununIndexi) && data[seciliUrununIndexi].UrunMiktari < miktar)
            {
                MessageBox.Show($"malzeme miktarı olandan fazla girildi!\n\n" +
                    $"ürün : {data[seciliUrununIndexi].UrunAdi}\n" +
                    $"Stokta : {data[seciliUrununIndexi].UrunMiktari}");
                return;
            }
            else if (indexFiyat.ContainsKey(seciliUrununIndexi) && data[seciliUrununIndexi].UrunMiktari < indexFiyat[seciliUrununIndexi] + miktar)
            {
                MessageBox.Show($"malzeme miktarı olandan fazla girildi!\n\n" +
                        $"ürün : {data[seciliUrununIndexi].UrunAdi}\n" +
                        $"Stokta : {data[seciliUrununIndexi].UrunMiktari}\n" +
                        $"Sepete ekli : {indexFiyat[seciliUrununIndexi]}\n" +
                        $"Stokta kalan: {data[seciliUrununIndexi].UrunMiktari - indexFiyat[seciliUrununIndexi]}");
                return;
            }

            if (indexFiyat.ContainsKey(seciliUrununIndexi))
            {
                indexFiyat[seciliUrununIndexi] = indexFiyat[seciliUrununIndexi] + miktar;
            }
            else
            {
                indexFiyat.Add(seciliUrununIndexi, miktar);
            }

            listBox1.Items.Add($"{data[seciliUrununIndexi].UrunAdi} ❌ {miktar} = {miktar * data[seciliUrununIndexi].UrunBirimFiyati:N2} ₺");

            float hesap = 0;
            foreach (var item in indexFiyat)
            {
                hesap += data[item.Key].UrunBirimFiyati * item.Value;
            }
            label_Hesap.Text = hesap.ToString("N2") + " ₺";
        }

        //  Combobox texti değiştiginde çalısır
        private void ComboBox_Urun_Ad_SelectedIndexChanged(object sender, EventArgs e)
        {
            seciliUrununIndexi = -1;
            var search = comboBox_Urun_Ad.SelectedItem.ToString();
            var find = data.Where(i => i.UrunAdi == search).First();
            var index = data.IndexOf(find);

            if (index == -1) return;

            seciliUrununIndexi = index;

            TextBox_Urun_Miktari_TextChanged(null, null);
        }

        //  textbox text değiştiginde çalısır
        private void TextBox_Urun_Miktari_TextChanged(object sender, EventArgs e)
        {
            int miktar;
            try
            {
                miktar = int.Parse(textBox_Urun_Miktari.Text);
            }
            catch (Exception)
            {
                label_Toplam_Tutar.Text = "Hata...";
                return;
            }

            label_Toplam_Tutar.Text = (data[seciliUrununIndexi].UrunBirimFiyati * miktar).ToString("N2") + " ₺";
        }
    }
}
