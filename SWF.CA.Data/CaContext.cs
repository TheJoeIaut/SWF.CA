using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using SWF.CA.Data.Models;

namespace SWF.CA.Data
{
    public class CaContext : DbContext
    {
        public DbSet<InsuranceOption> InsuranceOptions { get; set; }

        public CaContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Data Source=(LocalDb)\MSSQLLocalDB;Initial Catalog=SWF.CA;Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<InsuranceOption>().HasData(
                new InsuranceOption() {MinSquareMeter = 0, MaxSquareMeter = 50, Name = "LowCostOption"},
                new InsuranceOption() {MinSquareMeter = 51, MaxSquareMeter = 100, Name = "MediumCostOption"},
                new InsuranceOption() { MinSquareMeter = 101, MaxSquareMeter = 10000, Name = "HighCostOption"});
        }
    }
}
