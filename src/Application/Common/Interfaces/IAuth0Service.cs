using System.Threading.Tasks;
using Talks.Domain.Enums;

namespace Talks.Application.Common.Interfaces
{
    public interface IAuth0Service
    {
        Task<bool> AddRoleToUserAsync(string userId, Roles role);
    }
}
