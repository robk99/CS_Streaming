using CS.Session.Infrastructure;
using CS.Session.Infrastructure.Utils;
using Hangfire;
using System.Text.Json.Serialization;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Host.ConfigureLogging(builder.Configuration);

builder.Services.AddInfrastructure(builder.Configuration);
builder.Services.AddControllers()
     .AddJsonOptions(options =>
     {
         options.JsonSerializerOptions.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull;
     });

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "CS_Session_API", Version = "v1" });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "CS_Session_API v1");
    });
}

app.UseCustomExceptionHandlingMiddleware();

app.MapHangfireDashboard();

app.UseAuthorization();

app.MapControllers();

await MigrationUtil.ApplyMigrationsAndSeed(app);

app.Run();

