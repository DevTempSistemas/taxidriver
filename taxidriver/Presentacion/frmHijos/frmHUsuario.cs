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
    public partial class frmHUsuario : frmPadres.frmPGestionar
    {
        UsuarioController _objUsuario = new UsuarioController();

        public frmHUsuario()
        {
            InitializeComponent();
        }

        private void BunifuTileButton2_Click(object sender, EventArgs e)
        {
            frmUsuario AddUser = new frmUsuario();
            AddUser.ShowDialog();
            Listar(txtBusqueda.Text);
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            //Listar(txtBusqueda.Text);
        }

        private void frmHUsuario_Load(object sender, EventArgs e)
        {
            Listar(txtBusqueda.Text);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            frmUsuario AddUser = new frmUsuario(cuentaLabel1.Text);
            AddUser.ShowDialog();
            _objUsuario = new UsuarioController();
            Listar(txtBusqueda.Text);
        }

        private void Listar(string pBuscar)
        {
            usuarioBindingSource.DataSource = _objUsuario.Listar(pBuscar);
        }

        private void txtBusqueda_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                Listar(txtBusqueda.Text);
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Eliminar registro?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res== DialogResult.Yes)
            {
                _objUsuario.Eliminar(cuentaLabel1.Text);
                _objUsuario = new UsuarioController();
                Listar(txtBusqueda.Text);
            }
        }
    }
}
