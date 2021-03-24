using System.Windows.Forms;

namespace StokOtomasyonu
{
    public partial class MenuForm : Form
    {
        public static Panel panel;
        private readonly string[] menuFormString = { "Anasayfa", "Kullanıcı: " };

        public MenuForm()
        {
            panel = panel_Form_Show;
            //  Form içerisinde açılması için iptal edilmesi gereken ayar
            this.TopLevel = false;
            //  MainForm CurrentFormLabel bu formla alaklı bilgi ile doldurur
            MainForm.CurrentFormLabel.Text = menuFormString[0];
            //  MainForm InfoLabel bu formla alaklı yapılan beklenen bilgi ile doldurur
            MainForm.InfoLabel.Text = menuFormString[1] + JsonUser.Instance.Username;

            //  Componentleri yukler
            InitializeComponent();

            //  Bu formun ekranı doldurulması sağlanır
            this.Dock = DockStyle.Fill;
            //  Formu gostertir
            this.Show();

            //  buttonları oluşturup bu forma ekler
            new CreateButtonsAt(panel_Button_Container, panel_Form_Show);

        }
    }
}
