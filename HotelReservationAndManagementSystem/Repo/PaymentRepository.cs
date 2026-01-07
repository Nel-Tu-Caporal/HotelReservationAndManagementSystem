using HotelReservationAndManagementSystem.Interface;
using HotelReservationAndManagementSystem.References;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservationAndManagementSystem.Repo
{
    public class PaymentRepository : IPaymentRepository
    {
        private readonly DBConnector1 _db;

        public PaymentRepository(DBConnector1 db)
        {
            _db = db;
        }

        public DataTable GetBillingList()
        {
            return _db.GetBillingDetails(0); // or separate query if needed
        }

        public DataTable GetBillingDetails(int reservationId)
        {
            return _db.GetBillingDetails(reservationId);
        }

        public int GetClientIdFromReservation(int reservationId)
        {
            return _db.GetClientIdFromReservation(reservationId);
        }

        public bool AddPayment(
            int checkInOutId,
            int reservationId,
            int clientId,
            decimal totalAmount,
            decimal amountPaid,
            decimal changeAmount,
            string paymentMethod)
        {
            return _db.AddPayment(
                checkInOutId,
                reservationId,
                clientId,
                totalAmount,
                amountPaid,
                changeAmount,
                paymentMethod);
        }

        public void UpdateCheckInOutPaymentStatus(int checkInOutId)
        {
            _db.UpdateCheckInOutPaymentStatus(checkInOutId);
        }
    }
}
