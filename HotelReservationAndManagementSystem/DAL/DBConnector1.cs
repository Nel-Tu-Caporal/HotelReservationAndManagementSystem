    using HotelReservationAndManagementSystem.Models;
    using HotelReservationAndManagementSystem.Models.Users;
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.SqlClient;
    using System.Linq;
    using System.Net.NetworkInformation;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using HotelReservationAndManagementSystem.Interface;


namespace HotelReservationAndManagementSystem.References
    {
        public class DBConnector1 : IUserRepository 
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
                //  Initialize 'check' outside the try block so it is accessible for 'return'
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
            using (SqlConnection con = GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgv.AutoGenerateColumns = true;
                    dgv.DataSource = dt;
                }
            }
            }

        public Guest GetGuestById(int clientId)
        {
            Guest guest = null;

            string query = "SELECT * FROM Client_Table WHERE Client_ID = @ClientID";

            using (SqlConnection con = GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.Add("@ClientID", SqlDbType.Int).Value = clientId;

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            guest = new Guest
                            {
                                UserID = Convert.ToInt32(reader["Client_ID"]),
                                FullName = reader["Client_FirstName"] + " " + reader["Client_LastName"],
                                Phone = reader["Client_Phone"].ToString()
                            };
                        }
                    }
                }
            }

            return guest;
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
            using (SqlConnection connection = GetConnection())
            {
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    string reservationQuery = @"
INSERT INTO Reservation_Table
(Room_Number, Room_Type, Client_ID, Reservation_In, Reservation_Out, Reservation_Status)
VALUES (@No, @Type, @CID, @In, @Out, 'Reserved')";

                    using (SqlCommand cmd = new SqlCommand(reservationQuery, connection, transaction))
                    {
                        cmd.Parameters.Add("@Type", SqlDbType.VarChar).Value = type;
                        cmd.Parameters.Add("@No", SqlDbType.Int).Value = roomNo;
                        cmd.Parameters.Add("@CID", SqlDbType.Int).Value = clientId;
                        cmd.Parameters.Add("@In", SqlDbType.Date).Value = checkIn;
                        cmd.Parameters.Add("@Out", SqlDbType.Date).Value = checkOut;

                        cmd.ExecuteNonQuery();
                    }

                    string updateRoom = @"
UPDATE Room_Table
SET Room_Free = 'No'
WHERE Room_Number = @RoomNo";

                    using (SqlCommand cmd = new SqlCommand(updateRoom, connection, transaction))
                    {
                        cmd.Parameters.Add("@RoomNo", SqlDbType.Int).Value = roomNo;
                        cmd.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    return true;
                }
                catch
                {
                    transaction.Rollback();
                    throw; // 🔥 IMPORTANT: let UserControl handle the error
                }
            }
        
        }
            public bool CheckInFromReservation(
         int reservationId,
         string clientName,
         int roomNumber,
         string roomType,
         decimal roomRate,
         DateTime checkInDate,
         DateTime expectedCheckOutDate
     )
            {
                using (SqlConnection con = GetConnection())
                {
                    SqlTransaction tx = con.BeginTransaction();

                    try
                    {
                    // 1️⃣ Prevent duplicate active check-in
                    string existsQuery = @"
SELECT COUNT(*)
FROM CheckInOut_Table
WHERE Reservation_ID = @RID
  AND ActualCheckOutDate IS NULL";

                    using (SqlCommand checkCmd = new SqlCommand(existsQuery, con, tx))
                        {
                            checkCmd.Parameters.Add("@RID", SqlDbType.Int).Value = reservationId;
                            int exists = (int)checkCmd.ExecuteScalar();
                            if (exists > 0)
                                return false;
                        }

                        // 2️⃣ INSERT check-in
                        string insertQuery = @"
                    INSERT INTO CheckInOut_Table
                    (Reservation_ID, ClientName, Room_Number, Room_Type,
                     CheckInDate, ExpectedCheckOutDate, RoomRate,
                     Status, PaymentStatus)
                    VALUES
                    (@RID, @ClientName, @RoomNo, @RoomType,
                     @CheckIn, @ExpectedOut, @Rate,
                     'CheckedIn', 'Pending')";

                        using (SqlCommand cmd = new SqlCommand(insertQuery, con, tx))
                        {
                            cmd.Parameters.Add("@RID", SqlDbType.Int).Value = reservationId;
                            cmd.Parameters.Add("@ClientName", SqlDbType.VarChar).Value = clientName;
                            cmd.Parameters.Add("@RoomNo", SqlDbType.Int).Value = roomNumber;
                            cmd.Parameters.Add("@RoomType", SqlDbType.VarChar).Value = roomType;
                            cmd.Parameters.Add("@CheckIn", SqlDbType.DateTime).Value = checkInDate;
                            cmd.Parameters.Add("@ExpectedOut", SqlDbType.DateTime).Value = expectedCheckOutDate;
                            cmd.Parameters.Add("@Rate", SqlDbType.Decimal).Value = roomRate;

                            cmd.ExecuteNonQuery();
                        }

                        // 3️⃣ Update reservation status
                        string updateReservation = @"
                    UPDATE Reservation_Table
                    SET Reservation_Status = 'CheckedIn'
                    WHERE Reservation_ID = @RID";

                        using (SqlCommand cmd = new SqlCommand(updateReservation, con, tx))
                        {
                            cmd.Parameters.Add("@RID", SqlDbType.Int).Value = reservationId;
                            cmd.ExecuteNonQuery();
                        }

                        tx.Commit();
                        return true;
                    }
                    catch
                    {
                        tx.Rollback();
                        return false;
                    }
                }
            }

        public bool UpdateReservation(
    int reservationId,
    string roomType,
    int roomNumber,
    int clientId,
    DateTime dateIn,
    DateTime dateOut)
        {
            try
            {
                using (SqlConnection con = GetConnection())
                {
                    string query = @"
UPDATE Reservation_Table
SET 
    Room_Type = @RoomType,
    Room_Number = @RoomNumber,
    Client_ID = @ClientID,
    Reservation_In = @DateIn,
    Reservation_Out = @DateOut
WHERE Reservation_ID = @ReservationID
  AND Reservation_Status = 'Reserved'";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.Add("@RoomType", SqlDbType.VarChar).Value = roomType;
                        cmd.Parameters.Add("@RoomNumber", SqlDbType.Int).Value = roomNumber;
                        cmd.Parameters.Add("@ClientID", SqlDbType.Int).Value = clientId;
                        cmd.Parameters.Add("@DateIn", SqlDbType.Date).Value = dateIn;
                        cmd.Parameters.Add("@DateOut", SqlDbType.Date).Value = dateOut;
                        cmd.Parameters.Add("@ReservationID", SqlDbType.Int).Value = reservationId;

                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "UpdateReservation Error:\n" + ex.Message,
                    "DAL Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return false;
            }
        }
        public int Count(string query)
            {
                SqlConnection connection = GetConnection();
                SqlCommand sqlCommand = new SqlCommand(query, connection);
                return (int)sqlCommand.ExecuteScalar();
            }
        public DataTable GetCheckedInList()
        {
            DataTable table = new DataTable();

            string query = @"
SELECT
    c.CheckInOut_ID,
    c.Reservation_ID,
    c.ClientName,
    c.Room_Number,
    c.Room_Type,
    c.CheckInDate,
    c.ExpectedCheckOutDate,
    c.RoomRate,
    c.Status
FROM CheckInOut_Table c
WHERE c.Status = 'CheckedIn'";

            using (SqlConnection con = GetConnection())
            using (SqlCommand cmd = new SqlCommand(query, con))
            using (SqlDataAdapter da = new SqlDataAdapter(cmd))
            {
                da.Fill(table);
            }

            return table;
        }




        public bool CheckOutReservation(int ReservationID)
            {
                using (SqlConnection connection = GetConnection())
                {
                    SqlTransaction transaction = connection.BeginTransaction();

                    try
                    {
                        int checkInOutId;
                        int roomNumber;
                        decimal roomRate;
                        DateTime checkInDate;

                        // 1️⃣ Get active check-in
                        string selectQuery = @"
    SELECT 
        CheckInOut_ID,
        Room_Number,
        RoomRate,
        CheckInDate
    FROM CheckInOut_Table
    WHERE Reservation_ID = @ReservationID
      AND Status = 'CheckedIn'";

                        using (SqlCommand selectCmd = new SqlCommand(selectQuery, connection, transaction))
                        {
                            selectCmd.Parameters.Add("@ReservationID", SqlDbType.Int).Value = ReservationID;

                            using (SqlDataReader reader = selectCmd.ExecuteReader())
                            {
                                if (!reader.Read())
                                    throw new Exception("No active check-in found.");

                                checkInOutId = Convert.ToInt32(reader["CheckInOut_ID"]);
                                roomNumber = Convert.ToInt32(reader["Room_Number"]);
                                roomRate = Convert.ToDecimal(reader["RoomRate"]);
                                checkInDate = Convert.ToDateTime(reader["CheckInDate"]);
                            }
                        }

                        // 2️⃣ Compute bill
                        DateTime checkOutDate = DateTime.Now;
                        int totalDays = Math.Max(1, (int)Math.Ceiling((checkOutDate - checkInDate).TotalDays));
                        decimal totalAmount = totalDays * roomRate;

                        // 3️⃣ Update CheckInOut
                        string updateCheckInOut = @"
    UPDATE CheckInOut_Table SET
        ActualCheckOutDate = @CheckOutDate,
        TotalDays = @TotalDays,
        TotalAmount = @TotalAmount,
        PaymentStatus = 'Unpaid',
        Status = 'CheckedOut'
    WHERE CheckInOut_ID = @ID";

                        using (SqlCommand cmd = new SqlCommand(updateCheckInOut, connection, transaction))
                        {
                            cmd.Parameters.Add("@CheckOutDate", SqlDbType.DateTime).Value = checkOutDate;
                            cmd.Parameters.Add("@TotalDays", SqlDbType.Int).Value = totalDays;
                            cmd.Parameters.Add("@TotalAmount", SqlDbType.Decimal).Value = totalAmount;
                            cmd.Parameters.Add("@ID", SqlDbType.Int).Value = checkInOutId;
                            cmd.ExecuteNonQuery();
                        }

                        // 4️⃣ Free the room
                        string freeRoom = @"
    UPDATE Room_Table
    SET Room_Free = 'Yes'
    WHERE Room_Number = @RoomNo";

                        using (SqlCommand cmd = new SqlCommand(freeRoom, connection, transaction))
                        {
                            cmd.Parameters.Add("@RoomNo", SqlDbType.Int).Value = roomNumber;
                            cmd.ExecuteNonQuery();
                        }

                        // 5️⃣ ✅ CLOSE THE RESERVATION (THIS FIXES YOUR BUG)
                        string closeReservation = @"
    UPDATE Reservation_Table
    SET Reservation_Status = 'Completed'
    WHERE Reservation_ID = @ReservationID";

                        using (SqlCommand cmd = new SqlCommand(closeReservation, connection, transaction))
                        {
                            cmd.Parameters.Add("@ReservationID", SqlDbType.Int).Value = ReservationID;
                            cmd.ExecuteNonQuery();
                        }

                        transaction.Commit();

                        MessageBox.Show(
                            "Check-Out Successful!",
                            "Check-Out",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        return true;
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show(
                            "Check-Out failed:\n" + ex.Message,
                            "Check-Out Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);

                        return false;
                    }
                }
            }
            public bool CancelReservation(int reservationId)
            {
                using (SqlConnection connection = GetConnection())
                {
                    string query = @"
    UPDATE Reservation_Table
    SET Reservation_Status = 'Cancelled'
    WHERE Reservation_ID = @ReservationID
      AND Reservation_Status = 'Reserved'";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.Add("@ReservationID", SqlDbType.Int).Value = reservationId;
                        return cmd.ExecuteNonQuery() > 0;
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
            public int GetClientIdFromReservation(int reservationId)
            {
                string query =
                    "SELECT Client_ID FROM Reservation_Table WHERE Reservation_ID = @RID";

                using (SqlConnection connection = GetConnection())
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.Add("@RID", SqlDbType.Int).Value = reservationId;

                    object result = cmd.ExecuteScalar();
                    return result != null ? Convert.ToInt32(result) : 0;
                }
            }
        }
    }
