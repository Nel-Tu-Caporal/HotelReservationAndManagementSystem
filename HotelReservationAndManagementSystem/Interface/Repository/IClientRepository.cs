    using HotelReservationAndManagementSystem.Models;
    using HotelReservationAndManagementSystem.Models.Client;
    using HotelReservationAndManagementSystem.Models.Users;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
        using System.Windows.Forms;

    namespace HotelReservationAndManagementSystem.Interface
    {
        public interface IClientRepository
        {
            bool AddClient(string firstName, string lastName, string phone, string address);
            bool UpdateClient(string id, string firstName, string lastName, string phone, string address);
            bool DeleteClient(string id);

            void LoadClients(DataGridView dgv);
            void SearchClients(string keyword, DataGridView dgv);
        }
    }
