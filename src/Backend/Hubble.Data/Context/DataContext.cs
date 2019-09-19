using Hubble.Data.Mappings;
using Hubble.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Hubble.Data.Context
{
    public class DataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var config = new ConfigurationBuilder()
           .SetBasePath(Directory.GetCurrentDirectory())
           .AddJsonFile("appsettings.json")
           .Build();
            optionsBuilder.UseSqlServer(config.GetConnectionString("DefaultConnection"));

            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var config = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();

            modelBuilder.ApplyConfiguration(new TransportadoraMap());
            modelBuilder.ApplyConfiguration(new FornecedorMap());
            modelBuilder.ApplyConfiguration(new LancamentoMateriaPrimaMap());
        }
        public DbSet<Fornecedor> Fornecedor { get; set; }
        public DbSet<LancamentoMateriaPrima> LancamentoMateriaPrima { get; set; }
        public DbSet<Transportadora> Transportadora { get; set; }
    }
}
