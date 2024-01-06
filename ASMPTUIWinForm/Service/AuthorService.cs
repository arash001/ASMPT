using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using ASMPTUIWinForm.Model;

namespace ASMPTUIWinForm.Service
{
    public class AuthorService
    {
        private readonly HttpClient _httpClient;
        private const string baseUrl = "https://localhost:7258/api/";
        string apiUrl = $"{baseUrl}GetBorrowByStudent?studentId={1}";
        public AuthorService()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri(baseUrl);
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
        public async Task<List<Author>> GetDataAsync<T>()
        {
            HttpResponseMessage response = await _httpClient.GetAsync($"{baseUrl}Author");

            if (response.IsSuccessStatusCode)
            {
                string jsonResponse = await response.Content.ReadAsStringAsync();
                List<Author> authors = JsonConvert.DeserializeObject<List<Author>>(jsonResponse);

                return authors;
            }

            throw new Exception($"Failed to fetch data. Status code: {response.StatusCode}");
        }

        public async Task<ApiResponseDto> CreateAuthorAsync(CreateAuthorDto createAuthorDto)
        {
            try
            {
                // Serialize the Author object to JSON
                string jsonContent = JsonConvert.SerializeObject(createAuthorDto);

                // Create a StringContent with the JSON data
                StringContent content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

                // Make a 'POST' request to the API endpoint
                HttpResponseMessage response = await _httpClient.PostAsync($"{baseUrl}Author/create", content);

                // Ensure the request was successful before reading the content
                response.EnsureSuccessStatusCode();

                // Read and deserialize the JSON response
                string jsonResponse = await response.Content.ReadAsStringAsync();
                var apiResponse = JsonConvert.DeserializeObject<ApiResponseDto>(jsonResponse);

                return apiResponse;
            }
            catch (HttpRequestException ex)
            {
                // You can log the error or throw an exception as needed
                throw new Exception($"Error calling API: {ex.Message}", ex);
            }
        }
    }
}
