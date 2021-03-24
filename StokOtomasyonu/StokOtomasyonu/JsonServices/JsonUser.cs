using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace StokOtomasyonu
{
    /// <summary>
    /// Kullanıcı Paralo için json aracısı
    /// </summary>
    internal sealed class JsonUser : JsonController, IDisposable
    {
        //  Bu obje dispose oldu mu?
        public bool DisposedValue { get; private set; }
        //  Kullanıcı adı
        public string Username { get; private set; }

        //  Kullanıcı bilgilerini tutan json dosyasının adı
        private const string path = "JsonUserDictionary.json";
        //  Kullanıcı adı parola kombinasyonunu tutan dictionary
        private static Dictionary<string, string> combination = new Dictionary<string, string>();

        //  Bu nesnenin kendini sakladığı field
        static JsonUser instance = null;
        //  Bu nesne kendini oluşturunca çalıştırdığı constructor
        //  Base json constructorlerini çalıştırır
        private JsonUser() : base(path, ref combination)
        {
            //  Bu objenin dispose olmadıgını belirtir
            DisposedValue = false;

            //  Eğer veri bulunamassa kendini dispose et
            if (combination == null)
            {
                this.Dispose(true);
            }
        }

        //  Singleton pattern : read-only
        //  Eğere bu obje oluşmamıssa oluşturup kendi değeri gönderir
        public static JsonUser Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new JsonUser();
                }
                return instance;
            }
        }

        //  Verilen kullanıcı adı, paraloyı dictinaryden karsılastırır
        public bool CheckDictionary(string userName, string password)
        {
            //  Dictionarye kullanıcı adı parola kombinasyonlarını ekler
            if (!combination.Any())
                combination = GetUserAccounts(path);

            foreach (var item in combination)
            {
                if (item.Key.Equals(userName) && item.Value.Equals(password))
                {
                    //  eğer eşlesen kullanıcı adı parola kombinasyonu varsa true donderir
                    combination.Clear();
                    this.Username = item.Key;
                    return true;
                }
            }
            //  eğer eşlesen kullanıcı adı parola kombinasyonu yoksa false donderir ve uyarır
            MessageBox.Show("Hatalı kullanıcı adı, parola kombinasyonu!");
            return false;
        }

        //  public Dispose method
        public void Dispose()
        {
            Dispose(disposing: false);
            GC.SuppressFinalize(this);
        }

        //  Bu objeyi elden cıkartmak için olan fonksiyon
        private void Dispose(bool disposing)
        {
            if (!DisposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects)
                }

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                DisposedValue = true;

                combination = null;
                JsonUser.instance = null;
            }
        }

        // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
        // ~JsonUser()
        // {
        //     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        //     Dispose(disposing: false);
        // }

        void IDisposable.Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
