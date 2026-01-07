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
    public class ReservationRepository : IReservationRepository
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

        public bool CheckInFromReservation(int reservationId, string clientName, int roomNumber,
                                           string roomType, decimal roomRate,
                                           DateTime checkIn, DateTime expectedOut)
        {
            return _db.CheckInFromReservation(
                reservationId,
                clientName,
                roomNumber,
                roomType,
                roomRate,
                checkIn,
                expectedOut
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
    }
}