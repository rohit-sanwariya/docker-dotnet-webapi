using AutoMapper;
using docker_dotnet_webapi.DTOs;
using docker_dotnet_webapi.Models;

namespace docker_dotnet_webapi.Profiles
{
    public class UserProfile:Profile
    {
        public UserProfile()
        {
            CreateMap<UserReadDTO, User>();
            CreateMap<User, UserReadDTO>();
        }
    }
}
