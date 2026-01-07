using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelReservationAndManagementSystem.Interface.Services
{
    public interface IReservationService
    {
        bool AddReservation(string roomType, int roomNo, int clientId,
                            DateTime checkIn, DateTime checkOut);

        void LoadReservations(DataGridView dgv);

        void SearchByClient(string clientId, DataGridView dgv);

        bool UpdateReservation(int reservationId, string roomType, int roomNo, int clientId,
                               DateTime checkIn, DateTime checkOut, string oldRoomNo);

        bool CheckIn(int reservationId, string clientName, int roomNo,
                     string roomType, DateTime expectedCheckOut);

        void LoadRoomNumbers(string query, ComboBox comboBox);
    }
}