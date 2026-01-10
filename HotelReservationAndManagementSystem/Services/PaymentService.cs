using HotelReservationAndManagementSystem.Interface;
using HotelReservationAndManagementSystem.Interface.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservationAndManagementSystem.Models.Services
{
    public class PaymentService : IPaymentService
    {
        private readonly IPaymentRepository _repo;

        public PaymentService(IPaymentRepository repo)
        {
            _repo = repo;
        }
        public DataTable GetCheckedOutBillingList()
        {
            return _repo.GetCheckedOutBillingList();
        }

        public DataTable GetBillingList()
        {
            return _repo.GetBillingList();
        }

        public DataTable GetBillingDetails(int reservationId)
        {
            return _repo.GetBillingDetails(reservationId);
        }

        public bool ProcessPayment(
            int checkInOutId,
            int reservationId,
            decimal totalAmount,
            decimal amountPaid,
            string paymentMethod)
        {
            if (amountPaid < totalAmount)
                return false;

            int clientId = _repo.GetClientIdFromReservation(reservationId);
            if (clientId <= 0)
                return false;

            decimal change = amountPaid - totalAmount;

            bool success = _repo.AddPayment(
                checkInOutId,
                reservationId,
                clientId,
                totalAmount,
                amountPaid,
                change,
                paymentMethod);

            if (!success)
                return false;

            _repo.UpdateCheckInOutPaymentStatus(checkInOutId);
            return true;
        }

    }
}