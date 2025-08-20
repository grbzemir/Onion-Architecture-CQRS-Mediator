using Api.Application.Features.CQRSDesignPattern.Commands.UserRegisterCommands;
using Api.Persistence.Context;
using Api.Persistence.Identity;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Application.Features.CQRSDesignPattern.Handlers.UserRegisterHandlers
{
    public class CreateUserRegisterCommandHandler
    {
        private readonly MovieContext _movieContext;
        private readonly UserManager<AppUser> _UserManager;

        public CreateUserRegisterCommandHandler(MovieContext movieContext , UserManager<AppUser> UserManager)
        {
            _movieContext = movieContext;
			_UserManager = UserManager;
        }

        public async Task Handle(CreateUserRegisterCommand command)
        {
            var user = new AppUser
            {
                Name = command.Name,
                Surname = command.Surname,
                UserName = command.Username,
                Email = command.Email
            };

            await _UserManager.CreateAsync(user, command.Password);

        }
    }
}
