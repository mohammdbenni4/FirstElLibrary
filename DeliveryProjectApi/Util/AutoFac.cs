using Autofac;
using Domain;
using Elkood.Domain.Repository;

namespace DeliveryProjectApi.Util
{
    public class AutoFac
    {
        public static IContainer BuildContainer()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<ElRepository<Guid,ApplicationDbContext>>().As<IElRepository>();
            
            return builder.Build();
        }
    }
}
