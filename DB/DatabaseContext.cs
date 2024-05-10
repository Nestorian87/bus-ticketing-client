using BusTicketingSystem.Managers;
using BusTicketingSystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTicketingSystem.DB
{
    public class DatabaseContext : DbContext
    {
        private const string DB_FILE_NAME = "db.sqlite";

        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Bus> Buses { get; set; } = null!;
        public DbSet<Route> Routes { get; set; } = null!;
        public DbSet<RouteStop> RouteStops { get; set; } = null!;
        public DbSet<Trip> Trips { get; set; } = null!;
        public DbSet<Stop> Stops { get; set; } = null!;
        public DbSet<Ticket> Tickets { get; set; } = null!;


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Data Source={DB_FILE_NAME}");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    Username = "admin",
                    PasswordHash = PasswordHashingManager.HashPasword("1234"),
                    Name = "Admin",
                    Surname = "Admin",
                    IsAdmin = true,
                    IsLoggedIn = false
                });
        }
    }
}
