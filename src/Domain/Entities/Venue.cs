using System.Text.Json.Serialization;
using Talks.Domain.Enums;

namespace Talks.Domain.Entities
{
    public class Venue
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("country")]
        public string Country { get; set; }

        [JsonPropertyName("city")]
        public string City { get; set; }

        [JsonPropertyName("state")]
        public string State { get; set; }

        [JsonPropertyName("postal_code")]
        public string PostalCode { get; set; }

        [JsonPropertyName("phone")]
        public string Phone { get; set; }
 
        public BreweryType BreweryType { get; set; }

        [JsonPropertyName("website_url")]
        public string WebsiteUrl { get; set; }
    }
}
