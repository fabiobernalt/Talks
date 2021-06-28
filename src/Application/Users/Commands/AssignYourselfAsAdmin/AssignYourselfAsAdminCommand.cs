using MediatR;
using System.Threading;
using System.Threading.Tasks;
using Talks.Application.Common.Interfaces;

namespace Talks.Application.Users.Commands.AssignYourselfAsAdmin
{
    public class AssignYourselfAsAdminCommand : IRequest
    {

    }

    public class AssignYourselfAsAdminCommandHandler : IRequestHandler<AssignYourselfAsAdminCommand>
    {
        private readonly ICurrentUserService _currentUserService;
        private readonly IAuth0Service _auth0Service;

        public AssignYourselfAsAdminCommandHandler(ICurrentUserService currentUserService, IAuth0Service auth0Service)
        {
            _currentUserService = currentUserService;
            _auth0Service = auth0Service;
        }
        public async Task<Unit> Handle(AssignYourselfAsAdminCommand request, CancellationToken cancellationToken)
        {
            await _auth0Service.AddRoleToUserAsync(_currentUserService.UserId, Domain.Enums.Roles.Admin);

            return Unit.Value;
        }
    }
}
