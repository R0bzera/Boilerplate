using System.Reflection;
using Boilerplate.Api.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Boilerplate.Api.Data
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : IdentityDbContext<User, IdentityRole<long>, long,IdentityUserClaim<long>,IdentityUserRole<long>,IdentityUserLogin<long>,IdentityRoleClaim<long>,IdentityUserToken<long>>(options)
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly()); 
        }
    }
}
