using Mapping.Mapping;
using Microsoft.EntityFrameworkCore;
using Repository.Generic;
using Tasks.Model;
using Tasks.Model.Entities;
using Tasks.Services.Job;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddTransient<IJobService, JobService>();


builder.Services.AddAutoMapper(typeof(MappingDTO));

builder.Services.AddTransient(typeof(IGenericRepository<>), typeof(GenericRepository<>));



builder.Services.AddDbContext<ContextDb>(opt =>
{
    opt.UseNpgsql(builder.Configuration.GetConnectionString("Conn"));
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
