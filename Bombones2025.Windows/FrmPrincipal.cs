﻿using Bombones2025.Servicios;
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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnPaises_Click(object sender, EventArgs e)
        {
            PaisServicio servicio = new PaisServicio("Paises.txt");
            FrmPaises frm = new FrmPaises(servicio) { Text = "Listado de Paises" };//inyecto el servicio en el ctor del formulario
            frm.ShowDialog(this);//lo muestro cuando se habre el form de paises
        }

        private void btnFrutosSecos_Click(object sender, EventArgs e)
        {
            FrutoSecoServicio servicio = new FrutoSecoServicio("FrutosSecos.txt");
            FrmFrutosSecos frm = new FrmFrutosSecos(servicio) { Text = "Listado de Frutos Secos" };
            frm.ShowDialog(this);
        }
    }
}
