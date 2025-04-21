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
    public partial class FrmTiposChocolatesAE : Form
    {
        private TipoChocolate? tipoChocolate;
        public FrmTiposChocolatesAE()
        {
            InitializeComponent();
        }

        public TipoChocolate? GetTipoChocolate()
        {
            return tipoChocolate;
        }

        private void buttonCancelTipoChocolateAE_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void buttonOkTipoChocolateAE_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (tipoChocolate is null)
                {
                    tipoChocolate=new TipoChocolate();
                }
                tipoChocolate.NombreTipoChocolate = textBoxTipoChocolate.Text;
                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            errorProviderTipoChocolateAE.Clear();
            if (string.IsNullOrEmpty(textBoxTipoChocolate.Text))
            {
                valido = false;
                errorProviderTipoChocolateAE.SetError(textBoxTipoChocolate, "DEBE INGRESAR UN TIPO DE CHOCOLATE");
            }
            return valido;
        }
    }
}
