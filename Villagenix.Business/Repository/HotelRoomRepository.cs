using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
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

        public async Task<HotelRoomDto> UpdateHotelRoom(int roomId, HotelRoomDto hotelRoomDto)
        {
            try
            {
                if (roomId == hotelRoomDto.Id)
                {
                    HotelRoom roomDetails = await _context.HotelRooms.FindAsync(roomId);
                    HotelRoom room = _mapper.Map<HotelRoomDto, HotelRoom>(hotelRoomDto, roomDetails);
                    room.UpdatedBy = "";
                    room.UpdatedDate=DateTime.Now;
                    var updateRoom = _context.HotelRooms.Update(room);
                    await _context.SaveChangesAsync();
                    return _mapper.Map<HotelRoom, HotelRoomDto>(updateRoom.Entity);
                }
                else
                {
                    return null;
                }
            }
            catch (Exception e)
            {
                return null;
            }

          
        }

        public async Task<HotelRoomDto> GetHotelRoom(int roomId)
        {
            try
            {
                HotelRoomDto hotelRoom =_mapper.Map<HotelRoom,HotelRoomDto>( await _context.HotelRooms.FirstOrDefaultAsync(x => x.Id == roomId));
                return hotelRoom;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public async Task<int> DeleteHotelRoom(int roomId)
        {
            var roomDetails = await _context.HotelRooms.FindAsync(roomId);
            if (roomDetails != null)
            {
                _context.HotelRooms.Remove(roomDetails);
                return await _context.SaveChangesAsync();
            }

            return 0;
        }

        public async Task<IEnumerable<HotelRoomDto>> GetAllHotelRooms()
        {
            try
            {
                IEnumerable<HotelRoomDto> hotelRoomDtos =_mapper.Map<IEnumerable<HotelRoom>,IEnumerable<HotelRoomDto>>(_context.HotelRooms);

                return hotelRoomDtos;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public async Task<HotelRoomDto> IsRoomUnique(string name,int roomId=0)
        {
            try
            {
                if (roomId == 0)
                {
                    HotelRoomDto hotelRoom = _mapper.Map<HotelRoom, HotelRoomDto>(await _context.HotelRooms.FirstOrDefaultAsync(x => x.Name == name.ToLower()));
                    return hotelRoom;
                }
                else
                {
                    HotelRoomDto hotelRoom = _mapper.Map<HotelRoom, HotelRoomDto>(await _context.HotelRooms.FirstOrDefaultAsync(x => x.Name == name.ToLower() && x.Id != roomId));
                    return hotelRoom;
                }
              
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}
