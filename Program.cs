using TESTAPI.Implementations;
using TESTAPI.Services;
using TESTAPI.Interfaces;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IDescuento, DescuentoVip>();
builder.Services.AddScoped<IDescuento, DescuentoRegular>();

builder.Services.AddScoped<IPagoRepository, PagoRepository>();
builder.Services.AddScoped<INotificador, EmailNotificador>();
builder.Services.AddScoped<PagoService>();
// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
