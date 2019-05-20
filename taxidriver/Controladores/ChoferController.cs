using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using taxidriver.Data;

namespace taxidriver.Controladores
{
    class ChoferController
    {
        dbtaxiEntities _db = new dbtaxiEntities();

        #region Metodos

        public List<Chofer> Listar(string pBuscar)
        {
            return _db.Chofer.Where(x => x.Nombre.Contains(pBuscar) || x.Apellido.Contains(pBuscar)).ToList();
        }

        public bool Insertar(Data.Chofer reg)
        {
            _db.Chofer.Add(reg);
            _db.SaveChanges();
            return true;
        }

        internal List<Chofer> BuscarPorPK(string pNroLicencia)
        {
            return _db.Chofer.Where(x => x.NroLicencia == pNroLicencia).ToList();
        }

        #endregion
    }
}
