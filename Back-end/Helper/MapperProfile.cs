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
            CreateMap<User, UserModel>().ForMember(um=>um.Password,u=>u.MapFrom(u=>u.HashPassword));
            CreateMap<UserModel, User>();

            CreateMap<CarModel, CarModelx2>();
            CreateMap<CarModelx2, CarModel>();

            CreateMap<TimeFrame, TimeFrameModel>().ForMember(sm => sm.ParkingID, opt => opt.MapFrom(s => s.Parking.ID.ToString()));
            CreateMap<TimeFrameModel, TimeFrame>();

            CreateMap<Slot, SlotModel>()
                .ForMember(sm => sm.ParkingID, opt => opt.MapFrom(s => s.Parking.ID.ToString()))
                .ForMember(sm => sm.CarModelID, opt => opt.MapFrom(s => s.CarModel.ID.ToString()))
                .ForMember(sm => sm.LastModifyByID, opt => opt.MapFrom(s => s.LastModifyBy.ID.ToString()));


            CreateMap<SlotModel, Slot>();

            CreateMap<Parking, ParkingModel>();
            CreateMap<ParkingModel, Parking>();

            CreateMap<Request, RequestModel>();
            CreateMap<RequestModel, Request>();

            CreateMap<MembershipPackage, MembershipPackageModel>();
            CreateMap<MembershipPackageModel, MembershipPackage>();
        }
    }
}
