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
using static Portfolio.Services.ProjectAPIServices;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace Portfolio.Pages
{
    [BindProperties]
    public class IndexModel : PageModel
    {
        private readonly WeatherAPIServices _weatherApiClient;
        private readonly ProjectAPIServices _apiServices;

        public IndexModel(WeatherAPIServices weatherApiClient, ProjectAPIServices apiServices)
        {
            _weatherApiClient = weatherApiClient;
            _apiServices = apiServices;
        }

        public async Task OnGet()
        {
            var apiKey = _weatherApiClient.GetWeatherApiKey();
            _apiServices.ViewProjectData = await _apiServices.ShowProjects();

            for (int i = 0; i < _apiServices.ViewProjectData.Count; i += 3)
            {
                ViewData[$"Name{i / 3 + 1}"] = _apiServices.ViewProjectData[i];
                ViewData[$"Date{i / 3 + 1}"] = _apiServices.ViewProjectData[i + 1];
                ViewData[$"Info{i / 3 + 1}"] = _apiServices.ViewProjectData[i + 2];
            }

            await WeatherOnGet(apiKey);
        }

        public async Task<IActionResult> WeatherOnGet(string apiKey)
        {
            _weatherApiClient.WeatherDataJson = await _weatherApiClient.GenerateWeatherData("Stockholm", apiKey);
            var weatherJson = _weatherApiClient.WeatherDataJson;

            (_weatherApiClient.Temp, _weatherApiClient.Humidity, _weatherApiClient.Description) = _weatherApiClient.ExtractWeatherInfo(weatherJson);

            ViewData[nameof(_weatherApiClient.Temp)] = _weatherApiClient.Temp;
            ViewData[nameof(_weatherApiClient.Humidity)] = _weatherApiClient.Humidity;
            ViewData[nameof(_weatherApiClient.Description)] = _weatherApiClient.Description;
            ViewData["City"] = "Stockholm";

            return Page();
        }

        
    }
}