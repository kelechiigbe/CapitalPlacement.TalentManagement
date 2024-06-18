using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using CapitalPlacement.TalentManagement.Domain;

namespace CapitalPlacement.TalentManagement.Infrastructure.Data.Configurations
{
    /// <summary>
    /// Configuration class for the Program entity.
    /// </summary>
    public class ProgramConfiguration : IEntityTypeConfiguration<Program>
    {
        /// <summary>
        /// Configures the properties of the Program entity.
        /// </summary>
        /// <param name="builder">Entity type builder for Program.</param>
        public void Configure(EntityTypeBuilder<Program> builder)
        {
            builder.Property(p => p.Title)
                   .IsRequired();
            builder.Property(p => p.Description)
                  .IsRequired();
        }
    }
}
