
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TechFit.Core.Entities;

namespace TechFit.Infra.Configurations
{
    public class TreinadorConfigurations : IEntityTypeConfiguration<Treinador>
    {
        public void Configure(EntityTypeBuilder<Treinador> builder)
        {
            builder
            .ToTable("Treinadores")
            .HasKey(t => t.TreinadorId);

        }
    }
}