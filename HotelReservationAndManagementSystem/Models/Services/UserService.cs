using HotelReservationAndManagementSystem.Interface;
using HotelReservationAndManagementSystem.Models.Users;
using System.Windows.Forms;

namespace HotelReservationAndManagementSystem.Models.Services
{
    public class UserRepository : IUserService
    {
        private readonly IUserRepository _repo;

        public UserRepository(IUserRepository repo)
        {
            _repo = repo;
        }

        public bool Login(string username, string password)
        {
            return _repo.IsValidNamePass(username, password);
        }

        public bool AddUser(SystemUser user)
        {
            return _repo.AddUser(user.Username, user.Password);
        }

        public bool UpdateUser(int id, SystemUser user)
        {
            
            return _repo.UpdateUser(id.ToString(), user.Username, user.Password);
        }

        public bool DeleteUser(int id)
        {
            return _repo.DeleteUser(id.ToString());
        }
        public void LoadUsers(DataGridView dgv)
        {
            _repo.DisplayAndSearch("SELECT * FROM User_Table", dgv);
        }

        public void SearchUsers(string keyword, DataGridView dgv)
        {
            string query = "SELECT * FROM User_Table WHERE User_Name LIKE '%" + keyword + "%'";
            _repo.DisplayAndSearch(query, dgv);
        }
    }
}