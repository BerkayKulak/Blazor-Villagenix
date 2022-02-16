using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Villagenix.Models;

namespace Villagenix.Business.Repository.IRepository
{
    public interface IHotelRoomRepository
    {
        public Task<HotelRoomDto> CreateHotelRoom(HotelRoomDto hotelRoomDto);
        public Task<HotelRoomDto> UpdateHotelRoom(int roomId ,HotelRoomDto hotelRoomDto);
        public Task<HotelRoomDto> GetHotelRoom(int roomId);
        public Task<IEnumerable<HotelRoomDto>> GetAllHotelRooms();
        public Task<HotelRoomDto> IsSameNameRoomAlreadyPresent(string name);

    }
}
