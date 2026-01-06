using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservationAndManagementSystem.Models
{
    public class StandardRoom : Room
    {

        public override string RoomType => "Standard";
        public StandardRoom()
        {
            Price = 1500;
            Status = "Available";
        }
        public override decimal GetPricePerNight()
        {
            return Price;
        }

    }
}
