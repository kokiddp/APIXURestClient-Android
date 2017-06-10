using Android.App;
using Android.OS;

using System.Threading.Tasks;

using APIXURestClient;

namespace APIXURestClientSample
{
    [Activity(Label = "Sample", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        //Get an instance of the client by passing your API Key to the constructor
        APIXURestApi MyAPIXUClient = new APIXURestApi("YOUR API KEY");

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            Task.Run(() => GetWeatherAsync());

            //Get weather by town synchronously
            //Current
            APIXUCurrentWeather MyCurrentWeather = MyAPIXUClient.GetCurrentWeather("aosta");
            //Current localized
            APIXUCurrentWeather MyCurrentWeatherLocalized = MyAPIXUClient.GetCurrentWeatherLocalized("aosta", APIXUL10n.Italian);
            //Forecast
            APIXUForecastWeather MyForecastWeather = MyAPIXUClient.GetForecastWeather("aosta", 7);
            //Forecast localized
            APIXUForecastWeather MyForecastWeatherLocalized = MyAPIXUClient.GetForecastWeatherLocalized("aosta", 7, APIXUL10n.Italian);
        }

        //Get weather by town asynchronously
        public async void GetWeatherAsync()
        {
            APIXUCurrentWeather MyCurrentWeatherAsync = await MyAPIXUClient.GetCurrentWeatherAsync("aosta");
            APIXUCurrentWeather MyCurrentWeatherLocalizedAsync = await MyAPIXUClient.GetCurrentWeatherLocalizedAsync("aosta", APIXUL10n.Italian);
            APIXUForecastWeather MyForecastWeatherAsync = await MyAPIXUClient.GetForecastWeatherAsync("aosta", 7);
            APIXUForecastWeather MyForecastWeatherLocalizedAsync = await MyAPIXUClient.GetForecastWeatherLocalizedAsync("aosta", 7, APIXUL10n.Italian);
        }
    }
}

