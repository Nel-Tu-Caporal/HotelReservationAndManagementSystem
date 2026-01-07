using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelReservationAndManagementSystem.Interface
{
    public interface IRoomRepository
    {
        bool AddRoom(string type, string phone, bool free);
        bool UpdateRoom(string no, string type, string phone, bool free);
        bool DeleteRoom(string no);

        void LoadRooms(DataGridView dgv);
        void LoadAvailableRooms(ComboBox cb);
    }
}
