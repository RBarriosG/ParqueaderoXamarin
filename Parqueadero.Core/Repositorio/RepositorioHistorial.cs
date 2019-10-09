using Parqueadero.Core.Modelo;
using System.Collections.Generic;
using static Parqueadero.Core.enumeraciones.TipoVehiculo;

namespace Parqueadero.Core.Repositorio
{
    public interface RepositorioHistorial
    {
        #region metodos de implementacion historial
        List<Historial> ListarHistoriales();

        Historial IngresarVehiculo(Historial historial);

        double ActualizarHistorial(Historial historial);

        List<Historial> ListarVehiculosParqueados();

        Historial ObtenerVehiculoParqueado(string placa);

        long contarVehiculosParqueadosPorTipo(Tipo tipo);
        #endregion
    }
}
