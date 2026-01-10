using HotelReservationAndManagementSystem.Interface;
using HotelReservationAndManagementSystem.Interface.Services;
using HotelReservationAndManagementSystem.Models.Client;
using HotelReservationAndManagementSystem.Models.Users;
using HotelReservationAndManagementSystem.References;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelReservationAndManagementSystem.Models.Services
{
    public class ClientService : IClientService
    {
        private readonly IClientRepository _repo;

        public ClientService(IClientRepository repo)
        {
            _repo = repo;
        }

        public bool AddClient(Client1 client)
        {
            if (client == null) return false;

            return _repo.AddClient(
                client.FirstName,
                client.LastName,
                client.Phone,
                client.Address);
        }

        public bool UpdateClient(string id, Client1 client)
        {
            if (string.IsNullOrWhiteSpace(id) || client == null) return false;

            return _repo.UpdateClient(
                id,
                client.FirstName,
                client.LastName,
                client.Phone,
                client.Address);
        }

        public bool DeleteClient(string id)
        {
            return !string.IsNullOrWhiteSpace(id) && _repo.DeleteClient(id);
        }

        public void LoadClients(DataGridView dgv)
        {
            _repo.LoadClients(dgv);
        }

        public void SearchClients(string keyword, DataGridView dgv)
        {
            _repo.SearchClients(keyword, dgv);
        }
    }
}