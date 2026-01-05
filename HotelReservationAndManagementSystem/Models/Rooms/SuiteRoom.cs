using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservationAndManagementSystem.Models.Rooms
{
    public class SuiteRoom : Room
    {
        public SuiteRoom()
        {
            Price = 4000;
            Status = "Available";
        }   
    }
}
