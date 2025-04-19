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
            _tiposRellenos = _tiposRellenosServicio.GetTipoRellenos();
            MostrarDatosEnGrilla();
        }

        private void MostrarDatosEnGrilla()
        {
            dgvTiposRellenos.Rows.Clear();
            foreach (var tipoRelleno in _tiposRellenos)
            {
                DataGridViewRow r = new DataGridViewRow();
                r.CreateCells(dgvTiposRellenos);
                SetearFila(r, tipoRelleno);
                AgregarFila(r);

            }
        }

        private void AgregarFila(DataGridViewRow r)
        {
            dgvTiposRellenos.Rows.Add(r);
        }

        private void SetearFila(DataGridViewRow r, TipoRelleno tipoRelleno)
        {
            r.Cells[0].Value = tipoRelleno.TipoRellenoId;
            r.Cells[1].Value = tipoRelleno.NombreTipoRelleno;
            r.Tag = tipoRelleno;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmTiposRellenosAE frm = new FrmTiposRellenosAE() { Text= "NUEVO TIPO DE RELLENO"};
            DialogResult dr=frm.ShowDialog(this);

            if (dr == DialogResult.Cancel)
            {
                return;
            }

            TipoRelleno? tipoRelleno = frm.GetTipoRelleno();

            if (tipoRelleno==null)
            {
                return;
            }

            if (!_tiposRellenosServicio.Existe(tipoRelleno))
            {
                _tiposRellenosServicio.Guardar(tipoRelleno);
            }
        }
    }
}
