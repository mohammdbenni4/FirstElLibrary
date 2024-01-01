using Domain.Models;
using Domain.ValueObjects;
using Elkood.Application.Core.Abstractions.Common;
using Elkood.Application.Core.Abstractions.Data;
using Elkood.Application.Dispatchers.DomainEventDispatcher;
using Elkood.Persistence.EntityFramework.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class ApplicationDbContext : ElDbContext<Guid> , IDbContext<Guid>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options,
            IDateTime dateTime,
            IDomainEventDispatcher domainEvent): base(options,dateTime,domainEvent) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<WorkTimeValueObject>().HasNoKey();

        }


        public DbSet<Shop> Shops { get; set; }
        public DbSet<Brunch> Brunches { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<ShopCategory> ShopCategories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductAddOne> productAddOnes { get; set; }
        public DbSet<OrdersBrunchesProduct> OrdersBrunchesProduct { get; set; }
        public DbSet<OrdersBrunches> OrdersBrunches { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<OrderStatus> OrderStatuses { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Neighborhood> Neighborhoods { get; set; }

        
        




    }
}
