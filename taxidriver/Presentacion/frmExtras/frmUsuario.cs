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
        public frmUsuario()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void Guardar()
        {
            var reg = CargarDatos();
            _objUsuario.Insertar(reg);
        }

        private Usuario CargarDatos()
        {
            var reg = (Usuario)usuarioBindingSource.Current;
            reg.FechaCreacion = fechaCreacionDateTimePicker.Value;
            return reg;
        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            usuarioBindingSource.AddNew();
        }
    }
}
