using HotelReservationAndManagementSystem.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelReservationAndManagementSystem.Interface
{
    public interface IUserService
    {
        bool Login(string username, string password);
        bool AddUser(SystemUser user);
        bool UpdateUser(int id, SystemUser user);
        bool DeleteUser(int id);
        void LoadUsers(DataGridView dgv);
        void SearchUsers(string keyword, DataGridView dgv);
    }
}
