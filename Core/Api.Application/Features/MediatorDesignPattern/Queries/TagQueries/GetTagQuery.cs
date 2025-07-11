using Api.Application.Features.MediatorDesignPattern.Results.TagResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Application.Features.MediatorDesignPattern.Queries.TagQueries
{
    public class GetTagQuery:IRequest<List<GetTagQueryResult>>
    {
    }
}
