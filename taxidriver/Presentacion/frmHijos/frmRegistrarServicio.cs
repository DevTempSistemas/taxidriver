﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace taxidriver.Presentacion.frmHijos
{
    public partial class frmHRegistrarServicio : frmPadres.frmPTitulo
    {
        public frmHRegistrarServicio()
        {
            InitializeComponent();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
