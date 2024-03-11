using CleanAchitecture.Application;
using CleanAchitecture.Infrastructure;
using CleanAchitecture.Persistence;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddApplicationServices(builder.Configuration);
builder.Services.AddSwaggerService();
builder.Services.AddInfrastructureServices(builder.Configuration);
builder.Services.AddPersistenceServices(builder.Configuration);


var app = builder.Build();

ApplicationServiceRegistration.AddApplicationBuilder(app);

app.Run();


