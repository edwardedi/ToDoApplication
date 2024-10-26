using Application.Use_Cases.Commands;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ToDoApplication.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ToDoItemsController : ControllerBase
    {
        private readonly IMediator mediator;

        public ToDoItemsController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpPost]
        public async Task<ActionResult<Guid>> CreateToDoItem(CreateToDoItemCommand command)
        {
            return await mediator.Send(command); 
        }
    }
}
