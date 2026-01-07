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

        bool CheckInFromReservation(
            int reservationId,
            string clientName,
            int roomNumber,
            string roomType,
            decimal roomRate,
            DateTime checkIn,
            DateTime expectedOut
        );

        void DisplayAndSearch(string query, DataGridView dgv);

        void RoomTypeAndNo(string query, ComboBox comboBox);

        void UpdateReservationRoom(string roomNo, string free);
    }
}