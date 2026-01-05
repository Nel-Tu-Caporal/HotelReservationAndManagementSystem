using HotelReservationAndManagementSystem.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservationAndManagementSystem.Models.Services
{
    public class ReservationService
    {
        private List<Reservation> reservations = new List<Reservation>();

        public bool CreateReservation(Guest guest, Room room, DateTime checkIn, DateTime checkOut)
        {
            if (!room.IsAvailable())
                return false;

            room.Status = "Occupied";

            reservations.Add(new Reservation
            {
                Guest = guest,
                Room = room,
                CheckInDate = checkIn,
                CheckOutDate = checkOut,
                Status = "Reserved"
            });

            return true;
        }
    }
}

