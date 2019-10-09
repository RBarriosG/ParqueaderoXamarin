using Parqueadero.Core.Modelo;
using Parqueadero.Core.Repositorio;
using System.Collections.Generic;

namespace Parqueadero.Core.CasoDeUso
{
    public class CasoDeUsoListarHistoriales
    {
        private RepositorioHistorial repositorioHistorial;

        public CasoDeUsoListarHistoriales(RepositorioHistorial repositorioHistorial)
        {
            this.repositorioHistorial = repositorioHistorial;
        }

        public List<Historial> Ejecutar()
        {
            return repositorioHistorial.ListarHistoriales();
        }
    }
}
