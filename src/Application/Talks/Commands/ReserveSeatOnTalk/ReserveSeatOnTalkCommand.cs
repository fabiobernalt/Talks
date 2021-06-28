using MediatR;
using System.Threading;
using System.Threading.Tasks;
using Talks.Application.Common.Interfaces;

namespace Talks.Application.Talks.Commands.ReserveSeatOnTalk
{
    public class ReserveSeatOnTalkCommand : IRequest
    {
        public int UserId { get; set; }
        public int TalkId { get; set; }
    }

    public class ReserveSeatOnTaskCommandHandler : IRequestHandler<ReserveSeatOnTalkCommand>
    {
        private readonly IApplicationDbContext _context;

        public ReserveSeatOnTaskCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(ReserveSeatOnTalkCommand request, CancellationToken cancellationToken)
        {
            var talk = await _context.Talks.FindAsync(request.TalkId);
            var participant = await _context.Users.FindAsync(request.UserId);

            talk.Participants.Add(participant);

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
