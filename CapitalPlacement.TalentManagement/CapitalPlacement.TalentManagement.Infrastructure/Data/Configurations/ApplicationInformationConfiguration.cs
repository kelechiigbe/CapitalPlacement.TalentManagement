using CapitalPlacement.TalentManagement.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace CapitalPlacement.TalentManagement.Infrastructure.Data.Configurations
{
    /// <summary>
    /// Configuration class for the Application information entity.
    /// </summary>
    public class ApplicationInformationConfiguration : IEntityTypeConfiguration<ApplicationInformation>
    {
        /// <summary>
        /// Configures the properties of the ApplicationInformation entity.
        /// </summary>
        /// <param name="builder">Entity type builder for ApplicationInformation.</param>
        public void Configure(EntityTypeBuilder<ApplicationInformation> builder)
        {
            builder.Property(p => p.FirstName)
                   .IsRequired();
            builder.Property(p => p.LastName)
                  .IsRequired();
            builder.Property(p => p.Email)
                 .IsRequired();
        }
    }
}
