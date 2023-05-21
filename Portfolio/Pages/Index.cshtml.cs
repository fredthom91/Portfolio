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

namespace Portfolio.Pages
{
	[BindProperties]
	public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
		}

		

		public void OnGet()
		{
			var data = GetFirstProject();

			ViewData["Name"] = data.Result.Name;
			ViewData["Date"] = data.Result.CreatedDate;
			ViewData["Info"] = data.Result.Description;
		}
		public async Task<Project?> GetFirstProject()
		{
			using var client = new HttpClient();
			var responseOne = await client.GetAsync("https://fredrikportfolioapi.azurewebsites.net/api/Me/1");

			var content = await responseOne.Content.ReadAsStringAsync();

			var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
			var data = System.Text.Json.JsonSerializer.Deserialize<Project>(content, options);
			return data;
		}


	}
}