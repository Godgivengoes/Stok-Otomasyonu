using System.Windows.Forms;

namespace StokOtomasyonu
{
    public class FormControl
    {
        private readonly Control control;

        /// <summary>
        /// Verilen formu duzenler
        /// </summary>
        public FormControl(Form form)
        {
            if (form == null) return;
            DesignForm(form.Controls);
        }

        /// <summary>
        /// Verilen formu duzenleyerek verin kontrol unitesi icinde acar
        /// </summary>
        public FormControl(Form form, Control control) : this(form)
        {
            if (form == null || control == null) return;
            this.control = control;
            //  Form içerisinde açılması için iptal edilmesi gereken ayar
            form.TopLevel = false;

            //  Bu formun dock olgu yeri doldurmasını sağlar
            form.Dock = DockStyle.Fill;
            //  Formu kontrol unitesine ekler
            this.control.Controls.Add(form);
            //  Formu gostertir
            form.Show();
        }

        //  Form dizayn
        private void DesignForm(Control.ControlCollection control)
        {
            //  Verilen control unitesinin icindeki objeleri dondurur
            for (int i = 0; i < control.Count; i++)
            {
                //  Control panel ise
                if (control[i] is Panel panel)
                {
                    //  ve child objesi var ise recursive olarak bu methodu kullan
                    if (panel.Controls.Count != 0)
                        DesignForm(panel.Controls);
                    DesignPanel(panel);
                    //  iş bitince diğer kosulları kontrol etme
                    continue;
                }
                //  Control button ise
                if (control[i] is Button button)
                {
                    //  ve child objesi var ise recursive olarak bu methodu kullan
                    if (button.Controls.Count != 0)
                        DesignForm(button.Controls);
                    DesignButton(button);
                    //  iş bitince diğer kosulları kontrol etme
                    continue;
                }
                //  Control textbox ise
                if (control[i] is TextBox textBox)
                {
                    //  ve child objesi var ise recursive olarak bu methodu kullan
                    if (textBox.Controls.Count != 0)
                        DesignForm(textBox.Controls);
                    DesignTextBox(textBox);
                    //  iş bitince diğer kosulları kontrol etme
                    continue;
                }
            }
        }

        //  Panel ismindeki taglere gore duzenler
        private void DesignPanel(Panel panel)
        {
            //  panelin isimlerini ayırır
            var controlName = panel.Name.Split('_');

            //  her tag kontrol ederek ona gore sekillendirir
            for (int i = 0; i < controlName.Length; i++)
            {
                ControlPanelTag(panel, controlName[i]);
            }
        }

        //  Panel dizayn işlemi
        private void ControlPanelTag(Panel panel, string key)
        {
            switch (key)
            {
                case "panel":
                    panel.BackColor = SettingStruct.PanelColors.PanelColor;
                    break;
            }
        }

        //  Button ismindeki taglere gore duzenler
        private void DesignButton(Button button)
        {
            //  buttonun isimlerini ayırır
            var controlName = button.Name.Split('_');

            //  her tag kontrol ederek ona gore sekillendirir
            for (int i = 0; i < controlName.Length; i++)
            {
                ControlTagButton(button, controlName[i]);
            }
        }

        //  Button dizayn işlemi
        private void ControlTagButton(Button button, string key)
        {
            switch (key)
            {
                case "":
                    button.FlatStyle = FlatStyle.Flat;
                    button.FlatAppearance.BorderSize = 0;
                    break;
            }
        }

        //  TextBox ismindeki taglere gore duzenler
        private void DesignTextBox(TextBox textBox)
        {
            //  TextBoxın isimlerini ayırır
            var controlName = textBox.Name.Split('_');

            //  her tag kontrol ederek ona gore sekillendirir
            for (int i = 0; i < controlName.Length; i++)
            {
                ControlTagTextBox(textBox, controlName[i]);
            }
        }

        //  TextBox dizayn işlemi
        private void ControlTagTextBox(TextBox textBox, string key)
        {
            switch (key)
            {
                case "":
                    textBox.Text = "bunun olmaması gerekiyordu!";
                    break;
            }
        }
    }
}