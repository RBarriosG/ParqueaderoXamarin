using Android.Content.Res;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;
using Parqueadero.Core.Modelo;
using System.Runtime.Remoting.Contexts;
using static Parqueadero.Core.enumeraciones.TipoVehiculo;

namespace Parqueadero.Droid.ViewHolder
{
    public class ParqueoViewHolder : RecyclerView.ViewHolder
    {
        private const string Carro = "CARRO";
        private const string Moto = "MOTO";

        public TextView textPlaca;

        public TextView textTipo;

        public TextView textCilindraje;

        public TextView textFechaIngreso;

        public ImageView imagenTipoVehiculo;

        public Button botonSalida;

        public ParqueoViewHolder(View holder) : base(holder)
        {
            textPlaca = holder.FindViewById<TextView>(Resource.Id.parqueadosTextPlaca);
            textTipo = holder.FindViewById<TextView>(Resource.Id.parqueadosTextTipo);
            textCilindraje = holder.FindViewById<TextView>(Resource.Id.parqueadosTextCilindraje);
            textFechaIngreso = holder.FindViewById<TextView>(Resource.Id.parqueadosTextFechaIngreso);
            imagenTipoVehiculo = holder.FindViewById<ImageView>(Resource.Id.parqueadosImagen);
            botonSalida = holder.FindViewById<Button>(Resource.Id.parqueadosBotonSalir);
        }

        public void BindData(Historial historial, int posicion)
        {
            textPlaca.Text = historial.Vehiculo.Placa;
            textTipo.Text = historial.Vehiculo.Tipo == Tipo.Carro ? Carro : Moto;
            textCilindraje.Text = historial.Vehiculo.Cilindraje.ToString();
            textFechaIngreso.Text = historial.FechaIngreso.ToString();
            imagenTipoVehiculo.SetImageResource(historial.Vehiculo.Tipo == Tipo.Carro ? Resource.Drawable.ic_coche : Resource.Drawable.ic_motocicleta);
            //botonSalida.SetOnClickListener(Actualizar(posicion));
        }

        
        

    }
}