using OficinarCommon.Models;
using System.Net.Http.Json;

namespace BlazorOficinar.Services
{
    public class ClienteService
    {
        private readonly HttpClient _httpClient;

        public ClienteService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<Cliente>> GetClientes()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<Cliente>>("Cliente");
        }

        public async Task<Cliente> GetClienteById(int id)
        {
            return await _httpClient.GetFromJsonAsync<Cliente>($"Cliente/{id}");
        }

        public async Task AddCliente(Cliente cliente)
        {
            var response = await _httpClient.PostAsJsonAsync("Cliente", cliente);
            response.EnsureSuccessStatusCode();
        }

        public async Task UpdateCliente(Cliente cliente)
        {
            var response = await _httpClient.PutAsJsonAsync($"Cliente/{cliente.Id}", cliente);
            response.EnsureSuccessStatusCode();
        }

        public async Task DeleteCliente(int id)
        {
            var response = await _httpClient.DeleteAsync($"Cliente/{id}");
            response.EnsureSuccessStatusCode();
        }
    }
}
