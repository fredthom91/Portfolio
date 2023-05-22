using Newtonsoft.Json.Linq;

namespace Portfolio.Services
{
	public class WeatherApiClient
	{
		private readonly HttpClient _httpClient;

		public WeatherApiClient()
		{
			_httpClient = new HttpClient();
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

		public (double Temperature, double Humidity, string Description) ExtractWeatherInfo(string weatherJson)
		{
			JObject json = JObject.Parse(weatherJson);
			double temperature = json["main"]["temp"].Value<double>() - 273.15;
			double humidity = json["main"]["humidity"].Value<double>();
			string description = json["weather"][0]["description"].Value<string>();

			return (temperature, humidity, description);
		}
	}
}
