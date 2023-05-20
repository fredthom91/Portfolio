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
			
		}


	}
}