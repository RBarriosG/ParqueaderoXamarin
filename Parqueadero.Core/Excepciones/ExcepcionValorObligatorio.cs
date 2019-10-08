using System;
using System.Collections.Generic;
using System.Text;

namespace Parqueadero.Core.Excepciones
{
    class ExcepcionValorObligatorio : Exception
    {
        public ExcepcionValorObligatorio(string mensaje) : base(mensaje) { }
    }
}
