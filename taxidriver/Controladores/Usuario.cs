using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using taxidriver.Data;
using taxidriver.Data.dsTaxiTableAdapters;

namespace taxidriver.Controladores
{
    class Usuario
    {
        dsTaxi _ds = new dsTaxi();
        UsuarioTableAdapter _ta = new UsuarioTableAdapter();

        #region Atributos
        private string cuenta;
        private string clave;
        private string nombre;
        private string apellido;
        private string rol;
        private string estado;
        private DateTime fechaCreacion;

        #endregion

        #region Propiedades
        public string Cuenta { get => cuenta; set => cuenta = value; }
        public string Clave { get => clave; set => clave = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Rol { get => rol; set => rol = value; }
        public string Estado { get => estado; set => estado = value; }
        public DateTime FechaCreacion { get => fechaCreacion; set => fechaCreacion = value; }
        #endregion

        #region Metodos
        public bool AutenticarUsuario(string pCuenta, string pClave)
        {
            if (_ta.FillByAutenticarUsuario(_ds.Usuario, pCuenta, pClave) > 0)
                return true;
            else
                return false;
        }

        public bool Insertar()
        {
            return true;
        }

        #endregion
    }
}
