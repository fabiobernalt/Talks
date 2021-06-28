using MediatR;
using System.Threading;
using System.Threading.Tasks;
using Talks.Application.Common.Interfaces;
using Talks.Domain.Entities;

namespace Talks.Application.Talks.Commands.CreateTalk
{
    public class CreateTalkCommand : IRequest<int>
    {
        public string Title { get; set; }
        public int UserId { get; set; }
    }

    public class CreateTalkCommandHandler : IRequestHandler<CreateTalkCommand, int>
    {
        private readonly IApplicationDbContext _context;

        public CreateTalkCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(CreateTalkCommand request, CancellationToken cancellationToken)
        {
            var entity = new Talk
            {
                Title = request.Title,
                SpeakerId = request.UserId
            };

            _context.Talks.Add(entity);

            await _context.SaveChangesAsync(cancellationToken);

            return entity.Id;
        }
    }
}
