using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokOtomasyonu
{
    public class StokKontrolData : IEquatable<StokKontrolData>, IComparable<StokKontrolData>, IStokKontrolData
    {
        private int id = 0;
        private DateTime enSonDegistirme;
        private string urunAdi = string.Empty;
        private float urunBirimFiyati = 0;
        private int urunMiktari = 0;

        public int Id { get => id; set => id = value; }
        public DateTime EnSonDegistirme { get => enSonDegistirme; set => enSonDegistirme = value; }
        public string UrunAdi { get => urunAdi; set => urunAdi = value; }
        public float UrunBirimFiyati { get => urunBirimFiyati; set => urunBirimFiyati = value; }
        public int UrunMiktari { get => urunMiktari; set => urunMiktari = value; }

        /// <summary>
        /// Verinin içeriğini string'e çevirir istenilen şekilde
        /// </summary>
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("{" + id + "}" + ' ');
            stringBuilder.Append("{" + enSonDegistirme.ToString("dd/mm/yyyy") + "}" + ' ');
            stringBuilder.Append("{" + urunAdi + "}" + ' ');
            stringBuilder.Append("{" + urunBirimFiyati + "}" + ' ');
            stringBuilder.Append("{" + urunMiktari + "}" + ' ');
            return stringBuilder.ToString();
        }

        /// <summary>
        /// Verilen obje bu objeye eşit ise true değerini verir değilse false döndürür
        /// </summary>
        /// <param name="obj">Girdiverileri tipinden obje</param>
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (!(obj is StokKontrolData girdiVerileri)) return false;
            else return Equals(girdiVerileri);
        }

        /// <summary>
        /// Sting karşılaştırması
        /// </summary>
        public int SortByNameAscending(string name1, string name2)
        {
            return name1.CompareTo(name2);
        }

        /// <summary>
        /// Karşılastırma operantı IComparable
        /// </summary>
        public int CompareTo(StokKontrolData other)
        {
            if (other == null)
                return 1;
            else
                return this.Id.CompareTo(other.Id);
        }

        /// <summary>
        /// Her objeyenin idsini dondurur
        /// </summary>
        public override int GetHashCode()
        {
            return Id;
        }

        /// <summary>
        /// Verilen obje bu objeye eşit ise true değerini verir değilse false döndürür IEquatable
        /// </summary>
        /// <param name="other">Karşılastırlmak istenen obje Girdiverileri tipinde</param>
        public bool Equals(StokKontrolData other)
        {
            if (other == null)
                return false;
            return this.Id.Equals(other.Id);
        }

    }
}
