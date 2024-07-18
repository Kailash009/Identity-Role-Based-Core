using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RoleIdentity.Models;

namespace RoleIdentity.Models
{
    public class ApplicationDbContext:IdentityDbContext<ApplicationUser>   // Add this ApplicationUser Model Here.....
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
            
        }
        public DbSet<RoleIdentity.Models.RegisterViewModel> RegisterViewModel { get; set; } = default!;
    }
}
