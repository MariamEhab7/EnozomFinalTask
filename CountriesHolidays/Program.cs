using BL;
using DAL;
using DAL.Context;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

#region Database
builder.Services.AddDbContext<CountryDbContext>(options =>
{
    string connectionString = builder.Configuration.GetConnectionString("Default");
    options.UseMySql(connectionString,
        ServerVersion.AutoDetect(connectionString),
        mySqlOptions =>
            mySqlOptions.EnableRetryOnFailure(
                maxRetryCount: 10,
                maxRetryDelay: TimeSpan.FromSeconds(30),
                errorNumbersToAdd: null)
            );
});
#endregion

#region Services

builder.Services.AddSingleton<HttpService>();
builder.Services.AddScoped<ICountriesServices, CountryServices>();
builder.Services.AddScoped<ICountriesRepo, CountriesRepo>();
builder.Services.AddScoped<IHolidayRepo, HolidayRepo>();
builder.Services.AddScoped<ICountriesServices, CountryServices>();
builder.Services.AddScoped<IHolidayServices, HolidayServices>();

builder.Services.AddAutoMapper(typeof(AutoMapperProfile).Assembly);

#endregion

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
