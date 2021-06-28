using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;
using Talks.Domain.Entities;

namespace Talks.Application.Common.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<Talk> Talks { get; set; }
        DbSet<Convention> Conventions { get; set; }
        DbSet<User> Users { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
