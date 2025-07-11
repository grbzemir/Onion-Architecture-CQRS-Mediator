using Api.Application.Features.MediatorDesignPattern.Commands.TagCommands;
using Api.Domain.Entities;
using Api.Persistence.Context;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Application.Features.MediatorDesignPattern.Handlers.TagHandlers
{
    public class CreateTagCommandHandler:IRequestHandler<CreateTagCommand>
    {
        private readonly MovieContext _context;

        public CreateTagCommandHandler(MovieContext context)
        {
            _context = context;
        }

        public async Task Handle(CreateTagCommand request, CancellationToken cancellationToken)
        {
             _context.Tags.Add(new Tag
            {
                Title = request.Title,
            });

            await _context.SaveChangesAsync();
        }
    }
}
