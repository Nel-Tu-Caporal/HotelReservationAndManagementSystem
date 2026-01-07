using HotelReservationAndManagementSystem.Models.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelReservationAndManagementSystem.Interface.Services
{
    public interface IClientService
    {
        bool AddClient(Client1 client);
        bool UpdateClient(string id, Client1 client);
        bool DeleteClient(string id);

        void LoadClients(DataGridView dgv);
        void SearchClients(string keyword, DataGridView dgv);
    }
}
