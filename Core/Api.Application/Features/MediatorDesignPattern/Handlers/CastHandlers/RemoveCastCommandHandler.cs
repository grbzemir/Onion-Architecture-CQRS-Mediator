﻿using Api.Application.Features.MediatorDesignPattern.Commands.CastCommands;
using Api.Persistence.Context;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Application.Features.MediatorDesignPattern.Handlers.CastHandlers
{
    public class RemoveCastCommandHandler : IRequestHandler<RemoveCastCommand>
    {
        private readonly MovieContext _context;

        public RemoveCastCommandHandler(MovieContext context)
        {
            _context = context;
        }
        public async Task Handle(RemoveCastCommand request, CancellationToken cancellationToken)
        {
            var values = await _context.Casts.FindAsync(request.CastId);
            _context.Casts.Remove(values);
            await _context.SaveChangesAsync();
        }
    }
}
