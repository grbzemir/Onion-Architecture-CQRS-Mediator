using Api.Application.Features.MediatorDesignPattern.Commands.CastCommands;
using Api.Persistence.Context;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Application.Features.MediatorDesignPattern.Handlers.TagHandlers
{
    public class UpdateCastCommandHandler : IRequestHandler<UpdateCastCommand>
    {
        private readonly MovieContext _context;

        public UpdateCastCommandHandler(MovieContext context)
        {
            _context = context;
        }
        public async Task Handle(UpdateCastCommand request, CancellationToken cancellationToken)
        {
             var values = await _context.Casts.FindAsync(request.CastId);
             
             values.Title = request.Title;
             await _context.SaveChangesAsync(cancellationToken);
             

        }
    }
}
