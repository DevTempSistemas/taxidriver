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
    public partial class frmVehiculoDetalle : Form
    {
        string nroLicencia;

        public frmVehiculoDetalle(string nroLicencia)
        {
            this.nroLicencia = nroLicencia;

            InitializeComponent();
            this.Text = this.nroLicencia;
        }
    }
}
