using Parqueadero.Core.Entidades;
using Parqueadero.Core.Modelo;

namespace Parqueadero.Core.Conversores
{
    class ConversorVehiculo
    {
        public static Vehiculo AModelo(EntidadVehiculo entidadVehiculo)
        {
            return entidadVehiculo == null ? null :
                new Vehiculo(entidadVehiculo.Placa, entidadVehiculo.Cilindraje, ConversorTipoVehiculo.ATipo(entidadVehiculo.Tipo));
        }

        public static EntidadVehiculo AEntidadVehiculo(Vehiculo vehiculo)
        {
            EntidadVehiculo entidadVehiculo = new EntidadVehiculo();
            if(vehiculo != null)
            {
                entidadVehiculo.Placa = vehiculo.Placa;
                entidadVehiculo.Cilindraje = vehiculo.Cilindraje;
                entidadVehiculo.Tipo = ConversorTipoVehiculo.AString(vehiculo.Tipo);

                return entidadVehiculo;
            }
            return null;
        }
    }
}
