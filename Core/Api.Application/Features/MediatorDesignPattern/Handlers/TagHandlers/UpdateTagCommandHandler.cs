﻿using Api.Application.Features.MediatorDesignPattern.Commands.CastCommands;
using Api.Application.Features.MediatorDesignPattern.Commands.TagCommands;
using Api.Persistence.Context;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Application.Features.MediatorDesignPattern.Handlers.TagHandlers
{
    public class UpdateTagCommandHandler : IRequestHandler<UpdateTagCommand>
    {
        private readonly MovieContext _context;

        public UpdateTagCommandHandler(MovieContext context)
        {
            _context = context;
        }
        public async Task Handle(UpdateTagCommand request, CancellationToken cancellationToken)
        {
             var values = await _context.Tags.FindAsync(request.TagId);
             
             values.Title = request.Title;
             await _context.SaveChangesAsync();
             

        }
    }
}
