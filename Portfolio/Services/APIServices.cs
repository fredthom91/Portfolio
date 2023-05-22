using Newtonsoft.Json;
using ProjectsAPI;
using System.Net.Http;
using System.Text.Json;

namespace Portfolio.Services
{
    public class APIServices
    {
		
		
		public List<string> ShowProjects()
        {
            var dataList = new List<string>();

            var projectOne = GetProjects(1);

            dataList.Add(projectOne.Result.Name);
            dataList.Add(projectOne.Result.CreatedDate);
            dataList.Add(projectOne.Result.Description);

            var projectTwo = GetProjects(2);

            dataList.Add(projectTwo.Result.Name);
            dataList.Add(projectTwo.Result.CreatedDate);
            dataList.Add(projectTwo.Result.Description);

            var projectThree = GetProjects(3);

            dataList.Add(projectThree.Result.Name);
            dataList.Add(projectThree.Result.CreatedDate);
            dataList.Add(projectThree.Result.Description);

            var projectFour = GetProjects(4);

            dataList.Add(projectFour.Result.Name);
            dataList.Add(projectFour.Result.CreatedDate);
            dataList.Add(projectFour.Result.Description);

            return dataList;

        }
        public async Task<Project?> GetProjects(int id)
        {
            using var client = new HttpClient();
            var responseOne = await client.GetAsync($"https://fredrikportfolioapi.azurewebsites.net/api/Me/{id}");

            var content = await responseOne.Content.ReadAsStringAsync();

            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            var data = System.Text.Json.JsonSerializer.Deserialize<Project>(content, options);
            return data;
        }

		public string GetWeatherApiKey()
        {
			return "6ba62436dd00318990437058362d6a82";
		}





	}
}
