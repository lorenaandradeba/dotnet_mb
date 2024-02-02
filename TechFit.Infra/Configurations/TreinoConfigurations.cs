using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TechFit.Core.Entities;

namespace TechFit.Infra.Configurations
{
    public class TreinoConfigurations : IEntityTypeConfiguration<Treino>
    {
        public void Configure(EntityTypeBuilder<Treino> builder)
        {
            builder
            .ToTable("Treinos")
            .HasKey(t => t.TreinoId);
        }
    }
}