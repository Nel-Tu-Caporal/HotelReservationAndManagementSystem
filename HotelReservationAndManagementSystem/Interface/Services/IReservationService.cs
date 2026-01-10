using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelReservationAndManagementSystem.Interface.Services
{
    public interface IReservationService
    {
        bool AddReservation(string type, int roomNo, int clientId, DateTime inDate, DateTime outDate);

       
        List<int> GetAvailableRoomNumbers(string roomType, string oldRoomNo);

        DataTable GetReservations();


        DataTable SearchReservationsByClient(int clientId);

        bool UpdateReservation(int reservationId, string type, int roomNo, int clientId, DateTime inDate, DateTime outDate, string oldRoomNo);

        bool CheckIn(
    int reservationId,
    string clientName,
    int roomNumber,
    string roomType,
    decimal roomRate,
    DateTime checkInDate,
    DateTime expectedOutDate
);
        bool CanModifyReservation(int reservationId);
        bool ClientExists(int clientId);
        bool CancelReservation(int reservationId, string roomNo);
    }
}

