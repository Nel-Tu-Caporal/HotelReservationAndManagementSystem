using HotelReservationAndManagementSystem.Interface;
using HotelReservationAndManagementSystem.References;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace HotelReservationAndManagementSystem.Repo
{
    public class ReservationRepository
    {
        private readonly DBConnector1 _db;

        public ReservationRepository(DBConnector1 db)
        {
            _db = db;
        }

        public bool AddReservation(string type, int roomNo, int clientId, DateTime inDate, DateTime outDate)
            {
                return _db.AddReservation(type, roomNo, clientId, inDate, outDate);
            }

            public bool UpdateReservation(int reservationId, string type, int roomNo, int clientId, DateTime inDate, DateTime outDate)
            {
                return _db.UpdateReservation(reservationId, type, roomNo, clientId, inDate, outDate);
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



        public void DisplayAndSearch(string query, DataGridView dgv)
            {
                _db.DisplayAndSearch(query, dgv);
            }

            public void RoomTypeAndNo(string query, ComboBox comboBox)
            {
                _db.RoomTypeAndNo(query, comboBox);
            }

            public void UpdateReservationRoom(string roomNo, string free)
            {
                _db.UpdateReservationRoom(roomNo, free);
            }

            // ✅ Fixed GetDataTable without exposing GetConnection
            public DataTable GetDataTable(string query)
            {
                // Let DBConnector1 handle the connection internally
                return _db.ExecuteQuery(query); 
            }
        public bool CancelReservation(int reservationId)
        {
            string query = $@"
UPDATE Reservation_Table
SET Reservation_Status = 'Cancelled'
WHERE Reservation_ID = {reservationId}
  AND Reservation_Status = 'Reserved'";

            _db.ExecuteQuery(query);

            return true; // DBConnector1 does not return affected rows
        }

    }
 }
    
