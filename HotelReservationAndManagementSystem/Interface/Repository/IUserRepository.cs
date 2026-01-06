using HotelReservationAndManagementSystem.Models;
using HotelReservationAndManagementSystem.Models.Users;
using System;
using System.Data;
using System.Windows.Forms;

namespace HotelReservationAndManagementSystem.Interface
{
    public interface IUserRepository
    {
        //  User
        bool IsValidNamePass(string Username, string Password);
        bool AddUser(string Username, string Password);
        bool UpdateUser(string ID, string Username, string Password);
        bool DeleteUser(string ID);
        void DisplayAndSearch(string query, DataGridView dgv);

        //  Client
        bool AddClient(string FirstName, string LastName, string Phone, string Address);
        bool UpdateClient(string ID, string FirstName, string LastName, string Phone, string Address);
        bool DeleteClient(string ID);
        Guest GetGuestById(int clientId);

        //  Room
        bool AddRoom(string Type, string Phone, string Free);
        bool UpdateRoom(string No, string Type, string Phone, string Free);
        bool DeleteRoom(string No);
        void RoomTypeAndNo(string query, ComboBox cb);
        void UpdateReservationRoom(string No, string Free);

        //  Reservation
        bool AddReservation(string type, int roomNo, int clientId, DateTime checkIn, DateTime checkOut);
        bool UpdateReservation(int reservationId, string roomType, int roomNumber, int clientId, DateTime dateIn, DateTime dateOut);
        bool CancelReservation(int reservationId);
        int GetReservationId(int clientId, int roomNo);

        // Check-in / Check-out
        bool CheckInFromReservation(int reservationId, string clientName, int roomNumber, string roomType, decimal roomRate, DateTime checkInDate, DateTime expectedCheckOutDate);
        bool UpdateCheckIn(int checkInOutId, DateTime newExpectedOut);
        bool CancelCheckIn(int checkInOutId, int roomNumber);
        bool CheckOutReservation(int reservationId);

        //  Payment / Billing
        bool AddPayment(int checkInOutId, int reservationId, int clientId, decimal totalAmount, decimal amountPaid, decimal changeAmount, string paymentMethod);
        void UpdateCheckInOutPaymentStatus(int checkInOutId);
        DataTable GetBillingDetails(int reservationId);
        int GetClientIdFromReservation(int reservationId);

        //  Utility
        int Count(string query);
    }
}