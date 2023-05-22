using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjectsAPI;
using Microsoft.AspNetCore.Mvc.NewtonsoftJson;
using ProjectsAPI.Controllers;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using System.Net.Http.Headers;
using System.Security.Cryptography.Xml;
using System;
using System.Text.Json;
using Newtonsoft.Json;
using System.Reflection.Metadata;
using Portfolio.Services;
using static Portfolio.Services.APIServices;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace Portfolio.Pages
{
	[BindProperties]
	public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
		private readonly HttpClient _httpClient;
		private readonly WeatherApiClient _weatherApiClient;

		public IndexModel(ILogger<IndexModel> logger, HttpClient httpClient, WeatherApiClient weatherApiClient)
		{
			_logger = logger;
			_httpClient = httpClient;
			_weatherApiClient = weatherApiClient;
		}

		public List<string> ViewProjectData { get; set; } = new List<string>();
		public double Temperature { get; set; }
		public double Humidity { get; set; }
		public string? Description { get; set; }
		public string WeatherDataJson { get; set; }
		public async Task OnGet()
		{

			var getData = new APIServices();
			var apiKey = getData.GetWeatherApiKey();



			ViewProjectData = getData.ShowProjects();

			ViewData["Name1"] = ViewProjectData[0];
			ViewData["Date1"] = ViewProjectData[1];
			ViewData["Info1"] = ViewProjectData[2];

			ViewData["Name2"] = ViewProjectData[3];
			ViewData["Date2"] = ViewProjectData[4];
			ViewData["Info2"] = ViewProjectData[5];

			ViewData["Name3"] = ViewProjectData[6];
			ViewData["Date3"] = ViewProjectData[7];
			ViewData["Info3"] = ViewProjectData[8];

			ViewData["Name4"] = ViewProjectData[9];
			ViewData["Date4"] = ViewProjectData[10];
			ViewData["Info4"] = ViewProjectData[11];

			await WeatherOnGet(apiKey);

		}
		public async Task<IActionResult> WeatherOnGet(string apiKey)
		{
			await GenerateWeatherData("Stockholm", apiKey);
			var weatherJson = WeatherDataJson;

			(Temperature, Humidity, Description) = _weatherApiClient.ExtractWeatherInfo(weatherJson);

			ViewData["Temperature"] = Temperature;
			ViewData["Humidity"] = Humidity;
			ViewData["Description"] = Description;
			ViewData["City"] = "Stockholm";

			return Page();
		}

		

		public async Task GenerateWeatherData(string city, string apiKey)
		{
			WeatherDataJson = await _weatherApiClient.GetWeatherData(city, apiKey);
		}





	}
}