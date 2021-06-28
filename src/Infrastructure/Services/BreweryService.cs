using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Talks.Application.Common.Interfaces;
using Talks.Domain.Entities;

namespace Talks.Infrastructure.Services
{
    public class BreweryService : IBreweryService
    {
        private readonly HttpClient _client;

        public BreweryService(HttpClient client)
        {
            _client = client;
        }

        public async Task<IEnumerable<Venue>> GetVenuesAsync()
        {
            var response = await _client.GetAsync(string.Empty);

            if (response.IsSuccessStatusCode)
            {
                using var responseStream = await response.Content.ReadAsStreamAsync();
                return await JsonSerializer.DeserializeAsync<IEnumerable<Venue>>(responseStream);
            }
            else
            {
                return new List<Venue>();
            }           
        }
    }
}
