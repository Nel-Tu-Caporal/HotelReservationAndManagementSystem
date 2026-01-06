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

        public string Username { get; private set; }
        public string Password { get; private set; }

        protected User()
        {
            Username = string.Empty;
            Password = string.Empty;
        }

        protected User(string username, string password)
        {
            UpdateCredentials(username, password);
        }

        public void UpdateCredentials(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username))
                throw new ArgumentException("Username required");

            if (string.IsNullOrWhiteSpace(password))
                throw new ArgumentException("Password required");

            Username = username;
            Password = password;
        }

        public abstract string Role { get; }
        public abstract bool CanManageUsers();
    }
}
