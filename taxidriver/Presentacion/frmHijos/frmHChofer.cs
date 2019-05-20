using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using taxidriver.Controladores;

namespace taxidriver.Presentacion.frmHijos
{
    public partial class frmHChofer : frmPadres.frmPGestionar
    {
        ChoferController _objChofer = new ChoferController();

        public frmHChofer()
        {
            InitializeComponent();
        }

        private void frmHChofer_Load(object sender, EventArgs e)
        {
            Listar(txtBusqueda.Text);
        }

        private void Listar(string pBuscar)
        {
            choferBindingSource.DataSource = _objChofer.Listar(pBuscar);
        }

        private void btnAgregarVehiculo_Click(object sender, EventArgs e)
        {
            if (choferBindingSource.Count > 0)
            {
                frmVehiculoDetalle frmVehiculo = new frmVehiculoDetalle(nroLicenciaLabel1.Text);
                frmVehiculo.ShowDialog();
            }
        }
    }
}
