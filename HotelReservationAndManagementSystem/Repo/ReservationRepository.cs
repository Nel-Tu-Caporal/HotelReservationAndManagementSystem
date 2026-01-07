using HotelReservationAndManagementSystem.Interface;
using HotelReservationAndManagementSystem.References;
using System;
using System.Collections.Generic;
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

        // ================= ADD =================
        public bool AddReservation(
            string roomType,
            int roomNo,
            int clientId,
            DateTime checkIn,
            DateTime checkOut)
        {
            return _db.AddReservation(
                roomType,
                roomNo,
                clientId,
                checkIn,
                checkOut
            );
        }

        // ================= LOAD =================
        public void LoadReservations(DataGridView dgv)
        {
            _db.DisplayAndSearch(
                "SELECT * FROM Reservation_Table",
                dgv
            );
        }

        public void SearchReservationByClient(string clientId, DataGridView dgv)
        {
            _db.DisplayAndSearch(
                "SELECT * FROM Reservation_Table WHERE Client_ID LIKE '%" + clientId + "%'",
                dgv
            );
        }

        // ================= UPDATE =================
        public bool UpdateReservation(
            int reservationId,
            string roomType,
            int roomNo,
            int clientId,
            DateTime checkIn,
            DateTime checkOut)
        {
            return _db.UpdateReservation(
                reservationId,
                roomType,
                roomNo,
                clientId,
                checkIn,
                checkOut
            );
        }

        // ================= CHECK-IN =================
        public bool CheckInFromReservation(
            int reservationId,
            string clientName,
            int roomNo,
            string roomType,
            decimal roomRate,
            DateTime checkIn,
            DateTime expectedCheckOut)
        {
            return _db.CheckInFromReservation(
                reservationId,
                clientName,
                roomNo,
                roomType,
                roomRate,
                checkIn,
                expectedCheckOut
            );
        }

        // ================= ROOMS =================
        public void RoomTypeAndNo(string query, ComboBox comboBox)
        {
            _db.RoomTypeAndNo(query, comboBox);
        }

        public void UpdateReservationRoom(string roomNo, string free)
        {
            _db.UpdateReservationRoom(roomNo, free);
        }
    }
}