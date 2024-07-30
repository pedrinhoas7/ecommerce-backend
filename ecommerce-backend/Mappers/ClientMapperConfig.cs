using AutoMapper;
using Backend.Apllication.DTO;
using Backend.Core.Entities;

namespace Backend.API.Mappers
{
    public class ClientMapperConfig : Profile
    {
        public ClientMapperConfig()
        {
            CreateMap<ClientDTO, ClientEntity>().ReverseMap();
        }
    }
}
