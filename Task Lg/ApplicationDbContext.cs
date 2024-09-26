using Microsoft.EntityFrameworkCore;
using Task_Lg.Models;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<ProductBase> Products { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ProductBase>()
            .HasDiscriminator<string>("ProductType")
            .HasValue<LabtopProduct>("Labtop")
            .HasValue<PrinterProduct>("Printer")
            .HasValue<RouterProduct>("Router")
            .HasValue<ScreenProduct>("Screen");
    }
}
