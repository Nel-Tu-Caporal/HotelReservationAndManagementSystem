using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservationAndManagementSystem.Models
{
    public class DeluxeRoom : Room
    {
        public DeluxeRoom()
        {
            Price = 2500;
            Status = "Available";
        }
    }
}
