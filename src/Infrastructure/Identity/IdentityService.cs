using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Talks.Application.Common.Interfaces;

namespace Talks.Infrastructure.Identity
{
    public class IdentityService : IIdentityService
    {
        private readonly ICurrentUserService _currentUserService;
        private readonly IApplicationDbContext _context;

        public IdentityService(
            ICurrentUserService currentUserService,
            IApplicationDbContext context)
        {
            _currentUserService = currentUserService;
            _context = context;
        }

        public async Task<string> GetUserNameAsync(string userId)
        {
            var user = await _context.Users.FirstOrDefaultAsync(user => user.ExternalId == userId);
            return user != null ? user.FirstName : string.Empty;
        }
    }
}
