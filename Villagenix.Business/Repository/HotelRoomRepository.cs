using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Villagenix.Business.Repository.IRepository;
using Villagenix.DataAccess.Data;
using Villagenix.Models;

namespace Villagenix.Business.Repository
{
    public class HotelRoomRepository : IHotelRoomRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public HotelRoomRepository(ApplicationDbContext context,IMapper mapper)
        {
            _mapper = mapper;
            _context = context;
        }

        public async Task<HotelRoomDto> CreateHotelRoom(HotelRoomDto hotelRoomDto)
        {
            HotelRoom hotelRoom = _mapper.Map<HotelRoomDto, HotelRoom>(hotelRoomDto);

            hotelRoom.CreatedDate = DateTime.Now;

            hotelRoom.CreatedBy = "";

            var addedHotelRoom = await _context.HotelRooms.AddAsync(hotelRoom);

            await _context.SaveChangesAsync();

            return _mapper.Map<HotelRoom, HotelRoomDto>(addedHotelRoom.Entity);
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
