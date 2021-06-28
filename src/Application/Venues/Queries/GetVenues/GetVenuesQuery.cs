using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Talks.Application.Common.Interfaces;

namespace Talks.Application.Venues.Queries.GetVenues
{
    public class GetVenuesQuery : IRequest<List<VenueDto>>
    {
        public int PageNumber { get; set; } = 1;
        public int PageSize { get; set; } = 10;
    }

    public class GetTodosQueryHandler : IRequestHandler<GetVenuesQuery, List<VenueDto>>
    {
        private readonly IMapper _mapper;
        private readonly IBreweryService _breweryService;

        public GetTodosQueryHandler(IMapper mapper, IBreweryService breweryService)
        {
            _mapper = mapper;
            _breweryService = breweryService;
        }

        async Task<List<VenueDto>> IRequestHandler<GetVenuesQuery, List<VenueDto>>.Handle(GetVenuesQuery request, CancellationToken cancellationToken)
        {
            return _mapper.Map<List<VenueDto>>(await _breweryService.GetVenuesAsync());
        }
    }
}
