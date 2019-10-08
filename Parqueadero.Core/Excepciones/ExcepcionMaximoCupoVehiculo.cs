using System;
using System.Collections.Generic;
using System.Text;

namespace Parqueadero.Core.Excepciones
{
    class ExcepcionMaximoCupoVehiculo : Exception
    {
        public ExcepcionMaximoCupoVehiculo(string mensaje) : base(mensaje) { }
    }
}
