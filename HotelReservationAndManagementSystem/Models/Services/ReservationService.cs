using HotelReservationAndManagementSystem.Interface;
using HotelReservationAndManagementSystem.Interface.Services;
using HotelReservationAndManagementSystem.Models.Users;
using HotelReservationAndManagementSystem.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelReservationAndManagementSystem.Models.Services
{
    public class ReservationService : IReservationService
    {
        private readonly IReservationRepository _repo;

        public ReservationService(IReservationRepository repo)
        {
            _repo = repo;
        }

        public bool AddReservation(string roomType, int roomNo, int clientId,
                                   DateTime checkIn, DateTime checkOut)
        {
            return _repo.AddReservation(roomType, roomNo, clientId, checkIn, checkOut);
        }

        public void LoadReservations(DataGridView dgv)
        {
            _repo.DisplayAndSearch("SELECT * FROM Reservation_Table", dgv);
        }

        public void SearchByClient(string clientId, DataGridView dgv)
        {
            _repo.DisplayAndSearch(
                "SELECT * FROM Reservation_Table WHERE Client_ID LIKE '%" + clientId + "%'",
                dgv
            );
        }

        public bool UpdateReservation(int reservationId, string roomType, int roomNo,
                                      int clientId, DateTime checkIn,
                                      DateTime checkOut, string oldRoomNo)
        {
            bool updated = _repo.UpdateReservation(
                reservationId, roomType, roomNo, clientId, checkIn, checkOut
            );

            if (updated && oldRoomNo != roomNo.ToString())
            {
                _repo.UpdateReservationRoom(oldRoomNo, "Yes");
                _repo.UpdateReservationRoom(roomNo.ToString(), "No");
            }

            return updated;
        }

        public bool CheckIn(int reservationId, string clientName, int roomNo,
                            string roomType, DateTime expectedCheckOut)
        {
            decimal rate = 0;

            return _repo.CheckInFromReservation(
                reservationId,
                clientName,
                roomNo,
                roomType,
                rate,
                DateTime.Now,
                expectedCheckOut
            );
        }

        public void LoadRoomNumbers(string roomType, string oldRoomNo, ComboBox comboBox)
        {
            string query =
                "SELECT Room_Number FROM Room_Table " +
                "WHERE Room_Type = '" + roomType + "' " +
                "AND (Room_Free = 'Yes' OR Room_Number = '" + oldRoomNo + "')";

            _repo.RoomTypeAndNo(query, comboBox);
        }
    }
}
