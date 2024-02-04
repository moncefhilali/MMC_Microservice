using AutoMapper;
using Validator.Domain.DTOs;
using Validator.Domain.Entities;

namespace Validator.Application.Mapping;

public class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        //JoinEvent Mapping
        CreateMap<JoinEvent, JoinEventGetDTO>();
        CreateMap<JoinEventPostDTO, JoinEvent>();
        CreateMap<JoinEventPutDTO, JoinEvent>();
    }
}