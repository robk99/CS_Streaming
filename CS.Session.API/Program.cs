using CS.Session.Infrastructure;
using CS.Session.Infrastructure.Utils;
using Hangfire;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddInfrastructure(builder.Configuration);
builder.Services.AddControllers()
     .AddJsonOptions(options =>
     {
         options.JsonSerializerOptions.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull;
     });

var app = builder.Build();

// Configure the HTTP request pipeline.
app.MapHangfireDashboard();

app.UseAuthorization();

app.MapControllers();

MigrationUtil.ApplyMigrationsAndSeed(app);

app.Run();

