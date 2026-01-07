using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelReservationAndManagementSystem.Interface
{
    public interface IReservationRepository
    {
        bool AddReservation(string type, int roomNo, int clientId, DateTime inDate, DateTime outDate);
        bool UpdateReservation(int reservationId, string type, int roomNo, int clientId, DateTime inDate, DateTime outDate);
        bool CancelReservation(int reservationId);

        bool CheckInFromReservation(
            int reservationId,
            string clientName,
            int roomNumber,
            string roomType,
            decimal roomRate,
            DateTime checkIn,
            DateTime expectedOut
        );
        bool CheckOutReservation(int reservationId);

        int GetReservationId(int clientId, int roomNo);

        void DisplayAndSearch(string query, DataGridView dgv);
    }
}

