using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using Talks.Application.Venues.Queries.GetVenues;

namespace Talks.API.Controllers
{
    public class VenueController : ApiControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<VenueDto>>> Get()
        {
            return await Mediator.Send(new GetVenuesQuery());
        }
    }
}
