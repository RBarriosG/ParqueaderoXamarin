using Realms;
using System;

namespace Parqueadero.Core.Entidades
{
    class EntidadHistorial : RealmObject
    {
        [PrimaryKey]
        public long id { get; set; }

        public EntidadVehiculo Vehiculo { get; set; }
        
        public DateTimeOffset FechaIngreso { get; set; }

        public DateTimeOffset FechaSalida { get; set; }

        public double Cobro { get; set; }
    }
}
