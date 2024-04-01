using Newtonsoft.Json;

namespace Lr9.Models
{
    public class WeatherModel
    {
        public string City { get; set; }
        public string Country { get; set; }
        public double Temperature { get; set; }
        public string Description { get; set; }
    }
    public class Sys
    {
        public string Country { get; set; }
        public int Sunrise { get; set; }
        public int Sunset { get; set; }
    }
    public class Weather
    {
        public string Description { get; set; }
    }
    public class OpenWeatherMapResponse
    {
        public string Name { get; set; }
        public MainData Main { get; set; }
        public Weather[] Weather { get; set; }
        public Sys Sys { get; set; }
    }
    public class MainData
    {
        [JsonProperty("temp")]
        public double Temperature { get; set; }
    }
}
