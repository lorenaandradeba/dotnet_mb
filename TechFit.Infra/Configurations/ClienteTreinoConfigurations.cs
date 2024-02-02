using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TechFit.Core.Entities;

namespace TechFit.Infra.Configurations
{
    public class ClienteTreinoConfigurations : IEntityTypeConfiguration<ClienteTreino>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<ClienteTreino> builder)
        {
            builder
            .ToTable("ClienteTreino")
            .HasKey(e => e.ClienteTreinoId);
        }
    }
}