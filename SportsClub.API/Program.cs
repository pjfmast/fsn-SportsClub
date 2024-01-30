using SportsClub.API.Repositories.Contracts;
using SportsClub.API.Repositories;
using Microsoft.Net.Http.Headers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Added for SportsClub
builder.Services.AddScoped<ISportsClubRepository, SportsClubInMemoryRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
// See: https://learn.microsoft.com/en-us/aspnet/core/security/cors#attr
app.UseCors(policy =>
    policy.WithOrigins("http://localhost:5279", "https://localhost:7092")
    .AllowAnyMethod()
    .WithHeaders(HeaderNames.ContentType)
);

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
