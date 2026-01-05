using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservationAndManagementSystem.Models
{
    public class FrontDeskStaff : User
    {
        public override string Role => "FrontDesk";
    }
}

