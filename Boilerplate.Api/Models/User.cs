using Microsoft.AspNetCore.Identity;

namespace Boilerplate.Api.Models
{
    public class User : IdentityUser<long>
    {
        public List<IdentityRole<long>>? Roles { get; set; }
    }
}
