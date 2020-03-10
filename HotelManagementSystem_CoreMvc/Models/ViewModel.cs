using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelManagementSystem_CoreMvc.Models
{
    public class GeustFoodOrder
    {
        public IEnumerable<Food> Foods { get; set; }
        public IEnumerable<OrderFood> OrderFoods { get; set; }
        public IEnumerable<Guest> Guests { get; set; }
    }
    public class GeustReserveRoom
    {
        public IEnumerable<Room> Rooms { get; set; }
        public IEnumerable<Reservasion> Reservations { get; set; }
        public IEnumerable<Guest> Guests { get; set; }
    }


    
}
