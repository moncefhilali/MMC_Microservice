using Microsoft.EntityFrameworkCore;
using Validator.Application.Interfaces;
using Validator.Application.IRepositories;
using Validator.Application.Mapping;
using Validator.Application.Services;
using Validator.Infrastructure.Data;
using Validator.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

string? con = builder.Configuration.GetConnectionString("con");
builder.Services.AddDbContext<DBC>(options => options.UseSqlServer(con));
builder.Services.AddScoped<IJoinEventRepository, JoinEventRepository>();
builder.Services.AddAutoMapper(typeof(AutoMapperProfile));
builder.Services.AddScoped<IJoinEventService, JoinEventService>();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
