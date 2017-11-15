//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using MySql.Data.MySqlClient;
//using System.Data;

//namespace XEHAR2017
//{
//    public class MiddleEarth
//    {
//        public static bool TestConnection(IDbConnection con, out string message)
//        {
//            try
//            {
//                con.Open();
//                message = "Connection Successful!";
//                con.Close();
//            }
//            catch (Exception s)
//            {
//                message = "Couldn't connect to the database: " + s.Message;
//                return false;
//            }
//            return true;
//        }

//        public static bool TestConnection(IDbConnection con)
//        {
//            try
//            {
//                con.Open();
//                con.Close();
//            }
//            catch (Exception)
//            {
//                return false;
//            }
//            return true;
//        }

//        public static void CreateVendor(MySqlConnection con, Vendor r)
//        {
//            string errors; 
//            if (TestConnection(con, out errors))
//            {
//                con.Open();
//                var sql = "Insert into 'xehardb'.'vendors'" +
//                    "(Name, VIN, phoneNumber, Street, City, State, Zip, Country, Email)" +
//                    "Values(@name, @vin, @phone, @street, @city, @state, @zip, @country, @email)";
//                using (var cmd = new MySqlCommand(sql, con))
//                {
//                    cmd.Parameters.AddWithValue("@name", r.Name);
//                    cmd.Parameters.AddWithValue("@vin", r.Phone);
//                    cmd.Parameters.AddWithValue("@phone", r.Phone);
//                    cmd.Parameters.AddWithValue("@street", r.Phone);
//                    cmd.Parameters.AddWithValue("@city", r.Phone);
//                    cmd.Parameters.AddWithValue("@state", r.Phone);
//                    cmd.Parameters.AddWithValue("@zip", r.Phone);
//                    cmd.Parameters.AddWithValue("@country", r.Phone);
//                    cmd.Parameters.AddWithValue("@email", r.Phone);
//                    cmd.ExecuteNonQuery();
//                }
//            }
//            con.Close();
//        }

//        public static void UpdatePortfolio(MySqlConnection con, Portfolio port, out string message)
//        {
//            if (TestConnection(con, out message))
//            {
//                var query = "Update Portfolio set " +
//                        "Name = @name," +
//                        "Purpose = @purpose," +
//                        "where POID = @poid";
//                con.Open();
//                using (var cmd = new SqlCommand(query, con))
//                {
//                    cmd.Parameters.AddWithValue("@name", port.Name);
//                    cmd.Parameters.AddWithValue("@purpose", port.Purpose);
//                    cmd.Parameters.AddWithValue("@poid", port.POID);
//                    cmd.ExecuteNonQuery();
//                }
//                con.Close();
//            }
//            else
//            {
//                message += "Failed to connect to database...something seems to be wrong";
//            }
//        }

//        public static void UpdatePortfolio(SqlConnection con, Portfolio[] port, out string message)
//        {
//            if (TestConnection(con, out message))
//            {
//                foreach (var upt in port)
//                {
//                    var query = "Update Portfolio set " +
//                                    "Name = @name," +
//                                    "Purpose = @purpose," +
//                                    "where POID = @poid";
//                    con.Open();
//                    using (var cmd = new SqlCommand(query, con))
//                    {
//                        cmd.Parameters.AddWithValue("@name", upt.Name);
//                        cmd.Parameters.AddWithValue("@purpose", upt.Purpose);
//                        cmd.Parameters.AddWithValue("@poid", upt.POID);
//                        cmd.ExecuteNonQuery();
//                    }
//                }
//                con.Close();
//            }
//            else
//            {
//                message += "Failed to connect to database...something seems to be wrong";
//            }
//        }

//        public static Portfolio GetPortfolio(SqlConnection con, int port, out bool status, out string message)
//        {
//            var prt = new Portfolio();
//            string query = "Select * from Portfolio where POID = @poid"; // the string query we will give the database to execute
//            if (TestConnection(con, out message))
//            {
//                status = true;
//                con.Open();
//                using (var cmd = new MySqlCommand(query, con))
//                {
//                    cmd.Parameters.AddWithValue("@poid", port);
//                    var dr = cmd.ExecuteReader();
//                    while (dr.Read())
//                    {
//                        prt.POID = dr["POID"].GetType().FullName == "System.DBNull" ? 0 : (int)dr["POID"];
//                        prt.Name = dr["Name"].GetType().FullName == "System.DBNull" ? "" : (string)dr["Name"];
//                        prt.Purpose = dr["Purpose"].GetType().FullName == "System.DBNull" ? "" : (string)dr["Purpose"];
//                    }
//                    dr.Close();
//                }
//                con.Close();
//                return prt;
//            }
//            else
//            {
//                status = false;
//                message += "Failed to connect to database...something seems to be wrong";
//                return prt;
//            }
//        }

//        public static List<Portfolio> GetPortfolios(MySqlConnection con, out bool status, out string message)
//        {
//            var portfolio = new List<Portfolio>(); // Create a List of Portfolio to hold values from the Database
//            const string query = "Select * from Portfolio"; // the string query we will give the database to execute
//            string errorMessage; // This will be the error message if things go wrong with the database

//            // Open Connection using the helper function to validate the database connectivity. If the connection is successful then open do what we need to with it.
//            if (TestConnection(con, out errorMessage))
//            {
//                status = true;
//                message = errorMessage;
//                con.Open();
//                using (var cmd = new MySqlCommand(query, con))
//                {
//                    var dr = cmd.ExecuteReader();
//                    while (dr.Read())
//                    {
//                        portfolio.Add(new Portfolio
//                        {
//                            POID = dr["POID"].GetType().FullName == "System.DBNull" ? 0 : (int)dr["POID"],
//                            Name = dr["Name"].GetType().FullName == "System.DBNull" ? "" : (string)dr["Name"],
//                            Purpose = dr["Purpose"].GetType().FullName == "System.DBNull" ? "" : (string)dr["Purpose"]
//                        });
//                    }
//                    dr.Close();
//                }
//                con.Close();
//                return portfolio;
//            }
//            status = false;
//            message = errorMessage;
//            return portfolio;
//        }

//        public static void DeletePortfolio(MySqlConnection con, int gone, out string message)
//        {
//            if (TestConnection(con, out message))
//            {
//                message += "We got it!!";
//                con.Open();
//                var query = "Delete from Portfolio where POID = @poid";
//                using (var cmd = new MySqlCommand(query, con))
//                {
//                    cmd.Parameters.AddWithValue("@poid", gone);
//                    cmd.ExecuteNonQuery();
//                }
//                con.Close();
//            }
//            else
//            {
//                message += "Failed to connect to database...something seems to be wrong";
//            }
//        }

//        public static void DeletePortfolio(MySqlConnection con, int[] gone, out string message)
//        {
//            if (TestConnection(con, out message))
//            {
//                message += "We got it!!";
//                con.Open();
//                var query = "Delete from Portfolio where POID = @poid";
//                foreach (var id in gone)
//                {
//                    using (var cmd = new SqlCommand(query, con))
//                    {
//                        cmd.Parameters.AddWithValue("@poid", id);
//                        cmd.ExecuteNonQuery();
//                    }
//                }
//                con.Close();
//            }
//            else
//            {
//                message += "Failed to connect to database...something seems to be wrong";
//            }
//        }
//    }
//    #region
//    public class Vendor
//    {
//        public int VID { get; set; }
//        public string Name { get; set; }
//        public string VIN { get; set; }
//        public string Phone { get; set; }
//        public string Street { get; set; }
//        public string City { get; set; }
//        public string State { get; set; }
//        public string Zip { get; set; }
//        public string Country { get; set; }
//        public string Email { get; set; }

//    }
//    #endregion
//}