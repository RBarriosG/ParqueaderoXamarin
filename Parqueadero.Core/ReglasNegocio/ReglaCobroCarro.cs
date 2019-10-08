using System;
using System.Collections.Generic;
using System.Text;

namespace Parqueadero.Core.ReglasNegocio
{
    class ReglaCobroCarro : ReglaCobro
    {
        #region constantes
        private const double ValorHora = 1000;
        private const double ValorDia = 8000;
        #endregion

        #region implementacion metodos abstractos
        public override double GetValorDia()
        {
            return ValorDia;
        }

        public override double GetValorHora()
        {
            return ValorHora;
        }
        #endregion
    }
}
