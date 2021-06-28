using Talks.Application.Common.Models;
using System.Threading.Tasks;

namespace Talks.Application.Common.Interfaces
{
    public interface IIdentityService
    {
        Task<string> GetUserNameAsync(string userId);
    }
}
