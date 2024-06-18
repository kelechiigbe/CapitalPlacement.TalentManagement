using AutoMapper;
using CapitalPlacement.TalentManagement.Application.ViewModel;
using CapitalPlacement.TalentManagement.Domain;

namespace CapitalPlacement.TalentManagement.Application.MappingProfile
{
    public class AutomapperProfile: Profile
    {
        public AutomapperProfile() { 

            CreateMap<CreateProgramRequest, Program>().ReverseMap();
            CreateMap<ProgramResponse, Program>().ReverseMap();
            CreateMap<UpdateProgramRequest, Program>().ReverseMap();

            CreateMap<CreateApplicationRequest, ApplicationInformation>().ReverseMap();
            CreateMap<ApplicationResponse, ApplicationInformation>().ReverseMap();
        }
    }
}
