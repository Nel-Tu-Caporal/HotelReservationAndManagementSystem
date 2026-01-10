using HotelReservationAndManagementSystem.Interface;
using HotelReservationAndManagementSystem.Models;
using HotelReservationAndManagementSystem.References;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            Room room = new Room(type);

            return _db.AddRoom(
                room.RoomType,
                phone,
                room.RoomRate,
                free ? "Yes" : "No"
            );
        }

        public bool UpdateRoom(string no, string type, string phone, bool free)
        {
            Room room = new Room(type);

            return _db.UpdateRoom(
                no,
                room.RoomType,
                phone,
                room.RoomRate,
                free ? "Yes" : "No"
            );
        }

        public bool DeleteRoom(string no)
        {
            return _db.DeleteRoom(no);
        }

        public void LoadRooms(DataGridView dgv)
        {
            DataTable dt = _db.GetDataTable(
                "SELECT Room_Number, Room_Type, Room_Phone, Room_Free FROM Room_Table"
            );

            // Recompute RoomRate using Room class (OOP)
            dt.Columns.Add("Room_Rate", typeof(decimal));

            foreach (DataRow row in dt.Rows)
            {
                Room room = new Room(row["Room_Type"].ToString());
                row["Room_Rate"] = room.RoomRate;
            }

            dgv.DataSource = dt;
        }

        public void LoadAvailableRooms(ComboBox cb)
        {
            _db.RoomTypeAndNo(
                "SELECT Room_Number FROM Room_Table WHERE Room_Free = 'Yes'",
                cb
            );
        }
        public DataTable SearchRoomByNumber(int roomNo)
        {
            DataTable dt = _db.GetDataTable(
                $"SELECT Room_Number, Room_Type, Room_Phone, Room_Free " +
                $"FROM Room_Table WHERE Room_Number = {roomNo}"
            );

            dt.Columns.Add("Room_Rate", typeof(decimal));

            foreach (DataRow row in dt.Rows)
            {
                Room room = new Room(row["Room_Type"].ToString());
                row["Room_Rate"] = room.RoomRate;
            }

            return dt;
        }
    }
}