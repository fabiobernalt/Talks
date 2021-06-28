using Talks.Application.Common.Mappings;
using Talks.Domain.Entities;

namespace Talks.Application.Venues.Queries.GetVenues
{
    public class VenueDto : IMapFrom<Venue>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string WebsiteUrl { get; set; }
    }
}
