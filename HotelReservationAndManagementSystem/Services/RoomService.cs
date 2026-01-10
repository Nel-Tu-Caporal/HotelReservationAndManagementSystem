using HotelReservationAndManagementSystem.Interface;
using HotelReservationAndManagementSystem.Interface.Service;
using HotelReservationAndManagementSystem.Interface.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelReservationAndManagementSystem.Models.Services
{
    public class RoomService : IRoomService
    {
        private readonly IRoomRepository _repo;

        public RoomService(IRoomRepository repo)
        {
            _repo = repo;
        }

        public bool AddRoom(string type, string phone, bool free)
        {
            if (string.IsNullOrWhiteSpace(type) || string.IsNullOrWhiteSpace(phone))
                return false;

            return _repo.AddRoom(type, phone, free);
        }

        public bool UpdateRoom(string no, string type, string phone, bool free)
        {
            if (string.IsNullOrWhiteSpace(no) ||
                string.IsNullOrWhiteSpace(type) ||
                string.IsNullOrWhiteSpace(phone))
                return false;

            return _repo.UpdateRoom(no, type, phone, free);
        }

        public bool DeleteRoom(string no)
        {
            return !string.IsNullOrWhiteSpace(no) && _repo.DeleteRoom(no);
        }

        public void LoadRooms(DataGridView dgv)
        {
            _repo.LoadRooms(dgv);
        }

        public void LoadAvailableRooms(ComboBox cb)
        {
            _repo.LoadAvailableRooms(cb);
        }
        public DataTable SearchRoomByNumber(int roomNo)
        {
            return _repo.SearchRoomByNumber(roomNo); // error
        }
    }
}