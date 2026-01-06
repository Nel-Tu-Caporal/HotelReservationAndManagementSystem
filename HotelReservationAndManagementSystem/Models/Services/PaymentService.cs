using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservationAndManagementSystem.Models.Services
{
    public class PaymentService
    {
        public int PaymentID { get; set; }
        public Reservation1 Reservation { get; private set; }
        public decimal Amount { get; private set; }
        public DateTime PaymentDate { get; private set; }
        public string PaymentMethod { get; private set; }
        public string Status { get; private set; }

        public PaymentService(Reservation1 reservation, string paymentMethod)
        {
            Reservation = reservation;
            PaymentMethod = paymentMethod;
            Amount = reservation.CalculateTotalCost();
            PaymentDate = DateTime.Now;
            Status = "Unpaid";
        }

        public void Pay()
        {
            Status = "Paid";
        }

        public void Cancel()
        {
            Status = "Cancelled";
        }
    }
}
