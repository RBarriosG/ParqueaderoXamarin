using Parqueadero.Core.Excepciones;
using System;
using static Parqueadero.Core.enumeraciones.TipoVehiculo;

namespace Parqueadero.Core.Modelo
{
    class Vehiculo
    {
        #region constantes
        private const string LaPlacaEsObligatoria = "La placa es obligatoria";
        private const string ElCilindrajeEsObligatorio = "El cilindraje es obligatorio";
        private const string LaPlacaDebeContenerMinimoLetras = "La placa debe contener minimo letras";
        #endregion

        #region atributos y get
        private string placa;
        private int cilindraje;
        private Tipo tipo;

        public string Placa
        {
            get { return placa; }
        }

        public int Cilindraje
        {
            get { return cilindraje; }
        }

        public Tipo Tipo
        {
            get { return tipo; }
        }

        #endregion

        #region constructor
        public Vehiculo(string placa, int cilindraje, Tipo tipo)
        {
            ValidarPlaca(placa);
            ValidarCilindraje(cilindraje, tipo);
            this.placa = placa;
            this.cilindraje = cilindraje;
            this.tipo = tipo;
        }
        #endregion

        #region validadores
        private void ValidarPlaca(string placa)
        {
            ValidadorObligatorio(placa);
            ValidadorNoVacio(placa);
            ValidadorPlacaSinLetras(placa);
        }

        private void ValidadorObligatorio(object valor)
        {
            if(valor == null)
            {
                throw new ExcepcionValorObligatorio(LaPlacaEsObligatoria);
            }
        }

        private void ValidadorNoVacio(string valor)
        {
            if (string.IsNullOrEmpty(valor.Trim())) 
            {
                throw new ExcepcionLogitudValor(LaPlacaDebeContenerMinimoLetras);
            }
        }

        private void ValidadorPlacaSinLetras(string mensaje)
        {
            try
            {
                int.Parse(mensaje);
                throw new ExcepcionLogitudValor(LaPlacaDebeContenerMinimoLetras);
            } catch (FormatException)
            {
                return;
            }
        }

        private void ValidarCilindraje(int cilindraje, Tipo tipo)
        {
            if(tipo == Tipo.Moto && cilindraje <= 0)
            {
                throw new ExcepcionValorObligatorio(ElCilindrajeEsObligatorio);
            }
        }
        #endregion

    }
}
