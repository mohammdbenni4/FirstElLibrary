using Application.Cities.Commands.AddCity;
using DeliveryProjectApi.Util;
using Domain.Models;
using Elkood.API.Controller;
using Elkood.API.Swagger;
using Elkood.Application.Core.Abstractions.Request;
using Elkood.Application.OperationResponses;
using Elkood.Identity.Policies.Permission;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
namespace DeliveryProjectApi.Controllers
{
   
   
    public class DashboardController : ElApiController
    {


        [HttpPost, ElRoute(ElApiGroupNames.Dashboard), ElApiGroup(ElApiGroupNames.Dashboard)]
        [ProducesResponseType(typeof(AddCityCommand.Response), StatusCodes.Status200OK)]
        public async Task<IActionResult> AddCity(
            [FromServices] IRequestHandler<AddCityCommand.Request, OperationResponse<AddCityCommand.Response>>handler,
            [FromBody]AddCityCommand.Request city)
          =>  await handler.HandleAsync(city).ToJsonResultAsync();


    }
}
