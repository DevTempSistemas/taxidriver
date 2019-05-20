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
        //Controladores.Usuario _objUsuario = new Controladores.Usuario();
        UsuarioController _objUsuarioC = new UsuarioController();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            int idRol = _objUsuarioC.Login(txtCuenta.Text, txtClave.Text);
            if (idRol > 0)
            {
                this.Visible = false;
                frmPrincipal frmP = new frmPrincipal(idRol);
                frmP.Show();
            }
            else
                   MessageBox.Show("NO OK");
        //frmPrincipal frmP = new frmPrincipal();
        //frmP.Show();
    }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
