using ASMPTUIWinForm.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace ASMPTUIWinForm.Service
{
    public class BookService
    {
    private readonly HttpClient _httpClient;
    private const string baseUrl = "https://localhost:7258/api/";
    string apiUrl = $"{baseUrl}GetBorrowByStudent?studentId={1}";
        public BookService()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri(baseUrl);
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
        public async Task<List<Book>> GetBooks()
        {
            HttpResponseMessage response = await _httpClient.GetAsync($"{baseUrl}Book/GetBooks");

            if (response.IsSuccessStatusCode)
            {
                string result = await response.Content.ReadAsStringAsync();
                var list = JsonConvert.DeserializeObject<List<Book>>(result);

                return list;
            }

            throw new Exception($"Failed to fetch books. Status code: {response.StatusCode}");
        }

              public async Task<List<BookModel>> GetModelBooks()
        {
            HttpResponseMessage response = await _httpClient.GetAsync($"{baseUrl}Book/getmodels");

            if (response.IsSuccessStatusCode)
            {
                string result = await response.Content.ReadAsStringAsync();
                var list = JsonConvert.DeserializeObject<List<BookModel>>(result);

                return list;
            }

            throw new Exception($"Failed to fetch books. Status code: {response.StatusCode}");
        }

        public async Task<ApiResponseDto> CreateBooks(Book book)
        {
            try
            {
                string jsonContent = JsonConvert.SerializeObject(book);

                StringContent content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await _httpClient.PostAsync($"{baseUrl}Book/create", content);

                string jsonResponse = await response.Content.ReadAsStringAsync();
                var apiResponse = JsonConvert.DeserializeObject<ApiResponseDto>(jsonResponse);

                return apiResponse;
            }
            catch (Exception ex )
            {
                throw new Exception($"Error calling API: {ex.Message}", ex);
            }
        }
    }
}
