using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokOtomasyonu
{
    //  Bağımlılıktan kurtarma
    public class DependencyInjection
    {
        public static IStokKontrolData GetStokKontrolData()
        {
            return new StokKontrolData();
        }

        public static IJsonController GetJsonController(string path)
        {
            return new JsonController(path);
        }
    }
}