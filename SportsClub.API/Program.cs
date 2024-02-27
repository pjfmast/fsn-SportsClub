using SportsClub.API.Repositories.Contracts;
using SportsClub.API.Repositories;
using Microsoft.Net.Http.Headers;
using SportsClub.API.Data;
using Microsoft.EntityFrameworkCore;
using SportsClub.API.Configuration;
using SportsClub.API.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Les 2. For using EF with SportClubContext
builder.Services.AddDbContext<SportsClubDbContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("SportsClubDbConnection"))
);
// Option 1: in lesson 1 we used the SportsClubInMemoryRepository
//builder.Services.AddScoped<ISportsClubRepository, SportsClubInMemoryRepository>();

// Option 2. In lesson 2 we use using EF and SportClubDbRepository
builder.Services.AddScoped<ISportsClubRepository, SportsClubDbRepository>();

// Les 3. Added for EmailService
builder.Services.Configure<MailSettings>(builder.Configuration.GetSection(nameof(MailSettings)));
builder.Services.AddTransient<IMailService, MailService>();

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
