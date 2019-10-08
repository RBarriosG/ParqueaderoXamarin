using Parqueadero.Core.Modelo;
using System;
using static Parqueadero.Core.enumeraciones.TipoVehiculo;

namespace Parqueadero.Core.ReglasNegocio
{
    abstract class ReglaCobro
    {
        #region constantes
        private const int ReglaHora = 9;
        private const int HorasDia = 24;
        private const int MilisegundosHora = 1000 * 3600;
        #endregion

        public static ReglaCobro Crear(Vehiculo vehiculo)
        {
            if(vehiculo.Tipo == Tipo.Carro)
            {
                return new ReglaCobroCarro();
            } else
            {
                return new ReglaCobroMoto(vehiculo);
            }
        }

        #region metodos calcularCobro
        public double calcularCobro(DateTimeOffset fechaIngreso, DateTimeOffset fechaSalida)
        {
            long totalHoras = CalcularTotalHoras(fechaIngreso, fechaSalida);
            long dias = CalcularDias(totalHoras);
            long horas = CalcularHorasUltimoDia(totalHoras);
            return dias * GetValorDia() + horas * GetValorHora();
        }

        private long CalcularHorasUltimoDia(long totalHoras)
        {
            long horasExtras = CalcularTotalHorasExtras(totalHoras);
            return horasExtras < ReglaHora ? horasExtras : 0;
        }

        private long CalcularDias(long totalHoras)
        {
            long totalDias = totalHoras / HorasDia;
            return CalcularTotalHorasExtras(totalHoras) >= ReglaHora ? ++totalDias : totalDias;
        }

        private long CalcularTotalHorasExtras(long totalHoras)
        {
            return totalHoras > HorasDia ? totalHoras % HorasDia : totalHoras;
        }

        private long CalcularTotalHoras(DateTimeOffset fechaIngreso, DateTimeOffset fechaSalida)
        {
            decimal miliSegundos = (fechaSalida - fechaIngreso).Milliseconds;
            return (long) Math.Ceiling(miliSegundos / MilisegundosHora);
        }

        #endregion

        #region metodos abstractos
        public abstract double GetValorDia();

        public abstract double GetValorHora();
        #endregion
    }
}
