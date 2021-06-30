using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Xaml;

namespace Countries
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Details : ContentPage
    {
        double latitud, longitud;
        public Details(double lat, double lon)
        {
            InitializeComponent();
            latitud = lat;
            longitud = lon;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            Pin ubicacion = new Pin();
            ubicacion.Label = "Working Location";
            ubicacion.Position = new Position(latitud, longitud);
            mapas.Pins.Add(ubicacion); 
            mapas.MoveToRegion(new MapSpan(ubicacion.Position, 20, 20));
        }
    }
}