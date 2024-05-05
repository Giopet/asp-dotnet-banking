using Banking.API.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

//// The required property will take a default value with this options and no bad request will return.
//// Dont forget to comment any check like this: if (!ModelState.IsValid).. examle in the put method.
//builder.Services.AddControllers()
//    .ConfigureApiBehaviorOptions(options =>
//    {
//        options.SuppressModelStateInvalidFilter = true; 
//    });

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<BankingContext>(options =>
{
    options.UseInMemoryDatabase("Banking");
});

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowSpecificOrigin",
        policyBuilder =>
        {
            policyBuilder
                .AllowAnyHeader()
                .AllowAnyMethod()
                .WithExposedHeaders("WWW-Authenticate")
                .WithOrigins("https://localhost:3000")
                .AllowCredentials();
        });
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// By placing app.UseCors() before app.UseAuthorization() and app.MapControllers(),
// you ensure that CORS policies are applied to incoming requests early in the pipeline,
// allowing the appropriate CORS headers to be added or modified before the requests are authorized or routed to controllers.
app.UseCors("AllowSpecificOrigin");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
