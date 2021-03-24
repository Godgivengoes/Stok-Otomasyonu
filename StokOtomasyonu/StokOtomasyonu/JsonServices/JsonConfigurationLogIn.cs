using Newtonsoft.Json;

namespace StokOtomasyonu
{
    /// <summary>
    /// LogInForm'un kullanıcı adı, paralo, checkbox durumlarını json donusmek uzere tutan class
    /// </summary>
    public class JsonConfigurationLogIn
    {
        //-Bu fielddakiler default value tasır
        private bool checkBoxCheckRead = false;
        private string rememberUserNameRead = string.Empty;
        private string rememberPassword = string.Empty;
        //  CheckBox boolean
        [JsonProperty("CheckBoxCheckRead")]
        public bool CheckBoxCheckRead { get => checkBoxCheckRead; set => checkBoxCheckRead = value; }
        //  Kullanıcı adı
        [JsonProperty("rememberusernameRead")]
        public string RememberUserNameRead { get => rememberUserNameRead; set => rememberUserNameRead = value; }
        //  Parola
        [JsonProperty("rememberpassword")]
        public string RememberPassword { get => rememberPassword; set => rememberPassword = value; }
    }
}
