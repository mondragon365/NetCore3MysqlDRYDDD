// AutoMapping.cs
using AutoMapper;
using ApiRest.Entities.Models;

namespace DemonSol.Rest.Api
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<User, UserDTO>(); // means you want to map from User to UserDTO
        }
    }
}
