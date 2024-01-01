﻿using Domain.Models;
using Elkood.Application.Core.Abstractions.Request;
using Elkood.Application.OperationResponses;

namespace Application.Cities.Commands.AddCity
{
    public class AddCityCommand 
    {
        public class Request : IRequest<OperationResponse<Response>>
        {
            public string? Name { get; set; }
        }

        public class Response
        {
            public Guid? Id { get; set; }
            public string? Name { get; set;}
        }
    }

}
