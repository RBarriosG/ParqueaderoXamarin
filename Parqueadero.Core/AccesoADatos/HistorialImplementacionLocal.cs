using Parqueadero.Core.Conversores;
using Parqueadero.Core.Entidades;
using Parqueadero.Core.Modelo;
using Parqueadero.Core.Repositorio;
using Realms;
using System;
using System.Collections.Generic;
using System.Linq;
using static Parqueadero.Core.enumeraciones.TipoVehiculo;

namespace Parqueadero.Core.AccesoADatos
{
    public class HistorialImplementacionLocal : RepositorioHistorial
    {
        Realm realm;

        public HistorialImplementacionLocal()
        {
            realm = Realm.GetInstance();
        }

        public double ActualizarHistorial(Historial historial)
        {
            realm.Add(ConversorHistorial.AEntidad(historial));
            return historial.Cobro;
        }

        public long contarVehiculosParqueadosPorTipo(Tipo tipo)
        {
            String tipoVehiculo = ConversorTipoVehiculo.AString(tipo);
            return realm.All<EntidadHistorial>().Where(h => h.FechaSalida == null && h.Vehiculo.Tipo == tipoVehiculo).Count();
        }

        public Historial IngresarVehiculo(Historial historial)
        {
            realm.Add(ConversorHistorial.AEntidad(historial));
            return historial;
        }

        public List<Historial> ListarHistoriales()
        {
            return ConversorHistorial.AModelo(realm.All<EntidadHistorial>().ToList());
        }

        public List<Historial> ListarVehiculosParqueados()
        {
            return ConversorHistorial.AModelo(realm.All<EntidadHistorial>().Where(h => h.FechaSalida == null).ToList());
        }

        public Historial ObtenerVehiculoParqueado(string placa)
        {
            var historial = realm.All<EntidadHistorial>().Where(h => h.FechaSalida == null && h.Vehiculo.Placa == placa);
            return ConversorHistorial.AModelo((EntidadHistorial) historial);
        }
    }
}
