using Microsoft.EntityFrameworkCore;
using RegisterAnimals.Entities;

namespace RegisterAnimals.Data;

public class AnimalDbContext : DbContext
{
    public DbSet<Animal> Animals { get; set; }

    public AnimalDbContext(DbContextOptions<AnimalDbContext> options)
    : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Animal>()
            .HasDiscriminator<string>("AnimalType")
            .HasValue<Lion>("lion")
            .HasValue<Elephant>("elephant");
    }
}