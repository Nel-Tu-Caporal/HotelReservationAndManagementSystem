using HotelReservationAndManagementSystem.Interface;
using HotelReservationAndManagementSystem.References;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelReservationAndManagementSystem.Repo
{
    public class ClientRepository : IClientRepository
    {
        private readonly DBConnector1 _db;

        public ClientRepository(DBConnector1 db)
        {
            _db = db;
        }

        public bool AddClient(string firstName, string lastName, string phone, string address)
        {
            return _db.AddClient(firstName, lastName, phone, address);
        }

        public bool UpdateClient(string id, string firstName, string lastName, string phone, string address)
        {
            return _db.UpdateClient(id, firstName, lastName, phone, address);
        }

        public bool DeleteClient(string id)
        {
            return _db.DeleteClient(id);
        }

        public void LoadClients(DataGridView dgv)
        {
            _db.DisplayAndSearch("SELECT * FROM Client_Table", dgv);
        }

        public void SearchClients(string keyword, DataGridView dgv)
        {
            _db.DisplayAndSearch(
                $"SELECT * FROM Client_Table WHERE Phone LIKE '%{keyword}%'", dgv);
        }
    }
}