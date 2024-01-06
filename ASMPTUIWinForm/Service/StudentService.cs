using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using ASMPTUIWinForm.Model;
using Newtonsoft.Json;

namespace ASMPTUIWinForm.Service
{
    public class StudentService
    {
        private readonly HttpClient _httpClient;
        private const string baseUrl = "https://localhost:7258/api/";
        string apiUrl = $"{baseUrl}GetStudent?studentId={1}";

        public StudentService()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri(baseUrl);
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
        public async Task<List<Student>> GetStudentsAsync()
        {
            HttpResponseMessage response = await _httpClient.GetAsync($"{baseUrl}Student/getall");

            if (response.IsSuccessStatusCode)
            {
                string result = await response.Content.ReadAsStringAsync();
                var list = JsonConvert.DeserializeObject<List<Student>>(result);

                return list;
            }

            throw new Exception($"Failed to fetch students. Status code: {response.StatusCode}");
        }

        public async Task<List<StudentModel>> GetStudentsModelAsync()
        {
            HttpResponseMessage response = await _httpClient.GetAsync($"{baseUrl}Student/getmodel");

            if (response.IsSuccessStatusCode)
            {
                string result = await response.Content.ReadAsStringAsync();
                var list = JsonConvert.DeserializeObject<List<StudentModel>>(result);

                return list;
            }

            throw new Exception($"Failed to fetch students. Status code: {response.StatusCode}");
        }

        public async Task<ApiResponseDto> CreateStudentAsync(Student student)
        {
            try
            {
                string jsonContent = JsonConvert.SerializeObject(student);

                StringContent content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await _httpClient.PostAsync($"{baseUrl}Student/create", content);

                response.EnsureSuccessStatusCode();

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
