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

        public bool Insertar(Data.Usuario reg)
        {
            _db.Usuario.Add(reg);
            _db.SaveChanges();
            return true;
        }

        public bool Login(string pUser, String pPass)
        {
            try
            {
                var res = _db.Usuario.Where(x => x.Cuenta == pUser &&
                                x.Clave == pPass).SingleOrDefault();
                if (res != null)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        #endregion
    }
}
