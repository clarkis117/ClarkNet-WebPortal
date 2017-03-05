using ClarkNetWebPortal.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClarkNetWebPortal.DbContexts
{
    public class SqliteDbContext : DbContext
    {
        public static string ConnectionString = "Filename=./DataBase.db";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(ConnectionString);
        }

        public DbSet<Host> Hosts { get; set; }

        public DbSet<Application> Applications { get; set; }

        public DbSet<IpCamera> IpCameras { get; set; }

        public DbSet<NetworkAppliance> NetworkAppliances { get; set; }
    }
}
