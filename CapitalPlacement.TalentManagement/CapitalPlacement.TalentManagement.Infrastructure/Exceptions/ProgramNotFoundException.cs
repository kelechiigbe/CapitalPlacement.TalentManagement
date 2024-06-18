using CapitalPlacement.TalentManagement.Application.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CapitalPlacement.TalentManagement.Infrastructure.Exceptions
{
    /// <summary>
    /// Represents an exception thrown when program is not found.
    /// </summary>
    public class ProgramNotFoundException : BaseException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProgramNotFoundException"/> class 
        /// </summary>
        public ProgramNotFoundException()
            : base($"Program with not found", HttpStatusCode.NotFound)
        {
        }
    }
}
