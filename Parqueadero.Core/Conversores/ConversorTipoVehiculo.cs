using System;
using System.Collections.Generic;
using System.Text;
using static Parqueadero.Core.enumeraciones.TipoVehiculo;

namespace Parqueadero.Core.Conversores
{
    class ConversorTipoVehiculo
    {
        private const string Carro = "CARRO";
        private const string Moto = "MOTO";

        public static string AString(Tipo tipo)
        {
            return tipo == Tipo.Carro ? Carro : Moto;
        }

        public static Tipo ATipo(string tipo)
        {
            return tipo.Equals(Carro) ? Tipo.Carro : Tipo.Moto;
        }
    }
}
