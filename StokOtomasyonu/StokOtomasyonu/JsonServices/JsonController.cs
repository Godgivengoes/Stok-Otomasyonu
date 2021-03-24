using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace StokOtomasyonu
{
    public class JsonController : IJsonController
    {
        //  json dosyandan okunan string
        private string jsonString = string.Empty;
        //  Kullanıcı hesaplarını tutan json dosyası
        private readonly string path;

        /// <summary>
        /// JsonController'ın fonksiyonlarını kullanmak için
        /// </summary>
        private JsonController() { }

        //  ulaşılması istenmeyen constructor
        //  json dosyasını okur
        public JsonController(string path)
        {
            this.path = path;
            //  Eğer dosya yoksa uyarır ve methodu terkeder
            if (!File.Exists(path))
            {
                MessageBox.Show($"Couldn't find at {path}");
                return;
            }

            try
            {
                //  Json dosyasını okumayı dener
                this.jsonString = File.ReadAllText(path);
            }
            catch (Exception e)
            {
                //  Json dosyasını okumayı başaramassa ekrana hata mesajını verir
                //  methodu terkeder
                MessageBox.Show($"failed to open file from {path}!\n\n" +
                                $"{e.Message}\n\n" +
                                $"{e.StackTrace}\n\n");
                return;
            }
        }

        /// <summary>
        /// Json dosyasını okur
        /// </summary>
        /// <param name="path">Dosyanın yolu</param>
        /// <param name="obj">JsonConfigurationLogIn ref objesi</param>
        public JsonController(string path, ref JsonConfigurationLogIn obj) : this(path)
        {
            //  verilen obje null ise yenisini oluşturur
            obj = obj ?? new JsonConfigurationLogIn();

            try
            {
                //  Eğer json dosyası okunamamıs jsonString de değer yok ise
                //  JsonConfigurationLogIn'ın default valuelerinden json dosyası olusturur
                //  Methodu terk eder
                if (string.IsNullOrWhiteSpace(jsonString))
                {
                    //  Değerler string'e çevrilir
                    var jsonstring = JsonConvert.SerializeObject(obj);
                    //  Dosya yok ise oluşturur ve değerleri yazar
                    File.WriteAllText(path, jsonstring);
                    return;
                }
                //  Okunan string değerlerini objeye uygun hale çevirir
                obj = JsonConvert.DeserializeObject<JsonConfigurationLogIn>(this.jsonString);
            }
            catch (Exception e)
            {
                //  Butu yukardaki adımlarda başarısız olursa hata mesajını gösterir
                MessageBox.Show($"failed to deserialize!\n\n" +
                                $"{e.Message}\n\n" +
                                $"{e.StackTrace}\n\n");
            }
        }

        /// <summary>
        /// Okunan json dosyasını okur dictionarye çevirir
        /// </summary>
        /// <param name="path">Dosyanın yolu</param>
        /// <param name="combination">Dictionary</param>
        public JsonController(string path, ref Dictionary<string, string> combination) : this(path)
        {
            //  Eğer dosya okunamamışsa methodu terket
            if (string.IsNullOrWhiteSpace(jsonString)) return;

            //  verilen obje null ise uyarı verir ve methodu terkeder
            if (combination == null)
            {
                MessageBox.Show($"{this.GetType()} had null Dictionary!!!");
                return;
            }

            try
            {
                //  okunan dosyayı dictionarye çevirir
                combination = JsonConvert.DeserializeObject<Dictionary<string, string>>(jsonString);
            }
            catch (Exception e)
            {
                //  Butu yukardaki adımlarda başarısız olursa hata mesajını gösterir
                MessageBox.Show($"failed to deserialize!\n\n" +
                                $"{e.Message}\n\n" +
                                $"{e.StackTrace}\n\n");
            }
        }

        /// <summary>
        /// Json dosyasını yazdırır
        /// </summary>
        /// <param name="path">Dosyanın yolu</param>
        /// <param name="combination">yazdırılma istenen Dictionary<string, string></param>
        public JsonController(string path, Dictionary<string, string> combination) : this(path, ref combination)
        {
            //  verilen obje null ise uyarı verir ve methodu terkeder
            if (combination == null)
            {
                MessageBox.Show($"{this.GetType()} had null Dictionary!!!");
                return;
            }

            try
            {
                if (!string.IsNullOrWhiteSpace(jsonString))
                {
                    File.WriteAllText(path, jsonString);
                }
            }
            catch (Exception e)
            {
                //  Butu yukardaki adımlarda başarısız olursa hata mesajını gösterir
                MessageBox.Show($"from {combination.GetType()} failed to serialize!\n\n" +
                                $"{e.Message}\n\n" +
                                $"{e.StackTrace}\n\n");
            }
        }

        /// <summary>
        /// Json dosyasına yazdırır
        /// </summary>
        /// <param name="path">Dosyanın yolu</param>
        /// <param name="obj">yazdırılmak istenen obje</param>
        public JsonController(string path, JsonConfigurationLogIn obj)
        {
            //  verilen obje null ise uyarı verir ve methodu terkeder
            if (obj == null)
            {
                MessageBox.Show($"{this.GetType()} had null {obj.GetType()}!!!");
                return;
            }

            try
            {
                //  Objeyi string'e çevirir
                var json = JsonConvert.SerializeObject(obj);
                //  Dosya yok ise oluşturur ve değerleri yazar
                File.WriteAllText(path, json);
            }
            catch (Exception e)
            {
                //  Butu yukardaki adımlarda başarısız olursa hata mesajını gösterir
                MessageBox.Show($"from {obj.GetType()} failed to serialize!\n\n" +
                                $"{e.Message}\n\n" +
                                $"{e.StackTrace}\n\n");
            }
        }

        /// <summary>
        /// Json dosyasını okuyarak username account ciftinin dictionarysini verir
        /// </summary>
        /// <returns>Dictionary&lt;Key: Username, Value: Password&gt;</returns>
        public Dictionary<string, string> GetUserAccounts(string path)
        {
            //  Json dosyasını okur
            this.jsonString = File.ReadAllText(path);
            //  Okunan dosyayı dictionary haline getirir
            Dictionary<string, string> valuePairs = JsonConvert.DeserializeObject<Dictionary<string, string>>(this.jsonString);
            //  Dictionaryi döndürür
            return valuePairs;
        }

        /// <summary>
        /// Verilen tipte listeyi okuyup o tip listeyi donderir
        /// </summary>
        public List<T> GetList<T>()
        {
            //  Json dosyasını okur
            this.jsonString = File.ReadAllText(path);
            //  Okunan string değerlerini listeye uygun hale çevirir
            List<T> list = JsonConvert.DeserializeObject<List<T>>(this.jsonString);
            return list;
        }

        /// <summary>
        /// Girilen tipte listeyi json dosyası olarak kaydeder
        /// </summary>
        public void SetList<T>(IList<T> list)
        {
            //  Objeyi string'e çevirir
            var json = JsonConvert.SerializeObject(list);
            //  Dosya yok ise oluşturur ve değerleri yazar
            File.WriteAllText(path, json);
        }
    }
}
