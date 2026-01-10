    using HotelReservationAndManagementSystem.Interface;
    using HotelReservationAndManagementSystem.References;
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using HotelReservationAndManagementSystem.Models;

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
            DataTable dt = _db.GetCheckedInList();

            if (dt == null)
                return new DataTable();

            // Ensure RoomRate exists (safe for grid)
            if (!dt.Columns.Contains("RoomRate"))
            {
                dt.Columns.Add("RoomRate", typeof(decimal));

                foreach (DataRow row in dt.Rows)
                {
                    row["RoomRate"] = 0m;
                }
            }

            return dt;
        }

        public bool CancelCheckIn(int checkInOutId, int roomNumber)
        {
            return _db.CancelCheckIn(checkInOutId, roomNumber);
        }
    }
}
