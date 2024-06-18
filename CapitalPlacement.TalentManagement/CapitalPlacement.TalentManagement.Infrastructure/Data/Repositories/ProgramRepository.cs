using CapitalPlacement.TalentManagement.Application.Interface;
using CapitalPlacement.TalentManagement.Domain;

namespace CapitalPlacement.TalentManagement.Infrastructure.Data.Repositories
{
    public class ProgramRepository : GenericRepository<Program>, IProgramRepository
    {
        public ProgramRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
