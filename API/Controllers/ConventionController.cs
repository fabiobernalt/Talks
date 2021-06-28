using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Talks.Application.Common.Models;
using Talks.Application.Conventions.Commands.CreateConvention;
using Talks.Application.Conventions.Queries;

namespace Talks.API.Controllers
{
    public class ConventionController : ApiControllerBase
    {
        
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult<int>> Create(CreateConventionCommand command)
        {
            return await Mediator.Send(command);
        }

        [HttpGet]
        public async Task<ActionResult<PaginatedList<ConventionDto>>> GetConventionsWithPagination([FromQuery] GetConventionsWithPagination command)
        {
            return await Mediator.Send(command);
        }
    }
}
