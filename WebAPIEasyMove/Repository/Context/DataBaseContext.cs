using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WebAPIEasyMove.Models;

namespace WebAPIEasyMove.Repository.Context
{
    public class DataBaseContext : DbContext
    {

        public DbSet<Mudanca> Mudanca { get; set; }
        public DbSet<Pagamento> Pagamento { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var config = new ConfigurationBuilder()
                                    .SetBasePath(Directory.GetCurrentDirectory())
                                    .AddJsonFile("appsettings.json").Build();

                optionsBuilder.UseOracle(config.GetConnectionString("WebAPIEasyMove"));
            }

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }

    }
}
