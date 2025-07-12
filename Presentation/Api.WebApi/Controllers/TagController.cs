using Api.Application.Features.MediatorDesignPattern.Commands.TagCommands;
using Api.Application.Features.MediatorDesignPattern.Queries.TagQueries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TagController : ControllerBase
    {
        private readonly IMediator _mediator;

        public TagController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]

        public async Task<IActionResult> TagList()
        {
            var value = await _mediator.Send(new GetTagQuery());
            return Ok(value);
        }

        [HttpPost]

        public async Task<IActionResult> CreateTag([FromBody] CreateTagCommand command)
        {
            await _mediator.Send(command);
            return Ok("Tag ekleme işlemi başarılı");
        }

        [HttpDelete]

        public async Task<IActionResult> DeleteTag(int id)
        {
            await _mediator.Send(new RemoveTagCommand(id));
            return Ok("Silme işlemi başarılı");
        }

        [HttpPut]

        public async Task<IActionResult> UpdateTag([FromBody] UpdateTagCommand command)
        {
            await _mediator.Send(command);
            return Ok("Güncelleme işlemi başarılı");
        }


        [HttpGet("GetTag")]

        public async Task<IActionResult> GetTag(int id)
        {
            var value = await _mediator.Send(new GetTagByIdQuery(id));
            if (value == null)
                return NotFound($"Id={id} ile eşleşen tag bulunamadı.");
            return Ok(value);

        }

    }
}
