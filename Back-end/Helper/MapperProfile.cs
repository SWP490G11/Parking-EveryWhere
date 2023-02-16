using AutoMapper;
using Back_end.Entities;
using Back_end.Models;
using Back_end.Models.User;

namespace Back_end.Helper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<User, UserModel>();
            CreateMap<UserModel, User>();
            CreateMap<CarModel, CarModelx2>();
            CreateMap<CarModelx2, CarModel>();

            CreateMap<TimeFrame, TimeFrameModel>();
            CreateMap<TimeFrameModel, TimeFrame>();
        }
    }
}
