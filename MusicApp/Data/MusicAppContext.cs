using Microsoft.EntityFrameworkCore;
using MusicApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicApp.Data
{
    public class MusicAppContext : DbContext
    {
        public DbSet<SongCategory> Songs { get; set; }
        public DbSet<SongCategory> Categories { get; set; }
        public DbSet<SongCategory> SongCategories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=MusicApp;Trusted_Connection=True;");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SongCategory>()
                .HasKey(bc => new { bc.SongID, bc.CategoryID });
        }

        public DbSet<MusicApp.Models.Song> Song { get; set; }

        public DbSet<MusicApp.Models.Category> Category { get; set; }
    }
}
