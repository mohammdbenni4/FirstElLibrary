using Domain;
using Microsoft.EntityFrameworkCore;
using Application;
using System.Text.Json.Serialization;
using Elkood.DependencyInjection;
using Elkood.API.Swagger;
using Autofac.Extensions.DependencyInjection;
using Infrastructure;
using DeliveryProjectApi.Util;
using StackExchange.Redis;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//var container = AutoFac.BuildContainer();

builder.Configuration.AddJsonFile("appsettings.json",optional:false,reloadOnChange:true)
    .AddEnvironmentVariables();

builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());


builder.Services.AddControllers().AddJsonOptions(o =>
{
    o.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
    o.JsonSerializerOptions.WriteIndented = true;
    o.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
});
AppContext.SetSwitch("System.Drawing.EnableUnixSupport", true);

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddElRepository(Application.AssemblyReference.Assembly,
   Infrastructure.AssemblyReference.Assembly,
        Domain.AssemblyReference.Assembly);

builder.Services.ConfigureElRepository(o=>o.OrderByDescending("DateCreated"));

builder.Services.AddSingleton<IConnectionMultiplexer>(provider =>
{
    var options = ConfigurationOptions.Parse(builder.Environment.IsDevelopment() ? "localhost" : "localhost:6380,password=testredis");
    options.ConnectRetry = 5;
    options.AllowAdmin = true;
    options.ClientName = "Delivery";
    options.AbortOnConnectFail = false;
    return ConnectionMultiplexer.Connect(options);
});

builder.Services.AddStackExchangeRedisCache(options =>
{
    options.Configuration = builder.Environment.IsDevelopment() ? "localhost" : "localhost:6380,password=testredis";
    options.InstanceName = "Elan";

});


builder.Services
   .AddInfrastructure(builder.Configuration,builder.Environment)
   .AddElkood(
        Application.AssemblyReference.Assembly,
        Infrastructure.AssemblyReference.Assembly
        //Domain.AssemblyReference.Assembly
    );



builder.Services.AddDbContext<ApplicationDbContext>(o =>
        o.UseNpgsql(builder.Configuration.GetConnectionString("MyConnection"), b => b.MigrationsAssembly("DeliveryProjectApi"))
    );

//builder.Services.AddMediatR(o => o.RegisterServicesFromAssemblies(typeof(Program).Assembly));
builder.Services.AddApplication();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseElSawgger<ElApiGroupNames>();
app.UseCors(policyBuilder =>
{
    policyBuilder
        .AllowAnyHeader()
        .AllowAnyMethod()
        .AllowCredentials()
        .SetIsOriginAllowed(_ => true);
});

//app.UseElIdentity();
//app.UseEndpoints(endpoints =>
 //   endpoints.MapControllers());



ElProtoBuf.Initial();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

public partial class Startup
{
}
