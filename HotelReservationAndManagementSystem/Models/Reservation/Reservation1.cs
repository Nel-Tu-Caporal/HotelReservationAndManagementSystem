using HotelReservationAndManagementSystem.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservationAndManagementSystem.Models
{
    public class Reservation1
    {
        public int ReservationID { get; set; }
        public Guest Guest { get; private set; }
        public Room Room { get; private set; }
        public DateTime CheckInDate { get; private set; }
        public DateTime CheckOutDate { get; private set; }

        public Reservation1(
            Guest guest,
            Room room,
            DateTime checkIn,
            DateTime checkOut)
        {
            Guest = guest;
            Room = room;
            CheckInDate = checkIn;
            CheckOutDate = checkOut;
        }

        public int GetTotalNights()
        {
            return (CheckOutDate - CheckInDate).Days;
        }

        public decimal CalculateTotalCost()
        {
            return GetTotalNights() * Room.GetPricePerNight();
        }

        public bool IsValidDate()
        {
            return CheckOutDate > CheckInDate;
        }
    }
}

