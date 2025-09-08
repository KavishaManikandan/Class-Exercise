using System;
using System.Data;
using System.Data.SqlClient;

namespace AdoNetDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = @"Server=YOUR_SERVER_NAME;Database=YOUR_DATABASE_NAME;Trusted_Connection=True;";

            // 1. SQL Connection & Command (Connected Architecture)
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    Console.WriteLine("Database Connected Successfully!");

                    // 2. Prevent SQL Injection using Parameterized Query
                    string query = "SELECT * FROM Users WHERE Username = @username";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        Console.Write("Enter Username to Search: ");
                        string input = Console.ReadLine();
                        cmd.Parameters.AddWithValue("@username", input);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Console.WriteLine($"ID: {reader["Id"]}, Username: {reader["Username"]}, Email: {reader["Email"]}");
                            }
                        }
                    }

                    // 3. Call Stored Procedure
                    using (SqlCommand cmd = new SqlCommand("GetAllUsers", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            Console.WriteLine("\nUsers from Stored Procedure:");
                            while (reader.Read())
                            {
                                Console.WriteLine($"ID: {reader["Id"]}, Username: {reader["Username"]}, Email: {reader["Email"]}");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }

            // 4. Disconnected Architecture: DataAdapter, DataSet, DataTable
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Users";
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "Users");

                Console.WriteLine("\nDisconnected Data (DataSet):");
                DataTable dt = ds.Tables["Users"];
                foreach (DataRow row in dt.Rows)
                {
                    Console.WriteLine($"ID: {row["Id"]}, Username: {row["Username"]}, Email: {row["Email"]}");
                }
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
