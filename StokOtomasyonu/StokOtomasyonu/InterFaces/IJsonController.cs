using System.Collections.Generic;

namespace StokOtomasyonu
{
    public interface IJsonController
    {
        List<T> GetList<T>();
        Dictionary<string, string> GetUserAccounts(string path);
        void SetList<T>(IList<T> list);
    }
}