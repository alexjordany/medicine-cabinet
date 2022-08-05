using MedicineCabinet.API.Middleware;
using MedicineCabinet.Application;
using MedicineCabinet.Persistence;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);
IConfiguration configuration = builder.Configuration;

// Add services to the container.

builder.Services.AddApplicationServices();
builder.Services.AddPersistenceServices(configuration);
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "Medicine Cabinet API",
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Medicine Cabinet API");
    });
}

app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Medicine Cabinet API");
});

var scope = app.Services.CreateScope();
var medicineCabinetDbContext = scope.ServiceProvider.GetRequiredService<MedicineCabinetDbContext>();
medicineCabinetDbContext.Database.EnsureDeleted();
medicineCabinetDbContext.Database.EnsureCreated();

app.UseCustomExceptionHandler();
app.UseRouting();
app.UseHttpsRedirection();
app.UseCors("Open");

app.UseAuthorization();

app.MapControllers();

app.Run();

