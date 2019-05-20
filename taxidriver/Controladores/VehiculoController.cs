using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using taxidriver.Data;

namespace taxidriver.Controladores
{
    class VehiculoController
    {
        dbtaxiEntities _db = new dbtaxiEntities();

        #region Metodos

        public List<Vehiculo> Listar(string pBuscar)
        {
            return _db.Vehiculo.Where(x => x.Placa.Contains(pBuscar)).ToList();
        }

        public bool Insertar(Data.Vehiculo reg)
        {
            _db.Vehiculo.Add(reg);
            _db.SaveChanges();
            return true;
        }

        internal List<Vehiculo> BuscarPorPK(string pPlaca)
        {
            return _db.Vehiculo.Where(x => x.Placa == pPlaca).ToList();
        }

        #endregion
    }
}
