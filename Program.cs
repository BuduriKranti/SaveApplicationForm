using Microsoft.EntityFrameworkCore;
using SaveApplicationForm.Model;
using SaveApplicationForm.Repositories;
using SaveApplicationForm.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddScoped<IApplicationDetailsService, ApplicationDetailsService>();
builder.Services.AddScoped<IApplicationDetailsRepository, ApplicationDetailsRepository>();

builder.Services.AddDbContext<masterContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(options =>
{ 
        options.AddPolicy("AllowAnonymus", builder =>
            {
                builder.AllowAnyOrigin();
            });
});

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
