using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using taxidriver.Data;

namespace taxidriver.Controladores
{
    class UsuarioController
    {
        dbtaxiEntities _db = new dbtaxiEntities();

        #region Metodos

        public List<Usuario> Listar(string pBuscar)
        {
            return _db.Usuario.Where(x => x.Nombre.Contains(pBuscar) || x.Apellido.Contains(pBuscar)).ToList();
        }

        public bool Insertar(Data.Usuario reg)
        {
            _db.Usuario.Add(reg);
            _db.SaveChanges();
            return true;
        }

        public bool Modificar(Data.Usuario reg)
        {
            _db.Entry(reg).State = System.Data.Entity.EntityState.Modified;
            return _db.SaveChanges() > 0;
        }

        public bool Eliminar(string pParametro)
        {
            var reg = _db.Usuario.Where(x => x.Cuenta == pParametro).FirstOrDefault();
            _db.Usuario.Remove(reg);
            return _db.SaveChanges() > 0;
        }

        public int Login(string pUser, string pPass)
        {
            try
            {
                var res = _db.Usuario.Where(x => x.Cuenta == pUser &&
                                x.Clave == pPass).SingleOrDefault();
                if (res != null)
                {
                    if (res.Rol.Contains("Administrador"))
                        return 1;
                    else
                        return 2;
                }

                return 0;
            }
            catch
            {
                return 0;
            }
        }

        internal List<Usuario> BuscarPorPK(string pCuenta)
        {
            return _db.Usuario.Where(x => x.Cuenta == pCuenta).ToList();
        }

        #endregion
    }
}
