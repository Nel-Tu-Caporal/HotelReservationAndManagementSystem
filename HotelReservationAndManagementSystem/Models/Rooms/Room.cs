using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservationAndManagementSystem.Models
{
    public class Room
    {
        public string RoomType { get; }
        public decimal RoomRate { get; }

        public Room(string type)
        {
            RoomType = type;

            if (type == "Single")
                RoomRate = 1000m;
            else if (type == "Double")
                RoomRate = 1500m;
            else if (type == "Family")
                RoomRate = 2500m;
            else if (type == "Suite")
                RoomRate = 4000m;
            else
                RoomRate = 1000m;
        }
    }
}