using System.Text;
using API.Data;
using API.Extensions;
using API.Interfaces;
using API.Middleware;
using API.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

var builder = WebApplication.CreateBuilder(args);
var _issuer = builder.Configuration["Jwt:Issuer"];
var _audience = builder.Configuration["Jwt:Audience"];

// Add services to the container.
builder.Services.AddApplicationsServices(builder.Configuration);
builder.Services.AddIdentityServices(builder.Configuration);


var app = builder.Build();

app.UseMiddleware<ExceptionMiddleware>();
app.UseCors(x =>
    x.AllowAnyHeader()
        .AllowAnyMethod()
        .WithOrigins("http://localhost:4200", "https://localhost:4200")
);
//MiddleWare Authentification
app.UseAuthentication();
app.UseAuthorization();

// Configure the HTTP request pipeline.
app.MapControllers();

app.Run();
