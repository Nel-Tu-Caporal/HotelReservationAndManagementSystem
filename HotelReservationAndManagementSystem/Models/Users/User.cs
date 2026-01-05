using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservationAndManagementSystem.Models
{
    public abstract class User
    {
        public int UserID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        protected User()
        {
            Username = string.Empty;
            Password = string.Empty;
        }

        protected User(string username, string password)
        {
            Username = username;
            Password = password;
        }

        public abstract string Role { get; }
    }
}
