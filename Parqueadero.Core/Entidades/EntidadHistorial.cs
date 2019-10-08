using Parqueadero.Core.Modelo;
using Realms;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parqueadero.Core.Entidades
{
    class EntidadHistorial : RealmObject
    {
        [PrimaryKey]
        public long id { get; set; }

        public Vehiculo Vehiculo { get; set; }
        
        public DateTimeOffset FechaIngreso { get; set; }

        public DateTimeOffset FechaSalida { get; set; }

        public double Cobro { get; set; }
    }
}
