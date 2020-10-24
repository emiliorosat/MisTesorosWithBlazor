using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace misTesoros.Data
{
    public class ApplicationDbContext : IdentityDbContext<AppUser>
    {
        public DbSet<AppUser> AppUsers {get; set;}
        public DbSet<Treasure> Treasures {get; set;}
        public DbSet<Coordinate> Coordinates {get; protected set;}
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        /*
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite("DataSource=app.db");

        */
        /*moding*/
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<AppUser>(entityTypeBuilder => {
                entityTypeBuilder.ToTable("Users");
                entityTypeBuilder.Property(u => u.Uid).HasMaxLength(100).IsRequired();
                entityTypeBuilder.Property(u => u.Name).HasMaxLength(100);
                entityTypeBuilder.Property( u => u.Color).HasMaxLength(8).HasDefaultValue("#ffffff");
            });
        }
    }
}
