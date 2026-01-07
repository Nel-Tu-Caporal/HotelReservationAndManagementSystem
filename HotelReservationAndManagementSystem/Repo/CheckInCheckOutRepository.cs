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
    public class CheckInOutRepository : ICheckInOutRepository
    {
        private readonly DBConnector1 _db;

        public CheckInOutRepository(DBConnector1 db)
        {
            _db = db;
        }

        public bool CheckInFromReservation(
            int reservationId,
            string clientName,
            int roomNumber,
            string roomType,
            decimal roomRate,
            DateTime checkInDate,
            DateTime expectedCheckOutDate)
        {
            return _db.CheckInFromReservation(
                reservationId,
                clientName,
                roomNumber,
                roomType,
                roomRate,
                checkInDate,
                expectedCheckOutDate
            );
        }

        public bool CheckOutReservation(int reservationId)
        {
            return _db.CheckOutReservation(reservationId);
        }

     
        public DataTable GetCheckedInList()
        {
            return _db.GetCheckedInList();
        }

        public bool CancelCheckIn(int checkInOutId, int roomNumber)
        {
            return _db.CancelCheckIn(checkInOutId, roomNumber);
        }
    }
}
