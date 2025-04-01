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

        private List<Pais> _paises=new();
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
            r.Cells[0].Value=pais.PaisId;
            r.Cells[1].Value=pais.NombrePais;
            r.Tag=pais;
        }
    }
}
