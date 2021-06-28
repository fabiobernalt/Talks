using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Talks.Application.Users.Commands.AssignAdmin;
using Talks.Application.Users.Commands.CreateUser;

namespace Talks.API.Controllers
{
    public class UserController : ApiControllerBase
    {
        [HttpPost]
        public async Task<ActionResult<int>> Create(CreateUserCommand command)
        {
            return await Mediator.Send(command);
        }

        [HttpPut("[action]")]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult> AssignAdmin(AssignAdminCommand command)
        {
            await Mediator.Send(command);

            return Ok();
        }

        [HttpPut("[action]")]
        public async Task<ActionResult> AssignYourselfAsAdmin(AssignAdminCommand command)
        {
            await Mediator.Send(command);
            return Ok();
        }
    }
}
