using Api.Application.Features.CQRSDesignPattern.Commands.UserRegisterCommands;
using Api.Application.Features.CQRSDesignPattern.Handlers.UserRegisterHandlers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class RegistersController : ControllerBase
	{
		private readonly CreateUserRegisterCommandHandler _createUserRegisterCommandHandler;

        public RegistersController(CreateUserRegisterCommandHandler createUserRegisterCommandHandler)
        {
            _createUserRegisterCommandHandler = createUserRegisterCommandHandler;
        }

		[HttpPost]

		public async Task<IActionResult> CreateUserRegister([FromBody] CreateUserRegisterCommand command)

		{

			if (command == null)
			{
				return BadRequest("Invalid user registration data.");
			}

			try

			{

				await _createUserRegisterCommandHandler.Handle(command);
				return Ok("User registered successfully.");

			}

			catch (Exception ex)

			{
				return StatusCode(StatusCodes.Status500InternalServerError, $"Error registering user: {ex.Message}");

			}
		}

    }
}
