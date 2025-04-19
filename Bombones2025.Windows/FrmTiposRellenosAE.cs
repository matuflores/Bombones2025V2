using Bombones2025.Entidades;
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
    public partial class FrmTiposRellenosAE : Form
    {
        private TipoRelleno? tipoRelleno;
        public FrmTiposRellenosAE()
        {
            InitializeComponent();
        }

        public TipoRelleno? GetTipoRelleno()
        {
            return tipoRelleno;
        }
    }
}
