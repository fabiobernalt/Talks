using MediatR;
using System.Threading;
using System.Threading.Tasks;
using Talks.Application.Common.Interfaces;

namespace Talks.Application.Users.Commands.ReserveSeatOnTalk
{
    public class ReserveSeatOnTalkCommand : IRequest
    {
        public int TalkId { get; set; }
        public int UserId { get; set; }
    }

    public class ReserveSeatOnTalkCommandHandler : IRequestHandler<ReserveSeatOnTalkCommand>
    {
        private readonly IApplicationDbContext _context;

        public ReserveSeatOnTalkCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(ReserveSeatOnTalkCommand request, CancellationToken cancellationToken)
        {
            var talk = await _context.Talks.FindAsync(request.TalkId);
            var user = await _context.Users.FindAsync(request.UserId);

            talk.Participants.Add(user);

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
