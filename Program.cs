using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen( /* c =>
{
    c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo { Title = "ng10e2e-svc", Version = "v1", });
} */
);

var app = builder.Build();


//if (app.Environment.IsDevelopment())    2021-12-03 mtm; comment out: guarantees swagger endpoint in Release build at http://localhost/swagger/index.html (if using Docker Desktop kubernetes)
//{
app.UseSwagger();
app.UseSwaggerUI();
//}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
