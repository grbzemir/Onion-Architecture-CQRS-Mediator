﻿using Api.Application.Features.MediatorDesignPattern.Results.CastResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Application.Features.MediatorDesignPattern.Queries.CastQueries
{
    public class GetCastByIdQuery:IRequest<GetCastByIdQueryResult>
    {
        public int CastId { get; set; }

        public GetCastByIdQuery(int castId)
        {
            CastId = castId;
        }
    }
}
