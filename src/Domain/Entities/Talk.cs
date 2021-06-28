using System.Collections.Generic;
using Talks.Domain.Common;

namespace Talks.Domain.Entities
{
    public class Talk : AuditableEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public User Speaker { get; set; }
        public int SpeakerId { get; set; }
        public int SeatsAvailable { get; set; }
        public IList<User> Participants { get; private set; } = new List<User>();
    }
}
