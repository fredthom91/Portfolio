using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.NewtonsoftJson;
using Newtonsoft.Json;


namespace ProjectsAPI.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class ProjectController : ControllerBase
	{
		private readonly List<Project> _projects = new List<Project>
	{
		new Project { Id = 1, Name = "BankWebApp", Description = "A bank intern website for bank-workers(admin and cashier), you can see info about customers and users, handle their accounts and transactions aswell as change info", CreatedDate = "2020-01-01" },
		new Project { Id = 2, Name = "HotelBookingApp", Description = "A console-application for a hotel, you can book and handle customers aswell as rooms etc.", CreatedDate = "2020-01-01" },
		new Project { Id = 3, Name = "Ad API", Description = "A rest-API for ads.", CreatedDate = "2020-01-01" },
		new Project { Id = 4, Name = "Fixxo. E-Commerce", Description = "A E-commerce site for clothes.", CreatedDate = "2020-01-01" },
	};

		[HttpGet]
		public ActionResult<IEnumerable<Project>> GetProjects()
		{
			return _projects.ToList();
		}


	}
}
