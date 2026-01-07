using HotelReservationAndManagementSystem.References;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelReservationAndManagementSystem.Interface;
using HotelReservationAndManagementSystem.References;
using System.Windows.Forms;

namespace HotelReservationAndManagementSystem.Repo
{
    public class RoomRepository : IRoomRepository // error 
    {
        private readonly DBConnector1 _db;

        public RoomRepository(DBConnector1 db)
        {
            _db = db;
        }

        public bool AddRoom(string type, string phone, string free)
        {
            return _db.AddRoom(type, phone, free);
        }

        public bool UpdateRoom(string no, string type, string phone, string free)
        {
            return _db.UpdateRoom(no, type, phone, free);
        }

        public bool DeleteRoom(string no)
        {
            return _db.DeleteRoom(no);
        }

        public void LoadRooms(string query, DataGridView dgv)
        {
            _db.DisplayAndSearch(query, dgv);
        }

        public void LoadRoomNumbers(string query, ComboBox cb)
        {
            _db.RoomTypeAndNo(query, cb);
        }
    }
}
