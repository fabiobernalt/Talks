using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Talks.Application.Talks.Commands.CreateTalk;
using Talks.Application.Talks.Commands.InviteSpeaker;

namespace Talks.API.Controllers
{
    public class TalkController : ApiControllerBase
    {
        [HttpPost]
        public async Task<ActionResult<int>> Create(CreateTalkCommand command)
        {
            return await Mediator.Send(command);
        }

        [HttpPut("[action]")]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult> InviteSpeaker(int id, InviteSpeakerCommand command)
        {
            await Mediator.Send(command);

            return NoContent();
        }
    }
}
