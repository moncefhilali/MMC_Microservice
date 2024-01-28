using AutoMapper;
using MMC.Domain.DTOs;
using MMC.Domain.Entities;

namespace MMC.Application.Mapping;

public class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        //City Mapping
        CreateMap<City, CityGetDTO>();
        CreateMap<CityPostDTO, City>();
        CreateMap<CityPutDTO, City>();

        //Event Mapping
        CreateMap<Event, EventGetDTO>();
        CreateMap<EventPostDTO, Event>();
        CreateMap<EventPutDTO, Event>();

        //Theme Mapping
        CreateMap<Theme, ThemeGetDTO>();
        CreateMap<ThemePostDTO, Theme>();
        CreateMap<ThemePutDTO, Theme>();
    }
}