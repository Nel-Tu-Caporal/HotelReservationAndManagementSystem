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
        private readonly ReservationRepository _repo;

        public ReservationService(ReservationRepository repo)
        {
            _repo = repo;
        }

        // ================= ADD =================
        public bool AddReservation(string roomType, int roomNo, int clientId,
                                   DateTime checkIn, DateTime checkOut)
        {
            if (checkOut <= checkIn) return false;

            bool added = _repo.AddReservation(
                roomType,
                roomNo,
                clientId,
                checkIn,
                checkOut
            );

            if (!added) return false;

            // ✅ correct DAL call
            _repo.UpdateReservationRoom(roomNo.ToString(), "No");

            return true;
        }

        // ================= LOAD =================
        public void LoadReservations(DataGridView dgv)
        {
            _repo.LoadReservations(dgv);
        }

        public void SearchByClient(string clientId, DataGridView dgv)
        {
            _repo.SearchReservationByClient(clientId, dgv);
        }

        // ================= UPDATE =================
        public bool UpdateReservation(int reservationId,
                                      string roomType,
                                      int roomNo,
                                      int clientId,
                                      DateTime checkIn,
                                      DateTime checkOut,
                                      string oldRoomNo)
        {
            if (reservationId <= 0) return false;
            if (checkOut <= checkIn) return false;

            bool updated = _repo.UpdateReservation(
                reservationId,
                roomType,
                roomNo,
                clientId,
                checkIn,
                checkOut
            );

            if (!updated) return false;

            // ✅ free old room if changed
            if (!string.IsNullOrEmpty(oldRoomNo) &&
                oldRoomNo != roomNo.ToString())
            {
                _repo.UpdateReservationRoom(oldRoomNo, "Yes");
            }

            // ✅ occupy new room
            _repo.UpdateReservationRoom(roomNo.ToString(), "No");

            return true;
        }

        // ================= CHECK-IN =================
        public bool CheckIn(int reservationId,
                            string clientName,
                            int roomNo,
                            string roomType,
                            DateTime expectedCheckOut)
        {
            if (reservationId <= 0) return false;
            if (roomNo <= 0) return false;

            decimal roomRate = 1000m; // TEMP (same as UC)

            return _repo.CheckInFromReservation(
                reservationId,
                clientName,
                roomNo,
                roomType,
                roomRate,
                DateTime.Now,
                expectedCheckOut
            );
        }

        // ================= ROOMS =================
        public void LoadRoomNumbers(string query, ComboBox comboBox)
        {
            _repo.RoomTypeAndNo(query, comboBox);
        }
    }
}