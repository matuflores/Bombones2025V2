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
            FrmTiposRellenosAE frm = new FrmTiposRellenosAE() { Text = "NUEVO TIPO DE RELLENO" };
            DialogResult dr = frm.ShowDialog(this);

            if (dr == DialogResult.Cancel)
            {
                return;
            }

            TipoRelleno? tipoRelleno = frm.GetTipoRelleno();

            if (tipoRelleno == null)
            {
                return;
            }

            if (!_tiposRellenosServicio.Existe(tipoRelleno))//si no existe lo creo y guardo
            {
                _tiposRellenosServicio.Guardar(tipoRelleno);
                DataGridViewRow r = new DataGridViewRow();//ahora voy agregarlo al DGV
                r.CreateCells(dgvTiposRellenos);
                SetearFila(r, tipoRelleno);
                AgregarFila(r);
                MessageBox.Show("TIPO DE RELLENO AGREGADO", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("TIPO DE RELLENO EXISTENTE", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //CONCLUIDO EL METODO NUEVO LE DOY USO AL BOTON OK DEL FRM AE
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (dgvTiposRellenos.SelectedRows.Count==0)
            {
                return;
            }
            var r=dgvTiposRellenos.SelectedRows[0];
            TipoRelleno tipoRellenoBorrar=(TipoRelleno)r.Tag!;
            DialogResult dr=MessageBox.Show($"¿SEGURO QUE DESEA ELIMINAR EL TIPO DE RELLENO {tipoRellenoBorrar.NombreTipoRelleno}?",
                "CONFIRMAR ELIMINACION", 
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question, 
                MessageBoxDefaultButton.Button2);
            //Aca muestro un mensaje para asegurarme si el usuario quiere borrar
            if (dr == DialogResult.No) return;//si no quiere borrar regreso!

            _tiposRellenosServicio.Borrar(tipoRellenoBorrar);
            dgvTiposRellenos.Rows.Remove(r);

            MessageBox.Show($"EL TIPO DE RELLENO {tipoRellenoBorrar.NombreTipoRelleno} A SIDO ELIMINADO");
        }
    }
}
