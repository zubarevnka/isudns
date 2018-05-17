using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using isudns.Models;

namespace isudns.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Article> Articles { get; set; }
        public DbSet<Conferention> Conferentions { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<ApplicationUserConferention> ApplicationUserConferention { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);

            //builder.Entity<ApplicationUser>()
            //.Property(a => a.ConcurrencyStamp)
            //.IsConcurrencyToken()
            //.ValueGeneratedOnAddOrUpdate();
            modelBuilder.Entity<ApplicationUserConferention>()
       .HasKey(auc => new { auc.ApplicationUserId, auc.ConferentionId });

            modelBuilder.Entity<ApplicationUserConferention>()
                .HasOne(bc => bc.ApplicationUser)
                .WithMany(b => b.ApplicationUserConferentions)
                .HasForeignKey(bc => bc.ApplicationUserId);

            modelBuilder.Entity<ApplicationUserConferention>()
                .HasOne(bc => bc.Conferention)
                .WithMany(c => c.ApplicationUserConferentions)
                .HasForeignKey(bc => bc.ConferentionId);
        }


    }
}
