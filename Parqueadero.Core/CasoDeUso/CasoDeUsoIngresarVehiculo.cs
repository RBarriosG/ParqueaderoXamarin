using Parqueadero.Core.Modelo;
using Parqueadero.Core.ReglasNegocio;
using Parqueadero.Core.Repositorio;

namespace Parqueadero.Core.CasoDeUso
{
    public class CasoDeUsoIngresarVehiculo
    {
        private RepositorioHistorial repositorioHistorial;
        private ReglaIngresarVehiculo reglaIngresarVehiculo;

        public CasoDeUsoIngresarVehiculo(RepositorioHistorial repositorioHistorial)
        {
            this.repositorioHistorial = repositorioHistorial;
            reglaIngresarVehiculo = new ReglaIngresarVehiculo(repositorioHistorial);
        }

        public Historial Ejecutar(Historial historial)
        {
            reglaIngresarVehiculo.Validar(historial.Vehiculo, historial.FechaIngreso);
            return repositorioHistorial.IngresarVehiculo(historial);
        }

    }
}
