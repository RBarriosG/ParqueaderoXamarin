using Parqueadero.Core.Modelo;
using Parqueadero.Core.Repositorio;
using System.Collections.Generic;

namespace Parqueadero.Core.CasoDeUso
{
    class CasoDeUsoListarVehiculosParqueados
    {
        private RepositorioHistorial repositorioHistorial;

        public CasoDeUsoListarVehiculosParqueados(RepositorioHistorial repositorioHistorial)
        {
            this.repositorioHistorial = repositorioHistorial;
        }

        public List<Historial> Ejecutar()
        {
            return repositorioHistorial.ListarVehiculosParqueados();
        }
    }
}
