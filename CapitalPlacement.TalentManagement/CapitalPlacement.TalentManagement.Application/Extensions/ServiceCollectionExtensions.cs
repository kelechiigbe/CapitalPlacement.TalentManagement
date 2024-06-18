using CapitalPlacement.TalentManagement.Application.FluentValidators;
using CapitalPlacement.TalentManagement.Application.MappingProfile;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.Extensions.DependencyInjection;

namespace CapitalPlacement.TalentManagement.Application.Extensions
{
    /// <summary>
    /// Extensions for configuring application services.
    /// </summary>
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// Adds application services to the service collection.
        /// </summary>
        /// <param name="services">The current service collection.</param>
        /// <returns>The updated service collection.</returns>
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
             services.AddFluentValidationAutoValidation()
                          .AddValidatorsFromAssemblyContaining<CreateProgramRequestValidator>();

            services.AddAutoMapper(typeof(AutomapperProfile).Assembly);

            return services;
        }
    }
}
