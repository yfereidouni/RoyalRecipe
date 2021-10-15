using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoyalRecipe.Core.ApplicationServices.Tags.Commands.Add;
using System.Threading.Tasks;

namespace RoyalRecipe.Endpoints.API.Tags
{
    [Route("api/[controller]")]
    [ApiController]
    public class TagsController : ControllerBase
    {
        private readonly IMediator mediator;

        public TagsController(IMediator mediator)
        {
            this.mediator = mediator;
        }
        [HttpPost]
        public async Task<IActionResult> Post(AddTagCommand addTagCommand)
        {
            var result = await mediator.Send(addTagCommand);
            return StatusCode(201, result);
        }
    }
}
