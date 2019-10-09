using Parqueadero.Core.Entidades;
using Parqueadero.Core.Modelo;
using System.Collections.Generic;

namespace Parqueadero.Core.Conversores
{
    class ConversorHistorial
    {
        public static Historial AModelo(EntidadHistorial entidadHistorial)
        {
            return entidadHistorial == null ? null :
                new Historial(ConversorVehiculo.AModelo(entidadHistorial.Vehiculo),
                entidadHistorial.FechaIngreso, entidadHistorial.FechaSalida, entidadHistorial.Cobro);
        }

        public static EntidadHistorial AEntidad(Historial historial)
        {
            EntidadHistorial entidadHistorial = new EntidadHistorial();
            if(historial != null)
            {
                entidadHistorial.Vehiculo = ConversorVehiculo.AEntidadVehiculo(historial.Vehiculo);
                entidadHistorial.FechaIngreso = historial.FechaIngreso;
                entidadHistorial.FechaSalida = historial.FechaSalida;
                entidadHistorial.Cobro = historial.Cobro;

                return entidadHistorial;
            }

            return null;
        }

        public static List<Historial> AModelo(List<EntidadHistorial> entidadesHistorial)
        {
            if(entidadesHistorial.Count != 0)
            {
                List<Historial> historiales = new List<Historial>();
                foreach(EntidadHistorial item in entidadesHistorial)
                {
                    historiales.Add(AModelo(item));
                }
                return historiales;
            }
            return new List<Historial>();
        }

    }
}
