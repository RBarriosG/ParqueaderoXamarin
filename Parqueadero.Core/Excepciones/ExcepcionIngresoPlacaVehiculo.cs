using System;
using System.Collections.Generic;
using System.Text;

namespace Parqueadero.Core.Excepciones
{
    class ExcepcionIngresoPlacaVehiculo : Exception
    {
        public ExcepcionIngresoPlacaVehiculo(string mensaje) : base(mensaje) { }
    }
}
