using System;
using System.Collections.Generic;
using System.Text;

namespace Parqueadero.Core.Excepciones
{
    class ExcepcionVehiculoYaEstaEnParqueadero : Exception
    {
        public ExcepcionVehiculoYaEstaEnParqueadero(string mensaje) : base(mensaje) { }
    }
}
