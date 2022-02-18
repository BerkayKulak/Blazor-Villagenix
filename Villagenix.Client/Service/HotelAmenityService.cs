using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Villagenix.Client.Service.IService;
using Villagenix.Models;

namespace Villagenix.Client.Service
{
    public class HotelAmenityService : IHotelAmenityService
    {
        private readonly HttpClient _client;

        public HotelAmenityService(HttpClient client)
        {
            _client = client;
        }



        public async Task<IEnumerable<HotelAmenityDTO>> GetHotelAmenities()
        {
            var response = await _client.GetAsync($"api/hotelamenity");
            var content = await response.Content.ReadAsStringAsync();
            var rooms = JsonConvert.DeserializeObject<IEnumerable<HotelAmenityDTO>>(content);
            return rooms;
        }
    }
}
