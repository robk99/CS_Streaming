using CS.Session.Infrastructure;
using Hangfire;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddInfrastructure(builder.Configuration);
builder.Services.AddControllers()
     .AddJsonOptions(options =>
     {
         options.JsonSerializerOptions.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull;
     }); ;

var app = builder.Build();

// Configure the HTTP request pipeline.
app.MapHangfireDashboard();

//app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();


app.Run();
