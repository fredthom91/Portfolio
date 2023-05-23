using Newtonsoft.Json.Linq;
using System.Text.Json;

namespace Portfolio.Services
{
    public class WeatherApiClient
    {
        private readonly HttpClient _httpClient;

        public WeatherApiClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<string> GetWeatherData(string city, string apiKey)
        {
            string apiUrl = $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={apiKey}";

            HttpResponseMessage response = await _httpClient.GetAsync(apiUrl);

            if (response.IsSuccessStatusCode)
            {
                string json = await response.Content.ReadAsStringAsync();
                return json;
            }
            else
            {
                throw new HttpRequestException($"API request failed with status code: {response.StatusCode}");
            }
        }

        public (double Temp, double Humidity, string Description) ExtractWeatherInfo(string weatherJson)
        {
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            var weatherData = JsonSerializer.Deserialize<WeatherData>(weatherJson, options);

            double temperature = weatherData.Main.Temp - 273.15;
            double humidity = weatherData.Main.Humidity;
            string description = weatherData.Weather[0].Description;

            return (temperature, humidity, description);
        }

        private class WeatherData
        {
            public WeatherMain Main { get; set; }
            public WeatherDescription[] Weather { get; set; }
        }

        private class WeatherMain
        {
            public double Temp { get; set; }
            public double Humidity { get; set; }
        }

        private class WeatherDescription
        {
            public string Description { get; set; }
        }
    }
}
