using Domain;
using Domain.Interfaces;

using Domain.Models;
using Elkood.Application.Core.Abstractions.Request;
using Elkood.Application.OperationResponses;
using Elkood.Domain.Repository;

namespace Application.Cities.Commands.AddCity
{
    public class AddCityHandler : IRequestHandler<AddCityCommand.Request, OperationResponse<AddCityCommand.Response>>
    {
        private readonly IElRepository<Guid> _elRepository;
        private readonly ApplicationDbContext _context;
        public AddCityHandler( ApplicationDbContext context)
        {
            _context = context;
        }

       

        public async Task<OperationResponse<AddCityCommand.Response>> HandleAsync(AddCityCommand.Request request,
            CancellationToken cancellationToken = new())
        {
            var rr = new AddCityCommand.Response { Id = Guid.NewGuid(), Name = request.Name };
            var city = new City { Id = (Guid)rr.Id, Name = rr.Name }; 
            await _elRepository.AddAsync(city);
            await _elRepository.UnitOfWork.SaveChangesAsync(cancellationToken);
            return rr;

        }
    }
}
