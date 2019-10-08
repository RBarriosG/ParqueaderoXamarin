using Parqueadero.Core.Excepciones;
using Parqueadero.Core.Modelo;
using Parqueadero.Core.Repositorio;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parqueadero.Core.CasoDeUso
{
    class CasoDeUsoObtenerVehiculoParqueado
    {
        private const string VehiculoNoSeEncuentraEnParqueadero = "Vehiculo no se encuentra en parquedaro";

        private RepositorioHistorial repositorioHistorial;

        public CasoDeUsoObtenerVehiculoParqueado(RepositorioHistorial repositorioHistorial)
        {
            this.repositorioHistorial = repositorioHistorial;
        }

        public Historial Ejecutar(string placa)
        {
            if(repositorioHistorial.ObtenerVehiculoParqueado(placa) == null)
            {
                throw new ExcepcionVehiculoNoSeEncuentraEnParqueadero(VehiculoNoSeEncuentraEnParqueadero);
            }
            return repositorioHistorial.ObtenerVehiculoParqueado(placa);
        }
    }
}
