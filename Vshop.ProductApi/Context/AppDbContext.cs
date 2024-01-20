using Microsoft.EntityFrameworkCore;
using Vshop.ProductApi.Models;

namespace Vshop.ProductApi.Context;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }

    protected override void OnModelCreating(ModelBuilder mB)
    {
        var category = mB.Entity<Category>();
        category.HasKey(x => x.Id);

        category.Property(x => x.Name)
            .HasMaxLength(100)
                .IsRequired();

        category.HasData(
            new Category
            {
                Id = 1,
                Name = "Funco Gojo"
            });

        var product = mB.Entity<Product>();
        product.HasKey(x => x.Id);

        product.Property(x => x.Name)
            .HasMaxLength(100)
                .IsRequired();

        product.Property(x => x.Description)
            .HasMaxLength(200)
                .IsRequired();

        product.Property(x => x.Price).HasPrecision(12, 2);
    }
}