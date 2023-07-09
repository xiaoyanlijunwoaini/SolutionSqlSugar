using WebApplication1.Service.Config;
using AutoMapper.Execution;
using AutoMapper;
using WebApplication1.Service.Flower;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//builder.Services.AddAutoMapper(typeof(AutoMapperConfig));

AutoMapper.IConfigurationProvider config = new MapperConfiguration(cfg =>
{
    cfg.AddProfile<AutoMapperConfig>();
});
builder.Services.AddSingleton(config);
builder.Services.AddScoped<IMapper, Mapper>();
builder.Services.AddTransient<IflowerService, FlowerService>();

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
