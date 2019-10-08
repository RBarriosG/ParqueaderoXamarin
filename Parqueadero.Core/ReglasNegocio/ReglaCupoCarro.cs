using Parqueadero.Core.Repositorio;
using static Parqueadero.Core.enumeraciones.TipoVehiculo;

namespace Parqueadero.Core.ReglasNegocio
{
    class ReglaCupoCarro
    {
        #region constantes
        private const int MaximoCupoCarro = 20;
        #endregion

        private RepositorioHistorial repositorioHistorial;

        public ReglaCupoCarro(RepositorioHistorial repositorioHistorial)
        {
            this.repositorioHistorial = repositorioHistorial;
        }

        public bool Validar()
        {
            long carrosParqueados = repositorioHistorial.contarVehiculosParqueadosPorTipo(Tipo.Carro);
            return carrosParqueados < MaximoCupoCarro;
        }
    }
}
