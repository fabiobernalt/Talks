using System.Collections.Generic;
using System.Threading.Tasks;
using Talks.Domain.Entities;

namespace Talks.Application.Common.Interfaces
{
    public interface IBreweryService
    {
        Task<IEnumerable<Venue>> GetVenuesAsync();
    }
}
