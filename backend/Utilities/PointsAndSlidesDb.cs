using Microsoft.EntityFrameworkCore;
using backend.Models;

namespace backend.Utilities
{
    public class PointsAndSlidesDb : DbContext
    {
        public PointsAndSlidesDb(DbContextOptions<PointsAndSlidesDb> options)
            : base(options)
        { }

        public DbSet<Scan> Scans { get; set; }
        public DbSet<Slice> Slices { get; set; }
        public DbSet<Location> Locations { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Slice>()
                .HasMany(o => o.points)
                .WithOne(p => p.slice)
                .OnDelete(DeleteBehavior.Cascade);
            
            builder.Entity<Scan>()
                .HasMany(o => o.Slices)
                .WithOne(s => s.Scan)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<Location>()
                .HasOne<Location>(o => o.tail);
            
        }
    }
}