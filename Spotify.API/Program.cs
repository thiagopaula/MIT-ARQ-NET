using IdentityServer4.AccessTokenValidation;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Spotify.Domain.Album.Repository;
using Spotify.Domain.User.Repository;
using Spotify.Repository;
using Spotify.Repository.Context;
using Spotify.Repository.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.RegisterRepository(builder.Configuration.GetConnectionString("SpotifyDB"));

//builder.Services.AddAuthentication(IdentityServerAuthenticationDefaults.AuthenticationScheme)
//    .AddIdentityServerAuthentication(opt =>
//    {
//        opt.Authority = "";
//        opt.ApiName = "Spotify";
//        opt.ApiSecret = "";
//    });

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
