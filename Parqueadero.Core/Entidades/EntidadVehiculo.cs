using Realms;

namespace Parqueadero.Core.Entidades
{
    class EntidadVehiculo : RealmObject
    {

        public string Placa { get; set; }
        public int Cilindraje { get; set; }
        public string Tipo { get; set; }
    }
}
