using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservationAndManagementSystem.Models.Reservation
{
    public class CheckInOut
    {
        public int CheckInOutID { get; set; }
        public Reservation1 Reservation { get; set; }
        public DateTime CheckInTime { get; set; }
        public DateTime? CheckOutTime { get; set; }
    }
}
