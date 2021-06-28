using Talks.Application.Common.Mappings;
using Talks.Domain.Entities;

namespace Talks.Application.Users.Queries.GetUser
{
    public class UserDto : IMapFrom<User>
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public bool IsActive { get; set; }
        public string ExternalId { get; set; }
    }
}
