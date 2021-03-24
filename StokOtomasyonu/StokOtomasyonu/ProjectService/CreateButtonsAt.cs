using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace StokOtomasyonu
{
    public class CreateButtonsAt
    {
        private readonly Panel panel = MenuForm.panel;

        private Dictionary<string, string> formAtAssembly;

        /// <summary>
        /// Verilen control unitesine formları acan buttonlar ekler
        /// </summary>
        /// <param name="control">Buttonların ekleniceği control unit</param>
        /// <param name="panel">Formların gosterilecegi panel</param>
        public CreateButtonsAt(Control control, Panel panel)
        {
            if (control == null || panel == null) return;
            this.panel = panel;
            CreateFormButtons(control);
        }

        //  Assembly GetexecutingAssemlyden projedeki codların assembly referanslarının typelarını alır
        private void FindForms()
        {
            //  Eğer dictionary oluşturulmuş ise tekrar arama yapmamak için terkeder
            if (formAtAssembly != null) return;
            formAtAssembly = new Dictionary<string, string>();

            //  Arancak type olarak Form belirlenir
            Type formType = typeof(Form);
            foreach (var item in Assembly.GetExecutingAssembly().GetTypes())
            {
                //  bulunan type belirnen type değilse devam eder
                if (!formType.IsAssignableFrom(item)) continue;
                //  bulunan type isminde Form içeriyorsa devam eder
                if (item.FullName.Contains("Form")) continue;

                //  Koşullara uygun olan type kutuphaneye eklenir
                formAtAssembly.Add(item.FullName, item.Name);
            }
        }

        //  Verilen controle projeye eklenmiş olan formları açan buttonlar ekler
        private void CreateFormButtons(Control control)
        {
            //  kütüphane oluşturulmamış ise oluşturulur
            if (formAtAssembly == null) FindForms();

            foreach (var item in formAtAssembly)
            {
                //  Boş değerler atlanır
                if (string.IsNullOrWhiteSpace(item.Key) || string.IsNullOrWhiteSpace(item.Key)) continue;
                //  Dictionarydeki key formun ismini ifade eder ve alınıp ve aralara boşluklar ekler
                var formName = BuyukHarfdenOnceBoslukEkle(item.Value);
                //  Boşlukları "_" ile değiştirir buton isimlendirmesi için
                var buttonName = formName.Replace(" ", "_");
                //  Buttonun üzerinde yazıcak olan text için düzenler
                var buttonText = formName.Replace("button_", "");
                //  Button oluşturulur
                var button = new Button
                {
                    Name = buttonName,
                    Text = buttonText,
                    Dock = DockStyle.Top,
                    FlatStyle = FlatStyle.Flat,
                    BackColor = SettingStruct.ButtonColors.ButtonColor,
                    Height = (int)(Screen.PrimaryScreen.WorkingArea.Height * 0.05f)
                };
                //  Buttonun borderinin 0 lar
                button.FlatAppearance.BorderSize = 0;
                //  Buttona tıklandğında çalışacak olan fonksiyonu ekler
                button.MouseClick += ButtonClick;
                //  Buttonu controle ekler
                control.Controls.Add(button);
                //  Button arası boşluk olcak olan panel oluşturulur ve eklenir
                Panel newPanel = new Panel
                {
                    Name = "panel_",
                    BackColor = SettingStruct.PanelColors.GapPanelColor,
                    Dock = DockStyle.Top,
                    Height = 3
                };
                //  Panele panel ekler
                control.Controls.Add(newPanel);


            }
        }

        //  Oluşturulan butona eklenen tıklama fonksiyonu
        private void ButtonClick(object sender, EventArgs e)
        {
            //  Button fonksiyonlarıı kullanabilmek için cast edilir
            Button button = sender as Button;
            //  Aynı butona Tekrar basılıyor mu kontrol etmek için
            //  Eğer tıklanan button aynı ise true değerini alır ve fonksiyon terk edilir
            if (!ButtonControl.Instance.SelectCurrent(button)) return;
            //  Buttonun isminden açılcak olan formun ismine dönüştürülür
            string buttonName = button.Name.Replace("button_", "").Replace("_", "");

            //  Dictionary null ise doldurulur
            if (formAtAssembly == null) FindForms();

            //  Dictionary döndürülür
            foreach (var item in formAtAssembly)
            {
                //  Boş strinlerle karşılırsa atlar
                if (string.IsNullOrWhiteSpace(item.Key) || string.IsNullOrWhiteSpace(item.Key)) continue;
                //  karşılaşılan form adı oluşturduğumuz button adına eşit ise
                if (item.Value == buttonName)
                {
                    //  Oluşturulan dictionaryden karşılık gelen string id(key) alınır ve adressteki Type'a dönüştürülür.
                    Type t = Type.GetType(item.Key);
                    //  Eğer birşey bulunamazsa sonraki işleme geçtirir
                    if (t == null) continue;

                    //  Eğer formların açık olduğu controlde başka bir form açık ise onu kapatır
                    //  Activator ile verdiğimiz refansı kullanarak formu oluşturur
                    //  Değil ise sadece formu oluşturur
                    if (panel.Controls.Count != 0)
                    {
                        foreach (var form in panel.Controls)
                        {
                            if (form is Form formName)
                            {
                                if (formName.Name != item.Value)
                                {
                                    formName.Close();

                                    new FormControl((Form)Activator.CreateInstance(t), panel);

                                    MainForm.CurrentFormLabel.Text = buttonName;
                                }
                            }
                        }
                    }
                    else
                    {
                        MainForm.CurrentFormLabel.Text = buttonName;

                        new FormControl((Form)Activator.CreateInstance(t), panel);
                    }
                }
            }
        }

        //  Verilen string'e Buyuk harflerden önce boşluk ekler
        private string BuyukHarfdenOnceBoslukEkle(string str)
        {
            if (string.IsNullOrWhiteSpace(str))
                return "";
            StringBuilder newStr = new StringBuilder(str.Length * 2);
            string button = "button_";
            newStr.Append(button);
            newStr.Append(str[0]);
            for (int i = 1; i < str.Length; i++)
            {
                if (char.IsUpper(str[i]) && str[i - 1] != ' ')
                    newStr.Append(' ');
                newStr.Append(str[i]);
            }
            return newStr.ToString();
        }
    }
}
