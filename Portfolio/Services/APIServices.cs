using Newtonsoft.Json;
using ProjectsAPI;
using System.Net.Http;
using System.Text.Json;

namespace Portfolio.Services
{
    public class APIServices
    {
        private readonly HttpClient _httpClient;

        public APIServices(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<string>> ShowProjects()
        {
            var dataList = new List<string>();

            for (int id = 1; id <= 4; id++)
            {
                var project = await GetProject(id);

                if (project != null)
                {
                    dataList.Add(project.Name);
                    dataList.Add(project.CreatedDate);
                    dataList.Add(project.Description);
                }
            }

            return dataList;
        }

        private async Task<Project?> GetProject(int id)
        {
            var response = await _httpClient.GetFromJsonAsync<Project>($"https://fredrikportfolioapi.azurewebsites.net/api/Me/{id}");

            return response;
        }

        public string GetWeatherApiKey()
        {
            return "6ba62436dd00318990437058362d6a82";
        }
    }
}
