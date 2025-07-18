﻿using Api.Application.Features.MediatorDesignPattern.Commands.CastCommands;
using Api.Application.Features.MediatorDesignPattern.Queries.CastQueries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CastsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CastsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]

        public async Task<IActionResult> CastList()
        {
            var value = await _mediator.Send(new GetCastQuery());
            return Ok(value);
        }

        [HttpPost]

        public async Task<IActionResult> CreateCast([FromBody] CreateCastCommand command)
        {
            await _mediator.Send(command);
            return Ok("Cast ekleme işlemi başarılı");
        }

        [HttpDelete]

        public async Task<IActionResult> DeleteCast(int id)
        {
            await _mediator.Send(new RemoveCastCommand(id));
            return Ok("Silme işlemi başarılı");
        }

        [HttpPut]

        public async Task<IActionResult> UpdateCast([FromBody] UpdateCastCommand command)
        {
            await _mediator.Send(command);
            return Ok("Güncelleme işlemi başarılı");
        }

        [HttpGet("GetCastById")]

        public async Task<IActionResult> GetCastById(int id)
        {
            var value = await _mediator.Send(new GetCastByIdQuery(id));
            return Ok(value);

        }


    }
}
