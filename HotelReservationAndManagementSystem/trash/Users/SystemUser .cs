using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservationAndManagementSystem.Models.Users
{
    public class SystemUser : User
    {
        public SystemUser() { }

        public SystemUser(string username, string password)
            : base(username, password) { }

        public override string Role => "SystemUser";

        public override bool CanManageUsers()
        {
            return true;
        }
    }
}

