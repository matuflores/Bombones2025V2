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

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (tipoRelleno is not null)
            {
                textBoxTipoRelleno.Text = tipoRelleno.NombreTipoRelleno;
            }

        }

        private void buttonOkTipoRellenoAE_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (tipoRelleno is null)
                {
                    tipoRelleno = new TipoRelleno();
                }
                tipoRelleno.NombreTipoRelleno = textBoxTipoRelleno.Text;
                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            bool validar = true;
            errorProviderTipoRellenoAE.Clear();
            if (string.IsNullOrEmpty(textBoxTipoRelleno.Text))// el IsNullOrEmpty se fija si un string es null
            {
                validar= false;
                errorProviderTipoRellenoAE.SetError(textBoxTipoRelleno,"Tipo de relleno es requerido");
            }
            return validar;
        }

        private void buttonCancelTipoRellenoAE_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        public void SetTipoRelleno(TipoRelleno tipoRelleno)
        {
            this.tipoRelleno = tipoRelleno;
        }//despues de este metodo agrego el override onload para cargar el nombre del objeto a editar en el textbox
    }
}
