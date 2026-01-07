using HotelReservationAndManagementSystem.Interface;
using HotelReservationAndManagementSystem.Interface.Service;
using HotelReservationAndManagementSystem.Interface.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelReservationAndManagementSystem.Models.Services
{
    public class RoomService : IRoomService
    {
        private readonly IRoomRepository _roomRepo;

        public RoomService(IRoomRepository roomRepo)
        {
            _roomRepo = roomRepo;
        }

        public bool AddRoom(string type, string phone)
        {
            if (string.IsNullOrWhiteSpace(type) ||
                string.IsNullOrWhiteSpace(phone))
                return false;

            return _roomRepo.AddRoom(type, phone, "Yes");
        }

        public bool UpdateRoom(string no, string type, string phone)
        {
            if (string.IsNullOrWhiteSpace(no) ||
                string.IsNullOrWhiteSpace(type) ||
                string.IsNullOrWhiteSpace(phone))
                return false;

            return _roomRepo.UpdateRoom(no, type, phone, "Yes");
        }

        public bool DeleteRoom(string no)
        {
            if (string.IsNullOrWhiteSpace(no))
                return false;

            return _roomRepo.DeleteRoom(no);
        }

        public void LoadRooms(DataGridView dgv)
        {
            _roomRepo.LoadRooms(
                "SELECT Room_Number, Room_Type, Room_Phone, Room_Free FROM Room_Table",
                dgv
            );
        }

        public void LoadAvailableRooms(ComboBox cb)
        {
            _roomRepo.LoadRoomNumbers(
                "SELECT Room_Number FROM Room_Table WHERE Room_Free = 'Yes'",
                cb
            );
        }
    }
}