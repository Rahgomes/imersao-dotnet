using AutoMapper;
using SocialBots.Data.DTOs;
using SocialBots.Models;

namespace SocialBots.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, ReadUserDTO>();
            CreateMap<CreateUserDTO, User>();
            CreateMap<User, UpdateUserDTO>();
            CreateMap<UpdateUserDTO, User>();
        }
    }
}
