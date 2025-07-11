using Api.Application.Features.MediatorDesignPattern.Results.TagResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Application.Features.MediatorDesignPattern.Queries.TagQueries
{
    public class GetTagByIdQuery:IRequest<GetTagByIdQueryResult>
    {
        public int TagId { get; set; }

        public GetTagByIdQuery(int tagId)
        {
            TagId = tagId;
        }
    }
}
