using System;
using System.Net.Http;
using System.Threading.Tasks;
namespace Kalender
{
    public class ApiService
    {
        private readonly HttpClient _httpClient;

        public ApiService(HttpClient httpClient)
        {
            _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
        }

        public async Task<string> GetDataFromApiAsync()
        {
            try
            {
                // Replace this URL with the actual API endpoint
                var response = await _httpClient.GetAsync("https://www.googleapis.com/calendar/v3");
                response.EnsureSuccessStatusCode();
                return await response.Content.ReadAsStringAsync();
            }
            catch (Exception ex)
            {
                // Handle errors
                throw ex;
            }
        }
    }
}
