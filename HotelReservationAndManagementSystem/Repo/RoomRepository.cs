using HotelReservationAndManagementSystem.Interface;
using HotelReservationAndManagementSystem.References;
using HotelReservationAndManagementSystem.References;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;

namespace HotelReservationAndManagementSystem.Repo
{
    public class RoomRepository : IRoomRepository
    {
        private readonly DBConnector1 _db;

        public RoomRepository(DBConnector1 db)
        {
            _db = db;
        }

        public bool AddRoom(string type, string phone, bool free)
        {
            return _db.AddRoom(type, phone, free ? "Yes" : "No");
        }

        public bool UpdateRoom(string no, string type, string phone, bool free)
        {
            return _db.UpdateRoom(no, type, phone, free ? "Yes" : "No");
        }

        public bool DeleteRoom(string no)
        {
            return _db.DeleteRoom(no);
        }

        //  use existing DAL method
        public void LoadRooms(DataGridView dgv)
        {
            _db.DisplayAndSearch(
                "SELECT Room_Number, Room_Type, Room_Phone, Room_Free FROM Room_Table",
                dgv
            );
        }

        //  use existing DAL method
        public void LoadAvailableRooms(ComboBox cb)
        {
            _db.RoomTypeAndNo(
                "SELECT Room_Number FROM Room_Table WHERE Room_Free = 'Yes'",
                cb
            );
        }
    }
}