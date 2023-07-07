using Xamarin.Forms;
using Xamarin.Forms.GoogleMaps;


namespace PettAssitantApp.Views
{
    
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            Pin MiUbi = new Pin()
            {
                Type = PinType.Place,
                Label = "Mi Ubicacion",
                Address = "Av. Globo Terráqueo 3512, San Martín de Porres 15311",
                Position = new Position(-12.000521750624953, -77.06209627111522),
                Tag = "id_miubi",
            };

            Pin MiUbi2 = new Pin()
            {
                Type = PinType.Place,
                Label = "Casa de Alexandro",
                Address = "Av. Globo Terráqueo 3512, San Martín de Porres 15311",
                Position = new Position(-12.000663, -77.061356),
                Tag = "id_miubi",
            };

            Pin MiUbi3 = new Pin()
            {
                Type = PinType.Place,
                Label = "Casa de Zuñiga",
                Address = "José Del Carmen Verastegui 828, Cercado de Lima 15801",
                Position = new Position(-12.159215, -76.966659),
                Tag = "id_miubi",
            };

            map.Pins.Add(MiUbi);
            map.MoveToRegion(MapSpan.FromCenterAndRadius(MiUbi.Position, Distance.FromMeters(500)));

            map.Pins.Add(MiUbi2);
            map.MoveToRegion(MapSpan.FromCenterAndRadius(MiUbi2.Position, Distance.FromMeters(500)));

            map.Pins.Add(MiUbi3);
            map.MoveToRegion(MapSpan.FromCenterAndRadius(MiUbi3.Position, Distance.FromMeters(500)));
        }
    }
}