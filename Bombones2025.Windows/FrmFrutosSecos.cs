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
    public partial class FrmFrutosSecos : Form
    {
        private readonly FrutoSecoServicio _frutosSecosServicio;
        private List<FrutoSeco> _frutosSecos = new();
        public FrmFrutosSecos(FrutoSecoServicio frutoSecoServicio)
        {
            InitializeComponent();
            _frutosSecosServicio = frutoSecoServicio;
        }

        private void FrmFrutosSecos_Load(object sender, EventArgs e)
        {
            _frutosSecos = _frutosSecosServicio.GetFrutoSecos();
            MostrarDatosEnGrilla();
        }

        private void MostrarDatosEnGrilla()
        {
            dgvDatosFrutosSecos.Rows.Clear();
            foreach (var frutoSecos in _frutosSecos)
            {
                DataGridViewRow r = new DataGridViewRow();
                r.CreateCells(dgvDatosFrutosSecos);
                SetearFila(r, frutoSecos);
                AgregarFila(r);
            }
        }

        private void AgregarFila(DataGridViewRow r)
        {
            dgvDatosFrutosSecos.Rows.Add(r);
        }

        private void SetearFila(DataGridViewRow r, FrutoSeco frutoSecos)
        {
            r.Cells[0].Value = frutoSecos.FrutoSecoId;
            r.Cells[1].Value = frutoSecos.NombreFrutoSeco;
            r.Tag = frutoSecos;
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmFrutosSecosAE frm = new FrmFrutosSecosAE() { Text = "NUEVO FRUTO SECO" };
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                return;
            }
            FrutoSeco? frutoSeco = frm.GetFrutoSeco();//esto me dice que puede o no puede ingresar un fruto seco en el frm
            if (frutoSeco == null)
            {
                return;
            }
            if (!_frutosSecosServicio.Existe(frutoSeco))//si el frutoSeco paso la validacion es decir que vio que no existe paso a guardarlo en la lista
            {
                _frutosSecosServicio.Guardar(frutoSeco);
                DataGridViewRow r = new DataGridViewRow();
                r.CreateCells(dgvDatosFrutosSecos);
                SetearFila(r, frutoSeco);
                AgregarFila(r);
                MessageBox.Show("Fruto Seco Agregado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Fruto Seco Existente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (dgvDatosFrutosSecos.SelectedRows.Count==0)
            {
                return;
            }
            var r =dgvDatosFrutosSecos.SelectedRows[0];//guardamos en r la primer fila seleccionada
            FrutoSeco frutoSecoBorrar = (FrutoSeco)r.Tag!;
            DialogResult dr = MessageBox.Show($"¿QUIERE ELIMINAR EL FRUTO SECO {frutoSecoBorrar}?", "CONFIRMAR ELIMINACION",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.No) return;
            _frutosSecosServicio.Borrar(frutoSecoBorrar);
            dgvDatosFrutosSecos.Rows.Remove(r);
            MessageBox.Show("FRUTO SECO ELIMINADO CORRECTAMENTE");
        }
    }
}
