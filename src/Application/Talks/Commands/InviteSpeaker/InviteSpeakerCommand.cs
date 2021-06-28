using MediatR;
using System.Threading;
using System.Threading.Tasks;
using Talks.Application.Common.Interfaces;
using Talks.Domain.Enums;

namespace Talks.Application.Talks.Commands.InviteSpeaker
{
    public class InviteSpeakerCommand : IRequest
    {
        public int UserId { get; set; }
    }

    public class InviteSpeakerCommandHandler : IRequestHandler<InviteSpeakerCommand>
    {
        private readonly ICurrentUserService _currentUserService;
        private readonly IAuth0Service _auth0Service;

        public InviteSpeakerCommandHandler(ICurrentUserService currentUserService, IAuth0Service auth0Service)
        {
            _currentUserService = currentUserService;
            _auth0Service = auth0Service;
        }

        public Task<Unit> Handle(InviteSpeakerCommand request, CancellationToken cancellationToken)
        {
            var userId = _currentUserService.UserId;
            _auth0Service.AddRoleToUserAsync(userId, Roles.Speaker);

            return Unit.Task;
        }
    }
}
