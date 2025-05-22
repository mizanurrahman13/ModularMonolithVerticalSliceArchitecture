using Carter;
using ModularMonolith.Host.Seeding;
using ModularMonolith.Host;
using Modules.Carriers.Features;
using Modules.Carriers.Infrastructure.Database;
using Modules.Shipments.Features;
using Modules.Shipments.Infrastructure.Database;
using Modules.Stocks.Features;
using Modules.Stocks.Infrastructure.Database;
using Modules.Shipments.Infrastructure;
using Modules.Stocks.Infrastructure;
using Modules.Carriers.Infrastructure;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


builder.AddHostLogging();

builder.Services.AddWebHostInfrastructure();

builder.Services.AddShipmentsModule(builder.Configuration)
    .AddShipmentsInfrastructure(builder.Configuration);

builder.Services.AddStocksModule()
    .AddStocksInfrastructure(builder.Configuration);

builder.Services.AddCarriersModule()
    .AddCarriersInfrastructure(builder.Configuration);

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<ShipmentsDbContext>();
    await dbContext.Database.MigrateAsync();

    var carriersDbContext = scope.ServiceProvider.GetRequiredService<CarriersDbContext>();
    await carriersDbContext.Database.MigrateAsync();

    var stocksDbContext = scope.ServiceProvider.GetRequiredService<StocksDbContext>();
    await stocksDbContext.Database.MigrateAsync();

    var seedService = scope.ServiceProvider.GetRequiredService<SeedService>();
    await seedService.SeedDataAsync();
}

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapCarter();

app.Run();
