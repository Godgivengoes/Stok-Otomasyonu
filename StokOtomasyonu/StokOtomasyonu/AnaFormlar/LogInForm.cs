using System;
using System.Drawing;
using System.Windows.Forms;

namespace StokOtomasyonu
{
    public partial class LogInForm : Form
    {
        //  Textboxlardaki silik yazıları kontrol etmek için olan booleans
        private bool tbUsername, tbPassword;
        //  Hatırla beni CheckBox'ı true olduğunda kullanıcı ad, parola ve checkbox durumunu tutar
        private JsonConfigurationLogIn jsonLogIn = new JsonConfigurationLogIn();

        //  Kullanıcı giriş arayüzü
        public LogInForm()
        {
            //  Form içerisinde açılması için iptal edilmesi gereken ayar
            this.TopLevel = false;
            //  MainForm CurrentFormLabel bu formla alaklı bilgi ile doldurur
            MainForm.CurrentFormLabel.Text = "Kullanıcı Giriş Arayüzü";
            //  MainForm InfoLabel bu formla alaklı yapılan beklenen bilgi ile doldurur
            MainForm.InfoLabel.Text = "Kullanıcın girişi bekleniyor";

            //  Componentleri yukler
            InitializeComponent();

            //  Ayarları okur ve ona göre işlem yapar
            ReadJson();
            //  Bu formun ekranı doldurulması sağlanır
            this.Dock = DockStyle.Fill;
            //  Formu gostertir
            this.Show();
        }

        //  Kullanıcı textbox tıkladıgında ordaki gri yazıyı siler ve normal hale getirir
        //  tbUsername true diyerek kullanıcı su an burda oldugu belirtilir
        private void TextBox_Username_Enter(object sender, EventArgs e)
        {
            MainForm.InfoLabel.Text = "Kullanıcın adı düzenleniyor";
            if (tbUsername) return;
            TextBox textBox = (TextBox)sender;
            textBox.ForeColor = Color.Black;
            textBox.Text = string.Empty;
            tbUsername = true;
        }

        //  Kullanıcı textbox'dan ayrılınca;
        //  Eğer yazı yazılmamıs boş bırakılmıs ise ilk gosterilen  gri tonda yazı getirilir
        //  Eğer yazı yazılmıs ise tbUsername true kalıcak ve silinmicek
        private void TextBox_Username_Leave(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            MainForm.InfoLabel.Text = "Kullanıcın girişi bekleniyor";
            if (!string.IsNullOrWhiteSpace(textBox.Text)) return;
            textBox.ForeColor = Color.Silver;
            textBox.Text = "Kullanıcı Adı";
            tbUsername = false;
        }

        //  Kullanıcı textbox tıkladıgında ordaki gri yazıyı siler ve normal hale getirir
        //  tbPassword true diyerek kullanıcı su an burda oldugu belirtilir
        private void TextBox_Password_Enter(object sender, EventArgs e)
        {
            MainForm.InfoLabel.Text = "Parola düzenleniyor";
            if (tbPassword) return;
            TextBox textBox = (TextBox)sender;
            textBox.ForeColor = Color.Black;
            textBox.Text = string.Empty;
            textBox.PasswordChar = '●';
            tbPassword = true;
        }

        //  Kullanıcı textbox'dan ayrılınca;
        //  Eğer yazı yazılmamıs boş bırakılmıs ise ilk gosterilen  gri tonda yazı getirilir
        //  Eğer yazı yazılmıs ise tbPassword true kalıcak ve silinmicek
        private void TextBox_Password_Leave(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            MainForm.InfoLabel.Text = "Kullanıcın girişi bekleniyor";
            if (!string.IsNullOrWhiteSpace(textBox.Text)) return;
            textBox.TextAlign = HorizontalAlignment.Center;
            textBox.ForeColor = Color.Silver;
            textBox_Password.PasswordChar = '\0';
            textBox.Text = "Parola";
            tbPassword = false;
        }

        //  CheckBox durumu değiştiginde çalısır
        //  CheckBox check oldugunda ve texboxlarda bilgi var ise json olarak kaydeder
        //  Eğer CheckBox false durumuna geçerse Json dosyanı boş bilgiler yazdırılır
        private void CheckBox_Remember_Me_CheckStateChanged(object sender, EventArgs e)
        {
            CheckBox check = (CheckBox)sender;
            if (check.Checked)
            {
                if (!tbUsername) return;
                if (!tbPassword) return;
                jsonLogIn.CheckBoxCheckRead = check.Checked;
                jsonLogIn.RememberUserNameRead = textBox_Username.Text;
                jsonLogIn.RememberPassword = textBox_Password.Text;
                new JsonController("JsonRememberUsername.json", jsonLogIn);
            }
            else
            {
                new JsonController("JsonRememberUsername.json", new JsonConfigurationLogIn());
            }
        }

        //  Kullanıcı adı şifre kontrolunu başlatan fonksiyon
        //  CheckBox chec durumundaysa kullanıcı adını kaydeder
        private void Button_Log_In_Click(object sender, EventArgs e)
        {
            MainForm.InfoLabel.Text = "Giriş deneniyor...";
            if (JsonUser.Instance.CheckDictionary(textBox_Username.Text, textBox_Password.Text))
            {
                MainForm.CurrentFormLabel.Text = "NULL";
                CheckBox_Remember_Me_CheckStateChanged(checkBox_Remember_Me, null);
                MainForm.InfoLabel.Text = "Kullanıcı tanımlandı";
                this.Close();
                this.Dispose(true);
                return;
            }
            else
                MainForm.InfoLabel.Text = "Hatalı giriş";
        }

        //  MainForm.InfoLabel Textini default hale getirir
        int counTime = 0;
        //  MainForm.InfoLabel'ını modifiyer eder gorsel
        private void Timer_Label_MainForm_Info_Tick(object sender, EventArgs e)
        {
            MainForm.InfoLabel.Text += ".";
            if (MainForm.InfoLabel.Text.Contains("........"))
            {
                MainForm.InfoLabel.Text = MainForm.InfoLabel.Text.Substring(0, MainForm.InfoLabel.Text.Length - 8);
            }
            counTime++;
            if (counTime >= 50)
            {
                counTime = 0;
                MainForm.InfoLabel.Text = "Kullanıcın girişi bekleniyor";
            }
        }

        //  Göster simgesine tıklagın textBox_Password'da parola warsa saklı parolayı gosterir
        private void Button_Show_MouseDown(object sender, MouseEventArgs e)
        {
            if (!tbPassword) return;
            MainForm.InfoLabel.Text = "Şifre gözlemleniyor... Hemen unuttun değil mi :)";
            textBox_Password.PasswordChar = '\0';
        }

        //  Göster simgesinden tık kaldırılca textBox_Password'da parolayı geri saklar
        private void Button_Show_MouseUp(object sender, MouseEventArgs e)
        {
            if (!tbPassword) return;
            MainForm.InfoLabel.Text = "Kullanıcın girişi bekleniyor";
            textBox_Password.PasswordChar = '●';
        }

        private void EnterKeyLogIn(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Return))
            {
                Button_Log_In_Click(null, null);
            }
        }

        //  Form açıldıgı zaman json dosyasını okuyarak onceden kaydedilmiş bilgi varsa getirir
        private void ReadJson()
        {
            new JsonController("JsonRememberUsername.json", ref jsonLogIn);
            if (jsonLogIn.CheckBoxCheckRead)
            {
                textBox_Username.ForeColor = Color.Black;
                textBox_Username.Text = jsonLogIn.RememberUserNameRead;
                textBox_Password.ForeColor = Color.Black;
                textBox_Password.Text = jsonLogIn.RememberPassword;
                textBox_Password.PasswordChar = '●';
                checkBox_Remember_Me.Checked = jsonLogIn.CheckBoxCheckRead;
                tbUsername = true;
                tbPassword = true;
            }
        }
    }
}
