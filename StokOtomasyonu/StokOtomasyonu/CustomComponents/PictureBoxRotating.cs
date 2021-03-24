using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokOtomasyonu
{
    public partial class PictureBoxRotating : Component
    {
        public PictureBoxRotating()
        {
            InitializeComponent();
        }

        public PictureBoxRotating(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
