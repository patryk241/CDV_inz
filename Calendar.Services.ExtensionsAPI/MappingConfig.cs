using AutoMapper;
using Calendar.Services.ExtensionsAPI.Models;
using Calendar.Services.ExtensionsAPI.Models.Dto;

namespace Calendar.Services.ExtensionsAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<EventDto, Event>();
                config.CreateMap<Event, EventDto>();
            });

            return mappingConfig;
        }
    }
}
