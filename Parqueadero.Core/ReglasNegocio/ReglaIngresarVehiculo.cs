using Parqueadero.Core.Excepciones;
using Parqueadero.Core.Modelo;
using Parqueadero.Core.Repositorio;
using System;

namespace Parqueadero.Core.ReglasNegocio
{
    class ReglaIngresarVehiculo
    {
        #region constantes
        private const string DiaNoHabilParaIngreso = "Dia no habil para ingreso";
        private const string VehiculoYaEstaEnElParqueadero = "Vehiculo ya esta en el parqueadero";
        private const string CupoMaximoDeCarros = "Cupo maximo de carros";
        private const string CupoMaximoDeMotos = "Cupo maximo de motos";
        #endregion

        #region reglas
        private ReglaCupoCarro reglaCupoCarro;
        private ReglaCupoMoto reglaCupoMoto;
        private ReglaPlaca reglaPlaca;
        private ReglaFecha reglaFecha;
        #endregion

        private RepositorioHistorial repositorioHistorial;

        public ReglaIngresarVehiculo(RepositorioHistorial repositorioHistorial)
        {
            this.repositorioHistorial = repositorioHistorial;
            reglaCupoCarro = new ReglaCupoCarro(repositorioHistorial);
            reglaCupoMoto = new ReglaCupoMoto(repositorioHistorial);
            reglaPlaca = new ReglaPlaca();
            reglaFecha = new ReglaFecha();
        }

        #region validador publico
        public void Validar(Vehiculo vehiculo, DateTimeOffset fechaIngreso)
        {
            if(!ValidarIngresoPlacaDiaHabil(vehiculo.Placa, fechaIngreso))
            {
                throw new ExcepcionIngresoPlacaVehiculo(DiaNoHabilParaIngreso);
            } else if (YaEstaEnParqueadero(vehiculo.Placa))
            {
                throw new ExcepcionVehiculoYaEstaEnParqueadero(VehiculoYaEstaEnElParqueadero);
            } else if (!reglaCupoCarro.Validar())
            {
                throw new ExcepcionMaximoCupoVehiculo(CupoMaximoDeCarros);
            } else if (!reglaCupoMoto.Validar())
            {
                throw new ExcepcionMaximoCupoVehiculo(CupoMaximoDeMotos);
            }
        }
        #endregion

        #region validadores privados
        private bool YaEstaEnParqueadero(string placa)
        {
            return repositorioHistorial.ObtenerVehiculoParqueado(placa) != null;
        }

        private bool ValidarIngresoPlacaDiaHabil(string placa, DateTimeOffset fechaIngreso)
        {
            return reglaFecha.EsDiaHabil(fechaIngreso) || !reglaPlaca.EmpiezaPorA(placa);
        }
        #endregion
    }
}
