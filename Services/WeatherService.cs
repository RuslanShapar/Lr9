using Lr9.Models;
using Newtonsoft.Json;

namespace Lr9.Services
{ 
    public class WeatherService{
    private readonly HttpClient _httpClient;

    public WeatherService(HttpClient httpClient)
    {
        _httpClient = httpClient;
        _httpClient.BaseAddress = new Uri("https://api.openweathermap.org");
    }
    public async Task<WeatherModel> GetWeather(string city)
    {
        try
        {
            string apiKey = "11943d48b76605e7bbe8f19ac9846e81";
            string requestUrl = $"/data/2.5/weather?q={city}&appid={apiKey}";

            HttpResponseMessage response = await _httpClient.GetAsync(requestUrl);
            response.EnsureSuccessStatusCode();
            string jsonString = await response.Content.ReadAsStringAsync();
            var weatherData = JsonConvert.DeserializeObject<OpenWeatherMapResponse>(jsonString);
            var weatherModel = new WeatherModel
            {
                City = weatherData.Name,
                Country = weatherData.Sys.Country,
                Temperature = weatherData.Main.Temperature - 273.15,
                Description = weatherData.Weather[0].Description
            };
            return weatherModel;
        }
        catch (Exception ex)
        {
            throw new Exception("Failed to get weather data.", ex);
        }
    }
}

}
