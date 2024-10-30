using CS.Media.Infrastructure;
using CS.Media.Infrastructure.Utils;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddInfrastructure(builder.Configuration);
builder.Services.AddControllers()
     .AddJsonOptions(options =>
     {
         options.JsonSerializerOptions.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull;
     });

builder.Host.ConfigureLogging(builder.Configuration);

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseCustomExceptionHandlingMiddleware();

app.UseAuthorization();

app.MapControllers();

await MigrationUtil.ApplyMigrationsAndSeed(app);

app.Run();
