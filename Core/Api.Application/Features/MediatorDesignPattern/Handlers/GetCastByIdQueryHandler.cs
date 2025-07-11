using Api.Application.Features.MediatorDesignPattern.Queries.CastQueries;
using Api.Application.Features.MediatorDesignPattern.Results.CastResults;
using Api.Persistence.Context;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Application.Features.MediatorDesignPattern.Handlers
{
    public class GetCastByIdQueryHandler : IRequestHandler<GetCastByIdQuery, GetCastByIdQueryResult>
    {
        private readonly MovieContext _context;

        public GetCastByIdQueryHandler(MovieContext context)
        {
            _context = context;
        }
        public async Task<GetCastByIdQueryResult> Handle(GetCastByIdQuery request, CancellationToken cancellationToken)
        {
           var values = _context.Casts.Find(request.CastId);

            if(values == null)
            {
                return null; 
            }

            return new GetCastByIdQueryResult
            {
                CastId = values.CastId,
                Biography = values.Biography,
                ImageUrl = values.ImageUrl,
                Name = values.Name,
                Overview = values.Overview,
                Surname = values.Surname,
                Title = values.Title
            };
           
        }
    }
}
