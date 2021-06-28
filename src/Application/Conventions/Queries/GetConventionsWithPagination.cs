using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Talks.Application.Common.Interfaces;
using Talks.Application.Common.Mappings;
using Talks.Application.Common.Models;

namespace Talks.Application.Conventions.Queries
{
    public class GetConventionsWithPagination : IRequest<PaginatedList<ConventionDto>>
    {
        public string Title { get; set; }
        public int PageNumber { get; set; } = 1;
        public int PageSize { get; set; } = 10;
    }

    public class GetConventionsWithPaginationHandler : IRequestHandler<GetConventionsWithPagination, PaginatedList<ConventionDto>>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;

        public GetConventionsWithPaginationHandler(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<PaginatedList<ConventionDto>> Handle(GetConventionsWithPagination request, CancellationToken cancellationToken)
        {
            var conventions = _context.Conventions.AsQueryable();

            if (!string.IsNullOrEmpty(request.Title))
            {
                conventions = conventions.Where(convention => convention.Title.Contains(request.Title));
            }

            return await conventions
                .ProjectTo<ConventionDto>(_mapper.ConfigurationProvider)
                .PaginatedListAsync(request.PageNumber, request.PageSize);
        }
    }
}
