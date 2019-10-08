using Parqueadero.Core.Modelo;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parqueadero.Core.ReglasNegocio
{
    class ReglaCobroMoto : ReglaCobro
    {
        #region constantes
        private const double ValorHora = 500;
        private const double ValorDia = 4000;
        private const double ValorExcedenteCilindraje = 2000;
        private const int MaximoCilindraje = 500;
        private Vehiculo vehiculo;
        #endregion


        public ReglaCobroMoto(Vehiculo vehiculo)
        {
            this.vehiculo = vehiculo;
        }

        public double calcularCobro(DateTimeOffset fechaIngreso, DateTimeOffset fechaSalida)
        {
            double costo = base.calcularCobro(fechaIngreso, fechaSalida);
            return vehiculo.Cilindraje > MaximoCilindraje ? costo + ValorExcedenteCilindraje : costo;
        }

        #region implementacion metodos abstractos
        public override double GetValorDia()
        {
            return ValorDia;
        }

        public override double GetValorHora()
        {
            return ValorHora;
        }
        #endregion
    }
}
