using System;
using System.Collections.Generic;
using Talks.Domain.Common;

namespace Talks.Domain.Entities
{
    public class Convention : AuditableEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int LocationExternalId { get; set; }
        public string LocationExternalName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public IList<Talk> Talks { get; private set; } = new List<Talk>();
        public IList<User> Participants { get; private set; } = new List<User>();
    }
}
