using SelectACourse.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace SelectACourse.WebApp.Services
{
    public class ThirdPartyService
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public ThirdPartyService(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IEnumerable<Course>> GetCourses()
        {
            var client = _httpClientFactory.CreateClient();

            var result = await client.GetAsync($"https://localhost:44353/Course");

            using var responseStream = await result.Content.ReadAsStreamAsync();
            var responseString = await result.Content.ReadAsStringAsync();

            var options = new JsonSerializerOptions()
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            };

            var courses = await JsonSerializer.DeserializeAsync<List<Course>>(responseStream, options);
            return courses;
        }
    }
}
