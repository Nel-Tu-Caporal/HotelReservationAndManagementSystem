using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservationAndManagementSystem.Models
{
    public class HotelManager : User
    {
        public override string Role => "Admin";



        public override bool CanManageUsers() => true;
    }
}
