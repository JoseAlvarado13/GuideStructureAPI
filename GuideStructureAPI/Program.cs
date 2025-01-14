using DataAccess.DataModel.DracarysModel;
using Entities.Commons;
using Microsoft.AspNetCore.Authentication;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

/// AM-001
/// Author: Jos� Andr�s Alvarado Matamoros
// Configure Basic Authentication Scheme
builder.Services.AddAuthentication("BasicAuthentication") // Add authentication scheme named "BasicAuthentication"
    .AddScheme<AuthenticationSchemeOptions, BusinessLogic.Security.BasicAuthenticationHandler>("BasicAuthentication", null);
/// AM-001
/// Author: Jos� Andr�s Alvarado Matamoros
// Register the custom authentication handler (BasicAuthenticationHandler) for Basic Authentication.
// Add services to the container.
builder.Services.AddControllers();

/// AM-001
/// Author: Jos� Andr�s Alvarado Matamoros
// Configure Swagger for API documentation with Basic Authentication
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    /// AM-001
    /// Author: Jos� Andr�s Alvarado Matamoros
    // Define Basic Authentication for Swagger
    c.AddSecurityDefinition("Basic", new Microsoft.OpenApi.Models.OpenApiSecurityScheme
    {
        Name = "Authorization", // Name of the HTTP header
        Type = Microsoft.OpenApi.Models.SecuritySchemeType.Http, // Type of security scheme
        Scheme = "basic", // Use "basic" authentication scheme
        In = Microsoft.OpenApi.Models.ParameterLocation.Header, // Authorization info will be sent in HTTP headers
        Description = "Enter your username and password in the `Basic` format." // Swagger prompt for credentials
    });
    /// AM-001
    /// Author: Jos� Andr�s Alvarado Matamoros
    // Require Basic Authentication for all Swagger endpoints
    c.AddSecurityRequirement(new Microsoft.OpenApi.Models.OpenApiSecurityRequirement
    {
        {
            new Microsoft.OpenApi.Models.OpenApiSecurityScheme
            {
                Reference = new Microsoft.OpenApi.Models.OpenApiReference
                {
                    Type = Microsoft.OpenApi.Models.ReferenceType.SecurityScheme, // Link to the Basic Authentication scheme
                    Id = "Basic" // Match the ID defined in AddSecurityDefinition
                }
            },
            new string[] {} // No specific scopes required
        }
    });
});


// Database configuration and service registration
// AM-001
// Author: Jos� Andr�s Alvarado Matamoros

// Register the DataBaseDTO as a singleton service to ensure a single instance is shared across the application.
builder.Services.AddSingleton<DataBaseDTO>();

// Configure the DracarysContext to use the connection string provided by the DataBaseDTO.
builder.Services.AddDbContext<DracarysContext>(options =>
{
    // Obtain the DataBaseDTO instance from the service provider.
    var dbDTO = builder.Services.BuildServiceProvider().GetRequiredService<DataBaseDTO>();

    // Configure the DbContext to use SQL Server with the connection string from the DataBaseDTO.
    options.UseSqlServer(dbDTO.DefaultConnection);

    // Note: The provider can be adjusted to use another database (e.g., MySQL, PostgreSQL) if needed.
});



var app = builder.Build();
/// AM-001
/// Author: Jos� Andr�s Alvarado Matamoros
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger(); // Enable Swagger in development mode
    app.UseSwaggerUI(); // Configure Swagger UI
}

app.UseAuthentication(); // Enable the middleware for authentication
app.UseAuthorization(); // Enable the middleware for authorization

app.UseHttpsRedirection();

app.MapControllers();

app.Run();
