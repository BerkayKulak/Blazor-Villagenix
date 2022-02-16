using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Villagenix.Business.Repository.IRepository;
using Villagenix.Models;

namespace Villagenix.Business.Repository
{
    public class HotelRoomRepository : IHotelRoomRepository
    {
        private readonly ApplicationDb

        public Task<HotelRoomDto> CreateHotelRoom(HotelRoomDto hotelRoomDto)
        {
            throw new NotImplementedException();
        }

        public Task<HotelRoomDto> UpdateHotelRoom(int roomId, HotelRoomDto hotelRoomDto)
        {
            throw new NotImplementedException();
        }

        public Task<HotelRoomDto> GetHotelRoom(int roomId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<HotelRoomDto>> GetAllHotelRooms()
        {
            throw new NotImplementedException();
        }

        public Task<HotelRoomDto> IsSameNameRoomAlreadyPresent(string name)
        {
            throw new NotImplementedException();
        }
    }
}
