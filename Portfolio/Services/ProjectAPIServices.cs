using Newtonsoft.Json;
using ProjectsAPI;
using System.Net.Http;
using System.Text.Json;

namespace Portfolio.Services
{
    public class ProjectAPIServices
    {
        private readonly HttpClient _httpClient;

        public ProjectAPIServices(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

		public List<string> ViewProjectData { get; set; } = new List<string>();
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
            var response = await _httpClient.GetFromJsonAsync<Project>($"https://portfoliofredrikapi.azurewebsites.net/api/Me/{id}");

            return response;
        }

        
    }
}
