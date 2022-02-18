using System.Threading.Tasks;
using Villagenix.Models;

namespace Villagenix.Client.Service.IService
{
    public interface IRoomOrderDetailsService
    {
        public Task<RoomOrderDetailsDTO> SaveRoomOrderDetails(RoomOrderDetailsDTO details);
        public Task<RoomOrderDetailsDTO> MarkPaymentSuccessful(RoomOrderDetailsDTO details);
    }
}
