using EmployeeBL.Interfaces;
using EmployeeBL.Services;
using EmployeeRepo;
using EmployeeRepo.Interfaces;
using EmployeeRepo.Repos;
using Microsoft.EntityFrameworkCore;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddDbContextPool<EmployeeContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("EmpContextConnectionString"));
});
builder.Services.AddScoped<IEmpRepo, EmpRepo>();
builder.Services.AddScoped<IEmpBL, EmpBL>();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(p => p.AddPolicy("corsapp", builder =>
{
    builder.WithOrigins("*").AllowAnyMethod().AllowAnyHeader();
}));



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors("corsapp");
app.UseAuthorization();

app.MapControllers();

app.Run();
