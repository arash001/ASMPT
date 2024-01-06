using ASMPTUIWinForm.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;

namespace ASMPTUIWinForm.Service
{
    public class BorrowService
    {
        private readonly HttpClient _httpClient;
        private const string baseUrl = "https://localhost:7258/api/";
        string apiUrl = $"{baseUrl}GetBorrowByStudent?studentId={1}";
        public BorrowService()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri(baseUrl);
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<List<Borrow>> GetBorrowByStudentAsync(int StudentId)
        {
            HttpResponseMessage response = await _httpClient.GetAsync($"{baseUrl}borrow/GetBorrowByStudent/{StudentId}");

            if (response.IsSuccessStatusCode)
            {
                string jsonResponse = await response.Content.ReadAsStringAsync();
                List<Borrow> result = JsonConvert.DeserializeObject<List<Borrow>>(jsonResponse);

                return result;
            }

            throw new Exception($"Failed to fetch data. Status code: {response.StatusCode}");
        }


        public async Task<List<Borrow>> GetBorrowByBookAsync(int bookId)
        {
            HttpResponseMessage response = await _httpClient.GetAsync($"{baseUrl}borrow/GetBorrowByBook/{bookId}");

            if (response.IsSuccessStatusCode)
            {
                string jsonResponse = await response.Content.ReadAsStringAsync();
                List<Borrow> result = JsonConvert.DeserializeObject<List<Borrow>>(jsonResponse);

                return result;
            }

            throw new Exception($"Failed to fetch data. Status code: {response.StatusCode}");
        }

        public void CreateBorrow(CreateBorrow createBorrow)
        {
            HttpResponseMessage response = _httpClient.PostAsJsonAsync($"{baseUrl}Borrow/CreateBorrow", createBorrow).Result;

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception($"Failed to create borrow record. Status code: {response.StatusCode}");
            }
        }
    }

}

