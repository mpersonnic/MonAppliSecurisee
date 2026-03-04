using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MonAppliSécurisée.Areas.Identity.Data;

namespace MonAppliSécurisée.Data;

public class MonAppliSécuriséeContext : IdentityDbContext<MonAppliSécuriséeUser>
{
    public MonAppliSécuriséeContext(DbContextOptions<MonAppliSécuriséeContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }
}
