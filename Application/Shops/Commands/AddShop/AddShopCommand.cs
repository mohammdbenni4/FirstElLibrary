using Domain.Models;
using MediatR;
namespace Application.Shops.Commands.AddShop
{
    public class AddShopCommand : IRequest<Shop>
    {
        public string? Name { get; set; }
        public string? ShopCategoryId { get; set; }
    }
}
