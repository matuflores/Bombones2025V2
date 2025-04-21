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
    public partial class FrmTiposChocolates : Form
    {
        private readonly TipoChocolateServicio _tipoChocolateServicio;
        private List<TipoChocolate> _tiposChocolates = new();

        public FrmTiposChocolates(TipoChocolateServicio tipoChocolateServicio)
        {
            InitializeComponent();
            _tipoChocolateServicio = tipoChocolateServicio;
        }

        private void FrmTiposChocolates_Load(object sender, EventArgs e)
        {
            _tiposChocolates = _tipoChocolateServicio.GetTipoCholates();
            MostrarDatosEnGrilla();
        }

        private void MostrarDatosEnGrilla()
        {
            dgvTiposChocolates.Rows.Clear();
            foreach (var tipoChocolate in _tiposChocolates)
            {
                DataGridViewRow r = new DataGridViewRow();
                r.CreateCells(dgvTiposChocolates);
                SetearFila(r, tipoChocolate);
                AgregarFila(r);

            }
        }

        private void AgregarFila(DataGridViewRow r)
        {
            dgvTiposChocolates.Rows.Add(r);
        }

        private void SetearFila(DataGridViewRow r, TipoChocolate tipoChocolate)
        {
            r.Cells[0].Value = tipoChocolate.TipoChocolateId;
            r.Cells[1].Value = tipoChocolate.NombreTipoChocolate;
            r.Tag = tipoChocolate;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmTiposChocolatesAE frm = new FrmTiposChocolatesAE() { Text = "NUEVO TIPO DE CHOCOLATE" };
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel) return;

            TipoChocolate? tipoChocolate = frm.GetTipoChocolate();

            if (tipoChocolate is null)
            {
                return;
            }

            if (!_tipoChocolateServicio.Existe(tipoChocolate))
            {
                _tipoChocolateServicio.Guardar(tipoChocolate);
                DataGridViewRow r = new DataGridViewRow();
                r.CreateCells(dgvTiposChocolates);
                SetearFila(r, tipoChocolate);
                AgregarFila(r);
                MessageBox.Show("Tipo de chocolate agregado",
                    "Mensaje",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Tipo de chocolate existente",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (dgvTiposChocolates.SelectedRows.Count == 0)
            {
                return;
            }
            var r = dgvTiposChocolates.SelectedRows[0];
            TipoChocolate tipoChocolateBorrar = (TipoChocolate)r.Tag!;
            DialogResult dr = MessageBox.Show($"¿QUIERES ELIMINAR {tipoChocolateBorrar.NombreTipoChocolate}?",
                "CONFIRMAR ELIMINACION",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);

            if (dr == DialogResult.No) return;

            _tipoChocolateServicio.Borrar(tipoChocolateBorrar);
            dgvTiposChocolates.Rows.Remove(r);
            MessageBox.Show("TIPO DE CHOCOLATE ELIMINADO EXITOSAMENTE");
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }
    }
}
