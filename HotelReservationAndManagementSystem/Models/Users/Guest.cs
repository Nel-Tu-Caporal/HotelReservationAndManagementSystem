using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservationAndManagementSystem.Models.Users
{
    public class Guest : User
    {
        public string FullName { get; set; }
        public string Phone { get; set; }

        
        public Guest()
        {
            FullName = string.Empty;
            Phone = string.Empty;
        }

       
        public Guest(string fullName, string phone)
        {
            FullName = fullName;
            Phone = phone;
        }

        public override string Role => "Guest";
    }
}
