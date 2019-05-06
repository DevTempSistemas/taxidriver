using System;
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
    public partial class frmHCliente : frmPadres.frmPGestionar
    {
        public frmHCliente()
        {
            InitializeComponent();
        }

        private void BtnResgistrarServicio_Click(object sender, EventArgs e)
        {
            frmPrincipal frmP = new frmPrincipal();

            Presentacion.frmHijos.frmHRegistrarServicio frmReg = new Presentacion.frmHijos.frmHRegistrarServicio();
            frmReg.BackColor = Color.Cornsilk;
            frmReg.ShowDialog();
        }

        private void FrmHCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
