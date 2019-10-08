using System;

namespace Parqueadero.Core.Modelo
{
    class Historial
    {
        #region atributos, get y set
        private Vehiculo vehiculo;
        private DateTimeOffset fechaIngreso;
        private DateTimeOffset fechaSalida;
        private double cobro;

        public Vehiculo Vehiculo
        {
            get { return vehiculo; }
        }

        public DateTimeOffset FechaIngreso
        {
            get { return fechaIngreso; }
        }

        public DateTimeOffset FechaSalida
        {
            get { return fechaSalida; }
            
            set { fechaSalida = value; }
        }

        public double Cobro
        {
            get { return cobro; }

            set { cobro = value; }
        }
        #endregion

        #region constructores
        public Historial(Vehiculo vehiculo, DateTimeOffset fechaIngreso, DateTimeOffset? fechaSalida, double cobro)
        {
            this.vehiculo = vehiculo;
            this.fechaIngreso = fechaIngreso;
            this.fechaSalida = (DateTimeOffset) fechaSalida;
            this.cobro = cobro;
        }

        public Historial(Vehiculo vehiculo, DateTimeOffset fechaIngreso): this(vehiculo, fechaIngreso, null, 0) { }
        #endregion
    }
}
