using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelReservationAndManagementSystem.Interface
{
    public interface IRoomRepository
    {
        bool AddRoom(string type, string phone, string free);
        bool UpdateRoom(string no, string type, string phone, string free);
        bool DeleteRoom(string no);

        void LoadRooms(string query, DataGridView dgv);
        void LoadRoomNumbers(string query, ComboBox cb);
    }
}

