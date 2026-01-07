using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservationAndManagementSystem.Interface
{
    public interface IPaymentRepository
    {
        DataTable GetBillingList();
        DataTable GetBillingDetails(int reservationId);
        int GetClientIdFromReservation(int reservationId);

        bool AddPayment(
            int checkInOutId,
            int reservationId,
            int clientId,
            decimal totalAmount,
            decimal amountPaid,
            decimal changeAmount,
            string paymentMethod
        );

        void UpdateCheckInOutPaymentStatus(int checkInOutId);
    }
}
