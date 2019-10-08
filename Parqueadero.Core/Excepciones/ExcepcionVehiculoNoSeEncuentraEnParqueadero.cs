using System;
using System.Collections.Generic;
using System.Text;

namespace Parqueadero.Core.Excepciones
{
    class ExcepcionVehiculoNoSeEncuentraEnParqueadero : Exception
    {
        public ExcepcionVehiculoNoSeEncuentraEnParqueadero(string mensaje) : base(mensaje) { }
    }
}
