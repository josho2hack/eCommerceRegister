using AutoMapper;
using RDRegister.API.Dtos;
using RDRegister.API.Models;

namespace RDRegister.API.Profiles
{
    public class RDTrainedProfile : Profile
    {
        public RDTrainedProfile()
        {
            CreateMap<RDTrained, RDTrainedReadDto>();
            CreateMap<RDTrainedCreateDto, RDTrained>();
            CreateMap<RDTrainedUpdateDto, RDTrained>();
            CreateMap<RDTrained, RDTrainedUpdateDto>();
        }
    }
}
