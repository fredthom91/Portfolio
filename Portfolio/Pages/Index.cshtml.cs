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
        private readonly WeatherApiClient _weatherApiClient;
        private readonly APIServices _apiServices;

        public IndexModel(WeatherApiClient weatherApiClient, APIServices apiServices)
        {
            _weatherApiClient = weatherApiClient;
            _apiServices = apiServices;
        }

        public List<string> ViewProjectData { get; set; } = new List<string>();
        public double Temp { get; set; }
        public double Humidity { get; set; }
        public string? Description { get; set; }
        public string WeatherDataJson { get; set; }

        public async Task OnGet()
        {
            var apiKey = _apiServices.GetWeatherApiKey();
            ViewProjectData = await _apiServices.ShowProjects();

            for (int i = 0; i < ViewProjectData.Count; i += 3)
            {
                ViewData[$"Name{i / 3 + 1}"] = ViewProjectData[i];
                ViewData[$"Date{i / 3 + 1}"] = ViewProjectData[i + 1];
                ViewData[$"Info{i / 3 + 1}"] = ViewProjectData[i + 2];
            }

            await WeatherOnGet(apiKey);
        }

        public async Task<IActionResult> WeatherOnGet(string apiKey)
        {
            await GenerateWeatherData("Stockholm", apiKey);
            var weatherJson = WeatherDataJson;

            (Temp, Humidity, Description) = _weatherApiClient.ExtractWeatherInfo(weatherJson);

            ViewData[nameof(Temp)] = Temp;
            ViewData[nameof(Humidity)] = Humidity;
            ViewData[nameof(Description)] = Description;
            ViewData["City"] = "Stockholm";

            return Page();
        }

        public async Task GenerateWeatherData(string city, string apiKey)
        {
            WeatherDataJson = await _weatherApiClient.GetWeatherData(city, apiKey);
        }
    }
}