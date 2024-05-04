using BusTicketingSystem.Models;
using Microsoft.EntityFrameworkCore;
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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Data Source={DB_FILE_NAME}");
        }
    }
}
