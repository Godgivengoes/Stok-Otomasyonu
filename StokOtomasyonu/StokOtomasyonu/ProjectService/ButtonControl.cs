using System;
using System.Drawing;
using System.Windows.Forms;

namespace StokOtomasyonu
{
    public sealed class ButtonControl
    {
        private static readonly Lazy<ButtonControl> instance = new Lazy<ButtonControl>(() => new ButtonControl());
        /// <summary>
        /// Şeçili button'u kaydeder ve şeçili buttonu değiştirir
        /// Başka button şeçildiğinde önceki butonu eski haline getirir
        /// </summary>
        public static ButtonControl Instance { get { return instance.Value; } }
        private ButtonControl() { }

        //  Seçili olan button
        private Button ActiveButton;
        //  Seçili olan buttonun ilk rengi
        private Color ActiveButtonColor;

        /// <summary>
        /// AKtif seçili buttonu kaydeder ve rengini değiştir
        /// </summary>
        /// <param name="button">Istenilen button</param>
        /// <returns>Null veya aynı buttonda false donderir</returns>
        public bool SelectCurrent(Button button)
        {
            if (button == null) return false;
            if (ActiveButtonColor.Equals(button)) return false;

            if (ActiveButton != null)
                ActiveButton.BackColor = ActiveButtonColor;
            ActiveButton = button;
            ActiveButtonColor = button.BackColor;
            button.BackColor = SettingStruct.ButtonColors.ActiveButtonColor;

            return true;
        }
    }
}
