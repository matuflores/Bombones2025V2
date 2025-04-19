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

        protected override void OnLoad(EventArgs e)//con este metodo hago que se me muestre el objeto que voy a editar en el cuadro de texto
        {
            base.OnLoad(e);
            if (frutoSeco is not null)
            {
                textBoxFrutoSeco.Text = frutoSeco.NombreFrutoSeco;
            }
        }

        public void SetFrutoSeco(FrutoSeco frutoSeco)//remplazo internal por public
        {
            this.frutoSeco = frutoSeco;
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

        private void buttonCancelFrutoSecoAE_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
