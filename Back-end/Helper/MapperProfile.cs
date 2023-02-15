using AutoMapper;
using Back_end.Entities;
using Back_end.Models.User;

namespace Back_end.Helper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<User, UserModel>();
            CreateMap<UserModel, User>();
        }
    }
}
