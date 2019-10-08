using Parqueadero.Core.Modelo;
using Parqueadero.Core.Repositorio;
using System.Collections.Generic;

namespace Parqueadero.Core.CasoDeUso
{
    class CasoDeUsoListarHistoriales
    {
        private RepositorioHistorial repositorioHistorial;

        public CasoDeUsoListarHistoriales(RepositorioHistorial repositorioHistorial)
        {
            this.repositorioHistorial = repositorioHistorial;
        }

        public List<Historial> Ejecutar()
        {
            return repositorioHistorial.LisarHistoriales();
        }
    }
}
