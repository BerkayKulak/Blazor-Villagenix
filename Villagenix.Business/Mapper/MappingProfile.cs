using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Villagenix.DataAccess.Data;
using Villagenix.Models;

namespace Villagenix.Business.Mapper
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<HotelRoomDTO, HotelRoom>();
            CreateMap<HotelRoom, HotelRoomDTO>();
            CreateMap<HotelAmenity, HotelAmenityDTO>().ReverseMap();

            CreateMap<HotelRoomImage, HotelRoomImageDTO>().ReverseMap();

            CreateMap<RoomOrderDetails, RoomOrderDetailsDTO>().ForMember(x => x.HotelRoomDTO, opt => opt.MapFrom(c => c.HotelRoom));
            CreateMap<RoomOrderDetailsDTO, RoomOrderDetails>();

        }
    }
}
