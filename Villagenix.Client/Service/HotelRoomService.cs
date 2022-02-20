using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Villagenix.Client.Service.IService;
using Villagenix.Models;

namespace Villagenix.Client.Service
{
    public class HotelRoomService : IHotelRoomService
    {
        private readonly HttpClient _client;

        public HotelRoomService(HttpClient client)
        {
            _client = client;
        }

        public async Task<HotelRoomDTO> GetHotelRoomDetails(int roomId, string checkInDate, string checkOutDate)
        {
            var checkInDateFormat = checkInDate.Replace(".", "%2F");
            var checkOutDateFormat = checkOutDate.Replace(".", "%2F");
            var response = await _client.GetAsync($"api/hotelroom/{roomId}?checkInDate={checkInDateFormat}&checkOutDate={checkOutDateFormat}");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var room = JsonConvert.DeserializeObject<HotelRoomDTO>(content);
                return room;
            }
            else
            {
                var content = await response.Content.ReadAsStringAsync();
                var errorModel = JsonConvert.DeserializeObject<ErrorModel>(content);
                throw new Exception(errorModel.ErrorMessage);
            }

        }

        public async Task<IEnumerable<HotelRoomDTO>> GetHotelRooms(string checkInDate, string checkOutDate)
        {
            var checkInDateFormat = checkInDate.Replace(".", "%2F");
            var checkOutDateFormat = checkOutDate.Replace(".", "%2F");
            var response = await _client.GetAsync($"api/hotelroom?checkInDate={checkInDateFormat}&checkOutDate={checkOutDateFormat}");
            var content = await response.Content.ReadAsStringAsync();
            var rooms = JsonConvert.DeserializeObject<IEnumerable<HotelRoomDTO>>(content);
            return rooms;
        }
    }
}
