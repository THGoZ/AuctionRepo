using Auction.Core.Data;
using AuctionWebApi.Services;
using AuctionWebApi.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddControllers().AddJsonOptions(x =>//evita las referencias circulares (padre referencia al hijo y viceversa)
   x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);

#region Injeccion de DBcontext
builder.Services.AddDbContext<AuctionDBContext>(x =>
{
    var connectionString = builder.Configuration.GetConnectionString("AuctionDbConnect");
    x.UseSqlServer(connectionString);
});
#endregion

#region Servicio para cerrar y abrir subastas
builder.Services.AddScoped<ISubastaService, SubastaService>();
builder.Services.AddHostedService<SubastaOpenCloseService>();

#endregion


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
