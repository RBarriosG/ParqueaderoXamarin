using Parqueadero.Core.Modelo;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parqueadero.Core.ReglasNegocio
{
    class GenerarCobro
    {
        public double calcularCobro(Vehiculo vehiculo, DateTimeOffset fechaIngreso, DateTimeOffset fechaSalida)
        {
            return ReglaCobro.Crear(vehiculo).calcularCobro(fechaIngreso, fechaSalida);
        }
    }
}
