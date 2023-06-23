using AngularAuthAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using Task = AngularAuthAPI.Models.Task;

namespace AngularAuthAPI.Services
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

      

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
       // modelBuilder.Entity<Users>().ToTable("users");
       base.OnModelCreating(modelBuilder);
    }

        public DbSet<Users> Users { get; set; }

        public DbSet<Task> Tasks { get; set; }

    }


   
}
