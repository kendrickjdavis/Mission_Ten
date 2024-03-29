using Microsoft.EntityFrameworkCore;
using Mission_10.Data;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors();
// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddDbContext<BowlerContext>(options =>
    options.UseSqlite(builder.Configuration["ConnectionStrings:BowlerConnection"])
);
builder.Services.AddScoped<IBowlerRepository, EFBowlerRepository>();
var app = builder.Build();
// Configure the HTTP request pipeline.

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors(p => p.WithOrigins("http://localhost:3000"));

app.UseAuthorization();
app.MapControllers();
app.Run();
