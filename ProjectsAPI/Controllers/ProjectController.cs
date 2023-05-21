using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.NewtonsoftJson;
using Newtonsoft.Json;
using System.Xml.Linq;


namespace ProjectsAPI.Controllers
{
	[ApiController]
	[Route("api")]
	public class ProjectController : ControllerBase
	{
		private static List<Project> projects = new List<Project>
		{
			new Project()
			{
				Id = 1, Name = "BankApp", CreatedDate = "2020-01-01",
				Description = "A bank intern website for bank-workers(admin and cashier), you can see info about customers and users, handle their accounts and transactions aswell as change info"},
			new Project()
			{

				Id = 2, Name = "HotelBookingApp", CreatedDate = "2020-01-01",
				Description = "A console-application for a hotel, you can book and handle customers aswell as rooms etc."},

			new Project()
			{

				Id = 3, Name = "Fixxo. E-Commerce", CreatedDate = "2020-01-01",
				Description = "A E-commerce site for clothes."},
			new Project()
			{
				Id = 3, Name = "Ad API", Description = "A rest-API for ads.", CreatedDate = "2020-01-01" }
			};


		[HttpGet("Me/{id}")]
		public IActionResult GetProject(int id)
		{
			var project = projects.FirstOrDefault(p => p.Id == id);
			if (project == null)
			{
				return NotFound();
			}
			return Ok(project);
		}
	}
}




