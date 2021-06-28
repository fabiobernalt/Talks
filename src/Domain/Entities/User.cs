using Talks.Domain.Common;

namespace Talks.Domain.Entities
{
    public class User : AuditableEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public bool IsActive { get; set; }
        public string Picture { get; set; }
        public string ExternalId { get; set; }
    }
}
