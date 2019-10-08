using Android.App;
using Android.OS;
using Android.Support.V7.App;

namespace Parqueadero.Droid.Actividades
{
    [Activity]
    public class Historiales : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_main);
        }
    }
}