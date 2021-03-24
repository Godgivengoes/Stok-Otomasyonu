using System;
using System.Drawing;
using System.Windows.Forms;

namespace StokOtomasyonu
{
    public partial class MainForm : Form
    {
        //  Mouse'a tıklandığında pozisyonunu tutan alan
        private Point Start;
        //  Paneli genişletip daraltırken diger hareketleri kontrol etmek için olan booleanlar
        private bool SlideLeft, SlideRight, SlideDown, SlideUp;

        //  Bilgi vermekte kullanılacak olan label
        public static Label InfoLabel;
        //  Hangi kısımda olduğunu belirtmek için olan label
        public static Label CurrentFormLabel;

        //  Ana Form
        public MainForm()
        {
            //  Klasik windows border'ını kapatır.
            this.FormBorderStyle = FormBorderStyle.None;
            //  Form yüklendiği zaman ekranın ortasına hizalar
            this.StartPosition = FormStartPosition.CenterScreen;

            //  Komponentleri yükler
            InitializeComponent();

            //  Bu formun labelarını static alana ekler
            InfoLabel = label_Info;
            CurrentFormLabel = label_Form_Info;

            //  MouseDown eventi trigger olduğunda mouse pozisyonunu kaydeden fonksiyon ekler ekler
            panel_Top.MouseDown += MouseDownFormMove;
            label_Form_Info.MouseDown += MouseDownFormMove;
            label_Project_Name.MouseDown += MouseDownFormMove;

            //  panel_Top panelinin MouseMove eventi trigger olduğunda formu haraket ettiren delegate ekler
            panel_Top.MouseMove += MouseMoveFormMove;
            label_Form_Info.MouseMove += MouseMoveFormMove;
            label_Project_Name.MouseMove += MouseMoveFormMove;

            //  Form'un botunda değişiklik odugu zaman çalışır.
            this.SizeChanged += delegate (object sender, EventArgs e)
            {
                //  Form tam ekran olduğu zaman sadece çalışma alınının boyutunu verir taşmaması için
                this.MaximumSize = Screen.PrimaryScreen.WorkingArea.Size;
            };

            //  MainForm yuklendigi zaman çalışcak olan evente bu delegate'i ekler
            this.Load += delegate (object sender, EventArgs e)
            {
                //  Formun daralabileceği minumum boyut
                this.MinimumSize = new Size(800, 600);
                panel_Form_Show.Controls.Add(new LogInForm());
            };

            //  LogInForm kapanana kadar kontrol çalışır
            Timer timer_LogWait = new Timer()
            {
                Interval = 100,
                Enabled = true
            };

            //  Her tikinde çalışcak olcak olan delegate
            timer_LogWait.Tick += delegate (object sender, EventArgs e)
            {
                //  LogInForm kapandığı anlamına gelir
                //  Timer durdurur ve MenuFormu getirir
                if (panel_Form_Show.Controls.Count == 0)
                {
                    var timer = (Timer)sender;
                    this.Width = 1280;
                    this.Height = 720;
                    this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Size.Width - Width) / 2, (Screen.PrimaryScreen.WorkingArea.Size.Height - Height) / 2);
                    timer.Stop();
                    timer.Dispose();
                    panel_Form_Show.Controls.Add(new MenuForm());
                    JsonUser.Instance.Dispose();
                }
            };
        }

        //  button_Windows_State butonunun click eventinin fonksiyonu
        //  buttona tıklandığı zaman bu formu genişletip - daraltır
        private void Button_Windows_State_Click(object sender, EventArgs e)
        {
            //  objeyi Button olarak castleyerek Button özelliklerini kullanma imkanı verir
            var btn = (Button)sender;
            //  Buttonun adı genişlet ise formWindowState'i Maximized olarak ayarlayarak formu genişletir
            if (btn.Text == "genişlet")
            {
                //  Buttonun adını daralt yaparak yapacağı işlevi belirtilir
                btn.Text = "daralt";
                //  Form'u küçültür
                this.WindowState = FormWindowState.Maximized;
            }
            //  Buttonun adı genişlet değil ise formWindowState'i Normal olarak ayarlayarak formu eski haline getirir
            else
            {
                //  Buttonun adını daralt yaparak yapacağı işlevi belirtilir
                btn.Text = "genişlet";
                //  Form'u eski haline getirir
                this.WindowState = FormWindowState.Normal;
            }
        }

        //  trigger olduğunda mouse pozisyonunu kaydeder
        private void MouseDownFormMove(object sender, MouseEventArgs e) => Start = e.Location;

        //  trigger olduğunda formu haraket ettirir
        private void MouseMoveFormMove(object sender, MouseEventArgs e)
        {
            //  Kaydırma yapılıyorsa hareket yaptırılmaz
            if (SlideRight || SlideLeft || SlideDown || SlideUp) return;
            //  Eğer bu event triggerlandı mouse click sol ise form'u hareket ettir
            if (e.Button == MouseButtons.Left)
            {
                //  Eğer bu event gerçekleşirken form genişlemişse daraltır
                if (this.WindowState == FormWindowState.Maximized)
                {
                    //  Button_Windows_State_Click'daki işlemleri yapar
                    button_Windows_State.Text = "genişlet";
                    //  Form'u eski haline getir
                    WindowState = FormWindowState.Normal;
                }
                //  Formun posizyonunu farenin hareketine konumuna göre değiştirir
                this.Location = new Point(this.Location.X - (Start.X - e.X), this.Location.Y - (Start.Y - e.Y));
            }
        }

        //  button_Minimize butonunun click eventinin fonksiyonu
        //  buttona tıklandığı zaman bu formu küçültür
        private void Button_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //  button_Close butonunun click eventinin fonksiyonu
        //  buttona tıklandığı zaman bu formu kapatır ve aplikasyonu kapatır
        private void Button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        //  Label_Clock text'ini Date.Now ile düzenlenmiş string yapar her saniye
        //  Label_Clock'un Harf boyutu değişmesi durumunda pozisyonunu ayarlar
        private void Timer_Clock_Tick(object sender, EventArgs e)
        {
            label_Clock.Text = DateTime.Now.ToString("dd/MM/yyyy  HH:mm:ss");
            label_Clock.Location = new Point(panel_Bottom.Width - label_Clock.Width - 5, label_Clock.Location.Y);
        }

        //  En sağdaki panele tıklandıgında SlideRight'ı true yaparak saga dogru kaydırıldıgını belirtir
        private void Panel_Resize_Right_MouseDown(object sender, MouseEventArgs e)
        {
            SlideRight = true;
        }

        //  Mouse hareketiyle Formu yatay eksende enini genişletir veya küçültür
        private void Panel_Resize_Right_MouseMove(object sender, MouseEventArgs e)
        {
            //  panele tıklanmadıysa hareket yapmasını engeller
            if (!SlideRight) return;
            //  minumum genişliğe ulaşıldıysa ve hareket negatif yonde ise hareketi engeller
            if (this.Width == this.MinimumSize.Width && e.X < 0) return;
            //  Form'u mouse hareketi kadar genişlet
            this.Width += e.X;
        }

        //  Yatay eksendeki hareket bittiğini belirtir
        private void Panel_Resize_Right_MouseUp(object sender, MouseEventArgs e)
        {
            SlideRight = false;
        }

        //  En soldaki panele tıklandıgında SlideLeft'ı true yaparak sola dogru kaydırıldıgını belirtir
        //  Form sola doğru genişleme yapmadığından dolayı sağa doğru genişletilirken sola hareket ettirilir
        private void Panel_Resize_Left_MouseDown(object sender, MouseEventArgs e)
        {
            SlideLeft = true;
            //  Mouse'un başlangıç noktasını kaydeder
            Start = e.Location;
        }

        //  Mouse hareketiyle Formu yatay eksende enini genişletir veya küçültür
        private void Panel_Resize_Left_MouseMove(object sender, MouseEventArgs e)
        {
            //  panele tıklanmadıysa hareket yapmasını engeller
            if (!SlideLeft) return;
            //  minumum genişliğe ulaşıldıysa ve hareket pozitif yonde ise hareketi engeller
            if (this.Width == 800 && e.X > 0) return;
            //  Form'u mouse hareketi kadar genişlet
            this.Width -= e.X;
            //  Sola doğru genişliyormuş gibi göstermek için sola kaydır
            this.Location = new Point(this.Location.X - (Start.X - e.X), this.Location.Y);
        }

        //  Yatay eksendeki hareket bittiğini belirtir
        private void Panel_Resize_Left_MouseUp(object sender, MouseEventArgs e)
        {
            SlideLeft = false;
        }

        //  En alttaki panele tıklandıgında SlideDown'ı true yaparak aşağı doğru dogru kaydırıldıgını belirtir
        private void Panel_Resize_Bottom_MouseDown(object sender, MouseEventArgs e)
        {
            SlideDown = true;
        }

        //  Mouse hareketiyle Formu dikey eksende boyunu genişletir veya küçültür
        private void Panel_Resize_Bottom_MouseMove(object sender, MouseEventArgs e)
        {
            //  panele tıklanmadıysa hareket yapmasını engeller
            if (!SlideDown) return;
            //  Form'u mouse hareketi kadar genişlet
            this.Height += e.Y;
        }

        //  Dikey eksendeki hareket bittiğini belirtir
        private void Panel_Resize_Bottom_MouseUp(object sender, MouseEventArgs e)
        {
            SlideDown = false;
        }

        //  En üsteki panele tıklandıgında SlideUp'ı true yaparak aşağı doğru dogru kaydırıldıgını belirtir
        //  Form yukarı doğru genişleme yapmadığından dolayı aşağı doğru genişletilirken yukarı hareket ettirilir
        private void Panel_Resize_Top_MouseDown(object sender, MouseEventArgs e)
        {
            SlideUp = true;
            //  Mouse'un başlangıç noktasını kaydeder
            Start = e.Location;
        }

        //  Mouse hareketiyle Formu dikey eksende boyunu genişletir veya küçültür
        private void Panel_Resize_Top_MouseMove(object sender, MouseEventArgs e)
        {
            //  panele tıklanmadıysa hareket yapmasını engeller
            if (!SlideUp) return;
            //  minumum genişliğe ulaşıldıysa ve hareket pozitif yonde ise hareketi engeller
            if (this.Height == 600 && e.Y > 0) return;
            //  Form'u mouse hareketi kadar genişlet
            this.Height -= e.Y;
            //  Yukarı doğru genişliyormuş gibi göstermek için yukarı kaydır
            this.Location = new Point(this.Location.X, this.Location.Y - (Start.Y - e.Y));
        }

        //  Dikey eksendeki hareket bittiğini belirtir
        private void Panel_Resize_Top_MouseUp(object sender, MouseEventArgs e)
        {
            SlideUp = false;
        }

    }
}
