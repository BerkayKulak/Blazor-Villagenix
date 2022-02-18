using System.Collections.Generic;
using System.Threading.Tasks;
using Villagenix.Models;

namespace Villagenix.Client.Service.IService
{
    public interface IHotelAmenityService
    {
        public Task<IEnumerable<HotelAmenityDTO>> GetHotelAmenities();
    }
}
