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

namespace taxidriver.Presentacion
{
    public partial class frmLogin : Form
    {
        Usuario _objUsuario = new Usuario();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (_objUsuario.AutenticarUsuario(txtCuenta.Text, txtClave.Text))
                MessageBox.Show("OK");
            else
                MessageBox.Show("No OK");
        }
    }
}
