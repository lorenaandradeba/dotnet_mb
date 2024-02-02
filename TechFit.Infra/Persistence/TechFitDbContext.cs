using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TechFit.Core.Entities;

namespace TechFit.Infra.Persistence
{
    public class TechFitDbContext : DbContext
    {

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Treinador> Treinadores { get; set; }
        public DbSet<Treino> Treinos { get; set; }
        public DbSet<ClienteTreino> ClientesTreinos { get; set; }

        public TechFitDbContext(DbContextOptions<TechFitDbContext> options) : base(options)
        {
            //Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(TechFitDbContext).Assembly);
        }
    }
}