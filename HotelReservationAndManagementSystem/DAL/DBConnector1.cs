using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
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
            using (SqlConnection connection = GetConnection())
            using (SqlCommand cmd = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
            {
                DataTable table = new DataTable();
                adapter.Fill(table);
                dgv.DataSource = table;
            }
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
            string cmdText =
                "INSERT INTO Room_Table (Room_Type, Room_Phone, Room_Free) " +
                "VALUES (@Type, @Phone, @Free)";

            using (SqlConnection connection = GetConnection())
            using (SqlCommand sqlCommand = new SqlCommand(cmdText, connection))
            {
                sqlCommand.Parameters.Add("@Type", SqlDbType.VarChar, 6).Value = Type;
                sqlCommand.Parameters.Add("@Phone", SqlDbType.VarChar, 15).Value = Phone;
                sqlCommand.Parameters.Add("@Free", SqlDbType.VarChar, 3).Value = Free;

                try
                {
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Added Successfully!", "Room Added");
                    return true;
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 2627)
                        MessageBox.Show("Phone No. already exists.");
                    else
                        MessageBox.Show(ex.Message);

                    return false;
                }
            }
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
            string cmdText =
       "UPDATE Room_Table SET Room_Free = @RoomFree WHERE Room_Number = @RoomNumber";

            using (SqlConnection connection = GetConnection())
            using (SqlCommand cmd = new SqlCommand(cmdText, connection))
            {
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("@RoomNumber", SqlDbType.Int).Value = int.Parse(No);
                cmd.Parameters.Add("@RoomFree", SqlDbType.VarChar, 3).Value = Free;

                int rows = cmd.ExecuteNonQuery();
                if (rows == 0)
                {
                    MessageBox.Show(
                        $"Room update failed: No matching Room_Number ({No})",
                        "Update Room",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
            }
        public bool AddReservation(
     string type,
     int roomNo,
     int clientId,
     DateTime checkIn,
     DateTime checkOut)
        {
            string cmdText = @"
INSERT INTO Reservation_Table
(Room_Number, Room_Type, Client_ID, Reservation_In, Reservation_Out)
VALUES (@No, @Type, @CID, @In, @Out)";

            using (SqlConnection connection = GetConnection())
            using (SqlCommand sqlCommand = new SqlCommand(cmdText, connection))
            {
                sqlCommand.Parameters.Add("@Type", SqlDbType.VarChar).Value = type;
                sqlCommand.Parameters.Add("@No", SqlDbType.Int).Value = roomNo;
                sqlCommand.Parameters.Add("@CID", SqlDbType.Int).Value = clientId;
                sqlCommand.Parameters.Add("@In", SqlDbType.Date).Value = checkIn;
                sqlCommand.Parameters.Add("@Out", SqlDbType.Date).Value = checkOut;

                try
                {
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Added Successfully!", "Reservation Added");
                    return true;
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 547)
                    {
                        MessageBox.Show(
                            "Client ID does not exist. Please register the client first.",
                            "Invalid Client ID",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                        );
                    }
                    else
                    {
                        MessageBox.Show(ex.Message);
                    }
                    return false;
                }
            }
        }
        public bool CheckInFromReservation(
    int reservationId,
    string clientName,
    int roomNumber,
    string roomType,
    DateTime checkIn,
    DateTime expectedCheckOut
)
        {
            string query = @"
        INSERT INTO CheckInOut_Table
        (Reservation_ID, ClientName, Room_Number, Room_Type,
         CheckInDate, ExpectedCheckOutDate, RoomRate, Status)
        SELECT
            r.Reservation_ID,
            @ClientName,
            r.Room_Number,
            r.Room_Type,
            @CheckIn,
            @ExpectedOut,
            rm.Room_Rate,
            'CheckedIn'
        FROM Reservation_Table r
        JOIN Room_Table rm ON r.Room_Number = rm.Room_Number
        WHERE r.Reservation_ID = @ReservationID
          AND r.Reservation_Status = 'Reserved'";

            using (SqlConnection con = GetConnection())
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.Add("@ReservationID", SqlDbType.Int).Value = reservationId;
                cmd.Parameters.Add("@ClientName", SqlDbType.VarChar).Value = clientName;
                cmd.Parameters.Add("@CheckIn", SqlDbType.DateTime).Value = checkIn;
                cmd.Parameters.Add("@ExpectedOut", SqlDbType.DateTime).Value = expectedCheckOut;

                return cmd.ExecuteNonQuery() > 0;
            }
        }
        public void UpdateReservationStatus(int reservationId, string status)
        {
            string query =
                "UPDATE Reservation_Table SET Reservation_Status = @Status " +
                "WHERE Reservation_ID = @ReservationID";

            using (SqlConnection connection = GetConnection())
            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.Add("@ReservationID", SqlDbType.Int).Value = reservationId;
                cmd.Parameters.Add("@Status", SqlDbType.VarChar, 20).Value = status;
                cmd.ExecuteNonQuery();
            }
        }

        public bool UpdateReservation(
    int reservationId,
    string roomType,
    int roomNumber,
    int clientId,
    DateTime checkIn,
    DateTime checkOut)
        {
            string cmdText =
                "UPDATE Reservation_Table SET " +
                "Room_Type = @RoomType, " +
                "Room_Number = @RoomNumber, " +
                "Client_ID = @ClientID, " +
                "Reservation_In = @CheckIn, " +
                "Reservation_Out = @CheckOut " +
                "WHERE Reservation_ID = @ReservationID";

            using (SqlConnection connection = GetConnection())
            using (SqlCommand cmd = new SqlCommand(cmdText, connection))
            {
                cmd.Parameters.Add("@ReservationID", SqlDbType.Int).Value = reservationId;
                cmd.Parameters.Add("@RoomType", SqlDbType.VarChar, 6).Value = roomType;
                cmd.Parameters.Add("@RoomNumber", SqlDbType.Int).Value = roomNumber;
                cmd.Parameters.Add("@ClientID", SqlDbType.Int).Value = clientId;
                cmd.Parameters.Add("@CheckIn", SqlDbType.Date).Value = checkIn;
                cmd.Parameters.Add("@CheckOut", SqlDbType.Date).Value = checkOut;

                try
                {
                    return cmd.ExecuteNonQuery() > 0;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }
        }
        public int Count(string query)
        {
            SqlConnection connection = GetConnection();
            SqlCommand sqlCommand = new SqlCommand(query, connection);
            return (int)sqlCommand.ExecuteScalar();
        }

        public bool CheckInReservation(int ReservationID)
        {
            using (SqlConnection connection = GetConnection())
            {
                try
                {
                    string selectQuery =
                        "SELECT r.Room_Number, r.Room_Type, rm.Room_Rate, r.Reservation_Out, " +
                        "c.Client_FirstName + ' ' + c.Client_LastName AS ClientName " +
                        "FROM Reservation_Table r " +
                        "INNER JOIN Room_Table rm ON r.Room_Number = rm.Room_Number " +
                        "INNER JOIN Client_Table c ON r.Client_ID = c.Client_ID " +
                        "WHERE r.Reservation_ID = @ReservationID";

                    SqlCommand selectCmd = new SqlCommand(selectQuery, connection);
                    selectCmd.Parameters.Add("@ReservationID", SqlDbType.Int).Value = ReservationID;

                    SqlDataReader reader = selectCmd.ExecuteReader();
                    if (!reader.Read())
                    {
                        MessageBox.Show("Reservation not found.");
                        return false;
                    }

                    int roomNumber = Convert.ToInt32(reader["Room_Number"]);
                    string roomType = reader["Room_Type"].ToString();
                    decimal roomRate = Convert.ToDecimal(reader["Room_Rate"]);
                    DateTime expectedOut = Convert.ToDateTime(reader["Reservation_Out"]);
                    string clientName = reader["ClientName"].ToString();

                    reader.Close();

                    string insertQuery =
                        "INSERT INTO CheckInOut_Table " +
                        "(Reservation_ID, ClientName, Room_Number, Room_Type, CheckInDate, ExpectedCheckOutDate, RoomRate, PaymentStatus, Status) " +
                        "VALUES (@ReservationID, @ClientName, @RoomNumber, @RoomType, @CheckInDate, @ExpectedOut, @RoomRate, 'Pending', 'CheckedIn')";

                    SqlCommand insertCmd = new SqlCommand(insertQuery, connection);
                    insertCmd.Parameters.Add("@ReservationID", SqlDbType.Int).Value = ReservationID;
                    insertCmd.Parameters.Add("@ClientName", SqlDbType.VarChar, 300).Value = clientName;
                    insertCmd.Parameters.Add("@RoomNumber", SqlDbType.Int).Value = roomNumber;
                    insertCmd.Parameters.Add("@RoomType", SqlDbType.VarChar, 6).Value = roomType;
                    insertCmd.Parameters.Add("@CheckInDate", SqlDbType.DateTime).Value = DateTime.Now;
                    insertCmd.Parameters.Add("@ExpectedOut", SqlDbType.DateTime).Value = expectedOut;
                    insertCmd.Parameters.Add("@RoomRate", SqlDbType.Decimal).Value = roomRate;

                    insertCmd.ExecuteNonQuery();

                    UpdateReservationRoom(roomNumber.ToString(), "No");

                    MessageBox.Show("Check-In Successful!");
                    return true;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }
        }


        public bool CheckOutReservation(int ReservationID)
        {
            SqlConnection connection = GetConnection();

            try
            {
                string cmdSelect =
                    "SELECT c.CheckInOut_ID, c.CheckInDate, c.RoomRate, r.Room_Number " +
                    "FROM CheckInOut_Table c " +
                    "INNER JOIN Reservation_Table r ON c.Reservation_ID = r.Reservation_ID " +
                    "WHERE c.Reservation_ID = @ReservationID AND c.Status = 'CheckedIn'";

                SqlCommand sqlSelect = new SqlCommand(cmdSelect, connection);
                sqlSelect.Parameters.Add("@ReservationID", SqlDbType.Int).Value = ReservationID;

                int CheckInOutID = 0;
                int RoomNumber = 0;
                decimal RoomRate = 0;
                DateTime CheckInDate;

                SqlDataReader reader = sqlSelect.ExecuteReader();
                if (!reader.Read())
                {
                    reader.Close();
                    MessageBox.Show("No active check-in found.");
                    return false;
                }

                CheckInOutID = Convert.ToInt32(reader["CheckInOut_ID"]);
                CheckInDate = Convert.ToDateTime(reader["CheckInDate"]);
                RoomRate = Convert.ToDecimal(reader["RoomRate"]);
                RoomNumber = Convert.ToInt32(reader["Room_Number"]);
                reader.Close();

                DateTime checkOutDate = DateTime.Now;
                int totalDays = (int)Math.Ceiling((checkOutDate - CheckInDate).TotalDays);
                if (totalDays == 0) totalDays = 1;

                decimal totalAmount = totalDays * RoomRate;

                string cmdUpdate =
                    "UPDATE CheckInOut_Table SET " +
                    "ActualCheckOutDate = @CheckOutDate, " +
                    "TotalDays = @TotalDays, " +
                    "TotalAmount = @TotalAmount, " +
                    "PaymentStatus = 'Unpaid', " +
                    "Status = 'CheckedOut' " +
                    "WHERE CheckInOut_ID = @CheckInOutID";

                SqlCommand sqlUpdate = new SqlCommand(cmdUpdate, connection);
                sqlUpdate.Parameters.Add("@CheckOutDate", SqlDbType.DateTime).Value = checkOutDate;
                sqlUpdate.Parameters.Add("@TotalDays", SqlDbType.Int).Value = totalDays;
                sqlUpdate.Parameters.Add("@TotalAmount", SqlDbType.Decimal).Value = totalAmount;
                sqlUpdate.Parameters.Add("@CheckInOutID", SqlDbType.Int).Value = CheckInOutID;

                sqlUpdate.ExecuteNonQuery();

                // Make room available again
                UpdateReservationRoom(RoomNumber.ToString(), "Yes");

                MessageBox.Show("Check-Out Successful!", "Check-Out",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error!\n" + ex.Message);
                return false;
            }
            finally
            {
                connection.Close();
            }

            return true;
        }
        public bool DeleteReservation(string reservationId)
        {
            string cmdText =
                "DELETE FROM Reservation_Table WHERE Reservation_ID = @ReservationID";

            using (SqlConnection connection = GetConnection())
            using (SqlCommand cmd = new SqlCommand(cmdText, connection))
            {
                cmd.CommandType = CommandType.Text;

                // Convert string RID safely inside DAL
                cmd.Parameters.Add("@ReservationID", SqlDbType.Int)
                    .Value = int.Parse(reservationId);

                try
                {
                    return cmd.ExecuteNonQuery() > 0;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(
                        ex.Message,
                        "Delete Reservation",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                    return false;
                }
            }
        }
        public int GetReservationId(int clientId, int roomNo)
        {
            int reservationId = 0;
            SqlConnection connection = GetConnection();

            try
            {
                string query =
                    "SELECT TOP 1 Reservation_ID FROM Reservation_Table " +
                    "WHERE Client_ID = @ClientID " +
                    "AND Room_Number = @RoomNo " +
                    "AND Reservation_Status = 'Reserved'";

                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.Add("@ClientID", SqlDbType.Int).Value = clientId;
                cmd.Parameters.Add("@RoomNo", SqlDbType.Int).Value = roomNo;
                
                object result = cmd.ExecuteScalar();
                if (result != null)
                    reservationId = Convert.ToInt32(result);
            }
            finally
            {
                connection.Close();
            }

            return reservationId;
        }
        public bool UpdateCheckIn(int checkInOutId, DateTime newExpectedOut)
        {
            SqlConnection connection = GetConnection();
            try
            {
                string query =
                    "UPDATE CheckInOut_Table SET ExpectedCheckOutDate = @OutDate " +
                    "WHERE CheckInOut_ID = @ID AND Status = 'CheckedIn'";

                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.Add("@OutDate", SqlDbType.DateTime).Value = newExpectedOut;
                cmd.Parameters.Add("@ID", SqlDbType.Int).Value = checkInOutId;

                return cmd.ExecuteNonQuery() > 0;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                connection.Close();
            }

        }
        public bool CancelCheckIn(int checkInOutId, int roomNumber)
        {

            SqlConnection connection = GetConnection();
            SqlTransaction transaction = null;

            try
            {
                transaction = connection.BeginTransaction();

                // 1️⃣ Get Reservation_ID from CheckInOut
                int reservationId;
                using (SqlCommand cmdGetReservation = new SqlCommand(
                    "SELECT Reservation_ID FROM CheckInOut_Table WHERE CheckInOut_ID = @ID",
                    connection, transaction))
                {
                    cmdGetReservation.Parameters.Add("@ID", SqlDbType.Int).Value = checkInOutId;

                    object result = cmdGetReservation.ExecuteScalar();
                    if (result == null)
                        throw new Exception("Reservation not found for this check-in.");

                    reservationId = Convert.ToInt32(result);
                }

                // 2️⃣ Cancel Check-In (SOFT cancel, not delete)
                using (SqlCommand cmdCancelCheckIn = new SqlCommand(
                    "UPDATE CheckInOut_Table SET Status = 'Cancelled' WHERE CheckInOut_ID = @ID",
                    connection, transaction))
                {
                    cmdCancelCheckIn.Parameters.Add("@ID", SqlDbType.Int).Value = checkInOutId;
                    cmdCancelCheckIn.ExecuteNonQuery();
                }

                // 3️⃣ Restore Reservation status
                using (SqlCommand cmdRestoreReservation = new SqlCommand(
                    "UPDATE Reservation_Table SET Reservation_Status = 'Reserved' WHERE Reservation_ID = @RID",
                    connection, transaction))
                {
                    cmdRestoreReservation.Parameters.Add("@RID", SqlDbType.Int).Value = reservationId;
                    cmdRestoreReservation.ExecuteNonQuery();
                }

                // 4️⃣ Free the room
                using (SqlCommand cmdFreeRoom = new SqlCommand(
                    "UPDATE Room_Table SET Room_Free = 'Yes' WHERE Room_Number = @RoomNo",
                    connection, transaction))
                {
                    cmdFreeRoom.Parameters.Add("@RoomNo", SqlDbType.Int).Value = roomNumber;
                    cmdFreeRoom.ExecuteNonQuery();
                }

                transaction.Commit();
                return true;
            }
            catch (Exception ex)
            {
                transaction?.Rollback();
                MessageBox.Show(
                    "Cancel Check-In failed:\n" + ex.Message,
                    "Cancel Check-In",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                connection.Close();
            }
        }

        public bool AddPayment(
    int checkInOutId,
    int reservationId,
    int clientId,
    decimal totalAmount,
    decimal amountPaid,
    decimal changeAmount,
    string paymentMethod
)
        {
            string query = @"
INSERT INTO Payment_Table
(CheckInOut_ID, Reservation_ID, Client_ID,
 TotalAmount, AmountPaid, ChangeAmount,
 PaymentMethod, PaymentDate, PaymentStatus)
VALUES
(@CheckInOutID, @ReservationID, @ClientID,
 @TotalAmount, @AmountPaid, @ChangeAmount,
 @PaymentMethod, GETDATE(), 'Paid')";

            using (SqlConnection connection = GetConnection())
            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.Add("@CheckInOutID", SqlDbType.Int).Value = checkInOutId;
                cmd.Parameters.Add("@ReservationID", SqlDbType.Int).Value = reservationId;
                cmd.Parameters.Add("@ClientID", SqlDbType.Int).Value = clientId;
                cmd.Parameters.Add("@TotalAmount", SqlDbType.Decimal).Value = totalAmount;
                cmd.Parameters.Add("@AmountPaid", SqlDbType.Decimal).Value = amountPaid;
                cmd.Parameters.Add("@ChangeAmount", SqlDbType.Decimal).Value = changeAmount;
                cmd.Parameters.Add("@PaymentMethod", SqlDbType.VarChar, 30).Value = paymentMethod;

                try
                {
                    cmd.ExecuteNonQuery();

                    MessageBox.Show(
                        "Payment Successful!",
                        "Payment",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    return true;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(
                        "Payment failed!\n" + ex.Message,
                        "Payment Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                    return false;
                }
            }
        }
        public void UpdateCheckInOutPaymentStatus(int checkInOutId)
        {
            string query =
                "UPDATE CheckInOut_Table " +
                "SET PaymentStatus = 'Paid' " +
                "WHERE CheckInOut_ID = @ID";

            using (SqlConnection connection = GetConnection())
            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.Add("@ID", SqlDbType.Int).Value = checkInOutId;
                cmd.ExecuteNonQuery();
            }
        }
        public DataTable GetBillingDetails(int reservationId)
        {
            DataTable table = new DataTable();

            string query = @"
SELECT
    c.CheckInOut_ID,
    c.ClientName,
    c.Room_Number,
    c.Room_Type,
    c.CheckInDate,
    c.ExpectedCheckOutDate,
    c.TotalDays,
    c.RoomRate,
    c.TotalAmount,
    c.PaymentStatus
FROM CheckInOut_Table c
WHERE c.Reservation_ID = @ReservationID";

            using (SqlConnection connection = GetConnection())
            using (SqlCommand cmd = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
            {
                cmd.Parameters.Add("@ReservationID", SqlDbType.Int).Value = reservationId;
                adapter.Fill(table);
            }

            return table;
        }
    }
}
