using MediatR;
using System.Threading;
using System.Threading.Tasks;
using Talks.Application.Common.Interfaces;
using Talks.Domain.Enums;

namespace Talks.Application.Users.Commands.AssignAdmin
{
    public class AssignAdminCommand : IRequest
    {
        public string ExternalId { get; set; }
        public int UserId { get; set; }
    }

    public class AssignAdminCommandHandler : IRequestHandler<AssignAdminCommand>
    {
        private readonly IApplicationDbContext _context;
        private readonly IAuth0Service _auth0Service;

        public AssignAdminCommandHandler(IApplicationDbContext context, IAuth0Service auth0Service)
        {
            _context = context;
            _auth0Service = auth0Service;
        }

        public async Task<Unit> Handle(AssignAdminCommand request, CancellationToken cancellationToken)
        {
            var user = await _context.Users.FindAsync(request.UserId);
            await _auth0Service.AddRoleToUserAsync(user.ExternalId, Roles.Admin);

            return Unit.Value;
        }
    }
}
