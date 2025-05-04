
using Business.Abstracts;
using Business.Concretes;
using Microsoft.EntityFrameworkCore;
using Repositories.Abstacts;
using Repositories.Concretes;
using Repositories.Concretes.EntityFramework.Contexts;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<BaseDbContext>(op => op.UseSqlServer(builder.Configuration.GetConnectionString("EfConfiguration")));
//builder.Services.AddScoped<IConfiguration>();
builder.Services.AddHttpContextAccessor();


builder.Services.AddScoped<IUserService, UserManager>();     //her http request bir kez olusturulur
builder.Services.AddScoped<IUserRepository, UserRepository>();

builder.Services.AddScoped<IInstructorService, InstructorManager>();     //her http request bir kez olusturulur
builder.Services.AddScoped<IInstructorRepository, InstructorRepository>();



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
