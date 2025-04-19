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
    public partial class FrmPaises : Form
    {
        private readonly PaisServicio _paisServicio;

        private List<Pais> _paises = new();
        public FrmPaises(PaisServicio paisServicio)//se lo paso al ctor
        {

            InitializeComponent();
            _paisServicio = paisServicio;
        }

        private void FrmPaises_Load(object sender, EventArgs e)
        {
            _paises = _paisServicio.GetPaises();
            MostrarDatosEnGrilla();
        }

        private void MostrarDatosEnGrilla()
        {
            dgvDatosPaises.Rows.Clear();//limpio la grilla
            foreach (Pais pais in _paises)//por cada pais en la lista paises 
            {
                DataGridViewRow r = new DataGridViewRow();
                r.CreateCells(dgvDatosPaises);
                SetearFila(r, pais);
                AgregarFila(r);
            }
        }

        private void AgregarFila(DataGridViewRow r)
        {
            dgvDatosPaises.Rows.Add(r);
        }

        private void SetearFila(DataGridViewRow r, Pais pais)
        {
            r.Cells[0].Value = pais.PaisId;
            r.Cells[1].Value = pais.NombrePais;
            r.Tag = pais;
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmPaisesAE frm = new FrmPaisesAE() { Text = "NUEVO PAIS" };
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel) return;
            Pais? pais = frm.GetPais();
            if (pais == null) return;
            if (!_paisServicio.Existe(pais))
            {
                _paisServicio.Guardar(pais);
                DataGridViewRow r = new DataGridViewRow();
                r.CreateCells(dgvDatosPaises);
                SetearFila(r, pais);
                AgregarFila(r);
                MessageBox.Show("Pais Agregado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Pais Existente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            


        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (dgvDatosPaises.SelectedRows.Count == 0)
            {
                return;
            }
            var r = dgvDatosPaises.SelectedRows[0];
            Pais paisBorrar = (Pais)r.Tag!;
            DialogResult dr = MessageBox.Show($"¿QUIERE ELIMINAR EL PAIS {paisBorrar}?", "CONFIRMAR ELIMINACION",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);

            if (dr == DialogResult.No) return;
            _paisServicio.Borrar(paisBorrar);
            dgvDatosPaises.Rows.Remove(r);//una vez que lo borre lo elimino de la grilla.
            MessageBox.Show("PAIS ELIMINADO CORRECTAMENTE");
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvDatosPaises.SelectedRows.Count == 0)
            {
                return;
            }
            var r = dgvDatosPaises.SelectedRows[0];
            Pais? pais = (Pais)r.Tag!;

            FrmPaisesAE frm = new FrmPaisesAE() { Text = "EDITAR PAIS" };
            frm.SetPais(pais);
            DialogResult dr = frm.ShowDialog(this);

            if (dr == DialogResult.Cancel) return;

            pais = frm.GetPais();
            if (pais == null) return;

            if (!_paisServicio.Existe(pais))
            {
                _paisServicio.Guardar(pais);
                SetearFila(r, pais);
                MessageBox.Show("Pais Modificado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Pais Existente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
