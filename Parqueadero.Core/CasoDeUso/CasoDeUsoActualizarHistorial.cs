using Parqueadero.Core.Excepciones;
using Parqueadero.Core.Modelo;
using Parqueadero.Core.ReglasNegocio;
using Parqueadero.Core.Repositorio;
using System;

namespace Parqueadero.Core.CasoDeUso
{
    class CasoDeUsoActualizarHistorial
    {
        private const string VehiculoNoEstaEnParqueadero = "Vehiculo no esta en parqueadero";

        private RepositorioHistorial repositorioHistorial;
        private GenerarCobro generarCobro;

        public CasoDeUsoActualizarHistorial(RepositorioHistorial repositorioHistorial)
        {
            this.repositorioHistorial = repositorioHistorial;
            generarCobro = new GenerarCobro();
        }

        public double Ejecutar(string placa, DateTimeOffset fechaSalida)
        {
            if(repositorioHistorial.ObtenerVehiculoParqueado(placa) == null)
            {
                throw new ExcepcionVehiculoNoSeEncuentraEnParqueadero(VehiculoNoEstaEnParqueadero);
            }

            Historial historial = repositorioHistorial.ObtenerVehiculoParqueado(placa);
            double cobro = CalcularCobro(historial, fechaSalida);
            historial.FechaSalida = fechaSalida;
            historial.Cobro = cobro;

            repositorioHistorial.ActualizarHistorial(historial);
            return cobro;
        }

        private double CalcularCobro(Historial historial, DateTimeOffset fechaSalida)
        {
            return generarCobro.calcularCobro(historial.Vehiculo, historial.FechaIngreso, fechaSalida);
        }
    }
}
