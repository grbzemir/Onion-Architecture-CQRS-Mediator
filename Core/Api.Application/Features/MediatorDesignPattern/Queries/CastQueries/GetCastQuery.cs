using Api.Application.Features.MediatorDesignPattern.Results.CastResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Application.Features.MediatorDesignPattern.Queries.CastQueries
{
    public class GetCastQuery:IRequest<List<GetCastQueryResult>>
    {
    }
}
