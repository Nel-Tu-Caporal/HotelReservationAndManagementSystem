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
        private List<Reservation1> reservations = new List<Reservation1>();
        private List<PaymentService> payments = new List<PaymentService>();

        public PaymentService CreatePayment(Reservation1 reservation, string paymentMethod)
        {
            PaymentService payment = new PaymentService(reservation, paymentMethod);
            payments.Add(payment);
            return payment;
        }

        public bool CreateReservation(
            Guest guest,
            Room room,
            DateTime checkIn,
            DateTime checkOut)
        {
            // 1. Validate room availability
            if (!room.IsAvailable())
                return false;

            // 2. Create reservation
            Reservation1 reservation = new Reservation1(
                guest,
                room,
                checkIn,
                checkOut
            );

            // 3. Validate dates
            if (!reservation.IsValidDate())
                return false;

            // 4. Update room state
            room.MarkAsOccupied();

            // 5. Save reservation
            reservations.Add(reservation);

            return true;
        }
    }
}

