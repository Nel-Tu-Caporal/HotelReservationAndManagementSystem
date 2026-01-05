using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservationAndManagementSystem.Models
{
    public abstract class Room
    {
        public int RoomNumber { get; set; }
        public decimal Price { get; set; }
        public string Status { get; set; } // Available / Occupied

        public bool IsAvailable()
        {
            return Status == "Available";
        }
    }
}
