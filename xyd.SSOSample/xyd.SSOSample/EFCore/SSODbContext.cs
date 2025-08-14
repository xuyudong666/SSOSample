using Microsoft.EntityFrameworkCore;
using xyd.SSOSample.EFCore.Users;

namespace xyd.SSOSample.EFCore;

public class SSODbContext : DbContext
{
    public SSODbContext(DbContextOptions<SSODbContext> options): base(options)
    {
    }

    public virtual DbSet<User> Users { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("utf8_general_ci").HasCharSet("utf8");
        modelBuilder.Entity<User>(entity =>
        {
            entity.ToTable("user");
            entity.Property(e => e.PassWord).HasMaxLength(200).HasColumnName("password");
        });
    }
}
