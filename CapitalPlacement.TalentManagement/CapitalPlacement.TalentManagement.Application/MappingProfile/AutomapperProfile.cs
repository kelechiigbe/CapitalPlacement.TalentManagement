using AutoMapper;
using CapitalPlacement.TalentManagement.Application.ViewModel;
using CapitalPlacement.TalentManagement.Domain;

namespace CapitalPlacement.TalentManagement.Application.MappingProfile
{
    public class AutomapperProfile: Profile
    {
        public AutomapperProfile() { 

            CreateMap<CreateProgramRequest, Program>().ReverseMap();

        }
    }
}
