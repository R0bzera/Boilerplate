using Boilerplate.Api.Data;
using Boilerplate.Api.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(x=>{
    x.CustomSchemaIds(n=> n.FullName);
});

builder.Services
    .AddAuthentication(IdentityConstants.ApplicationScheme)
    .AddIdentityCookies();

builder.Services.AddAuthorization();

var connectionStr = builder.Configuration.GetConnectionString("DefaultConnection") ?? string.Empty;

builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseNpgsql(connectionStr);
});

builder.Services.AddIdentityCore<User>().AddRoles<IdentityRole<long>>().AddEntityFrameworkStores<AppDbContext>().AddApiEndpoints();

var app = builder.Build();

app.UseAuthentication();
app.UseAuthorization();

app.UseSwagger();
app.UseSwaggerUI();

app.MapGroup("/v1/identity").WithTags("Identity").MapIdentityApi<User>();


app.Run();