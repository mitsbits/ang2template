using CoreMvcAngular.Models;
using Microsoft.EntityFrameworkCore;
using OpenIddict;

namespace CoreMvcAngular.Data
{
    public class ApplicationDbContext : OpenIddictDbContext<AppUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
                : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}