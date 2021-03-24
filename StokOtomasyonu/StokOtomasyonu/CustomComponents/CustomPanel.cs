using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokOtomasyonu
{
    public partial class CustomPanel : PictureBox
    {
        private readonly Timer rotator;
        private float rotateAngle = 1;
        private float incrementAngle = 1;

        public float RotateAngle { get => rotateAngle; set => rotateAngle = value; }
        public float IncrementAngle { get => incrementAngle; set => incrementAngle = value; }

        public CustomPanel()
        {
            InitializeComponent();

            rotator = new Timer()
            {
                Interval = 100,
                Enabled = true
            };
            rotator.Tick += Rotator_Tick;

            this.DoubleBuffered = true;
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
        }

        private void Rotator_Tick(object sender, EventArgs e)
        {
            RotateAngle += incrementAngle;
            RotateAngle %= 360;
            if (Image != null)
            {
                Image = RotateImage(Image, new PointF(Image.Width / 2, Image.Height / 2), incrementAngle);
            }

            Invalidate();
        }

        public CustomPanel(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams createParams = base.CreateParams;
                createParams.ExStyle |= 0x00000020; // WS_EX_TRANSPARENT
                return createParams;
            }
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            // Do not paint background.
        }

        private Bitmap RotateImage(Image image, PointF offset, float angle)
        {
            if (image == null)
                throw new ArgumentNullException("image");

            //create a new empty bitmap to hold rotated image
            Bitmap rotatedBmp = new Bitmap(image.Width, image.Height);
            rotatedBmp.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            //make a graphics object from the empty bitmap
            Graphics g = Graphics.FromImage(rotatedBmp);

            //Put the rotation point in the center of the image
            g.TranslateTransform(offset.X, offset.Y);

            //rotate the image
            g.RotateTransform(angle);

            //move the image back
            g.TranslateTransform(-offset.X, -offset.Y);

            //draw passed in image onto graphics object
            g.DrawImage(image, new PointF(0, 0));

            return rotatedBmp;
        }
    }
}
