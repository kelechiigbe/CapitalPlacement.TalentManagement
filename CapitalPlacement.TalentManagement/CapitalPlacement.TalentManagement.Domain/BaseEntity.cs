using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapitalPlacement.TalentManagement.Domain
{
    /// <summary>
    /// Represents the base entity with a unique identifier.
    /// </summary>
    public class BaseEntity
    {
        /// <summary>
        /// Gets or sets the unique identifier for the entity.
        /// </summary>
        public Guid Id { get; set; } = Guid.NewGuid();
    }
}
