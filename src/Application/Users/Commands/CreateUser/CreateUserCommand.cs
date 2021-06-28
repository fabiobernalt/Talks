using MediatR;
using System.Threading;
using System.Threading.Tasks;
using Talks.Application.Common.Interfaces;
using Talks.Domain.Entities;
using Talks.Domain.Enums;

namespace Talks.Application.Users.Commands.CreateUser
{
    public class CreateUserCommand : IRequest<int>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Picture { get; set; }
        public string ExternalId { get; set; }
    }

    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, int>
    {
        private readonly IApplicationDbContext _context;
        private readonly IAuth0Service _auth0Service;

        public CreateUserCommandHandler(IApplicationDbContext context, IAuth0Service auth0Service)
        {
            _context = context;
            _auth0Service = auth0Service;
        }

        public async Task<int> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            await _auth0Service.AddRoleToUserAsync(request.ExternalId, Roles.Participant);

            var entity = new User
            {
                FirstName = request.FirstName,
                LastName = request.LastName,
                Email = request.Email,
                Picture = request.Picture,
                ExternalId = request.ExternalId
            };

            _context.Users.Add(entity);

            await _context.SaveChangesAsync(cancellationToken);

            return entity.Id;
        }
    }
}
