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
            CreateMap<HotelRoomDto, HotelRoom>();
            CreateMap<HotelRoom, HotelRoomDto>();

            CreateMap<HotelRoomImage, HotelRoomImageDto>().ReverseMap();
            
        }
    }
}
