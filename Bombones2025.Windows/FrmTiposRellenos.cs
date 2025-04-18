using Bombones2025.Entidades;
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
    public partial class FrmTiposRellenos : Form
    {

        private readonly TipoRellenoServicio _tiposRellenosServicio;
        private List<TipoRelleno> _tiposRellenos = new();
        public FrmTiposRellenos(TipoRellenoServicio tipoRellenoServicio)
        {
            InitializeComponent();
            _tiposRellenosServicio = tipoRellenoServicio;
        }

        private void FrmTiposRellenos_Load(object sender, EventArgs e)
        {
            //desarrolloaca
        }
    }
}
