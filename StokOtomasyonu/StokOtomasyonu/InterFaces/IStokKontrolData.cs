using System;
using System.Collections.Generic;

namespace StokOtomasyonu
{
    public interface IStokKontrolData
    {
        DateTime EnSonDegistirme { get; set; }
        int Id { get; set; }
        string UrunAdi { get; set; }
        float UrunBirimFiyati { get; set; }
        int UrunMiktari { get; set; }

        int CompareTo(StokKontrolData other);
        bool Equals(object obj);
        bool Equals(StokKontrolData other);
        int GetHashCode();
        int SortByNameAscending(string name1, string name2);
        string ToString();
    }
}