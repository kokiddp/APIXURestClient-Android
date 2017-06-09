using System.Collections.Generic;

using Newtonsoft.Json;

namespace APIXURestClient
{
    public class Location
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("Region")]
        public string Region { get; set; }
        [JsonProperty("country")]
        public string Country { get; set; }
        [JsonProperty("lat")]
        public double Lat { get; set; }
        [JsonProperty("lon")]
        public double Lon { get; set; }
        [JsonProperty("tz_id")]
        public string TimeZoneID { get; set; }
        [JsonProperty("localtime_epoch")]
        public int LocalTimeEpoch { get; set; }
        [JsonProperty("localtime")]
        public string LocalTime { get; set; }
    }

    public class Condition
    {
        [JsonProperty("text")]
        public string Text { get; set; }
        [JsonProperty("icon")]
        public string Icon { get; set; }
        [JsonProperty("code")]
        public int Code { get; set; }
    }

    public class Current
    {
        [JsonProperty("last_updated_epoch")]
        public int LastUpdatedEpoch { get; set; }
        [JsonProperty("last_updated")]
        public string LastUpdated { get; set; }
        [JsonProperty("temp_c")]
        public double TempC { get; set; }
        [JsonProperty("temp_f")]
        public double TempF { get; set; }
        [JsonConverter(typeof(BoolConverter))]
        [JsonProperty("is_day")]
        public bool IsDay { get; set; }
        [JsonProperty("condition")]
        public Condition Condition { get; set; }
        [JsonProperty("wind_mph")]
        public double WindMph { get; set; }
        [JsonProperty("wind_kph")]
        public double WindKph { get; set; }
        [JsonProperty("wind_degree")]
        public int WindDegree { get; set; }
        [JsonProperty("wind_dir")]
        public string WindDir { get; set; }
        [JsonProperty("pressure_mb")]
        public double PressureMb { get; set; }
        [JsonProperty("pressure_in")]
        public double PressureIn { get; set; }
        [JsonProperty("precip_mm")]
        public double PrecipMm { get; set; }
        [JsonProperty("precip_in")]
        public double PrecipIn { get; set; }
        [JsonProperty("humidity")]
        public int Humidity { get; set; }
        [JsonProperty("cloud")]
        public int Cloud { get; set; }
        [JsonProperty("feelslike_c")]
        public double FeelsLikeC { get; set; }
        [JsonProperty("feelslike_f")]
        public double FeelsLikeF { get; set; }
        [JsonProperty("vis_km")]
        public double VisKm { get; set; }
        [JsonProperty("vis_miles")]
        public double VisMiles { get; set; }
    }

    public class Day
    {
        [JsonProperty("maxtemp_c")]
        public double MaxTempC { get; set; }
        [JsonProperty("maxtemp_f")]
        public double MaxTempF { get; set; }
        [JsonProperty("mintemp_c")]
        public double MinTempC { get; set; }
        [JsonProperty("mintemp_f")]
        public double MinTempF { get; set; }
        [JsonProperty("avgtemp_c")]
        public double AvgTempC { get; set; }
        [JsonProperty("avgtemp_f")]
        public double AvgTempF { get; set; }
        [JsonProperty("maxwind_mph")]
        public double MaxWindMph { get; set; }
        [JsonProperty("maxwind_kph")]
        public double MaxWindKph { get; set; }
        [JsonProperty("totalprecip_mm")]
        public double TotalPrecipMm { get; set; }
        [JsonProperty("totalprecip_in")]
        public double TotalPrecipIn { get; set; }
        [JsonProperty("avgvis_km")]
        public double AvgVisKm { get; set; }
        [JsonProperty("avgvis_miles")]
        public double AvgVisMiles { get; set; }
        [JsonProperty("avghumidity")]
        public double AvgHumidity { get; set; }
        [JsonProperty("condition")]
        public Condition Condition { get; set; }
    }

    public class Astro
    {
        [JsonProperty("unrise")]
        public string SunRise { get; set; }
        [JsonProperty("sunset")]
        public string SunSet { get; set; }
        [JsonProperty("moonrise")]
        public string MoonRise { get; set; }
        [JsonProperty("moonset")]
        public string MoonSet { get; set; }
    }

    public class Hour
    {
        [JsonProperty("time_epoch")]
        public int TimeEpoch { get; set; }
        [JsonProperty("time")]
        public string Time { get; set; }
        [JsonProperty("temp_c")]
        public double TempC { get; set; }
        [JsonProperty("temp_f")]
        public double TempF { get; set; }
        [JsonConverter(typeof(BoolConverter))]
        [JsonProperty("is_day")]
        public bool IsDay { get; set; }
        [JsonProperty("condition")]
        public Condition Condition { get; set; }
        [JsonProperty("wind_mph")]
        public double WindMph { get; set; }
        [JsonProperty("wind_kph")]
        public double WindKph { get; set; }
        [JsonProperty("wind_degree")]
        public int WindDegree { get; set; }
        [JsonProperty("wind_dir")]
        public string WindDir { get; set; }
        [JsonProperty("pressure_mb")]
        public double PressureMb { get; set; }
        [JsonProperty("pressure_in")]
        public double PressureIn { get; set; }
        [JsonProperty("precip_mm")]
        public double PrecipMm { get; set; }
        [JsonProperty("precip_in")]
        public double PrecipIn { get; set; }
        [JsonProperty("humidity")]
        public int Humidity { get; set; }
        [JsonProperty("cloud")]
        public int Cloud { get; set; }
        [JsonProperty("feelslike_c")]
        public double FeelsLikeC { get; set; }
        [JsonProperty("feelslike_f")]
        public double FeelsLikeF { get; set; }
        [JsonProperty("windchill_c")]
        public double WindChillC { get; set; }
        [JsonProperty("windchill_f")]
        public double WindChillF { get; set; }
        [JsonProperty("heatindex_c")]
        public double HeatIndexC { get; set; }
        [JsonProperty("heatindex_f")]
        public double HeatIndexF { get; set; }
        [JsonProperty("dewpoint_c")]
        public double DewPointC { get; set; }
        [JsonProperty("dewpoint_f")]
        public double DewPointF { get; set; }
        [JsonConverter(typeof(BoolConverter))]
        [JsonProperty("will_it_rain")]
        public bool WillItRain { get; set; }
        [JsonConverter(typeof(BoolConverter))]
        [JsonProperty("will_it_snow")]
        public bool WillItSnow { get; set; }
        [JsonProperty("vis_km")]
        public double VisKm { get; set; }
        [JsonProperty("vis_miles")]
        public double VisMiles { get; set; }
    }

    public class ForecastDay
    {
        [JsonProperty("date")]
        public string Date { get; set; }
        [JsonProperty("date_epoch")]
        public int DateEpoch { get; set; }
        [JsonProperty("day")]
        public Day Day { get; set; }
        [JsonProperty("astro")]
        public Astro Astro { get; set; }
        [JsonProperty("hour")]
        public List<Hour> Hour { get; set; }
    }

    public class Forecast
    {
        [JsonProperty("forecastday")]
        public List<ForecastDay> ForecastDay { get; set; }
    }

    public class APIXUCurrentWeather
    {
        [JsonProperty("location")]
        public Location Location { get; set; }
        [JsonProperty("current")]
        public Current Current { get; set; }
    }

    public class APIXUForecastWeather : APIXUCurrentWeather
    {
        [JsonProperty("forecast")]
        public Forecast Forecast { get; set; }
    }
}