using CapitalPlacement.TalentManagement.Application.Interface;
using CapitalPlacement.TalentManagement.Domain;

namespace CapitalPlacement.TalentManagement.Infrastructure.Data.Repositories
{
    public class ApplicationRepository : GenericRepository<ApplicationInformation>, IApplicationRepository
    {
        public ApplicationRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
