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
    public partial class FrmFrutosSecosAE : Form
    {
        private FrutoSeco? frutoSeco;
        public FrmFrutosSecosAE()
        {
            InitializeComponent();
        }

        public FrutoSeco? GetFrutoSeco()
        {
            return frutoSeco;
        }

        private void buttonOkFrutoSecoAE_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())//cuando apreto OK valido los datos
            {
                if (frutoSeco is null)//si no tengo un fruto lo creo
                {
                    frutoSeco = new FrutoSeco();
                }

                frutoSeco.NombreFrutoSeco = textBoxFrutoSeco.Text;//le asigno el texto que esta en el textPais
                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            errorProviderFrutoSecoAE.Clear();
            if (string.IsNullOrEmpty(textBoxFrutoSeco.Text))// el IsNullOrEmpty se fija si un string es null
            {
                valido = false;
                errorProviderFrutoSecoAE.SetError(textBoxFrutoSeco, "Nombre de Fruto Seco requerido");
            }
            return valido;
        }
    }
}
