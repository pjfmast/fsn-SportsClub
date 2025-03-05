using Microsoft.EntityFrameworkCore;
using Microsoft.Net.Http.Headers;
using SportsClub.Api.Data;
using SportsClub.Api.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

// Les 2. For using EF with SportClubContext

// Option 1: in lesson 1 we used the SportsClubInMemoryRepository
//builder.Services.AddScoped<ISportsClubRepository, SportsClubInMemoryRepository>();

builder.Services.AddDbContext<SportsClubDbContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("SportsClubDbConnection"))
);
// option 2. in lesson 2 we use using ef and sportclubdbrepository
builder.Services.AddScoped<ISportsClubRepository, SportsClubDbRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

// See: https://learn.microsoft.com/en-us/aspnet/core/security/cors#attr
app.UseCors(policy =>
    policy.WithOrigins("http://localhost:5032", "https://localhost:7092")
    .AllowAnyMethod()
    .WithHeaders(HeaderNames.ContentType)
);

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
