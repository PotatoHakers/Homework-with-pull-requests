using ConsoleAppTest.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleAppTest
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Flat> Flats { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<House> Houses { get; set; }
        public DbSet<Office> Offices { get; set; }
        public DbSet<Realtor> Realtors { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {

            Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Deal>().HasKey(u => u.Id);
        }

    }
}
