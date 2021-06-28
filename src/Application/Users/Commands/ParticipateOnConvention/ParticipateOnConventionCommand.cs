using MediatR;
using System.Threading;
using System.Threading.Tasks;
using Talks.Application.Common.Interfaces;

namespace Talks.Application.Users.Commands.ParticipateOnConvention
{
    public class ParticipateOnConventionCommand : IRequest
    {
        public int UserId { get; set; }
        public int ConventionId { get; set; }
    }

    public class ParticipateOnConventionCommandHandle : IRequestHandler<ParticipateOnConventionCommand>
    {
        private readonly IApplicationDbContext _context;

        public ParticipateOnConventionCommandHandle(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(ParticipateOnConventionCommand request, CancellationToken cancellationToken)
        {
            var convention = await _context.Conventions.FindAsync(request.ConventionId);
            var participant = await _context.Users.FindAsync(request.UserId);

            convention.Participants.Add(participant);
            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
