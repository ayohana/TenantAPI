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

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Tenant>()
        .HasData(
          new Tenant { TenantId = 1, FirstName = "John", LastName = "Watson", Email = "assistant@holmes.com", Phone = "4477009999", ApartmentName = "Baker Apartments", ApartmentNumber = "221B", IsBackgroundChecked = true },
          new Tenant { TenantId = 2, FirstName = "Sherlock", LastName = "Holmes", Email = "detective@holmes.com", Phone = "4477009999", ApartmentName = "Baker Apartments", ApartmentNumber = "221B", IsBackgroundChecked = true },
          new Tenant { TenantId = 3, FirstName = "Mrs", LastName = "Hudson", Email = "housekeeper@holmes.com", Phone = "4477008888", ApartmentName = "Baker Apartments", ApartmentNumber = "221A", IsBackgroundChecked = true },
          new Tenant { TenantId = 4, FirstName = "Molly", LastName = "Hooper", Email = "specialist@morgue.com", Phone = "4476001111", ApartmentName = "Downing Apartments", ApartmentNumber = "303", IsBackgroundChecked = true },
          new Tenant { TenantId = 5, FirstName = "James", LastName = "Moriarty", Email = "mastermind@villain.com", Phone = "4470004444", ApartmentName = "Stonyhurst Place", ApartmentNumber = "V20", IsBackgroundChecked = false }
        );
    }
  }
}