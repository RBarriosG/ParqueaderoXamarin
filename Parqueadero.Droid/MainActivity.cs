using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Parqueadero.Core.AccesoADatos;
using Parqueadero.Core.CasoDeUso;
using Parqueadero.Core.Modelo;
using System;
using System.Collections.Generic;

namespace Parqueadero.Droid
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        private CasoDeUsoListarVehiculosParqueados casoDeUsoListarVehiculosParqueados;
        private CasoDeUsoIngresarVehiculo casoDeUsoIngresarVehiculo;
        private CasoDeUsoActualizarHistorial casoDeUsoActualizarHistorial;


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
        }
        
        public void Injectar()
        {
            casoDeUsoListarVehiculosParqueados = new CasoDeUsoListarVehiculosParqueados(new HistorialImplementacionLocal());
            casoDeUsoIngresarVehiculo = new CasoDeUsoIngresarVehiculo(new HistorialImplementacionLocal());
            casoDeUsoActualizarHistorial = new CasoDeUsoActualizarHistorial(new HistorialImplementacionLocal());
        }

        public List<Historial> ListarParqueados()
        {
            return casoDeUsoListarVehiculosParqueados.Ejecutar();
        }

        public Historial IngresarVehiculo(Historial historial)
        {
            return casoDeUsoIngresarVehiculo.Ejecutar(historial);
        }

        public double ActualizarHistorial(Historial historial)
        {
            return casoDeUsoActualizarHistorial.Ejecutar(historial.Vehiculo.Placa, DateTimeOffset.Now);
        }

    }
}