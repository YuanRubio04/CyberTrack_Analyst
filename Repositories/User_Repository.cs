using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberTrack_Analyst.Repositories
{
    public class User_Repository
    {
        private readonly string _connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\HP\\source\\repos\\Cybetrack_analyst\\CyberTrack_Database.mdf;Integrated Security=True";



        public List<User> GetUsers()
        {
            var users = new List<User>();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string sql = "SELECT UserID, FullName, Email, Role, Department, status FROM Users";
                var command = new System.Data.SqlClient.SqlCommand(sql, connection);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        User user = new User
                        {
                            UserID = reader["UserID"].ToString(),
                            FullName = reader["FullName"].ToString(),
                            Email = reader["Email"].ToString(),
                            Role = reader["Role"].ToString(),
                            Department = reader["Department"].ToString(),
                            status = reader["status"].ToString()
                        };
                        users.Add(user);
                    }
                }
            }
            return users; //this will return the list of users to the caller
        }

        public User GetUser(int id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    string sql = "SELECT UserID, FullName, Email, RoleID, Department, status FROM Users WHERE UserID = @UserID";
                    var command = new System.Data.SqlClient.SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@UserID", id);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new User
                            {
                                UserID = reader["UserID"].ToString(),
                                FullName = reader["FullName"].ToString(),
                                Email = reader["Email"].ToString(),
                                Role = reader["RoleID"].ToString() == "1" ? "Admin" : reader["RoleID"].ToString() == "2" ? "Analyst" : "Reporter",
                                Department = reader["Department"].ToString(),
                                status = reader["status"].ToString()
                            };
                        }
                    }
                }
                return null; // Return null if user not found
            }
            catch (Exception ex)
            {
                // Log the exception (not implemented here)
                Console.WriteLine($"An error occurred: {ex.Message}");
                return null; // Return null in case of an error
            }
        }
    }
}
