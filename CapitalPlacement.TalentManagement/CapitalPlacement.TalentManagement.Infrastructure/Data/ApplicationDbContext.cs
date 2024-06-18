using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using Microsoft.EntityFrameworkCore;
using CapitalPlacement.TalentManagement.Domain;

namespace CapitalPlacement.TalentManagement.Infrastructure.Data
{
    /// <summary>
    /// Represents the database context for the Capital placement talent management application.
    /// </summary>
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        /// <summary>
        /// Gets or sets the DbSet for Programs entity.
        /// </summary>
        public DbSet<Program> Programs { get; set; }

        /// <summary>
        /// Customizes the model using the provided modelBuilder.
        /// </summary>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
