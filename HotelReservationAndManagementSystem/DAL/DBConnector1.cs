using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace HotelReservationAndManagementSystem.References
{
    public class DBConnector1
    {
        private bool check = false;

        private SqlConnection GetConnection()
        {
            string connectionString = "Data Source = .\\SQLEXPRESS;\r\nInitial Catalog = Hotel_Management_System;\r\n                           Integrated Security = true";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            try
            {
                sqlConnection.Open();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error! \n" + ex.ToString(), "SQL connection", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }

            return sqlConnection;
        }

        public bool IsValidNamePass(string Username, string Password)
        {
            // Fix: Initialize 'check' outside the try block so it is accessible for 'return'
            bool check = false;

            try
            {
                // Use parameters for security (SQL Injection prevention)
                string cmdText = "SELECT User_Name FROM User_Table WHERE User_Name = @Username AND User_Password = @Password";

                // Get the connection object
                SqlConnection connection = GetConnection();

                try // Inner try block (for database operations)
                {
                    // Create the command with the parameterized query
                    SqlCommand selectCommand = new SqlCommand(cmdText, connection);

                    // Add parameters and their values safely
                    selectCommand.Parameters.AddWithValue("@Username", Username);
                    selectCommand.Parameters.AddWithValue("@Password", Password);

                    // Use SqlDataAdapter to fill a DataTable
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand);
                    DataTable dataTable = new DataTable();
                    sqlDataAdapter.Fill(dataTable);

                    // Check if any rows were returned
                    if (dataTable.Rows.Count > 0)
                    {
                        check = true;
                    }
                }
                catch (SqlException ex)
                {
                    // Display error message for SQL issues
                    MessageBox.Show("Error! \n" + ex.ToString(), "Username and Password", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                finally
                {
                    // Ensure connection is closed even if an error occurs
                    if (connection != null && connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
            }
            catch // Outer catch block (optional, but needed if you keep the outer try)
            {
                // Add specific handling for non-SQL errors here if needed
            }

            // Now 'check' is accessible here
            return check;
        }

        public bool AddUser(string Username, string Password)
        {
            string cmdText = "INSERT INTO User_Table VALUES (@User_Name, @User_Password)";
            SqlConnection connection = GetConnection();
            SqlCommand sqlCommand = new SqlCommand(cmdText, connection);
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.Parameters.Add("@User_Name", SqlDbType.VarChar).Value = Username;
            sqlCommand.Parameters.Add("@User_Password", SqlDbType.VarChar).Value = Password;
            try
            {
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Added Successfully!", "User Added", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627)
                {
                    MessageBox.Show("Username already exist.", "Username", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Error! \n" + ex.ToString(), "Add User", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }

                return false;
            }

            connection.Close();
            return true;
        }

        public bool UpdateUser(string ID, string Username, string Password)
        {
            string cmdText = "UPDATE User_Table SET User_Name = @UserName, User_Password = @UserPassword WHERE User_ID = @UserID";
            SqlConnection connection = GetConnection();
            SqlCommand sqlCommand = new SqlCommand(cmdText, connection);
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.Parameters.Add("@UserID", SqlDbType.Int).Value = ID;
            sqlCommand.Parameters.Add("@UserName", SqlDbType.VarChar).Value = Username;
            sqlCommand.Parameters.Add("@UserPassword", SqlDbType.VarChar).Value = Password;
            try
            {
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Updated Successfully!", "User Updated", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627)
                {
                    MessageBox.Show("Username already exist.", "Username", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Error! \n" + ex.ToString(), "Update User", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }

                return false;
            }

            connection.Close();
            return true;
        }

        public bool DeleteUser(string ID)
        {
            string cmdText = "DELETE FROM User_Table WHERE User_ID = @UserID";
            SqlConnection connection = GetConnection();
            SqlCommand sqlCommand = new SqlCommand(cmdText, connection);
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.Parameters.Add("@UserID", SqlDbType.Int).Value = ID;
            try
            {
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Deleted Successfully!", "User Deleted", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error! \n" + ex.ToString(), "Delete User", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return false;
            }

            connection.Close();
            return true;
        }

        public void DisplayAndSearch(string query, DataGridView dgv)
        {
            SqlConnection connection = GetConnection();
            SqlCommand selectCommand = new SqlCommand(query, connection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dgv.DataSource = dataTable;
        }

        public bool AddClient(string FirstName, string LastName, string Phone, string Address)
        {
            string cmdText = "INSERT INTO Client_Table VALUES (@Client_FirstName, @Client_LastName, @Client_Phone, @Client_Address)";
            SqlConnection connection = GetConnection();
            SqlCommand sqlCommand = new SqlCommand(cmdText, connection);
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.Parameters.Add("@Client_FirstName", SqlDbType.VarChar).Value = FirstName;
            sqlCommand.Parameters.Add("@Client_LastName", SqlDbType.VarChar).Value = LastName;
            sqlCommand.Parameters.Add("@Client_Phone", SqlDbType.VarChar).Value = Phone;
            sqlCommand.Parameters.Add("@Client_Address", SqlDbType.VarChar).Value = Address;
            try
            {
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Added Successfully!", "Client Added", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627)
                {
                    MessageBox.Show("Phone No. already exist.", "Phone No.", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Error! \n" + ex.ToString(), "Add Client", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }

                return false;
            }

            connection.Close();
            return true;
        }

        public bool UpdateClient(string ID, string FirstName, string LastName, string Phone, string Address)
        {
            string cmdText = "UPDATE Client_Table SET Client_FirstName = @ClientFirstName, Client_LastName = @ClientLastName, Client_Phone = @ClientPhone, Client_Address = @ClientAddress WHERE Client_ID = @ClientID";
            SqlConnection connection = GetConnection();
            SqlCommand sqlCommand = new SqlCommand(cmdText, connection);
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.Parameters.Add("@ClientID", SqlDbType.Int).Value = ID;
            sqlCommand.Parameters.Add("@ClientFirstName", SqlDbType.VarChar).Value = FirstName;
            sqlCommand.Parameters.Add("@ClientLastName", SqlDbType.VarChar).Value = LastName;
            sqlCommand.Parameters.Add("@ClientPhone", SqlDbType.VarChar).Value = Phone;
            sqlCommand.Parameters.Add("@ClientAddress", SqlDbType.VarChar).Value = Address;
            try
            {
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Updated Successfully!", "Client Updated", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627)
                {
                    MessageBox.Show("Phone No. already exist.", "Phone No.", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Error! \n" + ex.ToString(), "Update Client", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }

                return false;
            }

            connection.Close();
            return true;
        }

        public bool DeleteClient(string ID)
        {
            string cmdText = "DELETE FROM Client_Table WHERE Client_ID = @ClientID";
            SqlConnection connection = GetConnection();
            SqlCommand sqlCommand = new SqlCommand(cmdText, connection);
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.Parameters.Add("@ClientID", SqlDbType.Int).Value = ID;
            try
            {
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Deleted Successfully!", "Client Deleted", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error! \n" + ex.ToString(), "Delete Client", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return false;
            }

            connection.Close();
            return true;
        }

        public bool AddRoom(string Type, string Phone, string Free)
        {
            string cmdText = "INSERT INTO Room_Table VALUES (@Type, @Phone, @Free)";
            SqlConnection connection = GetConnection();
            SqlCommand sqlCommand = new SqlCommand(cmdText, connection);
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.Parameters.Add("@Type", SqlDbType.VarChar).Value = Type;
            sqlCommand.Parameters.Add("@Phone", SqlDbType.VarChar).Value = Phone;
            sqlCommand.Parameters.Add("@Free", SqlDbType.VarChar).Value = Free;
            try
            {
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Added Successfully!", "Room Added", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627)
                {
                    MessageBox.Show("Phone No. already exist.", "Phone No.", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Error! \n" + ex.ToString(), "Add Room", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }

                return false;
            }

            connection.Close();
            return true;
        }

        public bool UpdateRoom(string No, string Type, string Phone, string Free)
        {
            string cmdText = "UPDATE Room_Table SET Room_Type = @RoomType, Room_Phone = @RoomPhone, Room_Free = @RoomFree WHERE Room_Number = @RoomNumber";
            SqlConnection connection = GetConnection();
            SqlCommand sqlCommand = new SqlCommand(cmdText, connection);
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.Parameters.Add("@RoomNumber", SqlDbType.Int).Value = No;
            sqlCommand.Parameters.Add("@RoomType", SqlDbType.VarChar).Value = Type;
            sqlCommand.Parameters.Add("@RoomPhone", SqlDbType.VarChar).Value = Phone;
            sqlCommand.Parameters.Add("@RoomFree", SqlDbType.VarChar).Value = Free;
            try
            {
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Updated Successfully!", "Room Updated", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627)
                {
                    MessageBox.Show("Phone No. already exist.", "Phone No.", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Error! \n" + ex.ToString(), "Update Room", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }

                return false;
            }

            connection.Close();
            return true;
        }

        public bool DeleteRoom(string No)
        {
            string cmdText = "DELETE FROM Room_Table WHERE Room_Number = @RoomNumber";
            SqlConnection connection = GetConnection();
            SqlCommand sqlCommand = new SqlCommand(cmdText, connection);
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.Parameters.Add("@RoomNumber", SqlDbType.Int).Value = No;
            try
            {
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Deleted Successfully!", "Room Deleted", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error! \n" + ex.ToString(), "Delete Room", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return false;
            }

            connection.Close();
            return true;
        }

        public void RoomTypeAndNo(string query, ComboBox cb)
        {
            SqlConnection connection = GetConnection();
            SqlCommand sqlCommand = new SqlCommand(query, connection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            cb.Items.Clear();
            cb.Items.Add("Please select ...");
            cb.SelectedIndex = 0;

            while (sqlDataReader.Read())
            {
                // convert to string explicitly to match database
                cb.Items.Add(sqlDataReader[0].ToString());
            }
        }

        public void UpdateReservationRoom(string No, string Free)
        {
            string cmdText = "UPDATE Room_Table SET Room_Free = @RoomFree WHERE Room_Number = @RoomNumber";
            SqlConnection connection = GetConnection();
            SqlCommand sqlCommand = new SqlCommand(cmdText, connection);
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.Parameters.Add("@RoomNumber", SqlDbType.Int).Value = No;
            sqlCommand.Parameters.Add("@RoomFree", SqlDbType.VarChar).Value = Free;

            try
            {
                int rows = sqlCommand.ExecuteNonQuery();
                if (rows == 0)
                    MessageBox.Show("Room update failed: No matching Room_Number in Room_Table (" + No + ")");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error! \n" + ex.ToString(), "Update Reservation", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }

            connection.Close();
        }

        public bool AddReservation(string Type, string No, string CID, string In, string Out)
        {
            string cmdText = @"INSERT INTO Reservation_Table
(Room_Number, Room_Type, Client_ID, Reservation_In, Reservation_Out)
VALUES (@No, @Type, @CID, @In, @Out)";
            SqlConnection connection = GetConnection();
            SqlCommand sqlCommand = new SqlCommand(cmdText, connection);
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.Parameters.Add("@Type", SqlDbType.VarChar).Value = Type;
            sqlCommand.Parameters.Add("@No", SqlDbType.Int).Value = No;
            sqlCommand.Parameters.Add("@CID", SqlDbType.Int).Value = CID;
            sqlCommand.Parameters.Add("@In", SqlDbType.VarChar).Value = In;
            sqlCommand.Parameters.Add("@Out", SqlDbType.VarChar).Value = Out;
            try
            {
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Added Successfully!", "Reservation Added", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627)
                {
                    MessageBox.Show("Client ID already exist.", "Client ID", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Error! \n" + ex.ToString(), "Add Reservation", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }

                return false;
            }

            connection.Close();
            return true;
        }

        public bool UpdateReservation(string RID, string Type, string No, string CID, string In, string Out)
        {

            string cmdText = "UPDATE Reservation_Table SET Room_Type = @ReservationRoomType, Room_Number = @ReservationRoomNumber, Client_ID = @ReservationClientID, Reservation_In = @ReservationIn, Reservation_Out = @ReservationOut WHERE Reservation_ID = @ReservationID";

            SqlConnection connection = GetConnection();
            SqlCommand sqlCommand = new SqlCommand(cmdText, connection);
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.Parameters.Add("@ReservationID", SqlDbType.Int).Value = RID;
            sqlCommand.Parameters.Add("@ReservationRoomType", SqlDbType.VarChar).Value = Type;
            sqlCommand.Parameters.Add("@ReservationRoomNumber", SqlDbType.Int).Value = No;
            sqlCommand.Parameters.Add("@ReservationClientID", SqlDbType.Int).Value = CID;
            sqlCommand.Parameters.Add("@ReservationIn", SqlDbType.VarChar).Value = In;
            sqlCommand.Parameters.Add("@ReservationOut", SqlDbType.VarChar).Value = Out;

            try
            {
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Updated Successfully!", "Reservation Updated", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627)
                {
                    MessageBox.Show("Client ID already exist.", "Client ID", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Error! \n" + ex.ToString(), "Update Reservation", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                return false;
            }

            connection.Close();
            return true;
        }

        public bool DeleteReservation(string ID)
        {
            string cmdText = "DELETE FROM Reservation_Table WHERE Reservation_ID = @ReservationID";
            SqlConnection connection = GetConnection();
            SqlCommand sqlCommand = new SqlCommand(cmdText, connection);
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.Parameters.Add("@ReservationID", SqlDbType.Int).Value = ID;
            try
            {
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Canceled Successfully!", "Reservation Canceled", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error! \n" + ex.ToString(), "Canceled Reservation", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return false;
            }

            connection.Close();
            return true;
        }

        public int Count(string query)
        {
            SqlConnection connection = GetConnection();
            SqlCommand sqlCommand = new SqlCommand(query, connection);
            return (int)sqlCommand.ExecuteScalar();
        }

        public bool CheckInReservation(string ReservationID)
        {
            //  Get room number and rate for this reservation
            string cmdRoom = "SELECT Reservation_Room_Number, Room_Rate FROM Reservation_Table " +
                             "INNER JOIN Room_Table ON Reservation_Room_Number = Room_Number " +
                             "WHERE Reservation_ID = @ReservationID";

            SqlConnection connection = GetConnection();
            SqlCommand sqlCmdRoom = new SqlCommand(cmdRoom, connection);
            sqlCmdRoom.Parameters.Add("@ReservationID", SqlDbType.Int).Value = ReservationID;

            int RoomNumber = 0;
            decimal RoomRate = 0;

            try
            {
                SqlDataReader reader = sqlCmdRoom.ExecuteReader();
                if (reader.Read())
                {
                    RoomNumber = Convert.ToInt32(reader["Reservation_Room_Number"]);
                    RoomRate = Convert.ToDecimal(reader["Room_Rate"]);
                }
                reader.Close();

                // Insert into CheckInOut_Table
                string cmdInsert = "INSERT INTO CheckInOut_Table (Reservation_ID, CheckInDate, RoomRate, PaymentStatus) " +
                                   "VALUES (@ReservationID, @CheckInDate, @RoomRate, 'Pending')";

                SqlCommand sqlInsert = new SqlCommand(cmdInsert, connection);
                sqlInsert.Parameters.Add("@ReservationID", SqlDbType.Int).Value = ReservationID;
                sqlInsert.Parameters.Add("@CheckInDate", SqlDbType.DateTime).Value = DateTime.Now;
                sqlInsert.Parameters.Add("@RoomRate", SqlDbType.Decimal).Value = RoomRate;

                sqlInsert.ExecuteNonQuery();

                //  Update room availability to "No"
                UpdateReservationRoom(RoomNumber.ToString(), "No");

                MessageBox.Show("Check-In Successful!", "Check-In", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error! \n" + ex.ToString(), "Check-In", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return false;
            }
            finally
            {
                connection.Close();
            }

            return true;
        }
     

        public bool CheckOutReservation(string ReservationID)
        {
            SqlConnection connection = GetConnection();
            try
            {
                // FIX: Changed Reservation_Room_Number to Room_Number
                string cmdSelect = "SELECT CheckInOut_ID, CheckInDate, RoomRate, Room_Number " +
                                   "FROM CheckInOut_Table " +
                                   "INNER JOIN Reservation_Table ON CheckInOut_Table.Reservation_ID = Reservation_Table.Reservation_ID " +
                                   "WHERE CheckInOut_Table.Reservation_ID = @ReservationID";

                SqlCommand sqlSelect = new SqlCommand(cmdSelect, connection);
                sqlSelect.Parameters.Add("@ReservationID", SqlDbType.Int).Value = ReservationID;

                int RoomNumber = 0;
                decimal RoomRate = 0;
                DateTime CheckInDate = DateTime.Now;
                int CheckInOutID = 0;

                SqlDataReader reader = sqlSelect.ExecuteReader();
                if (reader.Read())
                {
                    CheckInOutID = Convert.ToInt32(reader["CheckInOut_ID"]);
                    CheckInDate = Convert.ToDateTime(reader["CheckInDate"]);
                    RoomRate = Convert.ToDecimal(reader["RoomRate"]);
                    // FIX: Changed reader key to Room_Number
                    RoomNumber = Convert.ToInt32(reader["Room_Number"]);
                }
                reader.Close();

                DateTime checkOutDate = DateTime.Now;
                int totalDays = (int)Math.Ceiling((checkOutDate - CheckInDate).TotalDays);
                if (totalDays == 0) totalDays = 1;
                decimal totalAmount = totalDays * RoomRate;

                string cmdUpdate = "UPDATE CheckInOut_Table SET CheckOutDate = @CheckOutDate, TotalDays = @TotalDays, TotalAmount = @TotalAmount, PaymentStatus = 'Pending' WHERE CheckInOut_ID = @CheckInOutID";
                SqlCommand sqlUpdate = new SqlCommand(cmdUpdate, connection);
                sqlUpdate.Parameters.Add("@CheckOutDate", SqlDbType.DateTime).Value = checkOutDate;
                sqlUpdate.Parameters.Add("@TotalDays", SqlDbType.Int).Value = totalDays;
                sqlUpdate.Parameters.Add("@TotalAmount", SqlDbType.Decimal).Value = totalAmount;
                sqlUpdate.Parameters.Add("@CheckInOutID", SqlDbType.Int).Value = CheckInOutID;
                sqlUpdate.ExecuteNonQuery();

                UpdateReservationRoom(RoomNumber.ToString(), "Yes");
                MessageBox.Show("Check-Out Successful!", "Check-Out", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (SqlException ex) { MessageBox.Show("Error! \n" + ex.ToString()); return false; }
            finally { connection.Close(); }
            return true;
        }
    }
}