using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Villagenix.Models;

namespace Villagenix.Business.Repository.IRepository
{
    public interface IHotelImagesRepository
    {
        public Task<int> CreateHotelRoomImage(HotelRoomImageDto imageDTO);
        public Task<int> DeleteHotelRoomImageByImageId(int imageId);
        public Task<int> DeleteHotelRoomImageByRoomId(int roomId);
        public Task<int> DeleteHotelImageByImageUrl(string imageUrl);
        public Task<IEnumerable<HotelRoomImageDto>> GetHotelRoomImages(int roomId);
    }
}
