using Solid.SRP.Correct.Dto;
using Solid.SRP.Correct.Interface;
using System.Data;
using System.Data.SqlClient;

namespace Solid.SRP.Correct.Repository
{
    public class UserRepository : IUserRepository
    {
        public void CreateUser(UserRequest newUser)
        {
            using (var cn = new SqlConnection())
            {
                var cmd = new SqlCommand();

                cn.ConnectionString = "ConnectionString";
                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO User (NAME, EMAIL, PASSWORD) VALUES (@name, @email, @password)";

                cmd.Parameters.AddWithValue("email", newUser.Email);
                cmd.Parameters.AddWithValue("password", newUser.Password);
                cmd.Parameters.AddWithValue("name", newUser.Name);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
