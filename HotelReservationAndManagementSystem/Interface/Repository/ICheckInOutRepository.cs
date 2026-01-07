using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservationAndManagementSystem.Interface
{
    public interface ICheckInOutRepository
    {
        bool CheckInFromReservation(
            int reservationId,
            string clientName,
            int roomNumber,
            string roomType,
            decimal roomRate,
            DateTime checkInDate,
            DateTime expectedCheckOutDate
        );

        bool CheckOutReservation(int reservationId);

      

       
        DataTable GetCheckedInList();
        bool CancelCheckIn(int checkInOutId, int roomNumber);
    }
}