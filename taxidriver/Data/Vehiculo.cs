//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace taxidriver.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Vehiculo
    {
        public string Placa { get; set; }
        public string TipoVehiculo { get; set; }
        public string Marca { get; set; }
        public Nullable<int> Modelo { get; set; }
        public Nullable<int> CantidadPasajeros { get; set; }
        public string FkChofer { get; set; }
    
        public virtual Chofer Chofer { get; set; }
    }
}