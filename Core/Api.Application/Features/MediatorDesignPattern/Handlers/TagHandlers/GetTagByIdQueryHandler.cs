using Api.Application.Features.MediatorDesignPattern.Queries.TagQueries;
using Api.Application.Features.MediatorDesignPattern.Results.TagResults;
using Api.Domain.Entities;
using Api.Persistence.Context;
using Azure;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Application.Features.MediatorDesignPattern.Handlers.TagHandlers
{
    public class GetTagByIdQueryHandler : IRequestHandler<GetTagByIdQuery, GetTagByIdQueryResult>
    {
        private readonly MovieContext _context;

        public GetTagByIdQueryHandler(MovieContext context)
        {
            _context = context;
        }
        public async Task<GetTagByIdQueryResult> Handle(GetTagByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _context.Tags.FindAsync(request.TagId);

            if (values == null)
            {
               
                return null;
            }

            return new GetTagByIdQueryResult
            {
                
                Title = values.Title,
            };

        }
    }
}
