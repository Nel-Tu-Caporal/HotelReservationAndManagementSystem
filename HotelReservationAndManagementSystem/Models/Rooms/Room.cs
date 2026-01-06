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
        public decimal Price { get; protected set; }
        public string Status { get; protected set; }

        protected Room()
        {
            Status = "Available";
        }

        public bool IsAvailable()
        {
            return Status == "Available";
        }

        public void MarkAsOccupied()
        {
            Status = "Occupied";
        }

        public void MarkAsAvailable()
        {
            Status = "Available";
        }

        public abstract string RoomType { get; }
        public abstract decimal GetPricePerNight();
    }
}
