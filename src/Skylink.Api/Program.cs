using Microsoft.EntityFrameworkCore;
using Skylink.Api;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<SkylinkDbContext>(options =>
{
    options.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;Database=Skylink;Integrated Security=sspi;");
    //options.UseSqlServer("Data Source=skylink-db.rumos.cloud;Database=Skylink;User Id=sa;Password=rumos123!;TrustServerCertificate=true;");
});

// TODO: Register services here

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapControllers();

app.Run();