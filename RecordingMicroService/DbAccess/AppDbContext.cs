using Microsoft.EntityFrameworkCore;
using RecordingMicroService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecordingMicroService.DbAccess
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Recording> Recordings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Recording>().HasData(new Recording { Id = 1, Name = "hard guitar", RecordingPath = "/recordings/hard_guitar.wav" });
            modelBuilder.Entity<Recording>().HasData(new Recording { Id = 2, Name = "riif guitar", RecordingPath = "/recordings/riff_guitar.wav" });
            modelBuilder.Entity<Recording>().HasData(new Recording { Id = 3, Name = "soft guitar", RecordingPath = "/recordings/soft_guitar.mp3" });

        }


    }




}