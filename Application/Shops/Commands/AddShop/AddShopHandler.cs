using Domain.Models;
using MediatR;

namespace Application.Shops.Commands.AddShop
{
    public class AddShopHandler : IRequestHandler<AddShopCommand, Shop>
    {
        public Task<Shop> Handle(AddShopCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

       
    }
}
