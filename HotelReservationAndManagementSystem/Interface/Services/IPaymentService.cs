using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservationAndManagementSystem.Interface.Services
{
    public interface IPaymentService
    {
        DataTable LoadBillingList();
        DataTable LoadBillingDetails(int reservationId);

        bool Pay(
            int checkInOutId,
            int reservationId,
            decimal totalAmount,
            decimal amountPaid,
            string paymentMethod
        );
    }
}
