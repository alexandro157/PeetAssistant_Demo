using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;

namespace PettAssitantApp.Droid
{
    [Activity(Label = "PettAssitant", Icon = "@mipmap/ico",
        Theme = "@style/splash", MainLauncher = true,
        ConfigurationChanges = ConfigChanges.ScreenSize)]
    public class SplashScreen : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            StartActivity(new Intent(Application.Context, typeof(MainActivity)));

        }
    }
}