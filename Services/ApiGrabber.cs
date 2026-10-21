using System.Net.Http.Headers;

namespace WP3.Services
{
    public class ApiGrabber
    {
        private static readonly HttpClient client = new HttpClient
        {
            BaseAddress = new Uri("https://ischool.gccis.rit.edu/api/")
        };

        public async Task<string> Grab(string endpoint)
        {
            try
            {
                var response = await client.GetAsync(endpoint);
                response.EnsureSuccessStatusCode();

                return await response.Content.ReadAsStringAsync();
            }
            catch (Exception ex)
            {
                return $"Error: {ex.Message}";
            }
        }
    }
}

