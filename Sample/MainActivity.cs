using Android.App;
using Android.OS;
using APIXURestClient;

namespace APIXURestClientSample
{
    [Activity(Label = "Sample", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {

        APIXURestApi MyAPIXUClient = new APIXURestApi("YOUR API KEY");

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            APIXUCurrentWeather MyCurrenWeather = MyAPIXUClient.GetCurrentWeather("aosta");
            APIXUCurrentWeather MyCurrentWeatherLocalized = MyAPIXUClient.GetCurrentWeatherLocalized("aosta", APIXUL10n.Italian);
            APIXUForecastWeather MyForecastWeather = MyAPIXUClient.GetForecastWeatherLocalized("aosta", 7, APIXUL10n.Italian);
            APIXUForecastWeather MyForecastWeatherLocalized = MyAPIXUClient.GetForecastWeatherLocalized("aosta", 7, APIXUL10n.Italian);

        }
    }
}

