using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservationAndManagementSystem.Models
{
    public class DeluxeRoom : Room
    {
        public override string RoomType => "Deluxe";

        public DeluxeRoom()
        {
            Price = 2500;
            Status = "Available";
        }
        public override decimal GetPricePerNight()
        {
            return Price * 1.10m; // 10% premium
        }
    }
}
