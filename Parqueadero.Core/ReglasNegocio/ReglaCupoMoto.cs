using Parqueadero.Core.Repositorio;
using static Parqueadero.Core.enumeraciones.TipoVehiculo;

namespace Parqueadero.Core.ReglasNegocio
{
    class ReglaCupoMoto
    {
        #region constante
        private const int MaximoCupoMoto = 10;
        #endregion

        private RepositorioHistorial repositorioHistorial;

        public ReglaCupoMoto(RepositorioHistorial repositorioHistorial)
        {
            this.repositorioHistorial = repositorioHistorial;
        }

        public bool Validar()
        {
            long motosParqueadas = repositorioHistorial.contarVehiculosParqueadosPorTipo(Tipo.Moto);
            return motosParqueadas < MaximoCupoMoto;
        }
    }
}
