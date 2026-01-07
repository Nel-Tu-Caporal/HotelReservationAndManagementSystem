    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace HotelReservationAndManagementSystem.Interface.Services
    {
        public interface ICheckInOutService
        {
            bool CheckIn(
                int reservationId,
                string clientName,
                int roomNumber,
                string roomType,
                decimal roomRate,
                DateTime checkIn,
                DateTime expectedOut
            );

            bool CheckOut(int reservationId);

       

       
            DataTable LoadCheckedInList();
            bool CancelCheckIn(int checkInOutId, int roomNumber);
       
        }
    }