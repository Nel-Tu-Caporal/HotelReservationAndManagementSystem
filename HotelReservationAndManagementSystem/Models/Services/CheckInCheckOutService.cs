    using HotelReservationAndManagementSystem.Interface;
    using HotelReservationAndManagementSystem.Interface.Services;
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace HotelReservationAndManagementSystem.Models.Services
    {
        public class CheckInOutService : ICheckInOutService
        {
            private readonly ICheckInOutRepository _repo;

            public CheckInOutService(ICheckInOutRepository repo)
            {
                _repo = repo;
            }

            public bool CheckIn(
                int reservationId,
                string clientName,
                int roomNumber,
                string roomType,
                decimal roomRate,
                DateTime checkIn,
                DateTime expectedOut)
            {
                return _repo.CheckInFromReservation(
                    reservationId,
                    clientName,
                    roomNumber,
                    roomType,
                    roomRate,
                    checkIn,
                    expectedOut
                );
            }

            public bool CheckOut(int reservationId)
            {
                return _repo.CheckOutReservation(reservationId);
            }

         
            public DataTable LoadCheckedInList()
            {
                return _repo.GetCheckedInList();
            }

            public bool CancelCheckIn(int checkInOutId, int roomNumber)
            {
                return _repo.CancelCheckIn(checkInOutId, roomNumber);
            }
        }
    }