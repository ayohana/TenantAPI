using Microsoft.EntityFrameworkCore;

namespace TenantAPI.Models
{
  public class TenantAPIContext : DbContext
  {
    public TenantAPIContext(DbContextOptions<TenantAPIContext> options)
        : base(options)
    {
    }

    public DbSet<Tenant> Tenants { get; set; }
  }
}