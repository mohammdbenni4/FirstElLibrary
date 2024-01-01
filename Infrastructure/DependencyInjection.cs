using Elkood.Application.Core.Abstractions.Data;
using Elkood.DependencyInjection;
using Elkood.Domain.Core.Culture;
using Elkood.Infrastructure.Languages;
using Domain;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;


namespace Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration, IWebHostEnvironment environment)
    {
        services.AddElDbContext<IDbContext<Guid>, ApplicationDbContext>
        (o =>
        {
            o.UseNpgsql(configuration.GetConnectionString("DefaultConnection"));
            if (environment.IsDevelopment())
            {
                o.EnableSensitiveDataLogging();
            }
        }, enableLegacyTimestampBehavior: true);
       
        
        Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", @"translate.json");
        
        services.ConfigureElLanguages(options =>
            options.DefaultLanguage(LanguageCode.en).Languages(LanguageCode.nl, LanguageCode.ar));
        services.ConfigureElRepository(o => { o.OrderByDescending("DateCreated"); });


        return services;
    }
}