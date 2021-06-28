using System.Collections.Generic;
using Talks.Application.Common.Mappings;
using Talks.Domain.Entities;

namespace Talks.Application.Conventions.Queries
{
    public class ConventionDto : IMapFrom<Convention>
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public IList<Talk> Talks { get; set; }
    }
}
