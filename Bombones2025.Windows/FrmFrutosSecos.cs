using Bombones2025.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bombones2025.Windows
{
    public partial class FrmFrutosSecos : Form
    {
        private readonly FrutoSecoServicio _frutosSecosServicio;
        public FrmFrutosSecos(FrutoSecoServicio frutoSecoServicio)
        {
            InitializeComponent();
            _frutosSecosServicio = frutoSecoServicio;
        }
    }
}
