using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservationAndManagementSystem.Models.Rooms
{
    public class SuiteRoom : Room
    {

        public override string RoomType => "Suite";
        public SuiteRoom()
        {
            Price = 4000;
            Status = "Available";
        }
        public override decimal GetPricePerNight()
        {
            return Price * 1.20m; // 20% premium
        }
    }
}
