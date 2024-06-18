using CapitalPlacement.TalentManagement.Application.Interface;
using CapitalPlacement.TalentManagement.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapitalPlacement.TalentManagement.Infrastructure.Extensions
{
    /// <summary>
    /// Extension methods for adding infrastructure services to the service collection.
    /// </summary>
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// Adds infrastructure services to the service collection.
        /// </summary>
        /// <typeparam name="TContext">The type of the DbContext.</typeparam>
        /// <param name="services">The current service collection.</param>
        /// <param name="connectionString">The connection string for the database.</param>
        /// <returns>The modified service collection.</returns>
        public static IServiceCollection AddInfrastructureServices<TContext>(this IServiceCollection services, string accountEndPoint, string accountKey, string databaseName) where TContext : DbContext
        {
            // AddDbContextPool and other service registrations

            services.AddDbContextPool<TContext>(options =>
            {
                options.UseCosmos(accountEndPoint, accountKey, databaseName);
            });

            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IProgramRepository, ProgramRepository>();
 

            return services;

        }
    }
}
