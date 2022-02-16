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
    public class HotelImagesRepository : IHotelImagesRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public HotelImagesRepository(ApplicationDbContext context, IMapper mapper)
        {
            _mapper = mapper;
            _context = context;
        }

        public async Task<int> CreateHotelRoomImage(HotelRoomImageDto imageDTO)
        {
            var image = _mapper.Map<HotelRoomImageDto, HotelRoomImage>(imageDTO);

            await _context.HotelRoomImages.AddAsync(image);

            return await _context.SaveChangesAsync();
        }

        public async Task<int> DeleteHotelRoomImageByImageId(int imageId)
        {
            var image = await _context.HotelRoomImages.FindAsync(imageId);

            _context.HotelRoomImages.Remove(image);

            return await _context.SaveChangesAsync();

        }

        public async Task<int> DeleteHotelRoomImageByRoomId(int roomId)
        {
            var imageList = await _context.HotelRoomImages.Where(x => x.RoomId == roomId).ToListAsync();

            _context.HotelRoomImages.RemoveRange(imageList);

            return await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<HotelRoomImageDto>> GetHotelRoomImages(int roomId)
        {
            return _mapper.Map<IEnumerable<HotelRoomImage>, IEnumerable<HotelRoomImageDto>>(
            await _context.HotelRoomImages.Where(x => x.RoomId == roomId).ToListAsync());

        }
    }
}
