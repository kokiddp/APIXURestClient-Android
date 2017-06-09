using System.Collections.Generic;
using System.Threading.Tasks;

using Newtonsoft.Json;
using RestSharp;

namespace APIXURestClient
{
    public partial class APIXURestApi
    {
        private string Resource { get; set; }
        private string Key { get; set; }

        public APIXURestApi(string ApiKey, string Res)
        {
            Resource = Res;
            Key = ApiKey;
        }

        public APIXURestApi(string ApiKey)
        {
            Resource = "http://api.apixu.com/";
            Key = ApiKey;
        }

        public APIXUCurrentWeather GetCurrentWeather(string city)
        {
            var restClient = new RestClient(Resource);
            var request = new RestRequest
            {
                Resource = "v1/current.json?key=" + Key + "&q=" + city,
                Method = Method.GET
            };

            return JsonConvert.DeserializeObject<APIXUCurrentWeather>(restClient.Execute(request).Content);
        }

        public APIXUCurrentWeather GetCurrentWeatherLocalized(string city, APIXUL10n i)
        {
            var restClient = new RestClient(Resource);
            var request = new RestRequest
            {
                Resource = "v1/current.json?key=" + Key + "&q=" + city + "&lang=" + GetAPIXUL10nCode(i),
                Method = Method.GET
            };

            return JsonConvert.DeserializeObject<APIXUCurrentWeather>(restClient.Execute(request).Content);
        }

        public async Task<APIXUCurrentWeather> GetCurrentWeatherAsync(string city)
        {
            var restClient = new RestClient(Resource);
            var request = new RestRequest
            {
                Resource = "v1/current.json?key=" + Key + "&q=" + city,
                Method = Method.GET
            };

            var restResponse = await restClient.ExecuteTaskAsync(request);
            return JsonConvert.DeserializeObject<APIXUCurrentWeather>(restResponse.Content);
        }

        public async Task<APIXUCurrentWeather> GetCurrentWeatherLocalizedAsync(string city, APIXUL10n i)
        {
            var restClient = new RestClient(Resource);
            var request = new RestRequest
            {
                Resource = "v1/current.json?key=" + Key + "&q=" + city + "&lang=" + GetAPIXUL10nCode(i),
                Method = Method.GET
            };

            var restResponse = await restClient.ExecuteTaskAsync(request);
            return JsonConvert.DeserializeObject<APIXUCurrentWeather>(restResponse.Content);
        }

        public APIXUForecastWeather GetForecastWeather(string city, int days)
        {
            var restClient = new RestClient(Resource);
            var request = new RestRequest
            {
                Resource = "v1/forecast.json?key=" + Key + "&q=" + city + "&days=" + days,
                Method = Method.GET
            };

            return JsonConvert.DeserializeObject<APIXUForecastWeather>(restClient.Execute(request).Content);
        }

        public APIXUForecastWeather GetForecastWeatherLocalized(string city, int days, APIXUL10n i)
        {
            var restClient = new RestClient(Resource);
            var request = new RestRequest
            {
                Resource = "v1/forecast.json?key=" + Key + "&q=" + city + "&days=" + days + "&lang=" + GetAPIXUL10nCode(i),
                Method = Method.GET
            };

            return JsonConvert.DeserializeObject<APIXUForecastWeather>(restClient.Execute(request).Content);
        }

        public async Task<APIXUForecastWeather> GetForecastWeatherAsync(string city, int days)
        {
            var restClient = new RestClient(Resource);
            var request = new RestRequest
            {
                Resource = "v1/forecast.json?key=" + Key + "&q=" + city + "&days=" + days + "&lang=fr",
                Method = Method.GET
            };

            var restResponse = await restClient.ExecuteTaskAsync(request);
            return JsonConvert.DeserializeObject<APIXUForecastWeather>(restResponse.Content);
        }

        public async Task<APIXUForecastWeather> GetForecastWeatherLocalizedAsync(string city, int days, APIXUL10n i)
        {
            var restClient = new RestClient(Resource);
            var request = new RestRequest
            {
                Resource = "v1/forecast.json?key=" + Key + "&q=" + city + "&days=" + days + "&lang=" + GetAPIXUL10nCode(i),
                Method = Method.GET
            };

            var restResponse = await restClient.ExecuteTaskAsync(request);
            return JsonConvert.DeserializeObject<APIXUForecastWeather>(restResponse.Content);
        }
    }
}