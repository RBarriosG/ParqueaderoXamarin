using Parqueadero.Core.Modelo;
using System.Collections.Generic;
using static Parqueadero.Core.enumeraciones.TipoVehiculo;

namespace Parqueadero.Core.Repositorio
{
    interface RepositorioHistorial
    {
        #region metodos de implementacion historial
        List<Historial> LisarHistoriales();

        Historial IngresarVehiculo(Historial historial);

        double ActualizarHistorial(Historial historial);

        List<Historial> ListarVehiculosParqueados();

        Historial ObtenerVehiculoParqueado(string placa);

        long contarVehiculosParqueadosPorTipo(Tipo tipo);
        #endregion
    }
}
