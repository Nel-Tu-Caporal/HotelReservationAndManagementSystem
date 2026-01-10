using HotelReservationAndManagementSystem.Interface;
using HotelReservationAndManagementSystem.Interface.Services;
using HotelReservationAndManagementSystem.Models.Users;
using HotelReservationAndManagementSystem.Repo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelReservationAndManagementSystem.Models.Services
{
    public class ReservationService : IReservationService
    {
        private readonly ReservationRepository _repo;

        public ReservationService(ReservationRepository repo)
        {
            _repo = repo;
        }

        public bool AddReservation(string type, int roomNo, int clientId, DateTime inDate, DateTime outDate)
        {
            return _repo.AddReservation(type, roomNo, clientId, inDate, outDate);
        }

        // ✅ FIXED — uses REAL table & columns
        public List<int> GetAvailableRoomNumbers(string roomType, string oldRoomNo)
        {
            if (string.IsNullOrWhiteSpace(roomType))
                return new List<int>();

            string query;

            if (int.TryParse(oldRoomNo, out int oldNo))
            {
                query = $@"
SELECT Room_Number
FROM Room_Table
WHERE Room_Type = '{roomType}'
  AND (Room_Number = {oldNo} OR Room_Free = 'Yes')";
            }
            else
            {
                query = $@"
SELECT Room_Number
FROM Room_Table
WHERE Room_Type = '{roomType}'
  AND Room_Free = 'Yes'";
            }

            DataTable dt = _repo.GetDataTable(query);

            return dt.AsEnumerable()
                     .Select(r => Convert.ToInt32(r["Room_Number"]))
                     .ToList();
        }

        // ✅ FIXED — REAL reservation table
        public DataTable GetReservations()
        {
            return _repo.GetDataTable(
                "SELECT Reservation_ID, Room_Type, Room_Number, Client_ID, Reservation_In, Reservation_Out, Reservation_Status FROM Reservation_Table"
            );
        }

        // ✅ FIXED
        public DataTable SearchReservationsByClient(int clientId)
        {
            return _repo.GetDataTable(
                $"SELECT Reservation_ID, Room_Type, Room_Number, Client_ID, Reservation_In, Reservation_Out, Reservation_Status " +
                $"FROM Reservation_Table WHERE Client_ID = {clientId}"
            );
        }

        public bool UpdateReservation(int reservationId, string type, int roomNo, int clientId,
                                      DateTime inDate, DateTime outDate, string oldRoomNo)
        {
            if (!string.IsNullOrEmpty(oldRoomNo))
                _repo.UpdateReservationRoom(oldRoomNo, "Yes");

            bool success = _repo.UpdateReservation(reservationId, type, roomNo, clientId, inDate, outDate);

            if (success)
                _repo.UpdateReservationRoom(roomNo.ToString(), "No");

            return success;
        }

        public bool CheckIn(
    int reservationId,
    string clientName,
    int roomNumber,
    string roomType,
    decimal roomRate,
    DateTime checkInDate,
    DateTime expectedOutDate)
        {
            return _repo.CheckInFromReservation(
                reservationId,
                clientName,
                roomNumber,
                roomType,
                roomRate,
                checkInDate,
                expectedOutDate
            );
        }

        public bool CanModifyReservation(int reservationId)
        {
            DataTable dt = _repo.GetDataTable(
                $"SELECT Reservation_Status FROM Reservation_Table WHERE Reservation_ID = {reservationId}"
            );

            if (dt.Rows.Count == 0)
                return false;

            return dt.Rows[0]["Reservation_Status"].ToString() == "Reserved";
        }
        public bool ClientExists(int clientId)
        {
            DataTable dt = _repo.GetDataTable(
                $"SELECT Client_ID FROM Client_Table WHERE Client_ID = {clientId}"
            );

            return dt.Rows.Count > 0;
        }
        public bool CancelReservation(int reservationId, string roomNo)
        {
            bool success = _repo.CancelReservation(reservationId);

            if (success && !string.IsNullOrWhiteSpace(roomNo))
            {
                _repo.UpdateReservationRoom(roomNo, "Yes");
            }

            return success;
        }
    }
}