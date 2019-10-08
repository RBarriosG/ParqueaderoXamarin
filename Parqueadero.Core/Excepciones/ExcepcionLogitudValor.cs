using System;

namespace Parqueadero.Core.Excepciones
{
    class ExcepcionLogitudValor : Exception
    {
        public ExcepcionLogitudValor(string mensaje) : base(mensaje) { }
    }
}
