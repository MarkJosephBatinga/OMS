using OMS.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace OMS.Client.Service.InternService
{
    public class InternService : IInternService
    {
        private readonly HttpClient _http;

        public InternService(HttpClient http)
        {
            _http = http;
        }

        public async Task<List<Intern>> AddIntern(Intern intern)
        {
            var result = await _http.PostAsJsonAsync("api/intern/create", intern);
            var status = await result.Content.ReadFromJsonAsync<List<Intern>>();
            return status;
        }

        public async Task<List<Intern>> DeleteIntern(Intern intern)
        {
            var result = await _http.PostAsJsonAsync("api/intern/delete", intern);
            var status = await result.Content.ReadFromJsonAsync<List<Intern>>();
            return status;
        }

        public async Task<List<Intern>> GetAllIntern()
        {
            var result = await _http.GetFromJsonAsync<List<Intern>>($"api/intern/displayall");
            return result;
        }

        public async Task<Intern> GetIntern(int Id)
        {
            var result = await _http.GetFromJsonAsync<Intern>($"api/intern/display/{Id}");
            return result;
        }

        public async Task<List<Intern>> UpdateIntern(Intern intern)
        {
            var result = await _http.PostAsJsonAsync("api/intern/update", intern);
            var status = await result.Content.ReadFromJsonAsync<List<Intern>>();
            return status;
        }
    }
}
