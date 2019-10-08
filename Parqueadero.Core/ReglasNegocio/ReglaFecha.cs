using System;
using System.Collections.Generic;
using System.Text;

namespace Parqueadero.Core.ReglasNegocio
{
    class ReglaFecha
    {

        public bool EsDiaHabil(DateTimeOffset fechaIngreso)
        {
            return !EsLunes(fechaIngreso) && !EsDomingo(fechaIngreso);
        }

        private bool EsLunes(DateTimeOffset fechaIngreso)
        {
            return fechaIngreso.DayOfWeek == DayOfWeek.Monday;
        }

        private bool EsDomingo(DateTimeOffset fechaIngreso)
        {
            return fechaIngreso.DayOfWeek == DayOfWeek.Sunday;
        }

    }
}
