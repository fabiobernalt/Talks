using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using Talks.Application.Common.Interfaces;
using Talks.Domain.Entities;

namespace Talks.Application.Conventions.Commands.CreateConvention
{
    public class CreateConventionCommand : IRequest<int>
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int LocationExternalId { get; set; }
        public string LocationExternalName { get; set; }
    }

    public class CreateConventionCommandHandler : IRequestHandler<CreateConventionCommand, int>
    {
        private readonly IApplicationDbContext _context;

        public CreateConventionCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(CreateConventionCommand request, CancellationToken cancellationToken)
        {
            var entity = new Convention
            {
                Title = request.Title,
                Description = request.Description,
                LocationExternalId = request.LocationExternalId,
                LocationExternalName = request.LocationExternalName,
                StartDate = request.StartDate,
                EndDate = request.EndDate
            };

            _context.Conventions.Add(entity);

            await _context.SaveChangesAsync(cancellationToken);

            return entity.Id;
        }
    }
}
