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
using taxidriver.Data;

namespace taxidriver.Presentacion
{
    public partial class frmUsuario : Form
    {
        UsuarioController _objUsuario = new UsuarioController();
        private string _cuenta;
        private bool _esNuevo;

        public frmUsuario()
        {
            _esNuevo = true;
            InitializeComponent();
        }

        public frmUsuario(string pCuenta)
        {
            _cuenta = pCuenta;
            _esNuevo = false;
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void Guardar()
        {
            var reg = CargarDatos();
            if (_esNuevo)
            {
                if (_objUsuario.Insertar(reg))
                {
                    MessageBox.Show("Insertado Correctamente");
                    Close();
                }
            }
            else
            {
                if (_objUsuario.Modificar(reg))
                {
                    MessageBox.Show("Modifcado Correctamente");
                    Close();
                }
            }
        }

        private Usuario CargarDatos()
        {
            var reg = (Usuario)usuarioBindingSource.Current;
            reg.FechaCreacion = DateTime.Now;
            reg.Estado = "Activo";
            return reg;
        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            if (_esNuevo)
            {
                usuarioBindingSource.AddNew();
                rolComboBox.SelectedIndex = 0;
            }
            else
            {
                usuarioBindingSource.DataSource = _objUsuario.BuscarPorPK(_cuenta);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
